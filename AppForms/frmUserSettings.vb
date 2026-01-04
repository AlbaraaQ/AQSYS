Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
	Public Partial Class frmUserSettings
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private _name As String

		Private _size As String

		Private _fcolor As Integer

		Private _bcolor As Integer

		Private _style As String

		Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmUserSettings_Load
			frmUserSettings.__ENCAddToList(Me)
			Me._name = "Tahoma"
			Me._size = "8"
			Me._fcolor = Color.Black.ToArgb()
			Me._bcolor = Color.LightBlue.ToArgb()
			Me._style = "عادي"
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmUserSettings.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmUserSettings.__ENCList.Count = frmUserSettings.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmUserSettings.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmUserSettings.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmUserSettings.__ENCList(num) = frmUserSettings.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmUserSettings.__ENCList.RemoveRange(num, frmUserSettings.__ENCList.Count - num)
				frmUserSettings.__ENCList.Capacity = frmUserSettings.__ENCList.Count
			End If
			frmUserSettings.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub LoadUserSett()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from UserSetting where user_id=" + Conversions.ToString(MainClass.UserID), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.Names.Text = dataTable.Rows(0)(1).ToString()
				Me.Sizes.Text = dataTable.Rows(0)(2).ToString()
				flag = (Operators.CompareString(dataTable.Rows(0)(3).ToString(), "عريض", False) = 0)
				If flag Then
					Me.Bold.Checked = True
				End If
				Me._fcolor = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(4)))
				Me._bcolor = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(5)))
				flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(6)))
				If flag Then
					Me.chkActive.Checked = True
				Else
					Me.chkActive.Checked = False
				End If
			End If
			Me.DoApply()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub ApplySett(Parent As Control)
		Try
			Try
				For Each obj As Object In Parent.Controls
					Dim control As Control = CType(obj, Control)
					Dim flag As Boolean = Operators.CompareString(Me._style, "عادي", False) = 0
					If flag Then
						control.Font = New Font(Me._name, Convert.ToSingle(Me._size), FontStyle.Regular)
					Else
						control.Font = New Font(Me._name, Convert.ToSingle(Me._size), FontStyle.Bold)
					End If
					control.ForeColor = Color.FromArgb(Me._fcolor)
					Me.ApplySett(control)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		Catch ex As Exception
		End Try
	End Sub

 Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
				If flag Then
					Me.conn.Open()
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from UserSetting where user_id=" + Conversions.ToString(MainClass.UserID), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim value As Integer = 0
				flag = Me.chkActive.Checked
				If flag Then
					value = 1
				End If
				Me.DoApply()
				flag = (dataTable.Rows.Count = 0)
				If flag Then
					Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() { "insert into UserSetting(user_id,FontName,FontSize,FontStyle,FontColor,BackColor,ActiveSett)values(", Conversions.ToString(MainClass.UserID), ",'", Me._name, "','", Me._size, "','", Me._style, "',", Conversions.ToString(Me._fcolor), ",", Conversions.ToString(Me._bcolor), ",", Conversions.ToString(value), ")" }), Me.conn)
					sqlCommand.ExecuteNonQuery()
				Else
					Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() { "update UserSetting set FontName='", Me._name, "',FontSize='", Me._size, "',FontStyle='", Me._style, "',FontColor=", Conversions.ToString(Me._fcolor), ",BackColor=", Conversions.ToString(Me._bcolor), ",ActiveSett=", Conversions.ToString(value), " where user_id=", Conversions.ToString(MainClass.UserID) }), Me.conn)
					sqlCommand2.ExecuteNonQuery()
				End If
				MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

  Private Sub frmUserSettings_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmUserSettings.Load
			Try
				Dim families As FontFamily() = FontFamily.Families
				For Each fontFamily As FontFamily In families
					Me.Names.Items.Add(fontFamily.Name)
				Next
				Me.Names.Text = "Tahoma"
				Me.Sizes.Text = "8"
				Me.LoadUserSett()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DoApply()
			Try
				Me._name = Me.Names.Text
				Me._size = Me.Sizes.Text
				Me._style = "عادي"
				Dim checked As Boolean = Me.Bold.Checked
				If checked Then
					Me._style = "عريض"
				End If
				Me.BackColor = Color.FromArgb(Me._bcolor)
				Me.ApplySett(Me)
			Catch ex As Exception
			End Try
		End Sub

 Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
		Me.DoApply()
	End Sub

 Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Try
				Dim flag As Boolean = Me.colorDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me._fcolor = Me.colorDialog1.Color.ToArgb()
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
			Try
				Dim flag As Boolean = Me.colorDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me._bcolor = Me.colorDialog1.Color.ToArgb()
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
