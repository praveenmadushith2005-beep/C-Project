using System;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("No user is logged in.", "Error");
                return;
            }

            string oldPass = txtOld.Text;
            string newPass = txtNew.Text;
            string confirm = txtConfirm.Text;

            // Validate: nothing blank.
            if (string.IsNullOrWhiteSpace(oldPass) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            // The old password must match the one we have for this user.
            if (oldPass != Session.CurrentUser.Password)
            {
                MessageBox.Show("Old password is incorrect.", "Error");
                return;
            }

            // New and confirm must match.
            if (newPass != confirm)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error");
                return;
            }

            try
            {
                // Update the password for the current user only.
                string sql = "UPDATE [User] SET Password=@p WHERE UserID=@id";
                int rows = DatabaseHelper.ExecuteNonQuery(
                    sql,
                    new SqlParameter("@p", newPass),
                    new SqlParameter("@id", Session.CurrentUser.UserId));

                if (rows > 0)
                {
                    // Keep the in-memory user in sync so a later change still works.
                    Session.CurrentUser.Password = newPass;
                    MessageBox.Show("Password changed successfully.", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password change failed.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
