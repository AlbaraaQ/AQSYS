Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmServerSetting
	Inherits Global.System.Windows.Forms.Form

	Private components As Global.System.ComponentModel.IContainer
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblIsOk As Label
	Friend WithEvents rdLocal As RadioButton
	Friend WithEvents rdNetwork As RadioButton
	Friend WithEvents txtDBName As TextBox
	Friend WithEvents txtPWD As TextBox
	Friend WithEvents txtServer As TextBox
	Friend WithEvents txtUser As TextBox

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
		Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmServerSetting))
		Me.txtServer = New Global.System.Windows.Forms.TextBox()
		Me.Label1 = New Global.System.Windows.Forms.Label()
		Me.Button1 = New Global.System.Windows.Forms.Button()
		Me.Button2 = New Global.System.Windows.Forms.Button()
		Me.lblIsOk = New Global.System.Windows.Forms.Label()
		Me.Label2 = New Global.System.Windows.Forms.Label()
		Me.rdLocal = New Global.System.Windows.Forms.RadioButton()
		Me.rdNetwork = New Global.System.Windows.Forms.RadioButton()
		Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
		Me.txtPWD = New Global.System.Windows.Forms.TextBox()
		Me.txtUser = New Global.System.Windows.Forms.TextBox()
		Me.Label4 = New Global.System.Windows.Forms.Label()
		Me.Label3 = New Global.System.Windows.Forms.Label()
		Me.Label5 = New Global.System.Windows.Forms.Label()
		Me.txtDBName = New Global.System.Windows.Forms.TextBox()
		Me.Label6 = New Global.System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		resources.ApplyResources(Me.txtServer, "txtServer")
		Me.txtServer.Name = "txtServer"
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		resources.ApplyResources(Me.Button1, "Button1")
		Me.Button1.Name = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		resources.ApplyResources(Me.Button2, "Button2")
		Me.Button2.Name = "Button2"
		Me.Button2.UseVisualStyleBackColor = True
		resources.ApplyResources(Me.lblIsOk, "lblIsOk")
		Me.lblIsOk.ForeColor = Global.System.Drawing.Color.Red
		Me.lblIsOk.Name = "lblIsOk"
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		resources.ApplyResources(Me.rdLocal, "rdLocal")
		Me.rdLocal.Checked = True
		Me.rdLocal.Name = "rdLocal"
		Me.rdLocal.TabStop = True
		Me.rdLocal.UseVisualStyleBackColor = True
		resources.ApplyResources(Me.rdNetwork, "rdNetwork")
		Me.rdNetwork.Name = "rdNetwork"
		Me.rdNetwork.UseVisualStyleBackColor = True
		Me.GroupBox1.Controls.Add(Me.txtPWD)
		Me.GroupBox1.Controls.Add(Me.txtUser)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		resources.ApplyResources(Me.GroupBox1, "GroupBox1")
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.TabStop = False
		resources.ApplyResources(Me.txtPWD, "txtPWD")
		Me.txtPWD.Name = "txtPWD"
		resources.ApplyResources(Me.txtUser, "txtUser")
		Me.txtUser.Name = "txtUser"
		resources.ApplyResources(Me.Label4, "Label4")
		Me.Label4.Name = "Label4"
		resources.ApplyResources(Me.Label3, "Label3")
		Me.Label3.Name = "Label3"
		resources.ApplyResources(Me.Label5, "Label5")
		Me.Label5.Name = "Label5"
		resources.ApplyResources(Me.txtDBName, "txtDBName")
		Me.txtDBName.Name = "txtDBName"
		resources.ApplyResources(Me.Label6, "Label6")
		Me.Label6.Name = "Label6"
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtDBName)
		Me.Controls.Add(Me.rdNetwork)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.rdLocal)
		Me.Controls.Add(Me.lblIsOk)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtServer)
		Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmServerSetting"
		Me.ShowIcon = False
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
End Class
