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
Public Partial Class frmCountries
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmCountries_Load
        frmCountries.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmCountries.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmCountries.__ENCList.Count = frmCountries.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmCountries.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmCountries.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmCountries.__ENCList(num) = frmCountries.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmCountries.__ENCList.RemoveRange(num, frmCountries.__ENCList.Count - num)
                frmCountries.__ENCList.Capacity = frmCountries.__ENCList.Count
            End If
            frmCountries.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.txtName.Text = ""
        Me.txtNationality.Text = ""
        Me.picFlag.Image = Nothing
        Me.Code = -1
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub LoadDG()
        Me.dgvCountries.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name,nationality from Countries", Me.conn)
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
            Me.dgvCountries.Rows.Add()
            Me.dgvCountries.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvCountries.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvCountries.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nationality"))
            num3 += 1
        End While
        Me.dgvCountries.ClearSelection()
    End Sub

    Private Sub frmCountries_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmCountries.Load
        Me.LoadDG()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
            If flag Then
                MessageBox.Show("ادخل اسم الدولة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtName.Focus()
            Else
                flag = (Operators.CompareString(Me.txtNationality.Text.Trim(), "", False) = 0)
                If flag Then
                    MessageBox.Show("ادخل اسم الجنسية", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txtNationality.Focus()
                Else
                    flag = (Me.conn.State <> ConnectionState.Open)
                    If flag Then
                        Me.conn.Open()
                    End If
                    flag = (Me.Code = -1)
                    If flag Then
                        Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"insert into Countries(name,nationality,flag_img) values('", Me.txtName.Text, "','", Me.txtNationality.Text, "',@img)"}), Me.conn)
                        flag = (Me.picFlag.Image IsNot Nothing)
                        If flag Then
                            sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picFlag.Image)
                        Else
                            sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value
                        End If
                        sqlCommand.ExecuteNonQuery()
                        Me.CLR()
                        Me.txtName.Focus()
                    Else
                        Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() {"update Countries set  name ='", Me.txtName.Text, "',nationality='", Me.txtNationality.Text, "',flag_img=@img where id=", Conversions.ToString(Me.Code)}), Me.conn)
                        flag = (Me.picFlag.Image IsNot Nothing)
                        If flag Then
                            sqlCommand2.Parameters.Add("@img", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picFlag.Image)
                        Else
                            sqlCommand2.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value
                        End If
                        sqlCommand2.ExecuteNonQuery()
                        Me.txtName.Focus()
                    End If
                    Me.LoadDG()
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

    Private Sub dgvManagements_RowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvCountries.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Countries where id=" + Conversions.ToString(Me.Code))
    End Sub

    Private Sub dgvCountries_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvCountries.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgvManagements_RowChng(e.RowIndex)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Dim flag As Boolean = Me.Code <> -1
            If flag Then
                Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
                If flag2 Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand("delete from Countries where id=" + Conversions.ToString(Me.Code), Me.conn)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.LoadDG()
                Me.CLR()
            Else
                MessageBox.Show("اختر ادارة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
        Dim flag As Boolean = dr.HasRows
        If flag Then
            dr.Read()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.txtName.Text = Conversions.ToString(dr("name"))
            Me.txtNationality.Text = Conversions.ToString(dr("nationality"))
            flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr("flag_img")))
            If flag Then
                Me.picFlag.Image = MainClass.Arr2Image(CType(dr("flag_img"), Byte()))
            Else
                Me.picFlag.Image = Nothing
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvCountries.ClearSelection()
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
        Me.Navigate("select top 1 * from Countries order by id desc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Countries order by id asc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Countries where id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Countries where id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub lnkClear_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkClear.LinkClicked
        Me.picFlag.Image = Nothing
    End Sub

    Private Sub lnkAdd_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkAdd.LinkClicked
        Try
            Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.picFlag.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvCountries.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("col1")
            dataTable.Columns.Add("col2")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvCountries.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvCountries.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvCountries.Rows(num3).Cells(2).Value)})
                num3 += 1
            End While
            Dim rptcol As rptcol2 = New rptcol2()
            rptcol.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptcol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
            textObject.Text = "الدول"
            Dim textObject2 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
            textObject2.Text = "الدولة"
            Dim textObject3 As TextObject = CType(rptcol.ReportDefinition.Sections(2).ReportObjects("col2"), TextObject)
            textObject3.Text = "الجنسية"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptcol.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject4 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject5 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject6 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject7 As TextObject = CType(rptcol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptcol
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptcol.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub
End Class
