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
Partial Public Class dfh
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmRekabaSetting_Load
        dfh.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = dfh.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = dfh.__ENCList.Count = dfh.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = dfh.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = dfh.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            dfh.__ENCList(num) = dfh.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                dfh.__ENCList.RemoveRange(num, dfh.__ENCList.Count - num)
                dfh.__ENCList.Capacity = dfh.__ENCList.Count
            End If
            dfh.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub txtVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal.TextChanged
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadDG()
        ' The following expression was wrapped in a checked-statement
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Rekaba", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Dim num As Integer = 0
                Dim num2 As Integer = dataTable.Rows.Count - 1
                Dim num3 As Integer = num
                While True
                    Dim num4 As Integer = num3
                    Dim num5 As Integer = num2
                    If num4 > num5 Then
                        Exit While
                    End If
                    Me.dgvCurrencies.Rows.Add()
                    Me.dgvCurrencies.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("curr_id"))
                    Me.dgvCurrencies.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("chk"))
                    num3 += 1
                End While
                Me.txtVal.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("val")))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmRekabaSetting_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmRekabaSetting.Load
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,symbol as currency from Currencies order by id", Me.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim dataGridViewComboBoxColumn As DataGridViewComboBoxColumn = CType(Me.dgvCurrencies.Columns(0), DataGridViewComboBoxColumn)
            dataGridViewComboBoxColumn.DataSource = dataTable
            dataGridViewComboBoxColumn.DisplayMember = "currency"
            dataGridViewComboBoxColumn.ValueMember = "id"
            Me.LoadDG()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' The following expression was wrapped in a checked-statement
        Try
            Me.txtVal.Focus()
            Dim flag As Boolean = Me.dgvCurrencies.Rows.Count <= 1
            If flag Then
                MessageBox.Show("لا توجد أصناف مدخلة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Dim num As Integer = 0
                Dim num2 As Integer = Me.dgvCurrencies.Rows.Count - 2
                Dim num3 As Integer = num
                While True
                    Dim num4 As Integer = num3
                    Dim num5 As Integer = num2
                    If num4 > num5 Then
                        GoTo Block_5
                    End If
                    flag = (Me.dgvCurrencies.Rows(num3).Cells(0).Value Is Nothing)
                    If flag Then
                        Exit While
                    End If
                    num3 += 1
                End While
                MessageBox.Show("ادخل الصنف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.dgvCurrencies.Rows(num3).Selected = True
                Return
Block_5:
                flag = (Conversion.Val(Me.txtVal.Text) = 0.0)
                If flag Then
                    MessageBox.Show("ادخل المبلغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txtVal.Focus()
                Else
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand()
                    sqlCommand = New SqlCommand("delete from Rekaba", Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    Dim num6 As Integer = 0
                    Dim num7 As Integer = Me.dgvCurrencies.Rows.Count - 2
                    Dim num8 As Integer = num6
                    While True
                        Dim num9 As Integer = num8
                        Dim num5 As Integer = num7
                        If num9 > num5 Then
                            Exit While
                        End If
                        sqlCommand = New SqlCommand("insert into Rekaba(curr_id,chk,val) values (@curr_id,@chk,@val)", Me.conn)
                        sqlCommand.Parameters.Add("@curr_id", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num8).Cells(0).Value)
                        Dim num10 As Integer = 0
                        flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvCurrencies.Rows(num8).Cells(1).Value)) = 1)
                        If flag Then
                            num10 = 1
                        End If
                        sqlCommand.Parameters.Add("@chk", SqlDbType.Bit).Value = num10
                        sqlCommand.Parameters.Add("@val", SqlDbType.Float).Value = Conversion.Val(Me.txtVal.Text)
                        sqlCommand.ExecuteNonQuery()
                        num8 += 1
                    End While
                    MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub txtVal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVal.KeyPress
        MainClass.IsFloat(e)
    End Sub

    Private Sub dgvCurrencies_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvCurrencies.DataError
    End Sub
End Class
