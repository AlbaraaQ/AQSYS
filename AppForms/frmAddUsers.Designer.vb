Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAddUsers
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewLinkColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox

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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAddUsers))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        groupbox1 = New GroupBox()
        cmbEmp = New ComboBox()
        label2 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        label4 = New Label()
        label1 = New Label()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        btnLast = New ToolStripButton()
        btnNext = New ToolStripButton()
        btnPrevious = New ToolStripButton()
        btnFirst = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnPrint = New ToolStripButton()
        btnClose = New ToolStripButton()
        dgvUsers = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewLinkColumn()
        groupbox1.SuspendLayout()
        toolStrip1.SuspendLayout()
        CType(dgvUsers, ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' groupbox1
        ' 
        groupbox1.BackColor = Color.White
        groupbox1.Controls.Add(cmbEmp)
        groupbox1.Controls.Add(label2)
        groupbox1.Controls.Add(txtUser)
        groupbox1.Controls.Add(txtPass)
        groupbox1.Controls.Add(label4)
        groupbox1.Controls.Add(label1)
        groupbox1.Dock = DockStyle.Top
        groupbox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        groupbox1.Location = New Point(0, 0)
        groupbox1.Margin = New Padding(3, 4, 3, 4)
        groupbox1.Name = "groupbox1"
        groupbox1.Padding = New Padding(3, 4, 3, 4)
        groupbox1.Size = New Size(822, 130)
        groupbox1.TabIndex = 2
        groupbox1.TabStop = False
        groupbox1.Text = "بيانات المستخدم"
        ' 
        ' cmbEmp
        ' 
        cmbEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbEmp.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbEmp.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbEmp.BackColor = Color.White
        cmbEmp.FlatStyle = FlatStyle.System
        cmbEmp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbEmp.FormattingEnabled = True
        cmbEmp.Location = New Point(453, 35)
        cmbEmp.Margin = New Padding(3, 4, 3, 4)
        cmbEmp.Name = "cmbEmp"
        cmbEmp.Size = New Size(190, 29)
        cmbEmp.TabIndex = 0
        ' 
        ' label2
        ' 
        label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.ForeColor = Color.DimGray
        label2.Location = New Point(694, 38)
        label2.Name = "label2"
        label2.Size = New Size(80, 23)
        label2.TabIndex = 6
        label2.Text = "الموظف :"
        ' 
        ' txtUser
        ' 
        txtUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(448, 80)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(195, 29)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(161, 80)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(170, 29)
        txtPass.TabIndex = 2
        ' 
        ' label4
        ' 
        label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        label4.ForeColor = Color.DimGray
        label4.Location = New Point(650, 83)
        label4.Name = "label4"
        label4.Size = New Size(122, 23)
        label4.TabIndex = 4
        label4.Text = "اسم المستخدم :"
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.ForeColor = Color.DimGray
        label1.Location = New Point(338, 83)
        label1.Name = "label1"
        label1.Size = New Size(101, 23)
        label1.TabIndex = 0
        label1.Text = "كلمة المرور :"
        ' 
        ' toolStrip1
        ' 
        toolStrip1.BackColor = Color.White
        toolStrip1.Dock = DockStyle.Bottom
        toolStrip1.GripStyle = ToolStripGripStyle.Hidden
        toolStrip1.ImageScalingSize = New Size(32, 32)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator1, btnLast, btnNext, btnPrevious, btnFirst, toolStripSeparator2, btnPrint, btnClose})
        toolStrip1.Location = New Point(0, 441)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RenderMode = ToolStripRenderMode.System
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(822, 64)
        toolStrip1.TabIndex = 1
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Margin = New Padding(2)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(50, 60)
        btnNew.Text = "جديد"
        btnNew.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Margin = New Padding(2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 60)
        btnSave.Text = "حفظ"
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(50, 60)
        btnDelete.Text = "حذف"
        btnDelete.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 64)
        ' 
        ' btnLast
        ' 
        btnLast.AutoSize = False
        btnLast.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLast.Image = CType(resources.GetObject("btnLast.Image"), Image)
        btnLast.ImageScaling = ToolStripItemImageScaling.None
        btnLast.ImageTransparentColor = Color.Magenta
        btnLast.Margin = New Padding(2)
        btnLast.Name = "btnLast"
        btnLast.Size = New Size(50, 60)
        btnLast.Text = "الأخير"
        btnLast.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnNext
        ' 
        btnNext.AutoSize = False
        btnNext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = CType(resources.GetObject("btnNext.Image"), Image)
        btnNext.ImageScaling = ToolStripItemImageScaling.None
        btnNext.ImageTransparentColor = Color.Magenta
        btnNext.Margin = New Padding(2)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(50, 60)
        btnNext.Text = "التالي"
        btnNext.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnPrevious
        ' 
        btnPrevious.AutoSize = False
        btnPrevious.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), Image)
        btnPrevious.ImageScaling = ToolStripItemImageScaling.None
        btnPrevious.ImageTransparentColor = Color.Magenta
        btnPrevious.Margin = New Padding(2)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(50, 60)
        btnPrevious.Text = "السابق"
        btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnFirst
        ' 
        btnFirst.AutoSize = False
        btnFirst.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnFirst.Image = My.Resources.Resources.Firstt
        btnFirst.ImageScaling = ToolStripItemImageScaling.None
        btnFirst.ImageTransparentColor = Color.Magenta
        btnFirst.Margin = New Padding(2)
        btnFirst.Name = "btnFirst"
        btnFirst.Size = New Size(50, 60)
        btnFirst.Text = "الأول"
        btnFirst.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 64)
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = False
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageScaling = ToolStripItemImageScaling.None
        btnPrint.ImageTransparentColor = Color.Magenta
        btnPrint.Margin = New Padding(2)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(50, 60)
        btnPrint.Text = "طباعة"
        btnPrint.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Margin = New Padding(2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 60)
        btnClose.Text = "خروج"
        btnClose.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToOrderColumns = True
        dgvUsers.BackgroundColor = Color.FromArgb(CByte(245), CByte(246), CByte(247))
        dgvUsers.BorderStyle = BorderStyle.None
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeight = 35
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {Column5, Column3, Column1, Column2, Column4, Column6})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvUsers.Location = New Point(0, 130)
        dgvUsers.Margin = New Padding(3, 4, 3, 4)
        dgvUsers.MultiSelect = False
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvUsers.RowTemplate.Height = 30
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(822, 311)
        dgvUsers.TabIndex = 0
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "الرقم"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Visible = False
        Column5.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "رقم الموظف"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Visible = False
        Column3.Width = 125
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "الموظف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "اسم المستخدم"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 180
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "كلمة المرور"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 180
        ' 
        ' Column6
        ' 
        Column6.HeaderText = ""
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Text = "اعداد الصلاحيات"
        Column6.ToolTipText = "اعداد الصلاحيات"
        Column6.UseColumnTextForLinkValue = True
        Column6.Width = 150
        ' 
        ' frmAddUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(247))
        ClientSize = New Size(822, 505)
        Controls.Add(dgvUsers)
        Controls.Add(toolStrip1)
        Controls.Add(groupbox1)
        Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmAddUsers"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "اضافة المستخدمين"
        groupbox1.ResumeLayout(False)
        groupbox1.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        CType(dgvUsers, ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
