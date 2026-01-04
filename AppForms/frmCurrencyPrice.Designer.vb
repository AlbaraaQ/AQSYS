Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCurrencyPrice
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkSrchAll As CheckBox
    Friend WithEvents cmbCurrency1 As ComboBox
    Friend WithEvents cmbCurrencySrch As ComboBox
    Friend WithEvents dgvPrices As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAveragePrice As Label
    Friend WithEvents txtCurrencyNoSrch As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents txtHighPurch As TextBox
    Friend WithEvents txtHighSale As TextBox
    Friend WithEvents txtLowPurch As TextBox
    Friend WithEvents txtLowSale As TextBox
    Friend WithEvents txtPurch As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents txtTime As DateTimePicker

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        dgvPrices = New DataGridView()
        Column1 = New DataGridViewComboBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        txtAveragePrice = New Label()
        GroupBox2 = New GroupBox()
        txtHighSale = New TextBox()
        txtEmp = New TextBox()
        txtLowSale = New TextBox()
        txtDate = New DateTimePicker()
        txtHighPurch = New TextBox()
        txtTime = New DateTimePicker()
        txtLowPurch = New TextBox()
        Label4 = New Label()
        txtSale = New TextBox()
        Label14 = New Label()
        txtPurch = New TextBox()
        Label10 = New Label()
        cmbCurrency1 = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Label12 = New Label()
        Label7 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvSrch = New DataGridView()
        Column11 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        GroupBox6 = New GroupBox()
        chkSrchAll = New CheckBox()
        txtCurrencyNoSrch = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        cmbCurrencySrch = New ComboBox()
        btnSearch = New Button()
        toolStripSeparator2 = New ToolStripSeparator()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnClose = New ToolStripButton()
        panel2 = New Panel()
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(TabControl1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1389, 573)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(3, 21)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1383, 548)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(dgvPrices)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1375, 519)
        TabPage1.TabIndex = 0
        TabPage1.Text = "                   اخر الاسعار                   "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' dgvPrices
        ' 
        dgvPrices.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvPrices.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPrices.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgvPrices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPrices.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column12})
        dgvPrices.Dock = DockStyle.Fill
        dgvPrices.Location = New Point(3, 181)
        dgvPrices.Margin = New Padding(3, 4, 3, 4)
        dgvPrices.MultiSelect = False
        dgvPrices.Name = "dgvPrices"
        dgvPrices.ReadOnly = True
        dgvPrices.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.White
        dgvPrices.RowsDefaultCellStyle = DataGridViewCellStyle8
        dgvPrices.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPrices.Size = New Size(1369, 334)
        dgvPrices.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الصنف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.Automatic
        Column1.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "وقت التحديد"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 80
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "تاريخ التحديد"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle2.BackColor = Color.Red
        Column5.DefaultCellStyle = DataGridViewCellStyle2
        Column5.HeaderText = "سعر الشراء"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 85
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Column6.DefaultCellStyle = DataGridViewCellStyle3
        Column6.HeaderText = "سعر البيع"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 85
        ' 
        ' Column7
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Column7.DefaultCellStyle = DataGridViewCellStyle4
        Column7.HeaderText = "ادنى سعر شراء"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 85
        ' 
        ' Column8
        ' 
        DataGridViewCellStyle5.BackColor = Color.Gray
        Column8.DefaultCellStyle = DataGridViewCellStyle5
        Column8.HeaderText = "اعلى سعر شراء"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 85
        ' 
        ' Column9
        ' 
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Column9.DefaultCellStyle = DataGridViewCellStyle6
        Column9.HeaderText = "ادنى سعر بيع"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 85
        ' 
        ' Column10
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Column10.DefaultCellStyle = DataGridViewCellStyle7
        Column10.HeaderText = "اعلى سعر بيع"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 85
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "مسئول الادخال"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 150
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(3, 4)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 177)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox3.Controls.Add(txtAveragePrice)
        GroupBox3.Location = New Point(17, 14)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.RightToLeft = RightToLeft.Yes
        GroupBox3.Size = New Size(168, 149)
        GroupBox3.TabIndex = 39
        GroupBox3.TabStop = False
        GroupBox3.Text = "متوسط تكلفة الشراء"
        ' 
        ' txtAveragePrice
        ' 
        txtAveragePrice.Dock = DockStyle.Fill
        txtAveragePrice.Font = New Font("Tahoma", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtAveragePrice.Location = New Point(3, 21)
        txtAveragePrice.Name = "txtAveragePrice"
        txtAveragePrice.Size = New Size(162, 124)
        txtAveragePrice.TabIndex = 0
        txtAveragePrice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(txtHighSale)
        GroupBox2.Controls.Add(txtEmp)
        GroupBox2.Controls.Add(txtLowSale)
        GroupBox2.Controls.Add(txtDate)
        GroupBox2.Controls.Add(txtHighPurch)
        GroupBox2.Controls.Add(txtTime)
        GroupBox2.Controls.Add(txtLowPurch)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtSale)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(txtPurch)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(cmbCurrency1)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(192, 14)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(1166, 149)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' txtHighSale
        ' 
        txtHighSale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtHighSale.Location = New Point(229, 96)
        txtHighSale.Margin = New Padding(3, 4, 3, 4)
        txtHighSale.Name = "txtHighSale"
        txtHighSale.Size = New Size(142, 24)
        txtHighSale.TabIndex = 9
        ' 
        ' txtEmp
        ' 
        txtEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmp.Location = New Point(30, 48)
        txtEmp.Margin = New Padding(3, 4, 3, 4)
        txtEmp.Multiline = True
        txtEmp.Name = "txtEmp"
        txtEmp.ReadOnly = True
        txtEmp.Size = New Size(156, 63)
        txtEmp.TabIndex = 1000
        ' 
        ' txtLowSale
        ' 
        txtLowSale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtLowSale.Location = New Point(378, 96)
        txtLowSale.Margin = New Padding(3, 4, 3, 4)
        txtLowSale.Name = "txtLowSale"
        txtLowSale.Size = New Size(142, 24)
        txtLowSale.TabIndex = 8
        ' 
        ' txtDate
        ' 
        txtDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(538, 33)
        txtDate.Margin = New Padding(3, 4, 3, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(125, 24)
        txtDate.TabIndex = 2
        ' 
        ' txtHighPurch
        ' 
        txtHighPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtHighPurch.Location = New Point(528, 96)
        txtHighPurch.Margin = New Padding(3, 4, 3, 4)
        txtHighPurch.Name = "txtHighPurch"
        txtHighPurch.Size = New Size(142, 24)
        txtHighPurch.TabIndex = 7
        ' 
        ' txtTime
        ' 
        txtTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTime.Format = DateTimePickerFormat.Time
        txtTime.Location = New Point(267, 32)
        txtTime.Margin = New Padding(3, 4, 3, 4)
        txtTime.Name = "txtTime"
        txtTime.ShowUpDown = True
        txtTime.Size = New Size(125, 24)
        txtTime.TabIndex = 3
        ' 
        ' txtLowPurch
        ' 
        txtLowPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtLowPurch.Location = New Point(678, 96)
        txtLowPurch.Margin = New Padding(3, 4, 3, 4)
        txtLowPurch.Name = "txtLowPurch"
        txtLowPurch.Size = New Size(142, 24)
        txtLowPurch.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(24, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 17)
        Label4.TabIndex = 7
        Label4.Text = "المسئول عن ادخال الأسعار"
        ' 
        ' txtSale
        ' 
        txtSale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSale.Location = New Point(827, 96)
        txtSale.Margin = New Padding(3, 4, 3, 4)
        txtSale.Name = "txtSale"
        txtSale.Size = New Size(142, 24)
        txtSale.TabIndex = 5
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New Point(1070, 38)
        Label14.Name = "Label14"
        Label14.Size = New Size(51, 17)
        Label14.TabIndex = 20
        Label14.Text = "الصنف"
        ' 
        ' txtPurch
        ' 
        txtPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPurch.Location = New Point(977, 96)
        txtPurch.Margin = New Padding(3, 4, 3, 4)
        txtPurch.Name = "txtPurch"
        txtPurch.Size = New Size(142, 24)
        txtPurch.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label10.Location = New Point(262, 70)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 17)
        Label10.TabIndex = 33
        Label10.Text = "اعلى سعر بيع"
        ' 
        ' cmbCurrency1
        ' 
        cmbCurrency1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCurrency1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrency1.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrency1.FormattingEnabled = True
        cmbCurrency1.Location = New Point(808, 33)
        cmbCurrency1.Margin = New Padding(3, 4, 3, 4)
        cmbCurrency1.Name = "cmbCurrency1"
        cmbCurrency1.Size = New Size(255, 24)
        cmbCurrency1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(554, 76)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 17)
        Label9.TabIndex = 32
        Label9.Text = "اعلى سعر شراء"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label8.Location = New Point(410, 76)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 17)
        Label8.TabIndex = 31
        Label8.Text = "ادنى سعر بيع"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(679, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 17)
        Label12.TabIndex = 24
        Label12.Text = "تاريخ التحديد"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(706, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 17)
        Label7.TabIndex = 30
        Label7.Text = "ادنى سعر شراء"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(405, 36)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 17)
        Label11.TabIndex = 26
        Label11.Text = "وقت التحديد"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label6.Location = New Point(872, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 17)
        Label6.TabIndex = 29
        Label6.Text = "سعر البيع"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(1014, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 17)
        Label5.TabIndex = 28
        Label5.Text = "سعر الشراء"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1374, 511)
        TabPage2.TabIndex = 1
        TabPage2.Text = "                   البحث                   "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightBlue
        GroupBox4.Controls.Add(dgvSrch)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(3, 139)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(1368, 368)
        GroupBox4.TabIndex = 11
        GroupBox4.TabStop = False
        GroupBox4.Text = "نتائج البحث"
        ' 
        ' dgvSrch
        ' 
        dgvSrch.AllowUserToAddRows = False
        dgvSrch.AllowUserToDeleteRows = False
        dgvSrch.AllowUserToOrderColumns = True
        dgvSrch.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = SystemColors.Control
        DataGridViewCellStyle9.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgvSrch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgvSrch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSrch.Columns.AddRange(New DataGridViewColumn() {Column11, Column14, Column15, Column19, Column20, Column16, Column17})
        dgvSrch.Dock = DockStyle.Fill
        dgvSrch.Location = New Point(3, 21)
        dgvSrch.Margin = New Padding(3, 4, 3, 4)
        dgvSrch.Name = "dgvSrch"
        dgvSrch.ReadOnly = True
        dgvSrch.RowHeadersWidth = 51
        dgvSrch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSrch.Size = New Size(1362, 343)
        dgvSrch.TabIndex = 0
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "الصنف"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 200
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "سعر الشراء"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 125
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "سعر البيع"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Width = 125
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "وقت التحديد"
        Column19.MinimumWidth = 6
        Column19.Name = "Column19"
        Column19.ReadOnly = True
        Column19.Width = 125
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "تاريخ التحديد"
        Column20.MinimumWidth = 6
        Column20.Name = "Column20"
        Column20.ReadOnly = True
        Column20.Width = 125
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "مسئول الادخال"
        Column16.MinimumWidth = 6
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Width = 200
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "رقم الصنف"
        Column17.MinimumWidth = 6
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Visible = False
        Column17.Width = 125
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.LightBlue
        GroupBox6.Controls.Add(chkSrchAll)
        GroupBox6.Controls.Add(txtCurrencyNoSrch)
        GroupBox6.Controls.Add(Label2)
        GroupBox6.Controls.Add(Label1)
        GroupBox6.Controls.Add(cmbCurrencySrch)
        GroupBox6.Controls.Add(btnSearch)
        GroupBox6.Dock = DockStyle.Top
        GroupBox6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox6.Location = New Point(3, 4)
        GroupBox6.Margin = New Padding(3, 4, 3, 4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 4, 3, 4)
        GroupBox6.RightToLeft = RightToLeft.Yes
        GroupBox6.Size = New Size(1368, 135)
        GroupBox6.TabIndex = 10
        GroupBox6.TabStop = False
        GroupBox6.Text = "البحث"
        ' 
        ' chkSrchAll
        ' 
        chkSrchAll.AutoSize = True
        chkSrchAll.Location = New Point(1193, 105)
        chkSrchAll.Margin = New Padding(3, 4, 3, 4)
        chkSrchAll.Name = "chkSrchAll"
        chkSrchAll.Size = New Size(58, 21)
        chkSrchAll.TabIndex = 31
        chkSrchAll.Text = "الكل"
        chkSrchAll.UseVisualStyleBackColor = True
        ' 
        ' txtCurrencyNoSrch
        ' 
        txtCurrencyNoSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCurrencyNoSrch.Location = New Point(1167, 38)
        txtCurrencyNoSrch.Margin = New Padding(3, 4, 3, 4)
        txtCurrencyNoSrch.Name = "txtCurrencyNoSrch"
        txtCurrencyNoSrch.Size = New Size(85, 24)
        txtCurrencyNoSrch.TabIndex = 29
        txtCurrencyNoSrch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(1269, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 17)
        Label2.TabIndex = 30
        Label2.Text = "رقم الصنف"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(1295, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 17)
        Label1.TabIndex = 22
        Label1.Text = "الصنف"
        ' 
        ' cmbCurrencySrch
        ' 
        cmbCurrencySrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCurrencySrch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrencySrch.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrencySrch.FormattingEnabled = True
        cmbCurrencySrch.Location = New Point(1019, 71)
        cmbCurrencySrch.Margin = New Padding(3, 4, 3, 4)
        cmbCurrencySrch.Name = "cmbCurrencySrch"
        cmbCurrencySrch.Size = New Size(233, 25)
        cmbCurrencySrch.TabIndex = 21
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Lime
        btnSearch.Image = My.Resources.Resources.search_icon
        btnSearch.Location = New Point(839, 42)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 59)
        btnSearch.TabIndex = 1
        btnSearch.UseVisualStyleBackColor = False
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
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, toolStripSeparator2, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(1387, 65)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNew.Image = My.Resources.Resources._new
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
        btnSave.Image = My.Resources.Resources.save
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 50)
        btnSave.Text = "حفظ"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = My.Resources.Resources._exit
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
        panel2.Location = New Point(0, 573)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(1389, 67)
        panel2.TabIndex = 12
        ' 
        ' frmCurrencyPrice
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1389, 640)
        Controls.Add(GroupBox1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCurrencyPrice"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "أسعار الأصناف"
        GroupBox1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(dgvPrices, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
