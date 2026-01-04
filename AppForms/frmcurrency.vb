Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Public Partial Class frmcurrency
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer

    Private _Exchangeal As Double

    Private _purch1 As Boolean

    Private _purch2 As Boolean

    Private _sale1 As Boolean

    Private _sale2 As Boolean

    Private _CompletedImport As Boolean

    Private dtItems As DataTable
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmcurrency_Load
        frmcurrency.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me._Exchangeal = 1250.0
        Me._purch1 = True
        Me._purch2 = False
        Me._sale1 = True
        Me._sale2 = False
        Me._CompletedImport = False
        Me.dtItems = New DataTable()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmcurrency.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmcurrency.__ENCList.Count = frmcurrency.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmcurrency.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmcurrency.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmcurrency.__ENCList(num) = frmcurrency.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmcurrency.__ENCList.RemoveRange(num, frmcurrency.__ENCList.Count - num)
                frmcurrency.__ENCList.Capacity = frmcurrency.__ENCList.Count
            End If
            frmcurrency.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.LoadNextNo()
        Me.txtNo.[ReadOnly] = False
        Me.txtBarcode.Focus()
        Me.txtBarcode.Text = ""
        Me.chkMezan.Checked = False
        Me.txtSymbol.Text = ""
        Me.txtNameEN.Text = ""
        Me.txtPurchPrice.Text = ""
        Me.txtSalePrice.Text = ""
        Me.txtPurchDollar.Text = ""
        Me.txtSaleDollar.Text = ""
        Me.txtMinPrice.Text = ""
        Me.txtLimit.Text = "0"
        Me.txtDiscount.Text = ""
        Me.chkOutOffer.Checked = False
        Me.txtNote.Text = ""
        Me.txtOperateNo.Text = ""
        Me.chkTab3.Checked = False
        Me.GetTaxVal()
        Me.cmbUnit.SelectedIndex = -1
        Me.picImage.Image = Nothing
        Me.txtPicPath.Text = ""
        Me.dgvFirst.Rows.Clear()
        Me.dgvSafeBalance.Rows.Clear()
        Me.dgvUnits.Rows.Clear()
        Me.dgvComponents.Rows.Clear()
        Me._purch1 = True
        Me._sale1 = True
        Me.Code = -1
    End Sub

    Private Function GetGroupName(group As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from groups where id=" + Conversions.ToString(group), Me.conn)
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

    Private Sub LoadDG(_cond As String)
        Me.dgvCurrencies.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Currencies.id as currency_id,Currencies.symbol,Currencies.nameEN,barcode,groups.name as groupname,purch_price,sale_price,tax from Currencies,groups  where " + _cond + " Currencies.group_id=groups.id and Currencies.IS_Deleted=0 order by Currencies.id", Me.conn)
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
            Me.dgvCurrencies.Rows.Add()
            Me.dgvCurrencies.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency_id"))
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
            If flag Then
                Me.dgvCurrencies.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("symbol"))
            Else
                Me.dgvCurrencies.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nameEN"))
            End If
            Me.dgvCurrencies.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("barcode"))
            Try
                Me.dgvCurrencies.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("groupname"))
            Catch ex As Exception
            End Try
            Try
                Me.dgvCurrencies.Rows(num3).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("purch_price"))))
                Me.dgvCurrencies.Rows(num3).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))))
            Catch ex2 As Exception
            End Try
            Try
                Me.dgvCurrencies.Rows(num3).Cells(6).Value = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("tax")))) + " %"
                Me.dgvCurrencies.Rows(num3).Cells(7).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("tax"))) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price")))
            Catch ex3 As Exception
            End Try
            num3 += 1
        End While
        Me.dgvCurrencies.ClearSelection()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub LoadUnits()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from units order by id", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvUnits.Columns(0), DataGridViewComboBoxColumn)
            dataGridViewComboBoxColumn.DataSource = dataTable
            dataGridViewComboBoxColumn.DisplayMember = "name"
            dataGridViewComboBoxColumn.ValueMember = "id"
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Me.cmbUnit.DataSource = dataTable2
            Me.cmbUnit.DisplayMember = "name"
            Me.cmbUnit.ValueMember = "id"
            Me.cmbUnit.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadSafes()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where branch=" + Conversions.ToString(MainClass.BranchNo) + " and status=1 and is_deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvSafeBalance.Columns(0), DataGridViewComboBoxColumn)
        dataGridViewComboBoxColumn.DataSource = dataTable
        dataGridViewComboBoxColumn.DisplayMember = "name"
        dataGridViewComboBoxColumn.ValueMember = "id"
        Dim dataTable2 As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable2)
        Dim dataGridViewComboBoxColumn2 As DataGridViewComboBoxColumn = CType(Me.dgvFirst.Columns(0), DataGridViewComboBoxColumn)
        dataGridViewComboBoxColumn2.DataSource = dataTable2
        dataGridViewComboBoxColumn2.DisplayMember = "name"
        dataGridViewComboBoxColumn2.ValueMember = "id"
    End Sub

    Public Sub LoadGroups()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from groups order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbGroups.DataSource = dataTable
        Me.cmbGroups.DisplayMember = "name"
        Me.cmbGroups.ValueMember = "id"
        Me.cmbGroups.SelectedIndex = -1
    End Sub

    Public Sub LoadTaxGroups()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,nameAR from tax_groups order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbTaxGroup.DataSource = dataTable
        Me.cmbTaxGroup.DisplayMember = "nameAR"
        Me.cmbTaxGroup.ValueMember = "id"
        Me.cmbTaxGroup.SelectedIndex = -1
    End Sub

    Private Sub LoadNextNo()
        Try
            Dim value As Integer = 1
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Currencies", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
                If flag2 Then
                    ' The following expression was wrapped in a checked-expression
                    ' The following expression was wrapped in a unchecked-expression
                    value = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
                End If
            End If
            Me.txtNo.Text = "" + Conversions.ToString(value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetTaxVal()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select tax from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax")))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CalcCostPrice()
        Try
            Dim num As Double = 0.0
            Dim num2 As Integer = 0
            Dim num3 As Integer = Me.dgvComponents.Rows.Count - 1
            Dim num4 As Integer = num2
            While True
                Dim num5 As Integer = num4
                Dim num6 As Integer = num3
                If num5 > num6 Then
                    Exit While
                End If
                num += Conversion.Val(Operators.ConcatenateObject("", Me.dgvComponents.Rows(num4).Cells(3).Value))
                num4 += 1
            End While
            Me.txtPurchPrice.Text = Conversions.ToString(Math.Round(num, 2))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvComponents_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvComponents.CellValueChanged
        Try
            Dim flag As Boolean = e.ColumnIndex = 0
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select units.id,units.name from currencies,units where currencies.unit=units.id and currencies.id=", Me.dgvComponents.Rows(e.RowIndex).Cells(0).Value), "union select units.id,units.name from curr_units,units where curr_units.unit=units.id and curr="), Me.dgvComponents.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me.dgvComponents.Rows(e.RowIndex).Cells(1), DataGridViewComboBoxCell)
                dataGridViewComboBoxCell.DataSource = dataTable
                dataGridViewComboBoxCell.DisplayMember = "name"
                dataGridViewComboBoxCell.ValueMember = "id"
            Else
                flag = (e.ColumnIndex = 1 Or e.ColumnIndex = 2)
                If flag Then
                    Try
                        Dim num As Double = 1.0
                        Dim num2 As Double = 0.0
                        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select unit,purch_price from currencies where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(e.RowIndex).Cells(0).Value)), Me.conn1)
                        Dim dataTable2 As DataTable = New DataTable()
                        sqlDataAdapter2.Fill(dataTable2)
                        flag = (dataTable2.Rows.Count > 0)
                        If flag Then
                            num2 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
                            flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))) <> Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(e.RowIndex).Cells(1).Value)))
                            If flag Then
                                sqlDataAdapter2 = New SqlDataAdapter("select perc from curr_units where curr=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(e.RowIndex).Cells(0).Value)) + " and unit=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(e.RowIndex).Cells(1).Value)), Me.conn1)
                                dataTable2 = New DataTable()
                                sqlDataAdapter2.Fill(dataTable2)
                                flag = (dataTable2.Rows.Count > 0)
                                If flag Then
                                    num = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
                                End If
                            End If
                        End If
                        Me.dgvComponents.Rows(e.RowIndex).Cells(3).Value = num * num2 * Conversion.Val(Operators.ConcatenateObject("", Me.dgvComponents.Rows(e.RowIndex).Cells(2).Value))
                        Me.CalcCostPrice()
                    Catch ex As Exception
                    End Try
                End If
            End If
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub LoadMaterials()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from currencies where type=2 and is_deleted=0 order by id", Me.conn1)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvComponents.Columns(0), DataGridViewComboBoxColumn)
            dataGridViewComboBoxColumn.DataSource = dataTable
            dataGridViewComboBoxColumn.DisplayMember = "symbol"
            dataGridViewComboBoxColumn.ValueMember = "id"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmcurrency_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmcurrency.Load
        Me.cmbItemType.SelectedIndex = 0
        Me.TabControl1.TabPages.Remove(Me.TabPage4)
        Me.LoadNextNo()
        Me.LoadSafes()
        Me.LoadGroups()
        Me.LoadTaxGroups()
        Me.LoadUnits()
        Me.LoadMaterials()
        Me.GetTaxVal()
        Me.LoadDG("")
        Me.WindowState = MainClass.Window_State
        Me.txtBarcode.Focus()
        Me.txtBarcode.RightToLeft = RightToLeft.No
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Try
                    Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)("Exchangeval").ToString(), "", False) <> 0
                    If flag2 Then
                        Me._Exchangeal = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Exchangeval")))
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim flag2 As Boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3_items")))
                    If flag2 Then
                        Me.chkTab3.Visible = True
                    End If
                Catch ex2 As Exception
                End Try
            End If
        Catch ex3 As Exception
        End Try
        Try
            Dim flag2 As Boolean = MainClass.hide_manfc
            If flag2 Then
                Me.Label19.Visible = False
                Me.cmbItemType.Visible = False
            End If
        Catch ex4 As Exception
        End Try
    End Sub

    Private Sub AddFirstStock()
        Dim num As Integer = 0
        Dim num2 As Integer = Me.dgvFirst.Rows.Count - 2
        Dim num3 As Integer = num
        While True
            Dim num4 As Integer = num3
            Dim num5 As Integer = num2
            If num4 > num5 Then
                Exit While
            End If
            Try
                Dim str As String = ""
                Dim flag As Boolean = MainClass.BranchNo <> -1
                If flag Then
                    str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
                End If
                flag = (Me.conn1.State <> ConnectionState.Open)
                If flag Then
                    Me.conn1.Open()
                End If
                Dim sqlTransaction As SqlTransaction = Me.conn1.BeginTransaction()
                Dim sqlCommand As SqlCommand = New SqlCommand()
                Dim num6 As Integer = 0
                Dim num7 As Integer = 0
                flag = (Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(1).Value)) <> 0.0)
                If flag Then
                    sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn1, sqlTransaction)
                    num6 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
                End If
                Dim num8 As Integer = 1
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and proc_type=3", Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Try
                        ' The following expression was wrapped in a unchecked-expression
                        num8 = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
                    Catch ex As Exception
                    End Try
                End If
                Dim num9 As Integer = -1
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id from Customers where IS_Deleted=0 order by id", Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    num9 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))))
                End If
                Dim num10 As Integer = -1
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select id from Stocks where IS_Deleted=0 order by id", Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag = (dataTable3.Rows.Count > 0)
                If flag Then
                    num10 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))))
                End If
                sqlCommand = New SqlCommand("insert into Inv(proc_type,id,date,inv_type,safe,stock,cust_id,sales_emp,tot_purch,tot_sale,tot_net,paid,minus,purch_rest_id,sale_rest_id,InvId_Return,branch,IS_Buy,IS_Deleted)values(@proc_type,@id,@date,@inv_type,@safe,@stock,@cust_id,@sales_emp,@tot_purch,@tot_sale,@tot_net,@paid,@minus,@purch_rest_id,@sale_rest_id,@InvId_Return,@branch,@IS_Buy,@IS_Deleted)", Me.conn1, sqlTransaction)
                sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 3
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num8
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
                sqlCommand.Parameters.Add("@inv_type", SqlDbType.Int).Value = 1
                sqlCommand.Parameters.Add("@safe", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(0).Value)
                sqlCommand.Parameters.Add("@stock", SqlDbType.Int).Value = num10
                sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = num9
                sqlCommand.Parameters.Add("@sales_emp", SqlDbType.Int).Value = MainClass.EmpNo
                sqlCommand.Parameters.Add("@tot_purch", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(3).Value)
                sqlCommand.Parameters.Add("@tot_sale", SqlDbType.Float).Value = 0
                sqlCommand.Parameters.Add("@tot_net", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(3).Value)
                sqlCommand.Parameters.Add("@paid", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(3).Value)
                sqlCommand.Parameters.Add("@minus", SqlDbType.Float).Value = 0
                sqlCommand.Parameters.Add("@purch_rest_id", SqlDbType.Int).Value = num6
                sqlCommand.Parameters.Add("@sale_rest_id", SqlDbType.Int).Value = num7
                sqlCommand.Parameters.Add("@InvId_Return", SqlDbType.Int).Value = -1
                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                sqlCommand.Parameters.Add("@IS_Buy", SqlDbType.Bit).Value = 1
                sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                sqlCommand.Parameters.Add("@salesman", SqlDbType.Int).Value = -1
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("select max(proc_id) from Inv", Me.conn1, sqlTransaction)
                Dim num11 As Integer = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                sqlCommand = New SqlCommand("insert into Inv_Sub(proc_id,proc_type,currency_from,unit,val,val1,exchange_price)values(@proc_id,@proc_type,@currency_from,@unit,@val,@val1,@exchange_price)", Me.conn1, sqlTransaction)
                sqlCommand.Parameters.Add("@proc_id", SqlDbType.Int).Value = num11
                sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 1
                sqlCommand.Parameters.Add("@currency_from", SqlDbType.Int).Value = Me.txtNo.Text
                sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = -1
                sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(1).Value)
                sqlCommand.Parameters.Add("@val1", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(1).Value)
                sqlCommand.Parameters.Add("@exchange_price", SqlDbType.Float).Value = Me.txtPurchPrice.Text
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn1, sqlTransaction)
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num6
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = num8
                sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 9
                sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn1, sqlTransaction)
                sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num6
                sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = 0
                sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(2).Value)
                sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = 2120001
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                sqlCommand.ExecuteNonQuery()
                sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn1, sqlTransaction)
                sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num6
                sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(num3).Cells(2).Value)
                sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = 0
                sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = 1270001
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                sqlCommand.ExecuteNonQuery()
                sqlTransaction.Commit()
            Catch ex2 As Exception
                Dim sqlTransaction As SqlTransaction
                sqlTransaction.Rollback()
                Dim text As String = "خطأ حفظ مخزون أول المدة"
                text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
                MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Finally
                Dim flag As Boolean = Me.conn1.State <> ConnectionState.Closed
                If flag Then
                    Me.conn1.Close()
                End If
            End Try
            num3 += 1
        End While
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Me.txtBarcode.Focus()
            Dim flag As Boolean = Operators.CompareString(Me.txtNo.Text.Trim(), "", False) = 0
            If flag Then
                flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                Dim text As String
                If flag Then
                    text = "ادخل رقم الصنف"
                Else
                    text = "Enter item No."
                End If
                MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtNo.Focus()
            Else
                flag = (Me.Code = -1)
                If flag Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Currencies where id=" + Me.txtNo.Text, Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag = (dataTable.Rows.Count > 0)
                    If flag Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        Dim text2 As String
                        If flag Then
                            text2 = "رقم الصنف تم ادخاله مسبقا"
                        Else
                            text2 = "item No. is previously inserted"
                        End If
                        MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txtNo.Focus()
                        Return
                    End If
                End If
                flag = (Me.cmbGroups.SelectedValue Is Nothing)
                If flag Then
                    flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    Dim text3 As String
                    If flag Then
                        text3 = "اختر مجموعة الصنف"
                    Else
                        text3 = "choose the item group"
                    End If
                    MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbGroups.Focus()
                Else
                    flag = (Me.cmbUnit.SelectedValue Is Nothing)
                    If flag Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        Dim text4 As String
                        If flag Then
                            text4 = "اختر الوحدة الافتراضية"
                        Else
                            text4 = "choose the default unit"
                        End If
                        MessageBox.Show(text4, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.cmbUnit.Focus()
                    Else
                        flag = (Operators.CompareString(Me.txtSymbol.Text.Trim(), "", False) = 0)
                        If flag Then
                            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            Dim text5 As String
                            If flag Then
                                text5 = "ادخل اسم الصنف"
                            Else
                                text5 = "Enter item name"
                            End If
                            MessageBox.Show(text5, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Me.txtSymbol.Focus()
                        Else
                            Dim flag2 As Boolean
                            Try
                                flag = (Me.Code = -1)
                                If flag Then
                                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter()
                                    Dim dataTable2 As DataTable = New DataTable()
                                    flag = (Operators.CompareString(Me.txtBarcode.Text.Trim(), "", False) <> 0)
                                    If flag Then
                                        sqlDataAdapter2 = New SqlDataAdapter("select barcode from Currencies where is_deleted=0 and barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
                                        dataTable2 = New DataTable()
                                        sqlDataAdapter2.Fill(dataTable2)
                                        flag = (dataTable2.Rows.Count > 0)
                                        If flag Then
                                            flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                                            If flag2 Then
                                                Interaction.MsgBox("تم ادخال رقم الباركود هذا من قبل", MsgBoxStyle.OkOnly, Nothing)
                                            Else
                                                Interaction.MsgBox("Barcode saved before", MsgBoxStyle.OkOnly, Nothing)
                                            End If
                                            Me.txtBarcode.Focus()
                                            Return
                                        End If
                                        sqlDataAdapter2 = New SqlDataAdapter("select curr_units.barcode from Currencies,curr_units where Currencies.id=curr_units.curr and is_deleted=0 and curr_units.barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
                                        dataTable2 = New DataTable()
                                        sqlDataAdapter2.Fill(dataTable2)
                                        flag2 = (dataTable2.Rows.Count > 0)
                                        If flag2 Then
                                            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                                            If flag Then
                                                Interaction.MsgBox("تم ادخال رقم الباركود هذا من قبل لوحدات الأصناف", MsgBoxStyle.OkOnly, Nothing)
                                            Else
                                                Interaction.MsgBox("Barcode saved before for one of item units", MsgBoxStyle.OkOnly, Nothing)
                                            End If
                                            Me.txtBarcode.Focus()
                                            Return
                                        End If
                                    End If
                                    Try
                                        Dim num As Integer = 0
                                        Dim num2 As Integer = Me.dgvUnits.Rows.Count - 2
                                        Dim num3 As Integer = num
                                        While True
                                            Dim num4 As Integer = num3
                                            Dim num5 As Integer = num2
                                            If num4 > num5 Then
                                                GoTo Block_49
                                            End If
                                            flag2 = (Operators.CompareString(Me.dgvUnits.Rows(num3).Cells(4).Value.ToString(), "", False) <> 0)
                                            If flag2 Then
                                                sqlDataAdapter2 = New SqlDataAdapter("select barcode from Currencies where is_deleted=0 and barcode='" + Me.dgvUnits.Rows(num3).Cells(4).Value.ToString() + "'", Me.conn1)
                                                dataTable2 = New DataTable()
                                                sqlDataAdapter2.Fill(dataTable2)
                                                flag2 = (dataTable2.Rows.Count > 0)
                                                If flag2 Then
                                                    Exit While
                                                End If
                                                sqlDataAdapter2 = New SqlDataAdapter("select curr_units.barcode from Currencies,curr_units where Currencies.id=curr_units.curr and is_deleted=0 and curr_units.barcode='" + Me.dgvUnits.Rows(num3).Cells(4).Value.ToString() + "'", Me.conn1)
                                                dataTable2 = New DataTable()
                                                sqlDataAdapter2.Fill(dataTable2)
                                                flag2 = (dataTable2.Rows.Count > 0)
                                                If flag2 Then
                                                    GoTo Block_47
                                                End If
                                            End If
                                            num3 += 1
                                        End While
                                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                                        If flag Then
                                            Interaction.MsgBox("تم ادخال رقم الباركود هذا من قبل", MsgBoxStyle.OkOnly, Nothing)
                                        Else
                                            Interaction.MsgBox("Barcode saved before", MsgBoxStyle.OkOnly, Nothing)
                                        End If
                                        Me.dgvUnits.Rows(num3).Selected = True
                                        Return
Block_47:
                                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                                        If flag Then
                                            Interaction.MsgBox("تم ادخال رقم الباركود هذا من قبل", MsgBoxStyle.OkOnly, Nothing)
                                        Else
                                            Interaction.MsgBox("Barcode saved before", MsgBoxStyle.OkOnly, Nothing)
                                        End If
                                        Me.dgvUnits.Rows(num3).Selected = True
                                        Return
Block_49:
                                    Catch ex As Exception
                                    End Try
                                End If
                            Catch ex2 As Exception
                            End Try
                            Try
                                Dim num6 As Integer = 0
                                Dim num7 As Integer = Me.dgvUnits.Rows.Count - 2
                                Dim num8 As Integer = num6
                                Dim num12 As Integer
                                While True
                                    Dim num9 As Integer = num8
                                    Dim num5 As Integer = num7
                                    If num9 > num5 Then
                                        GoTo Block_56
                                    End If
                                    flag2 = Operators.ConditionalCompareObjectEqual(Me.dgvUnits.Rows(num8).Cells(0).Value, Me.cmbUnit.SelectedValue, False)
                                    If flag2 Then
                                        Exit While
                                    End If
                                    flag2 = (num8 <> Me.dgvUnits.Rows.Count - 2)
                                    If flag2 Then
                                        Dim num10 As Integer = num8 + 1
                                        Dim num11 As Integer = Me.dgvUnits.Rows.Count - 2
                                        num12 = num10
                                        While True
                                            Dim num13 As Integer = num12
                                            num5 = num11
                                            If num13 > num5 Then
                                                Exit While
                                            End If
                                            flag = Operators.ConditionalCompareObjectEqual(Me.dgvUnits.Rows(num8).Cells(0).Value, Me.dgvUnits.Rows(num12).Cells(0).Value, False)
                                            If flag Then
                                                GoTo Block_55
                                            End If
                                            num12 += 1
                                        End While
                                    End If
                                    num8 += 1
                                End While
                                Me.TabControl1.SelectedIndex = 1
                                Me.dgvUnits.Rows(num8).Selected = True
                                Interaction.MsgBox("لقد تم ادخال الوحدة هذه كوحدة أساسية", MsgBoxStyle.OkOnly, Nothing)
                                Return
Block_55:
                                Me.TabControl1.SelectedIndex = 1
                                Me.dgvUnits.Rows(num12).Selected = True
                                Interaction.MsgBox("لقد تم تكرار ادخال الوحدة هذه كوحدة فرعية", MsgBoxStyle.OkOnly, Nothing)
                                Return
Block_56:
                            Catch ex3 As Exception
                            End Try
                            Dim num14 As Integer = 0
                            flag2 = Me.chkTab3.Checked
                            If flag2 Then
                                num14 = 1
                            End If
                            flag2 = (Me.conn.State <> ConnectionState.Open)
                            If flag2 Then
                                Me.conn.Open()
                            End If
                            Dim sqlTransaction As SqlTransaction = Me.conn.BeginTransaction()
                            Dim sqlCommand As SqlCommand = New SqlCommand()
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                sqlCommand = New SqlCommand("insert into Currencies(id,symbol,nameEN,barcode,is_mezan,group_id,unit,purch_price,sale_price,limit,discount,tax_group,tax,type,IS_Deleted,img,minprice,outoffer,operate_no,notes,is_tab3)values(@id,@symbol,@nameEN,@barcode,@is_mezan,@group_id,@unit,@purch_price,@sale_price,@limit,@discount,@tax_group,@tax,@type,@IS_Deleted,@img,@minprice,@outoffer,@operate_no,@notes,@is_tab3)", Me.conn, sqlTransaction)
                            Else
                                sqlCommand = New SqlCommand("update Currencies set symbol=@symbol,nameEN=@nameEN,barcode=@barcode,is_mezan=@is_mezan,group_id=@group_id,unit=@unit,purch_price=@purch_price,sale_price=@sale_price,limit=@limit,discount=@discount,tax_group=@tax_group,tax=@tax,type=@type,IS_Deleted=@IS_Deleted,img=@img,minprice=@minprice,outoffer=@outoffer,operate_no=@operate_no,notes=@notes,is_tab3=@is_tab3  where id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
                            End If
                            Dim num15 As Integer = 0
                            flag2 = Me.chkMezan.Checked
                            If flag2 Then
                                num15 = 1
                            End If
                            Dim num16 As Integer = 0
                            flag2 = Me.chkOutOffer.Checked
                            If flag2 Then
                                num16 = 1
                            End If
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = Me.txtNo.Text
                            End If
                            sqlCommand.Parameters.Add("@symbol", SqlDbType.NVarChar).Value = Me.txtSymbol.Text
                            sqlCommand.Parameters.Add("@nameEN", SqlDbType.NVarChar).Value = Me.txtNameEN.Text
                            sqlCommand.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = Me.txtBarcode.Text
                            sqlCommand.Parameters.Add("@is_mezan", SqlDbType.Bit).Value = num15
                            sqlCommand.Parameters.Add("@group_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbGroups.SelectedValue)
                            sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbUnit.SelectedValue)
                            sqlCommand.Parameters.Add("@purch_price", SqlDbType.Float).Value = Conversion.Val(Me.txtPurchPrice.Text)
                            sqlCommand.Parameters.Add("@sale_price", SqlDbType.Float).Value = Conversion.Val(Me.txtSalePrice.Text)
                            sqlCommand.Parameters.Add("@limit", SqlDbType.Int).Value = Conversion.Val(Me.txtLimit.Text)
                            sqlCommand.Parameters.Add("@discount", SqlDbType.Float).Value = Conversion.Val(Me.txtDiscount.Text)
                            Dim num17 As Integer = -1
                            flag2 = (Me.cmbTaxGroup.SelectedValue IsNot Nothing)
                            If flag2 Then
                                num17 = Conversions.ToInteger(Me.cmbTaxGroup.SelectedValue)
                            End If
                            sqlCommand.Parameters.Add("@tax_group", SqlDbType.Int).Value = num17
                            sqlCommand.Parameters.Add("@tax", SqlDbType.Float).Value = Conversion.Val(Me.txtTax.Text)
                            sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = Me.cmbItemType.SelectedIndex + 1
                            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                            flag2 = (Me.picImage.Image IsNot Nothing)
                            If flag2 Then
                                sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picImage.Image)
                            Else
                                sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value
                            End If
                            sqlCommand.Parameters.Add("@minprice", SqlDbType.Float).Value = Conversion.Val(Me.txtMinPrice.Text)
                            sqlCommand.Parameters.Add("@outoffer", SqlDbType.Bit).Value = num16
                            sqlCommand.Parameters.Add("@operate_no", SqlDbType.NVarChar).Value = Me.txtOperateNo.Text
                            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNote.Text
                            sqlCommand.Parameters.Add("@is_tab3", SqlDbType.Bit).Value = num14
                            sqlCommand.ExecuteNonQuery()
                            flag2 = (Me.Code <> -1)
                            If flag2 Then
                                sqlCommand = New SqlCommand("delete from curr_units where curr=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
                                sqlCommand.ExecuteNonQuery()
                            End If
                            Dim num18 As Integer = 0
                            Dim num19 As Integer = Me.dgvUnits.Rows.Count - 2
                            Dim num20 As Integer = num18
                            While True
                                Dim num21 As Integer = num20
                                Dim num5 As Integer = num19
                                If num21 > num5 Then
                                    Exit While
                                End If
                                sqlCommand = New SqlCommand("insert into curr_units(curr,unit,perc,purch,sale,barcode)values(@curr,@unit,@perc,@purch,@sale,@barcode)", Me.conn, sqlTransaction)
                                sqlCommand.Parameters.Add("@curr", SqlDbType.Int).Value = Conversion.Val(Me.txtNo.Text)
                                sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvUnits.Rows(num20).Cells(0).Value))
                                sqlCommand.Parameters.Add("@perc", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvUnits.Rows(num20).Cells(1).Value))
                                sqlCommand.Parameters.Add("@purch", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvUnits.Rows(num20).Cells(2).Value))
                                sqlCommand.Parameters.Add("@sale", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvUnits.Rows(num20).Cells(3).Value))
                                sqlCommand.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dgvUnits.Rows(num20).Cells(4).Value)
                                sqlCommand.ExecuteNonQuery()
                                num20 += 1
                            End While
                            flag2 = (Me.cmbItemType.SelectedIndex = 2)
                            If flag2 Then
                                flag = (Me.Code <> -1)
                                If flag Then
                                    sqlCommand = New SqlCommand("delete from item_comp where item_id=" + Convert.ToString(Me.Code), Me.conn, sqlTransaction)
                                    sqlCommand.ExecuteNonQuery()
                                End If
                                Dim num22 As Integer = 0
                                Dim num23 As Integer = Me.dgvComponents.Rows.Count - 2
                                Dim num24 As Integer = num22
                                While True
                                    Dim num25 As Integer = num24
                                    Dim num5 As Integer = num23
                                    If num25 > num5 Then
                                        Exit While
                                    End If
                                    sqlCommand = New SqlCommand("insert into item_comp(item_id,mat_id,mat_unit,mat_quan,mat_quantot)values(@item_id,@mat_id,@mat_unit,@mat_quan,@mat_quantot)", Me.conn, sqlTransaction)
                                    sqlCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = Conversion.Val(Me.txtNo.Text)
                                    sqlCommand.Parameters.Add("@mat_id", SqlDbType.Int).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(0).Value)))
                                    sqlCommand.Parameters.Add("@mat_unit", SqlDbType.Int).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(1).Value)))
                                    sqlCommand.Parameters.Add("@mat_quan", SqlDbType.Float).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(2).Value)))
                                    Dim num26 As Double = 1.0
                                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select unit from currencies where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(0).Value)), Me.conn1)
                                    Dim dataTable3 As DataTable = New DataTable()
                                    sqlDataAdapter3.Fill(dataTable3)
                                    flag2 = (dataTable3.Rows.Count > 0)
                                    If flag2 Then
                                        flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))) <> Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(1).Value)))
                                        If flag Then
                                            sqlDataAdapter3 = New SqlDataAdapter("select perc from curr_units where curr=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(0).Value)) + " and unit=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(1).Value)), Me.conn1)
                                            dataTable3 = New DataTable()
                                            sqlDataAdapter3.Fill(dataTable3)
                                            flag2 = (dataTable3.Rows.Count > 0)
                                            If flag2 Then
                                                num26 = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
                                            End If
                                        End If
                                    End If
                                    sqlCommand.Parameters.Add("@mat_quantot", SqlDbType.Float).Value = Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvComponents.Rows(num24).Cells(2).Value))) * num26
                                    sqlCommand.ExecuteNonQuery()
                                    num24 += 1
                                End While
                            End If
                            sqlTransaction.Commit()
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                flag = -(Me.dgvFirst.Rows.Count > 1 > False)
                                If flag Then
                                    Me.AddFirstStock()
                                End If
                            End If
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                Me.CLR()
                                Me.txtBarcode.Focus()
                            End If
                            Me.LoadDG("")
                            Me.LoadMaterials()
                            flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag2 Then
                                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Else
                                MessageBox.Show("saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex4 As Exception
            Dim sqlTransaction As SqlTransaction
            sqlTransaction.Rollback()
            Dim text6 As String = "خطأ أثناء الحفظ"
            text6 = text6 + Environment.NewLine + "تفاصيل الخطأ: " + ex4.Message
            Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag2 Then
                text6 = "error in saving"
                text6 = text6 + Environment.NewLine + "error details: " + ex4.Message
            End If
            MessageBox.Show(text6, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Try
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(*) from inv,inv_sub where inv.proc_id=inv_sub.proc_id and is_deleted=0 and currency_from=" + Conversions.ToString(Me.Code), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
                    If flag Then
                        Interaction.MsgBox("هذا الصنف مرتبط بفواتير ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
                        Return
                    End If
                Catch ex As Exception
                End Try
                Dim dialogResult As DialogResult = MessageBox.Show("هل متأكد من حذف الصنف؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                flag = (dialogResult = DialogResult.No)
                If Not flag Then
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand("update Currencies set symbol='" + Me.txtSymbol.Text + "(محذوف)' ,barcode='',IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    If flag Then
                        MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        MessageBox.Show("deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                    Me.LoadDG("")
                    Me.CLR()
                End If
            Else
                MessageBox.Show("اختر صنف ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex2 As Exception
            Dim text As String = "خطأ أثناء الحذف"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag Then
                text = "error in delete"
                text = text + Environment.NewLine + "error details: " + ex2.Message
            End If
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", Me.dgvCurrencies.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Currencies where id=" + Conversions.ToString(Me.Code))
    End Sub

    Private Sub dgvCurrencies_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCurrencies.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgvRowChng(e.RowIndex)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim flag As Boolean = dr.HasRows
        If flag Then
            dr.Read()
            Me.CLR()
            Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dr("id")))))
            Me.txtNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("id")))
            Me.txtSymbol.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("symbol")))
            Try
                Me.txtNameEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("nameEN")))
            Catch ex As Exception
            End Try
            Me.txtBarcode.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("barcode")))
            Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dr("group_id"))
            Try
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_mezan")))
                If flag Then
                    Me.chkMezan.Checked = True
                End If
            Catch ex2 As Exception
            End Try
            Try
                Me.cmbUnit.SelectedValue = RuntimeHelpers.GetObjectValue(dr("unit"))
            Catch ex3 As Exception
            End Try
            Try
                Me.txtPurchPrice.Text = String.Format("{0:0.#,##.##}", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr("purch_price"))))
                Me.txtSalePrice.Text = String.Format("{0:0.#,##.##}", Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dr("sale_price"))))
            Catch ex4 As Exception
            End Try
            Try
                Me.txtDiscount.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("discount")))
            Catch ex5 As Exception
            End Try
            Try
                Me.cmbTaxGroup.SelectedValue = RuntimeHelpers.GetObjectValue(dr("tax_group"))
            Catch ex6 As Exception
            End Try
            Try
                Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tax")))
            Catch ex7 As Exception
            End Try
            Me.txtLimit.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("limit")))
            Try
                Me.cmbItemType.SelectedIndex = 0
                Me.cmbItemType.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("type"))) - 1
                flag = (Me.cmbItemType.SelectedIndex = 2)
                If flag Then
                    Me.dgvComponents.Rows.Clear()
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from item_comp where item_id=" + Me.txtNo.Text, Me.conn1)
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
                        Me.dgvComponents.Rows.Add()
                        Me.dgvComponents.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mat_id"))
                        Me.dgvComponents.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mat_unit"))
                        Me.dgvComponents.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mat_quan"))
                        num3 += 1
                    End While
                End If
            Catch ex8 As Exception
            End Try
            Try
                Me.txtMinPrice.Text = Conversions.ToString(dr("minprice"))
            Catch ex9 As Exception
            End Try
            Try
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("outoffer")))
                    If flag Then
                        Me.chkOutOffer.Checked = True
                    End If
                Catch ex10 As Exception
                End Try
            Catch ex11 As Exception
            End Try
            Try
                Me.txtNote.Text = Conversions.ToString(dr("notes"))
            Catch ex12 As Exception
            End Try
            Me.txtNo.[ReadOnly] = True
            Try
                flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr("img")))
                If flag Then
                    Me.picImage.Image = MainClass.Arr2Image(CType(dr("img"), Byte()))
                End If
            Catch ex13 As Exception
            End Try
            Try
                Me.txtOperateNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("operate_no")))
            Catch ex14 As Exception
            End Try
            Try
                Me.chkTab3.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_tab3")))
            Catch ex15 As Exception
            End Try
            dr.Close()
            Me.dgvUnits.Rows.Clear()
            Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from curr_units where curr=" + Me.txtNo.Text, Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter2.Fill(dataTable2)
            Dim num6 As Integer = 0
            Dim num7 As Integer = dataTable2.Rows.Count - 1
            Dim num8 As Integer = num6
            While True
                Dim num9 As Integer = num8
                Dim num5 As Integer = num7
                If num9 > num5 Then
                    Exit While
                End If
                Me.dgvUnits.Rows.Add()
                Me.dgvUnits.Rows(num8).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)("unit"))
                Me.dgvUnits.Rows(num8).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)("perc"))
                Me.dgvUnits.Rows(num8).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)("purch"))
                Me.dgvUnits.Rows(num8).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)("sale"))
                Me.dgvUnits.Rows(num8).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)("barcode"))
                num8 += 1
            End While
            Me.CalcStock()
        End If
    End Sub

    Private Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("currency")
            dataTable.Columns.Add("sum")
            dataTable.Columns.Add("type")
            dataTable.Columns.Add("invtype")
            Dim selectCommandText As String = "select id,symbol from Currencies where id=" + Me.txtNo.Text
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim str As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Me.dgvSafeBalance.Rows.Clear()
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable2.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where branch=" + Conversions.ToString(MainClass.BranchNo) + " and status=1 and IS_Deleted=0", Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                Dim num6 As Integer = 0
                Dim count As Integer = dataTable3.Rows.Count
                Dim num7 As Integer = num6
                While True
                    Dim num8 As Integer = num7
                    num5 = count
                    If num8 > num5 Then
                        Exit While
                    End If
                    Dim num9 As Double = 0.0
                    Dim num10 As Double = 0.0
                    Dim num11 As Double = 0.0
                    Dim num12 As Double = 0.0
                    Dim num13 As Double = 0.0
                    Dim num14 As Double = 0.0
                    Dim num15 As Double = 0.0
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable3.Rows(num7)(0)), " and IS_Deleted=0 ")), Me.conn)
                    Dim dataTable4 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num9 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable3.Rows(num7)(0)), " and IS_Deleted=0 ")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num10 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable3.Rows(num7)(0)), " and IS_Deleted=0 ")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num11 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable3.Rows(num7)(0)), " and IS_Deleted=0 ")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num12 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable2.Rows(num3)("id")), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe="), dataTable3.Rows(num7)(0)), " and IS_Deleted=0 ")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num13 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + str + " SafesTransfer.safe_to=", dataTable3.Rows(num7)(0)), " and currency="), dataTable2.Rows(num3)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num14 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + str + " SafesTransfer.safe_from=", dataTable3.Rows(num7)(0)), " and currency="), dataTable2.Rows(num3)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0")), Me.conn)
                    dataTable4 = New DataTable()
                    sqlDataAdapter3.Fill(dataTable4)
                    flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num15 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    End If
                    Dim num16 As Double = num9 + num10 - num11 - num12 + num13 + num14 - num15
                    flag = (num16 <> 0.0)
                    If flag Then
                        Me.dgvSafeBalance.Rows.Add()
                        Me.dgvSafeBalance.Rows(Me.dgvSafeBalance.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num7)(0))
                        Me.dgvSafeBalance.Rows(Me.dgvSafeBalance.Rows.Count - 1).Cells(1).Value = num16
                    End If
                    num7 += 1
                End While
                num3 += 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvCurrencies.ClearSelection()
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

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Me.Navigate("select top 1 * from Currencies where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Currencies where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Currencies where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Currencies where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub txtNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNo.KeyPress
    End Sub

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvCurrencies.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("DataColumn1")
            dataTable.Columns.Add("DataColumn11")
            dataTable.Columns.Add("DataColumn12")
            dataTable.Columns.Add("doctype")
            dataTable.Columns.Add("safe")
            dataTable.Columns.Add("price")
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("total")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvCurrencies.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num3).Cells(7).Value)})
                num3 += 1
            End While
            Dim rptItems As rptItems = New rptItems()
            rptItems.SetDataSource(dataTable)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptItems.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject As TextObject = CType(rptItems.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject2 As TextObject = CType(rptItems.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject3 As TextObject = CType(rptItems.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject4 As TextObject = CType(rptItems.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptItems
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptItems.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcode.TextChanged
    End Sub

    Private Sub txtSymbol_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSymbol.TextChanged
    End Sub

    Private Sub txtPurchPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurchPrice.TextChanged
        Try
            Dim purch As Boolean = Me._purch1
            If purch Then
                Me.txtPurchDollar.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtPurchPrice.Text) / Me._Exchangeal, 2))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSalePrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSalePrice.TextChanged
        Try
            Dim sale As Boolean = Me._sale1
            If sale Then
                Me.txtSaleDollar.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtSalePrice.Text) / Me._Exchangeal, 2))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPurchPrice_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurchPrice.Enter
        Me._purch1 = True
        Me._purch2 = False
    End Sub

    Private Sub txtPurchDollar_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurchDollar.Enter
        Me._purch1 = False
        Me._purch2 = True
    End Sub

    Private Sub txtSalePrice_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtSalePrice.Enter
        Me._sale1 = True
        Me._sale2 = False
    End Sub

    Private Sub txtSaleDollar_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtSaleDollar.Enter
        Me._sale1 = False
        Me._sale2 = True
    End Sub

    Private Sub txtPurchDollar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPurchDollar.TextChanged
        Try
            Dim purch As Boolean = Me._purch2
            If purch Then
                Me.txtPurchPrice.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtPurchDollar.Text) * Me._Exchangeal, 2))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSaleDollar_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSaleDollar.TextChanged
        Try
            Dim sale As Boolean = Me._sale2
            If sale Then
                Me.txtSalePrice.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtSaleDollar.Text) * Me._Exchangeal, 2))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub hamode()
        Try
            Dim random As Random = New Random()
            Me.txtBarcode.Text = ""
            Dim num As Integer = Convert.ToInt32(random.[Next](4344, 34355353))
            Dim txtBarcode As TextBox = Me.txtBarcode
            txtBarcode.Text = Conversions.ToString(Conversions.ToDouble(txtBarcode.Text) + CDbl(num))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtLimit_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtLimit.TextChanged
    End Sub

    Private Sub txtVal1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) 'Handles txtVal1.TextChanged
    End Sub

    Private Sub dgvFirst_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvFirst.CellValueChanged
        Try
            Me.dgvFirst.Rows(e.RowIndex).Cells(3).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(e.RowIndex).Cells(1).Value)) * Conversions.ToDouble(Me.txtPurchDollar.Text)
            Me.dgvFirst.Rows(e.RowIndex).Cells(2).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(e.RowIndex).Cells(1).Value)) * Conversions.ToDouble(Me.txtPurchPrice.Text)
            Me.dgvFirst.Rows(e.RowIndex).Cells(1).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvUnits.Rows(e.RowIndex).Cells(1).Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvFirst.Rows(e.RowIndex).Cells(4).Value))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvUnits_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUnits.CellClick
        Try
            Dim flag As Boolean = e.ColumnIndex = 5
            If flag Then
                Dim frmBarcode As frmBarcode = New frmBarcode()
                flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", Me.dgvUnits.Rows(e.RowIndex).Cells(4).Value), "", False)
                If flag Then
                    frmBarcode.Show()
                    frmBarcode.cmbItems.SelectedValue = Me.txtNo.Text
                    frmBarcode._Unit = Me.GetUnitName(Conversions.ToInteger(Me.dgvUnits.Rows(e.RowIndex).Cells(0).Value))
                    frmBarcode.txtBarcode.Text = Conversions.ToString(Me.dgvUnits.Rows(e.RowIndex).Cells(4).Value)
                    frmBarcode.txtPrice.Text = Conversions.ToString(Me.dgvUnits.Rows(e.RowIndex).Cells(3).Value)
                    frmBarcode.cmbPrinters.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvUnits_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvUnits.DataError
    End Sub

    Private Sub dgvFirst_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvFirst.CellContentClick
    End Sub

    Private Sub dgvUnits_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUnits.CellContentClick
    End Sub

    Private Sub dgvUnits_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUnits.CellValueChanged
        Dim flag As Boolean = e.ColumnIndex = 1
        If flag Then
            Try
                Me.dgvUnits.Rows(e.RowIndex).Cells(2).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvUnits.Rows(e.RowIndex).Cells(1).Value)) * Conversions.ToDouble(Me.txtPurchPrice.Text)
                Me.dgvUnits.Rows(e.RowIndex).Cells(3).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvUnits.Rows(e.RowIndex).Cells(1).Value)) * Conversions.ToDouble(Me.txtSalePrice.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frmBarcode As frmBarcode = New frmBarcode()
        Dim flag As Boolean = Operators.CompareString(Me.txtBarcode.Text, "", False) <> 0
        If flag Then
            frmBarcode.txtBarcode.Text = Me.txtBarcode.Text
            frmBarcode.txtPrice.Text = Me.txtSalePrice.Text
        End If
        frmBarcode.Show()
        frmBarcode.cmbItems.SelectedValue = Me.txtNo.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            Dim frmMultiBarcode As frmMultiBarcode = New frmMultiBarcode()
            frmMultiBarcode.txtNo.Text = Me.txtNo.Text
            frmMultiBarcode.txtSymbol.Text = Me.txtSymbol.Text
            frmMultiBarcode.LoadDG()
            frmMultiBarcode.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbTaxGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTaxGroup.SelectedIndexChanged
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select value from tax_groups where id=", Me.cmbTaxGroup.SelectedValue)), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Try
            Dim text As String = String.Concat(New String() {"symbol like '%", Me.txtNameSrch.Text, "%' and (currencies.barcode like '%", Me.txtSrchBarcode.Text, "%' or (Currencies.id in ( select curr from curr_units where barcode like '%", Me.txtSrchBarcode.Text, "%') )) and "})
            Dim checked As Boolean = Me.chkPrintLimit.Checked
            If checked Then
                text = String.Concat(New String() {text, " currencies.id>=", Conversions.ToString(Me.txtFromNo.Value), " and currencies.id<=", Conversions.ToString(Me.txtToNo.Value), " and "})
            End If
            Me.LoadDG(text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenFile.Click
        Try
            Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.txtPicPath.Text = Me.OpenFileDialog1.FileName
                Me.picImage.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPicPath_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPicPath.TextChanged
    End Sub

    Private Sub Label16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label16.Click
    End Sub

    Private Sub GenBarcode()
        Dim minValue As Integer = 100000
        Dim maxValue As Integer = 999999
        Dim random As Random = New Random()
        Dim text As String = random.[Next](minValue, maxValue).ToString()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from currencies where barcode='" + text + "'", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count = 0
        If flag Then
            Me.txtBarcode.Text = text
        Else
            Me.GenBarcode()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Try
            Me.GenBarcode()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbItemType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItemType.SelectedIndexChanged
        Try
            Dim flag As Boolean = Me.cmbItemType.SelectedIndex <> 2
            If flag Then
                Me.TabControl1.TabPages.Remove(Me.TabPage3)
            Else
                flag = (Me.TabControl1.TabPages.Count = 2)
                If flag Then
                    Me.TabControl1.TabPages.Add(Me.TabPage3)
                    Me.LoadMaterials()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvComponents_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvComponents.DataError
    End Sub

    Private Function chkIsItemFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from currencies where symbol='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function chkIsItemUnitFounded(_itemname As String, _unitname As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currencies.id from currencies,units where currencies.unit=units.id and currencies.symbol='", _itemname, "' and units.name='", _unitname, "'"}), Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Boolean
        If flag Then
            result = True
        Else
            sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currencies.id from currencies,curr_units,units where currencies.id=curr_units.curr and curr_units.unit=units.id and currencies.symbol='", _itemname, "' and units.name='", _unitname, "'"}), Me.conn1)
            dataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            result = flag
        End If
        Return result
    End Function

    Private Function chkIsGroupFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from groups where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function chkIsStoreFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from safes where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function GetStoreID(_name As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from safes where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Function chkIsUnitFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from units where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function GetGroupID(_name As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from groups where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Function GetUnitID(_name As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from units where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Function GetUnitName(_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from units where id=" + Conversions.ToString(_id), Me.conn1)
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

    Private Function GetItemID(_name As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from currencies where symbol='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Function GetNextNo() As Integer
        Dim result As Integer = 1
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Currencies", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
                If flag2 Then
                    ' The following expression was wrapped in a checked-expression
                    result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) + 1
                End If
            End If
        Catch ex As Exception
        End Try
        Return result
    End Function

    Private Sub AddFirstStock(_store As Integer, _item As Integer, _unit As Integer, _unitperc As Integer, _quan As Double, _price As Double, _tot As Double)
        Try
            Dim str As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
            End If
            flag = (Me.conn1.State <> ConnectionState.Open)
            If flag Then
                Me.conn1.Open()
            End If
            Dim sqlTransaction As SqlTransaction = Me.conn1.BeginTransaction()
            Dim sqlCommand As SqlCommand = New SqlCommand()
            Dim num As Integer = 0
            Dim num2 As Integer = 0
            flag = (_quan <> 0.0)
            Dim num3 As Integer
            If flag Then
                sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn1, sqlTransaction)
                num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
            End If
            num3 = 1
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and proc_type=3", Me.conn)
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
            sqlCommand = New SqlCommand("insert into Inv(proc_type,id,date,inv_type,safe,stock,cust_id,sales_emp,tot_purch,tot_sale,tot_net,paid,minus,purch_rest_id,sale_rest_id,InvId_Return,branch,IS_Buy,IS_Deleted)values(@proc_type,@id,@date,@inv_type,@safe,@stock,@cust_id,@sales_emp,@tot_purch,@tot_sale,@tot_net,@paid,@minus,@purch_rest_id,@sale_rest_id,@InvId_Return,@branch,@IS_Buy,@IS_Deleted)", Me.conn1, sqlTransaction)
            sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 3
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num3
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
            sqlCommand.Parameters.Add("@inv_type", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@safe", SqlDbType.Int).Value = _store
            sqlCommand.Parameters.Add("@stock", SqlDbType.Int).Value = num5
            sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = num4
            sqlCommand.Parameters.Add("@sales_emp", SqlDbType.Int).Value = MainClass.EmpNo
            sqlCommand.Parameters.Add("@tot_purch", SqlDbType.Float).Value = _tot
            sqlCommand.Parameters.Add("@tot_sale", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@tot_net", SqlDbType.Float).Value = _tot
            sqlCommand.Parameters.Add("@paid", SqlDbType.Float).Value = _tot
            sqlCommand.Parameters.Add("@minus", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@purch_rest_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@sale_rest_id", SqlDbType.Int).Value = num2
            sqlCommand.Parameters.Add("@InvId_Return", SqlDbType.Int).Value = -1
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.Parameters.Add("@IS_Buy", SqlDbType.Bit).Value = 1
            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
            sqlCommand.Parameters.Add("@salesman", SqlDbType.Int).Value = -1
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("select max(proc_id) from Inv", Me.conn1, sqlTransaction)
            Dim num6 As Integer = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
            sqlCommand = New SqlCommand("insert into Inv_Sub(proc_id,proc_type,currency_from,unit,val,val1,exchange_price)values(@proc_id,@proc_type,@currency_from,@unit,@val,@val1,@exchange_price)", Me.conn1, sqlTransaction)
            sqlCommand.Parameters.Add("@proc_id", SqlDbType.Int).Value = num6
            sqlCommand.Parameters.Add("@proc_type", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@currency_from", SqlDbType.Int).Value = _item
            sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = _unit
            sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = _quan * CDbl(_unitperc)
            sqlCommand.Parameters.Add("@val1", SqlDbType.Float).Value = _quan
            sqlCommand.Parameters.Add("@exchange_price", SqlDbType.Float).Value = _price
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn1, sqlTransaction)
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
            sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = num3
            sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 9
            sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn1, sqlTransaction)
            sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = _tot
            sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = 2120001
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.ExecuteNonQuery()
            sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn1, sqlTransaction)
            sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = _tot
            sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = 0
            sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = 1270001
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "مخزون أول المدة "
            sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
            sqlCommand.ExecuteNonQuery()
            sqlTransaction.Commit()
        Catch ex2 As Exception
            Dim sqlTransaction As SqlTransaction
            sqlTransaction.Rollback()
        Finally
            Dim flag As Boolean = Me.conn1.State <> ConnectionState.Closed
            If flag Then
                Me.conn1.Close()
            End If
        End Try
    End Sub

    Private Sub ImportItems()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
            If flag Then
                Me.conn.Open()
            End If
            For i As Integer = 0 To Me.dtItems.Rows.Count - 1

                Try
                    flag = (Operators.CompareString(Me.dtItems.Rows(i)(0).ToString().Trim(), "", False) <> 0)
                    If flag Then
                        Dim num As Integer = -1
                        Dim num2 As Integer = -1
                        Dim text As String = Me.dtItems.Rows(i)(11).ToString().Trim()
                        Dim text2 As String = Me.dtItems.Rows(i)(13).ToString().Trim()
                        Dim num3 As Double = Conversion.Val("" + Me.dtItems.Rows(i)(12).ToString().Trim())
                        Dim num4 As Double = Conversion.Val("" + Me.dtItems.Rows(i)(14).ToString().Trim())
                        flag = (Operators.CompareString(text, "", False) <> 0)
                        Dim flag2 As Boolean
                        If flag Then
                            flag2 = Me.chkIsStoreFounded(text)
                            If flag2 Then
                                num = Me.GetStoreID(text)
                            Else
                                Dim sqlCommand As SqlCommand = New SqlCommand("insert into Safes(name,branch,status,IS_Default,notes,IS_Deleted)values(@name,@branch,@status,@IS_Default,@notes,@IS_Deleted)", Me.conn)
                                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = text
                                sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                                sqlCommand.Parameters.Add("@status", SqlDbType.Int).Value = 1
                                sqlCommand.Parameters.Add("@IS_Default", SqlDbType.Bit).Value = 0
                                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = ""
                                sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                                sqlCommand.ExecuteNonQuery()
                                num = Me.GetStoreID(text)
                                sqlCommand = New SqlCommand(String.Concat(New String() {"insert into Safe_Emps(safe_id,emp_id)values(", Conversions.ToString(num), ",", Conversions.ToString(MainClass.EmpNo), ")"}), Me.conn)
                                sqlCommand.ExecuteNonQuery()
                            End If
                        End If
                        flag2 = (Operators.CompareString(text2, "", False) <> 0)
                        If flag2 Then
                            flag = Me.chkIsStoreFounded(text2)
                            If flag Then
                                num2 = Me.GetStoreID(text2)
                            Else
                                Dim sqlCommand2 As SqlCommand = New SqlCommand("insert into Safes(name,branch,status,IS_Default,notes,IS_Deleted)values(@name,@branch,@status,@IS_Default,@notes,@IS_Deleted)", Me.conn)
                                sqlCommand2.Parameters.Add("@name", SqlDbType.NVarChar).Value = text2
                                sqlCommand2.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
                                sqlCommand2.Parameters.Add("@status", SqlDbType.Int).Value = 1
                                sqlCommand2.Parameters.Add("@IS_Default", SqlDbType.Bit).Value = 0
                                sqlCommand2.Parameters.Add("@notes", SqlDbType.NVarChar).Value = ""
                                sqlCommand2.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                                sqlCommand2.ExecuteNonQuery()
                                num2 = Me.GetStoreID(text2)
                                sqlCommand2 = New SqlCommand(String.Concat(New String() {"insert into Safe_Emps(safe_id,emp_id)values(", Conversions.ToString(num2), ",", Conversions.ToString(MainClass.EmpNo), ")"}), Me.conn)
                                sqlCommand2.ExecuteNonQuery()
                            End If
                        End If
                        Dim text3 As String = Me.dtItems.Rows(i)(0).ToString().Trim()
                        flag2 = Not Me.chkIsItemFounded(text3)
                        If flag2 Then
                            Dim sqlCommand3 As SqlCommand = New SqlCommand("insert into Currencies(id,symbol,nameEN,barcode,group_id,unit,purch_price,sale_price,limit,discount,tax_group,tax,IS_Deleted)values(@id,@symbol,@nameEN,@barcode,@group_id,@unit,@purch_price,@sale_price,@limit,@discount,@tax_group,@tax,@IS_Deleted)", Me.conn)
                            Dim num5 As Integer = -1
                            Dim num6 As Integer = -1
                            sqlCommand3.Parameters.Add("@id", SqlDbType.Int).Value = Me.GetNextNo()
                            sqlCommand3.Parameters.Add("@symbol", SqlDbType.NVarChar).Value = text3
                            sqlCommand3.Parameters.Add("@nameEN", SqlDbType.NVarChar).Value = Me.dtItems.Rows(i)(1).ToString().Trim()
                            Dim text4 As String = "" + Me.dtItems.Rows(i)(2).ToString().Trim()
                            flag2 = (Operators.CompareString(text4, "0", False) = 0)
                            If flag2 Then
                                text4 = ""
                            End If
                            sqlCommand3.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = text4
                            Dim text5 As String = Me.dtItems.Rows(i)(3).ToString().Trim()
                            Dim text6 As String = Me.dtItems.Rows(i)(4).ToString().Trim()
                            flag2 = (Operators.CompareString(text6, "", False) = 0)
                            If flag2 Then
                                text6 = "حبة"
                            End If
                            flag2 = (Operators.CompareString(text5, "", False) <> 0)
                            If flag2 Then
                                flag = Me.chkIsGroupFounded(text5)
                                If flag Then
                                    num5 = Me.GetGroupID(text5)
                                Else
                                    Dim sqlCommand4 As SqlCommand = New SqlCommand("insert into groups(name)values(@name)", Me.conn)
                                    sqlCommand4.Parameters.Add("@name", SqlDbType.NVarChar).Value = text5
                                    sqlCommand4.ExecuteNonQuery()
                                    num5 = Me.GetGroupID(text5)
                                End If
                            End If
                            flag2 = (Operators.CompareString(text6, "", False) <> 0)
                            If flag2 Then
                                flag = Me.chkIsUnitFounded(text6)
                                If flag Then
                                    num6 = Me.GetUnitID(text6)
                                Else
                                    Dim sqlCommand5 As SqlCommand = New SqlCommand("insert into units(name)values(@name)", Me.conn)
                                    sqlCommand5.Parameters.Add("@name", SqlDbType.NVarChar).Value = text6
                                    sqlCommand5.ExecuteNonQuery()
                                    num6 = Me.GetUnitID(text6)
                                End If
                            End If
                            sqlCommand3.Parameters.Add("@group_id", SqlDbType.Int).Value = num5
                            sqlCommand3.Parameters.Add("@unit", SqlDbType.Int).Value = num6
                            sqlCommand3.Parameters.Add("@purch_price", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString())
                            sqlCommand3.Parameters.Add("@sale_price", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(7).ToString())
                            sqlCommand3.Parameters.Add("@limit", SqlDbType.Int).Value = Conversion.Val("" + Me.dtItems.Rows(i)(10).ToString())
                            sqlCommand3.Parameters.Add("@discount", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(9).ToString())
                            sqlCommand3.Parameters.Add("@tax_group", SqlDbType.Int).Value = -1
                            sqlCommand3.Parameters.Add("@tax", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(8).ToString())
                            sqlCommand3.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                            sqlCommand3.ExecuteNonQuery()
                            flag2 = (num3 <> 0.0)
                            If flag2 Then
                                Me.AddFirstStock(num, Me.GetItemID(text3), num6, 1, num3, Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()), num3 * Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()))
                            End If
                            flag2 = (num4 <> 0.0)
                            If flag2 Then
                                Me.AddFirstStock(num2, Me.GetItemID(text3), num6, 1, num4, Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()), num4 * Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()))
                            End If
                        Else
                            flag2 = Not Me.chkIsItemUnitFounded(text3.ToString(), Me.dtItems.Rows(i)(4).ToString())
                            If flag2 Then
                                Dim text7 As String = Me.dtItems.Rows(i)(4).ToString().Trim()
                                Dim num7 As Integer = -1
                                flag2 = (Operators.CompareString(text7, "", False) <> 0)
                                If flag2 Then
                                    flag = Me.chkIsUnitFounded(text7)
                                    If flag Then
                                        num7 = Me.GetUnitID(text7)
                                    Else
                                        Dim sqlCommand6 As SqlCommand = New SqlCommand("insert into units(name)values(@name)", Me.conn)
                                        sqlCommand6.Parameters.Add("@name", SqlDbType.NVarChar).Value = text7
                                        sqlCommand6.ExecuteNonQuery()
                                        num7 = Me.GetUnitID(text7)
                                    End If
                                End If
                                Dim sqlCommand3 As SqlCommand = New SqlCommand("insert into curr_units(curr,unit,perc,purch,sale,barcode)values(@curr,@unit,@perc,@purch,@sale,@barcode)", Me.conn)
                                sqlCommand3.Parameters.Add("@curr", SqlDbType.Int).Value = Me.GetItemID(text3)
                                sqlCommand3.Parameters.Add("@unit", SqlDbType.Int).Value = num7
                                sqlCommand3.Parameters.Add("@perc", SqlDbType.Int).Value = Conversion.Val("" + Me.dtItems.Rows(i)(5).ToString())
                                sqlCommand3.Parameters.Add("@purch", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString())
                                sqlCommand3.Parameters.Add("@sale", SqlDbType.Float).Value = Conversion.Val("" + Me.dtItems.Rows(i)(7).ToString())
                                sqlCommand3.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = Me.dtItems.Rows(i)(2).ToString()
                                sqlCommand3.ExecuteNonQuery()
                                flag2 = (num3 <> 0.0)
                                If flag2 Then
                                    ' The following expression was wrapped in a checked-expression
                                    Me.AddFirstStock(num, Me.GetItemID(text3), num7, CInt(Math.Round(Conversion.Val("" + Me.dtItems.Rows(i)(5).ToString()))), num3, Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()), num3 * Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()))
                                End If
                                flag2 = (num4 <> 0.0)
                                If flag2 Then
                                    ' The following expression was wrapped in a checked-expression
                                    Me.AddFirstStock(num2, Me.GetItemID(text3), num7, CInt(Math.Round(Conversion.Val("" + Me.dtItems.Rows(i)(5).ToString()))), num4, Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()), num4 * Conversion.Val("" + Me.dtItems.Rows(i)(6).ToString()))
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                End Try

                Me.progressBar1.Value = Me.progressBar1.Value + 1
            Next
            Me.LoadGroups()
            Me.LoadUnits()
            Me.LoadDG("")
        Catch ex2 As Exception
        Finally
            Me._CompletedImport = True
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnClientsImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientsImport.Click
        Try
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me._CompletedImport = False
                Dim selectConnection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Me.OpenFileDialog1.FileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
                Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("select * from [Sheet1$]", selectConnection)
                Me.dtItems = New DataTable()
                oleDbDataAdapter.Fill(Me.dtItems)
                Me.progressBar1.Value = 0
                Me.progressBar1.Maximum = Me.dtItems.Rows.Count
                'Dim thread As Thread = AddressOf Me.ImportItems
                Dim thread As New Thread(AddressOf Me.ImportItems)
                thread.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
