IF DB_ID('TeaEstateDB') IS NULL
    CREATE DATABASE TeaEstateDB;
GO

USE TeaEstateDB;
GO


IF OBJECT_ID('SalaryPayment','U')    IS NOT NULL DROP TABLE SalaryPayment;
IF OBJECT_ID('ProcessingRecord','U') IS NOT NULL DROP TABLE ProcessingRecord;
IF OBJECT_ID('YieldRecord','U')      IS NOT NULL DROP TABLE YieldRecord;
IF OBJECT_ID('Attendance','U')       IS NOT NULL DROP TABLE Attendance;
IF OBJECT_ID('EstateSection','U')    IS NOT NULL DROP TABLE EstateSection;
IF OBJECT_ID('Worker','U')           IS NOT NULL DROP TABLE Worker;
IF OBJECT_ID('[User]','U')           IS NOT NULL DROP TABLE [User];
GO

CREATE TABLE Worker (
    WorkerID  INT IDENTITY(1,1) PRIMARY KEY,
    Name      NVARCHAR(100) NOT NULL,
    Address   NVARCHAR(200),
    ContactNo NVARCHAR(20),
    Position  NVARCHAR(50)
);

CREATE TABLE Attendance (
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
    WorkerID     INT NOT NULL FOREIGN KEY REFERENCES Worker(WorkerID),
    [Date]       DATE NOT NULL,
    Status       NVARCHAR(20) NOT NULL          
);

CREATE TABLE EstateSection (
    SectionID   INT IDENTITY(1,1) PRIMARY KEY,
    SectionName NVARCHAR(100) NOT NULL,
    Area        DECIMAL(10,2)                    
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
GO
