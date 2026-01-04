using DevExpress.XtraReports.UI;

namespace AccountingApp.WPF
{
    public class ReportViewModel : ViewModelBase
    {
        private XtraReport _report;

        public XtraReport Report
        {
            get => _report;
            set
            {
                _report = value;
                OnPropertyChanged();
            }
        }
    }
}
