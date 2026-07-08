using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
   
    public class SectionRepository : IDataManager
    {
        
        public DataTable GetAll()
        {
            
            string sql = "SELECT SectionID, SectionName, Area FROM EstateSection ORDER BY SectionName";
            return DatabaseHelper.ExecuteQuery(sql);
        }

        
        public void Add(EstateSection section)
        {
            string sql = "INSERT INTO EstateSection (SectionName, Area) VALUES (@name, @area)";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@name", section.SectionName),
                new SqlParameter("@area", section.Area)
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

        
        public void Update(EstateSection section)
        {
            string sql = "UPDATE EstateSection SET SectionName = @name, Area = @area WHERE SectionID = @id";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@name", section.SectionName),
                new SqlParameter("@area", section.Area),
                new SqlParameter("@id", section.SectionID)
            };

            DatabaseHelper.ExecuteNonQuery(sql, p);
        }

      
        public void DeleteById(int id)
        {
            string sql = "DELETE FROM EstateSection WHERE SectionID = @id";
            SqlParameter[] p = new SqlParameter[] { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, p);
        }
    }
}
