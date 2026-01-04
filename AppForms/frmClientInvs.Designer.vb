Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmClientInvs
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
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
    Friend WithEvents txtSum As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtVAT As Label

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
        txtDateTo = New DateTimePicker()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        chkAll = New CheckBox()
        btnClose = New Button()
        btnPreview = New Button()
        btnPrint = New Button()
        btnShow = New Button()
        cmbClients = New ComboBox()
        txtDateFrom = New DateTimePicker()
        Label15 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label7 = New Label()
        txtTotal = New Label()
        Label5 = New Label()
        txtVAT = New Label()
        Label3 = New Label()
        txtSum = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtDateTo
        ' 
        txtDateTo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateTo.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateTo.DropDownAlign = LeftRightAlignment.Right
        txtDateTo.Format = DateTimePickerFormat.Short
        txtDateTo.Location = New Point(-298, 20)
        txtDateTo.Name = "txtDateTo"
        txtDateTo.Size = New Size(200, 24)
        txtDateTo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(-314, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 17)
        Label2.TabIndex = 15
        Label2.Text = "إلى"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
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
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(148, 100)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(-314, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 26
        Button1.Text = "طباعة صغير"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Checked = True
        chkAll.CheckState = CheckState.Checked
        chkAll.Location = New Point(-252, 20)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 25
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.ImeMode = ImeMode.NoControl
        btnClose.Location = New Point(-298, 20)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 7
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.ImeMode = ImeMode.NoControl
        btnPreview.Location = New Point(-298, 20)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 5
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.ImeMode = ImeMode.NoControl
        btnPrint.Location = New Point(-298, 20)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 6
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.ImeMode = ImeMode.NoControl
        btnShow.Location = New Point(-298, 20)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbClients
        ' 
        cmbClients.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.Enabled = False
        cmbClients.FormattingEnabled = True
        cmbClients.Items.AddRange(New Object() {"آجلة", "نقدية"})
        cmbClients.Location = New Point(-298, 20)
        cmbClients.Name = "cmbClients"
        cmbClients.Size = New Size(121, 24)
        cmbClients.TabIndex = 0
        ' 
        ' txtDateFrom
        ' 
        txtDateFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDateFrom.CalendarFont = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDateFrom.DropDownAlign = LeftRightAlignment.Right
        txtDateFrom.Format = DateTimePickerFormat.Short
        txtDateFrom.Location = New Point(-298, 20)
        txtDateFrom.Name = "txtDateFrom"
        txtDateFrom.Size = New Size(200, 24)
        txtDateFrom.TabIndex = 2
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.ImeMode = ImeMode.NoControl
        Label15.Location = New Point(-314, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 17)
        Label15.TabIndex = 24
        Label15.Text = "اسم العميل"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(-314, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 17)
        Label1.TabIndex = 15
        Label1.Text = "التاريخ"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 100)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(148, 210)
        GroupBox2.TabIndex = 9
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 20)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 25
        dgvItems.Size = New Size(142, 87)
        dgvItems.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الصنف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 250
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "السعر"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        Column2.Width = 70
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "العدد"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الإجمالي"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 90
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtTotal)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtVAT)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtSum)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 107)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(142, 100)
        Panel1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label7.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(-424, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 9
        Label7.Text = "المبلغ الإجمالي"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtTotal
        ' 
        txtTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtTotal.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotal.ImeMode = ImeMode.NoControl
        txtTotal.Location = New Point(-408, 20)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 10
        txtTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(-424, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 9
        Label5.Text = "الضريبة"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtVAT
        ' 
        txtVAT.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtVAT.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtVAT.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtVAT.ImeMode = ImeMode.NoControl
        txtVAT.Location = New Point(-408, 20)
        txtVAT.Name = "txtVAT"
        txtVAT.Size = New Size(100, 23)
        txtVAT.TabIndex = 10
        txtVAT.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(-424, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 9
        Label3.Text = "الاجمالي"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSum
        ' 
        txtSum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSum.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSum.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSum.ImeMode = ImeMode.NoControl
        txtSum.Location = New Point(-408, 20)
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(100, 23)
        txtSum.TabIndex = 10
        txtSum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmClientInvs
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(148, 20)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "frmClientInvs"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تقرير مشتريات عميل"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class
