using System;
using System.Data;

namespace TeaEstate
{
    // Member 05 — screen to record tea-leaf yields and view summaries.
    //
    // The visual layout (controls, colours, positions) lives in YieldForm.Designer.cs
    // so the form opens in the Visual Studio drag-and-drop designer. This file holds
    // only the behaviour (recording a yield, deleting, and the two summary views).
    //
    // Class name + parameterless constructor are fixed because MainDashboard opens this
    // form by name (new YieldForm()).
    public partial class YieldForm : Form
    {
        // Repository does all the database work for yields.
        private readonly YieldRepository _repo = new YieldRepository();

        public YieldForm()
        {
            InitializeComponent();   // builds the controls (see YieldForm.Designer.cs)
            LoadWorkers();           // fill the worker dropdown
            LoadSections();          // fill the section dropdown
            LoadYields();            // show existing yield records
        }

        // Fill the worker dropdown from the Worker table.
        // We store WorkerID as the value and the Name as the text the user sees.
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

        // Fill the section dropdown from the EstateSection table.
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

        // Show all yield records (with worker + section names) in the grid.
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

        // Record button — validate, build a YieldRecord, then insert.
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure a worker and a section are chosen.
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

                // Validate the quantity.
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

        // Delete button — remove the selected yield record.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // The grid may currently be showing a summary (which has no YieldID
                // column), so guard for that before trying to delete.
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

        // Clear button — reset the quantity input.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
        }

        // Refresh button — reload the full yield list back into the grid.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadYields();
        }

        // Show the "total quantity per section" summary in the grid.
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

        // Show the "total quantity per worker" summary in the grid.
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
