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
Public Partial Class frmTaxGroups
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmActs_Load
			frmTaxGroups.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmTaxGroups.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmTaxGroups.__ENCList.Count = frmTaxGroups.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmTaxGroups.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmTaxGroups.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmTaxGroups.__ENCList(num) = frmTaxGroups.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmTaxGroups.__ENCList.RemoveRange(num, frmTaxGroups.__ENCList.Count - num)
					frmTaxGroups.__ENCList.Capacity = frmTaxGroups.__ENCList.Count
				End If
				frmTaxGroups.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			Me.GetNxtID()
			Me.txtNameAr.Text = ""
			Me.txtNameEN.Text = ""
			Me.txtValue.Text = ""
			Me.cmbCurrency.SelectedIndex = -1
			Me.dgvData.Rows.Clear()
			Me.Code = -1
		End Sub

		Private Sub GetNxtID()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(id) from tax_groups", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Me.txtNo.Text = Conversions.ToString(Conversion.Val("" + dataTable.Rows(0)(0).ToString()) + 1.0)
				Else
					Me.txtNo.Text = "1"
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

		Private Sub LoadDG(_id As Integer)
			Me.dgvData.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from currencies where is_deleted=0 and tax_group=" + Conversions.ToString(_id), Me.conn)
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
				Me.dgvData.Rows.Add()
				Me.dgvData.Rows(num3).Cells(0).Value = num3 + 1
				Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag Then
					Me.dgvData.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("symbol"))
				Else
					Me.dgvData.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nameEN"))
				End If
				num3 += 1
			End While
			Me.dgvData.ClearSelection()
		End Sub

		Public Sub LoadAllCurrency()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCurrency.DataSource = dataTable
			Me.cmbCurrency.DisplayMember = "symbol"
			Me.cmbCurrency.ValueMember = "id"
			Me.cmbCurrency.SelectedIndex = -1
		End Sub

  Private Sub frmActs_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmActs.Load
			Me.LoadAllCurrency()
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtNo.Text.Trim(), "", False) = 0
				If flag Then
					MessageBox.Show("ادخل الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtNo.Focus()
				Else
					flag = (Operators.CompareString(Me.txtNameAr.Text.Trim(), "", False) = 0)
					If flag Then
						MessageBox.Show("ادخل الإسم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.txtNameAr.Focus()
					Else
						flag = (Operators.CompareString(Me.txtValue.Text.Trim(), "", False) = 0)
						If flag Then
							MessageBox.Show("ادخل القيمة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.txtValue.Focus()
						Else
							flag = (Me.conn.State <> ConnectionState.Open)
							If flag Then
								Me.conn.Open()
							End If
							Dim sqlCommand As SqlCommand = New SqlCommand()
							flag = (Me.Code = -1)
							If flag Then
								sqlCommand = New SqlCommand("insert into tax_groups(id,nameAR,nameEN,Value) values(@id,@nameAR,@nameEN,@Value)", Me.conn)
							Else
								sqlCommand = New SqlCommand("update tax_groups set nameAR=@nameAR,nameEN=@nameEN,Value=@Value where id=" + Me.txtNo.Text, Me.conn)
							End If
							sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Me.txtNo.Text
							sqlCommand.Parameters.Add("@nameAR", SqlDbType.NVarChar).Value = Me.txtNameAr.Text
							sqlCommand.Parameters.Add("@nameEN", SqlDbType.NVarChar).Value = Me.txtNameEN.Text
							sqlCommand.Parameters.Add("@Value", SqlDbType.Float).Value = Conversion.Val(Me.txtValue.Text)
							sqlCommand.ExecuteNonQuery()
							flag = (Me.Code <> -1)
							If flag Then
								sqlCommand = New SqlCommand("update currencies set tax=" + Conversions.ToString(Conversion.Val(Me.txtValue.Text)) + " where tax_group=" + Conversions.ToString(Me.Code), Me.conn)
								sqlCommand.ExecuteNonQuery()
							End If
							Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
							Me.CLR()
						End If
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

  Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
			Dim flag As Boolean = e.ColumnIndex = 3
			If flag Then
				Try
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update currencies set tax_group=1 where id=", Me.dgvData.Rows(e.RowIndex).Cells(1).Value)), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.dgvData.Rows.RemoveAt(e.RowIndex)
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
			End If
		End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("delete from tax_groups where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					sqlCommand = New SqlCommand("update currencies set tax_group=1 where tax_group=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.CLR()
				Else
					MessageBox.Show("اختر مجموعة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				dr.Read()
				Me.CLR()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("id")))
				Me.txtNameAr.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("nameAR")))
				Me.txtNameEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("nameEN")))
				Me.txtValue.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("value")))
				Me.LoadDG(Me.Code)
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvData.ClearSelection()
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
			Me.Navigate("select top 1 * from tax_groups order by id desc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from tax_groups order by id asc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from tax_groups where id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from tax_groups where id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvData.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("col1")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvData.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value) })
					num3 += 1
				End While
				Dim rptCol As rptCol1 = New rptCol1()
				rptCol.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
				textObject.Text = "المجموعات"
				Dim textObject2 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
				textObject2.Text = "المجموعة"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptCol.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject3 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject4 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject5 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject6 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptCol
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptCol.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.cmbCurrency.SelectedValue Is Nothing
				If flag Then
					Interaction.MsgBox("اختر الصنف", MsgBoxStyle.OkOnly, Nothing)
					Me.cmbCurrency.Focus()
				Else
					flag = (Me.Code = -1)
					If flag Then
						Interaction.MsgBox("اختر المجموعة الضريبية أولا", MsgBoxStyle.OkOnly, Nothing)
					Else
						flag = (Me.conn.State <> ConnectionState.Open)
						If flag Then
							Me.conn.Open()
						End If
						Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update currencies set tax_group=" + Conversions.ToString(Me.Code) + " where id=", Me.cmbCurrency.SelectedValue)), Me.conn)
						sqlCommand.ExecuteNonQuery()
						Me.dgvData.Rows.Add()
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(0).Value = Me.dgvData.Rows.Count
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(2).Value = Me.cmbCurrency.Text
						Me.cmbCurrency.SelectedIndex = -1
					End If
				End If
			Catch ex As Exception
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub
	End Class
