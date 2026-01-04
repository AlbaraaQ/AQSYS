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
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Public Partial Class frmEmpSalaryAddSub
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmEmpSalaryAddSub_Load
        frmEmpSalaryAddSub.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmEmpSalaryAddSub.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmEmpSalaryAddSub.__ENCList.Count = frmEmpSalaryAddSub.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmEmpSalaryAddSub.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmEmpSalaryAddSub.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmEmpSalaryAddSub.__ENCList(num) = frmEmpSalaryAddSub.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmEmpSalaryAddSub.__ENCList.RemoveRange(num, frmEmpSalaryAddSub.__ENCList.Count - num)
                frmEmpSalaryAddSub.__ENCList.Capacity = frmEmpSalaryAddSub.__ENCList.Count
            End If
            frmEmpSalaryAddSub.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
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
        Me.dgvSrch.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select EmpSalaryAddSub.id,EmpSalaryAddSub.emp,Employees.name,EmpSalaryAddSub.date,EmpSalaryAddSub.val,SalaryAddSubTypes.name as type from EmpSalaryAddSub,SalaryAddSubTypes,Employees where EmpSalaryAddSub.type=SalaryAddSubTypes.id and EmpSalaryAddSub.emp=Employees.id and " + cond + " EmpSalaryAddSub.IS_Deleted=0 order by id", Me.conn)
        Dim flag As Boolean = Operators.CompareString(cond, "", False) <> 0
        If flag Then
            sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
            sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
        End If
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
            Me.dgvSrch.Rows.Add()
            Me.dgvSrch.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvSrch.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("emp"))
            Me.dgvSrch.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvSrch.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val"))
            Me.dgvSrch.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("type"))
            Me.dgvSrch.Rows(num3).Cells(5).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
            num3 += 1
        End While
        Me.dgvSrch.ClearSelection()
    End Sub

    Public Sub LoadEmps()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Employees where is_deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbEmp.DataSource = dataTable
        Me.cmbEmp.DisplayMember = "name"
        Me.cmbEmp.ValueMember = "id"
        Me.cmbEmp.SelectedIndex = -1
        Dim dataTable2 As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable2)
        Me.cmbEmpSrch.DataSource = dataTable2
        Me.cmbEmpSrch.DisplayMember = "name"
        Me.cmbEmpSrch.ValueMember = "id"
        Me.cmbEmpSrch.SelectedIndex = -1
    End Sub

    Public Sub LoadTypes()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from SalaryAddSubTypes order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbType.DataSource = dataTable
        Me.cmbType.DisplayMember = "name"
        Me.cmbType.ValueMember = "id"
        Me.cmbType.SelectedIndex = -1
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub frmEmpSalaryAddSub_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmEmpSalaryAddSub.Load
        Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadEmps()
        Me.LoadTypes()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Me.cmbEmp.SelectedValue Is Nothing
            If flag Then
                MessageBox.Show("يجب اختيار موظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbEmp.Focus()
            Else
                flag = (Me.cmbType.SelectedValue Is Nothing)
                If flag Then
                    MessageBox.Show("يجب اختيار نوع الاجراء", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.cmbType.Focus()
                Else
                    flag = (Operators.CompareString(Me.txtVal.Text.Trim(), "", False) = 0)
                    If flag Then
                        MessageBox.Show("يجب ادخال مبلغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txtVal.Focus()
                    Else
                        flag = (Me.conn.State <> ConnectionState.Open)
                        If flag Then
                            Me.conn.Open()
                        End If
                        Dim sqlCommand As SqlCommand = New SqlCommand()
                        flag = (Me.Code = -1)
                        If flag Then
                            sqlCommand = New SqlCommand("insert into EmpSalaryAddSub(emp,type,date,val,notes,user_id,IS_Deleted) values (@emp,@type,@date,@val,@notes,@user_id,@IS_Deleted)", Me.conn)
                        Else
                            sqlCommand = New SqlCommand("update EmpSalaryAddSub set emp=@emp ,type=@type ,date=@date ,val=@val ,notes=@notes ,user_id=@user_id ,IS_Deleted=@IS_Deleted where id=" + Conversions.ToString(Me.Code), Me.conn)
                        End If
                        sqlCommand.Parameters.Add("@emp", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbEmp.SelectedValue)
                        sqlCommand.Parameters.Add("@type", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbType.SelectedValue)
                        sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.txtDate.Value).ToShortDateString()
                        sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = Conversion.Val("" + Me.txtVal.Text)
                        sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                        sqlCommand.Parameters.Add("@user_id", SqlDbType.Int).Value = MainClass.UserID
                        sqlCommand.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
                        sqlCommand.ExecuteNonQuery()
                        Me.LoadDG("")
                        sqlCommand = New SqlCommand("select max(id) from EmpSalaryAddSub", Me.conn)
                        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                        MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
                If flag2 Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand("update EmpSalaryAddSub set IS_Deleted=1 where id=" + Conversions.ToString(Me.Code), Me.conn)
                sqlCommand.ExecuteNonQuery()
                Me.LoadDG("")
                Me.CLR()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("اختر عميل ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub dgvRowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from EmpSalaryAddSub where id=" + Conversions.ToString(Me.Code))
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgvRowChng(e.RowIndex)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim hasRows As Boolean = dr.HasRows
        If hasRows Then
            dr.Read()
            Me.CLR()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.cmbEmp.SelectedValue = Operators.ConcatenateObject("", dr("emp"))
            Me.cmbType.SelectedValue = Operators.ConcatenateObject("", dr("type"))
            Me.txtDate.Value = Conversions.ToDate(dr("date"))
            Me.txtVal.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("val")))
            Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvSrch.ClearSelection()
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
        Me.Navigate("select top 1 * from EmpSalaryAddSub where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from EmpSalaryAddSub where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from EmpSalaryAddSub where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from EmpSalaryAddSub where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub Search()
        Dim text As String = ""
        Dim flag As Boolean = Not Me.chkAllEmp.Checked
        If flag Then
            text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" emp=", Me.cmbEmpSrch.SelectedValue), " and ")))
        End If
        text += "date>=@date1 and date<=@date2 and "
        Me.LoadDG(text)
    End Sub

    Private Sub chkAllEmp_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAllEmp.CheckedChanged
        Dim checked As Boolean = Me.chkAllEmp.Checked
        If checked Then
            Me.cmbEmpSrch.Enabled = False
        Else
            Me.cmbEmpSrch.Enabled = True
        End If
    End Sub

    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVal.KeyPress
        MainClass.IsFloat(e)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim flag As Boolean = Not Me.chkAllEmp.Checked And Me.cmbEmpSrch.SelectedValue Is Nothing
        If flag Then
            MessageBox.Show("يجب اختيار موظف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.cmbEmpSrch.Focus()
        Else
            Me.Search()
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub Label6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Label4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Try
            Dim rptSalaryAddSub As rptSalaryAddSub = New rptSalaryAddSub()
            Dim textObject As TextObject = CType(rptSalaryAddSub.ReportDefinition.Sections(1).ReportObjects("name"), TextObject)
            textObject.Text = Me.cmbEmp.Text
            Dim textObject2 As TextObject = CType(rptSalaryAddSub.ReportDefinition.Sections(1).ReportObjects("val"), TextObject)
            textObject2.Text = Me.txtVal.Text + " ( " + Number2Arabic.ameral(Me.txtVal.Text) + " ) ريال فقط لا غير"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            rptSalaryAddSub.Subreports("rptHeader").SetDataSource(dataTable)
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptSalaryAddSub
            frmRptViewer.WindowState = FormWindowState.Maximized
            frmRptViewer.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbType.SelectedIndexChanged
        Try
            Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.cmbType.SelectedValue, 4, False)
            If flag Then
                Me.btnPrint.Visible = True
            Else
                Me.btnPrint.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
