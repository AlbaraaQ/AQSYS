Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmEmpSalaryAddSub
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
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
    Friend WithEvents chkAllEmp As CheckBox
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents cmbEmpSrch As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtVal As TextBox

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
        GroupBox1 = New GroupBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox2 = New GroupBox()
        txtDate = New DateTimePicker()
        txtNotes = New TextBox()
        Label5 = New Label()
        txtVal = New TextBox()
        cmbType = New ComboBox()
        cmbEmp = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvSrch = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        GroupBox6 = New GroupBox()
        chkAllEmp = New CheckBox()
        cmbEmpSrch = New ComboBox()
        Label8 = New Label()
        txtToDate = New DateTimePicker()
        Label2 = New Label()
        txtFromDate = New DateTimePicker()
        Label1 = New Label()
        btnSearch = New Button()
        panel2 = New Panel()
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
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        panel2.SuspendLayout()
        toolStrip1.SuspendLayout()
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
        GroupBox1.Size = New Size(704, 425)
        GroupBox1.TabIndex = 13
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
        TabControl1.Size = New Size(698, 400)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(690, 371)
        TabPage1.TabIndex = 0
        TabPage1.Text = "                   الحوافز والجزاءات والسلف                   "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtDate)
        GroupBox2.Controls.Add(txtNotes)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtVal)
        GroupBox2.Controls.Add(cmbType)
        GroupBox2.Controls.Add(cmbEmp)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(3, 4)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(684, 363)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' txtDate
        ' 
        txtDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(405, 123)
        txtDate.Margin = New Padding(3, 4, 3, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(156, 24)
        txtDate.TabIndex = 2
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(91, 180)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(470, 48)
        txtNotes.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(572, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 8
        Label5.Text = "ملاحظات"
        ' 
        ' txtVal
        ' 
        txtVal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtVal.Location = New Point(91, 123)
        txtVal.Margin = New Padding(3, 4, 3, 4)
        txtVal.Name = "txtVal"
        txtVal.Size = New Size(130, 24)
        txtVal.TabIndex = 3
        ' 
        ' cmbType
        ' 
        cmbType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbType.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(91, 70)
        cmbType.Margin = New Padding(3, 4, 3, 4)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(130, 25)
        cmbType.TabIndex = 1
        ' 
        ' cmbEmp
        ' 
        cmbEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbEmp.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbEmp.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbEmp.FormattingEnabled = True
        cmbEmp.Location = New Point(336, 73)
        cmbEmp.Margin = New Padding(3, 4, 3, 4)
        cmbEmp.Name = "cmbEmp"
        cmbEmp.Size = New Size(226, 25)
        cmbEmp.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(228, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 17)
        Label4.TabIndex = 3
        Label4.Text = "المبلغ"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(586, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 17)
        Label3.TabIndex = 2
        Label3.Text = "التاريخ"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(233, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 1
        Label6.Text = "النوع"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(577, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 17)
        Label7.TabIndex = 0
        Label7.Text = "الموظف"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(689, 364)
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
        GroupBox4.Location = New Point(3, 109)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(683, 251)
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSrch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSrch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSrch.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, Column11, Column1, Column2, Column4, Column3})
        dgvSrch.Dock = DockStyle.Fill
        dgvSrch.Location = New Point(3, 21)
        dgvSrch.Margin = New Padding(3, 4, 3, 4)
        dgvSrch.Name = "dgvSrch"
        dgvSrch.RowHeadersWidth = 51
        dgvSrch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSrch.Size = New Size(677, 226)
        dgvSrch.TabIndex = 0
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "الرقم"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Visible = False
        DataGridViewTextBoxColumn1.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "رقم الموظف"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Visible = False
        Column11.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "اسم الموظف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "القيمة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "النوع"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 120
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "التاريخ"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.LightBlue
        GroupBox6.Controls.Add(chkAllEmp)
        GroupBox6.Controls.Add(cmbEmpSrch)
        GroupBox6.Controls.Add(Label8)
        GroupBox6.Controls.Add(txtToDate)
        GroupBox6.Controls.Add(Label2)
        GroupBox6.Controls.Add(txtFromDate)
        GroupBox6.Controls.Add(Label1)
        GroupBox6.Controls.Add(btnSearch)
        GroupBox6.Dock = DockStyle.Top
        GroupBox6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox6.Location = New Point(3, 4)
        GroupBox6.Margin = New Padding(3, 4, 3, 4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 4, 3, 4)
        GroupBox6.RightToLeft = RightToLeft.Yes
        GroupBox6.Size = New Size(683, 105)
        GroupBox6.TabIndex = 10
        GroupBox6.TabStop = False
        GroupBox6.Text = "البحث"
        ' 
        ' chkAllEmp
        ' 
        chkAllEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllEmp.AutoSize = True
        chkAllEmp.Location = New Point(551, 63)
        chkAllEmp.Margin = New Padding(3, 4, 3, 4)
        chkAllEmp.Name = "chkAllEmp"
        chkAllEmp.Size = New Size(58, 21)
        chkAllEmp.TabIndex = 10
        chkAllEmp.Text = "الكل"
        chkAllEmp.UseVisualStyleBackColor = True
        ' 
        ' cmbEmpSrch
        ' 
        cmbEmpSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbEmpSrch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbEmpSrch.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbEmpSrch.FormattingEnabled = True
        cmbEmpSrch.Location = New Point(416, 33)
        cmbEmpSrch.Margin = New Padding(3, 4, 3, 4)
        cmbEmpSrch.Name = "cmbEmpSrch"
        cmbEmpSrch.Size = New Size(193, 25)
        cmbEmpSrch.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(613, 39)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 17)
        Label8.TabIndex = 8
        Label8.Text = "الموظف"
        ' 
        ' txtToDate
        ' 
        txtToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtToDate.Format = DateTimePickerFormat.Short
        txtToDate.Location = New Point(162, 63)
        txtToDate.Margin = New Padding(3, 4, 3, 4)
        txtToDate.Name = "txtToDate"
        txtToDate.Size = New Size(141, 24)
        txtToDate.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(316, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 17)
        Label2.TabIndex = 6
        Label2.Text = "الى تاريخ"
        ' 
        ' txtFromDate
        ' 
        txtFromDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFromDate.Format = DateTimePickerFormat.Short
        txtFromDate.Location = New Point(162, 30)
        txtFromDate.Margin = New Padding(3, 4, 3, 4)
        txtFromDate.Name = "txtFromDate"
        txtFromDate.Size = New Size(141, 24)
        txtFromDate.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(321, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 17)
        Label1.TabIndex = 6
        Label1.Text = "من تاريخ"
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Lime
        btnSearch.Image = My.Resources.Resources.search_icon
        btnSearch.Location = New Point(24, 31)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(102, 59)
        btnSearch.TabIndex = 3
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 425)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(704, 67)
        panel2.TabIndex = 14
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(702, 65)
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
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(50, 50)
        btnDelete.Text = "حذف"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnLast.Image = My.Resources.Resources.last
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
        btnNext.Image = My.Resources.Resources._next
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
        btnPrevious.Image = My.Resources.Resources.previous
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
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrint.Image = My.Resources.Resources.print
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(50, 50)
        btnPrint.Text = "طباعة"
        btnPrint.Visible = False
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
        ' frmEmpSalaryAddSub
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 492)
        Controls.Add(GroupBox1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmEmpSalaryAddSub"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "الحوافز والجزاءات والسلف"
        GroupBox1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
