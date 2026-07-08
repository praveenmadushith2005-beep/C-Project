namespace TeaEstate
{
    partial class ProcessingForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblYield = new System.Windows.Forms.Label();
            this.cmbYield = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.txtProcessed = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvProcessing = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 46);
            this.pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(168, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Factory Processing";
            //
            // grpDetails
            //
            this.grpDetails.Controls.Add(this.lblYield);
            this.grpDetails.Controls.Add(this.cmbYield);
            this.grpDetails.Controls.Add(this.lblDate);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.lblProcessed);
            this.grpDetails.Controls.Add(this.txtProcessed);
            this.grpDetails.Location = new System.Drawing.Point(12, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(756, 160);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            //
            // lblYield
            //
            this.lblYield.AutoSize = true;
            this.lblYield.Location = new System.Drawing.Point(16, 30);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(94, 15);
            this.lblYield.TabIndex = 0;
            this.lblYield.Text = "Raw Yield Batch:";
            //
            // cmbYield
            //
            this.cmbYield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYield.Location = new System.Drawing.Point(150, 27);
            this.cmbYield.Name = "cmbYield";
            this.cmbYield.Size = new System.Drawing.Size(260, 23);
            this.cmbYield.TabIndex = 1;
            //
            // lblDate
            //
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Processing Date:";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(150, 61);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 23);
            this.dtpDate.TabIndex = 3;
            //
            // lblProcessed
            //
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.Location = new System.Drawing.Point(16, 98);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(108, 15);
            this.lblProcessed.TabIndex = 4;
            this.lblProcessed.Text = "Processed Qty (kg):";
            //
            // txtProcessed
            //
            this.txtProcessed.Location = new System.Drawing.Point(150, 95);
            this.txtProcessed.Name = "txtProcessed";
            this.txtProcessed.Size = new System.Drawing.Size(190, 23);
            this.txtProcessed.TabIndex = 5;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(12, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(112, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(212, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(312, 228);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvProcessing
            //
            this.dgvProcessing.AllowUserToAddRows = false;
            this.dgvProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcessing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessing.Location = new System.Drawing.Point(12, 268);
            this.dgvProcessing.MultiSelect = false;
            this.dgvProcessing.Name = "dgvProcessing";
            this.dgvProcessing.ReadOnly = true;
            this.dgvProcessing.RowHeadersVisible = false;
            this.dgvProcessing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessing.Size = new System.Drawing.Size(756, 260);
            this.dgvProcessing.TabIndex = 6;
            this.dgvProcessing.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProcessing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessing_CellClick);
            //
            // ProcessingForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.dgvProcessing);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Estate — Factory Processing";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessing)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblYield;
        private System.Windows.Forms.ComboBox cmbYield;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblProcessed;
        private System.Windows.Forms.TextBox txtProcessed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProcessing;
    }
}
