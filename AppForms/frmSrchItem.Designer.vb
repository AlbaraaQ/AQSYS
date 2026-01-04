Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSrchItem
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button3 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkAllGroups As CheckBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvCurrencies As DataGridView
    Friend WithEvents txtNameSrch As TextBox
    Friend WithEvents txtSrchBarcode As TextBox

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
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.chkAllGroups = New Global.System.Windows.Forms.CheckBox()
			Me.cmbGroups = New Global.System.Windows.Forms.ComboBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtSrchBarcode = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtNameSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvCurrencies = New Global.System.Windows.Forms.DataGridView()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvCurrencies, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.chkAllGroups)
			Me.Panel1.Controls.Add(Me.cmbGroups)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtSrchBarcode)
			Me.Panel1.Controls.Add(Me.Label15)
			Me.Panel1.Controls.Add(Me.txtNameSrch)
			Me.Panel1.Controls.Add(Me.Label14)
			Me.Panel1.Controls.Add(Me.Button3)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(778, 55)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.chkAllGroups.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllGroups.AutoSize = True
			Me.chkAllGroups.Checked = True
			Me.chkAllGroups.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllGroups As Global.System.Windows.Forms.Control = Me.chkAllGroups
			point = New Global.System.Drawing.Point(282, 80)
			chkAllGroups.Location = point
			Me.chkAllGroups.Name = "chkAllGroups"
			Dim chkAllGroups2 As Global.System.Windows.Forms.Control = Me.chkAllGroups
			size = New Global.System.Drawing.Size(50, 17)
			chkAllGroups2.Size = size
			Me.chkAllGroups.TabIndex = 19
			Me.chkAllGroups.Text = "الكل"
			Me.chkAllGroups.UseVisualStyleBackColor = True
			Me.chkAllGroups.Visible = False
			Me.cmbGroups.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbGroups.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGroups.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGroups.Enabled = False
			Me.cmbGroups.FormattingEnabled = True
			Dim cmbGroups As Global.System.Windows.Forms.Control = Me.cmbGroups
			point = New Global.System.Drawing.Point(223, 57)
			cmbGroups.Location = point
			Me.cmbGroups.Name = "cmbGroups"
			Dim cmbGroups2 As Global.System.Windows.Forms.Control = Me.cmbGroups
			size = New Global.System.Drawing.Size(110, 21)
			cmbGroups2.Size = size
			Me.cmbGroups.TabIndex = 17
			Me.cmbGroups.Visible = False
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(333, 60)
			label.Location = point
			Me.Label3.Name = "Label3"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(87, 13)
			label2.Size = size
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "مجموعة الصنف"
			Me.Label3.Visible = False
			Me.txtSrchBarcode.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtSrchBarcode As Global.System.Windows.Forms.Control = Me.txtSrchBarcode
			point = New Global.System.Drawing.Point(566, 14)
			txtSrchBarcode.Location = point
			Me.txtSrchBarcode.MaxLength = 50
			Me.txtSrchBarcode.Name = "txtSrchBarcode"
			Dim txtSrchBarcode2 As Global.System.Windows.Forms.Control = Me.txtSrchBarcode
			size = New Global.System.Drawing.Size(137, 20)
			txtSrchBarcode2.Size = size
			Me.txtSrchBarcode.TabIndex = 1
			Me.Label15.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label15.AutoSize = True
			Me.Label15.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label15
			point = New Global.System.Drawing.Point(705, 18)
			label3.Location = point
			Me.Label15.Name = "Label15"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label15
			size = New Global.System.Drawing.Size(46, 13)
			label4.Size = size
			Me.Label15.TabIndex = 12
			Me.Label15.Text = "الباركود"
			Me.txtNameSrch.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNameSrch As Global.System.Windows.Forms.Control = Me.txtNameSrch
			point = New Global.System.Drawing.Point(238, 13)
			txtNameSrch.Location = point
			Me.txtNameSrch.MaxLength = 50
			Me.txtNameSrch.Name = "txtNameSrch"
			Dim txtNameSrch2 As Global.System.Windows.Forms.Control = Me.txtNameSrch
			size = New Global.System.Drawing.Size(256, 20)
			txtNameSrch2.Size = size
			Me.txtNameSrch.TabIndex = 0
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label14.AutoSize = True
			Me.Label14.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(499, 17)
			label5.Location = point
			Me.Label14.Name = "Label14"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(42, 13)
			label6.Size = size
			Me.Label14.TabIndex = 13
			Me.Label14.Text = "الصنف"
			Me.Button3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button3
			point = New Global.System.Drawing.Point(5, 4)
			button.Location = point
			Me.Button3.Name = "Button3"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(82, 41)
			button2.Size = size
			Me.Button3.TabIndex = 16
			Me.Button3.Text = "بحث"
			Me.Button3.UseVisualStyleBackColor = True
			Me.Button3.Visible = False
			Me.Panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel2.Controls.Add(Me.dgvCurrencies)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 55)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(778, 448)
			panel4.Size = size
			Me.Panel2.TabIndex = 1
			Me.dgvCurrencies.AllowUserToAddRows = False
			Me.dgvCurrencies.AllowUserToDeleteRows = False
			Me.dgvCurrencies.AllowUserToOrderColumns = True
			Me.dgvCurrencies.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvCurrencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvCurrencies.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvCurrencies.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column4, Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.Column8, Me.Column7 })
			Me.dgvCurrencies.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvCurrencies As Global.System.Windows.Forms.Control = Me.dgvCurrencies
			point = New Global.System.Drawing.Point(0, 0)
			dgvCurrencies.Location = point
			Me.dgvCurrencies.MultiSelect = False
			Me.dgvCurrencies.Name = "dgvCurrencies"
			Me.dgvCurrencies.[ReadOnly] = True
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvCurrencies.RowHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvCurrencies.RowHeadersVisible = False
			Me.dgvCurrencies.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvCurrencies2 As Global.System.Windows.Forms.Control = Me.dgvCurrencies
			size = New Global.System.Drawing.Size(776, 446)
			dgvCurrencies2.Size = size
			Me.dgvCurrencies.TabIndex = 2
			Me.Timer1.Interval = 500
			Me.Column3.HeaderText = "الرقم"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 70
			Me.Column4.HeaderText = "الصنف"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 150
			Me.Column1.HeaderText = "الباركود"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 90
			Me.Column2.HeaderText = "المجموعة"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column5.HeaderText = "آخر سعر الشراء"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 80
			Me.Column6.HeaderText = "سعر البيع"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 80
			Me.Column8.HeaderText = "كمية الصنف"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column7.HeaderText = ""
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Text = "اختر"
			Me.Column7.UseColumnTextForButtonValue = True
			Me.Column7.Width = 60
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(778, 503)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmSrchItem"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "بحث صنف"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvCurrencies, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
