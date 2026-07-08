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

           
            if (string.IsNullOrWhiteSpace(oldPass) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }

            
            if (oldPass != Session.CurrentUser.Password)
            {
                MessageBox.Show("Old password is incorrect.", "Error");
                return;
            }

            
            if (newPass != confirm)
            {
                MessageBox.Show("New password and confirmation do not match.", "Error");
                return;
            }

            try
            {
                
                string sql = "UPDATE [User] SET Password=@p WHERE UserID=@id";
                int rows = DatabaseHelper.ExecuteNonQuery(
                    sql,
                    new SqlParameter("@p", newPass),
                    new SqlParameter("@id", Session.CurrentUser.UserId));

                if (rows > 0)
                {
                    
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
