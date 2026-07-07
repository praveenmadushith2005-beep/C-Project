using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    // Member 01 — the first screen. Checks the username/password against the [User] table.
    // On success it remembers the user in Session and opens the MainDashboard.
    //
    // The visual layout (controls, colours, positions) lives in LoginForm.Designer.cs
    // so the form opens in the Visual Studio drag-and-drop designer. This file holds
    // only the behaviour (what happens when the Login button is clicked).
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();   // builds the controls (see LoginForm.Designer.cs)
        }

        // Runs when the Login button is clicked.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate: both fields are required.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                // Look up the account by username (parameterised — safe from SQL injection).
                string sql = "SELECT UserID, Username, Password, Role FROM [User] WHERE Username=@u";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql, new SqlParameter("@u", username));

                // Check we found a row AND the password matches (plain compare is fine for coursework).
                if (dt.Rows.Count == 1 && dt.Rows[0]["Password"].ToString() == password)
                {
                    DataRow row = dt.Rows[0];

                    // Build the logged-in User and store it for the rest of the app.
                    User user = new User();
                    user.UserId = Convert.ToInt32(row["UserID"]);
                    user.Username = row["Username"].ToString();
                    user.Password = row["Password"].ToString();
                    user.Role = row["Role"].ToString();
                    Session.CurrentUser = user;

                    // Open the dashboard; hide this login window while it is open.
                    // We pass ourselves in so Logout can re-show THIS same window.
                    MainDashboard dashboard = new MainDashboard(this);
                    dashboard.Show();

                    // Clear the boxes so the next login starts fresh.
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
