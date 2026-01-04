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
Public Partial Class frmRptInvAnalysis
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private tf As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmInvDetails_Load
			frmRptInvAnalysis.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.tf = True
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptInvAnalysis.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptInvAnalysis.__ENCList.Count = frmRptInvAnalysis.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptInvAnalysis.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptInvAnalysis.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptInvAnalysis.__ENCList(num) = frmRptInvAnalysis.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptInvAnalysis.__ENCList.RemoveRange(num, frmRptInvAnalysis.__ENCList.Count - num)
					frmRptInvAnalysis.__ENCList.Capacity = frmRptInvAnalysis.__ENCList.Count
				End If
				frmRptInvAnalysis.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
				dataTable.Columns.Add("num")
				dataTable.Columns.Add("quan")
				dataTable.Columns.Add("sale")
				dataTable.Columns.Add("disc")
				dataTable.Columns.Add("cost")
				dataTable.Columns.Add("profit")
				dataTable.Columns.Add("perc1")
				dataTable.Columns.Add("perc2")
				dataTable.Columns.Add("perc3")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(9).Value) })
					num3 += 1
				End While
				Dim rptInvAnalysis As rptInvAnalysis = New rptInvAnalysis()
				rptInvAnalysis.SetDataSource(dataTable)
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
				Dim text3 As String = "الكل"
				flag = Not Me.chkAllCust.Checked
				If flag Then
					text3 = Me.cmbCust.Text
				End If
				Dim text4 As String = "الكل"
				flag = Not Me.chkAllSales.Checked
				If flag Then
					text4 = Me.cmbSales.Text
				End If
				Dim text5 As String = "الكل"
				flag = Not Me.chkAllEmp.Checked
				If flag Then
					text5 = Me.cmbEmp.Text
				End If
				Dim text6 As String = "الكل"
				flag = Not Me.chkAllGroups.Checked
				If flag Then
					text6 = Me.cmbGroups.Text
				End If
				Dim textObject As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("stock"), TextObject)
				textObject2.Text = text2
				Dim textObject3 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("cust"), TextObject)
				textObject3.Text = text3
				Dim textObject4 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("sales"), TextObject)
				textObject4.Text = text4
				Dim textObject5 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject5.Text = text5
				Dim textObject6 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("group"), TextObject)
				textObject6.Text = text6
				Dim textObject7 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject7.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject8 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject8.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject9 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(4).ReportObjects("sum1"), TextObject)
				textObject9.Text = Me.txtSum1.Text
				Dim textObject10 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(4).ReportObjects("sum2"), TextObject)
				textObject10.Text = Me.txtSum2.Text
				Dim textObject11 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(4).ReportObjects("sum3"), TextObject)
				textObject11.Text = Me.txtSum3.Text
				Dim textObject12 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(4).ReportObjects("sum4"), TextObject)
				textObject12.Text = Me.txtSum4.Text
				Dim textObject13 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(4).ReportObjects("sum5"), TextObject)
				textObject13.Text = Me.txtSum5.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptInvAnalysis.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject14 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject15 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject16 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject16.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject17 As TextObject = CType(rptInvAnalysis.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject17.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptInvAnalysis
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptInvAnalysis.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		Private Sub ShowResultGroup()
			' The following expression was wrapped in a checked-statement
			Try
				Dim selectCommandText As String = "select id,name from groups "
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
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
					Dim text As String = ""
					Dim flag As Boolean = Not Me.chkAllSafe.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", dataTable.Rows(num5)("id")), " and ")))
					text += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount ) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 ", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sum")))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sum")))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount ) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date order by inv_sub.currency_from", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResultItem()
			' The following expression was wrapped in a checked-statement
			Try
				Dim selectCommandText As String = "select id,symbol from currencies where IS_Deleted=0 "
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
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
					Dim text As String = ""
					Dim flag As Boolean = Not Me.chkAllSafe.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("inv_sub.currency_from=", dataTable.Rows(num5)("id")), " and ")))
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sum")))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sum")))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount ) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Double = 0.0
						Dim num14 As Integer = 0
						Dim num15 As Double = 0.0
						Dim num16 As Double = 0.0
						Dim num17 As Double = 0.0
						Dim num18 As Integer = 0
						Dim num19 As Integer = dataTable2.Rows.Count - 1
						Dim num20 As Integer = num18
						While True
							Dim num21 As Integer = num20
							num7 = num19
							If num21 > num7 Then
								Exit While
							End If

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)("val")))
								num16 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)("val")))
								num17 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)("sum")))
								num12 += num17
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num20)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num13 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num14 = CInt(Math.Round(CDbl(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num20)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num13 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num14 = CInt(Math.Round(CDbl(num14) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num14 <> 0)
								If flag Then
									num15 = num13 / CDbl(num14)
									num15 = Math.Floor(num15 * 100000000.0)
									num15 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num20)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num15 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If

							num20 += 1
						End While
						num10 = Math.Round(num16 * num15, 4)
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("symbol"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResultCust()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "select id,name from customers where type=1 and IS_Deleted=0 "
				Dim flag As Boolean = Not Me.chkAllCust.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and [id]=", Me.cmbCust.SelectedValue)))
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
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
					Dim text2 As String = ""
					flag = Not Me.chkAllSafe.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", dataTable.Rows(num5)("id")), " and ")))
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text2 += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount ) as sum  from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResultSalesman()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "select id,name from salesmen where IS_Deleted=0 "
				Dim flag As Boolean = Not Me.chkAllSales.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and [id]=", Me.cmbSales.SelectedValue)))
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
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
					Dim text2 As String = ""
					flag = Not Me.chkAllSafe.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", dataTable.Rows(num5)("id")), " and ")))
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text2 += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price) as sum  from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResultEmp()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "select id,name from employees where IS_Deleted=0 "
				Dim flag As Boolean = Not Me.chkAllSales.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and [id]=", Me.cmbSales.SelectedValue)))
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
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
					Dim text2 As String = ""
					flag = Not Me.chkAllSafe.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("sales_emp=", dataTable.Rows(num5)("id")), " and ")))
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text2 += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price) as sum  from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResultMonth()
			' The following expression was wrapped in a checked-statement
			Try
				Dim selectCommandText As String = "select distinct date=DATEADD(MONTH, DATEDIFF(MONTH, 0, date), 0) from inv,inv_sub where inv.proc_id=inv_sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and date>=@date1 and date<=@date2 and IS_Deleted=0 GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, date),0)"
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
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
					Dim text As String = ""
					Dim flag As Boolean = Not Me.chkAllSafe.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date")))
					Dim dateTime2 As DateTime = New DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month))
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).Month) + " - " + Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).Year)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub ShowResultDay()
			' The following expression was wrapped in a checked-statement
			Try
				Dim selectCommandText As String = "select distinct date=DATEADD(DAY, DATEDIFF(DAY, 0, date), 0) from inv,inv_sub where inv.proc_id=inv_sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and date>=@date1 and date<=@date2 and IS_Deleted=0 GROUP BY DATEADD(DAY, DATEDIFF(DAY, 0, date),0)"
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(selectCommandText, Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
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
					Dim text As String = ""
					Dim flag As Boolean = Not Me.chkAllSafe.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbSafe.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllStock.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date")))
					Dim dateTime2 As DateTime = Conversions.ToDate(dateTime.AddDays(1.0).ToShortDateString())
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price) as sum  from inv,inv_sub,Currencies,groups where " + text + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).ToShortDateString()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub ShowResultStock()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "select id,name from Safes where IS_Deleted=0 and status<>2 "
				Dim flag As Boolean = Not Me.chkAllStock.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and [id]=", Me.cmbStock.SelectedValue)))
				End If
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
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
					Dim text2 As String = ""
					flag = Not Me.chkAllSafe.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[stock]=", Me.cmbStock.SelectedValue), " and ")))
					End If
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("[safe]=", dataTable.Rows(num5)("id")), " and ")))
					flag = Not Me.chkAllCust.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("cust_id=", Me.cmbCust.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllSales.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("salesman=", Me.cmbSales.SelectedValue), " and ")))
					End If
					flag = Not Me.chkAllGroups.Checked
					If flag Then
						text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("groups.id=", Me.cmbGroups.SelectedValue), " and ")))
					End If
					text2 += " date>=@date1 and date<=@date2 and "
					Dim num8 As Double = 0.0
					Dim value As Double = 0.0
					Dim num9 As Double = 0.0
					Dim num10 As Double = 0.0
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select distinct inv.proc_id from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					Dim count As Integer = dataTable2.Rows.Count
					sqlDataAdapter2 = New SqlDataAdapter("select sum(tot_net),sum(tot) from (select min(tot_net) as tot_net,min(tot_sale) as tot from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv.proc_id) as tbl", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim num11 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						value = num11 - num8
					End If
					Dim num12 As Double = 0.0
					sqlDataAdapter2 = New SqlDataAdapter("select inv_sub.currency_from,inv.date,sum(inv_sub.val) as val, sum(val1*exchange_price + inv_sub.taxval - inv_sub.discount ) as sum  from inv,inv_sub,Currencies,groups where " + text2 + " inv_sub.currency_from=Currencies.id and Currencies.group_id=groups.id and inv.proc_id=Inv_Sub.proc_id and inv.proc_type=1 and inv_sub.proc_type=2 and inv.is_deleted=0 group by inv_sub.currency_from,inv.date", Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num13 As Integer = 0
						Dim num14 As Integer = dataTable2.Rows.Count - 1
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							Dim num17 As Double = 0.0
							Dim num18 As Integer = 0
							Dim num19 As Double = 0.0

								num9 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num20 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("val")))
								Dim num21 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num15)("sum")))
								num12 += num21
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where inv_sub.currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=", dataTable2.Rows(num15)(0)), " and date <=@date2 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
								sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num15)("date")))
								dataTable3 = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								flag = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
								If flag Then
									num17 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
									num18 = CInt(Math.Round(CDbl(num18) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
								End If
								flag = (num18 <> 0)
								If flag Then
									num19 = num17 / CDbl(num18)
									num19 = Math.Floor(num19 * 100000000.0)
									num19 /= 100000000.0
								Else
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num15)(0))), Me.conn)
									Dim dataTable4 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable4)
									flag = (dataTable4.Rows.Count > 0)
									If flag Then
										num19 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
									End If
								End If
								num10 += Math.Round(num20 * num19, 4)

							num15 += 1
						End While
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num9, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num8, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(value, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Math.Round(num8 - num10, 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = Math.Round((num8 - num10) / num10 * 100.0, 2)

						num += num8
						num2 += num8 - num10

					num5 += 1
				End While
				Dim num22 As Integer = 0
				Dim num23 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num7 As Integer = num23
					If num25 > num7 Then
						Exit While
					End If

						Me.dgvItems.Rows(num24).Cells(8).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(3).Value)) / num * 100.0, 2)
						Me.dgvItems.Rows(num24).Cells(9).Value = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num24).Cells(6).Value)) / num2 * 100.0, 2)

					num24 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowResult()
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
					flag = (Not Me.chkAllCust.Checked And Me.cmbCust.SelectedValue Is Nothing)
					If flag Then
						MessageBox.Show("اختر عميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbCust.Focus()
					Else
						flag = (Not Me.chkAllEmp.Checked And Me.cmbEmp.SelectedValue Is Nothing)
						If flag Then
							MessageBox.Show("اختر مستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.cmbEmp.Focus()
						Else
							flag = (Not Me.chkAllGroups.Checked And Me.cmbGroups.SelectedValue Is Nothing)
							If flag Then
								MessageBox.Show("اختر مجموعة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Me.cmbGroups.Focus()
							Else
								flag = (Not Me.chkAllSales.Checked And Me.cmbSales.SelectedValue Is Nothing)
								If flag Then
									MessageBox.Show("اختر مندوب مبيعات", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.cmbSales.Focus()
								Else
									Me.dgvItems.Rows.Clear()
									flag = Me.rdStock.Checked
									If flag Then
										Me.dgvItems.Columns(0).HeaderText = "المخزن"
										Me.ShowResultStock()
									Else
										flag = Me.rdCust.Checked
										If flag Then
											Me.dgvItems.Columns(0).HeaderText = "العميل"
											Me.ShowResultCust()
										Else
											flag = Me.rdItem.Checked
											If flag Then
												Me.dgvItems.Columns(0).HeaderText = "الصنف"
												Me.ShowResultItem()
											Else
												flag = Me.rdSalesman.Checked
												If flag Then
													Me.dgvItems.Columns(0).HeaderText = "المندوب"
													Me.ShowResultSalesman()
												Else
													flag = Me.rdEmp.Checked
													If flag Then
														Me.dgvItems.Columns(0).HeaderText = "المستخدم"
														Me.ShowResultEmp()
													Else
														flag = Me.rdMonth.Checked
														If flag Then
															Me.dgvItems.Columns(0).HeaderText = "الفترة"
															Me.ShowResultMonth()
														Else
															flag = Me.rdDay.Checked
															If flag Then
																Me.dgvItems.Columns(0).HeaderText = "اليوم"
																Me.ShowResultDay()
															Else
																flag = Me.rdGroup.Checked
																If flag Then
																	Me.dgvItems.Columns(0).HeaderText = "التصنيف"
																	Me.ShowResultGroup()
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
									Dim num As Double = 0.0
									Dim num2 As Double = 0.0
									Dim num3 As Double = 0.0
									Dim num4 As Double = 0.0
									Dim num5 As Double = 0.0
									Dim num6 As Integer = 0
									Dim num7 As Integer = Me.dgvItems.Rows.Count - 1
									Dim num8 As Integer = num6
									While True
										Dim num9 As Integer = num8
										Dim num10 As Integer = num7
										If num9 > num10 Then
											Exit While
										End If
										num += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num8).Cells(2).Value))
										num2 += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num8).Cells(3).Value))
										num3 += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num8).Cells(4).Value))
										num4 += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num8).Cells(5).Value))
										num5 += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num8).Cells(6).Value))
										num8 += 1
									End While
									Me.txtSum1.Text = "" + Conversions.ToString(Math.Round(num, 2))
									Me.txtSum2.Text = "" + Conversions.ToString(Math.Round(num2, 2))
									Me.txtSum3.Text = "" + Conversions.ToString(Math.Round(num3, 2))
									Me.txtSum4.Text = "" + Conversions.ToString(Math.Round(num4, 2))
									Me.txtSum5.Text = "" + Conversions.ToString(Math.Round(num5, 2))
								End If
							End If
						End If
					End If
				End If
			End If
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

		Public Sub LoadCust()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=1 and IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCust.DataSource = dataTable
			Me.cmbCust.DisplayMember = "name"
			Me.cmbCust.ValueMember = "id"
			Me.cmbCust.SelectedIndex = -1
		End Sub

		Public Sub LoadEmps()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbEmp.DataSource = dataTable
			Me.cmbEmp.DisplayMember = "name"
			Me.cmbEmp.ValueMember = "id"
			Me.cmbEmp.SelectedIndex = -1
		End Sub

		Public Sub LoadSales()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from salesmen where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSales.DataSource = dataTable
			Me.cmbSales.DisplayMember = "name"
			Me.cmbSales.ValueMember = "id"
			Me.cmbSales.SelectedIndex = -1
		End Sub

		Public Sub LoadGroups()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from groups order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbGroups.DataSource = dataTable
			Me.cmbGroups.DisplayMember = "name"
			Me.cmbGroups.ValueMember = "id"
			Me.cmbGroups.SelectedIndex = -1
		End Sub

  Private Sub frmInvDetails_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmInvDetails.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadStocks()
			Me.LoadSafes()
			Me.LoadCust()
			Me.LoadEmps()
			Me.LoadGroups()
			Me.LoadSales()
			Me.LoadEmps()
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

  Private Sub chkAllCust_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllCust.CheckedChanged
			Dim checked As Boolean = Me.chkAllCust.Checked
			If checked Then
				Me.cmbCust.Enabled = False
			Else
				Me.cmbCust.Enabled = True
			End If
		End Sub

  Private Sub chkAllEmp_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllEmp.CheckedChanged
			Dim checked As Boolean = Me.chkAllEmp.Checked
			If checked Then
				Me.cmbEmp.Enabled = False
			Else
				Me.cmbEmp.Enabled = True
			End If
		End Sub

  Private Sub chkAllSales_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllSales.CheckedChanged
			Dim checked As Boolean = Me.chkAllSales.Checked
			If checked Then
				Me.cmbSales.Enabled = False
			Else
				Me.cmbSales.Enabled = True
			End If
		End Sub

  Private Sub chkAllGroups_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllGroups.CheckedChanged
			Dim checked As Boolean = Me.chkAllGroups.Checked
			If checked Then
				Me.cmbGroups.Enabled = False
			Else
				Me.cmbGroups.Enabled = True
			End If
		End Sub

  Private Sub cmbEmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbEmp.SelectedIndexChanged
		End Sub

  Private Sub rdEmp_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdEmp.CheckedChanged
		End Sub
	End Class
