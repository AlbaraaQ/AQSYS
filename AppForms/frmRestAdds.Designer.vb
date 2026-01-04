Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRestAdds
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents btnOK As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtAdds As TextBox

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
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.lblName = New Global.System.Windows.Forms.Label()
			Me.txtAdds = New Global.System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			Me.btnOK.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim btnOK As Global.System.Windows.Forms.Control = Me.btnOK
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 120)
			btnOK.Location = point
			Me.btnOK.Name = "btnOK"
			Dim btnOK2 As Global.System.Windows.Forms.Control = Me.btnOK
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(428, 46)
			btnOK2.Size = size
			Me.btnOK.TabIndex = 0
			Me.btnOK.Text = "موافق"
			Me.btnOK.UseVisualStyleBackColor = True
			Me.lblName.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblName.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim lblName As Global.System.Windows.Forms.Control = Me.lblName
			point = New Global.System.Drawing.Point(0, 0)
			lblName.Location = point
			Me.lblName.Name = "lblName"
			Dim lblName2 As Global.System.Windows.Forms.Control = Me.lblName
			size = New Global.System.Drawing.Size(428, 38)
			lblName2.Size = size
			Me.lblName.TabIndex = 1
			Me.lblName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtAdds.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim txtAdds As Global.System.Windows.Forms.Control = Me.txtAdds
			point = New Global.System.Drawing.Point(0, 38)
			txtAdds.Location = point
			Me.txtAdds.Multiline = True
			Me.txtAdds.Name = "txtAdds"
			Me.txtAdds.ScrollBars = Global.System.Windows.Forms.ScrollBars.Vertical
			Dim txtAdds2 As Global.System.Windows.Forms.Control = Me.txtAdds
			size = New Global.System.Drawing.Size(428, 82)
			txtAdds2.Size = size
			Me.txtAdds.TabIndex = 2
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(428, 166)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtAdds)
			Me.Controls.Add(Me.lblName)
			Me.Controls.Add(Me.btnOK)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmRestAdds"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "الإضافات"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
