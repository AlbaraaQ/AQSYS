Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
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
Imports System.Drawing.Printing
Imports System.Management
Imports System.Printing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Public Partial Class frmGroups
    Inherits Form

    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

    Private conn As SqlConnection

    Private Code As Integer
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmActs_Load
        frmGroups.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.Code = -1
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmGroups.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmGroups.__ENCList.Count = frmGroups.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmGroups.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmGroups.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmGroups.__ENCList(num) = frmGroups.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmGroups.__ENCList.RemoveRange(num, frmGroups.__ENCList.Count - num)
                frmGroups.__ENCList.Capacity = frmGroups.__ENCList.Count
            End If
            frmGroups.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub CLR()
        Me.txtName.Text = ""
        Me.txtNameEN.Text = ""
        Me.cmbPrinters.Text = ""
        Me.Code = -1
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.CLR()
    End Sub

    Private Sub LoadDG()
        Me.dgvData.Rows.Clear()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from groups", Me.conn)
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
            Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
            If flag Then
                Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("name"))
            Else
                Me.dgvData.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("nameEN"))
            End If
            num3 += 1
        End While
        Me.dgvData.ClearSelection()
    End Sub

    Private Sub GetPrinters()
        Try
            Dim query As ObjectQuery = New ObjectQuery("SELECT * FROM Win32_Printer")
            Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher(query)
            Dim managementObjectCollection As ManagementObjectCollection = managementObjectSearcher.[Get]()
            Try
                For Each managementBaseObject As ManagementBaseObject In managementObjectCollection
                    Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
                    Dim properties As PropertyDataCollection = managementObject.Properties
                    For Each propertyData As PropertyData In properties
                        Dim flag As Boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(managementObject("Network")))
                        If flag Then
                            Me.cmbPrinters.Items.Add(RuntimeHelpers.GetObjectValue(managementObject(propertyData.Name)))
                        End If
                    Next
                Next
            Finally
                Dim enumerator As ManagementObjectCollection.ManagementObjectEnumerator
                Dim flag As Boolean = enumerator IsNot Nothing
                If flag Then
                    CType(enumerator, IDisposable).Dispose()
                End If
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetPrinters1()
        Try
            Try
                For Each obj As Object In PrinterSettings.InstalledPrinters
                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
                    Me.cmbPrinters.Items.Add(RuntimeHelpers.GetObjectValue(objectValue))
                Next
            Finally
                Dim enumerator As IEnumerator
                Dim flag As Boolean = TypeOf enumerator Is IDisposable
                If flag Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim enumerationFlag As EnumeratedPrintQueueTypes() = New EnumeratedPrintQueueTypes() {EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections, EnumeratedPrintQueueTypes.[Shared]}
            Dim localPrintServer As LocalPrintServer = New LocalPrintServer()
            Dim printQueues As PrintQueueCollection = localPrintServer.GetPrintQueues(enumerationFlag)
            Try
                For Each printQueue As PrintQueue In printQueues
                    Me.cmbPrinters.Items.Add(printQueue.Name)
                Next
            Finally
                Dim enumerator2 As IEnumerator(Of PrintQueue)
                Dim flag As Boolean = enumerator2 IsNot Nothing
                If flag Then
                    enumerator2.Dispose()
                End If
            End Try
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmActs_Load(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmActs.Load
        Me.LoadDG()
        Me.GetPrinters1()
        Me.WindowState = MainClass.Window_State
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim flag As Boolean = Operators.CompareString(Me.txtName.Text.Trim(), "", False) <> 0
            If flag Then
                Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
                If flag2 Then
                    Me.conn.Open()
                End If
                flag2 = (Me.Code = -1)
                If flag2 Then
                    Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"insert into groups(name,nameEN,color,printer) values('", Me.txtName.Text, "','", Me.txtNameEN.Text, "',", Conversions.ToString(Me.btnColor.BackColor.ToArgb()), ",'", Me.cmbPrinters.Text, "')"}), Me.conn)
                    sqlCommand.ExecuteNonQuery()
                    Me.txtName.Text = ""
                    Me.txtName.Focus()
                Else
                    Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() {"update groups set  name ='", Me.txtName.Text, "',nameEN='", Me.txtNameEN.Text, "',color=", Conversions.ToString(Me.btnColor.BackColor.ToArgb()), ",printer='", Me.cmbPrinters.Text, "' where id=", Conversions.ToString(Me.Code)}), Me.conn)
                    sqlCommand2.ExecuteNonQuery()
                    Me.txtName.Focus()
                End If
                Me.LoadDG()
            Else
                MessageBox.Show("ادخل المجموعة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.txtName.Focus()
            End If
        Catch ex As Exception
            Dim text As String = "خطأ أثناء الحفظ"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
    End Sub

    Private Sub dgv_RowChng(row_index As Integer)
        ' The following expression was wrapped in a checked-expression
        Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvData.Rows(row_index).Cells(0).Value))))
        Me.Navigate("select * from groups where id=" + Conversions.ToString(Me.Code))
    End Sub

    Private Sub dgvData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim flag As Boolean = e.RowIndex >= 0
        If flag Then
            Me.dgv_RowChng(e.RowIndex)
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
                Try
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select count(*) from inv,inv_sub,currencies where inv.proc_id=inv_sub.proc_id and inv_sub.currency_from=currencies.id and inv.is_deleted=0 and currencies.group_id=" + Conversions.ToString(Me.Code), Me.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) > 0.0)
                    If flag2 Then
                        Interaction.MsgBox("هذه المجموعة مرتبطة بفواتير ولا يمكن حذفها", MsgBoxStyle.OkOnly, Nothing)
                        Return
                    End If
                Catch ex As Exception
                End Try
                Dim sqlCommand As SqlCommand = New SqlCommand("delete from groups where id=" + Conversions.ToString(Me.Code), Me.conn)
                sqlCommand.ExecuteNonQuery()
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.LoadDG()
                Me.CLR()
            Else
                MessageBox.Show("اختر مجموعة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex2 As Exception
            Dim text As String = "خطأ أثناء الحذف"
            text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex2.Message
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

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtName.KeyDown
        Dim flag As Boolean = e.KeyCode = Keys.[Return]
        If flag Then
            Me.btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ReadData(dr As SqlDataReader)
        Dim hasRows As Boolean = dr.HasRows
        If hasRows Then
            dr.Read()
            Me.CLR()
            Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dr("id")))))
            Me.txtName.Text = Conversions.ToString(dr("name"))
            Try
                Me.txtNameEN.Text = Conversions.ToString(dr("nameEN"))
            Catch ex As Exception
            End Try
            Dim white As Color = Color.White
            Try
                Me.btnColor.BackColor = Color.FromArgb(Conversions.ToInteger(dr("color")))
            Catch ex2 As Exception
            End Try
            Try
                Me.cmbPrinters.Text = Conversions.ToString(dr("printer"))
            Catch ex3 As Exception
            End Try
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
        Me.Navigate("select top 1 * from groups order by id desc")
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        Me.Navigate("select top 1 * from groups order by id asc")
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Me.Navigate("select top 1 * from groups where id>" + Conversions.ToString(Me.Code) + " order by id asc")
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        Me.Navigate("select top 1 * from groups where id<" + Conversions.ToString(Me.Code) + " order by id desc")
    End Sub

    Private Sub PrintRpt(type As Integer)
        Dim flag As Boolean = Me.dgvData.Rows.Count = 0
        If flag Then
            MessageBox.Show("الجدول فارغ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("col1")
            Dim num As Integer = 0
            Dim num2 As Integer = Me.dgvData.Rows.Count - 1
            Dim num3 As Integer = num
            While True
                Dim num4 As Integer = num3
                Dim num5 As Integer = num2
                If num4 > num5 Then
                    Exit While
                End If
                dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvData.Rows(num3).Cells(1).Value)})
                num3 += 1
            End While
            Dim rptCol As rptCol1 = New rptCol1()
            rptCol.SetDataSource(dataTable)
            Dim textObject As TextObject = CType(rptCol.ReportDefinition.Sections(1).ReportObjects("txtHeader"), TextObject)
            textObject.Text = "المجموعات"
            Dim textObject2 As TextObject = CType(rptCol.ReportDefinition.Sections(2).ReportObjects("col1"), TextObject)
            textObject2.Text = "المجموعة"
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
            Dim dataTable2 As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable2)
            rptCol.Subreports("rptHeader").SetDataSource(dataTable2)
            flag = (dataTable2.Rows.Count > 0)
            If flag Then
                Dim textObject3 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
                textObject3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
                Dim textObject4 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtTel"), TextObject)
                textObject4.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
                Dim textObject5 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
                textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
                Dim textObject6 As TextObject = CType(rptCol.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
                textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
            End If
            Dim frmRptViewer As frmRptViewer = New frmRptViewer()
            Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
            frmRptViewer.Controls.Add(crystalReportViewer)
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.DisplayGroupTree = False
            crystalReportViewer.ReportSource = rptCol
            frmRptViewer.WindowState = FormWindowState.Maximized
            flag = (type = 1)
            If flag Then
                frmRptViewer.Show()
            Else
                Try
                    crystalReportViewer.ShowLastPage()
                    Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
                    crystalReportViewer.ShowFirstPage()
                    rptCol.PrintToPrinter(1, False, 1, currentPageNumber)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Me.PrintRpt(1)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnColor.Click
        Try
            Dim flag As Boolean = Me.ColorDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.btnColor.BackColor = Me.ColorDialog1.Color
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
