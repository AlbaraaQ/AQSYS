Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.[Shared]
Imports CrystalDecisions.Windows.Forms
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
Imports AQSYS.AQSYS.rptt
Imports System.Windows.Forms
Partial Public Class frmClientsSendSms
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Private _Finished As Boolean

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmRptClientsMaint_Load
        frmClientsSendSms.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._Finished = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmClientsSendSms.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmClientsSendSms.__ENCList.Count = frmClientsSendSms.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmClientsSendSms.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmClientsSendSms.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmClientsSendSms.__ENCList(num) = frmClientsSendSms.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmClientsSendSms.__ENCList.RemoveRange(num, frmClientsSendSms.__ENCList.Count - num)
                frmClientsSendSms.__ENCList.Capacity = frmClientsSendSms.__ENCList.Count
            End If
            frmClientsSendSms.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Public Sub LoadCities(country As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Cities where country=" + Conversions.ToString(country) + " order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCity.DataSource = dataTable
        Me.cmbCity.DisplayMember = "name"
        Me.cmbCity.ValueMember = "id"
        Me.cmbCity.SelectedIndex = -1
    End Sub

    Public Sub LoadAreas(city As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from areas where city=" + Conversions.ToString(city) + " order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbArea.DataSource = dataTable
        Me.cmbArea.DisplayMember = "name"
        Me.cmbArea.ValueMember = "id"
        Me.cmbArea.SelectedIndex = -1
    End Sub

    Private Sub frmRptClientsMaint_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmRptClientsMaint.Load
        Try
            Dim txtDateFrom As DateTimePicker = Me.txtDateFrom
            Dim now As DateTime = DateTime.Now
            Dim now2 As DateTime = New DateTime(now.Year, 1, 1)
            txtDateFrom.Value = now2
            Me.txtDateTo.Value = DateTime.Now
            Dim txtMaintFromDate As DateTimePicker = Me.txtMaintFromDate
            now2 = DateTime.Now
            now = New DateTime(now2.Year, 1, 1)
            txtMaintFromDate.Value = now
            Me.txtMaintToDate.Value = DateTime.Now
            Me.LoadCities(1)
        Catch ex As Exception
        End Try
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
        Catch ex2 As Exception
        End Try
        flag3 = flag
        If flag3 Then
            Me.dgvData.Columns(3).Visible = False
        End If
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCity.SelectedIndexChanged
        Try
            Me.LoadAreas(Conversions.ToInteger(Me.cmbCity.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAllCities_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllCities.CheckedChanged
        Dim checked As Boolean = Me.chkAllCities.Checked
        If checked Then
            Me.cmbCity.Enabled = False
        Else
            Me.cmbCity.Enabled = True
        End If
    End Sub

    Private Sub chkAllAreas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllAreas.CheckedChanged
        Dim checked As Boolean = Me.chkAllAreas.Checked
        If checked Then
            Me.cmbArea.Enabled = False
        Else
            Me.cmbArea.Enabled = True
        End If
    End Sub

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
            Dim text As String = ""
            Dim flag As Boolean = Not Me.chkAllCities.Checked And Me.cmbCity.SelectedValue IsNot Nothing
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" city=", Me.cmbCity.SelectedValue), " and ")))
            End If
            flag = (Not Me.chkAllAreas.Checked And Me.cmbArea.SelectedValue IsNot Nothing)
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" area=", Me.cmbArea.SelectedValue), " and ")))
            End If
            Dim str As String = " and "
            flag = (Me.chkJoinDate.Checked And Me.chkMaintDate.Checked And Not Me.chkBothCond.Checked)
            If flag Then
                str = " or "
            End If
            flag = (Me.chkJoinDate.Checked And Me.chkMaintDate.Checked)
            If flag Then
                text += " ( "
            End If
            flag = Me.chkJoinDate.Checked
            If flag Then
                text = text + " ( (join_date>=@date1 and join_date<@date2) or (id in (select cust_id from inv where is_deleted=0 group by cust_id having min(date)>=@date1 and min(date)<@date2 )) ) " + str
            End If
            flag = Me.chkMaintDate.Checked
            If flag Then
                text += " ( ((maint_date>=@date3 and maint_date<@date4) or (maint_date is null and id not in (select cust_id from inv where is_maint=1 and is_deleted=0))) or (id in (select cust_id from inv where is_maint=1 and is_deleted=0 group by cust_id having max(date)>=@date3 and max(date)<@date4 )) ) "
            End If
            flag = (Me.chkJoinDate.Checked And Me.chkMaintDate.Checked)
            If flag Then
                text += " ) and "
            Else
                flag = Me.chkMaintDate.Checked
                If flag Then
                    text += " and "
                End If
            End If
            Me.dgvData.Rows.Clear()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from customers where " + text + " type=1 and is_deleted=0 order by id", Me.conn)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
            sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
            sqlDataAdapter.SelectCommand.Parameters.Add("@date3", SqlDbType.DateTime).Value = Me.txtMaintFromDate.Value.ToShortDateString()
            sqlDataAdapter.SelectCommand.Parameters.Add("@date4", SqlDbType.DateTime).Value = Me.txtMaintToDate.Value.AddDays(1.0).ToShortDateString()
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
                Dim flag2 As Boolean = True
                Dim text2 As String = ""
                Try
                    flag = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("join_date")), "", False)
                    If flag Then
                        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_deleted=0 and cust_id=", dataTable.Rows(num3)("id")), " order by date")), Me.conn)
                        Dim dataTable2 As DataTable = New DataTable()
                        sqlDataAdapter2.Fill(dataTable2)
                        flag = (dataTable2.Rows.Count > 0)
                        If flag Then
                            text2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))).ToShortDateString()
                            flag = Me.chkJoinDate.Checked
                            If flag Then
                                flag2 = False
                                flag = (DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))), Convert.ToDateTime(Me.txtDateFrom.Value.ToShortDateString())) >= 0 And DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))), Convert.ToDateTime(Me.txtDateTo.Value.ToShortDateString()).AddDays(1.0)) < 0)
                                If flag Then
                                    flag2 = True
                                End If
                            End If
                        End If
                    Else
                        text2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("join_date"))).ToShortDateString()
                        flag = Me.chkJoinDate.Checked
                        If flag Then
                            flag2 = False
                            flag = (DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("join_date"))), Convert.ToDateTime(Me.txtDateFrom.Value.ToShortDateString())) >= 0 And DateTime.Compare(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("join_date"))), Convert.ToDateTime(Me.txtDateTo.Value.ToShortDateString()).AddDays(1.0)) < 0)
                            If flag Then
                                flag2 = True
                            End If
                        End If
                    End If
                Catch ex As Exception
                End Try
                Dim flag3 As Boolean = True
                Dim t As DateTime = Nothing
                Try
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_maint=1 and is_deleted=0 and cust_id=", dataTable.Rows(num3)("id")), " order by date desc")), Me.conn)
                    Dim dataTable3 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable3)
                    flag = (dataTable3.Rows.Count > 0)
                    If flag Then
                        t = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
                    Else
                        t = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("maint_date")))
                    End If
                Catch ex2 As Exception
                End Try
                Try
                    flag = (Me.chkMaintDate.Checked And DateTime.Compare(t, Convert.ToDateTime(Me.txtMaintFromDate.Value.ToShortDateString())) >= 0 And DateTime.Compare(t, Convert.ToDateTime(Me.txtMaintToDate.Value.AddDays(1.0).ToShortDateString())) < 0)
                    If flag Then
                        flag3 = True
                    Else
                        flag = (Me.chkMaintDate.Checked And DateTime.Compare(t, DateTime.MinValue) <> 0)
                        If flag Then
                            flag3 = False
                        End If
                    End If
                Catch ex3 As Exception
                End Try
                flag = (Operators.CompareString(text2, "", False) = 0 And Me.chkJoinDate.Checked)
                If flag Then
                    flag2 = False
                End If
                Dim flag4 As Boolean = False
                flag = (Me.chkJoinDate.Checked And Me.chkMaintDate.Checked)
                Dim flag5 As Boolean
                If flag Then
                    Dim checked As Boolean = Me.chkBothCond.Checked
                    If checked Then
                        flag5 = (flag2 AndAlso flag3)
                        If flag5 Then
                            flag4 = True
                        End If
                    Else
                        flag5 = (flag2 OrElse flag3)
                        If flag5 Then
                            flag4 = True
                        End If
                    End If
                End If
                flag5 = (flag4 Or ((flag2 Or Not Me.chkJoinDate.Checked) And (flag3 Or Not Me.chkMaintDate.Checked)))
                If flag5 Then
                    Me.dgvData.Rows.Add()
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("cust_no"))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
                    Dim text3 As String = ""
                    flag5 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("tel")), "", False)
                    If flag5 Then
                        text3 = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("tel")))
                    End If
                    flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text3, "", False) = 0, Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("mobile")), "", False)))
                    If flag5 Then
                        text3 = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("mobile")))
                    End If
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(3).Value = text3
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(4).Value = Me.GetCityName(Conversions.ToInteger(dataTable.Rows(num3)("city")))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(5).Value = Me.GetAreaName(Conversions.ToInteger(dataTable.Rows(num3)("area")))
                    Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(6).Value = text2
                    flag5 = (DateTime.Compare(t, DateTime.MinValue) <> 0)
                    If flag5 Then
                        Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(7).Value = t.ToShortDateString()
                    Else
                        Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(7).Value = ""
                    End If
                    Try
                        Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(8).Value = Me.GetLastSMSSentDate(Conversions.ToInteger(dataTable.Rows(num3)("id")))
                    Catch ex4 As Exception
                    End Try
                End If
                Me.ProgressBar1.Value = num3 + 1
                num3 += 1
            End While
            Me.lblCount.Text = "عدد النتائج: " + Conversions.ToString(Me.dgvData.Rows.Count)
        Catch ex5 As Exception
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

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.dgvData.Rows.Count = 0
            If flag Then
                Interaction.MsgBox("جدول العملاء فارغ، اضغط زر عرض أولاً", MsgBoxStyle.OkOnly, Nothing)
            Else
                Dim text As String = ""
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select msg from sms_msgs where assign_to=1 and is_deleted=0 and is_default=1", Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
                End If
                flag = (Operators.CompareString(text, "", False) = 0)
                If flag Then
                    Interaction.MsgBox("يجب ادخال رسالة العملاء أولا من شاشة إعداد رسائل الجوال", MsgBoxStyle.OkOnly, Nothing)
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
                            Me.lblStatus.Text = text2
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
            Me.lblStatus.Text = ex2.Message
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvData_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvData.DataError
    End Sub

    Private Sub dgvData_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles dgvData.RowsRemoved
        Try
            Me.lblCount.Text = "عدد النتائج: " + Conversions.ToString(Me.dgvData.Rows.Count)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvData.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("id")
            dataTable.Columns.Add("name")
            flag = Me.dgvData.Columns(3).Visible
            If flag Then
                dataTable.Columns.Add("mobile")
            End If
            dataTable.Columns.Add("city")
            dataTable.Columns.Add("area")
            dataTable.Columns.Add("date")
            dataTable.Columns.Add("date2")
            dataTable.Columns.Add("DataColumn1")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvData.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                flag = Me.dgvData.Columns(3).Visible
                If flag Then
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(8).Value)})
                Else
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(8).Value)})
                End If
                num3 += 1
            End While
            Dim rptClientSMS As rptClientSMS = New rptClientSMS()
            rptClientSMS.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("from_date"), TextObject)
            Dim textObject2 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("to_date"), TextObject)
            flag = Me.chkJoinDate.Checked
            If flag Then
                textObject.Text = Me.txtDateFrom.Value.ToShortDateString()
                textObject2.Text = Me.txtDateTo.Value.ToShortDateString()
            Else
                textObject.Text = "الكل"
                textObject2.Text = "الكل"
            End If
            Dim textObject3 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("maint_from_date"), TextObject)
            Dim textObject4 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("maint_to_date"), TextObject)
            flag = Me.chkMaintDate.Checked
            If flag Then
                textObject3.Text = Me.txtMaintFromDate.Value.ToShortDateString()
                textObject4.Text = Me.txtMaintToDate.Value.ToShortDateString()
            Else
                textObject3.Text = "الكل"
                textObject4.Text = "الكل"
            End If
            Dim text As String = "الكل"
            flag = (Not Me.chkAllCities.Checked And Me.cmbCity.SelectedValue IsNot Nothing)
            If flag Then
                text = Me.cmbCity.Text
            End If
            Dim textObject5 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("city"), TextObject)
            textObject5.Text = text
            Dim text2 As String = "الكل"
            flag = (Not Me.chkAllAreas.Checked And Me.cmbArea.SelectedValue IsNot Nothing)
            If flag Then
                text2 = Me.cmbArea.Text
            End If
            Dim textObject6 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(1).ReportObjects("area"), TextObject)
            textObject6.Text = text2
            flag = Not Me.dgvData.Columns(3).Visible
            If flag Then
                Dim lineObject As LineObject = CType(rptClientSMS.ReportDefinition.Sections(2).ReportObjects("Line2"), LineObject)
                lineObject.LineStyle = LineStyle.NoLine
                Dim fieldObject As FieldObject = CType(rptClientSMS.ReportDefinition.Sections(3).ReportObjects("name1"), FieldObject)
                fieldObject.Left = 6400
                fieldObject.Width = 3780
                Dim textObject7 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(2).ReportObjects("lblname"), TextObject)
                textObject7.Left = 6400
                textObject7.Width = 3780
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptClientSMS.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject8 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject9 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject10 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject11 As TextObject = CType(rptClientSMS.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptClientSMS
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptClientSMS.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(2)
    End Sub
End Class
