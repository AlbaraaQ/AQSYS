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
Public Partial Class frmRptKhzna
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmInvDetails_Load
			frmRptKhzna.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptKhzna.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptKhzna.__ENCList.Count = frmRptKhzna.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptKhzna.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptKhzna.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptKhzna.__ENCList(num) = frmRptKhzna.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptKhzna.__ENCList.RemoveRange(num, frmRptKhzna.__ENCList.Count - num)
					frmRptKhzna.__ENCList.Capacity = frmRptKhzna.__ENCList.Count
				End If
				frmRptKhzna.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
				dataTable.Columns.Add("id")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("num")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("in")
				dataTable.Columns.Add("out")
				dataTable.Columns.Add("balance")
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value) })
					num3 += 1
				End While
				Dim rptKhznaProcess As rptKhznaProcess = New rptKhznaProcess()
				rptKhznaProcess.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
				textObject.Text = Me.cmbSafe.Text
				Dim textObject2 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(4).ReportObjects("sum1"), TextObject)
				textObject4.Text = Me.txtTotAll.Text
				Dim textObject5 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(4).ReportObjects("sum2"), TextObject)
				textObject5.Text = Me.txtTotPeriod.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptKhznaProcess.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject6 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject7 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject8 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject9 As TextObject = CType(rptKhznaProcess.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptKhznaProcess
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptKhznaProcess.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		Private Sub ShowResult()
			Try
				Dim flag As Boolean = Me.cmbSafe.SelectedValue Is Nothing
				If flag Then
					MessageBox.Show("اختر خزنة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbSafe.Focus()
				Else
					Me.dgvItems.Rows.Clear()
					Dim value As Integer = -1
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select Accounts_Index.Code from Accounts_Index,Stocks where Accounts_Index.AName=Stocks.name and Accounts_Index.acc_branch=Stocks.branch and Accounts_Index.Type=2 and Stocks.id=", Me.cmbSafe.SelectedValue)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						' The following expression was wrapped in a checked-expression
						value = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
					End If
					Dim text As String = ""
					flag = (MainClass.BranchNo <> -1)
					If flag Then
						text = String.Concat(New String() { "Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and " })
					End If
					Dim num As Double = 0.0
					Dim num2 As Double = 0.0
					Dim num3 As Double = 0.0
					Dim num4 As Double = 0.0
					Dim num5 As Double = 0.0
					Dim num6 As Double = 0.0
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + text + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date<@date1 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value), Me.conn)
					sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						num4 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("dept")))
						num5 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("credit")))
						num += num4
						num2 += num5
						num6 = num4 - num5
						num3 += num4 - num5
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Me.dgvItems.Rows.Count
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = "رصيد سابق"
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Me.txtDateFrom.Value.AddDays(-1.0).ToShortDateString()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num4
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num5
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = num4 - num5
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Restrictions.id,Restrictions.type,Restrictions.date,Restrictions.notes,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where ", text, " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=", Conversions.ToString(value), " group by Restrictions.id,Restrictions.type,Restrictions.date,Restrictions.notes" }), Me.conn)
					sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
					sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable3)
					Dim num7 As Integer = 0
					Dim num8 As Integer = dataTable3.Rows.Count - 1
					Dim num9 As Integer = num7
					While True
						Dim num10 As Integer = num9
						Dim num11 As Integer = num8
						If num10 > num11 Then
							Exit While
						End If
						Me.dgvItems.Rows.Add()
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Me.dgvItems.Rows.Count
						Dim value2 As String = ""
						flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 1, False)
						If flag Then
							value2 = "شراء"
						Else
							flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 2, False)
							If flag Then
								value2 = "بيع"
							Else
								flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 3, False)
								If flag Then
									value2 = "مرتد شراء"
								Else
									flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 4, False)
									If flag Then
										value2 = "مرتد بيع"
									Else
										flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 5, False)
										If flag Then
											value2 = "قبض"
										Else
											flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 6, False)
											If flag Then
												value2 = "صرف"
											Else
												flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 7, False)
												If flag Then
													value2 = "قبض"
												Else
													flag = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(num9)("type"), 8, False)
													If flag Then
														value2 = "صرف"
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = value2
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("id"))
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("date"))).ToShortDateString()
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("dept")))
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("credit")))

							num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("dept")))
							num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("credit")))
							num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("dept"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("credit")))

						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = num3
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num9)("notes"))
						num9 += 1
					End While
					Me.txtTotAll.Text = "رصيد الخزينة الإجمالي" + Environment.NewLine + String.Format("{0:#,##.##}", num3)
					Me.txtTotPeriod.Text = "صافي حركة الخزينة للفترة" + Environment.NewLine + String.Format("{0:#,##.##}", num3 - num6)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub LoadSafes()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Stocks where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSafe.DataSource = dataTable
			Me.cmbSafe.DisplayMember = "name"
			Me.cmbSafe.ValueMember = "id"
			Me.cmbSafe.SelectedIndex = -1
		End Sub

  Private Sub frmInvDetails_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmInvDetails.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
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
	End Class
