Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports AQSYS.AQSYS.rptt
Imports System.Windows.Forms
Imports AQSYS.My.Resources
Public Partial Class frmCustomers
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer

    Private _name As String

    Private _DefaultClientType As Integer

    Private _Finished As Boolean

    Private _type As Integer

    Public Shared _selectedacc As String = ""

    Private _CompletedImport As Boolean

    Private dtItems As DataTable

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCustomers_Load
        frmCustomers.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me._name = ""
        Me._DefaultClientType = 1
        Me._Finished = False
        Me._type = 1
        Me._CompletedImport = False
        Me.dtItems = New DataTable()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCustomers.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCustomers.__ENCList.Count = frmCustomers.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCustomers.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCustomers.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCustomers.__ENCList(num) = frmCustomers.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCustomers.__ENCList.RemoveRange(num, frmCustomers.__ENCList.Count - num)
                frmCustomers.__ENCList.Capacity = frmCustomers.__ENCList.Count
            End If
            frmCustomers.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Shared Sub New()
    End Sub

    Private Sub CLR()
        MainClass.CLRForm(Me)
        Me.chkJoinDate.Checked = False
        Me.chkMaintDate.Checked = False
        Dim value As String = "123"
        Dim flag As Boolean = Me.rdSupplier.Checked
        If flag Then
            value = "261"
        End If
        flag = MainClass.IsAccTreeNew
        If flag Then
            value = "110302"
            flag = Me.rdSupplier.Checked
            If flag Then
                value = "210011"
            End If
        End If
        Me.txtAccCode.Text = MainClass.GenerateCode(Conversions.ToInteger(value))
        Try
            Me.cmbCountry.SelectedValue = 1
        Catch ex As Exception
        End Try
        Me.LoadNextNo()
        flag = (Me._DefaultClientType = 2)
        If flag Then
            Me.rdCustCash.Checked = True
        Else
            Me.rdCustPerm.Checked = True
        End If
        Me.Code = -1
        Me._name = ""
    End Sub

    Private Sub LoadNextNo()
        Try
            Dim value As Integer = 1
            Dim flag As Boolean = Me.rdSupplier.Checked
            If flag Then
                value = 2
            End If
            Dim value2 As Integer = 1
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(cust_no) from Customers where type=" + Conversions.ToString(value), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            flag = (dataTable.Rows.Count > 0)
            If flag Then
                Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
                If flag2 Then
                    ' The following expression was wrapped in a checked-expression
                    value2 = Convert.ToInt32(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1
                End If
            End If
            Me.txtNo.Text = "" + Conversions.ToString(value2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadDG(cond As String)
        ' The following expression was wrapped in a checked-statement
        Try
            Me.dgvCustomers.Rows.Clear()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Customers where " + cond + " IS_Deleted=0 order by id", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.ProgressBar2.Value = 0
            Me.ProgressBar2.Maximum = dataTable.Rows.Count
            Dim num As Integer = 0
            Dim num2 As Integer = dataTable.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                Me.dgvCustomers.Rows.Add()
                Me.dgvCustomers.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
                Me.dgvCustomers.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
                Me.dgvCustomers.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("national_id"))
                Me.dgvCustomers.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
                Me.dgvCustomers.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
                Dim value As String = ""
                Try
                    Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num3)("country"), -1, False)
                    If flag Then
                        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from Countries where id=", dataTable.Rows(num3)("country"))), Me.conn)
                        Dim dataTable2 As DataTable = New DataTable()
                        sqlDataAdapter2.Fill(dataTable2)
                        flag = (dataTable2.Rows.Count > 0)
                        If flag Then
                            value = dataTable2.Rows(0)(0).ToString()
                        End If
                    End If
                Catch ex As Exception
                End Try
                Me.dgvCustomers.Rows(num3).Cells(5).Value = value
                Dim value2 As String = ""
                Try
                    Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num3)("city"), -1, False)
                    If flag Then
                        Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from Cities where id=", dataTable.Rows(num3)("city"))), Me.conn)
                        Dim dataTable3 As DataTable = New DataTable()
                        sqlDataAdapter3.Fill(dataTable3)
                        flag = (dataTable3.Rows.Count > 0)
                        If flag Then
                            value2 = dataTable3.Rows(0)(0).ToString()
                        End If
                    End If
                Catch ex2 As Exception
                End Try
                Me.dgvCustomers.Rows(num3).Cells(6).Value = value2
                Dim value3 As String = ""
                Try
                    Dim flag As Boolean = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num3)("area"), -1, False)
                    If flag Then
                        Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from areas where id=", dataTable.Rows(num3)("area"))), Me.conn)
                        Dim dataTable4 As DataTable = New DataTable()
                        sqlDataAdapter4.Fill(dataTable4)
                        flag = (dataTable4.Rows.Count > 0)
                        If flag Then
                            value3 = dataTable4.Rows(0)(0).ToString()
                        End If
                    End If
                Catch ex3 As Exception
                End Try
                Me.dgvCustomers.Rows(num3).Cells(7).Value = value3
                Me.ProgressBar2.Value = num3 + 1
                num3 += 1
            End While
            Me.dgvCustomers.ClearSelection()
        Catch ex4 As Exception
        Finally
            Me._Finished = True
        End Try
    End Sub

    Public Sub LoadCountries()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Countries order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCountry.DataSource = dataTable
        Me.cmbCountry.DisplayMember = "name"
        Me.cmbCountry.ValueMember = "id"
        Me.cmbCountry.SelectedIndex = -1
    End Sub

    Public Sub LoadActs()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Acts order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbActs.DataSource = dataTable
        Me.cmbActs.DisplayMember = "name"
        Me.cmbActs.ValueMember = "id"
        Me.cmbActs.SelectedIndex = -1
    End Sub

    Public Sub LoadCities(country As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Cities where country=" + Conversions.ToString(country) + " order by id", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbCity.DataSource = dataTable
        Me.cmbCity.DisplayMember = "name"
        Me.cmbCity.ValueMember = "id"
        Me.cmbCity.SelectedIndex = -1
    End Sub

    Public Sub LoadAreas(city As Integer)
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from areas where city=" + Conversions.ToString(city) + " order by id", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbArea.DataSource = dataTable
        Me.cmbArea.DisplayMember = "name"
        Me.cmbArea.ValueMember = "id"
        Me.cmbArea.SelectedIndex = -1
    End Sub

    Private Sub cmbCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCountry.SelectedIndexChanged
        Try
            Me.cmbArea.DataSource = Nothing
            Me.cmbCity.DataSource = Nothing
            Me.LoadCities(Conversions.ToInteger(Me.cmbCountry.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCity.SelectedIndexChanged
        Try
            Me.cmbArea.DataSource = Nothing
            Me.LoadAreas(Conversions.ToInteger(Me.cmbCity.SelectedValue))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub frmCustomers_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmCustomers.Load
        Me.LoadCountries()
        Me.LoadActs()
        Dim flag As Boolean
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select clienttype_default from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me._DefaultClientType = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("clienttype_default")))
            flag = (Me._DefaultClientType = 2)
            If flag Then
                Me.rdCustCash.Checked = True
            End If
        Catch ex As Exception
        End Try
        Try
            flag = Not Me.btnPrint.Enabled
            If flag Then
                Me.btnPrintSupp.Enabled = False
            End If
        Catch ex2 As Exception
        End Try
        Dim value As String = "123"
        flag = Me.rdSupplier.Checked
        If flag Then
            value = "261"
        End If
        flag = MainClass.IsAccTreeNew
        If flag Then
            value = "110302"
            flag = Me.rdSupplier.Checked
            If flag Then
                value = "210011"
            End If
        End If
        Me.txtAccCode.Text = MainClass.GenerateCode(Conversions.ToInteger(value))
        Me.LoadNextNo()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag2 As Boolean
            Try
                Dim flag As Boolean = Me.rdClient.Checked
                If flag Then
                    flag2 = (MainClass.IsTrial And Me.Code = -1)
                    If flag2 Then
                        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Customers where type=1", Me.conn1)
                        Dim dataTable As DataTable = New DataTable()
                        sqlDataAdapter.Fill(dataTable)
                        flag2 = (dataTable.Rows.Count >= 10)
                        If flag2 Then
                            Dim text As String = "لقد وصلت لأقصى حد ادخال للنسخة التجريبية، يمكنك شراء البرنامج وتفعيله من خلال بيانات الدعم الفني بالبرنامج"
                            flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                            If flag2 Then
                                text = "you reach the maximum of entries, you can purchase the app and activate it from support data in the app"
                            End If
                            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Return
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
            Try
                flag2 = (Me.Code = -1)
                If flag2 Then
                    Dim value As Integer = 1
                    flag2 = Me.rdSupplier.Checked
                    If flag2 Then
                        value = 2
                    End If
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select cust_no from customers where cust_no=" + Conversions.ToString(Conversion.Val(Me.txtNo.Text)) + " and type=" + Conversions.ToString(value), Me.conn)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag2 = (dataTable2.Rows.Count > 0)
                    If flag2 Then
                        MessageBox.Show("هذا الرقم مدخل مسبقاً", "")
                        Me.txtNo.Focus()
                        Return
                    End If
                End If
            Catch ex2 As Exception
            End Try
            Try
                flag2 = (Me.Code = -1)
                If flag2 Then
                    Dim flag As Boolean = Operators.CompareString(Me.txtTel.Text.Trim(), "", False) <> 0
                    If flag Then
                        Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select * from customers where is_deleted=0 and (tel='", Me.txtTel.Text.Trim(), "' or mobile='", Me.txtTel.Text.Trim(), "')"}), Me.conn)
                        Dim dataTable3 As DataTable = New DataTable()
                        sqlDataAdapter3.Fill(dataTable3)
                        flag2 = (dataTable3.Rows.Count > 0)
                        If flag2 Then
                            MessageBox.Show("رقم الجوال مسجل من قبل", "")
                            Me.txtTel.Focus()
                            Return
                        End If
                    End If
                    flag2 = (Operators.CompareString(Me.txtMobile.Text.Trim(), "", False) <> 0)
                    If flag2 Then
                        Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select * from customers where is_deleted=0 and (tel='", Me.txtMobile.Text.Trim(), "' or mobile='", Me.txtMobile.Text.Trim(), "')"}), Me.conn)
                        Dim dataTable4 As DataTable = New DataTable()
                        sqlDataAdapter4.Fill(dataTable4)
                        flag2 = (dataTable4.Rows.Count > 0)
                        If flag2 Then
                            MessageBox.Show("رقم الجوال مسجل من قبل", "")
                            Me.txtMobile.Focus()
                            Return
                        End If
                    End If
                Else
                    flag2 = (Operators.CompareString(Me.txtTel.Text.Trim(), "", False) <> 0)
                    If flag2 Then
                        Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select * from customers where id<>", Conversions.ToString(Me.Code), " and is_deleted=0 and (tel='", Me.txtTel.Text.Trim(), "' or mobile='", Me.txtTel.Text.Trim(), "')"}), Me.conn)
                        Dim dataTable5 As DataTable = New DataTable()
                        sqlDataAdapter5.Fill(dataTable5)
                        flag2 = (dataTable5.Rows.Count > 0)
                        If flag2 Then
                            MessageBox.Show("رقم الجوال مسجل من قبل", "")
                            Me.txtTel.Focus()
                            Return
                        End If
                    End If
                    flag2 = (Operators.CompareString(Me.txtMobile.Text.Trim(), "", False) <> 0)
                    If flag2 Then
                        Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select * from customers where id<>", Conversions.ToString(Me.Code), " and is_deleted=0 and (tel='", Me.txtMobile.Text.Trim(), "' or mobile='", Me.txtMobile.Text.Trim(), "')"}), Me.conn)
                        Dim dataTable6 As DataTable = New DataTable()
                        sqlDataAdapter6.Fill(dataTable6)
                        flag2 = (dataTable6.Rows.Count > 0)
                        If flag2 Then
                            MessageBox.Show("رقم الجوال مسجل من قبل", "")
                            Me.txtMobile.Focus()
                            Return
                        End If
                    End If
                End If
            Catch ex3 As Exception
            End Try
            Try
                flag2 = Me.rdSupplier.Checked
                If flag2 Then
                    Dim flag As Boolean = MainClass.IsTrial And Me.Code = -1
                    If flag Then
                        Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter("select id from Customers where type=2", Me.conn1)
                        Dim dataTable7 As DataTable = New DataTable()
                        sqlDataAdapter7.Fill(dataTable7)
                        flag2 = (dataTable7.Rows.Count >= 10)
                        If flag2 Then
                            Dim text2 As String = "لقد وصلت لأقصى حد ادخال للنسخة التجريبية، يمكنك شراء البرنامج وتفعيله من خلال بيانات الدعم الفني بالبرنامج"
                            flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                            If flag2 Then
                                text2 = "you reach the maximum of entries, you can purchase the app and activate it from support data in the app"
                            End If
                            MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Return
                        End If
                    End If
                End If
            Catch ex4 As Exception
            End Try
            Me.txtNo.Focus()
            flag2 = (Me.conn.State <> ConnectionState.Open)
            If flag2 Then
                Me.conn.Open()
            End If
            Dim num As Integer = 1
            flag2 = Me.rdSupplier.Checked
            If flag2 Then
                num = 2
            End If
            Dim num2 As Integer = 1
            flag2 = Me.rdCustCash.Checked
            If flag2 Then
                num2 = 2
            End If
            Dim sqlCommand As SqlCommand = New SqlCommand()
            flag2 = (Me.Code = -1)
            If flag2 Then
                Dim sqlDataAdapter8 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id from Customers where type=", Conversions.ToString(num), " and name='", Me.txtName.Text.Trim(), "'"}), Me.conn1)
                Dim dataTable8 As DataTable = New DataTable()
                sqlDataAdapter8.Fill(dataTable8)
                flag2 = (dataTable8.Rows.Count > 0)
                If flag2 Then
                    Interaction.MsgBox("هذا الإسم مدخل من قبل", MsgBoxStyle.OkOnly, Nothing)
                    Me.txtName.Focus()
                    Return
                End If
                sqlCommand = New SqlCommand("insert into Customers(cust_no,cust_type,name,nameEN,country,city,area,act,national_id,tel,mobile,fax,email,address,notes,type,tax_no,join_date,maint_date,credit_limit,IS_Deleted,street,gov,city_name,area_name,street_EN,gov_EN,city_EN,area_EN,build_no,post_code,add_no,crn_no,cr) values (@cust_no,@cust_type,@name,@nameEN,@country,@city,@area,@act,@national_id,@tel,@mobile,@fax,@email,@address,@notes,@type,@tax_no,@join_date,@maint_date,@credit_limit,@IS_Deleted,@street,@gov,@city_name,@area_name,@street_EN,@gov_EN,@city_EN,@area_EN,@build_no,@post_code,@add_no,@crn_no,@cr)", Me.conn)
            Else
                sqlCommand = New SqlCommand("update Customers set cust_no=@cust_no,cust_type=@cust_type,name=@name,nameEN=@nameEN,country=@country,city=@city,area=@area,act=@act,national_id=@national_id,tel=@tel,mobile=@mobile,fax=@fax,email=@email,address=@address,notes=@notes,type=@type,tax_no=@tax_no,join_date=@join_date,maint_date=@maint_date,credit_limit=@credit_limit,street=@street,gov=@gov,city_name=@city_name,area_name=@area_name,street_EN=@street_EN,gov_EN=@gov_EN,city_EN=@city_EN,area_EN=@area_EN,build_no=@build_no,post_code=@post_code,add_no=@add_no,crn_no=@crn_no,cr=@cr where id=" + Conversions.ToString(Me.Code), Me.conn)
            End If
            sqlCommand.Parameters.Add("@cust_no", SqlDbType.Int).Value = Conversion.Val(Me.txtNo.Text)
            sqlCommand.Parameters.Add("@cust_type", SqlDbType.Int).Value = num2
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
            sqlCommand.Parameters.Add("@nameEN", SqlDbType.NVarChar).Value = Me.txtNameEN.Text
            Dim num3 As Integer = -1
            flag2 = (Me.cmbCountry.SelectedValue IsNot Nothing)
            If flag2 Then
                num3 = Conversions.ToInteger(Me.cmbCountry.SelectedValue)
            End If
            sqlCommand.Parameters.Add("@country", SqlDbType.Int).Value = num3
            Dim num4 As Integer = -1
            flag2 = (Me.cmbCity.SelectedValue IsNot Nothing)
            If flag2 Then
                num4 = Conversions.ToInteger(Me.cmbCity.SelectedValue)
            End If
            sqlCommand.Parameters.Add("@city", SqlDbType.Int).Value = num4
            Dim num5 As Integer = -1
            flag2 = (Me.cmbArea.SelectedValue IsNot Nothing)
            If flag2 Then
                num5 = Conversions.ToInteger(Me.cmbArea.SelectedValue)
            End If
            sqlCommand.Parameters.Add("@area", SqlDbType.Int).Value = num5
            Dim num6 As Integer = -1
            flag2 = (Me.cmbActs.SelectedValue IsNot Nothing)
            If flag2 Then
                num6 = Conversions.ToInteger(Me.cmbActs.SelectedValue)
            End If
            sqlCommand.Parameters.Add("@act", SqlDbType.Int).Value = num6
            sqlCommand.Parameters.Add("@national_id", SqlDbType.NVarChar).Value = Me.txtNationalID.Text
            sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
            sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
            sqlCommand.Parameters.Add("@fax", SqlDbType.NVarChar).Value = Me.txtFax.Text
            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtEmail.Text
            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
            sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = num
            sqlCommand.Parameters.Add("@tax_no", SqlDbType.NVarChar).Value = Me.txtTaxNo.Text
            sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = Me.txtAddress.Text
            flag2 = Me.chkJoinDate.Checked
            If flag2 Then
                sqlCommand.Parameters.Add("@join_date", SqlDbType.DateTime).Value = Me.txtJoinDate.Value.ToShortDateString()
            Else
                sqlCommand.Parameters.Add("@join_date", SqlDbType.DateTime).Value = DBNull.Value
            End If
            flag2 = Me.chkMaintDate.Checked
            If flag2 Then
                sqlCommand.Parameters.Add("@maint_date", SqlDbType.DateTime).Value = Me.txtLastMaint.Value.ToShortDateString()
            Else
                sqlCommand.Parameters.Add("@maint_date", SqlDbType.DateTime).Value = DBNull.Value
            End If
            sqlCommand.Parameters.Add("@credit_limit", SqlDbType.Float).Value = Conversion.Val(Me.txtCreditLimit.Text)
            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
            sqlCommand.Parameters.Add("@street", SqlDbType.NVarChar).Value = Me.txtStreet.Text
            sqlCommand.Parameters.Add("@gov", SqlDbType.NVarChar).Value = Me.txtGov.Text
            sqlCommand.Parameters.Add("@city_name", SqlDbType.NVarChar).Value = Me.txtCity.Text
            sqlCommand.Parameters.Add("@area_name", SqlDbType.NVarChar).Value = Me.txtArea.Text
            sqlCommand.Parameters.Add("@street_EN", SqlDbType.NVarChar).Value = Me.txtStreetEN.Text
            sqlCommand.Parameters.Add("@gov_EN", SqlDbType.NVarChar).Value = Me.txtGovEN.Text
            sqlCommand.Parameters.Add("@city_EN", SqlDbType.NVarChar).Value = Me.txtCityEN.Text
            sqlCommand.Parameters.Add("@area_EN", SqlDbType.NVarChar).Value = Me.txtAreaEN.Text
            sqlCommand.Parameters.Add("@build_no", SqlDbType.NVarChar).Value = Me.txtBuildNo.Text
            sqlCommand.Parameters.Add("@post_code", SqlDbType.NVarChar).Value = Me.txtPostCode.Text
            sqlCommand.Parameters.Add("@add_no", SqlDbType.NVarChar).Value = Me.txtAddNo.Text
            sqlCommand.Parameters.Add("@crn_no", SqlDbType.NVarChar).Value = Me.txtCRN.Text
            sqlCommand.Parameters.Add("@cr", SqlDbType.NVarChar).Value = Me.txtCR.Text
            sqlCommand.ExecuteNonQuery()
            Dim text3 As String = "123"
            flag2 = Me.rdSupplier.Checked
            If flag2 Then
                text3 = "261"
            End If
            flag2 = MainClass.IsAccTreeNew
            If flag2 Then
                text3 = "110302"
                flag2 = Me.rdSupplier.Checked
                If flag2 Then
                    text3 = "210011"
                End If
            End If
            flag2 = (Me.Code = -1 And Me.rdCustPerm.Checked)
            If flag2 Then
                flag2 = Me.debt.Checked
                Dim value2 As Integer
                If flag2 Then
                    value2 = 1
                Else
                    value2 = 2
                End If
                Dim sqlDataAdapter9 As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where code='" + Me.txtAccCode.Text + "'", Me.conn)
                Dim dataTable9 As DataTable = New DataTable()
                sqlDataAdapter9.Fill(dataTable9)
                flag2 = (dataTable9.Rows.Count = 0)
                If flag2 Then
                    sqlCommand = New SqlCommand(String.Concat(New String() {"insert into Accounts_Index(Code,AName,Type,ParentCode,FinalAcc,Acc_branch,Nature,IValue,date) values ('", Me.txtAccCode.Text, "','", Me.txtName.Text, "',2,'", text3, "',1,", Conversions.ToString(MainClass.BranchNo), ",", Conversions.ToString(value2), ",", Conversions.ToString(Conversion.Val(Me.IValue.Text)), ",@date)"}), Me.conn)
                    sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                    sqlCommand.ExecuteNonQuery()
                End If
            Else
                flag2 = (Me.Code <> -1)
                If flag2 Then
                    flag2 = Me.debt.Checked
                    Dim value3 As Integer
                    If flag2 Then
                        value3 = 1
                    Else
                        value3 = 2
                    End If
                    Dim sqlDataAdapter10 As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where AName='" + Me._name + "'", Me.conn)
                    Dim dataTable10 As DataTable = New DataTable()
                    sqlDataAdapter10.Fill(dataTable10)
                    flag2 = (dataTable10.Rows.Count > 0)
                    If flag2 Then
                        sqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update Accounts_Index set AName='" + Me.txtName.Text + "',Nature=" + Conversions.ToString(value3) + ",IValue=" + Conversions.ToString(Conversion.Val(Me.IValue.Text)) + " where Code='", dataTable10.Rows(0)("Code")), "'")), Me.conn)
                        sqlCommand.ExecuteNonQuery()
                    Else
                        flag2 = Me.rdCustPerm.Checked
                        If flag2 Then
                            sqlCommand = New SqlCommand(String.Concat(New String() {"insert into Accounts_Index(Code,AName,Type,ParentCode,FinalAcc,Acc_branch,Nature,IValue,date) values ('", Me.txtAccCode.Text, "','", Me.txtName.Text, "',2,'", text3, "',1,", Conversions.ToString(MainClass.BranchNo), ",", Conversions.ToString(value3), ",", Conversions.ToString(Conversion.Val(Me.IValue.Text)), ",@date)"}), Me.conn)
                            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                            sqlCommand.ExecuteNonQuery()
                        End If
                    End If
                End If
            End If
            MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.CLR()
        Catch ex5 As Exception
            Dim text4 As String = "خطأ أثناء الحفظ"
            text4 = text4 + Environment.NewLine + "تفاصيل الخطأ: " + ex5.Message
            MessageBox.Show(text4, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim dialogResult As DialogResult = MessageBox.Show("هل أنت متأكد من الحذف؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                flag = (dialogResult = DialogResult.No)
                If Not flag Then
                    Try
                        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(id) from inv where is_deleted=0 and cust_id=" + Conversions.ToString(Me.Code), Me.conn)
                        Dim dataTable As DataTable = New DataTable()
                        sqlDataAdapter.Fill(dataTable)
                        flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
                        If flag Then
                            Interaction.MsgBox("هذا العميل/المورد مرتبط بفواتير ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
                            Return
                        End If
                    Catch ex As Exception
                    End Try
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand("update Customers set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where Type=2 and AName='" + Me.txtName.Text + "'", Me.conn)
                    Dim dataTable2 As DataTable = New DataTable()
                    sqlDataAdapter2.Fill(dataTable2)
                    flag = (dataTable2.Rows.Count > 0)
                    If flag Then
                        ' The following expression was wrapped in a checked-expression
                        Dim value As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))))
                        sqlCommand = New SqlCommand("delete from Accounts_Index where Code=" + Conversions.ToString(value), Me.conn)
                        sqlCommand.ExecuteNonQuery()
                    End If
                    Me.CLR()
                    MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                MessageBox.Show("اختر عميل ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex2 As Exception
            Dim text As String = "خطأ أثناء الحذف"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgvDepsRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvCustomers.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Customers where id=" + Conversions.ToString(Me.Code))
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgvCustomers_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
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
            Me.txtNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("cust_no")))
            Me.txtName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
            Me._name = Conversions.ToString(Operators.ConcatenateObject("", dr("name")))
            Try
                Me.txtNameEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("nameEN")))
            Catch ex As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectEqual(dr("cust_type"), 2, False)
                If flag Then
                    Me.rdCustCash.Checked = True
                End If
            Catch ex2 As Exception
            End Try
            Try
                Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where AName='" + Me._name + "'", Me.conn)
                Dim dataTable As DataTable = New DataTable()
                sqlDataAdapter.Fill(dataTable)
                flag = (dataTable.Rows.Count > 0)
                If flag Then
                    Me.IValue.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("IValue")))
                    flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("Nature"), 1, False)
                    If flag Then
                        Me.debt.Checked = True
                    Else
                        Me.credit.Checked = True
                    End If
                End If
            Catch ex3 As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("country"), -1, False)
                If flag Then
                    Me.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(dr("country"))
                    Me.LoadCities(Conversions.ToInteger(Me.cmbCountry.SelectedValue))
                End If
            Catch ex4 As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("city"), -1, False)
                If flag Then
                    Me.cmbCity.SelectedValue = RuntimeHelpers.GetObjectValue(dr("city"))
                    Me.LoadAreas(Conversions.ToInteger(Me.cmbCity.SelectedValue))
                End If
            Catch ex5 As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("area"), -1, False)
                If flag Then
                    Me.cmbArea.SelectedValue = RuntimeHelpers.GetObjectValue(dr("area"))
                End If
            Catch ex6 As Exception
            End Try
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("act"), -1, False)
                If flag Then
                    Me.cmbActs.SelectedValue = RuntimeHelpers.GetObjectValue(dr("act"))
                End If
            Catch ex7 As Exception
            End Try
            Me.txtNationalID.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("national_id")))
            Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
            Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
            Me.txtEmail.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("email")))
            Me.txtFax.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("fax")))
            Me.txtAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("address")))
            Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
            Me.rdClient.Checked = True
            Try
                flag = Operators.ConditionalCompareObjectEqual(dr("type"), 2, False)
                If flag Then
                    Me.rdSupplier.Checked = True
                End If
            Catch ex8 As Exception
            End Try
            Try
                Me.txtTaxNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tax_no")))
            Catch ex9 As Exception
            End Try
            Try
                Me.txtCustDisc.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("discount_balance")))
            Catch ex10 As Exception
            End Try
            Try
                Me.txtJoinDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("join_date")))
                Me.chkJoinDate.Checked = True
            Catch ex11 As Exception
                Me.chkJoinDate.Checked = False
            End Try
            Try
                Me.txtLastMaint.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("maint_date")))
                Me.chkMaintDate.Checked = True
            Catch ex12 As Exception
                Me.chkMaintDate.Checked = False
            End Try
            Try
                Me.txtCreditLimit.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("credit_limit")))
            Catch ex13 As Exception
            End Try
            Try
                Me.txtStreet.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("street")))
                Me.txtGov.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("gov")))
                Me.txtCity.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("city_name")))
                Me.txtArea.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("area_name")))
                Me.txtStreetEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("street_EN")))
                Me.txtGovEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("gov_EN")))
                Me.txtCityEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("city_EN")))
                Me.txtAreaEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("area_EN")))
                Me.txtBuildNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("build_no")))
                Me.txtPostCode.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("post_code")))
                Me.txtAddNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("add_no")))
                Me.txtCRN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("crn_no")))
            Catch ex14 As Exception
            End Try
            Try
                Me.txtCR.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("cr")))
            Catch ex15 As Exception
            End Try
            dr.Close()
            Try
                Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where ANAME='" + Me.txtName.Text + "'", Me.conn)
                Dim dataTable2 As DataTable = New DataTable()
                sqlDataAdapter2.Fill(dataTable2)
                flag = (dataTable2.Rows.Count > 0)
                If flag Then
                    Me.txtAccCode.Text = dataTable2.Rows(0)(0).ToString()
                End If
                Me.txtAccCode.[ReadOnly] = True
            Catch ex16 As Exception
            End Try
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvCustomers.ClearSelection()
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
        Me.Navigate("select top 1 * from customers where type=" + Conversions.ToString(Me._type) + " and IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate(String.Concat(New String() {"select top 1 * from customers where type=", Conversions.ToString(Me._type), " and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc"}))
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from customers where type=" + Conversions.ToString(Me._type) + " and IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate(String.Concat(New String() {"select top 1 * from customers where type=", Conversions.ToString(Me._type), " and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc"}))
    End Sub

    Private Sub Search()
        Dim cond As String = "name like '%" + Me.txtNameSrch.Text + "%' and "
        Me.LoadDG(cond)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Me._Finished = False
        Me.timer1.Enabled = True
        Me.dgvCustomers.ScrollBars = ScrollBars.None
        'Dim thread As Thread = AddressOf Me.Search
        Dim th As New Thread(AddressOf Me.Search)
        th.IsBackground = True
        th.Start()
    End Sub

    Private Sub txtNameSrch_KeyPress_1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNameSrch.KeyPress
        Dim flag As Boolean = Strings.Asc(e.KeyChar) = 13
        If flag Then
            Me.Search()
        End If
    End Sub

    Private Sub btnCountryAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCountryAdd.Click
        Dim num As Integer = -1
        Dim flag As Boolean = Me.cmbCountry.SelectedValue IsNot Nothing
        If flag Then
            num = Conversions.ToInteger(Me.cmbCountry.SelectedValue)
        End If
        Dim frmCountries As frmCountries = New frmCountries()
        frmCountries.Activate()
        frmCountries.ShowDialog()
        Me.LoadCountries()
        Try
            Me.cmbCountry.SelectedValue = num
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCityAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCityAdd.Click
        Dim flag As Boolean = Me.cmbCountry.SelectedValue Is Nothing
        If flag Then
            MessageBox.Show("يجب اختيار الدولة التابع لها المدينة أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbCountry.Focus()
        Else
            Dim num As Integer = -1
            flag = (Me.cmbCity.SelectedValue IsNot Nothing)
            If flag Then
                num = Conversions.ToInteger(Me.cmbCity.SelectedValue)
            End If
            Dim frmCities As frmCities = New frmCities()
            frmCities.Activate()
            frmCities.LoadCountries()
            frmCities.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(Me.cmbCountry.SelectedValue)
            frmCities.ShowDialog()
            Me.LoadCities(Conversions.ToInteger(Me.cmbCountry.SelectedValue))
            Try
                Me.cmbCity.SelectedValue = num
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnAreaAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAreaAdd.Click
        Dim flag As Boolean = Me.cmbCountry.SelectedValue Is Nothing
        If flag Then
            MessageBox.Show("يجب اختيار الدولة التابع لها المنطقة أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbCountry.Focus()
        Else
            flag = (Me.cmbCity.SelectedValue Is Nothing)
            If flag Then
                MessageBox.Show("يجب اختيار المدينة التابع لها المنطقة أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbCity.Focus()
            Else
                Dim num As Integer = -1
                flag = (Me.cmbArea.SelectedValue IsNot Nothing)
                If flag Then
                    num = Conversions.ToInteger(Me.cmbArea.SelectedValue)
                End If
                Dim frmAreas As frmAreas = New frmAreas()
                frmAreas.Activate()
                frmAreas.LoadCountries()
                frmAreas.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(Me.cmbCountry.SelectedValue)
                frmAreas.LoadCities(Conversions.ToInteger(Me.cmbCountry.SelectedValue))
                frmAreas.cmbCity.SelectedValue = RuntimeHelpers.GetObjectValue(Me.cmbCity.SelectedValue)
                frmAreas.ShowDialog()
                Me.LoadAreas(Conversions.ToInteger(Me.cmbCity.SelectedValue))
                Try
                    Me.cmbArea.SelectedValue = num
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnActAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActAdd.Click
        Dim num As Integer = -1
        Dim flag As Boolean = Me.cmbActs.SelectedValue IsNot Nothing
        If flag Then
            num = Conversions.ToInteger(Me.cmbActs.SelectedValue)
        End If
        Dim frmActs As frmActs = New frmActs()
        frmActs.Activate()
        frmActs.ShowDialog()
        Me.LoadActs()
        Try
            Me.cmbActs.SelectedValue = num
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
        dataTable.Columns.Add("ID")
        dataTable.Columns.Add("tel")
        dataTable.Columns.Add("mobile")
        dataTable.Columns.Add("country")
        dataTable.Columns.Add("city")
        dataTable.Columns.Add("area")
        dataTable.Columns.Add("act")
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Customers where type=" + Conversions.ToString(type) + " and IS_Deleted=0 order by id", Me.conn)
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
            dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("name")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("cust_no")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("tel")), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("mobile")), Me.GetNamByID("countries", Conversions.ToInteger(dataTable2.Rows(num3)("country"))), Me.GetNamByID("cities", Conversions.ToInteger(dataTable2.Rows(num3)("city"))), Me.GetNamByID("areas", Conversions.ToInteger(dataTable2.Rows(num3)("area"))), RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)("notes"))})
            num3 += 1
        End While
        Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
        Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
        If flag Then
            obj = New rptCustomers()
        Else
            obj = New rptCustomers___EN()
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
        Try
            flag = (type = 2)
            If flag Then
                Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtHeader"}, Nothing, Nothing, Nothing), TextObject)
                textObject.Text = "الموردين"
            End If
        Catch ex As Exception
        End Try
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
            Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
            textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
            Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
            textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Tel")))
            Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
            textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
            Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
            textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Fax")))
        End If
        Dim frmRptViewer As frmRptViewer = New frmRptViewer()
        Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
        frmRptViewer.Controls.Add(crystalReportViewer)
        crystalReportViewer.Dock = DockStyle.Fill
        crystalReportViewer.DisplayGroupTree = False
        crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
        frmRptViewer.WindowState = FormWindowState.Maximized
        flag = (type = 1 Or type = 2)
        If flag Then
            frmRptViewer.Show()
        Else
            Try
                crystalReportViewer.ShowLastPage()
                Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
                crystalReportViewer.ShowFirstPage()
                Dim instance3 As Object = obj
                Dim type4 As Type = Nothing
                Dim memberName3 As String = "PrintToPrinter"
                array = New Object() {1, False, 1, num6}
                Dim arguments3 As Object() = array
                Dim argumentNames3 As String() = Nothing
                Dim typeArguments3 As Type() = Nothing
                array2 = New Boolean() {False, False, False, True}
                NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
                If array2(3) Then
                    num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
                End If
            Catch ex2 As Exception
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Dim flag As Boolean = True
        Dim flag3 As Boolean
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select print_clients_pwd from users where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag2 As Boolean = Operators.CompareString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)).ToString().Trim(), "", False) <> 0
            If flag2 Then
                flag = False
                Dim frmPWD As frmPWD = New frmPWD()
                frmPWD.ShowDialog()
                flag2 = frmPWD.IsOK
                If flag2 Then
                    flag3 = Operators.ConditionalCompareObjectEqual(frmPWD.txtPWD.Text, Operators.ConcatenateObject("", dataTable.Rows(0)(0)), False)
                    If Not flag3 Then
                        Interaction.MsgBox("خطأ في كلمة المرور", MsgBoxStyle.OkOnly, Nothing)
                        Return
                    End If
                    flag = True
                End If
            End If
        Catch ex As Exception
        End Try
        flag3 = flag
        If flag3 Then
            Me.PrintRpt(1)
        End If
    End Sub

    Private Sub txtNationalID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNationalID.TextChanged
    End Sub

    Private Sub txtNameSrch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNameSrch.TextChanged
    End Sub

    Private Sub rdClient_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdClient.CheckedChanged
        Try
            Dim flag As Boolean = Me.rdClient.Checked
            If flag Then
                Me._type = 1
            Else
                Me._type = 2
            End If
            Dim value As String = "123"
            flag = Me.rdSupplier.Checked
            If flag Then
                value = "261"
            End If
            flag = MainClass.IsAccTreeNew
            If flag Then
                value = "110302"
                flag = Me.rdSupplier.Checked
                If flag Then
                    value = "210011"
                End If
            End If
            flag = Me.rdClient.Checked
            If flag Then
                Me.btnClientsImport.Text = "استيراد العملاء من اكسل"
                flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                If flag Then
                    Me.btnClientsImport.Text = "Import Clients from Excel"
                End If
            Else
                Me.btnClientsImport.Text = "استيراد الموردين من اكسل"
                flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
                If flag Then
                    Me.btnClientsImport.Text = "Import Suppliers from Excel"
                End If
            End If
            Me.txtAccCode.Text = MainClass.GenerateCode(Conversions.ToInteger(value))
        Catch ex As Exception
        End Try
        Try
            Dim flag As Boolean = Me.Code = -1
            If flag Then
                Me.LoadNextNo()
            End If
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub rdSupplier_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdSupplier.CheckedChanged
    End Sub

    Private Sub txtAccCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAccCode.TextChanged
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            frmCustomers._selectedacc = ""
            Dim frmSelectClient As frmSelectClient = New frmSelectClient()
            frmSelectClient.ShowDialog()
            Me.txtAccCode.Text = frmCustomers._selectedacc
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintSupp.Click
        Me.PrintRpt(2)
    End Sub

    Private Function chkIsItemFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from customers where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function chkIsGroupFounded(_name As String) As Boolean
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from acts where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return dataTable.Rows.Count > 0
    End Function

    Private Function GetGroupID(_name As String) As Integer
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from acts where name='" + _name + "'", Me.conn1)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        Dim result As Integer
        If flag Then
            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
        Else
            result = -1
        End If
        Return result
    End Function

    Private Sub ImportItems()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Me.conn.State <> ConnectionState.Open
            If flag Then
                Me.conn.Open()
            End If
            Dim frmAddRestriction As frmAddRestriction = New frmAddRestriction()
            frmAddRestriction._IsMsg = False
            frmAddRestriction.LoadData()
            frmAddRestriction.txtNotes.Text = "قيد افتتاحي"
            Dim num As Double = 0.0
            Dim num2 As Double = 0.0
            Dim value As Integer = 1
            Dim text As String = "123"
            flag = Me.rdSupplier.Checked
            If flag Then
                text = "261"
            End If
            flag = MainClass.IsAccTreeNew
            If flag Then
                text = "110302"
                flag = Me.rdSupplier.Checked
                If flag Then
                    text = "210011"
                End If
            End If
            Dim text2 As String = Conversions.ToString(-1)
            flag = Me.rdSupplier.Checked
            If flag Then
                value = 2
            End If
            Dim flag2 As Boolean
            For i As Integer = 0 To Me.dtItems.Rows.Count - 1
                Try
                    flag = (Operators.CompareString(Me.dtItems.Rows(i)(0).ToString().Trim(), "", False) <> 0)
                    If flag Then
                        flag2 = Not Me.chkIsItemFounded(Me.dtItems.Rows(i)(0).ToString())
                        If flag2 Then
                            Dim sqlCommand As SqlCommand = New SqlCommand("insert into Customers(name,country,city,area,act,national_id,tel,mobile,fax,email,notes,type,tax_no,IS_Deleted) values (@name,@country,@city,@area,@act,@national_id,@tel,@mobile,@fax,@email,@notes,@type,@tax_no,@IS_Deleted)", Me.conn)
                            Dim num3 As Integer = -1
                            Dim text3 As String = Me.dtItems.Rows(i)(5).ToString().Trim()
                            flag2 = (Operators.CompareString(text3, "", False) <> 0)
                            If flag2 Then
                                flag = Me.chkIsGroupFounded(text3)
                                If flag Then
                                    num3 = Me.GetGroupID(text3)
                                Else
                                    Dim sqlCommand2 As SqlCommand = New SqlCommand("insert into acts(name)values(@name)", Me.conn)
                                    sqlCommand2.Parameters.Add("@name", SqlDbType.NVarChar).Value = text3
                                    sqlCommand2.ExecuteNonQuery()
                                    num3 = Me.GetGroupID(text3)
                                End If
                            End If
                            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.dtItems.Rows(i)(0).ToString().Trim()
                            Dim num4 As Integer = -1
                            sqlCommand.Parameters.Add("@country", SqlDbType.Int).Value = num4
                            Dim num5 As Integer = -1
                            sqlCommand.Parameters.Add("@city", SqlDbType.Int).Value = num5
                            Dim num6 As Integer = -1
                            sqlCommand.Parameters.Add("@area", SqlDbType.Int).Value = num6
                            sqlCommand.Parameters.Add("@act", SqlDbType.Int).Value = num3
                            sqlCommand.Parameters.Add("@national_id", SqlDbType.NVarChar).Value = ""
                            sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dtItems.Rows(i)(2))
                            sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dtItems.Rows(i)(3))
                            sqlCommand.Parameters.Add("@fax", SqlDbType.NVarChar).Value = ""
                            sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dtItems.Rows(i)(4))
                            sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = ""
                            sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = Me._type
                            sqlCommand.Parameters.Add("@tax_no", SqlDbType.NVarChar).Value = Operators.ConcatenateObject("", Me.dtItems.Rows(i)(1))
                            sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                            sqlCommand.ExecuteNonQuery()
                            text2 = MainClass.GenerateCode(Conversions.ToInteger(text))
                            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Accounts_Index where code='" + text2 + "'", Me.conn)
                            Dim dataTable As DataTable = New DataTable()
                            sqlDataAdapter.Fill(dataTable)
                            flag2 = (dataTable.Rows.Count = 0)
                            If flag2 Then
                                sqlCommand = New SqlCommand(String.Concat(New String() {"insert into Accounts_Index(Code,AName,Type,ParentCode,FinalAcc,Acc_branch,Nature,IValue,date) values ('", text2, "','", Me.dtItems.Rows(i)(0).ToString().Trim(), "',2,'", text, "',1,", Conversions.ToString(MainClass.BranchNo), ",", Conversions.ToString(value), ",", Conversions.ToString(0), ",@date)"}), Me.conn)
                                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now
                                sqlCommand.ExecuteNonQuery()
                            End If
                            flag2 = (Conversions.ToDouble(text2) <> -1.0)
                            If flag2 Then
                                frmAddRestriction.dgvDetails.Rows.Add()
                                frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(0).Value = frmAddRestriction.dgvDetails.Rows.Count
                                frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(3).Value = text2
                                frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(5).Value = "قيد افتتاحي"
                                flag2 = (Me._type = 1)
                                Dim num7 As Double
                                Dim num8 As Double
                                If flag2 Then
                                    num7 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dtItems.Rows(i)(6))), 2)
                                    num8 = 0.0
                                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(1).Value = num7
                                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(2).Value = num8
                                Else
                                    num8 = Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dtItems.Rows(i)(6))), 2)
                                    num7 = 0.0
                                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(1).Value = num7
                                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(2).Value = num8
                                End If

                                num += num7
                                num2 += num8

                            End If
                        End If
                    End If
                Catch ex As Exception
                End Try
                Me.progressBar1.Value = Me.progressBar1.Value + 1
            Next
            flag2 = (Me.conn.State <> ConnectionState.Closed)
            If flag2 Then
                Me.conn.Close()
            End If
            Try
                flag2 = (num <> 0.0 Or num2 <> 0.0)
                If flag2 Then
                    frmAddRestriction.dgvDetails.Rows.Add()
                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(0).Value = frmAddRestriction.dgvDetails.Rows.Count
                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(5).Value = "قيد افتتاحي"
                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(3).Value = 2120001
                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(1).Value = num2
                    frmAddRestriction.dgvDetails.Rows(frmAddRestriction.dgvDetails.Rows.Count - 1).Cells(2).Value = num
                    frmAddRestriction.btnSave_Click(Nothing, Nothing)
                End If
            Catch ex2 As Exception
            End Try
            Me.LoadActs()
            Interaction.MsgBox("تم الإكتمال", MsgBoxStyle.OkOnly, Nothing)
        Catch ex3 As Exception
        Finally
            Me._CompletedImport = True
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnClientsImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClientsImport.Click
        Try
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me._CompletedImport = False
                Dim selectConnection As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Me.OpenFileDialog1.FileName + ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
                Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("select * from [Sheet1$]", selectConnection)
                Me.dtItems = New DataTable()
                oleDbDataAdapter.Fill(Me.dtItems)
                Me.progressBar1.Value = 0
                Me.progressBar1.Maximum = Me.dtItems.Rows.Count
                'Dim thread As Thread = AddressOf Me.ImportItems
                Dim thread As New Thread(AddressOf Me.ImportItems)
                thread.SetApartmentState(ApartmentState.STA)
                thread.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim webRequest As WebRequest = WebRequest.Create(uri)
        webRequest.ContentLength = CLng(jsonDataBytes.Length)
        webRequest.ContentType = contentType
        webRequest.Method = method
        Dim requestStream As Stream = webRequest.GetRequestStream()
        Dim result As String
        Try
            requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            requestStream.Close()
            Dim responseStream As Stream = webRequest.GetResponse().GetResponseStream()
            Try
                Dim streamReader As StreamReader = New StreamReader(responseStream)
                Try
                    result = streamReader.ReadToEnd()
                Finally
                    Dim flag As Boolean = streamReader IsNot Nothing
                    If flag Then
                        CType(streamReader, IDisposable).Dispose()
                    End If
                End Try
            Finally
                Dim flag As Boolean = responseStream IsNot Nothing
                If flag Then
                    CType(responseStream, IDisposable).Dispose()
                End If
            End Try
        Finally
            Dim flag As Boolean = requestStream IsNot Nothing
            If flag Then
                CType(requestStream, IDisposable).Dispose()
            End If
        End Try
        Return result
    End Function

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            Dim text As String = String.Concat(New String() {"{""userName"":""", Me.txtName.Text, """,""apiKey"":""", Me.txtNameEN.Text, """,""numbers"":""", Me.txtMobile.Text, """,""userSender"":""", Me.txtTaxNo.Text, """,""msg"":""", Me.txtNotes.Text, """,""msgEncoding"":""UTF8""}"})
            Interaction.MsgBox(text, MsgBoxStyle.OkOnly, Nothing)
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(text)
            Dim text2 As String = Me.SendRequest(New Uri("https://www.msegat.com/gw/sendsms.php"), bytes, "application/json", "POST")
            Interaction.MsgBox(text2, MsgBoxStyle.OkOnly, Nothing)
            Dim flag As Boolean = text2.Contains("200") Or text2.ToLower().Contains("ok") Or text2.ToLower().Contains("success")
            If flag Then
                Interaction.MsgBox("Sucess", MsgBoxStyle.OkOnly, Nothing)
            Else
                Interaction.MsgBox("Fail", MsgBoxStyle.OkOnly, Nothing)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Try
            Try
                ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12)
            Catch ex As Exception
            End Try
            Dim text As String = String.Concat(New String() {"{""userName"":""", Me.txtName.Text, """,""apiKey"":""", Me.txtNameEN.Text, """,""numbers"":""", Me.txtMobile.Text, """,""userSender"":""", Me.txtTaxNo.Text, """,""msg"":""", Me.txtNotes.Text, """,""msgEncoding"":""UTF8""}"})
            Interaction.MsgBox(text, MsgBoxStyle.OkOnly, Nothing)
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(text)
            Dim text2 As String = Me.SendRequest(New Uri("https://www.msegat.com/gw/sendsms.php"), bytes, "application/json", "POST")
            Interaction.MsgBox(text2, MsgBoxStyle.OkOnly, Nothing)
            Dim flag As Boolean = text2.Contains("200") Or text2.ToLower().Contains("ok") Or text2.ToLower().Contains("success")
            If flag Then
                Interaction.MsgBox("Sucess", MsgBoxStyle.OkOnly, Nothing)
            Else
                Interaction.MsgBox("Fail", MsgBoxStyle.OkOnly, Nothing)
            End If
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) ' Handles Button4.Click
        Try
            Try
                ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12)
            Catch ex As Exception
            End Try
            Dim text As String = String.Concat(New String() {"{""userName"":""", Me.txtName.Text, """,""apiKey"":""", Me.txtNameEN.Text, """,""numbers"":""", Me.txtMobile.Text, """,""userSender"":""", Me.txtTaxNo.Text, """,""msg"":""", Me.txtNotes.Text, """,""msgEncoding"":""UTF8""}"})
            Interaction.MsgBox(text, MsgBoxStyle.OkOnly, Nothing)
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(text)
            Dim text2 As String = Me.SendRequest(New Uri("https://www.msegat.com/gw/sendsms.php"), bytes, "application/json", "POST")
            Dim flag As Boolean = text2.Contains("200") Or text2.ToLower().Contains("ok") Or text2.ToLower().Contains("success")
            If flag Then
                Interaction.MsgBox("Sucess", MsgBoxStyle.OkOnly, Nothing)
            Else
                Interaction.MsgBox("Fail", MsgBoxStyle.OkOnly, Nothing)
            End If
        Catch ex2 As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            Dim finished As Boolean = Me._Finished
            If finished Then
                Me._Finished = False
                Me.Timer1.Enabled = False
                Me.dgvCustomers.ScrollBars = ScrollBars.Both
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
