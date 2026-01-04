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
Public Partial Class frmCustAccountGet
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private _IsPoNo As Boolean

    Public ClientID As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCustAccountGet_Load
        frmCustAccountGet.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._IsPoNo = False
        Me.ClientID = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCustAccountGet.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCustAccountGet.__ENCList.Count = frmCustAccountGet.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCustAccountGet.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCustAccountGet.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCustAccountGet.__ENCList(num) = frmCustAccountGet.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCustAccountGet.__ENCList.RemoveRange(num, frmCustAccountGet.__ENCList.Count - num)
                frmCustAccountGet.__ENCList.Capacity = frmCustAccountGet.__ENCList.Count
            End If
            frmCustAccountGet.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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

    Private Sub LoadAccounts()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter()
            Dim dataTable As DataTable = New DataTable()
            Dim text As String = "123"
            Dim text2 As String = "261"
            Dim flag As Boolean = MainClass.IsAccTreeNew
            If flag Then
                text = "110302"
                text2 = "210011"
            End If
            flag = Me.rdAll.Checked
            If flag Then
                sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Code,AName from Accounts_Index where Type=2 and (ParentCode=", text, " or parentcode=", text2, ")"}), Me.conn)
            Else
                flag = Me.rdAllClients.Checked
                If flag Then
                    sqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 and (ParentCode=" + text + ")", Me.conn)
                Else
                    flag = Me.rdAllSuppliers.Checked
                    If flag Then
                        sqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 and ( parentcode=" + text2 + ")", Me.conn)
                    End If
                End If
            End If
            dataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.cmbClients.DataSource = dataTable
            Me.cmbClients.DisplayMember = "AName"
            Me.cmbClients.ValueMember = "Code"
            Me.cmbClients.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmCustAccountGet_Load(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Me.dgvSrch.Columns("colBalance").DisplayIndex = 2
        Catch ex As Exception
        End Try
        Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadAccounts()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select is_pono from foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me._IsPoNo = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Try
            Dim checked As Boolean = Me.chkAll.Checked
            If checked Then
                Me.cmbClients.Enabled = False
            Else
                Me.cmbClients.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ShowAccount()
        Try
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Me.dgvSrch.Rows.Clear()
            Me.txtTotDept.Text = ""
            Me.txtTotCredit.Text = ""
            Me.txtBalance1.Text = ""
            Me.txtBalance2.Text = ""
            Dim text As String = ""
            Dim flag As Boolean = Not Me.chkAll.Checked
            Dim flag2 As Boolean
            If flag Then
                flag2 = (Me.cmbClients.SelectedValue Is Nothing)
                If flag2 Then
                    MessageBox.Show("اختر عميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbClients.Focus()
                    Return
                End If
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Restrictions_Sub.acc_no=", Me.cmbClients.SelectedValue)))
            End If
            Dim num3 As Integer = 1
            Try
                flag2 = Not Me.chkAll.Checked
                If flag2 Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select nature from accounts_index where Code=", Me.cmbClients.SelectedValue)), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
                End If
            Catch ex As Exception
            End Try
            Try
                flag2 = Me._IsPoNo
                If flag2 Then
                    Dim value As String = "123"
                    flag2 = MainClass.IsAccTreeNew
                    If flag2 Then
                        value = "110302"
                    End If
                    Me.dgvSrch.Columns("colpono").Visible = False
                    Dim flag3 As Boolean = False
                    flag2 = Me.rdAllClients.Checked
                    If flag2 Then
                        flag3 = True
                    End If
                    Try
                        flag2 = Not flag3
                        If flag2 Then
                            flag = (Me.cmbClients.SelectedValue IsNot Nothing And Not Me.chkAll.Checked And Me.cmbClients.SelectedValue.ToString().StartsWith(value))
                            If flag Then
                                flag3 = True
                            End If
                        End If
                    Catch ex2 As Exception
                    End Try
                    flag2 = flag3
                    If flag2 Then
                        Me.dgvSrch.Columns("colpono").Visible = True
                        Me.dgvSrch.Columns("colpono").DisplayIndex = 2
                    End If
                End If
            Catch ex3 As Exception
            End Try
            Dim text2 As String = "123"
            Dim text3 As String = "261"
            flag2 = MainClass.IsAccTreeNew
            If flag2 Then
                text2 = "110302"
                text3 = "210011"
            End If
            flag2 = Me.rdAll.Checked
            If flag2 Then
                text = String.Concat(New String() {text, " and (Accounts_Index.parentcode='", text2, "' or Accounts_Index.parentcode='", text3, "') "})
            Else
                flag2 = Me.rdAllClients.Checked
                If flag2 Then
                    text = text + " and Accounts_Index.parentcode='" + text2 + "' "
                Else
                    flag2 = Me.rdAllSuppliers.Checked
                    If flag2 Then
                        text = text + " and Accounts_Index.parentcode='" + text3 + "' "
                    End If
                End If
            End If
            Dim text4 As String = ""
            flag2 = (MainClass.BranchNo <> -1)
            If flag2 Then
                text4 = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
            End If
            flag2 = Me.chkOpen.Checked
            If flag2 Then
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + text4 + " Restrictions_Sub.acc_no=Accounts_Index.Code and Restrictions.type=11 and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))) <> 0.0)
                If flag2 Then
                    Me.dgvSrch.Rows.Add()
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))

                    num += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))

                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = ""
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = ""
                    Dim value2 As String = "رصيد افتتاحي"
                    flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag2 Then
                        value2 = "Open Processes"
                    End If
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = value2
                End If
            End If
            flag2 = Me.chkPrev.Checked
            If flag2 Then
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub,Accounts_Index where " + text4 + " Restrictions_Sub.acc_no=Accounts_Index.Code and Restrictions.type<>11 and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date<@date1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
                sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))) <> 0.0)
                If flag2 Then
                    Me.dgvSrch.Rows.Add()
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))

                    num += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                    num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))

                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = ""
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = ""
                    Dim value3 As String = "رصيد سابق"
                    flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag2 Then
                        value3 = "Previous Processes"
                    End If
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = value3
                    flag2 = (Me.dgvSrch.Rows.Count > 1)
                    If flag2 Then
                        flag = (num3 = 1)
                        If flag Then
                            ' The following expression was wrapped in a unchecked-expression
                            Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(0).Value)) + Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0))) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(1).Value)) - Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
                        Else
                            ' The following expression was wrapped in a unchecked-expression
                            Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(1).Value)) + Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(0).Value)) - Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                        End If
                    End If
                End If
            End If
            Dim text5 As String = " order by Restrictions.id "
            flag2 = Me.rdByDate.Checked
            If flag2 Then
                text5 = " order by Restrictions.date "
            End If
            Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Restrictions.id,Restrictions.date,Restrictions.type,Restrictions.doc_no,Restrictions.refno,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit,Restrictions_Sub.notes from Restrictions,Restrictions_Sub,Accounts_Index where ", text4, " Restrictions_Sub.acc_no=Accounts_Index.Code and Restrictions.type<>11 and Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<@date2 and Restrictions.id=Restrictions_Sub.res_id ", text, " group by Restrictions.id,Restrictions.date,Restrictions.type,Restrictions_Sub.notes,Restrictions_Sub.acc_no,Restrictions.doc_no,Restrictions.refno ", text5}), Me.conn)
            sqlDataAdapter4.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
            Dim dateTime As DateTime = Me.txtDateTo.Value.AddHours(24.0)
            sqlDataAdapter4.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime.ToShortDateString()
            Dim dataTable4 As DataTable = New DataTable()
            sqlDataAdapter4.Fill(dataTable4)
            Dim num4 As Integer = 0
            Dim num5 As Integer = dataTable4.Rows.Count - 1
            Dim num6 As Integer = num4
            While True
                Dim num7 As Integer = num6
                Dim num8 As Integer = num5
                If num7 > num8 Then
                    Exit While
                End If
                Me.dgvSrch.Rows.Add()
                flag2 = (num3 = 1)
                If flag2 Then
                    flag = (Me.dgvSrch.Rows.Count = 2)
                    If flag Then
                        ' The following expression was wrapped in a unchecked-expression
                        Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("dept"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("credit"))) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(0).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(1).Value))
                    Else
                        flag2 = (Me.dgvSrch.Rows.Count > 2)
                        If flag2 Then
                            ' The following expression was wrapped in a unchecked-expression
                            ' The following expression was wrapped in a checked-expression
                            Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("dept"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("credit"))) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 2).Cells("colBalance").Value))
                        End If
                    End If
                Else
                    flag2 = (Me.dgvSrch.Rows.Count = 2)
                    If flag2 Then
                        ' The following expression was wrapped in a unchecked-expression
                        Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("credit"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("dept"))) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(1).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(0).Cells(0).Value))
                    Else
                        flag2 = (Me.dgvSrch.Rows.Count > 2)
                        If flag2 Then
                            ' The following expression was wrapped in a unchecked-expression
                            ' The following expression was wrapped in a checked-expression
                            Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("credit"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("dept"))) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 2).Cells("colBalance").Value))
                        End If
                    End If
                End If
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("dept"))
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("credit"))
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("id"))
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("date"))).ToShortDateString()
                Try
                    flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable4.Rows(num6)("refno")), "", False)
                    If flag2 Then
                        Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("refno"))
                    Else
                        Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("doc_no"))
                    End If
                Catch ex4 As Exception
                End Try
                Try
                    flag2 = Conversions.ToBoolean(Operators.AndObject(Me._IsPoNo, Operators.OrObject(Operators.CompareObjectEqual(dataTable4.Rows(num6)("type"), 2, False), Operators.CompareObjectEqual(dataTable4.Rows(num6)("type"), 4, False))))
                    If flag2 Then
                        Dim value4 As Integer = 1
                        flag2 = Operators.ConditionalCompareObjectEqual(dataTable4.Rows(0)("type"), 4, False)
                        If flag2 Then
                            value4 = 2
                        End If
                        Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select pono from inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and proc_type=" + Conversions.ToString(value4) + " and is_buy=0 and id=", dataTable4.Rows(num6)("doc_no"))), Me.conn)
                        Dim dataTable5 As DataTable = New DataTable()
                        sqlDataAdapter5.Fill(dataTable5)
                        Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colpono").Value = Operators.ConcatenateObject("", dataTable5.Rows(0)(0))
                    End If
                Catch ex5 As Exception
                End Try
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("notes"))

                num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("dept")))
                num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("credit")))

                num6 += 1
            End While
            Me.txtTotDept.Text = "" + Conversions.ToString(num)
            Me.txtTotCredit.Text = "" + Conversions.ToString(num2)
            flag2 = (num > num2)
            If flag2 Then
                Me.txtBalance1.Text = "" + Conversions.ToString(Math.Round(num - num2, 3))
            Else
                flag2 = (num2 > num)
                If flag2 Then
                    Me.txtBalance2.Text = "" + Conversions.ToString(Math.Round(num2 - num, 3))
                Else
                    flag2 = (num = num2)
                    If flag2 Then
                        Me.txtBalance1.Text = "0"
                        Me.txtBalance2.Text = "0"
                    End If
                End If
            End If
        Catch ex6 As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.ShowAccount()
    End Sub

    Private Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
        Try
            Dim frmRestrictions As New frmRestrictions()
            frmRestrictions.Show()
            frmRestrictions.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Restrictions where id=", Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)))
            frmRestrictions.Activate()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = e.ColumnIndex = 6
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select doc_no,type from Restrictions where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=", Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)), Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 1, False), Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 2, False)))
                If flag Then
                    Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                    Dim frmSalePurch As frmSalePurch = New frmSalePurch()
                    frmSalePurch.cmbProcType.SelectedIndex = 0
                    frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
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
                    frmSalePurch.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and proc_type=1 and is_buy=" + Conversions.ToString(value) + " and id=", dataTable.Rows(0)("doc_no"))))
                    frmSalePurch.Activate()
                Else
                    flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 3, False), Operators.CompareObjectEqual(dataTable.Rows(0)("type"), 4, False)))
                    If flag Then
                        Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                        Dim frmSalePurch2 As frmSalePurch = New frmSalePurch()
                        frmSalePurch2.cmbProcType.SelectedIndex = 1
                        frmSalePurch2.cmbProcTypeSrch.SelectedIndex = 1
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
                        frmSalePurch2.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and proc_type=2 and is_buy=" + Conversions.ToString(value2) + " and id=", dataTable.Rows(0)("doc_no"))))
                        frmSalePurch2.Activate()
                    Else
                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 5, False)
                        If flag Then
                            Dim frmSandQ As frmSandQ = New frmSandQ()
                            frmSandQ.Show()
                            frmSandQ.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQ where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
                            frmSandQ.Activate()
                        Else
                            flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 6, False)
                            If flag Then
                                Dim frmSandD As frmSandD = New frmSandD()
                                frmSandD.Show()
                                frmSandD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandD where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
                                frmSandD.Activate()
                            Else
                                flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 7, False)
                                If flag Then
                                    Dim frmSandQD As frmSandQD = New frmSandQD()
                                    frmSandQD.Show()
                                    frmSandQD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQD where branch=" + Conversions.ToString(MainClass.BranchNo) + " and where IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
                                    frmSandQD.Activate()
                                Else
                                    flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 8, False)
                                    If flag Then
                                        Dim frmSandSD As frmSandSD = New frmSandSD()
                                        frmSandSD.Show()
                                        frmSandSD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandSD where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
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
        Dim flag As Boolean = Me.dgvSrch.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("dept")
            dataTable.Columns.Add("credit")
            dataTable.Columns.Add("no")
            dataTable.Columns.Add("date")
            dataTable.Columns.Add("DataColumn1")
            dataTable.Columns.Add("notes")
            dataTable.Columns.Add("DataColumn11")
            dataTable.Columns.Add("DataColumn12")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvSrch.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells("colBalance").Value), Operators.ConcatenateObject("", Me.dgvSrch.Rows(num3).Cells("colpono").Value)})
                num3 += 1
            End While
            Dim reportDocument As ReportDocument = New ReportDocument()
            flag = Me.dgvSrch.Columns("colpono").Visible
            If flag Then
                reportDocument = New rptAccountBalance2()
            Else
                reportDocument = New rptAccountBalance()
            End If
            reportDocument.SetDataSource(dataTable)
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbClients.Text
            End If
            Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("lblheader"), TextObject)
            textObject.Text = "كشف حساب عميل"
            Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("lbl"), TextObject)
            textObject2.Text = "العميل"
            Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtacc"), TextObject)
            textObject3.Text = text
            Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
            textObject4.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
            textObject5.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject6.Text = Me.GetEmpUserName(MainClass.EmpNo)
            Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
            textObject7.Text = Me.txtTotDept.Text
            Dim textObject8 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
            textObject8.Text = Me.txtTotCredit.Text
            Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
            textObject9.Text = Me.txtBalance1.Text
            Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum4"), TextObject)
            textObject10.Text = Me.txtBalance2.Text
            Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("note"), TextObject)
            textObject11.Text = "يعتبر هذا الكشف صحيحاً وموافقاً عليه من قبلكم مالم يصلنا أي اعتراض خطي خلال 15 يوم"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            reportDocument.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject12 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject13 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject14 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject14.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject15 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject15.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = reportDocument
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    reportDocument.PrintToPrinter(1, False, 1, currentPageNumber)
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

    Private Sub dgvSrch_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellContentClick
    End Sub

    Private Sub txtBalance2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBalance2.TextChanged
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
    End Sub

    Private Sub txtTotDept_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotDept.TextChanged
    End Sub

    Private Sub txtTotCredit_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotCredit.TextChanged
    End Sub

    Private Sub rdAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdAll.CheckedChanged
        Me.LoadAccounts()
    End Sub

    Private Sub rdAllClients_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdAllClients.CheckedChanged
        Me.LoadAccounts()
    End Sub

    Private Sub rdAllSuppliers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdAllSuppliers.CheckedChanged
        Me.LoadAccounts()
    End Sub

    Private Sub txtNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNo.TextChanged
        Try
            Dim value As Integer = 1
            Dim flag As Boolean = Me.rdAllSuppliers.Checked
            If flag Then
                value = 2
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Accounts_index.Code from Accounts_index,customers where Accounts_index.ANAME=customers.name and cust_no=" + Conversions.ToString(Conversion.Val(Me.txtNo.Text)) + " and customers.type=" + Conversions.ToString(value), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Me.cmbClients.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
        Try
            Dim frmSrchClient As frmSrchClient = New frmSrchClient()
            Dim flag As Boolean = Me.rdAllSuppliers.Checked
            If flag Then
                frmSrchClient._type = 2
            Else
                flag = Me.rdAllClients.Checked
                If flag Then
                    frmSrchClient._type = 1
                End If
            End If
            frmSrchClient.Form_Type = 4
            frmSrchClient.frm4 = Me
            frmSrchClient.ShowDialog()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select accounts_index.code from customers,accounts_index where customers.name=accounts_index.aname and customers.id=" + Conversions.ToString(Me.ClientID), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Me.cmbClients.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
