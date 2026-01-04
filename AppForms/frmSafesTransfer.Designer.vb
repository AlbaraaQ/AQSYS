Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSafesTransfer
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
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents cmbSafeFrom As ComboBox
    Friend WithEvents cmbSafeTo As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents dgvSrch As DataGridView
    Friend WithEvents panel2 As Panel
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtFromDate As DateTimePicker
    Friend WithEvents txtNo As TextBox
    Friend WithEvents txtSrchNo As TextBox
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtVal As TextBox

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
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSafesTransfer))
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.TabControl1 = New Global.System.Windows.Forms.TabControl()
			Me.TabPage1 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column11 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.cmbCurrency = New Global.System.Windows.Forms.ComboBox()
			Me.txtBalance = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtVal = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.txtDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbSafeTo = New Global.System.Windows.Forms.ComboBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.cmbSafeFrom = New Global.System.Windows.Forms.ComboBox()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.TabPage2 = New Global.System.Windows.Forms.TabPage()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvSrch = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.txtSrchNo = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtToDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtFromDate = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
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
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.TabPage2.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox6.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			resources.ApplyResources(Me.TabControl1, "TabControl1")
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Me.TabPage1.Controls.Add(Me.GroupBox1)
			resources.ApplyResources(Me.TabPage1, "TabPage1")
			Me.TabPage1.Name = "TabPage1"
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox1.Controls.Add(Me.GroupBox3)
			Me.GroupBox1.Controls.Add(Me.GroupBox5)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.Blue
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			Me.GroupBox3.Controls.Add(Me.dgvItems)
			Me.GroupBox3.Controls.Add(Me.Panel1)
			resources.ApplyResources(Me.GroupBox3, "GroupBox3")
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.TabStop = False
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column6, Me.Column10, Me.Column11, Me.Column5 })
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column10, "Column10")
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			resources.ApplyResources(Me.Column11, "Column11")
			Me.Column11.Name = "Column11"
			Me.Column11.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Panel1.Controls.Add(Me.cmbCurrency)
			Me.Panel1.Controls.Add(Me.txtBalance)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.txtVal)
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.cmbCurrency, "cmbCurrency")
			Me.cmbCurrency.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCurrency.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCurrency.FormattingEnabled = True
			Me.cmbCurrency.Name = "cmbCurrency"
			resources.ApplyResources(Me.txtBalance, "txtBalance")
			Me.txtBalance.BackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			Me.txtBalance.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtBalance.ForeColor = Global.System.Drawing.Color.Red
			Me.txtBalance.Name = "txtBalance"
			Me.txtBalance.[ReadOnly] = True
			resources.ApplyResources(Me.Label10, "Label10")
			Me.Label10.Name = "Label10"
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.Name = "Label8"
			resources.ApplyResources(Me.txtVal, "txtVal")
			Me.txtVal.Name = "txtVal"
			Me.GroupBox5.Controls.Add(Me.txtDate)
			Me.GroupBox5.Controls.Add(Me.Label5)
			Me.GroupBox5.Controls.Add(Me.cmbSafeTo)
			Me.GroupBox5.Controls.Add(Me.Label4)
			Me.GroupBox5.Controls.Add(Me.cmbSafeFrom)
			Me.GroupBox5.Controls.Add(Me.txtNo)
			Me.GroupBox5.Controls.Add(Me.Label3)
			Me.GroupBox5.Controls.Add(Me.Label9)
			resources.ApplyResources(Me.GroupBox5, "GroupBox5")
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.TabStop = False
			resources.ApplyResources(Me.txtDate, "txtDate")
			Me.txtDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtDate.Name = "txtDate"
			Dim txtDate As Global.System.Windows.Forms.DateTimePicker = Me.txtDate
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 22, 0, 0, 0, 0)
			txtDate.Value = dateTime
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.cmbSafeTo, "cmbSafeTo")
			Me.cmbSafeTo.FormattingEnabled = True
			Me.cmbSafeTo.Name = "cmbSafeTo"
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.cmbSafeFrom, "cmbSafeFrom")
			Me.cmbSafeFrom.FormattingEnabled = True
			Me.cmbSafeFrom.Name = "cmbSafeFrom"
			resources.ApplyResources(Me.txtNo, "txtNo")
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.Label9, "Label9")
			Me.Label9.Name = "Label9"
			Me.TabPage2.Controls.Add(Me.GroupBox4)
			Me.TabPage2.Controls.Add(Me.GroupBox6)
			resources.ApplyResources(Me.TabPage2, "TabPage2")
			Me.TabPage2.Name = "TabPage2"
			Me.TabPage2.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox4.Controls.Add(Me.dgvSrch)
			resources.ApplyResources(Me.GroupBox4, "GroupBox4")
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.TabStop = False
			Me.dgvSrch.AllowUserToAddRows = False
			Me.dgvSrch.AllowUserToDeleteRows = False
			Me.dgvSrch.AllowUserToOrderColumns = True
			Me.dgvSrch.BackgroundColor = Global.System.Drawing.Color.FromArgb(192, 192, 255)
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvSrch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvSrch.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvSrch.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4 })
			resources.ApplyResources(Me.dgvSrch, "dgvSrch")
			Me.dgvSrch.MultiSelect = False
			Me.dgvSrch.Name = "dgvSrch"
			Me.dgvSrch.[ReadOnly] = True
			Me.dgvSrch.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.LightBlue
			Me.GroupBox6.Controls.Add(Me.txtSrchNo)
			Me.GroupBox6.Controls.Add(Me.Label15)
			Me.GroupBox6.Controls.Add(Me.txtToDate)
			Me.GroupBox6.Controls.Add(Me.Label2)
			Me.GroupBox6.Controls.Add(Me.txtFromDate)
			Me.GroupBox6.Controls.Add(Me.Label1)
			Me.GroupBox6.Controls.Add(Me.btnSearch)
			resources.ApplyResources(Me.GroupBox6, "GroupBox6")
			Me.GroupBox6.Name = "GroupBox6"
			Me.GroupBox6.TabStop = False
			resources.ApplyResources(Me.txtSrchNo, "txtSrchNo")
			Me.txtSrchNo.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtSrchNo.Name = "txtSrchNo"
			resources.ApplyResources(Me.Label15, "Label15")
			Me.Label15.Name = "Label15"
			resources.ApplyResources(Me.txtToDate, "txtToDate")
			Me.txtToDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtToDate.Name = "txtToDate"
			Dim txtToDate As Global.System.Windows.Forms.DateTimePicker = Me.txtToDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtToDate.Value = dateTime
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtFromDate, "txtFromDate")
			Me.txtFromDate.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Me.txtFromDate.Name = "txtFromDate"
			Dim txtFromDate As Global.System.Windows.Forms.DateTimePicker = Me.txtFromDate
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtFromDate.Value = dateTime
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.btnSearch, "btnSearch")
			Me.btnSearch.BackColor = Global.System.Drawing.Color.White
			Me.btnSearch.ForeColor = Global.System.Drawing.Color.Lime
			Me.btnSearch.Image = My.Resources.Resources.search_icon
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.UseVisualStyleBackColor = False
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
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
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnPrint.Name = "btnPrint"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.DisplayStyle = Global.System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btnClose.Name = "btnClose"
			Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.toolStrip1)
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.Name = "panel2"
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "frmSafesTransfer"
			Me.ShowIcon = False
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox3.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.TabPage2.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			CType(Me.dgvSrch, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
