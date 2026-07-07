using System;
using System.Data;

namespace TeaEstate
{
    // Member 04 — screen to manage estate sections (Add / Update / Delete / Clear / Refresh).
    //
    // The visual layout (controls, colours, positions) lives in SectionForm.Designer.cs
    // so the form opens in the Visual Studio drag-and-drop designer. This file holds
    // only the behaviour (what happens when each button is clicked).
    //
    // Class name + parameterless constructor are fixed because MainDashboard opens this
    // form by name (new SectionForm()).
    public partial class SectionForm : Form
    {
        // Repository does all the database work for us.
        private readonly SectionRepository _repo = new SectionRepository();

        public SectionForm()
        {
            InitializeComponent();   // builds the controls (see SectionForm.Designer.cs)
            LoadSections();          // show the data as soon as the form opens
        }

        // Load all sections from the database into the grid.
        private void LoadSections()
        {
            try
            {
                dgvSections.DataSource = _repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Add button — validate, then insert.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EstateSection section = ReadInput();
                if (section == null) return;   // validation failed

                _repo.Add(section);
                MessageBox.Show("Section added.", "Success");
                ClearInput();
                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Update button — needs a row selected, then save changes.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedId();
                if (id == 0)
                {
                    MessageBox.Show("Please select a section to update.", "Validation");
                    return;
                }

                EstateSection section = ReadInput();
                if (section == null) return;

                section.SectionID = id;
                _repo.Update(section);
                MessageBox.Show("Section updated.", "Success");
                ClearInput();
                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Delete button — needs a row selected, asks to confirm, then deletes.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedId();
                if (id == 0)
                {
                    MessageBox.Show("Please select a section to delete.", "Validation");
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    "Delete the selected section?", "Confirm", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes) return;

                _repo.DeleteById(id);
                MessageBox.Show("Section deleted.", "Success");
                ClearInput();
                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Clear button — empty the inputs.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        // Refresh button — reload the grid from the database.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadSections();
        }

        // Read + validate the textboxes into an EstateSection object.
        // Returns null (and shows a message) if anything is invalid.
        private EstateSection ReadInput()
        {
            string name = txtName.Text.Trim();
            string areaText = txtArea.Text.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("Section name is required.", "Validation");
                return null;
            }

            decimal area;
            if (!decimal.TryParse(areaText, out area) || area < 0)
            {
                MessageBox.Show("Area must be a valid number (0 or more).", "Validation");
                return null;
            }

            EstateSection section = new EstateSection();
            section.SectionName = name;
            section.Area = area;
            return section;
        }

        // Get the SectionID of the selected grid row (0 if nothing selected).
        private int GetSelectedId()
        {
            if (dgvSections.CurrentRow == null) return 0;
            object value = dgvSections.CurrentRow.Cells["SectionID"].Value;
            if (value == null || value == DBNull.Value) return 0;
            return Convert.ToInt32(value);
        }

        // When the user clicks a row, fill the textboxes so it can be edited.
        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // ignore clicks on the header
            DataGridViewRow row = dgvSections.Rows[e.RowIndex];

            object name = row.Cells["SectionName"].Value;
            object area = row.Cells["Area"].Value;

            txtName.Text = (name == null || name == DBNull.Value) ? "" : name.ToString();
            txtArea.Text = (area == null || area == DBNull.Value) ? "" : area.ToString();
        }

        // Empty the textboxes.
        private void ClearInput()
        {
            txtName.Clear();
            txtArea.Clear();
        }
    }
}
