# Tea Estate Management System — BUILD CONTRACT (read before coding)

ONE .NET 8 WinForms app. ONE solution, ONE project (`TeaEstateApp`), organised into **8 member folders**
(one folder per team member). The project file `src/TeaEstateApp/TeaEstateApp.csproj` is SDK-style:
it auto-includes every `.cs` (and `.Designer.cs` / `.resx`) under it, so you NEVER edit the csproj —
just work inside your own folder.

The project now lives on **GitHub with a branch-per-member workflow** — each member works on their OWN
branch and only inside their OWN module folder, then opens a Pull Request. See `GITHUB_GUIDE.md`
(how to clone, branch, commit, push, PR) and `TEAM_TASKS.md` (who does what).

## RULES EVERY MEMBER MUST FOLLOW
1. Namespace for EVERY file: `namespace TeaEstate` (one flat namespace — no per-folder namespaces).
2. `ImplicitUsings` is ON. These are already available without `using`: `System`, `System.Linq`,
   `System.Collections.Generic`, `System.Windows.Forms`, `System.Drawing`, `System.Threading.Tasks`.
   You MUST still add explicitly when you use the DB: `using System.Data;` and `using Microsoft.Data.SqlClient;`
3. Forms are **Visual Studio Designer-based**: each form is THREE files —
   `XxxForm.cs` (your code / event handlers), `XxxForm.Designer.cs` (the controls, edited in the
   drag-and-drop designer), and `XxxForm.resx` (the form's resources). You may design a form by
   dragging controls in the VS designer OR by editing `.Designer.cs` directly — both are fine.
   - **Why Designer files are now safe** (the old contract banned them to avoid merge conflicts):
     the app is split so **each member owns exactly ONE folder** and works on their **OWN branch**.
     Two people never edit the same form or the same `.resx` at the same time, so the binary-ish
     `.resx` / `.Designer.cs` files never collide. Designer files only cause merge pain when two
     people edit the *same* form — and our ownership split guarantees that never happens.
4. Only create/edit files **inside your own folder**. Never touch another member's files, `Program.cs`, or the csproj.
5. ALL database access goes through `DatabaseHelper` (do not write your own connection strings).
6. Wrap every DB call in `try/catch` and show errors with `MessageBox.Show(ex.Message, "Error")`.
   Validate inputs before saving (reject blank required fields with a MessageBox).
7. Keep it beginner-level and readable. Plain code, short methods, helpful comments.

## MODULE OWNERSHIP (8 folders → 8 members)

| # | Folder (`src/TeaEstateApp/…`) | Member / module | Fixed form class names | DB table(s) |
|---|-------------------------------|-----------------|------------------------|-------------|
| 01 | `01_Core_Auth` | Core & Auth (shell + shared core) | `LoginForm`, `MainDashboard`, `ChangePasswordForm` | `[User]` |
| 02 | `02_WorkerAdmin` | Worker Admin (Worker / Manager / Supervisor) | `WorkerForm` | `Worker` |
| 03 | `03_Attendance` | Attendance | `AttendanceForm` | `Attendance` |
| 04 | `04_Sections` | Estate Sections | `SectionForm` | `EstateSection` |
| 05 | `05_Yield` | Tea Yield | `YieldForm` | `YieldRecord` |
| 06 | `06_Factory_Processing` | Factory Processing | `ProcessingForm` | `ProcessingRecord` |
| 07 | `07_Reports_AI` | Reports & AI Forecast | `ReportsForm`, `ForecastForm` | (reads all tables) |
| 08 | `08_Payroll` | Payroll / Salary (NEW) | `PayrollForm` | `SalaryPayment` |

There are also 8 standalone, copyable single-member projects in
`8_Member_Projects/{01_CoreAuth … 08_Payroll}` for members who want to run only their part.

## SHARED CORE (Member 01 owns; everyone calls it) — these already exist in 01_Core_Auth
- `static class DatabaseHelper`
  - `static string ConnectionString`
  - `static void EnsureDatabase()`   // auto-creates DB + tables + seed data on first run
  - `static SqlConnection GetConnection()`
  - `static DataTable ExecuteQuery(string sql, params SqlParameter[] p)`   // SELECT → table
  - `static int ExecuteNonQuery(string sql, params SqlParameter[] p)`       // INSERT/UPDATE/DELETE → rows affected
  - `static object ExecuteScalar(string sql, params SqlParameter[] p)`      // single value
- `static class Session { public static User CurrentUser; }`               // logged-in user; check `.Role`
- `abstract class Person { int Id; string Name; string Address; string ContactNo;
                            abstract string GetRoleDescription(); virtual string GetSummary(); }`
- `class User { int UserId; string Username; string Password; string Role; }`
- `interface IDataManager { DataTable GetAll(); void DeleteById(int id); }`
- `interface IReportGenerator { string ReportTitle { get; } DataTable GenerateReport(); }`

## DATABASE (Microsoft SQL Server LocalDB — database `TeaEstateDB`)
- Engine: **SQL Server LocalDB**. Data access uses **`Microsoft.Data.SqlClient`** with **`SqlParameter`**
  through the shared `DatabaseHelper`.
- Connection string: `Server=(localdb)\MSSQLLocalDB;Database=TeaEstateDB;Trusted_Connection=True;...`
- **No manual setup needed.** `DatabaseHelper.EnsureDatabase()` (called once from `Program.Main`)
  auto-creates the `TeaEstateDB` database, all tables, and the seed data on first run.
- The `/database/*.sql` scripts are also kept (for running in SSMS / `sqlcmd` and for marking),
  but you do not have to run them by hand.

Tables:
- `Worker`(WorkerID PK IDENTITY, Name, Address, ContactNo, Position)
- `Attendance`(AttendanceID PK IDENTITY, WorkerID FK→Worker, [Date], Status)
- `EstateSection`(SectionID PK IDENTITY, SectionName, Area DECIMAL)
- `YieldRecord`(YieldID PK IDENTITY, WorkerID FK→Worker, SectionID FK→EstateSection, Quantity DECIMAL, [Date])
- `ProcessingRecord`(ProcessID PK IDENTITY, YieldID FK→YieldRecord, ProcessingDate, ProcessedQuantity DECIMAL)
- `SalaryPayment`(PaymentID PK IDENTITY, WorkerID FK→Worker, [Month] NVARCHAR(7), DaysWorked INT,
  DailyRate DECIMAL, YieldBonus DECIMAL, TotalAmount DECIMAL, PaidDate DATE)   — **NEW (Member 08)**
- `[User]`(UserID PK IDENTITY, Username UNIQUE, Password, Role)
- Login seed: admin/admin123 (Manager) · supervisor/super123 (Supervisor) · officer/officer123 (ProcessingOfficer)
- NOTE: `User` and `Date` are reserved words → in SQL always write `[User]` and `[Date]`.

## REPOSITORIES (each implements `IDataManager`)
`WorkerRepository`, `AttendanceRepository`, `SectionRepository`, `YieldRepository`,
`ProcessingRepository`, and **`SalaryRepository`** (NEW — Member 08, owns the `SalaryPayment` table).
Reporting uses `ReportService` (implements `IReportGenerator`, 4 reports) and the AI helper
`YieldForecaster` (least-squares trend line).

## FIXED FORM CLASS NAMES (MainDashboard opens these by name — do not rename)
- Member 01: `LoginForm`, `MainDashboard`, `ChangePasswordForm`
- Member 02: `WorkerForm`
- Member 03: `AttendanceForm`
- Member 04: `SectionForm`
- Member 05: `YieldForm`
- Member 06: `ProcessingForm`
- Member 07: `ReportsForm`, `ForecastForm`
- Member 08: `PayrollForm`
Every form MUST have a `public` parameterless constructor.

## ROLE VISIBILITY (MainDashboard buttons)
- Manager           → Workers, Attendance, Sections, Yield, Processing, Reports, Forecast, **Payroll**
- Supervisor        → Attendance, Sections, Yield
- ProcessingOfficer → Processing
- Everyone          → Change Password, Logout

## OOP REQUIREMENTS (proposal §8 — must be demonstrably present)
- Encapsulation: private fields + public properties (models).
- Inheritance: `Worker : Person`, `Supervisor : Worker`, `Manager : Worker`.
- Polymorphism: override `GetSummary()` / `GetRoleDescription()` per subclass.
- Abstraction: `Person` is abstract with an abstract method.
- Interfaces: every repository implements `IDataManager`; report service implements `IReportGenerator`.
