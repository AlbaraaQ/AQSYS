Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
	Public Partial Class frmRptViewer
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Shared Sub New()
		End Sub
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRptViewer_Load
			frmRptViewer.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptViewer.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptViewer.__ENCList.Count = frmRptViewer.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptViewer.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptViewer.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptViewer.__ENCList(num) = frmRptViewer.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptViewer.__ENCList.RemoveRange(num, frmRptViewer.__ENCList.Count - num)
					frmRptViewer.__ENCList.Capacity = frmRptViewer.__ENCList.Count
				End If
				frmRptViewer.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmRptViewer_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmRptViewer.Load
		End Sub
	End Class
