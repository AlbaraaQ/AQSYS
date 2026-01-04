Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmInvRptType
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton

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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 18)
        Label1.TabIndex = 0
        Label1.Text = "افتراضي طباعة الفواتير"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(145, 58)
        RadioButton1.Margin = New Padding(4, 4, 4, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(86, 22)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "ورقة A4"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(332, 58)
        RadioButton2.Margin = New Padding(4, 4, 4, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(100, 22)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "ورق صغير"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(154, 108)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 66)
        Button1.TabIndex = 2
        Button1.Text = "حفظ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(300, 108)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 66)
        Button2.TabIndex = 2
        Button2.Text = "خروج"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' frmInvRptType
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(594, 204)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        Name = "frmInvRptType"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterParent
        Text = "افتراضي الطباعة"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
