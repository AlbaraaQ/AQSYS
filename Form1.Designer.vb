Imports DevExpress.XtraBars.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm 'Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))

        ' DevExpress Skin and Style
        Dim skin As New DevExpress.Skins.SkinManager()

        ' Menu Items
        Me.btnSMSMsgs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClientsSendSMS = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClientsSMSAlarm = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuItem3 = New DevExpress.XtraBars.BarButtonItem()

        ' Ribbon Control
        Me.Ribbon1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.MainMenuItem1 = New DevExpress.XtraBars.BarButtonItem()

        ' Ribbon Pages (Tabs)
        Me.RibbonTab1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab8 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab10 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab11 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonTab12 = New DevExpress.XtraBars.Ribbon.RibbonPage()

        ' Ribbon Page Groups (Chunks)
        Me.RibbonChunk1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk18 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk19 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk20 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk22 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk23 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk24 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk25 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk26 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk27 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk28 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk29 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk30 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk31 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk32 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk33 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk34 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk35 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk36 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk37 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk38 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk39 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk40 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk41 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk42 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonChunk43 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gbCostCenter = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gpYearClose = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()

        ' Buttons
        Me.btnFoundation = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBranches = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSafes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCurrencies = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTreasuries = New DevExpress.XtraBars.BarButtonItem()
        Me.Button14 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnits = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCountries = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCities = New DevExpress.XtraBars.BarButtonItem()
        Me.btnArea = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBanks = New DevExpress.XtraBars.BarButtonItem()
        Me.btnActs = New DevExpress.XtraBars.BarButtonItem()
        Me.Button2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRest = New DevExpress.XtraBars.BarButtonItem()
        Me.Button5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptCustBalances = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptSuppBalances = New DevExpress.XtraBars.BarButtonItem()
        Me.Button47 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button45 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGifts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOffers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClientInvs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnErsaliaExpenses = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptErsalia = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOneClientMonitor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClientsMonitor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClientsSMS = New DevExpress.XtraBars.BarButtonItem()
        Me.Button6 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button7 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button8 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button9 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button10 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button60 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button15 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button61 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button19 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPriceShow = New DevExpress.XtraBars.BarButtonItem()
        Me.Button70 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTawlasManage = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManfc = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPurchOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.Button20 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRpt1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRpt2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRpt3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button43 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button48 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button16 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button17 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button39 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button40 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button25 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSansSD = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCostCenter = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptCostCenter = New DevExpress.XtraBars.BarButtonItem()
        Me.Button18 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDailyJournals = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenJournal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptAcc = New DevExpress.XtraBars.BarButtonItem()
        Me.Button28 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button29 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button30 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button31 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button32 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button33 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button34 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnM5znTsweya = New DevExpress.XtraBars.BarButtonItem()
        Me.Button35 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button36 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button38 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button37 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button23 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button46 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button49 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button50 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button4 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button41 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button42 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptSalesTax = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptPurchTax = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptTotal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptItemsDaily = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptZatca = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptMobApp = New DevExpress.XtraBars.BarButtonItem()
        Me.Button51 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUserPerm = New DevExpress.XtraBars.BarButtonItem()
        Me.Button58 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button22 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBkUp = New DevExpress.XtraBars.BarButtonItem()
        Me.Button59 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSMSSett = New DevExpress.XtraBars.BarButtonItem()
        Me.btnYearClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.Button12 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button13 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button69 = New DevExpress.XtraBars.BarButtonItem()
        Me.Button57 = New DevExpress.XtraBars.BarButtonItem()

        ' Popups and Menus
        Me.Popup1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.menu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnClientsSMS1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.menu = New DevExpress.XtraBars.PopupMenu(Me.components)

        ' Status Bar
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblTime = New DevExpress.XtraBars.BarStaticItem()
        Me.lblDash2 = New DevExpress.XtraBars.BarStaticItem()
        Me.txtLoggedUser = New DevExpress.XtraBars.BarStaticItem()
        Me.lblDash1 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblBranch = New DevExpress.XtraBars.BarStaticItem()
        Me.lblDash3 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblIsTrial = New DevExpress.XtraBars.BarStaticItem()
        Me.lblVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.lblExpireDiff = New DevExpress.XtraBars.BarStaticItem()

        ' Timers
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)

        ' Tile Control for Dashboard
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()

        ' Tile Items (replacing old buttons)
        Me.tileButton24 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton53 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton54 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton55 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton56 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton62 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton63 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton64 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton65 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton66 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton67 = New DevExpress.XtraEditors.TileItem()
        Me.tileButton68 = New DevExpress.XtraEditors.TileItem()

        ' Header Panel
        Me.pnlHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblHeader = New DevExpress.XtraEditors.LabelControl()

        ' Labels
        Me.Label50 = New DevExpress.XtraEditors.LabelControl()
        Me.lnkUpdate = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblMarketing = New DevExpress.XtraEditors.LabelControl()

        ' Picture Boxes
        Me.picStamp = New DevExpress.XtraEditors.PictureEdit()
        Me.PBCustAcc = New DevExpress.XtraEditors.PictureEdit()
        Me.PBRetSales = New DevExpress.XtraEditors.PictureEdit()
        Me.PBSuppAcc = New DevExpress.XtraEditors.PictureEdit()
        Me.PBSandSD = New DevExpress.XtraEditors.PictureEdit()
        Me.PBitems = New DevExpress.XtraEditors.PictureEdit()
        Me.PBPurch = New DevExpress.XtraEditors.PictureEdit()
        Me.PBSales = New DevExpress.XtraEditors.PictureEdit()
        Me.PBRest = New DevExpress.XtraEditors.PictureEdit()
        Me.PBbkup = New DevExpress.XtraEditors.PictureEdit()
        Me.picFatoora = New DevExpress.XtraEditors.PictureEdit()

        ' Begin Init
        CType(Me.Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Popup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClientsSMS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picStamp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCustAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBRetSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSuppAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSandSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBitems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPurch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBRest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBbkup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFatoora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ========================================
        ' RIBBON CONTROL CONFIGURATION
        ' ========================================

        Me.Ribbon1.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.Ribbon1.ExpandCollapseItem.Id = 0
        Me.Ribbon1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
        Me.Ribbon1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue
        Me.Ribbon1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True
        Me.Ribbon1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True
        Me.Ribbon1.ShowToolbarCustomizeItem = False
        Me.Ribbon1.RightToLeft = System.Windows.Forms.RightToLeft.Yes

        Me.Ribbon1.Items.AddRange(New DevExpress.XtraBars.BarItem() {
            Me.Ribbon1.ExpandCollapseItem,
            Me.btnFoundation, Me.btnBranches, Me.btnSafes, Me.btnCurrencies, Me.btnTreasuries,
            Me.Button14, Me.btnUnits, Me.btnCountries, Me.btnCities, Me.btnArea, Me.btnBanks,
            Me.btnActs, Me.Button2, Me.btnRest, Me.Button5, Me.btnRptCustBalances,
            Me.btnRptSuppBalances, Me.Button47, Me.Button45, Me.btnGifts, Me.btnOffers,
            Me.btnClientInvs, Me.btnErsaliaExpenses, Me.btnRptErsalia, Me.btnOneClientMonitor,
            Me.btnClientsMonitor, Me.btnClientsSMS, Me.Button6, Me.Button7, Me.Button8,
            Me.Button9, Me.Button10, Me.Button60, Me.Button15, Me.Button61, Me.Button19,
            Me.btnPriceShow, Me.Button70, Me.btnTawlasManage, Me.btnManfc, Me.btnPurchOrder,
            Me.Button20, Me.btnRpt1, Me.btnRpt2, Me.btnRpt3, Me.Button43, Me.Button48,
            Me.Button16, Me.Button17, Me.Button39, Me.Button40, Me.Button25, Me.btnSansSD,
            Me.btnCostCenter, Me.btnRptCostCenter, Me.Button18, Me.btnDailyJournals,
            Me.btnOpenJournal, Me.btnRptAcc, Me.Button28, Me.Button29, Me.Button30,
            Me.Button31, Me.Button32, Me.Button33, Me.Button34, Me.btnM5znTsweya,
            Me.Button35, Me.Button36, Me.Button38, Me.Button37, Me.Button23, Me.Button46,
            Me.Button49, Me.Button50, Me.Button4, Me.Button1, Me.Button41, Me.Button42,
            Me.btnRptSalesTax, Me.btnRptPurchTax, Me.btnRptTotal, Me.btnRptItemsDaily,
            Me.btnRptZatca, Me.btnRptMobApp, Me.Button51, Me.btnUserPerm, Me.Button58,
            Me.Button3, Me.Button22, Me.btnBkUp, Me.Button59, Me.btnSMSSett, Me.btnYearClose,
            Me.btnLogin, Me.Button12, Me.Button13, Me.Button69, Me.btnSMSMsgs,
            Me.btnClientsSendSMS, Me.btnClientsSMSAlarm, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3,
            Me.MainMenuItem1, Me.Button57, Me.lblTime, Me.txtLoggedUser, Me.lblBranch,
            Me.lblIsTrial, Me.lblVersion, Me.lblExpireDiff
        })

        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Margin = New System.Windows.Forms.Padding(4)
        Me.Ribbon1.Name = "Ribbon1"
        Me.Ribbon1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {
            Me.RibbonTab1, Me.RibbonTab2, Me.RibbonTab3, Me.RibbonTab4,
            Me.RibbonTab5, Me.RibbonTab6, Me.RibbonTab7, Me.RibbonTab8,
            Me.RibbonTab10, Me.RibbonTab11, Me.RibbonTab12
        })
        Me.Ribbon1.Size = New System.Drawing.Size(1590, 185)
        Me.Ribbon1.StatusBar = Me.RibbonStatusBar1

        ' ========================================
        ' APPLICATION MENU
        ' ========================================

        Me.ApplicationMenu1.ItemLinks.Add(Me.MainMenuItem1)
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.Ribbon1

        Me.MainMenuItem1.Caption = "MainMenuItem1"
        Me.MainMenuItem1.Id = 1
        Me.MainMenuItem1.Name = "MainMenuItem1"

        ' ========================================
        ' MENU ITEMS
        ' ========================================

        Me.btnSMSMsgs.Caption = "إعداد الرسائل"
        Me.btnSMSMsgs.Id = 100
        Me.btnSMSMsgs.Name = "btnSMSMsgs"

        Me.btnClientsSendSMS.Caption = "إرسال للعملاء"
        Me.btnClientsSendSMS.Id = 101
        Me.btnClientsSendSMS.Name = "btnClientsSendSMS"

        Me.btnClientsSMSAlarm.Caption = "تذكير العملاء"
        Me.btnClientsSMSAlarm.Id = 102
        Me.btnClientsSMSAlarm.Name = "btnClientsSMSAlarm"

        Me.MenuItem1.Caption = "مجموعات الطاولات"
        Me.MenuItem1.Id = 103
        Me.MenuItem1.Name = "MenuItem1"

        Me.MenuItem2.Caption = "الطاولات"
        Me.MenuItem2.Id = 104
        Me.MenuItem2.Name = "MenuItem2"

        Me.MenuItem3.Caption = ""
        Me.MenuItem3.Id = 105
        Me.MenuItem3.Name = "MenuItem3"

        ' ========================================
        ' RIBBON TAB 1 - البيانات الأساسية
        ' ========================================

        Me.RibbonTab1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk1, Me.RibbonChunk2, Me.RibbonChunk6,
            Me.RibbonChunk12, Me.RibbonChunk26, Me.RibbonChunk43
        })
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "البيانات الأساسية"

        ' RibbonChunk1
        Me.RibbonChunk1.ItemLinks.Add(Me.btnFoundation)
        Me.RibbonChunk1.ItemLinks.Add(Me.btnBranches)
        Me.RibbonChunk1.Name = "RibbonChunk1"
        Me.RibbonChunk1.Text = "المؤسسة"

        Me.btnFoundation.Caption = "بيانات المؤسســـة"
        Me.btnFoundation.Id = 2
        Me.btnFoundation.LargeGlyph = Global.AQSYS.My.Resources.Resources.office_building_icon
        Me.btnFoundation.Name = "btnFoundation"
        Me.btnFoundation.Tag = "btnFoundation"
        Me.btnFoundation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnBranches.Caption = "تعريف الفروع"
        Me.btnBranches.Id = 3
        Me.btnBranches.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347915742_agency1
        Me.btnBranches.Name = "btnBranches"
        Me.btnBranches.Tag = "btnBranches"
        Me.btnBranches.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk2
        Me.RibbonChunk2.ItemLinks.Add(Me.btnSafes)
        Me.RibbonChunk2.ItemLinks.Add(Me.btnCurrencies)
        Me.RibbonChunk2.ItemLinks.Add(Me.btnTreasuries)
        Me.RibbonChunk2.ItemLinks.Add(Me.Button14)
        Me.RibbonChunk2.ItemLinks.Add(Me.btnUnits)
        Me.RibbonChunk2.Name = "RibbonChunk2"
        Me.RibbonChunk2.Text = "التعريفات"

        Me.btnSafes.Caption = "تعريف المخازن"
        Me.btnSafes.Id = 4
        Me.btnSafes.LargeGlyph = Global.AQSYS.My.Resources.Resources.safe_icon
        Me.btnSafes.Name = "btnSafes"
        Me.btnSafes.Tag = "btnSafes"
        Me.btnSafes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnCurrencies.Caption = "تعريف الأصناف"
        Me.btnCurrencies.Id = 5
        Me.btnCurrencies.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347977291_application_vnd_ms_excel
        Me.btnCurrencies.Name = "btnCurrencies"
        Me.btnCurrencies.Tag = "btnCurrencies"
        Me.btnCurrencies.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnTreasuries.Caption = "تعريف الخزن"
        Me.btnTreasuries.Id = 6
        Me.btnTreasuries.LargeGlyph = Global.AQSYS.My.Resources.Resources.data_management_icon
        Me.btnTreasuries.Name = "btnTreasuries"
        Me.btnTreasuries.Tag = "btnTreasuries"
        Me.btnTreasuries.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button14.Caption = "مجموعات الأصناف"
        Me.Button14.Id = 7
        Me.Button14.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937740_view_tree
        Me.Button14.Name = "Button14"
        Me.Button14.Tag = "Button14"
        Me.Button14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnUnits.Caption = "الوحدات"
        Me.btnUnits.Id = 8
        Me.btnUnits.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnUnits.Name = "btnUnits"
        Me.btnUnits.Tag = "btnUnits"
        Me.btnUnits.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk6
        Me.RibbonChunk6.ItemLinks.Add(Me.btnCountries)
        Me.RibbonChunk6.ItemLinks.Add(Me.btnCities)
        Me.RibbonChunk6.ItemLinks.Add(Me.btnArea)
        Me.RibbonChunk6.ItemLinks.Add(Me.btnBanks)
        Me.RibbonChunk6.Name = "RibbonChunk6"
        Me.RibbonChunk6.Text = "البيانات الجغرافية"

        Me.btnCountries.Caption = "بيانات الدول"
        Me.btnCountries.Id = 9
        Me.btnCountries.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347916062_globe_red1
        Me.btnCountries.Name = "btnCountries"
        Me.btnCountries.Tag = "btnCountries"
        Me.btnCountries.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnCities.Caption = "بيانات المدن"
        Me.btnCities.Id = 10
        Me.btnCities.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347915944_globe_green1
        Me.btnCities.Name = "btnCities"
        Me.btnCities.Tag = "btnCities"
        Me.btnCities.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnArea.Caption = "بيانات المناطق"
        Me.btnArea.Id = 11
        Me.btnArea.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347916099_globe_yellow
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Tag = "btnArea"
        Me.btnArea.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnBanks.Caption = "تعريف البنوك"
        Me.btnBanks.Id = 12
        Me.btnBanks.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347916137_Bank
        Me.btnBanks.Name = "btnBanks"
        Me.btnBanks.Tag = "btnBanks"
        Me.btnBanks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk12
        Me.RibbonChunk12.ItemLinks.Add(Me.btnActs)
        Me.RibbonChunk12.Name = "RibbonChunk12"
        Me.RibbonChunk12.Text = "مجالات العمل"

        Me.btnActs.Caption = "تعريف مجالات العمل"
        Me.btnActs.Id = 13
        Me.btnActs.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347916289_contacts
        Me.btnActs.Name = "btnActs"
        Me.btnActs.Tag = "btnActs"
        Me.btnActs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk26
        Me.RibbonChunk26.ItemLinks.Add(Me.Button2)
        Me.RibbonChunk26.Name = "RibbonChunk26"
        Me.RibbonChunk26.Text = "الضرائب"

        Me.Button2.Caption = "المجموعات الضريبية"
        Me.Button2.Id = 14
        Me.Button2.LargeGlyph = Global.AQSYS.My.Resources.Resources.Stock_Folder_Blue_icon
        Me.Button2.Name = "Button2"
        Me.Button2.Tag = "Button2"
        Me.Button2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk43
        Me.RibbonChunk43.ItemLinks.Add(Me.btnRest)
        Me.RibbonChunk43.Name = "RibbonChunk43"
        Me.RibbonChunk43.Text = "المطاعم"

        Me.btnRest.Caption = "المطاعم"
        Me.btnRest.Id = 15
        Me.btnRest.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937102_edit_notes
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Tag = "btnActs"
        Me.btnRest.DropDownControl = Me.Popup1
        Me.btnRest.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btnRest.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' Popup1
        Me.Popup1.ItemLinks.Add(Me.MenuItem1)
        Me.Popup1.ItemLinks.Add(Me.MenuItem2)
        Me.Popup1.ItemLinks.Add(Me.MenuItem3)
        Me.Popup1.Name = "Popup1"
        Me.Popup1.Ribbon = Me.Ribbon1

        ' ========================================
        ' RIBBON TAB 2 - العملاء والموردين
        ' ========================================

        Me.RibbonTab2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk3, Me.RibbonChunk19, Me.RibbonChunk30, Me.RibbonChunk33,
            Me.RibbonChunk35, Me.RibbonChunk36, Me.RibbonChunk40, Me.RibbonChunk41
        })
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "العملاء والموردين"

        ' RibbonChunk3
        Me.RibbonChunk3.ItemLinks.Add(Me.Button5)
        Me.RibbonChunk3.Name = "RibbonChunk3"
        Me.RibbonChunk3.Text = "البيانات"

        Me.Button5.Caption = "بيانات العملاء / الموردين"
        Me.Button5.Id = 16
        Me.Button5.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347916607_testimonials
        Me.Button5.Name = "Button5"
        Me.Button5.Tag = "Button5"
        Me.Button5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk19
        Me.RibbonChunk19.ItemLinks.Add(Me.btnRptCustBalances)
        Me.RibbonChunk19.ItemLinks.Add(Me.btnRptSuppBalances)
        Me.RibbonChunk19.ItemLinks.Add(Me.Button47)
        Me.RibbonChunk19.ItemLinks.Add(Me.Button45)
        Me.RibbonChunk19.Name = "RibbonChunk19"
        Me.RibbonChunk19.Text = "التقارير"

        Me.btnRptCustBalances.Caption = "ارصدة حسابات العملاء"
        Me.btnRptCustBalances.Id = 17
        Me.btnRptCustBalances.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936478_ordering
        Me.btnRptCustBalances.Name = "btnRptCustBalances"
        Me.btnRptCustBalances.Tag = "Button44"
        Me.btnRptCustBalances.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptSuppBalances.Caption = "ارصدة حسابات الموردين"
        Me.btnRptSuppBalances.Id = 18
        Me.btnRptSuppBalances.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936478_ordering
        Me.btnRptSuppBalances.Name = "btnRptSuppBalances"
        Me.btnRptSuppBalances.Tag = "Button44"
        Me.btnRptSuppBalances.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button47.Caption = "كشف حســـــاب  عميل"
        Me.Button47.Id = 19
        Me.Button47.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936351_sign_up
        Me.Button47.Name = "Button47"
        Me.Button47.Tag = "Button47"
        Me.Button47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button45.Caption = "حركة اخر سداد للعملاء"
        Me.Button45.Id = 20
        Me.Button45.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936533_Sales_by_Payment_Method_rep
        Me.Button45.Name = "Button45"
        Me.Button45.Tag = "Button45"
        Me.Button45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk30
        Me.RibbonChunk30.ItemLinks.Add(Me.btnGifts)
        Me.RibbonChunk30.Name = "RibbonChunk30"
        Me.RibbonChunk30.Text = "الهدايا"

        Me.btnGifts.Caption = "منح هدايا لعميل"
        Me.btnGifts.Id = 21
        Me.btnGifts.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnGifts.Name = "btnGifts"
        Me.btnGifts.Tag = "frmGifts"
        Me.btnGifts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk33
        Me.RibbonChunk33.ItemLinks.Add(Me.btnOffers)
        Me.RibbonChunk33.Name = "RibbonChunk33"
        Me.RibbonChunk33.Text = "العروض"

        Me.btnOffers.Caption = "إنشاء العروض"
        Me.btnOffers.Id = 22
        Me.btnOffers.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnOffers.Name = "btnOffers"
        Me.btnOffers.Tag = "frmOffers2"
        Me.btnOffers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk35
        Me.RibbonChunk35.ItemLinks.Add(Me.btnClientInvs)
        Me.RibbonChunk35.Name = "RibbonChunk35"
        Me.RibbonChunk35.Text = "المشتريات"

        Me.btnClientInvs.Caption = "تقرير مشتريات عميل"
        Me.btnClientInvs.Id = 23
        Me.btnClientInvs.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnClientInvs.Name = "btnClientInvs"
        Me.btnClientInvs.Tag = ""
        Me.btnClientInvs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk36
        Me.RibbonChunk36.ItemLinks.Add(Me.btnErsaliaExpenses)
        Me.RibbonChunk36.ItemLinks.Add(Me.btnRptErsalia)
        Me.RibbonChunk36.Name = "RibbonChunk36"
        Me.RibbonChunk36.Text = "الإرسالية"

        Me.btnErsaliaExpenses.Caption = "مصاريف إرسالية"
        Me.btnErsaliaExpenses.Id = 24
        Me.btnErsaliaExpenses.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnErsaliaExpenses.Name = "btnErsaliaExpenses"
        Me.btnErsaliaExpenses.Tag = ""
        Me.btnErsaliaExpenses.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptErsalia.Caption = "تقرير الإرسالية"
        Me.btnRptErsalia.Id = 25
        Me.btnRptErsalia.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnRptErsalia.Name = "btnRptErsalia"
        Me.btnRptErsalia.Tag = ""
        Me.btnRptErsalia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk40
        Me.RibbonChunk40.ItemLinks.Add(Me.btnOneClientMonitor)
        Me.RibbonChunk40.ItemLinks.Add(Me.btnClientsMonitor)
        Me.RibbonChunk40.Name = "RibbonChunk40"
        Me.RibbonChunk40.Text = "المتابعة"

        Me.btnOneClientMonitor.Caption = "تقرير متابعة عميل"
        Me.btnOneClientMonitor.Id = 26
        Me.btnOneClientMonitor.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnOneClientMonitor.Name = "btnOneClientMonitor"
        Me.btnOneClientMonitor.Tag = ""
        Me.btnOneClientMonitor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnClientsMonitor.Caption = "تقرير متابعة العملاء"
        Me.btnClientsMonitor.Id = 27
        Me.btnClientsMonitor.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnClientsMonitor.Name = "btnClientsMonitor"
        Me.btnClientsMonitor.Tag = ""
        Me.btnClientsMonitor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk41
        Me.RibbonChunk41.ItemLinks.Add(Me.btnClientsSMS)
        Me.RibbonChunk41.Name = "RibbonChunk41"
        Me.RibbonChunk41.Text = "الرسائل"

        Me.btnClientsSMS.Caption = "الرسائل"
        Me.btnClientsSMS.Id = 28
        Me.btnClientsSMS.LargeGlyph = CType(resources.GetObject("btnClientsSMS.Image"), System.Drawing.Image)
        Me.btnClientsSMS.Name = "btnClientsSMS"
        Me.btnClientsSMS.Tag = ""
        Me.btnClientsSMS.DropDownControl = Me.btnClientsSMS1
        Me.btnClientsSMS.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btnClientsSMS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' btnClientsSMS1 Popup Menu
        Me.btnClientsSMS1.ItemLinks.Add(Me.btnSMSMsgs)
        Me.btnClientsSMS1.ItemLinks.Add(Me.btnClientsSendSMS)
        Me.btnClientsSMS1.ItemLinks.Add(Me.btnClientsSMSAlarm)
        Me.btnClientsSMS1.Name = "btnClientsSMS1"
        Me.btnClientsSMS1.Ribbon = Me.Ribbon1

        ' ========================================
        ' RIBBON TAB 3 - شئون الموظفين
        ' ========================================

        Me.RibbonTab3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk4, Me.RibbonChunk5
        })
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Text = "شئون الموظفين"

        ' RibbonChunk4
        Me.RibbonChunk4.ItemLinks.Add(Me.Button6)
        Me.RibbonChunk4.ItemLinks.Add(Me.Button7)
        Me.RibbonChunk4.ItemLinks.Add(Me.Button8)
        Me.RibbonChunk4.Name = "RibbonChunk4"
        Me.RibbonChunk4.Text = "الهيكل التنظيمي"

        Me.Button6.Caption = "تعريف الادارات"
        Me.Button6.Id = 29
        Me.Button6.LargeGlyph = Global.AQSYS.My.Resources.Resources.data_management_icon
        Me.Button6.Name = "Button6"
        Me.Button6.Tag = "Button6"
        Me.Button6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button7.Caption = "تعريف الأقسام"
        Me.Button7.Id = 30
        Me.Button7.LargeGlyph = Global.AQSYS.My.Resources.Resources.content_tree_icon
        Me.Button7.Name = "Button7"
        Me.Button7.Tag = "Button7"
        Me.Button7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button8.Caption = "تعريف الموظف"
        Me.Button8.Id = 31
        Me.Button8.LargeGlyph = Global.AQSYS.My.Resources.Resources.Office_Client_Male_Light_icon
        Me.Button8.Name = "Button8"
        Me.Button8.Tag = "Button8"
        Me.Button8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk5
        Me.RibbonChunk5.ItemLinks.Add(Me.Button9)
        Me.RibbonChunk5.ItemLinks.Add(Me.Button10)
        Me.RibbonChunk5.Name = "RibbonChunk5"
        Me.RibbonChunk5.Text = "الرواتب"

        Me.Button9.Caption = "دفع الرواتب"
        Me.Button9.Id = 32
        Me.Button9.LargeGlyph = Global.AQSYS.My.Resources.Resources.money_icon1
        Me.Button9.Name = "Button9"
        Me.Button9.Tag = "Button9"
        Me.Button9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button10.Caption = "الحوافز والجزاءات"
        Me.Button10.Id = 33
        Me.Button10.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890646_Money
        Me.Button10.Name = "Button10"
        Me.Button10.Tag = "Button10"
        Me.Button10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 4 - مبيعات ومشتريات
        ' ========================================

        Me.RibbonTab4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk7, Me.RibbonChunk10, Me.RibbonChunk18, Me.RibbonChunk25
        })
        Me.RibbonTab4.Name = "RibbonTab4"
        Me.RibbonTab4.Text = "مبيعات ومشتريات"

        ' RibbonChunk7
        Me.RibbonChunk7.ItemLinks.Add(Me.Button60)
        Me.RibbonChunk7.ItemLinks.Add(Me.Button15)
        Me.RibbonChunk7.ItemLinks.Add(Me.Button61)
        Me.RibbonChunk7.ItemLinks.Add(Me.Button19)
        Me.RibbonChunk7.ItemLinks.Add(Me.btnPriceShow)
        Me.RibbonChunk7.ItemLinks.Add(Me.Button70)
        Me.RibbonChunk7.ItemLinks.Add(Me.btnTawlasManage)
        Me.RibbonChunk7.ItemLinks.Add(Me.btnManfc)
        Me.RibbonChunk7.ItemLinks.Add(Me.btnPurchOrder)
        Me.RibbonChunk7.Name = "RibbonChunk7"
        Me.RibbonChunk7.Text = "الفواتير"

        Me.Button60.Caption = "فاتورة المشتريات"
        Me.Button60.Id = 34
        Me.Button60.LargeGlyph = Global.AQSYS.My.Resources.Resources.sales_report_icon
        Me.Button60.Name = "Button60"
        Me.Button60.Tag = "Button60"
        Me.Button60.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.Button60.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button15.Caption = "فاتورة المبيعات"
        Me.Button15.Id = 35
        Me.Button15.LargeGlyph = Global.AQSYS.My.Resources.Resources.sales_report_icon
        Me.Button15.Name = "Button15"
        Me.Button15.Tag = "Button15"
        Me.Button15.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.Button15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button61.Caption = "مردود المشتريات"
        Me.Button61.Id = 36
        Me.Button61.LargeGlyph = Global.AQSYS.My.Resources.Resources.Back_icon
        Me.Button61.Name = "Button61"
        Me.Button61.Tag = "Button61"
        Me.Button61.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button19.Caption = "مردود المبيعات"
        Me.Button19.Id = 37
        Me.Button19.LargeGlyph = Global.AQSYS.My.Resources.Resources.Back_icon
        Me.Button19.Name = "Button19"
        Me.Button19.Tag = "Button19"
        Me.Button19.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnPriceShow.Caption = "عرض سعر"
        Me.btnPriceShow.Id = 38
        Me.btnPriceShow.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937102_edit_notes
        Me.btnPriceShow.Name = "btnPriceShow"
        Me.btnPriceShow.Tag = "btnPriceShow"
        Me.btnPriceShow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button70.Caption = "كاشير"
        Me.Button70.Id = 39
        Me.Button70.LargeGlyph = Global.AQSYS.My.Resources.Resources.sales_report_icon
        Me.Button70.Name = "Button70"
        Me.Button70.Tag = "Button15"
        Me.Button70.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.Button70.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnTawlasManage.Caption = "الطاولات"
        Me.btnTawlasManage.Id = 40
        Me.btnTawlasManage.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347977291_application_vnd_ms_excel
        Me.btnTawlasManage.Name = "btnTawlasManage"
        Me.btnTawlasManage.Tag = ""
        Me.btnTawlasManage.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.btnTawlasManage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnManfc.Caption = "إنتاج"
        Me.btnManfc.Id = 41
        Me.btnManfc.LargeGlyph = Global.AQSYS.My.Resources.Resources.sales_report_icon
        Me.btnManfc.Name = "btnManfc"
        Me.btnManfc.Tag = "Button15"
        Me.btnManfc.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.btnManfc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnPurchOrder.Caption = ""
        Me.btnPurchOrder.Id = 42
        Me.btnPurchOrder.LargeGlyph = Global.AQSYS.My.Resources.Resources.sales_report_icon
        Me.btnPurchOrder.Name = "btnPurchOrder"
        Me.btnPurchOrder.Tag = "Button15"
        Me.btnPurchOrder.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.btnPurchOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk10
        Me.RibbonChunk10.ItemLinks.Add(Me.Button20)
        Me.RibbonChunk10.Name = "RibbonChunk10"
        Me.RibbonChunk10.Text = "المخزون"

        Me.Button20.Caption = "مخزون أول المــــدة"
        Me.Button20.Id = 43
        Me.Button20.LargeGlyph = Global.AQSYS.My.Resources.Resources.Stock_Folder_Blue_icon
        Me.Button20.Name = "Button20"
        Me.Button20.Tag = "Button20"
        Me.Button20.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk18
        Me.RibbonChunk18.ItemLinks.Add(Me.btnRpt1)
        Me.RibbonChunk18.ItemLinks.Add(Me.btnRpt2)
        Me.RibbonChunk18.ItemLinks.Add(Me.btnRpt3)
        Me.RibbonChunk18.ItemLinks.Add(Me.Button43)
        Me.RibbonChunk18.Name = "RibbonChunk18"
        Me.RibbonChunk18.Text = "التقارير"

        Me.btnRpt1.Caption = "فواتير حسب نوع الفاتورة"
        Me.btnRpt1.Id = 44
        Me.btnRpt1.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890998_reports
        Me.btnRpt1.Name = "btnRpt1"
        Me.btnRpt1.Tag = "btnRpt1"
        Me.btnRpt1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRpt2.Caption = "فواتير حسب العملاء"
        Me.btnRpt2.Id = 45
        Me.btnRpt2.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937102_edit_notes
        Me.btnRpt2.Name = "btnRpt2"
        Me.btnRpt2.Tag = "btnRpt2"
        Me.btnRpt2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRpt3.Caption = "مبيعات ومشتريات تفصيلية"
        Me.btnRpt3.Id = 46
        Me.btnRpt3.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936533_Sales_by_Payment_Method_rep
        Me.btnRpt3.Name = "btnRpt3"
        Me.btnRpt3.Tag = "btnRpt3"
        Me.btnRpt3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button43.Caption = "صافي مبيعات وارباح"
        Me.Button43.Id = 47
        Me.Button43.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937248_credit_cards
        Me.Button43.Name = "Button43"
        Me.Button43.Tag = "Button43"
        Me.Button43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk25
        Me.RibbonChunk25.ItemLinks.Add(Me.Button48)
        Me.RibbonChunk25.Name = "RibbonChunk25"
        Me.RibbonChunk25.Text = "الموظفين"

        Me.Button48.Caption = "مبيعات ومشتريات موظف"
        Me.Button48.Id = 48
        Me.Button48.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937336_preferences_contact_list
        Me.Button48.Name = "Button48"
        Me.Button48.Tag = "Button48"
        Me.Button48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 5 - سندات
        ' ========================================

        Me.RibbonTab5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk8, Me.RibbonChunk17, Me.RibbonChunk21, Me.gbCostCenter
        })
        Me.RibbonTab5.Name = "RibbonTab5"
        Me.RibbonTab5.Text = "سندات"

        ' RibbonChunk8
        Me.RibbonChunk8.ItemLinks.Add(Me.Button16)
        Me.RibbonChunk8.ItemLinks.Add(Me.Button17)
        Me.RibbonChunk8.Name = "RibbonChunk8"
        Me.RibbonChunk8.Text = "السندات الخارجية"

        Me.Button16.Caption = "سندات قبض خارجية"
        Me.Button16.Id = 49
        Me.Button16.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937517_money_bag
        Me.Button16.Name = "Button16"
        Me.Button16.Tag = "Button16"
        Me.Button16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button17.Caption = "سندات صرف خارجية"
        Me.Button17.Id = 50
        Me.Button17.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937517_money_bag
        Me.Button17.Name = "Button17"
        Me.Button17.Tag = "Button17"
        Me.Button17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk17
        Me.RibbonChunk17.ItemLinks.Add(Me.Button39)
        Me.RibbonChunk17.ItemLinks.Add(Me.Button40)
        Me.RibbonChunk17.Name = "RibbonChunk17"
        Me.RibbonChunk17.Text = "عرض السندات"

        Me.Button39.Caption = "عرض سندات القبض والصرف خارجية"
        Me.Button39.Id = 51
        Me.Button39.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936533_Sales_by_Payment_Method_rep
        Me.Button39.Name = "Button39"
        Me.Button39.Tag = "Button39"
        Me.Button39.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button40.Caption = "عرض سندات القبض والصرف داخلية"
        Me.Button40.Id = 52
        Me.Button40.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348936533_Sales_by_Payment_Method_rep
        Me.Button40.Name = "Button40"
        Me.Button40.Tag = "Button40"
        Me.Button40.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk21
        Me.RibbonChunk21.ItemLinks.Add(Me.Button25)
        Me.RibbonChunk21.ItemLinks.Add(Me.btnSansSD)
        Me.RibbonChunk21.Name = "RibbonChunk21"
        Me.RibbonChunk21.Text = "السندات الداخلية"

        Me.Button25.Caption = "سندات قبض داخلية"
        Me.Button25.Id = 53
        Me.Button25.LargeGlyph = CType(resources.GetObject("Button25.Image"), System.Drawing.Image)
        Me.Button25.Name = "Button25"
        Me.Button25.Tag = "Button25"
        Me.Button25.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnSansSD.Caption = ""
        Me.btnSansSD.Id = 54
        Me.btnSansSD.LargeGlyph = CType(resources.GetObject("btnSansSD.Image"), System.Drawing.Image)
        Me.btnSansSD.Name = "btnSansSD"
        Me.btnSansSD.Tag = "Button26"
        Me.btnSansSD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' gbCostCenter
        Me.gbCostCenter.ItemLinks.Add(Me.btnCostCenter)
        Me.gbCostCenter.ItemLinks.Add(Me.btnRptCostCenter)
        Me.gbCostCenter.Name = "gbCostCenter"
        Me.gbCostCenter.Text = "مراكز التكلفة"

        Me.btnCostCenter.Caption = "مراكز التكلفة"
        Me.btnCostCenter.Id = 55
        Me.btnCostCenter.LargeGlyph = CType(resources.GetObject("btnCostCenter.Image"), System.Drawing.Image)
        Me.btnCostCenter.Name = "btnCostCenter"
        Me.btnCostCenter.Tag = "Button25"
        Me.btnCostCenter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptCostCenter.Caption = "تقرير مراكز التكلفة"
        Me.btnRptCostCenter.Id = 56
        Me.btnRptCostCenter.LargeGlyph = CType(resources.GetObject("btnRptCostCenter.Image"), System.Drawing.Image)
        Me.btnRptCostCenter.Name = "btnRptCostCenter"
        Me.btnRptCostCenter.Tag = "Button25"
        Me.btnRptCostCenter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 6 - الحسابات
        ' ========================================

        Me.RibbonTab6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk9, Me.RibbonChunk11, Me.RibbonChunk14
        })
        Me.RibbonTab6.Name = "RibbonTab6"
        Me.RibbonTab6.Text = "الحسابات"

        ' RibbonChunk9
        Me.RibbonChunk9.ItemLinks.Add(Me.Button18)
        Me.RibbonChunk9.Name = "RibbonChunk9"
        Me.RibbonChunk9.Text = "شجرة الحسابات"

        Me.Button18.Caption = "شجرة الحسابات"
        Me.Button18.Id = 57
        Me.Button18.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937740_view_tree
        Me.Button18.Name = "Button18"
        Me.Button18.Tag = "Button18"
        Me.Button18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk11
        Me.RibbonChunk11.ItemLinks.Add(Me.btnDailyJournals)
        Me.RibbonChunk11.ItemLinks.Add(Me.btnOpenJournal)
        Me.RibbonChunk11.Name = "RibbonChunk11"
        Me.RibbonChunk11.Text = "اليوميات"

        Me.btnDailyJournals.Caption = ""
        Me.btnDailyJournals.Id = 58
        Me.btnDailyJournals.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937809_todo_list_add
        Me.btnDailyJournals.Name = "btnDailyJournals"
        Me.btnDailyJournals.Tag = "Button21"
        Me.btnDailyJournals.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnOpenJournal.Caption = ""
        Me.btnOpenJournal.Id = 59
        Me.btnOpenJournal.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937809_todo_list_add
        Me.btnOpenJournal.Name = "btnOpenJournal"
        Me.btnOpenJournal.Tag = "Button21"
        Me.btnOpenJournal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk14
        Me.RibbonChunk14.ItemLinks.Add(Me.btnRptAcc)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button28)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button29)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button30)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button31)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button32)
        Me.RibbonChunk14.ItemLinks.Add(Me.Button33)
        Me.RibbonChunk14.Name = "RibbonChunk14"
        Me.RibbonChunk14.Text = "التقارير المحاسبية"

        Me.btnRptAcc.Caption = "كشف حساب"
        Me.btnRptAcc.Id = 60
        Me.btnRptAcc.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233068_bar_chart
        Me.btnRptAcc.Name = "btnRptAcc"
        Me.btnRptAcc.Tag = "Button27"
        Me.btnRptAcc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button28.Caption = "ميزان المراجعة رئيسي"
        Me.Button28.Id = 61
        Me.Button28.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233174_14
        Me.Button28.Name = "Button28"
        Me.Button28.Tag = "Button28"
        Me.Button28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button29.Caption = "ميزان المراجعة تحليلي"
        Me.Button29.Id = 62
        Me.Button29.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233205_balance
        Me.Button29.Name = "Button29"
        Me.Button29.Tag = "Button29"
        Me.Button29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button30.Caption = "أرباح وخسائر حسابات رئيسية"
        Me.Button30.Id = 63
        Me.Button30.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347891735_20
        Me.Button30.Name = "Button30"
        Me.Button30.Tag = "Button30"
        Me.Button30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button31.Caption = "أرباح وخسائر حسابات تحليلية"
        Me.Button31.Id = 64
        Me.Button31.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233408_shine_14
        Me.Button31.Name = "Button31"
        Me.Button31.Tag = "Button31"
        Me.Button31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button32.Caption = "ميزانية عمومية حسابات رئيسية"
        Me.Button32.Id = 65
        Me.Button32.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347977291_application_vnd_ms_excel
        Me.Button32.Name = "Button32"
        Me.Button32.Tag = "Button32"
        Me.Button32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button33.Caption = "ميزانية عمومية حسابات تحليلية"
        Me.Button33.Id = 66
        Me.Button33.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233626_schedule
        Me.Button33.Name = "Button33"
        Me.Button33.Tag = "Button33"
        Me.Button33.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 7 - المخازن
        ' ========================================

        Me.RibbonTab7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk15, Me.RibbonChunk16
        })
        Me.RibbonTab7.Name = "RibbonTab7"
        Me.RibbonTab7.Text = "المخازن"

        ' RibbonChunk15
        Me.RibbonChunk15.ItemLinks.Add(Me.Button34)
        Me.RibbonChunk15.ItemLinks.Add(Me.btnM5znTsweya)
        Me.RibbonChunk15.Name = "RibbonChunk15"
        Me.RibbonChunk15.Text = "عمليات المخازن"

        Me.Button34.Caption = "النقل من مخزن الى آخر"
        Me.Button34.Id = 67
        Me.Button34.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349232961_rafraichir_bleu
        Me.Button34.Name = "Button34"
        Me.Button34.Tag = "Button34"
        Me.Button34.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnM5znTsweya.Caption = "تسوية مخزون"
        Me.btnM5znTsweya.Id = 68
        Me.btnM5znTsweya.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347977291_application_vnd_ms_excel
        Me.btnM5znTsweya.Name = "btnM5znTsweya"
        Me.btnM5znTsweya.Tag = ""
        Me.btnM5znTsweya.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.btnM5znTsweya.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk16
        Me.RibbonChunk16.ItemLinks.Add(Me.Button35)
        Me.RibbonChunk16.ItemLinks.Add(Me.Button36)
        Me.RibbonChunk16.ItemLinks.Add(Me.Button38)
        Me.RibbonChunk16.ItemLinks.Add(Me.Button37)
        Me.RibbonChunk16.ItemLinks.Add(Me.Button23)
        Me.RibbonChunk16.Name = "RibbonChunk16"
        Me.RibbonChunk16.Text = "تقارير المخازن"

        Me.Button35.Caption = "كشف جرد المخازن"
        Me.Button35.Id = 69
        Me.Button35.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349232538_order_history
        Me.Button35.Name = "Button35"
        Me.Button35.Tag = "Button35"
        Me.Button35.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button36.Caption = "ارصدة المخزن حتى تاريخ"
        Me.Button36.Id = 70
        Me.Button36.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347891645_chart
        Me.Button36.Name = "Button36"
        Me.Button36.Tag = "Button36"
        Me.Button36.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button38.Caption = "حركـــــــــــــة صنف محددة"
        Me.Button38.Id = 71
        Me.Button38.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347891452_gnome_mime_application_vnd_lotus_1_2_3
        Me.Button38.Name = "Button38"
        Me.Button38.Tag = "Button38"
        Me.Button38.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button37.Caption = "صنف باجمالي الحركــــــــات"
        Me.Button37.Id = 72
        Me.Button37.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347891553_gnumeric
        Me.Button37.Name = "Button37"
        Me.Button37.Tag = "Button37"
        Me.Button37.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button23.Caption = "الأصناف التي ستنتهي صلاحيتها"
        Me.Button23.Id = 73
        Me.Button23.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349233626_schedule
        Me.Button23.Name = "Button23"
        Me.Button23.Tag = "Button23"
        Me.Button23.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 8 - دعم اتخاذ القرار
        ' ========================================

        Me.RibbonTab8.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk20
        })
        Me.RibbonTab8.Name = "RibbonTab8"
        Me.RibbonTab8.Text = "دعم اتخاذ القرار"

        ' RibbonChunk20
        Me.RibbonChunk20.ItemLinks.Add(Me.Button46)
        Me.RibbonChunk20.Name = "RibbonChunk20"
        Me.RibbonChunk20.Text = "التحليلات"

        Me.Button46.Caption = "معدل الدوران والركود للأصناف"
        Me.Button46.Id = 74
        Me.Button46.LargeGlyph = Global.AQSYS.My.Resources.Resources._1347890539_Emblem_Money_64
        Me.Button46.Name = "Button46"
        Me.Button46.Tag = "Button46"
        Me.Button46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 10 - اجمالي بيع وشراء
        ' ========================================

        Me.RibbonTab10.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk22, Me.RibbonChunk29, Me.RibbonChunk42, Me.RibbonChunk34
        })
        Me.RibbonTab10.Name = "RibbonTab10"
        Me.RibbonTab10.Text = "اجمالي بيع وشراء"

        ' RibbonChunk22
        Me.RibbonChunk22.ItemLinks.Add(Me.Button49)
        Me.RibbonChunk22.ItemLinks.Add(Me.Button50)
        Me.RibbonChunk22.ItemLinks.Add(Me.Button4)
        Me.RibbonChunk22.Name = "RibbonChunk22"
        Me.RibbonChunk22.Text = "الإجماليات"

        Me.Button49.Caption = "الاجمالي جهات مختلفة"
        Me.Button49.Id = 75
        Me.Button49.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234253_folder
        Me.Button49.Name = "Button49"
        Me.Button49.Tag = "Button49"
        Me.Button49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button50.Caption = "اجمالي المبيعات والمشتريات"
        Me.Button50.Id = 76
        Me.Button50.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234340_diagram_11
        Me.Button50.Name = "Button50"
        Me.Button50.Tag = "Button50"
        Me.Button50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button4.Caption = "اجمالي المبيعات والمشتريات جهة عمل أو عميل"
        Me.Button4.Id = 77
        Me.Button4.LargeGlyph = Global.AQSYS.My.Resources.Resources._1348937336_preferences_contact_list
        Me.Button4.Name = "Button4"
        Me.Button4.Tag = "Button4"
        Me.Button4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk29
        Me.RibbonChunk29.ItemLinks.Add(Me.Button1)
        Me.RibbonChunk29.ItemLinks.Add(Me.Button41)
        Me.RibbonChunk29.ItemLinks.Add(Me.Button42)
        Me.RibbonChunk29.Name = "RibbonChunk29"
        Me.RibbonChunk29.Text = "التقارير اليومية"

        Me.Button1.Caption = "تقرير الحركة اليومية"
        Me.Button1.Id = 78
        Me.Button1.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234340_diagram_11
        Me.Button1.Name = "Button1"
        Me.Button1.Tag = "frmRptDailyProcess"
        Me.Button1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button41.Caption = "تقرير تحليل المبيعات"
        Me.Button41.Id = 79
        Me.Button41.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234340_diagram_11
        Me.Button41.Name = "Button41"
        Me.Button41.Tag = "frmRptInvAnalysis"
        Me.Button41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button42.Caption = "تقرير حركة الخزينة"
        Me.Button42.Id = 80
        Me.Button42.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234340_diagram_11
        Me.Button42.Name = "Button42"
        Me.Button42.Tag = "frmRptKhzna"
        Me.Button42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk42
        Me.RibbonChunk42.ItemLinks.Add(Me.btnRptSalesTax)
        Me.RibbonChunk42.ItemLinks.Add(Me.btnRptPurchTax)
        Me.RibbonChunk42.ItemLinks.Add(Me.btnRptTotal)
        Me.RibbonChunk42.ItemLinks.Add(Me.btnRptItemsDaily)
        Me.RibbonChunk42.ItemLinks.Add(Me.btnRptZatca)
        Me.RibbonChunk42.Name = "RibbonChunk42"
        Me.RibbonChunk42.Text = "تقارير الضرائب"

        Me.btnRptSalesTax.Caption = "تقرير ضريبة المبيعات"
        Me.btnRptSalesTax.Id = 81
        Me.btnRptSalesTax.LargeGlyph = CType(resources.GetObject("btnRptSalesTax.Image"), System.Drawing.Image)
        Me.btnRptSalesTax.Name = "btnRptSalesTax"
        Me.btnRptSalesTax.Tag = "btnRpt1"
        Me.btnRptSalesTax.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptPurchTax.Caption = "تقرير ضريبة المشتريات"
        Me.btnRptPurchTax.Id = 82
        Me.btnRptPurchTax.LargeGlyph = CType(resources.GetObject("btnRptPurchTax.Image"), System.Drawing.Image)
        Me.btnRptPurchTax.Name = "btnRptPurchTax"
        Me.btnRptPurchTax.Tag = "btnRpt1"
        Me.btnRptPurchTax.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptTotal.Caption = "تقرير إجمالي اليومية"
        Me.btnRptTotal.Id = 83
        Me.btnRptTotal.LargeGlyph = CType(resources.GetObject("btnRptTotal.Image"), System.Drawing.Image)
        Me.btnRptTotal.Name = "btnRptTotal"
        Me.btnRptTotal.Tag = "frmRptTotal"
        Me.btnRptTotal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptItemsDaily.Caption = "تقرير مبيعات الأصناف"
        Me.btnRptItemsDaily.Id = 84
        Me.btnRptItemsDaily.LargeGlyph = CType(resources.GetObject("btnRptItemsDaily.Image"), System.Drawing.Image)
        Me.btnRptItemsDaily.Name = "btnRptItemsDaily"
        Me.btnRptItemsDaily.Tag = "btnRpt1"
        Me.btnRptItemsDaily.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnRptZatca.Caption = ""
        Me.btnRptZatca.Id = 85
        Me.btnRptZatca.LargeGlyph = CType(resources.GetObject("btnRptZatca.Image"), System.Drawing.Image)
        Me.btnRptZatca.Name = "btnRptZatca"
        Me.btnRptZatca.Tag = "btnRpt1"
        Me.btnRptZatca.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk34
        Me.RibbonChunk34.ItemLinks.Add(Me.btnRptMobApp)
        Me.RibbonChunk34.Name = "RibbonChunk34"
        Me.RibbonChunk34.Text = "تطبيق الموبايل"

        Me.btnRptMobApp.Caption = ""
        Me.btnRptMobApp.Id = 86
        Me.btnRptMobApp.LargeGlyph = CType(resources.GetObject("btnRptMobApp.Image"), System.Drawing.Image)
        Me.btnRptMobApp.Name = "btnRptMobApp"
        Me.btnRptMobApp.Tag = ""
        Me.btnRptMobApp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 11 - اعدادات النظام
        ' ========================================

        Me.RibbonTab11.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk23, Me.RibbonChunk38, Me.RibbonChunk27, Me.RibbonChunk28,
            Me.RibbonChunk39, Me.RibbonChunk31, Me.gpYearClose, Me.RibbonChunk32
        })
        Me.RibbonTab11.Name = "RibbonTab11"
        Me.RibbonTab11.Text = "اعدادات النظام"

        ' RibbonChunk23
        Me.RibbonChunk23.ItemLinks.Add(Me.Button51)
        Me.RibbonChunk23.ItemLinks.Add(Me.btnUserPerm)
        Me.RibbonChunk23.Name = "RibbonChunk23"
        Me.RibbonChunk23.Text = "المستخدمين"

        Me.Button51.Caption = "اضافة مستخدمين"
        Me.Button51.Id = 87
        Me.Button51.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234387_user_group_new
        Me.Button51.Name = "Button51"
        Me.Button51.Tag = "Button51"
        Me.Button51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.btnUserPerm.Caption = "صلاحيات المستخدمين"
        Me.btnUserPerm.Id = 88
        Me.btnUserPerm.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234457_Login_Manager
        Me.btnUserPerm.Name = "btnUserPerm"
        Me.btnUserPerm.Tag = "Button52"
        Me.btnUserPerm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk38
        Me.RibbonChunk38.ItemLinks.Add(Me.Button58)
        Me.RibbonChunk38.Name = "RibbonChunk38"
        Me.RibbonChunk38.Text = "كلمة المرور"

        Me.Button58.Caption = "تغيير كلمة المرور"
        Me.Button58.Id = 89
        Me.Button58.LargeGlyph = Global.AQSYS.My.Resources.Resources.modify_key_icon
        Me.Button58.Name = "Button58"
        Me.Button58.Tag = "Button58"
        Me.Button58.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk27
        Me.RibbonChunk27.ItemLinks.Add(Me.Button3)
        Me.RibbonChunk27.ItemLinks.Add(Me.Button22)
        Me.RibbonChunk27.Name = "RibbonChunk27"
        Me.RibbonChunk27.Text = "الرقابة"
        Me.RibbonChunk27.Visible = False

        Me.Button3.Caption = "الرقابة على بيع وشراء الأصناف"
        Me.Button3.Id = 90
        Me.Button3.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349232538_order_history
        Me.Button3.Name = "Button3"
        Me.Button3.Tag = "Button3"
        Me.Button3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button22.Caption = "افتراضي الطباعة"
        Me.Button22.Id = 91
        Me.Button22.LargeGlyph = Global.AQSYS.My.Resources.Resources.Stock_Folder_Blue_icon
        Me.Button22.Name = "Button22"
        Me.Button22.Tag = "Button22"
        Me.Button22.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk28
        Me.RibbonChunk28.ItemLinks.Add(Me.btnBkUp)
        Me.RibbonChunk28.Name = "RibbonChunk28"
        Me.RibbonChunk28.Text = "النسخ الاحتياطي"

        Me.btnBkUp.Caption = ""
        Me.btnBkUp.Id = 92
        Me.btnBkUp.LargeGlyph = Global.AQSYS.My.Resources.Resources.data_backup_icon
        Me.btnBkUp.Name = "btnBkUp"
        Me.btnBkUp.Tag = "Button11"
        Me.btnBkUp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk39
        Me.RibbonChunk39.ItemLinks.Add(Me.Button59)
        Me.RibbonChunk39.Name = "RibbonChunk39"
        Me.RibbonChunk39.Text = "خصائص المستخدم"

        Me.Button59.Caption = "خصائص المستخدم"
        Me.Button59.Id = 93
        Me.Button59.LargeGlyph = Global.AQSYS.My.Resources.Resources.Actions_user_properties_icon
        Me.Button59.Name = "Button59"
        Me.Button59.Tag = "Button59"
        Me.Button59.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk31
        Me.RibbonChunk31.ItemLinks.Add(Me.btnSMSSett)
        Me.RibbonChunk31.Name = "RibbonChunk31"
        Me.RibbonChunk31.Text = "إعدادات SMS"

        Me.btnSMSSett.Caption = "إعدادات SMS"
        Me.btnSMSSett.Id = 94
        Me.btnSMSSett.LargeGlyph = Global.AQSYS.My.Resources.Resources.Stock_Folder_Blue_icon
        Me.btnSMSSett.Name = "btnSMSSett"
        Me.btnSMSSett.Tag = "Button22"
        Me.btnSMSSett.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' gpYearClose
        Me.gpYearClose.ItemLinks.Add(Me.btnYearClose)
        Me.gpYearClose.Name = "gpYearClose"
        Me.gpYearClose.Text = "السنة المالية"
        Me.gpYearClose.Visible = False

        Me.btnYearClose.Caption = "اقفال السنة المالية"
        Me.btnYearClose.Id = 95
        Me.btnYearClose.LargeGlyph = Global.AQSYS.My.Resources.Resources.Stock_Folder_Blue_icon
        Me.btnYearClose.Name = "btnYearClose"
        Me.btnYearClose.Tag = ""
        Me.btnYearClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk32
        Me.RibbonChunk32.ItemLinks.Add(Me.btnLogin)
        Me.RibbonChunk32.Name = "RibbonChunk32"
        Me.RibbonChunk32.Text = "الدخول"

        Me.btnLogin.Caption = "دخول فرع"
        Me.btnLogin.Id = 96
        Me.btnLogin.LargeGlyph = Global.AQSYS.My.Resources.Resources._1349234457_Login_Manager
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Tag = "Button22"
        Me.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' ========================================
        ' RIBBON TAB 12 - الدعم الفني
        ' ========================================

        Me.RibbonTab12.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {
            Me.RibbonChunk24, Me.RibbonChunk13
        })
        Me.RibbonTab12.Name = "RibbonTab12"
        Me.RibbonTab12.Text = "الدعم الفني"

        ' RibbonChunk24
        Me.RibbonChunk24.ItemLinks.Add(Me.Button12)
        Me.RibbonChunk24.ItemLinks.Add(Me.Button13)
        Me.RibbonChunk24.Name = "RibbonChunk24"
        Me.RibbonChunk24.Text = "الشراء والتفعيل"

        Me.Button12.Caption = "شراء البرنامج"
        Me.Button12.Id = 97
        Me.Button12.LargeGlyph = Global.AQSYS.My.Resources.Resources.shopping_basket_icon
        Me.Button12.Name = "Button12"
        Me.Button12.Tag = "Button12"
        Me.Button12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        Me.Button13.Caption = "تفعيل البرنامج"
        Me.Button13.Id = 98
        Me.Button13.LargeGlyph = Global.AQSYS.My.Resources.Resources.Lock_Unlock_icon
        Me.Button13.Name = "Button13"
        Me.Button13.Tag = "Button13"
        Me.Button13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk13
        Me.RibbonChunk13.ItemLinks.Add(Me.Button69)
        Me.RibbonChunk13.Name = "RibbonChunk13"
        Me.RibbonChunk13.Text = "حول البرنامج"

        Me.Button69.Caption = "عن البرنامج"
        Me.Button69.Id = 99
        Me.Button69.LargeGlyph = CType(resources.GetObject("Button69.Image"), System.Drawing.Image)
        Me.Button69.Name = "Button69"
        Me.Button69.Tag = "Button69"
        Me.Button69.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' Button57
        Me.Button57.Caption = "تغيير كلمة المرور"
        Me.Button57.Id = 106
        Me.Button57.LargeGlyph = Global.AQSYS.My.Resources.Resources.modify_key_icon
        Me.Button57.Name = "Button57"
        Me.Button57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large

        ' RibbonChunk37
        Me.RibbonChunk37.ItemLinks.Add(Me.Button57)
        Me.RibbonChunk37.Name = "RibbonChunk37"
        Me.RibbonChunk37.Text = "كلمة المرور"

        ' ========================================
        ' RIBBON STATUS BAR
        ' ========================================

        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblTime)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.txtLoggedUser)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblBranch)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblIsTrial)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblVersion)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblExpireDiff)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 887)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.Ribbon1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1590, 25)

        Me.lblTime.Caption = ""
        Me.lblTime.Id = 200
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right

        Me.txtLoggedUser.Caption = ""
        Me.txtLoggedUser.Id = 201
        Me.txtLoggedUser.Name = "txtLoggedUser"
        Me.txtLoggedUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right

        Me.lblBranch.Caption = ""
        Me.lblBranch.Id = 202
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right

        Me.lblIsTrial.Caption = ""
        Me.lblIsTrial.Id = 203
        Me.lblIsTrial.Name = "lblIsTrial"
        Me.lblIsTrial.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right

        Me.lblVersion.Caption = ""
        Me.lblVersion.Id = 204
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left

        Me.lblExpireDiff.Caption = ""
        Me.lblExpireDiff.Id = 205
        Me.lblExpireDiff.Name = "lblExpireDiff"
        Me.lblExpireDiff.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left

        ' ========================================
        ' TILE CONTROL - لوحة التحكم الرئيسية
        ' ========================================

        Me.TileControl1.AllowDrag = False
        Me.TileControl1.AllowItemHover = True
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileControl1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TileControl1.AppearanceItem.Hovered.Options.UseBackColor = True
        Me.TileControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TileGroup1)
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.IndentBetweenGroups = 30
        Me.TileControl1.IndentBetweenItems = 15
        Me.TileControl1.ItemSize = 140
        Me.TileControl1.Location = New System.Drawing.Point(0, 185)
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileControl1.Padding = New System.Windows.Forms.Padding(30)
        Me.TileControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TileControl1.Size = New System.Drawing.Size(1590, 702)
        Me.TileControl1.TabIndex = 100

        ' TileGroup1 - المجموعة الأولى
        Me.TileGroup1.Items.Add(Me.tileButton24)
        Me.TileGroup1.Items.Add(Me.tileButton53)
        Me.TileGroup1.Items.Add(Me.tileButton54)
        Me.TileGroup1.Items.Add(Me.tileButton55)
        Me.TileGroup1.Name = "TileGroup1"
        Me.TileGroup1.Text = "العمليات الرئيسية"

        ' TileGroup2 - المجموعة الثانية
        Me.TileGroup2.Items.Add(Me.tileButton56)
        Me.TileGroup2.Items.Add(Me.tileButton62)
        Me.TileGroup2.Items.Add(Me.tileButton63)
        Me.TileGroup2.Items.Add(Me.tileButton64)
        Me.TileGroup2.Name = "TileGroup2"
        Me.TileGroup2.Text = "المبيعات والمشتريات"

        ' TileGroup3 - المجموعة الثالثة
        Me.TileGroup3.Items.Add(Me.tileButton65)
        Me.TileGroup3.Items.Add(Me.tileButton66)
        Me.TileGroup3.Items.Add(Me.tileButton67)
        Me.TileGroup3.Items.Add(Me.tileButton68)
        Me.TileGroup3.Name = "TileGroup3"
        Me.TileGroup3.Text = "الإدارة والتقارير"

        ' ========================================
        ' TILE ITEMS (Dashboard Buttons)
        ' ========================================

        ' tileButton24 - صافي الارباح والمبيعات
        Me.tileButton24.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tileButton24.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton24.Enabled = False
        Me.tileButton24.Id = 0
        Me.tileButton24.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton24.Name = "tileButton24"
        Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement1.Image = Global.AQSYS.My.Resources.Resources._1478657232_Businessman
        tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement2.Appearance.Normal.Options.UseFont = True
        tileItemElement2.Appearance.Normal.Options.UseForeColor = True
        tileItemElement2.Text = "صافي الارباح والمبيعات"
        tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton24.Elements.Add(tileItemElement1)
        Me.tileButton24.Elements.Add(tileItemElement2)

        ' tileButton53 - المخزن
        Me.tileButton53.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.tileButton53.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton53.Enabled = False
        Me.tileButton53.Id = 1
        Me.tileButton53.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton53.Name = "tileButton53"
        Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement3.Image = Global.AQSYS.My.Resources.Resources._1478660363_09
        tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement4.Appearance.Normal.Options.UseFont = True
        tileItemElement4.Appearance.Normal.Options.UseForeColor = True
        tileItemElement4.Text = "المخزن"
        tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton53.Elements.Add(tileItemElement3)
        Me.tileButton53.Elements.Add(tileItemElement4)

        ' tileButton54 - اجمالي فواتير بحسب نوع الفاتورة
        Me.tileButton54.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tileButton54.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton54.Enabled = False
        Me.tileButton54.Id = 2
        Me.tileButton54.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton54.Name = "tileButton54"
        Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement5.Image = Global.AQSYS.My.Resources.Resources._1478660490_custom_reports
        tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement6 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        tileItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement6.Appearance.Normal.Options.UseFont = True
        tileItemElement6.Appearance.Normal.Options.UseForeColor = True
        tileItemElement6.Text = "اجمالي فواتير بحسب نوع الفاتورة"
        tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton54.Elements.Add(tileItemElement5)
        Me.tileButton54.Elements.Add(tileItemElement6)

        ' tileButton55 - النسخ الاحتياطي واستعادة
        Me.tileButton55.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tileButton55.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton55.Enabled = False
        Me.tileButton55.Id = 3
        Me.tileButton55.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton55.Name = "tileButton55"
        Dim tileItemElement7 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement7.Image = Global.AQSYS.My.Resources.Resources._1478660592_xfce_system_settings
        tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement8 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        tileItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement8.Appearance.Normal.Options.UseFont = True
        tileItemElement8.Appearance.Normal.Options.UseForeColor = True
        tileItemElement8.Text = "النسخ الاحتياطي واستعادة"
        tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton55.Elements.Add(tileItemElement7)
        Me.tileButton55.Elements.Add(tileItemElement8)

        ' tileButton56 - المبيعات
        Me.tileButton56.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.tileButton56.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton56.Enabled = False
        Me.tileButton56.Id = 4
        Me.tileButton56.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton56.Name = "tileButton56"
        Dim tileItemElement9 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement9.Image = Global.AQSYS.My.Resources.Resources._1478661667_Green_Buy
        tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement10 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement10.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement10.Appearance.Normal.Options.UseFont = True
        tileItemElement10.Appearance.Normal.Options.UseForeColor = True
        tileItemElement10.Text = "المبيعات"
        tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton56.Elements.Add(tileItemElement9)
        Me.tileButton56.Elements.Add(tileItemElement10)

        ' tileButton62 - الشراء
        Me.tileButton62.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.tileButton62.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton62.Enabled = False
        Me.tileButton62.Id = 5
        Me.tileButton62.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton62.Name = "tileButton62"
        Dim tileItemElement11 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement11.Image = Global.AQSYS.My.Resources.Resources._1478661553_Purple_Shop
        tileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement11.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement12 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement12.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement12.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement12.Appearance.Normal.Options.UseFont = True
        tileItemElement12.Appearance.Normal.Options.UseForeColor = True
        tileItemElement12.Text = "الشراء"
        tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton62.Elements.Add(tileItemElement11)
        Me.tileButton62.Elements.Add(tileItemElement12)

        ' tileButton63 - اضافة مواد
        Me.tileButton63.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tileButton63.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton63.Enabled = False
        Me.tileButton63.Id = 6
        Me.tileButton63.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton63.Name = "tileButton63"
        Dim tileItemElement13 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement13.Image = Global.AQSYS.My.Resources.Resources._1478661750_Green_Add
        tileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement13.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement14 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement14.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement14.Appearance.Normal.Options.UseFont = True
        tileItemElement14.Appearance.Normal.Options.UseForeColor = True
        tileItemElement14.Text = "اضافة مواد"
        tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton63.Elements.Add(tileItemElement13)
        Me.tileButton63.Elements.Add(tileItemElement14)

        ' tileButton64 - العملاء والموردين
        Me.tileButton64.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.tileButton64.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton64.Enabled = False
        Me.tileButton64.Id = 7
        Me.tileButton64.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton64.Name = "tileButton64"
        Dim tileItemElement15 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement15.Image = Global.AQSYS.My.Resources.Resources._1478661827_Black_User
        tileItemElement15.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement15.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement16 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement16.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement16.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement16.Appearance.Normal.Options.UseFont = True
        tileItemElement16.Appearance.Normal.Options.UseForeColor = True
        tileItemElement16.Text = "العملاء والموردين"
        tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton64.Elements.Add(tileItemElement15)
        Me.tileButton64.Elements.Add(tileItemElement16)

        ' tileButton65 - الخروج
        Me.tileButton65.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tileButton65.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton65.Id = 8
        Me.tileButton65.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton65.Name = "tileButton65"
        Dim tileItemElement17 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement17.Image = Global.AQSYS.My.Resources.Resources._1478662022_Log_Out
        tileItemElement17.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement17.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement18 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement18.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement18.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement18.Appearance.Normal.Options.UseFont = True
        tileItemElement18.Appearance.Normal.Options.UseForeColor = True
        tileItemElement18.Text = "الخروج"
        tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton65.Elements.Add(tileItemElement17)
        Me.tileButton65.Elements.Add(tileItemElement18)

        ' tileButton66 - كشف حساب عميل
        Me.tileButton66.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tileButton66.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton66.Enabled = False
        Me.tileButton66.Id = 9
        Me.tileButton66.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton66.Name = "tileButton66"
        Dim tileItemElement19 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement19.Image = Global.AQSYS.My.Resources.Resources._090
        tileItemElement19.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement19.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement20 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement20.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement20.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement20.Appearance.Normal.Options.UseFont = True
        tileItemElement20.Appearance.Normal.Options.UseForeColor = True
        tileItemElement20.Text = "كشف حساب عميل"
        tileItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton66.Elements.Add(tileItemElement19)
        Me.tileButton66.Elements.Add(tileItemElement20)

        ' tileButton67 - اضافة مستخدمين
        Me.tileButton67.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.tileButton67.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton67.Enabled = False
        Me.tileButton67.Id = 10
        Me.tileButton67.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton67.Name = "tileButton67"
        Dim tileItemElement21 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement21.Image = CType(resources.GetObject("Button67.Image"), System.Drawing.Image)
        tileItemElement21.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement21.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement22 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement22.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        tileItemElement22.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement22.Appearance.Normal.Options.UseFont = True
        tileItemElement22.Appearance.Normal.Options.UseForeColor = True
        tileItemElement22.Text = "اضافة مستخدمين"
        tileItemElement22.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton67.Elements.Add(tileItemElement21)
        Me.tileButton67.Elements.Add(tileItemElement22)

        ' tileButton68 - استرجاع فواتير المبيعات
        Me.tileButton68.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.tileButton68.AppearanceItem.Normal.Options.UseBackColor = True
        Me.tileButton68.Enabled = False
        Me.tileButton68.Id = 11
        Me.tileButton68.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.tileButton68.Name = "tileButton68"
        Dim tileItemElement23 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement23.Image = Global.AQSYS.My.Resources.Resources._1478662530_Recover_arrow
        tileItemElement23.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        tileItemElement23.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        Dim tileItemElement24 As New DevExpress.XtraEditors.TileItemElement()
        tileItemElement24.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        tileItemElement24.Appearance.Normal.ForeColor = System.Drawing.Color.White
        tileItemElement24.Appearance.Normal.Options.UseFont = True
        tileItemElement24.Appearance.Normal.Options.UseForeColor = True
        tileItemElement24.Text = "استرجاع فواتير المبيعات"
        tileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.tileButton68.Elements.Add(tileItemElement23)
        Me.tileButton68.Elements.Add(tileItemElement24)

        ' ========================================
        ' TIMERS
        ' ========================================

        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000

        Me.Timer2.Interval = 2000

        Me.Timer3.Interval = 60000

        ' ========================================
        ' HEADER PANEL
        ' ========================================

        Me.pnlHeader.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Appearance.Options.UseBackColor = True
        Me.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 185)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1590, 96)
        Me.pnlHeader.TabIndex = 201
        Me.pnlHeader.Visible = False

        ' lblHeader
        Me.lblHeader.Appearance.BackColor = System.Drawing.Color.White
        Me.lblHeader.Appearance.Font = New System.Drawing.Font("Tahoma", 34.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblHeader.Appearance.Options.UseBackColor = True
        Me.lblHeader.Appearance.Options.UseFont = True
        Me.lblHeader.Appearance.Options.UseForeColor = True
        Me.lblHeader.Appearance.Options.UseTextOptions = True
        Me.lblHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1590, 96)
        Me.lblHeader.TabIndex = 5

        ' ========================================
        ' LABELS
        ' ========================================

        ' Label50
        Me.Label50.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label50.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label50.Appearance.Options.UseFont = True
        Me.Label50.Appearance.Options.UseForeColor = True
        Me.Label50.Location = New System.Drawing.Point(1149, 279)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(371, 92)
        Me.Label50.TabIndex = 208
        Me.Label50.Text = "برنامـــــج الأمهـــــــــــر" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "المحاسبــــــــــــــــــــــي"

        ' lnkUpdate
        Me.lnkUpdate.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lnkUpdate.Appearance.Options.UseFont = True
        Me.lnkUpdate.Location = New System.Drawing.Point(1190, 788)
        Me.lnkUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkUpdate.Name = "lnkUpdate"
        Me.lnkUpdate.Size = New System.Drawing.Size(405, 23)
        Me.lnkUpdate.TabIndex = 209
        Me.lnkUpdate.Text = "متوفر تحديث جديد للنظام، اضغط هنا للتحميل"
        Me.lnkUpdate.Visible = False

        ' Label7
        Me.Label7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label7.Appearance.Options.UseForeColor = True
        Me.Label7.Location = New System.Drawing.Point(766, 441)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 28)
        Me.Label7.TabIndex = 210

        ' lblMarketing
        Me.lblMarketing.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblMarketing.Appearance.Options.UseForeColor = True
        Me.lblMarketing.Location = New System.Drawing.Point(0, 778)
        Me.lblMarketing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarketing.Name = "lblMarketing"
        Me.lblMarketing.Size = New System.Drawing.Size(117, 28)
        Me.lblMarketing.TabIndex = 224

        ' ========================================
        ' PICTURE BOXES
        ' ========================================

        ' picStamp
        Me.picStamp.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStamp.Location = New System.Drawing.Point(1157, 517)
        Me.picStamp.Margin = New System.Windows.Forms.Padding(4)
        Me.picStamp.Name = "picStamp"
        Me.picStamp.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.picStamp.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.picStamp.Size = New System.Drawing.Size(117, 62)
        Me.picStamp.TabIndex = 214

        ' PBCustAcc
        Me.PBCustAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBCustAcc.Location = New System.Drawing.Point(64, 492)
        Me.PBCustAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCustAcc.Name = "PBCustAcc"
        Me.PBCustAcc.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBCustAcc.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBCustAcc.Size = New System.Drawing.Size(117, 62)
        Me.PBCustAcc.TabIndex = 223

        ' PBRetSales
        Me.PBRetSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBRetSales.Location = New System.Drawing.Point(64, 663)
        Me.PBRetSales.Margin = New System.Windows.Forms.Padding(4)
        Me.PBRetSales.Name = "PBRetSales"
        Me.PBRetSales.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBRetSales.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBRetSales.Size = New System.Drawing.Size(117, 62)
        Me.PBRetSales.TabIndex = 222

        ' PBSuppAcc
        Me.PBSuppAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBSuppAcc.Location = New System.Drawing.Point(355, 492)
        Me.PBSuppAcc.Margin = New System.Windows.Forms.Padding(4)
        Me.PBSuppAcc.Name = "PBSuppAcc"
        Me.PBSuppAcc.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBSuppAcc.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBSuppAcc.Size = New System.Drawing.Size(117, 62)
        Me.PBSuppAcc.TabIndex = 221

        ' PBSandSD
        Me.PBSandSD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBSandSD.Location = New System.Drawing.Point(638, 492)
        Me.PBSandSD.Margin = New System.Windows.Forms.Padding(4)
        Me.PBSandSD.Name = "PBSandSD"
        Me.PBSandSD.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBSandSD.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBSandSD.Size = New System.Drawing.Size(117, 62)
        Me.PBSandSD.TabIndex = 220

        ' PBitems
        Me.PBitems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBitems.Location = New System.Drawing.Point(638, 663)
        Me.PBitems.Margin = New System.Windows.Forms.Padding(4)
        Me.PBitems.Name = "PBitems"
        Me.PBitems.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBitems.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBitems.Size = New System.Drawing.Size(117, 62)
        Me.PBitems.TabIndex = 219

        ' PBPurch
        Me.PBPurch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBPurch.Location = New System.Drawing.Point(64, 326)
        Me.PBPurch.Margin = New System.Windows.Forms.Padding(4)
        Me.PBPurch.Name = "PBPurch"
        Me.PBPurch.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBPurch.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBPurch.Size = New System.Drawing.Size(117, 62)
        Me.PBPurch.TabIndex = 218

        ' PBSales
        Me.PBSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBSales.Location = New System.Drawing.Point(355, 326)
        Me.PBSales.Margin = New System.Windows.Forms.Padding(4)
        Me.PBSales.Name = "PBSales"
        Me.PBSales.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBSales.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBSales.Size = New System.Drawing.Size(117, 62)
        Me.PBSales.TabIndex = 217

        ' PBRest
        Me.PBRest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBRest.Location = New System.Drawing.Point(638, 326)
        Me.PBRest.Margin = New System.Windows.Forms.Padding(4)
        Me.PBRest.Name = "PBRest"
        Me.PBRest.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBRest.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBRest.Size = New System.Drawing.Size(117, 62)
        Me.PBRest.TabIndex = 216

        ' PBbkup
        Me.PBbkup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBbkup.Location = New System.Drawing.Point(355, 663)
        Me.PBbkup.Margin = New System.Windows.Forms.Padding(4)
        Me.PBbkup.Name = "PBbkup"
        Me.PBbkup.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.PBbkup.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PBbkup.Size = New System.Drawing.Size(117, 62)
        Me.PBbkup.TabIndex = 215

        ' picFatoora
        Me.picFatoora.Cursor = System.Windows.Forms.Cursors.Default
        Me.picFatoora.Location = New System.Drawing.Point(1098, 590)
        Me.picFatoora.Margin = New System.Windows.Forms.Padding(4)
        Me.picFatoora.Name = "picFatoora"
        Me.picFatoora.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
        Me.picFatoora.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.picFatoora.Size = New System.Drawing.Size(117, 62)
        Me.picFatoora.TabIndex = 225

        ' ========================================
        ' FORM1 - الإعدادات الرئيسية للنموذج
        ' ========================================

        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1590, 912)

        ' إضافة العناصر للنموذج
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.picFatoora)
        Me.Controls.Add(Me.lblMarketing)
        Me.Controls.Add(Me.PBCustAcc)
        Me.Controls.Add(Me.PBRetSales)
        Me.Controls.Add(Me.PBSuppAcc)
        Me.Controls.Add(Me.PBSandSD)
        Me.Controls.Add(Me.PBitems)
        Me.Controls.Add(Me.PBPurch)
        Me.Controls.Add(Me.PBSales)
        Me.Controls.Add(Me.PBRest)
        Me.Controls.Add(Me.PBbkup)
        Me.Controls.Add(Me.picStamp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lnkUpdate)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.Ribbon1)

        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Ribbon = Me.Ribbon1
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "برنامج الأمهر المحاسبي ( محاسبة - إدارة المخازن والمستودعات)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        ' End Init
        CType(Me.Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Popup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClientsSMS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.picStamp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCustAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBRetSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSuppAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSandSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBitems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPurch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBRest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBbkup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFatoora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ========================================
    ' تعريف المتغيرات (Field Declarations)
    ' ========================================

    ' DevExpress Ribbon Controls
    Friend WithEvents Ribbon1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

    ' Ribbon Pages (Tabs)
    Friend WithEvents RibbonTab1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab8 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab10 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab11 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonTab12 As DevExpress.XtraBars.Ribbon.RibbonPage

    ' Ribbon Page Groups (Chunks)
    Friend WithEvents RibbonChunk1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk18 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk19 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk20 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk22 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk23 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk24 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk25 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk26 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk27 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk28 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk29 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk30 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk31 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk32 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk33 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk34 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk35 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk36 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk37 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk38 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk39 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk40 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk41 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk42 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonChunk43 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gbCostCenter As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gpYearClose As DevExpress.XtraBars.Ribbon.RibbonPageGroup

    ' Bar Button Items (Buttons)
    Friend WithEvents btnFoundation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBranches As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSafes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCurrencies As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTreasuries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnits As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCountries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCities As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnArea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBanks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnActs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptCustBalances As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptSuppBalances As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button47 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button45 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGifts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOffers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientInvs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnErsaliaExpenses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptErsalia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOneClientMonitor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientsMonitor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientsSMS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button60 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button61 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPriceShow As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button70 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTawlasManage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnManfc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPurchOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRpt1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRpt2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRpt3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button43 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button48 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button39 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button40 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSansSD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCostCenter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptCostCenter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDailyJournals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOpenJournal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptAcc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnM5znTsweya As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button38 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button37 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button46 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button49 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button50 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button41 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button42 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptSalesTax As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptPurchTax As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptTotal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptItemsDaily As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptZatca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptMobApp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button51 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUserPerm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button58 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBkUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button59 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSMSSett As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnYearClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLogin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button69 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Button57 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MainMenuItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSMSMsgs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientsSendSMS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClientsSMSAlarm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem3 As DevExpress.XtraBars.BarButtonItem

    ' Popup Menus
    Friend WithEvents Popup1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents menu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnClientsSMS1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents menu As DevExpress.XtraBars.PopupMenu

    ' Status Bar Items
    Friend WithEvents lblTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txtLoggedUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblBranch As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblIsTrial As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblExpireDiff As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblDash1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblDash2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblDash3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barStaticItem2 As DevExpress.XtraBars.BarStaticItem

    ' Tile Control
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents tileButton24 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton53 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton54 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton55 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton56 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton62 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton63 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton64 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton65 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton66 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton67 As DevExpress.XtraEditors.TileItem
    Friend WithEvents tileButton68 As DevExpress.XtraEditors.TileItem

    ' Timers
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

    ' Panels
    Friend WithEvents pnlHeader As DevExpress.XtraEditors.PanelControl

    ' Labels
    Friend WithEvents lblHeader As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lnkUpdate As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMarketing As DevExpress.XtraEditors.LabelControl

    ' Picture Boxes
    Friend WithEvents picStamp As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBCustAcc As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBRetSales As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBSuppAcc As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBSandSD As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBitems As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBPurch As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBSales As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBRest As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PBbkup As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picFatoora As DevExpress.XtraEditors.PictureEdit

    ' Components

End Class
