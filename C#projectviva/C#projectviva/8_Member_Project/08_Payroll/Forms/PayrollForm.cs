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
