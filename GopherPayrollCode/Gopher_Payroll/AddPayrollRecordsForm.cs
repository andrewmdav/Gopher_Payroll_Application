using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

/*
 * Form allows the user to input weekly payroll records with text boxes, review their entries in a datagrid, and 
 * write the records to the database.  Additionally, they can output the new entries to an XML file or to a printed 
 * page. The user selects an employee from the combo box, adds the week ending and hours worked information to the text 
 * boxes, and clicks the ADD button to place the new record proposal into a data grid viewer.  The user can reveiw their 
 * entries after adding multiple records across different employees, write to an XML FILE and/or PRINT, and then COMMIT 
 * to the database.  This class leverages the clsDatabase class to retrieve/record database information.
 */


namespace GopherPayroll
{
    public partial class frmAddEmployeeRecords : Form
    {
        DataTable dtNewData;
        Decimal decPayRate;

        public frmAddEmployeeRecords()
        {
            InitializeComponent();
        }

        //calls the functions that load employee names to the combo box, display the 
        //hourly rate of the selected employee, and create the underlying table for the data grid.
        private void frmAddEmployeeRecords_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            LoadEmployeeNames();
            CreateDataTable();            
        }

        //loads employee names into the combo box and calls GetEmployeePayrate() to 
        //fill in the selected employee's payrate
        private void LoadEmployeeNames()
        {
            DataSet dsData;

            ////use clsDatabase class fill a data set with employee names
            dsData = clsDatabase.LoadEmployeeNames();

            //test for null data set and bind data set to comobo box
            if(dsData == null)
            {
                lblError.Text = "No data set returned";
            }
            else if(dsData.Tables.Count<1)
            {
                lblError.Text = "No tables present in dataset.";
                dsData.Dispose();
            }
            else
            {
                //bind combo box to data source and set value/display members
                cboEmpNames.DataSource = dsData.Tables[0];
                cboEmpNames.ValueMember = "EmpID";
                cboEmpNames.DisplayMember = "FullName";
            }
            
            //verify that the combo box loaded and retrieve payrate
            if (cboEmpNames.Items.Count>0)
            {
                //use cbo selection to fill dgv
                GetEmployeePayrate(Convert.ToInt32(cboEmpNames.SelectedValue));
            }
        }

        //loads an employee payrate into the txtPayRate text box
        private void GetEmployeePayrate(Int32 intEmpID)
        {
            //use clsDatabase class to retrieve the payrate from the database
            decPayRate = clsDatabase.GetEmployeePayrate(intEmpID);

            if(decPayRate == -1)
            {
                lblError.Text = "No payrate data returned.";
            }
            else
            {
                txtPayRate.Text = decPayRate.ToString("C2");
            }
        }

        //create source data table for the data grid viewer 
        private void CreateDataTable()
        {           
            dtNewData = new DataTable("NewDataEntry");

            //create columns
            dtNewData.Columns.Add("Emp ID", typeof(int));
            dtNewData.Columns.Add("Employee Name", typeof(string));
            dtNewData.Columns.Add("Week Ending", typeof(string));
            dtNewData.Columns.Add("Hours Worked", typeof(string));
            dtNewData.Columns.Add("Total Pay", typeof(string));
            
            //Bind data table to data grid as the data source
            dgvPayrollEntry.DataSource = dtNewData;

            //limit user control over data grid
            dgvPayrollEntry.AllowUserToAddRows = false;
            dgvPayrollEntry.AllowUserToDeleteRows = false;
            dgvPayrollEntry.AllowUserToOrderColumns = false;

            //set column widths
            dgvPayrollEntry.Columns[0].Width = 50;
            dgvPayrollEntry.Columns[1].Width = 150;
            dgvPayrollEntry.Columns[2].Width = 100;
            dgvPayrollEntry.Columns[3].Width = 100;
            dgvPayrollEntry.Columns[4].Width = 100;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //verify decision to close form 
        private void frmAddEmployeeRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgClose = new DialogResult();
            dlgClose = MessageBox.Show("Are you sure you want to exit?", "Confirm Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dlgClose.Equals(DialogResult.Cancel))
            {
                e.Cancel = true;
            }
        }

        //retrieve a new payrate and clear the hours text box with a combo box selection change
        private void cboEmpNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (cboEmpNames.Items.Count > 0)
            {
                //update pay rate with selection change
                GetEmployeePayrate(Convert.ToInt32(cboEmpNames.SelectedValue));
                
                //erase the hours text and leave week ending to expedite faster entry (same period for different employee)
                txtHours.Text = "";
            }
        }

        //adds user input data to the data grid for review and calculates/displays total weekly pay for the new record        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal decCalcPay;             //total pay for the hours worked given the employee's pay rate
            Decimal decHoursWorked = 0M;    //decimal value to store hours worked converted from user input text string
            Decimal decWeekEnding = 0M;     //decimal value to store week ending converted from user input text string
            DataRow  drNewRow;              //new row to collect input data and append to data table            
            Boolean isError = false;        //boolean to flag errors

            lblError.Text = "";

            //**Begin sequential validation**

            //validate employee selected for positive employee id
            if (Convert.ToInt32(cboEmpNames.SelectedValue) < 0)
            {
                lblError.Text = "No employee id selected.";
                isError = true;
                return;
            }

            //validate week ending for numerical input and length
            if (!Decimal.TryParse(txtWeekEnding.Text, out decWeekEnding) || txtWeekEnding.Text.Length != 8)
            {
                lblError.Text = "Input error in week ending field.  Please use YYYYMMDD format.";
                isError = true;
                return;
            }

            //validate hours entry for numerical input and length
            if (!Decimal.TryParse(txtHours.Text, out decHoursWorked) || txtHours.Text.Length > 8 || txtHours.Text.Length < 1)
            {
                lblError.Text = "Input error in hours field.  Please input a number between one and eight digits long.";
                isError = true;
                return;
            }       
            
            //validate pay rate            
            if (decPayRate == -1)
            { 
                lblError.Text = "No payrate data returned.";
                isError = true;
                return;
            }
            //**end sequential validation**

            //if no errors detected, calculate pay, fill a new row, and add the new row to the data table bound 
            //to the data grid
            //checked the error flag (even though it should not be triggered given the return statements above)
            if (!isError)
            {
                decCalcPay = decHoursWorked * decPayRate;
                drNewRow = dtNewData.NewRow();

                //fill the new data row
                drNewRow["Emp ID"] = cboEmpNames.SelectedValue.ToString();
                drNewRow["Employee Name"] = cboEmpNames.Text.ToString();
                drNewRow["Week Ending"] = decWeekEnding.ToString();
                drNewRow["Hours Worked"] = decHoursWorked.ToString();
                drNewRow["Total Pay"] = decCalcPay.ToString() ;

                //add new row to data table
                dtNewData.Rows.Add(drNewRow);                
            }
        }

        //validate and commit new input records into the database
        private void btnCommit_Click(object sender, EventArgs e)
        {
            int EmpID;
            String strWeekEnding = null;
            Decimal decHoursWorked = 0;     //decimal value to store hours worked converted from text string
            int ctr=0;                      //counts the number of rows successfully committed for a confirmation message to the user

            //clear error text
            lblError.Text = "";
            
            //check for null table and rows and add each row to the database using clsDatabase class
            //collect the number of rows successfully added to the database in the ctr variable and 
            //display the result for the user
            if (dtNewData != null && dtNewData.Rows.Count > 0)
            {                           
                //loop through each new employee record staged in the data grid table and insert into the database
                foreach(DataRow row in dtNewData.Rows)
                {
                    EmpID = Convert.ToInt32(row["Emp ID"]);
                    strWeekEnding = row["Week Ending"].ToString();
                    decHoursWorked = Convert.ToDecimal(row["Hours Worked"]);

                    //use clsDatabase class to insert new payroll records to the database
                    ctr += clsDatabase.InsertPayroll(EmpID, strWeekEnding, decHoursWorked);                        
                }

                lblError.Text = "You inserted " + ctr + " rows successfully";

                //refresh data table (erase/rebuild) 
                CreateDataTable();
            }
            else
            {
                lblError.Text = "No records loaded to viewer.  Input payroll record information, click add, and then click commit.";
            }
        }

        //use a save-file dialog and write the new records to an XML file at the designated location
        private void btnExport_Click(object sender, EventArgs e)
        {
            lblError.Text = "";           

            //check for new records, call the save-file-dialog, and write the table to an XML file
            if (dtNewData == null || dtNewData.Rows.Count<1)
            {
                lblError.Text = "No data loaded in the data grid.";
            }
            else
            {
                DialogResult dlgAnswer;

                //set generic save file dialog box to specifically focus on xml files
                sfdXML.Filter = "XML Files(*.xml)|*xml|All files(*.*)|*.*";
                sfdXML.DefaultExt = ".xml";
                //sfdXML.InitialDirectory = "C:\\Users\\Andrew\\Documents\\HTC\\CCIS 2585 - .Net II\\Projects\\Project 3 - PayrollDB Update";
                sfdXML.OverwritePrompt = true;
                sfdXML.Title = "Save New Payroll Entries in XML";

                dlgAnswer = sfdXML.ShowDialog();

                //at dialog confirmation, write dtNewData to XML file
                if (dlgAnswer == DialogResult.OK)
                {
                    //the data table or data set object writes out based on sfd result
                    dtNewData.WriteXml(sfdXML.FileName);

                    lblError.Text = "Data written to XML file.";
                }
            }            
        }

        //call a print file dialog, transfer its properties to a print document object, and call pdPrint.Print()
        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            //test whether input exists in the data table
            if(dtNewData == null || dtNewData.Rows.Count < 1)
            {
                lblError.Text = "No data in data table to print.";
            }
            else
            {
                DialogResult drResponse;
                drResponse = pfdData.ShowDialog();

                //if user selects "ok," transfer settings, call print function, and confirm print to user
                if (drResponse == DialogResult.OK)
                {
                    pdPrint.PrinterSettings = pfdData.PrinterSettings;
                    pdPrint.Print();
                    lblError.Text = "Data printed.";
                }
            }            
        }

        //uses drawing tool to write headings, table data, and totals to a printed page
        private void pdPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fDocBold, fDocBoldUndln, fDoc;                         //table title, header, and body fonts 
            Single[] sglXPos = new Single[] { 90, 180, 350, 500, 650};  //array for "standard" x-positions of table data            
            Single sglYPos = Convert.ToSingle(75);                      //y-position with starting value
            Int32 intRowCount = 0;                                      //table row counter variable to print in report summary
            Decimal decTotalValue = 0M;                                 //total value of payroll dollars to print in report summary
            Brush brushBlack = System.Drawing.Brushes.Black;            //black brush for writing the report
            String strTitle;                                            //title of report

            strTitle = "New Payroll Record Additions";

            fDoc = new Font("Times New Roman", 12);
            fDocBold = new Font("Times New Roman Bold", 14);
            

            //write header
            e.Graphics.DrawString(strTitle, fDocBold, brushBlack, Convert.ToSingle(250), sglYPos);
            sglYPos += fDoc.Height;     //change y-position by the amount of the font height
            e.Graphics.DrawString(System.DateTime.Now.ToShortDateString(), fDocBold, brushBlack, Convert.ToSingle(330), sglYPos);

            //adjust y-position, change font, and write col headers at the positons in the sglXPos array
            sglYPos += (fDoc.Height * 4);

            fDocBold = new Font("Times New Roman Bold", 12);
            fDocBoldUndln = new Font(fDocBold, FontStyle.Underline);
            
            e.Graphics.DrawString("Emp ID", fDocBoldUndln, brushBlack, sglXPos[0], sglYPos);
            e.Graphics.DrawString("Employee Name", fDocBoldUndln, brushBlack, sglXPos[1], sglYPos);
            e.Graphics.DrawString("Week Ending", fDocBoldUndln, brushBlack, sglXPos[2], sglYPos);
            e.Graphics.DrawString("Hours Worked", fDocBoldUndln, brushBlack, sglXPos[3], sglYPos);
            e.Graphics.DrawString("Total Pay", fDocBoldUndln, brushBlack, sglXPos[4], sglYPos);

            //adjust y-position
            sglYPos += fDoc.Height;

            // write each data row from table, while summing row count and total pay, and adjusting position
            //loop through rows in table
            foreach (DataRow row in dtNewData.Rows)
            {
                //loop through columns in table
                for (int i = 0; i < sglXPos.Length; i++)
                {
                    //write row data to page (convert Total Pay column to assist with formatting)
                    if (row[i] == row["Total Pay"])
                    {
                        Decimal decRowPay = Convert.ToDecimal(row["Total Pay"]);
                        e.Graphics.DrawString(decRowPay.ToString("C2"), fDoc, brushBlack, sglXPos[i], sglYPos);
                    }
                    else
                    {
                        e.Graphics.DrawString(row[i].ToString(), fDoc, brushBlack, sglXPos[i], sglYPos);
                    }
                }
                sglYPos += fDoc.Height;
                intRowCount++;
                decTotalValue += Convert.ToDecimal(row["Total Pay"]);
            }

            //write totals in summary area of report
            sglYPos += fDoc.Height*2;
            e.Graphics.DrawString("Total Pay for Entries: " + decTotalValue.ToString("C2"), fDocBold, brushBlack, sglXPos[0], sglYPos);
            sglYPos += fDoc.Height;
            e.Graphics.DrawString("Number of Entries: " + intRowCount.ToString(), fDocBold, brushBlack, sglXPos[0], sglYPos);

        }
        
        //describes the "Actions" group of buttons
        private void aboutActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strAdd = "ADD Button places new entries, based on inputs, into the viewing window.  " +
                "Multiple entries for different employees can be added to the window.\n\n" +
                "COMMIT Button records the entries from the veiwing window into the database and refreshes" +
                " the viewing window.  Entries are not saved until committed.";

            MessageBox.Show(strAdd, "About Actions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //describes the "Outputs" group of buttons
        private void aboutOutputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strOutput = "XML FILE Button creates an XML file of the new entries in the viewing window.\n\n" +
                "PRINT Button formats the new entries in the viewing window as output on a printed page.\n\n" +
                "Entries are not saved to the database until committed.";

            MessageBox.Show(strOutput, "About Outputs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
