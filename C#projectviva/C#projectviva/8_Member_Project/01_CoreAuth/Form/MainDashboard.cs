using System;
using TeaEstate;

namespace TeaEstate
{
    // Member 01 — the main menu shown after a successful login.
    // It greets the user and shows only the buttons their Role is allowed to use.
    //
    // The fixed parts of the screen (green header + welcome label) live in
    // MainDashboard.Designer.cs. The menu buttons are added here in code because
    // which buttons appear depends on the logged-in user's Role.
    //
    // This form OWNS the app lifetime decisions:
    //   - Logout  -> open a fresh LoginForm, then close this dashboard quietly.
    //   - Closing -> if it was NOT a logout, exit the whole application.
    public partial class MainDashboard : Form
    {
        // The login window that opened us. On logout we re-show this SAME window.
        private readonly LoginForm _loginForm;

        // True only while we are logging out, so FormClosed does NOT exit the app.
        private bool _loggingOut = false;

        // Where the next menu button is placed; grows downward as we add buttons.
        private int _nextTop;

        // Required public parameterless constructor (kept for the contract).
        public MainDashboard() : this(null)
        {
        }

        public MainDashboard(LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
            BuildMenu();
            this.FormClosed += MainDashboard_FormClosed;
        }

        // Adds the role-appropriate module buttons under the welcome label.
        private void BuildMenu()
        {
            // Who is logged in (used in the header and to decide visible buttons).
            User u = Session.CurrentUser;
            string who = (u != null) ? u.Username : "Guest";
            string role = (u != null) ? u.Role : "";
            lblWelcome.Text = "Welcome " + who + " (" + role + ")";

            // First button sits below the greeting; AddButton moves this down each time.
            _nextTop = 90;

            // Decide which module buttons this role may see.
            bool isManager = role == "Manager";
            bool isSupervisor = role == "Supervisor";
            bool isOfficer = role == "ProcessingOfficer";

            // Manager: everything. Supervisor: Attendance/Sections/Yield. Officer: Processing.
            if (isManager)
                AddButton("Workers", (s, e) => new TeaEstate.WorkerForm().Show());

            if (isManager || isSupervisor)
            {
                AddButton("Attendance", (s, e) => new AttendanceForm().Show());
                AddButton("Sections", (s, e) => new SectionForm().Show());
                AddButton("Yield", (s, e) => new YieldForm().Show());
            }

            if (isManager || isOfficer)
                AddButton("Processing", (s, e) => new ProcessingForm().Show());

            if (isManager)
            {
                AddButton("Reports", (s, e) => new ReportsForm().Show());
                AddButton("Forecast", (s, e) => new ForecastForm().Show());
                AddButton("Payroll", (s, e) => new PayrollForm().Show());
            }

            // Everyone can change their password and log out.
            AddButton("Change Password", (s, e) => new ChangePasswordForm().ShowDialog());
            AddButton("Logout", btnLogout_Click);
        }

        // Helper: creates one equal-size menu button and stacks it under the previous one.
        private void AddButton(string text, EventHandler onClick)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new System.Drawing.Point(40, _nextTop);
            btn.Size = new System.Drawing.Size(330, 34);
            btn.Click += onClick;
            this.Controls.Add(btn);
            btn.BringToFront();

            _nextTop += 40;   // leave a gap before the next button
        }

        // Logout: forget the current user, show the login window again, close this one.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggingOut = true;          // tell FormClosed not to exit the app
            Session.CurrentUser = null;  // forget who was logged in

            if (_loginForm != null)
                _loginForm.Show();
            else
                new LoginForm().Show();

            this.Close();                // close (and dispose) this dashboard
        }

        // When the dashboard closes: a logout already opened a new login, so keep
        // the app alive. Otherwise the user really closed the app, so exit.
        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_loggingOut)
            {
                Application.Exit();
            }
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
