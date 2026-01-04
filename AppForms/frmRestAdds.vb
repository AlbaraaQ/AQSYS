Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
	Public Partial Class frmRestAdds
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Shared Sub New()
		End Sub
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRestAdds_Load
			frmRestAdds.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRestAdds.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRestAdds.__ENCList.Count = frmRestAdds.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRestAdds.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRestAdds.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRestAdds.__ENCList(num) = frmRestAdds.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRestAdds.__ENCList.RemoveRange(num, frmRestAdds.__ENCList.Count - num)
					frmRestAdds.__ENCList.Capacity = frmRestAdds.__ENCList.Count
				End If
				frmRestAdds.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmRestAdds_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmRestAdds.Load
			Me.txtAdds.Focus()
		End Sub

  Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
			Me.Close()
		End Sub
	End Class
