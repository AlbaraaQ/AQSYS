Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmSalePurchRest
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewButtonColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewButtonColumn
    Friend WithEvents Column15 As DataGridViewButtonColumn
    Friend WithEvents Column16 As DataGridViewButtonColumn
    Friend WithEvents Column17 As DataGridViewButtonColumn
    Friend WithEvents Column18 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
	Friend WithEvents ToolTip1 As ToolTip
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
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnCustAdd As Button
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNew2DG As Button
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnPrintCashier As Button
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSave2DG As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkInTax As CheckBox
    Friend WithEvents chkIsPaid As CheckBox
    Friend WithEvents chkPaidOnline As CheckBox
    Friend WithEvents cmbAddSalesMen As Button
    Friend WithEvents cmbApps As ComboBox
    Friend WithEvents cmbBanks As ComboBox
    Friend WithEvents cmbCenter As ComboBox
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents cmbProcType As ComboBox
    Friend WithEvents cmbProcTypeSrch As ComboBox
    Friend WithEvents cmbSafe As ComboBox
    Friend WithEvents cmbSalesMen As ComboBox
    Friend WithEvents cmbStock As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbUnits As ComboBox
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd135 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmdClearAll As Button
    Friend WithEvents colAdds As DataGridViewTextBoxColumn
    Friend WithEvents coldisc As DataGridViewTextBoxColumn
    Friend WithEvents colistab3 As DataGridViewTextBoxColumn
    Friend WithEvents colold As DataGridViewTextBoxColumn
    Friend WithEvents coltab3val As DataGridViewTextBoxColumn
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvGroups As DataGridView
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents dgvTawlaGroups As DataGridView
    Friend WithEvents dgvTawlas As DataGridView
    Friend WithEvents dgvUnits As DataGridView
    Friend WithEvents dgvitemData As DataGridView
    Friend WithEvents label53 As Label
    Friend WithEvents label54 As Label
    Friend WithEvents lblBarcode As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents lblDiscPerc As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPerc As Label
    Friend WithEvents lblSalesMen As Label
    Friend WithEvents lblSrcInvNo As Label
    Friend WithEvents lblTab3Name As Label
    Friend WithEvents lblTab3Val As Label
    Friend WithEvents lblTaxVal As Label
    Friend WithEvents lblTotPurch As Label
    Friend WithEvents lblTotSale As Label
    Friend WithEvents lblcostcenter As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents pnlApp As Panel
    Friend WithEvents pnlBalance As Panel
    Friend WithEvents pnlGroups As Panel
    Friend WithEvents pnlPay As Panel
    Friend WithEvents pnlQuan As Panel
    Friend WithEvents pnlTawla As Panel
    Friend WithEvents rdApp As RadioButton
    Friend WithEvents rdAuto As RadioButton
    Friend WithEvents rdCash As RadioButton
    Friend WithEvents rdIn As RadioButton
    Friend WithEvents rdIn2 As RadioButton
    Friend WithEvents rdNetwork As RadioButton
    Friend WithEvents rdNormal As RadioButton
    Friend WithEvents rdOut As RadioButton
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAppFee As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtCapital As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents txtCustNo As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtDiff As TextBox
    Friend WithEvents txtExchangeVal As TextBox
    Friend WithEvents txtExchangeValD As TextBox
    Friend WithEvents txtExpireDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtInvTime As DateTimePicker
    Friend WithEvents txtMinusPerc As TextBox
    Friend WithEvents txtMinusVal As TextBox
    Friend WithEvents txtNetwork As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents txtRem As TextBox
    Friend WithEvents txtSrcInvNo As TextBox
    Friend WithEvents txtSrchNo As TextBox
    Friend WithEvents txtTab3Perc As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtTotPurch As TextBox
    Friend WithEvents txtTotSale As TextBox
    Friend WithEvents txtVal1 As TextBox
    Friend WithEvents txtVal2 As TextBox
    Friend WithEvents txtVal2D As TextBox
    Friend WithEvents txtrec As TextBox
    Friend WithEvents txtrecrem As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSalePurchRest))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle8 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle9 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle10 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle11 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle12 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle13 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle14 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle15 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle16 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle17 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle18 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle19 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle20 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle21 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.Panel13 = New Global.System.Windows.Forms.Panel()
			Me.Label37 = New Global.System.Windows.Forms.Label()
			Me.Label36 = New Global.System.Windows.Forms.Label()
			Me.Label35 = New Global.System.Windows.Forms.Label()
			Me.Label38 = New Global.System.Windows.Forms.Label()
			Me.Label39 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel6 = New Global.System.Windows.Forms.Panel()
			Me.Panel5 = New Global.System.Windows.Forms.Panel()
			Me.dgvitemData = New Global.System.Windows.Forms.DataGridView()
			Me.Column14 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Column15 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Column16 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Column17 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel11 = New Global.System.Windows.Forms.Panel()
			Me.Button8 = New Global.System.Windows.Forms.Button()
			Me.Button11 = New Global.System.Windows.Forms.Button()
			Me.Button9 = New Global.System.Windows.Forms.Button()
			Me.Button10 = New Global.System.Windows.Forms.Button()
			Me.pnlQuan = New Global.System.Windows.Forms.Panel()
			Me.Panel10 = New Global.System.Windows.Forms.Panel()
			Me.txtVal2 = New Global.System.Windows.Forms.TextBox()
			Me.txtVal1 = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.btnSave2DG = New Global.System.Windows.Forms.Button()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtExchangeVal = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.btnNew2DG = New Global.System.Windows.Forms.Button()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbBanks = New Global.System.Windows.Forms.ComboBox()
			Me.txtNetwork = New Global.System.Windows.Forms.TextBox()
			Me.txtCash = New Global.System.Windows.Forms.TextBox()
			Me.Label66 = New Global.System.Windows.Forms.Label()
			Me.Label65 = New Global.System.Windows.Forms.Label()
			Me.cmd0 = New Global.System.Windows.Forms.Button()
			Me.cmd9 = New Global.System.Windows.Forms.Button()
			Me.cmd8 = New Global.System.Windows.Forms.Button()
			Me.cmd7 = New Global.System.Windows.Forms.Button()
			Me.cmdClearAll = New Global.System.Windows.Forms.Button()
			Me.cmd6 = New Global.System.Windows.Forms.Button()
			Me.cmd5 = New Global.System.Windows.Forms.Button()
			Me.cmd4 = New Global.System.Windows.Forms.Button()
			Me.cmd3 = New Global.System.Windows.Forms.Button()
			Me.cmd2 = New Global.System.Windows.Forms.Button()
			Me.cmd135 = New Global.System.Windows.Forms.Button()
			Me.pnlGroups = New Global.System.Windows.Forms.Panel()
			Me.Panel14 = New Global.System.Windows.Forms.Panel()
			Me.dgvGroups = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewButtonColumn1 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.pnlTawla = New Global.System.Windows.Forms.Panel()
			Me.dgvTawlas = New Global.System.Windows.Forms.DataGridView()
			Me.Column20 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column21 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column22 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.dgvTawlaGroups = New Global.System.Windows.Forms.DataGridView()
			Me.Panel15 = New Global.System.Windows.Forms.Panel()
			Me.Button12 = New Global.System.Windows.Forms.Button()
			Me.Button13 = New Global.System.Windows.Forms.Button()
			Me.Panel7 = New Global.System.Windows.Forms.Panel()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewTextBoxColumn3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn4 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column13 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Column18 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.colAdds = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colold = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.coldisc = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colistab3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.coltab3val = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel16 = New Global.System.Windows.Forms.Panel()
			Me.chkIsPaid = New Global.System.Windows.Forms.CheckBox()
			Me.txtMinusPerc = New Global.System.Windows.Forms.TextBox()
			Me.lblDiscount = New Global.System.Windows.Forms.Label()
			Me.txtMinusVal = New Global.System.Windows.Forms.TextBox()
			Me.NumericUpDown1 = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label42 = New Global.System.Windows.Forms.Label()
			Me.txtTab3Perc = New Global.System.Windows.Forms.TextBox()
			Me.Label45 = New Global.System.Windows.Forms.Label()
			Me.lblTab3Name = New Global.System.Windows.Forms.Label()
			Me.lblTab3Val = New Global.System.Windows.Forms.Label()
			Me.txtTax = New Global.System.Windows.Forms.TextBox()
			Me.Label30 = New Global.System.Windows.Forms.Label()
			Me.lblTaxVal = New Global.System.Windows.Forms.Label()
			Me.Button14 = New Global.System.Windows.Forms.Button()
			Me.lblDiscPerc = New Global.System.Windows.Forms.Label()
			Me.Label31 = New Global.System.Windows.Forms.Label()
			Me.txtrecrem = New Global.System.Windows.Forms.TextBox()
			Me.txtDiff = New Global.System.Windows.Forms.TextBox()
			Me.txtrec = New Global.System.Windows.Forms.TextBox()
			Me.Label32 = New Global.System.Windows.Forms.Label()
			Me.Label33 = New Global.System.Windows.Forms.Label()
			Me.Label34 = New Global.System.Windows.Forms.Label()
			Me.Button6 = New Global.System.Windows.Forms.Button()
			Me.lblTotPurch = New Global.System.Windows.Forms.Label()
			Me.Button7 = New Global.System.Windows.Forms.Button()
			Me.txtTotPurch = New Global.System.Windows.Forms.TextBox()
			Me.lblTotSale = New Global.System.Windows.Forms.Label()
			Me.btnPrintCashier = New Global.System.Windows.Forms.Button()
			Me.txtTotSale = New Global.System.Windows.Forms.TextBox()
			Me.pnlBalance = New Global.System.Windows.Forms.Panel()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtCapital = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox7 = New Global.System.Windows.Forms.GroupBox()
			Me.pnlApp = New Global.System.Windows.Forms.Panel()
			Me.chkPaidOnline = New Global.System.Windows.Forms.CheckBox()
			Me.label54 = New Global.System.Windows.Forms.Label()
			Me.txtAppFee = New Global.System.Windows.Forms.TextBox()
			Me.cmbApps = New Global.System.Windows.Forms.ComboBox()
			Me.label53 = New Global.System.Windows.Forms.Label()
			Me.txtBarcode = New Global.System.Windows.Forms.TextBox()
			Me.Button15 = New Global.System.Windows.Forms.Button()
			Me.txtCustNo = New Global.System.Windows.Forms.TextBox()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.rdApp = New Global.System.Windows.Forms.RadioButton()
			Me.rdIn2 = New Global.System.Windows.Forms.RadioButton()
			Me.rdIn = New Global.System.Windows.Forms.RadioButton()
			Me.rdOut = New Global.System.Windows.Forms.RadioButton()
			Me.dgvUnits = New Global.System.Windows.Forms.DataGridView()
			Me.txtOrderNo = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.lblBarcode = New Global.System.Windows.Forms.Label()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.lblClient = New Global.System.Windows.Forms.Label()
			Me.cmbClient = New Global.System.Windows.Forms.ComboBox()
			Me.btnCustAdd = New Global.System.Windows.Forms.Button()
			Me.Label28 = New Global.System.Windows.Forms.Label()
			Me.txtBalance = New Global.System.Windows.Forms.TextBox()
			Me.rdAuto = New Global.System.Windows.Forms.RadioButton()
			Me.rdNormal = New Global.System.Windows.Forms.RadioButton()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.cmbUnits = New Global.System.Windows.Forms.ComboBox()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.Label29 = New Global.System.Windows.Forms.Label()
			Me.Label23 = New Global.System.Windows.Forms.Label()
			Me.Label24 = New Global.System.Windows.Forms.Label()
			Me.txtExchangeValD = New Global.System.Windows.Forms.TextBox()
			Me.txtVal2D = New Global.System.Windows.Forms.TextBox()
			Me.cmbCurrency = New Global.System.Windows.Forms.ComboBox()
			Me.cmbGroups = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtExpireDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label25 = New Global.System.Windows.Forms.Label()
			Me.txtRem = New Global.System.Windows.Forms.TextBox()
			Me.txtPaid = New Global.System.Windows.Forms.TextBox()
			Me.Label26 = New Global.System.Windows.Forms.Label()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.lblPerc = New Global.System.Windows.Forms.Label()
			Me.Label21 = New Global.System.Windows.Forms.Label()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.txtInvTime = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbCenter = New Global.System.Windows.Forms.ComboBox()
			Me.lblcostcenter = New Global.System.Windows.Forms.Label()
			Me.chkInTax = New Global.System.Windows.Forms.CheckBox()
			Me.pnlPay = New Global.System.Windows.Forms.Panel()
			Me.rdCash = New Global.System.Windows.Forms.RadioButton()
			Me.rdNetwork = New Global.System.Windows.Forms.RadioButton()
			Me.cmbAddSalesMen = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.cmbSalesMen = New Global.System.Windows.Forms.ComboBox()
			Me.lblSalesMen = New Global.System.Windows.Forms.Label()
			Me.cmbProcType = New Global.System.Windows.Forms.ComboBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.cmbStock = New Global.System.Windows.Forms.ComboBox()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.cmbSafe = New Global.System.Windows.Forms.ComboBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.txtSrcInvNo = New Global.System.Windows.Forms.TextBox()
			Me.lblSrcInvNo = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtSrchNo = New Global.System.Windows.Forms.TextBox()
			Me.cmbProcTypeSrch = New Global.System.Windows.Forms.ComboBox()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.Panel13.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel6.SuspendLayout()
			Me.Panel5.SuspendLayout()
			CType(Me.dgvitemData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel11.SuspendLayout()
			Me.pnlQuan.SuspendLayout()
			Me.Panel10.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.pnlGroups.SuspendLayout()
			Me.Panel14.SuspendLayout()
			CType(Me.dgvGroups, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlTawla.SuspendLayout()
			CType(Me.dgvTawlas, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dgvTawlaGroups, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel15.SuspendLayout()
			Me.Panel7.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel16.SuspendLayout()
			CType(Me.NumericUpDown1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlBalance.SuspendLayout()
			Me.GroupBox7.SuspendLayout()
			Me.pnlApp.SuspendLayout()
			Me.Panel4.SuspendLayout()
			CType(Me.dgvUnits, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.pnlPay.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnPrint, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			Me.ToolTip1.SetToolTip(Me.toolStrip1, resources.GetString("toolStrip1.ToolTip"))
			resources.ApplyResources(Me.btnNew, "btnNew")
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Image = My.Resources.Resources._new
			Me.btnNew.Name = "btnNew"
			resources.ApplyResources(Me.btnSave, "btnSave")
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Image = My.Resources.Resources.save
			Me.btnSave.Name = "btnSave"
			resources.ApplyResources(Me.btnDelete, "btnDelete")
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Image = My.Resources.Resources.delete
			Me.btnDelete.Name = "btnDelete"
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Image = My.Resources.Resources.last
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Image = My.Resources.Resources._next
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Image = My.Resources.Resources.previous
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Resources._exit
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.Panel13)
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			Me.ToolTip1.SetToolTip(Me.panel2, resources.GetString("panel2.ToolTip"))
			resources.ApplyResources(Me.Panel13, "Panel13")
			Me.Panel13.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel13.Controls.Add(Me.Label37)
			Me.Panel13.Controls.Add(Me.Label36)
			Me.Panel13.Controls.Add(Me.Label35)
			Me.Panel13.Controls.Add(Me.Label38)
			Me.Panel13.Controls.Add(Me.Label39)
			Me.Panel13.Name = "Panel13"
			Me.ToolTip1.SetToolTip(Me.Panel13, resources.GetString("Panel13.ToolTip"))
			resources.ApplyResources(Me.Label37, "Label37")
			Me.Label37.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label37.Name = "Label37"
			Me.ToolTip1.SetToolTip(Me.Label37, resources.GetString("Label37.ToolTip"))
			resources.ApplyResources(Me.Label36, "Label36")
			Me.Label36.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label36.Name = "Label36"
			Me.ToolTip1.SetToolTip(Me.Label36, resources.GetString("Label36.ToolTip"))
			resources.ApplyResources(Me.Label35, "Label35")
			Me.Label35.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label35.Name = "Label35"
			Me.ToolTip1.SetToolTip(Me.Label35, resources.GetString("Label35.ToolTip"))
			resources.ApplyResources(Me.Label38, "Label38")
			Me.Label38.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label38.Name = "Label38"
			Me.ToolTip1.SetToolTip(Me.Label38, resources.GetString("Label38.ToolTip"))
			resources.ApplyResources(Me.Label39, "Label39")
			Me.Label39.ForeColor = Global.System.Drawing.Color.Black
			Me.Label39.Name = "Label39"
			Me.ToolTip1.SetToolTip(Me.Label39, resources.GetString("Label39.ToolTip"))
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.TabControl1)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.ToolTip1.SetToolTip(Me.TabControl1, resources.GetString("TabControl1.ToolTip"))
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Controls.Add(Me.GroupBox2)
			Me.TabPage1.Name = "TabPage1"
			Me.ToolTip1.SetToolTip(Me.TabPage1, resources.GetString("TabPage1.ToolTip"))
			Me.TabPage1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Controls.Add(Me.Panel6)
			Me.GroupBox2.Controls.Add(Me.Panel7)
			Me.GroupBox2.Controls.Add(Me.GroupBox7)
			Me.GroupBox2.Controls.Add(Me.Panel3)
			Me.GroupBox2.Controls.Add(Me.Button5)
			Me.GroupBox2.Controls.Add(Me.Button2)
			Me.GroupBox2.Controls.Add(Me.Label27)
			Me.GroupBox2.Controls.Add(Me.TextBox1)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Controls.Add(Me.Label22)
			Me.GroupBox2.Controls.Add(Me.lblPerc)
			Me.GroupBox2.Controls.Add(Me.Label21)
			Me.GroupBox2.Controls.Add(Me.Button3)
			Me.GroupBox2.Controls.Add(Me.txtInvTime)
			Me.GroupBox2.Controls.Add(Me.Label20)
			Me.GroupBox2.Controls.Add(Me.GroupBox3)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox2, resources.GetString("GroupBox2.ToolTip"))
			resources.ApplyResources(Me.Panel6, "Panel6")
			Me.Panel6.Controls.Add(Me.Panel5)
			Me.Panel6.Controls.Add(Me.pnlQuan)
			Me.Panel6.Controls.Add(Me.pnlGroups)
			Me.Panel6.Name = "Panel6"
			Me.ToolTip1.SetToolTip(Me.Panel6, resources.GetString("Panel6.ToolTip"))
			resources.ApplyResources(Me.Panel5, "Panel5")
			Me.Panel5.Controls.Add(Me.dgvitemData)
			Me.Panel5.Controls.Add(Me.Panel11)
			Me.Panel5.Name = "Panel5"
			Me.ToolTip1.SetToolTip(Me.Panel5, resources.GetString("Panel5.ToolTip"))
			resources.ApplyResources(Me.dgvitemData, "dgvitemData")
			Me.dgvitemData.AllowUserToAddRows = False
			Me.dgvitemData.AllowUserToDeleteRows = False
			Me.dgvitemData.AllowUserToResizeColumns = False
			Me.dgvitemData.AllowUserToResizeRows = False
			Me.dgvitemData.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvitemData.ColumnHeadersVisible = False
			Me.dgvitemData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column14, Me.Column15, Me.Column16, Me.Column17 })
			Me.dgvitemData.Name = "dgvitemData"
			Me.dgvitemData.RowHeadersVisible = False
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvitemData.RowsDefaultCellStyle = dataGridViewCellStyle
			Me.dgvitemData.RowTemplate.DefaultCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvitemData.RowTemplate.Height = 85
			Me.dgvitemData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.CellSelect
			Me.ToolTip1.SetToolTip(Me.dgvitemData, resources.GetString("dgvitemData.ToolTip"))
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column14.DefaultCellStyle = dataGridViewCellStyle2
			Me.Column14.FillWeight = 2.330867F
			Me.Column14.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			resources.ApplyResources(Me.Column14, "Column14")
			Me.Column14.Name = "Column14"
			Me.Column14.Text = "ش"
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column15.DefaultCellStyle = dataGridViewCellStyle3
			Me.Column15.FillWeight = 11.63334F
			Me.Column15.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			resources.ApplyResources(Me.Column15, "Column15")
			Me.Column15.Name = "Column15"
			Me.Column15.Text = "ش"
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column16.DefaultCellStyle = dataGridViewCellStyle4
			Me.Column16.FillWeight = 61.16269F
			Me.Column16.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			resources.ApplyResources(Me.Column16, "Column16")
			Me.Column16.Name = "Column16"
			Me.Column16.Text = "ش"
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.Column17.DefaultCellStyle = dataGridViewCellStyle5
			Me.Column17.FillWeight = 324.8731F
			Me.Column17.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			resources.ApplyResources(Me.Column17, "Column17")
			Me.Column17.Name = "Column17"
			Me.Column17.Text = "ش"
			resources.ApplyResources(Me.Panel11, "Panel11")
			Me.Panel11.Controls.Add(Me.Button8)
			Me.Panel11.Controls.Add(Me.Button11)
			Me.Panel11.Controls.Add(Me.Button9)
			Me.Panel11.Controls.Add(Me.Button10)
			Me.Panel11.Name = "Panel11"
			Me.ToolTip1.SetToolTip(Me.Panel11, resources.GetString("Panel11.ToolTip"))
			resources.ApplyResources(Me.Button8, "Button8")
			Me.Button8.Name = "Button8"
			Me.ToolTip1.SetToolTip(Me.Button8, resources.GetString("Button8.ToolTip"))
			Me.Button8.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button11, "Button11")
			Me.Button11.Name = "Button11"
			Me.ToolTip1.SetToolTip(Me.Button11, resources.GetString("Button11.ToolTip"))
			Me.Button11.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button9, "Button9")
			Me.Button9.Name = "Button9"
			Me.ToolTip1.SetToolTip(Me.Button9, resources.GetString("Button9.ToolTip"))
			Me.Button9.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button10, "Button10")
			Me.Button10.Name = "Button10"
			Me.ToolTip1.SetToolTip(Me.Button10, resources.GetString("Button10.ToolTip"))
			Me.Button10.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.pnlQuan, "pnlQuan")
			Me.pnlQuan.Controls.Add(Me.Panel10)
			Me.pnlQuan.Controls.Add(Me.GroupBox5)
			Me.pnlQuan.Name = "pnlQuan"
			Me.ToolTip1.SetToolTip(Me.pnlQuan, resources.GetString("pnlQuan.ToolTip"))
			resources.ApplyResources(Me.Panel10, "Panel10")
			Me.Panel10.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel10.Controls.Add(Me.txtVal2)
			Me.Panel10.Controls.Add(Me.txtVal1)
			Me.Panel10.Controls.Add(Me.Label7)
			Me.Panel10.Controls.Add(Me.btnSave2DG)
			Me.Panel10.Controls.Add(Me.Label6)
			Me.Panel10.Controls.Add(Me.txtExchangeVal)
			Me.Panel10.Controls.Add(Me.Label5)
			Me.Panel10.Controls.Add(Me.btnNew2DG)
			Me.Panel10.Name = "Panel10"
			Me.ToolTip1.SetToolTip(Me.Panel10, resources.GetString("Panel10.ToolTip"))
			resources.ApplyResources(Me.txtVal2, "txtVal2")
			Me.txtVal2.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtVal2.Name = "txtVal2"
			Me.txtVal2.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtVal2, resources.GetString("txtVal2.ToolTip"))
			resources.ApplyResources(Me.txtVal1, "txtVal1")
			Me.txtVal1.Name = "txtVal1"
			Me.ToolTip1.SetToolTip(Me.txtVal1, resources.GetString("txtVal1.ToolTip"))
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			Me.ToolTip1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
			resources.ApplyResources(Me.btnSave2DG, "btnSave2DG")
			Me.btnSave2DG.Image = My.Resources.Resources.Actions_go_down_icon
			Me.btnSave2DG.Name = "btnSave2DG"
			Me.ToolTip1.SetToolTip(Me.btnSave2DG, resources.GetString("btnSave2DG.ToolTip"))
			Me.btnSave2DG.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
			resources.ApplyResources(Me.txtExchangeVal, "txtExchangeVal")
			Me.txtExchangeVal.Name = "txtExchangeVal"
			Me.ToolTip1.SetToolTip(Me.txtExchangeVal, resources.GetString("txtExchangeVal.ToolTip"))
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
			resources.ApplyResources(Me.btnNew2DG, "btnNew2DG")
			Me.btnNew2DG.Image = My.Resources.Resources.Files_New_Window_icon
			Me.btnNew2DG.Name = "btnNew2DG"
			Me.ToolTip1.SetToolTip(Me.btnNew2DG, resources.GetString("btnNew2DG.ToolTip"))
			Me.btnNew2DG.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox5, "GroupBox5")
			Me.GroupBox5.Controls.Add(Me.cmbBanks)
			Me.GroupBox5.Controls.Add(Me.txtNetwork)
			Me.GroupBox5.Controls.Add(Me.txtCash)
			Me.GroupBox5.Controls.Add(Me.Label66)
			Me.GroupBox5.Controls.Add(Me.Label65)
			Me.GroupBox5.Controls.Add(Me.cmd0)
			Me.GroupBox5.Controls.Add(Me.cmd9)
			Me.GroupBox5.Controls.Add(Me.cmd8)
			Me.GroupBox5.Controls.Add(Me.cmd7)
			Me.GroupBox5.Controls.Add(Me.cmdClearAll)
			Me.GroupBox5.Controls.Add(Me.cmd6)
			Me.GroupBox5.Controls.Add(Me.cmd5)
			Me.GroupBox5.Controls.Add(Me.cmd4)
			Me.GroupBox5.Controls.Add(Me.cmd3)
			Me.GroupBox5.Controls.Add(Me.cmd2)
			Me.GroupBox5.Controls.Add(Me.cmd135)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox5, resources.GetString("GroupBox5.ToolTip"))
			resources.ApplyResources(Me.cmbBanks, "cmbBanks")
			Me.cmbBanks.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbBanks.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbBanks.BackColor = Global.System.Drawing.Color.White
			Me.cmbBanks.FormattingEnabled = True
			Me.cmbBanks.Name = "cmbBanks"
			Me.ToolTip1.SetToolTip(Me.cmbBanks, resources.GetString("cmbBanks.ToolTip"))
			resources.ApplyResources(Me.txtNetwork, "txtNetwork")
			Me.txtNetwork.Name = "txtNetwork"
			Me.ToolTip1.SetToolTip(Me.txtNetwork, resources.GetString("txtNetwork.ToolTip"))
			resources.ApplyResources(Me.txtCash, "txtCash")
			Me.txtCash.Name = "txtCash"
			Me.ToolTip1.SetToolTip(Me.txtCash, resources.GetString("txtCash.ToolTip"))
			resources.ApplyResources(Me.Label66, "Label66")
			Me.Label66.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label66.Name = "Label66"
			Me.ToolTip1.SetToolTip(Me.Label66, resources.GetString("Label66.ToolTip"))
			resources.ApplyResources(Me.Label65, "Label65")
			Me.Label65.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label65.Name = "Label65"
			Me.ToolTip1.SetToolTip(Me.Label65, resources.GetString("Label65.ToolTip"))
			resources.ApplyResources(Me.cmd0, "cmd0")
			Me.cmd0.Name = "cmd0"
			Me.ToolTip1.SetToolTip(Me.cmd0, resources.GetString("cmd0.ToolTip"))
			Me.cmd0.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd9, "cmd9")
			Me.cmd9.Name = "cmd9"
			Me.ToolTip1.SetToolTip(Me.cmd9, resources.GetString("cmd9.ToolTip"))
			Me.cmd9.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd8, "cmd8")
			Me.cmd8.Name = "cmd8"
			Me.ToolTip1.SetToolTip(Me.cmd8, resources.GetString("cmd8.ToolTip"))
			Me.cmd8.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd7, "cmd7")
			Me.cmd7.Name = "cmd7"
			Me.ToolTip1.SetToolTip(Me.cmd7, resources.GetString("cmd7.ToolTip"))
			Me.cmd7.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmdClearAll, "cmdClearAll")
			Me.cmdClearAll.Name = "cmdClearAll"
			Me.ToolTip1.SetToolTip(Me.cmdClearAll, resources.GetString("cmdClearAll.ToolTip"))
			Me.cmdClearAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd6, "cmd6")
			Me.cmd6.Name = "cmd6"
			Me.ToolTip1.SetToolTip(Me.cmd6, resources.GetString("cmd6.ToolTip"))
			Me.cmd6.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd5, "cmd5")
			Me.cmd5.Name = "cmd5"
			Me.ToolTip1.SetToolTip(Me.cmd5, resources.GetString("cmd5.ToolTip"))
			Me.cmd5.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd4, "cmd4")
			Me.cmd4.Name = "cmd4"
			Me.ToolTip1.SetToolTip(Me.cmd4, resources.GetString("cmd4.ToolTip"))
			Me.cmd4.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd3, "cmd3")
			Me.cmd3.Name = "cmd3"
			Me.ToolTip1.SetToolTip(Me.cmd3, resources.GetString("cmd3.ToolTip"))
			Me.cmd3.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd2, "cmd2")
			Me.cmd2.Name = "cmd2"
			Me.ToolTip1.SetToolTip(Me.cmd2, resources.GetString("cmd2.ToolTip"))
			Me.cmd2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmd135, "cmd135")
			Me.cmd135.Name = "cmd135"
			Me.ToolTip1.SetToolTip(Me.cmd135, resources.GetString("cmd135.ToolTip"))
			Me.cmd135.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.pnlGroups, "pnlGroups")
			Me.pnlGroups.Controls.Add(Me.Panel14)
			Me.pnlGroups.Name = "pnlGroups"
			Me.ToolTip1.SetToolTip(Me.pnlGroups, resources.GetString("pnlGroups.ToolTip"))
			resources.ApplyResources(Me.Panel14, "Panel14")
			Me.Panel14.Controls.Add(Me.dgvGroups)
			Me.Panel14.Controls.Add(Me.pnlTawla)
			Me.Panel14.Controls.Add(Me.Panel15)
			Me.Panel14.Name = "Panel14"
			Me.ToolTip1.SetToolTip(Me.Panel14, resources.GetString("Panel14.ToolTip"))
			resources.ApplyResources(Me.dgvGroups, "dgvGroups")
			Me.dgvGroups.AllowUserToAddRows = False
			Me.dgvGroups.AllowUserToDeleteRows = False
			Me.dgvGroups.AllowUserToResizeColumns = False
			Me.dgvGroups.AllowUserToResizeRows = False
			Me.dgvGroups.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
			Me.dgvGroups.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvGroups.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvGroups.ColumnHeadersVisible = False
			Me.dgvGroups.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewButtonColumn1 })
			Me.dgvGroups.Name = "dgvGroups"
			Me.dgvGroups.RowHeadersVisible = False
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGroups.RowsDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvGroups.RowTemplate.DefaultCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGroups.RowTemplate.Height = 50
			Me.dgvGroups.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.CellSelect
			Me.ToolTip1.SetToolTip(Me.dgvGroups, resources.GetString("dgvGroups.ToolTip"))
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle7.ForeColor = Global.System.Drawing.Color.Black
			Me.DataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle7
			Me.DataGridViewButtonColumn1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			resources.ApplyResources(Me.DataGridViewButtonColumn1, "DataGridViewButtonColumn1")
			Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
			resources.ApplyResources(Me.pnlTawla, "pnlTawla")
			Me.pnlTawla.Controls.Add(Me.dgvTawlas)
			Me.pnlTawla.Controls.Add(Me.dgvTawlaGroups)
			Me.pnlTawla.Name = "pnlTawla"
			Me.ToolTip1.SetToolTip(Me.pnlTawla, resources.GetString("pnlTawla.ToolTip"))
			resources.ApplyResources(Me.dgvTawlas, "dgvTawlas")
			Me.dgvTawlas.AllowUserToAddRows = False
			Me.dgvTawlas.AllowUserToDeleteRows = False
			Me.dgvTawlas.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvTawlas.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvTawlas.ColumnHeadersVisible = False
			Me.dgvTawlas.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column20, Me.Column21, Me.Column22 })
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle8.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle8.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle8.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle8.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle8.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle8.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.dgvTawlas.DefaultCellStyle = dataGridViewCellStyle8
			Me.dgvTawlas.MultiSelect = False
			Me.dgvTawlas.Name = "dgvTawlas"
			Me.dgvTawlas.[ReadOnly] = True
			Me.dgvTawlas.RowHeadersVisible = False
			Me.dgvTawlas.RowTemplate.Height = 30
			Me.ToolTip1.SetToolTip(Me.dgvTawlas, resources.GetString("dgvTawlas.ToolTip"))
			resources.ApplyResources(Me.Column20, "Column20")
			Me.Column20.Name = "Column20"
			Me.Column20.[ReadOnly] = True
			resources.ApplyResources(Me.Column21, "Column21")
			Me.Column21.Name = "Column21"
			Me.Column21.[ReadOnly] = True
			resources.ApplyResources(Me.Column22, "Column22")
			Me.Column22.Name = "Column22"
			Me.Column22.[ReadOnly] = True
			resources.ApplyResources(Me.dgvTawlaGroups, "dgvTawlaGroups")
			Me.dgvTawlaGroups.AllowUserToAddRows = False
			Me.dgvTawlaGroups.AllowUserToDeleteRows = False
			Me.dgvTawlaGroups.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvTawlaGroups.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvTawlaGroups.ColumnHeadersVisible = False
			dataGridViewCellStyle9.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle9.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle9.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle9.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle9.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle9.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle9.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.dgvTawlaGroups.DefaultCellStyle = dataGridViewCellStyle9
			Me.dgvTawlaGroups.MultiSelect = False
			Me.dgvTawlaGroups.Name = "dgvTawlaGroups"
			Me.dgvTawlaGroups.[ReadOnly] = True
			Me.dgvTawlaGroups.RowHeadersVisible = False
			Me.ToolTip1.SetToolTip(Me.dgvTawlaGroups, resources.GetString("dgvTawlaGroups.ToolTip"))
			resources.ApplyResources(Me.Panel15, "Panel15")
			Me.Panel15.Controls.Add(Me.Button12)
			Me.Panel15.Controls.Add(Me.Button13)
			Me.Panel15.Name = "Panel15"
			Me.ToolTip1.SetToolTip(Me.Panel15, resources.GetString("Panel15.ToolTip"))
			resources.ApplyResources(Me.Button12, "Button12")
			Me.Button12.Name = "Button12"
			Me.ToolTip1.SetToolTip(Me.Button12, resources.GetString("Button12.ToolTip"))
			Me.Button12.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button13, "Button13")
			Me.Button13.Name = "Button13"
			Me.ToolTip1.SetToolTip(Me.Button13, resources.GetString("Button13.ToolTip"))
			Me.Button13.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Panel7, "Panel7")
			Me.Panel7.Controls.Add(Me.dgvItems)
			Me.Panel7.Controls.Add(Me.Panel16)
			Me.Panel7.Controls.Add(Me.pnlBalance)
			Me.Panel7.Controls.Add(Me.panel2)
			Me.Panel7.Name = "Panel7"
			Me.ToolTip1.SetToolTip(Me.Panel7, resources.GetString("Panel7.ToolTip"))
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
			dataGridViewCellStyle10.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle10.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle10.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle10.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle10.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvItems.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.dgvItems.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle11.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle11.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle11.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle11.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle11.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle11.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle11.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column4, Me.Column12, Me.Column9, Me.Column5, Me.Column13, Me.Column6, Me.Column8, Me.Column2, Me.Column7, Me.Column11, Me.Column18, Me.colAdds, Me.colold, Me.coldisc, Me.colistab3, Me.coltab3val })
			dataGridViewCellStyle12.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle12.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle12.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle12.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle12.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle12.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle12.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.DefaultCellStyle = dataGridViewCellStyle12
			Me.dgvItems.EditMode = Global.System.Windows.Forms.DataGridViewEditMode.EditOnEnter
			Me.dgvItems.GridColor = Global.System.Drawing.Color.Silver
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			dataGridViewCellStyle13.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle13.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle13.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle13.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle13.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle13.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle13.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle13
			Me.dgvItems.RowHeadersVisible = False
			dataGridViewCellStyle14.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle14.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle14.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle14.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle14.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle14
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ToolTip1.SetToolTip(Me.dgvItems, resources.GetString("dgvItems.ToolTip"))
			dataGridViewCellStyle15.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15
			resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
			dataGridViewCellStyle16.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16
			resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
			Me.DataGridViewTextBoxColumn4.Items.AddRange(New Object() { "شراء", "بيع" })
			Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
			Me.DataGridViewTextBoxColumn4.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn4.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.DataGridViewTextBoxColumn4.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			dataGridViewCellStyle17.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Column4.DefaultCellStyle = dataGridViewCellStyle17
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column12, "Column12")
			Me.Column12.Name = "Column12"
			Me.Column12.[ReadOnly] = True
			resources.ApplyResources(Me.Column9, "Column9")
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column13, "Column13")
			Me.Column13.Name = "Column13"
			Me.Column13.[ReadOnly] = True
			dataGridViewCellStyle18.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Column6.DefaultCellStyle = dataGridViewCellStyle18
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			dataGridViewCellStyle19.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle19.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle19.ForeColor = Global.System.Drawing.Color.Blue
			Me.Column8.DefaultCellStyle = dataGridViewCellStyle19
			resources.ApplyResources(Me.Column8, "Column8")
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column8.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			resources.ApplyResources(Me.Column11, "Column11")
			Me.Column11.Name = "Column11"
			Me.Column11.[ReadOnly] = True
			Me.Column11.Text = "حذف"
			Me.Column11.UseColumnTextForButtonValue = True
			resources.ApplyResources(Me.Column18, "Column18")
			Me.Column18.Name = "Column18"
			Me.Column18.[ReadOnly] = True
			Me.Column18.Text = "إضافة"
			Me.Column18.UseColumnTextForButtonValue = True
			resources.ApplyResources(Me.colAdds, "colAdds")
			Me.colAdds.Name = "colAdds"
			Me.colAdds.[ReadOnly] = True
			resources.ApplyResources(Me.colold, "colold")
			Me.colold.Name = "colold"
			Me.colold.[ReadOnly] = True
			resources.ApplyResources(Me.coldisc, "coldisc")
			Me.coldisc.Name = "coldisc"
			Me.coldisc.[ReadOnly] = True
			resources.ApplyResources(Me.colistab3, "colistab3")
			Me.colistab3.Name = "colistab3"
			Me.colistab3.[ReadOnly] = True
			resources.ApplyResources(Me.coltab3val, "coltab3val")
			Me.coltab3val.Name = "coltab3val"
			Me.coltab3val.[ReadOnly] = True
			resources.ApplyResources(Me.Panel16, "Panel16")
			Me.Panel16.Controls.Add(Me.chkIsPaid)
			Me.Panel16.Controls.Add(Me.txtMinusPerc)
			Me.Panel16.Controls.Add(Me.lblDiscount)
			Me.Panel16.Controls.Add(Me.txtMinusVal)
			Me.Panel16.Controls.Add(Me.NumericUpDown1)
			Me.Panel16.Controls.Add(Me.Label42)
			Me.Panel16.Controls.Add(Me.txtTab3Perc)
			Me.Panel16.Controls.Add(Me.Label45)
			Me.Panel16.Controls.Add(Me.lblTab3Name)
			Me.Panel16.Controls.Add(Me.lblTab3Val)
			Me.Panel16.Controls.Add(Me.txtTax)
			Me.Panel16.Controls.Add(Me.Label30)
			Me.Panel16.Controls.Add(Me.lblTaxVal)
			Me.Panel16.Controls.Add(Me.Button14)
			Me.Panel16.Controls.Add(Me.lblDiscPerc)
			Me.Panel16.Controls.Add(Me.Label31)
			Me.Panel16.Controls.Add(Me.txtrecrem)
			Me.Panel16.Controls.Add(Me.txtDiff)
			Me.Panel16.Controls.Add(Me.txtrec)
			Me.Panel16.Controls.Add(Me.Label32)
			Me.Panel16.Controls.Add(Me.Label33)
			Me.Panel16.Controls.Add(Me.Label34)
			Me.Panel16.Controls.Add(Me.Button6)
			Me.Panel16.Controls.Add(Me.lblTotPurch)
			Me.Panel16.Controls.Add(Me.Button7)
			Me.Panel16.Controls.Add(Me.txtTotPurch)
			Me.Panel16.Controls.Add(Me.lblTotSale)
			Me.Panel16.Controls.Add(Me.btnPrintCashier)
			Me.Panel16.Controls.Add(Me.txtTotSale)
			Me.Panel16.Name = "Panel16"
			Me.ToolTip1.SetToolTip(Me.Panel16, resources.GetString("Panel16.ToolTip"))
			resources.ApplyResources(Me.chkIsPaid, "chkIsPaid")
			Me.chkIsPaid.Name = "chkIsPaid"
			Me.ToolTip1.SetToolTip(Me.chkIsPaid, resources.GetString("chkIsPaid.ToolTip"))
			Me.chkIsPaid.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtMinusPerc, "txtMinusPerc")
			Me.txtMinusPerc.Name = "txtMinusPerc"
			Me.ToolTip1.SetToolTip(Me.txtMinusPerc, resources.GetString("txtMinusPerc.ToolTip"))
			resources.ApplyResources(Me.lblDiscount, "lblDiscount")
			Me.lblDiscount.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblDiscount.CausesValidation = False
			Me.lblDiscount.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblDiscount.Name = "lblDiscount"
			Me.ToolTip1.SetToolTip(Me.lblDiscount, resources.GetString("lblDiscount.ToolTip"))
			Me.lblDiscount.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.txtMinusVal, "txtMinusVal")
			Me.txtMinusVal.Name = "txtMinusVal"
			Me.ToolTip1.SetToolTip(Me.txtMinusVal, resources.GetString("txtMinusVal.ToolTip"))
			resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
			Dim numericUpDown As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			Dim num As Decimal = New Decimal(New Integer() { 1, 0, 0, 0 })
			numericUpDown.Minimum = num
			Me.NumericUpDown1.Name = "NumericUpDown1"
			Me.ToolTip1.SetToolTip(Me.NumericUpDown1, resources.GetString("NumericUpDown1.ToolTip"))
			Dim numericUpDown2 As Global.System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			numericUpDown2.Value = num
			resources.ApplyResources(Me.Label42, "Label42")
			Me.Label42.Name = "Label42"
			Me.ToolTip1.SetToolTip(Me.Label42, resources.GetString("Label42.ToolTip"))
			resources.ApplyResources(Me.txtTab3Perc, "txtTab3Perc")
			Me.txtTab3Perc.Name = "txtTab3Perc"
			Me.ToolTip1.SetToolTip(Me.txtTab3Perc, resources.GetString("txtTab3Perc.ToolTip"))
			resources.ApplyResources(Me.Label45, "Label45")
			Me.Label45.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label45.Name = "Label45"
			Me.ToolTip1.SetToolTip(Me.Label45, resources.GetString("Label45.ToolTip"))
			resources.ApplyResources(Me.lblTab3Name, "lblTab3Name")
			Me.lblTab3Name.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTab3Name.Name = "lblTab3Name"
			Me.ToolTip1.SetToolTip(Me.lblTab3Name, resources.GetString("lblTab3Name.ToolTip"))
			resources.ApplyResources(Me.lblTab3Val, "lblTab3Val")
			Me.lblTab3Val.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTab3Val.Name = "lblTab3Val"
			Me.ToolTip1.SetToolTip(Me.lblTab3Val, resources.GetString("lblTab3Val.ToolTip"))
			resources.ApplyResources(Me.txtTax, "txtTax")
			Me.txtTax.Name = "txtTax"
			Me.ToolTip1.SetToolTip(Me.txtTax, resources.GetString("txtTax.ToolTip"))
			resources.ApplyResources(Me.Label30, "Label30")
			Me.Label30.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label30.Name = "Label30"
			Me.ToolTip1.SetToolTip(Me.Label30, resources.GetString("Label30.ToolTip"))
			resources.ApplyResources(Me.lblTaxVal, "lblTaxVal")
			Me.lblTaxVal.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTaxVal.Name = "lblTaxVal"
			Me.ToolTip1.SetToolTip(Me.lblTaxVal, resources.GetString("lblTaxVal.ToolTip"))
			resources.ApplyResources(Me.Button14, "Button14")
			Me.Button14.Name = "Button14"
			Me.ToolTip1.SetToolTip(Me.Button14, resources.GetString("Button14.ToolTip"))
			Me.Button14.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.lblDiscPerc, "lblDiscPerc")
			Me.lblDiscPerc.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblDiscPerc.Name = "lblDiscPerc"
			Me.ToolTip1.SetToolTip(Me.lblDiscPerc, resources.GetString("lblDiscPerc.ToolTip"))
			resources.ApplyResources(Me.Label31, "Label31")
			Me.Label31.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label31.Name = "Label31"
			Me.ToolTip1.SetToolTip(Me.Label31, resources.GetString("Label31.ToolTip"))
			resources.ApplyResources(Me.txtrecrem, "txtrecrem")
			Me.txtrecrem.Name = "txtrecrem"
			Me.txtrecrem.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtrecrem, resources.GetString("txtrecrem.ToolTip"))
			resources.ApplyResources(Me.txtDiff, "txtDiff")
			Me.txtDiff.BackColor = Global.System.Drawing.Color.Coral
			Me.txtDiff.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtDiff.ForeColor = Global.System.Drawing.Color.Black
			Me.txtDiff.Name = "txtDiff"
			Me.txtDiff.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtDiff, resources.GetString("txtDiff.ToolTip"))
			resources.ApplyResources(Me.txtrec, "txtrec")
			Me.txtrec.Name = "txtrec"
			Me.ToolTip1.SetToolTip(Me.txtrec, resources.GetString("txtrec.ToolTip"))
			resources.ApplyResources(Me.Label32, "Label32")
			Me.Label32.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label32.CausesValidation = False
			Me.Label32.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Label32.Name = "Label32"
			Me.ToolTip1.SetToolTip(Me.Label32, resources.GetString("Label32.ToolTip"))
			Me.Label32.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.Label33, "Label33")
			Me.Label33.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label33.Name = "Label33"
			Me.ToolTip1.SetToolTip(Me.Label33, resources.GetString("Label33.ToolTip"))
			resources.ApplyResources(Me.Label34, "Label34")
			Me.Label34.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label34.Name = "Label34"
			Me.ToolTip1.SetToolTip(Me.Label34, resources.GetString("Label34.ToolTip"))
			resources.ApplyResources(Me.Button6, "Button6")
			Me.Button6.Name = "Button6"
			Me.ToolTip1.SetToolTip(Me.Button6, resources.GetString("Button6.ToolTip"))
			Me.Button6.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.lblTotPurch, "lblTotPurch")
			Me.lblTotPurch.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTotPurch.CausesValidation = False
			Me.lblTotPurch.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblTotPurch.Name = "lblTotPurch"
			Me.ToolTip1.SetToolTip(Me.lblTotPurch, resources.GetString("lblTotPurch.ToolTip"))
			Me.lblTotPurch.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.Button7, "Button7")
			Me.Button7.Name = "Button7"
			Me.ToolTip1.SetToolTip(Me.Button7, resources.GetString("Button7.ToolTip"))
			Me.Button7.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtTotPurch, "txtTotPurch")
			Me.txtTotPurch.BackColor = Global.System.Drawing.Color.LightGreen
			Me.txtTotPurch.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotPurch.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTotPurch.Name = "txtTotPurch"
			Me.txtTotPurch.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtTotPurch, resources.GetString("txtTotPurch.ToolTip"))
			resources.ApplyResources(Me.lblTotSale, "lblTotSale")
			Me.lblTotSale.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblTotSale.CausesValidation = False
			Me.lblTotSale.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblTotSale.Name = "lblTotSale"
			Me.ToolTip1.SetToolTip(Me.lblTotSale, resources.GetString("lblTotSale.ToolTip"))
			Me.lblTotSale.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.btnPrintCashier, "btnPrintCashier")
			Me.btnPrintCashier.Name = "btnPrintCashier"
			Me.ToolTip1.SetToolTip(Me.btnPrintCashier, resources.GetString("btnPrintCashier.ToolTip"))
			Me.btnPrintCashier.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtTotSale, "txtTotSale")
			Me.txtTotSale.BackColor = Global.System.Drawing.Color.LightCoral
			Me.txtTotSale.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotSale.ForeColor = Global.System.Drawing.Color.Black
			Me.txtTotSale.Name = "txtTotSale"
			Me.txtTotSale.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtTotSale, resources.GetString("txtTotSale.ToolTip"))
			resources.ApplyResources(Me.pnlBalance, "pnlBalance")
			Me.pnlBalance.Controls.Add(Me.Label8)
			Me.pnlBalance.Controls.Add(Me.txtCapital)
			Me.pnlBalance.Controls.Add(Me.Button1)
			Me.pnlBalance.Name = "pnlBalance"
			Me.ToolTip1.SetToolTip(Me.pnlBalance, resources.GetString("pnlBalance.ToolTip"))
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			Me.ToolTip1.SetToolTip(Me.Label8, resources.GetString("Label8.ToolTip"))
			resources.ApplyResources(Me.txtCapital, "txtCapital")
			Me.txtCapital.BackColor = Global.System.Drawing.Color.FromArgb(255, 255, 192)
			Me.txtCapital.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtCapital.Name = "txtCapital"
			Me.ToolTip1.SetToolTip(Me.txtCapital, resources.GetString("txtCapital.ToolTip"))
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.Image = My.Resources.Resources._1348964394_money
			Me.Button1.Name = "Button1"
			Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
			Me.Button1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox7, "GroupBox7")
			Me.GroupBox7.Controls.Add(Me.pnlApp)
			Me.GroupBox7.Controls.Add(Me.txtBarcode)
			Me.GroupBox7.Controls.Add(Me.Button15)
			Me.GroupBox7.Controls.Add(Me.txtCustNo)
			Me.GroupBox7.Controls.Add(Me.Panel4)
			Me.GroupBox7.Controls.Add(Me.dgvUnits)
			Me.GroupBox7.Controls.Add(Me.txtOrderNo)
			Me.GroupBox7.Controls.Add(Me.Label3)
			Me.GroupBox7.Controls.Add(Me.lblBarcode)
			Me.GroupBox7.Controls.Add(Me.Label40)
			Me.GroupBox7.Controls.Add(Me.lblClient)
			Me.GroupBox7.Controls.Add(Me.cmbClient)
			Me.GroupBox7.Controls.Add(Me.btnCustAdd)
			Me.GroupBox7.Controls.Add(Me.Label28)
			Me.GroupBox7.Controls.Add(Me.txtBalance)
			Me.GroupBox7.Controls.Add(Me.rdAuto)
			Me.GroupBox7.Controls.Add(Me.rdNormal)
			Me.GroupBox7.Controls.Add(Me.CheckBox1)
			Me.GroupBox7.Controls.Add(Me.cmbUnits)
			Me.GroupBox7.Name = "GroupBox7"
			Me.GroupBox7.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox7, resources.GetString("GroupBox7.ToolTip"))
			resources.ApplyResources(Me.pnlApp, "pnlApp")
			Me.pnlApp.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlApp.Controls.Add(Me.chkPaidOnline)
			Me.pnlApp.Controls.Add(Me.label54)
			Me.pnlApp.Controls.Add(Me.txtAppFee)
			Me.pnlApp.Controls.Add(Me.cmbApps)
			Me.pnlApp.Controls.Add(Me.label53)
			Me.pnlApp.Name = "pnlApp"
			Me.ToolTip1.SetToolTip(Me.pnlApp, resources.GetString("pnlApp.ToolTip"))
			resources.ApplyResources(Me.chkPaidOnline, "chkPaidOnline")
			Me.chkPaidOnline.Name = "chkPaidOnline"
			Me.ToolTip1.SetToolTip(Me.chkPaidOnline, resources.GetString("chkPaidOnline.ToolTip"))
			Me.chkPaidOnline.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.label54, "label54")
			Me.label54.Name = "label54"
			Me.ToolTip1.SetToolTip(Me.label54, resources.GetString("label54.ToolTip"))
			resources.ApplyResources(Me.txtAppFee, "txtAppFee")
			Me.txtAppFee.Name = "txtAppFee"
			Me.ToolTip1.SetToolTip(Me.txtAppFee, resources.GetString("txtAppFee.ToolTip"))
			resources.ApplyResources(Me.cmbApps, "cmbApps")
			Me.cmbApps.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbApps.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbApps.BackColor = Global.System.Drawing.Color.White
			Me.cmbApps.FormattingEnabled = True
			Me.cmbApps.Name = "cmbApps"
			Me.ToolTip1.SetToolTip(Me.cmbApps, resources.GetString("cmbApps.ToolTip"))
			resources.ApplyResources(Me.label53, "label53")
			Me.label53.Name = "label53"
			Me.ToolTip1.SetToolTip(Me.label53, resources.GetString("label53.ToolTip"))
			resources.ApplyResources(Me.txtBarcode, "txtBarcode")
			Me.txtBarcode.Name = "txtBarcode"
			Me.ToolTip1.SetToolTip(Me.txtBarcode, resources.GetString("txtBarcode.ToolTip"))
			resources.ApplyResources(Me.Button15, "Button15")
			Me.Button15.Name = "Button15"
			Me.ToolTip1.SetToolTip(Me.Button15, resources.GetString("Button15.ToolTip"))
			Me.Button15.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtCustNo, "txtCustNo")
			Me.txtCustNo.Name = "txtCustNo"
			Me.ToolTip1.SetToolTip(Me.txtCustNo, resources.GetString("txtCustNo.ToolTip"))
			resources.ApplyResources(Me.Panel4, "Panel4")
			Me.Panel4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel4.Controls.Add(Me.rdApp)
			Me.Panel4.Controls.Add(Me.rdIn2)
			Me.Panel4.Controls.Add(Me.rdIn)
			Me.Panel4.Controls.Add(Me.rdOut)
			Me.Panel4.Name = "Panel4"
			Me.ToolTip1.SetToolTip(Me.Panel4, resources.GetString("Panel4.ToolTip"))
			resources.ApplyResources(Me.rdApp, "rdApp")
			Me.rdApp.Name = "rdApp"
			Me.ToolTip1.SetToolTip(Me.rdApp, resources.GetString("rdApp.ToolTip"))
			Me.rdApp.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdIn2, "rdIn2")
			Me.rdIn2.Name = "rdIn2"
			Me.ToolTip1.SetToolTip(Me.rdIn2, resources.GetString("rdIn2.ToolTip"))
			Me.rdIn2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdIn, "rdIn")
			Me.rdIn.Checked = True
			Me.rdIn.Name = "rdIn"
			Me.rdIn.TabStop = True
			Me.ToolTip1.SetToolTip(Me.rdIn, resources.GetString("rdIn.ToolTip"))
			Me.rdIn.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdOut, "rdOut")
			Me.rdOut.Name = "rdOut"
			Me.ToolTip1.SetToolTip(Me.rdOut, resources.GetString("rdOut.ToolTip"))
			Me.rdOut.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.dgvUnits, "dgvUnits")
			Me.dgvUnits.AllowUserToAddRows = False
			Me.dgvUnits.AllowUserToDeleteRows = False
			Me.dgvUnits.AllowUserToResizeColumns = False
			Me.dgvUnits.AllowUserToResizeRows = False
			Me.dgvUnits.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvUnits.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvUnits.ColumnHeadersVisible = False
			dataGridViewCellStyle20.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle20.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle20.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle20.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle20.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle20.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle20.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.dgvUnits.DefaultCellStyle = dataGridViewCellStyle20
			Me.dgvUnits.MultiSelect = False
			Me.dgvUnits.Name = "dgvUnits"
			Me.dgvUnits.[ReadOnly] = True
			Me.dgvUnits.RowHeadersVisible = False
			Me.ToolTip1.SetToolTip(Me.dgvUnits, resources.GetString("dgvUnits.ToolTip"))
			resources.ApplyResources(Me.txtOrderNo, "txtOrderNo")
			Me.txtOrderNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtOrderNo.Name = "txtOrderNo"
			Me.txtOrderNo.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtOrderNo, resources.GetString("txtOrderNo.ToolTip"))
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label3.Name = "Label3"
			Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
			resources.ApplyResources(Me.lblBarcode, "lblBarcode")
			Me.lblBarcode.Name = "lblBarcode"
			Me.ToolTip1.SetToolTip(Me.lblBarcode, resources.GetString("lblBarcode.ToolTip"))
			resources.ApplyResources(Me.Label40, "Label40")
			Me.Label40.Name = "Label40"
			Me.ToolTip1.SetToolTip(Me.Label40, resources.GetString("Label40.ToolTip"))
			resources.ApplyResources(Me.lblClient, "lblClient")
			Me.lblClient.Name = "lblClient"
			Me.ToolTip1.SetToolTip(Me.lblClient, resources.GetString("lblClient.ToolTip"))
			resources.ApplyResources(Me.cmbClient, "cmbClient")
			Me.cmbClient.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbClient.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbClient.BackColor = Global.System.Drawing.Color.White
			Me.cmbClient.FormattingEnabled = True
			Me.cmbClient.Name = "cmbClient"
			Me.ToolTip1.SetToolTip(Me.cmbClient, resources.GetString("cmbClient.ToolTip"))
			resources.ApplyResources(Me.btnCustAdd, "btnCustAdd")
			Me.btnCustAdd.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnCustAdd.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnCustAdd.Name = "btnCustAdd"
			Me.ToolTip1.SetToolTip(Me.btnCustAdd, resources.GetString("btnCustAdd.ToolTip"))
			Me.btnCustAdd.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.Label28, "Label28")
			Me.Label28.Name = "Label28"
			Me.ToolTip1.SetToolTip(Me.Label28, resources.GetString("Label28.ToolTip"))
			resources.ApplyResources(Me.txtBalance, "txtBalance")
			Me.txtBalance.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtBalance.Name = "txtBalance"
			Me.txtBalance.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtBalance, resources.GetString("txtBalance.ToolTip"))
			resources.ApplyResources(Me.rdAuto, "rdAuto")
			Me.rdAuto.Name = "rdAuto"
			Me.ToolTip1.SetToolTip(Me.rdAuto, resources.GetString("rdAuto.ToolTip"))
			Me.rdAuto.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdNormal, "rdNormal")
			Me.rdNormal.Checked = True
			Me.rdNormal.Name = "rdNormal"
			Me.rdNormal.TabStop = True
			Me.ToolTip1.SetToolTip(Me.rdNormal, resources.GetString("rdNormal.ToolTip"))
			Me.rdNormal.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.CheckBox1, "CheckBox1")
			Me.CheckBox1.Name = "CheckBox1"
			Me.ToolTip1.SetToolTip(Me.CheckBox1, resources.GetString("CheckBox1.ToolTip"))
			Me.CheckBox1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbUnits, "cmbUnits")
			Me.cmbUnits.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbUnits.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbUnits.BackColor = Global.System.Drawing.SystemColors.InactiveCaption
			Me.cmbUnits.DropDownHeight = 400
			Me.cmbUnits.DropDownWidth = 257
			Me.cmbUnits.FormattingEnabled = True
			Me.cmbUnits.Name = "cmbUnits"
			Me.ToolTip1.SetToolTip(Me.cmbUnits, resources.GetString("cmbUnits.ToolTip"))
			resources.ApplyResources(Me.Panel3, "Panel3")
			Me.Panel3.Controls.Add(Me.Label17)
			Me.Panel3.Controls.Add(Me.Label4)
			Me.Panel3.Controls.Add(Me.Label19)
			Me.Panel3.Controls.Add(Me.Label29)
			Me.Panel3.Controls.Add(Me.Label23)
			Me.Panel3.Controls.Add(Me.Label24)
			Me.Panel3.Controls.Add(Me.txtExchangeValD)
			Me.Panel3.Controls.Add(Me.txtVal2D)
			Me.Panel3.Controls.Add(Me.cmbCurrency)
			Me.Panel3.Controls.Add(Me.cmbGroups)
			Me.Panel3.Controls.Add(Me.Label9)
			Me.Panel3.Controls.Add(Me.txtExpireDate)
			Me.Panel3.Name = "Panel3"
			Me.ToolTip1.SetToolTip(Me.Panel3, resources.GetString("Panel3.ToolTip"))
			resources.ApplyResources(Me.Label17, "Label17")
			Me.Label17.Name = "Label17"
			Me.ToolTip1.SetToolTip(Me.Label17, resources.GetString("Label17.ToolTip"))
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
			resources.ApplyResources(Me.Label19, "Label19")
			Me.Label19.Name = "Label19"
			Me.ToolTip1.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip"))
			resources.ApplyResources(Me.Label29, "Label29")
			Me.Label29.Name = "Label29"
			Me.ToolTip1.SetToolTip(Me.Label29, resources.GetString("Label29.ToolTip"))
			resources.ApplyResources(Me.Label23, "Label23")
			Me.Label23.Name = "Label23"
			Me.ToolTip1.SetToolTip(Me.Label23, resources.GetString("Label23.ToolTip"))
			resources.ApplyResources(Me.Label24, "Label24")
			Me.Label24.Name = "Label24"
			Me.ToolTip1.SetToolTip(Me.Label24, resources.GetString("Label24.ToolTip"))
			resources.ApplyResources(Me.txtExchangeValD, "txtExchangeValD")
			Me.txtExchangeValD.Name = "txtExchangeValD"
			Me.ToolTip1.SetToolTip(Me.txtExchangeValD, resources.GetString("txtExchangeValD.ToolTip"))
			resources.ApplyResources(Me.txtVal2D, "txtVal2D")
			Me.txtVal2D.Name = "txtVal2D"
			Me.ToolTip1.SetToolTip(Me.txtVal2D, resources.GetString("txtVal2D.ToolTip"))
			resources.ApplyResources(Me.cmbCurrency, "cmbCurrency")
			Me.cmbCurrency.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCurrency.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCurrency.BackColor = Global.System.Drawing.SystemColors.InactiveCaption
			Me.cmbCurrency.DropDownHeight = 400
			Me.cmbCurrency.DropDownWidth = 257
			Me.cmbCurrency.FormattingEnabled = True
			Me.cmbCurrency.Name = "cmbCurrency"
			Me.ToolTip1.SetToolTip(Me.cmbCurrency, resources.GetString("cmbCurrency.ToolTip"))
			resources.ApplyResources(Me.cmbGroups, "cmbGroups")
			Me.cmbGroups.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGroups.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGroups.BackColor = Global.System.Drawing.SystemColors.InactiveCaption
			Me.cmbGroups.DropDownHeight = 400
			Me.cmbGroups.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGroups.DropDownWidth = 257
			Me.cmbGroups.FormattingEnabled = True
			Me.cmbGroups.Name = "cmbGroups"
			Me.ToolTip1.SetToolTip(Me.cmbGroups, resources.GetString("cmbGroups.ToolTip"))
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			Me.ToolTip1.SetToolTip(Me.Label9, resources.GetString("Label9.ToolTip"))
			resources.ApplyResources(Me.txtExpireDate, "txtExpireDate")
			Me.txtExpireDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtExpireDate.Name = "txtExpireDate"
			Me.ToolTip1.SetToolTip(Me.txtExpireDate, resources.GetString("txtExpireDate.ToolTip"))
			resources.ApplyResources(Me.Button5, "Button5")
			Me.Button5.Name = "Button5"
			Me.ToolTip1.SetToolTip(Me.Button5, resources.GetString("Button5.ToolTip"))
			Me.Button5.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button2, "Button2")
			Me.Button2.Name = "Button2"
			Me.ToolTip1.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
			Me.Button2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Label27, "Label27")
			Me.Label27.Name = "Label27"
			Me.ToolTip1.SetToolTip(Me.Label27, resources.GetString("Label27.ToolTip"))
			resources.ApplyResources(Me.TextBox1, "TextBox1")
			Me.TextBox1.Name = "TextBox1"
			Me.ToolTip1.SetToolTip(Me.TextBox1, resources.GetString("TextBox1.ToolTip"))
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Controls.Add(Me.Label25)
			Me.Panel1.Controls.Add(Me.txtRem)
			Me.Panel1.Controls.Add(Me.txtPaid)
			Me.Panel1.Controls.Add(Me.Label26)
			Me.Panel1.Name = "Panel1"
			Me.ToolTip1.SetToolTip(Me.Panel1, resources.GetString("Panel1.ToolTip"))
			resources.ApplyResources(Me.Label25, "Label25")
			Me.Label25.Name = "Label25"
			Me.ToolTip1.SetToolTip(Me.Label25, resources.GetString("Label25.ToolTip"))
			resources.ApplyResources(Me.txtRem, "txtRem")
			Me.txtRem.BackColor = Global.System.Drawing.Color.White
			Me.txtRem.Name = "txtRem"
			Me.txtRem.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtRem, resources.GetString("txtRem.ToolTip"))
			resources.ApplyResources(Me.txtPaid, "txtPaid")
			Me.txtPaid.Name = "txtPaid"
			Me.ToolTip1.SetToolTip(Me.txtPaid, resources.GetString("txtPaid.ToolTip"))
			resources.ApplyResources(Me.Label26, "Label26")
			Me.Label26.Name = "Label26"
			Me.ToolTip1.SetToolTip(Me.Label26, resources.GetString("Label26.ToolTip"))
			resources.ApplyResources(Me.Label22, "Label22")
			Me.Label22.Name = "Label22"
			Me.ToolTip1.SetToolTip(Me.Label22, resources.GetString("Label22.ToolTip"))
			resources.ApplyResources(Me.lblPerc, "lblPerc")
			Me.lblPerc.Name = "lblPerc"
			Me.ToolTip1.SetToolTip(Me.lblPerc, resources.GetString("lblPerc.ToolTip"))
			resources.ApplyResources(Me.Label21, "Label21")
			Me.Label21.Name = "Label21"
			Me.ToolTip1.SetToolTip(Me.Label21, resources.GetString("Label21.ToolTip"))
			resources.ApplyResources(Me.Button3, "Button3")
			Me.Button3.Name = "Button3"
			Me.ToolTip1.SetToolTip(Me.Button3, resources.GetString("Button3.ToolTip"))
			Me.Button3.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtInvTime, "txtInvTime")
			Me.txtInvTime.Format = Global.System.Windows.Forms.DateTimePickerFormat.Time
			Me.txtInvTime.Name = "txtInvTime"
			Me.txtInvTime.ShowUpDown = True
			Me.ToolTip1.SetToolTip(Me.txtInvTime, resources.GetString("txtInvTime.ToolTip"))
			Dim txtInvTime As Global.System.Windows.Forms.DateTimePicker = Me.txtInvTime
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 10, 4, 15, 13, 0, 0)
			txtInvTime.Value = dateTime
			resources.ApplyResources(Me.Label20, "Label20")
			Me.Label20.CausesValidation = False
			Me.Label20.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Label20.Name = "Label20"
			Me.ToolTip1.SetToolTip(Me.Label20, resources.GetString("Label20.ToolTip"))
			Me.Label20.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.GroupBox3, "GroupBox3")
			Me.GroupBox3.BackColor = Global.System.Drawing.Color.White
			Me.GroupBox3.Controls.Add(Me.cmbCenter)
			Me.GroupBox3.Controls.Add(Me.lblcostcenter)
			Me.GroupBox3.Controls.Add(Me.chkInTax)
			Me.GroupBox3.Controls.Add(Me.pnlPay)
			Me.GroupBox3.Controls.Add(Me.cmbAddSalesMen)
			Me.GroupBox3.Controls.Add(Me.Button4)
			Me.GroupBox3.Controls.Add(Me.cmbSalesMen)
			Me.GroupBox3.Controls.Add(Me.lblSalesMen)
			Me.GroupBox3.Controls.Add(Me.cmbProcType)
			Me.GroupBox3.Controls.Add(Me.Label15)
			Me.GroupBox3.Controls.Add(Me.txtDate)
			Me.GroupBox3.Controls.Add(Me.cmbStock)
			Me.GroupBox3.Controls.Add(Me.Label16)
			Me.GroupBox3.Controls.Add(Me.cmbType)
			Me.GroupBox3.Controls.Add(Me.cmbSafe)
			Me.GroupBox3.Controls.Add(Me.Label12)
			Me.GroupBox3.Controls.Add(Me.Label18)
			Me.GroupBox3.Controls.Add(Me.Label13)
			Me.GroupBox3.Controls.Add(Me.txtSrcInvNo)
			Me.GroupBox3.Controls.Add(Me.lblSrcInvNo)
			Me.GroupBox3.Controls.Add(Me.txtNo)
			Me.GroupBox3.Controls.Add(Me.Label14)
			Me.GroupBox3.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox3, resources.GetString("GroupBox3.ToolTip"))
			resources.ApplyResources(Me.cmbCenter, "cmbCenter")
			Me.cmbCenter.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCenter.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCenter.FormattingEnabled = True
			Me.cmbCenter.Items.AddRange(New Object() { resources.GetString("cmbCenter.Items"), resources.GetString("cmbCenter.Items1"), resources.GetString("cmbCenter.Items2"), resources.GetString("cmbCenter.Items3"), resources.GetString("cmbCenter.Items4"), resources.GetString("cmbCenter.Items5"), resources.GetString("cmbCenter.Items6"), resources.GetString("cmbCenter.Items7"), resources.GetString("cmbCenter.Items8"), resources.GetString("cmbCenter.Items9") })
			Me.cmbCenter.Name = "cmbCenter"
			Me.ToolTip1.SetToolTip(Me.cmbCenter, resources.GetString("cmbCenter.ToolTip"))
			resources.ApplyResources(Me.lblcostcenter, "lblcostcenter")
			Me.lblcostcenter.Name = "lblcostcenter"
			Me.ToolTip1.SetToolTip(Me.lblcostcenter, resources.GetString("lblcostcenter.ToolTip"))
			resources.ApplyResources(Me.chkInTax, "chkInTax")
			Me.chkInTax.Name = "chkInTax"
			Me.ToolTip1.SetToolTip(Me.chkInTax, resources.GetString("chkInTax.ToolTip"))
			Me.chkInTax.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.pnlPay, "pnlPay")
			Me.pnlPay.Controls.Add(Me.rdCash)
			Me.pnlPay.Controls.Add(Me.rdNetwork)
			Me.pnlPay.Name = "pnlPay"
			Me.ToolTip1.SetToolTip(Me.pnlPay, resources.GetString("pnlPay.ToolTip"))
			resources.ApplyResources(Me.rdCash, "rdCash")
			Me.rdCash.Checked = True
			Me.rdCash.Name = "rdCash"
			Me.rdCash.TabStop = True
			Me.ToolTip1.SetToolTip(Me.rdCash, resources.GetString("rdCash.ToolTip"))
			Me.rdCash.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdNetwork, "rdNetwork")
			Me.rdNetwork.Name = "rdNetwork"
			Me.ToolTip1.SetToolTip(Me.rdNetwork, resources.GetString("rdNetwork.ToolTip"))
			Me.rdNetwork.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbAddSalesMen, "cmbAddSalesMen")
			Me.cmbAddSalesMen.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.cmbAddSalesMen.ForeColor = Global.System.Drawing.Color.Lime
			Me.cmbAddSalesMen.Name = "cmbAddSalesMen"
			Me.ToolTip1.SetToolTip(Me.cmbAddSalesMen, resources.GetString("cmbAddSalesMen.ToolTip"))
			Me.cmbAddSalesMen.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.Button4, "Button4")
			Me.Button4.Image = My.Resources.Resources.Actions_go_down_icon
			Me.Button4.Name = "Button4"
			Me.ToolTip1.SetToolTip(Me.Button4, resources.GetString("Button4.ToolTip"))
			Me.Button4.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbSalesMen, "cmbSalesMen")
			Me.cmbSalesMen.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSalesMen.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSalesMen.BackColor = Global.System.Drawing.Color.White
			Me.cmbSalesMen.FormattingEnabled = True
			Me.cmbSalesMen.Name = "cmbSalesMen"
			Me.ToolTip1.SetToolTip(Me.cmbSalesMen, resources.GetString("cmbSalesMen.ToolTip"))
			resources.ApplyResources(Me.lblSalesMen, "lblSalesMen")
			Me.lblSalesMen.Name = "lblSalesMen"
			Me.ToolTip1.SetToolTip(Me.lblSalesMen, resources.GetString("lblSalesMen.ToolTip"))
			resources.ApplyResources(Me.cmbProcType, "cmbProcType")
			Me.cmbProcType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbProcType.FormattingEnabled = True
			Me.cmbProcType.Items.AddRange(New Object() { resources.GetString("cmbProcType.Items"), resources.GetString("cmbProcType.Items1"), resources.GetString("cmbProcType.Items2"), resources.GetString("cmbProcType.Items3") })
			Me.cmbProcType.Name = "cmbProcType"
			Me.ToolTip1.SetToolTip(Me.cmbProcType, resources.GetString("cmbProcType.ToolTip"))
			resources.ApplyResources(Me.Label15, "Label15")
			Me.Label15.Name = "Label15"
			Me.ToolTip1.SetToolTip(Me.Label15, resources.GetString("Label15.ToolTip"))
			resources.ApplyResources(Me.txtDate, "txtDate")
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDate.Name = "txtDate"
			Me.ToolTip1.SetToolTip(Me.txtDate, resources.GetString("txtDate.ToolTip"))
			resources.ApplyResources(Me.cmbStock, "cmbStock")
			Me.cmbStock.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbStock.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbStock.FormattingEnabled = True
			Me.cmbStock.Name = "cmbStock"
			Me.ToolTip1.SetToolTip(Me.cmbStock, resources.GetString("cmbStock.ToolTip"))
			resources.ApplyResources(Me.Label16, "Label16")
			Me.Label16.Name = "Label16"
			Me.ToolTip1.SetToolTip(Me.Label16, resources.GetString("Label16.ToolTip"))
			resources.ApplyResources(Me.cmbType, "cmbType")
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { resources.GetString("cmbType.Items"), resources.GetString("cmbType.Items1") })
			Me.cmbType.Name = "cmbType"
			Me.ToolTip1.SetToolTip(Me.cmbType, resources.GetString("cmbType.ToolTip"))
			resources.ApplyResources(Me.cmbSafe, "cmbSafe")
			Me.cmbSafe.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafe.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafe.FormattingEnabled = True
			Me.cmbSafe.Name = "cmbSafe"
			Me.ToolTip1.SetToolTip(Me.cmbSafe, resources.GetString("cmbSafe.ToolTip"))
			resources.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
			resources.ApplyResources(Me.Label18, "Label18")
			Me.Label18.Name = "Label18"
			Me.ToolTip1.SetToolTip(Me.Label18, resources.GetString("Label18.ToolTip"))
			resources.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
			resources.ApplyResources(Me.txtSrcInvNo, "txtSrcInvNo")
			Me.txtSrcInvNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSrcInvNo.Name = "txtSrcInvNo"
			Me.ToolTip1.SetToolTip(Me.txtSrcInvNo, resources.GetString("txtSrcInvNo.ToolTip"))
			resources.ApplyResources(Me.lblSrcInvNo, "lblSrcInvNo")
			Me.lblSrcInvNo.Name = "lblSrcInvNo"
			Me.ToolTip1.SetToolTip(Me.lblSrcInvNo, resources.GetString("lblSrcInvNo.ToolTip"))
			resources.ApplyResources(Me.txtNo, "txtNo")
			Me.txtNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.ToolTip1.SetToolTip(Me.txtNo, resources.GetString("txtNo.ToolTip"))
			resources.ApplyResources(Me.Label14, "Label14")
			Me.Label14.Name = "Label14"
			Me.ToolTip1.SetToolTip(Me.Label14, resources.GetString("Label14.ToolTip"))
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Me.TabPage2.Name = "TabPage2"
			Me.ToolTip1.SetToolTip(Me.TabPage2, resources.GetString("TabPage2.ToolTip"))
			Me.TabPage2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip"))
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle21.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle21.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle21.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle21.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle21.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle21.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle21.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column10, Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column1 })
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.ToolTip1.SetToolTip(Me.dgvSrch, resources.GetString("dgvSrch.ToolTip"))
			resources.ApplyResources(Me.Column10, "Column10")
			Me.Column10.Name = "Column10"
			resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtSrchNo)
			Me.GroupBox6.Controls.Add(Me.cmbProcTypeSrch)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label10)
			Me.GroupBox6.Controls.Add(Me.Label11)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			Me.ToolTip1.SetToolTip(Me.GroupBox6, resources.GetString("GroupBox6.ToolTip"))
			resources.ApplyResources(Me.txtSrchNo, "txtSrchNo")
			Me.txtSrchNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSrchNo.Name = "txtSrchNo"
			Me.ToolTip1.SetToolTip(Me.txtSrchNo, resources.GetString("txtSrchNo.ToolTip"))
			resources.ApplyResources(Me.cmbProcTypeSrch, "cmbProcTypeSrch")
			Me.cmbProcTypeSrch.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbProcTypeSrch.FormattingEnabled = True
			Me.cmbProcTypeSrch.Items.AddRange(New Object() { resources.GetString("cmbProcTypeSrch.Items"), resources.GetString("cmbProcTypeSrch.Items1"), resources.GetString("cmbProcTypeSrch.Items2"), resources.GetString("cmbProcTypeSrch.Items3") })
			Me.cmbProcTypeSrch.Name = "cmbProcTypeSrch"
			Me.ToolTip1.SetToolTip(Me.cmbProcTypeSrch, resources.GetString("cmbProcTypeSrch.ToolTip"))
			resources.ApplyResources(Me.txtToDate, "txtToDate")
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtToDate.Name = "txtToDate"
			Me.ToolTip1.SetToolTip(Me.txtToDate, resources.GetString("txtToDate.ToolTip"))
			Dim txtToDate As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate.Value = dateTime
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
			resources.ApplyResources(Me.txtFromDate, "txtFromDate")
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtFromDate.Name = "txtFromDate"
			Me.ToolTip1.SetToolTip(Me.txtFromDate, resources.GetString("txtFromDate.ToolTip"))
			Dim txtFromDate As Global.System.Windows.Forms.DateTimePicker = Me.txtFromDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtFromDate.Value = dateTime
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			Me.Label10.Tag = ""
			Me.ToolTip1.SetToolTip(Me.Label10, resources.GetString("Label10.ToolTip"))
			resources.ApplyResources(Me.Label11, "Label11")
			Me.Label11.Name = "Label11"
			Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
			resources.ApplyResources(Me.btnSearch, "btnSearch")
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Me.btnSearch.Name = "btnSearch"
			Me.ToolTip1.SetToolTip(Me.btnSearch, resources.GetString("btnSearch.ToolTip"))
			Me.btnSearch.UseVisualStyleBackColor = False
			Me.Timer1.Interval = 800
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox1)
			Me.KeyPreview = True
			Me.Name = "frmSalePurchRest"
			Me.ShowIcon = False
			Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.Panel13.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.Panel6.ResumeLayout(False)
			Me.Panel5.ResumeLayout(False)
			CType(Me.dgvitemData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel11.ResumeLayout(False)
			Me.pnlQuan.ResumeLayout(False)
			Me.Panel10.ResumeLayout(False)
			Me.Panel10.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.pnlGroups.ResumeLayout(False)
			Me.Panel14.ResumeLayout(False)
			CType(Me.dgvGroups, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlTawla.ResumeLayout(False)
			CType(Me.dgvTawlas, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dgvTawlaGroups, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel15.ResumeLayout(False)
			Me.Panel7.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel16.ResumeLayout(False)
			Me.Panel16.PerformLayout()
			CType(Me.NumericUpDown1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlBalance.ResumeLayout(False)
			Me.GroupBox7.ResumeLayout(False)
			Me.GroupBox7.PerformLayout()
			Me.pnlApp.ResumeLayout(False)
			Me.pnlApp.PerformLayout()
			Me.Panel4.ResumeLayout(False)
			CType(Me.dgvUnits, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.pnlPay.ResumeLayout(False)
			Me.pnlPay.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
