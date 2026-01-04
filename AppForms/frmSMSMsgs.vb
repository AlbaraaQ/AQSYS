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
	Public Partial Class frmSMSMsgs
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frm_Load
			frmSMSMsgs.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSMSMsgs.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSMSMsgs.__ENCList.Count = frmSMSMsgs.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSMSMsgs.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSMSMsgs.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSMSMsgs.__ENCList(num) = frmSMSMsgs.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSMSMsgs.__ENCList.RemoveRange(num, frmSMSMsgs.__ENCList.Count - num)
					frmSMSMsgs.__ENCList.Capacity = frmSMSMsgs.__ENCList.Count
				End If
				frmSMSMsgs.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Private Sub CLR()
			Me.txtMSG.Text = ""
			Me.chkIsDefault.Checked = False
			Me.Code = -1
		End Sub

		Private Sub LoadDG()
			Me.dgvData.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,msg,assign_to from sms_msgs where is_deleted=0 order by id", Me.conn)
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
				Me.dgvData.Rows.Add()
				Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
				Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("msg"))
				Me.dgvData.Rows(num3).Cells(2).Value = Me.cmbAssign.GetItemText(RuntimeHelpers.GetObjectValue(Me.cmbAssign.Items(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("assign_to"))) - 1)))
				num3 += 1
			End While
			Me.dgvData.ClearSelection()
		End Sub

  Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
			Me.CLR()
		End Sub

  Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frm.Load
			Me.LoadDG()
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtMSG.Text.Trim(), "", False) = 0
				If flag Then
					MessageBox.Show("يجب ادخال الرسالة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtMSG.Focus()
				Else
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag = (Me.Code = -1)
					If flag Then
						sqlCommand = New SqlCommand("insert into sms_msgs(msg,assign_to,is_default,is_deleted) values(@msg,@assign_to,@is_default,@is_deleted)", Me.conn)
					Else
						sqlCommand = New SqlCommand("update sms_msgs set msg=@msg,assign_to=@assign_to,is_default=@is_default where id=" + Conversions.ToString(Me.Code), Me.conn)
					End If
					sqlCommand.Parameters.Add("@msg", SqlDbType.NVarChar).Value = Me.txtMSG.Text
					sqlCommand.Parameters.Add("@assign_to", SqlDbType.Int).Value = Me.cmbAssign.SelectedIndex + 1
					Dim num As Integer = 0
					flag = Me.chkIsDefault.Checked
					If flag Then
						num = 1
					End If
					sqlCommand.Parameters.Add("@is_default", SqlDbType.Bit).Value = num
					sqlCommand.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0
					sqlCommand.ExecuteNonQuery()
					Me.LoadDG()
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
					Dim sqlCommand As SqlCommand = New SqlCommand("update sms_msgs set is_deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
					sqlCommand.ExecuteNonQuery()
					MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.LoadDG()
					Me.CLR()
				Else
					MessageBox.Show("اختر رسالة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
			Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvData.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from sms_msgs where id=" + Conversions.ToString(Me.Code))
		End Sub

	Private Sub dgvCities_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
		Dim flag As Boolean = e.RowIndex >= 0
		If flag Then
			Me.dgvRowChng(e.RowIndex)
		End If
	End Sub

	Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub ReadData(dr As SqlDataReader)
			Dim hasRows As Boolean = dr.HasRows
			If hasRows Then
				dr.Read()
				Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
				Me.txtMSG.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("msg")))
				Me.cmbAssign.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("assign_to"))) - 1
				Try
					Me.chkIsDefault.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_default")))
				Catch ex As Exception
				End Try
				dr.Close()
			End If
		End Sub

		Private Sub Navigate(sqlstr As String)
			Me.dgvData.ClearSelection()
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
			Me.Navigate("select top 1 * from sms_msgs where is_deleted=0 order by id desc")
		End Sub

  Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			Me.Navigate("select top 1 * from sms_msgs where is_deleted=0 order by id asc")
		End Sub

  Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			Me.Navigate("select top 1 * from sms_msgs where is_deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
		End Sub

  Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			Me.Navigate("select top 1 * from sms_msgs where is_deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
		End Sub
	End Class
