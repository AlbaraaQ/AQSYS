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
Imports System.IO
Imports System.IO.Ports
Imports System.Printing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
	Public Partial Class frmFonudation
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection

		Private Code As Integer
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.frmFonudation_KeyDown
			AddHandler MyBase.Load, AddressOf Me.frmFonudation_Load
			frmFonudation.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.Code = -1
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmFonudation.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmFonudation.__ENCList.Count = frmFonudation.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmFonudation.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmFonudation.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmFonudation.__ENCList(num) = frmFonudation.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmFonudation.__ENCList.RemoveRange(num, frmFonudation.__ENCList.Count - num)
					frmFonudation.__ENCList.Capacity = frmFonudation.__ENCList.Count
				End If
				frmFonudation.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
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
				Dim enumerationFlag As EnumeratedPrintQueueTypes() = New EnumeratedPrintQueueTypes() { EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections, EnumeratedPrintQueueTypes.[Shared] }
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

  Private Sub frmFonudation_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmFonudation.Load
			' The following expression was wrapped in a checked-statement
			Try
				Me.TabControl1.TabPages.Remove(Me.tpZakat)
				Dim flag As Boolean = MainClass.IsTrial
				If flag Then
					Me.btnOpenFile.Enabled = False
				End If
				Try
					Dim portNames As String() = SerialPort.GetPortNames()
					For Each item As String In portNames
						Me.cmbPorts.Items.Add(item)
					Next
				Catch ex As Exception
				End Try
				Me.GetPrinters1()
				Try
					flag = MainClass.hide_retention
					If flag Then
						Me.lblRetention.Visible = False
						Me.txtRetention.Visible = False
					End If
				Catch ex2 As Exception
				End Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.Code = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("id")))))
					Me.txtNameAr.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("nameA")))
					Me.txtNameEn.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("nameE")))
					Try
						Me.txtNameAr.Enabled = False
						Me.txtNameEn.Enabled = False
						Try
							flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("edit_compname")))
							If flag Then
								Me.txtNameAr.Enabled = True
								Me.txtNameEn.Enabled = True
							End If
						Catch ex3 As Exception
						End Try
					Catch ex4 As Exception
					End Try
					Me.txtField.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("FieldA")))
					Me.txtFieldEn.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("FieldE")))
					Me.txtBusnNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("bsn_no")))
					Me.txtLicenceNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("licence_no")))
					Me.txtAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Address")))
					Me.txtTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Tel")))
					Me.txtMobile.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Mobile")))
					Me.txtFax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Fax")))
					Me.txtEmail.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Email")))
					Me.txtWebsite.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("website")))
					Me.txtExchange.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Exchangeval")))
					Try
						Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax")))
					Catch ex5 As Exception
					End Try
					Try
						Me.cmbPorts.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("port")))
					Catch ex6 As Exception
					End Try
					Try
						Me.txtTaxNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax_no")))
					Catch ex7 As Exception
					End Try
					Try
						Me.txtCustDisc.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("CustDisc")))
					Catch ex8 As Exception
					End Try
					Try
						Me.chkShowDisc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("showdisc")))
						Me.chkShowAfterDisc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("showafterdisc")))
						Me.chkShowTax.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("showtax")))
					Catch ex9 As Exception
					End Try
					Try
						Me.txtBank1.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("bank1")))
						Me.txtAcc1.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("acc1")))
						Me.txtBank2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("bank2")))
						Me.txtAcc2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("acc2")))
						Me.txtBank3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("bank3")))
						Me.txtAcc3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("acc3")))
					Catch ex10 As Exception
					End Try
					Try
						Me.txtIBAN1.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("iban1")))
						Me.txtIBAN2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("iban2")))
						Me.txtIBAN3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("iban3")))
						Me.txtSWIFT1.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("swift1")))
						Me.txtSWIFT2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("swift2")))
						Me.txtSWIFT3.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("swift3")))
					Catch ex11 As Exception
					End Try
					flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("Logo")))
					If flag Then
						Me.picLogo.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("Logo"), Byte()))
					End If
					Try
						Me.txtAddressEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("AddressEn")))
					Catch ex12 As Exception
					End Try
					Try
						Me.txtMsg.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("msg")))
					Catch ex13 As Exception
					End Try
					Try
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("offer_type"), 1, False)
						If flag Then
							Me.rdOffers1.Checked = True
						Else
							flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("offer_type"), 2, False)
							If flag Then
								Me.rdOffers2.Checked = True
							End If
						End If
					Catch ex14 As Exception
					End Try
					Try
						Me.txtTab3Name.Text = Conversions.ToString(dataTable.Rows(0)("tab3_name"))
						flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3")))
						If flag Then
							Me.chkTab3.Checked = True
							Me.txtTab3Val.Text = Conversions.ToString(dataTable.Rows(0)("tab3val"))
						End If
					Catch ex15 As Exception
					End Try
					Try
						Me.chkBarcode.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_barcode")))
					Catch ex16 As Exception
					End Try
					Try
						Me.chkLimitQuan.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_limit")))
					Catch ex17 As Exception
					End Try
					Try
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)("rptinv_type"), 1, False)
						If flag Then
							Me.rdinvtype1.Checked = True
						Else
							Me.rdinvtype2.Checked = True
						End If
					Catch ex18 As Exception
					End Try
					Try
						Me.chkLastPurchPrice.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("showlastpurch")))
					Catch ex19 As Exception
					End Try
					Try
						Me.chkShowBarcode.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("show_barcode")))
					Catch ex20 As Exception
					End Try
					Try
						Me.chkExpire.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("chk_expire")))
					Catch ex21 As Exception
					End Try
					Try
						Me.chkActvCustDisc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_custdisc")))
					Catch ex22 As Exception
					End Try
					Try
						Me.chkActvManfc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_manfc")))
					Catch ex23 As Exception
					End Try
					Try
						Me.txtSalesTitle.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sales_title")))
					Catch ex24 As Exception
					End Try
					Try
						Me.txtSalesTitle2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("sales_title2")))
					Catch ex25 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("vat_type"))) = 2)
						If flag Then
							Me.chkInTax.Checked = True
						End If
					Catch ex26 As Exception
					End Try
					Try
						Me.chkPrintSanadHeader.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_sanad_header")))
						Me.chkPrintSanadFooter.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_sanad_footer")))
					Catch ex27 As Exception
					End Try
					Try
						Me.chklblheader.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_lbl_header")))
					Catch ex28 As Exception
					End Try
					Try
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("start_purch")), "", False)
						If flag Then
							Me.txtStartPurch.Value = New Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("start_purch"))))
						End If
					Catch ex29 As Exception
					End Try
					Try
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("start_sales")), "", False)
						If flag Then
							Me.txtStartSales.Value = New Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("start_sales"))))
						End If
					Catch ex30 As Exception
					End Try
					Try
						Me.chkActvStamp.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_stamp")))
					Catch ex31 As Exception
					End Try
					Try
						flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("stamp")))
						If flag Then
							Me.picStamp.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("stamp"), Byte()))
						End If
					Catch ex32 As Exception
					End Try
					Try
						Me.chkPrinterAnother.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_print2")))
						Me.cmbPrinters.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("printer2")))
					Catch ex33 As Exception
					End Try
					Try
						Me.chkPurchOperateNo.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_operateno")))
						Me.chkPurchExpire.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_expire")))
						Me.chkSalesOperateNo.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sales_operateno")))
						Me.chkSalesExpire.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sales_expire")))
					Catch ex34 As Exception
					End Try
					Try
						Me.chkShowInvSign.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("show_inv_sign")))
					Catch ex35 As Exception
					End Try
					Try
						Me.chkQREnc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_qr_enc")))
					Catch ex36 As Exception
					End Try
					Try
						Me.chkClientLastSale.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_client_lastsale")))
					Catch ex37 As Exception
					End Try
					Try
						Me.chkClientsCreditLimit.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("chk_client_creditlimit")))
					Catch ex38 As Exception
					End Try
					Try
						Me.txtRetention.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("retention")))
					Catch ex39 As Exception
					End Try
					Try
						Me.cmbPaperList.SelectedIndex = 0
						Me.cmbPaperList.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("paper_id"))) - 1
					Catch ex40 As Exception
					End Try
					Try
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("currency_name")), "", False)
						If flag Then
							Me.txtCurrency.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("currency_name")))
						End If
					Catch ex41 As Exception
					End Try
					Try
						Me.chkPrintOpenTawlas.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_opentawlas")))
					Catch ex42 As Exception
					End Try
					Try
						Me.chkPrintCustBalance.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_custbalance")))
					Catch ex43 As Exception
					End Try
					Try
						Me.txtInvDiscName.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("inv_disc_name")))
					Catch ex44 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("storeclose_pricetype"))) = 2)
						If flag Then
							Me.rdStoreClosePriceType2.Checked = True
						Else
							flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("storeclose_pricetype"))) = 3)
							If flag Then
								Me.rdStoreClosePriceType3.Checked = True
							End If
						End If
					Catch ex45 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("barcode_read_type"))) = 2)
						If flag Then
							Me.rdBarcodeReadType2.Checked = True
						End If
					Catch ex46 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("inv_type"))) = 2)
						If flag Then
							Me.rdInvTypeAgel.Checked = True
						End If
					Catch ex47 As Exception
					End Try
					Try
						Me.chkTab3Item.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3_items")))
						Me.chkTb3ItemsMinFee.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3_items_minfee")))
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("tab3_items_minfee")), "", False)
						If flag Then
							Me.txtTab3ItemsMinFee.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tab3_items_minfee")))
						End If
					Catch ex48 As Exception
					End Try
					Try
						Me.chkPrintElecInv.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_elecinv")))
					Catch ex49 As Exception
					End Try
					Try
						Me.txtStreet.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("street")))
						Me.txtGov.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("gov")))
						Me.txtCity.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("city")))
						Me.txtArea.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("area")))
						Me.txtStreetEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("street_EN")))
						Me.txtGovEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("gov_EN")))
						Me.txtCityEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("city_EN")))
						Me.txtAreaEN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("area_EN")))
						Me.txtBuildNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("build_no")))
						Me.txtPostCode.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("post_code")))
						Me.txtAddNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("add_no")))
						Me.txtCRN.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("crn_no")))
					Catch ex50 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("consume_type"))) = 1)
						If flag Then
							Me.rdConsumeSale.Checked = True
						Else
							Me.rdConsumeProduct.Checked = True
						End If
					Catch ex51 As Exception
					End Try
					Try
						Me.chkActvRestPrintNew.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("actv_rest_print_new")))
					Catch ex52 As Exception
					End Try
					Try
						Me.chkPrintFileOut.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_file_out")))
					Catch ex53 As Exception
					End Try
					Try
						Me.chkPrintImg.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("print_img")))
					Catch ex54 As Exception
					End Try
					Try
						flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("img_gm")))
						If flag Then
							Me.picGM.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("img_gm"), Byte()))
						End If
					Catch ex55 As Exception
					End Try
					Try
						flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("img_pm")))
						If flag Then
							Me.picPM.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("img_pm"), Byte()))
						End If
					Catch ex56 As Exception
					End Try
					Try
						flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("img_pb")))
						If flag Then
							Me.picPB.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("img_pb"), Byte()))
						End If
					Catch ex57 As Exception
					End Try
					Try
						Me.txtCSR.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("csr")))
						Me.txtPrivateKey.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("private_key")))
						Me.txtPublicKey.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("public_key")))
						Me.txtSecretCode.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("secret_code")))
					Catch ex58 As Exception
					End Try
					Try
						Me.chkZatcInteg.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_zatc_integ")))
						Me.chkPreventInvZatcFail.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_prevent_inv_zatc_fail")))
					Catch ex59 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("zatc_integ_type"))) = 2)
						If flag Then
							Me.rdb_simulation.Checked = True
						Else
							flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("zatc_integ_type"))) = 3)
							If flag Then
								Me.rdb_production.Checked = True
							End If
						End If
					Catch ex60 As Exception
					End Try
					Try
						flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_zakat")))
						If flag Then
							Me.TabControl1.TabPages.Add(Me.tpZakat)
						End If
					Catch ex61 As Exception
					End Try
					Try
						Me.chkSandQStamp.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_sandQ_stamp")))
					Catch ex62 As Exception
					End Try
					Try
						Me.chkSandQSign.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_sandQ_sign")))
					Catch ex63 As Exception
					End Try
					Try
						flag = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sandQ_sign")))
						If flag Then
							Me.picSign.Image = MainClass.Arr2Image(CType(dataTable.Rows(0)("sandQ_sign"), Byte()))
						End If
					Catch ex64 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("clienttype_default"))) = 2)
						If flag Then
							Me.rdClientTypeCash.Checked = True
						End If
					Catch ex65 As Exception
					End Try
					Try
						flag = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("kit_print_type"))) = 2)
						If flag Then
							Me.chkPrintKit2.Checked = True
						End If
					Catch ex66 As Exception
					End Try
					Try
						Me.chkActvPoNo.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_pono")))
					Catch ex67 As Exception
					End Try
					Try
						Me.chkShowStampRecDoc.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("show_stamp_recdoc")))
					Catch ex68 As Exception
					End Try
				End If
			Catch ex69 As Exception
			End Try
			Try
				Dim flag As Boolean = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
				If flag Then
					Dim streamReader As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
					Dim left As String = streamReader.ReadLine()
					Dim left2 As String = streamReader.ReadLine()
					streamReader.Close()
					flag = (Operators.CompareString(left, "0", False) = 0)
					If flag Then
						Me.chkInvHeader.Checked = False
					End If
					flag = (Operators.CompareString(left2, "0", False) = 0)
					If flag Then
						Me.chkInvFooter.Checked = False
					End If
				End If
			Catch ex70 As Exception
			End Try
			Try
				Dim flag As Boolean = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invquan.txt")
				If flag Then
					Dim streamReader2 As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invquan.txt")
					Dim left3 As String = streamReader2.ReadLine()
					streamReader2.Close()
					flag = (Operators.CompareString(left3, "0", False) = 0)
					If flag Then
						Me.chkQuan.Checked = False
					End If
				End If
			Catch ex71 As Exception
			End Try
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtNameAr.Text.Trim(), "", False) = 0
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
					If flag2 Then
						MessageBox.Show("يجب ادخال اسم المؤسسة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Enter company name", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.txtNameAr.Focus()
				Else
					Dim flag2 As Boolean = Operators.CompareString(Me.txtNameEn.Text.Trim(), "", False) = 0
					If flag2 Then
						flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
						If flag Then
							MessageBox.Show("يجب ادخال اسم المؤسسة باللغة الانجليزية", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							MessageBox.Show("Enter company english name", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
						Me.txtNameEn.Focus()
					Else
						flag2 = (Operators.CompareString(Me.txtField.Text.Trim(), "", False) = 0)
						If flag2 Then
							flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
							If flag Then
								MessageBox.Show("يجب ادخال النشاط التجاري", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								MessageBox.Show("Enter the field", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
							Me.txtField.Focus()
						Else
							flag2 = (Operators.CompareString(Me.txtTel.Text.Trim(), "", False) = 0)
							If flag2 Then
								flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
								If flag Then
									MessageBox.Show("يجب ادخال رقم الهاتف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Else
									MessageBox.Show("Enter Tel.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End If
								Me.txtTel.Focus()
							Else
								flag2 = (Operators.CompareString(Me.txtMobile.Text.Trim(), "", False) = 0)
								If flag2 Then
									flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
									If flag Then
										MessageBox.Show("يجب ادخال رقم الجوال", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Else
										MessageBox.Show("Enter mobile", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									End If
									Me.txtMobile.Focus()
								Else
									Try
										flag2 = Not Me.txtNameAr.Enabled
										If flag2 Then
											Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select nameA,nameE,last_name,last_nameE from Foundation", Me.conn)
											Dim dataTable As DataTable = New DataTable()
											sqlDataAdapter.Fill(dataTable)
											flag2 = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("last_name")), Operators.ConcatenateObject("", dataTable.Rows(0)("nameA")), False), Operators.CompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("last_nameE")), Operators.ConcatenateObject("", dataTable.Rows(0)("nameE")), False)))
											If flag2 Then
												MessageBox.Show("تم التلاعب في إسم المؤسسة، يرجى التواصل مع الدعم الفني", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
												Return
											End If
										End If
									Catch ex As Exception
									End Try
									flag2 = (Me.conn.State <> ConnectionState.Open)
									If flag2 Then
										Me.conn.Open()
									End If
									Dim value As Integer = 0
									Dim value2 As Integer = 0
									Dim value3 As Integer = 0
									flag2 = Me.chkShowDisc.Checked
									If flag2 Then
										value = 1
									End If
									flag2 = Me.chkShowAfterDisc.Checked
									If flag2 Then
										value2 = 1
									End If
									flag2 = Me.chkShowTax.Checked
									If flag2 Then
										value3 = 1
									End If
									Dim value4 As Integer = 1
									flag2 = Me.rdOffers2.Checked
									If flag2 Then
										value4 = 2
									End If
									Dim value5 As Integer = 1
									flag2 = Me.rdinvtype2.Checked
									If flag2 Then
										value5 = 2
									End If
									Dim value6 As Integer = 0
									Dim value7 As Double = 0.0
									flag2 = Me.chkTab3.Checked
									If flag2 Then
										value6 = 1
										value7 = Conversion.Val(Me.txtTab3Val.Text)
									End If
									Dim value8 As Integer = 0
									flag2 = Me.chkBarcode.Checked
									If flag2 Then
										value8 = 1
									End If
									Dim value9 As Integer = 0
									flag2 = Me.chkLimitQuan.Checked
									If flag2 Then
										value9 = 1
									End If
									Dim value10 As Integer = 0
									flag2 = Me.chkLastPurchPrice.Checked
									If flag2 Then
										value10 = 1
									End If
									Dim value11 As Integer = 0
									flag2 = Me.chkShowBarcode.Checked
									If flag2 Then
										value11 = 1
									End If
									Dim value12 As Integer = 0
									flag2 = Me.chkExpire.Checked
									If flag2 Then
										value12 = 1
									End If
									Dim value13 As Integer = 0
									flag2 = Me.chkActvCustDisc.Checked
									If flag2 Then
										value13 = 1
									End If
									Dim value14 As Integer = 0
									flag2 = Me.chkActvManfc.Checked
									If flag2 Then
										value14 = 1
									End If
									Dim value15 As Integer = 1
									flag2 = Me.chkInTax.Checked
									If flag2 Then
										value15 = 2
									End If
									Dim value16 As Integer = 1
									flag2 = Not Me.chkPrintSanadHeader.Checked
									If flag2 Then
										value16 = 0
									End If
									Dim value17 As Integer = 1
									flag2 = Not Me.chkPrintSanadFooter.Checked
									If flag2 Then
										value17 = 0
									End If
									Dim value18 As Integer = 0
									flag2 = Me.chklblheader.Checked
									If flag2 Then
										value18 = 1
									End If
									Dim value19 As Integer = 0
									flag2 = Me.chkActvStamp.Checked
									If flag2 Then
										value19 = 1
									End If
									Dim value20 As Integer = 0
									flag2 = Me.chkPrinterAnother.Checked
									If flag2 Then
										value20 = 1
									End If
									Dim value21 As Integer = 0
									flag2 = Me.chkPurchOperateNo.Checked
									If flag2 Then
										value21 = 1
									End If
									Dim value22 As Integer = 0
									flag2 = Me.chkPurchExpire.Checked
									If flag2 Then
										value22 = 1
									End If
									Dim value23 As Integer = 0
									flag2 = Me.chkSalesOperateNo.Checked
									If flag2 Then
										value23 = 1
									End If
									Dim value24 As Integer = 0
									flag2 = Me.chkSalesExpire.Checked
									If flag2 Then
										value24 = 1
									End If
									Dim value25 As Integer = 0
									flag2 = Me.chkShowInvSign.Checked
									If flag2 Then
										value25 = 1
									End If
									Dim value26 As Integer = 0
									flag2 = Me.chkQREnc.Checked
									If flag2 Then
										value26 = 1
									End If
									Dim value27 As Integer = 0
									flag2 = Me.chkClientLastSale.Checked
									If flag2 Then
										value27 = 1
									End If
									Dim value28 As Integer = 0
									flag2 = Me.chkClientsCreditLimit.Checked
									If flag2 Then
										value28 = 1
									End If
									Dim value29 As Integer = 0
									flag2 = Me.chkPrintOpenTawlas.Checked
									If flag2 Then
										value29 = 1
									End If
									Dim value30 As Integer = 0
									flag2 = Me.chkPrintCustBalance.Checked
									If flag2 Then
										value30 = 1
									End If
									Dim value31 As Integer = 1
									flag2 = Me.rdStoreClosePriceType2.Checked
									If flag2 Then
										value31 = 2
									Else
										flag2 = Me.rdStoreClosePriceType3.Checked
										If flag2 Then
											value31 = 3
										End If
									End If
									Dim value32 As Integer = 1
									flag2 = Me.rdBarcodeReadType2.Checked
									If flag2 Then
										value32 = 2
									End If
									Dim value33 As Integer = 1
									flag2 = Me.rdInvTypeAgel.Checked
									If flag2 Then
										value33 = 2
									End If
									Dim value34 As Integer = 0
									Dim value35 As Double = 0.0
									flag2 = Me.chkTab3Item.Checked
									If flag2 Then
										value34 = 1
										value35 = Conversion.Val(Me.txtTab3ItemsMinFee.Text)
									End If
									Dim value36 As Integer = 0
									flag2 = Me.chkTb3ItemsMinFee.Checked
									If flag2 Then
										value36 = 1
									End If
									Dim value37 As Integer = 0
									flag2 = Me.chkPrintElecInv.Checked
									If flag2 Then
										value37 = 1
									End If
									Dim value38 As Integer = 1
									flag2 = Me.rdConsumeProduct.Checked
									If flag2 Then
										value38 = 2
									End If
									Dim value39 As Integer = 0
									flag2 = Me.chkActvRestPrintNew.Checked
									If flag2 Then
										value39 = 1
									End If
									Dim value40 As Integer = 0
									flag2 = Me.chkPrintFileOut.Checked
									If flag2 Then
										value40 = 1
									End If
									Dim value41 As Integer = 0
									flag2 = Me.chkPrintImg.Checked
									If flag2 Then
										value41 = 1
									End If
									Dim value42 As Integer = 0
									flag2 = Me.chkZatcInteg.Checked
									If flag2 Then
										value42 = 1
									End If
									Dim value43 As Integer = 0
									flag2 = Me.chkPreventInvZatcFail.Checked
									If flag2 Then
										value43 = 1
									End If
									Dim value44 As Integer = 1
									flag2 = Me.rdb_simulation.Checked
									If flag2 Then
										value44 = 2
									Else
										flag2 = Me.rdb_production.Checked
										If flag2 Then
											value44 = 3
										End If
									End If
									Dim value45 As Integer = 0
									flag2 = Me.chkSandQStamp.Checked
									If flag2 Then
										value45 = 1
									End If
									Dim value46 As Integer = 0
									flag2 = Me.chkSandQSign.Checked
									If flag2 Then
										value46 = 1
									End If
									Dim value47 As Integer = 1
									flag2 = Me.rdClientTypeCash.Checked
									If flag2 Then
										value47 = 2
									End If
									Dim value48 As Integer = 1
									flag2 = Me.chkPrintKit2.Checked
									If flag2 Then
										value48 = 2
									End If
									Dim value49 As Integer = 0
									flag2 = Me.chkActvPoNo.Checked
									If flag2 Then
										value49 = 1
									End If
									Dim value50 As Integer = 0
									flag2 = Me.chkShowStampRecDoc.Checked
									If flag2 Then
										value50 = 1
									End If
									flag2 = (Me.Code <> -1)
									If flag2 Then
										' The following expression was wrapped in a checked-expression
										Dim sqlCommand As SqlCommand = New SqlCommand(String.Concat(New String() { "update Foundation set nameA='", Me.txtNameAr.Text, "',nameE='", Me.txtNameEn.Text, "',last_name='", Me.txtNameAr.Text, "',last_nameE='", Me.txtNameEn.Text, "',FieldA='", Me.txtField.Text, "',FieldE='", Me.txtFieldEn.Text, "',bsn_no='", Me.txtBusnNo.Text, "',licence_no='", Me.txtLicenceNo.Text, "',Address='", Me.txtAddress.Text, "',Tel='", Me.txtTel.Text, "',Mobile='", Me.txtMobile.Text, "',Fax='", Me.txtFax.Text, "',Email='", Me.txtEmail.Text, "',website='", Me.txtWebsite.Text, "',Logo=@Logo,Exchangeval=", Conversions.ToString(Conversion.Val(Me.txtExchange.Text)), ",tax=", Conversions.ToString(Conversion.Val(Me.txtTax.Text)), ",port='", Me.cmbPorts.Text, "',tax_no='", Me.txtTaxNo.Text, "',CustDisc=", Conversions.ToString(Conversion.Val(Me.txtCustDisc.Text)), ",showdisc=", Conversions.ToString(value), ",showafterdisc=", Conversions.ToString(value2), ",showtax=", Conversions.ToString(value3), ",bank1='", Me.txtBank1.Text, "',acc1='", Me.txtAcc1.Text, "',bank2='", Me.txtBank2.Text, "',acc2='", Me.txtAcc2.Text, "',bank3='", Me.txtBank3.Text, "',acc3='", Me.txtAcc3.Text, "',AddressEn='", Me.txtAddressEN.Text, "',msg='", Me.txtMsg.Text, "',offer_type=", Conversions.ToString(value4), ",tab3_name='", Me.txtTab3Name.Text, "',is_tab3=", Conversions.ToString(value6), ",tab3val=", Conversions.ToString(value7), ",is_barcode=", Conversions.ToString(value8), ",is_limit=", Conversions.ToString(value9), ",rptinv_type=", Conversions.ToString(value5), ",showlastpurch=", Conversions.ToString(value10), ",show_barcode=", Conversions.ToString(value11), ",chk_expire=", Conversions.ToString(value12), ",actv_custdisc=", Conversions.ToString(value13), ",actv_manfc=", Conversions.ToString(value14), ",vat_type=", Conversions.ToString(value15), ",sales_title='", Me.txtSalesTitle.Text, "',sales_title2='", Me.txtSalesTitle2.Text, "',print_sanad_header=", Conversions.ToString(value16), ",print_sanad_footer=", Conversions.ToString(value17), ",is_lbl_header=", Conversions.ToString(value18), ",start_purch=", Conversions.ToString(Me.txtStartPurch.Value), ",start_sales=", Conversions.ToString(Me.txtStartSales.Value), ",actv_stamp=", Conversions.ToString(value19), ",stamp=@stamp,actv_print2=", Conversions.ToString(value20), ",printer2='", Me.cmbPrinters.Text, "',purch_operateno=", Conversions.ToString(value21), ",purch_expire=", Conversions.ToString(value22), ",sales_operateno=", Conversions.ToString(value23), ",sales_expire=", Conversions.ToString(value24), ",show_inv_sign=", Conversions.ToString(value25), ",is_qr_enc=", Conversions.ToString(value26), ",is_client_lastsale=", Conversions.ToString(value27), ",chk_client_creditlimit=", Conversions.ToString(value28), ",retention='", Me.txtRetention.Text, "',paper_id=", Conversions.ToString(Me.cmbPaperList.SelectedIndex + 1), ",currency_name='", Me.txtCurrency.Text, "',print_opentawlas=", Conversions.ToString(value29), ",print_custbalance=", Conversions.ToString(value30), ",inv_disc_name='", Me.txtInvDiscName.Text.Trim(), "',storeclose_pricetype=", Conversions.ToString(value31), ",barcode_read_type=", Conversions.ToString(value32), ",inv_type=", Conversions.ToString(value33), ",is_tab3_items=", Conversions.ToString(value34), ",is_tab3_items_minfee=", Conversions.ToString(value36), ",tab3_items_minfee=", Conversions.ToString(value35), ",print_elecinv=", Conversions.ToString(value37), ",iban1='", Me.txtIBAN1.Text, "',iban2='", Me.txtIBAN2.Text, "',iban3='", Me.txtIBAN3.Text, "',swift1='", Me.txtSWIFT1.Text, "',swift2='", Me.txtSWIFT2.Text, "',swift3='", Me.txtSWIFT3.Text, "',street='", Me.txtStreet.Text, "',gov='", Me.txtGov.Text, "',city='", Me.txtCity.Text, "',area='", Me.txtArea.Text, "',street_EN='", Me.txtStreetEN.Text, "',gov_EN='", Me.txtGovEN.Text, "',city_EN='", Me.txtCityEN.Text, "',area_EN='", Me.txtAreaEN.Text, "',build_no='", Me.txtBuildNo.Text, "',post_code='", Me.txtPostCode.Text, "',add_no='", Me.txtAddNo.Text, "',crn_no='", Me.txtCRN.Text, "',consume_type=", Conversions.ToString(value38), ",edit_compname=0,actv_rest_print_new=", Conversions.ToString(value39), ",print_file_out=", Conversions.ToString(value40), ",print_img=", Conversions.ToString(value41), ",img_gm=@img_gm,img_pm=@img_pm,img_pb=@img_pb,csr='", Me.txtCSR.Text, "',private_key='", Me.txtPrivateKey.Text, "',public_key='", Me.txtPublicKey.Text, "',secret_code='", Me.txtSecretCode.Text, "',is_zatc_integ=", Conversions.ToString(value42), ",is_prevent_inv_zatc_fail=", Conversions.ToString(value43), ",zatc_integ_type=", Conversions.ToString(value44), ",is_sandQ_stamp=", Conversions.ToString(value45), ",is_sandQ_sign=", Conversions.ToString(value46), ",sandQ_sign=@sandQ_sign,clienttype_default=", Conversions.ToString(value47), ",kit_print_type=", Conversions.ToString(value48), ",is_zakat=0,is_pono=", Conversions.ToString(value49), ",show_stamp_recdoc=", Conversions.ToString(value50), " where id=", Conversions.ToString(Me.Code) }), Me.conn)
										flag2 = (Me.picLogo.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@logo", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picLogo.Image)
										Else
											sqlCommand.Parameters.Add("@logo", SqlDbType.Image).Value = DBNull.Value
										End If
										flag2 = (Me.picStamp.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@stamp", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picStamp.Image)
										Else
											sqlCommand.Parameters.Add("@stamp", SqlDbType.Image).Value = DBNull.Value
										End If
										flag2 = (Me.picGM.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@img_gm", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picGM.Image)
										Else
											sqlCommand.Parameters.Add("@img_gm", SqlDbType.Image).Value = DBNull.Value
										End If
										flag2 = (Me.picPM.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@img_pm", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picPM.Image)
										Else
											sqlCommand.Parameters.Add("@img_pm", SqlDbType.Image).Value = DBNull.Value
										End If
										flag2 = (Me.picPB.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@img_pb", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picPB.Image)
										Else
											sqlCommand.Parameters.Add("@img_pb", SqlDbType.Image).Value = DBNull.Value
										End If
										flag2 = (Me.picSign.Image IsNot Nothing)
										If flag2 Then
											sqlCommand.Parameters.Add("@sandQ_sign", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picSign.Image)
										Else
											sqlCommand.Parameters.Add("@sandQ_sign", SqlDbType.Image).Value = DBNull.Value
										End If
										sqlCommand.ExecuteNonQuery()
									Else
										Dim sqlCommand2 As SqlCommand = New SqlCommand(String.Concat(New String() { "insert into Foundation(id,nameA,nameE,FieldA,FieldE,bsn_no,licence_no,Address,Tel,Mobile,Fax,Email,website,Logo,Exchangeval,tax,port,tax_no,CustDisc,showdisc,showafterdisc,showtax,bank1,acc1,bank2,acc2,bank3,acc3,AddressEn,msg,offer_type,tab3_name,is_tab3,tab3val,is_barcode,is_limit,rptinv_type,showlastpurch,show_barcode,chk_expire,actv_custdisc,actv_manfc) values (1,'", Me.txtNameAr.Text, "','", Me.txtNameEn.Text, "','", Me.txtField.Text, "','", Me.txtFieldEn.Text, "','", Me.txtBusnNo.Text, "','", Me.txtLicenceNo.Text, "','", Me.txtAddress.Text, "','", Me.txtTel.Text, "','", Me.txtMobile.Text, "','", Me.txtFax.Text, "','", Me.txtEmail.Text, "','", Me.txtWebsite.Text, "',@logo,", Conversions.ToString(Conversion.Val(Me.txtExchange.Text)), ",", Conversions.ToString(Conversion.Val(Me.txtTax.Text)), ",'", Me.cmbPorts.Text, "','", Me.txtTaxNo.Text, "',", Conversions.ToString(Conversion.Val(Me.txtCustDisc.Text)), ",", Conversions.ToString(value), ",", Conversions.ToString(value2), ",", Conversions.ToString(value3), ",'", Me.txtBank1.Text, "','", Me.txtAcc1.Text, "','", Me.txtBank2.Text, "','", Me.txtAcc2.Text, "','", Me.txtBank3.Text, "','", Me.txtAcc3.Text, "','", Me.txtAddressEN.Text, "','", Me.txtMsg.Text, "',", Conversions.ToString(value4), ",'", Me.txtTab3Name.Text, "',", Conversions.ToString(value6), ",", Conversions.ToString(value7), ",", Conversions.ToString(value8), ",", Conversions.ToString(value9), ",", Conversions.ToString(value5), ",", Conversions.ToString(value10), ",", Conversions.ToString(value11), ",", Conversions.ToString(value12), ",", Conversions.ToString(value13), ",", Conversions.ToString(value14), ")" }), Me.conn)
										flag2 = (Me.picLogo.Image IsNot Nothing)
										If flag2 Then
											sqlCommand2.Parameters.Add("@logo", SqlDbType.Image).Value = MainClass.Image2Arr(Me.picLogo.Image)
										Else
											sqlCommand2.Parameters.Add("@logo", SqlDbType.Image).Value = DBNull.Value
										End If
										sqlCommand2.ExecuteNonQuery()
									End If
									Me.txtNameAr.Enabled = False
									Me.txtNameEn.Enabled = False
									Try
										Dim str As String = "1"
										Dim str2 As String = "1"
										flag2 = Not Me.chkInvHeader.Checked
										If flag2 Then
											str = "0"
										End If
										flag2 = Not Me.chkInvFooter.Checked
										If flag2 Then
											str2 = "0"
										End If
										Dim contents As String = "1"
										flag2 = Not Me.chkQuan.Checked
										If flag2 Then
											contents = "0"
										End If
										File.WriteAllText(System.Windows.Forms.Application.StartupPath + "\\invprint.txt", str + Environment.NewLine + str2)
										File.WriteAllText(System.Windows.Forms.Application.StartupPath + "\\invquan.txt", contents)
									Catch ex2 As Exception
									End Try
								flag2 = Me.chklblheader.Checked
								Dim Form1 As New Form1()
								If flag2 Then
										Form1.pnlHeader.Visible = True
										Form1.lblHeader.Text = Me.txtNameAr.Text
									Else
										Form1.pnlHeader.Visible = False
									End If
									Try
										flag2 = (Operators.CompareString(Me.txtRetention.Text.Trim(), "", False) <> 0)
										If flag2 Then
											Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from accounts_index where code=1260002", Me.conn)
											Dim dataTable2 As DataTable = New DataTable()
											sqlDataAdapter2.Fill(dataTable2)
											flag2 = (dataTable2.Rows.Count = 0)
											If flag2 Then
											End If
										End If
									Catch ex3 As Exception
									End Try
									Try
										flag2 = Me.chkZatcInteg.Checked
										If flag2 Then
											Form1.picFatoora.Visible = True
										Else
											Form1.picFatoora.Visible = False
										End If
									Catch ex4 As Exception
									End Try
									flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
									If flag2 Then
										MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Else
										MessageBox.Show("Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									End If
									Try
										Me.TabControl1.TabPages.Remove(Me.tpZakat)
									Catch ex5 As Exception
									End Try
								End If
							End If
						End If
					End If
				End If
			Catch ex6 As Exception
				Dim text As String = "خطأ أثناء الحفظ"
				text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex6.Message
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text = "Error during saving"
					text = text + Environment.NewLine + "Error details: " + ex6.Message
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Finally
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
				If flag2 Then
					Me.conn.Close()
				End If
			End Try
		End Sub

  Private Sub btnOpenFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenFile.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtLogoPath.Text = Me.OpenFileDialog1.FileName
					Me.picLogo.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub frmFonudation_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) 'Handles frmFonudation.KeyDown
		End Sub

  Private Sub Label15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label15.Click
		End Sub

  Private Sub Label7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label7.Click
		End Sub

  Private Sub Label24_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label24.Click
		End Sub

  Private Sub chkInvHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkInvHeader.CheckedChanged
		End Sub

  Private Sub chkTab3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTab3.CheckedChanged
			Try
				Dim checked As Boolean = Me.chkTab3.Checked
				If checked Then
					Me.txtTab3Name.Enabled = True
					Me.txtTab3Val.Enabled = True
				Else
					Me.txtTab3Name.Enabled = False
					Me.txtTab3Val.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtStampPath.Text = Me.OpenFileDialog1.FileName
					Me.picStamp.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub chkTab3Item_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTab3Item.CheckedChanged
			Try
				Dim checked As Boolean = Me.chkTab3Item.Checked
				If checked Then
					Me.pnlTb3Item.Visible = True
				Else
					Me.pnlTb3Item.Visible = False
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtGMPath.Text = Me.OpenFileDialog1.FileName
					Me.picGM.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtPMPath.Text = Me.OpenFileDialog1.FileName
					Me.picPM.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtPBPath.Text = Me.OpenFileDialog1.FileName
					Me.picPB.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub

  Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
			Try
				Me.OpenFileDialog1.Filter = "All Files|*.*|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|TIFF|*.tiff|PNG|*.png"
				Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					Me.txtSignPath.Text = Me.OpenFileDialog1.FileName
					Me.picSign.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
