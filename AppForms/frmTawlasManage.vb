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
Imports AQSYS.UnitedSoftware.Forms
Imports AQSYS.My.Resources
	Public Partial Class frmTawlasManage
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmTawlasManage.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmTawlasManage.__ENCList.Count = frmTawlasManage.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmTawlasManage.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmTawlasManage.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmTawlasManage.__ENCList(num) = frmTawlasManage.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmTawlasManage.__ENCList.RemoveRange(num, frmTawlasManage.__ENCList.Count - num)
					frmTawlasManage.__ENCList.Capacity = frmTawlasManage.__ENCList.Count
				End If
				frmTawlasManage.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmTawlasManage_Load
			frmTawlasManage.__ENCAddToList(Me)
			Me.components = Nothing
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub

		Private Sub LoadGroups()
			' The following expression was wrapped in a checked-statement
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter()
				Dim checked As Boolean = Me.rdAll.Checked
				If checked Then
					sqlDataAdapter = New SqlDataAdapter("select id,name from tawla_groups order by id", Me.conn)
				Else
					checked = Me.rdMix.Checked
					If checked Then
						sqlDataAdapter = New SqlDataAdapter("select id,name from tawla_groups where type=1 order by id", Me.conn)
					Else
						checked = Me.rdOne.Checked
						If checked Then
							sqlDataAdapter = New SqlDataAdapter("select id,name from tawla_groups where type=2 order by id", Me.conn)
						Else
							checked = Me.rdFamily.Checked
							If checked Then
								sqlDataAdapter = New SqlDataAdapter("select id,name from tawla_groups where type=3 order by id", Me.conn)
							End If
						End If
					End If
				End If
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim imageList As ImageList = New ImageList()
				imageList.Images.Add(Resources.room)
				Dim imageList2 As ImageList = imageList
				Dim imageSize As Size = New Size(80, 80)
				imageList2.ImageSize = imageSize
				Me.lstTawlaGroups.Items.Clear()
				Me.lstTawlaGroups.LargeImageList = imageList
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					Me.lstTawlaGroups.Items.Add(dataTable.Rows(num3)("name").ToString(), 0)
					Me.lstTawlaGroups.Items(num3).Tag = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
					num3 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Function ISTawlaBusy(_id As Integer) As Boolean
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from inv where is_deleted=0 and tawla=" + Conversions.ToString(_id) + " and tawla_paid=0", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return True
				End If
			Catch ex As Exception
			End Try
			Return False
		End Function

		Private Function ISTawlaReserv(_id As Integer) As Boolean
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from tawla_reserve where tawla_id=" + Conversions.ToString(_id) + " and date>=@date", Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return True
				End If
			Catch ex As Exception
			End Try
			Return False
		End Function

		Private Function TawlaBusyTime(_id As Integer) As DateTime
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select date from inv where is_deleted=0 and tawla=" + Conversions.ToString(_id) + " and tawla_paid=0 order by id desc", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Return Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
				End If
			Catch ex As Exception
			End Try
			Return DateTime.Now
		End Function

		Private Function GetTawla(_id As Integer) As String
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from tawla where id=" + Conversions.ToString(_id), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Return dataTable.Rows(0)(0).ToString()
			Catch ex As Exception
			End Try
			Return ""
		End Function

		Private Sub LoadTawlas(group As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from tawla where tawla_group=" + Conversions.ToString(group) + " order by id", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim imageList As ImageList = New ImageList()
				imageList.Images.Add(Resources.table_green)
				imageList.Images.Add(Resources.table_yellow)
				imageList.Images.Add(Resources.table_red)
				Dim imageList2 As ImageList = imageList
				Dim imageSize As Size = New Size(80, 80)
				imageList2.ImageSize = imageSize
				Me.lstTawlas.Items.Clear()
				Me.lstTawlas.LargeImageList = imageList
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					Dim d As Double = 0.0
					Dim num6 As Integer = 0
					Dim flag As Boolean = Me.ISTawlaBusy(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))))
					If flag Then
						num6 = 2
						d = DateTime.Now.Subtract(Me.TawlaBusyTime(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))))).TotalMinutes
					Else
						flag = Me.ISTawlaReserv(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))))
						If flag Then
							num6 = 1
						End If
					End If
					Dim text As String = dataTable.Rows(num3)("name").ToString()
					flag = (num6 = 2)
					If flag Then
						text = String.Concat(New String() { text, Environment.NewLine, "منذ ", Conversions.ToString(Math.Floor(d)), " دقيقة" })
					End If
					Me.lstTawlas.Items.Add(text, num6)
					Me.lstTawlas.Items(num3).Tag = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
					num3 += 1
				End While
			Catch ex As Exception
			End Try
		End Sub

  Private Sub frmTawlasManage_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmTawlasManage.Load
			Me.LoadGroups()
		End Sub

  Private Sub rdMix_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdMix.CheckedChanged
			Me.LoadGroups()
		End Sub

  Private Sub lstTawlaGroups_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstTawlaGroups.SelectedIndexChanged
			Try
				Me.LoadTawlas(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlaGroups.Items(Convert.ToInt32(Me.lstTawlaGroups.SelectedIndices(0))).Tag)))
			Catch ex As Exception
			End Try
		End Sub

  Private Sub lstTawlas_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstTawlas.SelectedIndexChanged
		End Sub

	'///////////////////////////////
	''' <summary>
	''' معالج حدث النقر المزدوج على قائمة الطاولات
	''' يقوم بفتح نموذج فاتورة البيع مع تحديد الطاولة المختارة
	''' </summary>
 Private Sub lstTawlas_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lstTawlas.MouseDoubleClick
		Try
			' التحقق من وجود عنصر محدد
			If Not HasSelectedTable() Then Return

			' إنشاء وتهيئة نموذج البيع
			Dim salesForm As frmSalePurchRest = CreateAndInitializeSalesForm()

			' التحقق من حالة الطاولة (مشغولة أم فارغة)
			If IsTableOccupied() Then
				' الطاولة مشغولة - تحميل الفاتورة الحالية
				LoadExistingInvoice(salesForm)
			Else
				' الطاولة فارغة - إنشاء فاتورة جديدة
				SetupNewInvoice(salesForm)
			End If

			' إغلاق النموذج الحالي
			Me.Close()

		Catch ex As Exception
			HandleError("lstTawlas_MouseDoubleClick", ex)
		End Try
	End Sub

#Region "دوال التحقق"

	''' <summary>
	''' التحقق من وجود طاولة محددة
	''' </summary>
	Private Function HasSelectedTable() As Boolean
		Return Me.lstTawlas.SelectedItems.Count > 0
	End Function

	''' <summary>
	''' التحقق مما إذا كانت الطاولة مشغولة
	''' </summary>
	Private Function IsTableOccupied() As Boolean
		Return Me.lstTawlas.SelectedItems(0).ImageIndex = 2
	End Function

	''' <summary>
	''' التحقق من وجود مجموعة طاولات محددة
	''' </summary>
	Private Function HasSelectedTableGroup() As Boolean
		Return Me.lstTawlaGroups.SelectedItems.Count > 0
	End Function

#End Region

#Region "دوال إنشاء وتهيئة النموذج"

	''' <summary>
	''' إنشاء وتهيئة نموذج فاتورة البيع
	''' </summary>
	Private Function CreateAndInitializeSalesForm() As frmSalePurchRest
		Dim salesForm As New frmSalePurchRest()

		With salesForm
			' تعيين نوع العملية (بيع)
			.InvProc = 2

			' تعيين نوع الفاتورة
			.cmbProcType.SelectedIndex = 0
			.cmbProcTypeSrch.SelectedIndex = 0

			' عرض النموذج بملء الشاشة
			.Show()
			.WindowState = FormWindowState.Maximized
			.Activate()
		End With

		Return salesForm
	End Function

#End Region

#Region "دوال تحميل الفواتير"

	''' <summary>
	''' تحميل الفاتورة الموجودة للطاولة المشغولة
	''' </summary>
	Private Sub LoadExistingInvoice(salesForm As frmSalePurchRest)
		Dim tableId As Object = Me.lstTawlas.SelectedItems(0).Tag
		Dim query As String = $"SELECT * FROM inv WHERE tawla_paid = 0 AND tawla = {tableId} ORDER BY id DESC"

		salesForm.Navigate(query)
	End Sub

	''' <summary>
	''' إعداد فاتورة جديدة للطاولة الفارغة
	''' </summary>
	Private Sub SetupNewInvoice(salesForm As frmSalePurchRest)
		' تحديد نوع الطاولة (داخلي/عائلي/فردي)
		SetTableType(salesForm)

		' تحديد مجموعة الطاولات في النموذج
		SelectTableGroupInForm(salesForm)

		' تحديد الطاولة في النموذج
		SelectTableInForm(salesForm)
	End Sub

#End Region

#Region "دوال تحديد نوع الطاولة"

	''' <summary>
	''' تحديد نوع الطاولة بناءً على الاختيار الحالي
	''' </summary>
	Private Sub SetTableType(salesForm As frmSalePurchRest)
		If Me.rdMix.Checked OrElse Me.rdFamily.Checked Then
			' طاولة عائلية أو مختلطة
			salesForm.rdIn2.Checked = True

		ElseIf Me.rdOne.Checked Then
			' طاولة فردية
			salesForm.rdIn.Checked = True

		ElseIf Me.rdAll.Checked Then
			' تحديد النوع من قاعدة البيانات
			SetTableTypeFromDatabase(salesForm)
		End If
	End Sub

	''' <summary>
	''' تحديد نوع الطاولة من قاعدة البيانات
	''' </summary>
	Private Sub SetTableTypeFromDatabase(salesForm As frmSalePurchRest)
		If Not HasSelectedTableGroup() Then Return

		Dim groupId As Object = Me.lstTawlaGroups.SelectedItems(0).Tag
		Dim tableType As Integer = GetTableGroupType(groupId)

		Select Case tableType
			Case 1, 3
				' طاولة عائلية أو مختلطة
				salesForm.rdIn2.Checked = True
			Case 2
				' طاولة فردية
				salesForm.rdIn.Checked = True
		End Select
	End Sub

	''' <summary>
	''' الحصول على نوع مجموعة الطاولات من قاعدة البيانات
	''' </summary>
	Private Function GetTableGroupType(groupId As Object) As Integer
		Try
			Dim query As String = $"SELECT type FROM tawla_groups WHERE id = {groupId}"
			Dim adapter As New SqlDataAdapter(query, Me.conn)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
				Return Convert.ToInt32(dt.Rows(0)(0))
			End If
		Catch ex As Exception
			HandleError("GetTableGroupType", ex)
		End Try

		Return 0
	End Function

#End Region

#Region "دوال تحديد العناصر في النموذج"

	''' <summary>
	''' تحديد مجموعة الطاولات في نموذج البيع
	''' </summary>
	Private Sub SelectTableGroupInForm(salesForm As frmSalePurchRest)
		If Not HasSelectedTableGroup() Then Return

		Dim selectedGroupName As String = Me.lstTawlaGroups.SelectedItems(0).Text

		' البحث عن المجموعة في DataGridView
		Dim columnIndex As Integer = FindColumnIndexByValue(
		salesForm.dgvTawlaGroups,
		rowIndex:=0,
		searchValue:=selectedGroupName)

		If columnIndex >= 0 Then
			' تحديد الخلية
			salesForm.dgvTawlaGroups.Rows(0).Cells(columnIndex).Selected = True

			' تحميل طاولات المجموعة
			salesForm.LoadTawla(selectedGroupName)
		End If
	End Sub

	''' <summary>
	''' تحديد الطاولة في نموذج البيع
	''' </summary>
	Private Sub SelectTableInForm(salesForm As frmSalePurchRest)
		If Not HasSelectedTable() Then Return

		Dim selectedTableName As String = Me.lstTawlas.SelectedItems(0).Text

		' البحث عن الطاولة في DataGridView
		Dim cellLocation As CellLocation = FindCellByValue(
		salesForm.dgvTawlas,
		searchValue:=selectedTableName)

		If cellLocation.Found Then
			salesForm.dgvTawlas.Rows(cellLocation.RowIndex).Cells(cellLocation.ColumnIndex).Selected = True
		End If
	End Sub

	''' <summary>
	''' البحث عن فهرس العمود حسب القيمة في صف محدد
	''' </summary>
	Private Function FindColumnIndexByValue(dgv As DataGridView,
										 rowIndex As Integer,
										 searchValue As String) As Integer
		Try
			If dgv.Rows.Count <= rowIndex Then Return -1

			For colIndex As Integer = 0 To dgv.Columns.Count - 1
				Dim cellValue As Object = dgv.Rows(rowIndex).Cells(colIndex).Value

				If cellValue IsNot Nothing AndAlso
			   cellValue.ToString() = searchValue Then
					Return colIndex
				End If
			Next
		Catch ex As Exception
			HandleError("FindColumnIndexByValue", ex)
		End Try

		Return -1
	End Function

	''' <summary>
	''' هيكل لتخزين موقع الخلية
	''' </summary>
	Private Structure CellLocation
		Public Found As Boolean
		Public RowIndex As Integer
		Public ColumnIndex As Integer

		Public Sub New(found As Boolean, rowIndex As Integer, columnIndex As Integer)
			Me.Found = found
			Me.RowIndex = rowIndex
			Me.ColumnIndex = columnIndex
		End Sub
	End Structure

	''' <summary>
	''' البحث عن خلية حسب القيمة في DataGridView
	''' </summary>
	Private Function FindCellByValue(dgv As DataGridView,
								  searchValue As String) As CellLocation
		Try
			For rowIndex As Integer = 0 To dgv.Rows.Count - 1
				For colIndex As Integer = 0 To dgv.Columns.Count - 1
					Dim cellValue As Object = dgv.Rows(rowIndex).Cells(colIndex).Value

					If cellValue IsNot Nothing AndAlso
				   cellValue.ToString() = searchValue Then
						Return New CellLocation(True, rowIndex, colIndex)
					End If
				Next
			Next
		Catch ex As Exception
			HandleError("FindCellByValue", ex)
		End Try

		Return New CellLocation(False, -1, -1)
	End Function

#End Region

#Region "دوال معالجة الأخطاء"

	''' <summary>
	''' معالجة الأخطاء وتسجيلها
	''' </summary>
	Private Sub HandleError(methodName As String, ex As Exception)
		Debug.WriteLine($"خطأ في {methodName}: {ex.Message}")
		' يمكن إضافة تسجيل في ملف أو قاعدة بيانات هنا
	End Sub

#End Region

	'///////////////////////////////
 Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Try
				Dim flag As Boolean = Me.lstTawlas.SelectedItems.Count = 0
				If flag Then
					MessageBox.Show("اختر طاولة أولاً")
				Else
				'New frmReservTawla() With { .txtGroup = { .Text = Me.lstTawlaGroups.SelectedItems(0).Text }, .txtTawla = { .Text = Me.GetTawla(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag))) }, .tawla_id = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag)), .btnCancel = { .Enabled = False } }.ShowDialog()
				Using frm As New frmReservTawla()
					frm.txtGroup.Text = Me.lstTawlaGroups.SelectedItems(0).Text
					frm.txtTawla.Text = Me.GetTawla(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag)))
					frm.tawla_id = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag))
					frm.btnCancel.Enabled = False
					frm.ShowDialog()
				End Using
				Me.LoadTawlas(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlaGroups.Items(Convert.ToInt32(Me.lstTawlaGroups.SelectedIndices(0))).Tag)))
			End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Try
				Dim flag As Boolean = Me.lstTawlas.SelectedItems.Count = 0
				If flag Then
					MessageBox.Show("اختر طاولة أولاً")
				Else
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from tawla_reserve where date>=@date and tawla_id=", Me.lstTawlas.SelectedItems(0).Tag)), Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString()
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (dataTable.Rows.Count > 0)
					If flag Then
						Dim frmReservTawla As frmReservTawla = New frmReservTawla()
						frmReservTawla.isupdate = True
						frmReservTawla.txtGroup.Text = Me.lstTawlaGroups.SelectedItems(0).Text
						frmReservTawla.txtTawla.Text = Me.GetTawla(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag)))
						frmReservTawla.tawla_id = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlas.SelectedItems(0).Tag))
						frmReservTawla.ID = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("id")))
						frmReservTawla.txtDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("date")))
						frmReservTawla.txtClientName.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("clientname")))
						frmReservTawla.txtClientMobile.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("clientmobile")))
						frmReservTawla.txtNotes.Text = "" + Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("notes")))
						frmReservTawla.curr_index = 0
						frmReservTawla.dtReserv = dataTable
						flag = (dataTable.Rows.Count > 1)
						If flag Then
							frmReservTawla.pnlNavigate.Visible = True
						End If
						frmReservTawla.btnReserv.Text = "تعديل"
						frmReservTawla.btnCancel.Enabled = True
						frmReservTawla.ShowDialog()
						Me.LoadTawlas(Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.lstTawlaGroups.Items(Convert.ToInt32(Me.lstTawlaGroups.SelectedIndices(0))).Tag)))
					Else
						MessageBox.Show("لا يوجد حجز مستقبلي على هذه الطاولة")
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
