Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCustLastPay
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button11 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewButtonColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents dgvItems As DataGridView

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustLastPay))
        GroupBox2 = New GroupBox()
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewButtonColumn()
        GroupBox1 = New GroupBox()
        Button11 = New Button()
        chkAll = New CheckBox()
        btnClose = New Button()
        btnPrint = New Button()
        btnPreview = New Button()
        btnShow = New Button()
        cmbClients = New ComboBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvItems)
        resources.ApplyResources(GroupBox2, "GroupBox2")
        GroupBox2.Name = "GroupBox2"
        GroupBox2.TabStop = False
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column8, Column7, Column9, Column11, Column10})
        resources.ApplyResources(dgvItems, "dgvItems")
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        ' 
        ' Column1
        ' 
        resources.ApplyResources(Column1, "Column1")
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        resources.ApplyResources(Column2, "Column2")
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        resources.ApplyResources(Column3, "Column3")
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        resources.ApplyResources(Column4, "Column4")
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        resources.ApplyResources(Column5, "Column5")
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        resources.ApplyResources(Column6, "Column6")
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column8
        ' 
        resources.ApplyResources(Column8, "Column8")
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column7
        ' 
        resources.ApplyResources(Column7, "Column7")
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column9
        ' 
        resources.ApplyResources(Column9, "Column9")
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column11
        ' 
        resources.ApplyResources(Column11, "Column11")
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column10
        ' 
        resources.ApplyResources(Column10, "Column10")
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Text = "view"
        Column10.UseColumnTextForButtonValue = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button11)
        GroupBox1.Controls.Add(chkAll)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnPreview)
        GroupBox1.Controls.Add(btnShow)
        GroupBox1.Controls.Add(cmbClients)
        GroupBox1.Controls.Add(Label1)
        resources.ApplyResources(GroupBox1, "GroupBox1")
        GroupBox1.Name = "GroupBox1"
        GroupBox1.TabStop = False
        ' 
        ' Button11
        ' 
        resources.ApplyResources(Button11, "Button11")
        Button11.Name = "Button11"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' chkAll
        ' 
        resources.ApplyResources(chkAll, "chkAll")
        chkAll.Name = "chkAll"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        resources.ApplyResources(btnClose, "btnClose")
        btnClose.Name = "btnClose"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        resources.ApplyResources(btnPrint, "btnPrint")
        btnPrint.Name = "btnPrint"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        resources.ApplyResources(btnPreview, "btnPreview")
        btnPreview.Name = "btnPreview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnShow
        ' 
        resources.ApplyResources(btnShow, "btnShow")
        btnShow.Name = "btnShow"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' cmbClients
        ' 
        resources.ApplyResources(cmbClients, "cmbClients")
        cmbClients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbClients.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbClients.FormattingEnabled = True
        cmbClients.Name = "cmbClients"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' frmCustLastPay
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmCustLastPay"
        ShowIcon = False
        GroupBox2.ResumeLayout(False)
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
