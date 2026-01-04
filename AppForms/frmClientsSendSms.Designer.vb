Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmClientsSendSms
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllAreas As CheckBox
    Friend WithEvents chkAllCities As CheckBox
    Friend WithEvents chkBothCond As CheckBox
    Friend WithEvents chkJoinDate As CheckBox
    Friend WithEvents chkMaintDate As CheckBox
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtMaintFromDate As DateTimePicker
    Friend WithEvents txtMaintToDate As DateTimePicker

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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        dgvData = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        chkAllAreas = New CheckBox()
        chkMaintDate = New CheckBox()
        chkJoinDate = New CheckBox()
        chkAllCities = New CheckBox()
        Label6 = New Label()
        cmbCity = New ComboBox()
        Label9 = New Label()
        cmbArea = New ComboBox()
        timer1 = New Timer(components)
        btnPreview = New Button()
        btnShow = New Button()
        txtMaintFromDate = New DateTimePicker()
        txtMaintToDate = New DateTimePicker()
        txtDateFrom = New DateTimePicker()
        GroupBox1 = New GroupBox()
        chkBothCond = New CheckBox()
        btnPrint = New Button()
        Button2 = New Button()
        lblCount = New Label()
        lblStatus = New Label()
        Label1 = New Label()
        txtDateTo = New DateTimePicker()
        Label2 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvData)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 100)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(992, 239)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvData.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {Column8, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column9})
        dgvData.Dock = DockStyle.Fill
        dgvData.Location = New Point(3, 20)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.RowHeadersWidth = 51
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(986, 116)
        dgvData.TabIndex = 3
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "id"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Visible = False
        Column8.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم العميل"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 90
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "إسم العميل"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 170
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Column3.DefaultCellStyle = DataGridViewCellStyle2
        Column3.HeaderText = "رقم الجوال"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 120
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "المدينة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 120
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الحي"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 120
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "تاريخ الاشتراك"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "تاريخ الزيارة"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "آخر إرسال"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 136)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(986, 100)
        Panel1.TabIndex = 2
        Panel1.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.Location = New Point(3, 74)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(986, 23)
        ProgressBar1.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(792, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 23
        Button1.Text = "خروج"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' chkAllAreas
        ' 
        chkAllAreas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllAreas.AutoSize = True
        chkAllAreas.Checked = True
        chkAllAreas.CheckState = CheckState.Checked
        chkAllAreas.Location = New Point(838, 149)
        chkAllAreas.Name = "chkAllAreas"
        chkAllAreas.Size = New Size(58, 21)
        chkAllAreas.TabIndex = 22
        chkAllAreas.Text = "الكل"
        chkAllAreas.UseVisualStyleBackColor = True
        ' 
        ' chkMaintDate
        ' 
        chkMaintDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkMaintDate.AutoSize = True
        chkMaintDate.Location = New Point(790, 149)
        chkMaintDate.Name = "chkMaintDate"
        chkMaintDate.Size = New Size(106, 21)
        chkMaintDate.TabIndex = 22
        chkMaintDate.Text = "تاريخ الزيارة"
        chkMaintDate.UseVisualStyleBackColor = True
        ' 
        ' chkJoinDate
        ' 
        chkJoinDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkJoinDate.AutoSize = True
        chkJoinDate.Location = New Point(773, 149)
        chkJoinDate.Name = "chkJoinDate"
        chkJoinDate.Size = New Size(123, 21)
        chkJoinDate.TabIndex = 22
        chkJoinDate.Text = "تاريخ الاشتراك"
        chkJoinDate.UseVisualStyleBackColor = True
        ' 
        ' chkAllCities
        ' 
        chkAllCities.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllCities.AutoSize = True
        chkAllCities.Checked = True
        chkAllCities.CheckState = CheckState.Checked
        chkAllCities.Location = New Point(838, 149)
        chkAllCities.Name = "chkAllCities"
        chkAllCities.Size = New Size(58, 21)
        chkAllCities.TabIndex = 22
        chkAllCities.Text = "الكل"
        chkAllCities.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(792, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 17)
        Label6.TabIndex = 21
        Label6.Text = "الحي"
        ' 
        ' cmbCity
        ' 
        cmbCity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCity.Enabled = False
        cmbCity.FormattingEnabled = True
        cmbCity.Location = New Point(792, 149)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(121, 24)
        cmbCity.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.ImeMode = ImeMode.NoControl
        Label9.Location = New Point(792, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 17)
        Label9.TabIndex = 19
        Label9.Text = "المدينة"
        ' 
        ' cmbArea
        ' 
        cmbArea.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbArea.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbArea.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbArea.Enabled = False
        cmbArea.FormattingEnabled = True
        cmbArea.Location = New Point(792, 149)
        cmbArea.Name = "cmbArea"
        cmbArea.Size = New Size(121, 24)
        cmbArea.TabIndex = 20
        ' 
        ' timer1
        ' 
        timer1.Enabled = True
        timer1.Interval = 1000
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.ImeMode = ImeMode.NoControl
        btnPreview.Location = New Point(792, 149)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 5
        btnPreview.Text = "إرسال SMS"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.ImeMode = ImeMode.NoControl
        btnShow.Location = New Point(792, 149)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض العملاء"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' txtMaintFromDate
        ' 
        txtMaintFromDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMaintFromDate.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtMaintFromDate.DropDownAlign = LeftRightAlignment.Right
        txtMaintFromDate.Format = DateTimePickerFormat.Short
        txtMaintFromDate.Location = New Point(792, 149)
        txtMaintFromDate.Name = "txtMaintFromDate"
        txtMaintFromDate.Size = New Size(200, 24)
        txtMaintFromDate.TabIndex = 2
        ' 
        ' txtMaintToDate
        ' 
        txtMaintToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMaintToDate.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtMaintToDate.DropDownAlign = LeftRightAlignment.Right
        txtMaintToDate.Format = DateTimePickerFormat.Short
        txtMaintToDate.Location = New Point(792, 149)
        txtMaintToDate.Name = "txtMaintToDate"
        txtMaintToDate.Size = New Size(200, 24)
        txtMaintToDate.TabIndex = 3
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(792, 149)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(200, 24)
        txtDateFrom.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkBothCond)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(chkAllAreas)
        GroupBox1.Controls.Add(chkMaintDate)
        GroupBox1.Controls.Add(chkJoinDate)
        GroupBox1.Controls.Add(chkAllCities)
        GroupBox1.Controls.Add(cmbArea)
        GroupBox1.Controls.Add(lblCount)
        GroupBox1.Controls.Add(lblStatus)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(cmbCity)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(txtMaintFromDate)
        GroupBox1.Controls.Add(txtMaintToDate)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(992, 100)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "حدد فلتر العملاء المطلوب ارسال لهم رسالة الجوال"
        ' 
        ' chkBothCond
        ' 
        chkBothCond.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkBothCond.AutoSize = True
        chkBothCond.Checked = True
        chkBothCond.CheckState = CheckState.Checked
        chkBothCond.Location = New Point(745, 149)
        chkBothCond.Name = "chkBothCond"
        chkBothCond.Size = New Size(151, 21)
        chkBothCond.TabIndex = 29
        chkBothCond.Text = "أوبشن التحقق معاً"
        chkBothCond.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.ImeMode = ImeMode.NoControl
        btnPrint.Location = New Point(792, 149)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 26
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.ImeMode = ImeMode.NoControl
        Button2.Location = New Point(792, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 25
        Button2.Text = "معاينة"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCount.ImeMode = ImeMode.NoControl
        lblCount.Location = New Point(792, 149)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(100, 23)
        lblCount.TabIndex = 21
        lblCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatus.ImeMode = ImeMode.NoControl
        lblStatus.Location = New Point(792, 149)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 21
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(792, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 17)
        Label1.TabIndex = 15
        Label1.Text = "الي التاريــــخ"
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(792, 149)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(200, 24)
        txtDateTo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(792, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 17)
        Label2.TabIndex = 15
        Label2.Text = "الي التاريــــخ"
        ' 
        ' frmClientsSendSms
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(992, 339)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "frmClientsSendSms"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterParent
        Text = "إرسال رسالة جوال للعملاء"
        GroupBox2.ResumeLayout(False)
        CType(dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
