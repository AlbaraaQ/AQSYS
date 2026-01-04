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
Imports AQSYS.My
	Public Partial Class frmRptSalesTax
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private EmpName As String

		Public is_buy As Integer

		Private _Finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmEmpInvs_Load
			frmRptSalesTax.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.EmpName = ""
			Me.is_buy = 0
			Me._Finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptSalesTax.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptSalesTax.__ENCList.Count = frmRptSalesTax.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptSalesTax.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptSalesTax.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptSalesTax.__ENCList(num) = frmRptSalesTax.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptSalesTax.__ENCList.RemoveRange(num, frmRptSalesTax.__ENCList.Count - num)
					frmRptSalesTax.__ENCList.Capacity = frmRptSalesTax.__ENCList.Count
				End If
				frmRptSalesTax.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me.dgvItems.ScrollBars = ScrollBars.None
		'Dim thread As Thread = AddressOf Me.ShowResult
		Dim thread As New Thread(AddressOf Me.ShowResult)
		thread.Start()
	End Sub

	Private Function GetCurrencyName(Currency_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Symbol from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			Dim result As String
			If flag Then
				result = dataTable.Rows(0)(0).ToString()
			Else
				result = ""
			End If
			Return result
		End Function

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

		Public Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("type")
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("val")
				dataTable.Columns.Add("vat")
				dataTable.Columns.Add("net")
				dataTable.Columns.Add("client_name")
				dataTable.Columns.Add("DataColumn1")
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
				Dim rptSalesTax As rptSalesTax = New rptSalesTax()
				flag = (Me.is_buy = 1)
				If flag Then
					Dim textObject As TextObject = CType(rptSalesTax.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
					textObject.Text = "تقرير ضريبة المشتريات"
					Dim textObject2 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(1).ReportObjects("lblcust2"), TextObject)
					textObject2.Text = "إسم المورد"
				End If
				rptSalesTax.SetDataSource(dataTable)
				Dim text As String = "الكل"
				flag = (Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing)
				If flag Then
					text = Me.cmbBranches.Text
				End If
				Dim textObject3 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(2).ReportObjects("branch"), TextObject)
				textObject3.Text = text
				Dim textObject4 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject4.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject5 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject5.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject6 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(4).ReportObjects("sum_tab3"), TextObject)
				textObject6.Text = Me.txtSumTab3.Text
				Dim textObject7 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(4).ReportObjects("sum_tax"), TextObject)
				textObject7.Text = Me.txtSumTax.Text
				Dim textObject8 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject8.Text = Me.txtSumTotal.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptSalesTax.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject9 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject10 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject11 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject12 As TextObject = CType(rptSalesTax.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptSalesTax
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					flag = (type = 2)
					If flag Then
						Try
							crystalReportViewer.ShowLastPage()
							Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
							crystalReportViewer.ShowFirstPage()
							rptSalesTax.PrintToPrinter(1, False, 1, currentPageNumber)
						Catch ex As Exception
						End Try
					End If
				End If
			End If
		End Sub

		Public Sub ShowResult()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("inv.branch=", Me.cmbBranches.SelectedValue), " and "))
				End If
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						Dim text2 As String = "" + dataTable.Rows(0)(0).ToString()
					End If
				Catch ex As Exception
				End Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Inv.proc_id,Inv.proc_type,date,Inv.id,inv.inv_type,is_buy,tot_purch,tot_sale,tot_net,tax,minus,cust_id,branch,customers.name as cust_name,customers.tax_no,inv.refno,inv.cust_name as cust_name2  from Inv,customers where ", text, " customers.id=inv.cust_id and date>=@date1 and date<=@date2 and is_buy=", Conversions.ToString(Me.is_buy), " and Inv.IS_Deleted=0 order by date,id" }), Me.conn)
				sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.txtDateFrom.Value.ToShortDateString())
				Dim dateTime As DateTime = Convert.ToDateTime(Me.txtDateTo.Value.AddDays(1.0).ToShortDateString())
				sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Me.dgvItems.Rows.Clear()
				Me.EmpName = ""
				Me.txtSumTab3.Text = ""
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = dataTable2.Rows.Count
				Dim num3 As Integer = 0
				Dim num4 As Integer = dataTable2.Rows.Count - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Dim flag2 As Boolean = True
					Dim flag3 As Boolean = True
					Dim str As String = ""
					flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("inv_type"))) = 1.0)
					If flag Then
						str = "آجل"
					Else
						flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("inv_type"))) = 2.0)
						If flag Then
							str = "نقدي"
						End If
					End If
					Dim str2 As String = ""
					flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("proc_type"))) = 1.0)
					Dim flag4 As Boolean
					If flag Then
						flag4 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("is_buy")))
						If flag4 Then
							str2 = "بيع"
						Else
							str2 = "شراء"
						End If
						flag3 = True
					Else
						flag4 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("proc_type"))) = 2.0)
						If flag4 Then
							flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("is_buy")))
							If flag Then
								str2 = "مرتجع بيع"
							Else
								str2 = "مرتجع شراء"
							End If
							flag3 = False
						Else
							flag2 = False
						End If
					End If
					flag4 = flag2
					If flag4 Then
						Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sum(val1*exchange_price - discount),sum(taxval) from inv_sub where taxperc<>0 and proc_id=", dataTable2.Rows(num5)("proc_id"))), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter3.Fill(dataTable3)
						Dim num8 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
						Dim num9 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sum(val1*exchange_price - discount) from inv_sub where taxperc=0 and proc_id=", dataTable2.Rows(num5)("proc_id"))), Me.conn)
						Dim dataTable4 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable4)
						Dim num10 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
						Me.dgvItems.Rows.Add()
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = str2 + " " + str
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("id"))
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("date"))).ToShortDateString()
						flag4 = (Me.is_buy <> 0)
						Dim num11 As Double
						If flag4 Then
							num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tot_purch")))
						Else
							num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tot_sale")))
						End If
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num11
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num9
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tot_net")))
						Dim value As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(num5)("cust_name")))
						flag4 = Conversions.ToBoolean(Operators.AndObject(Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("is_buy"))), Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable2.Rows(num5)("cust_name2")), "", False)))
						If flag4 Then
							value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(num5)("cust_name2")))
						End If
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = value
						Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tax_no"))
						flag4 = flag3

							If flag4 Then
								num += num9
								num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tot_net")))
							Else
								num -= num9
								num2 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("tot_net")))
							End If

					End If
					Dim progressBar As ProgressBar = Me.ProgressBar1
					progressBar.Value += 1
					num5 += 1
				End While
				Me.txtSumTax.Text = "" + Conversions.ToString(Math.Round(num, 2))
				Me.txtSumTotal.Text = "" + Conversions.ToString(Math.Round(num2, 2))
			Catch ex2 As Exception
			Finally
				Me._Finished = True
			End Try
		End Sub

		Public Sub LoadData()
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadBranches()
		End Sub

  Private Sub chkAllBranches_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllBranches.CheckedChanged
			Dim checked As Boolean = Me.chkAllBranches.Checked
			If checked Then
				Me.cmbBranches.Enabled = False
			Else
				Me.cmbBranches.Enabled = True
			End If
		End Sub

		Public Sub LoadBranches()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbBranches.DataSource = dataTable
			Me.cmbBranches.DisplayMember = "name"
			Me.cmbBranches.ValueMember = "id"
			Me.cmbBranches.SelectedIndex = -1
			Try
				Me.cmbBranches.SelectedValue = MainClass.BranchNo
			Catch ex As Exception
			End Try
		End Sub

	Private Sub frmEmpInvs_Load(ByVal sender As Object, ByVal e As EventArgs)
		Control.CheckForIllegalCrossThreadCalls = False
		Dim flag As Boolean = Me.is_buy = 1
		If flag Then
			Me.dgvItems.Columns(6).HeaderText = "إسم المورد"
		End If
		Me.LoadData()
	End Sub

	Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 7
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة بيع", False) = 0
				If flag2 Then
					Dim Form1 As New Form1()
					Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
					Dim frmSalePurch As frmSalePurch = New frmSalePurch()
					Dim value As Integer = 1
					flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة شراء", False) = 0)
					If flag2 Then
						frmSalePurch.InvProc = 1
					Else
						flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة بيع", False) = 0)
						If flag2 Then
							frmSalePurch.InvProc = 2
							value = 0
						End If
					End If
					frmSalePurch.Show()
					frmSalePurch.WindowState = FormWindowState.Maximized
					frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where is_buy=" + Conversions.ToString(value) + " and IS_Deleted=0 and proc_type=1 and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
					frmSalePurch.Activate()
				Else
					flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد بيع", False) = 0)
					If flag2 Then
						Dim Form1 As New Form1()
						Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
						Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
						Dim value2 As Integer = 1
						flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد شراء", False) = 0)
						If flag2 Then
							frmSalePurch2.InvProc = 1
						Else
							flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد بيع", False) = 0)
							If flag2 Then
								frmSalePurch2.InvProc = 2
								value2 = 0
							End If
						End If
						frmSalePurch2.Show()
						frmSalePurch2.WindowState = FormWindowState.Maximized
						frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where is_buy=" + Conversions.ToString(value2) + " and IS_Deleted=0 and proc_type=2 and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
						frmSalePurch2.Activate()
					End If
				End If
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
			Dim finished As Boolean = Me._Finished
			If finished Then
				Me._Finished = False
				Me.dgvItems.ScrollBars = ScrollBars.Both
			End If
		End Sub
	End Class
