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
Public Partial Class frmInvSumByType
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmInvSumByType_Load
        frmInvSumByType.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmInvSumByType.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmInvSumByType.__ENCList.Count = frmInvSumByType.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmInvSumByType.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmInvSumByType.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmInvSumByType.__ENCList(num) = frmInvSumByType.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmInvSumByType.__ENCList.RemoveRange(num, frmInvSumByType.__ENCList.Count - num)
                frmInvSumByType.__ENCList.Capacity = frmInvSumByType.__ENCList.Count
            End If
            frmInvSumByType.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmInvSumByType_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
        If flag Then
            Me.cmbType.Items(0) = "postponed"
            Me.cmbType.Items(1) = "cash"
        End If
        Me.cmbType.SelectedIndex = 1
    End Sub

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
            dataTable.Columns.Add("type")
            dataTable.Columns.Add("no")
            dataTable.Columns.Add("date")
            dataTable.Columns.Add("sumpurch")
            dataTable.Columns.Add("sumsale")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)})
                num3 += 1
            End While
            Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
            If flag Then
                obj = New rptInvTypeClient()
            Else
                obj = New rptInvTypeClient___EN()
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
            Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
            textObject.Text = "النوع"
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbType.Text
            End If
            Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtcust"}, Nothing, Nothing, Nothing), TextObject)
            textObject2.Text = text
            Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateFrom"}, Nothing, Nothing, Nothing), TextObject)
            textObject3.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateTo"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSumPurch"}, Nothing, Nothing, Nothing), TextObject)
            textObject5.Text = Me.txtSumPurch.Text
            Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSumSale"}, Nothing, Nothing, Nothing), TextObject)
            textObject6.Text = Me.txtSumSale.Text
            Try
                Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
                textObject7.Text = Me.GetEmpName(MainClass.EmpNo)
            Catch ex As Exception
            End Try
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
                Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
                textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
                textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
                textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
                textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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
                Catch ex2 As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Try
            Dim str As String = ""
            Dim flag As Boolean = Not Me.chkAll.Checked
            Dim flag2 As Boolean
            If flag Then
                flag2 = (Me.cmbType.SelectedIndex = 0)
                If flag2 Then
                    str = " inv.inv_type=1 and "
                Else
                    flag2 = (Me.cmbType.SelectedIndex = 1)
                    If flag2 Then
                        str = " inv.inv_type=2 and "
                    End If
                End If
            End If
            Dim str2 As String = ""
            flag2 = (MainClass.BranchNo <> -1)
            If flag2 Then
                str2 = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,date,inv_type,tot_purch,tot_sale,tot_net,is_buy from inv where " + str2 + str + " proc_type=1 and date>=@date1 and date<=@date2 and IS_Deleted=0 order by id", Me.conn)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
            Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Me.dgvItems.Rows.Clear()
            Dim num3 As Integer = 0
            Dim num4 As Integer = dataTable.Rows.Count - 1
            Dim num5 As Integer = num3
            While True
                Dim num6 As Integer = num5
                Dim num7 As Integer = num4
                If num6 > num7 Then
                    Exit While
                End If
                Me.dgvItems.Rows.Add()
                Dim value As String = ""
                flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("inv_type"))) = 1.0)
                If flag2 Then
                    flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    If flag Then
                        value = "آجلة"
                    Else
                        value = "postponed"
                    End If
                Else
                    flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("inv_type"))) = 2.0)
                    If flag2 Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag Then
                            value = "نقدية"
                        Else
                            value = "cash"
                        End If
                    End If
                End If
                Dim num8 As Double = 0.0
                Dim num9 As Double = 0.0
                flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("is_buy")))
                If flag2 Then
                    num9 = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("tot_net")))
                Else
                    num8 = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("tot_net")))
                End If
                Me.dgvItems.Rows(num5).Cells(0).Value = value
                Me.dgvItems.Rows(num5).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("id"))
                Me.dgvItems.Rows(num5).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).ToShortDateString()
                Me.dgvItems.Rows(num5).Cells(3).Value = String.Format("{0:0.#,##.##}", num9)
                Me.dgvItems.Rows(num5).Cells(4).Value = String.Format("{0:0.#,##.##}", num8)
                num += num9
                num2 += num8
                num5 += 1
            End While
            Me.txtSumPurch.Text = String.Format("{0:0.#,##.##}", num)
            Me.txtSumSale.Text = String.Format("{0:0.#,##.##}", num2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbType.Enabled = False
        Else
            Me.cmbType.Enabled = True
        End If
    End Sub

    Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Try
            Dim flag As Boolean = e.ColumnIndex = 5
            If flag Then
                Dim Form1 As New Form1()
                Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                Dim value As Integer = 1
                flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)) <> 0.0)
                If flag Then
                    frmSalePurch.InvProc = 1
                Else
                    flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(4).Value)) <> 0.0)
                    If flag Then
                        frmSalePurch.InvProc = 2
                        value = 0
                    End If
                End If
                frmSalePurch.Show()
                frmSalePurch.WindowState = FormWindowState.Maximized
                frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)))
                frmSalePurch.Activate()
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

    Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
    End Sub
End Class
