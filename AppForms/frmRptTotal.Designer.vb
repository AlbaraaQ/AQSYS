Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmRptTotal
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cmbEmps As ComboBox
    Friend WithEvents txtDateFrom As DateTimePicker
    Friend WithEvents txtDateTo As DateTimePicker
    Friend WithEvents txtSumAgel As TextBox
    Friend WithEvents txtSumCash As TextBox
    Friend WithEvents txtSumNetwork As TextBox
    Friend WithEvents txtSumTotal As TextBox
    Friend WithEvents txtSumVAT As TextBox

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmRptTotal))
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtDateTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtDateFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.cmbEmps = New Global.System.Windows.Forms.ComboBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtSumTotal = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtSumVAT = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtSumAgel = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtSumNetwork = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtSumCash = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Controls.Add(Me.txtDateTo)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.txtDateFrom)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.chkAll)
			Me.GroupBox1.Controls.Add(Me.cmbEmps)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.txtSumTotal)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.txtSumVAT)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.txtSumAgel)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.txtSumNetwork)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.txtSumCash)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.txtDateTo, "txtDateTo")
			Me.txtDateTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.txtDateTo.Name = "txtDateTo"
			Dim txtDateTo As Global.System.Windows.Forms.DateTimePicker = Me.txtDateTo
			Dim dateTime As Global.System.DateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateTo.Value = dateTime
			resources.ApplyResources(Me.Label4, "Label4")
			Me.Label4.Name = "Label4"
			resources.ApplyResources(Me.txtDateFrom, "txtDateFrom")
			Me.txtDateFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.txtDateFrom.Name = "txtDateFrom"
			Dim txtDateFrom As Global.System.Windows.Forms.DateTimePicker = Me.txtDateFrom
			dateTime = New Global.System.DateTime(2012, 9, 21, 0, 0, 0, 0)
			txtDateFrom.Value = dateTime
			resources.ApplyResources(Me.Label7, "Label7")
			Me.Label7.Name = "Label7"
			resources.ApplyResources(Me.chkAll, "chkAll")
			Me.chkAll.Checked = True
			Me.chkAll.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkAll.Name = "chkAll"
			Me.chkAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbEmps, "cmbEmps")
			Me.cmbEmps.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbEmps.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbEmps.FormattingEnabled = True
			Me.cmbEmps.Name = "cmbEmps"
			resources.ApplyResources(Me.Label6, "Label6")
			Me.Label6.Name = "Label6"
			resources.ApplyResources(Me.txtSumTotal, "txtSumTotal")
			Me.txtSumTotal.BackColor = Global.System.Drawing.Color.White
			Me.txtSumTotal.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSumTotal.ForeColor = Global.System.Drawing.Color.Red
			Me.txtSumTotal.Name = "txtSumTotal"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.BackColor = Global.System.Drawing.Color.White
			Me.Label3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.txtSumVAT, "txtSumVAT")
			Me.txtSumVAT.BackColor = Global.System.Drawing.Color.White
			Me.txtSumVAT.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSumVAT.ForeColor = Global.System.Drawing.Color.Red
			Me.txtSumVAT.Name = "txtSumVAT"
			resources.ApplyResources(Me.Label5, "Label5")
			Me.Label5.BackColor = Global.System.Drawing.Color.White
			Me.Label5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label5.Name = "Label5"
			resources.ApplyResources(Me.txtSumAgel, "txtSumAgel")
			Me.txtSumAgel.BackColor = Global.System.Drawing.Color.White
			Me.txtSumAgel.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSumAgel.ForeColor = Global.System.Drawing.Color.Red
			Me.txtSumAgel.Name = "txtSumAgel"
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.BackColor = Global.System.Drawing.Color.White
			Me.Label2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtSumNetwork, "txtSumNetwork")
			Me.txtSumNetwork.BackColor = Global.System.Drawing.Color.White
			Me.txtSumNetwork.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSumNetwork.ForeColor = Global.System.Drawing.Color.Red
			Me.txtSumNetwork.Name = "txtSumNetwork"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.BackColor = Global.System.Drawing.Color.White
			Me.Label1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label1.Name = "Label1"
			resources.ApplyResources(Me.txtSumCash, "txtSumCash")
			Me.txtSumCash.BackColor = Global.System.Drawing.Color.White
			Me.txtSumCash.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.txtSumCash.ForeColor = Global.System.Drawing.Color.Red
			Me.txtSumCash.Name = "txtSumCash"
			resources.ApplyResources(Me.Label8, "Label8")
			Me.Label8.BackColor = Global.System.Drawing.Color.White
			Me.Label8.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label8.Name = "Label8"
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmRptTotal"
			Me.ShowIcon = False
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
