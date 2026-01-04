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
Public Partial Class frmMezanMorg3a_1
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _ParentCode As Integer

		Public _Type As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMezanMorg3a_Load
			frmMezanMorg3a_1.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._ParentCode = -1
			Me._Type = 1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmMezanMorg3a_1.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmMezanMorg3a_1.__ENCList.Count = frmMezanMorg3a_1.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmMezanMorg3a_1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmMezanMorg3a_1.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmMezanMorg3a_1.__ENCList(num) = frmMezanMorg3a_1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmMezanMorg3a_1.__ENCList.RemoveRange(num, frmMezanMorg3a_1.__ENCList.Count - num)
					frmMezanMorg3a_1.__ENCList.Capacity = frmMezanMorg3a_1.__ENCList.Count
				End If
				frmMezanMorg3a_1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
				Dim num As Decimal = 0D
				Dim num2 As Decimal = 0D
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Dim num5 As Double = 0.0
				Dim num6 As Double = 0.0
				Dim num7 As Double = 0.0
				Dim num8 As Double = 0.0
				Me.dgvSrch.Rows.Clear()
				Me._ParentCode = -1
				Me.txtSum1.Text = ""
				Me.txtSum2.Text = ""
				Me.txtSum3.Text = ""
				Me.txtSum4.Text = ""
				Me.txtSum5.Text = ""
				Me.txtSum6.Text = ""
				Me.txtSum7.Text = ""
				Me.txtSum8.Text = ""
				Me.txtIsBalanced.Text = ""
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("code")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("dept")
				dataTable.Columns.Add("credit")
				dataTable.Columns.Add("opendept")
				dataTable.Columns.Add("opencredit")
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing
				If flag Then
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Restrictions.branch=", Me.cmbBranches.SelectedValue), " and Restrictions_Sub.branch="), Me.cmbBranches.SelectedValue), " and "))
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.type<>11 and Restrictions.date<@date1 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (Me._Type = 1)
				If flag Then
					Dim num9 As Integer = 0
					Dim num10 As Integer = dataTable2.Rows.Count - 1
					Dim num11 As Integer = num9
					While True
						Dim num12 As Integer = num11
						Dim num13 As Integer = num10
						If num12 > num13 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num11)("acc_no"))))))
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						Dim values As Object() = New Object() { Me._ParentCode, RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)), 0, 0, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num11)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num11)("credit")) }
						dataTable.Rows.Add(values)
						num11 += 1
					End While
				Else
					Dim num14 As Integer = 0
					Dim num15 As Integer = dataTable2.Rows.Count - 1
					Dim num16 As Integer = num14
					While True
						Dim num17 As Integer = num16
						Dim num13 As Integer = num15
						If num17 > num13 Then
							Exit While
						End If
						Dim values2 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)("acc_no")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)("AName")), 0, 0, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)("credit")) }
						dataTable.Rows.Add(values2)
						num16 += 1
					End While
				End If
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName", Me.conn)
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dateTime As DateTime = Convert.ToDateTime(Me.txtDateTo.Value.AddHours(24.0).ToShortDateString())
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable4)
				flag = (Me._Type = 1)
				Dim flag2 As Boolean
				If flag Then
					Dim num18 As Integer = 0
					Dim num19 As Integer = dataTable4.Rows.Count - 1
					Dim num20 As Integer = num18
					While True
						Dim num21 As Integer = num20
						Dim num13 As Integer = num19
						If num21 > num13 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num20)("acc_no"))))))
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable5 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable5)
						Dim values3 As Object() = New Object() { Me._ParentCode, RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num20)("dept")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num20)("credit")), 0, 0 }
						dataTable.Rows.Add(values3)
						num20 += 1
					End While
					Dim num22 As Integer = dataTable.Rows.Count - 1
					Dim num23 As Integer = 0
					Dim num24 As Integer = num22
					Dim num25 As Integer = num23
					While True
						Dim num26 As Integer = num25
						Dim num13 As Integer = num24
						If num26 > num13 Then
							Exit While
						End If
						Dim num27 As Integer = num25 + 1
						Dim num28 As Integer = num22
						Dim num29 As Integer = num27
						While True
							Dim num30 As Integer = num29
							num13 = num28
							If num30 > num13 Then
								Exit While
							End If
							flag = (num29 <= num22)
							If flag Then
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num25)(0), dataTable.Rows(num29)(0), False)
								If flag2 Then

										dataTable.Rows(num25)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(2)))
										dataTable.Rows(num25)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(3)))
										dataTable.Rows(num25)(4) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(4))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(4)))
										dataTable.Rows(num25)(5) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(5))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(5)))
										dataTable.Rows.RemoveAt(num29)

									num29 -= 1
									num22 -= 1
								End If
							End If
							num29 += 1
						End While
						num25 += 1
					End While
				Else
					Dim num31 As Integer = 0
					Dim num32 As Integer = dataTable4.Rows.Count - 1
					Dim num33 As Integer = num31
					While True
						Dim num34 As Integer = num33
						Dim num13 As Integer = num32
						If num34 > num13 Then
							Exit While
						End If
						Dim values4 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)("acc_no")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)("AName")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)("dept")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)("credit")), 0, 0 }
						dataTable.Rows.Add(values4)
						num33 += 1
					End While
					Dim num35 As Integer = dataTable.Rows.Count - 1
					Dim num36 As Integer = 0
					Dim num37 As Integer = num35
					Dim num38 As Integer = num36
					While True
						Dim num39 As Integer = num38
						Dim num13 As Integer = num37
						If num39 > num13 Then
							Exit While
						End If
						Dim num40 As Integer = num38 + 1
						Dim num41 As Integer = num35
						Dim num42 As Integer = num40
						While True
							Dim num43 As Integer = num42
							num13 = num41
							If num43 > num13 Then
								Exit While
							End If
							flag2 = (num42 <= num35)
							If flag2 Then
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num38)(0), dataTable.Rows(num42)(0), False)
								If flag Then

										dataTable.Rows(num38)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num38)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num42)(2)))
										dataTable.Rows(num38)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num38)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num42)(3)))
										dataTable.Rows(num38)(4) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num38)(4))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num42)(4)))
										dataTable.Rows(num38)(5) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num38)(5))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num42)(5)))
										dataTable.Rows.RemoveAt(num42)

									num42 -= 1
									num35 -= 1
								End If
							End If
							num42 += 1
						End While
						num38 += 1
					End While
				End If
				Dim num44 As Integer = 0
				Dim num45 As Integer = dataTable.Rows.Count - 1
				Dim num46 As Integer = num44
				While True
					Dim num47 As Integer = num46
					Dim num13 As Integer = num45
					If num47 > num13 Then
						Exit While
					End If
					Me.dgvSrch.Rows.Add()
					Me.dgvSrch.Rows(num46).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(0))
					Me.dgvSrch.Rows(num46).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(1))
					Me.dgvSrch.Rows(num46).Cells(2).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))))
					Me.dgvSrch.Rows(num46).Cells(3).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))))
					Me.dgvSrch.Rows(num46).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))))
					Me.dgvSrch.Rows(num46).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))))

						Me.dgvSrch.Rows(num46).Cells(6).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) + Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))))
						Me.dgvSrch.Rows(num46).Cells(7).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) + Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))))
						flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))) >= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))))
						If flag2 Then
							Me.dgvSrch.Rows(num46).Cells(8).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))))
							Me.dgvSrch.Rows(num46).Cells(9).Value = 0
							num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5)))
						Else
							Me.dgvSrch.Rows(num46).Cells(9).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4))))
							Me.dgvSrch.Rows(num46).Cells(8).Value = 0
							num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(5))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(2))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num46)(4)))
						End If
						num = New Decimal(Convert.ToDouble(num) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(2).Value)))
						num2 = New Decimal(Convert.ToDouble(num2) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(3).Value)))
						num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(4).Value))
						num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(5).Value))
						num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(6).Value))
						num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num46).Cells(7).Value))

					num46 += 1
				End While
				Me.txtSum1.Text = String.Format("{0:0.#,##.##}", num)
				Me.txtSum2.Text = String.Format("{0:0.#,##.##}", num2)
				Me.txtSum3.Text = String.Format("{0:0.#,##.##}", num3)
				Me.txtSum4.Text = String.Format("{0:0.#,##.##}", num4)
				Me.txtSum5.Text = String.Format("{0:0.#,##.##}", num5)
				Me.txtSum6.Text = String.Format("{0:0.#,##.##}", num6)
				Me.txtSum7.Text = String.Format("{0:0.#,##.##}", num7)
				Me.txtSum8.Text = String.Format("{0:0.#,##.##}", num8)
				flag2 = (Math.Round(num5) = Math.Round(num6))
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
			Dim flag As Boolean = Me._Type = 1
			If flag Then
				Me.dgvSrch.Columns(10).Visible = False
			End If
		End Sub

  Private Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 10
				If flag Then
					Dim flag2 As Boolean = Me._Type = 2
				If flag2 Then
					Dim frmAccountBalance As New frmAccountBalance()
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
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("DataColumn11")
				dataTable.Columns.Add("DataColumn12")
				dataTable.Columns.Add("DataColumn13")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvSrch.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(8).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(9).Value) })
					num3 += 1
				End While
				Dim rptMezanMorag3a_ As rptMezanMorag3a_2 = New rptMezanMorag3a_2()
				rptMezanMorag3a_.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
				textObject.Text = Me.Text
				Dim textObject2 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
				textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
				textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum1"), TextObject)
				textObject4.Text = Me.txtSum1.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum2"), TextObject)
				textObject4.Text = Me.txtSum2.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum3"), TextObject)
				textObject4.Text = Me.txtSum3.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum4"), TextObject)
				textObject4.Text = Me.txtSum4.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum5"), TextObject)
				textObject4.Text = Me.txtSum5.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum6"), TextObject)
				textObject4.Text = Me.txtSum6.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum7"), TextObject)
				textObject4.Text = Me.txtSum7.Text
				textObject4 = CType(rptMezanMorag3a_.ReportDefinition.Sections(4).ReportObjects("sum8"), TextObject)
				textObject4.Text = Me.txtSum8.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptMezanMorag3a_.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject8 As TextObject = CType(rptMezanMorag3a_.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
					textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptMezanMorag3a_
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptMezanMorag3a_.PrintToPrinter(1, False, 1, currentPageNumber)
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

  Private Sub chkAllBranches_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllBranches.CheckedChanged
			Dim checked As Boolean = Me.chkAllBranches.Checked
			If checked Then
				Me.cmbBranches.Enabled = False
			Else
				Me.cmbBranches.Enabled = True
			End If
		End Sub
	End Class
