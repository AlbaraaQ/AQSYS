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
Imports AQSYS.AQSYS.rptt
Imports System.Windows.Forms
Public Partial Class frmDecisionHelp
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmDecisionHelp_Load
        frmDecisionHelp.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmDecisionHelp.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmDecisionHelp.__ENCList.Count = frmDecisionHelp.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmDecisionHelp.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmDecisionHelp.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmDecisionHelp.__ENCList(num) = frmDecisionHelp.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmDecisionHelp.__ENCList.RemoveRange(num, frmDecisionHelp.__ENCList.Count - num)
                frmDecisionHelp.__ENCList.Capacity = frmDecisionHelp.__ENCList.Count
            End If
            frmDecisionHelp.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Public Sub LoadCurrencies()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from Currencies where IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCurrency.DataSource = dataTable
        Me.cmbCurrency.DisplayMember = "symbol"
        Me.cmbCurrency.ValueMember = "id"
        Me.cmbCurrency.SelectedIndex = -1
    End Sub

    Public Sub LoadSafes()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes where branch=" + Conversions.ToString(MainClass.BranchNo) + " and status=1 and IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbSafes.DataSource = dataTable
        Me.cmbSafes.DisplayMember = "name"
        Me.cmbSafes.ValueMember = "id"
        Me.cmbSafes.SelectedIndex = -1
    End Sub

    Private Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = "select id,symbol from Currencies where IS_Deleted=0"
            Dim flag As Boolean = Not Me.chkAllCurrency.Checked
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and id=", Me.cmbCurrency.SelectedValue)))
            End If
            text += " order by id"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim text2 As String = ""
            flag = Not Me.chkAllSafes.Checked
            If flag Then
                text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(" and inv.safe=", Me.cmbSafes.SelectedValue)))
            End If
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Dim num6 As Double = 0.0
                Dim num7 As Double = 0.0
                Dim num8 As Double = 0.0
                Dim num9 As Double = 0.0
                Dim num10 As Double = 0.0
                Dim num11 As Double = 0.0
                Dim num12 As Double = 0.0
                Dim str As String = ""
                flag = (MainClass.BranchNo <> -1)
                If flag Then
                    str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
                End If
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num3)("id")), " and inv.proc_type=3 "), " and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0 "), text2)), Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num6 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num3)("id")), " and inv.proc_type=1 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0 "), text2)), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num7 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num3)("id")), " and inv.proc_type=2 "), " and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0 "), text2)), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num3)("id")), " and inv.proc_type=1 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0 "), text2)), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num9 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + str + " Inv_Sub.currency_from=", dataTable.Rows(num3)("id")), " and inv.proc_type=2 "), " and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and inv.IS_Deleted=0 "), text2)), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num10 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                End If
                flag = Not Me.chkAllSafes.Checked
                If flag Then
                    sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + str + " SafesTransfer.safe_to=", Me.cmbSafes.SelectedValue), " and SafesTransfer_Sub.currency="), dataTable.Rows(num3)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0")), Me.conn)
                    dataTable2 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num11 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    End If
                    sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(value) from SafesTransfer,SafesTransfer_Sub where " + str + " SafesTransfer.safe_from=", Me.cmbSafes.SelectedValue), " and SafesTransfer_Sub.currency="), dataTable.Rows(num3)("id")), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0")), Me.conn)
                    dataTable2 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(0).ToString(), "", False) <> 0)
                    If flag Then
                        num12 = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    End If
                End If
                flag = (num6 <> 0.0 Or num7 <> 0.0 Or num9 <> 0.0 Or num11 <> 0.0 Or num12 <> 0.0)
                If flag Then
                    Dim num13 As Double
                    Dim num14 As Double
                    Dim num15 As Double

                    num13 = num6 + num7 - num8 + num11
                    num14 = num9 - num10 + num12
                    num15 = num13 - num14
                    Me.dgvItems.Rows.Add()

                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("Symbol"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num13
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num14
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num15
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = "" + Conversions.ToString(Math.Round(num15 / num13 * 100.0, 1)) + " %"
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = "" + Conversions.ToString(Math.Round(num14 / num13 * 100.0, 1)) + " %"
                End If
                num3 += 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmDecisionHelp_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmDecisionHelp.Load
        Me.LoadCurrencies()
        Me.LoadSafes()
    End Sub

    Private Sub chkAllCurrency_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllCurrency.CheckedChanged
        Dim checked As Boolean = Me.chkAllCurrency.Checked
        If checked Then
            Me.cmbCurrency.Enabled = False
        Else
            Me.cmbCurrency.Enabled = True
        End If
    End Sub

    Private Sub chkAllSafes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllSafes.CheckedChanged
        Dim checked As Boolean = Me.chkAllSafes.Checked
        If checked Then
            Me.cmbSafes.Enabled = False
        Else
            Me.cmbSafes.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Dim flag As Boolean = Not Me.chkAllCurrency.Checked And Me.cmbCurrency.SelectedIndex = -1
        If flag Then
            MessageBox.Show("يجب اختيار الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbCurrency.Focus()
        Else
            flag = (Not Me.chkAllSafes.Checked And Me.cmbSafes.SelectedIndex = -1)
            If flag Then
                MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbSafes.Focus()
            Else
                Me.dgvItems.Rows.Clear()
                Me.CalcStock()
            End If
        End If
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
            dataTable.Columns.Add("no")
            dataTable.Columns.Add("name")
            dataTable.Columns.Add("income")
            dataTable.Columns.Add("outcome")
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("rkod")
            dataTable.Columns.Add("doran")
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
            Dim rptDecisionHelp As rptDecisionHelp = New rptDecisionHelp()
            rptDecisionHelp.SetDataSource(dataTable)
            Dim text As String = "الكل"
            flag = Not Me.chkAllSafes.Checked
            If flag Then
                text = Me.cmbSafes.Text
            End If
            Dim text2 As String = "الكل"
            flag = Not Me.chkAllCurrency.Checked
            If flag Then
                text2 = Me.cmbCurrency.Text
            End If
            Dim textObject As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
            textObject.Text = text
            Dim textObject2 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(1).ReportObjects("curr"), TextObject)
            textObject2.Text = text2
            Dim textObject3 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject3.Text = Me.GetEmpUserName(MainClass.EmpNo)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptDecisionHelp.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject4 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject5 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject6 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject7 As TextObject = CType(rptDecisionHelp.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptDecisionHelp
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptDecisionHelp.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
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
End Class
