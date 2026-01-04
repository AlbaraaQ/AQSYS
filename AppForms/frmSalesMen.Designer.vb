Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSalesMen
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtComm As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNameSrch As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtTel As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSalesMen))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.txtMobile = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtEmail = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtTel = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtComm = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvData = New Global.System.Windows.Forms.DataGridView()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.txtNameSrch = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.OpenFileDialog1 = New Global.System.Windows.Forms.OpenFileDialog()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Controls.Add(Me.GroupBox1)
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.txtMobile)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.txtEmail)
			Me.GroupBox1.Controls.Add(Me.Label10)
			Me.GroupBox1.Controls.Add(Me.txtNotes)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.txtTel)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.txtComm)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.txtName)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.Name = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtMobile, "txtMobile")
			Me.txtMobile.Name = "txtMobile"
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			resources.ApplyResources(Me.txtEmail, "txtEmail")
			Me.txtEmail.Name = "txtEmail"
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			resources.ApplyResources(Me.txtNotes, "txtNotes")
			Me.txtNotes.Name = "txtNotes"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtTel, "txtTel")
			Me.txtTel.Name = "txtTel"
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.txtComm, "txtComm")
			Me.txtComm.Name = "txtComm"
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtName, "txtName")
			Me.txtName.Name = "txtName"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvData)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			resources.ApplyResources(Me.dgvData, "dgvData")
			Me.dgvData.AllowUserToAddRows = False
			Me.dgvData.AllowUserToDeleteRows = False
			Me.dgvData.AllowUserToOrderColumns = True
			Me.dgvData.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvData.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvData.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column9, Me.Column7, Me.Column8 })
			Me.dgvData.Name = "dgvData"
			Me.dgvData.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			Me.GroupBox6.Controls.Add(Me.txtNameSrch)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			resources.ApplyResources(Me.btnSearch, "btnSearch")
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.txtNameSrch, "txtNameSrch")
			Me.txtNameSrch.Name = "txtNameSrch"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.btnDelete, "btnDelete")
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Name = "btnDelete"
			resources.ApplyResources(Me.btnSave, "btnSave")
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Name = "btnSave"
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnNew, "btnNew")
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Name = "btnNew"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			resources.ApplyResources(Me.Column9, "Column9")
			Me.Column9.Name = "Column9"
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			resources.ApplyResources(Me.Column8, "Column8")
			Me.Column8.Name = "Column8"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "frmSalesMen"
			Me.ShowIcon = False
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvData, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
