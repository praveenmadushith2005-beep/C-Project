using System;
using System.Data;

namespace TeaEstate
{
    
    public class ForecastResult
    {
        public double Predicted { get; set; }   
        public double Slope { get; set; }       
        public string Trend { get; set; }       
        public DataTable History { get; set; }   
    }

    public class YieldForecaster
    {
        
        public ForecastResult Predict()
        {
            
            string sql =
                "SELECT YEAR([Date]) AS [Year], " +
                "       MONTH([Date]) AS [Month], " +
                "       SUM(Quantity) AS TotalYieldKg " +
                "FROM YieldRecord " +
                "GROUP BY YEAR([Date]), MONTH([Date]) " +
                "ORDER BY [Year], [Month]";

            DataTable history = DatabaseHelper.ExecuteQuery(sql);

            ForecastResult result = new ForecastResult();
            result.History = history;

            int n = history.Rows.Count;   

            if (n == 0)
            {
                result.Predicted = 0;
                result.Slope = 0;
                result.Trend = "flat";
                return result;
            }
            if (n == 1)
            {
               
                result.Predicted = Math.Max(0, Convert.ToDouble(history.Rows[0]["TotalYieldKg"]));
                result.Slope = 0;
                result.Trend = "flat";
                return result;
            }

            
            double sumX = 0;  
            double sumY = 0;   
            double sumXY = 0;  
            double sumXX = 0; 

            for (int i = 0; i < n; i++)
            {
                double x = i;  
                double yVal = Convert.ToDouble(history.Rows[i]["TotalYieldKg"]);

                sumX += x;
                sumY += yVal;
                sumXY += x * yVal;
                sumXX += x * x;
            }

            
            double denominator = (n * sumXX) - (sumX * sumX);

            double b;  
            double a;  
            if (denominator == 0)
            {
                
                b = 0;
                a = sumY / n;
            }
            else
            {
                b = ((n * sumXY) - (sumX * sumY)) / denominator;
                a = (sumY - (b * sumX)) / n;
            }

          
            double nextIndex = n;
            double predicted = a + (b * nextIndex);

            
            if (predicted < 0) predicted = 0;

           
            string trend;
            if (b > 0.5) trend = "rising";
            else if (b < -0.5) trend = "falling";
            else trend = "flat";

            result.Predicted = predicted;
            result.Slope = b;
            result.Trend = trend;
            return result;
        }
    }
}
