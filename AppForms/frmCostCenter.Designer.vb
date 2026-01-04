Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCostCenter
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents dgvActs As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtName As TextBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostCenter))
        GroupBox1 = New GroupBox()
        dgvActs = New DataGridView()
        Column2 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        txtName = New TextBox()
        Label1 = New Label()
        btnClose = New ToolStripButton()
        btnPrint = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        toolStripSeparator1 = New ToolStripSeparator()
        btnFirst = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnLast = New ToolStripButton()
        btnDelete = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnNew = New ToolStripButton()
        toolStrip1 = New ToolStrip()
        panel2 = New Panel()
        GroupBox1.SuspendLayout()
        CType(dgvActs, System.ComponentModel.ISupportInitialize).BeginInit()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(dgvActs)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(443, 0)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' dgvActs
        ' 
        dgvActs.AllowUserToAddRows = False
        dgvActs.AllowUserToDeleteRows = False
        dgvActs.AllowUserToOrderColumns = True
        dgvActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvActs.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvActs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvActs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvActs.Columns.AddRange(New DataGridViewColumn() {Column2, Column1})
        dgvActs.Location = New Point(243, 0)
        dgvActs.MultiSelect = False
        dgvActs.Name = "dgvActs"
        dgvActs.ReadOnly = True
        dgvActs.RowHeadersWidth = 51
        dgvActs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvActs.Size = New Size(240, 150)
        dgvActs.TabIndex = 4
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الرقم"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        Column2.Width = 125
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.HeaderText = "مركز التكلفة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 300
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(243, 0)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 24)
        txtName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(243, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 17)
        Label1.TabIndex = 2
        Label1.Text = "مركز التكلفة"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(443, 279)
        btnClose.Text = "خروج"
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(443, 279)
        btnPrint.Text = "طباعة"
        btnPrint.Visible = False
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(443, 279)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 6)
        ' 
        ' btnFirst
        ' 
        btnFirst.AutoSize = False
        btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnFirst.Image = My.Resources.Resources.Firstt
        btnFirst.ImageScaling = ToolStripItemImageScaling.None
        btnFirst.ImageTransparentColor = Color.Magenta
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(443, 279)
        btnFirst.Text = "الأول"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoSize = False
        btnPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Image)
        btnPrevious.ImageScaling = ToolStripItemImageScaling.None
        btnPrevious.ImageTransparentColor = Color.Magenta
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(443, 279)
        btnPrevious.Text = "السابق"
        ' 
        ' btnNext
        ' 
        btnNext.AutoSize = False
        btnNext.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.ImageScaling = ToolStripItemImageScaling.None
        btnNext.ImageTransparentColor = Color.Magenta
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(443, 279)
        btnNext.Text = "التالي"
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnLast.Image = CType(resources.GetObject("btnLast.Image"), Image)
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(443, 279)
        btnLast.Text = "الأخير"
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(443, 279)
        btnDelete.Text = "حذف"
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(443, 279)
        btnSave.Text = "حفظ"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(443, 279)
        btnNew.Text = "جديد"
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(441, 277)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 0)
        panel2.Name = "panel2"
        panel2.Size = New Size(443, 279)
        panel2.TabIndex = 7
        ' 
        ' frmCostCenter
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(443, 279)
        Controls.Add(GroupBox1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        Name = "frmCostCenter"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "مراكز التكلفة"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvActs, System.ComponentModel.ISupportInitialize).EndInit()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
