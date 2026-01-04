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
	Public Partial Class frmOffers
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmOffers_Load
			frmOffers.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmOffers.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmOffers.__ENCList.Count = frmOffers.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmOffers.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmOffers.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmOffers.__ENCList(num) = frmOffers.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmOffers.__ENCList.RemoveRange(num, frmOffers.__ENCList.Count - num)
					frmOffers.__ENCList.Capacity = frmOffers.__ENCList.Count
				End If
				frmOffers.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub LoadAllCurrency()
			Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvItems.Columns(0), DataGridViewComboBoxColumn)
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where IS_Deleted=0 order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			dataGridViewComboBoxColumn.DataSource = dataTable
			dataGridViewComboBoxColumn.DisplayMember = "symbol"
			dataGridViewComboBoxColumn.ValueMember = "id"
		End Sub

		Private Sub LoadUnits()
			Try
				Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvItems.Columns(1), DataGridViewComboBoxColumn)
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from units order by id", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				dataGridViewComboBoxColumn.DataSource = dataTable
				dataGridViewComboBoxColumn.DisplayMember = "name"
				dataGridViewComboBoxColumn.ValueMember = "id"
			Catch ex As Exception
			End Try
		End Sub

  Private Sub frmOffers_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmOffers.Load
			Me.dgvItems.Columns(6).DisplayIndex = 0
			Me.LoadAllCurrency()
			Me.LoadUnits()
		End Sub

		Private Sub CLR()
			Me.Code = -1
			Me.dgvItems.Rows.Clear()
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update offers set is_deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.CLR()
				Else
					MessageBox.Show("اختر عرض ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحذف"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.dgvItems.Rows.Count = 1
				If flag Then
					Interaction.MsgBox("يجب ادخال الأصناف المشمولة بالعرض بالجدول", MsgBoxStyle.OkOnly, Nothing)
				Else
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag = (Me.Code = -1)
					If flag Then
						sqlCommand = New SqlCommand("insert into offers(date,is_deleted)values(@date,@is_deleted)", Me.conn)
						sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
						sqlCommand.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0
						sqlCommand.ExecuteNonQuery()
					Else
						sqlCommand = New SqlCommand("delete from offers_sub where offer_id=" + Conversions.ToString(Me.Code), Me.conn)
						sqlCommand.ExecuteNonQuery()
					End If
					flag = (Me.Code = -1)
					If flag Then
						sqlCommand = New SqlCommand("select max(id) from offers", Me.conn)
						Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
					End If
					Dim num As Integer = 0
					Dim num2 As Integer = Me.dgvItems.Rows.Count - 2
					Dim num3 As Integer = num
					While True
						Dim num4 As Integer = num3
						Dim num5 As Integer = num2
						If num4 > num5 Then
							Exit While
						End If
						sqlCommand = New SqlCommand("insert into offers_sub(offer_id,item,unit,quan,price,disc,net)values(@offer_id,@item,@unit,@quan,@price,@disc,@net)", Me.conn)
						sqlCommand.Parameters.Add("@offer_id", SqlDbType.Int).Value = Me.Code
						sqlCommand.Parameters.Add("@item", SqlDbType.Int).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(0).Value))
						sqlCommand.Parameters.Add("@unit", SqlDbType.Int).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(1).Value))
						sqlCommand.Parameters.Add("@quan", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
						sqlCommand.Parameters.Add("@price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(3).Value))
						sqlCommand.Parameters.Add("@disc", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(4).Value))
						sqlCommand.Parameters.Add("@net", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(5).Value))
						sqlCommand.ExecuteNonQuery()
						num3 += 1
					End While
					MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.CLR()
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub dgvItems_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
		End Sub

  Private Sub dgvItems_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
			Try
				Dim flag As Boolean = e.ColumnIndex = 0
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sale_price,unit from Currencies  where id= ", Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Me.dgvItems.Rows(e.RowIndex).Cells(2).Value = 1
					Me.dgvItems.Rows(e.RowIndex).Cells(3).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("sale_price")))
					Try
						Me.dgvItems.Rows(e.RowIndex).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("unit"))
					Catch ex As Exception
					End Try
				Else
					flag = (e.ColumnIndex = 1)
					If flag Then
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sale_price,unit from Currencies  where unit=", Me.dgvItems.Rows(e.RowIndex).Cells(1).Value), " and id= "), Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag = (dataTable2.Rows.Count > 0)
						If flag Then
							Dim num As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sale_price")))
							Me.dgvItems.Rows(e.RowIndex).Cells(3).Value = num
						Else
							sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.purch,curr_units.sale,curr_units.unit from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.dgvItems.Rows(e.RowIndex).Cells(1).Value), " and curr_units.curr= "), Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
							dataTable2 = New DataTable()
							sqlDataAdapter2.Fill(dataTable2)
							flag = (dataTable2.Rows.Count > 0)
							If flag Then
								Me.dgvItems.Rows(e.RowIndex).Cells(3).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sale")))
							Else
								sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sale_price,unit from Currencies  where id= ", Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), Me.conn)
								dataTable2 = New DataTable()
								sqlDataAdapter2.Fill(dataTable2)
								Me.dgvItems.Rows(e.RowIndex).Cells(3).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("sale_price")))
							End If
						End If
					Else
						flag = (e.ColumnIndex = 4)
						If flag Then
							Me.dgvItems.Rows(e.RowIndex).Cells(5).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(4).Value))
						Else
							flag = (e.ColumnIndex = 6)
							If flag Then
								Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(6).Value), "", False)
								If Not flag2 Then
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from currencies where barcode='", Me.dgvItems.Rows(e.RowIndex).Cells(6).Value), "'")), Me.conn)
									Dim dataTable3 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable3)
									flag2 = (dataTable3.Rows.Count > 0)
									If flag2 Then
										Me.dgvItems.Rows(e.RowIndex).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("id"))
									Else
										sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from currencies,curr_units where currencies.id=curr_units.curr and curr_units.barcode='", Me.dgvItems.Rows(e.RowIndex).Cells(6).Value), "'")), Me.conn)
										dataTable3 = New DataTable()
										sqlDataAdapter3.Fill(dataTable3)
										flag2 = (dataTable3.Rows.Count > 0)
										If flag2 Then
											Me.dgvItems.Rows(e.RowIndex).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("id"))
										Else
											sqlDataAdapter3 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from currencies,curr_barcodes where currencies.id=curr_barcodes.curr and curr_barcodes.barcode='", Me.dgvItems.Rows(e.RowIndex).Cells(6).Value), "'")), Me.conn)
											dataTable3 = New DataTable()
											sqlDataAdapter3.Fill(dataTable3)
											flag2 = (dataTable3.Rows.Count > 0)
											If flag2 Then
												Me.dgvItems.Rows(e.RowIndex).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("id"))
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				Me.CLR()
				dr.Read()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				dr.Close()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from offers_sub where offer_id=" + Conversions.ToString(Me.Code), Me.conn)
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
					Me.dgvItems.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("item"))
					Me.dgvItems.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("unit"))
					Me.dgvItems.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("quan"))
					Me.dgvItems.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("price"))
					Me.dgvItems.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("disc"))
					Me.dgvItems.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("net"))
					num3 += 1
				End While
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
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
			Me.Navigate("select top 1 * from offers where is_deleted=0 order by id desc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from offers where is_deleted=0 order by id asc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from offers  where is_deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from offers  where is_deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub

  Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
		End Sub
	End Class
