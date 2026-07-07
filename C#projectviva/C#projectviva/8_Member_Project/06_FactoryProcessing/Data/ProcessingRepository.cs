using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    public class ProcessingRepository : IDataManager
    {
        public DataTable GetAll()
        {
            string sql =
                "SELECT p.ProcessID, p.YieldID, y.Quantity AS RawQuantity, " +
                "       p.ProcessingDate, p.ProcessedQuantity " +
                "FROM ProcessingRecord p " +
                "JOIN YieldRecord y ON p.YieldID = y.YieldID " +
                "ORDER BY p.ProcessingDate DESC, p.ProcessID DESC";

            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public void Add(ProcessingRecord record)
        {
            string sql =
                "INSERT INTO ProcessingRecord (YieldID, ProcessingDate, ProcessedQuantity) " +
                "VALUES (@YieldID, @ProcessingDate, @ProcessedQuantity)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@YieldID", record.YieldID),
                new SqlParameter("@ProcessingDate", record.ProcessingDate),
                new SqlParameter("@ProcessedQuantity", record.ProcessedQuantity)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteById(int id)
        {
            string sql = "DELETE FROM ProcessingRecord WHERE ProcessID = @id";
            DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@id", id));
        }
    }
}
