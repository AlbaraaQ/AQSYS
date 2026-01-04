Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Partial Class frmBarcode
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents chkCompany As CheckBox
    Friend WithEvents chkCurrency As CheckBox
    Friend WithEvents chkExpireDate As CheckBox
    Friend WithEvents chkInTax As CheckBox
    Friend WithEvents chkItemEN As CheckBox
    Friend WithEvents chkPrice As CheckBox
    Friend WithEvents chkProdDate As CheckBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents cmbItems As ComboBox
    Friend WithEvents cmbPrinters As ComboBox
    Friend WithEvents lblBarcodeH As TextBox
    Friend WithEvents lblBarcodeW As TextBox
    Friend WithEvents rdAllItems As RadioButton
    Friend WithEvents rdGroup As RadioButton
    Friend WithEvents rdItem As RadioButton
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents txtExpireDate As TextBox
    Friend WithEvents txtNum As NumericUpDown
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProdDate As TextBox

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
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        rdAllItems = New RadioButton()
        rdGroup = New RadioButton()
        rdItem = New RadioButton()
        lblBarcodeH = New TextBox()
        lblBarcodeW = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        chkItemEN = New CheckBox()
        chkCompany = New CheckBox()
        txtNum = New NumericUpDown()
        cmbPrinters = New ComboBox()
        Label4 = New Label()
        chkInTax = New CheckBox()
        chkCurrency = New CheckBox()
        chkExpireDate = New CheckBox()
        chkProdDate = New CheckBox()
        chkPrice = New CheckBox()
        txtCurrency = New TextBox()
        Label8 = New Label()
        txtExpireDate = New TextBox()
        Label10 = New Label()
        txtProdDate = New TextBox()
        Label9 = New Label()
        txtPrice = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        txtBarcode = New TextBox()
        Label2 = New Label()
        cmbGroups = New ComboBox()
        cmbItems = New ComboBox()
        GroupBox2 = New GroupBox()
        PrintDialog1 = New PrintDialog()
        GroupBox1.SuspendLayout()
        CType(txtNum, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(rdAllItems)
        GroupBox1.Controls.Add(rdGroup)
        GroupBox1.Controls.Add(rdItem)
        GroupBox1.Controls.Add(lblBarcodeH)
        GroupBox1.Controls.Add(lblBarcodeW)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(chkItemEN)
        GroupBox1.Controls.Add(chkCompany)
        GroupBox1.Controls.Add(txtNum)
        GroupBox1.Controls.Add(cmbPrinters)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(chkInTax)
        GroupBox1.Controls.Add(chkCurrency)
        GroupBox1.Controls.Add(chkExpireDate)
        GroupBox1.Controls.Add(chkProdDate)
        GroupBox1.Controls.Add(chkPrice)
        GroupBox1.Controls.Add(txtCurrency)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtExpireDate)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtProdDate)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtBarcode)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cmbGroups)
        GroupBox1.Controls.Add(cmbItems)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(1031, 348)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.ImeMode = ImeMode.NoControl
        Button5.Location = New Point(763, 280)
        Button5.Margin = New Padding(4, 5, 4, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 48)
        Button5.TabIndex = 20
        Button5.Text = "طباعة2"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' rdAllItems
        ' 
        rdAllItems.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdAllItems.AutoSize = True
        rdAllItems.ImeMode = ImeMode.NoControl
        rdAllItems.Location = New Point(851, 95)
        rdAllItems.Margin = New Padding(4, 5, 4, 5)
        rdAllItems.Name = "rdAllItems"
        rdAllItems.Size = New Size(104, 24)
        rdAllItems.TabIndex = 19
        rdAllItems.Text = "كل الأصناف"
        rdAllItems.UseVisualStyleBackColor = True
        ' 
        ' rdGroup
        ' 
        rdGroup.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdGroup.AutoSize = True
        rdGroup.ImeMode = ImeMode.NoControl
        rdGroup.Location = New Point(872, 58)
        rdGroup.Margin = New Padding(4, 5, 4, 5)
        rdGroup.Name = "rdGroup"
        rdGroup.Size = New Size(82, 24)
        rdGroup.TabIndex = 19
        rdGroup.Text = "مجموعة"
        rdGroup.UseVisualStyleBackColor = True
        ' 
        ' rdItem
        ' 
        rdItem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        rdItem.AutoSize = True
        rdItem.Checked = True
        rdItem.Location = New Point(890, 20)
        rdItem.Margin = New Padding(4, 5, 4, 5)
        rdItem.Name = "rdItem"
        rdItem.Size = New Size(65, 24)
        rdItem.TabIndex = 19
        rdItem.TabStop = True
        rdItem.Text = "صنف"
        rdItem.UseVisualStyleBackColor = True
        ' 
        ' lblBarcodeH
        ' 
        lblBarcodeH.Location = New Point(579, 183)
        lblBarcodeH.Margin = New Padding(4, 5, 4, 5)
        lblBarcodeH.Name = "lblBarcodeH"
        lblBarcodeH.Size = New Size(49, 27)
        lblBarcodeH.TabIndex = 16
        lblBarcodeH.Text = "0.8"
        lblBarcodeH.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblBarcodeW
        ' 
        lblBarcodeW.Location = New Point(653, 183)
        lblBarcodeW.Margin = New Padding(4, 5, 4, 5)
        lblBarcodeW.Name = "lblBarcodeW"
        lblBarcodeW.Size = New Size(55, 27)
        lblBarcodeW.TabIndex = 18
        lblBarcodeW.Text = "4"
        lblBarcodeW.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ImeMode = ImeMode.NoControl
        Label6.Location = New Point(715, 189)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(175, 20)
        Label6.TabIndex = 12
        Label6.Text = "مقاس شريط الباركود (سم)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ImeMode = ImeMode.NoControl
        Label7.Location = New Point(635, 188)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 20)
        Label7.TabIndex = 14
        Label7.Text = "*"
        ' 
        ' chkItemEN
        ' 
        chkItemEN.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkItemEN.AutoSize = True
        chkItemEN.ImeMode = ImeMode.NoControl
        chkItemEN.Location = New Point(122, 155)
        chkItemEN.Margin = New Padding(4, 5, 4, 5)
        chkItemEN.Name = "chkItemEN"
        chkItemEN.Size = New Size(171, 24)
        chkItemEN.TabIndex = 10
        chkItemEN.Text = "طباعة اسم الصنف EN"
        chkItemEN.UseVisualStyleBackColor = True
        ' 
        ' chkCompany
        ' 
        chkCompany.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkCompany.AutoSize = True
        chkCompany.ImeMode = ImeMode.NoControl
        chkCompany.Location = New Point(311, 154)
        chkCompany.Margin = New Padding(4, 5, 4, 5)
        chkCompany.Name = "chkCompany"
        chkCompany.Size = New Size(164, 24)
        chkCompany.TabIndex = 10
        chkCompany.Text = "طباعة اسم المؤسسة"
        chkCompany.UseVisualStyleBackColor = True
        ' 
        ' txtNum
        ' 
        txtNum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtNum.Location = New Point(361, 92)
        txtNum.Margin = New Padding(4, 5, 4, 5)
        txtNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(113, 27)
        txtNum.TabIndex = 9
        txtNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbPrinters
        ' 
        cmbPrinters.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbPrinters.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPrinters.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbPrinters.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmbPrinters.FormattingEnabled = True
        cmbPrinters.Location = New Point(580, 138)
        cmbPrinters.Margin = New Padding(4, 5, 4, 5)
        cmbPrinters.Name = "cmbPrinters"
        cmbPrinters.Size = New Size(281, 26)
        cmbPrinters.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.ImeMode = ImeMode.NoControl
        Label4.Location = New Point(871, 145)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 7
        Label4.Text = "اختر طابعة"
        ' 
        ' chkInTax
        ' 
        chkInTax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkInTax.AutoSize = True
        chkInTax.ImeMode = ImeMode.NoControl
        chkInTax.Location = New Point(112, 108)
        chkInTax.Margin = New Padding(4, 5, 4, 5)
        chkInTax.Name = "chkInTax"
        chkInTax.Size = New Size(119, 24)
        chkInTax.TabIndex = 6
        chkInTax.Text = "شامل الضريبة"
        chkInTax.UseVisualStyleBackColor = True
        ' 
        ' chkCurrency
        ' 
        chkCurrency.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkCurrency.AutoSize = True
        chkCurrency.Checked = True
        chkCurrency.CheckState = CheckState.Checked
        chkCurrency.ImeMode = ImeMode.NoControl
        chkCurrency.Location = New Point(113, 77)
        chkCurrency.Margin = New Padding(4, 5, 4, 5)
        chkCurrency.Name = "chkCurrency"
        chkCurrency.Size = New Size(18, 17)
        chkCurrency.TabIndex = 6
        chkCurrency.UseVisualStyleBackColor = True
        ' 
        ' chkExpireDate
        ' 
        chkExpireDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkExpireDate.AutoSize = True
        chkExpireDate.ImeMode = ImeMode.NoControl
        chkExpireDate.Location = New Point(87, 229)
        chkExpireDate.Margin = New Padding(4, 5, 4, 5)
        chkExpireDate.Name = "chkExpireDate"
        chkExpireDate.Size = New Size(18, 17)
        chkExpireDate.TabIndex = 6
        chkExpireDate.UseVisualStyleBackColor = True
        ' 
        ' chkProdDate
        ' 
        chkProdDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkProdDate.AutoSize = True
        chkProdDate.ImeMode = ImeMode.NoControl
        chkProdDate.Location = New Point(294, 228)
        chkProdDate.Margin = New Padding(4, 5, 4, 5)
        chkProdDate.Name = "chkProdDate"
        chkProdDate.Size = New Size(18, 17)
        chkProdDate.TabIndex = 6
        chkProdDate.UseVisualStyleBackColor = True
        ' 
        ' chkPrice
        ' 
        chkPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkPrice.AutoSize = True
        chkPrice.Checked = True
        chkPrice.CheckState = CheckState.Checked
        chkPrice.Location = New Point(113, 42)
        chkPrice.Margin = New Padding(4, 5, 4, 5)
        chkPrice.Name = "chkPrice"
        chkPrice.Size = New Size(18, 17)
        chkPrice.TabIndex = 6
        chkPrice.UseVisualStyleBackColor = True
        ' 
        ' txtCurrency
        ' 
        txtCurrency.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCurrency.Location = New Point(135, 71)
        txtCurrency.Margin = New Padding(4, 5, 4, 5)
        txtCurrency.Name = "txtCurrency"
        txtCurrency.Size = New Size(95, 27)
        txtCurrency.TabIndex = 5
        txtCurrency.Text = "SR"
        txtCurrency.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.ImeMode = ImeMode.NoControl
        Label8.Location = New Point(239, 77)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 20)
        Label8.TabIndex = 4
        Label8.Text = "العملة"
        ' 
        ' txtExpireDate
        ' 
        txtExpireDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtExpireDate.Location = New Point(109, 225)
        txtExpireDate.Margin = New Padding(4, 5, 4, 5)
        txtExpireDate.Name = "txtExpireDate"
        txtExpireDate.Size = New Size(157, 27)
        txtExpireDate.TabIndex = 5
        txtExpireDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.ImeMode = ImeMode.NoControl
        Label10.Location = New Point(125, 200)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 20)
        Label10.TabIndex = 4
        Label10.Text = "تاريخ إنتهاء الصلاحية"
        ' 
        ' txtProdDate
        ' 
        txtProdDate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtProdDate.Location = New Point(316, 223)
        txtProdDate.Margin = New Padding(4, 5, 4, 5)
        txtProdDate.Name = "txtProdDate"
        txtProdDate.Size = New Size(157, 27)
        txtProdDate.TabIndex = 5
        txtProdDate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.ImeMode = ImeMode.NoControl
        Label9.Location = New Point(367, 198)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 20)
        Label9.TabIndex = 4
        Label9.Text = "تاريخ الإنتاج"
        ' 
        ' txtPrice
        ' 
        txtPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtPrice.Location = New Point(135, 37)
        txtPrice.Margin = New Padding(4, 5, 4, 5)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(157, 27)
        txtPrice.TabIndex = 5
        txtPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(185, 12)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 4
        Label3.Text = "سعر البيع"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.Location = New Point(543, 223)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 48)
        Button4.TabIndex = 3
        Button4.Text = "خروج"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.ImeMode = ImeMode.NoControl
        Button2.Location = New Point(655, 223)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 48)
        Button2.TabIndex = 3
        Button2.Text = "طباعة A4"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(763, 223)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 48)
        Button3.TabIndex = 3
        Button3.Text = "طباعة"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(871, 223)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 48)
        Button1.TabIndex = 3
        Button1.Text = "عرض"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.ImeMode = ImeMode.NoControl
        Label5.Location = New Point(391, 71)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 1
        Label5.Text = "عدد النسخ"
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBarcode.Location = New Point(301, 37)
        txtBarcode.Margin = New Padding(4, 5, 4, 5)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.Size = New Size(231, 27)
        txtBarcode.TabIndex = 2
        txtBarcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(391, 12)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 1
        Label2.Text = "الباركود"
        ' 
        ' cmbGroups
        ' 
        cmbGroups.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbGroups.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbGroups.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbGroups.FormattingEnabled = True
        cmbGroups.Location = New Point(580, 55)
        cmbGroups.Margin = New Padding(4, 5, 4, 5)
        cmbGroups.Name = "cmbGroups"
        cmbGroups.Size = New Size(281, 28)
        cmbGroups.TabIndex = 0
        ' 
        ' cmbItems
        ' 
        cmbItems.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbItems.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbItems.FormattingEnabled = True
        cmbItems.Location = New Point(580, 18)
        cmbItems.Margin = New Padding(4, 5, 4, 5)
        cmbItems.Name = "cmbItems"
        cmbItems.Size = New Size(281, 28)
        cmbItems.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 348)
        GroupBox2.Margin = New Padding(4, 5, 4, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 5, 4, 5)
        GroupBox2.Size = New Size(1031, 627)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' frmBarcode
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1031, 975)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "frmBarcode"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "إنشاء وطباعة باركود"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(txtNum, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
