Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptSalesTax
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllBranches As CheckBox
    Friend WithEvents cmbBranches As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblBranch As Label
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumTab3 As TextBox
    Friend WithEvents txtSumTax As TextBox
    Friend WithEvents txtSumTotal As TextBox

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
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSumTotal = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtSumTax = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtSumTab3 = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.chkAllBranches = New Global.System.Windows.Forms.CheckBox()
			Me.cmbBranches = New Global.System.Windows.Forms.ComboBox()
			Me.lblBranch = New Global.System.Windows.Forms.Label()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column3, Me.Column2, Me.Column6, Me.Column9, Me.Column8, Me.Column11, Me.Column12 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(3, 16)
			dgvItems.Location = point
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.RowHeadersVisible = False
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(782, 288)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 0
			Me.Column1.HeaderText = "نوع الفاتورة"
			Me.Column1.Name = "Column1"
			Me.Column1.Width = 90
			Me.Column3.HeaderText = "رقم الفاتورة"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 80
			Me.Column2.HeaderText = "تاريخ الفاتورة"
			Me.Column2.Name = "Column2"
			Me.Column2.Width = 110
			Me.Column6.HeaderText = "قيمة الفاتورة"
			Me.Column6.Name = "Column6"
			Me.Column6.Width = 80
			Me.Column9.HeaderText = "مبلغ الضريبة"
			Me.Column9.Name = "Column9"
			Me.Column9.Width = 80
			Me.Column8.HeaderText = "صافي الفاتورة"
			Me.Column8.Name = "Column8"
			Me.Column8.Width = 80
			Me.Column11.HeaderText = "إسم العميل"
			Me.Column11.Name = "Column11"
			Me.Column11.Width = 130
			Me.Column12.HeaderText = "الرقم الضريبي"
			Me.Column12.Name = "Column12"
			Me.Column12.Width = 110
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 133)
			groupBox.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(788, 307)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 8
			Me.GroupBox2.TabStop = False
			Me.Panel1.BackColor = Global.System.Drawing.Color.White
			Me.Panel1.Controls.Add(Me.txtSumTotal)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.txtSumTax)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.txtSumTab3)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 440)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(788, 37)
			panel2.Size = size
			Me.Panel1.TabIndex = 7
			Me.txtSumTotal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumTotal.BackColor = Global.System.Drawing.Color.White
			Me.txtSumTotal.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtSumTotal.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumTotal.ForeColor = Global.System.Drawing.Color.Red
			Dim txtSumTotal As Global.System.Windows.Forms.Control = Me.txtSumTotal
			point = New Global.System.Drawing.Point(53, 3)
			txtSumTotal.Location = point
			Me.txtSumTotal.Multiline = True
			Me.txtSumTotal.Name = "txtSumTotal"
			Dim txtSumTotal2 As Global.System.Windows.Forms.Control = Me.txtSumTotal
			size = New Global.System.Drawing.Size(94, 27)
			txtSumTotal2.Size = size
			Me.txtSumTotal.TabIndex = 10
			Me.txtSumTotal.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.BackColor = Global.System.Drawing.Color.White
			Me.Label8.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label8.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(150, 3)
			label.Location = point
			Me.Label8.Name = "Label8"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(78, 27)
			label2.Size = size
			Me.Label8.TabIndex = 11
			Me.Label8.Text = "الإجمالي"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSumTax.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumTax.BackColor = Global.System.Drawing.Color.White
			Me.txtSumTax.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtSumTax.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumTax.ForeColor = Global.System.Drawing.Color.Red
			Dim txtSumTax As Global.System.Windows.Forms.Control = Me.txtSumTax
			point = New Global.System.Drawing.Point(279, 3)
			txtSumTax.Location = point
			Me.txtSumTax.Multiline = True
			Me.txtSumTax.Name = "txtSumTax"
			Dim txtSumTax2 As Global.System.Windows.Forms.Control = Me.txtSumTax
			size = New Global.System.Drawing.Size(89, 27)
			txtSumTax2.Size = size
			Me.txtSumTax.TabIndex = 8
			Me.txtSumTax.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.BackColor = Global.System.Drawing.Color.White
			Me.Label10.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(371, 3)
			label3.Location = point
			Me.Label10.Name = "Label10"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(118, 27)
			label4.Size = size
			Me.Label10.TabIndex = 9
			Me.Label10.Text = "إجمالي VAT"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSumTab3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumTab3.BackColor = Global.System.Drawing.Color.White
			Me.txtSumTab3.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.txtSumTab3.Font = New Global.System.Drawing.Font("Tahoma", 11.25F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumTab3.ForeColor = Global.System.Drawing.Color.Red
			Dim txtSumTab As Global.System.Windows.Forms.Control = Me.txtSumTab3
			point = New Global.System.Drawing.Point(546, 3)
			txtSumTab.Location = point
			Me.txtSumTab3.Multiline = True
			Me.txtSumTab3.Name = "txtSumTab3"
			Dim txtSumTab2 As Global.System.Windows.Forms.Control = Me.txtSumTab3
			size = New Global.System.Drawing.Size(200, 27)
			txtSumTab2.Size = size
			Me.txtSumTab3.TabIndex = 8
			Me.txtSumTab3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.GroupBox1.Controls.Add(Me.chkAllBranches)
			Me.GroupBox1.Controls.Add(Me.cmbBranches)
			Me.GroupBox1.Controls.Add(Me.lblBranch)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox3.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(788, 133)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 6
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "ادخل بيانات البحث"
			Me.chkAllBranches.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllBranches.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim chkAllBranches As Global.System.Windows.Forms.Control = Me.chkAllBranches
			point = New Global.System.Drawing.Point(12, 20)
			chkAllBranches.Location = point
			Me.chkAllBranches.Name = "chkAllBranches"
			Me.chkAllBranches.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim chkAllBranches2 As Global.System.Windows.Forms.Control = Me.chkAllBranches
			size = New Global.System.Drawing.Size(53, 17)
			chkAllBranches2.Size = size
			Me.chkAllBranches.TabIndex = 39
			Me.chkAllBranches.Text = "الكل"
			Me.chkAllBranches.UseVisualStyleBackColor = True
			Me.cmbBranches.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbBranches.FormattingEnabled = True
			Dim cmbBranches As Global.System.Windows.Forms.Control = Me.cmbBranches
			point = New Global.System.Drawing.Point(66, 18)
			cmbBranches.Location = point
			Me.cmbBranches.Name = "cmbBranches"
			Dim cmbBranches2 As Global.System.Windows.Forms.Control = Me.cmbBranches
			size = New Global.System.Drawing.Size(163, 21)
			cmbBranches2.Size = size
			Me.cmbBranches.TabIndex = 37
			Me.lblBranch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblBranch.AutoSize = True
			Me.lblBranch.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblBranch As Global.System.Windows.Forms.Control = Me.lblBranch
			point = New Global.System.Drawing.Point(233, 22)
			lblBranch.Location = point
			Me.lblBranch.Name = "lblBranch"
			Dim lblBranch2 As Global.System.Windows.Forms.Control = Me.lblBranch
			size = New Global.System.Drawing.Size(35, 13)
			lblBranch2.Size = size
			Me.lblBranch.TabIndex = 38
			Me.lblBranch.Text = "الفرع"
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.ProgressBar1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			point = New Global.System.Drawing.Point(3, 107)
			progressBar.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(782, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 36
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(316, 18)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(133, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 3
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(453, 21)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(56, 13)
			label6.Size = size
			Me.Label3.TabIndex = 13
			Me.Label3.Text = "الى تاريخ"
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(537, 19)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(133, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Me.Label4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(678, 23)
			label7.Location = point
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(52, 13)
			label8.Size = size
			Me.Label4.TabIndex = 12
			Me.Label4.Text = "من تاريخ"
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(182, 49)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(128, 45)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(316, 49)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(137, 45)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(454, 49)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(137, 45)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(592, 49)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(137, 45)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.Timer1.Enabled = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(788, 477)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmRptSalesTax"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير ضريبة المبيعات"
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
