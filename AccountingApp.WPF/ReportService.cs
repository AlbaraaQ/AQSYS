using AccountingApp.Core;
using DevExpress.XtraReports.UI;

namespace AccountingApp.WPF
{
    public class ReportService : IReportService
    {
        private readonly IUnitsRepository _unitsRepository;
        private readonly IFoundationRepository _foundationRepository;

        public ReportService(IUnitsRepository unitsRepository, IFoundationRepository foundationRepository)
        {
            _unitsRepository = unitsRepository;
            _foundationRepository = foundationRepository;
        }

        public XtraReport CreateUnitsReport()
        {
            var report = new XtraReport();

            // Create bands
            var detailBand = new DetailBand();
            var pageHeaderBand = new PageHeaderBand();
            var pageFooterBand = new PageFooterBand();
            report.Bands.AddRange(new Band[] { detailBand, pageHeaderBand, pageFooterBand });

            // Get data
            var units = _unitsRepository.GetAll();
            var foundation = _foundationRepository.Get();
            report.DataSource = units;

            // Page Header
            var headerLabel = new XRLabel
            {
                Text = "Units Report",
                Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter,
                WidthF = 650
            };
            pageHeaderBand.Controls.Add(headerLabel);

            // Company Header
            if (foundation != null)
            {
                var companyLabel = new XRLabel
                {
                    Text = foundation.NameA,
                    Font = new System.Drawing.Font("Arial", 16),
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter,
                    WidthF = 650,
                    LocationF = new System.Drawing.PointF(0, 50)
                };
                pageHeaderBand.Controls.Add(companyLabel);
            }


            // Detail Band
            var nameLabel = new XRLabel
            {
                ExpressionBindings = { new ExpressionBinding("BeforePrint", "Text", "[Name]") },
                Font = new System.Drawing.Font("Arial", 12),
                WidthF = 650
            };
            detailBand.Controls.Add(nameLabel);

            // Page Footer
            var pageInfo = new XRPageInfo
            {
                PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime,
                Format = "{0:yyyy-MM-dd hh:mm tt}",
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft,
                WidthF = 200
            };
            var pageNumber = new XRPageInfo
            {
                PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal,
                Format = "Page {0} of {1}",
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight,
                WidthF = 200,
                LocationF = new System.Drawing.PointF(450, 0)
            };
            pageFooterBand.Controls.AddRange(new XRControl[] { pageInfo, pageNumber });

            return report;
        }
    }
}
