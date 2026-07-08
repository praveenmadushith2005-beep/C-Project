using System.Data;

namespace TeaEstate
{
    // Member 07 — produces the management reports for the estate.
    // OOP: implements the shared IReportGenerator interface so the Reports screen
    // can treat it like any other report producer.
    // Each report method returns a DataTable ready to bind to a DataGridView.
    // Remember: 'Date' is a SQL reserved word, so it is always written [Date].
    public class ReportService : IReportGenerator
    {
        // IReportGenerator: a friendly title for the default report.
        public string ReportTitle
        {
            get { return "Worker Performance"; }
        }

        // IReportGenerator: the default report = worker performance.
        public DataTable GenerateReport()
        {
            return WorkerPerformanceReport();
        }

        // 1) Worker performance — each worker and the total yield (kg) they have picked.
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

        // 2) Attendance history — worker, date and status, newest first.
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

        // 3) Yield by section — each estate section and the total yield (kg) from it.
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

        // 4) Processing log — processing records joined to their raw yield batch,
        //    showing raw leaf in vs made tea out.
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
