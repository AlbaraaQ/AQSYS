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
	Public Partial Class frmRptErsalia
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRptErsalia_Load
			frmRptErsalia.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptErsalia.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptErsalia.__ENCList.Count = frmRptErsalia.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptErsalia.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptErsalia.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptErsalia.__ENCList(num) = frmRptErsalia.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptErsalia.__ENCList.RemoveRange(num, frmRptErsalia.__ENCList.Count - num)
					frmRptErsalia.__ENCList.Capacity = frmRptErsalia.__ENCList.Count
				End If
				frmRptErsalia.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub LoadErsSupp()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=2 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSupplier.DataSource = dataTable
			Me.cmbSupplier.DisplayMember = "name"
			Me.cmbSupplier.ValueMember = "id"
			Me.cmbSupplier.SelectedIndex = -1
		End Sub

		Private Function GetCurrencyName(id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol from Currencies where id=" + Conversions.ToString(id), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		End Function

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			Try
				Dim flag As Boolean = Me.cmbSupplier.SelectedValue Is Nothing
				If flag Then
					Interaction.MsgBox("اختر المورد", MsgBoxStyle.OkOnly, Nothing)
					Me.cmbSupplier.Focus()
				Else
					flag = (Conversion.Val(Me.txtErsNo.Text) = 0.0)
					If flag Then
						Interaction.MsgBox("ادخل رقم الإرسالية", MsgBoxStyle.OkOnly, Nothing)
						Me.txtErsNo.Focus()
					Else
						Me.dgvItems.Rows.Clear()
						Me.lblComm.Text = "كومسيون"
						Dim num As Double = 0.0
						Dim num2 As Double = 0.0
						Dim num3 As Double = 0.0
						Dim num4 As Double = 0.0
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,(val) as val,exchange_price,(val1*exchange_price) as total from inv,inv_sub where inv.proc_id=inv_sub.proc_id and  is_deleted=0 and inv.proc_type=1 and ers_supp=", Me.cmbSupplier.SelectedValue), " and "), " ers_no="), Me.txtErsNo.Text)), Me.conn)
						Dim dataTable As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						flag = (dataTable.Rows.Count > 0)
						If flag Then
							Dim num5 As Integer = 0
							Dim num6 As Integer = dataTable.Rows.Count - 1
							Dim num7 As Integer = num5
							While True
								Dim num8 As Integer = num7
								Dim num9 As Integer = num6
								If num8 > num9 Then
									Exit While
								End If
								Me.dgvItems.Rows.Add()
								Me.dgvItems.Rows(num7).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num7)("total"))
								Me.dgvItems.Rows(num7).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num7)("val"))
								Me.dgvItems.Rows(num7).Cells(2).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num7)("exchange_price")))
								Me.dgvItems.Rows(num7).Cells(3).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num7)("currency_from")))

									num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num7)("total")))
									num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num7)("val")))

								num7 += 1
							End While
						End If
						sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select comm from ers_exp where supp=", Me.cmbSupplier.SelectedValue), " and no="), Me.txtErsNo.Text)), Me.conn)
						dataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						flag = (dataTable.Rows.Count > 0)
						If flag Then
							Me.lblComm.Text = "كومسيون (" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("comm")))) + "%)"
							num3 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("comm"))) / 100.0 * num)
							sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from ers_exp_sub where supp=", Me.cmbSupplier.SelectedValue), " and no="), Me.txtErsNo.Text)), Me.conn)
							dataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							flag = (dataTable.Rows.Count > 0)
							If flag Then
								Me.dgvItems.Rows.Add()
								Dim num10 As Integer = 0
								Dim num11 As Integer = dataTable.Rows.Count - 1
								Dim num12 As Integer = num10
								While True
									Dim num13 As Integer = num12
									Dim num9 As Integer = num11
									If num13 > num9 Then
										Exit While
									End If
									Me.dgvItems.Rows.Add()
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num12)("expval"))
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num12)("expname"))

										num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num12)("expval")))

									num12 += 1
								End While
							End If
						End If
						Me.txtSum.Text = "" + Conversions.ToString(num)
						Me.txtSumQuan.Text = "" + Conversions.ToString(num2)
						Me.txtComm.Text = "" + Conversions.ToString(num3)
						Me.txtSumTotal.Text = "" + Conversions.ToString(num - num3)
						Me.txtSumExpenses.Text = "" + Conversions.ToString(num4)
						Me.txtNet.Text = "" + Conversions.ToString(num - num3 - num4)
						Me.txtNetAR.Text = Number2Arabic.ameral(Me.txtNet.Text)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub frmRptErsalia_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmRptErsalia.Load
			Me.LoadErsSupp()
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("sumsale")
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("Date")
				dataTable.Columns.Add("DataColumn11")
				dataTable.Columns.Add("type")
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim rptErsalia As rptErsalia = New rptErsalia()
				rptErsalia.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptErsalia.ReportDefinition.Sections(1).ReportObjects("name"), TextObject)
				textObject.Text = Me.cmbSupplier.Text
				Dim textObject2 As TextObject = CType(rptErsalia.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
				textObject2.Text = Me.txtErsNo.Text
				Dim textObject3 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("sum"), TextObject)
				textObject3.Text = Me.txtSum.Text
				Dim textObject4 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("quan"), TextObject)
				textObject4.Text = Me.txtSumQuan.Text
				Dim textObject5 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("expenses"), TextObject)
				textObject5.Text = Me.txtSumExpenses.Text
				Dim textObject6 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("lblcomm"), TextObject)
				textObject6.Text = Me.lblComm.Text
				Dim textObject7 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("comm"), TextObject)
				textObject7.Text = Me.txtComm.Text
				Dim textObject8 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("total"), TextObject)
				textObject8.Text = Me.txtSumTotal.Text
				Dim textObject9 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("expenses1"), TextObject)
				textObject9.Text = Me.txtSumExpenses.Text
				Dim textObject10 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
				textObject10.Text = Me.txtNet.Text
				Dim textObject11 As TextObject = CType(rptErsalia.ReportDefinition.Sections(4).ReportObjects("netar"), TextObject)
				textObject11.Text = Me.txtNetAR.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptErsalia.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject12 As TextObject = CType(rptErsalia.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject13 As TextObject = CType(rptErsalia.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject14 As TextObject = CType(rptErsalia.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject15 As TextObject = CType(rptErsalia.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptErsalia
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptErsalia.PrintToPrinter(1, False, 1, currentPageNumber)
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
