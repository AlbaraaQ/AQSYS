Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCustAccountGet
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button11 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents chkPrev As CheckBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colpono As DataGridViewTextBoxColumn
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdAllClients As RadioButton
    Friend WithEvents rdAllSuppliers As RadioButton
    Friend WithEvents rdByDate As RadioButton
    Friend WithEvents rdByID As RadioButton
    Friend WithEvents txtBalance1 As TextBox
    Friend WithEvents txtBalance2 As TextBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtTotCredit As TextBox
    Friend WithEvents txtTotDept As TextBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustAccountGet))
        GroupBox2 = New GroupBox()
        dgvSrch = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewButtonColumn()
        colBalance = New DataGridViewTextBoxColumn()
        colpono = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        txtBalance2 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        txtTotCredit = New TextBox()
        txtBalance1 = New TextBox()
        txtTotDept = New TextBox()
        GroupBox1 = New GroupBox()
        chkPrev = New CheckBox()
        chkOpen = New CheckBox()
        Button11 = New Button()
        txtNo = New TextBox()
        Panel1 = New Panel()
        rdByID = New RadioButton()
        rdByDate = New RadioButton()
        rdAllSuppliers = New RadioButton()
        rdAll = New RadioButton()
        rdAllClients = New RadioButton()
        chkAll = New CheckBox()
        btnClose = New Button()
        txtDateTo = New DateTimePicker()
        btnPrint = New Button()
        txtDateFrom = New DateTimePicker()
        btnPreview = New Button()
        Label4 = New Label()
        btnShow = New Button()
        Label3 = New Label()
        cmbClients = New ComboBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvSrch)
        GroupBox2.Controls.Add(Panel3)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 175)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1210, 432)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "كشف الحساب"
        ' 
        ' dgvSrch
        ' 
        dgvSrch.AllowUserToAddRows = False
        dgvSrch.AllowUserToDeleteRows = False
        dgvSrch.AllowUserToOrderColumns = True
        dgvSrch.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSrch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSrch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSrch.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column5, Column7, Column6, Column2, colBalance, colpono})
        dgvSrch.Dock = DockStyle.Fill
        dgvSrch.Location = New Point(3, 21)
        dgvSrch.Margin = New Padding(3, 4, 3, 4)
        dgvSrch.MultiSelect = False
        dgvSrch.Name = "dgvSrch"
        dgvSrch.ReadOnly = True
        dgvSrch.RowHeadersVisible = False
        dgvSrch.RowHeadersWidth = 51
        dgvSrch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSrch.Size = New Size(1204, 348)
        dgvSrch.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "مدين"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "دائن"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "رقم القيد"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "تاريخ القيد"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "رقم الفاتورة"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "البيان"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 250
        ' 
        ' Column2
        ' 
        Column2.HeaderText = ""
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.True
        Column2.SortMode = DataGridViewColumnSortMode.Automatic
        Column2.Text = "view"
        Column2.ToolTipText = "عرض القيد"
        Column2.UseColumnTextForButtonValue = True
        Column2.Width = 80
        ' 
        ' colBalance
        ' 
        colBalance.HeaderText = "الرصيد"
        colBalance.MinimumWidth = 6
        colBalance.Name = "colBalance"
        colBalance.ReadOnly = True
        colBalance.Width = 125
        ' 
        ' colpono
        ' 
        colpono.HeaderText = "Po No"
        colpono.MinimumWidth = 6
        colpono.Name = "colpono"
        colpono.ReadOnly = True
        colpono.Visible = False
        colpono.Width = 120
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(txtBalance2)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(txtTotCredit)
        Panel3.Controls.Add(txtBalance1)
        Panel3.Controls.Add(txtTotDept)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(3, 369)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1204, 59)
        Panel3.TabIndex = 3
        ' 
        ' txtBalance2
        ' 
        txtBalance2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBalance2.BorderStyle = BorderStyle.FixedSingle
        txtBalance2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtBalance2.Location = New Point(1001, 31)
        txtBalance2.Margin = New Padding(3, 4, 3, 4)
        txtBalance2.Name = "txtBalance2"
        txtBalance2.ReadOnly = True
        txtBalance2.Size = New Size(100, 27)
        txtBalance2.TabIndex = 3
        txtBalance2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(92, 31)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(907, 27)
        TextBox5.TabIndex = 2
        TextBox5.Text = "الدين المتبقي "
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(92, 5)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(907, 24)
        TextBox4.TabIndex = 2
        TextBox4.Text = "تسديد"
        ' 
        ' txtTotCredit
        ' 
        txtTotCredit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotCredit.BorderStyle = BorderStyle.FixedSingle
        txtTotCredit.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotCredit.Location = New Point(1001, 1)
        txtTotCredit.Margin = New Padding(3, 4, 3, 4)
        txtTotCredit.Name = "txtTotCredit"
        txtTotCredit.ReadOnly = True
        txtTotCredit.Size = New Size(100, 27)
        txtTotCredit.TabIndex = 1
        txtTotCredit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBalance1
        ' 
        txtBalance1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBalance1.BorderStyle = BorderStyle.FixedSingle
        txtBalance1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtBalance1.Location = New Point(1103, 31)
        txtBalance1.Margin = New Padding(3, 4, 3, 4)
        txtBalance1.Name = "txtBalance1"
        txtBalance1.ReadOnly = True
        txtBalance1.Size = New Size(100, 27)
        txtBalance1.TabIndex = 2
        txtBalance1.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTotDept
        ' 
        txtTotDept.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotDept.BorderStyle = BorderStyle.FixedSingle
        txtTotDept.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotDept.Location = New Point(1103, 1)
        txtTotDept.Margin = New Padding(3, 4, 3, 4)
        txtTotDept.Name = "txtTotDept"
        txtTotDept.ReadOnly = True
        txtTotDept.Size = New Size(100, 27)
        txtTotDept.TabIndex = 0
        txtTotDept.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkPrev)
        GroupBox1.Controls.Add(chkOpen)
        GroupBox1.Controls.Add(Button11)
        GroupBox1.Controls.Add(txtNo)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(rdAllSuppliers)
        GroupBox1.Controls.Add(rdAll)
        GroupBox1.Controls.Add(rdAllClients)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cmbClients)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1210, 175)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "كشف حساب عميل "
        ' 
        ' chkPrev
        ' 
        chkPrev.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkPrev.AutoSize = True
        chkPrev.Checked = True
        chkPrev.CheckState = CheckState.Checked
        chkPrev.ImeMode = ImeMode.NoControl
        chkPrev.Location = New Point(154, 22)
        chkPrev.Margin = New Padding(3, 4, 3, 4)
        chkPrev.Name = "chkPrev"
        chkPrev.Size = New Size(106, 21)
        chkPrev.TabIndex = 208
        chkPrev.Text = "رصيد سابق"
        chkPrev.UseVisualStyleBackColor = True
        ' 
        ' chkOpen
        ' 
        chkOpen.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkOpen.AutoSize = True
        chkOpen.Checked = True
        chkOpen.CheckState = CheckState.Checked
        chkOpen.ImeMode = ImeMode.NoControl
        chkOpen.Location = New Point(259, 22)
        chkOpen.Margin = New Padding(3, 4, 3, 4)
        chkOpen.Name = "chkOpen"
        chkOpen.Size = New Size(120, 21)
        chkOpen.TabIndex = 209
        chkOpen.Text = "رصيد افتتاحي"
        chkOpen.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.ImeMode = ImeMode.NoControl
        Button11.Location = New Point(791, 46)
        Button11.Margin = New Padding(3, 4, 3, 4)
        Button11.Name = "Button11"
        Button11.Size = New Size(37, 31)
        Button11.TabIndex = 207
        Button11.UseVisualStyleBackColor = True
        ' 
        ' txtNo
        ' 
        txtNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNo.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtNo.Location = New Point(1041, 48)
        txtNo.Margin = New Padding(3, 4, 3, 4)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(75, 24)
        txtNo.TabIndex = 26
        txtNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.Controls.Add(rdByID)
        Panel1.Controls.Add(rdByDate)
        Panel1.Location = New Point(414, 7)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 48)
        Panel1.TabIndex = 12
        ' 
        ' rdByID
        ' 
        rdByID.AutoSize = True
        rdByID.Checked = True
        rdByID.ImeMode = ImeMode.NoControl
        rdByID.Location = New Point(150, 14)
        rdByID.Margin = New Padding(3, 4, 3, 4)
        rdByID.Name = "rdByID"
        rdByID.Size = New Size(133, 21)
        rdByID.TabIndex = 12
        rdByID.TabStop = True
        rdByID.Text = "ترتيب برقم القيد"
        rdByID.UseVisualStyleBackColor = True
        ' 
        ' rdByDate
        ' 
        rdByDate.AutoSize = True
        rdByDate.ImeMode = ImeMode.NoControl
        rdByDate.Location = New Point(13, 14)
        rdByDate.Margin = New Padding(3, 4, 3, 4)
        rdByDate.Name = "rdByDate"
        rdByDate.Size = New Size(140, 21)
        rdByDate.TabIndex = 13
        rdByDate.Text = "ترتيب بتاريخ القيد"
        rdByDate.UseVisualStyleBackColor = True
        ' 
        ' rdAllSuppliers
        ' 
        rdAllSuppliers.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAllSuppliers.AutoSize = True
        rdAllSuppliers.ImeMode = ImeMode.NoControl
        rdAllSuppliers.Location = New Point(823, 15)
        rdAllSuppliers.Margin = New Padding(3, 4, 3, 4)
        rdAllSuppliers.Name = "rdAllSuppliers"
        rdAllSuppliers.Size = New Size(76, 21)
        rdAllSuppliers.TabIndex = 11
        rdAllSuppliers.Text = "موردين"
        rdAllSuppliers.UseVisualStyleBackColor = True
        ' 
        ' rdAll
        ' 
        rdAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAll.AutoSize = True
        rdAll.Checked = True
        rdAll.ImeMode = ImeMode.NoControl
        rdAll.Location = New Point(983, 15)
        rdAll.Margin = New Padding(3, 4, 3, 4)
        rdAll.Name = "rdAll"
        rdAll.Size = New Size(57, 21)
        rdAll.TabIndex = 11
        rdAll.TabStop = True
        rdAll.Text = "الكل"
        rdAll.UseVisualStyleBackColor = True
        ' 
        ' rdAllClients
        ' 
        rdAllClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAllClients.AutoSize = True
        rdAllClients.Location = New Point(901, 15)
        rdAllClients.Margin = New Padding(3, 4, 3, 4)
        rdAllClients.Name = "rdAllClients"
        rdAllClients.Size = New Size(64, 21)
        rdAllClients.TabIndex = 11
        rdAllClients.Text = "عملاء"
        rdAllClients.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(978, 75)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 10
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(445, 103)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(157, 55)
        btnClose.TabIndex = 6
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(359, 59)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(127, 24)
        txtDateTo.TabIndex = 2
        txtDateTo.Value = New Date(2012, 9, 26, 0, 0, 0, 0)
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(608, 103)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(157, 55)
        btnPrint.TabIndex = 5
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(575, 59)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(130, 24)
        txtDateFrom.TabIndex = 1
        txtDateFrom.Value = New Date(2012, 9, 26, 0, 0, 0, 0)
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(771, 103)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(157, 55)
        btnPreview.TabIndex = 4
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(491, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 9
        Label4.Text = "الي تاريخ"
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(935, 103)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(157, 55)
        btnShow.TabIndex = 3
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(706, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 8
        Label3.Text = "من تاريخ"
        ' 
        ' cmbClients
        ' 
        cmbClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.FormattingEnabled = True
        cmbClients.Location = New Point(827, 48)
        cmbClients.Margin = New Padding(3, 4, 3, 4)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(212, 24)
        cmbClients.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(1123, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 0
        Label1.Text = "اسم العميل"
        ' 
        ' frmCustAccountGet
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1210, 607)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCustAccountGet"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "كشف حساب لعميل"
        GroupBox2.ResumeLayout(False)
        CType(dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
