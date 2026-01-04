Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSrchClient
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lblClient As Label
    Friend WithEvents txtName As TextBox

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
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.lblClient = New Global.System.Windows.Forms.Label()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.GroupBox1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.Panel2)
			Me.GroupBox1.Controls.Add(Me.Panel1)
			Me.GroupBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(486, 436)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.Panel2.Controls.Add(Me.dgvData)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(3, 68)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(480, 365)
			panel2.Size = size
			Me.Panel2.TabIndex = 2
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
			Me.dgvData.AllowUserToOrderColumns = True
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column3, Me.Column5 })
			Me.dgvData.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvData As Global.System.Windows.Forms.Control = Me.dgvData
			point = New Global.System.Drawing.Point(0, 0)
			dgvData.Location = point
			Me.dgvData.Name = "dgvData"
			Me.dgvData.RowHeadersVisible = False
			Dim dgvData2 As Global.System.Windows.Forms.Control = Me.dgvData
			size = New Global.System.Drawing.Size(480, 365)
			dgvData2.Size = size
			Me.dgvData.TabIndex = 0
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.txtName)
			Me.Panel1.Controls.Add(Me.lblClient)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(3, 16)
			panel3.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(480, 52)
			panel4.Size = size
			Me.Panel1.TabIndex = 1
			Me.txtName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtName.Font = New Global.System.Drawing.Font("Tahoma", 10F, Global.System.Drawing.FontStyle.Bold)
			Dim txtName As Global.System.Windows.Forms.Control = Me.txtName
			point = New Global.System.Drawing.Point(49, 12)
			txtName.Location = point
			Me.txtName.Name = "txtName"
			Dim txtName2 As Global.System.Windows.Forms.Control = Me.txtName
			size = New Global.System.Drawing.Size(269, 24)
			txtName2.Size = size
			Me.txtName.TabIndex = 203
			Me.txtName.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.lblClient.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblClient.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.lblClient.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblClient As Global.System.Windows.Forms.Control = Me.lblClient
			point = New Global.System.Drawing.Point(324, 12)
			lblClient.Location = point
			Me.lblClient.Name = "lblClient"
			Dim lblClient2 As Global.System.Windows.Forms.Control = Me.lblClient
			size = New Global.System.Drawing.Size(155, 22)
			lblClient2.Size = size
			Me.lblClient.TabIndex = 202
			Me.lblClient.Text = "ادخل أي جزء من الإســـــــم"
			Me.lblClient.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Column1.HeaderText = "id"
			Me.Column1.Name = "Column1"
			Me.Column1.Visible = False
			Me.Column3.HeaderText = "الإسم"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 300
			Me.Column5.HeaderText = ""
			Me.Column5.Name = "Column5"
			Me.Column5.Text = "اختر"
			Me.Column5.UseColumnTextForButtonValue = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(486, 436)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.MaximizeBox = False
			Me.Name = "frmSrchClient"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "بحث عميل / مورد"
			Me.GroupBox1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
