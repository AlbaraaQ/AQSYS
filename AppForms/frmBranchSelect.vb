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
Public Partial Class frmBranchSelect
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.KeyDown, AddressOf Me.frmBranchSelect_KeyDown
        AddHandler MyBase.Load, AddressOf Me.frmBranchSelect_Load
        frmBranchSelect.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmBranchSelect.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmBranchSelect.__ENCList.Count = frmBranchSelect.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmBranchSelect.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmBranchSelect.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmBranchSelect.__ENCList(num) = frmBranchSelect.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmBranchSelect.__ENCList.RemoveRange(num, frmBranchSelect.__ENCList.Count - num)
                frmBranchSelect.__ENCList.Capacity = frmBranchSelect.__ENCList.Count
            End If
            frmBranchSelect.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Dim Form1 As New Form1()
        Form1.Close()
    End Sub

    Private Sub frmBranchSelect_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Try
            Dim flag As Boolean = e.KeyCode = Keys.F4
            If flag Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadBranches()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbBranches.DataSource = dataTable
        Me.cmbBranches.DisplayMember = "name"
        Me.cmbBranches.ValueMember = "id"
        Me.cmbBranches.SelectedIndex = -1
    End Sub

    Private Sub frmBranchSelect_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.LoadBranches()
        Dim flag As Boolean = Me.cmbBranches.Items.Count > 0
        If flag Then
            Me.cmbBranches.SelectedIndex = 0
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Try
            Dim checked As Boolean = Me.chkAll.Checked
            If checked Then
                Me.cmbBranches.Enabled = False
            Else
                Me.cmbBranches.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEnter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnter.Click
        Try
            Dim Form1 As New Form1()
            Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbBranches.SelectedValue Is Nothing
            If flag Then
                MessageBox.Show("اختر فرع أو الكل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbBranches.Focus()
            Else
                Dim str As String = "الكل"
                Dim branchNo As Integer = -1
                flag = Not Me.chkAll.Checked
                If flag Then
                    str = Me.cmbBranches.Text
                    branchNo = Conversions.ToInteger(Me.cmbBranches.SelectedValue)
                End If
                Form1.lblBranch.Caption = "الفرع: " + str
                MainClass.BranchNo = branchNo
                Form1.Activate()
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
