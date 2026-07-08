namespace TeaEstate
{
    partial class ForecastForm
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
            lblHeader = new Label();
            grpResult = new GroupBox();
            lblResult = new Label();
            btnForecast = new Button();
            dgvHistory = new DataGridView();
            pnlHeader.SuspendLayout();
            grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(34, 139, 34);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(891, 61);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(14, 11);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(192, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "AI Yield Forecast";
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblResult);
            grpResult.Location = new Point(14, 77);
            grpResult.Margin = new Padding(3, 4, 3, 4);
            grpResult.Name = "grpResult";
            grpResult.Padding = new Padding(3, 4, 3, 4);
            grpResult.Size = new Size(864, 173);
            grpResult.TabIndex = 1;
            grpResult.TabStop = false;
            grpResult.Text = "Prediction";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(34, 139, 34);
            lblResult.Location = new Point(18, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(827, 113);
            lblResult.TabIndex = 0;
            lblResult.Text = "Click \"Forecast Next Month\" to predict next month's yield.";
            lblResult.Click += lblResult_Click;
            // 
            // btnForecast
            // 
            btnForecast.Location = new Point(14, 264);
            btnForecast.Margin = new Padding(3, 4, 3, 4);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(183, 40);
            btnForecast.TabIndex = 2;
            btnForecast.Text = "Forecast Next Month";
            btnForecast.UseVisualStyleBackColor = true;
            btnForecast.Click += btnForecast_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(14, 317);
            dgvHistory.Margin = new Padding(3, 4, 3, 4);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(864, 387);
            dgvHistory.TabIndex = 3;
            // 
            // ForecastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 720);
            Controls.Add(dgvHistory);
            Controls.Add(btnForecast);
            Controls.Add(grpResult);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ForecastForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tea Estate — AI Yield Forecast";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}
