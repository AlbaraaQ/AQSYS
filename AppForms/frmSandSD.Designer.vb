Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSandSD
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
    Friend WithEvents chkActvVAT As CheckBox
    Friend WithEvents chkPriceInVAT As CheckBox
    Friend WithEvents cmbAccounts As ComboBox
    Friend WithEvents cmbCenter As ComboBox
    Friend WithEvents cmbCheckType As ComboBox
    Friend WithEvents cmbEda3 As ComboBox
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents cmbSalesMan As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents lblcostcenter As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents pnlVAT As Panel
    Friend WithEvents rdCash As RadioButton
    Friend WithEvents rdCheck As RadioButton
    Friend WithEvents rdEmp As RadioButton
    Friend WithEvents rdPDeal As RadioButton
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtBankCheck As TextBox
    Friend WithEvents txtCheckDate As DateTimePicker
    Friend WithEvents txtCheckNo As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtSrchNo As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtVATPerc As TextBox
    Friend WithEvents txtVal As TextBox
    Friend WithEvents txtVal2 As TextBox
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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSandSD))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewTextBoxColumn1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.cmbCheckType = New Global.System.Windows.Forms.ComboBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtBankCheck = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtCheckDate = New Global.System.Windows.Forms.DateTimePicker()
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
			Me.pnlVAT = New Global.System.Windows.Forms.Panel()
			Me.txtVAT = New Global.System.Windows.Forms.TextBox()
			Me.txtVal2 = New Global.System.Windows.Forms.TextBox()
			Me.txtVATPerc = New Global.System.Windows.Forms.TextBox()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.chkPriceInVAT = New Global.System.Windows.Forms.CheckBox()
			Me.chkActvVAT = New Global.System.Windows.Forms.CheckBox()
			Me.cmbCenter = New Global.System.Windows.Forms.ComboBox()
			Me.lblcostcenter = New Global.System.Windows.Forms.Label()
			Me.txtValD = New Global.System.Windows.Forms.TextBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.rdEmp = New Global.System.Windows.Forms.RadioButton()
			Me.rdPDeal = New Global.System.Windows.Forms.RadioButton()
			Me.cmbAccounts = New Global.System.Windows.Forms.ComboBox()
			Me.cmbEmp = New Global.System.Windows.Forms.ComboBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtVal = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtSrchNo = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.pnlVAT.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox6.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column1, Me.Column2 })
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.cmbCheckType, "cmbCheckType")
			Me.cmbCheckType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCheckType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCheckType.FormattingEnabled = True
			Me.cmbCheckType.Name = "cmbCheckType"
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Controls.Add(Me.GroupBox2)
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Controls.Add(Me.GroupBox5)
			Me.GroupBox2.Controls.Add(Me.GroupBox3)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.GroupBox5, "GroupBox5")
			Me.GroupBox5.Controls.Add(Me.Panel1)
			Me.GroupBox5.Controls.Add(Me.rdCash)
			Me.GroupBox5.Controls.Add(Me.rdCheck)
			Me.GroupBox5.Controls.Add(Me.cmbSalesMan)
			Me.GroupBox5.Controls.Add(Me.cmbEda3)
			Me.GroupBox5.Controls.Add(Me.txtNotes)
			Me.GroupBox5.Controls.Add(Me.Label14)
			Me.GroupBox5.Controls.Add(Me.Label12)
			Me.GroupBox5.Controls.Add(Me.Label8)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.TabStop = False
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Controls.Add(Me.txtBankCheck)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.txtCheckDate)
			Me.Panel1.Controls.Add(Me.cmbCheckType)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.txtCheckNo)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtBankCheck, "txtBankCheck")
			Me.txtBankCheck.Name = "txtBankCheck"
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			resources.ApplyResources(Me.txtCheckDate, "txtCheckDate")
			Me.txtCheckDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtCheckDate.Name = "txtCheckDate"
			resources.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			resources.ApplyResources(Me.Label11, "Label11")
			Me.Label11.Name = "Label11"
			resources.ApplyResources(Me.txtCheckNo, "txtCheckNo")
			Me.txtCheckNo.Name = "txtCheckNo"
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			resources.ApplyResources(Me.rdCash, "rdCash")
			Me.rdCash.Checked = True
			Me.rdCash.Name = "rdCash"
			Me.rdCash.TabStop = True
			Me.rdCash.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdCheck, "rdCheck")
			Me.rdCheck.Name = "rdCheck"
			Me.rdCheck.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbSalesMan, "cmbSalesMan")
			Me.cmbSalesMan.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSalesMan.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSalesMan.FormattingEnabled = True
			Me.cmbSalesMan.Name = "cmbSalesMan"
			resources.ApplyResources(Me.cmbEda3, "cmbEda3")
			Me.cmbEda3.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEda3.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEda3.FormattingEnabled = True
			Me.cmbEda3.Name = "cmbEda3"
			resources.ApplyResources(Me.txtNotes, "txtNotes")
			Me.txtNotes.Name = "txtNotes"
			resources.ApplyResources(Me.Label14, "Label14")
			Me.Label14.Name = "Label14"
			resources.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			resources.ApplyResources(Me.GroupBox3, "GroupBox3")
			Me.GroupBox3.Controls.Add(Me.pnlVAT)
			Me.GroupBox3.Controls.Add(Me.chkActvVAT)
			Me.GroupBox3.Controls.Add(Me.cmbCenter)
			Me.GroupBox3.Controls.Add(Me.lblcostcenter)
			Me.GroupBox3.Controls.Add(Me.txtValD)
			Me.GroupBox3.Controls.Add(Me.Label18)
			Me.GroupBox3.Controls.Add(Me.Label17)
			Me.GroupBox3.Controls.Add(Me.txtDate)
			Me.GroupBox3.Controls.Add(Me.rdEmp)
			Me.GroupBox3.Controls.Add(Me.rdPDeal)
			Me.GroupBox3.Controls.Add(Me.cmbAccounts)
			Me.GroupBox3.Controls.Add(Me.cmbEmp)
			Me.GroupBox3.Controls.Add(Me.Label7)
			Me.GroupBox3.Controls.Add(Me.Label4)
			Me.GroupBox3.Controls.Add(Me.txtNo)
			Me.GroupBox3.Controls.Add(Me.Label5)
			Me.GroupBox3.Controls.Add(Me.txtVal)
			Me.GroupBox3.Controls.Add(Me.Label3)
			Me.GroupBox3.Controls.Add(Me.Label6)
			Me.GroupBox3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.UseCompatibleTextRendering = True
			resources.ApplyResources(Me.pnlVAT, "pnlVAT")
			Me.pnlVAT.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.pnlVAT.Controls.Add(Me.txtVAT)
			Me.pnlVAT.Controls.Add(Me.txtVal2)
			Me.pnlVAT.Controls.Add(Me.txtVATPerc)
			Me.pnlVAT.Controls.Add(Me.Label20)
			Me.pnlVAT.Controls.Add(Me.Label19)
			Me.pnlVAT.Controls.Add(Me.Label16)
			Me.pnlVAT.Controls.Add(Me.chkPriceInVAT)
			Me.pnlVAT.Name = "pnlVAT"
			resources.ApplyResources(Me.txtVAT, "txtVAT")
			Me.txtVAT.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtVAT.Name = "txtVAT"
			Me.txtVAT.[ReadOnly] = True
			resources.ApplyResources(Me.txtVal2, "txtVal2")
			Me.txtVal2.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtVal2.Name = "txtVal2"
			resources.ApplyResources(Me.txtVATPerc, "txtVATPerc")
			Me.txtVATPerc.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtVATPerc.Name = "txtVATPerc"
			Me.txtVATPerc.[ReadOnly] = True
			resources.ApplyResources(Me.Label20, "Label20")
			Me.Label20.Name = "Label20"
			resources.ApplyResources(Me.Label19, "Label19")
			Me.Label19.Name = "Label19"
			resources.ApplyResources(Me.Label16, "Label16")
			Me.Label16.Name = "Label16"
			resources.ApplyResources(Me.chkPriceInVAT, "chkPriceInVAT")
			Me.chkPriceInVAT.Name = "chkPriceInVAT"
			Me.chkPriceInVAT.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.chkActvVAT, "chkActvVAT")
			Me.chkActvVAT.Name = "chkActvVAT"
			Me.chkActvVAT.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbCenter, "cmbCenter")
			Me.cmbCenter.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCenter.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCenter.FormattingEnabled = True
			Me.cmbCenter.Items.AddRange(New Object() { resources.GetString("cmbCenter.Items"), resources.GetString("cmbCenter.Items1"), resources.GetString("cmbCenter.Items2"), resources.GetString("cmbCenter.Items3"), resources.GetString("cmbCenter.Items4"), resources.GetString("cmbCenter.Items5"), resources.GetString("cmbCenter.Items6"), resources.GetString("cmbCenter.Items7"), resources.GetString("cmbCenter.Items8"), resources.GetString("cmbCenter.Items9") })
			Me.cmbCenter.Name = "cmbCenter"
			resources.ApplyResources(Me.lblcostcenter, "lblcostcenter")
			Me.lblcostcenter.Name = "lblcostcenter"
			resources.ApplyResources(Me.txtValD, "txtValD")
			Me.txtValD.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtValD.Name = "txtValD"
			resources.ApplyResources(Me.Label18, "Label18")
			Me.Label18.Name = "Label18"
			resources.ApplyResources(Me.Label17, "Label17")
			Me.Label17.Name = "Label17"
			resources.ApplyResources(Me.txtDate, "txtDate")
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDate.Name = "txtDate"
			Dim txtDate As Global.System.Windows.Forms.DateTimePicker = Me.txtDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDate.Value = dateTime
			resources.ApplyResources(Me.rdEmp, "rdEmp")
			Me.rdEmp.Checked = True
			Me.rdEmp.Name = "rdEmp"
			Me.rdEmp.TabStop = True
			Me.rdEmp.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdPDeal, "rdPDeal")
			Me.rdPDeal.Name = "rdPDeal"
			Me.rdPDeal.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbAccounts, "cmbAccounts")
			Me.cmbAccounts.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbAccounts.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbAccounts.FormattingEnabled = True
			Me.cmbAccounts.Items.AddRange(New Object() { resources.GetString("cmbAccounts.Items"), resources.GetString("cmbAccounts.Items1"), resources.GetString("cmbAccounts.Items2"), resources.GetString("cmbAccounts.Items3"), resources.GetString("cmbAccounts.Items4"), resources.GetString("cmbAccounts.Items5"), resources.GetString("cmbAccounts.Items6"), resources.GetString("cmbAccounts.Items7"), resources.GetString("cmbAccounts.Items8"), resources.GetString("cmbAccounts.Items9"), resources.GetString("cmbAccounts.Items10") })
			Me.cmbAccounts.Name = "cmbAccounts"
			resources.ApplyResources(Me.cmbEmp, "cmbEmp")
			Me.cmbEmp.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEmp.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEmp.FormattingEnabled = True
			Me.cmbEmp.Items.AddRange(New Object() { resources.GetString("cmbEmp.Items"), resources.GetString("cmbEmp.Items1") })
			Me.cmbEmp.Name = "cmbEmp"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.txtNo, "txtNo")
			Me.txtNo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtVal, "txtVal")
			Me.txtVal.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtVal.Name = "txtVal"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtSrchNo)
			Me.GroupBox6.Controls.Add(Me.Label15)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			resources.ApplyResources(Me.txtSrchNo, "txtSrchNo")
			Me.txtSrchNo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSrchNo.Name = "txtSrchNo"
			resources.ApplyResources(Me.Label15, "Label15")
			Me.Label15.Name = "Label15"
			resources.ApplyResources(Me.txtToDate, "txtToDate")
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate.Value = dateTime
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtFromDate, "txtFromDate")
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtFromDate.Name = "txtFromDate"
			Dim txtFromDate As Global.System.Windows.Forms.DateTimePicker = Me.txtFromDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtFromDate.Value = dateTime
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.btnSearch, "btnSearch")
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Image = My.Resources.Resources.previous
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Resources._exit
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Image = My.Resources.Resources._next
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Image = My.Resources.Resources.last
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.TabControl1)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
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
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "frmSandSD"
			Me.ShowIcon = False
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.pnlVAT.ResumeLayout(False)
			Me.pnlVAT.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
