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
Public Partial Class frmClientInvs
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmInvSumByClient_Load
        frmClientInvs.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmClientInvs.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmClientInvs.__ENCList.Count = frmClientInvs.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmClientInvs.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmClientInvs.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmClientInvs.__ENCList(num) = frmClientInvs.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmClientInvs.__ENCList.RemoveRange(num, frmClientInvs.__ENCList.Count - num)
                frmClientInvs.__ENCList.Capacity = frmClientInvs.__ENCList.Count
            End If
            frmClientInvs.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Public Sub LoadClients()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbClients.DataSource = dataTable
        Me.cmbClients.DisplayMember = "name"
        Me.cmbClients.ValueMember = "id"
        Me.cmbClients.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmInvSumByClient_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmInvSumByClient.Load
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadClients()
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
            dataTable.Columns.Add("DataColumn1")
            dataTable.Columns.Add("no")
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
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)})
                num3 += 1
            End While
            Dim rptClientInvs As rptClientInvs = New rptClientInvs()
            rptClientInvs.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptClientInvs.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
            textObject.Text = Me.cmbClients.Text
            Dim textObject2 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
            textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject3 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
            textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject4 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
            textObject4.Text = Me.txtSum.Text
            Dim textObject5 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(4).ReportObjects("txtvat"), TextObject)
            textObject5.Text = Me.txtVAT.Text
            Dim textObject6 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(4).ReportObjects("txttot"), TextObject)
            textObject6.Text = Me.txtTotal.Text
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject7 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(5).ReportObjects("compar"), TextObject)
                textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameA")))
                Dim textObject8 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(5).ReportObjects("compen"), TextObject)
                textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameE")))
                Dim textObject9 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(5).ReportObjects("commno"), TextObject)
                textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("bsn_no")))
                Dim textObject10 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(5).ReportObjects("taxno"), TextObject)
                textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("tax_no")))
                Dim textObject11 As TextObject = CType(rptClientInvs.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptClientInvs
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptClientInvs.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Function GetCurrencyName(id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol from Currencies where id=" + Conversions.ToString(id), Me.conn)
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

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Try
            Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbClients.SelectedValue Is Nothing
            If flag Then
                MessageBox.Show("يجب اختيار الكل أو العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbClients.Focus()
            Else
                Dim text As String = ""
                flag = (Not Me.chkAll.Checked And Me.cmbClients.SelectedValue IsNot Nothing)
                If flag Then
                    text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" cust_id=", Me.cmbClients.SelectedValue), " and "))
                End If
                Dim str As String = ""
                flag = (MainClass.BranchNo <> -1)
                If flag Then
                    str = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
                End If
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(inv_sub.val) as val,sum(inv_sub.val * exchange_price) as total  from inv,inv_sub where inv.proc_id=inv_sub.proc_id and " + str + text + " is_buy=0 and inv.proc_type=1 and date>=@date1 and date<=@date2 and IS_Deleted=0 group by currency_from order by currency_from", Me.conn)
                sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                Dim num As Double = 0.0
                Me.dgvItems.Rows.Clear()
                Dim num2 As Integer = 0
                Dim num3 As Integer = dataTable.Rows.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Me.dgvItems.Rows.Add()
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sum(inv_sub.val) as val,sum(inv_sub.val * exchange_price) as total  from inv,inv_sub where inv.proc_id=inv_sub.proc_id and " + str + text + " is_buy=0 and inv.proc_type=2 and date>=@date1 and date<=@date2 and IS_Deleted=0 and currency_from=", dataTable.Rows(num4)("currency_from"))), Me.conn)
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                    sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    Dim num7 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num4)("total"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("total")))
                    Dim num8 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num4)("val"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("val")))
                    Me.dgvItems.Rows(num4).Cells(0).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num4)("currency_from")))
                    Me.dgvItems.Rows(num4).Cells(1).Value = Math.Round(num7 / num8, 2)
                    Me.dgvItems.Rows(num4).Cells(2).Value = Math.Round(num8, 2)
                    Me.dgvItems.Rows(num4).Cells(3).Value = Math.Round(num7, 2)
                    num += Math.Round(num7, 2)
                    num4 += 1
                End While
                sqlDataAdapter = New SqlDataAdapter("select sum(inv_sub.taxval) as tax  from inv,inv_sub where inv.proc_id=inv_sub.proc_id and " + str + text + " is_buy=0 and inv.proc_type=1 and date>=@date1 and date<=@date2 and IS_Deleted=0", Me.conn)
                sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
                dataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                Dim num9 As Decimal = New Decimal(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("tax"))), 2))
                sqlDataAdapter = New SqlDataAdapter("select sum(inv_sub.taxval) as tax  from inv,inv_sub where inv.proc_id=inv_sub.proc_id and " + str + text + " is_buy=0 and inv.proc_type=2 and date>=@date1 and date<=@date2 and IS_Deleted=0", Me.conn)
                sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
                dataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                num9 = New Decimal(Convert.ToDouble(num9) - Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("tax"))), 2))
                Me.txtSum.Text = String.Format("{0:0.#,##.##}", num)
                Me.txtVAT.Text = String.Format("{0:0.#,##.##}", num9)
                Me.txtTotal.Text = String.Format("{0:0.#,##.##}", num + Convert.ToDouble(num9))
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

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbClients.Enabled = False
        Else
            Me.cmbClients.Enabled = True
        End If
    End Sub

    Private Sub PrintRptMini(type As Integer)
        Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("type")
            dataTable.Columns.Add("DataColumn1")
            dataTable.Columns.Add("no")
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
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)})
                num3 += 1
            End While
            Dim rptItemsDaily As rptItemsDaily = New rptItemsDaily()
            rptItemsDaily.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptItemsDaily.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
            textObject.Text = "تاريخ الحركة " + Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject2 As TextObject = CType(rptItemsDaily.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
            textObject2.Text = Me.txtSum.Text
            Dim textObject3 As TextObject = CType(rptItemsDaily.ReportDefinition.Sections(4).ReportObjects("txtvat"), TextObject)
            textObject3.Text = Me.txtVAT.Text
            Dim textObject4 As TextObject = CType(rptItemsDaily.ReportDefinition.Sections(4).ReportObjects("txttot"), TextObject)
            textObject4.Text = Me.txtTotal.Text
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject5 As TextObject = CType(rptItemsDaily.ReportDefinition.Sections(0).ReportObjects("compar"), TextObject)
                textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameA")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptItemsDaily
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptItemsDaily.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.PrintRptMini(1)
    End Sub
End Class
