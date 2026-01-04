Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmInvSumByClient
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button11 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumPurch As Label
    Friend WithEvents txtSumSale As Label

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvSumByClient))
        chkAll = New CheckBox()
        btnClose = New Button()
        btnPreview = New Button()
        btnPrint = New Button()
        btnShow = New Button()
        cmbClients = New ComboBox()
        txtDateFrom = New DateTimePicker()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewButtonColumn()
        Panel1 = New Panel()
        Label3 = New Label()
        Label5 = New Label()
        txtSumSale = New Label()
        txtSumPurch = New Label()
        Label15 = New Label()
        GroupBox1 = New GroupBox()
        Button11 = New Button()
        txtDateTo = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(703, 55)
        chkAll.Margin = New Padding(3, 4, 3, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 1
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(138, 79)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(61, 33)
        btnClose.TabIndex = 7
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(273, 79)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(61, 33)
        btnPreview.TabIndex = 5
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(206, 79)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(61, 33)
        btnPrint.TabIndex = 6
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(341, 79)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(61, 33)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbClients
        ' 
        cmbClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.FormattingEnabled = True
        cmbClients.Items.AddRange(New Object() {"آجلة", "نقدية"})
        cmbClients.Location = New Point(138, 27)
        cmbClients.Margin = New Padding(3, 4, 3, 4)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(626, 24)
        cmbClients.TabIndex = 0
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(656, 86)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(105, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 130)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(982, 423)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "الفواتير"
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6, Column5})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(976, 359)
        dgvItems.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "نوع الفاتورة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "رقم الفاتورة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 119
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "التاريخ"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 119
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "اجمالي المشتريات"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 136
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "اجمالي المبيعات"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 136
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "عرض"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        Column5.Text = "view"
        Column5.ToolTipText = "عرض"
        Column5.UseColumnTextForButtonValue = True
        Column5.Width = 120
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtSumSale)
        Panel1.Controls.Add(txtSumPurch)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 380)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(976, 39)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(547, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(425, 34)
        Label3.TabIndex = 9
        Label3.Text = "الاجمالي"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(108, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 34)
        Label5.TabIndex = 10
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumSale
        ' 
        txtSumSale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumSale.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumSale.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumSale.Location = New Point(251, 0)
        txtSumSale.Name = "txtSumSale"
        txtSumSale.Size = New Size(152, 34)
        txtSumSale.TabIndex = 10
        txtSumSale.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSumPurch
        ' 
        txtSumPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumPurch.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSumPurch.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumPurch.Location = New Point(403, 0)
        txtSumPurch.Name = "txtSumPurch"
        txtSumPurch.Size = New Size(144, 34)
        txtSumPurch.TabIndex = 10
        txtSumPurch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(771, 32)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 17)
        Label15.TabIndex = 24
        Label15.Text = "اسم العميل"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button11)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbClients)
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(982, 130)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "فضلا ادخل البيانات"
        ' 
        ' Button11
        ' 
        Button11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button11.Image = CType(resources.GetObject("Button11.Image"), Image)
        Button11.ImeMode = ImeMode.NoControl
        Button11.Location = New Point(101, 23)
        Button11.Margin = New Padding(3, 4, 3, 4)
        Button11.Name = "Button11"
        Button11.Size = New Size(37, 31)
        Button11.TabIndex = 207
        Button11.UseVisualStyleBackColor = True
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(449, 86)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(105, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(768, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 17)
        Label1.TabIndex = 15
        Label1.Text = "من التاريــــخ"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(559, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 17)
        Label2.TabIndex = 15
        Label2.Text = "الي التاريــــخ"
        ' 
        ' frmInvSumByClient
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmInvSumByClient"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "اجمالي فواتير بحسب العمــــــــلاء"
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
