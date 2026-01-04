Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
	Public Partial Class frmBuyApp
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
		Private txt1 As String

		Private txt2 As String

		Public _mif As String
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmBuyApp_Load
			frmBuyApp.__ENCAddToList(Me)
			Me.txt1 = ""
			Me.txt2 = ""
			Me._mif = ""
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmBuyApp.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmBuyApp.__ENCList.Count = frmBuyApp.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmBuyApp.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmBuyApp.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmBuyApp.__ENCList(num) = frmBuyApp.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmBuyApp.__ENCList.RemoveRange(num, frmBuyApp.__ENCList.Count - num)
					frmBuyApp.__ENCList.Capacity = frmBuyApp.__ENCList.Count
				End If
				frmBuyApp.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub frmBuyApp_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmBuyApp.Load
			'Dim thread As Thread = AddressOf Me.loadinfo
			Dim thread As New Thread(AddressOf Me.loadinfo)
			thread.Start()
		End Sub

		Private Sub loadinfo()
			' The following expression was wrapped in a checked-statement
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
				Dim str2 As String = (num2 + num5 + num4).ToString()
				Me.txt1 = Me.txt1 + MainClass.AppNameAR + " ( محاسبة - إدارة مخازن ومستودعات )"
				Me.txt1 += Environment.NewLine
				Me.txt1 += " صمم لتلبية كافة احتياجات مؤسستك  ايا كان نشاطها التجاري سواء كانت تجارة عامة جملة أو تجزئة أو بقالة أو مطعم "
				Me.txt1 += Environment.NewLine
				Me.txt1 += Environment.NewLine
				Me.txt1 += "لشراء البرنامج وتفعيله على هذا الجهاز قم بالاتصال بـ"
				Me.txt1 += Environment.NewLine
				flag = (Operators.CompareString(Me._mif.Trim(), "", False) = 0)
				If flag Then
					Me.txt1 += "وضوح الحلول لتقنية المعلومات"
					Me.txt1 += Environment.NewLine
					Me.txt1 += Environment.NewLine
					Me.txt1 += "جوال 0550601061"
					Me.txt1 += Environment.NewLine
					Me.txt1 += "جوال 0572033860"
					Me.txt1 += Environment.NewLine
					Me.txt1 += Environment.NewLine
					Me.txt1 += "وارسل كود التفعيل الآتي"
				Else
					Me.txt1 += Me._mif
				End If
				Me.txt2 += str2
			Catch ex2 As Exception
			End Try
		End Sub

  Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Dim flag As Boolean = Operators.CompareString(Me.txt2, "", False) <> 0
			If flag Then
				Me.textBox2.Text = Me.txt1
				Me.textBox1.Text = Me.txt2
				Me.textBox1.BorderStyle = BorderStyle.FixedSingle
				Me.textBox1.BackColor = Color.Aqua
				Me.timer1.Enabled = False
			Else
				Dim textBox As TextBox = Me.textBox2
				textBox.Text += " ."
			End If
		End Sub

  Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox2.TextChanged
		End Sub
	End Class
