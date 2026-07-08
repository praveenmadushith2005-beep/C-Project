using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
   
    public partial class ProcessingForm : Form
    {
     
        private readonly ProcessingRepository _repo = new ProcessingRepository();

        public ProcessingForm()
        {
            InitializeComponent();  
            LoadYields();           
            LoadGrid();              
        }

       
        private void LoadYields()
        {
            try
            {
                string sql = "SELECT YieldID, Quantity FROM YieldRecord ORDER BY YieldID";
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);

              
                if (!dt.Columns.Contains("Display"))
                    dt.Columns.Add("Display", typeof(string));

                foreach (DataRow row in dt.Rows)
                    row["Display"] = "Yield #" + row["YieldID"] + " - " + row["Quantity"] + " kg";

                cmbYield.DataSource = dt;
                cmbYield.DisplayMember = "Display";
                cmbYield.ValueMember = "YieldID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

      
        private void LoadGrid()
        {
            try
            {
                dgvProcessing.DataSource = _repo.GetAll();
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
                
                if (cmbYield.SelectedValue == null)
                {
                    MessageBox.Show("Please select a yield batch.", "Validation");
                    return;
                }

            
                if (string.IsNullOrWhiteSpace(txtProcessed.Text))
                {
                    MessageBox.Show("Please enter the processed quantity.", "Validation");
                    return;
                }

                decimal processed;
                if (!decimal.TryParse(txtProcessed.Text.Trim(), out processed) || processed <= 0)
                {
                    MessageBox.Show("Processed quantity must be a number greater than 0.", "Validation");
                    return;
                }

              
                ProcessingRecord record = new ProcessingRecord();
                record.YieldID = Convert.ToInt32(cmbYield.SelectedValue);
                record.ProcessingDate = dtpDate.Value.Date;
                record.ProcessedQuantity = processed;

                _repo.Add(record);

                MessageBox.Show("Processing record added.", "Success");
                ClearInputs();
                LoadGrid();
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
                if (dgvProcessing.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to delete.", "Validation");
                    return;
                }

                object value = dgvProcessing.CurrentRow.Cells["ProcessID"].Value;
                if (value == null || value == DBNull.Value)
                {
                    MessageBox.Show("Please select a row to delete.", "Validation");
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    "Delete the selected processing record?", "Confirm", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes) return;

                _repo.DeleteById(Convert.ToInt32(value));

                MessageBox.Show("Processing record deleted.", "Success");
                ClearInputs();
                LoadGrid();
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
            LoadGrid();
        }

     
        private void dgvProcessing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvProcessing.Rows[e.RowIndex];

                object yieldVal = row.Cells["YieldID"].Value;
                if (yieldVal != null && yieldVal != DBNull.Value)
                    cmbYield.SelectedValue = Convert.ToInt32(yieldVal);

                object dateVal = row.Cells["ProcessingDate"].Value;
                if (dateVal != null && dateVal != DBNull.Value)
                    dtpDate.Value = Convert.ToDateTime(dateVal);

                object procVal = row.Cells["ProcessedQuantity"].Value;
                if (procVal != null && procVal != DBNull.Value)
                    txtProcessed.Text = procVal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

      
        private void ClearInputs()
        {
            txtProcessed.Clear();
            dtpDate.Value = DateTime.Today;
            if (cmbYield.Items.Count > 0) cmbYield.SelectedIndex = 0;
        }
    }
}
