Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Partial Public Class frmUsersPermissions
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private Code As Integer

    Private _Finished As Boolean

    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmUsersPermissions_Load
        frmUsersPermissions.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.Code = -1
        Me._Finished = True
        Me.InitializeComponent()
    End Sub

    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmUsersPermissions.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmUsersPermissions.__ENCList.Count = frmUsersPermissions.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmUsersPermissions.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmUsersPermissions.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmUsersPermissions.__ENCList(num) = frmUsersPermissions.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmUsersPermissions.__ENCList.RemoveRange(num, frmUsersPermissions.__ENCList.Count - num)
                frmUsersPermissions.__ENCList.Capacity = frmUsersPermissions.__ENCList.Count
            End If
            frmUsersPermissions.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
        Me.treeView1.Nodes(0).Checked = False
        Me.cmbEmp.Focus()
        Me.Code = -1
    End Sub

    Public Sub LoadEmps()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Users.id,Employees.name from Users,Employees where Users.emp=Employees.id and Users.IS_Deleted=0 and Employees.IS_Deleted=0 order by Users.id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbEmp.DataSource = dataTable
        Me.cmbEmp.DisplayMember = "name"
        Me.cmbEmp.ValueMember = "id"
        Me.cmbEmp.SelectedIndex = -1
    End Sub

    Private Sub LoadTree(ParentNode As TreeNode, ParentId As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Forms where parent_id=" + Conversions.ToString(ParentId), Me.conn)
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
            Dim columnName As String = "name"
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag Then
                columnName = "nameEn"
            End If
            Dim treeNode As TreeNode = ParentNode.Nodes.Add(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("id"))), Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)(columnName))))
            flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Parent")))
            If flag Then
                Me.LoadTree(treeNode, Conversions.ToInteger(dataTable.Rows(num3)("id")))
            Else
                treeNode.Tag = "Child"
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_New_Visible")))
                If flag Then
                    Dim text As String = "اضافة"
                    flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag Then
                        text = "new"
                    End If
                    treeNode.Nodes.Add(text)
                End If
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Save_Visible")))
                If flag Then
                    Dim text2 As String = "حفظ"
                    flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag Then
                        text2 = "save"
                    End If
                    treeNode.Nodes.Add(text2)
                End If
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Delete_Visible")))
                If flag Then
                    Dim text3 As String = "حذف"
                    flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag Then
                        text3 = "delete"
                    End If
                    treeNode.Nodes.Add(text3)
                End If
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Search_Visible")))
                If flag Then
                    Dim text4 As String = "بحث"
                    flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag Then
                        text4 = "search"
                    End If
                    treeNode.Nodes.Add(text4)
                End If
                flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Print_Visible")))
                If flag Then
                    Dim text5 As String = "طباعة"
                    flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                    If flag Then
                        text5 = "print"
                    End If
                    treeNode.Nodes.Add(text5)
                End If
            End If
            num3 += 1
        End While
    End Sub

    Private Sub LoadUserPermissions()
        Try
            Me.treeView1.Nodes(0).Checked = False
            Me.Code = Conversions.ToInteger(Me.cmbEmp.SelectedValue)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from User_Permissions where user_id=", Me.cmbEmp.SelectedValue)), Me.conn)
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
                Dim treeNode As TreeNode = Me.treeView1.Nodes.Find(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("Form_id"))), True)(0)
                Dim num6 As Integer = 0
                Dim num7 As Integer = treeNode.Nodes.Count - 1
                Dim num8 As Integer = num6
                While True
                    Dim num9 As Integer = num8
                    num5 = num7
                    If num9 > num5 Then
                        Exit While
                    End If
                    Dim flag As Boolean = (Operators.CompareString(treeNode.Nodes(num8).Text, "اضافة", False) = 0 Or Operators.CompareString(treeNode.Nodes(num8).Text, "new", False) = 0) And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_New")))
                    If flag Then
                        treeNode.Nodes(num8).Checked = True
                    End If
                    flag = ((Operators.CompareString(treeNode.Nodes(num8).Text, "حفظ", False) = 0 Or Operators.CompareString(treeNode.Nodes(num8).Text, "save", False) = 0) And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Save"))))
                    If flag Then
                        treeNode.Nodes(num8).Checked = True
                    End If
                    flag = ((Operators.CompareString(treeNode.Nodes(num8).Text, "حذف", False) = 0 Or Operators.CompareString(treeNode.Nodes(num8).Text, "delete", False) = 0) And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Delete"))))
                    If flag Then
                        treeNode.Nodes(num8).Checked = True
                    End If
                    flag = ((Operators.CompareString(treeNode.Nodes(num8).Text, "بحث", False) = 0 Or Operators.CompareString(treeNode.Nodes(num8).Text, "search", False) = 0) And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Search"))))
                    If flag Then
                        treeNode.Nodes(num8).Checked = True
                    End If
                    flag = ((Operators.CompareString(treeNode.Nodes(num8).Text, "طباعة", False) = 0 Or Operators.CompareString(treeNode.Nodes(num8).Text, "print", False) = 0) And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("IS_Print"))))
                    If flag Then
                        treeNode.Nodes(num8).Checked = True
                    End If
                    num8 += 1
                End While
                num3 += 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmUsersPermissions_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.LoadEmps()
        Me.treeView1.Nodes.Clear()
        Dim text As String = "الشاشات"
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
        If flag Then
            text = "screens"
        End If
        Dim parentNode As TreeNode = Me.treeView1.Nodes.Add("0", text)
        Me.LoadTree(parentNode, 0)
        Me.treeView1.Nodes(0).Expand()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub cmbEmp_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbEmp.SelectedIndexChanged
        Try
            Me.txtUser.Text = ""
            Me.txtPass.Text = ""
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from Users where id=", Me.cmbEmp.SelectedValue)), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.Code = Conversions.ToInteger(Operators.ConcatenateObject("", dataTable.Rows(0)("id")))
                Me.txtUser.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("username")))
                Me.txtPass.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("pwd")))
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_inv")))
                    If flag Then
                        Me.chkEdit.Checked = True
                    Else
                        Me.chkEdit.Checked = False
                    End If
                Catch ex As Exception
                End Try
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_disc")))
                    If flag Then
                        Me.chkDisc.Checked = True
                    Else
                        Me.chkDisc.Checked = False
                    End If
                Catch ex2 As Exception
                End Try
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_price")))
                    If flag Then
                        Me.chkPrice.Checked = True
                    Else
                        Me.chkPrice.Checked = False
                    End If
                Catch ex3 As Exception
                End Try
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_date")))
                    If flag Then
                        Me.chkDate.Checked = True
                    Else
                        Me.chkDate.Checked = False
                    End If
                Catch ex4 As Exception
                End Try
                Try
                    flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("hide_tel")))
                    If flag Then
                        Me.chkHideCustMobile.Checked = True
                    Else
                        Me.chkHideCustMobile.Checked = False
                    End If
                Catch ex5 As Exception
                End Try
                Try
                    Me.chkSendInvEmail.Checked = False
                    Me.chkSendInvEmail.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("send_inv_email")))
                Catch ex6 As Exception
                End Try
                Try
                    Me.txtPrintClientsPWD.Text = ""
                    Me.txtPrintClientsPWD.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("print_clients_pwd")))
                Catch ex7 As Exception
                End Try
                Me.LoadUserPermissions()
            End If
        Catch ex8 As Exception
        End Try
    End Sub

    ' ========== هنا الإصلاح الرئيسي ==========
    Private Sub treeView1_AfterCheck(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView1.AfterCheck
        Try
            Dim flag As Boolean = Me._Finished
            If flag Then
                Dim text As String = e.Node.Text
                flag = (e.Node.Nodes.Count > 0)
                If flag Then
                    Dim checked As Boolean = e.Node.Checked
                    Try
                        For Each obj As Object In e.Node.Nodes
                            Dim treeNode As TreeNode = CType(obj, TreeNode)
                            treeNode.Checked = checked
                        Next
                    Finally
                        Dim enumerator As IEnumerator
                        flag = (TypeOf enumerator Is IDisposable)
                        If flag Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                End If
            End If

            Me._Finished = False

            ' ========== الإصلاح: التحقق من أن Parent ليس Nothing ==========
            Dim parent As TreeNode = e.Node.Parent

            ' إذا كان العنصر هو الجذر (ليس له أب)، نخرج من الدالة
            If parent Is Nothing Then
                Me._Finished = True
                Exit Sub
            End If

            Dim flag2 As Boolean = False
            Try
                For Each obj2 As Object In parent.Nodes
                    Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
                    flag = treeNode2.Checked
                    If flag Then
                        flag2 = True
                        Exit For ' الخروج فور إيجاد عنصر محدد
                    End If
                Next
            Finally
                Dim enumerator2 As IEnumerator
                flag = (TypeOf enumerator2 Is IDisposable)
                If flag Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try

            flag = (parent.Checked <> flag2)
            If flag Then
                parent.Checked = flag2
            End If

            Me._Finished = True
        Catch ex As Exception
            Me._Finished = True
        End Try
    End Sub
    ' ========== نهاية الإصلاح ==========

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub SaveTree(ParentNode As TreeNode, tr As SqlTransaction)
        Dim num As Integer = 0
        Dim num2 As Integer = ParentNode.Nodes.Count - 1
        Dim num3 As Integer = num
        While True
            Dim num4 As Integer = num3
            Dim num5 As Integer = num2
            If num4 > num5 Then
                Exit While
            End If
            Dim treeNode As TreeNode = ParentNode.Nodes(num3)
            Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(treeNode.Tag, "Child", False)
            If flag Then
                Me.SaveTree(treeNode, tr)
            Else
                flag = treeNode.Checked
                If flag Then
                    Dim num6 As Integer = 0
                    Dim num7 As Integer = 0
                    Dim num8 As Integer = 0
                    Dim num9 As Integer = 0
                    Dim num10 As Integer = 0
                    Dim num11 As Integer = 0
                    Dim num12 As Integer = treeNode.Nodes.Count - 1
                    Dim num13 As Integer = num11
                    While True
                        Dim num14 As Integer = num13
                        num5 = num12
                        If num14 > num5 Then
                            Exit While
                        End If
                        flag = ((Operators.CompareString(treeNode.Nodes(num13).Text, "اضافة", False) = 0 Or Operators.CompareString(treeNode.Nodes(num13).Text, "new", False) = 0) And treeNode.Nodes(num13).Checked)
                        If flag Then
                            num6 = 1
                        End If
                        flag = ((Operators.CompareString(treeNode.Nodes(num13).Text, "حفظ", False) = 0 Or Operators.CompareString(treeNode.Nodes(num13).Text, "save", False) = 0) And treeNode.Nodes(num13).Checked)
                        If flag Then
                            num7 = 1
                        End If
                        flag = ((Operators.CompareString(treeNode.Nodes(num13).Text, "حذف", False) = 0 Or Operators.CompareString(treeNode.Nodes(num13).Text, "delete", False) = 0) And treeNode.Nodes(num13).Checked)
                        If flag Then
                            num8 = 1
                        End If
                        flag = ((Operators.CompareString(treeNode.Nodes(num13).Text, "بحث", False) = 0 Or Operators.CompareString(treeNode.Nodes(num13).Text, "search", False) = 0) And treeNode.Nodes(num13).Checked)
                        If flag Then
                            num9 = 1
                        End If
                        flag = ((Operators.CompareString(treeNode.Nodes(num13).Text, "طباعة", False) = 0 Or Operators.CompareString(treeNode.Nodes(num13).Text, "print", False) = 0) And treeNode.Nodes(num13).Checked)
                        If flag Then
                            num10 = 1
                        End If
                        num13 += 1
                    End While
                    Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into User_Permissions(user_id,Form_id,IS_New,IS_Save,IS_Delete,IS_Search,IS_Print)values(", Me.cmbEmp.SelectedValue), ","), treeNode.Name), ","), num6), ","), num7), ","), num8), ","), num9), ","), num10), ")")), Me.conn, tr)
                    sqlCommand.ExecuteNonQuery()
                End If
            End If
            num3 += 1
        End While
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim sqlTransaction As SqlTransaction = Nothing ' إصلاح: تهيئة المتغير
        Try
            Dim flag As Boolean = Me.cmbEmp.SelectedIndex = -1
            If flag Then
                MessageBox.Show("يجب اختيار الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbEmp.Focus()
            Else
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                sqlTransaction = Me.conn.BeginTransaction()
                Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("delete from User_Permissions where user_id=", Me.cmbEmp.SelectedValue)), Me.conn, sqlTransaction)
                sqlCommand.ExecuteNonQuery()
                Dim value As Integer = 0
                Dim value2 As Integer = 0
                Dim value3 As Integer = 0
                Dim value4 As Integer = 0
                Dim value5 As Integer = 0
                Dim value6 As Integer = 0
                flag = Me.chkEdit.Checked
                If flag Then
                    value = 1
                End If
                flag = Me.chkDisc.Checked
                If flag Then
                    value2 = 1
                End If
                flag = Me.chkPrice.Checked
                If flag Then
                    value3 = 1
                End If
                flag = Me.chkDate.Checked
                If flag Then
                    value4 = 1
                End If
                flag = Me.chkHideCustMobile.Checked
                If flag Then
                    value5 = 1
                End If
                flag = Me.chkSendInvEmail.Checked
                If flag Then
                    value6 = 1
                End If
                sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update users set edit_inv=" + Conversions.ToString(value) + ",edit_disc=" + Conversions.ToString(value2) + ", edit_price=" + Conversions.ToString(value3) + ",edit_date=" + Conversions.ToString(value4) + ",hide_tel=" + Conversions.ToString(value5) + ", send_inv_email=" + Conversions.ToString(value6) + ",print_clients_pwd='" + Me.txtPrintClientsPWD.Text + "' where id=", Me.cmbEmp.SelectedValue)), Me.conn, sqlTransaction)
                sqlCommand.ExecuteNonQuery()
                Me.SaveTree(Me.treeView1.Nodes(0), sqlTransaction)
                sqlTransaction.Commit()
                Me.Code = Conversions.ToInteger(Me.cmbEmp.SelectedValue)
                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            ' إصلاح: التحقق من أن sqlTransaction ليس Nothing قبل Rollback
            If sqlTransaction IsNot Nothing Then
                sqlTransaction.Rollback()
            End If
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

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
                If flag2 Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("delete from User_Permissions where user_id=", Me.cmbEmp.SelectedValue)), Me.conn)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.CLR()
            Else
                MessageBox.Show("قم بعرض صلاحيات موظف أولاً", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub gBoxClientData_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles gBoxClientData.Enter
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        Try
            Me.cmbEmp.SelectedIndex = Me.cmbEmp.Items.Count - 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim cmbEmp As ComboBox = Me.cmbEmp
            cmbEmp.SelectedIndex += 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Try
            Dim cmbEmp As ComboBox = Me.cmbEmp
            cmbEmp.SelectedIndex -= 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Try
            Me.cmbEmp.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
End Class