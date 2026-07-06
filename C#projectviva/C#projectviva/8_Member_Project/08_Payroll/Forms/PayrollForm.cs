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
