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
Imports AQSYS.AQSYS.rptt
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
	Public Partial Class frmNetsales
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmNetsales_Load
			frmNetsales.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmNetsales.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmNetsales.__ENCList.Count = frmNetsales.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmNetsales.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmNetsales.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmNetsales.__ENCList(num) = frmNetsales.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmNetsales.__ENCList.RemoveRange(num, frmNetsales.__ENCList.Count - num)
					frmNetsales.__ENCList.Capacity = frmNetsales.__ENCList.Count
				End If
				frmNetsales.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmNetsales_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmNetsales.Load
			Control.CheckForIllegalCrossThreadCalls = False
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadCurrencies()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select storeclose_pricetype from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) = 3
				If flag Then
					Me.rdLastPurchCost.Checked = True
				Else
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) = 2)
					If flag Then
						Me.rdPurchCost.Checked = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Public Sub LoadCurrencies()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from Currencies where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCurrency.DataSource = dataTable
			Me.cmbCurrency.DisplayMember = "symbol"
			Me.cmbCurrency.ValueMember = "id"
			Me.cmbCurrency.SelectedIndex = -1
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
				dataTable.Columns.Add("val1")
				dataTable.Columns.Add("val2")
				dataTable.Columns.Add("val3")
				dataTable.Columns.Add("net")
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
				Dim rptNetProfit As rptNetProfit = New rptNetProfit()
				rptNetProfit.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptNetProfit.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject2 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject2.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
				textObject3.Text = Me.txtVal2.Text
				Dim textObject4 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
				textObject4.Text = Me.txtVal3.Text
				Dim textObject5 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
				textObject5.Text = Me.txtVal4.Text
				Dim textObject6 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject6.Text = Me.GetEmpName(MainClass.EmpNo)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptNetProfit.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject7 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject8 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject9 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject10 As TextObject = CType(rptNetProfit.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptNetProfit
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptNetProfit.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
			Dim checked As Boolean = Me.chkAll.Checked
			If checked Then
				Me.cmbCurrency.Enabled = False
			Else
				Me.cmbCurrency.Enabled = True
			End If
		End Sub

		Private Sub ShowData()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbCurrency.SelectedIndex = -1
				If flag Then
					MessageBox.Show("يجب اختيار الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbCurrency.Focus()
					Return
				End If
				Dim text As String = "select distinct Currencies.id,Currencies.symbol,Currencies.purch_price from inv,inv_sub,Currencies where inv.proc_id=inv_sub.proc_id and inv_sub.currency_from=currencies.id and inv.proc_type=1 and inv.is_buy=0 and inv.IS_Deleted=0 and inv.branch=" + Conversions.ToString(MainClass.BranchNo)
				flag = Not Me.chkAll.Checked
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Currencies.id=", Me.cmbCurrency.SelectedValue)))
				End If
				text += " order by Currencies.id"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Me.dgvItems.Rows.Clear()
				Dim str As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Me.Finished = False
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = dataTable.Rows.Count
				Dim num4 As Integer = 0
				Dim num5 As Integer = dataTable.Rows.Count - 1
				Dim num6 As Integer = num4
				While True
					Dim num7 As Integer = num6
					Dim num8 As Integer = num5
					If num7 > num8 Then
						Exit While
					End If
					sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.id,inv.date, val as val ,(val1*exchange_price - discount ) as sum from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num6)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Dim num9 As Integer = 0
						Dim num10 As Integer = dataTable2.Rows.Count - 1
						Dim num11 As Integer = num9
						While True
							Dim num12 As Integer = num11
							num8 = num10
							If num12 > num8 Then
								Exit While
							End If
							Dim num13 As Double = 0.0
							Dim num14 As Double = 0.0
							Dim num15 As Double = 0.0
							Dim num16 As Double = 0.0
							num13 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num11)("val")))
							num15 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num11)("sum")))

								num += num15
								sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select val as val , (val1*exchange_price - discount) as sum from inv,inv_sub where InvId_Return=", dataTable2.Rows(num11)("id")), " and  Inv_Sub.currency_from="), dataTable.Rows(num6)("id")), " and date>=@date1 and date<=@date2 and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
								sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
								sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter.Fill(dataTable3)
								Dim num17 As Integer = 0
								Dim num18 As Integer = dataTable3.Rows.Count - 1
								Dim num19 As Integer = num17
								While True
									Dim num20 As Integer = num19
									num8 = num18
									If num20 > num8 Then
										Exit While
									End If
									num14 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num19)("val")))
									num16 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num19)("sum")))
									num19 += 1
								End While
								num13 -= num14
								num15 -= num16
								num -= num16
								flag = (num13 <> 0.0)
								If flag Then
									Dim num21 As Double = 0.0
									Dim num22 As Integer = 0
									Try
										flag = Me.rdAvgCost.Checked
										If flag Then
											sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num6)(0)), " and date <=@date2 and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
											sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num11)("date")))
											Dim dataTable4 As DataTable = New DataTable()
											sqlDataAdapter.Fill(dataTable4)
											flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(1).ToString(), "", False) <> 0)
											If flag Then
												num21 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(1)))
												num22 = CInt(Math.Round(CDbl(num22) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))))
											End If
										Else
											flag = Me.rdLastPurchCost.Checked
											If flag Then
												sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 (val),(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num6)(0)), " and date <=@date2 and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 order by inv.date desc")), Me.conn)
												sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num11)("date")))
												Dim dataTable5 As DataTable = New DataTable()
												sqlDataAdapter.Fill(dataTable5)
												flag = (dataTable5.Rows.Count > 0 And Operators.CompareString(dataTable5.Rows(0)(1).ToString(), "", False) <> 0)
												If flag Then
													num21 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(1)))
													num22 = CInt(Math.Round(CDbl(num22) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))))
												End If
											End If
										End If
									Catch ex As Exception
									End Try
									Try
										flag = (num22 <> 0)
										Dim num23 As Double
										If flag Then
											num23 = num21 / CDbl(num22)
											num23 = Math.Floor(num23 * 100000000.0)
											num23 /= 100000000.0
										Else
											num23 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num6)("purch_price")))
										End If
										Dim num24 As Double = Math.Round(num13 * num23, 2)
										num2 += num24
										Dim value As Double = num15 - num24
										num3 += Math.Round(value, 2)
										Me.dgvItems.Rows.Add()
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num6)(0))
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Operators.ConcatenateObject("", dataTable.Rows(num6)(1))
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = String.Format("{0:0.#,##.##}", num13)
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = String.Format("{0:0.#,##.##}", num15)
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = String.Format("{0:0.#,##.##}", num24)
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = String.Format("{0:0.#,##.##}", Math.Round(value, 2))
									Catch ex2 As Exception
									End Try
								End If

							num11 += 1
						End While
					End If
					Me.ProgressBar1.Value = num6 + 1
					num6 += 1
				End While
				Me.txtVal2.Text = String.Format("{0:0.#,##.##}", num)
				Me.txtVal3.Text = String.Format("{0:0.#,##.##}", num2)
				Me.txtVal4.Text = String.Format("{0:0.#,##.##}", num3)
			Catch ex3 As Exception
			End Try
			Me.Finished = True
		End Sub

	Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me.dgvItems.ScrollBars = ScrollBars.None
		'Dim thread As Thread = AddressOf Me.ShowData
		Dim thread As New Thread(AddressOf Me.ShowData)
		thread.Start()
	End Sub

	Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub txtVal2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal2.TextChanged
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Try
				Dim finished As Boolean = Me.Finished
				If finished Then
					Me.Finished = False
					Me.dgvItems.ScrollBars = ScrollBars.Both
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub ProgressBar1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProgressBar1.Click
		End Sub
	End Class
