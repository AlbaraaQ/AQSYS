Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmClientsSMSAlarm
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents timer1 As Timer
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents lblStatus As Label

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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        lblStatus = New Label()
        GroupBox1 = New GroupBox()
        lblCount = New Label()
        btnPreview = New Button()
        btnShow = New Button()
        timer1 = New Timer(components)
        GroupBox2 = New GroupBox()
        dgvData = New DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.Location = New Point(3, 74)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(749, 23)
        ProgressBar1.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(555, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 23
        Button1.Text = "خروج"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatus.ImeMode = ImeMode.NoControl
        lblStatus.Location = New Point(558, 113)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 21
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblCount)
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(lblStatus)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(755, 100)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "تذكير العملاء الذين مر 4 شهور وأكثر على فواتيرهم"
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCount.ImeMode = ImeMode.NoControl
        lblCount.Location = New Point(558, 113)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(100, 23)
        lblCount.TabIndex = 25
        lblCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.ImeMode = ImeMode.NoControl
        btnPreview.Location = New Point(558, 113)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 5
        btnPreview.Text = "إرسال SMS"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.ImeMode = ImeMode.NoControl
        btnShow.Location = New Point(558, 113)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 4
        btnShow.Text = "عرض العملاء"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' timer1
        ' 
        timer1.Enabled = True
        timer1.Interval = 1000
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvData)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 100)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(755, 0)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvData.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {Column6, Column1, Column2, Column3, Column4, Column5, Column7})
        dgvData.Dock = DockStyle.Fill
        dgvData.Location = New Point(3, 20)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.RowHeadersWidth = 51
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(749, 0)
        dgvData.TabIndex = 3
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "id"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم العميل"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 60
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "إسم العميل"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 170
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Column3.DefaultCellStyle = DataGridViewCellStyle2
        Column3.HeaderText = "رقم الجوال"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 120
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "المدينة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 120
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الحي"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 120
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "آخر إرسال"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, -80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(749, 100)
        Panel1.TabIndex = 2
        Panel1.Visible = False
        ' 
        ' frmClientsSMSAlarm
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(755, 23)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "frmClientsSMSAlarm"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تذكير العملاء"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
