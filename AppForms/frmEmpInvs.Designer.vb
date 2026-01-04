Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmEmpInvs
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbEmps As ComboBox
    Friend WithEvents cmbProcType As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdAgel As RadioButton
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdCash As RadioButton
    Friend WithEvents rdNetwork As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSum As TextBox
    Friend WithEvents txtSumAgel As TextBox
    Friend WithEvents txtSumCash As TextBox
    Friend WithEvents txtSumNetwork As TextBox
    Friend WithEvents txtSumTab3 As TextBox
    Friend WithEvents txtSumVAT As TextBox

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
        rdAgel = New RadioButton()
        rdNetwork = New RadioButton()
        rdCash = New RadioButton()
        rdAll = New RadioButton()
        chkAll = New CheckBox()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        txtDateFrom = New DateTimePicker()
        Label4 = New Label()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        btnShow = New Button()
        cmbEmps = New ComboBox()
        cmbProcType = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        txtSum = New TextBox()
        txtSumAgel = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        txtSumVAT = New TextBox()
        txtSumNetwork = New TextBox()
        Label10 = New Label()
        txtSumTab3 = New TextBox()
        Label6 = New Label()
        Label9 = New Label()
        txtSumCash = New TextBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewButtonColumn()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdAgel)
        GroupBox1.Controls.Add(rdNetwork)
        GroupBox1.Controls.Add(rdCash)
        GroupBox1.Controls.Add(rdAll)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbEmps)
        GroupBox1.Controls.Add(cmbProcType)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1077, 159)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل بيانات البحث"
        ' 
        ' rdAgel
        ' 
        rdAgel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAgel.AutoSize = True
        rdAgel.ImeMode = ImeMode.NoControl
        rdAgel.Location = New Point(17, 34)
        rdAgel.Margin = New Padding(3, 4, 3, 4)
        rdAgel.Name = "rdAgel"
        rdAgel.Size = New Size(55, 21)
        rdAgel.TabIndex = 37
        rdAgel.Text = "آجل"
        rdAgel.UseVisualStyleBackColor = True
        ' 
        ' rdNetwork
        ' 
        rdNetwork.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdNetwork.AutoSize = True
        rdNetwork.ImeMode = ImeMode.NoControl
        rdNetwork.Location = New Point(86, 34)
        rdNetwork.Margin = New Padding(3, 4, 3, 4)
        rdNetwork.Name = "rdNetwork"
        rdNetwork.Size = New Size(66, 21)
        rdNetwork.TabIndex = 37
        rdNetwork.Text = "شبكة"
        rdNetwork.UseVisualStyleBackColor = True
        ' 
        ' rdCash
        ' 
        rdCash.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdCash.AutoSize = True
        rdCash.ImeMode = ImeMode.NoControl
        rdCash.Location = New Point(158, 36)
        rdCash.Margin = New Padding(3, 4, 3, 4)
        rdCash.Name = "rdCash"
        rdCash.Size = New Size(64, 21)
        rdCash.TabIndex = 37
        rdCash.Text = "نقدي"
        rdCash.UseVisualStyleBackColor = True
        ' 
        ' rdAll
        ' 
        rdAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAll.AutoSize = True
        rdAll.Checked = True
        rdAll.Location = New Point(230, 36)
        rdAll.Margin = New Padding(3, 4, 3, 4)
        rdAll.Name = "rdAll"
        rdAll.Size = New Size(57, 21)
        rdAll.TabIndex = 37
        rdAll.TabStop = True
        rdAll.Text = "الكل"
        rdAll.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(727, 55)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 36
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CustomFormat = "dd/MM/yyyy hh:mm tt"
        txtDateTo.Format = DateTimePickerFormat.Custom
        txtDateTo.Location = New Point(315, 54)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(196, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(517, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 13
        Label3.Text = "الى تاريخ"
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CustomFormat = "dd/MM/yyyy hh:mm tt"
        txtDateFrom.Format = DateTimePickerFormat.Custom
        txtDateFrom.Location = New Point(315, 21)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(196, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(521, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 12
        Label4.Text = "من تاريخ"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(237, 92)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(157, 55)
        btnClose.TabIndex = 7
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(400, 92)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(157, 55)
        btnPrint.TabIndex = 6
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(563, 92)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(157, 55)
        btnPreview.TabIndex = 5
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(727, 92)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(157, 55)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbEmps
        ' 
        cmbEmps.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbEmps.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbEmps.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbEmps.FormattingEnabled = True
        cmbEmps.Location = New Point(597, 28)
        cmbEmps.Margin = New Padding(3, 4, 3, 4)
        cmbEmps.Name = "cmbEmps"
        cmbEmps.Size = New Size(191, 24)
        cmbEmps.TabIndex = 1
        ' 
        ' cmbProcType
        ' 
        cmbProcType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbProcType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProcType.FormattingEnabled = True
        cmbProcType.Items.AddRange(New Object() {"مشتريات", "مبيعات"})
        cmbProcType.Location = New Point(858, 30)
        cmbProcType.Margin = New Padding(3, 4, 3, 4)
        cmbProcType.Name = "cmbProcType"
        cmbProcType.Size = New Size(89, 24)
        cmbProcType.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(792, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 17)
        Label2.TabIndex = 1
        Label2.Text = "الموظف"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(951, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 0
        Label1.Text = "نوع الحركة"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtSum)
        Panel1.Controls.Add(txtSumAgel)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtSumVAT)
        Panel1.Controls.Add(txtSumNetwork)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtSumTab3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtSumCash)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 506)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1077, 90)
        Panel1.TabIndex = 4
        ' 
        ' txtSum
        ' 
        txtSum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSum.BackColor = SystemColors.Control
        txtSum.BorderStyle = BorderStyle.None
        txtSum.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSum.ForeColor = Color.Red
        txtSum.Location = New Point(14, 47)
        txtSum.Margin = New Padding(3, 4, 3, 4)
        txtSum.Multiline = True
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(125, 33)
        txtSum.TabIndex = 0
        txtSum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumAgel
        ' 
        txtSumAgel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumAgel.BackColor = SystemColors.Control
        txtSumAgel.BorderStyle = BorderStyle.None
        txtSumAgel.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumAgel.ForeColor = Color.Red
        txtSumAgel.Location = New Point(299, 47)
        txtSumAgel.Margin = New Padding(3, 4, 3, 4)
        txtSumAgel.Multiline = True
        txtSumAgel.Name = "txtSumAgel"
        txtSumAgel.Size = New Size(125, 33)
        txtSumAgel.TabIndex = 0
        txtSumAgel.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(141, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 33)
        Label8.TabIndex = 3
        Label8.Text = "الإجمالي"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(426, 47)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 33)
        Label7.TabIndex = 3
        Label7.Text = "إجمالي آجل"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumVAT
        ' 
        txtSumVAT.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumVAT.BackColor = SystemColors.Control
        txtSumVAT.BorderStyle = BorderStyle.None
        txtSumVAT.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumVAT.ForeColor = Color.Red
        txtSumVAT.Location = New Point(557, 7)
        txtSumVAT.Margin = New Padding(3, 4, 3, 4)
        txtSumVAT.Multiline = True
        txtSumVAT.Name = "txtSumVAT"
        txtSumVAT.Size = New Size(125, 33)
        txtSumVAT.TabIndex = 0
        txtSumVAT.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumNetwork
        ' 
        txtSumNetwork.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumNetwork.BackColor = SystemColors.Control
        txtSumNetwork.BorderStyle = BorderStyle.None
        txtSumNetwork.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumNetwork.ForeColor = Color.Red
        txtSumNetwork.Location = New Point(557, 48)
        txtSumNetwork.Margin = New Padding(3, 4, 3, 4)
        txtSumNetwork.Multiline = True
        txtSumNetwork.Name = "txtSumNetwork"
        txtSumNetwork.Size = New Size(125, 33)
        txtSumNetwork.TabIndex = 0
        txtSumNetwork.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.BackColor = SystemColors.Control
        Label10.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ImeMode = ImeMode.NoControl
        Label10.Location = New Point(681, 7)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 33)
        Label10.TabIndex = 3
        Label10.Text = "إجمالي VAT"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumTab3
        ' 
        txtSumTab3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumTab3.BackColor = SystemColors.Control
        txtSumTab3.BorderStyle = BorderStyle.None
        txtSumTab3.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumTab3.ForeColor = Color.Red
        txtSumTab3.Location = New Point(826, 6)
        txtSumTab3.Margin = New Padding(3, 4, 3, 4)
        txtSumTab3.Multiline = True
        txtSumTab3.Name = "txtSumTab3"
        txtSumTab3.Size = New Size(113, 33)
        txtSumTab3.TabIndex = 0
        txtSumTab3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(681, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 33)
        Label6.TabIndex = 3
        Label6.Text = "إجمالي شبكة"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.BackColor = SystemColors.Control
        Label9.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ImeMode = ImeMode.NoControl
        Label9.Location = New Point(939, 6)
        Label9.Name = "Label9"
        Label9.Size = New Size(134, 33)
        Label9.TabIndex = 3
        Label9.Text = "إجمالي رسوم تبغ"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumCash
        ' 
        txtSumCash.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumCash.BackColor = SystemColors.Control
        txtSumCash.BorderStyle = BorderStyle.None
        txtSumCash.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumCash.ForeColor = Color.Red
        txtSumCash.Location = New Point(826, 47)
        txtSumCash.Margin = New Padding(3, 4, 3, 4)
        txtSumCash.Multiline = True
        txtSumCash.Name = "txtSumCash"
        txtSumCash.Size = New Size(125, 33)
        txtSumCash.TabIndex = 0
        txtSumCash.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(951, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 33)
        Label5.TabIndex = 3
        Label5.Text = "إجمالي نقدي"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 159)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1077, 347)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column9, Column7})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(1071, 322)
        dgvItems.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "نوع الحركة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "التاريخ"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "رقم الفاتورة"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الصنف"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الكمية"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "السعر"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 120
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "الاجمالي"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "عرض"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        Column7.Text = "view"
        Column7.ToolTipText = "عرض الفاتورة"
        Column7.UseColumnTextForButtonValue = True
        Column7.Width = 120
        ' 
        ' frmEmpInvs
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 596)
        Controls.Add(GroupBox2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmEmpInvs"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "مبيعات ومشتريات موظف خلال الفترة"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
