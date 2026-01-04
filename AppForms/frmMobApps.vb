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
Public Partial Class frmMobApps
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmMobApps.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmMobApps.__ENCList.Count = frmMobApps.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmMobApps.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmMobApps.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmMobApps.__ENCList(num) = frmMobApps.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmMobApps.__ENCList.RemoveRange(num, frmMobApps.__ENCList.Count - num)
					frmMobApps.__ENCList.Capacity = frmMobApps.__ENCList.Count
				End If
				frmMobApps.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmBanks_Load
			frmMobApps.__ENCAddToList(Me)
			Me.components = Nothing
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.Code = -1
		End Sub

		Private Sub LoadDG(cond As String)
			Me.dgvData.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from mobapps where " + cond + " IS_Deleted=0 order by id", Me.conn)
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
				Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
				Me.dgvData.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("fees"))
				Me.dgvData.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("notes"))
				num3 += 1
			End While
			Me.dgvData.ClearSelection()
		End Sub

  Public Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Public Sub frmBanks_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmBanks.Load
			Me.LoadDG("")
		End Sub

  Public Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
				If flag Then
					MessageBox.Show("يجب ادخال اسم التطبيق", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtName.Focus()
				Else
					flag = (Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState))
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag = (Me.Code = -1)
					If flag Then
						sqlCommand = New SqlCommand("insert into mobapps(name,fees,notes,IS_Deleted) values (@name,@fees,@notes,@IS_Deleted)", Me.conn)
					Else
						sqlCommand = New SqlCommand("update mobapps set name=@name ,fees=@fees ,notes=@notes ,IS_Deleted=@IS_Deleted where id=" + Convert.ToString(Me.Code), Me.conn)
					End If
					sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
					sqlCommand.Parameters.Add("@fees", SqlDbType.Float).Value = Conversion.Val(Me.txtFee.Text)
					sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
					sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
					sqlCommand.ExecuteNonQuery()
					Me.LoadDG("")
					Me.CLR()
					MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState)
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Public Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState)
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update mobapps set IS_Deleted=1 where id=" + Convert.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Me.LoadDG("")
					Me.CLR()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					MessageBox.Show("اختر سجل ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState)
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Sub dgvRowChng(row_index As Integer)
			Me.Code = Convert.ToInt32(Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from mobapps where id=" + Convert.ToString(Me.Code))
		End Sub

	Public Sub dgvBanks_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
		Dim flag As Boolean = e.RowIndex >= 0
		If flag Then
			Me.dgvRowChng(e.RowIndex)
		End If
	End Sub

	Public Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				dr.Read()
				Me.CLR()
				Me.Code = Convert.ToInt32(Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("id")))))
				Me.txtName.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("name")))
				Me.txtFee.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("fees")))
				Me.txtNotes.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dr("notes")))
				dr.Close()
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvData.ClearSelection()
			Dim sqlCommand As SqlCommand = New SqlCommand(sqlstr, Me.conn)
			Dim flag As Boolean = Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState)
			If flag Then
				Me.conn.Open()
			End If
			Dim dr As SqlDataReader = sqlCommand.ExecuteReader()
			Me.ReadData(dr)
			flag = (Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState))
			If flag Then
				Me.conn.Close()
			End If
		End Sub

  Public Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			Me.Navigate("select top 1 * from mobapps where IS_Deleted=0 order by id desc")
		End Sub

  Public Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from mobapps where IS_Deleted=0 and id>" + Convert.ToString(Me.Code) + " order by id asc")
		End Sub

  Public Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from mobapps where IS_Deleted=0 order by id asc")
		End Sub

  Public Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from mobapps where IS_Deleted=0 and id<" + Convert.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvData.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("col1")
				dataTable.Columns.Add("col2")
				dataTable.Columns.Add("col3")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvData.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(3).Value) })
					num3 += 1
				End While
				Dim rptCol As rptCol3 = New rptCol3()
				rptCol.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
				textObject.Text = "تطبيقات الجوال"
				Dim textObject2 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
				textObject2.Text = "الاسم"
				Dim textObject3 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col2"), TextObject)
				textObject3.Text = "الرسوم"
				Dim textObject4 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col3"), TextObject)
				textObject4.Text = "ملاحظات"
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptCol.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject6.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Mobile")))
					Dim textObject8 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject8.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Fax")))
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

  Public Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub
	End Class
