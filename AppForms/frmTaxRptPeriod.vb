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
Imports AQSYS.AQSYS.rptt
Public Partial Class frmTaxRptPeriod
		Inherits Form

		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

Private conn As SqlConnection
		Shared Sub New()
		End Sub

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmTaxRptPeriod_Load
			frmTaxRptPeriod.__ENCAddToList(Me)
			Me.conn = MainClass.ConnObj()
			Me.InitializeComponent()
		End Sub
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = frmTaxRptPeriod.__ENCList
			Dim flag As Boolean = False
			Try
				Monitor.Enter(_ENCList, flag)
				Dim flag2 As Boolean = frmTaxRptPeriod.__ENCList.Count = frmTaxRptPeriod.__ENCList.Capacity
				If flag2 Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = frmTaxRptPeriod.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit While
						End If
						Dim weakReference As WeakReference = frmTaxRptPeriod.__ENCList(num4)
						flag2 = weakReference.IsAlive
						If flag2 Then
							Dim flag3 As Boolean = num4 <> num
							If flag3 Then
								frmTaxRptPeriod.__ENCList(num) = frmTaxRptPeriod.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					frmTaxRptPeriod.__ENCList.RemoveRange(num, frmTaxRptPeriod.__ENCList.Count - num)
					frmTaxRptPeriod.__ENCList.Capacity = frmTaxRptPeriod.__ENCList.Count
				End If
				frmTaxRptPeriod.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			Finally
				Dim flag3 As Boolean = flag
				If flag3 Then
					Monitor.[Exit](_ENCList)
				End If
			End Try
		End Sub

  Private Sub btnShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShow.Click
			Try
				Dim value As Integer = 3410001
				Dim isAccTreeNew As Boolean = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value = 31010001
				End If
				Dim value2 As Integer = 3410005
				isAccTreeNew = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value2 = 1103040001
				End If
				Dim value3 As Integer = 4110001
				isAccTreeNew = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value3 = 41010001
				End If
				Dim value4 As Integer = 4110005
				isAccTreeNew = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value4 = 2100120001
				End If
				Dim value5 As Integer = 3410002
				isAccTreeNew = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value5 = 41010002
				End If
				Dim value6 As Integer = 4110003
				isAccTreeNew = MainClass.IsAccTreeNew
				If isAccTreeNew Then
					value6 = 31010003
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value3), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtSaleVal.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("credit"))))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value4), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtSaleTax.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("credit"))))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value6), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtSaleRetVal.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("dept"))))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value4), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtSaleRetTax.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("dept"))))
				Me.txtSaleTaxNet.Text = Conversions.ToString(Conversion.Val(Me.txtSaleTax.Text) - Conversion.Val(Me.txtSaleRetTax.Text))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtPurchVal.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("dept"))))
				Try
					sqlDataAdapter = New SqlDataAdapter("select sum(val2) from sandSD where IS_Deleted=0 and date>=@date1 and date<=@date2 and vat<>0", Me.conn)
					sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
					sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
					dataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Me.txtPurchVal.Text = Conversions.ToString(Conversion.Val(Me.txtPurchVal.Text) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))))
				Catch ex As Exception
				End Try
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value2), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtPurchTax.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("dept"))))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value5), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtPurchRetVal.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("credit"))))
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where  Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.date>=@date1 and Restrictions.date<=@date2 and Restrictions.id=Restrictions_Sub.res_id and Restrictions_Sub.acc_no=" + Conversions.ToString(value2), Me.conn)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDateFrom.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDateTo.Value.AddDays(1.0).ToShortDateString()
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtPurchRetTax.Text = Conversions.ToString(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("credit"))))
				Me.txtPurchTaxNet.Text = Conversions.ToString(Conversion.Val(Me.txtPurchTax.Text) - Conversion.Val(Me.txtPurchRetTax.Text))
				Me.txtNetSaleTax.Text = Me.txtSaleTaxNet.Text
				Me.txtNetPurchTax.Text = Me.txtPurchTaxNet.Text
				Me.txtNetTax.Text = Conversions.ToString(Conversion.Val(Me.txtSaleTaxNet.Text) - Conversion.Val(Me.txtPurchTaxNet.Text))
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub PrintRpt(type As Integer)
			Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
			obj = New rptTax()
			Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateFrom" }, Nothing, Nothing, Nothing), TextObject)
			textObject.Text = Me.txtDateFrom.Value.ToShortDateString()
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtDateTo" }, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = Me.txtDateTo.Value.ToShortDateString()
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sale1" }, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = Me.txtSaleVal.Text
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sale2" }, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.txtSaleRetVal.Text
			Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sale3" }, Nothing, Nothing, Nothing), TextObject)
			textObject5.Text = Me.txtSaleTax.Text
			Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sale4" }, Nothing, Nothing, Nothing), TextObject)
			textObject6.Text = Me.txtSaleRetTax.Text
			Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "sale5" }, Nothing, Nothing, Nothing), TextObject)
			textObject7.Text = Me.txtSaleTaxNet.Text
			Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "purch1" }, Nothing, Nothing, Nothing), TextObject)
			textObject8.Text = Me.txtPurchVal.Text
			Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "purch2" }, Nothing, Nothing, Nothing), TextObject)
			textObject9.Text = Me.txtPurchRetVal.Text
			Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "purch3" }, Nothing, Nothing, Nothing), TextObject)
			textObject10.Text = Me.txtPurchTax.Text
			Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "purch4" }, Nothing, Nothing, Nothing), TextObject)
			textObject11.Text = Me.txtPurchRetTax.Text
			Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "purch5" }, Nothing, Nothing, Nothing), TextObject)
			textObject12.Text = Me.txtPurchTaxNet.Text
			Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "net1" }, Nothing, Nothing, Nothing), TextObject)
			textObject13.Text = Me.txtNetPurchTax.Text
			Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "net2" }, Nothing, Nothing, Nothing), TextObject)
			textObject14.Text = Me.txtNetSaleTax.Text
			Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 1 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "net3" }, Nothing, Nothing, Nothing), TextObject)
			textObject15.Text = Me.txtNetTax.Text
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim instance As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() { "rptHeader" }, Nothing, Nothing, Nothing)
			Dim type2 As Type = Nothing
			Dim memberName As String = "SetDataSource"
			Dim array As Object() = New Object() { dataTable }
			Dim arguments As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True }
			NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
			If array2(0) Then
				dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
			End If
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtAddress" }, Nothing, Nothing, Nothing), TextObject)
				textObject16.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Address")))
				Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtTel" }, Nothing, Nothing, Nothing), TextObject)
				textObject17.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Tel")))
				Dim textObject18 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtMobile" }, Nothing, Nothing, Nothing), TextObject)
				textObject18.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Mobile")))
				Dim textObject19 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() { 5 }, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() { "txtFax" }, Nothing, Nothing, Nothing), TextObject)
				textObject19.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Fax")))
			End If
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
			frmRptViewer.WindowState = FormWindowState.Maximized
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim num As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					Dim instance2 As Object = obj
					Dim type3 As Type = Nothing
					Dim memberName2 As String = "PrintToPrinter"
					Dim array3 As Object() = New Object() { 1, False, 1, num }
					Dim arguments2 As Object() = array3
					Dim argumentNames2 As String() = Nothing
					Dim typeArguments2 As Type() = Nothing
					array2 = New Boolean() { False, False, False, True }
					NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
					If array2(3) Then
						num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(3)), GetType(Integer)))
					End If
				Catch ex As Exception
				End Try
			End If
		End Sub

  Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.PrintRpt(1)
		End Sub

  Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
			Me.PrintRpt(2)
		End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub

  Private Sub frmTaxRptPeriod_Load(ByVal sender As Object, ByVal e As EventArgs)' Handles frmTaxRptPeriod.Load
			Me.txtDateFrom.Value = DateTime.Now
			Me.txtDateTo.Value = DateTime.Now
		End Sub
	End Class
