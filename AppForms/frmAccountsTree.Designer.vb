Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmAccountsTree
    Inherits Global.System.Windows.Forms.Form

    Private components As IContainer
    Friend WithEvents AName As TextBox
    Friend WithEvents Code As TextBox
    Friend WithEvents EName As TextBox
    Friend WithEvents FinalAcc As ComboBox
    Friend WithEvents IValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ParentCode As ComboBox
    Friend WithEvents User As TextBox
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents credit As RadioButton
    Friend WithEvents debt As RadioButton
    Friend WithEvents label1 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents label8 As Label
    Friend WithEvents lblivalue As Label
    Friend WithEvents lblnature As Label
    Friend WithEvents main As RadioButton
    Friend WithEvents panel1 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents panel3 As Panel
    Friend WithEvents sub1 As RadioButton
    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents tabPage1 As TabPage
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents treeView1 As TreeView
    Friend WithEvents txtDate As DateTimePicker

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
        panel1 = New Panel()
        tabControl1 = New TabControl()
        tabPage1 = New TabPage()
        ParentCode = New ComboBox()
        panel3 = New Panel()
        label11 = New Label()
        FinalAcc = New ComboBox()
        txtDate = New DateTimePicker()
        lblnature = New Label()
        debt = New RadioButton()
        credit = New RadioButton()
        IValue = New TextBox()
        label5 = New Label()
        lblivalue = New Label()
        label6 = New Label()
        User = New TextBox()
        Code = New TextBox()
        label1 = New Label()
        main = New RadioButton()
        Label3 = New Label()
        label2 = New Label()
        sub1 = New RadioButton()
        label8 = New Label()
        EName = New TextBox()
        AName = New TextBox()
        label4 = New Label()
        treeView1 = New TreeView()
        toolStrip1 = New ToolStrip()
        btnNew = New ToolStripButton()
        btnSave = New ToolStripButton()
        btnDelete = New ToolStripButton()
        toolStripSeparator2 = New ToolStripSeparator()
        btnClose = New ToolStripButton()
        panel1.SuspendLayout()
        tabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        panel3.SuspendLayout()
        toolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panel1
        ' 
        panel1.BackColor = SystemColors.InactiveCaption
        panel1.BorderStyle = BorderStyle.Fixed3D
        panel1.Controls.Add(tabControl1)
        panel1.Controls.Add(treeView1)
        panel1.Controls.Add(toolStrip1)
        panel1.Dock = DockStyle.Fill
        panel1.Location = New Point(0, 0)
        panel1.Margin = New Padding(3, 4, 3, 4)
        panel1.Name = "panel1"
        panel1.Size = New Size(745, 566)
        panel1.TabIndex = 7
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Dock = DockStyle.Fill
        tabControl1.Location = New Point(295, 0)
        tabControl1.Margin = New Padding(3, 4, 3, 4)
        tabControl1.Name = "tabControl1"
        tabControl1.RightToLeftLayout = True
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(446, 509)
        tabControl1.TabIndex = 22
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(ParentCode)
        tabPage1.Controls.Add(panel3)
        tabPage1.Controls.Add(Code)
        tabPage1.Controls.Add(label1)
        tabPage1.Controls.Add(main)
        tabPage1.Controls.Add(Label3)
        tabPage1.Controls.Add(label2)
        tabPage1.Controls.Add(sub1)
        tabPage1.Controls.Add(label8)
        tabPage1.Controls.Add(EName)
        tabPage1.Controls.Add(AName)
        tabPage1.Controls.Add(label4)
        tabPage1.Location = New Point(4, 25)
        tabPage1.Margin = New Padding(3, 4, 3, 4)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 4, 3, 4)
        tabPage1.Size = New Size(438, 480)
        tabPage1.TabIndex = 0
        tabPage1.Text = "تكويد الحساب"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' ParentCode
        ' 
        ParentCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ParentCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ParentCode.AutoCompleteSource = AutoCompleteSource.ListItems
        ParentCode.FormattingEnabled = True
        ParentCode.Location = New Point(18, 124)
        ParentCode.Margin = New Padding(3, 4, 3, 4)
        ParentCode.Name = "ParentCode"
        ParentCode.Size = New Size(227, 24)
        ParentCode.TabIndex = 2
        ' 
        ' panel3
        ' 
        panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panel3.Controls.Add(label11)
        panel3.Controls.Add(FinalAcc)
        panel3.Controls.Add(txtDate)
        panel3.Controls.Add(lblnature)
        panel3.Controls.Add(debt)
        panel3.Controls.Add(credit)
        panel3.Controls.Add(IValue)
        panel3.Controls.Add(label5)
        panel3.Controls.Add(lblivalue)
        panel3.Controls.Add(label6)
        panel3.Controls.Add(User)
        panel3.Location = New Point(18, 197)
        panel3.Margin = New Padding(3, 4, 3, 4)
        panel3.Name = "panel3"
        panel3.Size = New Size(384, 245)
        panel3.TabIndex = 19
        panel3.Visible = False
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(239, 174)
        label11.Name = "label11"
        label11.Size = New Size(124, 17)
        label11.TabIndex = 25
        label11.Text = "حساب نهاية العام"
        ' 
        ' FinalAcc
        ' 
        FinalAcc.DropDownStyle = ComboBoxStyle.DropDownList
        FinalAcc.FormattingEnabled = True
        FinalAcc.Items.AddRange(New Object() {"ميزانية", "أرباح وخسائر", "لا يتبع حساب"})
        FinalAcc.Location = New Point(38, 169)
        FinalAcc.Margin = New Padding(3, 4, 3, 4)
        FinalAcc.Name = "FinalAcc"
        FinalAcc.Size = New Size(189, 24)
        FinalAcc.TabIndex = 5
        ' 
        ' txtDate
        ' 
        txtDate.Format = DateTimePickerFormat.Short
        txtDate.Location = New Point(81, 96)
        txtDate.Margin = New Padding(3, 4, 3, 4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(146, 24)
        txtDate.TabIndex = 2
        ' 
        ' lblnature
        ' 
        lblnature.AutoSize = True
        lblnature.Location = New Point(241, 46)
        lblnature.Name = "lblnature"
        lblnature.Size = New Size(104, 17)
        lblnature.TabIndex = 5
        lblnature.Text = "طبيعة الحساب"
        ' 
        ' debt
        ' 
        debt.AutoSize = True
        debt.Checked = True
        debt.Location = New Point(161, 43)
        debt.Margin = New Padding(3, 4, 3, 4)
        debt.Name = "debt"
        debt.Size = New Size(62, 21)
        debt.TabIndex = 0
        debt.TabStop = True
        debt.Text = "مدين"
        debt.UseVisualStyleBackColor = True
        ' 
        ' credit
        ' 
        credit.AutoSize = True
        credit.Location = New Point(74, 43)
        credit.Margin = New Padding(3, 4, 3, 4)
        credit.Name = "credit"
        credit.Size = New Size(58, 21)
        credit.TabIndex = 1
        credit.Text = "دائن"
        credit.UseVisualStyleBackColor = True
        ' 
        ' IValue
        ' 
        IValue.BorderStyle = BorderStyle.FixedSingle
        IValue.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        IValue.Location = New Point(81, -27)
        IValue.Margin = New Padding(3, 4, 3, 4)
        IValue.Name = "IValue"
        IValue.Size = New Size(146, 24)
        IValue.TabIndex = 4
        IValue.TextAlign = HorizontalAlignment.Center
        IValue.Visible = False
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(234, 101)
        label5.Name = "label5"
        label5.Size = New Size(126, 17)
        label5.TabIndex = 11
        label5.Text = "تاريخ فتح الحساب"
        ' 
        ' lblivalue
        ' 
        lblivalue.AutoSize = True
        lblivalue.Location = New Point(240, -23)
        lblivalue.Name = "lblivalue"
        lblivalue.Size = New Size(118, 17)
        lblivalue.TabIndex = 14
        lblivalue.Text = "الرصيد الافتتاحي"
        lblivalue.Visible = False
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(258, 132)
        label6.Name = "label6"
        label6.Size = New Size(75, 17)
        label6.TabIndex = 12
        label6.Text = "المستخدم"
        ' 
        ' User
        ' 
        User.BorderStyle = BorderStyle.FixedSingle
        User.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        User.Location = New Point(81, 129)
        User.Margin = New Padding(3, 4, 3, 4)
        User.Name = "User"
        User.ReadOnly = True
        User.Size = New Size(146, 24)
        User.TabIndex = 3
        User.TextAlign = HorizontalAlignment.Center
        ' 
        ' Code
        ' 
        Code.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Code.BorderStyle = BorderStyle.FixedSingle
        Code.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Code.Location = New Point(112, 17)
        Code.Margin = New Padding(3, 4, 3, 4)
        Code.Name = "Code"
        Code.Size = New Size(133, 24)
        Code.TabIndex = 0
        Code.TextAlign = HorizontalAlignment.Center
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label1.AutoSize = True
        label1.Location = New Point(274, 22)
        label1.Name = "label1"
        label1.Size = New Size(90, 17)
        label1.TabIndex = 1
        label1.Text = "كود الحساب"
        ' 
        ' main
        ' 
        main.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        main.AutoSize = True
        main.Checked = True
        main.Location = New Point(160, 164)
        main.Margin = New Padding(3, 4, 3, 4)
        main.Name = "main"
        main.Size = New Size(77, 21)
        main.TabIndex = 3
        main.TabStop = True
        main.Text = "رئيسي"
        main.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.ImeMode = ImeMode.NoControl
        Label3.Location = New Point(270, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 17)
        Label3.TabIndex = 3
        Label3.Text = "اسم الحساب (انجليزي)"
        ' 
        ' label2
        ' 
        label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label2.AutoSize = True
        label2.Location = New Point(270, 55)
        label2.Name = "label2"
        label2.Size = New Size(149, 17)
        label2.TabIndex = 3
        label2.Text = "اسم الحساب (عربي)"
        ' 
        ' sub1
        ' 
        sub1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        sub1.AutoSize = True
        sub1.Location = New Point(77, 164)
        sub1.Margin = New Padding(3, 4, 3, 4)
        sub1.Name = "sub1"
        sub1.Size = New Size(70, 21)
        sub1.TabIndex = 4
        sub1.Text = "فرعي"
        sub1.UseVisualStyleBackColor = True
        ' 
        ' label8
        ' 
        label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label8.AutoSize = True
        label8.Location = New Point(267, 166)
        label8.Name = "label8"
        label8.Size = New Size(89, 17)
        label8.TabIndex = 16
        label8.Text = "نوع الحساب"
        ' 
        ' EName
        ' 
        EName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        EName.BorderStyle = BorderStyle.FixedSingle
        EName.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        EName.Location = New Point(18, 84)
        EName.Margin = New Padding(3, 4, 3, 4)
        EName.Name = "EName"
        EName.Size = New Size(227, 24)
        EName.TabIndex = 1
        EName.TextAlign = HorizontalAlignment.Center
        ' 
        ' AName
        ' 
        AName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AName.BorderStyle = BorderStyle.FixedSingle
        AName.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        AName.Location = New Point(18, 52)
        AName.Margin = New Padding(3, 4, 3, 4)
        AName.Name = "AName"
        AName.Size = New Size(227, 24)
        AName.TabIndex = 1
        AName.TextAlign = HorizontalAlignment.Center
        ' 
        ' label4
        ' 
        label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label4.AutoSize = True
        label4.Location = New Point(266, 133)
        label4.Name = "label4"
        label4.Size = New Size(97, 17)
        label4.TabIndex = 8
        label4.Text = " الحساب الأب"
        ' 
        ' treeView1
        ' 
        treeView1.Dock = DockStyle.Left
        treeView1.Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        treeView1.Location = New Point(0, 0)
        treeView1.Margin = New Padding(3, 4, 3, 4)
        treeView1.Name = "treeView1"
        treeView1.RightToLeft = RightToLeft.No
        treeView1.Size = New Size(295, 509)
        treeView1.TabIndex = 5
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Dock = DockStyle.Bottom
        toolStrip1.ImageScalingSize = New Size(20, 20)
        toolStrip1.Items.AddRange(New ToolStripItem() {btnNew, btnSave, btnDelete, toolStripSeparator2, btnClose})
        toolStrip1.Location = New Point(0, 509)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.RightToLeft = RightToLeft.Yes
        toolStrip1.Size = New Size(741, 53)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnNew
        ' 
        btnNew.AutoSize = False
        btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNew.Image = My.Resources.Resources._new
        btnNew.ImageScaling = ToolStripItemImageScaling.None
        btnNew.ImageTransparentColor = Color.Magenta
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(50, 50)
        btnNew.Text = "جديد"
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = False
        btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnSave.Image = My.Resources.Resources.save
        btnSave.ImageScaling = ToolStripItemImageScaling.None
        btnSave.ImageTransparentColor = Color.Magenta
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(50, 50)
        btnSave.Text = "حفظ"
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = False
        btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.ImageScaling = ToolStripItemImageScaling.None
        btnDelete.ImageTransparentColor = Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(50, 50)
        btnDelete.Text = "حذف"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 53)
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = False
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnClose.Image = My.Resources.Resources._exit
        btnClose.ImageScaling = ToolStripItemImageScaling.None
        btnClose.ImageTransparentColor = Color.Magenta
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(50, 50)
        btnClose.Text = "خروج"
        ' 
        ' frmAccountsTree
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 566)
        Controls.Add(panel1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmAccountsTree"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "شجرة الحسابات"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        tabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        panel3.ResumeLayout(False)
        panel3.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
