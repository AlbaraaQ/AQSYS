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
Public Partial Class frmInvBySalesMen
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private EmpName As String
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmEmpInvs_Load
        frmInvBySalesMen.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.EmpName = ""
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmInvBySalesMen.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmInvBySalesMen.__ENCList.Count = frmInvBySalesMen.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmInvBySalesMen.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmInvBySalesMen.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmInvBySalesMen.__ENCList(num) = frmInvBySalesMen.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmInvBySalesMen.__ENCList.RemoveRange(num, frmInvBySalesMen.__ENCList.Count - num)
                frmInvBySalesMen.__ENCList.Capacity = frmInvBySalesMen.__ENCList.Count
            End If
            frmInvBySalesMen.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.ShowResult()
    End Sub

    Private Function GetCurrencyName(Currency_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Symbol from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            result = dataTable.Rows(0)(0).ToString()
        Else
            result = ""
        End If
        Return result
    End Function

    Private Function GetEmpName(emp As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn)
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

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("ProcType")
            dataTable.Columns.Add("Date")
            dataTable.Columns.Add("No")
            dataTable.Columns.Add("Currency")
            dataTable.Columns.Add("Val")
            dataTable.Columns.Add("Price")
            dataTable.Columns.Add("Total")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)})
                num3 += 1
            End While
            Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
            If flag Then
                obj = New rptEmpInv()
            Else
                obj = New rptEmpInv___EN()
            End If
            Dim instance As Object = obj
            Dim type2 As Type = Nothing
            Dim memberName As String = "SetDataSource"
            Dim array As Object() = New Object() {dataTable}
            Dim arguments As Object() = array
            Dim argumentNames As String() = Nothing
            Dim typeArguments As Type() = Nothing
            Dim array2 As Boolean() = New Boolean() {True}
            NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
            If array2(0) Then
                dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
            End If
            Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lbl"}, Nothing, Nothing, Nothing), TextObject)
            textObject.Text = "المندوب"
            Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"name"}, Nothing, Nothing, Nothing), TextObject)
            textObject2.Text = "المندوب"
            Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"price"}, Nothing, Nothing, Nothing), TextObject)
            textObject3.Text = "قيمة الفاتورة"
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"comm"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = "العمولة"
            Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"val"}, Nothing, Nothing, Nothing), TextObject)
            textObject5.Text = "المبلغ المحصل"
            Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtemp"}, Nothing, Nothing, Nothing), TextObject)
            textObject6.Text = Me.EmpName
            Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateFrom"}, Nothing, Nothing, Nothing), TextObject)
            textObject7.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateTo"}, Nothing, Nothing, Nothing), TextObject)
            textObject8.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
            textObject9.Text = Me.txtSum.Text
            Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
            textObject10.Text = Me.GetEmpName(MainClass.EmpNo)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
            Dim type3 As Type = Nothing
            Dim memberName2 As String = "SetDataSource"
            Dim array3 As Object() = New Object() {dataTable2}
            Dim arguments2 As Object() = array3
            Dim argumentNames2 As String() = Nothing
            Dim typeArguments2 As Type() = Nothing
            array2 = New Boolean() {True}
            NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
            If array2(0) Then
                dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
            End If
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
                textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
                textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
                textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
                textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    Dim instance3 As Object = obj
                    Dim type4 As Type = Nothing
                    Dim memberName3 As String = "PrintToPrinter"
                    array = New Object() {1, False, 1, num6}
                    Dim arguments3 As Object() = array
                    Dim argumentNames3 As String() = Nothing
                    Dim typeArguments3 As Type() = Nothing
                    array2 = New Boolean() {False, False, False, True}
                    NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
                    If array2(3) Then
                        num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub ShowResult()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = ""
            Dim flag As Boolean = Not Me.chkAll.Checked
            Dim flag2 As Boolean
            If flag Then
                flag2 = (Me.cmbEmps.SelectedValue Is Nothing)
                If flag2 Then
                    MessageBox.Show("اختر مندوب", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbEmps.Focus()
                    Return
                End If
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Inv.salesman=", Me.cmbEmps.SelectedValue)))
            End If
            Dim text2 As String = ""
            flag2 = (MainClass.BranchNo <> -1)
            If flag2 Then
                text2 = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Inv.proc_type,date,Inv.id,tot_net,Inv.salesman  from Inv where ", text2, " Inv.salesman <> -1 and date>=@date1 and date<=@date2 and Inv.IS_Deleted=0 ", text, " order by date"}), Me.conn)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
            Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim num As Double = 0.0
            Me.dgvItems.Rows.Clear()
            Me.EmpName = ""
            flag2 = Not Me.chkAll.Checked
            If flag2 Then
                Me.EmpName = Me.cmbEmps.Text
            Else
                Me.EmpName = "الكل"
            End If
            Dim num2 As Integer = 0
            Dim num3 As Integer = dataTable.Rows.Count - 1
            Dim num4 As Integer = num2
            While True
                Dim num5 As Integer = num4
                Dim num6 As Integer = num3
                If num5 > num6 Then
                    Exit While
                End If
                Dim flag3 As Boolean = False
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select comm,name from salesmen where id=", dataTable.Rows(num4)("salesman"))), Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                Dim value As String = dataTable2.Rows(0)("name").ToString()
                Dim num7 As Decimal = New Decimal(Conversion.Val("" + dataTable2.Rows(0)("comm").ToString()))
                Dim value2 As String = ""
                flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("proc_type"))) = 1.0)
                If flag2 Then
                    value2 = "فاتورة بيع"
                    flag3 = True
                Else
                    flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("proc_type"))) = 2.0)
                    If flag2 Then
                        value2 = "فاتورة مرتد بيع"
                        flag3 = False
                    End If
                End If
                Me.dgvItems.Rows.Add()
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = value2
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("date"))).ToShortDateString()
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("id"))
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = value
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("tot_net"))))
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num7
                Dim num8 As Double = Convert.ToDouble(Decimal.Divide(num7, 100D)) * Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("tot_net")))
                Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = String.Format("{0:0.#,##.##}", num8)
                flag2 = flag3

                If flag2 Then
                    num += num8
                Else
                    num -= num8
                End If

                num4 += 1
            End While
            Me.txtSum.Text = "" + Conversions.ToString(num)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadEmps()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from salesmen where IS_Deleted=0 order by id", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.cmbEmps.DataSource = dataTable
            Me.cmbEmps.DisplayMember = "name"
            Me.cmbEmps.ValueMember = "id"
            Me.cmbEmps.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEmpInvs_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadEmps()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbEmps.Enabled = False
        Else
            Me.cmbEmps.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = e.ColumnIndex = 7
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة بيع", False) = 0
                If flag2 Then
                    Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                    Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                    Dim value As Integer = 1
                    flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة شراء", False) = 0)
                    If flag2 Then
                        frmSalePurch.InvProc = 1
                    Else
                        flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة بيع", False) = 0)
                        If flag2 Then
                            frmSalePurch.InvProc = 2
                            value = 0
                        End If
                    End If
                    frmSalePurch.Show()
                    frmSalePurch.WindowState = FormWindowState.Maximized
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
                    frmSalePurch.Activate()
                Else
                    flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد بيع", False) = 0)
                    If flag2 Then
                        Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                        Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
                        Dim value2 As Integer = 1
                        flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد شراء", False) = 0)
                        If flag2 Then
                            frmSalePurch2.InvProc = 1
                        Else
                            flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(0).Value)), "فاتورة مرتد بيع", False) = 0)
                            If flag2 Then
                                frmSalePurch2.InvProc = 2
                                value2 = 0
                            End If
                        End If
                        frmSalePurch2.Show()
                        frmSalePurch2.WindowState = FormWindowState.Maximized
                        frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and proc_type=2 and is_buy=" + Conversions.ToString(value2) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
                        frmSalePurch2.Activate()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(2)
    End Sub
End Class
