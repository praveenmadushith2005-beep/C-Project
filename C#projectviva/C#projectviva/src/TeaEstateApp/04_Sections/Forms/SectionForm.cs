using System;
using System.Data;

namespace TeaEstate
{
    
    public partial class SectionForm : Form
    {
        
        private readonly SectionRepository _repo = new SectionRepository();

        public SectionForm()
        {
            InitializeComponent();   
            LoadSections();          
        }

        
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

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EstateSection section = ReadInput();
                if (section == null) return;   

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

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadSections();
        }

        
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

        
        private int GetSelectedId()
        {
            if (dgvSections.CurrentRow == null) return 0;
            object value = dgvSections.CurrentRow.Cells["SectionID"].Value;
            if (value == null || value == DBNull.Value) return 0;
            return Convert.ToInt32(value);
        }

       
        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  
            DataGridViewRow row = dgvSections.Rows[e.RowIndex];

            object name = row.Cells["SectionName"].Value;
            object area = row.Cells["Area"].Value;

            txtName.Text = (name == null || name == DBNull.Value) ? "" : name.ToString();
            txtArea.Text = (area == null || area == DBNull.Value) ? "" : area.ToString();
        }

     
        private void ClearInput()
        {
            txtName.Clear();
            txtArea.Clear();
        }
    }
}
