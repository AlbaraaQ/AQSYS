Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmInvBySalesMen
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
    Friend WithEvents cmbEmps As ComboBox
    Friend WithEvents dgvItems As DataGridView
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
        Panel1 = New Panel()
        txtSum = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
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
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewButtonColumn()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtSum)
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 573)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1201, 43)
        Panel1.TabIndex = 7
        ' 
        ' txtSum
        ' 
        txtSum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSum.BackColor = SystemColors.Control
        txtSum.BorderStyle = BorderStyle.None
        txtSum.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtSum.ForeColor = Color.Red
        txtSum.Location = New Point(166, 3)
        txtSum.Margin = New Padding(4, 4, 4, 4)
        txtSum.Multiline = True
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(198, 35)
        txtSum.TabIndex = 0
        txtSum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(365, 3)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(832, 35)
        Label5.TabIndex = 3
        Label5.Text = "الاجمالي"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
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
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1201, 169)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل بيانات البحث"
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Location = New Point(893, 61)
        chkAll.Margin = New Padding(4, 4, 4, 4)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 36
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(108, 30)
        txtDateTo.Margin = New Padding(4, 4, 4, 4)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(170, 24)
        txtDateTo.TabIndex = 3
        txtDateTo.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(284, 34)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 13
        Label3.Text = "الى تاريخ"
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(365, 30)
        txtDateFrom.Margin = New Padding(4, 4, 4, 4)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(170, 24)
        txtDateFrom.TabIndex = 2
        txtDateFrom.Value = New Date(2012, 9, 21, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(546, 35)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 12
        Label4.Text = "من تاريخ"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(256, 98)
        btnClose.Margin = New Padding(4, 4, 4, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(176, 59)
        btnClose.TabIndex = 7
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(440, 98)
        btnPrint.Margin = New Padding(4, 4, 4, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(176, 59)
        btnPrint.TabIndex = 6
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(624, 98)
        btnPreview.Margin = New Padding(4, 4, 4, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(176, 59)
        btnPreview.TabIndex = 5
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(807, 98)
        btnShow.Margin = New Padding(4, 4, 4, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(176, 59)
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
        cmbEmps.Location = New Point(737, 30)
        cmbEmps.Margin = New Padding(4, 4, 4, 4)
        cmbEmps.Name = "cmbEmps"
        cmbEmps.Size = New Size(215, 25)
        cmbEmps.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(957, 35)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 17)
        Label2.TabIndex = 1
        Label2.Text = "المندوب"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 169)
        GroupBox2.Margin = New Padding(4, 4, 4, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 4, 4, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1201, 404)
        GroupBox2.TabIndex = 9
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
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column6, Column9, Column4, Column5, Column7})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(4, 21)
        dgvItems.Margin = New Padding(4, 4, 4, 4)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(1193, 379)
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
        ' Column6
        ' 
        Column6.HeaderText = "المندوب"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "قيمة الفاتورة"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "العمولة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "المبلغ المحصل"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "عرض"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Resizable = DataGridViewTriState.True
        Column7.SortMode = DataGridViewColumnSortMode.Automatic
        Column7.Text = "View"
        Column7.ToolTipText = "عرض الفاتورة"
        Column7.UseColumnTextForButtonValue = True
        Column7.Visible = False
        Column7.Width = 120
        ' 
        ' frmInvBySalesMen
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1201, 616)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmInvBySalesMen"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "مبيعات مندوب خلال فترة"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
