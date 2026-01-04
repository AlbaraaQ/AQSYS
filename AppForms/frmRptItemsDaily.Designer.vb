Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptItemsDaily
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtSum As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtVAT As Label

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
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtTotal = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtVAT = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.Column4.HeaderText = "الإجمالي"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 90
			Me.Column2.HeaderText = "السعر"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Visible = False
			Me.Column2.Width = 70
			Me.Column1.HeaderText = "الصنف"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 250
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label7.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label7
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(259, 63)
			label.Location = point
			Me.Label7.Name = "Label7"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label7
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(131, 28)
			label2.Size = size
			Me.Label7.TabIndex = 9
			Me.Label7.Text = "المبلغ الإجمالي"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtTotal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotal.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtTotal.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtTotal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtTotal As Global.System.Windows.Forms.Control = Me.txtTotal
			point = New Global.System.Drawing.Point(131, 64)
			txtTotal.Location = point
			Me.txtTotal.Name = "txtTotal"
			Dim txtTotal2 As Global.System.Windows.Forms.Control = Me.txtTotal
			size = New Global.System.Drawing.Size(126, 28)
			txtTotal2.Size = size
			Me.txtTotal.TabIndex = 10
			Me.txtTotal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(258, 32)
			label3.Location = point
			Me.Label5.Name = "Label5"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(131, 28)
			label4.Size = size
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "الضريبة"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtVAT.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtVAT.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtVAT.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtVAT.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtVAT As Global.System.Windows.Forms.Control = Me.txtVAT
			point = New Global.System.Drawing.Point(130, 33)
			txtVAT.Location = point
			Me.txtVAT.Name = "txtVAT"
			Dim txtVAT2 As Global.System.Windows.Forms.Control = Me.txtVAT
			size = New Global.System.Drawing.Size(126, 28)
			txtVAT2.Size = size
			Me.txtVAT.TabIndex = 10
			Me.txtVAT.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(258, 2)
			label5.Location = point
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(131, 28)
			label6.Size = size
			Me.Label3.TabIndex = 9
			Me.Label3.Text = "الاجمالي"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSum.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSum As Global.System.Windows.Forms.Control = Me.txtSum
			point = New Global.System.Drawing.Point(130, 3)
			txtSum.Location = point
			Me.txtSum.Name = "txtSum"
			Dim txtSum2 As Global.System.Windows.Forms.Control = Me.txtSum
			size = New Global.System.Drawing.Size(126, 28)
			txtSum2.Size = size
			Me.txtSum.TabIndex = 10
			Me.txtSum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(3, 16)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.RowHeadersWidth = 25
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(573, 307)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 3
			Me.Column3.HeaderText = "العدد"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 70
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.txtTotal)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.txtVAT)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtSum)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 323)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(573, 93)
			panel2.Size = size
			Me.Panel1.TabIndex = 2
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 106)
			groupBox.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(579, 419)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 11
			Me.GroupBox2.TabStop = False
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(144, 50)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(70, 36)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(284, 50)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(70, 36)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(214, 50)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(70, 36)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(354, 50)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(70, 36)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.CalendarFont = New Global.System.Drawing.Font("Tahoma", 9F)
			Me.txtDateFrom.DropDownAlign = Global.System.Windows.Forms.LeftRightAlignment.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(192, 17)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(162, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox3.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(579, 106)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 10
			Me.GroupBox1.TabStop = False
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(360, 20)
			label7.Location = point
			Me.Label1.Name = "Label1"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(41, 13)
			label8.Size = size
			Me.Label1.TabIndex = 15
			Me.Label1.Text = "التاريخ"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(579, 525)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptItemsDaily"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير مبيعات الأصناف"
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
