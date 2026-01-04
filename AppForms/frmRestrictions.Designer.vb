Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRestrictions
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtISBalanced As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNoSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtTotCredit As TextBox
    Friend WithEvents txtTotDebt As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRestrictions))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.dgvDetails = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewTextBoxColumn3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column13 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbState = New Global.System.Windows.Forms.ComboBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtISBalanced = New Global.System.Windows.Forms.TextBox()
			Me.txtTotCredit = New Global.System.Windows.Forms.TextBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.txtTotDebt = New Global.System.Windows.Forms.TextBox()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtNoSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvDetails, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.TabPage1.Controls.Add(Me.GroupBox1)
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.GroupBox2)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.White
			Me.GroupBox2.Controls.Add(Me.Button1)
			Me.GroupBox2.Controls.Add(Me.dgvDetails)
			Me.GroupBox2.Controls.Add(Me.txtDate)
			Me.GroupBox2.Controls.Add(Me.txtNotes)
			Me.GroupBox2.Controls.Add(Me.Label5)
			Me.GroupBox2.Controls.Add(Me.cmbState)
			Me.GroupBox2.Controls.Add(Me.Label13)
			Me.GroupBox2.Controls.Add(Me.cmbType)
			Me.GroupBox2.Controls.Add(Me.Label9)
			Me.GroupBox2.Controls.Add(Me.txtISBalanced)
			Me.GroupBox2.Controls.Add(Me.txtTotCredit)
			Me.GroupBox2.Controls.Add(Me.TextBox3)
			Me.GroupBox2.Controls.Add(Me.txtTotDebt)
			Me.GroupBox2.Controls.Add(Me.txtNo)
			Me.GroupBox2.Controls.Add(Me.Label12)
			Me.GroupBox2.Controls.Add(Me.Label7)
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.Name = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			Me.dgvDetails.AllowUserToAddRows = False
			Me.dgvDetails.AllowUserToDeleteRows = False
			Me.dgvDetails.AllowUserToOrderColumns = True
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Arial Rounded MT Bold", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			resources.ApplyResources(Me.dgvDetails, "dgvDetails")
			Me.dgvDetails.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvDetails.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.dgvDetails.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvDetails.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvDetails.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn3, Me.Column6, Me.Column10, Me.Column11, Me.Column12, Me.Column13 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.DefaultCellStyle = dataGridViewCellStyle3
			Me.dgvDetails.EditMode = Global.System.Windows.Forms.DataGridViewEditMode.EditOnEnter
			Me.dgvDetails.GridColor = Global.System.Drawing.Color.Silver
			Me.dgvDetails.MultiSelect = False
			Me.dgvDetails.Name = "dgvDetails"
			Me.dgvDetails.[ReadOnly] = True
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvDetails.RowHeadersVisible = False
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("Arial", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle5
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6
			resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column10, "Column10")
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			resources.ApplyResources(Me.Column11, "Column11")
			Me.Column11.Name = "Column11"
			Me.Column11.[ReadOnly] = True
			resources.ApplyResources(Me.Column12, "Column12")
			Me.Column12.Name = "Column12"
			Me.Column12.[ReadOnly] = True
			Me.Column12.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column12.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			resources.ApplyResources(Me.Column13, "Column13")
			Me.Column13.Name = "Column13"
			Me.Column13.[ReadOnly] = True
			resources.ApplyResources(Me.txtDate, "txtDate")
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDate.Name = "txtDate"
			Dim txtDate As Global.System.Windows.Forms.DateTimePicker = Me.txtDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDate.Value = dateTime
			resources.ApplyResources(Me.txtNotes, "txtNotes")
			Me.txtNotes.Name = "txtNotes"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.cmbState, "cmbState")
			Me.cmbState.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbState.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbState.FormattingEnabled = True
			Me.cmbState.Items.AddRange(New Object() { resources.GetString("cmbState.Items"), resources.GetString("cmbState.Items1") })
			Me.cmbState.Name = "cmbState"
			resources.ApplyResources(Me.Label13, "Label13")
			Me.Label13.Name = "Label13"
			resources.ApplyResources(Me.cmbType, "cmbType")
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { resources.GetString("cmbType.Items"), resources.GetString("cmbType.Items1"), resources.GetString("cmbType.Items2"), resources.GetString("cmbType.Items3"), resources.GetString("cmbType.Items4"), resources.GetString("cmbType.Items5"), resources.GetString("cmbType.Items6"), resources.GetString("cmbType.Items7"), resources.GetString("cmbType.Items8"), resources.GetString("cmbType.Items9") })
			Me.cmbType.Name = "cmbType"
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			resources.ApplyResources(Me.txtISBalanced, "txtISBalanced")
			Me.txtISBalanced.Name = "txtISBalanced"
			Me.txtISBalanced.[ReadOnly] = True
			resources.ApplyResources(Me.txtTotCredit, "txtTotCredit")
			Me.txtTotCredit.Name = "txtTotCredit"
			Me.txtTotCredit.[ReadOnly] = True
			resources.ApplyResources(Me.TextBox3, "TextBox3")
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.[ReadOnly] = True
			resources.ApplyResources(Me.txtTotDebt, "txtTotDebt")
			Me.txtTotDebt.Name = "txtTotDebt"
			Me.txtTotDebt.[ReadOnly] = True
			resources.ApplyResources(Me.txtNo, "txtNo")
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			resources.ApplyResources(Me.Label12, "Label12")
			Me.Label12.Name = "Label12"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle7.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle7.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle7.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle7.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle7.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4 })
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtNoSrch)
			Me.GroupBox6.Controls.Add(Me.Label3)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			resources.ApplyResources(Me.txtNoSrch, "txtNoSrch")
			Me.txtNoSrch.Name = "txtNoSrch"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
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
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			resources.ApplyResources(Me.btnDelete, "btnDelete")
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Name = "btnDelete"
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Name = "btnClose"
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "frmRestrictions"
			Me.ShowIcon = False
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			CType(Me.dgvDetails, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
