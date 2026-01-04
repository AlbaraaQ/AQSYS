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
Public Partial Class frmSafeGrdToDate
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _stoerclosepricetype As Integer

		Private _Finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSafeGrdToDate_Load
			frmSafeGrdToDate.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._stoerclosepricetype = 1
			Me._Finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSafeGrdToDate.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSafeGrdToDate.__ENCList.Count = frmSafeGrdToDate.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSafeGrdToDate.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSafeGrdToDate.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSafeGrdToDate.__ENCList(num) = frmSafeGrdToDate.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSafeGrdToDate.__ENCList.RemoveRange(num, frmSafeGrdToDate.__ENCList.Count - num)
					frmSafeGrdToDate.__ENCList.Capacity = frmSafeGrdToDate.__ENCList.Count
				End If
				frmSafeGrdToDate.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

	Private Sub frmSafeGrdToDate_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSafeGrdToDate.Load
			Control.CheckForIllegalCrossThreadCalls = False
			Try
				Dim flag As Boolean = MainClass.hide_manfc
				If flag Then
					Me.pnlItemType.Visible = False
				End If
			Catch ex As Exception
			End Try
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select storeclose_pricetype from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me._stoerclosepricetype = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
			Catch ex2 As Exception
			End Try
			Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.LoadSafes()
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
				Dim dateTime As DateTime = Conversions.ToDate(Me.txtDateFrom.Value.ToShortDateString())
				Dim dateTime2 As DateTime = Conversions.ToDate(Me.txtDateTo.Value.AddDays(1.0).ToShortDateString())
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				sqlDataAdapter = New SqlDataAdapter("select item,sum(difftot) from tsweya,tsweya_sub where " + str2 + " tsweya.id=tsweya_sub.tsweya_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by item", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " (is_hold=0 or is_hold is null) and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
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
				Dim num26 As Integer = 2
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select consume_type from foundation where id=1", Me.conn)
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))) = 1)
					If flag Then
						num26 = 1
					End If
				Catch ex As Exception
				End Try
				flag = (num26 = 1)
				If flag Then
					sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " is_buy=0 and inv.proc_type=1 and inv.proc_id=inv_sub.proc_id and date>=@date1 and date<=@date2  and IS_Deleted=0 group by currency_from", Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim num27 As Integer = 0
					Dim num28 As Integer = dataTable2.Rows.Count - 1
					Dim num29 As Integer = num27
					While True
						Dim num30 As Integer = num29
						Dim num5 As Integer = num28
						If num30 > num5 Then
							Exit While
						End If
						Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num29)(0))), Me.conn)
						Dim dataTable4 As DataTable = New DataTable()
						sqlDataAdapter3.Fill(dataTable4)
						Dim num31 As Integer = 0
						Dim num32 As Integer = dataTable4.Rows.Count - 1
						Dim num33 As Integer = num31
						While True
							Dim num34 As Integer = num33
							num5 = num32
							If num34 > num5 Then
								Exit While
							End If
							dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num29)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num33)(1)))), 2 })
							num33 += 1
						End While
						num29 += 1
					End While
				Else
					sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str3 + str + " is_manfc=1 and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from", Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim num35 As Integer = 0
					Dim num36 As Integer = dataTable2.Rows.Count - 1
					Dim num37 As Integer = num35
					While True
						Dim num38 As Integer = num37
						Dim num5 As Integer = num36
						If num38 > num5 Then
							Exit While
						End If
						Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select mat_id,mat_quantot from item_comp where item_id=" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num37)(0))), Me.conn)
						Dim dataTable5 As DataTable = New DataTable()
						sqlDataAdapter4.Fill(dataTable5)
						Dim num39 As Integer = 0
						Dim num40 As Integer = dataTable5.Rows.Count - 1
						Dim num41 As Integer = num39
						While True
							Dim num42 As Integer = num41
							num5 = num40
							If num42 > num5 Then
								Exit While
							End If
							dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable5.Rows(num41)(0)), Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num37)(1)))) * Conversion.Val("" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable5.Rows(num41)(1)))), 2 })
							num41 += 1
						End While
						num37 += 1
					End While
				End If
				flag = Not Me.chkAll.Checked
				If flag Then
					sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Me.cmbSafes.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency")), Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim num43 As Integer = 0
					Dim num44 As Integer = dataTable2.Rows.Count - 1
					Dim num45 As Integer = num43
					While True
						Dim num46 As Integer = num45
						Dim num5 As Integer = num44
						If num46 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num45)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num45)(1))), 1 })
						num45 += 1
					End While
					sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Me.cmbSafes.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency")), Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = dateTime
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
					dataTable2 = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim num47 As Integer = 0
					Dim num48 As Integer = dataTable2.Rows.Count - 1
					Dim num49 As Integer = num47
					While True
						Dim num50 As Integer = num49
						Dim num5 As Integer = num48
						If num50 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num49)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num49)(1))), 2 })
						num49 += 1
					End While
				End If
				Dim num51 As Integer = dataTable.Rows.Count - 1
				Dim num52 As Integer = 0
				Dim num53 As Integer = num51
				Dim num54 As Integer = num52
				While True
					Dim num55 As Integer = num54
					Dim num5 As Integer = num53
					If num55 > num5 Then
						Exit While
					End If
					flag = (num54 <= num51)
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num54)(2), 2, False)
						If flag2 Then
							' The following expression was wrapped in a unchecked-expression
							dataTable.Rows(num54)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num54)(1)))
						End If
					End If
					Dim num56 As Integer = num54 + 1
					Dim num57 As Integer = num51
					Dim num58 As Integer = num56
					While True
						Dim num59 As Integer = num58
						num5 = num57
						If num59 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = num58 <= num51
						If flag2 Then
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num54)(0), dataTable.Rows(num58)(0), False)
							If flag Then
								Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num58)(2), 2, False)

									If flag3 Then
										dataTable.Rows(num58)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1)))
									End If
									dataTable.Rows(num54)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num54)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num58)(1)))
									dataTable.Rows.RemoveAt(num58)

								num58 -= 1
								num51 -= 1
							End If
						End If
						num58 += 1
					End While
					num54 += 1
				End While
				Dim num60 As Double = 0.0
				Me.ProgressBar1.Value = 0
				Me.ProgressBar1.Maximum = dataTable.Rows.Count
				Dim dataView As DataView = dataTable.AsDataView()
				dataView.Sort = "currency asc"
				dataTable = dataView.ToTable()
				Dim num61 As Integer = 0
				Dim num62 As Integer = dataTable.Rows.Count - 1
				Dim num63 As Integer = num61
				While True
					Dim num64 As Integer = num63
					Dim num5 As Integer = num62
					If num64 > num5 Then
						Exit While
					End If
					Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select is_deleted,sale_price,type from currencies where id=", dataTable.Rows(num63)(0))), Me.conn)
					Dim dataTable6 As DataTable = New DataTable()
					sqlDataAdapter5.Fill(dataTable6)
					Dim flag4 As Boolean = False
					Dim num65 As Integer = 1
					Try
						num65 = Conversions.ToInteger(dataTable6.Rows(0)("type"))
					Catch ex2 As Exception
					End Try
					Dim flag3 As Boolean = num65 = 1 And Me.chkType1.Checked
					If flag3 Then
						flag4 = True
					Else
						flag3 = (num65 = 2 And Me.chkType2.Checked)
						If flag3 Then
							flag4 = True
						Else
							flag3 = (num65 = 3 And Me.chkType3.Checked)
							If flag3 Then
								flag4 = True
							End If
						End If
					End If
					flag3 = ((Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))) AndAlso flag4) And Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num63)(1))) <> 0.0)
					Dim progressBar As ProgressBar

						If flag3 Then
							Dim num66 As Double = 0.0
							Dim num67 As Double = 0.0
							Try
								flag3 = (Me._stoerclosepricetype = 1)
								If flag3 Then
									sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str3 + " currency_from=", dataTable.Rows(num63)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
									dataTable2 = New DataTable()
									sqlDataAdapter.Fill(dataTable2)
									flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
									If flag3 Then
										num66 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))
										num67 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
									End If
								Else
									flag3 = (Me._stoerclosepricetype = 3)
									If flag3 Then
										sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 (val),(val1*exchange_price) from inv,inv_sub where " + str3 + " currency_from=", dataTable.Rows(num63)(0)), " and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 order by inv.date desc")), Me.conn)
										dataTable2 = New DataTable()
										sqlDataAdapter.Fill(dataTable2)
										flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
										If flag3 Then
											num66 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))
											num67 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
										End If
									End If
								End If
							Catch ex3 As Exception
							End Try
							Try
								flag3 = (num67 <> 0.0)
								Dim num68 As Double
								If flag3 Then
									num68 = num66 / num67
									num68 = Math.Floor(num68 * 100000000.0)
									num68 /= 100000000.0
								Else
									Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from currencies where id=", dataTable.Rows(num63)(0))), Me.conn)
									Dim dataTable7 As DataTable = New DataTable()
									sqlDataAdapter6.Fill(dataTable7)
									num68 = Conversion.Val(Operators.ConcatenateObject("", dataTable7.Rows(0)(0)))
								End If
								Me.dgvItems.Rows.Add()
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num63)(0))
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num63)(0)))
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num63)(1))), 2)
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = String.Format("{0:0.#,##.##}", num68)
								Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = String.Format("{0:0.#,##.##}", Math.Round(num68 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num63)(1))), 4))
								num60 += Math.Round(num68 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num63)(1))), 4)
							Catch ex4 As Exception
							End Try
						End If
						progressBar = Me.ProgressBar1

					progressBar.Value += 1
					num63 += 1
				End While
				Me.txtSum.Text = String.Format("{0:0.#,##.##}", num60)
			Catch ex5 As Exception
			Finally
				Me._Finished = True
			End Try
		End Sub

		Private Function GetCurrencyName(Currency_id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol,nameEN from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
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
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value) })
					num3 += 1
				End While
				Dim rptSafeGrd As rptSafeGrd = New rptSafeGrd()
				rptSafeGrd.SetDataSource(dataTable)
				Dim text As String = "الكل"
				flag = Not Me.chkAll.Checked
				If flag Then
					text = Me.cmbSafes.Text
				End If
				Dim textObject As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("txtSafe"), TextObject)
				textObject.Text = text
				Dim textObject2 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("lbltodate"), TextObject)
				textObject2.Text = "حتى تاريخ"
				Dim textObject3 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("txtdateto"), TextObject)
				textObject3.Text = Me.txtDateFrom.Value.ToShortDateString()
				Dim textObject4 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject4.Text = Me.GetEmpUserName(MainClass.EmpNo)
				Dim textObject5 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
				textObject5.Text = Me.txtSum.Text
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

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Dim finished As Boolean = Me._Finished
			If finished Then
				Me._Finished = False
				Me.dgvItems.ScrollBars = ScrollBars.Both
			End If
		End Sub
	End Class
