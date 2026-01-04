Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSalaryPay
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents btnPrintRslt As Button
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents cmbEmpSrch As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNoSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtSalaryAdd As TextBox
    Friend WithEvents txtSalarySlf As TextBox
    Friend WithEvents txtSalarySub As TextBox
    Friend WithEvents txtSum As Label
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtTotSalary As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSalaryPay))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.btnPrintRslt = New Global.System.Windows.Forms.Button()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.cmbEmpSrch = New Global.System.Windows.Forms.ComboBox()
			Me.txtNoSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSalarySlf = New Global.System.Windows.Forms.TextBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.cmbYear = New Global.System.Windows.Forms.ComboBox()
			Me.cmbMonth = New Global.System.Windows.Forms.ComboBox()
			Me.cmbEmp = New Global.System.Windows.Forms.ComboBox()
			Me.cmbBranch = New Global.System.Windows.Forms.ComboBox()
			Me.txtNet = New Global.System.Windows.Forms.TextBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtSalarySub = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtSalaryAdd = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtTotSalary = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtEmp = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.GroupBox6.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel3.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.btnPrintRslt)
			Me.GroupBox6.Controls.Add(Me.Label16)
			Me.GroupBox6.Controls.Add(Me.cmbEmpSrch)
			Me.GroupBox6.Controls.Add(Me.txtNoSrch)
			Me.GroupBox6.Controls.Add(Me.Label15)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			resources.ApplyResources(Me.btnPrintRslt, "btnPrintRslt")
			Me.btnPrintRslt.BackColor = Global.System.Drawing.Color.White
			Me.btnPrintRslt.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnPrintRslt.Image = My.Resources.Resources.print
			Me.btnPrintRslt.Name = "btnPrintRslt"
			Me.btnPrintRslt.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.Label16, "Label16")
			Me.Label16.Name = "Label16"
			resources.ApplyResources(Me.cmbEmpSrch, "cmbEmpSrch")
			Me.cmbEmpSrch.FormattingEnabled = True
			Me.cmbEmpSrch.Name = "cmbEmpSrch"
			resources.ApplyResources(Me.txtNoSrch, "txtNoSrch")
			Me.txtNoSrch.Name = "txtNoSrch"
			resources.ApplyResources(Me.Label15, "Label15")
			Me.Label15.Name = "Label15"
			resources.ApplyResources(Me.txtToDate, "txtToDate")
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
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
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Controls.Add(Me.GroupBox2)
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Controls.Add(Me.txtSalarySlf)
			Me.Panel1.Controls.Add(Me.Label18)
			Me.Panel1.Controls.Add(Me.txtNo)
			Me.Panel1.Controls.Add(Me.Label14)
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.txtNotes)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.cmbYear)
			Me.Panel1.Controls.Add(Me.cmbMonth)
			Me.Panel1.Controls.Add(Me.cmbEmp)
			Me.Panel1.Controls.Add(Me.cmbBranch)
			Me.Panel1.Controls.Add(Me.txtNet)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.txtSalarySub)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.txtSalaryAdd)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.txtTotSalary)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Controls.Add(Me.txtEmp)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.txtDate)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtSalarySlf, "txtSalarySlf")
			Me.txtSalarySlf.Name = "txtSalarySlf"
			resources.ApplyResources(Me.Label18, "Label18")
			Me.Label18.Name = "Label18"
			resources.ApplyResources(Me.txtNo, "txtNo")
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			resources.ApplyResources(Me.Label14, "Label14")
			Me.Label14.Name = "Label14"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.txtNotes, "txtNotes")
			Me.txtNotes.Name = "txtNotes"
			resources.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.cmbYear, "cmbYear")
			Me.cmbYear.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbYear.FormattingEnabled = True
			Me.cmbYear.Name = "cmbYear"
			resources.ApplyResources(Me.cmbMonth, "cmbMonth")
			Me.cmbMonth.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbMonth.FormattingEnabled = True
			Me.cmbMonth.Items.AddRange(New Object() { resources.GetString("cmbMonth.Items"), resources.GetString("cmbMonth.Items1"), resources.GetString("cmbMonth.Items2"), resources.GetString("cmbMonth.Items3"), resources.GetString("cmbMonth.Items4"), resources.GetString("cmbMonth.Items5"), resources.GetString("cmbMonth.Items6"), resources.GetString("cmbMonth.Items7"), resources.GetString("cmbMonth.Items8"), resources.GetString("cmbMonth.Items9"), resources.GetString("cmbMonth.Items10"), resources.GetString("cmbMonth.Items11") })
			Me.cmbMonth.Name = "cmbMonth"
			resources.ApplyResources(Me.cmbEmp, "cmbEmp")
			Me.cmbEmp.FormattingEnabled = True
			Me.cmbEmp.Name = "cmbEmp"
			resources.ApplyResources(Me.cmbBranch, "cmbBranch")
			Me.cmbBranch.FormattingEnabled = True
			Me.cmbBranch.Name = "cmbBranch"
			resources.ApplyResources(Me.txtNet, "txtNet")
			Me.txtNet.Name = "txtNet"
			Me.txtNet.[ReadOnly] = True
			resources.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			resources.ApplyResources(Me.txtSalarySub, "txtSalarySub")
			Me.txtSalarySub.Name = "txtSalarySub"
			resources.ApplyResources(Me.Label11, "Label11")
			Me.Label11.Name = "Label11"
			resources.ApplyResources(Me.txtSalaryAdd, "txtSalaryAdd")
			Me.txtSalaryAdd.Name = "txtSalaryAdd"
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			resources.ApplyResources(Me.txtTotSalary, "txtTotSalary")
			Me.txtTotSalary.Name = "txtTotSalary"
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			resources.ApplyResources(Me.txtEmp, "txtEmp")
			Me.txtEmp.Name = "txtEmp"
			Me.txtEmp.[ReadOnly] = True
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtDate, "txtDate")
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDate.Name = "txtDate"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Controls.Add(Me.Panel3)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.AllowUserToAddRows = False
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.dgvSrch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column4, Me.Column5, Me.Column9, Me.Column2, Me.Column3, Me.Column6 })
			Me.dgvSrch.MultiSelect = False
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.White
			Me.dgvSrch.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column5.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			resources.ApplyResources(Me.Column9, "Column9")
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column9.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column9.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Panel3, "Panel3")
			Me.Panel3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Panel3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel3.Controls.Add(Me.Label17)
			Me.Panel3.Controls.Add(Me.txtSum)
			Me.Panel3.Name = "Panel3"
			resources.ApplyResources(Me.Label17, "Label17")
			Me.Label17.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Label17.Name = "Label17"
			resources.ApplyResources(Me.txtSum, "txtSum")
			Me.txtSum.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSum.Name = "txtSum"
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.TabControl1)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.GripStyle = Global.System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
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
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Resources._exit
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.panel2)
			Me.KeyPreview = True
			Me.Name = "frmSalaryPay"
			Me.ShowIcon = False
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel3.ResumeLayout(False)
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.TabControl1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
