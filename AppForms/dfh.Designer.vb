Imports System.Runtime.CompilerServices

Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class dfh
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents dgvCurrencies As DataGridView
    Friend WithEvents lblCurr As Label
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents txtVal As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator

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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(dfh))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        toolStrip1 = New ToolStrip()
        btnSave = New ToolStripButton()
        btnClose = New ToolStripButton()
        GroupBox4 = New GroupBox()
        dgvCurrencies = New DataGridView()
        Column4 = New DataGridViewComboBoxColumn()
        Column1 = New DataGridViewCheckBoxColumn()
        Panel2 = New Panel()
        lblCurr = New Label()
        txtVal = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        toolStrip1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvCurrencies, ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(toolStrip1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 387)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(535, 75)
        Panel1.TabIndex = 4
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnSave, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(535, 75)
        toolStrip1.TabIndex = 1
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 50)
        btnSave.Text = "حفظ"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.Text = "خروج"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvCurrencies)
        GroupBox4.Controls.Add(Panel2)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Location = New Point(0, 0)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.Size = New Size(535, 387)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "الرقابة على بيع وشراء الأصناف التالية"
        ' 
        ' dgvCurrencies
        ' 
        dgvCurrencies.AllowUserToDeleteRows = False
        dgvCurrencies.AllowUserToOrderColumns = True
        dgvCurrencies.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCurrencies.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCurrencies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCurrencies.Columns.AddRange(New DataGridViewColumn() {Column4, Column1})
        dgvCurrencies.Dock = DockStyle.Fill
        dgvCurrencies.Location = New Point(3, 21)
        dgvCurrencies.Margin = New Padding(3, 4, 3, 4)
        dgvCurrencies.MultiSelect = False
        dgvCurrencies.Name = "dgvCurrencies"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCurrencies.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCurrencies.RowHeadersWidth = 51
        dgvCurrencies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCurrencies.Size = New Size(529, 296)
        dgvCurrencies.TabIndex = 1
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "الصنف"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.Automatic
        Column4.Width = 250
        ' 
        ' Column1
        ' 
        Column1.FalseValue = "0"
        Column1.HeaderText = "رقابة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.Automatic
        Column1.TrueValue = "1"
        Column1.Width = 125
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblCurr)
        Panel2.Controls.Add(txtVal)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(3, 317)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(529, 66)
        Panel2.TabIndex = 0
        ' 
        ' lblCurr
        ' 
        lblCurr.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCurr.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblCurr.Location = New Point(20, 22)
        lblCurr.Name = "lblCurr"
        lblCurr.Size = New Size(135, 22)
        lblCurr.TabIndex = 2
        lblCurr.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtVal
        ' 
        txtVal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtVal.Location = New Point(171, 21)
        txtVal.Margin = New Padding(3, 4, 3, 4)
        txtVal.Name = "txtVal"
        txtVal.Size = New Size(103, 24)
        txtVal.TabIndex = 1
        txtVal.Text = "10000"
        txtVal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(284, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 17)
        Label1.TabIndex = 0
        Label1.Text = "رقابة على عملية الصرف لأكثر من :"
        ' 
        ' dfh
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 462)
        Controls.Add(GroupBox4)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "dfh"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "الرقابة على بيع وشراء الأصناف"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(dgvCurrencies, ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
