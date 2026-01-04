Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptKhzna
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents cmbSafe As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtTotAll As TextBox
    Friend WithEvents txtTotPeriod As TextBox

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
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.txtTotPeriod = New Global.System.Windows.Forms.TextBox()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.txtTotAll = New Global.System.Windows.Forms.TextBox()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbSafe = New Global.System.Windows.Forms.ComboBox()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel2.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column7, Me.Column8, Me.Column9, Me.Column5, Me.Column1, Me.Column3, Me.Column10, Me.Column6 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.RowHeadersVisible = False
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(968, 298)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 0
			Me.Column7.HeaderText = "م"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Width = 50
			Me.Column8.HeaderText = "الحركة"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column8.Width = 70
			Me.Column9.HeaderText = "رقم الحركة"
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column9.Width = 50
			Me.Column5.HeaderText = "التاريخ"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column1.HeaderText = "وارد"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column3.HeaderText = "صادر"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column10.HeaderText = "الرصيد"
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			Me.Column6.HeaderText = "البيان"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 350
			Me.Panel2.Controls.Add(Me.dgvItems)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Panel2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 107)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(968, 298)
			panel2.Size = size
			Me.Panel2.TabIndex = 6
			Me.txtTotPeriod.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotPeriod.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotPeriod.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotPeriod As Global.System.Windows.Forms.Control = Me.txtTotPeriod
			point = New Global.System.Drawing.Point(718, 8)
			txtTotPeriod.Location = point
			Me.txtTotPeriod.Multiline = True
			Me.txtTotPeriod.Name = "txtTotPeriod"
			Me.txtTotPeriod.[ReadOnly] = True
			Dim txtTotPeriod2 As Global.System.Windows.Forms.Control = Me.txtTotPeriod
			size = New Global.System.Drawing.Size(229, 63)
			txtTotPeriod2.Size = size
			Me.txtTotPeriod.TabIndex = 1
			Me.txtTotPeriod.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Panel3.Controls.Add(Me.txtTotAll)
			Me.Panel3.Controls.Add(Me.txtTotPeriod)
			Me.Panel3.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.Panel3.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel3
			point = New Global.System.Drawing.Point(0, 405)
			panel3.Location = point
			Me.Panel3.Name = "Panel3"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel3
			size = New Global.System.Drawing.Size(968, 81)
			panel4.Size = size
			Me.Panel3.TabIndex = 5
			Me.txtTotAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotAll.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotAll.Font = New Global.System.Drawing.Font("Tahoma", 12F, Global.System.Drawing.FontStyle.Bold)
			Dim txtTotAll As Global.System.Windows.Forms.Control = Me.txtTotAll
			point = New Global.System.Drawing.Point(477, 8)
			txtTotAll.Location = point
			Me.txtTotAll.Multiline = True
			Me.txtTotAll.Name = "txtTotAll"
			Me.txtTotAll.[ReadOnly] = True
			Dim txtTotAll2 As Global.System.Windows.Forms.Control = Me.txtTotAll
			size = New Global.System.Drawing.Size(235, 63)
			txtTotAll2.Size = size
			Me.txtTotAll.TabIndex = 2
			Me.txtTotAll.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(290, 59)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(92, 33)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(94, 59)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(92, 33)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(192, 59)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(92, 33)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(388, 59)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(92, 33)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.cmbSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSafe.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafe.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafe.FormattingEnabled = True
			Dim cmbSafe As Global.System.Windows.Forms.Control = Me.cmbSafe
			point = New Global.System.Drawing.Point(502, 22)
			cmbSafe.Location = point
			Me.cmbSafe.Name = "cmbSafe"
			Dim cmbSafe2 As Global.System.Windows.Forms.Control = Me.cmbSafe
			size = New Global.System.Drawing.Size(333, 21)
			cmbSafe2.Size = size
			Me.cmbSafe.TabIndex = 1
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(502, 66)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(133, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 3
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(641, 69)
			label.Location = point
			Me.Label3.Name = "Label3"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(56, 13)
			label2.Size = size
			Me.Label3.TabIndex = 0
			Me.Label3.Text = "الى تاريخ"
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(702, 66)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(133, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(847, 71)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(52, 13)
			label4.Size = size
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "من تاريخ"
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(847, 25)
			label5.Location = point
			Me.Label1.Name = "Label1"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(44, 13)
			label6.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "الخزينة"
			Me.Panel1.Controls.Add(Me.btnPreview)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Controls.Add(Me.btnPrint)
			Me.Panel1.Controls.Add(Me.btnShow)
			Me.Panel1.Controls.Add(Me.cmbSafe)
			Me.Panel1.Controls.Add(Me.txtDateTo)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtDateFrom)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.Panel1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel5 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 0)
			panel5.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel6 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(968, 107)
			panel6.Size = size
			Me.Panel1.TabIndex = 4
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(968, 486)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel3)
			Me.Controls.Add(Me.Panel1)
			Me.Name = "frmRptKhzna"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "حركة الخزينة"
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
