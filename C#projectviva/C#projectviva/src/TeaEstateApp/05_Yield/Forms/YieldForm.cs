using System;
using System.Data;

namespace TeaEstate
{
   
    public partial class YieldForm : Form
    {
        
        private readonly YieldRepository _repo = new YieldRepository();

        public YieldForm()
        {
            InitializeComponent();  
            LoadWorkers();          
            LoadSections();         
            LoadYields();            
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

        
        private void LoadSections()
        {
            try
            {
                DataTable sections = DatabaseHelper.ExecuteQuery(
                    "SELECT SectionID, SectionName FROM EstateSection ORDER BY SectionName");

                cmbSection.DataSource = sections;
                cmbSection.DisplayMember = "SectionName";
                cmbSection.ValueMember = "SectionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void LoadYields()
        {
            try
            {
                dgvYields.DataSource = _repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbWorker.SelectedValue == null)
                {
                    MessageBox.Show("Please select a worker.", "Validation");
                    return;
                }
                if (cmbSection.SelectedValue == null)
                {
                    MessageBox.Show("Please select a section.", "Validation");
                    return;
                }

                
                decimal quantity;
                if (!decimal.TryParse(txtQuantity.Text.Trim(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Quantity must be a number greater than 0.", "Validation");
                    return;
                }

                YieldRecord record = new YieldRecord();
                record.WorkerID = Convert.ToInt32(cmbWorker.SelectedValue);
                record.SectionID = Convert.ToInt32(cmbSection.SelectedValue);
                record.Quantity = quantity;
                record.Date = dtpDate.Value.Date;

                _repo.Add(record);
                MessageBox.Show("Yield recorded.", "Success");
                txtQuantity.Clear();
                LoadYields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvYields.CurrentRow == null ||
                    !dgvYields.Columns.Contains("YieldID"))
                {
                    MessageBox.Show("Please show the yield list and select a record to delete.", "Validation");
                    return;
                }

                object value = dgvYields.CurrentRow.Cells["YieldID"].Value;
                if (value == null || value == DBNull.Value)
                {
                    MessageBox.Show("Please select a yield record to delete.", "Validation");
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    "Delete the selected yield record?", "Confirm", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes) return;

                _repo.DeleteById(Convert.ToInt32(value));
                MessageBox.Show("Yield record deleted.", "Success");
                LoadYields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
        }

       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadYields();
        }

        
        private void btnTotalBySection_Click(object sender, EventArgs e)
        {
            try
            {
                dgvYields.DataSource = _repo.TotalBySection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnTotalByWorker_Click(object sender, EventArgs e)
        {
            try
            {
                dgvYields.DataSource = _repo.TotalByWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
