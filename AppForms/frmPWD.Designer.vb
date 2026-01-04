Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmPWD
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
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
			Me.txtPWD = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.btnExit = New Global.System.Windows.Forms.Button()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.txtPWD.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim txtPWD As Global.System.Windows.Forms.Control = Me.txtPWD
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(138, 12)
			txtPWD.Location = point
			Me.txtPWD.Name = "txtPWD"
			Me.txtPWD.PasswordChar = "*"c
			Dim txtPWD2 As Global.System.Windows.Forms.Control = Me.txtPWD
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(222, 20)
			txtPWD2.Size = size
			Me.txtPWD.TabIndex = 3
			Me.txtPWD.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			point = New Global.System.Drawing.Point(66, 16)
			label.Location = point
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(68, 13)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "كلمة المرور"
			Me.btnExit.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnExit As Global.System.Windows.Forms.Control = Me.btnExit
			point = New Global.System.Drawing.Point(252, 49)
			btnExit.Location = point
			Me.btnExit.Name = "btnExit"
			Dim btnExit2 As Global.System.Windows.Forms.Control = Me.btnExit
			size = New Global.System.Drawing.Size(108, 38)
			btnExit2.Size = size
			Me.btnExit.TabIndex = 4
			Me.btnExit.Text = "إلغاء"
			Me.btnExit.UseVisualStyleBackColor = True
			Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			point = New Global.System.Drawing.Point(138, 49)
			btnOK.Location = point
			Me.btnOK.Name = "btnOK"
			Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
			size = New Global.System.Drawing.Size(108, 38)
			btnOK2.Size = size
			Me.btnOK.TabIndex = 5
			Me.btnOK.Text = "موافق"
			Me.btnOK.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			size = New Global.System.Drawing.Size(419, 102)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnExit)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.txtPWD)
			Me.Controls.Add(Me.Label1)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Name = "frmPWD"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ادخل كلمة المرور"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
