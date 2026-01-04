Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmGifts
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbClientSrch As ComboBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblClientSrch As Label
    Friend WithEvents lblTaxNo As Label
    Friend WithEvents lblivalue As Label
    Friend WithEvents lblname As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtCustDisc As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtGift As TextBox
    Friend WithEvents txtNationalID As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtValue As TextBox

    <Global.System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
            If flag Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGifts))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtCustDisc = New TextBox()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnFirst = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnPrint = New ToolStripButton()
        btnClose = New ToolStripButton()
        Label13 = New Label()
        txtValue = New TextBox()
        lblivalue = New Label()
        txtNotes = New TextBox()
        Label5 = New Label()
        txtGift = New TextBox()
        lblTaxNo = New Label()
        btnSearch = New Button()
        GroupBox6 = New GroupBox()
        chkAll = New CheckBox()
        lblClientSrch = New Label()
        cmbClientSrch = New ComboBox()
        txtToDate = New DateTimePicker()
        Label1 = New Label()
        txtFromDate = New DateTimePicker()
        Label4 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        cmbClients = New ComboBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        txtDate = New DateTimePicker()
        Label3 = New Label()
        txtNationalID = New TextBox()
        Label2 = New Label()
        lblname = New Label()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvData = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        panel2 = New Panel()
        toolStrip1.SuspendLayout()
        GroupBox6.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCustDisc
        ' 
        txtCustDisc.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCustDisc.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtCustDisc.Location = New Point(-21, 68)
        txtCustDisc.Name = "txtCustDisc"
        txtCustDisc.ReadOnly = True
        txtCustDisc.Size = New Size(100, 24)
        txtCustDisc.TabIndex = 3
        txtCustDisc.TextAlign = HorizontalAlignment.Center
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(146, 18)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(113, 20)
        btnNew.Text = "جديد"
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 20)
        btnSave.Text = "حفظ"
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(113, 20)
        btnDelete.Text = "حذف"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 6)
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnLast.Image = CType(resources.GetObject("btnLast.Image"), Image)
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(113, 20)
        btnLast.Text = "الأخير"
        ' 
        ' btnNext
        ' 
        btnNext.AutoSize = False
        btnNext.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.ImageScaling = ToolStripItemImageScaling.None
        btnNext.ImageTransparentColor = Color.Magenta
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(113, 20)
        btnNext.Text = "التالي"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoSize = False
        btnPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Image)
        btnPrevious.ImageScaling = ToolStripItemImageScaling.None
        btnPrevious.ImageTransparentColor = Color.Magenta
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(113, 20)
        btnPrevious.Text = "السابق"
        ' 
        ' btnFirst
        ' 
        btnFirst.AutoSize = False
        btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnFirst.Image = My.Resources.Resources.Firstt
        btnFirst.ImageScaling = ToolStripItemImageScaling.None
        btnFirst.ImageTransparentColor = Color.Magenta
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(113, 20)
        btnFirst.Text = "الأول"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(113, 20)
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(113, 20)
        btnPrint.Text = "طباعة"
        btnPrint.Visible = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(113, 20)
        btnClose.Text = "خروج"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.ImeMode = ImeMode.NoControl
        Label13.Location = New Point(-66, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(50, 17)
        Label13.TabIndex = 23
        Label13.Text = "الرصيد"
        ' 
        ' txtValue
        ' 
        txtValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtValue.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtValue.Location = New Point(-21, 68)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(100, 24)
        txtValue.TabIndex = 3
        txtValue.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblivalue
        ' 
        lblivalue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblivalue.AutoSize = True
        lblivalue.ImeMode = ImeMode.NoControl
        lblivalue.Location = New Point(-21, 68)
        lblivalue.Name = "lblivalue"
        lblivalue.Size = New Size(43, 17)
        lblivalue.TabIndex = 23
        lblivalue.Text = "خصم"
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(-21, 68)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(100, 27)
        txtNotes.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(-66, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 13
        Label5.Text = "ملاحظات"
        ' 
        ' txtGift
        ' 
        txtGift.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGift.Location = New Point(-21, 68)
        txtGift.Name = "txtGift"
        txtGift.Size = New Size(100, 24)
        txtGift.TabIndex = 2
        ' 
        ' lblTaxNo
        ' 
        lblTaxNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTaxNo.AutoSize = True
        lblTaxNo.ImeMode = ImeMode.NoControl
        lblTaxNo.Location = New Point(-21, 68)
        lblTaxNo.Name = "lblTaxNo"
        lblTaxNo.Size = New Size(47, 17)
        lblTaxNo.TabIndex = 13
        lblTaxNo.Text = "الهدية"
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Lime
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.ImeMode = ImeMode.NoControl
        btnSearch.Location = New Point(37, 68)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 1
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.LightBlue
        GroupBox6.Controls.Add(chkAll)
        GroupBox6.Controls.Add(lblClientSrch)
        GroupBox6.Controls.Add(cmbClientSrch)
        GroupBox6.Controls.Add(txtToDate)
        GroupBox6.Controls.Add(Label1)
        GroupBox6.Controls.Add(txtFromDate)
        GroupBox6.Controls.Add(Label4)
        GroupBox6.Controls.Add(btnSearch)
        GroupBox6.Dock = DockStyle.Top
        GroupBox6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox6.Location = New Point(0, 0)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.RightToLeft = RightToLeft.Yes
        GroupBox6.Size = New Size(192, 100)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "بحث"
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Checked = True
        chkAll.CheckState = CheckState.Checked
        chkAll.ImeMode = ImeMode.NoControl
        chkAll.Location = New Point(83, 68)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 151
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' lblClientSrch
        ' 
        lblClientSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblClientSrch.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblClientSrch.ImeMode = ImeMode.NoControl
        lblClientSrch.Location = New Point(37, 68)
        lblClientSrch.Name = "lblClientSrch"
        lblClientSrch.Size = New Size(100, 23)
        lblClientSrch.TabIndex = 150
        lblClientSrch.Text = "العميل"
        lblClientSrch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbClientSrch
        ' 
        cmbClientSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClientSrch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClientSrch.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClientSrch.BackColor = Color.White
        cmbClientSrch.Enabled = False
        cmbClientSrch.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        cmbClientSrch.FormattingEnabled = True
        cmbClientSrch.Location = New Point(37, 68)
        cmbClientSrch.Name = "cmbClientSrch"
        cmbClientSrch.Size = New Size(121, 26)
        cmbClientSrch.TabIndex = 149
        ' 
        ' txtToDate
        ' 
        txtToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtToDate.Format = DateTimePickerFormat.Short
        txtToDate.Location = New Point(37, 68)
        txtToDate.Name = "txtToDate"
        txtToDate.Size = New Size(200, 24)
        txtToDate.TabIndex = 146
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(-8, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 147
        Label1.Text = "الى تاريخ"
        ' 
        ' txtFromDate
        ' 
        txtFromDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFromDate.Format = DateTimePickerFormat.Short
        txtFromDate.Location = New Point(37, 68)
        txtFromDate.Name = "txtFromDate"
        txtFromDate.Size = New Size(200, 24)
        txtFromDate.TabIndex = 145
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(-8, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 148
        Label4.Text = "من تاريخ"
        ' 
        ' cmbClients
        ' 
        cmbClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.FormattingEnabled = True
        cmbClients.Location = New Point(-21, 68)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(121, 24)
        cmbClients.TabIndex = 8
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(148, 0)
        TabControl1.TabIndex = 13
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(140, 0)
        TabPage1.TabIndex = 0
        TabPage1.Text = "            بيانـــات            "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(140, 0)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtDate)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtCustDisc)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(txtValue)
        GroupBox2.Controls.Add(lblivalue)
        GroupBox2.Controls.Add(txtNotes)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtGift)
        GroupBox2.Controls.Add(lblTaxNo)
        GroupBox2.Controls.Add(cmbClients)
        GroupBox2.Controls.Add(txtNationalID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(lblname)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(3, 20)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(134, 0)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' txtDate
        ' 
        txtDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDate.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(-21, 68)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(200, 26)
        txtDate.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(-66, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 17)
        Label3.TabIndex = 24
        Label3.Text = "التاريخ"
        ' 
        ' txtNationalID
        ' 
        txtNationalID.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNationalID.Location = New Point(-21, 68)
        txtNationalID.Name = "txtNationalID"
        txtNationalID.Size = New Size(100, 24)
        txtNationalID.TabIndex = 4
        txtNationalID.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(-66, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 17)
        Label2.TabIndex = 3
        Label2.Text = "الرقم القومي"
        Label2.Visible = False
        ' 
        ' lblname
        ' 
        lblname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblname.AutoSize = True
        lblname.ImeMode = ImeMode.NoControl
        lblname.Location = New Point(-21, 68)
        lblname.Name = "lblname"
        lblname.Size = New Size(50, 17)
        lblname.TabIndex = 0
        lblname.Text = "العميل"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(192, 71)
        TabPage2.TabIndex = 1
        TabPage2.Text = "                    البحــــــــــث              "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightBlue
        GroupBox4.Controls.Add(dgvData)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(0, 100)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(192, 0)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "النتائج"
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.AllowUserToOrderColumns = True
        dgvData.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column7})
        dgvData.Dock = DockStyle.Fill
        dgvData.Location = New Point(3, 20)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(186, 0)
        dgvData.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الرقم"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Visible = False
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "العميل"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "التاريخ"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "القيمة"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 0)
        panel2.Name = "panel2"
        panel2.Size = New Size(148, 20)
        panel2.TabIndex = 12
        ' 
        ' frmGifts
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(148, 20)
        Controls.Add(TabControl1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        Name = "frmGifts"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "منح هدايا لعميل"
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
