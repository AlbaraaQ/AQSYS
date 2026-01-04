Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.[Shared]
Imports CrystalDecisions.Windows.Forms
Imports GenCode128
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.IO.Ports
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Partial Public Class frmSalePurch


	Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

	Private conn As SqlConnection

	Private conn1 As SqlConnection

	Private Code As Integer

	Private ProcCode As Integer

	Private RestPurchCode As Integer

	Private RestSaleCode As Integer

	Public InvProc As Integer

	Private DGV_Count As Integer

	Private ISTRialEnd As Boolean

	Private hamode As String

	Public IS_manfc As Boolean

	Private taxno As String

	Private _DefaultBank As Integer

	Private _IsUpdateDG As Boolean

	Private sp As SerialPort

	Private _fieldname As String

	Private _gfieldname As String

	Private _Exchangeal As Double

	Private _foundname As String

	Private _IsEditInvPerm As Boolean

	Private _ShowBarcode As Boolean

	Private chk_Expire As Boolean

	Private _IsBuy As Integer

	Private Sales_title As String

	Private Sales_title2 As String

	Private _VatVal As Double

	Private _SendEmail As Boolean

	Private _showPurchOperateno As Boolean

	Private _showPurchExpire As Boolean

	Private _showSalesOperateno As Boolean

	Private _showSalesExpire As Boolean

	Private _lastclientsale As Boolean

	Private _chkclientcreditlimit As Boolean

	Private _BarcodeReadType As Integer

	Private _PrintElecInv As Boolean

	Private _PrintFileOut As Boolean

	Private _PrintImg As Boolean

	Private _ZatcInteg As Boolean

	Private _PreventInvZatcFail As Boolean

	Private _IsAmmand As Boolean

	Public _IsCreditNote As Boolean

	Public _IsPoNo As Boolean

	Public _IsReAPI As Boolean

	Private _ReadCompleted As Boolean

	Private _CustDiscAdded As Double

	Private _custdisc As Double

	Private chkcurr As Boolean

	Private _newproc As Boolean

	Private pbImage2 As PictureBox

	Private _hidetel As Boolean

	Private _loaded As Boolean

	Private _EnteredBarcode As String

	Private _BarcodeProcess As Boolean

	Private _ismezan As Boolean

	Private dochange As Boolean

	Private calcFunc As String

	Private hasDecimal As Boolean

	Private valHolder1 As Double

	Private valHolder2 As Double

	Private _lastdisc As Decimal

	Public dochange1 As Boolean

	Public dochange2 As Boolean

	Private _chkCustTel As Boolean

	Public ClientID As Integer

	Private _DoChangeValPrice As Boolean

	Public ItemID As Integer
	Shared Sub New()
	End Sub

	Public Sub New()

		AddHandler MyBase.Load, AddressOf Me.frmSalePurch_Load
		AddHandler MyBase.FormClosing, AddressOf Me.frmSalePurch_FormClosing
		AddHandler MyBase.KeyDown, AddressOf Me.frmSalePurch_KeyDown
		frmSalePurch.__ENCAddToList(Me)
		Me.conn = MainClass.ConnObj()
		Me.conn1 = MainClass.ConnObj()
		Me.Code = -1
		Me.ProcCode = -1
		Me.RestPurchCode = -1
		Me.RestSaleCode = -1
		Me.InvProc = 1
		Me.DGV_Count = 0
		Me.ISTRialEnd = False
		Me.IS_manfc = False
		Me.taxno = ""
		Me._DefaultBank = -1
		Me._IsUpdateDG = False
		'Me.sp = New SerialPort("COM1", 9600, Parity.None, 8, StopBits.One)
		Me._fieldname = "symbol"
		Me._gfieldname = "name"
		Me._Exchangeal = 1250.0
		Me._foundname = ""
		Me._IsEditInvPerm = True
		Me._ShowBarcode = True
		Me.chk_Expire = True
		Me._IsBuy = 1
		Me.Sales_title = ""
		Me.Sales_title2 = ""
		Me._VatVal = 0.0
		Me._SendEmail = False
		Me._showPurchOperateno = False
		Me._showPurchExpire = False
		Me._showSalesOperateno = False
		Me._showSalesExpire = False
		Me._lastclientsale = False
		Me._chkclientcreditlimit = False
		Me._BarcodeReadType = 1
		Me._PrintElecInv = False
		Me._PrintFileOut = False
		Me._PrintImg = False
		Me._ZatcInteg = False
		Me._PreventInvZatcFail = False
		Me._IsAmmand = False
		Me._IsCreditNote = False
		Me._IsPoNo = False
		Me._IsReAPI = False
		Me._ReadCompleted = True
		Me._CustDiscAdded = 0.0
		Me._custdisc = 0.0
		Me.chkcurr = True
		Me._newproc = True
		Me.pbImage2 = New PictureBox()
		Me._hidetel = False
		Me._loaded = False
		Me._EnteredBarcode = ""
		Me._BarcodeProcess = False
		Me._ismezan = False
		Me.dochange = True
		Me._lastdisc = 0D
		Me.dochange1 = False
		Me.dochange2 = False
		Me._chkCustTel = True
		Me.ClientID = -1
		Me._DoChangeValPrice = True
		Me.ItemID = -1
		Me.InitializeComponent()
	End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmSalePurch.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmSalePurch.__ENCList.Count = frmSalePurch.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmSalePurch.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmSalePurch.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmSalePurch.__ENCList(num) = frmSalePurch.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmSalePurch.__ENCList.RemoveRange(num, frmSalePurch.__ENCList.Count - num)
				frmSalePurch.__ENCList.Capacity = frmSalePurch.__ENCList.Count
			End If
			frmSalePurch.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub CLR()
		Dim frmChargeData As New frmChargeData()
		Me.txtBarcode.Focus()
		Dim num As Integer = Convert.ToInt32(Me.NumericUpDown1.Value)
		Me._newproc = True
		Dim selectedIndex As Integer = Me.cmbProcType.SelectedIndex
		MainClass.CLRForm(Me)
		Me.cmbProcType.SelectedIndex = selectedIndex
		Me.cmbProcTypeSrch.SelectedIndex = selectedIndex
		Me.dgvItems.Rows.Clear()
		Me.Code = -1
		Me.ProcCode = -1
		Me.cmbType.SelectedIndex = 1
		Me.txtInvoicePeriod.Value = 1D
		Me.GetDefaultInvType()
		Me._IsUpdateDG = False
		Me.txtSrcInvNo.Enabled = True
		Me.chkHold.Checked = False
		Me.LoadSafes(False)
		Me.LoadStocks(False)
		Me.cmbSafe.Enabled = True
		Me.cmbStock.Enabled = True
		Dim flag As Boolean = Me._DefaultBank <> -1
		If flag Then
			Me.cmbBanks.SelectedValue = Me._DefaultBank
		End If
		flag = (Me.cmbBanks.Items.Count > 0 And Me._DefaultBank = -1)
		If flag Then
			Me.cmbBanks.SelectedIndex = 0
		End If
		flag = (Me.cmbClient.Items.Count > 0)
		If flag Then
			Me.cmbClient.SelectedIndex = 0
		End If
		flag = (Me.cmbSafe.Items.Count > 0)
		If flag Then
			Me.cmbSafe.SelectedIndex = 0
		End If
		flag = (Me.cmbStock.Items.Count > 0)
		If flag Then
			Me.cmbStock.SelectedIndex = 0
		End If
		Me.txtPaid.Text = "0"
		Me.txtTotPurch.Text = "0"
		Me.txtTotSale.Text = "0"
		Me.txtDiff.Text = "0"
		Me.txtInvCustDisc.Text = ""
		Me._custdisc = 0.0
		Me._CustDiscAdded = 0.0
		Me.chkIsVAT.Checked = True
		Me.GetTaxVal()
		Try
			frmChargeData.txtRecNo.Text = ""
			frmChargeData.txtRecDate.Value = DateTime.Now
			frmChargeData.txtRecPurchOrderNo.Text = ""
			frmChargeData.txtRecSaleOrderNo.Text = ""
			frmChargeData.txtRecChargeType.Text = ""
			frmChargeData.txtRecCustLoc.Text = ""
			frmChargeData.txtRecCustLocAddress.Text = ""
			frmChargeData.txtRecRespTel.Text = ""
			frmChargeData.txtRecCustVatNo.Text = ""
			frmChargeData.txtRecCar.Text = ""
			frmChargeData.txtRecCarNo.Text = ""
			frmChargeData.txtRecChargeTime.Text = ""
			frmChargeData.txtRecChargeAcc.Text = ""
			frmChargeData.txtRecDriver.Text = ""
		Catch ex As Exception
		End Try
		Try
			flag = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 1)
			If flag Then
				Dim num2 As Integer = 3410001
				flag = MainClass.IsAccTreeNew
				If flag Then
					num2 = 31010001
				End If
				Me.cmbAcc.SelectedValue = num2
			End If
		Catch ex2 As Exception
		End Try
		Try
			Me.sp.Open()
			Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
			Me.sp.WriteLine("WELCOME IN " + Me._foundname)
			Me.sp.Close()
		Catch ex3 As Exception
		End Try
		Me.lblCostPrice.Text = ""
		Me.chkDebtNote.Checked = False
		Me.chkMaintainance.Checked = False
		Me.txtMaintInvId.Text = ""
		Me.btnConvertToSales.Visible = False
		Me.NumericUpDown1.Value = New Decimal(num + 1)
		Me.NumericUpDown1.Value = New Decimal(num)
		Me.DGV_Count = 0
		Me.GroupBox3.Enabled = True
		Me.GroupBox7.Enabled = True
		Me.GroupBox8.Enabled = True
	End Sub

	Private Sub LoadDG(cond As String)
		Me.dgvSrch.Rows.Clear()
		Dim value As Integer = 1
		Dim flag As Boolean = Me.InvProc = 2
		If flag Then
			value = 0
		End If
		Dim text As String = ""
		flag = Me.IS_manfc
		If flag Then
			text = " is_manfc=1 and "
		End If
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Inv.proc_id,Inv.id as id,Inv.date as date,Customers.name as cust from Inv,Customers where proc_type=", Conversions.ToString(Me.cmbProcTypeSrch.SelectedIndex + 1), " and IS_Buy=", Conversions.ToString(value), " and Inv.IS_Deleted=0 and ", text, cond, " Inv.cust_id=Customers.id order by Inv.id"}), Me.conn)
		flag = (Operators.CompareString(cond, "", False) <> 0)
		If flag Then
			Dim dateTime As DateTime = Me.txtToDate.Value.AddHours(24.0)
			sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtFromDate.Value.ToShortDateString()
			sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = dateTime
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
			Me.dgvSrch.Rows(num3).Cells(0).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("proc_id"))
			Me.dgvSrch.Rows(num3).Cells(1).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("id"))
			Me.dgvSrch.Rows(num3).Cells(2).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("date"))).ToShortDateString()
			Me.dgvSrch.Rows(num3).Cells(3).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("cust"))
			num3 += 1
		End While
		Me.dgvSrch.ClearSelection()
	End Sub

	Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
		Me.CLR()
		Me.LoadInvNo()
		Me.txtMinusPerc.Text = Conversions.ToString(0)
	End Sub

	Public Sub LoadSalesMen()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from salesmen where IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbSalesMen.DataSource = dataTable
		Me.cmbSalesMen.DisplayMember = "name"
		Me.cmbSalesMen.ValueMember = "id"
		Me.cmbSalesMen.SelectedIndex = -1
	End Sub

	Public Sub LoadSafes(Optional _IsAll As Boolean = False)
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter()
		If _IsAll Then
			sqlDataAdapter = New SqlDataAdapter("select id,name from Safes where IS_Deleted=0 and status<>2 order by id", Me.conn1)
		Else
			sqlDataAdapter = New SqlDataAdapter("select id,name from Safes,Safe_Emps where Safes.id=Safe_Emps.safe_id and emp_id=" + Conversions.ToString(MainClass.EmpNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn1)
		End If
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbSafe.DataSource = dataTable
		Me.cmbSafe.DisplayMember = "name"
		Me.cmbSafe.ValueMember = "id"
		Me.cmbSafe.SelectedIndex = -1
	End Sub

	Public Sub LoadStocks(Optional _IsAll As Boolean = False)
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter()
		If _IsAll Then
			sqlDataAdapter = New SqlDataAdapter("select id,name from Stocks where IS_Deleted=0 and status<>2 order by id", Me.conn1)
		Else
			sqlDataAdapter = New SqlDataAdapter("select id,name from Stocks,Stock_Emps where Stocks.id=Stock_Emps.stock_id and emp_id=" + Conversions.ToString(MainClass.EmpNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn1)
		End If
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbStock.DataSource = dataTable
		Me.cmbStock.DisplayMember = "name"
		Me.cmbStock.ValueMember = "id"
		Me.cmbStock.SelectedIndex = -1
	End Sub

	Private Sub LoadErsSupp()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=2 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbErsSuppliers.DataSource = dataTable
		Me.cmbErsSuppliers.DisplayMember = "name"
		Me.cmbErsSuppliers.ValueMember = "id"
		Me.cmbErsSuppliers.SelectedIndex = -1
	End Sub

	Public Sub LoadCustomers()
		Dim value As Integer = 1
		Dim flag As Boolean = Me.InvProc = 1
		If flag Then
			value = 2
			flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag Then
				Me.lblClient.Text = "المورد"
				Me.lblClientSrch.Text = "المورد"
				Me.dgvSrch.Columns(3).HeaderText = "المورد"
			Else
				Me.lblClient.Text = "Supplier"
				Me.lblClientSrch.Text = "Supplier"
				Me.dgvSrch.Columns(3).HeaderText = "Supplier"
			End If
		End If
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where is_deleted=0 and type=" + Conversions.ToString(value) + " order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbClient.DataSource = dataTable
		Me.cmbClient.DisplayMember = "name"
		Me.cmbClient.ValueMember = "id"
		Me.cmbClient.SelectedIndex = -1
		Dim dataTable2 As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable2)
		Me.cmbClientSrch.DataSource = dataTable2
		Me.cmbClientSrch.DisplayMember = "name"
		Me.cmbClientSrch.ValueMember = "id"
		Me.cmbClientSrch.SelectedIndex = -1
	End Sub

	Public Sub LoadCurrency(group As Integer)
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where group_id=" + Conversions.ToString(group) + " and IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbCurrency.DataSource = dataTable
		Me.cmbCurrency.DisplayMember = "symbol"
		Me.cmbCurrency.ValueMember = "id"
	End Sub

	Public Sub LoadAllCurrency()
		Dim text As String = ""
		Dim flag As Boolean = Me.InvProc = 2
		If flag Then
			text += " (type is null or type=1 or type=3 or type=4) and "
		Else
			flag = Me.IS_manfc
			If flag Then
				text += " (type=3) and "
			End If
		End If
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol from Currencies where " + text + " IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbCurrency.DataSource = dataTable
		Me.cmbCurrency.DisplayMember = "symbol"
		Me.cmbCurrency.ValueMember = "id"
		Me.cmbCurrency.SelectedIndex = -1
	End Sub

	Private Sub LoadBaks()
		Try
			Dim str As String = "122"
			Dim flag As Boolean = MainClass.IsAccTreeNew
			If flag Then
				str = "1103012"
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select code,aname from Accounts_Index where parentcode='" + str + "'", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbBanks.DataSource = dataTable
			Me.cmbBanks.DisplayMember = "aname"
			Me.cmbBanks.ValueMember = "code"
			Me.cmbBanks.SelectedIndex = -1
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select default_bank from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = Conversions.ToBoolean(Operators.AndObject(dataTable2.Rows.Count > 0, Operators.CompareObjectNotEqual(dataTable2.Rows(0)(0), -1, False)))
				If flag Then
					Me._DefaultBank = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
					Me.cmbBanks.SelectedValue = Me._DefaultBank
				End If
			Catch ex As Exception
			End Try
			flag = (Me.cmbBanks.Items.Count > 0 And Me.cmbBanks.SelectedIndex = -1)
			If flag Then
				Me.cmbBanks.SelectedIndex = 0
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub txtVal1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVal1.KeyPress
		MainClass.IsFloat(e)
	End Sub

	Private Sub CalcTot()
		Dim num As Double = 0.0
		Dim num2 As Double = 0.0
		Dim num3 As Decimal = 0D
		Dim num4 As Double = 0.0
		Dim num5 As Double = 0.0
		Dim num6 As Double = 0.0
		Dim num7 As Double = 0.0
		Dim num8 As Integer = 0
		Dim num9 As Integer = Me.dgvItems.Rows.Count - 1
		Dim num10 As Integer = num8
		Dim flag As Boolean
		While True
			Dim num11 As Integer = num10
			Dim num12 As Integer = num9
			If num11 > num12 Then
				Exit While
			End If
			Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(num10).Cells(1), DataGridViewComboBoxCell)
			flag = Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, "شراء", False)
			If flag Then
				num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(8).Value))
				num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(13).Value))
			Else
				num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(8).Value))
				num5 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(13).Value))
			End If
			num3 = Decimal.Add(num3, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(4).Value)))
			num7 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(12).Value)) / 100.0 * Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(8).Value))
			num6 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num10).Cells(15).Value))
			num10 += 1
		End While
		flag = (num <> 0.0)
		Dim num13 As Double
		If flag Then
			num13 = num - num2
		Else
			num13 = num2
		End If
		Me.txtTotQuan.Text = "" + Conversions.ToString(num3)
		Me.txtTotPurch.Text = String.Format("{0:0.#,##.##}", num)
		Me.txtTotSale.Text = String.Format("{0:0.#,##.##}", num2)
		Me.txtDiff.Text = String.Format("{0:0.#,##.##}", num13)
		flag = (Me.InvProc = 1)
		If flag Then
			Me.txtTotAfterDisc.Text = String.Format("{0:0.#,##.##}", num4)
		Else
			Me.txtTotAfterDisc.Text = String.Format("{0:0.#,##.##}", num5)
		End If
		flag = Not Me.dochange2
		If flag Then
			Me.txtMinusVal.Text = "" + Conversions.ToString(Math.Round(num7, 3))
		End If
		flag = (Me.InvProc = 1)
		If flag Then
			Me.txtTotAfterDisc.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text) - Conversion.Val(Me.txtMinusVal.Text), 3))
		Else
			Me.txtTotAfterDisc.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text), 3))
		End If
		flag = (Me.InvProc = 1)
		If flag Then
			Dim num14 As Double = Conversions.ToDouble("" + Conversions.ToString(num6))
			Me.lblTaxVal.Text = "" + Conversions.ToString(num14)
			Me.txtDiff.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtTotPurch.Text) + num14 - Conversion.Val(Me.txtMinusVal.Text), 2))
		Else
			Dim num15 As Double = Conversions.ToDouble("" + Conversions.ToString(num6))
			Me.lblTaxVal.Text = "" + Conversions.ToString(num15)
			Me.txtDiff.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtTotSale.Text) + num15 - Conversion.Val(Me.txtMinusVal.Text) - Conversion.Val(Me.txtInvCustDisc.Text) - Conversion.Val(Me.txtRetention.Text), 2))
		End If
		flag = (Me.ProcCode = -1)
		If flag Then
			Me.txtCash.Text = Me.txtDiff.Text
			Me.txtNetwork.Text = ""
		End If
	End Sub

	Private Function GetCurrencyNo(name As String) As Integer
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from Currencies where symbol='" + name + "'", Me.conn1)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Return CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))))
	End Function

	Private Function GetCurrencyName(id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol from Currencies where id=" + Conversions.ToString(id), Me.conn1)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
	End Function

	Private Function GetOperateNo(id As Integer) As String
		Dim result As String
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select operate_no from Currencies where id=" + Conversions.ToString(id), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Catch ex As Exception
			result = ""
		End Try
		Return result
	End Function

	Private Function GetUnitName(id As Integer) As String
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from units where id=" + Conversions.ToString(id), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
		Catch ex As Exception
		End Try
		Return ""
	End Function

	Private Function CalcCurrencyStock() As Double
		' The following expression was wrapped in a checked-statement
		Dim result As Double
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("currency")
			dataTable.Columns.Add("sum")
			dataTable.Columns.Add("type")
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable2.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1})
				num3 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num6 As Integer = 0
			Dim num7 As Integer = dataTable2.Rows.Count - 1
			Dim num8 As Integer = num6
			While True
				Dim num9 As Integer = num8
				Dim num5 As Integer = num7
				If num9 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 2})
				num8 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num10 As Integer = 0
			Dim num11 As Integer = dataTable2.Rows.Count - 1
			Dim num12 As Integer = num10
			While True
				Dim num13 As Integer = num12
				Dim num5 As Integer = num11
				If num13 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 3})
				num12 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num14 As Integer = 0
			Dim num15 As Integer = dataTable2.Rows.Count - 1
			Dim num16 As Integer = num14
			While True
				Dim num17 As Integer = num16
				Dim num5 As Integer = num15
				If num17 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 4})
				num16 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num18 As Integer = 0
			Dim num19 As Integer = dataTable2.Rows.Count - 1
			Dim num20 As Integer = num18
			While True
				Dim num21 As Integer = num20
				Dim num5 As Integer = num19
				If num21 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 5})
				num20 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Me.cmbSafe.SelectedValue), " and currency="), Me.cmbCurrency.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num22 As Integer = 0
			Dim num23 As Integer = dataTable2.Rows.Count - 1
			Dim num24 As Integer = num22
			While True
				Dim num25 As Integer = num24
				Dim num5 As Integer = num23
				If num25 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 6})
				num24 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Me.cmbSafe.SelectedValue), " and currency="), Me.cmbCurrency.SelectedValue), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num26 As Integer = 0
			Dim num27 As Integer = dataTable2.Rows.Count - 1
			Dim num28 As Integer = num26
			While True
				Dim num29 As Integer = num28
				Dim num5 As Integer = num27
				If num29 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num28)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num28)(1))), 7})
				num28 += 1
			End While
			Dim num30 As Integer = dataTable.Rows.Count - 1
			Dim num31 As Integer = 0
			Dim num32 As Integer = num30
			Dim num33 As Integer = num31
			Dim flag3 As Boolean
			While True
				Dim num34 As Integer = num33
				Dim num5 As Integer = num32
				If num34 > num5 Then
					Exit While
				End If
				Dim num35 As Integer = num33 + 1
				Dim num36 As Integer = num30
				Dim num37 As Integer = num35
				While True
					Dim num38 As Integer = num37
					num5 = num36
					If num38 > num5 Then
						Exit While
					End If
					Dim flag As Boolean = num37 <= num30
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num33)(0), dataTable.Rows(num37)(0), False)
						If flag2 Then
							flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num33)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num33)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num33)(2), 7, False)))

							If flag3 Then
								dataTable.Rows(num33)(1) = -Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1)))
							End If
							flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 3, False), Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 4, False)), Operators.CompareObjectEqual(dataTable.Rows(num37)(2), 7, False)))
							If flag3 Then
								dataTable.Rows(num37)(1) = -Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
							End If
							dataTable.Rows(num33)(1) = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num33)(1))) + Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
							dataTable.Rows.RemoveAt(num37)

							num37 -= 1
							num30 -= 1
						End If
					End If
					num37 += 1
				End While
				num33 += 1
			End While
			flag3 = (dataTable.Rows.Count > 0)
			If flag3 Then
				result = Convert.ToDouble(dataTable.Rows(0)(1).ToString())
			Else
				result = 0.0
			End If
		Catch ex As Exception
			result = 0.0
		End Try
		Return result
	End Function

	Private Sub Add2DG()
		Me.txtBarcode.Focus()
		Dim flag As Boolean = Me.cmbClient.SelectedValue Is Nothing
		If flag Then
			Dim text As String = "اختر العميل"
			flag = (Me.InvProc = 1)
			If flag Then
				text = "اختر المورد"
			End If
			flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
			If flag Then
				text = "choose client"
				flag = (Me.InvProc = 1)
				If flag Then
					text = "choose supplier"
				End If
			End If
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbClient.Focus()
		Else
			flag = (Me.cmbCurrency.SelectedValue Is Nothing)
			If flag Then
				Dim text2 As String = "اختر الصنف"
				flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
				If flag Then
					text2 = "choose item"
				End If
				MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbCurrency.Focus()
			Else
				flag = (Operators.CompareString(Me.txtVal1.Text.Trim(), "", False) = 0 Or Conversion.Val(Me.txtVal1.Text) = 0.0)
				If flag Then
					Dim text3 As String = "ادخل الكمية"
					flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
					If flag Then
						text3 = "Enter value"
					End If
					MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.txtVal1.Focus()
				Else
					flag = (Me.cmbSafe.SelectedIndex = -1)
					If flag Then
						Dim text4 As String = "يجب اختيار المخزن"
						flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag Then
							text4 = "choose store"
						End If
						MessageBox.Show(text4, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.cmbSafe.Focus()
					Else
						Dim flag3 As Boolean
						Try
							flag = (Me.InvProc = 2)
							If flag Then
								Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select minprice from currencies where id=", Me.cmbCurrency.SelectedValue), " and unit="), Me.cmbUnits.SelectedValue)), Me.conn)
								Dim dataTable As DataTable = New DataTable()
								sqlDataAdapter.Fill(dataTable)
								flag = (dataTable.Rows.Count > 0)
								If flag Then
									Dim flag2 As Boolean = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) <> 0.0
									If flag2 Then
										flag3 = (Conversion.Val(Me.txtExchangeVal.Text) < Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))))
										If flag3 Then
											Interaction.MsgBox("لقد أدخلت السعر أقل من المسموح به", MsgBoxStyle.OkOnly, Nothing)
											Me.txtExchangeVal.Focus()
											Return
										End If
									End If
								End If
							End If
						Catch ex As Exception
						End Try
						Dim num As Double = Convert.ToDouble(Me.txtVal1.Text)
						Dim num2 As Double = Convert.ToDouble(Me.txtVal1.Text)
						Dim num3 As Decimal = 1D
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.perc from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.cmbUnits.SelectedValue), " and curr_units.curr="), Me.cmbCurrency.SelectedValue)), Me.conn)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag3 = (dataTable2.Rows.Count > 0)
						If flag3 Then
							num2 = num * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0)))
							num3 = New Decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))))
						End If
						Dim flag4 As Boolean = True
						Try
							flag3 = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invquan.txt")
							If flag3 Then
								Dim streamReader As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invquan.txt")
								Dim left As String = streamReader.ReadLine()
								streamReader.Close()
								flag3 = (Operators.CompareString(left, "0", False) = 0)
								If flag3 Then
									flag4 = False
								End If
							End If
						Catch ex2 As Exception
						End Try
						flag3 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 2 And Me.chkExpire.Checked)
						If flag3 Then
							Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("CalcStock", Me.conn1)
							sqlDataAdapter3.SelectCommand.CommandType = CommandType.StoredProcedure
							sqlDataAdapter3.SelectCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
							sqlDataAdapter3.SelectCommand.Parameters.Add("@stock", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbSafe.SelectedValue)
							sqlDataAdapter3.SelectCommand.Parameters.Add("@item", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
							sqlDataAdapter3.SelectCommand.Parameters.Add("@balance", SqlDbType.Int).Direction = ParameterDirection.Output
							Dim dataTable3 As DataTable = New DataTable()
							sqlDataAdapter3.Fill(dataTable3)
							Dim num4 As Double = Convert.ToDouble(Operators.ConcatenateObject("", sqlDataAdapter3.SelectCommand.Parameters("@balance").Value))
							Dim num5 As Integer = 0
							Dim num6 As Integer = Me.dgvItems.Rows.Count - 1
							Dim num7 As Integer = num5
							While True
								Dim num8 As Integer = num7
								Dim num9 As Integer = num6
								If num8 > num9 Then
									Exit While
								End If
								flag3 = Operators.ConditionalCompareObjectEqual(Me.dgvItems.Rows(num7).Cells(9).Value, Me.cmbCurrency.SelectedValue, False)
								If flag3 Then
									num4 -= Convert.ToDouble(Operators.ConcatenateObject("", Me.dgvItems.Rows(num7).Cells(5).Value))
								End If
								num7 += 1
							End While
							Dim num10 As Double = MainClass.chkItemExpire(Conversions.ToInteger(Me.cmbCurrency.SelectedValue), num4, Conversions.ToInteger(Me.cmbSafe.SelectedValue), Me.txtDate.Value)
							flag3 = (num10 > 0.0)
							If flag3 Then
								Dim dialogResult As DialogResult = MessageBox.Show("يوجد أصناف منتهية الصلاحية بالمخزن، هل تريد الإستمرار؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
								flag3 = (dialogResult = DialogResult.No)
								If flag3 Then
									Return
								End If
							End If
						End If
						Try
							Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select type from currencies where id=", Me.cmbCurrency.SelectedValue)), Me.conn1)
							Dim dataTable4 As DataTable = New DataTable()
							sqlDataAdapter4.Fill(dataTable4)
							flag3 = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))) = 4)
							If flag3 Then
								flag4 = True
							End If
						Catch ex3 As Exception
						End Try
						flag3 = (Not flag4 And Me.InvProc = 2 And Me.cmbProcType.SelectedIndex = 0)
						If flag3 Then
							Dim num11 As Double = Me.CalcCurrencyStock(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
							Dim num12 As Integer = 0
							Dim num13 As Integer = Me.dgvItems.Rows.Count - 1
							Dim num14 As Integer = num12
							While True
								Dim num15 As Integer = num14
								Dim num9 As Integer = num13
								If num15 > num9 Then
									Exit While
								End If
								flag3 = Operators.ConditionalCompareObjectEqual(Me.dgvItems.Rows(num14).Cells(9).Value, Me.cmbCurrency.SelectedValue, False)
								If flag3 Then
									num11 -= Convert.ToDouble(Operators.ConcatenateObject("", Me.dgvItems.Rows(num14).Cells(5).Value))
								End If
								num14 += 1
							End While
							flag3 = (Me.ProcCode <> -1)
							If flag3 Then
								Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select val from Inv_Sub where currency_from=", Me.cmbCurrency.SelectedValue), " and proc_id="), Me.ProcCode)), Me.conn1)
								Dim dataTable5 As DataTable = New DataTable()
								sqlDataAdapter5.Fill(dataTable5)
								flag3 = (dataTable5.Rows.Count > 0)
								If flag3 Then
									num11 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))
									flag3 = (num2 > num11)
									If flag3 Then
										Dim text5 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
										text5 = text5 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
										text5 = String.Concat(New String() {text5, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0))))})
										flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
										If flag3 Then
											text5 = "quantity is greater than store balance"
											text5 = text5 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
											text5 = String.Concat(New String() {text5, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0))))})
										End If
										MessageBox.Show(text5, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Me.txtVal1.Focus()
										Return
									End If
								Else
									flag3 = (num2 > num11)
									If flag3 Then
										Dim text6 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
										text6 = text6 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
										text6 = String.Concat(New String() {text6, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11)})
										flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
										If flag3 Then
											text6 = "quantity is greater than store balance"
											text6 = text6 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
											text6 = String.Concat(New String() {text6, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11)})
										End If
										MessageBox.Show(text6, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Me.txtVal1.Focus()
										Return
									End If
								End If
							Else
								flag3 = (num2 > num11)
								If flag3 Then
									Dim text7 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
									text7 = text7 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
									text7 = String.Concat(New String() {text7, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11)})
									flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
									If flag3 Then
										text7 = "quantity is greater than store balance"
										text7 = text7 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
										text7 = String.Concat(New String() {text7, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num11)})
									End If
									MessageBox.Show(text7, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.txtVal1.Focus()
									Return
								End If
							End If
						End If
						flag3 = (Me.InvProc = 1 And Me.cmbProcType.SelectedIndex = 0)
						If flag3 Then
							Try
								Me.CalcBalance()
								Dim num16 As Double = Convert.ToDouble(Me.txtCapital.Text)
								flag3 = (Me.ProcCode <> -1)
								If flag3 Then
									Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select val*exchange_price from Inv_Sub where currency_from=", Me.cmbCurrency.SelectedValue), " and proc_id="), Me.ProcCode)), Me.conn1)
									Dim dataTable6 As DataTable = New DataTable()
									sqlDataAdapter6.Fill(dataTable6)
									flag3 = (dataTable6.Rows.Count > 0)
									If flag3 Then
										num16 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0)))
										flag3 = (Convert.ToDouble(Me.txtVal2.Text) > num16)
										If flag3 Then
											Dim text8 As String = "اجمالي الشراء أكبر من رصيد الخزنة"
											text8 = text8 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
											text8 = text8 + Environment.NewLine + "تعديل باضافة مبلغ: " + Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text) - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))
											text8 = String.Concat(New String() {text8, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))})
											flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
											If flag3 Then
												text8 = "total purchases is greater than safe balance"
												text8 = text8 + Environment.NewLine + "value : " + Me.txtVal2.Text
												text8 = text8 + Environment.NewLine + "the edited value: " + Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text) - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))
												text8 = String.Concat(New String() {text8, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable6.Rows(0)(0))))})
											End If
											MessageBox.Show(text8, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
											Me.txtVal1.Focus()
											Return
										End If
									Else
										flag3 = (Convert.ToDouble(Me.txtVal2.Text) > num16)
										If flag3 Then
											Dim text9 As String = "اجمالي الشراء أكبر من رصيد الخزنة"
											text9 = text9 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
											text9 = String.Concat(New String() {text9, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16)})
											flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
											If flag3 Then
												text9 = "total purchases is greater than safe balance"
												text9 = text9 + Environment.NewLine + "value : " + Me.txtVal2.Text
												text9 = String.Concat(New String() {text9, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16)})
											End If
											MessageBox.Show(text9, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
											Me.txtVal1.Focus()
											Return
										End If
									End If
								Else
									flag3 = (Convert.ToDouble(Me.txtVal2.Text) > num16)
									If flag3 Then
										Dim text10 As String = "اجمالي الشراء للعملةأكبر من رصيد الخزنة"
										text10 = text10 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
										text10 = String.Concat(New String() {text10, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16)})
										flag3 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
										If flag3 Then
											text10 = "total purchases is greater than safe balance"
											text10 = text10 + Environment.NewLine + "value : " + Me.txtVal2.Text
											text10 = String.Concat(New String() {text10, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num16)})
										End If
										MessageBox.Show(text10, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
										Me.txtVal1.Focus()
										Return
									End If
								End If
							Catch ex4 As Exception
							End Try
						End If
						flag3 = (Me.InvProc = 2)
						If flag3 Then
						End If
						flag3 = (Me.cmbProcType.SelectedIndex = 0)
						If flag3 Then
							Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select val from Rekaba where curr_id=", Me.cmbCurrency.SelectedValue), " and chk=1")), Me.conn)
							Dim dataTable7 As DataTable = New DataTable()
							sqlDataAdapter7.Fill(dataTable7)
							flag3 = (dataTable7.Rows.Count > 0)
							If flag3 Then
								Dim flag2 As Boolean = Convert.ToDouble(Me.txtVal2.Text) >= Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("val")))
								If flag2 Then
									Dim text11 As String = String.Concat(New String() {"مبلغ ", Me.txtVal2.Text, " تعدى حد الرقابة ", Environment.NewLine, Me.cmbCurrency.Text, Environment.NewLine, " ويساوي ", Conversions.ToString(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable7.Rows(0)("val"))))})
									Dim sqlDataAdapter8 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select national_id from Customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
									Dim dataTable8 As DataTable = New DataTable()
									sqlDataAdapter8.Fill(dataTable8)
									flag3 = (Operators.CompareString(dataTable8.Rows(0)("national_id").ToString(), "", False) = 0)
									If flag3 Then
										text11 = String.Concat(New String() {text11, Environment.NewLine, "العميل: ", Me.cmbClient.Text, " غير مسجل له رقم قومي"})
									End If
									text11 = text11 + Environment.NewLine + "هل تريد الاستمرار?"
									Dim dialogResult2 As DialogResult = MessageBox.Show(text11, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
									flag3 = (dialogResult2 = DialogResult.No)
									If flag3 Then
										Return
									End If
								End If
							End If
						End If
						Dim flag5 As Boolean = False
						Dim num17 As Integer = -1
						flag3 = Me._IsUpdateDG
						If flag3 Then
							num17 = Me.dgvItems.SelectedRows(0).Index
						Else
							Dim num18 As Integer = 0
							Dim num19 As Integer = Me.dgvItems.Rows.Count - 1
							Dim num20 As Integer = num18
							While True
								Dim num21 As Integer = num20
								Dim num9 As Integer = num19
								If num21 > num9 Then
									GoTo IL_1611
								End If
								Dim left2 As String = "شراء"
								flag3 = (Me.InvProc = 2)
								If flag3 Then
									left2 = "بيع"
								End If
								flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(Me.dgvItems.Rows(num20).Cells(9).Value, Me.cmbCurrency.SelectedValue, False), Operators.CompareObjectEqual(Me.dgvItems.Rows(num20).Cells(3).Value, Me.cmbUnits.Text, False)), Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num20).Cells(7).Value)) = Conversion.Val(Me.txtExchangeVal.Text)), Operators.CompareString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num20).Cells(18).Value).ToString().Trim(), Me.txtItemNote.Text.Trim(), False) = 0), Operators.CompareObjectEqual(left2, Me.dgvItems.Rows(num20).Cells(1).Value, False)))
								If flag3 Then
									Exit While
								End If
								num20 += 1
							End While
							flag5 = True
							num17 = num20
IL_1611:
							flag3 = Not flag5
							If flag3 Then
								Me.dgvItems.Rows.Add()
								num17 = Me.dgvItems.Rows.Count - 1
							End If
						End If
						Try
							Me.sp.Open()
							Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
							Me.sp.WriteLine(String.Concat(New String() {Me.GetCurrencyName(Conversions.ToInteger(Me.cmbCurrency.SelectedValue)), " Q:", Me.txtVal1.Text, " P:", Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text))}))
							Me.sp.Close()
						Catch ex5 As Exception
						End Try
						Me._DoChangeValPrice = False
						Try
							flag3 = (Not Me._IsUpdateDG AndAlso flag5)
							If flag3 Then
								Me.dgvItems.Rows(num17).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(4).Value)) + Convert.ToDouble(Me.txtVal1.Text))
								Me.dgvItems.Rows(num17).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(5).Value)) + num2)
								Me.dgvItems.Rows(num17).Cells(8).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(8).Value)) + Convert.ToDouble(Me.txtVal2.Text))
								Me.dgvItems.Rows(num17).Cells(12).Value = Conversion.Val(Me.txtCurrDisc.Text) + Conversion.Val(Me.txtDiscPerc.Text)
								Me.dgvItems.Rows(num17).Cells(11).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(12).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(8).Value)), 3)
								Dim num22 As Double = Convert.ToDouble(Me.txtVal2.Text) - Conversion.Val(Me.txtCurrDiscVal.Text)
								Me.dgvItems.Rows(num17).Cells(13).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(8).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(11).Value))
								Me.dgvItems.Rows(num17).Cells(14).Value = Conversion.Val(Me.txtCurrTax.Text)
								Me.dgvItems.Rows(num17).Cells(15).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(14).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(13).Value)), 3)
								Me.dgvItems.Rows(num17).Cells(16).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(13).Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(15).Value)), 2)
								Me.dgvItems.Rows(num17).Cells(18).Value = Me.txtItemNote.Text
							Else
								Me.dgvItems.Rows(num17).Cells(0).Value = Me.txtNo.Text
								Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(num17).Cells(1), DataGridViewComboBoxCell)
								flag3 = (Me.InvProc = 1)
								If flag3 Then
									dataGridViewComboBoxCell.Value = "شراء"
								Else
									dataGridViewComboBoxCell.Value = "بيع"
								End If
								Me.dgvItems.Rows(num17).Cells("colbarcode").Value = Me.txtBarcode.Text
								Me.dgvItems.Rows(num17).Cells(2).Value = Me.GetCurrencyName(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
								Me.dgvItems.Rows(num17).Cells(3).Value = Me.cmbUnits.Text
								Me.dgvItems.Rows(num17).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(Me.txtVal1.Text))
								Me.dgvItems.Rows(num17).Cells(5).Value = String.Format("{0:0.#,##.##}", num2)
								Me.dgvItems.Rows(num17).Cells(6).Value = String.Format("{0:0.#,##.##}", num3)
								Me.dgvItems.Rows(num17).Cells(7).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(Me.txtExchangeVal.Text))
								Me.dgvItems.Rows(num17).Cells(8).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(Me.txtVal2.Text))
								Me.dgvItems.Rows(num17).Cells(9).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
								Me.dgvItems.Rows(num17).Cells(10).Value = Me.txtExpireDate.Value.ToShortDateString()
								Me.dgvItems.Rows(num17).Cells(12).Value = Conversion.Val(Me.txtCurrDisc.Text) + Conversion.Val(Me.txtDiscPerc.Text)
								Me.dgvItems.Rows(num17).Cells(11).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(12).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(8).Value)), 3)
								Dim num23 As Double = Convert.ToDouble(Me.txtVal2.Text) - Conversion.Val(Me.txtCurrDiscVal.Text)
								Me.dgvItems.Rows(num17).Cells(13).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(8).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(11).Value))
								Me.dgvItems.Rows(num17).Cells(14).Value = Conversion.Val(Me.txtCurrTax.Text)
								Me.dgvItems.Rows(num17).Cells(15).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(14).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(13).Value)), 3)
								Me.dgvItems.Rows(num17).Cells(16).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(13).Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num17).Cells(15).Value)), 2)
								Me.dgvItems.Rows(num17).Cells(18).Value = Me.txtItemNote.Text
								flag3 = Not Me._IsUpdateDG
								If flag3 Then
									Me.dgvItems.Rows(num17).Cells("colOperateNo").Value = Me.GetOperateNo(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
								End If
							End If
						Catch ex6 As Exception
						Finally
							Me._DoChangeValPrice = True
						End Try
						Try
							Me.dgvItems.Rows(num17).Selected = True
							Me.dgvItems.FirstDisplayedScrollingRowIndex = num17
						Catch ex7 As Exception
						End Try
						flag3 = (Me.InvProc = 2)
						If flag3 Then
							Dim num24 As Integer = 1
							Try
								Dim sqlDataAdapter9 As SqlDataAdapter = New SqlDataAdapter("select offer_type from Foundation", Me.conn)
								Dim dataTable9 As DataTable = New DataTable()
								sqlDataAdapter9.Fill(dataTable9)
								flag3 = Operators.ConditionalCompareObjectEqual(dataTable9.Rows(0)(0), 2, False)
								If flag3 Then
									num24 = 2
								End If
							Catch ex8 As Exception
							End Try
							flag3 = (num24 = 1)
							If flag3 Then
								Me.ChkOffer()
							Else
								Me.ChkOffer2()
							End If
						End If
						Me.CalcTot()
						Me.cmbGroups.SelectedIndex = -1
						Me.cmbCurrency.SelectedIndex = -1
						Me.cmbUnits.SelectedIndex = -1
						Me.txtBarcode.Text = ""
						Me.txtVal1.Text = "1"
						Me.txtExchangeVal.Text = ""
						Me.txtExchangeValD.Text = ""
						Me.txtVal2D.Text = ""
						Me.txtCurrDisc.Text = ""
						Me.txtCurrDiscVal.Text = ""
						Me.txtCurrTax.Text = ""
						Me.lblCurrTaxVal.Text = ""
						Me.txtItemNote.Text = ""
						Me._IsUpdateDG = False
						Me.lblCostPrice.Text = ""
						Me.txtBarcode.Focus()
					End If
				End If
			End If
		End If
	End Sub

	Private Sub ChkOffer()
		' The following expression was wrapped in a checked-statement
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from offers where is_deleted=0", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			Dim num6 As Integer
			Dim listBox As ListBox
			Dim listBox3 As ListBox
			Dim listBox4 As ListBox
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					GoTo IL_7B5
				End If
				Dim flag As Boolean = False
				num6 = 10000000
				listBox = New ListBox()
				Dim listBox2 As ListBox = New ListBox()
				listBox3 = New ListBox()
				listBox4 = New ListBox()
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from offers_sub where offer_id=", dataTable.Rows(num3)("id"))), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Dim num7 As Integer = 0
				Dim num8 As Integer = dataTable2.Rows.Count - 1
				Dim num9 As Integer = num7
				Dim flag3 As Boolean
				While True
					Dim num10 As Integer = num9
					num5 = num8
					If num10 > num5 Then
						Exit While
					End If
					listBox2.Items.Add(0)
					Dim num11 As Integer = 0
					Dim num12 As Integer = Me.dgvItems.Rows.Count - 1
					Dim num13 As Integer = num11
					While True
						Dim num14 As Integer = num13
						num5 = num12
						If num14 > num5 Then
							Exit While
						End If
						Dim flag2 As Boolean = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataTable2.Rows(num9)("item"), Me.dgvItems.Rows(num13).Cells(9).Value, False), Operators.CompareObjectEqual(dataTable2.Rows(num9)("unit"), Me.GetUnitID(Conversions.ToString(Me.dgvItems.Rows(num13).Cells(3).Value)), False)))
						If flag2 Then
							flag3 = (Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num13).Cells(4).Value)) >= Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("quan"))))
							If flag3 Then
								flag = True
								listBox2.Items(num9) = 1
								listBox3.Items.Add(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("item"))))
								listBox4.Items.Add(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("unit"))))
								listBox.Items.Add(Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("disc"))))
								flag3 = (Math.Floor(Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num13).Cells(4).Value)) / Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("quan")))) < CDbl(num6))
								If flag3 Then
									num6 = CInt(Math.Round(Math.Floor(Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num13).Cells(4).Value)) / Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(num9)("quan"))))))
								End If
							End If
						End If
						num13 += 1
					End While
					num9 += 1
				End While
				flag3 = flag
				If flag3 Then
					Dim flag4 As Boolean = True
					Dim num15 As Integer = 0
					Dim num16 As Integer = listBox2.Items.Count - 1
					Dim num17 As Integer = num15
					While True
						Dim num18 As Integer = num17
						num5 = num16
						If num18 > num5 Then
							Exit While
						End If
						flag3 = Operators.ConditionalCompareObjectEqual(listBox2.Items(num17), 0, False)
						If flag3 Then
							GoTo Block_8
						End If
						num17 += 1
					End While
IL_405:
					flag3 = flag4
					If flag3 Then
						Exit While
					End If
					GoTo IL_7A0
Block_8:
					flag4 = False
					GoTo IL_405
				End If
IL_7A0:
				num3 += 1
			End While
			Dim num19 As Integer = 0
			Dim num20 As Integer = listBox3.Items.Count - 1
			Dim num21 As Integer = num19
			While True
				Dim num22 As Integer = num21
				Dim num5 As Integer = num20
				If num22 > num5 Then
					Exit While
				End If
				Dim num23 As Integer = 0
				Dim num24 As Integer = Me.dgvItems.Rows.Count - 1
				Dim num25 As Integer = num23
				While True
					Dim num26 As Integer = num25
					num5 = num24
					If num26 > num5 Then
						Exit While
					End If
					Dim flag2 As Boolean = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(listBox3.Items(num21), Me.dgvItems.Rows(num25).Cells(9).Value, False), Operators.CompareObjectEqual(listBox4.Items(num21), Me.GetUnitID(Conversions.ToString(Me.dgvItems.Rows(num25).Cells(3).Value)), False)))

					If flag2 Then
						Me.dgvItems.Rows(num25).Cells(11).Value = Conversion.Val(Operators.ConcatenateObject("", listBox.Items(num21))) * CDbl(num6)
						Me.dgvItems.Rows(num25).Cells(12).Value = Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(11).Value)) / Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(8).Value)) * 100.0, 2)
						Me.dgvItems.Rows(num25).Cells(13).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(8).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(11).Value))
						Me.dgvItems.Rows(num25).Cells(15).Value = Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(14).Value)) / 100.0 * Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(13).Value)), 2)
						Me.dgvItems.Rows(num25).Cells(16).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(13).Value)) + Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num25).Cells(15).Value))
					End If

					num25 += 1
				End While
				num21 += 1
			End While
IL_7B5:
		Catch ex As Exception
		End Try
	End Sub

	'///////////////////////////////
	Private Sub ChkOffer2()
		Try
			Dim totalQuantity As Double = 0
			Dim excludedCurrencies As New ListBox()

			' حساب الكمية الإجمالية للعملات المؤهلة للعروض
			For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
				Try
					Dim currencyId As Object = Me.dgvItems.Rows(i).Cells(9).Value
					Dim isOutOffer As Boolean = GetCurrencyOutOfferStatus(currencyId)

					If Not isOutOffer Then
						totalQuantity += Conversion.Val(Me.dgvItems.Rows(i).Cells(5).Value)
						excludedCurrencies.Items.Add(currencyId)
					End If
				Catch ex As Exception
					' في حالة الخطأ، نعتبر العملة مؤهلة
					totalQuantity += Conversion.Val(Me.dgvItems.Rows(i).Cells(5).Value)
					excludedCurrencies.Items.Add(Me.dgvItems.Rows(i).Cells(9).Value)
				End Try
			Next

			' إنشاء جدول بيانات للعناصر المرتبة
			Dim itemsTable As DataTable = CreateSortedItemsTable()

			' البحث عن العروض المناسبة
			Dim offersTable As DataTable = GetApplicableOffers(totalQuantity)

			If offersTable.Rows.Count > 0 Then
				ApplyOffersToItems(itemsTable, offersTable)
				UpdateDataGridViewWithDiscounts(itemsTable)
			End If

		Catch ex As Exception
			' تسجيل الخطأ مع تجاهله للاستمرار في العمل
			Debug.WriteLine($"Error in ChkOffer2: {ex.Message}")
		End Try
	End Sub

	' ========== الدوال المساعدة ==========

	''' <summary>
	''' الحصول على حالة استبعاد العملة من العروض
	''' </summary>
	Private Function GetCurrencyOutOfferStatus(currencyId As Object) As Boolean
		Try
			Dim query As String = $"SELECT outoffer FROM currencies WHERE id = {currencyId}"
			Using adapter As New SqlDataAdapter(query, Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					Return Convert.ToBoolean(dt.Rows(0)(0))
				End If
			End Using

			Return False
		Catch ex As Exception
			Return False
		End Try
	End Function

	''' <summary>
	''' إنشاء جدول العناصر المرتبة تنازلياً حسب الكمية
	''' </summary>
	Private Function CreateSortedItemsTable() As DataTable
		Dim itemsTable As New DataTable()

		' إضافة الأعمدة
		itemsTable.Columns.Add("index", GetType(Integer))
		itemsTable.Columns.Add("id", GetType(Integer))
		itemsTable.Columns.Add("quan", GetType(Double))
		itemsTable.Columns.Add("price", GetType(Double))
		itemsTable.Columns.Add("perc", GetType(Double))
		itemsTable.Columns.Add("disc", GetType(Double))
		itemsTable.Columns.Add("end", GetType(Integer))

		' إضافة البيانات من DataGridView
		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			Dim row As DataRow = itemsTable.NewRow()
			row("index") = i
			row("id") = Me.dgvItems.Rows(i).Cells(9).Value
			row("quan") = Conversion.Val(Me.dgvItems.Rows(i).Cells(5).Value)
			row("price") = Conversion.Val(Me.dgvItems.Rows(i).Cells(7).Value)
			row("perc") = Conversion.Val(Me.dgvItems.Rows(i).Cells(6).Value)
			row("disc") = 0.0
			row("end") = 0
			itemsTable.Rows.Add(row)
		Next

		' ترتيب تنازلي حسب الكمية
		Dim dataView As DataView = itemsTable.AsDataView()
		dataView.Sort = "quan DESC"

		Return dataView.ToTable()
	End Function

	''' <summary>
	''' الحصول على العروض المناسبة للكمية الإجمالية
	''' </summary>
	Private Function GetApplicableOffers(totalQuantity As Double) As DataTable
		Dim query As String = $"SELECT * FROM offers2 WHERE quan <= {totalQuantity} ORDER BY quan DESC"

		Using adapter As New SqlDataAdapter(query, Me.conn)
			Dim offersTable As New DataTable()
			adapter.Fill(offersTable)
			Return offersTable
		End Using
	End Function

	''' <summary>
	''' تطبيق العروض على العناصر
	''' </summary>
	Private Sub ApplyOffersToItems(itemsTable As DataTable, offersTable As DataTable)
		For offerIndex As Integer = 0 To offersTable.Rows.Count - 1
			Dim offerQuantity As Double = Conversion.Val(offersTable.Rows(offerIndex)("quan"))
			Dim offerPrice As Double = Conversion.Val(offersTable.Rows(offerIndex)("price"))

			For itemIndex As Integer = 0 To itemsTable.Rows.Count - 1
				If Convert.ToInt32(itemsTable.Rows(itemIndex)("end")) = 0 Then
					' التحقق مما إذا كانت العملة مؤهلة للعرض
					Dim currencyId As Object = itemsTable.Rows(itemIndex)("id")
					If IsCurrencyEligibleForOffer(currencyId) Then

						If offerQuantity > 0 Then
							Dim itemQuantity As Double = Conversion.Val(itemsTable.Rows(itemIndex)("quan"))

							' تطبيق الخصم على العنصر
							ApplyDiscountToItem(itemsTable, itemIndex, offerQuantity, offerPrice)

							' تحديث الكمية المتبقية من العرض
							offerQuantity -= itemQuantity
						End If
					End If
				End If
			Next
		Next
	End Sub

	''' <summary>
	''' التحقق من أهلية العملة للعرض
	''' </summary>
	Private Function IsCurrencyEligibleForOffer(currencyId As Object) As Boolean
		Try
			Dim query As String = $"SELECT outoffer FROM currencies WHERE id = {currencyId}"
			Using adapter As New SqlDataAdapter(query, Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					Return Not Convert.ToBoolean(dt.Rows(0)(0))
				End If
			End Using

			Return True ' الافتراضي أن العملة مؤهلة
		Catch ex As Exception
			Return True
		End Try
	End Function

	''' <summary>
	''' تطبيق الخصم على عنصر محدد
	''' </summary>
	Private Sub ApplyDiscountToItem(itemsTable As DataTable, itemIndex As Integer,
							   offerQuantity As Double, offerPrice As Double)

		Dim itemQuantity As Double = Conversion.Val(itemsTable.Rows(itemIndex)("quan"))
		Dim itemPrice As Double = Conversion.Val(itemsTable.Rows(itemIndex)("price"))
		Dim itemPerc As Double = Conversion.Val(itemsTable.Rows(itemIndex)("perc"))

		' تعديل السعر بالنسبة المئوية
		If itemPerc > 0 Then
			itemPrice /= itemPerc
		End If

		' حساب الخصم
		Dim priceDifference As Double = itemPrice - offerPrice
		Dim totalDiscount As Double = priceDifference * itemQuantity

		' تحديث الجدول
		itemsTable.Rows(itemIndex)("disc") = totalDiscount
		itemsTable.Rows(itemIndex)("end") = 1

		' إذا كانت كمية العرض أقل من كمية العنصر، نبحث عن عرض أصغر
		If offerQuantity - itemQuantity < 0 Then
			Dim remainingQuantity As Double = itemQuantity - offerQuantity

			If remainingQuantity > 0 Then
				' البحث عن عرض مناسب للكمية المتبقية
				Dim newQuery As String = $"SELECT * FROM offers2 WHERE quan <= {remainingQuantity} ORDER BY quan DESC"
				Using adapter As New SqlDataAdapter(newQuery, Me.conn)
					Dim newOffersTable As New DataTable()
					adapter.Fill(newOffersTable)

					' إعادة المعالجة من البداية
					ApplyOffersToItems(itemsTable, newOffersTable)
				End Using
			End If
		End If
	End Sub

	''' <summary>
	''' تحديث DataGridView بالخصومات المحسوبة
	''' </summary>
	Private Sub UpdateDataGridViewWithDiscounts(itemsTable As DataTable)
		For Each row As DataRow In itemsTable.Rows
			Dim discountAmount As Double = Conversion.Val(row("disc"))

			If discountAmount <> 0 Then
				Dim originalIndex As Integer = Convert.ToInt32(row("index"))

				' تحديث الخلايا في DataGridView
				UpdateDataGridViewRow(originalIndex, discountAmount)
			End If
		Next
	End Sub

	''' <summary>
	''' تحديث صف معين في DataGridView
	''' </summary>
	Private Sub UpdateDataGridViewRow(rowIndex As Integer, discountAmount As Double)
		Dim rowTotal As Double = Conversion.Val(Me.dgvItems.Rows(rowIndex).Cells(8).Value)
		Dim taxPercentage As Double = Conversion.Val(Me.dgvItems.Rows(rowIndex).Cells(14).Value)

		' الخصم المباشر
		Me.dgvItems.Rows(rowIndex).Cells(11).Value = discountAmount

		' نسبة الخصم
		Dim discountPercentage As Double = 0
		If rowTotal > 0 Then
			discountPercentage = Math.Round(discountAmount / rowTotal * 100.0, 2)
		End If
		Me.dgvItems.Rows(rowIndex).Cells(12).Value = discountPercentage

		' الإجمالي بعد الخصم
		Dim totalAfterDiscount As Double = rowTotal - discountAmount
		Me.dgvItems.Rows(rowIndex).Cells(13).Value = totalAfterDiscount

		' قيمة الضريبة
		Dim taxAmount As Double = Math.Round(taxPercentage / 100.0 * totalAfterDiscount, 2)
		Me.dgvItems.Rows(rowIndex).Cells(15).Value = taxAmount

		' الصافي النهائي
		Dim netTotal As Double = totalAfterDiscount + taxAmount
		Me.dgvItems.Rows(rowIndex).Cells(16).Value = netTotal
	End Sub

	'///////////////////////////////
	Private Sub txtVal2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtVal2.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
		End If
		flag = (e.KeyCode = Keys.Up)
		If flag Then
			SendKeys.Send("+{TAB}")
		End If
	End Sub

	Private Sub LoadInvNo()
		' The following expression was wrapped in a checked-statement
		Try
			Me.txtNo.Text = ""
			Dim value As Integer = 1
			Dim value2 As Integer = 1
			Dim flag As Boolean = Me.InvProc = 2
			If flag Then
				value2 = 0
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select max(id) from Inv where is_buy=", Conversions.ToString(value2), " and branch=", Conversions.ToString(MainClass.BranchNo), " and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1)}), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) <> 0.0)
			Dim flag2 As Boolean
			If flag Then
				Try
					' The following expression was wrapped in a unchecked-expression
					value = CInt(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) + 1.0))
				Catch ex As Exception
				End Try
			Else
				flag = (Me.cmbProcType.SelectedIndex = 0 Or Me.cmbProcType.SelectedIndex = 1)
				If flag Then
					Try
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select start_purch,start_sales from foundation where id=1", Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag = (dataTable2.Rows.Count > 0)
						If flag Then
							flag2 = (Me.InvProc = 1)
							If flag2 Then
								value = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("start_purch")))
							Else
								value = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("start_sales")))
							End If
						End If
					Catch ex2 As Exception
					End Try
				End If
			End If
			Me.txtNo.Text = "" + Conversions.ToString(value)
			Me.txtBarcode.Focus()
			flag2 = (Me.cmbProcType.SelectedIndex = 1)
			If flag2 Then
				Me.lblSrcInvNo.Visible = True
				Me.txtSrcInvNo.Visible = True
			Else
				Me.lblSrcInvNo.Visible = False
				Me.txtSrcInvNo.Visible = False
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub SetLocationOfSum()
		Dim flag As Boolean = Me.InvProc = 1
		If flag Then
			Dim lblTotPurch As Control = Me.lblTotPurch
			Dim location As Point = New Point(993, 440)
			lblTotPurch.Location = location
			Dim txtTotPurch As Control = Me.txtTotPurch
			location = New Point(805, 428)
			txtTotPurch.Location = location
		Else
			Dim lblTotSale As Control = Me.lblTotSale
			Dim location As Point = New Point(993, 440)
			lblTotSale.Location = location
			Dim txtTotSale As Control = Me.txtTotSale
			location = New Point(805, 428)
			txtTotSale.Location = location
		End If
	End Sub

	Public Sub LoadGroups()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from groups order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbGroups.DataSource = dataTable
		Me.cmbGroups.DisplayMember = "name"
		Me.cmbGroups.ValueMember = "id"
		Me.cmbGroups.SelectedIndex = -1
	End Sub

	Private Sub LoadUnits()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from units order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbUnits.DataSource = dataTable
			Me.cmbUnits.DisplayMember = "name"
			Me.cmbUnits.ValueMember = "id"
			Me.cmbUnits.SelectedIndex = -1
		Catch ex As Exception
		End Try
	End Sub

	Private Sub LoadUnits(curr As Integer)
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select units.id,units.name from units where id in ( select currencies.unit from currencies where currencies.id= ", Conversions.ToString(curr), ") or id in (select curr_units.unit from curr_units where curr_units.curr=", Conversions.ToString(curr), ")  order by units.id"}), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.cmbUnits.DataSource = dataTable
				Me.cmbUnits.DisplayMember = "name"
				Me.cmbUnits.ValueMember = "id"
				Me.cmbUnits.SelectedIndex = -1
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GetTaxVal()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select tax,tax_no from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax")))
				Me.taxno = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax_no")))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GetDefaultInvType()
		Try
			Me.cmbType.SelectedIndex = 1
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select inv_type from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("inv_type"))) = 2
				If flag2 Then
					Me.cmbType.SelectedIndex = 0
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub LoadCenters()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from costcenter order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCenter.DataSource = dataTable
			Me.cmbCenter.DisplayMember = "name"
			Me.cmbCenter.ValueMember = "id"
			Me.cmbCenter.SelectedIndex = -1
		Catch ex As Exception
		End Try
	End Sub

	Private Sub LoadAccounts()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select Code,AName from Accounts_Index where Type=2 order by code ", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbAcc.DataSource = dataTable
			Me.cmbAcc.DisplayMember = "AName"
			Me.cmbAcc.ValueMember = "Code"
			Me.cmbAcc.SelectedIndex = -1
			Dim num As Integer = 3410001
			Dim isAccTreeNew As Boolean = MainClass.IsAccTreeNew
			If isAccTreeNew Then
				num = 31010001
			End If
			Me.cmbAcc.SelectedValue = num
		Catch ex As Exception
		End Try
	End Sub

	Public Sub LoadData()
		Dim frmChargeData As New frmChargeData()
		Try
			Me._loaded = False
			Try
				Me.btnFirst.Visible = True
				Me.btnLast.Visible = True
				Me.btnNext.Visible = True
				Me.btnPrevious.Visible = True
			Catch ex As Exception
			End Try
			Me.dgvItems.Columns("colbarcode").DisplayIndex = 0
			Dim flag As Boolean
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select IS_New,IS_Save,IS_Delete,IS_Search,IS_Print from User_Permissions,Forms where User_Permissions.Form_id=Forms.id and Forms.id=20001 and user_id=" + Conversions.ToString(MainClass.UserID), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count = 0)
				If flag Then
					Me.btnCustAdd.Enabled = False
				End If
			Catch ex2 As Exception
			End Try
			flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
			If flag Then
				Me.cmbProcType.Items(0) = "Sales and Purchases inv."
				Me.cmbProcType.Items(1) = "Retrieve inv."
				Me.cmbProcType.Items(2) = "First-time stock"
				Me.cmbProcType.Items(3) = "Price offer inv."
				Me.cmbProcTypeSrch.Items(0) = "Sales and Purchases inv."
				Me.cmbProcTypeSrch.Items(1) = "Retrieve inv."
				Me.cmbProcTypeSrch.Items(2) = "First-time stock"
				Me.cmbProcTypeSrch.Items(3) = "Price offer inv."
				Me.cmbType.Items(0) = "postpone"
				Me.cmbType.Items(1) = "cash"
			End If
			flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag Then
				Me._fieldname = "symbol"
				Me._gfieldname = "name"
			Else
				Me._fieldname = "nameEN"
				Me._gfieldname = "nameEN"
			End If
			Me.txtPaid.Text = "0"
			Me.txtTotPurch.Text = "0"
			Me.txtTotSale.Text = "0"
			Me.txtDiff.Text = "0"
			Me.txtBarcode.RightToLeft = RightToLeft.No
			Me.GetTaxVal()
			Dim flag2 As Boolean
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select edit_inv,edit_disc,edit_price,edit_date,send_inv_email,hide_tel from Users where id=" + Conversions.ToString(MainClass.UserID), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Try
						flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("edit_inv")))
						If flag2 Then
							Me._IsEditInvPerm = False
						End If
					Catch ex3 As Exception
					End Try
					Try
						flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("edit_disc")))
						If flag2 Then
							Me.txtCurrDisc.[ReadOnly] = True
							Me.txtCurrDiscVal.[ReadOnly] = True
							Me.txtDiscPerc.[ReadOnly] = True
							Me.txtMinusVal.[ReadOnly] = True
						End If
					Catch ex4 As Exception
					End Try
					Try
						flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("edit_price")))
						If flag2 Then
							Me.txtExchangeVal.[ReadOnly] = True
							Me.txtExchangeValD.[ReadOnly] = True
							Me.txtVal2.[ReadOnly] = True
							Me.txtVal2D.[ReadOnly] = True
						End If
					Catch ex5 As Exception
					End Try
					Try
						flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("edit_date")))
						If flag2 Then
							Me.txtDate.Enabled = False
						End If
					Catch ex6 As Exception
					End Try
					Try
						Me._SendEmail = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("send_inv_email")))
					Catch ex7 As Exception
					End Try
					Try
						Me._hidetel = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("hide_tel")))
					Catch ex8 As Exception
					End Try
				End If
			Catch ex9 As Exception
			End Try
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select port,nameA,Exchangeval from Foundation", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag2 = (dataTable3.Rows.Count > 0)
				If flag2 Then
					Try
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)), "", False)
						If flag Then
							Me.sp = New SerialPort(dataTable3.Rows(0)(0).ToString(), 9600, Parity.None, 8, StopBits.One)
						End If
					Catch ex10 As Exception
					End Try
					Try
						flag2 = (Operators.CompareString(dataTable3.Rows(0)("Exchangeval").ToString(), "", False) <> 0)
						If flag2 Then
							Me._Exchangeal = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("Exchangeval")))
						End If
					Catch ex11 As Exception
					End Try
					Me._foundname = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("nameA")))
				End If
			Catch ex12 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Me.lblTotSale.Visible = False
				Me.txtTotSale.Visible = False
				Me.lblTotPurch.Location = Me.lblTotSale.Location
				Me.txtTotPurch.Location = Me.txtTotSale.Location
				Me.chkInTax.Visible = False
				Me.chkMaintainance.Visible = False
				Me.lblMaintainanceInvId.Visible = False
				Me.txtMaintInvId.Visible = False
				Me.lblProjectname.Visible = False
				Me.txtProjectName.Visible = False
				Me.txtInvoicePeriod.Visible = False
				flag2 = (Me.cmbProcType.SelectedIndex = 2)
				If flag2 Then
					Me.chkIsVAT.Visible = False
				End If
				Me.btnRecData.Visible = True
				Me.btnRecData.Text = "بيانات أمر الإستلام"
				Me.btnRecPrint.Text = "طباعة سند إستلام"
			Else
				Me.pnlCustDisc.Visible = True
				Me.pnlInvCustDisc.Visible = True
				Me.lblTotPurch.Visible = False
				Me.txtTotPurch.Visible = False
				Me.chkIsVAT.Visible = False
				Me.printDoc.Visible = False
				Me._IsBuy = 0
				Me.dgvItems.Columns("colExpire").Visible = False
				Me.btnRecData.Visible = True
			End If
			flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 1)
			If flag2 Then
				Me.lblAcc.Visible = True
				Me.cmbAcc.Visible = True
			End If
			flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 2)
			If flag2 Then
				Me.chkDebtNote.Visible = True
			End If
			flag2 = (Me.InvProc = 2)
			If flag2 Then
				Me.pnlErsalia.Visible = True
				Me.LoadErsSupp()
			End If
			flag2 = (Me.InvProc = 2 And Me.cmbProcType.SelectedIndex = 0)
			If flag2 Then
				Me.chkExpire.Visible = True
			End If
			Me.LoadAllCurrency()
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDate.Value = DateTime.Now
			Me.txtPeriodDate1.Value = DateTime.Now
			Me.txtPeriodDate2.Value = DateTime.Now
			Me.txtDueDate.Value = DateTime.Now
			frmChargeData.txtRecDate.Value = DateTime.Now
			Me.LoadGroups()
			Me.LoadUnits()
			Me.LoadSafes(False)
			Me.LoadStocks(False)
			Me.LoadCustomers()
			Me.LoadSalesMen()
			Me.LoadBaks()
			Me.LoadCenters()
			flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 1)
			If flag2 Then
				Me.LoadAccounts()
			End If
			Try
				Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select tax,vat_type,showdisc,showafterdisc,showtax,show_barcode,chk_expire,actv_custdisc,sales_title,sales_title2,is_lbl_header,nameA,purch_operateno,purch_expire,sales_operateno,sales_expire,is_client_lastsale,chk_client_creditlimit,retention,barcode_read_type,print_elecinv,print_file_out,print_img,is_zatc_integ,is_prevent_inv_zatc_fail,is_ammand,is_pono from Foundation", Me.conn)
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter4.Fill(dataTable4)
				flag2 = (dataTable4.Rows.Count > 0)
				If flag2 Then
					Try
						Me._VatVal = Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)("tax")))
					Catch ex13 As Exception
					End Try
					Try
						flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable4.Rows(0)("vat_type"))) = 2.0)
						If flag2 Then
							Me.chkInTax.Checked = True
						End If
					Catch ex14 As Exception
					End Try
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("showdisc")))
					If flag2 Then
						Me.dgvItems.Columns(11).Visible = False
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("showafterdisc")))
					If flag2 Then
						Me.dgvItems.Columns(13).Visible = False
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("showtax")))
					If flag2 Then
						Me.dgvItems.Columns(14).Visible = False
						Me.dgvItems.Columns(15).Visible = False
					End If
					Try
						Me._ShowBarcode = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("show_barcode")))
					Catch ex15 As Exception
					End Try
					Try
						Me.chk_Expire = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("chk_expire")))
						Me.chkExpire.Checked = Me.chk_Expire
					Catch ex16 As Exception
					End Try
					Try
						flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("actv_custdisc")))
						If flag2 Then
							Me.pnlCustDisc.Visible = False
							Me.chkUseDisc.Checked = False
							Me.pnlInvCustDisc.Visible = False
						End If
					Catch ex17 As Exception
					End Try
					Try
						flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable4.Rows(0)("sales_title")), "", False)
						If flag2 Then
							Me.Sales_title = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("sales_title")))
						End If
					Catch ex18 As Exception
					End Try
					Try
						flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable4.Rows(0)("sales_title2")), "", False)
						If flag2 Then
							Me.Sales_title2 = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("sales_title2")))
						End If
					Catch ex19 As Exception
					End Try
					Try
						flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_lbl_header")))
						If flag2 Then
							Me.pnlHeader.Visible = True
							Me.lblHeader.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("nameA")))
						End If
					Catch ex20 As Exception
					End Try
					Try
						Me._showPurchOperateno = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("purch_operateno")))
						Me._showPurchExpire = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("purch_expire")))
						Me._showSalesOperateno = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("sales_operateno")))
						Me._showSalesExpire = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("sales_expire")))
					Catch ex21 As Exception
					End Try
					Try
						Me._lastclientsale = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_client_lastsale")))
					Catch ex22 As Exception
					End Try
					Try
						Me._chkclientcreditlimit = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("chk_client_creditlimit")))
					Catch ex23 As Exception
					End Try
					Try
						flag2 = (Me.InvProc = 2)
						If flag2 Then
							Me.lblRetention.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("retention")))
							flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable4.Rows(0)("retention")), "", False)
							If flag2 Then
								Me.pnlRetention.Visible = True
							End If
						End If
					Catch ex24 As Exception
					End Try
					Try
						Me._BarcodeReadType = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("barcode_read_type")))
					Catch ex25 As Exception
					End Try
					Try
						Me._PrintElecInv = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("print_elecinv")))
						flag2 = (Me._PrintElecInv And (Me.cmbProcType.SelectedIndex = 0 Or Me.cmbProcType.SelectedIndex = 1) And Me.InvProc = 2)
						If flag2 Then
							Me.pnlElecInv.Visible = True
						End If
					Catch ex26 As Exception
					End Try
					Try
						Me._PrintFileOut = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("print_file_out")))
					Catch ex27 As Exception
					End Try
					Try
						Me._PrintImg = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("print_img")))
					Catch ex28 As Exception
					End Try
					Try
						Me._ZatcInteg = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_zatc_integ")))
						Me._PreventInvZatcFail = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_prevent_inv_zatc_fail")))
					Catch ex29 As Exception
					End Try
					Try
						Me._IsAmmand = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_ammand")))
					Catch ex30 As Exception
					End Try
					Try
						flag2 = ((Me.cmbProcType.SelectedIndex = 0 Or Me.cmbProcType.SelectedIndex = 1) And Me.InvProc = 2)
						If flag2 Then
							Me._IsPoNo = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_pono")))
						End If
					Catch ex31 As Exception
					End Try
				End If
			Catch ex32 As Exception
			End Try
			flag2 = Me._IsPoNo
			If flag2 Then
				Me.lblPoNo.Visible = True
				Me.txtPoNo.Visible = True
				Me.GroupBox3.Height = 87
			End If
			flag2 = ((Me.cmbProcType.SelectedIndex = 0 Or Me.cmbProcType.SelectedIndex = 1 Or Me.cmbProcType.SelectedIndex = 2) And Me._IsAmmand)
			If flag2 Then
				Me.chkHold.Visible = True
				Me.chkSrchHold.Visible = True
			End If
			Try
				flag2 = (Me._showPurchExpire And Me.InvProc = 1)
				If flag2 Then
					Me.Label9.Visible = True
					Me.txtExpireDate.Visible = True
					Me.dgvItems.Columns("colExpire").Visible = True
				End If
			Catch ex33 As Exception
			End Try
			Try
				flag2 = (Me._showSalesExpire And Me.InvProc = 2)
				If flag2 Then
					Me.Label9.Visible = True
					Me.txtExpireDate.Visible = True
					Me.dgvItems.Columns("colExpire").Visible = True
				End If
			Catch ex34 As Exception
			End Try
			Try
				flag2 = (Me._showPurchOperateno And Me.InvProc = 1)
				If flag2 Then
					Me.dgvItems.Columns("colOperateNo").Visible = True
				End If
			Catch ex35 As Exception
			End Try
			Try
				flag2 = (Me._showSalesOperateno And Me.InvProc = 2)
				If flag2 Then
					Me.dgvItems.Columns("colOperateNo").Visible = True
				End If
			Catch ex36 As Exception
			End Try
			Try
				flag2 = Me.dgvItems.Columns("colOperateNo").Visible
				If flag2 Then
					Me.dgvItems.Columns("colOperateNo").DisplayIndex = 3
				End If
				flag2 = Me.dgvItems.Columns("colExpire").Visible
				If flag2 Then
					Me.dgvItems.Columns("colExpire").DisplayIndex = 4
				End If
			Catch ex37 As Exception
			End Try
			Try
				flag2 = MainClass.hide_retention
				If flag2 Then
					Me.pnlRetention.Visible = False
				End If
			Catch ex38 As Exception
			End Try
			Try
				flag2 = MainClass.hide_costcenter
				If flag2 Then
					Me.lblcostcenter.Visible = False
					Me.cmbCenter.Visible = False
				End If
			Catch ex39 As Exception
			End Try
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 4 And Me._PrintElecInv)
				If flag2 Then
					Me.pnlPurchOrder.Visible = True
				End If
			Catch ex40 As Exception
			End Try
			Me.txtDate.Value = DateTime.Now
			Me.cmbType.SelectedIndex = 1
			Me.GetDefaultInvType()
			AddHandler Me.cmbCurrency.SelectedIndexChanged, AddressOf Me.cmbCurrency_SelectedIndexChanged
			AddHandler Me.cmbClient.SelectedIndexChanged, AddressOf Me.cmbClient_SelectedIndexChanged
			flag2 = (Me.cmbClient.Items.Count > 0)
			If flag2 Then
				Me.cmbClient.SelectedIndex = 0
			End If
			flag2 = (Me.cmbSafe.Items.Count > 0)
			If flag2 Then
				Me.cmbSafe.SelectedIndex = 0
			End If
			flag2 = (Me.cmbStock.Items.Count > 0)
			If flag2 Then
				Me.cmbStock.SelectedIndex = 0
			End If
			flag2 = Not Me.btnPrint.Enabled
			If flag2 Then
				Me.btnPrintCashier.Enabled = False
				Me.btnPreview.Enabled = False
			End If
			Me._loaded = True
			Me.cmbClient_SelectedIndexChanged(Nothing, Nothing)
			Me.cmbBanks.Visible = True
			Me.txtBarcode.Focus()
		Catch ex41 As Exception
		End Try
	End Sub
	'////////////////////////
	Private Sub frmSalePurch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		Control.CheckForIllegalCrossThreadCalls = False

		' تطبيق التصميم الاحترافي
		ApplyProfessionalDesign()

		' ترتيب العناصر ومنع التداخل
		ArrangeControlsWithoutOverlap()

		' تحميل البيانات
		Me.LoadData()
	End Sub

#Region "التصميم الاحترافي"

	''' <summary>
	''' تطبيق التصميم الاحترافي على النموذج
	''' </summary>
	Private Sub ApplyProfessionalDesign()
		' تعريف الألوان الرئيسية
		Dim PrimaryColor As Color = Color.FromArgb(41, 128, 185)
		Dim SecondaryColor As Color = Color.FromArgb(52, 73, 94)
		Dim AccentColor As Color = Color.FromArgb(26, 188, 156)
		Dim DangerColor As Color = Color.FromArgb(231, 76, 60)
		Dim WarningColor As Color = Color.FromArgb(241, 196, 15)
		Dim LightBgColor As Color = Color.FromArgb(236, 240, 241)
		Dim WhiteColor As Color = Color.White
		Dim DarkTextColor As Color = Color.FromArgb(44, 62, 80)

		' تطبيق على النموذج
		Me.BackColor = LightBgColor
		Me.ForeColor = DarkTextColor

		' تطبيق التصميم على جميع العناصر
		ApplyDesignToAllControls(Me.Controls, PrimaryColor, SecondaryColor, AccentColor, DangerColor, WarningColor, LightBgColor, WhiteColor, DarkTextColor)

		' تصميم خاص للجداول
		StyleDataGridViews()

		' تصميم خاص لشريط الأدوات
		StyleToolStrip()

		' تصميم خاص للتبويبات
		StyleTabControl()
	End Sub

	''' <summary>
	''' تطبيق التصميم على جميع العناصر بشكل تكراري
	''' </summary>
	Private Sub ApplyDesignToAllControls(ByVal controls As Control.ControlCollection,
									  ByVal PrimaryColor As Color,
									  ByVal SecondaryColor As Color,
									  ByVal AccentColor As Color,
									  ByVal DangerColor As Color,
									  ByVal WarningColor As Color,
									  ByVal LightBgColor As Color,
									  ByVal WhiteColor As Color,
									  ByVal DarkTextColor As Color)

		For Each ctrl As Control In controls
			' تصميم الأزرار
			If TypeOf ctrl Is Button Then
				Dim btn As Button = DirectCast(ctrl, Button)
				btn.FlatStyle = FlatStyle.Flat
				btn.FlatAppearance.BorderSize = 0
				btn.Cursor = Cursors.Hand
				btn.Font = New Font("Tahoma", 9, FontStyle.Bold)

				' تحديد اللون حسب اسم الزر
				If btn.Name.ToLower.Contains("save") Or btn.Name.ToLower.Contains("add") Then
					btn.BackColor = AccentColor
					btn.ForeColor = WhiteColor
				ElseIf btn.Name.ToLower.Contains("delete") Or btn.Name.ToLower.Contains("close") Then
					btn.BackColor = DangerColor
					btn.ForeColor = WhiteColor
				ElseIf btn.Name.ToLower.Contains("print") Then
					btn.BackColor = PrimaryColor
					btn.ForeColor = WhiteColor
				ElseIf btn.Name.ToLower.Contains("search") Then
					btn.BackColor = PrimaryColor
					btn.ForeColor = WhiteColor
				Else
					btn.BackColor = SecondaryColor
					btn.ForeColor = WhiteColor
				End If
			End If

			' تصميم حقول النص
			If TypeOf ctrl Is TextBox Then
				Dim txt As TextBox = DirectCast(ctrl, TextBox)
				txt.BorderStyle = BorderStyle.FixedSingle
				txt.Font = New Font("Tahoma", 10, FontStyle.Regular)
				txt.BackColor = WhiteColor
				txt.ForeColor = DarkTextColor
			End If

			' تصميم القوائم المنسدلة
			If TypeOf ctrl Is ComboBox Then
				Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
				cmb.FlatStyle = FlatStyle.Flat
				cmb.Font = New Font("Tahoma", 10, FontStyle.Bold)
				cmb.BackColor = WhiteColor
				cmb.ForeColor = DarkTextColor
			End If

			' تصميم العناوين
			If TypeOf ctrl Is Label Then
				Dim lbl As Label = DirectCast(ctrl, Label)
				lbl.Font = New Font("Tahoma", 10, FontStyle.Bold)
				lbl.ForeColor = DarkTextColor
			End If

			' تصميم مجموعات العناصر
			If TypeOf ctrl Is GroupBox Then
				Dim grp As GroupBox = DirectCast(ctrl, GroupBox)
				grp.Font = New Font("Tahoma", 10, FontStyle.Bold)
				grp.ForeColor = PrimaryColor
				grp.BackColor = WhiteColor
			End If

			' تصميم اللوحات
			If TypeOf ctrl Is Panel Then
				Dim pnl As Panel = DirectCast(ctrl, Panel)
				pnl.BackColor = WhiteColor
			End If

			' تصميم خانات الاختيار
			If TypeOf ctrl Is CheckBox Then
				Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
				chk.Font = New Font("Tahoma", 9, FontStyle.Bold)
				chk.ForeColor = DarkTextColor
			End If

			' تصميم أزرار الراديو
			If TypeOf ctrl Is RadioButton Then
				Dim rdb As RadioButton = DirectCast(ctrl, RadioButton)
				rdb.Font = New Font("Tahoma", 9, FontStyle.Bold)
				rdb.ForeColor = DarkTextColor
			End If

			' تكرار للعناصر الفرعية
			If ctrl.HasChildren Then
				ApplyDesignToAllControls(ctrl.Controls, PrimaryColor, SecondaryColor, AccentColor, DangerColor, WarningColor, LightBgColor, WhiteColor, DarkTextColor)
			End If
		Next
	End Sub

	''' <summary>
	''' تصميم جداول البيانات
	''' </summary>
	Private Sub StyleDataGridViews()
		Dim PrimaryColor As Color = Color.FromArgb(41, 128, 185)
		Dim WhiteColor As Color = Color.White
		Dim DarkTextColor As Color = Color.FromArgb(44, 62, 80)
		Dim LightBgColor As Color = Color.FromArgb(248, 249, 250)

		Dim grids As New List(Of DataGridView)
		grids.Add(dgvItems)
		grids.Add(dgvSrch)

		For Each dgv As DataGridView In grids
			If dgv IsNot Nothing Then
				' الإعدادات العامة
				dgv.BackgroundColor = WhiteColor
				dgv.BorderStyle = BorderStyle.None
				dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
				dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
				dgv.EnableHeadersVisualStyles = False
				dgv.RowHeadersVisible = False
				dgv.GridColor = Color.FromArgb(224, 224, 224)

				' تصميم رؤوس الأعمدة
				dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor
				dgv.ColumnHeadersDefaultCellStyle.ForeColor = WhiteColor
				dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
				dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				dgv.ColumnHeadersDefaultCellStyle.Padding = New Padding(5)
				dgv.ColumnHeadersHeight = 45

				' تصميم الصفوف
				dgv.DefaultCellStyle.BackColor = WhiteColor
				dgv.DefaultCellStyle.ForeColor = DarkTextColor
				dgv.DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
				dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219)
				dgv.DefaultCellStyle.SelectionForeColor = WhiteColor
				dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				dgv.DefaultCellStyle.Padding = New Padding(3)

				' تصميم الصفوف المتناوبة
				dgv.AlternatingRowsDefaultCellStyle.BackColor = LightBgColor
				dgv.AlternatingRowsDefaultCellStyle.ForeColor = DarkTextColor

				' ارتفاع الصفوف
				dgv.RowTemplate.Height = 35
			End If
		Next
	End Sub

	''' <summary>
	''' تصميم شريط الأدوات
	''' </summary>
	Private Sub StyleToolStrip()
		Dim SecondaryColor As Color = Color.FromArgb(52, 73, 94)

		If toolStrip1 IsNot Nothing Then
			toolStrip1.BackColor = SecondaryColor
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden
			toolStrip1.Padding = New Padding(10, 5, 10, 5)
			toolStrip1.RenderMode = ToolStripRenderMode.Professional
		End If
	End Sub

	''' <summary>
	''' تصميم التبويبات
	''' </summary>
	Private Sub StyleTabControl()
		If TabControl1 IsNot Nothing Then
			TabControl1.Appearance = TabAppearance.FlatButtons
			TabControl1.ItemSize = New Size(200, 40)
			TabControl1.SizeMode = TabSizeMode.Fixed
			TabControl1.Font = New Font("Tahoma", 11, FontStyle.Bold)
		End If
	End Sub

#End Region

#Region "ترتيب العناصر ومنع التداخل"

	''' <summary>
	''' ترتيب جميع العناصر ومنع التداخل
	''' </summary>
	Private Sub ArrangeControlsWithoutOverlap()
		' ترتيب عناصر Panel4 (لوحة إدخال بيانات الأصناف)
		ArrangePanel4Controls()

		' ترتيب عناصر GroupBox3 (بيانات الفاتورة)
		ArrangeGroupBox3Controls()

		' ترتيب عناصر GroupBox8 (الإجماليات)
		ArrangeGroupBox8Controls()

		' ترتيب عناصر GroupBox9 (الطباعة)
		ArrangeGroupBox9Controls()

		' ترتيب عناصر GroupBox6 (البحث)
		ArrangeGroupBox6Controls()

		' تحديث الشاشة
		Me.Refresh()
	End Sub

	''' <summary>
	''' ترتيب عناصر لوحة إدخال الأصناف
	''' </summary>
	Private Sub ArrangePanel4Controls()
		If Panel4 Is Nothing Then Exit Sub

		Dim startX As Integer = Panel4.Width - 20
		Dim startY As Integer = 10
		Dim rowHeight As Integer = 38
		Dim spacing As Integer = 10
		Dim labelWidth As Integer = 80
		Dim controlWidth As Integer = 150

		' الصف الأول - العميل
		Dim row1Y As Integer = startY

		lblClient.Location = New Point(startX - lblClient.Width, row1Y)
		cmbClient.Location = New Point(lblClient.Left - cmbClient.Width - spacing, row1Y)
		btnCustAdd.Location = New Point(cmbClient.Left - btnCustAdd.Width - 5, row1Y)
		txtCustNo.Location = New Point(btnCustAdd.Left - txtCustNo.Width - 5, row1Y)

		Label28.Location = New Point(txtCustNo.Left - Label28.Width - spacing, row1Y)
		txtBalance.Location = New Point(Label28.Left - txtBalance.Width - 5, row1Y)

		' الصف الثاني - بيانات العميل
		Dim row2Y As Integer = row1Y + rowHeight

		Label54.Location = New Point(startX - Label54.Width, row2Y)
		txtCustTel.Location = New Point(Label54.Left - txtCustTel.Width - spacing, row2Y)

		Label47.Location = New Point(txtCustTel.Left - Label47.Width - spacing, row2Y)
		txtCustAddress.Location = New Point(Label47.Left - txtCustAddress.Width - 5, row2Y)

		lblNote.Location = New Point(txtCustAddress.Left - lblNote.Width - spacing, row2Y)
		txtCustNote.Location = New Point(lblNote.Left - txtCustNote.Width - 5, row2Y)

		' الصف الثالث - المنتج والمجموعة
		Dim row3Y As Integer = row2Y + rowHeight

		Label17.Location = New Point(startX - Label17.Width, row3Y)
		txtBarcode.Location = New Point(Label17.Left - txtBarcode.Width - spacing, row3Y)

		Label19.Location = New Point(txtBarcode.Left - Label19.Width - spacing, row3Y)
		cmbGroups.Location = New Point(Label19.Left - cmbGroups.Width - 5, row3Y)

		Label4.Location = New Point(cmbGroups.Left - Label4.Width - spacing, row3Y)
		cmbCurrency.Location = New Point(Label4.Left - cmbCurrency.Width - 5, row3Y)

		Button13.Location = New Point(cmbCurrency.Left - Button13.Width - 5, row3Y)
		btnRefreshItems.Location = New Point(Button13.Left - btnRefreshItems.Width - 5, row3Y)

		Label29.Location = New Point(btnRefreshItems.Left - Label29.Width - spacing, row3Y)
		cmbUnits.Location = New Point(Label29.Left - cmbUnits.Width - 5, row3Y)

		' الصف الرابع - الكمية والسعر
		Dim row4Y As Integer = row3Y + rowHeight

		Label5.Location = New Point(startX - Label5.Width, row4Y)
		txtVal1.Location = New Point(Label5.Left - txtVal1.Width - spacing, row4Y)

		Label6.Location = New Point(txtVal1.Left - Label6.Width - spacing, row4Y)
		txtExchangeVal.Location = New Point(Label6.Left - txtExchangeVal.Width - 5, row4Y)

		Label7.Location = New Point(txtExchangeVal.Left - Label7.Width - spacing, row4Y)
		txtVal2.Location = New Point(Label7.Left - txtVal2.Width - 5, row4Y)

		' الصف الخامس - الخصم والضريبة
		Dim row5Y As Integer = row4Y + rowHeight

		Label36.Location = New Point(startX - Label36.Width, row5Y)
		txtCurrDisc.Location = New Point(Label36.Left - txtCurrDisc.Width - 5, row5Y)
		Label35.Location = New Point(txtCurrDisc.Left - Label35.Width, row5Y)
		txtCurrDiscVal.Location = New Point(Label35.Left - txtCurrDiscVal.Width - 5, row5Y)

		Label3.Location = New Point(txtCurrDiscVal.Left - Label3.Width - spacing, row5Y)
		txtCurrTax.Location = New Point(Label3.Left - txtCurrTax.Width - 5, row5Y)
		Label32.Location = New Point(txtCurrTax.Left - Label32.Width, row5Y)
		lblCurrTaxVal.Location = New Point(Label32.Left - lblCurrTaxVal.Width - 5, row5Y)

		' الصف السادس - البيان وأزرار الحفظ
		Dim row6Y As Integer = row5Y + rowHeight

		Label45.Location = New Point(startX - Label45.Width, row6Y)
		txtItemNote.Location = New Point(Label45.Left - txtItemNote.Width - spacing, row6Y)

		btnSave2DG.Location = New Point(txtItemNote.Left - btnSave2DG.Width - spacing, row6Y)
		btnNew2DG.Location = New Point(btnSave2DG.Left - btnNew2DG.Width - 5, row6Y)
	End Sub

	''' <summary>
	''' ترتيب عناصر بيانات الفاتورة
	''' </summary>
	Private Sub ArrangeGroupBox3Controls()
		If GroupBox3 Is Nothing Then Exit Sub

		Dim startX As Integer = GroupBox3.Width - 20
		Dim startY As Integer = 18
		Dim spacing As Integer = 10

		' الصف الأول
		Label14.Location = New Point(startX - Label14.Width, startY)
		txtNo.Location = New Point(Label14.Left - txtNo.Width - 5, startY)

		Label13.Location = New Point(txtNo.Left - Label13.Width - spacing, startY)
		txtDate.Location = New Point(Label13.Left - txtDate.Width - 5, startY)

		Label18.Location = New Point(txtDate.Left - Label18.Width - spacing, startY)
		cmbType.Location = New Point(Label18.Left - cmbType.Width - 5, startY)

		Label12.Location = New Point(cmbType.Left - Label12.Width - spacing, startY)
		cmbSafe.Location = New Point(Label12.Left - cmbSafe.Width - 5, startY)

		Label16.Location = New Point(cmbSafe.Left - Label16.Width - spacing, startY)
		cmbStock.Location = New Point(Label16.Left - cmbStock.Width - 5, startY)

		' الصف الثاني
		Dim row2Y As Integer = startY + 32

		lblSrcInvNo.Location = New Point(startX - lblSrcInvNo.Width, row2Y)
		txtSrcInvNo.Location = New Point(lblSrcInvNo.Left - txtSrcInvNo.Width - 5, row2Y)

		lblSalesMen.Location = New Point(txtSrcInvNo.Left - lblSalesMen.Width - spacing, row2Y)
		cmbSalesMen.Location = New Point(lblSalesMen.Left - cmbSalesMen.Width - 5, row2Y)
		cmbAddSalesMen.Location = New Point(cmbSalesMen.Left - cmbAddSalesMen.Width - 5, row2Y)

		chkIsVAT.Location = New Point(cmbAddSalesMen.Left - chkIsVAT.Width - spacing, row2Y)
		chkInTax.Location = New Point(chkIsVAT.Left - chkInTax.Width - spacing, row2Y)

		lblcostcenter.Location = New Point(chkInTax.Left - lblcostcenter.Width - spacing, row2Y)
		cmbCenter.Location = New Point(lblcostcenter.Left - cmbCenter.Width - 5, row2Y)
	End Sub

	''' <summary>
	''' ترتيب عناصر الإجماليات
	''' </summary>
	Private Sub ArrangeGroupBox8Controls()
		If GroupBox8 Is Nothing Then Exit Sub

		Dim centerX As Integer = GroupBox8.Width \ 2
		Dim startY As Integer = 20
		Dim rowHeight As Integer = 35
		Dim controlWidth As Integer = 200

		' لوحة الأرقام
		GroupBox5.Location = New Point(10, startY)
		GroupBox5.Size = New Size(GroupBox8.Width - 20, 135)

		' اجمالي المبيعات
		Dim row1Y As Integer = GroupBox5.Bottom + 10
		lblTotSale.Location = New Point(10, row1Y)
		lblTotSale.Size = New Size(GroupBox8.Width - 20, 26)

		txtTotSale.Location = New Point(10, lblTotSale.Bottom + 2)
		txtTotSale.Size = New Size(GroupBox8.Width - 20, 35)

		' الخصم
		Dim row2Y As Integer = txtTotSale.Bottom + 10
		Label22.Location = New Point(GroupBox8.Width - Label22.Width - 10, row2Y)
		txtDiscPerc.Location = New Point(Label22.Left - txtDiscPerc.Width - 5, row2Y)
		Label44.Location = New Point(txtDiscPerc.Left - Label44.Width, row2Y)
		txtMinusVal.Location = New Point(Label44.Left - txtMinusVal.Width - 5, row2Y)

		' اجمالي بعد الخصم
		Dim row3Y As Integer = row2Y + rowHeight
		Label37.Location = New Point(10, row3Y)
		Label37.Size = New Size(GroupBox8.Width - 20, 26)

		txtTotAfterDisc.Location = New Point(10, Label37.Bottom + 2)
		txtTotAfterDisc.Size = New Size(GroupBox8.Width - 20, 38)

		' القيمة المضافة
		Dim row4Y As Integer = txtTotAfterDisc.Bottom + 5
		Label30.Location = New Point(GroupBox8.Width - Label30.Width - 10, row4Y)
		lblTaxVal.Location = New Point(Label30.Left - lblTaxVal.Width - 10, row4Y)

		' الصافي
		Dim row5Y As Integer = row4Y + 30
		Label20.Location = New Point(10, row5Y)
		Label20.Size = New Size(GroupBox8.Width - 20, 30)

		txtDiff.Location = New Point(10, Label20.Bottom + 2)
		txtDiff.Size = New Size(GroupBox8.Width - 20, 35)

		' الاستلام والمتبقي
		Dim row6Y As Integer = txtDiff.Bottom + 10
		Label33.Location = New Point(GroupBox8.Width - Label33.Width - 10, row6Y)
		txtrec.Location = New Point(Label33.Left - txtrec.Width - 5, row6Y)
		Label34.Location = New Point(txtrec.Left - Label34.Width - 10, row6Y)
		txtrecrem.Location = New Point(Label34.Left - txtrecrem.Width - 5, row6Y)

		' لوحة الدفع
		pnlPay2.Location = New Point(0, GroupBox8.Height - pnlPay2.Height - 5)
		pnlPay2.Size = New Size(GroupBox8.Width, 52)
	End Sub

	''' <summary>
	''' ترتيب عناصر الطباعة
	''' </summary>
	Private Sub ArrangeGroupBox9Controls()
		If GroupBox9 Is Nothing Then Exit Sub

		Dim startX As Integer = GroupBox9.Width - 20
		Dim startY As Integer = 15
		Dim buttonWidth As Integer = 80
		Dim buttonHeight As Integer = 50
		Dim spacing As Integer = 5

		' الصف الأول - الملاحظات وإجمالي الكمية
		Label27.Location = New Point(startX - Label27.Width, startY)
		TextBox1.Location = New Point(Label27.Left - TextBox1.Width - spacing, startY + 20)
		TextBox1.Size = New Size(200, 60)

		Label38.Location = New Point(TextBox1.Left - Label38.Width - 20, startY)
		txtTotQuan.Location = New Point(Label38.Left - txtTotQuan.Width - 5, startY + 20)

		Label42.Location = New Point(txtTotQuan.Left - Label42.Width - 20, startY)
		NumericUpDown1.Location = New Point(Label42.Left - NumericUpDown1.Width - 5, startY + 20)

		' أزرار الطباعة
		Dim buttonsY As Integer = startY + 25
		Dim currentX As Integer = NumericUpDown1.Left - spacing - buttonWidth

		btnPrintCashier.Location = New Point(currentX, buttonsY)
		btnPrintCashier.Size = New Size(buttonWidth, buttonHeight)
		currentX -= (buttonWidth + spacing)

		Button6.Location = New Point(currentX, buttonsY)
		Button6.Size = New Size(buttonWidth, buttonHeight)
		currentX -= (buttonWidth + spacing)

		Button7.Location = New Point(currentX, buttonsY)
		Button7.Size = New Size(buttonWidth, buttonHeight)
		currentX -= (buttonWidth + spacing)

		Button8.Location = New Point(currentX, buttonsY)
		Button8.Size = New Size(buttonWidth, buttonHeight)
		currentX -= (buttonWidth + spacing)

		Button9.Location = New Point(currentX, buttonsY)
		Button9.Size = New Size(buttonWidth, buttonHeight)
		currentX -= (buttonWidth + spacing)

		Panel6.Location = New Point(currentX, buttonsY)
		Panel6.Size = New Size(85, buttonHeight)
		currentX -= (100 + spacing)

		Button18.Location = New Point(currentX, buttonsY)
		Button18.Size = New Size(95, buttonHeight)
		currentX -= (100 + spacing)

		btnRecPrint.Location = New Point(currentX, buttonsY)
		btnRecPrint.Size = New Size(95, buttonHeight)

		' شريط الأدوات في الأسفل
		panel2.Dock = DockStyle.Bottom
		panel2.Height = 60
	End Sub

	''' <summary>
	''' ترتيب عناصر البحث
	''' </summary>
	Private Sub ArrangeGroupBox6Controls()
		If GroupBox6 Is Nothing Then Exit Sub

		Dim startX As Integer = GroupBox6.Width - 20
		Dim startY As Integer = 25
		Dim rowHeight As Integer = 35
		Dim spacing As Integer = 15
		Dim labelWidth As Integer = 100
		Dim controlWidth As Integer = 150

		' الصف الأول
		Dim row1Y As Integer = startY

		Label11.Location = New Point(startX - Label11.Width, row1Y)
		txtSrchNo.Location = New Point(Label11.Left - txtSrchNo.Width - 5, row1Y)

		Label43.Location = New Point(txtSrchNo.Left - Label43.Width - spacing, row1Y)
		txtSrchBarcode.Location = New Point(Label43.Left - txtSrchBarcode.Width - 5, row1Y)

		' الصف الثاني
		Dim row2Y As Integer = row1Y + rowHeight

		Label1.Location = New Point(startX - Label1.Width, row2Y)
		txtFromDate.Location = New Point(Label1.Left - txtFromDate.Width - 5, row2Y)

		Label2.Location = New Point(txtFromDate.Left - Label2.Width - spacing, row2Y)
		txtToDate.Location = New Point(Label2.Left - txtToDate.Width - 5, row2Y)

		chkSrchDate.Location = New Point(txtToDate.Left - chkSrchDate.Width - spacing, row2Y)

		' الصف الثالث
		Dim row3Y As Integer = row2Y + rowHeight

		lblClientSrch.Location = New Point(startX - lblClientSrch.Width, row3Y)
		cmbClientSrch.Location = New Point(lblClientSrch.Left - cmbClientSrch.Width - 5, row3Y)

		chkAll.Location = New Point(cmbClientSrch.Left - chkAll.Width - spacing, row3Y)
		Button12.Location = New Point(chkAll.Left - Button12.Width - 5, row3Y)

		' الصف الرابع
		Dim row4Y As Integer = row3Y + rowHeight

		Label39.Location = New Point(startX - Label39.Width, row4Y)
		txtClientMobile.Location = New Point(Label39.Left - txtClientMobile.Width - 5, row4Y)

		' زر البحث
		btnSearch.Location = New Point(txtToDate.Left - btnSearch.Width - 30, row1Y)
		btnSearch.Size = New Size(130, 90)
	End Sub

#End Region

#Region "أحداث تغيير حجم النموذج"

	''' <summary>
	''' إعادة ترتيب العناصر عند تغيير حجم النموذج
	''' </summary>
	Private Sub frmSalePurch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		If Me.WindowState <> FormWindowState.Minimized Then
			ArrangeControlsWithoutOverlap()
		End If
	End Sub

	''' <summary>
	''' إعادة ترتيب العناصر عند تغيير حجم اللوحات
	''' </summary>
	Private Sub Panel4_Resize(sender As Object, e As EventArgs) Handles Panel4.Resize
		ArrangePanel4Controls()
	End Sub

	Private Sub GroupBox3_Resize(sender As Object, e As EventArgs) Handles GroupBox3.Resize
		ArrangeGroupBox3Controls()
	End Sub

	Private Sub GroupBox8_Resize(sender As Object, e As EventArgs) Handles GroupBox8.Resize
		ArrangeGroupBox8Controls()
	End Sub

	Private Sub GroupBox9_Resize(sender As Object, e As EventArgs) Handles GroupBox9.Resize
		ArrangeGroupBox9Controls()
	End Sub

	Private Sub GroupBox6_Resize(sender As Object, e As EventArgs) Handles GroupBox6.Resize
		ArrangeGroupBox6Controls()
	End Sub

#End Region
	'////////////////////////
	Private Sub UpdateCustDiscBalance()
		Try
			Dim num As Double = Conversion.Val(Me.txtDiscBalance.Text)
			Dim flag As Boolean = Me.Code <> -1
			If flag Then
				num = num - Me._CustDiscAdded + Me._custdisc
			End If
			Dim num2 As Double = 0.0
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select CustDisc from Foundation where id=1", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) <> 0.0
				If flag2 Then
					num2 = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) / 100.0 * Conversion.Val(Me.txtDiff.Text)
				End If
			End If
			num = num - Conversion.Val(Me.txtInvCustDisc.Text) + num2
			Me.conn1.Open()
			Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update customers set discount_balance=" + Conversions.ToString(Math.Round(num, 2)) + " where id=", Me.cmbClient.SelectedValue)), Me.conn1)
			sqlCommand.ExecuteNonQuery()
			Me.conn1.Close()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateCustDiscBalanceRet()
		Try
			Dim num As Double = Conversion.Val(Me.txtDiscBalance.Text)
			Dim flag As Boolean = Not Me._newproc
			If flag Then
				num = num + Me._CustDiscAdded - Me._custdisc
			End If
			Dim num2 As Double = 0.0
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select CustDisc from Foundation where id=1", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) <> 0.0
				If flag2 Then
					num2 = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))) / 100.0 * Conversion.Val(Me.txtDiff.Text)
				End If
			End If
			num = num + Conversion.Val(Me.txtInvCustDisc.Text) - num2
			Me.conn1.Open()
			Dim sqlCommand As SqlCommand = New SqlCommand(Conversions.ToString(Operators.ConcatenateObject("update customers set discount_balance=" + Conversions.ToString(Math.Round(num, 2)) + " where id=", Me.cmbClient.SelectedValue)), Me.conn1)
			sqlCommand.ExecuteNonQuery()
			Me.conn1.Close()
		Catch ex As Exception
		End Try
	End Sub

	Private Function CalcCurrencyStock(_item As Integer) As Double
		' The following expression was wrapped in a checked-statement
		Dim result As Double
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("currency")
			dataTable.Columns.Add("sum")
			dataTable.Columns.Add("type")
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), _item), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable2.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num3)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num3)(1))), 1})
				num3 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select item,sum(difftot) from tsweya,tsweya_sub where tsweya.id=tsweya_sub.tsweya_id and item=" + Conversions.ToString(_item) + " and safe=", Me.cmbSafe.SelectedValue), " and IS_Deleted=0 group by item")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num6 As Integer = 0
			Dim num7 As Integer = dataTable2.Rows.Count - 1
			Dim num8 As Integer = num6
			While True
				Dim num9 As Integer = num8
				Dim num5 As Integer = num7
				If num9 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num8)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num8)(1))), 1})
				num8 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), _item), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num10 As Integer = 0
			Dim num11 As Integer = dataTable2.Rows.Count - 1
			Dim num12 As Integer = num10
			While True
				Dim num13 As Integer = num12
				Dim num5 As Integer = num11
				If num13 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num12)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num12)(1))), 1})
				num12 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), _item), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num14 As Integer = 0
			Dim num15 As Integer = dataTable2.Rows.Count - 1
			Dim num16 As Integer = num14
			While True
				Dim num17 As Integer = num16
				Dim num5 As Integer = num15
				If num17 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num16)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num16)(1))), 2})
				num16 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), _item), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num18 As Integer = 0
			Dim num19 As Integer = dataTable2.Rows.Count - 1
			Dim num20 As Integer = num18
			While True
				Dim num21 As Integer = num20
				Dim num5 As Integer = num19
				If num21 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num20)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num20)(1))), 2})
				num20 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency_from,sum(val) from inv,inv_sub where (is_hold=0 or is_hold is null) and inv.safe=", Me.cmbSafe.SelectedValue), " and Inv_Sub.currency_from="), _item), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 group by currency_from")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num22 As Integer = 0
			Dim num23 As Integer = dataTable2.Rows.Count - 1
			Dim num24 As Integer = num22
			While True
				Dim num25 As Integer = num24
				Dim num5 As Integer = num23
				If num25 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num24)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num24)(1))), 1})
				num24 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_to=", Me.cmbSafe.SelectedValue), " and currency="), _item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num26 As Integer = 0
			Dim num27 As Integer = dataTable2.Rows.Count - 1
			Dim num28 As Integer = num26
			While True
				Dim num29 As Integer = num28
				Dim num5 As Integer = num27
				If num29 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num28)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num28)(1))), 1})
				num28 += 1
			End While
			sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select currency,sum(value) from SafesTransfer,SafesTransfer_Sub where SafesTransfer.safe_from=", Me.cmbSafe.SelectedValue), " and currency="), _item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id  and IS_Deleted=0 group by currency")), Me.conn)
			dataTable2 = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num30 As Integer = 0
			Dim num31 As Integer = dataTable2.Rows.Count - 1
			Dim num32 As Integer = num30
			While True
				Dim num33 As Integer = num32
				Dim num5 As Integer = num31
				If num33 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(dataTable2.Rows(num32)(0)), Convert.ToDouble(Operators.ConcatenateObject("", dataTable2.Rows(num32)(1))), 2})
				num32 += 1
			End While
			Dim num34 As Integer = dataTable.Rows.Count - 1
			Dim num35 As Integer = 0
			Dim num36 As Integer = num34
			Dim num37 As Integer = num35
			Dim flag3 As Boolean
			While True
				Dim num38 As Integer = num37
				Dim num5 As Integer = num36
				If num38 > num5 Then
					Exit While
				End If
				Dim flag As Boolean = num37 <= num34
				If flag Then
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num37)(2), 2, False)
					If flag2 Then
						' The following expression was wrapped in a unchecked-expression
						dataTable.Rows(num37)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1)))
					End If
				End If
				Dim num39 As Integer = num37 + 1
				Dim num40 As Integer = num34
				Dim num41 As Integer = num39
				While True
					Dim num42 As Integer = num41
					num5 = num40
					If num42 > num5 Then
						Exit While
					End If
					Dim flag2 As Boolean = num41 <= num34
					If flag2 Then
						flag = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num37)(0), dataTable.Rows(num41)(0), False)
						If flag Then
							flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num41)(2), 2, False)

							If flag3 Then
								dataTable.Rows(num41)(1) = -Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num41)(1)))
							End If
							dataTable.Rows(num37)(1) = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num37)(1))) + Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num41)(1)))
							dataTable.Rows.RemoveAt(num41)

							num41 -= 1
							num34 -= 1
						End If
					End If
					num41 += 1
				End While
				num37 += 1
			End While
			flag3 = (dataTable.Rows.Count > 0)
			If flag3 Then
				result = Convert.ToDouble(dataTable.Rows(0)(1).ToString())
			Else
				result = 0.0
			End If
		Catch ex As Exception
			result = 0.0
		End Try
		Return result
	End Function

	'///////////////////////////////
	Public Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
		Dim sqlTransaction As SqlTransaction = Nothing

		Try
			' ========== التحقق من الترخيص ==========
			If Not ValidateLicense() Then Return

			' ========== التحقق من حد النسخة التجريبية ==========
			If Not ValidateTrialLimit() Then Return

			' ========== التحقق من المدخلات الأساسية ==========
			If Not ValidateBasicInputs() Then Return

			' ========== التحقق من حد ائتمان العميل ==========
			If Not ValidateCustomerCreditLimit() Then Return

			' ========== التحقق من الحد الأدنى للسعر ==========
			If Not ValidateMinimumPrice() Then Return

			' ========== التحقق من رصيد المخزون ==========
			If Not ValidateStockQuantity() Then Return

			' ========== التحقق من البنك والمدفوعات ==========
			If Not ValidatePaymentInputs() Then Return

			' ========== التحقق من اسم المؤسسة ==========
			If Not ValidateFoundationName() Then Return

			' ========== معالجة ربط الزكاة والدخل ==========
			Dim zatcaIntegration As New ZatcaIntegration()
			Dim isZatcaProcessed As Boolean = False
			If Not ProcessZatcaIntegration(zatcaIntegration, isZatcaProcessed) Then Return

			' ========== الحصول على أكواد الحسابات ==========
			Dim clientAccountCode As Integer = GetAccountCode(Me.cmbClient.Text)
			Dim stockAccountCode As Integer = 0
			If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
				stockAccountCode = GetAccountCode(Me.cmbStock.Text)
			End If

			' ========== بدء المعاملة ==========
			OpenConnectionAndBeginTransaction(sqlTransaction)

			' ========== تحديد أكواد القيود ==========
			Dim purchRestCode As Integer = 0
			Dim saleRestCode As Integer = 0
			DetermineRestrictionCodes(sqlTransaction, purchRestCode, saleRestCode)

			' ========== حفظ الفاتورة الرئيسية ==========
			SaveMainInvoice(sqlTransaction, purchRestCode, saleRestCode)

			' ========== تحديث بيانات الفاتورة الإضافية ==========
			Dim isExistingInvoice As Boolean = False
			UpdateInvoiceData(sqlTransaction, zatcaIntegration, isZatcaProcessed, isExistingInvoice)

			' ========== حفظ تفاصيل الفاتورة ==========
			SaveInvoiceDetails(sqlTransaction)

			' ========== حفظ القيود المحاسبية ==========
			Dim refNo As String = GetReferenceNumber()
			Dim centerCode As Integer = GetCenterCode()
			SaveAccountingRestrictions(sqlTransaction, clientAccountCode, stockAccountCode,
								   purchRestCode, saleRestCode, centerCode, refNo)

			' ========== تأكيد المعاملة ==========
			sqlTransaction.Commit()

			' ========== معالجة ما بعد الحفظ ==========
			ProcessPostSaveOperations(isExistingInvoice, saleRestCode, purchRestCode,
								  clientAccountCode, stockAccountCode, refNo)

		Catch ex As Exception
			HandleSaveError(sqlTransaction, ex)
		Finally
			CloseConnection()
		End Try
	End Sub

#Region "دوال التحقق من الصحة"

	Private Function ValidateLicense() As Boolean
		Try
			If Not MainClass.IsTrial Then
				If MainClass.ISExpire(Me.txtDate.Value) Then
					Return False
				End If
			End If
			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function ValidateTrialLimit() As Boolean
		Try
			If Not (MainClass.IsTrial AndAlso Me.ProcCode = -1) Then Return True

			Dim query As String
			Dim maxEntries As Integer = 10
			Dim message As String

			If Me.InvProc = 2 Then
				' فواتير البيع
				query = "SELECT id FROM inv WHERE is_buy=0 AND proc_type=1"
			ElseIf Me.InvProc = 1 Then
				' فواتير الشراء
				query = "SELECT id FROM inv WHERE is_buy=1 AND proc_type=1"
			Else
				Return True
			End If

			Dim adapter As New SqlDataAdapter(query, Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count >= maxEntries Then
				message = If(MainClass.Language = "en",
				"you reach the maximum of entries, you can purchase the app and activate it from support data in the app",
				"لقد وصلت لأقصى حد ادخال للنسخة التجريبية، يمكنك شراء البرنامج وتفعيله من خلال بيانات الدعم الفني بالبرنامج")
				MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.ISTRialEnd = True
				Return False
			End If

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function ValidateBasicInputs() As Boolean
		Me.txtNo.Focus()

		' التحقق من المخزن
		If Me.cmbSafe.SelectedIndex = -1 Then
			MessageBox.Show("يجب اختيار المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
			Return False
		End If

		' التحقق من الخزنة
		If Me.cmbStock.SelectedIndex = -1 Then
			MessageBox.Show("يجب اختيار الخزنة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbStock.Focus()
			Return False
		End If

		' التحقق من العميل/المورد
		If (Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) AndAlso
	   Me.cmbClient.SelectedValue Is Nothing Then

			Dim message As String = If(Me.InvProc = 1, "يجب اختيار المورد", "يجب اختيار العميل")
			MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbClient.Focus()
			Return False
		End If

		' التحقق من وجود أصناف
		If Me.dgvItems.Rows.Count = 0 Then
			MessageBox.Show("يجب ادخال أصناف للفاتورة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.txtBarcode.Focus()
			Return False
		End If

		Return True
	End Function

	Private Function ValidateCustomerCreditLimit() As Boolean
		Try
			If Not (Me.InvProc = 2 AndAlso Me._chkclientcreditlimit AndAlso Me.cmbType.SelectedIndex = 0) Then
				Return True
			End If

			If Me.ProcCode <> -1 Then Return True

			Dim adapter As New SqlDataAdapter(
			$"SELECT credit_limit FROM Customers WHERE id={Me.cmbClient.SelectedValue}", Me.conn)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Dim creditLimit As Double = Conversion.Val($"{dt.Rows(0)(0)}")
				If creditLimit <> 0.0 Then
					Dim custBalance As Double = Me.GetCustBalance(Me.cmbClient.Text)
					Dim newBalance As Double = custBalance + Convert.ToDouble(Convert.ToDecimal(Me.txtDiff.Text)) -
										   Conversion.Val(Me.txtPaid.Text)

					If newBalance > creditLimit Then
						Interaction.MsgBox("العميل تعدى حد الإئتمان", MsgBoxStyle.OkOnly, Nothing)
						Return False
					End If
				End If
			End If

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function ValidateMinimumPrice() As Boolean
		Try
			If Me.InvProc <> 2 Then Return True

			For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
				Dim currencyId As Object = Me.dgvItems.Rows(i).Cells(9).Value
				Dim unitId As Integer = Me.GetUnitID(Me.dgvItems.Rows(i).Cells(3).Value?.ToString())

				Dim adapter As New SqlDataAdapter(
				$"SELECT minprice FROM currencies WHERE id={currencyId} AND unit={unitId}", Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					Dim minPrice As Double = Conversion.Val($"{dt.Rows(0)(0)}")
					If minPrice <> 0.0 Then
						Dim itemPrice As Double = Conversion.Val($"{Me.dgvItems.Rows(i).Cells(7).Value}")
						If itemPrice < minPrice Then
							Me.dgvItems.Rows(i).Selected = True
							Interaction.MsgBox("لقد أدخلت السعر أقل من المسموح به", MsgBoxStyle.OkOnly, Nothing)
							Return False
						End If
					End If
				End If
			Next

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function ValidateStockQuantity() As Boolean
		Try
			' التحقق من إعداد فحص الكمية
			Dim checkQuantity As Boolean = True
			Dim settingsPath As String = System.Windows.Forms.Application.StartupPath & "\invquan.txt"

			If File.Exists(settingsPath) Then
				Using reader As New StreamReader(settingsPath)
					If reader.ReadLine() = "0" Then
						checkQuantity = False
					End If
				End Using
			End If

			If checkQuantity Then Return True
			If Me.InvProc <> 2 Then Return True
			If Me.cmbProcType.SelectedIndex <> 0 Then Return True

			For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
				' التحقق من نوع الصنف (تخطي الخدمات)
				If IsServiceItem(i) Then Continue For

				Dim currencyId As Integer = Conversions.ToInteger(Me.dgvItems.Rows(i).Cells(9).Value)
				Dim stockBalance As Double = Me.CalcCurrencyStock(currencyId)
				Dim enteredQuantity As Double = Conversion.Val(Me.dgvItems.Rows(i).Cells(5).Value)

				' إضافة الكمية السابقة في حالة التعديل
				Dim previousQuantity As Double = 0
				If Me.ProcCode <> -1 Then
					previousQuantity = GetPreviousQuantity(currencyId)
					stockBalance += previousQuantity
				End If

				If enteredQuantity > stockBalance Then
					ShowStockQuantityError(i, enteredQuantity, stockBalance, previousQuantity)
					Return False
				End If
			Next

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function IsServiceItem(rowIndex As Integer) As Boolean
		Try
			Dim adapter As New SqlDataAdapter(
			$"SELECT type FROM currencies WHERE id={Me.dgvItems.Rows(rowIndex).Cells(9).Value}",
			Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)
			Return dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)(0)) = 4
		Catch ex As Exception
			Return False
		End Try
	End Function

	Private Function GetPreviousQuantity(currencyId As Integer) As Double
		Try
			Dim adapter As New SqlDataAdapter(
			$"SELECT val FROM Inv_Sub WHERE currency_from={currencyId} AND proc_id={Me.ProcCode}",
			Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Return Convert.ToDouble(dt.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
		Return 0
	End Function

	Private Sub ShowStockQuantityError(rowIndex As Integer, enteredQty As Double,
									stockBalance As Double, previousQty As Double)
		Dim message As String
		Dim displayBalance As Double = If(previousQty > 0, stockBalance - previousQty, stockBalance)

		If MainClass.Language = "en" Then
			message = $"quantity is greater than store balance{Environment.NewLine}" &
				  $"total quantity: {enteredQty}{Environment.NewLine}" &
				  $"store balance: {Me.cmbSafe.Text} = {displayBalance}"
		Else
			message = $"الكمية المدخلة للصنف أكبر من رصيد المخزن{Environment.NewLine}" &
				  $"الكمية الاجمالية المدخلة: {enteredQty}{Environment.NewLine}" &
				  $"رصيد المخزن: {Me.cmbSafe.Text} = {displayBalance}"
		End If

		MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		Me.dgvItems.Rows(rowIndex).Selected = True
	End Sub

	Private Function ValidatePaymentInputs() As Boolean
		' التحقق من اختيار البنك
		If Conversion.Val(Me.txtNetwork.Text) <> 0.0 AndAlso Me.cmbBanks.SelectedValue Is Nothing Then
			Interaction.MsgBox("اختر البنك", MsgBoxStyle.OkOnly, Nothing)
			Me.txtNetwork.Focus()
			Return False
		End If

		' التحقق من تطابق المدفوعات
		If (Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) AndAlso
	   Me.cmbType.SelectedIndex = 1 Then

			Dim totalPayment As Double = Math.Round(
			Conversion.Val(Me.txtCash.Text) + Conversion.Val(Me.txtNetwork.Text), 2)
			Dim netAmount As Double = Math.Round(Conversion.Val(Me.txtDiff.Text), 2)

			If totalPayment <> netAmount Then
				Interaction.MsgBox("يجب أن يكون المدفوع نقدي وشبكة يساوي لصافي الفاتورة",
							  MsgBoxStyle.OkOnly, Nothing)
				Me.txtCash.Focus()
				Return False
			End If
		End If

		Return True
	End Function

	Private Function ValidateFoundationName() As Boolean
		Try
			Dim adapter As New SqlDataAdapter(
			"SELECT nameA, nameE, last_name, last_nameE FROM Foundation", Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Dim nameA As String = $"{dt.Rows(0)("nameA")}"
				Dim nameE As String = $"{dt.Rows(0)("nameE")}"
				Dim lastName As String = $"{dt.Rows(0)("last_name")}"
				Dim lastNameE As String = $"{dt.Rows(0)("last_nameE")}"

				If lastName <> nameA OrElse lastNameE <> nameE Then
					MessageBox.Show("تم التلاعب في إسم المؤسسة، يرجى التواصل مع الدعم الفني",
							   "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return False
				End If
			End If

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

#End Region

#Region "دوال معالجة الزكاة والدخل"

	Private Function ProcessZatcaIntegration(ByRef zatcaIntegration As ZatcaIntegration,
										  ByRef isProcessed As Boolean) As Boolean
		Try
			Dim shouldProcess As Boolean = (Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) AndAlso
			Me.InvProc = 2 AndAlso
			((Me.ProcCode = -1 AndAlso Me._ZatcInteg) OrElse Me._IsReAPI)

			If Not shouldProcess Then Return True

			Dim payType As Integer = DeterminePaymentType()
			Dim invType As Integer = If(Me.cmbProcType.SelectedIndex = 1, 5, 1)
			Dim itemsTable As DataTable = PrepareZatcaItemsTable()

			' الحصول على بيانات فاتورة المرتجع الأصلية
			Dim srcInv As Integer = -1
			Dim srcDate As DateTime = Nothing
			GetSourceInvoiceData(srcInv, srcDate)

			Dim netAmount As Double = Convert.ToDouble(Me.txtDiff.Text) +
								  Conversion.Val(Me.txtInvCustDisc.Text) +
								  Conversion.Val(Me.txtRetention.Text)

			Dim success As Boolean = zatcaIntegration.ZatcaIntegration(
			Me.txtNo.Text,
			Me.txtDate.Value,
			invType,
			payType,
			Conversions.ToInteger(Me.cmbClient.SelectedValue),
			Convert.ToDouble(Me.txtTotSale.Text),
			Convert.ToDouble(Me.txtMinusVal.Text),
			Convert.ToDouble(Me.lblTaxVal.Text),
			netAmount,
			itemsTable,
			srcInv,
			srcDate)

			isProcessed = True

			If Not success AndAlso Me._PreventInvZatcFail Then
				MessageBox.Show("فشل الربط مع الزكاة والدخل")
				Return False
			End If

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function DeterminePaymentType() As Integer
		If Me.cmbType.SelectedIndex = 0 Then
			Return 0 ' آجل
		ElseIf Me.rdNetwork.Checked Then
			Return 2 ' شبكة
		Else
			Return 1 ' نقدي
		End If
	End Function

	Private Function PrepareZatcaItemsTable() As DataTable
		Dim dt As New DataTable()
		dt.Columns.Add("name")
		dt.Columns.Add("price")
		dt.Columns.Add("quan")
		dt.Columns.Add("total")
		dt.Columns.Add("disc")
		dt.Columns.Add("totalafterdisc")
		dt.Columns.Add("vatperc")
		dt.Columns.Add("vat")
		dt.Columns.Add("net")

		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			Dim row As DataRow = dt.NewRow()
			row("name") = Me.dgvItems.Rows(i).Cells(2).Value
			row("price") = Me.dgvItems.Rows(i).Cells(7).Value
			row("quan") = Me.dgvItems.Rows(i).Cells(4).Value
			row("total") = Me.dgvItems.Rows(i).Cells(8).Value
			row("disc") = Me.dgvItems.Rows(i).Cells(11).Value
			row("totalafterdisc") = Me.dgvItems.Rows(i).Cells(13).Value
			row("vatperc") = Me.dgvItems.Rows(i).Cells(14).Value
			row("vat") = Me.dgvItems.Rows(i).Cells(15).Value
			row("net") = Me.dgvItems.Rows(i).Cells(16).Value
			dt.Rows.Add(row)
		Next

		Return dt
	End Function

	Private Sub GetSourceInvoiceData(ByRef srcInv As Integer, ByRef srcDate As DateTime)
		Try
			If Me.cmbProcType.SelectedIndex <> 1 Then Return
			If Conversion.Val(Me.txtSrcInvNo.Text) = 0.0 Then Return

			srcInv = CInt(Math.Round(Conversion.Val(Me.txtSrcInvNo.Text)))
			Dim isBuy As Integer = If(Me.InvProc = 2, 0, 1)

			Dim adapter As New SqlDataAdapter(
			$"SELECT date FROM Inv WHERE branch={MainClass.BranchNo} AND IS_Buy={isBuy} " &
			$"AND IS_Deleted=0 AND proc_type=1 AND id={Me.txtSrcInvNo.Text}", Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				srcDate = Convert.ToDateTime(dt.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
	End Sub

#End Region

#Region "دوال قاعدة البيانات"

	Private Function GetAccountCode(accountName As String) As Integer
		Dim adapter As New SqlDataAdapter(
		$"SELECT Code FROM Accounts_Index WHERE type=2 AND AName='{accountName}'", Me.conn)
		Dim dt As New DataTable()
		adapter.Fill(dt)

		If dt.Rows.Count > 0 Then
			Return CInt(Math.Round(Convert.ToDouble($"{dt.Rows(0)(0)}")))
		End If
		Return 0
	End Function

	Private Sub OpenConnectionAndBeginTransaction(ByRef transaction As SqlTransaction)
		If Me.conn.State <> ConnectionState.Open Then
			Me.conn.Open()
		End If
		transaction = Me.conn.BeginTransaction()
	End Sub

	Private Sub DetermineRestrictionCodes(transaction As SqlTransaction,
									   ByRef purchCode As Integer,
									   ByRef saleCode As Integer)
		InitializeTextFields()

		If Not (Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) Then Return

		Dim branchFilter As String = If(MainClass.BranchNo <> -1,
		$" WHERE branch={MainClass.BranchNo}", "")

		If Me.ProcCode = -1 AndAlso Not Me.chkHold.Checked Then
			' فاتورة جديدة
			If Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
				purchCode = GetNextRestrictionId(transaction, branchFilter)
			End If

			If Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
				saleCode = If(purchCode <> 0, purchCode + 1,
				GetNextRestrictionId(transaction, branchFilter))
			End If
		Else
			' تعديل فاتورة موجودة
			purchCode = Me.RestPurchCode
			saleCode = Me.RestSaleCode

			DeleteExistingRestrictions(transaction, purchCode, saleCode)

			If Not Me.chkHold.Checked Then
				If purchCode = 0 AndAlso Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
					purchCode = GetNextRestrictionId(transaction, branchFilter)
				End If
				If saleCode = 0 AndAlso Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
					saleCode = GetNextRestrictionId(transaction, branchFilter)
				End If
			Else
				purchCode = 0
				saleCode = 0
			End If
		End If
	End Sub

	Private Sub InitializeTextFields()
		If Me.txtTotPurch.Text = "" Then Me.txtTotPurch.Text = "0"
		If Me.txtTotSale.Text = "" Then Me.txtTotSale.Text = "0"
		If Me.txtDiff.Text = "" Then Me.txtDiff.Text = "0"
		If Me.txtPaid.Text = "" Then Me.txtPaid.Text = "0"
	End Sub

	Private Function GetNextRestrictionId(transaction As SqlTransaction, filter As String) As Integer
		Dim cmd As New SqlCommand($"SELECT MAX(id) FROM Restrictions {filter}", Me.conn, transaction)
		Return CInt(Math.Round(Conversion.Val($"{cmd.ExecuteScalar()}") + 1.0))
	End Function

	Private Sub DeleteExistingRestrictions(transaction As SqlTransaction,
										purchCode As Integer, saleCode As Integer)
		Dim commands() As String = {
		$"DELETE FROM Restrictions WHERE branch={MainClass.BranchNo} AND id={purchCode}",
		$"DELETE FROM Restrictions WHERE branch={MainClass.BranchNo} AND id={saleCode}",
		$"DELETE FROM Restrictions_Sub WHERE branch={MainClass.BranchNo} AND res_id={purchCode}",
		$"DELETE FROM Restrictions_Sub WHERE branch={MainClass.BranchNo} AND res_id={saleCode}"
	}

		For Each sql As String In commands
			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Next
	End Sub

	Private Function GetReferenceNumber() As String
		Dim refNo As String = $"{Me.Code}"
		If Me.txtRefNo.Text.Trim() <> "" Then
			refNo = Me.txtRefNo.Text
		End If
		Return refNo
	End Function

	Private Function GetCenterCode() As Integer
		If Me.cmbCenter.SelectedValue IsNot Nothing Then
			Return Convert.ToInt32(Me.cmbCenter.SelectedValue)
		End If
		Return -1
	End Function

#End Region

#Region "دوال حفظ الفاتورة"

	Private Sub SaveMainInvoice(transaction As SqlTransaction,
							purchRestCode As Integer, saleRestCode As Integer)
		Dim isBuy As Integer = If(Me.InvProc = 2, 0, 1)
		Dim cmd As SqlCommand

		If Me.ProcCode = -1 Then
			Dim spName As String = If(Me.cmbProcType.SelectedIndex <> 1, "InsertInv", "InsertInvRet")
			cmd = New SqlCommand(spName, Me.conn, transaction)
			Me.LoadInvNo()
			Me.Code = CInt(Math.Round(Convert.ToDouble(Me.txtNo.Text)))
		Else
			Dim spName As String = If(Me.cmbProcType.SelectedIndex <> 1, "UpdateInv", "UpdateInvRet")
			cmd = New SqlCommand(spName, Me.conn, transaction)
		End If

		cmd.CommandType = CommandType.StoredProcedure
		AddInvoiceParameters(cmd, purchRestCode, saleRestCode, isBuy)
		cmd.ExecuteNonQuery()
	End Sub

	Private Sub AddInvoiceParameters(cmd As SqlCommand, purchRestCode As Integer,
								  saleRestCode As Integer, isBuy As Integer)
		If Me.ProcCode <> -1 Then
			cmd.Parameters.Add("@proc_id", SqlDbType.Int).Value = Me.ProcCode
		End If

		cmd.Parameters.Add("@proc_type", SqlDbType.Int).Value = Me.cmbProcType.SelectedIndex + 1
		cmd.Parameters.Add("@id", SqlDbType.Int).Value = Me.Code
		cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
		cmd.Parameters.Add("@inv_type", SqlDbType.Int).Value = Me.cmbType.SelectedIndex + 1
		cmd.Parameters.Add("@safe", SqlDbType.Int).Value = Me.cmbSafe.SelectedValue
		cmd.Parameters.Add("@stock", SqlDbType.Int).Value = Me.cmbStock.SelectedValue
		cmd.Parameters.Add("@cust_id", SqlDbType.Int).Value = Me.cmbClient.SelectedValue
		cmd.Parameters.Add("@sales_emp", SqlDbType.Int).Value = MainClass.EmpNo
		cmd.Parameters.Add("@tot_purch", SqlDbType.Float).Value = Me.txtTotPurch.Text
		cmd.Parameters.Add("@tot_sale", SqlDbType.Float).Value = Me.txtTotSale.Text
		cmd.Parameters.Add("@tot_net", SqlDbType.Float).Value = Convert.ToDouble(Me.txtDiff.Text)
		cmd.Parameters.Add("@paid", SqlDbType.Float).Value = Convert.ToDouble(Me.txtPaid.Text)
		cmd.Parameters.Add("@minus", SqlDbType.Float).Value = Conversion.Val(Me.txtMinusVal.Text)
		cmd.Parameters.Add("@tax", SqlDbType.Float).Value = Conversion.Val(Me.txtTax.Text)
		cmd.Parameters.Add("@purch_rest_id", SqlDbType.Int).Value = purchRestCode
		cmd.Parameters.Add("@sale_rest_id", SqlDbType.Int).Value = saleRestCode

		If Me.cmbProcType.SelectedIndex = 1 Then
			cmd.Parameters.Add("@InvId_Return", SqlDbType.Int).Value = Conversion.Val(Me.txtSrcInvNo.Text)
		End If

		cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
		cmd.Parameters.Add("@IS_Buy", SqlDbType.Bit).Value = isBuy
		cmd.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0

		' مندوب المبيعات
		Dim salesmanId As Integer = If(Me.cmbSalesMen.SelectedValue IsNot Nothing,
		Conversions.ToInteger(Me.cmbSalesMen.SelectedValue), -1)
		cmd.Parameters.Add("@salesman", SqlDbType.Int).Value = salesmanId

		' نوع الدفع
		Dim payType As Integer = -1
		If Me.cmbType.SelectedIndex = 1 Then
			payType = If(Me.rdCash.Checked, 1, 2)
		End If
		cmd.Parameters.Add("@pay_type", SqlDbType.Int).Value = payType

		' البنك
		Dim bankId As Integer = -1
		Try
			If Me.cmbType.SelectedIndex = 1 AndAlso Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
				bankId = Conversions.ToInteger(Me.cmbBanks.SelectedValue)
			End If
		Catch ex As Exception
		End Try
		cmd.Parameters.Add("@bank", SqlDbType.Int).Value = bankId
	End Sub

	Private Sub UpdateInvoiceData(transaction As SqlTransaction,
							   zatcaIntegration As ZatcaIntegration,
							   isZatcaProcessed As Boolean,
							   ByRef isExisting As Boolean)
		' حذف التفاصيل القديمة وتحديد كود الفاتورة
		If Me.ProcCode <> -1 Then
			Dim cmd As New SqlCommand($"DELETE FROM Inv_Sub WHERE proc_id={Me.ProcCode}",
								  Me.conn, transaction)
			cmd.ExecuteNonQuery()
			isExisting = True
		Else
			Dim cmd As New SqlCommand("SELECT MAX(proc_id) FROM Inv", Me.conn, transaction)
			Me.ProcCode = CInt(Math.Round(Convert.ToDouble($"{cmd.ExecuteScalar()}")))
		End If

		' تحديث بيانات الزكاة
		UpdateZatcaData(transaction, zatcaIntegration, isZatcaProcessed)

		' تحديث خصم العميل
		UpdateCustomerDiscount(transaction)

		' تحديث أكواد القيود
		UpdateRestrictionCodes(transaction, isExisting)

		' تحديث بيانات إضافية متنوعة
		UpdateDebtNote(transaction)
		UpdateNotes(transaction)
		UpdateDeliveryDate(transaction)
		UpdateReservationData(transaction)
		UpdateManufacturingFlag(transaction)
		UpdateSupplierData(transaction)
		UpdatePurchaseOrderData(transaction)
		UpdateMaintenanceData(transaction)
		UpdatePaymentParts(transaction)
		UpdateCostCenter(transaction)
		UpdateRetention(transaction)
		UpdateHoldStatus(transaction)
		UpdateChargeData(transaction)
		UpdateCustomerName(transaction)
		UpdateAccountCode(transaction)
		UpdatePoNumber(transaction)
	End Sub

	Private Sub UpdateZatcaData(transaction As SqlTransaction,
							zatcaIntegration As ZatcaIntegration,
							isProcessed As Boolean)
		Try
			If Not isProcessed Then Return

			Dim sql As String = $"UPDATE Inv SET InvoiceHash=@InvoiceHash, EncodedInvoice=@EncodedInvoice, " &
			$"UUID=@UUID, qr=@qr, status_code=@status_code, war_msg=@war_msg, " &
			$"err_msg=@err_msg, is_zatc_done=1 WHERE proc_id={Me.ProcCode}"

			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
			cmd.Parameters.Add("@InvoiceHash", SqlDbType.NVarChar).Value = zatcaIntegration.res.InvoiceHash
			cmd.Parameters.Add("@EncodedInvoice", SqlDbType.NVarChar).Value = zatcaIntegration.res.EncodedInvoice
			cmd.Parameters.Add("@UUID", SqlDbType.NVarChar).Value = zatcaIntegration.res.UUID
			cmd.Parameters.Add("@qr", SqlDbType.NVarChar).Value = zatcaIntegration.strQR
			cmd.Parameters.Add("@status_code", SqlDbType.NVarChar).Value = zatcaIntegration.StatusCode
			cmd.Parameters.Add("@war_msg", SqlDbType.NVarChar).Value = zatcaIntegration.warningmsg
			cmd.Parameters.Add("@err_msg", SqlDbType.NVarChar).Value = zatcaIntegration.errmsg
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateCustomerDiscount(transaction As SqlTransaction)
		Try
			If Conversion.Val(Me.txtInvCustDisc.Text) = 0.0 Then Return

			Dim discountAdd As Double = 0.0
			Dim adapter As New SqlDataAdapter("SELECT CustDisc FROM Foundation WHERE id=1", Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Dim custDiscPerc As Double = Conversion.Val($"{dt.Rows(0)(0)}")
				If custDiscPerc <> 0.0 Then
					discountAdd = custDiscPerc / 100.0 * Conversion.Val(Me.txtDiff.Text)
				End If
			End If

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET cust_disc={Conversion.Val(Me.txtInvCustDisc.Text)}, " &
			$"custdiscadd={discountAdd} WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateRestrictionCodes(transaction As SqlTransaction, isExisting As Boolean)
		Try
			If Not isExisting Then Return

			Dim cmd As SqlCommand
			If Me.InvProc = 1 Then
				cmd = New SqlCommand(
				$"UPDATE inv SET purch_rest_id={Me.RestPurchCode} WHERE proc_id={Me.ProcCode}",
				Me.conn, transaction)
			ElseIf Me.InvProc = 2 Then
				cmd = New SqlCommand(
				$"UPDATE inv SET sale_rest_id={Me.RestSaleCode} WHERE proc_id={Me.ProcCode}",
				Me.conn, transaction)
			Else
				Return
			End If
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateDebtNote(transaction As SqlTransaction)
		Try
			If Not (Me.cmbProcType.SelectedIndex = 0 AndAlso Me.InvProc = 2 AndAlso Me.chkDebtNote.Checked) Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET is_debtnote=1, debtnote_id='{Me.txtDebtNoteInvNo.Text}' " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateNotes(transaction As SqlTransaction)
		Try
			Dim cmd As New SqlCommand(
			$"UPDATE inv SET notes='{Me.TextBox1.Text}' WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateDeliveryDate(transaction As SqlTransaction)
		Try
			If Me.txtTwreedDate.Text.Trim() = "" Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET twreed_date='{Me.txtTwreedDate.Text}' WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateReservationData(transaction As SqlTransaction)
		Try
			If Me.cmbProcType.SelectedIndex <> 3 Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET reserv_custname='{Me.txtCustNote.Text}', " &
			$"reserv_custtel='{Me.txtCustTel.Text}', reserv_custadd='{Me.txtCustAddress.Text}' " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateManufacturingFlag(transaction As SqlTransaction)
		Try
			If Not Me.IS_manfc Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET is_manfc=1 WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateSupplierData(transaction As SqlTransaction)
		Try
			Dim supplierId As Integer = If(Me.cmbErsSuppliers.SelectedValue IsNot Nothing,
			Conversions.ToInteger(Me.cmbErsSuppliers.SelectedValue), -1)

			Dim sql As String = $"UPDATE inv SET ers_supp={supplierId}, " &
			$"ers_no={Conversion.Val(Me.txtErsNo.Text)}, refno='{Me.txtRefNo.Text}', " &
			$"project_name='{Me.txtProjectName.Text}', inv_period={Me.txtInvoicePeriod.Value}, " &
			"period_date1=@period_date1, period_date2=@period_date2, due_date=@due_date " &
			$"WHERE proc_id={Me.ProcCode}"

			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
			cmd.Parameters.Add("@period_date1", SqlDbType.DateTime).Value = Me.txtPeriodDate1.Value.ToShortDateString()
			cmd.Parameters.Add("@period_date2", SqlDbType.DateTime).Value = Me.txtPeriodDate2.Value.ToShortDateString()
			cmd.Parameters.Add("@due_date", SqlDbType.DateTime).Value = Me.txtDueDate.Value.ToShortDateString()
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdatePurchaseOrderData(transaction As SqlTransaction)
		Try
			If Not (Me.cmbProcType.SelectedIndex = 4 AndAlso Me.pnlPurchOrder.Visible) Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET payment_terms='{Me.txtPaymentTerms.Text}', " &
			$"reference_no='{Me.txtReferenceNo.Text}', hire_period='{Me.txtHirePeriod.Text}' " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateMaintenanceData(transaction As SqlTransaction)
		Try
			Dim isMaint As Integer = 0
			Dim maintInvId As Integer = 0

			If Me.chkMaintainance.Checked Then
				isMaint = 1
				maintInvId = CInt(Math.Round(Conversion.Val(Me.txtMaintInvId.Text)))
			End If

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET is_maint={isMaint}, maint_inv_id={maintInvId} " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdatePaymentParts(transaction As SqlTransaction)
		Try
			Dim cmd As New SqlCommand(
			$"UPDATE inv SET cash_part={Conversion.Val(Me.txtCash.Text)}, " &
			$"network_part={Conversion.Val(Me.txtNetwork.Text)} WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateCostCenter(transaction As SqlTransaction)
		Try
			Dim centerId As Integer = If(Me.cmbCenter.SelectedValue IsNot Nothing,
			Conversions.ToInteger(Me.cmbCenter.SelectedValue), -1)

			Dim cmd As New SqlCommand(
			$"UPDATE Inv SET center={centerId} WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateRetention(transaction As SqlTransaction)
		Try
			Dim cmd As New SqlCommand(
			$"UPDATE Inv SET retention={Conversion.Val(Me.txtRetention.Text)} " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateHoldStatus(transaction As SqlTransaction)
		Try
			Dim isHold As Integer = If(Me.chkHold.Checked, 1, 0)

			Dim cmd As New SqlCommand(
			$"UPDATE Inv SET is_hold={isHold} WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateChargeData(transaction As SqlTransaction)
		Dim frmChargeData As New frmChargeData()
		Try
			Dim sql As String = "UPDATE Inv SET rec_no=@rec_no, rec_date=@rec_date, " &
			"rec_purchno=@rec_purchno, rec_saleno=@rec_saleno, rec_chargetype=@rec_chargetype, " &
			"rec_custloc=@rec_custloc, rec_custlocadd=@rec_custlocadd, rec_resptel=@rec_resptel, " &
			"rec_custvatno=@rec_custvatno, rec_car=@rec_car, rec_carno=@rec_carno, " &
			"rec_chargetime=@rec_chargetime, rec_chargeacc=@rec_chargeacc, rec_driver=@rec_driver " &
			$"WHERE proc_id={Me.ProcCode}"

			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
			cmd.Parameters.Add("@rec_no", SqlDbType.NVarChar).Value = frmChargeData.txtRecNo.Text
			cmd.Parameters.Add("@rec_date", SqlDbType.DateTime).Value = frmChargeData.txtRecDate.Value.ToShortDateString()
			cmd.Parameters.Add("@rec_purchno", SqlDbType.NVarChar).Value = frmChargeData.txtRecPurchOrderNo.Text
			cmd.Parameters.Add("@rec_saleno", SqlDbType.NVarChar).Value = frmChargeData.txtRecSaleOrderNo.Text
			cmd.Parameters.Add("@rec_chargetype", SqlDbType.NVarChar).Value = frmChargeData.txtRecChargeType.Text
			cmd.Parameters.Add("@rec_custloc", SqlDbType.NVarChar).Value = frmChargeData.txtRecCustLoc.Text
			cmd.Parameters.Add("@rec_custlocadd", SqlDbType.NVarChar).Value = frmChargeData.txtRecCustLocAddress.Text
			cmd.Parameters.Add("@rec_resptel", SqlDbType.NVarChar).Value = frmChargeData.txtRecRespTel.Text
			cmd.Parameters.Add("@rec_custvatno", SqlDbType.NVarChar).Value = frmChargeData.txtRecCustVatNo.Text
			cmd.Parameters.Add("@rec_car", SqlDbType.NVarChar).Value = frmChargeData.txtRecCar.Text
			cmd.Parameters.Add("@rec_carno", SqlDbType.NVarChar).Value = frmChargeData.txtRecCarNo.Text
			cmd.Parameters.Add("@rec_chargetime", SqlDbType.NVarChar).Value = frmChargeData.txtRecChargeTime.Text
			cmd.Parameters.Add("@rec_chargeacc", SqlDbType.NVarChar).Value = frmChargeData.txtRecChargeAcc.Text
			cmd.Parameters.Add("@rec_driver", SqlDbType.NVarChar).Value = frmChargeData.txtRecDriver.Text
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateCustomerName(transaction As SqlTransaction)
		Try
			If Me.InvProc <> 2 Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE Inv SET cust_name='{Me.txtCustName.Text.Trim()}' " &
			$"WHERE proc_id={Me.ProcCode}", Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateAccountCode(transaction As SqlTransaction)
		Try
			If Not ((Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) AndAlso
				Me.InvProc = 1 AndAlso Me.cmbAcc.SelectedValue IsNot Nothing) Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE Inv SET acc={Me.cmbAcc.SelectedValue} WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdatePoNumber(transaction As SqlTransaction)
		Try
			If Not (Me._IsPoNo AndAlso Me.txtPoNo.Text.Trim() <> "") Then Return

			Dim cmd As New SqlCommand(
			$"UPDATE inv SET pono='{Me.txtPoNo.Text.Trim()}' WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

#End Region

#Region "دوال حفظ تفاصيل الفاتورة"

	Private Sub SaveInvoiceDetails(transaction As SqlTransaction)
		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			SaveInvoiceDetailRow(transaction, i)
		Next
	End Sub

	Private Sub SaveInvoiceDetailRow(transaction As SqlTransaction, rowIndex As Integer)
		Dim sql As String = "INSERT INTO Inv_Sub(proc_id, proc_type, currency_from, unit, val, val1, " &
		"exchange_price, discount, taxperc, taxval, notes, expire_date, operate_no) " &
		"VALUES(@proc_id, @proc_type, @currency_from, @unit, @val, @val1, " &
		"@exchange_price, @discount, @taxperc, @taxval, @notes, @expire_date, @operate_no)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)

		cmd.Parameters.Add("@proc_id", SqlDbType.Int).Value = Me.ProcCode

		' نوع العملية
		Dim cell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(rowIndex).Cells(1), DataGridViewComboBoxCell)
		cmd.Parameters.Add("@proc_type", SqlDbType.Int).Value = If(cell.Value?.ToString() = "شراء", 1, 2)

		cmd.Parameters.Add("@currency_from", SqlDbType.Int).Value = Me.dgvItems.Rows(rowIndex).Cells(9).Value
		cmd.Parameters.Add("@unit", SqlDbType.Int).Value = GetUnitID($"{Me.dgvItems.Rows(rowIndex).Cells(3).Value}")
		cmd.Parameters.Add("@val", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(5).Value
		cmd.Parameters.Add("@val1", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(4).Value
		cmd.Parameters.Add("@exchange_price", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(7).Value
		cmd.Parameters.Add("@discount", SqlDbType.Float).Value = Conversion.Val($"{Me.dgvItems.Rows(rowIndex).Cells(11).Value}")
		cmd.Parameters.Add("@taxperc", SqlDbType.Float).Value = Conversion.Val($"{Me.dgvItems.Rows(rowIndex).Cells(14).Value}")
		cmd.Parameters.Add("@taxval", SqlDbType.Float).Value = Conversion.Val($"{Me.dgvItems.Rows(rowIndex).Cells(15).Value}")
		cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = $"{Me.dgvItems.Rows(rowIndex).Cells(18).Value}"

		' تاريخ الصلاحية
		Try
			If (Me.InvProc = 1 OrElse Me.InvProc = 3) AndAlso Me._showPurchExpire Then
				cmd.Parameters.Add("@expire_date", SqlDbType.DateTime).Value =
				Convert.ToDateTime(Me.dgvItems.Rows(rowIndex).Cells(10).Value)
			ElseIf Me.InvProc = 2 AndAlso Me._showSalesExpire Then
				cmd.Parameters.Add("@expire_date", SqlDbType.DateTime).Value =
				Convert.ToDateTime(Me.dgvItems.Rows(rowIndex).Cells(10).Value)
			Else
				cmd.Parameters.Add("@expire_date", SqlDbType.DateTime).Value = DBNull.Value
			End If
		Catch ex As Exception
			cmd.Parameters.Add("@expire_date", SqlDbType.DateTime).Value = DBNull.Value
		End Try

		cmd.Parameters.Add("@operate_no", SqlDbType.NVarChar).Value =
		$"{Me.dgvItems.Rows(rowIndex).Cells("colOperateNo").Value}"

		cmd.ExecuteNonQuery()
	End Sub

#End Region

#Region "دوال القيود المحاسبية"

	Private Sub SaveAccountingRestrictions(transaction As SqlTransaction,
										clientAccountCode As Integer,
										stockAccountCode As Integer,
										purchRestCode As Integer,
										saleRestCode As Integer,
										centerCode As Integer,
										refNo As String)
		If Me.chkHold.Checked Then Return

		Dim custDiscAccount As Integer = If(MainClass.IsAccTreeNew, 31010004, 4110008)

		Select Case Me.cmbProcType.SelectedIndex
			Case 0 ' فاتورة عادية
				SaveNormalInvoiceRestrictions(transaction, clientAccountCode, stockAccountCode,
										  purchRestCode, saleRestCode, centerCode, refNo, custDiscAccount)
			Case 1 ' فاتورة مرتجع
				SaveReturnInvoiceRestrictions(transaction, clientAccountCode, stockAccountCode,
										  purchRestCode, saleRestCode, centerCode, refNo, custDiscAccount)
			Case 2 ' مخزون أول المدة
				SaveOpeningStockRestrictions(transaction, purchRestCode, refNo)
		End Select
	End Sub

	Private Sub SaveNormalInvoiceRestrictions(transaction As SqlTransaction,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer,
										   purchRestCode As Integer,
										   saleRestCode As Integer,
										   centerCode As Integer,
										   refNo As String,
										   custDiscAccount As Integer)
		' قيود الشراء
		If Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
			SavePurchaseRestriction(transaction, purchRestCode, clientAccountCode,
							   stockAccountCode, centerCode, refNo)
		End If

		' قيود البيع
		If Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
			SaveSaleRestriction(transaction, saleRestCode, clientAccountCode,
						   stockAccountCode, centerCode, refNo, custDiscAccount)
		End If
	End Sub

	Private Sub SavePurchaseRestriction(transaction As SqlTransaction,
									 restCode As Integer,
									 clientAccountCode As Integer,
									 stockAccountCode As Integer,
									 centerCode As Integer,
									 refNo As String)
		Dim notes As String = $"فاتورة شراء {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة شراء{Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

		' إدخال القيد الرئيسي
		InsertRestriction(transaction, restCode, 1, notes, refNo)

		' حساب المشتريات
		Dim purchaseAccount As Integer = If(MainClass.IsAccTreeNew, 31010001, 3410001)
		Try
			If Me.cmbAcc.SelectedValue IsNot Nothing Then
				purchaseAccount = Conversions.ToInteger(Me.cmbAcc.SelectedValue)
			End If
		Catch ex As Exception
		End Try

		' المشتريات - مدين
		InsertRestrictionSubWithCenter(transaction, restCode,
		Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text), 0,
		purchaseAccount, notes, centerCode)

		' ضريبة القيمة المضافة - مدين
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 1103040001, 3410005)
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.lblTaxVal.Text), 0, vatAccount, taxNotes)

		' المورد - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)

			If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode, 0,
				Conversion.Val(Me.txtCash.Text), stockAccountCode, notes)
			End If

			If Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode, 0,
				Conversion.Val(Me.txtNetwork.Text),
				Conversions.ToInteger(Me.cmbBanks.SelectedValue), notes)
			End If
		End If
	End Sub

	Private Sub SaveSaleRestriction(transaction As SqlTransaction,
								 restCode As Integer,
								 clientAccountCode As Integer,
								 stockAccountCode As Integer,
								 centerCode As Integer,
								 refNo As String,
								 custDiscAccount As Integer)
		Dim notes As String = $"فاتورة بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

		' إدخال القيد الرئيسي
		InsertRestriction(transaction, restCode, 2, notes, refNo)

		' العميل - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)

		' المبيعات - دائن
		Dim salesAccount As Integer = If(MainClass.IsAccTreeNew, 41010001, 4110001)
		Dim salesAmount As Double = Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text) +
								Conversion.Val(Me.txtInvCustDisc.Text) + Conversion.Val(Me.txtRetention.Text)
		InsertRestrictionSubWithCenter(transaction, restCode, 0, salesAmount, salesAccount, notes, centerCode)

		' ضريبة القيمة المضافة - دائن
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 2100120001, 4110005)
		InsertRestrictionSub(transaction, restCode, 0,
		Conversion.Val(Me.lblTaxVal.Text), vatAccount, taxNotes)

		' خصم العميل - مدين
		If Conversion.Val(Me.txtInvCustDisc.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode,
			Conversion.Val(Me.txtInvCustDisc.Text), 0, custDiscAccount,
			$"خصم عميل فاتورة بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' الاستبقاء - مدين
		If Conversion.Val(Me.txtRetention.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode,
			Conversion.Val(Me.txtRetention.Text), 0, clientAccountCode,
			$"{Me.lblRetention.Text} فاتورة بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode,
				Conversion.Val(Me.txtCash.Text), 0, stockAccountCode, notes)
			End If

			If Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode,
				Conversion.Val(Me.txtNetwork.Text), 0,
				Conversions.ToInteger(Me.cmbBanks.SelectedValue), notes)
			End If

			InsertRestrictionSub(transaction, restCode, 0,
			Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)
		End If
	End Sub

	Private Sub SaveReturnInvoiceRestrictions(transaction As SqlTransaction,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer,
										   purchRestCode As Integer,
										   saleRestCode As Integer,
										   centerCode As Integer,
										   refNo As String,
										   custDiscAccount As Integer)
		' قيود مرتجع الشراء
		If Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
			SavePurchaseReturnRestriction(transaction, purchRestCode, clientAccountCode,
									  stockAccountCode, centerCode, refNo)
		End If

		' قيود مرتجع البيع
		If Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
			SaveSaleReturnRestriction(transaction, saleRestCode, clientAccountCode,
								  stockAccountCode, centerCode, refNo, custDiscAccount)
		End If
	End Sub

	Private Sub SavePurchaseReturnRestriction(transaction As SqlTransaction,
										   restCode As Integer,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer,
										   centerCode As Integer,
										   refNo As String)
		Dim notes As String = $"فاتورة مرتد شراء {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة مرتد شراء {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

		InsertRestriction(transaction, restCode, 3, notes, refNo)

		' مرتجعات المشتريات - دائن
		Dim returnAccount As Integer = If(MainClass.IsAccTreeNew, 41010002, 3410002)
		InsertRestrictionSubWithCenter(transaction, restCode, 0,
		Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text),
		returnAccount, notes, centerCode)

		' ضريبة القيمة المضافة - دائن
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 1103040001, 3410005)
		InsertRestrictionSub(transaction, restCode, 0,
		Conversion.Val(Me.lblTaxVal.Text), vatAccount, taxNotes)

		' المورد - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			InsertRestrictionSub(transaction, restCode, 0,
			Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)

			If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode,
				Conversion.Val(Me.txtCash.Text), 0, stockAccountCode, notes)
			End If

			If Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode,
				Conversion.Val(Me.txtNetwork.Text), 0,
				Conversions.ToInteger(Me.cmbBanks.SelectedValue), notes)
			End If
		End If
	End Sub

	Private Sub SaveSaleReturnRestriction(transaction As SqlTransaction,
									   restCode As Integer,
									   clientAccountCode As Integer,
									   stockAccountCode As Integer,
									   centerCode As Integer,
									   refNo As String,
									   custDiscAccount As Integer)
		Dim notes As String = $"فاتورة مرتد بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة مرتد بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

		InsertRestriction(transaction, restCode, 4, notes, refNo)

		' العميل - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)

		' مرتجعات المبيعات - مدين
		Dim returnAccount As Integer = If(MainClass.IsAccTreeNew, 31010003, 4110003)
		Dim returnAmount As Double = Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text) +
								 Conversion.Val(Me.txtInvCustDisc.Text) + Conversion.Val(Me.txtRetention.Text)
		InsertRestrictionSubWithCenter(transaction, restCode, returnAmount, 0, returnAccount, notes, centerCode)

		' ضريبة القيمة المضافة - مدين
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 2100120001, 4110005)
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.lblTaxVal.Text), 0, vatAccount, taxNotes)

		' خصم العميل - دائن
		If Conversion.Val(Me.txtInvCustDisc.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode, 0,
			Conversion.Val(Me.txtInvCustDisc.Text), custDiscAccount,
			$"خصم عميل فاتورة مرتد بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' الاستبقاء - دائن
		If Conversion.Val(Me.txtRetention.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode, 0,
			Conversion.Val(Me.txtRetention.Text), clientAccountCode,
			$"{Me.lblRetention.Text} فاتورة مرتد بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode, 0,
				Conversion.Val(Me.txtCash.Text), stockAccountCode, notes)
			End If

			If Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
				InsertRestrictionSub(transaction, restCode, 0,
				Conversion.Val(Me.txtNetwork.Text),
				Conversions.ToInteger(Me.cmbBanks.SelectedValue), notes)
			End If

			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)
		End If
	End Sub

	Private Sub SaveOpeningStockRestrictions(transaction As SqlTransaction,
										  restCode As Integer, refNo As String)
		Dim notes As String = "مخزون أول المدة "

		Dim stockAccount As Integer = If(MainClass.IsAccTreeNew, 1103030001, 1270001)
		Dim equityAccount As Integer = If(MainClass.IsAccTreeNew, 210020001, 2120001)

		InsertRestriction(transaction, restCode, 9, notes, refNo)

		' رأس المال - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), equityAccount, notes)

		' المخزون - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, stockAccount, notes)
	End Sub

	Private Sub InsertRestriction(transaction As SqlTransaction,
							   id As Integer,
							   type As Integer,
							   notes As String,
							   refNo As String)
		Dim sql As String = "INSERT INTO Restrictions(id, date, doc_no, type, state, notes, branch, IS_Deleted, refno) " &
						"VALUES(@id, @date, @doc_no, @type, @state, @notes, @branch, @IS_Deleted, @refno)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)
		cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
		cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
		cmd.Parameters.Add("@doc_no", SqlDbType.Int).Value = Me.Code
		cmd.Parameters.Add("@type", SqlDbType.Int).Value = type
		cmd.Parameters.Add("@state", SqlDbType.Int).Value = 1
		cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
		cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
		cmd.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
		cmd.Parameters.Add("@refno", SqlDbType.NVarChar).Value = Me.txtRefNo.Text
		cmd.ExecuteNonQuery()
	End Sub

	Private Sub InsertRestrictionSub(transaction As SqlTransaction,
								  resId As Integer,
								  debit As Double,
								  credit As Double,
								  accountNo As Integer,
								  notes As String)
		Dim sql As String = "INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch) " &
						"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)
		cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = resId
		cmd.Parameters.Add("@dept", SqlDbType.Float).Value = debit
		cmd.Parameters.Add("@credit", SqlDbType.Float).Value = credit
		cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = accountNo
		cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
		cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
		cmd.ExecuteNonQuery()
	End Sub

	Private Sub InsertRestrictionSubWithCenter(transaction As SqlTransaction,
											resId As Integer,
											debit As Double,
											credit As Double,
											accountNo As Integer,
											notes As String,
											centerCode As Integer)
		Dim sql As String = "INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch, center) " &
						"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch, @center)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)
		cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = resId
		cmd.Parameters.Add("@dept", SqlDbType.Float).Value = debit
		cmd.Parameters.Add("@credit", SqlDbType.Float).Value = credit
		cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = accountNo
		cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
		cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
		cmd.Parameters.Add("@center", SqlDbType.Int).Value = centerCode
		cmd.ExecuteNonQuery()
	End Sub

#End Region

#Region "دوال ما بعد الحفظ"

	Private Sub ProcessPostSaveOperations(isExisting As Boolean,
									   saleRestCode As Integer,
									   purchRestCode As Integer,
									   clientAccountCode As Integer,
									   stockAccountCode As Integer,
									   refNo As String)
		Me.dgvSrch.Rows.Clear()
		Me.SendSMS()

		' إضافة قيود المدفوعات للفواتير الآجلة الجديدة
		SaveAdvancePaymentRestrictions(isExisting, saleRestCode, purchRestCode,
								   clientAccountCode, stockAccountCode, refNo)

		' تحديث رصيد خصم العميل
		UpdateCustomerDiscountBalance()

		' إرسال إلى شاشة العرض
		SendToCustomerDisplay()

		' عرض نافذة الإيصال
		ShowReceiptPopup()

		' مسح النموذج
		Me.CLR()
		Me.txtBarcode.Focus()
		Me.txtMinusPerc.Text = "0"
	End Sub

	Private Sub SaveAdvancePaymentRestrictions(isExisting As Boolean,
											saleRestCode As Integer,
											purchRestCode As Integer,
											clientAccountCode As Integer,
											stockAccountCode As Integer,
											refNo As String)
		Try
			If isExisting Then Return
			If Me.cmbType.SelectedIndex <> 0 Then Return
			If Conversion.Val(Me.txtPaid.Text) = 0.0 Then Return

			' فتح اتصال جديد للقيود الإضافية
			If Me.conn.State <> ConnectionState.Open Then
				Me.conn.Open()
			End If

			Dim notes As String

			If Me.InvProc = 2 Then
				' فاتورة بيع آجلة مع دفعة مقدمة
				notes = $"فاتورة بيع {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

				' الخزنة - مدين
				Using cmd As New SqlCommand(
				"INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch) " &
				"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch)", Me.conn)
					cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = saleRestCode
					cmd.Parameters.Add("@dept", SqlDbType.Float).Value = Conversion.Val(Me.txtPaid.Text)
					cmd.Parameters.Add("@credit", SqlDbType.Float).Value = 0
					cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = stockAccountCode
					cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
					cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					cmd.ExecuteNonQuery()
				End Using

				' العميل - دائن
				Using cmd As New SqlCommand(
				"INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch) " &
				"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch)", Me.conn)
					cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = saleRestCode
					cmd.Parameters.Add("@dept", SqlDbType.Float).Value = 0
					cmd.Parameters.Add("@credit", SqlDbType.Float).Value = Conversion.Val(Me.txtPaid.Text)
					cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = clientAccountCode
					cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
					cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					cmd.ExecuteNonQuery()
				End Using

			ElseIf Me.InvProc = 1 Then
				' فاتورة شراء آجلة مع دفعة مقدمة
				notes = $"فاتورة شراء {Me.cmbType.Text} رقم:{refNo} خاصة العميل:{Me.cmbClient.Text}"

				' الخزنة - دائن
				Using cmd As New SqlCommand(
				"INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch) " &
				"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch)", Me.conn)
					cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = purchRestCode
					cmd.Parameters.Add("@dept", SqlDbType.Float).Value = 0
					cmd.Parameters.Add("@credit", SqlDbType.Float).Value = Conversion.Val(Me.txtPaid.Text)
					cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = stockAccountCode
					cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
					cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					cmd.ExecuteNonQuery()
				End Using

				' المورد - مدين
				Using cmd As New SqlCommand(
				"INSERT INTO Restrictions_Sub(res_id, dept, credit, acc_no, notes, branch) " &
				"VALUES(@res_id, @dept, @credit, @acc_no, @notes, @branch)", Me.conn)
					cmd.Parameters.Add("@res_id", SqlDbType.Int).Value = purchRestCode
					cmd.Parameters.Add("@dept", SqlDbType.Float).Value = Conversion.Val(Me.txtPaid.Text)
					cmd.Parameters.Add("@credit", SqlDbType.Float).Value = 0
					cmd.Parameters.Add("@acc_no", SqlDbType.Int).Value = clientAccountCode
					cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
					cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
					cmd.ExecuteNonQuery()
				End Using
			End If

		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub UpdateCustomerDiscountBalance()
		Try
			If Me.InvProc = 2 AndAlso Me.cmbProcType.SelectedIndex = 0 Then
				Me.UpdateCustDiscBalance()
			ElseIf Me.InvProc = 2 AndAlso Me.cmbProcType.SelectedIndex = 1 Then
				Me.UpdateCustDiscBalanceRet()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub SendToCustomerDisplay()
		Try
			Me.sp.Open()
			Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
			Me.sp.WriteLine("Total: " & Me.txtDiff.Text)
			Me.sp.Close()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub ShowReceiptPopup()
		Dim frmInvPopUpWindow As New frmInvPopUpWindow()
		Try
			If Conversion.Val(Me.txtrec.Text) <> 0.0 Then
				Using frm As New frmInvPopUpWindow()
					frm.txtRec.Text = Me.txtrec.Text
					frm.txtRem.Text = Me.txtrecrem.Text
					frm.ShowDialog()
				End Using
			End If
		Catch ex As Exception
		End Try
	End Sub

#End Region

#Region "دوال معالجة الأخطاء"

	Private Sub HandleSaveError(transaction As SqlTransaction, ex As Exception)
		Try
			transaction?.Rollback()
		Catch rollbackEx As Exception
			' تجاهل خطأ التراجع
		End Try

		Dim errorMessage As String

		If MainClass.Language = "en" Then
			errorMessage = "error in saving" & Environment.NewLine & "Error details: " & ex.Message
		Else
			errorMessage = "خطأ أثناء الحفظ" & Environment.NewLine & "تفاصيل الخطأ: " & ex.Message
		End If

		MessageBox.Show(errorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	Private Sub CloseConnection()
		Try
			If Me.conn.State <> ConnectionState.Closed Then
				Me.conn.Close()
			End If
		Catch ex As Exception
			' تجاهل الخطأ
		End Try
	End Sub

#End Region

	'///////////////////////////////
	Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
		Try
			Dim flag As Boolean = Me.Code <> -1
			If flag Then
				Dim dialogResult As DialogResult = MessageBox.Show("سوء استخدام قد تتعرض للمسائلة القانونية من قبل الجهات الضريبية، هل أنت متأكد من الحذف؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				flag = (dialogResult = DialogResult.No)
				If Not flag Then
					flag = (Me.conn.State <> ConnectionState.Open)
					If flag Then
						Me.conn.Open()
					End If
					Dim sqlCommand As SqlCommand = New SqlCommand("update Inv set IS_Deleted=1 where proc_id=" + Conversions.ToString(Me.ProcCode), Me.conn)
					sqlCommand.ExecuteNonQuery()
					flag = (Me.RestPurchCode <> 0)
					If flag Then
						sqlCommand = New SqlCommand("update Restrictions set state=2 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.RestPurchCode), Me.conn)
						sqlCommand.ExecuteNonQuery()
					End If
					flag = (Me.RestSaleCode <> 0)
					If flag Then
						sqlCommand = New SqlCommand("update Restrictions set state=2 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.RestSaleCode), Me.conn)
						sqlCommand.ExecuteNonQuery()
					End If
					flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
					If flag Then
						MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Else
						MessageBox.Show("Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
					Me.dgvSrch.Rows.Clear()
					Me.CLR()
				End If
			Else
				MessageBox.Show("اختر فاتورة ليتم حذفها", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		Catch ex As Exception
			Dim text As String = "خطأ أثناء الحذف"
			text = text + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
			Dim flag As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
			If flag Then
				text = "error in delete"
				text = text + Environment.NewLine + "error details: " + ex.Message
			End If
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		Finally
			Dim flag As Boolean = Me.conn.State <> ConnectionState.Closed
			If flag Then
				Me.conn.Close()
			End If
		End Try
	End Sub

	Private Sub dgvRowChng(row_index As Integer)
		Try
			' The following expression was wrapped in a checked-expression
			Me.ProcCode = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", Me.dgvSrch.Rows(row_index).Cells(0).Value))))
			Me.Navigate("select * from Inv where proc_id=" + Conversions.ToString(Me.ProcCode))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvSrch_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellClick
		Dim flag As Boolean = e.RowIndex >= 0
		If flag Then
			Me.dgvRowChng(e.RowIndex)
			Me.TabControl1.SelectedIndex = 0
		End If
	End Sub

	Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub ReadData(dr As SqlDataReader)
		Dim frmChargeData As New frmChargeData()
		Dim flag As Boolean = dr.HasRows
		If flag Then
			Me._ReadCompleted = False
			dr.Read()
			Me.CLR()
			Me._newproc = False
			Dim flag2 As Boolean
			Me.ProcCode = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dr("proc_id")))))
			Me.RestPurchCode = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dr("purch_rest_id")))))
			Me.RestSaleCode = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dr("sale_rest_id")))))
			Me.cmbProcType.SelectedIndex = CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("proc_type"))) - 1.0))
			Me.Code = CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dr("id")))))
			Me.txtNo.Text = "" + Conversions.ToString(Me.Code)
			Me.txtDate.Value = Conversions.ToDate(Operators.ConcatenateObject("", dr("date")))
			Me.cmbType.SelectedIndex = CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("inv_type"))) - 1.0))
			Me.cmbSafe.SelectedValue = Operators.ConcatenateObject("", dr("safe"))
			Me.cmbStock.SelectedValue = Operators.ConcatenateObject("", dr("stock"))
			Try
				flag = (Me.cmbSafe.SelectedValue Is Nothing)
				If flag Then
					Me.LoadSafes(True)
					Me.cmbSafe.SelectedValue = Operators.ConcatenateObject("", dr("safe"))
					Me.cmbSafe.Enabled = False
				End If
			Catch ex As Exception
			End Try
			Try
				flag = (Me.cmbStock.SelectedValue Is Nothing)
				If flag Then
					Me.LoadStocks(True)
					Me.cmbStock.SelectedValue = Operators.ConcatenateObject("", dr("stock"))
					Me.cmbStock.Enabled = False
				End If
			Catch ex2 As Exception
			End Try
			Me.cmbClient.SelectedValue = Operators.ConcatenateObject("", dr("cust_id"))
			Me.txtTotPurch.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("tot_purch"))))
			Me.txtTotSale.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("tot_sale"))))
			Me.txtDiff.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("tot_net"))))
			Try
				Me.TextBox1.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("notes")))
			Catch ex3 As Exception
			End Try
			Try
				Me.txtPaid.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dr("paid"))))
			Catch ex4 As Exception
			End Try
			Try
				Me._custdisc = Conversion.Val(Operators.ConcatenateObject("", dr("cust_disc")))
				Me._CustDiscAdded = Conversion.Val(Operators.ConcatenateObject("", dr("custdiscadd")))
			Catch ex5 As Exception
			End Try
			Try
				flag = Operators.ConditionalCompareObjectNotEqual(dr("salesman"), -1, False)
				If flag Then
					Me.cmbSalesMen.SelectedValue = RuntimeHelpers.GetObjectValue(dr("salesman"))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.cmbProcType.SelectedIndex = 1)
			If flag Then
				Me.txtSrcInvNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("InvId_Return")))
			End If
			Try
				flag = (Me.cmbType.SelectedIndex = 1)
				If flag Then
					flag2 = Operators.ConditionalCompareObjectEqual(dr("pay_type"), 1, False)
					If flag2 Then
						Me.rdCash.Checked = True
					Else
						flag2 = Operators.ConditionalCompareObjectEqual(dr("pay_type"), 2, False)
						If flag2 Then
							Me.rdNetwork.Checked = True
							Me.cmbBanks.SelectedValue = RuntimeHelpers.GetObjectValue(dr("bank"))
						End If
					End If
				End If
			Catch ex7 As Exception
			End Try
			Try
				Me.cmbBanks.SelectedValue = RuntimeHelpers.GetObjectValue(dr("bank"))
			Catch ex8 As Exception
			End Try
			Try
				flag2 = Operators.ConditionalCompareObjectNotEqual(dr("ers_supp"), -1, False)
				If flag2 Then
					Me.cmbErsSuppliers.SelectedValue = RuntimeHelpers.GetObjectValue(dr("ers_supp"))
				End If
				flag2 = (Conversion.Val(RuntimeHelpers.GetObjectValue(dr("ers_no"))) <> 0.0)
				If flag2 Then
					Me.txtErsNo.Text = Conversions.ToString(dr("ers_no"))
				End If
			Catch ex9 As Exception
			End Try
			Try
				Me.txtRefNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("refno")))
			Catch ex10 As Exception
			End Try
			Try
				Me.chkMaintainance.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_maint")))
				Me.txtMaintInvId.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("maint_inv_id")))
			Catch ex11 As Exception
			End Try
			Try
				Me.txtCash.Text = Conversions.ToString(dr("cash_part"))
				Me.txtNetwork.Text = Conversions.ToString(dr("network_part"))
			Catch ex12 As Exception
			End Try
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 3)
				If flag2 Then
					Me.txtCustNote.Text = Conversions.ToString(dr("reserv_custname"))
					Me.txtCustTel.Text = Conversions.ToString(dr("reserv_custtel"))
					Me.txtCustAddress.Text = Conversions.ToString(dr("reserv_custadd"))
				End If
			Catch ex13 As Exception
			End Try
			Try
				Me.cmbCenter.SelectedValue = Operators.ConcatenateObject("", dr("center"))
			Catch ex14 As Exception
			End Try
			Try
				Me.txtRetention.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("retention")))
			Catch ex15 As Exception
			End Try
			Try
				frmChargeData.txtRecNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_no")))
				frmChargeData.txtRecDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("rec_date")))
				frmChargeData.txtRecPurchOrderNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_purchno")))
				frmChargeData.txtRecSaleOrderNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_saleno")))
				frmChargeData.txtRecChargeType.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_chargetype")))
				frmChargeData.txtRecCustLoc.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_custloc")))
				frmChargeData.txtRecCustLocAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_custlocadd")))
				frmChargeData.txtRecRespTel.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_resptel")))
				frmChargeData.txtRecCustVatNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_custvatno")))
				frmChargeData.txtRecCar.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_car")))
				frmChargeData.txtRecCarNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_carno")))
				frmChargeData.txtRecChargeTime.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_chargetime")))
				frmChargeData.txtRecChargeAcc.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_chargeacc")))
				frmChargeData.txtRecDriver.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("rec_driver")))
			Catch ex16 As Exception
			End Try
			Try
				Me.chkHold.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_hold")))
			Catch ex17 As Exception
			End Try
			Try
				Me.txtProjectName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("project_name")))
			Catch ex18 As Exception
			End Try
			Try
				Me.txtInvoicePeriod.Value = Conversions.ToDecimal(dr("inv_period"))
			Catch ex19 As Exception
			End Try
			Try
				flag2 = (Me.InvProc = 2)
				If flag2 Then
					Me.txtCustName.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("cust_name")))
				End If
			Catch ex20 As Exception
			End Try
			Try
				Me.txtPeriodDate1.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("period_date1")))
				Me.txtPeriodDate2.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("period_date2")))
				Me.txtDueDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dr("due_date")))
			Catch ex21 As Exception
			End Try
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 4 And Me.pnlPurchOrder.Visible)
				If flag2 Then
					Me.txtPaymentTerms.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("payment_terms")))
					Me.txtReferenceNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("reference_no")))
					Me.txtHirePeriod.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("hire_period")))
				End If
			Catch ex22 As Exception
			End Try
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 1)
				If flag2 Then
					Me.cmbAcc.SelectedValue = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dr("acc")))
				End If
			Catch ex23 As Exception
			End Try
			Try
				Me.txtTwreedDate.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("twreed_date")))
			Catch ex24 As Exception
			End Try
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 2)
				If flag2 Then
					Me.chkDebtNote.Checked = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dr("is_debtnote")))
					Me.txtDebtNoteInvNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("debtnote_id")))
				End If
			Catch ex25 As Exception
			End Try
			Try
				Me.txtPoNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dr("pono")))
			Catch ex26 As Exception
			End Try
			dr.Close()
			Me._loaded = False
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Inv_Sub where proc_id=" + Conversions.ToString(Me.ProcCode), Me.conn)
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
				Me.dgvItems.Rows.Add()
				Me.dgvItems.Rows(num3).Cells(0).Value = Me.Code
				flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows(num3)("proc_type"), 1, False)
				If flag2 Then
					Me.dgvItems.Rows(num3).Cells(1).Value = "شراء"
				Else
					Me.dgvItems.Rows(num3).Cells(1).Value = "بيع"
				End If
				Try
					Me.dgvItems.Rows(num3).Cells(10).Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("expire_date"))).ToShortDateString()
				Catch ex27 As Exception
				End Try
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select barcode from Currencies where id=", dataTable.Rows(num3)("currency_from"))), Me.conn1)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag2 = (dataTable2.Rows.Count > 0)
					If flag2 Then
						Me.dgvItems.Rows(num3).Cells("colbarcode").Value = Operators.ConcatenateObject("", dataTable2.Rows(0)(0))
					End If
				Catch ex28 As Exception
				End Try
				Me.dgvItems.Rows(num3).Cells(2).Value = Me.GetCurrencyName(CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency_from"))))))
				Me.dgvItems.Rows(num3).Cells(3).Value = Me.GetUnitName(CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("unit"))))))
				Me.dgvItems.Rows(num3).Cells(4).Value = Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val1")))
				Me.dgvItems.Rows(num3).Cells(5).Value = Convert.ToString(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val")))
				Dim num6 As Decimal = 1D
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.perc from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", dataTable.Rows(num3)("unit")), " and curr_units.curr="), dataTable.Rows(num3)("currency_from"))), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag2 = (dataTable3.Rows.Count > 0)
				If flag2 Then
					num6 = New Decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))))
				End If
				Me.dgvItems.Rows(num3).Cells(6).Value = num6
				Dim dataGridViewCell As DataGridViewCell = Me.dgvItems.Rows(num3).Cells(7)
				Dim instance As Object = Nothing
				Dim typeFromHandle As Type = GetType(Math)
				Dim memberName As String = "Round"
				Dim array As Object() = New Object(1) {}
				Dim array2 As Object() = array
				Dim num7 As Integer = 0
				Dim dataRow As DataRow = dataTable.Rows(num3)
				Dim dataRow2 As DataRow = dataRow
				Dim columnName As String = "exchange_price"
				array2(num7) = RuntimeHelpers.GetObjectValue(dataRow2(columnName))
				array(1) = 5
				Dim array3 As Object() = array
				Dim arguments As Object() = array3
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array4 As Boolean() = New Boolean() {True, False}
				Dim obj As Object = NewLateBinding.LateGet(instance, typeFromHandle, memberName, arguments, argumentNames, typeArguments, array4)
				If array4(0) Then
					dataRow(columnName) = RuntimeHelpers.GetObjectValue(array3(0))
				End If
				dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(obj)

				Dim num8 As Double = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("val1"))) * Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("exchange_price"))), 3)
				Me.dgvItems.Rows(num3).Cells(8).Value = num8
				Me.dgvItems.Rows(num3).Cells(9).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("currency_from"))
				Try
					Dim num9 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("discount")))
					Dim num10 As Double = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("discount"))) / num8 * 100.0
					Me.dgvItems.Rows(num3).Cells(11).Value = num9
					Me.dgvItems.Rows(num3).Cells(12).Value = num10
					Me.dgvItems.Rows(num3).Cells(13).Value = num8 - num9
				Catch ex29 As Exception
				End Try
				Try
					Me.dgvItems.Rows(num3).Cells(14).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("taxperc"))
					Me.dgvItems.Rows(num3).Cells(15).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(num3)("taxval"))), 3)
					Me.dgvItems.Rows(num3).Cells(16).Value = Math.Round(Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(13).Value)) + Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(num3)("taxval"))), 2)
				Catch ex30 As Exception
				End Try
				Try
					Me.dgvItems.Rows(num3).Cells(18).Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("notes"))
				Catch ex31 As Exception
				End Try
				Try
					Me.dgvItems.Rows(num3).Cells("colOperateNo").Value = Operators.ConcatenateObject("", dataTable.Rows(num3)("operate_no"))
				Catch ex32 As Exception
				End Try

				num3 += 1
			End While
			Me._loaded = True
			Try
				flag2 = (Me.cmbProcType.SelectedIndex = 3)
				If flag2 Then
					Me.btnConvertToSales.Visible = True
				End If
			Catch ex33 As Exception
			End Try
			Me.txtInvCustDisc.Text = "" + Conversions.ToString(Me._custdisc)
			Me.CalcTot()
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Me.txtDiscPerc.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotPurch.Text) * 100.0, 2))
				Me.txtDiscPerc1.Text = Conversions.ToString(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotPurch.Text) * 100.0)
			Else
				Me.txtDiscPerc.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotSale.Text) * 100.0, 2))
				Me.txtDiscPerc1.Text = Conversions.ToString(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotSale.Text) * 100.0)
			End If
			Me._lastdisc = New Decimal(Conversion.Val(Me.txtDiscPerc1.Text))
			Me.DGV_Count = Me.dgvItems.Rows.Count
			flag2 = (Me.cmbProcType.SelectedIndex <> 3 And Me.InvProc <> 1 And Not Me.chkHold.Checked)
			If flag2 Then
				Me.GroupBox3.Enabled = False
				Me.GroupBox7.Enabled = False
				Me.GroupBox8.Enabled = False
			End If
			Me._ReadCompleted = True
		Else
			Me.CLR()
		End If
	End Sub

	Public Sub Navigate(sqlstr As String)
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

	Private Sub txtVal1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal1.TextChanged
		Try
			Me.txtVal2.Text = String.Format("{0:0.#,##.##}", Math.Round(Convert.ToDouble(Me.txtVal1.Text) * Convert.ToDouble(Me.txtExchangeVal.Text), 3))
			Me.txtCurrDiscVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtCurrDisc.Text) / 100.0 * Conversion.Val(Me.txtVal2.Text), 2))
			Me.txtExchangeValD.Text = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtExchangeVal.Text) / Me._Exchangeal, 2))
			Me.txtVal2D.Text = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtVal2.Text) / Me._Exchangeal, 2))
			Try
				Dim num As Double = Conversion.Val(Me.txtCurrDiscVal.Text)
				Dim num2 As Double = Conversion.Val(Me.txtVal2.Text) - num
				Me.lblCurrTaxVal.Text = "" + Conversions.ToString(Math.Round(Conversion.Val(Me.txtCurrTax.Text) / 100.0 * num2, 3))
			Catch ex As Exception
			End Try
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=", Conversions.ToString(Me._IsBuy), " and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 order by id desc"}))
	End Sub

	Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=", Conversions.ToString(Me._IsBuy), " and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc"}))
	End Sub

	Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=", Conversions.ToString(Me._IsBuy), " and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 order by id asc"}))
	End Sub

	Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=", Conversions.ToString(Me._IsBuy), " and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc"}))
	End Sub

	Private Sub CalcPrice()
		Try
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GetItemCost(_item As Integer, _unit As Integer)
		Try
			Dim flag As Boolean = True
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select showlastpurch from foundation where id=1", Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Dim str As String = ""
			Dim flag2 As Boolean = flag
			If flag2 Then
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select top 1 exchange_price,inv.cust_id from inv,inv_sub where inv.proc_type=1 and is_buy=1 and inv.proc_id=inv_sub.proc_id and currency_from=", Conversions.ToString(_item), " and unit=", Conversions.ToString(_unit), " order by inv.date desc"}), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag2 = (dataTable2.Rows.Count > 0)
				If flag2 Then
					Me.lblCostPrice.Text = Conversions.ToString(Operators.ConcatenateObject("آخر سعر شراء: ", dataTable2.Rows(0)(0)))
					str = "   المورد: " + Me.GetCustName(Conversions.ToInteger(dataTable2.Rows(0)(1)))
				Else
					sqlDataAdapter2 = New SqlDataAdapter("select purch_price from currencies where is_deleted=0 and id=" + Conversions.ToString(_item) + " and unit=" + Conversions.ToString(_unit), Me.conn)
					dataTable2 = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag2 = (dataTable2.Rows.Count > 0)
					If flag2 Then
						Me.lblCostPrice.Text = Conversions.ToString(Operators.ConcatenateObject("آخر سعر شراء: ", dataTable2.Rows(0)(0)))
					Else
						sqlDataAdapter2 = New SqlDataAdapter("select purch from curr_units where curr=" + Conversions.ToString(_item) + " and unit=" + Conversions.ToString(_unit), Me.conn)
						dataTable2 = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag2 = (dataTable2.Rows.Count > 0)
						If flag2 Then
							Me.lblCostPrice.Text = Conversions.ToString(Operators.ConcatenateObject("آخر سعر شراء: ", dataTable2.Rows(0)(0)))
						End If
					End If
				End If
			End If
			Dim lblCostPrice As Label = Me.lblCostPrice
			lblCostPrice.Text = lblCostPrice.Text + "   كمية الصنف: " + Conversions.ToString(MainClass.GetItemQuan(_item, Conversions.ToInteger(Me.cmbSafe.SelectedValue)))
			flag2 = flag
			If flag2 Then
				lblCostPrice = Me.lblCostPrice
				lblCostPrice.Text += str
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
		Try
			Dim flag As Boolean = Not Me._loaded
			If Not flag Then
				Dim flag2 As Boolean
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price,sale_price,tax,discount from Currencies  where id= ", Me.cmbCurrency.SelectedValue)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag = (Me.InvProc = 1)
					If flag Then
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_price"))))
					Else
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_price"))))
					End If
					flag = (Me.cmbProcType.SelectedIndex <> 2)
					If flag Then
						Try
							flag2 = (Me.InvProc = 2 Or (Me.InvProc = 1 And Me.chkIsVAT.Checked))
							If flag2 Then
								Me.txtCurrTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax")))
							End If
						Catch ex As Exception
						End Try
						Try
							Me.txtCurrDisc.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("discount")))
						Catch ex2 As Exception
						End Try
					End If
				Catch ex3 As Exception
				End Try
				Try
					flag2 = (Me.InvProc = 2 And Me.chkInTax.Checked)
					If flag2 Then
						Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtCurrTax.Text) / 100.0), 5))
					End If
				Catch ex4 As Exception
				End Try
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from Currencies where id=", Me.cmbCurrency.SelectedValue)), Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag2 = (dataTable2.Rows.Count > 0)
					If flag2 Then
						Try
							Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("group_id"))
						Catch ex5 As Exception
						End Try
						Try
							Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("unit"))
						Catch ex6 As Exception
							flag2 = (Me.cmbUnits.Items.Count > 0)
							If flag2 Then
								Me.cmbUnits.SelectedIndex = 0
							End If
						End Try
						Try
							Me.txtItemNote.Text = Conversions.ToString(dataTable2.Rows(0)("notes"))
						Catch ex7 As Exception
						End Try
					End If
				Catch ex8 As Exception
				End Try
				Try
					flag2 = Me.rdNormal.Checked
					If flag2 Then
						Me.LoadUnits(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
					End If
				Catch ex9 As Exception
				End Try
				flag2 = Not Me._IsUpdateDG
				If flag2 Then
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select barcode from currencies where id=", Me.cmbCurrency.SelectedValue)), Me.conn1)
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable3)
					flag2 = (dataTable3.Rows.Count > 0)
					If flag2 Then
						flag = (Operators.CompareString(dataTable3.Rows(0)(0).ToString(), "", False) <> 0)
						If flag Then
							Me._loaded = False
							Me.txtBarcode.Text = dataTable3.Rows(0)(0).ToString()
							Me._loaded = True
						End If
					End If
				End If
			End If
		Catch ex10 As Exception
		End Try
	End Sub

	Private Sub Search()
		Dim flag As Boolean = Not Me.chkAll.Checked And Me.cmbClientSrch.SelectedValue Is Nothing
		If flag Then
			Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
			If flag2 Then
				Dim flag3 As Boolean = Me.InvProc = 2
				If flag3 Then
					Interaction.MsgBox("اختر العميل أو الكل", MsgBoxStyle.OkOnly, Nothing)
				Else
					Interaction.MsgBox("اختر المورد أو الكل", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Dim flag3 As Boolean = Me.InvProc = 2
				If flag3 Then
					Interaction.MsgBox("choose client or all", MsgBoxStyle.OkOnly, Nothing)
				Else
					Interaction.MsgBox("choose supplier or all", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
			Me.cmbClientSrch.Focus()
		Else
			Dim text As String = ""
			Dim flag3 As Boolean = MainClass.BranchNo <> -1
			If flag3 Then
				text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Dim text2 As String = text
			flag3 = (Operators.CompareString(Me.txtSrchNo.Text, "", False) <> 0)
			If flag3 Then
				text2 = text2 + " inv.id=" + Me.txtSrchNo.Text + " and "
			Else
				flag3 = (Operators.CompareString(Me.txtSrchBarcode.Text, "", False) <> 0)
				If flag3 Then
					text2 = text2 + " inv.id=" + Me.txtSrchBarcode.Text.Replace("00112233", "") + " and "
				Else
					flag3 = Me.chkSrchDate.Checked
					If flag3 Then
						text2 += " date>=@date1 and date<=@date2 and "
					End If
				End If
			End If
			flag3 = Not Me.chkAll.Checked
			If flag3 Then
				text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" cust_id=", Me.cmbClientSrch.SelectedValue), " and ")))
			End If
			flag3 = Me.chkSrchHold.Checked
			If flag3 Then
				text2 += " is_hold=1 and "
			End If
			flag3 = (Operators.CompareString(Me.txtClientMobile.Text.Trim(), "", False) <> 0)
			If flag3 Then
				text2 = String.Concat(New String() {text2, " (customers.mobile='", Me.txtClientMobile.Text, "' or customers.tel='", Me.txtClientMobile.Text, "') and "})
			End If
			Me.LoadDG(text2)
		End If
	End Sub

	Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
		Me.Search()
	End Sub

	Public Sub DotxtInvProc()
		Dim flag As Boolean = Me.InvProc = 1
		If flag Then
			Me.Label5.Text = "شراء من عميل"
			Me.Label7.Text = "بيع من المؤسسة"
		Else
			Me.Label5.Text = "بيع لعميل"
			Me.Label7.Text = "دخل المؤسسة"
		End If
	End Sub

	Private Sub frmSalePurch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
		Dim flag As Boolean = e.KeyCode = Keys.F6
		If flag Then
			Me.btnSave_Click(Nothing, Nothing)
		Else
			flag = (e.KeyCode = Keys.F3)
			If flag Then
				Dim flag2 As Boolean = Me.btnPrint.Enabled
				If flag2 Then
					Me.PrintRpt(2)
				End If
			Else
				Dim flag2 As Boolean = e.KeyCode = Keys.F4
				If flag2 Then
					flag = Me.btnPrint.Enabled
					If flag Then
						Me.PrintRptA4(1, 1, False)
					End If
				Else
					flag2 = (e.KeyCode = Keys.F5)
					If flag2 Then
						Me.Add2DG()
					Else
						flag2 = (e.KeyCode = Keys.[Return])
						If flag2 Then
							flag = Not Me.txtBarcode.Focused
							If flag Then
								SendKeys.Send("{TAB}")
							End If
						Else
							flag2 = (e.KeyCode = Keys.F7)
							If flag2 Then
								Try
									flag = (Me.dgvItems.Rows.Count > 0)
									If flag Then
										Me.dgvItems.Focus()
										Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(4).Selected = True
									End If
								Catch ex As Exception
								End Try
							Else
								flag2 = (e.KeyCode = Keys.F8)
								If flag2 Then
									Try
										flag = (Me.dgvItems.Rows.Count > 0)
										If flag Then
											Me.dgvItems.Focus()
											Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1).Cells(7).Selected = True
										End If
									Catch ex2 As Exception
									End Try
								Else
									flag2 = (e.KeyCode = Keys.F9)
									If flag2 Then
										Me.txtNetwork.Focus()
										Me.txtCash.Text = "0"
										Me.txtNetwork.Text = Me.txtDiff.Text
									Else
										flag2 = (e.KeyCode = Keys.F10)
										If flag2 Then
											Me.txtCash.Focus()
										Else
											flag2 = (e.KeyCode = Keys.F12 And Me.InvProc = 2)
											If flag2 Then
												Me.SrchItem()
											Else
												flag2 = (e.KeyCode = Keys.Delete)
												If flag2 Then
													Try
														flag = (Me.dgvItems.Rows.Count > 0)
														If flag Then
															Dim dialogResult As DialogResult = MessageBox.Show("هل تريد حذف الصنف من الجدول", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
															flag2 = (dialogResult = DialogResult.Yes)
															If flag2 Then
																Me.dgvItems.Rows.Remove(Me.dgvItems.Rows(Me.dgvItems.Rows.Count - 1))
																Me.CalcTot()
															End If
														End If
													Catch ex3 As Exception
													End Try
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If
	End Sub

	Private Sub txtVal1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal1.Enter
		Try
			Me.txtVal1.SelectAll()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtExchangeVal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtExchangeVal.Enter
		Try
			Me.txtExchangeVal.SelectAll()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtVal2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal2.Enter
		Try
			Me.txtVal2.SelectAll()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbProcType.SelectedIndexChanged
		Me.LoadInvNo()
		Try
			Dim flag As Boolean = Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 1
			If flag Then
				Me.Text = "فاتورة مشتريات"
			Else
				flag = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 2)
				If flag Then
					Me.Text = "فاتورة مبيعات"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 1)
					If flag Then
						Me.Text = "مرتد مشتريات"
					Else
						flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 2)
						If flag Then
							Dim flag2 As Boolean = Me._IsCreditNote
							If flag2 Then
								Me.Text = "إشعار دائن"
							Else
								Me.Text = "مرتد مبيعات"
							End If
						Else
							Dim flag2 As Boolean = Me.cmbProcType.SelectedIndex = 2
							If flag2 Then
								flag = Me.IS_manfc
								If flag Then
									Me.Text = "إنتاج"
								Else
									Me.Text = "أصناف أول المدة"
								End If
							Else
								flag2 = (Me.cmbProcType.SelectedIndex = 3)
								If flag2 Then
									Me.Text = "عرض سعر"
								Else
									flag2 = (Me.cmbProcType.SelectedIndex = 4)
									If flag2 Then
										Me.Text = "أمر شراء"
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Function GetUnitID(name As String) As Integer
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from units where name='" + name + "'", Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Return Conversions.ToInteger(dataTable.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
		Return -1
	End Function

	Private Sub dgvItems_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
		Try
			Dim flag As Boolean = e.ColumnIndex = 17
			If flag Then
				Dim dialogResult As DialogResult = MessageBox.Show("هل تريد حذف السجل", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				flag = (dialogResult = DialogResult.Yes)
				If flag Then
					Me.dgvItems.Rows.Remove(Me.dgvItems.Rows(e.RowIndex))
					Me.CalcTot()
				End If
			Else
				flag = (e.ColumnIndex = 4 Or e.ColumnIndex = 7)
				If Not flag Then
					Me._IsUpdateDG = True
					Try
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select group_id from Currencies where id=", Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)), Me.conn)
						Dim dataTable As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						Dim num As Integer = CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
						Me.cmbGroups.SelectedValue = num
					Catch ex As Exception
					End Try
					Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)
					Try
						Me.cmbUnits.SelectedValue = Me.GetUnitID(Conversions.ToString(Me.dgvItems.Rows(e.RowIndex).Cells(3).Value))
					Catch ex2 As Exception
					End Try
					Me.txtVal1.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(4).Value))
					Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(7).Value)))
					Me.txtVal2.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(8).Value)))
					Me.txtCurrDiscVal.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(11).Value))
					Try
						Me.txtItemNote.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(18).Value))
					Catch ex3 As Exception
					End Try
					Try
						Me.txtExpireDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(10).Value))
					Catch ex4 As Exception
					End Try
					flag = (Me.InvProc = 2)
					If flag Then
						Me.GetItemCost(Conversions.ToInteger(Me.cmbCurrency.SelectedValue), Conversions.ToInteger(Me.cmbUnits.SelectedValue))
					End If
				End If
			End If
		Catch ex5 As Exception
		End Try
	End Sub

	Private Sub txtExchangeVal_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtExchangeVal.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.Down
		If flag Then
			SendKeys.Send("{TAB}")
		Else
			flag = (e.KeyCode = Keys.Up)
			If flag Then
				SendKeys.Send("+{TAB}")
			Else
				flag = (e.KeyCode = Keys.[Return])
				If flag Then
					Try
						Dim flag2 As Boolean = Me.InvProc = 2 And Me.chkInTax.Checked
						If flag2 Then
							Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtCurrTax.Text) / 100.0), 5))
						End If
					Catch ex As Exception
					End Try
				End If
			End If
		End If
	End Sub

	Private Sub txtSrcInvNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSrcInvNo.KeyDown
		Try
			Dim flag As Boolean = Operators.CompareString(Me.txtSrcInvNo.Text.Trim(), "", False) <> 0 And e.KeyCode = Keys.[Return]
			If flag Then
				Dim text As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
				End If
				Dim value As Integer = 1
				flag = (Me.InvProc = 2)
				If flag Then
					value = 0
				End If
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select InvId_Return from Inv where ", text, " IS_Buy=", Conversions.ToString(value), " and IS_Deleted=0 and InvId_Return=", Me.txtSrcInvNo.Text}), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					MessageBox.Show("هذه الفاتورة تم ارجاعها من قبل", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.dgvItems.Rows.Clear()
					Me.CalcTot()
					Me.txtSrcInvNo.Focus()
					Me.txtSrcInvNo.Text = ""
				Else
					Dim text2 As String = Me.txtSrcInvNo.Text
					Me.Navigate(String.Concat(New String() {"select * from Inv where ", text, " IS_Buy=", Conversions.ToString(value), " and IS_Deleted=0 and proc_type=1 and  id=", Me.txtSrcInvNo.Text}))
					Me.txtSrcInvNo.Text = text2
					Me.GroupBox3.Enabled = True
					Me.GroupBox7.Enabled = True
					Me.GroupBox8.Enabled = True
					flag = (Me.dgvItems.Rows.Count > 0)
					If flag Then
						Me.txtSrcInvNo.Enabled = False
					Else
						Interaction.MsgBox("لا توجد بيانات لهذا الرقم", MsgBoxStyle.OkOnly, Nothing)
						Me.txtSrcInvNo.Text = ""
					End If
					Me.txtDate.Value = DateTime.Now
					Me.cmbProcType.SelectedIndex = 1
					Me.ProcCode = -1
					Me._newproc = True
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtSrcInvNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSrcInvNo.KeyPress
		MainClass.ISInteger(e)
	End Sub

	Private Sub btnSave2DG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave2DG.Click
		Me.Add2DG()
	End Sub

	Private Sub btnNew2DG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew2DG.Click
		Me.cmbCurrency.SelectedIndex = -1
		Me.txtVal1.Text = ""
		Me.txtExchangeVal.Text = ""
		Me.txtVal2.Text = ""
		Me.txtExchangeValD.Text = ""
		Me.txtVal2D.Text = ""
		Me.txtCurrTax.Text = ""
		Me.lblCurrTaxVal.Text = ""
		Me.txtCurrDisc.Text = ""
		Me.txtCurrDiscVal.Text = ""
		Me._IsUpdateDG = False
		Me.lblCostPrice.Text = ""
		Me.txtBarcode.Focus()
	End Sub

	Private Sub dgvSrch_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvSrch.DataError
	End Sub

	Private Sub dgvItems_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvItems.DataError
	End Sub

	Private Sub txtVal1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtVal1.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.Down
		If flag Then
			SendKeys.Send("{TAB}")
		Else
			flag = (e.KeyCode = Keys.Up)
			If flag Then
				SendKeys.Send("+{TAB}")
			End If
		End If
	End Sub

	Private Function GetEmpName(emp As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetCustName(cust As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Customers where id=" + Conversions.ToString(cust), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetCustAct(cust As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select acts.name from acts,Customers where Customers.id=" + Conversions.ToString(cust) + " and Customers.act=acts.id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetSalesEmpNameByInvNo() As String
		Dim result As String
		Try
			Dim flag As Boolean = Me.ProcCode <> -1
			If flag Then
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select users.username from Employees,Inv,users where users.emp=Employees.id and Employees.id=Inv.sales_emp and proc_id=" + Conversions.ToString(Me.ProcCode), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				Else
					result = ""
				End If
			Else
				result = MainClass.UserName
			End If
		Catch ex As Exception
			result = ""
		End Try
		Return result
	End Function

	Private Function GetCustAddress(cust As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select address from Customers where id=" + Conversions.ToString(cust), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetCustTel(cust As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select tel,mobile from Customers where id=" + Conversions.ToString(cust), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
			If flag2 Then
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			Else
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
			End If
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetBranchName(branch As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from branches where id=" + Conversions.ToString(branch), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = ""
		End If
		Return result
	End Function

	Private Sub SendSMS()
		Dim Form1 As New Form1()
		Try
			Dim text As String = ""
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select msg from sms_msgs where assign_to=2 and is_deleted=0 and is_default=1", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			flag = (Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(Me.txtCustTel2.Text, "", False) <> 0)
			If flag Then
				Dim flag2 As Boolean = Form1.SMS_CompType = 1
				If flag2 Then
					Dim text2 As String = Form1.SendMessage(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.txtCustTel2.Text)
				Else
					flag2 = (Form1.SMS_CompType = 2)
					If flag2 Then
						Dim text3 As String = Form1.SendMessage2(Form1.SMSUSERNAME, Form1.SMSPWD, Form1.ConvertToUnicode(text), Form1.SMSUSERNAME, Me.txtCustTel2.Text)
					Else
						flag2 = (Form1.SMS_CompType = 3)
						If flag2 Then
							Dim text4 As String = Form1.SendMessage3(Form1.SMSUSERNAME, Form1.SMSPWD, text, Form1.SMSSender, Me.txtCustTel2.Text)
						End If
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrintRpt(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Process")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("DataColumn1")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(18).Value)})
				num3 += 1
			End While
			Dim reportDocument As ReportDocument = Nothing
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num6 As Integer = 1
			Try
				flag = Operators.ConditionalCompareObjectEqual(dataTable2.Rows(0)("rptinv_type"), 2, False)
				If flag Then
					num6 = 2
				End If
			Catch ex As Exception
			End Try
			Dim num7 As Decimal = 1D
			Dim value As Decimal = Me.NumericUpDown1.Value
			Dim num8 As Decimal = num7
			Dim flag2 As Boolean
			While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num8, value, 1D)
				flag = (num6 = 1)
				If flag Then
					reportDocument = New rptInv()
				Else
					reportDocument = New rptInvNoTable()
				End If
				reportDocument.SetDataSource(dataTable)
				Dim text As String = ""
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
					flag = (Operators.CompareString(text, "", False) <> 0)
					If flag Then
						Try
							Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("lbltaxno"), TextObject)
							textObject.Text = "الرقم الضريبي"
						Catch ex2 As Exception
						End Try
						Try
							Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("lbltaxnoen"), TextObject)
							textObject2.Text = "Tax No."
						Catch ex3 As Exception
						End Try
						Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
						textObject3.Text = text
					End If
				Catch ex4 As Exception
				End Try
				Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject4.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject4.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject4.Text = "فاتورة ضريبية مبسطة"
								flag2 = (Operators.CompareString(text, "", False) <> 0)
								If flag2 Then
									textObject4.Text = "فاتورة ضريبية"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject4.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title2, "", False) <> 0)
								If flag2 Then
									textObject4.Text = Me.Sales_title2
								End If
								flag2 = Me.chkDebtNote.Checked
								If flag2 Then
									textObject4.Text = "إشعار مدين"
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject4.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									flag = Me._IsCreditNote
									If flag Then
										textObject4.Text = "إشعار دائن"
									Else
										textObject4.Text = "فاتورة مرتجع مبيعات"
									End If
								End If
							End If
						End If
					End If
				End If
				Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("invno"), TextObject)
				textObject5.Text = Me.txtNo.Text
				Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
				textObject6.Text = Me.txtDate.Value.ToShortDateString()
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txttime"), TextObject)
				textObject7.Text = Me.txtInvTime.Text
				Try
					flag2 = (Me.cmbProcType.SelectedIndex = 0 And Me.InvProc = 2 And Me.chkDebtNote.Checked And Operators.CompareString(Me.txtDebtNoteInvNo.Text.Trim(), "", False) <> 0)
					If flag2 Then
						Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select date from inv where is_deleted=0 and proc_type=1 and is_buy=0 and id=" + Me.txtDebtNoteInvNo.Text.Trim(), Me.conn1)
						Dim dataTable4 As DataTable = New DataTable()
						sqlDataAdapter3.Fill(dataTable4)
						flag2 = (dataTable4.Rows.Count > 0)
						If flag2 Then
							Dim text2 As String = "رقم الفاتورة الأصل: " + Me.txtDebtNoteInvNo.Text.Trim() + " - تاريخها: " + Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))).ToString("dd/MM/yyyy")
							Dim textObject8 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("src_info"), TextObject)
							textObject8.Text = text2
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 2 And Me._IsCreditNote And Operators.CompareString(Me.txtSrcInvNo.Text.Trim(), "", False) <> 0)
						If flag2 Then
							Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select date from inv where is_deleted=0 and proc_type=1 and is_buy=0 and id=" + Me.txtSrcInvNo.Text.Trim(), Me.conn1)
							Dim dataTable5 As DataTable = New DataTable()
							sqlDataAdapter4.Fill(dataTable5)
							flag2 = (dataTable5.Rows.Count > 0)
							If flag2 Then
								Dim text3 As String = "رقم الفاتورة الأصل: " + Me.txtSrcInvNo.Text.Trim() + " - تاريخها: " + Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0))).ToString("dd/MM/yyyy")
								Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("src_info"), TextObject)
								textObject9.Text = text3
							End If
						End If
					End If
				Catch ex5 As Exception
				End Try
				Try
					Dim text4 As String = ""
					flag2 = (Me.cmbType.SelectedIndex = 0)
					If flag2 Then
						text4 = "آجل"
					Else
						flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) = 0.0)
						If flag2 Then
							text4 = "نقدي"
						Else
							flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) = 0.0)
							If flag2 Then
								text4 = "شبكة"
							Else
								flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) <> 0.0)
								If flag2 Then
									text4 = "نقدي وشبكة"
								End If
							End If
						End If
					End If
					Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("paytype"), TextObject)
					textObject10.Text = text4
				Catch ex6 As Exception
				End Try
				Try
					Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("branch"), TextObject)
					textObject11.Text = Me.GetBranchName(MainClass.BranchNo)
					Dim textObject12 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("custname"), TextObject)
					textObject12.Text = Me.cmbClient.Text
					flag2 = (Me.txtCustName.Visible And Operators.CompareString(Me.txtCustName.Text.Trim(), "", False) <> 0)
					If flag2 Then
						textObject12.Text = Me.txtCustName.Text
					End If
					Dim textObject13 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("custtel"), TextObject)
					flag2 = (Operators.CompareString(Me.txtCustTel.Text.Trim(), "", False) <> 0)
					If flag2 Then
						textObject13.Text = Me.txtCustTel.Text
					Else
						textObject13.Text = Me.GetCustTel(Conversions.ToInteger(Me.cmbClient.SelectedValue))
					End If
					Dim text5 As String = "نقدي"
					flag2 = (Me.cmbType.SelectedIndex = 0)
					If flag2 Then
						text5 = "آجل"
					End If
					Dim textObject14 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
					textObject14.Text = text5
				Catch ex7 As Exception
				End Try
				Dim textObject15 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("discount"), TextObject)
				textObject15.Text = Me.txtMinusVal.Text
				flag2 = (Me.InvProc = 2)
				If flag2 Then
					Dim textObject16 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("lbldiscount2"), TextObject)
					textObject16.Text = "خصم العميل"
				End If
				Dim textObject17 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("discount2"), TextObject)
				textObject17.Text = Me.txtInvCustDisc.Text
				Dim textObject18 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
				textObject18.Text = Me.lblTaxVal.Text
				Dim textObject19 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("sum"), TextObject)
				flag2 = (Me.InvProc = 1)
				If flag2 Then
					textObject19.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 2))
				Else
					textObject19.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 2))
				End If
				Dim textObject20 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("tot"), TextObject)
				textObject20.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
				Try
					Dim textObject21 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("lblvat"), TextObject)
					textObject21.Text = "إجمالي القيمة المضافة"
					flag2 = (Me._VatVal <> 0.0)
					If flag2 Then
						Dim textObject22 As TextObject = textObject21
						textObject22.Text = textObject22.Text + " (" + Conversions.ToString(Me._VatVal) + "%)"
					End If
				Catch ex8 As Exception
				End Try
				Try
					Dim textObject23 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("lblvaten"), TextObject)
					textObject23.Text = "Total VAT"
					flag2 = (Me._VatVal <> 0.0)
					If flag2 Then
						Dim textObject22 As TextObject = textObject23
						textObject22.Text = textObject22.Text + " (" + Conversions.ToString(Me._VatVal) + "%)"
					End If
				Catch ex9 As Exception
				End Try
				Dim textObject24 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("user"), TextObject)
				textObject24.Text = Me.GetSalesEmpNameByInvNo()
				Try
					Dim textObject25 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
					textObject25.Text = Me.cmbSalesMen.Text
				Catch ex10 As Exception
				End Try
				Try
					flag2 = (Me.cmbType.SelectedIndex = 0 And Conversion.Val(Me.txtPaid.Text) <> 0.0)
					If flag2 Then
						Dim textObject26 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("rec"), TextObject)
						textObject26.Text = "المدفوع: " + Conversions.ToString(Conversion.Val(Me.txtPaid.Text)) + " - المتبقي: " + Conversions.ToString(Conversion.Val(Me.txtRem.Text))
					Else
						flag2 = (Me.cmbType.SelectedIndex = 1 And Conversion.Val(Me.txtrec.Text) <> 0.0)
						If flag2 Then
							Dim textObject27 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("rec"), TextObject)
							flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
							If flag2 Then
								textObject27.Text = "مدفوع شبكة: " + Me.txtNetwork.Text + " - "
							End If
							Dim textObject22 As TextObject = textObject27
							textObject22.Text = String.Concat(New String() {textObject22.Text, "المستلم: ", Me.txtrec.Text, " - المتبقي: ", Me.txtrecrem.Text})
						End If
					End If
				Catch ex11 As Exception
				End Try
				reportDocument.Subreports("rptHeader").SetDataSource(dataTable2)
				Dim flag3 As Boolean = True
				Try
					flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("is_barcode")))
				Catch ex12 As Exception
				End Try
				Try
					flag2 = flag3
					If flag2 Then
						Dim img As Image = Code128Rendering.MakeBarcodeImage("00112233" + Me.txtNo.Text, 2, False)
						Dim dataTable6 As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable6)
						dataTable6.Columns("Logo").ColumnName = "barcode"
						dataTable6.Rows(0)("barcode") = MainClass.Image2Arr(img)
						reportDocument.Subreports("rptBarcode").SetDataSource(dataTable6)
					End If
				Catch ex13 As Exception
				End Try
				Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter("select name,tel,mobile,address,addressEn,cr,bank1,acc1,bank2,acc2,bank3,acc3,img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable7 As DataTable = New DataTable()
				sqlDataAdapter5.Fill(dataTable7)
				Try
					flag2 = (dataTable7.Rows(0)("logo") IsNot DBNull.Value)
					If flag2 Then
						dataTable7.Columns.Add("NameA")
						dataTable7.Columns.Add("NameE")
						dataTable7.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameA"))
						dataTable7.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameE"))
						reportDocument.Subreports("rptHeader").SetDataSource(dataTable7)
					End If
				Catch ex14 As Exception
				End Try
				Dim custvatno As String = ""
				Try
					Dim sqlDataAdapter6 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
					Dim dataTable8 As DataTable = New DataTable()
					sqlDataAdapter6.Fill(dataTable8)
					custvatno = Conversions.ToString(Operators.ConcatenateObject("", dataTable8.Rows(0)(0)))
				Catch ex15 As Exception
				End Try
				Try
					Dim img2 As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, custvatno, Conversions.ToString(dataTable2.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
					Dim dataTable9 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable9)
					dataTable9.Columns("Logo").ColumnName = "barcode"
					dataTable9.Rows(0)("barcode") = MainClass.Image2Arr(img2)
					reportDocument.Subreports("rptQR").SetDataSource(dataTable9)
				Catch ex16 As Exception
				End Try
				Dim textObject28 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				textObject28.Text = Me.taxno
				Try
					Dim textObject29 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("cr"), TextObject)
					textObject29.Text = dataTable2.Rows(0)("bsn_no").ToString()
					Try
						flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable7.Rows(0)("cr")), "", False)
						If flag2 Then
							textObject29.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable7.Rows(0)("cr")))
						End If
					Catch ex17 As Exception
					End Try
				Catch ex18 As Exception
				End Try
				flag2 = (dataTable2.Rows.Count > 0)
				If flag2 Then
					Dim textObject30 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtAddress"), TextObject)
					textObject30.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject31 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtTel"), TextObject)
					textObject31.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject32 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtFax"), TextObject)
					textObject32.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
					Try
						flag2 = (Me.InvProc = 2)
						If flag2 Then
							Try
								reportDocument.SetParameterValue("msg", RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("msg")))
							Catch ex19 As Exception
								reportDocument.SetParameterValue("msg", "")
							End Try
						Else
							reportDocument.SetParameterValue("msg", "")
						End If
					Catch ex20 As Exception
						reportDocument.SetParameterValue("msg", "")
					End Try
					Try
						reportDocument.SetParameterValue("notes", Me.TextBox1.Text)
					Catch ex21 As Exception
					End Try
					flag2 = (dataTable7.Rows.Count > 0)
					If flag2 Then
						flag = (Operators.CompareString(dataTable7.Rows(0)("Address").ToString(), "", False) <> 0)
						If flag Then
							textObject30.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable7.Rows(0)("Address")))
						End If
						flag2 = (Operators.CompareString(dataTable7.Rows(0)("tel").ToString(), "", False) <> 0)
						If flag2 Then
							textObject31.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable7.Rows(0)("tel")))
						End If
						flag2 = (Operators.CompareString(dataTable7.Rows(0)("mobile").ToString(), "", False) <> 0)
						If flag2 Then
							textObject32.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable7.Rows(0)("mobile")))
						End If
					End If
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = reportDocument
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag2 = (type = 1)
				If flag2 Then
					frmRptViewer.Show()
					frmRptViewer.TopMost = True
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						reportDocument.PrintToPrinter(1, False, 1, currentPageNumber)
					Catch ex22 As Exception
					End Try
					Try
						flag2 = (Me.InvProc = 2 And Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("actv_print2"))))
						If flag2 Then
							Try
								reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, System.Windows.Forms.Application.StartupPath + "\\print.pdf")
								Process.Start(New ProcessStartInfo() With {.UseShellExecute = True, .Arguments = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("""", dataTable2.Rows(0)("printer2")), """"c)), .Verb = "printTo", .WindowStyle = ProcessWindowStyle.Hidden, .FileName = System.Windows.Forms.Application.StartupPath + "\\print.pdf"})
							Catch ex23 As Exception
							End Try
						End If
					Catch ex24 As Exception
					End Try
				End If
				num8 = Decimal.Add(num8, 1D)
			End While
			flag2 = (type = 2)
			If flag2 Then
				flag = Me._SendEmail
				If flag Then
					Dim flag4 As Boolean = Not Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\Bill")
					If flag4 Then
						Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\Bill")
					End If
					reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf")
					Dim text6 As String = ""
					Try
						Dim sqlDataAdapter7 As SqlDataAdapter = New SqlDataAdapter("select email from employees where id=" + Conversions.ToString(MainClass.EmpNo), Me.conn1)
						Dim dataTable10 As DataTable = New DataTable()
						sqlDataAdapter7.Fill(dataTable10)
						flag4 = (dataTable10.Rows.Count > 0)
						If flag4 Then
							text6 = Conversions.ToString(Operators.ConcatenateObject("", dataTable10.Rows(0)(0)))
						End If
					Catch ex25 As Exception
					End Try
					flag4 = (Operators.CompareString(text6, "", False) <> 0)
					If flag4 Then
						MainClass.SendEmail(text6, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf", "فاتورة رقم " + Me.txtNo.Text)
					End If
				End If
				Me.Print_Sub()
				Me.btnSave_Click(Nothing, Nothing)
			End If
		End If
	End Sub

	Private Sub PrintRpt_EN(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("Table is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Process")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("Value2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)})
				num3 += 1
			End While
			Dim num6 As Decimal = 1D
			Dim value As Decimal = Me.NumericUpDown1.Value
			Dim num7 As Decimal = num6
			Dim flag2 As Boolean
			While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num7, value, 1D)
				Dim obj As Object = New rptInv_en()
				Dim instance As Object = obj
				Dim type2 As Type = Nothing
				Dim memberName As String = "SetDataSource"
				Dim array As Object() = New Object() {dataTable}
				Dim arguments As Object() = array
				Dim argumentNames As String() = Nothing
				Dim typeArguments As Type() = Nothing
				Dim array2 As Boolean() = New Boolean() {True}
				NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
				If array2(0) Then
					dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
				End If
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject.Text = "price offer bill"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject.Text = "Purchases bill"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject.Text = "Sales bill"
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject.Text = "purchases ret. bill"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject.Text = "Sales ret. bill"
								End If
							End If
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"invno"}, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtNo.Text
				Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"date"}, Nothing, Nothing, Nothing), TextObject)
				textObject3.Text = Me.txtDate.Value.ToShortDateString()
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttime"}, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.txtInvTime.Text
				Try
					Dim text As String = "cash"
					flag2 = Me.rdNetwork.Checked
					If flag2 Then
						text = "network"
					End If
					Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"paytype"}, Nothing, Nothing, Nothing), TextObject)
					textObject5.Text = text
				Catch ex As Exception
				End Try
				Try
					Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"branch"}, Nothing, Nothing, Nothing), TextObject)
					textObject6.Text = Me.GetBranchName(MainClass.BranchNo)
					Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"custname"}, Nothing, Nothing, Nothing), TextObject)
					textObject7.Text = Me.cmbClient.Text
					Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"custtel"}, Nothing, Nothing, Nothing), TextObject)
					textObject8.Text = Me.GetCustTel(Conversions.ToInteger(Me.cmbClient.SelectedValue))
					Dim text2 As String = "cash"
					flag2 = (Me.cmbType.SelectedIndex = 0)
					If flag2 Then
						text2 = "post."
					End If
					Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"invtype"}, Nothing, Nothing, Nothing), TextObject)
					textObject9.Text = text2
				Catch ex2 As Exception
				End Try
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"discount"}, Nothing, Nothing, Nothing), TextObject)
				textObject10.Text = Me.txtMinusVal.Text
				flag2 = (Me.InvProc = 2)
				If flag2 Then
					Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lbldiscount2"}, Nothing, Nothing, Nothing), TextObject)
					textObject11.Text = "client disc."
				End If
				Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"discount2"}, Nothing, Nothing, Nothing), TextObject)
				textObject12.Text = Me.txtInvCustDisc.Text
				Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
				textObject13.Text = Me.lblTaxVal.Text
				Try
					Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblvat"}, Nothing, Nothing, Nothing), TextObject)
					textObject14.Text = "VAT"
					flag2 = (Me._VatVal <> 0.0)
					If flag2 Then
						Dim textObject15 As TextObject = textObject14
						textObject15.Text = textObject15.Text + " (" + Conversions.ToString(Me._VatVal) + "%)"
					End If
				Catch ex3 As Exception
				End Try
				Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"sum"}, Nothing, Nothing, Nothing), TextObject)
				flag2 = (Me.InvProc = 1)
				If flag2 Then
					textObject16.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
				Else
					textObject16.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
				End If
				Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tot"}, Nothing, Nothing, Nothing), TextObject)
				textObject17.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
				Dim textObject18 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"user"}, Nothing, Nothing, Nothing), TextObject)
				textObject18.Text = Me.GetSalesEmpNameByInvNo()
				Try
					Dim textObject19 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"emp"}, Nothing, Nothing, Nothing), TextObject)
					textObject19.Text = Me.cmbSalesMen.Text
				Catch ex4 As Exception
				End Try
				Try
					flag2 = (Me.cmbType.SelectedIndex = 0 And Conversion.Val(Me.txtPaid.Text) <> 0.0)
					If flag2 Then
						Dim textObject20 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"rec"}, Nothing, Nothing, Nothing), TextObject)
						textObject20.Text = "paid: " + Conversions.ToString(Conversion.Val(Me.txtPaid.Text)) + " - rem.: " + Conversions.ToString(Conversion.Val(Me.txtRem.Text))
					End If
				Catch ex5 As Exception
				End Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
				Dim type3 As Type = Nothing
				Dim memberName2 As String = "SetDataSource"
				Dim array3 As Object() = New Object() {dataTable2}
				Dim arguments2 As Object() = array3
				Dim argumentNames2 As String() = Nothing
				Dim typeArguments2 As Type() = Nothing
				array2 = New Boolean() {True}
				NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
				If array2(0) Then
					dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
				End If
				Dim flag3 As Boolean = True
				Try
					flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("is_barcode")))
				Catch ex6 As Exception
				End Try
				Try
					flag2 = flag3
					If flag2 Then
						Dim img As Image = Code128Rendering.MakeBarcodeImage("00112233" + Me.txtNo.Text, 2, False)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable3)
						dataTable3.Columns("Logo").ColumnName = "barcode"
						dataTable3.Rows(0)("barcode") = MainClass.Image2Arr(img)
						Dim instance3 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptBarcode"}, Nothing, Nothing, Nothing)
						Dim type4 As Type = Nothing
						Dim memberName3 As String = "SetDataSource"
						Dim array4 As Object() = New Object() {dataTable3}
						Dim arguments3 As Object() = array4
						Dim argumentNames3 As String() = Nothing
						Dim typeArguments3 As Type() = Nothing
						array2 = New Boolean() {True}
						NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
						If array2(0) Then
							dataTable3 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(DataTable)), DataTable)
						End If
					End If
				Catch ex7 As Exception
				End Try
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
					Dim dataTable4 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable4)
					flag2 = (dataTable4.Rows(0)("logo") IsNot DBNull.Value)
					If flag2 Then
						dataTable4.Columns.Add("NameA")
						dataTable4.Columns.Add("NameE")
						dataTable4.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameA"))
						dataTable4.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameE"))
						Dim instance4 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
						Dim type5 As Type = Nothing
						Dim memberName4 As String = "SetDataSource"
						Dim array4 As Object() = New Object() {dataTable4}
						Dim arguments4 As Object() = array4
						Dim argumentNames4 As String() = Nothing
						Dim typeArguments4 As Type() = Nothing
						array2 = New Boolean() {True}
						NewLateBinding.LateCall(instance4, type5, memberName4, arguments4, argumentNames4, typeArguments4, array2, True)
						If array2(0) Then
							dataTable4 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(DataTable)), DataTable)
						End If
					End If
				Catch ex8 As Exception
				End Try
				Dim textObject21 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing), Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
				textObject21.Text = Me.taxno
				flag2 = (dataTable2.Rows.Count > 0)
				If flag2 Then
					Dim textObject22 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
					textObject22.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject23 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
					textObject23.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject24 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
					textObject24.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
					Dim dataTable5 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable5)
					flag2 = (dataTable.Rows.Count > 0)
					If flag2 Then
						flag = (Operators.CompareString(dataTable5.Rows(0)("Address").ToString(), "", False) <> 0)
						If flag Then
							textObject22.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable5.Rows(0)("Address")))
						End If
						flag2 = (Operators.CompareString(dataTable5.Rows(0)("tel").ToString(), "", False) <> 0)
						If flag2 Then
							textObject23.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable5.Rows(0)("tel")))
						End If
						flag2 = (Operators.CompareString(dataTable5.Rows(0)("mobile").ToString(), "", False) <> 0)
						If flag2 Then
							textObject24.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable5.Rows(0)("mobile")))
						End If
					End If
				End If
				Dim frmRptViewer As frmRptViewer = New frmRptViewer()
				Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
				frmRptViewer.Controls.Add(crystalReportViewer)
				crystalReportViewer.Dock = DockStyle.Fill
				crystalReportViewer.DisplayGroupTree = False
				crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
				frmRptViewer.WindowState = FormWindowState.Maximized
				flag2 = (type = 1)
				If flag2 Then
					frmRptViewer.Show()
					frmRptViewer.TopMost = True
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim num8 As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						Dim instance5 As Object = obj
						Dim type6 As Type = Nothing
						Dim memberName5 As String = "PrintToPrinter"
						array = New Object() {1, False, 1, num8}
						Dim arguments5 As Object() = array
						Dim argumentNames5 As String() = Nothing
						Dim typeArguments5 As Type() = Nothing
						array2 = New Boolean() {False, False, False, True}
						NewLateBinding.LateCall(instance5, type6, memberName5, arguments5, argumentNames5, typeArguments5, array2, True)
						If array2(3) Then
							num8 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
						End If
					Catch ex9 As Exception
					End Try
				End If
				num7 = Decimal.Add(num7, 1D)
			End While
			flag2 = (type = 2)
			If flag2 Then
				Me.Print_Sub()
				Me.btnSave_Click(Nothing, Nothing)
			End If
		End If
	End Sub

	Private Sub PrintRptEn(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Process")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)})
				num3 += 1
			End While
			Dim obj As Object = New rptInvEn()
			Dim instance As Object = obj
			Dim type2 As Type = Nothing
			Dim memberName As String = "SetDataSource"
			Dim array As Object() = New Object() {dataTable}
			Dim arguments As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() {True}
			NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
			If array2(0) Then
				dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
			End If
			Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"invno"}, Nothing, Nothing, Nothing), TextObject)
			textObject.Text = Me.txtNo.Text
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"date"}, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = Me.txtDate.Value.ToShortDateString()
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttime"}, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = Me.txtInvTime.Text
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"discount"}, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.txtMinusVal.Text
			Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
			textObject5.Text = Me.lblTaxVal.Text
			Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tot"}, Nothing, Nothing, Nothing), TextObject)
			textObject6.Text = Me.txtDiff.Text
			Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"user"}, Nothing, Nothing, Nothing), TextObject)
			textObject7.Text = Me.GetSalesEmpNameByInvNo()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
			Dim type3 As Type = Nothing
			Dim memberName2 As String = "SetDataSource"
			Dim array3 As Object() = New Object() {dataTable2}
			Dim arguments2 As Object() = array3
			Dim argumentNames2 As String() = Nothing
			Dim typeArguments2 As Type() = Nothing
			array2 = New Boolean() {True}
			NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
			If array2(0) Then
				dataTable2 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
			End If
			Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing), Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
			textObject8.Text = Me.taxno
			flag = (dataTable2.Rows.Count > 0)
			If flag Then
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
				textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
				Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
				textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Fax")))
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
				frmRptViewer.TopMost = True
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					Dim instance3 As Object = obj
					Dim type4 As Type = Nothing
					Dim memberName3 As String = "PrintToPrinter"
					array = New Object() {1, False, 1, num6}
					Dim arguments3 As Object() = array
					Dim argumentNames3 As String() = Nothing
					Dim typeArguments3 As Type() = Nothing
					array2 = New Boolean() {False, False, False, True}
					NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
					If array2(3) Then
						num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
					End If
				Catch ex As Exception
				End Try
				Me.btnSave_Click(Nothing, Nothing)
			End If
		End If
	End Sub

	Private Sub PrintRptA4_1(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = Me.CheckBox1.Checked
			If flag Then
				Me.hamode = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtDiff.Text) * Me._Exchangeal, 2))
			Else
				Me.hamode = ""
			End If
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("Process")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)})
				num3 += 1
			End While
			Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
			flag = (Me.dgvItems.Rows.Count < 17)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 16
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			obj = New rptInvA4_1()
			Dim instance As Object = obj
			Dim type2 As Type = Nothing
			Dim memberName As String = "SetDataSource"
			Dim array As Object() = New Object() {dataTable}
			Dim arguments As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() {True}
			NewLateBinding.LateCall(instance, type2, memberName, arguments, argumentNames, typeArguments, array2, True)
			If array2(0) Then
				dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
			End If
			flag = (Me.cmbProcType.SelectedIndex = 3)
			If flag Then
				Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
				textObject.Text = "عرض سعر"
			End If
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtNo"}, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = Me.txtNo.Text
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDate"}, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtcust"}, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.cmbClient.Text
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
					textObject5.Text = text
				End If
			Catch ex As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Me.txtTotPurch.Text
				Dim text2 As String = textObject6.Text
			Else
				Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject7.Text = Me.txtTotSale.Text
				Dim text2 As String = textObject7.Text
			End If
			Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"net"}, Nothing, Nothing, Nothing), TextObject)
			textObject8.Text = Me.txtDiff.Text
			Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"minus"}, Nothing, Nothing, Nothing), TextObject)
			textObject9.Text = Me.txtMinusVal.Text
			Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
			textObject10.Text = Me.lblTaxVal.Text
			flag = (Conversion.Val(Me.txtrec.Text) <> 0.0)
			If flag Then
				Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"rec"}, Nothing, Nothing, Nothing), TextObject)
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					textObject11.Text = "المبلغ المستلم: " + Me.txtrec.Text + " &  المتبقي: " + Me.txtRem.Text
				Else
					textObject11.Text = "Rec. Value: " + Me.txtrec.Text + " -  Reminder: " + Me.txtRem.Text
				End If
			End If
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
				If flag Then
					Dim streamReader As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
					Dim left As String = streamReader.ReadLine()
					Dim left2 As String = streamReader.ReadLine()
					streamReader.Close()
					flag = (Operators.CompareString(left, "0", False) = 0)
					If flag Then
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {0}, Nothing, Nothing, Nothing), Nothing, "SectionFormat", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EnableSuppress", New Object() {True}, Nothing, Nothing, False, True)
					End If
					flag = (Operators.CompareString(left2, "0", False) = 0)
					If flag Then
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {6}, Nothing, Nothing, Nothing), Nothing, "SectionFormat", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EnableSuppress", New Object() {True}, Nothing, Nothing, False, True)
					End If
				End If
			Catch ex2 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim num8 As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					Dim instance2 As Object = obj
					Dim type3 As Type = Nothing
					Dim memberName2 As String = "PrintToPrinter"
					Dim array3 As Object() = New Object() {1, False, 1, num8}
					Dim arguments2 As Object() = array3
					Dim argumentNames2 As String() = Nothing
					Dim typeArguments2 As Type() = Nothing
					array2 = New Boolean() {False, False, False, True}
					NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
					If array2(3) Then
						num8 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(3)), GetType(Integer)))
					End If
				Catch ex3 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Hankook(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 13)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 12
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4Hankook As rptInvA4Hankook = New rptInvA4Hankook()
			rptInvA4Hankook.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject6 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject6.Text = text5
				Else
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex3 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject7 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject7.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject8 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject8.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject9 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject9.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject10 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject10.Text = Me.txtMinusVal.Text
			Try
				Dim textObject11 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("ar1"), TextObject)
				textObject11.Text = "فقط  " + Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير"
			Catch ex4 As Exception
			End Try
			Dim textObject12 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject12.Text = Me.lblTaxVal.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Hankook
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Hankook.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex5 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4ROKN(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn11")
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				dataRow(1) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(2) = text3
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(7) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 14)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 13
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4Rokn As rptInvA4Rokn = New rptInvA4Rokn()
			rptInvA4Rokn.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject10 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject10.Text = Me.GetEmpName(MainClass.EmpNo)
			Catch ex7 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject11 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject12 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject13 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex8 As Exception
			End Try
			Dim textObject14 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject15 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject15.Text = Me.txtMinusVal.Text
			Try
				Dim textObject16 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject16.Text = "فقط  " + Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير"
			Catch ex9 As Exception
			End Try
			Dim textObject17 As TextObject = CType(rptInvA4Rokn.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject17.Text = Me.lblTaxVal.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Rokn
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Rokn.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4ALREDA(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 11)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 10
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4ALREDA As rptInvA4ALREDA = New rptInvA4ALREDA()
			rptInvA4ALREDA.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject10 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject10.Text = Me.GetEmpName(MainClass.EmpNo)
			Catch ex7 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject11 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject12 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject13 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex8 As Exception
			End Try
			Dim textObject14 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject15 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject15.Text = Me.txtMinusVal.Text
			Try
				Dim textObject16 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject16.Text = "فقط  " + Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير"
			Catch ex9 As Exception
			End Try
			Dim textObject17 As TextObject = CType(rptInvA4ALREDA.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject17.Text = Me.lblTaxVal.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4ALREDA
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4ALREDA.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Lgein(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 11)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 10
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4Hankook As rptInvA4Hankook = New rptInvA4Hankook()
			rptInvA4Hankook.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex7 As Exception
			End Try
			Dim textObject13 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = "فقط  " + Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject16 As TextObject = CType(rptInvA4Hankook.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject16.Text = Me.lblTaxVal.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Hankook
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Hankook.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex9 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Aseel(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Aseel As rptInvA4Aseel = New rptInvA4Aseel()
			rptInvA4Aseel.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Dim text5 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text5 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex7 As Exception
			End Try
			Dim textObject13 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = "فقط  " + Number2Arabic.ameral(textObject13.Text) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject16 As TextObject = CType(rptInvA4Aseel.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject16.Text = Me.lblTaxVal.Text
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text5, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Aseel.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Aseel
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Aseel.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4WhiteStone(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
				End If
				dataRow(0) = value
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				dataRow(1) = text2
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 12)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 11
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4WhiteStone As rptInvA4WhiteStone = New rptInvA4WhiteStone()
			rptInvA4WhiteStone.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim textObject2 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("branch"), TextObject)
				textObject2.Text = Me.GetBranchName(MainClass.BranchNo)
				Dim text3 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text3 = "آجل"
				End If
				Dim textObject3 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject3.Text = text3
			Catch ex As Exception
			End Try
			Dim textObject4 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject4.Text = Me.txtDate.Value.ToShortDateString()
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject5 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
			textObject5.Text = Me.txtInvTime.Text
			Dim textObject6 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject6.Text = Me.cmbClient.Text
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text4 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					Dim textObject7 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
					textObject7.Text = text4
				End If
			Catch ex2 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject8 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject8.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject9 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject9.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject10 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Try
				Dim textObject11 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject11.Text = "فقط  " + Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير"
			Catch ex3 As Exception
			End Try
			Dim textObject12 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject12.Text = Me.txtMinusVal.Text
			Try
				Dim textObject13 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("ar1"), TextObject)
				textObject13.Text = "فقط  " + Number2Arabic.ameral(Me.txtTotSale.Text) + "  لاغير"
			Catch ex4 As Exception
			End Try
			Dim textObject14 As TextObject = CType(rptInvA4WhiteStone.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject14.Text = Me.lblTaxVal.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4WhiteStone
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4WhiteStone.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex5 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA5Faisal(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA5Faisal As rptInvA5Faisal = New rptInvA5Faisal()
			rptInvA5Faisal.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex7 As Exception
			End Try
			Dim textObject13 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = "فقط  " + Number2Arabic.ameral(textObject13.Text) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject16 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject16.Text = Me.lblTaxVal.Text
			Try
				flag = (Me.cmbType.SelectedIndex = 1)
				If flag Then
					Dim textObject17 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("paytype"), TextObject)
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) <> 0.0)
					If flag Then
						textObject17.Text = "متنوع"
						Dim textObject18 As TextObject = CType(rptInvA5Faisal.ReportDefinition.Sections(4).ReportObjects("pay"), TextObject)
						textObject18.Text = "كاش = " + Me.txtCash.Text + "   -   شبكة = " + Me.txtNetwork.Text
					Else
						flag = (Conversion.Val(Me.txtCash.Text) <> 0.0)
						If flag Then
							textObject17.Text = "كاش"
						Else
							flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
							If flag Then
								textObject17.Text = "شبكة"
							End If
						End If
					End If
				End If
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA5Faisal
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA5Faisal.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	'///////////////////////////////
	Private Sub PrintRptA5(printType As Integer)
		' التحقق من وجود عناصر للطباعة
		If Me.dgvItems.Rows.Count = 0 Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "",
					   MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
			Return
		End If

		' إعداد البيانات الأساسية للطباعة
		PreparePrintingData()

		' إنشاء مصدر بيانات للتقرير
		Dim reportDataTable As DataTable = CreateReportDataTable()

		' ملء البيانات في الجدول
		PopulateReportDataTable(reportDataTable)

		' إنشاء وعرض التقرير
		Dim reportDocument As ReportDocument = CreateAndConfigureReport(reportDataTable)

		' عرض التقرير أو طباعته
		DisplayOrPrintReport(reportDocument, printType)
	End Sub

	' ========== الدوال المساعدة ==========

	''' <summary>
	''' إعداد البيانات الأساسية للطباعة
	''' </summary>
	Private Sub PreparePrintingData()
		' حساب hamode إذا كان CheckBox1 محدداً
		If Me.CheckBox1.Checked Then
			Me.hamode = String.Format("{0:#,##.##}",
			Math.Round(Convert.ToDouble(Me.txtDiff.Text) * Me._Exchangeal, 2))
		Else
			Me.hamode = ""
		End If

		' تحميل رقم الفاتورة إذا كانت جديدة
		If Me.ProcCode = -1 Then
			Me.LoadInvNo()
		End If
	End Sub

	''' <summary>
	''' إنشاء جدول بيانات للتقرير
	''' </summary>
	Private Function CreateReportDataTable() As DataTable
		Dim dataTable As New DataTable()

		' إضافة الأعمدة بناءً على الإعدادات
		If Me._ShowBarcode Then
			dataTable.Columns.Add("DataColumn1") ' للباركود
		End If

		' الأعمدة الأساسية
		dataTable.Columns.Add("Currency1")   ' اسم العملة
		dataTable.Columns.Add("Currency2")   ' الوحدة
		dataTable.Columns.Add("Value1")      ' القيمة 1
		dataTable.Columns.Add("quan")        ' الكمية
		dataTable.Columns.Add("Price")       ' السعر
		dataTable.Columns.Add("Value2")      ' القيمة 2

		' الأعمدة الاختيارية بناءً على مرئية الأعمدة في DataGridView
		If Me.dgvItems.Columns(11).Visible Then
			dataTable.Columns.Add("discount") ' الخصم
		End If

		If Me.dgvItems.Columns(13).Visible Then
			dataTable.Columns.Add("tot1")     ' الإجمالي 1
		End If

		If Me.dgvItems.Columns(14).Visible Then
			dataTable.Columns.Add("taxperc")  ' نسبة الضريبة
		End If

		dataTable.Columns.Add("tot2")         ' الإجمالي 2

		Return dataTable
	End Function

	''' <summary>
	''' ملء جدول بيانات التقرير
	''' </summary>
	Private Sub PopulateReportDataTable(dataTable As DataTable)
		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			Dim dataRow As DataRow = dataTable.NewRow()

			' ملء البيانات الأساسية
			FillReportRowData(dataRow, i)

			' إضافة الصف إلى الجدول
			dataTable.Rows.Add(dataRow)
		Next
	End Sub

	''' <summary>
	''' ملء بيانات صف التقرير
	''' </summary>
	Private Sub FillReportRowData(dataRow As DataRow, rowIndex As Integer)
		' الباركود (إذا كان مفعلاً)
		If Me._ShowBarcode Then
			dataRow("DataColumn1") = GetCurrencyBarcode(rowIndex)
		End If

		' اسم العملة مع الإضافات
		Dim currencyName As String = Me.dgvItems.Rows(rowIndex).Cells(2).Value.ToString()
		Dim additions As String = Me.dgvItems.Rows(rowIndex).Cells(18).Value.ToString()

		If Not String.IsNullOrEmpty(additions) Then
			currencyName = currencyName & " - " & additions
		End If

		dataRow("Currency1") = currencyName

		' باقي البيانات
		dataRow("Currency2") = Me.dgvItems.Rows(rowIndex).Cells(3).Value
		dataRow("Value1") = Me.dgvItems.Rows(rowIndex).Cells(4).Value
		dataRow("quan") = Me.dgvItems.Rows(rowIndex).Cells(6).Value
		dataRow("Price") = Me.dgvItems.Rows(rowIndex).Cells(7).Value
		dataRow("Value2") = Me.dgvItems.Rows(rowIndex).Cells(8).Value

		' البيانات الاختيارية
		If Me.dgvItems.Columns(11).Visible Then
			dataRow("discount") = Me.dgvItems.Rows(rowIndex).Cells(11).Value
		End If

		If Me.dgvItems.Columns(13).Visible Then
			dataRow("tot1") = Me.dgvItems.Rows(rowIndex).Cells(13).Value
		End If

		If Me.dgvItems.Columns(14).Visible Then
			dataRow("taxperc") = Me.dgvItems.Rows(rowIndex).Cells(14).Value
		End If

		dataRow("tot2") = Me.dgvItems.Rows(rowIndex).Cells(16).Value
	End Sub

	''' <summary>
	''' الحصول على الباركود للعملة
	''' </summary>
	Private Function GetCurrencyBarcode(rowIndex As Integer) As String
		Dim currencyId As Object = Me.dgvItems.Rows(rowIndex).Cells(9).Value

		Dim query As String = $"SELECT barcode FROM Currencies WHERE id = {currencyId}"

		Using adapter As New SqlDataAdapter(query, Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Return dt.Rows(0)("barcode").ToString()
			End If
		End Using

		Return String.Empty
	End Function

	''' <summary>
	''' إنشاء وتكوين التقرير
	''' </summary>
	Private Function CreateAndConfigureReport(dataTable As DataTable) As ReportDocument
		' تحديد نوع التقرير (عربي أو إنجليزي)
		Dim reportDocument As ReportDocument

		If Me.rdPrintAr.Checked Then
			reportDocument = New rptInvA5()
		Else
			reportDocument = New rptInvA5EN()
		End If

		' تعيين مصدر البيانات
		reportDocument.SetDataSource(dataTable)

		' تكوين التقرير
		ConfigureReportLayout(reportDocument)
		SetReportParameters(reportDocument)
		LoadReportHeaderData(reportDocument)
		ApplyPrintingSettings(reportDocument)

		Return reportDocument
	End Function

	''' <summary>
	''' تكوين تخطيط التقرير
	''' </summary>
	Private Sub ConfigureReportLayout(reportDocument As ReportDocument)
		Try
			' التحكم في ظهور الخطوط بناءً على ظهور الأعمدة
			Dim section = reportDocument.ReportDefinition.Sections(1)

			Dim line7 As LineObject = CType(section.ReportObjects("Line7"), LineObject)
			Dim line8 As LineObject = CType(section.ReportObjects("Line8"), LineObject)
			Dim line9 As LineObject = CType(section.ReportObjects("Line9"), LineObject)
			Dim line10 As LineObject = CType(section.ReportObjects("Line10"), LineObject)

			If Not Me.dgvItems.Columns(11).Visible Then
				line8.LineStyle = LineStyle.NoLine
			End If

			If Not Me.dgvItems.Columns(13).Visible Then
				line9.LineStyle = LineStyle.NoLine
			End If

			If Not Me.dgvItems.Columns(14).Visible Then
				line10.LineStyle = LineStyle.NoLine
			End If

			' تكوين الباركود
			If Not Me._ShowBarcode Then
				Dim line14 As LineObject = CType(section.ReportObjects("Line14"), LineObject)
				Dim line17 As LineObject = CType(section.ReportObjects("Line17"), LineObject)
				Dim text6 As TextObject = CType(section.ReportObjects("Text6"), TextObject)
				Dim currency11 As FieldObject = CType(section.ReportObjects("Currency11"), FieldObject)

				line14.LineStyle = LineStyle.NoLine
				line17.LineStyle = LineStyle.NoLine
				text6.Width = 4560
				currency11.Width = 4560
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error configuring report layout: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' تعيين معاملات التقرير
	''' </summary>
	Private Sub SetReportParameters(reportDocument As ReportDocument)
		' المعلومات الأساسية للفاتورة
		SetTextObject(reportDocument, "txtNo", Me.txtNo.Text)
		SetTextObject(reportDocument, "txtDate", Me.txtDate.Value.ToShortDateString())
		SetTextObject(reportDocument, "txtTime", Me.txtInvTime.Text)
		SetTextObject(reportDocument, "txtcust", Me.cmbClient.Text)

		' معلومات العميل الإضافية
		Try
			SetTextObject(reportDocument, "branch", GetBranchName(MainClass.BranchNo))
			SetTextObject(reportDocument, "custtel", GetCustTel(Conversions.ToInteger(Me.cmbClient.SelectedValue)))

			Dim invoiceType As String = If(Me.cmbType.SelectedIndex = 0, "آجل", "نقدي")
			SetTextObject(reportDocument, "invtype", invoiceType)

			' الرقم الضريبي
			Dim taxLabel As String = If(MainClass.Language = "ar", "الرقم الضريبي", "Tax No.")
			SetTextObject(reportDocument, "lbltaxno", taxLabel)

			Dim customerTaxNo As String = GetCustomerTaxNo()
			If Not String.IsNullOrEmpty(customerTaxNo) Then
				SetTextObject(reportDocument, "tax_no", customerTaxNo)
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error setting customer parameters: {ex.Message}")
		End Try

		' القيم المالية
		Dim totalAmount As Double = If(Me.InvProc = 1,
								   Conversion.Val(Me.txtTotPurch.Text),
								   Conversion.Val(Me.txtTotSale.Text))

		SetTextObject(reportDocument, "txtSum", Math.Round(totalAmount, 2).ToString())
		SetTextObject(reportDocument, "net", Math.Round(Conversion.Val(Me.txtDiff.Text), 2).ToString())
		SetTextObject(reportDocument, "minus", Me.txtMinusVal.Text)
		SetTextObject(reportDocument, "tax", Me.lblTaxVal.Text)

		' النصوص العربية (المبالغ كتابة)
		Try
			SetTextObject(reportDocument, "ar2", "فقط  " +
				Number2Arabic.ameral(Me.txtDiff.Text) + "  لاغير")
			SetTextObject(reportDocument, "ar1", "فقط  " +
				Number2Arabic.ameral(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 2).ToString()) +
				"  لاغير")
		Catch ex As Exception
			Debug.WriteLine($"Error setting Arabic amounts: {ex.Message}")
		End Try

		' معلومات الدفع للفواتير الآجلة
		Try
			If Me.cmbType.SelectedIndex = 0 AndAlso Conversion.Val(Me.txtPaid.Text) <> 0.0 Then
				Dim paidText As String = $"المدفوع: {Conversion.Val(Me.txtPaid.Text)} - المتبقي: {Conversion.Val(Me.txtRem.Text)}"
				SetTextObject(reportDocument, "paid", paidText)
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error setting payment info: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' تحميل بيانات رأس التقرير
	''' </summary>
	Private Sub LoadReportHeaderData(reportDocument As ReportDocument)
		Try
			' بيانات المؤسسة
			Dim foundationData As DataTable = GetFoundationData()
			reportDocument.Subreports("rptHeader").SetDataSource(foundationData)

			' الشعار إذا كان موجوداً
			LoadBranchLogo(reportDocument, foundationData)

			' الباركود إذا كان مفعلاً
			LoadBarcodeIfEnabled(reportDocument)

			' تعيين معلمات إضافية
			SetHeaderParameters(reportDocument, foundationData)

			' ملاحظات الفاتورة
			Try
				reportDocument.SetParameterValue("note", Me.TextBox1.Text)
			Catch ex As Exception
				Debug.WriteLine($"Error setting note parameter: {ex.Message}")
			End Try

		Catch ex As Exception
			Debug.WriteLine($"Error loading report header: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' الحصول على بيانات المؤسسة
	''' </summary>
	Private Function GetFoundationData() As DataTable
		Dim query As String = "SELECT * FROM Foundation"

		Using adapter As New SqlDataAdapter(query, Me.conn)
			Dim dt As New DataTable()
			adapter.Fill(dt)
			Return dt
		End Using
	End Function

	''' <summary>
	''' تحميل شعار الفرع
	''' </summary>
	Private Sub LoadBranchLogo(reportDocument As ReportDocument, foundationData As DataTable)
		Try
			Dim query As String = $"SELECT img as logo FROM branches WHERE id = {MainClass.BranchNo}"

			Using adapter As New SqlDataAdapter(query, Me.conn)
				Dim logoData As New DataTable()
				adapter.Fill(logoData)

				If logoData.Rows.Count > 0 AndAlso Not IsDBNull(logoData.Rows(0)("logo")) Then
					' إضافة الأعمدة المطلوبة
					logoData.Columns.Add("NameA")
					logoData.Columns.Add("NameE")
					logoData.Columns.Add("FieldA")
					logoData.Columns.Add("FieldE")

					' نسخ البيانات من foundationData
					logoData.Rows(0)("NameA") = foundationData.Rows(0)("NameA")
					logoData.Rows(0)("NameE") = foundationData.Rows(0)("NameE")
					logoData.Rows(0)("FieldA") = foundationData.Rows(0)("FieldA")
					logoData.Rows(0)("FieldE") = foundationData.Rows(0)("FieldE")

					reportDocument.Subreports("rptHeader").SetDataSource(logoData)
				End If
			End Using
		Catch ex As Exception
			Debug.WriteLine($"Error loading branch logo: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' تحميل الباركود إذا كان مفعلاً
	''' </summary>
	Private Sub LoadBarcodeIfEnabled(reportDocument As ReportDocument)
		Try
			Dim isBarcodeEnabled As Boolean = True

			' التحقق من إعدادات الباركود
			Dim foundationData As DataTable = GetFoundationData()
			If foundationData.Rows.Count > 0 Then
				isBarcodeEnabled = Convert.ToBoolean(foundationData.Rows(0)("is_barcode"))
			End If

			If isBarcodeEnabled Then
				' إنشاء صورة الباركود
				Dim barcodeImage As Image = Code128Rendering.MakeBarcodeImage(
				"00112233" + Me.txtNo.Text, 2, False)

				' إعداد بيانات الباركود
				Dim barcodeData As DataTable = foundationData.Copy()
				barcodeData.Columns("Logo").ColumnName = "barcode"
				barcodeData.Rows(0)("barcode") = MainClass.Image2Arr(barcodeImage)

				reportDocument.Subreports("rptBarcode").SetDataSource(barcodeData)
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error loading barcode: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' تعيين معلمات رأس التقرير
	''' </summary>
	Private Sub SetHeaderParameters(reportDocument As ReportDocument, foundationData As DataTable)
		Try
			' الرقم الضريبي ورقم السجل التجاري
			Dim headerSubreport = reportDocument.Subreports("rptHeader")

			' استخدام SetSubreportTextObject للتقرير الفرعي
			SetSubreportTextObject(headerSubreport, "tax_no", Me.taxno)
			SetSubreportTextObject(headerSubreport, "cr", foundationData.Rows(0)("bsn_no").ToString())

			' معلومات الاتصال والعنوان
			If foundationData.Rows.Count > 0 Then
				SetSubreportTextObject(headerSubreport, "txtAddress", foundationData.Rows(0)("Address").ToString())
				SetSubreportTextObject(headerSubreport, "txtAddressen", foundationData.Rows(0)("AddressEN").ToString())
				SetSubreportTextObject(headerSubreport, "txttel", foundationData.Rows(0)("tel").ToString())
				SetSubreportTextObject(headerSubreport, "txtMobile", foundationData.Rows(0)("Mobile").ToString())

				' رسالة خاصة للفواتير
				If Me.InvProc = 2 Then
					reportDocument.SetParameterValue("msg", foundationData.Rows(0)("msg"))
				End If
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error setting header parameters: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' تطبيق إعدادات الطباعة من الملف
	''' </summary>
	Private Sub ApplyPrintingSettings(reportDocument As ReportDocument)
		Try
			Dim settingsFile As String = System.Windows.Forms.Application.StartupPath + "\\invprint.txt"

			If File.Exists(settingsFile) Then
				Using reader As New StreamReader(settingsFile)
					Dim suppressSubreport As String = reader.ReadLine()
					Dim suppressSection As String = reader.ReadLine()

					' التحكم في ظهور التقرير الفرعي
					If suppressSubreport = "0" Then
						Dim subreport As SubreportObject =
						CType(reportDocument.ReportDefinition.ReportObjects("Subreport1"),
							  SubreportObject)
						subreport.ObjectFormat.EnableSuppress = True
					End If

					' التحكم في ظهور القسم السادس
					If suppressSection = "0" Then
						reportDocument.ReportDefinition.Sections(6).SectionFormat.EnableSuppress = True
					End If
				End Using
			End If
		Catch ex As Exception
			Debug.WriteLine($"Error applying printing settings: {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' عرض التقرير أو طباعته
	''' </summary>
	Private Sub DisplayOrPrintReport(reportDocument As ReportDocument, printType As Integer)
		' حفظ الفاتورة أولاً
		Me.btnSave_Click(Nothing, Nothing)

		' عرض التقرير أو طباعته
		If printType = 1 Then
			DisplayReport(reportDocument)
		Else
			PrintReport(reportDocument)
		End If
	End Sub

	''' <summary>
	''' عرض التقرير في نافذة
	''' </summary>
	Private Sub DisplayReport(reportDocument As ReportDocument)
		Dim frmRptViewer As New frmRptViewer()
		Dim viewerForm As New frmRptViewer()
		Dim crystalViewer As New CrystalReportViewer()

		viewerForm.Controls.Add(crystalViewer)
		crystalViewer.Dock = DockStyle.Fill
		crystalViewer.DisplayGroupTree = False
		crystalViewer.ReportSource = reportDocument

		viewerForm.WindowState = FormWindowState.Maximized
		viewerForm.Show()
	End Sub

	''' <summary>
	''' طباعة التقرير مباشرة
	''' </summary>
	Private Sub PrintReport(reportDocument As ReportDocument)
		Try
			Dim viewer As New CrystalReportViewer()
			viewer.ReportSource = reportDocument

			' الانتقال إلى آخر صفحة للحصول على العدد الإجمالي للصفحات
			viewer.ShowLastPage()
			Dim totalPages As Integer = viewer.GetCurrentPageNumber()

			' العودة إلى الصفحة الأولى
			viewer.ShowFirstPage()

			' الطباعة
			reportDocument.PrintToPrinter(1, False, 1, totalPages)
		Catch ex As Exception
			MessageBox.Show($"خطأ في الطباعة: {ex.Message}", "خطأ",
					   MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	''' <summary>
	''' دالة مساعدة: تعيين نص لكائن نصي في التقرير الرئيسي
	''' </summary>
	Private Sub SetTextObject(reportDocument As ReportDocument, objectName As String, text As String)
		Try
			Dim textObject As TextObject =
			CType(reportDocument.ReportDefinition.Sections(1).ReportObjects(objectName),
				  TextObject)
			textObject.Text = text
		Catch ex As Exception
			Debug.WriteLine($"Error setting text object '{objectName}': {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' دالة مساعدة: تعيين نص لكائن نصي في تقرير فرعي
	''' </summary>
	Private Sub SetSubreportTextObject(subReport As ReportDocument, objectName As String, text As String)
		Try
			Dim textObject As TextObject =
			CType(subReport.ReportDefinition.Sections(1).ReportObjects(objectName),
				  TextObject)
			textObject.Text = text
		Catch ex As Exception
			Debug.WriteLine($"Error setting subreport text object '{objectName}': {ex.Message}")
		End Try
	End Sub

	''' <summary>
	''' الحصول على الرقم الضريبي للعميل
	''' </summary>
	Private Function GetCustomerTaxNo() As String
		Try
			Dim query As String = $"SELECT tax_no FROM customers WHERE id = {Me.cmbClient.SelectedValue}"

			Using adapter As New SqlDataAdapter(query, Me.conn)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count > 0 Then
					Dim taxNo As String = dt.Rows(0)("tax_no").ToString()
					If Not String.IsNullOrEmpty(taxNo) Then
						Return taxNo
					End If
				End If
			End Using

			Return String.Empty
		Catch ex As Exception
			Debug.WriteLine($"Error getting customer tax number: {ex.Message}")
			Return String.Empty
		End Try
	End Function

	'///////////////////////////////
	'///////////////////////////////
	Public Sub PrintRptA4(type As Integer, Optional _DocType As Integer = 1, Optional _istop As Boolean = False)

	End Sub

	'///////////////////////////////
	'///////////////////////////////
	Private Sub PrintRptA4Printed(type As Integer)

	End Sub

	'///////////////////////////////

	Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
		Dim printElecInv As Boolean = Me._PrintElecInv
		If printElecInv Then
			Me.PrintRptA4(2, 2, False)
		Else
			Me.PrintRptA4(2, 1, False)
		End If
	End Sub

	Private Sub GetCustDiscBalance()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select discount_balance from Customers where id=", Me.cmbClient.SelectedValue)), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.txtDiscBalance.Text = Conversions.ToString(Math.Round(Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)(0))), 2))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GetMaintInvNo()
		Try
			Dim flag As Boolean = Me.chkMaintainance.Checked
			If flag Then
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 inv.id from inv where is_deleted=0 and (is_maint=0 or is_maint is null) and cust_id=", Me.cmbClient.SelectedValue), " order by date desc")), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.txtMaintInvId.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
				End If
			Else
				Me.txtMaintInvId.Text = ""
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Function GetCityName(_id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from cities where id=" + Conversions.ToString(_id), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
			If flag2 Then
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			Else
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
			End If
		Else
			result = ""
		End If
		Return result
	End Function

	Private Function GetAreaName(_id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from areas where id=" + Conversions.ToString(_id), Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = dataTable.Rows.Count > 0
		Dim result As String
		If flag Then
			Dim flag2 As Boolean = Operators.CompareString("" + dataTable.Rows(0)(0).ToString(), "", False) <> 0
			If flag2 Then
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			Else
				result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
			End If
		Else
			result = ""
		End If
		Return result
	End Function

	Private Sub cmbClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbClient.SelectedIndexChanged
		Dim frmChargeData As New frmChargeData()
		Dim flag As Boolean = Not Me._loaded
		If Not flag Then
			flag = Conversions.ToBoolean(Operators.AndObject(Me.InvProc = 2, Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Me.cmbClient.SelectedValue, 1, False), Operators.CompareString(Me.cmbClient.Text, "عميل عام", False) = 0), Operators.CompareString(Me.cmbClient.Text, "عميل نقدي", False) = 0), Operators.CompareString(Me.cmbClient.Text, "عميل نقدى", False) = 0)))
			If flag Then
				Me.lblCustName.Visible = True
				Me.txtCustName.Visible = True
			Else
				Me.lblCustName.Visible = False
				Me.txtCustName.Visible = False
				Me.txtCustName.Text = ""
			End If
			Dim flag2 As Boolean
			Try
				Me._chkCustTel = False
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tel,mobile,address,city,area,cust_no,tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.txtCustTel2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tel")))
					flag = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", dataTable.Rows(0)("tel")), "", False)
					If flag Then
						Me.txtCustTel2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("mobile")))
					End If
					flag = Not Me._hidetel
					If flag Then
						Me.txtCustTel.Text = Me.txtCustTel2.Text
					End If
					Try
						Me.txtCustNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("cust_no")))
					Catch ex As Exception
					End Try
					Try
						flag = (Me.InvProc = 2)
						If flag Then
							frmChargeData.txtRecCustVatNo.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax_no")))
						End If
					Catch ex2 As Exception
					End Try
					Me.txtCustAddress.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("address")))
					Dim cityName As String = Me.GetCityName(Conversions.ToInteger(dataTable.Rows(0)("city")))
					Dim areaName As String = Me.GetAreaName(Conversions.ToInteger(dataTable.Rows(0)("area")))
					flag = (Operators.CompareString(cityName, "", False) <> 0)
					If flag Then
						flag2 = (Operators.CompareString(Me.txtCustAddress.Text, "", False) <> 0)
						Dim txtCustAddress As TextBox
						If flag2 Then
							txtCustAddress = Me.txtCustAddress
							txtCustAddress.Text += "-"
						End If
						txtCustAddress = Me.txtCustAddress
						txtCustAddress.Text += cityName
					End If
					flag2 = (Operators.CompareString(areaName, "", False) <> 0)
					If flag2 Then
						flag = (Operators.CompareString(Me.txtCustAddress.Text, "", False) <> 0)
						Dim txtCustAddress As TextBox
						If flag Then
							txtCustAddress = Me.txtCustAddress
							txtCustAddress.Text += "-"
						End If
						txtCustAddress = Me.txtCustAddress
						txtCustAddress.Text += areaName
					End If
				End If
			Catch ex3 As Exception
			Finally
				Me._chkCustTel = True
			End Try
			Me.GetMaintInvNo()
			Try
				Me.ShowCustBalance()
			Catch ex4 As Exception
			End Try
			flag2 = (Me.InvProc = 2)
			If flag2 Then
				Me.GetCustDiscBalance()
			End If
		End If
	End Sub

	Private Function GetCurrencyNameEN(id As Integer) As String
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select nameEN from Currencies where id=" + Conversions.ToString(id), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Return Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Catch ex As Exception
		End Try
		Return ""
	End Function

	Private Sub Print_Sub()
		' The following expression was wrapped in a checked-statement
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			dataTable.Columns.Add()
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(9).Value), 0})
				num3 += 1
			End While
			Me.PrintToGroups(dataTable)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Printsub(dt As DataTable, _printer As String)
		Try
			Dim reportDocument As ReportDocument = New ReportDocument()
			reportDocument = New rptInvG()
			reportDocument.SetDataSource(dt)
			Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("invno"), TextObject)
			textObject.Text = Me.txtNo.Text
			Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
			textObject2.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txttime"), TextObject)
				textObject3.Text = Me.txtInvTime.Text
			Catch ex As Exception
			End Try
			Try
				Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("user"), TextObject)
				textObject4.Text = Me.GetSalesEmpNameByInvNo()
			Catch ex2 As Exception
			End Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			reportDocument.Subreports("rptHeader").SetDataSource(dataTable)
			Try
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtAddress"), TextObject)
					textObject5.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Address")))
					Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtTel"), TextObject)
					textObject6.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Tel")))
					Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtFax"), TextObject)
					textObject7.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Fax")))
				End If
			Catch ex3 As Exception
			End Try
			Try
				reportDocument.ReportDefinition.Sections(0).SectionFormat.EnableSuppress = True
				reportDocument.ReportDefinition.Sections(4).SectionFormat.EnableSuppress = True
			Catch ex4 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = reportDocument
			frmRptViewer.WindowState = FormWindowState.Maximized
			Try
				crystalReportViewer.ShowLastPage()
				Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
				crystalReportViewer.ShowFirstPage()
				reportDocument.PrintOptions.PrinterName = _printer
				reportDocument.PrintToPrinter(1, False, 1, currentPageNumber)
			Catch ex5 As Exception
			End Try
		Catch ex6 As Exception
		End Try
	End Sub

	Private Sub PrintToGroups(dtt As DataTable)
		' The following expression was wrapped in a checked-statement
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Process")
			Dim num As Integer = -1
			Dim text As String = ""
			Dim flag As Boolean = False
			Dim num2 As Integer = 0
			Dim num3 As Integer = dtt.Rows.Count - 1
			Dim num4 As Integer = num2
			Dim flag3 As Boolean
			While True
				Dim num5 As Integer = num4
				Dim num6 As Integer = num3
				If num5 > num6 Then
					Exit While
				End If
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(dtt.Rows(num4)(10), 0, False)
				If flag2 Then
					flag3 = (Operators.CompareString(text, "", False) = 0)
					If flag3 Then
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select groups.id,groups.printer from groups,currencies where groups.id=currencies.group_id and currencies.id=", dtt.Rows(num4)(9))), Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable2)
						num = Conversions.ToInteger(dataTable2.Rows(0)(0))
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						flag3 = (Operators.CompareString(text, "", False) <> 0)
						If flag3 Then
							Dim currencyNameEN As String = Me.GetCurrencyNameEN(Conversions.ToInteger(dtt.Rows(num4)(9)))
							Dim text2 As String = dtt.Rows(num4)(2).ToString()
							flag3 = (Operators.CompareString(currencyNameEN, "", False) <> 0)
							If flag3 Then
								text2 = text2 + " - " + currencyNameEN
							End If
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2 + " - ", dtt.Rows(num4)(3)))
							dataTable.Rows.Add(New Object() {text2, RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(4)), RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(1))})
							dtt.Rows(num4)(10) = 1
							flag = True
						End If
					Else
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select groups.id,groups.printer from groups,currencies where groups.id=currencies.group_id and currencies.id=", dtt.Rows(num4)(9))), Me.conn1)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						flag3 = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(0)(0), num, False)
						If flag3 Then
							Dim currencyNameEN2 As String = Me.GetCurrencyNameEN(Conversions.ToInteger(dtt.Rows(num4)(9)))
							Dim text3 As String = dtt.Rows(num4)(2).ToString()
							flag3 = (Operators.CompareString(currencyNameEN2, "", False) <> 0)
							If flag3 Then
								text3 = text3 + " - " + currencyNameEN2
							End If
							text3 = Conversions.ToString(Operators.ConcatenateObject(text3 + " - ", dtt.Rows(num4)(3)))
							dataTable.Rows.Add(New Object() {text3, RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(4)), RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(1))})
							dtt.Rows(num4)(10) = 1
							flag = True
						End If
					End If
				End If
				num4 += 1
			End While
			flag3 = flag
			If flag3 Then
				Me.Printsub(dataTable, text)
				Me.PrintToGroups(dtt)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
		Me.PrintRpt(1)
	End Sub

	Private Sub CalcBalance()
		Try
			Dim value As Integer = -1
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Code from Accounts_Index where Type=2 and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null ) and AName='", Me.cmbStock.Text, "'"}), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				value = CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
			End If
			Try
				Dim num As Double = 0.0
				Dim num2 As Double = 0.0
				Dim text As String = ""
				text = text + " and Restrictions_Sub.acc_no=" + Conversions.ToString(value)
				Dim str As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					str = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
				End If
				sqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				num += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("dept")))
				num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("credit")))
				flag = (num >= num2)
				If flag Then
					Me.txtCapital.Text = "+" + Environment.NewLine + "" + Conversions.ToString(num - num2)
				Else
					flag = (num2 > num)
					If flag Then
						Me.txtCapital.Text = "-" + Environment.NewLine + "" + Conversions.ToString(num2 - num)
					End If
				End If
			Catch ex As Exception
			End Try
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub txtSrchNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSrchNo.KeyPress
		MainClass.ISInteger(e)
	End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Dim frmCurrenciesBalances As New frmCurrenciesBalances()
		Try
			Dim flag As Boolean = Me.cmbSafe.SelectedValue IsNot Nothing
			If flag Then
				frmCurrenciesBalances.Text = "أرصدة الأصناف - " + Me.cmbSafe.Text
				frmCurrenciesBalances.CalcStock(Conversions.ToInteger(Me.cmbSafe.SelectedValue))
				frmCurrenciesBalances.Show()
				frmCurrenciesBalances.TopMost = True
				frmCurrenciesBalances.Left = 10
				frmCurrenciesBalances.Top += 80
			Else
				MessageBox.Show("اختر مخزن أولا", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbSafe.Focus()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub frmSalePurch_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
		Dim frmCurrenciesBalances As New frmCurrenciesBalances()
		Try
			Dim flag As Boolean = Not Me.ISTRialEnd
			If flag Then
				Dim flag2 As Boolean = Me.cmbProcType.SelectedIndex = 0
				If flag2 Then
					Dim flag3 As Boolean = (Me.ProcCode = -1 And Me.dgvItems.Rows.Count > 0) Or (Me.ProcCode <> -1 And Me.DGV_Count <> Me.dgvItems.Rows.Count)
					If flag3 Then
						MessageBox.Show("انت لم تحفظ الفاتورة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						e.Cancel = True
						Return
					End If
				End If
			End If
			frmCurrenciesBalances.Close()
		Catch ex As Exception
		End Try
	End Sub

	Public Sub LoadClients()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbClient.DataSource = dataTable
		Me.cmbClient.DisplayMember = "name"
		Me.cmbClient.ValueMember = "id"
		Me.cmbClient.SelectedIndex = -1
	End Sub

	Private Function GetCustBalance(_name As String) As Double
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Code from Accounts_Index where AName='", _name, "' and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null )"}), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim text As String = ""
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Restrictions_Sub.acc_no=", dataTable.Rows(0)(0))))
			Dim str As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				str = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
			End If
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from Accounts_Index where Code='", dataTable.Rows(0)(0)), "'")), Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable2)
			flag = (dataTable2.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("IValue"))) <> 0.0
				If flag2 Then
					Dim flag3 As Boolean = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Nature"))) = 1
					If flag3 Then
						num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
					Else
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
					End If
				End If
			End If
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn1)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable3)
			num += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("dept")))
			num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("credit")))
			Return Math.Round(num - num2, 3)
		Catch ex As Exception
		End Try
		Return 0.0
	End Function

	Private Sub ShowCustBalance()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Code from Accounts_Index where AName='", Me.cmbClient.Text, "' and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null )"}), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim text As String = ""
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(" and Restrictions_Sub.acc_no=", dataTable.Rows(0)(0))))
			Dim str As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				str = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
			End If
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from Accounts_Index where Code='", dataTable.Rows(0)(0)), "'")), Me.conn1)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable2)
			flag = (dataTable2.Rows.Count > 0)
			Dim flag3 As Boolean
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("IValue"))) <> 0.0
				If flag2 Then
					flag3 = (Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("Nature"))) = 1)
					If flag3 Then
						num += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
					Else
						num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("IValue")))
					End If
				End If
			End If
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn1)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable3)
			num += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("dept")))
			num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("credit")))
			flag3 = (num > num2)
			If flag3 Then
				Me.txtBalance.Text = String.Format("{0:0.#,##.##}", Math.Round(num - num2, 3))
			Else
				flag3 = (num2 > num)
				If flag3 Then
					Me.txtBalance.Text = String.Format("{0:0.#,##.##}", Math.Round(num2 - num, 3)) + "  دائن"
				Else
					flag3 = (num = num2)
					If flag3 Then
						Me.txtBalance.Text = "0"
					End If
				End If
			End If
		Catch ex As Exception
			Me.txtBalance.Text = "0"
		End Try
	End Sub

	Private Sub btnCustAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCustAdd.Click
		Dim num As Integer = -1
		Dim flag As Boolean = Me.cmbClient.SelectedValue IsNot Nothing
		If flag Then
			num = Conversions.ToInteger(Me.cmbClient.SelectedValue)
		End If
		Dim frmCustomers As frmCustomers = New frmCustomers()
		MainClass.ApplyPermissionToForm(frmCustomers)
		frmCustomers.Activate()
		frmCustomers.ShowDialog()
		Me.LoadCustomers()
		Try
			Me.cmbClient.SelectedValue = num
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
		Me.PrintRptEn(1)
	End Sub

	Private Sub ShowCalculator()
		Dim flag As Boolean = Operators.CompareString(Me.txtVal1.Text.Trim(), "", False) = 0 Or Convert.ToDouble(Me.txtVal1.Text) = 0.0
		If flag Then
			Dim frm_Calculator As Frm_Calculator = New Frm_Calculator()
			frm_Calculator.ShowDialog()
		End If
	End Sub

	Private Sub txtBarcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcode.TextChanged
		' The following expression was wrapped in a checked-statement
		Try
			Me.chkcurr = False
			Dim flag As Boolean = Operators.CompareString(Me.txtBarcode.Text.Trim(), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = False
				Me._EnteredBarcode = Me.txtBarcode.Text.Trim()
				flag = Not Me._BarcodeProcess
				If flag Then
					Me._ismezan = False
					Me.Timer1.Enabled = True
				Else
					flag = Me._ismezan
					If Not flag Then
						Me._ismezan = False
						Dim text As String = ""
						Dim flag3 As Boolean
						Try
							Dim text2 As String = Me.txtBarcode.Text.Substring(0, Me.txtBarcode.TextLength - 6)
							text = Me.txtBarcode.Text.Replace(text2, "").Replace(Environment.NewLine, "")
							text = text.Substring(0, text.Length - 1)
							text = Conversions.ToString(Conversion.Val(text) / 1000.0)
							Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select is_mezan from currencies where is_deleted=0 and barcode='" + text2 + "'", Me.conn)
							Dim dataTable As DataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							flag = (dataTable.Rows.Count > 0)
							If flag Then
								flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
								If flag3 Then
									Me._ismezan = True
									Me.txtBarcode.Text = text2
								End If
							End If
						Catch ex As Exception
						End Try
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id,group_id,unit from currencies where IS_Deleted=0 and barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag3 = (dataTable2.Rows.Count > 0)
						If flag3 Then
							flag2 = True
							Try
								Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1))
							Catch ex2 As Exception
							End Try
							Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))
							Try
								flag3 = (dataTable2.Rows(0)(2) IsNot DBNull.Value)
								If flag3 Then
									Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(2))
								Else
									flag3 = (Me.cmbUnits.Items.Count > 0)
									If flag3 Then
										Me.cmbUnits.SelectedIndex = 0
									End If
								End If
							Catch ex3 As Exception
							End Try
							flag3 = (Me.rdAuto.Checked And Me._IsUpdateDG)
							If flag3 Then
								Me.CalcPrice()
								Dim frm_Calculator As Frm_Calculator = New Frm_Calculator()
								frm_Calculator.TextBox1.Text = "1"
								flag3 = Me._ismezan
								If flag3 Then
									frm_Calculator.TextBox1.Text = text
								End If
								frm_Calculator.ShowDialog()
								Me.txtVal1.Text = Conversions.ToString(MySettingsProperty.Settings.QTY)
								Me.Add2DG()
								Me.txtBarcode.Focus()
							Else
								flag3 = (Me.rdAuto.Checked And Not Me._IsUpdateDG)
								If flag3 Then
									flag = Me._ismezan
									If flag Then
										Me.txtVal1.Text = text
									Else
										Me.txtVal1.Text = "1"
									End If
									Me.Add2DG()
									Me.txtBarcode.Focus()
								Else
									Me.txtVal1.Text = "1"
								End If
							End If
						Else
							sqlDataAdapter2 = New SqlDataAdapter("select currencies.id,group_id,curr_units.unit from currencies,curr_units where currencies.id=curr_units.curr and currencies.IS_Deleted=0 and curr_units.barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
							dataTable2 = New DataTable()
							sqlDataAdapter2.Fill(dataTable2)
							flag3 = (dataTable2.Rows.Count > 0)
							If flag3 Then
								flag2 = True
								Me._loaded = False
								Try
									Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1))
								Catch ex4 As Exception
								End Try
								Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))
								Try
									flag3 = (dataTable2.Rows(0)(2) IsNot DBNull.Value)
									If flag3 Then
										Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(2))
									Else
										flag3 = (Me.cmbUnits.Items.Count > 0)
										If flag3 Then
											Me.cmbUnits.SelectedIndex = 0
										End If
									End If
								Catch ex5 As Exception
								End Try
								Try
									Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price,sale_price,tax,discount from Currencies  where id= ", Me.cmbCurrency.SelectedValue)), Me.conn)
									Dim dataTable3 As DataTable = New DataTable()
									sqlDataAdapter3.Fill(dataTable3)
									flag3 = (Me.InvProc = 2 Or (Me.InvProc = 1 And Me.chkIsVAT.Checked And Me.cmbProcType.SelectedIndex <> 2))
									If flag3 Then
										Me.txtCurrTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)(2)))
									End If
								Catch ex6 As Exception
								End Try
								Me._loaded = True
								Me.cmbUnits_SelectedIndexChanged(Nothing, Nothing)
								flag3 = (Me.rdAuto.Checked And Me._IsUpdateDG)
								If flag3 Then
									Me.CalcPrice()
									Dim frm_Calculator2 As Frm_Calculator = New Frm_Calculator()
									frm_Calculator2.TextBox1.Text = "1"
									flag3 = Me._ismezan
									If flag3 Then
										frm_Calculator2.TextBox1.Text = text
									End If
									frm_Calculator2.ShowDialog()
									Me.txtVal1.Text = Conversions.ToString(MySettingsProperty.Settings.QTY)
									Me.Add2DG()
									Me.txtBarcode.Focus()
								Else
									flag3 = (Me.rdAuto.Checked And Not Me._IsUpdateDG)
									If flag3 Then
										flag = Me._ismezan
										If flag Then
											Me.txtVal1.Text = text
										Else
											Me.txtVal1.Text = "1"
										End If
										Me.Add2DG()
										Me.txtBarcode.Focus()
									Else
										Me.txtVal1.Text = "1"
									End If
								End If
							Else
								sqlDataAdapter2 = New SqlDataAdapter("select currencies.id,group_id,currencies.unit from currencies,curr_barcodes where currencies.id=curr_barcodes.curr and currencies.IS_Deleted=0 and curr_barcodes.barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
								dataTable2 = New DataTable()
								sqlDataAdapter2.Fill(dataTable2)
								flag3 = (dataTable2.Rows.Count > 0)
								If flag3 Then
									flag2 = True
									Try
										Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1))
									Catch ex7 As Exception
									End Try
									Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))
									Try
										flag3 = (dataTable2.Rows(0)(2) IsNot DBNull.Value)
										If flag3 Then
											Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(2))
										Else
											flag3 = (Me.cmbUnits.Items.Count > 0)
											If flag3 Then
												Me.cmbUnits.SelectedIndex = 0
											End If
										End If
									Catch ex8 As Exception
									End Try
									flag3 = (Me.rdAuto.Checked And Me._IsUpdateDG)
									If flag3 Then
										Me.CalcPrice()
										Dim frm_Calculator3 As Frm_Calculator = New Frm_Calculator()
										frm_Calculator3.TextBox1.Text = "1"
										flag3 = Me._ismezan
										If flag3 Then
											frm_Calculator3.TextBox1.Text = text
										End If
										frm_Calculator3.ShowDialog()
										Me.txtVal1.Text = Conversions.ToString(MySettingsProperty.Settings.QTY)
										Me.Add2DG()
										Me.txtBarcode.Focus()
									Else
										flag3 = (Me.rdAuto.Checked And Not Me._IsUpdateDG)
										If flag3 Then
											flag = Me._ismezan
											If flag Then
												Me.txtVal1.Text = text
											Else
												Me.txtVal1.Text = "1"
											End If
										Else
											Me.txtVal1.Text = "1"
										End If
									End If
									Me._loaded = True
								End If
							End If
						End If
						flag3 = (Not flag2 And Me._BarcodeReadType = 1)
						If flag3 Then
							Dim dialogResult As DialogResult = MessageBox.Show("رقم الباركود غير مسجل، هل تريد تسجيل صنف جديد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
							flag3 = (dialogResult = DialogResult.No)
							If flag3 Then
								Me.txtBarcode.Text = ""
								Me.txtBarcode.Focus()
							Else
								Dim frmcurrency As frmcurrency = New frmcurrency()
								frmcurrency.txtBarcode.Text = Me.txtBarcode.Text
								frmcurrency.txtSymbol.Focus()
								frmcurrency.ShowDialog()
								Me._loaded = False
								Me.LoadAllCurrency()
								Me._loaded = True
								Me.txtBarcode_TextChanged(Nothing, Nothing)
							End If
						End If
					End If
				End If
			End If
		Catch ex9 As Exception
		Finally
			Me.chkcurr = True
			Me._BarcodeProcess = False
		End Try
	End Sub

	Private Sub cmbGroups_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGroups.SelectedIndexChanged
		Try
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMinusPerc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusPerc.TextChanged
		Try
			Dim flag As Boolean = Me.dochange
			If flag Then
				Try
					Me.dochange = False
					flag = (Me.InvProc = 1)
					If flag Then
						Me.txtMinusVal.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusPerc.Text) / 100.0 * Convert.ToDouble(Me.txtTotPurch.Text), 2))
						Dim num As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * Convert.ToDouble(Me.txtTotPurch.Text), 2)
						Me.txtDiff.Text = Conversions.ToString(Convert.ToDouble(Me.txtTotPurch.Text) - Convert.ToDouble(Me.txtMinusVal.Text) + num)
					Else
						Me.txtMinusVal.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusPerc.Text) / 100.0 * Convert.ToDouble(Me.txtTotSale.Text), 2))
						Dim num2 As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * Convert.ToDouble(Me.txtTotSale.Text), 2)
						Me.txtDiff.Text = Conversions.ToString(Convert.ToDouble(Me.txtTotSale.Text) - Convert.ToDouble(Me.txtMinusVal.Text) + num2)
					End If
				Catch ex As Exception
				End Try
				Me.dochange = True
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub txtMinusVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusVal.TextChanged
		Dim flag As Boolean = Me.dochange2
		If flag Then
			Try
				Try
					Dim flag2 As Boolean = Me.InvProc = 1
					If flag2 Then
						Me.txtDiscPerc.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotPurch.Text) * 100.0, 2))
						Me.txtDiscPerc1.Text = Conversions.ToString(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotPurch.Text) * 100.0)
					Else
						Me.txtDiscPerc.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotSale.Text) * 100.0, 2))
						Me.txtDiscPerc1.Text = Conversions.ToString(Convert.ToDouble(Me.txtMinusVal.Text) / Convert.ToDouble(Me.txtTotSale.Text) * 100.0)
					End If
				Catch ex As Exception
				End Try
				Try
					Me.CalcDisc()
					Me._lastdisc = New Decimal(Conversion.Val(Me.txtDiscPerc.Text))
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End If
	End Sub

	Private Sub cmd135_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd135.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd135.Text
	End Sub

	Private Sub cmd2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd2.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd2.Text
	End Sub

	Private Sub cmd3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd3.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd3.Text
	End Sub

	Private Sub cmd4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd4.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd4.Text
	End Sub

	Private Sub cmd5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd5.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd5.Text
	End Sub

	Private Sub cmd6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd6.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd6.Text
	End Sub

	Private Sub cmd7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd7.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd7.Text
	End Sub

	Private Sub cmd8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd8.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd8.Text
	End Sub

	Private Sub cmd9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd9.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd9.Text
	End Sub

	Private Sub cmd0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd0.Click
		Dim txtVal As TextBox = Me.txtVal1
		txtVal.Text += Me.cmd0.Text
	End Sub

	Private Sub cmdClearAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClearAll.Click
		Me.txtVal1.Text = String.Empty
		Me.valHolder1 = 0.0
		Me.valHolder2 = 0.0
		Me.calcFunc = String.Empty
		Me.hasDecimal = False
	End Sub

	Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbType.SelectedIndexChanged
		Dim flag As Boolean = Me.cmbType.SelectedIndex = 0
		If flag Then
			Me.Panel1.Visible = True
		Else
			Me.Panel1.Visible = False
		End If
		flag = (Me.cmbType.SelectedIndex = 0)
		If flag Then
			Me.pnlPay2.Visible = False
		Else
			Me.pnlPay2.Visible = True
		End If
	End Sub

	Private Sub txtPaid_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPaid.TextChanged
		Try
			Me.txtRem.Text = Conversions.ToString(Convert.ToDouble(Me.txtDiff.Text) - Convert.ToDouble(Me.txtPaid.Text))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub rdAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdAuto.CheckedChanged
		Try
			Dim checked As Boolean = Me.rdAuto.Checked
			If checked Then
				Me.txtBarcode.Focus()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub cmbUnits_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbUnits.SelectedIndexChanged
		Try
			Dim flag As Boolean = Not Me._loaded
			If Not flag Then
				Me.txtExchangeVal.Text = ""
				Me.txtExchangeValD.Text = ""
				Me.txtVal2.Text = ""
				Me.txtVal2D.Text = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select purch_price,sale_price from Currencies  where unit=", Me.cmbUnits.SelectedValue), " and id= "), Me.cmbCurrency.SelectedValue)), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				Dim flag2 As Boolean
				If flag Then
					flag2 = (Me.InvProc = 1)
					If flag2 Then
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_price"))))
					Else
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_price"))))
					End If
				Else
					sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.purch,curr_units.sale from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.cmbUnits.SelectedValue), " and curr_units.curr= "), Me.cmbCurrency.SelectedValue)), Me.conn)
					dataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag2 = (dataTable.Rows.Count > 0)
					If flag2 Then
						flag = (Me.InvProc = 1)
						If flag Then
							Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch"))))
						Else
							Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale"))))
						End If
					Else
						sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price,sale_price from Currencies  where id= ", Me.cmbCurrency.SelectedValue)), Me.conn)
						dataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable)
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_price"))))
						Else
							Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_price"))))
						End If
					End If
				End If
				Dim flag3 As Boolean = False
				Try
					flag2 = (Me.InvProc = 2 And Me._lastclientsale)
					If flag2 Then
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 inv_sub.exchange_price from inv,inv_sub where inv.proc_id=inv_sub.proc_id and  is_deleted=0 and cust_id=", Me.cmbClient.SelectedValue), " and inv.proc_type=1 and is_buy=0 and "), " inv_sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv_sub.unit="), Me.cmbUnits.SelectedValue), " order by inv.date desc")), Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag2 = (dataTable2.Rows.Count > 0)
						If flag2 Then
							flag3 = True
							Me.txtExchangeVal.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))))
						End If
					End If
				Catch ex As Exception
				End Try
				Try
					flag2 = (Me.InvProc = 2 And Me.chkInTax.Checked And Not flag3)
					If flag2 Then
						Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtCurrTax.Text) / 100.0), 5))
					End If
				Catch ex2 As Exception
				End Try
				flag2 = (Me.InvProc = 2)
				If flag2 Then
					Me.GetItemCost(Conversions.ToInteger(Me.cmbCurrency.SelectedValue), Conversions.ToInteger(Me.cmbUnits.SelectedValue))
				End If
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub cmbAddSalesMen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAddSalesMen.Click
		Dim num As Integer = -1
		Dim flag As Boolean = Me.cmbSalesMen.SelectedValue IsNot Nothing
		If flag Then
			num = Conversions.ToInteger(Me.cmbSalesMen.SelectedValue)
		End If
		Dim frmSalesMen As frmSalesMen = New frmSalesMen()
		frmSalesMen.Activate()
		frmSalesMen.ShowDialog()
		Me.LoadSalesMen()
		Try
			Me.cmbSalesMen.SelectedValue = num
		Catch ex As Exception
		End Try
	End Sub

	Private Sub cmbSalesMen_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSalesMen.SelectedIndexChanged
	End Sub

	Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = Me.CheckBox1.Checked
			If flag Then
				Me.hamode = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtDiff.Text) * Me._Exchangeal, 2))
			Else
				Me.hamode = ""
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)})
				num3 += 1
			End While
			Dim rptInvA As rptInvA4 = New rptInvA4()
			rptInvA.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Dim textObject2 As TextObject = CType(rptInvA.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject2.Text = Me.txtDate.Value.ToShortDateString()
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject3 As TextObject = CType(rptInvA.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
			textObject3.Text = Me.txtInvTime.Text
			Dim textObject4 As TextObject = CType(rptInvA.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject4.Text = Me.cmbClient.Text
			Dim textObject5 As TextObject = CType(rptInvA.ReportDefinition.Sections(1).ReportObjects("txtact"), TextObject)
			textObject5.Text = Me.GetCustAct(Conversions.ToInteger(Me.cmbClient.SelectedValue))
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject6 As TextObject = CType(rptInvA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject6.Text = Me.txtTotPurch.Text
			Else
				Dim textObject7 As TextObject = CType(rptInvA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject7.Text = Me.txtTotSale.Text
			End If
			Dim textObject8 As TextObject = CType(rptInvA.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject8.Text = Me.txtDiff.Text
			Dim textObject9 As TextObject = CType(rptInvA.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject9.Text = Me.txtMinusVal.Text
			Dim textObject10 As TextObject = CType(rptInvA.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
			textObject10.Text = Me.GetSalesEmpNameByInvNo()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			rptInvA.Subreports("rptHeader").SetDataSource(dataTable2)
			flag = (dataTable2.Rows.Count > 0)
			If flag Then
				Dim textObject11 As TextObject = CType(rptInvA.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
				textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
				Dim textObject12 As TextObject = CType(rptInvA.ReportDefinition.Sections(5).ReportObjects("txttel"), TextObject)
				textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("tel")))
				Dim textObject13 As TextObject = CType(rptInvA.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
				textObject13.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
				Dim textObject14 As TextObject = CType(rptInvA.ReportDefinition.Sections(5).ReportObjects("txtFax"), TextObject)
				textObject14.Text = Me.TextBox1.Text
			End If
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
				If flag Then
					Dim streamReader As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
					Dim left As String = streamReader.ReadLine()
					Dim left2 As String = streamReader.ReadLine()
					streamReader.Close()
					flag = (Operators.CompareString(left, "0", False) = 0)
					If flag Then
						Dim subreportObject As SubreportObject = CType(rptInvA.ReportDefinition.ReportObjects("Subreport1"), SubreportObject)
						subreportObject.ObjectFormat.EnableSuppress = True
					End If
					flag = (Operators.CompareString(left2, "0", False) = 0)
					If flag Then
						rptInvA.ReportDefinition.Sections(6).SectionFormat.EnableSuppress = True
					End If
				End If
			Catch ex As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA
			frmRptViewer.WindowState = FormWindowState.Maximized
			frmRptViewer.Show()
		End If
	End Sub

	Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
		Dim frmSalePurch As frmSalePurch = New frmSalePurch()
		frmSalePurch.InvProc = 2
		frmSalePurch.Tag = "SalePurch6"
		MainClass.ApplyPermissionToForm(frmSalePurch)
		MainClass.DoApplyUserSett(frmSalePurch)
		frmSalePurch.cmbProcType.SelectedIndex = 3
		frmSalePurch.cmbProcTypeSrch.SelectedIndex = 3
		frmSalePurch.Text = "عرض سعر"
		frmSalePurch.Show()
		frmSalePurch.WindowState = FormWindowState.Maximized
		frmSalePurch.Activate()
	End Sub

	Private Sub txtTax_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTax.TextChanged
		Try
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				Dim num As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * Convert.ToDouble(Me.txtTotPurch.Text), 2)
				Me.lblTaxVal.Text = "" + Conversions.ToString(num)
				Me.txtDiff.Text = Conversions.ToString(Convert.ToDouble(Me.txtTotPurch.Text) + num - Conversion.Val(Me.txtMinusVal.Text))
			Else
				Dim num2 As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * Convert.ToDouble(Me.txtTotSale.Text), 2)
				Me.lblTaxVal.Text = "" + Conversions.ToString(num2)
				Me.txtDiff.Text = Conversions.ToString(Convert.ToDouble(Me.txtTotSale.Text) + num2 - Conversion.Val(Me.txtMinusVal.Text))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnPrintCashier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintCashier.Click
		Dim checked As Boolean = Me.rdPrintAr.Checked
		If checked Then
			Me.PrintRpt(2)
		Else
			Me.PrintRpt_EN(2)
		End If
	End Sub

	Private Sub txtrec_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtrec.TextChanged
		Try
			Dim flag As Boolean = Operators.CompareString(Me.txtrec.Text, "", False) = 0
			If flag Then
				Me.txtrecrem.Text = ""
			Else
				Me.txtrecrem.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtrec.Text) - Conversion.Val(Me.txtCash.Text), 2))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
		Me.PrintRpt_EN(2)
	End Sub

	Private Sub Label27_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label27.Click
	End Sub

	Private Sub Label30_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label30.Click
	End Sub

	Private Sub txtCurrTax_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrTax.TextChanged
		Try
			Dim num As Double = Conversion.Val(Me.txtCurrDiscVal.Text)
			Dim num2 As Double = Conversion.Val(Me.txtVal2.Text) - num
			Me.lblCurrTaxVal.Text = "" + Conversions.ToString(Math.Round(Conversion.Val(Me.txtCurrTax.Text) / 100.0 * num2, 3))
		Catch ex As Exception
		End Try
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

	Private Sub txtCurrDisc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrDisc.TextChanged
		Try
			Dim flag As Boolean = Me.dochange
			If flag Then
				Try
					Me.dochange = False
					Me.txtCurrDiscVal.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtCurrDisc.Text) / 100.0 * Convert.ToDouble(Me.txtVal2.Text), 2))
				Catch ex As Exception
				End Try
				Me.dochange = True
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub txtCurrDiscVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrDiscVal.TextChanged
		Try
			Dim flag As Boolean = Me.dochange
			If flag Then
				Try
					Me.dochange = False
					Me.txtCurrDisc.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtCurrDiscVal.Text) / Convert.ToDouble(Me.txtVal2.Text) * 100.0, 2))
				Catch ex As Exception
				End Try
				Try
					Dim num As Double = Conversion.Val(Me.txtCurrDiscVal.Text)
					Dim num2 As Double = Conversion.Val(Me.txtVal2.Text) - num
					Me.lblCurrTaxVal.Text = "" + Conversions.ToString(Math.Round(Conversion.Val(Me.txtCurrTax.Text) / 100.0 * num2, 2))
				Catch ex2 As Exception
				End Try
				Me.dochange = True
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub rdCash_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdCash.CheckedChanged
	End Sub

	Private Sub rdNetwork_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdNetwork.CheckedChanged
	End Sub

	Private Sub CalcInvCustDisc()
		Try
			Dim flag As Boolean = Me.Code = -1 And Me.InvProc = 2 And Me.chkUseDisc.Checked And Me._ReadCompleted
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text) >= Conversion.Val(Me.txtDiscBalance.Text)
				If flag2 Then
					Me.txtInvCustDisc.Text = Conversions.ToString(Conversion.Val(Me.txtDiscBalance.Text))
				Else
					Me.txtInvCustDisc.Text = Conversions.ToString(Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text))
				End If
			Else
				Dim flag2 As Boolean = Me.InvProc = 2 And Me.chkUseDisc.Checked And Me._ReadCompleted
				If flag2 Then
					flag = (Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text) < Conversion.Val(Me.txtDiscBalance.Text))
					If flag Then
						Me.txtInvCustDisc.Text = Conversions.ToString(Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text))
					End If
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtTotSale_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotSale.TextChanged
		Me.CalcInvCustDisc()
	End Sub

	Private Sub txtInvCustDisc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtInvCustDisc.TextChanged
		Try
			Me.CalcTot()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub chkUseDisc_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUseDisc.CheckedChanged
		Me.CalcInvCustDisc()
	End Sub

	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
		Try
			Me.Timer1.Enabled = False
			Dim flag As Boolean = Operators.CompareString(Me._EnteredBarcode, Me.txtBarcode.Text.Trim(), False) = 0
			If flag Then
				Me._BarcodeProcess = True
				Me.txtBarcode_TextChanged(Nothing, Nothing)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrintPDF()
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = Me.CheckBox1.Checked
			If flag Then
				Me.hamode = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtDiff.Text) * Me._Exchangeal, 2))
			Else
				Me.hamode = ""
			End If
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(2).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)})
				num3 += 1
			End While
			Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
			flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag Then
				obj = New rptInvA4_Herazi()
			Else
				obj = New rptInvA4_Herazi()
			End If
			Dim instance As Object = obj
			Dim type As Type = Nothing
			Dim memberName As String = "SetDataSource"
			Dim array As Object() = New Object() {dataTable}
			Dim arguments As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() {True}
			NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, True)
			If array2(0) Then
				dataTable = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(DataTable)), DataTable)
			End If
			Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
			flag = (Me.cmbProcType.SelectedIndex = 3)
			Dim flag2 As Boolean
			If flag Then
				textObject.Text = "فاتورة عرض سعر"
			Else
				flag = (Me.cmbProcType.SelectedIndex = 0)
				If flag Then
					flag2 = (Me.InvProc = 1)
					If flag2 Then
						textObject.Text = "فاتورة مشتريات"
					Else
						flag2 = (Me.InvProc = 2)
						If flag2 Then
							textObject.Text = Me.Sales_title
						End If
					End If
				Else
					flag2 = (Me.cmbProcType.SelectedIndex = 1)
					If flag2 Then
						flag = (Me.InvProc = 1)
						If flag Then
							textObject.Text = "فاتورة مرتجع مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								flag = Me._IsCreditNote
								If flag Then
									textObject.Text = "إشعار دائن"
								Else
									textObject.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			End If
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtNo"}, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = Me.txtNo.Text
			Dim text As String = Me.txtDate.Value.ToString("dd/MM/yyyy")
			Try
				Dim cultureInfo As CultureInfo = New CultureInfo("ar-SA")
				Dim s As String = text
				text = DateTime.ParseExact(s, "dd/MM/yyyy", cultureInfo.DateTimeFormat, DateTimeStyles.AllowInnerWhite).ToString("dd/MM/yyyy")
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDate"}, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = text
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTime"}, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.txtInvTime.Text
			Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtcust"}, Nothing, Nothing, Nothing), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lbltaxno"}, Nothing, Nothing, Nothing), TextObject)
			flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag2 Then
				textObject6.Text = "الرقم الضريبي"
			Else
				textObject6.Text = "Tax No."
			End If
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
				flag2 = (Operators.CompareString(text2, "", False) <> 0)
				If flag2 Then
					Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
					textObject7.Text = text2
				End If
			Catch ex2 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject8.Text = Me.txtTotPurch.Text
			Else
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.txtTotSale.Text
			End If
			Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"net"}, Nothing, Nothing, Nothing), TextObject)
			textObject10.Text = Me.txtDiff.Text
			Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"minus"}, Nothing, Nothing, Nothing), TextObject)
			textObject11.Text = Me.txtMinusVal.Text
			flag2 = (Me.InvProc = 2)
			If flag2 Then
				Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lbldiscount2"}, Nothing, Nothing, Nothing), TextObject)
				textObject12.Text = "خصم العميل"
			End If
			Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"discount2"}, Nothing, Nothing, Nothing), TextObject)
			textObject13.Text = Me.txtInvCustDisc.Text
			Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
			textObject14.Text = Me.lblTaxVal.Text
			Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
			textObject15.Text = Me.GetSalesEmpNameByInvNo()
			Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtNotes"}, Nothing, Nothing, Nothing), TextObject)
			textObject16.Text = Me.TextBox1.Text
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = RuntimeHelpers.GetObjectValue(obj)
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			flag2 = (saveFileDialog.ShowDialog() = DialogResult.OK)
			If flag2 Then
				NewLateBinding.LateCall(obj, Nothing, "ExportToDisk", New Object() {ExportFormatType.PortableDocFormat, saveFileDialog.FileName + ".pdf"}, Nothing, Nothing, Nothing, True)
			End If
		End If
	End Sub

	Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printDoc.Click
		Me.PrintRptA4WhiteStone(2)
	End Sub

	Private Sub txtMinusVal_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusVal.MouseEnter
		Me.dochange2 = True
	End Sub

	Private Sub txtDiscPerc_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles txtDiscPerc.MouseEnter
		Me.dochange1 = True
	End Sub

	Private Sub txtMinusVal_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusVal.MouseLeave
		Me.dochange2 = False
	End Sub

	Private Sub txtDiscPerc_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDiscPerc.MouseLeave
		Me.dochange1 = False
	End Sub

	Private Sub CalcDisc()
		Try
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim d As Decimal = New Decimal(Conversion.Val(Me.txtDiscPerc1.Text))
				Me.dgvItems.Rows(num3).Cells(12).Value = Conversion.Val(Me.txtDiscPerc1.Text)
				Me.dgvItems.Rows(num3).Cells(11).Value = Math.Round(Convert.ToDouble(Decimal.Divide(d, 100D)) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)), 2)
				Me.dgvItems.Rows(num3).Cells(13).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)), 2)
				Me.dgvItems.Rows(num3).Cells(15).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)), 2)
				Me.dgvItems.Rows(num3).Cells(16).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)), 2)
				num3 += 1
			End While
			Me.CalcTot()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtDiscPerc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDiscPerc.TextChanged
		Dim flag As Boolean = Me.dochange1
		If flag Then
			Try
				Me.txtDiscPerc1.Text = Conversions.ToString(Conversion.Val(Me.txtDiscPerc.Text))
				Me.CalcDisc()
				Me._lastdisc = New Decimal(Conversion.Val(Me.txtDiscPerc.Text))
			Catch ex As Exception
			End Try
		End If
	End Sub

	Private Sub Button7_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
		Me.PrintRptA4Printed(1)
	End Sub

	Private Sub txtCustNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCustNo.TextChanged
		Try
			Dim value As Integer = 1
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				value = 2
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from customers where cust_no=" + Conversions.ToString(Conversion.Val(Me.txtCustNo.Text)) + " and type=" + Conversions.ToString(value), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Me.cmbClient.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub cmbBanks_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBanks.SelectedIndexChanged
	End Sub

	Private Sub dgvItems_CellMouseMove(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvItems.CellMouseMove
		Try
			Dim flag As Boolean = Me.InvProc = 2
			If flag Then
				Me.GetItemCost(Conversions.ToInteger(Me.dgvItems.Rows(e.RowIndex).Cells(9).Value), Me.GetUnitID(Conversions.ToString(Me.dgvItems.Rows(e.RowIndex).Cells(3).Value)))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrintRptMolsk(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			Dim rptMolsk As rptMolsk2 = New rptMolsk2()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim textObject As TextObject = CType(rptMolsk.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
			textObject.Text = Me.txtNo.Text
			Dim textObject2 As TextObject = CType(rptMolsk.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
			textObject2.Text = Me.txtDate.Value.ToString("dd/MM/yyyy")
			Try
				Dim textObject3 As TextObject = CType(rptMolsk.ReportDefinition.Sections(1).ReportObjects("cust"), TextObject)
				textObject3.Text = Me.cmbClient.Text
				Dim textObject4 As TextObject = CType(rptMolsk.ReportDefinition.Sections(1).ReportObjects("tel"), TextObject)
				textObject4.Text = Me.txtCustTel2.Text
				Dim textObject5 As TextObject = CType(rptMolsk.ReportDefinition.Sections(1).ReportObjects("address"), TextObject)
				textObject5.Text = Me.txtCustAddress.Text
			Catch ex As Exception
			End Try
			Dim textObject6 As TextObject = CType(rptMolsk.ReportDefinition.Sections(4).ReportObjects("total"), TextObject)
			textObject6.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
			Dim textObject7 As TextObject = CType(rptMolsk.ReportDefinition.Sections(4).ReportObjects("note"), TextObject)
			textObject7.Text = Me.txtCustNote.Text
			rptMolsk.Subreports("rptHeader").SetDataSource(dataTable)
			Dim flag2 As Boolean = True
			Try
				flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_barcode")))
			Catch ex2 As Exception
			End Try
			Try
				flag = flag2
				If flag Then
					Dim img As Image = Code128Rendering.MakeBarcodeImage("00112233" + Me.txtNo.Text, 2, False)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					dataTable2.Columns("Logo").ColumnName = "barcode"
					dataTable2.Rows(0)("barcode") = MainClass.Image2Arr(img)
					rptMolsk.Subreports("rptBarcode").SetDataSource(dataTable2)
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				flag = (dataTable3.Rows(0)("logo") IsNot DBNull.Value)
				If flag Then
					dataTable3.Columns.Add("NameA")
					dataTable3.Columns.Add("NameE")
					dataTable3.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("NameA"))
					dataTable3.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("NameE"))
					rptMolsk.Subreports("rptHeader").SetDataSource(dataTable3)
				End If
			Catch ex4 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptMolsk
			frmRptViewer.WindowState = FormWindowState.Maximized
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
				frmRptViewer.TopMost = True
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptMolsk.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex5 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
		Me.PrintRptMolsk(1)
	End Sub

	Private Sub Button9_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
		Me.PrintRptA5(1)
	End Sub

	Private Sub PrintRptA4RAWAA(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			flag = (Me.dgvItems.Rows.Count < 11)
			If flag Then
				Dim num6 As Integer = Me.dgvItems.Rows.Count
				While True
					Dim num7 As Integer = num6
					Dim num5 As Integer = 10
					If num7 > num5 Then
						Exit While
					End If
					dataTable.Rows.Add(New Object() {"", "", "", "", "", "", "", "", "", "", ""})
					num6 += 1
				End While
			End If
			Dim rptInvA4RAWAA As rptInvA4RAWAA = New rptInvA4RAWAA()
			rptInvA4RAWAA.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject6.Text = Me.txtCustTel.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject7.Text = Me.txtCustAddress.Text
			Catch ex4 As Exception
			End Try
			Dim text5 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text5 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject8 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject8.Text = text5
				End If
			Catch ex5 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject9 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject9.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject10 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject11 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject11.Text = Me.lblTaxVal.Text
			Dim textObject12 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			flag = (Conversion.Val(Me.txtMinusVal.Text) <> 0.0)
			If flag Then
				Dim textObject13 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
				textObject13.Text = "الخصم  " + Me.txtMinusVal.Text
			End If
			Try
				Dim textObject14 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject14.Text = "فقط  " + Number2Arabic.ameral(textObject12.Text) + "  لاغير"
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject15 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("rec"), TextObject)
				textObject15.Text = Me.txtPaid.Text
			Catch ex7 As Exception
			End Try
			Try
				Dim textObject16 As TextObject = CType(rptInvA4RAWAA.ReportDefinition.Sections(4).ReportObjects("rem"), TextObject)
				textObject16.Text = Me.txtRem.Text
			Catch ex8 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text5, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4RAWAA.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4RAWAA
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4RAWAA.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4ARH(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvARH As rptInvARH = New rptInvARH()
			rptInvARH.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "فاتورة نقدية"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "فاتورة آجلة"
				End If
				Dim textObject2 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject6.Text = Me.txtCustTel.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject7.Text = Me.txtCustAddress.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject8 As TextObject = CType(rptInvARH.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject8.Text = text5
				End If
			Catch ex5 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject9 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject9.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject10 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject11 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject11.Text = Me.lblTaxVal.Text
			Dim textObject12 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject13 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject13.Text = Conversions.ToString(Conversion.Val(Me.txtMinusVal.Text))
			Try
				Dim textObject14 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject14.Text = "فقط  " + Number2Arabic.ameral(textObject12.Text) + "  لاغير"
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject15 As TextObject = CType(rptInvARH.ReportDefinition.Sections(4).ReportObjects("notes"), TextObject)
				textObject15.Text = Me.TextBox1.Text
			Catch ex7 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, "", Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvARH.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex8 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvARH
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvARH.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex9 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4BarQ(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvBarQ As rptInvBarQ = New rptInvBarQ()
			rptInvBarQ.SetDataSource(dataTable)
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject.Text = text4
				End If
			Catch ex As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim textObject2 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("lblheader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject2.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject2.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject2.Text = "ضريبية"
								flag2 = (Operators.CompareString(text4, "", False) = 0)
								If flag2 Then
									textObject2.Text = "ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject2.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject2.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject2.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject2.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject3.Text = Me.txtNo.Text
			Try
				Dim text5 As String = "فاتورة نقدية"
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text5 = "فاتورة آجلة"
				End If
				Dim textObject4 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject4.Text = text5
			Catch ex3 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject5.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject6 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject6.Text = Me.txtInvTime.Text
			Catch ex4 As Exception
			End Try
			Dim textObject7 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject7.Text = Me.cmbClient.Text
			Try
				Dim textObject8 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject9 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject9.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject10 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject11 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject11.Text = Me.lblTaxVal.Text
			Dim textObject12 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject13 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject13.Text = Conversions.ToString(Conversion.Val(Me.txtMinusVal.Text))
			Try
				Dim textObject14 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject14.Text = "فقط  " + Number2Arabic.ameral(textObject12.Text) + "  ريال لاغير"
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject15 As TextObject = CType(rptInvBarQ.ReportDefinition.Sections(4).ReportObjects("notes"), TextObject)
				textObject15.Text = Me.TextBox1.Text
			Catch ex7 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, "", Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvBarQ.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex8 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvBarQ
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvBarQ.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex9 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4RAHAF(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			dataTable.Columns.Add("DataColumn11")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataRow("DataColumn11") = num3 + 1
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvRAHAF As rptInvRAHAF = New rptInvRAHAF()
			rptInvRAHAF.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "فاتورة نقدية"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "فاتورة آجلة"
				End If
				Dim textObject2 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject6.Text = Me.txtCustTel.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject7.Text = Me.txtCustAddress.Text
			Catch ex4 As Exception
			End Try
			Dim text5 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id,cust_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text5 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject8 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject8.Text = text5
				End If
				Try
					Dim textObject9 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
					textObject9.Text = Conversions.ToString(dataTable3.Rows(0)("cust_no"))
				Catch ex5 As Exception
				End Try
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Dim textObject12 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject12.Text = Me.lblTaxVal.Text
			Dim textObject13 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Conversions.ToString(Conversion.Val(Me.txtMinusVal.Text))
			Try
				Dim textObject15 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = "فقط  " + Number2Arabic.ameral(textObject13.Text) + "  لاغير"
			Catch ex7 As Exception
			End Try
			Try
				Dim textObject16 As TextObject = CType(rptInvRAHAF.ReportDefinition.Sections(4).ReportObjects("notes"), TextObject)
				textObject16.Text = Me.TextBox1.Text
			Catch ex8 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text5, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvRAHAF.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvRAHAF
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvRAHAF.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4_2(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = Me.CheckBox1.Checked
			If flag Then
				Me.hamode = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtDiff.Text) * Me._Exchangeal, 2))
			Else
				Me.hamode = ""
			End If
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			flag = Me._ShowBarcode
			If flag Then
				dataTable.Columns.Add("DataColumn1")
			End If
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			flag = Me.dgvItems.Columns(11).Visible
			If flag Then
				dataTable.Columns.Add("discount")
			End If
			flag = Me.dgvItems.Columns(13).Visible
			If flag Then
				dataTable.Columns.Add("tot1")
			End If
			flag = Me.dgvItems.Columns(14).Visible
			If flag Then
				dataTable.Columns.Add("taxperc")
			End If
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				flag = Me._ShowBarcode
				If flag Then
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					flag = (dataTable2.Rows.Count > 0)
					If flag Then
						value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					End If
					dataRow("DataColumn1") = value
				End If
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				dataRow("Currency1") = text2
				dataRow("Currency2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow("Value1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow("quan") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow("Price") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow("Value2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				flag = Me.dgvItems.Columns(11).Visible
				If flag Then
					dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				End If
				flag = Me.dgvItems.Columns(13).Visible
				If flag Then
					dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				End If
				flag = Me.dgvItems.Columns(14).Visible
				If flag Then
					dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				End If
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4_ As rptInvA4_2 = New rptInvA4_2()
			rptInvA4_.SetDataSource(dataTable)
			Try
				Dim lineObject As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line7"), LineObject)
				Dim lineObject2 As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line8"), LineObject)
				Dim lineObject3 As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line9"), LineObject)
				Dim lineObject4 As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line10"), LineObject)
				flag = Not Me.dgvItems.Columns(11).Visible
				If flag Then
					lineObject2.LineStyle = LineStyle.NoLine
				End If
				flag = Not Me.dgvItems.Columns(13).Visible
				If flag Then
					lineObject3.LineStyle = LineStyle.NoLine
				End If
				flag = Not Me.dgvItems.Columns(14).Visible
				If flag Then
					lineObject4.LineStyle = LineStyle.NoLine
				End If
			Catch ex As Exception
			End Try
			Try
				flag = Not Me._ShowBarcode
				If flag Then
					Dim lineObject5 As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line14"), LineObject)
					Dim lineObject6 As LineObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Line17"), LineObject)
					lineObject5.LineStyle = LineStyle.NoLine
					lineObject6.LineStyle = LineStyle.NoLine
					Dim textObject As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Text6"), TextObject)
					textObject.Width = 4560
					Dim fieldObject As FieldObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("Currency11"), FieldObject)
					fieldObject.Width = 4560
				End If
			Catch ex2 As Exception
			End Try
			Dim textObject2 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
			flag = (Me.cmbProcType.SelectedIndex = 3)
			Dim flag2 As Boolean
			If flag Then
				textObject2.Text = "فاتورة عرض سعر"
			Else
				flag = (Me.cmbProcType.SelectedIndex = 0)
				If flag Then
					flag2 = (Me.InvProc = 1)
					If flag2 Then
						textObject2.Text = "فاتورة مشتريات"
					Else
						flag2 = (Me.InvProc = 2)
						If flag2 Then
							textObject2.Text = Me.Sales_title
						End If
					End If
				Else
					flag2 = (Me.cmbProcType.SelectedIndex = 1)
					If flag2 Then
						flag = (Me.InvProc = 1)
						If flag Then
							textObject2.Text = "فاتورة مرتجع مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject2.Text = "فاتورة مرتجع مبيعات"
							End If
						End If
					End If
				End If
			End If
			Dim textObject3 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject3.Text = Me.txtNo.Text
			Try
				Dim textObject4 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("branch"), TextObject)
				textObject4.Text = Me.GetBranchName(MainClass.BranchNo)
				Dim textObject5 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("custtel"), TextObject)
				flag2 = (Me.cmbProcType.SelectedIndex <> 3)
				If flag2 Then
					textObject5.Text = Me.GetCustTel(Conversions.ToInteger(Me.cmbClient.SelectedValue))
				Else
					textObject5.Text = Me.txtCustTel.Text
				End If
				Dim textObject6 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("add"), TextObject)
				textObject6.Text = Me.txtCustAddress.Text
				Dim text3 As String = "نقدي"
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text3 = "آجل"
				End If
				Dim textObject7 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject7.Text = text3
			Catch ex3 As Exception
			End Try
			Try
				Dim text4 As String = ""
				flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) = 0.0)
				If flag2 Then
					text4 = "نقدي"
				Else
					flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) = 0.0)
					If flag2 Then
						text4 = "شبكة"
					Else
						flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) <> 0.0)
						If flag2 Then
							text4 = "نقدي وشبكة"
						End If
					End If
				End If
				Dim textObject8 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("paytype"), TextObject)
				textObject8.Text = text4
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject9 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject9.Text = Me.cmbSalesMen.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject10 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("emp2"), TextObject)
				textObject10.Text = Me.GetEmpName(MainClass.EmpNo)
			Catch ex6 As Exception
			End Try
			Dim textObject11 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject11.Text = Me.txtDate.Value.ToShortDateString()
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject12 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
			textObject12.Text = Me.txtInvTime.Text
			Dim textObject13 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			flag2 = (Me.cmbProcType.SelectedIndex <> 3)
			If flag2 Then
				textObject13.Text = Me.cmbClient.Text
			Else
				textObject13.Text = Me.txtCustNote.Text
			End If
			Dim textObject14 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("lbltaxno"), TextObject)
			flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag2 Then
				textObject14.Text = "الرقم الضريبي"
			Else
				textObject14.Text = "Tax No."
			End If
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				Dim text5 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
				flag2 = (Operators.CompareString(text5, "", False) <> 0)
				If flag2 Then
					Dim textObject15 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
					textObject15.Text = text5
				End If
			Catch ex7 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject16 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject16.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 2))
			Else
				Dim textObject17 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject17.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 2))
			End If
			Dim textObject18 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject18.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Try
				Dim textObject19 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject19.Text = "فقط  " + Number2Arabic.ameral(Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject20 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject20.Text = Me.txtMinusVal.Text
			Try
				Dim textObject21 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("ar1"), TextObject)
				textObject21.Text = "فقط  " + Number2Arabic.ameral(Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 2))) + "  لاغير"
			Catch ex9 As Exception
			End Try
			Dim textObject22 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject22.Text = Me.lblTaxVal.Text
			Try
				Dim textObject23 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("lblvat"), TextObject)
				flag2 = Me.rdPrintAr.Checked
				If flag2 Then
					textObject23.Text = "إجمالي القيمة المضافة"
				Else
					textObject23.Text = "VAT"
				End If
				flag2 = (Me._VatVal <> 0.0)
				If flag2 Then
					Dim textObject24 As TextObject = textObject23
					textObject24.Text = textObject24.Text + " (" + Conversions.ToString(Me._VatVal) + "%)"
				End If
			Catch ex10 As Exception
			End Try
			Try
				flag2 = (Me.cmbType.SelectedIndex = 0 And Conversion.Val(Me.txtPaid.Text) <> 0.0)
				If flag2 Then
					Dim textObject25 As TextObject = CType(rptInvA4_.ReportDefinition.Sections(4).ReportObjects("paid"), TextObject)
					textObject25.Text = "المدفوع: " + Conversions.ToString(Conversion.Val(Me.txtPaid.Text)) + " - المتبقي: " + Conversions.ToString(Conversion.Val(Me.txtRem.Text))
				End If
			Catch ex11 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			rptInvA4_.Subreports("rptHeader").SetDataSource(dataTable4)
			Try
				Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter4.Fill(dataTable5)
				flag2 = (dataTable5.Rows(0)("logo") IsNot DBNull.Value)
				If flag2 Then
					dataTable5.Columns.Add("NameA")
					dataTable5.Columns.Add("NameE")
					dataTable5.Columns.Add("FieldA")
					dataTable5.Columns.Add("FieldE")
					dataTable5.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("NameA"))
					dataTable5.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("NameE"))
					dataTable5.Rows(0)("FieldA") = RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("FieldA"))
					dataTable5.Rows(0)("FieldE") = RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("FieldE"))
					rptInvA4_.Subreports("rptHeader").SetDataSource(dataTable5)
				End If
			Catch ex12 As Exception
			End Try
			Dim flag3 As Boolean = True
			Try
				flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("is_barcode")))
			Catch ex13 As Exception
			End Try
			Try
				flag2 = flag3
				If flag2 Then
					Dim img As Image = Code128Rendering.MakeBarcodeImage("00112233" + Me.txtNo.Text, 2, False)
					Dim dataTable6 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable6)
					dataTable6.Columns("Logo").ColumnName = "barcode"
					dataTable6.Rows(0)("barcode") = MainClass.Image2Arr(img)
					rptInvA4_.Subreports("rptBarcode").SetDataSource(dataTable6)
				End If
			Catch ex14 As Exception
			End Try
			Try
				flag2 = (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("actv_stamp"))) And Me.InvProc = 2)
				If flag2 Then
					Dim dataTable7 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable7)
					dataTable7.Rows(0)("Logo") = CType(dataTable4.Rows(0)("stamp"), Byte())
					rptInvA4_.Subreports("rptStamp").SetDataSource(dataTable7)
				Else
					Dim subreportObject As SubreportObject = CType(rptInvA4_.ReportDefinition.ReportObjects("Subreport3"), SubreportObject)
					subreportObject.ObjectFormat.EnableSuppress = True
				End If
			Catch ex15 As Exception
				Dim subreportObject2 As SubreportObject = CType(rptInvA4_.ReportDefinition.ReportObjects("Subreport3"), SubreportObject)
				subreportObject2.ObjectFormat.EnableSuppress = True
			End Try
			Dim textObject26 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
			textObject26.Text = Me.taxno
			Try
				Dim textObject27 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("cr"), TextObject)
				textObject27.Text = dataTable4.Rows(0)("bsn_no").ToString()
			Catch ex16 As Exception
			End Try
			Try
				Dim textObject28 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("bank1"), TextObject)
				Dim textObject29 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("bank2"), TextObject)
				Dim textObject30 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("bank3"), TextObject)
				Dim textObject31 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("acc1"), TextObject)
				Dim textObject32 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("acc2"), TextObject)
				Dim textObject33 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("acc3"), TextObject)
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				flag2 = (Operators.CompareString(dataTable4.Rows(0)("bank1").ToString(), "", False) <> 0 And Operators.CompareString(dataTable4.Rows(0)("acc1").ToString(), "", False) <> 0)
				If flag2 Then
					flag4 = True
					textObject28.Text = dataTable4.Rows(0)("bank1").ToString()
					textObject31.Text = dataTable4.Rows(0)("acc1").ToString()
				End If
				flag2 = (Operators.CompareString(dataTable4.Rows(0)("bank2").ToString(), "", False) <> 0 And Operators.CompareString(dataTable4.Rows(0)("acc2").ToString(), "", False) <> 0)
				If flag2 Then
					flag5 = True
					flag2 = Not flag4
					If flag2 Then
						textObject28.Text = dataTable4.Rows(0)("bank2").ToString()
						textObject31.Text = dataTable4.Rows(0)("acc2").ToString()
					Else
						textObject29.Text = dataTable4.Rows(0)("bank2").ToString()
						textObject32.Text = dataTable4.Rows(0)("acc2").ToString()
					End If
				End If
				flag2 = (Operators.CompareString(dataTable4.Rows(0)("bank3").ToString(), "", False) <> 0 And Operators.CompareString(dataTable4.Rows(0)("acc3").ToString(), "", False) <> 0)
				If flag2 Then
					flag2 = (Not flag4 And Not flag5)
					If flag2 Then
						textObject28.Text = dataTable4.Rows(0)("bank3").ToString()
						textObject31.Text = dataTable4.Rows(0)("acc3").ToString()
					Else
						flag2 = (Not flag5 Or (Not flag4 AndAlso flag5))
						If flag2 Then
							textObject29.Text = dataTable4.Rows(0)("bank3").ToString()
							textObject32.Text = dataTable4.Rows(0)("acc3").ToString()
						Else
							textObject30.Text = dataTable4.Rows(0)("bank3").ToString()
							textObject33.Text = dataTable4.Rows(0)("acc3").ToString()
						End If
					End If
				End If
			Catch ex17 As Exception
			End Try
			Try
				rptInvA4_.SetParameterValue("note", Me.TextBox1.Text)
			Catch ex18 As Exception
			End Try
			flag2 = (dataTable4.Rows.Count > 0)
			If flag2 Then
				Dim textObject34 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("txtAddress"), TextObject)
				Dim textObject35 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("txtAddressen"), TextObject)
				textObject34.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Address")))
				textObject35.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("AddressEN")))
				Dim textObject36 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("txttel"), TextObject)
				textObject36.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("tel")))
				Dim textObject37 As TextObject = CType(rptInvA4_.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("txtMobile"), TextObject)
				textObject37.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Mobile")))
				Try
					flag2 = (Me.InvProc = 2)
					If flag2 Then
						rptInvA4_.SetParameterValue("msg", RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)("msg")))
					Else
						rptInvA4_.SetParameterValue("msg", "")
					End If
				Catch ex19 As Exception
					rptInvA4_.SetParameterValue("msg", "")
				End Try
			End If
			Try
				flag2 = File.Exists(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
				If flag2 Then
					Dim streamReader As StreamReader = New StreamReader(System.Windows.Forms.Application.StartupPath + "\\invprint.txt")
					Dim left As String = streamReader.ReadLine()
					Dim text6 As String = streamReader.ReadLine()
					streamReader.Close()
					flag2 = (Operators.CompareString(left, "0", False) = 0)
					If flag2 Then
						Dim subreportObject3 As SubreportObject = CType(rptInvA4_.ReportDefinition.ReportObjects("Subreport1"), SubreportObject)
						subreportObject3.ObjectFormat.EnableSuppress = True
					End If
				End If
			Catch ex20 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4_
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4_.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex21 As Exception
				End Try
				Try
					flag2 = Me._SendEmail
					If flag2 Then
						flag = Not Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\Bill")
						If flag Then
							Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\Bill")
						End If
						rptInvA4_.ExportToDisk(ExportFormatType.PortableDocFormat, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf")
						Dim text7 As String = ""
						Try
							Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter("select email from employees where id=" + Conversions.ToString(MainClass.EmpNo), Me.conn1)
							Dim dataTable8 As DataTable = New DataTable()
							sqlDataAdapter5.Fill(dataTable8)
							flag2 = (dataTable8.Rows.Count > 0)
							If flag2 Then
								text7 = Conversions.ToString(Operators.ConcatenateObject("", dataTable8.Rows(0)(0)))
							End If
						Catch ex22 As Exception
						End Try
						flag2 = (Operators.CompareString(text7, "", False) <> 0)
						If flag2 Then
							MainClass.SendEmail(text7, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf", "فاتورة رقم " + Me.txtNo.Text)
						End If
					End If
				Catch ex23 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
		Me.PrintRptA4_2(2)
	End Sub

	Private Sub chkMaintainance_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkMaintainance.CheckedChanged
		Me.GetMaintInvNo()
	End Sub

	Private Sub txtCustTel_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCustTel.TextChanged
		Try
			Dim flag As Boolean = Operators.CompareString(Me.txtCustTel.Text.Trim(), "", False) <> 0 And Me._chkCustTel
			If flag Then
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id from customers where tel='", Me.txtCustTel.Text, "' or mobile='", Me.txtCustTel.Text, "'"}), Me.conn1)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.cmbClient.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
		Try
			Dim frmSrchClient As frmSrchClient = New frmSrchClient()
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				frmSrchClient._type = 2
			Else
				flag = (Me.InvProc = 2)
				If flag Then
					frmSrchClient._type = 1
				End If
			End If
			frmSrchClient.Form_Type = 1
			frmSrchClient.frm1 = Me
			frmSrchClient.ShowDialog()
			Me.cmbClient.SelectedValue = Me.ClientID
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
		Try
			Dim frmSrchClient As frmSrchClient = New frmSrchClient()
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				frmSrchClient._type = 2
			Else
				flag = (Me.InvProc = 2)
				If flag Then
					frmSrchClient._type = 1
				End If
			End If
			frmSrchClient.Form_Type = 1
			frmSrchClient.frm1 = Me
			frmSrchClient.ShowDialog()
			Me.cmbClientSrch.SelectedValue = Me.ClientID
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMinusVal_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtMinusVal.KeyDown
		Try
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.dochange2 = True
				Me.txtMinusVal_TextChanged(Nothing, Nothing)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.TextChanged
		Try
			Dim focused As Boolean = Me.txtCash.Focused
			If focused Then
				Me.txtNetwork.Text = Conversions.ToString(Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.txtCash.Text))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtNetwork_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNetwork.TextChanged
		Try
			Dim focused As Boolean = Me.txtNetwork.Focused
			If focused Then
				Me.txtCash.Text = Conversions.ToString(Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.txtNetwork.Text))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvItems_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
		Try
			Dim flag As Boolean = Not Me._DoChangeValPrice
			If Not flag Then
				flag = (e.ColumnIndex = 4 Or e.ColumnIndex = 7)
				If flag Then
					Me.dgvItems.Rows(e.RowIndex).Cells(5).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(4).Value)) * Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(6).Value))
					Me.dgvItems.Rows(e.RowIndex).Cells(8).Value = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(4).Value)) * Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(7).Value))
					Me.dgvItems.Rows(e.RowIndex).Cells(11).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(12).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(8).Value)), 3)
					Me.dgvItems.Rows(e.RowIndex).Cells(13).Value = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(8).Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(11).Value))
					Me.dgvItems.Rows(e.RowIndex).Cells(15).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(14).Value)) / 100.0 * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(13).Value)), 3)
					Me.dgvItems.Rows(e.RowIndex).Cells(16).Value = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(13).Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(15).Value)), 2)
					Me.CalcTot()
					Me.txtBarcode.Focus()
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBarcode.KeyDown
		Try
			Dim flag As Boolean = e.KeyCode = Keys.[Return] And Me._BarcodeReadType = 1
			If flag Then
				Me.txtBarcode_TextChanged(Nothing, Nothing)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
		Try
			Dim frmcurrency As frmcurrency = New frmcurrency()
			frmcurrency.ShowDialog()
			Me._loaded = False
			Me.LoadAllCurrency()
			Me._loaded = True
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrintRptA4Ameri(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Ameri As rptInvA4Ameri = New rptInvA4Ameri()
			rptInvA4Ameri.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Try
				Dim textObject3 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
				textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Catch ex2 As Exception
			End Try
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject5 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
				textObject5.Text = Me.cmbClient.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex7 As Exception
			End Try
			Dim text5 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text5 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex8 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex9 As Exception
			End Try
			Try
				Dim textObject13 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Catch ex10 As Exception
			End Try
			Dim textObject14 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = Number2Arabic.ameral(Me.txtDiff.Text) + "  ريال سعودي لاغير"
			Catch ex11 As Exception
			End Try
			Try
				Dim textObject16 As TextObject = CType(rptInvA4Ameri.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
				textObject16.Text = Me.lblTaxVal.Text
			Catch ex12 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text5, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Ameri.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex13 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Ameri
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Ameri.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex14 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub Button14_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
		Me.PrintRptA4Ameri(1)
	End Sub

	Private Sub btnRefreshItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshItems.Click
		Try
			Me._loaded = False
			Me.LoadAllCurrency()
			Me._loaded = True
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click
		Me.PrintRptA4RAWAA(1)
	End Sub

	Private Sub Button16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button16.Click
		Me.PrintRptA4Aseel(1)
	End Sub

	Private Sub PrintRptA4Turki(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim left As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(left, "", False) = 0)
					If flag Then
						left = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				dataRow(1) = text2
				dataRow(2) = value
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Turki As rptInvA4Turki = New rptInvA4Turki()
			rptInvA4Turki.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text3 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text3 = "آجل"
				Else
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag Then
						text3 = "نقدي"
					Else
						flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag Then
							text3 = "شبكة"
						End If
					End If
				End If
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					text3 = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 1)
					If flag Then
						text3 = "مرتجع شراء"
					Else
						flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 2)
						If flag Then
							text3 = "مرتجع بيع"
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text3
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject9.Text = text4
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex7 As Exception
			End Try
			Dim textObject13 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = " " + Number2Arabic.ameral(textObject13.Text) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject16 As TextObject = CType(rptInvA4Turki.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject16.Text = Me.lblTaxVal.Text
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Turki.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Turki
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Turki.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Tamkeen(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim left As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(left, "", False) = 0)
					If flag Then
						left = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				dataRow(1) = text2
				dataRow(2) = value
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim reportDocument As ReportDocument = New ReportDocument()
			reportDocument.Load(System.Windows.Forms.Application.StartupPath + "\\rpt\\rptInvA4Tamkeen.rpt")
			reportDocument.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text3 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text3 = "آجل"
				Else
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag Then
						text3 = "نقدي"
					Else
						flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag Then
							text3 = "شبكة"
						End If
					End If
				End If
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					text3 = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 1)
					If flag Then
						text3 = "مرتجع شراء"
					Else
						flag = (Me.cmbProcType.SelectedIndex = 1 And Me.InvProc = 2)
						If flag Then
							text3 = "مرتجع بيع"
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text3
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject9.Text = text4
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			Dim dataTable4 As DataTable = New DataTable()
			dataTable4.Columns.Add("tot1")
			dataTable4.Columns.Add("taxval")
			dataTable4.Columns.Add("discount")
			dataTable4.Columns.Add("tot2")
			dataTable4.Rows.Add(New Object() {Math.Round(Conversion.Val(Me.txtTotSale.Text), 2), Me.lblTaxVal.Text, Me.txtMinusVal.Text, Math.Round(Conversion.Val(Me.txtDiff.Text), 2)})
			reportDocument.Subreports("rptsum").SetDataSource(dataTable4)
			Try
				Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject10.Text = "فقط  " + Number2Arabic.NoToTxt(Conversions.ToDouble(Math.Round(Conversion.Val(Me.txtDiff.Text), 2).ToString("N2")), "ريال", "هللة")
			Catch ex7 As Exception
			End Try
			Try
				flag = (Operators.CompareString(Me.txtCustTel.Text.Trim(), "", False) <> 0)
				If flag Then
					Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
					textObject11.Text = "جوال العميل / " + Me.txtCustTel.Text
				End If
			Catch ex8 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable5 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable5)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable5.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable6 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable6)
				dataTable6.Columns("Logo").ColumnName = "barcode"
				dataTable6.Rows(0)("barcode") = MainClass.Image2Arr(img)
				reportDocument.Subreports("rptQR").SetDataSource(dataTable6)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = reportDocument
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					reportDocument.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Yezen(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim left As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(left, "", False) = 0)
					If flag Then
						left = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Yezen As rptInvA4Yezen = New rptInvA4Yezen()
			rptInvA4Yezen.SetDataSource(dataTable)
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject.Text = text4
				Else
					textObject.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim textObject2 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("lblheader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject2.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject2.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject2.Text = "ضريبية"
								flag2 = (Operators.CompareString(text4, "", False) = 0)
								If flag2 Then
									textObject2.Text = "ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject2.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject2.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject2.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject2.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject3.Text = Me.txtNo.Text
			Try
				Dim text5 As String = "نقدي"
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text5 = "آجل"
				Else
					flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag2 Then
						text5 = "نقدي"
					Else
						flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag2 Then
							text5 = "شبكة"
						End If
					End If
				End If
				Dim textObject4 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject4.Text = text5
			Catch ex3 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject5.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject6 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject6.Text = Me.txtInvTime.Text
			Catch ex4 As Exception
			End Try
			Dim textObject7 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject7.Text = Me.cmbClient.Text
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject8.Text = Me.txtCustNo.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject9 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject9.Text = Me.txtCustTel.Text
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject10 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject10.Text = Me.txtCustAddress.Text
			Catch ex7 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject11 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject12 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject13 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex8 As Exception
			End Try
			Dim textObject14 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject15 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject15.Text = Me.txtMinusVal.Text
			Try
				Dim textObject16 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject16.Text = " " + Number2Arabic.ameral(textObject14.Text) + "  ريال فقط لاغير"
			Catch ex9 As Exception
			End Try
			Dim textObject17 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject17.Text = Me.lblTaxVal.Text
			Try
				Dim textObject18 As TextObject = CType(rptInvA4Yezen.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject18.Text = Me.GetSalesEmpNameByInvNo()
			Catch ex10 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Yezen.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex11 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Yezen
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Yezen.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex12 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub Button17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button17.Click
		Me.PrintRptA4Turki(1)
	End Sub

	Private Sub PrintRptA4WaleedK(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim left As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(left, "", False) = 0)
					If flag Then
						left = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				dataRow(1) = text2
				dataRow(2) = value
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Waleed As rptInvA4Waleed = New rptInvA4Waleed()
			rptInvA4Waleed.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text3 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text3 = "آجل"
				Else
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag Then
						text3 = "نقدي"
					Else
						flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag Then
							text3 = "شبكة"
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text3
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject9.Text = text4
				Else
					textObject9.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex6 As Exception
			End Try
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject10 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject10.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject11 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject12 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex7 As Exception
			End Try
			Dim textObject13 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject14 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject14.Text = Me.txtMinusVal.Text
			Try
				Dim textObject15 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject15.Text = " " + Number2Arabic.ameral(textObject13.Text) + "  لاغير"
			Catch ex8 As Exception
			End Try
			Dim textObject16 As TextObject = CType(rptInvA4Waleed.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject16.Text = Me.lblTaxVal.Text
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Waleed.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex9 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Waleed
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Waleed.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex10 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4SAAD(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			dataTable.Columns.Add("DataColumn11")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Dim left As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(left, "", False) = 0)
					If flag Then
						left = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = num3 + 1
				Dim value As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim value2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				dataRow(1) = value2
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataRow("DataColumn11") = value
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Saad As rptInvA4Saad = New rptInvA4Saad()
			rptInvA4Saad.SetDataSource(dataTable)
			Dim flag2 As Boolean
			Try
				Dim textObject As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject.Text = "فاتورة ضريبية"
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
			Dim textObject2 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject2.Text = Me.txtNo.Text
			Try
				Dim text2 As String = "نقدي"
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text2 = "آجل"
				Else
					flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag2 Then
						text2 = "نقدي"
					Else
						flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag2 Then
							text2 = "شبكة"
						End If
					End If
				End If
				Dim textObject3 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject3.Text = text2
			Catch ex2 As Exception
			End Try
			Dim textObject4 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject4.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject5 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject5.Text = Me.txtInvTime.Text
			Catch ex3 As Exception
			End Try
			Dim textObject6 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject6.Text = Me.cmbClient.Text
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject7.Text = Me.txtCustNo.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject8.Text = Me.txtCustTel.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject9 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject9.Text = Me.txtCustAddress.Text
			Catch ex6 As Exception
			End Try
			Dim text3 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text3 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject10 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag2 = (Operators.CompareString(text3, "", False) <> 0)
				If flag2 Then
					textObject10.Text = text3
				Else
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex7 As Exception
			End Try
			Try
				Dim textObject11 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(1).ReportObjects("lblheader"), TextObject)
				flag2 = (Me.cmbProcType.SelectedIndex = 3)
				If flag2 Then
					textObject11.Text = "عرض سعر"
				Else
					flag2 = (Me.cmbProcType.SelectedIndex = 0)
					If flag2 Then
						flag = (Me.InvProc = 1)
						If flag Then
							textObject11.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject11.Text = "فاتورة ضريبية"
								flag2 = (Operators.CompareString(text3, "", False) = 0)
								If flag2 Then
									textObject11.Text = "فاتورة ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject11.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject11.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject11.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject11.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex8 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject12 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject13 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject14 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex9 As Exception
			End Try
			Dim textObject15 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject15.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 1))
			Dim textObject16 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject16.Text = Me.txtMinusVal.Text
			Try
				Dim textObject17 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject17.Text = " " + Number2Arabic.ameral(textObject15.Text) + "  لاغير"
			Catch ex10 As Exception
			End Try
			Dim textObject18 As TextObject = CType(rptInvA4Saad.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject18.Text = Me.lblTaxVal.Text
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text3, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Saad.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex11 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Saad
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Saad.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex12 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Nawafidh(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.txtNo.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			dataTable.Columns.Add("DataColumn11")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode,nameEN from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("nameEN")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim value As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim value2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				dataRow(1) = value2
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)), 2)
				dataRow(6) = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)), 2)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)), 2)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)), 2)
				dataRow("tot2") = Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)), 2)
				dataRow("DataColumn11") = value
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Nawafidh As rptInvA4Nawafidh = New rptInvA4Nawafidh()
			rptInvA4Nawafidh.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text3 As String = "نقدي"
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text3 = "آجل"
				Else
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0)
					If flag Then
						text3 = "نقدي"
					Else
						flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
						If flag Then
							text3 = "شبكة"
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
				textObject2.Text = text3
			Catch ex As Exception
			End Try
			Dim textObject3 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex2 As Exception
			End Try
			Dim textObject5 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject9 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject9.Text = Me.txtCustNo.Text
			Catch ex6 As Exception
			End Try
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject10 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text4, "", False) <> 0)
				If flag Then
					textObject10.Text = text4
				Else
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("id")))
				End If
			Catch ex7 As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim textObject11 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(1).ReportObjects("lblheader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject11.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject11.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject11.Text = "فاتورة ضريبية"
								flag2 = (Operators.CompareString(text4, "", False) = 0)
								If flag2 Then
									textObject11.Text = "فاتورة ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject11.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject11.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject11.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject11.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex8 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject12 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 2))
			Else
				Dim textObject13 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 2))
			End If
			Try
				Dim textObject14 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 2))
			Catch ex9 As Exception
			End Try
			Dim textObject15 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject15.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
			Try
				Dim textObject16 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
				textObject16.Text = Me.txtMinusVal.Text
			Catch ex10 As Exception
			End Try
			Try
				Dim textObject17 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
				textObject17.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.lblTaxVal.Text), 2))
			Catch ex11 As Exception
			End Try
			Try
				Dim textObject18 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject18.Text = " " + Number2Arabic.ameral(textObject15.Text) + "  لاغير"
			Catch ex12 As Exception
			End Try
			Try
				Dim textObject19 As TextObject = CType(rptInvA4Nawafidh.ReportDefinition.Sections(4).ReportObjects("notes"), TextObject)
				textObject19.Text = Me.TextBox1.Text
			Catch ex13 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Nawafidh.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex14 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Nawafidh
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Nawafidh.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex15 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4Enarty(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4Enarty As rptInvA4Enarty = New rptInvA4Enarty()
			rptInvA4Enarty.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Try
				Dim text4 As String = ""
				flag = (Me.cmbType.SelectedIndex = 0)
				If flag Then
					text4 = "آجل"
				Else
					flag = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) = 0.0)
					If flag Then
						text4 = "نقدي"
					Else
						flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) = 0.0)
						If flag Then
							text4 = "شبكة"
						Else
							flag = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) <> 0.0)
							If flag Then
								text4 = "نقدي وشبكة"
							End If
						End If
					End If
				End If
				Dim textObject2 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("paytype"), TextObject)
				textObject2.Text = text4
			Catch ex As Exception
			End Try
			Try
				Dim textObject3 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
				textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Catch ex2 As Exception
			End Try
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject4 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject4.Text = Me.txtInvTime.Text
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject5 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
				textObject5.Text = Me.cmbClient.Text
			Catch ex4 As Exception
			End Try
			Try
				Dim textObject6 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject6.Text = Me.txtCustNo.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject7 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject7.Text = Me.txtCustTel.Text
			Catch ex6 As Exception
			End Try
			Try
				Dim textObject8 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject8.Text = Me.txtCustAddress.Text
			Catch ex7 As Exception
			End Try
			Dim text5 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,id from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text5 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Dim textObject9 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				flag = (Operators.CompareString(text5, "", False) <> 0)
				If flag Then
					textObject9.Text = text5
				End If
			Catch ex8 As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim textObject10 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(0).ReportObjects("lblheader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject10.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject10.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject10.Text = "فاتورة ضريبية"
								flag2 = (Operators.CompareString(text5, "", False) = 0)
								If flag2 Then
									textObject10.Text = "فاتورة ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject10.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject10.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject10.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject10.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex9 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject11 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 2))
			Else
				Dim textObject12 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject12.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 2))
			End If
			Try
				Dim textObject13 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("txtSum2"), TextObject)
				textObject13.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 2))
			Catch ex10 As Exception
			End Try
			Try
				Dim textObject14 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
				textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
			Catch ex11 As Exception
			End Try
			Dim textObject15 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
			textObject15.Text = Me.txtMinusVal.Text
			Try
				Dim textObject16 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject16.Text = Number2Arabic.ameral(Me.txtDiff.Text) + "  ريال سعودي لاغير"
			Catch ex12 As Exception
			End Try
			Try
				Dim textObject17 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
				textObject17.Text = Me.lblTaxVal.Text
			Catch ex13 As Exception
			End Try
			Try
				Dim textObject18 As TextObject = CType(rptInvA4Enarty.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject18.Text = Me.GetSalesEmpNameByInvNo()
			Catch ex14 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text5, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4Enarty.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex15 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4Enarty
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4Enarty.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex16 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub PrintRptA4RasKH(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			dataTable.Columns.Add("discount")
			dataTable.Columns.Add("tot1")
			dataTable.Columns.Add("taxperc")
			dataTable.Columns.Add("taxval")
			dataTable.Columns.Add("tot2")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim text As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id,barcode from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
					flag = (Operators.CompareString(text, "", False) = 0)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("id")))
					End If
				End If
				dataRow(0) = text
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text3 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text2, "", False) <> 0)
				If flag Then
					text3 = text3 + " - " + text2
				End If
				dataRow(1) = text3
				dataRow(2) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow(3) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow(4) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow(5) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow(6) = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim rptInvA4RasKH As rptInvA4RasKH = New rptInvA4RasKH()
			rptInvA4RasKH.SetDataSource(dataTable)
			Dim text4 As String = ""
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no,email from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable3)
				text4 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tax_no")))
				Try
					Dim textObject As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("txtCustVatNo"), TextObject)
					textObject.Text = text4
				Catch ex As Exception
				End Try
				Try
					Dim textObject2 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("cust_email"), TextObject)
					textObject2.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("email")))
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim textObject3 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("lblHeader"), TextObject)
				flag = (Me.cmbProcType.SelectedIndex = 3)
				If flag Then
					textObject3.Text = "عرض سعر"
				Else
					flag = (Me.cmbProcType.SelectedIndex = 0)
					If flag Then
						flag2 = (Me.InvProc = 1)
						If flag2 Then
							textObject3.Text = "فاتورة مشتريات"
						Else
							flag2 = (Me.InvProc = 2)
							If flag2 Then
								textObject3.Text = "فاتورة ضريبية"
								flag2 = (Operators.CompareString(text4, "", False) = 0)
								If flag2 Then
									textObject3.Text = "فاتورة ضريبية مبسطة"
								End If
								flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
								If flag2 Then
									textObject3.Text = "فاتورة مبيعات"
								End If
								flag2 = (Operators.CompareString(Me.Sales_title, "", False) <> 0)
								If flag2 Then
									textObject3.Text = Me.Sales_title
								End If
							End If
						End If
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 1)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject3.Text = "فاتورة مرتجع مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject3.Text = "فاتورة مرتجع مبيعات"
								End If
							End If
						End If
					End If
				End If
			Catch ex4 As Exception
			End Try
			Dim textObject4 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject4.Text = Me.txtNo.Text
			Try
				Dim text5 As String = "نقدي"
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text5 = "آجل"
				End If
				Dim textObject5 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("invtype"), TextObject)
				textObject5.Text = text5
			Catch ex5 As Exception
			End Try
			Dim textObject6 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("txtDate"), TextObject)
			textObject6.Text = Me.txtDate.Value.ToShortDateString()
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject7 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("txtTime"), TextObject)
				textObject7.Text = Me.txtInvTime.Text
			Catch ex6 As Exception
			End Try
			Dim textObject8 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("txtcust"), TextObject)
			textObject8.Text = Me.cmbClient.Text
			Try
				Dim textObject9 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("cust_no"), TextObject)
				textObject9.Text = Me.txtCustNo.Text
			Catch ex7 As Exception
			End Try
			Try
				Dim textObject10 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("cust_tel"), TextObject)
				textObject10.Text = Me.txtCustTel.Text
			Catch ex8 As Exception
			End Try
			Try
				Dim textObject11 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("cust_add"), TextObject)
				textObject11.Text = Me.txtCustAddress.Text
			Catch ex9 As Exception
			End Try
			Try
				Dim text6 As String = ""
				flag2 = (Me.cmbType.SelectedIndex = 0)
				If flag2 Then
					text6 = "آجل"
				Else
					flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) = 0.0)
					If flag2 Then
						text6 = "نقدي"
					Else
						flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) = 0.0)
						If flag2 Then
							text6 = "شبكة"
						Else
							flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) <> 0.0)
							If flag2 Then
								text6 = "نقدي وشبكة"
							End If
						End If
					End If
				End If
				Dim textObject12 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("pay_type"), TextObject)
				textObject12.Text = text6
			Catch ex10 As Exception
			End Try
			Try
				Dim textObject13 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(1).ReportObjects("emp"), TextObject)
				textObject13.Text = Me.cmbSalesMen.Text
			Catch ex11 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Dim textObject14 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject14.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotPurch.Text), 1))
			Else
				Dim textObject15 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("txtSum"), TextObject)
				textObject15.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotSale.Text), 1))
			End If
			Try
				Dim textObject16 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("tot2"), TextObject)
				textObject16.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtTotAfterDisc.Text), 1))
			Catch ex12 As Exception
			End Try
			Dim textObject17 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("net"), TextObject)
			textObject17.Text = Math.Round(Conversion.Val(Me.txtDiff.Text), 2).ToString("N2")
			Try
				Dim textObject18 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("minus"), TextObject)
				textObject18.Text = Me.txtMinusVal.Text
			Catch ex13 As Exception
			End Try
			Try
				Dim textObject19 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("ar2"), TextObject)
				textObject19.Text = "فقط  " + Number2Arabic.NoToTxt(Conversions.ToDouble(Math.Round(Conversion.Val(Me.txtDiff.Text), 2).ToString("N2")), "ريال", "هللة")
			Catch ex14 As Exception
			End Try
			Dim textObject20 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("tax"), TextObject)
			textObject20.Text = Me.lblTaxVal.Text
			Try
				Dim textObject21 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(4).ReportObjects("notes"), TextObject)
				textObject21.Text = Me.TextBox1.Text
			Catch ex15 As Exception
			End Try
			Try
				Dim textObject22 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(2).ReportObjects("txtuser"), TextObject)
				textObject22.Text = MainClass.UserName
			Catch ex16 As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable4 As DataTable = New DataTable()
			sqlDataAdapter3.Fill(dataTable4)
			Try
				rptInvA4RasKH.Subreports("rptHeader").SetDataSource(dataTable4)
			Catch ex17 As Exception
			End Try
			Try
				Dim textObject23 As TextObject = CType(rptInvA4RasKH.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
				textObject23.Text = Me.taxno
			Catch ex18 As Exception
			End Try
			Try
				flag2 = (dataTable4.Rows.Count > 0)
				If flag2 Then
					Dim textObject24 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(5).ReportObjects("txtAddress"), TextObject)
					textObject24.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Address")))
					Dim textObject25 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(5).ReportObjects("txttel"), TextObject)
					textObject25.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("tel")))
					Dim textObject26 As TextObject = CType(rptInvA4RasKH.ReportDefinition.Sections(5).ReportObjects("txtMobile"), TextObject)
					textObject26.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable4.Rows(0)("Mobile")))
				End If
			Catch ex19 As Exception
			End Try
			Try
				Dim img As Image = MainClass.qrcodeGen(2, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text4, Conversions.ToString(dataTable4.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
				Dim dataTable5 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable5)
				dataTable5.Columns("Logo").ColumnName = "barcode"
				dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
				rptInvA4RasKH.Subreports("rptQR").SetDataSource(dataTable5)
			Catch ex20 As Exception
			End Try
			Try
				flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
				If flag2 Then
					Dim subreportObject As SubreportObject = CType(rptInvA4RasKH.ReportDefinition.ReportObjects("Subreport2"), SubreportObject)
					subreportObject.ObjectFormat.EnableSuppress = True
				End If
			Catch ex21 As Exception
			End Try
			Try
				flag2 = (Me.InvProc = 2)
				If flag2 Then
					rptInvA4RasKH.SetParameterValue("msg", Operators.ConcatenateObject("", dataTable4.Rows(0)("msg")))
				Else
					rptInvA4RasKH.SetParameterValue("msg", "")
				End If
			Catch ex22 As Exception
				Try
					rptInvA4RasKH.SetParameterValue("msg", "")
				Catch ex23 As Exception
				End Try
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = rptInvA4RasKH
			frmRptViewer.WindowState = FormWindowState.Maximized
			Me.btnSave_Click(Nothing, Nothing)
			flag2 = (type = 1)
			If flag2 Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					rptInvA4RasKH.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex24 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub Button18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button18.Click
		Dim num As Integer = 1
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select paper_id from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("paper_id")))
		Catch ex As Exception
		End Try
		Dim flag As Boolean = num = 1
		If flag Then
			Me.PrintRptA4Enarty(1)
		Else
			flag = (num = 2)
			If flag Then
				Me.PrintRptA4ALREDA(1)
			Else
				flag = (num = 3)
				If flag Then
					Me.PrintRptA4Ameri(1)
				Else
					flag = (num = 4)
					If flag Then
						Me.PrintRptA4ARH(1)
					Else
						flag = (num = 5)
						If flag Then
							Me.PrintRptA4Aseel(1)
						Else
							flag = (num = 6)
							If flag Then
								Me.PrintRptA4Hankook(1)
							Else
								flag = (num = 7)
								If flag Then
									Me.PrintRptA4Lgein(1)
								Else
									flag = (num = 8)
									If flag Then
										Me.PrintRptA4RAHAF(1)
									Else
										flag = (num = 9)
										If flag Then
											Me.PrintRptA4RAWAA(1)
										Else
											flag = (num = 10)
											If flag Then
												Me.PrintRptA4ROKN(1)
											Else
												flag = (num = 11)
												If flag Then
													Me.PrintRptA4SAAD(1)
												Else
													flag = (num = 12)
													If flag Then
														Me.PrintRptA4Turki(1)
													Else
														flag = (num = 13)
														If flag Then
															Me.PrintRptA4WaleedK(1)
														Else
															flag = (num = 14)
															If flag Then
																Me.PrintRptA4WhiteStone(1)
															Else
																flag = (num = 15)
																If flag Then
																	Me.PrintRptA5Faisal(1)
																Else
																	flag = (num = 16)
																	If flag Then
																		Me.PrintRptA4BarQ(1)
																	Else
																		flag = (num = 17)
																		If flag Then
																			Me.PrintRptA4Yezen(1)
																		Else
																			flag = (num = 18)
																			If flag Then
																				Me.PrintRptA4RasKH(1)
																			Else
																				flag = (num = 19)
																				If flag Then
																					Me.PrintRptA4Tamkeen(1)
																				Else
																					flag = (num = 20)
																					If flag Then
																						Me.PrintRptA4Nawafidh(1)
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If
	End Sub

	Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
		Dim printElecInv As Boolean = Me._PrintElecInv
		If printElecInv Then
			Me.PrintRptA4(1, 2, False)
		Else
			Me.PrintRptA4(1, 1, False)
		End If
	End Sub

	Private Sub txtRetention_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRetention.TextChanged
		Me.CalcTot()
	End Sub

	Private Sub btnConvertToSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvertToSales.Click
		Try
			Dim frmSalePurch As frmSalePurch = New frmSalePurch()
			frmSalePurch.InvProc = 2
			frmSalePurch.Tag = "SalePurch2"
			MainClass.ApplyPermissionToForm(frmSalePurch)
			MainClass.DoApplyUserSett(frmSalePurch)
			frmSalePurch.cmbProcType.SelectedIndex = 0
			frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
			frmSalePurch.Show()
			frmSalePurch.Navigate("select * from inv where proc_id=" + Conversions.ToString(Me.ProcCode))
			frmSalePurch.btnConvertToSales.Visible = False
			frmSalePurch.Code = -1
			frmSalePurch.ProcCode = -1
			frmSalePurch.txtDate.Value = DateTime.Now
			frmSalePurch.cmbProcType.SelectedIndex = 0
			frmSalePurch.cmbProcTypeSrch.SelectedIndex = 0
			frmSalePurch.WindowState = FormWindowState.Maximized
			frmSalePurch.Activate()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub PrintRptA4DeliveryNote(type As Integer)
		Dim frmChargeData As New frmChargeData()
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.txtNo.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
			End If
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataColumn1")
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Currency2")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("quan")
			dataTable.Columns.Add("Price")
			dataTable.Columns.Add("Value2")
			flag = Me.dgvItems.Columns(11).Visible
			If flag Then
				dataTable.Columns.Add("discount")
			End If
			flag = Me.dgvItems.Columns(13).Visible
			If flag Then
				dataTable.Columns.Add("tot1")
			End If
			flag = Me.dgvItems.Columns(14).Visible
			If flag Then
				dataTable.Columns.Add("taxperc")
			End If
			flag = Me.dgvItems.Columns(15).Visible
			If flag Then
				dataTable.Columns.Add("taxval")
			End If
			dataTable.Columns.Add("tot2")
			dataTable.Columns.Add("DataColumn11")
			dataTable.Columns.Add("DataColumn12")
			Dim num As Integer = 0
			Dim num2 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim dataRow As DataRow = dataTable.NewRow()
				Dim value As String = ""
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from Currencies where id=", Me.dgvItems.Rows(num3).Cells(9).Value)), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					value = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("barcode")))
				End If
				dataRow("DataColumn1") = value
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(18).Value))
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
				flag = (Operators.CompareString(text, "", False) <> 0)
				If flag Then
					text2 = text2 + " - " + text
				End If
				Dim currencyNameEN As String = Me.GetCurrencyNameEN(Conversions.ToInteger(Me.dgvItems.Rows(num3).Cells(9).Value))
				flag = (Operators.CompareString(currencyNameEN, "", False) <> 0)
				If flag Then
					text2 = text2 + Environment.NewLine + currencyNameEN
				End If
				dataRow("Currency1") = text2
				dataRow("Currency2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value)
				dataRow("Value1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value)
				dataRow("quan") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value)
				dataRow("Price") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value)
				dataRow("Value2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)
				flag = Me.dgvItems.Columns(11).Visible
				If flag Then
					dataRow("discount") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(11).Value)
				End If
				flag = Me.dgvItems.Columns(13).Visible
				If flag Then
					dataRow("tot1") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(13).Value)
				End If
				flag = Me.dgvItems.Columns(14).Visible
				If flag Then
					dataRow("taxperc") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(14).Value)
				End If
				flag = Me.dgvItems.Columns(15).Visible
				If flag Then
					dataRow("taxval") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(15).Value)
				End If
				dataRow("tot2") = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(16).Value)
				dataRow("DataColumn11") = Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colOperateNo").Value)
				dataRow("DataColumn12") = Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colExpire").Value)
				dataTable.Rows.Add(dataRow)
				num3 += 1
			End While
			Dim reportDocument As ReportDocument = New ReportDocument()
			flag = (Me.InvProc = 1)
			If flag Then
				reportDocument = New rptInvA4RecOrderPurch()
			Else
				flag = (Me.InvProc = 2)
				If flag Then
					reportDocument = New rptInvA4RecOrder()
				End If
			End If
			reportDocument.SetDataSource(dataTable)
			Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtNo"), TextObject)
			textObject.Text = Me.txtNo.Text
			Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("no"), TextObject)
			textObject2.Text = frmChargeData.txtRecNo.Text
			Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("cust"), TextObject)
			textObject3.Text = Me.cmbClient.Text
			Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
			textObject4.Text = frmChargeData.txtRecDate.Value.ToShortDateString()
			Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("purchno"), TextObject)
			textObject5.Text = frmChargeData.txtRecPurchOrderNo.Text
			Try
				Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("salesno"), TextObject)
				textObject6.Text = frmChargeData.txtRecSaleOrderNo.Text
			Catch ex As Exception
			End Try
			Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("chargetype"), TextObject)
			textObject7.Text = frmChargeData.txtRecChargeType.Text
			Dim textObject8 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("custloc"), TextObject)
			textObject8.Text = frmChargeData.txtRecCustLoc.Text
			Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("custlocadd"), TextObject)
			textObject9.Text = frmChargeData.txtRecCustLocAddress.Text
			Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("resptel"), TextObject)
			textObject10.Text = frmChargeData.txtRecRespTel.Text
			Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("custvatno"), TextObject)
			textObject11.Text = frmChargeData.txtRecCustVatNo.Text
			Dim textObject12 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("car"), TextObject)
			textObject12.Text = frmChargeData.txtRecCar.Text
			Dim textObject13 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("carno"), TextObject)
			textObject13.Text = frmChargeData.txtRecCarNo.Text
			Dim textObject14 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("chargetime"), TextObject)
			textObject14.Text = frmChargeData.txtRecChargeTime.Text
			Dim textObject15 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("chargeacc"), TextObject)
			textObject15.Text = frmChargeData.txtRecChargeAcc.Text
			Dim textObject16 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("driver"), TextObject)
			textObject16.Text = frmChargeData.txtRecDriver.Text
			Dim textObject17 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txtSum"), TextObject)
			textObject17.Text = Me.txtTotQuan.Text
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable3)
			reportDocument.Subreports("rptHeader").SetDataSource(dataTable3)
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
				Dim dataTable4 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable4)
				flag = (dataTable4.Rows(0)("logo") IsNot DBNull.Value)
				If flag Then
					dataTable4.Columns.Add("NameA")
					dataTable4.Columns.Add("NameE")
					dataTable4.Columns.Add("FieldA")
					dataTable4.Columns.Add("FieldE")
					dataTable4.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("NameA"))
					dataTable4.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("NameE"))
					dataTable4.Rows(0)("FieldA") = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("FieldA"))
					dataTable4.Rows(0)("FieldE") = RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("FieldE"))
					reportDocument.Subreports("rptHeader").SetDataSource(dataTable4)
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim flag2 As Boolean = False
				Try
					flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("show_stamp_recdoc")))
				Catch ex3 As Exception
				End Try
				flag = flag2
				If flag Then
					Try
						Dim dataTable5 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable5)
						dataTable5.Rows(0)("Logo") = CType(dataTable3.Rows(0)("stamp"), Byte())
						reportDocument.Subreports("rptStamp").SetDataSource(dataTable5)
					Catch ex4 As Exception
					End Try
					Try
						Dim dataTable6 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable6)
						dataTable6.Rows(0)("Logo") = CType(dataTable3.Rows(0)("sandQ_sign"), Byte())
						reportDocument.Subreports("rptSign").SetDataSource(dataTable6)
					Catch ex5 As Exception
					End Try
				Else
					reportDocument.ReportDefinition.Sections("secStamp").SectionFormat.EnableSuppress = True
				End If
			Catch ex6 As Exception
				Try
					reportDocument.ReportDefinition.Sections("secStamp").SectionFormat.EnableSuppress = True
				Catch ex7 As Exception
				End Try
			End Try
			Dim textObject18 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("tax_no"), TextObject)
			textObject18.Text = Me.taxno
			Try
				Dim textObject19 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("tax_no2"), TextObject)
				textObject19.Text = Me.taxno
			Catch ex8 As Exception
			End Try
			Try
				Dim textObject20 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("cr"), TextObject)
				textObject20.Text = dataTable3.Rows(0)("bsn_no").ToString()
			Catch ex9 As Exception
			End Try
			Try
				Dim textObject21 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("cr2"), TextObject)
				textObject21.Text = dataTable3.Rows(0)("bsn_no").ToString()
			Catch ex10 As Exception
			End Try
			Try
				flag = (dataTable3.Rows.Count > 0)
				If flag Then
					Dim textObject22 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtAddress"), TextObject)
					textObject22.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
					Dim textObject23 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txttel"), TextObject)
					textObject23.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tel")))
					Dim textObject24 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtMobile"), TextObject)
					textObject24.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
					Dim textObject25 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtFax"), TextObject)
					textObject25.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Fax")))
				End If
			Catch ex11 As Exception
			End Try
			Dim frmRptViewer As frmRptViewer = New frmRptViewer()
			Dim crystalReportViewer As CrystalReportViewer = New CrystalReportViewer()
			frmRptViewer.Controls.Add(crystalReportViewer)
			crystalReportViewer.Dock = DockStyle.Fill
			crystalReportViewer.DisplayGroupTree = False
			crystalReportViewer.ReportSource = reportDocument
			frmRptViewer.WindowState = FormWindowState.Maximized
			flag = (type = 2)
			If flag Then
				Me.btnSave_Click(Nothing, Nothing)
			End If
			flag = (type = 1)
			If flag Then
				frmRptViewer.Show()
			Else
				Try
					crystalReportViewer.ShowLastPage()
					Dim currentPageNumber As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					reportDocument.PrintToPrinter(1, False, 1, currentPageNumber)
				Catch ex12 As Exception
				End Try
				Try
					flag = Me._SendEmail
					If flag Then
						Dim flag3 As Boolean = Not Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\Bill")
						If flag3 Then
							Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\Bill")
						End If
						reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf")
						Dim text3 As String = ""
						Try
							Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter("select email from employees where id=" + Conversions.ToString(MainClass.EmpNo), Me.conn1)
							Dim dataTable7 As DataTable = New DataTable()
							sqlDataAdapter4.Fill(dataTable7)
							flag3 = (dataTable7.Rows.Count > 0)
							If flag3 Then
								text3 = Conversions.ToString(Operators.ConcatenateObject("", dataTable7.Rows(0)(0)))
							End If
						Catch ex13 As Exception
						End Try
						flag3 = (Operators.CompareString(text3, "", False) <> 0)
						If flag3 Then
							MainClass.SendEmail(text3, System.Windows.Forms.Application.StartupPath + "\\Bill\\Bill-" + Me.txtNo.Text + ".pdf", "فاتورة رقم " + Me.txtNo.Text)
						End If
					End If
				Catch ex14 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub btnRecPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecPrint.Click
		Me.PrintRptA4DeliveryNote(1)
	End Sub

	Private Sub btnRecData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecData.Click
		Dim frmChargeData As New frmChargeData()
		Dim flag As Boolean = Me.InvProc = 1
		If flag Then
			frmChargeData.Text = "معلومات سند استلام البضاعة"
			frmChargeData.lblNo.Text = "رقم سند الاستلام"
			frmChargeData.lblOrderNo.Text = "رقم أمر شراء المورد"
			frmChargeData.lblSaleOrderNo.Visible = False
			frmChargeData.txtRecSaleOrderNo.Visible = False
			frmChargeData.lblCustLoc.Text = "موقع المورد"
			frmChargeData.lblCustLocAdd.Text = "عنوان موقع المورد"
		Else
			flag = (Me.InvProc = 2)
			If flag Then
				frmChargeData.Text = "معلومات سند تسليم البضاعة"
				frmChargeData.lblNo.Text = "رقم سند التسليم"
				frmChargeData.lblOrderNo.Text = "رقم أمر شراء العميل"
				frmChargeData.lblSaleOrderNo.Visible = True
				frmChargeData.txtRecSaleOrderNo.Visible = True
				frmChargeData.lblCustLoc.Text = "موقع العميل"
				frmChargeData.lblCustLocAdd.Text = "عنوان موقع العميل"
			End If
		End If
		frmChargeData.ShowDialog()
	End Sub

	Private Sub SrchItem()
		Try
			Me.ItemID = -1
			Dim frmSrchItem As frmSrchItem = New frmSrchItem()
			frmSrchItem.type = 1
			frmSrchItem.txtNameSrch.Focus()
			frmSrchItem.frm1 = Me
			frmSrchItem._Store = Conversions.ToInteger(Me.cmbSafe.SelectedValue)
			frmSrchItem.ShowDialog()
			Dim flag As Boolean = Me.ItemID <> -1
			If flag Then
				Me.cmbCurrency.SelectedValue = Me.ItemID
				Me.txtVal1.Text = "1"
				Me.Add2DG()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtBarcode_TextChanged1(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarcode.TextChanged
		Try
			Dim flag As Boolean = Not Me._loaded
			If Not flag Then
				flag = (Me._BarcodeReadType <> 2)
				If Not flag Then
					Me.txtBarcode_TextChanged(Nothing, Nothing)
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
		Me.PrintRptA4(3, 1, False)
	End Sub

	Private Sub chkDebtNote_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDebtNote.CheckedChanged
		Try
			Dim checked As Boolean = Me.chkDebtNote.Checked
			If checked Then
				Me.lblDebtNoteInvNo.Visible = True
				Me.txtDebtNoteInvNo.Visible = True
			Else
				Me.lblDebtNoteInvNo.Visible = False
				Me.txtDebtNoteInvNo.Visible = False
			End If
		Catch ex As Exception
		End Try
	End Sub
End Class
