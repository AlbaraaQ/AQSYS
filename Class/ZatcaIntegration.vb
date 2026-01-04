Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports ZatcaIntegrationSDK
Imports ZatcaIntegrationSDK.APIHelper
Imports ZatcaIntegrationSDK.BLL
Imports ZatcaIntegrationSDK.HelperContracts
Imports ZXing
Imports ZXing.Common
	Public Class ZatcaIntegration
		Private conn As SqlConnection

		Private mode As Mode

		Private invlines As List(Of ZatcaIntegration.InvoiceItems)

		Private QRImg As Image

		Public strQR As String

		Public StatusCode As String

		Public warningmsg As String

		Public errmsg As String

		Public res As ZatcaIntegrationSDK.Result

		Public Sub New()
			Me.conn = MainClass.ConnObj()
			Me.mode = Mode.developer
			Me.QRImg = Nothing
			Me.strQR = ""
			Me.StatusCode = ""
			Me.warningmsg = ""
			Me.errmsg = ""
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

		Private Function GetPaymentMethod(Optional _type As Integer = 1) As String
			Dim flag As Boolean = _type = 1
			Dim result As String
			If flag Then
				result = "10"
			Else
				flag = (_type = 2)
				If flag Then
					result = "30"
				Else
					flag = (_type = 3)
					If flag Then
						result = "42"
					Else
						flag = (_type = 4)
						If flag Then
							result = "48"
						Else
							flag = (_type = 5)
							If flag Then
								result = "1"
							Else
								result = ""
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		Private Function GetInvoiceType(Optional _type As Integer = 1) As Integer
			Dim result As Integer = 388
			Dim flag As Boolean = _type = 1
			If flag Then
				result = 388
			Else
				flag = (_type = 2)
				If flag Then
					result = 388
				Else
					flag = (_type = 3)
					If flag Then
						result = 383
					Else
						flag = (_type = 4)
						If flag Then
							result = 383
						Else
							flag = (_type = 5)
							If flag Then
								result = 381
							Else
								flag = (_type = 6)
								If flag Then
									result = 381
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		Public Function GetInvoiceTypeName(Optional _type As Integer = 1) As String
			Dim result As String = "0100000"
			Dim flag As Boolean = _type = 1
			If flag Then
				result = "0200000"
			Else
				flag = (_type = 2)
				If flag Then
					result = "0100000"
				Else
					flag = (_type = 3)
					If flag Then
						result = "0200000"
					Else
						flag = (_type = 4)
						If flag Then
							result = "0100000"
						Else
							flag = (_type = 5)
							If flag Then
								result = "0200000"
							Else
								flag = (_type = 6)
								If flag Then
									result = "0100000"
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		Public Function QrCodeImage(qrcodestring As String, Optional width As Integer = 250, Optional height As Integer = 250) As Bitmap
			Dim barcodeWriter As BarcodeWriter = New BarcodeWriter() With { .Format = BarcodeFormat.QR_CODE, .Options = New EncodingOptions() With { .Width = width, .Height = height } }
			Return barcodeWriter.Write(qrcodestring)
		End Function
    '///////////////////////////////
    ''' <summary>
    ''' دالة التكامل مع منظومة الفوترة الإلكترونية (زاتكا)
    ''' </summary>
    ''' <param name="_InvId">رقم الفاتورة</param>
    ''' <param name="_InvDate">تاريخ الفاتورة</param>
    ''' <param name="_InvType">نوع الفاتورة</param>
    ''' <param name="_payType">نوع الدفع</param>
    ''' <param name="_CustId">رقم العميل</param>
    ''' <param name="_InvTot">إجمالي الفاتورة</param>
    ''' <param name="_InvDisc">الخصم</param>
    ''' <param name="_InvVat">الضريبة</param>
    ''' <param name="_InvNet">الصافي</param>
    ''' <param name="_dtItems">جدول الأصناف</param>
    ''' <param name="_srcinv">رقم الفاتورة المرجعية</param>
    ''' <param name="_srcdate">تاريخ الفاتورة المرجعية</param>
    ''' <returns>True إذا نجحت العملية</returns>
    Public Function ZatcaIntegration(_InvId As String, _InvDate As DateTime, _InvType As Integer,
                                  _payType As Integer, _CustId As Integer, _InvTot As Double,
                                  _InvDisc As Double, _InvVat As Double, _InvNet As Double,
                                  _dtItems As DataTable, Optional _srcinv As Integer = -1,
                                  Optional _srcdate As DateTime = Nothing) As Boolean
        Try
            ' ========== جلب البيانات الأساسية ==========
            Dim foundationData As DataTable = GetFoundationData()
            Dim customerData As DataTable = GetCustomerData(_CustId)

            If Not ValidateRequiredData(foundationData, customerData) Then
                Return False
            End If

            ' ========== إنشاء كائن الفاتورة ==========
            Dim ublxml As New UBLXML("EN")
            Dim invoice As New Invoice()
            Me.res = New ZatcaIntegrationSDK.Result()

            ' ========== تعيين البيانات الأساسية للفاتورة ==========
            SetInvoiceBasicInfo(invoice, _InvId, _InvDate, _InvType, customerData)

            ' ========== إضافة مرجع الفاتورة للمرتجعات ==========
            AddBillingReferenceIfNeeded(invoice, _srcinv, _srcdate)

            ' ========== تعيين معلومات PIH و ICV ==========
            Dim icvValue As Long = 0
            Dim branchUuid As Long = 0
            SetAdditionalDocumentReferences(invoice, _InvId, icvValue, branchUuid)

            ' ========== تعيين بيانات التسليم والدفع ==========
            SetDeliveryAndPaymentInfo(invoice, _InvDate, _payType)

            ' ========== تعيين بيانات المورد (البائع) ==========
            SetSupplierPartyInfo(invoice, foundationData)

            ' ========== تعيين بيانات العميل (المشتري) ==========
            SetCustomerPartyInfo(invoice, customerData)

            ' ========== إضافة الخصومات ==========
            AddDiscountIfExists(invoice, _InvDisc)

            ' ========== تعيين المبالغ الإجمالية ==========
            SetMonetaryTotals(invoice, _InvNet)

            ' ========== إضافة بنود الفاتورة ==========
            AddInvoiceLines(invoice, _dtItems)

            ' ========== تعيين شهادات التوقيع ==========
            SetCertificateInfo(invoice, foundationData)

            ' ========== توليد XML الفاتورة ==========
            If Not GenerateInvoiceXML(ublxml, invoice) Then
                Return False
            End If

            ' ========== تحديث قاعدة البيانات ==========
            UpdateDatabaseReferences(icvValue, branchUuid)

            ' ========== إرسال الفاتورة لزاتكا ==========
            Return SendInvoiceToZatca(invoice, foundationData)

        Catch ex As Exception
            HandleError("ZatcaIntegration", ex)
            Return False
        End Try
    End Function

#Region "جلب البيانات"

    ''' <summary>
    ''' جلب بيانات المؤسسة
    ''' </summary>
    Private Function GetFoundationData() As DataTable
        Const QUERY As String =
        "SELECT nameA, bsn_no, tax_no, gov, city, area, street, build_no, post_code, " &
        "public_key, private_key, secret_code, csr, zatc_integ_type " &
        "FROM foundation WHERE id = 1"

        Dim adapter As New SqlDataAdapter(QUERY, Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

    ''' <summary>
    ''' جلب بيانات العميل
    ''' </summary>
    Private Function GetCustomerData(customerId As Integer) As DataTable
        Dim query As String =
        "SELECT name, tax_no, cr, country, city, area, street, build_no, post_code " &
        $"FROM customers WHERE id = {customerId}"

        Dim adapter As New SqlDataAdapter(query, Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

    ''' <summary>
    ''' جلب بيانات الفرع
    ''' </summary>
    Private Function GetBranchData() As DataTable
        Dim query As String = $"SELECT pih, uuid FROM branches WHERE id = {MainClass.BranchNo}"
        Dim adapter As New SqlDataAdapter(query, Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

    ''' <summary>
    ''' جلب بيانات PIH من المؤسسة
    ''' </summary>
    Private Function GetFoundationPIHData() As DataTable
        Dim adapter As New SqlDataAdapter("SELECT pih, uuid FROM foundation", Me.conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

    ''' <summary>
    ''' التحقق من صحة البيانات المطلوبة
    ''' </summary>
    Private Function ValidateRequiredData(foundationData As DataTable, customerData As DataTable) As Boolean
        If foundationData.Rows.Count = 0 Then
            MessageBox.Show("لم يتم العثور على بيانات المؤسسة")
            Return False
        End If

        If customerData.Rows.Count = 0 Then
            MessageBox.Show("لم يتم العثور على بيانات العميل")
            Return False
        End If

        Return True
    End Function

#End Region

#Region "تعيين بيانات الفاتورة الأساسية"

    ''' <summary>
    ''' تعيين المعلومات الأساسية للفاتورة
    ''' </summary>
    Private Sub SetInvoiceBasicInfo(invoice As Invoice, invId As String, invDate As DateTime,
                                 invType As Integer, customerData As DataTable)
        invoice.ID = invId
        invoice.IssueDate = invDate.ToString("yyyy-MM-dd")
        invoice.IssueTime = invDate.ToString("HH:mm:ss")
        invoice.invoiceTypeCode.id = GetInvoiceType(invType)

        ' تحديد نوع الفاتورة بناءً على الرقم الضريبي للعميل
        Dim adjustedType As Integer = DetermineAdjustedInvoiceType(invType, customerData)
        invoice.invoiceTypeCode.Name = GetInvoiceTypeName(adjustedType)

        invoice.DocumentCurrencyCode = "SAR"
        invoice.TaxCurrencyCode = "SAR"
    End Sub

    ''' <summary>
    ''' تحديد نوع الفاتورة المعدل بناءً على الرقم الضريبي
    ''' </summary>
    Private Function DetermineAdjustedInvoiceType(invType As Integer, customerData As DataTable) As Integer
        Dim customerTaxNo As String = GetSafeString(customerData.Rows(0), "tax_no")

        If invType = 1 AndAlso Not String.IsNullOrEmpty(customerTaxNo) Then
            Return 2
        ElseIf invType = 5 AndAlso Not String.IsNullOrEmpty(customerTaxNo) Then
            Return 6
        End If

        Return invType
    End Function

    ''' <summary>
    ''' إضافة مرجع الفاتورة للمرتجعات
    ''' </summary>
    Private Sub AddBillingReferenceIfNeeded(invoice As Invoice, srcInv As Integer, srcDate As DateTime)
        Dim invoiceTypeId As Integer = invoice.invoiceTypeCode.id

        If invoiceTypeId = 383 OrElse invoiceTypeId = 381 Then
            Dim docReference As New InvoiceDocumentReference()
            docReference.ID = $"Invoice Number: {srcInv}; Invoice Issue Date: {srcDate:yyyy-MM-dd}"
            invoice.billingReference.invoiceDocumentReferences.Add(docReference)
        End If
    End Sub

#End Region

#Region "تعيين المراجع الإضافية"

    ''' <summary>
    ''' تعيين مراجع المستندات الإضافية (PIH و ICV)
    ''' </summary>
    Private Sub SetAdditionalDocumentReferences(invoice As Invoice, invId As String,
                                             ByRef icvValue As Long, ByRef branchUuid As Long)
        ' القيمة الافتراضية لـ PIH
        Dim pihValue As String = "NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ=="

        icvValue = Conversions.ToLong(invId)
        branchUuid = Conversions.ToLong(invId)

        ' جلب PIH من الفرع
        Dim branchData As DataTable = GetBranchData()
        If branchData.Rows.Count > 0 Then
            Dim branchPih As String = GetSafeString(branchData.Rows(0), 0)
            If Not String.IsNullOrEmpty(branchPih) Then
                Try
                    branchUuid = Convert.ToInt64(branchData.Rows(0)(1)) + 1L
                Catch ex As Exception
                    ' تجاهل الخطأ
                End Try
            End If
        End If

        ' جلب PIH من المؤسسة
        Dim foundationPihData As DataTable = GetFoundationPIHData()
        If foundationPihData.Rows.Count > 0 Then
            Dim foundationPih As String = GetSafeString(foundationPihData.Rows(0), 0)
            If Not String.IsNullOrEmpty(foundationPih) Then
                pihValue = foundationPih
                Try
                    icvValue = Convert.ToInt64(foundationPihData.Rows(0)(1)) + 1L
                Catch ex As Exception
                    ' تجاهل الخطأ
                End Try
            End If
        End If

        invoice.AdditionalDocumentReferencePIH.EmbeddedDocumentBinaryObject = pihValue
        invoice.AdditionalDocumentReferenceICV.UUID = icvValue
    End Sub

#End Region

#Region "تعيين بيانات التسليم والدفع"

    ''' <summary>
    ''' تعيين معلومات التسليم والدفع
    ''' </summary>
    Private Sub SetDeliveryAndPaymentInfo(invoice As Invoice, invDate As DateTime, payType As Integer)
        ' بيانات التسليم
        invoice.delivery.ActualDeliveryDate = invDate.ToString("yyyy-MM-dd")
        invoice.delivery.LatestDeliveryDate = invDate.ToString("yyyy-MM-dd")

        ' طريقة الدفع
        Dim paymentMethod As String = GetPaymentMethod(payType)
        If Not String.IsNullOrEmpty(paymentMethod) Then
            Dim paymentMeans As New PaymentMeans()
            paymentMeans.PaymentMeansCode = paymentMethod
            paymentMeans.InstructionNote = "Payment Notes"
            invoice.paymentmeans.Add(paymentMeans)
        End If
    End Sub

#End Region

#Region "تعيين بيانات الأطراف"

    ''' <summary>
    ''' تعيين بيانات المورد (البائع)
    ''' </summary>
    Private Sub SetSupplierPartyInfo(invoice As Invoice, foundationData As DataTable)
        Dim row As DataRow = foundationData.Rows(0)

        With invoice.SupplierParty
            ' معرف الطرف
            .partyIdentification.ID = GetSafeString(row, "bsn_no")
            .partyIdentification.schemeID = "CRN"

            ' العنوان البريدي
            With .postalAddress
                .StreetName = GetSafeString(row, "street")
                .AdditionalStreetName = ""
                .BuildingNumber = GetSafeString(row, "build_no")
                .CityName = GetSafeString(row, "city")
                .PostalZone = GetSafeString(row, "post_code")
                .CountrySubentity = GetSafeString(row, "gov")
                .CitySubdivisionName = GetSafeString(row, "area")
                .country.IdentificationCode = "SA"
            End With

            ' الكيان القانوني
            .partyLegalEntity.RegistrationName = GetSafeString(row, "nameA")

            ' الرقم الضريبي
            .partyTaxScheme.CompanyID = GetSafeString(row, "tax_no")
        End With
    End Sub

    ''' <summary>
    ''' تعيين بيانات العميل (المشتري)
    ''' </summary>
    Private Sub SetCustomerPartyInfo(invoice As Invoice, customerData As DataTable)
        Dim row As DataRow = customerData.Rows(0)

        With invoice.CustomerParty
            ' معرف الطرف
            .partyIdentification.ID = GetSafeString(row, "cr")
            .partyIdentification.schemeID = "CRN"

            ' العنوان البريدي
            With .postalAddress
                .StreetName = GetSafeString(row, "street")
                .AdditionalStreetName = ""
                .BuildingNumber = GetSafeString(row, "build_no")
                .PlotIdentification = "9833"
                .CityName = GetNameById("cities", GetSafeInteger(row, "city"))
                .PostalZone = GetSafeString(row, "post_code")
                .CountrySubentity = GetNameById("Countries", GetSafeInteger(row, "country"))
                .CitySubdivisionName = GetNameById("areas", GetSafeInteger(row, "area"))
                .country.IdentificationCode = "SA"
            End With

            ' الكيان القانوني
            .partyLegalEntity.RegistrationName = GetSafeString(row, "name")

            ' الرقم الضريبي
            .partyTaxScheme.CompanyID = GetSafeString(row, "tax_no")
        End With
    End Sub

#End Region

#Region "الخصومات والمبالغ"

    ''' <summary>
    ''' إضافة الخصم إذا وجد
    ''' </summary>
    Private Sub AddDiscountIfExists(invoice As Invoice, discountAmount As Double)
        Dim discount As Decimal = 0D
        Decimal.TryParse(discountAmount.ToString(), discount)

        If discount > 0D Then
            Dim allowanceCharge As New AllowanceCharge()
            With allowanceCharge
                .ChargeIndicator = False
                .MultiplierFactorNumeric = 0D
                .BaseAmount = 0D
                .Amount = discount
                .AllowanceChargeReasonCode = ""
                .AllowanceChargeReason = "discount"
                .taxCategory.ID = "S"
                .taxCategory.Percent = 15D
            End With
            invoice.allowanceCharges.Add(allowanceCharge)
        End If
    End Sub

    ''' <summary>
    ''' تعيين المبالغ الإجمالية
    ''' </summary>
    Private Sub SetMonetaryTotals(invoice As Invoice, netAmount As Double)
        With invoice.legalMonetaryTotal
            .PayableRoundingAmount = 0D
            .PrepaidAmount = 0D
            .PayableAmount = New Decimal(netAmount)
        End With
    End Sub

#End Region

#Region "بنود الفاتورة"

    ''' <summary>
    ''' إضافة بنود الفاتورة
    ''' </summary>
    Private Sub AddInvoiceLines(invoice As Invoice, itemsTable As DataTable)
        Me.invlines = New List(Of ZatcaIntegration.InvoiceItems)()

        ' تحويل البيانات إلى قائمة البنود
        For Each row As DataRow In itemsTable.Rows
            Dim item As New ZatcaIntegration.InvoiceItems()
            With item
                .ProductName = Conversions.ToString(row("name"))
                .ProductPrice = New Decimal(Conversion.Val(row("price")))
                .ProductQuantity = New Decimal(Conversion.Val(row("quan")))
                .TotalPrice = New Decimal(Conversion.Val(row("total")))
                .DiscountValue = New Decimal(Conversion.Val(row("disc")))
                .TotalPriceAfterDiscount = New Decimal(Conversion.Val(row("totalafterdisc")))
                .VatPercentage = New Decimal(Conversion.Val(row("vatperc")))
                .VatValue = New Decimal(Conversion.Val(row("vat")))
                .TotalWithVat = New Decimal(Conversion.Val(row("net")))
            End With
            Me.invlines.Add(item)
        Next

        ' إضافة البنود للفاتورة
        For Each item As ZatcaIntegration.InvoiceItems In Me.invlines
            Dim invoiceLine As New InvoiceLine()
            SetInvoiceLineData(invoiceLine, item)
            invoice.InvoiceLines.Add(invoiceLine)
        Next
    End Sub

    ''' <summary>
    ''' تعيين بيانات بند الفاتورة
    ''' </summary>
    Private Sub SetInvoiceLineData(invoiceLine As InvoiceLine, item As ZatcaIntegration.InvoiceItems)
        invoiceLine.InvoiceQuantity = item.ProductQuantity
        invoiceLine.item.Name = item.ProductName

        ' تحديد فئة الضريبة
        If item.VatPercentage = 0D Then
            ' معفي من الضريبة
            SetZeroVatCategory(invoiceLine)
        Else
            ' خاضع للضريبة
            SetStandardVatCategory(invoiceLine, item.VatPercentage)
        End If

        ' السعر
        invoiceLine.price.EncludingVat = False
        invoiceLine.price.PriceAmount = item.ProductPrice

        ' الخصم على مستوى البند
        If item.DiscountValue > 0D Then
            AddLineDiscount(invoiceLine, item.DiscountValue)
        End If
    End Sub

    ''' <summary>
    ''' تعيين فئة ضريبة صفرية
    ''' </summary>
    Private Sub SetZeroVatCategory(invoiceLine As InvoiceLine)
        invoiceLine.item.classifiedTaxCategory.ID = "Z"
        invoiceLine.item.classifiedTaxCategory.Percent = 0D

        invoiceLine.taxTotal.TaxSubtotal.taxCategory.ID = "Z"
        invoiceLine.taxTotal.TaxSubtotal.taxCategory.Percent = 0D
        invoiceLine.taxTotal.TaxSubtotal.taxCategory.TaxExemptionReasonCode = "VATEX-SA-HEA"
        invoiceLine.taxTotal.TaxSubtotal.taxCategory.TaxExemptionReason = "Private healthcare to citizen"
    End Sub

    ''' <summary>
    ''' تعيين فئة ضريبة قياسية
    ''' </summary>
    Private Sub SetStandardVatCategory(invoiceLine As InvoiceLine, vatPercentage As Decimal)
        invoiceLine.item.classifiedTaxCategory.ID = "S"
        invoiceLine.item.classifiedTaxCategory.Percent = vatPercentage

        invoiceLine.taxTotal.TaxSubtotal.taxCategory.ID = "S"
        invoiceLine.taxTotal.TaxSubtotal.taxCategory.Percent = vatPercentage
    End Sub

    ''' <summary>
    ''' إضافة خصم على مستوى البند
    ''' </summary>
    Private Sub AddLineDiscount(invoiceLine As InvoiceLine, discountValue As Decimal)
        Dim allowanceCharge As New AllowanceCharge()
        With allowanceCharge
            .ChargeIndicator = False
            .AllowanceChargeReason = "discount"
            .Amount = discountValue
            .MultiplierFactorNumeric = 0D
            .BaseAmount = 0D
        End With
        invoiceLine.allowanceCharges.Add(allowanceCharge)
    End Sub

#End Region

#Region "توليد XML وإرسال الفاتورة"

    ''' <summary>
    ''' تعيين معلومات الشهادة
    ''' </summary>
    Private Sub SetCertificateInfo(invoice As Invoice, foundationData As DataTable)
        Dim row As DataRow = foundationData.Rows(0)
        invoice.cSIDInfo.CertPem = GetSafeString(row, "public_key")
        invoice.cSIDInfo.PrivateKey = GetSafeString(row, "private_key")
    End Sub

    ''' <summary>
    ''' توليد XML الفاتورة
    ''' </summary>
    Private Function GenerateInvoiceXML(ublxml As UBLXML, invoice As Invoice) As Boolean
        Try
            Me.res = ublxml.GenerateInvoiceXML(invoice, Directory.GetCurrentDirectory(), True)

            If Not Me.res.IsValid Then
                MessageBox.Show(Me.res.ErrorMessage)
                Return False
            End If

            Return True

        Catch ex As Exception
            MessageBox.Show($"{ex.Message}{vbLf}{vbLf}{ex.InnerException}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' تحديث مراجع قاعدة البيانات
    ''' </summary>
    Private Sub UpdateDatabaseReferences(icvValue As Long, branchUuid As Long)
        Try
            OpenConnectionSafely()

            ' تحديث الفرع
            Dim branchSql As String =
            $"UPDATE branches SET pih = '{Me.res.InvoiceHash}', uuid = {branchUuid} " &
            $"WHERE id = {MainClass.BranchNo}"
            ExecuteNonQuery(branchSql)

            ' تحديث المؤسسة
            Dim foundationSql As String =
            $"UPDATE foundation SET pih = '{Me.res.InvoiceHash}', uuid = {icvValue}"
            ExecuteNonQuery(foundationSql)

        Catch ex As Exception
            HandleError("UpdateDatabaseReferences", ex)
        Finally
            CloseConnectionSafely()
        End Try
    End Sub

    ''' <summary>
    ''' إرسال الفاتورة لزاتكا
    ''' </summary>
    Private Function SendInvoiceToZatca(invoice As Invoice, foundationData As DataTable) As Boolean
        Dim integrationType As Integer = GetIntegrationType(foundationData)
        Dim apiMode As Mode = GetApiMode(integrationType)

        Dim apiRequest As New ApiRequestLogic(apiMode, "", False)
        Dim reportingRequest As InvoiceReportingRequest = CreateReportingRequest()

        Select Case integrationType
            Case 1
                ' وضع التطوير - Compliance
                Return ProcessComplianceMode(apiRequest, reportingRequest, foundationData)

            Case Else
                ' وضع الإنتاج أو المحاكاة
                Return ProcessProductionMode(apiRequest, reportingRequest, invoice, foundationData)
        End Select
    End Function

    ''' <summary>
    ''' الحصول على نوع التكامل
    ''' </summary>
    Private Function GetIntegrationType(foundationData As DataTable) As Integer
        Try
            Return Convert.ToInt32(foundationData.Rows(0)("zatc_integ_type"))
        Catch ex As Exception
            Return 1
        End Try
    End Function

    ''' <summary>
    ''' الحصول على وضع API
    ''' </summary>
    Private Function GetApiMode(integrationType As Integer) As Mode
        Select Case integrationType
            Case 2
                Me.mode = Mode.Simulation
            Case 3
                Me.mode = Mode.Production
            Case Else
                Me.mode = Mode.developer
        End Select
        Return Me.mode
    End Function

    ''' <summary>
    ''' إنشاء طلب الإبلاغ
    ''' </summary>
    Private Function CreateReportingRequest() As InvoiceReportingRequest
        Dim request As New InvoiceReportingRequest()
        request.invoice = Me.res.EncodedInvoice
        request.invoiceHash = Me.res.InvoiceHash
        request.uuid = Me.res.UUID
        Return request
    End Function

    ''' <summary>
    ''' معالجة وضع Compliance (التطوير)
    ''' </summary>
    Private Function ProcessComplianceMode(apiRequest As ApiRequestLogic,
                                        reportingRequest As InvoiceReportingRequest,
                                        foundationData As DataTable) As Boolean
        ' الحصول على CSID
        Dim csr As String = GetSafeString(foundationData.Rows(0), "csr")
        Dim csidResponse As ComplianceCsrResponse = apiRequest.GetComplianceCSIDAPI("123456", csr)

        If Not String.IsNullOrEmpty(csidResponse.ErrorMessage) Then
            Me.errmsg = csidResponse.ErrorMessage
            MessageBox.Show(csidResponse.ErrorMessage)
            Return False
        End If

        ' إرسال الفاتورة
        Dim response As InvoiceReportingResponse = apiRequest.CallComplianceInvoiceAPI(
        csidResponse.BinarySecurityToken, csidResponse.Secret, reportingRequest)

        Return ProcessApiResponse(response, Me.res.QRCode, 200)
    End Function

    ''' <summary>
    ''' معالجة وضع الإنتاج/المحاكاة
    ''' </summary>
    Private Function ProcessProductionMode(apiRequest As ApiRequestLogic,
                                        reportingRequest As InvoiceReportingRequest,
                                        invoice As Invoice,
                                        foundationData As DataTable) As Boolean
        Dim password As String = GetSafeString(foundationData.Rows(0), "secret_code")
        Dim encodedCert As String = Utility.ToBase64Encode(invoice.cSIDInfo.CertPem)

        ' التحقق من نوع الفاتورة (B2B أو B2C)
        If invoice.invoiceTypeCode.Name.StartsWith("01") Then
            ' B2B - Clearance
            Return ProcessClearanceRequest(apiRequest, encodedCert, password, reportingRequest)
        Else
            ' B2C - Reporting
            Return ProcessReportingRequest(apiRequest, encodedCert, password, reportingRequest)
        End If
    End Function

    ''' <summary>
    ''' معالجة طلب Clearance
    ''' </summary>
    Private Function ProcessClearanceRequest(apiRequest As ApiRequestLogic,
                                          encodedCert As String,
                                          password As String,
                                          reportingRequest As InvoiceReportingRequest) As Boolean
        Dim response As InvoiceClearanceResponse = apiRequest.CallClearanceAPI(
        encodedCert, password, reportingRequest)

        Me.StatusCode = response.StatusCode.ToString()

        If Not response.IsSuccess Then
            Me.errmsg = response.ErrorMessage
            MessageBox.Show(response.ErrorMessage)
            Return False
        End If

        Me.strQR = response.QRCode
        Me.QRImg = QrCodeImage(response.QRCode, 250, 250)

        If response.StatusCode = 202 Then
            Me.warningmsg = response.WarningMessage
        End If

        Return True
    End Function

    ''' <summary>
    ''' معالجة طلب Reporting
    ''' </summary>
    Private Function ProcessReportingRequest(apiRequest As ApiRequestLogic,
                                          encodedCert As String,
                                          password As String,
                                          reportingRequest As InvoiceReportingRequest) As Boolean
        Dim response As InvoiceReportingResponse = apiRequest.CallReportingAPI(
        encodedCert, password, reportingRequest)

        Return ProcessApiResponse(response, Me.res.QRCode, 250)
    End Function

    ''' <summary>
    ''' معالجة استجابة API
    ''' </summary>
    Private Function ProcessApiResponse(response As InvoiceReportingResponse,
                                     qrCode As String,
                                     qrSize As Integer) As Boolean
        Me.StatusCode = response.StatusCode.ToString()

        If Not response.IsSuccess Then
            Me.errmsg = response.ErrorMessage
            MessageBox.Show(response.ErrorMessage)
            Return False
        End If

        Me.strQR = qrCode
        Me.QRImg = QrCodeImage(qrCode, qrSize, qrSize)

        If response.StatusCode = 202 Then
            Me.warningmsg = response.WarningMessage
        End If

        Return True
    End Function

#End Region

#Region "دوال مساعدة"

    ''' <summary>
    ''' الحصول على قيمة نصية آمنة من DataRow
    ''' </summary>
    Private Function GetSafeString(row As DataRow, columnName As String) As String
        Try
            If row(columnName) IsNot DBNull.Value Then
                Return row(columnName).ToString()
            End If
        Catch ex As Exception
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' الحصول على قيمة نصية آمنة من DataRow بالفهرس
    ''' </summary>
    Private Function GetSafeString(row As DataRow, columnIndex As Integer) As String
        Try
            If row(columnIndex) IsNot DBNull.Value Then
                Return row(columnIndex).ToString()
            End If
        Catch ex As Exception
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' الحصول على قيمة رقمية آمنة من DataRow
    ''' </summary>
    Private Function GetSafeInteger(row As DataRow, columnName As String) As Integer
        Try
            If row(columnName) IsNot DBNull.Value Then
                Return Convert.ToInt32(row(columnName))
            End If
        Catch ex As Exception
        End Try
        Return -1
    End Function

    ''' <summary>
    ''' الحصول على الاسم بالمعرف
    ''' </summary>
    Private Function GetNameById(tableName As String, id As Integer) As String
        If id = -1 Then Return ""
        Return GetNamByID(tableName, id)
    End Function

    ''' <summary>
    ''' فتح الاتصال بشكل آمن
    ''' </summary>
    Private Sub OpenConnectionSafely()
        If Me.conn.State <> ConnectionState.Open Then
            Me.conn.Open()
        End If
    End Sub

    ''' <summary>
    ''' إغلاق الاتصال بشكل آمن
    ''' </summary>
    Private Sub CloseConnectionSafely()
        If Me.conn.State <> ConnectionState.Closed Then
            Me.conn.Close()
        End If
    End Sub

    ''' <summary>
    ''' تنفيذ استعلام بدون إرجاع
    ''' </summary>
    Private Sub ExecuteNonQuery(sql As String)
        Using cmd As New SqlCommand(sql, Me.conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>
    ''' معالجة الأخطاء
    ''' </summary>
    Private Sub HandleError(methodName As String, ex As Exception)
        Debug.WriteLine($"خطأ في {methodName}: {ex.Message}")
    End Sub

#End Region

    '///////////////////////////////
    Private Class InvoiceItems
		Public Sub New()
		End Sub

        Public Property ProductName As String
        Public Property ProductPrice As Decimal
        Public Property ProductQuantity As Decimal
        Public Property TotalPrice As Decimal
        Public Property DiscountValue As Decimal
        Public Property TotalPriceAfterDiscount As Decimal
        Public Property VatPercentage As Decimal
        Public Property VatValue As Decimal
        Public Property TotalWithVat As Decimal
    End Class
	End Class
