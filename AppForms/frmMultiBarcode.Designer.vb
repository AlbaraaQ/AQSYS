Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmMultiBarcode
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtSymbol As TextBox

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
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtSymbol = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtBarcode = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.DataGridViewTextBoxColumn2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.txtBarcode)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.txtNo)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.txtSymbol)
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(489, 63)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtNo As Global.System.Windows.Forms.Control = Me.txtNo
			point = New Global.System.Drawing.Point(282, 8)
			txtNo.Location = point
			Me.txtNo.MaxLength = 50
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Dim txtNo2 As Global.System.Windows.Forms.Control = Me.txtNo
			size = New Global.System.Drawing.Size(110, 20)
			txtNo2.Size = size
			Me.txtNo.TabIndex = 2
			Me.txtNo.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Me.Label1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(406, 11)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(56, 13)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "رقم الصنف"
			Me.txtSymbol.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtSymbol As Global.System.Windows.Forms.Control = Me.txtSymbol
			point = New Global.System.Drawing.Point(40, 8)
			txtSymbol.Location = point
			Me.txtSymbol.MaxLength = 50
			Me.txtSymbol.Name = "txtSymbol"
			Me.txtSymbol.[ReadOnly] = True
			Dim txtSymbol2 As Global.System.Windows.Forms.Control = Me.txtSymbol
			size = New Global.System.Drawing.Size(178, 20)
			txtSymbol2.Size = size
			Me.txtSymbol.TabIndex = 5
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Me.Label6.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(224, 11)
			label3.Location = point
			Me.Label6.Name = "Label6"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(36, 13)
			label4.Size = size
			Me.Label6.TabIndex = 4
			Me.Label6.Text = "الصنف"
			Me.txtBarcode.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtBarcode As Global.System.Windows.Forms.Control = Me.txtBarcode
			point = New Global.System.Drawing.Point(241, 33)
			txtBarcode.Location = point
			Me.txtBarcode.MaxLength = 50
			Me.txtBarcode.Name = "txtBarcode"
			Dim txtBarcode2 As Global.System.Windows.Forms.Control = Me.txtBarcode
			size = New Global.System.Drawing.Size(151, 20)
			txtBarcode2.Size = size
			Me.txtBarcode.TabIndex = 7
			Me.txtBarcode.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Me.Label2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(415, 36)
			label5.Location = point
			Me.Label2.Name = "Label2"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(39, 13)
			label6.Size = size
			Me.Label2.TabIndex = 6
			Me.Label2.Text = "الباركود"
			Me.GroupBox3.Controls.Add(Me.dgvData)
			Me.GroupBox3.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox3
			point = New Global.System.Drawing.Point(0, 63)
			groupBox.Location = point
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(489, 215)
			groupBox2.Size = size
			Me.GroupBox3.TabIndex = 2
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "أرقام الباركود الأخرى للصنف"
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
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
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.DataGridViewTextBoxColumn2, Me.Column1 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(3, 16)
			dgvData.Location = point
			Me.dgvData.MultiSelect = False
			Me.dgvData.Name = "dgvData"
			Me.dgvData.[ReadOnly] = True
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(483, 196)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 0
			Me.Button1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(142, 31)
			button.Location = point
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(76, 23)
			button2.Size = size
			Me.Button1.TabIndex = 12
			Me.Button1.Text = "حفظ"
			Me.Button1.UseVisualStyleBackColor = True
			Me.DataGridViewTextBoxColumn2.HeaderText = "الباركود"
			Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
			Me.DataGridViewTextBoxColumn2.[ReadOnly] = True
			Me.DataGridViewTextBoxColumn2.Width = 250
			Me.Column1.HeaderText = "حذف"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Text = "حذف"
			Me.Column1.UseColumnTextForButtonValue = True
			Me.Column1.Width = 70
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(489, 278)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.Panel1)
			Me.MaximizeBox = False
			Me.Name = "frmMultiBarcode"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ادخل أرقام الباركود الأخرى للصنف"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
