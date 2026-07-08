namespace TeaEstate
{
    partial class YieldForm
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
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnTotalBySection = new System.Windows.Forms.Button();
            this.btnTotalByWorker = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvYields = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYields)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(764, 46);
            this.pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Yield";
            //
            // grpDetails
            //
            this.grpDetails.Controls.Add(this.lblWorker);
            this.grpDetails.Controls.Add(this.cmbWorker);
            this.grpDetails.Controls.Add(this.lblSection);
            this.grpDetails.Controls.Add(this.cmbSection);
            this.grpDetails.Controls.Add(this.lblQty);
            this.grpDetails.Controls.Add(this.txtQuantity);
            this.grpDetails.Controls.Add(this.lblDate);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Location = new System.Drawing.Point(14, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(360, 190);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details";
            //
            // lblWorker
            //
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(16, 30);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 15);
            this.lblWorker.TabIndex = 0;
            this.lblWorker.Text = "Worker:";
            //
            // cmbWorker
            //
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.Location = new System.Drawing.Point(120, 27);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(210, 23);
            this.cmbWorker.TabIndex = 1;
            //
            // lblSection
            //
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(16, 64);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(50, 15);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section:";
            //
            // cmbSection
            //
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Location = new System.Drawing.Point(120, 61);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(210, 23);
            this.cmbSection.TabIndex = 3;
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(16, 98);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(81, 15);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Quantity (kg):";
            //
            // txtQuantity
            //
            this.txtQuantity.Location = new System.Drawing.Point(120, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 23);
            this.txtQuantity.TabIndex = 5;
            //
            // lblDate
            //
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(120, 129);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 23);
            this.dtpDate.TabIndex = 7;
            //
            // btnTotalBySection
            //
            this.btnTotalBySection.Location = new System.Drawing.Point(390, 88);
            this.btnTotalBySection.Name = "btnTotalBySection";
            this.btnTotalBySection.Size = new System.Drawing.Size(130, 30);
            this.btnTotalBySection.TabIndex = 2;
            this.btnTotalBySection.Text = "Total by Section";
            this.btnTotalBySection.UseVisualStyleBackColor = true;
            this.btnTotalBySection.Click += new System.EventHandler(this.btnTotalBySection_Click);
            //
            // btnTotalByWorker
            //
            this.btnTotalByWorker.Location = new System.Drawing.Point(390, 126);
            this.btnTotalByWorker.Name = "btnTotalByWorker";
            this.btnTotalByWorker.Size = new System.Drawing.Size(130, 30);
            this.btnTotalByWorker.TabIndex = 3;
            this.btnTotalByWorker.Text = "Total by Worker";
            this.btnTotalByWorker.UseVisualStyleBackColor = true;
            this.btnTotalByWorker.Click += new System.EventHandler(this.btnTotalByWorker_Click);
            //
            // btnRecord
            //
            this.btnRecord.Location = new System.Drawing.Point(14, 256);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(92, 30);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(114, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(214, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(314, 256);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvYields
            //
            this.dgvYields.AllowUserToAddRows = false;
            this.dgvYields.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvYields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYields.Location = new System.Drawing.Point(14, 298);
            this.dgvYields.MultiSelect = false;
            this.dgvYields.Name = "dgvYields";
            this.dgvYields.ReadOnly = true;
            this.dgvYields.RowHeadersVisible = false;
            this.dgvYields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYields.Size = new System.Drawing.Size(748, 196);
            this.dgvYields.TabIndex = 8;
            //
            // YieldForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.dgvYields);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTotalBySection);
            this.Controls.Add(this.btnTotalByWorker);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Estate — Yield";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYields)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnTotalBySection;
        private System.Windows.Forms.Button btnTotalByWorker;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvYields;
    }
}
