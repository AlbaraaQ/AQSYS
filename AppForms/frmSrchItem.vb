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
	Public Partial Class frmSrchItem
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Public type As Integer

		Public frm1 As frmSalePurch

		Public _Store As Integer

		Private cond As String

		Private th As Thread

		Private _Finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSrchItem_Load
			frmSrchItem.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.type = 1
			Me._Store = -1
			Me.cond = ""
			Me.th = Nothing
			Me._Finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSrchItem.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSrchItem.__ENCList.Count = frmSrchItem.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSrchItem.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSrchItem.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSrchItem.__ENCList(num) = frmSrchItem.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSrchItem.__ENCList.RemoveRange(num, frmSrchItem.__ENCList.Count - num)
					frmSrchItem.__ENCList.Capacity = frmSrchItem.__ENCList.Count
				End If
				frmSrchItem.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub LoadDG()
			' The following expression was wrapped in a checked-statement
			Try
				Me.dgvCurrencies.Rows.Clear()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Currencies.id as currency_id,Currencies.symbol,Currencies.nameEN,barcode,groups.name as groupname,purch_price,sale_price from Currencies,groups  where " + Me.cond + " Currencies.group_id=groups.id and Currencies.IS_Deleted=0", Me.conn)
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
					Me.dgvCurrencies.Rows.Add()
					Me.dgvCurrencies.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency_id"))
					Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag Then
						Me.dgvCurrencies.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("symbol"))
					Else
						Me.dgvCurrencies.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nameEN"))
					End If
					Me.dgvCurrencies.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("barcode"))
					Try
						Me.dgvCurrencies.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("groupname"))
					Catch ex As Exception
					End Try
					Try
						Me.dgvCurrencies.Rows(num3).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("purch_price"))))
						Me.dgvCurrencies.Rows(num3).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))))
					Catch ex2 As Exception
					End Try
					Try
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 exchange_price,val,val1 from inv,inv_sub where inv.proc_id=inv_sub.proc_id and inv.is_deleted=0 and inv.proc_type=1 and is_buy=1 and currency_from=", dataTable.Rows(num3)("currency_id")), " order by date desc")), Me.conn)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag = (dataTable2.Rows.Count > 0)
						If flag Then
							Me.dgvCurrencies.Rows(num3).Cells(4).Value = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("exchange_price"))) / (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("val"))) / Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("val1")))), 2))
						End If
					Catch ex3 As Exception
					End Try
					Try
						Me.dgvCurrencies.Rows(num3).Cells(6).Value = Me.CalcStock(Conversions.ToInteger(dataTable.Rows(num3)("currency_id")))
					Catch ex4 As Exception
					End Try
					num3 += 1
				End While
				Me.dgvCurrencies.Focus()
			Catch ex5 As Exception
			Finally
				Me._Finished = True
			End Try
		End Sub

		Private Function CalcStock(_item As Integer) As Double
			' The following expression was wrapped in a checked-statement
			Try
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("currency")
				dataTable.Columns.Add("sum")
				dataTable.Columns.Add("type")
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency_from,sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and inv.safe=", Conversions.ToString(Me._Store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from" }), Me.conn)
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
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select item,sum(difftot) from tsweya,tsweya_sub where safe=", Conversions.ToString(Me._Store), " and item=", Conversions.ToString(_item), " and tsweya.id=tsweya_sub.tsweya_id and IS_Deleted=0 group by item" }), Me.conn)
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
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency_from,sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and inv.safe=", Conversions.ToString(Me._Store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from" }), Me.conn)
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 2 })
					num12 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency_from,sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and inv.safe=", Conversions.ToString(Me._Store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from" }), Me.conn)
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 3 })
					num16 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency_from,sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and inv.safe=", Conversions.ToString(Me._Store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from" }), Me.conn)
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 4 })
					num20 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency_from,sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and inv.safe=", Conversions.ToString(Me._Store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from" }), Me.conn)
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
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 5 })
					num24 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Conversions.ToString(Me._Store), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0 group by currency" }), Me.conn)
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num26 As Integer = 0
				Dim num27 As Integer = dataTable2.Rows.Count - 1
				Dim num28 As Integer = num26
				While True
					Dim num29 As Integer = num28
					Dim num5 As Integer = num27
					If num29 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num28)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num28)(1))), 6 })
					num28 += 1
				End While
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Conversions.ToString(Me._Store), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0 group by currency" }), Me.conn)
				dataTable2 = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim num30 As Integer = 0
				Dim num31 As Integer = dataTable2.Rows.Count - 1
				Dim num32 As Integer = num30
				While True
					Dim num33 As Integer = num32
					Dim num5 As Integer = num31
					If num33 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(dataTable2.Rows(num32)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num32)(1))), 7 })
					num32 += 1
				End While
				Dim num34 As Integer = dataTable.Rows.Count - 1
				Dim num35 As Integer = 0
				Dim num36 As Integer = num34
				Dim num37 As Integer = num35
				Dim flag3 As Boolean
				While True
					Dim num38 As Integer = num37
					Dim num5 As Integer = num36
					If num38 > num5 Then
						Exit While
					End If
					Dim flag As Boolean = num37 <= num34
					If flag Then
						Dim flag2 As Boolean = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 7, False)))
						If flag2 Then
							' The following expression was wrapped in a unchecked-expression
							dataTable.Rows(num37)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
						End If
					End If
					Dim num39 As Integer = num37 + 1
					Dim num40 As Integer = num34
					Dim num41 As Integer = num39
					While True
						Dim num42 As Integer = num41
						num5 = num40
						If num42 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = num41 <= num34
						If flag2 Then
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num37)(0), dataTable.Rows(num41)(0), False)
							If flag Then
								flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num41)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num41)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num41)(2), 7, False)))

									If flag3 Then
										dataTable.Rows(num41)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num41)(1)))
									End If
									dataTable.Rows(num37)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num41)(1)))
									dataTable.Rows.RemoveAt(num41)

								num41 -= 1
								num34 -= 1
							End If
						End If
						num41 += 1
					End While
					num37 += 1
				End While
				flag3 = (dataTable.Rows.Count > 0)
				If flag3 Then
					Return Conversion.Val(dataTable.Rows(0)(1).ToString())
				End If
			Catch ex As Exception
			End Try
			Return 0.0
		End Function

  Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
			Try
				Me.cond = String.Concat(New String() { "symbol like '%", Me.txtNameSrch.Text, "%' and barcode like '%", Me.txtSrchBarcode.Text, "%' and " })
				Dim flag As Boolean = Not Me.chkAllGroups.Checked And Me.cmbGroups.SelectedValue IsNot Nothing
				If flag Then
					Me.cond = Conversions.ToString(Operators.AddObject(Me.cond, Operators.ConcatenateObject(Operators.ConcatenateObject(" group_id=", Me.cmbGroups.SelectedValue), " and ")))
				End If
				Try
					Me.th.Abort()
				Catch ex As Exception
				End Try
				Me._Finished = False
				Me.Timer1.Enabled = True
				Me.dgvCurrencies.ScrollBars = ScrollBars.None
			'Me.th = AddressOf Me.LoadDG
			Dim th As New Thread(AddressOf Me.LoadDG)
			th.Start()
		Catch ex2 As Exception
			End Try
		End Sub

		Public Sub LoadGroups()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from groups order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbGroups.DataSource = dataTable
			Me.cmbGroups.DisplayMember = "name"
			Me.cmbGroups.ValueMember = "id"
			Me.cmbGroups.SelectedIndex = -1
		End Sub

  Private Sub frmSrchItem_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSrchItem.Load
			Me.LoadGroups()
			Me.txtNameSrch.Focus()
		End Sub

  Private Sub chkAllGroups_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllGroups.CheckedChanged
			Try
				Dim checked As Boolean = Me.chkAllGroups.Checked
				If checked Then
					Me.cmbGroups.Enabled = False
				Else
					Me.cmbGroups.Enabled = True
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvCurrencies_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCurrencies.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 7
				If flag Then
					Dim flag2 As Boolean = Me.type = 1
					If flag2 Then
						Me.frm1.ItemID = Conversions.ToInteger(Me.dgvCurrencies.Rows(e.RowIndex).Cells(0).Value)
						Me.Close()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtNameSrch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtNameSrch.KeyDown
			Try
				Dim flag As Boolean = e.KeyCode = Keys.[Return]
				If flag Then
					Me.Button3_Click(Nothing, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub txtSrchBarcode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSrchBarcode.KeyDown
			Try
				Dim flag As Boolean = e.KeyCode = Keys.[Return]
				If flag Then
					Me.Button3_Click(Nothing, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvCurrencies_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgvCurrencies.KeyDown
			Try
				Dim flag As Boolean = e.KeyCode = Keys.[Return]
				If flag Then
					Dim flag2 As Boolean = Me.type = 1
					If flag2 Then
						Me.frm1.ItemID = Conversions.ToInteger(Me.dgvCurrencies.Rows(Me.dgvCurrencies.SelectedCells(0).RowIndex).Cells(0).Value)
						Me.Close()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
			Try
				Dim finished As Boolean = Me._Finished
				If finished Then
					Me._Finished = False
					Me.dgvCurrencies.ScrollBars = ScrollBars.Both
					Me.Timer1.Enabled = False
					Me.dgvCurrencies.Focus()
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
