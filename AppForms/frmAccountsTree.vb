Imports Microsoft.VisualBasic
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
Imports AQSYS.My.Resources
Public Partial Class frmAccountsTree
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private con As SqlConnection

    Private ID As Integer

    Public _selectedname As String
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmAccountsTree_Load
        frmAccountsTree.__ENCAddToList(Me)
        Me.con = MainClass.ConnObj()
        Me.ID = -1
        Me._selectedname = ""
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmAccountsTree.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmAccountsTree.__ENCList.Count = frmAccountsTree.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmAccountsTree.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmAccountsTree.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmAccountsTree.__ENCList(num) = frmAccountsTree.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmAccountsTree.__ENCList.RemoveRange(num, frmAccountsTree.__ENCList.Count - num)
                frmAccountsTree.__ENCList.Capacity = frmAccountsTree.__ENCList.Count
            End If
            frmAccountsTree.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub clr()
        Me.ID = -1
        Me.Code.Text = ""
        Me.AName.Text = ""
        Me.debt.Checked = True
        Me.main.Checked = True
        Me.txtDate.Value = DateTime.Now
        Me.User.Text = ""
        Me.IValue.Text = ""
        Me.FinalAcc.SelectedIndex = -1
        Me.AName.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Operators.CompareString(Me.Code.Text, "", False) = 0
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
                If flag2 Then
                    MessageBox.Show("من فضلك أدخل كود الحساب")
                Else
                    MessageBox.Show("Enter account code")
                End If
            Else
                Dim flag2 As Boolean = Me.ID = -1
                If flag2 Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code='" + Me.Code.Text + "'", Me.con)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag2 = (dataTable.Rows.Count > 0)
                    If flag2 Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag Then
                            MessageBox.Show("كود الحساب مدخل مسبقا، من فضلك أدخل كود آخر")
                        Else
                            MessageBox.Show("Account code is previously inserted, Enter another code")
                        End If
                        Return
                    End If
                End If
                Try
                    flag2 = (Operators.CompareString(Me.Code.Text, Me.ParentCode.SelectedValue.ToString(), False) = 0)
                    If flag2 Then
                        Interaction.MsgBox("لقد ادخلت رقم الحساب نفس حساب الأب", MsgBoxStyle.OkOnly, Nothing)
                        Me.ParentCode.Focus()
                        Return
                    End If
                Catch ex As Exception
                End Try
                flag2 = (Me.ParentCode.SelectedValue IsNot Nothing)
                If flag2 Then
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code=" + Me.ParentCode.SelectedValue.ToString(), Me.con)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag2 = (dataTable2.Rows.Count = 0)
                    If flag2 Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag Then
                            MessageBox.Show("الحساب الأب غير موجود")
                        Else
                            MessageBox.Show("Parent code not found")
                        End If
                        Return
                    End If
                End If
                flag2 = (Me.ParentCode.SelectedValue IsNot Nothing And Me.sub1.Checked)
                Dim flag3 As Boolean
                If flag2 Then
                    Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select Type from Accounts_Index where Code=" + Me.ParentCode.SelectedValue.ToString(), Me.con)
                    Dim dataTable3 As DataTable = New DataTable()
                    sqlDataAdapter3.Fill(dataTable3)
                    flag2 = (dataTable3.Rows.Count > 0)
                    If flag2 Then
                        flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))) = 2)
                        If flag Then
                            flag3 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag3 Then
                                MessageBox.Show("الحساب الأب عبارة عن حساب فرعي ، يجب أن يكون الحساب الأب رئيسي")
                            Else
                                MessageBox.Show("the parent code is sub account,it must be main account")
                            End If
                            Return
                        End If
                    End If
                Else
                    flag3 = (Me.ParentCode.SelectedValue Is Nothing And Me.sub1.Checked)
                    If flag3 Then
                        flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag2 Then
                            MessageBox.Show("من فضلك ادخل كود الحساب الأب")
                        Else
                            MessageBox.Show("Enter the parent code")
                        End If
                        Return
                    End If
                End If
                Try
                    flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 121, False), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 122, False)), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 123, False)), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 261, False)))
                    If flag3 Then
                        MessageBox.Show("يتم الإضافة أو التعديل لهذا البند من خلال شاشة البيانات الأساسية")
                        Return
                    End If
                Catch ex2 As Exception
                End Try
                Dim value As Integer = 0
                Dim value2 As Integer = Me.FinalAcc.SelectedIndex + 1
                flag3 = Me.sub1.Checked
                If flag3 Then
                    flag2 = Me.debt.Checked
                    If flag2 Then
                        value = 1
                    Else
                        value = 2
                    End If
                End If
                Dim value3 As Integer = 1
                flag3 = Me.sub1.Checked
                If flag3 Then
                    value3 = 2
                End If
                Dim value4 As Double = 0.0
                flag3 = Me.sub1.Checked
                If flag3 Then
                    value4 = Conversion.Val(Me.IValue.Text)
                End If
                flag3 = (Me.ID = -1)
                If flag3 Then
                    Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"insert into Accounts_Index(Code,AName,EName,Nature,Type,ParentCode,Date,UserName,IValue,FinalAcc,Total_Debts,Total_Credits,Account_Value,Acc_branch) values ('", Me.Code.Text, "','", Me.AName.Text, "','", Me.EName.Text, "',", Conversions.ToString(value), ",", Conversions.ToString(value3), ",'", Me.ParentCode.SelectedValue.ToString(), "',@Date,'", Me.User.Text, "',", Conversions.ToString(value4), ",", Conversions.ToString(value2), ",0,0,", Conversions.ToString(value4), ",@Acc_branch)"}), Me.con)
                    flag3 = Me.sub1.Checked
                    If flag3 Then
                        sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = Me.txtDate.Value
                    Else
                        sqlCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = DBNull.Value
                    End If
                    sqlCommand.Parameters.Add("@Acc_branch", SqlDbType.Int).Value = DBNull.Value
                    Me.con.Open()
                    sqlCommand.ExecuteNonQuery()
                Else
                    Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() {"update Accounts_Index set AName='", Me.AName.Text, "',EName='", Me.EName.Text, "',Nature=", Conversions.ToString(value), ",Type=", Conversions.ToString(value3), ",ParentCode='", Me.ParentCode.SelectedValue.ToString(), "',Date=@Date,UserName='", Me.User.Text, "',IValue=", Conversions.ToString(value4), ",FinalAcc=", Conversions.ToString(value2), " where Code=", Me.Code.Text}), Me.con)
                    flag3 = Me.sub1.Checked
                    If flag3 Then
                        sqlCommand2.Parameters.Add("@Date", SqlDbType.DateTime).Value = Me.txtDate.Value
                    Else
                        sqlCommand2.Parameters.Add("@Date", SqlDbType.DateTime).Value = DBNull.Value
                    End If
                    Me.con.Open()
                    sqlCommand2.ExecuteNonQuery()
                End If
                Dim right As String = "123"
                Dim right2 As String = "261"
                Dim right3 As String = "121"
                Dim right4 As String = "122"
                Try
                    flag3 = (Me.ID = -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right, False) = 0)
                    If flag3 Then
                        Dim sqlCommand3 As SqlCommand = New SqlCommand("insert into customers(name,type,is_deleted) values ('" + Me.AName.Text + "',1,0)", Me.con)
                        sqlCommand3.ExecuteNonQuery()
                    Else
                        flag3 = (Me.ID <> -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right, False) = 0)
                        If flag3 Then
                            Try
                                Dim sqlCommand4 As SqlCommand = New SqlCommand(String.Concat(New String() {"update customers set name='", Me.AName.Text, "' where name='", Me._selectedname, "'"}), Me.con)
                                sqlCommand4.ExecuteNonQuery()
                            Catch ex3 As Exception
                            End Try
                        Else
                            flag3 = (Me.ID = -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right2, False) = 0)
                            If flag3 Then
                                Dim sqlCommand5 As SqlCommand = New SqlCommand("insert into customers(name,type,is_deleted) values ('" + Me.AName.Text + "',2,0)", Me.con)
                                sqlCommand5.ExecuteNonQuery()
                            Else
                                flag3 = (Me.ID <> -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right2, False) = 0)
                                If flag3 Then
                                    Try
                                        Dim sqlCommand6 As SqlCommand = New SqlCommand(String.Concat(New String() {"update customers set name='", Me.AName.Text, "' where name='", Me._selectedname, "'"}), Me.con)
                                        sqlCommand6.ExecuteNonQuery()
                                    Catch ex4 As Exception
                                    End Try
                                Else
                                    flag3 = (Me.ID = -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right3, False) = 0)
                                    If flag3 Then
                                        Dim sqlCommand7 As SqlCommand = New SqlCommand(String.Concat(New String() {"insert into Stocks(name,branch,status,IS_Default,IS_Deleted)values('", Me.AName.Text, "',", Conversions.ToString(MainClass.BranchNo), ",1,0,0)"}), Me.con)
                                        sqlCommand7.ExecuteNonQuery()
                                        sqlCommand7 = New SqlCommand("select max(id) from Stocks", Me.con)
                                        Dim value5 As Integer = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand7.ExecuteScalar()))))
                                        sqlCommand7 = New SqlCommand(String.Concat(New String() {"insert into Stock_Emps(stock_id,emp_id)values(", Conversions.ToString(value5), ",", Conversions.ToString(MainClass.EmpNo), ")"}), Me.con)
                                        sqlCommand7.ExecuteNonQuery()
                                    Else
                                        flag3 = (Me.ID <> -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right3, False) = 0)
                                        If flag3 Then
                                            Try
                                                Dim sqlCommand8 As SqlCommand = New SqlCommand(String.Concat(New String() {"update Stocks set name='", Me.AName.Text, "' where name='", Me._selectedname, "'"}), Me.con)
                                                sqlCommand8.ExecuteNonQuery()
                                            Catch ex5 As Exception
                                            End Try
                                        Else
                                            flag3 = (Me.ID = -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right4, False) = 0)
                                            If flag3 Then
                                                Dim sqlCommand9 As SqlCommand = New SqlCommand("insert into banks(name,is_deleted) values ('" + Me.AName.Text + "',0)", Me.con)
                                                sqlCommand9.ExecuteNonQuery()
                                            Else
                                                flag3 = (Me.ID <> -1 And Operators.CompareString(Me.ParentCode.SelectedValue.ToString(), right4, False) = 0)
                                                If flag3 Then
                                                    Try
                                                        Dim sqlCommand10 As SqlCommand = New SqlCommand(String.Concat(New String() {"update banks set name='", Me.AName.Text, "' where name='", Me._selectedname, "'"}), Me.con)
                                                        sqlCommand10.ExecuteNonQuery()
                                                    Catch ex6 As Exception
                                                    End Try
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch ex7 As Exception
                End Try
                Me.loadtree()
                flag3 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                If flag3 Then
                    MessageBox.Show("تمت حفظ البيانات بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("Saved", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                Me.clr()
                Dim num As Integer = Conversions.ToInteger(Me.ParentCode.SelectedValue)
                Me.LoadParent()
                Me.ParentCode.SelectedValue = num
                Me.GenerateCode()
                Me.AName.Focus()
            End If
        Catch ex8 As Exception
        Finally
            Dim flag3 As Boolean = Me.con.State <> ConnectionState.Closed
            If flag3 Then
                Me.con.Close()
            End If
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.clr()
        Dim flag As Boolean = Me.ParentCode.SelectedValue IsNot Nothing
        If flag Then
            Me.GenerateCode()
        End If
    End Sub

    Private Sub sub1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sub1.CheckedChanged
        Dim checked As Boolean = Me.sub1.Checked
        If checked Then
            Me.panel3.Visible = True
        Else
            Me.panel3.Visible = False
            Me.IValue.Text = ""
            Me.debt.Checked = True
            Me.txtDate.Value = DateTime.Now
            Me.User.Text = ""
        End If
        Me.GenerateCode()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.Code.Text, "", False) = 0
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
                If flag2 Then
                    MessageBox.Show("من فضلك اختر حساب أولا أو ادخل كوده")
                Else
                    MessageBox.Show("choose account to be deleted")
                End If
            Else
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code='" + Me.Code.Text + "'", Me.con)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                Dim flag2 As Boolean = dataTable.Rows.Count > 0
                If flag2 Then
                    Try
                        flag = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 121, False), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 122, False)), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 123, False)), Operators.CompareObjectEqual(Me.ParentCode.SelectedValue, 261, False)))
                        If flag Then
                            MessageBox.Show("يتم الحذف لهذا البند من خلال شاشة البيانات الأساسية")
                            Return
                        End If
                    Catch ex As Exception
                    End Try
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where ParentCode='" + Me.Code.Text + "'", Me.con)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag2 = (dataTable2.Rows.Count > 0)
                    If flag2 Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag Then
                            MessageBox.Show("لايمكن حذف الحساب لأن له حسابات فرعية")
                        Else
                            MessageBox.Show("account can not be deleted, it has sub accounts")
                        End If
                    Else
                        Try
                            Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from restrictions,restrictions_sub  where restrictions.id=restrictions_sub.res_id  and is_deleted=0 and acc_no=" + Me.Code.Text, Me.con)
                            Dim dataTable3 As DataTable = New DataTable()
                            sqlDataAdapter3.Fill(dataTable3)
                            flag2 = (dataTable3.Rows.Count > 0)
                            If flag2 Then
                                MessageBox.Show("لا يمكن حذف الحساب لأنه مرتبط بحركات", "")
                                Return
                            End If
                        Catch ex2 As Exception
                        End Try
                        Dim sqlCommand As SqlCommand = New SqlCommand("delete from Accounts_Index where Code='" + Me.Code.Text + "'", Me.con)
                        Me.con.Open()
                        sqlCommand.ExecuteNonQuery()
                        Me.loadtree()
                        Me.treeView1.ExpandAll()
                        flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag2 Then
                            MessageBox.Show("تمت حذف البيانات بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Else
                            MessageBox.Show("Deleted", "delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                        Me.clr()
                    End If
                Else
                    flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    If flag2 Then
                        MessageBox.Show("هذا الحساب غير موجود")
                    Else
                        MessageBox.Show("this account not found")
                    End If
                End If
            End If
        Catch ex3 As Exception
            MessageBox.Show(ex3.Message)
        Finally
            Dim flag2 As Boolean = Me.con.State <> ConnectionState.Closed
            If flag2 Then
                Me.con.Close()
            End If
        End Try
    End Sub

    Private Sub LoadParent()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,cast(Code as nvarchar)  + ' - ' + AName as name from Accounts_Index where Type=1 order by Code", Me.con)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.ParentCode.DataSource = dataTable
            Me.ParentCode.DisplayMember = "name"
            Me.ParentCode.ValueMember = "Code"
            Me.ParentCode.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Function GetEmpName(emp As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.con)
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

    Private Sub frmAccountsTree_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmAccountsTree.Load
        Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.loadtree()
        Me.LoadParent()
        Me.GetEmpName(MainClass.EmpNo)
        Me.AName.Focus()
    End Sub

    Private Sub loadtree()
        Try
            Me.treeView1.Nodes.Clear()
            Dim text As String = "الحسابات"
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag Then
                text = "Accounts"
            End If
            Dim node As TreeNode = Me.treeView1.Nodes.Add(text)
            Dim str As String = ""
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName,EName from Accounts_Index where ParentCode='" + str + "'", Me.con)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Me.gettreenodes(node, dataTable)
            End If
            Me.treeView1.Nodes(0).Expand()
            Try
                For Each obj As Object In Me.treeView1.Nodes(0).Nodes
                    Dim treeNode As TreeNode = CType(obj, TreeNode)
                    treeNode.Expand()
                Next
            Finally
                Dim enumerator As IEnumerator
                flag = (TypeOf enumerator Is IDisposable)
                If flag Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub gettreenodes(node As TreeNode, subnodesdt As DataTable)
        Dim num As Integer = 0
        Dim num2 As Integer = subnodesdt.Rows.Count - 1
        Dim num3 As Integer = num
        While True
            Dim num4 As Integer = num3
            Dim num5 As Integer = num2
            If num4 > num5 Then
                Exit While
            End If
            Dim text As String = subnodesdt.Rows(num3)(0).ToString() + "-" + subnodesdt.Rows(num3)(1).ToString()
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag Then
                text = subnodesdt.Rows(num3)(0).ToString() + "-" + subnodesdt.Rows(num3)(2).ToString()
            End If
            Dim node2 As TreeNode = node.Nodes.Add(text)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName,EName from Accounts_Index where ParentCode='" + subnodesdt.Rows(num3)(0).ToString() + "'", Me.con)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Me.gettreenodes(node2, dataTable)
            End If
            num3 += 1
        End While
    End Sub

    Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView1.AfterSelect
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Operators.CompareString(e.Node.Text, "الحسابات", False) <> 0
            If flag Then
                Me.clr()
                Dim text As String = e.Node.Text
                Dim length As Integer = text.IndexOf("-")
                Dim str As String = text.Substring(0, length)
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code='" + str + "'", Me.con)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Me.ID = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Code")))))
                    Me.Code.Text = dataTable.Rows(0)("Code").ToString()
                    Me.AName.Text = dataTable.Rows(0)("AName").ToString()
                    Me.EName.Text = dataTable.Rows(0)("EName").ToString()
                    Me._selectedname = dataTable.Rows(0)("AName").ToString()
                    Me.ParentCode.SelectedValue = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("ParentCode")))
                    flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Type"))) = 1)
                    If flag Then
                        Me.main.Checked = True
                        Me.panel3.Visible = False
                    Else
                        flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Type"))) = 2)
                        If flag Then
                            Me.sub1.Checked = True
                            Me.panel3.Visible = True
                            flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Nature"))) = 1)
                            If flag Then
                                Me.debt.Checked = True
                            Else
                                Me.credit.Checked = True
                            End If
                            Me.txtDate.Value = Conversions.ToDate(dataTable.Rows(0)("Date"))
                            Me.User.Text = dataTable.Rows(0)("UserName").ToString()
                            Me.IValue.Text = dataTable.Rows(0)("IValue").ToString()
                            Me.FinalAcc.SelectedIndex = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("FinalAcc"))) - 1.0))
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub treeView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles treeView1.KeyDown
        Try
            Dim flag As Boolean = e.KeyCode = Keys.[Return]
            If flag Then
                Dim selectedNode As TreeNode = Me.treeView1.SelectedNode
                flag = selectedNode.IsExpanded
                If flag Then
                    selectedNode.Collapse(True)
                Else
                    selectedNode.Expand()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub panel3_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel3.Paint
    End Sub

    Private Sub GenerateCode()
        Try
            Dim flag As Boolean = Me.ID = -1
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select max(Code) from Accounts_Index where ParentCode='", Me.ParentCode.SelectedValue), "'")), Me.con)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
                    If flag2 Then
                        Me.Code.Text = "" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) + 1.0)
                    Else
                        flag2 = Me.main.Checked
                        If flag2 Then
                            flag = MainClass.IsAccTreeNew
                            If flag Then
                                Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "01"))
                            Else
                                Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "1"))
                            End If
                        Else
                            Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "0001"))
                        End If
                    End If
                Else
                    Dim flag2 As Boolean = Me.main.Checked
                    If flag2 Then
                        flag = MainClass.IsAccTreeNew
                        If flag Then
                            Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "01"))
                        Else
                            Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "1"))
                        End If
                    Else
                        Me.Code.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("", Me.ParentCode.SelectedValue), "0001"))
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ParentCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ParentCode.SelectedIndexChanged
        Me.GenerateCode()
    End Sub

    Private Sub Code_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Code.KeyDown
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = e.KeyCode = Keys.[Return] And Operators.CompareString(Me.Code.Text.Trim(), "", False) <> 0
            If flag Then
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where Code='" + Me.Code.Text + "'", Me.con)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Me.ID = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Code")))))
                    Me.Code.Text = dataTable.Rows(0)("Code").ToString()
                    Me.AName.Text = dataTable.Rows(0)("AName").ToString()
                    Me.EName.Text = dataTable.Rows(0)("EName").ToString()
                    Me.ParentCode.SelectedValue = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("ParentCode")))
                    flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Type"))) = 1)
                    If flag Then
                        Me.main.Checked = True
                        Me.panel3.Visible = False
                    Else
                        flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Type"))) = 2)
                        If flag Then
                            Me.sub1.Checked = True
                            Me.panel3.Visible = True
                            flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Nature"))) = 1)
                            If flag Then
                                Me.debt.Checked = True
                            Else
                                Me.credit.Checked = True
                            End If
                            Me.txtDate.Value = Conversions.ToDate(dataTable.Rows(0)("Date"))
                            Me.User.Text = dataTable.Rows(0)("UserName").ToString()
                            Me.IValue.Text = dataTable.Rows(0)("IValue").ToString()
                            Me.FinalAcc.SelectedIndex = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("FinalAcc"))) - 1.0))
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
