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

Namespace UnitedSoftware.Forms
	Partial Public Class frmReservTawla
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		Private conn As SqlConnection

		Public tawla_id As Integer

		Public ID As Integer

		Public dtReserv As DataTable

		Public curr_index As Integer

		Public isupdate As Boolean

		' Note: this type is marked as 'beforefieldinit'.
		<DebuggerNonUserCode()>
		Shared Sub New()
		End Sub

		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmReservTawla.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmReservTawla.__ENCList.Count = frmReservTawla.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmReservTawla.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmReservTawla.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmReservTawla.__ENCList(num) = frmReservTawla.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmReservTawla.__ENCList.RemoveRange(num, frmReservTawla.__ENCList.Count - num)
					frmReservTawla.__ENCList.Capacity = frmReservTawla.__ENCList.Count
				End If
				frmReservTawla.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub New()
			frmReservTawla.__ENCAddToList(Me)
			Me.components = Nothing
			Me.conn = MainClass.ConnObj()
			Me.tawla_id = -1
			Me.ID = -1
			Me.curr_index = 0
			Me.isupdate = False
			Me.InitializeComponent()
		End Sub

		Private Sub btnReserv_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnReserv.Click
			Try
				Dim flag As Boolean = Me.curr_index = -1 AndAlso Me.isupdate
				If flag Then
					MessageBox.Show("اختر حجز من التالي والسابق أولاً")
					Me.btnNext.Focus()
				Else
					flag = Operators.CompareString(Me.txtClientName.Text.Trim(), "", False) = 0
					If flag Then
						MessageBox.Show("ادخل اسم العميل")
						Me.txtClientName.Focus()
					Else
						flag = Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState)
						If flag Then
							Me.conn.Open()
						End If
						flag = Not Me.isupdate
						Dim sqlCommand As SqlCommand
						If flag Then
							sqlCommand = New SqlCommand("insert into tawla_reserve(tawla_id,date,clientname,clientmobile,notes)values(@tawla_id,@date,@clientname,@clientmobile,@notes)", Me.conn)
						Else
							sqlCommand = New SqlCommand("update tawla_reserve set date=@date,clientname=@clientname,clientmobile=@clientmobile,notes=@notes where id=" + Conversions.ToString(Me.ID), Me.conn)
						End If
						sqlCommand.Parameters.Add("@tawla_id", SqlDbType.Int).Value = Me.tawla_id
						sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
						sqlCommand.Parameters.Add("@clientname", SqlDbType.NVarChar).Value = Me.txtClientName.Text
						sqlCommand.Parameters.Add("@clientmobile", SqlDbType.NVarChar).Value = Me.txtClientMobile.Text
						sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
						sqlCommand.ExecuteNonQuery()
						MessageBox.Show("تم الحفظ")
						Me.curr_index = -1
						Me.txtDate.Value = DateTime.Now
						Me.txtClientName.Text = ""
						Me.txtClientMobile.Text = ""
						Me.txtNotes.Text = ""
						Me.txtDate.Focus()
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag Then
					text = "error in saving"
				End If
				flag = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag Then
					text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Else
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState)
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnCancel.Click
			Try
				Dim flag As Boolean = Me.curr_index = -1 AndAlso Me.isupdate
				If flag Then
					MessageBox.Show("اختر حجز من التالي والسابق أولاً")
					Me.btnNext.Focus()
				Else
					Dim dialogResult As DialogResult = MessageBox.Show("هل متأكد من إلغاء هذا الحجز", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					flag = dialogResult = DialogResult.No
					If Not flag Then
						flag = Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState)
						If flag Then
							Me.conn.Open()
						End If
						Dim sqlCommand As SqlCommand = New SqlCommand("delete from tawla_reserve where id=" + Conversions.ToString(Me.ID), Me.conn)
						sqlCommand.ExecuteNonQuery()
						MessageBox.Show("تم إلغاء الحجز")
						Me.dtReserv.Rows.RemoveAt(Me.curr_index)
						Me.curr_index = -1
						Me.txtDate.Value = DateTime.Now
						Me.txtClientName.Text = ""
						Me.txtClientMobile.Text = ""
						Me.txtNotes.Text = ""
						Me.txtDate.Focus()
					End If
				End If
			Catch ex As Exception
				Dim text As String = "خطأ أثناء العملية"
				Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag Then
					text = "error in saving"
				End If
				flag = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag Then
					text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
				Else
					text = text + Environment.NewLine + "Error details: " + ex.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag As Boolean = Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState)
				If flag Then
					Me.conn.Close()
				End If
			End Try
		End Sub

		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnNext.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.curr_index < Me.dtReserv.Rows.Count - 1
				If flag Then
					Me.curr_index += 1
					Me.ID = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("id")))
					Me.txtDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("date")))
					Me.txtClientName.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("clientname")))
					Me.txtClientMobile.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("clientmobile")))
					Me.txtNotes.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("notes")))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnPrevious.Click
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.curr_index = Me.dtReserv.Rows.Count - 1 AndAlso Me.dtReserv.Rows.Count > 1
				If flag Then
					Me.curr_index -= 1
					Me.ID = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("id")))
					Me.txtDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("date")))
					Me.txtClientName.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("clientname")))
					Me.txtClientMobile.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("clientmobile")))
					Me.txtNotes.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dtReserv.Rows(Me.curr_index)("notes")))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles btnClose.Click
			Me.Close()
		End Sub
	End Class
End Namespace
