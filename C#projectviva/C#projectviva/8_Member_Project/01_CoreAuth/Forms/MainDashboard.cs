using System;
using System.Windows.Forms;
using TeaEstate;


namespace TeaEstate
{
  
    public partial class MainDashboard : Form
    {
        private readonly LoginForm _loginForm;
        private bool _loggingOut = false;
        private int _nextTop;

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

        private void BuildMenu()
        {
            User u = Session.CurrentUser;
            string who = (u != null) ? u.Username : "Guest";
            string role = (u != null) ? u.Role : "";

            
            if (lblWelcome != null)
            {
                lblWelcome.Text = "Welcome " + who + " (" + role + ")";
            }

            _nextTop = 90;

            bool isManager = role == "Manager";
            bool isSupervisor = role == "Supervisor";
            bool isOfficer = role == "ProcessingOfficer";

           
            if (isManager)
                AddButton("Workers", (s, e) => new WorkerForm().Show());

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

            AddButton("Change Password", (s, e) => new ChangePasswordForm().ShowDialog());
            AddButton("Logout", btnLogout_Click);
        }

        private void AddButton(string text, EventHandler onClick)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new System.Drawing.Point(40, _nextTop);
            btn.Size = new System.Drawing.Size(330, 34);
            btn.Click += onClick;
            this.Controls.Add(btn);
            btn.BringToFront();

            _nextTop += 40;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggingOut = true;
            Session.CurrentUser = null;

            if (_loginForm != null)
                _loginForm.Show();
            else
                new LoginForm().Show();

            this.Close();
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_loggingOut)
            {
                Application.Exit();
            }
        }
    }
}