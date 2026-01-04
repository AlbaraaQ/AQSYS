Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmNetsales
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdAvgCost As RadioButton
    Friend WithEvents rdLastPurchCost As RadioButton
    Friend WithEvents rdPurchCost As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtVal2 As TextBox
    Friend WithEvents txtVal3 As TextBox
    Friend WithEvents txtVal4 As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmNetsales))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.rdPurchCost = New Global.System.Windows.Forms.RadioButton()
			Me.rdAvgCost = New Global.System.Windows.Forms.RadioButton()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbCurrency = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtVal3 = New Global.System.Windows.Forms.TextBox()
			Me.txtVal2 = New Global.System.Windows.Forms.TextBox()
			Me.txtVal4 = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.rdLastPurchCost = New Global.System.Windows.Forms.RadioButton()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.GroupBox3)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.chkAll)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.cmbCurrency)
			Me.GroupBox1.Controls.Add(Me.Label1)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.GroupBox3, "GroupBox3")
			Me.GroupBox3.Controls.Add(Me.rdLastPurchCost)
			Me.GroupBox3.Controls.Add(Me.rdPurchCost)
			Me.GroupBox3.Controls.Add(Me.rdAvgCost)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.TabStop = False
			resources.ApplyResources(Me.rdPurchCost, "rdPurchCost")
			Me.rdPurchCost.Name = "rdPurchCost"
			Me.rdPurchCost.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.rdAvgCost, "rdAvgCost")
			Me.rdAvgCost.Checked = True
			Me.rdAvgCost.Name = "rdAvgCost"
			Me.rdAvgCost.TabStop = True
			Me.rdAvgCost.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
			Me.ProgressBar1.Name = "ProgressBar1"
			resources.ApplyResources(Me.chkAll, "chkAll")
			Me.chkAll.Name = "chkAll"
			Me.chkAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbCurrency, "cmbCurrency")
			Me.cmbCurrency.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCurrency.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCurrency.FormattingEnabled = True
			Me.cmbCurrency.Items.AddRange(New Object() { resources.GetString("cmbCurrency.Items") })
			Me.cmbCurrency.Name = "cmbCurrency"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6 })
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.Name = "dgvItems"
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Panel1.Controls.Add(Me.txtVal3)
			Me.Panel1.Controls.Add(Me.txtVal2)
			Me.Panel1.Controls.Add(Me.txtVal4)
			Me.Panel1.Controls.Add(Me.Label4)
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtVal3, "txtVal3")
			Me.txtVal3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtVal3.Name = "txtVal3"
			resources.ApplyResources(Me.txtVal2, "txtVal2")
			Me.txtVal2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtVal2.Name = "txtVal2"
			resources.ApplyResources(Me.txtVal4, "txtVal4")
			Me.txtVal4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtVal4.Name = "txtVal4"
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Label4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label4.Name = "Label4"
			Me.Timer1.Enabled = True
			resources.ApplyResources(Me.rdLastPurchCost, "rdLastPurchCost")
			Me.rdLastPurchCost.Name = "rdLastPurchCost"
			Me.rdLastPurchCost.UseVisualStyleBackColor = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmNetsales"
			Me.ShowIcon = False
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
