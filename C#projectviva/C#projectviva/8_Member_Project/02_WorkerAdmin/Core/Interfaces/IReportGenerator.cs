using System.Data;

namespace TeaEstate
{
    // Member 01 — OOP: interface. Anything that produces a report implements this
    // (Member 05's ReportService). Lets the Reports screen treat all reports the same way.
    public interface IReportGenerator
    {
        string ReportTitle { get; }
        DataTable GenerateReport();
    }
}
