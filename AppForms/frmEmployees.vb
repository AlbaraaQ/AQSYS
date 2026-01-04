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
Imports AQSYS.AQSYS.rptt
Imports AQSYS.My.Resources
Public Partial Class frmEmployees
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmEmployees_Load
        frmEmployees.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmEmployees.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmEmployees.__ENCList.Count = frmEmployees.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmEmployees.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmEmployees.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmEmployees.__ENCList(num) = frmEmployees.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmEmployees.__ENCList.RemoveRange(num, frmEmployees.__ENCList.Count - num)
                frmEmployees.__ENCList.Capacity = frmEmployees.__ENCList.Count
            End If
            frmEmployees.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        MainClass.CLRForm(Me)
        Me.rdMale.Checked = True
        Me.dgvBranches.Rows.Clear()
        Me.Code = -1
    End Sub

    Private Sub LoadDG(cond As String)
        Me.dgvEmps.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name,work_date,mobile,salary_basic,salary_add,salary_other,house,travel,food,medical from Employees where " + cond + " IS_Deleted=0 order by id", Me.conn)
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
            Me.dgvEmps.Rows.Add()
            Me.dgvEmps.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvEmps.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvEmps.Rows(num3).Cells(2).Value = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("salary_basic"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("salary_add"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("salary_other"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("house"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("travel"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("food"))) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("medical")))
            Me.dgvEmps.Rows(num3).Cells(3).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("work_date"))).ToShortDateString()
            Me.dgvEmps.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
            num3 += 1
        End While
        Me.dgvEmps.ClearSelection()
    End Sub

    Public Sub LoadManags()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Managements order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbManags.DataSource = dataTable
        Me.cmbManags.DisplayMember = "name"
        Me.cmbManags.ValueMember = "id"
        Me.cmbManags.SelectedIndex = -1
    End Sub

    Public Sub LoadDeps(manag As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Departments where manag_id=" + Conversions.ToString(manag) + " order by id", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbDeps.DataSource = dataTable
        Me.cmbDeps.DisplayMember = "name"
        Me.cmbDeps.ValueMember = "id"
        Me.cmbDeps.SelectedIndex = -1
    End Sub

    Public Sub LoadJobs()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from jobs order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbJob.DataSource = dataTable
        Me.cmbJob.DisplayMember = "name"
        Me.cmbJob.ValueMember = "id"
        Me.cmbJob.SelectedIndex = -1
    End Sub

    Public Sub LoadBranches()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Branches order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvBranches.Columns(0), DataGridViewComboBoxColumn)
        dataGridViewComboBoxColumn.DataSource = dataTable
        dataGridViewComboBoxColumn.DisplayMember = "name"
        dataGridViewComboBoxColumn.ValueMember = "id"
    End Sub

    Public Sub LoadNationality()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,nationality from Countries order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbNationality.DataSource = dataTable
        Me.cmbNationality.DisplayMember = "nationality"
        Me.cmbNationality.ValueMember = "id"
        Me.cmbNationality.SelectedIndex = -1
    End Sub

    Public Sub LoadMarital()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Marital_status order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbMaritalStatus.DataSource = dataTable
        Me.cmbMaritalStatus.DisplayMember = "name"
        Me.cmbMaritalStatus.ValueMember = "id"
        Me.cmbMaritalStatus.SelectedIndex = -1
    End Sub

    Public Sub LoadStates()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from States order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbStatus.DataSource = dataTable
        Me.cmbStatus.DisplayMember = "name"
        Me.cmbStatus.ValueMember = "id"
        Me.cmbStatus.SelectedIndex = -1
    End Sub

    Private Sub btnManagAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnManagAdd.Click
        Dim num As Integer = -1
        Dim flag As Boolean = Me.cmbManags.SelectedValue IsNot Nothing
        If flag Then
            num = Conversions.ToInteger(Me.cmbManags.SelectedValue)
        End If
        Dim frmManagement As frmManagement = New frmManagement()
        frmManagement.Activate()
        frmManagement.ShowDialog()
        Me.LoadManags()
        Try
            Me.cmbManags.SelectedValue = num
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub frmEmployees_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmEmployees.Load
        Me.txtBirthDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtWorkDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadManags()
        Me.LoadJobs()
        Me.LoadBranches()
        Me.LoadMarital()
        Me.LoadStates()
        Me.LoadNationality()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub cmbManags_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbManags.SelectedIndexChanged
        Try
            Me.LoadDeps(Conversions.ToInteger(Me.cmbManags.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDepAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDepAdd.Click
        Dim flag As Boolean = Me.cmbManags.SelectedValue Is Nothing
        If flag Then
            Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
            If flag2 Then
                MessageBox.Show("يجب اختيار الادارة التابع لها القسم أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("you must select management first", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Me.cmbManags.Focus()
        Else
            Dim num As Integer = -1
            Dim flag2 As Boolean = Me.cmbDeps.SelectedValue IsNot Nothing
            If flag2 Then
                num = Conversions.ToInteger(Me.cmbDeps.SelectedValue)
            End If
            Dim frmDepartments As frmDepartments = New frmDepartments()
            frmDepartments.Activate()
            frmDepartments.LoadManags()
            frmDepartments.cmbManags.SelectedValue = RuntimeHelpers.GetObjectValue(Me.cmbManags.SelectedValue)
            frmDepartments.ShowDialog()
            Me.LoadDeps(Conversions.ToInteger(Me.cmbManags.SelectedValue))
            Try
                Me.cmbDeps.SelectedValue = num
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnJobAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnJobAdd.Click
        Dim num As Integer = -1
        Dim flag As Boolean = Me.cmbJob.SelectedValue IsNot Nothing
        If flag Then
            num = Conversions.ToInteger(Me.cmbJob.SelectedValue)
        End If
        Dim frmJobs As frmJobs = New frmJobs()
        frmJobs.Activate()
        frmJobs.ShowDialog()
        Me.LoadJobs()
        Try
            Me.cmbJob.SelectedValue = num
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Me.txtName.Focus()
            Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
                If flag2 Then
                    MessageBox.Show("يجب ادخال اسم الموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("Enter employee name", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                Me.txtName.Focus()
            Else
                Dim flag2 As Boolean = Me.cmbManags.SelectedIndex = -1
                If flag2 Then
                    flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    If flag Then
                        MessageBox.Show("يجب اختيار الادارة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        MessageBox.Show("choose management", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                    Me.cmbManags.Focus()
                Else
                    flag2 = (Me.cmbDeps.SelectedIndex = -1)
                    If flag2 Then
                        flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                        If flag Then
                            MessageBox.Show("يجب اختيار القسم", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Else
                            MessageBox.Show("choose department", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                        Me.cmbDeps.Focus()
                    Else
                        flag2 = (Me.dgvBranches.Rows.Count = 1)
                        If flag2 Then
                            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag Then
                                MessageBox.Show("يجب ادخال فرع للموظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Else
                                MessageBox.Show("Enter branch for employee", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                            Me.dgvBranches.Focus()
                        Else
                            Dim num As Integer = 0
                            Dim num2 As Integer = Me.dgvBranches.Rows.Count - 2
                            Dim num3 As Integer = num
                            While True
                                Dim num4 As Integer = num3
                                Dim num5 As Integer = num2
                                If num4 > num5 Then
                                    GoTo Block_13
                                End If
                                flag2 = (Me.dgvBranches.Rows(num3).Cells(0).Value Is Nothing)
                                If flag2 Then
                                    Exit While
                                End If
                                num3 += 1
                            End While
                            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag Then
                                MessageBox.Show("لم تختر فرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Else
                                MessageBox.Show("you not choose branch", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                            Me.dgvBranches.Rows(num3).Selected = True
                            Return
Block_13:
                            Dim num6 As Integer = 0
                            Dim num7 As Integer = Me.dgvBranches.Rows.Count - 2
                            Dim num8 As Integer = num6
                            Dim num12 As Integer
                            While True
                                Dim num9 As Integer = num8
                                Dim num5 As Integer = num7
                                If num9 > num5 Then
                                    GoTo Block_17
                                End If
                                Dim num10 As Integer = num8 + 1
                                Dim num11 As Integer = Me.dgvBranches.Rows.Count - 2
                                num12 = num10
                                While True
                                    Dim num13 As Integer = num12
                                    num5 = num11
                                    If num13 > num5 Then
                                        Exit While
                                    End If
                                    flag2 = Operators.ConditionalCompareObjectEqual(Me.dgvBranches.Rows(num8).Cells(0).Value, Me.dgvBranches.Rows(num12).Cells(0).Value, False)
                                    If flag2 Then
                                        GoTo Block_14
                                    End If
                                    num12 += 1
                                End While
                                num8 += 1
                            End While
Block_14:
                            flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag Then
                                MessageBox.Show("لقد كررت ادخال الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Else
                                MessageBox.Show("you repeat the branch", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                            Me.dgvBranches.Rows(num12).Selected = True
                            Return
Block_17:
                            flag2 = (Me.conn.State <> ConnectionState.Open)
                            If flag2 Then
                                Me.conn.Open()
                            End If
                            Dim sqlCommand As SqlCommand = New SqlCommand()
                            flag2 = (Me.Code <> -1)
                            If flag2 Then
                                sqlCommand = New SqlCommand("delete from EmpBranches where emp=" + Conversions.ToString(Me.Code), Me.conn)
                                sqlCommand.ExecuteNonQuery()
                            End If
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                sqlCommand = New SqlCommand("insert into Employees(name,manag,dep,state,job,birth_date,insurance_no,work_date,marital_state,nationality,sex,tel,mobile,email,address,notes,image,salary_basic,house,travel,food,medical,salary_add,salary_other,IS_Deleted) values (@name,@manag,@dep,@state,@job,@birth_date,@insurance_no,@work_date,@marital_state,@nationality,@sex,@tel,@mobile,@email,@address,@notes,@image,@salary_basic,@house,@travel,@food,@medical,@salary_add,@salary_other,@IS_Deleted)", Me.conn)
                            Else
                                sqlCommand = New SqlCommand("update Employees set name=@name ,manag=@manag ,dep=@dep ,state=@state ,job=@job  ,birth_date=@birth_date ,insurance_no=@insurance_no ,work_date=@work_date ,marital_state=@marital_state ,nationality=@nationality ,sex=@sex ,tel=@tel ,mobile=@mobile ,email=@email ,address=@address ,notes=@notes ,image=@image ,salary_basic=@salary_basic ,house=@house, travel=@travel, food=@food, medical=@medical, salary_add=@salary_add ,salary_other=@salary_other ,IS_Deleted=@IS_Deleted where id=" + Conversions.ToString(Me.Code), Me.conn)
                            End If
                            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
                            sqlCommand.Parameters.Add("@manag", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbManags.SelectedValue)
                            sqlCommand.Parameters.Add("@dep", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbDeps.SelectedValue)
                            Dim num14 As Integer = -1
                            flag2 = (Me.cmbStatus.SelectedValue IsNot Nothing)
                            If flag2 Then
                                num14 = Conversions.ToInteger(Me.cmbStatus.SelectedValue)
                            End If
                            sqlCommand.Parameters.Add("@state", SqlDbType.Int).Value = num14
                            Dim num15 As Integer = -1
                            flag2 = (Me.cmbJob.SelectedValue IsNot Nothing)
                            If flag2 Then
                                num15 = Conversions.ToInteger(Me.cmbJob.SelectedValue)
                            End If
                            sqlCommand.Parameters.Add("@job", SqlDbType.Int).Value = num15
                            sqlCommand.Parameters.Add("@birth_date", SqlDbType.DateTime).Value = Me.txtBirthDate.Value.ToShortDateString()
                            sqlCommand.Parameters.Add("@insurance_no", SqlDbType.NVarChar).Value = Me.txtInsuranceNo.Text
                            sqlCommand.Parameters.Add("@work_date", SqlDbType.DateTime).Value = Me.txtWorkDate.Value.ToShortDateString()
                            Dim num16 As Integer = -1
                            flag2 = (Me.cmbMaritalStatus.SelectedValue IsNot Nothing)
                            If flag2 Then
                                num16 = Conversions.ToInteger(Me.cmbMaritalStatus.SelectedValue)
                            End If
                            sqlCommand.Parameters.Add("@marital_state", SqlDbType.Int).Value = num16
                            Dim num17 As Integer = -1
                            flag2 = (Me.cmbNationality.SelectedValue IsNot Nothing)
                            If flag2 Then
                                num17 = Conversions.ToInteger(Me.cmbNationality.SelectedValue)
                            End If
                            sqlCommand.Parameters.Add("@nationality", SqlDbType.Int).Value = num17
                            Dim value As String = "M"
                            flag2 = Me.rdFemale.Checked
                            If flag2 Then
                                value = "F"
                            End If
                            sqlCommand.Parameters.Add("@sex", SqlDbType.Char).Value = value
                            sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
                            sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
                            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtEmail.Text
                            sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = Me.txtAddress.Text
                            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                            flag2 = (Me.picImage.Image IsNot Nothing)
                            If flag2 Then
                                sqlCommand.Parameters.Add("@image", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picImage.Image)
                            Else
                                sqlCommand.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value
                            End If
                            sqlCommand.Parameters.Add("@salary_basic", SqlDbType.Float).Value = Conversion.Val("" + Me.txtBasicSalary.Text)
                            sqlCommand.Parameters.Add("@house", SqlDbType.Float).Value = Conversion.Val("" + Me.txtHouse.Text)
                            sqlCommand.Parameters.Add("@travel", SqlDbType.Float).Value = Conversion.Val("" + Me.txtTravel.Text)
                            sqlCommand.Parameters.Add("@food", SqlDbType.Float).Value = Conversion.Val("" + Me.txtFood.Text)
                            sqlCommand.Parameters.Add("@medical", SqlDbType.Float).Value = Conversion.Val("" + Me.txtMedical.Text)
                            sqlCommand.Parameters.Add("@salary_add", SqlDbType.Float).Value = Conversion.Val("" + Me.txtSalaryAdd.Text)
                            sqlCommand.Parameters.Add("@salary_other", SqlDbType.Float).Value = Conversion.Val("" + Me.txtSalaryOther.Text)
                            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                            sqlCommand.ExecuteNonQuery()
                            Me.LoadDG("")
                            flag2 = (Me.Code = -1)
                            If flag2 Then
                                sqlCommand = New SqlCommand("select max(id) from Employees", Me.conn)
                                Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                            End If
                            Dim num18 As Integer = 0
                            Dim num19 As Integer = Me.dgvBranches.Rows.Count - 2
                            Dim num20 As Integer = num18
                            While True
                                Dim num21 As Integer = num20
                                Dim num5 As Integer = num19
                                If num21 > num5 Then
                                    Exit While
                                End If
                                sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into EmpBranches(emp,branch)values(" + Conversions.ToString(Me.Code) + ",", Me.dgvBranches.Rows(num20).Cells(0).Value), ")")), Me.conn)
                                sqlCommand.ExecuteNonQuery()
                                num20 += 1
                            End While
                            flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                            If flag2 Then
                                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Else
                                MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Dim text As String = "خطأ أثناء الحفظ"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag2 Then
                text = "Error during saving"
                text = text + Environment.NewLine + "Error details: " + ex.Message
            End If
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub txtSalaryOther_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSalaryOther.TextChanged
        Try
            Me.txtSalaryTotal.Text = "" + Conversions.ToString(Conversion.Val("" + Me.txtBasicSalary.Text) + Conversion.Val("" + Me.txtSalaryAdd.Text) + Conversion.Val("" + Me.txtSalaryOther.Text) + Conversion.Val("" + Me.txtHouse.Text) + Conversion.Val("" + Me.txtTravel.Text) + Conversion.Val("" + Me.txtFood.Text) + Conversion.Val("" + Me.txtMedical.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim flag2 As Boolean = Me.Code = 1
                If flag2 Then
                    Interaction.MsgBox("لا يمكن حذف الموظف الرئيسي، يمكنك تعديل بياناته", MsgBoxStyle.OkOnly, Nothing)
                Else
                    Try
                        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(id) from inv where is_deleted=0 and sales_emp=" + Conversions.ToString(Me.Code), Me.conn)
                        Dim dataTable As DataTable = New DataTable()
                        sqlDataAdapter.Fill(dataTable)
                        flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
                        If flag2 Then
                            Interaction.MsgBox("هذا الموظف مرتبط بفواتير ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
                            Return
                        End If
                    Catch ex As Exception
                    End Try
                    flag2 = (Me.conn.State <> ConnectionState.Open)
                    If flag2 Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand("update Employees set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    Me.LoadDG("")
                    Me.CLR()
                    flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
                    If flag2 Then
                        MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End If
            Else
                Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
                If flag2 Then
                    MessageBox.Show("اختر موظف ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("choose employee to be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex2 As Exception
            Dim text As String = "خطأ أثناء الحذف"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
            Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
            If flag2 Then
                text = "Error during deleting"
                text = text + Environment.NewLine + "Error details: " + ex2.Message
            End If
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvDepsRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvEmps.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Employees where id=" + Conversions.ToString(Me.Code))
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgvEmps_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvEmps.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgvDepsRowChng(e.RowIndex)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim flag As Boolean = dr.HasRows
        If flag Then
            dr.Read()
            Me.CLR()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.txtName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
            flag = Operators.ConditionalCompareObjectNotEqual(dr("manag"), -1, False)
            If flag Then
                Me.cmbManags.SelectedValue = RuntimeHelpers.GetObjectValue(dr("manag"))
                Me.LoadDeps(Conversions.ToInteger(Me.cmbManags.SelectedValue))
            End If
            flag = Operators.ConditionalCompareObjectNotEqual(dr("dep"), -1, False)
            If flag Then
                Me.cmbDeps.SelectedValue = RuntimeHelpers.GetObjectValue(dr("dep"))
            End If
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("state"), -1, False)
                If flag Then
                    Me.cmbStatus.SelectedValue = RuntimeHelpers.GetObjectValue(dr("state"))
                End If
            Catch ex As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("job"), -1, False)
                If flag Then
                    Me.cmbJob.SelectedValue = RuntimeHelpers.GetObjectValue(dr("job"))
                End If
            Catch ex2 As Exception
            End Try
            Me.txtBirthDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("birth_date")))
            Me.txtInsuranceNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("insurance_no")))
            Me.txtWorkDate.Text = Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("work_date"))))
            flag = Operators.ConditionalCompareObjectNotEqual(dr("marital_state"), -1, False)
            If flag Then
                Me.cmbMaritalStatus.SelectedValue = RuntimeHelpers.GetObjectValue(dr("marital_state"))
            End If
            flag = Operators.ConditionalCompareObjectNotEqual(dr("nationality"), -1, False)
            If flag Then
                Me.cmbNationality.SelectedValue = RuntimeHelpers.GetObjectValue(dr("nationality"))
            End If
            flag = (Operators.CompareString(dr("sex").ToString(), "M", False) = 0)
            If flag Then
                Me.rdMale.Checked = True
            Else
                Me.rdFemale.Checked = True
            End If
            Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
            Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
            Me.txtEmail.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("email")))
            Me.txtAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("address")))
            Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
            flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr("image")))
            If flag Then
                Me.picImage.Image = MainClass.Arr2Image(CType(dr("image"), Byte()))
            End If
            Me.txtBasicSalary.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("salary_basic")))
            Me.txtSalaryAdd.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("salary_add")))
            Me.txtSalaryOther.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("salary_other")))
            Try
                Me.txtHouse.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("house")))
                Me.txtTravel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("travel")))
                Me.txtFood.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("food")))
                Me.txtMedical.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("medical")))
            Catch ex3 As Exception
            End Try
            dr.Close()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from EmpBranches where emp=" + Conversions.ToString(Me.Code), Me.conn)
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
                Me.dgvBranches.Rows.Add()
                Me.dgvBranches.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("branch"))
                num3 += 1
            End While
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvEmps.ClearSelection()
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
        Me.Navigate("select top 1 * from Employees where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Employees where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Employees where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Employees where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub lnkImgClr_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkImgClr.LinkClicked
        Me.picImage.Image = Nothing
    End Sub

    Private Sub lnkImgAdd_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkImgAdd.LinkClicked
        Try
            Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.picImage.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBasicSalary_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBasicSalary.KeyDown
    End Sub

    Private Sub txtBasicSalary_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBasicSalary.KeyPress
        Dim flag As Boolean = Not (Char.IsNumber(e.KeyChar) Or Strings.Asc(e.KeyChar) = 8 Or Operators.CompareString(e.KeyChar.ToString(), ".", False) = 0)
        If flag Then
            e.Handled = True
        End If
    End Sub

    Private Sub Search()
        Dim cond As String = "name like '%" + Me.txtNameSrch.Text + "%' and "
        Me.LoadDG(cond)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Me.Search()
    End Sub

    Private Sub txtNameSrch_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNameSrch.KeyPress
        Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
        If flag Then
            Me.Search()
        End If
    End Sub

    Private Sub btnNationalityAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNationalityAdd.Click
        Dim num As Integer = -1
        Dim flag As Boolean = Me.cmbNationality.SelectedValue IsNot Nothing
        If flag Then
            num = Conversions.ToInteger(Me.cmbNationality.SelectedValue)
        End If
        Dim frmCountries As frmCountries = New frmCountries()
        frmCountries.Activate()
        frmCountries.ShowDialog()
        Me.LoadNationality()
        Try
            Me.cmbNationality.SelectedValue = num
        Catch ex As Exception
        End Try
    End Sub

    Private Function GetNamByID(tbl As String, id As Integer) As String
        Dim result As String
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from " + tbl + " where id=" + Conversions.ToString(id), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                result = dataTable.Rows(0)(0).ToString()
            Else
                result = ""
            End If
        Catch ex As Exception
            result = ""
        End Try
        Return result
    End Function

    Private Function GetNationalityName(id As Integer) As String
        Dim result As String
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select nationality from Countries where id=" + Conversions.ToString(id), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                result = dataTable.Rows(0)(0).ToString()
            Else
                result = ""
            End If
        Catch ex As Exception
            result = ""
        End Try
        Return result
    End Function

    Private Sub PrintRpt(type As Integer)
        Dim dataTable As DataTable = New DataTable()
        dataTable.Columns.Add("name")
        dataTable.Columns.Add("manag")
        dataTable.Columns.Add("dep")
        dataTable.Columns.Add("job")
        dataTable.Columns.Add("branch")
        dataTable.Columns.Add("workdate")
        dataTable.Columns.Add("nationality")
        dataTable.Columns.Add("mobile")
        dataTable.Columns.Add("totsalary")
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Employees where IS_Deleted=0 order by id", Me.conn)
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
            Dim num6 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("salary_basic"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("salary_add"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("salary_other")))
            dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("name")), Me.GetNamByID("Managements", Conversions.ToInteger(dataTable2.Rows(num3)("manag"))), Me.GetNamByID("Departments", Conversions.ToInteger(dataTable2.Rows(num3)("dep"))), Me.GetNamByID("jobs", Conversions.ToInteger(dataTable2.Rows(num3)("job"))), Me.GetNamByID("branches", Conversions.ToInteger(dataTable2.Rows(num3)("branch"))), Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("work_date"))).ToShortDateString(), Me.GetNationalityName(Conversions.ToInteger(dataTable2.Rows(num3)("nationality"))), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("mobile")), num6})
            num3 += 1
        End While
        Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
        If flag Then
            obj = New rptEmployees()
        Else
            obj = New rptEmployees___EN()
        End If
        Dim instance As Object = obj
        Dim type2 As Type = Nothing
        Dim memberName As String = "SetDataSource"
        Dim array As Object() = New Object() {dataTable}
        Dim arguments As Object() = array
        Dim argumentNames As String() = Nothing
        Dim typeArguments As Type() = Nothing
        Dim array2 As Boolean() = New Boolean() {True}
        NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
        If array2(0) Then
            dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
        End If
        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
        Dim dataTable3 As DataTable = New DataTable()
        sqlDataAdapter2.Fill(dataTable3)
        Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
        Dim type3 As Type = Nothing
        Dim memberName2 As String = "SetDataSource"
        Dim array3 As Object() = New Object() {dataTable3}
        Dim arguments2 As Object() = array3
        Dim argumentNames2 As String() = Nothing
        Dim typeArguments2 As Type() = Nothing
        array2 = New Boolean() {True}
        NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
        If array2(0) Then
            dataTable3 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
        End If
        flag = (dataTable3.Rows.Count > 0)
        If flag Then
            Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
            textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
            Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
            textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Tel")))
            Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
            textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Fax")))
        End If
        Dim frmRptViewer As frmRptViewer = New frmRptViewer()
        Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
        frmRptViewer.Controls.Add(crystalReportViewer)
        crystalReportViewer.Dock = DockStyle.Fill
        crystalReportViewer.DisplayGroupTree = False
        crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
        frmRptViewer.WindowState = FormWindowState.Maximized
        flag = (type = 1)
        If flag Then
            frmRptViewer.Show()
        Else
            Try
                crystalReportViewer.ShowLastPage()
                Dim num7 As Integer = crystalReportViewer.GetCurrentPageNumber()
                crystalReportViewer.ShowFirstPage()
                Dim instance3 As Object = obj
                Dim type4 As Type = Nothing
                Dim memberName3 As String = "PrintToPrinter"
                array = New Object() {1, False, 1, num7}
                Dim arguments3 As Object() = array
                Dim argumentNames3 As String() = Nothing
                Dim typeArguments3 As Type() = Nothing
                array2 = New Boolean() {False, False, False, True}
                NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
                If array2(3) Then
                    num7 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox5.Enter
    End Sub

    Private Sub dgvBranches_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvBranches.DataError
    End Sub
End Class
