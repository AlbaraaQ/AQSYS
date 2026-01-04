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
Public Partial Class frmBranches
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private conn1 As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmBranches_Load
        frmBranches.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.conn1 = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmBranches.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmBranches.__ENCList.Count = frmBranches.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmBranches.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmBranches.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmBranches.__ENCList(num) = frmBranches.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmBranches.__ENCList.RemoveRange(num, frmBranches.__ENCList.Count - num)
                frmBranches.__ENCList.Capacity = frmBranches.__ENCList.Count
            End If
            frmBranches.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        MainClass.CLRForm(Me)
        Me.picImage.Image = Nothing
        Me.Code = -1
    End Sub

    Private Sub LoadDG()
        Me.dgvBranches.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Branches order by id", Me.conn)
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
            Me.dgvBranches.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
            Me.dgvBranches.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Me.dgvBranches.Rows(num3).Cells(2).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tel"))
            Me.dgvBranches.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("mobile"))
            Me.dgvBranches.Rows(num3).Cells(4).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("fax"))
            Me.dgvBranches.Rows(num3).Cells(5).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("email"))
            num3 += 1
        End While
        Me.dgvBranches.ClearSelection()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub LoadBanks()
        Try
            Dim str As String = "122"
            Dim isAccTreeNew As Boolean = MainClass.IsAccTreeNew
            If isAccTreeNew Then
                str = "1103012"
            End If
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select code,aname from Accounts_Index where parentcode='" + str + "'", Me.conn1)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Me.cmbDefaultBank.DataSource = dataTable
            Me.cmbDefaultBank.DisplayMember = "aname"
            Me.cmbDefaultBank.ValueMember = "code"
            Me.cmbDefaultBank.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmBranches_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmBranches.Load
        Dim isTrial As Boolean = MainClass.IsTrial
        If isTrial Then
            Me.btnOpenFile.Enabled = False
        End If
        Me.LoadBanks()
        Me.LoadDG()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) = 0
            If flag Then
                MessageBox.Show("يجب ادخال اسم الفرع", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtName.Focus()
            Else
                flag = (Me.conn.State <> ConnectionState.Open)
                If flag Then
                    Me.conn.Open()
                End If
                Dim sqlCommand As SqlCommand = New SqlCommand()
                flag = (Me.Code = -1)
                If flag Then
                    sqlCommand = New SqlCommand("insert into Branches(name,tel,mobile,fax,email,address,notes,is_deleted,img,addressEn,cr,bank1,acc1,bank2,acc2,bank3,acc3,default_bank) values (@name,@tel,@mobile,@fax,@email,@address,@notes,@is_deleted,@img,@addressEn,@cr,@bank1,@acc1,@bank2,@acc2,@bank3,@acc3,@default_bank)", Me.conn)
                Else
                    sqlCommand = New SqlCommand("update Branches set name=@name ,tel=@tel ,mobile=@mobile ,fax=@fax ,email=@email ,address=@address,notes=@notes,img=@img,addressEn=@addressEn,cr=@cr,bank1=@bank1,acc1=@acc1,bank2=@bank2,acc2=@acc2,bank3=@bank3,acc3=@acc3,default_bank=@default_bank where id=" + Conversions.ToString(Me.Code), Me.conn)
                End If
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.txtName.Text
                sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar).Value = Me.txtTel.Text
                sqlCommand.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = Me.txtMobile.Text
                sqlCommand.Parameters.Add("@fax", SqlDbType.NVarChar).Value = Me.txtFax.Text
                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Me.txtEmail.Text
                sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = Me.txtAddress.Text
                sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                sqlCommand.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0
                flag = (Me.picImage.Image IsNot Nothing)
                If flag Then
                    sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picImage.Image)
                Else
                    sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = DBNull.Value
                End If
                sqlCommand.Parameters.Add("@cr", SqlDbType.NVarChar).Value = Me.txtcr.Text
                sqlCommand.Parameters.Add("@addressEn", SqlDbType.NVarChar).Value = Me.txtAddressEN.Text
                sqlCommand.Parameters.Add("@bank1", SqlDbType.NVarChar).Value = Me.txtBank1.Text
                sqlCommand.Parameters.Add("@acc1", SqlDbType.NVarChar).Value = Me.txtAcc1.Text
                sqlCommand.Parameters.Add("@bank2", SqlDbType.NVarChar).Value = Me.txtBank2.Text
                sqlCommand.Parameters.Add("@acc2", SqlDbType.NVarChar).Value = Me.txtAcc2.Text
                sqlCommand.Parameters.Add("@bank3", SqlDbType.NVarChar).Value = Me.txtBank3.Text
                sqlCommand.Parameters.Add("@acc3", SqlDbType.NVarChar).Value = Me.txtAcc3.Text
                Dim num As Integer = -1
                Try
                    flag = (Me.cmbDefaultBank.SelectedValue IsNot Nothing)
                    If flag Then
                        num = Conversions.ToInteger(Me.cmbDefaultBank.SelectedValue)
                    End If
                Catch ex As Exception
                End Try
                sqlCommand.Parameters.Add("@default_bank", SqlDbType.Int).Value = num
                sqlCommand.ExecuteNonQuery()
                Me.LoadDG()
                sqlCommand = New SqlCommand("select max(id) from Branches", Me.conn)
                Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", sqlCommand.ExecuteScalar()))))
                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex2 As Exception
            Dim text As String = "خطأ أثناء الحفظ"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
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
                Dim flag2 As Boolean = Me.Code = 1
                If flag2 Then
                    Interaction.MsgBox("لا يمكن حذف الفرع الرئيسي، يمكنك تعديل بياناته", MsgBoxStyle.OkOnly, Nothing)
                Else
                    flag2 = (Me.conn.State <> ConnectionState.Open)
                    If flag2 Then
                        Me.conn.Open()
                    End If
                    Dim sqlCommand As SqlCommand = New SqlCommand("delete from Branches where id=" + Conversions.ToString(Me.Code), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    Me.LoadDG()
                    Me.CLR()
                    MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                MessageBox.Show("اختر فرع ليتم حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvBranches.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from Branches where id=" + Conversions.ToString(Me.Code))
    End Sub

    Private Sub dgvBranches_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvBranches.CellClick
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
            Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("tel")))
            Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("mobile")))
            Me.txtFax.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("fax")))
            Me.txtEmail.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("email")))
            Me.txtAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("address")))
            Me.txtNotes.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
            Try
                flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dr("img")))
                If flag Then
                    Me.picImage.Image = MainClass.Arr2Image(CType(dr("img"), Byte()))
                End If
            Catch ex As Exception
            End Try
            Me.txtcr.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("cr")))
            Me.txtAddressEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("addressEn")))
            Me.txtBank1.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("bank1")))
            Me.txtAcc1.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("acc1")))
            Me.txtBank2.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("bank2")))
            Me.txtAcc2.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("acc2")))
            Me.txtBank3.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("bank3")))
            Me.txtAcc3.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("acc3")))
            Try
                flag = Operators.ConditionalCompareObjectNotEqual(dr("default_bank"), -1, False)
                If flag Then
                    Me.cmbDefaultBank.SelectedValue = RuntimeHelpers.GetObjectValue(dr("default_bank"))
                End If
            Catch ex2 As Exception
            End Try
            dr.Close()
        End If
    End Sub

    Private Sub Navigate(sqlstr As String)
        Me.dgvBranches.ClearSelection()
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
        Me.Navigate("select top 1 * from Branches where IS_Deleted=0 order by id desc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from Branches where IS_Deleted=0 and id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from Branches where IS_Deleted=0 order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from Branches where IS_Deleted=0 and id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub dgvBranches_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvBranches.DataError
    End Sub

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvBranches.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("name")
            dataTable.Columns.Add("tel")
            dataTable.Columns.Add("mobile")
            dataTable.Columns.Add("fax")
            dataTable.Columns.Add("email")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvBranches.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvBranches.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvBranches.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvBranches.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvBranches.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvBranches.Rows(num3).Cells(5).Value)})
                num3 += 1
            End While
            Dim rptBranches As rptBranches = New rptBranches()
            rptBranches.SetDataSource(dataTable)
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptBranches.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject As TextObject = CType(rptBranches.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject2 As TextObject = CType(rptBranches.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject3 As TextObject = CType(rptBranches.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject4 As TextObject = CType(rptBranches.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptBranches
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptBranches.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenFile.Click
        Try
            Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
            Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.txtPicPath.Text = Me.OpenFileDialog1.FileName
                Me.picImage.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
