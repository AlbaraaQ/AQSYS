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
Public Partial Class frmOpenRestrictions
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer

		Private _chk As Boolean

		Public Shared accsrch As Integer = 0

		Private srch As Boolean

		Private rowinx As Integer

		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.frmAddRestriction_KeyDown
			AddHandler MyBase.Load, AddressOf Me.frmAddRestriction_Load
			frmOpenRestrictions.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me._chk = True
			Me.srch = False
			Me.rowinx = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmOpenRestrictions.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmOpenRestrictions.__ENCList.Count = frmOpenRestrictions.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmOpenRestrictions.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmOpenRestrictions.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmOpenRestrictions.__ENCList(num) = frmOpenRestrictions.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmOpenRestrictions.__ENCList.RemoveRange(num, frmOpenRestrictions.__ENCList.Count - num)
					frmOpenRestrictions.__ENCList.Capacity = frmOpenRestrictions.__ENCList.Count
				End If
				frmOpenRestrictions.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Shared Sub New()
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub LoadDG(cond As String)
			Me.dgvSrch.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,date,doc_no,type,state,notes from Restrictions where type=11 and IS_Deleted=0 " + cond + " order by id", Me.conn)
			Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
			If flag Then
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
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
				Dim num6 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("state")))))
				Me.dgvSrch.Rows(num3).Cells(2).Value = Me.cmbState.Items(num6 - 1).ToString()
				Me.dgvSrch.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("notes"))
				num3 += 1
			End While
			Me.dgvSrch.ClearSelection()
		End Sub

		Private Function GetCondBranch() As String
			Dim result As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				result = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Return result
		End Function

  Private Sub frmAddRestriction_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmAddRestriction.Load
			Me._chk = False
			Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.cmbState.SelectedIndex = 0
			Me.LoadAccounts()
			Me.LoadNxtNo()
			Me.txtNotes.Text = "قيد افتتاحي"
			Me.WindowState = MainClass.Window_State
			Me._chk = True
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim flag As Boolean = dr.HasRows
			If flag Then
				dr.Read()
				Me.dgvDetails.Rows.Clear()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
				Me.txtDate.Value = Conversions.ToDate(dr("date"))
				Me.cmbState.SelectedIndex = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("state"))) - 1.0))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				dr.Close()
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Restrictions_Sub where branch=" + Conversions.ToString(MainClass.BranchNo) + " and res_id=" + Conversions.ToString(Me.Code), Me.conn)
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
					Me.dgvDetails.Rows.Add()
					Me.dgvDetails.Rows(num5).Cells(0).Value = num5 + 1
					Me.dgvDetails.Rows(num5).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("dept"))
					Me.dgvDetails.Rows(num5).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("credit"))
					Me.dgvDetails.Rows(num5).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("acc_no"))
					Me.dgvDetails.Rows(num5).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("notes"))

						num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("dept")))
						num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("credit")))

					num5 += 1
				End While
				Me.txtTotDebt.Text = "" + String.Format("{0:n}", num)
				Me.txtTotCredit.Text = "" + String.Format("{0:n}", num2)
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					Dim flag2 As Boolean = Math.Round(num, 2) = Math.Round(num2, 2)
					If flag2 Then
						Me.txtISBalanced.Text = "قيد متوازن"
					Else
						Me.txtISBalanced.Text = "قيد غير متوازن"
					End If
				Else
					Dim flag2 As Boolean = Math.Round(num, 2) = Math.Round(num2, 2)
					If flag2 Then
						Me.txtISBalanced.Text = "Balanced Restriction"
					Else
						Me.txtISBalanced.Text = "Not Balanced Restriction"
					End If
				End If
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
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + "  type=11 and IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type=11 and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc" }))
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type=11 and IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type=11 and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc" }))
		End Sub

		Private Sub Search()
			Dim str As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				str = "and branch=" + Conversions.ToString(MainClass.BranchNo)
			End If
			flag = (Operators.CompareString(Me.txtNoSrch.Text, "", False) <> 0)
			Dim cond As String
			If flag Then
				cond = str + " and id=" + Me.txtNoSrch.Text
			Else
				cond = str + " and date>=@date1 and date<=@date2 "
			End If
			Me.LoadDG(cond)
		End Sub

  Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
			Me.Search()
		End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update Restrictions set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag2 Then
						MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.CLR()
				Else
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						MessageBox.Show("اختر قيد ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Select restriction to be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text = "Error in deleting"
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Sub LoadAccounts()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 and (acc_branch=" + Conversions.ToString(MainClass.BranchNo) + " or acc_branch is null ) order by code ", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvDetails.Columns(2), DataGridViewComboBoxColumn)
				dataGridViewComboBoxColumn.DataSource = dataTable
				dataGridViewComboBoxColumn.DisplayMember = "AName"
				dataGridViewComboBoxColumn.ValueMember = "Code"
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Dim flag As Boolean = e.RowIndex >= 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value))))
				Me.Navigate("select * from Restrictions where id=" + Conversions.ToString(Me.Code))
				Me.TabControl1.SelectedIndex = 0
			End If
		End Sub

  Private Sub txtNoSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNoSrch.KeyPress
			MainClass.ISInteger(e)
		End Sub

  Private Sub dgvDetails_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvDetails.CellValueChanged
			Dim chk As Boolean = Me._chk
			If chk Then
				Try
					Dim flag As Boolean = e.ColumnIndex = 1
					If flag Then
						Try
							Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select code from Accounts_Index where code=", Me.dgvDetails.Rows(e.RowIndex).Cells(1).Value)), Me.conn)
							Dim dataTable As DataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							flag = (dataTable.Rows.Count > 0)
							If flag Then
								Me.dgvDetails.Rows(e.RowIndex).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
							End If
						Catch ex As Exception
						End Try
					Else
						flag = (e.ColumnIndex = 2)
						If flag Then
							Me.dgvDetails.Rows(e.RowIndex).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(e.RowIndex).Cells(2).Value)
						Else
							flag = (e.ColumnIndex = 3 Or e.ColumnIndex = 4)
							If flag Then
								Me.CalcTotalDeptCredit()
							End If
						End If
					End If
				Catch ex2 As Exception
				End Try
			End If
		End Sub

		Private Sub LoadNxtNo()
			Try
				Dim value As Integer = 1
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from Restrictions where branch=" + Conversions.ToString(MainClass.BranchNo), Me.conn1)
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

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.dgvDetails.Rows.Clear()
			Me.LoadNxtNo()
			Me.chkPostponed.Checked = False
			Me.cmbState.SelectedIndex = 0
			Me.Code = -1
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub dgvDetails_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvDetails.CurrentCellChanged
			Try
				' The following expression was wrapped in a checked-expression
				Me.dgvDetails.Rows(Me.dgvDetails.CurrentCell.RowIndex).Cells(0).Value = Me.dgvDetails.CurrentCell.RowIndex + 1
			Catch ex As Exception
			End Try
		End Sub

		Private Sub CalcTotalDeptCredit()
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.dgvDetails.Rows.Count - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num5).Cells(3).Value))
					num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num5).Cells(4).Value))
					num5 += 1
				End While
				Me.txtTotDebt.Text = "" + Conversions.ToString(num)
				Me.txtTotCredit.Text = "" + Conversions.ToString(num2)
				Dim flag As Boolean = num >= num2
				If flag Then
					Me.txtDiff.Text = Conversions.ToString(num - num2) + " مدين"
				Else
					Me.txtDiff.Text = Conversions.ToString(num2 - num) + " دائن"
				End If
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					Dim flag2 As Boolean = Math.Round(num, 2) = Math.Round(num2, 2)
					If flag2 Then
						Me.txtISBalanced.Text = "قيد متوازن"
						Me.chkPostponed.Enabled = False
						Me.cmbState.SelectedIndex = 0
					Else
						Me.txtISBalanced.Text = "قيد غير متوازن"
						Me.chkPostponed.Enabled = True
						Me.cmbState.SelectedIndex = 1
					End If
				Else
					Dim flag2 As Boolean = Math.Round(num, 2) = Math.Round(num2, 2)
					If flag2 Then
						Me.txtISBalanced.Text = "Balanced Restriction"
					Else
						Me.txtISBalanced.Text = "Not Balanced Restriction"
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvDetails_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvDetails.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 6
				If flag Then
					Me.dgvDetails.Rows.RemoveAt(e.RowIndex)
					Me.CalcTotalDeptCredit()
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.dgvDetails.Rows.Count = 1
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						MessageBox.Show("لم يتم ادخال حسابات في القيد", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("There is no Accounts inserted to the table", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.dgvDetails.Focus()
				Else
					Dim flag2 As Boolean = Conversion.Val(Me.txtTotDebt.Text) <> Conversion.Val(Me.txtTotCredit.Text) And Not Me.chkPostponed.Checked
					If flag2 Then
						Dim dialogResult As DialogResult = MessageBox.Show("يجب أن يكون القيد متوازن، هل تريد حفظه كقيد معلق", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						flag2 = (dialogResult = DialogResult.No)
						If flag2 Then
							Me.dgvDetails.Focus()
							Return
						End If
						Me.cmbState.SelectedIndex = 1
						Me.chkPostponed.Checked = True
					End If
					flag2 = (Me.conn.State <> ConnectionState.Open)
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlTransaction As SqlTransaction = Me.conn.BeginTransaction()
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag2 = (Me.Code = -1)
					If flag2 Then
						Me.LoadNxtNo()
						Me.Code = CInt(Math.Round(Conversion.Val("" + Me.txtNo.Text)))
						sqlCommand = New SqlCommand("insert into Restrictions (id,date,doc_no,type,state,notes,branch,IS_Deleted)values(" + Conversions.ToString(Me.Code) + ",@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
					Else
						sqlCommand = New SqlCommand("update Restrictions set date=@date ,doc_no=@doc_no ,type=@type ,state=@state ,notes=@notes ,branch=@branch ,IS_Deleted=@IS_Deleted where id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
						Dim sqlCommand2 As SqlCommand = New SqlCommand("delete from Restrictions_Sub where res_id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
						sqlCommand2.ExecuteNonQuery()
					End If
					Dim num As Integer = 11
					sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
					sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = -1
					sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = num
					sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = Me.cmbState.SelectedIndex + 1
					sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
					sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
					sqlCommand.ExecuteNonQuery()
					Dim num2 As Integer = 0
					Dim num3 As Integer = Me.dgvDetails.Rows.Count - 2
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
						sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = Me.Code
						sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(3).Value))
						sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(4).Value))
						sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(1).Value))
						sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dgvDetails.Rows(num4).Cells(5).Value)
						sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
						sqlCommand.ExecuteNonQuery()
						num4 += 1
					End While
					flag2 = (Me.Code = -1)
					If flag2 Then
						sqlCommand = New SqlCommand("select max(id) from Restrictions", Me.conn, sqlTransaction)
						Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
					End If
					sqlTransaction.Commit()
					flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag2 Then
						MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex As Exception
				Dim sqlTransaction As SqlTransaction
				sqlTransaction.Rollback()
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text = "Error in saving"
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub frmAddRestriction_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)' Handles frmAddRestriction.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				SendKeys.Send("{TAB}")
			End If
		End Sub

	Private Sub txtDept_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) ' Handles txtDept.KeyPress
		MainClass.IsFloat(e)
	End Sub

	Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) ' Handles txtCredit.KeyPress
		MainClass.IsFloat(e)
	End Sub

	Private Function GetAccName(AccCode As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(AccCode), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Return ""
		End Function

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvDetails.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("id")
				dataTable.Columns.Add("code")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("debt")
				dataTable.Columns.Add("credit")
				dataTable.Columns.Add("notes")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvDetails.Rows.Count - 2
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(1).Value), Me.GetAccName(Conversions.ToInteger(Me.dgvDetails.Rows(num3).Cells(2).Value)), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim rptRestrictions As rptRestrictions = New rptRestrictions()
				rptRestrictions.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptRestrictions.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
				textObject.Text = Me.txtNo.Text
				Dim textObject2 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
				textObject2.Text = Me.txtDate.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(1).ReportObjects("notes"), TextObject)
				textObject3.Text = Me.txtNotes.Text
				Dim textObject4 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(4).ReportObjects("sum1"), TextObject)
				textObject4.Text = Me.txtTotDebt.Text
				Dim textObject5 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(4).ReportObjects("sum2"), TextObject)
				textObject5.Text = Me.txtTotCredit.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptRestrictions.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject6 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject7 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject8 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject9 As TextObject = CType(rptRestrictions.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptRestrictions
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptRestrictions.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub dgvDetails_RowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs) Handles dgvDetails.RowsAdded
		End Sub

  Private Sub dgvDetails_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvDetails.DataError
		End Sub

  Private Sub txtTotDebt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotDebt.TextChanged
			Me.txtTotDebtAr.Text = Number2Arabic.ameral(Conversions.ToString(Conversion.Val(Me.txtTotDebt.Text)))
		End Sub

  Private Sub txtTotCredit_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotCredit.TextChanged
			Me.txtTotCreditAr.Text = Number2Arabic.ameral(Conversions.ToString(Conversion.Val(Me.txtTotCredit.Text)))
		End Sub

  Private Sub dgvDetails_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetails.EditingControlShowing
			Try
				Dim flag As Boolean = e.Control.[GetType]() Is GetType(DataGridViewComboBoxEditingControl)
				If flag Then
					Dim comboBox As ComboBox = TryCast(e.Control, ComboBox)
					flag = (comboBox IsNot Nothing)
					If flag Then
						comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
						comboBox.AutoCompleteSource = AutoCompleteSource.ListItems
						comboBox.DropDownStyle = ComboBoxStyle.DropDown
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

	Private Sub txtAccCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) ' Handles txtAccCode.TextChanged
		Try
			Me.srch = False
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtAccName_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) ' Handles txtAccName.PreviewKeyDown
		Try
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Try
				Me.Timer1.Enabled = False
				Me.dgvDetails.Rows(Me.rowinx).Cells(2).Value = Me.GetAccName(frmOpenRestrictions.accsrch)
			Catch ex As Exception
			End Try
		End Sub

  Private Sub chkPostponed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPostponed.CheckedChanged
			Dim checked As Boolean = Me.chkPostponed.Checked
			If checked Then
				Me.cmbState.SelectedIndex = 1
			Else
				Me.cmbState.SelectedIndex = 0
			End If
		End Sub

  Private Sub cmbState_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbState.SelectedIndexChanged
			Try
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvDetails_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvDetails.CellContentClick
		End Sub
	End Class
