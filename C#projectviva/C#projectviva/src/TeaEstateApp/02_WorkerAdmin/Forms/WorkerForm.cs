using System;
using System.Data;

namespace TeaEstate
{
    
    public partial class WorkerForm : Form
    {
        
        private readonly WorkerRepository _repo = new WorkerRepository();

        
        private int _selectedId = 0;

        
        public WorkerForm()
        {
            InitializeComponent();  
            LoadWorkers();           
        }

        
        private void LoadWorkers()
        {
            try
            {
                dgvWorkers.DataSource = _repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsNameValid()) return;

            try
            {
                Worker w = ReadWorkerFromInputs();
                _repo.Add(w);
                MessageBox.Show("Worker added.", "Success");
                ClearInputs();
                LoadWorkers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Please select a worker from the list first.", "Error");
                return;
            }
            if (!IsNameValid()) return;

            try
            {
                Worker w = ReadWorkerFromInputs();
                w.Id = _selectedId;
                _repo.Update(w);
                MessageBox.Show("Worker updated.", "Success");
                ClearInputs();
                LoadWorkers();
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
                MessageBox.Show("Please select a worker from the list first.", "Error");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Delete this worker?", "Confirm", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes) return;

            try
            {
                _repo.DeleteById(_selectedId);
                MessageBox.Show("Worker deleted.", "Success");
                ClearInputs();
                LoadWorkers();
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
            txtSearch.Clear();
            ClearInputs();
            LoadWorkers();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtSearch.Text.Trim();
                
                dgvWorkers.DataSource = term.Length == 0 ? _repo.GetAll() : _repo.Search(term);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        
        private void dgvWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow row = dgvWorkers.Rows[e.RowIndex];

            
            object idValue = row.Cells["WorkerID"].Value;
            _selectedId = (idValue == null || idValue == DBNull.Value) ? 0 : Convert.ToInt32(idValue);

            txtName.Text = SafeText(row.Cells["Name"].Value);
            txtAddress.Text = SafeText(row.Cells["Address"].Value);
            txtContact.Text = SafeText(row.Cells["ContactNo"].Value);
            txtPosition.Text = SafeText(row.Cells["Position"].Value);
        }

        
        private Worker ReadWorkerFromInputs()
        {
            Worker w = new Worker();
            w.Name = txtName.Text.Trim();
            w.Address = txtAddress.Text.Trim();
            w.ContactNo = txtContact.Text.Trim();
            w.Position = txtPosition.Text.Trim();
            return w;
        }

       
        private bool IsNameValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Error");
                return false;
            }
            return true;
        }

       
        private void ClearInputs()
        {
            _selectedId = 0;
            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtPosition.Clear();
        }

       
        private string SafeText(object value)
        {
            return value == null || value == DBNull.Value ? "" : value.ToString();
        }
    }
}
