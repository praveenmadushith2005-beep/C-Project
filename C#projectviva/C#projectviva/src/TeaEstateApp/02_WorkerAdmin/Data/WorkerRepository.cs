using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public class WorkerRepository : IDataManager
    {
        
        public DataTable GetAll()
        {
            string sql = "SELECT WorkerID, Name, Address, ContactNo, Position FROM Worker";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public void Add(Worker w)
        {
            string sql = "INSERT INTO Worker (Name, Address, ContactNo, Position) " +
                         "VALUES (@n, @a, @c, @p)";

            
            SqlParameter[] p =
            {
                new SqlParameter("@n", w.Name),
                new SqlParameter("@a", Box(w.Address)),
                new SqlParameter("@c", Box(w.ContactNo)),
                new SqlParameter("@p", Box(w.Position))
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public void Update(Worker w)
        {
            string sql = "UPDATE Worker SET Name = @n, Address = @a, ContactNo = @c, Position = @p " +
                         "WHERE WorkerID = @id";

            SqlParameter[] p =
            {
                new SqlParameter("@n", w.Name),
                new SqlParameter("@a", Box(w.Address)),
                new SqlParameter("@c", Box(w.ContactNo)),
                new SqlParameter("@p", Box(w.Position)),
                new SqlParameter("@id", w.Id)
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM Worker WHERE WorkerID = @id";
            SqlParameter[] p = { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public DataTable Search(string term)
        {
            string sql = "SELECT WorkerID, Name, Address, ContactNo, Position FROM Worker " +
                         "WHERE Name LIKE @t OR Position LIKE @t";

            
            SqlParameter[] p = { new SqlParameter("@t", "%" + term + "%") };
            return DatabaseHelper.ExecuteQuery(sql, p);
        }

        
        private static object Box(string value)
        {
            return string.IsNullOrEmpty(value) ? (object)DBNull.Value : value;
        }
    }
}
