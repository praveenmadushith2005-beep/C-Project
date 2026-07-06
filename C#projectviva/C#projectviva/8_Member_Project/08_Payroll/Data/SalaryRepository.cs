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
