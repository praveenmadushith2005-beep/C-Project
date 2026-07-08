using System;

namespace TeaEstate
{
   
    public partial class ForecastForm : Form
    {
        
        private readonly YieldForecaster _forecaster = new YieldForecaster();

        public ForecastForm()
        {
            InitializeComponent();  
        }

      
        private void btnForecast_Click(object sender, EventArgs e)
        {
            try
            {
                ForecastResult result = _forecaster.Predict();

               
                dgvHistory.DataSource = result.History;

                
                lblResult.Text =
                    "Predicted next month: " + result.Predicted.ToString("N1") + " kg" +
                    Environment.NewLine +
                    "Trend: " + result.Trend +
                    "   (slope " + result.Slope.ToString("N1") + " kg/month)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
