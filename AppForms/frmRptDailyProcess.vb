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
Public Partial Class frmRptDailyProcess
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmInvDetails_Load
			frmRptDailyProcess.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptDailyProcess.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptDailyProcess.__ENCList.Count = frmRptDailyProcess.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptDailyProcess.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptDailyProcess.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptDailyProcess.__ENCList(num) = frmRptDailyProcess.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptDailyProcess.__ENCList.RemoveRange(num, frmRptDailyProcess.__ENCList.Count - num)
					frmRptDailyProcess.__ENCList.Capacity = frmRptDailyProcess.__ENCList.Count
				End If
				frmRptDailyProcess.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			Me.ShowResult()
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("num1")
				dataTable.Columns.Add("num2")
				dataTable.Columns.Add("num3")
				dataTable.Columns.Add("num4")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value) })
					num3 += 1
				End While
				Dim rptDailyProcess As rptDailyProcess = New rptDailyProcess()
				rptDailyProcess.SetDataSource(dataTable)
				Dim text As String = "الكل"
				flag = Not Me.chkAllSafe.Checked
				If flag Then
					text = Me.cmbSafe.Text
				End If
				Dim text2 As String = "الكل"
				flag = Not Me.chkAllStock.Checked
				If flag Then
					text2 = Me.cmbStock.Text
				End If
				Dim textObject As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(1).ReportObjects("stock"), TextObject)
				textObject2.Text = text2
				Dim textObject3 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject3.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject4.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptDailyProcess.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject8 As TextObject = CType(rptDailyProcess.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptDailyProcess
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptDailyProcess.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		Private Sub DoProcess(_name As String, _type1 As Integer, _type2 As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Dim flag As Boolean = Not Me.chkAllStock.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
				End If
				flag = Not Me.chkAllSafe.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
				End If
				text += " date>=@date1 and date<=@date2 and "
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select distinct inv.proc_id from inv,inv_sub where ", text, " inv.proc_id=Inv_Sub.proc_id and inv.proc_type=", Conversions.ToString(_type1), " and inv_sub.proc_type=", Conversions.ToString(_type2), " and is_deleted=0" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim count As Integer = dataTable.Rows.Count
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(tot_net) from (select min(tot_net) as tot_net from inv,inv_sub where ", text, " inv.proc_id=Inv_Sub.proc_id and inv.proc_type=", Conversions.ToString(_type1), " and inv_sub.proc_type=", Conversions.ToString(_type2), " and is_deleted=0 group by inv.proc_id) as tbl" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(tot_net) from (select min(tot_net) as tot_net from inv,inv_sub where ", text, " inv.proc_id=Inv_Sub.proc_id and inv.proc_type=", Conversions.ToString(_type1), " and inv_sub.proc_type=", Conversions.ToString(_type2), " and inv.inv_type=2 and is_deleted=0 group by inv.proc_id) as tbl" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num2 = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(tot_net) from (select min(tot_net) as tot_net from inv,inv_sub where ", text, " inv.proc_id=Inv_Sub.proc_id and inv.proc_type=", Conversions.ToString(_type1), " and inv_sub.proc_type=", Conversions.ToString(_type2), " and inv.inv_type=1 and is_deleted=0 group by inv.proc_id) as tbl" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num3 = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				Me.dgvItems.Rows.Add()
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = _name
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num2
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num3
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DoProcess2(_type As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Dim flag As Boolean = Not Me.chkAllSafe.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("safe_bank_id=", Me.cmbSafe.SelectedValue), " and ")))
				End If
				text += " date>=@date1 and date<=@date2 and "
				Dim num As Double = 0.0
				Dim text2 As String = "SandQ"
				Dim value As String = "قبض خارجي"
				flag = (_type = 2)
				If flag Then
					text2 = "SandD"
					value = "صرف خارجي"
				Else
					flag = (_type = 3)
					If flag Then
						text2 = "SandQD"
						value = "قبض داخلي"
					Else
						flag = (_type = 4)
						If flag Then
							text2 = "SandSD"
							value = "صرف داخلي"
						End If
					End If
				End If
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select * from ", text2, " where ", text, "  is_deleted=0" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim count As Integer = dataTable.Rows.Count
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from ", text2, " where ", text, "  is_deleted=0" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					num = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				Me.dgvItems.Rows.Add()
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = value
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
				Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResult()
			Try
				Dim flag As Boolean = Not Me.chkAllStock.Checked And Me.cmbStock.SelectedValue Is Nothing
				If flag Then
					MessageBox.Show("اختر مخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbStock.Focus()
				Else
					flag = (Not Me.chkAllSafe.Checked And Me.cmbSafe.SelectedValue Is Nothing)
					If flag Then
						MessageBox.Show("اختر خزنة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbSafe.Focus()
					Else
						Me.dgvItems.Rows.Clear()
						Me.DoProcess("بيع", 1, 2)
						Me.DoProcess("مرتد بيع", 2, 2)
						Me.DoProcess("شراء", 1, 1)
						Me.DoProcess("مرتد شراء", 2, 1)
						Me.DoProcess2(1)
						Me.DoProcess2(2)
						Me.DoProcess2(3)
						Me.DoProcess2(4)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LoadSafes()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("Select id,name from Stocks where branch=" + Conversions.ToString(MainClass.BranchNo) + " And IS_Deleted=0 And status<>2 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSafe.DataSource = dataTable
			Me.cmbSafe.DisplayMember = "name"
			Me.cmbSafe.ValueMember = "id"
			Me.cmbSafe.SelectedIndex = -1
		End Sub

		Public Sub LoadStocks()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where IS_Deleted=0 and status<>2 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbStock.DataSource = dataTable
			Me.cmbStock.DisplayMember = "name"
			Me.cmbStock.ValueMember = "id"
			Me.cmbStock.SelectedIndex = -1
		End Sub

  Private Sub frmInvDetails_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmInvDetails.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadStocks()
			Me.LoadSafes()
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub chkAllStock_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllStock.CheckedChanged
			Dim checked As Boolean = Me.chkAllStock.Checked
			If checked Then
				Me.cmbStock.Enabled = False
			Else
				Me.cmbStock.Enabled = True
			End If
		End Sub

  Private Sub chkAllSafe_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllSafe.CheckedChanged
			Dim checked As Boolean = Me.chkAllSafe.Checked
			If checked Then
				Me.cmbSafe.Enabled = False
			Else
				Me.cmbSafe.Enabled = True
			End If
		End Sub
	End Class
