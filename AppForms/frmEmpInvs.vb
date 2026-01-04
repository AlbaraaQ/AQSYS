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
Imports AQSYS.My
Public Partial Class frmEmpInvs
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private EmpName As String

    Private _lastinvid As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmEmpInvs_Load
        frmEmpInvs.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.EmpName = ""
        Me._lastinvid = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmEmpInvs.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmEmpInvs.__ENCList.Count = frmEmpInvs.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmEmpInvs.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmEmpInvs.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmEmpInvs.__ENCList(num) = frmEmpInvs.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmEmpInvs.__ENCList.RemoveRange(num, frmEmpInvs.__ENCList.Count - num)
                frmEmpInvs.__ENCList.Capacity = frmEmpInvs.__ENCList.Count
            End If
            frmEmpInvs.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
            Dim rptEmpInv As rptEmpInv = New rptEmpInv()
            rptEmpInv.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptEmpInv.ReportDefinition.Sections(1).ReportObjects("lbl"), TextObject)
            textObject.Text = Me.cmbProcType.Text
            Dim textObject2 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(1).ReportObjects("txtemp"), TextObject)
            textObject2.Text = Me.EmpName
            Dim textObject3 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
            textObject3.Text = Me.txtDateFrom.Value.ToString("dd/MM/yyyy hh:mm tt")
            Dim textObject4 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
            textObject4.Text = Me.txtDateTo.Value.ToString("dd/MM/yyyy hh:mm tt")
            Dim textObject5 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("sum_tab3"), TextObject)
            textObject5.Text = Me.txtSumTab3.Text
            Dim textObject6 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("sum_VAT"), TextObject)
            textObject6.Text = Me.txtSumVAT.Text
            Dim textObject7 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
            textObject7.Text = Me.txtSum.Text
            Dim textObject8 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("txtSumCash"), TextObject)
            textObject8.Text = Me.txtSumCash.Text
            Dim textObject9 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("txtSumNetwork"), TextObject)
            textObject9.Text = Me.txtSumNetwork.Text
            Dim textObject10 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(4).ReportObjects("txtSumAgel"), TextObject)
            textObject10.Text = Me.txtSumAgel.Text
            Dim textObject11 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject11.Text = Me.GetEmpName(MainClass.EmpNo)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptEmpInv.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject12 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject13 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject14 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject15 As TextObject = CType(rptEmpInv.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptEmpInv
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptEmpInv.PrintToPrinter(1, False, 1, currentPageNumber)
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
                    MessageBox.Show("اختر موظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbEmps.Focus()
                    Return
                End If
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Inv.sales_emp=", Me.cmbEmps.SelectedValue)))
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
            Dim text3 As String = ""
            flag2 = Me.rdCash.Checked
            If flag2 Then
                text3 = " (pay_type=1 or cash_part<>0) and "
            Else
                flag2 = Me.rdNetwork.Checked
                If flag2 Then
                    text3 = " (pay_type=2 or network_part<>0) and "
                Else
                    flag2 = Me.rdAgel.Checked
                    If flag2 Then
                        text3 = " inv_type=1 and "
                    End If
                End If
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select inv.proc_id,Inv.proc_type,date,Inv.id,inv.inv_type,inv.pay_type,currency_from,val1 as val,exchange_price,taxval,ISNULL(item_tab3,0) as tab3,(val1*exchange_price + taxval - discount - ISNULL(cust_disc, 0 ) + ISNULL(item_tab3,0))as sum,cash_part,network_part  from Inv,Inv_Sub where ", text2, text3, " date>=@date1 and date<=@date2 and Inv.proc_id=Inv_Sub.proc_id and Inv_Sub.proc_type=", Conversions.ToString(num), " and Inv.IS_Deleted=0 ", text, " order by date"}), Me.conn)
            sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value
            Dim value As DateTime = Me.txtDateTo.Value
            sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = value
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim num2 As Double = 0.0
            Dim num3 As Double = 0.0
            Dim num4 As Double = 0.0
            Dim num5 As Double = 0.0
            Dim num6 As Double = 0.0
            Dim num7 As Double = 0.0
            Me.dgvItems.Rows.Clear()
            Me.EmpName = ""
            flag2 = Not Me.chkAll.Checked
            If flag2 Then
                Me.EmpName = Me.cmbEmps.Text
            Else
                Me.EmpName = "الكل"
            End If
            Dim num8 As Integer = 0
            Dim num9 As Integer = dataTable.Rows.Count - 1
            Dim num10 As Integer = num8
            While True
                Dim num11 As Integer = num10
                Dim num12 As Integer = num9
                If num11 > num12 Then
                    Exit While
                End If
                Dim flag3 As Boolean = True
                Dim flag4 As Boolean = True
                Dim value2 As String = ""
                flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("proc_type"))) = 1.0 And num = 1)
                If flag2 Then
                    value2 = "فاتورة شراء"
                    flag4 = True
                Else
                    flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("proc_type"))) = 1.0 And num = 2)
                    If flag2 Then
                        value2 = "فاتورة بيع"
                        flag4 = True
                    Else
                        flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("proc_type"))) = 2.0 And num = 1)
                        If flag2 Then
                            value2 = "فاتورة مرتد شراء"
                            flag4 = False
                        Else
                            flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("proc_type"))) = 2.0 And num = 2)
                            If flag2 Then
                                value2 = "فاتورة مرتد بيع"
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
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = value2
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("date"))).ToShortDateString()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("id"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num10)("currency_from")))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("val"))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("exchange_price"))))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum"))))
                    flag2 = flag4

                    If flag2 Then
                        num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                        num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("taxval")))
                        num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("tab3")))
                        flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("inv_type"), 2, False)
                        If flag2 Then
                            flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("cash_part"))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("network_part"))) <> 0.0)
                            If flag Then
                                Dim flag5 As Boolean = Operators.ConditionalCompareObjectNotEqual(Me._lastinvid, dataTable.Rows(num10)("proc_id"), False)
                                If flag5 Then
                                    Me._lastinvid = Conversions.ToInteger(dataTable.Rows(num10)("proc_id"))
                                    num3 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("cash_part")))
                                    num4 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("network_part")))
                                End If
                            Else
                                Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("pay_type"), 1, False)
                                If flag5 Then
                                    num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                                Else
                                    flag5 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("pay_type"), 2, False)
                                    If flag5 Then
                                        num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                                    End If
                                End If
                            End If
                        Else
                            num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                        End If
                    Else
                        num2 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                        num7 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("taxval")))
                        num6 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("tab3")))
                        Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("inv_type"), 2, False)
                        If flag5 Then
                            flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("cash_part"))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("network_part"))) <> 0.0)
                            If flag2 Then
                                flag = Operators.ConditionalCompareObjectNotEqual(Me._lastinvid, dataTable.Rows(num10)("proc_id"), False)
                                If flag Then
                                    Me._lastinvid = Conversions.ToInteger(dataTable.Rows(num10)("proc_id"))
                                    num3 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("cash_part")))
                                    num4 -= Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num10)("network_part")))
                                End If
                            Else
                                flag5 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("pay_type"), 1, False)
                                If flag5 Then
                                    num3 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                                Else
                                    flag5 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num10)("pay_type"), 2, False)
                                    If flag5 Then
                                        num4 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                                    End If
                                End If
                            End If
                        Else
                            num5 -= Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num10)("sum")))
                        End If
                    End If

                End If
                num10 += 1
            End While
            Me.txtSum.Text = "" + Conversions.ToString(Math.Round(num2, 2))
            Me.txtSumTab3.Text = "" + Conversions.ToString(Math.Round(num6, 2))
            Me.txtSumVAT.Text = "" + Conversions.ToString(Math.Round(num7, 2))
            Me.txtSumCash.Text = "" + Conversions.ToString(Math.Round(num3, 2))
            Me.txtSumNetwork.Text = "" + Conversions.ToString(Math.Round(num4, 2))
            Me.txtSumAgel.Text = "" + Conversions.ToString(Math.Round(num5, 2))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadEmps()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where IS_Deleted=0 order by id", Me.conn)
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
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.AddDays(1.0).ToShortDateString())
        Me.cmbProcType.SelectedIndex = 0
        Me.LoadEmps()
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = Not Form1.Button35.Enabled
            If flag Then
                Me.cmbProcType.SelectedIndex = 1
                Me.cmbProcType.Enabled = False
            End If
        Catch ex As Exception
        End Try
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
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
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
                        frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and proc_type=2 and is_buy=" + Conversions.ToString(value2) + " and id=", Me.dgvItems.Rows(e.RowIndex).Cells(2).Value)))
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
