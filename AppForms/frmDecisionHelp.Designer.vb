Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmDecisionHelp
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllCurrency As CheckBox
    Friend WithEvents chkAllSafes As CheckBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbSafes As ComboBox
    Friend WithEvents dgvItems As DataGridView

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
        Label1 = New Label()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        chkAllSafes = New CheckBox()
        btnShow = New Button()
        chkAllCurrency = New CheckBox()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        cmbSafes = New ComboBox()
        Label3 = New Label()
        cmbCurrency = New ComboBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.Font = New Font("Arial", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(365, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 37)
        Label1.TabIndex = 3
        Label1.Text = "معدل دوران وركود الأصناف"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(945, 70)
        Panel1.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkAllSafes)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(chkAllCurrency)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(cmbSafes)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cmbCurrency)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 70)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(945, 90)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' chkAllSafes
        ' 
        chkAllSafes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllSafes.AutoSize = True
        chkAllSafes.Location = New Point(535, 60)
        chkAllSafes.Margin = New Padding(3, 4, 3, 4)
        chkAllSafes.Name = "chkAllSafes"
        chkAllSafes.Size = New Size(58, 21)
        chkAllSafes.TabIndex = 7
        chkAllSafes.Text = "الكل"
        chkAllSafes.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(323, 21)
        btnShow.Margin = New Padding(3, 4, 3, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(86, 43)
        btnShow.TabIndex = 2
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' chkAllCurrency
        ' 
        chkAllCurrency.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAllCurrency.AutoSize = True
        chkAllCurrency.Location = New Point(750, 60)
        chkAllCurrency.Margin = New Padding(3, 4, 3, 4)
        chkAllCurrency.Name = "chkAllCurrency"
        chkAllCurrency.Size = New Size(58, 21)
        chkAllCurrency.TabIndex = 6
        chkAllCurrency.Text = "الكل"
        chkAllCurrency.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(46, 21)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(86, 43)
        btnClose.TabIndex = 5
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(138, 21)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(86, 43)
        btnPrint.TabIndex = 4
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(231, 21)
        btnPreview.Margin = New Padding(3, 4, 3, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(86, 43)
        btnPreview.TabIndex = 3
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' cmbSafes
        ' 
        cmbSafes.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSafes.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSafes.FormattingEnabled = True
        cmbSafes.Location = New Point(437, 31)
        cmbSafes.Margin = New Padding(3, 4, 3, 4)
        cmbSafes.Name = "cmbSafes"
        cmbSafes.Size = New Size(158, 24)
        cmbSafes.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(599, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 17)
        Label3.TabIndex = 2
        Label3.Text = "المخزن"
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCurrency.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(670, 32)
        cmbCurrency.Margin = New Padding(3, 4, 3, 4)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(140, 24)
        cmbCurrency.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(814, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 17)
        Label2.TabIndex = 0
        Label2.Text = "الصنف"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 160)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(945, 436)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "النتائج"
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
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(3, 21)
        dgvItems.Margin = New Padding(3, 4, 3, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(939, 411)
        dgvItems.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم الصنف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الصنف"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 120
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "المبلغ الوارد"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "المبلغ الصادر"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الرصيد الان"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "معدل الركود"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 130
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "معدل الدوران"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 130
        ' 
        ' frmDecisionHelp
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(945, 596)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmDecisionHelp"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "مساعدة في اتخاذ القرار"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
