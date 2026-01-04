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
Public Partial Class frmMezanMorg3a
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _ParentCode As Integer

		Public _Type As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMezanMorg3a_Load
			frmMezanMorg3a.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._ParentCode = -1
			Me._Type = 1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmMezanMorg3a.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmMezanMorg3a.__ENCList.Count = frmMezanMorg3a.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmMezanMorg3a.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmMezanMorg3a.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmMezanMorg3a.__ENCList(num) = frmMezanMorg3a.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmMezanMorg3a.__ENCList.RemoveRange(num, frmMezanMorg3a.__ENCList.Count - num)
					frmMezanMorg3a.__ENCList.Capacity = frmMezanMorg3a.__ENCList.Count
				End If
				frmMezanMorg3a.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

		Private Function GetAccName(Code As String) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Code, Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Return ""
		End Function

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
				dataTable.Columns.Add("opendept")
				dataTable.Columns.Add("opencredit")
				dataTable.Columns.Add("parent")
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing
				If flag Then
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Restrictions.branch=", Me.cmbBranches.SelectedValue), " and Restrictions_Sub.branch="), Me.cmbBranches.SelectedValue), " and "))
				End If
				Dim num5 As Decimal = 0D
				Dim num6 As Decimal = 0D
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.type=11 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (Me._Type = 1)
				Dim flag3 As Boolean
				If flag Then
					Dim num7 As Integer = 0
					Dim num8 As Integer = dataTable2.Rows.Count - 1
					Dim num9 As Integer = num7
					While True
						Dim num10 As Integer = num9
						Dim num11 As Integer = num8
						If num10 > num11 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num9)("acc_no"))))))
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						Dim values As Object() = New Object() { Me._ParentCode, RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)), 0, 0, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num9)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num9)("credit")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num9)("parentcode")) }
						dataTable.Rows.Add(values)
						num9 += 1
					End While
				Else
					Dim num12 As Integer = 0
					Dim num13 As Integer = dataTable2.Rows.Count - 1
					Dim num14 As Integer = num12
					While True
						Dim num15 As Integer = num14
						Dim num11 As Integer = num13
						If num15 > num11 Then
							Exit While
						End If
						Dim values2 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num14)("acc_no")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num14)("AName")), 0, 0, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num14)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num14)("credit")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num14)("parentcode")) }
						dataTable.Rows.Add(values2)
						num14 += 1
					End While
				End If
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.type<>11 and Restrictions.date<@date1 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode", Me.conn)
				sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable4)
				flag = (Me._Type = 1)
				If flag Then
					Dim num16 As Integer = 0
					Dim num17 As Integer = dataTable4.Rows.Count - 1
					Dim num18 As Integer = num16
					While True
						Dim num19 As Integer = num18
						Dim num11 As Integer = num17
						If num19 > num11 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num18)("acc_no"))))))
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable5 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable5)
						Dim values3 As Object() = New Object() { Me._ParentCode, RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)), 0, 0, RuntimeHelpers.GetObjectValue(dataTable4.Rows(num18)("dept")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num18)("credit")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num18)("parentcode")) }
						dataTable.Rows.Add(values3)
						num18 += 1
					End While
				Else
					Dim num20 As Integer = 0
					Dim num21 As Integer = dataTable4.Rows.Count - 1
					Dim num22 As Integer = num20
					While True
						Dim num23 As Integer = num22
						Dim num11 As Integer = num21
						If num23 > num11 Then
							Exit While
						End If
						Dim values4 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable4.Rows(num22)("acc_no")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num22)("AName")), 0, 0, RuntimeHelpers.GetObjectValue(dataTable4.Rows(num22)("dept")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num22)("credit")), RuntimeHelpers.GetObjectValue(dataTable4.Rows(num22)("parentcode")) }
						dataTable.Rows.Add(values4)
						num22 += 1
					End While
				End If
				Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter("select Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + str + " Restrictions.IS_Deleted=0 and Restrictions.type<>11 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=Accounts_Index.Code  group by Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.parentcode", Me.conn)
				sqlDataAdapter5.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				sqlDataAdapter5.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable6 As DataTable = New DataTable()
				sqlDataAdapter5.Fill(dataTable6)
				flag = (Me._Type = 1)
				Dim flag2 As Boolean
				If flag Then
					Dim num24 As Integer = 0
					Dim num25 As Integer = dataTable6.Rows.Count - 1
					Dim num26 As Integer = num24
					While True
						Dim num27 As Integer = num26
						Dim num11 As Integer = num25
						If num27 > num11 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable6.Rows(num26)("acc_no"))))))
						Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter("select AName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable7 As DataTable = New DataTable()
						sqlDataAdapter6.Fill(dataTable7)
						Dim values5 As Object() = New Object() { Me._ParentCode, RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)(0)), RuntimeHelpers.GetObjectValue(dataTable6.Rows(num26)("dept")), RuntimeHelpers.GetObjectValue(dataTable6.Rows(num26)("credit")), 0, 0, RuntimeHelpers.GetObjectValue(dataTable6.Rows(num26)("parentcode")) }
						dataTable.Rows.Add(values5)
						num26 += 1
					End While
					Dim num28 As Integer = dataTable.Rows.Count - 1
					Dim num29 As Integer = 0
					Dim num30 As Integer = num28
					Dim num31 As Integer = num29
					While True
						Dim num32 As Integer = num31
						Dim num11 As Integer = num30
						If num32 > num11 Then
							Exit While
						End If
						Dim num33 As Integer = num31 + 1
						Dim num34 As Integer = num28
						Dim num35 As Integer = num33
						While True
							Dim num36 As Integer = num35
							num11 = num34
							If num36 > num11 Then
								Exit While
							End If
							flag = (num35 <= num28)
							If flag Then
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num31)(0), dataTable.Rows(num35)(0), False)
								If flag2 Then

										dataTable.Rows(num31)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num31)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num35)(2)))
										dataTable.Rows(num31)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num31)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num35)(3)))
										dataTable.Rows(num31)(4) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num31)(4))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num35)(4)))
										dataTable.Rows(num31)(5) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num31)(5))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num35)(5)))
										dataTable.Rows.RemoveAt(num35)

									num35 -= 1
									num28 -= 1
								End If
							End If
							num35 += 1
						End While
						num31 += 1
					End While
				Else
					Dim num37 As Integer = 0
					Dim num38 As Integer = dataTable6.Rows.Count - 1
					Dim num39 As Integer = num37
					While True
						Dim num40 As Integer = num39
						Dim num11 As Integer = num38
						If num40 > num11 Then
							Exit While
						End If
						Dim values6 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable6.Rows(num39)("acc_no")), RuntimeHelpers.GetObjectValue(dataTable6.Rows(num39)("AName")), RuntimeHelpers.GetObjectValue(dataTable6.Rows(num39)("dept")), RuntimeHelpers.GetObjectValue(dataTable6.Rows(num39)("credit")), 0, 0, RuntimeHelpers.GetObjectValue(dataTable6.Rows(num39)("parentcode")) }
						dataTable.Rows.Add(values6)
						num39 += 1
					End While
					Dim num41 As Integer = dataTable.Rows.Count - 1
					Dim num42 As Integer = 0
					Dim num43 As Integer = num41
					Dim num44 As Integer = num42
					While True
						Dim num45 As Integer = num44
						Dim num11 As Integer = num43
						If num45 > num11 Then
							Exit While
						End If
						Dim num46 As Integer = num44 + 1
						Dim num47 As Integer = num41
						Dim num48 As Integer = num46
						While True
							Dim num49 As Integer = num48
							num11 = num47
							If num49 > num11 Then
								Exit While
							End If
							flag2 = (num48 <= num41)
							If flag2 Then
								flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num44)(0), dataTable.Rows(num48)(0), False)
								If flag Then

										dataTable.Rows(num44)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num44)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num48)(2)))
										dataTable.Rows(num44)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num44)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num48)(3)))
										dataTable.Rows(num44)(4) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num44)(4))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num48)(4)))
										dataTable.Rows(num44)(5) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num44)(5))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num48)(5)))
										dataTable.Rows.RemoveAt(num48)

									num48 -= 1
									num41 -= 1
								End If
							End If
							num48 += 1
						End While
						num44 += 1
					End While
				End If
				flag2 = (Me._Type = 2)
				If flag2 Then
					Dim dataView As DataView = dataTable.AsDataView()
					dataView.Sort = "parent asc"
					dataTable = dataView.ToTable()
				End If
				Dim right As String = ""
				Dim num50 As Integer = -1
				Dim num51 As Double = 0.0
				Dim num52 As Double = 0.0
				Dim num53 As Double = 0.0
				Dim num54 As Double = 0.0
				Dim num55 As Double = 0.0
				Dim num56 As Double = 0.0
				Dim num57 As Double = 0.0
				Dim num58 As Integer = 0
				Dim num59 As Integer = dataTable.Rows.Count - 1
				Dim num60 As Integer = num58
				While True
					Dim num61 As Integer = num60
					Dim num11 As Integer = num59
					If num61 > num11 Then
						Exit While
					End If
					flag2 = (Me._Type = 2 And Me.chkShowParent.Checked)
					If flag2 Then
						flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num60)("parent"), right, False)
						If flag Then
							flag3 = (num60 <> 0 And num50 <> -1)
							If flag3 Then
								Me.dgvSrch.Rows(num50).Cells(2).Value = String.Format("{0:0.#,##.##}", num51)
								Me.dgvSrch.Rows(num50).Cells(3).Value = String.Format("{0:0.#,##.##}", num52)
								Me.dgvSrch.Rows(num50).Cells(4).Value = String.Format("{0:0.#,##.##}", num53)
								Me.dgvSrch.Rows(num50).Cells(5).Value = String.Format("{0:0.#,##.##}", num54)
								Me.dgvSrch.Rows(num50).Cells(6).Value = String.Format("{0:0.#,##.##}", num55)
								Me.dgvSrch.Rows(num50).Cells(7).Value = String.Format("{0:0.#,##.##}", num56)
								Me.dgvSrch.Rows(num50).Cells(8).Value = String.Format("{0:0.#,##.##}", num57)
							End If
							num51 = 0.0
							num52 = 0.0
							num53 = 0.0
							num54 = 0.0
							num55 = 0.0
							num56 = 0.0
							num57 = 0.0
							Me.dgvSrch.Rows.Add()
							Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)("parent"))
							Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Me.GetAccName(Conversions.ToString(dataTable.Rows(num60)("parent")))
							Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colisparent").Value = "1"
							Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Aqua
							num50 = Me.dgvSrch.Rows.Count - 1
						End If
						right = Conversions.ToString(dataTable.Rows(num60)("parent"))
					End If
					Me.dgvSrch.Rows.Add()
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(0))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(1))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(4))))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(5))))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(2))))
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(3))))
					flag3 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(4))) >= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(5)))
					If flag3 Then
						' The following expression was wrapped in a unchecked-expression
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(6).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(4))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(3))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(5))))
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(7).Value = 0
					Else
						' The following expression was wrapped in a unchecked-expression
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(7).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(5))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(2))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num60)(4))))
						Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(6).Value = 0
					End If
					Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(8).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(6).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(7).Value))

						' The following expression was wrapped in a checked-expression
						num5 = New Decimal(Convert.ToDouble(num5) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value)))
						num6 = New Decimal(Convert.ToDouble(num6) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value)))
						num += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value))
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value))
						num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(6).Value))
						num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(7).Value))
						flag3 = (Me._Type = 2)
						If flag3 Then
							' The following expression was wrapped in a checked-expression
							num51 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value))
							num52 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value))
							num53 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value))
							num54 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value))
							num55 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(6).Value))
							num56 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(7).Value))
							num57 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(8).Value))
						End If

					num60 += 1
				End While
				Me.txtTotOpenDebt.Text = String.Format("{0:0.#,##.##}", num5)
				Me.txtTotOpenCredit.Text = String.Format("{0:0.#,##.##}", num6)
				Me.txtTotDept.Text = String.Format("{0:0.#,##.##}", num)
				Me.txtTotCredit.Text = String.Format("{0:0.#,##.##}", num2)
				Me.txtDeptDiff.Text = String.Format("{0:0.#,##.##}", num3)
				Me.txtCreditDiff.Text = String.Format("{0:0.#,##.##}", num4)
				Me.txtDiff.Text = String.Format("{0:0.#,##.##}", Math.Round(num3 - num4, 2))
				flag3 = (Math.Round(num3) = Math.Round(num4))
				If flag3 Then
					Me.txtIsBalanced.Text = "ميزان المراجعة متوازن"
				Else
					Me.txtIsBalanced.Text = "ميزان المراجعة غير متوازن"
				End If
				Me.dgvSrch.ClearSelection()
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
				Me.dgvSrch.Columns(9).Visible = False
			Else
				Me.chkShowParent.Visible = True
			End If
		End Sub

  Private Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 9
				If flag Then
					Dim flag2 As Boolean = Me._Type = 2
					If flag2 Then
						Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvSrch.Rows(e.RowIndex).Cells("colisparent").Value, "1", False)
					If flag3 Then
						Interaction.MsgBox("اختر حساب فرعي فقط لكشف حسابه", MsgBoxStyle.OkOnly, Nothing)
					Else
						Dim frmAccountBalance As New frmAccountBalance()
						frmAccountBalance.Show()
							frmAccountBalance.txtCode.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value))
							frmAccountBalance.txtDateFrom.Value = Me.txtDateFrom.Value
							frmAccountBalance.txtDateTo.Value = Me.txtDateTo.Value
							frmAccountBalance.ShowAccount()
							frmAccountBalance.Activate()
						End If
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
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("DataColumn11")
				dataTable.Columns.Add("dept1")
				dataTable.Columns.Add("credit1")
				dataTable.Columns.Add("dept2")
				dataTable.Columns.Add("credit2")
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(8).Value), Operators.ConcatenateObject("", Me.dgvSrch.Rows(num3).Cells("colisparent").Value) })
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
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sumopendept" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtTotOpenDebt.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sumopencredit" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.txtTotOpenCredit.Text
				Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum1" }, Nothing, Nothing, Nothing), TextObject)
				textObject7.Text = Me.txtTotDept.Text
				Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum2" }, Nothing, Nothing, Nothing), TextObject)
				textObject8.Text = Me.txtTotCredit.Text
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum3" }, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.txtDeptDiff.Text
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum4" }, Nothing, Nothing, Nothing), TextObject)
				textObject10.Text = Me.txtCreditDiff.Text
				Try
					Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sumnet" }, Nothing, Nothing, Nothing), TextObject)
					textObject11.Text = Me.txtDiff.Text
				Catch ex As Exception
				End Try
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
					Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
					textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
					textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
					textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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
					Catch ex2 As Exception
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
	End Class
