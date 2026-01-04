Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptSalary
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtMonth As NumericUpDown
    Friend WithEvents txtSum As Label
    Friend WithEvents txtSumAdds As Label
    Friend WithEvents txtSumDisc As Label
    Friend WithEvents txtSumNet As Label
    Friend WithEvents txtSumSlf As Label
    Friend WithEvents txtYear As NumericUpDown

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRptSalary))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.BackgroundWorker1 = New Global.System.ComponentModel.BackgroundWorker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSumSlf = New Global.System.Windows.Forms.Label()
			Me.txtSumNet = New Global.System.Windows.Forms.Label()
			Me.txtSumDisc = New Global.System.Windows.Forms.Label()
			Me.txtSumAdds = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.txtYear = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtMonth = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.txtYear, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.txtMonth, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 1
			Me.BackgroundWorker1.WorkerReportsProgress = True
			Me.BackgroundWorker1.WorkerSupportsCancellation = True
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.BackColor = Global.System.Drawing.SystemColors.Control
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtSum, "txtSum")
			Me.txtSum.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSum.Name = "txtSum"
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 9F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6 })
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.RowHeadersVisible = False
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Controls.Add(Me.txtSumSlf)
			Me.Panel1.Controls.Add(Me.txtSumNet)
			Me.Panel1.Controls.Add(Me.txtSumDisc)
			Me.Panel1.Controls.Add(Me.txtSumAdds)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.txtSum)
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtSumSlf, "txtSumSlf")
			Me.txtSumSlf.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSumSlf.Name = "txtSumSlf"
			resources.ApplyResources(Me.txtSumNet, "txtSumNet")
			Me.txtSumNet.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSumNet.Name = "txtSumNet"
			resources.ApplyResources(Me.txtSumDisc, "txtSumDisc")
			Me.txtSumDisc.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSumDisc.Name = "txtSumDisc"
			resources.ApplyResources(Me.txtSumAdds, "txtSumAdds")
			Me.txtSumAdds.BackColor = Global.System.Drawing.SystemColors.Control
			Me.txtSumAdds.Name = "txtSumAdds"
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox1.Controls.Add(Me.Button1)
			Me.GroupBox1.Controls.Add(Me.txtYear)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtMonth)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.Name = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.txtYear, "txtYear")
			Dim txtYear As Global.System.Windows.Forms.NumericUpDown = Me.txtYear
			Dim num As Decimal = New Decimal(New Integer() { 2100, 0, 0, 0 })
			txtYear.Maximum = num
			Dim txtYear2 As Global.System.Windows.Forms.NumericUpDown = Me.txtYear
			num = New Decimal(New Integer() { 1900, 0, 0, 0 })
			txtYear2.Minimum = num
			Me.txtYear.Name = "txtYear"
			Dim txtYear3 As Global.System.Windows.Forms.NumericUpDown = Me.txtYear
			num = New Decimal(New Integer() { 2017, 0, 0, 0 })
			txtYear3.Value = num
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.txtMonth, "txtMonth")
			Dim txtMonth As Global.System.Windows.Forms.NumericUpDown = Me.txtMonth
			num = New Decimal(New Integer() { 12, 0, 0, 0 })
			txtMonth.Maximum = num
			Dim txtMonth2 As Global.System.Windows.Forms.NumericUpDown = Me.txtMonth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			txtMonth2.Minimum = num
			Me.txtMonth.Name = "txtMonth"
			Dim txtMonth3 As Global.System.Windows.Forms.NumericUpDown = Me.txtMonth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			txtMonth3.Value = num
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
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
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmRptSalary"
			Me.ShowIcon = False
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.txtYear, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.txtMonth, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
