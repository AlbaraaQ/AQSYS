Namespace UnitedSoftware.Forms
	Partial Public Class frmReservTawla
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer

		Private panel2 As Global.System.Windows.Forms.Panel

		Private panel1 As Global.System.Windows.Forms.Panel

		Friend label1 As Global.System.Windows.Forms.Label

		Friend Label11 As Global.System.Windows.Forms.Label

		Friend txtDate As Global.System.Windows.Forms.DateTimePicker

		Friend Label13 As Global.System.Windows.Forms.Label

		Friend txtNotes As Global.System.Windows.Forms.TextBox

		Friend label2 As Global.System.Windows.Forms.Label

		Private btnClose As Global.System.Windows.Forms.Button

		Public txtTawla As Global.System.Windows.Forms.TextBox

		Public txtGroup As Global.System.Windows.Forms.TextBox

		Public btnCancel As Global.System.Windows.Forms.Button

		Public btnReserv As Global.System.Windows.Forms.Button

		Public txtClientMobile As Global.System.Windows.Forms.TextBox

		Friend label4 As Global.System.Windows.Forms.Label

		Public txtClientName As Global.System.Windows.Forms.TextBox

		Friend label3 As Global.System.Windows.Forms.Label

		Private btnPrevious As Global.System.Windows.Forms.Button

		Private btnNext As Global.System.Windows.Forms.Button

		Public pnlNavigate As Global.System.Windows.Forms.Panel

		Protected Overrides Sub Dispose(disposing As Boolean)
			Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
			If flag Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnReserv = New Global.System.Windows.Forms.Button()
			Me.panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.txtTawla = New Global.System.Windows.Forms.TextBox()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.txtGroup = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.txtClientName = New Global.System.Windows.Forms.TextBox()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.txtClientMobile = New Global.System.Windows.Forms.TextBox()
			Me.pnlNavigate = New Global.System.Windows.Forms.Panel()
			Me.btnNext = New Global.System.Windows.Forms.Button()
			Me.btnPrevious = New Global.System.Windows.Forms.Button()
			Me.panel2.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.pnlNavigate.SuspendLayout()
			Me.SuspendLayout()
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.btnClose)
			Me.panel2.Controls.Add(Me.btnCancel)
			Me.panel2.Controls.Add(Me.btnReserv)
			Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim control As Global.System.Windows.Forms.Control = Me.panel2
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 299)
			control.Location = point
			Me.panel2.Name = "panel2"
			Dim control2 As Global.System.Windows.Forms.Control = Me.panel2
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(642, 46)
			control2.Size = size
			Me.panel2.TabIndex = 1
			Dim control3 As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(299, 3)
			control3.Location = point
			Me.btnClose.Name = "btnClose"
			Dim control4 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(108, 38)
			control4.Size = size
			Me.btnClose.TabIndex = 0
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			AddHandler Me.btnClose.Click, AddressOf Me.btnClose_Click
			Dim control5 As Global.System.Windows.Forms.Control = Me.btnCancel
			point = New Global.System.Drawing.Point(413, 3)
			control5.Location = point
			Me.btnCancel.Name = "btnCancel"
			Dim control6 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(108, 38)
			control6.Size = size
			Me.btnCancel.TabIndex = 0
			Me.btnCancel.Text = "إلغاء الحجز"
			Me.btnCancel.UseVisualStyleBackColor = True
			AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
			Dim control7 As Global.System.Windows.Forms.Control = Me.btnReserv
			point = New Global.System.Drawing.Point(527, 3)
			control7.Location = point
			Me.btnReserv.Name = "btnReserv"
			Dim control8 As Global.System.Windows.Forms.Control = Me.btnReserv
			size = New Global.System.Drawing.Size(108, 38)
			control8.Size = size
			Me.btnReserv.TabIndex = 0
			Me.btnReserv.Text = "حجز"
			Me.btnReserv.UseVisualStyleBackColor = True
			AddHandler Me.btnReserv.Click, AddressOf Me.btnReserv_Click
			Me.panel1.Controls.Add(Me.pnlNavigate)
			Me.panel1.Controls.Add(Me.txtDate)
			Me.panel1.Controls.Add(Me.Label13)
			Me.panel1.Controls.Add(Me.txtNotes)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.txtClientMobile)
			Me.panel1.Controls.Add(Me.txtTawla)
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.txtClientName)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.txtGroup)
			Me.panel1.Controls.Add(Me.Label11)
			Me.panel1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim control9 As Global.System.Windows.Forms.Control = Me.panel1
			point = New Global.System.Drawing.Point(0, 0)
			control9.Location = point
			Me.panel1.Name = "panel1"
			Dim control10 As Global.System.Windows.Forms.Control = Me.panel1
			size = New Global.System.Drawing.Size(642, 299)
			control10.Size = size
			Me.panel1.TabIndex = 2
			Me.txtDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDate.CustomFormat = "  dd/MM/yyyy   hh:mm tt"
			Me.txtDate.Font = New Global.System.Drawing.Font("Tahoma", 9.0F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Dim control11 As Global.System.Windows.Forms.Control = Me.txtDate
			point = New Global.System.Drawing.Point(236, 98)
			control11.Location = point
			Me.txtDate.Name = "txtDate"
			Me.txtDate.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.txtDate.RightToLeftLayout = True
			Dim control12 As Global.System.Windows.Forms.Control = Me.txtDate
			size = New Global.System.Drawing.Size(278, 22)
			control12.Size = size
			Me.txtDate.TabIndex = 2
			Me.Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12.0F)
			Me.Label13.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(519, 99)
			label.Location = point
			Me.Label13.Name = "Label13"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(73, 20)
			label2.Size = size
			Me.Label13.TabIndex = 53
			Me.Label13.Text = "تاريخ الحجز"
			Me.txtNotes.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNotes.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtNotes.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
			Dim control13 As Global.System.Windows.Forms.Control = Me.txtNotes
			point = New Global.System.Drawing.Point(80, 197)
			control13.Location = point
			Me.txtNotes.Multiline = True
			Me.txtNotes.Name = "txtNotes"
			Dim control14 As Global.System.Windows.Forms.Control = Me.txtNotes
			size = New Global.System.Drawing.Size(434, 59)
			control14.Size = size
			Me.txtNotes.TabIndex = 5
			Me.label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.label2.AutoSize = True
			Me.label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim control15 As Global.System.Windows.Forms.Control = Me.label2
			point = New Global.System.Drawing.Point(528, 201)
			control15.Location = point
			Me.label2.Name = "label2"
			Dim control16 As Global.System.Windows.Forms.Control = Me.label2
			size = New Global.System.Drawing.Size(53, 13)
			control16.Size = size
			Me.label2.TabIndex = 51
			Me.label2.Text = "ملاحظات"
			Me.txtTawla.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTawla.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTawla.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
			Dim control17 As Global.System.Windows.Forms.Control = Me.txtTawla
			point = New Global.System.Drawing.Point(236, 54)
			control17.Location = point
			Me.txtTawla.Name = "txtTawla"
			Me.txtTawla.[ReadOnly] = True
			Dim control18 As Global.System.Windows.Forms.Control = Me.txtTawla
			size = New Global.System.Drawing.Size(278, 27)
			control18.Size = size
			Me.txtTawla.TabIndex = 1
			Me.txtTawla.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.label1.AutoSize = True
			Me.label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim control19 As Global.System.Windows.Forms.Control = Me.label1
			point = New Global.System.Drawing.Point(528, 61)
			control19.Location = point
			Me.label1.Name = "label1"
			Dim control20 As Global.System.Windows.Forms.Control = Me.label1
			size = New Global.System.Drawing.Size(45, 13)
			control20.Size = size
			Me.label1.TabIndex = 51
			Me.label1.Text = "الطاولة"
			Me.txtGroup.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtGroup.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtGroup.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
			Dim control21 As Global.System.Windows.Forms.Control = Me.txtGroup
			point = New Global.System.Drawing.Point(236, 21)
			control21.Location = point
			Me.txtGroup.Name = "txtGroup"
			Me.txtGroup.[ReadOnly] = True
			Dim control22 As Global.System.Windows.Forms.Control = Me.txtGroup
			size = New Global.System.Drawing.Size(278, 27)
			control22.Size = size
			Me.txtGroup.TabIndex = 0
			Me.txtGroup.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label11.AutoSize = True
			Me.Label11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(521, 28)
			label3.Location = point
			Me.Label11.Name = "Label11"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(57, 13)
			label4.Size = size
			Me.Label11.TabIndex = 51
			Me.Label11.Text = "المجموعة"
			Me.label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.label3.AutoSize = True
			Me.label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim control23 As Global.System.Windows.Forms.Control = Me.label3
			point = New Global.System.Drawing.Point(521, 135)
			control23.Location = point
			Me.label3.Name = "label3"
			Dim control24 As Global.System.Windows.Forms.Control = Me.label3
			size = New Global.System.Drawing.Size(68, 13)
			control24.Size = size
			Me.label3.TabIndex = 51
			Me.label3.Text = "اسم العميل"
			Me.txtClientName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtClientName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtClientName.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
			Dim control25 As Global.System.Windows.Forms.Control = Me.txtClientName
			point = New Global.System.Drawing.Point(236, 128)
			control25.Location = point
			Me.txtClientName.Name = "txtClientName"
			Dim control26 As Global.System.Windows.Forms.Control = Me.txtClientName
			size = New Global.System.Drawing.Size(278, 27)
			control26.Size = size
			Me.txtClientName.TabIndex = 3
			Me.txtClientName.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.label4.AutoSize = True
			Me.label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim control27 As Global.System.Windows.Forms.Control = Me.label4
			point = New Global.System.Drawing.Point(528, 168)
			control27.Location = point
			Me.label4.Name = "label4"
			Dim control28 As Global.System.Windows.Forms.Control = Me.label4
			size = New Global.System.Drawing.Size(63, 13)
			control28.Size = size
			Me.label4.TabIndex = 51
			Me.label4.Text = "رقم الجوال"
			Me.txtClientMobile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtClientMobile.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtClientMobile.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
			Dim control29 As Global.System.Windows.Forms.Control = Me.txtClientMobile
			point = New Global.System.Drawing.Point(236, 161)
			control29.Location = point
			Me.txtClientMobile.Name = "txtClientMobile"
			Dim control30 As Global.System.Windows.Forms.Control = Me.txtClientMobile
			size = New Global.System.Drawing.Size(278, 27)
			control30.Size = size
			Me.txtClientMobile.TabIndex = 4
			Me.txtClientMobile.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.pnlNavigate.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlNavigate.Controls.Add(Me.btnPrevious)
			Me.pnlNavigate.Controls.Add(Me.btnNext)
			Dim control31 As Global.System.Windows.Forms.Control = Me.pnlNavigate
			point = New Global.System.Drawing.Point(217, 262)
			control31.Location = point
			Me.pnlNavigate.Name = "pnlNavigate"
			Dim control32 As Global.System.Windows.Forms.Control = Me.pnlNavigate
			size = New Global.System.Drawing.Size(200, 27)
			control32.Size = size
			Me.pnlNavigate.TabIndex = 54
			Me.pnlNavigate.Visible = False
			Dim control33 As Global.System.Windows.Forms.Control = Me.btnNext
			point = New Global.System.Drawing.Point(106, 1)
			control33.Location = point
			Me.btnNext.Name = "btnNext"
			Dim control34 As Global.System.Windows.Forms.Control = Me.btnNext
			size = New Global.System.Drawing.Size(75, 23)
			control34.Size = size
			Me.btnNext.TabIndex = 0
			Me.btnNext.Text = "<"
			Me.btnNext.UseVisualStyleBackColor = True
			AddHandler Me.btnNext.Click, AddressOf Me.btnNext_Click
			Dim control35 As Global.System.Windows.Forms.Control = Me.btnPrevious
			point = New Global.System.Drawing.Point(26, 2)
			control35.Location = point
			Me.btnPrevious.Name = "btnPrevious"
			Dim control36 As Global.System.Windows.Forms.Control = Me.btnPrevious
			size = New Global.System.Drawing.Size(75, 23)
			control36.Size = size
			Me.btnPrevious.TabIndex = 0
			Me.btnPrevious.Text = ">"
			Me.btnPrevious.UseVisualStyleBackColor = True
			AddHandler Me.btnPrevious.Click, AddressOf Me.btnPrevious_Click
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7.0F, 13.0F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(642, 345)
			Me.ClientSize = size
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panel2)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8.0F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmReservTawla"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "حجز طاولة"
			Me.panel2.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.pnlNavigate.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace
