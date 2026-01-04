Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmErsaliaExpenses
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbErsSuppliers As ComboBox
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents pnlErsalia As GroupBox
    Friend WithEvents txtComm As TextBox
    Friend WithEvents txtErsNo As TextBox
    Friend WithEvents txtTotVal As Label

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
        pnlErsalia = New GroupBox()
        txtErsNo = New TextBox()
        Label50 = New Label()
        Label49 = New Label()
        cmbErsSuppliers = New ComboBox()
        GroupBox1 = New GroupBox()
        dgvExpenses = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        txtTotVal = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        txtComm = New TextBox()
        Label1 = New Label()
        btnSave = New Button()
        btnClose = New Button()
        pnlErsalia.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlErsalia
        ' 
        pnlErsalia.Controls.Add(txtErsNo)
        pnlErsalia.Controls.Add(Label50)
        pnlErsalia.Controls.Add(Label49)
        pnlErsalia.Controls.Add(cmbErsSuppliers)
        pnlErsalia.Location = New Point(25, 4)
        pnlErsalia.Name = "pnlErsalia"
        pnlErsalia.Size = New Size(200, 100)
        pnlErsalia.TabIndex = 191
        pnlErsalia.TabStop = False
        pnlErsalia.Text = "اختر إرسالية"
        ' 
        ' txtErsNo
        ' 
        txtErsNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtErsNo.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtErsNo.Location = New Point(25, 4)
        txtErsNo.MaxLength = 50
        txtErsNo.Name = "txtErsNo"
        txtErsNo.Size = New Size(100, 26)
        txtErsNo.TabIndex = 206
        txtErsNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label50
        ' 
        Label50.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label50.AutoSize = True
        Label50.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label50.ImeMode = ImeMode.NoControl
        Label50.Location = New Point(0, 0)
        Label50.Name = "Label50"
        Label50.Size = New Size(96, 24)
        Label50.TabIndex = 207
        Label50.Text = "رقم الإرسالية"
        ' 
        ' Label49
        ' 
        Label49.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label49.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label49.ImeMode = ImeMode.NoControl
        Label49.Location = New Point(0, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(100, 23)
        Label49.TabIndex = 205
        Label49.Text = "المورد"
        Label49.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbErsSuppliers
        ' 
        cmbErsSuppliers.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbErsSuppliers.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbErsSuppliers.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbErsSuppliers.BackColor = Color.White
        cmbErsSuppliers.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        cmbErsSuppliers.FormattingEnabled = True
        cmbErsSuppliers.Location = New Point(25, 4)
        cmbErsSuppliers.Name = "cmbErsSuppliers"
        cmbErsSuppliers.Size = New Size(121, 29)
        cmbErsSuppliers.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvExpenses)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 191
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل المصاريف"
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvExpenses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Columns.AddRange(New DataGridViewColumn() {Column1, Column3})
        dgvExpenses.Dock = DockStyle.Fill
        dgvExpenses.Location = New Point(3, 20)
        dgvExpenses.MultiSelect = False
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.RowHeadersWidth = 51
        dgvExpenses.Size = New Size(194, 0)
        dgvExpenses.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "إسم المصروف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 220
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "المبلغ"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtTotVal)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(194, 100)
        Panel1.TabIndex = 0
        ' 
        ' txtTotVal
        ' 
        txtTotVal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTotVal.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotVal.ImeMode = ImeMode.NoControl
        txtTotVal.Location = New Point(17, 4)
        txtTotVal.Name = "txtTotVal"
        txtTotVal.Size = New Size(100, 23)
        txtTotVal.TabIndex = 207
        txtTotVal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(-8, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 24)
        Label3.TabIndex = 207
        Label3.Text = "إجمالي المصاريف"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtComm)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 192
        GroupBox2.TabStop = False
        GroupBox2.Text = "العمولة"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 24)
        Label2.TabIndex = 208
        Label2.Text = "%"
        ' 
        ' txtComm
        ' 
        txtComm.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtComm.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtComm.Location = New Point(25, 4)
        txtComm.MaxLength = 50
        txtComm.Name = "txtComm"
        txtComm.Size = New Size(100, 26)
        txtComm.TabIndex = 206
        txtComm.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 24)
        Label1.TabIndex = 207
        Label1.Text = "مبلغ العمولة"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(25, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 193
        btnSave.Text = "حفظ"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(25, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 193
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmErsaliaExpenses
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(403, 50)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(pnlErsalia)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        Name = "frmErsaliaExpenses"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تسجيل مصاريف إرسالية"
        pnlErsalia.ResumeLayout(False)
        pnlErsalia.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
