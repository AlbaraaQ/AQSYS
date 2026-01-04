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
Public Partial Class frmActsInvTotal
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmActsInvTotal_Load
			frmActsInvTotal.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmActsInvTotal.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmActsInvTotal.__ENCList.Count = frmActsInvTotal.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmActsInvTotal.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmActsInvTotal.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmActsInvTotal.__ENCList(num) = frmActsInvTotal.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmActsInvTotal.__ENCList.RemoveRange(num, frmActsInvTotal.__ENCList.Count - num)
					frmActsInvTotal.__ENCList.Capacity = frmActsInvTotal.__ENCList.Count
				End If
				frmActsInvTotal.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmActsInvTotal_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmActsInvTotal.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadActs()
		End Sub

		Public Sub LoadActs()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Acts order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbActs.DataSource = dataTable
			Me.cmbActs.DisplayMember = "name"
			Me.cmbActs.ValueMember = "id"
			Me.cmbActs.SelectedIndex = -1
		End Sub

	Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub chkAllActs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllActs.CheckedChanged
			Dim checked As Boolean = Me.chkAllActs.Checked
			If checked Then
				Me.cmbActs.Enabled = False
			Else
				Me.cmbActs.Enabled = True
			End If
		End Sub

		Private Sub CalcStock()
			Try
				Dim text As String = "select id,name from Acts"
				Dim flag As Boolean = Not Me.chkAllActs.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" where id=", Me.cmbActs.SelectedValue)))
				End If
				text += " order by id"
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("currency")
				dataTable.Columns.Add("sum")
				dataTable.Columns.Add("type")
				dataTable.Columns.Add("invtype")
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim str As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim num3 As Integer = 0
				Dim num4 As Integer = dataTable2.Rows.Count - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Dim num8 As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim num11 As Double = 0.0
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub,Customers where " + str + "inv.cust_id=Customers.id and Customers.act=", dataTable2.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=1 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						Dim num12 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
						num8 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub,Customers where " + str + "inv.cust_id=Customers.id and Customers.act=", dataTable2.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=2 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						Dim num13 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
						num9 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub,Customers where " + str + "inv.cust_id=Customers.id and Customers.act=", dataTable2.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=1 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						Dim num14 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
						num10 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub,Customers where " + str + "inv.cust_id=Customers.id and Customers.act=", dataTable2.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=2 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						Dim num15 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
						num11 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))), 4)
					End If
					Dim num16 As Double = num8 - num9
					num += num16
					Dim num17 As Double = num10 - num11
					num2 += num17
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Me.dgvItems.Rows.Count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)(1))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num16
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)(1))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num17
					num5 += 1
				End While
				Me.txtSumPurch.Text = "" + Conversions.ToString(num)
				Me.txtSumSale.Text = "" + Conversions.ToString(num2)
			Catch ex As Exception
			End Try
		End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Dim flag As Boolean = Not Me.chkAllActs.Checked And Me.cmbActs.SelectedIndex = -1
		If flag Then
			MessageBox.Show("يجب اختيار جهة العمل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbActs.Focus()
		Else
			Me.dgvItems.Rows.Clear()
			Me.txtSumPurch.Text = ""
			Me.txtSumSale.Text = ""
			Me.CalcStock()
		End If
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

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("act1")
				dataTable.Columns.Add("val1")
				Dim dataTable2 As DataTable = New DataTable()
				dataTable2.Columns.Add("act2")
				dataTable2.Columns.Add("val2")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value) })
					dataTable2.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value) })
					num3 += 1
				End While
				Dim rptNkdActs As rptNkdActs = New rptNkdActs()
				Dim text As String = "لشهر " + Conversions.ToString(Me.txtDateFrom.Value.Month) + "/" + Conversions.ToString(Me.txtDateFrom.Value.Year)
				Dim textObject As TextObject = CType(rptNkdActs.ReportDefinition.Sections(1).ReportObjects("txtmonthyear"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject4.Text = Me.GetEmpName(MainClass.EmpNo)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable3)
				rptNkdActs.Subreports("rptHeader").SetDataSource(dataTable3)
				flag = (dataTable3.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
					Dim textObject8 As TextObject = CType(rptNkdActs.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Fax")))
				End If
				rptNkdActs.Subreports("rpt1").SetDataSource(dataTable)
				rptNkdActs.Subreports("rpt2").SetDataSource(dataTable2)
				Dim textObject9 As TextObject = CType(rptNkdActs.Subreports("rpt1").ReportDefinition.Sections(3).ReportObjects("txtSum"), TextObject)
				textObject9.Text = Me.txtSumSale.Text
				Dim textObject10 As TextObject = CType(rptNkdActs.Subreports("rpt2").ReportDefinition.Sections(3).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Me.txtSumPurch.Text
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptNkdActs
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptNkdActs.PrintToPrinter(1, False, 1, currentPageNumber)
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
