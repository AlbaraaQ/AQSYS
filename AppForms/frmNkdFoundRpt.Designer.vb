Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmNkdFoundRpt
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox

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
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.Button2)
			Me.GroupBox1.Controls.Add(Me.Button1)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(6, 5)
			groupBox.Location = point
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(381, 118)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = " فضلا اختر  التقرير المطلوب "
			Dim button As Global.System.Windows.Forms.Control = Me.Button2
			point = New Global.System.Drawing.Point(25, 34)
			button.Location = point
			Me.Button2.Name = "Button2"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(163, 56)
			button2.Size = size
			Me.Button2.TabIndex = 1
			Me.Button2.Text = "اجمالي المبيعات والمشتريات"
			Me.Button2.UseVisualStyleBackColor = True
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			point = New Global.System.Drawing.Point(194, 34)
			button3.Location = point
			Me.Button1.Name = "Button1"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(163, 56)
			button4.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "الاجمالي جهات مختلفة"
			Me.Button1.UseVisualStyleBackColor = True
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(395, 133)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Name = "frmNkdFoundRpt"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "تقارير مؤسسة النقد"
			Me.GroupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
