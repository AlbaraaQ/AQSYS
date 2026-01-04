Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmInvPopUpWindow
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timer1 As Timer
    Friend WithEvents txtRec As Label
    Friend WithEvents txtRem As Label

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
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvPopUpWindow))
        timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        txtRec = New Label()
        txtRem = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' timer1
        ' 
        timer1.Interval = 5000
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "المستلم"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 0
        Label2.Text = "المتبقي"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtRec
        ' 
        txtRec.BorderStyle = BorderStyle.FixedSingle
        txtRec.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtRec.Location = New Point(58, 105)
        txtRec.Name = "txtRec"
        txtRec.Size = New Size(100, 23)
        txtRec.TabIndex = 0
        txtRec.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtRem
        ' 
        txtRem.BorderStyle = BorderStyle.FixedSingle
        txtRem.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtRem.Location = New Point(58, 105)
        txtRem.Name = "txtRem"
        txtRem.Size = New Size(100, 23)
        txtRem.TabIndex = 0
        txtRem.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' frmInvPopUpWindow
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(185, 66)
        Controls.Add(PictureBox1)
        Controls.Add(txtRem)
        Controls.Add(txtRec)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmInvPopUpWindow"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
