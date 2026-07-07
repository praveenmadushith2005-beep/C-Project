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


            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 46);
            this.pnlHeader.TabIndex = 0;
            


            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll / Salary";
            


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

            


            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(16, 31);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 15);
            this.lblWorker.TabIndex = 0;
            this.lblWorker.Text = "Worker:";
           
            
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(130, 28);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 23);
            this.cmbWorker.TabIndex = 1;
           


            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(16, 65);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(101, 15);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month (yyyy-MM):";


            this.txtMonth.Location = new System.Drawing.Point(130, 62);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(200, 23);
            this.txtMonth.TabIndex = 3;
         
            

            this.lblDaysWorked.AutoSize = true;
            this.lblDaysWorked.Location = new System.Drawing.Point(16, 99);
            this.lblDaysWorked.Name = "lblDaysWorked";
            this.lblDaysWorked.Size = new System.Drawing.Size(80, 15);
            this.lblDaysWorked.TabIndex = 4;
            this.lblDaysWorked.Text = "Days Worked:";
            


            this.txtDaysWorked.Location = new System.Drawing.Point(130, 96);
            this.txtDaysWorked.Name = "txtDaysWorked";
            this.txtDaysWorked.Size = new System.Drawing.Size(200, 23);
            this.txtDaysWorked.TabIndex = 5;
            


            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(16, 133);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(63, 15);
            this.lblDailyRate.TabIndex = 6;
            this.lblDailyRate.Text = "Daily Rate:";
            


            this.txtDailyRate.Location = new System.Drawing.Point(130, 130);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(200, 23);
            this.txtDailyRate.TabIndex = 7;
            


            this.lblYieldBonus.AutoSize = true;
            this.lblYieldBonus.Location = new System.Drawing.Point(16, 167);
            this.lblYieldBonus.Name = "lblYieldBonus";
            this.lblYieldBonus.Size = new System.Drawing.Size(75, 15);
            this.lblYieldBonus.TabIndex = 8;
            this.lblYieldBonus.Text = "Yield Bonus:";
            


            this.txtYieldBonus.Location = new System.Drawing.Point(130, 164);
            this.txtYieldBonus.Name = "txtYieldBonus";
            this.txtYieldBonus.Size = new System.Drawing.Size(200, 23);
            this.txtYieldBonus.TabIndex = 9;