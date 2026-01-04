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
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Public Partial Class frmCities
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Private conn As SqlConnection

		Private Code As Integer

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmCities_Load
			frmCities.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmCities.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmCities.__ENCList.Count = frmCities.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmCities.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmCities.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmCities.__ENCList(num) = frmCities.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmCities.__ENCList.RemoveRange(num, frmCities.__ENCList.Count - num)
					frmCities.__ENCList.Capacity = frmCities.__ENCList.Count
				End If
				frmCities.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			Me.txtName.Text = ""
			Me.Code = -1
		End Sub

		Private Sub LoadDG()
			Me.dgvCities.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Cities.id as city_id,Countries.id as country_id,Countries.name as country,Cities.name as city from Cities,Countries  where Cities.country=Countries.id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Me.dgvCities.Rows.Add()
				Me.dgvCities.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("city_id"))
				Me.dgvCities.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("country"))
				Me.dgvCities.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("city"))
				Me.dgvCities.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("country_id"))
				num3 += 1
			End While
			Me.dgvCities.ClearSelection()
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

		Public Sub LoadCountries()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Countries order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCountry.DataSource = dataTable
			Me.cmbCountry.DisplayMember = "name"
			Me.cmbCountry.ValueMember = "id"
			Me.cmbCountry.SelectedIndex = -1
		End Sub

  Private Sub frmCities_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmCities.Load
			Dim flag As Boolean = Me.cmbCountry.Items.Count = 0
			If flag Then
				Me.LoadCountries()
			End If
			Me.LoadDG()
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Me.cmbCountry.SelectedIndex = -1
				If flag Then
					MessageBox.Show("يجب اختيار دولة أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbCountry.Focus()
				Else
					flag = (Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0)
					If flag Then
						MessageBox.Show("يجب ادخال اسم المدينة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.txtName.Focus()
					Else
						flag = (Me.conn.State <> ConnectionState.Open)
						If flag Then
							Me.conn.Open()
						End If
						flag = (Me.Code = -1)
						If flag Then
							Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Cities(name,country) values('" + Me.txtName.Text + "',", Me.cmbCountry.SelectedValue), ")")), Me.conn)
							sqlCommand.ExecuteNonQuery()
							Me.txtName.Text = ""
							Me.txtName.Focus()
						Else
							Dim sqlCommand2 As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Cities set name='" + Me.txtName.Text + "',country =", Me.cmbCountry.SelectedValue), " where id="), Me.Code)), Me.conn)
							sqlCommand2.ExecuteNonQuery()
							Me.txtName.Focus()
						End If
						Me.LoadDG()
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("delete from Cities where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.LoadDG()
					Me.CLR()
				Else
					MessageBox.Show("اختر مدينة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Sub dgvRowChng(row_index As Integer)
			Me.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dgvCities.Rows(row_index).Cells(3).Value)
			Me.txtName.Text = Me.dgvCities.Rows(row_index).Cells(2).Value.ToString()
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvCities.Rows(row_index).Cells(0).Value))))
		End Sub

  Private Sub dgvCities_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCities.CellClick
			Dim flag As Boolean = e.RowIndex >= 0
			If flag Then
				Me.dgvRowChng(e.RowIndex)
			End If
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtName.KeyDown
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.btnSave_Click(Nothing, Nothing)
			End If
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				dr.Read()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(dr("country"))
				Me.txtName.Text = Conversions.ToString(dr("name"))
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvCities.ClearSelection()
			Dim sqlCommand As SqlCommand = New SqlCommand(sqlstr, Me.conn)
			Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
			If flag Then
				Me.conn.Open()
			End If
			Dim dr As SqlDataReader = sqlCommand.ExecuteReader()
			Me.ReadData(dr)
			flag = (Me.conn.State <> ConnectionState.Closed)
			If flag Then
				Me.conn.Close()
			End If
		End Sub

  Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			Me.Navigate("select top 1 * from Cities order by id desc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from Cities order by id asc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from Cities where id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from Cities where id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

  Private Sub btnCountryAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCountryAdd.Click
			Dim num As Integer = -1
			Dim flag As Boolean = Me.cmbCountry.SelectedValue IsNot Nothing
			If flag Then
				num = Conversions.ToInteger(Me.cmbCountry.SelectedValue)
			End If
			Dim frmCountries As frmCountries = New frmCountries()
			frmCountries.Activate()
			frmCountries.ShowDialog()
			Me.LoadCountries()
			Try
				Me.cmbCountry.SelectedValue = num
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvCities.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("col1")
				dataTable.Columns.Add("col2")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvCities.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvCities.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvCities.Rows(num3).Cells(2).Value) })
					num3 += 1
				End While
				Dim rptcol As rptcol2 = New rptcol2()
				rptcol.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptcol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
				textObject.Text = "المدن"
				Dim textObject2 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
				textObject2.Text = "الدولة"
				Dim textObject3 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col2"), TextObject)
				textObject3.Text = "المدينة"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptcol.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject4 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject5 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject6 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject7 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptcol
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptcol.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
		End Sub
	End Class
