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
Public Partial Class frmSafeGrd
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _stoerclosepricetype As Integer

		Private _Finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSafeGrd_Load
			frmSafeGrd.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._stoerclosepricetype = 1
			Me._Finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSafeGrd.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSafeGrd.__ENCList.Count = frmSafeGrd.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSafeGrd.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSafeGrd.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSafeGrd.__ENCList(num) = frmSafeGrd.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSafeGrd.__ENCList.RemoveRange(num, frmSafeGrd.__ENCList.Count - num)
					frmSafeGrd.__ENCList.Capacity = frmSafeGrd.__ENCList.Count
				End If
				frmSafeGrd.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub LoadSafes()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where branch=" + Conversions.ToString(MainClass.BranchNo) + " and status=1 and IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSafes.DataSource = dataTable
			Me.cmbSafes.DisplayMember = "name"
			Me.cmbSafes.ValueMember = "id"
			Me.cmbSafes.SelectedIndex = -1
		End Sub

  Private Sub frmSafeGrd_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSafeGrd.Load
			Control.CheckForIllegalCrossThreadCalls = False
			Me.LoadSafes()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select storeclose_pricetype from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me._stoerclosepricetype = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Try
				Dim flag As Boolean = MainClass.hide_manfc
				If flag Then
					Me.pnlItemType.Visible = False
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select actv_manfc from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Dim flag As Boolean = dataTable2.Rows.Count > 0
				If flag Then
					Try
						Dim flag2 As Boolean = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("actv_manfc")))
						If flag2 Then
							Me.pnlItemType.Visible = False
						End If
					Catch ex3 As Exception
					End Try
				End If
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub CalcStock()
			' The following expression was wrapped in a checked-statement
			Try
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("currency", Type.[GetType]("System.Int32"))
				dataTable.Columns.Add("sum")
				dataTable.Columns.Add("type")
				Dim str As String = ""
				Dim str2 As String = ""
				Dim flag As Boolean = Not Me.chkAll.Checked
				If flag Then
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" inv.safe=", Me.cmbSafes.SelectedValue), " and "))
					str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" safe=", Me.cmbSafes.SelectedValue), " and "))
				End If
				Dim str3 As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str3 = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				flag = Me.chkZeros.Checked
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from currencies where is_deleted=0", Me.conn)
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
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("id")), 0, 1 })
						num3 += 1
					End While
				End If
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num6 As Integer = 0
				Dim num7 As Integer = dataTable3.Rows.Count - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					Dim num5 As Integer = num7
					If num9 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num8)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num8)(1))), 1 })
					num8 += 1
				End While
				sqlDataAdapter2 = New SqlDataAdapter("select item,sum(difftot) from tsweya,tsweya_sub where " + str2 + " tsweya.id=tsweya_sub.tsweya_id and IS_Deleted=0 group by item", Me.conn)
				dataTable3 = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num10 As Integer = 0
				Dim num11 As Integer = dataTable3.Rows.Count - 1
				Dim num12 As Integer = num10
				While True
					Dim num13 As Integer = num12
					Dim num5 As Integer = num11
					If num13 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num12)(1))), 1 })
					num12 += 1
				End While
				sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable3 = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num14 As Integer = 0
				Dim num15 As Integer = dataTable3.Rows.Count - 1
				Dim num16 As Integer = num14
				While True
					Dim num17 As Integer = num16
					Dim num5 As Integer = num15
					If num17 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num16)(1))), 1 })
					num16 += 1
				End While
				sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable3 = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num18 As Integer = 0
				Dim num19 As Integer = dataTable3.Rows.Count - 1
				Dim num20 As Integer = num18
				While True
					Dim num21 As Integer = num20
					Dim num5 As Integer = num19
					If num21 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num20)(1))), 2 })
					num20 += 1
				End While
				sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable3 = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num22 As Integer = 0
				Dim num23 As Integer = dataTable3.Rows.Count - 1
				Dim num24 As Integer = num22
				While True
					Dim num25 As Integer = num24
					Dim num5 As Integer = num23
					If num25 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num24)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num24)(1))), 2 })
					num24 += 1
				End While
				sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
				dataTable3 = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim num26 As Integer = 0
				Dim num27 As Integer = dataTable3.Rows.Count - 1
				Dim num28 As Integer = num26
				While True
					Dim num29 As Integer = num28
					Dim num5 As Integer = num27
					If num29 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num28)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num28)(1))), 1 })
					num28 += 1
				End While
				Dim num30 As Integer = 2
				Try
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select consume_type from foundation where id=1", Me.conn)
					Dim dataTable4 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable4)
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))) = 1)
					If flag Then
						num30 = 1
					End If
				Catch ex As Exception
				End Try
				flag = (num30 = 1)
				If flag Then
					sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " is_buy=0 and inv.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					Dim num31 As Integer = 0
					Dim num32 As Integer = dataTable3.Rows.Count - 1
					Dim num33 As Integer = num31
					While True
						Dim num34 As Integer = num33
						Dim num5 As Integer = num32
						If num34 > num5 Then
							Exit While
						End If
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num33)(0))), Me.conn)
						Dim dataTable5 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable5)
						Dim num35 As Integer = 0
						Dim num36 As Integer = dataTable5.Rows.Count - 1
						Dim num37 As Integer = num35
						While True
							Dim num38 As Integer = num37
							num5 = num36
							If num38 > num5 Then
								Exit While
							End If
							dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable5.Rows(num37)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num33)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable5.Rows(num37)(1)))), 2 })
							num37 += 1
						End While
						num33 += 1
					End While
				Else
					sqlDataAdapter2 = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " is_manfc=1 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					Dim num39 As Integer = 0
					Dim num40 As Integer = dataTable3.Rows.Count - 1
					Dim num41 As Integer = num39
					While True
						Dim num42 As Integer = num41
						Dim num5 As Integer = num40
						If num42 > num5 Then
							Exit While
						End If
						Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num41)(0))), Me.conn)
						Dim dataTable6 As DataTable = New DataTable()
						sqlDataAdapter5.Fill(dataTable6)
						Dim num43 As Integer = 0
						Dim num44 As Integer = dataTable6.Rows.Count - 1
						Dim num45 As Integer = num43
						While True
							Dim num46 As Integer = num45
							num5 = num44
							If num46 > num5 Then
								Exit While
							End If
							dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable6.Rows(num45)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable3.Rows(num41)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable6.Rows(num45)(1)))), 2 })
							num45 += 1
						End While
						num41 += 1
					End While
				End If
				flag = Not Me.chkAll.Checked
				If flag Then
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Me.cmbSafes.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					Dim num47 As Integer = 0
					Dim num48 As Integer = dataTable3.Rows.Count - 1
					Dim num49 As Integer = num47
					While True
						Dim num50 As Integer = num49
						Dim num5 As Integer = num48
						If num50 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num49)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num49)(1))), 1 })
						num49 += 1
					End While
					sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Me.cmbSafes.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
					dataTable3 = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					Dim num51 As Integer = 0
					Dim num52 As Integer = dataTable3.Rows.Count - 1
					Dim num53 As Integer = num51
					While True
						Dim num54 As Integer = num53
						Dim num5 As Integer = num52
						If num54 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable3.Rows(num53)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num53)(1))), 2 })
						num53 += 1
					End While
				End If
				Dim num55 As Integer = dataTable.Rows.Count - 1
				Dim num56 As Integer = 0
				Dim num57 As Integer = num55
				Dim num58 As Integer = num56
				While True
					Dim num59 As Integer = num58
					Dim num5 As Integer = num57
					If num59 > num5 Then
						Exit While
					End If
					flag = (num58 <= num55)
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num58)(2), 2, False)
						If flag2 Then
							' The following expression was wrapped in a unchecked-expression
							dataTable.Rows(num58)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1)))
						End If
					End If
					Dim num60 As Integer = num58 + 1
					Dim num61 As Integer = num55
					Dim num62 As Integer = num60
					While True
						Dim num63 As Integer = num62
						num5 = num61
						If num63 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = num62 <= num55
						If flag2 Then
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num58)(0), dataTable.Rows(num62)(0), False)
							If flag Then
								Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num62)(2), 2, False)

									If flag3 Then
										dataTable.Rows(num62)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num62)(1)))
									End If
									dataTable.Rows(num58)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num62)(1)))
									dataTable.Rows.RemoveAt(num62)

								num62 -= 1
								num55 -= 1
							End If
						End If
						num62 += 1
					End While
					num58 += 1
				End While
				Dim num64 As Double = 0.0
				Dim num65 As Double = 0.0
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = dataTable.Rows.Count
				Dim dataView As DataView = dataTable.AsDataView()
				dataView.Sort = "currency asc"
				dataTable = dataView.ToTable()
				Dim num66 As Integer = 0
				Dim num67 As Integer = dataTable.Rows.Count - 1
				Dim num68 As Integer = num66
				While True
					Dim num69 As Integer = num68
					Dim num5 As Integer = num67
					If num69 > num5 Then
						Exit While
					End If
					Dim progressBar As ProgressBar

						Try
							Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select is_deleted,sale_price,type from currencies where id=", dataTable.Rows(num68)(0))), Me.conn)
							Dim dataTable7 As DataTable = New DataTable()
							sqlDataAdapter6.Fill(dataTable7)
							Dim flag4 As Boolean = False
							Dim num70 As Integer = 1
							Try
								num70 = Conversions.ToInteger(dataTable7.Rows(0)("type"))
							Catch ex2 As Exception
							End Try
							Dim flag3 As Boolean = num70 = 1 And Me.chkType1.Checked
							If flag3 Then
								flag4 = True
							Else
								flag3 = (num70 = 2 And Me.chkType2.Checked)
								If flag3 Then
									flag4 = True
								Else
									flag3 = (num70 = 3 And Me.chkType3.Checked)
									If flag3 Then
										flag4 = True
									End If
								End If
							End If
							Dim flag5 As Boolean = True
							flag3 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))) = 0.0 And Not Me.chkZeros.Checked)
							If flag3 Then
								flag5 = False
							End If
							flag3 = (Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)(0))) AndAlso flag4 AndAlso flag5)
							If flag3 Then
								Dim num71 As Double = 0.0
								Dim num72 As Double = 0.0
								Try
									flag3 = (Me._stoerclosepricetype = 1)
									If flag3 Then
										sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str3 + " currency_from=", dataTable.Rows(num68)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
										dataTable3 = New DataTable()
										sqlDataAdapter2.Fill(dataTable3)
										flag3 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
										If flag3 Then
											num71 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
											num72 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
										End If
									Else
										flag3 = (Me._stoerclosepricetype = 3)
										If flag3 Then
											sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 (val),(val1*exchange_price) from inv,inv_sub where " + str3 + " currency_from=", dataTable.Rows(num68)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 order by inv.date desc")), Me.conn)
											dataTable3 = New DataTable()
											sqlDataAdapter2.Fill(dataTable3)
											flag3 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
											If flag3 Then
												num71 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
												num72 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
											End If
										End If
									End If
								Catch ex3 As Exception
								End Try
								Try
									flag3 = (num72 <> 0.0)
									Dim num73 As Double
									If flag3 Then
										num73 = num71 / num72
										num73 = Math.Floor(num73 * 100000000.0)
										num73 /= 100000000.0
									Else
										Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from currencies where id=", dataTable.Rows(num68)(0))), Me.conn)
										Dim dataTable8 As DataTable = New DataTable()
										sqlDataAdapter7.Fill(dataTable8)
										num73 = Conversion.Val(Operators.ConcatenateObject("", dataTable8.Rows(0)(0)))
									End If
									Me.dgvItems.Rows.Add()
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(0))
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num68)(0)))
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))), 2)
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = String.Format("{0:0.#,##.##}", num73)
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = String.Format("{0:0.#,##.##}", Math.Round(num73 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))), 2))
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = String.Format("{0:0.#,##.##}", RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("sale_price")))
									Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = String.Format("{0:0.#,##.##}", Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("sale_price"))) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))), 2))
									num64 += Math.Round(num73 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))), 2)
									num65 += Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("sale_price"))) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num68)(1))), 4)
								Catch ex4 As Exception
								End Try
							End If
						Catch ex5 As Exception
						End Try
						progressBar = Me.ProgressBar1

					progressBar.Value += 1
					num68 += 1
				End While
				Me.txtSum.Text = String.Format("{0:0.#,##.##}", num64)
				Me.txtSum2.Text = String.Format("{0:0.#,##.##}", num65)
			Catch ex6 As Exception
			Finally
				Me._Finished = True
			End Try
		End Sub

		Private Function GetCurrencyName(Currency_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol,nameEN from Currencies where IS_Deleted=0 and id=" + Conversions.ToString(Currency_id), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			Dim result As String
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag2 Then
					result = dataTable.Rows(0)(0).ToString()
				Else
					result = dataTable.Rows(0)(1).ToString()
				End If
			Else
				result = ""
			End If
			Return result
		End Function

	Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbSafes.SelectedIndex = -1
		If flag Then
			MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafes.Focus()
		Else
			Me.dgvItems.Rows.Clear()
			Me.dgvItems.ScrollBars = ScrollBars.None
			'Dim thread As Thread = AddressOf Me.CalcStock
			Dim thread As New Thread(AddressOf Me.CalcStock)
			thread.Start()
		End If
	End Sub

	Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
			Dim checked As Boolean = Me.chkAll.Checked
			If checked Then
				Me.cmbSafes.Enabled = False
			Else
				Me.cmbSafes.Enabled = True
			End If
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
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
			If flag Then
				MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("no")
				dataTable.Columns.Add("name")
				dataTable.Columns.Add("val")
				dataTable.Columns.Add("avg")
				dataTable.Columns.Add("total")
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("DataColumn11")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value) })
					num3 += 1
				End While
				Dim rptSafeGrd As rptSafeGrd2 = New rptSafeGrd2()
				rptSafeGrd.SetDataSource(dataTable)
				Dim text As String = "الكل"
				flag = Not Me.chkAll.Checked
				If flag Then
					text = Me.cmbSafes.Text
				End If
				Dim textObject As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("txtSafe"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject2.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject3 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
				textObject3.Text = Me.txtSum.Text
				Dim textObject4 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(4).ReportObjects("txtSum2"), TextObject)
				textObject4.Text = Me.txtSum2.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptSafeGrd.Subreports("rptHeader").SetDataSource(dataTable2)
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptSafeGrd
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptSafeGrd.PrintToPrinter(1, False, 1, currentPageNumber)
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

  Private Sub cmbSafes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSafes.SelectedIndexChanged
		End Sub

  Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Dim finished As Boolean = Me._Finished
			If finished Then
				Me._Finished = False
				Me.dgvItems.ScrollBars = ScrollBars.Both
			End If
		End Sub
	End Class
