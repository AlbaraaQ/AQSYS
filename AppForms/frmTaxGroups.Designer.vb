Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmTaxGroups
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtNameAr As TextBox
    Friend WithEvents txtNameEN As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtValue As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmTaxGroups))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.ColorDialog1 = New Global.System.Windows.Forms.ColorDialog()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtValue = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtNameEN = New Global.System.Windows.Forms.TextBox()
			Me.txtNameAr = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbCurrency = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox2.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox2.Controls.Add(Me.panel2)
			Me.GroupBox2.Controls.Add(Me.Label4)
			Me.GroupBox2.Controls.Add(Me.Label1)
			Me.GroupBox2.Controls.Add(Me.txtNo)
			Me.GroupBox2.Controls.Add(Me.Label2)
			Me.GroupBox2.Controls.Add(Me.txtValue)
			Me.GroupBox2.Controls.Add(Me.Label3)
			Me.GroupBox2.Controls.Add(Me.txtNameEN)
			Me.GroupBox2.Controls.Add(Me.txtNameAr)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(610, 193)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 8
			Me.GroupBox2.TabStop = False
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.panel2
			point = New Global.System.Drawing.Point(3, 135)
			panel.Location = point
			Me.panel2.Name = "panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.panel2
			size = New Global.System.Drawing.Size(604, 55)
			panel2.Size = size
			Me.panel2.TabIndex = 8
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.toolStrip1
			point = New Global.System.Drawing.Point(0, 0)
			toolStrip.Location = point
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.toolStrip1
			size = New Global.System.Drawing.Size(602, 53)
			toolStrip2.Size = size
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			Me.btnNew.AutoSize = False
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), Global.System.Drawing.Image)
			Me.btnNew.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNew.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNew.Name = "btnNew"
			Dim btnNew As Global.System.Windows.Forms.ToolStripItem = Me.btnNew
			size = New Global.System.Drawing.Size(50, 50)
			btnNew.Size = size
			Me.btnNew.Text = "جديد"
			Me.btnSave.AutoSize = False
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), Global.System.Drawing.Image)
			Me.btnSave.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSave.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnSave.Name = "btnSave"
			Dim btnSave As Global.System.Windows.Forms.ToolStripItem = Me.btnSave
			size = New Global.System.Drawing.Size(50, 50)
			btnSave.Size = size
			Me.btnSave.Text = "حفظ"
			Me.btnDelete.AutoSize = False
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Global.System.Drawing.Image)
			Me.btnDelete.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnDelete.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnDelete.Name = "btnDelete"
			Dim btnDelete As Global.System.Windows.Forms.ToolStripItem = Me.btnDelete
			size = New Global.System.Drawing.Size(50, 50)
			btnDelete.Size = size
			Me.btnDelete.Text = "حذف"
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator1
			size = New Global.System.Drawing.Size(6, 53)
			toolStripSeparator.Size = size
			Me.btnLast.AutoSize = False
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), Global.System.Drawing.Image)
			Me.btnLast.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnLast.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnLast.Name = "btnLast"
			Dim btnLast As Global.System.Windows.Forms.ToolStripItem = Me.btnLast
			size = New Global.System.Drawing.Size(50, 50)
			btnLast.Size = size
			Me.btnLast.Text = "الأخير"
			Me.btnNext.AutoSize = False
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), Global.System.Drawing.Image)
			Me.btnNext.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNext.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNext.Name = "btnNext"
			Dim btnNext As Global.System.Windows.Forms.ToolStripItem = Me.btnNext
			size = New Global.System.Drawing.Size(50, 50)
			btnNext.Size = size
			Me.btnNext.Text = "التالي"
			Me.btnPrevious.AutoSize = False
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Global.System.Drawing.Image)
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
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator2
			size = New Global.System.Drawing.Size(6, 53)
			toolStripSeparator2.Size = size
			Me.btnPrint.AutoSize = False
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Global.System.Drawing.Image)
			Me.btnPrint.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrint.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint As Global.System.Windows.Forms.ToolStripItem = Me.btnPrint
			size = New Global.System.Drawing.Size(50, 50)
			btnPrint.Size = size
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.Visible = False
			Me.btnClose.AutoSize = False
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), Global.System.Drawing.Image)
			Me.btnClose.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnClose.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnClose.Name = "btnClose"
			Dim btnClose As Global.System.Windows.Forms.ToolStripItem = Me.btnClose
			size = New Global.System.Drawing.Size(50, 50)
			btnClose.Size = size
			Me.btnClose.Text = "خروج"
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(492, 19)
			label.Location = point
			Me.Label4.Name = "Label4"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(31, 13)
			label2.Size = size
			Me.Label4.TabIndex = 2
			Me.Label4.Text = "الرقم"
			Me.Label4.Visible = False
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(481, 45)
			label3.Location = point
			Me.Label1.Name = "Label1"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(65, 13)
			label4.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "الإسم عربي"
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(366, 15)
			txtNo.Location = point
			Me.txtNo.Name = "txtNo"
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(92, 20)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 3
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(488, 97)
			label5.Location = point
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(50, 13)
			label6.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "القيمة %"
			Me.txtValue.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtValue As Global.System.Windows.Forms.Control = Me.txtValue
			point = New Global.System.Drawing.Point(366, 93)
			txtValue.Location = point
			Me.txtValue.Name = "txtValue"
			Dim txtValue2 As Global.System.Windows.Forms.Control = Me.txtValue
			size = New Global.System.Drawing.Size(92, 20)
			txtValue2.Size = size
			Me.txtValue.TabIndex = 3
			Me.txtValue.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(476, 71)
			label7.Location = point
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(75, 13)
			label8.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "الإسم انجليزي"
			Me.txtNameEN.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNameEN As Global.System.Windows.Forms.Control = Me.txtNameEN
			point = New Global.System.Drawing.Point(86, 67)
			txtNameEN.Location = point
			Me.txtNameEN.Name = "txtNameEN"
			Dim txtNameEN2 As Global.System.Windows.Forms.Control = Me.txtNameEN
			size = New Global.System.Drawing.Size(372, 20)
			txtNameEN2.Size = size
			Me.txtNameEN.TabIndex = 3
			Me.txtNameAr.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNameAr As Global.System.Windows.Forms.Control = Me.txtNameAr
			point = New Global.System.Drawing.Point(86, 41)
			txtNameAr.Location = point
			Me.txtNameAr.Name = "txtNameAr"
			Dim txtNameAr2 As Global.System.Windows.Forms.Control = Me.txtNameAr
			size = New Global.System.Drawing.Size(372, 20)
			txtNameAr2.Size = size
			Me.txtNameAr.TabIndex = 3
			Me.GroupBox3.Controls.Add(Me.dgvData)
			Me.GroupBox3.Controls.Add(Me.Panel1)
			Me.GroupBox3.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(0, 193)
			groupBox3.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(610, 269)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 10
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "إدراج أصناف"
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
			Me.dgvData.AllowUserToOrderColumns = True
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column2, Me.Column1, Me.Column3, Me.Column4 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(3, 60)
			dgvData.Location = point
			Me.dgvData.MultiSelect = False
			Me.dgvData.Name = "dgvData"
			Me.dgvData.[ReadOnly] = True
			Me.dgvData.RowHeadersVisible = False
			Me.dgvData.RowTemplate.DefaultCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(604, 206)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 5
			Me.Column2.HeaderText = "الرقم"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 70
			Me.Column1.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
			Me.Column1.HeaderText = "رقم الصنف"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column3.HeaderText = "الصنف"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 300
			Me.Column4.HeaderText = ""
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Text = "حذف"
			Me.Column4.ToolTipText = "حذف"
			Me.Column4.UseColumnTextForButtonValue = True
			Me.Column4.Width = 70
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.cmbCurrency)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 16)
			panel3.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(604, 44)
			panel4.Size = size
			Me.Panel1.TabIndex = 0
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(139, 4)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 34)
			button2.Size = size
			Me.Button1.TabIndex = 145
			Me.Button1.Text = "حفظ"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(472, 9)
			label9.Location = point
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(54, 23)
			label10.Size = size
			Me.Label5.TabIndex = 144
			Me.Label5.Text = "الصنف"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.cmbCurrency.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCurrency.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCurrency.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCurrency.BackColor = Global.System.Drawing.SystemColors.InactiveCaption
			Me.cmbCurrency.DropDownHeight = 400
			Me.cmbCurrency.DropDownWidth = 257
			Me.cmbCurrency.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.cmbCurrency.Font = New Global.System.Drawing.Font("Tahoma", 14.25F, Global.System.Drawing.FontStyle.Bold)
			Me.cmbCurrency.FormattingEnabled = True
			Me.cmbCurrency.IntegralHeight = False
			Dim cmbCurrency As Global.System.Windows.Forms.Control = Me.cmbCurrency
			point = New Global.System.Drawing.Point(215, 6)
			cmbCurrency.Location = point
			Me.cmbCurrency.Name = "cmbCurrency"
			Dim cmbCurrency2 As Global.System.Windows.Forms.Control = Me.cmbCurrency
			size = New Global.System.Drawing.Size(253, 31)
			cmbCurrency2.Size = size
			Me.cmbCurrency.TabIndex = 143
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(610, 462)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox2)
			Me.Name = "frmTaxGroups"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "المجموعات الضريبية"
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
