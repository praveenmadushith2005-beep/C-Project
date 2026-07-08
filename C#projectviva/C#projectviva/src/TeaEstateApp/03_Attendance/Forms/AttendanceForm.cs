using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
   
    public partial class AttendanceForm : Form
    {
        
        private readonly AttendanceRepository _repo = new AttendanceRepository();

        public AttendanceForm()
        {
            InitializeComponent();   

            SetupRuntime();         
            LoadWorkers();          
            ShowSelectedDay();       
        }

       
        private void SetupRuntime()
        {
            
            cmbStatus.Items.AddRange(new object[] { "Present", "Absent", "Leave" });
            cmbStatus.SelectedIndex = 0;

            
            cmbMonth.Items.AddRange(new object[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1; 

            
            int thisYear = DateTime.Now.Year;
            for (int y = thisYear - 5; y <= thisYear + 1; y++)
            {
                cmbYear.Items.Add(y);
            }
            cmbYear.SelectedItem = thisYear; 
        }

       
        private void LoadWorkers()
        {
            try
            {
                DataTable workers = DatabaseHelper.ExecuteQuery(
                    "SELECT WorkerID, Name FROM Worker ORDER BY Name");

                cmbWorker.DataSource = workers;
                cmbWorker.DisplayMember = "Name";     
                cmbWorker.ValueMember = "WorkerID";    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnMark_Click(object sender, EventArgs e)
        {
            
            if (cmbWorker.SelectedValue == null)
            {
                MessageBox.Show("Please select a worker.", "Validation");
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation");
                return;
            }

            try
            {
                Attendance record = new Attendance();
                record.WorkerID = Convert.ToInt32(cmbWorker.SelectedValue);
                record.Date = dtpDate.Value.Date;
                record.Status = cmbStatus.SelectedItem.ToString();

                _repo.Add(record);
                MessageBox.Show("Attendance marked.", "Success");

                ShowSelectedDay(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnShowDay_Click(object sender, EventArgs e)
        {
            ShowSelectedDay();
        }

        
        private void ShowSelectedDay()
        {
            try
            {
                dgvAttendance.DataSource = _repo.GetByDate(dtpDate.Value.Date);
                lblGrid.Text = "Attendance for " + dtpDate.Value.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnMonthlySummary_Click(object sender, EventArgs e)
        {
            try
            {
                int month = cmbMonth.SelectedIndex + 1;
                int year = Convert.ToInt32(cmbYear.SelectedItem);

                dgvAttendance.DataSource = _repo.MonthlySummary(month, year);
                lblGrid.Text = "Monthly Summary — " + cmbMonth.SelectedItem + " " + year;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
