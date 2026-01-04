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
Partial Public Class frmSafesTransfer
	Inherits Form

	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Private conn As SqlConnection

	Private conn1 As SqlConnection

	Private Code As Integer

	Private Loaded As Boolean

	Private _IsUpdateDG As Boolean
	Shared Sub New()
	End Sub

	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.frmSafesTransfer_Load
		frmSafesTransfer.__ENCAddToList(Me)
		Me.conn = MainClass.ConnObj()
		Me.conn1 = MainClass.ConnObj()
		Me.Code = -1
		Me.Loaded = False
		Me._IsUpdateDG = False
		Me.InitializeComponent()
	End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmSafesTransfer.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmSafesTransfer.__ENCList.Count = frmSafesTransfer.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmSafesTransfer.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmSafesTransfer.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmSafesTransfer.__ENCList(num) = frmSafesTransfer.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmSafesTransfer.__ENCList.RemoveRange(num, frmSafesTransfer.__ENCList.Count - num)
				frmSafesTransfer.__ENCList.Capacity = frmSafesTransfer.__ENCList.Count
			End If
			frmSafesTransfer.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub CLR()
		MainClass.CLRForm(Me)
		Me.dgvItems.Rows.Clear()
		Me.LoadNxtNo()
		Me.Code = -1
	End Sub

	Private Sub LoadNxtNo()
		Try
			Dim value As Integer = 1
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from SafesTransfer", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				value = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
			End If
			Me.txtNo.Text = "" + Conversions.ToString(value)
		Catch ex As Exception
		End Try
	End Sub

	Private Function GetSafeName(safe_id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from safes where id=" + Conversions.ToString(safe_id), Me.conn)
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

	Private Function GetCurrencyName(Currency_id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol,nameEN from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
			If flag2 Then
				result = dataTable.Rows(0)(0).ToString()
			Else
				result = dataTable.Rows(0)(1).ToString()
			End If
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetEmpName(Emp_id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(Emp_id), Me.conn)
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

	Private Function GetEmpNo(Emp As String) As Integer
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Employees where name='" + Emp + "'", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As Integer
		If flag Then
			result = Conversions.ToInteger(dataTable.Rows(0)(0).ToString())
		Else
			result = -1
		End If
		Return result
	End Function

	Private Sub LoadDG(cond As String)
		Me.dgvSrch.Rows.Clear()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select SafesTransfer.id,SafesTransfer.date,safe_from,safe_to from SafesTransfer  where branch=" + Conversions.ToString(MainClass.BranchNo) + " and SafesTransfer.IS_Deleted=0 " + cond, Me.conn)
		Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
		If flag Then
			sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
			sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
		End If
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
			Me.dgvSrch.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
			Me.dgvSrch.Rows(num3).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
			Me.dgvSrch.Rows(num3).Cells(2).Value = Me.GetSafeName(Conversions.ToInteger(dataTable.Rows(num3)("safe_from")))
			Me.dgvSrch.Rows(num3).Cells(3).Value = Me.GetSafeName(Conversions.ToInteger(dataTable.Rows(num3)("safe_to")))
			num3 += 1
		End While
		Me.dgvSrch.ClearSelection()
	End Sub

	Public Sub LoadSafes()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where status=1 and IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbSafeFrom.DataSource = dataTable
		Me.cmbSafeFrom.DisplayMember = "name"
		Me.cmbSafeFrom.ValueMember = "id"
		Me.cmbSafeFrom.SelectedIndex = -1
		Dim dataTable2 As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable2)
		Me.cmbSafeTo.DataSource = dataTable2
		Me.cmbSafeTo.DisplayMember = "name"
		Me.cmbSafeTo.ValueMember = "id"
		Me.cmbSafeTo.SelectedIndex = -1
	End Sub

	Public Sub LoadCurrency()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol as currency,nameEN from Currencies order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbCurrency.DataSource = dataTable
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
		If flag Then
			Me.cmbCurrency.DisplayMember = "currency"
		Else
			Me.cmbCurrency.DisplayMember = "nameEN"
		End If
		Me.cmbCurrency.ValueMember = "id"
		Me.cmbCurrency.SelectedIndex = -1
	End Sub

	Private Sub ProcessLoad()
		Try
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadSafes()
			Me.LoadCurrency()
			Me.txtDate.Value = DateTime.Now
			Me.LoadNxtNo()
			AddHandler Me.cmbCurrency.SelectedIndexChanged, AddressOf Me.cmbCurrency_SelectedIndexChanged
			Me.Loaded = True
		Catch ex As Exception
		End Try
	End Sub

	Private Sub frmSafesTransfer_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmSafesTransfer.Load
		Control.CheckForIllegalCrossThreadCalls = False
		Me.ProcessLoad()
	End Sub

	Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
		Me.CLR()
	End Sub

	Private Sub txtVal_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtVal.KeyDown
		Try
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Dim flag2 As Boolean = Me.cmbCurrency.SelectedIndex = -1
				If flag2 Then
					MessageBox.Show("يجب اختيار الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbCurrency.Focus()
				Else
					flag2 = (Operators.CompareString(Me.txtVal.Text, "", False) = 0)
					If flag2 Then
						MessageBox.Show("يجب ادخال المبلغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.txtVal.Focus()
					Else
						flag2 = (Conversion.Val(Me.txtVal.Text) > Conversion.Val(Me.txtBalance.Text))
						If flag2 Then
							MessageBox.Show("المبلغ المحول اكبر من رصيد المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.txtVal.Focus()
						Else
							flag2 = Me._IsUpdateDG
							Dim index As Integer
							If flag2 Then
								index = Me.dgvItems.SelectedRows(0).Index
							Else
								Me.dgvItems.Rows.Add()
								index = Me.dgvItems.Rows.Count - 1
							End If
							Me.dgvItems.Rows(index).Cells(0).Value = Me.GetCurrencyName(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
							Me.dgvItems.Rows(index).Cells(1).Value = Me.txtVal.Text
							Me.dgvItems.Rows(index).Cells(2).Value = Me.GetEmpName(MainClass.EmpNo)
							Me.dgvItems.Rows(index).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
							Me._IsUpdateDG = False
							Me.cmbCurrency.SelectedIndex = -1
							Me.txtBalance.Text = ""
							Me.txtVal.Text = ""
							Me.cmbCurrency.Focus()
						End If
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
		Try
			Me.cmbCurrency.SelectedValue = Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)
			Me.txtVal.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(1).Value))
			Me._IsUpdateDG = True
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtSrchNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSrchNo.KeyPress
		MainClass.ISInteger(e)
	End Sub

	Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVal.KeyPress
		MainClass.IsFloat(e)
	End Sub

	Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = Me.cmbSafeFrom.SelectedIndex = -1
			If flag Then
				MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbSafeFrom.Focus()
			Else
				flag = (Me.cmbSafeTo.SelectedIndex = -1)
				If flag Then
					MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbSafeTo.Focus()
				Else
					flag = Operators.ConditionalCompareObjectEqual(Me.cmbSafeTo.SelectedValue, Me.cmbSafeFrom.SelectedValue, False)
					If flag Then
						MessageBox.Show("لا يمكن التحويل لنفس المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbSafeTo.Focus()
					Else
						flag = (Me.dgvItems.Rows.Count = 0)
						If flag Then
							MessageBox.Show("لم تدخل أصناف للتحويل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							flag = (Me.conn.State <> ConnectionState.Open)
							If flag Then
								Me.conn.Open()
							End If
							Dim sqlCommand As SqlCommand = New SqlCommand()
							flag = (Me.Code <> -1)
							If flag Then
								sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update SafesTransfer set date=@date,safe_from=", Me.cmbSafeFrom.SelectedValue), ",safe_to="), Me.cmbSafeTo.SelectedValue), " where id="), Me.Code)), Me.conn)
								sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
								sqlCommand.ExecuteNonQuery()
								sqlCommand = New SqlCommand("delete from SafesTransfer_Sub where transfer_id=" + Conversions.ToString(Me.Code), Me.conn)
								sqlCommand.ExecuteNonQuery()
							End If
							flag = (Me.Code = -1)
							If flag Then
								Me.LoadNxtNo()
								sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into SafesTransfer(id,date,safe_from,safe_to,branch,IS_Deleted) values( " + Me.txtNo.Text + ",@date,", Me.cmbSafeFrom.SelectedValue), ","), Me.cmbSafeTo.SelectedValue), ",@branch,0)")), Me.conn)
								sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
								sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
								sqlCommand.ExecuteNonQuery()
								Me.Code = CInt(Math.Round(Conversion.Val("" + Me.txtNo.Text)))
							End If
							Dim num As Integer = 0
							Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
							Dim num3 As Integer = num
							While True
								Dim num4 As Integer = num3
								Dim num5 As Integer = num2
								If num4 > num5 Then
									Exit While
								End If
								sqlCommand = New SqlCommand("insert into SafesTransfer_Sub(transfer_id,currency,value,user_emp) values (@transfer_id,@currency,@value,@user_emp)", Me.conn)
								sqlCommand.Parameters.Add("@transfer_id", SqlDbType.Int).Value = Me.Code
								sqlCommand.Parameters.Add("@currency", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
								sqlCommand.Parameters.Add("@value", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value)
								sqlCommand.Parameters.Add("@user_emp", SqlDbType.Int).Value = Me.GetEmpNo(Conversions.ToString(Me.dgvItems.Rows(num3).Cells(2).Value))
								sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
								sqlCommand.ExecuteNonQuery()
								num3 += 1
							End While
							MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					End If
				End If
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

	Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
		Try
			Dim flag As Boolean = Me.Code <> -1
			If flag Then
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
				If flag2 Then
					Me.conn.Open()
				End If
				Dim sqlCommand As SqlCommand = New SqlCommand("update SafesTransfer set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
				sqlCommand.ExecuteNonQuery()
				MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.dgvSrch.Rows.Clear()
				Me.CLR()
			Else
				MessageBox.Show("اختر اذن ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		Catch ex As Exception
			Dim text As String = "خطأ أثناء الحذف"
			text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		Finally
			Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
			If flag2 Then
				Me.conn.Close()
			End If
		End Try
	End Sub

	Private Sub dgvRowChng(row_index As Integer)
		Try
			' The following expression was wrapped in a checked-expression
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from SafesTransfer where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.Code))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
		Dim flag As Boolean = e.RowIndex >= 0
		If flag Then
			Me.dgvRowChng(e.RowIndex)
			Me.TabControl1.SelectedIndex = 0
		End If
	End Sub

	Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub ReadData(dr As SqlDataReader)
		Dim hasRows As Boolean = dr.HasRows
		If hasRows Then
			dr.Read()
			Me.CLR()
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
			Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
			Me.txtDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", dr("date")))
			Me.cmbSafeFrom.SelectedValue = Operators.ConcatenateObject("", dr("safe_from"))
			Me.cmbSafeTo.SelectedValue = Operators.ConcatenateObject("", dr("safe_to"))
			dr.Close()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from SafesTransfer_Sub where transfer_id=" + Conversions.ToString(Me.Code), Me.conn)
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
				Me.dgvItems.Rows.Add()
				Me.dgvItems.Rows(num3).Cells(0).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num3)("currency")))
				Me.dgvItems.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("value"))
				Me.dgvItems.Rows(num3).Cells(2).Value = Me.GetEmpName(Conversions.ToInteger(dataTable.Rows(num3)("user_emp")))
				Me.dgvItems.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency"))
				num3 += 1
			End While
		End If
	End Sub

	Public Sub Navigate(sqlstr As String)
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

	Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
		Me.Navigate("select top 1 * from SafesTransfer where IS_Deleted=0 order by id desc")
	End Sub

	Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
		Me.Navigate("select top 1 * from SafesTransfer where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
	End Sub

	Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
		Me.Navigate("select top 1 * from SafesTransfer where IS_Deleted=0 order by id asc")
	End Sub

	Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
		Me.Navigate("select top 1 * from SafesTransfer where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
	End Sub

	Private Sub Search()
		Dim flag As Boolean = Operators.CompareString(Me.txtSrchNo.Text.Trim(), "", False) <> 0
		Dim cond As String
		If flag Then
			cond = " and SafesTransfer.id=" + Me.txtSrchNo.Text
		Else
			cond = " and date>=@date1 and date<=@date2"
		End If
		Me.LoadDG(cond)
	End Sub

	Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
		Me.Search()
	End Sub

	Private Sub CalcStock()
		' The following expression was wrapped in a checked-statement
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("currency")
			dataTable.Columns.Add("sum")
			dataTable.Columns.Add("type")
			Dim str As String = ""
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafeFrom.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable2.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1})
				num3 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select item,sum(difftot) from tsweya,tsweya_sub where safe=", Me.cmbSafeFrom.SelectedValue), " and item="), Me.cmbCurrency.SelectedValue), " and tsweya.id=tsweya_sub.tsweya_id and IS_Deleted=0 group by item")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num6 As Integer = 0
			Dim num7 As Integer = dataTable2.Rows.Count - 1
			Dim num8 As Integer = num6
			While True
				Dim num9 As Integer = num8
				Dim num5 As Integer = num7
				If num9 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 1})
				num8 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafeFrom.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num10 As Integer = 0
			Dim num11 As Integer = dataTable2.Rows.Count - 1
			Dim num12 As Integer = num10
			While True
				Dim num13 As Integer = num12
				Dim num5 As Integer = num11
				If num13 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 2})
				num12 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafeFrom.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num14 As Integer = 0
			Dim num15 As Integer = dataTable2.Rows.Count - 1
			Dim num16 As Integer = num14
			While True
				Dim num17 As Integer = num16
				Dim num5 As Integer = num15
				If num17 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 3})
				num16 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafeFrom.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num18 As Integer = 0
			Dim num19 As Integer = dataTable2.Rows.Count - 1
			Dim num20 As Integer = num18
			While True
				Dim num21 As Integer = num20
				Dim num5 As Integer = num19
				If num21 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 4})
				num20 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafeFrom.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num22 As Integer = 0
			Dim num23 As Integer = dataTable2.Rows.Count - 1
			Dim num24 As Integer = num22
			While True
				Dim num25 As Integer = num24
				Dim num5 As Integer = num23
				If num25 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 5})
				num24 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Me.cmbSafeFrom.SelectedValue), " and currency="), Me.cmbCurrency.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num26 As Integer = 0
			Dim num27 As Integer = dataTable2.Rows.Count - 1
			Dim num28 As Integer = num26
			While True
				Dim num29 As Integer = num28
				Dim num5 As Integer = num27
				If num29 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num28)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num28)(1))), 6})
				num28 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Me.cmbSafeFrom.SelectedValue), " and currency="), Me.cmbCurrency.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num30 As Integer = 0
			Dim num31 As Integer = dataTable2.Rows.Count - 1
			Dim num32 As Integer = num30
			While True
				Dim num33 As Integer = num32
				Dim num5 As Integer = num31
				If num33 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num32)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num32)(1))), 7})
				num32 += 1
			End While
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select consume_type from foundation where id=1", Me.conn)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable3)
			Dim num34 As Integer = 2
			Dim flag As Boolean
			Try
				flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))) = 1)
				If flag Then
					num34 = 1
				End If
			Catch ex As Exception
			End Try
			Dim str2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" inv.safe=", Me.cmbSafeFrom.SelectedValue), " and "))
			flag = (num34 = 1)
			If flag Then
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + str2 + " is_buy=0 and inv.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num35 As Integer = 0
				Dim num36 As Integer = dataTable2.Rows.Count - 1
				Dim num37 As Integer = num35
				While True
					Dim num38 As Integer = num37
					Dim num5 As Integer = num36
					If num38 > num5 Then
						Exit While
					End If
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num37)(0))), Me.conn)
					Dim dataTable4 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable4)
					Dim num39 As Integer = 0
					Dim num40 As Integer = dataTable4.Rows.Count - 1
					Dim num41 As Integer = num39
					While True
						Dim num42 As Integer = num41
						num5 = num40
						If num42 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable4.Rows(num41)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num37)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num41)(1)))), 4})
						num41 += 1
					End While
					num37 += 1
				End While
			Else
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + str2 + " is_manfc=1 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num43 As Integer = 0
				Dim num44 As Integer = dataTable2.Rows.Count - 1
				Dim num45 As Integer = num43
				While True
					Dim num46 As Integer = num45
					Dim num5 As Integer = num44
					If num46 > num5 Then
						Exit While
					End If
					Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num45)(0))), Me.conn)
					Dim dataTable5 As DataTable = New DataTable()
					sqlDataAdapter4.Fill(dataTable5)
					Dim num47 As Integer = 0
					Dim num48 As Integer = dataTable5.Rows.Count - 1
					Dim num49 As Integer = num47
					While True
						Dim num50 As Integer = num49
						num5 = num48
						If num50 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable5.Rows(num49)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num45)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable5.Rows(num49)(1)))), 4})
						num49 += 1
					End While
					num45 += 1
				End While
			End If
			Dim num51 As Integer = dataTable.Rows.Count - 1
			Dim num52 As Integer = 0
			Dim num53 As Integer = num51
			Dim num54 As Integer = num52
			Dim flag3 As Boolean
			While True
				Dim num55 As Integer = num54
				Dim num5 As Integer = num53
				If num55 > num5 Then
					Exit While
				End If
				flag = (num54 <= num51)
				If flag Then
					Dim flag2 As Boolean = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num54)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num54)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num54)(2), 7, False)))
					If flag2 Then
						' The following expression was wrapped in a unchecked-expression
						dataTable.Rows(num54)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num54)(1)))
					End If
				End If
				Dim num56 As Integer = num54 + 1
				Dim num57 As Integer = num51
				Dim num58 As Integer = num56
				While True
					Dim num59 As Integer = num58
					num5 = num57
					If num59 > num5 Then
						Exit While
					End If
					Dim flag2 As Boolean = num58 <= num51
					If flag2 Then
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num54)(0), dataTable.Rows(num58)(0), False)
						If flag Then
							flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num58)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num58)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num58)(2), 7, False)))

							If flag3 Then
								dataTable.Rows(num58)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1)))
							End If
							dataTable.Rows(num54)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num54)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1)))
							dataTable.Rows.RemoveAt(num58)

							num58 -= 1
							num51 -= 1
						End If
					End If
					num58 += 1
				End While
				num54 += 1
			End While
			flag3 = (dataTable.Rows.Count > 0)
			If flag3 Then
				Me.txtBalance.Text = "" + Conversions.ToString(Conversion.Val(dataTable.Rows(0)(1).ToString()))
			Else
				Me.txtBalance.Text = "0"
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
		Dim flag As Boolean = Me.Loaded
		If flag Then
			Me.txtBalance.Text = ""
			Me.txtVal.Text = ""
			flag = (Me.cmbSafeFrom.SelectedIndex = -1)
			If flag Then
				Me.Loaded = False
				MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbCurrency.SelectedIndex = -1
				Me.cmbSafeFrom.Focus()
				Me.Loaded = True
			Else
				flag = (Me.cmbSafeTo.SelectedIndex = -1)
				If flag Then
					Me.Loaded = False
					MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbCurrency.SelectedIndex = -1
					Me.cmbSafeTo.Focus()
					Me.Loaded = True
				Else
					Me.CalcStock()
				End If
			End If
		End If
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
			dataTable.Columns.Add("curr")
			dataTable.Columns.Add("val")
			dataTable.Columns.Add("emp")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value)})
				num3 += 1
			End While
			Dim rptSafesTransfer As rptSafesTransfer = New rptSafesTransfer()
			rptSafesTransfer.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(1).ReportObjects("fromsafe"), TextObject)
			textObject.Text = Me.cmbSafeFrom.Text
			Dim textObject2 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(1).ReportObjects("tosafe"), TextObject)
			textObject2.Text = Me.cmbSafeTo.Text
			Dim textObject3 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
			textObject3.Text = Me.txtNo.Text
			Dim textObject4 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
			textObject4.Text = Me.txtDate.Value.ToShortDateString()
			Dim textObject5 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
			textObject5.Text = Me.GetEmpUserName(MainClass.EmpNo)
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			rptSafesTransfer.Subreports("rptHeader").SetDataSource(dataTable2)
			flag = (dataTable2.Rows.Count > 0)
			If flag Then
				Dim textObject6 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
				textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
				Dim textObject7 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
				textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
				Dim textObject8 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
				textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
				Dim textObject9 As TextObject = CType(rptSafesTransfer.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
				textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
			End If
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptSafesTransfer
			frmRptViewer.WindowState = FormWindowState.Maximized
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptSafesTransfer.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
		Me.PrintRpt(1)
	End Sub
End Class
