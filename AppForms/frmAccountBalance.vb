Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.[Shared]
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
Partial Public Class frmAccountBalance
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Private _IsPoNo As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmAccountBalance_Load
        frmAccountBalance.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me._IsPoNo = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmAccountBalance.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmAccountBalance.__ENCList.Count = frmAccountBalance.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmAccountBalance.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmAccountBalance.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmAccountBalance.__ENCList(num) = frmAccountBalance.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmAccountBalance.__ENCList.RemoveRange(num, frmAccountBalance.__ENCList.Count - num)
                frmAccountBalance.__ENCList.Capacity = frmAccountBalance.__ENCList.Count
            End If
            frmAccountBalance.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCode.KeyPress
        MainClass.ISInteger(e)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
    End Sub

    Private Sub LoadAccounts()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 ", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.cmbAccounts.DataSource = dataTable
            Me.cmbAccounts.DisplayMember = "AName"
            Me.cmbAccounts.ValueMember = "Code"
            Me.cmbAccounts.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadCenters()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from costcenter order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCostCenter.DataSource = dataTable
        Me.cmbCostCenter.DisplayMember = "name"
        Me.cmbCostCenter.ValueMember = "id"
        Me.cmbCostCenter.SelectedIndex = -1
    End Sub

    Public Sub LoadBranches()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbBranches.DataSource = dataTable
        Me.cmbBranches.DisplayMember = "name"
        Me.cmbBranches.ValueMember = "id"
        Me.cmbBranches.SelectedIndex = -1
        Try
            Me.cmbBranches.SelectedValue = MainClass.BranchNo
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmAccountBalance_Load(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Me.dgvSrch.Columns("colBalance").DisplayIndex = 2
        Catch ex As Exception
        End Try
        Try
            Dim hide_costcenter As Boolean = MainClass.hide_costcenter
            If hide_costcenter Then
                Me.lblCostCenter.Visible = False
                Me.cmbCostCenter.Visible = False
                Me.chkAllCenter.Visible = False
            End If
        Catch ex2 As Exception
        End Try
        Try
            Me.txtDateFrom.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
            Me.txtDateTo.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Catch ex3 As Exception
        End Try
        Me.LoadAccounts()
        Me.LoadCenters()
        Me.LoadBranches()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select is_pono from foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me._IsPoNo = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Catch ex4 As Exception
        End Try
    End Sub

    Private Sub cmbAccounts_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccounts.SelectedIndexChanged
        Try
            Me.txtCode.Text = Conversions.ToString(Me.cmbAccounts.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Try
            Dim checked As Boolean = Me.chkAll.Checked
            If checked Then
                Me.txtCode.Enabled = False
                Me.cmbAccounts.Enabled = False
            Else
                Me.txtCode.Enabled = True
                Me.cmbAccounts.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCode.TextChanged
        Try
            Me.cmbAccounts.SelectedValue = Me.txtCode.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Public Sub ShowAccount()
        ' The following expression was wrapped in a checked-statement
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
                flag2 = (Me.cmbAccounts.SelectedValue Is Nothing)
                If flag2 Then
                    MessageBox.Show("اختر حساب", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbAccounts.Focus()
                    Return
                End If
                text = text + " and Restrictions_Sub.acc_no=" + Me.txtCode.Text
            End If
            Try
                flag2 = Me._IsPoNo
                If flag2 Then
                    Me.dgvSrch.Columns("colpono").Visible = False
                    flag2 = (Me.cmbAccounts.SelectedValue IsNot Nothing And Not Me.chkAll.Checked)
                    If flag2 Then
                        Dim value As String = "123"
                        flag2 = MainClass.IsAccTreeNew
                        If flag2 Then
                            value = "110302"
                        End If
                        flag2 = Me.txtCode.Text.StartsWith(value)
                        If flag2 Then
                            Me.dgvSrch.Columns("colpono").Visible = True
                            Me.dgvSrch.Columns("colpono").DisplayIndex = 2
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
            Dim text2 As String = ""
            flag2 = (MainClass.BranchNo <> -1 And Not Me.chkAllBranches.Checked And Me.cmbBranches.SelectedValue IsNot Nothing)
            If flag2 Then
                text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Restrictions.branch=", Me.cmbBranches.SelectedValue), " and Restrictions_Sub.branch="), Me.cmbBranches.SelectedValue), " and "))
            End If
            Try
                flag2 = Conversions.ToBoolean(Operators.AndObject(Not Me.chkAllBranches.Checked, Operators.CompareObjectEqual(Me.cmbBranches.SelectedValue, MainClass.BranchNo, False)))
                If flag2 Then
                    Me.dgvSrch.Columns("colView").Visible = True
                Else
                    Me.dgvSrch.Columns("colView").Visible = False
                End If
            Catch ex2 As Exception
            End Try
            Dim num3 As Integer = 1
            Try
                flag2 = Not Me.chkAll.Checked
                If flag2 Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select nature from accounts_index where Code=", Me.cmbAccounts.SelectedValue)), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    num3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
                End If
            Catch ex3 As Exception
            End Try
            Dim text3 As String = ""
            flag2 = (Not Me.chkAllCenter.Checked And Me.cmbCostCenter.SelectedValue IsNot Nothing)
            If flag2 Then
                Dim text4 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("default_center = ", Me.cmbCostCenter.SelectedValue), " and "))
                text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("center = ", Me.cmbCostCenter.SelectedValue), " and "))
            End If
            flag2 = Me.chkOpen.Checked
            If flag2 Then
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + text2 + " Restrictions.IS_Deleted=0 and Restrictions.type=11 and Restrictions.state=1 and Restrictions.branch=Restrictions_Sub.branch and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
                sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1))) <> 0.0)
                If flag2 Then
                    Me.dgvSrch.Rows.Add()
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
                    Dim value2 As String

                    num += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
                    num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
                    value2 = "رصيد افتتاحي"
                    flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag2 Then
                        value2 = "open Processes"
                    End If

                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = value2
                End If
            End If
            flag2 = Me.chkPrev.Checked
            If flag2 Then
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where ", text2, text3, " Restrictions.IS_Deleted=0 and Restrictions.type<>11 and Restrictions.state=1 and Restrictions.date<@date1 and Restrictions.branch=Restrictions_Sub.branch and Restrictions.id=Restrictions_Sub.res_id ", text}), Me.conn)
                sqlDataAdapter3.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0))) <> 0.0 Or Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1))) <> 0.0)
                If flag2 Then
                    Me.dgvSrch.Rows.Add()
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
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
                    Dim value3 As String

                    num += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
                    num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)(1)))
                    value3 = "رصيد سابق"
                    flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag2 Then
                        value3 = "Previous Processes"
                    End If

                    Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(5).Value = value3
                End If
            End If
            Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Restrictions.id,Restrictions.date,Restrictions.type,Restrictions.doc_no,Restrictions.refno,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit,Restrictions_Sub.notes from Restrictions,Restrictions_Sub where ", text2, " Restrictions.IS_Deleted=0 and Restrictions.type<>11 and Restrictions.state=1 and ", text3, " Restrictions.date>=@date1 and Restrictions.date<@date2 and Restrictions.branch=Restrictions_Sub.branch and Restrictions.id=Restrictions_Sub.res_id ", text, " group by Restrictions.id,Restrictions.date,Restrictions.type,Restrictions_Sub.notes,Restrictions_Sub.acc_no,Restrictions.doc_no,Restrictions.refno"}), Me.conn)
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
                            Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells("colBalance").Value = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("credit"))) - Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(num6)("dept"))) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 2).Cells(2).Value))
                        End If
                    End If
                End If
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(0).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("dept"))))
                Me.dgvSrch.Rows(Me.dgvSrch.Rows.Count - 1).Cells(1).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(num6)("credit"))))
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
            Me.txtTotDept.Text = String.Format("{0:0.#,##.##}", num)
            Me.txtTotCredit.Text = String.Format("{0:0.#,##.##}", num2)
            flag2 = (num > num2)

            If flag2 Then
                Me.txtBalance1.Text = String.Format("{0:0.#,##.##}", Math.Round(num - num2, 3))
            Else
                flag2 = (num2 > num)
                If flag2 Then
                    Me.txtBalance2.Text = String.Format("{0:0.#,##.##}", Math.Round(num2 - num, 3))
                Else
                    flag2 = (num = num2)
                    If flag2 Then
                        Me.txtBalance1.Text = "0"
                        Me.txtBalance2.Text = "0"
                    End If
                End If
            End If
            flag2 = Me.rdDebt.Checked

            If flag2 Then
                Me.dgvSrch.Columns(0).Visible = True
                Me.dgvSrch.Columns(1).Visible = False
                Me.txtTotDept.Visible = True
                Me.txtBalance1.Visible = True
                Me.txtTotCredit.Visible = False
                Me.txtBalance2.Visible = False
                Me.TextBox4.Width = 918
                Me.TextBox5.Width = 918
            Else
                flag2 = Me.rdCredit.Checked
                If flag2 Then
                    Me.dgvSrch.Columns(1).Visible = True
                    Me.dgvSrch.Columns(0).Visible = False
                    Me.txtTotDept.Visible = False
                    Me.txtBalance1.Visible = False
                    Me.txtTotCredit.Visible = True
                    Me.txtBalance2.Visible = True
                    Me.TextBox4.Width = 918
                    Me.TextBox5.Width = 918
                    Me.txtTotCredit.Left = Me.txtTotDept.Left
                    Me.txtBalance2.Left = Me.txtBalance1.Left
                Else
                    Me.dgvSrch.Columns(0).Visible = True
                    Me.dgvSrch.Columns(1).Visible = True
                    Me.txtTotDept.Visible = True
                    Me.txtBalance1.Visible = True
                    Me.txtTotCredit.Visible = True
                    Me.txtBalance2.Visible = True
                    Me.TextBox4.Width = 829
                    Me.TextBox5.Width = 829
                    Me.txtTotCredit.Left = Me.txtTotDept.Left - Me.txtTotDept.Width
                    Me.txtBalance2.Left = Me.txtBalance1.Left - Me.txtBalance1.Width
                End If
            End If
        Catch ex6 As Exception
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
        Me.ShowAccount()
    End Sub

    Private Sub dgvSrch_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellDoubleClick
        Try
            Try
                Dim flag As Boolean = Conversions.ToBoolean(Operators.NotObject(Operators.AndObject(Not Me.chkAllBranches.Checked, Operators.CompareObjectEqual(Me.cmbBranches.SelectedValue, MainClass.BranchNo, False))))
                If flag Then
                    Return
                End If
            Catch ex As Exception
            End Try
            Dim frmRestrictions As New frmRestrictions()
            frmRestrictions.Show()
            frmRestrictions.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Restrictions where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=", Me.dgvSrch.Rows(e.RowIndex).Cells(2).Value)))
            frmRestrictions.Activate()
        Catch ex2 As Exception
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
                                    frmSandQD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandQD where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
                                    frmSandQD.Activate()
                                Else
                                    flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 8, False)
                                    If flag Then
                                        Dim frmSandSD As frmSandSD = New frmSandSD()
                                        frmSandSD.Show()
                                        frmSandSD.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from SandSD where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and id=", dataTable.Rows(0)("doc_no"))))
                                        frmSandSD.Activate()
                                    Else
                                        flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("type"), 9, False)
                                        If flag Then
                                            Form1.RibbonTab1.Ribbon.SelectedPage = Nothing
                                            Dim frmSalePurch3 As frmSalePurch = New frmSalePurch()
                                            frmSalePurch3.Show()
                                            frmSalePurch3.WindowState = FormWindowState.Maximized
                                            frmSalePurch3.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from Inv where branch=" + Conversions.ToString(MainClass.BranchNo) + " and IS_Deleted=0 and proc_type=3 and id=", dataTable.Rows(0)("doc_no"))))
                                            frmSalePurch3.Activate()
                                        End If
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

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(2)
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
            flag = (Me.rdAll.Checked Or Me.rdDebt.Checked)
            If flag Then
                dataTable.Columns.Add("dept")
            End If
            flag = (Me.rdAll.Checked Or Me.rdCredit.Checked)
            If flag Then
                dataTable.Columns.Add("credit")
            End If
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
                flag = Me.rdAll.Checked
                If flag Then
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells("colBalance").Value), Operators.ConcatenateObject("", Me.dgvSrch.Rows(num3).Cells("colpono").Value)})
                End If
                flag = Me.rdDebt.Checked
                If flag Then
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells("colBalance").Value), Operators.ConcatenateObject("", Me.dgvSrch.Rows(num3).Cells("colpono").Value)})
                End If
                flag = Me.rdCredit.Checked
                If flag Then
                    dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvSrch.Rows(num3).Cells("colBalance").Value), Operators.ConcatenateObject("", Me.dgvSrch.Rows(num3).Cells("colpono").Value)})
                End If
                num3 += 1
            End While
            Dim reportDocument As ReportDocument = New ReportDocument()
            flag = Me.dgvSrch.Columns("colpono").Visible
            If flag Then
                reportDocument = New rptAccountBalance2()
            Else
                flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                If flag Then
                    reportDocument = New rptAccountBalance()
                Else
                    reportDocument = New rptAccountBalance___EN()
                End If
            End If
            reportDocument.SetDataSource(dataTable)
            Dim text As String = "الكل"
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Me.cmbAccounts.Text
            End If
            Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtacc"), TextObject)
            textObject.Text = text
            Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtDateFrom"), TextObject)
            textObject2.Text = Me.txtDateFrom.Value.ToShortDateString()
            Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtDateTo"), TextObject)
            textObject3.Text = Me.txtDateTo.Value.ToShortDateString()
            Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
            textObject4.Text = Me.GetEmpUserName(MainClass.EmpNo)
            flag = (Me.rdDebt.Checked Or Me.rdAll.Checked)
            If flag Then
                Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
                textObject5.Text = Me.txtTotDept.Text
                Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
                textObject6.Text = Me.txtBalance1.Text
            End If
            flag = (Me.rdCredit.Checked Or Me.rdAll.Checked)
            If flag Then
                Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
                textObject7.Text = Me.txtTotCredit.Text
                Dim textObject8 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum4"), TextObject)
                textObject8.Text = Me.txtBalance2.Text
            End If
            flag = (Me.rdDebt.Checked Or Me.rdCredit.Checked)
            If flag Then
                Dim lineObject As LineObject = CType(reportDocument.ReportDefinition.Sections(2).ReportObjects("Line16"), LineObject)
                lineObject.LineStyle = LineStyle.NoLine
            End If
            flag = Me.rdDebt.Checked
            If flag Then
                Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(2).ReportObjects("Text5"), TextObject)
                textObject9.Left = 8550
                Dim fieldObject As FieldObject = CType(reportDocument.ReportDefinition.Sections(3).ReportObjects("dept1"), FieldObject)
                fieldObject.Left = 8550
                Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
                textObject10.Left = 7680
                textObject10.Width = 3680
                Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
                textObject11.Left = 7680
                textObject11.Width = 3680
                Dim textObject12 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
                textObject12.Left = 15000
                Dim textObject13 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum4"), TextObject)
                textObject13.Left = 15000
            End If
            flag = Me.rdCredit.Checked
            If flag Then
                Dim textObject14 As TextObject = CType(reportDocument.ReportDefinition.Sections(2).ReportObjects("Text4"), TextObject)
                textObject14.Left = 8550
                Dim fieldObject2 As FieldObject = CType(reportDocument.ReportDefinition.Sections(3).ReportObjects("credit1"), FieldObject)
                fieldObject2.Left = 8550
                Dim textObject15 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum2"), TextObject)
                textObject15.Left = 7680
                textObject15.Width = 3680
                Dim textObject16 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum4"), TextObject)
                textObject16.Left = 7680
                textObject16.Width = 3680
                Dim textObject17 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum1"), TextObject)
                textObject17.Left = 15000
                Dim textObject18 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtsum3"), TextObject)
                textObject18.Left = 15000
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            reportDocument.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject19 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject19.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject20 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject20.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject21 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject21.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject22 As TextObject = CType(reportDocument.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject22.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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

    Private Sub dgvSrch_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellContentClick
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frmTaxRptPeriod As New frmTaxRptPeriod()
        frmTaxRptPeriod.Show()
        frmTaxRptPeriod.Activate()
    End Sub

    Private Sub chkAllCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllCenter.CheckedChanged
        Dim checked As Boolean = Me.chkAllCenter.Checked
        If checked Then
            Me.cmbCostCenter.Enabled = False
        Else
            Me.cmbCostCenter.Enabled = True
        End If
    End Sub

    Private Sub chkAllBranches_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllBranches.CheckedChanged
        Dim checked As Boolean = Me.chkAllBranches.Checked
        If checked Then
            Me.cmbBranches.Enabled = False
        Else
            Me.cmbBranches.Enabled = True
        End If
    End Sub
End Class
