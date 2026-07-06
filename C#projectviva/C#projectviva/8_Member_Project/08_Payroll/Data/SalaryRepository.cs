using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public class SalaryRepository : IDataManager
    {
        
        public DataTable GetAll()
        {
            string sql =
                "SELECT s.PaymentID, w.Name AS WorkerName, s.[Month], s.DaysWorked, " +
                "s.DailyRate, s.YieldBonus, s.TotalAmount, s.PaidDate " +
                "FROM SalaryPayment s " +
                "INNER JOIN Worker w ON s.WorkerID = w.WorkerID " +
                "ORDER BY s.PaymentID";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        public void Add(SalaryPayment p)
        {
            string sql =
                "INSERT INTO SalaryPayment " +
                "([Month], WorkerID, DaysWorked, DailyRate, YieldBonus, TotalAmount, PaidDate) " +
                "VALUES (@m, @w, @days, @rate, @bonus, @total, @paid)";

            SqlParameter[] prms =
            {
                new SqlParameter("@m", p.Month),
                new SqlParameter("@w", p.WorkerId),
                new SqlParameter("@days", p.DaysWorked),
                new SqlParameter("@rate", p.DailyRate),
                new SqlParameter("@bonus", p.YieldBonus),
                new SqlParameter("@total", p.TotalAmount),
                new SqlParameter("@paid", p.PaidDate)
            };

            DatabaseHelper.ExecuteNonQuery(sql, prms);
        }

        
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM SalaryPayment WHERE PaymentID = @id";
            SqlParameter[] prms = { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, prms);
        }

        
        public DataTable GetWorkers()
        {
            string sql = "SELECT WorkerID, Name FROM Worker ORDER BY Name";
            return DatabaseHelper.ExecuteQuery(sql);
        }