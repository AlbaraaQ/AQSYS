Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptClientsMaint
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllAreas As CheckBox
    Friend WithEvents chkAllCities As CheckBox
    Friend WithEvents chkBothCond As CheckBox
    Friend WithEvents chkJoinDate As CheckBox
    Friend WithEvents chkMaintDate As CheckBox
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtMaintFromDate As DateTimePicker
    Friend WithEvents txtMaintToDate As DateTimePicker
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSum As Label

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
			Me.chkAllAreas = New Global.System.Windows.Forms.CheckBox()
			Me.chkMaintDate = New Global.System.Windows.Forms.CheckBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.lblCount = New Global.System.Windows.Forms.Label()
			Me.chkJoinDate = New Global.System.Windows.Forms.CheckBox()
			Me.chkAllCities = New Global.System.Windows.Forms.CheckBox()
			Me.cmbArea = New Global.System.Windows.Forms.ComboBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.cmbCity = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtMobile = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.txtMaintFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtMaintToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.chkBothCond = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.chkAllAreas.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllAreas.AutoSize = True
			Me.chkAllAreas.Checked = True
			Me.chkAllAreas.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllAreas As Global.System.Windows.Forms.Control = Me.chkAllAreas
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(361, 41)
			chkAllAreas.Location = point
			Me.chkAllAreas.Name = "chkAllAreas"
			Dim chkAllAreas2 As Global.System.Windows.Forms.Control = Me.chkAllAreas
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(50, 17)
			chkAllAreas2.Size = size
			Me.chkAllAreas.TabIndex = 22
			Me.chkAllAreas.Text = "الكل"
			Me.chkAllAreas.UseVisualStyleBackColor = True
			Me.chkMaintDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkMaintDate.AutoSize = True
			Dim chkMaintDate As Global.System.Windows.Forms.Control = Me.chkMaintDate
			point = New Global.System.Drawing.Point(884, 61)
			chkMaintDate.Location = point
			Me.chkMaintDate.Name = "chkMaintDate"
			Dim chkMaintDate2 As Global.System.Windows.Forms.Control = Me.chkMaintDate
			size = New Global.System.Drawing.Size(88, 17)
			chkMaintDate2.Size = size
			Me.chkMaintDate.TabIndex = 22
			Me.chkMaintDate.Text = "تاريخ الزيارة"
			Me.chkMaintDate.UseVisualStyleBackColor = True
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(24, 20)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(78, 62)
			button2.Size = size
			Me.Button1.TabIndex = 23
			Me.Button1.Text = "خروج"
			Me.Button1.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.chkBothCond)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.lblCount)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.chkAllAreas)
			Me.GroupBox1.Controls.Add(Me.chkMaintDate)
			Me.GroupBox1.Controls.Add(Me.chkJoinDate)
			Me.GroupBox1.Controls.Add(Me.chkAllCities)
			Me.GroupBox1.Controls.Add(Me.cmbArea)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.cmbCity)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.txtMobile)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.txtName)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.txtMaintFromDate)
			Me.GroupBox1.Controls.Add(Me.txtMaintToDate)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(978, 127)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 12
			Me.GroupBox1.TabStop = False
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(3, 101)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(972, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 27
			Me.lblCount.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblCount.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCount As Global.System.Windows.Forms.Control = Me.lblCount
			point = New Global.System.Drawing.Point(185, 84)
			lblCount.Location = point
			Me.lblCount.Name = "lblCount"
			Dim lblCount2 As Global.System.Windows.Forms.Control = Me.lblCount
			size = New Global.System.Drawing.Size(168, 20)
			lblCount2.Size = size
			Me.lblCount.TabIndex = 26
			Me.lblCount.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.chkJoinDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkJoinDate.AutoSize = True
			Dim chkJoinDate As Global.System.Windows.Forms.Control = Me.chkJoinDate
			point = New Global.System.Drawing.Point(870, 37)
			chkJoinDate.Location = point
			Me.chkJoinDate.Name = "chkJoinDate"
			Dim chkJoinDate2 As Global.System.Windows.Forms.Control = Me.chkJoinDate
			size = New Global.System.Drawing.Size(102, 17)
			chkJoinDate2.Size = size
			Me.chkJoinDate.TabIndex = 22
			Me.chkJoinDate.Text = "تاريخ الاشتراك"
			Me.chkJoinDate.UseVisualStyleBackColor = True
			Me.chkAllCities.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllCities.AutoSize = True
			Me.chkAllCities.Checked = True
			Me.chkAllCities.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllCities As Global.System.Windows.Forms.Control = Me.chkAllCities
			point = New Global.System.Drawing.Point(361, 14)
			chkAllCities.Location = point
			Me.chkAllCities.Name = "chkAllCities"
			Dim chkAllCities2 As Global.System.Windows.Forms.Control = Me.chkAllCities
			size = New Global.System.Drawing.Size(50, 17)
			chkAllCities2.Size = size
			Me.chkAllCities.TabIndex = 22
			Me.chkAllCities.Text = "الكل"
			Me.chkAllCities.UseVisualStyleBackColor = True
			Me.cmbArea.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbArea.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbArea.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbArea.Enabled = False
			Me.cmbArea.FormattingEnabled = True
			Dim cmbArea As Global.System.Windows.Forms.Control = Me.cmbArea
			point = New Global.System.Drawing.Point(414, 39)
			cmbArea.Location = point
			Me.cmbArea.Name = "cmbArea"
			Dim cmbArea2 As Global.System.Windows.Forms.Control = Me.cmbArea
			size = New Global.System.Drawing.Size(100, 21)
			cmbArea2.Size = size
			Me.cmbArea.TabIndex = 20
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Me.Label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(528, 42)
			label.Location = point
			Me.Label6.Name = "Label6"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(36, 13)
			label2.Size = size
			Me.Label6.TabIndex = 21
			Me.Label6.Text = "الحي"
			Me.cmbCity.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCity.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCity.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCity.Enabled = False
			Me.cmbCity.FormattingEnabled = True
			Dim cmbCity As Global.System.Windows.Forms.Control = Me.cmbCity
			point = New Global.System.Drawing.Point(414, 12)
			cmbCity.Location = point
			Me.cmbCity.Name = "cmbCity"
			Dim cmbCity2 As Global.System.Windows.Forms.Control = Me.cmbCity
			size = New Global.System.Drawing.Size(100, 21)
			cmbCity2.Size = size
			Me.cmbCity.TabIndex = 18
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.AutoSize = True
			Me.Label9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(526, 16)
			label3.Location = point
			Me.Label9.Name = "Label9"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(43, 13)
			label4.Size = size
			Me.Label9.TabIndex = 19
			Me.Label9.Text = "المدينة"
			Me.txtMobile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtMobile As Global.System.Windows.Forms.Control = Me.txtMobile
			point = New Global.System.Drawing.Point(414, 65)
			txtMobile.Location = point
			Me.txtMobile.Name = "txtMobile"
			Dim txtMobile2 As Global.System.Windows.Forms.Control = Me.txtMobile
			size = New Global.System.Drawing.Size(100, 20)
			txtMobile2.Size = size
			Me.txtMobile.TabIndex = 16
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Me.Label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(517, 68)
			label5.Location = point
			Me.Label7.Name = "Label7"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(63, 13)
			label6.Size = size
			Me.Label7.TabIndex = 17
			Me.Label7.Text = "رقم الجوال"
			Me.txtName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtName As Global.System.Windows.Forms.Control = Me.txtName
			point = New Global.System.Drawing.Point(595, 7)
			txtName.Location = point
			Me.txtName.Name = "txtName"
			Dim txtName2 As Global.System.Windows.Forms.Control = Me.txtName
			size = New Global.System.Drawing.Size(273, 20)
			txtName2.Size = size
			Me.txtName.TabIndex = 16
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(890, 12)
			label7.Location = point
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(68, 13)
			label8.Size = size
			Me.Label4.TabIndex = 17
			Me.Label4.Text = "إسم العميل"
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(183, 21)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(78, 61)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(103, 20)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(78, 62)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(263, 21)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(78, 61)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.txtMaintFromDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtMaintFromDate.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtMaintFromDate.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtMaintFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtMaintFromDate As Global.System.Windows.Forms.Control = Me.txtMaintFromDate
			point = New Global.System.Drawing.Point(776, 58)
			txtMaintFromDate.Location = point
			Me.txtMaintFromDate.Name = "txtMaintFromDate"
			Dim txtMaintFromDate2 As Global.System.Windows.Forms.Control = Me.txtMaintFromDate
			size = New Global.System.Drawing.Size(92, 20)
			txtMaintFromDate2.Size = size
			Me.txtMaintFromDate.TabIndex = 2
			Dim txtMaintFromDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtMaintFromDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtMaintFromDate3.Value = dateTime
			Me.txtMaintToDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtMaintToDate.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtMaintToDate.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtMaintToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtMaintToDate As Global.System.Windows.Forms.Control = Me.txtMaintToDate
			point = New Global.System.Drawing.Point(595, 58)
			txtMaintToDate.Location = point
			Me.txtMaintToDate.Name = "txtMaintToDate"
			Dim txtMaintToDate2 As Global.System.Windows.Forms.Control = Me.txtMaintToDate
			size = New Global.System.Drawing.Size(92, 20)
			txtMaintToDate2.Size = size
			Me.txtMaintToDate.TabIndex = 3
			Dim txtMaintToDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtMaintToDate
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtMaintToDate3.Value = dateTime
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtDateFrom.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(776, 34)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(92, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(691, 61)
			label9.Location = point
			Me.Label1.Name = "Label1"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(77, 13)
			label10.Size = size
			Me.Label1.TabIndex = 15
			Me.Label1.Text = "الي التاريــــخ"
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtDateTo.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(595, 34)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(92, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 3
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(691, 37)
			label11.Location = point
			Me.Label2.Name = "Label2"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(77, 13)
			label12.Size = size
			Me.Label2.TabIndex = 15
			Me.Label2.Text = "الي التاريــــخ"
			Me.GroupBox2.Controls.Add(Me.dgvData)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 127)
			groupBox3.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(978, 354)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 14
			Me.GroupBox2.TabStop = False
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
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column5 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(3, 16)
			dgvData.Location = point
			Me.dgvData.MultiSelect = False
			Me.dgvData.Name = "dgvData"
			Me.dgvData.[ReadOnly] = True
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(972, 303)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 3
			Me.Column1.HeaderText = "رقم العميل"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 90
			Me.Column2.HeaderText = "إسم العميل"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 170
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column3.DefaultCellStyle = dataGridViewCellStyle2
			Me.Column3.HeaderText = "جوالاته"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column4.HeaderText = "المدينة"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column6.HeaderText = "الحي"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column7.HeaderText = "تاريخ الاشتراك"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Width = 110
			Me.Column8.HeaderText = "مبلغ الاشتراك"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column8.Width = 120
			Me.Column9.HeaderText = "تاريخ آخر زيارة"
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column9.Width = 110
			Me.Column5.HeaderText = ""
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column5.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			Me.Column5.Text = "تفاصيل"
			Me.Column5.ToolTipText = "تفاصيل"
			Me.Column5.UseColumnTextForButtonValue = True
			Me.Column5.Visible = False
			Me.Column5.Width = 90
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtSum)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 319)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(972, 32)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(267, 0)
			label13.Location = point
			Me.Label3.Name = "Label3"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(702, 28)
			label14.Size = size
			Me.Label3.TabIndex = 9
			Me.Label3.Text = "الاجمالي"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSum.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSum As Global.System.Windows.Forms.Control = Me.txtSum
			point = New Global.System.Drawing.Point(140, 0)
			txtSum.Location = point
			Me.txtSum.Name = "txtSum"
			Dim txtSum2 As Global.System.Windows.Forms.Control = Me.txtSum
			size = New Global.System.Drawing.Size(126, 28)
			txtSum2.Size = size
			Me.txtSum.TabIndex = 10
			Me.txtSum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Timer1.Interval = 500
			Me.chkBothCond.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkBothCond.AutoSize = True
			Me.chkBothCond.Checked = True
			Me.chkBothCond.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkBothCond As Global.System.Windows.Forms.Control = Me.chkBothCond
			point = New Global.System.Drawing.Point(849, 83)
			chkBothCond.Location = point
			Me.chkBothCond.Name = "chkBothCond"
			Dim chkBothCond2 As Global.System.Windows.Forms.Control = Me.chkBothCond
			size = New Global.System.Drawing.Size(123, 17)
			chkBothCond2.Size = size
			Me.chkBothCond.TabIndex = 28
			Me.chkBothCond.Text = "أوبشن التحقق معاً"
			Me.chkBothCond.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(978, 481)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptClientsMaint"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير متابعة العملاء"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
