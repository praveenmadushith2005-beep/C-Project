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

        // Required method for Designer support — do not modify the contents of this
        // method with the code editor; edit it on the design surface instead.
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpDetails = new GroupBox();
            lblWorker = new Label();
            cmbWorker = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnMark = new Button();
            btnShowDay = new Button();
            grpSummary = new GroupBox();
            lblMonth = new Label();
            cmbMonth = new ComboBox();
            lblYear = new Label();
            cmbYear = new ComboBox();
            btnMonthlySummary = new Button();
            lblGrid = new Label();
            dgvAttendance = new DataGridView();
            pnlHeader.SuspendLayout();
            grpDetails.SuspendLayout();
            grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(34, 139, 34);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(873, 61);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Attendance";
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblWorker);
            grpDetails.Controls.Add(cmbWorker);
            grpDetails.Controls.Add(lblDate);
            grpDetails.Controls.Add(dtpDate);
            grpDetails.Controls.Add(lblStatus);
            grpDetails.Controls.Add(cmbStatus);
            grpDetails.Controls.Add(btnMark);
            grpDetails.Controls.Add(btnShowDay);
            grpDetails.Location = new Point(14, 75);
            grpDetails.Margin = new Padding(3, 4, 3, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(3, 4, 3, 4);
            grpDetails.Size = new Size(411, 227);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Mark Attendance";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Location = new Point(17, 40);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(59, 20);
            lblWorker.TabIndex = 0;
            lblWorker.Text = "Worker:";
            // 
            // cmbWorker
            // 
            cmbWorker.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorker.Location = new Point(137, 35);
            cmbWorker.Margin = new Padding(3, 4, 3, 4);
            cmbWorker.Name = "cmbWorker";
            cmbWorker.Size = new Size(217, 28);
            cmbWorker.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(17, 85);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(137, 80);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(217, 27);
            dtpDate.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 131);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(137, 125);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(217, 28);
            cmbStatus.TabIndex = 5;
            // 
            // btnMark
            // 
            btnMark.Location = new Point(137, 171);
            btnMark.Margin = new Padding(3, 4, 3, 4);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(105, 40);
            btnMark.TabIndex = 6;
            btnMark.Text = "Mark";
            btnMark.UseVisualStyleBackColor = true;
            btnMark.Click += btnMark_Click;
            // 
            // btnShowDay
            // 
            btnShowDay.Location = new Point(249, 171);
            btnShowDay.Margin = new Padding(3, 4, 3, 4);
            btnShowDay.Name = "btnShowDay";
            btnShowDay.Size = new Size(105, 40);
            btnShowDay.TabIndex = 7;
            btnShowDay.Text = "Show Day";
            btnShowDay.UseVisualStyleBackColor = true;
            btnShowDay.Click += btnShowDay_Click;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblMonth);
            grpSummary.Controls.Add(cmbMonth);
            grpSummary.Controls.Add(lblYear);
            grpSummary.Controls.Add(cmbYear);
            grpSummary.Controls.Add(btnMonthlySummary);
            grpSummary.Location = new Point(439, 75);
            grpSummary.Margin = new Padding(3, 4, 3, 4);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(3, 4, 3, 4);
            grpSummary.Size = new Size(425, 227);
            grpSummary.TabIndex = 2;
            grpSummary.TabStop = false;
            grpSummary.Text = "Monthly Summary";
            grpSummary.Enter += grpSummary_Enter;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(17, 40);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(55, 20);
            lblMonth.TabIndex = 0;
            lblMonth.Text = "Month:";
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Location = new Point(137, 35);
            cmbMonth.Margin = new Padding(3, 4, 3, 4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(217, 28);
            cmbMonth.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(17, 85);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year:";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Location = new Point(137, 80);
            cmbYear.Margin = new Padding(3, 4, 3, 4);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(217, 28);
            cmbYear.TabIndex = 3;
            // 
            // btnMonthlySummary
            // 
            btnMonthlySummary.Location = new Point(137, 171);
            btnMonthlySummary.Margin = new Padding(3, 4, 3, 4);
            btnMonthlySummary.Name = "btnMonthlySummary";
            btnMonthlySummary.Size = new Size(137, 40);
            btnMonthlySummary.TabIndex = 4;
            btnMonthlySummary.Text = "Show Summary";
            btnMonthlySummary.UseVisualStyleBackColor = true;
            btnMonthlySummary.Click += btnMonthlySummary_Click;
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGrid.Location = new Point(14, 312);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(90, 20);
            lblGrid.TabIndex = 3;
            lblGrid.Text = "Attendance";
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(14, 341);
            dgvAttendance.Margin = new Padding(3, 4, 3, 4);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(850, 312);
            dgvAttendance.TabIndex = 4;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 669);
            Controls.Add(dgvAttendance);
            Controls.Add(lblGrid);
            Controls.Add(grpSummary);
            Controls.Add(grpDetails);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tea Estate — Attendance";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
