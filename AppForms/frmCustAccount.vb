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
Imports AQSYS.AQSYS.rptt
Public Partial Class frmCustAccount
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private _loaded As Boolean

    Public _type As Integer

    Public ClientID As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCustAccount_Load
        frmCustAccount.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._loaded = False
        Me._type = 1
        Me.ClientID = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCustAccount.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCustAccount.__ENCList.Count = frmCustAccount.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCustAccount.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCustAccount.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCustAccount.__ENCList(num) = frmCustAccount.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCustAccount.__ENCList.RemoveRange(num, frmCustAccount.__ENCList.Count - num)
                frmCustAccount.__ENCList.Capacity = frmCustAccount.__ENCList.Count
            End If
            frmCustAccount.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Public Sub LoadActs()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Acts order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbActs.DataSource = dataTable
        Me.cmbActs.DisplayMember = "name"
        Me.cmbActs.ValueMember = "id"
        Me.cmbActs.SelectedIndex = -1
    End Sub

    Private Sub frmCustAccount_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmCustAccount.Load
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Dim flag As Boolean = Me._type = 2
        If flag Then
            Me.Text = "أرصدة حسابات الموردين"
            Me.lblCust.Text = "إسم المورد"
            Me.dgvItems.Columns(1).HeaderText = "إسم المورد"
        End If
        Me.LoadActs()
        Me.LoadClients()
        Me._loaded = True
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub LoadClients(_act As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id,name from Customers where type=", Conversions.ToString(Me._type), " and act=", Conversions.ToString(_act), " and IS_Deleted=0 order by id"}), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbClients.DataSource = dataTable
        Me.cmbClients.DisplayMember = "name"
        Me.cmbClients.ValueMember = "id"
        Me.cmbClients.SelectedIndex = -1
    End Sub

    Public Sub LoadClients()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=" + Conversions.ToString(Me._type) + " and IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbClients.DataSource = dataTable
        Me.cmbClients.DisplayMember = "name"
        Me.cmbClients.ValueMember = "id"
        Me.cmbClients.SelectedIndex = -1
    End Sub

    Private Sub ShowResult()
        Try
            Dim text As String = "select id,name from Customers where type=" + Conversions.ToString(Me._type) + " and IS_Deleted=0"
            Dim flag As Boolean = Not Me.chkAllActs.Checked And Me.cmbActs.SelectedValue IsNot Nothing
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and act=", Me.cmbActs.SelectedValue)))
            End If
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and id=", Me.cmbClients.SelectedValue)))
            End If
            text += " order by id"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.dgvItems.Rows.Clear()
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Dim num3 As Integer = 0
            Dim num4 As Integer = dataTable.Rows.Count - 1
            Dim num5 As Integer = num3
            While True
                Dim num6 As Integer = num5
                Dim num7 As Integer = num4
                If num6 > num7 Then
                    Exit While
                End If
                Dim num8 As Integer = -1
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Code from Accounts_Index where Type=2 and AName='", dataTable.Rows(num5)("name")), "'")), Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    num8 = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                Dim text2 As String = ""
                text2 = text2 + " and Restrictions_Sub.acc_no=" + Conversions.ToString(num8)
                Dim str As String = ""
                flag = (MainClass.BranchNo <> -1)
                If flag Then
                    str = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
                End If
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id " + text2, Me.conn)
                sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
                sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                Dim num9 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                Dim num10 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
                flag = (num10 <> 0.0 Or num9 - num10 <> 0.0)
                If flag Then

                    num += num9
                    num2 += num10
                    Me.dgvItems.Rows.Add()

                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = num8
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("name"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num9
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num10
                    flag = (num9 >= num10)
                    If flag Then
                        ' The following expression was wrapped in a unchecked-expression
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = "" + Conversions.ToString(Math.Round(num9 - num10, 3))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = "مدين"
                    Else
                        ' The following expression was wrapped in a unchecked-expression
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = "" + Conversions.ToString(Math.Round(num10 - num9, 3))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = "دائن"
                    End If
                End If
                num5 += 1
            End While
            Me.txtSumDept.Text = "" + Conversions.ToString(num)
            Me.txtSumCredit.Text = "" + Conversions.ToString(num2)
            flag = (num >= num2)
            If flag Then
                Me.txtSumBalance.Text = "" + Conversions.ToString(Math.Round(num - num2, 3))
                Me.txtSumState.Text = "مدين"
            Else
                Me.txtSumBalance.Text = "" + Conversions.ToString(Math.Round(num2 - num, 3))
                Me.txtSumState.Text = "دائن"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbClients.SelectedIndex = -1
        If flag Then
            MessageBox.Show("يجب اختيار إسم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbClients.Focus()
        Else
            Me.dgvItems.Rows.Clear()
            Me.ShowResult()
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbClients.Enabled = False
        Else
            Me.cmbClients.Enabled = True
        End If
    End Sub

    Private Sub txtSum_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtSumDept.Click
    End Sub

    Private Function GetEmpUserName(emp As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from users,Employees where users.emp=Employees.id and Employees.id=" + Conversions.ToString(emp), Me.conn)
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
            dataTable.Columns.Add("accno")
            dataTable.Columns.Add("custname")
            dataTable.Columns.Add("dept")
            dataTable.Columns.Add("credit")
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("state")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value)})
                num3 += 1
            End While
            Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
            If flag Then
                obj = New rptCustBalance()
            Else
                obj = New rptCustBalance___EN()
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
            Try
                flag = (Me._type = 2)
                If flag Then
                    Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
                    textObject.Text = "أرصدة حسابات الموردين"
                    Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblCust"}, Nothing, Nothing, Nothing), TextObject)
                    textObject2.Text = "إسم المورد"
                    Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblCust1"}, Nothing, Nothing, Nothing), TextObject)
                    textObject3.Text = "إسم المورد"
                End If
            Catch ex As Exception
            End Try
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbClients.Text
            End If
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtacc"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = text
            Dim text2 As String = "الكل"
            flag = Not Me.chkAllActs.Checked
            If flag Then
                text2 = Me.cmbActs.Text
            End If
            Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtact"}, Nothing, Nothing, Nothing), TextObject)
            textObject5.Text = text2
            Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateFrom"}, Nothing, Nothing, Nothing), TextObject)
            textObject6.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDateTo"}, Nothing, Nothing, Nothing), TextObject)
            textObject7.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtsum1"}, Nothing, Nothing, Nothing), TextObject)
            textObject8.Text = Me.txtSumDept.Text
            Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtsum2"}, Nothing, Nothing, Nothing), TextObject)
            textObject9.Text = Me.txtSumCredit.Text
            Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtsum3"}, Nothing, Nothing, Nothing), TextObject)
            textObject10.Text = Me.txtSumBalance.Text
            Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtsumstate"}, Nothing, Nothing, Nothing), TextObject)
            textObject11.Text = Me.txtSumState.Text
            Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
            textObject12.Text = Me.GetEmpUserName(MainClass.EmpNo)
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
                Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
                textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
                textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
                textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
                textObject16.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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

    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(2)
    End Sub

    Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        Try
            'New frmSrchClient() With { .Form_Type = 3, .frm3 = Me }.ShowDialog()
            Using frm As New frmSrchClient()
                frm.Form_Type = 3
                frm.frm3 = Me
                frm.ShowDialog()
            End Using
            Me.cmbClients.SelectedValue = Me.ClientID
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAllActs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllActs.CheckedChanged
        Try
            Dim flag As Boolean = Me.chkAllActs.Checked
            If flag Then
                Me.cmbActs.Enabled = False
                flag = Me._loaded
                If flag Then
                    Me.cmbActs.SelectedIndex = -1
                    Me.LoadClients()
                End If
            Else
                Me.cmbActs.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbActs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbActs.SelectedIndexChanged
        Try
            Dim loaded As Boolean = Me._loaded
            If loaded Then
                Me.LoadClients(Conversions.ToInteger(Me.cmbActs.SelectedValue))
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
