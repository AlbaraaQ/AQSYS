Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmOffers
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column12 As DataGridViewComboBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents colbarcode As DataGridViewTextBoxColumn
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmOffers))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column16 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column17 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.colbarcode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel2.Controls.Add(Me.toolStrip1)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 264)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(675, 51)
			panel2.Size = size
			Me.Panel2.TabIndex = 1
			Me.toolStrip1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.toolStrip1
			point = New Global.System.Drawing.Point(0, 0)
			toolStrip.Location = point
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.toolStrip1
			size = New Global.System.Drawing.Size(675, 51)
			toolStrip2.Size = size
			Me.toolStrip1.TabIndex = 1
			Me.toolStrip1.Text = "toolStrip1"
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
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Dim toolStripSeparator As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator1
			size = New Global.System.Drawing.Size(6, 51)
			toolStripSeparator.Size = size
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
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Dim toolStripSeparator2 As Global.System.Windows.Forms.ToolStripItem = Me.toolStripSeparator2
			size = New Global.System.Drawing.Size(6, 51)
			toolStripSeparator2.Size = size
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
			Me.btnPrint.Visible = False
			Me.btnClose.AutoSize = False
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), Global.System.Drawing.Image)
			Me.btnClose.ImageScaling = Global.System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnClose.ImageTransparentColor = Global.System.Drawing.Color.Magenta
			Me.btnClose.Name = "btnClose"
			Dim btnClose As Global.System.Windows.Forms.ToolStripItem = Me.btnClose
			size = New Global.System.Drawing.Size(50, 50)
			btnClose.Size = size
			Me.btnClose.Text = "خروج"
			Me.GroupBox1.Controls.Add(Me.dgvItems)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(675, 264)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 2
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "ادخل الأصناف المشمولة بالعرض"
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
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column4, Me.Column12, Me.Column9, Me.Column6, Me.Column16, Me.Column17, Me.colbarcode })
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.Color.Blue
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.DefaultCellStyle = dataGridViewCellStyle3
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvItems.EditMode = Global.System.Windows.Forms.DataGridViewEditMode.EditOnEnter
			Me.dgvItems.GridColor = Global.System.Drawing.Color.Silver
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(3, 16)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
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
			size = New Global.System.Drawing.Size(669, 245)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 10
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
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
			Me.Column9.HeaderText = "الكمية"
			Me.Column9.Name = "Column9"
			Me.Column9.Width = 70
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Column6.DefaultCellStyle = dataGridViewCellStyle7
			Me.Column6.HeaderText = "السعر"
			Me.Column6.MinimumWidth = 7
			Me.Column6.Name = "Column6"
			Me.Column6.Width = 70
			Me.Column16.HeaderText = "الخصم"
			Me.Column16.Name = "Column16"
			Me.Column16.Width = 60
			Me.Column17.HeaderText = "السعر بعد الخصم"
			Me.Column17.Name = "Column17"
			Me.Column17.Width = 80
			Me.colbarcode.HeaderText = "الباركود"
			Me.colbarcode.Name = "colbarcode"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(675, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.Panel2)
			Me.MaximizeBox = False
			Me.Name = "frmOffers"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "شاشة إدخال العروض"
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
