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
Public Partial Class frmGifts
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer

    Private _val As Double
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmActs_Load
        frmGifts.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me._val = 0.0
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmGifts.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmGifts.__ENCList.Count = frmGifts.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmGifts.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmGifts.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmGifts.__ENCList(num) = frmGifts.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmGifts.__ENCList.RemoveRange(num, frmGifts.__ENCList.Count - num)
                frmGifts.__ENCList.Capacity = frmGifts.__ENCList.Count
            End If
            frmGifts.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.cmbClients.SelectedIndex = -1
        Me.txtCustDisc.Text = ""
        Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtGift.Text = ""
        Me.txtValue.Text = ""
        Me.txtNotes.Text = ""
        Me.Code = -1
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Function GetCustName(id As Integer) As String
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from customers where id=" + Conversions.ToString(id), Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
    End Function

    Private Sub LoadDG(cond As String)
        Me.dgvData.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from gifts where is_deleted=0 " + cond, Me.conn)
        sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
        sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtToDate.Value.ToShortDateString()
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
            Me.dgvData.Rows.Add()
            Me.dgvData.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvData.Rows(num3).Cells(1).Value = Me.GetCustName(Conversions.ToInteger(dataTable.Rows(num3)("cust_id")))
            Me.dgvData.Rows(num3).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
            Me.dgvData.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("value"))
            num3 += 1
        End While
        Me.dgvData.ClearSelection()
    End Sub

    Public Sub LoadClients()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where IS_Deleted=0 order by id", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbClients.DataSource = dataTable
        Me.cmbClients.DisplayMember = "name"
        Me.cmbClients.ValueMember = "id"
        Me.cmbClients.SelectedIndex = -1
        Dim dataTable2 As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable2)
        Me.cmbClientSrch.DataSource = dataTable
        Me.cmbClientSrch.DisplayMember = "name"
        Me.cmbClientSrch.ValueMember = "id"
        Me.cmbClientSrch.SelectedIndex = -1
    End Sub

    Private Sub frmActs_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmActs.Load
        Me.WindowState = MainClass.Window_State
        Me.txtDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
        Me.LoadClients()
    End Sub

    Private Sub UpdateCustBalance()
        Try
            Dim num As Double = Conversion.Val(Me.txtCustDisc.Text)
            Dim flag As Boolean = Me.Code = -1
            If flag Then
                num -= Conversion.Val(Me.txtValue.Text)
            Else
                num = num + Me._val - Conversion.Val(Me.txtValue.Text)
            End If
            Me.conn1.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update customers set discount_balance=" + Conversions.ToString(num) + " where id=", Me.cmbClients.SelectedValue)), Me.conn)
            sqlCommand.ExecuteNonQuery()
            Me.conn1.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Me.cmbClients.SelectedValue Is Nothing
            If flag Then
                MessageBox.Show("اختر العميل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.cmbClients.Focus()
            Else
                flag = (Operators.CompareString(Me.txtGift.Text.Trim(), "", False) = 0)
                If flag Then
                    MessageBox.Show("ادخل الهدية", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txtGift.Focus()
                Else
                    flag = (Conversion.Val(Me.txtValue.Text) = 0.0)
                    If flag Then
                        MessageBox.Show("ادخل المبلغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txtValue.Focus()
                    Else
                        flag = (Me.conn.State <> ConnectionState.Open)
                        If flag Then
                            Me.conn.Open()
                        End If
                        Dim sqlCommand As SqlCommand = New SqlCommand()
                        flag = (Me.Code = -1)
                        If flag Then
                            sqlCommand = New SqlCommand("insert into gifts(date,cust_id,gift,value,notes,is_deleted) values(@date,@cust_id,@gift,@value,@notes,@is_deleted)", Me.conn)
                        Else
                            sqlCommand = New SqlCommand("update gifts set  date=@date,cust_id=@cust_id,gift=@gift,value=@value,notes=@notes where id=" + Conversions.ToString(Me.Code), Me.conn)
                        End If
                        sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
                        sqlCommand.Parameters.Add("@cust_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbClients.SelectedValue)
                        sqlCommand.Parameters.Add("@gift", SqlDbType.NVarChar).Value = Me.txtGift.Text
                        sqlCommand.Parameters.Add("@value", SqlDbType.Float).Value = Conversion.Val(Me.txtValue.Text)
                        sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                        sqlCommand.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0
                        sqlCommand.ExecuteNonQuery()
                        Me.UpdateCustBalance()
                        Me.CLR()
                        Interaction.MsgBox("تم الحفظ", MsgBoxStyle.OkOnly, Nothing)
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

    Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Try
            Me.Navigate(Conversions.ToString(Operators.ConcatenateObject("select * from gifts where id=", Me.dgvData.Rows(e.RowIndex).Cells(0).Value)))
            Me.TabControl1.SelectedIndex = 0
        Catch ex As Exception
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
                Dim sqlCommand As SqlCommand = New SqlCommand("update gifts set is_deleted=0 where id=" + Conversions.ToString(Me.Code), Me.conn)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.CLR()
            Else
                MessageBox.Show("اختر سجل ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub ReadData(dr As SqlDataReader)
        Dim hasRows As Boolean = dr.HasRows
        If hasRows Then
            dr.Read()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.cmbClients.SelectedValue = RuntimeHelpers.GetObjectValue(dr("cust_id"))
            Me.txtDate.Value = Conversions.ToDate(dr("date"))
            Me.txtGift.Text = Conversions.ToString(dr("gift"))
            Me.txtValue.Text = Conversions.ToString(dr("value"))
            Me._val = Conversion.Val(RuntimeHelpers.GetObjectValue(dr("value")))
            Me.txtNotes.Text = Conversions.ToString(dr("notes"))
            dr.Close()
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvData.ClearSelection()
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
        Me.Navigate("select top 1 * from gifts order by id desc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from gifts order by id asc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from gifts where id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from gifts where id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAll.CheckedChanged
        Try
            Dim checked As Boolean = Me.chkAll.Checked
            If checked Then
                Me.cmbClientSrch.Enabled = False
            Else
                Me.cmbClientSrch.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Search()
        Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbClientSrch.SelectedValue Is Nothing
        If flag Then
            Interaction.MsgBox("اختر العميل أو الكل", MsgBoxStyle.OkOnly, Nothing)
            Me.cmbClientSrch.Focus()
        Else
            Dim text As String = ""
            flag = Not Me.chkAll.Checked
            If flag Then
                text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and cust_id=", Me.cmbClientSrch.SelectedValue)))
            End If
            text += " and date>=@date1 and date<=@date2 "
            Me.LoadDG(text)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Me.Search()
    End Sub

    Private Sub GetCustDiscBalance()
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select discount_balance from Customers where id=", Me.cmbClients.SelectedValue)), Me.conn1)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.txtCustDisc.Text = Conversions.ToString(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))), 2))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbClients_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbClients.SelectedIndexChanged
        Me.GetCustDiscBalance()
    End Sub
End Class
