using System.Data;

namespace TeaEstate
{
    

    public interface IReportGenerator
    {
        string ReportTitle { get; }
        DataTable GenerateReport();
    }
}
