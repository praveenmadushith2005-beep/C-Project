using System.Data;

namespace TeaEstate
{
    
    public class ReportService : IReportGenerator
    {
        
        public string ReportTitle
        {
            get { return "Worker Performance"; }
        }

        
        public DataTable GenerateReport()
        {
            return WorkerPerformanceReport();
        }

 
        public DataTable WorkerPerformanceReport()
        {
            string sql =
                "SELECT w.Name AS Worker, " +
                "       SUM(y.Quantity) AS TotalYieldKg " +
                "FROM Worker w " +
                "JOIN YieldRecord y ON w.WorkerID = y.WorkerID " +
                "GROUP BY w.Name " +
                "ORDER BY SUM(y.Quantity) DESC";

            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public DataTable AttendanceHistoryReport()
        {
            string sql =
                "SELECT w.Name AS Worker, " +
                "       a.[Date] AS [Date], " +
                "       a.Status AS Status " +
                "FROM Attendance a " +
                "JOIN Worker w ON a.WorkerID = w.WorkerID " +
                "ORDER BY a.[Date] DESC";

            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public DataTable YieldBySectionReport()
        {
            string sql =
                "SELECT s.SectionName AS Section, " +
                "       SUM(y.Quantity) AS TotalYieldKg " +
                "FROM EstateSection s " +
                "JOIN YieldRecord y ON s.SectionID = y.SectionID " +
                "GROUP BY s.SectionName " +
                "ORDER BY SUM(y.Quantity) DESC";

            return DatabaseHelper.ExecuteQuery(sql);
        }

       
        public DataTable ProcessingLogReport()
        {
            string sql =
                "SELECT p.ProcessID, " +
                "       p.YieldID, " +
                "       y.Quantity AS RawQuantityKg, " +
                "       p.ProcessingDate, " +
                "       p.ProcessedQuantity AS ProcessedKg " +
                "FROM ProcessingRecord p " +
                "JOIN YieldRecord y ON p.YieldID = y.YieldID " +
                "ORDER BY p.ProcessingDate DESC, p.ProcessID DESC";

            return DatabaseHelper.ExecuteQuery(sql);
        }
    }
}
