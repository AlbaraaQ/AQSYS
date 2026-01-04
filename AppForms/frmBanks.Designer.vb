Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmBanks
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAreaAdd As Button
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
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents dgvBanks As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtTel As TextBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBanks))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnClose = New ToolStripButton()
        btnPrint = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnFirst = New ToolStripButton()
        panel2 = New Panel()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        dgvBanks = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        txtMobile = New TextBox()
        Label10 = New Label()
        txtNotes = New TextBox()
        Label5 = New Label()
        btnCityAdd = New Button()
        btnCountryAdd = New Button()
        btnAreaAdd = New Button()
        cmbArea = New ComboBox()
        Label4 = New Label()
        cmbCity = New ComboBox()
        Label9 = New Label()
        cmbCountry = New ComboBox()
        Label3 = New Label()
        txtTel = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label7 = New Label()
        panel2.SuspendLayout()
        toolStrip1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
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
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 484)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(898, 67)
        panel2.TabIndex = 12
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(896, 65)
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
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightBlue
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(txtMobile)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtNotes)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(btnCityAdd)
        GroupBox2.Controls.Add(btnCountryAdd)
        GroupBox2.Controls.Add(btnAreaAdd)
        GroupBox2.Controls.Add(cmbArea)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(cmbCity)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(cmbCountry)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtTel)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(898, 484)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "ادخل بيانات البنوك"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.Controls.Add(dgvBanks)
        GroupBox1.Location = New Point(14, 224)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(871, 235)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات البنوك"
        ' 
        ' dgvBanks
        ' 
        dgvBanks.AllowUserToAddRows = False
        dgvBanks.AllowUserToDeleteRows = False
        dgvBanks.AllowUserToOrderColumns = True
        dgvBanks.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBanks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBanks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBanks.Columns.AddRange(New DataGridViewColumn() {Column3, Column1, Column2, Column4, Column7, Column5, Column6})
        dgvBanks.Dock = DockStyle.Fill
        dgvBanks.Location = New Point(3, 21)
        dgvBanks.Margin = New Padding(3, 4, 3, 4)
        dgvBanks.MultiSelect = False
        dgvBanks.Name = "dgvBanks"
        dgvBanks.ReadOnly = True
        dgvBanks.RowHeadersWidth = 51
        dgvBanks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBanks.Size = New Size(865, 210)
        dgvBanks.TabIndex = 0
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
        Column1.HeaderText = "اسم البنك"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الدولة"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 120
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "المدينة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 120
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "المنطقة"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "تليفون"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "موبايل"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' txtMobile
        ' 
        txtMobile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMobile.Location = New Point(350, 118)
        txtMobile.Margin = New Padding(3, 4, 3, 4)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(142, 24)
        txtMobile.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(502, 122)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 17)
        Label10.TabIndex = 13
        Label10.Text = "موبايل"
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(121, 162)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(667, 45)
        txtNotes.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(803, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 13
        Label5.Text = "ملاحظات"
        ' 
        ' btnCityAdd
        ' 
        btnCityAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCityAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCityAdd.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCityAdd.ForeColor = Color.Lime
        btnCityAdd.Image = CType(resources.GetObject("btnCityAdd.Image"), Image)
        btnCityAdd.Location = New Point(350, 71)
        btnCityAdd.Margin = New Padding(3, 4, 3, 4)
        btnCityAdd.Name = "btnCityAdd"
        btnCityAdd.Size = New Size(27, 28)
        btnCityAdd.TabIndex = 4
        btnCityAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCountryAdd
        ' 
        btnCountryAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCountryAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCountryAdd.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCountryAdd.ForeColor = Color.Lime
        btnCountryAdd.Image = CType(resources.GetObject("btnCountryAdd.Image"), Image)
        btnCountryAdd.Location = New Point(632, 71)
        btnCountryAdd.Margin = New Padding(3, 4, 3, 4)
        btnCountryAdd.Name = "btnCountryAdd"
        btnCountryAdd.Size = New Size(27, 28)
        btnCountryAdd.TabIndex = 2
        btnCountryAdd.UseVisualStyleBackColor = False
        ' 
        ' btnAreaAdd
        ' 
        btnAreaAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAreaAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAreaAdd.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAreaAdd.ForeColor = Color.Lime
        btnAreaAdd.Image = CType(resources.GetObject("btnAreaAdd.Image"), Image)
        btnAreaAdd.Location = New Point(121, 70)
        btnAreaAdd.Margin = New Padding(3, 4, 3, 4)
        btnAreaAdd.Name = "btnAreaAdd"
        btnAreaAdd.Size = New Size(27, 28)
        btnAreaAdd.TabIndex = 6
        btnAreaAdd.UseVisualStyleBackColor = False
        ' 
        ' cmbArea
        ' 
        cmbArea.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbArea.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbArea.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbArea.FormattingEnabled = True
        cmbArea.Location = New Point(149, 71)
        cmbArea.Margin = New Padding(3, 4, 3, 4)
        cmbArea.Name = "cmbArea"
        cmbArea.Size = New Size(108, 24)
        cmbArea.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(259, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 17)
        Label4.TabIndex = 7
        Label4.Text = "المنطقة"
        ' 
        ' cmbCity
        ' 
        cmbCity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCity.FormattingEnabled = True
        cmbCity.Location = New Point(378, 73)
        cmbCity.Margin = New Padding(3, 4, 3, 4)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(114, 24)
        cmbCity.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(499, 78)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 17)
        Label9.TabIndex = 5
        Label9.Text = "المدينة"
        ' 
        ' cmbCountry
        ' 
        cmbCountry.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCountry.FormattingEnabled = True
        cmbCountry.Location = New Point(659, 73)
        cmbCountry.Margin = New Padding(3, 4, 3, 4)
        cmbCountry.Name = "cmbCountry"
        cmbCountry.Size = New Size(129, 24)
        cmbCountry.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(821, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 5
        Label3.Text = "الدولة"
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTel.Location = New Point(632, 118)
        txtTel.Margin = New Padding(3, 4, 3, 4)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(156, 24)
        txtTel.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(818, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 17)
        Label2.TabIndex = 3
        Label2.Text = "تليفون"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(121, 28)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(667, 24)
        txtName.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(795, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 17)
        Label7.TabIndex = 0
        Label7.Text = "اسم البنك"
        ' 
        ' frmBanks
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 551)
        Controls.Add(GroupBox2)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmBanks"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف البنوك"
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvBanks, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
