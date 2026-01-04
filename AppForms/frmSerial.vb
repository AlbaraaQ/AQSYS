Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
	Public Partial Class frmSerial
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSerial_Load
			AddHandler MyBase.KeyDown, AddressOf Me.frmSerial_KeyDown
			frmSerial.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmSerial.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmSerial.__ENCList.Count = frmSerial.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmSerial.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmSerial.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmSerial.__ENCList(num) = frmSerial.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmSerial.__ENCList.RemoveRange(num, frmSerial.__ENCList.Count - num)
					frmSerial.__ENCList.Capacity = frmSerial.__ENCList.Count
				End If
				frmSerial.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

	Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		Dim frmBuyApp As New frmBuyApp()
		frmBuyApp.Activate()
		frmBuyApp.ShowDialog()
	End Sub

	Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
			Me.Close()
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
				result = ""
			End Try
			Return result
		End Function

	Private Sub UpdateExpireDate()
		Dim form1 As New Form1()
		Try
			Dim str As String = ""
			Dim flag As Boolean
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				If flag Then
					str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				End If
			Catch ex As Exception
			End Try
			Dim value As String = ""
			Dim flag2 As Boolean = False
			Dim left As String = ""
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select date_exp,open_expire from foundation where id=1", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)(0)), "", False)
				If flag Then
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
					flag2 = True
				End If
				Try
					left = MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("open_expire"))), MainClass._enckey)
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
			flag = Not flag2
			If flag Then
				Try
					value = MainClass.Encrypt(DateTime.Now.AddYears(1).ToString("dd/MM/yyyy"), MainClass._enckey)
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update foundation set date_exp=@date_exp where id=1", Me.conn)
					sqlCommand.Parameters.Add("@date_exp", SqlDbType.NVarChar).Value = value
					sqlCommand.ExecuteNonQuery()
				Catch ex4 As Exception
				Finally
					flag = (Me.conn.State <> ConnectionState.Closed)
					If flag Then
						Me.conn.Close()
					End If
				End Try
			End If
			Try
				Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
				flag = (registryKey Is Nothing)
				If flag Then
					registryKey = Registry.LocalMachine.CreateSubKey("Software\ExchangeVB" + str)
				End If
				flag = (registryKey.GetValue("Expire") IsNot Nothing)
				If flag Then
					value = Conversions.ToString(registryKey.GetValue("Expire"))
					flag2 = True
				Else
					registryKey.SetValue("Expire", value)
				End If
			Catch ex5 As Exception
			End Try
			flag = (Operators.CompareString(left, "open", False) <> 0)
			If flag Then
				Form1.lblExpireDiff.Caption = "متبقي " + Conversions.ToString(MainClass.GetExpireDaysDiff()) + " يوم على انتهاء الترخيص"
			End If
		Catch ex6 As Exception
		End Try
	End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Dim form1 As New Form1()
		Try
			Dim flag As Boolean = Operators.CompareString(Me.txt1.Text.Trim(), "", False) = 0 Or Operators.CompareString(Me.txt2.Text.Trim(), "", False) = 0 Or Operators.CompareString(Me.txt3.Text.Trim(), "", False) = 0 Or Operators.CompareString(Me.txt4.Text.Trim(), "", False) = 0
			If flag Then
				Interaction.MsgBox("ادخل السيريال كامل", MsgBoxStyle.OkOnly, Nothing)
			Else
				Me.Cursor = Cursors.WaitCursor
				Dim text As String = String.Concat(New String() {Me.txt1.Text.Trim(), " - ", Me.txt2.Text.Trim(), " - ", Me.txt3.Text.Trim(), " - ", Me.txt4.Text.Trim()})
				Dim left As String = Me.LoadSerial()
				Dim str As String = ""
				Try
					flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
					If flag Then
						str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
					End If
				Catch ex As Exception
				End Try
				flag = (Operators.CompareString(left, text, False) = 0)
				If flag Then
					Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
					registryKey.CreateSubKey("ExchangeVB" + str)
					registryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
					registryKey.SetValue("Serial", text)
					MainClass.IsTrial = False
					Form1.lblIsTrial.Caption = ""
					Form1.lblDash3.Caption = ""
					Me.UpdateExpireDate()
					Try
						flag = (Me.conn.State <> ConnectionState.Open)
						If flag Then
							Me.conn.Open()
						End If
						Dim sqlCommand As SqlCommand = New SqlCommand("update foundation set edit_compname=1", Me.conn)
						sqlCommand.ExecuteNonQuery()
					Catch ex2 As Exception
					Finally
						flag = (Me.conn.State <> ConnectionState.Closed)
						If flag Then
							Me.conn.Close()
						End If
					End Try
					Interaction.MsgBox("تم تفعيل البرنامج بنجاح", MsgBoxStyle.OkOnly, Nothing)
				Else
					Interaction.MsgBox("خطأ في ادخال السيريال", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		Catch ex3 As Exception
			Interaction.MsgBox("خطأ: " + ex3.Message, MsgBoxStyle.OkOnly, Nothing)
		Finally
			Me.Cursor = Cursors.[Default]
		End Try
	End Sub

	Private Sub frmSerial_Load(ByVal sender As Object, ByVal e As EventArgs)
		Try
			Dim str As String = ""
			Dim flag As Boolean
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				If flag Then
					str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				End If
			Catch ex As Exception
			End Try
			Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
			flag = (registryKey IsNot Nothing)
			If flag Then
				Dim text As String = registryKey.GetValue("Serial").ToString()
				Dim array As String() = text.Split(New Char() {"-"c})
				Me.txt1.Text = array(0).Trim()
				Me.txt2.Text = array(1).Trim()
				Me.txt3.Text = array(2).Trim()
				Me.txt4.Text = array(3).Trim()
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub frmSerial_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		Try
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				SendKeys.Send("{TAB}")
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txt4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt4.TextChanged
		End Sub

  Private Sub txt1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt1.TextChanged
		End Sub

  Private Sub txt3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt3.TextChanged
		End Sub
	End Class
