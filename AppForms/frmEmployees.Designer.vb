Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmEmployees
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnDepAdd As Button
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnJobAdd As Button
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnManagAdd As Button
    Friend WithEvents btnNationalityAdd As Button
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbDeps As ComboBox
    Friend WithEvents cmbJob As ComboBox
    Friend WithEvents cmbManags As ComboBox
    Friend WithEvents cmbMaritalStatus As ComboBox
    Friend WithEvents cmbNationality As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dgvBranches As DataGridView
    Friend WithEvents dgvEmps As DataGridView
    Friend WithEvents lnkImgAdd As LinkLabel
    Friend WithEvents lnkImgClr As LinkLabel
    Friend WithEvents panel2 As Panel
    Friend WithEvents picImage As PictureBox
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtBirthDate As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFood As TextBox
    Friend WithEvents txtHouse As TextBox
    Friend WithEvents txtInsuranceNo As TextBox
    Friend WithEvents txtMedical As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNameSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtSalaryAdd As TextBox
    Friend WithEvents txtSalaryOther As TextBox
    Friend WithEvents txtSalaryTotal As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtTravel As TextBox
    Friend WithEvents txtWorkDate As DateTimePicker

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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        txtSalaryTotal = New TextBox()
        Label19 = New Label()
        txtMedical = New TextBox()
        txtFood = New TextBox()
        Label25 = New Label()
        txtSalaryOther = New TextBox()
        Label23 = New Label()
        Label18 = New Label()
        txtHouse = New TextBox()
        Label24 = New Label()
        txtTravel = New TextBox()
        Label20 = New Label()
        txtSalaryAdd = New TextBox()
        Label17 = New Label()
        txtBasicSalary = New TextBox()
        Label16 = New Label()
        GroupBox2 = New GroupBox()
        lnkImgClr = New LinkLabel()
        lnkImgAdd = New LinkLabel()
        picImage = New PictureBox()
        GroupBox5 = New GroupBox()
        rdFemale = New RadioButton()
        GroupBox7 = New GroupBox()
        dgvBranches = New DataGridView()
        DataGridViewComboBoxColumn1 = New DataGridViewComboBoxColumn()
        rdMale = New RadioButton()
        txtBirthDate = New DateTimePicker()
        txtWorkDate = New DateTimePicker()
        btnNationalityAdd = New Button()
        btnJobAdd = New Button()
        btnDepAdd = New Button()
        btnManagAdd = New Button()
        txtNotes = New TextBox()
        Label15 = New Label()
        txtAddress = New TextBox()
        Label14 = New Label()
        txtMobile = New TextBox()
        txtEmail = New TextBox()
        txtTel = New TextBox()
        Label21 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        cmbNationality = New ComboBox()
        cmbMaritalStatus = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        txtInsuranceNo = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        cmbDeps = New ComboBox()
        cmbJob = New ComboBox()
        cmbStatus = New ComboBox()
        cmbManags = New ComboBox()
        Label22 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btnLast = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnNext = New ToolStripButton()
        btnPrint = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnFirst = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnDelete = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnNew = New ToolStripButton()
        toolStrip1 = New ToolStrip()
        btnClose = New ToolStripButton()
        panel2 = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvEmps = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        GroupBox6 = New GroupBox()
        btnSearch = New Button()
        txtNameSrch = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox7.SuspendLayout()
        CType(dgvBranches, System.ComponentModel.ISupportInitialize).BeginInit()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvEmps, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(GroupBox5)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(3, 4)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1154, 550)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox3.Controls.Add(txtSalaryTotal)
        GroupBox3.Controls.Add(Label19)
        GroupBox3.Controls.Add(txtMedical)
        GroupBox3.Controls.Add(txtFood)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(txtSalaryOther)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(txtHouse)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(txtTravel)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(txtSalaryAdd)
        GroupBox3.Controls.Add(Label17)
        GroupBox3.Controls.Add(txtBasicSalary)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(9, 230)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.RightToLeft = RightToLeft.Yes
        GroupBox3.Size = New Size(278, 309)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "الرواتب والمستحقات"
        ' 
        ' txtSalaryTotal
        ' 
        txtSalaryTotal.Location = New Point(22, 263)
        txtSalaryTotal.Margin = New Padding(3, 4, 3, 4)
        txtSalaryTotal.Name = "txtSalaryTotal"
        txtSalaryTotal.ReadOnly = True
        txtSalaryTotal.Size = New Size(217, 24)
        txtSalaryTotal.TabIndex = 3
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Red
        Label19.Location = New Point(26, 235)
        Label19.Name = "Label19"
        Label19.Size = New Size(239, 21)
        Label19.TabIndex = 32
        Label19.Text = "اجمالي الرواتب والمستحقات"
        ' 
        ' txtMedical
        ' 
        txtMedical.Location = New Point(26, 142)
        txtMedical.Margin = New Padding(3, 4, 3, 4)
        txtMedical.Name = "txtMedical"
        txtMedical.Size = New Size(135, 24)
        txtMedical.TabIndex = 2
        ' 
        ' txtFood
        ' 
        txtFood.Location = New Point(26, 113)
        txtFood.Margin = New Padding(3, 4, 3, 4)
        txtFood.Name = "txtFood"
        txtFood.Size = New Size(135, 24)
        txtFood.TabIndex = 2
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(202, 146)
        Label25.Name = "Label25"
        Label25.Size = New Size(40, 17)
        Label25.TabIndex = 30
        Label25.Text = "طبي"
        ' 
        ' txtSalaryOther
        ' 
        txtSalaryOther.Location = New Point(26, 201)
        txtSalaryOther.Margin = New Padding(3, 4, 3, 4)
        txtSalaryOther.Name = "txtSalaryOther"
        txtSalaryOther.Size = New Size(135, 24)
        txtSalaryOther.TabIndex = 2
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(202, 118)
        Label23.Name = "Label23"
        Label23.Size = New Size(41, 17)
        Label23.TabIndex = 30
        Label23.Text = "طعام"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(200, 206)
        Label18.Name = "Label18"
        Label18.Size = New Size(44, 17)
        Label18.TabIndex = 30
        Label18.Text = "اخرى"
        ' 
        ' txtHouse
        ' 
        txtHouse.Location = New Point(26, 54)
        txtHouse.Margin = New Padding(3, 4, 3, 4)
        txtHouse.Name = "txtHouse"
        txtHouse.Size = New Size(135, 24)
        txtHouse.TabIndex = 1
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(201, 59)
        Label24.Name = "Label24"
        Label24.Size = New Size(43, 17)
        Label24.TabIndex = 28
        Label24.Text = "سكن"
        ' 
        ' txtTravel
        ' 
        txtTravel.Location = New Point(26, 85)
        txtTravel.Margin = New Padding(3, 4, 3, 4)
        txtTravel.Name = "txtTravel"
        txtTravel.Size = New Size(135, 24)
        txtTravel.TabIndex = 1
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(203, 90)
        Label20.Name = "Label20"
        Label20.Size = New Size(38, 17)
        Label20.TabIndex = 28
        Label20.Text = "سفر"
        ' 
        ' txtSalaryAdd
        ' 
        txtSalaryAdd.Location = New Point(26, 171)
        txtSalaryAdd.Margin = New Padding(3, 4, 3, 4)
        txtSalaryAdd.Name = "txtSalaryAdd"
        txtSalaryAdd.Size = New Size(135, 24)
        txtSalaryAdd.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(178, 176)
        Label17.Name = "Label17"
        Label17.Size = New Size(93, 17)
        Label17.TabIndex = 28
        Label17.Text = "مكافاءة ثابتة "
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Location = New Point(26, 26)
        txtBasicSalary.Margin = New Padding(3, 4, 3, 4)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(135, 24)
        txtBasicSalary.TabIndex = 0
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(169, 31)
        Label16.Name = "Label16"
        Label16.Size = New Size(110, 17)
        Label16.TabIndex = 0
        Label16.Text = "اساسي الراتب "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(lnkImgClr)
        GroupBox2.Controls.Add(lnkImgAdd)
        GroupBox2.Controls.Add(picImage)
        GroupBox2.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(9, 20)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(282, 198)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "صورة الموظف"
        ' 
        ' lnkImgClr
        ' 
        lnkImgClr.AutoSize = True
        lnkImgClr.Location = New Point(37, 159)
        lnkImgClr.Name = "lnkImgClr"
        lnkImgClr.Size = New Size(43, 17)
        lnkImgClr.TabIndex = 1
        lnkImgClr.TabStop = True
        lnkImgClr.Text = "مسح"
        ' 
        ' lnkImgAdd
        ' 
        lnkImgAdd.AutoSize = True
        lnkImgAdd.Location = New Point(105, 159)
        lnkImgAdd.Name = "lnkImgAdd"
        lnkImgAdd.Size = New Size(130, 17)
        lnkImgAdd.TabIndex = 0
        lnkImgAdd.TabStop = True
        lnkImgAdd.Text = "اختر صورة الموظف"
        ' 
        ' picImage
        ' 
        picImage.BorderStyle = BorderStyle.FixedSingle
        picImage.Location = New Point(40, 32)
        picImage.Margin = New Padding(3, 4, 3, 4)
        picImage.Name = "picImage"
        picImage.Size = New Size(183, 123)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox5.Controls.Add(rdFemale)
        GroupBox5.Controls.Add(GroupBox7)
        GroupBox5.Controls.Add(rdMale)
        GroupBox5.Controls.Add(txtBirthDate)
        GroupBox5.Controls.Add(txtWorkDate)
        GroupBox5.Controls.Add(btnNationalityAdd)
        GroupBox5.Controls.Add(btnJobAdd)
        GroupBox5.Controls.Add(btnDepAdd)
        GroupBox5.Controls.Add(btnManagAdd)
        GroupBox5.Controls.Add(txtNotes)
        GroupBox5.Controls.Add(Label15)
        GroupBox5.Controls.Add(txtAddress)
        GroupBox5.Controls.Add(Label14)
        GroupBox5.Controls.Add(txtMobile)
        GroupBox5.Controls.Add(txtEmail)
        GroupBox5.Controls.Add(txtTel)
        GroupBox5.Controls.Add(Label21)
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Controls.Add(Label12)
        GroupBox5.Controls.Add(cmbNationality)
        GroupBox5.Controls.Add(cmbMaritalStatus)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(Label10)
        GroupBox5.Controls.Add(txtInsuranceNo)
        GroupBox5.Controls.Add(Label9)
        GroupBox5.Controls.Add(Label8)
        GroupBox5.Controls.Add(Label7)
        GroupBox5.Controls.Add(Label6)
        GroupBox5.Controls.Add(Label5)
        GroupBox5.Controls.Add(cmbDeps)
        GroupBox5.Controls.Add(cmbJob)
        GroupBox5.Controls.Add(cmbStatus)
        GroupBox5.Controls.Add(cmbManags)
        GroupBox5.Controls.Add(Label22)
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Controls.Add(txtName)
        GroupBox5.Controls.Add(Label3)
        GroupBox5.Controls.Add(Label2)
        GroupBox5.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox5.Location = New Point(298, 20)
        GroupBox5.Margin = New Padding(3, 4, 3, 4)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(3, 4, 3, 4)
        GroupBox5.RightToLeft = RightToLeft.Yes
        GroupBox5.Size = New Size(845, 522)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "بيانات الموظف الاساسية"
        ' 
        ' rdFemale
        ' 
        rdFemale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdFemale.AutoSize = True
        rdFemale.Location = New Point(345, 302)
        rdFemale.Margin = New Padding(3, 4, 3, 4)
        rdFemale.Name = "rdFemale"
        rdFemale.Size = New Size(58, 21)
        rdFemale.TabIndex = 14
        rdFemale.Text = "أنثى"
        rdFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox7.Controls.Add(dgvBranches)
        GroupBox7.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox7.Location = New Point(21, 63)
        GroupBox7.Margin = New Padding(3, 4, 3, 4)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(3, 4, 3, 4)
        GroupBox7.RightToLeft = RightToLeft.Yes
        GroupBox7.Size = New Size(282, 378)
        GroupBox7.TabIndex = 5
        GroupBox7.TabStop = False
        GroupBox7.Text = "فروع الموظف"
        ' 
        ' dgvBranches
        ' 
        dgvBranches.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBranches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBranches.Columns.AddRange(New DataGridViewColumn() {DataGridViewComboBoxColumn1})
        dgvBranches.Dock = DockStyle.Fill
        dgvBranches.Location = New Point(3, 21)
        dgvBranches.Margin = New Padding(3, 4, 3, 4)
        dgvBranches.MultiSelect = False
        dgvBranches.Name = "dgvBranches"
        dgvBranches.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBranches.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvBranches.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBranches.Size = New Size(276, 353)
        dgvBranches.TabIndex = 1
        ' 
        ' DataGridViewComboBoxColumn1
        ' 
        DataGridViewComboBoxColumn1.HeaderText = "الفرع"
        DataGridViewComboBoxColumn1.MinimumWidth = 6
        DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        DataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True
        DataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic
        DataGridViewComboBoxColumn1.Width = 180
        ' 
        ' rdMale
        ' 
        rdMale.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdMale.AutoSize = True
        rdMale.Checked = True
        rdMale.Location = New Point(412, 302)
        rdMale.Margin = New Padding(3, 4, 3, 4)
        rdMale.Name = "rdMale"
        rdMale.Size = New Size(52, 21)
        rdMale.TabIndex = 13
        rdMale.TabStop = True
        rdMale.Text = "ذكر"
        rdMale.UseVisualStyleBackColor = True
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBirthDate.Format = DateTimePickerFormat.Short
        txtBirthDate.Location = New Point(326, 183)
        txtBirthDate.Margin = New Padding(3, 4, 3, 4)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.Size = New Size(159, 24)
        txtBirthDate.TabIndex = 7
        ' 
        ' txtWorkDate
        ' 
        txtWorkDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtWorkDate.Format = DateTimePickerFormat.Short
        txtWorkDate.Location = New Point(326, 224)
        txtWorkDate.Margin = New Padding(3, 4, 3, 4)
        txtWorkDate.Name = "txtWorkDate"
        txtWorkDate.Size = New Size(159, 24)
        txtWorkDate.TabIndex = 9
        ' 
        ' btnNationalityAdd
        ' 
        btnNationalityAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNationalityAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnNationalityAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnNationalityAdd.ForeColor = Color.Black
        btnNationalityAdd.Image = CType(resources.GetObject("btnNationalityAdd.Image"), Image)
        btnNationalityAdd.Location = New Point(327, 258)
        btnNationalityAdd.Margin = New Padding(3, 4, 3, 4)
        btnNationalityAdd.Name = "btnNationalityAdd"
        btnNationalityAdd.Size = New Size(29, 30)
        btnNationalityAdd.TabIndex = 32
        btnNationalityAdd.UseVisualStyleBackColor = False
        ' 
        ' btnJobAdd
        ' 
        btnJobAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnJobAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnJobAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnJobAdd.ForeColor = Color.Lime
        btnJobAdd.Image = CType(resources.GetObject("btnJobAdd.Image"), Image)
        btnJobAdd.Location = New Point(325, 142)
        btnJobAdd.Margin = New Padding(3, 4, 3, 4)
        btnJobAdd.Name = "btnJobAdd"
        btnJobAdd.Size = New Size(29, 30)
        btnJobAdd.TabIndex = 32
        btnJobAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDepAdd
        ' 
        btnDepAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDepAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnDepAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDepAdd.ForeColor = Color.Lime
        btnDepAdd.Image = CType(resources.GetObject("btnDepAdd.Image"), Image)
        btnDepAdd.Location = New Point(325, 105)
        btnDepAdd.Margin = New Padding(3, 4, 3, 4)
        btnDepAdd.Name = "btnDepAdd"
        btnDepAdd.Size = New Size(29, 30)
        btnDepAdd.TabIndex = 32
        btnDepAdd.UseVisualStyleBackColor = False
        ' 
        ' btnManagAdd
        ' 
        btnManagAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnManagAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnManagAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnManagAdd.ForeColor = Color.Lime
        btnManagAdd.Image = CType(resources.GetObject("btnManagAdd.Image"), Image)
        btnManagAdd.Location = New Point(569, 107)
        btnManagAdd.Margin = New Padding(3, 4, 3, 4)
        btnManagAdd.Name = "btnManagAdd"
        btnManagAdd.Size = New Size(29, 30)
        btnManagAdd.TabIndex = 32
        btnManagAdd.UseVisualStyleBackColor = False
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(326, 406)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(391, 34)
        txtNotes.TabIndex = 18
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(769, 411)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 17)
        Label15.TabIndex = 30
        Label15.Text = "ملاحظات"
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddress.Location = New Point(326, 368)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(391, 30)
        txtAddress.TabIndex = 17
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Location = New Point(779, 380)
        Label14.Name = "Label14"
        Label14.Size = New Size(53, 17)
        Label14.TabIndex = 28
        Label14.Text = "العنوان"
        ' 
        ' txtMobile
        ' 
        txtMobile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMobile.Location = New Point(581, 331)
        txtMobile.Margin = New Padding(3, 4, 3, 4)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(135, 24)
        txtMobile.TabIndex = 16
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmail.Location = New Point(581, 293)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(135, 24)
        txtEmail.TabIndex = 15
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTel.Location = New Point(581, 257)
        txtTel.Margin = New Padding(3, 4, 3, 4)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(135, 24)
        txtTel.TabIndex = 12
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Location = New Point(722, 300)
        Label21.Name = "Label21"
        Label21.Size = New Size(113, 17)
        Label21.TabIndex = 24
        Label21.Text = "البريد الالكتروني"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(749, 336)
        Label13.Name = "Label13"
        Label13.Size = New Size(88, 17)
        Label13.TabIndex = 25
        Label13.Text = "رقم الموبايل"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(758, 262)
        Label12.Name = "Label12"
        Label12.Size = New Size(78, 17)
        Label12.TabIndex = 24
        Label12.Text = "رقم الهاتف"
        ' 
        ' cmbNationality
        ' 
        cmbNationality.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbNationality.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbNationality.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbNationality.FormattingEnabled = True
        cmbNationality.Items.AddRange(New Object() {"ذكر", "انثى"})
        cmbNationality.Location = New Point(357, 261)
        cmbNationality.Margin = New Padding(3, 4, 3, 4)
        cmbNationality.Name = "cmbNationality"
        cmbNationality.Size = New Size(129, 25)
        cmbNationality.TabIndex = 11
        ' 
        ' cmbMaritalStatus
        ' 
        cmbMaritalStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbMaritalStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbMaritalStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbMaritalStatus.FormattingEnabled = True
        cmbMaritalStatus.Items.AddRange(New Object() {"اعزب", "متزوج", "ارمل", "مطلق"})
        cmbMaritalStatus.Location = New Point(581, 222)
        cmbMaritalStatus.Margin = New Padding(3, 4, 3, 4)
        cmbMaritalStatus.Name = "cmbMaritalStatus"
        cmbMaritalStatus.Size = New Size(135, 25)
        cmbMaritalStatus.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(505, 304)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 17)
        Label11.TabIndex = 21
        Label11.Text = "النوع"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(722, 226)
        Label10.Name = "Label10"
        Label10.Size = New Size(119, 17)
        Label10.TabIndex = 20
        Label10.Text = "الحالة الاجتماعية"
        ' 
        ' txtInsuranceNo
        ' 
        txtInsuranceNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtInsuranceNo.Location = New Point(581, 185)
        txtInsuranceNo.Margin = New Padding(3, 4, 3, 4)
        txtInsuranceNo.Name = "txtInsuranceNo"
        txtInsuranceNo.Size = New Size(137, 24)
        txtInsuranceNo.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(494, 266)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 17)
        Label9.TabIndex = 17
        Label9.Text = "الجنسية"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(745, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 17)
        Label8.TabIndex = 16
        Label8.Text = "رقم التأمينات"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(489, 228)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 17)
        Label7.TabIndex = 14
        Label7.Text = "تاريخ التعيين"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(493, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 17)
        Label6.TabIndex = 11
        Label6.Text = "تاريخ الميلاد"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(786, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 17)
        Label5.TabIndex = 10
        Label5.Text = "الحالة"
        ' 
        ' cmbDeps
        ' 
        cmbDeps.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbDeps.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbDeps.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbDeps.FormattingEnabled = True
        cmbDeps.Location = New Point(355, 107)
        cmbDeps.Margin = New Padding(3, 4, 3, 4)
        cmbDeps.Name = "cmbDeps"
        cmbDeps.Size = New Size(129, 25)
        cmbDeps.TabIndex = 3
        ' 
        ' cmbJob
        ' 
        cmbJob.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbJob.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbJob.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbJob.FormattingEnabled = True
        cmbJob.Location = New Point(355, 144)
        cmbJob.Margin = New Padding(3, 4, 3, 4)
        cmbJob.Name = "cmbJob"
        cmbJob.Size = New Size(129, 25)
        cmbJob.TabIndex = 5
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(601, 145)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(115, 25)
        cmbStatus.TabIndex = 4
        ' 
        ' cmbManags
        ' 
        cmbManags.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbManags.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbManags.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbManags.FormattingEnabled = True
        cmbManags.Location = New Point(600, 108)
        cmbManags.Margin = New Padding(3, 4, 3, 4)
        cmbManags.Name = "cmbManags"
        cmbManags.Size = New Size(115, 25)
        cmbManags.TabIndex = 2
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label22.AutoSize = True
        Label22.Location = New Point(498, 151)
        Label22.Name = "Label22"
        Label22.Size = New Size(58, 17)
        Label22.TabIndex = 5
        Label22.Text = "الوظيفة"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(498, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 17)
        Label4.TabIndex = 5
        Label4.Text = "القسم"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(325, 74)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(391, 24)
        txtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(784, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 17)
        Label3.TabIndex = 2
        Label3.Text = "الادارة"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(743, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 17)
        Label2.TabIndex = 1
        Label2.Text = "اسم الموظف"
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
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
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
        toolStrip1.Size = New Size(1166, 65)
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
        panel2.Location = New Point(0, 587)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(1168, 67)
        panel2.TabIndex = 8
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1168, 587)
        TabControl1.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1160, 558)
        TabPage1.TabIndex = 0
        TabPage1.Text = "            بيانـــات الموظفيـــــن            "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1160, 557)
        TabPage2.TabIndex = 1
        TabPage2.Text = "                    البحــــــــــث              "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightBlue
        GroupBox4.Controls.Add(dgvEmps)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(3, 101)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(1154, 452)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "المـــــوظفين"
        ' 
        ' dgvEmps
        ' 
        dgvEmps.AllowUserToAddRows = False
        dgvEmps.AllowUserToDeleteRows = False
        dgvEmps.AllowUserToOrderColumns = True
        dgvEmps.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgvEmps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmps.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, Column5, Column6, Column7, Column8})
        dgvEmps.Dock = DockStyle.Fill
        dgvEmps.Location = New Point(3, 21)
        dgvEmps.Margin = New Padding(3, 4, 3, 4)
        dgvEmps.MultiSelect = False
        dgvEmps.Name = "dgvEmps"
        dgvEmps.ReadOnly = True
        dgvEmps.RowHeadersWidth = 51
        dgvEmps.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmps.Size = New Size(1148, 427)
        dgvEmps.TabIndex = 4
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "الرقم"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Visible = False
        DataGridViewTextBoxColumn1.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الاسم"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 250
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "اجمالي المرتب"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 130
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "تاريخ التعيين"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "رقم الموبايل"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 150
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.LightBlue
        GroupBox6.Controls.Add(btnSearch)
        GroupBox6.Controls.Add(txtNameSrch)
        GroupBox6.Controls.Add(Label1)
        GroupBox6.Dock = DockStyle.Top
        GroupBox6.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox6.Location = New Point(3, 4)
        GroupBox6.Margin = New Padding(3, 4, 3, 4)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 4, 3, 4)
        GroupBox6.RightToLeft = RightToLeft.Yes
        GroupBox6.Size = New Size(1154, 97)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "بحث عن موظف"
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Lime
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(505, 25)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 59)
        btnSearch.TabIndex = 33
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtNameSrch
        ' 
        txtNameSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNameSrch.Location = New Point(615, 34)
        txtNameSrch.Margin = New Padding(3, 4, 3, 4)
        txtNameSrch.Name = "txtNameSrch"
        txtNameSrch.Size = New Size(391, 24)
        txtNameSrch.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(1013, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 17)
        Label1.TabIndex = 2
        Label1.Text = "اسم الموظف"
        ' 
        ' frmEmployees
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1168, 654)
        Controls.Add(TabControl1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmEmployees"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف موظف"
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox7.ResumeLayout(False)
        CType(dgvBranches, System.ComponentModel.ISupportInitialize).EndInit()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvEmps, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
