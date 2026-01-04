Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCustomers
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents IValue As TextBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnActAdd As Button
    Friend WithEvents btnAreaAdd As Button
    Friend WithEvents btnCityAdd As Button
    Friend WithEvents btnClientsImport As Button
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnCountryAdd As Button
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnPrintSupp As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkJoinDate As CheckBox
    Friend WithEvents chkMaintDate As CheckBox
    Friend WithEvents cmbActs As ComboBox
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents credit As RadioButton
    Friend WithEvents debt As RadioButton
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents lblTaxNo As Label
    Friend WithEvents lblivalue As Label
    Friend WithEvents lblname As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents progressBar1 As ProgressBar
    Friend WithEvents rdClient As RadioButton
    Friend WithEvents rdCustCash As RadioButton
    Friend WithEvents rdCustPerm As RadioButton
    Friend WithEvents rdSupplier As RadioButton
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAccCode As TextBox
    Friend WithEvents txtAddNo As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtAreaEN As TextBox
    Friend WithEvents txtBuildNo As TextBox
    Friend WithEvents txtCR As TextBox
    Friend WithEvents txtCRN As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtCityEN As TextBox
    Friend WithEvents txtCreditLimit As TextBox
    Friend WithEvents txtCustDisc As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtGov As TextBox
    Friend WithEvents txtGovEN As TextBox
    Friend WithEvents txtJoinDate As DateTimePicker
    Friend WithEvents txtLastMaint As DateTimePicker
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNameEN As TextBox
    Friend WithEvents txtNameSrch As TextBox
    Friend WithEvents txtNationalID As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtStreetEN As TextBox
    Friend WithEvents txtTaxNo As TextBox
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
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Panel3 = New Panel()
        rdCustCash = New RadioButton()
        rdCustPerm = New RadioButton()
        txtCR = New TextBox()
        Label20 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        txtCreditLimit = New TextBox()
        Label18 = New Label()
        chkMaintDate = New CheckBox()
        btnClientsImport = New Button()
        chkJoinDate = New CheckBox()
        txtLastMaint = New DateTimePicker()
        txtJoinDate = New DateTimePicker()
        txtNo = New TextBox()
        Label14 = New Label()
        Panel1 = New Panel()
        debt = New RadioButton()
        credit = New RadioButton()
        txtCustDisc = New TextBox()
        Label13 = New Label()
        IValue = New TextBox()
        lblivalue = New Label()
        rdSupplier = New RadioButton()
        rdClient = New RadioButton()
        txtMobile = New TextBox()
        Label17 = New Label()
        Label8 = New Label()
        Label16 = New Label()
        txtFax = New TextBox()
        Label11 = New Label()
        txtEmail = New TextBox()
        Label10 = New Label()
        txtNotes = New TextBox()
        Label5 = New Label()
        txtTaxNo = New TextBox()
        lblTaxNo = New Label()
        txtAccCode = New TextBox()
        Label7 = New Label()
        txtTel = New TextBox()
        Label6 = New Label()
        btnCityAdd = New Button()
        btnCountryAdd = New Button()
        btnActAdd = New Button()
        Button1 = New Button()
        btnAreaAdd = New Button()
        cmbActs = New ComboBox()
        Label12 = New Label()
        cmbArea = New ComboBox()
        Label4 = New Label()
        cmbCity = New ComboBox()
        Label9 = New Label()
        cmbCountry = New ComboBox()
        Label3 = New Label()
        txtNationalID = New TextBox()
        Label2 = New Label()
        txtAddress = New TextBox()
        Label15 = New Label()
        txtNameEN = New TextBox()
        Label19 = New Label()
        txtName = New TextBox()
        lblname = New Label()
        TabPage3 = New TabPage()
        GroupBox17 = New GroupBox()
        txtGovEN = New TextBox()
        txtStreetEN = New TextBox()
        txtCityEN = New TextBox()
        txtAreaEN = New TextBox()
        Label47 = New Label()
        txtAddNo = New TextBox()
        txtCRN = New TextBox()
        Label48 = New Label()
        txtGov = New TextBox()
        Label53 = New Label()
        txtStreet = New TextBox()
        Label54 = New Label()
        Label58 = New Label()
        txtBuildNo = New TextBox()
        txtCity = New TextBox()
        Label55 = New Label()
        Label57 = New Label()
        txtArea = New TextBox()
        txtPostCode = New TextBox()
        Label56 = New Label()
        TabPage2 = New TabPage()
        GroupBox4 = New GroupBox()
        dgvCustomers = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        GroupBox6 = New GroupBox()
        ProgressBar2 = New ProgressBar()
        btnSearch = New Button()
        txtNameSrch = New TextBox()
        Label1 = New Label()
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
        btnPrintSupp = New ToolStripButton()
        btnClose = New ToolStripButton()
        panel2 = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        progressBar1 = New ProgressBar()
        timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox17.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        toolStrip1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(869, 540)
        TabControl1.TabIndex = 11
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(861, 511)
        TabPage1.TabIndex = 0
        TabPage1.Text = "            بيانـــات            "
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.ForeColor = Color.Blue
        GroupBox1.Location = New Point(3, 4)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(855, 503)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Panel3)
        GroupBox2.Controls.Add(txtCR)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(txtCreditLimit)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(chkMaintDate)
        GroupBox2.Controls.Add(btnClientsImport)
        GroupBox2.Controls.Add(chkJoinDate)
        GroupBox2.Controls.Add(txtLastMaint)
        GroupBox2.Controls.Add(txtJoinDate)
        GroupBox2.Controls.Add(txtNo)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(txtCustDisc)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(IValue)
        GroupBox2.Controls.Add(lblivalue)
        GroupBox2.Controls.Add(rdSupplier)
        GroupBox2.Controls.Add(rdClient)
        GroupBox2.Controls.Add(txtMobile)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(txtFax)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txtNotes)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtTaxNo)
        GroupBox2.Controls.Add(lblTaxNo)
        GroupBox2.Controls.Add(txtAccCode)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtTel)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(btnCityAdd)
        GroupBox2.Controls.Add(btnCountryAdd)
        GroupBox2.Controls.Add(btnActAdd)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(btnAreaAdd)
        GroupBox2.Controls.Add(cmbActs)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(cmbArea)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(cmbCity)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(cmbCountry)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtNationalID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtAddress)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(txtNameEN)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(lblname)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(3, 21)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(849, 478)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(rdCustCash)
        Panel3.Controls.Add(rdCustPerm)
        Panel3.Location = New Point(43, 10)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(180, 43)
        Panel3.TabIndex = 60
        ' 
        ' rdCustCash
        ' 
        rdCustCash.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdCustCash.AutoSize = True
        rdCustCash.ImeMode = ImeMode.NoControl
        rdCustCash.Location = New Point(8, 10)
        rdCustCash.Margin = New Padding(3, 4, 3, 4)
        rdCustCash.Name = "rdCustCash"
        rdCustCash.Size = New Size(64, 21)
        rdCustCash.TabIndex = 17
        rdCustCash.Text = "نقدي"
        rdCustCash.UseVisualStyleBackColor = True
        ' 
        ' rdCustPerm
        ' 
        rdCustPerm.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdCustPerm.AutoSize = True
        rdCustPerm.Checked = True
        rdCustPerm.ImeMode = ImeMode.NoControl
        rdCustPerm.Location = New Point(88, 10)
        rdCustPerm.Margin = New Padding(3, 4, 3, 4)
        rdCustPerm.Name = "rdCustPerm"
        rdCustPerm.Size = New Size(56, 21)
        rdCustPerm.TabIndex = 18
        rdCustPerm.TabStop = True
        rdCustPerm.Text = "دائم"
        rdCustPerm.UseVisualStyleBackColor = True
        ' 
        ' txtCR
        ' 
        txtCR.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCR.Location = New Point(5, 80)
        txtCR.Margin = New Padding(3, 4, 3, 4)
        txtCR.Name = "txtCR"
        txtCR.Size = New Size(171, 24)
        txtCR.TabIndex = 58
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.ImeMode = ImeMode.NoControl
        Label20.Location = New Point(180, 85)
        Label20.Name = "Label20"
        Label20.Size = New Size(90, 17)
        Label20.TabIndex = 59
        Label20.Text = "سجل تجاري"
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.ImeMode = ImeMode.NoControl
        Button3.Location = New Point(345, 404)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(73, 33)
        Button3.TabIndex = 57
        Button3.Text = "tst2"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.ImeMode = ImeMode.NoControl
        Button2.Location = New Point(420, 404)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 33)
        Button2.TabIndex = 56
        Button2.Text = "tst1"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtCreditLimit
        ' 
        txtCreditLimit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCreditLimit.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtCreditLimit.Location = New Point(41, 270)
        txtCreditLimit.Margin = New Padding(3, 4, 3, 4)
        txtCreditLimit.Name = "txtCreditLimit"
        txtCreditLimit.Size = New Size(129, 24)
        txtCreditLimit.TabIndex = 54
        txtCreditLimit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.ImeMode = ImeMode.NoControl
        Label18.Location = New Point(173, 274)
        Label18.Name = "Label18"
        Label18.Size = New Size(80, 17)
        Label18.TabIndex = 55
        Label18.Text = "حد الإئتمان"
        ' 
        ' chkMaintDate
        ' 
        chkMaintDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkMaintDate.AutoSize = True
        chkMaintDate.ImeMode = ImeMode.NoControl
        chkMaintDate.Location = New Point(21, 353)
        chkMaintDate.Margin = New Padding(3, 4, 3, 4)
        chkMaintDate.Name = "chkMaintDate"
        chkMaintDate.Size = New Size(18, 17)
        chkMaintDate.TabIndex = 28
        chkMaintDate.UseVisualStyleBackColor = True
        ' 
        ' btnClientsImport
        ' 
        btnClientsImport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClientsImport.ImeMode = ImeMode.NoControl
        btnClientsImport.Location = New Point(526, 394)
        btnClientsImport.Margin = New Padding(3, 4, 3, 4)
        btnClientsImport.Name = "btnClientsImport"
        btnClientsImport.Size = New Size(211, 53)
        btnClientsImport.TabIndex = 53
        btnClientsImport.Text = "استيراد العملاء من  إكسل"
        btnClientsImport.UseVisualStyleBackColor = True
        ' 
        ' chkJoinDate
        ' 
        chkJoinDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkJoinDate.AutoSize = True
        chkJoinDate.Location = New Point(21, 315)
        chkJoinDate.Margin = New Padding(3, 4, 3, 4)
        chkJoinDate.Name = "chkJoinDate"
        chkJoinDate.Size = New Size(18, 17)
        chkJoinDate.TabIndex = 28
        chkJoinDate.UseVisualStyleBackColor = True
        ' 
        ' txtLastMaint
        ' 
        txtLastMaint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtLastMaint.Format = DateTimePickerFormat.Short
        txtLastMaint.Location = New Point(41, 350)
        txtLastMaint.Margin = New Padding(3, 4, 3, 4)
        txtLastMaint.Name = "txtLastMaint"
        txtLastMaint.Size = New Size(135, 24)
        txtLastMaint.TabIndex = 27
        ' 
        ' txtJoinDate
        ' 
        txtJoinDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtJoinDate.Format = DateTimePickerFormat.Short
        txtJoinDate.Location = New Point(41, 311)
        txtJoinDate.Margin = New Padding(3, 4, 3, 4)
        txtJoinDate.Name = "txtJoinDate"
        txtJoinDate.Size = New Size(135, 24)
        txtJoinDate.TabIndex = 27
        ' 
        ' txtNo
        ' 
        txtNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNo.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtNo.Location = New Point(610, 15)
        txtNo.Margin = New Padding(3, 4, 3, 4)
        txtNo.Name = "txtNo"
        txtNo.Size = New Size(129, 24)
        txtNo.TabIndex = 25
        txtNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.ImeMode = ImeMode.NoControl
        Label14.Location = New Point(766, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 17)
        Label14.TabIndex = 26
        Label14.Text = "الرقم"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.Controls.Add(debt)
        Panel1.Controls.Add(credit)
        Panel1.Location = New Point(20, 111)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(131, 36)
        Panel1.TabIndex = 24
        Panel1.Visible = False
        ' 
        ' debt
        ' 
        debt.AutoSize = True
        debt.Checked = True
        debt.ImeMode = ImeMode.NoControl
        debt.Location = New Point(69, 9)
        debt.Margin = New Padding(3, 4, 3, 4)
        debt.Name = "debt"
        debt.Size = New Size(62, 21)
        debt.TabIndex = 17
        debt.TabStop = True
        debt.Text = "مدين"
        debt.UseVisualStyleBackColor = True
        ' 
        ' credit
        ' 
        credit.AutoSize = True
        credit.ImeMode = ImeMode.NoControl
        credit.Location = New Point(7, 9)
        credit.Margin = New Padding(3, 4, 3, 4)
        credit.Name = "credit"
        credit.Size = New Size(58, 21)
        credit.TabIndex = 18
        credit.Text = "دائن"
        credit.UseVisualStyleBackColor = True
        ' 
        ' txtCustDisc
        ' 
        txtCustDisc.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCustDisc.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtCustDisc.Location = New Point(582, 197)
        txtCustDisc.Margin = New Padding(3, 4, 3, 4)
        txtCustDisc.Name = "txtCustDisc"
        txtCustDisc.ReadOnly = True
        txtCustDisc.Size = New Size(156, 24)
        txtCustDisc.TabIndex = 3
        txtCustDisc.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.ImeMode = ImeMode.NoControl
        Label13.Location = New Point(748, 201)
        Label13.Name = "Label13"
        Label13.Size = New Size(88, 17)
        Label13.TabIndex = 23
        Label13.Text = "رصيد الخصم"
        ' 
        ' IValue
        ' 
        IValue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IValue.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        IValue.Location = New Point(180, 116)
        IValue.Margin = New Padding(3, 4, 3, 4)
        IValue.Name = "IValue"
        IValue.Size = New Size(129, 24)
        IValue.TabIndex = 3
        IValue.TextAlign = HorizontalAlignment.Center
        IValue.Visible = False
        ' 
        ' lblivalue
        ' 
        lblivalue.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblivalue.AutoSize = True
        lblivalue.ImeMode = ImeMode.NoControl
        lblivalue.Location = New Point(313, 121)
        lblivalue.Name = "lblivalue"
        lblivalue.Size = New Size(118, 17)
        lblivalue.TabIndex = 23
        lblivalue.Text = "الرصيد الافتتاحي"
        lblivalue.Visible = False
        ' 
        ' rdSupplier
        ' 
        rdSupplier.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdSupplier.AutoSize = True
        rdSupplier.ImeMode = ImeMode.NoControl
        rdSupplier.Location = New Point(368, 16)
        rdSupplier.Margin = New Padding(3, 4, 3, 4)
        rdSupplier.Name = "rdSupplier"
        rdSupplier.Size = New Size(59, 21)
        rdSupplier.TabIndex = 16
        rdSupplier.Text = "مورد"
        rdSupplier.UseVisualStyleBackColor = True
        ' 
        ' rdClient
        ' 
        rdClient.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdClient.AutoSize = True
        rdClient.Checked = True
        rdClient.Location = New Point(480, 16)
        rdClient.Margin = New Padding(3, 4, 3, 4)
        rdClient.Name = "rdClient"
        rdClient.Size = New Size(64, 21)
        rdClient.TabIndex = 16
        rdClient.TabStop = True
        rdClient.Text = "عميل"
        rdClient.UseVisualStyleBackColor = True
        ' 
        ' txtMobile
        ' 
        txtMobile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtMobile.Location = New Point(300, 233)
        txtMobile.Margin = New Padding(3, 4, 3, 4)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(142, 24)
        txtMobile.TabIndex = 10
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.ImeMode = ImeMode.NoControl
        Label17.Location = New Point(187, 353)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 17)
        Label17.TabIndex = 13
        Label17.Text = "تاريخ آخر زيارة"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(457, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 17)
        Label8.TabIndex = 15
        Label8.Text = "رقم جوال2"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.ImeMode = ImeMode.NoControl
        Label16.Location = New Point(187, 315)
        Label16.Name = "Label16"
        Label16.Size = New Size(101, 17)
        Label16.TabIndex = 13
        Label16.Text = "تاريخ الإشتراك"
        ' 
        ' txtFax
        ' 
        txtFax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtFax.Location = New Point(41, 231)
        txtFax.Margin = New Padding(3, 4, 3, 4)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(135, 24)
        txtFax.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(210, 235)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 17)
        Label11.TabIndex = 13
        Label11.Text = "فاكس"
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtEmail.Location = New Point(286, 194)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(156, 24)
        txtEmail.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(442, 198)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 17)
        Label10.TabIndex = 13
        Label10.Text = "البريد الالكتروني"
        ' 
        ' txtNotes
        ' 
        txtNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNotes.Location = New Point(300, 341)
        txtNotes.Margin = New Padding(3, 4, 3, 4)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ScrollBars = ScrollBars.Vertical
        txtNotes.Size = New Size(438, 45)
        txtNotes.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(762, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 17)
        Label5.TabIndex = 13
        Label5.Text = "ملاحظات"
        ' 
        ' txtTaxNo
        ' 
        txtTaxNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTaxNo.Location = New Point(434, 116)
        txtTaxNo.Margin = New Padding(3, 4, 3, 4)
        txtTaxNo.Name = "txtTaxNo"
        txtTaxNo.Size = New Size(305, 24)
        txtTaxNo.TabIndex = 2
        ' 
        ' lblTaxNo
        ' 
        lblTaxNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTaxNo.AutoSize = True
        lblTaxNo.ImeMode = ImeMode.NoControl
        lblTaxNo.Location = New Point(744, 119)
        lblTaxNo.Name = "lblTaxNo"
        lblTaxNo.Size = New Size(102, 17)
        lblTaxNo.TabIndex = 13
        lblTaxNo.Text = "الرقم الضريبي"
        ' 
        ' txtAccCode
        ' 
        txtAccCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAccCode.Location = New Point(45, 44)
        txtAccCode.Margin = New Padding(3, 4, 3, 4)
        txtAccCode.Name = "txtAccCode"
        txtAccCode.ReadOnly = True
        txtAccCode.Size = New Size(131, 24)
        txtAccCode.TabIndex = 1
        txtAccCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(178, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 17)
        Label7.TabIndex = 13
        Label7.Text = "رقم الحساب"
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtTel.Location = New Point(582, 234)
        txtTel.Margin = New Padding(3, 4, 3, 4)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(156, 24)
        txtTel.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(756, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 17)
        Label6.TabIndex = 13
        Label6.Text = "رقم جوال1"
        ' 
        ' btnCityAdd
        ' 
        btnCityAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCityAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCityAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCityAdd.ForeColor = Color.Lime
        btnCityAdd.Image = CType(resources.GetObject("btnCityAdd.Image"), Image)
        btnCityAdd.Location = New Point(300, 154)
        btnCityAdd.Margin = New Padding(3, 4, 3, 4)
        btnCityAdd.Name = "btnCityAdd"
        btnCityAdd.Size = New Size(27, 28)
        btnCityAdd.TabIndex = 12
        btnCityAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCountryAdd
        ' 
        btnCountryAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCountryAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCountryAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCountryAdd.ForeColor = Color.Lime
        btnCountryAdd.Image = CType(resources.GetObject("btnCountryAdd.Image"), Image)
        btnCountryAdd.Location = New Point(582, 154)
        btnCountryAdd.Margin = New Padding(3, 4, 3, 4)
        btnCountryAdd.Name = "btnCountryAdd"
        btnCountryAdd.Size = New Size(27, 28)
        btnCountryAdd.TabIndex = 12
        btnCountryAdd.UseVisualStyleBackColor = False
        ' 
        ' btnActAdd
        ' 
        btnActAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnActAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnActAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnActAdd.ForeColor = Color.Lime
        btnActAdd.Image = CType(resources.GetObject("btnActAdd.Image"), Image)
        btnActAdd.Location = New Point(35, 192)
        btnActAdd.Margin = New Padding(3, 4, 3, 4)
        btnActAdd.Name = "btnActAdd"
        btnActAdd.Size = New Size(27, 28)
        btnActAdd.TabIndex = 11
        btnActAdd.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.White
        Button1.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(6, 43)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(39, 28)
        Button1.TabIndex = 11
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAreaAdd
        ' 
        btnAreaAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAreaAdd.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnAreaAdd.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAreaAdd.ForeColor = Color.Lime
        btnAreaAdd.Image = CType(resources.GetObject("btnAreaAdd.Image"), Image)
        btnAreaAdd.Location = New Point(41, 154)
        btnAreaAdd.Margin = New Padding(3, 4, 3, 4)
        btnAreaAdd.Name = "btnAreaAdd"
        btnAreaAdd.Size = New Size(27, 28)
        btnAreaAdd.TabIndex = 11
        btnAreaAdd.UseVisualStyleBackColor = False
        ' 
        ' cmbActs
        ' 
        cmbActs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbActs.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbActs.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbActs.FormattingEnabled = True
        cmbActs.Location = New Point(62, 194)
        cmbActs.Margin = New Padding(3, 4, 3, 4)
        cmbActs.Name = "cmbActs"
        cmbActs.Size = New Size(114, 24)
        cmbActs.TabIndex = 8
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(188, 201)
        Label12.Name = "Label12"
        Label12.Size = New Size(84, 17)
        Label12.TabIndex = 7
        Label12.Text = "مجال العمل"
        ' 
        ' cmbArea
        ' 
        cmbArea.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbArea.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbArea.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbArea.FormattingEnabled = True
        cmbArea.Location = New Point(68, 155)
        cmbArea.Margin = New Padding(3, 4, 3, 4)
        cmbArea.Name = "cmbArea"
        cmbArea.Size = New Size(108, 24)
        cmbArea.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(200, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 17)
        Label4.TabIndex = 7
        Label4.Text = "الحي"
        ' 
        ' cmbCity
        ' 
        cmbCity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCity.FormattingEnabled = True
        cmbCity.Location = New Point(329, 155)
        cmbCity.Margin = New Padding(3, 4, 3, 4)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(114, 24)
        cmbCity.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(468, 161)
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
        cmbCountry.Location = New Point(610, 155)
        cmbCountry.Margin = New Padding(3, 4, 3, 4)
        cmbCountry.Name = "cmbCountry"
        cmbCountry.Size = New Size(129, 24)
        cmbCountry.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(770, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 5
        Label3.Text = "الدولة"
        ' 
        ' txtNationalID
        ' 
        txtNationalID.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNationalID.Location = New Point(857, 138)
        txtNationalID.Margin = New Padding(3, 4, 3, 4)
        txtNationalID.Name = "txtNationalID"
        txtNationalID.Size = New Size(156, 24)
        txtNationalID.TabIndex = 4
        txtNationalID.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(1021, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 17)
        Label2.TabIndex = 3
        Label2.Text = "الرقم القومي"
        Label2.Visible = False
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddress.Location = New Point(300, 270)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(438, 62)
        txtAddress.TabIndex = 0
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.ImeMode = ImeMode.NoControl
        Label15.Location = New Point(770, 273)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 17)
        Label15.TabIndex = 0
        Label15.Text = "العنوان"
        ' 
        ' txtNameEN
        ' 
        txtNameEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNameEN.Location = New Point(267, 80)
        txtNameEN.Margin = New Padding(3, 4, 3, 4)
        txtNameEN.Name = "txtNameEN"
        txtNameEN.Size = New Size(471, 24)
        txtNameEN.TabIndex = 0
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.ImeMode = ImeMode.NoControl
        Label19.Location = New Point(763, 84)
        Label19.Name = "Label19"
        Label19.Size = New Size(71, 17)
        Label19.TabIndex = 0
        Label19.Text = "الإسم EN"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtName.Location = New Point(267, 46)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(471, 24)
        txtName.TabIndex = 0
        ' 
        ' lblname
        ' 
        lblname.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblname.AutoSize = True
        lblname.Location = New Point(770, 49)
        lblname.Name = "lblname"
        lblname.Size = New Size(47, 17)
        lblname.TabIndex = 0
        lblname.Text = "الإسم"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(GroupBox17)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 4, 3, 4)
        TabPage3.Size = New Size(861, 511)
        TabPage3.TabIndex = 2
        TabPage3.Text = "   حقول الفاتورة الإلكترونية    "
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox17
        ' 
        GroupBox17.Controls.Add(txtGovEN)
        GroupBox17.Controls.Add(txtStreetEN)
        GroupBox17.Controls.Add(txtCityEN)
        GroupBox17.Controls.Add(txtAreaEN)
        GroupBox17.Controls.Add(Label47)
        GroupBox17.Controls.Add(txtAddNo)
        GroupBox17.Controls.Add(txtCRN)
        GroupBox17.Controls.Add(Label48)
        GroupBox17.Controls.Add(txtGov)
        GroupBox17.Controls.Add(Label53)
        GroupBox17.Controls.Add(txtStreet)
        GroupBox17.Controls.Add(Label54)
        GroupBox17.Controls.Add(Label58)
        GroupBox17.Controls.Add(txtBuildNo)
        GroupBox17.Controls.Add(txtCity)
        GroupBox17.Controls.Add(Label55)
        GroupBox17.Controls.Add(Label57)
        GroupBox17.Controls.Add(txtArea)
        GroupBox17.Controls.Add(txtPostCode)
        GroupBox17.Controls.Add(Label56)
        GroupBox17.Location = New Point(113, 26)
        GroupBox17.Margin = New Padding(3, 4, 3, 4)
        GroupBox17.Name = "GroupBox17"
        GroupBox17.Padding = New Padding(3, 4, 3, 4)
        GroupBox17.Size = New Size(723, 246)
        GroupBox17.TabIndex = 205
        GroupBox17.TabStop = False
        ' 
        ' txtGovEN
        ' 
        txtGovEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGovEN.Location = New Point(40, 41)
        txtGovEN.Margin = New Padding(3, 4, 3, 4)
        txtGovEN.Name = "txtGovEN"
        txtGovEN.Size = New Size(268, 24)
        txtGovEN.TabIndex = 47
        ' 
        ' txtStreetEN
        ' 
        txtStreetEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtStreetEN.Location = New Point(40, 137)
        txtStreetEN.Margin = New Padding(3, 4, 3, 4)
        txtStreetEN.Name = "txtStreetEN"
        txtStreetEN.Size = New Size(268, 24)
        txtStreetEN.TabIndex = 50
        ' 
        ' txtCityEN
        ' 
        txtCityEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCityEN.Location = New Point(40, 73)
        txtCityEN.Margin = New Padding(3, 4, 3, 4)
        txtCityEN.Name = "txtCityEN"
        txtCityEN.Size = New Size(268, 24)
        txtCityEN.TabIndex = 48
        ' 
        ' txtAreaEN
        ' 
        txtAreaEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAreaEN.Location = New Point(40, 105)
        txtAreaEN.Margin = New Padding(3, 4, 3, 4)
        txtAreaEN.Name = "txtAreaEN"
        txtAreaEN.Size = New Size(268, 24)
        txtAreaEN.TabIndex = 49
        ' 
        ' Label47
        ' 
        Label47.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label47.AutoSize = True
        Label47.ForeColor = Color.Black
        Label47.ImeMode = ImeMode.NoControl
        Label47.Location = New Point(597, 208)
        Label47.Name = "Label47"
        Label47.Size = New Size(102, 17)
        Label47.TabIndex = 45
        Label47.Text = "الرقم الإضافي"
        ' 
        ' txtAddNo
        ' 
        txtAddNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtAddNo.Location = New Point(379, 203)
        txtAddNo.Margin = New Padding(3, 4, 3, 4)
        txtAddNo.Name = "txtAddNo"
        txtAddNo.Size = New Size(204, 24)
        txtAddNo.TabIndex = 43
        ' 
        ' txtCRN
        ' 
        txtCRN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCRN.Location = New Point(40, 208)
        txtCRN.Margin = New Padding(3, 4, 3, 4)
        txtCRN.Name = "txtCRN"
        txtCRN.Size = New Size(172, 24)
        txtCRN.TabIndex = 44
        ' 
        ' Label48
        ' 
        Label48.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label48.AutoSize = True
        Label48.ForeColor = Color.Black
        Label48.ImeMode = ImeMode.NoControl
        Label48.Location = New Point(218, 213)
        Label48.Name = "Label48"
        Label48.Size = New Size(71, 17)
        Label48.TabIndex = 46
        Label48.Text = "معرف آخر"
        ' 
        ' txtGov
        ' 
        txtGov.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtGov.Location = New Point(315, 41)
        txtGov.Margin = New Padding(3, 4, 3, 4)
        txtGov.Name = "txtGov"
        txtGov.Size = New Size(268, 24)
        txtGov.TabIndex = 4
        ' 
        ' Label53
        ' 
        Label53.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label53.AutoSize = True
        Label53.ForeColor = Color.Black
        Label53.ImeMode = ImeMode.NoControl
        Label53.Location = New Point(608, 142)
        Label53.Name = "Label53"
        Label53.Size = New Size(54, 17)
        Label53.TabIndex = 32
        Label53.Text = "الشارع"
        ' 
        ' txtStreet
        ' 
        txtStreet.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtStreet.Location = New Point(315, 137)
        txtStreet.Margin = New Padding(3, 4, 3, 4)
        txtStreet.Name = "txtStreet"
        txtStreet.Size = New Size(268, 24)
        txtStreet.TabIndex = 7
        ' 
        ' Label54
        ' 
        Label54.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label54.AutoSize = True
        Label54.ForeColor = Color.Black
        Label54.ImeMode = ImeMode.NoControl
        Label54.Location = New Point(597, 174)
        Label54.Name = "Label54"
        Label54.Size = New Size(79, 17)
        Label54.TabIndex = 34
        Label54.Text = "رقم المبنى"
        ' 
        ' Label58
        ' 
        Label58.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label58.AutoSize = True
        Label58.ForeColor = Color.Black
        Label58.ImeMode = ImeMode.NoControl
        Label58.Location = New Point(613, 46)
        Label58.Name = "Label58"
        Label58.Size = New Size(35, 17)
        Label58.TabIndex = 42
        Label58.Text = "البلد"
        ' 
        ' txtBuildNo
        ' 
        txtBuildNo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBuildNo.Location = New Point(379, 169)
        txtBuildNo.Margin = New Padding(3, 4, 3, 4)
        txtBuildNo.Name = "txtBuildNo"
        txtBuildNo.Size = New Size(204, 24)
        txtBuildNo.TabIndex = 8
        ' 
        ' txtCity
        ' 
        txtCity.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCity.Location = New Point(315, 73)
        txtCity.Margin = New Padding(3, 4, 3, 4)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(268, 24)
        txtCity.TabIndex = 5
        ' 
        ' Label55
        ' 
        Label55.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label55.AutoSize = True
        Label55.ForeColor = Color.Black
        Label55.ImeMode = ImeMode.NoControl
        Label55.Location = New Point(609, 110)
        Label55.Name = "Label55"
        Label55.Size = New Size(44, 17)
        Label55.TabIndex = 36
        Label55.Text = "الحي"
        ' 
        ' Label57
        ' 
        Label57.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label57.AutoSize = True
        Label57.ForeColor = Color.Black
        Label57.ImeMode = ImeMode.NoControl
        Label57.Location = New Point(608, 78)
        Label57.Name = "Label57"
        Label57.Size = New Size(53, 17)
        Label57.TabIndex = 40
        Label57.Text = "المدينة"
        ' 
        ' txtArea
        ' 
        txtArea.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtArea.Location = New Point(315, 105)
        txtArea.Margin = New Padding(3, 4, 3, 4)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(268, 24)
        txtArea.TabIndex = 6
        ' 
        ' txtPostCode
        ' 
        txtPostCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPostCode.Location = New Point(40, 174)
        txtPostCode.Margin = New Padding(3, 4, 3, 4)
        txtPostCode.Name = "txtPostCode"
        txtPostCode.Size = New Size(172, 24)
        txtPostCode.TabIndex = 9
        ' 
        ' Label56
        ' 
        Label56.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label56.AutoSize = True
        Label56.ForeColor = Color.Black
        Label56.ImeMode = ImeMode.NoControl
        Label56.Location = New Point(218, 178)
        Label56.Name = "Label56"
        Label56.Size = New Size(91, 17)
        Label56.TabIndex = 38
        Label56.Text = "الرمز البريدي"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(861, 511)
        TabPage2.TabIndex = 1
        TabPage2.Text = "                    البحــــــــــث              "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightBlue
        GroupBox4.Controls.Add(dgvCustomers)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(3, 101)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.RightToLeft = RightToLeft.Yes
        GroupBox4.Size = New Size(855, 406)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "النتائج"
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AllowUserToDeleteRows = False
        dgvCustomers.AllowUserToOrderColumns = True
        dgvCustomers.BackgroundColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column7, Column8, Column9, Column4, Column5})
        dgvCustomers.Dock = DockStyle.Fill
        dgvCustomers.Location = New Point(3, 21)
        dgvCustomers.Margin = New Padding(3, 4, 3, 4)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.RowHeadersWidth = 51
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomers.Size = New Size(849, 381)
        dgvCustomers.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "الرقم"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Visible = False
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الإسم"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الرقم القومي"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Visible = False
        Column3.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "جوال1"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "جوال2"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "الدولة"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "المدينة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "المنطقة"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' GroupBox6
        ' 
        GroupBox6.BackColor = Color.LightBlue
        GroupBox6.Controls.Add(ProgressBar2)
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
        GroupBox6.Size = New Size(855, 97)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "بحث"
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Dock = DockStyle.Bottom
        ProgressBar2.Location = New Point(3, 65)
        ProgressBar2.Margin = New Padding(3, 4, 3, 4)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(849, 28)
        ProgressBar2.TabIndex = 28
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Lime
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(223, 4)
        btnSearch.Margin = New Padding(3, 4, 3, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(87, 59)
        btnSearch.TabIndex = 1
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtNameSrch
        ' 
        txtNameSrch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNameSrch.Location = New Point(316, 26)
        txtNameSrch.Margin = New Padding(3, 4, 3, 4)
        txtNameSrch.Name = "txtNameSrch"
        txtNameSrch.Size = New Size(391, 24)
        txtNameSrch.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(715, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 2
        Label1.Text = "الإسم"
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Fill
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnPrintSupp, btnClose})
        toolStrip1.Location = New Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(867, 65)
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
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(80, 50)
        btnPrint.Text = "طباعة العملاء"
        btnPrint.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnPrintSupp
        ' 
        btnPrintSupp.AutoSize = False
        btnPrintSupp.Image = CType(resources.GetObject("btnPrintSupp.Image"), Image)
        btnPrintSupp.ImageScaling = ToolStripItemImageScaling.None
        btnPrintSupp.ImageTransparentColor = Color.Magenta
        btnPrintSupp.Name = "btnPrintSupp"
        btnPrintSupp.Size = New Size(80, 50)
        btnPrintSupp.Text = "طباعة الموردين"
        btnPrintSupp.TextImageRelation = TextImageRelation.ImageAboveText
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
        panel2.Location = New Point(0, 540)
        panel2.Margin = New Padding(3, 4, 3, 4)
        panel2.Name = "panel2"
        panel2.Size = New Size(869, 67)
        panel2.TabIndex = 10
        ' 
        ' progressBar1
        ' 
        progressBar1.Dock = DockStyle.Bottom
        progressBar1.ImeMode = ImeMode.NoControl
        progressBar1.Location = New Point(0, 512)
        progressBar1.Margin = New Padding(3, 4, 3, 4)
        progressBar1.Name = "progressBar1"
        progressBar1.Size = New Size(869, 28)
        progressBar1.TabIndex = 54
        ' 
        ' timer1
        ' 
        timer1.Interval = 500
        ' 
        ' frmCustomers
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 607)
        Controls.Add(progressBar1)
        Controls.Add(TabControl1)
        Controls.Add(panel2)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmCustomers"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تعريف العملاء / الموردين"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox17.ResumeLayout(False)
        GroupBox17.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
