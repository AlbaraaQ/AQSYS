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
Imports AQSYS.AQSYS.rptt
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Public Partial Class frmCustLastPay
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Public ClientID As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCustLastPay_Load
        frmCustLastPay.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.ClientID = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCustLastPay.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCustLastPay.__ENCList.Count = frmCustLastPay.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCustLastPay.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCustLastPay.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCustLastPay.__ENCList(num) = frmCustLastPay.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCustLastPay.__ENCList.RemoveRange(num, frmCustLastPay.__ENCList.Count - num)
                frmCustLastPay.__ENCList.Capacity = frmCustLastPay.__ENCList.Count
            End If
            frmCustLastPay.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub frmCustLastPay_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.LoadClients()
    End Sub

    Private Sub ShowResult()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = "select id,name,tel,mobile from Customers where IS_Deleted=0"
            Dim flag As Boolean = Not Me.chkAll.Checked
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and id=", Me.cmbClients.SelectedValue)))
            End If
            text += " order by id"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text, Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.dgvItems.Rows.Clear()
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Dim num6 As Integer = -1
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select Code from Accounts_Index where Type=2 and AName='", dataTable.Rows(num3)("name")), "'")), Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    num6 = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                Dim text2 As String = ""
                text2 = text2 + " and Restrictions_Sub.acc_no=" + Conversions.ToString(num6)
                Dim text3 As String = ""
                flag = (MainClass.BranchNo <> -1)
                If flag Then
                    text3 = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
                End If
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select top 1 Restrictions.id,Restrictions.type,Restrictions.date,Restrictions_Sub.dept,Restrictions_Sub.credit from Restrictions,Restrictions_Sub where ", text3, " state=1 and Restrictions.id=Restrictions_Sub.res_id ", text2, " and IS_Deleted=0 order by id desc"}), Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                Dim value As String = ""
                flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 1.0)
                If flag Then
                    value = "فاتورة شراء"
                Else
                    flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 2.0)
                    If flag Then
                        value = "فاتورة بيع"
                    Else
                        flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 3.0)
                        If flag Then
                            value = "مرتد فاتورة شراء"
                        Else
                            flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 4.0)
                            If flag Then
                                value = "مرتد فاتورة بيع"
                            Else
                                flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 5.0)
                                If flag Then
                                    value = "قبض خارجي"
                                Else
                                    flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 6.0)
                                    If flag Then
                                        value = "صرف خارجي"
                                    Else
                                        flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 7.0)
                                        If flag Then
                                            value = "قبض داخلي"
                                        Else
                                            flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("type"))) = 8.0)
                                            If flag Then
                                                value = "صرف داخلي"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                flag = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("dept"))) <> 0.0)
                Dim num7 As Double
                If flag Then
                    num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("dept")))
                Else
                    num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("credit")))
                End If
                Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + text3 + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text2, Me.conn)
                Dim dataTable4 As DataTable = New DataTable()
                sqlDataAdapter4.Fill(dataTable4)
                Dim num8 As Double = 0.0
                Dim num9 As Double = 0.0
                flag = (dataTable4.Rows.Count > 0 And Operators.CompareString(dataTable4.Rows(0)(0).ToString(), "", False) <> 0)
                If flag Then
                    num8 = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)(0)))
                    num9 = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)(1)))
                End If
                Me.dgvItems.Rows.Add()
                Me.dgvItems.Rows(num3).Cells(0).Value = num6
                Me.dgvItems.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
                Me.dgvItems.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
                Me.dgvItems.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
                Me.dgvItems.Rows(num3).Cells(4).Value = num7
                Me.dgvItems.Rows(num3).Cells(5).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("date"))).ToShortDateString()
                Me.dgvItems.Rows(num3).Cells(6).Value = value
                flag = (num8 >= num9)

                If flag Then
                    Me.dgvItems.Rows(num3).Cells(7).Value = "" + Conversions.ToString(Math.Round(num8 - num9, 3))
                    Me.dgvItems.Rows(num3).Cells(8).Value = "مدين"
                Else
                    Me.dgvItems.Rows(num3).Cells(7).Value = "" + Conversions.ToString(Math.Round(num9 - num8, 3))
                    Me.dgvItems.Rows(num3).Cells(8).Value = "دائن"
                End If
                Me.dgvItems.Rows(num3).Cells(9).Value = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("id"))

                num3 += 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbClients.SelectedIndex = -1
        If flag Then
            MessageBox.Show("يجب اختيار العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = e.ColumnIndex = 10
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select doc_no,type from Restrictions where id=", Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)), Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 1, False), Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 2, False)))
                If flag Then
                    Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                    Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                    Dim value As Integer = 1
                    flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 1, False)
                    If flag Then
                        frmSalePurch.InvProc = 1
                    Else
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 2, False)
                        If flag Then
                            frmSalePurch.InvProc = 2
                            value = 0
                        End If
                    End If
                    frmSalePurch.Show()
                    frmSalePurch.WindowState = FormWindowState.Maximized
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", dataTable.Rows(0)("doc_no"))))
                    frmSalePurch.Activate()
                Else
                    flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 3, False), Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 4, False)))
                    If flag Then
                        Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                        Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
                        Dim value2 As Integer = 1
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 3, False)
                        If flag Then
                            frmSalePurch2.InvProc = 1
                        Else
                            flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 4, False)
                            If flag Then
                                frmSalePurch2.InvProc = 2
                                value2 = 0
                            End If
                        End If
                        frmSalePurch2.Show()
                        frmSalePurch2.WindowState = FormWindowState.Maximized
                        frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where proc_type=2 and is_buy=" + Conversions.ToString(value2) + " and id=", dataTable.Rows(0)("doc_no"))))
                        frmSalePurch2.Activate()
                    Else
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 5, False)
                        If flag Then
                            Dim frmSandQ As frmSandQ = New frmSandQ()
                            frmSandQ.Show()
                            frmSandQ.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQ where id=", dataTable.Rows(0)("doc_no"))))
                            frmSandQ.Activate()
                        Else
                            flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 6, False)
                            If flag Then
                                Dim frmSandD As frmSandD = New frmSandD()
                                frmSandD.Show()
                                frmSandD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandD where id=", dataTable.Rows(0)("doc_no"))))
                                frmSandD.Activate()
                            Else
                                flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 7, False)
                                If flag Then
                                    Dim frmSandQD As frmSandQD = New frmSandQD()
                                    frmSandQD.Show()
                                    frmSandQD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQD where id=", dataTable.Rows(0)("doc_no"))))
                                    frmSandQD.Activate()
                                Else
                                    flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 8, False)
                                    If flag Then
                                        Dim frmSandSD As frmSandSD = New frmSandSD()
                                        frmSandSD.Show()
                                        frmSandSD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandSD where id=", dataTable.Rows(0)("doc_no"))))
                                        frmSandSD.Activate()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
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
            dataTable.Columns.Add("tel")
            dataTable.Columns.Add("mobile")
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("date")
            dataTable.Columns.Add("doctype")
            dataTable.Columns.Add("balance")
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
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)})
                num3 += 1
            End While
            Dim rptCustLastPay As rptCustLastPay = New rptCustLastPay()
            rptCustLastPay.SetDataSource(dataTable)
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbClients.Text
            End If
            Dim textObject As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(1).ReportObjects("txtacc"), TextObject)
            textObject.Text = text
            Dim textObject2 As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject2.Text = Me.GetEmpUserName(MainClass.EmpNo)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptCustLastPay.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject3 As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject4 As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject5 As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject6 As TextObject = CType(rptCustLastPay.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptCustLastPay
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptCustLastPay.PrintToPrinter(1, False, 1, currentPageNumber)
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

    Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        Try
            'New frmSrchClient() With { .Form_Type = 5, .frm5 = Me }.ShowDialog()
            Using frm As New frmSrchClient()
                frm.Form_Type = 5
                frm.frm5 = Me
                frm.ShowDialog()
            End Using
            Me.cmbClients.SelectedValue = Me.ClientID
        Catch ex As Exception
        End Try
    End Sub
End Class
