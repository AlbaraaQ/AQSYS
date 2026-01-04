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
	Public Partial Class frmOffers2
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmOffers2_Load
			frmOffers2.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmOffers2.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmOffers2.__ENCList.Count = frmOffers2.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmOffers2.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmOffers2.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmOffers2.__ENCList(num) = frmOffers2.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmOffers2.__ENCList.RemoveRange(num, frmOffers2.__ENCList.Count - num)
					frmOffers2.__ENCList.Capacity = frmOffers2.__ENCList.Count
				End If
				frmOffers2.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.dgvItems.Rows.Count = 1
				If flag Then
					Interaction.MsgBox("الجدول فارغ", MsgBoxStyle.OkOnly, Nothing)
				Else
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("delete from offers2", Me.conn)
					sqlCommand.ExecuteNonQuery()
					Dim num As Integer = 0
					Dim num2 As Integer = Me.dgvItems.Rows.Count - 2
					Dim num3 As Integer = num
					While True
						Dim num4 As Integer = num3
						Dim num5 As Integer = num2
						If num4 > num5 Then
							Exit While
						End If
						sqlCommand = New SqlCommand("insert into offers2(quan,price)values(@quan,@price)", Me.conn)
						sqlCommand.Parameters.Add("@quan", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(0).Value))
						sqlCommand.Parameters.Add("@price", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(1).Value))
						sqlCommand.ExecuteNonQuery()
						num3 += 1
					End While
					Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			Finally
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub frmOffers2_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmOffers2.Load
			' The following expression was wrapped in a checked-statement
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from offers2", Me.conn)
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
					Me.dgvItems.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("quan"))
					Me.dgvItems.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("price"))
					num3 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

  Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 2
				If flag Then
					Me.dgvItems.Rows.RemoveAt(e.RowIndex)
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
