namespace TeaEstate
{
	partial class ChangePasswordForm
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
			this.lblHeader = new System.Windows.Forms.Label();
			this.grpDetails = new System.Windows.Forms.GroupBox();
			this.lblOld = new System.Windows.Forms.Label();
			this.txtOld = new System.Windows.Forms.TextBox();
			this.lblNew = new System.Windows.Forms.Label();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlHeader.SuspendLayout();
			this.grpDetails.SuspendLayout();
			this.SuspendLayout();
			//
			// pnlHeader
			//
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
			this.pnlHeader.Controls.Add(this.lblHeader);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(404, 46);
			this.pnlHeader.TabIndex = 0;
			//
			// lblHeader
			//
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
			this.lblHeader.ForeColor = System.Drawing.Color.White;
			this.lblHeader.Location = new System.Drawing.Point(12, 8);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(155, 25);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Change Password";
			//
			// grpDetails
			//
			this.grpDetails.Controls.Add(this.lblOld);
			this.grpDetails.Controls.Add(this.txtOld);
			this.grpDetails.Controls.Add(this.lblNew);
			this.grpDetails.Controls.Add(this.txtNew);
			this.grpDetails.Controls.Add(this.lblConfirm);
			this.grpDetails.Controls.Add(this.txtConfirm);
			this.grpDetails.Location = new System.Drawing.Point(30, 64);
			this.grpDetails.Name = "grpDetails";
			this.grpDetails.Size = new System.Drawing.Size(360, 150);
			this.grpDetails.TabIndex = 1;
			this.grpDetails.TabStop = false;
			this.grpDetails.Text = "Details";
			//
			// lblOld
			//
			this.lblOld.AutoSize = true;
			this.lblOld.Location = new System.Drawing.Point(16, 31);
			this.lblOld.Name = "lblOld";
			this.lblOld.Size = new System.Drawing.Size(78, 15);
			this.lblOld.TabIndex = 0;
			this.lblOld.Text = "Old Password";
			//
			// txtOld
			//
			this.txtOld.Location = new System.Drawing.Point(150, 28);
			this.txtOld.Name = "txtOld";
			this.txtOld.Size = new System.Drawing.Size(190, 23);
			this.txtOld.TabIndex = 1;
			this.txtOld.UseSystemPasswordChar = true;
			//
			// lblNew
			//
			this.lblNew.AutoSize = true;
			this.lblNew.Location = new System.Drawing.Point(16, 65);
			this.lblNew.Name = "lblNew";
			this.lblNew.Size = new System.Drawing.Size(82, 15);
			this.lblNew.TabIndex = 2;
			this.lblNew.Text = "New Password";
			//
			// txtNew
			//
			this.txtNew.Location = new System.Drawing.Point(150, 62);
			this.txtNew.Name = "txtNew";
			this.txtNew.Size = new System.Drawing.Size(190, 23);
			this.txtNew.TabIndex = 3;
			this.txtNew.UseSystemPasswordChar = true;
			//
			// lblConfirm
			//
			this.lblConfirm.AutoSize = true;
			this.lblConfirm.Location = new System.Drawing.Point(16, 99);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(75, 15);
			this.lblConfirm.TabIndex = 4;
			this.lblConfirm.Text = "Confirm New";
			//
			// txtConfirm
			//
			this.txtConfirm.Location = new System.Drawing.Point(150, 96);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.Size = new System.Drawing.Size(190, 23);
			this.txtConfirm.TabIndex = 5;
			this.txtConfirm.UseSystemPasswordChar = true;
			//
			// btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(200, 224);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(92, 30);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			//
			// btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(298, 224);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(92, 30);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			//
			// ChangePasswordForm
			//
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 270);
			this.Controls.Add(this.grpDetails);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ChangePasswordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tea Estate — Change Password";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.grpDetails.ResumeLayout(false);
			this.grpDetails.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.GroupBox grpDetails;
		private System.Windows.Forms.Label lblOld;
		private System.Windows.Forms.TextBox txtOld;
		private System.Windows.Forms.Label lblNew;
		private System.Windows.Forms.TextBox txtNew;
		private System.Windows.Forms.Label lblConfirm;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
	}
}
