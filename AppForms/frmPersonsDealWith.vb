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
	Public Partial Class frmPersonsDealWith
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private conn1 As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmPersonsDealWith_Load
			frmPersonsDealWith.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.conn1 = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmPersonsDealWith.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmPersonsDealWith.__ENCList.Count = frmPersonsDealWith.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmPersonsDealWith.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmPersonsDealWith.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmPersonsDealWith.__ENCList(num) = frmPersonsDealWith.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmPersonsDealWith.__ENCList.RemoveRange(num, frmPersonsDealWith.__ENCList.Count - num)
					frmPersonsDealWith.__ENCList.Capacity = frmPersonsDealWith.__ENCList.Count
				End If
				frmPersonsDealWith.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			MainClass.CLRForm(Me)
			Me.Code = -1
		End Sub

		Private Sub LoadDG()
			Me.dgvPersons.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from DealPersons order by id", Me.conn)
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
				Me.dgvPersons.Rows.Add()
				Me.dgvPersons.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Me.dgvPersons.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
				Me.dgvPersons.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
				Me.dgvPersons.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
				Me.dgvPersons.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(Me.GetJobName(Conversions.ToInteger(dataTable.Rows(num3)("job"))))
				num3 += 1
			End While
			Me.dgvPersons.ClearSelection()
		End Sub

		Public Function GetJobName(job As Integer) As Object
			Dim result As Object
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from jobs where id=" + Conversions.ToString(job), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					result = Operators.ConcatenateObject("", dataTable.Rows(0)(0))
				Else
					result = ""
				End If
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		Public Sub LoadJobs()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from jobs order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbJob.DataSource = dataTable
			Me.cmbJob.DisplayMember = "name"
			Me.cmbJob.ValueMember = "id"
			Me.cmbJob.SelectedIndex = -1
		End Sub

  Private Sub btnJobAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJobAdd.Click
			Dim num As Integer = -1
			Dim flag As Boolean = Me.cmbJob.SelectedValue IsNot Nothing
			If flag Then
				num = Conversions.ToInteger(Me.cmbJob.SelectedValue)
			End If
			Dim frmJobs As frmJobs = New frmJobs()
			frmJobs.Activate()
			frmJobs.ShowDialog()
			Me.LoadJobs()
			Try
				Me.cmbJob.SelectedValue = num
			Catch ex As Exception
			End Try
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub frmPersonsDealWith_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmPersonsDealWith.Load
			Me.LoadJobs()
			Me.LoadDG()
			Me.WindowState = MainClass.Window_State
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
				If flag Then
					MessageBox.Show("يجب ادخال اسم الجهة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtName.Focus()
				Else
					Dim num As Integer = -1
					flag = (Me.cmbJob.SelectedValue IsNot Nothing)
					If flag Then
						num = Conversions.ToInteger(Me.cmbJob.SelectedValue)
					End If
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag = (Me.Code = -1)
					If flag Then
						sqlCommand = New SqlCommand("insert into DealPersons(name,tel,mobile,job,address,notes) values (@name,@tel,@mobile,@job,@address,@notes)", Me.conn)
					Else
						sqlCommand = New SqlCommand("update DealPersons set name=@name ,tel=@tel ,mobile=@mobile ,job=@job ,address=@address,notes=@notes where id=" + Conversions.ToString(Me.Code), Me.conn)
					End If
					sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
					sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
					sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
					sqlCommand.Parameters.Add("@job", SqlDbType.NVarChar).Value = num
					sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = Me.txtAddress.Text
					sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
					sqlCommand.ExecuteNonQuery()
					Me.LoadDG()
					sqlCommand = New SqlCommand("select max(id) from DealPersons", Me.conn)
					Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
					MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			Try
				Dim flag As Boolean = Me.Code <> -1
				If flag Then
					Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
					If flag2 Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("delete from DealPersons where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					Me.LoadDG()
					Me.CLR()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					MessageBox.Show("اختر جهة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

		Private Sub dgvRowChng(row_index As Integer)
			' The following expression was wrapped in a checked-expression
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvPersons.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from DealPersons where id=" + Conversions.ToString(Me.Code))
		End Sub

  Private Sub dgvPersons_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvPersons.CellClick
			Dim flag As Boolean = e.RowIndex >= 0
			If flag Then
				Me.dgvRowChng(e.RowIndex)
			End If
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim flag As Boolean = dr.HasRows
			If flag Then
				dr.Read()
				Me.CLR()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
				Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
				Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
				flag = Operators.ConditionalCompareObjectNotEqual(dr("job"), -1, False)
				If flag Then
					Me.cmbJob.SelectedValue = RuntimeHelpers.GetObjectValue(dr("job"))
				End If
				Me.txtAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("address")))
				Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvPersons.ClearSelection()
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
			Me.Navigate("select top 1 * from DealPersons order by id desc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from DealPersons where id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from DealPersons order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from DealPersons where id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub
	End Class
