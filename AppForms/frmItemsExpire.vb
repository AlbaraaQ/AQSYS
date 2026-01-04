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
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.AQSYS.rptt
Public Partial Class frmItemsExpire
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmItemsExpire.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmItemsExpire.__ENCList.Count = frmItemsExpire.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmItemsExpire.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmItemsExpire.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmItemsExpire.__ENCList(num) = frmItemsExpire.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmItemsExpire.__ENCList.RemoveRange(num, frmItemsExpire.__ENCList.Count - num)
                frmItemsExpire.__ENCList.Capacity = frmItemsExpire.__ENCList.Count
            End If
            frmItemsExpire.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub frmSafeGrd_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmSafeGrd.Load
    End Sub

    Public Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("currency")
            dataTable.Columns.Add("sum")
            dataTable.Columns.Add("type")
            Dim text As String = ""
            Me.dgvItems.Rows.Clear()
            Dim str As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + text + " inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable2.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1})
                num3 += 1
            End While
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + text + " inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num6 As Integer = 0
            Dim num7 As Integer = dataTable2.Rows.Count - 1
            Dim num8 As Integer = num6
            While True
                Dim num9 As Integer = num8
                Dim num5 As Integer = num7
                If num9 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 1})
                num8 += 1
            End While
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + text + " inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num10 As Integer = 0
            Dim num11 As Integer = dataTable2.Rows.Count - 1
            Dim num12 As Integer = num10
            While True
                Dim num13 As Integer = num12
                Dim num5 As Integer = num11
                If num13 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 2})
                num12 += 1
            End While
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + text + " inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num14 As Integer = 0
            Dim num15 As Integer = dataTable2.Rows.Count - 1
            Dim num16 As Integer = num14
            While True
                Dim num17 As Integer = num16
                Dim num5 As Integer = num15
                If num17 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 2})
                num16 += 1
            End While
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + str + text + " inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num18 As Integer = 0
            Dim num19 As Integer = dataTable2.Rows.Count - 1
            Dim num20 As Integer = num18
            While True
                Dim num21 As Integer = num20
                Dim num5 As Integer = num19
                If num21 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 1})
                num20 += 1
            End While
            Dim num22 As Integer = dataTable.Rows.Count - 1
            Dim num23 As Integer = 0
            Dim num24 As Integer = num22
            Dim num25 As Integer = num23
            While True
                Dim num26 As Integer = num25
                Dim num5 As Integer = num24
                If num26 > num5 Then
                    Exit While
                End If
                flag = (num25 <= num22)
                If flag Then
                    Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num25)(2), 2, False)
                    If flag2 Then
                        ' The following expression was wrapped in a unchecked-expression
                        dataTable.Rows(num25)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(1)))
                    End If
                End If
                Dim num27 As Integer = num25 + 1
                Dim num28 As Integer = num22
                Dim num29 As Integer = num27
                While True
                    Dim num30 As Integer = num29
                    num5 = num28
                    If num30 > num5 Then
                        Exit While
                    End If
                    Dim flag2 As Boolean = num29 <= num22
                    If flag2 Then
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num25)(0), dataTable.Rows(num29)(0), False)
                        If flag Then
                            Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num29)(2), 2, False)

                            If flag3 Then
                                dataTable.Rows(num29)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1)))
                            End If
                            dataTable.Rows(num25)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num25)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num29)(1)))
                            dataTable.Rows.RemoveAt(num29)

                            num29 -= 1
                            num22 -= 1
                        End If
                    End If
                    num29 += 1
                End While
                num25 += 1
            End While
            Dim num31 As Double = 0.0
            Dim num32 As Integer = 0
            Dim num33 As Integer = dataTable.Rows.Count - 1
            Dim num34 As Integer = num32
            While True
                Dim num35 As Integer = num34
                Dim num5 As Integer = num33
                If num35 > num5 Then
                    Exit While
                End If
                Dim num36 As Double = 0.0
                Dim num37 As Integer = 0
                sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num34)(0)), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter.Fill(dataTable2)
                Dim flag3 As Boolean = dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0
                If flag3 Then

                    num36 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))

                    num37 = CInt(Math.Round(CDbl(num37) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + str + " currency_from=", dataTable.Rows(num34)(0)), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter.Fill(dataTable2)
                flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
                If flag3 Then

                    num36 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))

                    num37 = CInt(Math.Round(CDbl(num37) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                Try
                    flag3 = (num37 <> 0)
                    Dim num38 As Double
                    If flag3 Then
                        num38 = num36 / CDbl(num37)
                        num38 = Math.Floor(num38 * 100000000.0)
                        num38 /= 100000000.0
                    Else
                        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from currencies where id=", dataTable.Rows(num34)(0))), Me.conn)
                        Dim dataTable3 As DataTable = New DataTable()
                        sqlDataAdapter2.Fill(dataTable3)
                        num38 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                    End If
                    Dim num39 As Integer = Conversions.ToInteger(dataTable.Rows(num34)(1))
                    Dim flag4 As Boolean = True
                    sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select val,date from inv,inv_sub where " + str + text + " currency_from=", dataTable.Rows(num34)(0)), " and expire_date>=@date and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 order by date desc")), Me.conn)
                    sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
                    dataTable2 = New DataTable()
                    sqlDataAdapter.Fill(dataTable2)
                    Dim num40 As Integer = 0
                    Dim num41 As Integer = dataTable2.Rows.Count - 1
                    Dim num42 As Integer = num40
                    While True
                        Dim num43 As Integer = num42
                        num5 = num41
                        If num43 > num5 Then
                            GoTo IL_A5A
                        End If
                        flag3 = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num42)("val"))) > num39)
                        If flag3 Then
                            Exit While
                        End If
                        num39 -= Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num42)("val")))
                        num42 += 1
                    End While
                    flag4 = False
IL_A5A:
                    flag3 = (flag4 And num39 <> 0)
                    If flag3 Then
                        Me.dgvItems.Rows.Add()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num34)(0))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num34)(0)))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = num39
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = num38
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = Math.Round(num38 * CDbl(num39), 2)

                        num31 += Math.Round(num38 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num34)(1))), 2)

                    End If
                Catch ex As Exception
                End Try
                num34 += 1
            End While
            Me.txtSum.Text = "" + Conversions.ToString(num31)
        Catch ex2 As Exception
        End Try
    End Sub

    Private Function GetCurrencyName(Currency_id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol from Currencies where id=" + Conversions.ToString(Currency_id), Me.conn)
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

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.CalcStock()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
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
            dataTable.Columns.Add("val")
            dataTable.Columns.Add("avg")
            dataTable.Columns.Add("total")
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
            Dim rptSafeGrd As rptSafeGrd = New rptSafeGrd()
            rptSafeGrd.SetDataSource(dataTable)
            Dim text As String = "الكل"
            Dim textObject As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
            textObject.Text = "الأصناف التي ستنتهي صلاحيتها قبل " + Me.txtDate.Value.ToString("dd/MM/yyyy")
            Dim textObject2 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(1).ReportObjects("txtSafe"), TextObject)
            textObject2.Text = text
            Dim textObject3 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject3.Text = Me.GetEmpUserName(MainClass.EmpNo)
            Dim textObject4 As TextObject = CType(rptSafeGrd.ReportDefinition.Sections(4).ReportObjects("txtsum"), TextObject)
            textObject4.Text = Me.txtSum.Text
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptSafeGrd.Subreports("rptHeader").SetDataSource(dataTable2)
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptSafeGrd
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptSafeGrd.PrintToPrinter(1, False, 1, currentPageNumber)
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

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmSafeGrd_Load
        frmItemsExpire.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
        If flag Then
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar")
        Else
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-us")
        End If
        Me.InitializeComponent()
    End Sub
End Class
