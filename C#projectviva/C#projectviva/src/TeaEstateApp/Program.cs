using System;

namespace TeaEstate
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
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
