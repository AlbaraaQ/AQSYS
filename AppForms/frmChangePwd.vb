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
Public Partial Class frmChangePwd
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmChangePwd_Load
        frmChangePwd.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmChangePwd.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmChangePwd.__ENCList.Count = frmChangePwd.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmChangePwd.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmChangePwd.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmChangePwd.__ENCList(num) = frmChangePwd.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmChangePwd.__ENCList.RemoveRange(num, frmChangePwd.__ENCList.Count - num)
                frmChangePwd.__ENCList.Capacity = frmChangePwd.__ENCList.Count
            End If
            frmChangePwd.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub frmChangePwd_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmChangePwd.Load
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select username,pwd from users where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.txtUser.Text = dataTable.Rows(0)(0).ToString()
                Me.txtPass.Text = dataTable.Rows(0)(1).ToString()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtPass.Text.Trim(), "", False) = 0
            If flag Then
                MessageBox.Show("ادخل كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtPass.Focus()
            Else
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand("update Users set pwd='" + Me.txtPass.Text + "' where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            Dim text As String = "خطأ أثناء الحفظ"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub
End Class
