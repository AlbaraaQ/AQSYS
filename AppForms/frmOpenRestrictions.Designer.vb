Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmOpenRestrictions
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewComboBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
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
    Friend WithEvents chkPostponed As CheckBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtDiff As TextBox
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtISBalanced As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNoSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtTotCredit As TextBox
    Friend WithEvents txtTotCreditAr As TextBox
    Friend WithEvents txtTotDebt As TextBox
    Friend WithEvents txtTotDebtAr As TextBox

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
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvDetails = New Global.System.Windows.Forms.DataGridView()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.chkPostponed = New Global.System.Windows.Forms.CheckBox()
			Me.txtTotDebtAr = New Global.System.Windows.Forms.TextBox()
			Me.txtTotDebt = New Global.System.Windows.Forms.TextBox()
			Me.txtDiff = New Global.System.Windows.Forms.TextBox()
			Me.txtISBalanced = New Global.System.Windows.Forms.TextBox()
			Me.txtTotCreditAr = New Global.System.Windows.Forms.TextBox()
			Me.txtTotCredit = New Global.System.Windows.Forms.TextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.cmbState = New Global.System.Windows.Forms.ComboBox()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.ToolStrip2 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator3 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator4 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtNoSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.DataGridViewTextBoxColumn3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column13 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			CType(Me.dgvDetails, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.ToolStrip2.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.SuspendLayout()
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			tabControl.Location = point
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.RightToLeftLayout = True
			Me.TabControl1.SelectedIndex = 0
			Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1081, 499)
			tabControl2.Size = size
			Me.TabControl1.TabIndex = 4
			Me.TabPage1.Controls.Add(Me.GroupBox1)
			Dim tabPage As Global.System.Windows.Forms.TabPage = Me.TabPage1
			point = New Global.System.Drawing.Point(4, 22)
			tabPage.Location = point
			Me.TabPage1.Name = "TabPage1"
			Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3)
			tabPage2.Padding = padding
			Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage1
			size = New Global.System.Drawing.Size(1073, 473)
			tabPage3.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "            القيد الإفتتاحي            "
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox1.Controls.Add(Me.GroupBox2)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(3, 3)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(1067, 467)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 7
			Me.GroupBox1.TabStop = False
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.White
			Me.GroupBox2.Controls.Add(Me.Panel4)
			Me.GroupBox2.Controls.Add(Me.Panel3)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Controls.Add(Me.panel2)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(3, 16)
			groupBox3.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(1061, 448)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.Panel4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel4.Controls.Add(Me.GroupBox3)
			Me.Panel4.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel4
			point = New Global.System.Drawing.Point(3, 90)
			panel.Location = point
			Me.Panel4.Name = "Panel4"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel4
			size = New Global.System.Drawing.Size(1055, 246)
			panel2.Size = size
			Me.Panel4.TabIndex = 17
			Me.GroupBox3.Controls.Add(Me.dgvDetails)
			Me.GroupBox3.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(0, 0)
			groupBox5.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(1053, 244)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 18
			Me.GroupBox3.TabStop = False
			Me.dgvDetails.AllowUserToDeleteRows = False
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.dgvDetails.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvDetails.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.dgvDetails.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvDetails.ColumnHeadersHeight = 35
			Me.dgvDetails.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn3, Me.Column11, Me.Column12, Me.Column6, Me.Column10, Me.Column13, Me.Column3 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.DefaultCellStyle = dataGridViewCellStyle3
			Me.dgvDetails.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvDetails.EditMode = Global.System.Windows.Forms.DataGridViewEditMode.EditOnEnter
			Me.dgvDetails.GridColor = Global.System.Drawing.Color.Silver
			Dim dgvDetails As Global.System.Windows.Forms.Control = Me.dgvDetails
			point = New Global.System.Drawing.Point(3, 16)
			dgvDetails.Location = point
			Me.dgvDetails.MultiSelect = False
			Me.dgvDetails.Name = "dgvDetails"
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvDetails.RowHeadersVisible = False
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle5
			Dim dgvDetails2 As Global.System.Windows.Forms.Control = Me.dgvDetails
			size = New Global.System.Drawing.Size(1047, 225)
			dgvDetails2.Size = size
			Me.dgvDetails.TabIndex = 5
			Me.Panel3.Controls.Add(Me.chkPostponed)
			Me.Panel3.Controls.Add(Me.txtTotDebtAr)
			Me.Panel3.Controls.Add(Me.txtTotDebt)
			Me.Panel3.Controls.Add(Me.txtDiff)
			Me.Panel3.Controls.Add(Me.txtISBalanced)
			Me.Panel3.Controls.Add(Me.txtTotCreditAr)
			Me.Panel3.Controls.Add(Me.txtTotCredit)
			Me.Panel3.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel3
			point = New Global.System.Drawing.Point(3, 336)
			panel3.Location = point
			Me.Panel3.Name = "Panel3"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel3
			size = New Global.System.Drawing.Size(1055, 54)
			panel4.Size = size
			Me.Panel3.TabIndex = 16
			Me.chkPostponed.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkPostponed.AutoSize = True
			Dim chkPostponed As Global.System.Windows.Forms.Control = Me.chkPostponed
			point = New Global.System.Drawing.Point(605, 33)
			chkPostponed.Location = point
			Me.chkPostponed.Name = "chkPostponed"
			Dim chkPostponed2 As Global.System.Windows.Forms.Control = Me.chkPostponed
			size = New Global.System.Drawing.Size(74, 17)
			chkPostponed2.Size = size
			Me.chkPostponed.TabIndex = 14
			Me.chkPostponed.Text = "قيد معلق"
			Me.chkPostponed.UseVisualStyleBackColor = True
			Me.txtTotDebtAr.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotDebtAr.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotDebtAr As Global.System.Windows.Forms.Control = Me.txtTotDebtAr
			point = New Global.System.Drawing.Point(778, 28)
			txtTotDebtAr.Location = point
			Me.txtTotDebtAr.Name = "txtTotDebtAr"
			Me.txtTotDebtAr.[ReadOnly] = True
			Dim txtTotDebtAr2 As Global.System.Windows.Forms.Control = Me.txtTotDebtAr
			size = New Global.System.Drawing.Size(270, 24)
			txtTotDebtAr2.Size = size
			Me.txtTotDebtAr.TabIndex = 6
			Me.txtTotDebtAr.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTotDebt.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotDebt.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotDebt As Global.System.Windows.Forms.Control = Me.txtTotDebt
			point = New Global.System.Drawing.Point(778, 2)
			txtTotDebt.Location = point
			Me.txtTotDebt.Name = "txtTotDebt"
			Me.txtTotDebt.[ReadOnly] = True
			Dim txtTotDebt2 As Global.System.Windows.Forms.Control = Me.txtTotDebt
			size = New Global.System.Drawing.Size(270, 24)
			txtTotDebt2.Size = size
			Me.txtTotDebt.TabIndex = 6
			Me.txtTotDebt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtDiff.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDiff.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtDiff As Global.System.Windows.Forms.Control = Me.txtDiff
			point = New Global.System.Drawing.Point(524, 3)
			txtDiff.Location = point
			Me.txtDiff.Name = "txtDiff"
			Me.txtDiff.[ReadOnly] = True
			Dim txtDiff2 As Global.System.Windows.Forms.Control = Me.txtDiff
			size = New Global.System.Drawing.Size(248, 24)
			txtDiff2.Size = size
			Me.txtDiff.TabIndex = 13
			Me.txtDiff.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtISBalanced.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtISBalanced.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtISBalanced As Global.System.Windows.Forms.Control = Me.txtISBalanced
			point = New Global.System.Drawing.Point(78, 2)
			txtISBalanced.Location = point
			Me.txtISBalanced.Name = "txtISBalanced"
			Me.txtISBalanced.[ReadOnly] = True
			Dim txtISBalanced2 As Global.System.Windows.Forms.Control = Me.txtISBalanced
			size = New Global.System.Drawing.Size(102, 24)
			txtISBalanced2.Size = size
			Me.txtISBalanced.TabIndex = 13
			Me.txtISBalanced.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTotCreditAr.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotCreditAr.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotCreditAr As Global.System.Windows.Forms.Control = Me.txtTotCreditAr
			point = New Global.System.Drawing.Point(186, 28)
			txtTotCreditAr.Location = point
			Me.txtTotCreditAr.Name = "txtTotCreditAr"
			Me.txtTotCreditAr.[ReadOnly] = True
			Dim txtTotCreditAr2 As Global.System.Windows.Forms.Control = Me.txtTotCreditAr
			size = New Global.System.Drawing.Size(332, 24)
			txtTotCreditAr2.Size = size
			Me.txtTotCreditAr.TabIndex = 8
			Me.txtTotCreditAr.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtTotCredit.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotCredit.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotCredit As Global.System.Windows.Forms.Control = Me.txtTotCredit
			point = New Global.System.Drawing.Point(186, 3)
			txtTotCredit.Location = point
			Me.txtTotCredit.Name = "txtTotCredit"
			Me.txtTotCredit.[ReadOnly] = True
			Dim txtTotCredit2 As Global.System.Windows.Forms.Control = Me.txtTotCredit
			size = New Global.System.Drawing.Size(332, 24)
			txtTotCredit2.Size = size
			Me.txtTotCredit.TabIndex = 8
			Me.txtTotCredit.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.txtDate)
			Me.Panel1.Controls.Add(Me.txtNo)
			Me.Panel1.Controls.Add(Me.txtNotes)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.cmbState)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel5 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 16)
			panel5.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel6 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(1055, 74)
			panel6.Size = size
			Me.Panel1.TabIndex = 15
			Me.Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label13.AutoSize = True
			Me.Label13.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(594, 10)
			label.Location = point
			Me.Label13.Name = "Label13"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(57, 13)
			label2.Size = size
			Me.Label13.TabIndex = 5
			Me.Label13.Text = "حالة القيد"
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Me.Label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(960, 11)
			label3.Location = point
			Me.Label7.Name = "Label7"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(53, 13)
			label4.Size = size
			Me.Label7.TabIndex = 0
			Me.Label7.Text = "رقم القيد"
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label12.AutoSize = True
			Me.Label12.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(792, 9)
			label5.Location = point
			Me.Label12.Name = "Label12"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(60, 13)
			label6.Size = size
			Me.Label12.TabIndex = 0
			Me.Label12.Text = "تاريخ القيد"
			Me.txtDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDate As Global.System.Windows.Forms.Control = Me.txtDate
			point = New Global.System.Drawing.Point(679, 6)
			txtDate.Location = point
			Me.txtDate.Name = "txtDate"
			Dim txtDate2 As Global.System.Windows.Forms.Control = Me.txtDate
			size = New Global.System.Drawing.Size(109, 20)
			txtDate2.Size = size
			Me.txtDate.TabIndex = 1
			Dim txtDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDate3.Value = dateTime
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(861, 6)
			txtNo.Location = point
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(86, 20)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 0
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtNotes.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNotes As Global.System.Windows.Forms.Control = Me.txtNotes
			point = New Global.System.Drawing.Point(495, 31)
			txtNotes.Location = point
			Me.txtNotes.Multiline = True
			Me.txtNotes.Name = "txtNotes"
			Dim txtNotes2 As Global.System.Windows.Forms.Control = Me.txtNotes
			size = New Global.System.Drawing.Size(452, 37)
			txtNotes2.Size = size
			Me.txtNotes.TabIndex = 3
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(958, 34)
			label7.Location = point
			Me.Label2.Name = "Label2"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(55, 13)
			label8.Size = size
			Me.Label2.TabIndex = 13
			Me.Label2.Text = "بيان القيد"
			Me.cmbState.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbState.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbState.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbState.FormattingEnabled = True
			Me.cmbState.Items.AddRange(New Object() { "معتمد", "لاغي / معلق" })
			Dim cmbState As Global.System.Windows.Forms.Control = Me.cmbState
			point = New Global.System.Drawing.Point(495, 6)
			cmbState.Location = point
			Me.cmbState.Name = "cmbState"
			Dim cmbState2 As Global.System.Windows.Forms.Control = Me.cmbState
			size = New Global.System.Drawing.Size(96, 21)
			cmbState2.Size = size
			Me.cmbState.TabIndex = 2
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.ToolStrip2)
			Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel7 As Global.System.Windows.Forms.Control = Me.panel2
			point = New Global.System.Drawing.Point(3, 390)
			panel7.Location = point
			Me.panel2.Name = "panel2"
			Dim panel8 As Global.System.Windows.Forms.Control = Me.panel2
			size = New Global.System.Drawing.Size(1055, 55)
			panel8.Size = size
			Me.panel2.TabIndex = 14
			Me.ToolStrip2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ToolStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.ToolStripSeparator3, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.ToolStripSeparator4, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.ToolStrip2
			point = New Global.System.Drawing.Point(0, 0)
			toolStrip.Location = point
			Me.ToolStrip2.Name = "ToolStrip2"
			Me.ToolStrip2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.ToolStrip2
			size = New Global.System.Drawing.Size(1053, 53)
			toolStrip2.Size = size
			Me.ToolStrip2.TabIndex = 2
			Me.ToolStrip2.Text = "ToolStrip2"
			Me.btnNew.AutoSize = False
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Image = My.Resources.Resources._new
			Me.btnNew.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNew.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNew.Name = "btnNew"
			Dim btnNew As Global.System.Windows.Forms.ToolStripItem = Me.btnNew
			size = New Global.System.Drawing.Size(50, 50)
			btnNew.Size = size
			Me.btnNew.Text = "جديد"
			Me.btnSave.AutoSize = False
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Image = My.Resources.Resources.save
			Me.btnSave.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSave.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnSave.Name = "btnSave"
			Dim btnSave As Global.System.Windows.Forms.ToolStripItem = Me.btnSave
			size = New Global.System.Drawing.Size(50, 50)
			btnSave.Size = size
			Me.btnSave.Text = "حفظ"
			Me.btnDelete.AutoSize = False
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Image = My.Resources.Resources.delete
			Me.btnDelete.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnDelete.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnDelete.Name = "btnDelete"
			Dim btnDelete As Global.System.Windows.Forms.ToolStripItem = Me.btnDelete
			size = New Global.System.Drawing.Size(50, 50)
			btnDelete.Size = size
			Me.btnDelete.Text = "حذف"
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator3
			size = New Global.System.Drawing.Size(6, 53)
			toolStripSeparator.Size = size
			Me.btnLast.AutoSize = False
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Image = My.Resources.Resources.last
			Me.btnLast.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnLast.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnLast.Name = "btnLast"
			Dim btnLast As Global.System.Windows.Forms.ToolStripItem = Me.btnLast
			size = New Global.System.Drawing.Size(50, 50)
			btnLast.Size = size
			Me.btnLast.Text = "الأخير"
			Me.btnNext.AutoSize = False
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Image = My.Resources.Resources._next
			Me.btnNext.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNext.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnNext.Name = "btnNext"
			Dim btnNext As Global.System.Windows.Forms.ToolStripItem = Me.btnNext
			size = New Global.System.Drawing.Size(50, 50)
			btnNext.Size = size
			Me.btnNext.Text = "التالي"
			Me.btnPrevious.AutoSize = False
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Image = My.Resources.Resources.previous
			Me.btnPrevious.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrevious.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrevious.Name = "btnPrevious"
			Dim btnPrevious As Global.System.Windows.Forms.ToolStripItem = Me.btnPrevious
			size = New Global.System.Drawing.Size(50, 50)
			btnPrevious.Size = size
			Me.btnPrevious.Text = "السابق"
			Me.btnFirst.AutoSize = False
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnFirst.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnFirst.Name = "btnFirst"
			Dim btnFirst As Global.System.Windows.Forms.ToolStripItem = Me.btnFirst
			size = New Global.System.Drawing.Size(50, 50)
			btnFirst.Size = size
			Me.btnFirst.Text = "الأول"
			Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripSeparator4
			size = New Global.System.Drawing.Size(6, 53)
			toolStripSeparator2.Size = size
			Me.btnPrint.AutoSize = False
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrint.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint As Global.System.Windows.Forms.ToolStripItem = Me.btnPrint
			size = New Global.System.Drawing.Size(50, 50)
			btnPrint.Size = size
			Me.btnPrint.Text = "طباعة"
			Me.btnClose.AutoSize = False
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = My.Resources.Resources._exit
			Me.btnClose.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnClose.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnClose.Name = "btnClose"
			Dim btnClose As Global.System.Windows.Forms.ToolStripItem = Me.btnClose
			size = New Global.System.Drawing.Size(50, 50)
			btnClose.Size = size
			Me.btnClose.Text = "خروج"
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Dim tabPage4 As Global.System.Windows.Forms.TabPage = Me.TabPage2
			point = New Global.System.Drawing.Point(4, 22)
			tabPage4.Location = point
			Me.TabPage2.Name = "TabPage2"
			Dim tabPage5 As Global.System.Windows.Forms.Control = Me.TabPage2
			padding = New Global.System.Windows.Forms.Padding(3)
			tabPage5.Padding = padding
			Dim tabPage6 As Global.System.Windows.Forms.Control = Me.TabPage2
			size = New Global.System.Drawing.Size(1073, 473)
			tabPage6.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "                    البحــــــــــث              "
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox4.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox4
			point = New Global.System.Drawing.Point(3, 93)
			groupBox7.Location = point
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(1067, 377)
			groupBox8.Size = size
			Me.GroupBox4.TabIndex = 9
			Me.GroupBox4.TabStop = False
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle6.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle6.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column5, Me.Column4 })
			Me.dgvSrch.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvSrch As Global.System.Windows.Forms.Control = Me.dgvSrch
			point = New Global.System.Drawing.Point(3, 17)
			dgvSrch.Location = point
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvSrch2 As Global.System.Windows.Forms.Control = Me.dgvSrch
			size = New Global.System.Drawing.Size(1061, 357)
			dgvSrch2.Size = size
			Me.dgvSrch.TabIndex = 0
			Me.Column1.HeaderText = "رقم القيد"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column2.HeaderText = "تاريخ القيد"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 130
			Me.Column5.HeaderText = "حالة القيد"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column4.HeaderText = "البيان"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 400
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtNoSrch)
			Me.GroupBox6.Controls.Add(Me.Label8)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label10)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label11)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GroupBox6.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox6
			point = New Global.System.Drawing.Point(3, 3)
			groupBox9.Location = point
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(1067, 90)
			groupBox10.Size = size
			Me.GroupBox6.TabIndex = 8
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "بحث"
			Me.txtNoSrch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNoSrch As Global.System.Windows.Forms.Control = Me.txtNoSrch
			point = New Global.System.Drawing.Point(827, 21)
			txtNoSrch.Location = point
			Me.txtNoSrch.Name = "txtNoSrch"
			Dim txtNoSrch2 As Global.System.Windows.Forms.Control = Me.txtNoSrch
			size = New Global.System.Drawing.Size(124, 21)
			txtNoSrch2.Size = size
			Me.txtNoSrch.TabIndex = 14
			Me.txtNoSrch.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.AutoSize = True
			Me.Label8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(964, 26)
			label9.Location = point
			Me.Label8.Name = "Label8"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(53, 13)
			label10.Size = size
			Me.Label8.TabIndex = 13
			Me.Label8.Text = "رقم القيد"
			Me.txtToDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtToDate As Global.System.Windows.Forms.Control = Me.txtToDate
			point = New Global.System.Drawing.Point(593, 51)
			txtToDate.Location = point
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate2 As Global.System.Windows.Forms.Control = Me.txtToDate
			size = New Global.System.Drawing.Size(124, 21)
			txtToDate2.Size = size
			Me.txtToDate.TabIndex = 1
			Dim txtToDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate3.Value = dateTime
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.AutoSize = True
			Me.Label10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(728, 55)
			label11.Location = point
			Me.Label10.Name = "Label10"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(56, 13)
			label12.Size = size
			Me.Label10.TabIndex = 11
			Me.Label10.Text = "الى تاريخ"
			Me.txtFromDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtFromDate As Global.System.Windows.Forms.Control = Me.txtFromDate
			point = New Global.System.Drawing.Point(827, 51)
			txtFromDate.Location = point
			Me.txtFromDate.Name = "txtFromDate"
			Dim txtFromDate2 As Global.System.Windows.Forms.Control = Me.txtFromDate
			size = New Global.System.Drawing.Size(124, 21)
			txtFromDate2.Size = size
			Me.txtFromDate.TabIndex = 0
			Dim txtFromDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtFromDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtFromDate3.Value = dateTime
			Me.Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label11.AutoSize = True
			Me.Label11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(964, 55)
			label13.Location = point
			Me.Label11.Name = "Label11"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(52, 13)
			label14.Size = size
			Me.Label11.TabIndex = 12
			Me.Label11.Text = "من تاريخ"
			Me.btnSearch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Me.btnSearch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSearch As Global.System.Windows.Forms.Control = Me.btnSearch
			point = New Global.System.Drawing.Point(404, 21)
			btnSearch.Location = point
			Me.btnSearch.Name = "btnSearch"
			Dim btnSearch2 As Global.System.Windows.Forms.Control = Me.btnSearch
			size = New Global.System.Drawing.Size(89, 48)
			btnSearch2.Size = size
			Me.btnSearch.TabIndex = 2
			Me.btnSearch.UseVisualStyleBackColor = False
			Me.Timer1.Interval = 200
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7
			Me.DataGridViewTextBoxColumn3.HeaderText = "م"
			Me.DataGridViewTextBoxColumn3.MinimumWidth = 7
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn3.Width = 40
			Me.Column11.HeaderText = "كود الحساب"
			Me.Column11.Name = "Column11"
			Me.Column11.Width = 110
			Me.Column12.HeaderText = "اسم الحساب"
			Me.Column12.Name = "Column12"
			Me.Column12.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column12.Width = 200
			Me.Column6.HeaderText = "مدين"
			Me.Column6.Name = "Column6"
			Me.Column6.Width = 70
			Me.Column10.HeaderText = "دائن"
			Me.Column10.Name = "Column10"
			Me.Column10.Width = 70
			Me.Column13.HeaderText = "البيان"
			Me.Column13.Name = "Column13"
			Me.Column13.Width = 300
			Me.Column3.HeaderText = ""
			Me.Column3.Name = "Column3"
			Me.Column3.Text = "حذف"
			Me.Column3.ToolTipText = "حذف"
			Me.Column3.UseColumnTextForButtonValue = True
			Me.Column3.Width = 70
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(1081, 499)
			Me.ClientSize = size
			Me.Controls.Add(Me.TabControl1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmOpenRestrictions"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "القيود الإفتتاحية"
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.GroupBox3.ResumeLayout(False)
			CType(Me.dgvDetails, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ToolStrip2.ResumeLayout(False)
			Me.ToolStrip2.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
