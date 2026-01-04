Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptClientMaintDetails
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button2 As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtJoinDate As TextBox
    Friend WithEvents txtLastMaint As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtSrchMobile As TextBox
    Friend WithEvents txtSum As TextBox

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
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRptClientMaintDetails))
			Me.txtMobile = New Global.System.Windows.Forms.TextBox()
			Me.lblMobile = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtSrchMobile = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Button11 = New Global.System.Windows.Forms.Button()
			Me.cmbClient = New Global.System.Windows.Forms.ComboBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.txtSum = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtLastMaint = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtJoinDate = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtArea = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtAdd = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtCity = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.txtMobile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtMobile As Global.System.Windows.Forms.Control = Me.txtMobile
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(814, 92)
			txtMobile.Location = point
			Me.txtMobile.Multiline = True
			Me.txtMobile.Name = "txtMobile"
			Me.txtMobile.[ReadOnly] = True
			Dim txtMobile2 As Global.System.Windows.Forms.Control = Me.txtMobile
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(136, 37)
			txtMobile2.Size = size
			Me.txtMobile.TabIndex = 16
			Me.txtMobile.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblMobile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblMobile.AutoSize = True
			Me.lblMobile.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMobile As Global.System.Windows.Forms.Control = Me.lblMobile
			point = New Global.System.Drawing.Point(953, 95)
			lblMobile.Location = point
			Me.lblMobile.Name = "lblMobile"
			Dim lblMobile2 As Global.System.Windows.Forms.Control = Me.lblMobile
			size = New Global.System.Drawing.Size(70, 13)
			lblMobile2.Size = size
			Me.lblMobile.TabIndex = 17
			Me.lblMobile.Text = "أرقام الجوال"
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(956, 22)
			label.Location = point
			Me.Label4.Name = "Label4"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(66, 13)
			label2.Size = size
			Me.Label4.TabIndex = 17
			Me.Label4.Text = "اختر العميل"
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 314)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(1026, 10)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AutoSizeRowsMode = Global.System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(3, 16)
			dgvData.Location = point
			Me.dgvData.MultiSelect = False
			Me.dgvData.Name = "dgvData"
			Me.dgvData.[ReadOnly] = True
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(1026, 298)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 3
			Me.Column5.HeaderText = "رقم الفاتورة"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column1.HeaderText = "تاريخ الفاتورة"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 110
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column2.DefaultCellStyle = dataGridViewCellStyle2
			Me.Column2.HeaderText = "نوع الجهاز"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 200
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column3.DefaultCellStyle = dataGridViewCellStyle3
			Me.Column3.HeaderText = "مبلغ الفاتورة"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column4.DefaultCellStyle = dataGridViewCellStyle4
			Me.Column4.HeaderText = "تاريخ الزيارة"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 110
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column6.DefaultCellStyle = dataGridViewCellStyle5
			Me.Column6.HeaderText = "نوع الزيارة"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 200
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column7.DefaultCellStyle = dataGridViewCellStyle6
			Me.Column7.HeaderText = "المندوب"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Width = 150
			Me.GroupBox2.Controls.Add(Me.dgvData)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 158)
			groupBox.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(1032, 327)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 11
			Me.GroupBox2.TabStop = False
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.txtSrchMobile)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.Button11)
			Me.GroupBox1.Controls.Add(Me.cmbClient)
			Me.GroupBox1.Controls.Add(Me.Button2)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.txtMobile)
			Me.GroupBox1.Controls.Add(Me.lblMobile)
			Me.GroupBox1.Controls.Add(Me.txtSum)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.txtLastMaint)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.txtJoinDate)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.txtNo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.txtArea)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.txtAdd)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.txtCity)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox3.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(1032, 158)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 10
			Me.GroupBox1.TabStop = False
			Me.txtSrchMobile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtSrchMobile As Global.System.Windows.Forms.Control = Me.txtSrchMobile
			point = New Global.System.Drawing.Point(849, 17)
			txtSrchMobile.Location = point
			Me.txtSrchMobile.Name = "txtSrchMobile"
			Dim txtSrchMobile2 As Global.System.Windows.Forms.Control = Me.txtSrchMobile
			size = New Global.System.Drawing.Size(100, 20)
			txtSrchMobile2.Size = size
			Me.txtSrchMobile.TabIndex = 208
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Me.Label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(865, 2)
			label3.Location = point
			Me.Label7.Name = "Label7"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(63, 13)
			label4.Size = size
			Me.Label7.TabIndex = 209
			Me.Label7.Text = "رقم الجوال"
			Me.Button11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button11.Image = CType(resources.GetObject("Button11.Image"), Global.System.Drawing.Image)
			Me.Button11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button11
			point = New Global.System.Drawing.Point(572, 14)
			button.Location = point
			Me.Button11.Name = "Button11"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button11
			size = New Global.System.Drawing.Size(32, 25)
			button2.Size = size
			Me.Button11.TabIndex = 207
			Me.Button11.UseVisualStyleBackColor = True
			Me.cmbClient.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbClient.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbClient.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbClient.BackColor = Global.System.Drawing.Color.White
			Me.cmbClient.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.cmbClient.FormattingEnabled = True
			Dim cmbClient As Global.System.Windows.Forms.Control = Me.cmbClient
			point = New Global.System.Drawing.Point(604, 15)
			cmbClient.Location = point
			Me.cmbClient.Name = "cmbClient"
			Dim cmbClient2 As Global.System.Windows.Forms.Control = Me.cmbClient
			size = New Global.System.Drawing.Size(244, 24)
			cmbClient2.Size = size
			Me.cmbClient.TabIndex = 28
			Me.Button2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(256, 26)
			button3.Location = point
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(78, 61)
			button4.Size = size
			Me.Button2.TabIndex = 27
			Me.Button2.Text = "عرض"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(16, 24)
			button5.Location = point
			Me.Button1.Name = "Button1"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(78, 62)
			button6.Size = size
			Me.Button1.TabIndex = 26
			Me.Button1.Text = "خروج"
			Me.Button1.UseVisualStyleBackColor = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(175, 25)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(78, 61)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 24
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(95, 24)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(78, 62)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 25
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.txtSum.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtSum As Global.System.Windows.Forms.Control = Me.txtSum
			point = New Global.System.Drawing.Point(503, 109)
			txtSum.Location = point
			Me.txtSum.Name = "txtSum"
			Me.txtSum.[ReadOnly] = True
			Dim txtSum2 As Global.System.Windows.Forms.Control = Me.txtSum
			size = New Global.System.Drawing.Size(99, 20)
			txtSum2.Size = size
			Me.txtSum.TabIndex = 16
			Me.txtSum.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.AutoSize = True
			Me.Label8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(514, 94)
			label5.Location = point
			Me.Label8.Name = "Label8"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(79, 13)
			label6.Size = size
			Me.Label8.TabIndex = 17
			Me.Label8.Text = "مبلغ الاشتراك"
			Me.txtLastMaint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtLastMaint As Global.System.Windows.Forms.Control = Me.txtLastMaint
			point = New Global.System.Drawing.Point(350, 109)
			txtLastMaint.Location = point
			Me.txtLastMaint.Name = "txtLastMaint"
			Me.txtLastMaint.[ReadOnly] = True
			Dim txtLastMaint2 As Global.System.Windows.Forms.Control = Me.txtLastMaint
			size = New Global.System.Drawing.Size(150, 20)
			txtLastMaint2.Size = size
			Me.txtLastMaint.TabIndex = 16
			Me.txtLastMaint.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.AutoSize = True
			Me.Label9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(380, 93)
			label7.Location = point
			Me.Label9.Name = "Label9"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(81, 13)
			label8.Size = size
			Me.Label9.TabIndex = 17
			Me.Label9.Text = "تاريخ آخر زيارة"
			Me.txtJoinDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtJoinDate As Global.System.Windows.Forms.Control = Me.txtJoinDate
			point = New Global.System.Drawing.Point(608, 109)
			txtJoinDate.Location = point
			Me.txtJoinDate.Name = "txtJoinDate"
			Me.txtJoinDate.[ReadOnly] = True
			Dim txtJoinDate2 As Global.System.Windows.Forms.Control = Me.txtJoinDate
			size = New Global.System.Drawing.Size(115, 20)
			txtJoinDate2.Size = size
			Me.txtJoinDate.TabIndex = 16
			Me.txtJoinDate.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Me.Label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(628, 93)
			label9.Location = point
			Me.Label6.Name = "Label6"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(83, 13)
			label10.Size = size
			Me.Label6.TabIndex = 17
			Me.Label6.Text = "تاريخ الاشتراك"
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(814, 43)
			txtNo.Location = point
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(136, 20)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 16
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(956, 47)
			label11.Location = point
			Me.Label3.Name = "Label3"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(63, 13)
			label12.Size = size
			Me.Label3.TabIndex = 17
			Me.Label3.Text = "رقم العميل"
			Me.txtArea.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtArea As Global.System.Windows.Forms.Control = Me.txtArea
			point = New Global.System.Drawing.Point(350, 68)
			txtArea.Location = point
			Me.txtArea.Name = "txtArea"
			Me.txtArea.[ReadOnly] = True
			Dim txtArea2 As Global.System.Windows.Forms.Control = Me.txtArea
			size = New Global.System.Drawing.Size(150, 20)
			txtArea2.Size = size
			Me.txtArea.TabIndex = 16
			Me.txtArea.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(404, 52)
			label13.Location = point
			Me.Label2.Name = "Label2"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(36, 13)
			label14.Size = size
			Me.Label2.TabIndex = 17
			Me.Label2.Text = "الحي"
			Me.txtAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtAdd As Global.System.Windows.Forms.Control = Me.txtAdd
			point = New Global.System.Drawing.Point(608, 68)
			txtAdd.Location = point
			Me.txtAdd.Name = "txtAdd"
			Me.txtAdd.[ReadOnly] = True
			Dim txtAdd2 As Global.System.Windows.Forms.Control = Me.txtAdd
			size = New Global.System.Drawing.Size(342, 20)
			txtAdd2.Size = size
			Me.txtAdd.TabIndex = 16
			Me.txtAdd.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.AutoSize = True
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(966, 73)
			label15.Location = point
			Me.Label5.Name = "Label5"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(44, 13)
			label16.Size = size
			Me.Label5.TabIndex = 17
			Me.Label5.Text = "العنوان"
			Me.txtCity.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtCity As Global.System.Windows.Forms.Control = Me.txtCity
			point = New Global.System.Drawing.Point(503, 68)
			txtCity.Location = point
			Me.txtCity.Name = "txtCity"
			Me.txtCity.[ReadOnly] = True
			Dim txtCity2 As Global.System.Windows.Forms.Control = Me.txtCity
			size = New Global.System.Drawing.Size(99, 20)
			txtCity2.Size = size
			Me.txtCity.TabIndex = 16
			Me.txtCity.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(534, 52)
			label17.Location = point
			Me.Label1.Name = "Label1"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(43, 13)
			label18.Size = size
			Me.Label1.TabIndex = 17
			Me.Label1.Text = "المدينة"
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(3, 135)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(1026, 20)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 210
			Me.Timer1.Interval = 500
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(1032, 485)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptClientMaintDetails"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير متابعة عميل"
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
