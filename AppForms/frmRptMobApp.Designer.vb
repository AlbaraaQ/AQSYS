Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptMobApp
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbApps As ComboBox
    Friend WithEvents colcust As DataGridViewTextBoxColumn
    Friend WithEvents colsno As DataGridViewTextBoxColumn
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdPaidAll As RadioButton
    Friend WithEvents rdPaidComp As RadioButton
    Friend WithEvents rdPaidOnline As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumFees As Label
    Friend WithEvents txtSumSale As Label

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
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.rdPaidOnline = New Global.System.Windows.Forms.RadioButton()
			Me.rdPaidComp = New Global.System.Windows.Forms.RadioButton()
			Me.rdPaidAll = New Global.System.Windows.Forms.RadioButton()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.cmbApps = New Global.System.Windows.Forms.ComboBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colcust = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.colsno = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSumFees = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtSumSale = New Global.System.Windows.Forms.Label()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Timer1.Interval = 500
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(3, 85)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(890, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 37
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtDateTo.CustomFormat = "dd/MM/yyyy hh:mm tt"
			Me.txtDateTo.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(396, 52)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(160, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 3
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(809, 55)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(72, 13)
			label2.Size = size
			Me.Label1.TabIndex = 15
			Me.Label1.Text = "من التاريــــخ"
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.White
			Me.GroupBox1.Controls.Add(Me.GroupBox3)
			Me.GroupBox1.Controls.Add(Me.chkAll)
			Me.GroupBox1.Controls.Add(Me.cmbApps)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(896, 111)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 12
			Me.GroupBox1.TabStop = False
			Me.GroupBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox3.Controls.Add(Me.rdPaidOnline)
			Me.GroupBox3.Controls.Add(Me.rdPaidComp)
			Me.GroupBox3.Controls.Add(Me.rdPaidAll)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(116, 126)
			groupBox3.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(273, 64)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 41
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Visible = False
			Me.rdPaidOnline.AutoSize = True
			Dim rdPaidOnline As Global.System.Windows.Forms.Control = Me.rdPaidOnline
			point = New Global.System.Drawing.Point(118, 27)
			rdPaidOnline.Location = point
			Me.rdPaidOnline.Name = "rdPaidOnline"
			Dim rdPaidOnline2 As Global.System.Windows.Forms.Control = Me.rdPaidOnline
			size = New Global.System.Drawing.Size(96, 17)
			rdPaidOnline2.Size = size
			Me.rdPaidOnline.TabIndex = 0
			Me.rdPaidOnline.Text = "مدفوع أونلاين"
			Me.rdPaidOnline.UseVisualStyleBackColor = True
			Me.rdPaidComp.AutoSize = True
			Dim rdPaidComp As Global.System.Windows.Forms.Control = Me.rdPaidComp
			point = New Global.System.Drawing.Point(1, 27)
			rdPaidComp.Location = point
			Me.rdPaidComp.Name = "rdPaidComp"
			Dim rdPaidComp2 As Global.System.Windows.Forms.Control = Me.rdPaidComp
			size = New Global.System.Drawing.Size(114, 17)
			rdPaidComp2.Size = size
			Me.rdPaidComp.TabIndex = 0
			Me.rdPaidComp.Text = "مدفوع للمؤسسة"
			Me.rdPaidComp.UseVisualStyleBackColor = True
			Me.rdPaidAll.AutoSize = True
			Me.rdPaidAll.Checked = True
			Dim rdPaidAll As Global.System.Windows.Forms.Control = Me.rdPaidAll
			point = New Global.System.Drawing.Point(219, 27)
			rdPaidAll.Location = point
			Me.rdPaidAll.Name = "rdPaidAll"
			Dim rdPaidAll2 As Global.System.Windows.Forms.Control = Me.rdPaidAll
			size = New Global.System.Drawing.Size(49, 17)
			rdPaidAll2.Size = size
			Me.rdPaidAll.TabIndex = 0
			Me.rdPaidAll.TabStop = True
			Me.rdPaidAll.Text = "الكل"
			Me.rdPaidAll.UseVisualStyleBackColor = True
			Me.chkAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAll.AutoSize = True
			Me.chkAll.Checked = True
			Me.chkAll.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkAll.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAll As Global.System.Windows.Forms.Control = Me.chkAll
			point = New Global.System.Drawing.Point(553, 21)
			chkAll.Location = point
			Me.chkAll.Name = "chkAll"
			Dim chkAll2 As Global.System.Windows.Forms.Control = Me.chkAll
			size = New Global.System.Drawing.Size(50, 17)
			chkAll2.Size = size
			Me.chkAll.TabIndex = 40
			Me.chkAll.Text = "الكل"
			Me.chkAll.UseVisualStyleBackColor = True
			Me.cmbApps.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbApps.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbApps.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbApps.Enabled = False
			Me.cmbApps.FormattingEnabled = True
			Dim cmbApps As Global.System.Windows.Forms.Control = Me.cmbApps
			point = New Global.System.Drawing.Point(606, 19)
			cmbApps.Location = point
			Me.cmbApps.Name = "cmbApps"
			Dim cmbApps2 As Global.System.Windows.Forms.Control = Me.cmbApps
			size = New Global.System.Drawing.Size(197, 21)
			cmbApps2.Size = size
			Me.cmbApps.TabIndex = 38
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(806, 23)
			label3.Location = point
			Me.Label4.Name = "Label4"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(48, 13)
			label4.Size = size
			Me.Label4.TabIndex = 39
			Me.Label4.Text = "التطبيق"
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnClose.BackColor = Global.System.Drawing.Color.White
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(41, 21)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(83, 53)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = False
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.BackColor = Global.System.Drawing.Color.White
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(206, 21)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(76, 53)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = False
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.BackColor = Global.System.Drawing.Color.White
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(126, 21)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(77, 53)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = False
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.BackColor = Global.System.Drawing.Color.White
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(286, 21)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(75, 53)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = False
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtDateFrom.CustomFormat = "dd/MM/yyyy hh:mm tt"
			Me.txtDateFrom.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(641, 52)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(162, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(560, 55)
			label5.Location = point
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(77, 13)
			label6.Size = size
			Me.Label2.TabIndex = 15
			Me.Label2.Text = "الي التاريــــخ"
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 111)
			groupBox5.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(896, 347)
			groupBox6.Size = size
			Me.GroupBox2.TabIndex = 14
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "الفواتير"
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.colcust, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.colsno })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(3, 16)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(890, 296)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 3
			Me.Column1.HeaderText = "procid"
			Me.Column1.Name = "Column1"
			Me.Column1.Visible = False
			Me.Column2.HeaderText = "رقم الفاتورة"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.colcust.HeaderText = "التاريخ"
			Me.colcust.Name = "colcust"
			Me.colcust.[ReadOnly] = True
			Me.colcust.Width = 110
			Me.Column3.HeaderText = "إسم التطبيق"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 120
			Me.Column4.HeaderText = "رسوم التطبيق"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 110
			Me.Column6.HeaderText = "قيمة الفاتورة"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 120
			Me.Column5.HeaderText = ""
			Me.Column5.Name = "Column5"
			Me.Column5.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column5.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			Me.Column5.Text = "عرض"
			Me.Column5.ToolTipText = "عرض"
			Me.Column5.UseColumnTextForButtonValue = True
			Me.Column5.Width = 90
			Me.colsno.HeaderText = "م"
			Me.colsno.Name = "colsno"
			Me.colsno.Width = 70
			Me.Panel1.BackColor = Global.System.Drawing.Color.FromArgb(217, 162, 2)
			Me.Panel1.Controls.Add(Me.txtSumFees)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.txtSumSale)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 312)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(890, 32)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.txtSumFees.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumFees.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumFees.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumFees.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSumFees As Global.System.Windows.Forms.Control = Me.txtSumFees
			point = New Global.System.Drawing.Point(424, 0)
			txtSumFees.Location = point
			Me.txtSumFees.Name = "txtSumFees"
			Dim txtSumFees2 As Global.System.Windows.Forms.Control = Me.txtSumFees
			size = New Global.System.Drawing.Size(98, 28)
			txtSumFees2.Size = size
			Me.txtSumFees.TabIndex = 11
			Me.txtSumFees.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(524, 0)
			label7.Location = point
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(370, 28)
			label8.Size = size
			Me.Label3.TabIndex = 9
			Me.Label3.Text = "الاجمالي"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(-139, 0)
			label9.Location = point
			Me.Label5.Name = "Label5"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(442, 28)
			label10.Size = size
			Me.Label5.TabIndex = 10
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label5.Visible = False
			Me.txtSumSale.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumSale.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumSale.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumSale.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSumSale As Global.System.Windows.Forms.Control = Me.txtSumSale
			point = New Global.System.Drawing.Point(305, 0)
			txtSumSale.Location = point
			Me.txtSumSale.Name = "txtSumSale"
			Dim txtSumSale2 As Global.System.Windows.Forms.Control = Me.txtSumSale
			size = New Global.System.Drawing.Size(118, 28)
			txtSumSale2.Size = size
			Me.txtSumSale.TabIndex = 10
			Me.txtSumSale.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(896, 458)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptMobApp"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير طلبات التطبيقات"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
