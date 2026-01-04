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
Public Partial Class frmM5znTsweya
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer

		Private chkcurr As Boolean

		Public ItemID As Integer

		Private ResID As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmM5znTransfer_Load
			frmM5znTsweya.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me.chkcurr = True
			Me.ItemID = -1
			Me.ResID = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmM5znTsweya.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmM5znTsweya.__ENCList.Count = frmM5znTsweya.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmM5znTsweya.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmM5znTsweya.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmM5znTsweya.__ENCList(num) = frmM5znTsweya.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmM5znTsweya.__ENCList.RemoveRange(num, frmM5znTsweya.__ENCList.Count - num)
					frmM5znTsweya.__ENCList.Capacity = frmM5znTsweya.__ENCList.Count
				End If
				frmM5znTsweya.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub LoadCostCenter()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from costcenter order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCenter.DataSource = dataTable
			Me.cmbCenter.DisplayMember = "name"
			Me.cmbCenter.ValueMember = "id"
			Me.cmbCenter.SelectedIndex = -1
		End Sub

		Public Sub LoadSafes()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes,Safe_Emps where Safes.id=Safe_Emps.safe_id and emp_id=" + Conversions.ToString(MainClass.EmpNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbSafe.DataSource = dataTable
			Me.cmbSafe.DisplayMember = "name"
			Me.cmbSafe.ValueMember = "id"
			Me.cmbSafe.SelectedIndex = -1
			Dim flag As Boolean = Me.cmbSafe.Items.Count > 0
			If flag Then
				Me.cmbSafe.SelectedIndex = 0
			End If
		End Sub

		Public Sub LoadAllItems()
			Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvItems.Columns(1), DataGridViewComboBoxColumn)
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			dataGridViewComboBoxColumn.DataSource = dataTable
			dataGridViewComboBoxColumn.DisplayMember = "symbol"
			dataGridViewComboBoxColumn.ValueMember = "id"
		End Sub

		Private Sub LoadUnits()
			Try
				Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvItems.Columns(2), DataGridViewComboBoxColumn)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from units order by id", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				dataGridViewComboBoxColumn.DataSource = dataTable
				dataGridViewComboBoxColumn.DisplayMember = "name"
				dataGridViewComboBoxColumn.ValueMember = "id"
			Catch ex As Exception
			End Try
		End Sub

		Private Sub LoadNextNo()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(no) from tsweya", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Me.txtNo.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0)
				Else
					Me.txtNo.Text = "1"
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.dgvItems.Rows.Clear()
			Me.Code = -1
			Me.LoadNextNo()
			Dim flag As Boolean = Me.cmbSafe.Items.Count > 0
			If flag Then
				Me.cmbSafe.SelectedIndex = 0
			End If
		End Sub

		Private Sub UnitChanged(_rowinx As Integer, _Item As Integer, _Unit As Integer)
			Try
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select curr_units.perc from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=" + Conversions.ToString(_Unit) + " and curr_units.curr=" + Conversions.ToString(_Item), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Dim flag As Boolean = dataTable.Rows.Count > 0
					If flag Then
						Me.dgvItems.Rows(_rowinx).Cells(4).Value = Math.Round(Convert.ToDouble(Me.CalcStock(Conversions.ToInteger(Me.cmbSafe.SelectedValue), _Item)) / Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))), 2)
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub LoadUnits(curr As Integer)
			Try
				Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvItems.Columns(2), DataGridViewComboBoxColumn)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select units.id,units.name from units where id in ( select currencies.unit from currencies where currencies.id= ", Conversions.ToString(curr), ") or id in (select curr_units.unit from curr_units where curr_units.curr=", Conversions.ToString(curr), ")  order by units.id" }), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					dataGridViewComboBoxColumn.DataSource = dataTable
					dataGridViewComboBoxColumn.DisplayMember = "name"
					dataGridViewComboBoxColumn.ValueMember = "id"
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function CalcStock(_safe As Integer, _item As Integer) As Decimal
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Double = 0.0
				Dim num5 As Double = 0.0
				Dim num6 As Double = 0.0
				Dim num7 As Double = 0.0
				Dim num8 As Double = 0.0
				Dim num9 As Double = 0.0
				Dim num10 As Double = 0.0
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and Safe=", Conversions.ToString(_safe), " and IS_Deleted=0 " }), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
				If flag Then
					num = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(difftot) from tsweya,tsweya_sub where tsweya.id=tsweya_sub.tsweya_id and item=", Conversions.ToString(_item), " and safe=", Conversions.ToString(_safe), " and IS_Deleted=0" }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num4 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe=", Conversions.ToString(_safe), " and IS_Deleted=0 " }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num5 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and Safe=", Conversions.ToString(_safe), " and IS_Deleted=0 " }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num6 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe=", Conversions.ToString(_safe), " and IS_Deleted=0 " }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num7 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and Safe=", Conversions.ToString(_safe), " and IS_Deleted=0 " }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num8 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Conversions.ToString(_safe), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0" }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num9 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() { "select sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Conversions.ToString(_safe), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0" }), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
				If flag Then
					num10 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
				Dim value As Double = num + num5 - num6 - num7 + num8 + num9 - num10 + num2 - num3 + num4
				Return New Decimal(value)
			Catch ex As Exception
			End Try
			Return 0D
		End Function

		Private Sub ItemChanged(_rowinx As Integer, _Item As Integer)
			Try
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select purch_price,sale_price,tax,discount from Currencies  where id= " + Conversions.ToString(_Item), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Me.dgvItems.Rows(_rowinx).Cells(3).Value = 1
				Catch ex As Exception
				End Try
				Try
					Me.LoadUnits(_Item)
				Catch ex2 As Exception
				End Try
				Dim flag As Boolean
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select group_id,unit from Currencies where id=" + Conversions.ToString(_Item), Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						Try
							Me.dgvItems.Rows(_rowinx).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1))
						Catch ex3 As Exception
						End Try
					End If
				Catch ex4 As Exception
				End Try
				Try
					Me.dgvItems.Rows(_rowinx).Cells(3).Value = Me.GetAvgPrice(_Item)
				Catch ex5 As Exception
				End Try
				Try
					Me.dgvItems.Rows(_rowinx).Cells(4).Value = Me.CalcStock(Conversions.ToInteger(Me.cmbSafe.SelectedValue), _Item)
				Catch ex6 As Exception
				End Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select barcode from currencies where id=" + Conversions.ToString(_Item), Me.conn1)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag = (dataTable3.Rows.Count > 0)
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0
					If flag2 Then
						Me.dgvItems.Rows(_rowinx).Cells(0).Value = dataTable3.Rows(0)(0).ToString()
					End If
				End If
			Catch ex7 As Exception
			End Try
		End Sub

		Private Sub BarcodeChanged(_rowinx As Integer, _barocode As String)
			Try
				Me.chkcurr = False
				Dim flag As Boolean = Operators.CompareString(_barocode.Trim(), "", False) <> 0
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,group_id,unit from currencies where IS_Deleted=0 and barcode='" + _barocode + "'", Me.conn1)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						Me.dgvItems.Rows(_rowinx).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
						Try
							flag = (dataTable.Rows(0)(2) IsNot DBNull.Value)
							If flag Then
								Me.dgvItems.Rows(_rowinx).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(2))
							End If
						Catch ex As Exception
						End Try
					Else
						sqlDataAdapter = New SqlDataAdapter("select currencies.id,group_id,curr_units.unit from currencies,curr_units where currencies.id=curr_units.curr and currencies.IS_Deleted=0 and curr_units.barcode='" + _barocode + "'", Me.conn1)
						dataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						flag = (dataTable.Rows.Count > 0)
						If flag Then
							Me.dgvItems.Rows(_rowinx).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
							Try
								flag = (dataTable.Rows(0)(2) IsNot DBNull.Value)
								If flag Then
									Me.dgvItems.Rows(_rowinx).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(2))
								End If
							Catch ex2 As Exception
							End Try
						Else
							sqlDataAdapter = New SqlDataAdapter("select currencies.id,group_id,currencies.unit from currencies,curr_barcodes where currencies.id=curr_barcodes.curr and currencies.IS_Deleted=0 and curr_barcodes.barcode='" + _barocode + "'", Me.conn1)
							dataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							flag = (dataTable.Rows.Count > 0)
							If flag Then
								Me.dgvItems.Rows(_rowinx).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
								Try
									flag = (dataTable.Rows(0)(2) IsNot DBNull.Value)
									If flag Then
										Me.dgvItems.Rows(_rowinx).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(2))
									End If
								Catch ex3 As Exception
								End Try
							End If
						End If
					End If
				End If
			Catch ex4 As Exception
			Finally
				Me.chkcurr = True
			End Try
		End Sub

		Private Sub LoadAccounts()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 and (acc_branch=" + Conversions.ToString(MainClass.BranchNo) + " or acc_branch is null )", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.cmbAccName.DataSource = dataTable
				Me.cmbAccName.DisplayMember = "AName"
				Me.cmbAccName.ValueMember = "Code"
				Me.cmbAccName.SelectedIndex = -1
			Catch ex As Exception
			End Try
		End Sub

  Private Sub frmM5znTransfer_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmM5znTransfer.Load
			Me.LoadNextNo()
			Me.LoadSafes()
			Me.LoadAccounts()
			Me.LoadAllItems()
			Me.LoadUnits()
			Me.txtDate.Value = DateTime.Now
			Me.txtFromDate.Value = DateTime.Now
			Me.txtToDate.Value = DateTime.Now
		End Sub

  Private Sub dgvItems_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellDoubleClick
		End Sub

  Private Sub dgvItems_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
			Try
				Dim flag As Boolean = e.ColumnIndex = 0
				If flag Then
					Me.BarcodeChanged(e.RowIndex, Conversions.ToString(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value))
				Else
					flag = (e.ColumnIndex = 1)
					If flag Then
						Me.ItemChanged(e.RowIndex, Conversions.ToInteger(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value))
					Else
						flag = (e.ColumnIndex = 2)
						If flag Then
							Me.UnitChanged(e.RowIndex, Conversions.ToInteger(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value), Conversions.ToInteger(Me.dgvItems.Rows(e.RowIndex).Cells(2).Value))
						Else
							flag = (e.ColumnIndex = 5)
							If flag Then
								Try
									Me.dgvItems.Rows(e.RowIndex).Cells(6).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(5).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(4).Value))
									Me.dgvItems.Rows(e.RowIndex).Cells(7).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)
									Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.perc from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value), " and curr_units.curr="), Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), Me.conn)
									Dim dataTable As DataTable = New DataTable()
									sqlDataAdapter.Fill(dataTable)
									flag = (dataTable.Rows.Count > 0)
									If flag Then
										Me.dgvItems.Rows(e.RowIndex).Cells(7).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
									End If
								Catch ex As Exception
								End Try
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			Finally
			End Try
		End Sub

  Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 8
				If flag Then
					Dim dialogResult As DialogResult = MessageBox.Show("هل تريد حذف السجل", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					flag = (dialogResult = DialogResult.Yes)
					If flag Then
						Me.dgvItems.Rows.Remove(Me.dgvItems.Rows(e.RowIndex))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim flag As Boolean = dr.HasRows
			If flag Then
				dr.Read()
				Me.dgvItems.Rows.Clear()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("no")))
				Me.txtDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", dr("date")))
				Me.txtRefNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("refno")))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
				Me.ResID = Conversions.ToInteger(dr("res_id"))
				Me.cmbSafe.SelectedValue = Operators.ConcatenateObject("", dr("safe"))
				Try
					Me.cmbAccName.SelectedValue = RuntimeHelpers.GetObjectValue(dr("acc"))
				Catch ex As Exception
				End Try
				Try
					flag = Operators.ConditionalCompareObjectNotEqual(dr("center"), -1, False)
					If flag Then
						Me.cmbCenter.SelectedValue = RuntimeHelpers.GetObjectValue(dr("center"))
					End If
				Catch ex2 As Exception
				End Try
				dr.Close()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from tsweya_sub where tsweya_id=" + Conversions.ToString(Me.Code), Me.conn)
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
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("item"))
					Me.dgvItems.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("unit"))
					Me.dgvItems.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("avg_price"))
					Me.dgvItems.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val1"))
					Me.dgvItems.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val2"))
					Me.dgvItems.Rows(num3).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("diff"))
					Me.dgvItems.Rows(num3).Cells(7).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("difftot"))
					num3 += 1
				End While
			End If
		End Sub

		Public Sub Navigate(sqlstr As String)
			Me.dgvItems.ClearSelection()
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
			Me.Navigate("select top 1 * from tsweya where IS_Deleted=0 order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from tsweya where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from tsweya where IS_Deleted=0 order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from tsweya where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

		Private Function GetSafeName(id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Safes where id=" + Conversions.ToString(id), Me.conn)
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

		Private Sub LoadDG(cond As String)
			Me.dgvSrch.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,no,date,safe,notes from tsweya where IS_Deleted=0 " + cond + " order by id", Me.conn)
			Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
			If flag Then
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.AddDays(1.0).ToShortDateString()
			End If
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
				Me.dgvSrch.Rows.Add()
				Me.dgvSrch.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Me.dgvSrch.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("no"))
				Me.dgvSrch.Rows(num3).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
				Me.dgvSrch.Rows(num3).Cells(3).Value = Me.GetSafeName(Conversions.ToInteger(dataTable.Rows(num3)("safe")))
				Me.dgvSrch.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("notes"))
				num3 += 1
			End While
			Me.dgvSrch.ClearSelection()
		End Sub

		Private Sub Search()
			Dim flag As Boolean = Operators.CompareString(Me.txtNoSrch.Text, "", False) <> 0
			Dim cond As String
			If flag Then
				cond = " and no=" + Me.txtNoSrch.Text
			Else
				flag = (Operators.CompareString(Me.txtRefNoSrch.Text, "", False) <> 0)
				If flag Then
					cond = " and refno='" + Me.txtRefNoSrch.Text + "' "
				Else
					cond = " and date>=@date1 and date<=@date2 "
				End If
			End If
			Me.LoadDG(cond)
		End Sub

  Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
			Dim flag As Boolean = e.RowIndex >= 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(e.RowIndex).Cells(0).Value))))
				Me.Navigate("select * from tsweya where id=" + Conversions.ToString(Me.Code))
				Me.TabControl1.SelectedIndex = 0
			End If
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Dim num As Integer = -1
			Dim flag As Boolean = Me.cmbCenter.SelectedValue IsNot Nothing
			If flag Then
				num = Conversions.ToInteger(Me.cmbCenter.SelectedValue)
			End If
			Dim frmCostCenter As frmCostCenter = New frmCostCenter()
			frmCostCenter.Activate()
			frmCostCenter.ShowDialog()
			Me.LoadCostCenter()
			Try
				Me.cmbCenter.SelectedValue = num
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.cmbSafe.SelectedIndex = -1
				If flag Then
					MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbSafe.Focus()
				Else
					flag = (Me.cmbAccName.SelectedValue Is Nothing)
					If flag Then
						MessageBox.Show("يجب اختيار الحساب", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbAccName.Focus()
					Else
						flag = (Me.dgvItems.Rows.Count = 1)
						If flag Then
							MessageBox.Show("يجب ادخال أصناف بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							flag = (Me.conn.State <> ConnectionState.Open)
							If flag Then
								Me.conn.Open()
							End If
							Dim sqlTransaction As SqlTransaction = Me.conn.BeginTransaction()
							Dim num As Integer = -1
							flag = (Me.cmbCenter.SelectedValue IsNot Nothing)
							If flag Then
								num = Conversions.ToInteger(Me.cmbCenter.SelectedValue)
							End If
							Dim sqlCommand As SqlCommand = New SqlCommand()
							Dim str As String = ""
							flag = (MainClass.BranchNo <> -1)
							If flag Then
								str = " where branch=" + Conversions.ToString(MainClass.BranchNo)
							End If
							flag = (Me.Code = -1)
							Dim num2 As Integer
							If flag Then
								sqlCommand = New SqlCommand("select max(id) from Restrictions " + str, Me.conn, sqlTransaction)
								num2 = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar())) + 1.0))
							Else
								num2 = Me.ResID
								sqlCommand = New SqlCommand("delete from Restrictions where id= " + Conversions.ToString(num2), Me.conn, sqlTransaction)
								sqlCommand.ExecuteNonQuery()
								sqlCommand = New SqlCommand("delete from Restrictions_Sub where res_id= " + Conversions.ToString(num2), Me.conn, sqlTransaction)
								sqlCommand.ExecuteNonQuery()
							End If
							flag = (Me.Code = -1)
							If flag Then
								sqlCommand = New SqlCommand("insert into tsweya(no,date,safe,refno,acc,center,notes,res_id,is_deleted)values(@no,@date,@safe,@refno,@acc,@center,@notes,@res_id,@is_deleted)", Me.conn, sqlTransaction)
							Else
								sqlCommand = New SqlCommand("update tsweya set date=@date,safe=@safe,refno=@refno,acc=@acc,center=@center,notes=@notes,res_id=@res_id where id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
							End If
							sqlCommand.Parameters.Add("@no", SqlDbType.Int).Value = Conversion.Val(Me.txtNo.Text)
							sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 1
							sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
							sqlCommand.Parameters.Add("@safe", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbSafe.SelectedValue)
							sqlCommand.Parameters.Add("@refno", SqlDbType.NVarChar).Value = Me.txtRefNo.Text
							sqlCommand.Parameters.Add("@acc", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbAccName.SelectedValue)
							sqlCommand.Parameters.Add("@center", SqlDbType.Int).Value = num
							sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
							sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num2
							sqlCommand.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0
							sqlCommand.ExecuteNonQuery()
							flag = (Me.Code = -1)
							If flag Then
								sqlCommand = New SqlCommand("select max(id) from tsweya", Me.conn, sqlTransaction)
								Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
							Else
								sqlCommand = New SqlCommand("delete from tsweya_sub where tsweya_id=" + Conversions.ToString(Me.Code), Me.conn, sqlTransaction)
								sqlCommand.ExecuteNonQuery()
							End If
							Dim num3 As Integer = 0
							Dim num4 As Integer = Me.dgvItems.Rows.Count - 2
							Dim num5 As Integer = num3
							While True
								Dim num6 As Integer = num5
								Dim num7 As Integer = num4
								If num6 > num7 Then
									Exit While
								End If
								sqlCommand = New SqlCommand("insert into tsweya_sub(tsweya_id,item,unit,avg_price,val1,val2,diff,difftot)values(@tsweya_id,@item,@unit,@avg_price,@val1,@val2,@diff,@difftot)", Me.conn, sqlTransaction)
								sqlCommand.Parameters.Add("@tsweya_id", SqlDbType.Int).Value = Me.Code
								sqlCommand.Parameters.Add("@item", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(1).Value)
								sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(2).Value)
								sqlCommand.Parameters.Add("@avg_price", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(3).Value)
								sqlCommand.Parameters.Add("@val1", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(4).Value)
								sqlCommand.Parameters.Add("@val2", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(5).Value)
								sqlCommand.Parameters.Add("@diff", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(6).Value)
								sqlCommand.Parameters.Add("@difftot", SqlDbType.Float).Value = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num5).Cells(7).Value)
								sqlCommand.ExecuteNonQuery()
								num5 += 1
							End While
							Dim num8 As Decimal = 0D
							Dim num9 As Integer = 0
							Dim num10 As Integer = Me.dgvItems.Rows.Count - 2
							Dim num11 As Integer = num9
							While True
								Dim num12 As Integer = num11
								Dim num7 As Integer = num10
								If num12 > num7 Then
									Exit While
								End If
								num8 = Decimal.Add(num8, Decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num11).Cells(3).Value)), Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num11).Cells(7).Value))))
								num11 += 1
							End While
							Dim num13 As Decimal = 0D
							Dim num14 As Decimal = 0D
							Dim num15 As Decimal = 0D
							Dim num16 As Decimal = 0D
							flag = (Decimal.Compare(num8, 0D) < 0)
							If flag Then
								num13 = 0D
								num14 = Math.Round(Math.Abs(num8), 2)
								num15 = Math.Round(Math.Abs(num8), 2)
								num16 = 0D
							Else
								num13 = Math.Round(Math.Abs(num8), 2)
								num14 = 0D
								num15 = 0D
								num16 = Math.Round(Math.Abs(num8), 2)
							End If
							sqlCommand = New SqlCommand("insert into Restrictions(id,date,doc_no,type,state,notes,branch,IS_Deleted)values(@id,@date,@doc_no,@type,@state,@notes,@branch,@IS_Deleted)", Me.conn, sqlTransaction)
							sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = num2
							sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
							sqlCommand.Parameters.Add("@doc_no", SqlDbType.Int).Value = Me.txtNo.Text
							sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = 10
							sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = 1
							sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "أمر تسوية مخزون رقم " + Me.txtNo.Text
							sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
							sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
							sqlCommand.ExecuteNonQuery()
							Dim num17 As Integer = 1270001
							flag = MainClass.IsAccTreeNew
							If flag Then
								num17 = 1103030001
							End If
							sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
							sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num2
							sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = num13
							sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = num14
							sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = num17
							sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "أمر تسوية مخزون رقم " + Me.txtNo.Text
							sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
							sqlCommand.ExecuteNonQuery()
							sqlCommand = New SqlCommand("insert into Restrictions_Sub(res_id,dept,credit,acc_no,notes,branch)values(@res_id,@dept,@credit,@acc_no,@notes,@branch)", Me.conn, sqlTransaction)
							sqlCommand.Parameters.Add("@res_id", SqlDbType.Int).Value = num2
							sqlCommand.Parameters.Add("@dept", SqlDbType.Float).Value = num15
							sqlCommand.Parameters.Add("@credit", SqlDbType.Float).Value = num16
							sqlCommand.Parameters.Add("@acc_no", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbAccName.SelectedValue)
							sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = "أمر تسوية مخزون رقم " + Me.txtNo.Text
							sqlCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
							sqlCommand.ExecuteNonQuery()
							sqlTransaction.Commit()
							Me.CLR()
						End If
					End If
				End If
			Catch ex As Exception
				Dim sqlTransaction As SqlTransaction
				sqlTransaction.Rollback()
				Dim text As String = "خطأ أثناء الحفظ"
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag Then
					text = "error in saving"
				End If
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Else
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update tsweya set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					sqlCommand = New SqlCommand("update Restrictions set state=2 where id=" + Conversions.ToString(Me.ResID), Me.conn)
					sqlCommand.ExecuteNonQuery()
					flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag2 Then
						MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.CLR()
				Else
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						MessageBox.Show("اختر سجل ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Select Record to be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text = "Error in deleting"
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Function GetAvgPrice(item As Integer) As Decimal
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=" + Conversions.ToString(item) + " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(1).ToString(), "", False) <> 0
				If flag Then
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1)))
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select sum(val),sum(val1*exchange_price) from inv,inv_sub where currency_from=" + Conversions.ToString(item) + " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0", Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(1).ToString(), "", False) <> 0)
				If flag Then
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1)))
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				sqlDataAdapter = New SqlDataAdapter("select sum(totquan),sum(quan*price) from Twreed_Srf,Twreed_Srf_sub where item=" + Conversions.ToString(item) + " and type=1 and Twreed_Srf.id=Twreed_Srf_sub.proc_id and IS_Deleted=0", Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(1).ToString(), "", False) <> 0)
				If flag Then
					num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1)))
					num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
				flag = (num2 <> 0.0)
				If flag Then
					num3 = num / num2
					num3 = Math.Floor(num3 * 100000000.0)
					num3 /= 100000000.0
				Else
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select purch_price from currencies where id=" + Conversions.ToString(item), Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					num3 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
				End If
			Catch ex As Exception
			End Try
			Return New Decimal(Math.Round(num3, 2))
		End Function

  Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
			Me.Search()
		End Sub

  Private Sub dgvItems_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
		End Sub

		Private Function GetCurrencyName(id As Integer) As String
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol from Currencies where id=" + Conversions.ToString(id), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		End Function

		Private Function GetUnitName(id As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from units where id=" + Conversions.ToString(id), Me.conn1)
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

		Private Sub PrintRpt(type As Integer)
			Dim flag As Boolean = Me.dgvItems.Rows.Count = 1
			If flag Then
				MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbSafe.Focus()
			Else
				Dim dataTable As DataTable = New DataTable()
				dataTable.Columns.Add("DataColumn1")
				dataTable.Columns.Add("Currency1")
				dataTable.Columns.Add("Currency2")
				dataTable.Columns.Add("Price")
				dataTable.Columns.Add("Value1")
				dataTable.Columns.Add("Value2")
				dataTable.Columns.Add("DataColumn11")
				Dim num As Integer = 0
				Dim num2 As Integer = Me.dgvItems.Rows.Count - 2
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), Me.GetCurrencyName(Conversions.ToInteger(Me.dgvItems.Rows(num3).Cells(1).Value)), Me.GetUnitName(Conversions.ToInteger(Me.dgvItems.Rows(num3).Cells(2).Value)), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value) })
					num3 += 1
				End While
				Dim rptTsweya As rptTsweya = New rptTsweya()
				rptTsweya.SetDataSource(dataTable)
				Dim textObject As TextObject = CType(rptTsweya.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
				textObject.Text = Me.txtNo.Text
				Dim textObject2 As TextObject = CType(rptTsweya.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
				textObject2.Text = Me.txtDate.Value.ToShortDateString()
				Dim textObject3 As TextObject = CType(rptTsweya.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
				textObject3.Text = Me.cmbSafe.Text
				Dim textObject4 As TextObject = CType(rptTsweya.ReportDefinition.Sections(1).ReportObjects("notes"), TextObject)
				textObject4.Text = Me.txtNotes.Text
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				rptTsweya.Subreports("rptHeader").SetDataSource(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim textObject5 As TextObject = CType(rptTsweya.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(rptTsweya.ReportDefinition.Sections(5).ReportObjects("txttel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("tel")))
					Dim textObject7 As TextObject = CType(rptTsweya.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = rptTsweya
				frmRptViewer.WindowState = FormWindowState.Maximized
				Me.btnSave_Click(Nothing, Nothing)
				flag = (type = 1)
				If flag Then
					frmRptViewer.Show()
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						rptTsweya.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub txtAccCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAccCode.TextChanged
			Try
				Me.cmbAccName.SelectedValue = Me.txtAccCode.Text
			Catch ex As Exception
			End Try
		End Sub

  Private Sub cmbAccName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccName.SelectedIndexChanged
			Try
				Me.txtAccCode.Text = Conversions.ToString(Me.cmbAccName.SelectedValue)
			Catch ex As Exception
			End Try
		End Sub
	End Class
