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
Public Partial Class frmErsaliaExpenses
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmErsaliaExpenses_Load
        frmErsaliaExpenses.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmErsaliaExpenses.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmErsaliaExpenses.__ENCList.Count = frmErsaliaExpenses.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmErsaliaExpenses.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmErsaliaExpenses.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmErsaliaExpenses.__ENCList(num) = frmErsaliaExpenses.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmErsaliaExpenses.__ENCList.RemoveRange(num, frmErsaliaExpenses.__ENCList.Count - num)
                frmErsaliaExpenses.__ENCList.Capacity = frmErsaliaExpenses.__ENCList.Count
            End If
            frmErsaliaExpenses.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub LoadErsSupp()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=2 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbErsSuppliers.DataSource = dataTable
        Me.cmbErsSuppliers.DisplayMember = "name"
        Me.cmbErsSuppliers.ValueMember = "id"
        Me.cmbErsSuppliers.SelectedIndex = -1
    End Sub

    Private Sub frmErsaliaExpenses_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmErsaliaExpenses.Load
        Try
            Me.LoadErsSupp()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadData()
        ' The following expression was wrapped in a checked-statement
        Try
            Me.txtComm.Text = ""
            Me.dgvExpenses.Rows.Clear()
            Dim flag As Boolean = Me.cmbErsSuppliers.SelectedValue IsNot Nothing And Conversion.Val(Me.txtErsNo.Text) <> 0.0
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from ers_exp where supp=", Me.cmbErsSuppliers.SelectedValue), " and no="), Conversion.Val(Me.txtErsNo.Text))), Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Me.txtComm.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("comm")))
                    sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from ers_exp_sub where supp=", Me.cmbErsSuppliers.SelectedValue), " and no="), Conversion.Val(Me.txtErsNo.Text))), Me.conn)
                    dataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    Dim num As Integer = 0
                    Dim num2 As Integer = dataTable.Rows.Count - 1
                    Dim num3 As Integer = num
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        Me.dgvExpenses.Rows.Add()
                        Me.dgvExpenses.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("expname"))
                        Me.dgvExpenses.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("expval"))
                        num3 += 1
                    End While
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbErsSuppliers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbErsSuppliers.SelectedIndexChanged
        Me.LoadData()
    End Sub

    Private Sub txtErsNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtErsNo.TextChanged
        Me.LoadData()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.cmbErsSuppliers.SelectedValue Is Nothing
            If flag Then
                Interaction.MsgBox("اختر المورد", MsgBoxStyle.OkOnly, Nothing)
                Me.cmbErsSuppliers.Focus()
            Else
                flag = (Conversion.Val(Me.txtErsNo.Text) = 0.0)
                If flag Then
                    Interaction.MsgBox("ادخل رقم الإرسالية", MsgBoxStyle.OkOnly, Nothing)
                    Me.txtErsNo.Focus()
                Else
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand()
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from ers_exp where supp=", Me.cmbErsSuppliers.SelectedValue), " and no="), Conversion.Val(Me.txtErsNo.Text))), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag = (dataTable.Rows.Count = 0)
                    If flag Then
                        sqlCommand = New SqlCommand("insert into ers_exp(supp,no,comm)values(@supp,@no,@comm)", Me.conn)
                    Else
                        sqlCommand = New SqlCommand("update ers_exp set comm=@comm where supp=@supp and no=@no", Me.conn)
                    End If
                    sqlCommand.Parameters.Add("@supp", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbErsSuppliers.SelectedValue)
                    sqlCommand.Parameters.Add("@no", SqlDbType.Int).Value = Conversion.Val(Me.txtErsNo.Text)
                    sqlCommand.Parameters.Add("@comm", SqlDbType.Float).Value = Conversion.Val(Me.txtComm.Text)
                    sqlCommand.ExecuteNonQuery()
                    sqlCommand = New SqlCommand("delete from ers_exp_sub where supp=@supp and no=@no", Me.conn)
                    sqlCommand.Parameters.Add("@supp", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbErsSuppliers.SelectedValue)
                    sqlCommand.Parameters.Add("@no", SqlDbType.Int).Value = Conversion.Val(Me.txtErsNo.Text)
                    sqlCommand.ExecuteNonQuery()
                    Dim num As Integer = 0
                    Dim num2 As Integer = Me.dgvExpenses.Rows.Count - 2
                    Dim num3 As Integer = num
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        sqlCommand = New SqlCommand("insert into ers_exp_sub(supp,no,expname,expval)values(@supp,@no,@expname,@expval)", Me.conn)
                        sqlCommand.Parameters.Add("@supp", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbErsSuppliers.SelectedValue)
                        sqlCommand.Parameters.Add("@no", SqlDbType.Int).Value = Conversion.Val(Me.txtErsNo.Text)
                        sqlCommand.Parameters.Add("@expname", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dgvExpenses.Rows(num3).Cells(0).Value)
                        sqlCommand.Parameters.Add("@expval", SqlDbType.Float).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvExpenses.Rows(num3).Cells(1).Value))
                        sqlCommand.ExecuteNonQuery()
                        num3 += 1
                    End While
                    MessageBox.Show("تم الحفظ")
                End If
            End If
        Catch ex As Exception
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvExpenses_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvExpenses.CellValueChanged
        Try
            Dim flag As Boolean = e.ColumnIndex = 1
            If flag Then
                Dim num As Double = 0.0
                Dim num2 As Integer = 0
                Dim num3 As Integer = Me.dgvExpenses.Rows.Count - 2
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    num += Conversion.Val(Operators.ConcatenateObject("", Me.dgvExpenses.Rows(num4).Cells(1).Value))
                    num4 += 1
                End While
                Me.txtTotVal.Text = "" + Conversions.ToString(num)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
