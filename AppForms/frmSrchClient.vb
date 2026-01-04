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
	Public Partial Class frmSrchClient
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Public _type As Integer

		Public Form_Type As Integer

		Public frm1 As frmSalePurch

		Public frm2 As frmInvSumByClient

		Public frm3 As frmCustAccount

		Public frm4 As frmCustAccountGet

		Public frm5 As frmCustLastPay

		Public frm6 As frmRptClientMaintDetails

		Public frm7 As frmSalePurchRest

		Public frm8 As frmNkdTotSalePurchActCust

		Public frm9 As frmSandD

		Public frm10 As frmSandQ
		Shared Sub New()
		End Sub

		Public Sub New()
			frmSrchClient.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._type = -1
			Me.Form_Type = -1
			Me.frm1 = Nothing
			Me.frm2 = Nothing
			Me.frm3 = Nothing
			Me.frm4 = Nothing
			Me.frm5 = Nothing
			Me.frm6 = Nothing
			Me.frm7 = Nothing
			Me.frm8 = Nothing
			Me.frm9 = Nothing
			Me.frm10 = Nothing
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSrchClient.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSrchClient.__ENCList.Count = frmSrchClient.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSrchClient.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSrchClient.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSrchClient.__ENCList(num) = frmSrchClient.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSrchClient.__ENCList.RemoveRange(num, frmSrchClient.__ENCList.Count - num)
					frmSrchClient.__ENCList.Capacity = frmSrchClient.__ENCList.Count
				End If
				frmSrchClient.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub txtCustNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtName.TextChanged
		' The following expression was wrapped in a checked-statement
		Try
			Dim text As String = ""
			Dim flag As Boolean = Me._type <> -1
			If flag Then
				text = " type = " + Conversions.ToString(Me._type) + " and "
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select * from customers where ", text, " name like '%", Me.txtName.Text, "%' and is_deleted=0 order by id"}), Me.conn)
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
				Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
				num3 += 1
			End While
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
			Try
				Dim flag As Boolean = e.ColumnIndex = 2
				If flag Then
					Dim flag2 As Boolean = Me.Form_Type = 1
					If flag2 Then
						Me.frm1.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
					Else
						flag2 = (Me.Form_Type = 2)
						If flag2 Then
							Me.frm2.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
						Else
							flag2 = (Me.Form_Type = 3)
							If flag2 Then
								Me.frm3.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
							Else
								flag2 = (Me.Form_Type = 4)
								If flag2 Then
									Me.frm4.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
								Else
									flag2 = (Me.Form_Type = 5)
									If flag2 Then
										Me.frm5.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
									Else
										flag2 = (Me.Form_Type = 6)
										If flag2 Then
											Me.frm6.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
										Else
											flag2 = (Me.Form_Type = 7)
											If flag2 Then
												Me.frm7.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
											Else
												flag2 = (Me.Form_Type = 8)
												If flag2 Then
													Me.frm8.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
												Else
													flag2 = (Me.Form_Type = 9)
													If flag2 Then
														Me.frm9.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
													Else
														flag2 = (Me.Form_Type = 10)
														If flag2 Then
															Me.frm10.ClientID = Conversions.ToInteger(Me.dgvData.Rows(e.RowIndex).Cells(0).Value)
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
					Me.Close()
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
