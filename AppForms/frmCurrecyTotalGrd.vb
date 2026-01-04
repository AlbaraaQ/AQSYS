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
Public Partial Class frmCurrecyTotalGrd
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private _Finished As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCurrecyTotalGrd_Load
        frmCurrecyTotalGrd.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._Finished = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCurrecyTotalGrd.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCurrecyTotalGrd.__ENCList.Count = frmCurrecyTotalGrd.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCurrecyTotalGrd.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCurrecyTotalGrd.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCurrecyTotalGrd.__ENCList(num) = frmCurrecyTotalGrd.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCurrecyTotalGrd.__ENCList.RemoveRange(num, frmCurrecyTotalGrd.__ENCList.Count - num)
                frmCurrecyTotalGrd.__ENCList.Capacity = frmCurrecyTotalGrd.__ENCList.Count
            End If
            frmCurrecyTotalGrd.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

    Public Sub LoadCurrencies()
        Dim text As String = ""
        Dim flag As Boolean = Me.chkType1.Checked
        If flag Then
            text += " (type=1  or type is null "
        End If
        flag = Me.chkType2.Checked
        Dim flag2 As Boolean
        If flag Then
            flag2 = (Operators.CompareString(text, "", False) <> 0)
            If flag2 Then
                text += " or type=2 "
            Else
                text += " (type=2 "
            End If
        End If
        flag2 = Me.chkType3.Checked
        If flag2 Then
            flag = (Operators.CompareString(text, "", False) <> 0)
            If flag Then
                text += " or type=3 "
            Else
                text += " (type=3 "
            End If
        End If
        flag2 = (Operators.CompareString(text, "", False) <> 0)
        If flag2 Then
            text += ") and "
        End If
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol from Currencies where " + text + " IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCurrency.DataSource = dataTable
        Me.cmbCurrency.DisplayMember = "symbol"
        Me.cmbCurrency.ValueMember = "id"
        Me.cmbCurrency.SelectedIndex = -1
    End Sub

    Private Sub frmCurrecyTotalGrd_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmCurrecyTotalGrd.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.LoadCurrencies()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select actv_manfc from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Try
                    Dim flag2 As Boolean = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_manfc")))
                    If flag2 Then
                        Me.pnlItemType.Visible = False
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub txtCurrencyNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrencyNo.TextChanged
        Try
            Me.cmbCurrency.SelectedValue = Me.txtCurrencyNo.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
        Try
            Me.txtCurrencyNo.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.cmbCurrency.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCurrencyNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCurrencyNo.KeyPress
        MainClass.ISInteger(e)
    End Sub

    Private Sub CalcStock()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("currency")
            dataTable.Columns.Add("sum")
            dataTable.Columns.Add("type")
            dataTable.Columns.Add("invtype")
            Dim text As String = ""
            Dim flag As Boolean = Me.chkType1.Checked
            If flag Then
                text += " (type=1 or type is null "
            End If
            flag = Me.chkType2.Checked
            Dim flag2 As Boolean
            If flag Then
                flag2 = (Operators.CompareString(text, "", False) <> 0)
                If flag2 Then
                    text += " or type=2 "
                Else
                    text += " (type=2 "
                End If
            End If
            flag2 = Me.chkType3.Checked
            If flag2 Then
                flag = (Operators.CompareString(text, "", False) <> 0)
                If flag Then
                    text += " or type=3 "
                Else
                    text += " (type=3 "
                End If
            End If
            flag2 = (Operators.CompareString(text, "", False) <> 0)
            If flag2 Then
                text += ") and "
            End If
            Dim text2 As String = "select id,symbol,type from Currencies where " + text + " IS_Deleted=0"
            flag2 = Not Me.chkAll.Checked
            If flag2 Then
                text2 = text2 + " and id=" + Me.txtCurrencyNo.Text
            End If
            text2 += " order by id"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(text2, Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            Dim text3 As String = ""
            flag2 = (MainClass.BranchNo <> -1)
            If flag2 Then
                text3 = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
            End If
            Me.dgvItems.Rows.Clear()
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Dim num3 As Double = 0.0
            Dim num4 As Double = 0.0
            Dim num5 As Double = 0.0
            Dim num6 As Double = 0.0
            Dim num7 As Double = 0.0
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = dataTable2.Rows.Count
            Dim num8 As Integer = 0
            Dim num9 As Integer = dataTable2.Rows.Count - 1
            Dim num10 As Integer = num8
            While True
                Dim num11 As Integer = num10
                Dim num12 As Integer = num9
                If num11 > num12 Then
                    Exit While
                End If
                Dim num13 As Double = 0.0
                Dim num14 As Double = 0.0
                Dim num15 As Double = 0.0
                Dim num16 As Double = 0.0
                Dim num17 As Double = 0.0
                Dim num18 As Double = 0.0
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text3 + " Inv_Sub.currency_from=", dataTable2.Rows(num10)("id")), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
                If flag2 Then
                    num13 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text3 + " Inv_Sub.currency_from=", dataTable2.Rows(num10)("id")), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
                If flag2 Then
                    num14 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text3 + " Inv_Sub.currency_from=", dataTable2.Rows(num10)("id")), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
                If flag2 Then
                    num15 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text3 + " Inv_Sub.currency_from=", dataTable2.Rows(num10)("id")), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
                If flag2 Then
                    num16 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                End If
                sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val) from inv,inv_sub where " + text3 + " Inv_Sub.currency_from=", dataTable2.Rows(num10)("id")), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0")), Me.conn)
                dataTable3 = New DataTable()
                sqlDataAdapter2.Fill(dataTable3)
                flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
                If flag2 Then
                    num17 = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                End If
                Dim num19 As Integer = 2
                flag2 = (num19 = 1)
                If flag2 Then
                    sqlDataAdapter2 = New SqlDataAdapter(String.Concat(New String() {"select inv_sub.currency_from,sum(Inv_Sub.val) as val,item_comp.mat_quantot  from inv,inv_sub,item_comp where ", text3, " is_buy=0 and inv.proc_type=1 and  inv.proc_id=inv_sub.proc_id and item_comp.item_id=inv_sub.currency_from and IS_Deleted=0  and item_comp.mat_id=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num10)("id"))), " group by inv_sub.currency_from,item_comp.mat_quantot"}), Me.conn)
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    Dim num20 As Integer = 0
                    Dim num21 As Integer = dataTable3.Rows.Count - 1
                    Dim num22 As Integer = num20
                    While True
                        Dim num23 As Integer = num22
                        num12 = num21
                        If num23 > num12 Then
                            Exit While
                        End If

                        num18 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num22)("val"))) * Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num22)("mat_quantot")))

                        num22 += 1
                    End While
                Else
                    sqlDataAdapter2 = New SqlDataAdapter(String.Concat(New String() {"select inv_sub.currency_from,sum(Inv_Sub.val) as val,item_comp.mat_quantot  from inv,inv_sub,item_comp where ", text3, " is_manfc=1 and inv.proc_type=3 and  inv.proc_id=inv_sub.proc_id and item_comp.item_id=inv_sub.currency_from and IS_Deleted=0  and item_comp.mat_id=", Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num10)("id"))), " group by inv_sub.currency_from,item_comp.mat_quantot"}), Me.conn)
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    Dim num24 As Integer = 0
                    Dim num25 As Integer = dataTable3.Rows.Count - 1
                    Dim num26 As Integer = num24
                    While True
                        Dim num27 As Integer = num26
                        num12 = num25
                        If num27 > num12 Then
                            Exit While
                        End If

                        num18 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num26)("val"))) * Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(num26)("mat_quantot")))

                        num26 += 1
                    End While
                End If
                Dim progressBar As ProgressBar

                Dim num28 As Double = num13 + num14 - num15 - num16 + num17 - num18
                flag2 = (num28 <> 0.0)
                If flag2 Then
                    Dim num29 As Double = 0.0
                    Dim num30 As Integer = 0
                    Dim num31 As Double = 0.0
                    sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + text3 + " currency_from=", dataTable2.Rows(num10)(0)), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
                    If flag2 Then
                        num29 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
                        num30 = CInt(Math.Round(CDbl(num30) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
                    End If
                    sqlDataAdapter2 = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select sum(val),sum(val1*exchange_price) from inv,inv_sub where " + text3 + " currency_from=", dataTable2.Rows(num10)(0)), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0")), Me.conn)
                    dataTable3 = New DataTable()
                    sqlDataAdapter2.Fill(dataTable3)
                    flag2 = (dataTable3.Rows.Count > 0 And Operators.CompareString(dataTable3.Rows(0)(1).ToString(), "", False) <> 0)
                    If flag2 Then
                        num29 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(1)))
                        num30 = CInt(Math.Round(CDbl(num30) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))))
                    End If
                    Try
                        flag2 = (num30 <> 0)
                        If flag2 Then
                            num31 = num29 / CDbl(num30)
                            num31 = Math.Floor(num31 * 100000000.0)
                            num31 /= 100000000.0
                        Else
                            Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from Currencies where id=", dataTable2.Rows(num10)(0))), Me.conn)
                            Dim dataTable4 As DataTable = New DataTable()
                            sqlDataAdapter3.Fill(dataTable4)
                            flag2 = (dataTable4.Rows.Count > 0)
                            If flag2 Then
                                num31 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
                            End If
                        End If
                        Me.dgvItems.Rows.Add()
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num10)(0))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(1).Value = Operators.ConcatenateObject("", dataTable2.Rows(num10)(1))
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(2).Value = Math.Round(num31, 2)
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(3).Value = Math.Round(num31 * num28, 2)
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Value = num13
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(5).Value = num14
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(6).Value = num15
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Value = num16 + num18
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(8).Value = num17
                        Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(9).Value = num28
                        num += num28
                        num2 += Math.Round(num31 * num28, 2)
                        num3 += num13
                        num4 += num14
                        num5 += num15
                        num6 += num16
                        num7 += num17
                    Catch ex As Exception
                    End Try
                End If
                progressBar = Me.ProgressBar1

                progressBar.Value += 1
                num10 += 1
            End While
            Me.txtSumBalance.Text = Conversions.ToString(num)
            Me.txtSumCost.Text = Conversions.ToString(num2)
            Me.txtSumOpen.Text = Conversions.ToString(num3)
            Me.txtSumPurch.Text = Conversions.ToString(num4)
            Me.txtSumRetPurch.Text = Conversions.ToString(num5)
            Me.txtSumSales.Text = Conversions.ToString(num6)
            Me.txtSumRetSales.Text = Conversions.ToString(num7)
        Catch ex2 As Exception
        Finally
            Me._Finished = True
        End Try
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

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbCurrency.SelectedIndex = -1
        If flag Then
            MessageBox.Show("يجب اختيار الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbCurrency.Focus()
        Else
            Me.dgvItems.Rows.Clear()
            Me.dgvItems.ScrollBars = ScrollBars.None
            'Dim thread As Thread = AddressOf Me.CalcStock
            Dim thread As New Thread(AddressOf Me.CalcStock)
            thread.Start()
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Dim checked As Boolean = Me.chkAll.Checked
        If checked Then
            Me.cmbCurrency.Enabled = False
            Me.txtCurrencyNo.Enabled = False
        Else
            Me.cmbCurrency.Enabled = True
            Me.txtCurrencyNo.Enabled = True
        End If
    End Sub

    Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
    End Sub

    Private Sub Label5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub chkType1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkType1.CheckedChanged
        Try
            Me.LoadCurrencies()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Dim finished As Boolean = Me._Finished
        If finished Then
            Me._Finished = False
            Me.dgvItems.ScrollBars = ScrollBars.Both
        End If
    End Sub
End Class
