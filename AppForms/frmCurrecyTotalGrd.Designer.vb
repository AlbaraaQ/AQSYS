Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCurrecyTotalGrd
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkType1 As CheckBox
    Friend WithEvents chkType2 As CheckBox
    Friend WithEvents chkType3 As CheckBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents pnlItemType As GroupBox
    Friend WithEvents txtCurrencyNo As TextBox
    Friend WithEvents txtSumBalance As TextBox
    Friend WithEvents txtSumCost As TextBox
    Friend WithEvents txtSumOpen As TextBox
    Friend WithEvents txtSumPurch As TextBox
    Friend WithEvents txtSumRetPurch As TextBox
    Friend WithEvents txtSumRetSales As TextBox
    Friend WithEvents txtSumSales As TextBox

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
        btnShow = New Button()
        txtCurrencyNo = New TextBox()
        cmbCurrency = New ComboBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Label5 = New Label()
        txtSumRetSales = New TextBox()
        txtSumRetPurch = New TextBox()
        txtSumOpen = New TextBox()
        txtSumSales = New TextBox()
        txtSumPurch = New TextBox()
        txtSumCost = New TextBox()
        txtSumBalance = New TextBox()
        timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        pnlItemType.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(pnlItemType)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(txtCurrencyNo)
        GroupBox1.Controls.Add(cmbCurrency)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1336, 124)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.ImeMode = ImeMode.NoControl
        ProgressBar1.Location = New Point(3, 92)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1330, 28)
        ProgressBar1.TabIndex = 39
        ' 
        ' pnlItemType
        ' 
        pnlItemType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlItemType.Controls.Add(chkType3)
        pnlItemType.Controls.Add(chkType2)
        pnlItemType.Controls.Add(chkType1)
        pnlItemType.Location = New Point(543, 16)
        pnlItemType.Margin = New Padding(3, 4, 3, 4)
        pnlItemType.Name = "pnlItemType"
        pnlItemType.Padding = New Padding(3, 4, 3, 4)
        pnlItemType.Size = New Size(282, 60)
        pnlItemType.TabIndex = 38
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
        chkAll.Location = New Point(1198, 66)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 35
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(171, 43)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(167, 33)
        btnClose.TabIndex = 3
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(345, 43)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(158, 33)
        btnShow.TabIndex = 2
        btnShow.Text = "بحث"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' txtCurrencyNo
        ' 
        txtCurrencyNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCurrencyNo.Location = New Point(1150, 38)
        txtCurrencyNo.Margin = New Padding(3, 4, 3, 4)
        txtCurrencyNo.Name = "txtCurrencyNo"
        txtCurrencyNo.Size = New Size(106, 24)
        txtCurrencyNo.TabIndex = 0
        txtCurrencyNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrency.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(874, 38)
        cmbCurrency.Margin = New Padding(3, 4, 3, 4)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(275, 24)
        cmbCurrency.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(1265, 42)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(51, 17)
        Label2.TabIndex = 9
        Label2.Text = "الصنف"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 124)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1336, 483)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column10, Column4, Column5, Column6, Column7, Column8, Column9, Column3})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(1330, 409)
        dgvItems.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الرقم"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 50
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الصنف"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "متوسط سعر التكلفة"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "اجمالي التكلفة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "رصيد اول"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "مشتريات"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 70
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "مردود مشتريات"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "مبيعات"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 70
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "مردود مبيعات"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الرصيد"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtSumRetSales)
        Panel2.Controls.Add(txtSumRetPurch)
        Panel2.Controls.Add(txtSumOpen)
        Panel2.Controls.Add(txtSumSales)
        Panel2.Controls.Add(txtSumPurch)
        Panel2.Controls.Add(txtSumCost)
        Panel2.Controls.Add(txtSumBalance)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(3, 430)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1330, 49)
        Panel2.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(930, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 17)
        Label5.TabIndex = 5
        Label5.Text = "الرصيد الإجمالي"
        ' 
        ' txtSumRetSales
        ' 
        txtSumRetSales.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumRetSales.BorderStyle = BorderStyle.FixedSingle
        txtSumRetSales.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumRetSales.Location = New Point(323, 6)
        txtSumRetSales.Margin = New Padding(3, 4, 3, 4)
        txtSumRetSales.Multiline = True
        txtSumRetSales.Name = "txtSumRetSales"
        txtSumRetSales.ReadOnly = True
        txtSumRetSales.Size = New Size(114, 33)
        txtSumRetSales.TabIndex = 4
        txtSumRetSales.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumRetPurch
        ' 
        txtSumRetPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumRetPurch.BorderStyle = BorderStyle.FixedSingle
        txtSumRetPurch.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumRetPurch.Location = New Point(528, 6)
        txtSumRetPurch.Margin = New Padding(3, 4, 3, 4)
        txtSumRetPurch.Multiline = True
        txtSumRetPurch.Name = "txtSumRetPurch"
        txtSumRetPurch.ReadOnly = True
        txtSumRetPurch.Size = New Size(101, 33)
        txtSumRetPurch.TabIndex = 4
        txtSumRetPurch.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumOpen
        ' 
        txtSumOpen.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumOpen.BorderStyle = BorderStyle.FixedSingle
        txtSumOpen.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumOpen.Location = New Point(707, 6)
        txtSumOpen.Margin = New Padding(3, 4, 3, 4)
        txtSumOpen.Multiline = True
        txtSumOpen.Name = "txtSumOpen"
        txtSumOpen.ReadOnly = True
        txtSumOpen.Size = New Size(99, 33)
        txtSumOpen.TabIndex = 4
        txtSumOpen.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumSales
        ' 
        txtSumSales.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumSales.BorderStyle = BorderStyle.FixedSingle
        txtSumSales.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumSales.Location = New Point(436, 6)
        txtSumSales.Margin = New Padding(3, 4, 3, 4)
        txtSumSales.Multiline = True
        txtSumSales.Name = "txtSumSales"
        txtSumSales.ReadOnly = True
        txtSumSales.Size = New Size(92, 33)
        txtSumSales.TabIndex = 4
        txtSumSales.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumPurch
        ' 
        txtSumPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumPurch.BorderStyle = BorderStyle.FixedSingle
        txtSumPurch.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumPurch.Location = New Point(628, 6)
        txtSumPurch.Margin = New Padding(3, 4, 3, 4)
        txtSumPurch.Multiline = True
        txtSumPurch.Name = "txtSumPurch"
        txtSumPurch.ReadOnly = True
        txtSumPurch.Size = New Size(80, 33)
        txtSumPurch.TabIndex = 4
        txtSumPurch.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumCost
        ' 
        txtSumCost.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumCost.BorderStyle = BorderStyle.FixedSingle
        txtSumCost.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumCost.Location = New Point(806, 6)
        txtSumCost.Margin = New Padding(3, 4, 3, 4)
        txtSumCost.Multiline = True
        txtSumCost.Name = "txtSumCost"
        txtSumCost.ReadOnly = True
        txtSumCost.Size = New Size(117, 33)
        txtSumCost.TabIndex = 4
        txtSumCost.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSumBalance
        ' 
        txtSumBalance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumBalance.BorderStyle = BorderStyle.FixedSingle
        txtSumBalance.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumBalance.Location = New Point(207, 6)
        txtSumBalance.Margin = New Padding(3, 4, 3, 4)
        txtSumBalance.Multiline = True
        txtSumBalance.Name = "txtSumBalance"
        txtSumBalance.ReadOnly = True
        txtSumBalance.Size = New Size(117, 33)
        txtSumBalance.TabIndex = 4
        txtSumBalance.TextAlign = HorizontalAlignment.Center
        ' 
        ' timer1
        ' 
        timer1.Enabled = True
        ' 
        ' frmCurrecyTotalGrd
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1336, 607)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCurrecyTotalGrd"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "صنف باجمالي الحركــــــــات"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        pnlItemType.ResumeLayout(False)
        pnlItemType.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
