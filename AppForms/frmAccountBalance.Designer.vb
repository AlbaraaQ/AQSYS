Imports System.ComponentModel
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAccountBalance
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkAllBranches As CheckBox
    Friend WithEvents chkAllCenter As CheckBox
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents chkPrev As CheckBox
    Friend WithEvents cmbAccounts As ComboBox
    Friend WithEvents cmbBranches As ComboBox
    Friend WithEvents cmbCostCenter As ComboBox
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colView As DataGridViewButtonColumn
    Friend WithEvents colpono As DataGridViewTextBoxColumn
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents lblCostCenter As Label
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdCredit As RadioButton
    Friend WithEvents rdDebt As RadioButton
    Friend WithEvents txtBalance1 As TextBox
    Friend WithEvents txtBalance2 As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
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
        Panel1 = New Panel()
        chkAllBranches = New CheckBox()
        cmbBranches = New ComboBox()
        Label5 = New Label()
        chkPrev = New CheckBox()
        chkOpen = New CheckBox()
        chkAllCenter = New CheckBox()
        cmbCostCenter = New ComboBox()
        lblCostCenter = New Label()
        rdCredit = New RadioButton()
        rdDebt = New RadioButton()
        rdAll = New RadioButton()
        btnPreview = New Button()
        chkAll = New CheckBox()
        txtCode = New TextBox()
        Button1 = New Button()
        btnClose = New Button()
        btnPrint = New Button()
        btnShow = New Button()
        cmbAccounts = New ComboBox()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        txtDateFrom = New DateTimePicker()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTotDept = New TextBox()
        Panel3 = New Panel()
        txtBalance2 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        txtTotCredit = New TextBox()
        txtBalance1 = New TextBox()
        Panel2 = New Panel()
        dgvSrch = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        colView = New DataGridViewButtonColumn()
        colBalance = New DataGridViewTextBoxColumn()
        colpono = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvSrch, ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(chkAllBranches)
        Panel1.Controls.Add(cmbBranches)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(chkPrev)
        Panel1.Controls.Add(chkOpen)
        Panel1.Controls.Add(chkAllCenter)
        Panel1.Controls.Add(cmbCostCenter)
        Panel1.Controls.Add(lblCostCenter)
        Panel1.Controls.Add(rdCredit)
        Panel1.Controls.Add(rdDebt)
        Panel1.Controls.Add(rdAll)
        Panel1.Controls.Add(btnPreview)
        Panel1.Controls.Add(chkAll)
        Panel1.Controls.Add(txtCode)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(btnShow)
        Panel1.Controls.Add(cmbAccounts)
        Panel1.Controls.Add(txtDateTo)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtDateFrom)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1031, 158)
        Panel1.TabIndex = 0
        ' 
        ' chkAllBranches
        ' 
        chkAllBranches.Location = New Point(62, 64)
        chkAllBranches.Margin = New Padding(3, 4, 3, 4)
        chkAllBranches.Name = "chkAllBranches"
        chkAllBranches.Size = New Size(119, 30)
        chkAllBranches.TabIndex = 204
        chkAllBranches.UseVisualStyleBackColor = True
        ' 
        ' cmbBranches
        ' 
        cmbBranches.FormattingEnabled = True
        cmbBranches.Location = New Point(125, 62)
        cmbBranches.Margin = New Padding(3, 4, 3, 4)
        cmbBranches.Name = "cmbBranches"
        cmbBranches.Size = New Size(138, 24)
        cmbBranches.TabIndex = 202
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(315, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 28)
        Label5.TabIndex = 203
        ' 
        ' chkPrev
        ' 
        chkPrev.Checked = True
        chkPrev.CheckState = CheckState.Checked
        chkPrev.Location = New Point(120, 28)
        chkPrev.Margin = New Padding(3, 4, 3, 4)
        chkPrev.Name = "chkPrev"
        chkPrev.Size = New Size(119, 30)
        chkPrev.TabIndex = 200
        chkPrev.UseVisualStyleBackColor = True
        ' 
        ' chkOpen
        ' 
        chkOpen.Checked = True
        chkOpen.CheckState = CheckState.Checked
        chkOpen.Location = New Point(225, 28)
        chkOpen.Margin = New Padding(3, 4, 3, 4)
        chkOpen.Name = "chkOpen"
        chkOpen.Size = New Size(119, 30)
        chkOpen.TabIndex = 201
        chkOpen.UseVisualStyleBackColor = True
        ' 
        ' chkAllCenter
        ' 
        chkAllCenter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllCenter.AutoSize = True
        chkAllCenter.Checked = True
        chkAllCenter.CheckState = CheckState.Checked
        chkAllCenter.ImeMode = ImeMode.NoControl
        chkAllCenter.Location = New Point(165, 79)
        chkAllCenter.Margin = New Padding(3, 4, 3, 4)
        chkAllCenter.Name = "chkAllCenter"
        chkAllCenter.Size = New Size(58, 21)
        chkAllCenter.TabIndex = 199
        chkAllCenter.Text = "الكل"
        chkAllCenter.UseVisualStyleBackColor = True
        ' 
        ' cmbCostCenter
        ' 
        cmbCostCenter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCostCenter.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCostCenter.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCostCenter.Enabled = False
        cmbCostCenter.FormattingEnabled = True
        cmbCostCenter.Location = New Point(227, 76)
        cmbCostCenter.Margin = New Padding(3, 4, 3, 4)
        cmbCostCenter.Name = "cmbCostCenter"
        cmbCostCenter.Size = New Size(173, 24)
        cmbCostCenter.TabIndex = 197
        ' 
        ' lblCostCenter
        ' 
        lblCostCenter.Location = New Point(406, 81)
        lblCostCenter.Name = "lblCostCenter"
        lblCostCenter.Size = New Size(114, 28)
        lblCostCenter.TabIndex = 198
        ' 
        ' rdCredit
        ' 
        rdCredit.AutoSize = True
        rdCredit.ImeMode = ImeMode.NoControl
        rdCredit.Location = New Point(663, 117)
        rdCredit.Margin = New Padding(3, 4, 3, 4)
        rdCredit.Name = "rdCredit"
        rdCredit.Size = New Size(58, 21)
        rdCredit.TabIndex = 8
        rdCredit.Text = "دائن"
        rdCredit.UseVisualStyleBackColor = True
        ' 
        ' rdDebt
        ' 
        rdDebt.AutoSize = True
        rdDebt.ImeMode = ImeMode.NoControl
        rdDebt.Location = New Point(726, 117)
        rdDebt.Margin = New Padding(3, 4, 3, 4)
        rdDebt.Name = "rdDebt"
        rdDebt.Size = New Size(62, 21)
        rdDebt.TabIndex = 8
        rdDebt.Text = "مدين"
        rdDebt.UseVisualStyleBackColor = True
        ' 
        ' rdAll
        ' 
        rdAll.AutoSize = True
        rdAll.Checked = True
        rdAll.Location = New Point(789, 117)
        rdAll.Margin = New Padding(3, 4, 3, 4)
        rdAll.Name = "rdAll"
        rdAll.Size = New Size(57, 21)
        rdAll.TabIndex = 8
        rdAll.TabStop = True
        rdAll.Text = "الكل"
        rdAll.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(256, 112)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(105, 41)
        btnPreview.TabIndex = 5
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(743, 53)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 2
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' txtCode
        ' 
        txtCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCode.Location = New Point(649, 27)
        txtCode.Margin = New Padding(3, 4, 3, 4)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(151, 24)
        txtCode.TabIndex = 0
        txtCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(32, 11)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 41)
        Button1.TabIndex = 7
        Button1.Text = "الإقرار الضريبي"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(32, 112)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(105, 41)
        btnClose.TabIndex = 7
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(144, 112)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(105, 41)
        btnPrint.TabIndex = 6
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(368, 112)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(105, 41)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbAccounts
        ' 
        cmbAccounts.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbAccounts.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbAccounts.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbAccounts.FormattingEnabled = True
        cmbAccounts.Location = New Point(227, 27)
        cmbAccounts.Margin = New Padding(3, 4, 3, 4)
        cmbAccounts.Name = "cmbAccounts"
        cmbAccounts.Size = New Size(422, 24)
        cmbAccounts.TabIndex = 1
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(498, 81)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(151, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 10, 3, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(657, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 0
        Label3.Text = "الى تاريخ"
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(727, 81)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(151, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 10, 3, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(891, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 17)
        Label4.TabIndex = 0
        Label4.Text = "الظهور"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(891, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 0
        Label2.Text = "من تاريخ"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(811, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 17)
        Label1.TabIndex = 0
        Label1.Text = "كود الحساب"
        ' 
        ' txtTotDept
        ' 
        txtTotDept.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotDept.BorderStyle = BorderStyle.FixedSingle
        txtTotDept.Location = New Point(928, 0)
        txtTotDept.Margin = New Padding(3, 4, 3, 4)
        txtTotDept.Name = "txtTotDept"
        txtTotDept.ReadOnly = True
        txtTotDept.Size = New Size(100, 24)
        txtTotDept.TabIndex = 0
        txtTotDept.TextAlign = HorizontalAlignment.Center
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
        Panel3.Location = New Point(0, 546)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1031, 53)
        Panel3.TabIndex = 2
        ' 
        ' txtBalance2
        ' 
        txtBalance2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBalance2.BorderStyle = BorderStyle.FixedSingle
        txtBalance2.Location = New Point(827, 26)
        txtBalance2.Margin = New Padding(3, 4, 3, 4)
        txtBalance2.Name = "txtBalance2"
        txtBalance2.ReadOnly = True
        txtBalance2.Size = New Size(100, 24)
        txtBalance2.TabIndex = 3
        txtBalance2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(22, 26)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(804, 24)
        TextBox5.TabIndex = 2
        TextBox5.Text = "رصيد الفترة المحددة"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(22, 0)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(804, 24)
        TextBox4.TabIndex = 2
        TextBox4.Text = "اجمالي الفترة المحددة"
        ' 
        ' txtTotCredit
        ' 
        txtTotCredit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotCredit.BorderStyle = BorderStyle.FixedSingle
        txtTotCredit.Location = New Point(827, 0)
        txtTotCredit.Margin = New Padding(3, 4, 3, 4)
        txtTotCredit.Name = "txtTotCredit"
        txtTotCredit.ReadOnly = True
        txtTotCredit.Size = New Size(100, 24)
        txtTotCredit.TabIndex = 1
        txtTotCredit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBalance1
        ' 
        txtBalance1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBalance1.BorderStyle = BorderStyle.FixedSingle
        txtBalance1.Location = New Point(928, 26)
        txtBalance1.Margin = New Padding(3, 4, 3, 4)
        txtBalance1.Name = "txtBalance1"
        txtBalance1.ReadOnly = True
        txtBalance1.Size = New Size(100, 24)
        txtBalance1.TabIndex = 2
        txtBalance1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvSrch)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 158)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1031, 388)
        Panel2.TabIndex = 3
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
        dgvSrch.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column5, Column7, Column6, colView, colBalance, colpono})
        dgvSrch.Dock = DockStyle.Fill
        dgvSrch.Location = New Point(0, 0)
        dgvSrch.Margin = New Padding(3, 4, 3, 4)
        dgvSrch.MultiSelect = False
        dgvSrch.Name = "dgvSrch"
        dgvSrch.ReadOnly = True
        dgvSrch.RowHeadersVisible = False
        dgvSrch.RowHeadersWidth = 51
        dgvSrch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSrch.Size = New Size(1031, 388)
        dgvSrch.TabIndex = 0
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
        Column6.Width = 300
        ' 
        ' colView
        ' 
        colView.HeaderText = ""
        colView.MinimumWidth = 6
        colView.Name = "colView"
        colView.ReadOnly = True
        colView.Resizable = DataGridViewTriState.True
        colView.SortMode = DataGridViewColumnSortMode.Automatic
        colView.Text = "view"
        colView.UseColumnTextForButtonValue = True
        colView.Width = 80
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
        colpono.HeaderText = "Po No."
        colpono.MinimumWidth = 6
        colpono.Name = "colpono"
        colpono.ReadOnly = True
        colpono.Width = 120
        ' 
        ' frmAccountBalance
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1031, 599)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmAccountBalance"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "حركة حساب خلال فترة"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvSrch, ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
