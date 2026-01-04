Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
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
Imports AQSYS.AQSYS.rptt
Public Partial Class frmRptSalary
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmRptSalary_Load
			frmRptSalary.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmRptSalary.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmRptSalary.__ENCList.Count = frmRptSalary.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmRptSalary.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmRptSalary.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmRptSalary.__ENCList(num) = frmRptSalary.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmRptSalary.__ENCList.RemoveRange(num, frmRptSalary.__ENCList.Count - num)
					frmRptSalary.__ENCList.Capacity = frmRptSalary.__ENCList.Count
				End If
				frmRptSalary.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

    '///////////////////////////////
    ''' <summary>
    ''' عرض كشف رواتب الموظفين للشهر المحدد
    ''' </summary>
    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Try
            ' ========== تهيئة المتغيرات ==========
            Dim salaryTotals As New SalaryTotals()

            ' مسح البيانات السابقة
            Me.dgvItems.Rows.Clear()

            ' ========== جلب قائمة الموظفين ==========
            Dim employeesTable As DataTable = GetActiveEmployees()

            If employeesTable.Rows.Count = 0 Then
                MessageBox.Show("لا يوجد موظفين", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' ========== تحديد فترة الشهر ==========
            Dim monthPeriod As MonthPeriod = GetMonthPeriod()

            ' ========== معالجة بيانات كل موظف ==========
            Dim rowIndex As Integer = 0

            For Each empRow As DataRow In employeesTable.Rows
                Dim employeeId As Integer = Convert.ToInt32(empRow(0))
                Dim employeeName As String = empRow("name").ToString()

                ' حساب راتب الموظف
                Dim empSalary As EmployeeSalary = CalculateEmployeeSalary(employeeId, monthPeriod)

                ' إضافة الصف للجدول
                AddEmployeeRow(rowIndex, employeeName, empSalary)

                ' تجميع الإجماليات
                AccumulateTotals(salaryTotals, empSalary)

                rowIndex += 1
            Next

            ' ========== عرض الإجماليات ==========
            DisplayTotals(salaryTotals)

        Catch ex As Exception
            HandleError("btnShow_Click", ex)
        End Try
    End Sub

#Region "الهياكل والأنواع"

    ''' <summary>
    ''' هيكل لتخزين فترة الشهر
    ''' </summary>
    Private Structure MonthPeriod
        Public StartDate As DateTime
        Public EndDate As DateTime
        Public Year As Integer
        Public Month As Integer
    End Structure

    ''' <summary>
    ''' هيكل لتخزين بيانات راتب الموظف
    ''' </summary>
    Private Structure EmployeeSalary
        Public BasicSalary As Double      ' الراتب الأساسي والبدلات
        Public Additions As Double        ' الإضافات
        Public Deductions As Double       ' الخصومات
        Public Advances As Double         ' السلف
        Public NetSalary As Double        ' صافي الراتب
    End Structure

    ''' <summary>
    ''' هيكل لتخزين إجماليات الرواتب
    ''' </summary>
    Private Structure SalaryTotals
        Public TotalBasic As Double
        Public TotalAdditions As Double
        Public TotalDeductions As Double
        Public TotalAdvances As Double
        Public TotalNet As Double
    End Structure

#End Region

#Region "جلب البيانات"

    ''' <summary>
    ''' جلب قائمة الموظفين النشطين
    ''' </summary>
    Private Function GetActiveEmployees() As DataTable
        Const QUERY As String = "SELECT id, name FROM Employees WHERE IS_Deleted = 0 ORDER BY id"

        Using adapter As New SqlDataAdapter(QUERY, Me.conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Return dt
        End Using
    End Function

    ''' <summary>
    ''' تحديد فترة الشهر المطلوب
    ''' </summary>
    Private Function GetMonthPeriod() As MonthPeriod
        Dim period As New MonthPeriod()

        period.Year = CInt(Math.Round(Conversion.Val(Me.txtYear.Value)))
        period.Month = CInt(Math.Round(Conversion.Val(Me.txtMonth.Value)))

        Dim daysInMonth As Integer = DateTime.DaysInMonth(period.Year, period.Month)

        period.StartDate = New DateTime(period.Year, period.Month, 1)
        period.EndDate = New DateTime(period.Year, period.Month, daysInMonth)

        Return period
    End Function

    ''' <summary>
    ''' جلب الراتب الأساسي والبدلات للموظف
    ''' </summary>
    Private Function GetBasicSalaryAndAllowances(employeeId As Integer) As Double
        Const QUERY As String =
        "SELECT salary_basic, salary_add, salary_other, house, travel, food, medical " &
        "FROM Employees WHERE id = @empId"

        Using adapter As New SqlDataAdapter(QUERY, Me.conn)
            adapter.SelectCommand.Parameters.AddWithValue("@empId", employeeId)

            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                Return GetSafeDouble(row, 0) + ' salary_basic
                   GetSafeDouble(row, 1) + ' salary_add
                   GetSafeDouble(row, 2) + ' salary_other
                   GetSafeDouble(row, 3) + ' house
                   GetSafeDouble(row, 4) + ' travel
                   GetSafeDouble(row, 5) + ' food
                   GetSafeDouble(row, 6)   ' medical
            End If

            Return 0.0
        End Using
    End Function

    ''' <summary>
    ''' جلب الإضافات للموظف خلال الفترة
    ''' </summary>
    Private Function GetEmployeeAdditions(employeeId As Integer, period As MonthPeriod) As Double
        Const QUERY As String =
        "SELECT ISNULL(SUM(EmpSalaryAddSub.val), 0) " &
        "FROM EmpSalaryAddSub " &
        "INNER JOIN SalaryAddSubTypes ON EmpSalaryAddSub.type = SalaryAddSubTypes.id " &
        "WHERE SalaryAddSubTypes.ISAdd = 1 " &
        "AND EmpSalaryAddSub.IS_Deleted = 0 " &
        "AND date >= @date1 AND date <= @date2 " &
        "AND emp = @empId"

        Return ExecuteSumQuery(QUERY, employeeId, period)
    End Function

    ''' <summary>
    ''' جلب الخصومات للموظف خلال الفترة (نوع 3)
    ''' </summary>
    Private Function GetEmployeeDeductions(employeeId As Integer, period As MonthPeriod) As Double
        Const QUERY As String =
        "SELECT ISNULL(SUM(EmpSalaryAddSub.val), 0) " &
        "FROM EmpSalaryAddSub " &
        "INNER JOIN SalaryAddSubTypes ON EmpSalaryAddSub.type = SalaryAddSubTypes.id " &
        "WHERE SalaryAddSubTypes.ISAdd = 0 " &
        "AND SalaryAddSubTypes.id = 3 " &
        "AND EmpSalaryAddSub.IS_Deleted = 0 " &
        "AND date >= @date1 AND date <= @date2 " &
        "AND emp = @empId"

        Return ExecuteSumQuery(QUERY, employeeId, period)
    End Function

    ''' <summary>
    ''' جلب السلف للموظف خلال الفترة (نوع 4)
    ''' </summary>
    Private Function GetEmployeeAdvances(employeeId As Integer, period As MonthPeriod) As Double
        Const QUERY As String =
        "SELECT ISNULL(SUM(EmpSalaryAddSub.val), 0) " &
        "FROM EmpSalaryAddSub " &
        "INNER JOIN SalaryAddSubTypes ON EmpSalaryAddSub.type = SalaryAddSubTypes.id " &
        "WHERE SalaryAddSubTypes.ISAdd = 0 " &
        "AND SalaryAddSubTypes.id = 4 " &
        "AND EmpSalaryAddSub.IS_Deleted = 0 " &
        "AND date >= @date1 AND date <= @date2 " &
        "AND emp = @empId"

        Return ExecuteSumQuery(QUERY, employeeId, period)
    End Function

    ''' <summary>
    ''' تنفيذ استعلام جمع مع المعاملات
    ''' </summary>
    Private Function ExecuteSumQuery(query As String, employeeId As Integer, period As MonthPeriod) As Double
        Using adapter As New SqlDataAdapter(query, Me.conn)
            adapter.SelectCommand.Parameters.AddWithValue("@empId", employeeId)
            adapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = period.StartDate
            adapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = period.EndDate

            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return Conversion.Val(dt.Rows(0)(0))
            End If

            Return 0.0
        End Using
    End Function

#End Region

#Region "حساب الرواتب"

    ''' <summary>
    ''' حساب راتب الموظف الكامل
    ''' </summary>
    Private Function CalculateEmployeeSalary(employeeId As Integer, period As MonthPeriod) As EmployeeSalary
        Dim salary As New EmployeeSalary()

        ' الراتب الأساسي والبدلات
        salary.BasicSalary = GetBasicSalaryAndAllowances(employeeId)

        ' الإضافات
        salary.Additions = GetEmployeeAdditions(employeeId, period)

        ' الخصومات
        salary.Deductions = GetEmployeeDeductions(employeeId, period)

        ' السلف
        salary.Advances = GetEmployeeAdvances(employeeId, period)

        ' صافي الراتب
        salary.NetSalary = salary.BasicSalary + salary.Additions - salary.Deductions - salary.Advances

        Return salary
    End Function

    ''' <summary>
    ''' تجميع الإجماليات
    ''' </summary>
    Private Sub AccumulateTotals(ByRef totals As SalaryTotals, salary As EmployeeSalary)
        totals.TotalBasic += salary.BasicSalary
        totals.TotalAdditions += salary.Additions
        totals.TotalDeductions += salary.Deductions
        totals.TotalAdvances += salary.Advances
        totals.TotalNet += salary.NetSalary
    End Sub

#End Region

#Region "عرض البيانات"

    ''' <summary>
    ''' إضافة صف الموظف للجدول
    ''' </summary>
    Private Sub AddEmployeeRow(rowIndex As Integer, employeeName As String, salary As EmployeeSalary)
        Me.dgvItems.Rows.Add()

        With Me.dgvItems.Rows(rowIndex)
            .Cells(0).Value = rowIndex + 1              ' الرقم التسلسلي
            .Cells(1).Value = employeeName              ' اسم الموظف
            .Cells(2).Value = salary.BasicSalary        ' الراتب الأساسي
            .Cells(3).Value = salary.Additions          ' الإضافات
            .Cells(4).Value = salary.Deductions         ' الخصومات
            .Cells(5).Value = salary.Advances           ' السلف
            .Cells(6).Value = salary.NetSalary          ' صافي الراتب
        End With
    End Sub

    ''' <summary>
    ''' عرض الإجماليات في حقول النص
    ''' </summary>
    Private Sub DisplayTotals(totals As SalaryTotals)
        Me.txtSum.Text = FormatNumber(totals.TotalBasic)
        Me.txtSumAdds.Text = FormatNumber(totals.TotalAdditions)
        Me.txtSumDisc.Text = FormatNumber(totals.TotalDeductions)
        Me.txtSumSlf.Text = FormatNumber(totals.TotalAdvances)
        Me.txtSumNet.Text = FormatNumber(totals.TotalNet)
    End Sub

    ''' <summary>
    ''' تنسيق الرقم للعرض
    ''' </summary>
    Private Function FormatNumber(value As Double) As String
        Return value.ToString("N2")
    End Function

#End Region

#Region "دوال مساعدة"

    ''' <summary>
    ''' الحصول على قيمة رقمية آمنة من DataRow
    ''' </summary>
    Private Function GetSafeDouble(row As DataRow, columnIndex As Integer) As Double
        Try
            If row(columnIndex) IsNot DBNull.Value Then
                Return Conversion.Val(row(columnIndex))
            End If
        Catch ex As Exception
        End Try
        Return 0.0
    End Function

    ''' <summary>
    ''' معالجة الأخطاء
    ''' </summary>
    Private Sub HandleError(methodName As String, ex As Exception)
        Debug.WriteLine($"خطأ في {methodName}: {ex.Message}")
        MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

#End Region

    '///////////////////////////////
    Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
		End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frmSalaryPay As New frmSalaryPay()
        frmSalaryPay.Show()
        frmSalaryPay.Activate()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

		Private Sub PrintRpt(_type As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
				If flag Then
					Interaction.MsgBox("الجدول فارغ", MsgBoxStyle.OkOnly, Nothing)
				Else
					Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
					flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag Then
						obj = New rptSalary()
					Else
						obj = New rptSalary___EN()
					End If
					Dim dataTable As DataTable = New DataTable()
					dataTable.Columns.Add("DataColumn1")
					dataTable.Columns.Add("name")
					dataTable.Columns.Add("totsalary")
					dataTable.Columns.Add("dep")
					dataTable.Columns.Add("DataColumn11")
					dataTable.Columns.Add("manag")
					dataTable.Columns.Add("DataColumn12")
					Dim num As Integer = 0
					Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
					Dim num3 As Integer = num
					While True
						Dim num4 As Integer = num3
						Dim num5 As Integer = num2
						If num4 > num5 Then
							Exit While
						End If
						dataTable.Rows.Add(New Object() { RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value) })
						num3 += 1
					End While
					Dim instance As Object = obj
					Dim type As Type = Nothing
					Dim memberName As String = "SetDataSource"
					Dim array As Object() = New Object() { dataTable }
					Dim arguments As Object() = array
					Dim argumentNames As String() = Nothing
					Dim typeArguments As Type() = Nothing
					Dim array2 As Boolean() = New Boolean() { True }
					NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, True)
					If array2(0) Then
						dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
					End If
					Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "month" }, Nothing, Nothing, Nothing), TextObject)
					textObject.Text = Conversions.ToString(Me.txtMonth.Value)
					Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "year" }, Nothing, Nothing, Nothing), TextObject)
					textObject2.Text = Conversions.ToString(Me.txtYear.Value)
					Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "tot" }, Nothing, Nothing, Nothing), TextObject)
					textObject3.Text = Me.txtSumNet.Text
					Try
						Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "tot1" }, Nothing, Nothing, Nothing), TextObject)
						textObject4.Text = Me.txtSum.Text
						Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "tot2" }, Nothing, Nothing, Nothing), TextObject)
						textObject5.Text = Me.txtSumAdds.Text
						Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "tot3" }, Nothing, Nothing, Nothing), TextObject)
						textObject6.Text = Me.txtSumDisc.Text
					Catch ex As Exception
					End Try
					Try
						Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "tot4" }, Nothing, Nothing, Nothing), TextObject)
						textObject7.Text = Me.txtSumSlf.Text
					Catch ex2 As Exception
					End Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
					Dim type2 As Type = Nothing
					Dim memberName2 As String = "SetDataSource"
					Dim array3 As Object() = New Object() { dataTable2 }
					Dim arguments2 As Object() = array3
					Dim argumentNames2 As String() = Nothing
					Dim typeArguments2 As Type() = Nothing
					array2 = New Boolean() { True }
					NewLateBinding.LateCall(instance2, type2, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
					If array2(0) Then
						dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
					End If
					Dim frmRptViewer As frmRptViewer = New frmRptViewer()
					Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
					frmRptViewer.Controls.Add(crystalReportViewer)
					crystalReportViewer.Dock = DockStyle.Fill
					crystalReportViewer.DisplayGroupTree = False
					crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
					frmRptViewer.WindowState = FormWindowState.Maximized
					flag = (_type = 1)
					If flag Then
						frmRptViewer.Show()
					Else
						Try
							crystalReportViewer.ShowLastPage()
							Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
							crystalReportViewer.ShowFirstPage()
							Dim instance3 As Object = obj
							Dim type3 As Type = Nothing
							Dim memberName3 As String = "PrintToPrinter"
							array = New Object() { 1, False, 1, num6 }
							Dim arguments3 As Object() = array
							Dim argumentNames3 As String() = Nothing
							Dim typeArguments3 As Type() = Nothing
							array2 = New Boolean() { False, False, False, True }
							NewLateBinding.LateCall(instance3, type3, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
							If array2(3) Then
								num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
							End If
						Catch ex3 As Exception
						End Try
					End If
				End If
			Catch ex4 As Exception
			End Try
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub frmRptSalary_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmRptSalary.Load
			Me.txtMonth.Value = New Decimal(DateTime.Now.Month)
			Me.txtYear.Value = New Decimal(DateTime.Now.Year)
		End Sub
	End Class
