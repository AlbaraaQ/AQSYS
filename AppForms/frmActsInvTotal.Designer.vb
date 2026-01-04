Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmActsInvTotal
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllActs As CheckBox
    Friend WithEvents cmbActs As ComboBox
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        txtSumSale = New Label()
        Label1 = New Label()
        Label9 = New Label()
        txtSumPurch = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        txtDateFrom = New DateTimePicker()
        txtDateTo = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        chkAllActs = New CheckBox()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        btnShow = New Button()
        cmbActs = New ComboBox()
        Label2 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvItems, ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.FromArgb(64, 64, 64)
        GroupBox2.Location = New Point(0, 180)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(10)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(873, 460)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "التقرير"
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.BackgroundColor = Color.White
        dgvItems.BorderStyle = BorderStyle.None
        dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94)
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94)
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvItems.ColumnHeadersHeight = 40
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 240, 241)
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvItems.DefaultCellStyle = DataGridViewCellStyle2
        dgvItems.Dock = DockStyle.Fill
        dgvItems.EnableHeadersVisualStyles = False
        dgvItems.GridColor = Color.FromArgb(224, 224, 224)
        dgvItems.Location = New Point(10, 78)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        dgvItems.RowTemplate.Height = 35
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(853, 317)
        dgvItems.TabIndex = 9
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "م"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 51
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "جهة العمل"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الاجمالي"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 190
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "جهة العمل"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الاجمالي"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 190
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(245, 246, 247)
        Panel1.Controls.Add(txtSumSale)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtSumPurch)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(10, 395)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(853, 55)
        Panel1.TabIndex = 8
        ' 
        ' txtSumSale
        ' 
        txtSumSale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumSale.BackColor = Color.White
        txtSumSale.BorderStyle = BorderStyle.FixedSingle
        txtSumSale.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumSale.ForeColor = Color.FromArgb(41, 128, 185)
        txtSumSale.Location = New Point(35, 8)
        txtSumSale.Name = "txtSumSale"
        txtSumSale.Size = New Size(194, 38)
        txtSumSale.TabIndex = 10
        txtSumSale.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(680, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 23)
        Label1.TabIndex = 7
        Label1.Text = "اجمالي المشتريات"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(250, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 23)
        Label9.TabIndex = 9
        Label9.Text = "اجمالي المبيعات"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSumPurch
        ' 
        txtSumPurch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSumPurch.BackColor = Color.White
        txtSumPurch.BorderStyle = BorderStyle.FixedSingle
        txtSumPurch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSumPurch.ForeColor = Color.FromArgb(192, 57, 43)
        txtSumPurch.Location = New Point(419, 8)
        txtSumPurch.Name = "txtSumPurch"
        txtSumPurch.Size = New Size(210, 38)
        txtSumPurch.TabIndex = 8
        txtSumPurch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(236, 240, 241)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(10, 28)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(853, 50)
        Panel2.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(41, 128, 185)
        Label6.Location = New Point(33, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(385, 34)
        Label6.TabIndex = 4
        Label6.Text = "بيانات المبيعات"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(192, 57, 43)
        Label7.Location = New Point(419, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(385, 34)
        Label7.TabIndex = 3
        Label7.Text = "بيانات المشتريات"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(txtDateFrom)
        GroupBox1.Controls.Add(txtDateTo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(chkAllActs)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbActs)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(873, 180)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "خيارات البحث والفلترة"
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(320, 38)
        txtDateFrom.Margin = New Padding(3, 4, 3, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(134, 30)
        txtDateFrom.TabIndex = 6
        txtDateFrom.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(79, 38)
        txtDateTo.Margin = New Padding(3, 4, 3, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(126, 30)
        txtDateTo.TabIndex = 7
        txtDateTo.Value = New Date(2012, 9, 23, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(465, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 23)
        Label3.TabIndex = 40
        Label3.Text = "من التاريــــخ"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(213, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 41
        Label4.Text = "الي التاريــــخ"
        ' 
        ' chkAllActs
        ' 
        chkAllActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllActs.AutoSize = True
        chkAllActs.ForeColor = Color.DimGray
        chkAllActs.Location = New Point(685, 75)
        chkAllActs.Margin = New Padding(3, 4, 3, 4)
        chkAllActs.Name = "chkAllActs"
        chkAllActs.Size = New Size(62, 27)
        chkAllActs.TabIndex = 3
        chkAllActs.Text = "الكل"
        chkAllActs.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(231, 76, 60)
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(163, 115)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(126, 40)
        btnClose.TabIndex = 11
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.BackColor = Color.FromArgb(39, 174, 96)
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(305, 115)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(126, 40)
        btnPrint.TabIndex = 10
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.BackColor = Color.FromArgb(41, 128, 185)
        btnPreview.Cursor = Cursors.Hand
        btnPreview.FlatAppearance.BorderSize = 0
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPreview.ForeColor = Color.White
        btnPreview.Location = New Point(438, 115)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(126, 40)
        btnPreview.TabIndex = 9
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.BackColor = Color.FromArgb(52, 73, 94)
        btnShow.Cursor = Cursors.Hand
        btnShow.FlatAppearance.BorderSize = 0
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnShow.ForeColor = Color.White
        btnShow.Location = New Point(570, 115)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(126, 40)
        btnShow.TabIndex = 8
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' cmbActs
        ' 
        cmbActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbActs.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        cmbActs.FormattingEnabled = True
        cmbActs.Location = New Point(583, 38)
        cmbActs.Margin = New Padding(3, 4, 3, 4)
        cmbActs.Name = "cmbActs"
        cmbActs.Size = New Size(161, 31)
        cmbActs.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(751, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 23)
        Label2.TabIndex = 1
        Label2.Text = "جهة العمل"
        ' 
        ' frmActsInvTotal
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(245, 246, 247)
        ClientSize = New Size(873, 640)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmActsInvTotal"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تقرير اجمالي مشتريات ومبيعات جهات العمل"
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
