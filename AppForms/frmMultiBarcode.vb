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
	Public Partial Class frmMultiBarcode
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmMultiBarcode_Load
			frmMultiBarcode.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmMultiBarcode.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmMultiBarcode.__ENCList.Count = frmMultiBarcode.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmMultiBarcode.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmMultiBarcode.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmMultiBarcode.__ENCList(num) = frmMultiBarcode.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmMultiBarcode.__ENCList.RemoveRange(num, frmMultiBarcode.__ENCList.Count - num)
				frmMultiBarcode.__ENCList.Capacity = frmMultiBarcode.__ENCList.Count
			End If
			frmMultiBarcode.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Public Sub LoadDG()
			' The following expression was wrapped in a checked-statement
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from curr_barcodes where curr=" + Conversions.ToString(Conversion.Val(Me.txtNo.Text)), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.dgvData.Rows.Clear()
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					Me.dgvData.Rows.Add()
					Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("barcode"))
					num3 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtBarcode.Text.Trim(), "", False) = 0
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						Interaction.MsgBox("ادخل الباركود", MsgBoxStyle.OkOnly, Nothing)
					Else
						Interaction.MsgBox("Enter barcode", MsgBoxStyle.OkOnly, Nothing)
					End If
					Me.txtBarcode.Focus()
				Else
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("insert into curr_barcodes(curr,barcode)values(@curr,@barcode)", Me.conn)
					sqlCommand.Parameters.Add("@curr", SqlDbType.Int).Value = Conversion.Val(Me.txtNo.Text)
					sqlCommand.Parameters.Add("@barcode", SqlDbType.NVarChar).Value = Me.txtBarcode.Text
					sqlCommand.ExecuteNonQuery()
					Me.txtBarcode.Text = ""
					Me.txtBarcode.Focus()
					Me.LoadDG()
					flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag2 Then
						Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
					Else
						Interaction.MsgBox("Saved", MsgBoxStyle.OkOnly, Nothing)
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text = "error in saving"
					text = text + Environment.NewLine + "error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 1
				If flag Then
					Try
						Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
						If flag2 Then
							Me.conn.Open()
						End If
						Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from curr_barcodes where curr=" + Conversions.ToString(Conversion.Val(Me.txtNo.Text)) + " and barcode='", Me.dgvData.Rows(e.RowIndex).Cells(0).Value), "'")), Me.conn)
						sqlCommand.ExecuteNonQuery()
						Me.txtBarcode.Focus()
						Me.LoadDG()
						flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
						If flag2 Then
							Interaction.MsgBox("تم الحذف", MsgBoxStyle.OkOnly, Nothing)
						Else
							Interaction.MsgBox("Deleted", MsgBoxStyle.OkOnly, Nothing)
						End If
					Catch ex As Exception
						Dim text As String = "خطأ أثناء الحذف"
						text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
						Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
						If flag2 Then
							text = "error in deleting"
							text = text + Environment.NewLine + "error details: " + ex.Message
						End If
						MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Finally
						Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
						If flag2 Then
							Me.conn.Close()
						End If
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub frmMultiBarcode_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmMultiBarcode.Load
			Me.txtBarcode.Focus()
		End Sub
	End Class
