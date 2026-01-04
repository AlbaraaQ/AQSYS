Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmFinancialYearClose
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents chkToDate As CheckBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtToDate As DateTimePicker
    Friend WithEvents txtYear As TextBox

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
        Button1 = New Button()
        ProgressBar1 = New ProgressBar()
        lblStatus = New Label()
        txtYear = New TextBox()
        Label2 = New Label()
        txtToDate = New DateTimePicker()
        chkToDate = New CheckBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "بدأ"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.Location = New Point(0, 27)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(180, 23)
        ProgressBar1.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(266, 59)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 2
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(266, 59)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(100, 24)
        txtYear.TabIndex = 3
        txtYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 17)
        Label2.TabIndex = 4
        Label2.Text = "Database"
        ' 
        ' txtToDate
        ' 
        txtToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtToDate.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtToDate.Format = DateTimePickerFormat.Short
        txtToDate.Location = New Point(266, 59)
        txtToDate.Name = "txtToDate"
        txtToDate.Size = New Size(200, 24)
        txtToDate.TabIndex = 10
        ' 
        ' chkToDate
        ' 
        chkToDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkToDate.AutoSize = True
        chkToDate.Location = New Point(240, 59)
        chkToDate.Name = "chkToDate"
        chkToDate.Size = New Size(130, 21)
        chkToDate.TabIndex = 9
        chkToDate.Text = "إقفال إلى تاريخ"
        chkToDate.UseVisualStyleBackColor = True
        ' 
        ' frmFinancialYearClose
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 16.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(180, 50)
        Controls.Add(txtToDate)
        Controls.Add(chkToDate)
        Controls.Add(Label2)
        Controls.Add(txtYear)
        Controls.Add(lblStatus)
        Controls.Add(ProgressBar1)
        Controls.Add(Button1)
        Font = New Font("Tahoma", 8.0F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        Name = "frmFinancialYearClose"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "إقفال السنة المالية"
        ResumeLayout(False)
        PerformLayout()
    End Sub
End Class
