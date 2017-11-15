namespace GopherPayroll
{
    partial class frmPayrollReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.splDisplayEmpl = new System.Windows.Forms.SplitContainer();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMidInitial = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpNav = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splDisplayEmpl)).BeginInit();
            this.splDisplayEmpl.Panel1.SuspendLayout();
            this.splDisplayEmpl.Panel2.SuspendLayout();
            this.splDisplayEmpl.SuspendLayout();
            this.grpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Gold;
            this.btnFirst.ForeColor = System.Drawing.Color.Maroon;
            this.btnFirst.Location = new System.Drawing.Point(100, 42);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "FIRST";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(764, 716);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Gold;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Maroon;
            this.btnLast.Location = new System.Drawing.Point(478, 42);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = "LAST";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gold;
            this.btnNext.ForeColor = System.Drawing.Color.Maroon;
            this.btnNext.Location = new System.Drawing.Point(352, 42);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gold;
            this.btnPrevious.ForeColor = System.Drawing.Color.Maroon;
            this.btnPrevious.Location = new System.Drawing.Point(226, 42);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "PREV";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(35, 719);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(104, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error Message!";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.GridColor = System.Drawing.Color.Black;
            this.dgvEmployee.Location = new System.Drawing.Point(18, 96);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(730, 223);
            this.dgvEmployee.TabIndex = 6;
            // 
            // splDisplayEmpl
            // 
            this.splDisplayEmpl.Location = new System.Drawing.Point(214, 50);
            this.splDisplayEmpl.Name = "splDisplayEmpl";
            // 
            // splDisplayEmpl.Panel1
            // 
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblPayRate);
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblSSN);
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblFName);
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblLName);
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblMidInitial);
            this.splDisplayEmpl.Panel1.Controls.Add(this.lblID);
            // 
            // splDisplayEmpl.Panel2
            // 
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtPayRate);
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtSN);
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtMiddleInitial);
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtLName);
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtFName);
            this.splDisplayEmpl.Panel2.Controls.Add(this.txtID);
            this.splDisplayEmpl.Size = new System.Drawing.Size(441, 295);
            this.splDisplayEmpl.SplitterDistance = 147;
            this.splDisplayEmpl.TabIndex = 7;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(14, 265);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(97, 20);
            this.lblPayRate.TabIndex = 5;
            this.lblPayRate.Text = "Pay Rate: ";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(14, 217);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(58, 20);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN: ";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(14, 73);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(114, 20);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name: ";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(14, 123);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(112, 20);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name: ";
            // 
            // lblMidInitial
            // 
            this.lblMidInitial.AutoSize = true;
            this.lblMidInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidInitial.Location = new System.Drawing.Point(14, 173);
            this.lblMidInitial.Name = "lblMidInitial";
            this.lblMidInitial.Size = new System.Drawing.Size(128, 20);
            this.lblMidInitial.TabIndex = 1;
            this.lblMidInitial.Text = "Middle Initial: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(14, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID: ";
            // 
            // txtPayRate
            // 
            this.txtPayRate.BackColor = System.Drawing.Color.White;
            this.txtPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.ForeColor = System.Drawing.Color.Black;
            this.txtPayRate.Location = new System.Drawing.Point(53, 259);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(171, 26);
            this.txtPayRate.TabIndex = 5;
            // 
            // txtSN
            // 
            this.txtSN.BackColor = System.Drawing.Color.White;
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.ForeColor = System.Drawing.Color.Black;
            this.txtSN.Location = new System.Drawing.Point(53, 211);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(171, 26);
            this.txtSN.TabIndex = 4;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BackColor = System.Drawing.Color.White;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleInitial.Location = new System.Drawing.Point(53, 167);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(171, 26);
            this.txtMiddleInitial.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.White;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Black;
            this.txtLName.Location = new System.Drawing.Point(53, 117);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(171, 26);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Black;
            this.txtFName.Location = new System.Drawing.Point(53, 67);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(171, 26);
            this.txtFName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(53, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 26);
            this.txtID.TabIndex = 0;
            // 
            // grpNav
            // 
            this.grpNav.Controls.Add(this.btnFirst);
            this.grpNav.Controls.Add(this.btnLast);
            this.grpNav.Controls.Add(this.btnNext);
            this.grpNav.Controls.Add(this.dgvEmployee);
            this.grpNav.Controls.Add(this.btnPrevious);
            this.grpNav.ForeColor = System.Drawing.Color.Gold;
            this.grpNav.Location = new System.Drawing.Point(48, 381);
            this.grpNav.Name = "grpNav";
            this.grpNav.Size = new System.Drawing.Size(774, 325);
            this.grpNav.TabIndex = 9;
            this.grpNav.TabStop = false;
            this.grpNav.Text = "Payroll Naigation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gopher Payroll: Employee Record Review";
            // 
            // frmPayrollReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(874, 760);
            this.Controls.Add(this.grpNav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splDisplayEmpl);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "frmPayrollReview";
            this.Text = "Gopher Payroll::Employee Review";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGopherPayroll_FormClosing);
            this.Load += new System.EventHandler(this.frmGopherPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.splDisplayEmpl.Panel1.ResumeLayout(false);
            this.splDisplayEmpl.Panel1.PerformLayout();
            this.splDisplayEmpl.Panel2.ResumeLayout(false);
            this.splDisplayEmpl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splDisplayEmpl)).EndInit();
            this.splDisplayEmpl.ResumeLayout(false);
            this.grpNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.SplitContainer splDisplayEmpl;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMidInitial;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpNav;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label label1;
    }
}

