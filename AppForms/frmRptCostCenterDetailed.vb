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
Imports AQSYS.My
Imports AQSYS.AQSYS.rptt
Public Partial Class frmRptCostCenterDetailed
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmCustAccountGet_Load
			frmRptCostCenterDetailed.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptCostCenterDetailed.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptCostCenterDetailed.__ENCList.Count = frmRptCostCenterDetailed.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptCostCenterDetailed.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptCostCenterDetailed.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptCostCenterDetailed.__ENCList(num) = frmRptCostCenterDetailed.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptCostCenterDetailed.__ENCList.RemoveRange(num, frmRptCostCenterDetailed.__ENCList.Count - num)
					frmRptCostCenterDetailed.__ENCList.Capacity = frmRptCostCenterDetailed.__ENCList.Count
				End If
				frmRptCostCenterDetailed.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Public Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub LoadCenters()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from costcenter order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCenter.DataSource = dataTable
			Me.cmbCenter.DisplayMember = "name"
			Me.cmbCenter.ValueMember = "id"
			Me.cmbCenter.SelectedIndex = -1
		End Sub

	Public Sub frmCustAccountGet_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.txtDateFrom.Value = DateTime.Parse(DateTime.Now.ToShortDateString())
		Me.txtDateTo.Value = DateTime.Parse(DateTime.Now.ToShortDateString())
		Me.LoadCenters()
	End Sub

	Public Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
			Try
				Dim checked As Boolean = Me.chkAll.Checked
				If checked Then
					Me.cmbCenter.Enabled = False
				Else
					Me.cmbCenter.Enabled = True
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetAccName(id As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Aname from accounts_index where Code=" + Convert.ToString(id), Me.conn)
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

		Public Sub ShowAccount()
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Me.dgvSrch.Rows.Clear()
				Me.txtTotDept.Text = ""
				Me.txtTotCredit.Text = ""
				Me.txtBalance1.Text = ""
				Me.txtBalance2.Text = ""
				Dim text As String = ""
				Dim text2 As String = ""
				Dim flag As Boolean = Not Me.chkAll.Checked
				Dim flag2 As Boolean
				If flag Then
					flag2 = Object.ReferenceEquals(RuntimeHelpers.GetObjectValue(Me.cmbCenter.SelectedValue), Nothing)
					If flag2 Then
						MessageBox.Show("اختر مركز تكلفة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbCenter.Focus()
						Return
					End If
					text = text + " and Restrictions_Sub.center=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.cmbCenter.SelectedValue))
					text2 = text2 + " and Accounts_Index.default_center=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.cmbCenter.SelectedValue))
				End If
				Dim text3 As String = ""
				flag2 = (MainClass.BranchNo <> -1)
				If flag2 Then
					text3 = String.Concat(New String() { "Restrictions.branch=", Convert.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Convert.ToString(MainClass.BranchNo), " and " })
				End If
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select sum(IValue) from Accounts_Index where nature=1 " + text2, Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag2 = (dataTable.Rows.Count > 0 AndAlso Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag2 Then
					num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select sum(IValue) from Accounts_Index where nature=2 " + text2, Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag2 = (dataTable.Rows.Count > 0 AndAlso Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag2 Then
					num4 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,costcenter where " + text3 + " type=11 and Restrictions_Sub.center=costcenter.id and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag2 = (dataTable2.Rows.Count > 0 AndAlso Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
				If flag2 Then
					num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("dept")))
					num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("credit")))
				End If
				sqlDataAdapter2 = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,costcenter where " + text3 + " type<>11 and Restrictions_Sub.center=costcenter.id and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date<@date1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
				sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				dataTable2 = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag2 = (dataTable2.Rows.Count > 0 AndAlso Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
				If flag2 Then
					num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("dept")))
					num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("credit")))
				End If
				flag2 = (num3 <> 0.0 OrElse num4 <> 0.0)
				If flag2 Then
					Me.dgvSrch.Rows.Add()
					Me.dgvSrch.Rows(0).Cells(0).Value = num3.ToString("N2")
					Me.dgvSrch.Rows(0).Cells(1).Value = num4.ToString("N2")
					Me.dgvSrch.Rows(0).Cells(5).Value = "رصيد سابق"
					num += num3
					num2 += num4
				End If
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Restrictions.id,Restrictions.date,Accounts_index.Code,Accounts_index.AName,Accounts_index.ParentCode,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit,Restrictions.notes from Restrictions,Restrictions_Sub,costcenter,Accounts_index where ", text3, " Restrictions_Sub.acc_no=Accounts_index.Code and Restrictions_Sub.center=costcenter.id and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id ", text, " group by Restrictions.id,Restrictions.date,Restrictions.notes,Restrictions_Sub.center,Accounts_index.ParentCode,Accounts_index.Code,Accounts_index.AName order by Accounts_index.ParentCode" }), Me.conn)
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				Dim num5 As Integer = -1
				Dim num6 As Integer = -1
				Dim num7 As Double = 0.0
				Dim num8 As Double = 0.0
				Dim num9 As Integer = 0
				Dim num10 As Integer = dataTable3.Rows.Count - 1
				Dim num11 As Integer = num9
				While True
					Dim num12 As Integer = num11
					Dim num13 As Integer = num10
					If num12 > num13 Then
						Exit While
					End If
					Me.dgvSrch.Rows.Add()
					flag2 = Operators.ConditionalCompareObjectNotEqual(dataTable3.Rows(num11)("parentcode"), num6, False)
					If flag2 Then
						Try
							flag = (num5 <> -1)
							If flag Then
								Me.dgvSrch.Rows(num5).Cells(0).Value = num7.ToString("N2")
								Me.dgvSrch.Rows(num5).Cells(1).Value = num8.ToString("N2")
								Me.dgvSrch.Rows(num5).DefaultCellStyle.BackColor = Color.Aqua
							End If
						Catch ex As Exception
						End Try
						num6 = Conversions.ToInteger(dataTable3.Rows(num11)("parentcode"))
						num5 = Me.dgvSrch.Rows.Count - 1
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable3.Rows(num11)("ParentCode"), " - "), Me.GetAccName(Conversions.ToInteger(dataTable3.Rows(num11)("ParentCode"))))
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = "------------"
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value = "------------"
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ---- ", dataTable3.Rows(num11)("ParentCode")), " - "), Me.GetAccName(Conversions.ToInteger(dataTable3.Rows(num11)("ParentCode")))), " ---- ")
						num7 = 0.0
						num8 = 0.0
						Me.dgvSrch.Rows.Add()
					End If
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("dept"))).ToString("N2")
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("credit"))).ToString("N2")
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable3.Rows(num11)("Code"), " - "), dataTable3.Rows(num11)("AName"))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("id"))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("date"))).ToShortDateString()
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("notes"))

						num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("dept")))
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("credit")))
						num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("dept")))
						num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num11)("credit")))

					flag2 = (num11 = dataTable3.Rows.Count - 1)
					If flag2 Then
						Try
							flag = (num5 <> -1)
							If flag Then
								Me.dgvSrch.Rows(num5).Cells(0).Value = num7.ToString("N2")
								Me.dgvSrch.Rows(num5).Cells(1).Value = num8.ToString("N2")
								Me.dgvSrch.Rows(num5).DefaultCellStyle.BackColor = Color.Aqua
							End If
						Catch ex2 As Exception
						End Try
					End If
					num11 += 1
				End While
				Me.txtTotDept.Text = "" + num.ToString("N2")
				Me.txtTotCredit.Text = "" + num2.ToString("N2")
				flag2 = (num > num2)
				If flag2 Then
					Me.txtBalance1.Text = "" + Math.Round(num - num2, 3).ToString("N2")
				Else
					flag2 = (num2 > num)
					If flag2 Then
						Me.txtBalance2.Text = "" + Math.Round(num2 - num, 3).ToString("N2")
					Else
						flag2 = (num = num2)
						If flag2 Then
							Me.txtBalance1.Text = "0"
							Me.txtBalance2.Text = "0"
						End If
					End If
				End If
				Me.dgvSrch.ClearSelection()
			Catch ex3 As Exception
			End Try
		End Sub

	Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me.ShowAccount()
	End Sub

	Public Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
		Try
			Dim frmRestrictions As New frmRestrictions()
			frmRestrictions.Show()
			frmRestrictions.Navigate("select * from Restrictions where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)))
			frmRestrictions.Activate()
		Catch ex As Exception
		End Try
		End Sub

  Public Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
		Try
			Dim Form1 As New Form1()
			Dim flag As Boolean = e.ColumnIndex = 5
			If flag Then
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select doc_no,type from Restrictions where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 1 OrElse Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 2)
				If flag Then
					Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
					Dim frmSalePurch As frmSalePurch = New frmSalePurch()
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 1)
					Dim value As Integer
					If flag Then
						frmSalePurch.InvProc = 1
						value = 1
					Else
						frmSalePurch.InvProc = 2
						value = 0
					End If
					frmSalePurch.Show()
					frmSalePurch.WindowState = FormWindowState.Maximized
					frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and is_buy=" + Conversions.ToString(value) + " and proc_type=1 and id=", dataTable.Rows(0)("doc_no"))))
					frmSalePurch.Activate()
				Else
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 3 OrElse Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 4)
					If flag Then
						Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
						Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 3)
						Dim value2 As Integer
						If flag Then
							frmSalePurch2.InvProc = 1
							value2 = 1
						Else
							frmSalePurch2.InvProc = 2
							value2 = 0
						End If
						frmSalePurch2.Show()
						frmSalePurch2.WindowState = FormWindowState.Maximized
						frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and is_buy=" + Conversions.ToString(value2) + " and proc_type=2 and id=", dataTable.Rows(0)("doc_no"))))
						frmSalePurch2.Activate()
					Else
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 5)
						If flag Then
							Dim frmSandQ As frmSandQ = New frmSandQ()
							frmSandQ.Show()
							frmSandQ.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQ where IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
							frmSandQ.Activate()
						Else
							flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 6)
							If flag Then
								Dim frmSandD As frmSandD = New frmSandD()
								frmSandD.Show()
								frmSandD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandD where IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
								frmSandD.Activate()
							Else
								flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 7)
								If flag Then
									Dim frmSandQD As frmSandQD = New frmSandQD()
									frmSandQD.Show()
									frmSandQD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQD where where IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
									frmSandQD.Activate()
								Else
									flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 8)
									If flag Then
										Dim frmSandSD As frmSandSD = New frmSandSD()
										frmSandSD.Show()
										frmSandSD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandSD where IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
										frmSandSD.Activate()
									Else
										flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("type"))) = 10)
										If flag Then
											Dim frmRestrictions As frmRestrictions = New frmRestrictions()
											frmRestrictions.Show()
											frmRestrictions.Navigate("select * from Restrictions where id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)))
											frmRestrictions.Activate()
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		Catch ex As Exception
		End Try
		End Sub

		Private Function GetEmpUserName(emp As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from users,Employees where users.emp=Employees.id and Employees.id=" + Convert.ToString(emp), Me.conn)
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
				dataTable.Columns.Add("dept")
				dataTable.Columns.Add("credit")
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("date")
				dataTable.Columns.Add("notes")
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
				Dim rptAccountBalanceCostCenter As rptAccountBalanceCostCenter = New rptAccountBalanceCostCenter()
				rptAccountBalanceCostCenter.SetDataSource(dataTable)
				Dim text As String = "الكل"
				flag = Not Me.chkAll.Checked
				If flag Then
					text = Me.cmbCenter.Text
				End If
				Dim textObject As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(1).ReportObjects("txtacc"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject4.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject5 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
				textObject5.Text = Me.txtTotDept.Text
				Dim textObject6 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
				textObject6.Text = Me.txtTotCredit.Text
				Dim textObject7 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
				textObject7.Text = Me.txtBalance1.Text
				Dim textObject8 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(4).ReportObjects("txtsum4"), TextObject)
				textObject8.Text = Me.txtBalance2.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptAccountBalanceCostCenter.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject9 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject10 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject11 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject12 As TextObject = CType(rptAccountBalanceCostCenter.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptAccountBalanceCostCenter
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptAccountBalanceCostCenter.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Public Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Public Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub
	End Class
