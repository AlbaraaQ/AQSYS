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
Public Partial Class frmCurrenciesBalances
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCurrenciesBalances_Load
        frmCurrenciesBalances.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCurrenciesBalances.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCurrenciesBalances.__ENCList.Count = frmCurrenciesBalances.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCurrenciesBalances.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCurrenciesBalances.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCurrenciesBalances.__ENCList(num) = frmCurrenciesBalances.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCurrenciesBalances.__ENCList.RemoveRange(num, frmCurrenciesBalances.__ENCList.Count - num)
                frmCurrenciesBalances.__ENCList.Capacity = frmCurrenciesBalances.__ENCList.Count
            End If
            frmCurrenciesBalances.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) ' Handles ListView1.SelectedIndexChanged
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

    Public Sub CalcStock(Safe As Integer)
        ' The following expression was wrapped in a checked-statement
        Try
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("currency")
            dataTable.Columns.Add("sum")
            dataTable.Columns.Add("type")
            Dim str As String = " inv.safe=" + Conversions.ToString(Safe) + " and "
            Dim text As String = ""
            Dim flag As Boolean = MainClass.BranchNo <> -1
            If flag Then
                text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + text + str + " inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
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
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + text + str + " inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
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
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + text + str + " inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
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
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + text + str + " inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
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
            sqlDataAdapter = New SqlDataAdapter("select currency_from,sum(val) from inv,inv_sub where " + text + str + " inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from", Me.conn)
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
            sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where ", text, " SafesTransfer.safe_to=", Conversions.ToString(Safe), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency"}), Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num22 As Integer = 0
            Dim num23 As Integer = dataTable2.Rows.Count - 1
            Dim num24 As Integer = num22
            While True
                Dim num25 As Integer = num24
                Dim num5 As Integer = num23
                If num25 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 1})
                num24 += 1
            End While
            sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where ", text, " SafesTransfer.safe_from=", Conversions.ToString(Safe), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency"}), Me.conn)
            dataTable2 = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim num26 As Integer = 0
            Dim num27 As Integer = dataTable2.Rows.Count - 1
            Dim num28 As Integer = num26
            While True
                Dim num29 As Integer = num28
                Dim num5 As Integer = num27
                If num29 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num28)(0)), Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num28)(1))), 2})
                num28 += 1
            End While
            Dim num30 As Integer = dataTable.Rows.Count - 1
            Dim num31 As Integer = 0
            Dim num32 As Integer = num30
            Dim num33 As Integer = num31
            While True
                Dim num34 As Integer = num33
                Dim num5 As Integer = num32
                If num34 > num5 Then
                    Exit While
                End If
                flag = (num33 <= num30)
                If flag Then
                    Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num33)(2), 2, False)
                    If flag2 Then
                        ' The following expression was wrapped in a unchecked-expression
                        dataTable.Rows(num33)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1)))
                    End If
                End If
                Dim num35 As Integer = num33 + 1
                Dim num36 As Integer = num30
                Dim num37 As Integer = num35
                While True
                    Dim num38 As Integer = num37
                    num5 = num36
                    If num38 > num5 Then
                        Exit While
                    End If
                    Dim flag2 As Boolean = num37 <= num30
                    If flag2 Then
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num33)(0), dataTable.Rows(num37)(0), False)
                        If flag Then
                            Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num37)(2), 2, False)

                            If flag3 Then
                                dataTable.Rows(num37)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
                            End If
                            dataTable.Rows(num33)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
                            dataTable.Rows.RemoveAt(num37)

                            num37 -= 1
                            num30 -= 1
                        End If
                    End If
                    num37 += 1
                End While
                num33 += 1
            End While
            Me.dgvItems.Rows.Clear()
            Dim num39 As Integer = 0
            Dim num40 As Integer = dataTable.Rows.Count - 1
            Dim num41 As Integer = num39
            While True
                Dim num42 As Integer = num41
                Dim num5 As Integer = num40
                If num42 > num5 Then
                    Exit While
                End If
                Dim num43 As Double = 0.0
                Dim num44 As Integer = 0
                sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + text + " currency_from=", dataTable.Rows(num41)(0)), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter.Fill(dataTable2)
                Dim flag3 As Boolean = dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0
                If flag3 Then

                    num43 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))

                    num44 = CInt(Math.Round(CDbl(num44) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + text + " currency_from=", dataTable.Rows(num41)(0)), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                dataTable2 = New DataTable()
                sqlDataAdapter.Fill(dataTable2)
                flag3 = (dataTable2.Rows.Count > 0 And Operators.CompareString(dataTable2.Rows(0)(1).ToString(), "", False) <> 0)
                If flag3 Then

                    num43 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1)))

                    num44 = CInt(Math.Round(CDbl(num44) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                End If
                Try
                    Dim num45 As Double = num43 / CDbl(num44)
                    num45 = Math.Floor(num45 * 100000000.0)
                    num45 /= 100000000.0
                    Me.dgvItems.Rows.Add()
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = Me.GetCurrencyName(Conversions.ToInteger(dataTable.Rows(num41)(0)))
                    Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num41)(1))
                Catch ex As Exception
                End Try
                num41 += 1
            End While
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub frmCurrenciesBalances_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmCurrenciesBalances.Load
    End Sub
End Class
