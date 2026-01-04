Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
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
Partial Public Class frmTawlaGroups
	Inherits Form

	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Private conn As SqlConnection

	Private Code As Integer
	Shared Sub New()
	End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmTawlaGroups.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmTawlaGroups.__ENCList.Count = frmTawlaGroups.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmTawlaGroups.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmTawlaGroups.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmTawlaGroups.__ENCList(num) = frmTawlaGroups.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmTawlaGroups.__ENCList.RemoveRange(num, frmTawlaGroups.__ENCList.Count - num)
				frmTawlaGroups.__ENCList.Capacity = frmTawlaGroups.__ENCList.Count
			End If
			frmTawlaGroups.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Public Sub New()
		frmTawlaGroups.__ENCAddToList(Me)
		Me.components = Nothing
		Me.conn = MainClass.ConnObj()
		Me.Code = -1
		Me.InitializeComponent()
	End Sub

	Private Sub CLR()
		Me.txtName.Text = ""
		Me.Code = -1
	End Sub

	Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
		Me.CLR()
	End Sub

	Private Sub LoadDG()
		Me.dgvActs.Rows.Clear()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from tawla_groups", Me.conn)
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
			Me.dgvActs.Rows.Add()
			Me.dgvActs.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
			Me.dgvActs.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
			Try
				Dim value As String = ""
				Dim flag As Boolean = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("type"))) = 1
				If flag Then
					value = "مختلط"
				Else
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("type"))) = 2)
					If flag Then
						value = "أفراد"
					Else
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("type"))) = 3)
						If flag Then
							value = "عوائل"
						End If
					End If
				End If
				Me.dgvActs.Rows(num3).Cells(2).Value = value
			Catch ex As Exception
			End Try
			num3 += 1
		End While
		Me.dgvActs.ClearSelection()
	End Sub

	Private Sub frmActs_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.LoadDG()
		Me.WindowState = MainClass.Window_State
	End Sub

	Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
		Try
			Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
				If flag2 Then
					Me.conn.Open()
				End If
				Dim value As Integer = 1
				flag2 = Me.rdOne.Checked
				If flag2 Then
					value = 2
				Else
					flag2 = Me.rdFamily.Checked
					If flag2 Then
						value = 3
					End If
				End If
				flag2 = (Me.Code = -1)
				If flag2 Then
					Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"insert into tawla_groups(name,type) values('", Me.txtName.Text, "',", Conversions.ToString(value), ")"}), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Me.txtName.Text = ""
					Me.txtName.Focus()
				Else
					Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() {"update tawla_groups set  name ='", Me.txtName.Text, "',type=", Conversions.ToString(value), " where id=", Conversions.ToString(Me.Code)}), Me.conn)
					sqlCommand2.ExecuteNonQuery()
					Me.txtName.Focus()
				End If
				Me.LoadDG()
			Else
				MessageBox.Show("ادخل المجموعة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.txtName.Focus()
			End If
		Catch ex As Exception
			Dim text As String = "خطأ أثناء الحفظ"
			text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		Finally
			Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
			If flag2 Then
				Me.conn.Close()
			End If
		End Try
	End Sub

	Private Sub dgv_RowChng(row_index As Integer)
		Me.txtName.Text = Me.dgvActs.Rows(row_index).Cells(1).Value.ToString()
		Me.Code = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvActs.Rows(row_index).Cells(0).Value))
	End Sub

	Private Sub dgvActs_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvActs.CellClick
		Me.Navigate("select * from tawla_groups where id=" + Conversions.ToString(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvActs.Rows(e.RowIndex).Cells(0).Value))))
	End Sub

	Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
		Try
			Dim flag As Boolean = Me.Code <> -1
			If flag Then
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
				If flag2 Then
					Me.conn.Open()
				End If
				Dim sqlCommand As SqlCommand = New SqlCommand("delete from tawla_groups where id=" + Conversions.ToString(Me.Code), Me.conn)
				sqlCommand.ExecuteNonQuery()
				MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.LoadDG()
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

	Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtName.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
			Me.btnSave_Click(Nothing, Nothing)
		End If
	End Sub

	Private Sub ReadData(dr As SqlDataReader)
		Dim flag As Boolean = dr.HasRows
		If flag Then
			dr.Read()
			Me.Code = Convert.ToInt32("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("id"))))
			Me.txtName.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("name")))
			Try
				flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("type"))) = 1)
				If flag Then
					Me.rdMix.Checked = True
				Else
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("type"))) = 2)
					If flag Then
						Me.rdOne.Checked = True
					Else
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("type"))) = 3)
						If flag Then
							Me.rdFamily.Checked = True
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			dr.Close()
		End If
	End Sub

	Private Sub Navigate(sqlstr As String)
		Me.dgvActs.ClearSelection()
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
		Me.Navigate("select top 1 * from tawla_groups order by id desc")
	End Sub

	Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
		Me.Navigate("select top 1 * from tawla_groups order by id asc")
	End Sub

	Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
		Me.Navigate("select top 1 * from tawla_groups where id>" + Conversions.ToString(Me.Code) + " order by id asc")
	End Sub

	Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
		Me.Navigate("select top 1 * from tawla_groups where id<" + Conversions.ToString(Me.Code) + " order by id desc")
	End Sub

	Private Sub PrintRpt(type As Integer)
		Dim flag As Boolean = Me.dgvActs.Rows.Count = 0
		If flag Then
			MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		Else
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("col1")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvActs.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvActs.Rows(num3).Cells(1).Value)})
				num3 += 1
			End While
			Dim rptCol As rptCol1 = New rptCol1()
			rptCol.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
			textObject.Text = "مجموعات الطاولات"
			Dim textObject2 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
			textObject2.Text = "المجموعة"
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			rptCol.Subreports("rptHeader").SetDataSource(dataTable2)
			flag = (dataTable2.Rows.Count > 0)
			If flag Then
				Dim textObject3 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
				textObject3.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Address")))
				Dim textObject4 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
				textObject4.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Tel")))
				Dim textObject5 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
				textObject5.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Mobile")))
				Dim textObject6 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
				textObject6.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Fax")))
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

	Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
	End Sub

	Private Sub frmTawlaGroups_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		Me.LoadDG()
	End Sub
End Class
