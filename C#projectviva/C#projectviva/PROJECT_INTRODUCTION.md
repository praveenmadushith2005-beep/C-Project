# Tea Estate Management System — Project Introduction

> A team project for the **CS107.3 – Object Oriented Programming with C#** module.
> Built by a team of **8 members** collaborating on **GitHub** (one branch per member).

---

## 1. Introduction

The **Tea Estate Management System** is a Windows desktop application that helps a tea
estate run its **day-to-day crop and labour work** from one place. Today many small and
mid-sized estates still keep workers, attendance, plucking yield, factory processing and
salaries in paper books or scattered Excel sheets. That makes the data easy to lose, hard
to total up, and almost impossible to analyse.

Our system replaces those paper books with a single, simple program. A user **logs in**,
the app shows a **dashboard with only the buttons their role is allowed to use**, and from
there they reach **8 feature modules** that each manage one part of the estate. All data is
stored in a **Microsoft SQL Server (LocalDB)** database, and the app even includes a small
**AI yield forecast** that predicts next month's tea harvest from past records.

The project is written in **C# / .NET 8 using Windows Forms**, and is built and shared by a
team of 8 students using **Git and GitHub**, where every member owns one module and works on
their own branch.

---

## 2. The problem we are solving

| Problem on a paper-based estate | How our system fixes it |
|---|---|
| Worker details kept in notebooks, easily lost | Stored once in a `Worker` table; searchable |
| Attendance counted by hand at month end | One click gives a per-worker monthly summary |
| Plucking yield per section/worker not totalled | Automatic totals by section and by worker |
| Factory processing not linked to the raw leaf it came from | Every processing record links back to its yield batch |
| Salary worked out manually, prone to mistakes | Auto-calculated: `days × rate + yield bonus` |
| No way to see trends or plan ahead | Reports + an AI forecast of next month's yield |
| Anyone could see/edit everything | Role-based login (Manager / Supervisor / Officer) |

---

## 3. Objectives

1. Build **one integrated desktop app** that covers the whole estate workflow:
   workers → attendance → sections → yield → processing → reports → payroll.
2. Apply the **core OOP principles** taught in CS107.3 (encapsulation, inheritance,
   polymorphism, abstraction, interfaces) in a real, working program.
3. Use a **relational database** (SQL Server) with proper tables, keys and parameterised
   queries (safe from SQL injection).
4. Demonstrate **team software engineering**: split the work cleanly into 8 modules and
   collaborate through **GitHub** without overwriting each other's code.
5. Add a **simple, explainable AI feature** (least-squares yield forecast) with **no external
   libraries**.

---

## 4. Who uses it (roles)

The app has three login roles. The dashboard shows **only** the modules each role may use.

| Role | Can open |
|------|----------|
| **Manager** | Everything — Workers, Attendance, Sections, Yield, Processing, Reports, Forecast, **Payroll** |
| **Supervisor** | Attendance, Sections, Yield |
| **ProcessingOfficer** | Processing |
| *(everyone)* | Change Password, Logout |

Seeded test logins (created automatically on first run):

| Username | Password | Role |
|----------|----------|------|
| `admin` | `admin123` | Manager |
| `supervisor` | `super123` | Supervisor |
| `officer` | `officer123` | ProcessingOfficer |

---

## 5. The 8 feature modules (and the 8-member split)

Each member owns exactly **one module folder** in `src/TeaEstateApp/` and **one GitHub
branch**. This is what lets 8 people work at the same time without conflicts.

| # | Module | Member owns | Main screen(s) | Database table |
|---|--------|-------------|----------------|----------------|
| 01 | **Core & Authentication** (app shell + shared core) | Member 01 | `LoginForm`, `MainDashboard`, `ChangePasswordForm` | `[User]` |
| 02 | **Worker Administration** | Member 02 | `WorkerForm` | `Worker` |
| 03 | **Attendance** | Member 03 | `AttendanceForm` | `Attendance` |
| 04 | **Estate Sections** | Member 04 | `SectionForm` | `EstateSection` |
| 05 | **Tea Yield** | Member 05 | `YieldForm` | `YieldRecord` |
| 06 | **Factory Processing** | Member 06 | `ProcessingForm` | `ProcessingRecord` |
| 07 | **Reports & AI Forecast** | Member 07 | `ReportsForm`, `ForecastForm` | (reads all tables) |
| 08 | **Payroll / Salary** | Member 08 | `PayrollForm` | `SalaryPayment` |

Every member also has a **detailed "How my code works" guide** inside their own folder
(`src/TeaEstateApp/0X_.../HOW_MY_CODE_WORKS.md`) explaining their part line by line.

---

## 6. How the app is built (architecture)

The whole app lives in **one namespace, `TeaEstate`**, and is organised into clean layers.
A user action flows **down** through the layers to the database and the results flow **back up**:

```
        ┌──────────────────────────────────────────────────────────┐
        │  FORMS  (the screens you see — WinForms, 1 per module)    │   UI layer
        │  LoginForm, WorkerForm, AttendanceForm, … PayrollForm     │
        └───────────────┬──────────────────────────────────────────┘
                        │ calls
        ┌───────────────▼──────────────────────────────────────────┐
        │  REPOSITORIES  (one per table, each : IDataManager)       │   Data-access layer
        │  WorkerRepository, AttendanceRepository, … SalaryRepo     │
        └───────────────┬──────────────────────────────────────────┘
                        │ uses
        ┌───────────────▼──────────────────────────────────────────┐
        │  DatabaseHelper  (the ONE place that opens SQL Server)    │   Shared core
        │  ExecuteQuery / ExecuteNonQuery / ExecuteScalar           │   (Member 01)
        └───────────────┬──────────────────────────────────────────┘
                        │ SqlParameter (safe from SQL injection)
        ┌───────────────▼──────────────────────────────────────────┐
        │  SQL Server LocalDB  —  database "TeaEstateDB"            │   Database
        └──────────────────────────────────────────────────────────┘

   MODELS (Person, Worker, Attendance, YieldRecord, SalaryPayment, …) are the plain
   data objects that travel up and down between these layers.
```

**Key design rules every member follows** (full list in `CONTRACTS.md`):
1. One namespace: `namespace TeaEstate` in every file.
2. **All** database access goes through `DatabaseHelper` — nobody writes their own connection string.
3. Every DB call is wrapped in `try/catch` showing `MessageBox.Show(ex.Message, "Error")`.
4. Inputs are validated before saving (`int.TryParse` / `decimal.TryParse`, no blank required fields).
5. Form class names are **fixed** (the dashboard opens forms by name) and each form has a public
   parameterless constructor.

---

## 7. Data model (database `TeaEstateDB`)

Seven tables, created automatically on first run by `DatabaseHelper.EnsureDatabase()`.
Arrows show foreign keys.

```
[User](UserID, Username, Password, Role)            ← login accounts

Worker(WorkerID, Name, Address, ContactNo, Position)
   ▲                ▲                 ▲
   │                │                 │
Attendance      YieldRecord       SalaryPayment
(WorkerID FK,   (WorkerID FK,     (WorkerID FK,
 Date, Status)   SectionID FK ──► EstateSection(SectionID, SectionName, Area)
                 Quantity, Date)   Month, DaysWorked, DailyRate,
                       ▲           YieldBonus, TotalAmount, PaidDate)
                       │
                 ProcessingRecord(ProcessID, YieldID FK, ProcessingDate, ProcessedQuantity)
```

> Note: `User` and `Date` are SQL reserved words, so in SQL they are always written `[User]` and `[Date]`.

---

## 8. Technology stack

| Area | Technology |
|------|-----------|
| Language / runtime | **C# / .NET 8** (`net8.0-windows`) |
| UI | **Windows Forms**, built with the **Visual Studio drag-and-drop Designer** (`*.Designer.cs` + `*.resx`) |
| Database | **Microsoft SQL Server LocalDB** (ships with Visual Studio) |
| Data access | `Microsoft.Data.SqlClient` with `SqlParameter`, all through `DatabaseHelper` |
| AI feature | Least-squares **linear regression** written by hand (no ML library) |
| Collaboration | **Git + GitHub**, branch-per-member, Pull Requests |
| IDE | Visual Studio 2022 |

---

## 9. OOP concepts demonstrated (CS107.3 requirement)

| Principle | Where it lives in our code |
|-----------|----------------------------|
| **Encapsulation** | Private fields + public properties in every model (e.g. `Person._name`, all of `SalaryPayment`) |
| **Abstraction** | `Person` is an `abstract` class with the abstract method `GetRoleDescription()` |
| **Inheritance** | `Worker : Person`, then `Supervisor : Worker` and `Manager : Worker` |
| **Polymorphism** | Each subclass `override`s `GetRoleDescription()` / `GetSummary()` |
| **Interfaces** | `IDataManager` (every repository) and `IReportGenerator` (the report service) |

---

## 10. How to run it

1. Open **`TeaEstateManagementSystem.sln`** in **Visual Studio 2022**.
2. Press **F5**.

That is all. On first launch, `DatabaseHelper.EnsureDatabase()` automatically creates the
`TeaEstateDB` database, all tables, and sample data in SQL Server LocalDB — there is **no
manual database setup**. Log in with `admin` / `admin123` to see every module.

---

## 11. How the team collaborates (GitHub)

- The code lives in a **private GitHub repository**.
- Each member works **only inside their own module folder**, on **their own branch**
  (e.g. `member-04-sections`).
- Daily routine: **pull** the latest → work in your folder → **commit** → **push** your branch
  → open a **Pull Request** → team lead **merges** to `main`.
- Because each member owns a separate folder, two people never edit the same file, so merge
  conflicts are extremely rare.

Full step-by-step: **`GITHUB_GUIDE.md`**. Who-builds-what: **`TEAM_TASKS.md`**.
Shared rules: **`CONTRACTS.md`**. Visual style: **`UI_GUIDE.md`**.

---

## 12. Document map (read these next)

| File | What it gives you |
|------|-------------------|
| `README.md` | Quick start + repo layout |
| `PROJECT_INTRODUCTION.md` | **This document** — the full project overview |
| `TEAM_TASKS.md` | The 8-member split: who builds what |
| `GITHUB_GUIDE.md` | Step-by-step GitHub workflow |
| `CONTRACTS.md` | The shared API + rules every module must follow |
| `UI_GUIDE.md` | The look-and-feel standard every screen follows |
| `src/TeaEstateApp/0X_.../HOW_MY_CODE_WORKS.md` | **Each member's own code walkthrough** |
