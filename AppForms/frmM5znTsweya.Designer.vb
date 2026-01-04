Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmM5znTsweya
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewButtonColumn
    Friend WithEvents Column12 As DataGridViewComboBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents cmbAccName As ComboBox
    Friend WithEvents cmbCenter As ComboBox
    Friend WithEvents cmbSafe As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents label4 As Label
    Friend WithEvents txtAccCode As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtNoSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents txtRefNoSrch As TextBox
    Friend WithEvents txtToDate As DateTimePicker

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
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmM5znTsweya))
			Dim dataGridViewCellStyle8 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.DataGridViewTextBoxColumn3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
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
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.cmbAccName = New Global.System.Windows.Forms.ComboBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtAccCode = New Global.System.Windows.Forms.TextBox()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.cmbCenter = New Global.System.Windows.Forms.ComboBox()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.txtRefNo = New Global.System.Windows.Forms.TextBox()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.cmbSafe = New Global.System.Windows.Forms.ComboBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.DataGridViewTextBoxColumn2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.DataGridViewTextBoxColumn1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtRefNoSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.txtNoSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel3.SuspendLayout()
			Me.ToolStrip2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.SuspendLayout()
			Me.btnPrint.AutoSize = False
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Image = My.Resources.Resources.print
			Me.btnPrint.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrint.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint As Global.System.Windows.Forms.ToolStripItem = Me.btnPrint
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(50, 50)
			btnPrint.Size = size
			Me.btnPrint.Text = "طباعة"
			Me.TabPage1.Controls.Add(Me.Panel2)
			Me.TabPage1.Controls.Add(Me.Panel1)
			Dim tabPage As Global.System.Windows.Forms.TabPage = Me.TabPage1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 22)
			tabPage.Location = point
			Me.TabPage1.Name = "TabPage1"
			Dim tabPage2 As Global.System.Windows.Forms.Control = Me.TabPage1
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3)
			tabPage2.Padding = padding
			Dim tabPage3 As Global.System.Windows.Forms.Control = Me.TabPage1
			size = New Global.System.Drawing.Size(780, 422)
			tabPage3.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "     ادخل البيانات        "
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.Panel2.Controls.Add(Me.dgvItems)
			Me.Panel2.Controls.Add(Me.Panel4)
			Me.Panel2.Controls.Add(Me.Panel3)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(3, 115)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(774, 304)
			panel2.Size = size
			Me.Panel2.TabIndex = 3
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvItems.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.dgvItems.ColumnHeadersBorderStyle = Global.System.Windows.Forms.DataGridViewHeaderBorderStyle.None
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn3, Me.Column4, Me.Column12, Me.Column7, Me.Column9, Me.Column5, Me.Column6, Me.Column8, Me.Column11 })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.DefaultCellStyle = dataGridViewCellStyle3
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvItems.EditMode = Global.System.Windows.Forms.DataGridViewEditMode.EditOnEnter
			Me.dgvItems.GridColor = Global.System.Drawing.Color.Silver
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(0, 0)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(774, 240)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 10
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6
			Me.DataGridViewTextBoxColumn3.HeaderText = "الباركود"
			Me.DataGridViewTextBoxColumn3.MinimumWidth = 7
			Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
			Me.DataGridViewTextBoxColumn3.Width = 90
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Column4.DefaultCellStyle = dataGridViewCellStyle7
			Me.Column4.HeaderText = "الصنف"
			Me.Column4.MinimumWidth = 7
			Me.Column4.Name = "Column4"
			Me.Column4.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column4.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			Me.Column4.Width = 150
			Me.Column12.HeaderText = "الوحدة"
			Me.Column12.Name = "Column12"
			Me.Column12.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column12.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			Me.Column12.Width = 70
			Me.Column7.HeaderText = "متوسط التكلفة"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Width = 80
			Me.Column9.HeaderText = "الكمية المتوفرة"
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column9.Width = 80
			Me.Column5.HeaderText = "الكمية الفعلية"
			Me.Column5.Name = "Column5"
			Me.Column5.Width = 80
			Me.Column6.HeaderText = "الفرق"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 80
			Me.Column8.HeaderText = "الفرق الكلي"
			Me.Column8.Name = "Column8"
			Me.Column8.Visible = False
			Me.Column11.HeaderText = ""
			Me.Column11.Name = "Column11"
			Me.Column11.Text = "Delete"
			Me.Column11.ToolTipText = "حذف"
			Me.Column11.UseColumnTextForButtonValue = True
			Me.Column11.Width = 70
			Me.Panel4.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel4
			point = New Global.System.Drawing.Point(0, 240)
			panel3.Location = point
			Me.Panel4.Name = "Panel4"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel4
			size = New Global.System.Drawing.Size(774, 13)
			panel4.Size = size
			Me.Panel4.TabIndex = 1
			Me.Panel3.Controls.Add(Me.ToolStrip2)
			Me.Panel3.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel5 As Global.System.Windows.Forms.Control = Me.Panel3
			point = New Global.System.Drawing.Point(0, 253)
			panel5.Location = point
			Me.Panel3.Name = "Panel3"
			Dim panel6 As Global.System.Windows.Forms.Control = Me.Panel3
			size = New Global.System.Drawing.Size(774, 51)
			panel6.Size = size
			Me.Panel3.TabIndex = 0
			Me.ToolStrip2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ToolStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.ToolStripSeparator3, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.ToolStripSeparator4, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.ToolStrip2
			point = New Global.System.Drawing.Point(0, 0)
			toolStrip.Location = point
			Me.ToolStrip2.Name = "ToolStrip2"
			Me.ToolStrip2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.ToolStrip2
			size = New Global.System.Drawing.Size(774, 51)
			toolStrip2.Size = size
			Me.ToolStrip2.TabIndex = 3
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
			size = New Global.System.Drawing.Size(6, 51)
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
			size = New Global.System.Drawing.Size(6, 51)
			toolStripSeparator2.Size = size
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
			Me.Panel1.Controls.Add(Me.cmbAccName)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtAccCode)
			Me.Panel1.Controls.Add(Me.txtNotes)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.cmbCenter)
			Me.Panel1.Controls.Add(Me.label4)
			Me.Panel1.Controls.Add(Me.txtRefNo)
			Me.Panel1.Controls.Add(Me.Label40)
			Me.Panel1.Controls.Add(Me.cmbSafe)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.txtDate)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.txtNo)
			Me.Panel1.Controls.Add(Me.Label14)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel7 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 3)
			panel7.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel8 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(774, 112)
			panel8.Size = size
			Me.Panel1.TabIndex = 2
			Me.cmbAccName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbAccName.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbAccName.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbAccName.FormattingEnabled = True
			Me.cmbAccName.Items.AddRange(New Object() { "فاتورة شراء", "فاتورة بيع", "مرتد فاتورة شراء", "مرتد فاتورة بيع", "سند قبض خارجي", "سند صرف خارجي", "سند قبض داخلي", "سند صرف داخلي", "مخزون أول المدة", "أخرى" })
			Dim cmbAccName As Global.System.Windows.Forms.Control = Me.cmbAccName
			point = New Global.System.Drawing.Point(59, 9)
			cmbAccName.Location = point
			Me.cmbAccName.Name = "cmbAccName"
			Dim cmbAccName2 As Global.System.Windows.Forms.Control = Me.cmbAccName
			size = New Global.System.Drawing.Size(183, 21)
			cmbAccName2.Size = size
			Me.cmbAccName.TabIndex = 213
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(322, 14)
			label.Location = point
			Me.Label3.Name = "Label3"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(72, 13)
			label2.Size = size
			Me.Label3.TabIndex = 214
			Me.Label3.Text = "رقم الحساب"
			Me.txtAccCode.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtAccCode.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtAccCode.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtAccCode As Global.System.Windows.Forms.Control = Me.txtAccCode
			point = New Global.System.Drawing.Point(244, 8)
			txtAccCode.Location = point
			Me.txtAccCode.Name = "txtAccCode"
			Dim txtAccCode2 As Global.System.Windows.Forms.Control = Me.txtAccCode
			size = New Global.System.Drawing.Size(77, 22)
			txtAccCode2.Size = size
			Me.txtAccCode.TabIndex = 212
			Me.txtAccCode.Text = " "
			Me.txtAccCode.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.txtNotes.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNotes As Global.System.Windows.Forms.Control = Me.txtNotes
			point = New Global.System.Drawing.Point(121, 69)
			txtNotes.Location = point
			Me.txtNotes.Multiline = True
			Me.txtNotes.Name = "txtNotes"
			Me.txtNotes.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim txtNotes2 As Global.System.Windows.Forms.Control = Me.txtNotes
			size = New Global.System.Drawing.Size(579, 26)
			txtNotes2.Size = size
			Me.txtNotes.TabIndex = 210
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(728, 73)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(36, 13)
			label4.Size = size
			Me.Label2.TabIndex = 211
			Me.Label2.Text = "البيان"
			Me.Button1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.Button1.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Button1.ForeColor = Global.System.Drawing.Color.Lime
			Me.Button1.Image = CType(resources.GetObject("Button1.Image"), Global.System.Drawing.Image)
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(119, -40)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(23, 21)
			button2.Size = size
			Me.Button1.TabIndex = 209
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button1.Visible = False
			Me.cmbCenter.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCenter.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCenter.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCenter.FormattingEnabled = True
			Me.cmbCenter.Items.AddRange(New Object() { "فاتورة شراء", "فاتورة بيع", "مرتد فاتورة شراء", "مرتد فاتورة بيع", "سند قبض خارجي", "سند صرف خارجي", "سند قبض داخلي", "سند صرف داخلي", "مخزون أول المدة", "أخرى" })
			Dim cmbCenter As Global.System.Windows.Forms.Control = Me.cmbCenter
			point = New Global.System.Drawing.Point(142, -40)
			cmbCenter.Location = point
			Me.cmbCenter.Name = "cmbCenter"
			Dim cmbCenter2 As Global.System.Windows.Forms.Control = Me.cmbCenter
			size = New Global.System.Drawing.Size(100, 21)
			cmbCenter2.Size = size
			Me.cmbCenter.TabIndex = 204
			Me.cmbCenter.Visible = False
			Me.label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.label4.AutoSize = True
			Me.label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.label4
			point = New Global.System.Drawing.Point(248, -36)
			label5.Location = point
			Me.label4.Name = "label4"
			Dim label6 As Global.System.Windows.Forms.Control = Me.label4
			size = New Global.System.Drawing.Size(71, 13)
			label6.Size = size
			Me.label4.TabIndex = 205
			Me.label4.Text = "مركز التكلفة"
			Me.label4.Visible = False
			Me.txtRefNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRefNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtRefNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtRefNo As Global.System.Windows.Forms.Control = Me.txtRefNo
			point = New Global.System.Drawing.Point(577, 41)
			txtRefNo.Location = point
			Me.txtRefNo.Name = "txtRefNo"
			Dim txtRefNo2 As Global.System.Windows.Forms.Control = Me.txtRefNo
			size = New Global.System.Drawing.Size(123, 22)
			txtRefNo2.Size = size
			Me.txtRefNo.TabIndex = 202
			Me.txtRefNo.Text = " "
			Me.txtRefNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label40.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label40.AutoSize = True
			Me.Label40.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label40.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label40
			point = New Global.System.Drawing.Point(702, 44)
			label7.Location = point
			Me.Label40.Name = "Label40"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label40
			size = New Global.System.Drawing.Size(65, 13)
			label8.Size = size
			Me.Label40.TabIndex = 203
			Me.Label40.Text = "رقم المرجع"
			Me.cmbSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSafe.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafe.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafe.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.cmbSafe.FormattingEnabled = True
			Dim cmbSafe As Global.System.Windows.Forms.Control = Me.cmbSafe
			point = New Global.System.Drawing.Point(406, 41)
			cmbSafe.Location = point
			Me.cmbSafe.Name = "cmbSafe"
			Dim cmbSafe2 As Global.System.Windows.Forms.Control = Me.cmbSafe
			size = New Global.System.Drawing.Size(109, 22)
			cmbSafe2.Size = size
			Me.cmbSafe.TabIndex = 70
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label12.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(519, 44)
			label9.Location = point
			Me.Label12.Name = "Label12"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(45, 13)
			label10.Size = size
			Me.Label12.TabIndex = 71
			Me.Label12.Text = "المخزن"
			Me.txtDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDate.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDate As Global.System.Windows.Forms.Control = Me.txtDate
			point = New Global.System.Drawing.Point(415, 12)
			txtDate.Location = point
			Me.txtDate.Name = "txtDate"
			Dim txtDate2 As Global.System.Windows.Forms.Control = Me.txtDate
			size = New Global.System.Drawing.Size(100, 22)
			txtDate2.Size = size
			Me.txtDate.TabIndex = 52
			Me.Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label13.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label13
			point = New Global.System.Drawing.Point(518, 14)
			label11.Location = point
			Me.Label13.Name = "Label13"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label13
			size = New Global.System.Drawing.Size(41, 13)
			label12.Size = size
			Me.Label13.TabIndex = 50
			Me.Label13.Text = "التاريخ"
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNo.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtNo.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(577, 10)
			txtNo.Location = point
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(123, 26)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 51
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Label14.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(717, 14)
			label13.Location = point
			Me.Label14.Name = "Label14"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(35, 13)
			label14.Size = size
			Me.Label14.TabIndex = 53
			Me.Label14.Text = "الرقم"
			Me.DataGridViewTextBoxColumn2.HeaderText = "البيان"
			Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
			Me.DataGridViewTextBoxColumn2.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn2.Width = 300
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
			size = New Global.System.Drawing.Size(780, 422)
			tabPage6.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "      البحث        "
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			Me.GroupBox4.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox4.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox4
			point = New Global.System.Drawing.Point(3, 113)
			groupBox.Location = point
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(774, 306)
			groupBox2.Size = size
			Me.GroupBox4.TabIndex = 11
			Me.GroupBox4.TabStop = False
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle8.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle8.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle8.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle8.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle8.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle8.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column1, Me.Column2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2 })
			Me.dgvSrch.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvSrch As Global.System.Windows.Forms.Control = Me.dgvSrch
			point = New Global.System.Drawing.Point(3, 17)
			dgvSrch.Location = point
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvSrch2 As Global.System.Windows.Forms.Control = Me.dgvSrch
			size = New Global.System.Drawing.Size(768, 286)
			dgvSrch2.Size = size
			Me.dgvSrch.TabIndex = 0
			Me.Column3.HeaderText = "id"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Visible = False
			Me.Column1.HeaderText = "رقم الأمر"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column2.HeaderText = "التاريخ"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn1.HeaderText = "المخزن"
			Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
			Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn1.Width = 120
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtRefNoSrch)
			Me.GroupBox6.Controls.Add(Me.Label17)
			Me.GroupBox6.Controls.Add(Me.txtNoSrch)
			Me.GroupBox6.Controls.Add(Me.Label8)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label10)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label11)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GroupBox6.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox6
			point = New Global.System.Drawing.Point(3, 3)
			groupBox3.Location = point
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(774, 110)
			groupBox4.Size = size
			Me.GroupBox6.TabIndex = 10
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "بحث"
			Me.txtRefNoSrch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtRefNoSrch As Global.System.Windows.Forms.Control = Me.txtRefNoSrch
			point = New Global.System.Drawing.Point(534, 79)
			txtRefNoSrch.Location = point
			Me.txtRefNoSrch.Name = "txtRefNoSrch"
			Dim txtRefNoSrch2 As Global.System.Windows.Forms.Control = Me.txtRefNoSrch
			size = New Global.System.Drawing.Size(124, 21)
			txtRefNoSrch2.Size = size
			Me.txtRefNoSrch.TabIndex = 16
			Me.txtRefNoSrch.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label17.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label17.AutoSize = True
			Me.Label17.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label17
			point = New Global.System.Drawing.Point(671, 84)
			label15.Location = point
			Me.Label17.Name = "Label17"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label17
			size = New Global.System.Drawing.Size(65, 13)
			label16.Size = size
			Me.Label17.TabIndex = 15
			Me.Label17.Text = "رقم المرجع"
			Me.txtNoSrch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNoSrch As Global.System.Windows.Forms.Control = Me.txtNoSrch
			point = New Global.System.Drawing.Point(534, 21)
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
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(671, 26)
			label17.Location = point
			Me.Label8.Name = "Label8"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(54, 13)
			label18.Size = size
			Me.Label8.TabIndex = 13
			Me.Label8.Text = "رقم الأمر"
			Me.txtToDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtToDate As Global.System.Windows.Forms.Control = Me.txtToDate
			point = New Global.System.Drawing.Point(300, 51)
			txtToDate.Location = point
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate2 As Global.System.Windows.Forms.Control = Me.txtToDate
			size = New Global.System.Drawing.Size(124, 21)
			txtToDate2.Size = size
			Me.txtToDate.TabIndex = 1
			Dim txtToDate3 As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate3.Value = dateTime
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.AutoSize = True
			Me.Label10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(435, 55)
			label19.Location = point
			Me.Label10.Name = "Label10"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(56, 13)
			label20.Size = size
			Me.Label10.TabIndex = 11
			Me.Label10.Text = "الى تاريخ"
			Me.txtFromDate.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtFromDate As Global.System.Windows.Forms.Control = Me.txtFromDate
			point = New Global.System.Drawing.Point(534, 51)
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
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(671, 55)
			label21.Location = point
			Me.Label11.Name = "Label11"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(52, 13)
			label22.Size = size
			Me.Label11.TabIndex = 12
			Me.Label11.Text = "من تاريخ"
			Me.btnSearch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Me.btnSearch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSearch As Global.System.Windows.Forms.Control = Me.btnSearch
			point = New Global.System.Drawing.Point(130, 35)
			btnSearch.Location = point
			Me.btnSearch.Name = "btnSearch"
			Dim btnSearch2 As Global.System.Windows.Forms.Control = Me.btnSearch
			size = New Global.System.Drawing.Size(125, 48)
			btnSearch2.Size = size
			Me.btnSearch.TabIndex = 2
			Me.btnSearch.UseVisualStyleBackColor = False
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim tabControl As Global.System.Windows.Forms.Control = Me.TabControl1
			point = New Global.System.Drawing.Point(0, 0)
			tabControl.Location = point
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.RightToLeftLayout = True
			Me.TabControl1.SelectedIndex = 0
			Dim tabControl2 As Global.System.Windows.Forms.Control = Me.TabControl1
			size = New Global.System.Drawing.Size(788, 448)
			tabControl2.Size = size
			Me.TabControl1.TabIndex = 3
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(788, 448)
			Me.ClientSize = size
			Me.Controls.Add(Me.TabControl1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmM5znTsweya"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "أمر تسوية مخزون"
			Me.TabPage1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.ToolStrip2.ResumeLayout(False)
			Me.ToolStrip2.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.TabControl1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
