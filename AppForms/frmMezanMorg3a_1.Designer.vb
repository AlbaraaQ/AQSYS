Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmMezanMorg3a_1
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewButtonColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllBranches As CheckBox
    Friend WithEvents cmbBranches As ComboBox
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents lblHeader As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtIsBalanced As TextBox
    Friend WithEvents txtSum1 As TextBox
    Friend WithEvents txtSum2 As TextBox
    Friend WithEvents txtSum3 As TextBox
    Friend WithEvents txtSum4 As TextBox
    Friend WithEvents txtSum5 As TextBox
    Friend WithEvents txtSum6 As TextBox
    Friend WithEvents txtSum7 As TextBox
    Friend WithEvents txtSum8 As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmMezanMorg3a_1))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.txt2 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.chkAllBranches = New Global.System.Windows.Forms.CheckBox()
			Me.cmbBranches = New Global.System.Windows.Forms.ComboBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.lblHeader = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txt1 = New Global.System.Windows.Forms.TextBox()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.txtSum8 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum7 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum6 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum5 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum2 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum4 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum1 = New Global.System.Windows.Forms.TextBox()
			Me.txtSum3 = New Global.System.Windows.Forms.TextBox()
			Me.txtIsBalanced = New Global.System.Windows.Forms.TextBox()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewButtonColumn()
			Me.Panel1.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txt2, "txt2")
			Me.txt2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt2.Name = "txt2"
			Me.txt2.[ReadOnly] = True
			Me.Panel1.Controls.Add(Me.chkAllBranches)
			Me.Panel1.Controls.Add(Me.cmbBranches)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.btnPreview)
			Me.Panel1.Controls.Add(Me.lblHeader)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Controls.Add(Me.btnPrint)
			Me.Panel1.Controls.Add(Me.btnShow)
			Me.Panel1.Controls.Add(Me.txtDateTo)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.txtDateFrom)
			Me.Panel1.Controls.Add(Me.Label2)
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.chkAllBranches, "chkAllBranches")
			Me.chkAllBranches.Name = "chkAllBranches"
			Me.chkAllBranches.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbBranches, "cmbBranches")
			Me.cmbBranches.FormattingEnabled = True
			Me.cmbBranches.Name = "cmbBranches"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.lblHeader, "lblHeader")
			Me.lblHeader.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lblHeader.Name = "lblHeader"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txt1, "txt1")
			Me.txt1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt1.Name = "txt1"
			Me.txt1.[ReadOnly] = True
			Me.Panel3.Controls.Add(Me.txtSum8)
			Me.Panel3.Controls.Add(Me.txtSum7)
			Me.Panel3.Controls.Add(Me.txtSum6)
			Me.Panel3.Controls.Add(Me.txtSum5)
			Me.Panel3.Controls.Add(Me.txtSum2)
			Me.Panel3.Controls.Add(Me.txtSum4)
			Me.Panel3.Controls.Add(Me.txtSum1)
			Me.Panel3.Controls.Add(Me.txtSum3)
			Me.Panel3.Controls.Add(Me.txtIsBalanced)
			Me.Panel3.Controls.Add(Me.txt2)
			Me.Panel3.Controls.Add(Me.txt1)
			resources.ApplyResources(Me.Panel3, "Panel3")
			Me.Panel3.Name = "Panel3"
			resources.ApplyResources(Me.txtSum8, "txtSum8")
			Me.txtSum8.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum8.Name = "txtSum8"
			Me.txtSum8.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum7, "txtSum7")
			Me.txtSum7.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum7.Name = "txtSum7"
			Me.txtSum7.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum6, "txtSum6")
			Me.txtSum6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum6.Name = "txtSum6"
			Me.txtSum6.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum5, "txtSum5")
			Me.txtSum5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum5.Name = "txtSum5"
			Me.txtSum5.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum2, "txtSum2")
			Me.txtSum2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum2.Name = "txtSum2"
			Me.txtSum2.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum4, "txtSum4")
			Me.txtSum4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum4.Name = "txtSum4"
			Me.txtSum4.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum1, "txtSum1")
			Me.txtSum1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum1.Name = "txtSum1"
			Me.txtSum1.[ReadOnly] = True
			resources.ApplyResources(Me.txtSum3, "txtSum3")
			Me.txtSum3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSum3.Name = "txtSum3"
			Me.txtSum3.[ReadOnly] = True
			Me.txtIsBalanced.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			resources.ApplyResources(Me.txtIsBalanced, "txtIsBalanced")
			Me.txtIsBalanced.ForeColor = Global.System.Drawing.Color.Red
			Me.txtIsBalanced.Name = "txtIsBalanced"
			Me.txtIsBalanced.[ReadOnly] = True
			Me.Panel2.Controls.Add(Me.dgvSrch)
			resources.ApplyResources(Me.Panel2, "Panel2")
			Me.Panel2.Name = "Panel2"
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
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column8, Me.Column9, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column11, Me.Column7 })
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.MultiSelect = False
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.RowHeadersVisible = False
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column8, "Column8")
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			resources.ApplyResources(Me.Column9, "Column9")
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column10, "Column10")
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			resources.ApplyResources(Me.Column11, "Column11")
			Me.Column11.Name = "Column11"
			Me.Column11.[ReadOnly] = True
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Text = "details"
			Me.Column7.UseColumnTextForButtonValue = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Panel3)
			Me.Name = "frmMezanMorg3a"
			Me.ShowIcon = False
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
