namespace TeaEstate
{
    partial class WorkerForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(212, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Worker Administration";
            //
            // grpDetails
            //
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblAddress);
            this.grpDetails.Controls.Add(this.txtAddress);
            this.grpDetails.Controls.Add(this.lblContact);
            this.grpDetails.Controls.Add(this.txtContact);
            this.grpDetails.Controls.Add(this.lblPosition);
            this.grpDetails.Controls.Add(this.txtPosition);
            this.grpDetails.Location = new System.Drawing.Point(12, 58);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(360, 200);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Worker Details";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(110, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 23);
            this.txtName.TabIndex = 1;
            //
            // lblAddress
            //
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 15);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(110, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 23);
            this.txtAddress.TabIndex = 3;
            //
            // lblContact
            //
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(16, 99);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 15);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact No:";
            //
            // txtContact
            //
            this.txtContact.Location = new System.Drawing.Point(110, 96);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(190, 23);
            this.txtContact.TabIndex = 5;
            //
            // lblPosition
            //
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(16, 133);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 15);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position:";
            //
            // txtPosition
            //
            this.txtPosition.Location = new System.Drawing.Point(110, 130);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(190, 23);
            this.txtPosition.TabIndex = 7;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(390, 64);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(147, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search (name / position):";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(390, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 23);
            this.txtSearch.TabIndex = 3;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(588, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(12, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(112, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(212, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(312, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(412, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvWorkers
            //
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToResizeRows = false;
            this.dgvWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(12, 306);
            this.dgvWorkers.MultiSelect = false;
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            this.dgvWorkers.RowHeadersVisible = false;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(756, 222);
            this.dgvWorkers.TabIndex = 10;
            this.dgvWorkers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkers_CellClick);
            //
            // WorkerForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Estate — Worker Administration";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvWorkers;
    }
}
