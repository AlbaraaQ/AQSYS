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
	Public Partial Class frmSelectClient
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSelectClient_Load
			frmSelectClient.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSelectClient.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSelectClient.__ENCList.Count = frmSelectClient.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSelectClient.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSelectClient.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSelectClient.__ENCList(num) = frmSelectClient.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSelectClient.__ENCList.RemoveRange(num, frmSelectClient.__ENCList.Count - num)
					frmSelectClient.__ENCList.Capacity = frmSelectClient.__ENCList.Count
				End If
				frmSelectClient.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Function GetAccountNo(_name As String) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where AName='" + _name + "'", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return dataTable.Rows(0)("Code").ToString()
				End If
			Catch ex As Exception
			End Try
			Return ""
		End Function

		Private Sub LoadData()
			' The following expression was wrapped in a checked-statement
			Try
				Me.dgvData.Rows.Clear()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name,type from customers where is_deleted=0", Me.conn)
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
					Dim value As String = ""
					Dim flag As Boolean = False
					Dim flag2 As Boolean = Me.rdAll.Checked
					Dim flag3 As Boolean
					If flag2 Then
						flag = True
						Try
							flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num3)("type"), 1, False)
							If flag2 Then
								value = "عميل"
							Else
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num3)("type"), 2, False)
								If flag2 Then
									value = "مورد"
								End If
							End If
						Catch ex As Exception
						End Try
					Else
						flag2 = Me.rdClient.Checked
						If flag2 Then
							flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num3)("type"), 1, False)
							If flag3 Then
								flag = True
								value = "عميل"
							End If
						Else
							flag3 = Me.rdSupplier.Checked
							If flag3 Then
								flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num3)("type"), 2, False)
								If flag2 Then
									flag = True
									value = "مورد"
								End If
							End If
						End If
					End If
					flag3 = flag
					If flag3 Then
						Me.dgvData.Rows.Add()
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(1).Value = value
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(2).Value = Me.GetAccountNo(dataTable.Rows(num3)("name").ToString())
						Me.dgvData.Rows(Me.dgvData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
					End If
					num3 += 1
				End While
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub frmSelectClient_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSelectClient.Load
			Me.LoadData()
		End Sub

  Private Sub rdAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdAll.CheckedChanged
			Me.LoadData()
		End Sub

  Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 4
				If flag Then
					frmCustomers._selectedacc = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvData.Rows(e.RowIndex).Cells(2).Value))
					Me.Close()
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
