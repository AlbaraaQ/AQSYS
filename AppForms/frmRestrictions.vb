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
Public Partial Class frmRestrictions
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRestrictions_Load
			frmRestrictions.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRestrictions.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRestrictions.__ENCList.Count = frmRestrictions.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRestrictions.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRestrictions.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRestrictions.__ENCList(num) = frmRestrictions.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRestrictions.__ENCList.RemoveRange(num, frmRestrictions.__ENCList.Count - num)
					frmRestrictions.__ENCList.Capacity = frmRestrictions.__ENCList.Count
				End If
				frmRestrictions.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

		Private Sub LoadDG(cond As String)
			Me.dgvSrch.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,date,doc_no,type,state,notes from Restrictions where type<>11 and IS_Deleted=0 " + cond + " order by id", Me.conn)
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
				Dim num6 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("type")))))
				Me.dgvSrch.Rows(num3).Cells(2).Value = Me.cmbType.Items(num6 - 1).ToString()
				Dim num7 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("state")))))
				Me.dgvSrch.Rows(num3).Cells(3).Value = Me.cmbState.Items(num7 - 1).ToString()
				Me.dgvSrch.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("notes"))
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

		Private Sub LoadLastRest()
			Try
				Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type<>11 and IS_Deleted=0 order by id desc")
			Catch ex As Exception
			End Try
		End Sub

  Private Sub frmRestrictions_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmRestrictions.Load
			Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadLastRest()
			Me.WindowState = MainClass.Window_State
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim flag As Boolean = dr.HasRows
			If flag Then
				dr.Read()
				Me.dgvDetails.Rows.Clear()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
				Me.txtDate.Value = Conversions.ToDate(dr("date"))
				Me.cmbType.SelectedIndex = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("type"))) - 1.0))
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
					Me.dgvDetails.Rows(num5).Cells(1).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("dept"))))
					Me.dgvDetails.Rows(num5).Cells(2).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("credit"))))
					Me.dgvDetails.Rows(num5).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("acc_no"))
					Me.dgvDetails.Rows(num5).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("notes"))

						num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("dept")))
						num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("credit")))

					num5 += 1
				End While
				Me.txtTotDebt.Text = String.Format("{0:0.#,##.##}", num)
				Me.txtTotCredit.Text = String.Format("{0:0.#,##.##}", num2)
				flag = (num = num2)
				If flag Then
					Me.txtISBalanced.Text = "قيد متوازن"
				Else
					Me.txtISBalanced.Text = "قيد غير متوازن"
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
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type<>11 and IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type<>11 and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc" }))
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from Restrictions where " + Me.GetCondBranch() + " type<>11 and IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate(String.Concat(New String() { "select top 1 * from Restrictions where ", Me.GetCondBranch(), " type<>11 and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc" }))
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
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.dgvDetails.Rows.Clear()
					Me.btnFirst_Click(Nothing, Nothing)
				Else
					MessageBox.Show("اختر قيد ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Dim flag As Boolean = e.RowIndex >= 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value))))
				Me.Navigate("select * from Restrictions where id=" + Conversions.ToString(Me.Code))
				Me.TabControl1.SelectedIndex = 0
			End If
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
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtNoSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNoSrch.KeyPress
			MainClass.ISInteger(e)
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Dim frmAddRestriction As frmAddRestriction = New frmAddRestriction()
			frmAddRestriction.Show()
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
