Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmChargeData
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblCustLoc As Label
    Friend WithEvents lblCustLocAdd As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents lblSaleOrderNo As Label
    Friend WithEvents txtRecCar As TextBox
    Friend WithEvents txtRecCarNo As TextBox
    Friend WithEvents txtRecChargeAcc As TextBox
    Friend WithEvents txtRecChargeTime As TextBox
    Friend WithEvents txtRecChargeType As TextBox
    Friend WithEvents txtRecCustLoc As TextBox
    Friend WithEvents txtRecCustLocAddress As TextBox
    Friend WithEvents txtRecCustVatNo As TextBox
    Friend WithEvents txtRecDate As DateTimePicker
    Friend WithEvents txtRecDriver As TextBox
    Friend WithEvents txtRecNo As TextBox
    Friend WithEvents txtRecPurchOrderNo As TextBox
    Friend WithEvents txtRecRespTel As TextBox
    Friend WithEvents txtRecSaleOrderNo As TextBox

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
			Me.GroupBox10 = New Global.System.Windows.Forms.GroupBox()
			Me.txtRecCustVatNo = New Global.System.Windows.Forms.TextBox()
			Me.txtRecRespTel = New Global.System.Windows.Forms.TextBox()
			Me.txtRecPurchOrderNo = New Global.System.Windows.Forms.TextBox()
			Me.txtRecCustLocAddress = New Global.System.Windows.Forms.TextBox()
			Me.txtRecCustLoc = New Global.System.Windows.Forms.TextBox()
			Me.txtRecChargeType = New Global.System.Windows.Forms.TextBox()
			Me.lblCustLocAdd = New Global.System.Windows.Forms.Label()
			Me.txtRecSaleOrderNo = New Global.System.Windows.Forms.TextBox()
			Me.lblCustLoc = New Global.System.Windows.Forms.Label()
			Me.txtRecNo = New Global.System.Windows.Forms.TextBox()
			Me.Label59 = New Global.System.Windows.Forms.Label()
			Me.Label63 = New Global.System.Windows.Forms.Label()
			Me.Label62 = New Global.System.Windows.Forms.Label()
			Me.lblOrderNo = New Global.System.Windows.Forms.Label()
			Me.lblSaleOrderNo = New Global.System.Windows.Forms.Label()
			Me.Label55 = New Global.System.Windows.Forms.Label()
			Me.lblNo = New Global.System.Windows.Forms.Label()
			Me.Label56 = New Global.System.Windows.Forms.Label()
			Me.txtRecDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtRecDriver = New Global.System.Windows.Forms.TextBox()
			Me.txtRecCarNo = New Global.System.Windows.Forms.TextBox()
			Me.txtRecChargeAcc = New Global.System.Windows.Forms.TextBox()
			Me.txtRecChargeTime = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtRecCar = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.btnOk = New Global.System.Windows.Forms.Button()
			Me.GroupBox10.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox10.Controls.Add(Me.txtRecCustVatNo)
			Me.GroupBox10.Controls.Add(Me.txtRecRespTel)
			Me.GroupBox10.Controls.Add(Me.txtRecPurchOrderNo)
			Me.GroupBox10.Controls.Add(Me.txtRecCustLocAddress)
			Me.GroupBox10.Controls.Add(Me.txtRecCustLoc)
			Me.GroupBox10.Controls.Add(Me.txtRecChargeType)
			Me.GroupBox10.Controls.Add(Me.lblCustLocAdd)
			Me.GroupBox10.Controls.Add(Me.txtRecSaleOrderNo)
			Me.GroupBox10.Controls.Add(Me.lblCustLoc)
			Me.GroupBox10.Controls.Add(Me.txtRecNo)
			Me.GroupBox10.Controls.Add(Me.Label59)
			Me.GroupBox10.Controls.Add(Me.Label63)
			Me.GroupBox10.Controls.Add(Me.Label62)
			Me.GroupBox10.Controls.Add(Me.lblOrderNo)
			Me.GroupBox10.Controls.Add(Me.lblSaleOrderNo)
			Me.GroupBox10.Controls.Add(Me.Label55)
			Me.GroupBox10.Controls.Add(Me.lblNo)
			Me.GroupBox10.Controls.Add(Me.Label56)
			Me.GroupBox10.Controls.Add(Me.txtRecDate)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox10
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(12, 12)
			groupBox.Location = point
			Me.GroupBox10.Name = "GroupBox10"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox10
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(429, 169)
			groupBox2.Size = size
			Me.GroupBox10.TabIndex = 211
			Me.GroupBox10.TabStop = False
			Me.txtRecCustVatNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecCustVatNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecCustVatNo As Global.System.Windows.Forms.Control = Me.txtRecCustVatNo
			point = New Global.System.Drawing.Point(6, 134)
			txtRecCustVatNo.Location = point
			Me.txtRecCustVatNo.MaxLength = 50
			Me.txtRecCustVatNo.Name = "txtRecCustVatNo"
			Dim txtRecCustVatNo2 As Global.System.Windows.Forms.Control = Me.txtRecCustVatNo
			size = New Global.System.Drawing.Size(144, 22)
			txtRecCustVatNo2.Size = size
			Me.txtRecCustVatNo.TabIndex = 8
			Me.txtRecCustVatNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecRespTel.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecRespTel.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecRespTel As Global.System.Windows.Forms.Control = Me.txtRecRespTel
			point = New Global.System.Drawing.Point(235, 134)
			txtRecRespTel.Location = point
			Me.txtRecRespTel.MaxLength = 50
			Me.txtRecRespTel.Name = "txtRecRespTel"
			Dim txtRecRespTel2 As Global.System.Windows.Forms.Control = Me.txtRecRespTel
			size = New Global.System.Drawing.Size(112, 22)
			txtRecRespTel2.Size = size
			Me.txtRecRespTel.TabIndex = 7
			Me.txtRecRespTel.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecPurchOrderNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecPurchOrderNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecPurchOrderNo As Global.System.Windows.Forms.Control = Me.txtRecPurchOrderNo
			point = New Global.System.Drawing.Point(245, 50)
			txtRecPurchOrderNo.Location = point
			Me.txtRecPurchOrderNo.MaxLength = 50
			Me.txtRecPurchOrderNo.Name = "txtRecPurchOrderNo"
			Dim txtRecPurchOrderNo2 As Global.System.Windows.Forms.Control = Me.txtRecPurchOrderNo
			size = New Global.System.Drawing.Size(93, 22)
			txtRecPurchOrderNo2.Size = size
			Me.txtRecPurchOrderNo.TabIndex = 2
			Me.txtRecPurchOrderNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecCustLocAddress.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecCustLocAddress.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecCustLocAddress As Global.System.Windows.Forms.Control = Me.txtRecCustLocAddress
			point = New Global.System.Drawing.Point(4, 107)
			txtRecCustLocAddress.Location = point
			Me.txtRecCustLocAddress.MaxLength = 50
			Me.txtRecCustLocAddress.Name = "txtRecCustLocAddress"
			Dim txtRecCustLocAddress2 As Global.System.Windows.Forms.Control = Me.txtRecCustLocAddress
			size = New Global.System.Drawing.Size(322, 22)
			txtRecCustLocAddress2.Size = size
			Me.txtRecCustLocAddress.TabIndex = 6
			Me.txtRecCustLocAddress.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecCustLoc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecCustLoc.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecCustLoc As Global.System.Windows.Forms.Control = Me.txtRecCustLoc
			point = New Global.System.Drawing.Point(4, 79)
			txtRecCustLoc.Location = point
			Me.txtRecCustLoc.MaxLength = 50
			Me.txtRecCustLoc.Name = "txtRecCustLoc"
			Dim txtRecCustLoc2 As Global.System.Windows.Forms.Control = Me.txtRecCustLoc
			size = New Global.System.Drawing.Size(160, 22)
			txtRecCustLoc2.Size = size
			Me.txtRecCustLoc.TabIndex = 5
			Me.txtRecCustLoc.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecChargeType.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecChargeType.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecChargeType As Global.System.Windows.Forms.Control = Me.txtRecChargeType
			point = New Global.System.Drawing.Point(245, 78)
			txtRecChargeType.Location = point
			Me.txtRecChargeType.MaxLength = 50
			Me.txtRecChargeType.Name = "txtRecChargeType"
			Dim txtRecChargeType2 As Global.System.Windows.Forms.Control = Me.txtRecChargeType
			size = New Global.System.Drawing.Size(93, 22)
			txtRecChargeType2.Size = size
			Me.txtRecChargeType.TabIndex = 4
			Me.txtRecChargeType.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblCustLocAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblCustLocAdd.AutoSize = True
			Me.lblCustLocAdd.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCustLocAdd.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCustLocAdd As Global.System.Windows.Forms.Control = Me.lblCustLocAdd
			point = New Global.System.Drawing.Point(329, 110)
			lblCustLocAdd.Location = point
			Me.lblCustLocAdd.Name = "lblCustLocAdd"
			Dim lblCustLocAdd2 As Global.System.Windows.Forms.Control = Me.lblCustLocAdd
			size = New Global.System.Drawing.Size(95, 16)
			lblCustLocAdd2.Size = size
			Me.lblCustLocAdd.TabIndex = 207
			Me.lblCustLocAdd.Text = "عنوان موقع العميل"
			Me.txtRecSaleOrderNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecSaleOrderNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecSaleOrderNo As Global.System.Windows.Forms.Control = Me.txtRecSaleOrderNo
			point = New Global.System.Drawing.Point(4, 51)
			txtRecSaleOrderNo.Location = point
			Me.txtRecSaleOrderNo.MaxLength = 50
			Me.txtRecSaleOrderNo.Name = "txtRecSaleOrderNo"
			Dim txtRecSaleOrderNo2 As Global.System.Windows.Forms.Control = Me.txtRecSaleOrderNo
			size = New Global.System.Drawing.Size(132, 22)
			txtRecSaleOrderNo2.Size = size
			Me.txtRecSaleOrderNo.TabIndex = 3
			Me.txtRecSaleOrderNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblCustLoc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblCustLoc.AutoSize = True
			Me.lblCustLoc.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCustLoc.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblCustLoc As Global.System.Windows.Forms.Control = Me.lblCustLoc
			point = New Global.System.Drawing.Point(171, 82)
			lblCustLoc.Location = point
			Me.lblCustLoc.Name = "lblCustLoc"
			Dim lblCustLoc2 As Global.System.Windows.Forms.Control = Me.lblCustLoc
			size = New Global.System.Drawing.Size(62, 16)
			lblCustLoc2.Size = size
			Me.lblCustLoc.TabIndex = 207
			Me.lblCustLoc.Text = "موقع العميل"
			Me.txtRecNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecNo As Global.System.Windows.Forms.Control = Me.txtRecNo
			point = New Global.System.Drawing.Point(245, 22)
			txtRecNo.Location = point
			Me.txtRecNo.MaxLength = 50
			Me.txtRecNo.Name = "txtRecNo"
			Dim txtRecNo2 As Global.System.Windows.Forms.Control = Me.txtRecNo
			size = New Global.System.Drawing.Size(93, 22)
			txtRecNo2.Size = size
			Me.txtRecNo.TabIndex = 0
			Me.txtRecNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label59.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label59.AutoSize = True
			Me.Label59.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label59.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label59
			point = New Global.System.Drawing.Point(349, 81)
			label.Location = point
			Me.Label59.Name = "Label59"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label59
			size = New Global.System.Drawing.Size(60, 16)
			label2.Size = size
			Me.Label59.TabIndex = 207
			Me.Label59.Text = "نوع الشحن"
			Me.Label63.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label63.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label63.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label63
			point = New Global.System.Drawing.Point(146, 129)
			label3.Location = point
			Me.Label63.Name = "Label63"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label63
			size = New Global.System.Drawing.Size(83, 34)
			label4.Size = size
			Me.Label63.TabIndex = 207
			Me.Label63.Text = "رقم ضريبة القيمة المضافة"
			Me.Label62.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label62.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label62.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label62
			point = New Global.System.Drawing.Point(349, 129)
			label5.Location = point
			Me.Label62.Name = "Label62"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label62
			size = New Global.System.Drawing.Size(69, 34)
			label6.Size = size
			Me.Label62.TabIndex = 207
			Me.Label62.Text = "هاتف مسئول التواصل"
			Me.lblOrderNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblOrderNo.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblOrderNo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblOrderNo As Global.System.Windows.Forms.Control = Me.lblOrderNo
			point = New Global.System.Drawing.Point(338, 45)
			lblOrderNo.Location = point
			Me.lblOrderNo.Name = "lblOrderNo"
			Dim lblOrderNo2 As Global.System.Windows.Forms.Control = Me.lblOrderNo
			size = New Global.System.Drawing.Size(80, 34)
			lblOrderNo2.Size = size
			Me.lblOrderNo.TabIndex = 207
			Me.lblOrderNo.Text = "رقم أمر شراء العميل"
			Me.lblSaleOrderNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblSaleOrderNo.AutoSize = True
			Me.lblSaleOrderNo.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblSaleOrderNo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSaleOrderNo As Global.System.Windows.Forms.Control = Me.lblSaleOrderNo
			point = New Global.System.Drawing.Point(140, 54)
			lblSaleOrderNo.Location = point
			Me.lblSaleOrderNo.Name = "lblSaleOrderNo"
			Dim lblSaleOrderNo2 As Global.System.Windows.Forms.Control = Me.lblSaleOrderNo
			size = New Global.System.Drawing.Size(67, 16)
			lblSaleOrderNo2.Size = size
			Me.lblSaleOrderNo.TabIndex = 207
			Me.lblSaleOrderNo.Text = "رقم أمر البيع"
			Me.Label55.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label55.AutoSize = True
			Me.Label55.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label55.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label55
			point = New Global.System.Drawing.Point(170, 25)
			label7.Location = point
			Me.Label55.Name = "Label55"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label55
			size = New Global.System.Drawing.Size(39, 16)
			label8.Size = size
			Me.Label55.TabIndex = 207
			Me.Label55.Text = "التاريخ"
			Me.lblNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblNo.AutoSize = True
			Me.lblNo.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.lblNo.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblNo As Global.System.Windows.Forms.Control = Me.lblNo
			point = New Global.System.Drawing.Point(340, 24)
			lblNo.Location = point
			Me.lblNo.Name = "lblNo"
			Dim lblNo2 As Global.System.Windows.Forms.Control = Me.lblNo
			size = New Global.System.Drawing.Size(80, 16)
			lblNo2.Size = size
			Me.lblNo.TabIndex = 207
			Me.lblNo.Text = "رقم سند التسليم"
			Me.Label56.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label56.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.Label56.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label56
			point = New Global.System.Drawing.Point(1289, 38)
			label9.Location = point
			Me.Label56.Name = "Label56"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label56
			size = New Global.System.Drawing.Size(53, 22)
			label10.Size = size
			Me.Label56.TabIndex = 204
			Me.Label56.Text = "رقم الجوال"
			Me.Label56.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtRecDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecDate.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.txtRecDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtRecDate As Global.System.Windows.Forms.Control = Me.txtRecDate
			point = New Global.System.Drawing.Point(5, 22)
			txtRecDate.Location = point
			Me.txtRecDate.Name = "txtRecDate"
			Dim txtRecDate2 As Global.System.Windows.Forms.Control = Me.txtRecDate
			size = New Global.System.Drawing.Size(157, 22)
			txtRecDate2.Size = size
			Me.txtRecDate.TabIndex = 1
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox1.Controls.Add(Me.txtRecDriver)
			Me.GroupBox1.Controls.Add(Me.txtRecCarNo)
			Me.GroupBox1.Controls.Add(Me.txtRecChargeAcc)
			Me.GroupBox1.Controls.Add(Me.txtRecChargeTime)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtRecCar)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.Label10)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(11, 187)
			groupBox3.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(430, 169)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 212
			Me.GroupBox1.TabStop = False
			Me.txtRecDriver.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecDriver.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecDriver As Global.System.Windows.Forms.Control = Me.txtRecDriver
			point = New Global.System.Drawing.Point(161, 134)
			txtRecDriver.Location = point
			Me.txtRecDriver.MaxLength = 50
			Me.txtRecDriver.Name = "txtRecDriver"
			Dim txtRecDriver2 As Global.System.Windows.Forms.Control = Me.txtRecDriver
			size = New Global.System.Drawing.Size(171, 22)
			txtRecDriver2.Size = size
			Me.txtRecDriver.TabIndex = 4
			Me.txtRecDriver.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecCarNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecCarNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecCarNo As Global.System.Windows.Forms.Control = Me.txtRecCarNo
			point = New Global.System.Drawing.Point(161, 50)
			txtRecCarNo.Location = point
			Me.txtRecCarNo.MaxLength = 50
			Me.txtRecCarNo.Name = "txtRecCarNo"
			Dim txtRecCarNo2 As Global.System.Windows.Forms.Control = Me.txtRecCarNo
			size = New Global.System.Drawing.Size(171, 22)
			txtRecCarNo2.Size = size
			Me.txtRecCarNo.TabIndex = 1
			Me.txtRecCarNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecChargeAcc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecChargeAcc.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecChargeAcc As Global.System.Windows.Forms.Control = Me.txtRecChargeAcc
			point = New Global.System.Drawing.Point(161, 107)
			txtRecChargeAcc.Location = point
			Me.txtRecChargeAcc.MaxLength = 50
			Me.txtRecChargeAcc.Name = "txtRecChargeAcc"
			Dim txtRecChargeAcc2 As Global.System.Windows.Forms.Control = Me.txtRecChargeAcc
			size = New Global.System.Drawing.Size(171, 22)
			txtRecChargeAcc2.Size = size
			Me.txtRecChargeAcc.TabIndex = 3
			Me.txtRecChargeAcc.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtRecChargeTime.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecChargeTime.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecChargeTime As Global.System.Windows.Forms.Control = Me.txtRecChargeTime
			point = New Global.System.Drawing.Point(161, 78)
			txtRecChargeTime.Location = point
			Me.txtRecChargeTime.MaxLength = 50
			Me.txtRecChargeTime.Name = "txtRecChargeTime"
			Dim txtRecChargeTime2 As Global.System.Windows.Forms.Control = Me.txtRecChargeTime
			size = New Global.System.Drawing.Size(171, 22)
			txtRecChargeTime2.Size = size
			Me.txtRecChargeTime.TabIndex = 2
			Me.txtRecChargeTime.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(333, 110)
			label11.Location = point
			Me.Label1.Name = "Label1"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(93, 16)
			label12.Size = size
			Me.Label1.TabIndex = 207
			Me.Label1.Text = "الشحن على حساب"
			Me.txtRecCar.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRecCar.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRecCar As Global.System.Windows.Forms.Control = Me.txtRecCar
			point = New Global.System.Drawing.Point(161, 22)
			txtRecCar.Location = point
			Me.txtRecCar.MaxLength = 50
			Me.txtRecCar.Name = "txtRecCar"
			Dim txtRecCar2 As Global.System.Windows.Forms.Control = Me.txtRecCar
			size = New Global.System.Drawing.Size(171, 22)
			txtRecCar2.Size = size
			Me.txtRecCar.TabIndex = 0
			Me.txtRecCar.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(356, 81)
			label13.Location = point
			Me.Label3.Name = "Label3"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(62, 16)
			label14.Size = size
			Me.Label3.TabIndex = 207
			Me.Label3.Text = "زمن الشحن"
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(351, 134)
			label15.Location = point
			Me.Label5.Name = "Label5"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(69, 22)
			label16.Size = size
			Me.Label5.TabIndex = 207
			Me.Label5.Text = "إسم السائق"
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(352, 50)
			label17.Location = point
			Me.Label6.Name = "Label6"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(67, 24)
			label18.Size = size
			Me.Label6.TabIndex = 207
			Me.Label6.Text = "رقم الشاحنة"
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(370, 24)
			label19.Location = point
			Me.Label9.Name = "Label9"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(31, 16)
			label20.Size = size
			Me.Label9.TabIndex = 207
			Me.Label9.Text = "الناقل"
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(1290, 38)
			label21.Location = point
			Me.Label10.Name = "Label10"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(53, 22)
			label22.Size = size
			Me.Label10.TabIndex = 204
			Me.Label10.Text = "رقم الجوال"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.btnOk.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnOk.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnOk As Global.System.Windows.Forms.Control = Me.btnOk
			point = New Global.System.Drawing.Point(127, 363)
			btnOk.Location = point
			Me.btnOk.Name = "btnOk"
			Dim btnOk2 As Global.System.Windows.Forms.Control = Me.btnOk
			size = New Global.System.Drawing.Size(139, 40)
			btnOk2.Size = size
			Me.btnOk.TabIndex = 0
			Me.btnOk.Text = "موافق"
			Me.btnOk.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(454, 419)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.GroupBox10)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmChargeData"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "معلومات سند تسليم البضاعة"
			Me.GroupBox10.ResumeLayout(False)
			Me.GroupBox10.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
