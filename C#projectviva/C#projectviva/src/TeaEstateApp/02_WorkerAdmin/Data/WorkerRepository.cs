using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    // Member 02 — all database work for the Worker table lives here.
    // OOP: implements the shared IDataManager interface (Member 01),
    //      so the rest of the app can treat every repository the same way.
    // All SQL uses SqlParameter (safe from SQL injection) and goes through DatabaseHelper.
    public class WorkerRepository : IDataManager
    {
        // Return every worker as a table (ready to bind to a DataGridView).
        public DataTable GetAll()
        {
            string sql = "SELECT WorkerID, Name, Address, ContactNo, Position FROM Worker";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        // Add a new worker. WorkerID is IDENTITY so the database creates it.
        public void Add(Worker w)
        {
            string sql = "INSERT INTO Worker (Name, Address, ContactNo, Position) " +
                         "VALUES (@n, @a, @c, @p)";

            // Use DBNull for empty optional fields so we never pass a C# null to SQL.
            SqlParameter[] p =
            {
                new SqlParameter("@n", w.Name),
                new SqlParameter("@a", Box(w.Address)),
                new SqlParameter("@c", Box(w.ContactNo)),
                new SqlParameter("@p", Box(w.Position))
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        // Update an existing worker, matched by its primary key (Id).
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

        // Delete one worker by primary key (required by IDataManager).
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM Worker WHERE WorkerID = @id";
            SqlParameter[] p = { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        // Search by name or position (case-insensitive LIKE).
        public DataTable Search(string term)
        {
            string sql = "SELECT WorkerID, Name, Address, ContactNo, Position FROM Worker " +
                         "WHERE Name LIKE @t OR Position LIKE @t";

            // Wrap the term with % so it matches anywhere in the text.
            SqlParameter[] p = { new SqlParameter("@t", "%" + term + "%") };
            return DatabaseHelper.ExecuteQuery(sql, p);
        }

        // Helper: turn a null/empty optional string into DBNull so SQL stores a real NULL
        // instead of throwing on a C# null parameter value.
        private static object Box(string value)
        {
            return string.IsNullOrEmpty(value) ? (object)DBNull.Value : value;
        }
    }
}
