Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSMSSett
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chkActvLoginSMS As CheckBox
    Friend WithEvents chkActvSMS As CheckBox
    Friend WithEvents chkDefaultAcc As CheckBox
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents groupBox4 As GroupBox
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents pnlAcc As Panel
    Friend WithEvents rdJawal As RadioButton
    Friend WithEvents rdMobily As RadioButton
    Friend WithEvents rdMsegat As RadioButton
    Friend WithEvents rdPurchAppClose As RadioButton
    Friend WithEvents rdPurchTime As RadioButton
    Friend WithEvents rdSaleAppClose As RadioButton
    Friend WithEvents rdSaletime As RadioButton
    Friend WithEvents txtLoginMobile As TextBox
    Friend WithEvents txtPWD As TextBox
    Friend WithEvents txtPurchMobile As TextBox
    Friend WithEvents txtPurchTime As DateTimePicker
    Friend WithEvents txtSaleMobile As TextBox
    Friend WithEvents txtSaleTime As DateTimePicker
    Friend WithEvents txtSender As TextBox
    Friend WithEvents txtUsername As TextBox

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
			Me.chkActvSMS = New Global.System.Windows.Forms.CheckBox()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.chkActvLoginSMS = New Global.System.Windows.Forms.CheckBox()
			Me.txtLoginMobile = New Global.System.Windows.Forms.TextBox()
			Me.label7 = New Global.System.Windows.Forms.Label()
			Me.groupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.label5 = New Global.System.Windows.Forms.Label()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.txtSaleTime = New Global.System.Windows.Forms.DateTimePicker()
			Me.rdSaletime = New Global.System.Windows.Forms.RadioButton()
			Me.rdSaleAppClose = New Global.System.Windows.Forms.RadioButton()
			Me.txtSaleMobile = New Global.System.Windows.Forms.TextBox()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.rdPurchTime = New Global.System.Windows.Forms.RadioButton()
			Me.rdPurchAppClose = New Global.System.Windows.Forms.RadioButton()
			Me.txtPurchMobile = New Global.System.Windows.Forms.TextBox()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.groupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.txtPurchTime = New Global.System.Windows.Forms.DateTimePicker()
			Me.groupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.chkDefaultAcc = New Global.System.Windows.Forms.CheckBox()
			Me.pnlAcc = New Global.System.Windows.Forms.Panel()
			Me.txtSender = New Global.System.Windows.Forms.TextBox()
			Me.txtUsername = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.txtPWD = New Global.System.Windows.Forms.TextBox()
			Me.groupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.rdJawal = New Global.System.Windows.Forms.RadioButton()
			Me.rdMobily = New Global.System.Windows.Forms.RadioButton()
			Me.rdMsegat = New Global.System.Windows.Forms.RadioButton()
			Me.groupBox4.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.pnlAcc.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.chkActvSMS.AutoSize = True
			Me.chkActvSMS.Checked = True
			Me.chkActvSMS.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkActvSMS.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkActvSMS As Global.System.Windows.Forms.Control = Me.chkActvSMS
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(51, 6)
			chkActvSMS.Location = point
			Me.chkActvSMS.Name = "chkActvSMS"
			Dim chkActvSMS2 As Global.System.Windows.Forms.Control = Me.chkActvSMS
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(158, 17)
			chkActvSMS2.Size = size
			Me.chkActvSMS.TabIndex = 7
			Me.chkActvSMS.Text = "تفعيل رسائل SMS بالنظام"
			Me.chkActvSMS.UseVisualStyleBackColor = True
			Me.btnSave.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSave As Global.System.Windows.Forms.Control = Me.btnSave
			point = New Global.System.Drawing.Point(104, 470)
			btnSave.Location = point
			Me.btnSave.Name = "btnSave"
			Dim btnSave2 As Global.System.Windows.Forms.Control = Me.btnSave
			size = New Global.System.Drawing.Size(100, 34)
			btnSave2.Size = size
			Me.btnSave.TabIndex = 12
			Me.btnSave.Text = "حفظ"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.chkActvLoginSMS.AutoSize = True
			Me.chkActvLoginSMS.Checked = True
			Me.chkActvLoginSMS.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkActvLoginSMS.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkActvLoginSMS As Global.System.Windows.Forms.Control = Me.chkActvLoginSMS
			point = New Global.System.Drawing.Point(162, 16)
			chkActvLoginSMS.Location = point
			Me.chkActvLoginSMS.Name = "chkActvLoginSMS"
			Dim chkActvLoginSMS2 As Global.System.Windows.Forms.Control = Me.chkActvLoginSMS
			size = New Global.System.Drawing.Size(55, 17)
			chkActvLoginSMS2.Size = size
			Me.chkActvLoginSMS.TabIndex = 3
			Me.chkActvLoginSMS.Text = "تفعيل"
			Me.chkActvLoginSMS.UseVisualStyleBackColor = True
			Dim txtLoginMobile As Global.System.Windows.Forms.Control = Me.txtLoginMobile
			point = New Global.System.Drawing.Point(103, 39)
			txtLoginMobile.Location = point
			Me.txtLoginMobile.Name = "txtLoginMobile"
			Dim txtLoginMobile2 As Global.System.Windows.Forms.Control = Me.txtLoginMobile
			size = New Global.System.Drawing.Size(112, 20)
			txtLoginMobile2.Size = size
			Me.txtLoginMobile.TabIndex = 1
			Me.txtLoginMobile.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.label7.AutoSize = True
			Me.label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.label7
			point = New Global.System.Drawing.Point(221, 42)
			label.Location = point
			Me.label7.Name = "label7"
			Dim label2 As Global.System.Windows.Forms.Control = Me.label7
			size = New Global.System.Drawing.Size(63, 13)
			label2.Size = size
			Me.label7.TabIndex = 0
			Me.label7.Text = "رقم الجوال"
			Me.groupBox4.Controls.Add(Me.chkActvLoginSMS)
			Me.groupBox4.Controls.Add(Me.txtLoginMobile)
			Me.groupBox4.Controls.Add(Me.label7)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.groupBox4
			point = New Global.System.Drawing.Point(34, 393)
			groupBox.Location = point
			Me.groupBox4.Name = "groupBox4"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.groupBox4
			size = New Global.System.Drawing.Size(351, 68)
			groupBox2.Size = size
			Me.groupBox4.TabIndex = 11
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "إعدادات لوج ان الموظف"
			Me.label5.AutoSize = True
			Me.label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.label5
			point = New Global.System.Drawing.Point(224, 83)
			label3.Location = point
			Me.label5.Name = "label5"
			Dim label4 As Global.System.Windows.Forms.Control = Me.label5
			size = New Global.System.Drawing.Size(63, 13)
			label4.Size = size
			Me.label5.TabIndex = 0
			Me.label5.Text = "رقم الجوال"
			Me.label6.AutoSize = True
			Me.label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.label6
			point = New Global.System.Drawing.Point(263, 34)
			label5.Location = point
			Me.label6.Name = "label6"
			Dim label6 As Global.System.Windows.Forms.Control = Me.label6
			size = New Global.System.Drawing.Size(74, 13)
			label6.Size = size
			Me.label6.TabIndex = 0
			Me.label6.Text = "وقت الإرسال"
			Me.txtSaleTime.CustomFormat = "hh:mm tt"
			Me.txtSaleTime.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Dim txtSaleTime As Global.System.Windows.Forms.Control = Me.txtSaleTime
			point = New Global.System.Drawing.Point(6, 55)
			txtSaleTime.Location = point
			Me.txtSaleTime.Name = "txtSaleTime"
			Me.txtSaleTime.RightToLeftLayout = True
			Me.txtSaleTime.ShowUpDown = True
			Dim txtSaleTime2 As Global.System.Windows.Forms.Control = Me.txtSaleTime
			size = New Global.System.Drawing.Size(81, 20)
			txtSaleTime2.Size = size
			Me.txtSaleTime.TabIndex = 1
			Me.txtSaleTime.Visible = False
			Me.rdSaletime.AutoSize = True
			Me.rdSaletime.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdSaletime As Global.System.Windows.Forms.Control = Me.rdSaletime
			point = New Global.System.Drawing.Point(3, 32)
			rdSaletime.Location = point
			Me.rdSaletime.Name = "rdSaletime"
			Dim rdSaletime2 As Global.System.Windows.Forms.Control = Me.rdSaletime
			size = New Global.System.Drawing.Size(89, 17)
			rdSaletime2.Size = size
			Me.rdSaletime.TabIndex = 0
			Me.rdSaletime.Text = "توقيت يومي"
			Me.rdSaletime.UseVisualStyleBackColor = True
			Me.rdSaleAppClose.AutoSize = True
			Me.rdSaleAppClose.Checked = True
			Me.rdSaleAppClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdSaleAppClose As Global.System.Windows.Forms.Control = Me.rdSaleAppClose
			point = New Global.System.Drawing.Point(106, 32)
			rdSaleAppClose.Location = point
			Me.rdSaleAppClose.Name = "rdSaleAppClose"
			Dim rdSaleAppClose2 As Global.System.Windows.Forms.Control = Me.rdSaleAppClose
			size = New Global.System.Drawing.Size(145, 17)
			rdSaleAppClose2.Size = size
			Me.rdSaleAppClose.TabIndex = 0
			Me.rdSaleAppClose.TabStop = True
			Me.rdSaleAppClose.Text = "عند الخروج من البرنامج"
			Me.rdSaleAppClose.UseVisualStyleBackColor = True
			Dim txtSaleMobile As Global.System.Windows.Forms.Control = Me.txtSaleMobile
			point = New Global.System.Drawing.Point(106, 80)
			txtSaleMobile.Location = point
			Me.txtSaleMobile.Name = "txtSaleMobile"
			Dim txtSaleMobile2 As Global.System.Windows.Forms.Control = Me.txtSaleMobile
			size = New Global.System.Drawing.Size(112, 20)
			txtSaleMobile2.Size = size
			Me.txtSaleMobile.TabIndex = 1
			Me.txtSaleMobile.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.label4.AutoSize = True
			Me.label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.label4
			point = New Global.System.Drawing.Point(224, 83)
			label7.Location = point
			Me.label4.Name = "label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.label4
			size = New Global.System.Drawing.Size(63, 13)
			label8.Size = size
			Me.label4.TabIndex = 0
			Me.label4.Text = "رقم الجوال"
			Me.rdPurchTime.AutoSize = True
			Me.rdPurchTime.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdPurchTime As Global.System.Windows.Forms.Control = Me.rdPurchTime
			point = New Global.System.Drawing.Point(3, 32)
			rdPurchTime.Location = point
			Me.rdPurchTime.Name = "rdPurchTime"
			Dim rdPurchTime2 As Global.System.Windows.Forms.Control = Me.rdPurchTime
			size = New Global.System.Drawing.Size(89, 17)
			rdPurchTime2.Size = size
			Me.rdPurchTime.TabIndex = 0
			Me.rdPurchTime.Text = "توقيت يومي"
			Me.rdPurchTime.UseVisualStyleBackColor = True
			Me.rdPurchAppClose.AutoSize = True
			Me.rdPurchAppClose.Checked = True
			Me.rdPurchAppClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdPurchAppClose As Global.System.Windows.Forms.Control = Me.rdPurchAppClose
			point = New Global.System.Drawing.Point(106, 32)
			rdPurchAppClose.Location = point
			Me.rdPurchAppClose.Name = "rdPurchAppClose"
			Dim rdPurchAppClose2 As Global.System.Windows.Forms.Control = Me.rdPurchAppClose
			size = New Global.System.Drawing.Size(145, 17)
			rdPurchAppClose2.Size = size
			Me.rdPurchAppClose.TabIndex = 0
			Me.rdPurchAppClose.TabStop = True
			Me.rdPurchAppClose.Text = "عند الخروج من البرنامج"
			Me.rdPurchAppClose.UseVisualStyleBackColor = True
			Dim txtPurchMobile As Global.System.Windows.Forms.Control = Me.txtPurchMobile
			point = New Global.System.Drawing.Point(106, 80)
			txtPurchMobile.Location = point
			Me.txtPurchMobile.Name = "txtPurchMobile"
			Dim txtPurchMobile2 As Global.System.Windows.Forms.Control = Me.txtPurchMobile
			size = New Global.System.Drawing.Size(112, 20)
			txtPurchMobile2.Size = size
			Me.txtPurchMobile.TabIndex = 1
			Me.txtPurchMobile.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.label3.AutoSize = True
			Me.label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.label3
			point = New Global.System.Drawing.Point(263, 34)
			label9.Location = point
			Me.label3.Name = "label3"
			Dim label10 As Global.System.Windows.Forms.Control = Me.label3
			size = New Global.System.Drawing.Size(74, 13)
			label10.Size = size
			Me.label3.TabIndex = 0
			Me.label3.Text = "وقت الإرسال"
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(210, 470)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(75, 34)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 13
			Me.btnClose.Text = "غلق"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.groupBox3.Controls.Add(Me.txtPurchTime)
			Me.groupBox3.Controls.Add(Me.rdPurchTime)
			Me.groupBox3.Controls.Add(Me.rdPurchAppClose)
			Me.groupBox3.Controls.Add(Me.txtPurchMobile)
			Me.groupBox3.Controls.Add(Me.label5)
			Me.groupBox3.Controls.Add(Me.label6)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.groupBox3
			point = New Global.System.Drawing.Point(34, 279)
			groupBox3.Location = point
			Me.groupBox3.Name = "groupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.groupBox3
			size = New Global.System.Drawing.Size(351, 111)
			groupBox4.Size = size
			Me.groupBox3.TabIndex = 9
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "إعدادات رسالة المشتريات"
			Me.txtPurchTime.CustomFormat = "hh:mm tt"
			Me.txtPurchTime.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Dim txtPurchTime As Global.System.Windows.Forms.Control = Me.txtPurchTime
			point = New Global.System.Drawing.Point(6, 55)
			txtPurchTime.Location = point
			Me.txtPurchTime.Name = "txtPurchTime"
			Me.txtPurchTime.RightToLeftLayout = True
			Me.txtPurchTime.ShowUpDown = True
			Dim txtPurchTime2 As Global.System.Windows.Forms.Control = Me.txtPurchTime
			size = New Global.System.Drawing.Size(81, 20)
			txtPurchTime2.Size = size
			Me.txtPurchTime.TabIndex = 1
			Me.txtPurchTime.Visible = False
			Me.groupBox2.Controls.Add(Me.txtSaleTime)
			Me.groupBox2.Controls.Add(Me.rdSaletime)
			Me.groupBox2.Controls.Add(Me.rdSaleAppClose)
			Me.groupBox2.Controls.Add(Me.txtSaleMobile)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.groupBox2
			point = New Global.System.Drawing.Point(34, 162)
			groupBox5.Location = point
			Me.groupBox2.Name = "groupBox2"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.groupBox2
			size = New Global.System.Drawing.Size(351, 111)
			groupBox6.Size = size
			Me.groupBox2.TabIndex = 10
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "إعدادات رسالة المبيعات"
			Me.chkDefaultAcc.AutoSize = True
			Me.chkDefaultAcc.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkDefaultAcc As Global.System.Windows.Forms.Control = Me.chkDefaultAcc
			point = New Global.System.Drawing.Point(75, -27)
			chkDefaultAcc.Location = point
			Me.chkDefaultAcc.Name = "chkDefaultAcc"
			Dim chkDefaultAcc2 As Global.System.Windows.Forms.Control = Me.chkDefaultAcc
			size = New Global.System.Drawing.Size(81, 17)
			chkDefaultAcc2.Size = size
			Me.chkDefaultAcc.TabIndex = 3
			Me.chkDefaultAcc.Text = "الإفتراضي"
			Me.chkDefaultAcc.UseVisualStyleBackColor = True
			Me.chkDefaultAcc.Visible = False
			Me.pnlAcc.Controls.Add(Me.txtSender)
			Me.pnlAcc.Controls.Add(Me.txtUsername)
			Me.pnlAcc.Controls.Add(Me.Label8)
			Me.pnlAcc.Controls.Add(Me.label2)
			Me.pnlAcc.Controls.Add(Me.label1)
			Me.pnlAcc.Controls.Add(Me.txtPWD)
			Dim pnlAcc As Global.System.Windows.Forms.Control = Me.pnlAcc
			point = New Global.System.Drawing.Point(51, 36)
			pnlAcc.Location = point
			Me.pnlAcc.Name = "pnlAcc"
			Dim pnlAcc2 As Global.System.Windows.Forms.Control = Me.pnlAcc
			size = New Global.System.Drawing.Size(283, 84)
			pnlAcc2.Size = size
			Me.pnlAcc.TabIndex = 2
			Dim txtSender As Global.System.Windows.Forms.Control = Me.txtSender
			point = New Global.System.Drawing.Point(7, 57)
			txtSender.Location = point
			Me.txtSender.Name = "txtSender"
			Dim txtSender2 As Global.System.Windows.Forms.Control = Me.txtSender
			size = New Global.System.Drawing.Size(135, 20)
			txtSender2.Size = size
			Me.txtSender.TabIndex = 1
			Me.txtSender.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Dim txtUsername As Global.System.Windows.Forms.Control = Me.txtUsername
			point = New Global.System.Drawing.Point(7, 7)
			txtUsername.Location = point
			Me.txtUsername.Name = "txtUsername"
			Dim txtUsername2 As Global.System.Windows.Forms.Control = Me.txtUsername
			size = New Global.System.Drawing.Size(135, 20)
			txtUsername2.Size = size
			Me.txtUsername.TabIndex = 1
			Me.txtUsername.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label8.AutoSize = True
			Me.Label8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(148, 60)
			label11.Location = point
			Me.Label8.Name = "Label8"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(76, 13)
			label12.Size = size
			Me.Label8.TabIndex = 0
			Me.Label8.Text = "إسم المرسل"
			Me.label2.AutoSize = True
			Me.label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.label2
			point = New Global.System.Drawing.Point(143, 36)
			label13.Location = point
			Me.label2.Name = "label2"
			Dim label14 As Global.System.Windows.Forms.Control = Me.label2
			size = New Global.System.Drawing.Size(117, 13)
			label14.Size = size
			Me.label2.TabIndex = 0
			Me.label2.Text = "كلمة المرور (apiKey)"
			Me.label1.AutoSize = True
			Me.label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label15 As Global.System.Windows.Forms.Control = Me.label1
			point = New Global.System.Drawing.Point(148, 10)
			label15.Location = point
			Me.label1.Name = "label1"
			Dim label16 As Global.System.Windows.Forms.Control = Me.label1
			size = New Global.System.Drawing.Size(87, 13)
			label16.Size = size
			Me.label1.TabIndex = 0
			Me.label1.Text = "إسم المستخدم"
			Dim txtPWD As Global.System.Windows.Forms.Control = Me.txtPWD
			point = New Global.System.Drawing.Point(7, 33)
			txtPWD.Location = point
			Me.txtPWD.Name = "txtPWD"
			Dim txtPWD2 As Global.System.Windows.Forms.Control = Me.txtPWD
			size = New Global.System.Drawing.Size(135, 20)
			txtPWD2.Size = size
			Me.txtPWD.TabIndex = 1
			Me.txtPWD.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.groupBox1.Controls.Add(Me.rdMsegat)
			Me.groupBox1.Controls.Add(Me.chkDefaultAcc)
			Me.groupBox1.Controls.Add(Me.rdJawal)
			Me.groupBox1.Controls.Add(Me.pnlAcc)
			Me.groupBox1.Controls.Add(Me.rdMobily)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.groupBox1
			point = New Global.System.Drawing.Point(34, 30)
			groupBox7.Location = point
			Me.groupBox1.Name = "groupBox1"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.groupBox1
			size = New Global.System.Drawing.Size(351, 126)
			groupBox8.Size = size
			Me.groupBox1.TabIndex = 8
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "إعدادات الحساب"
			Me.rdJawal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdJawal.AutoSize = True
			Me.rdJawal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdJawal As Global.System.Windows.Forms.Control = Me.rdJawal
			point = New Global.System.Drawing.Point(116, 15)
			rdJawal.Location = point
			Me.rdJawal.Name = "rdJawal"
			Dim rdJawal2 As Global.System.Windows.Forms.Control = Me.rdJawal
			size = New Global.System.Drawing.Size(85, 17)
			rdJawal2.Size = size
			Me.rdJawal.TabIndex = 0
			Me.rdJawal.Text = "jawalbsms"
			Me.rdJawal.UseVisualStyleBackColor = True
			Me.rdMobily.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdMobily.AutoSize = True
			Me.rdMobily.Checked = True
			Me.rdMobily.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdMobily As Global.System.Windows.Forms.Control = Me.rdMobily
			point = New Global.System.Drawing.Point(219, 15)
			rdMobily.Location = point
			Me.rdMobily.Name = "rdMobily"
			Dim rdMobily2 As Global.System.Windows.Forms.Control = Me.rdMobily
			size = New Global.System.Drawing.Size(86, 17)
			rdMobily2.Size = size
			Me.rdMobily.TabIndex = 0
			Me.rdMobily.TabStop = True
			Me.rdMobily.Text = "mobilysms"
			Me.rdMobily.UseVisualStyleBackColor = True
			Me.rdMsegat.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdMsegat.AutoSize = True
			Me.rdMsegat.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim rdMsegat As Global.System.Windows.Forms.Control = Me.rdMsegat
			point = New Global.System.Drawing.Point(40, 15)
			rdMsegat.Location = point
			Me.rdMsegat.Name = "rdMsegat"
			Dim rdMsegat2 As Global.System.Windows.Forms.Control = Me.rdMsegat
			size = New Global.System.Drawing.Size(68, 17)
			rdMsegat2.Size = size
			Me.rdMsegat.TabIndex = 4
			Me.rdMsegat.Text = "msegat"
			Me.rdMsegat.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(404, 511)
			Me.ClientSize = size
			Me.Controls.Add(Me.chkActvSMS)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.groupBox4)
			Me.Controls.Add(Me.btnClose)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmSMSSett"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "إعدادات SMS"
			Me.groupBox4.ResumeLayout(False)
			Me.groupBox4.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.pnlAcc.ResumeLayout(False)
			Me.pnlAcc.PerformLayout()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
