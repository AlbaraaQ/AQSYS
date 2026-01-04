Imports Divelements.SandRibbon
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Imports AQSYS.My.Resources
Public Class Form1
	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Public conn As SqlConnection

	Public conn1 As SqlConnection

	Private SMSACTV As Boolean

	Public Shared SMSUSERNAME As String = ""

	Public Shared SMSPWD As String = ""

	Public Shared SMSSender As String = ""

	Public Shared SMS_CompType As Integer = 1

	Private SMSSALETYPE As Integer

	Private SMSSALETIME As DateTime

	Private SMSSALEMOBILE As String

	Private SMSPURCHTYPE As Integer

	Private SMSPURCHTIME As DateTime

	Private SMSPURCHMOBILE As String

	Private SMSLOGINACTV As Boolean

	Private SMSLOGINMOBILE As String

	Private company_name As String

	Private branchname As String

	Private _isfoundedupdate As Boolean

	Private _mif As String
	Private _copyNo As String = ""
	Private _companyName As String = ""
	Private _branchName As String = ""
	Private _SMSSALETIMEDONe As Boolean

	Private _SMSPURCHTIMEDONE As Boolean

	Public Shared DoExitProcess As Boolean = True

	Private _tmrExpire As Boolean

	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = Form1.__ENCList.Count = Form1.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = Form1.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = Form1.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							Form1.__ENCList(num) = Form1.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
				Form1.__ENCList.Capacity = Form1.__ENCList.Count
			End If
			Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub Button1_Activate(ByVal sender As Object, ByVal e As EventArgs)
	End Sub

	'///////////////////////
	Private Sub ApplyPermissionsOnTabs()
		Try
			' ========================================
			' أولاً: تعطيل جميع الأزرار
			' ========================================
			For Each page As DevExpress.XtraBars.Ribbon.RibbonPage In Me.Ribbon1.Pages
				' تخطي تبويب "تواصل معنا"
				If page.Text.Trim() <> "تواصل معنا" AndAlso page.Text.Trim() <> "Contact Us" Then
					For Each group As DevExpress.XtraBars.Ribbon.RibbonPageGroup In page.Groups
						For Each itemLink As DevExpress.XtraBars.BarItemLink In group.ItemLinks
							' تعطيل الزر
							If TypeOf itemLink.Item Is DevExpress.XtraBars.BarButtonItem Then
								Dim btn As DevExpress.XtraBars.BarButtonItem = CType(itemLink.Item, DevExpress.XtraBars.BarButtonItem)
								btn.Enabled = False
							End If
						Next
					Next
				End If
			Next

			' تعطيل أزرار SMS
			Me.btnClientsSMS.Enabled = True
			Me.btnClientsSendSMS.Enabled = False
			Me.btnClientsSMSAlarm.Enabled = False

			' ========================================
			' ثانياً: جلب صلاحيات المستخدم من قاعدة البيانات
			' ========================================
			Dim sqlDataAdapter As New SqlDataAdapter(
			"SELECT Forms.name as form_name, Forms.nameEn, Forms.FormName " &
			"FROM User_Permissions, Forms " &
			"WHERE User_Permissions.Form_id = Forms.id AND user_id = " & MainClass.UserID.ToString(),
			Me.conn1)

			Dim dataTable As New DataTable()
			sqlDataAdapter.Fill(dataTable)

			' ========================================
			' ثالثاً: تطبيق الصلاحيات
			' ========================================
			For Each row As DataRow In dataTable.Rows
				Dim formName As String = row("form_name").ToString().Trim()
				Dim nameEn As String = row("nameEn").ToString().Trim()
				Dim formNameTag As String = row("FormName").ToString().Trim()

				' التحقق من صلاحيات SMS
				If formName = "إرسال للعملاء" Then
					Me.btnClientsSendSMS.Enabled = True
				ElseIf formName = "تذكير العملاء" Then
					Me.btnClientsSMSAlarm.Enabled = True
				Else
					' البحث في جميع الأزرار وتفعيل الصلاحيات
					For Each page As DevExpress.XtraBars.Ribbon.RibbonPage In Me.Ribbon1.Pages
						For Each group As DevExpress.XtraBars.Ribbon.RibbonPageGroup In page.Groups
							For Each itemLink As DevExpress.XtraBars.BarItemLink In group.ItemLinks
								If TypeOf itemLink.Item Is DevExpress.XtraBars.BarButtonItem Then
									Dim btn As DevExpress.XtraBars.BarButtonItem = CType(itemLink.Item, DevExpress.XtraBars.BarButtonItem)

									' ========== الإصلاح الرئيسي ==========
									' مقارنة Caption أو nameEn أو Tag
									Dim btnCaption As String = If(btn.Caption IsNot Nothing, btn.Caption.Trim(), "")
									Dim btnTag As String = If(btn.Tag IsNot Nothing, btn.Tag.ToString().Trim(), "")

									If btnCaption = formName OrElse
								   btnCaption = nameEn OrElse
								   btnTag = formNameTag Then
										' تفعيل الزر
										btn.Enabled = True
									End If
									' =====================================

								End If
							Next
						Next
					Next

					' تفعيل العناصر المرتبطة
					ApplyRelatedPermissions(formName, nameEn)
				End If
			Next

			' ========================================
			' رابعاً: تفعيل الصلاحيات المرتبطة
			' ========================================
			ApplyLinkedPermissions()

		Catch ex As Exception
			MessageBox.Show(
			ex.Message & vbCrLf & vbCrLf &
			"StackTrace:" & vbCrLf & ex.StackTrace,
			"خطأ فعلي",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error)
		End Try
	End Sub

	''' <summary>
	''' تفعيل العناصر المرتبطة بناءً على الصلاحية
	''' </summary>
	Private Sub ApplyRelatedPermissions(formName As String, nameEn As String)
		' تنظيف النصوص
		formName = If(formName IsNot Nothing, formName.Trim(), "")
		nameEn = If(nameEn IsNot Nothing, nameEn.Trim(), "")

		Select Case True
			Case formName = "تعريف الأصناف" OrElse nameEn = "Items"
				Me.tileButton63.Enabled = True
				Me.btnRest.Enabled = True
				Me.PBitems.Enabled = True

			Case formName = "تعريف المخازن" OrElse nameEn = "Stores"
				Me.tileButton53.Enabled = True

			Case formName = "فواتير حسب نوع الفاتورة" OrElse nameEn = "frmInvSumByType"
				Me.tileButton54.Enabled = True

			Case formName = "فواتير حسب العملاء"
				Me.btnClientInvs.Enabled = True

			Case formName = "صافي مبيعات وارباح" OrElse nameEn = "frmNetsales"
				Me.tileButton24.Enabled = True

			Case formName = "النسخ الاحتياطي واستعادة قاعدة البيانات" OrElse nameEn = "frmBackupRstore"
				Me.tileButton55.Enabled = True

			Case formName = "بيانات العملاء / الموردين" OrElse nameEn = "Clients / Suppliers Data"
				Me.tileButton64.Enabled = True

			Case formName = "فاتورة المشتريات" OrElse nameEn = "Purchase Invoice"
				Me.tileButton62.Enabled = True
				Me.PBPurch.Enabled = True
				Me.btnPurchOrder.Enabled = True

			Case formName = "فاتورة المبيعات" OrElse nameEn = "Sales Invoice"
				Me.tileButton56.Enabled = True
				Me.Button70.Enabled = True
				Me.btnManfc.Enabled = True
				Me.btnTawlasManage.Enabled = True
				Me.btnErsaliaExpenses.Enabled = True
				Me.btnRptErsalia.Enabled = True
				Me.PBSales.Enabled = True
				Me.PBRest.Enabled = True

			Case formName = "مردود المبيعات" OrElse nameEn = "Sales Retreive"
				Me.tileButton68.Enabled = True
				Me.PBRetSales.Enabled = True

			Case formName = "كشف حساب" OrElse nameEn = "Accounts Report"
				Me.tileButton66.Enabled = True
				Me.btnRptSalesTax.Enabled = True
				Me.btnRptPurchTax.Enabled = True
				Me.btnRptItemsDaily.Enabled = True

			Case formName = "كشف حســـــاب  عميل" OrElse nameEn = "Client Account Report"
				Me.tileButton66.Enabled = True
				Me.PBCustAcc.Enabled = True
				Me.PBSuppAcc.Enabled = True

			Case formName = "اضافة مستخدمين" OrElse nameEn = "Add User"
				Me.tileButton67.Enabled = True
		End Select
	End Sub

	''' <summary>
	''' تفعيل الصلاحيات المرتبطة ببعضها
	''' </summary>
	Private Sub ApplyLinkedPermissions()
		' إذا كان btnFoundation مفعل، فعّل btnRptZatca
		If Me.btnFoundation.Enabled Then
			Me.btnRptZatca.Enabled = True
		End If

		' إذا كان Button48 مفعل، فعّل btnRptMobApp
		If Me.Button48.Enabled Then
			Me.btnRptMobApp.Enabled = True
		End If

		' إذا كان btnDailyJournals مفعل، فعّل btnOpenJournal
		If Me.btnDailyJournals.Enabled Then
			Me.btnOpenJournal.Enabled = True
		End If

		' إذا كان btnSansSD مفعل، فعّل PBSandSD
		If Me.btnSansSD.Enabled Then
			Me.PBSandSD.Enabled = True
		End If

		' إذا كان btnBkUp مفعل، فعّل PBbkup
		If Me.btnBkUp.Enabled Then
			Me.PBbkup.Enabled = True
		End If

		' إذا كان btnRptCustBalances مفعل، فعّل btnRptSuppBalances
		If Me.btnRptCustBalances.Enabled Then
			Me.btnRptSuppBalances.Enabled = True
		End If

		' إذا كان btnRptAcc مفعل، فعّل مراكز التكلفة
		If Me.btnRptAcc.Enabled Then
			Me.btnCostCenter.Enabled = True
			Me.btnRptCostCenter.Enabled = True
		End If

		' إذا كان Button35 مفعل، فعّل btnM5znTsweya
		If Me.Button35.Enabled Then
			Me.btnM5znTsweya.Enabled = True
		End If

		' تفعيل الأزرار الدائمة
		Me.btnPriceShow.Enabled = True
		Me.btnLogin.Enabled = True
		Me.btnYearClose.Enabled = True
		Me.tileButton54.Enabled = True
	End Sub
	'///////////////////////
	Public Function MUL(no As Long, x As Integer) As Long
		' The following expression was wrapped in a checked-expression
		' The following expression was wrapped in a unchecked-expression
		Return no * CLng(x)
	End Function

	Private Function LoadSerial() As String

	End Function
	Private Function LoadSerial1() As String
		' The following expression was wrapped in a checked-statement
		Dim result As String
		Try
			Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive WHERE InterfaceType <> 'USB'")
			Dim array As String() = New String(managementObjectSearcher.[Get]().Count + 1 - 1) {}
			Dim num As Integer = 0
			Dim flag As Boolean
			Try
				For Each managementBaseObject As ManagementBaseObject In managementObjectSearcher.[Get]()
					Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
					flag = (managementObject("SerialNumber") IsNot Nothing)
					If flag Then
						array(num) = managementObject("SerialNumber").ToString()
						num += 1
					End If
				Next
			Finally
				Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator
				flag = (enumerator IsNot Nothing)
				If flag Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim num2 As Long = CLng(array(0).GetHashCode())
			flag = (num2 < 0L)
			If flag Then
				num2 = 0L - num2
			End If
			Dim managementObjectSearcher2 As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
			Dim array2 As String() = New String(managementObjectSearcher2.[Get]().Count + 1 - 1) {}
			Dim num3 As Integer = 0
			Try
				For Each managementBaseObject2 As ManagementBaseObject In managementObjectSearcher2.[Get]()
					Dim managementObject2 As ManagementObject = CType(managementBaseObject2, ManagementObject)
					flag = (managementObject2("ProcessorID") IsNot Nothing)
					If flag Then
						array2(num3) = managementObject2("ProcessorID").ToString()
						num3 += 1
					End If
				Next
			Finally
				Dim enumerator2 As ManagementObjectCollection.ManagementObjectEnumerator
				flag = (enumerator2 IsNot Nothing)
				If flag Then
					CType(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Dim num4 As Long = CLng(array2(0).GetHashCode())
			flag = (num4 < 0L)
			If flag Then
				num4 = 0L - num4
			End If
			Dim str As String = ""
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				If flag Then
					str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				End If
			Catch ex As Exception
			End Try
			Dim num5 As Long = CLng(("StockVB-abshir20" + str).GetHashCode())
			flag = (num5 < 0L)
			If flag Then
				num5 = 0L - num5
			End If
			Dim value As String = (num2 + num5 + num4).ToString()
			Dim num6 As Long = CLng((Conversions.ToDouble(value) * 2022.625).GetHashCode())
			flag = (num6 < 0L)
			If flag Then
				num6 = 0L - num6
			End If
			Dim text As String = num6.ToString()
			flag = (num6.ToString().Length >= 16)
			If flag Then
				text = num6.ToString().Substring(0, 16)
			Else
				While num6.ToString().Length < 16
					num6 = Me.MUL(num6, 47)
				End While
				text = num6.ToString().Substring(0, 16)
			End If
			Dim text2 As String = ""
			Dim num7 As Integer = 0
			Dim num8 As Integer = text.Length - 1
			Dim num9 As Integer = num7
			While True
				Dim num10 As Integer = num9
				Dim num11 As Integer = num8
				If num10 > num11 Then
					Exit While
				End If
				flag = (num9 Mod 4 = 0 And num9 <> 0)
				If flag Then
					text2 = text2 + " - " + Conversions.ToString(text(num9))
				Else
					text2 += Conversions.ToString(text(num9))
				End If
				num9 += 1
			End While
			result = text2
		Catch ex2 As Exception
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
			result = ""
		End Try
		Return result
	End Function

	Public Sub chkItemExpire()
		Try
			Dim frmItemsExpire As frmItemsExpire = New frmItemsExpire()
			frmItemsExpire.txtDate.Value = DateTime.Now.AddDays(10.0)
			frmItemsExpire.CalcStock()
			Dim flag As Boolean = frmItemsExpire.dgvItems.Rows.Count > 0
			If flag Then
				frmItemsExpire.Show()
				frmItemsExpire.Activate()
			End If
		Catch ex As Exception
		End Try
	End Sub
	Public Sub chkItemExpire1()
		Try
			' 1. إنشاء نافذة WPF
			Dim frmItemsExpire As New frmItemsExpire()

			' 2. تعيين القيم - تأكد أن txtDate موجود في WPF
			' في WPF عادةً يكون DatePicker وليس TextBox
			frmItemsExpire.txtDate.Value = DateTime.Now.AddDays(10)

			' 3. استدعاء الدالة
			frmItemsExpire.CalcStock()

			' 4. التحقق من وجود بيانات
			' في WPF عادةً DataGrid وليس DataGridView
			Dim flag As Boolean = frmItemsExpire.dgvItems.Rows.Count > 0

			If flag Then
				' 5. عرض النافذة في WPF
				frmItemsExpire.Show()  ' ✅ Show() بدلاً من Application.Run()
				' أو
				' frmItemsExpire.ShowDialog()  ' للنافذة المودالية

				frmItemsExpire.Activate()
			End If
		Catch ex As Exception
			MessageBox.Show("خطأ: " & ex.Message)
		End Try
	End Sub
	Private Sub ChkAppUpdates()
		Try
			Dim selectConnection As SqlConnection = New SqlConnection("server=sql5075.site4now.net;database=db_a7e029_abshir;user id=db_a7e029_abshir_admin;pwd=asd123456*")
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select version from updates", selectConnection)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) > CDbl(MainClass.CurrentVersion)
				If flag2 Then
					Me._isfoundedupdate = True
					Dim dialogResult As DialogResult = MessageBox.Show("متوفر الآن تحديث للنظام، هل تريد تحميل التحديث؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					flag2 = (dialogResult = DialogResult.Yes)
					If flag2 Then
						Process.Start(System.Windows.Forms.Application.StartupPath + "\\update.exe")
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Sub GetSmsSett()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from sms_sett", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.SMSACTV = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv")))
				flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_defaultacc")))
				If flag Then
					Form1.SMSUSERNAME = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("username")))
					Form1.SMSPWD = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("pwd")))
					Form1.SMSSender = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sender_name")))
					Try
						Form1.SMS_CompType = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("comp_type")))
					Catch ex As Exception
					End Try
				End If
				Me.SMSSALETYPE = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_type")))
				flag = (Me.SMSSALETYPE = 2)
				If flag Then
					Me.SMSSALETIME = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_time")))
				End If
				Me.SMSSALEMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sale_mobile")))
				Me.SMSPURCHTYPE = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_type")))
				flag = (Me.SMSPURCHTYPE = 2)
				If flag Then
					Me.SMSPURCHTIME = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_time")))
				End If
				Me.SMSPURCHMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("purch_mobile")))
				Me.SMSLOGINACTV = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("login_actv")))
				Me.SMSLOGINMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("login_mobile")))
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.Button69.Enabled = True
		Me.Button13.Enabled = True
		Me.Button12.Enabled = True
		Control.CheckForIllegalCrossThreadCalls = False
		Dim str As String = ""
		Dim flag As Boolean
		Try
			flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
			If flag Then
				str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
			End If
		Catch ex As Exception
		End Try
		Try
			flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
			If flag Then
				Me._mif = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\mif.txt")
			End If
		Catch ex2 As Exception
		End Try
		flag = (Operators.CompareString(Me._mif.Trim(), "", False) <> 0)
		If flag Then
			Me.lblMarketing.Text = Me._mif
			Me.lblMarketing.BorderStyle = BorderStyle.FixedSingle
		End If
		Dim flag2 As Boolean = True
		Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
		flag = (registryKey IsNot Nothing)
		Dim flag3 As Boolean
		If flag Then
			flag3 = (registryKey.GetValue("Serial") IsNot Nothing)
			If flag3 Then
				Dim left As String = registryKey.GetValue("Serial").ToString()
				flag3 = (Operators.CompareString(left, Me.LoadSerial(), False) = 0)
				If flag3 Then
					MainClass.IsTrial = False
					flag2 = False
				End If
			End If
		End If
		Try
			flag3 = flag2
			If flag3 Then
				Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\aclf.txt"
				Dim left2 As String = File.ReadAllText(path, Encoding.[Default])
				flag3 = (Operators.CompareString(left2, "ok", False) = 0)
				If flag3 Then
					MainClass.IsTrial = False
					flag2 = False
				End If
			End If
		Catch ex3 As Exception
		End Try
		Try
			Me.lblVersion.Caption = "V " + Conversions.ToString(MainClass.CurrentVersion)
		Catch ex4 As Exception
		End Try
		Me.Ribbon1.Minimized = True
		Try
			For Each obj As Object In Me.Controls
				Dim control As Control = CType(obj, Control)
				Try
					Dim mdiClient As MdiClient = CType(control, MdiClient)
					mdiClient.BackColor = Me.BackColor
				Catch ex5 As InvalidCastException
				End Try
			Next
		Finally
			Dim enumerator As IEnumerator
			flag3 = (TypeOf enumerator Is IDisposable)
			If flag3 Then
				TryCast(enumerator, IDisposable).Dispose()
			End If
		End Try
		flag3 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
		If flag3 Then
			Me.Text = MainClass.AppNameAR + " ( محاسبة - إدارة المخازن والمستودعات)"
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar")
		Else
			Me.Text = MainClass.AppNameEN + "(accounts - Stocks and Restaurants Management)"
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-us")
			Me.RightToLeft = RightToLeft.No
			Me.RightToLeftLayout = False
		End If
		Try
			Dim frmUserLogin2 As New frmUserLogin2()
			frmUserLogin2.ShowDialog()
			frmUserLogin2.Left = CInt(Math.Round(CDbl(Me.Width) / 2.0 - CDbl(frmUserLogin2.Width) / 2.0))
			frmUserLogin2.Top = CInt(Math.Round(CDbl(Me.Height) / 2.0 - CDbl(frmUserLogin2.Height) / 2.0 + 200.0))
			flag3 = flag2
			If flag3 Then
				Me.lblIsTrial.Caption = "نسخة تجريبية"
				flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
				If flag3 Then
					Me.lblIsTrial.Caption = "Trial version"
				End If
			End If
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where Code=1103", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag3 = (dataTable.Rows.Count > 0)
				If flag3 Then
					MainClass.IsAccTreeNew = True
				End If
			Catch ex6 As Exception
			End Try
			Me.UpdateDB()
			Me.ApplyLang(Me)
			Me.ApplyPermissionsOnTabs()
			Me.ApplyHideSett()
			Me.Timer3.Enabled = True
			flag3 = (MainClass.EmpNo = 1)
			If flag3 Then
				Me.btnUserPerm.Enabled = True
			End If
			Dim left3 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select chk_expire,is_lbl_header,nameA,is_zatc_integ,open_expire from Foundation where id=1", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("chk_expire")))
				If flag3 Then
					Me.Timer2.Enabled = True
				End If
				Try
					flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("is_lbl_header")))
					If flag3 Then
						Me.pnlHeader.Visible = True
						Me.lblHeader.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameA")))
					End If
				Catch ex7 As Exception
				End Try
				Try
					flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("is_zatc_integ")))
					If flag3 Then
						Me.picFatoora.Visible = True
					End If
				Catch ex8 As Exception
				End Try
				Try
					left3 = MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("open_expire"))), MainClass._enckey)
				Catch ex9 As Exception
				End Try
			Catch ex10 As Exception
			End Try
			Try
				flag3 = (Not MainClass.IsTrial And Operators.CompareString(left3, "open", False) <> 0)
				If flag3 Then
					MainClass.ISExpire(DateTime.Now)
					Dim expireDaysDiff As Integer = MainClass.GetExpireDaysDiff()
					flag3 = (expireDaysDiff <= 7)
					If flag3 Then
						Dim text As String = String.Concat(New String() {"عميلنا العزيز نعمل جاهدين على ان ننال رضاكم ", Environment.NewLine, "سينتهى ترخيص البرنامج  بعد ", Conversions.ToString(expireDaysDiff), " أيام ", Environment.NewLine, "فضلا للتواصل مع الدعم الفنى للحصول على الترخيص لفتره جديده"})
						MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.lblExpireDiff.Caption = "متبقي " + Conversions.ToString(MainClass.GetExpireDaysDiff()) + " يوم على انتهاء الترخيص"
				End If
			Catch ex11 As Exception
			End Try
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select nameA from Foundation", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				Me.company_name = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("nameA")))
			Catch ex12 As Exception
			End Try
			Try
				Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select name from Branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter4.Fill(dataTable4)
				Me.branchname = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("name")))
			Catch ex13 As Exception
			End Try
			Me.GetSmsSett()
			Try
				flag3 = (Me.SMSACTV AndAlso Me.SMSLOGINACTV)
				If flag3 Then
					Dim text2 As String = Me.CompanyName + " " + Me.branchname + Environment.NewLine
					text2 = String.Concat(New String() {text2, "تم الدخول للنظام من المستخدم: ", MainClass.UserName, "  في توقيت: ", DateTime.Now.ToShortTimeString()})
					flag3 = (Form1.SMS_CompType = 1)
					If flag3 Then
						Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSLOGINMOBILE)
					Else
						flag3 = (Form1.SMS_CompType = 2)
						If flag3 Then
							Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSLOGINMOBILE)
						Else
							flag3 = (Form1.SMS_CompType = 3)
							If flag3 Then
								Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text2, Form1.SMSSender, Me.SMSLOGINMOBILE)
							End If
						End If
					End If
				End If
			Catch ex14 As Exception
			End Try
		Catch ex15 As Exception
		End Try
	End Sub
	'///////////////////////////////
	Private Sub Form1_Load2(ByVal sender As Object, ByVal e As EventArgs) ' Handles MyBase.Load
		Try
			' تهيئة التحكم في السلوك
			Control.CheckForIllegalCrossThreadCalls = False

			' تمكين الأزرار
			Me.Button69.Enabled = True
			Me.Button13.Enabled = True
			Me.Button12.Enabled = True

			' ضبط شريط الأدوات
			Me.Ribbon1.Minimized = True

			' تهيئة الألوان والنمط
			InitializeMDIClientBackground()

			' قراءة معلومات الترخيص والتسويق
			ReadLicenseInfo()
			ReadMarketingInfo()

			' التحقق من الترخيص
			CheckLicenseStatus()

			' ضبط اللغة والواجهة
			SetupLanguageAndUI()

			' إظهار شاشة تسجيل الدخول
			ShowLoginDialog()

			' تحديث معلومات النظام
			UpdateSystemInfo()

			' تطبيق إعدادات المستخدم
			ApplyUserSettings()

			' بدء الموقتات
			StartTimers()

			' التحقق من صلاحيات المستخدم
			CheckUserPermissions()

			' إرسال إشعار تسجيل الدخول عبر SMS
			SendLoginNotification()

		Catch ex As Exception
			MessageBox.Show("حدث خطأ أثناء تحميل النموذج: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
			' يمكنك إضافة تسجيل الخطأ هنا
			LogError(ex)
		End Try
	End Sub

	' ============ الدوال المساعدة ============

	Private Sub InitializeMDIClientBackground()
		Try
			For Each ctrl As Control In Me.Controls
				If TypeOf ctrl Is MdiClient Then
					Dim mdiClient As MdiClient = DirectCast(ctrl, MdiClient)
					mdiClient.BackColor = Me.BackColor
					Exit For ' وجدنا MdiClient الأول
				End If
			Next
		Catch ex As Exception
			' تجاهل الخطأ - ليس حرجاً
		End Try
	End Sub

	Private Sub ReadLicenseInfo()
		Try
			Dim copyNoFilePath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "copyno.txt")
			Dim copyNo As String = ""

			If File.Exists(copyNoFilePath) Then
				copyNo = File.ReadAllText(copyNoFilePath)
			End If

			_copyNo = copyNo
		Catch ex As Exception
			' تجاهل الخطأ
			_copyNo = ""
		End Try
	End Sub

	Private Sub ReadMarketingInfo()
		Try
			Dim mifFilePath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "mif.txt")

			If File.Exists(mifFilePath) Then
				_mif = File.ReadAllText(mifFilePath).Trim()

				If Not String.IsNullOrEmpty(_mif) Then
					Me.lblMarketing.Text = _mif
					Me.lblMarketing.BorderStyle = BorderStyle.FixedSingle
				End If
			End If
		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub CheckLicenseStatus()
		Dim isLicensed As Boolean = False

		' التحقق من الترخيص في الريجستري
		If Not String.IsNullOrEmpty(_copyNo) Then
			Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + _copyNo, False)

			If registryKey IsNot Nothing Then
				Dim serialValue As Object = registryKey.GetValue("Serial")

				If serialValue IsNot Nothing Then
					Dim storedSerial As String = serialValue.ToString()
					Dim currentSerial As String = LoadSerial()

					If storedSerial = currentSerial Then
						MainClass.IsTrial = False
						isLicensed = True
					End If
				End If
			End If
		End If

		' التحقق من الترخيص البديل
		If Not isLicensed Then
			Try
				Dim aclfPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "aclf.txt")

				If File.Exists(aclfPath) Then
					Dim aclfContent As String = File.ReadAllText(aclfPath, Encoding.Default)

					If aclfContent.Trim() = "ok" Then
						MainClass.IsTrial = False
						isLicensed = True
					End If
				End If
			Catch ex As Exception
				' تجاهل الخطأ
			End Try
		End If

		' عرض حالة النسخة التجريبية إذا لزم الأمر
		If Not isLicensed Then
			MainClass.IsTrial = True
			UpdateTrialVersionLabel()
		End If
	End Sub

	Private Sub SetupLanguageAndUI()
		Try
			' تحديث رقم الإصدار
			Me.lblVersion.Caption = "V " & MainClass.CurrentVersion.ToString()
		Catch ex As Exception
			Me.lblVersion.Caption = "V ?.?"
		End Try

		' ضبط اللغة
		If MainClass.Language = "ar" Then
			Me.Text = MainClass.AppNameAR & " (محاسبة - إدارة المخازن والمستودعات)"
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar")
			' اللغة العربية: RightToLeft مفعل افتراضياً
		Else
			Me.Text = MainClass.AppNameEN & " (Accounts - Stocks and Restaurants Management)"
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
			Me.RightToLeft = RightToLeft.No
			Me.RightToLeftLayout = False
		End If
	End Sub

	Private Sub ShowLoginDialog()
		Dim frmUserLogin As New frmUserLogin()

		' تحديد موقع الشاشة في المنتصف
		frmUserLogin.StartPosition = FormStartPosition.Manual
		frmUserLogin.Left = Me.Left + (Me.Width - frmUserLogin.Width) \ 2
		frmUserLogin.Top = Me.Top + (Me.Height - frmUserLogin.Height) \ 2

		frmUserLogin.ShowDialog()
	End Sub

	Private Sub UpdateSystemInfo()
		Try
			' التحقق من بنية الحسابات
			CheckAccountsStructure()

			' تحديث قاعدة البيانات
			UpdateDB()

			' قراءة إعدادات المؤسسة
			ReadFoundationSettings()

			' قراءة معلومات الشركة والفرع
			ReadCompanyAndBranchInfo()
		Catch ex As Exception
			MessageBox.Show("خطأ في تحديث معلومات النظام: " & ex.Message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End Try
	End Sub

	Private Sub CheckAccountsStructure()
		Try
			Using adapter As New SqlDataAdapter("SELECT * FROM accounts_index WHERE Code = 1103", Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					MainClass.IsAccTreeNew = True
				End If
			End Using
		Catch ex As Exception
			' تجاهل الخطأ - ليس حرجاً
		End Try
	End Sub

	Private Sub ReadFoundationSettings()
		Try
			Using adapter As New SqlDataAdapter("SELECT chk_expire, is_lbl_header, nameA, is_zatc_integ, open_expire FROM Foundation WHERE id = 1", Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					Dim row As DataRow = dt.Rows(0)

					' التحقق من صلاحية المنتجات
					If Convert.ToBoolean(row("chk_expire")) Then
						Me.Timer2.Enabled = True
					End If

					' عرض ترويسة المؤسسة
					If Convert.ToBoolean(row("is_lbl_header")) Then
						Me.pnlHeader.Visible = True
						Me.lblHeader.Text = row("nameA").ToString()
					End If

					' دمج زاتكا
					If Convert.ToBoolean(row("is_zatc_integ")) Then
						Me.picFatoora.Visible = True
					End If

					' التحقق من انتهاء الترخيص
					Try
						Dim openExpireEncrypted As String = row("open_expire").ToString()
						Dim openExpire As String = MainClass.Decrypt(openExpireEncrypted, MainClass._enckey)

						If Not MainClass.IsTrial AndAlso openExpire <> "open" Then
							CheckLicenseExpiration()
						End If
					Catch ex As Exception
						' تجاهل خطأ فك التشفير
					End Try
				End If
			End Using
		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub CheckLicenseExpiration()
		Try
			MainClass.ISExpire(DateTime.Now)
			Dim daysRemaining As Integer = MainClass.GetExpireDaysDiff()

			If daysRemaining <= 7 Then
				Dim message As String = String.Format("عميلنا العزيز نعمل جاهدين على أن ننال رضاكم{0}" &
												 "سينتهى ترخيص البرنامج بعد {1} أيام{0}" &
												 "فضلاً للتواصل مع الدعم الفنى للحصول على الترخيص لفترة جديدة",
												 Environment.NewLine, daysRemaining)
				MessageBox.Show(message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

			Me.lblExpireDiff.Caption = String.Format("متبقي {0} يوم على انتهاء الترخيص", daysRemaining)
		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub ReadCompanyAndBranchInfo()
		Try
			' قراءة اسم الشركة
			Using adapter As New SqlDataAdapter("SELECT nameA FROM Foundation", Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					_companyName = dt.Rows(0)("nameA").ToString()
				End If
			End Using

			' قراءة اسم الفرع
			Using adapter As New SqlDataAdapter("SELECT name FROM Branches WHERE id = " & MainClass.BranchNo, Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					_branchName = dt.Rows(0)("name").ToString()
				End If
			End Using
		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub ApplyUserSettings()
		Try
			' تطبيق اللغة
			Me.ApplyLang(Me)

			' تطبيق الصلاحيات
			Me.ApplyPermissionsOnTabs()

			' تطبيق إعدادات الإخفاء
			Me.ApplyHideSett()
		Catch ex As Exception
			MessageBox.Show("خطأ في تطبيق إعدادات المستخدم: " & ex.Message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End Try
	End Sub

	Private Sub StartTimers()
		Me.Timer3.Enabled = True
		' Timer2 قد تم تفعيله سابقاً في ReadFoundationSettings
	End Sub

	Private Sub CheckUserPermissions()
		If MainClass.EmpNo = 1 Then
			Me.btnUserPerm.Enabled = True
		End If
	End Sub

	Private Sub SendLoginNotification()
		Try
			' قراءة إعدادات SMS
			GetSmsSett()

			' التحقق من تفعيل SMS
			If Me.SMSACTV AndAlso Me.SMSLOGINACTV Then
				Dim messageText As String = String.Format("{0} {1}{2}تم الدخول للنظام من المستخدم: {3} في توقيت: {4}",
													 _companyName, _branchName, Environment.NewLine,
													 MainClass.UserName, DateTime.Now.ToShortTimeString())

				Select Case SMS_CompType
					Case 1
						SendMessage(SMSUSERNAME, SMSPWD, ConvertToUnicode(messageText), SMSUSERNAME, SMSLOGINMOBILE)
					Case 2
						SendMessage2(SMSUSERNAME, SMSPWD, ConvertToUnicode(messageText), SMSUSERNAME, SMSLOGINMOBILE)
					Case 3
						SendMessage3(SMSUSERNAME, SMSPWD, messageText, SMSSender, SMSLOGINMOBILE)
				End Select
			End If
		Catch ex As Exception
			' تجاهل الخطأ في إرسال الإشعار
		End Try
	End Sub

	' ============ الدوال الإضافية ============

	Private Sub UpdateTrialVersionLabel()
		If MainClass.IsTrial Then
			If MainClass.Language = "en" Then
				Me.lblIsTrial.Caption = "Trial version"
			Else
				Me.lblIsTrial.Caption = "نسخة تجريبية"
			End If
		Else
			Me.lblIsTrial.Caption = ""
		End If
	End Sub

	Private Sub LogError(ByVal ex As Exception)
		' يمكنك إضافة كود تسجيل الأخطاء هنا
		' مثلاً: تسجيل في ملف أو قاعدة بيانات
		Try
			Dim logPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "error_log.txt")
			Dim logMessage As String = String.Format("[{0}] {1}: {2}{3}{4}{5}",
												 DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
												 ex.GetType().Name,
												 ex.Message,
												 Environment.NewLine,
												 ex.StackTrace,
												 Environment.NewLine)

			File.AppendAllText(logPath, logMessage)
		Catch
			' إذا فشل تسجيل الخطأ، تجاهله
		End Try
	End Sub

	' ============ المتغيرات الخاصة ============


	'//////////////////////////////
	Private Sub UpdateDB()
		Try
			Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
			If flag Then
				Me.conn.Open()
			End If
			Try
				Dim sqlCommand As SqlCommand = New SqlCommand("alter table branches add default_bank int", Me.conn)
				sqlCommand.ExecuteNonQuery()
			Catch ex As Exception
			End Try
			Try
				Dim sqlCommand2 As SqlCommand = New SqlCommand("alter table foundation add show_stamp_recdoc bit", Me.conn)
				sqlCommand2.ExecuteNonQuery()
			Catch ex2 As Exception
			End Try
			Try
				Dim sqlCommand3 As SqlCommand = New SqlCommand("alter table foundation add is_pono bit", Me.conn)
				sqlCommand3.ExecuteNonQuery()
				sqlCommand3 = New SqlCommand("alter table inv add pono nvarchar(100)", Me.conn)
				sqlCommand3.ExecuteNonQuery()
			Catch ex3 As Exception
			End Try
			Try
				Dim sqlCommand4 As SqlCommand = New SqlCommand("alter table inv add qr nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add status_code nvarchar(10)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add war_msg nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add err_msg nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add InvoiceHash nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add EncodedInvoice nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add UUID nvarchar(max)", Me.conn)
				sqlCommand4.ExecuteNonQuery()
				sqlCommand4 = New SqlCommand("alter table inv add is_zatc_done bit", Me.conn)
				sqlCommand4.ExecuteNonQuery()
			Catch ex4 As Exception
			End Try
			Try
				Dim sqlCommand5 As SqlCommand = New SqlCommand("alter table foundation add kit_print_type int", Me.conn)
				sqlCommand5.ExecuteNonQuery()
			Catch ex5 As Exception
			End Try
			Try
				Dim sqlCommand6 As SqlCommand = New SqlCommand("alter table inv add is_debtnote bit", Me.conn)
				sqlCommand6.ExecuteNonQuery()
				sqlCommand6 = New SqlCommand("alter table inv add debtnote_id nvarchar(50)", Me.conn)
				sqlCommand6.ExecuteNonQuery()
			Catch ex6 As Exception
			End Try
			Try
				Dim sqlCommand7 As SqlCommand = New SqlCommand("alter table sandQ add ref_no nvarchar(50)", Me.conn)
				sqlCommand7.ExecuteNonQuery()
			Catch ex7 As Exception
			End Try
			Try
				Dim sqlCommand8 As SqlCommand = New SqlCommand("alter table foundation add is_ammand bit", Me.conn)
				sqlCommand8.ExecuteNonQuery()
			Catch ex8 As Exception
			End Try
			Try
				Dim sqlCommand9 As SqlCommand = New SqlCommand("alter table foundation add clienttype_default int", Me.conn)
				sqlCommand9.ExecuteNonQuery()
			Catch ex9 As Exception
			End Try
			Try
				Dim sqlCommand10 As SqlCommand = New SqlCommand("alter table users add print_clients_pwd nvarchar(100)", Me.conn)
				sqlCommand10.ExecuteNonQuery()
			Catch ex10 As Exception
			End Try
			Try
				Dim sqlCommand11 As SqlCommand = New SqlCommand("alter table foundation add open_expire nvarchar(100)", Me.conn)
				sqlCommand11.ExecuteNonQuery()
			Catch ex11 As Exception
			End Try
			Try
				Dim sqlCommand12 As SqlCommand = New SqlCommand("alter table foundation add is_sandQ_stamp bit", Me.conn)
				sqlCommand12.ExecuteNonQuery()
			Catch ex12 As Exception
			End Try
			Try
				Dim sqlCommand13 As SqlCommand = New SqlCommand("alter table foundation add is_sandQ_sign bit", Me.conn)
				sqlCommand13.ExecuteNonQuery()
				sqlCommand13 = New SqlCommand("alter table foundation add sandQ_sign image", Me.conn)
				sqlCommand13.ExecuteNonQuery()
			Catch ex13 As Exception
			End Try
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from forms where id=20009", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count = 0)
				If flag Then
					Dim sqlCommand14 As SqlCommand = New SqlCommand("insert into forms(id,name,NameEn,FormName,IS_New_Visible,IS_Save_Visible,IS_Delete_Visible,IS_Search_Visible,IS_Print_Visible,IS_Parent,Parent_id)values(" + Conversions.ToString(20009) + ",'تقرير متابعة عميل','تقرير متابعة عميل','frmRptClientMaintDetails',0,0,0,1,1,0,2)", Me.conn)
					sqlCommand14.ExecuteNonQuery()
				End If
			Catch ex14 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from forms where id=20010", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count = 0)
				If flag Then
					Dim sqlCommand15 As SqlCommand = New SqlCommand("insert into forms(id,name,NameEn,FormName,IS_New_Visible,IS_Save_Visible,IS_Delete_Visible,IS_Search_Visible,IS_Print_Visible,IS_Parent,Parent_id)values(" + Conversions.ToString(20010) + ",'تقرير متابعة العملاء','تقرير متابعة العملاء','frmRptClientsMaint',0,0,0,1,1,0,2)", Me.conn)
					sqlCommand15.ExecuteNonQuery()
				End If
			Catch ex15 As Exception
			End Try
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from forms where id=20011", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag = (dataTable3.Rows.Count = 0)
				If flag Then
					Dim sqlCommand16 As SqlCommand = New SqlCommand("insert into forms(id,name,NameEn,FormName,IS_New_Visible,IS_Save_Visible,IS_Delete_Visible,IS_Search_Visible,IS_Print_Visible,IS_Parent,Parent_id)values(" + Conversions.ToString(20011) + ",'إرسال للعملاء','إرسال للعملاء','frmClientsSendSms',0,0,0,1,1,0,2)", Me.conn)
					sqlCommand16.ExecuteNonQuery()
				End If
			Catch ex16 As Exception
			End Try
			Try
				Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select * from forms where id=20012", Me.conn)
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter4.Fill(dataTable4)
				flag = (dataTable4.Rows.Count = 0)
				If flag Then
					Dim sqlCommand17 As SqlCommand = New SqlCommand("insert into forms(id,name,NameEn,FormName,IS_New_Visible,IS_Save_Visible,IS_Delete_Visible,IS_Search_Visible,IS_Print_Visible,IS_Parent,Parent_id)values(" + Conversions.ToString(20012) + ",'تذكير العملاء','تذكير العملاء','frmClientsSMSAlarm',0,0,0,1,1,0,2)", Me.conn)
					sqlCommand17.ExecuteNonQuery()
				End If
			Catch ex17 As Exception
			End Try
			Try
				Dim sqlCommand18 As SqlCommand = New SqlCommand("alter table inv add twreed_date nvarchar(50)", Me.conn)
				sqlCommand18.ExecuteNonQuery()
			Catch ex18 As Exception
			End Try
			Try
				Dim sqlCommand19 As SqlCommand = New SqlCommand("alter table Restrictions_Sub add acc_order int", Me.conn)
				sqlCommand19.ExecuteNonQuery()
			Catch ex19 As Exception
			End Try
			Try
				Dim sqlCommand20 As SqlCommand = New SqlCommand("alter table customers add cust_type int", Me.conn)
				sqlCommand20.ExecuteNonQuery()
			Catch ex20 As Exception
			End Try
			Try
				Dim sqlCommand21 As SqlCommand = New SqlCommand("alter table inv add acc int", Me.conn)
				sqlCommand21.ExecuteNonQuery()
			Catch ex21 As Exception
			End Try
			Try
				Dim sqlCommand22 As SqlCommand = New SqlCommand("alter table foundation add is_zakat bit", Me.conn)
				sqlCommand22.ExecuteNonQuery()
			Catch ex22 As Exception
			End Try
			Try
				Dim sqlCommand23 As SqlCommand = New SqlCommand("alter table foundation add zatc_integ_type int", Me.conn)
				sqlCommand23.ExecuteNonQuery()
			Catch ex23 As Exception
			End Try
			Try
				Dim sqlCommand24 As SqlCommand = New SqlCommand("alter table foundation add is_zatc_integ bit", Me.conn)
				sqlCommand24.ExecuteNonQuery()
				sqlCommand24 = New SqlCommand("alter table foundation add is_prevent_inv_zatc_fail bit", Me.conn)
				sqlCommand24.ExecuteNonQuery()
			Catch ex24 As Exception
			End Try
			Try
				Dim sqlCommand25 As SqlCommand = New SqlCommand("alter table branches add pih nvarchar(max)", Me.conn)
				sqlCommand25.ExecuteNonQuery()
			Catch ex25 As Exception
			End Try
			Try
				Dim sqlCommand26 As SqlCommand = New SqlCommand("alter table branches add uuid bigint", Me.conn)
				sqlCommand26.ExecuteNonQuery()
				sqlCommand26 = New SqlCommand("alter table foundation add pih nvarchar(max)", Me.conn)
				sqlCommand26.ExecuteNonQuery()
				sqlCommand26 = New SqlCommand("alter table foundation add uuid bigint", Me.conn)
				sqlCommand26.ExecuteNonQuery()
			Catch ex26 As Exception
			End Try
			Try
				Dim sqlCommand27 As SqlCommand = New SqlCommand("alter table foundation add csr nvarchar(max)", Me.conn)
				sqlCommand27.ExecuteNonQuery()
				sqlCommand27 = New SqlCommand("alter table foundation add private_key nvarchar(max)", Me.conn)
				sqlCommand27.ExecuteNonQuery()
				sqlCommand27 = New SqlCommand("alter table foundation add public_key nvarchar(max)", Me.conn)
				sqlCommand27.ExecuteNonQuery()
				sqlCommand27 = New SqlCommand("alter table foundation add secret_code nvarchar(max)", Me.conn)
				sqlCommand27.ExecuteNonQuery()
			Catch ex27 As Exception
			End Try
			Try
				Dim sqlCommand28 As SqlCommand = New SqlCommand("alter table branches add addressEn nvarchar(max)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add cr nvarchar(100)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add bank1 nvarchar(200)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add acc1 nvarchar(100)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add bank2 nvarchar(200)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add acc2 nvarchar(100)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add bank3 nvarchar(200)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
				sqlCommand28 = New SqlCommand("alter table branches add acc3 nvarchar(100)", Me.conn)
				sqlCommand28.ExecuteNonQuery()
			Catch ex28 As Exception
			End Try
			Try
				Dim sqlCommand29 As SqlCommand = New SqlCommand("alter table foundation add img_gm image", Me.conn)
				sqlCommand29.ExecuteNonQuery()
				sqlCommand29 = New SqlCommand("alter table foundation add img_pm image", Me.conn)
				sqlCommand29.ExecuteNonQuery()
				sqlCommand29 = New SqlCommand("alter table foundation add img_pb image", Me.conn)
				sqlCommand29.ExecuteNonQuery()
			Catch ex29 As Exception
			End Try
			Try
				Dim sqlCommand30 As SqlCommand = New SqlCommand("alter table customers add cr nvarchar(100)", Me.conn)
				sqlCommand30.ExecuteNonQuery()
			Catch ex30 As Exception
			End Try
			Try
				Dim sqlCommand31 As SqlCommand = New SqlCommand("alter table inv add period_date1 datetime", Me.conn)
				sqlCommand31.ExecuteNonQuery()
				sqlCommand31 = New SqlCommand("alter table inv add period_date2 datetime", Me.conn)
				sqlCommand31.ExecuteNonQuery()
				sqlCommand31 = New SqlCommand("alter table inv add due_date datetime", Me.conn)
				sqlCommand31.ExecuteNonQuery()
			Catch ex31 As Exception
			End Try
			Try
				Dim sqlCommand32 As SqlCommand = New SqlCommand("alter table inv add payment_terms nvarchar(max)", Me.conn)
				sqlCommand32.ExecuteNonQuery()
				sqlCommand32 = New SqlCommand("alter table inv add reference_no nvarchar(max)", Me.conn)
				sqlCommand32.ExecuteNonQuery()
				sqlCommand32 = New SqlCommand("alter table inv add hire_period nvarchar(max)", Me.conn)
				sqlCommand32.ExecuteNonQuery()
			Catch ex32 As Exception
			End Try
			Try
				Dim sqlCommand33 As SqlCommand = New SqlCommand("alter table foundation add print_img bit", Me.conn)
				sqlCommand33.ExecuteNonQuery()
			Catch ex33 As Exception
			End Try
			Try
				Dim sqlCommand34 As SqlCommand = New SqlCommand("alter table foundation add print_file_out bit", Me.conn)
				sqlCommand34.ExecuteNonQuery()
			Catch ex34 As Exception
			End Try
			Try
				Dim sqlCommand35 As SqlCommand = New SqlCommand("alter table foundation add actv_rest_print_new bit", Me.conn)
				sqlCommand35.ExecuteNonQuery()
			Catch ex35 As Exception
			End Try
			Try
				Dim sqlCommand36 As SqlCommand = New SqlCommand("alter table foundation add date_exp nvarchar(max)", Me.conn)
				sqlCommand36.ExecuteNonQuery()
			Catch ex36 As Exception
			End Try
			Try
				Dim sqlCommand37 As SqlCommand = New SqlCommand("alter table inv add cust_name nvarchar(max)", Me.conn)
				sqlCommand37.ExecuteNonQuery()
			Catch ex37 As Exception
			End Try
			Try
				Dim sqlCommand38 As SqlCommand = New SqlCommand("alter table foundation add last_name nvarchar(max)", Me.conn)
				sqlCommand38.ExecuteNonQuery()
				sqlCommand38 = New SqlCommand("alter table foundation add last_nameE nvarchar(max)", Me.conn)
				sqlCommand38.ExecuteNonQuery()
				sqlCommand38 = New SqlCommand("update foundation set last_name=nameA,last_nameE=nameE", Me.conn)
				sqlCommand38.ExecuteNonQuery()
			Catch ex38 As Exception
			End Try
			Try
				Dim sqlCommand39 As SqlCommand = New SqlCommand("alter table foundation add edit_compname bit", Me.conn)
				sqlCommand39.ExecuteNonQuery()
			Catch ex39 As Exception
			End Try
			Try
				Try
					Dim sqlCommand40 As SqlCommand = New SqlCommand("alter table inv add mobapp_id int", Me.conn)
					sqlCommand40.ExecuteNonQuery()
				Catch ex40 As Exception
				End Try
				Try
					Dim sqlCommand41 As SqlCommand = New SqlCommand("alter table inv add fees float", Me.conn)
					sqlCommand41.ExecuteNonQuery()
				Catch ex41 As Exception
				End Try
				Try
					Dim sqlCommand42 As SqlCommand = New SqlCommand("alter table inv add is_paid_online bit", Me.conn)
					sqlCommand42.ExecuteNonQuery()
				Catch ex42 As Exception
				End Try
			Catch ex43 As Exception
			End Try
			Try
				Dim sqlCommand43 As SqlCommand = New SqlCommand("create table mobapps(id int identity(1,1),name nvarchar(max,fees float,notes nvarchar(max),is_deleted bit)", Me.conn)
				sqlCommand43.ExecuteNonQuery()
			Catch ex44 As Exception
			End Try
			Try
				Dim sqlCommand44 As SqlCommand = New SqlCommand("alter table foundation add consume_type int", Me.conn)
				sqlCommand44.ExecuteNonQuery()
			Catch ex45 As Exception
			End Try
			Try
				Dim sqlCommand45 As SqlCommand = New SqlCommand("alter table inv add project_name nvarchar(max)", Me.conn)
				sqlCommand45.ExecuteNonQuery()
			Catch ex46 As Exception
			End Try
			Try
				Dim sqlCommand46 As SqlCommand = New SqlCommand("alter table inv add inv_period float", Me.conn)
				sqlCommand46.ExecuteNonQuery()
			Catch ex47 As Exception
			End Try
			Try
				Dim sqlCommand47 As SqlCommand = New SqlCommand("alter table foundation add print_elecinv bit", Me.conn)
				sqlCommand47.ExecuteNonQuery()
			Catch ex48 As Exception
			End Try
			Try
				Dim sqlCommand48 As SqlCommand = New SqlCommand("alter table foundation add street nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add gov nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add city nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add area nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add street_EN nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add gov_EN nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add city_EN nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add area_EN nvarchar(max)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add build_no nvarchar(50)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add post_code nvarchar(50)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add add_no nvarchar(50)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
				sqlCommand48 = New SqlCommand("alter table foundation add crn_no nvarchar(50)", Me.conn)
				sqlCommand48.ExecuteNonQuery()
			Catch ex49 As Exception
			End Try
			Try
				Dim sqlCommand49 As SqlCommand = New SqlCommand("alter table customers add street nvarchar(max)", Me.conn)
				sqlCommand49.ExecuteNonQuery()
			Catch ex50 As Exception
			End Try
			Try
				Try
					Dim sqlCommand50 As SqlCommand = New SqlCommand("alter table customers add gov nvarchar(max)", Me.conn)
					sqlCommand50.ExecuteNonQuery()
					sqlCommand50 = New SqlCommand("alter table customers add city_name nvarchar(max)", Me.conn)
					sqlCommand50.ExecuteNonQuery()
					sqlCommand50 = New SqlCommand("alter table customers add area_name nvarchar(max)", Me.conn)
					sqlCommand50.ExecuteNonQuery()
				Catch ex51 As Exception
				End Try
				Try
					Dim sqlCommand51 As SqlCommand = New SqlCommand("alter table customers add street_EN nvarchar(max)", Me.conn)
					sqlCommand51.ExecuteNonQuery()
					sqlCommand51 = New SqlCommand("alter table customers add gov_EN nvarchar(max)", Me.conn)
					sqlCommand51.ExecuteNonQuery()
					sqlCommand51 = New SqlCommand("alter table customers add city_EN nvarchar(max)", Me.conn)
					sqlCommand51.ExecuteNonQuery()
					sqlCommand51 = New SqlCommand("alter table customers add area_EN nvarchar(max)", Me.conn)
					sqlCommand51.ExecuteNonQuery()
				Catch ex52 As Exception
				End Try
				Try
					Dim sqlCommand52 As SqlCommand = New SqlCommand("alter table customers add build_no nvarchar(50)", Me.conn)
					sqlCommand52.ExecuteNonQuery()
				Catch ex53 As Exception
				End Try
				Try
					Dim sqlCommand53 As SqlCommand = New SqlCommand("alter table customers add post_code nvarchar(50)", Me.conn)
					sqlCommand53.ExecuteNonQuery()
				Catch ex54 As Exception
				End Try
				Try
					Dim sqlCommand54 As SqlCommand = New SqlCommand("alter table customers add add_no nvarchar(50)", Me.conn)
					sqlCommand54.ExecuteNonQuery()
				Catch ex55 As Exception
				End Try
				Try
					Dim sqlCommand55 As SqlCommand = New SqlCommand("alter table customers add crn_no nvarchar(50)", Me.conn)
					sqlCommand55.ExecuteNonQuery()
				Catch ex56 As Exception
				End Try
			Catch ex57 As Exception
			End Try
			Try
				Dim sqlCommand56 As SqlCommand = New SqlCommand("ALTER TABLE foundation add iban1 nvarchar(max)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
				sqlCommand56 = New SqlCommand("ALTER TABLE foundation add iban2 nvarchar(max)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
				sqlCommand56 = New SqlCommand("ALTER TABLE foundation add iban3 nvarchar(max)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
				sqlCommand56 = New SqlCommand("ALTER TABLE foundation add swift1 nvarchar(50)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
				sqlCommand56 = New SqlCommand("ALTER TABLE foundation add swift2 nvarchar(50)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
				sqlCommand56 = New SqlCommand("ALTER TABLE foundation add swift3 nvarchar(50)", Me.conn)
				sqlCommand56.ExecuteNonQuery()
			Catch ex58 As Exception
			End Try
			Try
				Dim sqlCommand57 As SqlCommand = New SqlCommand("ALTER TABLE foundation add is_tab3_items bit", Me.conn)
				sqlCommand57.ExecuteNonQuery()
				sqlCommand57 = New SqlCommand("ALTER TABLE foundation add tab3_items_limit float", Me.conn)
				sqlCommand57.ExecuteNonQuery()
				sqlCommand57 = New SqlCommand("ALTER TABLE foundation add is_tab3_items_minfee bit", Me.conn)
				sqlCommand57.ExecuteNonQuery()
				sqlCommand57 = New SqlCommand("ALTER TABLE foundation add tab3_items_minfee float", Me.conn)
				sqlCommand57.ExecuteNonQuery()
			Catch ex59 As Exception
			End Try
			Try
				Dim sqlCommand58 As SqlCommand = New SqlCommand("ALTER TABLE currencies add is_tab3 bit", Me.conn)
				sqlCommand58.ExecuteNonQuery()
			Catch ex60 As Exception
			End Try
			Try
				Dim sqlCommand59 As SqlCommand = New SqlCommand("ALTER TABLE inv add tab3_val float", Me.conn)
				sqlCommand59.ExecuteNonQuery()
			Catch ex61 As Exception
			End Try
			Try
				Dim sqlCommand60 As SqlCommand = New SqlCommand("ALTER TABLE inv_sub add is_tab3 bit", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("ALTER TABLE inv_sub add item_tab3 float", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("ALTER TABLE invtemp add tab3_val float", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("ALTER TABLE invtemp_sub add is_tab3 bit", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("ALTER TABLE invtemp_sub add item_tab3 float", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("update inv set tab3_val=((isnull(tab3tax,0)/100) * (tot_sale-minus)) where (proc_type=1 or proc_type=2) and is_buy=0 and tab3tax<>0 and tab3tax is not null", Me.conn)
				sqlCommand60.ExecuteNonQuery()
				sqlCommand60 = New SqlCommand("update inv_sub set item_tab3 = (val1*exchange_price - discount) where proc_id in (select proc_id from inv where (proc_type=1 or proc_type=2) and is_buy=0 and tab3tax=100)", Me.conn)
				sqlCommand60.ExecuteNonQuery()
			Catch ex62 As Exception
			End Try
			Try
				Dim sqlCommand61 As SqlCommand = New SqlCommand("alter table customers alter column name nvarchar(max)", Me.conn)
				sqlCommand61.ExecuteNonQuery()
				sqlCommand61 = New SqlCommand("alter table accounts_index alter column AName nvarchar(max)", Me.conn)
				sqlCommand61.ExecuteNonQuery()
			Catch ex63 As Exception
			End Try
			Try
				Dim sqlCommand62 As SqlCommand = New SqlCommand("alter table Foundation add inv_type int", Me.conn)
				sqlCommand62.ExecuteNonQuery()
			Catch ex64 As Exception
			End Try
			Try
				Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where Code=232", Me.conn)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter5.Fill(dataTable5)
				flag = (dataTable5.Rows.Count = 0)
				If flag Then
					Dim sqlCommand63 As SqlCommand = New SqlCommand("insert into accounts_index(Code,AName,Nature,Type,ParentCode,FinalAcc)values(232,'أرباح وخسائر مرحلة', 1 , 2 , 23 , 1 )", Me.conn)
					sqlCommand63.ExecuteNonQuery()
				End If
			Catch ex65 As Exception
			End Try
			Try
				Dim sqlCommand64 As SqlCommand = New SqlCommand("alter table Foundation add barcode_read_type int", Me.conn)
				sqlCommand64.ExecuteNonQuery()
			Catch ex66 As Exception
			End Try
			Try
				Dim sqlCommand65 As SqlCommand = New SqlCommand("alter table Foundation add storeclose_pricetype int", Me.conn)
				sqlCommand65.ExecuteNonQuery()
			Catch ex67 As Exception
			End Try
			Try
				Dim sqlCommand66 As SqlCommand = New SqlCommand("alter table inv add is_hold bit", Me.conn)
				sqlCommand66.ExecuteNonQuery()
			Catch ex68 As Exception
			End Try
			Try
				Dim sqlCommand67 As SqlCommand = New SqlCommand("alter table Foundation add inv_disc_name nvarchar(500)", Me.conn)
				sqlCommand67.ExecuteNonQuery()
			Catch ex69 As Exception
			End Try
			Try
				Dim sqlCommand68 As SqlCommand = New SqlCommand("alter table Foundation add print_custbalance bit", Me.conn)
				sqlCommand68.ExecuteNonQuery()
			Catch ex70 As Exception
			End Try
			Try
				Dim sqlCommand69 As SqlCommand = New SqlCommand("alter table customers add nameEN nvarchar(max)", Me.conn)
				sqlCommand69.ExecuteNonQuery()
			Catch ex71 As Exception
			End Try
			Try
				Dim sqlCommand70 As SqlCommand = New SqlCommand("alter table Foundation add print_opentawlas bit", Me.conn)
				sqlCommand70.ExecuteNonQuery()
			Catch ex72 As Exception
			End Try
			Try
				Dim sqlCommand71 As SqlCommand = New SqlCommand("alter table Foundation add is_barcode bit", Me.conn)
				sqlCommand71.ExecuteNonQuery()
			Catch ex73 As Exception
			End Try
			Try
				Dim sqlCommand72 As SqlCommand = New SqlCommand("alter table tsweya add acc int", Me.conn)
				sqlCommand72.ExecuteNonQuery()
			Catch ex74 As Exception
			End Try
			Try
				Dim sqlCommand73 As SqlCommand = New SqlCommand("alter table inv add rec_no nvarchar(50)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_date datetime", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_purchno nvarchar(50)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_saleno nvarchar(50)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_chargetype nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_custloc nvarchar(500)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_custlocadd nvarchar(500)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_resptel nvarchar(50)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_custvatno nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_car nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_carno nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_chargetime nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_chargeacc nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
				sqlCommand73 = New SqlCommand("alter table inv add rec_driver nvarchar(100)", Me.conn)
				sqlCommand73.ExecuteNonQuery()
			Catch ex75 As Exception
			End Try
			Try
				Dim sqlCommand74 As SqlCommand = New SqlCommand("alter table foundation add currency_name nvarchar(100)", Me.conn)
				sqlCommand74.ExecuteNonQuery()
			Catch ex76 As Exception
			End Try
			Try
				Dim sqlCommand75 As SqlCommand = New SqlCommand("alter table accounts_index add default_center int", Me.conn)
				sqlCommand75.ExecuteNonQuery()
			Catch ex77 As Exception
			End Try
			Try
				Dim sqlCommand76 As SqlCommand = New SqlCommand("alter table customers alter column name nvarchar(max)", Me.conn)
				sqlCommand76.ExecuteNonQuery()
			Catch ex78 As Exception
			End Try
			Try
				Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter("select * from SalaryAddSubTypes where id=4", Me.conn)
				Dim dataTable6 As DataTable = New DataTable()
				sqlDataAdapter6.Fill(dataTable6)
				flag = (dataTable6.Rows.Count = 0)
				If flag Then
					Dim sqlCommand77 As SqlCommand = New SqlCommand("insert into SalaryAddSubTypes(name,ISAdd)values('سلفة',0)", Me.conn)
					sqlCommand77.ExecuteNonQuery()
				End If
			Catch ex79 As Exception
			End Try
			Try
				Dim sqlCommand78 As SqlCommand = New SqlCommand("alter table SalaryPay add salary_slf float", Me.conn)
				sqlCommand78.ExecuteNonQuery()
			Catch ex80 As Exception
			End Try
			Try
				Dim sqlCommand79 As SqlCommand = New SqlCommand("alter table Foundation add paper_id int", Me.conn)
				sqlCommand79.ExecuteNonQuery()
			Catch ex81 As Exception
			End Try
			Try
				Dim sqlCommand80 As SqlCommand = New SqlCommand("alter table Foundation add hide_yearclose int", Me.conn)
				sqlCommand80.ExecuteNonQuery()
			Catch ex82 As Exception
			End Try
			Try
				Dim sqlCommand81 As SqlCommand = New SqlCommand("alter table Foundation add hide_costcenter bit", Me.conn)
				sqlCommand81.ExecuteNonQuery()
				sqlCommand81 = New SqlCommand("alter table Foundation add hide_retention bit", Me.conn)
				sqlCommand81.ExecuteNonQuery()
			Catch ex83 As Exception
			End Try
			Try
				Dim sqlCommand82 As SqlCommand = New SqlCommand("alter table Foundation add hide_manfc bit", Me.conn)
				sqlCommand82.ExecuteNonQuery()
			Catch ex84 As Exception
			End Try
			Try
				Dim sqlCommand83 As SqlCommand = New SqlCommand("alter table Foundation add sales_title2 nvarchar(500)", Me.conn)
				sqlCommand83.ExecuteNonQuery()
			Catch ex85 As Exception
			End Try
			Try
				Dim sqlCommand84 As SqlCommand = New SqlCommand("alter table Foundation add sales_title nvarchar(500)", Me.conn)
				sqlCommand84.ExecuteNonQuery()
			Catch ex86 As Exception
			End Try
			Try
				Dim sqlCommand85 As SqlCommand = New SqlCommand("alter table foundation add retention nvarchar(100)", Me.conn)
				sqlCommand85.ExecuteNonQuery()
			Catch ex87 As Exception
			End Try
			Try
				Dim sqlCommand86 As SqlCommand = New SqlCommand("alter table inv add retention float", Me.conn)
				sqlCommand86.ExecuteNonQuery()
			Catch ex88 As Exception
			End Try
			Try
				Dim sqlCommand87 As SqlCommand = New SqlCommand("alter table sandSD add val2 float", Me.conn)
				sqlCommand87.ExecuteNonQuery()
				sqlCommand87 = New SqlCommand("alter table sandSD add vatperc float", Me.conn)
				sqlCommand87.ExecuteNonQuery()
				sqlCommand87 = New SqlCommand("alter table sandSD add vat float", Me.conn)
				sqlCommand87.ExecuteNonQuery()
			Catch ex89 As Exception
			End Try
			Try
				Dim sqlCommand88 As SqlCommand = New SqlCommand("alter table customers add credit_limit float", Me.conn)
				sqlCommand88.ExecuteNonQuery()
			Catch ex90 As Exception
			End Try
			Try
				Dim sqlCommand89 As SqlCommand = New SqlCommand("alter table foundation add is_client_lastsale bit", Me.conn)
				sqlCommand89.ExecuteNonQuery()
				sqlCommand89 = New SqlCommand("alter table foundation add chk_client_creditlimit bit", Me.conn)
				sqlCommand89.ExecuteNonQuery()
			Catch ex91 As Exception
			End Try
			Try
				Dim sqlCommand90 As SqlCommand = New SqlCommand("alter table foundation add is_qr_enc bit", Me.conn)
				sqlCommand90.ExecuteNonQuery()
			Catch ex92 As Exception
			End Try
			Try
				Dim sqlCommand91 As SqlCommand = New SqlCommand("alter table foundation add show_inv_sign bit", Me.conn)
				sqlCommand91.ExecuteNonQuery()
			Catch ex93 As Exception
			End Try
			Try
				Dim sqlCommand92 As SqlCommand = New SqlCommand("alter table foundation add purch_operateno bit", Me.conn)
				sqlCommand92.ExecuteNonQuery()
				sqlCommand92 = New SqlCommand("alter table foundation add purch_expire bit", Me.conn)
				sqlCommand92.ExecuteNonQuery()
				sqlCommand92 = New SqlCommand("alter table foundation add sales_operateno bit", Me.conn)
				sqlCommand92.ExecuteNonQuery()
				sqlCommand92 = New SqlCommand("alter table foundation add sales_expire bit", Me.conn)
				sqlCommand92.ExecuteNonQuery()
			Catch ex94 As Exception
			End Try
			Try
				Dim sqlCommand93 As SqlCommand = New SqlCommand("alter table currencies add operate_no nvarchar(100)", Me.conn)
				sqlCommand93.ExecuteNonQuery()
			Catch ex95 As Exception
			End Try
			Try
				Dim sqlCommand94 As SqlCommand = New SqlCommand("alter table inv_sub add operate_no nvarchar(100)", Me.conn)
				sqlCommand94.ExecuteNonQuery()
			Catch ex96 As Exception
			End Try
			Try
				Dim sqlCommand95 As SqlCommand = New SqlCommand("alter table inv add tawla_paid bit", Me.conn)
				sqlCommand95.ExecuteNonQuery()
			Catch ex97 As Exception
			End Try
			Try
				Dim sqlCommand96 As SqlCommand = New SqlCommand("CREATE TABLE [dbo].[tawla_reserve]([id] [int] IDENTITY(1,1) NOT NULL,[tawla_id] [int] NULL,[date] [datetime] NULL,[clientname] [nvarchar](100) NULL,[clientmobile] [nvarchar](50) NULL,[notes] [nvarchar](max) NULL)", Me.conn)
				sqlCommand96.ExecuteNonQuery()
			Catch ex98 As Exception
			End Try
			Try
				Dim sqlCommand97 As SqlCommand = New SqlCommand("alter table inv add cash_part float", Me.conn)
				sqlCommand97.ExecuteNonQuery()
				sqlCommand97 = New SqlCommand("alter table inv add network_part float", Me.conn)
				sqlCommand97.ExecuteNonQuery()
			Catch ex99 As Exception
			End Try
			Try
				Dim sqlCommand98 As SqlCommand = New SqlCommand("create table sms_hist(id int identity(1,1),date datetime,cust int)", Me.conn)
				sqlCommand98.ExecuteNonQuery()
				sqlCommand98 = New SqlCommand("create table sms_msgs(id int identity(1,1),msg nvarchar(max),assign_to int,is_default bit,is_deleted bit)", Me.conn)
				sqlCommand98.ExecuteNonQuery()
				sqlCommand98 = New SqlCommand("alter table sms_sett add sender_name nvarchar(100)", Me.conn)
				sqlCommand98.ExecuteNonQuery()
			Catch ex100 As Exception
			End Try
			Try
				Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter("select * from forms where id=100013", Me.conn)
				Dim dataTable7 As DataTable = New DataTable()
				sqlDataAdapter7.Fill(dataTable7)
				flag = (dataTable7.Rows.Count = 0)
				If flag Then
					Dim sqlCommand99 As SqlCommand = New SqlCommand("insert into forms(id,name,NameEn,FormName,IS_New_Visible,IS_Save_Visible,IS_Delete_Visible,IS_Search_Visible,IS_Print_Visible,IS_Parent,Parent_id)values(" + Conversions.ToString(100013) + ",'تقرير إجمالي اليومية','تقرير إجمالي اليومية','frmRptTotal',0,0,0,1,1,0,10)", Me.conn)
					sqlCommand99.ExecuteNonQuery()
				End If
			Catch ex101 As Exception
			End Try
			Try
				Dim sqlCommand100 As SqlCommand = New SqlCommand("create table ers_exp(supp int,no int,comm float)", Me.conn)
				sqlCommand100.ExecuteNonQuery()
				sqlCommand100 = New SqlCommand("create table ers_exp_sub(supp int,no int,expname nvarchar(500),expval float)", Me.conn)
				sqlCommand100.ExecuteNonQuery()
			Catch ex102 As Exception
			End Try
			Try
				Dim sqlCommand101 As SqlCommand = New SqlCommand("alter table sms_sett add comp_type int", Me.conn)
				sqlCommand101.ExecuteNonQuery()
			Catch ex103 As Exception
			End Try
			Try
				Try
					Dim sqlCommand102 As SqlCommand = New SqlCommand("alter table inv_sub add item_adds nvarchar(max)", Me.conn)
					sqlCommand102.ExecuteNonQuery()
				Catch ex104 As Exception
				End Try
				Try
					Dim sqlCommand103 As SqlCommand = New SqlCommand("alter table Foundation add msg nvarchar(max)", Me.conn)
					sqlCommand103.ExecuteNonQuery()
				Catch ex105 As Exception
				End Try
			Catch ex106 As Exception
			End Try
			Try
				Dim sqlCommand104 As SqlCommand = New SqlCommand("alter table inv add is_maint bit", Me.conn)
				sqlCommand104.ExecuteNonQuery()
				sqlCommand104 = New SqlCommand("alter table inv add maint_inv_id int", Me.conn)
				sqlCommand104.ExecuteNonQuery()
				sqlCommand104 = New SqlCommand("alter table inv add refno nvarchar(50)", Me.conn)
				sqlCommand104.ExecuteNonQuery()
			Catch ex107 As Exception
			End Try
			Try
				Dim sqlCommand105 As SqlCommand = New SqlCommand("alter table restrictions add refno nvarchar(50)", Me.conn)
				sqlCommand105.ExecuteNonQuery()
			Catch ex108 As Exception
			End Try
			Try
				Dim sqlCommand106 As SqlCommand = New SqlCommand("alter table Foundation add msg nvarchar(max)", Me.conn)
				sqlCommand106.ExecuteNonQuery()
			Catch ex109 As Exception
			End Try
			Try
				Dim sqlCommand107 As SqlCommand = New SqlCommand("alter table inv add ers_supp int", Me.conn)
				sqlCommand107.ExecuteNonQuery()
				sqlCommand107 = New SqlCommand("alter table inv add ers_no int", Me.conn)
				sqlCommand107.ExecuteNonQuery()
			Catch ex110 As Exception
			End Try
			Try
				Dim sqlCommand108 As SqlCommand = New SqlCommand("alter table Customers add maint_date nvarchar(50)", Me.conn)
				sqlCommand108.ExecuteNonQuery()
				sqlCommand108 = New SqlCommand("alter table Customers add join_date nvarchar(50)", Me.conn)
				sqlCommand108.ExecuteNonQuery()
				sqlCommand108 = New SqlCommand("alter table Customers add cust_no int", Me.conn)
				sqlCommand108.ExecuteNonQuery()
			Catch ex111 As Exception
			End Try
			Try
				Dim sqlCommand109 As SqlCommand = New SqlCommand("alter table Customers alter column maint_date datetime", Me.conn)
				sqlCommand109.ExecuteNonQuery()
				sqlCommand109 = New SqlCommand("alter table Customers alter column join_date datetime", Me.conn)
				sqlCommand109.ExecuteNonQuery()
			Catch ex112 As Exception
			End Try
			Try
				Dim sqlCommand110 As SqlCommand = New SqlCommand("alter table Customers add address nvarchar(max)", Me.conn)
				sqlCommand110.ExecuteNonQuery()
			Catch ex113 As Exception
			End Try
			Try
				Try
					Dim sqlCommand111 As SqlCommand = New SqlCommand("alter table users add send_inv_email bit", Me.conn)
					sqlCommand111.ExecuteNonQuery()
				Catch ex114 As Exception
				End Try
				Try
					Dim sqlCommand112 As SqlCommand = New SqlCommand("alter table users add edit_inv bit", Me.conn)
					sqlCommand112.ExecuteNonQuery()
				Catch ex115 As Exception
				End Try
				Try
					Dim sqlCommand113 As SqlCommand = New SqlCommand("alter table users add hide_tel bit", Me.conn)
					sqlCommand113.ExecuteNonQuery()
				Catch ex116 As Exception
				End Try
				Try
					Dim sqlCommand114 As SqlCommand = New SqlCommand("alter table users add edit_disc bit", Me.conn)
					sqlCommand114.ExecuteNonQuery()
				Catch ex117 As Exception
				End Try
				Try
					Dim sqlCommand115 As SqlCommand = New SqlCommand("alter table users add edit_price bit", Me.conn)
					sqlCommand115.ExecuteNonQuery()
				Catch ex118 As Exception
				End Try
				Try
					Dim sqlCommand116 As SqlCommand = New SqlCommand("alter table users add edit_date bit", Me.conn)
					sqlCommand116.ExecuteNonQuery()
				Catch ex119 As Exception
				End Try
			Catch ex120 As Exception
			End Try
			Try
				Dim sqlCommand117 As SqlCommand = New SqlCommand("alter table restrictions add refno nvarchar(50)", Me.conn)
				sqlCommand117.ExecuteNonQuery()
			Catch ex121 As Exception
			End Try
			Try
				Dim sqlCommand118 As SqlCommand = New SqlCommand("alter table currencies add img image", Me.conn)
				sqlCommand118.ExecuteNonQuery()
			Catch ex122 As Exception
			End Try
			Try
				Dim sqlCommand119 As SqlCommand = New SqlCommand("alter table currencies add outoffer bit", Me.conn)
				sqlCommand119.ExecuteNonQuery()
			Catch ex123 As Exception
			End Try
			Try
				Dim sqlCommand120 As SqlCommand = New SqlCommand("alter table currencies add notes nvarchar(max)", Me.conn)
				sqlCommand120.ExecuteNonQuery()
			Catch ex124 As Exception
			End Try
			Try
				Dim sqlCommand121 As SqlCommand = New SqlCommand("alter table inv_sub add notes nvarchar(max)", Me.conn)
				sqlCommand121.ExecuteNonQuery()
			Catch ex125 As Exception
			End Try
			Try
				Dim sqlCommand122 As SqlCommand = New SqlCommand("alter table branches add img image", Me.conn)
				sqlCommand122.ExecuteNonQuery()
			Catch ex126 As Exception
			End Try
			Try
				Dim sqlCommand123 As SqlCommand = New SqlCommand("alter table Accounts_Index add EName nvarchar(500)", Me.conn)
				sqlCommand123.ExecuteNonQuery()
			Catch ex127 As Exception
			End Try
			Try
				Dim sqlCommand124 As SqlCommand = New SqlCommand("alter table restrictions add refno nvarchar(50)", Me.conn)
				sqlCommand124.ExecuteNonQuery()
			Catch ex128 As Exception
			End Try
			Try
				Dim sqlCommand125 As SqlCommand = New SqlCommand("alter table Foundation add barcode_height float", Me.conn)
				sqlCommand125.ExecuteNonQuery()
				sqlCommand125 = New SqlCommand("alter table Foundation add barcode_width float", Me.conn)
				sqlCommand125.ExecuteNonQuery()
			Catch ex129 As Exception
			End Try
			Try
				Try
					Dim sqlCommand126 As SqlCommand = New SqlCommand("alter table Foundation add actv_print2 bit", Me.conn)
					sqlCommand126.ExecuteNonQuery()
					sqlCommand126 = New SqlCommand("alter table Foundation add printer2 nvarchar(500)", Me.conn)
					sqlCommand126.ExecuteNonQuery()
				Catch ex130 As Exception
				End Try
				Try
					Dim sqlCommand127 As SqlCommand = New SqlCommand("alter table Foundation add actv_stamp bit", Me.conn)
					sqlCommand127.ExecuteNonQuery()
					sqlCommand127 = New SqlCommand("alter table Foundation add stamp image", Me.conn)
					sqlCommand127.ExecuteNonQuery()
				Catch ex131 As Exception
				End Try
				Try
					Dim sqlCommand128 As SqlCommand = New SqlCommand("alter table Foundation add start_purch int", Me.conn)
					sqlCommand128.ExecuteNonQuery()
					sqlCommand128 = New SqlCommand("alter table Foundation add start_sales int", Me.conn)
					sqlCommand128.ExecuteNonQuery()
				Catch ex132 As Exception
				End Try
				Try
					Dim sqlCommand129 As SqlCommand = New SqlCommand("alter table Foundation add is_lbl_header bit", Me.conn)
					sqlCommand129.ExecuteNonQuery()
				Catch ex133 As Exception
				End Try
				Try
					Dim sqlCommand130 As SqlCommand = New SqlCommand("alter table Foundation add print_sanad_header bit", Me.conn)
					sqlCommand130.ExecuteNonQuery()
					sqlCommand130 = New SqlCommand("alter table Foundation add print_sanad_footer bit", Me.conn)
					sqlCommand130.ExecuteNonQuery()
				Catch ex134 As Exception
				End Try
				Try
					Dim sqlCommand131 As SqlCommand = New SqlCommand("alter table Foundation add vat_type int", Me.conn)
					sqlCommand131.ExecuteNonQuery()
				Catch ex135 As Exception
				End Try
			Catch ex136 As Exception
			End Try
			Try
				Dim sqlCommand132 As SqlCommand = New SqlCommand("alter table Foundation add actv_custdisc bit", Me.conn)
				sqlCommand132.ExecuteNonQuery()
				sqlCommand132 = New SqlCommand("alter table Foundation add actv_manfc bit", Me.conn)
				sqlCommand132.ExecuteNonQuery()
			Catch ex137 As Exception
			End Try
			Try
				Dim sqlCommand133 As SqlCommand = New SqlCommand("alter table Foundation add chk_expire bit", Me.conn)
				sqlCommand133.ExecuteNonQuery()
			Catch ex138 As Exception
			End Try
			Try
				Dim sqlCommand134 As SqlCommand = New SqlCommand("alter table Foundation add show_barcode bit", Me.conn)
				sqlCommand134.ExecuteNonQuery()
			Catch ex139 As Exception
			End Try
			Try
				Dim sqlCommand135 As SqlCommand = New SqlCommand("alter table Foundation add showlastpurch bit", Me.conn)
				sqlCommand135.ExecuteNonQuery()
			Catch ex140 As Exception
			End Try
			Try
				Dim sqlCommand136 As SqlCommand = New SqlCommand("alter table Foundation add rptinv_type int", Me.conn)
				sqlCommand136.ExecuteNonQuery()
			Catch ex141 As Exception
			End Try
			Try
				Dim sqlCommand137 As SqlCommand = New SqlCommand("alter table Foundation add is_limit bit", Me.conn)
				sqlCommand137.ExecuteNonQuery()
			Catch ex142 As Exception
			End Try
			Try
				Dim sqlCommand138 As SqlCommand = New SqlCommand("alter table Foundation add AddressEn nvarchar(500)", Me.conn)
				sqlCommand138.ExecuteNonQuery()
			Catch ex143 As Exception
			End Try
			Try
				Dim sqlCommand139 As SqlCommand = New SqlCommand("alter table Foundation add msg nvarchar(max)", Me.conn)
				sqlCommand139.ExecuteNonQuery()
			Catch ex144 As Exception
			End Try
			Try
				Dim sqlCommand140 As SqlCommand = New SqlCommand("alter table Foundation add offer_type int", Me.conn)
				sqlCommand140.ExecuteNonQuery()
			Catch ex145 As Exception
			End Try
			Try
				Dim sqlCommand141 As SqlCommand = New SqlCommand("alter table Foundation add showdisc bit", Me.conn)
				sqlCommand141.ExecuteNonQuery()
				sqlCommand141 = New SqlCommand("alter table Foundation add showafterdisc bit", Me.conn)
				sqlCommand141.ExecuteNonQuery()
				sqlCommand141 = New SqlCommand("alter table Foundation add showtax bit", Me.conn)
				sqlCommand141.ExecuteNonQuery()
			Catch ex146 As Exception
			End Try
			Try
				Dim sqlCommand142 As SqlCommand = New SqlCommand("alter table Foundation add bank1 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
				sqlCommand142 = New SqlCommand("alter table Foundation add acc1 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
				sqlCommand142 = New SqlCommand("alter table Foundation add bank2 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
				sqlCommand142 = New SqlCommand("alter table Foundation add acc2 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
				sqlCommand142 = New SqlCommand("alter table Foundation add bank3 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
				sqlCommand142 = New SqlCommand("alter table Foundation add acc3 nvarchar(100)", Me.conn)
				sqlCommand142.ExecuteNonQuery()
			Catch ex147 As Exception
			End Try
			Try
				flag = Not MainClass.IsAccTreeNew
				If flag Then
					Try
						Dim sqlDataAdapter8 As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where Code=4110009", Me.conn)
						Dim dataTable8 As DataTable = New DataTable()
						sqlDataAdapter8.Fill(dataTable8)
						flag = (dataTable8.Rows.Count = 0)
						If flag Then
							Dim sqlCommand143 As SqlCommand = New SqlCommand("insert into accounts_index(Code,AName,Nature,Type,ParentCode,FinalAcc)values(4110009,'رسوم تبغ', 2 , 2 , 411 , 2 )", Me.conn)
							sqlCommand143.ExecuteNonQuery()
						End If
					Catch ex148 As Exception
					End Try
					Try
						Dim sqlDataAdapter9 As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where Code=4110010", Me.conn)
						Dim dataTable9 As DataTable = New DataTable()
						sqlDataAdapter9.Fill(dataTable9)
						flag = (dataTable9.Rows.Count = 0)
						If flag Then
							Dim sqlCommand144 As SqlCommand = New SqlCommand("insert into accounts_index(Code,AName,Nature,Type,ParentCode,FinalAcc)values(4110010,'رسوم تطبيق', 2 , 2 , 411 , 2 )", Me.conn)
							sqlCommand144.ExecuteNonQuery()
						End If
					Catch ex149 As Exception
					End Try
				Else
					Try
						Dim sqlDataAdapter10 As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where Code=2100120005", Me.conn)
						Dim dataTable10 As DataTable = New DataTable()
						sqlDataAdapter10.Fill(dataTable10)
						flag = (dataTable10.Rows.Count = 0)
						If flag Then
							Dim sqlCommand145 As SqlCommand = New SqlCommand("insert into accounts_index(Code,AName,Nature,Type,ParentCode,FinalAcc)values(2100120005,'رسوم تطبيق', 2 , 2 , 210012 , 2 )", Me.conn)
							sqlCommand145.ExecuteNonQuery()
						End If
					Catch ex150 As Exception
					End Try
				End If
				Dim sqlCommand146 As SqlCommand = New SqlCommand("alter table Foundation add tab3_name nvarchar(100)", Me.conn)
				sqlCommand146.ExecuteNonQuery()
				sqlCommand146 = New SqlCommand("alter table Foundation add is_tab3 bit", Me.conn)
				sqlCommand146.ExecuteNonQuery()
				sqlCommand146 = New SqlCommand("alter table Foundation add tab3val float", Me.conn)
				sqlCommand146.ExecuteNonQuery()
				sqlCommand146 = New SqlCommand("alter table inv add tab3tax float", Me.conn)
				sqlCommand146.ExecuteNonQuery()
			Catch ex151 As Exception
			End Try
		Catch ex152 As Exception
		Finally
			Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
			If flag Then
				Me.conn.Close()
			End If
		End Try
	End Sub

	Private Sub ProcAfterLogin()
		Try
			Me.ApplyLang(Me)
			Me.ApplyPermissionsOnTabs()
			Me.btnUnits.Enabled = True
			Me.ApplyHideSett()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.company_name = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("nameA")))
			Catch ex As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Me.branchname = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("name")))
			Catch ex2 As Exception
			End Try
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from sms_sett", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				Dim flag As Boolean = dataTable3.Rows.Count > 0
				If flag Then
					Me.SMSACTV = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("actv")))
					flag = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("is_defaultacc")))
					If flag Then
						Form1.SMSUSERNAME = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("username")))
						Form1.SMSPWD = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("pwd")))
					End If
					Me.SMSSALETYPE = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("sale_type")))
					flag = (Me.SMSSALETYPE = 2)
					If flag Then
						Me.SMSSALETIME = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("sale_time")))
					End If
					Me.SMSSALEMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("sale_mobile")))
					Me.SMSPURCHTYPE = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("purch_type")))
					flag = (Me.SMSPURCHTYPE = 2)
					If flag Then
						Me.SMSPURCHTIME = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("purch_time")))
					End If
					Me.SMSPURCHMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("purch_mobile")))
					Me.SMSLOGINACTV = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("login_actv")))
					Me.SMSLOGINMOBILE = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("login_mobile")))
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim flag As Boolean = Me.SMSACTV AndAlso Me.SMSLOGINACTV
				If flag Then
					Dim text As String = Me.CompanyName + " " + Me.branchname + Environment.NewLine
					text = String.Concat(New String() {text, "تم الدخول للنظام من المستخدم: ", MainClass.UserName, "  في توقيت: ", DateTime.Now.ToShortTimeString()})
					flag = (Form1.SMS_CompType = 1)
					If flag Then
						Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.SMSLOGINMOBILE)
					Else
						flag = (Form1.SMS_CompType = 2)
						If flag Then
							Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.SMSLOGINMOBILE)
						Else
							flag = (Form1.SMS_CompType = 3)
							If flag Then
								Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text, Form1.SMSSender, Me.SMSLOGINMOBILE)
							End If
						End If
					End If
				End If
			Catch ex4 As Exception
			End Try
		Catch ex5 As Exception
		End Try
	End Sub

	Public Shared Function ConvertToUnicode(val As String) As String
		Dim text As String = String.Empty
		Dim num As Integer = 0
		Dim num2 As Integer = val.Length - 1
		Dim num3 As Integer = num
		While True
			Dim num4 As Integer = num3
			Dim num5 As Integer = num2
			If num4 > num5 Then
				Exit While
			End If
			text += Form1.ConvertToUnicode(Convert.ToChar(val.Substring(num3, 1)))
			num3 += 1
		End While
		Return text
	End Function

	Public Shared Function ConvertToUnicode(ch As Char) As String
		Dim unicodeEncoding As UnicodeEncoding = New UnicodeEncoding()
		Dim bytes As Byte() = unicodeEncoding.GetBytes(Convert.ToString(ch))
		Return Form1.fourDigits(Conversions.ToString(bytes(1)) + bytes(0).ToString("X"))
	End Function

	Public Shared Function fourDigits(val As String) As String
		Dim result As String = String.Empty
		Select Case val.Length
			Case 1
				result = "000" + val
			Case 2
				result = "00" + val
			Case 3
				result = "0" + val
			Case 4
				result = val
		End Select
		Return result
	End Function

	Private Sub Button1_Activate_11(ByVal sender As Object, ByVal e As EventArgs) 'Handles btnFoundation.ItemClick
		Dim frmFonudation As New frmFonudation()
		MainClass.ApplyPermissionToForm(frmFonudation)
		MainClass.DoApplyUserSett(frmFonudation)
		frmFonudation.Show()
		frmFonudation.Activate()
	End Sub
	Private Sub Button1_Activate_1(sender As Object, e As EventArgs) Handles btnFoundation.ItemClick
		Dim frm As New frmFonudation2()

		' تطبيق الصلاحيات
		'MainClassWPF.ApplyPermissionToWindow(frm)

		' تطبيق إعدادات المستخدم
		'MainClassWPF.DoApplyUserSett(frm)

		frm.Show()
	End Sub

	Private Sub RibbonTab1_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles RibbonTab1.ItemClick
	End Sub

	Private Sub Button2_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnSafes.ItemClick
		Dim frmSafes As New frmSafes()
		MainClass.ApplyPermissionToForm(frmSafes)
		MainClass.DoApplyUserSett(frmSafes)
		frmSafes.Show()
		frmSafes.Activate()
	End Sub

	Private Sub Button3_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnCurrencies.ItemClick
		Dim frmcurrency As New frmcurrency()
		MainClass.ApplyPermissionToForm(frmcurrency)
		MainClass.DoApplyUserSett(frmcurrency)
		frmcurrency.Show()
		frmcurrency.Activate()
	End Sub

	Private Sub Button5_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.ItemClick
		Dim frmCustomers As New frmCustomers()
		MainClass.ApplyPermissionToForm(frmCustomers)
		MainClass.DoApplyUserSett(frmCustomers)
		frmCustomers.Show()
		frmCustomers.Activate()
	End Sub

	Private Sub Button6_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.ItemClick
		Dim frmManagement As New frmManagement()
		MainClass.ApplyPermissionToForm(frmManagement)
		MainClass.DoApplyUserSett(frmManagement)
		frmManagement.Show()
		frmManagement.Activate()
	End Sub

	Private Sub Button7_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.ItemClick
		Dim frmDepartments As New frmDepartments()
		MainClass.ApplyPermissionToForm(frmDepartments)
		MainClass.DoApplyUserSett(frmDepartments)
		frmDepartments.Show()
		frmDepartments.Activate()
	End Sub

	Private Sub Button8_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.ItemClick
		Dim frmEmployees As New frmEmployees()
		MainClass.ApplyPermissionToForm(frmEmployees)
		MainClass.DoApplyUserSett(frmEmployees)
		frmEmployees.Show()
		frmEmployees.Activate()
	End Sub

	Private Sub Button9_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.ItemClick
		Dim frmRptSalary As New frmRptSalary()
		MainClass.ApplyPermissionToForm(frmRptSalary)
		MainClass.DoApplyUserSett(frmRptSalary)
		frmRptSalary.Show()
		frmRptSalary.Activate()
	End Sub

	Private Sub Button10_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.ItemClick
		Dim frmEmpSalaryAddSub As New frmEmpSalaryAddSub()
		MainClass.ApplyPermissionToForm(frmEmpSalaryAddSub)
		MainClass.DoApplyUserSett(frmEmpSalaryAddSub)
		frmEmpSalaryAddSub.Show()
		frmEmpSalaryAddSub.Activate()
	End Sub

	Private Sub Button11_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnCountries.ItemClick
		Dim frmCountries As New frmCountries()
		MainClass.ApplyPermissionToForm(frmCountries)
		MainClass.DoApplyUserSett(frmCountries)
		frmCountries.Show()
		frmCountries.Activate()
	End Sub

	Private Sub Button12_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnCities.ItemClick
		Dim frmCities As New frmCities()
		MainClass.ApplyPermissionToForm(frmCities)
		MainClass.DoApplyUserSett(frmCities)
		frmCities.Show()
		frmCities.Activate()
	End Sub

	Private Sub Button13_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnArea.ItemClick
		Dim frmAreas As New frmAreas()
		MainClass.ApplyPermissionToForm(frmAreas)
		MainClass.DoApplyUserSett(frmAreas)
		frmAreas.Show()
		frmAreas.Activate()
	End Sub

	Private Sub Button14_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnBanks.ItemClick
		Dim frmBanks As New frmBanks()
		MainClass.ApplyPermissionToForm(frmBanks)
		MainClass.DoApplyUserSett(frmBanks)
		frmBanks.Show()
		frmBanks.Activate()
	End Sub

	Private Sub Button15_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 0
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button16_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button16.ItemClick
		Dim frmSandQ As New frmSandQ()
		MainClass.ApplyPermissionToForm(frmSandQ)
		MainClass.DoApplyUserSett(frmSandQ)
		frmSandQ.Show()
		frmSandQ.Activate()
	End Sub

	Private Sub Button17_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button17.ItemClick
		Dim frmSandD As New frmSandD()
		MainClass.ApplyPermissionToForm(frmSandD)
		MainClass.DoApplyUserSett(frmSandD)
		frmSandD.Show()
		frmSandD.Activate()
	End Sub

	Private Sub Button18_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button18.ItemClick
		Dim frmAccountsTree As New frmAccountsTree()
		MainClass.ApplyPermissionToForm(frmAccountsTree)
		MainClass.DoApplyUserSett(frmAccountsTree)
		frmAccountsTree.Show()
		frmAccountsTree.Activate()
	End Sub

	Private Sub Button19_Activate(ByVal sender As Object, ByVal e As EventArgs) ' Handles Button19.Activate
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing
		frmSalePurch.Tag = "SalePurch2"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 1
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 1
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button20_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button20.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing
		frmSalePurch.Tag = "SalePurch3"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 2
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 2
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button21_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnDailyJournals.ItemClick
		Dim frmRestrictions As New frmRestrictions()
		MainClass.ApplyPermissionToForm(frmRestrictions)
		MainClass.DoApplyUserSett(frmRestrictions)
		frmRestrictions.Show()
		frmRestrictions.Activate()
	End Sub

	Private Sub Button22_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnActs.ItemClick
		Dim frmActs As New frmActs()
		MainClass.ApplyPermissionToForm(frmActs)
		MainClass.DoApplyUserSett(frmActs)
		frmActs.Show()
		frmActs.Activate()
	End Sub

	Private Sub Button23_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnBranches.ItemClick
		Dim frmBranches As New frmBranches()
		MainClass.ApplyPermissionToForm(frmBranches)
		MainClass.DoApplyUserSett(frmBranches)
		frmBranches.Show()
		frmBranches.Activate()
	End Sub

	Private Sub Button24_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnTreasuries.ItemClick
		Dim frmTreasury As New frmTreasury()
		MainClass.ApplyPermissionToForm(frmTreasury)
		MainClass.DoApplyUserSett(frmTreasury)
		frmTreasury.Show()
		frmTreasury.Activate()
	End Sub

	Private Sub Button27_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptAcc.ItemClick
		Dim frmAccountBalance As New frmAccountBalance()
		MainClass.ApplyPermissionToForm(frmAccountBalance)
		MainClass.DoApplyUserSett(frmAccountBalance)
		frmAccountBalance.Show()
		frmAccountBalance.Activate()
	End Sub

	Private Sub Button28_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button28.ItemClick
		Dim frmMezanMorg3a As New frmMezanMorg3a()
		MainClass.ApplyPermissionToForm(frmMezanMorg3a)
		MainClass.DoApplyUserSett(frmMezanMorg3a)
		frmMezanMorg3a.Text = "ميزان المراجعة رئيسي خلال فترة"
		frmMezanMorg3a.lblHeader.Text = "ميزان المراجعة رئيسي خلال فترة"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanMorg3a.Text = "main audit balance in period"
			frmMezanMorg3a.lblHeader.Text = "main audit balance in period"
		End If
		frmMezanMorg3a._Type = 1
		frmMezanMorg3a.Show()
		frmMezanMorg3a.Activate()
	End Sub

	Private Sub Button29_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button29.ItemClick
		Dim frmMezanMorg3a As New frmMezanMorg3a()
		frmMezanMorg3a.Tag = "frmMezanMorg3a2"
		MainClass.ApplyPermissionToForm(frmMezanMorg3a)
		MainClass.DoApplyUserSett(frmMezanMorg3a)
		frmMezanMorg3a.Text = "ميزان المراجعة تحليلي خلال فترة"
		frmMezanMorg3a.lblHeader.Text = "ميزان المراجعة تحليلي خلال فترة"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanMorg3a.Text = "analytical audit balance in period"
			frmMezanMorg3a.lblHeader.Text = "analytical audit balance in period"
		End If
		frmMezanMorg3a._Type = 2
		frmMezanMorg3a.Show()
		frmMezanMorg3a.Activate()
	End Sub

	Private Sub Button30_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button30.ItemClick
		Dim frmMezanyaArba7 As New frmMezanyaArba7()
		Dim frmMezanyaArba As frmMezanyaArba7 = New frmMezanyaArba7()
		MainClass.ApplyPermissionToForm(frmMezanyaArba)
		MainClass.DoApplyUserSett(frmMezanyaArba)
		frmMezanyaArba.Text = "أرباح وخسائر حسابات رئيسية"
		frmMezanyaArba.lblHeader.Text = "أرباح وخسائر حسابات رئيسية"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanyaArba.Text = "Profit and loss of Main accounts"
			frmMezanyaArba.lblHeader.Text = "Profit and loss of Main accounts"
		End If
		frmMezanyaArba._Type = 1
		frmMezanyaArba._FormType = 1
		frmMezanyaArba.Show()
		frmMezanyaArba.Activate()
	End Sub

	Private Sub Button31_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button31.ItemClick
		Dim frmMezanyaArba7 As New frmMezanyaArba7()
		Dim frmMezanyaArba As frmMezanyaArba7 = New frmMezanyaArba7()
		frmMezanyaArba.Tag = "frmMezanyaArba72"
		MainClass.ApplyPermissionToForm(frmMezanyaArba)
		MainClass.DoApplyUserSett(frmMezanyaArba)
		frmMezanyaArba.Text = "أرباح وخسائر حسابات فرعية"
		frmMezanyaArba.lblHeader.Text = "أرباح وخسائر حسابات فرعية"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanyaArba.Text = "Profit and loss of analytical accounts"
			frmMezanyaArba.lblHeader.Text = "Profit and loss of analytical accounts"
		End If
		frmMezanyaArba._Type = 2
		frmMezanyaArba._FormType = 1
		frmMezanyaArba.Show()
		frmMezanyaArba.Activate()
	End Sub

	Private Sub Button32_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button32.ItemClick
		Dim frmMezanyaArba7 As New frmMezanyaArba7()
		Dim frmMezanyaArba As frmMezanyaArba7 = New frmMezanyaArba7()
		frmMezanyaArba.Tag = "frmMezanyaArba73"
		MainClass.ApplyPermissionToForm(frmMezanyaArba)
		MainClass.DoApplyUserSett(frmMezanyaArba)
		frmMezanyaArba.Text = "ميزانية عمومية حسابات رئيسية"
		frmMezanyaArba.lblHeader.Text = "ميزانية عمومية حسابات رئيسية"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanyaArba.Text = "Balance Sheet Major Accounts"
			frmMezanyaArba.lblHeader.Text = "Balance Sheet Major Accounts"
		End If
		frmMezanyaArba._Type = 1
		frmMezanyaArba._FormType = 2
		frmMezanyaArba.Show()
		frmMezanyaArba.Activate()
	End Sub

	Private Sub Button33_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button33.ItemClick
		Dim frmMezanyaArba7 As New frmMezanyaArba7()
		Dim frmMezanyaArba As frmMezanyaArba7 = New frmMezanyaArba7()
		frmMezanyaArba.Tag = "frmMezanyaArba74"
		MainClass.ApplyPermissionToForm(frmMezanyaArba)
		MainClass.DoApplyUserSett(frmMezanyaArba)
		frmMezanyaArba.Text = "ميزانية عمومية حسابات تحليلية"
		frmMezanyaArba.lblHeader.Text = "ميزانية عمومية حسابات تحليلية"
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
		If flag Then
			frmMezanyaArba.Text = "Balance Sheet analytical Accounts"
			frmMezanyaArba.lblHeader.Text = "Balance Sheet analytical Accounts"
		End If
		frmMezanyaArba._Type = 2
		frmMezanyaArba._FormType = 2
		frmMezanyaArba.Show()
		frmMezanyaArba.Activate()
	End Sub

	Private Sub Button34_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button34.ItemClick
		Dim frmSafesTransfer As New frmSafesTransfer()
		MainClass.ApplyPermissionToForm(frmSafesTransfer)
		MainClass.DoApplyUserSett(frmSafesTransfer)
		frmSafesTransfer.Show()
		frmSafesTransfer.Activate()
	End Sub

	Private Sub Button35_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button35.ItemClick
		Dim frmSafeGrd As New frmSafeGrd()
		MainClass.ApplyPermissionToForm(frmSafeGrd)
		MainClass.DoApplyUserSett(frmSafeGrd)
		frmSafeGrd.Show()
		frmSafeGrd.Activate()
	End Sub

	Private Sub Button36_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button36.ItemClick
		Dim frmSafeGrdToDate As New frmSafeGrdToDate()
		MainClass.ApplyPermissionToForm(frmSafeGrdToDate)
		MainClass.DoApplyUserSett(frmSafeGrdToDate)
		frmSafeGrdToDate.Show()
		frmSafeGrdToDate.Activate()
	End Sub

	Private Sub Button37_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button37.ItemClick
		Dim frmCurrecyTotalGrd As New frmCurrecyTotalGrd()
		MainClass.ApplyPermissionToForm(frmCurrecyTotalGrd)
		MainClass.DoApplyUserSett(frmCurrecyTotalGrd)
		frmCurrecyTotalGrd.Show()
		frmCurrecyTotalGrd.Activate()
	End Sub

	Private Sub Button38_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button38.ItemClick
		Dim frmCurrencyDetails As New frmCurrencyDetails()
		MainClass.ApplyPermissionToForm(frmCurrencyDetails)
		MainClass.DoApplyUserSett(frmCurrencyDetails)
		frmCurrencyDetails.Show()
		frmCurrencyDetails.Activate()
	End Sub

	Private Sub Button39_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button39.ItemClick
		Dim frmSummaryQ As New frmSummaryQ()
		MainClass.ApplyPermissionToForm(frmSummaryQ)
		MainClass.DoApplyUserSett(frmSummaryQ)
		frmSummaryQ.Show()
		frmSummaryQ.Activate()
	End Sub

	Private Sub Button40_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button40.ItemClick
		Dim frmSummaryD As New frmSummaryD()
		MainClass.ApplyPermissionToForm(frmSummaryD)
		MainClass.DoApplyUserSett(frmSummaryD)
		frmSummaryD.Show()
		frmSummaryD.Activate()
	End Sub

	Private Sub Button41_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRpt1.ItemClick
		Dim frmInvSumByType As New frmInvSumByType()
		MainClass.ApplyPermissionToForm(frmInvSumByType)
		MainClass.DoApplyUserSett(frmInvSumByType)
		frmInvSumByType.Show()
		frmInvSumByType.Activate()
	End Sub

	Private Sub Button42_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRpt2.ItemClick
		Dim frmInvSumByClient As New frmInvSumByClient()
		MainClass.ApplyPermissionToForm(frmInvSumByClient)
		MainClass.DoApplyUserSett(frmInvSumByClient)
		frmInvSumByClient.Show()
		frmInvSumByClient.Activate()
	End Sub

	Private Sub Button43_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button43.ItemClick
		Dim frmNetsales As New frmNetsales()
		MainClass.ApplyPermissionToForm(frmNetsales)
		MainClass.DoApplyUserSett(frmNetsales)
		frmNetsales.Show()
		frmNetsales.Activate()
	End Sub

	Private Sub Button44_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptCustBalances.ItemClick
		Dim frmCustAccount As New frmCustAccount()
		MainClass.ApplyPermissionToForm(frmCustAccount)
		MainClass.DoApplyUserSett(frmCustAccount)
		frmCustAccount.Show()
		frmCustAccount.Activate()
	End Sub

	Private Sub Button45_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button45.ItemClick
		Dim frmCustLastPay As New frmCustLastPay()
		MainClass.ApplyPermissionToForm(frmCustLastPay)
		MainClass.DoApplyUserSett(frmCustLastPay)
		frmCustLastPay.Show()
		frmCustLastPay.Activate()
	End Sub

	Private Sub Button47_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button47.ItemClick
		Dim frmCustAccountGet As New frmCustAccountGet()
		MainClass.ApplyPermissionToForm(frmCustAccountGet)
		MainClass.DoApplyUserSett(frmCustAccountGet)
		frmCustAccountGet.Show()
		frmCustAccountGet.Activate()
	End Sub

	Private Sub Button48_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button48.ItemClick
		Dim frmEmpInvs As New frmEmpInvs()
		MainClass.ApplyPermissionToForm(frmEmpInvs)
		MainClass.DoApplyUserSett(frmEmpInvs)
		frmEmpInvs.Show()
		frmEmpInvs.Activate()
	End Sub

	Private Sub Button50_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button50.ItemClick
		Dim frmNkdTotSalePurch As New frmNkdTotSalePurch()
		MainClass.ApplyPermissionToForm(frmNkdTotSalePurch)
		MainClass.DoApplyUserSett(frmNkdTotSalePurch)
		frmNkdTotSalePurch.Show()
		frmNkdTotSalePurch.Activate()
	End Sub

	Private Sub Button49_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button49.ItemClick
		Dim frmActsInvTotal As New frmActsInvTotal()
		MainClass.ApplyPermissionToForm(frmActsInvTotal)
		MainClass.DoApplyUserSett(frmActsInvTotal)
		frmActsInvTotal.Show()
		frmActsInvTotal.Activate()
	End Sub

	Private Sub Button46_Activate_2(ByVal sender As Object, ByVal e As EventArgs) Handles Button46.ItemClick
		Dim frmDecisionHelp As New frmDecisionHelp()
		MainClass.ApplyPermissionToForm(frmDecisionHelp)
		MainClass.DoApplyUserSett(frmDecisionHelp)
		frmDecisionHelp.Show()
		frmDecisionHelp.Activate()
	End Sub

	Private Sub Button51_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button51.ItemClick
		Dim frmAddUsers As New frmAddUsers()
		MainClass.ApplyPermissionToForm(frmAddUsers)
		MainClass.DoApplyUserSett(frmAddUsers)
		frmAddUsers.Show()
		frmAddUsers.Activate()
	End Sub

	Private Sub RibbonChunk23_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonChunk23.CaptionButtonClick
	End Sub

	Private Sub Button52_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnUserPerm.ItemClick
		Dim frmUsersPermissions As New frmUsersPermissions()
		MainClass.ApplyPermissionToForm(frmUsersPermissions)
		MainClass.DoApplyUserSett(frmUsersPermissions)
		frmUsersPermissions.Show()
		frmUsersPermissions.Activate()
	End Sub

	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
		Try
			Me.lblTime.Caption = Conversions.ToString(DateTime.Now)
		Catch ex As Exception
		End Try
		Try
			Dim smsactv As Boolean = Me.SMSACTV
			If smsactv Then
				Dim flag As Boolean = Me.SMSSALETYPE = 2
				Dim flag2 As Boolean
				If flag Then
					flag2 = (Operators.CompareString(Me.SMSSALETIME.ToString("hh:mm tt"), DateTime.Now.ToString("hh:mm tt"), False) = 0 AndAlso Not Me._SMSSALETIMEDONe)
					If flag2 Then
						Me._SMSSALETIMEDONe = True
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(*),sum(tot_net) from inv where proc_type=1 and is_buy=0 and date>=@date and is_deleted=0", Me.conn)
						sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
						Dim dataTable As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						Dim str As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
						Dim str2 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
						Dim text As String = Me.CompanyName + " " + Me.branchname + Environment.NewLine
						text = text + "عدد عمليات البيع اليوم: " + str
						text = text + Environment.NewLine + "قيمة مبيعات اليوم: " + str2
						flag2 = (Form1.SMS_CompType = 1)
						If flag2 Then
							Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.SMSSALEMOBILE)
						Else
							flag2 = (Form1.SMS_CompType = 2)
							If flag2 Then
								Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.SMSSALEMOBILE)
							Else
								flag2 = (Form1.SMS_CompType = 3)
								If flag2 Then
									Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text, Form1.SMSSender, Me.SMSSALEMOBILE)
								End If
							End If
						End If
					End If
				End If
				flag2 = (Me.SMSPURCHTYPE = 2)
				If flag2 Then
					flag = (Operators.CompareString(Me.SMSPURCHTIME.ToString("hh:mm tt"), DateTime.Now.ToString("hh:mm tt"), False) = 0 AndAlso Not Me._SMSPURCHTIMEDONE)
					If flag Then
						Me._SMSPURCHTIMEDONE = True
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select count(*),sum(tot_net) from inv where proc_type=1 and is_buy=1 and date>=@date and is_deleted=0", Me.conn)
						sqlDataAdapter2.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						Dim str3 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
						Dim str4 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						Dim text2 As String = Me.CompanyName + " " + Me.branchname + Environment.NewLine
						text2 = text2 + "عدد عمليات الشراء اليوم: " + str3
						text2 = text2 + Environment.NewLine + "قيمة مشتريات اليوم: " + str4
						flag2 = (Form1.SMS_CompType = 1)
						If flag2 Then
							Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSPURCHMOBILE)
						Else
							flag2 = (Form1.SMS_CompType = 2)
							If flag2 Then
								Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSPURCHMOBILE)
							Else
								flag2 = (Form1.SMS_CompType = 3)
								If flag2 Then
									Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text2, Form1.SMSSender, Me.SMSPURCHMOBILE)
								End If
							End If
						End If
					End If
				End If
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub ApplyHideSett()
		Try
			Try
				Me.btnManfc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
				Me.gbCostCenter.Visible = False
				Me.gpYearClose.Visible = False
			Catch ex As Exception
			End Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from foundation where id=1", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_manfc")))
				If flag2 Then
					Me.btnManfc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
					MainClass.hide_manfc = True
				Else
					Me.btnManfc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
					MainClass.hide_manfc = False
				End If
				flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_costcenter")))
				If flag2 Then
					Me.gbCostCenter.Visible = False
					MainClass.hide_costcenter = True
				Else
					Me.gbCostCenter.Visible = True
					MainClass.hide_costcenter = False
				End If
				flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_retention")))
				If flag2 Then
					MainClass.hide_retention = True
				Else
					MainClass.hide_retention = False
				End If
				Try
					flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_yearclose")))
					If flag2 Then
						Me.gpYearClose.Visible = False
						MainClass.hide_yearclose = True
					Else
						Me.gpYearClose.Visible = True
						MainClass.hide_yearclose = False
					End If
				Catch ex2 As Exception
				End Try
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		Dim frmActiveManual As New frmActiveManual()
		Dim frmCntrlSections As New frmCntrlSections()
		Try
			Dim flag As Boolean = e.KeyCode = Keys.F10 And Me.Button15.Enabled
			If flag Then
				Me.Button15_Activate(Nothing, Nothing)
			Else
				flag = (e.KeyCode = Keys.S And e.Modifiers = Keys.Alt)
				If flag Then
					frmActiveManual.ShowDialog()
				Else
					flag = (e.KeyCode = Keys.C And e.Modifiers = Keys.Alt)
					If flag Then
						frmCntrlSections.txtPWD.Text = ""
						frmCntrlSections.Panel2.Visible = False
						frmCntrlSections.ShowDialog()
						Me.ApplyHideSett()
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button1_Activate_2(ByVal sender As Object, ByVal e As EventArgs) Handles btnRpt3.ItemClick
		Dim frmInvDetails As New frmInvDetails()
		MainClass.ApplyPermissionToForm(frmInvDetails)
		MainClass.DoApplyUserSett(frmInvDetails)
		frmInvDetails.Show()
		frmInvDetails.Activate()
	End Sub

	Private Sub Button2_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.ItemClick
		Dim frmTaxGroups As New frmTaxGroups()
		frmTaxGroups.Show()
		frmTaxGroups.Activate()
	End Sub

	Private Sub Button3_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.ItemClick
		Dim dfh As New dfh()
		MainClass.ApplyPermissionToForm(dfh)
		MainClass.DoApplyUserSett(dfh)
		dfh.Show()
		dfh.Activate()
	End Sub

	Private Sub Button4_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.ItemClick
		Dim frmNkdTotSalePurchActCust As New frmNkdTotSalePurchActCust()
		MainClass.ApplyPermissionToForm(frmNkdTotSalePurchActCust)
		MainClass.DoApplyUserSett(frmNkdTotSalePurchActCust)
		frmNkdTotSalePurchActCust.Show()
		frmNkdTotSalePurchActCust.Activate()
	End Sub

	Private Sub Button11_Activate_2(ByVal sender As Object, ByVal e As EventArgs) Handles btnBkUp.ItemClick
		Dim frmBackupRstore As New frmBackupRstore()
		MainClass.ApplyPermissionToForm(frmBackupRstore)
		MainClass.DoApplyUserSett(frmBackupRstore)
		frmBackupRstore.Show()
		frmBackupRstore.Activate()
	End Sub

	Private Sub Button12_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.ItemClick
		Dim frmBuyApp As New frmBuyApp()
		frmBuyApp._mif = Me.lblMarketing.Text
		frmBuyApp.Show()
		frmBuyApp.Activate()
	End Sub

	Private Sub Button13_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.ItemClick
		Dim frmSerial As New frmSerial()
		frmSerial.Show()
		frmSerial.Activate()
	End Sub

	Private Sub Button58_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button58.ItemClick
		Dim frmChangePwd As New frmChangePwd()
		frmChangePwd.Show()
		frmChangePwd.Activate()
	End Sub

	Private Sub Button59_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button59.ItemClick
		Dim frmUserSettings As New frmUserSettings()
		frmUserSettings.Show()
		frmUserSettings.Activate()
	End Sub

	Private Sub Button60_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles Button60.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 1
		frmSalePurch.Tag = "SalePurch"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 0
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button15_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch2"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 0
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurch.Show()
		frmSalePurch.Activate()
	End Sub

	Private Sub Button61_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button61.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 1
		frmSalePurch.Tag = "SalePurch4"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 1
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 1
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button19_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button19.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch5"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 1
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 1
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button14_Activate_2(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.ItemClick
		Dim frmGroups As New frmGroups()
		MainClass.ApplyPermissionToForm(frmGroups)
		MainClass.DoApplyUserSett(frmGroups)
		frmGroups.Show()
		frmGroups.Activate()
	End Sub

	Private Sub Button22_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button22.ItemClick
		Dim frmInvRptType As New frmInvRptType()
		frmInvRptType.ShowDialog()
	End Sub

	Private Sub Button23_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button23.ItemClick
		Dim frmItemsExpire As New frmItemsExpire()
		MainClass.ApplyPermissionToForm(frmItemsExpire)
		MainClass.DoApplyUserSett(frmItemsExpire)
		frmItemsExpire.Show()
		frmItemsExpire.Activate()
	End Sub

	Private Sub ApplicationMenu1_Activate(ByVal sender As Object, ByVal e As EventArgs) 'Handles ApplicationMenu1.ItemClick
	End Sub

	Private Sub RibbonChunk1_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonChunk1.CaptionButtonClick
	End Sub

	Private Sub Ribbon1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Ribbon1.Click
	End Sub

	Private Sub Button67_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton67.ItemClick
		Dim frmAddUsers As New frmAddUsers()
		MainClass.ApplyPermissionToForm(frmAddUsers)
		MainClass.DoApplyUserSett(frmAddUsers)
		frmAddUsers.Show()
		frmAddUsers.Activate()
	End Sub

	Private Sub Button55_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton55.ItemClick
		Dim frmBackupRstore As New frmBackupRstore()
		MainClass.ApplyPermissionToForm(frmBackupRstore)
		MainClass.DoApplyUserSett(frmBackupRstore)
		frmBackupRstore.Show()
		frmBackupRstore.Activate()
	End Sub

	Private Sub Button56_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton56.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch2"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 0
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub tileButton65_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tileButton65.ItemClick
		'Application.Current.Shutdown()
	End Sub

	Private Sub RibbonTab4_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles RibbonTab4.ItemClick
	End Sub

	Private Sub Button53_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton53.ItemClick
		Dim frmSafeGrd As New frmSafeGrd()
		MainClass.ApplyPermissionToForm(frmSafeGrd)
		MainClass.DoApplyUserSett(frmSafeGrd)
		frmSafeGrd.Show()
		frmSafeGrd.Activate()
	End Sub

	Private Sub Button64_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton64.ItemClick
		Dim frmCustomers As New frmCustomers()
		MainClass.ApplyPermissionToForm(frmCustomers)
		MainClass.DoApplyUserSett(frmCustomers)
		frmCustomers.Show()
		frmCustomers.Activate()
	End Sub

	Private Sub Button62_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton62.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 1
		frmSalePurch.Tag = "SalePurch"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 0
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button63_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton63.ItemClick
		Dim frmcurrency As New frmcurrency()
		MainClass.ApplyPermissionToForm(frmcurrency)
		MainClass.DoApplyUserSett(frmcurrency)
		frmcurrency.Show()
		frmcurrency.Activate()
	End Sub

	Private Sub RibbonTab5_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles RibbonTab5.ItemClick
	End Sub

	Private Sub Button24_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton24.ItemClick
		Dim frmNetsales As New frmNetsales()
		MainClass.ApplyPermissionToForm(frmNetsales)
		MainClass.DoApplyUserSett(frmNetsales)
		frmNetsales.Show()
		frmNetsales.Activate()
	End Sub

	Private Sub Button68_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton68.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch5"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 1
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 1
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Button54_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton54.ItemClick
		Dim frmInvSumByType As New frmInvSumByType()
		MainClass.ApplyPermissionToForm(frmInvSumByType)
		MainClass.DoApplyUserSett(frmInvSumByType)
		frmInvSumByType.Show()
		frmInvSumByType.Activate()
	End Sub

	Private Sub RibbonChunk24_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonChunk24.CaptionButtonClick
	End Sub

	Private Sub Button66_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tileButton66.ItemClick
		Dim frmCustAccountGet As New frmCustAccountGet()
		MainClass.ApplyPermissionToForm(frmCustAccountGet)
		MainClass.DoApplyUserSett(frmCustAccountGet)
		frmCustAccountGet.Show()
		frmCustAccountGet.Activate()
	End Sub

	Public Shared Function SendMessage2(username As String, password As String, msg As String, sender As String, numbers As String) As String
		Try
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12)
		Catch ex As Exception
		End Try
		Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(String.Concat(New String() {"http://www.jawalbsms.ws/api.php/sendsms?user=", username, "&pass=", password, "&to=", numbers, "&message=", msg, "&sender=", Form1.SMSSender, "&unicode=u"})), HttpWebRequest)
		httpWebRequest.KeepAlive = False
		Dim streamReader As StreamReader = New StreamReader(httpWebRequest.GetResponse().GetResponseStream())
		Dim result As String = streamReader.ReadToEnd()
		streamReader.Close()
		Return result
	End Function

	Private Shared Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
		Dim webRequest As WebRequest = WebRequest.Create(uri)
		webRequest.ContentLength = CLng(jsonDataBytes.Length)
		webRequest.ContentType = contentType
		webRequest.Method = method
		Dim requestStream As Stream = webRequest.GetRequestStream()
		Dim result As String
		Try
			requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
			requestStream.Close()
			Dim responseStream As Stream = webRequest.GetResponse().GetResponseStream()
			Try
				Dim streamReader As StreamReader = New StreamReader(responseStream)
				Try
					result = streamReader.ReadToEnd()
				Finally
					Dim flag As Boolean = streamReader IsNot Nothing
					If flag Then
						CType(streamReader, IDisposable).Dispose()
					End If
				End Try
			Finally
				Dim flag As Boolean = responseStream IsNot Nothing
				If flag Then
					CType(responseStream, IDisposable).Dispose()
				End If
			End Try
		Finally
			Dim flag As Boolean = requestStream IsNot Nothing
			If flag Then
				CType(requestStream, IDisposable).Dispose()
			End If
		End Try
		Return result
	End Function

	Public Shared Function SendMessage3(username As String, apiKey As String, msg As String, sender As String, numbers As String) As String
		Try
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12)
		Catch ex As Exception
		End Try
		Dim s As String = String.Concat(New String() {"{""userName"":""", username, """,""apiKey"":""", apiKey, """,""numbers"":""", numbers, """,""userSender"":""", sender, """,""msg"":""", msg, """,""msgEncoding"":""UTF8""}"})
		Dim bytes As Byte() = Encoding.UTF8.GetBytes(s)
		Return Form1.SendRequest(New Uri("https://www.msegat.com/gw/sendsms.php"), bytes, "application/json", "POST")
	End Function

	Public Shared Function SendMessage(username As String, password As String, msg As String, sender As String, numbers As String) As String
		Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("http://www.alfa-cell.com/api/msgSend.php"), HttpWebRequest)
		httpWebRequest.Method = "POST"
		httpWebRequest.ContentType = "application/x-www-form-urlencoded"
		Dim text As String = String.Concat(New String() {"mobile=", username, "&password=", password, "&numbers=", numbers, "&sender=", Form1.SMSSender, "&msg=", msg, "&applicationType=61"})
		httpWebRequest.ContentLength = CLng(text.Length)
		Dim streamWriter As StreamWriter = New StreamWriter(httpWebRequest.GetRequestStream(), Encoding.ASCII)
		streamWriter.Write(text)
		streamWriter.Close()
		Dim streamReader As StreamReader = New StreamReader(httpWebRequest.GetResponse().GetResponseStream())
		Dim result As String = streamReader.ReadToEnd()
		streamReader.Close()
		Return result
	End Function

	Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
		Dim frmBackupRstore As New frmBackupRstore()
		Dim flag As Boolean = Not Form1.DoExitProcess
		If Not flag Then
			Try
				Dim flag2 As Boolean = False
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\bkup.txt")
				Dim flag3 As Boolean
				If flag Then
					Dim text As String = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\bkup.txt", Encoding.[Default])
					flag = (Operators.CompareString(text, "", False) <> 0)
					If flag Then
						flag3 = Not text.EndsWith("\")
						If flag3 Then
							text += "\\"
						End If
						text = text + "backUp_" + DateTime.Now.ToString("dd-MM-yyyy")
						frmBackupRstore.RunNunQuary(String.Concat(New String() {"backup database [", MainClass.Database, "] To Disk='", text, ".BAK'"}), "")
						flag2 = True
					End If
				End If
				flag3 = Not flag2
				If flag3 Then
					Dim dialogResult As DialogResult = MessageBox.Show(String.Concat(New String() {"هل تريد النسخ الاحتياطي لقاعدة البيانات؟", Environment.NewLine, Environment.NewLine, "عدم اخذ نسخ احتياطي للبيانات يعرض بياناتك للفقدان في حال تعرض لأي مشاكل", Environment.NewLine, "يفضل أخذ النسخة الاحتياطية في أي مسار غير مسار الويندوز", Environment.NewLine, "(C)"}), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					flag3 = (dialogResult = DialogResult.Yes)
					If flag3 Then
						Dim saveFileDialog As Windows.Forms.SaveFileDialog = New Windows.Forms.SaveFileDialog()
						saveFileDialog.Filter = "BackUp Files (*.BAK)|*.BAK"
						flag3 = (saveFileDialog.ShowDialog() = DialogResult.OK)
						If flag3 Then
							Dim frmBackupRstore2 As frmBackupRstore = New frmBackupRstore()
							frmBackupRstore2.RunNunQuary(String.Concat(New String() {"backup database [", MainClass.Database, "] To Disk='", saveFileDialog.FileName, ".BAK'"}), "")
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Try
				Dim flag3 As Boolean = Me.SMSACTV
				If flag3 Then
					flag = (Me.SMSSALETYPE = 1)
					Dim flag4 As Boolean
					If flag Then
						flag4 = True
						If flag4 Then
							Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(*),sum(tot_net) from inv where proc_type=1 and is_buy=0 and date>=@date and is_deleted=0", Me.conn)
							sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
							Dim dataTable As DataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							Dim str As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
							Dim str2 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
							Dim text2 As String = Me.company_name + " " + Me.branchname + Environment.NewLine
							text2 = text2 + "عدد عمليات البيع اليوم: " + str
							text2 = text2 + Environment.NewLine + "قيمة مبيعات اليوم: " + str2
							flag4 = (Form1.SMS_CompType = 1)
							If flag4 Then
								Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSSALEMOBILE)
							Else
								flag4 = (Form1.SMS_CompType = 2)
								If flag4 Then
									Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text2), Form1.SMSUSERNAME, Me.SMSSALEMOBILE)
								Else
									flag4 = (Form1.SMS_CompType = 3)
									If flag4 Then
										Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text2, Form1.SMSSender, Me.SMSSALEMOBILE)
									End If
								End If
							End If
						End If
					End If
					flag4 = (Me.SMSPURCHTYPE = 1)
					If flag4 Then
						flag3 = True
						If flag3 Then
							Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select count(*),sum(tot_net) from inv where proc_type=1 and is_buy=1 and date>=@date and is_deleted=0", Me.conn)
							sqlDataAdapter2.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
							Dim dataTable2 As DataTable = New DataTable()
							sqlDataAdapter2.Fill(dataTable2)
							Dim str3 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
							Dim str4 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
							Dim text3 As String = Me.company_name + " " + Me.branchname + Environment.NewLine
							text3 = text3 + "عدد عمليات الشراء اليوم: " + str3
							text3 = text3 + Environment.NewLine + "قيمة مشتريات اليوم: " + str4
							flag4 = (Form1.SMS_CompType = 1)
							If flag4 Then
								Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text3), Form1.SMSUSERNAME, Me.SMSPURCHMOBILE)
							Else
								flag4 = (Form1.SMS_CompType = 2)
								If flag4 Then
									Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text3), Form1.SMSUSERNAME, Me.SMSPURCHMOBILE)
								Else
									flag4 = (Form1.SMS_CompType = 3)
									If flag4 Then
										Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text3, Form1.SMSSender, Me.SMSPURCHMOBILE)
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
			'Application.[Exit]()
			Environment.Exit(0)
		End If
	End Sub

	Private Sub RibbonChunk21_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles RibbonChunk21.CaptionButtonClick
	End Sub

	Private Sub Button25_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button25.ItemClick
		Dim frmSandQD As New frmSandQD()
		MainClass.ApplyPermissionToForm(frmSandQD)
		MainClass.DoApplyUserSett(frmSandQD)
		frmSandQD.Show()
		frmSandQD.Activate()
	End Sub

	Private Sub Button26_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnSansSD.ItemClick
		Dim frmSandSD As New frmSandSD()
		MainClass.ApplyPermissionToForm(frmSandSD)
		MainClass.DoApplyUserSett(frmSandSD)
		frmSandSD.Show()
		frmSandSD.Activate()
	End Sub

	Private Sub Button69_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnits.ItemClick
		Dim frmUnits As New frmUnits()
		MainClass.ApplyPermissionToForm(frmUnits)
		MainClass.DoApplyUserSett(frmUnits)
		frmUnits.Show()
		frmUnits.Activate()
	End Sub

	Private Sub Button69_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button69.ItemClick
		Dim frmAbout As New frmAbout()
		Dim flag As Boolean = Operators.CompareString(Me._mif.Trim(), "", False) <> 0
		If flag Then
			frmAbout.Label3.Text = ""
		End If
		frmAbout.Show()
		frmAbout.Activate()
	End Sub

	Private Sub Button70_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnPriceShow.ItemClick
		Dim frmSalePurch As New frmSalePurch()

		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch6"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 3
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 3
		frmSalePurch.Text = "عرض سعر"
		frmSalePurch.lblNote.Text = "إسم العميل"
		frmSalePurch.btnCustAdd.Visible = False
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
		Dim frmItemsExpire As New frmItemsExpire()
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = Not Me._tmrExpire
			If flag Then
				Me._tmrExpire = True
				Me.Timer2.Interval = 300000
			End If
			Dim flag2 As Boolean = True
			Dim num As Integer = 0
			Dim num2 As Integer = System.Windows.Forms.Application.OpenForms.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					GoTo IL_76
				End If
				flag = (Operators.CompareString(System.Windows.Forms.Application.OpenForms(num3).Name, "frmItemsExpire", False) = 0)
				If flag Then
					Exit While
				End If
				num3 += 1
			End While
			flag2 = False
IL_76:
			flag = flag2
			If flag Then
				'Dim thread As Thread = AddressOf Me.chkItemExpire
				Dim thread As New Thread(AddressOf Me.chkItemExpire)
				thread.SetApartmentState(ApartmentState.STA)
				thread.Start()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Sub ApplyLang(ctrl As Control)
		Try
			Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
			If flag Then
				Try
					For Each obj As Object In ctrl.Controls
						Dim control As Control = CType(obj, Control)
						Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
						componentResourceManager.ApplyResources(control, control.Name, New CultureInfo("ar"))
						Me.ApplyLang(control)
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Else
				Dim name As String = ctrl.Name
				' ========================================
				' البيانات الأساسية - Tab 1
				' ========================================
				Me.btnFoundation.Caption = "Company Data"
				Me.btnBranches.Caption = "Branches"
				Me.btnSafes.Caption = "Stores"
				Me.btnCurrencies.Caption = "Items"
				Me.btnTreasuries.Caption = "Safes"
				Me.Button14.Caption = "Item Groups"
				Me.btnUnits.Caption = "Units"
				Me.btnCountries.Caption = "Countries"
				Me.btnCities.Caption = "Cities"
				Me.btnArea.Caption = "Areas"
				Me.btnBanks.Caption = "Banks"
				Me.btnActs.Caption = "Work Fields"
				Me.Button2.Caption = "Company Related Acts"
				Me.btnRest.Caption = "Restaurant"
				Me.MenuItem1.Caption = "Tables Groups"
				Me.MenuItem2.Caption = "Tables"

				' ========================================
				' العملاء والموردين - Tab 2
				' ========================================
				Me.Button5.Caption = "Clients / Suppliers Data"
				Me.btnRptCustBalances.Caption = "Clients Accounts Balance"
				Me.btnRptSuppBalances.Caption = "Suppliers Accounts Balance"
				Me.Button47.Caption = "Client Account Report"
				Me.Button45.Caption = "Client Last Pay"
				Me.btnGifts.Caption = "Gifts"
				Me.btnOffers.Caption = "Offers"
				Me.btnClientInvs.Caption = "Client Purchases"
				Me.btnErsaliaExpenses.Caption = "Ersalia Expenses"
				Me.btnRptErsalia.Caption = "Ersalia Report"
				Me.btnOneClientMonitor.Caption = "Client Monitor Report"
				Me.btnClientsMonitor.Caption = "Clients Monitor Report"
				Me.btnClientsSMS.Caption = "Messages"
				Me.btnSMSMsgs.Caption = "Messages Settings"
				Me.btnClientsSendSMS.Caption = "Clients Send"
				Me.btnClientsSMSAlarm.Caption = "Clients Alert"

				' ========================================
				' شئون الموظفين - Tab 3
				' ========================================
				Me.Button6.Caption = "Managements"
				Me.Button7.Caption = "Departments"
				Me.Button8.Caption = "Employees"
				Me.Button9.Caption = "Salaries Pay"
				Me.Button10.Caption = "Add and Deduction"

				' ========================================
				' مبيعات ومشتريات - Tab 4
				' ========================================
				Me.Button60.Caption = "Purchase Invoice"
				Me.Button15.Caption = "Sales Invoice"
				Me.Button61.Caption = "Purchase Retrieve"
				Me.Button19.Caption = "Sales Retrieve"
				Me.btnPriceShow.Caption = "Quotation"
				Me.Button20.Caption = "First-time stock"
				Me.btnRpt1.Caption = "Invoices By Type"
				Me.btnRpt2.Caption = "Invoices By Clients"
				Me.btnRpt3.Caption = "Invoices in Detail"
				Me.Button43.Caption = "Sales Net Profit"
				Me.Button48.Caption = "Invoices By Employee"
				Me.Button70.Caption = "Restaurant"
				Me.btnManfc.Caption = "Manufacture"
				Me.btnTawlasManage.Caption = "Tables"

				' ========================================
				' سندات - Tab 5
				' ========================================
				Me.Button16.Caption = "Out Receipts Bonds"
				Me.Button17.Caption = "Out Exchange Bonds"
				Me.Button39.Caption = "View Out Bonds"
				Me.Button40.Caption = "View In Bonds"
				Me.Button25.Caption = "In Receipts Bonds"
				Me.btnSansSD.Caption = "In Exchange Bonds"
				Me.btnCostCenter.Caption = "Cost Centers"
				Me.btnRptCostCenter.Caption = "Cost Centers Report"

				' ========================================
				' الحسابات - Tab 6
				' ========================================
				Me.Button18.Caption = "Accounts Tree"
				Me.btnDailyJournals.Caption = "Daily Restrictions"
				Me.btnOpenJournal.Caption = "Open Journal"
				Me.btnRptAcc.Caption = "Accounts Report"
				Me.Button28.Caption = "Main Audit Balance"
				Me.Button29.Caption = "Analytical Audit Balance"
				Me.Button30.Caption = "Profit and Loss of Main Accounts"
				Me.Button31.Caption = "Profit and Loss Analytical"
				Me.Button32.Caption = "Balance Sheet Major Accounts"
				Me.Button33.Caption = "Balance Sheet Analytical Accounts"

				' ========================================
				' المخازن - Tab 7
				' ========================================
				Me.Button34.Caption = "Transfer from Store to Store"
				Me.btnM5znTsweya.Caption = "Stock Adjustment"
				Me.Button35.Caption = "Inventory Stores"
				Me.Button36.Caption = "Stores Balances to Date"
				Me.Button38.Caption = "Defined Item Movement"
				Me.Button37.Caption = "Tot Movements of Item Report"
				Me.Button23.Caption = "Expired Items"

				' ========================================
				' دعم اتخاذ القرار - Tab 8
				' ========================================
				Me.Button46.Caption = "Rotation Rate and Stagnation of Items"

				' ========================================
				' اجمالي بيع وشراء - Tab 10
				' ========================================
				Me.Button49.Caption = "Total Different Entities"
				Me.Button50.Caption = "Total Sales and Purchases"
				Me.Button4.Caption = "Total Sales and Purchases by Entity or Client"
				Me.Button1.Caption = "Daily Process Report"
				Me.Button41.Caption = "Sales Analysis Report"
				Me.Button42.Caption = "Safe Process Report"
				Me.btnRptSalesTax.Caption = "Sales VAT Report"
				Me.btnRptPurchTax.Caption = "Purchases VAT Report"
				Me.btnRptTotal.Caption = "Day Total Report"
				Me.btnRptItemsDaily.Caption = "Items Sales Report"
				Me.btnRptZatca.Caption = "ZATCA Report"
				Me.btnRptMobApp.Caption = "Mobile App Report"

				' ========================================
				' اعدادات النظام - Tab 11
				' ========================================
				Me.Button51.Caption = "Add User"
				Me.btnUserPerm.Caption = "User Permissions"
				Me.Button58.Caption = "Change Password"
				Me.Button3.Caption = "Control Sale and Purchase Items"
				Me.Button22.Caption = "Default Print Option"
				Me.btnBkUp.Caption = "Backup and Restore"
				Me.Button59.Caption = "User Properties"
				Me.btnSMSSett.Caption = "SMS Settings"
				Me.btnYearClose.Caption = "Fiscal Year Closing"
				Me.btnLogin.Caption = "Branch Login"

				' ========================================
				' الدعم الفني - Tab 12
				' ========================================
				Me.Button12.Caption = "Purchase Program"
				Me.Button13.Caption = "Activate Program"
				Me.Button69.Caption = "About"
				Try
					For Each obj2 As Object In ctrl.Controls
						Dim control2 As Control = CType(obj2, Control)
						Dim componentResourceManager2 As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
						componentResourceManager2.ApplyResources(control2, control2.Name, New CultureInfo("en-us"))
						Me.ApplyLang(control2)
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

	Public Sub New()
		AddHandler MyBase.KeyDown, AddressOf Me.Form1_KeyDown
		AddHandler MyBase.Load, AddressOf Me.Form1_Load
		AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
		Form1.__ENCAddToList(Me)
		Me.conn = MainClass.ConnObj()
		Me.conn1 = MainClass.ConnObj()
		Me.SMSACTV = False
		Me.SMSSALETYPE = 1
		Me.SMSSALEMOBILE = ""
		Me.SMSPURCHTYPE = 1
		Me.SMSPURCHMOBILE = ""
		Me.SMSLOGINACTV = False
		Me.SMSLOGINMOBILE = ""
		Me.company_name = ""
		Me.branchname = ""
		Me._isfoundedupdate = False
		Me._mif = ""
		Me._SMSSALETIMEDONe = False
		Me._SMSPURCHTIMEDONE = False
		Me._tmrExpire = False
		Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar")
		Me.InitializeComponent()
	End Sub

	Private Sub Button1_Activate_3(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.ItemClick
		Dim frmRptDailyProcess As New frmRptDailyProcess()
		frmRptDailyProcess.Show()
		frmRptDailyProcess.Activate()
	End Sub

	Private Sub Button41_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button41.ItemClick
		Dim frmRptInvAnalysis As New frmRptInvAnalysis()
		frmRptInvAnalysis.Show()
		frmRptInvAnalysis.Activate()
	End Sub

	Private Sub Button42_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button42.ItemClick
		Dim frmRptKhzna As New frmRptKhzna()
		frmRptKhzna.Show()
		frmRptKhzna.Activate()
	End Sub

	Private Sub Button70_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button70.ItemClick
		Dim frmSalePurchRest As New frmSalePurchRest()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing
		frmSalePurchRest.InvProc = 2
		frmSalePurchRest.Tag = "SalePurch2"
		MainClass.ApplyPermissionToForm(frmSalePurchRest)
		MainClass.DoApplyUserSett(frmSalePurchRest)
		frmSalePurchRest.cmbProcType.SelectedIndex = 0
		frmSalePurchRest.cmbProcTypeSrch.SelectedIndex = 0
		frmSalePurchRest.Show()
		frmSalePurchRest.WindowState = FormWindowState.Maximized
		frmSalePurchRest.Activate()
	End Sub

	Private Sub Button71_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnGifts.ItemClick
		Dim frmGifts As New frmGifts()
		frmGifts.Show()
		frmGifts.Activate()
	End Sub

	Private Sub btnSMSSett_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnSMSSett.ItemClick
		Dim frmSMSSett As New frmSMSSett()
		frmSMSSett.Show()
		frmSMSSett.Activate()
	End Sub

	Private Sub btnLogin_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.ItemClick
		Dim frmUserLogin As New frmUserLogin()
		frmUserLogin.ShowDialog()
		frmUserLogin.Left = CInt(Math.Round(CDbl(Me.Width) / 2.0 - CDbl(frmUserLogin.Width) / 2.0))
		frmUserLogin.Top = CInt(Math.Round(CDbl(Me.Height) / 2.0 - CDbl(frmUserLogin.Height) / 2.0 + 200.0))
		Me.ProcAfterLogin()
	End Sub

	Private Sub btnOffers_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnOffers.ItemClick
		Dim frmOffers As New frmOffers()
		Dim frmOffers2 As New frmOffers2()
		Dim num As Integer = 1
		Dim flag As Boolean
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select offer_type from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)(0), 2, False)
			If flag Then
				num = 2
			End If
		Catch ex As Exception
		End Try
		flag = (num = 1)
		If flag Then
			frmOffers.Show()
			frmOffers.Activate()
		Else
			frmOffers2.Show()
			frmOffers2.Activate()
		End If
	End Sub

	Private Sub btnYearClose_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnYearClose.ItemClick
		Dim frmFinancialYearClose As New frmFinancialYearClose()
		frmFinancialYearClose.Show()
		frmFinancialYearClose.Activate()
	End Sub

	Private Sub btnClientInvs_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientInvs.ItemClick
		Dim frmClientInvs As New frmClientInvs()
		frmClientInvs.Show()
		frmClientInvs.Activate()
	End Sub

	Private Sub btnManfc_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnManfc.ItemClick
		Dim frmSalePurch As New frmSalePurch()

		frmSalePurch.Text = "إنتاج"
		frmSalePurch.IS_manfc = True
		frmSalePurch.Tag = "SalePurch3"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 2
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 2
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub btnErsaliaExpenses_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnErsaliaExpenses.ItemClick
		Dim frmErsaliaExpenses As New frmErsaliaExpenses()
		frmErsaliaExpenses.Show()
		frmErsaliaExpenses.Activate()
	End Sub

	Private Sub btnRptErsalia_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptErsalia.ItemClick
		Dim frmRptErsalia As New frmRptErsalia()
		frmRptErsalia.Show()
		frmRptErsalia.Activate()
	End Sub

	Private Sub Button71_Activate_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientsMonitor.ItemClick
		Dim frmRptClientsMaint As New frmRptClientsMaint()
		frmRptClientsMaint.Show()
		frmRptClientsMaint.Activate()
	End Sub

	Private Sub btnOneClientMonitor_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnOneClientMonitor.ItemClick
		Dim frmRptClientMaintDetails As New frmRptClientMaintDetails()
		frmRptClientMaintDetails.Show()
		frmRptClientMaintDetails.Activate()
	End Sub

	Private Sub btnSMSMsgs_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnSMSMsgs.ItemClick
		Dim frmSMSMsgs As New frmSMSMsgs()
		frmSMSMsgs.Show()
		frmSMSMsgs.Activate()
	End Sub

	Private Sub btnClientsSendSMS_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientsSendSMS.ItemClick
		Dim frmClientsSendSms As New frmClientsSendSms()
		frmClientsSendSms.Show()
		frmClientsSendSms.Activate()
	End Sub

	Private Sub btnClientsSMSAlarm_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientsSMSAlarm.ItemClick
		Dim frmClientsSMSAlarm As New frmClientsSMSAlarm()
		frmClientsSMSAlarm.Show()
		frmClientsSMSAlarm.Activate()
	End Sub

	Private Sub btnRptSalesTax_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptSalesTax.ItemClick
		Dim frmRptSalesTax As New frmRptSalesTax()
		frmRptSalesTax.Show()
	End Sub

	Private Sub btnRptPurchTax_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptPurchTax.ItemClick
		Dim frmRptSalesTax As New frmRptSalesTax()
		'New frmRptSalesTax() With { .Text = "تقرير ضريبة المشتريات", .is_buy = 1 }.Show()
		Using frm As New frmRptSalesTax()
			frm.Text = "تقرير ضريبة المشتريات"
			frm.is_buy = 1
			frm.Show()
		End Using
	End Sub

	Private Sub btnRptTotal_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptTotal.ItemClick
		Dim frmRptTotal As New frmRptTotal()
		frmRptTotal.Show()
	End Sub

	Private Sub btnRptItemsDaily_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptItemsDaily.ItemClick
		Dim frmRptItemsDaily As New frmRptItemsDaily()
		frmRptItemsDaily.Show()
		frmRptItemsDaily.Activate()
	End Sub

	Private Sub btnRptSuppBalances_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptSuppBalances.ItemClick
		Dim frmCustAccount As New frmCustAccount()
		frmCustAccount._type = 2
		MainClass.ApplyPermissionToForm(frmCustAccount)
		MainClass.DoApplyUserSett(frmCustAccount)
		frmCustAccount.Show()
		frmCustAccount.Activate()
	End Sub

	Private Sub MenuItem1_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem1.ItemClick
		Dim frmTawlaGroups As New frmTawlaGroups()
		frmTawlaGroups.Show()
		frmTawlaGroups.Activate()
	End Sub

	Private Sub MenuItem2_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem2.ItemClick
		Dim frmTawlas As New frmTawlas()
		frmTawlas.Show()
		frmTawlas.Activate()
	End Sub

	Private Sub btnTawlasManage_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnTawlasManage.ItemClick
		Dim frmTawlasManage As New frmTawlasManage()
		frmTawlasManage.Show()
		frmTawlasManage.Activate()
	End Sub

	Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3.Tick
		Dim isfoundedupdate As Boolean = Me._isfoundedupdate
		If isfoundedupdate Then
			Me.Timer3.Enabled = False
			Me.lnkUpdate.Visible = True
		Else
			'Dim thread As Thread = AddressOf Me.ChkAppUpdates
			Dim thread As New Thread(AddressOf Me.ChkAppUpdates)
			thread.Start()
		End If
	End Sub

	Private Sub lnkUpdate_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkUpdate.Click
		Try
			Process.Start(System.Windows.Forms.Application.StartupPath + "\\update.exe")
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button72_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnCostCenter.ItemClick
		Dim frmCostCenter As New frmCostCenter()
		frmCostCenter.Show()
		frmCostCenter.Activate()
	End Sub

	Private Sub btnRptCostCenter2_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptCostCenter.ItemClick
		Dim frmRptCostCenterDetailed As New frmRptCostCenterDetailed()
		frmRptCostCenterDetailed.Show()
		frmRptCostCenterDetailed.Activate()
	End Sub

	Private Sub btnM5znTsweya_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnM5znTsweya.ItemClick
		Dim frmM5znTsweya As New frmM5znTsweya()
		frmM5znTsweya.Show()
		frmM5znTsweya.Activate()
	End Sub

	Private Sub PBCustAcc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBCustAcc.Click
		Dim frmCustAccountGet As New frmCustAccountGet()
		MainClass.ApplyPermissionToForm(frmCustAccountGet)
		MainClass.DoApplyUserSett(frmCustAccountGet)
		frmCustAccountGet.Show()
		frmCustAccountGet.rdAllClients.Checked = True
		frmCustAccountGet.chkAll.Checked = True
		frmCustAccountGet.Activate()
	End Sub

	Private Sub PBSuppAcc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBSuppAcc.Click
		Dim frmCustAccountGet As New frmCustAccountGet()
		MainClass.ApplyPermissionToForm(frmCustAccountGet)
		MainClass.DoApplyUserSett(frmCustAccountGet)
		frmCustAccountGet.Show()
		frmCustAccountGet.rdAllSuppliers.Checked = True
		frmCustAccountGet.chkAll.Checked = True
		frmCustAccountGet.Activate()
	End Sub

	Private Sub btnOpenJournal_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenJournal.ItemClick
		Dim frmOpenRestrictions As New frmOpenRestrictions()
		frmOpenRestrictions.Show()
		frmOpenRestrictions.Activate()
	End Sub

	Private Sub btnPurchOrder_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnPurchOrder.ItemClick
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch.InvProc = 1
		frmSalePurch.Tag = "SalePurch"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 4
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 4
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub MenuItem3_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem3.ItemClick
		Dim frmMobApps As New frmMobApps()
		frmMobApps.Show()
		frmMobApps.Activate()
	End Sub

	Private Sub btnRptMobApp_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptMobApp.ItemClick
		Dim frmRptMobApp As New frmRptMobApp()
		frmRptMobApp.Show()
		frmRptMobApp.Activate()
	End Sub

	Private Sub PBRetSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PBRetSales.Click
		Dim frmSalePurch As New frmSalePurch()
		Me.RibbonTab1.Ribbon.SelectedPage = Nothing

		frmSalePurch._IsCreditNote = True
		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch5"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 1
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 1
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub btnRptZatca_Activate(ByVal sender As Object, ByVal e As EventArgs) Handles btnRptZatca.ItemClick
		Dim frmRptZatca As New frmRptZatca()
		frmRptZatca.Show()
		frmRptZatca.Activate()
	End Sub
End Class