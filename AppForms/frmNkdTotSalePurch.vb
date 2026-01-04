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
	Public Partial Class frmNkdTotSalePurch
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmNkdTotSalePurch_Load
			frmNkdTotSalePurch.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmNkdTotSalePurch.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmNkdTotSalePurch.__ENCList.Count = frmNkdTotSalePurch.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmNkdTotSalePurch.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmNkdTotSalePurch.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmNkdTotSalePurch.__ENCList(num) = frmNkdTotSalePurch.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmNkdTotSalePurch.__ENCList.RemoveRange(num, frmNkdTotSalePurch.__ENCList.Count - num)
					frmNkdTotSalePurch.__ENCList.Capacity = frmNkdTotSalePurch.__ENCList.Count
				End If
				frmNkdTotSalePurch.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CalcStock()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "select id,symbol,nameEN from Currencies where IS_Deleted=0"
				text += " order by id"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1
				If flag Then
					str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim num3 As Integer = 0
				Dim num4 As Integer = dataTable.Rows.Count - 1
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
					Dim num12 As Double = 0.0
					Dim num13 As Double = 0.0
					Dim num14 As Double = 0.0
					Dim num15 As Double = 0.0
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=1 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						num12 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=2 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						num9 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						num13 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=1 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						num10 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						num14 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))), 4)
					End If
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num5)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=2 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0")), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
					If flag Then
						num11 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						num15 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))), 4)
					End If
					flag = (num8 <> 0.0 Or num10 <> 0.0)
					If flag Then
						Try
							Dim num16 As Double
							Dim num17 As Double
							Dim num18 As Double
							Dim num19 As Double

								num16 = num8 - num9
								num17 = num12 - num13
								num += num17
								num18 = num10 - num11
								num19 = num14 - num15
								num2 += num19
								Me.dgvItems.Rows.Add()

							Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)(0))
							flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag Then
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)(1))
							Else
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)(2))
							End If
							Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num16
							Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num17
							Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num18
							Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num19
						Catch ex As Exception
						End Try
					End If
					num5 += 1
				End While
				Me.txtSumPurch.Text = "" + Conversions.ToString(num)
				Me.txtSumSale.Text = "" + Conversions.ToString(num2)
			Catch ex2 As Exception
			End Try
		End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me.dgvItems.Rows.Clear()
		Me.txtSumPurch.Text = ""
		Me.txtSumSale.Text = ""
		Me.CalcStock()
	End Sub

	Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
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
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("purch")
				dataTable.Columns.Add("tot_purch")
				dataTable.Columns.Add("sale")
				dataTable.Columns.Add("tot_sale")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					obj = New rptNkdSalePurchTotal()
				Else
					obj = New rptNkdSalePurchTotal___EN()
				End If
				Dim instance As Object = obj
				Dim type2 As Type = Nothing
				Dim memberName As String = "SetDataSource"
				Dim array As Object() = New Object() { dataTable }
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
				If array2(0) Then
					dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
				End If
				Dim text As String = "لشهر " + Conversions.ToString(Me.txtDateFrom.Value.Month) + "/" + Conversions.ToString(Me.txtDateFrom.Value.Year)
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtmonthyear" }, Nothing, Nothing, Nothing), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateFrom" }, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateTo" }, Nothing, Nothing, Nothing), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txttotpurch" }, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.txtSumPurch.Text
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txttotsale" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtSumSale.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtuser" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.GetEmpName(MainClass.EmpNo)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
				Dim type3 As Type = Nothing
				Dim memberName2 As String = "SetDataSource"
				Dim array3 As Object() = New Object() { dataTable2 }
				Dim arguments2 As Object() = array3
				Dim argumentNames2 As String() = Nothing
				Dim typeArguments2 As Type() = Nothing
				array2 = New Boolean() { True }
				NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
				If array2(0) Then
					dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
				End If
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						Dim instance3 As Object = obj
						Dim type4 As Type = Nothing
						Dim memberName3 As String = "PrintToPrinter"
						array = New Object() { 1, False, 1, num6 }
						Dim arguments3 As Object() = array
						Dim argumentNames3 As String() = Nothing
						Dim typeArguments3 As Type() = Nothing
						array2 = New Boolean() { False, False, False, True }
						NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
						If array2(3) Then
							num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
						End If
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

  Private Sub frmNkdTotSalePurch_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmNkdTotSalePurch.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
		End Sub
	End Class
