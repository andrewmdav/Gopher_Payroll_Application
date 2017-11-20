namespace GopherPayroll
{
    partial class frmAddEmployeeRecords
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPayrollEntry = new System.Windows.Forms.DataGridView();
            this.cboEmpNames = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtWeekEnding = new System.Windows.Forms.TextBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.sfdXML = new System.Windows.Forms.SaveFileDialog();
            this.pfdData = new System.Windows.Forms.PrintDialog();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            this.mnuAddRecord = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutOutputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollEntry)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.mnuAddRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(727, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPayrollEntry
            // 
            this.dgvPayrollEntry.AllowUserToAddRows = false;
            this.dgvPayrollEntry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            this.dgvPayrollEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayrollEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayrollEntry.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvPayrollEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayrollEntry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayrollEntry.GridColor = System.Drawing.Color.Black;
            this.dgvPayrollEntry.Location = new System.Drawing.Point(46, 329);
            this.dgvPayrollEntry.Name = "dgvPayrollEntry";
            this.dgvPayrollEntry.ReadOnly = true;
            this.dgvPayrollEntry.RowTemplate.Height = 24;
            this.dgvPayrollEntry.Size = new System.Drawing.Size(756, 150);
            this.dgvPayrollEntry.TabIndex = 13;
            // 
            // cboEmpNames
            // 
            this.cboEmpNames.FormattingEnabled = true;
            this.cboEmpNames.Location = new System.Drawing.Point(46, 92);
            this.cboEmpNames.Name = "cboEmpNames";
            this.cboEmpNames.Size = new System.Drawing.Size(191, 24);
            this.cboEmpNames.TabIndex = 0;
            this.cboEmpNames.Text = "Select Employee";
            this.cboEmpNames.SelectionChangeCommitted += new System.EventHandler(this.cboEmpNames_SelectionChangeCommitted);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Gold;
            this.lblError.Location = new System.Drawing.Point(46, 528);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 17);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "Error Message";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(6, 35);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(70, 17);
            this.lblPayRate.TabIndex = 16;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(129, 30);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.ReadOnly = true;
            this.txtPayRate.Size = new System.Drawing.Size(100, 22);
            this.txtPayRate.TabIndex = 0;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(129, 123);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(6, 128);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(103, 17);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "Hours Worked:";
            // 
            // txtWeekEnding
            // 
            this.txtWeekEnding.Location = new System.Drawing.Point(129, 82);
            this.txtWeekEnding.Name = "txtWeekEnding";
            this.txtWeekEnding.Size = new System.Drawing.Size(100, 22);
            this.txtWeekEnding.TabIndex = 1;
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(6, 70);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(96, 34);
            this.lblWeek.TabIndex = 21;
            this.lblWeek.Text = "Week Ending:\r\n(YYYYMMDD)\r\n";
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblPayRate);
            this.grpInputs.Controls.Add(this.txtWeekEnding);
            this.grpInputs.Controls.Add(this.txtPayRate);
            this.grpInputs.Controls.Add(this.lblWeek);
            this.grpInputs.Controls.Add(this.lblHours);
            this.grpInputs.Controls.Add(this.txtHours);
            this.grpInputs.ForeColor = System.Drawing.Color.Gold;
            this.grpInputs.Location = new System.Drawing.Point(46, 132);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(242, 163);
            this.grpInputs.TabIndex = 1;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Gold;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.Maroon;
            this.btnCommit.Location = new System.Drawing.Point(16, 110);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(94, 23);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "COMMIT";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(16, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnAdd);
            this.grpActions.Controls.Add(this.btnCommit);
            this.grpActions.ForeColor = System.Drawing.Color.Gold;
            this.grpActions.Location = new System.Drawing.Point(491, 132);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(125, 163);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions:";
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.btnPrint);
            this.grpOutputs.Controls.Add(this.btnExport);
            this.grpOutputs.ForeColor = System.Drawing.Color.Gold;
            this.grpOutputs.Location = new System.Drawing.Point(666, 132);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(136, 163);
            this.grpOutputs.TabIndex = 3;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Outputs:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Maroon;
            this.btnPrint.Location = new System.Drawing.Point(15, 107);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Gold;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Maroon;
            this.btnExport.Location = new System.Drawing.Point(15, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "XML FILE";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // sfdXML
            // 
            this.sfdXML.CreatePrompt = true;
            // 
            // pfdData
            // 
            this.pfdData.UseEXDialog = true;
            // 
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
            // 
            // mnuAddRecord
            // 
            this.mnuAddRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuAddRecord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.mnuAddRecord.Location = new System.Drawing.Point(0, 0);
            this.mnuAddRecord.Name = "mnuAddRecord";
            this.mnuAddRecord.Size = new System.Drawing.Size(841, 28);
            this.mnuAddRecord.TabIndex = 16;
            this.mnuAddRecord.Text = "HelpMenu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutActionsToolStripMenuItem,
            this.aboutOutputsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutActionsToolStripMenuItem
            // 
            this.aboutActionsToolStripMenuItem.Name = "aboutActionsToolStripMenuItem";
            this.aboutActionsToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.aboutActionsToolStripMenuItem.Text = "Actions";
            this.aboutActionsToolStripMenuItem.Click += new System.EventHandler(this.aboutActionsToolStripMenuItem_Click);
            // 
            // aboutOutputsToolStripMenuItem
            // 
            this.aboutOutputsToolStripMenuItem.Name = "aboutOutputsToolStripMenuItem";
            this.aboutOutputsToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.aboutOutputsToolStripMenuItem.Text = "Outputs";
            this.aboutOutputsToolStripMenuItem.Click += new System.EventHandler(this.aboutOutputsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(205, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gopher Payroll: Payroll Record Creation";
            // 
            // frmAddEmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cboEmpNames);
            this.Controls.Add(this.dgvPayrollEntry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mnuAddRecord);
            this.MainMenuStrip = this.mnuAddRecord;
            this.Name = "frmAddEmployeeRecords";
            this.Text = "Gopher Payroll::Add Employee Records";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEmployeeRecords_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEmployeeRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollEntry)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpOutputs.ResumeLayout(false);
            this.mnuAddRecord.ResumeLayout(false);
            this.mnuAddRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvPayrollEntry;
        private System.Windows.Forms.ComboBox cboEmpNames;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtWeekEnding;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdXML;
        private System.Windows.Forms.PrintDialog pfdData;
        private System.Drawing.Printing.PrintDocument pdPrint;
        private System.Windows.Forms.MenuStrip mnuAddRecord;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutOutputsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}