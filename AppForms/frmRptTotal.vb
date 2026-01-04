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
Public Partial Class frmRptTotal
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRptTotal_Load
			frmRptTotal.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptTotal.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptTotal.__ENCList.Count = frmRptTotal.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptTotal.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptTotal.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptTotal.__ENCList(num) = frmRptTotal.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptTotal.__ENCList.RemoveRange(num, frmRptTotal.__ENCList.Count - num)
					frmRptTotal.__ENCList.Capacity = frmRptTotal.__ENCList.Count
				End If
				frmRptTotal.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmRptTotal_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmRptTotal.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.AddDays(1.0).ToShortDateString())
			Me.LoadEmps()
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub LoadEmps()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where IS_Deleted=0 order by id", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.cmbEmps.DataSource = dataTable
				Me.cmbEmps.DisplayMember = "name"
				Me.cmbEmps.ValueMember = "id"
				Me.cmbEmps.SelectedIndex = -1
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			Try
				Dim text As String = ""
				Dim flag As Boolean = Not Me.chkAll.Checked
				Dim flag2 As Boolean
				If flag Then
					flag2 = (Me.cmbEmps.SelectedValue Is Nothing)
					If flag2 Then
						MessageBox.Show("اختر موظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbEmps.Focus()
						Return
					End If
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Inv.sales_emp=", Me.cmbEmps.SelectedValue)))
				End If
				Dim str As String = ""
				flag2 = (MainClass.BranchNo <> -1)
				If flag2 Then
					str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=2 and pay_type=1 and (cash_part =0 or cash_part is null) and (network_part =0 or network_part is null) and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(cash_part) from Inv where " + str + " inv_type=2 and (cash_part <> 0 and cash_part is not null) and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=2 and pay_type=1 and (cash_part =0 or cash_part is null) and (network_part =0 or network_part is null) and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(cash_part) from Inv where " + str + " inv_type=2 and (cash_part <> 0 and cash_part is not null) and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=2 and pay_type=2 and (cash_part =0 or cash_part is null) and (network_part =0 or network_part is null) and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(network_part) from Inv where " + str + " inv_type=2 and (network_part <> 0 and network_part is not null) and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=2 and pay_type=1 and (cash_part =0 or cash_part is null) and (network_part =0 or network_part is null) and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num2 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(network_part) from Inv where " + str + " inv_type=2 and (network_part <> 0 and network_part is not null) and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num2 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=1 and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num3 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(tot_net) from Inv where " + str + " inv_type=1 and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num3 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(taxval) from Inv,inv_sub where " + str + " inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and inv.proc_type=1 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num4 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				sqlDataAdapter = New SqlDataAdapter("select sum(taxval) from Inv,inv_sub where " + str + " inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and inv.proc_type=2 and is_buy=0 and Inv.IS_Deleted=0 " + text, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num4 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				Me.txtSumCash.Text = "" + Conversions.ToString(Math.Round(num, 2))
				Me.txtSumNetwork.Text = "" + Conversions.ToString(Math.Round(num2, 2))
				Me.txtSumAgel.Text = "" + Conversions.ToString(Math.Round(num3, 2))
				Me.txtSumVAT.Text = "" + Conversions.ToString(Math.Round(num4, 2))
				Me.txtSumTotal.Text = "" + Conversions.ToString(Math.Round(num + num2 + num3, 2))
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PrintRpt(type As Integer)
			Try
				Dim rptTotal As rptTotal = New rptTotal()
				Dim text As String = "الكل"
				Dim flag As Boolean = Not Me.chkAll.Checked
				If flag Then
					text = Me.cmbEmps.Text
				End If
				Dim textObject As TextObject = CType(rptTotal.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptTotal.ReportDefinition.Sections(1).ReportObjects("date1"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToString("dd/MM/yyyy hh:mm tt")
				Dim textObject3 As TextObject = CType(rptTotal.ReportDefinition.Sections(1).ReportObjects("date2"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToString("dd/MM/yyyy hh:mm tt")
				Dim textObject4 As TextObject = CType(rptTotal.ReportDefinition.Sections(4).ReportObjects("cash"), TextObject)
				textObject4.Text = Me.txtSumCash.Text
				Dim textObject5 As TextObject = CType(rptTotal.ReportDefinition.Sections(4).ReportObjects("network"), TextObject)
				textObject5.Text = Me.txtSumNetwork.Text
				Dim textObject6 As TextObject = CType(rptTotal.ReportDefinition.Sections(4).ReportObjects("agel"), TextObject)
				textObject6.Text = Me.txtSumAgel.Text
				Dim textObject7 As TextObject = CType(rptTotal.ReportDefinition.Sections(4).ReportObjects("vat"), TextObject)
				textObject7.Text = Me.txtSumVAT.Text
				Dim textObject8 As TextObject = CType(rptTotal.ReportDefinition.Sections(4).ReportObjects("total"), TextObject)
				textObject8.Text = Me.txtSumTotal.Text
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptTotal
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptTotal.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
			Try
				Dim checked As Boolean = Me.chkAll.Checked
				If checked Then
					Me.cmbEmps.Enabled = False
				Else
					Me.cmbEmps.Enabled = True
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
