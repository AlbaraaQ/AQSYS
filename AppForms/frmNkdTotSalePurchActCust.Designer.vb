Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmNkdTotSalePurchActCust
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button11 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllActs As CheckBox
    Friend WithEvents chkAllCust As CheckBox
    Friend WithEvents cmbActs As ComboBox
    Friend WithEvents cmbCust As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumPurch As Label
    Friend WithEvents txtSumSale As Label

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmNkdTotSalePurchActCust))
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.chkAllCust = New Global.System.Windows.Forms.CheckBox()
			Me.cmbCust = New Global.System.Windows.Forms.ComboBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.chkAllActs = New Global.System.Windows.Forms.CheckBox()
			Me.cmbActs = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSumSale = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.txtSumPurch = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Button11 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel3.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 23, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			Me.GroupBox1.Controls.Add(Me.Button11)
			Me.GroupBox1.Controls.Add(Me.chkAllCust)
			Me.GroupBox1.Controls.Add(Me.cmbCust)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.chkAllActs)
			Me.GroupBox1.Controls.Add(Me.cmbActs)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.chkAllCust, "chkAllCust")
			Me.chkAllCust.Name = "chkAllCust"
			Me.chkAllCust.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbCust, "cmbCust")
			Me.cmbCust.FormattingEnabled = True
			Me.cmbCust.Name = "cmbCust"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.chkAllActs, "chkAllActs")
			Me.chkAllActs.Name = "chkAllActs"
			Me.chkAllActs.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbActs, "cmbActs")
			Me.cmbActs.FormattingEnabled = True
			Me.cmbActs.Name = "cmbActs"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.GroupBox2.Controls.Add(Me.Panel3)
			Me.GroupBox2.Controls.Add(Me.Panel2)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			Me.Panel3.Controls.Add(Me.dgvItems)
			resources.ApplyResources(Me.Panel3, "Panel3")
			Me.Panel3.Name = "Panel3"
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5 })
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Panel2.Controls.Add(Me.Label5)
			Me.Panel2.Controls.Add(Me.Label2)
			resources.ApplyResources(Me.Panel2, "Panel2")
			Me.Panel2.Name = "Panel2"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label2.Name = "Label2"
			Me.Panel1.Controls.Add(Me.txtSumSale)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Controls.Add(Me.txtSumPurch)
			Me.Panel1.Controls.Add(Me.Label6)
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtSumSale, "txtSumSale")
			Me.txtSumSale.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumSale.Name = "txtSumSale"
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label9.Name = "Label9"
			resources.ApplyResources(Me.txtSumPurch, "txtSumPurch")
			Me.txtSumPurch.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSumPurch.Name = "txtSumPurch"
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.Button11, "Button11")
			Me.Button11.Name = "Button11"
			Me.Button11.UseVisualStyleBackColor = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmNkdTotSalePurchActCust"
			Me.ShowIcon = False
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
