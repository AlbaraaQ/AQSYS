Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
	Public Partial Class Frm_Calculator
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Public isfirst As Boolean

		Private calcFunc As String

		Private hasDecimal As Boolean

		Private valHolder1 As Double

		Private valHolder2 As Double
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Frm_Calculator_Load
			AddHandler MyBase.Click, AddressOf Me.Frm_Calculator_Click
			AddHandler MyBase.KeyDown, AddressOf Me.Frm_Calculator_KeyDown
			Frm_Calculator.__ENCAddToList(Me)
			Me.isfirst = True
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Frm_Calculator.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = Frm_Calculator.__ENCList.Count = Frm_Calculator.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Frm_Calculator.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = Frm_Calculator.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								Frm_Calculator.__ENCList(num) = Frm_Calculator.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Frm_Calculator.__ENCList.RemoveRange(num, Frm_Calculator.__ENCList.Count - num)
					Frm_Calculator.__ENCList.Capacity = Frm_Calculator.__ENCList.Count
				End If
				Frm_Calculator.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub cmd8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd8.Click
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd8.Text
			Me.TextBox1.Focus()
		End Sub

  Private Sub cmd135_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd135.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd135.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd2.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd2.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd3.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd3.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd4.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd4.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
		End Sub

		Private Sub ok2()
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, "", False) = 0
			If flag Then
				MessageBox.Show("تحذير", "من فضلك ادخل الكمية")
			Else
				flag = (Decimal.Compare(Convert.ToDecimal(Me.TextBox1.Text), 1D) >= 0 AndAlso Decimal.Compare(Convert.ToDecimal(Me.TextBox1.Text), 1000000D) <= 0)
				If flag Then
					MySettingsProperty.Settings.QTY = Convert.ToDecimal(Me.TextBox1.Text)
					MySettingsProperty.Settings.Save()
					Me.Close()
				Else
					MessageBox.Show("تحذير", "من فضلك ادخل ارقام فقط")
				End If
			End If
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Me.ok2()
		End Sub

  Private Sub cmd5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd5.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd5.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd6.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd6.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd7.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd7.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd9.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd9.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmd0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd0.Click
			Dim flag As Boolean = Me.isfirst
			If flag Then
				Me.TextBox1.Text = ""
			End If
			Dim textBox As TextBox = Me.TextBox1
			textBox.Text += Me.cmd0.Text
			Me.TextBox1.Focus()
			Me.isfirst = False
		End Sub

  Private Sub cmdClearAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClearAll.Click
			Me.TextBox1.Text = String.Empty
			Me.valHolder1 = 0.0
			Me.valHolder2 = 0.0
			Me.calcFunc = String.Empty
			Me.hasDecimal = False
			Me.TextBox1.Focus()
		End Sub

  Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.ok2()
			End If
		End Sub

	Private Sub Frm_Calculator_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.TextBox1.Focus()
		Me.Timer1.Enabled = True
	End Sub

	Private Sub Frm_Calculator_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.TextBox1.Focus()
	End Sub

	Private Sub Frm_Calculator_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		Me.TextBox1.Focus()
	End Sub

	Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
			Dim flag As Boolean = Not Char.IsControl(e.KeyChar)
			If flag Then
				Dim flag2 As Boolean = Char.IsDigit(e.KeyChar)
				If Not flag2 Then
					Interaction.MsgBox(" الحقل لا يقبل الا الارقام فقط ", MsgBoxStyle.OkOnly, Nothing)
					e.Handled = True
					Me.TextBox1.Focus()
				End If
			End If
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Me.TextBox1.Focus()
			Me.Timer1.Enabled = False
		End Sub
	End Class
