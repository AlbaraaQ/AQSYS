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
Imports AQSYS.AQSYS.rptt
Imports System.Windows.Forms
	Public Partial Class frmRptMobApp
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frm_Load
			frmRptMobApp.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptMobApp.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptMobApp.__ENCList.Count = frmRptMobApp.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptMobApp.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptMobApp.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptMobApp.__ENCList(num) = frmRptMobApp.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptMobApp.__ENCList.RemoveRange(num, frmRptMobApp.__ENCList.Count - num)
					frmRptMobApp.__ENCList.Capacity = frmRptMobApp.__ENCList.Count
				End If
				frmRptMobApp.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Public Sub LoadMobApps()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from mobapps where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbApps.DataSource = dataTable
			Me.cmbApps.DisplayMember = "name"
			Me.cmbApps.ValueMember = "id"
			Me.cmbApps.SelectedIndex = -1
		End Sub

  Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frm.Load
			Me.dgvItems.Columns("colsno").DisplayIndex = 0
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.AddDays(1.0).ToShortDateString())
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select close_time from foundation where id=1", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim obj As Object = dataTable.Rows(0)(0)
				Dim timeSpan As TimeSpan
				Dim hours As Integer = If((obj IsNot Nothing), CType(obj, TimeSpan), timeSpan).Hours
				Me.txtDateFrom.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddHours(CDbl(hours))
				Me.txtDateTo.Value = Convert.ToDateTime(DateTime.Now.AddDays(1.0).ToShortDateString()).AddHours(CDbl(hours))
			Catch ex As Exception
			End Try
			Me.LoadMobApps()
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

		Private Function GetAppName(_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from mobapps where id=" + Conversions.ToString(_id), Me.conn)
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
				dataTable.Columns.Add("type")
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("DataColumn11")
				dataTable.Columns.Add("sumsale")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells("colsno").Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim rptRestMobApp As rptRestMobApp = New rptRestMobApp()
				rptRestMobApp.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject2 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject2.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject3.Text = Me.txtSumSale.Text
				Dim textObject4 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(4).ReportObjects("sumfees"), TextObject)
				textObject4.Text = Me.txtSumFees.Text
				Dim textObject5 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject5.Text = Me.GetEmpName(MainClass.EmpNo)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptRestMobApp.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject6 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject7 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject8 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject9 As TextObject = CType(rptRestMobApp.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptRestMobApp
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptRestMobApp.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		Private Sub StartProcess()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbApps.SelectedValue IsNot Nothing
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" mobapp_id=", Me.cmbApps.SelectedValue), " and "))
				End If
				Dim str As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				flag = Me.rdPaidOnline.Checked
				If flag Then
					text += " is_paid_online=1 and "
				Else
					flag = Me.rdPaidComp.Checked
					If flag Then
						text += " is_paid_online=0 and "
					End If
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select proc_id,id,date,mobapp_id,fees,tot_sale,tot_net,is_buy,tawla_paid from inv where " + str + text + " rest_type=6 and is_buy=0 and proc_type=1 and date>=@date1 and date<=@date2 and IS_Deleted=0 order by id", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Me.dgvItems.Rows.Clear()
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = dataTable.Rows.Count
				Dim num3 As Integer = 0
				Dim num4 As Integer = dataTable.Rows.Count - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(num5).Cells("colsno").Value = num5 + 1
					Me.dgvItems.Rows(num5).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("proc_id"))
					Me.dgvItems.Rows(num5).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("id"))
					Me.dgvItems.Rows(num5).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).ToShortDateString()
					Me.dgvItems.Rows(num5).Cells(3).Value = Me.GetAppName(Conversions.ToInteger(dataTable.Rows(num5)("mobapp_id")))
					Me.dgvItems.Rows(num5).Cells(4).Value = Operators.ConcatenateObject("", dataTable.Rows(num5)("fees"))
					Me.dgvItems.Rows(num5).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("tot_net"))

						num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("tot_net")))
						num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num5)("fees")))

					Me.ProgressBar1.Value = num5 + 1
					num5 += 1
				End While
				Me.txtSumFees.Text = String.Format("{0:0.#,##.##}", num2)
				Me.txtSumSale.Text = String.Format("{0:0.#,##.##}", num)
			Catch ex As Exception
			End Try
			Me._finished = True
		End Sub

	Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me._finished = False
		Me.dgvItems.ScrollBars = ScrollBars.None
		Me.timer1.Enabled = True
		'Dim thread As Thread = AddressOf Me.StartProcess
		Dim thread As New Thread(AddressOf Me.StartProcess)
		thread.Start()
	End Sub

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 6
				If flag Then
					Dim frmSalePurchRest As frmSalePurchRest = New frmSalePurchRest()
					frmSalePurchRest.InvProc = 2
					frmSalePurchRest.Show()
					frmSalePurchRest.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)))
					frmSalePurchRest.Activate()
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Dim finished As Boolean = Me._finished
			If finished Then
				Me._finished = False
				Me.dgvItems.ScrollBars = ScrollBars.Both
				Me.Timer1.Enabled = False
			End If
		End Sub

  Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
			Dim checked As Boolean = Me.chkAll.Checked
			If checked Then
				Me.cmbApps.Enabled = False
			Else
				Me.cmbApps.Enabled = True
			End If
		End Sub
	End Class
