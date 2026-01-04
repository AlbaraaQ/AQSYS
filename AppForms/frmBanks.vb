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
Imports AQSYS.My
Imports AQSYS.My.Resources
Public Partial Class frmBanks
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmBanks_Load
        frmBanks.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmBanks.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmBanks.__ENCList.Count = frmBanks.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmBanks.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmBanks.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmBanks.__ENCList(num) = frmBanks.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmBanks.__ENCList.RemoveRange(num, frmBanks.__ENCList.Count - num)
                frmBanks.__ENCList.Capacity = frmBanks.__ENCList.Count
            End If
            frmBanks.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        MainClass.CLRForm(Me)
        Me.Code = -1
    End Sub

    Private Sub LoadDG(cond As String)
        Me.dgvBanks.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Banks where " + cond + " IS_Deleted=0 order by id", Me.conn)
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
            Me.dgvBanks.Rows.Add()
            Me.dgvBanks.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvBanks.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvBanks.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
            Me.dgvBanks.Rows(num3).Cells(6).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
            Dim value As String = ""
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
            Me.dgvBanks.Rows(num3).Cells(2).Value = value
            Dim value2 As String = ""
            flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num3)("city"), -1, False)
            If flag Then
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from Cities where id=", dataTable.Rows(num3)("city"))), Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag = (dataTable3.Rows.Count > 0)
                If flag Then
                    value2 = dataTable3.Rows(0)(0).ToString()
                End If
            End If
            Me.dgvBanks.Rows(num3).Cells(3).Value = value2
            Dim value3 As String = ""
            flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows(num3)("area"), -1, False)
            If flag Then
                Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select name from areas where id=", dataTable.Rows(num3)("area"))), Me.conn)
                Dim dataTable4 As DataTable = New DataTable()
                sqlDataAdapter4.Fill(dataTable4)
                flag = (dataTable4.Rows.Count > 0)
                If flag Then
                    value3 = dataTable4.Rows(0)(0).ToString()
                End If
            End If
            Me.dgvBanks.Rows(num3).Cells(4).Value = value3
            num3 += 1
        End While
        Me.dgvBanks.ClearSelection()
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

    Private Sub frmBanks_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmBanks.Load
        Me.LoadCountries()
        Me.LoadDG("")
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
            If flag Then
                MessageBox.Show("يجب ادخال اسم البنك", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtName.Focus()
            Else
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand()
                flag = (Me.Code <> -1)
                If flag Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Accounts_Index.Code from Accounts_Index,Banks where Accounts_Index.AName=Banks.name and Accounts_Index.Type=2 and Banks.id=" + Conversions.ToString(Me.Code), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag = (dataTable.Rows.Count > 0)
                    If flag Then
                        Dim value As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
                        sqlCommand = New SqlCommand(String.Concat(New String() {"update Accounts_Index set AName='", Me.txtName.Text, "' where Code=", Conversions.ToString(value), " and Type=2"}), Me.conn)
                        sqlCommand.ExecuteNonQuery()
                    End If
                End If
                flag = (Me.Code = -1)
                If flag Then
                    sqlCommand = New SqlCommand("insert into Banks(name,country,city,area,tel,mobile,notes,IS_Deleted) values (@name,@country,@city,@area,@tel,@mobile,@notes,@IS_Deleted)", Me.conn)
                Else
                    sqlCommand = New SqlCommand("update Banks set name=@name ,country=@country ,city=@city ,area=@area ,tel=@tel ,mobile=@mobile,notes=@notes ,IS_Deleted=@IS_Deleted where id=" + Conversions.ToString(Me.Code), Me.conn)
                End If
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
                Dim num As Integer = -1
                flag = (Me.cmbCountry.SelectedValue IsNot Nothing)
                If flag Then
                    num = Conversions.ToInteger(Me.cmbCountry.SelectedValue)
                End If
                sqlCommand.Parameters.Add("@country", SqlDbType.Int).Value = num
                Dim num2 As Integer = -1
                flag = (Me.cmbCity.SelectedValue IsNot Nothing)
                If flag Then
                    num2 = Conversions.ToInteger(Me.cmbCity.SelectedValue)
                End If
                sqlCommand.Parameters.Add("@city", SqlDbType.Int).Value = num2
                Dim num3 As Integer = -1
                flag = (Me.cmbArea.SelectedValue IsNot Nothing)
                If flag Then
                    num3 = Conversions.ToInteger(Me.cmbArea.SelectedValue)
                End If
                sqlCommand.Parameters.Add("@area", SqlDbType.Int).Value = num3
                sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
                sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                sqlCommand.ExecuteNonQuery()
                Me.LoadDG("")
                Dim text As String = "122"
                flag = MainClass.IsAccTreeNew
                If flag Then
                    text = "1103012"
                End If
                flag = (Me.Code = -1)
                If flag Then
                    Dim text2 As String = MainClass.GenerateCode(Conversions.ToInteger(text))
                    sqlCommand = New SqlCommand(String.Concat(New String() {"insert into Accounts_Index(Code,AName,Type,ParentCode,FinalAcc,Acc_branch) values ('", text2, "','", Me.txtName.Text, "',2,'", text, "',1,", Conversions.ToString(MainClass.BranchNo), ")"}), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                End If
                sqlCommand = New SqlCommand("select max(id) from Banks", Me.conn)
                Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            Dim text3 As String = "خطأ أثناء الحفظ"
            text3 = text3 + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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
                Try
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where type=2 and AName='" + Me.txtName.Text + "'", Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag = (dataTable.Rows.Count > 0)
                    If flag Then
                        Dim value As Long = Convert.ToInt64(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
                        Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select count(id) from inv where is_deleted=0 and bank=" + Conversions.ToString(value), Me.conn)
                        Dim dataTable2 As DataTable = New DataTable()
                        sqlDataAdapter2.Fill(dataTable2)
                        flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)(0))) > 0.0)
                        If flag Then
                            Interaction.MsgBox("هذا البنك مرتبط بفواتير ولا يمكن حذفه", MsgBoxStyle.OkOnly, Nothing)
                            Return
                        End If
                    End If
                Catch ex As Exception
                End Try
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand("update Banks set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                sqlCommand.ExecuteNonQuery()
                Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select Code from Accounts_Index where Type=2 and AName='" + Me.txtName.Text + "'", Me.conn)
                Dim dataTable3 As DataTable = New DataTable()
                sqlDataAdapter3.Fill(dataTable3)
                flag = (dataTable3.Rows.Count > 0)
                If flag Then
                    Dim value2 As Long = Convert.ToInt64(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
                    sqlCommand = New SqlCommand("delete from Accounts_Index where Code=" + Conversions.ToString(value2), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                End If
                Me.LoadDG("")
                Me.CLR()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub dgvRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvBanks.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Banks where id=" + Conversions.ToString(Me.Code))
    End Sub

    Private Sub dgvBanks_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvBanks.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgvRowChng(e.RowIndex)
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
            flag = Operators.ConditionalCompareObjectNotEqual(dr("country"), -1, False)
            If flag Then
                Me.cmbCountry.SelectedValue = RuntimeHelpers.GetObjectValue(dr("country"))
                Me.LoadCities(Conversions.ToInteger(Me.cmbCountry.SelectedValue))
            End If
            flag = Operators.ConditionalCompareObjectNotEqual(dr("city"), -1, False)
            If flag Then
                Me.cmbCity.SelectedValue = RuntimeHelpers.GetObjectValue(dr("city"))
                Me.LoadAreas(Conversions.ToInteger(Me.cmbCity.SelectedValue))
            End If
            flag = Operators.ConditionalCompareObjectNotEqual(dr("area"), -1, False)
            If flag Then
                Me.cmbArea.SelectedValue = RuntimeHelpers.GetObjectValue(dr("area"))
            End If
            Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
            Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
            Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvBanks.ClearSelection()
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
        Me.Navigate("select top 1 * from Banks where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Banks where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Banks where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Banks where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
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
                frmAreas.LoadCities(Conversions.ToInteger(frmAreas.cmbCountry.SelectedValue))
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

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvBanks.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("name")
            dataTable.Columns.Add("country")
            dataTable.Columns.Add("city")
            dataTable.Columns.Add("area")
            dataTable.Columns.Add("tel")
            dataTable.Columns.Add("mobile")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvBanks.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvBanks.Rows(num3).Cells(6).Value)})
                num3 += 1
            End While
            Dim rptBanks As rptBanks = New rptBanks()
            rptBanks.SetDataSource(dataTable)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptBanks.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject As TextObject = CType(rptBanks.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject2 As TextObject = CType(rptBanks.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject3 As TextObject = CType(rptBanks.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject4 As TextObject = CType(rptBanks.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptBanks
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptBanks.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub
End Class
