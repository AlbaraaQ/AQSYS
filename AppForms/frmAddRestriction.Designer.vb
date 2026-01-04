Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAddRestriction
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
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
    Friend WithEvents cmbAccName As ComboBox
    Friend WithEvents cmbCenter As ComboBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents lblcostcenter As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents txtAccCode As TextBox
    Friend WithEvents txtAccNote As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtDept As TextBox
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtISBalanced As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNoSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtTotCredit As TextBox
    Friend WithEvents txtTotDebt As TextBox

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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        cmbCenter = New ComboBox()
        lblcostcenter = New Label()
        dgvDetails = New DataGridView()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewButtonColumn()
        cmbAccName = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtISBalanced = New TextBox()
        txtTotCredit = New TextBox()
        TextBox3 = New TextBox()
        txtTotDebt = New TextBox()
        txtAccNote = New TextBox()
        txtCredit = New TextBox()
        txtDept = New TextBox()
        txtAccCode = New TextBox()
        Panel1 = New Panel()
        cmbType = New ComboBox()
        Label9 = New Label()
        Label13 = New Label()
        Label7 = New Label()
        Label12 = New Label()
        txtDate = New DateTimePicker()
        txtNo = New TextBox()
        txtNotes = New TextBox()
        Label2 = New Label()
        cmbState = New ComboBox()
        panel2 = New Panel()
        ToolStrip2 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnFirst = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        btnPrint = New ToolStripButton()
        btnClose = New ToolStripButton()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvSrch = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        GroupBox6 = New GroupBox()
        txtNoSrch = New TextBox()
        Label8 = New Label()
        txtToDate = New DateTimePicker()
        Label10 = New Label()
        txtFromDate = New DateTimePicker()
        Label11 = New Label()
        btnSearch = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvDetails, ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        panel2.SuspendLayout()
        ToolStrip2.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvSrch, ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1153, 619)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(247))
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1145, 585)
        TabPage1.TabIndex = 0
        TabPage1.Text = "            بيانـــات القيد            "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(3, 4)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1139, 577)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(247))
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(panel2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 20)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1139, 557)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(cmbCenter)
        GroupBox3.Controls.Add(lblcostcenter)
        GroupBox3.Controls.Add(dgvDetails)
        GroupBox3.Controls.Add(cmbAccName)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(txtISBalanced)
        GroupBox3.Controls.Add(txtTotCredit)
        GroupBox3.Controls.Add(TextBox3)
        GroupBox3.Controls.Add(txtTotDebt)
        GroupBox3.Controls.Add(txtAccNote)
        GroupBox3.Controls.Add(txtCredit)
        GroupBox3.Controls.Add(txtDept)
        GroupBox3.Controls.Add(txtAccCode)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(5, 168)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(10)
        GroupBox3.Size = New Size(1129, 314)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "تفاصيل القيد"
        ' 
        ' cmbCenter
        ' 
        cmbCenter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCenter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCenter.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCenter.FlatStyle = FlatStyle.System
        cmbCenter.FormattingEnabled = True
        cmbCenter.Items.AddRange(New Object() {"فاتورة شراء", "فاتورة بيع", "مرتد فاتورة شراء", "مرتد فاتورة بيع", "سند قبض خارجي", "سند صرف خارجي", "سند قبض داخلي", "سند صرف داخلي", "مخزون أول المدة", "أخرى"})
        cmbCenter.Location = New Point(381, 44)
        cmbCenter.Margin = New Padding(3, 4, 3, 4)
        cmbCenter.Name = "cmbCenter"
        cmbCenter.Size = New Size(175, 29)
        cmbCenter.TabIndex = 4
        ' 
        ' lblcostcenter
        ' 
        lblcostcenter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblcostcenter.AutoSize = True
        lblcostcenter.ForeColor = Color.DimGray
        lblcostcenter.ImeMode = ImeMode.NoControl
        lblcostcenter.Location = New Point(442, 25)
        lblcostcenter.Name = "lblcostcenter"
        lblcostcenter.Size = New Size(96, 23)
        lblcostcenter.TabIndex = 23
        lblcostcenter.Text = "مركز التكلفة"
        ' 
        ' dgvDetails
        ' 
        dgvDetails.AllowUserToAddRows = False
        dgvDetails.AllowUserToDeleteRows = False
        dgvDetails.AllowUserToOrderColumns = True
        dgvDetails.BackgroundColor = Color.White
        dgvDetails.BorderStyle = BorderStyle.None
        dgvDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDetails.ColumnHeadersHeight = 35
        dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvDetails.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn3, Column6, Column10, Column11, Column12, Column13, Column7, Column8, Column3})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDetails.DefaultCellStyle = DataGridViewCellStyle3
        dgvDetails.EditMode = DataGridViewEditMode.EditOnEnter
        dgvDetails.EnableHeadersVisualStyles = False
        dgvDetails.GridColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        dgvDetails.Location = New Point(13, 82)
        dgvDetails.Margin = New Padding(3, 4, 3, 4)
        dgvDetails.MultiSelect = False
        dgvDetails.Name = "dgvDetails"
        dgvDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvDetails.RowHeadersVisible = False
        dgvDetails.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvDetails.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvDetails.RowTemplate.Height = 30
        dgvDetails.Size = New Size(1107, 215)
        dgvDetails.TabIndex = 6
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewCellStyle2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn3.HeaderText = "م"
        DataGridViewTextBoxColumn3.MinimumWidth = 7
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 60
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "مدين"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "دائن"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "كود الحساب"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "اسم الحساب"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Resizable = DataGridViewTriState.True
        Column12.SortMode = DataGridViewColumnSortMode.NotSortable
        Column12.Width = 200
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "البيان"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 200
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "مركز التكلفة"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "رقم المركز"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Visible = False
        Column8.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = ""
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Text = "Delete"
        Column3.ToolTipText = "حذف"
        Column3.UseColumnTextForButtonValue = True
        Column3.Width = 125
        ' 
        ' cmbAccName
        ' 
        cmbAccName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbAccName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbAccName.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbAccName.FlatStyle = FlatStyle.System
        cmbAccName.FormattingEnabled = True
        cmbAccName.Items.AddRange(New Object() {"فاتورة شراء", "فاتورة بيع", "مرتد فاتورة شراء", "مرتد فاتورة بيع", "سند قبض خارجي", "سند صرف خارجي", "سند قبض داخلي", "سند صرف داخلي", "مخزون أول المدة", "أخرى"})
        cmbAccName.Location = New Point(818, 44)
        cmbAccName.Margin = New Padding(3, 4, 3, 4)
        cmbAccName.Name = "cmbAccName"
        cmbAccName.Size = New Size(187, 29)
        cmbAccName.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(335, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 23)
        Label5.TabIndex = 16
        Label5.Text = "البيان"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(636, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 23)
        Label4.TabIndex = 19
        Label4.Text = "دائن"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(755, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 23)
        Label3.TabIndex = 18
        Label3.Text = "مدين"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(1036, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 23)
        Label1.TabIndex = 0
        Label1.Text = "الحساب"
        ' 
        ' txtISBalanced
        ' 
        txtISBalanced.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtISBalanced.BackColor = Color.WhiteSmoke
        txtISBalanced.BorderStyle = BorderStyle.FixedSingle
        txtISBalanced.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtISBalanced.Location = New Point(13, 286)
        txtISBalanced.Margin = New Padding(3, 4, 3, 4)
        txtISBalanced.Name = "txtISBalanced"
        txtISBalanced.ReadOnly = True
        txtISBalanced.Size = New Size(678, 27)
        txtISBalanced.TabIndex = 13
        txtISBalanced.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTotCredit
        ' 
        txtTotCredit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotCredit.BackColor = Color.WhiteSmoke
        txtTotCredit.BorderStyle = BorderStyle.FixedSingle
        txtTotCredit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotCredit.ForeColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        txtTotCredit.Location = New Point(692, 286)
        txtTotCredit.Margin = New Padding(3, 4, 3, 4)
        txtTotCredit.Name = "txtTotCredit"
        txtTotCredit.ReadOnly = True
        txtTotCredit.Size = New Size(179, 27)
        txtTotCredit.TabIndex = 8
        txtTotCredit.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(1033, 286)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(87, 27)
        TextBox3.TabIndex = 7
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTotDebt
        ' 
        txtTotDebt.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotDebt.BackColor = Color.WhiteSmoke
        txtTotDebt.BorderStyle = BorderStyle.FixedSingle
        txtTotDebt.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotDebt.ForeColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        txtTotDebt.Location = New Point(874, 286)
        txtTotDebt.Margin = New Padding(3, 4, 3, 4)
        txtTotDebt.Name = "txtTotDebt"
        txtTotDebt.ReadOnly = True
        txtTotDebt.Size = New Size(157, 27)
        txtTotDebt.TabIndex = 6
        txtTotDebt.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAccNote
        ' 
        txtAccNote.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAccNote.BorderStyle = BorderStyle.FixedSingle
        txtAccNote.Location = New Point(15, 46)
        txtAccNote.Margin = New Padding(3, 4, 3, 4)
        txtAccNote.Name = "txtAccNote"
        txtAccNote.Size = New Size(359, 29)
        txtAccNote.TabIndex = 5
        txtAccNote.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCredit
        ' 
        txtCredit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCredit.BorderStyle = BorderStyle.FixedSingle
        txtCredit.Location = New Point(563, 46)
        txtCredit.Margin = New Padding(3, 4, 3, 4)
        txtCredit.Name = "txtCredit"
        txtCredit.Size = New Size(130, 29)
        txtCredit.TabIndex = 3
        txtCredit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDept
        ' 
        txtDept.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDept.BorderStyle = BorderStyle.FixedSingle
        txtDept.Location = New Point(700, 46)
        txtDept.Margin = New Padding(3, 4, 3, 4)
        txtDept.Name = "txtDept"
        txtDept.Size = New Size(111, 29)
        txtDept.TabIndex = 2
        txtDept.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAccCode
        ' 
        txtAccCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAccCode.BorderStyle = BorderStyle.FixedSingle
        txtAccCode.Location = New Point(1007, 46)
        txtAccCode.Margin = New Padding(3, 4, 3, 4)
        txtAccCode.Name = "txtAccCode"
        txtAccCode.Size = New Size(103, 29)
        txtAccCode.TabIndex = 0
        txtAccCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(cmbType)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtDate)
        Panel1.Controls.Add(txtNo)
        Panel1.Controls.Add(txtNotes)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cmbState)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Panel1.Location = New Point(5, 25)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 143)
        Panel1.TabIndex = 15
        ' 
        ' cmbType
        ' 
        cmbType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbType.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbType.FlatStyle = FlatStyle.System
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"فاتورة شراء", "فاتورة بيع", "مرتد فاتورة شراء", "مرتد فاتورة بيع", "سند قبض خارجي", "سند صرف خارجي", "سند قبض داخلي", "سند صرف داخلي", "مخزون أول المدة", "أخرى"})
        cmbType.Location = New Point(411, 16)
        cmbType.Margin = New Padding(3, 4, 3, 4)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(187, 29)
        cmbType.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(605, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 23)
        Label9.TabIndex = 15
        Label9.Text = "نوع القيد"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.ForeColor = Color.DimGray
        Label13.Location = New Point(314, 22)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 23)
        Label13.TabIndex = 5
        Label13.Text = "حالة القيد"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(1019, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 23)
        Label7.TabIndex = 0
        Label7.Text = "رقم القيد"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.ForeColor = Color.DimGray
        Label12.Location = New Point(827, 21)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 23)
        Label12.TabIndex = 0
        Label12.Text = "تاريخ القيد"
        ' 
        ' txtDate
        ' 
        txtDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDate.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(698, 17)
        txtDate.Margin = New Padding(3, 4, 3, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(124, 29)
        txtDate.TabIndex = 1
        txtDate.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' txtNo
        ' 
        txtNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNo.BackColor = Color.White
        txtNo.BorderStyle = BorderStyle.FixedSingle
        txtNo.Location = New Point(906, 17)
        txtNo.Margin = New Padding(3, 4, 3, 4)
        txtNo.Name = "txtNo"
        txtNo.ReadOnly = True
        txtNo.Size = New Size(98, 29)
        txtNo.TabIndex = 0
        txtNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.BorderStyle = BorderStyle.FixedSingle
        txtNotes.Location = New Point(201, 60)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(803, 45)
        txtNotes.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(1017, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 23)
        Label2.TabIndex = 13
        Label2.Text = "بيان القيد"
        ' 
        ' cmbState
        ' 
        cmbState.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbState.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbState.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbState.FlatStyle = FlatStyle.System
        cmbState.FormattingEnabled = True
        cmbState.Items.AddRange(New Object() {"معتمد", "لاغي"})
        cmbState.Location = New Point(201, 17)
        cmbState.Margin = New Padding(3, 4, 3, 4)
        cmbState.Name = "cmbState"
        cmbState.Size = New Size(109, 29)
        cmbState.TabIndex = 2
        ' 
        ' panel2
        ' 
        panel2.BackColor = Color.White
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(ToolStrip2)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(5, 482)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(1129, 70)
        panel2.TabIndex = 14
        ' 
        ' ToolStrip2
        ' 
        ToolStrip2.BackColor = Color.White
        ToolStrip2.Dock = DockStyle.Fill
        ToolStrip2.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip2.ImageScalingSize = New Size(32, 32)
        ToolStrip2.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, ToolStripSeparator3, btnLast, btnNext, btnPrevious, btnFirst, ToolStripSeparator4, btnPrint, btnClose})
        ToolStrip2.Location = New Point(0, 0)
        ToolStrip2.Name = "ToolStrip2"
        ToolStrip2.RenderMode = ToolStripRenderMode.System
        ToolStrip2.RightToLeft = RightToLeft.Yes
        ToolStrip2.Size = New Size(1127, 68)
        ToolStrip2.TabIndex = 2
        ToolStrip2.Text = "ToolStrip2"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.Image = My.Resources.Resources._new
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Margin = New Padding(2)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(50, 60)
        btnNew.Text = "جديد"
        btnNew.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Image = My.Resources.Resources.save
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Margin = New Padding(2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 60)
        btnSave.Text = "حفظ"
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(50, 60)
        btnDelete.Text = "حذف"
        btnDelete.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 68)
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnLast.Image = My.Resources.Resources.last
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Margin = New Padding(2)
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(50, 60)
        btnLast.Text = "الأخير"
        btnLast.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnNext
        ' 
        btnNext.AutoSize = False
        btnNext.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = My.Resources.Resources._next
        btnNext.ImageScaling = ToolStripItemImageScaling.None
        btnNext.ImageTransparentColor = Color.Magenta
        btnNext.Margin = New Padding(2)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(50, 60)
        btnNext.Text = "التالي"
        btnNext.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoSize = False
        btnPrevious.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.Image = My.Resources.Resources.previous
        btnPrevious.ImageScaling = ToolStripItemImageScaling.None
        btnPrevious.ImageTransparentColor = Color.Magenta
        btnPrevious.Margin = New Padding(2)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(50, 60)
        btnPrevious.Text = "السابق"
        btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnFirst
        ' 
        btnFirst.AutoSize = False
        btnFirst.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnFirst.Image = My.Resources.Resources.Firstt
        btnFirst.ImageScaling = ToolStripItemImageScaling.None
        btnFirst.ImageTransparentColor = Color.Magenta
        btnFirst.Margin = New Padding(2)
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(50, 60)
        btnFirst.Text = "الأول"
        btnFirst.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 68)
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.Image = My.Resources.Resources.print
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Margin = New Padding(2)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(50, 60)
        btnPrint.Text = "طباعة"
        btnPrint.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.Image = My.Resources.Resources._exit
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Margin = New Padding(2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 60)
        btnClose.Text = "خروج"
        btnClose.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(247))
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1145, 585)
        TabPage2.TabIndex = 1
        TabPage2.Text = "                    البحــــــــــث              "
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.White
        GroupBox4.Controls.Add(dgvSrch)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.Location = New Point(3, 115)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(10)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(1139, 466)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "نتائج البحث"
        ' 
        ' dgvSrch
        ' 
        dgvSrch.AllowUserToAddRows = False
        dgvSrch.AllowUserToDeleteRows = False
        dgvSrch.AllowUserToOrderColumns = True
        dgvSrch.BackgroundColor = Color.White
        dgvSrch.BorderStyle = BorderStyle.None
        dgvSrch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSrch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvSrch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvSrch.ColumnHeadersHeight = 35
        dgvSrch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSrch.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column5, Column4})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvSrch.DefaultCellStyle = DataGridViewCellStyle7
        dgvSrch.Dock = DockStyle.Fill
        dgvSrch.EnableHeadersVisualStyles = False
        dgvSrch.GridColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        dgvSrch.Location = New Point(10, 32)
        dgvSrch.Margin = New Padding(3, 4, 3, 4)
        dgvSrch.Name = "dgvSrch"
        dgvSrch.ReadOnly = True
        dgvSrch.RowHeadersVisible = False
        dgvSrch.RowHeadersWidth = 51
        dgvSrch.RowTemplate.Height = 30
        dgvSrch.ScrollBars = ScrollBars.Vertical
        dgvSrch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSrch.Size = New Size(1119, 424)
        dgvSrch.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم القيد"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "تاريخ القيد"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "حالة القيد"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "البيان"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 400
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.White
        GroupBox6.Controls.Add(txtNoSrch)
        GroupBox6.Controls.Add(Label8)
        GroupBox6.Controls.Add(txtToDate)
        GroupBox6.Controls.Add(Label10)
        GroupBox6.Controls.Add(txtFromDate)
        GroupBox6.Controls.Add(Label11)
        GroupBox6.Controls.Add(btnSearch)
        GroupBox6.Dock = DockStyle.Top
        GroupBox6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox6.Location = New Point(3, 4)
        GroupBox6.Margin = New Padding(3, 4, 3, 4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 4, 3, 4)
        GroupBox6.RightToLeft = RightToLeft.Yes
        GroupBox6.Size = New Size(1139, 111)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "خيارات البحث"
        ' 
        ' txtNoSrch
        ' 
        txtNoSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNoSrch.BorderStyle = BorderStyle.FixedSingle
        txtNoSrch.Location = New Point(865, 26)
        txtNoSrch.Margin = New Padding(3, 4, 3, 4)
        txtNoSrch.Name = "txtNoSrch"
        txtNoSrch.Size = New Size(141, 29)
        txtNoSrch.TabIndex = 14
        txtNoSrch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(1021, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 23)
        Label8.TabIndex = 13
        Label8.Text = "رقم القيد"
        ' 
        ' txtToDate
        ' 
        txtToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtToDate.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtToDate.Format = DateTimePickerFormat.Short
        txtToDate.Location = New Point(597, 63)
        txtToDate.Margin = New Padding(3, 4, 3, 4)
        txtToDate.Name = "txtToDate"
        txtToDate.Size = New Size(141, 29)
        txtToDate.TabIndex = 1
        txtToDate.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.ForeColor = Color.DimGray
        Label10.Location = New Point(752, 68)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 23)
        Label10.TabIndex = 11
        Label10.Text = "الى تاريخ"
        ' 
        ' txtFromDate
        ' 
        txtFromDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFromDate.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtFromDate.Format = DateTimePickerFormat.Short
        txtFromDate.Location = New Point(865, 63)
        txtFromDate.Margin = New Padding(3, 4, 3, 4)
        txtFromDate.Name = "txtFromDate"
        txtFromDate.Size = New Size(141, 29)
        txtFromDate.TabIndex = 0
        txtFromDate.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.ForeColor = Color.DimGray
        Label11.Location = New Point(1021, 68)
        Label11.Name = "Label11"
        Label11.Size = New Size(70, 23)
        Label11.TabIndex = 12
        Label11.Text = "من تاريخ"
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.White
        btnSearch.Image = My.Resources.Resources.search_icon
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnSearch.Location = New Point(381, 26)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(120, 59)
        btnSearch.TabIndex = 2
        btnSearch.Text = "بحث"
        btnSearch.TextAlign = ContentAlignment.MiddleRight
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' frmAddRestriction
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1153, 619)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmAddRestriction"
        RightToLeft = RightToLeft.Yes
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "ادخال قيد يدوي"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvDetails, ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ToolStrip2.ResumeLayout(False)
        ToolStrip2.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvSrch, ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
