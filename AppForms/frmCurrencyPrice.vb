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
Imports AQSYS.My.Resources
Public Partial Class frmCurrencyPrice
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer

    Private Emp_No As Integer

    Private _IsUpdateDG As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.KeyDown, AddressOf Me.frmCurrencyPrice_KeyDown
        AddHandler MyBase.Load, AddressOf Me.frmCurrencyPrice_Load
        frmCurrencyPrice.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me.Emp_No = -1
        Me._IsUpdateDG = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCurrencyPrice.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCurrencyPrice.__ENCList.Count = frmCurrencyPrice.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCurrencyPrice.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCurrencyPrice.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCurrencyPrice.__ENCList(num) = frmCurrencyPrice.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCurrencyPrice.__ENCList.RemoveRange(num, frmCurrencyPrice.__ENCList.Count - num)
                frmCurrencyPrice.__ENCList.Capacity = frmCurrencyPrice.__ENCList.Count
            End If
            frmCurrencyPrice.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.txtDate.Value = DateTime.Now
        Me.LoadEmp(MainClass.EmpNo)
        Me.cmbCurrency1.SelectedIndex = -1
        Me.txtPurch.Text = ""
        Me.txtSale.Text = ""
        Me.txtLowPurch.Text = ""
        Me.txtHighPurch.Text = ""
        Me.txtLowSale.Text = ""
        Me.txtHighSale.Text = ""
        Me.txtTime.Value = DateTime.Now
        Me.txtDate.Value = DateTime.Now
        Me._IsUpdateDG = False
        Me.cmbCurrency1.Focus()
    End Sub

    Private Sub LoadDG(cond As String)
        Me.dgvSrch.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency1,purch_price,sale_price,Currency_Lastprice_Sub.time,Currency_Lastprice_Sub.date,Emp from Currency_Lastprice,Currency_Lastprice_Sub  where Currency_Lastprice.id = Currency_Lastprice_Sub.doc_id and IS_Deleted=0 " + cond, Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim num As Integer = 0
        Dim num2 As Integer = dataTable.Rows.Count - 1
        Dim num3 As Integer = num
        While True
            Dim num4 As Integer = num3
            Dim num5 As Integer = num2
            If num4 > num5 Then
                Exit While
            End If
            Me.dgvSrch.Rows.Add()
            Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select symbol from Currencies where id=", dataTable.Rows(num3)("currency1"))), Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter2.Fill(dataTable2)
            Me.dgvSrch.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))
            Me.dgvSrch.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("purch_price"))
            Me.dgvSrch.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))
            Dim flag As Boolean = dataTable.Rows(num3)("time").ToString().Contains("ص") And (Me.txtTime.Text.Contains("AM") Or Me.txtTime.Text.Contains("PM"))
            If flag Then
                dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("ص", "AM")
            End If
            flag = (dataTable.Rows(num3)("time").ToString().Contains("م") And (Me.txtTime.Text.Contains("AM") Or Me.txtTime.Text.Contains("PM")))
            If flag Then
                dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("م", "PM")
            End If
            flag = (dataTable.Rows(num3)("time").ToString().Contains("AM") And (Me.txtTime.Text.Contains("ص") Or Me.txtTime.Text.Contains("م")))
            If flag Then
                dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("AM", "ص")
            End If
            flag = (dataTable.Rows(num3)("time").ToString().Contains("PM") And (Me.txtTime.Text.Contains("ص") Or Me.txtTime.Text.Contains("م")))
            If flag Then
                dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("PM", "م")
            End If
            Me.dgvSrch.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("time"))
            Me.dgvSrch.Rows(num3).Cells(4).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
            flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("emp")))
            If flag Then
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from Employees where id=", dataTable.Rows(num3)("emp"))), Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag = (dataTable3.Rows.Count > 0)
                If flag Then
                    Me.dgvSrch.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))
                End If
            End If
            Me.dgvSrch.Rows(num3).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency1"))
            num3 += 1
        End While
        Me.dgvSrch.ClearSelection()
    End Sub

    Public Sub LoadCurrency()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol as currency from Currencies order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvPrices.Columns(0), DataGridViewComboBoxColumn)
        dataGridViewComboBoxColumn.DataSource = dataTable
        dataGridViewComboBoxColumn.DisplayMember = "currency"
        dataGridViewComboBoxColumn.ValueMember = "id"
        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id,symbol as currency from Currencies order by id", Me.conn)
        Dim dataTable2 As DataTable = New DataTable()
        sqlDataAdapter2.Fill(dataTable2)
        Me.cmbCurrency1.DataSource = dataTable2
        Me.cmbCurrency1.DisplayMember = "currency"
        Me.cmbCurrency1.ValueMember = "id"
        Me.cmbCurrency1.SelectedIndex = -1
        Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select id,symbol as currency from Currencies order by id", Me.conn)
        Dim dataTable3 As DataTable = New DataTable()
        sqlDataAdapter3.Fill(dataTable3)
        Me.cmbCurrencySrch.DataSource = dataTable3
        Me.cmbCurrencySrch.DisplayMember = "currency"
        Me.cmbCurrencySrch.ValueMember = "id"
        Me.cmbCurrencySrch.SelectedIndex = -1
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub LoadEmp(emp As Integer)
        Dim flag As Boolean = emp <> -1
        If flag Then
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn1)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Me.Emp_No = emp
                Me.txtEmp.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            End If
        End If
    End Sub

    Private Function GetEmpNo(emp As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Employees where name='" + emp + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            ' The following expression was wrapped in a checked-expression
            result = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Function GetEmpName(emp As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn1)
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

    Private Sub LoadData()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Currency_Lastprice", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count = 0
            If flag Then
                Me.Code = -1
            Else
                ' The following expression was wrapped in a checked-expression
                Me.Code = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
                Me.Navigate("select * from Currency_Lastprice where id=" + Conversions.ToString(Me.Code))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCurrencyPrice_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmCurrencyPrice.Load
        Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadCurrency()
        Me.LoadDG("")
        Me.LoadEmp(MainClass.EmpNo)
        Try
            Me.LoadData()
        Catch ex As Exception
        End Try
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.dgvPrices.Rows.Count = 0
            If flag Then
                MessageBox.Show("لا توجد أصناف مدخلة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand()
                flag = (Me.Code <> -1)
                If flag Then
                    sqlCommand = New SqlCommand("update Currency_Lastprice set date=@date where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                    sqlCommand.ExecuteNonQuery()
                    sqlCommand = New SqlCommand("delete from Currency_Lastprice_Sub where doc_id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                End If
                flag = (Me.Code = -1)
                If flag Then
                    sqlCommand = New SqlCommand("insert into Currency_Lastprice(date,IS_Deleted) values (@date,0)", Me.conn)
                    sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                    sqlCommand.ExecuteNonQuery()
                    sqlCommand = New SqlCommand("select max(id) from Currency_Lastprice", Me.conn)
                    Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                End If
                Dim num As Integer = 0
                Dim num2 As Integer = Me.dgvPrices.Rows.Count - 1
                Dim num3 As Integer = num
                While True
                    Dim num4 As Integer = num3
                    Dim num5 As Integer = num2
                    If num4 > num5 Then
                        Exit While
                    End If
                    sqlCommand = New SqlCommand("insert into Currency_Lastprice_Sub(doc_id,currency1,time,date,purch_price,sale_price,low_purch_price,high_purch_price,low_sale_price,high_sale_price,Emp) values (@doc_id,@currency1,@time,@date,@purch_price,@sale_price,@low_purch_price,@high_purch_price,@low_sale_price,@high_sale_price,@Emp)", Me.conn)
                    sqlCommand.Parameters.Add("@doc_id", SqlDbType.Int).Value = Me.Code
                    sqlCommand.Parameters.Add("@currency1", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvPrices.Rows(num3).Cells(0).Value)
                    sqlCommand.Parameters.Add("@time", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(1).Value)
                    sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(Me.dgvPrices.Rows(num3).Cells(2).Value))
                    sqlCommand.Parameters.Add("@purch_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(3).Value))
                    sqlCommand.Parameters.Add("@sale_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(4).Value))
                    sqlCommand.Parameters.Add("@low_purch_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(5).Value))
                    sqlCommand.Parameters.Add("@high_purch_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(6).Value))
                    sqlCommand.Parameters.Add("@low_sale_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(7).Value))
                    sqlCommand.Parameters.Add("@high_sale_price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(8).Value))
                    flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvPrices.Rows(num3).Cells(9).Value)), "", False) = 0)
                    If flag Then
                        sqlCommand.Parameters.Add("@Emp", SqlDbType.Int).Value = DBNull.Value
                    Else
                        flag = (Me.GetEmpNo(Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(9).Value))) <> -1)
                        If flag Then
                            sqlCommand.Parameters.Add("@Emp", SqlDbType.Int).Value = Me.GetEmpNo(Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(num3).Cells(9).Value)))
                        Else
                            sqlCommand.Parameters.Add("@Emp", SqlDbType.Int).Value = DBNull.Value
                        End If
                    End If
                    sqlCommand.ExecuteNonQuery()
                    num3 += 1
                End While
                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.CalcAvgCost()
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

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnDelete.Click
    End Sub

    Private Sub dgvRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Currency_Lastprice where id=" + Conversions.ToString(Me.Code))
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
        ' The following expression was wrapped in a checked-statement
        Try
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvPrices.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    GoTo IL_93
                End If
                Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvPrices.Rows(num3).Cells(0).Value, Me.dgvSrch.Rows(e.RowIndex).Cells(6).Value, False)
                If flag Then
                    Exit While
                End If
                num3 += 1
            End While
            Me.dgvPrices.Rows(num3).Selected = True
IL_93:
            Me.DGPrice_CellClick(Me.dgvPrices.SelectedRows(0).Index)
            Me.TabControl1.SelectedIndex = 0
            Me.cmbCurrency1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim flag As Boolean = dr.HasRows
        If flag Then
            dr.Read()
            Me.CLR()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            dr.Close()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Currency_Lastprice_Sub where doc_id=" + Conversions.ToString(Me.Code), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Me.dgvPrices.Rows.Add()
                Me.dgvPrices.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency1"))
                flag = (dataTable.Rows(num3)("time").ToString().Contains("ص") And (Me.txtTime.Text.Contains("AM") Or Me.txtTime.Text.Contains("PM")))
                If flag Then
                    dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("ص", "AM")
                End If
                flag = (dataTable.Rows(num3)("time").ToString().Contains("م") And (Me.txtTime.Text.Contains("AM") Or Me.txtTime.Text.Contains("PM")))
                If flag Then
                    dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("م", "PM")
                End If
                flag = (dataTable.Rows(num3)("time").ToString().Contains("AM") And (Me.txtTime.Text.Contains("ص") Or Me.txtTime.Text.Contains("م")))
                If flag Then
                    dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("AM", "ص")
                End If
                flag = (dataTable.Rows(num3)("time").ToString().Contains("PM") And (Me.txtTime.Text.Contains("ص") Or Me.txtTime.Text.Contains("م")))
                If flag Then
                    dataTable.Rows(num3)("time") = dataTable.Rows(num3)("time").ToString().Replace("PM", "م")
                End If
                Me.dgvPrices.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("time"))
                Me.dgvPrices.Rows(num3).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
                Me.dgvPrices.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("purch_price"))
                Me.dgvPrices.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))
                Me.dgvPrices.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("low_purch_price"))
                Me.dgvPrices.Rows(num3).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("high_purch_price"))
                Me.dgvPrices.Rows(num3).Cells(7).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("low_sale_price"))
                Me.dgvPrices.Rows(num3).Cells(8).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("high_sale_price"))
                flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("Emp")))
                If flag Then
                    Me.dgvPrices.Rows(num3).Cells(9).Value = Me.GetEmpName(Conversions.ToInteger(dataTable.Rows(num3)("Emp")))
                End If
                num3 += 1
            End While
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvSrch.ClearSelection()
        Dim sqlCommand As SqlCommand = New SqlCommand(sqlstr, Me.conn)
        Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
        If flag Then
            Me.conn.Open()
        End If
        Dim dr As SqlDataReader = sqlCommand.ExecuteReader()
        Me.ReadData(dr)
        flag = (Me.conn.State <> ConnectionState.Closed)
        If flag Then
            Me.conn.Close()
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnLast.Click
        Me.Navigate("select top 1 * from Currency_Lastprice where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnNext.Click
        Me.Navigate("select top 1 * from Currency_Lastprice where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) 'Handles btnFirst.Click
        Me.Navigate("select top 1 * from Currency_Lastprice where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Currency_Lastprice where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub Search()
        Dim flag As Boolean = Not Me.chkSrchAll.Checked
        If flag Then
            Dim cond As String = "and currency1=" + Me.txtCurrencyNoSrch.Text
            Me.LoadDG(cond)
        Else
            Me.LoadDG("")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim flag As Boolean = Not Me.chkSrchAll.Checked And Operators.CompareString(Me.txtCurrencyNoSrch.Text.Trim(), "", False) = 0
        If flag Then
            MessageBox.Show("ادخل الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.txtCurrencyNoSrch.Focus()
        Else
            Me.Search()
        End If
    End Sub

    Private Sub dgvPrices_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvPrices.RowsAdded
    End Sub

    Private Sub dgvPrices_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvPrices.CellContentClick
    End Sub

    Private Sub CalcAvgCost()
        Try
            Dim num As Double = 0.0
            Dim num2 As Integer = 0
            Dim num3 As Double = 0.0
            Dim str As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", Me.cmbCurrency1.SelectedValue), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(1).ToString(), "", False) <> 0)
            If flag Then
                num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1)))
                num2 = CInt(Math.Round(CDbl(num2) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
            End If
            sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", Me.cmbCurrency1.SelectedValue), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
            dataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(1).ToString(), "", False) <> 0)
            If flag Then
                num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1)))
                num2 = CInt(Math.Round(CDbl(num2) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
            End If
            flag = (num2 <> 0)
            If flag Then
                num3 = num / CDbl(num2)
                num3 = Math.Floor(num3 * 100000000.0)
                num3 /= 100000000.0
            Else
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currency_Lastprice_Sub where currency1=", Me.cmbCurrency1.SelectedValue)), Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
                End If
            End If
            Me.txtAveragePrice.Text = "" + Conversions.ToString(num3)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency1.SelectedIndexChanged
        Try
            Me.txtDate.Value = DateTime.Now
            Me.txtTime.Value = DateTime.Now
            Me.CalcAvgCost()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCurrencyPrice_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) ' Handles frmCurrencyPrice.KeyDown
        Dim flag As Boolean = e.KeyCode = Keys.[Return]
        If flag Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Add2DG()
        Dim flag As Boolean = Me.cmbCurrency1.SelectedValue Is Nothing
        If flag Then
            MessageBox.Show("اختر الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbCurrency1.Focus()
        Else
            flag = (Operators.CompareString(Me.txtPurch.Text.Trim(), "", False) = 0 Or Conversion.Val(Me.txtPurch.Text) = 0.0)
            If flag Then
                MessageBox.Show("ادخل سعر الشراء", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtPurch.Focus()
            Else
                flag = (Operators.CompareString(Me.txtSale.Text.Trim(), "", False) = 0 Or Conversion.Val(Me.txtSale.Text) = 0.0)
                If flag Then
                    MessageBox.Show("ادخل سعر البيع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txtSale.Focus()
                Else
                    flag = Me._IsUpdateDG
                    Dim index As Integer
                    If flag Then
                        index = Me.dgvPrices.SelectedRows(0).Index
                    Else
                        Me.dgvPrices.Rows.Add()
                        index = Me.dgvPrices.Rows.Count - 1
                    End If
                    Me.dgvPrices.Rows(index).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency1.SelectedValue)
                    Me.dgvPrices.Rows(index).Cells(1).Value = Me.txtTime.Text
                    Me.dgvPrices.Rows(index).Cells(2).Value = Me.txtDate.Value.ToShortDateString()
                    Me.dgvPrices.Rows(index).Cells(3).Value = Conversion.Val(Me.txtPurch.Text)
                    Me.dgvPrices.Rows(index).Cells(4).Value = Conversion.Val(Me.txtSale.Text)
                    Me.dgvPrices.Rows(index).Cells(5).Value = Conversion.Val(Me.txtLowPurch.Text)
                    Me.dgvPrices.Rows(index).Cells(6).Value = Conversion.Val(Me.txtHighPurch.Text)
                    Me.dgvPrices.Rows(index).Cells(7).Value = Conversion.Val(Me.txtLowSale.Text)
                    Me.dgvPrices.Rows(index).Cells(8).Value = Conversion.Val(Me.txtHighSale.Text)
                    Me.dgvPrices.Rows(index).Cells(9).Value = Me.txtEmp.Text
                    Me.dgvPrices.Rows(index).Selected = True
                    Me._IsUpdateDG = True
                    Me.GroupBox2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtHighSale.KeyDown
        Dim flag As Boolean = e.KeyCode = Keys.[Return]
        If flag Then
            Me.Add2DG()
        End If
    End Sub

    Private Sub txtHighSale_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtHighSale.KeyPress
        MainClass.IsFloat(e)
    End Sub

    Private Sub DGPrice_CellClick(index As Integer)
        Try
            Me.cmbCurrency1.SelectedValue = Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(0).Value)
            Me.txtTime.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(1).Value))
            Me.txtDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(2).Value))
            Me.txtPurch.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(3).Value))
            Me.txtSale.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(4).Value))
            Me.txtLowPurch.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(5).Value))
            Me.txtHighPurch.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(6).Value))
            Me.txtLowSale.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(7).Value))
            Me.txtHighSale.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvPrices.Rows(index).Cells(8).Value))
            Me._IsUpdateDG = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvPrices_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvPrices.CellClick
        Me.DGPrice_CellClick(e.RowIndex)
    End Sub

    Private Sub btnSave2DG_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnSave2DG.Click
        Me.Add2DG()
    End Sub

    Private Sub btnNew2DG_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnNew2DG.Click
        Me.txtPurch.Text = ""
        Me.txtSale.Text = ""
        Me.txtLowPurch.Text = ""
        Me.txtHighPurch.Text = ""
        Me.txtLowSale.Text = ""
        Me.txtHighSale.Text = ""
        Me.txtTime.Value = DateTime.Now
        Me.txtDate.Value = DateTime.Now
        Me._IsUpdateDG = False
        Me.cmbCurrency1.Focus()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub chkSrchAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSrchAll.CheckedChanged
        Dim checked As Boolean = Me.chkSrchAll.Checked
        If checked Then
            Me.cmbCurrencySrch.Enabled = False
            Me.txtCurrencyNoSrch.Enabled = False
        Else
            Me.cmbCurrencySrch.Enabled = True
            Me.txtCurrencyNoSrch.Enabled = True
        End If
    End Sub

    Private Sub txtCurrencyNoSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCurrencyNoSrch.KeyPress
        MainClass.ISInteger(e)
    End Sub

    Private Sub txtCurrencyNoSrch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrencyNoSrch.TextChanged
        Try
            Me.cmbCurrencySrch.SelectedValue = Me.txtCurrencyNoSrch.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCurrencySrch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrencySrch.SelectedIndexChanged
        Try
            Me.txtCurrencyNoSrch.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.cmbCurrencySrch.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvPrices_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles dgvPrices.RowsRemoved
        Try
            Me._IsUpdateDG = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvPrices_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvPrices.DataError
    End Sub

    Private Sub dgvSrch_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvSrch.DataError
    End Sub

    Private Sub txtPurch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurch.TextChanged
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox2.Enter
    End Sub
End Class
