Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmBranches
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbDefaultBank As ComboBox
    Friend WithEvents dgvBranches As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents picImage As PictureBox
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAcc1 As TextBox
    Friend WithEvents txtAcc2 As TextBox
    Friend WithEvents txtAcc3 As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAddressEN As TextBox
    Friend WithEvents txtBank1 As TextBox
    Friend WithEvents txtBank2 As TextBox
    Friend WithEvents txtBank3 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtPicPath As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtcr As TextBox

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBranches))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtMobile = New TextBox()
        toolStripSeparator2 = New ToolStripSeparator()
        Label10 = New Label()
        txtNotes = New TextBox()
        Label5 = New Label()
        btnNew = New ToolStripButton()
        btnFirst = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnPrint = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnDelete = New ToolStripButton()
        GroupBox1 = New GroupBox()
        dgvBranches = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btnLast = New ToolStripButton()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        cmbDefaultBank = New ComboBox()
        txtAddressEN = New TextBox()
        Label8 = New Label()
        txtcr = New TextBox()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        txtAcc3 = New TextBox()
        Label28 = New Label()
        txtAcc2 = New TextBox()
        Label26 = New Label()
        txtBank3 = New TextBox()
        txtAcc1 = New TextBox()
        Label24 = New Label()
        txtBank1 = New TextBox()
        txtBank2 = New TextBox()
        Label23 = New Label()
        Label25 = New Label()
        Label27 = New Label()
        picImage = New PictureBox()
        txtPicPath = New TextBox()
        Label16 = New Label()
        btnOpenFile = New Button()
        txtEmail = New TextBox()
        Label3 = New Label()
        txtFax = New TextBox()
        Label1 = New Label()
        txtTel = New TextBox()
        Label2 = New Label()
        txtAddress = New TextBox()
        Label4 = New Label()
        txtName = New TextBox()
        Label7 = New Label()
        panel2 = New Panel()
        toolStrip1 = New ToolStrip()
        toolStripSeparator1 = New ToolStripSeparator()
        btnClose = New ToolStripButton()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(dgvBranches, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        panel2.SuspendLayout()
        toolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtMobile
        ' 
        txtMobile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMobile.Location = New Point(471, 54)
        txtMobile.Margin = New Padding(3, 4, 3, 4)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(81, 24)
        txtMobile.TabIndex = 2
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 65)
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(558, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 17)
        Label10.TabIndex = 13
        Label10.Text = "موبايل"
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(61, 148)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(635, 24)
        txtNotes.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(714, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 13
        Label5.Text = "ملاحظات"
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
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.Controls.Add(dgvBranches)
        GroupBox1.Location = New Point(21, 338)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(769, 199)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "بيانات الفروع"
        ' 
        ' dgvBranches
        ' 
        dgvBranches.AllowUserToAddRows = False
        dgvBranches.AllowUserToDeleteRows = False
        dgvBranches.AllowUserToOrderColumns = True
        dgvBranches.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBranches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBranches.Columns.AddRange(New DataGridViewColumn() {Column3, Column1, Column5, Column6, Column2, Column4})
        dgvBranches.Dock = DockStyle.Fill
        dgvBranches.Location = New Point(3, 21)
        dgvBranches.Margin = New Padding(3, 4, 3, 4)
        dgvBranches.MultiSelect = False
        dgvBranches.Name = "dgvBranches"
        dgvBranches.ReadOnly = True
        dgvBranches.RowHeadersWidth = 51
        dgvBranches.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBranches.Size = New Size(763, 174)
        dgvBranches.TabIndex = 0
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
        Column1.HeaderText = "اسم الفرع"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
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
        ' Column2
        ' 
        Column2.HeaderText = "فاكس"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "بريد الكتروني"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
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
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightBlue
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(cmbDefaultBank)
        GroupBox2.Controls.Add(txtAddressEN)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtcr)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(picImage)
        GroupBox2.Controls.Add(txtPicPath)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(btnOpenFile)
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtFax)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtMobile)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtNotes)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtTel)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtAddress)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(806, 540)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "ادخل بيانات الفروع"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.ImeMode = ImeMode.NoControl
        Label9.Location = New Point(255, 213)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 17)
        Label9.TabIndex = 250
        Label9.Text = "بنك افتراضي"
        ' 
        ' cmbDefaultBank
        ' 
        cmbDefaultBank.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbDefaultBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbDefaultBank.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbDefaultBank.BackColor = Color.White
        cmbDefaultBank.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        cmbDefaultBank.FormattingEnabled = True
        cmbDefaultBank.Location = New Point(61, 206)
        cmbDefaultBank.Margin = New Padding(3, 4, 3, 4)
        cmbDefaultBank.Name = "cmbDefaultBank"
        cmbDefaultBank.Size = New Size(186, 29)
        cmbDefaultBank.TabIndex = 249
        ' 
        ' txtAddressEN
        ' 
        txtAddressEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddressEN.Location = New Point(61, 116)
        txtAddressEN.Margin = New Padding(3, 4, 3, 4)
        txtAddressEN.Name = "txtAddressEN"
        txtAddressEN.Size = New Size(635, 24)
        txtAddressEN.TabIndex = 184
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(712, 121)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 185
        Label8.Text = "العنوان EN"
        ' 
        ' txtcr
        ' 
        txtcr.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtcr.Location = New Point(61, 176)
        txtcr.Margin = New Padding(3, 4, 3, 4)
        txtcr.Name = "txtcr"
        txtcr.Size = New Size(143, 24)
        txtcr.TabIndex = 182
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(210, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 17)
        Label6.TabIndex = 183
        Label6.Text = "السجل التجاري"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox3.Controls.Add(txtAcc3)
        GroupBox3.Controls.Add(Label28)
        GroupBox3.Controls.Add(txtAcc2)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(txtBank3)
        GroupBox3.Controls.Add(txtAcc1)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(txtBank1)
        GroupBox3.Controls.Add(txtBank2)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label27)
        GroupBox3.Location = New Point(365, 178)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(424, 105)
        GroupBox3.TabIndex = 181
        GroupBox3.TabStop = False
        GroupBox3.Text = "حسابات البنوك"
        ' 
        ' txtAcc3
        ' 
        txtAcc3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAcc3.Location = New Point(21, 75)
        txtAcc3.Margin = New Padding(3, 4, 3, 4)
        txtAcc3.Name = "txtAcc3"
        txtAcc3.Size = New Size(145, 24)
        txtAcc3.TabIndex = 5
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label28.AutoSize = True
        Label28.ImeMode = ImeMode.NoControl
        Label28.Location = New Point(166, 79)
        Label28.Name = "Label28"
        Label28.Size = New Size(90, 17)
        Label28.TabIndex = 29
        Label28.Text = "رقم الحساب"
        ' 
        ' txtAcc2
        ' 
        txtAcc2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAcc2.Location = New Point(21, 49)
        txtAcc2.Margin = New Padding(3, 4, 3, 4)
        txtAcc2.Name = "txtAcc2"
        txtAcc2.Size = New Size(145, 24)
        txtAcc2.TabIndex = 3
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label26.AutoSize = True
        Label26.ImeMode = ImeMode.NoControl
        Label26.Location = New Point(166, 53)
        Label26.Name = "Label26"
        Label26.Size = New Size(90, 17)
        Label26.TabIndex = 29
        Label26.Text = "رقم الحساب"
        ' 
        ' txtBank3
        ' 
        txtBank3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBank3.Location = New Point(251, 75)
        txtBank3.Margin = New Padding(3, 4, 3, 4)
        txtBank3.Name = "txtBank3"
        txtBank3.Size = New Size(118, 24)
        txtBank3.TabIndex = 4
        ' 
        ' txtAcc1
        ' 
        txtAcc1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAcc1.Location = New Point(21, 23)
        txtAcc1.Margin = New Padding(3, 4, 3, 4)
        txtAcc1.Name = "txtAcc1"
        txtAcc1.Size = New Size(145, 24)
        txtAcc1.TabIndex = 1
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label24.AutoSize = True
        Label24.ImeMode = ImeMode.NoControl
        Label24.Location = New Point(166, 27)
        Label24.Name = "Label24"
        Label24.Size = New Size(90, 17)
        Label24.TabIndex = 29
        Label24.Text = "رقم الحساب"
        ' 
        ' txtBank1
        ' 
        txtBank1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBank1.Location = New Point(251, 23)
        txtBank1.Margin = New Padding(3, 4, 3, 4)
        txtBank1.Name = "txtBank1"
        txtBank1.Size = New Size(118, 24)
        txtBank1.TabIndex = 0
        ' 
        ' txtBank2
        ' 
        txtBank2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBank2.Location = New Point(251, 49)
        txtBank2.Margin = New Padding(3, 4, 3, 4)
        txtBank2.Name = "txtBank2"
        txtBank2.Size = New Size(118, 24)
        txtBank2.TabIndex = 2
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label23.AutoSize = True
        Label23.ImeMode = ImeMode.NoControl
        Label23.Location = New Point(373, 27)
        Label23.Name = "Label23"
        Label23.Size = New Size(40, 17)
        Label23.TabIndex = 29
        Label23.Text = "بنك1"
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.ImeMode = ImeMode.NoControl
        Label25.Location = New Point(373, 53)
        Label25.Name = "Label25"
        Label25.Size = New Size(40, 17)
        Label25.TabIndex = 29
        Label25.Text = "بنك2"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label27.AutoSize = True
        Label27.ImeMode = ImeMode.NoControl
        Label27.Location = New Point(373, 79)
        Label27.Name = "Label27"
        Label27.Size = New Size(40, 17)
        Label27.TabIndex = 29
        Label27.Text = "بنك3"
        ' 
        ' picImage
        ' 
        picImage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picImage.BorderStyle = BorderStyle.FixedSingle
        picImage.ImeMode = ImeMode.NoControl
        picImage.Location = New Point(54, 250)
        picImage.Margin = New Padding(3, 4, 3, 4)
        picImage.Name = "picImage"
        picImage.Size = New Size(123, 93)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 104
        picImage.TabStop = False
        ' 
        ' txtPicPath
        ' 
        txtPicPath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPicPath.Location = New Point(383, 304)
        txtPicPath.Margin = New Padding(3, 4, 3, 4)
        txtPicPath.Name = "txtPicPath"
        txtPicPath.ReadOnly = True
        txtPicPath.Size = New Size(306, 24)
        txtPicPath.TabIndex = 101
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.ImeMode = ImeMode.NoControl
        Label16.Location = New Point(696, 308)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 17)
        Label16.TabIndex = 103
        Label16.Text = "شعار الفرع"
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenFile.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnOpenFile.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnOpenFile.ForeColor = Color.Lime
        btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), Image)
        btnOpenFile.ImeMode = ImeMode.NoControl
        btnOpenFile.Location = New Point(341, 299)
        btnOpenFile.Margin = New Padding(3, 4, 3, 4)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(40, 36)
        btnOpenFile.TabIndex = 102
        btnOpenFile.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmail.Location = New Point(61, 55)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(143, 24)
        txtEmail.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(210, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 17)
        Label3.TabIndex = 13
        Label3.Text = "البريد الالكتروني"
        ' 
        ' txtFax
        ' 
        txtFax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFax.Location = New Point(325, 55)
        txtFax.Margin = New Padding(3, 4, 3, 4)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(81, 24)
        txtFax.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(410, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 13
        Label1.Text = "فاكس"
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTel.Location = New Point(610, 54)
        txtTel.Margin = New Padding(3, 4, 3, 4)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(83, 24)
        txtTel.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(727, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 17)
        Label2.TabIndex = 3
        Label2.Text = "تليفون"
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddress.Location = New Point(61, 86)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(635, 24)
        txtAddress.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(722, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 17)
        Label4.TabIndex = 100
        Label4.Text = "العنوان"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(61, 22)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(635, 24)
        txtName.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(702, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 17)
        Label7.TabIndex = 0
        Label7.Text = "اسم الفرع"
        ' 
        ' panel2
        ' 
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.Controls.Add(toolStrip1)
        panel2.Dock = DockStyle.Bottom
        panel2.Location = New Point(0, 540)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(806, 67)
        panel2.TabIndex = 14
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(804, 65)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 65)
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
        ' frmBranches
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(806, 607)
        Controls.Add(GroupBox2)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmBranches"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف الفروع"
        GroupBox1.ResumeLayout(False)
        CType(dgvBranches, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(picImage, System.ComponentModel.ISupportInitialize).EndInit()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
