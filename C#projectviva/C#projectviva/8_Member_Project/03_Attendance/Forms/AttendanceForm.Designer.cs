namespace TeaEstate
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnShowDay = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnMonthlySummary = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
  
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(764, 46);
            this.pnlHeader.TabIndex = 0;
         
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Attendance";
          
            this.grpDetails.Controls.Add(this.lblWorker);
            this.grpDetails.Controls.Add(this.cmbWorker);
            this.grpDetails.Controls.Add(this.lblDate);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.lblStatus);
            this.grpDetails.Controls.Add(this.cmbStatus);
            this.grpDetails.Controls.Add(this.btnMark);
            this.grpDetails.Controls.Add(this.btnShowDay);
            this.grpDetails.Location = new System.Drawing.Point(12, 56);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(360, 170);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Mark Attendance";
        
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(15, 30);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 15);
            this.lblWorker.TabIndex = 0;
            this.lblWorker.Text = "Worker:";

            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.Location = new System.Drawing.Point(120, 26);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(190, 23);
            this.cmbWorker.TabIndex = 1;
       
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";

            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(120, 60);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 23);
            this.dtpDate.TabIndex = 3;
       
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
       
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(120, 94);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 23);
            this.cmbStatus.TabIndex = 5;
       
            this.btnMark.Location = new System.Drawing.Point(120, 128);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(92, 30);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
    
            this.btnShowDay.Location = new System.Drawing.Point(218, 128);
            this.btnShowDay.Name = "btnShowDay";
            this.btnShowDay.Size = new System.Drawing.Size(92, 30);
            this.btnShowDay.TabIndex = 7;
            this.btnShowDay.Text = "Show Day";
            this.btnShowDay.UseVisualStyleBackColor = true;
            this.btnShowDay.Click += new System.EventHandler(this.btnShowDay_Click);
         
            this.grpSummary.Controls.Add(this.lblMonth);
            this.grpSummary.Controls.Add(this.cmbMonth);
            this.grpSummary.Controls.Add(this.lblYear);
            this.grpSummary.Controls.Add(this.cmbYear);
            this.grpSummary.Controls.Add(this.btnMonthlySummary);
            this.grpSummary.Location = new System.Drawing.Point(384, 56);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(372, 170);
            this.grpSummary.TabIndex = 2;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Monthly Summary";
       
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(15, 30);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(46, 15);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
           
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Location = new System.Drawing.Point(120, 26);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(190, 23);
            this.cmbMonth.TabIndex = 1;
          
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(15, 64);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 15);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
      
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Location = new System.Drawing.Point(120, 60);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(190, 23);
            this.cmbYear.TabIndex = 3;
        
            this.btnMonthlySummary.Location = new System.Drawing.Point(120, 128);
            this.btnMonthlySummary.Name = "btnMonthlySummary";
            this.btnMonthlySummary.Size = new System.Drawing.Size(120, 30);
            this.btnMonthlySummary.TabIndex = 4;
            this.btnMonthlySummary.Text = "Show Summary";
            this.btnMonthlySummary.UseVisualStyleBackColor = true;
            this.btnMonthlySummary.Click += new System.EventHandler(this.btnMonthlySummary_Click);
          
            this.lblGrid.AutoSize = true;
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGrid.Location = new System.Drawing.Point(12, 234);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(73, 15);
            this.lblGrid.TabIndex = 3;
            this.lblGrid.Text = "Attendance";

            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(12, 256);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(744, 234);
            this.dgvAttendance.TabIndex = 4;
      
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 502);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Estate — Attendance";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnShowDay;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnMonthlySummary;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}
