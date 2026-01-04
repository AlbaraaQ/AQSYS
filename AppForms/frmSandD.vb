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
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Public Partial Class frmSandD
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer

		Private RestCode As Integer

		Private _Exchangeal As Double

		Private _change1 As Boolean

		Private _change2 As Boolean

		Public ClientID As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSandD_Load
			frmSandD.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me.RestCode = -1
			Me._Exchangeal = 1250.0
			Me._change1 = True
			Me._change2 = False
			Me.ClientID = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSandD.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSandD.__ENCList.Count = frmSandD.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSandD.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSandD.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSandD.__ENCList(num) = frmSandD.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSandD.__ENCList.RemoveRange(num, frmSandD.__ENCList.Count - num)
					frmSandD.__ENCList.Capacity = frmSandD.__ENCList.Count
				End If
				frmSandD.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.txtBalanceType.Text = ""
			Me.LoadNxtNo()
			Me.Code = -1
		End Sub

		Public Function InsertAuto(_val As Double, _cust As Integer, _custname As String, _khazna As Integer, _khznaname As String, _date As DateTime) As Object
			' The following expression was wrapped in a checked-statement
			Try
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1
				If flag Then
					str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
				End If
				flag = (Me.conn.State <> ConnectionState.Open)
				If flag Then
					Me.conn.Open()
				End If
				Dim sqlTransaction As SqlTransaction = Me.conn.BeginTransaction()
				Dim sqlCommand As SqlCommand = New SqlCommand()
				Dim num As Integer = 0
				sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn, sqlTransaction)
				num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
				Dim value As Integer = 1
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from SandQ where branch=" + Conversions.ToString(MainClass.BranchNo), Me.conn1)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						' The following expression was wrapped in a unchecked-expression
						value = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
					End If
				Catch ex As Exception
				End Try
				sqlCommand = New SqlCommand("insert into SandD(id,date,cust_id,val,type,safe_bank_id,sales_emp,check_no,check_date,checkbank,check_state,rest_id,notes,branch,IS_Deleted)values(" + Conversions.ToString(value) + ",@date,@cust_id,@val,@type,@safe_bank_id,@sales_emp,@check_no,@check_date,@checkbank,@check_state,@rest_id,@notes,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
				sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = _date
				sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = _cust
				sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = _val
				Dim num2 As Integer = 1
				flag = Me.rdCheck.Checked
				If flag Then
					num2 = 2
					sqlCommand.Parameters.Add("@check_no", SqlDbType.NVarChar).Value = Me.txtCheckNo.Text
					sqlCommand.Parameters.Add("@check_date", SqlDbType.DateTime).Value = Me.txtCheckDate.Value.ToShortDateString()
					sqlCommand.Parameters.Add("@checkbank", SqlDbType.NVarChar).Value = Me.txtBankCheck.Text
					sqlCommand.Parameters.Add("@check_state", SqlDbType.Int).Value = Me.cmbCheckType.SelectedIndex + 1
				Else
					sqlCommand.Parameters.Add("@check_no", SqlDbType.NVarChar).Value = DBNull.Value
					sqlCommand.Parameters.Add("@check_date", SqlDbType.DateTime).Value = DBNull.Value
					sqlCommand.Parameters.Add("@checkbank", SqlDbType.NVarChar).Value = DBNull.Value
					sqlCommand.Parameters.Add("@check_state", SqlDbType.Int).Value = DBNull.Value
				End If
				sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = num2
				sqlCommand.Parameters.Add("@safe_bank_id", SqlDbType.Int).Value = _khazna
				sqlCommand.Parameters.Add("@sales_emp", SqlDbType.Int).Value = MainClass.EmpNo
				sqlCommand.Parameters.Add("@rest_id", SqlDbType.Int).Value = num
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
				sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
				sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
				sqlCommand.ExecuteNonQuery()
				flag = (Me.Code = -1)
				If flag Then
					Me.Code = CInt(Math.Round(Conversion.Val("" + Conversions.ToString(value))))
				End If
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Code from Accounts_Index where Type=2 and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null ) and AName='", _custname, "'" }), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					num3 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))))
				End If
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Code from Accounts_Index where Type=2 and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null ) and AName='", _khznaname, "'" }), Me.conn1)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag = (dataTable3.Rows.Count > 0)
				If flag Then
					num4 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))))
				End If
				sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
				sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num
				sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = _date
				sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = Me.Code
				sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 5
				sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند صرف خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة المورد:" + _custname
				sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
				sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
				sqlCommand.ExecuteNonQuery()
				sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
				sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
				sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = 0
				sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = _val
				sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num4
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند قبض خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة العميل:" + _custname
				sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
				sqlCommand.ExecuteNonQuery()
				sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
				sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
				sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = _val
				sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = 0
				sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num3
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند قبض خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة العميل:" + _custname
				sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
				sqlCommand.ExecuteNonQuery()
				sqlTransaction.Commit()
			Catch ex2 As Exception
				Dim sqlTransaction As SqlTransaction
				sqlTransaction.Rollback()
				Dim str2 As String = "خطأ أثناء الحفظ"
				str2 = str2 + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
			Dim result As Object
			Return result
		End Function

		Private Sub LoadNxtNo()
			Try
				Dim value As Integer = 1
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from SandD where branch=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
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

		Private Sub LoadDG(cond As String)
			Me.dgvSrch.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select SandD.id,SandD.date,SandD.val,Employees.name from SandD,Employees  where SandD.IS_Deleted=0 and " + cond + " SandD.sales_emp=Employees.id", Me.conn)
			Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
			If flag Then
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
				Dim dateTime As DateTime = Me.txtToDate.Value.AddHours(24.0)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
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
				Me.dgvSrch.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val"))
				Me.dgvSrch.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
				num3 += 1
			End While
			Me.dgvSrch.ClearSelection()
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

		Public Sub LoadEmps()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees,EmpBranches where Employees.id=EmpBranches.emp and EmpBranches.branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 order by id", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbEmp.DataSource = dataTable
			Me.cmbEmp.DisplayMember = "name"
			Me.cmbEmp.ValueMember = "id"
			Me.cmbEmp.SelectedIndex = -1
		End Sub

		Public Sub LoadSales()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees,EmpBranches where Employees.id=EmpBranches.emp and EmpBranches.branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 order by id", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSalesMan.DataSource = dataTable
			Me.cmbSalesMan.DisplayMember = "name"
			Me.cmbSalesMan.ValueMember = "id"
			Me.cmbSalesMan.SelectedIndex = -1
		End Sub

  Private Sub rdCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdCheck.CheckedChanged
			Dim checked As Boolean = Me.rdCash.Checked
			If checked Then
				Me.Panel1.Enabled = False
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Stocks where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.cmbEda3.DataSource = dataTable
				Me.cmbEda3.DisplayMember = "name"
				Me.cmbEda3.ValueMember = "id"
				Me.cmbEda3.SelectedIndex = -1
			Else
				Me.Panel1.Enabled = True
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id,name from Banks where IS_Deleted=0 order by id", Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Me.cmbEda3.DataSource = dataTable2
				Me.cmbEda3.DisplayMember = "name"
				Me.cmbEda3.ValueMember = "id"
				Me.cmbEda3.SelectedIndex = -1
			End If
		End Sub

		Public Sub LoadClients()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbClients.DataSource = dataTable
			Me.cmbClients.DisplayMember = "name"
			Me.cmbClients.ValueMember = "id"
			Me.cmbClients.SelectedIndex = -1
		End Sub

  Private Sub frmSandD_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmSandD.Load
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadEmps()
			Me.LoadClients()
			Me.LoadSales()
			Me.LoadNxtNo()
			Me.WindowState = MainClass.Window_State
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Exchangeval from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
					If flag2 Then
						Me._Exchangeal = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtVal.Text.Trim(), "", False) = 0
				If flag Then
					MessageBox.Show("ادخل القيمة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtVal.Focus()
				Else
					flag = (Me.cmbEmp.SelectedIndex = -1)
					If flag Then
						MessageBox.Show("يجب اختيار الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbEmp.Focus()
					Else
						flag = (Me.cmbClients.SelectedIndex = -1)
						If flag Then
							MessageBox.Show("يجب اختيار العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.cmbClients.Focus()
						Else
							flag = (Me.cmbEda3.SelectedIndex = -1)
							If flag Then
								Dim flag2 As Boolean = Me.rdCash.Checked
								If flag2 Then
									MessageBox.Show("يجب اختيار الخزنة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Else
									MessageBox.Show("يجب اختيار البنك", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End If
								Me.cmbEda3.Focus()
							Else
								Dim flag2 As Boolean = Me.cmbSalesMan.SelectedIndex = -1
								If flag2 Then
									MessageBox.Show("يجب اختيار مندوب المبيعات", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.cmbSalesMan.Focus()
								Else
									Dim str As String = ""
									flag2 = (MainClass.BranchNo <> -1)
									If flag2 Then
										str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
									End If
									flag2 = (Me.conn.State <> ConnectionState.Open)
									If flag2 Then
										Me.conn.Open()
									End If
									Dim sqlTransaction As SqlTransaction = Me.conn.BeginTransaction()
									Dim sqlCommand As SqlCommand = New SqlCommand()
									flag2 = (Me.Code = -1)
									Dim num As Integer
									If flag2 Then
										sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn, sqlTransaction)
										num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
									Else
										num = Me.RestCode
										sqlCommand = New SqlCommand("delete from Restrictions where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id= " + Conversions.ToString(num), Me.conn, sqlTransaction)
										sqlCommand.ExecuteNonQuery()
										sqlCommand = New SqlCommand("delete from Restrictions_Sub where branch=" + Conversions.ToString(MainClass.BranchNo) + " and res_id= " + Conversions.ToString(num), Me.conn, sqlTransaction)
										sqlCommand.ExecuteNonQuery()
									End If
									flag2 = (Me.Code = -1)
									If flag2 Then
										Me.LoadNxtNo()
										sqlCommand = New SqlCommand("insert into SandD(id,date,emp_id,cust_id,val,type,safe_bank_id,sales_emp,check_no,check_date,checkbank,check_state,notes,rest_id,branch,IS_Deleted)values(" + Me.txtNo.Text + ",@date,@emp_id,@cust_id,@val,@type,@safe_bank_id,@sales_emp,@check_no,@check_date,@checkbank,@check_state,@notes,@rest_id,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
									Else
										sqlCommand = New SqlCommand("update SandD set date=@date ,emp_id=@emp_id ,cust_id=@cust_id, val=@val ,type=@type ,safe_bank_id=@safe_bank_id ,sales_emp=@sales_emp ,check_no=@check_no ,check_date=@check_date ,checkbank=@checkbank ,check_state=@check_state ,notes=@notes ,IS_Deleted=@IS_Deleted where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
									End If
									sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
									sqlCommand.Parameters.Add("@emp_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbEmp.SelectedValue)
									sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbClients.SelectedValue)
									sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = Me.txtVal.Text
									Dim num2 As Integer = 1
									flag2 = Me.rdCheck.Checked
									If flag2 Then
										num2 = 2
										sqlCommand.Parameters.Add("@check_no", SqlDbType.NVarChar).Value = Me.txtCheckNo.Text
										sqlCommand.Parameters.Add("@check_date", SqlDbType.DateTime).Value = Me.txtCheckDate.Value.ToShortDateString()
										sqlCommand.Parameters.Add("@checkbank", SqlDbType.NVarChar).Value = Me.txtBankCheck.Text
										sqlCommand.Parameters.Add("@check_state", SqlDbType.Int).Value = Me.cmbCheckType.SelectedIndex + 1
									Else
										sqlCommand.Parameters.Add("@check_no", SqlDbType.NVarChar).Value = DBNull.Value
										sqlCommand.Parameters.Add("@check_date", SqlDbType.DateTime).Value = DBNull.Value
										sqlCommand.Parameters.Add("@checkbank", SqlDbType.NVarChar).Value = DBNull.Value
										sqlCommand.Parameters.Add("@check_state", SqlDbType.Int).Value = DBNull.Value
									End If
									sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = num2
									sqlCommand.Parameters.Add("@safe_bank_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbEda3.SelectedValue)
									sqlCommand.Parameters.Add("@sales_emp", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbSalesMan.SelectedValue)
									flag2 = (Me.Code = -1)
									If flag2 Then
										Dim sqlCommand2 As SqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn, sqlTransaction)
										num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand2.ExecuteScalar())) + 1.0))
									End If
									sqlCommand.Parameters.Add("@rest_id", SqlDbType.Int).Value = num
									sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
									sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
									sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
									sqlCommand.ExecuteNonQuery()
									flag2 = (Me.Code = -1)
									If flag2 Then
										Me.Code = CInt(Math.Round(Conversion.Val("" + Me.txtNo.Text)))
									End If
									Dim num3 As Integer = 0
									Dim num4 As Integer = 0
									Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Code from Accounts_Index where Type=2 and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null ) and AName='", Me.cmbClients.Text, "'" }), Me.conn1)
									Dim dataTable As DataTable = New DataTable()
									sqlDataAdapter.Fill(dataTable)
									flag2 = (dataTable.Rows.Count > 0)
									If flag2 Then
										num3 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))))
									End If
									Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Code from Accounts_Index where Type=2 and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null ) and AName='", Me.cmbEda3.Text, "'" }), Me.conn1)
									Dim dataTable2 As DataTable = New DataTable()
									sqlDataAdapter2.Fill(dataTable2)
									flag2 = (dataTable2.Rows.Count > 0)
									If flag2 Then
										num4 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))))
									End If
									sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
									sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num
									sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
									sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = Me.Code
									sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 6
									sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
									sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند صرف خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة العميل:" + Me.cmbClients.Text
									sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
									sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
									sqlCommand.ExecuteNonQuery()
									sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
									sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
									sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = 0
									sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = Me.txtVal.Text
									sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num4
									sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند صرف خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة العميل:" + Me.cmbClients.Text
									sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
									sqlCommand.ExecuteNonQuery()
									sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
									sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num
									sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = Me.txtVal.Text
									sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = 0
									sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num3
									sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "سند صرف خارجي رقم: " + Conversions.ToString(Me.Code) + " خاصة العميل:" + Me.cmbClients.Text
									sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
									sqlCommand.ExecuteNonQuery()
									sqlTransaction.Commit()
									Me.dgvSrch.Rows.Clear()
									MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.CLR()
								End If
							End If
						End If
					End If
				End If
			Catch ex As Exception
				Dim sqlTransaction As SqlTransaction
				sqlTransaction.Rollback()
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update SandD set IS_Deleted=1 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					sqlCommand = New SqlCommand("update Restrictions set state=2 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.RestCode), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.dgvSrch.Rows.Clear()
					Me.CLR()
				Else
					MessageBox.Show("اختر سند ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
			' The following expression was wrapped in a checked-expression
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from SandD where id=" + Conversions.ToString(Me.Code))
			Me.TabControl1.SelectedIndex = 0
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
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
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
				Me.RestCode = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("rest_id")))))
				Me.txtDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", dr("date")))
				Try
					Me.cmbEmp.SelectedValue = Operators.ConcatenateObject("", dr("emp_id"))
				Catch ex As Exception
				End Try
				Me.cmbClients.SelectedValue = Operators.ConcatenateObject("", dr("cust_id"))
				Me.txtVal.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("val")))
				flag = Operators.ConditionalCompareObjectEqual(dr("type"), 1, False)
				If flag Then
					Me.rdCash.Checked = True
					Me.Panel1.Enabled = False
				Else
					Me.rdCheck.Checked = True
					Me.Panel1.Enabled = True
					Me.txtCheckNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("check_no")))
					Me.txtCheckDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", dr("check_date")))
					Me.txtBankCheck.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("checkbank")))
					Me.cmbCheckType.SelectedIndex = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("check_state"))) - 1.0))
					Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				End If
				Me.cmbEda3.SelectedValue = Operators.ConcatenateObject("", dr("safe_bank_id"))
				Me.cmbSalesMan.SelectedValue = Operators.ConcatenateObject("", dr("sales_emp"))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				dr.Close()
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

		Private Function GetCondBranch() As String
			Dim result As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				result = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Return result
		End Function

  Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			Me.Navigate("select top 1 * from SandD where " + Me.GetCondBranch() + " IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from SandD where ", Me.GetCondBranch(), " IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc" }))
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from SandD where " + Me.GetCondBranch() + " IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from SandD where ", Me.GetCondBranch(), " IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc" }))
		End Sub

		Private Sub Search()
			Dim str As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				str = "SandD.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			flag = (Operators.CompareString(Me.txtSrchNo.Text.Trim(), "", False) <> 0)
			Dim cond As String
			If flag Then
				cond = str + " SandD.id=" + Me.txtSrchNo.Text + " and "
			Else
				cond = str + " date>=@date1 and date<=@date2 and "
			End If
			Me.LoadDG(cond)
		End Sub

  Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
			Me.Search()
		End Sub

  Private Sub txtSrchNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSrchNo.KeyPress
			MainClass.ISInteger(e)
		End Sub

		Private Sub GetCustBalance()
			Try
				Dim value As Integer = -1
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where Type=2 and AName='" + Me.cmbClients.Text + "'", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					' The following expression was wrapped in a checked-expression
					value = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
				End If
				Dim text As String = ""
				text = text + " and Restrictions_Sub.acc_no=" + Conversions.ToString(value)
				Dim str As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str = String.Concat(New String() { "Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and " })
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code='" + Conversions.ToString(value) + "'", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				Dim flag2 As Boolean
				If flag Then
					flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("IValue"))) <> 0.0)
					If flag2 Then
						Me.dgvSrch.Rows.Add()
						flag2 = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Nature"))) = 1)
						If flag2 Then
							num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
						Else
							num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
						End If
					End If
				End If
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDate.Value.AddHours(24.0)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
				If flag2 Then
					num += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
					num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
				End If
				flag2 = (num >= num2)
				If flag2 Then
					Me.txtBalance.Text = "" + Conversions.ToString(Math.Round(num - num2, 3))
					Me.txtBalanceType.Text = "مدين"
				Else
					Me.txtBalance.Text = "" + Conversions.ToString(Math.Round(num2 - num, 3))
					Me.txtBalanceType.Text = "دائن"
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub cmbClients_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbClients.SelectedIndexChanged
			Try
				Me.GetCustBalance()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
			Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
			If flag Then
				obj = New rptSand()
			Else
				obj = New rptSand___EN()
			End If
			Try
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblheader" }, Nothing, Nothing, Nothing), TextObject)
				textObject.Text = "سند صرف"
			Catch ex As Exception
			End Try
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtlbl" }, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = "رقم سند الصرف"
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtno" }, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = Me.txtNo.Text
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtdate" }, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblemp" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = "الموظف"
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txt_emp" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.cmbEmp.Text
			Catch ex2 As Exception
			End Try
			Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblacc" }, Nothing, Nothing, Nothing), TextObject)
			textObject7.Text = "استلمت أنا السيد"
			Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtacc" }, Nothing, Nothing, Nothing), TextObject)
			textObject8.Text = Me.cmbClients.Text
			Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtval" }, Nothing, Nothing, Nothing), TextObject)
			textObject9.Text = Me.txtVal.Text
			Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lbl10" }, Nothing, Nothing, Nothing), TextObject)
			textObject10.Text = "يصرف سداد دفعة لحساب"
			Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtval1" }, Nothing, Nothing, Nothing), TextObject)
			textObject11.Text = Me.txtVal.Text
			flag = Me.rdCheck.Checked
			If flag Then
				Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtcheckno" }, Nothing, Nothing, Nothing), TextObject)
				textObject12.Text = Me.txtCheckNo.Text
				Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtcheckdate" }, Nothing, Nothing, Nothing), TextObject)
				textObject13.Text = Me.txtCheckDate.Value.ToShortDateString()
			End If
			Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txt_acc" }, Nothing, Nothing, Nothing), TextObject)
			textObject14.Text = Me.cmbClients.Text
			Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtvalname" }, Nothing, Nothing, Nothing), TextObject)
			textObject15.Text = Number2Arabic.ameral(Me.txtVal.Text)
			Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtnotes" }, Nothing, Nothing, Nothing), TextObject)
			textObject16.Text = Me.txtNotes.Text
			Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtemp" }, Nothing, Nothing, Nothing), TextObject)
			textObject17.Text = Me.cmbSalesMan.Text
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim instance As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
			Dim type2 As Type = Nothing
			Dim memberName As String = "SetDataSource"
			Dim array As Object() = New Object() { dataTable }
			Dim arguments As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True }
			NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
			If array2(0) Then
				dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
			End If
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Dim textObject18 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
				textObject18.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Address")))
				Dim textObject19 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
				textObject19.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Tel")))
				Dim textObject20 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
				textObject20.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Mobile")))
				Dim textObject21 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
				textObject21.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Fax")))
			End If
			Try
				Dim subreportObject As SubreportObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "Subreport2" }, Nothing, Nothing, Nothing), SubreportObject)
				subreportObject.ObjectFormat.EnableSuppress = True
			Catch ex3 As Exception
			End Try
			Try
				flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_sanad_header")))
				If flag Then
					Dim subreportObject2 As SubreportObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "Subreport1" }, Nothing, Nothing, Nothing), SubreportObject)
					subreportObject2.ObjectFormat.EnableSuppress = True
				End If
				flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_sanad_footer")))
				If flag Then
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "SectionFormat", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EnableSuppress", New Object() { True }, Nothing, Nothing, False, True)
				End If
			Catch ex4 As Exception
			End Try
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
					Dim num As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					Dim instance2 As Object = obj
					Dim type3 As Type = Nothing
					Dim memberName2 As String = "PrintToPrinter"
					Dim array3 As Object() = New Object() { 1, False, 1, num }
					Dim arguments2 As Object() = array3
					Dim argumentNames2 As String() = Nothing
					Dim typeArguments2 As Type() = Nothing
					array2 = New Boolean() { False, False, False, True }
					NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
					If array2(3) Then
						num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(3)), GetType(Integer)))
					End If
				Catch ex5 As Exception
				End Try
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub txtVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal.TextChanged
			Try
				Dim change As Boolean = Me._change1
				If change Then
					Me.txtValD.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtVal.Text) / Me._Exchangeal, 2))
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtValD_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtValD.TextChanged
			Try
				Dim change As Boolean = Me._change2
				If change Then
					Me.txtVal.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtValD.Text) * Me._Exchangeal, 2))
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtVal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal.Enter
			Me._change1 = True
			Me._change2 = False
		End Sub

  Private Sub txtValD_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtValD.Enter
			Me._change1 = False
			Me._change2 = True
		End Sub

  Private Sub GroupBox3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox3.Enter
		End Sub

  Private Sub cmbEda3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbEda3.SelectedIndexChanged
		End Sub

	Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles Button12.Click
		Try
			'New frmSrchClient() With { .Form_Type = 9, .frm9 = Me }.ShowDialog()
			Using frm As New frmSrchClient()
				frm.Form_Type = 9
				frm.frm9 = Me
				frm.ShowDialog()
			End Using
			Me.cmbClients.SelectedValue = Me.ClientID
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		Try
			Using frm As New frmSrchClient()
				frm.Form_Type = 9
				frm.frm9 = Me

				If frm.ShowDialog(Me) = DialogResult.OK Then
					If Me.ClientID > 0 Then
						cmbClients.SelectedValue = Me.ClientID
					End If
				End If
			End Using
		Catch ex As Exception
			MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub


End Class
