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
Public Partial Class frmAddRestriction
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer

		Public _IsMsg As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.frmAddRestriction_KeyDown
			AddHandler MyBase.Load, AddressOf Me.frmAddRestriction_Load
			frmAddRestriction.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me._IsMsg = True
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmAddRestriction.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmAddRestriction.__ENCList.Count = frmAddRestriction.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmAddRestriction.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmAddRestriction.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmAddRestriction.__ENCList(num) = frmAddRestriction.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmAddRestriction.__ENCList.RemoveRange(num, frmAddRestriction.__ENCList.Count - num)
					frmAddRestriction.__ENCList.Capacity = frmAddRestriction.__ENCList.Count
				End If
				frmAddRestriction.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Function GetCenterName(id As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from costcenter where id=" + Convert.ToString(id), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
			Catch ex As Exception
			End Try
			Return ""
		End Function

		Private Sub LoadDG(cond As String)
			Me.dgvSrch.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,date,doc_no,type,state,notes from Restrictions where type<>11 and doc_no=-1 and IS_Deleted=0 " + cond + " order by id", Me.conn)
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

		Private Sub LoadCenters()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from costcenter order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCenter.DataSource = dataTable
			Me.cmbCenter.DisplayMember = "name"
			Me.cmbCenter.ValueMember = "id"
			Me.cmbCenter.SelectedIndex = -1
		End Sub

		Public Sub LoadData()
			Try
				Dim hide_costcenter As Boolean = MainClass.hide_costcenter
				If hide_costcenter Then
					Me.lblcostcenter.Visible = False
					Me.cmbCenter.Visible = False
				End If
			Catch ex As Exception
			End Try
			Me.txtDate.Value = DateTime.Now
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.cmbState.SelectedIndex = 0
			Me.cmbType.SelectedIndex = 9
			Me.LoadAccounts()
			Me.LoadCenters()
			Me.LoadNxtNo()
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub frmAddRestriction_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmAddRestriction.Load
			Me.LoadData()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim flag As Boolean = dr.HasRows
			If flag Then
				dr.Read()
				Me.dgvDetails.Rows.Clear()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
				Me.txtDate.Value = Conversions.ToDate(dr("date"))
				Try
					flag = (Conversion.Val(Operators.ConcatenateObject("", dr("type"))) <> -1.0)
					If flag Then
						' The following expression was wrapped in a unchecked-expression
						Me.cmbType.SelectedIndex = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("type"))) - 1.0))
					Else
						Me.cmbType.SelectedIndex = 9
					End If
				Catch ex As Exception
				End Try
				Me.cmbState.SelectedIndex = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("state"))) - 1.0))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				dr.Close()
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select * from Restrictions_Sub where branch=", Conversions.ToString(MainClass.BranchNo), " and res_id=", Conversions.ToString(Me.Code), " order by acc_order" }), Me.conn)
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
					Me.dgvDetails.Rows(num5).Cells(1).Value = String.Format("{0:n}", RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("dept")))
					Me.dgvDetails.Rows(num5).Cells(2).Value = String.Format("{0:n}", RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("credit")))
					Me.dgvDetails.Rows(num5).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("acc_no"))
					Me.dgvDetails.Rows(num5).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("notes"))
					Try
						Me.dgvDetails.Rows(num5).Cells(6).Value = Me.GetCenterName(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("center"))))
						Me.dgvDetails.Rows(num5).Cells(7).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("center"))
					Catch ex2 As Exception
					End Try

						num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("dept")))
						num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("credit")))

					num5 += 1
				End While
				Me.txtTotDebt.Text = "" + String.Format("{0:n}", num)
				Me.txtTotCredit.Text = "" + String.Format("{0:n}", num2)
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					Dim flag2 As Boolean = num = num2
					If flag2 Then
						Me.txtISBalanced.Text = "قيد متوازن"
					Else
						Me.txtISBalanced.Text = "قيد غير متوازن"
					End If
				Else
					Dim flag2 As Boolean = num = num2
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
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type<>11 and doc_no=-1 and IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type<>11 and doc_no=-1 and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc" }))
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type<>11 and doc_no=-1 and IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type<>11 and doc_no=-1 and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc" }))
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
					Dim sqlCommand As SqlCommand = New SqlCommand("update Restrictions set IS_Deleted=1 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.Code), Me.conn)
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
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 ", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.cmbAccName.DataSource = dataTable
				Me.cmbAccName.DisplayMember = "AName"
				Me.cmbAccName.ValueMember = "Code"
				Me.cmbAccName.SelectedIndex = -1
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

  Private Sub txtAccCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAccCode.TextChanged
			Try
				Me.cmbAccName.SelectedValue = Me.txtAccCode.Text
			Catch ex As Exception
			End Try
		End Sub

  Private Sub cmbAccName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccName.SelectedIndexChanged
			Try
				Me.txtAccCode.Text = Conversions.ToString(Me.cmbAccName.SelectedValue)
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtAccCode_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAccCode.KeyPress
			MainClass.ISInteger(e)
		End Sub

  Private Sub txtNoSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNoSrch.KeyPress
			MainClass.ISInteger(e)
		End Sub

  Private Sub dgvDetails_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvDetails.CellValueChanged
			Try
				Dim flag As Boolean = e.ColumnIndex = 3
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select AName from Accounts_Index where Code=", Me.dgvDetails.Rows(e.RowIndex).Cells(3).Value)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						Me.dgvDetails.Rows(e.RowIndex).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
					End If
				Else
					flag = (e.ColumnIndex = 1 Or e.ColumnIndex = 2)
					If flag Then
						Me.CalcTotalDeptCredit()
					End If
				End If
			Catch ex As Exception
			End Try
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
			Me.cmbState.SelectedIndex = 0
			Me.cmbType.SelectedIndex = 9
			Me.Code = -1
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub txtAccNote_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtAccNote.KeyDown
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = e.KeyCode = Keys.[Return]
				If flag Then
					Dim flag2 As Boolean = Me.cmbAccName.SelectedValue Is Nothing
					If flag2 Then
						Dim flag3 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
						If flag3 Then
							MessageBox.Show("اختر الحساب", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							MessageBox.Show("Select Account", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
						Me.cmbAccName.Focus()
					Else
						Dim flag3 As Boolean = Operators.CompareString(Me.txtCredit.Text.Trim(), "", False) = 0 And Operators.CompareString(Me.txtDept.Text.Trim(), "", False) = 0
						If flag3 Then
							flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag2 Then
								MessageBox.Show("ادخل قيمة المدين او الدائن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("Enter Debt. value or Credit value", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							flag3 = (Operators.CompareString(Me.txtDept.Text.Trim(), "", False) = 0)
							If flag3 Then
								Me.txtDept.Focus()
							Else
								flag3 = (Operators.CompareString(Me.txtCredit.Text.Trim(), "", False) = 0)
								If flag3 Then
									Me.txtCredit.Focus()
								End If
							End If
						Else
							Me.dgvDetails.Rows.Add()
							Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(0).Value = Me.dgvDetails.Rows.Count
							Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(1).Value = Conversion.Val("" + Me.txtDept.Text)
							Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(2).Value = Conversion.Val("" + Me.txtCredit.Text)
							Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(3).Value = Me.txtAccCode.Text
							Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(5).Value = Me.txtAccNote.Text
							flag3 = (Me.cmbCenter.SelectedValue IsNot Nothing)
							If flag3 Then
								Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(6).Value = Me.cmbCenter.Text
								Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(7).Value = RuntimeHelpers.GetObjectValue(Me.cmbCenter.SelectedValue)
							Else
								Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(6).Value = ""
								Me.dgvDetails.Rows(Me.dgvDetails.Rows.Count - 1).Cells(7).Value = -1
							End If
							Me.CalcTotalDeptCredit()
							Me.cmbAccName.SelectedIndex = -1
							Me.txtAccCode.Text = ""
							Me.txtDept.Text = ""
							Me.txtCredit.Text = ""
							Me.txtAccNote.Text = ""
							Me.cmbCenter.SelectedIndex = -1
							Me.txtAccCode.Focus()
						End If
					End If
				End If
			Catch ex As Exception
			End Try
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
					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num5).Cells(1).Value))
					num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num5).Cells(2).Value))
					num5 += 1
				End While
				Me.txtTotDebt.Text = "" + String.Format("{0:n}", num)
				Me.txtTotCredit.Text = "" + String.Format("{0:n}", num2)
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag Then
					Dim flag2 As Boolean = num = num2
					If flag2 Then
						Me.txtISBalanced.Text = "قيد متوازن"
					Else
						Me.txtISBalanced.Text = "قيد غير متوازن"
					End If
				Else
					Dim flag2 As Boolean = num = num2
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
				Dim flag As Boolean = e.ColumnIndex = 8
				If flag Then
					Me.dgvDetails.Rows.RemoveAt(e.RowIndex)
					Me.CalcTotalDeptCredit()
				End If
			Catch ex As Exception
			End Try
		End Sub

  Public Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Not MainClass.IsTrial
				If flag Then
					Dim flag2 As Boolean = MainClass.ISExpire(Me.txtDate.Value)
					If flag2 Then
						Return
					End If
				End If
			Catch ex As Exception
			End Try
			Try
				Dim flag2 As Boolean = MainClass.IsTrial And Me.Code = -1
				If flag2 Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Restrictions where doc_no=-1", Me.conn1)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag2 = (dataTable.Rows.Count >= 10)
					If flag2 Then
						Dim text As String = "لقد وصلت لأقصى حد ادخال للنسخة التجريبية، يمكنك شراء البرنامج وتفعيله من خلال بيانات الدعم الفني بالبرنامج"
						flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag2 Then
							text = "you reach the maximum of entries, you can purchase the app and activate it from support data in the app"
						End If
						MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim flag2 As Boolean = Me.dgvDetails.Rows.Count = 0
				If flag2 Then
					Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag Then
						MessageBox.Show("لم يتم ادخال حسابات في القيد", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("There is no Accounts inserted to the table", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.dgvDetails.Focus()
				Else
					Try
						flag2 = (Convert.ToDouble(Me.txtTotDebt.Text) <> Convert.ToDouble(Me.txtTotCredit.Text))
						If flag2 Then
							Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
							If flag Then
								MessageBox.Show("يجب أن يكون القيد متوازن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("The restriction must be balanced", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Me.dgvDetails.Focus()
							Return
						End If
					Catch ex3 As Exception
					End Try
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
						Dim sqlCommand2 As SqlCommand = New SqlCommand("delete from Restrictions_Sub where branch=" + Conversions.ToString(MainClass.BranchNo) + " and res_id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
						sqlCommand2.ExecuteNonQuery()
					End If
					Dim num As Integer = Me.cmbType.SelectedIndex + 1
					sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
					sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = -1
					sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = num
					sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = Me.cmbState.SelectedIndex + 1
					sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
					sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
					sqlCommand.ExecuteNonQuery()
					Dim num2 As Integer = 0
					Dim num3 As Integer = Me.dgvDetails.Rows.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch,center,acc_order)values(@res_id,@dept,@credit,@acc_no,@notes,@branch,@center,@acc_order)", Me.conn, sqlTransaction)
						sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = Me.Code
						sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(1).Value))
						sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(2).Value))
						sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(3).Value))
						sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num4).Cells(5).Value)
						sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
						sqlCommand.Parameters.Add("@center", SqlDbType.Int).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvDetails.Rows(num4).Cells(7).Value))
						sqlCommand.Parameters.Add("@acc_order", SqlDbType.Int).Value = num4 + 1
						sqlCommand.ExecuteNonQuery()
						num4 += 1
					End While
					sqlTransaction.Commit()
					flag2 = Me._IsMsg
					If flag2 Then
						Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
						If flag Then
							MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					End If
					Me.CLR()
				End If
			Catch ex4 As Exception
				Dim sqlTransaction As SqlTransaction
				sqlTransaction.Rollback()
				Dim text2 As String = "خطأ أثناء الحفظ"
				text2 = text2 + Environment.NewLine + "تفاصيل الخطأ: " + ex4.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text2 = "Error in saving"
					text2 = text2 + Environment.NewLine + "Error details: " + ex4.Message
				End If
				MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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

  Private Sub txtDept_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDept.KeyPress
			MainClass.IsFloat(e)
		End Sub

  Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCredit.KeyPress
			MainClass.IsFloat(e)
		End Sub

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
				Dim num2 As Integer = Me.dgvDetails.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvDetails.Rows(num3).Cells(5).Value) })
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
	End Class
