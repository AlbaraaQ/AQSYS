Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Frm_Calculator
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd135 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmdClearAll As Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As Panel


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
        components = New Container()
        TextBox1 = New TextBox()
        Button1 = New Button()
        cmd0 = New Button()
        cmd9 = New Button()
        cmd8 = New Button()
        cmd7 = New Button()
        cmdClearAll = New Button()
        cmd6 = New Button()
        cmd5 = New Button()
        cmd4 = New Button()
        cmd3 = New Button()
        cmd2 = New Button()
        cmd135 = New Button()
        Timer1 = New System.Windows.Forms.Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Drawing.Font("Tahoma", 15.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TextBox1.Location = New Drawing.Point(16, 3)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.MaxLength = 10
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Drawing.Size(271, 39)
        TextBox1.TabIndex = 189
        ' 
        ' Button1
        ' 
        Button1.BackColor = Drawing.SystemColors.AppWorkspace
        Button1.Font = New Drawing.Font("Tahoma", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        Button1.ForeColor = Drawing.SystemColors.ActiveCaption
        Button1.Location = New Drawing.Point(16, 463)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Drawing.Size(273, 78)
        Button1.TabIndex = 190
        Button1.Text = "موافق"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' cmd0
        ' 
        cmd0.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd0.Location = New Drawing.Point(16, 357)
        cmd0.Margin = New Padding(4, 5, 4, 5)
        cmd0.Name = "cmd0"
        cmd0.Size = New Drawing.Size(91, 98)
        cmd0.TabIndex = 188
        cmd0.Text = "0"
        cmd0.UseVisualStyleBackColor = True
        ' 
        ' cmd9
        ' 
        cmd9.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd9.Location = New Drawing.Point(205, 262)
        cmd9.Margin = New Padding(4, 5, 4, 5)
        cmd9.Name = "cmd9"
        cmd9.Size = New Drawing.Size(84, 83)
        cmd9.TabIndex = 187
        cmd9.Text = "9"
        cmd9.UseVisualStyleBackColor = True
        ' 
        ' cmd8
        ' 
        cmd8.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd8.Location = New Drawing.Point(115, 263)
        cmd8.Margin = New Padding(4, 5, 4, 5)
        cmd8.Name = "cmd8"
        cmd8.Size = New Drawing.Size(83, 83)
        cmd8.TabIndex = 186
        cmd8.Text = "8"
        cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmd7
        ' 
        cmd7.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd7.Location = New Drawing.Point(16, 263)
        cmd7.Margin = New Padding(4, 5, 4, 5)
        cmd7.Name = "cmd7"
        cmd7.Size = New Drawing.Size(91, 82)
        cmd7.TabIndex = 185
        cmd7.Text = "7"
        cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdClearAll
        ' 
        cmdClearAll.Font = New Drawing.Font("Tahoma", 30.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmdClearAll.Location = New Drawing.Point(115, 357)
        cmdClearAll.Margin = New Padding(4, 5, 4, 5)
        cmdClearAll.Name = "cmdClearAll"
        cmdClearAll.Size = New Drawing.Size(175, 98)
        cmdClearAll.TabIndex = 184
        cmdClearAll.Text = "c"
        cmdClearAll.UseVisualStyleBackColor = True
        ' 
        ' cmd6
        ' 
        cmd6.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd6.Location = New Drawing.Point(205, 169)
        cmd6.Margin = New Padding(4, 5, 4, 5)
        cmd6.Name = "cmd6"
        cmd6.Size = New Drawing.Size(84, 86)
        cmd6.TabIndex = 183
        cmd6.Text = "6"
        cmd6.UseVisualStyleBackColor = True
        ' 
        ' cmd5
        ' 
        cmd5.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd5.Location = New Drawing.Point(115, 169)
        cmd5.Margin = New Padding(4, 5, 4, 5)
        cmd5.Name = "cmd5"
        cmd5.Size = New Drawing.Size(83, 86)
        cmd5.TabIndex = 182
        cmd5.Text = "5"
        cmd5.UseVisualStyleBackColor = True
        ' 
        ' cmd4
        ' 
        cmd4.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd4.Location = New Drawing.Point(16, 169)
        cmd4.Margin = New Padding(4, 5, 4, 5)
        cmd4.Name = "cmd4"
        cmd4.Size = New Drawing.Size(91, 86)
        cmd4.TabIndex = 181
        cmd4.Text = "4"
        cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmd3
        ' 
        cmd3.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd3.Location = New Drawing.Point(205, 63)
        cmd3.Margin = New Padding(4, 5, 4, 5)
        cmd3.Name = "cmd3"
        cmd3.Size = New Drawing.Size(83, 95)
        cmd3.TabIndex = 180
        cmd3.Text = "3"
        cmd3.UseVisualStyleBackColor = True
        ' 
        ' cmd2
        ' 
        cmd2.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd2.Location = New Drawing.Point(115, 62)
        cmd2.Margin = New Padding(4, 5, 4, 5)
        cmd2.Name = "cmd2"
        cmd2.Size = New Drawing.Size(83, 97)
        cmd2.TabIndex = 179
        cmd2.Text = "2"
        cmd2.UseVisualStyleBackColor = True
        ' 
        ' cmd135
        ' 
        cmd135.Font = New Drawing.Font("Tahoma", 24.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        cmd135.Location = New Drawing.Point(16, 63)
        cmd135.Margin = New Padding(4, 5, 4, 5)
        cmd135.Name = "cmd135"
        cmd135.Size = New Drawing.Size(91, 95)
        cmd135.TabIndex = 178
        cmd135.Text = "1"
        cmd135.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Frm_Calculator
        ' 
        AutoScaleDimensions = New Drawing.SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Drawing.Size(308, 560)
        ControlBox = False
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(cmd0)
        Controls.Add(cmd135)
        Controls.Add(cmd9)
        Controls.Add(cmd2)
        Controls.Add(cmd8)
        Controls.Add(cmd3)
        Controls.Add(cmd7)
        Controls.Add(cmd4)
        Controls.Add(cmdClearAll)
        Controls.Add(cmd5)
        Controls.Add(cmd6)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        Name = "Frm_Calculator"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
