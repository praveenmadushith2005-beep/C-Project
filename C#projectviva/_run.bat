@echo off
REM ============================================================
REM  Double-click this file to build and run the
REM  Tea Estate Crop & Labour Management System.
REM  (Needs the .NET 8 SDK and SQL Server LocalDB - both ship
REM   with Visual Studio. The SQL Server LocalDB database
REM   "TeaEstateDB" is created automatically on first launch -
REM   no manual setup required.)
REM ============================================================
cd /d "%~dp0src\TeaEstateApp"
dotnet run
pause
