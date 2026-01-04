Imports System.Windows.Forms
Partial Public Class frmTawlasManage
	Inherits Global.System.Windows.Forms.Form

	Private components As Global.System.ComponentModel.IContainer
	Friend WithEvents button1 As Button
	Friend WithEvents button2 As Button
	Friend WithEvents label1 As Label
	Friend WithEvents label2 As Label
	Friend WithEvents lstTawlaGroups As ListView
	Friend WithEvents lstTawlas As ListView
	Friend WithEvents panel1 As Panel
	Friend WithEvents panel2 As Panel
	Friend WithEvents panel3 As Panel
	Friend WithEvents panel4 As Panel
	Friend WithEvents rdAll As RadioButton
	Friend WithEvents rdFamily As RadioButton
	Friend WithEvents rdMix As RadioButton
	Friend WithEvents rdOne As RadioButton

	Protected Overrides Sub Dispose(disposing As Boolean)
		Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
		If flag Then
			Me.components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	Private Sub InitializeComponent()
		Me.panel2 = New Panel()
		Me.lstTawlas = New Global.System.Windows.Forms.ListView()
		Me.panel4 = New Global.System.Windows.Forms.Panel()
		Me.button2 = New Global.System.Windows.Forms.Button()
		Me.button1 = New Global.System.Windows.Forms.Button()
		Me.label2 = New Global.System.Windows.Forms.Label()
		Me.label1 = New Global.System.Windows.Forms.Label()
		Me.panel1 = New Global.System.Windows.Forms.Panel()
		Me.lstTawlaGroups = New Global.System.Windows.Forms.ListView()
		Me.panel3 = New Global.System.Windows.Forms.Panel()
		Me.rdFamily = New Global.System.Windows.Forms.RadioButton()
		Me.rdOne = New Global.System.Windows.Forms.RadioButton()
		Me.rdAll = New Global.System.Windows.Forms.RadioButton()
		Me.rdMix = New Global.System.Windows.Forms.RadioButton()
		Me.panel2.SuspendLayout()
		Me.panel4.SuspendLayout()
		Me.panel1.SuspendLayout()
		Me.panel3.SuspendLayout()
		Me.SuspendLayout()
		Me.panel2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.lstTawlas)
		Me.panel2.Controls.Add(Me.panel4)
		Me.panel2.Dock = Global.System.Windows.Forms.DockStyle.Fill
		Dim panel As Global.System.Windows.Forms.Control = Me.panel2
		Dim point As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 156)
		panel.Location = point
		Me.panel2.Name = "panel2"
		Dim panel2 As Global.System.Windows.Forms.Control = Me.panel2
		Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(1070, 371)
		panel2.Size = size
		Me.panel2.TabIndex = 1
		Me.lstTawlas.Dock = Global.System.Windows.Forms.DockStyle.Fill
		Dim lstTawlas As Global.System.Windows.Forms.Control = Me.lstTawlas
		point = New Global.System.Drawing.Point(0, 31)
		lstTawlas.Location = point
		Me.lstTawlas.Name = "lstTawlas"
		Me.lstTawlas.RightToLeftLayout = True
		Dim lstTawlas2 As Global.System.Windows.Forms.Control = Me.lstTawlas
		size = New Global.System.Drawing.Size(1068, 338)
		lstTawlas2.Size = size
		Me.lstTawlas.TabIndex = 2
		Me.lstTawlas.UseCompatibleStateImageBehavior = False
		Me.panel4.Controls.Add(Me.button2)
		Me.panel4.Controls.Add(Me.button1)
		Me.panel4.Controls.Add(Me.label2)
		Me.panel4.Controls.Add(Me.label1)
		Me.panel4.Dock = Global.System.Windows.Forms.DockStyle.Top
		Dim panel3 As Global.System.Windows.Forms.Control = Me.panel4
		point = New Global.System.Drawing.Point(0, 0)
		panel3.Location = point
		Me.panel4.Name = "panel4"
		Dim panel4 As Global.System.Windows.Forms.Control = Me.panel4
		size = New Global.System.Drawing.Size(1068, 31)
		panel4.Size = size
		Me.panel4.TabIndex = 0
		Me.button2.BackColor = Global.System.Drawing.Color.Yellow
		Me.button2.Dock = Global.System.Windows.Forms.DockStyle.Left
		Dim button As Global.System.Windows.Forms.Control = Me.button2
		point = New Global.System.Drawing.Point(119, 0)
		button.Location = point
		Me.button2.Name = "button2"
		Dim button2 As Global.System.Windows.Forms.Control = Me.button2
		size = New Global.System.Drawing.Size(106, 31)
		button2.Size = size
		Me.button2.TabIndex = 1
		Me.button2.Text = "حجز جديد"
		Me.button2.UseVisualStyleBackColor = False
		Me.button1.BackColor = Global.System.Drawing.Color.Red
		Me.button1.Dock = Global.System.Windows.Forms.DockStyle.Left
		Dim button3 As Global.System.Windows.Forms.Control = Me.button1
		point = New Global.System.Drawing.Point(0, 0)
		button3.Location = point
		Me.button1.Name = "button1"
		Dim button4 As Global.System.Windows.Forms.Control = Me.button1
		size = New Global.System.Drawing.Size(119, 31)
		button4.Size = size
		Me.button1.TabIndex = 1
		Me.button1.Text = "تعديل / إلغاء حجز"
		Me.button1.UseVisualStyleBackColor = False
		Me.label2.AutoSize = True
		Dim label As Global.System.Windows.Forms.Control = Me.label2
		point = New Global.System.Drawing.Point(346, 9)
		label.Location = point
		Me.label2.Name = "label2"
		Dim label2 As Global.System.Windows.Forms.Control = Me.label2
		size = New Global.System.Drawing.Size(382, 13)
		label2.Size = size
		Me.label2.TabIndex = 0
		Me.label2.Text = "أو اختر طاولة للحجز ثم اضغط زر حجز جديد .. أو زر تعديل / إلغاء حجز سابق"
		Me.label1.AutoSize = True
		Dim label3 As Global.System.Windows.Forms.Control = Me.label1
		point = New Global.System.Drawing.Point(742, 9)
		label3.Location = point
		Me.label1.Name = "label1"
		Dim label4 As Global.System.Windows.Forms.Control = Me.label1
		size = New Global.System.Drawing.Size(275, 13)
		label4.Size = size
		Me.label1.TabIndex = 0
		Me.label1.Text = "اضغط ضغطة مزدوجة (دبل كليك) على الطاولة لفتحها"
		Me.panel1.Controls.Add(Me.lstTawlaGroups)
		Me.panel1.Controls.Add(Me.panel3)
		Me.panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
		Dim panel5 As Global.System.Windows.Forms.Control = Me.panel1
		point = New Global.System.Drawing.Point(0, 0)
		panel5.Location = point
		Me.panel1.Name = "panel1"
		Dim panel6 As Global.System.Windows.Forms.Control = Me.panel1
		size = New Global.System.Drawing.Size(1070, 156)
		panel6.Size = size
		Me.panel1.TabIndex = 0
		Me.lstTawlaGroups.Dock = Global.System.Windows.Forms.DockStyle.Fill
		Dim lstTawlaGroups As Global.System.Windows.Forms.Control = Me.lstTawlaGroups
		point = New Global.System.Drawing.Point(0, 36)
		lstTawlaGroups.Location = point
		Me.lstTawlaGroups.Name = "lstTawlaGroups"
		Me.lstTawlaGroups.RightToLeftLayout = True
		Dim lstTawlaGroups2 As Global.System.Windows.Forms.Control = Me.lstTawlaGroups
		size = New Global.System.Drawing.Size(1070, 120)
		lstTawlaGroups2.Size = size
		Me.lstTawlaGroups.TabIndex = 3
		Me.lstTawlaGroups.UseCompatibleStateImageBehavior = False
		Me.panel3.Controls.Add(Me.rdFamily)
		Me.panel3.Controls.Add(Me.rdOne)
		Me.panel3.Controls.Add(Me.rdAll)
		Me.panel3.Controls.Add(Me.rdMix)
		Me.panel3.Dock = Global.System.Windows.Forms.DockStyle.Top
		Dim panel7 As Global.System.Windows.Forms.Control = Me.panel3
		point = New Global.System.Drawing.Point(0, 0)
		panel7.Location = point
		Me.panel3.Name = "panel3"
		Dim panel8 As Global.System.Windows.Forms.Control = Me.panel3
		size = New Global.System.Drawing.Size(1070, 36)
		panel8.Size = size
		Me.panel3.TabIndex = 1
		Me.rdFamily.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.rdFamily.AutoSize = True
		Me.rdFamily.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim rdFamily As Global.System.Windows.Forms.Control = Me.rdFamily
		point = New Global.System.Drawing.Point(428, 10)
		rdFamily.Location = point
		Me.rdFamily.Name = "rdFamily"
		Dim rdFamily2 As Global.System.Windows.Forms.Control = Me.rdFamily
		size = New Global.System.Drawing.Size(58, 17)
		rdFamily2.Size = size
		Me.rdFamily.TabIndex = 6
		Me.rdFamily.Text = "عائلات"
		Me.rdFamily.UseVisualStyleBackColor = True
		Me.rdOne.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.rdOne.AutoSize = True
		Me.rdOne.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim rdOne As Global.System.Windows.Forms.Control = Me.rdOne
		point = New Global.System.Drawing.Point(533, 10)
		rdOne.Location = point
		Me.rdOne.Name = "rdOne"
		Dim rdOne2 As Global.System.Windows.Forms.Control = Me.rdOne
		size = New Global.System.Drawing.Size(51, 17)
		rdOne2.Size = size
		Me.rdOne.TabIndex = 7
		Me.rdOne.Text = "أفراد"
		Me.rdOne.UseVisualStyleBackColor = True
		Me.rdAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.rdAll.AutoSize = True
		Me.rdAll.Checked = True
		Me.rdAll.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim rdAll As Global.System.Windows.Forms.Control = Me.rdAll
		point = New Global.System.Drawing.Point(736, 10)
		rdAll.Location = point
		Me.rdAll.Name = "rdAll"
		Dim rdAll2 As Global.System.Windows.Forms.Control = Me.rdAll
		size = New Global.System.Drawing.Size(49, 17)
		rdAll2.Size = size
		Me.rdAll.TabIndex = 8
		Me.rdAll.TabStop = True
		Me.rdAll.Text = "الكل"
		Me.rdAll.UseVisualStyleBackColor = True
		Me.rdMix.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
		Me.rdMix.AutoSize = True
		Me.rdMix.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
		Dim rdMix As Global.System.Windows.Forms.Control = Me.rdMix
		point = New Global.System.Drawing.Point(638, 10)
		rdMix.Location = point
		Me.rdMix.Name = "rdMix"
		Dim rdMix2 As Global.System.Windows.Forms.Control = Me.rdMix
		size = New Global.System.Drawing.Size(57, 17)
		rdMix2.Size = size
		Me.rdMix.TabIndex = 8
		Me.rdMix.Text = "مختلط"
		Me.rdMix.UseVisualStyleBackColor = True
		Dim sizeF As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7.0F, 13.0F)
		Me.AutoScaleDimensions = sizeF
		Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Global.System.Drawing.Color.White
		size = New Global.System.Drawing.Size(1070, 527)
		Me.ClientSize = size
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Font = New Global.System.Drawing.Font("Tahoma", 8.0F, Global.System.Drawing.FontStyle.Bold)
		Me.Name = "frmTawlasManage"
		Me.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
		Me.RightToLeftLayout = True
		Me.ShowIcon = False
		Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "الطاولات"
		Me.WindowState = Global.System.Windows.Forms.FormWindowState.Maximized
		Me.panel2.ResumeLayout(False)
		Me.panel4.ResumeLayout(False)
		Me.panel4.PerformLayout()
		Me.panel1.ResumeLayout(False)
		Me.panel3.ResumeLayout(False)
		Me.panel3.PerformLayout()
		Me.ResumeLayout(False)
	End Sub
End Class
