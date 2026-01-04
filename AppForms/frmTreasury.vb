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
Imports AQSYS.My.Resources
	Public Partial Class frmTreasury
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmTreasury_Load
			frmTreasury.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmTreasury.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmTreasury.__ENCList.Count = frmTreasury.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmTreasury.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmTreasury.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmTreasury.__ENCList(num) = frmTreasury.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmTreasury.__ENCList.RemoveRange(num, frmTreasury.__ENCList.Count - num)
					frmTreasury.__ENCList.Capacity = frmTreasury.__ENCList.Count
				End If
				frmTreasury.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			Me.txtName.Focus()
			Me.txtName.Text = ""
			Me.dgvSafeEmps.Rows.Clear()
			Me.cmbBranches.SelectedIndex = -1
			Me.cmbStatus.SelectedIndex = -1
			Me.chkDefault.Checked = False
			Me.txtNotes.Text = ""
			Me.Code = -1
		End Sub

		Private Sub LoadDG()
			Me.dgvStocks.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Stocks.id as stock_id,Stocks.name as stock,Branches.name as branch from Stocks,Branches  where Stocks.IS_Deleted=0 and Stocks.branch=branches.id", Me.conn)
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
				Me.dgvStocks.Rows.Add()
				Me.dgvStocks.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("stock_id"))
				Me.dgvStocks.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("stock"))
				Me.dgvStocks.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("branch"))
				num3 += 1
			End While
			Me.dgvStocks.ClearSelection()
		End Sub

  Private Sub frmTreasury_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmTreasury.Load
			Me.LoadBranches()
			Me.LoadStates()
			Me.LoadEmps()
			Me.LoadDG()
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

		Private Function GetEmpName(emp As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn)
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

		Public Sub LoadEmps()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvSafeEmps.Columns(0), DataGridViewComboBoxColumn)
			dataGridViewComboBoxColumn.DataSource = dataTable
			dataGridViewComboBoxColumn.DisplayMember = "name"
			dataGridViewComboBoxColumn.ValueMember = "id"
		End Sub

		Public Sub LoadBranches()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbBranches.DataSource = dataTable
			Me.cmbBranches.DisplayMember = "name"
			Me.cmbBranches.ValueMember = "id"
			Me.cmbBranches.SelectedIndex = -1
		End Sub

		Public Sub LoadStates()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from States order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbStatus.DataSource = dataTable
			Me.cmbStatus.DisplayMember = "name"
			Me.cmbStatus.ValueMember = "id"
			Me.cmbStatus.SelectedIndex = -1
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Me.txtName.Focus()
				Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						MessageBox.Show("ادخل اسم الخزينة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Enter safe name", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.txtName.Focus()
				Else
					Dim flag2 As Boolean = Me.cmbBranches.SelectedIndex = -1
					If flag2 Then
						flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
						If flag Then
							MessageBox.Show("يجب اختيار الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							MessageBox.Show("choose branch", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
						Me.cmbBranches.Focus()
					Else
						flag2 = (Me.dgvSafeEmps.Rows.Count = 1)
						If flag2 Then
							flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag Then
								MessageBox.Show("يجب اختيار المسئول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("choose responsible employee", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Me.dgvSafeEmps.Focus()
						Else
							Dim num As Integer = 0
							Dim num2 As Integer = Me.dgvSafeEmps.Rows.Count - 2
							Dim num3 As Integer = num
							While True
								Dim num4 As Integer = num3
								Dim num5 As Integer = num2
								If num4 > num5 Then
									GoTo Block_11
								End If
								flag2 = (Me.dgvSafeEmps.Rows(num3).Cells(0).Value Is Nothing)
								If flag2 Then
									Exit While
								End If
								num3 += 1
							End While
							flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag Then
								MessageBox.Show("لم تختر مسئول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("you not choose responsible employee", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Me.dgvSafeEmps.Rows(num3).Selected = True
							Return
							Block_11:
							Dim num6 As Integer = 0
							Dim num7 As Integer = Me.dgvSafeEmps.Rows.Count - 2
							Dim num8 As Integer = num6
							Dim num12 As Integer
							While True
								Dim num9 As Integer = num8
								Dim num5 As Integer = num7
								If num9 > num5 Then
									GoTo Block_15
								End If
								Dim num10 As Integer = num8 + 1
								Dim num11 As Integer = Me.dgvSafeEmps.Rows.Count - 2
								num12 = num10
								While True
									Dim num13 As Integer = num12
									num5 = num11
									If num13 > num5 Then
										Exit While
									End If
									flag2 = Operators.ConditionalCompareObjectEqual(Me.dgvSafeEmps.Rows(num8).Cells(0).Value, Me.dgvSafeEmps.Rows(num12).Cells(0).Value, False)
									If flag2 Then
										GoTo Block_12
									End If
									num12 += 1
								End While
								num8 += 1
							End While
							Block_12:
							flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag Then
								MessageBox.Show("لقد كررت ادخال الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("you repeat inserting the employee", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Me.dgvSafeEmps.Rows(num12).Selected = True
							Return
							Block_15:
							flag2 = (Me.conn.State <> ConnectionState.Open)
							If flag2 Then
								Me.conn.Open()
							End If
							Dim sqlCommand As SqlCommand = New SqlCommand()
							flag2 = (Me.Code <> -1)
							If flag2 Then
								sqlCommand = New SqlCommand("delete from Stock_Emps where stock_id=" + Conversions.ToString(Me.Code), Me.conn)
								sqlCommand.ExecuteNonQuery()
							End If
							flag2 = (Me.Code <> -1)
							If flag2 Then
								Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Accounts_Index.Code from Accounts_Index,Stocks where Accounts_Index.AName=Stocks.name and Accounts_Index.acc_branch=Stocks.branch and Accounts_Index.Type=2 and Stocks.id=" + Conversions.ToString(Me.Code), Me.conn)
								Dim dataTable As DataTable = New DataTable()
								sqlDataAdapter.Fill(dataTable)
								flag2 = (dataTable.Rows.Count > 0)
								If flag2 Then
									Dim num14 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
									sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Accounts_Index set acc_branch=", Me.cmbBranches.SelectedValue), ",AName='"), Me.txtName.Text), "' where Code="), num14), " and Type=2")), Me.conn)
									sqlCommand.ExecuteNonQuery()
								End If
							End If
							flag2 = (Me.Code = -1)
							If flag2 Then
								sqlCommand = New SqlCommand("insert into Stocks(name,branch,status,IS_Default,notes,IS_Deleted)values(@name,@branch,@status,@IS_Default,@notes,@IS_Deleted)", Me.conn)
							Else
								sqlCommand = New SqlCommand("update Stocks set name=@name,branch=@branch,status=@status,IS_Default=@IS_Default,notes=@notes,IS_Deleted=@IS_Deleted where id=" + Conversions.ToString(Me.Code), Me.conn)
							End If
							sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
							Dim num15 As Integer = -1
							flag2 = (Me.cmbBranches.SelectedValue IsNot Nothing)
							If flag2 Then
								num15 = Conversions.ToInteger(Me.cmbBranches.SelectedValue)
							End If
							sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = num15
							Dim num16 As Integer = -1
							flag2 = (Me.cmbStatus.SelectedValue IsNot Nothing)
							If flag2 Then
								num16 = Conversions.ToInteger(Me.cmbStatus.SelectedValue)
							End If
							sqlCommand.Parameters.Add("@status", SqlDbType.Int).Value = num16
							Dim num17 As Integer = 0
							flag2 = Me.chkDefault.Checked
							If flag2 Then
								num17 = 1
							End If
							sqlCommand.Parameters.Add("@IS_Default", SqlDbType.Bit).Value = num17
							sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
							sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
							sqlCommand.ExecuteNonQuery()
							Dim text As String = "121"
							flag2 = MainClass.IsAccTreeNew
							If flag2 Then
								text = "1103011"
							End If
							flag2 = (Me.Code = -1)
							If flag2 Then
								Dim str As String = MainClass.GenerateCode(Conversions.ToInteger(text))
								sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Accounts_Index(Code,AName,acc_branch,Type,ParentCode,FinalAcc) values ('" + str + "','" + Me.txtName.Text + "',", Me.cmbBranches.SelectedValue), ",2,'"), text), "',1)")), Me.conn)
								sqlCommand.ExecuteNonQuery()
							End If
							flag2 = (Me.Code = -1)
							If flag2 Then
								sqlCommand = New SqlCommand("select max(id) from Stocks", Me.conn)
								Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
							End If
							Dim num18 As Integer = 0
							Dim num19 As Integer = Me.dgvSafeEmps.Rows.Count - 2
							Dim num20 As Integer = num18
							While True
								Dim num21 As Integer = num20
								Dim num5 As Integer = num19
								If num21 > num5 Then
									Exit While
								End If
								sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Stock_Emps(stock_id,emp_id)values(" + Conversions.ToString(Me.Code) + ",", Me.dgvSafeEmps.Rows(num20).Cells(0).Value), ")")), Me.conn)
								sqlCommand.ExecuteNonQuery()
								num20 += 1
							End While
							Me.LoadDG()
							flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag2 Then
								MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
						End If
					End If
				End If
			Catch ex As Exception
				Dim text2 As String = "خطأ أثناء الحفظ"
				text2 = text2 + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text2 = "Error during saving"
					text2 = text2 + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(id) from inv where is_deleted=0 and stock=" + Conversions.ToString(Me.Code), Me.conn)
						Dim dataTable As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
						If flag Then
							Interaction.MsgBox("هذا الصندوق مرتبط بفواتير ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
							Return
						End If
					Catch ex As Exception
					End Try
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update Stocks set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					sqlCommand = New SqlCommand("delete from Stock_Emps where stock_id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where Type=2 and AName='" + Me.txtName.Text + "'", Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						' The following expression was wrapped in a checked-expression
						Dim value As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
						sqlCommand = New SqlCommand("delete from Accounts_Index where Code=" + Conversions.ToString(value), Me.conn)
						sqlCommand.ExecuteNonQuery()
					End If
					flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag Then
						MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.LoadDG()
					Me.CLR()
				Else
					flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag Then
						MessageBox.Show("اختر خزينة ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("choose safe to be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex2 As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag Then
					text = "Error during delete"
					text = text + Environment.NewLine + "Error details: " + ex2.Message
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
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvStocks.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from Stocks where id=" + Conversions.ToString(Me.Code))
		End Sub

  Private Sub dgvStocks_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvStocks.CellClick
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
				Me.txtName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
				flag = Operators.ConditionalCompareObjectNotEqual(dr("branch"), -1, False)
				If flag Then
					Me.cmbBranches.SelectedValue = RuntimeHelpers.GetObjectValue(dr("branch"))
				End If
				flag = Operators.ConditionalCompareObjectNotEqual(dr("status"), -1, False)
				If flag Then
					Me.cmbStatus.SelectedValue = RuntimeHelpers.GetObjectValue(dr("status"))
				End If
				flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("IS_Default")))
				If flag Then
					Me.chkDefault.Checked = True
				Else
					Me.chkDefault.Checked = False
				End If
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				dr.Close()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Stock_Emps where stock_id=" + Conversions.ToString(Me.Code), Me.conn)
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
					Me.dgvSafeEmps.Rows.Add()
					Me.dgvSafeEmps.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("emp_id"))
					num3 += 1
				End While
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvStocks.ClearSelection()
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
			Me.Navigate("select top 1 * from Stocks where IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from Stocks where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from Stocks where IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from Stocks where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvStocks.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("col1")
				dataTable.Columns.Add("col2")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvStocks.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvStocks.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvStocks.Rows(num3).Cells(2).Value) })
					num3 += 1
				End While
				Dim rptcol As rptcol2 = New rptcol2()
				rptcol.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptcol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
				textObject.Text = "الخزن"
				Dim textObject2 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
				textObject2.Text = "الخزينة"
				Dim textObject3 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col2"), TextObject)
				textObject3.Text = "الفرع"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptcol.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject4 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject5 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject6 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject7 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptcol
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptcol.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub dgvSafeEmps_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvSafeEmps.DataError
		End Sub

  Private Sub dgvSafeEmps_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSafeEmps.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 1 And Me.Code <> -1
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select count(id) from inv where is_deleted=0 and stock=" + Conversions.ToString(Me.Code) + " and sales_emp=", Me.dgvSafeEmps.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
					If flag Then
						Interaction.MsgBox("هذا الموظف مرتبط بفواتير لهذا الصندوق ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
					Else
						Me.dgvSafeEmps.Rows.RemoveAt(e.RowIndex)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
