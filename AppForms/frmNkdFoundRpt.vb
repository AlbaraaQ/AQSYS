Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
	Public Partial Class frmNkdFoundRpt
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Shared Sub New()
		End Sub
		Public Sub New()
			frmNkdFoundRpt.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmNkdFoundRpt.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmNkdFoundRpt.__ENCList.Count = frmNkdFoundRpt.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmNkdFoundRpt.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmNkdFoundRpt.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmNkdFoundRpt.__ENCList(num) = frmNkdFoundRpt.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmNkdFoundRpt.__ENCList.RemoveRange(num, frmNkdFoundRpt.__ENCList.Count - num)
					frmNkdFoundRpt.__ENCList.Capacity = frmNkdFoundRpt.__ENCList.Count
				End If
				frmNkdFoundRpt.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Dim frmActsInvTotal As New frmActsInvTotal()
		Dim frmCurrecyTotalGrd As New frmCurrecyTotalGrd()
		Dim Form1 As New Form1()
		frmActsInvTotal.MdiParent = Form1
		frmActsInvTotal.Show()
		frmCurrecyTotalGrd.Activate()
	End Sub

	Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
		Dim Form1 As New Form1()
		Dim frmNkdTotSalePurch As New frmNkdTotSalePurch()
		frmNkdTotSalePurch.MdiParent = Form1
		frmNkdTotSalePurch.Show()
		frmNkdTotSalePurch.Activate()
	End Sub
End Class
