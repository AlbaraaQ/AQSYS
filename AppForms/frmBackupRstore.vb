Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Public Partial Class frmBackupRstore
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Private cmd As SqlCommand
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmBackupRstore_Load
        frmBackupRstore.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.cmd = New SqlCommand()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmBackupRstore.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmBackupRstore.__ENCList.Count = frmBackupRstore.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmBackupRstore.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmBackupRstore.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmBackupRstore.__ENCList(num) = frmBackupRstore.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmBackupRstore.__ENCList.RemoveRange(num, frmBackupRstore.__ENCList.Count - num)
                frmBackupRstore.__ENCList.Capacity = frmBackupRstore.__ENCList.Count
            End If
            frmBackupRstore.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Try
            Me.saveFileDialog1.Filter = "BackUp Files (*.BAK)|*.BAK"
            Me.saveFileDialog1.FileName = "BackUp_" + DateTime.Now.ToString("dd-MM-yyyy") + ""
            Dim flag As Boolean = Me.saveFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.bkuppath.Text = Me.saveFileDialog1.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetCommand(stmt As String)
        Me.cmd.Connection = Me.conn
        Me.cmd.CommandText = stmt
    End Sub

    Public Function RunNunQuary(stmt As String, Message As String) As Boolean
        Dim result As Boolean
        Try
            Me.SetCommand(stmt)
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
            If flag Then
                Me.conn.Open()
            End If
            Me.cmd.ExecuteNonQuery()
            flag = (Operators.CompareString(Message, "", False) <> 0)
            If flag Then
                MessageBox.Show(Message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            result = True
        Catch ex As Exception
            result = False
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
        Return result
    End Function

    Private Sub backup_button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim flag As Boolean = Operators.CompareString(Me.bkuppath.Text, "", False) = 0
            If flag Then
                MessageBox.Show("اختر مسار النسخة الاحتياطية أولاً", "")
                Me.bkuppath.Focus()
            Else
                Me.RunNunQuary(String.Concat(New String() {"backup database [", MainClass.Database, "] To Disk='", Me.bkuppath.Text, "'"}), "تم اخذ النسخة الاحتياطية بنجاح")
                flag = Me.checkBox1.Checked
                If flag Then
                    File.WriteAllText(System.Windows.Forms.Application.StartupPath + "\\bkup.txt", Path.GetDirectoryName(Me.bkuppath.Text), Encoding.[Default])
                Else
                    File.WriteAllText(System.Windows.Forms.Application.StartupPath + "\\bkup.txt", "", Encoding.[Default])
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Try
            Me.openFileDialog1.Filter = "BackUp Files (*.BAK)|*.BAK|(*.BACK)|*.BACK"
            Dim flag As Boolean = Me.openFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.txtRestore.Text = Me.openFileDialog1.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub restore_button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDoRestore.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtRestore.Text, "", False) = 0
            If flag Then
                MessageBox.Show("اختر النسخة الاحتياطية أولاً", "")
                Me.txtRestore.Focus()
            Else
                Dim server As Server = New Server(MainClass.Server)
                Dim database As Database = server.Databases(MainClass.Database)
                flag = (database IsNot Nothing)
                If flag Then
                    server.KillAllProcesses(database.Name)
                End If
                Dim restore As Restore = New Restore()
                restore.Database = database.Name
                restore.Action = RestoreActionType.Database
                restore.Devices.AddDevice(Me.txtRestore.Text, DeviceType.File)
                restore.ReplaceDatabase = True
                restore.NoRecovery = False
                restore.SqlRestore(server)
                MessageBox.Show("تم استرجاع النسخه الاحتياطية بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmBackupRstore_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmBackupRstore.Load
        Dim p As Point = New Point(536, 228)
        Dim Form1 As New Form1()
        Me.Size = CType(p, Size)
        Me.Left = CInt(Math.Round(CDbl(Form1.Width) / 2.0 - CDbl(Me.Width) / 2.0))
        Me.DtbTest.Text = DateTime.Now.ToShortDateString()
        Me.Top = 50
    End Sub

    Private Sub close_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnDoBkUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDoBkUp.Click
    End Sub

    Private Sub TabPage1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage1.Click
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
    End Sub
End Class
