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
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Imports DevExpress.Internal

Partial Public Class frmUserLogin
	Inherits Form

	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Public conn As SqlConnection

	Public conn1 As SqlConnection

	Public txtServer As String

	Public DBName As String

	Public userid As String

	Public pwd As String

	Public conn_type As Integer
	Shared Sub New()
	End Sub

	Public Sub New()
		AddHandler MyBase.FormClosing, AddressOf Me.frmUserLogin_FormClosing
		AddHandler MyBase.KeyDown, AddressOf Me.frmUserLogin_KeyDown
		AddHandler MyBase.Load, AddressOf Me.frmUserLogin_Load
		frmUserLogin.__ENCAddToList(Me)
		Me.conn = MainClass.ConnObj()
		Me.conn1 = MainClass.ConnObj()
		Me.txtServer = ""
		Me.DBName = "StockDB-Basem"
		Me.userid = ""
		Me.pwd = ""
		Me.conn_type = 1
		Me.InitializeComponent()
	End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmUserLogin.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmUserLogin.__ENCList.Count = frmUserLogin.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmUserLogin.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmUserLogin.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmUserLogin.__ENCList(num) = frmUserLogin.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmUserLogin.__ENCList.RemoveRange(num, frmUserLogin.__ENCList.Count - num)
				frmUserLogin.__ENCList.Capacity = frmUserLogin.__ENCList.Count
			End If
			frmUserLogin.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Public Function MUL(no As Long, x As Integer) As Long
		' The following expression was wrapped in a checked-expression
		' The following expression was wrapped in a unchecked-expression
		Return no * CLng(x)
	End Function

	Private Function LoadSerial() As String
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

	Private Sub chkLimit()
		' The following expression was wrapped in a checked-statement
		Try
			Dim frmItemsLimit As frmItemsLimit = New frmItemsLimit()
			Dim flag As Boolean = False
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Currencies  where IS_Deleted=0", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			Dim flag2 As Boolean
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Try
					Dim num6 As Integer = Me.CalcStock(Conversions.ToInteger(dataTable.Rows(num3)("id")))
					flag2 = (num6 <= Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("limit"))))
					If flag2 Then
						flag = True
						frmItemsLimit.dgvData.Rows.Add()
						frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
						Try
							frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(1).Value = Me.GetGroupName(Conversions.ToInteger(dataTable.Rows(num3)("group_id")))
						Catch ex As Exception
						End Try
						flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
						If flag2 Then
							frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("symbol"))
						Else
							frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nameEN"))
						End If
						frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("purch_price"))
						frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))
						frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(5).Value = num6
						frmItemsLimit.dgvData.Rows(frmItemsLimit.dgvData.Rows.Count - 1).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("limit"))
					End If
				Catch ex2 As Exception
				End Try
				num3 += 1
			End While
			flag2 = flag
			If flag2 Then
				flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				Dim text As String
				If flag2 Then
					text = "توجد أصناف وصلت لحد الطلب، هل تريد عرض هذه الأصناف"
				Else
					text = "There are items reach request limit, do you want to view it"
				End If
				Dim dialogResult As DialogResult = MessageBox.Show(text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				flag2 = (dialogResult = DialogResult.Yes)
				If flag2 Then
					frmItemsLimit.ShowDialog()
				End If
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub Login()
		Try
			If String.IsNullOrWhiteSpace(Me.txtUser.Text) Then
				MessageBox.Show("ادخل اسم المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Me.txtUser.Focus()
				Return
			End If

			If String.IsNullOrWhiteSpace(Me.txtPwd.Text) Then
				MessageBox.Show("ادخل كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Me.txtPwd.Focus()
				Return
			End If

			If Me.cmbBranches.SelectedValue Is Nothing Then
				MessageBox.Show("يجب اختيار الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Me.cmbBranches.Focus()
				Return
			End If

			MainClass.Database = Me.cmbYear.Text.Replace("Database", Me.DBName)

			' إنشاء الاتصال
			If Me.conn_type = 1 Then
				Me.conn = New SqlConnection($"server={Me.txtServer};database={MainClass.Database};trusted_connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;")
				Me.conn1 = New SqlConnection($"server={Me.txtServer};database={MainClass.Database};trusted_connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;")
				MainClass.connstr = $"server={Me.txtServer};database={MainClass.Database};trusted_connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;"
			Else
				Me.conn = New SqlConnection($"server={Me.txtServer};database={MainClass.Database};user id={Me.userid};pwd={Me.pwd};MultipleActiveResultSets=true;TrustServerCertificate=True;")
				Me.conn1 = New SqlConnection($"server={Me.txtServer};database={MainClass.Database};user id={Me.userid};pwd={Me.pwd};MultipleActiveResultSets=true;TrustServerCertificate=True;")
				MainClass.connstr = $"server={Me.txtServer};database={MainClass.Database};user id={Me.userid};pwd={Me.pwd};MultipleActiveResultSets=true;TrustServerCertificate=True;"
			End If
			Dim form1 As New Form1()
			form1.conn = Me.conn
			Form1.conn1 = Me.conn1

			' التحقق من المستخدم
			Dim adapter As New SqlDataAdapter($"SELECT * FROM Users WHERE username='{Me.txtUser.Text}' AND pwd='{Me.txtPwd.Text}'", Me.conn)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count = 0 Then
				MessageBox.Show("دخول غير صحيح", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Me.txtUser.Focus()
				Return
			End If

			' التحقق من الفرع
			Dim branchAdapter As New SqlDataAdapter($"SELECT branch FROM EmpBranches WHERE emp={dt.Rows(0)("emp")} AND branch={Me.cmbBranches.SelectedValue}", Me.conn)
			Dim branchDt As New DataTable()
			branchAdapter.Fill(branchDt)

			If branchDt.Rows.Count = 0 Then
				MessageBox.Show("ليس لديك صلاحية لدخول هذا الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Me.cmbBranches.Focus()
				Return
			End If

			Me.Cursor = Cursors.WaitCursor

			' إعداد اللغة
			If Me.rdAr.Checked Then
				Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("ar")
				MainClass.Language = "ar"
			Else
				Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("en-us")
				MainClass.Language = "en"
			End If

			' حفظ بيانات المستخدم
			MainClass.UserID = CInt(dt.Rows(0)("id"))
			MainClass.EmpNo = CInt(dt.Rows(0)("emp"))
			MainClass.UserName = dt.Rows(0)("username").ToString()
			MainClass.BranchNo = CInt(Me.cmbBranches.SelectedValue)
			MainClass.Server = Me.txtServer

			' إعداد الواجهة
			If MainClass.Language = "ar" Then
				Form1.txtLoggedUser.Caption = "المستخدم: " & MainClass.UserName
				Form1.lblBranch.Caption = "الفرع: " & Me.cmbBranches.Text
			Else
				Form1.txtLoggedUser.Caption = "user: " & MainClass.UserName
				Form1.lblBranch.Caption = "branch: " & Me.cmbBranches.Text
			End If

			Form1.lblDash1.Caption = "|"
			Form1.lblDash2.Caption = "|"

			' ★★★ حفظ الإعدادات مشفرة ★★★
			Dim mgr As New SecureDatabaseManager(Me.txtServer, Me.DBName)
			mgr.SaveSettings(MainClass.BranchNo, Me.txtUser.Text, Me.txtPwd.Text, Me.chkRemember.Checked)

			' عرض النافذة الرئيسية
			Form1.Activate()
			Me.Hide()

		Catch ex As Exception
			MessageBox.Show("حدث خطأ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Function GetGroupName(group As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from groups where id=" + Conversions.ToString(group), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function CalcStock(curr As Integer) As Integer
		' The following expression was wrapped in a checked-statement
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("currency")
			dataTable.Columns.Add("sum")
			dataTable.Columns.Add("type")
			Dim text As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val) from inv,inv_sub where ", text, "  Inv_Sub.currency_from=", Conversions.ToString(curr), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from"}), Me.conn1)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable2.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1})
				num3 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val) from inv,inv_sub where ", text, "  Inv_Sub.currency_from=", Conversions.ToString(curr), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from"}), Me.conn1)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num6 As Integer = 0
			Dim num7 As Integer = dataTable2.Rows.Count - 1
			Dim num8 As Integer = num6
			While True
				Dim num9 As Integer = num8
				Dim num5 As Integer = num7
				If num9 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 2})
				num8 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val) from inv,inv_sub where ", text, "  Inv_Sub.currency_from=", Conversions.ToString(curr), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from"}), Me.conn1)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num10 As Integer = 0
			Dim num11 As Integer = dataTable2.Rows.Count - 1
			Dim num12 As Integer = num10
			While True
				Dim num13 As Integer = num12
				Dim num5 As Integer = num11
				If num13 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 3})
				num12 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val) from inv,inv_sub where ", text, "  Inv_Sub.currency_from=", Conversions.ToString(curr), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from"}), Me.conn1)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num14 As Integer = 0
			Dim num15 As Integer = dataTable2.Rows.Count - 1
			Dim num16 As Integer = num14
			While True
				Dim num17 As Integer = num16
				Dim num5 As Integer = num15
				If num17 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 4})
				num16 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val) from inv,inv_sub where ", text, "  Inv_Sub.currency_from=", Conversions.ToString(curr), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from"}), Me.conn1)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num18 As Integer = 0
			Dim num19 As Integer = dataTable2.Rows.Count - 1
			Dim num20 As Integer = num18
			While True
				Dim num21 As Integer = num20
				Dim num5 As Integer = num19
				If num21 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 5})
				num20 += 1
			End While
			Dim num22 As Integer = dataTable.Rows.Count - 1
			Dim num23 As Integer = 0
			Dim num24 As Integer = num22
			Dim num25 As Integer = num23
			Dim flag3 As Boolean
			While True
				Dim num26 As Integer = num25
				Dim num5 As Integer = num24
				If num26 > num5 Then
					Exit While
				End If
				Dim num27 As Integer = num25 + 1
				Dim num28 As Integer = num22
				Dim num29 As Integer = num27
				While True
					Dim num30 As Integer = num29
					num5 = num28
					If num30 > num5 Then
						Exit While
					End If
					flag = (num29 <= num22)
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num25)(0), dataTable.Rows(num29)(0), False)
						If flag2 Then
							flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num25)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num25)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num25)(2), 7, False)))

							If flag3 Then
								dataTable.Rows(num25)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(1)))
							End If
							flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num29)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num29)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num29)(2), 7, False)))
							If flag3 Then
								dataTable.Rows(num29)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1)))
							End If
							dataTable.Rows(num25)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1)))
							dataTable.Rows.RemoveAt(num29)

							num29 -= 1
							num22 -= 1
						End If
					End If
					num29 += 1
				End While
				num25 += 1
			End While
			flag3 = (dataTable.Rows.Count > 0)
			If flag3 Then
				Return CInt(Math.Round(Conversion.Val(dataTable.Rows(0)(1).ToString())))
			End If
		Catch ex As Exception
		End Try
		Return 0
	End Function

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		Me.Login()
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		'Form1.Close()
	End Sub

	Private Sub frmUserLogin_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
		Try
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtPwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown
		Try
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.Login()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub frmUserLogin_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		Try
			Dim flag As Boolean = e.KeyCode = Keys.F4
			If flag Then
				e.Handled = True
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Sub LoadBranches()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbBranches.DataSource = dataTable
		Me.cmbBranches.DisplayMember = "name"
		Me.cmbBranches.ValueMember = "id"
		Me.cmbBranches.SelectedIndex = -1
		Dim flag As Boolean = Me.cmbBranches.Items.Count > 0
		If flag Then
			Me.cmbBranches.SelectedIndex = 0
		End If
	End Sub

	Private Sub chkDBExist()
		Try
			Dim sqlConnection As SqlConnection = New SqlConnection("server=.\DATAWORLD;trusted_connection=true")
			Try
				sqlConnection.Open()
			Catch ex As Exception
				Interaction.MsgBox("تاكد من وجود خادم السيكول لقاعدة البيانات", MsgBoxStyle.OkOnly, Nothing)
				Return
			End Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases WHERE name = 'StockDB-Basem'", sqlConnection)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count = 0
			If flag Then
				Dim text As String = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\script.sql", Encoding.[Default])
				Dim sqlCommand As SqlCommand = New SqlCommand("create database [StockDB-Basem]", sqlConnection)
				sqlCommand.ExecuteNonQuery()
				Dim separator As String() = New String() {"GO"}
				Dim array As String() = text.Split(separator, StringSplitOptions.RemoveEmptyEntries)
				For Each cmdText As String In array
					sqlCommand = New SqlCommand(cmdText, sqlConnection)
					sqlCommand.ExecuteNonQuery()
				Next
			End If
			Try
				sqlConnection.Close()
			Catch ex2 As Exception
			End Try
		Catch ex3 As Exception
		End Try
	End Sub

	Public Sub LoadYearsDB(_dbname As String)
		' The following expression was wrapped in a checked-statement
		Try
			Me.cmbYear.Items.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM master.dbo.sysdatabases", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			Dim flag2 As Boolean
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim flag As Boolean = dataTable.Rows(num3)("name").ToString().ToLower().Contains(_dbname.ToLower())
				If flag Then
					flag2 = (Operators.CompareString(dataTable.Rows(num3)("name").ToString().ToLower().Replace(_dbname.ToLower(), ""), "2", False) <> 0)
					If flag2 Then
						Me.cmbYear.Items.Add(dataTable.Rows(num3)("name").ToString().ToLower().Replace(_dbname.ToLower(), "Database"))
					End If
				End If
				num3 += 1
			End While
			flag2 = (Me.cmbYear.Items.Count > 0)
			If flag2 Then
				Me.cmbYear.SelectedIndex = 0
				Dim num6 As Integer = 0
				Dim num7 As Integer = Me.cmbYear.Items.Count - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					Dim num5 As Integer = num7
					If num9 > num5 Then
						GoTo IL_1AC
					End If
					flag2 = Me.cmbYear.Items(num8).ToString().Contains(DateTime.Now.Year.ToString())
					If flag2 Then
						Exit While
					End If
					num8 += 1
				End While
				Me.cmbYear.SelectedIndex = num8
			End If
IL_1AC:
		Catch ex As Exception
		End Try
	End Sub

	Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Control.CheckForIllegalCrossThreadCalls = False

		Dim dataPath As String = System.Windows.Forms.Application.StartupPath & "\Data.txt"

		' إذا لم يوجد ملف الإعدادات
		If Not IO.File.Exists(dataPath) Then
			Dim frm As New frmDatabaseSetup()
			frm.ShowDialog()

			If Not frm.SetupCompleted Then
				System.Windows.Forms.Application.Exit()
				Return
			End If
		End If

		Try
			' قراءة الإعدادات المشفرة
			Dim s = SecureDatabaseManager.LoadSettings()

			If s Is Nothing Then
				' الملف تالف أو غير مشفر، حاول القراءة بالطريقة القديمة
				s = LoadSettingsLegacy(dataPath)
			End If

			If s Is Nothing Then
				MessageBox.Show("ملف الإعدادات تالف!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Try : IO.File.Delete(dataPath) : Catch : End Try

				Dim frm As New frmDatabaseSetup()
				frm.ShowDialog()

				If frm.SetupCompleted Then
					s = SecureDatabaseManager.LoadSettings()
				Else
					System.Windows.Forms.Application.Exit()
					Return
				End If
			End If

			Me.txtServer = s.Server
			Me.DBName = s.Database

			If Not String.IsNullOrEmpty(s.SqlUser) AndAlso Not String.IsNullOrEmpty(s.SqlPassword) Then
				Me.conn_type = 2
				Me.userid = s.SqlUser
				Me.pwd = s.SqlPassword
				Me.conn = New SqlConnection($"server={s.Server};database={s.Database};user id={s.SqlUser};pwd={s.SqlPassword};TrustServerCertificate=True;")
			Else
				Me.conn_type = 1
				Me.conn = New SqlConnection($"server={s.Server};database={s.Database};trusted_connection=true;TrustServerCertificate=True;")
			End If

			' تحديث MainClass
			MainClass.Server = s.Server
			MainClass.Database = s.Database
			If Me.conn_type = 2 Then
				MainClass.connstr = $"server={s.Server};database={s.Database};user id={Me.userid};pwd={Me.pwd};MultipleActiveResultSets=true;TrustServerCertificate=True;"
			Else
				MainClass.connstr = $"server={s.Server};database={s.Database};trusted_connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;"
			End If

			Me.LoadBranches()
			Me.LoadYearsDB(Me.DBName)

			If s.BranchId > 0 Then
				Try : Me.cmbBranches.SelectedValue = s.BranchId : Catch : End Try
			End If

			If s.Remember AndAlso Not String.IsNullOrEmpty(s.UserName) Then
				Me.chkRemember.Checked = True
				Me.txtUser.Text = s.UserName
				Me.txtPwd.Text = s.Password
				Me.btnLogin.Focus()
			Else
				Me.chkRemember.Checked = False
				Me.txtUser.Focus()
			End If

		Catch ex As Exception
			Dim frm As New frmDatabaseSetup()
			frm.ShowDialog()
		End Try
	End Sub

	''' <summary>
	''' قراءة الإعدادات بالطريقة القديمة (للتوافق)
	''' </summary>
	Private Function LoadSettingsLegacy(path As String) As SecureDatabaseManager.Settings
		Try
			Dim array = IO.File.ReadAllLines(path, Encoding.Default)
			If array.Length < 6 Then Return Nothing

			Dim s As New SecureDatabaseManager.Settings()
			s.Remember = (array(0).Trim() = "1")

			Dim serverLine = array(1).Trim()
			If serverLine.Contains(";") Then
				Dim parts = serverLine.Split(";"c)
				s.Server = parts(0)
				If parts.Length > 1 Then s.SqlUser = parts(1)
				If parts.Length > 2 Then s.SqlPassword = parts(2)
			Else
				s.Server = serverLine
			End If

			s.BranchId = CInt(Val(array(2).Trim()))
			s.UserName = array(3).Trim()
			s.Password = array(4).Trim()
			s.Database = array(5).Trim()

			Return s
		Catch
			Return Nothing
		End Try
	End Function

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Dim frmServerSetting As New frmServerSetting()
		Try
			Dim flag As Boolean = Me.conn_type = 1
			If flag Then
				frmServerSetting.txtServer.Text = Me.txtServer
			Else
				frmServerSetting.txtServer.Text = Me.txtServer
				frmServerSetting.rdNetwork.Checked = True
				frmServerSetting.txtUser.Text = Me.userid
				frmServerSetting.txtPWD.Text = Me.pwd
			End If
			frmServerSetting._DBName = Me.DBName
			frmServerSetting.ShowDialog()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
		Dim flag As Boolean = e.KeyData = Keys.[Return]
		If flag Then
			Me.txtPwd.Focus()
		End If
	End Sub

	Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
	End Sub

	Private Sub cmbBranches_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBranches.KeyDown
		Dim flag As Boolean = e.KeyData = Keys.[Return]
		If flag Then
			Me.txtUser.Focus()
		End If
	End Sub

	Private Sub rdAr_CheckedChanged(sender As Object, e As EventArgs) Handles rdAr.CheckedChanged
		Dim flag As Boolean = Me.rdAr.Checked
		If flag Then
			Try
				For Each obj As Object In Me.Controls
					Dim control As Control = CType(obj, Control)
					Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar")
					MainClass.Language = "ar"
					Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(frmUserLogin))
					componentResourceManager.ApplyResources(control, control.Name, New CultureInfo("ar"))
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
				For Each obj2 As Object In Me.Controls
					Dim control2 As Control = CType(obj2, Control)
					Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-us")
					MainClass.Language = "en"
					Dim componentResourceManager2 As ComponentResourceManager = New ComponentResourceManager(GetType(frmUserLogin))
					componentResourceManager2.ApplyResources(control2, control2.Name, New CultureInfo("en-us"))
				Next
			Finally
				Dim enumerator2 As IEnumerator
				flag = (TypeOf enumerator2 Is IDisposable)
				If flag Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
		End If
	End Sub

	Private Sub rdEn_CheckedChanged(sender As Object, e As EventArgs) Handles rdEn.CheckedChanged
	End Sub
End Class
