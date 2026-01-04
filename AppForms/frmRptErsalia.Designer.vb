Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptErsalia
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblComm As Label
    Friend WithEvents txtComm As Label
    Friend WithEvents txtErsNo As TextBox
    Friend WithEvents txtNet As Label
    Friend WithEvents txtNetAR As Label
    Friend WithEvents txtSum As Label
    Friend WithEvents txtSumExpenses As Label
    Friend WithEvents txtSumQuan As Label
    Friend WithEvents txtSumTotal As Label

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
			Me.txtComm = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtNetAR = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.lblComm = New Global.System.Windows.Forms.Label()
			Me.txtNet = New Global.System.Windows.Forms.Label()
			Me.txtSumExpenses = New Global.System.Windows.Forms.Label()
			Me.txtSumTotal = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtSumQuan = New Global.System.Windows.Forms.Label()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbSupplier = New Global.System.Windows.Forms.ComboBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtErsNo = New Global.System.Windows.Forms.TextBox()
			Me.Label50 = New Global.System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.txtComm.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtComm.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtComm.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtComm.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtComm As Global.System.Windows.Forms.Control = Me.txtComm
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(700, 30)
			txtComm.Location = point
			Me.txtComm.Name = "txtComm"
			Dim txtComm2 As Global.System.Windows.Forms.Control = Me.txtComm
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(140, 28)
			txtComm2.Size = size
			Me.txtComm.TabIndex = 10
			Me.txtComm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSum.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSum As Global.System.Windows.Forms.Control = Me.txtSum
			point = New Global.System.Drawing.Point(700, 0)
			txtSum.Location = point
			Me.txtSum.Name = "txtSum"
			Dim txtSum2 As Global.System.Windows.Forms.Control = Me.txtSum
			size = New Global.System.Drawing.Size(142, 28)
			txtSum2.Size = size
			Me.txtSum.TabIndex = 10
			Me.txtSum.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Panel1.Controls.Add(Me.txtNetAR)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.lblComm)
			Me.Panel1.Controls.Add(Me.txtNet)
			Me.Panel1.Controls.Add(Me.txtSumExpenses)
			Me.Panel1.Controls.Add(Me.txtSumTotal)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtComm)
			Me.Panel1.Controls.Add(Me.txtSumQuan)
			Me.Panel1.Controls.Add(Me.txtSum)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 296)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(843, 153)
			panel2.Size = size
			Me.Panel1.TabIndex = 3
			Me.txtNetAR.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNetAR.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtNetAR.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtNetAR.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtNetAR As Global.System.Windows.Forms.Control = Me.txtNetAR
			point = New Global.System.Drawing.Point(214, 120)
			txtNetAR.Location = point
			Me.txtNetAR.Name = "txtNetAR"
			Dim txtNetAR2 As Global.System.Windows.Forms.Control = Me.txtNetAR
			size = New Global.System.Drawing.Size(243, 28)
			txtNetAR2.Size = size
			Me.txtNetAR.TabIndex = 16
			Me.txtNetAR.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label11.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label11.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label11
			point = New Global.System.Drawing.Point(460, 121)
			label.Location = point
			Me.Label11.Name = "Label11"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(142, 28)
			label2.Size = size
			Me.Label11.TabIndex = 15
			Me.Label11.Text = "صافي الفاتورة"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(460, 91)
			label3.Location = point
			Me.Label10.Name = "Label10"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(142, 28)
			label4.Size = size
			Me.Label10.TabIndex = 15
			Me.Label10.Text = "خصم المصاريف"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.lblComm.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblComm.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.lblComm.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.lblComm.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblComm As Global.System.Windows.Forms.Control = Me.lblComm
			point = New Global.System.Drawing.Point(460, 30)
			lblComm.Location = point
			Me.lblComm.Name = "lblComm"
			Dim lblComm2 As Global.System.Windows.Forms.Control = Me.lblComm
			size = New Global.System.Drawing.Size(142, 28)
			lblComm2.Size = size
			Me.lblComm.TabIndex = 15
			Me.lblComm.Text = "كمسيون"
			Me.lblComm.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtNet.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNet.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtNet.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtNet.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtNet As Global.System.Windows.Forms.Control = Me.txtNet
			point = New Global.System.Drawing.Point(604, 120)
			txtNet.Location = point
			Me.txtNet.Name = "txtNet"
			Dim txtNet2 As Global.System.Windows.Forms.Control = Me.txtNet
			size = New Global.System.Drawing.Size(236, 28)
			txtNet2.Size = size
			Me.txtNet.TabIndex = 14
			Me.txtNet.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSumExpenses.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumExpenses.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumExpenses.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumExpenses.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSumExpenses As Global.System.Windows.Forms.Control = Me.txtSumExpenses
			point = New Global.System.Drawing.Point(700, 91)
			txtSumExpenses.Location = point
			Me.txtSumExpenses.Name = "txtSumExpenses"
			Dim txtSumExpenses2 As Global.System.Windows.Forms.Control = Me.txtSumExpenses
			size = New Global.System.Drawing.Size(140, 28)
			txtSumExpenses2.Size = size
			Me.txtSumExpenses.TabIndex = 12
			Me.txtSumExpenses.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSumTotal.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumTotal.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumTotal.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumTotal.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSumTotal As Global.System.Windows.Forms.Control = Me.txtSumTotal
			point = New Global.System.Drawing.Point(700, 61)
			txtSumTotal.Location = point
			Me.txtSumTotal.Name = "txtSumTotal"
			Dim txtSumTotal2 As Global.System.Windows.Forms.Control = Me.txtSumTotal
			size = New Global.System.Drawing.Size(142, 28)
			txtSumTotal2.Size = size
			Me.txtSumTotal.TabIndex = 13
			Me.txtSumTotal.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label9.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(460, 61)
			label5.Location = point
			Me.Label9.Name = "Label9"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(142, 28)
			label6.Size = size
			Me.Label9.TabIndex = 11
			Me.Label9.Text = "إجمالي الفاتورة"
			Me.Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(460, 0)
			label7.Location = point
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(142, 28)
			label8.Size = size
			Me.Label3.TabIndex = 11
			Me.Label3.Text = "قائم الفاتورة"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSumQuan.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSumQuan.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumQuan.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.txtSumQuan.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim txtSumQuan As Global.System.Windows.Forms.Control = Me.txtSumQuan
			point = New Global.System.Drawing.Point(604, 0)
			txtSumQuan.Location = point
			Me.txtSumQuan.Name = "txtSumQuan"
			Dim txtSumQuan2 As Global.System.Windows.Forms.Control = Me.txtSumQuan
			size = New Global.System.Drawing.Size(94, 28)
			txtSumQuan2.Size = size
			Me.txtSumQuan.TabIndex = 10
			Me.txtSumQuan.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(3, 16)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(843, 280)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 4
			Me.Column1.HeaderText = "الثمن"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column2.HeaderText = "العدد"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column3.HeaderText = "السعر"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column4.HeaderText = "الصنف"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 150
			Me.Column6.HeaderText = "القيمة"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 136
			Me.Column5.HeaderText = "المصروفات"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 150
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			point = New Global.System.Drawing.Point(0, 74)
			groupBox.Location = point
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(849, 452)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 6
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "نتائج البحث"
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnClose.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(108, 15)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(75, 40)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 6
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPreview.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(271, 15)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(73, 40)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 4
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnPrint.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(187, 15)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(81, 40)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 5
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.btnShow.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(347, 15)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(76, 40)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 3
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.cmbSupplier.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSupplier.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSupplier.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSupplier.FormattingEnabled = True
			Me.cmbSupplier.Items.AddRange(New Object() { "آجلة", "نقدية" })
			Dim cmbSupplier As Global.System.Windows.Forms.Control = Me.cmbSupplier
			point = New Global.System.Drawing.Point(618, 23)
			cmbSupplier.Location = point
			Me.cmbSupplier.Name = "cmbSupplier"
			Dim cmbSupplier2 As Global.System.Windows.Forms.Control = Me.cmbSupplier
			size = New Global.System.Drawing.Size(105, 21)
			cmbSupplier2.Size = size
			Me.cmbSupplier.TabIndex = 0
			Me.Label15.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label15.AutoSize = True
			Me.Label15.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label15.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(727, 27)
			label9.Location = point
			Me.Label15.Name = "Label15"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(39, 13)
			label10.Size = size
			Me.Label15.TabIndex = 24
			Me.Label15.Text = "المورد"
			Me.GroupBox1.Controls.Add(Me.txtErsNo)
			Me.GroupBox1.Controls.Add(Me.Label50)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.cmbSupplier)
			Me.GroupBox1.Controls.Add(Me.Label15)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			point = New Global.System.Drawing.Point(0, 0)
			groupBox3.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(849, 74)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 5
			Me.GroupBox1.TabStop = False
			Me.txtErsNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtErsNo.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			Dim txtErsNo As Global.System.Windows.Forms.Control = Me.txtErsNo
			point = New Global.System.Drawing.Point(465, 22)
			txtErsNo.Location = point
			Me.txtErsNo.MaxLength = 50
			Me.txtErsNo.Name = "txtErsNo"
			Dim txtErsNo2 As Global.System.Windows.Forms.Control = Me.txtErsNo
			size = New Global.System.Drawing.Size(55, 22)
			txtErsNo2.Size = size
			Me.txtErsNo.TabIndex = 208
			Me.txtErsNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label50.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label50.AutoSize = True
			Me.Label50.Font = New Global.System.Drawing.Font("Arial", 10F, Global.System.Drawing.FontStyle.Bold)
			Me.Label50.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label50
			point = New Global.System.Drawing.Point(523, 26)
			label11.Location = point
			Me.Label50.Name = "Label50"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label50
			size = New Global.System.Drawing.Size(68, 16)
			label12.Size = size
			Me.Label50.TabIndex = 209
			Me.Label50.Text = "رقم الإرسالية"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(849, 526)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptErsalia"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير الإرسالية"
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
