Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCustAccount
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button11 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkAllActs As CheckBox
    Friend WithEvents cmbActs As ComboBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblCust As Label
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumBalance As Label
    Friend WithEvents txtSumCredit As Label
    Friend WithEvents txtSumDept As Label
    Friend WithEvents txtSumState As Label

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustAccount))
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label5 = New Label()
        Label2 = New Label()
        txtSumState = New Label()
        txtSumBalance = New Label()
        txtSumCredit = New Label()
        txtSumDept = New Label()
        GroupBox1 = New GroupBox()
        Button11 = New Button()
        chkAllActs = New CheckBox()
        chkAll = New CheckBox()
        txtDateFrom = New DateTimePicker()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        btnShow = New Button()
        cmbActs = New ComboBox()
        Label1 = New Label()
        cmbClients = New ComboBox()
        lblCust = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 176)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1022, 458)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(1016, 394)
        dgvItems.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم الحساب"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "اسم العميل "
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "حركة مدين"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 105
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "حركة دائن"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 105
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الرصيد"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 105
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "الحالة"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtSumState)
        Panel1.Controls.Add(txtSumBalance)
        Panel1.Controls.Add(txtSumCredit)
        Panel1.Controls.Add(txtSumDept)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 415)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1016, 39)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Location = New Point(734, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 28)
        Label5.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(620, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 34)
        Label2.TabIndex = 9
        Label2.Text = "الاجمالي"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumState
        ' 
        txtSumState.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumState.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumState.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumState.Location = New Point(148, -1)
        txtSumState.Name = "txtSumState"
        txtSumState.Size = New Size(130, 34)
        txtSumState.TabIndex = 10
        txtSumState.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumBalance
        ' 
        txtSumBalance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumBalance.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumBalance.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumBalance.Location = New Point(278, 0)
        txtSumBalance.Name = "txtSumBalance"
        txtSumBalance.Size = New Size(114, 34)
        txtSumBalance.TabIndex = 10
        txtSumBalance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumCredit
        ' 
        txtSumCredit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumCredit.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumCredit.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumCredit.Location = New Point(392, 0)
        txtSumCredit.Name = "txtSumCredit"
        txtSumCredit.Size = New Size(114, 34)
        txtSumCredit.TabIndex = 10
        txtSumCredit.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumDept
        ' 
        txtSumDept.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumDept.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumDept.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumDept.Location = New Point(506, 0)
        txtSumDept.Name = "txtSumDept"
        txtSumDept.Size = New Size(114, 34)
        txtSumDept.TabIndex = 10
        txtSumDept.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button11)
        GroupBox1.Controls.Add(chkAllActs)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbActs)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbClients)
        GroupBox1.Controls.Add(lblCust)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1022, 176)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.ImeMode = ImeMode.NoControl
        Button11.Location = New Point(538, 55)
        Button11.Margin = New Padding(3, 4, 3, 4)
        Button11.Name = "Button11"
        Button11.Size = New Size(37, 31)
        Button11.TabIndex = 207
        Button11.UseVisualStyleBackColor = True
        ' 
        ' chkAllActs
        ' 
        chkAllActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllActs.AutoSize = True
        chkAllActs.Checked = True
        chkAllActs.CheckState = CheckState.Checked
        chkAllActs.ImeMode = ImeMode.NoControl
        chkAllActs.Location = New Point(514, 22)
        chkAllActs.Margin = New Padding(3, 4, 3, 4)
        chkAllActs.Name = "chkAllActs"
        chkAllActs.Size = New Size(58, 21)
        chkAllActs.TabIndex = 1
        chkAllActs.Text = "الكل"
        chkAllActs.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(727, 85)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 1
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(227, 15)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(127, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(227, 47)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(127, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(362, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 17)
        Label3.TabIndex = 23
        Label3.Text = "من التاريــــخ"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(360, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 17)
        Label4.TabIndex = 22
        Label4.Text = "الي التاريــــخ"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(154, 108)
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
        btnPrint.Location = New Point(318, 108)
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
        btnPreview.Location = New Point(481, 108)
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
        btnShow.Location = New Point(645, 108)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(157, 55)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbActs
        ' 
        cmbActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbActs.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbActs.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbActs.Enabled = False
        cmbActs.FormattingEnabled = True
        cmbActs.Location = New Point(575, 20)
        cmbActs.Margin = New Padding(3, 4, 3, 4)
        cmbActs.Name = "cmbActs"
        cmbActs.Size = New Size(212, 24)
        cmbActs.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(791, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 17)
        Label1.TabIndex = 0
        Label1.Text = "اختر المجال"
        ' 
        ' cmbClients
        ' 
        cmbClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.FormattingEnabled = True
        cmbClients.Location = New Point(575, 58)
        cmbClients.Margin = New Padding(3, 4, 3, 4)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(212, 24)
        cmbClients.TabIndex = 0
        ' 
        ' lblCust
        ' 
        lblCust.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCust.AutoSize = True
        lblCust.Location = New Point(791, 62)
        lblCust.Name = "lblCust"
        lblCust.Size = New Size(83, 17)
        lblCust.TabIndex = 0
        lblCust.Text = "اسم العميل"
        ' 
        ' frmCustAccount
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 634)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCustAccount"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "ارصدة حساب العملاء"
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
