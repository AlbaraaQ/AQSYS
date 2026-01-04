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
Public Partial Class frmSalaryPay
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer

		Private Emp_No As Integer

		Private _loaded As Boolean

		Private _DoCheck As Boolean

		Private _YearSelected As String

		Private _MonthSelected As String

		Private _IsUpdateDG As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSalaryPay_Load
			AddHandler MyBase.KeyDown, AddressOf Me.frmSalaryPay_KeyDown
			frmSalaryPay.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me.Emp_No = -1
			Me._loaded = False
			Me._DoCheck = True
			Me._YearSelected = Conversions.ToString(-1)
			Me._MonthSelected = Conversions.ToString(-1)
			Me._IsUpdateDG = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSalaryPay.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSalaryPay.__ENCList.Count = frmSalaryPay.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSalaryPay.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSalaryPay.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSalaryPay.__ENCList(num) = frmSalaryPay.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSalaryPay.__ENCList.RemoveRange(num, frmSalaryPay.__ENCList.Count - num)
					frmSalaryPay.__ENCList.Capacity = frmSalaryPay.__ENCList.Count
				End If
				frmSalaryPay.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			Me.cmbEmp.SelectedIndex = -1
			Me.txtTotSalary.Text = ""
			Me.txtSalaryAdd.Text = ""
			Me.txtSalarySub.Text = ""
			Me.txtSalarySlf.Text = ""
			Me.txtNet.Text = ""
			Me.txtNotes.Text = ""
			Me.dgvSrch.Rows.Clear()
			Me.LoadNxtNo()
			Me.cmbEmp.Focus()
			Me.Code = -1
		End Sub

		Private Sub LoadNxtNo()
			Try
				Dim value As Integer = 1
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from SalaryPay", Me.conn)
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
			Dim num As Double = 0.0
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select SalaryPay.id,Employees.name,salary_net,month,year,SalaryPay.date,SalaryPay.emp_resp from SalaryPay,Employees where SalaryPay.emp=Employees.id and " + cond + " SalaryPay.IS_Deleted=0 order by id", Me.conn)
			Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
			If flag Then
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
			End If
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num2 As Integer = 0
			Dim num3 As Integer = dataTable.Rows.Count - 1
			Dim num4 As Integer = num2
			While True
				Dim num5 As Integer = num4
				Dim num6 As Integer = num3
				If num5 > num6 Then
					Exit While
				End If
				Me.dgvSrch.Rows.Add()
				Me.dgvSrch.Rows(num4).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("id"))
				Me.dgvSrch.Rows(num4).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("date"))).ToShortDateString()
				Me.dgvSrch.Rows(num4).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("name"))
				Me.dgvSrch.Rows(num4).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("salary_net"))
				Me.dgvSrch.Rows(num4).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("month"))
				Me.dgvSrch.Rows(num4).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("year"))
				num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("salary_net")))
				flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num4)("emp_resp"), -1, False)
				If flag Then
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from Employees where id=", dataTable.Rows(num4)("emp_resp"))), Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Me.dgvSrch.Rows(num4).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("name"))
					End If
				End If
				num4 += 1
			End While
			Me.txtSum.Text = Conversions.ToString(num)
			Me.dgvSrch.ClearSelection()
		End Sub

		Public Sub LoadEmps(branch As Integer)
			Dim selectCommandText As String = "select id,name from Employees where IS_Deleted=0 order by id"
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbEmp.DataSource = dataTable
			Me.cmbEmp.DisplayMember = "name"
			Me.cmbEmp.ValueMember = "id"
			Me.cmbEmp.SelectedIndex = -1
		End Sub

		Public Sub LoadEmpSrch()
			Dim selectCommandText As String = "select id,name from Employees where IS_Deleted=0 order by id"
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbEmpSrch.DataSource = dataTable
			Me.cmbEmpSrch.DisplayMember = "name"
			Me.cmbEmpSrch.ValueMember = "id"
			Me.cmbEmpSrch.SelectedIndex = -1
		End Sub

		Public Sub LoadBranches()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbBranch.DataSource = dataTable
			Me.cmbBranch.DisplayMember = "name"
			Me.cmbBranch.ValueMember = "id"
			Me.cmbBranch.SelectedIndex = -1
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

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub frmSalaryPay_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSalaryPay.Load
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.CLR()
			Dim num As Integer = 1950
			Dim num2 As Integer
			Dim num3 As Integer
			Do
				Me.cmbYear.Items.Add("" + Conversions.ToString(num))
				num += 1
				num2 = num
				num3 = 2100
			Loop While num2 <= num3
			Me.cmbMonth.SelectedIndex = 0
			Me.cmbYear.Text = "" + Conversions.ToString(DateTime.Now.Year)
			Me.LoadBranches()
			Me.LoadEmps(-1)
			Me.LoadEmpSrch()
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				Me.cmbBranch.SelectedValue = MainClass.BranchNo
			End If
			Me.LoadEmp(MainClass.EmpNo)
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBranch.SelectedIndexChanged
			Try
				Me.cmbEmp.Text = ""
				Me.LoadEmps(Conversions.ToInteger(Me.cmbBranch.SelectedValue))
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Me.cmbBranch.SelectedIndex = -1
				If flag Then
					MessageBox.Show("يجب اختيار الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbBranch.Focus()
				Else
					flag = (Me.cmbEmp.SelectedIndex = -1)
					If flag Then
						MessageBox.Show("يجب اختيار الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbEmp.Focus()
					Else
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Employees where name='" + Me.txtEmp.Text + "'", Me.conn)
						Dim dataTable As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						Dim num As Integer = -1
						flag = (dataTable.Rows.Count > 0)
						If flag Then
							' The following expression was wrapped in a checked-expression
							num = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))))
						End If
						flag = (Me.conn.State <> ConnectionState.Open)
						If flag Then
							Me.conn.Open()
						End If
						Dim sqlCommand As SqlCommand = New SqlCommand()
						flag = (Me.Code <> -1)
						If flag Then
							sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update SalaryPay set date=@date,month=" + Me.cmbMonth.Text + ",year=" + Me.cmbYear.Text + ",branch=", Me.cmbBranch.SelectedValue), ",emp="), Me.cmbEmp.SelectedValue), ",tot_salary="), Me.txtTotSalary.Text), ",salary_add="), Me.txtSalaryAdd.Text), ",salary_sub="), Me.txtSalarySub.Text), ",salary_slf="), Me.txtSalarySlf.Text), ",salary_net="), Me.txtNet.Text), ",emp_resp="), num), ",notes='"), Me.txtNotes.Text), "' where id="), Me.Code)), Me.conn)
							sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
							sqlCommand.ExecuteNonQuery()
						End If
						flag = (Me.Code = -1)
						If flag Then
							Me.LoadNxtNo()
							sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into SalaryPay(id,date,month,year,branch,emp,tot_salary,salary_add,salary_sub,salary_slf,salary_net,emp_resp,notes,IS_Deleted) values( " + Me.txtNo.Text + ",@date," + Me.cmbMonth.Text + "," + Me.cmbYear.Text + ",", Me.cmbBranch.SelectedValue), ","), Me.cmbEmp.SelectedValue), ","), Me.txtTotSalary.Text), ","), Me.txtSalaryAdd.Text), ","), Me.txtSalarySub.Text), ","), Me.txtSalarySlf.Text), ","), Me.txtNet.Text), ","), num), ",'"), Me.txtNotes.Text), "',0)")), Me.conn)
							sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
							sqlCommand.ExecuteNonQuery()
							Try
								Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select name from stocks,stock_emps where stocks.id=stock_emps.stock_id and stocks.is_deleted=0 and stock_Emps.emp_id=" + Conversions.ToString(MainClass.EmpNo), Me.conn1)
								Dim dataTable2 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable2)
								flag = (dataTable2.Rows.Count > 0)
								If flag Then
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Code from Accounts_Index where Type=2 and (acc_branch=" + Conversions.ToString(MainClass.BranchNo) + " or acc_branch is null ) and AName='", dataTable2.Rows(0)(0)), "'")), Me.conn1)
									Dim dataTable3 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable3)
									flag = (dataTable3.Rows.Count > 0)
									If flag Then
										Dim frmSandSD As frmSandSD = New frmSandSD()
										Dim acc As Integer = 3210001
										flag = MainClass.IsAccTreeNew
										If flag Then
											acc = 31020001
										End If
										frmSandSD.InsertAuto(New Decimal(Conversion.Val(Me.txtNet.Text)), acc, Conversions.ToInteger(dataTable3.Rows(0)(0)), String.Concat(New String() { "راتب الموظف ", Me.cmbEmp.Text, " شهر ", Me.cmbMonth.Text, "  لسنة ", Me.cmbYear.Text }))
									End If
								End If
							Catch ex As Exception
							End Try
							Me.CLR()
						End If
						MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex2 As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
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
					Dim sqlCommand As SqlCommand = New SqlCommand("update SalaryPay set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Me.CLR()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
			' The following expression was wrapped in a checked-expression
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from SalaryPay where id=" + Conversions.ToString(Me.Code))
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
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				dr.Read()
				Me.CLR()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
				Me.txtDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("date")))
				Me.LoadEmp(Conversions.ToInteger(dr("emp_resp")))
				Me.cmbMonth.Text = Conversions.ToString(dr("month"))
				Me.cmbYear.Text = Conversions.ToString(dr("year"))
				Me.cmbBranch.SelectedValue = RuntimeHelpers.GetObjectValue(dr("branch"))
				Me.cmbEmp.SelectedValue = RuntimeHelpers.GetObjectValue(dr("emp"))
				Me.txtTotSalary.Text = Conversions.ToString(dr("tot_salary"))
				Me.txtSalaryAdd.Text = Conversions.ToString(dr("salary_add"))
				Me.txtSalarySub.Text = Conversions.ToString(dr("salary_sub"))
				Try
					Me.txtSalarySlf.Text = Conversions.ToString(dr("salary_slf"))
				Catch ex As Exception
				End Try
				Me.txtNet.Text = Conversions.ToString(dr("salary_net"))
				Me.txtNotes.Text = Conversions.ToString(dr("notes"))
				dr.Close()
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

  Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			Me.Navigate("select top 1 * from SalaryPay where IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from SalaryPay where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from SalaryPay where IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from SalaryPay where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Sub Search()
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.txtNoSrch.Text.Trim(), "", False) <> 0
			If flag Then
				text = text + " SalaryPay.id=" + Me.txtNoSrch.Text + " and "
			Else
				flag = (Operators.CompareString(Me.cmbEmpSrch.Text.Trim(), "", False) <> 0 And Me.cmbEmpSrch.SelectedIndex <> -1)
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" SalaryPay.emp=", Me.cmbEmpSrch.SelectedValue), " and ")))
				End If
				text += " date>=@date1 and date<=@date2 and "
			End If
			Me.LoadDG(text)
		End Sub

  Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
			Me.Search()
		End Sub

	Private Sub dgvEmpsSalary_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) ' Handles dgvEmpsSalary.CellValueChanged
	End Sub

	Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbMonth.SelectedIndexChanged
			Try
				Dim flag As Boolean = Me.cmbEmp.SelectedValue IsNot Nothing
				If flag Then
					Me.CalcEmpSalary()
				End If
			Catch ex As Exception
			End Try
		End Sub

	Private Sub dgvEmpsSalary_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) 'Handles dgvEmpsSalary.DataError
	End Sub

	Private Sub Add2DG()
			Dim flag As Boolean = Me.cmbBranch.SelectedValue Is Nothing
			If flag Then
				MessageBox.Show("اختر الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbBranch.Focus()
			Else
				flag = (Me.cmbEmp.SelectedValue Is Nothing)
				If flag Then
					MessageBox.Show("اختر الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbEmp.Focus()
				Else
					flag = (Operators.CompareString(Me.txtTotSalary.Text.Trim(), "", False) = 0 Or Conversion.Val(Me.txtTotSalary.Text) = 0.0)
					If flag Then
						MessageBox.Show("ادخل اجمالي المرتب", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.txtTotSalary.Focus()
					Else
						flag = Me._IsUpdateDG
						Dim index As Integer
						If flag Then
							index = Me.dgvSrch.SelectedRows(0).Index
						Else
							Me.dgvSrch.Rows.Add()
							index = Me.dgvSrch.Rows.Count - 1
						End If
						Me.dgvSrch.Rows(index).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.cmbEmp.SelectedValue)
						Me.dgvSrch.Rows(index).Cells(1).Value = Me.txtTotSalary.Text
						Me.dgvSrch.Rows(index).Cells(2).Value = Me.txtSalaryAdd.Text
						Me.dgvSrch.Rows(index).Cells(3).Value = Me.txtSalarySub.Text
						Me.dgvSrch.Rows(index).Cells(4).Value = Me.txtNet.Text
						Me.dgvSrch.Rows(index).Cells(5).Value = Me.txtNotes.Text
						Me._IsUpdateDG = False
						Me._YearSelected = Me.cmbYear.Text
						Me._MonthSelected = Me.cmbMonth.Text
						Me.cmbMonth.Enabled = False
						Me.cmbYear.Enabled = False
						Me.cmbEmp.SelectedIndex = -1
						Me.txtTotSalary.Text = ""
						Me.txtSalaryAdd.Text = ""
						Me.txtSalarySub.Text = ""
						Me.txtNet.Text = ""
						Me.txtNotes.Text = ""
						Me.cmbEmp.Focus()
					End If
				End If
			End If
		End Sub

  Private Sub txtNotes_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtNotes.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.Add2DG()
			End If
		End Sub

		Private Sub CalcEmpSalary()
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Dim value As Integer = Conversions.ToInteger(Me.cmbEmp.SelectedValue)
				Dim dateTime As DateTime
				Dim dateTime2 As DateTime
				Dim sqlDataAdapter As SqlDataAdapter
				Dim dataTable As DataTable
				Dim flag As Boolean
				Dim day As Integer = DateTime.DaysInMonth(CInt(Math.Round(Conversion.Val(Me.cmbYear.Text))), CInt(Math.Round(Conversion.Val(Me.cmbMonth.Text))))
				dateTime = New DateTime(CInt(Math.Round(Conversion.Val(Me.cmbYear.Text))), CInt(Math.Round(Conversion.Val(Me.cmbMonth.Text))), 1)
				dateTime2 = New DateTime(CInt(Math.Round(Conversion.Val(Me.cmbYear.Text))), CInt(Math.Round(Conversion.Val(Me.cmbMonth.Text))), day)
				sqlDataAdapter = New SqlDataAdapter("select salary_basic,salary_add,salary_other,house,travel,food,medical from Employees where id=" + Conversions.ToString(value), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(1))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(2))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(3))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(4))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(5))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(6)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select isnull(sum(EmpSalaryAddSub.val),0) from EmpSalaryAddSub,SalaryAddSubTypes where EmpSalaryAddSub.type=SalaryAddSubTypes.id and SalaryAddSubTypes.ISAdd=1 and EmpSalaryAddSub.IS_Deleted=0 and date>=@date1 and date<=@date2 and emp=" + Conversions.ToString(value), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select isnull(sum(EmpSalaryAddSub.val),0) from EmpSalaryAddSub,SalaryAddSubTypes where EmpSalaryAddSub.type=SalaryAddSubTypes.id and SalaryAddSubTypes.ISAdd=0 and SalaryAddSubTypes.id=3 and EmpSalaryAddSub.IS_Deleted=0 and date>=@date1 and date<=@date2 and emp=" + Conversions.ToString(value), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select isnull(sum(EmpSalaryAddSub.val),0) from EmpSalaryAddSub,SalaryAddSubTypes where EmpSalaryAddSub.type=SalaryAddSubTypes.id and SalaryAddSubTypes.ISAdd=0 and SalaryAddSubTypes.id=4 and EmpSalaryAddSub.IS_Deleted=0 and date>=@date1 and date<=@date2 and emp=" + Conversions.ToString(value), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				Dim value2 As Double = num + num2 - num3 - num4
				Me.txtTotSalary.Text = "" + Conversions.ToString(num)
				Me.txtSalaryAdd.Text = "" + Conversions.ToString(num2)
				Me.txtSalarySub.Text = "" + Conversions.ToString(num3)
				Me.txtSalarySlf.Text = "" + Conversions.ToString(num4)
				Me.txtNet.Text = "" + Conversions.ToString(value2)
			Catch ex As Exception
			End Try
		End Sub

  Private Sub cmbEmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbEmp.SelectedIndexChanged
			Me.CalcEmpSalary()
		End Sub

  Private Sub frmSalaryPay_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)' Handles frmSalaryPay.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				SendKeys.Send("{TAB}")
			End If
		End Sub

  Private Sub txtTotSalary_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotSalary.TextChanged
			Try
				Me.txtNet.Text = "" + Conversions.ToString(Conversion.Val(Me.txtTotSalary.Text) + Conversion.Val(Me.txtSalaryAdd.Text) - Conversion.Val(Me.txtSalarySub.Text))
			Catch ex As Exception
			End Try
		End Sub

	Private Sub dgvEmpsSalary_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) ' Handles dgvEmpsSalary.CellClick
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select branch from Employees where id=", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbBranch.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
			Me.cmbEmp.SelectedValue = Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value)
			Me.txtTotSalary.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(1).Value))
			Me.txtSalaryAdd.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value))
			Me.txtSalarySub.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(3).Value))
			Me.txtNet.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(4).Value))
			Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(5).Value))
			Me._IsUpdateDG = True
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles Button2.Click
		Me._IsUpdateDG = False
		Me.cmbEmp.SelectedIndex = -1
		Me.txtTotSalary.Text = ""
		Me.txtSalaryAdd.Text = ""
		Me.txtSalarySub.Text = ""
		Me.txtNet.Text = ""
		Me.txtNotes.Text = ""
		Me.cmbEmp.Focus()
	End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles Button1.Click
		Me.Add2DG()
	End Sub

	Private Sub cmbYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbYear.SelectedIndexChanged
			Try
				Dim flag As Boolean = Me.cmbEmp.SelectedValue IsNot Nothing
				If flag Then
					Me.CalcEmpSalary()
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtNoSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNoSrch.KeyPress
			MainClass.ISInteger(e)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Try
				Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag Then
					obj = New rptSalaryRec()
				Else
					obj = New rptSalaryRec___EN()
				End If
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "name" }, Nothing, Nothing, Nothing), TextObject)
				textObject.Text = Me.cmbEmp.Text
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "val" }, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtNet.Text
				Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "basic" }, Nothing, Nothing, Nothing), TextObject)
				textObject3.Text = Me.txtTotSalary.Text
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "net" }, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.txtNet.Text
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "add" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtSalaryAdd.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sub" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.txtSalarySub.Text
				Try
					Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "slf" }, Nothing, Nothing, Nothing), TextObject)
					textObject7.Text = Me.txtSalarySlf.Text
				Catch ex As Exception
				End Try
				Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "month" }, Nothing, Nothing, Nothing), TextObject)
				textObject8.Text = Me.cmbMonth.Text
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "year" }, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.cmbYear.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim instance As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
				Dim type As Type = Nothing
				Dim memberName As String = "SetDataSource"
				Dim array As Object() = New Object() { dataTable }
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, True)
				If array2(0) Then
					dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
				frmRptViewer.WindowState = FormWindowState.Maximized
				frmRptViewer.Show()
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub PrintRptRslt(type As Integer)
			Dim flag As Boolean = Me.dgvSrch.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("type")
				dataTable.Columns.Add("sumsale")
				dataTable.Columns.Add("sumpurch")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvSrch.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), Operators.ConcatenateObject(Operators.ConcatenateObject(Me.dgvSrch.Rows(num3).Cells(4).Value, " لسنة "), Me.dgvSrch.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim rptEmpSalaryPay As rptEmpSalaryPay = New rptEmpSalaryPay()
				rptEmpSalaryPay.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject.Text = Me.cmbEmpSrch.Text
				Dim textObject2 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtFromDate.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtToDate.Value.ToShortDateString()
				Try
					Dim textObject4 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(1).ReportObjects("sum"), TextObject)
					textObject4.Text = Me.txtSum.Text
				Catch ex As Exception
				End Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptEmpSalaryPay.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject8 As TextObject = CType(rptEmpSalaryPay.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptEmpSalaryPay
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptEmpSalaryPay.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex2 As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrintRslt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintRslt.Click
			Me.PrintRptRslt(1)
		End Sub
	End Class
