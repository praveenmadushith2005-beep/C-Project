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

        
        public static void EnsureDatabase()
        {
            
            using (SqlConnection master = new SqlConnection(MasterConnectionString))
            {
                master.Open();
                using (SqlCommand create = new SqlCommand(
                    "IF DB_ID('TeaEstateDB') IS NULL CREATE DATABASE TeaEstateDB;", master))
                {
                    create.ExecuteNonQuery();
                }
            }

            
            using (SqlConnection con = GetConnection())
            {
                con.Open();

                using (SqlCommand check = new SqlCommand("SELECT OBJECT_ID('[User]','U');", con))
                {
                    object result = check.ExecuteScalar();
                    if (result != null && result != DBNull.Value) return; 
                }

                using (SqlCommand setup = new SqlCommand(CreateAndSeedSql, con))
                {
                    setup.ExecuteNonQuery();
                }
            }
        }

       
        private const string CreateAndSeedSql = @"
CREATE TABLE Worker (
    WorkerID  INT IDENTITY(1,1) PRIMARY KEY,
    Name      NVARCHAR(100) NOT NULL,
    Address   NVARCHAR(200),
    ContactNo NVARCHAR(20),
    Position  NVARCHAR(50)
);
CREATE TABLE EstateSection (
    SectionID   INT IDENTITY(1,1) PRIMARY KEY,
    SectionName NVARCHAR(100) NOT NULL,
    Area        DECIMAL(10,2)
);
CREATE TABLE Attendance (
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
    WorkerID     INT NOT NULL FOREIGN KEY REFERENCES Worker(WorkerID),
    [Date]       DATE NOT NULL,
    Status       NVARCHAR(20) NOT NULL
);
CREATE TABLE YieldRecord (
    YieldID   INT IDENTITY(1,1) PRIMARY KEY,
    WorkerID  INT NOT NULL FOREIGN KEY REFERENCES Worker(WorkerID),
    SectionID INT NOT NULL FOREIGN KEY REFERENCES EstateSection(SectionID),
    Quantity  DECIMAL(10,2) NOT NULL,
    [Date]    DATE NOT NULL
);
CREATE TABLE ProcessingRecord (
    ProcessID         INT IDENTITY(1,1) PRIMARY KEY,
    YieldID           INT NOT NULL FOREIGN KEY REFERENCES YieldRecord(YieldID),
    ProcessingDate    DATE NOT NULL,
    ProcessedQuantity DECIMAL(10,2) NOT NULL
);
CREATE TABLE [User] (
    UserID   INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role     NVARCHAR(30) NOT NULL
);
CREATE TABLE SalaryPayment (
    PaymentID   INT IDENTITY(1,1) PRIMARY KEY,
    WorkerID    INT NOT NULL FOREIGN KEY REFERENCES Worker(WorkerID),
    [Month]     NVARCHAR(7) NOT NULL,
    DaysWorked  INT NOT NULL,
    DailyRate   DECIMAL(10,2) NOT NULL,
    YieldBonus  DECIMAL(10,2) NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    PaidDate    DATE NOT NULL
);

INSERT INTO [User] (Username, Password, Role) VALUES
('admin','admin123','Manager'),
('supervisor','super123','Supervisor'),
('officer','officer123','ProcessingOfficer');

INSERT INTO Worker (Name, Address, ContactNo, Position) VALUES
('K. Perera','Nuwara Eliya','0771234567','Plucker'),
('S. Fernando','Hatton','0779876543','Plucker'),
('R. Silva','Maskeliya','0712223334','Field Hand');

INSERT INTO EstateSection (SectionName, Area) VALUES
('Section A',12.50),('Section B',8.00),('Section C',15.25);

INSERT INTO YieldRecord (WorkerID, SectionID, Quantity, [Date]) VALUES
(1,1,42.5,'2026-01-10'),(2,1,38.0,'2026-01-10'),
(1,2,40.0,'2026-02-10'),(2,2,45.5,'2026-02-10'),
(1,1,50.0,'2026-03-10'),(3,3,30.0,'2026-03-10'),
(1,1,55.0,'2026-04-10'),(2,2,48.0,'2026-04-10'),
(1,1,60.0,'2026-05-10'),(3,3,35.0,'2026-05-10');

INSERT INTO Attendance (WorkerID, [Date], Status) VALUES
(1,'2026-06-16','Present'),(2,'2026-06-16','Present'),(3,'2026-06-16','Absent');

INSERT INTO ProcessingRecord (YieldID, ProcessingDate, ProcessedQuantity) VALUES
(1,'2026-01-11',38.0),(2,'2026-01-11',34.0);

INSERT INTO SalaryPayment (WorkerID, [Month], DaysWorked, DailyRate, YieldBonus, TotalAmount, PaidDate) VALUES
(1,'2026-05',24,1500.00,500.00,36500.00,'2026-06-01'),
(2,'2026-05',22,1500.00,300.00,33300.00,'2026-06-01');
";
    }
}
