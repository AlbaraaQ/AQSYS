Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class frmSafeGrd
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkType1 As CheckBox
    Friend WithEvents chkType2 As CheckBox
    Friend WithEvents chkType3 As CheckBox
    Friend WithEvents chkZeros As CheckBox
    Friend WithEvents cmbSafes As ComboBox
    Friend WithEvents timer1 As timer
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents pnlItemType As GroupBox
    Friend WithEvents txtSum As Label
    Friend WithEvents txtSum2 As Label

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
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(frmSafeGrd))
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.dgvItems = New Global.System.Windows.Forms.DataGridView()
			Me.Column1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column5 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column6 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column7 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtSum2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtSum = New Global.System.Windows.Forms.Label()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.chkZeros = New Global.System.Windows.Forms.CheckBox()
			Me.pnlItemType = New Global.System.Windows.Forms.GroupBox()
			Me.chkType3 = New Global.System.Windows.Forms.CheckBox()
			Me.chkType2 = New Global.System.Windows.Forms.CheckBox()
			Me.chkType1 = New Global.System.Windows.Forms.CheckBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPreview = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnShow = New Global.System.Windows.Forms.Button()
			Me.cmbSafes = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.GroupBox2.SuspendLayout()
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.pnlItemType.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox2.Controls.Add(Me.dgvItems)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			resources.ApplyResources(Me.GroupBox2, "GroupBox2")
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.TabStop = False
			Me.dgvItems.AllowUserToAddRows = False
			Me.dgvItems.AllowUserToDeleteRows = False
			Me.dgvItems.AllowUserToOrderColumns = True
			Me.dgvItems.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvItems.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgvItems.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7 })
			resources.ApplyResources(Me.dgvItems, "dgvItems")
			Me.dgvItems.MultiSelect = False
			Me.dgvItems.Name = "dgvItems"
			Me.dgvItems.[ReadOnly] = True
			resources.ApplyResources(Me.Column1, "Column1")
			Me.Column1.Name = "Column1"
			Me.Column1.[ReadOnly] = True
			resources.ApplyResources(Me.Column2, "Column2")
			Me.Column2.Name = "Column2"
			Me.Column2.[ReadOnly] = True
			resources.ApplyResources(Me.Column3, "Column3")
			Me.Column3.Name = "Column3"
			Me.Column3.[ReadOnly] = True
			resources.ApplyResources(Me.Column4, "Column4")
			Me.Column4.Name = "Column4"
			Me.Column4.[ReadOnly] = True
			resources.ApplyResources(Me.Column5, "Column5")
			Me.Column5.Name = "Column5"
			Me.Column5.[ReadOnly] = True
			resources.ApplyResources(Me.Column6, "Column6")
			Me.Column6.Name = "Column6"
			Me.Column6.[ReadOnly] = True
			resources.ApplyResources(Me.Column7, "Column7")
			Me.Column7.Name = "Column7"
			Me.Column7.[ReadOnly] = True
			Me.Panel1.Controls.Add(Me.txtSum2)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.txtSum)
			resources.ApplyResources(Me.Panel1, "Panel1")
			Me.Panel1.Name = "Panel1"
			resources.ApplyResources(Me.txtSum2, "txtSum2")
			Me.txtSum2.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum2.Name = "txtSum2"
			resources.ApplyResources(Me.Label3, "Label3")
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label3.Name = "Label3"
			resources.ApplyResources(Me.Label2, "Label2")
			Me.Label2.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.Label2.Name = "Label2"
			resources.ApplyResources(Me.txtSum, "txtSum")
			Me.txtSum.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.txtSum.Name = "txtSum"
			Me.GroupBox1.Controls.Add(Me.chkZeros)
			Me.GroupBox1.Controls.Add(Me.pnlItemType)
			Me.GroupBox1.Controls.Add(Me.ProgressBar1)
			Me.GroupBox1.Controls.Add(Me.chkAll)
			Me.GroupBox1.Controls.Add(Me.btnClose)
			Me.GroupBox1.Controls.Add(Me.btnPreview)
			Me.GroupBox1.Controls.Add(Me.btnPrint)
			Me.GroupBox1.Controls.Add(Me.btnShow)
			Me.GroupBox1.Controls.Add(Me.cmbSafes)
			Me.GroupBox1.Controls.Add(Me.Label1)
			resources.ApplyResources(Me.GroupBox1, "GroupBox1")
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.TabStop = False
			resources.ApplyResources(Me.chkZeros, "chkZeros")
			Me.chkZeros.Name = "chkZeros"
			Me.chkZeros.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.pnlItemType, "pnlItemType")
			Me.pnlItemType.Controls.Add(Me.chkType3)
			Me.pnlItemType.Controls.Add(Me.chkType2)
			Me.pnlItemType.Controls.Add(Me.chkType1)
			Me.pnlItemType.Name = "pnlItemType"
			Me.pnlItemType.TabStop = False
			resources.ApplyResources(Me.chkType3, "chkType3")
			Me.chkType3.Checked = True
			Me.chkType3.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkType3.Name = "chkType3"
			Me.chkType3.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.chkType2, "chkType2")
			Me.chkType2.Checked = True
			Me.chkType2.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkType2.Name = "chkType2"
			Me.chkType2.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.chkType1, "chkType1")
			Me.chkType1.Checked = True
			Me.chkType1.CheckState = Global.System.Windows.Forms.CheckState.Checked
			Me.chkType1.Name = "chkType1"
			Me.chkType1.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
			Me.ProgressBar1.Name = "ProgressBar1"
			resources.ApplyResources(Me.chkAll, "chkAll")
			Me.chkAll.Name = "chkAll"
			Me.chkAll.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnClose, "btnClose")
			Me.btnClose.Name = "btnClose"
			Me.btnClose.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPreview, "btnPreview")
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnPrint, "btnPrint")
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.btnShow, "btnShow")
			Me.btnShow.Name = "btnShow"
			Me.btnShow.UseVisualStyleBackColor = True
			resources.ApplyResources(Me.cmbSafes, "cmbSafes")
			Me.cmbSafes.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSafes.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSafes.FormattingEnabled = True
			Me.cmbSafes.Name = "cmbSafes"
			resources.ApplyResources(Me.Label1, "Label1")
			Me.Label1.Name = "Label1"
			Me.Timer1.Enabled = True
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Name = "frmSafeGrd"
			Me.ShowIcon = False
			Me.GroupBox2.ResumeLayout(False)
			CType(Me.dgvItems, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.pnlItemType.ResumeLayout(False)
			Me.pnlItemType.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
