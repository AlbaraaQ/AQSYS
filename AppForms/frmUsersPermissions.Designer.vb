Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmUsersPermissions
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnFirst As ToolStripButton
    Friend WithEvents btnLast As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents chkDate As CheckBox
    Friend WithEvents chkDisc As CheckBox
    Friend WithEvents chkEdit As CheckBox
    Friend WithEvents chkHideCustMobile As CheckBox
    Friend WithEvents chkPrice As CheckBox
    Friend WithEvents chkSendInvEmail As CheckBox
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents gBoxClientData As GroupBox
    Friend WithEvents groupBox1 As GroupBox
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents treeView1 As TreeView
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtPrintClientsPWD As TextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsersPermissions))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLast = New System.Windows.Forms.ToolStripButton()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
        Me.btnFirst = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.gBoxClientData = New System.Windows.Forms.GroupBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPrintClientsPWD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkHideCustMobile = New System.Windows.Forms.CheckBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.chkPrice = New System.Windows.Forms.CheckBox()
        Me.chkSendInvEmail = New System.Windows.Forms.CheckBox()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.chkDisc = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbEmp = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toolStrip1.SuspendLayout()
        Me.gBoxClientData.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        resources.ApplyResources(Me.toolStrip1, "toolStrip1")
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnDelete, Me.toolStripSeparator1, Me.btnLast, Me.btnNext, Me.btnPrevious, Me.btnFirst, Me.toolStripSeparator2, Me.btnClose})
        Me.toolStrip1.Name = "toolStrip1"
        '
        'btnNew
        '
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Name = "btnNew"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Name = "btnSave"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Name = "btnDelete"
        '
        'toolStripSeparator1
        '
        resources.ApplyResources(Me.toolStripSeparator1, "toolStripSeparator1")
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        '
        'btnLast
        '
        resources.ApplyResources(Me.btnLast, "btnLast")
        Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLast.Name = "btnLast"
        '
        'btnNext
        '
        resources.ApplyResources(Me.btnNext, "btnNext")
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Name = "btnNext"
        '
        'btnPrevious
        '
        resources.ApplyResources(Me.btnPrevious, "btnPrevious")
        Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnFirst
        '
        resources.ApplyResources(Me.btnFirst, "btnFirst")
        Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirst.Image = Global.AQSYS.My.Resources.Resources.Firstt
        Me.btnFirst.Name = "btnFirst"
        '
        'toolStripSeparator2
        '
        resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Name = "btnClose"
        '
        'gBoxClientData
        '
        resources.ApplyResources(Me.gBoxClientData, "gBoxClientData")
        Me.gBoxClientData.BackColor = System.Drawing.Color.White
        Me.gBoxClientData.Controls.Add(Me.groupBox1)
        Me.gBoxClientData.Controls.Add(Me.Panel1)
        Me.gBoxClientData.Name = "gBoxClientData"
        Me.gBoxClientData.TabStop = False
        '
        'groupBox1
        '
        resources.ApplyResources(Me.groupBox1, "groupBox1")
        Me.groupBox1.Controls.Add(Me.treeView1)
        Me.groupBox1.Controls.Add(Me.Panel2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.TabStop = False
        '
        'treeView1
        '
        resources.ApplyResources(Me.treeView1, "treeView1")
        Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeView1.CheckBoxes = True
        Me.treeView1.Name = "treeView1"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPrintClientsPWD)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.chkHideCustMobile)
        Me.Panel2.Controls.Add(Me.chkDate)
        Me.Panel2.Controls.Add(Me.chkPrice)
        Me.Panel2.Controls.Add(Me.chkSendInvEmail)
        Me.Panel2.Controls.Add(Me.chkEdit)
        Me.Panel2.Controls.Add(Me.chkDisc)
        Me.Panel2.Name = "Panel2"
        '
        'txtPrintClientsPWD
        '
        resources.ApplyResources(Me.txtPrintClientsPWD, "txtPrintClientsPWD")
        Me.txtPrintClientsPWD.Name = "txtPrintClientsPWD"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'chkHideCustMobile
        '
        resources.ApplyResources(Me.chkHideCustMobile, "chkHideCustMobile")
        Me.chkHideCustMobile.Name = "chkHideCustMobile"
        Me.chkHideCustMobile.UseVisualStyleBackColor = True
        '
        'chkDate
        '
        resources.ApplyResources(Me.chkDate, "chkDate")
        Me.chkDate.Name = "chkDate"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'chkPrice
        '
        resources.ApplyResources(Me.chkPrice, "chkPrice")
        Me.chkPrice.Name = "chkPrice"
        Me.chkPrice.UseVisualStyleBackColor = True
        '
        'chkSendInvEmail
        '
        resources.ApplyResources(Me.chkSendInvEmail, "chkSendInvEmail")
        Me.chkSendInvEmail.Name = "chkSendInvEmail"
        Me.chkSendInvEmail.UseVisualStyleBackColor = True
        '
        'chkEdit
        '
        resources.ApplyResources(Me.chkEdit, "chkEdit")
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'chkDisc
        '
        resources.ApplyResources(Me.chkDisc, "chkDisc")
        Me.chkDisc.Name = "chkDisc"
        Me.chkDisc.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.cmbEmp)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Name = "Panel1"
        '
        'cmbEmp
        '
        resources.ApplyResources(Me.cmbEmp, "cmbEmp")
        Me.cmbEmp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmbEmp.FormattingEnabled = True
        Me.cmbEmp.Name = "cmbEmp"
        '
        'label2
        '
        resources.ApplyResources(Me.label2, "label2")
        Me.label2.Name = "label2"
        '
        'txtUser
        '
        resources.ApplyResources(Me.txtUser, "txtUser")
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        '
        'txtPass
        '
        resources.ApplyResources(Me.txtPass, "txtPass")
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ReadOnly = True
        '
        'label4
        '
        resources.ApplyResources(Me.label4, "label4")
        Me.label4.Name = "label4"
        '
        'label1
        '
        resources.ApplyResources(Me.label1, "label1")
        Me.label1.Name = "label1"
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'frmUsersPermissions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gBoxClientData)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "frmUsersPermissions"
        Me.ShowIcon = False
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.gBoxClientData.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
