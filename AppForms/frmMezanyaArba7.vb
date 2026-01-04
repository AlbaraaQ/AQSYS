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
	Public Partial Class frmMezanyaArba7
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _ParentCode As Integer

		Public _Type As Integer

		Public _FormType As Integer

		Private _stoerclosepricetype As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMezanyaArba7_Load
			frmMezanyaArba7.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._ParentCode = -1
			Me._Type = 1
			Me._FormType = 1
			Me._stoerclosepricetype = 1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmMezanyaArba7.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmMezanyaArba7.__ENCList.Count = frmMezanyaArba7.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmMezanyaArba7.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmMezanyaArba7.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmMezanyaArba7.__ENCList(num) = frmMezanyaArba7.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmMezanyaArba7.__ENCList.RemoveRange(num, frmMezanyaArba7.__ENCList.Count - num)
					frmMezanyaArba7.__ENCList.Capacity = frmMezanyaArba7.__ENCList.Count
				End If
				frmMezanyaArba7.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub dgvSrch_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellContentClick
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

		Private Sub CalcStock()
			' The following expression was wrapped in a checked-statement
			Try
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("currency")
				dataTable.Columns.Add("sum")
				dataTable.Columns.Add("type")
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1
				If flag Then
					str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				Dim dateTime As DateTime = Conversions.ToDate(Me.txtDateTo.Value.AddHours(24.0).ToShortDateString())
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable2.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1 })
					num3 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter("select item,sum(difftot) from tsweya,tsweya_sub where tsweya.id=tsweya_sub.tsweya_id and date<=@date2 and IS_Deleted=0 group by item", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num6 As Integer = 0
				Dim num7 As Integer = dataTable2.Rows.Count - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					Dim num5 As Integer = num7
					If num9 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 1 })
					num8 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num10 As Integer = 0
				Dim num11 As Integer = dataTable2.Rows.Count - 1
				Dim num12 As Integer = num10
				While True
					Dim num13 As Integer = num12
					Dim num5 As Integer = num11
					If num13 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 1 })
					num12 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num14 As Integer = 0
				Dim num15 As Integer = dataTable2.Rows.Count - 1
				Dim num16 As Integer = num14
				While True
					Dim num17 As Integer = num16
					Dim num5 As Integer = num15
					If num17 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 2 })
					num16 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num18 As Integer = 0
				Dim num19 As Integer = dataTable2.Rows.Count - 1
				Dim num20 As Integer = num18
				While True
					Dim num21 As Integer = num20
					Dim num5 As Integer = num19
					If num21 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 2 })
					num20 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num22 As Integer = 0
				Dim num23 As Integer = dataTable2.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num5 As Integer = num23
					If num25 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 1 })
					num24 += 1
				End While
				Dim num26 As Integer = dataTable.Rows.Count - 1
				Dim num27 As Integer = 0
				Dim num28 As Integer = num26
				Dim num29 As Integer = num27
				Dim flag3 As Boolean
				While True
					Dim num30 As Integer = num29
					Dim num5 As Integer = num28
					If num30 > num5 Then
						Exit While
					End If
					flag = (num29 <= num26)
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num29)(2), 2, False)
						If flag2 Then
							' The following expression was wrapped in a unchecked-expression
							dataTable.Rows(num29)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1)))
						End If
					End If
					Dim num31 As Integer = num29 + 1
					Dim num32 As Integer = num26
					Dim num33 As Integer = num31
					While True
						Dim num34 As Integer = num33
						num5 = num32
						If num34 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = num33 <= num26
						If flag2 Then
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num29)(0), dataTable.Rows(num33)(0), False)
							If flag Then
								flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num33)(2), 2, False)

									If flag3 Then
										dataTable.Rows(num33)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1)))
									End If
									dataTable.Rows(num29)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1)))
									dataTable.Rows.RemoveAt(num33)

								num33 -= 1
								num26 -= 1
							End If
						End If
						num33 += 1
					End While
					num29 += 1
				End While
				Dim num35 As Double = 0.0
				Dim num36 As Integer = 0
				Dim num37 As Integer = dataTable.Rows.Count - 1
				Dim num38 As Integer = num36
				While True
					Dim num39 As Integer = num38
					Dim num5 As Integer = num37
					If num39 > num5 Then
						Exit While
					End If
					Dim num40 As Double = 0.0
					Dim num41 As Double = 0.0

						Try
							flag3 = (Me._stoerclosepricetype = 1)
							If flag3 Then
								sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num38)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0")), Me.conn)
								sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
								dataTable2 = New DataTable()
								sqlDataAdapter.Fill(dataTable2)
								flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
								If flag3 Then
									num40 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))
									num41 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
								End If
							Else
								flag3 = (Me._stoerclosepricetype = 3)
								If flag3 Then
									sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 (val),(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num38)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 order by inv.date desc")), Me.conn)
									sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
									dataTable2 = New DataTable()
									sqlDataAdapter.Fill(dataTable2)
									flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
									If flag3 Then
										num40 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))
										num41 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
									End If
								End If
							End If
						Catch ex As Exception
						End Try
						Try
							flag3 = (num41 <> 0.0)
							Dim num42 As Double
							If flag3 Then
								num42 = num40 / num41
								num42 = Math.Floor(num42 * 100000000.0)
								num42 /= 100000000.0
							Else
								Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from currencies where id=", dataTable.Rows(num38)(0))), Me.conn)
								Dim dataTable3 As DataTable = New DataTable()
								sqlDataAdapter2.Fill(dataTable3)
								num42 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
							End If
							num35 += Math.Round(num42 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num38)(1))), 3)
						Catch ex2 As Exception
						End Try

					num38 += 1
				End While
				num35 = Math.Round(num35, 3)
				flag3 = (Me._FormType = 1)
				If flag3 Then
					Me.txtStockVal.Text = "" + Conversions.ToString(num35)
					Me.txtStockVal1.Text = "0"
				Else
					Me.txtStockVal1.Text = "" + Conversions.ToString(num35)
					Me.txtStockVal.Text = "0"
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub CalcStockFirstVal()
			' The following expression was wrapped in a checked-statement
			Try
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("currency")
				dataTable.Columns.Add("sum")
				dataTable.Columns.Add("type")
				Dim str As String = ""
				Dim flag As Boolean = MainClass.BranchNo <> -1
				If flag Then
					str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + " inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable2.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1 })
					num3 += 1
				End While
				Dim num6 As Integer = dataTable.Rows.Count - 1
				Dim num7 As Integer = 0
				Dim num8 As Integer = num6
				Dim num9 As Integer = num7
				Dim flag3 As Boolean
				While True
					Dim num10 As Integer = num9
					Dim num5 As Integer = num8
					If num10 > num5 Then
						Exit While
					End If
					flag = (num9 <= num6)
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num9)(2), 2, False)
						If flag2 Then
							' The following expression was wrapped in a unchecked-expression
							dataTable.Rows(num9)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num9)(1)))
						End If
					End If
					Dim num11 As Integer = num9 + 1
					Dim num12 As Integer = num6
					Dim num13 As Integer = num11
					While True
						Dim num14 As Integer = num13
						num5 = num12
						If num14 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = num13 <= num6
						If flag2 Then
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num9)(0), dataTable.Rows(num13)(0), False)
							If flag Then
								flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num13)(2), 2, False)

									If flag3 Then
										dataTable.Rows(num13)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num13)(1)))
									End If
									dataTable.Rows(num9)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num9)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num13)(1)))
									dataTable.Rows.RemoveAt(num13)

								num13 -= 1
								num6 -= 1
							End If
						End If
						num13 += 1
					End While
					num9 += 1
				End While
				Dim num15 As Double = 0.0
				Dim num16 As Integer = 0
				Dim num17 As Integer = dataTable.Rows.Count - 1
				Dim num18 As Integer = num16
				While True
					Dim num19 As Integer = num18
					Dim num5 As Integer = num17
					If num19 > num5 Then
						Exit While
					End If
					Dim num20 As Double = 0.0
					Dim num21 As Double = 0.0
					sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num18)(0)), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and date<=@date2 and IS_Deleted=0")), Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
					dataTable2 = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)

						If flag3 Then
							num20 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))
							num21 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
						End If
						Try
							Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.AddObject("select is_deleted,sale_price,purch_price from currencies where id=", dataTable.Rows(num18)(0))), Me.conn)
							Dim dataTable3 As DataTable = New DataTable()
							sqlDataAdapter2.Fill(dataTable3)
							flag3 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("is_deleted")))
							If flag3 Then
								Dim flag2 As Boolean = num21 <> 0.0
								Dim num22 As Double
								If flag2 Then
									num22 = num20 / num21
									num22 = Math.Floor(num22 * 100000000.0)
									num22 /= 100000000.0
								Else
									num22 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("purch_price")))
								End If
								num15 += Math.Round(num22 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num18)(1))), 3)
							End If
						Catch ex As Exception
						End Try

					num18 += 1
				End While
				num15 = Math.Round(num15, 3)
				flag3 = (Me._FormType = 1)
				If flag3 Then
					Me.txtFirstVal.Text = "" + Conversions.ToString(num15)
					Me.txtFirstVal1.Text = "0"
				Else
					Me.txtFirstVal1.Text = "" + Conversions.ToString(num15)
					Me.txtFirstVal.Text = "0"
				End If
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Me.dgvSrch.Rows.Clear()
				Me._ParentCode = -1
				Me.txtProfit1.Text = ""
				Me.txtProfit2.Text = ""
				Me.txtStockVal1.Text = ""
				Me.txtStockVal.Text = ""
				Me.txtCreditDiff.Text = ""
				Me.txtDeptDiff.Text = ""
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("code")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("dept")
				dataTable.Columns.Add("credit")
				Dim value As Integer = 2
				Dim flag As Boolean = Me._FormType = 2
				If flag Then
					value = 1
				End If
				Dim text As String = ""
				flag = (MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Restrictions.branch=", Me.cmbBranches.SelectedValue), " and Restrictions_Sub.branch="), Me.cmbBranches.SelectedValue), " and "))
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.EName,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where ", text, " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions.branch=Restrictions_Sub.branch and Restrictions_Sub.acc_no=Accounts_Index.Code and Accounts_Index.FinalAcc=", Conversions.ToString(value), " group by Restrictions_Sub.acc_no,Accounts_Index.AName,Accounts_Index.EName" }), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (Me._Type = 1)
				Dim flag2 As Boolean
				If flag Then
					Dim num3 As Integer = 0
					Dim num4 As Integer = dataTable2.Rows.Count - 1
					Dim num5 As Integer = num3
					While True
						Dim num6 As Integer = num5
						Dim num7 As Integer = num4
						If num6 > num7 Then
							Exit While
						End If
						Me._ParentCode = -1
						Me.GetParent(CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("acc_no"))))))
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select AName,EName from Accounts_Index where Code=" + Conversions.ToString(Me._ParentCode), Me.conn)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						Dim text2 As String = Conversions.ToString(dataTable3.Rows(0)("AName"))
						flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag Then
							text2 = Conversions.ToString(dataTable3.Rows(0)("EName"))
						End If
						Dim values As Object() = New Object() { Me._ParentCode, text2, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num5)("credit")) }
						dataTable.Rows.Add(values)
						num5 += 1
					End While
					Dim num8 As Integer = dataTable.Rows.Count - 1
					Dim num9 As Integer = 0
					Dim num10 As Integer = num8
					Dim num11 As Integer = num9
					While True
						Dim num12 As Integer = num11
						Dim num7 As Integer = num10
						If num12 > num7 Then
							Exit While
						End If
						Dim num13 As Integer = num11 + 1
						Dim num14 As Integer = num8
						Dim num15 As Integer = num13
						While True
							Dim num16 As Integer = num15
							num7 = num14
							If num16 > num7 Then
								Exit While
							End If
							flag = (num15 <= num8)
							If flag Then
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num11)(0), dataTable.Rows(num15)(0), False)
								If flag2 Then

										dataTable.Rows(num11)(2) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num11)(2))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num15)(2)))
										dataTable.Rows(num11)(3) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num11)(3))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num15)(3)))
										dataTable.Rows.RemoveAt(num15)

									num15 -= 1
									num8 -= 1
								End If
							End If
							num15 += 1
						End While
						num11 += 1
					End While
				Else
					Dim num17 As Integer = 0
					Dim num18 As Integer = dataTable2.Rows.Count - 1
					Dim num19 As Integer = num17
					While True
						Dim num20 As Integer = num19
						Dim num7 As Integer = num18
						If num20 > num7 Then
							Exit While
						End If
						Dim text3 As String = Conversions.ToString(dataTable2.Rows(num19)("AName"))
						flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag2 Then
							text3 = Conversions.ToString(dataTable2.Rows(num19)("EName"))
						End If
						Dim values2 As Object() = New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num19)("acc_no")), text3, RuntimeHelpers.GetObjectValue(dataTable2.Rows(num19)("dept")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num19)("credit")) }
						dataTable.Rows.Add(values2)
						num19 += 1
					End While
				End If
				Dim num21 As Integer = 0
				Dim num22 As Integer = dataTable.Rows.Count - 1
				Dim num23 As Integer = num21
				While True
					Dim num24 As Integer = num23
					Dim num7 As Integer = num22
					If num24 > num7 Then
						Exit While
					End If
					Me.dgvSrch.Rows.Add()
					Me.dgvSrch.Rows(num23).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(0))
					Me.dgvSrch.Rows(num23).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(1))
					flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(2))) >= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(3))))

						If flag2 Then
							Me.dgvSrch.Rows(num23).Cells(2).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(2))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(3))))
							Me.dgvSrch.Rows(num23).Cells(3).Value = 0
						Else
							Me.dgvSrch.Rows(num23).Cells(3).Value = String.Format("{0:0.#,##.##}", Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(3))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num23)(2))))
							Me.dgvSrch.Rows(num23).Cells(2).Value = 0
						End If
						num += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num23).Cells(2).Value))
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num23).Cells(3).Value))

					num23 += 1
				End While
				Me.CalcStockFirstVal()
				Me.CalcStock()
				num2 += Conversion.Val(Me.txtStockVal.Text) + Conversion.Val(Me.txtFirstVal1.Text)
				num += Conversion.Val(Me.txtStockVal1.Text) + Conversion.Val(Me.txtFirstVal.Text)
				flag2 = (num2 >= num)
				If flag2 Then
					flag = (Me._FormType = 1)
					If flag Then
						Me.txtProfitLbl.Text = "صافي أرباح العام"
					Else
						Me.txtProfitLbl.Text = "صافي خسائر العام"
					End If
					Me.txtProfit1.Text = String.Format("{0:0.#,##.##}", Math.Round(num2 - num, 3))
					num += Conversion.Val(Me.txtProfit1.Text)
					Me.txtProfit2.Text = "0"
				Else
					flag2 = (Me._FormType = 2)
					If flag2 Then
						Me.txtProfitLbl.Text = "صافي أرباح العام"
					Else
						Me.txtProfitLbl.Text = "صافي خسائر العام"
					End If
					Me.txtProfit2.Text = String.Format("{0:0.#,##.##}", Math.Round(num - num2, 3))
					num2 += Conversion.Val(Me.txtProfit2.Text)
					Me.txtProfit1.Text = "0"
				End If
				Me.txtDeptDiff.Text = String.Format("{0:0.#,##.##}", num)
				Me.txtCreditDiff.Text = String.Format("{0:0.#,##.##}", num2)
				Me.txtIsBalanced.Text = "الحسابات متوازنة"
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

  Private Sub frmMezanyaArba7_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmMezanyaArba7.Load
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadBranches()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select storeclose_pricetype from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me._stoerclosepricetype = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
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
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvSrch.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value) })
					num3 += 1
				End While
				Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					obj = New rptArba7Details()
				Else
					obj = New rptArba7Details___EN()
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
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateTo" }, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtDateTo.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 2 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtuser" }, Nothing, Nothing, Nothing), TextObject)
				textObject3.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtfirst1" }, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.txtFirstVal.Text
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtfirst2" }, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtFirstVal1.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtlast1" }, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.txtStockVal1.Text
				Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtlast2" }, Nothing, Nothing, Nothing), TextObject)
				textObject7.Text = Me.txtStockVal.Text
				Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtprofit1" }, Nothing, Nothing, Nothing), TextObject)
				textObject8.Text = Me.txtProfit1.Text
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtprofit2" }, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.txtProfit2.Text
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblprofit" }, Nothing, Nothing, Nothing), TextObject)
				textObject10.Text = Me.txtProfitLbl.Text
				Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum1" }, Nothing, Nothing, Nothing), TextObject)
				textObject11.Text = Me.txtDeptDiff.Text
				Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtsum2" }, Nothing, Nothing, Nothing), TextObject)
				textObject12.Text = Me.txtCreditDiff.Text
				Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 4 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "lblisbalance" }, Nothing, Nothing, Nothing), TextObject)
				textObject13.Text = Me.txtIsBalanced.Text
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
					Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
					textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
					textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
					textObject16.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
					textObject17.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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

  Private Sub chkAllBranches_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllBranches.CheckedChanged
			Dim checked As Boolean = Me.chkAllBranches.Checked
			If checked Then
				Me.cmbBranches.Enabled = False
			Else
				Me.cmbBranches.Enabled = True
			End If
		End Sub
	End Class
