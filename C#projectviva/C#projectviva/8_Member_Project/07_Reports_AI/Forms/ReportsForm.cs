using System;
using System.Data;

namespace TeaEstate
{
   
    public partial class ReportsForm : Form
    {
       
        private readonly ReportService _reports = new ReportService();

        public ReportsForm()
        {
            InitializeComponent();          
            if (cmbReport.Items.Count > 0)
                cmbReport.SelectedIndex = 0; 
        }

        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbReport.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a report.", "Validation");
                    return;
                }

                DataTable result;

            
                switch (cmbReport.SelectedItem.ToString())
                {
                    case "Worker Performance":
                        result = _reports.WorkerPerformanceReport();
                        break;
                    case "Attendance History":
                        result = _reports.AttendanceHistoryReport();
                        break;
                    case "Yield By Section":
                        result = _reports.YieldBySectionReport();
                        break;
                    case "Processing Log":
                        result = _reports.ProcessingLogReport();
                        break;
                    default:
                        result = _reports.GenerateReport();  
                        break;
                }

                dgvReport.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
