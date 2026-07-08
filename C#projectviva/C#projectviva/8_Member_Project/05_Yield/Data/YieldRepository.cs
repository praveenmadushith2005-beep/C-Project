using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public class YieldRepository : IDataManager
    {
        
        public DataTable GetAll()
        {
            string sql =
                "SELECT y.YieldID, w.Name, s.SectionName, y.Quantity, y.[Date] " +
                "FROM YieldRecord y " +
                "JOIN Worker w ON y.WorkerID = w.WorkerID " +
                "JOIN EstateSection s ON y.SectionID = s.SectionID";

            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public void Add(YieldRecord record)
        {
            string sql =
                "INSERT INTO YieldRecord (WorkerID, SectionID, Quantity, [Date]) " +
                "VALUES (@workerId, @sectionId, @quantity, @date)";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@workerId", record.WorkerID),
                new SqlParameter("@sectionId", record.SectionID),
                new SqlParameter("@quantity", record.Quantity),
                new SqlParameter("@date", record.Date)
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM YieldRecord WHERE YieldID = @id";
            SqlParameter[] p = new SqlParameter[] { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public DataTable TotalBySection()
        {
            string sql =
                "SELECT s.SectionName, SUM(y.Quantity) AS TotalQuantity " +
                "FROM YieldRecord y " +
                "JOIN EstateSection s ON y.SectionID = s.SectionID " +
                "GROUP BY s.SectionName";

            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public DataTable TotalByWorker()
        {
            string sql =
                "SELECT w.Name, SUM(y.Quantity) AS TotalQuantity " +
                "FROM YieldRecord y " +
                "JOIN Worker w ON y.WorkerID = w.WorkerID " +
                "GROUP BY w.Name";

            return DatabaseHelper.ExecuteQuery(sql);
        }
    }
}
