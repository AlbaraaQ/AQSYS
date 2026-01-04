Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmCities
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnCountryAdd As Button
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents dgvCities As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmCities))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnDelete = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnPrint = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnSave = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnNew = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnLast = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New Global.System.Windows.Forms.ToolStripSeparator()
			Me.btnNext = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnFirst = New Global.System.Windows.Forms.ToolStripButton()
			Me.toolStrip1 = New Global.System.Windows.Forms.ToolStrip()
			Me.btnPrevious = New Global.System.Windows.Forms.ToolStripButton()
			Me.btnClose = New Global.System.Windows.Forms.ToolStripButton()
			Me.panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvCities = New Global.System.Windows.Forms.DataGridView()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.btnCountryAdd = New Global.System.Windows.Forms.Button()
			Me.cmbCountry = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.dgvCities, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.btnDelete, "btnDelete")
			Me.btnDelete.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnDelete.Name = "btnDelete"
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnSave, "btnSave")
			Me.btnSave.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnSave.Name = "btnSave"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.btnNew, "btnNew")
			Me.btnNew.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNew.Name = "btnNew"
			resources.ApplyResources(Me.btnLast, "btnLast")
			Me.btnLast.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnLast.Name = "btnLast"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.btnNext, "btnNext")
			Me.btnNext.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnNext.Name = "btnNext"
			resources.ApplyResources(Me.btnFirst, "btnFirst")
			Me.btnFirst.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnFirst.Image = My.Resources.Resources.Firstt
			Me.btnFirst.Name = "btnFirst"
			resources.ApplyResources(Me.toolStrip1, "toolStrip1")
			Me.toolStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnPrint, Me.btnClose })
			Me.toolStrip1.Name = "toolStrip1"
			resources.ApplyResources(Me.btnPrevious, "btnPrevious")
			Me.btnPrevious.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrevious.Name = "btnPrevious"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Name = "btnClose"
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me.dgvCities, "dgvCities")
			Me.dgvCities.AllowUserToAddRows = False
			Me.dgvCities.AllowUserToDeleteRows = False
			Me.dgvCities.AllowUserToOrderColumns = True
			Me.dgvCities.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvCities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvCities.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvCities.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column3, Me.Column1, Me.Column2, Me.Column4 })
			Me.dgvCities.MultiSelect = False
			Me.dgvCities.Name = "dgvCities"
			Me.dgvCities.[ReadOnly] = True
			Me.dgvCities.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.btnCountryAdd, "btnCountryAdd")
			Me.btnCountryAdd.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.btnCountryAdd.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnCountryAdd.Name = "btnCountryAdd"
			Me.btnCountryAdd.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.cmbCountry, "cmbCountry")
			Me.cmbCountry.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCountry.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCountry.FormattingEnabled = True
			Me.cmbCountry.Name = "cmbCountry"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.txtName, "txtName")
			Me.txtName.Name = "txtName"
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.dgvCities)
			Me.GroupBox1.Controls.Add(Me.btnCountryAdd)
			Me.GroupBox1.Controls.Add(Me.cmbCountry)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtName)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmCities"
			Me.ShowIcon = False
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			CType(Me.dgvCities, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
