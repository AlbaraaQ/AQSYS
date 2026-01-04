Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSelectClient
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdClient As RadioButton
    Friend WithEvents rdSupplier As RadioButton

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
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.rdAll = New Global.System.Windows.Forms.RadioButton()
			Me.rdSupplier = New Global.System.Windows.Forms.RadioButton()
			Me.rdClient = New Global.System.Windows.Forms.RadioButton()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.GroupBox1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.Panel2)
			Me.GroupBox1.Controls.Add(Me.Panel1)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(509, 369)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.rdAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdAll.AutoSize = True
			Me.rdAll.Checked = True
			Dim rdAll As Global.System.Windows.Forms.Control = Me.rdAll
			point = New Global.System.Drawing.Point(317, 17)
			rdAll.Location = point
			Me.rdAll.Name = "rdAll"
			Dim rdAll2 As Global.System.Windows.Forms.Control = Me.rdAll
			size = New Global.System.Drawing.Size(45, 17)
			rdAll2.Size = size
			Me.rdAll.TabIndex = 0
			Me.rdAll.TabStop = True
			Me.rdAll.Text = "الكل"
			Me.rdAll.UseVisualStyleBackColor = True
			Me.rdSupplier.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdSupplier.AutoSize = True
			Dim rdSupplier As Global.System.Windows.Forms.Control = Me.rdSupplier
			point = New Global.System.Drawing.Point(183, 17)
			rdSupplier.Location = point
			Me.rdSupplier.Name = "rdSupplier"
			Dim rdSupplier2 As Global.System.Windows.Forms.Control = Me.rdSupplier
			size = New Global.System.Drawing.Size(45, 17)
			rdSupplier2.Size = size
			Me.rdSupplier.TabIndex = 0
			Me.rdSupplier.Text = "مورد"
			Me.rdSupplier.UseVisualStyleBackColor = True
			Me.rdClient.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdClient.AutoSize = True
			Dim rdClient As Global.System.Windows.Forms.Control = Me.rdClient
			point = New Global.System.Drawing.Point(248, 17)
			rdClient.Location = point
			Me.rdClient.Name = "rdClient"
			Dim rdClient2 As Global.System.Windows.Forms.Control = Me.rdClient
			size = New Global.System.Drawing.Size(51, 17)
			rdClient2.Size = size
			Me.rdClient.TabIndex = 0
			Me.rdClient.Text = "عميل"
			Me.rdClient.UseVisualStyleBackColor = True
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.rdSupplier)
			Me.Panel1.Controls.Add(Me.rdClient)
			Me.Panel1.Controls.Add(Me.rdAll)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 16)
			panel.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(503, 52)
			panel2.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel2.Controls.Add(Me.dgvData)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(3, 68)
			panel3.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(503, 298)
			panel4.Size = size
			Me.Panel2.TabIndex = 2
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
			Me.dgvData.AllowUserToOrderColumns = True
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(0, 0)
			dgvData.Location = point
			Me.dgvData.Name = "dgvData"
			Me.dgvData.RowHeadersVisible = False
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(503, 298)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 0
			Me.Column1.HeaderText = "id"
			Me.Column1.Name = "Column1"
			Me.Column1.Visible = False
			Me.Column2.HeaderText = "النوع"
			Me.Column2.Name = "Column2"
			Me.Column2.Width = 70
			Me.Column4.HeaderText = "رقم الحساب"
			Me.Column4.Name = "Column4"
			Me.Column3.HeaderText = "الإسم"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 200
			Me.Column5.HeaderText = ""
			Me.Column5.Name = "Column5"
			Me.Column5.Text = "اختر"
			Me.Column5.UseColumnTextForButtonValue = True
			Me.Column5.Width = 70
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(509, 369)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.MaximizeBox = False
			Me.Name = "frmSelectClient"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "اختر عميل أو مورد"
			Me.GroupBox1.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
