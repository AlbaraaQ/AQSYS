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
Partial Public Class frmClientsSMSAlarm
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private _Finished As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmRptClientsMaint_Load
        frmClientsSMSAlarm.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._Finished = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmClientsSMSAlarm.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmClientsSMSAlarm.__ENCList.Count = frmClientsSMSAlarm.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmClientsSMSAlarm.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmClientsSMSAlarm.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmClientsSMSAlarm.__ENCList(num) = frmClientsSMSAlarm.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmClientsSMSAlarm.__ENCList.RemoveRange(num, frmClientsSMSAlarm.__ENCList.Count - num)
                frmClientsSMSAlarm.__ENCList.Capacity = frmClientsSMSAlarm.__ENCList.Count
            End If
            frmClientsSMSAlarm.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub frmRptClientsMaint_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmRptClientsMaint.Load
        Dim flag As Boolean = False
        Dim flag3 As Boolean
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Users where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag2 As Boolean = dataTable.Rows.Count > 0
            If flag2 Then
                flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_tel")))
                If flag3 Then
                    flag = True
                End If
            End If
        Catch ex As Exception
        End Try
        flag3 = flag
        If flag3 Then
            Me.dgvData.Columns(3).Visible = False
        End If
    End Sub

    Private Function GetLastSMSSentDate(_cust As Integer) As String
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select top 1 date from sms_hist where cust=" + Conversions.ToString(_cust) + " order by date desc", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Return Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))).ToShortDateString()
            End If
        Catch ex As Exception
        End Try
        Return ""
    End Function

    Private Function GetCityName(_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from cities where id=" + Conversions.ToString(_id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
            If flag2 Then
                result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            Else
                result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
            End If
        Else
            result = ""
        End If
        Return result
    End Function

    Private Function GetAreaName(_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from areas where id=" + Conversions.ToString(_id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
            If flag2 Then
                result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            Else
                result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
            End If
        Else
            result = ""
        End If
        Return result
    End Function

    Private Sub ShowResult()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim str As String = ""
            Me.dgvData.Rows.Clear()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from customers where " + str + " type=1 and is_deleted=0 order by id", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = dataTable.Rows.Count
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Dim t As DateTime = Nothing
                Dim flag As Boolean
                Try
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_deleted=0 and cust_id=", dataTable.Rows(num3)("id")), " order by date")), Me.conn)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag = (dataTable2.Rows.Count > 0)
                    If flag Then
                        t = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
                    End If
                Catch ex As Exception
                End Try
                Dim t2 As DateTime = Nothing
                Try
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_maint=1 and is_deleted=0 and cust_id=", dataTable.Rows(num3)("id")), " order by date desc")), Me.conn)
                    Dim dataTable3 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable3)
                    flag = (dataTable3.Rows.Count > 0)
                    If flag Then
                        t2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
                    End If
                Catch ex2 As Exception
                End Try
                Dim flag2 As Boolean = True
                Dim flag3 As Boolean = True
                flag = (DateTime.Compare(t, DateTime.MinValue) <> 0)
                Dim flag4 As Boolean
                If flag Then
                    flag4 = (DateTime.Compare(t, DateTime.Now.AddMonths(-4)) >= 0)
                    If flag4 Then
                        flag2 = False
                    End If
                End If
                flag4 = (DateTime.Compare(t2, DateTime.MinValue) <> 0)
                If flag4 Then
                    flag = (DateTime.Compare(t2, DateTime.Now.AddMonths(-4)) >= 0)
                    If flag Then
                        flag3 = False
                    End If
                End If
                flag4 = (flag2 AndAlso flag3)
                If flag4 Then
                    Me.dgvData.Rows.Add()
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("cust_no"))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
                    Dim text As String = ""
                    flag4 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("tel")), "", False)
                    If flag4 Then
                        text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("tel")))
                    End If
                    flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "", False) = 0, Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("mobile")), "", False)))
                    If flag4 Then
                        text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("mobile")))
                    End If
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(3).Value = text
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(4).Value = Me.GetCityName(Conversions.ToInteger(dataTable.Rows(num3)("city")))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(5).Value = Me.GetAreaName(Conversions.ToInteger(dataTable.Rows(num3)("area")))
                    Try
                        Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(6).Value = Me.GetLastSMSSentDate(Conversions.ToInteger(dataTable.Rows(num3)("id")))
                    Catch ex3 As Exception
                    End Try
                End If
                Me.ProgressBar1.Value = num3 + 1
                num3 += 1
            End While
            Me.lblCount.Text = "عدد النتائج: " + Conversions.ToString(Me.dgvData.Rows.Count)
        Catch ex4 As Exception
        Finally
            Me._Finished = True
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.dgvData.ScrollBars = ScrollBars.None
        'Dim thread As Thread = AddressOf Me.ShowResult
        Dim thread As New Thread(AddressOf Me.ShowResult)
        thread.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim finished As Boolean = Me._Finished
        If finished Then
            Me._Finished = False
            Me.dgvData.ScrollBars = ScrollBars.Both
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.dgvData.Rows.Count = 0
            If flag Then
                Interaction.MsgBox("جدول العملاء فارغ، اضغط زر عرض أولاً", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim text As String = ""
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select msg from sms_msgs where assign_to=3 and is_deleted=0 and is_default=1", Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
                End If
                flag = (Operators.CompareString(text, "", False) = 0)
                If flag Then
                    Interaction.MsgBox("يجب ادخال رسالة التذكير أولا من شاشة إعداد رسائل الجوال", MsgBoxStyle.OkOnly, Nothing)
                Else
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    Dim num As Integer = 0
                    Dim num2 As Integer = 0
                    Dim num3 As Integer = Me.dgvData.Rows.Count - 1
                    Dim num4 As Integer = num2
                    While True
                        Dim num5 As Integer = num4
                        Dim num6 As Integer = num3
                        If num5 > num6 Then
                            Exit While
                        End If
                        flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", Me.dgvData.Rows(num4).Cells(3).Value), "", False)
                        If flag Then
                            Dim text2 As String = ""
                            flag = (Form1.SMS_CompType = 1)
                            If flag Then
                                text2 = Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Conversions.ToString(Operators.ConcatenateObject("", Me.dgvData.Rows(num4).Cells(3).Value)))
                            Else
                                flag = (Form1.SMS_CompType = 2)
                                If flag Then
                                    text2 = Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Conversions.ToString(Operators.ConcatenateObject("", Me.dgvData.Rows(num4).Cells(3).Value)))
                                Else
                                    flag = (Form1.SMS_CompType = 3)
                                    If flag Then
                                        text2 = Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text, Form1.SMSSender, Conversions.ToString(Operators.ConcatenateObject("", Me.dgvData.Rows(num4).Cells(3).Value)))
                                    End If
                                End If
                            End If
                            flag = ((Form1.SMS_CompType = 1 And Operators.CompareString(text2, "1", False) = 0) Or (Form1.SMS_CompType = 2 And text2.ToLower().Contains("success")) Or (Form1.SMS_CompType = 3 And (text2.ToLower().Contains("200") Or text2.ToLower().Contains("ok") Or text2.ToLower().Contains("success"))))
                            If flag Then
                                num += 1
                                Me.lblStatus.Text = "تم الإرسال إلى عدد " + Conversions.ToString(num) + " عملاء"
                                Try
                                    Dim sqlCommand As SqlCommand = New SqlCommand("insert into sms_hist(date,cust)values(@date,@cust)", Me.conn)
                                    sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                                    sqlCommand.Parameters.Add("@cust", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num4).Cells(0).Value)
                                    sqlCommand.ExecuteNonQuery()
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                        num4 += 1
                    End While
                End If
            End If
        Catch ex2 As Exception
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvData_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles dgvData.RowsRemoved
        Try
            Me.lblCount.Text = "عدد النتائج: " + Conversions.ToString(Me.dgvData.Rows.Count)
        Catch ex As Exception
        End Try
    End Sub
End Class
