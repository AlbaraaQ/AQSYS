Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSMSMsgs
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents chkIsDefault As CheckBox
    Friend WithEvents cmbAssign As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtMSG As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSMSMsgs))
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.chkIsDefault = New Global.System.Windows.Forms.CheckBox()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.cmbAssign = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtMSG = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
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
			Me.GroupBox1.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.White
			Me.GroupBox1.Controls.Add(Me.chkIsDefault)
			Me.GroupBox1.Controls.Add(Me.dgvData)
			Me.GroupBox1.Controls.Add(Me.cmbAssign)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtMSG)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(528, 348)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 9
			Me.GroupBox1.TabStop = False
			Me.chkIsDefault.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkIsDefault.AutoSize = True
			Dim chkIsDefault As Global.System.Windows.Forms.Control = Me.chkIsDefault
			point = New Global.System.Drawing.Point(82, 83)
			chkIsDefault.Location = point
			Me.chkIsDefault.Name = "chkIsDefault"
			Dim chkIsDefault2 As Global.System.Windows.Forms.Control = Me.chkIsDefault
			size = New Global.System.Drawing.Size(79, 17)
			chkIsDefault2.Size = size
			Me.chkIsDefault.TabIndex = 4
			Me.chkIsDefault.Text = "الإفتراضية"
			Me.chkIsDefault.UseVisualStyleBackColor = True
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
			Me.dgvData.AllowUserToOrderColumns = True
			Me.dgvData.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column2, Me.Column4 })
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(4, 110)
			dgvData.Location = point
			Me.dgvData.MultiSelect = False
			Me.dgvData.Name = "dgvData"
			Me.dgvData.[ReadOnly] = True
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(521, 232)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 3
			Me.Column3.HeaderText = "الرقم"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Visible = False
			Me.Column2.HeaderText = "الرسالة"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 350
			Me.Column4.HeaderText = "مخصصة لـ"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.cmbAssign.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbAssign.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbAssign.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbAssign.FormattingEnabled = True
			Me.cmbAssign.Items.AddRange(New Object() { "إسال العملاء", "طباعة فاتورة", "تذكير العملاء" })
			Dim cmbAssign As Global.System.Windows.Forms.Control = Me.cmbAssign
			point = New Global.System.Drawing.Point(176, 81)
			cmbAssign.Location = point
			Me.cmbAssign.Name = "cmbAssign"
			Dim cmbAssign2 As Global.System.Windows.Forms.Control = Me.cmbAssign
			size = New Global.System.Drawing.Size(263, 21)
			cmbAssign2.Size = size
			Me.cmbAssign.TabIndex = 0
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(451, 84)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(61, 13)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "مخصصة لـ"
			Me.txtMSG.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtMSG As Global.System.Windows.Forms.Control = Me.txtMSG
			point = New Global.System.Drawing.Point(23, 17)
			txtMSG.Location = point
			Me.txtMSG.Multiline = True
			Me.txtMSG.Name = "txtMSG"
			Me.txtMSG.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim txtMSG2 As Global.System.Windows.Forms.Control = Me.txtMSG
			size = New Global.System.Drawing.Size(416, 58)
			txtMSG2.Size = size
			Me.txtMSG.TabIndex = 2
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(455, 20)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(48, 13)
			label4.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "الرسالة"
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.panel2
			point = New Global.System.Drawing.Point(0, 348)
			panel.Location = point
			Me.panel2.Name = "panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.panel2
			size = New Global.System.Drawing.Size(528, 55)
			panel2.Size = size
			Me.panel2.TabIndex = 10
			Me.toolStrip1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Dim toolStrip As Global.System.Windows.Forms.Control = Me.toolStrip1
			point = New Global.System.Drawing.Point(0, 0)
			toolStrip.Location = point
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim toolStrip2 As Global.System.Windows.Forms.Control = Me.toolStrip1
			size = New Global.System.Drawing.Size(526, 53)
			toolStrip2.Size = size
			Me.toolStrip1.TabIndex = 0
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
			size = New Global.System.Drawing.Size(6, 53)
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
			size = New Global.System.Drawing.Size(6, 53)
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
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(528, 403)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.panel2)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmSMSMsgs"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.Text = "إعداد رسائل الجوال"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
