Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptZatca
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewButtonColumn
    Friend WithEvents Column15 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkSelectAll As CheckBox
    Friend WithEvents chkWar As CheckBox
    Friend WithEvents colSelect As DataGridViewTextBoxColumn
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdAll As RadioButton
    Friend WithEvents rdFail As RadioButton
    Friend WithEvents rdInvRest As RadioButton
    Friend WithEvents rdInvSales As RadioButton
    Friend WithEvents rdNotInteg As RadioButton
    Friend WithEvents rdSuccess As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRptZatca))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.rdInvSales = New Global.System.Windows.Forms.RadioButton()
			Me.rdInvRest = New Global.System.Windows.Forms.RadioButton()
			Me.chkSelectAll = New Global.System.Windows.Forms.CheckBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.rdAll = New Global.System.Windows.Forms.RadioButton()
			Me.rdNotInteg = New Global.System.Windows.Forms.RadioButton()
			Me.chkWar = New Global.System.Windows.Forms.CheckBox()
			Me.rdFail = New Global.System.Windows.Forms.RadioButton()
			Me.rdSuccess = New Global.System.Windows.Forms.RadioButton()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.colSelect = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column12 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column13 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column14 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Column15 = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.AliceBlue
			Me.GroupBox1.Controls.Add(Me.rdInvSales)
			Me.GroupBox1.Controls.Add(Me.rdInvRest)
			Me.GroupBox1.Controls.Add(Me.chkSelectAll)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.GroupBox3)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.rdInvSales, "rdInvSales")
			Me.rdInvSales.Checked = True
			Me.rdInvSales.Name = "rdInvSales"
			Me.rdInvSales.TabStop = True
			Me.rdInvSales.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdInvRest, "rdInvRest")
			Me.rdInvRest.Name = "rdInvRest"
			Me.rdInvRest.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.chkSelectAll, "chkSelectAll")
			Me.chkSelectAll.Name = "chkSelectAll"
			Me.chkSelectAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.BackColor = Global.System.Drawing.Color.White
			Me.Button1.Name = "Button1"
			Me.Button1.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.GroupBox3, "GroupBox3")
			Me.GroupBox3.Controls.Add(Me.GroupBox4)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.TabStop = False
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.Controls.Add(Me.rdAll)
			Me.GroupBox4.Controls.Add(Me.rdNotInteg)
			Me.GroupBox4.Controls.Add(Me.chkWar)
			Me.GroupBox4.Controls.Add(Me.rdFail)
			Me.GroupBox4.Controls.Add(Me.rdSuccess)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			resources.ApplyResources(Me.rdAll, "rdAll")
			Me.rdAll.Checked = True
			Me.rdAll.Name = "rdAll"
			Me.rdAll.TabStop = True
			Me.rdAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdNotInteg, "rdNotInteg")
			Me.rdNotInteg.Name = "rdNotInteg"
			Me.rdNotInteg.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.chkWar, "chkWar")
			Me.chkWar.Name = "chkWar"
			Me.chkWar.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdFail, "rdFail")
			Me.rdFail.Name = "rdFail"
			Me.rdFail.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdSuccess, "rdSuccess")
			Me.rdSuccess.Name = "rdSuccess"
			Me.rdSuccess.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
			Me.ProgressBar1.Name = "ProgressBar1"
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.BackColor = Global.System.Drawing.Color.White
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = False
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.BackColor = Global.System.Drawing.Color.White
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = False
			Me.Timer1.Interval = 500
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.dgvItems, "dgvItems")
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.colSelect, Me.Column5, Me.Column1, Me.Column2, Me.Column6, Me.Column3, Me.Column7, Me.Column8, Me.Column9, Me.Column12, Me.Column13, Me.Column10, Me.Column11, Me.Column14, Me.Column15 })
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.RowHeadersVisible = False
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.colSelect, "colSelect")
			Me.colSelect.Name = "colSelect"
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			resources.ApplyResources(Me.Column8, "Column8")
			Me.Column8.Name = "Column8"
			resources.ApplyResources(Me.Column9, "Column9")
			Me.Column9.Name = "Column9"
			resources.ApplyResources(Me.Column12, "Column12")
			Me.Column12.Name = "Column12"
			resources.ApplyResources(Me.Column13, "Column13")
			Me.Column13.Name = "Column13"
			resources.ApplyResources(Me.Column10, "Column10")
			Me.Column10.Name = "Column10"
			resources.ApplyResources(Me.Column11, "Column11")
			Me.Column11.Name = "Column11"
			resources.ApplyResources(Me.Column14, "Column14")
			Me.Column14.Name = "Column14"
			Me.Column14.Text = "View"
			Me.Column14.UseColumnTextForButtonValue = True
			Me.Column15.FalseValue = "0"
			resources.ApplyResources(Me.Column15, "Column15")
			Me.Column15.Name = "Column15"
			Me.Column15.TrueValue = "1"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmRptZatca"
			Me.ShowIcon = False
			Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
