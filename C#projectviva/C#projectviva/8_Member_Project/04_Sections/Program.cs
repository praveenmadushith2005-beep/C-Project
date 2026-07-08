using System;

namespace TeaEstate
{
    // Standalone entry point for Member 04 — Estate Sections.
    // Opens straight to this member's screen so it can be built/tested on its own.
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Shared DatabaseHelper creates + seeds the SQL Server LocalDB database on first launch.
            try
            {
                DatabaseHelper.EnsureDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }

            Application.Run(new SectionForm());
        }
    }
}
