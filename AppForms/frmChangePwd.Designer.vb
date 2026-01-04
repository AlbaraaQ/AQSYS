Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmChangePwd
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents label1 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents toolStrip1 As ToolStrip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePwd))
        btnClose = New ToolStripButton()
        groupbox1 = New GroupBox()
        txtUser = New TextBox()
        txtPass = New TextBox()
        label4 = New Label()
        label1 = New Label()
        toolStrip1 = New ToolStrip()
        btnSave = New ToolStripButton()
        groupbox1.SuspendLayout()
        toolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.Text = "خروج"
        ' 
        ' groupbox1
        ' 
        groupbox1.BackColor = Color.Transparent
        groupbox1.Controls.Add(txtUser)
        groupbox1.Controls.Add(txtPass)
        groupbox1.Controls.Add(label4)
        groupbox1.Controls.Add(label1)
        groupbox1.Dock = DockStyle.Fill
        groupbox1.Location = New Point(0, 0)
        groupbox1.Margin = New Padding(3, 4, 3, 4)
        groupbox1.Name = "groupbox1"
        groupbox1.Padding = New Padding(3, 4, 3, 4)
        groupbox1.Size = New Size(330, 149)
        groupbox1.TabIndex = 5
        groupbox1.TabStop = False
        ' 
        ' txtUser
        ' 
        txtUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtUser.Location = New Point(31, 38)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.ReadOnly = True
        txtUser.Size = New Size(164, 24)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPass.Location = New Point(31, 70)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(164, 24)
        txtPass.TabIndex = 2
        ' 
        ' label4
        ' 
        label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label4.AutoSize = True
        label4.Location = New Point(203, 42)
        label4.Name = "label4"
        label4.Size = New Size(117, 17)
        label4.TabIndex = 4
        label4.Text = "اسم المستخدم :"
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label1.AutoSize = True
        label1.Location = New Point(226, 74)
        label1.Name = "label1"
        label1.Size = New Size(90, 17)
        label1.TabIndex = 0
        label1.Text = "كلمة المرور :"
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Bottom
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnSave, btnClose})
        toolStrip1.Location = New Point(0, 149)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(330, 53)
        toolStrip1.TabIndex = 4
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 50)
        btnSave.Text = "حفظ"
        ' 
        ' frmChangePwd
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 202)
        Controls.Add(groupbox1)
        Controls.Add(toolStrip1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "frmChangePwd"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تغيير كلمة المرور"
        groupbox1.ResumeLayout(False)
        groupbox1.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
