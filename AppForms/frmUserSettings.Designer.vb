Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmUserSettings
		Inherits Global.System.Windows.Forms.Form

		Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Bold As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Names As ComboBox
    Friend WithEvents Regular As RadioButton
    Friend WithEvents Sizes As ComboBox
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents button1 As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents colorDialog1 As ColorDialog
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents toolStrip1 As ToolStrip

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserSettings))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Bold = New System.Windows.Forms.RadioButton()
        Me.Regular = New System.Windows.Forms.RadioButton()
        Me.Sizes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Names = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        resources.ApplyResources(Me.toolStrip1, "toolStrip1")
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClose})
        Me.toolStrip1.Name = "toolStrip1"
        '
        'groupBox1
        '
        resources.ApplyResources(Me.groupBox1, "groupBox1")
        Me.groupBox1.Controls.Add(Me.chkActive)
        Me.groupBox1.Controls.Add(Me.Button3)
        Me.groupBox1.Controls.Add(Me.Button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.Bold)
        Me.groupBox1.Controls.Add(Me.Regular)
        Me.groupBox1.Controls.Add(Me.Sizes)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.Names)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.TabStop = False
        '
        'chkActive
        '
        resources.ApplyResources(Me.chkActive, "chkActive")
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Name = "chkActive"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        resources.ApplyResources(Me.button1, "button1")
        Me.button1.Name = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Bold
        '
        resources.ApplyResources(Me.Bold, "Bold")
        Me.Bold.Name = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'Regular
        '
        resources.ApplyResources(Me.Regular, "Regular")
        Me.Regular.Checked = True
        Me.Regular.Name = "Regular"
        Me.Regular.TabStop = True
        Me.Regular.UseVisualStyleBackColor = True
        '
        'Sizes
        '
        resources.ApplyResources(Me.Sizes, "Sizes")
        Me.Sizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sizes.FormattingEnabled = True
        Me.Sizes.Items.AddRange(New Object() {resources.GetString("Sizes.Items"), resources.GetString("Sizes.Items1"), resources.GetString("Sizes.Items2"), resources.GetString("Sizes.Items3"), resources.GetString("Sizes.Items4"), resources.GetString("Sizes.Items5"), resources.GetString("Sizes.Items6"), resources.GetString("Sizes.Items7")})
        Me.Sizes.Name = "Sizes"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Names
        '
        resources.ApplyResources(Me.Names, "Names")
        Me.Names.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Names.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Names.FormattingEnabled = True
        Me.Names.Name = "Names"
        '
        'label5
        '
        resources.ApplyResources(Me.label5, "label5")
        Me.label5.Name = "label5"
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'label3
        '
        resources.ApplyResources(Me.label3, "label3")
        Me.label3.Name = "label3"
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Name = "btnSave"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Name = "btnClose"
        '
        'frmUserSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "frmUserSettings"
        Me.ShowIcon = False
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
