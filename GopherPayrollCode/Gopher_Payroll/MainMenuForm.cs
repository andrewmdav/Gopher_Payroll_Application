using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Form represents the "Home" screen for the Gopher Payroll application.  It allows the user
 * to select two other forms, the frmPayrollReview and the frmAddEmployeeRecords,
 * or exit the application.
 */

namespace GopherPayroll
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();            

        }

        //call the frmPayrollReview to browse payroll database data by employee
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmPayrollReview FormPayrollReview = new frmPayrollReview();

            FormPayrollReview.ShowDialog();
        }

        //verify decision to close form 
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgClose = new DialogResult();
            dlgClose = MessageBox.Show("Are you sure you want to exit?", "Confirm Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlgClose.Equals(DialogResult.Cancel))
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //call the frmAddEmployeeRecords to add weekly payroll records (record hours worked by time period)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployeeRecords FormAddEmployeeRecords = new frmAddEmployeeRecords();

            FormAddEmployeeRecords.ShowDialog();

        }
    }
}
