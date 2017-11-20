using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

/*
 * Form allows the user to navigate the employees in the payroll database and review their weekly
 * records.  Two tables in the database are accessed, utilizing the clsDatabase class for database
 * connection and dataset/table retrieval.  The read-only text boxes are linked to the employee
 * identification information, while the data grid is tied to the selected employee's payroll
 * records.
 */

namespace GopherPayroll
{
    public partial class frmPayrollReview : Form
    {
        //Global Variables
        DataSet dsEmpInfo = null;      //data set returning employee information (name, SSN, etc.)
        DataSet dsEmpRecords = null;   //data set returning employee weekly payroll records (e.g hours worked)
        Int32 intCurrRow = 0;
        Int32 intEmployeeID = 0;

        public frmPayrollReview()
        {
            InitializeComponent();                      
        }

        //loads the identification information and payroll records of the first employee in the database  
        private void frmGopherPayroll_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            lblError.Text = "";
        }

        //display the first employee in the payroll database employee list 
        private void btnFirst_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = 0;
            ShowEmployee();
        }

        //display the previous employee in the payroll database employee list (with circular looping)
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            intCurrRow--;

            if (intCurrRow < 0)
            {
                intCurrRow = dsEmpInfo.Tables[0].Rows.Count - 1;
            }

            ShowEmployee();
        }

        //display the next employee in the payroll database employee list (with circular looping)        
        private void btnNext_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            intCurrRow++;

            if (intCurrRow > dsEmpInfo.Tables[0].Rows.Count - 1)
            {
                intCurrRow = 0;
            }
            ShowEmployee();
        }

        //go to the last employee in the payroll database employee list 
        private void btnLast_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            intCurrRow = dsEmpInfo.Tables[0].Rows.Count - 1;
            ShowEmployee();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //called at form load to initially validate the employee data set, enabling the navigation if successful,
        //and calling ShowEmployee()
        public void LoadEmployee()
        {                        
            ClearForm();    //clears employee information text boxes
            DisableNav();   //disable nav and re-enable at end of function with a successfull data load

            //Clear global dataset in case of uncleared data
            if (dsEmpInfo != null)
            {
                dsEmpInfo.Dispose();
            }
            
            //return the employee information to the dataset 
            dsEmpInfo = clsDatabase.getEmployeeDBDataSet();

            //validate the data set, enable the navigation, and display the
            // employee information.  Display appropriate messages if errors detected. 
            if (dsEmpInfo == null)
            {
                lblError.Text = "***Database Retrieval Error: Null Dataset***";
            }
            else if(dsEmpInfo.Tables.Count < 1)
            {
                lblError.Text = "***Database Retrieval Error: No Tables in DB***";
                dsEmpInfo.Dispose();
                dsEmpInfo = null;
            }
            else if (dsEmpInfo.Tables[0].Rows.Count < 1)
            {
                lblError.Text = "***Database Retrieval Error: No Rows in DB Table***";                
                dsEmpInfo.Dispose();
                dsEmpInfo = null;
            }
            else
            {
                EnableNav();
                ShowEmployee();
            }
        }


        //display employee information in the text boxes and use the employee id of the selected employee to         
        //retrieve and display data records in the data grid. Only called if an "active" employee in the database
        //is retrieved
        public void ShowEmployee()
        {            
            //use current EmpID from Employee Table and pass it to the stored procedure that
            //retrieves employee information and payroll records for that employe.  
            intEmployeeID = Convert.ToInt32(dsEmpInfo.Tables[0].Rows[intCurrRow]["EmpID"]);
            dsEmpRecords = clsDatabase.getEmpPayrollDBDataSet(intEmployeeID);

            //convert ssn to masked look with dashes
            String strSSN = dsEmpInfo.Tables[0].Rows[intCurrRow]["SSAN"].ToString();
            strSSN = strSSN.Substring(0,3) + "-" + strSSN.Substring(3, 2) + "-" + strSSN.Substring(5, 3);

            //remove trailing zero's on payrate (could have also parsed and rounded)
            String strPayRate = dsEmpInfo.Tables[0].Rows[intCurrRow]["PayRate"].ToString();
            strPayRate = strPayRate.Substring(0, strPayRate.Length - 2);

            //fill text boxes with the selected employee's identification information
            txtID.Text = dsEmpInfo.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
            txtFName.Text = dsEmpInfo.Tables[0].Rows[intCurrRow]["FName"].ToString();
            txtLName.Text = dsEmpInfo.Tables[0].Rows[intCurrRow]["LName"].ToString();
            txtSN.Text = strSSN;
            txtPayRate.Text = strPayRate;

            //check for null middle initial to handle the database null value
            if (dsEmpInfo.Tables[0].Rows[0]["MInit"] == DBNull.Value)
            {
                txtMiddleInitial.Text = "";
            }
            else
            {
                txtMiddleInitial.Text = dsEmpInfo.Tables[0].Rows[intCurrRow]["MInit"].ToString();
            }
           
            //bind the retrieved employee records to the data grid
            dgvEmployee.DataSource = dsEmpRecords.Tables[0];            
        }

        //clear form field
        public void ClearForm()
        {
            txtID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMiddleInitial.Text = "";

        }

        //enables navigation for the user, called by LoadEmployee() at form load
        public void EnableNav()
        {
            txtID.Enabled = true;
            txtFName.Enabled = true;
            txtFName.Enabled = true;
            txtMiddleInitial.Enabled = true;
        }

        //disable navigation
        public void DisableNav()
        {
            txtID.Enabled = false;
            txtFName.Enabled = false;
            txtFName.Enabled = false;
            txtMiddleInitial.Enabled = false;
        }

        //verify decision to close form 
        private void frmGopherPayroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult userExitResponse;

            userExitResponse = MessageBox.Show("Are you sure that you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (userExitResponse == DialogResult.OK)
            {
                this.ClearForm();
                dsEmpInfo.Dispose();
                dsEmpRecords.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
