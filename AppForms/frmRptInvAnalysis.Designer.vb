Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptInvAnalysis
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAllCust As CheckBox
    Friend WithEvents chkAllEmp As CheckBox
    Friend WithEvents chkAllGroups As CheckBox
    Friend WithEvents chkAllSafe As CheckBox
    Friend WithEvents chkAllSales As CheckBox
    Friend WithEvents chkAllStock As CheckBox
    Friend WithEvents cmbCust As ComboBox
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents cmbSafe As ComboBox
    Friend WithEvents cmbSales As ComboBox
    Friend WithEvents cmbStock As ComboBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents rdCust As RadioButton
    Friend WithEvents rdDay As RadioButton
    Friend WithEvents rdEmp As RadioButton
    Friend WithEvents rdGroup As RadioButton
    Friend WithEvents rdItem As RadioButton
    Friend WithEvents rdMonth As RadioButton
    Friend WithEvents rdSalesman As RadioButton
    Friend WithEvents rdStock As RadioButton
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSum1 As Label
    Friend WithEvents txtSum2 As Label
    Friend WithEvents txtSum3 As Label
    Friend WithEvents txtSum4 As Label
    Friend WithEvents txtSum5 As Label

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
			Me.chkAllEmp = New Global.System.Windows.Forms.CheckBox()
			Me.chkAllSales = New Global.System.Windows.Forms.CheckBox()
			Me.rdCust = New Global.System.Windows.Forms.RadioButton()
			Me.chkAllSafe = New Global.System.Windows.Forms.CheckBox()
			Me.chkAllStock = New Global.System.Windows.Forms.CheckBox()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.rdGroup = New Global.System.Windows.Forms.RadioButton()
			Me.rdEmp = New Global.System.Windows.Forms.RadioButton()
			Me.rdMonth = New Global.System.Windows.Forms.RadioButton()
			Me.rdSalesman = New Global.System.Windows.Forms.RadioButton()
			Me.rdItem = New Global.System.Windows.Forms.RadioButton()
			Me.rdDay = New Global.System.Windows.Forms.RadioButton()
			Me.rdStock = New Global.System.Windows.Forms.RadioButton()
			Me.chkAllGroups = New Global.System.Windows.Forms.CheckBox()
			Me.chkAllCust = New Global.System.Windows.Forms.CheckBox()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbGroups = New Global.System.Windows.Forms.ComboBox()
			Me.cmbEmp = New Global.System.Windows.Forms.ComboBox()
			Me.cmbSales = New Global.System.Windows.Forms.ComboBox()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column8 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column9 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column10 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.txtSum5 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtSum4 = New Global.System.Windows.Forms.Label()
			Me.txtSum2 = New Global.System.Windows.Forms.Label()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.txtSum3 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.txtSum1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.cmbCust = New Global.System.Windows.Forms.ComboBox()
			Me.cmbSafe = New Global.System.Windows.Forms.ComboBox()
			Me.cmbStock = New Global.System.Windows.Forms.ComboBox()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel4.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.chkAllEmp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllEmp.AutoSize = True
			Me.chkAllEmp.Checked = True
			Me.chkAllEmp.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllEmp As Global.System.Windows.Forms.Control = Me.chkAllEmp
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(125, 74)
			chkAllEmp.Location = point
			Me.chkAllEmp.Name = "chkAllEmp"
			Dim chkAllEmp2 As Global.System.Windows.Forms.Control = Me.chkAllEmp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(50, 17)
			chkAllEmp2.Size = size
			Me.chkAllEmp.TabIndex = 11
			Me.chkAllEmp.Text = "الكل"
			Me.chkAllEmp.UseVisualStyleBackColor = True
			Me.chkAllSales.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllSales.AutoSize = True
			Me.chkAllSales.Checked = True
			Me.chkAllSales.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllSales As Global.System.Windows.Forms.Control = Me.chkAllSales
			point = New Global.System.Drawing.Point(366, 122)
			chkAllSales.Location = point
			Me.chkAllSales.Name = "chkAllSales"
			Dim chkAllSales2 As Global.System.Windows.Forms.Control = Me.chkAllSales
			size = New Global.System.Drawing.Size(50, 17)
			chkAllSales2.Size = size
			Me.chkAllSales.TabIndex = 10
			Me.chkAllSales.Text = "الكل"
			Me.chkAllSales.UseVisualStyleBackColor = True
			Me.rdCust.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdCust.AutoSize = True
			Dim rdCust As Global.System.Windows.Forms.Control = Me.rdCust
			point = New Global.System.Drawing.Point(624, 21)
			rdCust.Location = point
			Me.rdCust.Name = "rdCust"
			Dim rdCust2 As Global.System.Windows.Forms.Control = Me.rdCust
			size = New Global.System.Drawing.Size(59, 17)
			rdCust2.Size = size
			Me.rdCust.TabIndex = 12
			Me.rdCust.Text = "العميل"
			Me.rdCust.UseVisualStyleBackColor = True
			Me.chkAllSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllSafe.AutoSize = True
			Me.chkAllSafe.Checked = True
			Me.chkAllSafe.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllSafe As Global.System.Windows.Forms.Control = Me.chkAllSafe
			point = New Global.System.Drawing.Point(585, 122)
			chkAllSafe.Location = point
			Me.chkAllSafe.Name = "chkAllSafe"
			Dim chkAllSafe2 As Global.System.Windows.Forms.Control = Me.chkAllSafe
			size = New Global.System.Drawing.Size(50, 17)
			chkAllSafe2.Size = size
			Me.chkAllSafe.TabIndex = 11
			Me.chkAllSafe.Text = "الكل"
			Me.chkAllSafe.UseVisualStyleBackColor = True
			Me.chkAllStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllStock.AutoSize = True
			Me.chkAllStock.Checked = True
			Me.chkAllStock.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllStock As Global.System.Windows.Forms.Control = Me.chkAllStock
			point = New Global.System.Drawing.Point(796, 122)
			chkAllStock.Location = point
			Me.chkAllStock.Name = "chkAllStock"
			Dim chkAllStock2 As Global.System.Windows.Forms.Control = Me.chkAllStock
			size = New Global.System.Drawing.Size(50, 17)
			chkAllStock2.Size = size
			Me.chkAllStock.TabIndex = 10
			Me.chkAllStock.Text = "الكل"
			Me.chkAllStock.UseVisualStyleBackColor = True
			Me.btnPreview.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPreview As Global.System.Windows.Forms.Control = Me.btnPreview
			point = New Global.System.Drawing.Point(655, 159)
			btnPreview.Location = point
			Me.btnPreview.Name = "btnPreview"
			Dim btnPreview2 As Global.System.Windows.Forms.Control = Me.btnPreview
			size = New Global.System.Drawing.Size(92, 41)
			btnPreview2.Size = size
			Me.btnPreview.TabIndex = 5
			Me.btnPreview.Text = "معاينة"
			Me.btnPreview.UseVisualStyleBackColor = True
			Me.rdGroup.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdGroup.AutoSize = True
			Dim rdGroup As Global.System.Windows.Forms.Control = Me.rdGroup
			point = New Global.System.Drawing.Point(70, 21)
			rdGroup.Location = point
			Me.rdGroup.Name = "rdGroup"
			Dim rdGroup2 As Global.System.Windows.Forms.Control = Me.rdGroup
			size = New Global.System.Drawing.Size(105, 17)
			rdGroup2.Size = size
			Me.rdGroup.TabIndex = 12
			Me.rdGroup.Text = "مجموعة الصنف"
			Me.rdGroup.UseVisualStyleBackColor = True
			Me.rdEmp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdEmp.AutoSize = True
			Dim rdEmp As Global.System.Windows.Forms.Control = Me.rdEmp
			point = New Global.System.Drawing.Point(192, 21)
			rdEmp.Location = point
			Me.rdEmp.Name = "rdEmp"
			Dim rdEmp2 As Global.System.Windows.Forms.Control = Me.rdEmp
			size = New Global.System.Drawing.Size(78, 17)
			rdEmp2.Size = size
			Me.rdEmp.TabIndex = 12
			Me.rdEmp.Text = "المستخدم"
			Me.rdEmp.UseVisualStyleBackColor = True
			Me.rdMonth.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdMonth.AutoSize = True
			Dim rdMonth As Global.System.Windows.Forms.Control = Me.rdMonth
			point = New Global.System.Drawing.Point(466, 21)
			rdMonth.Location = point
			Me.rdMonth.Name = "rdMonth"
			Dim rdMonth2 As Global.System.Windows.Forms.Control = Me.rdMonth
			size = New Global.System.Drawing.Size(63, 17)
			rdMonth2.Size = size
			Me.rdMonth.TabIndex = 12
			Me.rdMonth.Text = "الشهور"
			Me.rdMonth.UseVisualStyleBackColor = True
			Me.rdSalesman.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdSalesman.AutoSize = True
			Dim rdSalesman As Global.System.Windows.Forms.Control = Me.rdSalesman
			point = New Global.System.Drawing.Point(290, 21)
			rdSalesman.Location = point
			Me.rdSalesman.Name = "rdSalesman"
			Dim rdSalesman2 As Global.System.Windows.Forms.Control = Me.rdSalesman
			size = New Global.System.Drawing.Size(84, 17)
			rdSalesman2.Size = size
			Me.rdSalesman.TabIndex = 12
			Me.rdSalesman.Text = "مندوب البيع"
			Me.rdSalesman.UseVisualStyleBackColor = True
			Me.rdItem.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdItem.AutoSize = True
			Dim rdItem As Global.System.Windows.Forms.Control = Me.rdItem
			point = New Global.System.Drawing.Point(543, 21)
			rdItem.Location = point
			Me.rdItem.Name = "rdItem"
			Dim rdItem2 As Global.System.Windows.Forms.Control = Me.rdItem
			size = New Global.System.Drawing.Size(60, 17)
			rdItem2.Size = size
			Me.rdItem.TabIndex = 12
			Me.rdItem.Text = "الصنف"
			Me.rdItem.UseVisualStyleBackColor = True
			Me.rdDay.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdDay.AutoSize = True
			Dim rdDay As Global.System.Windows.Forms.Control = Me.rdDay
			point = New Global.System.Drawing.Point(392, 21)
			rdDay.Location = point
			Me.rdDay.Name = "rdDay"
			Dim rdDay2 As Global.System.Windows.Forms.Control = Me.rdDay
			size = New Global.System.Drawing.Size(52, 17)
			rdDay2.Size = size
			Me.rdDay.TabIndex = 12
			Me.rdDay.Text = "الأيام"
			Me.rdDay.UseVisualStyleBackColor = True
			Me.rdStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.rdStock.AutoSize = True
			Me.rdStock.Checked = True
			Dim rdStock As Global.System.Windows.Forms.Control = Me.rdStock
			point = New Global.System.Drawing.Point(702, 21)
			rdStock.Location = point
			Me.rdStock.Name = "rdStock"
			Dim rdStock2 As Global.System.Windows.Forms.Control = Me.rdStock
			size = New Global.System.Drawing.Size(63, 17)
			rdStock2.Size = size
			Me.rdStock.TabIndex = 12
			Me.rdStock.TabStop = True
			Me.rdStock.Text = "المخزن"
			Me.rdStock.UseVisualStyleBackColor = True
			Me.chkAllGroups.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllGroups.AutoSize = True
			Me.chkAllGroups.Checked = True
			Me.chkAllGroups.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllGroups As Global.System.Windows.Forms.Control = Me.chkAllGroups
			point = New Global.System.Drawing.Point(125, 122)
			chkAllGroups.Location = point
			Me.chkAllGroups.Name = "chkAllGroups"
			Dim chkAllGroups2 As Global.System.Windows.Forms.Control = Me.chkAllGroups
			size = New Global.System.Drawing.Size(50, 17)
			chkAllGroups2.Size = size
			Me.chkAllGroups.TabIndex = 11
			Me.chkAllGroups.Text = "الكل"
			Me.chkAllGroups.UseVisualStyleBackColor = True
			Me.chkAllCust.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAllCust.AutoSize = True
			Me.chkAllCust.Checked = True
			Me.chkAllCust.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Dim chkAllCust As Global.System.Windows.Forms.Control = Me.chkAllCust
			point = New Global.System.Drawing.Point(366, 74)
			chkAllCust.Location = point
			Me.chkAllCust.Name = "chkAllCust"
			Dim chkAllCust2 As Global.System.Windows.Forms.Control = Me.chkAllCust
			size = New Global.System.Drawing.Size(50, 17)
			chkAllCust2.Size = size
			Me.chkAllCust.TabIndex = 10
			Me.chkAllCust.Text = "الكل"
			Me.chkAllCust.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnClose As Global.System.Windows.Forms.Control = Me.btnClose
			point = New Global.System.Drawing.Point(459, 159)
			btnClose.Location = point
			Me.btnClose.Name = "btnClose"
			Dim btnClose2 As Global.System.Windows.Forms.Control = Me.btnClose
			size = New Global.System.Drawing.Size(92, 41)
			btnClose2.Size = size
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "خروج"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnPrint As Global.System.Windows.Forms.Control = Me.btnPrint
			point = New Global.System.Drawing.Point(557, 159)
			btnPrint.Location = point
			Me.btnPrint.Name = "btnPrint"
			Dim btnPrint2 As Global.System.Windows.Forms.Control = Me.btnPrint
			size = New Global.System.Drawing.Size(92, 41)
			btnPrint2.Size = size
			Me.btnPrint.TabIndex = 6
			Me.btnPrint.Text = "طباعة"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnShow As Global.System.Windows.Forms.Control = Me.btnShow
			point = New Global.System.Drawing.Point(753, 159)
			btnShow.Location = point
			Me.btnShow.Name = "btnShow"
			Dim btnShow2 As Global.System.Windows.Forms.Control = Me.btnShow
			size = New Global.System.Drawing.Size(92, 41)
			btnShow2.Size = size
			Me.btnShow.TabIndex = 4
			Me.btnShow.Text = "عرض"
			Me.btnShow.UseVisualStyleBackColor = True
			Me.cmbGroups.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbGroups.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGroups.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGroups.Enabled = False
			Me.cmbGroups.FormattingEnabled = True
			Dim cmbGroups As Global.System.Windows.Forms.Control = Me.cmbGroups
			point = New Global.System.Drawing.Point(42, 101)
			cmbGroups.Location = point
			Me.cmbGroups.Name = "cmbGroups"
			Dim cmbGroups2 As Global.System.Windows.Forms.Control = Me.cmbGroups
			size = New Global.System.Drawing.Size(133, 21)
			cmbGroups2.Size = size
			Me.cmbGroups.TabIndex = 1
			Me.cmbEmp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbEmp.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEmp.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEmp.Enabled = False
			Me.cmbEmp.FormattingEnabled = True
			Dim cmbEmp As Global.System.Windows.Forms.Control = Me.cmbEmp
			point = New Global.System.Drawing.Point(42, 53)
			cmbEmp.Location = point
			Me.cmbEmp.Name = "cmbEmp"
			Dim cmbEmp2 As Global.System.Windows.Forms.Control = Me.cmbEmp
			size = New Global.System.Drawing.Size(133, 21)
			cmbEmp2.Size = size
			Me.cmbEmp.TabIndex = 1
			Me.cmbSales.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSales.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSales.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSales.Enabled = False
			Me.cmbSales.FormattingEnabled = True
			Dim cmbSales As Global.System.Windows.Forms.Control = Me.cmbSales
			point = New Global.System.Drawing.Point(283, 101)
			cmbSales.Location = point
			Me.cmbSales.Name = "cmbSales"
			Dim cmbSales2 As Global.System.Windows.Forms.Control = Me.cmbSales
			size = New Global.System.Drawing.Size(133, 21)
			cmbSales2.Size = size
			Me.cmbSales.TabIndex = 1
			Me.Panel2.Controls.Add(Me.dgvItems)
			Me.Panel2.Controls.Add(Me.Panel4)
			Me.Panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Panel2.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel2
			point = New Global.System.Drawing.Point(0, 218)
			panel.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel2
			size = New Global.System.Drawing.Size(945, 375)
			panel2.Size = size
			Me.Panel2.TabIndex = 15
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
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
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column8, Me.Column9, Me.Column5, Me.Column10, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7 })
			Me.dgvItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim dgvItems As Global.System.Windows.Forms.Control = Me.dgvItems
			point = New Global.System.Drawing.Point(0, 0)
			dgvItems.Location = point
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			Me.dgvItems.RowHeadersVisible = False
			Me.dgvItems.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Dim dgvItems2 As Global.System.Windows.Forms.Control = Me.dgvItems
			size = New Global.System.Drawing.Size(945, 310)
			dgvItems2.Size = size
			Me.dgvItems.TabIndex = 7
			Me.Column1.HeaderText = "المخزن"
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			Me.Column1.Width = 130
			Me.Column8.HeaderText = "فواتير"
			Me.Column8.Name = "Column8"
			Me.Column8.[ReadOnly] = True
			Me.Column9.HeaderText = "صافي الكمية"
			Me.Column9.Name = "Column9"
			Me.Column9.[ReadOnly] = True
			Me.Column9.Width = 80
			Me.Column5.HeaderText = "صافي الإجمالي"
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			Me.Column5.Width = 80
			Me.Column10.HeaderText = "صافي الخصم"
			Me.Column10.Name = "Column10"
			Me.Column10.[ReadOnly] = True
			Me.Column10.Width = 80
			Me.Column2.HeaderText = "صافي التكلفة"
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			Me.Column2.Width = 80
			Me.Column3.HeaderText = "صافي الربح"
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			Me.Column3.Width = 80
			Me.Column4.HeaderText = "نسبة الربح للتكلفة"
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			Me.Column4.Width = 80
			Me.Column6.HeaderText = "نسبة الإجمالي لإجمالي البيع"
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			Me.Column6.Width = 80
			Me.Column7.HeaderText = "نسبة الربح لإجمالي الربح"
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Column7.Width = 80
			Me.Panel4.Controls.Add(Me.Label18)
			Me.Panel4.Controls.Add(Me.Label16)
			Me.Panel4.Controls.Add(Me.txtSum5)
			Me.Panel4.Controls.Add(Me.Label12)
			Me.Panel4.Controls.Add(Me.txtSum4)
			Me.Panel4.Controls.Add(Me.txtSum2)
			Me.Panel4.Controls.Add(Me.Label14)
			Me.Panel4.Controls.Add(Me.txtSum3)
			Me.Panel4.Controls.Add(Me.Label10)
			Me.Panel4.Controls.Add(Me.txtSum1)
			Me.Panel4.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel4
			point = New Global.System.Drawing.Point(0, 310)
			panel3.Location = point
			Me.Panel4.Name = "Panel4"
			Dim panel4 As Global.System.Windows.Forms.Control = Me.Panel4
			size = New Global.System.Drawing.Size(945, 65)
			panel4.Size = size
			Me.Panel4.TabIndex = 6
			Me.Label18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label18.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label18.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim label As Global.System.Windows.Forms.Control = Me.Label18
			point = New Global.System.Drawing.Point(330, 3)
			label.Location = point
			Me.Label18.Name = "Label18"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label18
			size = New Global.System.Drawing.Size(105, 28)
			label2.Size = size
			Me.Label18.TabIndex = 16
			Me.Label18.Text = "صافي الربح"
			Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label16.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label16.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label16.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label16
			point = New Global.System.Drawing.Point(443, 4)
			label3.Location = point
			Me.Label16.Name = "Label16"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label16
			size = New Global.System.Drawing.Size(105, 28)
			label4.Size = size
			Me.Label16.TabIndex = 16
			Me.Label16.Text = "صافي التكلفة"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum5.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim txtSum As Global.System.Windows.Forms.Control = Me.txtSum5
			point = New Global.System.Drawing.Point(330, 32)
			txtSum.Location = point
			Me.txtSum5.Name = "txtSum5"
			Dim txtSum2 As Global.System.Windows.Forms.Control = Me.txtSum5
			size = New Global.System.Drawing.Size(105, 28)
			txtSum2.Size = size
			Me.txtSum5.TabIndex = 17
			Me.txtSum5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label12.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label12.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label12
			point = New Global.System.Drawing.Point(664, 4)
			label5.Location = point
			Me.Label12.Name = "Label12"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label12
			size = New Global.System.Drawing.Size(105, 28)
			label6.Size = size
			Me.Label12.TabIndex = 16
			Me.Label12.Text = "صافي الإجمالي"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum4.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim txtSum3 As Global.System.Windows.Forms.Control = Me.txtSum4
			point = New Global.System.Drawing.Point(443, 33)
			txtSum3.Location = point
			Me.txtSum4.Name = "txtSum4"
			Dim txtSum4 As Global.System.Windows.Forms.Control = Me.txtSum4
			size = New Global.System.Drawing.Size(105, 28)
			txtSum4.Size = size
			Me.txtSum4.TabIndex = 17
			Me.txtSum4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum2.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim txtSum5 As Global.System.Windows.Forms.Control = Me.txtSum2
			point = New Global.System.Drawing.Point(664, 33)
			txtSum5.Location = point
			Me.txtSum2.Name = "txtSum2"
			Dim txtSum6 As Global.System.Windows.Forms.Control = Me.txtSum2
			size = New Global.System.Drawing.Size(105, 28)
			txtSum6.Size = size
			Me.txtSum2.TabIndex = 17
			Me.txtSum2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label14.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label14.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label14
			point = New Global.System.Drawing.Point(553, 4)
			label7.Location = point
			Me.Label14.Name = "Label14"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label14
			size = New Global.System.Drawing.Size(105, 28)
			label8.Size = size
			Me.Label14.TabIndex = 16
			Me.Label14.Text = "صافي الخصم"
			Me.Label14.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim txtSum7 As Global.System.Windows.Forms.Control = Me.txtSum3
			point = New Global.System.Drawing.Point(553, 33)
			txtSum7.Location = point
			Me.txtSum3.Name = "txtSum3"
			Dim txtSum8 As Global.System.Windows.Forms.Control = Me.txtSum3
			size = New Global.System.Drawing.Size(105, 28)
			txtSum8.Size = size
			Me.txtSum3.TabIndex = 17
			Me.txtSum3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label10
			point = New Global.System.Drawing.Point(774, 4)
			label9.Location = point
			Me.Label10.Name = "Label10"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(105, 28)
			label10.Size = size
			Me.Label10.TabIndex = 16
			Me.Label10.Text = "صافي الكمية"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtSum1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtSum1.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 178)
			Dim txtSum9 As Global.System.Windows.Forms.Control = Me.txtSum1
			point = New Global.System.Drawing.Point(774, 33)
			txtSum9.Location = point
			Me.txtSum1.Name = "txtSum1"
			Dim txtSum10 As Global.System.Windows.Forms.Control = Me.txtSum1
			size = New Global.System.Drawing.Size(105, 28)
			txtSum10.Size = size
			Me.txtSum1.TabIndex = 17
			Me.txtSum1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Panel1.Controls.Add(Me.rdGroup)
			Me.Panel1.Controls.Add(Me.rdEmp)
			Me.Panel1.Controls.Add(Me.rdMonth)
			Me.Panel1.Controls.Add(Me.rdSalesman)
			Me.Panel1.Controls.Add(Me.rdItem)
			Me.Panel1.Controls.Add(Me.rdDay)
			Me.Panel1.Controls.Add(Me.rdCust)
			Me.Panel1.Controls.Add(Me.rdStock)
			Me.Panel1.Controls.Add(Me.chkAllGroups)
			Me.Panel1.Controls.Add(Me.chkAllEmp)
			Me.Panel1.Controls.Add(Me.chkAllSafe)
			Me.Panel1.Controls.Add(Me.chkAllSales)
			Me.Panel1.Controls.Add(Me.chkAllCust)
			Me.Panel1.Controls.Add(Me.chkAllStock)
			Me.Panel1.Controls.Add(Me.btnPreview)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Controls.Add(Me.btnPrint)
			Me.Panel1.Controls.Add(Me.btnShow)
			Me.Panel1.Controls.Add(Me.cmbGroups)
			Me.Panel1.Controls.Add(Me.cmbEmp)
			Me.Panel1.Controls.Add(Me.cmbSales)
			Me.Panel1.Controls.Add(Me.cmbCust)
			Me.Panel1.Controls.Add(Me.cmbSafe)
			Me.Panel1.Controls.Add(Me.cmbStock)
			Me.Panel1.Controls.Add(Me.txtDateTo)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label7)
			Me.Panel1.Controls.Add(Me.txtDateFrom)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.Label9)
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.Panel1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim panel5 As Global.System.Windows.Forms.Control = Me.Panel1
			point = New Global.System.Drawing.Point(0, 0)
			panel5.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel6 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(945, 218)
			panel6.Size = size
			Me.Panel1.TabIndex = 14
			Me.cmbCust.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCust.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCust.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCust.Enabled = False
			Me.cmbCust.FormattingEnabled = True
			Dim cmbCust As Global.System.Windows.Forms.Control = Me.cmbCust
			point = New Global.System.Drawing.Point(283, 53)
			cmbCust.Location = point
			Me.cmbCust.Name = "cmbCust"
			Dim cmbCust2 As Global.System.Windows.Forms.Control = Me.cmbCust
			size = New Global.System.Drawing.Size(133, 21)
			cmbCust2.Size = size
			Me.cmbCust.TabIndex = 1
			Me.cmbSafe.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbSafe.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafe.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafe.Enabled = False
			Me.cmbSafe.FormattingEnabled = True
			Dim cmbSafe As Global.System.Windows.Forms.Control = Me.cmbSafe
			point = New Global.System.Drawing.Point(502, 101)
			cmbSafe.Location = point
			Me.cmbSafe.Name = "cmbSafe"
			Dim cmbSafe2 As Global.System.Windows.Forms.Control = Me.cmbSafe
			size = New Global.System.Drawing.Size(133, 21)
			cmbSafe2.Size = size
			Me.cmbSafe.TabIndex = 1
			Me.cmbStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbStock.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbStock.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbStock.Enabled = False
			Me.cmbStock.FormattingEnabled = True
			Dim cmbStock As Global.System.Windows.Forms.Control = Me.cmbStock
			point = New Global.System.Drawing.Point(713, 101)
			cmbStock.Location = point
			Me.cmbStock.Name = "cmbStock"
			Dim cmbStock2 As Global.System.Windows.Forms.Control = Me.cmbStock
			size = New Global.System.Drawing.Size(133, 21)
			cmbStock2.Size = size
			Me.cmbStock.TabIndex = 1
			Me.txtDateTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateTo As Global.System.Windows.Forms.Control = Me.txtDateTo
			point = New Global.System.Drawing.Point(502, 56)
			txtDateTo.Location = point
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo2 As Global.System.Windows.Forms.Control = Me.txtDateTo
			size = New Global.System.Drawing.Size(133, 20)
			txtDateTo2.Size = size
			Me.txtDateTo.TabIndex = 3
			Dim txtDateTo3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateTo3.Value = dateTime
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label8.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label8
			point = New Global.System.Drawing.Point(179, 104)
			label11.Location = point
			Me.Label8.Name = "Label8"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(87, 13)
			label12.Size = size
			Me.Label8.TabIndex = 0
			Me.Label8.Text = "مجموعة الصنف"
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label3.AutoSize = True
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label3
			point = New Global.System.Drawing.Point(641, 59)
			label13.Location = point
			Me.Label3.Name = "Label3"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(56, 13)
			label14.Size = size
			Me.Label3.TabIndex = 0
			Me.Label3.Text = "الى تاريخ"
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label7
			point = New Global.System.Drawing.Point(179, 56)
			label15.Location = point
			Me.Label7.Name = "Label7"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(60, 13)
			label16.Size = size
			Me.Label7.TabIndex = 0
			Me.Label7.Text = "المستخدم"
			Me.txtDateFrom.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.[Short]
			Dim txtDateFrom As Global.System.Windows.Forms.Control = Me.txtDateFrom
			point = New Global.System.Drawing.Point(713, 56)
			txtDateFrom.Location = point
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom2 As Global.System.Windows.Forms.Control = Me.txtDateFrom
			size = New Global.System.Drawing.Size(133, 20)
			txtDateFrom2.Size = size
			Me.txtDateFrom.TabIndex = 2
			Dim txtDateFrom3 As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 10, 3, 0, 0, 0, 0)
			txtDateFrom3.Value = dateTime
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label4.AutoSize = True
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label4
			point = New Global.System.Drawing.Point(647, 104)
			label17.Location = point
			Me.Label4.Name = "Label4"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(44, 13)
			label18.Size = size
			Me.Label4.TabIndex = 0
			Me.Label4.Text = "الخزينة"
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label5.AutoSize = True
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label5
			point = New Global.System.Drawing.Point(786, 23)
			label19.Location = point
			Me.Label5.Name = "Label5"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(62, 13)
			label20.Size = size
			Me.Label5.TabIndex = 0
			Me.Label5.Text = "نوع التقرير"
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label9.AutoSize = True
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label9
			point = New Global.System.Drawing.Point(418, 105)
			label21.Location = point
			Me.Label9.Name = "Label9"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(66, 13)
			label22.Size = size
			Me.Label9.TabIndex = 0
			Me.Label9.Text = "مندوب البيع"
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Dim label23 As Global.System.Windows.Forms.Control = Me.Label6
			point = New Global.System.Drawing.Point(428, 56)
			label23.Location = point
			Me.Label6.Name = "Label6"
			Dim label24 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(41, 13)
			label24.Size = size
			Me.Label6.TabIndex = 0
			Me.Label6.Text = "العميل"
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label2.AutoSize = True
			Dim label25 As Global.System.Windows.Forms.Control = Me.Label2
			point = New Global.System.Drawing.Point(858, 61)
			label25.Location = point
			Me.Label2.Name = "Label2"
			Dim label26 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(52, 13)
			label26.Size = size
			Me.Label2.TabIndex = 0
			Me.Label2.Text = "من تاريخ"
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Dim label27 As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(858, 104)
			label27.Location = point
			Me.Label1.Name = "Label1"
			Dim label28 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(45, 13)
			label28.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "المخزن"
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(945, 593)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRptInvAnalysis"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقرير تحليل المبيعات"
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel4.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
