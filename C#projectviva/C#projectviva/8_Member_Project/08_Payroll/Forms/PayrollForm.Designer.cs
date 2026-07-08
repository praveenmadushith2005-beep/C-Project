namespace TeaEstate
{
    partial class PayrollForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblDaysWorked = new System.Windows.Forms.Label();
            this.txtDaysWorked = new System.Windows.Forms.TextBox();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.lblYieldBonus = new System.Windows.Forms.Label();
            this.txtYieldBonus = new System.Windows.Forms.TextBox();
            this.lblPaidDate = new System.Windows.Forms.Label();
            this.dtpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 46);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll / Salary";
            //
            // grpDetails
            //
            this.grpDetails.Controls.Add(this.lblWorker);
            this.grpDetails.Controls.Add(this.cmbWorker);
            this.grpDetails.Controls.Add(this.lblMonth);
            this.grpDetails.Controls.Add(this.txtMonth);
            this.grpDetails.Controls.Add(this.lblDaysWorked);
            this.grpDetails.Controls.Add(this.txtDaysWorked);
            this.grpDetails.Controls.Add(this.lblDailyRate);
            this.grpDetails.Controls.Add(this.txtDailyRate);
            this.grpDetails.Controls.Add(this.lblYieldBonus);
            this.grpDetails.Controls.Add(this.txtYieldBonus);
            this.grpDetails.Controls.Add(this.lblPaidDate);
            this.grpDetails.Controls.Add(this.dtpPaidDate);
            this.grpDetails.Controls.Add(this.lblTotalCaption);
            this.grpDetails.Controls.Add(this.lblTotal);
            this.grpDetails.Location = new System.Drawing.Point(12, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(360, 290);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            //
            // lblWorker
            //
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(16, 31);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 15);
            this.lblWorker.TabIndex = 0;
            this.lblWorker.Text = "Worker:";
            //
            // cmbWorker
            //
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(130, 28);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 23);
            this.cmbWorker.TabIndex = 1;
            //
            // lblMonth
            //
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(16, 65);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(101, 15);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month (yyyy-MM):";
            //
            // txtMonth
            //
            this.txtMonth.Location = new System.Drawing.Point(130, 62);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(200, 23);
            this.txtMonth.TabIndex = 3;
            //
            // lblDaysWorked
            //
            this.lblDaysWorked.AutoSize = true;
            this.lblDaysWorked.Location = new System.Drawing.Point(16, 99);
            this.lblDaysWorked.Name = "lblDaysWorked";
            this.lblDaysWorked.Size = new System.Drawing.Size(80, 15);
            this.lblDaysWorked.TabIndex = 4;
            this.lblDaysWorked.Text = "Days Worked:";
            //
            // txtDaysWorked
            //
            this.txtDaysWorked.Location = new System.Drawing.Point(130, 96);
            this.txtDaysWorked.Name = "txtDaysWorked";
            this.txtDaysWorked.Size = new System.Drawing.Size(200, 23);
            this.txtDaysWorked.TabIndex = 5;
            //
            // lblDailyRate
            //
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(16, 133);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(63, 15);
            this.lblDailyRate.TabIndex = 6;
            this.lblDailyRate.Text = "Daily Rate:";
            //
            // txtDailyRate
            //
            this.txtDailyRate.Location = new System.Drawing.Point(130, 130);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(200, 23);
            this.txtDailyRate.TabIndex = 7;
            //
            // lblYieldBonus
            //
            this.lblYieldBonus.AutoSize = true;
            this.lblYieldBonus.Location = new System.Drawing.Point(16, 167);
            this.lblYieldBonus.Name = "lblYieldBonus";
            this.lblYieldBonus.Size = new System.Drawing.Size(75, 15);
            this.lblYieldBonus.TabIndex = 8;
            this.lblYieldBonus.Text = "Yield Bonus:";
            //
            // txtYieldBonus
            //
            this.txtYieldBonus.Location = new System.Drawing.Point(130, 164);
            this.txtYieldBonus.Name = "txtYieldBonus";
            this.txtYieldBonus.Size = new System.Drawing.Size(200, 23);
            this.txtYieldBonus.TabIndex = 9;
            //
            // lblPaidDate
            //
            this.lblPaidDate.AutoSize = true;
            this.lblPaidDate.Location = new System.Drawing.Point(16, 201);
            this.lblPaidDate.Name = "lblPaidDate";
            this.lblPaidDate.Size = new System.Drawing.Size(60, 15);
            this.lblPaidDate.TabIndex = 10;
            this.lblPaidDate.Text = "Paid Date:";
            //
            // dtpPaidDate
            //
            this.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaidDate.Location = new System.Drawing.Point(130, 198);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Size = new System.Drawing.Size(200, 23);
            this.dtpPaidDate.TabIndex = 11;
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 240);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(36, 15);
            this.lblTotalCaption.TabIndex = 12;
            this.lblTotalCaption.Text = "Total:";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblTotal.Location = new System.Drawing.Point(127, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0.00";
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(12, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 30);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(112, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(212, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(312, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(412, 356);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvSalary
            //
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.AllowUserToResizeRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(12, 396);
            this.dgvSalary.MultiSelect = false;
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(756, 132);
            this.dgvSalary.TabIndex = 7;
            this.dgvSalary.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            //
            // PayrollForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.dgvSalary);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Estate — Payroll / Salary";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblDaysWorked;
        private System.Windows.Forms.TextBox txtDaysWorked;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.Label lblYieldBonus;
        private System.Windows.Forms.TextBox txtYieldBonus;
        private System.Windows.Forms.Label lblPaidDate;
        private System.Windows.Forms.DateTimePicker dtpPaidDate;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSalary;
    }
}
