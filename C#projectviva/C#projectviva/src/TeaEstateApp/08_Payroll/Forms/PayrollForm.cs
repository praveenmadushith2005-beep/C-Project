using System;
using System.Data;

namespace TeaEstate
{
   
    public partial class PayrollForm : Form
    {
        
        private readonly SalaryRepository _repo = new SalaryRepository();

        
        private int _selectedId = 0;

        
        private const decimal BonusPerKg = 2.0m;

        
        public PayrollForm()
        {
            InitializeComponent();  
            LoadWorkers();          
            dtpPaidDate.Value = DateTime.Today;
            LoadSalaries();        
        }

        
        private void LoadWorkers()
        {
            try
            {
                cmbWorker.DataSource = _repo.GetWorkers();
                cmbWorker.DisplayMember = "Name";
                cmbWorker.ValueMember = "WorkerID";
                cmbWorker.SelectedIndex = -1;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

     
        private void LoadSalaries()
        {
            try
            {
                dgvSalary.DataSource = _repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

      
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbWorker.SelectedValue == null)
            {
                MessageBox.Show("Please select a worker first.", "Error");
                return;
            }

            string month = txtMonth.Text.Trim();
            if (month.Length == 0)
            {
                MessageBox.Show("Please enter a month (e.g. 2026-05).", "Error");
                return;
            }

            try
            {
                int workerId = Convert.ToInt32(cmbWorker.SelectedValue);

                
                int days = _repo.CountPresentDays(workerId, month);
                txtDaysWorked.Text = days.ToString();

                
                decimal yield = _repo.SumYield(workerId, month);
                decimal suggestedBonus = yield * BonusPerKg;
                txtYieldBonus.Text = suggestedBonus.ToString("0.00");

                
                RecomputeTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (cmbWorker.SelectedValue == null)
            {
                MessageBox.Show("Please select a worker first.", "Error");
                return;
            }

            
            string month = txtMonth.Text.Trim();
            if (month.Length == 0)
            {
                MessageBox.Show("Month is required (e.g. 2026-05).", "Error");
                return;
            }

           
            int daysWorked;
            if (!int.TryParse(txtDaysWorked.Text.Trim(), out daysWorked))
            {
                MessageBox.Show("Days Worked must be a whole number.", "Error");
                return;
            }

            decimal dailyRate;
            if (!decimal.TryParse(txtDailyRate.Text.Trim(), out dailyRate))
            {
                MessageBox.Show("Daily Rate must be a number.", "Error");
                return;
            }

            decimal yieldBonus;
            if (!decimal.TryParse(txtYieldBonus.Text.Trim(), out yieldBonus))
            {
                MessageBox.Show("Yield Bonus must be a number.", "Error");
                return;
            }

            try
            {
                SalaryPayment p = new SalaryPayment();
                p.WorkerId = Convert.ToInt32(cmbWorker.SelectedValue);
                p.Month = month;
                p.DaysWorked = daysWorked;
                p.DailyRate = dailyRate;
                p.YieldBonus = yieldBonus;
                p.TotalAmount = p.CalculateTotal();   
                p.PaidDate = dtpPaidDate.Value.Date;

                _repo.Add(p);
                MessageBox.Show("Salary payment added.", "Success");
                ClearInputs();
                LoadSalaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Please select a payment from the list first.", "Error");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Delete this salary payment?", "Confirm", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes) return;

            try
            {
                _repo.DeleteById(_selectedId);
                MessageBox.Show("Salary payment deleted.", "Success");
                ClearInputs();
                LoadSalaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadSalaries();
        }

        
        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow row = dgvSalary.Rows[e.RowIndex];

            
            object idValue = row.Cells["PaymentID"].Value;
            _selectedId = (idValue == null || idValue == DBNull.Value) ? 0 : Convert.ToInt32(idValue);

            
            string workerName = SafeText(row.Cells["WorkerName"].Value);
            cmbWorker.SelectedValue = WorkerIdForName(workerName);

            txtMonth.Text = SafeText(row.Cells["Month"].Value);
            txtDaysWorked.Text = SafeText(row.Cells["DaysWorked"].Value);
            txtDailyRate.Text = SafeText(row.Cells["DailyRate"].Value);
            txtYieldBonus.Text = SafeText(row.Cells["YieldBonus"].Value);

            
            object paid = row.Cells["PaidDate"].Value;
            if (paid != null && paid != DBNull.Value)
            {
                dtpPaidDate.Value = Convert.ToDateTime(paid);
            }

            RecomputeTotal();
        }

        
        private void RecomputeTotal()
        {
            int days;
            decimal rate;
            decimal bonus;

            int.TryParse(txtDaysWorked.Text.Trim(), out days);
            decimal.TryParse(txtDailyRate.Text.Trim(), out rate);
            decimal.TryParse(txtYieldBonus.Text.Trim(), out bonus);

            SalaryPayment temp = new SalaryPayment();
            temp.DaysWorked = days;
            temp.DailyRate = rate;
            temp.YieldBonus = bonus;

            lblTotal.Text = temp.CalculateTotal().ToString("0.00");
        }

        
        private int WorkerIdForName(string name)
        {
            DataTable dt = cmbWorker.DataSource as DataTable;
            if (dt == null) return 0;

            foreach (DataRow r in dt.Rows)
            {
                if (string.Equals(SafeText(r["Name"]), name, StringComparison.Ordinal))
                {
                    return Convert.ToInt32(r["WorkerID"]);
                }
            }
            return 0;
        }

        
        private void ClearInputs()
        {
            _selectedId = 0;
            cmbWorker.SelectedIndex = -1;
            txtMonth.Clear();
            txtDaysWorked.Clear();
            txtDailyRate.Clear();
            txtYieldBonus.Clear();
            dtpPaidDate.Value = DateTime.Today;
            lblTotal.Text = "0.00";
        }

       
        private string SafeText(object value)
        {
            return value == null || value == DBNull.Value ? "" : value.ToString();
        }
    }
}
