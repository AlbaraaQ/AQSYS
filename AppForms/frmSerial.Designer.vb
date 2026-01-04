Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSerial
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSerial))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txt1 = New Global.System.Windows.Forms.TextBox()
			Me.txt2 = New Global.System.Windows.Forms.TextBox()
			Me.txt3 = New Global.System.Windows.Forms.TextBox()
			Me.txt4 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.LinkLabel1 = New Global.System.Windows.Forms.LinkLabel()
			Me.SuspendLayout()
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.txt1, "txt1")
			Me.txt1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt1.Name = "txt1"
			resources.ApplyResources(Me.txt2, "txt2")
			Me.txt2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt2.Name = "txt2"
			resources.ApplyResources(Me.txt3, "txt3")
			Me.txt3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt3.Name = "txt3"
			resources.ApplyResources(Me.txt4, "txt4")
			Me.txt4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txt4.Name = "txt4"
			resources.ApplyResources(Me.Button1, "Button1")
			Me.Button1.Name = "Button1"
			Me.Button1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.Button3, "Button3")
			Me.Button3.Name = "Button3"
			Me.Button3.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
			Me.LinkLabel1.Name = "LinkLabel1"
			Me.LinkLabel1.TabStop = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.LinkLabel1)
			Me.Controls.Add(Me.Button3)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.txt4)
			Me.Controls.Add(Me.txt3)
			Me.Controls.Add(Me.txt2)
			Me.Controls.Add(Me.txt1)
			Me.Controls.Add(Me.Label1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.KeyPreview = True
			Me.MaximizeBox = False
			Me.Name = "frmSerial"
			Me.ShowIcon = False
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
