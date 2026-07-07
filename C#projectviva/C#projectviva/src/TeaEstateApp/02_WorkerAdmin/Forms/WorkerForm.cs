using System;
using System.Data;

namespace TeaEstate
{
    // Member 02 — the Worker Administration screen.
    // The visual layout (controls, colours, positions) lives in WorkerForm.Designer.cs
    // so the form opens in the Visual Studio drag-and-drop designer. This file holds
    // only the behaviour: list, search, add, update and delete workers.
    public partial class WorkerForm : Form
    {
        // The data layer this form talks to (implements IDataManager).
        private readonly WorkerRepository _repo = new WorkerRepository();

        // The WorkerID of the row currently selected in the grid (0 = none).
        private int _selectedId = 0;

        // Required public parameterless constructor (dashboard opens `new WorkerForm()`).
        public WorkerForm()
        {
            InitializeComponent();   // builds the controls (see WorkerForm.Designer.cs)
            LoadWorkers();           // fill the grid on open
        }

        // ---------- Data loading ----------

        // Load every worker into the grid.
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

        // ---------- Button handlers ----------

        // Add a new worker after validating the name.
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

        // Update the worker that is currently selected in the grid.
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

        // Delete the selected worker (with a confirmation prompt).
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

        // Clear the textboxes and the current selection.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Reload the full list (also clears any search filter).
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearInputs();
            LoadWorkers();
        }

        // Run a search by name or position.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtSearch.Text.Trim();
                // Empty search just shows everything.
                dgvWorkers.DataSource = term.Length == 0 ? _repo.GetAll() : _repo.Search(term);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // ---------- Grid interaction ----------

        // When a grid row is clicked, copy its values into the textboxes.
        private void dgvWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header row clicked

            DataGridViewRow row = dgvWorkers.Rows[e.RowIndex];

            // DBNull-safe: WorkerID should never be null, but guard anyway.
            object idValue = row.Cells["WorkerID"].Value;
            _selectedId = (idValue == null || idValue == DBNull.Value) ? 0 : Convert.ToInt32(idValue);

            txtName.Text = SafeText(row.Cells["Name"].Value);
            txtAddress.Text = SafeText(row.Cells["Address"].Value);
            txtContact.Text = SafeText(row.Cells["ContactNo"].Value);
            txtPosition.Text = SafeText(row.Cells["Position"].Value);
        }

        // ---------- Helpers ----------

        // Build a Worker object from the current textbox values.
        private Worker ReadWorkerFromInputs()
        {
            Worker w = new Worker();
            w.Name = txtName.Text.Trim();
            w.Address = txtAddress.Text.Trim();
            w.ContactNo = txtContact.Text.Trim();
            w.Position = txtPosition.Text.Trim();
            return w;
        }

        // Name is the only required field. Returns false (and warns) if blank.
        private bool IsNameValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Error");
                return false;
            }
            return true;
        }

        // Reset all inputs and clear the current selection.
        private void ClearInputs()
        {
            _selectedId = 0;
            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtPosition.Clear();
        }

        // Turn a cell value (which may be null/DBNull) into a safe string.
        private string SafeText(object value)
        {
            return value == null || value == DBNull.Value ? "" : value.ToString();
        }
    }
}
