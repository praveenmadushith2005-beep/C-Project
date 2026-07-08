using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public class AttendanceRepository : IDataManager
    {
        
        public DataTable GetAll()
        {
            string sql =
                "SELECT a.AttendanceID, a.WorkerID, w.Name, a.[Date], a.Status " +
                "FROM Attendance a " +
                "JOIN Worker w ON a.WorkerID = w.WorkerID " +
                "ORDER BY a.[Date] DESC, w.Name";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public void Add(Attendance attendance)
        {
            string sql =
                "INSERT INTO Attendance (WorkerID, [Date], Status) " +
                "VALUES (@w, @d, @s)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@w", attendance.WorkerID),
                new SqlParameter("@d", attendance.Date.Date),  
                new SqlParameter("@s", attendance.Status)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM Attendance WHERE AttendanceID = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        
        public DataTable GetByDate(DateTime d)
        {
            string sql =
                "SELECT a.AttendanceID, a.WorkerID, w.Name, a.[Date], a.Status " +
                "FROM Attendance a " +
                "JOIN Worker w ON a.WorkerID = w.WorkerID " +
                "WHERE a.[Date] = @d " +
                "ORDER BY w.Name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@d", d.Date)
            };
            return DatabaseHelper.ExecuteQuery(sql, parameters);
        }

        
        public DataTable MonthlySummary(int month, int year)
        {
            string sql =
                "SELECT w.WorkerID, w.Name, " +
                "  SUM(CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END) AS PresentDays, " +
                "  SUM(CASE WHEN a.Status = 'Absent'  THEN 1 ELSE 0 END) AS AbsentDays, " +
                "  SUM(CASE WHEN a.Status = 'Leave'   THEN 1 ELSE 0 END) AS LeaveDays " +
                "FROM Attendance a " +
                "JOIN Worker w ON a.WorkerID = w.WorkerID " +
                "WHERE MONTH(a.[Date]) = @m " +
                "  AND YEAR(a.[Date]) = @y " +
                "GROUP BY w.WorkerID, w.Name " +
                "ORDER BY w.Name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@m", month),
                new SqlParameter("@y", year)
            };
            return DatabaseHelper.ExecuteQuery(sql, parameters);
        }
    }
}
