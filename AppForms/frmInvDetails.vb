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
Imports AQSYS.AQSYS.rptt
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Public Partial Class frmInvDetails
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmInvDetails_Load
        frmInvDetails.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmInvDetails.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmInvDetails.__ENCList.Count = frmInvDetails.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmInvDetails.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmInvDetails.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmInvDetails.__ENCList(num) = frmInvDetails.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmInvDetails.__ENCList.RemoveRange(num, frmInvDetails.__ENCList.Count - num)
                frmInvDetails.__ENCList.Capacity = frmInvDetails.__ENCList.Count
            End If
            frmInvDetails.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.ShowResult()
    End Sub

    Private Function GetCurrencyName(Currency_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Symbol,nameEN from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As String
        If flag Then
            Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
            If flag2 Then
                result = dataTable.Rows(0)(0).ToString()
            Else
                result = dataTable.Rows(0)(1).ToString()
            End If
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

    Private Function GetSafeName(Safe As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Safes where id=" + Conversions.ToString(Safe), Me.conn)
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

    Private Function GetSalesEmpNameByInvNo(type As Integer, no As Integer) As String
        Dim result As String
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from Employees,Inv,users where users.emp=Employees.id and Employees.id=Inv.sales_emp and Inv.id=" + Conversions.ToString(no) + " and inv.proc_type=" + Conversions.ToString(type), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            Else
                result = ""
            End If
        Catch ex As Exception
            result = ""
        End Try
        Return result
    End Function

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            flag = Me.rdBynv.Checked
            If flag Then
                Dim dataTable As DataTable = New DataTable()
                dataTable.Columns.Add("safe")
                dataTable.Columns.Add("procetype")
                dataTable.Columns.Add("date")
                dataTable.Columns.Add("invno")
                dataTable.Columns.Add("curr")
                dataTable.Columns.Add("val")
                dataTable.Columns.Add("price")
                dataTable.Columns.Add("total")
                dataTable.Columns.Add("user")
                Dim num As Integer = 0
                Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
                Dim num3 As Integer = num
                While True
                    Dim num4 As Integer = num3
                    Dim num5 As Integer = num2
                    If num4 > num5 Then
                        Exit While
                    End If
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)})
                    num3 += 1
                End While
                Dim rptInvDetails As rptInvDetails = New rptInvDetails()
                rptInvDetails.SetDataSource(dataTable)
                Dim text As String = "الكل"
                flag = Not Me.chkAllSafes.Checked
                If flag Then
                    text = Me.cmbSafes.Text
                End If
                Dim text2 As String = "الكل"
                flag = Not Me.chkAllSafes.Checked
                If flag Then
                    text2 = Me.cmbCurrencies.Text
                End If
                Dim textObject As TextObject = CType(rptInvDetails.ReportDefinition.Sections(1).ReportObjects("safe"), TextObject)
                textObject.Text = text
                Dim textObject2 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(1).ReportObjects("curr"), TextObject)
                textObject2.Text = text2
                Dim textObject3 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
                textObject3.Text = Me.txtDateFrom.Value.ToShortDateString()
                Dim textObject4 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
                textObject4.Text = Me.txtDateTo.Value.ToShortDateString()
                Dim textObject5 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
                textObject5.Text = Me.txtSum.Text
                Dim textObject6 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
                textObject6.Text = Me.GetEmpName(MainClass.EmpNo)
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable2)
                rptInvDetails.Subreports("rptHeader").SetDataSource(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    Dim textObject7 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                    textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                    Dim textObject8 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                    textObject8.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                    Dim textObject9 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                    textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                    Dim textObject10 As TextObject = CType(rptInvDetails.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                    textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
                End If
                Dim frmRptViewer As frmRptViewer = New frmRptViewer()
                Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
                frmRptViewer.Controls.Add(crystalReportViewer)
                crystalReportViewer.Dock = DockStyle.Fill
                crystalReportViewer.DisplayGroupTree = False
                crystalReportViewer.ReportSource = rptInvDetails
                frmRptViewer.WindowState = FormWindowState.Maximized
                flag = (type = 1)
                If flag Then
                    frmRptViewer.Show()
                Else
                    Try
                        crystalReportViewer.ShowLastPage()
                        Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                        crystalReportViewer.ShowFirstPage()
                        rptInvDetails.PrintToPrinter(1, False, 1, currentPageNumber)
                    Catch ex As Exception
                    End Try
                End If
            Else
                Dim dataTable3 As DataTable = New DataTable()
                dataTable3.Columns.Add("col1")
                dataTable3.Columns.Add("col2")
                dataTable3.Columns.Add("col3")
                Dim num6 As Integer = 0
                Dim num7 As Integer = Me.dgvItems.Rows.Count - 1
                Dim num8 As Integer = num6
                While True
                    Dim num9 As Integer = num8
                    Dim num5 As Integer = num7
                    If num9 > num5 Then
                        Exit While
                    End If
                    dataTable3.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num8).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num8).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num8).Cells(7).Value)})
                    num8 += 1
                End While
                Dim rptCol As rptCol3 = New rptCol3()
                rptCol.SetDataSource(dataTable3)
                flag = Not Me.chkAllSafes.Checked
                If flag Then
                    Dim text3 As String = Me.cmbSafes.Text
                End If
                flag = Not Me.chkAllSafes.Checked
                If flag Then
                    Dim text4 As String = Me.cmbCurrencies.Text
                End If
                flag = (Me.cmbProcType.SelectedIndex = 0)
                Dim text5 As String
                If flag Then
                    text5 = "تقرير مشتريات أصناف أجمالي خلال فترة"
                Else
                    text5 = "تقرير مبيعات أصناف أجمالي خلال فترة"
                End If
                Dim textObject11 As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
                textObject11.Text = text5
                Dim textObject12 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
                textObject12.Text = "الصنف"
                Dim textObject13 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col2"), TextObject)
                textObject13.Text = "الكمية"
                Dim textObject14 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col3"), TextObject)
                textObject14.Text = "الإجمالي"
                Dim textObject15 As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtdate"), TextObject)
                textObject15.Text = "من تاريخ:" + Me.txtDateFrom.Value.ToShortDateString() + "   إلى تاريخ: " + Me.txtDateTo.Value.ToShortDateString()
                Dim textObject16 As TextObject = CType(rptCol.ReportDefinition.Sections(4).ReportObjects("lbltot"), TextObject)
                textObject16.Text = "الإجمالي"
                Dim textObject17 As TextObject = CType(rptCol.ReportDefinition.Sections(4).ReportObjects("txttot"), TextObject)
                textObject17.Text = Me.txtSum.Text
                textObject16.Border.BackgroundColor = Color.Silver
                textObject17.Border.BackgroundColor = Color.Silver
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
                Dim dataTable4 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable4)
                rptCol.Subreports("rptHeader").SetDataSource(dataTable4)
                flag = (dataTable4.Rows.Count > 0)
                If flag Then
                    Dim textObject18 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                    textObject18.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Address")))
                    Dim textObject19 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                    textObject19.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Tel")))
                    Dim textObject20 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                    textObject20.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Mobile")))
                    Dim textObject21 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                    textObject21.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Fax")))
                End If
                Dim frmRptViewer2 As frmRptViewer = New frmRptViewer()
                Dim crystalReportViewer2 As CrystalReportViewer = New CrystalReportViewer()
                frmRptViewer2.Controls.Add(crystalReportViewer2)
                crystalReportViewer2.Dock = DockStyle.Fill
                crystalReportViewer2.DisplayGroupTree = False
                crystalReportViewer2.ReportSource = rptCol
                frmRptViewer2.WindowState = FormWindowState.Maximized
                flag = (type = 1)
                If flag Then
                    frmRptViewer2.Show()
                Else
                    Try
                        crystalReportViewer2.ShowLastPage()
                        Dim currentPageNumber2 As Integer = crystalReportViewer2.GetCurrentPageNumber()
                        crystalReportViewer2.ShowFirstPage()
                        rptCol.PrintToPrinter(1, False, 1, currentPageNumber2)
                    Catch ex2 As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ShowResult()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = ""
            Dim flag As Boolean = Not Me.chkAllSafes.Checked
            Dim flag2 As Boolean
            If flag Then
                flag2 = (Me.cmbSafes.SelectedValue Is Nothing)
                If flag2 Then
                    MessageBox.Show("اختر مخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbSafes.Focus()
                    Return
                End If
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Inv.safe=", Me.cmbSafes.SelectedValue)))
            End If
            flag2 = Not Me.chkAllCurrencies.Checked
            If flag2 Then
                flag = (Me.cmbCurrencies.SelectedValue Is Nothing)
                If flag Then
                    MessageBox.Show("اختر صنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbCurrencies.Focus()
                    Return
                End If
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Inv_Sub.currency_from=", Me.cmbCurrencies.SelectedValue)))
            End If
            Dim num As Integer = 1
            flag2 = (Me.cmbProcType.SelectedIndex = 1)
            If flag2 Then
                num = 2
            End If
            Dim text2 As String = ""
            flag2 = (MainClass.BranchNo <> -1)
            If flag2 Then
                text2 = "inv.branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim num2 As Double = 0.0
            flag2 = Me.rdBynv.Checked
            If flag2 Then
                Me.dgvItems.Columns(0).Visible = True
                Me.dgvItems.Columns(1).Visible = True
                Me.dgvItems.Columns(2).Visible = True
                Me.dgvItems.Columns(3).Visible = True
                Me.dgvItems.Columns(6).Visible = True
                Me.dgvItems.Columns(8).Visible = True
                Me.dgvItems.Columns(9).Visible = True
                Me.dgvItems.Columns(4).Width = 130
                Me.dgvItems.Columns(5).Width = 100
                Me.dgvItems.Columns(7).Width = 130
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Inv.safe,Inv.proc_type,date,Inv.id,currency_from,val1 as val,exchange_price,(val1*exchange_price + taxval - discount - ISNULL(cust_disc, 0 ))as sum,sales_emp  from Inv,Inv_Sub where ", text2, " date>=@date1 and date<=@date2 and Inv.proc_id=Inv_Sub.proc_id and Inv_Sub.proc_type=", Conversions.ToString(num), " and Inv.IS_Deleted=0 ", text, " order by date"}), Me.conn)
                sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
                sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
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
                    Dim flag3 As Boolean = True
                    Dim flag4 As Boolean = True
                    Dim value As String = ""
                    flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("proc_type"))) = 1.0 And num = 1)
                    If flag2 Then
                        value = "فاتورة شراء"
                        flag4 = True
                    Else
                        flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("proc_type"))) = 1.0 And num = 2)
                        If flag2 Then
                            value = "فاتورة بيع"
                            flag4 = True
                        Else
                            flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("proc_type"))) = 2.0 And num = 1)
                            If flag2 Then
                                value = "فاتورة مرتد شراء"
                                flag4 = False
                            Else
                                flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("proc_type"))) = 2.0 And num = 2)
                                If flag2 Then
                                    value = "فاتورة مرتد بيع"
                                    flag4 = False
                                Else
                                    flag3 = False
                                End If
                            End If
                        End If
                    End If
                    flag2 = flag3
                    If flag2 Then
                        Me.dgvItems.Rows.Add()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Me.GetSafeName(Conversions.ToInteger(dataTable.Rows(num5)("safe")))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = value
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("date"))).ToShortDateString()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("id"))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num5)("currency_from")))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("val"))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("exchange_price"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("sum"))))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(8).Value = Me.GetEmpName(Conversions.ToInteger(dataTable.Rows(num5)("sales_emp")))
                        flag2 = flag4

                        If flag2 Then
                            num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("sum")))
                        Else
                            num2 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("sum")))
                        End If

                    End If
                    num5 += 1
                End While
            Else
                Me.dgvItems.Columns(0).Visible = False
                Me.dgvItems.Columns(1).Visible = False
                Me.dgvItems.Columns(2).Visible = False
                Me.dgvItems.Columns(3).Visible = False
                Me.dgvItems.Columns(6).Visible = False
                Me.dgvItems.Columns(8).Visible = False
                Me.dgvItems.Columns(9).Visible = False
                Me.dgvItems.Columns(4).Width = 400
                Me.dgvItems.Columns(5).Width = 300
                Me.dgvItems.Columns(7).Width = 300
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency_from,sum(val),sum(val1*exchange_price + taxval - discount - ISNULL(cust_disc, 0 ))as sum  from Inv,Inv_Sub where ", text2, " Inv.proc_type=1 and date>=@date1 and date<=@date2 and Inv.proc_id=Inv_Sub.proc_id and Inv_Sub.proc_type=", Conversions.ToString(num), " and Inv.IS_Deleted=0 ", text, " group by currency_from"}), Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dateTime2 As DateTime = Me.txtDateTo.Value.AddHours(24.0)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                Me.dgvItems.Rows.Clear()
                Dim num8 As Integer = 0
                Dim num9 As Integer = dataTable2.Rows.Count - 1
                Dim num10 As Integer = num8
                While True
                    Dim num11 As Integer = num10
                    Dim num7 As Integer = num9
                    If num11 > num7 Then
                        Exit While
                    End If
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price + taxval - discount - ISNULL(cust_disc, 0 ))as sum  from Inv,Inv_Sub where " + text2 + " currency_from=", dataTable2.Rows(num10)("currency_from")), " and Inv.proc_type=2 and date>=@date1 and date<=@date2 and Inv.proc_id=Inv_Sub.proc_id and Inv_Sub.proc_type="), num), " and Inv.IS_Deleted=0 "), text)), Me.conn)
                    sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                    sqlDataAdapter3.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime2
                    Dim dataTable3 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable3)
                    Me.dgvItems.Rows.Add()
                    Dim num12 As Decimal = New Decimal(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num10)(1))))
                    flag2 = (dataTable3.Rows.Count > 0)
                    Dim num13 As Decimal

                    If flag2 Then
                        num12 = New Decimal(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num10)(1))) - Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0))))
                    End If
                    num13 = New Decimal(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num10)(2))))
                    flag2 = (dataTable3.Rows.Count > 0)
                    If flag2 Then
                        num13 = New Decimal(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num10)(2))) - Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))))
                    End If

                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable2.Rows(num10)("currency_from")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num12
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = String.Format("{0:0.#,##.##}", num13)

                    num2 += Convert.ToDouble(num13)

                    num10 += 1
                End While
            End If
            Me.txtSum.Text = String.Format("{0:0.#,##.##}", num2)
        Catch ex As Exception
        End Try
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

    Public Sub LoadCurrencies()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol,nameEN from Currencies where IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCurrencies.DataSource = dataTable
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
        If flag Then
            Me.cmbCurrencies.DisplayMember = "symbol"
        Else
            Me.cmbCurrencies.DisplayMember = "nameEN"
        End If
        Me.cmbCurrencies.ValueMember = "id"
        Me.cmbCurrencies.SelectedIndex = -1
    End Sub

    Private Sub frmInvDetails_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.cmbProcType.SelectedIndex = 0
        Me.LoadSafes()
        Me.LoadCurrencies()
    End Sub

    Private Sub chkAllSafes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllSafes.CheckedChanged
        Dim checked As Boolean = Me.chkAllSafes.Checked
        If checked Then
            Me.cmbSafes.Enabled = False
        Else
            Me.cmbSafes.Enabled = True
        End If
    End Sub

    Private Sub chkAllCurrencies_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllCurrencies.CheckedChanged
        Dim checked As Boolean = Me.chkAllCurrencies.Checked
        If checked Then
            Me.cmbCurrencies.Enabled = False
        Else
            Me.cmbCurrencies.Enabled = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = e.ColumnIndex = 9
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة بيع", False) = 0
                If flag2 Then
                    Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                    Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                    Dim value As Integer = 1
                    flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة شراء", False) = 0)
                    If flag2 Then
                        frmSalePurch.InvProc = 1
                    Else
                        flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة بيع", False) = 0)
                        If flag2 Then
                            frmSalePurch.InvProc = 2
                            value = 0
                        End If
                    End If
                    frmSalePurch.Show()
                    frmSalePurch.WindowState = FormWindowState.Maximized
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)))
                    frmSalePurch.Activate()
                Else
                    flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة مرتد شراء", False) = 0 Or Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة مرتد بيع", False) = 0)
                    If flag2 Then
                        Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                        Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
                        Dim value2 As Integer = 1
                        flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة مرتد شراء", False) = 0)
                        If flag2 Then
                            frmSalePurch2.InvProc = 1
                        Else
                            flag2 = (Operators.CompareString(Convert.ToString(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(1).Value)), "فاتورة مرتد بيع", False) = 0)
                            If flag2 Then
                                frmSalePurch2.InvProc = 2
                                value2 = 0
                            End If
                        End If
                        frmSalePurch2.Show()
                        frmSalePurch2.WindowState = FormWindowState.Maximized
                        frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where IS_Deleted=0 and proc_type=2 and is_buy=" + Conversions.ToString(value2) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)))
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

    Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
    End Sub
End Class
