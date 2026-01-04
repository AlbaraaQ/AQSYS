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
Public Partial Class frmSalesMen
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmCustomers_Load
			frmSalesMen.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSalesMen.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSalesMen.__ENCList.Count = frmSalesMen.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSalesMen.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSalesMen.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSalesMen.__ENCList(num) = frmSalesMen.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSalesMen.__ENCList.RemoveRange(num, frmSalesMen.__ENCList.Count - num)
					frmSalesMen.__ENCList.Capacity = frmSalesMen.__ENCList.Count
				End If
				frmSalesMen.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.Code = -1
		End Sub

	Private Sub LoadDG(cond As String)
		Me.dgvData.Rows.Clear()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from salesmen where " + cond + " IS_Deleted=0 order by id", Me.conn)
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
			Me.dgvData.Rows.Add()
			Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
			Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
			Me.dgvData.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("comm"))
			Me.dgvData.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("email"))
			Me.dgvData.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
			Me.dgvData.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
			num3 += 1
		End While
		Me.dgvData.ClearSelection()
	End Sub

	Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub frmCustomers_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmCustomers.Load
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
				If flag Then
					Me.conn.Open()
				End If
				Dim sqlCommand As SqlCommand = New SqlCommand()
				flag = (Me.Code = -1)
				If flag Then
					sqlCommand = New SqlCommand("insert into salesmen(name,comm,tel,mobile,email,notes,IS_Deleted) values (@name,@comm,@tel,@mobile,@email,@notes,@IS_Deleted)", Me.conn)
				Else
					sqlCommand = New SqlCommand("update salesmen set name=@name,comm=@comm,tel=@tel,mobile=@mobile,email=@email,notes=@notes where id=" + Conversions.ToString(Me.Code), Me.conn)
				End If
				sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
				sqlCommand.Parameters.Add("@comm", SqlDbType.[Decimal]).Value = Conversion.Val(Me.txtComm.Text)
				sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
				sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
				sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtEmail.Text
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
				sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
				sqlCommand.ExecuteNonQuery()
				Me.CLR()
				MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
					Dim sqlCommand As SqlCommand = New SqlCommand("update salesmen set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Me.CLR()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					MessageBox.Show("اختر مندوب ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

		Private Sub dgvDepsRowChng(row_index As Integer)
			' The following expression was wrapped in a checked-expression
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvData.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from salesmen where id=" + Conversions.ToString(Me.Code))
			Me.TabControl1.SelectedIndex = 0
		End Sub

	Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
		Dim flag As Boolean = e.RowIndex >= 0
		If flag Then
			Me.dgvDepsRowChng(e.RowIndex)
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
				Me.txtName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
				Me.txtComm.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("comm")))
				Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
				Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
				Me.txtEmail.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("email")))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvData.ClearSelection()
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
			Me.Navigate("select top 1 * from salesmen where IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from salesmen where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from salesmen where IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from salesmen where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Sub Search()
			Dim cond As String = "name like '%" + Me.txtNameSrch.Text + "%' and "
			Me.LoadDG(cond)
		End Sub

  Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
			Me.Search()
		End Sub

	Private Sub txtNameSrch_KeyPress_1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNameSrch.KeyPress
		Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
		If flag Then
			Me.Search()
		End If
	End Sub

	Private Function GetNamByID(tbl As String, id As Integer) As String
			Dim result As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from " + tbl + " where id=" + Conversions.ToString(id), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					result = dataTable.Rows(0)(0).ToString()
				Else
					result = ""
				End If
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Private Sub PrintRpt(type As Integer)
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("name")
			dataTable.Columns.Add("ID")
			dataTable.Columns.Add("tel")
			dataTable.Columns.Add("mobile")
			dataTable.Columns.Add("country")
			dataTable.Columns.Add("city")
			dataTable.Columns.Add("area")
			dataTable.Columns.Add("act")
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Customers where IS_Deleted=0 order by id", Me.conn)
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
				dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("name")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("national_id")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("tel")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("mobile")), Me.GetNamByID("countries", Conversions.ToInteger(dataTable2.Rows(num3)("country"))), Me.GetNamByID("cities", Conversions.ToInteger(dataTable2.Rows(num3)("city"))), Me.GetNamByID("areas", Conversions.ToInteger(dataTable2.Rows(num3)("area"))), Me.GetNamByID("acts", Conversions.ToInteger(dataTable2.Rows(num3)("act"))) })
				num3 += 1
			End While
			Dim rptCustomers As rptCustomers = New rptCustomers()
			rptCustomers.SetDataSource(dataTable)
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable3)
			rptCustomers.Subreports("rptHeader").SetDataSource(dataTable3)
			Dim flag As Boolean = dataTable3.Rows.Count > 0
			If flag Then
				Dim textObject As TextObject = CType(rptCustomers.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
				textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
				Dim textObject2 As TextObject = CType(rptCustomers.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
				textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Tel")))
				Dim textObject3 As TextObject = CType(rptCustomers.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
				textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
				Dim textObject4 As TextObject = CType(rptCustomers.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
				textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Fax")))
			End If
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptCustomers
			frmRptViewer.WindowState = FormWindowState.Maximized
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptCustomers.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex As Exception
				End Try
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

	Private Sub txtNationalID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtComm.TextChanged
	End Sub

	Private Sub txtNameSrch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNameSrch.TextChanged
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Dim frmInvBySalesMen As frmInvBySalesMen = New frmInvBySalesMen()
			frmInvBySalesMen.Show()
			frmInvBySalesMen.Activate()
		End Sub
	End Class
