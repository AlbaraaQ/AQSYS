Imports System.ComponentModel
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAreas
    Inherits Form

    Private components As IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCityAdd As Button
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnCountryAdd As Button
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents dgvAreas As DataGridView
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAreas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panel2 = New Panel()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnFirst = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnPrint = New ToolStripButton()
        btnClose = New ToolStripButton()
        dgvAreas = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        btnCityAdd = New Button()
        btnCountryAdd = New Button()
        cmbCity = New ComboBox()
        Label3 = New Label()
        cmbCountry = New ComboBox()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        panel2.SuspendLayout()
        toolStrip1.SuspendLayout()
        CType(dgvAreas, ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 539)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(790, 67)
        panel2.TabIndex = 10
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(788, 65)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
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
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
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
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
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
        ' dgvAreas
        ' 
        dgvAreas.AllowUserToAddRows = False
        dgvAreas.AllowUserToDeleteRows = False
        dgvAreas.AllowUserToOrderColumns = True
        dgvAreas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvAreas.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAreas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAreas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAreas.Columns.AddRange(New DataGridViewColumn() {Column3, Column1, Column2, Column4, Column5, Column6})
        dgvAreas.Location = New Point(14, 170)
        dgvAreas.Margin = New Padding(3, 4, 3, 4)
        dgvAreas.MultiSelect = False
        dgvAreas.Name = "dgvAreas"
        dgvAreas.ReadOnly = True
        dgvAreas.RowHeadersWidth = 51
        dgvAreas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAreas.Size = New Size(757, 321)
        dgvAreas.TabIndex = 5
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الرقم"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Visible = False
        Column3.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "اسم الدولة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "اسم المدينة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 200
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "اسم المنطقة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 200
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "رقم الدولة"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Visible = False
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "رقم المدينة"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        Column6.Width = 125
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(dgvAreas)
        GroupBox1.Controls.Add(btnCityAdd)
        GroupBox1.Controls.Add(btnCountryAdd)
        GroupBox1.Controls.Add(cmbCity)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cmbCountry)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(790, 606)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "ادخل بيانات المناطق"
        ' 
        ' btnCityAdd
        ' 
        btnCityAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCityAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCityAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCityAdd.ForeColor = Color.Lime
        btnCityAdd.Image = CType(resources.GetObject("btnCityAdd.Image"), Image)
        btnCityAdd.Location = New Point(134, 66)
        btnCityAdd.Margin = New Padding(3, 4, 3, 4)
        btnCityAdd.Name = "btnCityAdd"
        btnCityAdd.Size = New Size(40, 34)
        btnCityAdd.TabIndex = 3
        btnCityAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCountryAdd
        ' 
        btnCountryAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCountryAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCountryAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCountryAdd.ForeColor = Color.Lime
        btnCountryAdd.Image = CType(resources.GetObject("btnCountryAdd.Image"), Image)
        btnCountryAdd.Location = New Point(134, 33)
        btnCountryAdd.Margin = New Padding(3, 4, 3, 4)
        btnCountryAdd.Name = "btnCountryAdd"
        btnCountryAdd.Size = New Size(40, 34)
        btnCountryAdd.TabIndex = 1
        btnCountryAdd.UseVisualStyleBackColor = False
        ' 
        ' cmbCity
        ' 
        cmbCity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCity.FormattingEnabled = True
        cmbCity.Location = New Point(176, 70)
        cmbCity.Margin = New Padding(3, 4, 3, 4)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(433, 24)
        cmbCity.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(623, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 17)
        Label3.TabIndex = 0
        Label3.Text = "اسم المدينة"
        ' 
        ' cmbCountry
        ' 
        cmbCountry.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCountry.FormattingEnabled = True
        cmbCountry.Location = New Point(176, 37)
        cmbCountry.Margin = New Padding(3, 4, 3, 4)
        cmbCountry.Name = "cmbCountry"
        cmbCountry.Size = New Size(433, 24)
        cmbCountry.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(629, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 0
        Label1.Text = "اسم الدولة"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(134, 106)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(475, 24)
        txtName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(617, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 17)
        Label2.TabIndex = 1
        Label2.Text = "اسم المنطقة"
        ' 
        ' frmAreas
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(790, 606)
        Controls.Add(panel2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmAreas"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف المناطق"
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        CType(dgvAreas, ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
