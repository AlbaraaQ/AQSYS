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
Imports AQSYS.My
	Public Partial Class frmSMSSett
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSMSSett.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSMSSett.__ENCList.Count = frmSMSSett.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSMSSett.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSMSSett.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSMSSett.__ENCList(num) = frmSMSSett.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSMSSett.__ENCList.RemoveRange(num, frmSMSSett.__ENCList.Count - num)
					frmSMSSett.__ENCList.Capacity = frmSMSSett.__ENCList.Count
				End If
				frmSMSSett.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSMSSett_Load
			frmSMSSett.__ENCAddToList(Me)
			Me.Code = -1
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub

  Public Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

	Public Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
		Dim form1 As New Form1()

		Try
			Dim flag As Boolean = Not Me.chkDefaultAcc.Checked AndAlso Operators.CompareString(Me.txtUsername.Text.Trim(), "", False) = 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
				If flag2 Then
					MessageBox.Show("يجب ادخال اسم المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					MessageBox.Show("Enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
				Me.txtUsername.Focus()
			Else
				Dim flag2 As Boolean = Not Me.chkDefaultAcc.Checked AndAlso Operators.CompareString(Me.txtPWD.Text.Trim(), "", False) = 0
				If flag2 Then
					flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag Then
						MessageBox.Show("يجب ادخال كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.txtPWD.Focus()
				Else
					flag2 = (Me.conn.State <> CType(Convert.ToInt32(1), ConnectionState))
					If flag2 Then
						Me.conn.Open()
					End If
					Dim num As Integer = 1
					flag2 = Me.rdJawal.Checked
					If flag2 Then
						num = 2
					Else
						flag2 = Me.rdMsegat.Checked
						If flag2 Then
							num = 3
						End If
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand()
					flag2 = (Me.Code <> -1)
					If flag2 Then
						sqlCommand = New SqlCommand("update sms_sett set actv=@actv,comp_type=@comp_type,is_defaultacc=@is_defaultacc,username=@username,pwd=@pwd,sender_name=@sender_name,sale_type=@sale_type,sale_time=@sale_time,sale_mobile=@sale_mobile,purch_type=@purch_type,purch_time=@purch_time,purch_mobile=@purch_mobile,login_actv=@login_actv,login_mobile=@login_mobile where id=" + Convert.ToString(Me.Code), Me.conn)
					Else
						sqlCommand = New SqlCommand("insert into sms_sett(id,actv,comp_type,is_defaultacc,username,pwd,sender_name,sale_type,sale_time,sale_mobile,purch_type,purch_time,purch_mobile,login_actv,login_mobile)values(@id,@actv,@comp_type,@is_defaultacc,@username,@pwd,@sender_name,@sale_type,@sale_time,@sale_mobile,@purch_type,@purch_time,@purch_mobile,@login_actv,@login_mobile)", Me.conn)
					End If
					sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = 1
					Dim num2 As Integer = 0
					flag2 = Me.chkActvSMS.Checked
					If flag2 Then
						num2 = 1
					End If
					sqlCommand.Parameters.Add("@actv", SqlDbType.Bit).Value = num2
					sqlCommand.Parameters.Add("@comp_type", SqlDbType.Int).Value = num
					Dim num3 As Integer = 0
					flag2 = Me.chkDefaultAcc.Checked
					If flag2 Then
						num3 = 1
					End If
					sqlCommand.Parameters.Add("@is_defaultacc", SqlDbType.Bit).Value = num3
					sqlCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = Me.txtUsername.Text
					sqlCommand.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = Me.txtPWD.Text
					sqlCommand.Parameters.Add("@sender_name", SqlDbType.NVarChar).Value = Me.txtSender.Text
					Dim num4 As Integer = 1
					flag2 = Me.rdSaletime.Checked
					If flag2 Then
						num4 = 2
						sqlCommand.Parameters.Add("@sale_time", SqlDbType.DateTime).Value = Me.txtSaleTime.Value
					Else
						sqlCommand.Parameters.Add("@sale_time", SqlDbType.DateTime).Value = DBNull.Value
					End If
					sqlCommand.Parameters.Add("@sale_type", SqlDbType.Int).Value = num4
					sqlCommand.Parameters.Add("@sale_mobile", SqlDbType.NVarChar).Value = Me.txtSaleMobile.Text
					Dim num5 As Integer = 1
					flag2 = Me.rdPurchTime.Checked
					If flag2 Then
						num5 = 2
						sqlCommand.Parameters.Add("@purch_time", SqlDbType.DateTime).Value = Me.txtPurchTime.Value
					Else
						sqlCommand.Parameters.Add("@purch_time", SqlDbType.DateTime).Value = DBNull.Value
					End If
					sqlCommand.Parameters.Add("@purch_type", SqlDbType.Int).Value = num5
					sqlCommand.Parameters.Add("@purch_mobile", SqlDbType.NVarChar).Value = Me.txtPurchMobile.Text
					Dim num6 As Integer = 0
					flag2 = Me.chkActvLoginSMS.Checked
					If flag2 Then
						num6 = 1
					End If
					sqlCommand.Parameters.Add("@login_actv", SqlDbType.Bit).Value = num6
					sqlCommand.Parameters.Add("@login_mobile", SqlDbType.NVarChar).Value = Me.txtLoginMobile.Text
					sqlCommand.ExecuteNonQuery()
					Form1.GetSmsSett()
					flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag2 Then
						MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			End If
		Catch ex As Exception
			Dim text As String = "خطأ أثناء الحفظ"
			text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
			Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
			If flag2 Then
				text = "Error during saving"
				text = text + Environment.NewLine + "Error details: " + ex.Message
			End If
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		Finally
			Dim flag2 As Boolean = Me.conn.State <> CType(Convert.ToInt32(0), ConnectionState)
			If flag2 Then
				Me.conn.Close()
			End If
		End Try
	End Sub

	Private Sub frmSMSSett_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmSMSSett.Load
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from sms_sett", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Me.Code = Convert.ToInt32(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("id"))))
					flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv")))
					If flag Then
						Me.chkActvSMS.Checked = True
					Else
						Me.chkActvSMS.Checked = False
					End If
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("comp_type"))) = 2)
						If flag Then
							Me.rdJawal.Checked = True
						Else
							flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("comp_type"))) = 3)
							If flag Then
								Me.rdMsegat.Checked = True
							End If
						End If
					Catch ex As Exception
					End Try
					flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_defaultacc")))
					If flag Then
						Me.chkDefaultAcc.Checked = True
					Else
						Me.chkDefaultAcc.Checked = False
						Me.txtUsername.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("username")))
						Me.txtPWD.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("pwd")))
						Me.txtSender.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sender_name")))
					End If
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_type"))) = 1)
					If flag Then
						Me.rdSaleAppClose.Checked = True
					Else
						Me.rdSaletime.Checked = True
						Me.txtSaleTime.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_time")))
					End If
					Me.txtSaleMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sale_mobile")))
					flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_type"))) = 1)
					If flag Then
						Me.rdPurchAppClose.Checked = True
					Else
						Me.rdPurchTime.Checked = True
						Me.txtPurchTime.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_time")))
					End If
					Me.txtPurchMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("purch_mobile")))
					flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("login_actv")))
					If flag Then
						Me.chkActvLoginSMS.Checked = True
					Else
						Me.chkActvLoginSMS.Checked = False
					End If
					Me.txtLoginMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("login_mobile")))
				End If
				Me.chkDefaultAcc.Checked = False
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub chkDefaultAcc_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDefaultAcc.CheckedChanged
		End Sub

  Private Sub rdSaleAppClose_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdSaleAppClose.CheckedChanged
			Dim checked As Boolean = Me.rdSaleAppClose.Checked
			If checked Then
				Me.txtSaleTime.Visible = False
			Else
				Me.txtSaleTime.Visible = True
			End If
		End Sub

  Private Sub rdPurchAppClose_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdPurchAppClose.CheckedChanged
			Dim checked As Boolean = Me.rdPurchAppClose.Checked
			If checked Then
				Me.txtPurchTime.Visible = False
			Else
				Me.txtPurchTime.Visible = True
			End If
		End Sub

End Class
