Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmItemsExpire
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents txtSum As Label

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
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label2 = New Label()
        txtSum = New Label()
        btnClose = New Button()
        btnPreview = New Button()
        btnPrint = New Button()
        GroupBox1 = New GroupBox()
        txtDate = New DateTimePicker()
        Label13 = New Label()
        btnShow = New Button()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 108)
        GroupBox2.Margin = New Padding(4, 4, 4, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 4, 4, 4)
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1057, 495)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "النتائج"
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.AllowUserToOrderColumns = True
        dgvItems.BackgroundColor = Color.White
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(4, 23)
        dgvItems.Margin = New Padding(4, 4, 4, 4)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(1049, 427)
        dgvItems.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "رقم الصنف"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "الصنف"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "الرصيد"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "متوسط سعر التكلفة"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "اجمالي التكلفة"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtSum)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(4, 450)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1049, 41)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(365, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(679, 36)
        Label2.TabIndex = 9
        Label2.Text = "اجمالي التكلفة"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtSum
        ' 
        txtSum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSum.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtSum.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtSum.Location = New Point(157, 0)
        txtSum.Margin = New Padding(4, 0, 4, 0)
        txtSum.Name = "txtSum"
        txtSum.Size = New Size(207, 36)
        txtSum.TabIndex = 10
        txtSum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(237, 46)
        btnClose.Margin = New Padding(4, 4, 4, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(68, 35)
        btnClose.TabIndex = 33
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPreview.Location = New Point(388, 46)
        btnPreview.Margin = New Padding(4, 4, 4, 4)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(68, 35)
        btnPreview.TabIndex = 31
        btnPreview.Text = "معاينة"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Location = New Point(312, 45)
        btnPrint.Margin = New Padding(4, 4, 4, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(68, 35)
        btnPrint.TabIndex = 32
        btnPrint.Text = "طباعة"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtDate)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.RightToLeft = RightToLeft.Yes
        GroupBox1.Size = New Size(1057, 108)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' txtDate
        ' 
        txtDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDate.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(643, 46)
        txtDate.Margin = New Padding(4, 4, 4, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(311, 26)
        txtDate.TabIndex = 35
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(643, 24)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(296, 18)
        Label13.TabIndex = 34
        Label13.Text = "الأصناف التي ستنتهي صلاحيتها قبل تاريخ"
        ' 
        ' btnShow
        ' 
        btnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnShow.Location = New Point(464, 46)
        btnShow.Margin = New Padding(4, 4, 4, 4)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(68, 35)
        btnShow.TabIndex = 30
        btnShow.Text = "عرض"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' frmItemsExpire
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1057, 603)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4, 4, 4, 4)
        Name = "frmItemsExpire"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "الأصناف التي ستنتهي صلاحيتها"
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
