using System;

namespace TeaEstate
{
    // Application entry point. Starts at the Login screen (Member 01).
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create + seed the SQL Server LocalDB database on first launch
            // (TeaEstateDB) — no manual DB setup needed, just run the app.
            try
            {
                DatabaseHelper.EnsureDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not prepare the database:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new LoginForm());
        }
    }
}
