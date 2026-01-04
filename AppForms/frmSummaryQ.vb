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
Public Partial Class frmSummaryQ
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Private conn As SqlConnection

	Private Type As Integer

		Private title As String
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSummaryQ_Load
			frmSummaryQ.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Type = 1
			Me.title = ""
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSummaryQ.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSummaryQ.__ENCList.Count = frmSummaryQ.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSummaryQ.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSummaryQ.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSummaryQ.__ENCList(num) = frmSummaryQ.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSummaryQ.__ENCList.RemoveRange(num, frmSummaryQ.__ENCList.Count - num)
					frmSummaryQ.__ENCList.Capacity = frmSummaryQ.__ENCList.Count
				End If
				frmSummaryQ.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

  Private Sub frmSummaryQ_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSummaryQ.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.cmbType.SelectedIndex = 0
			Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
			If flag Then
				Me.cmbType.Items(0) = "out receipt bonds"
				Me.cmbType.Items(1) = "out exchange bonds"
			End If
		End Sub

	Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Try
			Dim text As String = "SandQ"
			Me.Type = 1
			Dim flag As Boolean = Me.cmbType.SelectedIndex = 1
			If flag Then
				text = "SandD"
				Me.Type = 2
			End If
			Dim text2 As String = ""
			flag = (MainClass.BranchNo <> -1)
			If flag Then
				text2 = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id,date,val,notes from ", text, " where ", text2, " date>=@date1 and date<=@date2 and IS_Deleted=0 order by id"}), Me.conn)
			sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
			Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
			sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Double = 0.0
			Me.dgvItems.Rows.Clear()
			Me.title = Me.cmbType.Text
			Dim num2 As Integer = 0
			Dim num3 As Integer = dataTable.Rows.Count - 1
			Dim num4 As Integer = num2
			While True
				Dim num5 As Integer = num4
				Dim num6 As Integer = num3
				If num5 > num6 Then
					Exit While
				End If
				Me.dgvItems.Rows.Add()
				Me.dgvItems.Rows(num4).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("val"))
				Me.dgvItems.Rows(num4).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("date"))).ToShortDateString()
				Me.dgvItems.Rows(num4).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("id"))
				Me.dgvItems.Rows(num4).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("notes"))
				num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("val")))
				num4 += 1
			End While
			Me.txtSum.Text = "" + Conversions.ToString(num)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 4
				If flag Then
					Dim flag2 As Boolean = Me.Type = 1
					If flag2 Then
						Dim frmSandQ As frmSandQ = New frmSandQ()
						frmSandQ.Show()
						frmSandQ.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQ where id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
						frmSandQ.Activate()
					Else
						Dim frmSandD As frmSandD = New frmSandD()
						frmSandD.Show()
						frmSandD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandD where id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
						frmSandD.Activate()
					End If
				End If
			Catch ex As Exception
			End Try
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
				dataTable.Columns.Add("val")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("notes")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value) })
					num3 += 1
				End While
				Dim rptSummary As rptSummary = New rptSummary()
				rptSummary.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptSummary.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
				textObject.Text = Me.title
				Dim textObject2 As TextObject = CType(rptSummary.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptSummary.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptSummary.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject4.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject5 As TextObject = CType(rptSummary.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
				textObject5.Text = Me.txtSum.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptSummary.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject6 As TextObject = CType(rptSummary.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject7 As TextObject = CType(rptSummary.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject8 As TextObject = CType(rptSummary.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject9 As TextObject = CType(rptSummary.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptSummary
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptSummary.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub
	End Class
