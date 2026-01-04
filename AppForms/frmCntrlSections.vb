Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Public Partial Class frmCntrlSections
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCntrlSections_Load
        frmCntrlSections.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCntrlSections.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCntrlSections.__ENCList.Count = frmCntrlSections.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCntrlSections.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCntrlSections.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCntrlSections.__ENCList(num) = frmCntrlSections.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCntrlSections.__ENCList.RemoveRange(num, frmCntrlSections.__ENCList.Count - num)
                frmCntrlSections.__ENCList.Capacity = frmCntrlSections.__ENCList.Count
            End If
            frmCntrlSections.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub txtPWD_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPWD.KeyDown
        Try
            Dim flag As Boolean = e.KeyCode <> Keys.[Return]
            If Not flag Then
                flag = (Operators.CompareString(Me.txtPWD.Text.Trim(), "", False) = 0)
                If flag Then
                    Interaction.MsgBox("ادخل كلمة المرور", MsgBoxStyle.OkOnly, Nothing)
                    Me.txtPWD.Focus()
                Else
                    flag = (Operators.CompareString(Me.txtPWD.Text, "abshir2022", False) = 0)
                    If flag Then
                        Me.Panel2.Visible = True
                    Else
                        Interaction.MsgBox("خطأ في كلمة المرور", MsgBoxStyle.OkOnly, Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
            If flag Then
                Me.conn.Open()
            End If
            Dim value As Integer = 0
            Dim value2 As Integer = 0
            Dim value3 As Integer = 0
            Dim value4 As Integer = 0
            flag = Me.chkManfc.Checked
            If flag Then
                value = 1
            End If
            flag = Me.chkCostCenter.Checked
            If flag Then
                value2 = 1
            End If
            flag = Me.chkRetention.Checked
            If flag Then
                value3 = 1
            End If
            flag = Me.chkYearClose.Checked
            If flag Then
                value4 = 1
            End If
            Dim value5 As Integer = 0
            flag = Me.chkEditCompName.Checked
            If flag Then
                value5 = 1
            End If
            Dim value6 As Integer = 0
            flag = Me.chkActiveZakat.Checked
            If flag Then
                value6 = 1
            End If
            Dim text As String = ""
            flag = Me.chkOpenExpire.Checked
            If flag Then
                text = MainClass.Encrypt("open", MainClass._enckey)
            End If
            Dim value7 As Integer = 0
            flag = Me.chkAmmand.Checked
            If flag Then
                value7 = 1
            End If
            Dim value8 As String = MainClass.Encrypt(Me.txtExpireDate.Value.ToString("dd/MM/yyyy"), MainClass._enckey)
            Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"update foundation set hide_manfc=", Conversions.ToString(value), ",hide_costcenter=", Conversions.ToString(value2), ",hide_retention=", Conversions.ToString(value3), ",hide_yearclose=", Conversions.ToString(value4), ",edit_compname=", Conversions.ToString(value5), ",date_exp=@date_exp ,is_zakat=", Conversions.ToString(value6), ",open_expire='", text, "',is_ammand=", Conversions.ToString(value7), " where id=1"}), Me.conn)
            sqlCommand.Parameters.Add("@date_exp", SqlDbType.NVarChar).Value = value8
            sqlCommand.ExecuteNonQuery()
            Try
                Dim str As String = ""
                Try
                    flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
                    If flag Then
                        str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
                    End If
                Catch ex As Exception
                End Try
                Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
                flag = (registryKey Is Nothing)
                If flag Then
                    registryKey = Registry.LocalMachine.CreateSubKey("Software\ExchangeVB" + str)
                End If
                flag = (registryKey IsNot Nothing)
                If flag Then
                    registryKey.SetValue("Expire", value8)
                    flag = Not Me.chkOpenExpire.Checked
                    If flag Then
                        Form1.lblExpireDiff.Caption = "متبقي " + Conversions.ToString(MainClass.GetExpireDaysDiff()) + " يوم على انتهاء الترخيص"
                    End If
                End If
            Catch ex2 As Exception
            End Try
            flag = Me.chkOpenExpire.Checked
            If flag Then
                Form1.lblExpireDiff.Caption = ""
            End If
            Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
        Catch ex3 As Exception
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub frmCntrlSections_Load(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from foundation where id=1", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.chkManfc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_manfc")))
                Me.chkCostCenter.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_costcenter")))
                Me.chkRetention.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_retention")))
                Try
                    Me.chkYearClose.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_yearclose")))
                Catch ex As Exception
                End Try
                Try
                    Me.chkEditCompName.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_compname")))
                Catch ex2 As Exception
                End Try
                Try
                    Me.chkActiveZakat.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_zakat")))
                Catch ex3 As Exception
                End Try
                Try
                    flag = (Operators.CompareString(MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("open_expire"))), MainClass._enckey), "open", False) = 0)
                    If flag Then
                        Me.chkOpenExpire.Checked = True
                    End If
                Catch ex4 As Exception
                End Try
                Try
                    Me.chkAmmand.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_ammand")))
                Catch ex5 As Exception
                End Try
            End If
        Catch ex6 As Exception
        End Try
        Try
            Dim flag2 As Boolean = False
            Dim flag As Boolean
            Try
                Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB", True)
                flag = (registryKey.GetValue("Expire") IsNot Nothing)
                If flag Then
                    Dim value As DateTime = DateTime.ParseExact(MainClass.Decrypt(Conversions.ToString(registryKey.GetValue("Expire")), MainClass._enckey), "dd/MM/yyyy", Nothing)
                    Me.txtExpireDate.Value = value
                    flag2 = True
                End If
            Catch ex7 As Exception
            End Try
            flag = Not flag2
            If flag Then
                Try
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select date_exp from foundation where id=1", Me.conn)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)), "", False)
                    If flag Then
                        Dim value2 As DateTime = DateTime.ParseExact(MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0))), MainClass._enckey), "dd/MM/yyyy", Nothing)
                        Me.txtExpireDate.Value = value2
                        flag2 = True
                    End If
                Catch ex8 As Exception
                End Try
            End If
            flag = Not flag2
            If flag Then
                Me.txtExpireDate.Value = DateTime.Now.AddYears(1)
            End If
        Catch ex9 As Exception
        End Try
    End Sub
End Class
