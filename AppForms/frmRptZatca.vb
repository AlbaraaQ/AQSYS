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
	Public Partial Class frmRptZatca
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private _finished As Boolean
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frm_Load
			frmRptZatca.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me._finished = False
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptZatca.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptZatca.__ENCList.Count = frmRptZatca.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptZatca.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptZatca.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptZatca.__ENCList(num) = frmRptZatca.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptZatca.__ENCList.RemoveRange(num, frmRptZatca.__ENCList.Count - num)
					frmRptZatca.__ENCList.Capacity = frmRptZatca.__ENCList.Count
				End If
				frmRptZatca.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
		Me._finished = False
		Me.Button1.Enabled = False
		Me.dgvItems.ScrollBars = ScrollBars.None
		Me.timer1.Enabled = True
		'Dim thread As Thread = AddressOf Me.ShowResult
		Dim thread As New Thread(AddressOf Me.ShowResult)
		thread.Start()
	End Sub

	Private Sub ShowResult()
		' The following expression was wrapped in a checked-statement
		Try
			Dim str As String = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			Dim text As String = ""
			Dim flag As Boolean = Me.rdSuccess.Checked
			If flag Then
				text += " (status_code='200' or status_code='201' or status_code='202') and "
			Else
				flag = Me.rdFail.Checked
				If flag Then
					text += " (status_code<>'' and status_code<>'200' and status_code<>'201' and status_code<>'202') and "
				Else
					flag = Me.rdNotInteg.Checked
					If flag Then
						text += " (status_code='' or status_code is null) and "
					End If
				End If
			End If
			flag = Me.chkWar.Checked
			If flag Then
				text += " (war_msg<>'') and "
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Inv where " + str + text + " date>=@date1 and date<=@date2 and (proc_type=1 or proc_type=2) and (tawla_paid is null or tawla_paid=1) and is_buy=0 and Inv.IS_Deleted=0 order by date", Me.conn)
			sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
			sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.dgvItems.Rows.Clear()
			Me.ProgressBar1.Value = 0
			Me.ProgressBar1.Maximum = dataTable.Rows.Count
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim flag2 As Boolean = True
				flag = flag2
				If flag Then
					Dim value As String = ""
					flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("proc_type"))) = 1.0)
					If flag Then
						value = "بيع"
						flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag Then
							value = "Sales"
						End If
					Else
						flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("proc_type"))) = 2.0)
						If flag Then
							value = "مرتجع بيع"
							flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
							If flag Then
								value = "Ret. Sales"
							End If
						End If
					End If
					Dim value2 As String = ""
					flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("status_code")), "", False)
					If flag Then
						Dim flag3 As Boolean = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("status_code")), "200", False), Operators.CompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("status_code")), "201", False)), Operators.CompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(num3)("status_code")), "202", False)))
						If flag3 Then
							value2 = "نجاح"
							flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
							If flag3 Then
								value2 = "Success"
							End If
						Else
							value2 = "فشل"
							flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
							If flag3 Then
								value2 = "Fail"
							End If
						End If
					End If
					Me.dgvItems.Rows.Add()
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("proc_id"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = value
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToString("dd/MM/yyyy  hh:mm tt")
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tot_net"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("minus"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tot_sale"))), 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tot_net"))), 2)
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("status_code"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = value2
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(8).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("uuid"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(9).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("war_msg"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(10).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("err_msg"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(11).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("InvoiceHash"))
					Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(12).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("EncodedInvoice"))
				End If
				Me.ProgressBar1.Value = num3 + 1
				num3 += 1
			End While
		Catch ex As Exception
		End Try
		Me._finished = True
	End Sub

 Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frm.Load
		Control.CheckForIllegalCrossThreadCalls = False
		Try
			Me.dgvItems.Columns(14).DisplayIndex = 0
		Catch ex As Exception
		End Try
		Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
		Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.AddDays(1.0).ToShortDateString())
	End Sub

	Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
		Try
			Dim flag As Boolean = e.ColumnIndex = 13
			If flag Then
				flag = (Me.rdInvSales.Checked Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "مرتجع بيع", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "Ret. Sales", False) = 0)
				If flag Then
					Dim frmSalePurch As frmSalePurch = New frmSalePurch()
					frmSalePurch.InvProc = 2
					flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "مرتجع بيع", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "Ret. Sales", False) = 0)
					If flag Then
					End If
					Try
						flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "200", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "201", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "202", False) <> 0)
						If flag Then
							frmSalePurch._IsReAPI = True
						End If
					Catch ex As Exception
					End Try
					frmSalePurch.Show()
					frmSalePurch.WindowState = FormWindowState.Maximized
					frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)))
					frmSalePurch.Activate()
				Else
					Dim frmSalePurchRest As frmSalePurchRest = New frmSalePurchRest()
					frmSalePurchRest.InvProc = 2
					Try
						flag = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "200", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "201", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(6).Value)), "202", False) <> 0)
						If flag Then
							frmSalePurchRest._IsReAPI = True
						End If
					Catch ex2 As Exception
					End Try
					frmSalePurchRest.Show()
					frmSalePurchRest.WindowState = FormWindowState.Maximized
					frmSalePurchRest.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)))
					frmSalePurchRest.Activate()
				End If
			End If
		Catch ex3 As Exception
		End Try
	End Sub

 Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
		Dim finished As Boolean = Me._finished
		If finished Then
			Me._finished = False
			Me.Button1.Enabled = True
			Me.dgvItems.ScrollBars = ScrollBars.Both
			Me.timer1.Enabled = False
		End If
	End Sub

 Private Sub dgvItems_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
	End Sub

	Private Sub IntegSelected1()
		' The following expression was wrapped in a checked-statement
		Try
			Dim frmSalePurch As frmSalePurch = New frmSalePurch()
			frmSalePurch.InvProc = 2
			frmSalePurch.LoadData()
			Me.ProgressBar1.Value = 0
			Me.ProgressBar1.Maximum = Me.dgvItems.Rows.Count
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvItems.Rows(num3).Cells(14).Value, 1, False)
				If flag Then
					Try
						Dim flag2 As Boolean = Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "200", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "201", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "202", False) <> 0
						If flag2 Then
							frmSalePurch._IsReAPI = True
							flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value)), "مرتجع بيع", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value)), "Ret. Sales", False) = 0)
							If flag2 Then
							End If
							frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(num3).Cells(0).Value)))
							frmSalePurch.btnSave_Click(Nothing, Nothing)
						End If
					Catch ex As Exception
					End Try
				End If
				Me.ProgressBar1.Value = num3 + 1
				num3 += 1
			End While
			Interaction.MsgBox("تم الإنتهاء", MsgBoxStyle.OkOnly, Nothing)
		Catch ex2 As Exception
		Finally
			Me._finished = True
		End Try
	End Sub

	Private Sub IntegSelected2()
		' The following expression was wrapped in a checked-statement
		Try
			Dim frmSalePurchRest As frmSalePurchRest = New frmSalePurchRest()
			frmSalePurchRest.InvProc = 2
			frmSalePurchRest.LoadData()
			Me.ProgressBar1.Value = 0
			Me.ProgressBar1.Maximum = Me.dgvItems.Rows.Count
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvItems.Rows(num3).Cells(14).Value, 1, False)
				If flag Then
					Try
						Dim flag2 As Boolean = Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "200", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "201", False) <> 0 And Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)), "202", False) <> 0
						If flag2 Then
							frmSalePurchRest._IsReAPI = True
							flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value)), "مرتجع بيع", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value)), "Ret. Sales", False) = 0)
							If flag2 Then
								Dim frmSalePurch As frmSalePurch = New frmSalePurch()
								frmSalePurch.InvProc = 2
								frmSalePurch.LoadData()
								frmSalePurch._IsReAPI = True
								frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(num3).Cells(0).Value)))
								frmSalePurch.btnSave_Click(Nothing, Nothing)
							Else
								frmSalePurchRest.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_id=", Me.dgvItems.Rows(num3).Cells(0).Value)))
								frmSalePurchRest.btnSave_Click(Nothing, Nothing)
							End If
						End If
					Catch ex As Exception
					End Try
				End If
				Me.ProgressBar1.Value = num3 + 1
				num3 += 1
			End While
			Interaction.MsgBox("تم الإنتهاء", MsgBoxStyle.OkOnly, Nothing)
		Catch ex2 As Exception
		Finally
			Me._finished = True
		End Try
	End Sub

	Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Me.txtDateFrom.Focus()
		Me.Button1.Enabled = False
		Me._finished = False
		Me.timer1.Enabled = True
		Dim checked As Boolean = Me.rdInvSales.Checked
		If checked Then
			'Dim thread As Thread = AddressOf Me.IntegSelected1
			Dim thread As New Thread(AddressOf Me.IntegSelected1)
			thread.SetApartmentState(ApartmentState.STA)
			thread.Start()
		Else
			checked = Me.rdInvRest.Checked
			If checked Then
				Dim thread2 As New Thread(AddressOf Me.IntegSelected2)
				thread2.SetApartmentState(ApartmentState.STA)
				thread2.Start()
			End If
		End If
	End Sub

	Private Sub chkSelectAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSelectAll.CheckedChanged
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim checked As Boolean = Me.chkSelectAll.Checked
				If checked Then
					num = 1
				End If
				Dim num2 As Integer = 0
				Dim num3 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Me.dgvItems.Rows(num4).Cells(14).Value = num
					num4 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub
	End Class
