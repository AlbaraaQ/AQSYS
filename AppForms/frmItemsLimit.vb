Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Partial Class frmItemsLimit
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Shared Sub New()
    End Sub
    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmItemsLimit_Load
        frmItemsLimit.__ENCAddToList(Me)
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmItemsLimit.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmItemsLimit.__ENCList.Count = frmItemsLimit.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmItemsLimit.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmItemsLimit.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmItemsLimit.__ENCList(num) = frmItemsLimit.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmItemsLimit.__ENCList.RemoveRange(num, frmItemsLimit.__ENCList.Count - num)
                frmItemsLimit.__ENCList.Capacity = frmItemsLimit.__ENCList.Count
            End If
            frmItemsLimit.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub frmItemsLimit_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmItemsLimit.Load
    End Sub
End Class
