Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Partial Class frmInvRptType
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        frmInvRptType.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmInvRptType.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmInvRptType.__ENCList.Count = frmInvRptType.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmInvRptType.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmInvRptType.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmInvRptType.__ENCList(num) = frmInvRptType.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmInvRptType.__ENCList.RemoveRange(num, frmInvRptType.__ENCList.Count - num)
                frmInvRptType.__ENCList.Capacity = frmInvRptType.__ENCList.Count
            End If
            frmInvRptType.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
            If flag Then
                Me.conn.Open()
            End If
            Dim value As Integer = 1
            flag = Me.RadioButton2.Checked
            If flag Then
                value = 2
            End If
            Dim sqlCommand As SqlCommand = New SqlCommand("update sett set val=" + Conversions.ToString(value) + " where id=1", Me.conn)
            sqlCommand.ExecuteNonQuery()
            Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
            flag = (Me.conn.State <> ConnectionState.Closed)
            If flag Then
                Me.conn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
