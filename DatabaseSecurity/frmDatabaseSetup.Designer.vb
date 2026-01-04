Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabaseSetup
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbServers = New System.Windows.Forms.ComboBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.grpOperations = New System.Windows.Forms.GroupBox()
        Me.chkApplyProtection = New System.Windows.Forms.CheckBox()
        Me.btnFullSetup = New System.Windows.Forms.Button()
        Me.btnApplyProtection = New System.Windows.Forms.Button()
        Me.btnExecuteScript = New System.Windows.Forms.Button()
        Me.btnCreateDatabase = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.grpLog = New System.Windows.Forms.GroupBox()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.grpServer.SuspendLayout()
        Me.grpOperations.SuspendLayout()
        Me.grpLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(481, 40)
        Me.pnlHeader.TabIndex = 0

        ' أضف هذه الأزرار في الأسفل
        With Me
            .btnFixUser = New Button With {
        .Text = "إصلاح المستخدم السري",
        .Location = New Point(20, 420),
        .Size = New Size(120, 30),
        .ForeColor = Color.White,
        .BackColor = Color.DodgerBlue,
        .FlatStyle = FlatStyle.Flat
    }

            .btnEmergencyRecovery = New Button With {
        .Text = "استعادة الطوارئ",
        .Location = New Point(150, 420),
        .Size = New Size(120, 30),
        .ForeColor = Color.White,
        .BackColor = Color.OrangeRed,
        .FlatStyle = FlatStyle.Flat
    }

            .Controls.Add(.btnFixUser)
            .Controls.Add(.btnEmergencyRecovery)
        End With
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(4, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "✕"
        Me.ToolTip1.SetToolTip(Me.btnClose, "إغلاق")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(96, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTitle.Size = New System.Drawing.Size(341, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🛡️ إعداد قاعدة البيانات"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpServer
        '
        Me.grpServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServer.Controls.Add(Me.btnRefresh)
        Me.grpServer.Controls.Add(Me.cmbServers)
        Me.grpServer.Controls.Add(Me.lblServer)
        Me.grpServer.Controls.Add(Me.txtDatabaseName)
        Me.grpServer.Controls.Add(Me.lblDatabase)
        Me.grpServer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpServer.Location = New System.Drawing.Point(10, 48)
        Me.grpServer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpServer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpServer.Size = New System.Drawing.Size(460, 76)
        Me.grpServer.TabIndex = 1
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "إعدادات الاتصال"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(9, 20)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(61, 28)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "🔄 بحث"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "البحث عن خوادم SQL")
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'cmbServers
        '
        Me.cmbServers.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.cmbServers.FormattingEnabled = True
        Me.cmbServers.Location = New System.Drawing.Point(75, 20)
        Me.cmbServers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbServers.Name = "cmbServers"
        Me.cmbServers.Size = New System.Drawing.Size(246, 28)
        Me.cmbServers.TabIndex = 3
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(326, 22)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(82, 23)
        Me.lblServer.TabIndex = 2
        Me.lblServer.Text = "خادم SQL:"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txtDatabaseName.Location = New System.Drawing.Point(75, 46)
        Me.txtDatabaseName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(246, 27)
        Me.txtDatabaseName.TabIndex = 1
        Me.txtDatabaseName.Text = "StockDB-4soft"
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(326, 49)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(98, 23)
        Me.lblDatabase.TabIndex = 0
        Me.lblDatabase.Text = "اسم القاعدة:"
        '
        'grpOperations
        '
        Me.grpOperations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOperations.Controls.Add(Me.chkApplyProtection)
        Me.grpOperations.Controls.Add(Me.btnFullSetup)
        Me.grpOperations.Controls.Add(Me.btnApplyProtection)
        Me.grpOperations.Controls.Add(Me.btnExecuteScript)
        Me.grpOperations.Controls.Add(Me.btnCreateDatabase)
        Me.grpOperations.Controls.Add(Me.btnTestConnection)
        Me.grpOperations.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpOperations.Location = New System.Drawing.Point(10, 129)
        Me.grpOperations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOperations.Name = "grpOperations"
        Me.grpOperations.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOperations.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpOperations.Size = New System.Drawing.Size(460, 108)
        Me.grpOperations.TabIndex = 2
        Me.grpOperations.TabStop = False
        Me.grpOperations.Text = "العمليات"
        '
        'chkApplyProtection
        '
        Me.chkApplyProtection.AutoSize = True
        Me.chkApplyProtection.Checked = True
        Me.chkApplyProtection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApplyProtection.Location = New System.Drawing.Point(223, 54)
        Me.chkApplyProtection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkApplyProtection.Name = "chkApplyProtection"
        Me.chkApplyProtection.Size = New System.Drawing.Size(221, 27)
        Me.chkApplyProtection.TabIndex = 5
        Me.chkApplyProtection.Text = "تفعيل حماية قاعدة البيانات"
        Me.chkApplyProtection.UseVisualStyleBackColor = True
        '
        'btnFullSetup
        '
        Me.btnFullSetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnFullSetup.FlatAppearance.BorderSize = 0
        Me.btnFullSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFullSetup.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnFullSetup.ForeColor = System.Drawing.Color.White
        Me.btnFullSetup.Location = New System.Drawing.Point(9, 80)
        Me.btnFullSetup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFullSetup.Name = "btnFullSetup"
        Me.btnFullSetup.Size = New System.Drawing.Size(438, 28)
        Me.btnFullSetup.TabIndex = 4
        Me.btnFullSetup.Text = "🚀 إعداد كامل تلقائي"
        Me.ToolTip1.SetToolTip(Me.btnFullSetup, "إنشاء القاعدة + تنفيذ Script + الحماية")
        Me.btnFullSetup.UseVisualStyleBackColor = False
        '
        'btnApplyProtection
        '
        Me.btnApplyProtection.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnApplyProtection.FlatAppearance.BorderSize = 0
        Me.btnApplyProtection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyProtection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnApplyProtection.ForeColor = System.Drawing.Color.White
        Me.btnApplyProtection.Location = New System.Drawing.Point(9, 22)
        Me.btnApplyProtection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnApplyProtection.Name = "btnApplyProtection"
        Me.btnApplyProtection.Size = New System.Drawing.Size(105, 34)
        Me.btnApplyProtection.TabIndex = 3
        Me.btnApplyProtection.Text = "🔐 تطبيق الحماية"
        Me.btnApplyProtection.UseVisualStyleBackColor = False
        '
        'btnExecuteScript
        '
        Me.btnExecuteScript.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExecuteScript.FlatAppearance.BorderSize = 0
        Me.btnExecuteScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExecuteScript.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExecuteScript.ForeColor = System.Drawing.Color.White
        Me.btnExecuteScript.Location = New System.Drawing.Point(119, 22)
        Me.btnExecuteScript.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExecuteScript.Name = "btnExecuteScript"
        Me.btnExecuteScript.Size = New System.Drawing.Size(105, 34)
        Me.btnExecuteScript.TabIndex = 2
        Me.btnExecuteScript.Text = "📥 تنفيذ Script"
        Me.btnExecuteScript.UseVisualStyleBackColor = False
        '
        'btnCreateDatabase
        '
        Me.btnCreateDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCreateDatabase.FlatAppearance.BorderSize = 0
        Me.btnCreateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateDatabase.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCreateDatabase.ForeColor = System.Drawing.Color.White
        Me.btnCreateDatabase.Location = New System.Drawing.Point(229, 22)
        Me.btnCreateDatabase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateDatabase.Name = "btnCreateDatabase"
        Me.btnCreateDatabase.Size = New System.Drawing.Size(105, 34)
        Me.btnCreateDatabase.TabIndex = 1
        Me.btnCreateDatabase.Text = "📊 إنشاء القاعدة"
        Me.btnCreateDatabase.UseVisualStyleBackColor = False
        '
        'btnTestConnection
        '
        Me.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTestConnection.FlatAppearance.BorderSize = 0
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestConnection.ForeColor = System.Drawing.Color.White
        Me.btnTestConnection.Location = New System.Drawing.Point(340, 22)
        Me.btnTestConnection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(105, 34)
        Me.btnTestConnection.TabIndex = 0
        Me.btnTestConnection.Text = "✅ اختبار الاتصال"
        Me.btnTestConnection.UseVisualStyleBackColor = False
        '
        'grpLog
        '
        Me.grpLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLog.Controls.Add(Me.rtbLog)
        Me.grpLog.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.grpLog.Location = New System.Drawing.Point(10, 242)
        Me.grpLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLog.Name = "grpLog"
        Me.grpLog.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpLog.Size = New System.Drawing.Size(460, 254)
        Me.grpLog.TabIndex = 3
        Me.grpLog.TabStop = False
        Me.grpLog.Text = "السجل"
        '
        'rtbLog
        '
        Me.rtbLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLog.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.rtbLog.ForeColor = System.Drawing.Color.Lime
        Me.rtbLog.Location = New System.Drawing.Point(3, 25)
        Me.rtbLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rtbLog.Size = New System.Drawing.Size(454, 227)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'progressBar
        '
        Me.progressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar.Location = New System.Drawing.Point(10, 500)
        Me.progressBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(460, 16)
        Me.progressBar.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.Location = New System.Drawing.Point(340, 519)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStatus.Size = New System.Drawing.Size(131, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "جاهز"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 542)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.grpLog)
        Me.Controls.Add(Me.grpOperations)
        Me.Controls.Add(Me.grpServer)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDatabaseSetup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعداد قاعدة البيانات"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        Me.grpOperations.ResumeLayout(False)
        Me.grpOperations.PerformLayout()
        Me.grpLog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpServer As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbServers As ComboBox
    Friend WithEvents lblServer As Label
    Friend WithEvents txtDatabaseName As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents grpOperations As GroupBox
    Friend WithEvents btnFullSetup As Button
    Friend WithEvents btnApplyProtection As Button
    Friend WithEvents btnExecuteScript As Button
    Friend WithEvents btnCreateDatabase As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents btnFixUser As Button
    Friend WithEvents btnEmergencyRecovery As Button

    Friend WithEvents grpLog As GroupBox
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents chkApplyProtection As CheckBox
    Friend WithEvents ToolTip1 As ToolTip

End Class