Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCurrencyDetails
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents bntShow As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkType1 As CheckBox
    Friend WithEvents chkType2 As CheckBox
    Friend WithEvents chkType3 As CheckBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbSafes As ComboBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents pnlItemType As GroupBox
    Friend WithEvents txtCurrencyNo As TextBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker

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
        components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        ProgressBar1 = New ProgressBar()
        pnlItemType = New GroupBox()
        chkType3 = New CheckBox()
        chkType2 = New CheckBox()
        chkType1 = New CheckBox()
        chkAll = New CheckBox()
        btnClose = New Button()
        btnPreview = New Button()
        btnPrint = New Button()
        bntShow = New Button()
        txtDateFrom = New DateTimePicker()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        txtCurrencyNo = New TextBox()
        cmbCurrency = New ComboBox()
        Label5 = New Label()
        Label2 = New Label()
        cmbSafes = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewButtonColumn()
        timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        pnlItemType.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(pnlItemType)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(bntShow)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtCurrencyNo)
        GroupBox1.Controls.Add(cmbCurrency)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cmbSafes)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1063, 175)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.ImeMode = ImeMode.NoControl
        ProgressBar1.Location = New Point(3, 143)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1057, 28)
        ProgressBar1.TabIndex = 38
        ' 
        ' pnlItemType
        ' 
        pnlItemType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlItemType.Controls.Add(chkType3)
        pnlItemType.Controls.Add(chkType2)
        pnlItemType.Controls.Add(chkType1)
        pnlItemType.Location = New Point(418, 10)
        pnlItemType.Margin = New Padding(3, 4, 3, 4)
        pnlItemType.Name = "pnlItemType"
        pnlItemType.Padding = New Padding(3, 4, 3, 4)
        pnlItemType.Size = New Size(282, 60)
        pnlItemType.TabIndex = 37
        pnlItemType.TabStop = False
        pnlItemType.Text = "نوع الصنف"
        ' 
        ' chkType3
        ' 
        chkType3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkType3.AutoSize = True
        chkType3.Checked = True
        chkType3.CheckState = CheckState.Checked
        chkType3.ImeMode = ImeMode.NoControl
        chkType3.Location = New Point(13, 27)
        chkType3.Margin = New Padding(3, 4, 3, 4)
        chkType3.Name = "chkType3"
        chkType3.Size = New Size(81, 21)
        chkType3.TabIndex = 0
        chkType3.Text = "مصنعي"
        chkType3.UseVisualStyleBackColor = True
        ' 
        ' chkType2
        ' 
        chkType2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkType2.AutoSize = True
        chkType2.Checked = True
        chkType2.CheckState = CheckState.Checked
        chkType2.ImeMode = ImeMode.NoControl
        chkType2.Location = New Point(103, 27)
        chkType2.Margin = New Padding(3, 4, 3, 4)
        chkType2.Name = "chkType2"
        chkType2.Size = New Size(55, 21)
        chkType2.TabIndex = 0
        chkType2.Text = "خام"
        chkType2.UseVisualStyleBackColor = True
        ' 
        ' chkType1
        ' 
        chkType1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkType1.AutoSize = True
        chkType1.Checked = True
        chkType1.CheckState = CheckState.Checked
        chkType1.ImeMode = ImeMode.NoControl
        chkType1.Location = New Point(165, 27)
        chkType1.Margin = New Padding(3, 4, 3, 4)
        chkType1.Name = "chkType1"
        chkType1.Size = New Size(77, 21)
        chkType1.TabIndex = 0
        chkType1.Text = "مخزني"
        chkType1.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(811, 55)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 36
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(34, 82)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(82, 33)
        btnClose.TabIndex = 33
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(214, 84)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(80, 33)
        btnPreview.TabIndex = 31
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(123, 84)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(83, 33)
        btnPrint.TabIndex = 32
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' bntShow
        ' 
        bntShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        bntShow.Location = New Point(301, 84)
        bntShow.Margin = New Padding(3, 4, 3, 4)
        bntShow.Name = "bntShow"
        bntShow.Size = New Size(79, 33)
        bntShow.TabIndex = 30
        bntShow.Text = "عرض"
        bntShow.UseVisualStyleBackColor = True
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(735, 92)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(134, 24)
        txtDateFrom.TabIndex = 19
        txtDateFrom.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(494, 92)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(126, 24)
        txtDateTo.TabIndex = 20
        txtDateTo.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(880, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 17)
        Label3.TabIndex = 17
        Label3.Text = "من التاريــــخ"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(627, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 17)
        Label4.TabIndex = 18
        Label4.Text = "الي التاريــــخ"
        ' 
        ' txtCurrencyNo
        ' 
        txtCurrencyNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCurrencyNo.Location = New Point(237, 32)
        txtCurrencyNo.Margin = New Padding(3, 4, 3, 4)
        txtCurrencyNo.Name = "txtCurrencyNo"
        txtCurrencyNo.Size = New Size(107, 24)
        txtCurrencyNo.TabIndex = 8
        txtCurrencyNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrency.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(26, 31)
        cmbCurrency.Margin = New Padding(3, 4, 3, 4)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(209, 24)
        cmbCurrency.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(223, 12)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(152, 17)
        Label5.TabIndex = 6
        Label5.Text = "رقم الصنف / التشغيلة"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(120, 10)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(51, 17)
        Label2.TabIndex = 6
        Label2.Text = "الصنف"
        ' 
        ' cmbSafes
        ' 
        cmbSafes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbSafes.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSafes.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSafes.FormattingEnabled = True
        cmbSafes.Location = New Point(735, 26)
        cmbSafes.Margin = New Padding(3, 4, 3, 4)
        cmbSafes.Name = "cmbSafes"
        cmbSafes.Size = New Size(134, 24)
        cmbSafes.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(902, 31)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(55, 17)
        Label1.TabIndex = 4
        Label1.Text = "المخزن"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 175)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1063, 442)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "بيانات الحركة"
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.AllowUserToOrderColumns = True
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(1057, 417)
        dgvItems.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "نوع الحركة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 120
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "المخزن"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "رقم الفاتورة"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "التاريخ"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الكمية"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "السعر"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 70
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "الاجمالي"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 120
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "عرض"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Text = "view"
        Column8.UseColumnTextForButtonValue = True
        Column8.Width = 120
        ' 
        ' timer1
        ' 
        timer1.Enabled = True
        ' 
        ' frmCurrencyDetails
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 617)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCurrencyDetails"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "حركة صنف محددة"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        pnlItemType.ResumeLayout(False)
        pnlItemType.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
