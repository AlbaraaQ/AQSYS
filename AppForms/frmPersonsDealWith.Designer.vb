Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmPersonsDealWith
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnJobAdd As Button
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbJob As ComboBox
    Friend WithEvents dgvPersons As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtName As TextBox
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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmPersonsDealWith))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.btnJobAdd = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvPersons = New Global.System.Windows.Forms.DataGridView()
			Me.cmbJob = New Global.System.Windows.Forms.ComboBox()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.txtMobile = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtTel = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtAddress = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.dgvPersons, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox2.Controls.Add(Me.btnJobAdd)
			Me.GroupBox2.Controls.Add(Me.GroupBox1)
			Me.GroupBox2.Controls.Add(Me.cmbJob)
			Me.GroupBox2.Controls.Add(Me.Label22)
			Me.GroupBox2.Controls.Add(Me.txtMobile)
			Me.GroupBox2.Controls.Add(Me.Label10)
			Me.GroupBox2.Controls.Add(Me.txtNotes)
			Me.GroupBox2.Controls.Add(Me.Label5)
			Me.GroupBox2.Controls.Add(Me.txtTel)
			Me.GroupBox2.Controls.Add(Me.Label2)
			Me.GroupBox2.Controls.Add(Me.txtAddress)
			Me.GroupBox2.Controls.Add(Me.Label4)
			Me.GroupBox2.Controls.Add(Me.txtName)
			Me.GroupBox2.Controls.Add(Me.Label7)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.btnJobAdd, "btnJobAdd")
			Me.btnJobAdd.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnJobAdd.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnJobAdd.Name = "btnJobAdd"
			Me.btnJobAdd.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Controls.Add(Me.dgvPersons)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.dgvPersons, "dgvPersons")
			Me.dgvPersons.AllowUserToAddRows = False
			Me.dgvPersons.AllowUserToDeleteRows = False
			Me.dgvPersons.AllowUserToOrderColumns = True
			Me.dgvPersons.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvPersons.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvPersons.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column1, Me.Column5, Me.Column6, Me.Column2 })
			Me.dgvPersons.MultiSelect = False
			Me.dgvPersons.Name = "dgvPersons"
			Me.dgvPersons.[ReadOnly] = True
			Me.dgvPersons.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.cmbJob, "cmbJob")
			Me.cmbJob.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbJob.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbJob.FormattingEnabled = True
			Me.cmbJob.Name = "cmbJob"
			resources.ApplyResources(Me.Label22, "Label22")
			Me.Label22.Name = "Label22"
			resources.ApplyResources(Me.txtMobile, "txtMobile")
			Me.txtMobile.Name = "txtMobile"
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			resources.ApplyResources(Me.txtNotes, "txtNotes")
			Me.txtNotes.Name = "txtNotes"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtTel, "txtTel")
			Me.txtTel.Name = "txtTel"
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtAddress, "txtAddress")
			Me.txtAddress.Name = "txtAddress"
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.txtName, "txtName")
			Me.txtName.Name = "txtName"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			resources.ApplyResources(Me.btnNew, "btnNew")
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Name = "btnNew"
			resources.ApplyResources(Me.btnSave, "btnSave")
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Name = "btnSave"
			resources.ApplyResources(Me.btnDelete, "btnDelete")
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Name = "btnDelete"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.panel2)
			Me.Name = "frmPersonsDealWith"
			Me.ShowIcon = False
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			CType(Me.dgvPersons, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
