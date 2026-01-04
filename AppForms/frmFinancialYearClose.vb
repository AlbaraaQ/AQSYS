Imports Microsoft.SqlServer.Management.Sdk.Sfc
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
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
Public Partial Class frmFinancialYearClose
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private connexp As SqlConnection

    Private connnew As SqlConnection

    Private cmd As SqlCommand
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmFinancialYearClose_Load
        frmFinancialYearClose.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.connexp = New SqlConnection("server=" + MainClass.Server + ";trusted_connection=true")
        Me.connnew = New SqlConnection()
        Me.cmd = New SqlCommand()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmFinancialYearClose.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmFinancialYearClose.__ENCList.Count = frmFinancialYearClose.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmFinancialYearClose.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmFinancialYearClose.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmFinancialYearClose.__ENCList(num) = frmFinancialYearClose.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmFinancialYearClose.__ENCList.RemoveRange(num, frmFinancialYearClose.__ENCList.Count - num)
                frmFinancialYearClose.__ENCList.Capacity = frmFinancialYearClose.__ENCList.Count
            End If
            frmFinancialYearClose.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim flag As Boolean = Conversion.Val(Me.txtYear.Text) = 0.0
        If flag Then
            Interaction.MsgBox("ادخل السنة الجديدة المطلوب تقفيل البيانات إليها", MsgBoxStyle.OkOnly, Nothing)
            Me.txtYear.Focus()
        Else
            Me.txtYear.Focus()
            Me.lblStatus.Text = "جاري التهيئة ... "
            Me.ProgressBar1.Value = 0
            'Dim thread As Thread = AddressOf Me.StartProcess
            Dim thread As New Thread(AddressOf Me.StartProcess)
            thread.Start()
        End If
    End Sub

    Private Sub StartProcess()
        Try
            Dim text As String = MainClass.Database + Me.txtYear.Text
            Me.connexp.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand("create database [" + text + "] collate arabic_ci_as", Me.connexp)
            sqlCommand.ExecuteNonQuery()
            Me.connnew = New SqlConnection(String.Concat(New String() {"server=", MainClass.Server, ";database=", text, ";trusted_connection=true"}))
            Me.connnew.Open()
            Dim flag As Boolean = True
            If flag Then
                Dim server As Server = New Server(MainClass.Server)
                Dim scripter As Scripter = New Scripter(server)
                Dim database As Database = server.Databases(MainClass.Database)
                Dim scriptingOptions As ScriptingOptions = New ScriptingOptions()
                scripter.Options.IncludeIfNotExists = False
                scripter.Options.ScriptSchema = True
                scripter.Options.ScriptData = False
                Try
                    For Each obj As Object In database.Tables
                        Dim table As Table = CType(obj, Table)
                        flag = table.IsSystemObject
                        If Not flag Then
                            Try
                                For Each cmdText As String In scripter.EnumScript(New Urn() {table.Urn})
                                    Dim sqlCommand2 As SqlCommand = New SqlCommand(cmdText, Me.connnew)
                                    sqlCommand2.ExecuteNonQuery()
                                Next
                            Finally
                                Dim enumerator2 As IEnumerator(Of String)
                                flag = (enumerator2 IsNot Nothing)
                                If flag Then
                                    enumerator2.Dispose()
                                End If
                            End Try
                        End If
                    Next
                Finally
                    Dim enumerator As IEnumerator
                    flag = (TypeOf enumerator Is IDisposable)
                    If flag Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
                Try
                    For Each obj2 As Object In database.StoredProcedures
                        Dim storedProcedure As StoredProcedure = CType(obj2, StoredProcedure)
                        flag = storedProcedure.IsSystemObject
                        If Not flag Then
                            Try
                                For Each cmdText2 As String In scripter.EnumScript(New Urn() {storedProcedure.Urn})
                                    Dim sqlCommand3 As SqlCommand = New SqlCommand(cmdText2, Me.connnew)
                                    sqlCommand3.ExecuteNonQuery()
                                Next
                            Finally
                                Dim enumerator4 As IEnumerator(Of String)
                                flag = (enumerator4 IsNot Nothing)
                                If flag Then
                                    enumerator4.Dispose()
                                End If
                            End Try
                        End If
                    Next
                Finally
                    Dim enumerator3 As IEnumerator
                    flag = (TypeOf enumerator3 Is IDisposable)
                    If flag Then
                        TryCast(enumerator3, IDisposable).Dispose()
                    End If
                End Try
            Else
                flag = Not File.Exists(System.Windows.Forms.Application.StartupPath + "\script1.sql")
                If flag Then
                    Interaction.MsgBox("تأكد من موجود ملف سكريبت بمجلد البرنامج ", MsgBoxStyle.OkOnly, Nothing)
                    Return
                End If
                Dim text2 As String = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\script1.sql", Encoding.[Default])
                text2 = text2.Replace("USE [StockDB-Basem]", "USE [" + text + "]")
                Dim separator As String() = New String() {"GO"}
                Dim array As String() = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                For Each cmdText3 As String In array
                    Try
                        sqlCommand = New SqlCommand(cmdText3, Me.connnew)
                        sqlCommand.ExecuteNonQuery()
                    Catch ex As Exception
                        Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, Nothing)
                    End Try
                Next
            End If
        Catch ex2 As Exception
        End Try
        Try
            Me.connnew.Close()
            Me.connexp.Close()
        Catch ex3 As Exception
        End Try
        Me.transferTables()
        Me.CalcStock()
        Me.lblStatus.Text = "تم الانتهاء" + Environment.NewLine + "يمكنك اختيار قاعدة البيانات الجديدة عند تسجيل الدخول"
    End Sub

    Private Sub AddFirstStock(_Val As Integer, Safe As Integer, Item As Integer, _Price As Decimal)
        ' The following expression was wrapped in a checked-statement
        Try
            Dim str As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
            End If
            flag = (Me.connnew.State <> ConnectionState.Open)
            If flag Then
                Me.connnew.Open()
            End If
            Dim sqlTransaction As SqlTransaction = Me.connnew.BeginTransaction()
            Dim sqlCommand As SqlCommand = New SqlCommand()
            Dim num As Integer = 0
            Dim num2 As Integer = 0
            flag = (_Val <> 0)
            If flag Then
                sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.connnew, sqlTransaction)
                num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
            End If
            Dim num3 As Integer = 1
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and proc_type=3", Me.connnew)
            sqlDataAdapter.SelectCommand.Transaction = sqlTransaction
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Try
                    ' The following expression was wrapped in a unchecked-expression
                    num3 = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
                Catch ex As Exception
                End Try
            End If
            Dim num4 As Integer = -1
            Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id from Customers where IS_Deleted=0 order by id", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter2.Fill(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                num4 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))))
            End If
            Dim num5 As Integer = -1
            Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select id from Stocks where IS_Deleted=0 order by id", Me.conn)
            Dim dataTable3 As DataTable = New DataTable()
            sqlDataAdapter3.Fill(dataTable3)
            flag = (dataTable3.Rows.Count > 0)
            If flag Then
                num5 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))))
            End If
            sqlCommand = New SqlCommand("insert into Inv(proc_type,id,date,inv_type,safe,stock,cust_id,sales_emp,tot_purch,tot_sale,tot_net,paid,minus,purch_rest_id,sale_rest_id,InvId_Return,branch,IS_Buy,IS_Deleted)values(@proc_type,@id,@date,@inv_type,@safe,@stock,@cust_id,@sales_emp,@tot_purch,@tot_sale,@tot_net,@paid,@minus,@purch_rest_id,@sale_rest_id,@InvId_Return,@branch,@IS_Buy,@IS_Deleted)", Me.connnew, sqlTransaction)
            sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 3
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num3
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
            Else
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
            End If
            sqlCommand.Parameters.Add("@inv_type", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@safe", SqlDbType.Int).Value = Safe
            sqlCommand.Parameters.Add("@stock", SqlDbType.Int).Value = num5
            sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = num4
            sqlCommand.Parameters.Add("@sales_emp", SqlDbType.Int).Value = MainClass.EmpNo
            sqlCommand.Parameters.Add("@tot_purch", SqlDbType.Float).Value = Decimal.Multiply(New Decimal(_Val), _Price)
            sqlCommand.Parameters.Add("@tot_sale", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@tot_net", SqlDbType.Float).Value = Decimal.Multiply(New Decimal(_Val), _Price)
            sqlCommand.Parameters.Add("@paid", SqlDbType.Float).Value = Decimal.Multiply(New Decimal(_Val), _Price)
            sqlCommand.Parameters.Add("@minus", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@purch_rest_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@sale_rest_id", SqlDbType.Int).Value = num2
            sqlCommand.Parameters.Add("@InvId_Return", SqlDbType.Int).Value = -1
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.Parameters.Add("@IS_Buy", SqlDbType.Bit).Value = 1
            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
            sqlCommand.Parameters.Add("@salesman", SqlDbType.Int).Value = -1
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("select max(proc_id) from Inv", Me.connnew, sqlTransaction)
            Dim num6 As Integer = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
            sqlCommand = New SqlCommand("insert into Inv_Sub(proc_id,proc_type,currency_from,unit,val,val1,exchange_price)values(@proc_id,@proc_type,@currency_from,@unit,@val,@val1,@exchange_price)", Me.connnew, sqlTransaction)
            sqlCommand.Parameters.Add("@proc_id", SqlDbType.Int).Value = num6
            sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@currency_from", SqlDbType.Int).Value = Item
            sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = -1
            sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = _Val
            sqlCommand.Parameters.Add("@val1", SqlDbType.Float).Value = _Val
            sqlCommand.Parameters.Add("@exchange_price", SqlDbType.Float).Value = _Price
            sqlCommand.ExecuteNonQuery()
            Dim num7 As Integer = 1270001
            Dim num8 As Integer = 2120001
            flag = MainClass.IsAccTreeNew
            If flag Then
                num7 = 1103030001
                num8 = 210020001
            End If
            sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.connnew, sqlTransaction)
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
            Else
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
            End If
            sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = num3
            sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 9
            sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.connnew, sqlTransaction)
            sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = Decimal.Multiply(New Decimal(_Val), _Price)
            sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num8
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.connnew, sqlTransaction)
            sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = Decimal.Multiply(New Decimal(_Val), _Price)
            sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num7
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.ExecuteNonQuery()
            sqlTransaction.Commit()
        Catch ex2 As Exception
            Dim sqlTransaction As SqlTransaction
            sqlTransaction.Rollback()
            Dim str2 As String = "خطأ حفظ مخزون أول المدة"
            str2 = str2 + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
        Finally
            Dim flag As Boolean = Me.connnew.State <> ConnectionState.Closed
            If flag Then
                Me.connnew.Close()
            End If
        End Try
    End Sub

    Private Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Me.lblStatus.Text = "جاري تهيئة أرصدة المخزون للأصناف ..."
            Dim num As Integer = 1
            Try
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select storeclose_pricetype from Foundation", Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
            Catch ex As Exception
            End Try
            Dim dataTable2 As DataTable = New DataTable()
            dataTable2.Columns.Add("currency")
            dataTable2.Columns.Add("sum")
            dataTable2.Columns.Add("type")
            dataTable2.Columns.Add("invtype")
            Dim selectCommandText As String = "select id,symbol,purch_price from Currencies"
            Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
            Dim dataTable3 As DataTable = New DataTable()
            sqlDataAdapter2.Fill(dataTable3)
            Dim text As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            flag = Me.chkToDate.Checked
            If flag Then
                text += " date<@date and "
            End If
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = dataTable3.Rows.Count
            Dim num2 As Integer = 0
            Dim num3 As Integer = dataTable3.Rows.Count - 1
            Dim num4 As Integer = num2
            While True
                Dim num5 As Integer = num4
                Dim num6 As Integer = num3
                If num5 > num6 Then
                    Exit While
                End If
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where branch=" + Conversions.ToString(MainClass.BranchNo) + " and status=1 and IS_Deleted=0", Me.conn)
                Dim dataTable4 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable4)
                Dim num7 As Integer = 0
                Dim num8 As Integer = dataTable4.Rows.Count - 1
                Dim num9 As Integer = num7
                While True
                    Dim num10 As Integer = num9
                    num6 = num8
                    If num10 > num6 Then
                        Exit While
                    End If
                    Dim num11 As Double = 0.0
                    Dim num12 As Double = 0.0
                    Dim num13 As Double = 0.0
                    Dim num14 As Double = 0.0
                    Dim num15 As Double = 0.0
                    Dim num16 As Double = 0.0
                    Dim num17 As Double = 0.0
                    Dim num18 As Double = 0.0
                    Dim num19 As Double = 0.0
                    Dim num20 As Double = 0.0
                    Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text + " (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", dataTable3.Rows(num4)("id")), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0 ")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    Dim dataTable5 As DataTable = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num11 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text + " (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", dataTable3.Rows(num4)("id")), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0 ")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num12 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text + " (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", dataTable3.Rows(num4)("id")), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0 ")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num13 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text + " (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", dataTable3.Rows(num4)("id")), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0 ")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num14 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text + " (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", dataTable3.Rows(num4)("id")), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0 ")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num15 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + text + " SafesTransfer.safe_to=", dataTable4.Rows(num9)(0)), " and currency="), dataTable3.Rows(num4)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num16 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + text + " SafesTransfer.safe_from=", dataTable4.Rows(num9)(0)), " and currency="), dataTable3.Rows(num4)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num17 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If
                    Dim text2 As String = ""
                    flag = Me.chkToDate.Checked
                    If flag Then
                        text2 += " date<@date and "
                    End If
                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(difftot) from tsweya,tsweya_sub where " + text2 + " tsweya.id=tsweya_sub.tsweya_id and item=", dataTable3.Rows(num4)("id")), " and safe="), dataTable4.Rows(num9)(0)), " and IS_Deleted=0")), Me.conn)
                    sqlDataAdapter4.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                    dataTable5 = New DataTable()
                    sqlDataAdapter4.Fill(dataTable5)
                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num20 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable5.Rows(0)(0)))
                    End If

                    Dim num21 As Double = num11 + num12 - num13 - num14 + num15 + num16 - num17 + num18 - num19 + num20
                    flag = (num21 <> 0.0)
                    If flag Then
                        Dim value As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num4)("purch_price")))
                        Try
                            Dim num22 As Double = 0.0
                            Dim num23 As Double = 0.0
                            Try
                                flag = (num = 1)
                                If flag Then
                                    sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + text + " currency_from=", dataTable3.Rows(num4)("id")), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                                    dataTable5 = New DataTable()
                                    sqlDataAdapter4.Fill(dataTable5)
                                    flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(1).ToString(), "", False) <> 0)
                                    If flag Then
                                        num22 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(1)))
                                        num23 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))
                                    End If
                                Else
                                    flag = (num = 3)
                                    If flag Then
                                        sqlDataAdapter4 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 (val),(val1*exchange_price) from inv,inv_sub where " + text + " currency_from=", dataTable3.Rows(num4)("id")), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 order by inv.date desc")), Me.conn)
                                        dataTable5 = New DataTable()
                                        sqlDataAdapter4.Fill(dataTable5)
                                        flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(1).ToString(), "", False) <> 0)
                                        If flag Then
                                            num22 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(1)))
                                            num23 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))
                                        End If
                                    End If
                                End If
                            Catch ex2 As Exception
                            End Try
                            flag = (num23 <> 0.0)
                            If flag Then
                                Dim num24 As Double = num22 / num23
                                num24 = Math.Floor(num24 * 100000000.0)
                                num24 /= 100000000.0
                                value = num24
                            End If
                        Catch ex3 As Exception
                        End Try
                        Me.AddFirstStock(CInt(Math.Round(num21)), Conversions.ToInteger(dataTable4.Rows(num9)(0)), Conversions.ToInteger(dataTable3.Rows(num4)(0)), New Decimal(value))
                    End If

                    num9 += 1
                End While
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
                num4 += 1
            End While
        Catch ex4 As Exception
        End Try
    End Sub

    Public Sub transferTables()
        ' The following expression was wrapped in a checked-statement
        Try
            Me.lblStatus.Text = "جاري تهيئة أرصدة الحسابات ..."
            Dim text As String = MainClass.Database + Me.txtYear.Text
            Dim server As Server = New Server(MainClass.Server)
            Dim scripter As Scripter = New Scripter(server)
            Dim database As Database = server.Databases(MainClass.Database)
            Dim scriptingOptions As ScriptingOptions = New ScriptingOptions()
            scripter.Options.IncludeIfNotExists = False
            scripter.Options.ScriptSchema = False
            scripter.Options.ScriptData = True
            Me.ProgressBar1.Maximum = database.Tables.Count
            Me.connnew = New SqlConnection(String.Concat(New String() {"server=", MainClass.Server, ";database=", text, ";trusted_connection=true"}))
            Me.connnew.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand("delete from Accounts_Index", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Acts", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Areas", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Banks", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Branches", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Cities", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Countries", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from curr_barcodes", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from curr_units", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Currencies", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Companies", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from services", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Customers", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Employees", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from EmpBranches", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Forms", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Foundation", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from groups", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from sett", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Stocks", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Stock_Emps", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Safes", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Safe_Emps", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from units", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from tax_groups", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Stocks", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Stock_Emps", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from Users", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("delete from User_Permissions", Me.connnew)
            sqlCommand.ExecuteNonQuery()
            Dim flag As Boolean
            Try
                For Each obj As Object In database.Tables
                    Dim table As Table = CType(obj, Table)
                    flag = table.IsSystemObject
                    If Not flag Then
                        Try
                            For Each text2 As String In scripter.EnumScript(New Urn() {table.Urn})
                                Dim flag2 As Boolean = False
                                flag = (text2.ToLower().Contains("insert ") And Not text2.ToLower().Contains("[inv]") And Not text2.ToLower().Contains("[inv_sub]") And Not text2.ToLower().Contains("[services_inv]") And Not text2.ToLower().Contains("[services_inv_sub]") And Not text2.ToLower().Contains("[restrictions]") And Not text2.ToLower().Contains("[restrictions_sub]") And Not text2.ToLower().Contains("[sandq]") And Not text2.ToLower().Contains("[sandd]") And Not text2.ToLower().Contains("[sandqd]") And Not text2.ToLower().Contains("[sandsd]") And Not text2.ToLower().Contains("[tsweya]") And Not text2.ToLower().Contains("[tsweya_sub]") And Not text2.ToLower().Contains("[SafesTransfer]") And Not text2.ToLower().Contains("[SafesTransfer_Sub]"))
                                If flag Then
                                    flag2 = True
                                End If
                                flag = Me.chkToDate.Checked
                                If flag Then
                                    flag2 = True
                                End If
                                flag = flag2
                                If flag Then
                                    Try
                                        sqlCommand = New SqlCommand(text2, Me.connnew)
                                        sqlCommand.ExecuteNonQuery()
                                    Catch ex As Exception
                                    End Try
                                End If
                            Next
                        Finally
                            Dim enumerator2 As IEnumerator(Of String)
                            flag = (enumerator2 IsNot Nothing)
                            If flag Then
                                enumerator2.Dispose()
                            End If
                        End Try
                        Dim progressBar As ProgressBar = Me.ProgressBar1
                        progressBar.Value += 1
                    End If
                Next
            Finally
                Dim enumerator As IEnumerator
                flag = (TypeOf enumerator Is IDisposable)
                If flag Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from inv_sub", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from inv", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from inv_sub where proc_id in (select proc_id from inv where date<@date)", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from inv where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from services_inv_sub", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from services_inv", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from services_inv_sub where inv_id in (select id from services_inv where date<@date)", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from services_inv where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from restrictions_sub", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from restrictions", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from restrictions_sub where res_id in (select id from restrictions where date<@date)", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from restrictions where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from sandq", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandd", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandqd", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandsd", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from sandq where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandd where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandqd where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from sandsd where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from safestransfer_sub", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from safestransfer", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from safestransfer_sub where transfer_id in (select id from safestransfer where date<@date)", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from safestransfer where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            flag = Not Me.chkToDate.Checked
            If flag Then
                sqlCommand = New SqlCommand("delete from tsweya_sub", Me.connnew)
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from tsweya", Me.connnew)
                sqlCommand.ExecuteNonQuery()
            Else
                sqlCommand = New SqlCommand("delete from tsweya_sub where tsweya_id in (select id from tsweya where date<@date)", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("delete from tsweya where date<@date", Me.connnew)
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
                sqlCommand.ExecuteNonQuery()
            End If
            Me.connnew.Close()
            Me.CalcAccountsOpen()
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)
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
            Me.conn.Open()
            Me.cmd.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            result = False
        Finally
            Me.conn.Close()
        End Try
        Return result
    End Function
    '///////////////////////////////
    ''' <summary>
    ''' حساب القيد الافتتاحي للحسابات
    ''' </summary>
    Private Sub CalcAccountsOpen()
        Try
            ' ========== إعادة تعيين القيم الافتتاحية ==========
            ResetAccountInitialValues()

            ' ========== تحديد فلتر الفرع ==========
            Dim branchFilter As String = GetBranchFilter()

            ' ========== جلب الحسابات المطلوبة ==========
            Dim accountsTable As DataTable = GetAccountsForOpeningEntry()

            ' ========== إنشاء القيد الافتتاحي الرئيسي ==========
            Dim restrictionId As Integer = CreateOpeningRestriction(branchFilter)

            ' ========== حساب قيم الحسابات ==========
            CalculateAllAccountValues(accountsTable, restrictionId)

            ' ========== حساب الفرق وإنشاء قيد التسوية ==========
            CreateBalancingEntry(restrictionId, branchFilter)

        Catch ex As Exception
            ' يمكن إضافة تسجيل للخطأ هنا
            Debug.WriteLine($"خطأ في CalcAccountsOpen: {ex.Message}")
        Finally
            CloseConnectionSafely(Me.connnew)
        End Try
    End Sub

#Region "دوال مساعدة - إعادة التعيين"

    ''' <summary>
    ''' إعادة تعيين القيم الافتتاحية لجميع الحسابات
    ''' </summary>
    Private Sub ResetAccountInitialValues()
        Try
            OpenConnectionSafely(Me.connnew)

            Using cmd As New SqlCommand("UPDATE Accounts_Index SET IValue = 0", Me.connnew)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Debug.WriteLine($"خطأ في إعادة تعيين القيم: {ex.Message}")
        Finally
            CloseConnectionSafely(Me.connnew)
        End Try
    End Sub

#End Region

#Region "دوال مساعدة - الاستعلامات"

    ''' <summary>
    ''' الحصول على فلتر الفرع
    ''' </summary>
    Private Function GetBranchFilter() As String
        If MainClass.BranchNo <> -1 Then
            Return $" WHERE branch = {MainClass.BranchNo}"
        End If
        Return ""
    End Function

    ''' <summary>
    ''' الحصول على فلتر الفرع للاستعلامات المركبة
    ''' </summary>
    Private Function GetBranchFilterForJoin() As String
        If MainClass.BranchNo <> -1 Then
            Return $"Restrictions.branch = {MainClass.BranchNo} AND " &
               $"Restrictions_Sub.branch = {MainClass.BranchNo} AND "
        End If
        Return ""
    End Function

    ''' <summary>
    ''' جلب الحسابات المطلوبة للقيد الافتتاحي
    ''' </summary>
    Private Function GetAccountsForOpeningEntry() As DataTable
        Const ACCOUNTS_QUERY As String =
        "SELECT Code, AName FROM Accounts_Index " &
        "WHERE Type = 2 AND (Code LIKE '1%' OR Code LIKE '2%')"

        Dim adapter As New SqlDataAdapter(ACCOUNTS_QUERY, Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        Return dt
    End Function

    ''' <summary>
    ''' الحصول على أقصى رقم قيد
    ''' </summary>
    Private Function GetNextRestrictionId(branchFilter As String) As Integer
        Using cmd As New SqlCommand($"SELECT MAX(id) FROM Restrictions {branchFilter}", Me.connnew)
            Dim result As Object = cmd.ExecuteScalar()
            Return CInt(Math.Round(Conversion.Val($"{result}") + 1.0))
        End Using
    End Function

#End Region

#Region "دوال مساعدة - إنشاء القيود"

    ''' <summary>
    ''' إنشاء القيد الافتتاحي الرئيسي
    ''' </summary>
    Private Function CreateOpeningRestriction(branchFilter As String) As Integer
        OpenConnectionSafely(Me.connnew)

        ' الحصول على رقم القيد الجديد
        Dim restrictionId As Integer = GetNextRestrictionId(branchFilter)

        ' إنشاء القيد الرئيسي
        Dim sql As String =
        "INSERT INTO Restrictions (id, date, doc_no, type, state, notes, branch, IS_Deleted) " &
        "VALUES (@id, @date, @doc_no, @type, @state, @notes, @branch, @IS_Deleted)"

        Using cmd As New SqlCommand(sql, Me.connnew)
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = restrictionId
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = GetRestrictionDate()
            cmd.Parameters.Add("@doc_no", SqlDbType.Int).Value = -1
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = 11
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = 1
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "قيد افتتاحي"
            cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            cmd.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0

            cmd.ExecuteNonQuery()
        End Using

        Return restrictionId
    End Function

    ''' <summary>
    ''' الحصول على تاريخ القيد
    ''' </summary>
    Private Function GetRestrictionDate() As DateTime
        If Me.chkToDate.Checked Then
            Return Me.txtToDate.Value.Date
        Else
            Return DateTime.Now
        End If
    End Function

    ''' <summary>
    ''' حساب قيم جميع الحسابات
    ''' </summary>
    Private Sub CalculateAllAccountValues(accountsTable As DataTable, restrictionId As Integer)
        For Each row As DataRow In accountsTable.Rows
            Dim accountCode As String = row(0).ToString()
            Me.CalcAccountVal(accountCode, restrictionId)
        Next
    End Sub

#End Region

#Region "دوال مساعدة - قيد التسوية"

    ''' <summary>
    ''' إنشاء قيد التسوية للفرق بين المدين والدائن
    ''' </summary>
    Private Sub CreateBalancingEntry(restrictionId As Integer, branchFilter As String)
        ' حساب إجمالي المدين والدائن للحسابات 3 و 4
        Dim totals As AccountTotals = CalculateAccountTotals()

        ' إضافة حركات القيود
        AddRestrictionMovements(totals, branchFilter)

        ' حساب الفرق
        Dim difference As Double
        Dim differenceType As Integer
        CalculateDifference(totals.TotalDebit, totals.TotalCredit, difference, differenceType)

        ' إنشاء قيد التسوية إذا كان هناك فرق
        If difference <> 0.0 Then
            InsertBalancingRestrictionSub(restrictionId, difference, differenceType)
        End If

        CloseConnectionSafely(Me.connnew)
    End Sub

    ''' <summary>
    ''' هيكل لتخزين إجماليات الحسابات
    ''' </summary>
    Private Structure AccountTotals
        Public TotalDebit As Double
        Public TotalCredit As Double
    End Structure

    ''' <summary>
    ''' حساب إجماليات الحسابات
    ''' </summary>
    Private Function CalculateAccountTotals() As AccountTotals
        Dim totals As New AccountTotals()
        totals.TotalDebit = 0.0
        totals.TotalCredit = 0.0

        ' حساب إجمالي الحسابات ذات الطبيعة المدينة
        totals.TotalDebit += GetAccountsSum(1) ' nature = 1 (مدين)

        ' حساب إجمالي الحسابات ذات الطبيعة الدائنة
        totals.TotalCredit += GetAccountsSum(2) ' nature = 2 (دائن)

        Return totals
    End Function

    ''' <summary>
    ''' الحصول على مجموع الحسابات حسب الطبيعة
    ''' </summary>
    Private Function GetAccountsSum(nature As Integer) As Double
        Dim sql As String =
        $"SELECT SUM(IValue) FROM Accounts_Index " &
        $"WHERE type = 2 AND nature = {nature} AND (code LIKE '3%' OR code LIKE '4%')"

        Dim adapter As New SqlDataAdapter(sql, Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
            Return Conversion.Val($"{dt.Rows(0)(0)}")
        End If

        Return 0.0
    End Function

    ''' <summary>
    ''' إضافة حركات القيود من جدول Restrictions_Sub
    ''' </summary>
    Private Sub AddRestrictionMovements(ByRef totals As AccountTotals, branchFilter As String)
        Dim branchJoinFilter As String = GetBranchFilterForJoin()

        Dim sql As String =
        "SELECT SUM(Restrictions_Sub.dept) AS dept, SUM(Restrictions_Sub.credit) AS credit " &
        "FROM Restrictions " &
        "INNER JOIN Restrictions_Sub ON Restrictions.id = Restrictions_Sub.res_id " &
        $"WHERE {branchJoinFilter}" &
        "Restrictions.IS_Deleted = 0 AND Restrictions.state = 1 AND " &
        "Restrictions.date >= @date1 AND Restrictions.date < @date2 AND " &
        "(acc_no LIKE '3%' OR acc_no LIKE '4%')"

        Dim adapter As New SqlDataAdapter(sql, Me.conn)

        ' تاريخ البداية
        adapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = New DateTime(1990, 1, 1)

        ' تاريخ النهاية
        adapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = GetEndDate()

        Dim dt As New DataTable()
        adapter.Fill(dt)

        Try
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)("dept") IsNot DBNull.Value Then
                    totals.TotalDebit += Conversion.Val($"{dt.Rows(0)("dept")}")
                End If
                If dt.Rows(0)("credit") IsNot DBNull.Value Then
                    totals.TotalCredit += Conversion.Val($"{dt.Rows(0)("credit")}")
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine($"خطأ في قراءة حركات القيود: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على تاريخ النهاية
    ''' </summary>
    Private Function GetEndDate() As DateTime
        If Me.chkToDate.Checked Then
            Return Me.txtToDate.Value.AddDays(1).Date
        Else
            Return DateTime.Now
        End If
    End Function

    ''' <summary>
    ''' حساب الفرق بين المدين والدائن
    ''' </summary>
    Private Sub CalculateDifference(totalDebit As Double, totalCredit As Double,
                                 ByRef difference As Double, ByRef differenceType As Integer)
        If totalDebit > totalCredit Then
            difference = totalDebit - totalCredit
            differenceType = 1 ' مدين
        Else
            difference = totalCredit - totalDebit
            differenceType = 2 ' دائن
        End If
    End Sub

    ''' <summary>
    ''' إدراج قيد التسوية الفرعي
    ''' </summary>
    Private Sub InsertBalancingRestrictionSub(restrictionId As Integer,
                                           difference As Double,
                                           differenceType As Integer)
        Const BALANCING_ACCOUNT_CODE As Integer = 232

        Dim sql As String =
        "INSERT INTO Restrictions_Sub (res_id, dept, credit, acc_no, notes, branch) " &
        "VALUES (@res_id, @dept, @credit, @acc_no, @notes, @branch)"

        Using cmd As New SqlCommand(sql, Me.connnew)
            cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = restrictionId

            ' تحديد المدين والدائن حسب نوع الفرق
            If differenceType = 1 Then
                ' الفرق مدين
                cmd.Parameters.Add("@dept", SqlDbType.Float).Value = difference
                cmd.Parameters.Add("@credit", SqlDbType.Float).Value = 0
            Else
                ' الفرق دائن
                cmd.Parameters.Add("@dept", SqlDbType.Float).Value = 0
                cmd.Parameters.Add("@credit", SqlDbType.Float).Value = difference
            End If

            cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = BALANCING_ACCOUNT_CODE
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "قيد افتتاحي"
            cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo

            cmd.ExecuteNonQuery()
        End Using
    End Sub

#End Region

#Region "دوال مساعدة - إدارة الاتصال"

    ''' <summary>
    ''' فتح الاتصال بشكل آمن
    ''' </summary>
    Private Sub OpenConnectionSafely(connection As SqlConnection)
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
        Catch ex As Exception
            Debug.WriteLine($"خطأ في فتح الاتصال: {ex.Message}")
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' إغلاق الاتصال بشكل آمن
    ''' </summary>
    Private Sub CloseConnectionSafely(connection As SqlConnection)
        Try
            If connection IsNot Nothing AndAlso connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine($"خطأ في إغلاق الاتصال: {ex.Message}")
        End Try
    End Sub

#End Region

    '///////////////////////////////
    Public Sub CalcAccountVal(_Code As String, Optional _ResID As Integer = 1)
        Try
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Dim text As String = " and Restrictions_Sub.acc_no=" + _Code
            Dim text2 As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                text2 = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Restrictions.id,Restrictions.date,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit,Restrictions.notes from Restrictions,Restrictions_Sub where ", text2, " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date<@date2 and Restrictions.id=Restrictions_Sub.res_id ", text, " group by Restrictions.id,Restrictions.date,Restrictions.notes,Restrictions_Sub.acc_no"}), Me.conn)
            flag = Me.chkToDate.Checked
            If flag Then
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
            Else
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = DateTime.Now
            End If
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim num3 As Integer = 0
            Dim num4 As Integer = dataTable.Rows.Count - 1
            Dim num5 As Integer = num3
            While True
                Dim num6 As Integer = num5
                Dim num7 As Integer = num4
                If num6 > num7 Then
                    Exit While
                End If
                num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("dept")))
                num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("credit")))
                num5 += 1
            End While
            Dim num8 As Integer = 1
            Dim value As Decimal = 0D
            flag = (num > num2)
            If flag Then
                value = New Decimal(Math.Round(num - num2, 3))
                num8 = 1
            Else
                flag = (num2 > num)
                If flag Then
                    value = New Decimal(Math.Round(num2 - num, 3))
                    num8 = 2
                End If
            End If
            Dim num9 As Double = 0.0
            Dim num10 As Double = 0.0
            flag = (num8 = 1)
            If flag Then
                num9 = Convert.ToDouble(value)
            Else
                num10 = Convert.ToDouble(value)
            End If
            flag = (num9 <> 0.0 Or num10 <> 0.0)
            If flag Then
                Dim sqlCommand As SqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.connnew)
                sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = _ResID
                sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = num9
                sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = num10
                sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = _Code
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "قيد افتتاحي"
                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                sqlCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmFinancialYearClose_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmFinancialYearClose.Load
        ' The following expression was wrapped in a checked-expression
        Me.txtYear.Text = Conversions.ToString(DateTime.Now.Year + 1)
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
