Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCountries
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents dgvCountries As DataGridView
    Friend WithEvents lnkAdd As LinkLabel
    Friend WithEvents lnkClear As LinkLabel
    Friend WithEvents panel2 As Panel
    Friend WithEvents picFlag As PictureBox
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNationality As TextBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCountries))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnLast = New ToolStripButton()
        GroupBox1 = New GroupBox()
        lnkClear = New LinkLabel()
        lnkAdd = New LinkLabel()
        picFlag = New PictureBox()
        dgvCountries = New DataGridView()
        Column2 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        txtNationality = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        btnNext = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnPrevious = New ToolStripButton()
        btnPrint = New ToolStripButton()
        btnFirst = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnSave = New ToolStripButton()
        btnNew = New ToolStripButton()
        toolStrip1 = New ToolStrip()
        btnClose = New ToolStripButton()
        panel2 = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCountries, System.ComponentModel.ISupportInitialize).BeginInit()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnLast.Image = CType(resources.GetObject("btnLast.Image"), Image)
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(50, 50)
        btnLast.Text = "الأخير"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(lnkClear)
        GroupBox1.Controls.Add(lnkAdd)
        GroupBox1.Controls.Add(picFlag)
        GroupBox1.Controls.Add(dgvCountries)
        GroupBox1.Controls.Add(txtNationality)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(683, 459)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل بيانات الدول  "
        ' 
        ' lnkClear
        ' 
        lnkClear.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lnkClear.AutoSize = True
        lnkClear.Location = New Point(35, 175)
        lnkClear.Name = "lnkClear"
        lnkClear.Size = New Size(43, 17)
        lnkClear.TabIndex = 4
        lnkClear.TabStop = True
        lnkClear.Text = "مسح"
        ' 
        ' lnkAdd
        ' 
        lnkAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lnkAdd.AutoSize = True
        lnkAdd.Location = New Point(114, 175)
        lnkAdd.Name = "lnkAdd"
        lnkAdd.Size = New Size(74, 17)
        lnkAdd.TabIndex = 4
        lnkAdd.TabStop = True
        lnkAdd.Text = "اختر صورة"
        ' 
        ' picFlag
        ' 
        picFlag.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picFlag.BorderStyle = BorderStyle.FixedSingle
        picFlag.Location = New Point(35, 59)
        picFlag.Margin = New Padding(3, 4, 3, 4)
        picFlag.Name = "picFlag"
        picFlag.Size = New Size(143, 112)
        picFlag.SizeMode = PictureBoxSizeMode.StretchImage
        picFlag.TabIndex = 3
        picFlag.TabStop = False
        ' 
        ' dgvCountries
        ' 
        dgvCountries.AllowUserToAddRows = False
        dgvCountries.AllowUserToDeleteRows = False
        dgvCountries.AllowUserToOrderColumns = True
        dgvCountries.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvCountries.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCountries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCountries.Columns.AddRange(New DataGridViewColumn() {Column2, Column1, Column3})
        dgvCountries.Location = New Point(35, 204)
        dgvCountries.Margin = New Padding(3, 4, 3, 4)
        dgvCountries.MultiSelect = False
        dgvCountries.Name = "dgvCountries"
        dgvCountries.ReadOnly = True
        dgvCountries.RowHeadersWidth = 51
        dgvCountries.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCountries.Size = New Size(589, 231)
        dgvCountries.TabIndex = 2
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
        Column1.HeaderText = "اسم الدولة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 300
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الجنسية"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' txtNationality
        ' 
        txtNationality.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNationality.Location = New Point(314, 75)
        txtNationality.Margin = New Padding(3, 4, 3, 4)
        txtNationality.Name = "txtNationality"
        txtNationality.Size = New Size(217, 24)
        txtNationality.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(547, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 17)
        Label2.TabIndex = 2
        Label2.Text = "اسم الجنسية"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(194, 42)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(337, 24)
        txtName.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(71, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 17)
        Label3.TabIndex = 2
        Label3.Text = "صورة العلم"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(547, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 2
        Label1.Text = "اسم الدولة"
        ' 
        ' btnNext
        ' 
        btnNext.AutoSize = False
        btnNext.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.ImageScaling = ToolStripItemImageScaling.None
        btnNext.ImageTransparentColor = Color.Magenta
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(50, 50)
        btnNext.Text = "التالي"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoSize = False
        btnPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Image)
        btnPrevious.ImageScaling = ToolStripItemImageScaling.None
        btnPrevious.ImageTransparentColor = Color.Magenta
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(50, 50)
        btnPrevious.Text = "السابق"
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(50, 50)
        btnPrint.Text = "طباعة"
        ' 
        ' btnFirst
        ' 
        btnFirst.AutoSize = False
        btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnFirst.Image = My.Resources.Resources.Firstt
        btnFirst.ImageScaling = ToolStripItemImageScaling.None
        btnFirst.ImageTransparentColor = Color.Magenta
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(50, 50)
        btnFirst.Text = "الأول"
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(50, 50)
        btnDelete.Text = "حذف"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
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
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(50, 50)
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
        toolStrip1.Size = New Size(681, 65)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
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
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 459)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(683, 67)
        panel2.TabIndex = 3
        ' 
        ' frmCountries
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(683, 526)
        Controls.Add(GroupBox1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCountries"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف الدول"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCountries, System.ComponentModel.ISupportInitialize).EndInit()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
