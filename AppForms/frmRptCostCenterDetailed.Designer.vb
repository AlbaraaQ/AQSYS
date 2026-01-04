Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptCostCenterDetailed
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbCenter As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents txtBalance1 As TextBox
    Friend WithEvents txtBalance2 As TextBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtTotCredit As TextBox
    Friend WithEvents txtTotDept As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRptCostCenterDetailed))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.txtBalance2 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox5 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox4 = New Global.System.Windows.Forms.TextBox()
			Me.txtTotCredit = New Global.System.Windows.Forms.TextBox()
			Me.txtTotDept = New Global.System.Windows.Forms.TextBox()
			Me.txtBalance1 = New Global.System.Windows.Forms.TextBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.cmbCenter = New Global.System.Windows.Forms.ComboBox()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel3.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.txtBalance2, "txtBalance2")
			Me.txtBalance2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtBalance2.Name = "txtBalance2"
			Me.txtBalance2.[ReadOnly] = True
			resources.ApplyResources(Me.TextBox5, "TextBox5")
			Me.TextBox5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox5.Name = "TextBox5"
			Me.TextBox5.[ReadOnly] = True
			resources.ApplyResources(Me.TextBox4, "TextBox4")
			Me.TextBox4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox4.Name = "TextBox4"
			Me.TextBox4.[ReadOnly] = True
			resources.ApplyResources(Me.txtTotCredit, "txtTotCredit")
			Me.txtTotCredit.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotCredit.Name = "txtTotCredit"
			Me.txtTotCredit.[ReadOnly] = True
			resources.ApplyResources(Me.txtTotDept, "txtTotDept")
			Me.txtTotDept.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtTotDept.Name = "txtTotDept"
			Me.txtTotDept.[ReadOnly] = True
			resources.ApplyResources(Me.txtBalance1, "txtBalance1")
			Me.txtBalance1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtBalance1.Name = "txtBalance1"
			Me.txtBalance1.[ReadOnly] = True
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column3, Me.Column7, Me.Column4, Me.Column5, Me.Column6, Me.Column2 })
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.MultiSelect = False
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.RowHeadersVisible = False
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column2.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.Automatic
			Me.Column2.Text = "view"
			Me.Column2.UseColumnTextForButtonValue = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 26, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.Panel3.Controls.Add(Me.txtBalance2)
			Me.Panel3.Controls.Add(Me.TextBox5)
			Me.Panel3.Controls.Add(Me.TextBox4)
			Me.Panel3.Controls.Add(Me.txtTotCredit)
			Me.Panel3.Controls.Add(Me.txtBalance1)
			Me.Panel3.Controls.Add(Me.txtTotDept)
			resources.ApplyResources(Me.Panel3, "Panel3")
			Me.Panel3.Name = "Panel3"
			resources.ApplyResources(Me.chkAll, "chkAll")
			Me.chkAll.Name = "chkAll"
			Me.chkAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			dateTime = New Global.System.DateTime(2012, 9, 26, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			Me.GroupBox2.Controls.Add(Me.dgvSrch)
			Me.GroupBox2.Controls.Add(Me.Panel3)
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			Me.GroupBox1.Controls.Add(Me.chkAll)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.cmbCenter)
			Me.GroupBox1.Controls.Add(Me.Label1)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.cmbCenter, "cmbCenter")
			Me.cmbCenter.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCenter.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCenter.FormattingEnabled = True
			Me.cmbCenter.Name = "cmbCenter"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmRptCostCenterDetailed"
			Me.ShowIcon = False
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
