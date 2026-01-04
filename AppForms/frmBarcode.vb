Imports GenCode128
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
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Printing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Partial Class frmBarcode
    Inherits Form

    Private conn As SqlConnection
    Friend WithEvents pdPrint As PrintDocument
    Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
    Private PrintDocType As String

    Private StrPrinterName As String

    Private pbImage2 As PictureBox

    Private g As Graphics

    Private _counter As Integer

    Private _item As String

    Private _ItemID As Integer

    Private _Barcode As String

    Private _price As String

    Public _Unit As String

    Private _foundation As String

    Private _IsPriceInTax As Boolean

    Private A4Barcode As Boolean

    Private _IsMiniPrint As Boolean
    Shared Sub New()
    End Sub

    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.frmBarcode_Load
        frmBarcode.__ENCAddToList(Me)
        Me.conn = MainClass.ConnObj()
        Me.PrintDocType = "Barcode"
        Me.StrPrinterName = "Microsoft XPS Document Writer"
        Me.pbImage2 = New PictureBox()
        Me._counter = 0
        Me._item = ""
        Me._ItemID = -1
        Me._Barcode = ""
        Me._price = ""
        Me._Unit = ""
        Me._foundation = ""
        Me._IsPriceInTax = False
        Me.A4Barcode = False
        Me._IsMiniPrint = False
        Me.InitializeComponent()
    End Sub
    Private Shared Sub __ENCAddToList(value As Object)
        Dim _ENCList As List(Of WeakReference) = frmBarcode.__ENCList
        Dim flag As Boolean = False
        Try
            Monitor.Enter(_ENCList, flag)
            Dim flag2 As Boolean = frmBarcode.__ENCList.Count = frmBarcode.__ENCList.Capacity
            If flag2 Then
                Dim num As Integer = 0
                Dim num2 As Integer = 0
                Dim num3 As Integer = frmBarcode.__ENCList.Count - 1
                Dim num4 As Integer = num2
                While True
                    Dim num5 As Integer = num4
                    Dim num6 As Integer = num3
                    If num5 > num6 Then
                        Exit While
                    End If
                    Dim weakReference As WeakReference = frmBarcode.__ENCList(num4)
                    flag2 = weakReference.IsAlive
                    If flag2 Then
                        Dim flag3 As Boolean = num4 <> num
                        If flag3 Then
                            frmBarcode.__ENCList(num) = frmBarcode.__ENCList(num4)
                        End If
                        num += 1
                    End If
                    num4 += 1
                End While
                frmBarcode.__ENCList.RemoveRange(num, frmBarcode.__ENCList.Count - num)
                frmBarcode.__ENCList.Capacity = frmBarcode.__ENCList.Count
            End If
            frmBarcode.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
        Finally
            Dim flag3 As Boolean = flag
            If flag3 Then
                Monitor.[Exit](_ENCList)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim image As Image = Code128Rendering.MakeBarcodeImage(Me.txtBarcode.Text.ToString(), 2, False)
        Me.pbImage2.Image = image
        Me.g.Clear(Color.White)
        Dim rectangle As Rectangle = New Rectangle(0, 10, 280, 85)
        Dim num As Integer = 50
        Dim num2 As Integer = 10
        Dim num3 As Integer = 1
        Dim num6 As Integer
        Dim num7 As Integer
        Do
            Dim num4 As Integer = 1
            Dim num5 As Integer
            Do
                Dim stringFormat As StringFormat = New StringFormat()
                stringFormat.LineAlignment = StringAlignment.Center
                Dim font As Font = New Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point)
                Me.g.DrawRectangle(Pens.White, rectangle)
                Dim width As Integer = Me.pbImage2.Width
                Dim height As Integer = Me.pbImage2.Height
                rectangle = New Rectangle(num, num2, 150, 60)
                Me.g.InterpolationMode = InterpolationMode.HighQualityBicubic
                Me.g.SmoothingMode = SmoothingMode.HighQuality
                Me.g.CompositingQuality = CompositingQuality.HighQuality
                Me.g.PixelOffsetMode = PixelOffsetMode.HighQuality
                Me.g.DrawImage(Me.pbImage2.Image, rectangle)
                Me.g.DrawRectangle(Pens.White, rectangle)
                rectangle = New Rectangle(num + 50, num2 + 60, 150, 15)
                Me.g.DrawString(Me.txtBarcode.Text.ToString(), font, Brushes.Black, rectangle, stringFormat)
                num2 += 100
                num4 += 1
                num5 = num4
                num6 = 5
            Loop While num5 <= num6
            num += 200
            num2 = 10
            num3 += 1
            num7 = num3
            num6 = 3
        Loop While num7 <= num6
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim rectangle As Rectangle = New Rectangle(0, 10, 280, 85)
        Dim stringFormat As StringFormat = New StringFormat()
        stringFormat.LineAlignment = StringAlignment.Center
        stringFormat.Alignment = StringAlignment.Center
        Dim stringFormat2 As StringFormat = New StringFormat(StringFormatFlags.DirectionRightToLeft)
        stringFormat2.LineAlignment = StringAlignment.Center
        stringFormat2.Alignment = StringAlignment.Center
        Dim font As Font = New Font("Arial", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        Dim font2 As Font = New Font("Arial", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Dim font3 As Font = New Font("Arial", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        rectangle = New Rectangle(0, 10, 280, 15)
        Dim num As Integer = 5
        Dim num2 As Integer = 5
        Dim num3 As Integer = CInt(Math.Round(Conversion.Val(Me.lblBarcodeW.Text) * 37.8))
        Dim num4 As Integer = CInt(Math.Round(Conversion.Val(Me.lblBarcodeH.Text) * 37.8))
        Dim flag As Boolean = Me._IsMiniPrint
        If flag Then
            num3 = 76
            num4 = 26
            rectangle = New Rectangle(num, num2, num3, num4)
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
            e.Graphics.DrawImage(Me.pbImage2.Image, rectangle)
            e.Graphics.DrawRectangle(Pens.White, rectangle)
            rectangle = New Rectangle(num + num3 + 10, num2 + 5, num3, 15)
            Dim text As String = Me._price
            flag = Me.chkCurrency.Checked
            If flag Then
                text = text + "  " + Me.txtCurrency.Text
            End If
            e.Graphics.DrawString(text, font2, Brushes.Black, rectangle, stringFormat)
            rectangle = New Rectangle(num, num2 + num4 + 3, num3, 12)
            text = Me._Barcode
            e.Graphics.DrawString(text, font3, Brushes.Black, rectangle, stringFormat)
            rectangle = New Rectangle(num + num3 + 10, num2 + 20, num3, 15)
            e.Graphics.DrawString(Me._item, font, Brushes.Black, rectangle, stringFormat)
        Else
            flag = Not Me.A4Barcode
            If flag Then
                Dim flag2 As Boolean = Me.chkCompany.Checked
                If flag2 Then
                    rectangle = New Rectangle(num + 10, num2, num3, 12)
                    e.Graphics.DrawString(Me._foundation, font, Brushes.Black, rectangle, stringFormat)
                Else
                    num2 -= 15
                End If
                rectangle = New Rectangle(num + 10, num2 + 15, num3, 12)
                e.Graphics.DrawString(Me._item, font, Brushes.Black, rectangle, stringFormat2)
                flag2 = Me.chkItemEN.Checked
                If flag2 Then
                    Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select nameEN from Currencies where id=" + Conversions.ToString(Me._ItemID), MainClass.conn)
                    Dim dataTable As DataTable = New DataTable()
                    sqlDataAdapter.Fill(dataTable)
                    num2 += 15
                    rectangle = New Rectangle(num + 10, num2 + 15, num3, 12)
                    e.Graphics.DrawString(dataTable.Rows(0)(0).ToString(), font, Brushes.Black, rectangle, stringFormat)
                End If
                Dim width As Integer = Me.pbImage2.Width
                Dim height As Integer = Me.pbImage2.Height
                rectangle = New Rectangle(num + 3, num2 + 30, num3, num4)
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
                e.Graphics.DrawImage(Me.pbImage2.Image, rectangle)
                e.Graphics.DrawRectangle(Pens.White, rectangle)
                rectangle = New Rectangle(num + 10, num2 + 32 + num4, num3, 12)
                Dim text2 As String = Me._Barcode
                e.Graphics.DrawString(text2, font3, Brushes.Black, rectangle, stringFormat)
                rectangle = New Rectangle(num + 10, num2 + 48 + num4, num3, 15)
                flag2 = Me.chkPrice.Checked
                If flag2 Then
                    text2 = "   price: " + Me._price
                    flag2 = Me.chkCurrency.Checked
                    If flag2 Then
                        text2 = text2 + "  " + Me.txtCurrency.Text
                    End If
                    flag2 = Me.chkInTax.Checked
                    If flag2 Then
                        text2 += " (شامل الضريبة)"
                    End If
                    e.Graphics.DrawString(text2, font2, Brushes.Black, rectangle, stringFormat)
                End If
                flag2 = (Me.chkProdDate.Checked And Operators.CompareString(Me.txtProdDate.Text.Trim(), "", False) <> 0)
                If flag2 Then
                    rectangle = New Rectangle(num + 10, num2 + 66 + num4, num3, 12)
                    e.Graphics.DrawString("تاريخ الإنتاج: " + Me.txtProdDate.Text, font, Brushes.Black, rectangle, stringFormat)
                End If
                flag2 = (Me.chkExpireDate.Checked And Operators.CompareString(Me.txtExpireDate.Text.Trim(), "", False) <> 0)
                If flag2 Then
                    rectangle = New Rectangle(num + 10, num2 + 80 + num4, num3, 12)
                    e.Graphics.DrawString("تاريخ الصلاحية: " + Me.txtExpireDate.Text, font, Brushes.Black, rectangle, stringFormat)
                End If
            Else
                Dim width As Integer = Me.pbImage2.Width
                Dim height As Integer = Me.pbImage2.Height
                Dim num5 As Integer = 1
                Dim num8 As Integer
                Dim num9 As Integer
                Do
                    Dim num6 As Integer = 1
                    Dim num7 As Integer
                    Do
                        rectangle = New Rectangle(num + 25, num2, 100, 12)
                        e.Graphics.DrawString(Me._foundation, font, Brushes.Black, rectangle, stringFormat)
                        rectangle = New Rectangle(num + 25, num2 + 15, 100, 12)
                        e.Graphics.DrawString(Me.cmbItems.Text, font, Brushes.Black, rectangle, stringFormat)
                        rectangle = New Rectangle(num, num2 + 28, 100, 28)
                        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
                        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
                        e.Graphics.DrawImage(Me.pbImage2.Image, rectangle)
                        e.Graphics.DrawRectangle(Pens.White, rectangle)
                        rectangle = New Rectangle(num + 25, num2 + 57, 100, 12)
                        e.Graphics.DrawString(Me.txtBarcode.Text.ToString(), font, Brushes.Black, rectangle, stringFormat)
                        e.Graphics.DrawRectangle(Pens.White, rectangle)
                        Dim flag2 As Boolean = Me.chkPrice.Checked
                        If flag2 Then
                            rectangle = New Rectangle(num + 25, num2 + 72, 100, 16)
                            e.Graphics.DrawString("Price: " + Me.txtPrice.Text, font, Brushes.Black, rectangle, stringFormat)
                        End If
                        num2 += 100
                        Me._counter += 1
                        num6 += 1
                        num7 = num6
                        num8 = 6
                    Loop While num7 <= num8
                    num += 160
                    num2 = 10
                    num5 += 1
                    num9 = num5
                    num8 = 5
                Loop While num9 <= num8
            End If
        End If
    End Sub

    Private Sub PrintBarcode()
        Try
            Me.A4Barcode = False
            Dim image As Image = Code128Rendering.MakeBarcodeImage(Me._Barcode.ToString(), 2, False)
            Me.pbImage2.Image = image
            Me.pdPrint = New PrintDocument()
            Me.pdPrint.PrinterSettings.PrinterName = Me.cmbPrinters.Text
            Me.pdPrint.PrintController = New StandardPrintController()
            Dim isValid As Boolean = Me.pdPrint.PrinterSettings.IsValid
            If isValid Then
                Me.pdPrint.DocumentName = Me.PrintDocType
                Me.pdPrint.Print()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub btnPrintBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Me._IsMiniPrint = False
        Dim str As String = ""
        Dim flag As Boolean = Me.rdItem.Checked
        If flag Then
            Dim flag2 As Boolean = Me.cmbItems.SelectedValue Is Nothing
            If flag2 Then
                Interaction.MsgBox("اختر صنف", MsgBoxStyle.OkOnly, Nothing)
                Me.cmbItems.Focus()
                Return
            End If
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" id=", Me.cmbItems.SelectedValue), " and "))
        Else
            Dim flag2 As Boolean = Me.rdGroup.Checked
            If flag2 Then
                flag = (Me.cmbGroups.SelectedValue Is Nothing)
                If flag Then
                    Interaction.MsgBox("اختر مجموعة", MsgBoxStyle.OkOnly, Nothing)
                    Me.cmbGroups.Focus()
                    Return
                End If
                str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" group_id=", Me.cmbGroups.SelectedValue), " and "))
            End If
        End If
        Try
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
            If flag2 Then
                Me.conn.Open()
            End If
            Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() {"update Foundation set barcode_width=", Conversions.ToString(Conversion.Val(Me.lblBarcodeW.Text)), ",barcode_height=", Conversions.ToString(Conversion.Val(Me.lblBarcodeH.Text)), " where id=1"}), Me.conn)
            sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
            If flag2 Then
                Me.conn.Close()
            End If
        End Try
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from currencies where " + str + " is_deleted=0 ", Me.conn)
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
            Me._item = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("symbol")))
            Me._ItemID = Conversions.ToInteger(dataTable.Rows(num3)("id"))
            Me._Barcode = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("barcode")))
            Me._price = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("sale_price")))
            Dim flag2 As Boolean = Me.rdItem.Checked And Operators.CompareString(Me._Unit, "", False) <> 0
            If flag2 Then
                Me._item = Me._item + " (" + Me._Unit + ")"
                Me._Barcode = Me.txtBarcode.Text
                Me._price = Me.txtPrice.Text
            End If
            flag2 = (Me.chkInTax.Checked And Not Me._IsPriceInTax)
            If flag2 Then
                ' The following expression was wrapped in a unchecked-expression
                Me._price = Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tax"))) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))), 2))
            End If
            Dim num6 As Decimal = 1D
            Dim value As Decimal = Me.txtNum.Value
            Dim num7 As Decimal = num6
            While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num7, value, 1D)
                Me.PrintBarcode()
                num7 = Decimal.Add(num7, 1D)
            End While
            num3 += 1
        End While
    End Sub

    Public Sub LoadAllItems()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where IS_Deleted=0 order by id", MainClass.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbItems.DataSource = dataTable
        Me.cmbItems.DisplayMember = "symbol"
        Me.cmbItems.ValueMember = "id"
        Me.cmbItems.SelectedIndex = -1
    End Sub

    Public Sub LoadGroups()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, name from groups order by id", MainClass.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Me.cmbGroups.DataSource = dataTable
        Me.cmbGroups.DisplayMember = "name"
        Me.cmbGroups.ValueMember = "id"
        Me.cmbGroups.SelectedIndex = -1
    End Sub

    Private Sub GetPrinters()
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

    Public Sub LoadData()
        Me.LoadAllItems()
        Me.LoadGroups()
        Me.GetPrinters()
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
        Dim dataTable As DataTable = New DataTable()
        sqlDataAdapter.Fill(dataTable)
        Dim flag As Boolean = dataTable.Rows.Count > 0
        If flag Then
            Me._foundation = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("nameA")))
            Try
                flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("barcode_height")), "", False), Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("barcode_width")), "", False)))
                If flag Then
                    Me.lblBarcodeH.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("barcode_height")))
                    Me.lblBarcodeW.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("barcode_width")))
                End If
            Catch ex As Exception
            End Try
            Try
                flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("vat_type"))) = 2.0)
                If flag Then
                    Me._IsPriceInTax = True
                End If
            Catch ex2 As Exception
            End Try
        End If
        Me.g = Me.GroupBox2.CreateGraphics()
    End Sub

    Private Sub frmBarcode_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmBarcode.Load
        Me.LoadData()
    End Sub

    Private Sub cmbItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItems.SelectedIndexChanged
        Try
            Me._Unit = ""
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select barcode from Currencies where id=", Me.cmbItems.SelectedValue)), MainClass.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.txtBarcode.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcode.TextChanged
        Try
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select sale_price from Currencies where id=", Me.cmbItems.SelectedValue)), MainClass.conn)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            Dim flag As Boolean = dataTable.Rows.Count > 0
            If flag Then
                Me.txtPrice.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            Me._IsMiniPrint = False
            Me.A4Barcode = True
            Dim image As Image = Code128Rendering.MakeBarcodeImage(Me.txtBarcode.Text.ToString(), 2, False)
            Me.pbImage2.Image = image
            Dim flag As Boolean = Me.PrintDialog1.ShowDialog() = DialogResult.OK
            If flag Then
                Me.pdPrint = New PrintDocument()
                Me.pdPrint.PrinterSettings.PrinterName = Me.PrintDialog1.PrinterSettings.PrinterName
                Me.pdPrint.PrintController = New StandardPrintController()
                flag = Me.pdPrint.PrinterSettings.IsValid
                If flag Then
                    Me.pdPrint.DocumentName = Me.PrintDocType
                    Me.pdPrint.Print()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPrice.TextChanged
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim str As String = ""
        Dim flag As Boolean = Me.rdItem.Checked
        If flag Then
            Dim flag2 As Boolean = Me.cmbItems.SelectedValue Is Nothing
            If flag2 Then
                Interaction.MsgBox("اختر صنف", MsgBoxStyle.OkOnly, Nothing)
                Me.cmbItems.Focus()
                Return
            End If
            str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" id=", Me.cmbItems.SelectedValue), " and "))
        Else
            Dim flag2 As Boolean = Me.rdGroup.Checked
            If flag2 Then
                flag = (Me.cmbGroups.SelectedValue Is Nothing)
                If flag Then
                    Interaction.MsgBox("اختر مجموعة", MsgBoxStyle.OkOnly, Nothing)
                    Me.cmbGroups.Focus()
                    Return
                End If
                str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" group_id=", Me.cmbGroups.SelectedValue), " and "))
            End If
        End If
        Me._IsMiniPrint = True
        Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from currencies where " + str + " is_deleted=0 ", Me.conn)
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
            Me._item = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("symbol")))
            Me._ItemID = Conversions.ToInteger(dataTable.Rows(num3)("id"))
            Me._Barcode = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("barcode")))
            Me._price = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(num3)("sale_price")))
            Dim flag2 As Boolean = Me.chkInTax.Checked And Not Me._IsPriceInTax
            If flag2 Then
                ' The following expression was wrapped in a unchecked-expression
                Me._price = Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("tax"))) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("sale_price"))), 2))
            End If
            Dim num6 As Decimal = 1D
            Dim value As Decimal = Me.txtNum.Value
            Dim num7 As Decimal = num6
            While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num7, value, 1D)
                Me.PrintBarcode()
                num7 = Decimal.Add(num7, 1D)
            End While
            num3 += 1
        End While
    End Sub

    Private Sub chkInTax_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkInTax.CheckedChanged
        Try
        Catch ex As Exception
        End Try
    End Sub
End Class
