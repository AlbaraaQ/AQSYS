Imports CrystalDecisions.CrystalReports.Engine
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
Imports System.Windows.Forms
Imports AQSYS.AQSYS.rptt
Imports AQSYS.My
Public Partial Class frmCurrencyDetails
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private _Finished As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCurrencyDetails_Load
        frmCurrencyDetails.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._Finished = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCurrencyDetails.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCurrencyDetails.__ENCList.Count = frmCurrencyDetails.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCurrencyDetails.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCurrencyDetails.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCurrencyDetails.__ENCList(num) = frmCurrencyDetails.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCurrencyDetails.__ENCList.RemoveRange(num, frmCurrencyDetails.__ENCList.Count - num)
                frmCurrencyDetails.__ENCList.Capacity = frmCurrencyDetails.__ENCList.Count
            End If
            frmCurrencyDetails.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Public Sub LoadSafes()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where status=1 and IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbSafes.DataSource = dataTable
        Me.cmbSafes.DisplayMember = "name"
        Me.cmbSafes.ValueMember = "id"
        Me.cmbSafes.SelectedIndex = -1
    End Sub

    Public Sub LoadCurrencies()
        Dim text As String = ""
        Dim flag As Boolean = Me.chkType1.Checked
        If flag Then
            text += " (type=1 or type is null "
        End If
        flag = Me.chkType2.Checked
        Dim flag2 As Boolean
        If flag Then
            flag2 = (Operators.CompareString(text, "", False) <> 0)
            If flag2 Then
                text += " or type=2 "
            Else
                text += " (type=2 "
            End If
        End If
        flag2 = Me.chkType3.Checked
        If flag2 Then
            flag = (Operators.CompareString(text, "", False) <> 0)
            If flag Then
                text += " or type=3 "
            Else
                text += " (type=3 "
            End If
        End If
        flag2 = (Operators.CompareString(text, "", False) <> 0)
        If flag2 Then
            text += ") and "
        End If
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from Currencies where " + text + " IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCurrency.DataSource = dataTable
        Me.cmbCurrency.DisplayMember = "symbol"
        Me.cmbCurrency.ValueMember = "id"
        Me.cmbCurrency.SelectedIndex = -1
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbSafes.Enabled = False
        Else
            Me.cmbSafes.Enabled = True
        End If
    End Sub

    Private Sub frmCurrencyDetails_Load(ByVal sender As Object, ByVal e As EventArgs)
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            Dim flag As Boolean = MainClass.hide_manfc
            If flag Then
                Me.pnlItemType.Visible = False
            End If
        Catch ex As Exception
        End Try
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadSafes()
        Me.LoadCurrencies()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select actv_manfc from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Try
                    Dim flag2 As Boolean = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_manfc")))
                    If flag2 Then
                        Me.pnlItemType.Visible = False
                    End If
                Catch ex2 As Exception
                End Try
            End If
        Catch ex3 As Exception
        End Try
    End Sub

    Private Sub txtCurrencyNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrencyNo.TextChanged
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtCurrencyNo.Text.Trim(), "", False) = 0
            If Not flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id from currencies where is_deleted=0 and (id=", Me.txtCurrencyNo.Text, " or operate_no='", Me.txtCurrencyNo.Text, "')"}), Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
        Try
            Dim flag As Boolean = Not Me.txtCurrencyNo.Focus()
            If flag Then
                Me.txtCurrencyNo.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.cmbCurrency.SelectedValue))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function GetsafeName(Safe_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Safes where id=" + Conversions.ToString(Safe_id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            result = dataTable.Rows(0)(0).ToString()
        Else
            result = ""
        End If
        Return result
    End Function

    Private Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("currency")
            dataTable.Columns.Add("sum")
            dataTable.Columns.Add("type")
            dataTable.Columns.Add("invtype")
            Dim text As String = ""
            Dim text2 As String = ""
            Dim text3 As String = ""
            Dim text4 As String = ""
            Dim selectCommandText As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select id,symbol from Currencies where id=", Me.cmbCurrency.SelectedValue), " order by id"))
            Dim flag As Boolean = Not Me.chkAll.Checked
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" Inv.safe=", Me.cmbSafes.SelectedValue), " and ")))
                text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" safe=", Me.cmbSafes.SelectedValue), " and ")))
                text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" safe_to=", Me.cmbSafes.SelectedValue), " and ")))
                text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" safe_from=", Me.cmbSafes.SelectedValue), " and ")))
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim text5 As String = ""
            flag = (MainClass.BranchNo <> -1)
            If flag Then
                text5 = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Me.dgvItems.Rows.Clear()
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable2.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_hold=0 or is_hold is null) and (is_manfc=0 or is_manfc is null) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dateTime As DateTime = Convert.ToDateTime(Me.txtDateTo.Value.AddHours(24.0).ToShortDateString())
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num6 As Integer = 0
                Dim num7 As Integer = dataTable3.Rows.Count - 1
                Dim num8 As Integer = num6
                While True
                    Dim num9 As Integer = num8
                    num5 = num7
                    If num9 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "مخزون أول المدة"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num8)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)("date"))).ToShortDateString()).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num8 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_manfc=1) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num10 As Integer = 0
                Dim num11 As Integer = dataTable3.Rows.Count - 1
                Dim num12 As Integer = num10
                While True
                    Dim num13 As Integer = num12
                    num5 = num11
                    If num13 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "إنتاج"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num12)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)("date"))).ToShortDateString()).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num12 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_hold=0 or is_hold is null) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num14 As Integer = 0
                Dim num15 As Integer = dataTable3.Rows.Count - 1
                Dim num16 As Integer = num14
                While True
                    Dim num17 As Integer = num16
                    num5 = num15
                    If num17 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "فاتورة مشتريات"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num16)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num16 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_hold=0 or is_hold is null) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num18 As Integer = 0
                Dim num19 As Integer = dataTable3.Rows.Count - 1
                Dim num20 As Integer = num18
                While True
                    Dim num21 As Integer = num20
                    num5 = num19
                    If num21 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "فاتورة مرتد مشتريات"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num20)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num20 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_hold=0 or is_hold is null) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num22 As Integer = 0
                Dim num23 As Integer = dataTable3.Rows.Count - 1
                Dim num24 As Integer = num22
                While True
                    Dim num25 As Integer = num24
                    num5 = num23
                    If num25 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "فاتورة مبيعات"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num24)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num24 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date,inv.safe,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total from inv,inv_sub where " + text5 + text + " (is_hold=0 or is_hold is null) and inv.date>=@date1 and inv.date<=@date2 and Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num26 As Integer = 0
                Dim num27 As Integer = dataTable3.Rows.Count - 1
                Dim num28 As Integer = num26
                While True
                    Dim num29 As Integer = num28
                    num5 = num27
                    If num29 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "فاتورة مرتد مبيعات"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num28)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)("exchange_price"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)("total"))
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num28 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select no,date,safe,difftot from tsweya,tsweya_sub where " + text2 + " tsweya.id=tsweya_sub.tsweya_id and date>=@date1 and date<=@date2 and IS_Deleted=0 and item=", dataTable2.Rows(num3)("id"))), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Dim num30 As Integer = 0
                Dim num31 As Integer = dataTable3.Rows.Count - 1
                Dim num32 As Integer = num30
                While True
                    Dim num33 As Integer = num32
                    num5 = num31
                    If num33 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "تسوية"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num32)("safe")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num32)("no"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num32)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num32)("difftot"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = ""
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = ""
                    num32 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,date,safe_to,currency,value from SafesTransfer,SafesTransfer_Sub where " + text3 + " SafesTransfer.id=SafesTransfer_Sub.transfer_id  and date>=@date1 and date<=@date2 and IS_Deleted=0 and currency=", dataTable2.Rows(num3)("id"))), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num34 As Integer = 0
                Dim num35 As Integer = dataTable3.Rows.Count - 1
                Dim num36 As Integer = num34
                While True
                    Dim num37 As Integer = num36
                    num5 = num35
                    If num37 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "محول إليه"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num36)("safe_to")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num36)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num36)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num36)("value"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = ""
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = ""
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num36 += 1
                End While
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,date,safe_from,currency,value from SafesTransfer,SafesTransfer_Sub where " + text4 + " SafesTransfer.id=SafesTransfer_Sub.transfer_id  and date>=@date1 and date<=@date2 and IS_Deleted=0 and currency=", dataTable2.Rows(num3)("id"))), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                Dim num38 As Integer = 0
                Dim num39 As Integer = dataTable3.Rows.Count - 1
                Dim num40 As Integer = num38
                While True
                    Dim num41 As Integer = num40
                    num5 = num39
                    If num41 > num5 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "محول منه"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Conversions.ToInteger(dataTable3.Rows(num40)("safe_from")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num40)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num40)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num40)("value"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = ""
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = ""
                    Dim progressBar As ProgressBar = Me.ProgressBar1
                    progressBar.Value += 1
                    num40 += 1
                End While
                Dim num42 As Integer = 2
                Try
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select consume_type from foundation where id=1", Me.conn)
                    Dim dataTable4 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))) = 1)
                    If flag Then
                        num42 = 1
                    End If
                Catch ex As Exception
                End Try
                flag = (num42 = 1)
                If flag Then
                    sqlDataAdapter2 = New SqlDataAdapter(String.Concat(New String() {"select inv.id,inv.date,inv.safe,currency_from,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total,item_comp.mat_quantot  from inv,inv_sub,item_comp where ", text5, text, " inv.date>=@date1 and inv.date<=@date2 and is_buy=0 and inv.proc_type=1 and  inv.proc_id=inv_sub.proc_id and item_comp.item_id=inv_sub.currency_from and IS_Deleted=0  and item_comp.mat_id=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id")))}), Me.conn)
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    Me.ProgressBar1.Value = 0
                    Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                    Dim num43 As Integer = 0
                    Dim num44 As Integer = dataTable3.Rows.Count - 1
                    Dim num45 As Integer = num43
                    While True
                        Dim num46 As Integer = num45
                        num5 = num44
                        If num46 > num5 Then
                            Exit While
                        End If
                        Dim num47 As Double = 0.0
                        Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select is_deleted from currencies where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), Me.conn)
                        Dim dataTable5 As DataTable = New DataTable()
                        sqlDataAdapter4.Fill(dataTable5)
                        flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))
                        If flag Then
                            Dim num48 As Double = 0.0
                            Dim num49 As Integer = 0
                            Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val),sum(val1*exchange_price) from inv,inv_sub where ", text5, " currency_from=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0"}), Me.conn)
                            Dim dataTable6 As DataTable = New DataTable()
                            sqlDataAdapter5.Fill(dataTable6)
                            flag = (dataTable6.Rows.Count > 0 AndAlso Operators.CompareString(dataTable6.Rows(0)(1).ToString(), "", False) <> 0)
                            If flag Then

                                num48 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(1)))

                                num49 += Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))
                            End If
                            sqlDataAdapter5 = New SqlDataAdapter(String.Concat(New String() {"select sum(val),sum(val1*exchange_price) from inv,inv_sub where ", text5, " currency_from=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0"}), Me.conn)
                            dataTable6 = New DataTable()
                            sqlDataAdapter5.Fill(dataTable6)
                            flag = (dataTable6.Rows.Count > 0 AndAlso Operators.CompareString(dataTable6.Rows(0)(1).ToString(), "", False) <> 0)
                            If flag Then

                                num48 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(1)))

                                num49 += Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))
                            End If
                            Try
                                flag = (num49 <> 0)
                                If flag Then
                                    num47 = num48 / CDbl(num49)
                                    num47 = Math.Floor(num47 * 100000000.0)
                                    num47 /= 100000000.0
                                Else
                                    num47 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)("price")))
                                End If
                            Catch ex2 As Exception
                            End Try
                        End If
                        Me.dgvItems.Rows.Add()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "بيع"
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("safe"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("id"))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("date"))).ToShortDateString()
                        Dim num50 As Double = Math.Round(Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("val")))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("mat_quantot")))), 2)
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("val")))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num45)("mat_quantot"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num47
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num50 * num47, 2)
                        Dim progressBar As ProgressBar = Me.ProgressBar1
                        progressBar.Value += 1
                        num45 += 1
                    End While
                Else
                    sqlDataAdapter2 = New SqlDataAdapter(String.Concat(New String() {"select inv.id,inv.date,inv.safe,currency_from,Inv_Sub.val,Inv_Sub.exchange_price,(Inv_Sub.val*Inv_Sub.exchange_price) as total,item_comp.mat_quantot  from inv,inv_sub,item_comp where ", text5, text, " inv.date>=@date1 and inv.date<=@date2 and is_manfc=1 and inv.proc_type=3 and  inv.proc_id=inv_sub.proc_id and item_comp.item_id=inv_sub.currency_from and IS_Deleted=0  and item_comp.mat_id=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id")))}), Me.conn)
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    Me.ProgressBar1.Value = 0
                    Me.ProgressBar1.Maximum = dataTable3.Rows.Count
                    Dim num51 As Integer = 0
                    Dim num52 As Integer = dataTable3.Rows.Count - 1
                    Dim num53 As Integer = num51
                    While True
                        Dim num54 As Integer = num53
                        num5 = num52
                        If num54 > num5 Then
                            Exit While
                        End If
                        Dim num55 As Double = 0.0
                        Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter("select is_deleted from currencies where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), Me.conn)
                        Dim dataTable7 As DataTable = New DataTable()
                        sqlDataAdapter6.Fill(dataTable7)
                        flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)(0)))
                        If flag Then
                            Dim num56 As Double = 0.0
                            Dim num57 As Integer = 0
                            Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val),sum(val1*exchange_price) from inv,inv_sub where ", text5, " currency_from=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0"}), Me.conn)
                            Dim dataTable8 As DataTable = New DataTable()
                            sqlDataAdapter7.Fill(dataTable8)
                            flag = (dataTable8.Rows.Count > 0 AndAlso Operators.CompareString(dataTable8.Rows(0)(1).ToString(), "", False) <> 0)
                            If flag Then

                                num56 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable8.Rows(0)(1)))

                                num57 += Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable8.Rows(0)(0))))
                            End If
                            sqlDataAdapter7 = New SqlDataAdapter(String.Concat(New String() {"select sum(val),sum(val1*exchange_price) from inv,inv_sub where ", text5, " currency_from=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id"))), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0"}), Me.conn)
                            dataTable8 = New DataTable()
                            sqlDataAdapter7.Fill(dataTable8)
                            flag = (dataTable8.Rows.Count > 0 AndAlso Operators.CompareString(dataTable8.Rows(0)(1).ToString(), "", False) <> 0)
                            If flag Then

                                num56 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable8.Rows(0)(1)))

                                num57 += Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable8.Rows(0)(0))))
                            End If
                            Try
                                flag = (num57 <> 0)
                                If flag Then
                                    num55 = num56 / CDbl(num57)
                                    num55 = Math.Floor(num55 * 100000000.0)
                                    num55 /= 100000000.0
                                Else
                                    num55 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("price")))
                                End If
                            Catch ex3 As Exception
                            End Try
                        End If
                        Me.dgvItems.Rows.Add()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = "إنتاج"
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetsafeName(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("safe"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("id"))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("date"))).ToShortDateString()
                        Dim num58 As Double = Math.Round(Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("val")))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("mat_quantot")))), 2)
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("val")))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)("mat_quantot"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num55
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num58 * num55, 2)
                        Dim progressBar As ProgressBar = Me.ProgressBar1
                        progressBar.Value += 1
                        num53 += 1
                    End While
                End If
                num3 += 1
            End While
        Catch ex4 As Exception
        Finally
            Me._Finished = True
        End Try
    End Sub

    Private Sub bntView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bntShow.Click
        Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbSafes.SelectedIndex = -1
        If flag Then
            MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbSafes.Focus()
        Else
            flag = (Me.cmbCurrency.SelectedIndex = -1)
            If flag Then
                MessageBox.Show("يجب اختيار الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbCurrency.Focus()
            Else
                Me.dgvItems.Rows.Clear()
                Me.dgvItems.ScrollBars = ScrollBars.None
                'Dim thread As Thread = AddressOf Me.CalcStock
                Dim thread As New Thread(AddressOf Me.CalcStock)
                thread.Start()
            End If
        End If
    End Sub

    Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Try
            Dim flag As Boolean = e.ColumnIndex = 7
            If flag Then
                Dim Form1 As New Form1()
                Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                Dim num As Integer = -1
                flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "مخزون أول المدة", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "إنتاج", False) = 0)
                If flag Then
                    num = 3
                Else
                    flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مشتريات", False) = 0)
                    If flag Then
                        num = 1
                    Else
                        flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد مشتريات", False) = 0)
                        If flag Then
                            num = 2
                        Else
                            flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مبيعات", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "بيع", False) = 0)
                            If flag Then
                                num = 1
                            Else
                                flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد مبيعات", False) = 0)
                                If flag Then
                                    num = 2
                                End If
                            End If
                        End If
                    End If
                End If
                flag = (num <> -1)
                If flag Then
                    Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                    frmSalePurch.WindowState = FormWindowState.Maximized
                    Dim value As Integer = 1
                    flag = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)).Contains("مشتريات")
                    If flag Then
                        frmSalePurch.InvProc = 1
                    Else
                        flag = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)).Contains("بيع")
                        If flag Then
                            frmSalePurch.InvProc = 2
                            value = 0
                        Else
                            flag = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)).Contains("مخزون")
                            If flag Then
                                frmSalePurch.InvProc = 1
                                num = 3
                            Else
                                flag = Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)).Contains("إنتاج")
                                If flag Then
                                    frmSalePurch.InvProc = 1
                                    num = 3
                                End If
                            End If
                        End If
                    End If
                    frmSalePurch.Show()
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from Inv where is_buy=" + Conversions.ToString(value) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value), " and proc_type="), num)))
                    frmSalePurch.Activate()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function GetEmpUserName(emp As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from users,Employees where users.emp=Employees.id and Employees.id=" + Conversions.ToString(emp), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
        Else
            result = ""
        End If
        Return result
    End Function

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("doctype")
            dataTable.Columns.Add("safe")
            dataTable.Columns.Add("invno")
            dataTable.Columns.Add("date")
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("price")
            dataTable.Columns.Add("total")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)})
                num3 += 1
            End While
            Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
            If flag Then
                obj = New rptCurrencyDetails()
            Else
                obj = New rptCurrencyDetails___EN()
            End If
            Dim instance As Object = obj
            Dim type2 As Type = Nothing
            Dim memberName As String = "SetDataSource"
            Dim array As Object() = New Object() {dataTable}
            Dim arguments As Object() = array
            Dim argumentNames As String() = Nothing
            Dim typeArguments As Type() = Nothing
            Dim array2 As Boolean() = New Boolean() {True}
            NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
            If array2(0) Then
                dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
            End If
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbSafes.Text
            End If
            Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"Safe"}, Nothing, Nothing, Nothing), TextObject)
            textObject.Text = text
            Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"currency"}, Nothing, Nothing, Nothing), TextObject)
            textObject2.Text = Me.cmbCurrency.Text
            Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtdatefrom"}, Nothing, Nothing, Nothing), TextObject)
            textObject3.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtdateto"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
            textObject5.Text = Me.GetEmpUserName(MainClass.EmpNo)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
            Dim type3 As Type = Nothing
            Dim memberName2 As String = "SetDataSource"
            Dim array3 As Object() = New Object() {dataTable2}
            Dim arguments2 As Object() = array3
            Dim argumentNames2 As String() = Nothing
            Dim typeArguments2 As Type() = Nothing
            array2 = New Boolean() {True}
            NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
            If array2(0) Then
                dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
            End If
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
                textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
                textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
                textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
                textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    Dim instance3 As Object = obj
                    Dim type4 As Type = Nothing
                    Dim memberName3 As String = "PrintToPrinter"
                    array = New Object() {1, False, 1, num6}
                    Dim arguments3 As Object() = array
                    Dim argumentNames3 As String() = Nothing
                    Dim typeArguments3 As Type() = Nothing
                    array2 = New Boolean() {False, False, False, True}
                    NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
                    If array2(3) Then
                        num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(2)
    End Sub

    Private Sub chkType1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkType1.CheckedChanged
        Try
            Me.LoadCurrencies()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim finished As Boolean = Me._Finished
        If finished Then
            Me._Finished = False
            Me.dgvItems.ScrollBars = ScrollBars.Both
        End If
    End Sub
End Class
