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
	Public Partial Class frmRptClientMaintDetails
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Public Cust As Integer

		Private _Finished As Boolean

		Public ClientID As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRptClientMaintDetails_Load
			frmRptClientMaintDetails.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Cust = -1
			Me._Finished = False
			Me.ClientID = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptClientMaintDetails.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptClientMaintDetails.__ENCList.Count = frmRptClientMaintDetails.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptClientMaintDetails.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptClientMaintDetails.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptClientMaintDetails.__ENCList(num) = frmRptClientMaintDetails.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptClientMaintDetails.__ENCList.RemoveRange(num, frmRptClientMaintDetails.__ENCList.Count - num)
					frmRptClientMaintDetails.__ENCList.Capacity = frmRptClientMaintDetails.__ENCList.Count
				End If
				frmRptClientMaintDetails.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Function GetEmpName(emp As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
			Catch ex As Exception
			End Try
			Return ""
		End Function

		Public Sub LoadCustomers()
			Dim value As Integer = 1
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where is_deleted=0 and type=" + Conversions.ToString(value) + " order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbClient.DataSource = dataTable
			Me.cmbClient.DisplayMember = "name"
			Me.cmbClient.ValueMember = "id"
			Me.cmbClient.SelectedIndex = -1
		End Sub

		Private Sub ShowResult()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.cmbClient.SelectedValue Is Nothing
				If flag Then
					Interaction.MsgBox("اختر عميل", MsgBoxStyle.OkOnly, Nothing)
					Me.cmbClient.Focus()
				Else
					Me.Cust = Conversions.ToInteger(Me.cmbClient.SelectedValue)
					Me.dgvData.Rows.Clear()
					Dim num As Double = 0.0
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select proc_id,inv.date,inv.id,tot_net,employees.name as emp,is_maint from inv,employees where inv.sales_emp=employees.id and inv.is_deleted=0 and (is_maint=0 or (is_maint=1 and maint_inv_id=0)) and cust_id=" + Conversions.ToString(Me.Cust) + " order by inv.date", Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Me.ProgressBar1.Value = 0
					Me.ProgressBar1.Maximum = dataTable.Rows.Count
					Dim num2 As Integer = 0
					Dim num3 As Integer = dataTable.Rows.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Me.dgvData.Rows.Add()
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num4)("is_maint"), 0, False)
						If flag Then
							Me.dgvData.Rows(num4).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("id"))
							Me.dgvData.Rows(num4).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("date"))).ToShortDateString()
							Dim text As String = ""
							Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select currencies.symbol from inv_sub,currencies where inv_sub.currency_from=currencies.id and proc_id=", dataTable.Rows(num4)("proc_id"))), Me.conn)
							Dim dataTable2 As DataTable = New DataTable()
							sqlDataAdapter2.Fill(dataTable2)
							Dim num7 As Integer = 0
							Dim num8 As Integer = dataTable2.Rows.Count - 1
							Dim num9 As Integer = num7
							While True
								Dim num10 As Integer = num9
								num6 = num8
								If num10 > num6 Then
									Exit While
								End If
								flag = (num9 <> 0)
								If flag Then
									text += " - "
								End If
								text = Conversions.ToString(Operators.AddObject(text, dataTable2.Rows(num9)("symbol")))
								num9 += 1
							End While
							Me.dgvData.Rows(num4).Cells(2).Value = text
							Me.dgvData.Rows(num4).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("tot_net"))
							Me.dgvData.Rows(num4).Cells(6).Value = Operators.ConcatenateObject("", dataTable.Rows(num4)("emp"))
							Dim text2 As String = ""
							Dim text3 As String = ""
							Dim text4 As String = ""
							Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv.proc_id,inv.date,employees.name as emp from inv,employees where inv.sales_emp=employees.id and inv.is_deleted=0 and is_maint=1 and maint_inv_id=", dataTable.Rows(num4)("id")), " and cust_id="), Me.Cust), "order by inv.date")), Me.conn)
							Dim dataTable3 As DataTable = New DataTable()
							sqlDataAdapter3.Fill(dataTable3)
							Dim num11 As Integer = 0
							Dim num12 As Integer = dataTable3.Rows.Count - 1
							Dim num13 As Integer = num11
							While True
								Dim num14 As Integer = num13
								num6 = num12
								If num14 > num6 Then
									Exit While
								End If
								flag = (num13 <> 0)
								If flag Then
									text2 += Environment.NewLine
									text3 += Environment.NewLine
									text4 += Environment.NewLine
								End If
								text2 += Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num13)("date"))).ToShortDateString()
								Try
									text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject("", dataTable3.Rows(num13)("emp"))))
								Catch ex As Exception
								End Try
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select currencies.symbol from inv_sub,currencies where inv_sub.currency_from=currencies.id and proc_id=", dataTable3.Rows(num13)("proc_id"))), Me.conn)
								dataTable2 = New DataTable()
								sqlDataAdapter2.Fill(dataTable2)
								Dim num15 As Integer = 0
								Dim num16 As Integer = dataTable2.Rows.Count - 1
								Dim num17 As Integer = num15
								While True
									Dim num18 As Integer = num17
									num6 = num16
									If num18 > num6 Then
										Exit While
									End If
									flag = (num17 <> 0)
									If flag Then
										text3 += " - "
									End If
									text3 = Conversions.ToString(Operators.AddObject(text3, dataTable2.Rows(num17)("symbol")))
									num17 += 1
								End While
								num13 += 1
							End While
							Me.dgvData.Rows(num4).Cells(4).Value = text2
							Me.dgvData.Rows(num4).Cells(5).Value = text3
							flag = (Operators.CompareString(text4, "", False) <> 0)
							If flag Then
								Me.dgvData.Rows(num4).Cells(6).Value = text4
							End If

								num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("tot_net")))

						Else
							Dim value As String = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("date"))).ToShortDateString()
							Dim value2 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num4)("emp")))
							Dim text5 As String = ""
							Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select currencies.symbol from inv_sub,currencies where inv_sub.currency_from=currencies.id and proc_id=", dataTable.Rows(num4)("proc_id"))), Me.conn)
							Dim dataTable4 As DataTable = New DataTable()
							sqlDataAdapter4.Fill(dataTable4)
							Dim num19 As Integer = 0
							Dim num20 As Integer = dataTable4.Rows.Count - 1
							Dim num21 As Integer = num19
							While True
								Dim num22 As Integer = num21
								num6 = num20
								If num22 > num6 Then
									Exit While
								End If
								flag = (num21 <> 0)
								If flag Then
									text5 += " - "
								End If
								text5 = Conversions.ToString(Operators.AddObject(text5, dataTable4.Rows(num21)("symbol")))
								num21 += 1
							End While
							Me.dgvData.Rows(num4).Cells(4).Value = value
							Me.dgvData.Rows(num4).Cells(5).Value = text5
							Me.dgvData.Rows(num4).Cells(6).Value = value2
						End If
						Me.ProgressBar1.Value = num4 + 1
						num4 += 1
					End While
				End If
			Catch ex2 As Exception
			Finally
				Me._Finished = True
			End Try
		End Sub

  Private Sub frmRptClientMaintDetails_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmRptClientMaintDetails.Load
			Control.CheckForIllegalCrossThreadCalls = False
			Me.LoadCustomers()
			Dim flag As Boolean = False
			Dim flag3 As Boolean
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Users where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag2 As Boolean = dataTable.Rows.Count > 0
				If flag2 Then
					flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_tel")))
					If flag3 Then
						flag = True
					End If
				End If
			Catch ex As Exception
			End Try
			flag3 = flag
			If flag3 Then
				Me.lblMobile.Visible = False
				Me.txtMobile.Visible = False
			End If
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Me.Close()
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvData.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("id")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("val")
				dataTable.Columns.Add("date2")
				dataTable.Columns.Add("DataColumn11")
				dataTable.Columns.Add("DataColumn12")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvData.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(6).Value) })
					num3 += 1
				End While
				Dim rptClientsMonitorDetails As rptClientsMonitorDetails = New rptClientsMonitorDetails()
				rptClientsMonitorDetails.SetDataSource(dataTable)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptClientsMonitorDetails.Subreports("rptHeader").SetDataSource(dataTable2)
				Dim textObject As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("name"), TextObject)
				textObject.Text = Me.cmbClient.Text
				flag = Me.txtMobile.Visible
				If flag Then
					rptClientsMonitorDetails.SetParameterValue("mobile", Me.txtMobile.Text)
				Else
					rptClientsMonitorDetails.SetParameterValue("mobile", "")
				End If
				Dim textObject2 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
				textObject2.Text = Me.txtNo.Text
				Dim textObject3 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("add"), TextObject)
				textObject3.Text = Me.txtAdd.Text
				Dim textObject4 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("city"), TextObject)
				textObject4.Text = Me.txtCity.Text
				Dim textObject5 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("area"), TextObject)
				textObject5.Text = Me.txtArea.Text
				Dim textObject6 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("Sum"), TextObject)
				textObject6.Text = Me.txtSum.Text
				Dim textObject7 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("join_date"), TextObject)
				textObject7.Text = Me.txtJoinDate.Text
				Dim textObject8 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(1).ReportObjects("last_maint"), TextObject)
				textObject8.Text = Me.txtLastMaint.Text
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject9 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject10 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject11 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject12 As TextObject = CType(rptClientsMonitorDetails.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptClientsMonitorDetails
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptClientsMonitorDetails.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub dgvData_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
		End Sub

  Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
			Me._Finished = False
			Me.dgvData.ScrollBars = ScrollBars.None
			Me.Timer1.Enabled = True
			'Dim thread As Thread = AddressOf Me.ShowResult
			Dim thread As New Thread(AddressOf Me.ShowResult)
			thread.Start()
		End Sub

		Private Function GetCityName(_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from cities where id=" + Conversions.ToString(_id), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			Dim result As String
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
				If flag2 Then
					result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				Else
					result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
				End If
			Else
				result = ""
			End If
			Return result
		End Function

		Private Function GetAreaName(_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from areas where id=" + Conversions.ToString(_id), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			Dim result As String
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
				If flag2 Then
					result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				Else
					result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
				End If
			Else
				result = ""
			End If
			Return result
		End Function

  Private Sub cmbClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbClient.SelectedIndexChanged
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Me.txtNo.Text = Conversions.ToString(dataTable.Rows(0)("cust_no"))
					Dim text As String = ""
					flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("tel")), "", False)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tel")))
					End If
					flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("mobile")), "", False)
					If flag Then
						Dim flag2 As Boolean = Operators.CompareString(text, "", False) <> 0
						If flag2 Then
							text += Environment.NewLine
						End If
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject("", dataTable.Rows(0)("mobile"))))
					End If
					Me.txtMobile.Text = text
					Me.txtAdd.Text = Conversions.ToString(dataTable.Rows(0)("address"))
					Me.txtCity.Text = Me.GetCityName(Conversions.ToInteger(dataTable.Rows(0)("city")))
					Me.txtArea.Text = Me.GetAreaName(Conversions.ToInteger(dataTable.Rows(0)("area")))
					Dim text2 As String = ""
					Try
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("join_date")), "", False)
						If flag2 Then
							Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_deleted=0 and cust_id=", Me.cmbClient.SelectedValue), " order by date")), Me.conn)
							Dim dataTable2 As DataTable = New DataTable()
							sqlDataAdapter2.Fill(dataTable2)
							flag2 = (dataTable2.Rows.Count > 0)
							If flag2 Then
								text2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))).ToShortDateString()
							End If
						Else
							text2 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("join_date"))).ToShortDateString()
						End If
					Catch ex As Exception
					End Try
					Me.txtJoinDate.Text = text2
					Dim text3 As String = ""
					Try
						Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 date from inv where is_maint=1 and is_deleted=0 and cust_id=", Me.cmbClient.SelectedValue), " order by date desc")), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter3.Fill(dataTable3)
						Dim flag2 As Boolean = dataTable3.Rows.Count > 0
						If flag2 Then
							text3 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))).ToShortDateString()
						Else
							text3 = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("maint_date"))).ToShortDateString()
						End If
					Catch ex2 As Exception
					End Try
					Me.txtLastMaint.Text = text3
					Dim value As Double = 0.0
					Try
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sum(tot_net) from inv where is_deleted=0 and (is_maint is null or is_maint=0) and cust_id=", Me.cmbClient.SelectedValue)), Me.conn)
						Dim dataTable4 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable4)
						value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
					Catch ex3 As Exception
					End Try
					Me.txtSum.Text = Conversions.ToString(value)
				End If
			Catch ex4 As Exception
			End Try
		End Sub

  Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
			Try
			'New frmSrchClient() With { ._type = 1, .Form_Type = 6, .frm6 = Me }.ShowDialog()
			Using frm As New frmSrchClient()
				frm._type = 1
				frm.Form_Type = 6
				frm.frm6 = Me
				frm.ShowDialog()
			End Using
			Me.cmbClient.SelectedValue = Me.ClientID
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtSrchMobile_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSrchMobile.TextChanged
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtSrchMobile.Text.Trim(), "", False) = 0
				If Not flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select id from customers where is_deleted=0 and (tel = '", Me.txtSrchMobile.Text, "' or mobile = '", Me.txtSrchMobile.Text, "')" }), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						Me.cmbClient.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
					Else
						Me.cmbClient.SelectedIndex = -1
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Dim finished As Boolean = Me._Finished
			If finished Then
				Me._Finished = False
				Me.Timer1.Enabled = False
				Me.dgvData.ScrollBars = ScrollBars.Both
			End If
		End Sub
	End Class
