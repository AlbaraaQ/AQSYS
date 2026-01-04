Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmBackupRstore
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DtbTest As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bkuppath As TextBox
    Friend WithEvents btnDoBkUp As Button
    Friend WithEvents btnDoRestore As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents checkBox1 As CheckBox
    Friend WithEvents label1 As Label
    Friend WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents txtRestore As TextBox

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
        saveFileDialog1 = New SaveFileDialog()
        openFileDialog1 = New OpenFileDialog()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button1 = New Button()
        DtbTest = New DateTimePicker()
        checkBox1 = New CheckBox()
        btnclose = New Button()
        btnDoBkUp = New Button()
        label1 = New Label()
        bkuppath = New TextBox()
        TabPage2 = New TabPage()
        Button3 = New Button()
        Button2 = New Button()
        btnDoRestore = New Button()
        Label2 = New Label()
        txtRestore = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' saveFileDialog1
        ' 
        saveFileDialog1.DefaultExt = "*.BAK"
        ' 
        ' openFileDialog1
        ' 
        openFileDialog1.DefaultExt = "*.BAK"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.RightToLeftLayout = True
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(520, 190)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(DtbTest)
        TabPage1.Controls.Add(checkBox1)
        TabPage1.Controls.Add(btnclose)
        TabPage1.Controls.Add(btnDoBkUp)
        TabPage1.Controls.Add(label1)
        TabPage1.Controls.Add(bkuppath)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(512, 161)
        TabPage1.TabIndex = 0
        TabPage1.Text = "النسخ الاحتياطي"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImeMode = ImeMode.NoControl
        Button1.Location = New Point(23, 45)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 30)
        Button1.TabIndex = 13
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DtbTest
        ' 
        DtbTest.Format = DateTimePickerFormat.Short
        DtbTest.Location = New Point(58, 22)
        DtbTest.Name = "DtbTest"
        DtbTest.Size = New Size(200, 24)
        DtbTest.TabIndex = 12
        DtbTest.Visible = False
        ' 
        ' checkBox1
        ' 
        checkBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkBox1.AutoSize = True
        checkBox1.Location = New Point(-45, 77)
        checkBox1.Name = "checkBox1"
        checkBox1.Size = New Size(523, 21)
        checkBox1.TabIndex = 11
        checkBox1.Text = "عمل نسخ احتياطي عند الخروج من البرنامج --- سيتم الحفظ في هذا المسار "
        checkBox1.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnclose.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnclose.Location = New Point(157, 108)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(85, 36)
        btnclose.TabIndex = 10
        btnclose.Text = "خروج"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' btnDoBkUp
        ' 
        btnDoBkUp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDoBkUp.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDoBkUp.Location = New Point(245, 108)
        btnDoBkUp.Name = "btnDoBkUp"
        btnDoBkUp.Size = New Size(124, 36)
        btnDoBkUp.TabIndex = 9
        btnDoBkUp.Text = "تنفيــــــذ"
        btnDoBkUp.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        label1.AutoSize = True
        label1.Location = New Point(301, 29)
        label1.Name = "label1"
        label1.Size = New Size(197, 17)
        label1.TabIndex = 7
        label1.Text = "اختر مسار النسخة الاحتياطية"
        ' 
        ' bkuppath
        ' 
        bkuppath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        bkuppath.BorderStyle = BorderStyle.FixedSingle
        bkuppath.Location = New Point(74, 51)
        bkuppath.Name = "bkuppath"
        bkuppath.ReadOnly = True
        bkuppath.Size = New Size(404, 24)
        bkuppath.TabIndex = 6
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button3)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(btnDoRestore)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(txtRestore)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(512, 161)
        TabPage2.TabIndex = 1
        TabPage2.Text = "استعادة البيانات"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImeMode = ImeMode.NoControl
        Button3.Location = New Point(36, 42)
        Button3.Name = "Button3"
        Button3.Size = New Size(48, 30)
        Button3.TabIndex = 14
        Button3.Text = "..."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(164, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 34)
        Button2.TabIndex = 9
        Button2.Text = "خروج"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnDoRestore
        ' 
        btnDoRestore.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDoRestore.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDoRestore.Location = New Point(267, 95)
        btnDoRestore.Name = "btnDoRestore"
        btnDoRestore.Size = New Size(98, 34)
        btnDoRestore.TabIndex = 8
        btnDoRestore.Text = "تنفيــــــذ"
        btnDoRestore.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(303, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 17)
        Label2.TabIndex = 6
        Label2.Text = "اختر مسار النسخة الاحتياطية"
        ' 
        ' txtRestore
        ' 
        txtRestore.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtRestore.BorderStyle = BorderStyle.FixedSingle
        txtRestore.Location = New Point(87, 49)
        txtRestore.Name = "txtRestore"
        txtRestore.ReadOnly = True
        txtRestore.Size = New Size(378, 24)
        txtRestore.TabIndex = 5
        ' 
        ' frmBackupRstore
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(520, 190)
        Controls.Add(TabControl1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "frmBackupRstore"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "النسخ الاحتياطي واستعادة البيانات"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
