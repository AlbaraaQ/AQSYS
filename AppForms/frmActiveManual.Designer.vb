Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmActiveManual
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnActive As Button
    Friend WithEvents txtPWD As TextBox

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
        Panel1 = New Panel()
        txtPWD = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        btnActive = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.None
        Panel1.Controls.Add(txtPWD)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 180)
        Panel1.TabIndex = 0
        ' 
        ' txtPWD
        ' 
        txtPWD.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPWD.BackColor = Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        txtPWD.BorderStyle = BorderStyle.FixedSingle
        txtPWD.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPWD.Location = New Point(200, 100)
        txtPWD.Name = "txtPWD"
        txtPWD.PasswordChar = "●"c
        txtPWD.Size = New Size(200, 34)
        txtPWD.TabIndex = 23
        txtPWD.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Label1.ImeMode = ImeMode.NoControl
        Label1.Location = New Point(410, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 25)
        Label1.TabIndex = 24
        Label1.Text = "كلمة المرور"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnActive)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 180)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 60)
        Panel2.TabIndex = 1
        ' 
        ' btnActive
        ' 
        btnActive.Anchor = AnchorStyles.None
        btnActive.BackColor = Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        btnActive.FlatAppearance.BorderSize = 0
        btnActive.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(91, Byte), Integer))
        btnActive.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(125, Byte), Integer))
        btnActive.FlatStyle = FlatStyle.Flat
        btnActive.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnActive.ForeColor = Color.White
        btnActive.Location = New Point(175, 10)
        btnActive.Name = "btnActive"
        btnActive.Size = New Size(150, 40)
        btnActive.TabIndex = 0
        btnActive.Text = "تفعيل النسخة"
        btnActive.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(135, Byte), Integer))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(500, 60)
        Panel3.TabIndex = 25
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        ' PictureBox1.Image = My.Resources.Resources.lock_icon
        PictureBox1.Location = New Point(20, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(500, 60)
        Label2.TabIndex = 0
        Label2.Text = "تفعيل النسخة"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmActiveManual
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(500, 240)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(518, 287)
        Name = "frmActiveManual"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "تفعيل النسخة"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
