Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAbout
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox

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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmAbout))
        Panel2 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 153)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(663, 199)
        Panel2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Tahoma", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(0, 0)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(663, 199)
        Label3.TabIndex = 2
        Label3.Text = resources.GetString("Label3.Text")
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Tahoma", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(663, 199)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(663, 153)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(661, 151)
        Label2.TabIndex = 2
        Label2.Text = "برنامج الأمهر المحاسبي ( محاسبة - إدارة مطاعم ومخازن ومستودعات )" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(663, 352)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "frmAbout"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "عن البرنامج"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class
