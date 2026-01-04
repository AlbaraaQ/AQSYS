Imports System.Windows.Forms
Partial Public Class frmTawlas
	Inherits Global.System.Windows.Forms.Form

	Private components As Global.System.ComponentModel.IContainer
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnClose As ToolStripButton
	Friend WithEvents btnDelete As ToolStripButton
	Friend WithEvents btnFirst As ToolStripButton
	Friend WithEvents btnLast As ToolStripButton
	Friend WithEvents btnNew As ToolStripButton
	Friend WithEvents btnNext As ToolStripButton
	Friend WithEvents btnPrevious As ToolStripButton
	Friend WithEvents btnPrint As ToolStripButton
	Friend WithEvents btnSave As ToolStripButton
	Friend WithEvents cmbGroups As ComboBox
	Friend WithEvents dgvData As DataGridView
	Friend WithEvents panel2 As Panel
	Friend WithEvents toolStrip1 As ToolStrip
	Friend WithEvents toolStripSeparator1 As ToolStripSeparator
	Friend WithEvents toolStripSeparator2 As ToolStripSeparator
	Friend WithEvents txtName As TextBox

	Protected Overrides Sub Dispose(disposing As Boolean)
		Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
		If flag Then
			Me.components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	Private Sub InitializeComponent()
		Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmTawlas))
		Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
		Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
		Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
		Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
		Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
		Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
		Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
		Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
		Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
		Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
		Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
		Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
		Me.dgvData = New Global.System.Windows.Forms.DataGridView()
		Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnAdd = New Global.System.Windows.Forms.Button()
		Me.cmbGroups = New Global.System.Windows.Forms.ComboBox()
		Me.Label1 = New Global.System.Windows.Forms.Label()
		Me.txtName = New Global.System.Windows.Forms.TextBox()
		Me.Label2 = New Global.System.Windows.Forms.Label()
		Me.panel2 = New Global.System.Windows.Forms.Panel()
		Me.toolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel2.SuspendLayout()
		Me.SuspendLayout()
		Me.btnClose.AutoSize = False
		Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), Global.System.Drawing.Image)
		Me.btnClose.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnClose.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnClose.Name = "btnClose"
		Dim btnClose As Global.System.Windows.Forms.ToolStripItem = Me.btnClose
		Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(50, 50)
		btnClose.Size = size
		Me.btnClose.Text = "خروج"
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator2
		size = New Global.System.Drawing.Size(6, 53)
		toolStripSeparator.Size = size
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
		Me.btnPrevious.AutoSize = False
		Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Global.System.Drawing.Image)
		Me.btnPrevious.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnPrevious.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnPrevious.Name = "btnPrevious"
		Dim btnPrevious As Global.System.Windows.Forms.ToolStripItem = Me.btnPrevious
		size = New Global.System.Drawing.Size(50, 50)
		btnPrevious.Size = size
		Me.btnPrevious.Text = "السابق"
		Me.btnNext.AutoSize = False
		Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), Global.System.Drawing.Image)
		Me.btnNext.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnNext.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnNext.Name = "btnNext"
		Dim btnNext As Global.System.Windows.Forms.ToolStripItem = Me.btnNext
		size = New Global.System.Drawing.Size(50, 50)
		btnNext.Size = size
		Me.btnNext.Text = "التالي"
		Me.btnLast.AutoSize = False
		Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), Global.System.Drawing.Image)
		Me.btnLast.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnLast.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnLast.Name = "btnLast"
		Dim btnLast As Global.System.Windows.Forms.ToolStripItem = Me.btnLast
		size = New Global.System.Drawing.Size(50, 50)
		btnLast.Size = size
		Me.btnLast.Text = "الأخير"
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator1
		size = New Global.System.Drawing.Size(6, 53)
		toolStripSeparator2.Size = size
		Me.btnDelete.AutoSize = False
		Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Global.System.Drawing.Image)
		Me.btnDelete.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnDelete.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnDelete.Name = "btnDelete"
		Dim btnDelete As Global.System.Windows.Forms.ToolStripItem = Me.btnDelete
		size = New Global.System.Drawing.Size(50, 50)
		btnDelete.Size = size
		Me.btnDelete.Text = "حذف"
		Me.btnSave.AutoSize = False
		Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), Global.System.Drawing.Image)
		Me.btnSave.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnSave.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnSave.Name = "btnSave"
		Dim btnSave As Global.System.Windows.Forms.ToolStripItem = Me.btnSave
		size = New Global.System.Drawing.Size(50, 50)
		btnSave.Size = size
		Me.btnSave.Text = "حفظ"
		Me.btnNew.AutoSize = False
		Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), Global.System.Drawing.Image)
		Me.btnNew.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnNew.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnNew.Name = "btnNew"
		Dim btnNew As Global.System.Windows.Forms.ToolStripItem = Me.btnNew
		size = New Global.System.Drawing.Size(50, 50)
		btnNew.Size = size
		Me.btnNew.Text = "جديد"
		Me.toolStrip1.Dock = Global.System.Windows.Forms.DockStyle.Fill
		Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose})
		Dim toolStrip As Global.System.Windows.Forms.Control = Me.toolStrip1
		Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
		toolStrip.Location = point
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
		Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.toolStrip1
		size = New Global.System.Drawing.Size(649, 53)
		toolStrip2.Size = size
		Me.toolStrip1.TabIndex = 0
		Me.toolStrip1.Text = "toolStrip1"
		Me.btnPrint.AutoSize = False
		Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Global.System.Drawing.Image)
		Me.btnPrint.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnPrint.ImageTransparentColor = Global.System.Drawing.Color.Magenta
		Me.btnPrint.Name = "btnPrint"
		Dim btnPrint As Global.System.Windows.Forms.ToolStripItem = Me.btnPrint
		size = New Global.System.Drawing.Size(50, 50)
		btnPrint.Size = size
		Me.btnPrint.Text = "طباعة"
		Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
		Me.GroupBox1.Controls.Add(Me.dgvData)
		Me.GroupBox1.Controls.Add(Me.btnAdd)
		Me.GroupBox1.Controls.Add(Me.cmbGroups)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtName)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
		Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
		point = New Global.System.Drawing.Point(0, 0)
		groupBox.Location = point
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
		Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
		size = New Global.System.Drawing.Size(651, 432)
		groupBox2.Size = size
		Me.GroupBox1.TabIndex = 11
		Me.GroupBox1.TabStop = False
		Me.dgvData.AllowUserToAddRows = False
		Me.dgvData.AllowUserToDeleteRows = False
		Me.dgvData.AllowUserToOrderColumns = True
		Me.dgvData.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.dgvData.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
		dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
		dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8.0F, Global.System.Drawing.FontStyle.Bold)
		dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
		Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4})
		Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
		point = New Global.System.Drawing.Point(43, 117)
		dgvData.Location = point
		Me.dgvData.MultiSelect = False
		Me.dgvData.Name = "dgvData"
		Me.dgvData.[ReadOnly] = True
		Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
		size = New Global.System.Drawing.Size(560, 261)
		dgvData2.Size = size
		Me.dgvData.TabIndex = 3
		Me.Column3.HeaderText = "الرقم"
		Me.Column3.Name = "Column3"
		Me.Column3.[ReadOnly] = True
		Me.Column3.Visible = False
		Me.Column1.HeaderText = "المجموعة"
		Me.Column1.Name = "Column1"
		Me.Column1.[ReadOnly] = True
		Me.Column1.Width = 250
		Me.Column2.HeaderText = "الطاولة"
		Me.Column2.Name = "Column2"
		Me.Column2.[ReadOnly] = True
		Me.Column2.Width = 250
		Me.Column4.HeaderText = "رقم المجموعة"
		Me.Column4.Name = "Column4"
		Me.Column4.[ReadOnly] = True
		Me.Column4.Visible = False
		Me.btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.btnAdd.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
		Me.btnAdd.Font = New Global.System.Drawing.Font("Tahoma", 12.0F, Global.System.Drawing.FontStyle.Bold)
		Me.btnAdd.ForeColor = Global.System.Drawing.Color.Lime
		Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Global.System.Drawing.Image)
		Me.btnAdd.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim btnAdd As Global.System.Windows.Forms.Control = Me.btnAdd
		point = New Global.System.Drawing.Point(77, 35)
		btnAdd.Location = point
		Me.btnAdd.Name = "btnAdd"
		Dim btnAdd2 As Global.System.Windows.Forms.Control = Me.btnAdd
		size = New Global.System.Drawing.Size(35, 28)
		btnAdd2.Size = size
		Me.btnAdd.TabIndex = 1
		Me.btnAdd.UseVisualStyleBackColor = False
		Me.cmbGroups.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.cmbGroups.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cmbGroups.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbGroups.FormattingEnabled = True
		Dim cmbGroups As Global.System.Windows.Forms.Control = Me.cmbGroups
		point = New Global.System.Drawing.Point(114, 38)
		cmbGroups.Location = point
		Me.cmbGroups.Name = "cmbGroups"
		Dim cmbGroups2 As Global.System.Windows.Forms.Control = Me.cmbGroups
		size = New Global.System.Drawing.Size(379, 21)
		cmbGroups2.Size = size
		Me.cmbGroups.TabIndex = 0
		Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim label As Global.System.Windows.Forms.Control = Me.Label1
		point = New Global.System.Drawing.Point(505, 41)
		label.Location = point
		Me.Label1.Name = "Label1"
		Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
		size = New Global.System.Drawing.Size(57, 13)
		label2.Size = size
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "المجموعة"
		Me.txtName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Dim txtName As Global.System.Windows.Forms.Control = Me.txtName
		point = New Global.System.Drawing.Point(77, 77)
		txtName.Location = point
		Me.txtName.Name = "txtName"
		Dim txtName2 As Global.System.Windows.Forms.Control = Me.txtName
		size = New Global.System.Drawing.Size(416, 20)
		txtName2.Size = size
		Me.txtName.TabIndex = 2
		Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
		point = New Global.System.Drawing.Point(500, 81)
		label3.Location = point
		Me.Label2.Name = "Label2"
		Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
		size = New Global.System.Drawing.Size(72, 13)
		label4.Size = size
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "اسم الطاولة"
		Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.toolStrip1)
		Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
		Dim panel As Global.System.Windows.Forms.Control = Me.panel2
		point = New Global.System.Drawing.Point(0, 432)
		panel.Location = point
		Me.panel2.Name = "panel2"
		Dim panel2 As Global.System.Windows.Forms.Control = Me.panel2
		size = New Global.System.Drawing.Size(651, 55)
		panel2.Size = size
		Me.panel2.TabIndex = 12
		Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7.0F, 13.0F)
		Me.AutoScaleDimensions = sizeF
		Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Global.System.Drawing.Color.White
		size = New Global.System.Drawing.Size(651, 487)
		Me.ClientSize = size
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.panel2)
		Me.Font = New Global.System.Drawing.Font("Tahoma", 8.0F, Global.System.Drawing.FontStyle.Bold)
		Me.MaximizeBox = False
		Me.Name = "frmTawlas"
		Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
		Me.RightToLeftLayout = True
		Me.ShowIcon = False
		Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "طاولات المطاعم"
		Me.toolStrip1.ResumeLayout(False)
		Me.toolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel2.ResumeLayout(False)
		Me.panel2.PerformLayout()
		Me.ResumeLayout(False)
	End Sub
End Class
