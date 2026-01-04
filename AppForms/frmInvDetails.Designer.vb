Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmInvDetails
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllCurrencies As CheckBox
    Friend WithEvents chkAllSafes As CheckBox
    Friend WithEvents cmbCurrencies As ComboBox
    Friend WithEvents cmbProcType As ComboBox
    Friend WithEvents cmbSafes As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdByItem As RadioButton
    Friend WithEvents rdBynv As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSum As TextBox

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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        rdByItem = New RadioButton()
        rdBynv = New RadioButton()
        chkAllCurrencies = New CheckBox()
        cmbCurrencies = New ComboBox()
        Label6 = New Label()
        chkAllSafes = New CheckBox()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        txtDateFrom = New DateTimePicker()
        Label4 = New Label()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        btnShow = New Button()
        cmbSafes = New ComboBox()
        cmbProcType = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        txtSum = New TextBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        Panel2 = New Panel()
        dgvItems = New DataGridView()
        Column10 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewButtonColumn()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdByItem)
        GroupBox1.Controls.Add(rdBynv)
        GroupBox1.Controls.Add(chkAllCurrencies)
        GroupBox1.Controls.Add(cmbCurrencies)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(chkAllSafes)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbSafes)
        GroupBox1.Controls.Add(cmbProcType)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1310, 235)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل بيانات البحث"
        ' 
        ' rdByItem
        ' 
        rdByItem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdByItem.AutoSize = True
        rdByItem.ImeMode = ImeMode.NoControl
        rdByItem.Location = New Point(138, 105)
        rdByItem.Margin = New Padding(3, 4, 3, 4)
        rdByItem.Name = "rdByItem"
        rdByItem.Size = New Size(132, 21)
        rdByItem.TabIndex = 40
        rdByItem.Text = "إجمالي بالصنف"
        rdByItem.UseVisualStyleBackColor = True
        ' 
        ' rdBynv
        ' 
        rdBynv.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdBynv.AutoSize = True
        rdBynv.Checked = True
        rdBynv.Location = New Point(273, 105)
        rdBynv.Margin = New Padding(3, 4, 3, 4)
        rdBynv.Name = "rdBynv"
        rdBynv.Size = New Size(141, 21)
        rdBynv.TabIndex = 40
        rdBynv.TabStop = True
        rdBynv.Text = "تفصيلي بالفاتورة"
        rdBynv.UseVisualStyleBackColor = True
        ' 
        ' chkAllCurrencies
        ' 
        chkAllCurrencies.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllCurrencies.AutoSize = True
        chkAllCurrencies.Location = New Point(393, 58)
        chkAllCurrencies.Margin = New Padding(3, 4, 3, 4)
        chkAllCurrencies.Name = "chkAllCurrencies"
        chkAllCurrencies.Size = New Size(58, 21)
        chkAllCurrencies.TabIndex = 39
        chkAllCurrencies.Text = "الكل"
        chkAllCurrencies.UseVisualStyleBackColor = True
        ' 
        ' cmbCurrencies
        ' 
        cmbCurrencies.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCurrencies.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrencies.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrencies.FormattingEnabled = True
        cmbCurrencies.Location = New Point(264, 30)
        cmbCurrencies.Margin = New Padding(3, 4, 3, 4)
        cmbCurrencies.Name = "cmbCurrencies"
        cmbCurrencies.Size = New Size(191, 24)
        cmbCurrencies.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(459, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 17)
        Label6.TabIndex = 37
        Label6.Text = "الصنف"
        ' 
        ' chkAllSafes
        ' 
        chkAllSafes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllSafes.AutoSize = True
        chkAllSafes.Location = New Point(733, 58)
        chkAllSafes.Margin = New Padding(3, 4, 3, 4)
        chkAllSafes.Name = "chkAllSafes"
        chkAllSafes.Size = New Size(58, 21)
        chkAllSafes.TabIndex = 36
        chkAllSafes.Text = "الكل"
        chkAllSafes.UseVisualStyleBackColor = True
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(465, 107)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(151, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(622, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 13
        Label3.Text = "الى تاريخ"
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(694, 107)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(151, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(855, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 12
        Label4.Text = "من تاريخ"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(367, 156)
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
        btnPrint.Location = New Point(530, 156)
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
        btnPreview.Location = New Point(694, 156)
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
        btnShow.Location = New Point(857, 156)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(157, 55)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbSafes
        ' 
        cmbSafes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbSafes.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSafes.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSafes.FormattingEnabled = True
        cmbSafes.Location = New Point(603, 30)
        cmbSafes.Margin = New Padding(3, 4, 3, 4)
        cmbSafes.Name = "cmbSafes"
        cmbSafes.Size = New Size(191, 24)
        cmbSafes.TabIndex = 1
        ' 
        ' cmbProcType
        ' 
        cmbProcType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbProcType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProcType.FormattingEnabled = True
        cmbProcType.Items.AddRange(New Object() {"مشتريات", "مبيعات"})
        cmbProcType.Location = New Point(911, 31)
        cmbProcType.Margin = New Padding(3, 4, 3, 4)
        cmbProcType.Name = "cmbProcType"
        cmbProcType.Size = New Size(89, 24)
        cmbProcType.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(799, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 17)
        Label2.TabIndex = 1
        Label2.Text = "المخزن"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(1003, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 0
        Label1.Text = "نوع العملية"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtSum)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 589)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1310, 41)
        Panel1.TabIndex = 7
        ' 
        ' txtSum
        ' 
        txtSum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSum.BackColor = SystemColors.Control
        txtSum.BorderStyle = BorderStyle.None
        txtSum.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSum.ForeColor = Color.Red
        txtSum.Location = New Point(285, 1)
        txtSum.Margin = New Padding(3, 4, 3, 4)
        txtSum.Multiline = True
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(163, 33)
        txtSum.TabIndex = 0
        txtSum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(455, 4)
        Label5.Name = "Label5"
        Label5.Size = New Size(851, 33)
        Label5.TabIndex = 3
        Label5.Text = "الاجمالي"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1310, 630)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "البيانات"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvItems)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 235)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1310, 354)
        Panel2.TabIndex = 9
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column10, Column1, Column2, Column3, Column4, Column5, Column6, Column9, Column8, Column7})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(0, 0)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(1310, 354)
        dgvItems.TabIndex = 2
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "المخزن"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "نوع العملية"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "التاريخ"
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
        Column3.Width = 90
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الصنف"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 130
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
        Column6.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "الاجمالي"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 130
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "المستخدم"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "عرض"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        Column7.Text = "view"
        Column7.ToolTipText = "عرض الفاتورة"
        Column7.UseColumnTextForButtonValue = True
        Column7.Width = 120
        ' 
        ' frmInvDetails
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1310, 630)
        Controls.Add(Panel2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmInvDetails"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "مبيعات ومشتريات تفصيلية"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
