using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
   
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();  
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
               
                string sql = "SELECT UserID, Username, Password, Role FROM [User] WHERE Username=@u";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@u", username));

                
                if (dt.Rows.Count == 1 && dt.Rows[0]["Password"].ToString() == password)
                {
                    DataRow row = dt.Rows[0];

                    
                    User user = new User();
                    user.UserId = Convert.ToInt32(row["UserID"]);
                    user.Username = row["Username"].ToString();
                    user.Password = row["Password"].ToString();
                    user.Role = row["Role"].ToString();
                    Session.CurrentUser = user;

                   
                    MainDashboard dashboard = new MainDashboard(this);
                    dashboard.Show();

                    
                    txtPassword.Clear();
                    lblError.Text = "";

                    this.Hide();
                }
                else
                {
                    lblError.Text = "Invalid username or password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
