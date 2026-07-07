using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TeaEstate
{
    
    public static class DatabaseHelper
    {
        
        public static string ConnectionString =>
            "Server=(localdb)\\MSSQLLocalDB;Database=TeaEstateDB;" +
            "Trusted_Connection=True;TrustServerCertificate=True;";

        
        private static string MasterConnectionString =>
            "Server=(localdb)\\MSSQLLocalDB;Database=master;" +
            "Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

       
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                con.Open();
                return cmd.ExecuteScalar();
            }
        }

        
