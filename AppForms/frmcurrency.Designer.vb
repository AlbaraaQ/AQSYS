Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmcurrency
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewComboBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnClientsImport As Button
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents chkMezan As CheckBox
    Friend WithEvents chkOutOffer As CheckBox
    Friend WithEvents chkPrintLimit As CheckBox
    Friend WithEvents chkTab3 As CheckBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents cmbTaxGroup As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents dataGridViewComboBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents dataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents dgvComponents As DataGridView
    Friend WithEvents dgvCurrencies As DataGridView
    Friend WithEvents dgvFirst As DataGridView
    Friend WithEvents dgvSafeBalance As DataGridView
    Friend WithEvents dgvUnits As DataGridView
    Friend WithEvents lbkbUnit As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents picImage As PictureBox
    Friend WithEvents progressBar1 As ProgressBar
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtFromNo As NumericUpDown
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents txtMinPrice As TextBox
    Friend WithEvents txtNameEN As TextBox
    Friend WithEvents txtNameSrch As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtOperateNo As TextBox
    Friend WithEvents txtPicPath As TextBox
    Friend WithEvents txtPurchDollar As TextBox
    Friend WithEvents txtPurchPrice As TextBox
    Friend WithEvents txtSaleDollar As TextBox
    Friend WithEvents txtSalePrice As TextBox
    Friend WithEvents txtSrchBarcode As TextBox
    Friend WithEvents txtSymbol As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtToNo As NumericUpDown

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcurrency))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        toolStripSeparator1 = New ToolStripSeparator()
        toolStripSeparator2 = New ToolStripSeparator()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnFirst = New ToolStripButton()
        btnPrint = New ToolStripButton()
        btnClose = New ToolStripButton()
        panel2 = New Panel()
        GroupBox1 = New GroupBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        dgvFirst = New DataGridView()
        DataGridViewComboBoxColumn1 = New DataGridViewComboBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        dgvUnits = New DataGridView()
        DataGridViewComboBoxColumn2 = New DataGridViewComboBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewButtonColumn()
        TabPage3 = New TabPage()
        dgvComponents = New DataGridView()
        Column12 = New DataGridViewComboBoxColumn()
        dataGridViewComboBoxColumn3 = New DataGridViewComboBoxColumn()
        dataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        TabPage4 = New TabPage()
        dgvSafeBalance = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewComboBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        dgvCurrencies = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        chkPrintLimit = New CheckBox()
        Label20 = New Label()
        txtFromNo = New NumericUpDown()
        txtToNo = New NumericUpDown()
        Label21 = New Label()
        txtSrchBarcode = New TextBox()
        Label15 = New Label()
        txtNameSrch = New TextBox()
        Label14 = New Label()
        Button3 = New Button()
        GroupBox2 = New GroupBox()
        chkTab3 = New CheckBox()
        progressBar1 = New ProgressBar()
        btnClientsImport = New Button()
        cmbItemType = New ComboBox()
        Label19 = New Label()
        txtMinPrice = New TextBox()
        Label17 = New Label()
        Button4 = New Button()
        picImage = New PictureBox()
        txtPicPath = New TextBox()
        Label16 = New Label()
        btnOpenFile = New Button()
        chkOutOffer = New CheckBox()
        chkMezan = New CheckBox()
        txtDiscount = New TextBox()
        Label12 = New Label()
        txtTax = New TextBox()
        Label11 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        cmbTaxGroup = New ComboBox()
        Label13 = New Label()
        cmbUnit = New ComboBox()
        lbkbUnit = New Label()
        txtLimit = New TextBox()
        Label8 = New Label()
        txtSaleDollar = New TextBox()
        Label9 = New Label()
        txtSalePrice = New TextBox()
        txtPurchDollar = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        txtPurchPrice = New TextBox()
        Label4 = New Label()
        cmbGroups = New ComboBox()
        Label3 = New Label()
        txtBarcode = New TextBox()
        Label2 = New Label()
        txtNo = New TextBox()
        Label1 = New Label()
        txtOperateNo = New TextBox()
        Label22 = New Label()
        txtNameEN = New TextBox()
        Label10 = New Label()
        txtNote = New TextBox()
        Label18 = New Label()
        txtSymbol = New TextBox()
        Label6 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvFirst, System.ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgvSafeBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgvCurrencies, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(txtFromNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(txtToNo, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(1113, 65)
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
        btnNew.Size = New Size(50, 50)
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
        btnSave.Size = New Size(50, 50)
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
        btnDelete.Size = New Size(50, 50)
        btnDelete.Text = "حذف"
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnLast.Image = CType(resources.GetObject("btnLast.Image"), Image)
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(50, 50)
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
        btnNext.Size = New Size(50, 50)
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
        btnPrevious.Size = New Size(50, 50)
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
        btnFirst.Size = New Size(50, 50)
        btnFirst.Text = "الأول"
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(50, 50)
        btnPrint.Text = "طباعة"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.Text = "خروج"
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 716)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(1115, 67)
        panel2.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(TabControl1)
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1115, 783)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(7, 334)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1085, 127)
        TabControl1.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dgvFirst)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1077, 98)
        TabPage1.TabIndex = 0
        TabPage1.Text = "      مخزون أول المدة      "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgvFirst
        ' 
        dgvFirst.AllowUserToDeleteRows = False
        dgvFirst.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvFirst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvFirst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFirst.Columns.AddRange(New DataGridViewColumn() {DataGridViewComboBoxColumn1, DataGridViewTextBoxColumn3, Column7, Column8})
        dgvFirst.Dock = DockStyle.Fill
        dgvFirst.Location = New Point(3, 4)
        dgvFirst.Margin = New Padding(3, 4, 3, 4)
        dgvFirst.MultiSelect = False
        dgvFirst.Name = "dgvFirst"
        dgvFirst.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvFirst.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvFirst.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFirst.Size = New Size(1071, 90)
        dgvFirst.TabIndex = 0
        ' 
        ' DataGridViewComboBoxColumn1
        ' 
        DataGridViewComboBoxColumn1.HeaderText = "المخزن"
        DataGridViewComboBoxColumn1.MinimumWidth = 6
        DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        DataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True
        DataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewComboBoxColumn1.Width = 150
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "الكمية"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.Width = 90
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "اجمالي (ريال)"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 120
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "اجمالي (دولار)"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 120
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvUnits)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1077, 98)
        TabPage2.TabIndex = 1
        TabPage2.Text = "        الوحدات الفرعية        "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvUnits
        ' 
        dgvUnits.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvUnits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUnits.Columns.AddRange(New DataGridViewColumn() {DataGridViewComboBoxColumn2, DataGridViewTextBoxColumn4, Column9, Column10, Column11, Column16})
        dgvUnits.Dock = DockStyle.Fill
        dgvUnits.Location = New Point(3, 4)
        dgvUnits.Margin = New Padding(3, 4, 3, 4)
        dgvUnits.MultiSelect = False
        dgvUnits.Name = "dgvUnits"
        dgvUnits.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvUnits.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUnits.Size = New Size(1071, 90)
        dgvUnits.TabIndex = 0
        ' 
        ' DataGridViewComboBoxColumn2
        ' 
        DataGridViewComboBoxColumn2.HeaderText = "الوحدة"
        DataGridViewComboBoxColumn2.MinimumWidth = 6
        DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        DataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.True
        DataGridViewComboBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewComboBoxColumn2.Width = 70
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "نسبة الوحدة"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 50
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "سعر الشراء"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 50
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "سعر البيع"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 50
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "الباركود"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Width = 130
        ' 
        ' Column16
        ' 
        Column16.HeaderText = ""
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        Column16.Text = "طباعة الباركود"
        Column16.UseColumnTextForButtonValue = True
        Column16.Width = 125
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvComponents)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 4, 3, 4)
        TabPage3.Size = New Size(1077, 98)
        TabPage3.TabIndex = 2
        TabPage3.Text = "      مكونات الصنف       "
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvComponents
        ' 
        dgvComponents.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvComponents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComponents.Columns.AddRange(New DataGridViewColumn() {Column12, dataGridViewComboBoxColumn3, dataGridViewTextBoxColumn5, Column13})
        dgvComponents.Dock = DockStyle.Fill
        dgvComponents.Location = New Point(3, 4)
        dgvComponents.Margin = New Padding(3, 4, 3, 4)
        dgvComponents.MultiSelect = False
        dgvComponents.Name = "dgvComponents"
        dgvComponents.RowHeadersWidth = 51
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComponents.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvComponents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvComponents.Size = New Size(1071, 90)
        dgvComponents.TabIndex = 3
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "المادة الخام"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Resizable = DataGridViewTriState.True
        Column12.SortMode = DataGridViewColumnSortMode.Automatic
        Column12.Width = 200
        ' 
        ' dataGridViewComboBoxColumn3
        ' 
        dataGridViewComboBoxColumn3.HeaderText = "الوحدة"
        dataGridViewComboBoxColumn3.MinimumWidth = 6
        dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3"
        dataGridViewComboBoxColumn3.Resizable = DataGridViewTriState.True
        dataGridViewComboBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic
        dataGridViewComboBoxColumn3.Width = 120
        ' 
        ' dataGridViewTextBoxColumn5
        ' 
        dataGridViewTextBoxColumn5.HeaderText = "الكمية"
        dataGridViewTextBoxColumn5.MinimumWidth = 6
        dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5"
        dataGridViewTextBoxColumn5.Width = 125
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "السعر"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.Visible = False
        Column13.Width = 125
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(dgvSafeBalance)
        TabPage4.Location = New Point(4, 25)
        TabPage4.Margin = New Padding(3, 4, 3, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3, 4, 3, 4)
        TabPage4.Size = New Size(1077, 98)
        TabPage4.TabIndex = 3
        TabPage4.Text = "رصيد الصنف"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' dgvSafeBalance
        ' 
        dgvSafeBalance.AllowUserToAddRows = False
        dgvSafeBalance.AllowUserToDeleteRows = False
        dgvSafeBalance.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvSafeBalance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvSafeBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSafeBalance.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2})
        dgvSafeBalance.Dock = DockStyle.Fill
        dgvSafeBalance.Location = New Point(3, 4)
        dgvSafeBalance.Margin = New Padding(3, 4, 3, 4)
        dgvSafeBalance.MultiSelect = False
        dgvSafeBalance.Name = "dgvSafeBalance"
        dgvSafeBalance.ReadOnly = True
        dgvSafeBalance.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSafeBalance.RowsDefaultCellStyle = DataGridViewCellStyle8
        dgvSafeBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSafeBalance.Size = New Size(1071, 90)
        dgvSafeBalance.TabIndex = 0
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "المخزن"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True
        DataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewTextBoxColumn1.Width = 150
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "الرصيد"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 90
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgvCurrencies)
        GroupBox4.Controls.Add(Panel1)
        GroupBox4.Location = New Point(64, 468)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.Size = New Size(1024, 245)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "بيانات الأصناف"
        ' 
        ' dgvCurrencies
        ' 
        dgvCurrencies.AllowUserToAddRows = False
        dgvCurrencies.AllowUserToDeleteRows = False
        dgvCurrencies.AllowUserToOrderColumns = True
        dgvCurrencies.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvCurrencies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvCurrencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCurrencies.Columns.AddRange(New DataGridViewColumn() {Column3, Column4, Column1, Column2, Column5, Column6, Column14, Column15})
        dgvCurrencies.Dock = DockStyle.Fill
        dgvCurrencies.Location = New Point(3, 76)
        dgvCurrencies.Margin = New Padding(3, 4, 3, 4)
        dgvCurrencies.MultiSelect = False
        dgvCurrencies.Name = "dgvCurrencies"
        dgvCurrencies.ReadOnly = True
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgvCurrencies.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgvCurrencies.RowHeadersWidth = 51
        dgvCurrencies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCurrencies.Size = New Size(1018, 165)
        dgvCurrencies.TabIndex = 1
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الرقم"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الصنف"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 200
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الباركود"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "المجموعة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "سعر الشراء"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 80
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "سعر البيع"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 80
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "الضريبة"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Visible = False
        Column14.Width = 125
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "السعر بعد الضريبة"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Visible = False
        Column15.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(txtSrchBarcode)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtNameSrch)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(3, 21)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1018, 55)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox3.Controls.Add(chkPrintLimit)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(txtFromNo)
        GroupBox3.Controls.Add(txtToNo)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Location = New Point(238, 0)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(269, 46)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        ' 
        ' chkPrintLimit
        ' 
        chkPrintLimit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkPrintLimit.AutoSize = True
        chkPrintLimit.ImeMode = ImeMode.NoControl
        chkPrintLimit.Location = New Point(14, 15)
        chkPrintLimit.Margin = New Padding(3, 4, 3, 4)
        chkPrintLimit.Name = "chkPrintLimit"
        chkPrintLimit.Size = New Size(18, 17)
        chkPrintLimit.TabIndex = 58
        chkPrintLimit.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.ImeMode = ImeMode.NoControl
        Label20.Location = New Point(205, 16)
        Label20.Name = "Label20"
        Label20.Size = New Size(60, 17)
        Label20.TabIndex = 13
        Label20.Text = " من رقم"
        ' 
        ' txtFromNo
        ' 
        txtFromNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFromNo.Location = New Point(142, 11)
        txtFromNo.Margin = New Padding(3, 4, 3, 4)
        txtFromNo.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        txtFromNo.Name = "txtFromNo"
        txtFromNo.Size = New Size(58, 24)
        txtFromNo.TabIndex = 12
        txtFromNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtToNo
        ' 
        txtToNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtToNo.Location = New Point(39, 11)
        txtToNo.Margin = New Padding(3, 4, 3, 4)
        txtToNo.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        txtToNo.Name = "txtToNo"
        txtToNo.Size = New Size(58, 24)
        txtToNo.TabIndex = 12
        txtToNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.ImeMode = ImeMode.NoControl
        Label21.Location = New Point(102, 16)
        Label21.Name = "Label21"
        Label21.Size = New Size(32, 17)
        Label21.TabIndex = 0
        Label21.Text = "إلى"
        ' 
        ' txtSrchBarcode
        ' 
        txtSrchBarcode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSrchBarcode.Location = New Point(518, 14)
        txtSrchBarcode.Margin = New Padding(3, 4, 3, 4)
        txtSrchBarcode.MaxLength = 50
        txtSrchBarcode.Name = "txtSrchBarcode"
        txtSrchBarcode.Size = New Size(129, 24)
        txtSrchBarcode.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.ImeMode = ImeMode.NoControl
        Label15.Location = New Point(649, 18)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 17)
        Label15.TabIndex = 0
        Label15.Text = "الباركود"
        ' 
        ' txtNameSrch
        ' 
        txtNameSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNameSrch.Location = New Point(713, 14)
        txtNameSrch.Margin = New Padding(3, 4, 3, 4)
        txtNameSrch.MaxLength = 50
        txtNameSrch.Name = "txtNameSrch"
        txtNameSrch.Size = New Size(195, 24)
        txtNameSrch.TabIndex = 0
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.ImeMode = ImeMode.NoControl
        Label14.Location = New Point(914, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(51, 17)
        Label14.TabIndex = 0
        Label14.Text = "الصنف"
        ' 
        ' Button3
        ' 
        Button3.ImeMode = ImeMode.NoControl
        Button3.Location = New Point(105, 7)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 39)
        Button3.TabIndex = 11
        Button3.Text = "بحث"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(chkTab3)
        GroupBox2.Controls.Add(progressBar1)
        GroupBox2.Controls.Add(btnClientsImport)
        GroupBox2.Controls.Add(cmbItemType)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(txtMinPrice)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(picImage)
        GroupBox2.Controls.Add(txtPicPath)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(btnOpenFile)
        GroupBox2.Controls.Add(chkOutOffer)
        GroupBox2.Controls.Add(chkMezan)
        GroupBox2.Controls.Add(txtDiscount)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(txtTax)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(cmbTaxGroup)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(cmbUnit)
        GroupBox2.Controls.Add(lbkbUnit)
        GroupBox2.Controls.Add(txtLimit)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtSaleDollar)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txtSalePrice)
        GroupBox2.Controls.Add(txtPurchDollar)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtPurchPrice)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(cmbGroups)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtBarcode)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtNo)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtOperateNo)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(txtNameEN)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtNote)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(txtSymbol)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(7, 6)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(1081, 329)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' chkTab3
        ' 
        chkTab3.BackColor = Color.Transparent
        chkTab3.ForeColor = Color.Blue
        chkTab3.Location = New Point(498, 154)
        chkTab3.Margin = New Padding(3, 4, 3, 4)
        chkTab3.Name = "chkTab3"
        chkTab3.Size = New Size(119, 30)
        chkTab3.TabIndex = 222
        chkTab3.UseVisualStyleBackColor = False
        ' 
        ' progressBar1
        ' 
        progressBar1.Dock = DockStyle.Bottom
        progressBar1.ImeMode = ImeMode.NoControl
        progressBar1.Location = New Point(3, 297)
        progressBar1.Margin = New Padding(3, 4, 3, 4)
        progressBar1.Name = "progressBar1"
        progressBar1.Size = New Size(1075, 28)
        progressBar1.TabIndex = 59
        ' 
        ' btnClientsImport
        ' 
        btnClientsImport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClientsImport.ImeMode = ImeMode.NoControl
        btnClientsImport.Location = New Point(51, 265)
        btnClientsImport.Margin = New Padding(3, 4, 3, 4)
        btnClientsImport.Name = "btnClientsImport"
        btnClientsImport.Size = New Size(306, 28)
        btnClientsImport.TabIndex = 58
        btnClientsImport.Text = "استيراد الأصناف من  إكسل"
        btnClientsImport.UseVisualStyleBackColor = True
        ' 
        ' cmbItemType
        ' 
        cmbItemType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbItemType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbItemType.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbItemType.FormattingEnabled = True
        cmbItemType.Items.AddRange(New Object() {"مخزني", "خام", "صناعي", "خدمي"})
        cmbItemType.Location = New Point(648, 194)
        cmbItemType.Margin = New Padding(3, 4, 3, 4)
        cmbItemType.Name = "cmbItemType"
        cmbItemType.Size = New Size(116, 24)
        cmbItemType.TabIndex = 56
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.ImeMode = ImeMode.NoControl
        Label19.Location = New Point(773, 199)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 17)
        Label19.TabIndex = 57
        Label19.Text = "نوع الصنف"
        ' 
        ' txtMinPrice
        ' 
        txtMinPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMinPrice.Location = New Point(864, 194)
        txtMinPrice.Margin = New Padding(3, 4, 3, 4)
        txtMinPrice.MaxLength = 50
        txtMinPrice.Name = "txtMinPrice"
        txtMinPrice.Size = New Size(107, 24)
        txtMinPrice.TabIndex = 5
        txtMinPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.ImeMode = ImeMode.NoControl
        Label17.Location = New Point(973, 198)
        Label17.Name = "Label17"
        Label17.Size = New Size(115, 17)
        Label17.TabIndex = 55
        Label17.Text = "الحد الأدنى للبيع"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.ImeMode = ImeMode.NoControl
        Button4.Location = New Point(683, 48)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(47, 28)
        Button4.TabIndex = 53
        Button4.Text = "Gen"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' picImage
        ' 
        picImage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picImage.BorderStyle = BorderStyle.FixedSingle
        picImage.ImeMode = ImeMode.NoControl
        picImage.Location = New Point(466, 196)
        picImage.Margin = New Padding(3, 4, 3, 4)
        picImage.Name = "picImage"
        picImage.Size = New Size(123, 93)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 52
        picImage.TabStop = False
        ' 
        ' txtPicPath
        ' 
        txtPicPath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPicPath.Location = New Point(665, 262)
        txtPicPath.Margin = New Padding(3, 4, 3, 4)
        txtPicPath.Name = "txtPicPath"
        txtPicPath.ReadOnly = True
        txtPicPath.Size = New Size(306, 24)
        txtPicPath.TabIndex = 49
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.ImeMode = ImeMode.NoControl
        Label16.Location = New Point(978, 266)
        Label16.Name = "Label16"
        Label16.Size = New Size(90, 17)
        Label16.TabIndex = 51
        Label16.Text = "صورة الصنف"
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenFile.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnOpenFile.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnOpenFile.ForeColor = Color.Lime
        btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), Image)
        btnOpenFile.ImeMode = ImeMode.NoControl
        btnOpenFile.Location = New Point(618, 257)
        btnOpenFile.Margin = New Padding(3, 4, 3, 4)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(40, 36)
        btnOpenFile.TabIndex = 15
        btnOpenFile.UseVisualStyleBackColor = False
        ' 
        ' chkOutOffer
        ' 
        chkOutOffer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkOutOffer.AutoSize = True
        chkOutOffer.ImeMode = ImeMode.NoControl
        chkOutOffer.Location = New Point(458, 162)
        chkOutOffer.Margin = New Padding(3, 4, 3, 4)
        chkOutOffer.Name = "chkOutOffer"
        chkOutOffer.Size = New Size(169, 21)
        chkOutOffer.TabIndex = 13
        chkOutOffer.Text = "غير مشمول بالعروض"
        chkOutOffer.UseVisualStyleBackColor = True
        ' 
        ' chkMezan
        ' 
        chkMezan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkMezan.AutoSize = True
        chkMezan.ImeMode = ImeMode.NoControl
        chkMezan.Location = New Point(862, 74)
        chkMezan.Margin = New Padding(3, 4, 3, 4)
        chkMezan.Name = "chkMezan"
        chkMezan.Size = New Size(109, 21)
        chkMezan.TabIndex = 1
        chkMezan.Text = "باركود ميزان"
        chkMezan.UseVisualStyleBackColor = True
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDiscount.Location = New Point(473, 129)
        txtDiscount.Margin = New Padding(3, 4, 3, 4)
        txtDiscount.MaxLength = 50
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(116, 24)
        txtDiscount.TabIndex = 8
        txtDiscount.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.ImeMode = ImeMode.NoControl
        Label12.Location = New Point(605, 133)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 17)
        Label12.TabIndex = 15
        Label12.Text = "الخصم %"
        ' 
        ' txtTax
        ' 
        txtTax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTax.Location = New Point(75, 142)
        txtTax.Margin = New Padding(3, 4, 3, 4)
        txtTax.MaxLength = 50
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(124, 24)
        txtTax.TabIndex = 10
        txtTax.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.ImeMode = ImeMode.NoControl
        Label11.Location = New Point(63, 122)
        Label11.Name = "Label11"
        Label11.Size = New Size(155, 17)
        Label11.TabIndex = 13
        Label11.Text = "ض. القيمة المضافة %"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.ImeMode = ImeMode.NoControl
        Button2.Location = New Point(577, 47)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 28)
        Button2.TabIndex = 12
        Button2.Text = "متعدد"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(627, 48)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(57, 28)
        Button1.TabIndex = 11
        Button1.Text = "طباعة"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmbTaxGroup
        ' 
        cmbTaxGroup.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbTaxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbTaxGroup.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbTaxGroup.FormattingEnabled = True
        cmbTaxGroup.Location = New Point(213, 142)
        cmbTaxGroup.Margin = New Padding(3, 4, 3, 4)
        cmbTaxGroup.Name = "cmbTaxGroup"
        cmbTaxGroup.Size = New Size(145, 24)
        cmbTaxGroup.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.ImeMode = ImeMode.NoControl
        Label13.Location = New Point(213, 122)
        Label13.Name = "Label13"
        Label13.Size = New Size(131, 17)
        Label13.TabIndex = 10
        Label13.Text = "المجموعة الضريبية"
        ' 
        ' cmbUnit
        ' 
        cmbUnit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbUnit.FormattingEnabled = True
        cmbUnit.Location = New Point(213, 196)
        cmbUnit.Margin = New Padding(3, 4, 3, 4)
        cmbUnit.Name = "cmbUnit"
        cmbUnit.Size = New Size(145, 24)
        cmbUnit.TabIndex = 11
        ' 
        ' lbkbUnit
        ' 
        lbkbUnit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbkbUnit.AutoSize = True
        lbkbUnit.Location = New Point(231, 176)
        lbkbUnit.Name = "lbkbUnit"
        lbkbUnit.Size = New Size(121, 17)
        lbkbUnit.TabIndex = 10
        lbkbUnit.Text = "الوحدة الافتراضية"
        ' 
        ' txtLimit
        ' 
        txtLimit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtLimit.Location = New Point(74, 197)
        txtLimit.Margin = New Padding(3, 4, 3, 4)
        txtLimit.MaxLength = 50
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(125, 24)
        txtLimit.TabIndex = 12
        txtLimit.Text = "0"
        txtLimit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(77, 175)
        Label8.Name = "Label8"
        Label8.Size = New Size(127, 17)
        Label8.TabIndex = 6
        Label8.Text = "الحد الأدنى للكمية"
        ' 
        ' txtSaleDollar
        ' 
        txtSaleDollar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSaleDollar.Location = New Point(75, 79)
        txtSaleDollar.Margin = New Padding(3, 4, 3, 4)
        txtSaleDollar.MaxLength = 50
        txtSaleDollar.Name = "txtSaleDollar"
        txtSaleDollar.Size = New Size(125, 24)
        txtSaleDollar.TabIndex = 7
        txtSaleDollar.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(85, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 17)
        Label9.TabIndex = 6
        Label9.Text = "سعر البيع (دولار)"
        ' 
        ' txtSalePrice
        ' 
        txtSalePrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSalePrice.Location = New Point(235, 80)
        txtSalePrice.Margin = New Padding(3, 4, 3, 4)
        txtSalePrice.MaxLength = 50
        txtSalePrice.Name = "txtSalePrice"
        txtSalePrice.Size = New Size(107, 24)
        txtSalePrice.TabIndex = 7
        txtSalePrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPurchDollar
        ' 
        txtPurchDollar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPurchDollar.Location = New Point(75, 32)
        txtPurchDollar.Margin = New Padding(3, 4, 3, 4)
        txtPurchDollar.MaxLength = 50
        txtPurchDollar.Name = "txtPurchDollar"
        txtPurchDollar.Size = New Size(125, 24)
        txtPurchDollar.TabIndex = 6
        txtPurchDollar.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(254, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 17)
        Label5.TabIndex = 6
        Label5.Text = "سعر البيع"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(80, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 17)
        Label7.TabIndex = 4
        Label7.Text = "سعر الشراء (دولار)"
        ' 
        ' txtPurchPrice
        ' 
        txtPurchPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPurchPrice.Location = New Point(235, 33)
        txtPurchPrice.Margin = New Padding(3, 4, 3, 4)
        txtPurchPrice.MaxLength = 50
        txtPurchPrice.Name = "txtPurchPrice"
        txtPurchPrice.Size = New Size(107, 24)
        txtPurchPrice.TabIndex = 6
        txtPurchPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(247, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 17)
        Label4.TabIndex = 4
        Label4.Text = "سعر الشراء"
        ' 
        ' cmbGroups
        ' 
        cmbGroups.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbGroups.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbGroups.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbGroups.FormattingEnabled = True
        cmbGroups.Location = New Point(734, 159)
        cmbGroups.Margin = New Padding(3, 4, 3, 4)
        cmbGroups.Name = "cmbGroups"
        cmbGroups.Size = New Size(237, 24)
        cmbGroups.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(978, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 17)
        Label3.TabIndex = 3
        Label3.Text = "مجموعة الصنف"
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBarcode.Location = New Point(734, 49)
        txtBarcode.Margin = New Padding(3, 4, 3, 4)
        txtBarcode.MaxLength = 50
        txtBarcode.Name = "txtBarcode"
        txtBarcode.RightToLeft = RightToLeft.No
        txtBarcode.Size = New Size(237, 24)
        txtBarcode.TabIndex = 1
        txtBarcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(998, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 17)
        Label2.TabIndex = 0
        Label2.Text = "الباركود"
        ' 
        ' txtNo
        ' 
        txtNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNo.Location = New Point(846, 21)
        txtNo.Margin = New Padding(3, 4, 3, 4)
        txtNo.MaxLength = 50
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(125, 24)
        txtNo.TabIndex = 0
        txtNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(987, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 0
        Label1.Text = "رقم الصنف"
        ' 
        ' txtOperateNo
        ' 
        txtOperateNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtOperateNo.Location = New Point(213, 234)
        txtOperateNo.Margin = New Padding(3, 4, 3, 4)
        txtOperateNo.MaxLength = 500
        txtOperateNo.Name = "txtOperateNo"
        txtOperateNo.Size = New Size(145, 24)
        txtOperateNo.TabIndex = 3
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label22.AutoSize = True
        Label22.ImeMode = ImeMode.NoControl
        Label22.Location = New Point(362, 239)
        Label22.Name = "Label22"
        Label22.Size = New Size(93, 17)
        Label22.TabIndex = 0
        Label22.Text = "رقم التشغيلة"
        ' 
        ' txtNameEN
        ' 
        txtNameEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNameEN.Location = New Point(734, 128)
        txtNameEN.Margin = New Padding(3, 4, 3, 4)
        txtNameEN.MaxLength = 500
        txtNameEN.Name = "txtNameEN"
        txtNameEN.Size = New Size(237, 24)
        txtNameEN.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.ImeMode = ImeMode.NoControl
        Label10.Location = New Point(986, 133)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 17)
        Label10.TabIndex = 0
        Label10.Text = "الصنف (EN)"
        ' 
        ' txtNote
        ' 
        txtNote.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNote.Location = New Point(618, 226)
        txtNote.Margin = New Padding(3, 4, 3, 4)
        txtNote.MaxLength = 500
        txtNote.Name = "txtNote"
        txtNote.Size = New Size(353, 24)
        txtNote.TabIndex = 14
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.ImeMode = ImeMode.NoControl
        Label18.Location = New Point(983, 230)
        Label18.Name = "Label18"
        Label18.Size = New Size(81, 17)
        Label18.TabIndex = 0
        Label18.Text = "بيان الصنف"
        ' 
        ' txtSymbol
        ' 
        txtSymbol.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSymbol.Location = New Point(472, 97)
        txtSymbol.Margin = New Padding(3, 4, 3, 4)
        txtSymbol.MaxLength = 500
        txtSymbol.Name = "txtSymbol"
        txtSymbol.Size = New Size(499, 24)
        txtSymbol.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(1000, 101)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 17)
        Label6.TabIndex = 0
        Label6.Text = "الصنف"
        ' 
        ' frmcurrency
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1115, 783)
        Controls.Add(panel2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmcurrency"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف الأصناف"
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(dgvFirst, System.ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgvUnits, System.ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgvComponents, System.ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        CType(dgvSafeBalance, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(dgvCurrencies, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(txtFromNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(txtToNo, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
