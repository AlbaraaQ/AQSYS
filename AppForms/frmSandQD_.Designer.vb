Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSandQD_
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
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
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbAccounts As ComboBox
    Friend WithEvents cmbCheckType As ComboBox
    Friend WithEvents cmbEda3 As ComboBox
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents cmbSalesMan As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents rdCash As RadioButton
    Friend WithEvents rdCheck As RadioButton
    Friend WithEvents rdEmp As RadioButton
    Friend WithEvents rdPDeal As RadioButton
    Friend WithEvents txtBankCheck As TextBox
    Friend WithEvents txtCheckDate As DateTimePicker
    Friend WithEvents txtCheckNo As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtSrchNo As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtVal As TextBox
    Friend WithEvents txtValD As TextBox

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
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox7 = New Global.System.Windows.Forms.GroupBox()
			Me.ToolStrip2 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator3 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator4 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtBankCheck = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtCheckDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.cmbCheckType = New Global.System.Windows.Forms.ComboBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtCheckNo = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.rdCash = New Global.System.Windows.Forms.RadioButton()
			Me.rdCheck = New Global.System.Windows.Forms.RadioButton()
			Me.cmbSalesMan = New Global.System.Windows.Forms.ComboBox()
			Me.cmbEda3 = New Global.System.Windows.Forms.ComboBox()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.txtValD = New Global.System.Windows.Forms.TextBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.rdEmp = New Global.System.Windows.Forms.RadioButton()
			Me.rdPDeal = New Global.System.Windows.Forms.RadioButton()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.cmbAccounts = New Global.System.Windows.Forms.ComboBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbEmployee = New Global.System.Windows.Forms.ComboBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtVal = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewTextBoxColumn1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtSrchNo = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox7.SuspendLayout()
			Me.ToolStrip2.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.TabControl1)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(864, 471)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 21
			Me.GroupBox1.TabStop = False
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
			point = New Global.System.Drawing.Point(3, 16)
			tabControl.Location = point
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.RightToLeftLayout = True
			Me.TabControl1.SelectedIndex = 0
			Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
			size = New Global.System.Drawing.Size(858, 452)
			tabControl2.Size = size
			Me.TabControl1.TabIndex = 1
			Me.TabPage1.Controls.Add(Me.GroupBox2)
			Dim tabPage As Global.System.Windows.Forms.TabPage = Me.TabPage1
			point = New Global.System.Drawing.Point(4, 22)
			tabPage.Location = point
			Me.TabPage1.Name = "TabPage1"
			Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3)
			tabPage2.Padding = padding
			Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage1
			size = New Global.System.Drawing.Size(850, 426)
			tabPage3.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "                   سندات قبض عمليات داخلية                   "
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.GroupBox2.Controls.Add(Me.GroupBox7)
			Me.GroupBox2.Controls.Add(Me.GroupBox5)
			Me.GroupBox2.Controls.Add(Me.GroupBox3)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(3, 3)
			groupBox3.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(844, 420)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 23
			Me.GroupBox2.TabStop = False
			Me.GroupBox7.Controls.Add(Me.ToolStrip2)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox7
			point = New Global.System.Drawing.Point(2, 344)
			groupBox5.Location = point
			Me.GroupBox7.Name = "GroupBox7"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox7
			size = New Global.System.Drawing.Size(839, 76)
			groupBox6.Size = size
			Me.GroupBox7.TabIndex = 20
			Me.GroupBox7.TabStop = False
			Me.GroupBox7.Text = "z"
			Me.ToolStrip2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ToolStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.ToolStripSeparator3, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.ToolStripSeparator4, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.ToolStrip2
			point = New Global.System.Drawing.Point(3, 17)
			toolStrip.Location = point
			Me.ToolStrip2.Name = "ToolStrip2"
			Me.ToolStrip2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.ToolStrip2
			size = New Global.System.Drawing.Size(833, 56)
			toolStrip2.Size = size
			Me.ToolStrip2.TabIndex = 21
			Me.ToolStrip2.Text = "ToolStrip2"
			Me.btnNew.AutoSize = False
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Image = My.Resources.Resources._new
			Me.btnNew.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNew.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNew.Name = "btnNew"
			Dim btnNew As Global.System.Windows.Forms.ToolStripItem = Me.btnNew
			size = New Global.System.Drawing.Size(50, 50)
			btnNew.Size = size
			Me.btnNew.Text = "جديد"
			Me.btnSave.AutoSize = False
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Image = My.Resources.Resources.save
			Me.btnSave.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSave.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnSave.Name = "btnSave"
			Dim btnSave As Global.System.Windows.Forms.ToolStripItem = Me.btnSave
			size = New Global.System.Drawing.Size(50, 50)
			btnSave.Size = size
			Me.btnSave.Text = "حفظ"
			Me.btnDelete.AutoSize = False
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Image = My.Resources.Resources.delete
			Me.btnDelete.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnDelete.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnDelete.Name = "btnDelete"
			Dim btnDelete As Global.System.Windows.Forms.ToolStripItem = Me.btnDelete
			size = New Global.System.Drawing.Size(50, 50)
			btnDelete.Size = size
			Me.btnDelete.Text = "حذف"
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator3
			size = New Global.System.Drawing.Size(6, 56)
			toolStripSeparator.Size = size
			Me.btnLast.AutoSize = False
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Image = My.Resources.Resources.last
			Me.btnLast.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnLast.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnLast.Name = "btnLast"
			Dim btnLast As Global.System.Windows.Forms.ToolStripItem = Me.btnLast
			size = New Global.System.Drawing.Size(50, 50)
			btnLast.Size = size
			Me.btnLast.Text = "الأخير"
			Me.btnNext.AutoSize = False
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Image = My.Resources.Resources._next
			Me.btnNext.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNext.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNext.Name = "btnNext"
			Dim btnNext As Global.System.Windows.Forms.ToolStripItem = Me.btnNext
			size = New Global.System.Drawing.Size(50, 50)
			btnNext.Size = size
			Me.btnNext.Text = "التالي"
			Me.btnPrevious.AutoSize = False
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Image = My.Resources.Resources.previous
			Me.btnPrevious.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrevious.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrevious.Name = "btnPrevious"
			Dim btnPrevious As Global.System.Windows.Forms.ToolStripItem = Me.btnPrevious
			size = New Global.System.Drawing.Size(50, 50)
			btnPrevious.Size = size
			Me.btnPrevious.Text = "السابق"
			Me.btnFirst.AutoSize = False
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnFirst.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnFirst.Name = "btnFirst"
			Dim btnFirst As Global.System.Windows.Forms.ToolStripItem = Me.btnFirst
			size = New Global.System.Drawing.Size(50, 50)
			btnFirst.Size = size
			Me.btnFirst.Text = "الأول"
			Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator4
			size = New Global.System.Drawing.Size(6, 56)
			toolStripSeparator2.Size = size
			Me.btnPrint.AutoSize = False
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrint.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint As Global.System.Windows.Forms.ToolStripItem = Me.btnPrint
			size = New Global.System.Drawing.Size(50, 50)
			btnPrint.Size = size
			Me.btnPrint.Text = "طباعة"
			Me.btnClose.AutoSize = False
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Resources._exit
			Me.btnClose.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnClose.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnClose.Name = "btnClose"
			Dim btnClose As Global.System.Windows.Forms.ToolStripItem = Me.btnClose
			size = New Global.System.Drawing.Size(50, 50)
			btnClose.Size = size
			Me.btnClose.Text = "خروج"
			Me.GroupBox5.AutoSizeMode = Global.System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.GroupBox5.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Center
			Me.GroupBox5.Controls.Add(Me.Panel1)
			Me.GroupBox5.Controls.Add(Me.rdCash)
			Me.GroupBox5.Controls.Add(Me.rdCheck)
			Me.GroupBox5.Controls.Add(Me.cmbSalesMan)
			Me.GroupBox5.Controls.Add(Me.cmbEda3)
			Me.GroupBox5.Controls.Add(Me.txtNotes)
			Me.GroupBox5.Controls.Add(Me.Label14)
			Me.GroupBox5.Controls.Add(Me.Label12)
			Me.GroupBox5.Controls.Add(Me.Label8)
			Me.GroupBox5.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox5
			point = New Global.System.Drawing.Point(3, 174)
			groupBox7.Location = point
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(838, 243)
			groupBox8.Size = size
			Me.GroupBox5.TabIndex = 26
			Me.GroupBox5.TabStop = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.txtBankCheck)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.txtCheckDate)
			Me.Panel1.Controls.Add(Me.cmbCheckType)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.txtCheckNo)
			Me.Panel1.Controls.Add(Me.Label9)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(-57, 20)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(399, 135)
			panel2.Size = size
			Me.Panel1.TabIndex = 19
			Me.txtBankCheck.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtBankCheck As Global.System.Windows.Forms.Control = Me.txtBankCheck
			point = New Global.System.Drawing.Point(7, 103)
			txtBankCheck.Location = point
			Me.txtBankCheck.Name = "txtBankCheck"
			Dim txtBankCheck2 As Global.System.Windows.Forms.Control = Me.txtBankCheck
			size = New Global.System.Drawing.Size(247, 21)
			txtBankCheck2.Size = size
			Me.txtBankCheck.TabIndex = 3
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(261, 107)
			label.Location = point
			Me.Label10.Name = "Label10"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(136, 13)
			label2.Size = size
			Me.Label10.TabIndex = 30
			Me.Label10.Text = "الشيك مسحوب على بنك"
			Me.txtCheckDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtCheckDate As Global.System.Windows.Forms.Control = Me.txtCheckDate
			point = New Global.System.Drawing.Point(102, 51)
			txtCheckDate.Location = point
			Me.txtCheckDate.Name = "txtCheckDate"
			Dim txtCheckDate2 As Global.System.Windows.Forms.Control = Me.txtCheckDate
			size = New Global.System.Drawing.Size(152, 21)
			txtCheckDate2.Size = size
			Me.txtCheckDate.TabIndex = 1
			Me.cmbCheckType.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCheckType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCheckType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCheckType.FormattingEnabled = True
			Dim cmbCheckType As Global.System.Windows.Forms.Control = Me.cmbCheckType
			point = New Global.System.Drawing.Point(102, 76)
			cmbCheckType.Location = point
			Me.cmbCheckType.Name = "cmbCheckType"
			Dim cmbCheckType2 As Global.System.Windows.Forms.Control = Me.cmbCheckType
			size = New Global.System.Drawing.Size(152, 21)
			cmbCheckType2.Size = size
			Me.cmbCheckType.TabIndex = 2
			Me.Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label13.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(265, 79)
			label3.Location = point
			Me.Label13.Name = "Label13"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(116, 13)
			label4.Size = size
			Me.Label13.TabIndex = 28
			Me.Label13.Text = "حــــــالة الشــــــــــيك"
			Me.Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label11.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(257, 54)
			label5.Location = point
			Me.Label11.Name = "Label11"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(124, 13)
			label6.Size = size
			Me.Label11.TabIndex = 27
			Me.Label11.Text = "تاريخ استحقاق (شيك)"
			Me.txtCheckNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtCheckNo As Global.System.Windows.Forms.Control = Me.txtCheckNo
			point = New Global.System.Drawing.Point(102, 25)
			txtCheckNo.Location = point
			Me.txtCheckNo.Name = "txtCheckNo"
			Dim txtCheckNo2 As Global.System.Windows.Forms.Control = Me.txtCheckNo
			size = New Global.System.Drawing.Size(152, 21)
			txtCheckNo2.Size = size
			Me.txtCheckNo.TabIndex = 0
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(269, 28)
			label7.Location = point
			Me.Label9.Name = "Label9"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(112, 13)
			label8.Size = size
			Me.Label9.TabIndex = 26
			Me.Label9.Text = "رقـــم الشـــــــــــــيك"
			Me.rdCash.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdCash.AutoSize = True
			Me.rdCash.Checked = True
			Dim rdCash As Global.System.Windows.Forms.Control = Me.rdCash
			point = New Global.System.Drawing.Point(599, 20)
			rdCash.Location = point
			Me.rdCash.Name = "rdCash"
			Dim rdCash2 As Global.System.Windows.Forms.Control = Me.rdCash
			size = New Global.System.Drawing.Size(52, 17)
			rdCash2.Size = size
			Me.rdCash.TabIndex = 0
			Me.rdCash.TabStop = True
			Me.rdCash.Text = "نقدي"
			Me.rdCash.UseVisualStyleBackColor = True
			Me.rdCheck.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdCheck.AutoSize = True
			Dim rdCheck As Global.System.Windows.Forms.Control = Me.rdCheck
			point = New Global.System.Drawing.Point(539, 20)
			rdCheck.Location = point
			Me.rdCheck.Name = "rdCheck"
			Dim rdCheck2 As Global.System.Windows.Forms.Control = Me.rdCheck
			size = New Global.System.Drawing.Size(51, 17)
			rdCheck2.Size = size
			Me.rdCheck.TabIndex = 1
			Me.rdCheck.Text = "شيك"
			Me.rdCheck.UseVisualStyleBackColor = True
			Me.cmbSalesMan.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSalesMan.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSalesMan.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSalesMan.FormattingEnabled = True
			Dim cmbSalesMan As Global.System.Windows.Forms.Control = Me.cmbSalesMan
			point = New Global.System.Drawing.Point(346, 71)
			cmbSalesMan.Location = point
			Me.cmbSalesMan.Name = "cmbSalesMan"
			Dim cmbSalesMan2 As Global.System.Windows.Forms.Control = Me.cmbSalesMan
			size = New Global.System.Drawing.Size(306, 21)
			cmbSalesMan2.Size = size
			Me.cmbSalesMan.TabIndex = 3
			Me.cmbEda3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbEda3.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEda3.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEda3.FormattingEnabled = True
			Dim cmbEda As Global.System.Windows.Forms.Control = Me.cmbEda3
			point = New Global.System.Drawing.Point(346, 45)
			cmbEda.Location = point
			Me.cmbEda3.Name = "cmbEda3"
			Dim cmbEda2 As Global.System.Windows.Forms.Control = Me.cmbEda3
			size = New Global.System.Drawing.Size(306, 21)
			cmbEda2.Size = size
			Me.cmbEda3.TabIndex = 2
			Me.txtNotes.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNotes As Global.System.Windows.Forms.Control = Me.txtNotes
			point = New Global.System.Drawing.Point(346, 100)
			txtNotes.Location = point
			Me.txtNotes.Multiline = True
			Me.txtNotes.Name = "txtNotes"
			Dim txtNotes2 As Global.System.Windows.Forms.Control = Me.txtNotes
			size = New Global.System.Drawing.Size(306, 45)
			txtNotes2.Size = size
			Me.txtNotes.TabIndex = 4
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label14.AutoSize = True
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(666, 103)
			label9.Location = point
			Me.Label14.Name = "Label14"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(129, 13)
			label10.Size = size
			Me.Label14.TabIndex = 18
			Me.Label14.Text = "البيـــــــــــــــــــــــــــــــان"
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label12.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(664, 75)
			label11.Location = point
			Me.Label12.Name = "Label12"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(131, 13)
			label12.Size = size
			Me.Label12.TabIndex = 14
			Me.Label12.Text = "منـــــــــــــــدوب المبيعات"
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.AutoSize = True
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(662, 49)
			label13.Location = point
			Me.Label8.Name = "Label8"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(133, 13)
			label14.Size = size
			Me.Label8.TabIndex = 5
			Me.Label8.Text = "يودع في حســـــــــــــاب "
			Me.GroupBox3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Center
			Me.GroupBox3.Controls.Add(Me.txtValD)
			Me.GroupBox3.Controls.Add(Me.Label18)
			Me.GroupBox3.Controls.Add(Me.Label17)
			Me.GroupBox3.Controls.Add(Me.rdEmp)
			Me.GroupBox3.Controls.Add(Me.rdPDeal)
			Me.GroupBox3.Controls.Add(Me.txtNo)
			Me.GroupBox3.Controls.Add(Me.Label7)
			Me.GroupBox3.Controls.Add(Me.txtDate)
			Me.GroupBox3.Controls.Add(Me.cmbAccounts)
			Me.GroupBox3.Controls.Add(Me.Label5)
			Me.GroupBox3.Controls.Add(Me.cmbEmployee)
			Me.GroupBox3.Controls.Add(Me.Label4)
			Me.GroupBox3.Controls.Add(Me.txtVal)
			Me.GroupBox3.Controls.Add(Me.Label3)
			Me.GroupBox3.Controls.Add(Me.Label6)
			Me.GroupBox3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.GroupBox3.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(3, 17)
			groupBox9.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(838, 157)
			groupBox10.Size = size
			Me.GroupBox3.TabIndex = 0
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "سند قبض لجميع العمليات الادارية بالمؤسسة "
			Me.GroupBox3.UseCompatibleTextRendering = True
			Me.txtValD.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtValD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Dim txtValD As Global.System.Windows.Forms.Control = Me.txtValD
			point = New Global.System.Drawing.Point(97, 75)
			txtValD.Location = point
			Me.txtValD.Name = "txtValD"
			Dim txtValD2 As Global.System.Windows.Forms.Control = Me.txtValD
			size = New Global.System.Drawing.Size(186, 21)
			txtValD2.Size = size
			Me.txtValD.TabIndex = 11
			Me.Label18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label18.AutoSize = True
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label18
			point = New Global.System.Drawing.Point(60, 78)
			label15.Location = point
			Me.Label18.Name = "Label18"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label18
			size = New Global.System.Drawing.Size(32, 13)
			label16.Size = size
			Me.Label18.TabIndex = 13
			Me.Label18.Text = "دولار"
			Me.Label17.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label17.AutoSize = True
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label17
			point = New Global.System.Drawing.Point(296, 78)
			label17.Location = point
			Me.Label17.Name = "Label17"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label17
			size = New Global.System.Drawing.Size(65, 13)
			label18.Size = size
			Me.Label17.TabIndex = 12
			Me.Label17.Text = "قيمة السند"
			Me.rdEmp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdEmp.AutoSize = True
			Me.rdEmp.Checked = True
			Dim rdEmp As Global.System.Windows.Forms.Control = Me.rdEmp
			point = New Global.System.Drawing.Point(566, 100)
			rdEmp.Location = point
			Me.rdEmp.Name = "rdEmp"
			Dim rdEmp2 As Global.System.Windows.Forms.Control = Me.rdEmp
			size = New Global.System.Drawing.Size(59, 17)
			rdEmp2.Size = size
			Me.rdEmp.TabIndex = 9
			Me.rdEmp.TabStop = True
			Me.rdEmp.Text = "موظف"
			Me.rdEmp.UseVisualStyleBackColor = True
			Me.rdPDeal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdPDeal.AutoSize = True
			Dim rdPDeal As Global.System.Windows.Forms.Control = Me.rdPDeal
			point = New Global.System.Drawing.Point(518, 100)
			rdPDeal.Location = point
			Me.rdPDeal.Name = "rdPDeal"
			Dim rdPDeal2 As Global.System.Windows.Forms.Control = Me.rdPDeal
			size = New Global.System.Drawing.Size(46, 17)
			rdPDeal2.Size = size
			Me.rdPDeal.TabIndex = 10
			Me.rdPDeal.Text = "جهة"
			Me.rdPDeal.UseVisualStyleBackColor = True
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(539, 37)
			txtNo.Location = point
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(112, 21)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 7
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(696, 40)
			label19.Location = point
			Me.Label7.Name = "Label7"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(60, 13)
			label20.Size = size
			Me.Label7.TabIndex = 8
			Me.Label7.Text = "رقم السند"
			Me.txtDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDate As Global.System.Windows.Forms.Control = Me.txtDate
			point = New Global.System.Drawing.Point(539, 68)
			txtDate.Location = point
			Me.txtDate.Name = "txtDate"
			Dim txtDate2 As Global.System.Windows.Forms.Control = Me.txtDate
			size = New Global.System.Drawing.Size(113, 21)
			txtDate2.Size = size
			Me.txtDate.TabIndex = 0
			Dim txtDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDate3.Value = dateTime
			Me.cmbAccounts.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbAccounts.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbAccounts.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbAccounts.FormattingEnabled = True
			Me.cmbAccounts.Items.AddRange(New Object() { "رأس مال نقد بداية المدة", "رأس مال أرصدة بداية المدة", "أوراق قبض" })
			Dim cmbAccounts As Global.System.Windows.Forms.Control = Me.cmbAccounts
			point = New Global.System.Drawing.Point(97, 107)
			cmbAccounts.Location = point
			Me.cmbAccounts.Name = "cmbAccounts"
			Dim cmbAccounts2 As Global.System.Windows.Forms.Control = Me.cmbAccounts
			size = New Global.System.Drawing.Size(186, 21)
			cmbAccounts2.Size = size
			Me.cmbAccounts.TabIndex = 1
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.AutoSize = True
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(291, 111)
			label21.Location = point
			Me.Label5.Name = "Label5"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(89, 13)
			label22.Size = size
			Me.Label5.TabIndex = 6
			Me.Label5.Text = "دفعة من حساب"
			Me.cmbEmployee.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbEmployee.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEmployee.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEmployee.FormattingEnabled = True
			Me.cmbEmployee.Items.AddRange(New Object() { "فهد محمد العلوي", "فيصل تركي الاحمدي" })
			Dim cmbEmployee As Global.System.Windows.Forms.Control = Me.cmbEmployee
			point = New Global.System.Drawing.Point(472, 120)
			cmbEmployee.Location = point
			Me.cmbEmployee.Name = "cmbEmployee"
			Dim cmbEmployee2 As Global.System.Windows.Forms.Control = Me.cmbEmployee
			size = New Global.System.Drawing.Size(180, 21)
			cmbEmployee2.Size = size
			Me.cmbEmployee.TabIndex = 1
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Dim label23 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(663, 123)
			label23.Location = point
			Me.Label4.Name = "Label4"
			Dim label24 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(98, 13)
			label24.Size = size
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "استلمت أنا السيد"
			Me.txtVal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtVal.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Dim txtVal As Global.System.Windows.Forms.Control = Me.txtVal
			point = New Global.System.Drawing.Point(97, 48)
			txtVal.Location = point
			Me.txtVal.Name = "txtVal"
			Dim txtVal2 As Global.System.Windows.Forms.Control = Me.txtVal
			size = New Global.System.Drawing.Size(186, 21)
			txtVal2.Size = size
			Me.txtVal.TabIndex = 1
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Dim label25 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(296, 51)
			label25.Location = point
			Me.Label3.Name = "Label3"
			Dim label26 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(65, 13)
			label26.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "قيمة السند"
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Dim label27 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(709, 71)
			label27.Location = point
			Me.Label6.Name = "Label6"
			Dim label28 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(53, 13)
			label28.Size = size
			Me.Label6.TabIndex = 2
			Me.Label6.Text = "التاريــــخ"
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Dim tabPage4 As Global.System.Windows.Forms.TabPage = Me.TabPage2
			point = New Global.System.Drawing.Point(4, 22)
			tabPage4.Location = point
			Me.TabPage2.Name = "TabPage2"
			Dim tabPage5 As Global.System.Windows.Forms.Control = Me.TabPage2
			padding = New Global.System.Windows.Forms.Padding(3)
			tabPage5.Padding = padding
			Dim tabPage6 As Global.System.Windows.Forms.Control = Me.TabPage2
			size = New Global.System.Drawing.Size(850, 426)
			tabPage6.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "                   البحث                   "
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox4.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim groupBox11 As Global.System.Windows.Forms.Control = Me.GroupBox4
			point = New Global.System.Drawing.Point(3, 118)
			groupBox11.Location = point
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox12 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(844, 305)
			groupBox12.Size = size
			Me.GroupBox4.TabIndex = 11
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "نتائج البحث"
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column1, Me.Column2 })
			Me.dgvSrch.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvSrch As Global.System.Windows.Forms.Control = Me.dgvSrch
			point = New Global.System.Drawing.Point(3, 17)
			dgvSrch.Location = point
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvSrch2 As Global.System.Windows.Forms.Control = Me.dgvSrch
			size = New Global.System.Drawing.Size(838, 285)
			dgvSrch2.Size = size
			Me.dgvSrch.TabIndex = 0
			Me.DataGridViewTextBoxColumn1.HeaderText = "الرقم"
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
			Me.Column3.HeaderText = "التاريخ"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column1.HeaderText = "المبلغ"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column2.HeaderText = "مندوب المبيعات"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 200
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtSrchNo)
			Me.GroupBox6.Controls.Add(Me.Label15)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GroupBox6.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim groupBox13 As Global.System.Windows.Forms.Control = Me.GroupBox6
			point = New Global.System.Drawing.Point(3, 3)
			groupBox13.Location = point
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox14 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(844, 115)
			groupBox14.Size = size
			Me.GroupBox6.TabIndex = 10
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "البحث"
			Me.txtSrchNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSrchNo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Dim txtSrchNo As Global.System.Windows.Forms.Control = Me.txtSrchNo
			point = New Global.System.Drawing.Point(624, 36)
			txtSrchNo.Location = point
			Me.txtSrchNo.Name = "txtSrchNo"
			Dim txtSrchNo2 As Global.System.Windows.Forms.Control = Me.txtSrchNo
			size = New Global.System.Drawing.Size(124, 21)
			txtSrchNo2.Size = size
			Me.txtSrchNo.TabIndex = 9
			Me.txtSrchNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label15.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label15.AutoSize = True
			Dim label29 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(758, 39)
			label29.Location = point
			Me.Label15.Name = "Label15"
			Dim label30 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(60, 13)
			label30.Size = size
			Me.Label15.TabIndex = 10
			Me.Label15.Text = "رقم السند"
			Me.txtToDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtToDate As Global.System.Windows.Forms.Control = Me.txtToDate
			point = New Global.System.Drawing.Point(390, 68)
			txtToDate.Location = point
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate2 As Global.System.Windows.Forms.Control = Me.txtToDate
			size = New Global.System.Drawing.Size(124, 21)
			txtToDate2.Size = size
			Me.txtToDate.TabIndex = 1
			Dim txtToDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate3.Value = dateTime
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Dim label31 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(525, 72)
			label31.Location = point
			Me.Label2.Name = "Label2"
			Dim label32 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(56, 13)
			label32.Size = size
			Me.Label2.TabIndex = 6
			Me.Label2.Text = "الى تاريخ"
			Me.txtFromDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtFromDate As Global.System.Windows.Forms.Control = Me.txtFromDate
			point = New Global.System.Drawing.Point(624, 68)
			txtFromDate.Location = point
			Me.txtFromDate.Name = "txtFromDate"
			Dim txtFromDate2 As Global.System.Windows.Forms.Control = Me.txtFromDate
			size = New Global.System.Drawing.Size(124, 21)
			txtFromDate2.Size = size
			Me.txtFromDate.TabIndex = 0
			Dim txtFromDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtFromDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtFromDate3.Value = dateTime
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Dim label33 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(763, 72)
			label33.Location = point
			Me.Label1.Name = "Label1"
			Dim label34 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(52, 13)
			label34.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "من تاريخ"
			Me.btnSearch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Dim btnSearch As Global.System.Windows.Forms.Control = Me.btnSearch
			point = New Global.System.Drawing.Point(183, 41)
			btnSearch.Location = point
			Me.btnSearch.Name = "btnSearch"
			Dim btnSearch2 As Global.System.Windows.Forms.Control = Me.btnSearch
			size = New Global.System.Drawing.Size(89, 48)
			btnSearch2.Size = size
			Me.btnSearch.TabIndex = 2
			Me.btnSearch.UseVisualStyleBackColor = False
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(864, 471)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmSandQD_"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "سند قبض داخلي"
			Me.GroupBox1.ResumeLayout(False)
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox7.ResumeLayout(False)
			Me.GroupBox7.PerformLayout()
			Me.ToolStrip2.ResumeLayout(False)
			Me.ToolStrip2.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
