Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmTaxRptPeriod
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtNetPurchTax As Label
    Friend WithEvents txtNetSaleTax As Label
    Friend WithEvents txtNetTax As Label
    Friend WithEvents txtPurchRetTax As Label
    Friend WithEvents txtPurchRetVal As Label
    Friend WithEvents txtPurchTax As Label
    Friend WithEvents txtPurchTaxNet As Label
    Friend WithEvents txtPurchVal As Label
    Friend WithEvents txtSaleRetTax As Label
    Friend WithEvents txtSaleRetVal As Label
    Friend WithEvents txtSaleTax As Label
    Friend WithEvents txtSaleTaxNet As Label
    Friend WithEvents txtSaleVal As Label

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
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.txtNetTax = New Global.System.Windows.Forms.Label()
			Me.txtPurchTaxNet = New Global.System.Windows.Forms.Label()
			Me.txtSaleTaxNet = New Global.System.Windows.Forms.Label()
			Me.Label34 = New Global.System.Windows.Forms.Label()
			Me.Label23 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtPurchRetTax = New Global.System.Windows.Forms.Label()
			Me.txtSaleRetTax = New Global.System.Windows.Forms.Label()
			Me.txtPurchTax = New Global.System.Windows.Forms.Label()
			Me.txtSaleTax = New Global.System.Windows.Forms.Label()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtNetPurchTax = New Global.System.Windows.Forms.Label()
			Me.txtPurchRetVal = New Global.System.Windows.Forms.Label()
			Me.txtSaleRetVal = New Global.System.Windows.Forms.Label()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtNetSaleTax = New Global.System.Windows.Forms.Label()
			Me.txtPurchVal = New Global.System.Windows.Forms.Label()
			Me.txtSaleVal = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label26 = New Global.System.Windows.Forms.Label()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label25 = New Global.System.Windows.Forms.Label()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.btnPreview)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Controls.Add(Me.btnPrint)
			Me.Panel1.Controls.Add(Me.btnShow)
			Me.Panel1.Controls.Add(Me.txtDateTo)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtDateFrom)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(836, 76)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(237, 22)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(92, 33)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 13
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(41, 22)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(92, 33)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 15
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(139, 22)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(92, 33)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 14
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(335, 22)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(92, 33)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 12
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(449, 29)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(133, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 11
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(585, 32)
			label.Location = point
			Me.Label3.Name = "Label3"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(51, 13)
			label2.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "الى تاريخ"
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(644, 29)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(133, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 10
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(781, 32)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(47, 13)
			label4.Size = size
			Me.Label2.TabIndex = 9
			Me.Label2.Text = "من تاريخ"
			Me.Panel2.Controls.Add(Me.txtNetTax)
			Me.Panel2.Controls.Add(Me.txtPurchTaxNet)
			Me.Panel2.Controls.Add(Me.txtSaleTaxNet)
			Me.Panel2.Controls.Add(Me.Label34)
			Me.Panel2.Controls.Add(Me.Label23)
			Me.Panel2.Controls.Add(Me.Label8)
			Me.Panel2.Controls.Add(Me.txtPurchRetTax)
			Me.Panel2.Controls.Add(Me.txtSaleRetTax)
			Me.Panel2.Controls.Add(Me.txtPurchTax)
			Me.Panel2.Controls.Add(Me.txtSaleTax)
			Me.Panel2.Controls.Add(Me.Label20)
			Me.Panel2.Controls.Add(Me.Label7)
			Me.Panel2.Controls.Add(Me.txtNetPurchTax)
			Me.Panel2.Controls.Add(Me.txtPurchRetVal)
			Me.Panel2.Controls.Add(Me.txtSaleRetVal)
			Me.Panel2.Controls.Add(Me.Label18)
			Me.Panel2.Controls.Add(Me.Label6)
			Me.Panel2.Controls.Add(Me.txtNetSaleTax)
			Me.Panel2.Controls.Add(Me.txtPurchVal)
			Me.Panel2.Controls.Add(Me.txtSaleVal)
			Me.Panel2.Controls.Add(Me.Label27)
			Me.Panel2.Controls.Add(Me.Label16)
			Me.Panel2.Controls.Add(Me.Label5)
			Me.Panel2.Controls.Add(Me.Label26)
			Me.Panel2.Controls.Add(Me.Label15)
			Me.Panel2.Controls.Add(Me.Label4)
			Me.Panel2.Controls.Add(Me.Label25)
			Me.Panel2.Controls.Add(Me.Label14)
			Me.Panel2.Controls.Add(Me.Label1)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 76)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(836, 364)
			panel4.Size = size
			Me.Panel2.TabIndex = 1
			Me.txtNetTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNetTax.BackColor = Global.System.Drawing.Color.DarkGray
			Me.txtNetTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtNetTax As Global.System.Windows.Forms.Control = Me.txtNetTax
			point = New Global.System.Drawing.Point(159, 308)
			txtNetTax.Location = point
			Me.txtNetTax.Name = "txtNetTax"
			Dim txtNetTax2 As Global.System.Windows.Forms.Control = Me.txtNetTax
			size = New Global.System.Drawing.Size(182, 29)
			txtNetTax2.Size = size
			Me.txtNetTax.TabIndex = 9
			Me.txtNetTax.Text = " "
			Me.txtNetTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtPurchTaxNet.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPurchTaxNet.BackColor = Global.System.Drawing.Color.Silver
			Me.txtPurchTaxNet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtPurchTaxNet As Global.System.Windows.Forms.Control = Me.txtPurchTaxNet
			point = New Global.System.Drawing.Point(159, 197)
			txtPurchTaxNet.Location = point
			Me.txtPurchTaxNet.Name = "txtPurchTaxNet"
			Dim txtPurchTaxNet2 As Global.System.Windows.Forms.Control = Me.txtPurchTaxNet
			size = New Global.System.Drawing.Size(104, 29)
			txtPurchTaxNet2.Size = size
			Me.txtPurchTaxNet.TabIndex = 9
			Me.txtPurchTaxNet.Text = " "
			Me.txtPurchTaxNet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSaleTaxNet.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSaleTaxNet.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtSaleTaxNet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSaleTaxNet As Global.System.Windows.Forms.Control = Me.txtSaleTaxNet
			point = New Global.System.Drawing.Point(159, 79)
			txtSaleTaxNet.Location = point
			Me.txtSaleTaxNet.Name = "txtSaleTaxNet"
			Dim txtSaleTaxNet2 As Global.System.Windows.Forms.Control = Me.txtSaleTaxNet
			size = New Global.System.Drawing.Size(104, 29)
			txtSaleTaxNet2.Size = size
			Me.txtSaleTaxNet.TabIndex = 9
			Me.txtSaleTaxNet.Text = " "
			Me.txtSaleTaxNet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label34.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label34.BackColor = Global.System.Drawing.Color.DarkGray
			Me.Label34.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label34
			point = New Global.System.Drawing.Point(159, 277)
			label5.Location = point
			Me.Label34.Name = "Label34"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label34
			size = New Global.System.Drawing.Size(182, 29)
			label6.Size = size
			Me.Label34.TabIndex = 9
			Me.Label34.Text = "الضريبة المستحقة"
			Me.Label34.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label23.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label23.BackColor = Global.System.Drawing.Color.Silver
			Me.Label23.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label23
			point = New Global.System.Drawing.Point(159, 166)
			label7.Location = point
			Me.Label23.Name = "Label23"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label23
			size = New Global.System.Drawing.Size(104, 29)
			label8.Size = size
			Me.Label23.TabIndex = 9
			Me.Label23.Text = "الضريبة المستحقة"
			Me.Label23.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(159, 48)
			label9.Location = point
			Me.Label8.Name = "Label8"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(104, 29)
			label10.Size = size
			Me.Label8.TabIndex = 9
			Me.Label8.Text = "الضريبة المستحقة"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtPurchRetTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPurchRetTax.BackColor = Global.System.Drawing.Color.Silver
			Me.txtPurchRetTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtPurchRetTax As Global.System.Windows.Forms.Control = Me.txtPurchRetTax
			point = New Global.System.Drawing.Point(265, 197)
			txtPurchRetTax.Location = point
			Me.txtPurchRetTax.Name = "txtPurchRetTax"
			Dim txtPurchRetTax2 As Global.System.Windows.Forms.Control = Me.txtPurchRetTax
			size = New Global.System.Drawing.Size(104, 29)
			txtPurchRetTax2.Size = size
			Me.txtPurchRetTax.TabIndex = 9
			Me.txtPurchRetTax.Text = " "
			Me.txtPurchRetTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSaleRetTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSaleRetTax.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtSaleRetTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSaleRetTax As Global.System.Windows.Forms.Control = Me.txtSaleRetTax
			point = New Global.System.Drawing.Point(265, 79)
			txtSaleRetTax.Location = point
			Me.txtSaleRetTax.Name = "txtSaleRetTax"
			Dim txtSaleRetTax2 As Global.System.Windows.Forms.Control = Me.txtSaleRetTax
			size = New Global.System.Drawing.Size(104, 29)
			txtSaleRetTax2.Size = size
			Me.txtSaleRetTax.TabIndex = 9
			Me.txtSaleRetTax.Text = " "
			Me.txtSaleRetTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtPurchTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPurchTax.BackColor = Global.System.Drawing.Color.Silver
			Me.txtPurchTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtPurchTax As Global.System.Windows.Forms.Control = Me.txtPurchTax
			point = New Global.System.Drawing.Point(373, 197)
			txtPurchTax.Location = point
			Me.txtPurchTax.Name = "txtPurchTax"
			Dim txtPurchTax2 As Global.System.Windows.Forms.Control = Me.txtPurchTax
			size = New Global.System.Drawing.Size(104, 29)
			txtPurchTax2.Size = size
			Me.txtPurchTax.TabIndex = 9
			Me.txtPurchTax.Text = " "
			Me.txtPurchTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSaleTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSaleTax.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtSaleTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSaleTax As Global.System.Windows.Forms.Control = Me.txtSaleTax
			point = New Global.System.Drawing.Point(373, 79)
			txtSaleTax.Location = point
			Me.txtSaleTax.Name = "txtSaleTax"
			Dim txtSaleTax2 As Global.System.Windows.Forms.Control = Me.txtSaleTax
			size = New Global.System.Drawing.Size(104, 29)
			txtSaleTax2.Size = size
			Me.txtSaleTax.TabIndex = 9
			Me.txtSaleTax.Text = " "
			Me.txtSaleTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label20.BackColor = Global.System.Drawing.Color.Silver
			Me.Label20.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label20
			point = New Global.System.Drawing.Point(265, 166)
			label11.Location = point
			Me.Label20.Name = "Label20"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label20
			size = New Global.System.Drawing.Size(104, 29)
			label12.Size = size
			Me.Label20.TabIndex = 9
			Me.Label20.Text = "التسوية الضريبية"
			Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(265, 48)
			label13.Location = point
			Me.Label7.Name = "Label7"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(104, 29)
			label14.Size = size
			Me.Label7.TabIndex = 9
			Me.Label7.Text = "التسوية الضريبية"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtNetPurchTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNetPurchTax.BackColor = Global.System.Drawing.Color.DarkGray
			Me.txtNetPurchTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtNetPurchTax As Global.System.Windows.Forms.Control = Me.txtNetPurchTax
			point = New Global.System.Drawing.Point(347, 308)
			txtNetPurchTax.Location = point
			Me.txtNetPurchTax.Name = "txtNetPurchTax"
			Dim txtNetPurchTax2 As Global.System.Windows.Forms.Control = Me.txtNetPurchTax
			size = New Global.System.Drawing.Size(165, 29)
			txtNetPurchTax2.Size = size
			Me.txtNetPurchTax.TabIndex = 9
			Me.txtNetPurchTax.Text = " "
			Me.txtNetPurchTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtPurchRetVal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPurchRetVal.BackColor = Global.System.Drawing.Color.Silver
			Me.txtPurchRetVal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtPurchRetVal As Global.System.Windows.Forms.Control = Me.txtPurchRetVal
			point = New Global.System.Drawing.Point(481, 197)
			txtPurchRetVal.Location = point
			Me.txtPurchRetVal.Name = "txtPurchRetVal"
			Dim txtPurchRetVal2 As Global.System.Windows.Forms.Control = Me.txtPurchRetVal
			size = New Global.System.Drawing.Size(104, 29)
			txtPurchRetVal2.Size = size
			Me.txtPurchRetVal.TabIndex = 9
			Me.txtPurchRetVal.Text = " "
			Me.txtPurchRetVal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSaleRetVal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSaleRetVal.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtSaleRetVal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSaleRetVal As Global.System.Windows.Forms.Control = Me.txtSaleRetVal
			point = New Global.System.Drawing.Point(481, 79)
			txtSaleRetVal.Location = point
			Me.txtSaleRetVal.Name = "txtSaleRetVal"
			Dim txtSaleRetVal2 As Global.System.Windows.Forms.Control = Me.txtSaleRetVal
			size = New Global.System.Drawing.Size(104, 29)
			txtSaleRetVal2.Size = size
			Me.txtSaleRetVal.TabIndex = 9
			Me.txtSaleRetVal.Text = " "
			Me.txtSaleRetVal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label18.BackColor = Global.System.Drawing.Color.Silver
			Me.Label18.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label18
			point = New Global.System.Drawing.Point(373, 166)
			label15.Location = point
			Me.Label18.Name = "Label18"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label18
			size = New Global.System.Drawing.Size(104, 29)
			label16.Size = size
			Me.Label18.TabIndex = 9
			Me.Label18.Text = "ض القيمة المضافة"
			Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(373, 48)
			label17.Location = point
			Me.Label6.Name = "Label6"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(104, 29)
			label18.Size = size
			Me.Label6.TabIndex = 9
			Me.Label6.Text = "ض القيمة المضافة"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtNetSaleTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNetSaleTax.BackColor = Global.System.Drawing.Color.DarkGray
			Me.txtNetSaleTax.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtNetSaleTax As Global.System.Windows.Forms.Control = Me.txtNetSaleTax
			point = New Global.System.Drawing.Point(518, 308)
			txtNetSaleTax.Location = point
			Me.txtNetSaleTax.Name = "txtNetSaleTax"
			Dim txtNetSaleTax2 As Global.System.Windows.Forms.Control = Me.txtNetSaleTax
			size = New Global.System.Drawing.Size(174, 29)
			txtNetSaleTax2.Size = size
			Me.txtNetSaleTax.TabIndex = 9
			Me.txtNetSaleTax.Text = " "
			Me.txtNetSaleTax.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtPurchVal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPurchVal.BackColor = Global.System.Drawing.Color.Silver
			Me.txtPurchVal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtPurchVal As Global.System.Windows.Forms.Control = Me.txtPurchVal
			point = New Global.System.Drawing.Point(588, 197)
			txtPurchVal.Location = point
			Me.txtPurchVal.Name = "txtPurchVal"
			Dim txtPurchVal2 As Global.System.Windows.Forms.Control = Me.txtPurchVal
			size = New Global.System.Drawing.Size(104, 29)
			txtPurchVal2.Size = size
			Me.txtPurchVal.TabIndex = 9
			Me.txtPurchVal.Text = " "
			Me.txtPurchVal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSaleVal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSaleVal.BackColor = Global.System.Drawing.Color.LightGray
			Me.txtSaleVal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSaleVal As Global.System.Windows.Forms.Control = Me.txtSaleVal
			point = New Global.System.Drawing.Point(588, 79)
			txtSaleVal.Location = point
			Me.txtSaleVal.Name = "txtSaleVal"
			Dim txtSaleVal2 As Global.System.Windows.Forms.Control = Me.txtSaleVal
			size = New Global.System.Drawing.Size(104, 29)
			txtSaleVal2.Size = size
			Me.txtSaleVal.TabIndex = 9
			Me.txtSaleVal.Text = " "
			Me.txtSaleVal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label27.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label27.BackColor = Global.System.Drawing.Color.DarkGray
			Me.Label27.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label27
			point = New Global.System.Drawing.Point(347, 277)
			label19.Location = point
			Me.Label27.Name = "Label27"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label27
			size = New Global.System.Drawing.Size(165, 29)
			label20.Size = size
			Me.Label27.TabIndex = 9
			Me.Label27.Text = "ضريبة المشتريات"
			Me.Label27.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label16.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label16.BackColor = Global.System.Drawing.Color.Silver
			Me.Label16.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label16
			point = New Global.System.Drawing.Point(481, 166)
			label21.Location = point
			Me.Label16.Name = "Label16"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label16
			size = New Global.System.Drawing.Size(104, 29)
			label22.Size = size
			Me.Label16.TabIndex = 9
			Me.Label16.Text = "المردودات"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label23 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(481, 48)
			label23.Location = point
			Me.Label5.Name = "Label5"
			Dim label24 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(104, 29)
			label24.Size = size
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "المردودات"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label26.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label26.BackColor = Global.System.Drawing.Color.DarkGray
			Me.Label26.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label25 As Global.System.Windows.Forms.Control = Me.Label26
			point = New Global.System.Drawing.Point(518, 277)
			label25.Location = point
			Me.Label26.Name = "Label26"
			Dim label26 As Global.System.Windows.Forms.Control = Me.Label26
			size = New Global.System.Drawing.Size(174, 29)
			label26.Size = size
			Me.Label26.TabIndex = 9
			Me.Label26.Text = "ضريبة المبيعات"
			Me.Label26.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label15.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label15.BackColor = Global.System.Drawing.Color.Silver
			Me.Label15.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label27 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(588, 166)
			label27.Location = point
			Me.Label15.Name = "Label15"
			Dim label28 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(104, 29)
			label28.Size = size
			Me.Label15.TabIndex = 9
			Me.Label15.Text = "المشتريات"
			Me.Label15.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label29 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(588, 48)
			label29.Location = point
			Me.Label4.Name = "Label4"
			Dim label30 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(104, 29)
			label30.Size = size
			Me.Label4.TabIndex = 9
			Me.Label4.Text = "المبيعات"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label25.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label25.BackColor = Global.System.Drawing.Color.DarkGray
			Me.Label25.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label31 As Global.System.Windows.Forms.Control = Me.Label25
			point = New Global.System.Drawing.Point(159, 245)
			label31.Location = point
			Me.Label25.Name = "Label25"
			Dim label32 As Global.System.Windows.Forms.Control = Me.Label25
			size = New Global.System.Drawing.Size(533, 29)
			label32.Size = size
			Me.Label25.TabIndex = 9
			Me.Label25.Text = "تفاصيل الضريبة"
			Me.Label25.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label14.BackColor = Global.System.Drawing.Color.Silver
			Me.Label14.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label33 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(159, 134)
			label33.Location = point
			Me.Label14.Name = "Label14"
			Dim label34 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(533, 29)
			label34.Size = size
			Me.Label14.TabIndex = 9
			Me.Label14.Text = "ضريبة القيمة المضافة على المشتريات"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.BackColor = Global.System.Drawing.Color.LightGray
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label35 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(159, 16)
			label35.Location = point
			Me.Label1.Name = "Label1"
			Dim label36 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(533, 29)
			label36.Size = size
			Me.Label1.TabIndex = 9
			Me.Label1.Text = "ضريبة القيمة المضافة على المبيعات"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(836, 440)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.MaximizeBox = False
			Me.Name = "frmTaxRptPeriod"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "إقرار ضريبي"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
