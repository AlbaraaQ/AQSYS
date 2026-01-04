Imports DevExpress.XtraReports.UserDesigner

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ReportDesign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim BarInfo1 As BarInfo = New BarInfo()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frm_ReportDesign))
        Dim XrDesignPanelListener1 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener2 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener3 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener4 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener5 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener6 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener7 As XRDesignPanelListener = New XRDesignPanelListener()
        Dim XrDesignPanelListener8 As XRDesignPanelListener = New XRDesignPanelListener()
        Bar2 = New DevExpress.XtraBars.Bar()
        XrDesignBarManager1 = New XRDesignBarManager(components)
        DesignBar1 = New DesignBar()
        msiFile = New DevExpress.XtraBars.BarSubItem()
        CommandBarItem1 = New CommandBarItem()
        CommandBarItem2 = New CommandBarItem()
        bbiOpenFile = New CommandBarItem()
        bbiSaveFile = New CommandBarItem()
        CommandBarItem3 = New CommandBarItem()
        CommandBarItem7 = New CommandBarItem()
        CommandBarItem11 = New CommandBarItem()
        CommandBarItem4 = New CommandBarItem()
        msiEdit = New DevExpress.XtraBars.BarSubItem()
        bbiUndo = New CommandBarItem()
        bbiRedo = New CommandBarItem()
        bbiCut = New CommandBarItem()
        bbiCopy = New CommandBarItem()
        bbiPaste = New CommandBarItem()
        CommandBarItem5 = New CommandBarItem()
        CommandBarItem6 = New CommandBarItem()
        msiTabButtons = New DevExpress.XtraBars.BarSubItem()
        BarReportTabButtonsListItem1 = New BarReportTabButtonsListItem()
        BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        XrBarToolbarsListItem1 = New XRBarToolbarsListItem()
        BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        BarDockPanelsListItem1 = New BarDockPanelsListItem()
        msiFormat = New DevExpress.XtraBars.BarSubItem()
        bbiForeColor = New CommandColorBarItem()
        bbiBackColor = New CommandColorBarItem()
        msiFont = New DevExpress.XtraBars.BarSubItem()
        bbiFontBold = New CommandBarItem()
        bbiFontItalic = New CommandBarItem()
        bbiFontUnderline = New CommandBarItem()
        msiJustify = New DevExpress.XtraBars.BarSubItem()
        bbiJustifyLeft = New CommandBarItem()
        bbiJustifyCenter = New CommandBarItem()
        bbiJustifyRight = New CommandBarItem()
        bbiJustifyJustify = New CommandBarItem()
        msiAlign = New DevExpress.XtraBars.BarSubItem()
        bbiAlignLeft = New CommandBarItem()
        bbiAlignVerticalCenters = New CommandBarItem()
        bbiAlignRight = New CommandBarItem()
        bbiAlignTop = New CommandBarItem()
        bbiAlignHorizontalCenters = New CommandBarItem()
        bbiAlignBottom = New CommandBarItem()
        bbiAlignToGrid = New CommandBarItem()
        msiSameSize = New DevExpress.XtraBars.BarSubItem()
        bbiSizeToControlWidth = New CommandBarItem()
        bbiSizeToGrid = New CommandBarItem()
        bbiSizeToControlHeight = New CommandBarItem()
        bbiSizeToControl = New CommandBarItem()
        msiHorizontalSpacing = New DevExpress.XtraBars.BarSubItem()
        bbiHorizSpaceMakeEqual = New CommandBarItem()
        bbiHorizSpaceIncrease = New CommandBarItem()
        bbiHorizSpaceDecrease = New CommandBarItem()
        bbiHorizSpaceConcatenate = New CommandBarItem()
        msiVerticalSpacing = New DevExpress.XtraBars.BarSubItem()
        bbiVertSpaceMakeEqual = New CommandBarItem()
        bbiVertSpaceIncrease = New CommandBarItem()
        bbiVertSpaceDecrease = New CommandBarItem()
        bbiVertSpaceConcatenate = New CommandBarItem()
        bsiCenter = New DevExpress.XtraBars.BarSubItem()
        bbiCenterHorizontally = New CommandBarItem()
        bbiCenterVertically = New CommandBarItem()
        msiOrder = New DevExpress.XtraBars.BarSubItem()
        bbiBringToFront = New CommandBarItem()
        bbiSendToBack = New CommandBarItem()
        msiWindow = New DevExpress.XtraBars.BarSubItem()
        msiWindowInterface = New CommandBarCheckItem()
        CommandBarItem8 = New CommandBarItem()
        CommandBarItem9 = New CommandBarItem()
        CommandBarItem10 = New CommandBarItem()
        msiWindows = New DevExpress.XtraBars.BarMdiChildrenListItem()
        DesignBar2 = New DesignBar()
        DesignBar3 = New DesignBar()
        beiFontName = New DevExpress.XtraBars.BarEditItem()
        RecentlyUsedItemsComboBox1 = New RecentlyUsedItemsComboBox()
        beiFontSize = New DevExpress.XtraBars.BarEditItem()
        DesignRepositoryItemComboBox1 = New DesignRepositoryItemComboBox()
        DesignBar4 = New DesignBar()
        DesignBar5 = New DesignBar()
        bsiHint = New DevExpress.XtraBars.BarStaticItem()
        Bar1 = New DevExpress.XtraBars.Bar()
        bbiZoomOut = New CommandBarItem()
        bbiZoom = New XRZoomBarEditItem()
        DesignRepositoryItemComboBox2 = New DesignRepositoryItemComboBox()
        bbiZoomIn = New CommandBarItem()
        barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        XrDesignDockManager1 = New XRDesignDockManager(components)
        panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
        panelContainer2 = New DevExpress.XtraBars.Docking.DockPanel()
        ReportExplorerDockPanel1 = New ReportExplorerDockPanel()
        ReportExplorerDockPanel1_Container = New DesignControlContainer()
        FieldListDockPanel1 = New FieldListDockPanel()
        FieldListDockPanel1_Container = New DesignControlContainer()
        panelContainer3 = New DevExpress.XtraBars.Docking.DockPanel()
        PropertyGridDockPanel1 = New PropertyGridDockPanel()
        PropertyGridDockPanel1_Container = New DesignControlContainer()
        ReportGalleryDockPanel1 = New ReportGalleryDockPanel()
        ReportGalleryDockPanel1_Container = New DesignControlContainer()
        panelContainer4 = New DevExpress.XtraBars.Docking.DockPanel()
        GroupAndSortDockPanel1 = New GroupAndSortDockPanel()
        GroupAndSortDockPanel1_Container = New DesignControlContainer()
        ErrorListDockPanel1 = New ErrorListDockPanel()
        ErrorListDockPanel1_Container = New DesignControlContainer()
        ReportDesigner1 = New XRDesignMdiController(components)
        CType(XrDesignBarManager1, ComponentModel.ISupportInitialize).BeginInit()
        CType(RecentlyUsedItemsComboBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DesignRepositoryItemComboBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DesignRepositoryItemComboBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(XrDesignDockManager1, ComponentModel.ISupportInitialize).BeginInit()
        panelContainer1.SuspendLayout()
        panelContainer2.SuspendLayout()
        ReportExplorerDockPanel1.SuspendLayout()
        FieldListDockPanel1.SuspendLayout()
        panelContainer3.SuspendLayout()
        PropertyGridDockPanel1.SuspendLayout()
        ReportGalleryDockPanel1.SuspendLayout()
        panelContainer4.SuspendLayout()
        GroupAndSortDockPanel1.SuspendLayout()
        ErrorListDockPanel1.SuspendLayout()
        CType(ReportDesigner1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Bar2
        ' 
        Bar2.BarName = "Toolbox"
        Bar2.DockCol = 0
        Bar2.DockRow = 0
        Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
        Bar2.OptionsBar.AllowQuickCustomization = False
        Bar2.Text = "Standard Controls"
        ' 
        ' XrDesignBarManager1
        ' 
        BarInfo1.Bar = Bar2
        BarInfo1.ToolboxType = ToolboxType.Standard
        XrDesignBarManager1.BarInfos.AddRange(New BarInfo() {BarInfo1})
        XrDesignBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {DesignBar1, DesignBar2, DesignBar3, DesignBar4, DesignBar5, Bar1, Bar2})
        XrDesignBarManager1.DockControls.Add(barDockControlTop)
        XrDesignBarManager1.DockControls.Add(barDockControlBottom)
        XrDesignBarManager1.DockControls.Add(barDockControlLeft)
        XrDesignBarManager1.DockControls.Add(barDockControlRight)
        XrDesignBarManager1.DockManager = XrDesignDockManager1
        XrDesignBarManager1.FontNameBox = RecentlyUsedItemsComboBox1
        XrDesignBarManager1.FontNameEdit = beiFontName
        XrDesignBarManager1.FontSizeBox = DesignRepositoryItemComboBox1
        XrDesignBarManager1.FontSizeEdit = beiFontSize
        XrDesignBarManager1.Form = Me
        XrDesignBarManager1.FormattingToolbar = DesignBar3
        XrDesignBarManager1.HintStaticItem = bsiHint
        XrDesignBarManager1.ImageStream = CType(resources.GetObject("XrDesignBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        XrDesignBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {beiFontName, beiFontSize, bbiFontBold, bbiFontItalic, bbiFontUnderline, bbiForeColor, bbiBackColor, bbiJustifyLeft, bbiJustifyCenter, bbiJustifyRight, bbiJustifyJustify, bbiAlignToGrid, bbiAlignLeft, bbiAlignVerticalCenters, bbiAlignRight, bbiAlignTop, bbiAlignHorizontalCenters, bbiAlignBottom, bbiSizeToControlWidth, bbiSizeToGrid, bbiSizeToControlHeight, bbiSizeToControl, bbiHorizSpaceMakeEqual, bbiHorizSpaceIncrease, bbiHorizSpaceDecrease, bbiHorizSpaceConcatenate, bbiVertSpaceMakeEqual, bbiVertSpaceIncrease, bbiVertSpaceDecrease, bbiVertSpaceConcatenate, bbiCenterHorizontally, bbiCenterVertically, bbiBringToFront, bbiSendToBack, CommandBarItem1, bbiOpenFile, bbiSaveFile, bbiCut, bbiCopy, bbiPaste, bbiUndo, bbiRedo, bsiHint, msiFile, msiEdit, msiTabButtons, BarReportTabButtonsListItem1, BarSubItem1, XrBarToolbarsListItem1, BarSubItem2, BarDockPanelsListItem1, msiFormat, msiFont, msiJustify, msiAlign, msiSameSize, msiHorizontalSpacing, msiVerticalSpacing, bsiCenter, msiOrder, CommandBarItem2, CommandBarItem3, CommandBarItem4, CommandBarItem5, CommandBarItem6, CommandBarItem7, msiWindow, msiWindowInterface, CommandBarItem8, CommandBarItem9, CommandBarItem10, msiWindows, CommandBarItem11, bbiZoomOut, bbiZoom, bbiZoomIn})
        XrDesignBarManager1.LayoutToolbar = DesignBar4
        XrDesignBarManager1.MainMenu = DesignBar1
        XrDesignBarManager1.MaxItemId = 76
        XrDesignBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {RecentlyUsedItemsComboBox1, DesignRepositoryItemComboBox1, DesignRepositoryItemComboBox2})
        XrDesignBarManager1.StatusBar = DesignBar5
        XrDesignBarManager1.Toolbar = DesignBar2
        XrDesignBarManager1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True
        XrDesignBarManager1.Updates.AddRange(New String() {"Toolbox"})
        XrDesignBarManager1.ZoomItem = bbiZoom
        ' 
        ' DesignBar1
        ' 
        DesignBar1.BarName = "Main Menu"
        DesignBar1.DockCol = 0
        DesignBar1.DockRow = 0
        DesignBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        DesignBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(msiFile), New DevExpress.XtraBars.LinkPersistInfo(msiEdit), New DevExpress.XtraBars.LinkPersistInfo(msiTabButtons), New DevExpress.XtraBars.LinkPersistInfo(msiFormat), New DevExpress.XtraBars.LinkPersistInfo(msiWindow)})
        DesignBar1.OptionsBar.MultiLine = True
        DesignBar1.OptionsBar.UseWholeRow = True
        DesignBar1.Text = "Main Menu"
        ' 
        ' msiFile
        ' 
        msiFile.Caption = "&File"
        msiFile.Id = 43
        msiFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem1), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem2), New DevExpress.XtraBars.LinkPersistInfo(bbiOpenFile), New DevExpress.XtraBars.LinkPersistInfo(bbiSaveFile, True), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem3), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem7), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem11), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem4, True)})
        msiFile.Name = "msiFile"
        ' 
        ' CommandBarItem1
        ' 
        CommandBarItem1.Caption = "&New"
        CommandBarItem1.Command = ReportCommand.NewReport
        CommandBarItem1.Enabled = False
        CommandBarItem1.Hint = "Create a new blank report"
        CommandBarItem1.Id = 34
        CommandBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.N)
        CommandBarItem1.Name = "CommandBarItem1"
        ' 
        ' CommandBarItem2
        ' 
        CommandBarItem2.Caption = "New via &Wizard..."
        CommandBarItem2.Command = ReportCommand.NewReportWizard
        CommandBarItem2.Enabled = False
        CommandBarItem2.Hint = "Create a new report using the Wizard"
        CommandBarItem2.Id = 60
        CommandBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.W)
        CommandBarItem2.Name = "CommandBarItem2"
        ' 
        ' bbiOpenFile
        ' 
        bbiOpenFile.Caption = "&Open..."
        bbiOpenFile.Command = ReportCommand.OpenFile
        bbiOpenFile.Enabled = False
        bbiOpenFile.Hint = "Open a report"
        bbiOpenFile.Id = 35
        bbiOpenFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.O)
        bbiOpenFile.Name = "bbiOpenFile"
        ' 
        ' bbiSaveFile
        ' 
        bbiSaveFile.Caption = "&Save"
        bbiSaveFile.Command = ReportCommand.SaveFile
        bbiSaveFile.Enabled = False
        bbiSaveFile.Hint = "Save the report"
        bbiSaveFile.Id = 36
        bbiSaveFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.S)
        bbiSaveFile.Name = "bbiSaveFile"
        ' 
        ' CommandBarItem3
        ' 
        CommandBarItem3.Caption = "Save &As..."
        CommandBarItem3.Command = ReportCommand.SaveFileAs
        CommandBarItem3.Enabled = False
        CommandBarItem3.Hint = "Save the report with a new name"
        CommandBarItem3.Id = 61
        CommandBarItem3.Name = "CommandBarItem3"
        ' 
        ' CommandBarItem7
        ' 
        CommandBarItem7.Caption = "Save A&ll"
        CommandBarItem7.Command = ReportCommand.SaveAll
        CommandBarItem7.Enabled = False
        CommandBarItem7.Hint = "Save all reports"
        CommandBarItem7.Id = 65
        CommandBarItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.L)
        CommandBarItem7.Name = "CommandBarItem7"
        ' 
        ' CommandBarItem11
        ' 
        CommandBarItem11.Caption = "&Close"
        CommandBarItem11.Command = ReportCommand.Close
        CommandBarItem11.Enabled = False
        CommandBarItem11.Hint = "Close the report"
        CommandBarItem11.Id = 72
        CommandBarItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.F4)
        CommandBarItem11.Name = "CommandBarItem11"
        ' 
        ' CommandBarItem4
        ' 
        CommandBarItem4.Caption = "E&xit"
        CommandBarItem4.Command = ReportCommand.Exit
        CommandBarItem4.Enabled = False
        CommandBarItem4.Hint = "Close the designer"
        CommandBarItem4.Id = 62
        CommandBarItem4.Name = "CommandBarItem4"
        ' 
        ' msiEdit
        ' 
        msiEdit.Caption = "&Edit"
        msiEdit.Id = 44
        msiEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiUndo, True), New DevExpress.XtraBars.LinkPersistInfo(bbiRedo), New DevExpress.XtraBars.LinkPersistInfo(bbiCut, True), New DevExpress.XtraBars.LinkPersistInfo(bbiCopy), New DevExpress.XtraBars.LinkPersistInfo(bbiPaste), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem5), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem6, True)})
        msiEdit.Name = "msiEdit"
        ' 
        ' bbiUndo
        ' 
        bbiUndo.Caption = "&Undo"
        bbiUndo.Command = ReportCommand.Undo
        bbiUndo.Enabled = False
        bbiUndo.Hint = "Undo the last operation"
        bbiUndo.Id = 40
        bbiUndo.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.Z)
        bbiUndo.Name = "bbiUndo"
        ' 
        ' bbiRedo
        ' 
        bbiRedo.Caption = "&Redo"
        bbiRedo.Command = ReportCommand.Redo
        bbiRedo.Enabled = False
        bbiRedo.Hint = "Redo the last operation"
        bbiRedo.Id = 41
        bbiRedo.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.Y)
        bbiRedo.Name = "bbiRedo"
        ' 
        ' bbiCut
        ' 
        bbiCut.Caption = "Cu&t"
        bbiCut.Command = ReportCommand.Cut
        bbiCut.Enabled = False
        bbiCut.Hint = "Delete the control and copy it to the clipboard"
        bbiCut.Id = 37
        bbiCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.X)
        bbiCut.Name = "bbiCut"
        ' 
        ' bbiCopy
        ' 
        bbiCopy.Caption = "&Copy"
        bbiCopy.Command = ReportCommand.Copy
        bbiCopy.Enabled = False
        bbiCopy.Hint = "Copy the control to the clipboard"
        bbiCopy.Id = 38
        bbiCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.C)
        bbiCopy.Name = "bbiCopy"
        ' 
        ' bbiPaste
        ' 
        bbiPaste.Caption = "&Paste"
        bbiPaste.Command = ReportCommand.Paste
        bbiPaste.Enabled = False
        bbiPaste.Hint = "Add the control from the clipboard"
        bbiPaste.Id = 39
        bbiPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.V)
        bbiPaste.Name = "bbiPaste"
        ' 
        ' CommandBarItem5
        ' 
        CommandBarItem5.Caption = "&Delete"
        CommandBarItem5.Command = ReportCommand.Delete
        CommandBarItem5.Enabled = False
        CommandBarItem5.Hint = "Delete the control"
        CommandBarItem5.Id = 63
        CommandBarItem5.Name = "CommandBarItem5"
        ' 
        ' CommandBarItem6
        ' 
        CommandBarItem6.Caption = "Select &All"
        CommandBarItem6.Command = ReportCommand.SelectAll
        CommandBarItem6.Enabled = False
        CommandBarItem6.Hint = "Select all the controls in the document"
        CommandBarItem6.Id = 64
        CommandBarItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.A)
        CommandBarItem6.Name = "CommandBarItem6"
        ' 
        ' msiTabButtons
        ' 
        msiTabButtons.Caption = "&View"
        msiTabButtons.Id = 45
        msiTabButtons.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarReportTabButtonsListItem1), New DevExpress.XtraBars.LinkPersistInfo(BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(BarSubItem2, True)})
        msiTabButtons.Name = "msiTabButtons"
        ' 
        ' BarReportTabButtonsListItem1
        ' 
        BarReportTabButtonsListItem1.Caption = "Tab Buttons"
        BarReportTabButtonsListItem1.Id = 46
        BarReportTabButtonsListItem1.Name = "BarReportTabButtonsListItem1"
        ' 
        ' BarSubItem1
        ' 
        BarSubItem1.Caption = "&Toolbars"
        BarSubItem1.Id = 47
        BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(XrBarToolbarsListItem1)})
        BarSubItem1.Name = "BarSubItem1"
        ' 
        ' XrBarToolbarsListItem1
        ' 
        XrBarToolbarsListItem1.Caption = "&Toolbars"
        XrBarToolbarsListItem1.Id = 48
        XrBarToolbarsListItem1.Name = "XrBarToolbarsListItem1"
        ' 
        ' BarSubItem2
        ' 
        BarSubItem2.Caption = "&Windows"
        BarSubItem2.Id = 49
        BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarDockPanelsListItem1)})
        BarSubItem2.Name = "BarSubItem2"
        ' 
        ' BarDockPanelsListItem1
        ' 
        BarDockPanelsListItem1.Caption = "&Windows"
        BarDockPanelsListItem1.DockManager = Nothing
        BarDockPanelsListItem1.Id = 50
        BarDockPanelsListItem1.Name = "BarDockPanelsListItem1"
        BarDockPanelsListItem1.ShowCustomizationItem = False
        BarDockPanelsListItem1.ShowDockPanels = True
        BarDockPanelsListItem1.ShowToolbars = False
        ' 
        ' msiFormat
        ' 
        msiFormat.Caption = "Fo&rmat"
        msiFormat.Id = 51
        msiFormat.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiForeColor), New DevExpress.XtraBars.LinkPersistInfo(bbiBackColor), New DevExpress.XtraBars.LinkPersistInfo(msiFont, True), New DevExpress.XtraBars.LinkPersistInfo(msiJustify), New DevExpress.XtraBars.LinkPersistInfo(msiAlign, True), New DevExpress.XtraBars.LinkPersistInfo(msiSameSize), New DevExpress.XtraBars.LinkPersistInfo(msiHorizontalSpacing, True), New DevExpress.XtraBars.LinkPersistInfo(msiVerticalSpacing), New DevExpress.XtraBars.LinkPersistInfo(bsiCenter, True), New DevExpress.XtraBars.LinkPersistInfo(msiOrder, True)})
        msiFormat.Name = "msiFormat"
        ' 
        ' bbiForeColor
        ' 
        bbiForeColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        bbiForeColor.Caption = "For&eground Color"
        bbiForeColor.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.False
        bbiForeColor.Command = ReportCommand.ForeColor
        bbiForeColor.Enabled = False
        bbiForeColor.Hint = "Set the foreground color of the control"
        bbiForeColor.Id = 5
        bbiForeColor.Name = "bbiForeColor"
        ' 
        ' bbiBackColor
        ' 
        bbiBackColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        bbiBackColor.Caption = "Bac&kground Color"
        bbiBackColor.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.False
        bbiBackColor.Command = ReportCommand.BackColor
        bbiBackColor.Enabled = False
        bbiBackColor.Hint = "Set the background color of the control"
        bbiBackColor.Id = 6
        bbiBackColor.Name = "bbiBackColor"
        ' 
        ' msiFont
        ' 
        msiFont.Caption = "&Font"
        msiFont.Id = 52
        msiFont.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiFontBold, True), New DevExpress.XtraBars.LinkPersistInfo(bbiFontItalic), New DevExpress.XtraBars.LinkPersistInfo(bbiFontUnderline)})
        msiFont.Name = "msiFont"
        ' 
        ' bbiFontBold
        ' 
        bbiFontBold.Caption = "&Bold"
        bbiFontBold.Command = ReportCommand.FontBold
        bbiFontBold.Enabled = False
        bbiFontBold.Hint = "Make the font bold"
        bbiFontBold.Id = 2
        bbiFontBold.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.B)
        bbiFontBold.Name = "bbiFontBold"
        ' 
        ' bbiFontItalic
        ' 
        bbiFontItalic.Caption = "&Italic"
        bbiFontItalic.Command = ReportCommand.FontItalic
        bbiFontItalic.Enabled = False
        bbiFontItalic.Hint = "Make the font italic"
        bbiFontItalic.Id = 3
        bbiFontItalic.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.I)
        bbiFontItalic.Name = "bbiFontItalic"
        ' 
        ' bbiFontUnderline
        ' 
        bbiFontUnderline.Caption = "&Underline"
        bbiFontUnderline.Command = ReportCommand.FontUnderline
        bbiFontUnderline.Enabled = False
        bbiFontUnderline.Hint = "Underline the font"
        bbiFontUnderline.Id = 4
        bbiFontUnderline.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.U)
        bbiFontUnderline.Name = "bbiFontUnderline"
        ' 
        ' msiJustify
        ' 
        msiJustify.Caption = "&Justify"
        msiJustify.Id = 53
        msiJustify.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyLeft, True), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyCenter), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyRight), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyJustify)})
        msiJustify.Name = "msiJustify"
        ' 
        ' bbiJustifyLeft
        ' 
        bbiJustifyLeft.Caption = "&Left"
        bbiJustifyLeft.Command = ReportCommand.JustifyLeft
        bbiJustifyLeft.Enabled = False
        bbiJustifyLeft.Hint = "Align the control's text to the left"
        bbiJustifyLeft.Id = 7
        bbiJustifyLeft.Name = "bbiJustifyLeft"
        ' 
        ' bbiJustifyCenter
        ' 
        bbiJustifyCenter.Caption = "&Center"
        bbiJustifyCenter.Command = ReportCommand.JustifyCenter
        bbiJustifyCenter.Enabled = False
        bbiJustifyCenter.Hint = "Align the control's text to the center"
        bbiJustifyCenter.Id = 8
        bbiJustifyCenter.Name = "bbiJustifyCenter"
        ' 
        ' bbiJustifyRight
        ' 
        bbiJustifyRight.Caption = "&Rights"
        bbiJustifyRight.Command = ReportCommand.JustifyRight
        bbiJustifyRight.Enabled = False
        bbiJustifyRight.Hint = "Align the control's text to the right"
        bbiJustifyRight.Id = 9
        bbiJustifyRight.Name = "bbiJustifyRight"
        ' 
        ' bbiJustifyJustify
        ' 
        bbiJustifyJustify.Caption = "&Justify"
        bbiJustifyJustify.Command = ReportCommand.JustifyJustify
        bbiJustifyJustify.Enabled = False
        bbiJustifyJustify.Hint = "Justify the control's text"
        bbiJustifyJustify.Id = 10
        bbiJustifyJustify.Name = "bbiJustifyJustify"
        ' 
        ' msiAlign
        ' 
        msiAlign.Caption = "&Align"
        msiAlign.Id = 54
        msiAlign.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiAlignLeft, True), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignVerticalCenters), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignRight), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignTop, True), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignHorizontalCenters), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignBottom), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignToGrid, True)})
        msiAlign.Name = "msiAlign"
        ' 
        ' bbiAlignLeft
        ' 
        bbiAlignLeft.Caption = "&Lefts"
        bbiAlignLeft.Command = ReportCommand.AlignLeft
        bbiAlignLeft.Enabled = False
        bbiAlignLeft.Hint = "Left align the selected controls"
        bbiAlignLeft.Id = 12
        bbiAlignLeft.Name = "bbiAlignLeft"
        ' 
        ' bbiAlignVerticalCenters
        ' 
        bbiAlignVerticalCenters.Caption = "&Centers"
        bbiAlignVerticalCenters.Command = ReportCommand.AlignVerticalCenters
        bbiAlignVerticalCenters.Enabled = False
        bbiAlignVerticalCenters.Hint = "Align the centers of the selected controls vertically"
        bbiAlignVerticalCenters.Id = 13
        bbiAlignVerticalCenters.Name = "bbiAlignVerticalCenters"
        ' 
        ' bbiAlignRight
        ' 
        bbiAlignRight.Caption = "&Rights"
        bbiAlignRight.Command = ReportCommand.AlignRight
        bbiAlignRight.Enabled = False
        bbiAlignRight.Hint = "Right align the selected controls"
        bbiAlignRight.Id = 14
        bbiAlignRight.Name = "bbiAlignRight"
        ' 
        ' bbiAlignTop
        ' 
        bbiAlignTop.Caption = "&Tops"
        bbiAlignTop.Command = ReportCommand.AlignTop
        bbiAlignTop.Enabled = False
        bbiAlignTop.Hint = "Align the tops of the selected controls"
        bbiAlignTop.Id = 15
        bbiAlignTop.Name = "bbiAlignTop"
        ' 
        ' bbiAlignHorizontalCenters
        ' 
        bbiAlignHorizontalCenters.Caption = "&Middles"
        bbiAlignHorizontalCenters.Command = ReportCommand.AlignHorizontalCenters
        bbiAlignHorizontalCenters.Enabled = False
        bbiAlignHorizontalCenters.Hint = "Align the centers of the selected controls horizontally"
        bbiAlignHorizontalCenters.Id = 16
        bbiAlignHorizontalCenters.Name = "bbiAlignHorizontalCenters"
        ' 
        ' bbiAlignBottom
        ' 
        bbiAlignBottom.Caption = "&Bottoms"
        bbiAlignBottom.Command = ReportCommand.AlignBottom
        bbiAlignBottom.Enabled = False
        bbiAlignBottom.Hint = "Align the bottoms of the selected controls"
        bbiAlignBottom.Id = 17
        bbiAlignBottom.Name = "bbiAlignBottom"
        ' 
        ' bbiAlignToGrid
        ' 
        bbiAlignToGrid.Caption = "to &Grid"
        bbiAlignToGrid.Command = ReportCommand.AlignToGrid
        bbiAlignToGrid.Enabled = False
        bbiAlignToGrid.Hint = "Align the positions of the selected controls to the grid"
        bbiAlignToGrid.Id = 11
        bbiAlignToGrid.Name = "bbiAlignToGrid"
        ' 
        ' msiSameSize
        ' 
        msiSameSize.Caption = "&Make Same Size"
        msiSameSize.Id = 55
        msiSameSize.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControlWidth, True), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToGrid), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControlHeight), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControl)})
        msiSameSize.Name = "msiSameSize"
        ' 
        ' bbiSizeToControlWidth
        ' 
        bbiSizeToControlWidth.Caption = "&Width"
        bbiSizeToControlWidth.Command = ReportCommand.SizeToControlWidth
        bbiSizeToControlWidth.Enabled = False
        bbiSizeToControlWidth.Hint = "Make the selected controls have the same width"
        bbiSizeToControlWidth.Id = 18
        bbiSizeToControlWidth.Name = "bbiSizeToControlWidth"
        ' 
        ' bbiSizeToGrid
        ' 
        bbiSizeToGrid.Caption = "Size to Gri&d"
        bbiSizeToGrid.Command = ReportCommand.SizeToGrid
        bbiSizeToGrid.Enabled = False
        bbiSizeToGrid.Hint = "Size the selected controls to the grid"
        bbiSizeToGrid.Id = 19
        bbiSizeToGrid.Name = "bbiSizeToGrid"
        ' 
        ' bbiSizeToControlHeight
        ' 
        bbiSizeToControlHeight.Caption = "&Height"
        bbiSizeToControlHeight.Command = ReportCommand.SizeToControlHeight
        bbiSizeToControlHeight.Enabled = False
        bbiSizeToControlHeight.Hint = "Make the selected controls have the same height"
        bbiSizeToControlHeight.Id = 20
        bbiSizeToControlHeight.Name = "bbiSizeToControlHeight"
        ' 
        ' bbiSizeToControl
        ' 
        bbiSizeToControl.Caption = "&Both"
        bbiSizeToControl.Command = ReportCommand.SizeToControl
        bbiSizeToControl.Enabled = False
        bbiSizeToControl.Hint = "Make the selected controls the same size"
        bbiSizeToControl.Id = 21
        bbiSizeToControl.Name = "bbiSizeToControl"
        ' 
        ' msiHorizontalSpacing
        ' 
        msiHorizontalSpacing.Caption = "&Horizontal Spacing"
        msiHorizontalSpacing.Id = 56
        msiHorizontalSpacing.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceMakeEqual, True), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceIncrease), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceDecrease), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceConcatenate)})
        msiHorizontalSpacing.Name = "msiHorizontalSpacing"
        ' 
        ' bbiHorizSpaceMakeEqual
        ' 
        bbiHorizSpaceMakeEqual.Caption = "Make &Equal"
        bbiHorizSpaceMakeEqual.Command = ReportCommand.HorizSpaceMakeEqual
        bbiHorizSpaceMakeEqual.Enabled = False
        bbiHorizSpaceMakeEqual.Hint = "Make the spacing between the selected controls equal"
        bbiHorizSpaceMakeEqual.Id = 22
        bbiHorizSpaceMakeEqual.Name = "bbiHorizSpaceMakeEqual"
        ' 
        ' bbiHorizSpaceIncrease
        ' 
        bbiHorizSpaceIncrease.Caption = "&Increase"
        bbiHorizSpaceIncrease.Command = ReportCommand.HorizSpaceIncrease
        bbiHorizSpaceIncrease.Enabled = False
        bbiHorizSpaceIncrease.Hint = "Increase the spacing between the selected controls"
        bbiHorizSpaceIncrease.Id = 23
        bbiHorizSpaceIncrease.Name = "bbiHorizSpaceIncrease"
        ' 
        ' bbiHorizSpaceDecrease
        ' 
        bbiHorizSpaceDecrease.Caption = "&Decrease"
        bbiHorizSpaceDecrease.Command = ReportCommand.HorizSpaceDecrease
        bbiHorizSpaceDecrease.Enabled = False
        bbiHorizSpaceDecrease.Hint = "Decrease the spacing between the selected controls"
        bbiHorizSpaceDecrease.Id = 24
        bbiHorizSpaceDecrease.Name = "bbiHorizSpaceDecrease"
        ' 
        ' bbiHorizSpaceConcatenate
        ' 
        bbiHorizSpaceConcatenate.Caption = "&Remove"
        bbiHorizSpaceConcatenate.Command = ReportCommand.HorizSpaceConcatenate
        bbiHorizSpaceConcatenate.Enabled = False
        bbiHorizSpaceConcatenate.Hint = "Remove the spacing between the selected controls"
        bbiHorizSpaceConcatenate.Id = 25
        bbiHorizSpaceConcatenate.Name = "bbiHorizSpaceConcatenate"
        ' 
        ' msiVerticalSpacing
        ' 
        msiVerticalSpacing.Caption = "&Vertical Spacing"
        msiVerticalSpacing.Id = 57
        msiVerticalSpacing.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceMakeEqual, True), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceIncrease), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceDecrease), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceConcatenate)})
        msiVerticalSpacing.Name = "msiVerticalSpacing"
        ' 
        ' bbiVertSpaceMakeEqual
        ' 
        bbiVertSpaceMakeEqual.Caption = "Make &Equal"
        bbiVertSpaceMakeEqual.Command = ReportCommand.VertSpaceMakeEqual
        bbiVertSpaceMakeEqual.Enabled = False
        bbiVertSpaceMakeEqual.Hint = "Make the spacing between the selected controls equal"
        bbiVertSpaceMakeEqual.Id = 26
        bbiVertSpaceMakeEqual.Name = "bbiVertSpaceMakeEqual"
        ' 
        ' bbiVertSpaceIncrease
        ' 
        bbiVertSpaceIncrease.Caption = "&Increase"
        bbiVertSpaceIncrease.Command = ReportCommand.VertSpaceIncrease
        bbiVertSpaceIncrease.Enabled = False
        bbiVertSpaceIncrease.Hint = "Increase the spacing between the selected controls"
        bbiVertSpaceIncrease.Id = 27
        bbiVertSpaceIncrease.Name = "bbiVertSpaceIncrease"
        ' 
        ' bbiVertSpaceDecrease
        ' 
        bbiVertSpaceDecrease.Caption = "&Decrease"
        bbiVertSpaceDecrease.Command = ReportCommand.VertSpaceDecrease
        bbiVertSpaceDecrease.Enabled = False
        bbiVertSpaceDecrease.Hint = "Decrease the spacing between the selected controls"
        bbiVertSpaceDecrease.Id = 28
        bbiVertSpaceDecrease.Name = "bbiVertSpaceDecrease"
        ' 
        ' bbiVertSpaceConcatenate
        ' 
        bbiVertSpaceConcatenate.Caption = "&Remove"
        bbiVertSpaceConcatenate.Command = ReportCommand.VertSpaceConcatenate
        bbiVertSpaceConcatenate.Enabled = False
        bbiVertSpaceConcatenate.Hint = "Remove the spacing between the selected controls"
        bbiVertSpaceConcatenate.Id = 29
        bbiVertSpaceConcatenate.Name = "bbiVertSpaceConcatenate"
        ' 
        ' bsiCenter
        ' 
        bsiCenter.Caption = "&Center in Form"
        bsiCenter.Id = 58
        bsiCenter.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiCenterHorizontally, True), New DevExpress.XtraBars.LinkPersistInfo(bbiCenterVertically)})
        bsiCenter.Name = "bsiCenter"
        ' 
        ' bbiCenterHorizontally
        ' 
        bbiCenterHorizontally.Caption = "&Horizontally"
        bbiCenterHorizontally.Command = ReportCommand.CenterHorizontally
        bbiCenterHorizontally.Enabled = False
        bbiCenterHorizontally.Hint = "Horizontally center the selected controls within a band"
        bbiCenterHorizontally.Id = 30
        bbiCenterHorizontally.Name = "bbiCenterHorizontally"
        ' 
        ' bbiCenterVertically
        ' 
        bbiCenterVertically.Caption = "&Vertically"
        bbiCenterVertically.Command = ReportCommand.CenterVertically
        bbiCenterVertically.Enabled = False
        bbiCenterVertically.Hint = "Vertically center the selected controls within a band"
        bbiCenterVertically.Id = 31
        bbiCenterVertically.Name = "bbiCenterVertically"
        ' 
        ' msiOrder
        ' 
        msiOrder.Caption = "&Order"
        msiOrder.Id = 59
        msiOrder.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiBringToFront, True), New DevExpress.XtraBars.LinkPersistInfo(bbiSendToBack)})
        msiOrder.Name = "msiOrder"
        ' 
        ' bbiBringToFront
        ' 
        bbiBringToFront.Caption = "&Bring to Front"
        bbiBringToFront.Command = ReportCommand.BringToFront
        bbiBringToFront.Enabled = False
        bbiBringToFront.Hint = "Bring the selected controls to the front"
        bbiBringToFront.Id = 32
        bbiBringToFront.Name = "bbiBringToFront"
        ' 
        ' bbiSendToBack
        ' 
        bbiSendToBack.Caption = "&Send to Back"
        bbiSendToBack.Command = ReportCommand.SendToBack
        bbiSendToBack.Enabled = False
        bbiSendToBack.Hint = "Move the selected controls to the back"
        bbiSendToBack.Id = 33
        bbiSendToBack.Name = "bbiSendToBack"
        ' 
        ' msiWindow
        ' 
        msiWindow.Caption = "&Window"
        msiWindow.Id = 66
        msiWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(msiWindowInterface, True), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem8), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem9), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem10), New DevExpress.XtraBars.LinkPersistInfo(msiWindows, True)})
        msiWindow.Name = "msiWindow"
        ' 
        ' msiWindowInterface
        ' 
        msiWindowInterface.BindableChecked = True
        msiWindowInterface.Caption = "&Tabbed Interface"
        msiWindowInterface.Checked = True
        msiWindowInterface.CheckedCommand = ReportCommand.ShowTabbedInterface
        msiWindowInterface.Enabled = False
        msiWindowInterface.Hint = "Switch between tabbed and window MDI layout modes"
        msiWindowInterface.Id = 67
        msiWindowInterface.Name = "msiWindowInterface"
        msiWindowInterface.UncheckedCommand = ReportCommand.ShowWindowInterface
        ' 
        ' CommandBarItem8
        ' 
        CommandBarItem8.Caption = "&Cascade"
        CommandBarItem8.Command = ReportCommand.MdiCascade
        CommandBarItem8.Enabled = False
        CommandBarItem8.Hint = "Arrange all open documents cascaded, so that they overlap each other"
        CommandBarItem8.Id = 68
        CommandBarItem8.Name = "CommandBarItem8"
        ' 
        ' CommandBarItem9
        ' 
        CommandBarItem9.Caption = "Tile &Horizontal"
        CommandBarItem9.Command = ReportCommand.MdiTileHorizontal
        CommandBarItem9.Enabled = False
        CommandBarItem9.Hint = "Arrange all open documents from top to bottom"
        CommandBarItem9.Id = 69
        CommandBarItem9.Name = "CommandBarItem9"
        ' 
        ' CommandBarItem10
        ' 
        CommandBarItem10.Caption = "Tile &Vertical"
        CommandBarItem10.Command = ReportCommand.MdiTileVertical
        CommandBarItem10.Enabled = False
        CommandBarItem10.Hint = "Arrange all open documents from left to right"
        CommandBarItem10.Id = 70
        CommandBarItem10.Name = "CommandBarItem10"
        ' 
        ' msiWindows
        ' 
        msiWindows.Caption = "Windows"
        msiWindows.Id = 71
        msiWindows.Name = "msiWindows"
        ' 
        ' DesignBar2
        ' 
        DesignBar2.BarName = "Toolbar"
        DesignBar2.DockCol = 0
        DesignBar2.DockRow = 1
        DesignBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        DesignBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem1), New DevExpress.XtraBars.LinkPersistInfo(bbiOpenFile), New DevExpress.XtraBars.LinkPersistInfo(bbiSaveFile), New DevExpress.XtraBars.LinkPersistInfo(CommandBarItem7), New DevExpress.XtraBars.LinkPersistInfo(bbiCut, True), New DevExpress.XtraBars.LinkPersistInfo(bbiCopy), New DevExpress.XtraBars.LinkPersistInfo(bbiPaste), New DevExpress.XtraBars.LinkPersistInfo(bbiUndo, True), New DevExpress.XtraBars.LinkPersistInfo(bbiRedo)})
        DesignBar2.Text = "Toolbar"
        ' 
        ' DesignBar3
        ' 
        DesignBar3.BarName = "Formatting Toolbar"
        DesignBar3.DockCol = 1
        DesignBar3.DockRow = 1
        DesignBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        DesignBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(beiFontName), New DevExpress.XtraBars.LinkPersistInfo(beiFontSize), New DevExpress.XtraBars.LinkPersistInfo(bbiFontBold), New DevExpress.XtraBars.LinkPersistInfo(bbiFontItalic), New DevExpress.XtraBars.LinkPersistInfo(bbiFontUnderline), New DevExpress.XtraBars.LinkPersistInfo(bbiForeColor, True), New DevExpress.XtraBars.LinkPersistInfo(bbiBackColor), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyLeft, True), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyCenter), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyRight), New DevExpress.XtraBars.LinkPersistInfo(bbiJustifyJustify)})
        DesignBar3.Text = "Formatting Toolbar"
        ' 
        ' beiFontName
        ' 
        beiFontName.Caption = "Font Name"
        beiFontName.Edit = RecentlyUsedItemsComboBox1
        beiFontName.EditWidth = 120
        beiFontName.Hint = "Font Name"
        beiFontName.Id = 0
        beiFontName.Name = "beiFontName"
        ' 
        ' RecentlyUsedItemsComboBox1
        ' 
        RecentlyUsedItemsComboBox1.AppearanceDropDown.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RecentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = True
        RecentlyUsedItemsComboBox1.AutoHeight = False
        RecentlyUsedItemsComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        RecentlyUsedItemsComboBox1.Name = "RecentlyUsedItemsComboBox1"
        ' 
        ' beiFontSize
        ' 
        beiFontSize.Caption = "Font Size"
        beiFontSize.Edit = DesignRepositoryItemComboBox1
        beiFontSize.EditWidth = 55
        beiFontSize.Hint = "Font Size"
        beiFontSize.Id = 1
        beiFontSize.Name = "beiFontSize"
        ' 
        ' DesignRepositoryItemComboBox1
        ' 
        DesignRepositoryItemComboBox1.AutoHeight = False
        DesignRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        DesignRepositoryItemComboBox1.Name = "DesignRepositoryItemComboBox1"
        ' 
        ' DesignBar4
        ' 
        DesignBar4.BarName = "Layout Toolbar"
        DesignBar4.DockCol = 0
        DesignBar4.DockRow = 2
        DesignBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        DesignBar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiAlignToGrid), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignLeft, True), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignVerticalCenters), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignRight), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignTop, True), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignHorizontalCenters), New DevExpress.XtraBars.LinkPersistInfo(bbiAlignBottom), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControlWidth, True), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToGrid), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControlHeight), New DevExpress.XtraBars.LinkPersistInfo(bbiSizeToControl), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceMakeEqual, True), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceIncrease), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceDecrease), New DevExpress.XtraBars.LinkPersistInfo(bbiHorizSpaceConcatenate), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceMakeEqual, True), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceIncrease), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceDecrease), New DevExpress.XtraBars.LinkPersistInfo(bbiVertSpaceConcatenate), New DevExpress.XtraBars.LinkPersistInfo(bbiCenterHorizontally, True), New DevExpress.XtraBars.LinkPersistInfo(bbiCenterVertically), New DevExpress.XtraBars.LinkPersistInfo(bbiBringToFront, True), New DevExpress.XtraBars.LinkPersistInfo(bbiSendToBack)})
        DesignBar4.Text = "Layout Toolbar"
        ' 
        ' DesignBar5
        ' 
        DesignBar5.BarName = "Status Bar"
        DesignBar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        DesignBar5.DockCol = 0
        DesignBar5.DockRow = 0
        DesignBar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        DesignBar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bsiHint)})
        DesignBar5.OptionsBar.AllowQuickCustomization = False
        DesignBar5.OptionsBar.DrawDragBorder = False
        DesignBar5.OptionsBar.UseWholeRow = True
        DesignBar5.Text = "Status Bar"
        ' 
        ' bsiHint
        ' 
        bsiHint.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        bsiHint.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        bsiHint.Id = 42
        bsiHint.Name = "bsiHint"
        ' 
        ' Bar1
        ' 
        Bar1.BarName = "Zoom Toolbar"
        Bar1.DockCol = 1
        Bar1.DockRow = 2
        Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(bbiZoomOut), New DevExpress.XtraBars.LinkPersistInfo(bbiZoom), New DevExpress.XtraBars.LinkPersistInfo(bbiZoomIn)})
        Bar1.Text = "Zoom Toolbar"
        ' 
        ' bbiZoomOut
        ' 
        bbiZoomOut.Caption = "Zoom Out"
        bbiZoomOut.Command = ReportCommand.ZoomOut
        bbiZoomOut.Enabled = False
        bbiZoomOut.Hint = "Zoom out the design surface"
        bbiZoomOut.Id = 73
        bbiZoomOut.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.W)
        bbiZoomOut.Name = "bbiZoomOut"
        ' 
        ' bbiZoom
        ' 
        bbiZoom.Caption = "Zoom"
        bbiZoom.Edit = DesignRepositoryItemComboBox2
        bbiZoom.EditWidth = 70
        bbiZoom.Enabled = False
        bbiZoom.Hint = "Select or input the zoom factor"
        bbiZoom.Id = 74
        bbiZoom.Name = "bbiZoom"
        ' 
        ' DesignRepositoryItemComboBox2
        ' 
        DesignRepositoryItemComboBox2.AutoComplete = False
        DesignRepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        DesignRepositoryItemComboBox2.Name = "DesignRepositoryItemComboBox2"
        ' 
        ' bbiZoomIn
        ' 
        bbiZoomIn.Caption = "Zoom In"
        bbiZoomIn.Command = ReportCommand.ZoomIn
        bbiZoomIn.Enabled = False
        bbiZoomIn.Hint = "Zoom in the design surface"
        bbiZoomIn.Id = 75
        bbiZoomIn.ItemShortcut = New DevExpress.XtraBars.BarShortcut(Keys.Control Or Keys.W)
        bbiZoomIn.Name = "bbiZoomIn"
        ' 
        ' barDockControlTop
        ' 
        barDockControlTop.CausesValidation = False
        barDockControlTop.Dock = DockStyle.Top
        barDockControlTop.Location = New Point(0, 0)
        barDockControlTop.Manager = XrDesignBarManager1
        barDockControlTop.Margin = New Padding(5, 5, 5, 5)
        barDockControlTop.Size = New Size(1622, 88)
        ' 
        ' barDockControlBottom
        ' 
        barDockControlBottom.CausesValidation = False
        barDockControlBottom.Dock = DockStyle.Bottom
        barDockControlBottom.Location = New Point(0, 1028)
        barDockControlBottom.Manager = XrDesignBarManager1
        barDockControlBottom.Margin = New Padding(5, 5, 5, 5)
        barDockControlBottom.Size = New Size(1622, 27)
        ' 
        ' barDockControlLeft
        ' 
        barDockControlLeft.CausesValidation = False
        barDockControlLeft.Dock = DockStyle.Left
        barDockControlLeft.Location = New Point(0, 88)
        barDockControlLeft.Manager = XrDesignBarManager1
        barDockControlLeft.Margin = New Padding(5, 5, 5, 5)
        barDockControlLeft.Size = New Size(21, 940)
        ' 
        ' barDockControlRight
        ' 
        barDockControlRight.CausesValidation = False
        barDockControlRight.Dock = DockStyle.Right
        barDockControlRight.Location = New Point(1622, 88)
        barDockControlRight.Manager = XrDesignBarManager1
        barDockControlRight.Margin = New Padding(5, 5, 5, 5)
        barDockControlRight.Size = New Size(0, 940)
        ' 
        ' XrDesignDockManager1
        ' 
        XrDesignDockManager1.Form = Me
        XrDesignDockManager1.ImageStream = CType(resources.GetObject("XrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        XrDesignDockManager1.MenuManager = XrDesignBarManager1
        XrDesignDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {panelContainer1, panelContainer4})
        XrDesignDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraReports.UserDesigner.XRToolBoxPanel"})
        ' 
        ' panelContainer1
        ' 
        panelContainer1.Controls.Add(panelContainer2)
        panelContainer1.Controls.Add(panelContainer3)
        panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        panelContainer1.ID = New Guid("1301df89-5888-4346-bfc6-a64bd2e360fe")
        panelContainer1.Location = New Point(1193, 88)
        panelContainer1.Margin = New Padding(5, 5, 5, 5)
        panelContainer1.Name = "panelContainer1"
        panelContainer1.OriginalSize = New Size(375, 200)
        panelContainer1.Size = New Size(429, 940)
        panelContainer1.Text = "panelContainer1"
        ' 
        ' panelContainer2
        ' 
        panelContainer2.ActiveChild = ReportExplorerDockPanel1
        panelContainer2.Controls.Add(ReportExplorerDockPanel1)
        panelContainer2.Controls.Add(FieldListDockPanel1)
        panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        panelContainer2.ID = New Guid("3e04ceb2-4606-46d1-91a7-455a2ece56a3")
        panelContainer2.Location = New Point(0, 0)
        panelContainer2.Margin = New Padding(5, 5, 5, 5)
        panelContainer2.Name = "panelContainer2"
        panelContainer2.OriginalSize = New Size(438, 376)
        panelContainer2.Size = New Size(429, 471)
        panelContainer2.Tabbed = True
        panelContainer2.Text = "panelContainer2"
        ' 
        ' ReportExplorerDockPanel1
        ' 
        ReportExplorerDockPanel1.Controls.Add(ReportExplorerDockPanel1_Container)
        ReportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        ReportExplorerDockPanel1.ID = New Guid("fb3ec6cc-3b9b-4b9c-91cf-cff78c1edbf1")
        ReportExplorerDockPanel1.Location = New Point(1, 28)
        ReportExplorerDockPanel1.Margin = New Padding(5, 5, 5, 5)
        ReportExplorerDockPanel1.Name = "ReportExplorerDockPanel1"
        ReportExplorerDockPanel1.OriginalSize = New Size(437, 316)
        ReportExplorerDockPanel1.Size = New Size(428, 411)
        ReportExplorerDockPanel1.Text = "Report Explorer"
        ' 
        ' ReportExplorerDockPanel1_Container
        ' 
        ReportExplorerDockPanel1_Container.Location = New Point(0, 0)
        ReportExplorerDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        ReportExplorerDockPanel1_Container.Name = "ReportExplorerDockPanel1_Container"
        ReportExplorerDockPanel1_Container.Size = New Size(428, 411)
        ReportExplorerDockPanel1_Container.TabIndex = 0
        ' 
        ' FieldListDockPanel1
        ' 
        FieldListDockPanel1.Controls.Add(FieldListDockPanel1_Container)
        FieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        FieldListDockPanel1.ID = New Guid("faf69838-a93f-4114-83e8-d0d09cc5ce95")
        FieldListDockPanel1.Location = New Point(1, 28)
        FieldListDockPanel1.Margin = New Padding(5, 5, 5, 5)
        FieldListDockPanel1.Name = "FieldListDockPanel1"
        FieldListDockPanel1.OriginalSize = New Size(437, 316)
        FieldListDockPanel1.Size = New Size(428, 411)
        FieldListDockPanel1.Text = "Field List"
        ' 
        ' FieldListDockPanel1_Container
        ' 
        FieldListDockPanel1_Container.Location = New Point(0, 0)
        FieldListDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        FieldListDockPanel1_Container.Name = "FieldListDockPanel1_Container"
        FieldListDockPanel1_Container.Size = New Size(428, 411)
        FieldListDockPanel1_Container.TabIndex = 0
        ' 
        ' panelContainer3
        ' 
        panelContainer3.ActiveChild = PropertyGridDockPanel1
        panelContainer3.Controls.Add(PropertyGridDockPanel1)
        panelContainer3.Controls.Add(ReportGalleryDockPanel1)
        panelContainer3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        panelContainer3.ID = New Guid("b852cfae-9bac-4f1b-991c-998df767bbc8")
        panelContainer3.Location = New Point(0, 471)
        panelContainer3.Margin = New Padding(5, 5, 5, 5)
        panelContainer3.Name = "panelContainer3"
        panelContainer3.OriginalSize = New Size(438, 375)
        panelContainer3.Size = New Size(429, 469)
        panelContainer3.Tabbed = True
        panelContainer3.Text = "panelContainer3"
        ' 
        ' PropertyGridDockPanel1
        ' 
        PropertyGridDockPanel1.Controls.Add(PropertyGridDockPanel1_Container)
        PropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        PropertyGridDockPanel1.ID = New Guid("b38d12c3-cd06-4dec-b93d-63a0088e495a")
        PropertyGridDockPanel1.Location = New Point(1, 29)
        PropertyGridDockPanel1.Margin = New Padding(5, 5, 5, 5)
        PropertyGridDockPanel1.Name = "PropertyGridDockPanel1"
        PropertyGridDockPanel1.OriginalSize = New Size(437, 314)
        PropertyGridDockPanel1.Size = New Size(428, 408)
        PropertyGridDockPanel1.Text = "Properties"
        ' 
        ' PropertyGridDockPanel1_Container
        ' 
        PropertyGridDockPanel1_Container.Location = New Point(0, 0)
        PropertyGridDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        PropertyGridDockPanel1_Container.Name = "PropertyGridDockPanel1_Container"
        PropertyGridDockPanel1_Container.Size = New Size(428, 408)
        PropertyGridDockPanel1_Container.TabIndex = 0
        ' 
        ' ReportGalleryDockPanel1
        ' 
        ReportGalleryDockPanel1.Controls.Add(ReportGalleryDockPanel1_Container)
        ReportGalleryDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        ReportGalleryDockPanel1.ID = New Guid("7cd5b1e8-63bb-46f7-af65-af61eb851a38")
        ReportGalleryDockPanel1.Location = New Point(1, 29)
        ReportGalleryDockPanel1.Margin = New Padding(5, 5, 5, 5)
        ReportGalleryDockPanel1.Name = "ReportGalleryDockPanel1"
        ReportGalleryDockPanel1.OriginalSize = New Size(437, 314)
        ReportGalleryDockPanel1.Size = New Size(428, 408)
        ReportGalleryDockPanel1.Text = "Report Gallery"
        ' 
        ' ReportGalleryDockPanel1_Container
        ' 
        ReportGalleryDockPanel1_Container.Location = New Point(0, 0)
        ReportGalleryDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        ReportGalleryDockPanel1_Container.Name = "ReportGalleryDockPanel1_Container"
        ReportGalleryDockPanel1_Container.Size = New Size(428, 408)
        ReportGalleryDockPanel1_Container.TabIndex = 0
        ' 
        ' panelContainer4
        ' 
        panelContainer4.ActiveChild = GroupAndSortDockPanel1
        panelContainer4.Controls.Add(GroupAndSortDockPanel1)
        panelContainer4.Controls.Add(ErrorListDockPanel1)
        panelContainer4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        panelContainer4.ID = New Guid("a27f419a-3c89-4764-969a-c95f4762e24a")
        panelContainer4.Location = New Point(21, 778)
        panelContainer4.Margin = New Padding(5, 5, 5, 5)
        panelContainer4.Name = "panelContainer4"
        panelContainer4.OriginalSize = New Size(200, 200)
        panelContainer4.Size = New Size(1172, 250)
        panelContainer4.Tabbed = True
        panelContainer4.Text = "panelContainer4"
        ' 
        ' GroupAndSortDockPanel1
        ' 
        GroupAndSortDockPanel1.Controls.Add(GroupAndSortDockPanel1_Container)
        GroupAndSortDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        GroupAndSortDockPanel1.ID = New Guid("4bab159e-c495-4d67-87dc-f4e895da443e")
        GroupAndSortDockPanel1.Location = New Point(0, 29)
        GroupAndSortDockPanel1.Margin = New Padding(5, 5, 5, 5)
        GroupAndSortDockPanel1.Name = "GroupAndSortDockPanel1"
        GroupAndSortDockPanel1.OriginalSize = New Size(960, 185)
        GroupAndSortDockPanel1.Size = New Size(1172, 189)
        GroupAndSortDockPanel1.Text = "Group and Sort"
        ' 
        ' GroupAndSortDockPanel1_Container
        ' 
        GroupAndSortDockPanel1_Container.Location = New Point(0, 0)
        GroupAndSortDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        GroupAndSortDockPanel1_Container.Name = "GroupAndSortDockPanel1_Container"
        GroupAndSortDockPanel1_Container.Size = New Size(1172, 189)
        GroupAndSortDockPanel1_Container.TabIndex = 0
        ' 
        ' ErrorListDockPanel1
        ' 
        ErrorListDockPanel1.Controls.Add(ErrorListDockPanel1_Container)
        ErrorListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        ErrorListDockPanel1.ID = New Guid("5a9a01fd-6e95-4e81-a8c4-ac63153d7488")
        ErrorListDockPanel1.Location = New Point(0, 29)
        ErrorListDockPanel1.Margin = New Padding(5, 5, 5, 5)
        ErrorListDockPanel1.Name = "ErrorListDockPanel1"
        ErrorListDockPanel1.OriginalSize = New Size(960, 185)
        ErrorListDockPanel1.Size = New Size(1172, 189)
        ErrorListDockPanel1.Text = "Report Design Analyzer"
        ' 
        ' ErrorListDockPanel1_Container
        ' 
        ErrorListDockPanel1_Container.Location = New Point(0, 0)
        ErrorListDockPanel1_Container.Margin = New Padding(5, 5, 5, 5)
        ErrorListDockPanel1_Container.Name = "ErrorListDockPanel1_Container"
        ErrorListDockPanel1_Container.Size = New Size(1172, 189)
        ErrorListDockPanel1_Container.TabIndex = 0
        ' 
        ' ReportDesigner1
        ' 
        ReportDesigner1.ContainerControl = Nothing
        XrDesignPanelListener1.DesignControl = XrDesignBarManager1
        XrDesignPanelListener2.DesignControl = XrDesignDockManager1
        XrDesignPanelListener3.DesignControl = FieldListDockPanel1
        XrDesignPanelListener4.DesignControl = PropertyGridDockPanel1
        XrDesignPanelListener5.DesignControl = ReportExplorerDockPanel1
        XrDesignPanelListener6.DesignControl = ReportGalleryDockPanel1
        XrDesignPanelListener7.DesignControl = GroupAndSortDockPanel1
        XrDesignPanelListener8.DesignControl = ErrorListDockPanel1
        ReportDesigner1.DesignPanelListeners.AddRange(New XRDesignPanelListener() {XrDesignPanelListener1, XrDesignPanelListener2, XrDesignPanelListener3, XrDesignPanelListener4, XrDesignPanelListener5, XrDesignPanelListener6, XrDesignPanelListener7, XrDesignPanelListener8})
        ReportDesigner1.Form = Me
        ' 
        ' frm_ReportDesign
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1622, 1055)
        Controls.Add(panelContainer1)
        Controls.Add(panelContainer4)
        Controls.Add(barDockControlLeft)
        Controls.Add(barDockControlRight)
        Controls.Add(barDockControlBottom)
        Controls.Add(barDockControlTop)
        Margin = New Padding(5, 5, 5, 5)
        Name = "frm_ReportDesign"
        Text = "frm_ReportDesign"
        WindowState = FormWindowState.Maximized
        CType(XrDesignBarManager1, ComponentModel.ISupportInitialize).EndInit()
        CType(RecentlyUsedItemsComboBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DesignRepositoryItemComboBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DesignRepositoryItemComboBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(XrDesignDockManager1, ComponentModel.ISupportInitialize).EndInit()
        panelContainer1.ResumeLayout(False)
        panelContainer2.ResumeLayout(False)
        ReportExplorerDockPanel1.ResumeLayout(False)
        FieldListDockPanel1.ResumeLayout(False)
        panelContainer3.ResumeLayout(False)
        PropertyGridDockPanel1.ResumeLayout(False)
        ReportGalleryDockPanel1.ResumeLayout(False)
        panelContainer4.ResumeLayout(False)
        GroupAndSortDockPanel1.ResumeLayout(False)
        ErrorListDockPanel1.ResumeLayout(False)
        CType(ReportDesigner1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents XrDesignBarManager1 As XRDesignBarManager
    Friend WithEvents BarDockPanelsListItem1 As BarDockPanelsListItem
    Friend WithEvents BarInfo As BarInfo
    Friend WithEvents BarReportTabButtonsListItem1 As BarReportTabButtonsListItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents CommandBarItem1 As CommandBarItem
    Friend WithEvents CommandBarItem10 As CommandBarItem
    Friend WithEvents CommandBarItem11 As CommandBarItem
    Friend WithEvents CommandBarItem2 As CommandBarItem
    Friend WithEvents CommandBarItem3 As CommandBarItem
    Friend WithEvents CommandBarItem4 As CommandBarItem
    Friend WithEvents CommandBarItem5 As CommandBarItem
    Friend WithEvents CommandBarItem6 As CommandBarItem
    Friend WithEvents CommandBarItem7 As CommandBarItem
    Friend WithEvents CommandBarItem8 As CommandBarItem
    Friend WithEvents CommandBarItem9 As CommandBarItem
    Friend WithEvents DesignBar1 As DesignBar
    Friend WithEvents DesignBar2 As DesignBar
    Friend WithEvents DesignBar3 As DesignBar
    Friend WithEvents DesignBar4 As DesignBar
    Friend WithEvents DesignBar5 As DesignBar
    Friend WithEvents DesignRepositoryItemComboBox1 As DesignRepositoryItemComboBox
    Friend WithEvents DesignRepositoryItemComboBox2 As DesignRepositoryItemComboBox
    Friend WithEvents ErrorListDockPanel1 As ErrorListDockPanel
    Friend WithEvents ErrorListDockPanel1_Container As DesignControlContainer
    Friend WithEvents ReportDesigner1 As XRDesignMdiController
    Friend WithEvents FieldListDockPanel1 As FieldListDockPanel
    Friend WithEvents FieldListDockPanel1_Container As DesignControlContainer
    Friend WithEvents GroupAndSortDockPanel1 As GroupAndSortDockPanel
    Friend WithEvents GroupAndSortDockPanel1_Container As DesignControlContainer
    Friend WithEvents PropertyGridDockPanel1 As PropertyGridDockPanel
    Friend WithEvents PropertyGridDockPanel1_Container As DesignControlContainer
    Friend WithEvents RecentlyUsedItemsComboBox1 As RecentlyUsedItemsComboBox
    Friend WithEvents ReportExplorerDockPanel1 As ReportExplorerDockPanel
    Friend WithEvents ReportExplorerDockPanel1_Container As DesignControlContainer
    Friend WithEvents ReportGalleryDockPanel1 As ReportGalleryDockPanel
    Friend WithEvents ReportGalleryDockPanel1_Container As DesignControlContainer
    Friend WithEvents XRDesignPanelListener As XRDesignPanelListener
    Friend WithEvents XrBarToolbarsListItem1 As XRBarToolbarsListItem
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents XrDesignDockManager1 As XRDesignDockManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbiAlignBottom As CommandBarItem
    Friend WithEvents bbiAlignHorizontalCenters As CommandBarItem
    Friend WithEvents bbiAlignLeft As CommandBarItem
    Friend WithEvents bbiAlignRight As CommandBarItem
    Friend WithEvents bbiAlignToGrid As CommandBarItem
    Friend WithEvents bbiAlignTop As CommandBarItem
    Friend WithEvents bbiAlignVerticalCenters As CommandBarItem
    Friend WithEvents bbiBackColor As CommandColorBarItem
    Friend WithEvents bbiBringToFront As CommandBarItem
    Friend WithEvents bbiCenterHorizontally As CommandBarItem
    Friend WithEvents bbiCenterVertically As CommandBarItem
    Friend WithEvents bbiCopy As CommandBarItem
    Friend WithEvents bbiCut As CommandBarItem
    Friend WithEvents bbiFontBold As CommandBarItem
    Friend WithEvents bbiFontItalic As CommandBarItem
    Friend WithEvents bbiFontUnderline As CommandBarItem
    Friend WithEvents bbiForeColor As CommandColorBarItem
    Friend WithEvents bbiHorizSpaceConcatenate As CommandBarItem
    Friend WithEvents bbiHorizSpaceDecrease As CommandBarItem
    Friend WithEvents bbiHorizSpaceIncrease As CommandBarItem
    Friend WithEvents bbiHorizSpaceMakeEqual As CommandBarItem
    Friend WithEvents bbiJustifyCenter As CommandBarItem
    Friend WithEvents bbiJustifyJustify As CommandBarItem
    Friend WithEvents bbiJustifyLeft As CommandBarItem
    Friend WithEvents bbiJustifyRight As CommandBarItem
    Friend WithEvents bbiOpenFile As CommandBarItem
    Friend WithEvents bbiPaste As CommandBarItem
    Friend WithEvents bbiRedo As CommandBarItem
    Friend WithEvents bbiSaveFile As CommandBarItem
    Friend WithEvents bbiSendToBack As CommandBarItem
    Friend WithEvents bbiSizeToControl As CommandBarItem
    Friend WithEvents bbiSizeToControlHeight As CommandBarItem
    Friend WithEvents bbiSizeToControlWidth As CommandBarItem
    Friend WithEvents bbiSizeToGrid As CommandBarItem
    Friend WithEvents bbiUndo As CommandBarItem
    Friend WithEvents bbiVertSpaceConcatenate As CommandBarItem
    Friend WithEvents bbiVertSpaceDecrease As CommandBarItem
    Friend WithEvents bbiVertSpaceIncrease As CommandBarItem
    Friend WithEvents bbiVertSpaceMakeEqual As CommandBarItem
    Friend WithEvents bbiZoomIn As CommandBarItem
    Friend WithEvents bbiZoomOut As CommandBarItem
    Friend WithEvents bbiZoom As XRZoomBarEditItem
    Friend WithEvents beiFontName As DevExpress.XtraBars.BarEditItem
    Friend WithEvents beiFontSize As DevExpress.XtraBars.BarEditItem
    Friend WithEvents bsiCenter As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bsiHint As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents msiAlign As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiEdit As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiFile As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiFont As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiFormat As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiHorizontalSpacing As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiJustify As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiOrder As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiSameSize As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiTabButtons As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiVerticalSpacing As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiWindow As DevExpress.XtraBars.BarSubItem
    Friend WithEvents msiWindowInterface As CommandBarCheckItem
    Friend WithEvents msiWindows As DevExpress.XtraBars.BarMdiChildrenListItem
    Friend WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents panelContainer2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents panelContainer3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents panelContainer4 As DevExpress.XtraBars.Docking.DockPanel
End Class
