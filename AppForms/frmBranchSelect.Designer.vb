Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmBranchSelect
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbBranches As ComboBox

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
        Label1 = New Label()
        cmbBranches = New ComboBox()
        chkAll = New CheckBox()
        btnEnter = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 18)
        Label1.TabIndex = 0
        Label1.Text = "الفرع"
        ' 
        ' cmbBranches
        ' 
        cmbBranches.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbBranches.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbBranches.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbBranches.Enabled = False
        cmbBranches.FormattingEnabled = True
        cmbBranches.Location = New Point(56, 19)
        cmbBranches.Name = "cmbBranches"
        cmbBranches.Size = New Size(121, 24)
        cmbBranches.TabIndex = 1
        ' 
        ' chkAll
        ' 
        chkAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAll.AutoSize = True
        chkAll.Checked = True
        chkAll.CheckState = CheckState.Checked
        chkAll.ForeColor = Color.Black
        chkAll.Location = New Point(102, 19)
        chkAll.Name = "chkAll"
        chkAll.Size = New Size(58, 21)
        chkAll.TabIndex = 2
        chkAll.Text = "الكل"
        chkAll.UseVisualStyleBackColor = True
        ' 
        ' btnEnter
        ' 
        btnEnter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEnter.Location = New Point(56, 19)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 23)
        btnEnter.TabIndex = 3
        btnEnter.Text = "دخول"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Location = New Point(56, 19)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 3
        btnClose.Text = "خروج"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmBranchSelect
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(148, 29)
        ControlBox = False
        Controls.Add(btnClose)
        Controls.Add(btnEnter)
        Controls.Add(chkAll)
        Controls.Add(cmbBranches)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Name = "frmBranchSelect"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "اختر فرع"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
