Imports DevExpress.XtraReports.UI

Public Class rptClientSMS_DevExpress
    Inherits XtraReport

    Private WithEvents Area3 As DetailBand
    Private WithEvents id1 As XRLabel
    Private WithEvents name1 As XRLabel
    Private WithEvents mobile1 As XRLabel
    Private WithEvents city1 As XRLabel
    Private WithEvents area6 As XRLabel
    Private WithEvents date1 As XRLabel
    Private WithEvents Line3 As XRLine
    Private WithEvents date21 As XRLabel
    Private WithEvents DataColumn11 As XRLabel
    Private WithEvents Area1 As ReportHeaderBand
    Private WithEvents Section1 As SubBand
    Private WithEvents Subreport1 As XRSubreport
    Private WithEvents ReportHeaderSection1 As SubBand
    Private WithEvents Text10 As XRLabel
    Private WithEvents from_date As XRLabel
    Private WithEvents to_date As XRLabel
    Private WithEvents Text13 As XRLabel
    Private WithEvents txtCust As XRLabel
    Private WithEvents Text9 As XRLabel
    Private WithEvents city As XRLabel
    Private WithEvents area As XRLabel
    Private WithEvents Text14 As XRLabel
    Private WithEvents Text11 As XRLabel
    Private WithEvents maint_from_date As XRLabel
    Private WithEvents maint_to_date As XRLabel
    Private WithEvents Text19 As XRLabel
    Private WithEvents Area2 As PageHeaderBand
    Private WithEvents Text1 As XRLabel
    Private WithEvents lblname As XRLabel
    Private WithEvents Text3 As XRLabel
    Private WithEvents Text4 As XRLabel
    Private WithEvents Text5 As XRLabel
    Private WithEvents Text17 As XRLabel
    Private WithEvents Text8 As XRLabel
    Private WithEvents Text12 As XRLabel
    Private WithEvents Area4 As ReportFooterBand
    Private WithEvents ReportFooterSection2 As SubBand
    Private WithEvents Section4 As SubBand
    Private WithEvents Area5 As PageFooterBand
    Private WithEvents txtAddress As XRLabel
    Private WithEvents Line30 As XRLine
    Private WithEvents Text27 As XRLabel
    Private WithEvents txtTel As XRLabel
    Private WithEvents Text29 As XRLabel
    Private WithEvents txtMobile As XRLabel
    Private WithEvents Text31 As XRLabel
    Private WithEvents txtFax As XRLabel
    Private WithEvents Line31 As XRLine
    Private WithEvents Line32 As XRLine
    Private WithEvents Line22 As XRLine
    Private WithEvents Line23 As XRLine
    Private WithEvents Line24 As XRLine
    Private WithEvents Line25 As XRLine
    Private WithEvents Line7 As XRCrossBandLine
    Private WithEvents Line13 As XRCrossBandLine
    Private WithEvents Line14 As XRCrossBandLine
    Private WithEvents Line15 As XRCrossBandLine
    Private WithEvents Line1 As XRCrossBandLine
    Private WithEvents Line2 As XRCrossBandLine
    Private WithEvents Box1 As XRCrossBandBox
    Private WithEvents Line4 As XRCrossBandLine
    Private WithEvents Box5 As XRCrossBandBox

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Area3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.Area1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.Area2 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Area4 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.Area5 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.id1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.name1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.mobile1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.city1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.area6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.date1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line3 = New DevExpress.XtraReports.UI.XRLine()
        Me.date21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DataColumn11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Section1 = New DevExpress.XtraReports.UI.SubBand()
        Me.ReportHeaderSection1 = New DevExpress.XtraReports.UI.SubBand()
        Me.Subreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.from_date = New DevExpress.XtraReports.UI.XRLabel()
        Me.to_date = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtCust = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.city = New DevExpress.XtraReports.UI.XRLabel()
        Me.area = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.maint_from_date = New DevExpress.XtraReports.UI.XRLabel()
        Me.maint_to_date = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblname = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooterSection2 = New DevExpress.XtraReports.UI.SubBand()
        Me.Section4 = New DevExpress.XtraReports.UI.SubBand()
        Me.txtAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line30 = New DevExpress.XtraReports.UI.XRLine()
        Me.Text27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTel = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtMobile = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtFax = New DevExpress.XtraReports.UI.XRLabel()
        Me.Line31 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line32 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line22 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line23 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line24 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line25 = New DevExpress.XtraReports.UI.XRLine()
        Me.Line7 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line13 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line14 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line15 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line1 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Line2 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Box1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        Me.Line4 = New DevExpress.XtraReports.UI.XRCrossBandLine()
        Me.Box5 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Area3
        '
        Me.Area3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.id1, Me.name1, Me.mobile1, Me.city1, Me.area6, Me.date1, Me.Line3, Me.date21, Me.DataColumn11})
        Me.Area3.HeightF = 24.0!
        Me.Area3.KeepTogether = True
        Me.Area3.Name = "Area3"
        Me.Area3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area1
        '
        Me.Area1.HeightF = 0!
        Me.Area1.Name = "Area1"
        Me.Area1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.Section1, Me.ReportHeaderSection1})
        Me.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area2
        '
        Me.Area2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1, Me.lblname, Me.Text3, Me.Text4, Me.Text5, Me.Text17, Me.Text8, Me.Text12})
        Me.Area2.HeightF = 67.0!
        Me.Area2.Name = "Area2"
        Me.Area2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area4
        '
        Me.Area4.HeightF = 0!
        Me.Area4.Name = "Area4"
        Me.Area4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area4.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.ReportFooterSection2, Me.Section4})
        Me.Area4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Area5
        '
        Me.Area5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtAddress, Me.Line30, Me.Text27, Me.txtTel, Me.Text29, Me.txtMobile, Me.Text31, Me.txtFax, Me.Line31, Me.Line32, Me.Line22, Me.Line23, Me.Line24, Me.Line25})
        Me.Area5.HeightF = 103.0!
        Me.Area5.Name = "Area5"
        Me.Area5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Area5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'id1
        '
        Me.id1.BackColor = System.Drawing.Color.Transparent
        Me.id1.BorderColor = System.Drawing.Color.Black
        Me.id1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.id1.BorderWidth = 1.0!
        Me.id1.CanGrow = False
        Me.id1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[id]")})
        Me.id1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.id1.ForeColor = System.Drawing.Color.Black
        Me.id1.LocationFloat = New DevExpress.Utils.PointFloat(708.3333!, 3.472222!)
        Me.id1.Name = "id1"
        Me.id1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.id1.SizeF = New System.Drawing.SizeF(55.20833!, 16.66667!)
        Me.id1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'name1
        '
        Me.name1.BackColor = System.Drawing.Color.Transparent
        Me.name1.BorderColor = System.Drawing.Color.Black
        Me.name1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.name1.BorderWidth = 1.0!
        Me.name1.CanGrow = False
        Me.name1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[name]")})
        Me.name1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.name1.ForeColor = System.Drawing.Color.Black
        Me.name1.LocationFloat = New DevExpress.Utils.PointFloat(541.6667!, 0!)
        Me.name1.Name = "name1"
        Me.name1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.name1.SizeF = New System.Drawing.SizeF(165.2778!, 16.66667!)
        Me.name1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'mobile1
        '
        Me.mobile1.BackColor = System.Drawing.Color.Transparent
        Me.mobile1.BorderColor = System.Drawing.Color.Black
        Me.mobile1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.mobile1.BorderWidth = 1.0!
        Me.mobile1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[mobile]")})
        Me.mobile1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.mobile1.ForeColor = System.Drawing.Color.Black
        Me.mobile1.LocationFloat = New DevExpress.Utils.PointFloat(441.6667!, 0!)
        Me.mobile1.Name = "mobile1"
        Me.mobile1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.mobile1.SizeF = New System.Drawing.SizeF(96.875!, 16.66667!)
        Me.mobile1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'city1
        '
        Me.city1.BackColor = System.Drawing.Color.Transparent
        Me.city1.BorderColor = System.Drawing.Color.Black
        Me.city1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.city1.BorderWidth = 1.0!
        Me.city1.CanGrow = False
        Me.city1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[city]")})
        Me.city1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.city1.ForeColor = System.Drawing.Color.Black
        Me.city1.LocationFloat = New DevExpress.Utils.PointFloat(366.6667!, 0!)
        Me.city1.Name = "city1"
        Me.city1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.city1.SizeF = New System.Drawing.SizeF(71.875!, 16.66667!)
        Me.city1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'area6
        '
        Me.area6.BackColor = System.Drawing.Color.Transparent
        Me.area6.BorderColor = System.Drawing.Color.Black
        Me.area6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.area6.BorderWidth = 1.0!
        Me.area6.CanGrow = False
        Me.area6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[area]")})
        Me.area6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.area6.ForeColor = System.Drawing.Color.Black
        Me.area6.LocationFloat = New DevExpress.Utils.PointFloat(266.6667!, 0!)
        Me.area6.Name = "area6"
        Me.area6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.area6.SizeF = New System.Drawing.SizeF(96.875!, 16.66667!)
        Me.area6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'date1
        '
        Me.date1.BackColor = System.Drawing.Color.Transparent
        Me.date1.BorderColor = System.Drawing.Color.Black
        Me.date1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.date1.BorderWidth = 1.0!
        Me.date1.CanGrow = False
        Me.date1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[date]")})
        Me.date1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.date1.ForeColor = System.Drawing.Color.Black
        Me.date1.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 0!)
        Me.date1.Name = "date1"
        Me.date1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.date1.SizeF = New System.Drawing.SizeF(88.54166!, 16.66667!)
        Me.date1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Transparent
        Me.Line3.BorderColor = System.Drawing.Color.Black
        Me.Line3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line3.BorderWidth = 1.0!
        Me.Line3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line3.ForeColor = System.Drawing.Color.Black
        Me.Line3.LineWidth = 2.0!
        Me.Line3.LocationFloat = New DevExpress.Utils.PointFloat(6.25!, 0!)
        Me.Line3.Name = "Line3"
        Me.Line3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line3.SizeF = New System.Drawing.SizeF(759.375!, 2.083333!)
        '
        'date21
        '
        Me.date21.BackColor = System.Drawing.Color.Transparent
        Me.date21.BorderColor = System.Drawing.Color.Black
        Me.date21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.date21.BorderWidth = 1.0!
        Me.date21.CanGrow = False
        Me.date21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[date2]")})
        Me.date21.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.date21.ForeColor = System.Drawing.Color.Black
        Me.date21.LocationFloat = New DevExpress.Utils.PointFloat(93.75!, 0!)
        Me.date21.Name = "date21"
        Me.date21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.date21.SizeF = New System.Drawing.SizeF(80.20834!, 16.66667!)
        Me.date21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DataColumn11
        '
        Me.DataColumn11.BackColor = System.Drawing.Color.Transparent
        Me.DataColumn11.BorderColor = System.Drawing.Color.Black
        Me.DataColumn11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataColumn11.BorderWidth = 1.0!
        Me.DataColumn11.CanGrow = False
        Me.DataColumn11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataColumn1]")})
        Me.DataColumn11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.DataColumn11.ForeColor = System.Drawing.Color.Black
        Me.DataColumn11.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 0!)
        Me.DataColumn11.Name = "DataColumn11"
        Me.DataColumn11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DataColumn11.SizeF = New System.Drawing.SizeF(82.29166!, 16.66667!)
        Me.DataColumn11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Section1
        '
        Me.Section1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Subreport1})
        Me.Section1.HeightF = 111.0!
        Me.Section1.KeepTogether = True
        Me.Section1.Name = "Section1"
        Me.Section1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Section1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text10, Me.from_date, Me.to_date, Me.Text13, Me.txtCust, Me.Text9, Me.city, Me.area, Me.Text14, Me.Text11, Me.maint_from_date, Me.maint_to_date, Me.Text19})
        Me.ReportHeaderSection1.HeightF = 166.0!
        Me.ReportHeaderSection1.KeepTogether = True
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeaderSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Subreport1
        '
        Me.Subreport1.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 8.333333!)
        Me.Subreport1.Name = "Subreport1"
        Me.Subreport1.ReportSource = New DevExpress.XtraReports.UI.XtraReport()
        Me.Subreport1.SizeF = New System.Drawing.SizeF(758.3333!, 100.0!)
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.Transparent
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text10.BorderWidth = 1.0!
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(641.6667!, 108.3333!)
        Me.Text10.Name = "Text10"
        Me.Text10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text10.SizeF = New System.Drawing.SizeF(121.4583!, 25.0!)
        Me.Text10.Text = "تاريخ الإشتراك     من"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'from_date
        '
        Me.from_date.BackColor = System.Drawing.Color.Transparent
        Me.from_date.BorderColor = System.Drawing.Color.Black
        Me.from_date.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.from_date.BorderWidth = 1.0!
        Me.from_date.CanGrow = False
        Me.from_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.from_date.ForeColor = System.Drawing.Color.Black
        Me.from_date.LocationFloat = New DevExpress.Utils.PointFloat(483.3333!, 108.3333!)
        Me.from_date.Name = "from_date"
        Me.from_date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.from_date.SizeF = New System.Drawing.SizeF(154.7917!, 25.0!)
        Me.from_date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'to_date
        '
        Me.to_date.BackColor = System.Drawing.Color.Transparent
        Me.to_date.BorderColor = System.Drawing.Color.Black
        Me.to_date.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.to_date.BorderWidth = 1.0!
        Me.to_date.CanGrow = False
        Me.to_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.to_date.ForeColor = System.Drawing.Color.Black
        Me.to_date.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 108.3333!)
        Me.to_date.Name = "to_date"
        Me.to_date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.to_date.SizeF = New System.Drawing.SizeF(158.3333!, 25.0!)
        Me.to_date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.Transparent
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text13.BorderWidth = 1.0!
        Me.Text13.CanGrow = False
        Me.Text13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(408.3333!, 108.3333!)
        Me.Text13.Name = "Text13"
        Me.Text13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text13.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Text13.Text = "إلى"
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtCust
        '
        Me.txtCust.BackColor = System.Drawing.Color.Transparent
        Me.txtCust.BorderColor = System.Drawing.Color.Black
        Me.txtCust.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtCust.BorderWidth = 1.0!
        Me.txtCust.CanGrow = False
        Me.txtCust.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtCust.ForeColor = System.Drawing.Color.Black
        Me.txtCust.LocationFloat = New DevExpress.Utils.PointFloat(308.3333!, 8.333333!)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtCust.SizeF = New System.Drawing.SizeF(213.125!, 25.0!)
        Me.txtCust.Text = "تقرير إرسال رسالة للعملاء"
        Me.txtCust.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text9
        '
        Me.Text9.BackColor = System.Drawing.Color.Transparent
        Me.Text9.BorderColor = System.Drawing.Color.Black
        Me.Text9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text9.BorderWidth = 1.0!
        Me.Text9.CanGrow = False
        Me.Text9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text9.ForeColor = System.Drawing.Color.Black
        Me.Text9.LocationFloat = New DevExpress.Utils.PointFloat(691.6667!, 66.66666!)
        Me.Text9.Name = "Text9"
        Me.Text9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text9.SizeF = New System.Drawing.SizeF(63.125!, 25.0!)
        Me.Text9.Text = "المدينة"
        Me.Text9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'city
        '
        Me.city.BackColor = System.Drawing.Color.Transparent
        Me.city.BorderColor = System.Drawing.Color.Black
        Me.city.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.city.BorderWidth = 1.0!
        Me.city.CanGrow = False
        Me.city.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.city.ForeColor = System.Drawing.Color.Black
        Me.city.LocationFloat = New DevExpress.Utils.PointFloat(575.0!, 66.66666!)
        Me.city.Name = "city"
        Me.city.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.city.SizeF = New System.Drawing.SizeF(113.125!, 25.0!)
        Me.city.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'area
        '
        Me.area.BackColor = System.Drawing.Color.Transparent
        Me.area.BorderColor = System.Drawing.Color.Black
        Me.area.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.area.BorderWidth = 1.0!
        Me.area.CanGrow = False
        Me.area.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.area.ForeColor = System.Drawing.Color.Black
        Me.area.LocationFloat = New DevExpress.Utils.PointFloat(391.6667!, 66.66666!)
        Me.area.Name = "area"
        Me.area.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.area.SizeF = New System.Drawing.SizeF(104.7917!, 25.0!)
        Me.area.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text14
        '
        Me.Text14.BackColor = System.Drawing.Color.Transparent
        Me.Text14.BorderColor = System.Drawing.Color.Black
        Me.Text14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text14.BorderWidth = 1.0!
        Me.Text14.CanGrow = False
        Me.Text14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text14.ForeColor = System.Drawing.Color.Black
        Me.Text14.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 66.66666!)
        Me.Text14.Name = "Text14"
        Me.Text14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text14.SizeF = New System.Drawing.SizeF(63.125!, 25.0!)
        Me.Text14.Text = "الحي"
        Me.Text14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.Transparent
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text11.BorderWidth = 1.0!
        Me.Text11.CanGrow = False
        Me.Text11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(641.6667!, 141.6667!)
        Me.Text11.Name = "Text11"
        Me.Text11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text11.SizeF = New System.Drawing.SizeF(121.4583!, 25.0!)
        Me.Text11.Text = "تاريخ آخر زيارة     من"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'maint_from_date
        '
        Me.maint_from_date.BackColor = System.Drawing.Color.Transparent
        Me.maint_from_date.BorderColor = System.Drawing.Color.Black
        Me.maint_from_date.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.maint_from_date.BorderWidth = 1.0!
        Me.maint_from_date.CanGrow = False
        Me.maint_from_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.maint_from_date.ForeColor = System.Drawing.Color.Black
        Me.maint_from_date.LocationFloat = New DevExpress.Utils.PointFloat(483.3333!, 141.6667!)
        Me.maint_from_date.Name = "maint_from_date"
        Me.maint_from_date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.maint_from_date.SizeF = New System.Drawing.SizeF(154.7917!, 25.0!)
        Me.maint_from_date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'maint_to_date
        '
        Me.maint_to_date.BackColor = System.Drawing.Color.Transparent
        Me.maint_to_date.BorderColor = System.Drawing.Color.Black
        Me.maint_to_date.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.maint_to_date.BorderWidth = 1.0!
        Me.maint_to_date.CanGrow = False
        Me.maint_to_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.maint_to_date.ForeColor = System.Drawing.Color.Black
        Me.maint_to_date.LocationFloat = New DevExpress.Utils.PointFloat(250.0!, 141.6667!)
        Me.maint_to_date.Name = "maint_to_date"
        Me.maint_to_date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.maint_to_date.SizeF = New System.Drawing.SizeF(158.3333!, 25.0!)
        Me.maint_to_date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text19
        '
        Me.Text19.BackColor = System.Drawing.Color.Transparent
        Me.Text19.BorderColor = System.Drawing.Color.Black
        Me.Text19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text19.BorderWidth = 1.0!
        Me.Text19.CanGrow = False
        Me.Text19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Text19.ForeColor = System.Drawing.Color.Black
        Me.Text19.LocationFloat = New DevExpress.Utils.PointFloat(408.3333!, 141.6667!)
        Me.Text19.Name = "Text19"
        Me.Text19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text19.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.Text19.Text = "إلى"
        Me.Text19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.Transparent
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text1.BorderWidth = 1.0!
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(708.3333!, 41.66667!)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text1.SizeF = New System.Drawing.SizeF(55.20833!, 25.0!)
        Me.Text1.Text = "رقم العميل"
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.BorderColor = System.Drawing.Color.Black
        Me.lblname.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblname.BorderWidth = 1.0!
        Me.lblname.CanGrow = False
        Me.lblname.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.LocationFloat = New DevExpress.Utils.PointFloat(541.6667!, 41.66667!)
        Me.lblname.Name = "lblname"
        Me.lblname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblname.SizeF = New System.Drawing.SizeF(163.5417!, 25.0!)
        Me.lblname.Text = "إسم العميل"
        Me.lblname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.Transparent
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text3.BorderWidth = 1.0!
        Me.Text3.CanGrow = False
        Me.Text3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(441.6667!, 41.66667!)
        Me.Text3.Name = "Text3"
        Me.Text3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text3.SizeF = New System.Drawing.SizeF(96.875!, 25.0!)
        Me.Text3.Text = "رقم الجوال"
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text4
        '
        Me.Text4.BackColor = System.Drawing.Color.Transparent
        Me.Text4.BorderColor = System.Drawing.Color.Black
        Me.Text4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text4.BorderWidth = 1.0!
        Me.Text4.CanGrow = False
        Me.Text4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text4.ForeColor = System.Drawing.Color.Black
        Me.Text4.LocationFloat = New DevExpress.Utils.PointFloat(366.6667!, 41.66667!)
        Me.Text4.Name = "Text4"
        Me.Text4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text4.SizeF = New System.Drawing.SizeF(71.875!, 25.0!)
        Me.Text4.Text = "المدينة"
        Me.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text5
        '
        Me.Text5.BackColor = System.Drawing.Color.Transparent
        Me.Text5.BorderColor = System.Drawing.Color.Black
        Me.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text5.BorderWidth = 1.0!
        Me.Text5.CanGrow = False
        Me.Text5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text5.ForeColor = System.Drawing.Color.Black
        Me.Text5.LocationFloat = New DevExpress.Utils.PointFloat(266.6667!, 41.66667!)
        Me.Text5.Name = "Text5"
        Me.Text5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text5.SizeF = New System.Drawing.SizeF(96.875!, 25.0!)
        Me.Text5.Text = "الحي"
        Me.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text17
        '
        Me.Text17.BackColor = System.Drawing.Color.Transparent
        Me.Text17.BorderColor = System.Drawing.Color.Black
        Me.Text17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text17.BorderWidth = 1.0!
        Me.Text17.CanGrow = False
        Me.Text17.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text17.ForeColor = System.Drawing.Color.Black
        Me.Text17.LocationFloat = New DevExpress.Utils.PointFloat(175.0!, 41.66667!)
        Me.Text17.Name = "Text17"
        Me.Text17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text17.SizeF = New System.Drawing.SizeF(88.54166!, 25.0!)
        Me.Text17.Text = "تاريخ الإشتراك"
        Me.Text17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text8
        '
        Me.Text8.BackColor = System.Drawing.Color.Transparent
        Me.Text8.BorderColor = System.Drawing.Color.Black
        Me.Text8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text8.BorderWidth = 1.0!
        Me.Text8.CanGrow = False
        Me.Text8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text8.ForeColor = System.Drawing.Color.Black
        Me.Text8.LocationFloat = New DevExpress.Utils.PointFloat(93.75!, 41.66667!)
        Me.Text8.Name = "Text8"
        Me.Text8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text8.SizeF = New System.Drawing.SizeF(80.20834!, 16.66667!)
        Me.Text8.Text = "تاريخ آخر زيارة"
        Me.Text8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text12
        '
        Me.Text12.BackColor = System.Drawing.Color.Transparent
        Me.Text12.BorderColor = System.Drawing.Color.Black
        Me.Text12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text12.BorderWidth = 1.0!
        Me.Text12.CanGrow = False
        Me.Text12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text12.ForeColor = System.Drawing.Color.Black
        Me.Text12.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 41.66667!)
        Me.Text12.Name = "Text12"
        Me.Text12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text12.SizeF = New System.Drawing.SizeF(80.20834!, 16.66667!)
        Me.Text12.Text = "آخر ارسال"
        Me.Text12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooterSection2
        '
        Me.ReportFooterSection2.HeightF = 1.0!
        Me.ReportFooterSection2.KeepTogether = True
        Me.ReportFooterSection2.Name = "ReportFooterSection2"
        Me.ReportFooterSection2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooterSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Section4
        '
        Me.Section4.HeightF = 0!
        Me.Section4.KeepTogether = True
        Me.Section4.Name = "Section4"
        Me.Section4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Section4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Section4.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Transparent
        Me.txtAddress.BorderColor = System.Drawing.Color.Black
        Me.txtAddress.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtAddress.BorderWidth = 1.0!
        Me.txtAddress.CanGrow = False
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 41.66667!)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtAddress.SizeF = New System.Drawing.SizeF(752.7083!, 25.0!)
        Me.txtAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line30
        '
        Me.Line30.BackColor = System.Drawing.Color.Transparent
        Me.Line30.BorderColor = System.Drawing.Color.Black
        Me.Line30.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line30.BorderWidth = 1.0!
        Me.Line30.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line30.ForeColor = System.Drawing.Color.Black
        Me.Line30.LineWidth = 2.0!
        Me.Line30.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 66.66666!)
        Me.Line30.Name = "Line30"
        Me.Line30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line30.SizeF = New System.Drawing.SizeF(757.2917!, 2.083333!)
        '
        'Text27
        '
        Me.Text27.BackColor = System.Drawing.Color.Transparent
        Me.Text27.BorderColor = System.Drawing.Color.Black
        Me.Text27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text27.BorderWidth = 1.0!
        Me.Text27.CanGrow = False
        Me.Text27.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text27.ForeColor = System.Drawing.Color.Black
        Me.Text27.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 66.66666!)
        Me.Text27.Name = "Text27"
        Me.Text27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text27.SizeF = New System.Drawing.SizeF(63.125!, 25.0!)
        Me.Text27.Text = "هاتف"
        Me.Text27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.Transparent
        Me.txtTel.BorderColor = System.Drawing.Color.Black
        Me.txtTel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtTel.BorderWidth = 1.0!
        Me.txtTel.CanGrow = False
        Me.txtTel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTel.ForeColor = System.Drawing.Color.Black
        Me.txtTel.LocationFloat = New DevExpress.Utils.PointFloat(508.3333!, 66.66666!)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTel.SizeF = New System.Drawing.SizeF(188.125!, 25.0!)
        Me.txtTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text29
        '
        Me.Text29.BackColor = System.Drawing.Color.Transparent
        Me.Text29.BorderColor = System.Drawing.Color.Black
        Me.Text29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text29.BorderWidth = 1.0!
        Me.Text29.CanGrow = False
        Me.Text29.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text29.ForeColor = System.Drawing.Color.Black
        Me.Text29.LocationFloat = New DevExpress.Utils.PointFloat(441.6667!, 66.66666!)
        Me.Text29.Name = "Text29"
        Me.Text29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text29.SizeF = New System.Drawing.SizeF(63.125!, 25.0!)
        Me.Text29.Text = "موبايل"
        Me.Text29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.Transparent
        Me.txtMobile.BorderColor = System.Drawing.Color.Black
        Me.txtMobile.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtMobile.BorderWidth = 1.0!
        Me.txtMobile.CanGrow = False
        Me.txtMobile.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.LocationFloat = New DevExpress.Utils.PointFloat(208.3333!, 66.66666!)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtMobile.SizeF = New System.Drawing.SizeF(229.7917!, 25.0!)
        Me.txtMobile.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text31
        '
        Me.Text31.BackColor = System.Drawing.Color.Transparent
        Me.Text31.BorderColor = System.Drawing.Color.Black
        Me.Text31.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Text31.BorderWidth = 1.0!
        Me.Text31.CanGrow = False
        Me.Text31.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Text31.ForeColor = System.Drawing.Color.Black
        Me.Text31.LocationFloat = New DevExpress.Utils.PointFloat(141.6667!, 66.66666!)
        Me.Text31.Name = "Text31"
        Me.Text31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Text31.SizeF = New System.Drawing.SizeF(63.125!, 25.0!)
        Me.Text31.Text = "فاكس"
        Me.Text31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.Transparent
        Me.txtFax.BorderColor = System.Drawing.Color.Black
        Me.txtFax.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.txtFax.BorderWidth = 1.0!
        Me.txtFax.CanGrow = False
        Me.txtFax.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtFax.ForeColor = System.Drawing.Color.Black
        Me.txtFax.LocationFloat = New DevExpress.Utils.PointFloat(8.333333!, 66.66666!)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtFax.SizeF = New System.Drawing.SizeF(129.7917!, 25.0!)
        Me.txtFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Line31
        '
        Me.Line31.BackColor = System.Drawing.Color.Transparent
        Me.Line31.BorderColor = System.Drawing.Color.Black
        Me.Line31.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Line31.BorderWidth = 1.0!
        Me.Line31.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line31.ForeColor = System.Drawing.Color.Black
        Me.Line31.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line31.LineWidth = 2.0!
        Me.Line31.LocationFloat = New DevExpress.Utils.PointFloat(698.9583!, 66.66666!)
        Me.Line31.Name = "Line31"
        Me.Line31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line31.SizeF = New System.Drawing.SizeF(2.083333!, 22.84722!)
        '
        'Line32
        '
        Me.Line32.BackColor = System.Drawing.Color.Transparent
        Me.Line32.BorderColor = System.Drawing.Color.Black
        Me.Line32.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Line32.BorderWidth = 1.0!
        Me.Line32.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line32.ForeColor = System.Drawing.Color.Black
        Me.Line32.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line32.LineWidth = 2.0!
        Me.Line32.LocationFloat = New DevExpress.Utils.PointFloat(441.6667!, 66.66666!)
        Me.Line32.Name = "Line32"
        Me.Line32.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line32.SizeF = New System.Drawing.SizeF(2.083333!, 23.88889!)
        '
        'Line22
        '
        Me.Line22.BackColor = System.Drawing.Color.Transparent
        Me.Line22.BorderColor = System.Drawing.Color.Black
        Me.Line22.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Line22.BorderWidth = 1.0!
        Me.Line22.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line22.ForeColor = System.Drawing.Color.Black
        Me.Line22.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line22.LineWidth = 2.0!
        Me.Line22.LocationFloat = New DevExpress.Utils.PointFloat(508.3333!, 66.66666!)
        Me.Line22.Name = "Line22"
        Me.Line22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line22.SizeF = New System.Drawing.SizeF(2.083333!, 23.88889!)
        '
        'Line23
        '
        Me.Line23.BackColor = System.Drawing.Color.Transparent
        Me.Line23.BorderColor = System.Drawing.Color.Black
        Me.Line23.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Line23.BorderWidth = 1.0!
        Me.Line23.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line23.ForeColor = System.Drawing.Color.Black
        Me.Line23.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line23.LineWidth = 2.0!
        Me.Line23.LocationFloat = New DevExpress.Utils.PointFloat(208.3333!, 66.66666!)
        Me.Line23.Name = "Line23"
        Me.Line23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line23.SizeF = New System.Drawing.SizeF(2.083333!, 23.88889!)
        '
        'Line24
        '
        Me.Line24.BackColor = System.Drawing.Color.Transparent
        Me.Line24.BorderColor = System.Drawing.Color.Black
        Me.Line24.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.Line24.BorderWidth = 1.0!
        Me.Line24.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line24.ForeColor = System.Drawing.Color.Black
        Me.Line24.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.Line24.LineWidth = 2.0!
        Me.Line24.LocationFloat = New DevExpress.Utils.PointFloat(141.6667!, 66.66666!)
        Me.Line24.Name = "Line24"
        Me.Line24.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line24.SizeF = New System.Drawing.SizeF(2.083333!, 23.88889!)
        '
        'Line25
        '
        Me.Line25.BackColor = System.Drawing.Color.Transparent
        Me.Line25.BorderColor = System.Drawing.Color.Black
        Me.Line25.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Line25.BorderWidth = 1.0!
        Me.Line25.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Line25.ForeColor = System.Drawing.Color.Black
        Me.Line25.LineWidth = 2.0!
        Me.Line25.LocationFloat = New DevExpress.Utils.PointFloat(5.555555!, 16.66667!)
        Me.Line25.Name = "Line25"
        Me.Line25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Line25.SizeF = New System.Drawing.SizeF(761.1111!, 2.083333!)
        '
        'Line7
        '
        Me.Line7.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line7.EndBand = Me.ReportFooterSection2
        Me.Line7.EndPointFloat = New DevExpress.Utils.PointFloat(708.3333!, 0.7638889!)
        Me.Line7.ForeColor = System.Drawing.Color.Black
        Me.Line7.Name = "Line7"
        Me.Line7.StartBand = Me.Area2
        Me.Line7.StartPointFloat = New DevExpress.Utils.PointFloat(708.3333!, 33.33333!)
        Me.Line7.WidthF = 1.388889!
        '
        'Line13
        '
        Me.Line13.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line13.EndBand = Me.ReportFooterSection2
        Me.Line13.EndPointFloat = New DevExpress.Utils.PointFloat(441.6667!, 0.7638889!)
        Me.Line13.ForeColor = System.Drawing.Color.Black
        Me.Line13.Name = "Line13"
        Me.Line13.StartBand = Me.Area2
        Me.Line13.StartPointFloat = New DevExpress.Utils.PointFloat(441.6667!, 33.33333!)
        Me.Line13.WidthF = 1.388889!
        '
        'Line14
        '
        Me.Line14.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line14.EndBand = Me.ReportFooterSection2
        Me.Line14.EndPointFloat = New DevExpress.Utils.PointFloat(366.6667!, 0.7638889!)
        Me.Line14.ForeColor = System.Drawing.Color.Black
        Me.Line14.Name = "Line14"
        Me.Line14.StartBand = Me.Area2
        Me.Line14.StartPointFloat = New DevExpress.Utils.PointFloat(366.6667!, 33.33333!)
        Me.Line14.WidthF = 1.388889!
        '
        'Line15
        '
        Me.Line15.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line15.EndBand = Me.ReportFooterSection2
        Me.Line15.EndPointFloat = New DevExpress.Utils.PointFloat(266.6667!, 0.7638889!)
        Me.Line15.ForeColor = System.Drawing.Color.Black
        Me.Line15.Name = "Line15"
        Me.Line15.StartBand = Me.Area2
        Me.Line15.StartPointFloat = New DevExpress.Utils.PointFloat(266.6667!, 33.33333!)
        Me.Line15.WidthF = 1.388889!
        '
        'Line1
        '
        Me.Line1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line1.EndBand = Me.ReportFooterSection2
        Me.Line1.EndPointFloat = New DevExpress.Utils.PointFloat(175.0!, 0.7638889!)
        Me.Line1.ForeColor = System.Drawing.Color.Black
        Me.Line1.Name = "Line1"
        Me.Line1.StartBand = Me.Area2
        Me.Line1.StartPointFloat = New DevExpress.Utils.PointFloat(175.0!, 33.33333!)
        Me.Line1.WidthF = 1.388889!
        '
        'Line2
        '
        Me.Line2.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line2.EndBand = Me.ReportFooterSection2
        Me.Line2.EndPointFloat = New DevExpress.Utils.PointFloat(541.6667!, 0.7638889!)
        Me.Line2.ForeColor = System.Drawing.Color.Black
        Me.Line2.Name = "Line2"
        Me.Line2.StartBand = Me.Area2
        Me.Line2.StartPointFloat = New DevExpress.Utils.PointFloat(541.6667!, 33.33333!)
        Me.Line2.WidthF = 1.388889!
        '
        'Box1
        '
        Me.Box1.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Box1.EndBand = Me.ReportFooterSection2
        Me.Box1.EndPointFloat = New DevExpress.Utils.PointFloat(5.555555!, 1.388889!)
        Me.Box1.Name = "Box1"
        Me.Box1.StartBand = Me.Area2
        Me.Box1.StartPointFloat = New DevExpress.Utils.PointFloat(5.555555!, 33.33333!)
        Me.Box1.WidthF = 762.1528!
        '
        'Line4
        '
        Me.Line4.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Line4.EndBand = Me.ReportFooterSection2
        Me.Line4.EndPointFloat = New DevExpress.Utils.PointFloat(91.66666!, 0.7638889!)
        Me.Line4.ForeColor = System.Drawing.Color.Black
        Me.Line4.Name = "Line4"
        Me.Line4.StartBand = Me.Area2
        Me.Line4.StartPointFloat = New DevExpress.Utils.PointFloat(91.66666!, 33.33333!)
        Me.Line4.WidthF = 1.388889!
        '
        'Box5
        '
        Me.Box5.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.Box5.EndBand = Me.Area5
        Me.Box5.EndPointFloat = New DevExpress.Utils.PointFloat(5.555555!, 91.66666!)
        Me.Box5.Name = "Box5"
        Me.Box5.StartBand = Me.Area5
        Me.Box5.StartPointFloat = New DevExpress.Utils.PointFloat(5.555555!, 33.33333!)
        Me.Box5.WidthF = 762.1528!
        '
        'rptClientSMS_DevExpress
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Area3, Me.Area1, Me.Area2, Me.Area4, Me.Area5})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.Line7, Me.Line13, Me.Line14, Me.Line15, Me.Line1, Me.Line2, Me.Box1, Me.Line4, Me.Box5})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class