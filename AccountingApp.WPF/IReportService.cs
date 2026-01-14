using DevExpress.XtraReports.UI;

namespace AccountingApp.WPF
{
    public interface IReportService
    {
        XtraReport CreateUnitsReport();
    }
}
