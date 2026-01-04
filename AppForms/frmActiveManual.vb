Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
	Public Partial Class frmActiveManual
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Shared Sub New()
		End Sub
		Public Sub New()
			frmActiveManual.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmActiveManual.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmActiveManual.__ENCList.Count = frmActiveManual.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmActiveManual.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmActiveManual.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmActiveManual.__ENCList(num) = frmActiveManual.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmActiveManual.__ENCList.RemoveRange(num, frmActiveManual.__ENCList.Count - num)
					frmActiveManual.__ENCList.Capacity = frmActiveManual.__ENCList.Count
				End If
				frmActiveManual.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub txtPWD_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPWD.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return] And Operators.CompareString(Me.txtPWD.Text, "abshir2020", False) = 0
			If flag Then
				Me.Panel2.Visible = True
			End If
		End Sub

  Private Sub btnActive_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActive.Click
		Try
			Dim Form1 As New Form1()
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\aclf.txt"
			File.WriteAllText(path, "ok", Encoding.[Default])
			MainClass.IsTrial = False
			Form1.lblIsTrial.Caption = ""
			Form1.lblDash3.Caption = ""
			Interaction.MsgBox("تم التفعيل", MsgBoxStyle.OkOnly, Nothing)
		Catch ex As Exception
			Interaction.MsgBox("Error: " + ex.Message, MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub
	End Class
