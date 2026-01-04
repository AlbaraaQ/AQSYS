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
Imports AQSYS.My.Resources
Partial Public Class frmAddUsers
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmAddUsers_Load
        frmAddUsers.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmAddUsers.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmAddUsers.__ENCList.Count = frmAddUsers.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmAddUsers.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmAddUsers.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmAddUsers.__ENCList(num) = frmAddUsers.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmAddUsers.__ENCList.RemoveRange(num, frmAddUsers.__ENCList.Count - num)
                frmAddUsers.__ENCList.Capacity = frmAddUsers.__ENCList.Count
            End If
            frmAddUsers.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.cmbEmp.SelectedIndex = -1
        Me.txtUser.Text = ""
        Me.txtPass.Text = ""
        Me.cmbEmp.Focus()
        Me.Code = -1
    End Sub

    Public Sub LoadEmps()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbEmp.DataSource = dataTable
        Me.cmbEmp.DisplayMember = "name"
        Me.cmbEmp.ValueMember = "id"
        Me.cmbEmp.SelectedIndex = -1
    End Sub

    Private Sub frmAddUsers_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmAddUsers.Load
        Me.LoadDG()
        Me.LoadEmps()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub LoadDG()
        Me.dgvUsers.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Users.id as userid,Employees.id as empid,Employees.name,username,pwd from Employees,Users  where Employees.id=Users.emp and Employees.IS_Deleted=0 and Users.IS_Deleted=0", Me.conn)
        Dim dataTable As DataTable = New DataTable()
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
            Me.dgvUsers.Rows.Add()
            Me.dgvUsers.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("userid"))
            Me.dgvUsers.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("empid"))
            Me.dgvUsers.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvUsers.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("username"))
            Me.dgvUsers.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("pwd"))
            num3 += 1
        End While
        Me.dgvUsers.ClearSelection()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Me.cmbEmp.SelectedValue Is Nothing
            If flag Then
                MessageBox.Show("اختر موظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbEmp.Focus()
            Else
                flag = (Operators.CompareString(Me.txtUser.Text.Trim(), "", False) = 0)
                If flag Then
                    MessageBox.Show("ادخل اسم المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txtUser.Focus()
                Else
                    flag = (Operators.CompareString(Me.txtPass.Text.Trim(), "", False) = 0)
                    If flag Then
                        MessageBox.Show("ادخل كلمة المرور", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txtPass.Focus()
                    Else
                        flag = (Me.Code = -1)
                        If flag Then
                            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Users where username='" + Me.txtUser.Text + "'", Me.conn)
                            Dim dataTable As DataTable = New DataTable()
                            sqlDataAdapter.Fill(dataTable)
                            flag = (dataTable.Rows.Count > 0)
                            If flag Then
                                MessageBox.Show("اسم المستخدم مدخل من قبل، ادخل اسم مستخدم اخر", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                Me.txtUser.Focus()
                                Return
                            End If
                        End If
                        flag = (Me.Code <> -1)
                        If flag Then
                            Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id from Users where id<>", Conversions.ToString(Me.Code), " and username='", Me.txtUser.Text, "'"}), Me.conn)
                            Dim dataTable2 As DataTable = New DataTable()
                            sqlDataAdapter2.Fill(dataTable2)
                            flag = (dataTable2.Rows.Count > 0)
                            If flag Then
                                MessageBox.Show("اسم المستخدم مدخل من قبل، ادخل اسم مستخدم اخر", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                Me.txtUser.Focus()
                                Return
                            End If
                        End If
                        flag = (Me.conn.State <> ConnectionState.Open)
                        If flag Then
                            Me.conn.Open()
                        End If
                        flag = (Me.Code = -1)
                        If flag Then
                            Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Users(emp,username,pwd,IS_Deleted) values(", Me.cmbEmp.SelectedValue), ",'"), Me.txtUser.Text), "','"), Me.txtPass.Text), "',0)")), Me.conn)
                            sqlCommand.ExecuteNonQuery()
                            Me.CLR()
                            Me.cmbEmp.Focus()
                        Else
                            Dim sqlCommand2 As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update Users set emp=", Me.cmbEmp.SelectedValue), ",username='"), Me.txtUser.Text), "',pwd='"), Me.txtPass.Text), "' where id="), Me.Code)), Me.conn)
                            sqlCommand2.ExecuteNonQuery()
                            Me.cmbEmp.Focus()
                        End If
                        Me.LoadDG()
                    End If
                End If
            End If
        Catch ex As Exception
            Dim text As String = "خطأ أثناء الحفظ"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgv_RowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvUsers.Rows(row_index).Cells(0).Value))))
        Me.cmbEmp.SelectedValue = Me.dgvUsers.Rows(row_index).Cells(1).Value.ToString()
        Me.txtUser.Text = Me.dgvUsers.Rows(row_index).Cells(3).Value.ToString()
        Me.txtPass.Text = Me.dgvUsers.Rows(row_index).Cells(4).Value.ToString()
    End Sub

    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Dim flag2 As Boolean = e.ColumnIndex = 5
            If flag2 Then
                Dim frmUsersPermissions As frmUsersPermissions = New frmUsersPermissions()
                frmUsersPermissions.Show()
                frmUsersPermissions.cmbEmp.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dgvUsers.Rows(e.RowIndex).Cells(0).Value)
            Else
                Me.dgv_RowChng(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim flag2 As Boolean = Me.Code = 1
                If flag2 Then
                    Interaction.MsgBox("لا يمكن حذف المستخدم الرئيسي، يمكنك تعديل بياناته", MsgBoxStyle.OkOnly, Nothing)
                Else
                    flag2 = (Me.conn.State <> ConnectionState.Open)
                    If flag2 Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand("update Users set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.LoadDG()
                    Me.CLR()
                End If
            Else
                MessageBox.Show("اختر مستخدم ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            Dim text As String = "خطأ أثناء الحذف"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPass.KeyDown
        Dim flag As Boolean = e.KeyCode = Keys.[Return]
        If flag Then
            Me.btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim hasRows As Boolean = dr.HasRows
        If hasRows Then
            dr.Read()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.cmbEmp.SelectedValue = RuntimeHelpers.GetObjectValue(dr("emp"))
            Me.txtUser.Text = Conversions.ToString(dr("username"))
            Me.txtPass.Text = Conversions.ToString(dr("pwd"))
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvUsers.ClearSelection()
        Dim sqlCommand As SqlCommand = New SqlCommand(sqlstr, Me.conn)
        Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
        If flag Then
            Me.conn.Open()
        End If
        Dim dr As SqlDataReader = sqlCommand.ExecuteReader()
        Me.ReadData(dr)
        flag = (Me.conn.State <> ConnectionState.Closed)
        If flag Then
            Me.conn.Close()
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Me.Navigate("select top 1 * from Users where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Users where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Users where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Users where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub cmbEmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbEmp.SelectedIndexChanged
        Try
            Me.Code = -1
            Me.txtUser.Text = ""
            Me.txtPass.Text = ""
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select id,username,pwd from Users where emp=", Me.cmbEmp.SelectedValue), " and IS_Deleted=0")), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                ' The following expression was wrapped in a checked-expression
                Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("id")))))
                Me.txtUser.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("username")))
                Me.txtPass.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("pwd")))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class
