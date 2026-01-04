Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCntrlSections
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents chkActiveZakat As CheckBox
    Friend WithEvents chkAmmand As CheckBox
    Friend WithEvents chkCostCenter As CheckBox
    Friend WithEvents chkEditCompName As CheckBox
    Friend WithEvents chkManfc As CheckBox
    Friend WithEvents chkOpenExpire As CheckBox
    Friend WithEvents chkRetention As CheckBox
    Friend WithEvents chkYearClose As CheckBox
    Friend WithEvents lblExpire As Label
    Friend WithEvents txtExpireDate As DateTimePicker
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
        Panel1 = New Panel()
        txtPWD = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        chkAmmand = New CheckBox()
        chkOpenExpire = New CheckBox()
        chkActiveZakat = New CheckBox()
        lblExpire = New Label()
        txtExpireDate = New DateTimePicker()
        chkEditCompName = New CheckBox()
        btnExit = New Button()
        btnOK = New Button()
        chkYearClose = New CheckBox()
        chkRetention = New CheckBox()
        chkCostCenter = New CheckBox()
        chkManfc = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtPWD)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(635, 100)
        Panel1.TabIndex = 0
        ' 
        ' txtPWD
        ' 
        txtPWD.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPWD.Location = New Point(435, 0)
        txtPWD.Name = "txtPWD"
        txtPWD.PasswordChar = "*"c
        txtPWD.Size = New Size(100, 24)
        txtPWD.TabIndex = 1
        txtPWD.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(435, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 17)
        Label1.TabIndex = 0
        Label1.Text = "كلمة المرور"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(chkAmmand)
        Panel2.Controls.Add(chkOpenExpire)
        Panel2.Controls.Add(chkActiveZakat)
        Panel2.Controls.Add(lblExpire)
        Panel2.Controls.Add(txtExpireDate)
        Panel2.Controls.Add(chkEditCompName)
        Panel2.Controls.Add(btnExit)
        Panel2.Controls.Add(btnOK)
        Panel2.Controls.Add(chkYearClose)
        Panel2.Controls.Add(chkRetention)
        Panel2.Controls.Add(chkCostCenter)
        Panel2.Controls.Add(chkManfc)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(635, 0)
        Panel2.TabIndex = 1
        Panel2.Visible = False
        ' 
        ' chkAmmand
        ' 
        chkAmmand.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAmmand.AutoSize = True
        chkAmmand.Location = New Point(447, 0)
        chkAmmand.Name = "chkAmmand"
        chkAmmand.Size = New Size(92, 21)
        chkAmmand.TabIndex = 46
        chkAmmand.Text = "Ammand"
        chkAmmand.UseVisualStyleBackColor = True
        ' 
        ' chkOpenExpire
        ' 
        chkOpenExpire.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkOpenExpire.AutoSize = True
        chkOpenExpire.Location = New Point(459, 0)
        chkOpenExpire.Name = "chkOpenExpire"
        chkOpenExpire.Size = New Size(80, 21)
        chkOpenExpire.TabIndex = 45
        chkOpenExpire.Text = "Infinity"
        chkOpenExpire.UseVisualStyleBackColor = True
        ' 
        ' chkActiveZakat
        ' 
        chkActiveZakat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkActiveZakat.AutoSize = True
        chkActiveZakat.Location = New Point(360, 0)
        chkActiveZakat.Name = "chkActiveZakat"
        chkActiveZakat.Size = New Size(179, 21)
        chkActiveZakat.TabIndex = 44
        chkActiveZakat.Text = "إظهار تحديث ربط الزكاة"
        chkActiveZakat.UseVisualStyleBackColor = True
        ' 
        ' lblExpire
        ' 
        lblExpire.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblExpire.AutoSize = True
        lblExpire.ImeMode = ImeMode.NoControl
        lblExpire.Location = New Point(435, 0)
        lblExpire.Name = "lblExpire"
        lblExpire.RightToLeft = RightToLeft.No
        lblExpire.Size = New Size(138, 17)
        lblExpire.TabIndex = 42
        lblExpire.Text = "تاريخ إنتهاء الإشتراك"
        ' 
        ' txtExpireDate
        ' 
        txtExpireDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtExpireDate.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtExpireDate.Format = DateTimePickerFormat.Short
        txtExpireDate.Location = New Point(435, 0)
        txtExpireDate.Name = "txtExpireDate"
        txtExpireDate.Size = New Size(200, 26)
        txtExpireDate.TabIndex = 43
        ' 
        ' chkEditCompName
        ' 
        chkEditCompName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkEditCompName.AutoSize = True
        chkEditCompName.Location = New Point(369, 0)
        chkEditCompName.Name = "chkEditCompName"
        chkEditCompName.Size = New Size(170, 21)
        chkEditCompName.TabIndex = 2
        chkEditCompName.Text = "تعديل إسم المؤسسة"
        chkEditCompName.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.Location = New Point(435, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 1
        btnExit.Text = "خروج"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOK.Location = New Point(435, 0)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 23)
        btnOK.TabIndex = 1
        btnOK.Text = "حفظ"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' chkYearClose
        ' 
        chkYearClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkYearClose.AutoSize = True
        chkYearClose.Checked = True
        chkYearClose.CheckState = CheckState.Checked
        chkYearClose.Location = New Point(346, 0)
        chkYearClose.Name = "chkYearClose"
        chkYearClose.Size = New Size(193, 21)
        chkYearClose.TabIndex = 0
        chkYearClose.Text = "إخفاء إقفال السنة المالية"
        chkYearClose.UseVisualStyleBackColor = True
        ' 
        ' chkRetention
        ' 
        chkRetention.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkRetention.AutoSize = True
        chkRetention.Checked = True
        chkRetention.CheckState = CheckState.Checked
        chkRetention.Location = New Point(388, 0)
        chkRetention.Name = "chkRetention"
        chkRetention.Size = New Size(151, 21)
        chkRetention.TabIndex = 0
        chkRetention.Text = "إخفاء حسن التنفيذ"
        chkRetention.UseVisualStyleBackColor = True
        ' 
        ' chkCostCenter
        ' 
        chkCostCenter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkCostCenter.AutoSize = True
        chkCostCenter.Checked = True
        chkCostCenter.CheckState = CheckState.Checked
        chkCostCenter.Location = New Point(389, 0)
        chkCostCenter.Name = "chkCostCenter"
        chkCostCenter.Size = New Size(150, 21)
        chkCostCenter.TabIndex = 0
        chkCostCenter.Text = "إخفاء مراكز التكلفة"
        chkCostCenter.UseVisualStyleBackColor = True
        ' 
        ' chkManfc
        ' 
        chkManfc.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkManfc.AutoSize = True
        chkManfc.Checked = True
        chkManfc.CheckState = CheckState.Checked
        chkManfc.Location = New Point(424, 0)
        chkManfc.Name = "chkManfc"
        chkManfc.Size = New Size(115, 21)
        chkManfc.TabIndex = 0
        chkManfc.Text = "إخفاء التصنيع"
        chkManfc.UseVisualStyleBackColor = True
        ' 
        ' frmCntrlSections
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(635, 50)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "frmCntrlSections"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "إظهار/إخفاء  عناصر"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
