Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmBuyApp
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    
    Friend WithEvents groupBox3 As GroupBox
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents textBox2 As TextBox
	Friend WithEvents timer1 As timer

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
			Me.components = New Global.System.ComponentModel.Container()
			Me.groupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.textBox1 = New Global.System.Windows.Forms.TextBox()
			Me.textBox2 = New Global.System.Windows.Forms.TextBox()
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			Me.groupBox3.BackColor = Global.System.Drawing.Color.White
			Me.groupBox3.Controls.Add(Me.textBox1)
			Me.groupBox3.Controls.Add(Me.textBox2)
			Me.groupBox3.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.groupBox3.ForeColor = Global.System.Drawing.Color.White
			Dim groupBox As Global.System.Windows.Forms.Control = Me.groupBox3
			Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			groupBox.Location = point
			Me.groupBox3.Name = "groupBox3"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.groupBox3
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(471, 391)
			groupBox2.Size = size
			Me.groupBox3.TabIndex = 6
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "شراء البرنامج"
			Me.textBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.textBox1.BackColor = Global.System.Drawing.SystemColors.ButtonHighlight
			Me.textBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.textBox1.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Dim textBox As Global.System.Windows.Forms.Control = Me.textBox1
			point = New Global.System.Drawing.Point(78, 322)
			textBox.Location = point
			Me.textBox1.Name = "textBox1"
			Me.textBox1.[ReadOnly] = True
			Me.textBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.textBox1
			size = New Global.System.Drawing.Size(337, 13)
			textBox2.Size = size
			Me.textBox1.TabIndex = 1
			Me.textBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.textBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.textBox2.BackColor = Global.System.Drawing.SystemColors.ButtonHighlight
			Me.textBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.textBox2.Font = New Global.System.Drawing.Font("Times New Roman", 14.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.textBox2
			point = New Global.System.Drawing.Point(40, 20)
			textBox3.Location = point
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.[ReadOnly] = True
			Me.textBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.textBox2
			size = New Global.System.Drawing.Size(425, 266)
			textBox4.Size = size
			Me.textBox2.TabIndex = 0
			Me.textBox2.Text = "انتظر جاري التحميل"
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1000
			Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 13F)
			Me.AutoScaleDimensions = sizeF
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(471, 391)
			Me.ClientSize = size
			Me.Controls.Add(Me.groupBox3)
			Me.Font = New Global.System.Drawing.Font("Tahoma", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.Name = "frmBuyApp"
			Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Me.RightToLeftLayout = True
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "شراء البرنامج"
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
