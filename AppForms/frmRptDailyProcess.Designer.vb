Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptDailyProcess
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllSafe As CheckBox
    Friend WithEvents chkAllStock As CheckBox
    Friend WithEvents cmbSafe As ComboBox
    Friend WithEvents cmbStock As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker

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
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbStock = New Global.System.Windows.Forms.ComboBox()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.chkAllSafe = New Global.System.Windows.Forms.CheckBox()
			Me.chkAllStock = New Global.System.Windows.Forms.CheckBox()
			Me.cmbSafe = New Global.System.Windows.Forms.ComboBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(78, 110)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(92, 33)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(176, 110)
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
			point = New Global.System.Drawing.Point(372, 110)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(92, 33)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.cmbStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbStock.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbStock.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbStock.FormattingEnabled = True
			Dim cmbStock As Global.System.Windows.Forms.Control = Me.cmbStock
			point = New Global.System.Drawing.Point(278, 22)
			cmbStock.Location = point
			Me.cmbStock.Name = "cmbStock"
			Dim cmbStock2 As Global.System.Windows.Forms.Control = Me.cmbStock
			size = New Global.System.Drawing.Size(133, 21)
			cmbStock2.Size = size
			Me.cmbStock.TabIndex = 1
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(78, 66)
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
			point = New Global.System.Drawing.Point(217, 69)
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
			point = New Global.System.Drawing.Point(278, 66)
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
			point = New Global.System.Drawing.Point(423, 71)
			label3.Location = point
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(52, 13)
			label4.Size = size
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "من تاريخ"
			Me.Panel2.Controls.Add(Me.dgvItems)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Panel2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 191)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(544, 308)
			panel2.Size = size
			Me.Panel2.TabIndex = 9
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column8, Me.Column9, Me.Column5, Me.Column10 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(0, 0)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.RowHeadersVisible = False
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(544, 308)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 1
			Me.Column1.HeaderText = ""
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 130
			Me.Column8.HeaderText = "عدد الفواتير"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column9.HeaderText = "الإجمالي"
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column5.HeaderText = "نقدي"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column10.HeaderText = "آجل"
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(274, 110)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(92, 33)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.Panel1.Controls.Add(Me.chkAllSafe)
			Me.Panel1.Controls.Add(Me.chkAllStock)
			Me.Panel1.Controls.Add(Me.btnPreview)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Controls.Add(Me.btnPrint)
			Me.Panel1.Controls.Add(Me.btnShow)
			Me.Panel1.Controls.Add(Me.cmbSafe)
			Me.Panel1.Controls.Add(Me.cmbStock)
			Me.Panel1.Controls.Add(Me.txtDateTo)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtDateFrom)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.Panel1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 0)
			panel3.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(544, 191)
			panel4.Size = size
			Me.Panel1.TabIndex = 7
			Me.chkAllSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllSafe.AutoSize = True
			Dim chkAllSafe As Global.System.Windows.Forms.Control = Me.chkAllSafe
			point = New Global.System.Drawing.Point(161, 43)
			chkAllSafe.Location = point
			Me.chkAllSafe.Name = "chkAllSafe"
			Dim chkAllSafe2 As Global.System.Windows.Forms.Control = Me.chkAllSafe
			size = New Global.System.Drawing.Size(50, 17)
			chkAllSafe2.Size = size
			Me.chkAllSafe.TabIndex = 11
			Me.chkAllSafe.Text = "الكل"
			Me.chkAllSafe.UseVisualStyleBackColor = True
			Me.chkAllStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllStock.AutoSize = True
			Dim chkAllStock As Global.System.Windows.Forms.Control = Me.chkAllStock
			point = New Global.System.Drawing.Point(361, 43)
			chkAllStock.Location = point
			Me.chkAllStock.Name = "chkAllStock"
			Dim chkAllStock2 As Global.System.Windows.Forms.Control = Me.chkAllStock
			size = New Global.System.Drawing.Size(50, 17)
			chkAllStock2.Size = size
			Me.chkAllStock.TabIndex = 10
			Me.chkAllStock.Text = "الكل"
			Me.chkAllStock.UseVisualStyleBackColor = True
			Me.cmbSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSafe.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafe.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafe.FormattingEnabled = True
			Dim cmbSafe As Global.System.Windows.Forms.Control = Me.cmbSafe
			point = New Global.System.Drawing.Point(78, 22)
			cmbSafe.Location = point
			Me.cmbSafe.Name = "cmbSafe"
			Dim cmbSafe2 As Global.System.Windows.Forms.Control = Me.cmbSafe
			size = New Global.System.Drawing.Size(133, 21)
			cmbSafe2.Size = size
			Me.cmbSafe.TabIndex = 1
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(223, 25)
			label5.Location = point
			Me.Label4.Name = "Label4"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(44, 13)
			label6.Size = size
			Me.Label4.TabIndex = 0
			Me.Label4.Text = "الخزينة"
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(423, 25)
			label7.Location = point
			Me.Label1.Name = "Label1"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(45, 13)
			label8.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "المخزن"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(544, 499)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptDailyProcess"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير الحركة اليومية"
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
