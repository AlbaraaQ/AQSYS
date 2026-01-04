Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Partial Public Class frmServerSetting
	Inherits Form

	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Public Shared _DBName As Object = "StockDB-4soft"
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmServerSetting.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmServerSetting.__ENCList.Count = frmServerSetting.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmServerSetting.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmServerSetting.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmServerSetting.__ENCList(num) = frmServerSetting.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmServerSetting.__ENCList.RemoveRange(num, frmServerSetting.__ENCList.Count - num)
				frmServerSetting.__ENCList.Capacity = frmServerSetting.__ENCList.Count
			End If
			frmServerSetting.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Try
			If String.IsNullOrWhiteSpace(Me.txtServer.Text) Then
				If MainClass.Language = "ar" Then
					MessageBox.Show("ادخل عنوان السيرفر")
				Else
					MessageBox.Show("Enter server address")
				End If
				Me.txtServer.Focus()
				Return
			End If

			If Me.rdNetwork.Checked Then
				If String.IsNullOrWhiteSpace(Me.txtUser.Text) Then
					If MainClass.Language = "ar" Then
						MessageBox.Show("ادخل المستخدم")
					Else
						MessageBox.Show("Enter user")
					End If
					Me.txtUser.Focus()
					Return
				End If

				If String.IsNullOrWhiteSpace(Me.txtPWD.Text) Then
					If MainClass.Language = "ar" Then
						MessageBox.Show("ادخل كلمة المرور")
					Else
						MessageBox.Show("Enter password")
					End If
					Me.txtPWD.Focus()
					Return
				End If
			End If
			Dim frmUserLogin As New frmUserLogin()
			frmUserLogin.txtServer = Me.txtServer.Text

			If MainClass.Language = "ar" Then
				Me.lblIsOk.Text = "تم الحفظ"
			Else
				Me.lblIsOk.Text = "Saved"
			End If

			' إنشاء الاتصال
			Dim connStr As String
			If Me.rdLocal.Checked Then
				' Windows Authentication - للاختبار فقط
				connStr = $"Server={Me.txtServer.Text};Database={Me.txtDBName.Text};" &
					  "Integrated Security=True;TrustServerCertificate=True;Encrypt=False;"
				frmUserLogin.conn_type = 1
			Else
				' SQL Authentication
				connStr = $"Server={Me.txtServer.Text};Database={Me.txtDBName.Text};" &
					  $"User Id={Me.txtUser.Text};Password={Me.txtPWD.Text};" &
					  $"Application Name={AppConstants.APP_SIGNATURE};" &
					  "TrustServerCertificate=True;Encrypt=False;"
				frmUserLogin.conn_type = 2
				frmUserLogin.userid = Me.txtUser.Text
				frmUserLogin.pwd = Me.txtPWD.Text
			End If

			frmUserLogin.conn = New SqlConnection(connStr)
			frmUserLogin.conn.Open()

			frmUserLogin.DBName = Me.txtDBName.Text
			frmUserLogin.LoadBranches()
			frmUserLogin.LoadYearsDB(Me.txtDBName.Text)

			' حفظ الإعدادات
			Dim mgr As New SecureDatabaseManager(Me.txtServer.Text, Me.txtDBName.Text)
			' نحفظ فقط بدون بيانات المستخدم العادي (سيتم حفظها عند تسجيل الدخول)
			mgr.SaveSettings(0, "", "", False)

		Catch ex As Exception
			If MainClass.Language = "ar" Then
				MessageBox.Show("خطأ: " & ex.Message)
			Else
				MessageBox.Show("Error: " & ex.Message)
			End If
		End Try
	End Sub

	Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub

	Private Sub Lang(ctrl As Control)
		Try
			Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
			If flag Then
				Try
					For Each obj As Object In ctrl.Controls
						Dim control As Control = CType(obj, Control)
						Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(frmServerSetting))
						componentResourceManager.ApplyResources(control, control.Name, New CultureInfo("ar"))
						Me.Lang(control)
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Else
				Try
					For Each obj2 As Object In ctrl.Controls
						Dim control2 As Control = CType(obj2, Control)
						Dim componentResourceManager2 As ComponentResourceManager = New ComponentResourceManager(GetType(frmServerSetting))
						componentResourceManager2.ApplyResources(control2, control2.Name, New CultureInfo("en-us"))
						Me.Lang(control2)
					Next
				Finally
					Dim enumerator2 As IEnumerator
					flag = (TypeOf enumerator2 Is IDisposable)
					If flag Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub frmServerSetting_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmServerSetting.Load
		Me.lblIsOk.Text = ""
		Me.Lang(Me)
		Me.txtDBName.Text = Conversions.ToString(frmServerSetting._DBName)
	End Sub

	Private Sub rdLocal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdLocal.CheckedChanged
		Try
			Dim checked As Boolean = Me.rdLocal.Checked
			If checked Then
				Me.GroupBox1.Enabled = False
			Else
				Me.GroupBox1.Enabled = True
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.frmServerSetting_Load
		frmServerSetting.__ENCAddToList(Me)
		Me.InitializeComponent()
	End Sub

	Private Sub btnDatabaseSetup_Click(sender As Object, e As EventArgs)
		Using setupForm As New frmDatabaseSetup()
			setupForm.ShowDialog()
		End Using
	End Sub
End Class
