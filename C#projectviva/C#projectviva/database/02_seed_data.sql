USE TeaEstateDB;
GO


INSERT INTO [User] (Username, Password, Role) VALUES
('admin',      'admin123',   'Manager'),
('supervisor', 'super123',   'Supervisor'),
('officer',    'officer123', 'ProcessingOfficer');

INSERT INTO Worker (Name, Address, ContactNo, Position) VALUES
('K. Perera',   'Nuwara Eliya', '0771234567', 'Plucker'),
('S. Fernando', 'Hatton',       '0779876543', 'Plucker'),
('R. Silva',    'Maskeliya',    '0712223334', 'Field Hand');

INSERT INTO EstateSection (SectionName, Area) VALUES
('Section A', 12.50),
('Section B',  8.00),
('Section C', 15.25);

INSERT INTO YieldRecord (WorkerID, SectionID, Quantity, [Date]) VALUES
(1,1,42.5,'2026-01-10'), (2,1,38.0,'2026-01-10'),
(1,2,40.0,'2026-02-10'), (2,2,45.5,'2026-02-10'),
(1,1,50.0,'2026-03-10'), (3,3,30.0,'2026-03-10'),
(1,1,55.0,'2026-04-10'), (2,2,48.0,'2026-04-10'),
(1,1,60.0,'2026-05-10'), (3,3,35.0,'2026-05-10');

INSERT INTO Attendance (WorkerID, [Date], Status) VALUES
(1,'2026-06-16','Present'),
(2,'2026-06-16','Present'),
(3,'2026-06-16','Absent');

INSERT INTO ProcessingRecord (YieldID, ProcessingDate, ProcessedQuantity) VALUES
(1,'2026-01-11',38.0),
(2,'2026-01-11',34.0);

INSERT INTO SalaryPayment (WorkerID, [Month], DaysWorked, DailyRate, YieldBonus, TotalAmount, PaidDate) VALUES
(1,'2026-05',24,1500.00,500.00,36500.00,'2026-06-01'),
(2,'2026-05',22,1500.00,300.00,33300.00,'2026-06-01');
GO
