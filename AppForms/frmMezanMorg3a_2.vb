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
	Public Partial Class frmMezanMorg3a_2
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _ParentCode As Integer

		Public _Type As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMezanMorg3a_Load
			frmMezanMorg3a_2.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._ParentCode = -1
			Me._Type = 1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmMezanMorg3a_2.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmMezanMorg3a_2.__ENCList.Count = frmMezanMorg3a_2.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmMezanMorg3a_2.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmMezanMorg3a_2.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmMezanMorg3a_2.__ENCList(num) = frmMezanMorg3a_2.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmMezanMorg3a_2.__ENCList.RemoveRange(num, frmMezanMorg3a_2.__ENCList.Count - num)
					frmMezanMorg3a_2.__ENCList.Capacity = frmMezanMorg3a_2.__ENCList.Count
				End If
				frmMezanMorg3a_2.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub GetParent(Code As Integer)
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select ParentCode from Accounts_Index where Code=" + Conversions.ToString(Code), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) < 10.0
			If flag Then
				Me._ParentCode = Code
			Else
				Me.GetParent(Conversions.ToInteger(dataTable.Rows(0)(0)))
			End If
		End Sub

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Me.dgvSrch.Rows.Clear()
				Me._ParentCode = -1
				Me.txtTotDept.Text = ""
				Me.txtTotCredit.Text = ""
				Me.txtDeptDiff.Text = ""
				Me.txtCreditDiff.Text = ""
				Me.txtIsBalanced.Text = ""
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("code")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("dept")
				dataTable.Columns.Add("credit")
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing
				If flag Then
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Restrictions.branch=", Me.cmbBranches.SelectedValue), " and Restrictions_Sub.branch="), Me.cmbBranches.SelectedValue), " and "))
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.EName,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions.branch=Restrictions_Sub.branch and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.EName order by Restrictions_Sub.acc_no", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (Me._Type = 1)
				Dim flag2 As Boolean
				If flag Then
					Dim num5 As Integer = 0
					Dim num6 As Integer = dataTable2.Rows.Count - 1
					Dim num7 As Integer = num5
					While True
						Dim num8 As Integer = num7
						Dim num9 As Integer = num6
						If num8 > num9 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num7)("acc_no"))))))
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select AName,EName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						Dim text As String = Conversions.ToString(dataTable3.Rows(0)("AName"))
						flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag Then
							text = Conversions.ToString(dataTable3.Rows(0)("EName"))
						End If
						Dim values As Object() = New Object() { Me._ParentCode, text, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num7)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num7)("credit")) }
						dataTable.Rows.Add(values)
						num7 += 1
					End While
					Dim num10 As Integer = dataTable.Rows.Count - 1
					Dim num11 As Integer = 0
					Dim num12 As Integer = num10
					Dim num13 As Integer = num11
					While True
						Dim num14 As Integer = num13
						Dim num9 As Integer = num12
						If num14 > num9 Then
							Exit While
						End If
						Dim num15 As Integer = num13 + 1
						Dim num16 As Integer = num10
						Dim num17 As Integer = num15
						While True
							Dim num18 As Integer = num17
							num9 = num16
							If num18 > num9 Then
								Exit While
							End If
							flag = (num17 <= num10)
							If flag Then
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num13)(0), dataTable.Rows(num17)(0), False)
								If flag2 Then

										dataTable.Rows(num13)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num13)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num17)(2)))
										dataTable.Rows(num13)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num13)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num17)(3)))
										dataTable.Rows.RemoveAt(num17)

									num17 -= 1
									num10 -= 1
								End If
							End If
							num17 += 1
						End While
						num13 += 1
					End While
				Else
					Dim num19 As Integer = 0
					Dim num20 As Integer = dataTable2.Rows.Count - 1
					Dim num21 As Integer = num19
					While True
						Dim num22 As Integer = num21
						Dim num9 As Integer = num20
						If num22 > num9 Then
							Exit While
						End If
						Dim text2 As String = Conversions.ToString(dataTable2.Rows(num21)("AName"))
						flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag2 Then
							text2 = Conversions.ToString(dataTable2.Rows(num21)("EName"))
						End If
						Dim values2 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num21)("acc_no")), text2, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num21)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num21)("credit")) }
						dataTable.Rows.Add(values2)
						num21 += 1
					End While
				End If
				Dim num23 As Integer = 0
				Dim num24 As Integer = dataTable.Rows.Count - 1
				Dim num25 As Integer = num23
				While True
					Dim num26 As Integer = num25
					Dim num9 As Integer = num24
					If num26 > num9 Then
						Exit While
					End If
					Me.dgvSrch.Rows.Add()
					Me.dgvSrch.Rows(num25).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(0))
					Me.dgvSrch.Rows(num25).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(1))
					Me.dgvSrch.Rows(num25).Cells(2).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(2))).ToString("N")
					Me.dgvSrch.Rows(num25).Cells(3).Value = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(3))).ToString("N")
					flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(2))) >= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(3))))

						If flag2 Then
							Me.dgvSrch.Rows(num25).Cells(4).Value = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(2))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(3)))).ToString("N")
							Me.dgvSrch.Rows(num25).Cells(5).Value = 0
						Else
							Me.dgvSrch.Rows(num25).Cells(5).Value = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(3))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(2)))).ToString("N")
							Me.dgvSrch.Rows(num25).Cells(4).Value = 0
						End If
						num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num25).Cells(2).Value))
						num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num25).Cells(3).Value))
						num3 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num25).Cells(4).Value))
						num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num25).Cells(5).Value))

					num25 += 1
				End While
				Me.txtTotDept.Text = num.ToString("N")
				Me.txtTotCredit.Text = num2.ToString("N")
				Me.txtDeptDiff.Text = num3.ToString("N")
				Me.txtCreditDiff.Text = num4.ToString("N")
				flag2 = (Math.Floor(num) = Math.Floor(num2))
				If flag2 Then
					Me.txtIsBalanced.Text = "ميزان المراجعة متوازن"
				Else
					Me.txtIsBalanced.Text = "ميزان المراجعة غير متوازن"
				End If
			Catch ex As Exception
			End Try
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

  Private Sub frmMezanMorg3a_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmMezanMorg3a.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadBranches()
		End Sub

  Private Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 6
				If flag Then
					Dim flag2 As Boolean = Me._Type = 2
				If flag2 Then
					Dim frmAccountBalance As New frmAccountBalance()
					Dim Form1 As New Form1()
					frmAccountBalance.MdiParent = Form1
					frmAccountBalance.Show()
					frmAccountBalance.txtCode.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value))
					frmAccountBalance.txtDateFrom.Value = Me.txtDateFrom.Value
					frmAccountBalance.txtDateTo.Value = Me.txtDateTo.Value
					frmAccountBalance.ShowAccount()
					frmAccountBalance.Activate()
				End If
			End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetEmpUserName(emp As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from users,Employees where users.emp=Employees.id and Employees.id=" + Conversions.ToString(emp), Me.conn)
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
			Dim flag As Boolean = Me.dgvSrch.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("code")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("dept1")
				dataTable.Columns.Add("credit1")
				dataTable.Columns.Add("dept2")
				dataTable.Columns.Add("credit2")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvSrch.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value) })
					num3 += 1
				End While
				Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					obj = New rptMezanMorag3a()
				Else
					obj = New rptMezanMorag3a___EN()
				End If
				Dim instance As Object = obj
				Dim type2 As Type = Nothing
				Dim memberName As String = "SetDataSource"
				Dim array As Object() = New Object() { dataTable }
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
				If array2(0) Then
					dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
				End If
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblHeader" }, Nothing, Nothing, Nothing), TextObject)
				textObject.Text = Me.Text
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateFrom" }, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateTo" }, Nothing, Nothing, Nothing), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtuser" }, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum1" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtTotDept.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum2" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.txtTotCredit.Text
				Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum3" }, Nothing, Nothing, Nothing), TextObject)
				textObject7.Text = Me.txtDeptDiff.Text
				Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum4" }, Nothing, Nothing, Nothing), TextObject)
				textObject8.Text = Me.txtCreditDiff.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
				Dim type3 As Type = Nothing
				Dim memberName2 As String = "SetDataSource"
				Dim array3 As Object() = New Object() { dataTable2 }
				Dim arguments2 As Object() = array3
				Dim argumentNames2 As String() = Nothing
				Dim typeArguments2 As Type() = Nothing
				array2 = New Boolean() { True }
				NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
				If array2(0) Then
					dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
				End If
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
					textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						Dim instance3 As Object = obj
						Dim type4 As Type = Nothing
						Dim memberName3 As String = "PrintToPrinter"
						array = New Object() { 1, False, 1, num6 }
						Dim arguments3 As Object() = array
						Dim argumentNames3 As String() = Nothing
						Dim typeArguments3 As Type() = Nothing
						array2 = New Boolean() { False, False, False, True }
						NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
						If array2(3) Then
							num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
						End If
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

  Private Sub txtTotDept_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotDept.TextChanged
		End Sub

  Private Sub chkAllBranches_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllBranches.CheckedChanged
			Dim checked As Boolean = Me.chkAllBranches.Checked
			If checked Then
				Me.cmbBranches.Enabled = False
			Else
				Me.cmbBranches.Enabled = True
			End If
		End Sub
	End Class
