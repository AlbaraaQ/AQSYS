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
Imports System.IO
Imports System.IO.Ports
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports AQSYS.My
Imports AQSYS.My.Resources
Imports AQSYS.AQSYS.rptt
Partial Public Class frmSalePurchRest
	Inherits Form

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

	Private sp As SerialPort

	Private taxno As String

	Private dtItems As DataTable

	Private dtGroups As DataTable

	Private dtcolor As DataTable

	Private ItemsIndex As Integer

	Private GroupsIndex As Integer

	Private _fieldname As String

	Private _gfieldname As String

	Private _IsCalcTot As Boolean

	Private _IsUpdateDG As Boolean

	Private _DefaultBank As Integer

	Private Sales_title2 As String

	Private _Exchangeal As Double

	Private _foundname As String

	Private _lastclientsale As Boolean

	Private _IsItemsTab3 As Boolean

	Private _IsItemsTab3MinFee As Boolean

	Private _ItemsTab3MinFee As Double

	Private _ActvRestPrintNew As Boolean

	Private _KitPrinterType As Integer

	Private _ZatcInteg As Boolean

	Private _PreventInvZatcFail As Boolean

	Private _IsCLR As Boolean

	Public _IsReAPI As Boolean

	Private _Ispaid As Boolean

	Private _IsLastClientSaleDo As Boolean

	Private _focusedtxt As TextBox

	Private _lastitemprice As Double

	Private _frmSalePurch As frmSalePurch

	Private dochange As Boolean

	Private _entered As Boolean

	Private calcFunc As String

	Private hasDecimal As Boolean

	Private valHolder1 As Double

	Private valHolder2 As Double

	Private _paintend As Boolean

	Public ClientID As Integer

	Private _EnteredBarcode As String

	Private _BarcodeProcess As Boolean

	Private _ismezan As Boolean
	Shared Sub New()
	End Sub
	Private Shared Sub __ENCAddToList(value As Object)
		Dim _ENCList As List(Of WeakReference) = frmSalePurchRest.__ENCList
		Dim flag As Boolean = False
		Try
			Monitor.Enter(_ENCList, flag)
			Dim flag2 As Boolean = frmSalePurchRest.__ENCList.Count = frmSalePurchRest.__ENCList.Capacity
			If flag2 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = frmSalePurchRest.__ENCList.Count - 1
				Dim num4 As Integer = num2
				While True
					Dim num5 As Integer = num4
					Dim num6 As Integer = num3
					If num5 > num6 Then
						Exit While
					End If
					Dim weakReference As WeakReference = frmSalePurchRest.__ENCList(num4)
					flag2 = weakReference.IsAlive
					If flag2 Then
						Dim flag3 As Boolean = num4 <> num
						If flag3 Then
							frmSalePurchRest.__ENCList(num) = frmSalePurchRest.__ENCList(num4)
						End If
						num += 1
					End If
					num4 += 1
				End While
				frmSalePurchRest.__ENCList.RemoveRange(num, frmSalePurchRest.__ENCList.Count - num)
				frmSalePurchRest.__ENCList.Capacity = frmSalePurchRest.__ENCList.Count
			End If
			frmSalePurchRest.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
		Finally
			Dim flag3 As Boolean = flag
			If flag3 Then
				Monitor.[Exit](_ENCList)
			End If
		End Try
	End Sub

	Private Sub CLR()
		Me.cmbCurrency.Focus()
		Dim num As Integer = Convert.ToInt32(Me.NumericUpDown1.Value)
		Dim selectedIndex As Integer = Me.cmbProcType.SelectedIndex
		Dim text As String = Me.txtSrcInvNo.Text
		MainClass.CLRForm(Me)
		Me.cmbProcType.SelectedIndex = selectedIndex
		Me.cmbProcTypeSrch.SelectedIndex = selectedIndex
		Me.dgvItems.Rows.Clear()
		Me._IsCLR = True
		Me._IsCalcTot = True
		Me._IsLastClientSaleDo = False
		Me._lastitemprice = 0.0
		Me.dgvTawlas.Rows.Clear()
		Me.rdOut.Checked = True
		Dim flag As Boolean = Me.dgvTawlaGroups.Rows.Count > 0
		If flag Then
			Me.dgvTawlaGroups.Rows(0).Cells(0).Selected = True
			Me.LoadTawla(Conversions.ToString(Me.dgvTawlaGroups.Rows(0).Cells(0).Value))
		End If
		Me.chkPaidOnline.Checked = False
		Me.Code = -1
		Me.ProcCode = -1
		Me.cmbType.SelectedIndex = 1
		Me._IsUpdateDG = False
		flag = (Me._DefaultBank <> -1)
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
		Me._Ispaid = False
		Me.GetTaxVal()
		Me.LoadOrderNo()
		Try
			Me.sp.Open()
			Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
			Me.sp.WriteLine("WELCOME IN " + Me._foundname)
			Me.sp.Close()
		Catch ex As Exception
		End Try
		Me.NumericUpDown1.Value = New Decimal(num + 1)
		Me.NumericUpDown1.Value = New Decimal(num)
		Me.txtSrcInvNo.Text = text
		Me.DGV_Count = 0
	End Sub

	Private Sub LoadDG(cond As String)
		Me.dgvSrch.Rows.Clear()
		Dim value As Integer = 1
		Dim flag As Boolean = Me.InvProc = 2
		If flag Then
			value = 0
		End If
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Inv.proc_id,Inv.id as id,Inv.date as date,Customers.name as cust from Inv,Customers where proc_type=", Conversions.ToString(Me.cmbProcTypeSrch.SelectedIndex + 1), " and IS_Buy=", Conversions.ToString(value), " and Inv.IS_Deleted=0 and ", cond, " Inv.cust_id=Customers.id order by Inv.id"}), Me.conn)
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

	Public Sub LoadSafes()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Safes,Safe_Emps where Safes.id=Safe_Emps.safe_id and emp_id=" + Conversions.ToString(MainClass.EmpNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbSafe.DataSource = dataTable
		Me.cmbSafe.DisplayMember = "name"
		Me.cmbSafe.ValueMember = "id"
		Me.cmbSafe.SelectedIndex = -1
	End Sub

	Public Sub LoadStocks()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Stocks,Stock_Emps where Stocks.id=Stock_Emps.stock_id and emp_id=" + Conversions.ToString(MainClass.EmpNo) + " and IS_Deleted=0 and status<>2 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbStock.DataSource = dataTable
		Me.cmbStock.DisplayMember = "name"
		Me.cmbStock.ValueMember = "id"
		Me.cmbStock.SelectedIndex = -1
	End Sub

	Public Sub LoadCustomers()
		Dim value As Integer = 1
		Dim flag As Boolean = Me.InvProc = 1
		If flag Then
			value = 2
			flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag Then
				Me.lblClient.Text = "المورد"
			Else
				Me.lblClient.Text = "Supplier"
			End If
		End If
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from Customers where type=" + Conversions.ToString(value) + " order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbClient.DataSource = dataTable
		Me.cmbClient.DisplayMember = "name"
		Me.cmbClient.ValueMember = "id"
		Me.cmbClient.SelectedIndex = -1
	End Sub

	Public Sub LoadCurrency(group As Integer)
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol,nameEN from Currencies where group_id=" + Conversions.ToString(group) + " and IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbCurrency.DataSource = dataTable
		Me.cmbCurrency.DisplayMember = Me._fieldname
		Me.cmbCurrency.ValueMember = "id"
	End Sub

	Public Sub LoadAllCurrency()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id, symbol,nameEN,group_id from Currencies where IS_Deleted=0 order by id", Me.conn)
		sqlDataAdapter.Fill(Me.dtItems)
		Me.cmbCurrency.DataSource = Me.dtItems
		Me.cmbCurrency.DisplayMember = Me._fieldname
		Me.cmbCurrency.ValueMember = "id"
		Me.cmbCurrency.SelectedIndex = -1
		Try
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select groups.color from Currencies,groups where Currencies.group_id=groups.id and Currencies.IS_Deleted=0 order by Currencies.id", Me.conn)
			sqlDataAdapter2.Fill(Me.dtcolor)
		Catch ex As Exception
		End Try
		Dim num As Integer = 0
		Dim num2 As Integer = 12
		Dim flag As Boolean = num2 > Me.dtItems.Rows.Count
		If flag Then
			num2 = Me.dtItems.Rows.Count
		End If
		Dim num3 As Integer = num
		Dim num4 As Integer = num2 - 1
		Dim num5 As Integer = num3
		While True
			Dim num6 As Integer = num5
			Dim num7 As Integer = num4
			If num6 > num7 Then
				Exit While
			End If
			Me.dgvitemData.Rows.Add()
			flag = (num5 < Me.dtItems.Rows.Count)
			If flag Then
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
				Try
					Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
					dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5)("color")))
				Catch ex2 As Exception
				End Try
			End If
			flag = (num5 + 1 < Me.dtItems.Rows.Count)
			If flag Then
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
				Try
					Dim dataGridViewButtonCell2 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1), DataGridViewButtonCell)
					dataGridViewButtonCell2.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 1)("color")))
				Catch ex3 As Exception
				End Try
			End If
			flag = (num5 + 2 < Me.dtItems.Rows.Count)
			If flag Then
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
				Try
					Dim dataGridViewButtonCell3 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2), DataGridViewButtonCell)
					dataGridViewButtonCell3.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 2)("color")))
				Catch ex4 As Exception
				End Try
			End If
			flag = (num5 + 3 < Me.dtItems.Rows.Count)
			If flag Then
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
				Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
				Try
					Dim dataGridViewButtonCell4 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3), DataGridViewButtonCell)
					dataGridViewButtonCell4.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 3)("color")))
				Catch ex5 As Exception
				End Try
			End If
			num5 += 3
			num5 += 1
		End While
	End Sub

	Private Sub txtVal1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVal1.KeyPress
		MainClass.IsFloat(e)
	End Sub

	Private Sub CalcTot()
		Dim flag As Boolean = Not Me._IsCalcTot
		If Not flag Then
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Dim num4 As Integer = 0
			Dim num5 As Integer = Me.dgvItems.Rows.Count - 1
			Dim num6 As Integer = num4
			Dim flag3 As Boolean
			While True
				Dim num7 As Integer = num6
				Dim num8 As Integer = num5
				If num7 > num8 Then
					Exit While
				End If
				Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(num6).Cells(1), DataGridViewComboBoxCell)
				flag = Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, "شراء", False)
				If flag Then
					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num6).Cells(8).Value))
				Else
					num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num6).Cells(8).Value))
				End If
				Try
					Dim num9 As Double = Math.Round(Conversion.Val(Me.txtMinusVal.Text) / If((Conversion.Val(Me.txtTotSale.Text) = 0.0), 1.0, Conversion.Val(Me.txtTotSale.Text)) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num6).Cells(8).Value)), 2)
					Me.dgvItems.Rows(num6).Cells("coldisc").Value = num9
				Catch ex As Exception
				End Try
				Try
					Dim num10 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num6).Cells(8).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num6).Cells("coldisc").Value))
					flag = Me._IsItemsTab3
					If flag Then
						Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(num6).Cells("colistab3").Value), "1", False)
						If flag2 Then
							flag3 = (num10 >= Me._ItemsTab3MinFee)
							If flag3 Then
								Me.dgvItems.Rows(num6).Cells("coltab3val").Value = Math.Round(Conversion.Val(Me.txtTab3Perc.Text) / 100.0 * num10, 3)
							Else
								flag3 = Me._IsItemsTab3MinFee
								If flag3 Then
									Me.dgvItems.Rows(num6).Cells("coltab3val").Value = Me._ItemsTab3MinFee
								End If
							End If
						End If
					Else
						Me.dgvItems.Rows(num6).Cells("coltab3val").Value = Math.Round(Conversion.Val(Me.txtTab3Perc.Text) / 100.0 * num10, 3)
					End If
				Catch ex2 As Exception
				End Try
				num3 += Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num6).Cells("coltab3val").Value))
				num6 += 1
			End While
			flag3 = (num <> 0.0)
			Dim num11 As Double
			If flag3 Then
				num11 = num - num2
			Else
				num11 = num2
			End If
			Me.txtTotPurch.Text = String.Format("{0:0.#,##.##}", num)
			Me.txtTotSale.Text = String.Format("{0:0.#,##.##}", num2)
			Me.txtDiff.Text = String.Format("{0:0.#,##.##}", num11)
			flag3 = (Me.InvProc = 1)
			If flag3 Then
				Dim num12 As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * Convert.ToDouble(Me.txtTotPurch.Text), 2)
				Me.lblTaxVal.Text = "" + Conversions.ToString(num12)
				Me.txtDiff.Text = Conversions.ToString(Convert.ToDouble(Me.txtTotPurch.Text) + num12 - Conversion.Val(Me.txtMinusVal.Text))
			Else
				Me.lblTab3Val.Text = "" + Conversions.ToString(num3)
				Dim value As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * (Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text) + Conversion.Val(Me.lblTab3Val.Text)), 3)
				Me.lblTaxVal.Text = "" + Conversions.ToString(value)
				Me.txtDiff.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtTotSale.Text) + Conversion.Val(Me.lblTab3Val.Text) + Conversion.Val(Me.lblTaxVal.Text) - Conversion.Val(Me.txtMinusVal.Text) + Conversion.Val(Me.txtAppFee.Text), 2))
			End If
			flag3 = (Me.cmbType.SelectedIndex = 1 And Not Me._Ispaid)
			If flag3 Then
				Me.txtCash.Text = Me.txtDiff.Text
				Me.txtNetwork.Text = ""
			End If
		End If
	End Sub

	Private Function GetCurrencyNo(name As String) As Integer
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select id from Currencies where symbol='", name, "' or nameEN='", name, "'"}), Me.conn1)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Return CInt(Math.Round(Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))))
	End Function

	Private Function GetCurrencyName(id As Integer) As String
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select symbol,nameEN from Currencies where id=" + Conversions.ToString(id), Me.conn1)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Dim flag As Boolean = Operators.CompareString(MainClass.Language, "ar", False) = 0
		Dim result As String
		If flag Then
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
		Else
			result = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(1)))
		End If
		Return result
	End Function

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
		Dim flag As Boolean = Me.rdAuto.Checked
		If flag Then
			Me.txtBarcode.Focus()
		Else
			Me.cmbCurrency.Focus()
		End If
		flag = (Me.cmbClient.SelectedValue Is Nothing)
		If flag Then
			Dim text As String = "اختر العميل"
			flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
			If flag Then
				text = "choose client"
			End If
			MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbClient.Focus()
		Else
			flag = (Me.cmbGroups.SelectedValue Is Nothing)
			If flag Then
				Dim text2 As String = "اختر مجموعة الصنف"
				flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
				If flag Then
					text2 = "choose item group"
				End If
				MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cmbGroups.Focus()
			Else
				flag = (Me.cmbCurrency.SelectedValue Is Nothing)
				If flag Then
					Dim text3 As String = "اختر الصنف"
					flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
					If flag Then
						text3 = "choose item"
					End If
					MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.cmbCurrency.Focus()
				Else
					flag = (Operators.CompareString(Me.txtVal1.Text.Trim(), "", False) = 0 Or Conversion.Val(Me.txtVal1.Text) = 0.0)
					If flag Then
						Dim text4 As String = "ادخل الكمية"
						flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
						If flag Then
							text4 = "Enter value"
						End If
						MessageBox.Show(text4, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Me.txtVal1.Focus()
					Else
						flag = (Operators.CompareString(Me.txtExchangeVal.Text.Trim(), "", False) = 0)
						If flag Then
							Dim text5 As String = "ادخل السعر"
							flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
							If flag Then
								text5 = "Enter price"
							End If
							MessageBox.Show(text5, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.txtExchangeVal.Focus()
						Else
							flag = (Me.cmbSafe.SelectedIndex = -1)
							If flag Then
								Dim text6 As String = "يجب اختيار المخزن"
								flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
								If flag Then
									text6 = "choose store"
								End If
								MessageBox.Show(text6, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Me.cmbSafe.Focus()
							Else
								Dim num As Double = Convert.ToDouble(Me.txtVal1.Text)
								Dim num2 As Double = Convert.ToDouble(Me.txtVal1.Text)
								Dim num3 As Decimal = 1D
								Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.perc from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.cmbUnits.SelectedValue), " and curr_units.curr="), Me.cmbCurrency.SelectedValue)), Me.conn)
								Dim dataTable As DataTable = New DataTable()
								sqlDataAdapter.Fill(dataTable)
								flag = (dataTable.Rows.Count > 0)
								If flag Then
									num2 = num * Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
									num3 = New Decimal(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))))
								End If
								flag = (Me.InvProc = 2 And Me.cmbProcType.SelectedIndex = 0)
								If flag Then
									Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("CalcStock", Me.conn1)
									sqlDataAdapter2.SelectCommand.CommandType = CommandType.StoredProcedure
									sqlDataAdapter2.SelectCommand.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
									sqlDataAdapter2.SelectCommand.Parameters.Add("@stock", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbSafe.SelectedValue)
									sqlDataAdapter2.SelectCommand.Parameters.Add("@item", SqlDbType.Int).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
									sqlDataAdapter2.SelectCommand.Parameters.Add("@balance", SqlDbType.Int).Direction = ParameterDirection.Output
									Dim dataTable2 As DataTable = New DataTable()
									sqlDataAdapter2.Fill(dataTable2)
									Dim num4 As Double = Convert.ToDouble(Operators.ConcatenateObject("", sqlDataAdapter2.SelectCommand.Parameters("@balance").Value))
									Dim num5 As Integer = 0
									Dim num6 As Integer = Me.dgvItems.Rows.Count - 1
									Dim num7 As Integer = num5
									While True
										Dim num8 As Integer = num7
										Dim num9 As Integer = num6
										If num8 > num9 Then
											Exit While
										End If
										flag = Operators.ConditionalCompareObjectEqual(Me.dgvItems.Rows(num7).Cells(9).Value, Me.cmbCurrency.SelectedValue, False)
										If flag Then
											num4 -= Convert.ToDouble(Operators.ConcatenateObject("", Me.dgvItems.Rows(num7).Cells(5).Value))
										End If
										num7 += 1
									End While
									flag = (Me.ProcCode <> -1)
									If flag Then
										Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select val from Inv_Sub where currency_from=", Me.cmbCurrency.SelectedValue), " and proc_id="), Me.ProcCode)), Me.conn1)
										Dim dataTable3 As DataTable = New DataTable()
										sqlDataAdapter3.Fill(dataTable3)
										flag = (dataTable3.Rows.Count > 0)
										If flag Then
											num4 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0)))
											flag = (num2 > num4)
											If flag Then
												Dim text7 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
												text7 = text7 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
												text7 = String.Concat(New String() {text7, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))))})
												flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
												If flag Then
													text7 = "quantity is greater than store balance"
													text7 = text7 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
													text7 = String.Concat(New String() {text7, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)(0))))})
												End If
											End If
										Else
											flag = (num2 > num4)
											If flag Then
												Dim text8 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
												text8 = text8 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
												text8 = String.Concat(New String() {text8, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4)})
												flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
												If flag Then
													text8 = "quantity is greater than store balance"
													text8 = text8 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
													text8 = String.Concat(New String() {text8, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4)})
												End If
											End If
										End If
									Else
										flag = (num2 > num4)
										If flag Then
											Dim text9 As String = "الكمية المدخلة للصنف أكبر من رصيد المخزن"
											text9 = text9 + Environment.NewLine + "الكمية الاجمالية المدخلة: " + Conversions.ToString(num2)
											text9 = String.Concat(New String() {text9, Environment.NewLine, "رصيد المخزن: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4)})
											flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
											If flag Then
												text9 = "quantity is greater than store balance"
												text9 = text9 + Environment.NewLine + "total quantity: " + Conversions.ToString(num2)
												text9 = String.Concat(New String() {text9, Environment.NewLine, "store balance: ", Me.cmbSafe.Text, " = ", Conversions.ToString(num4)})
											End If
										End If
									End If
								End If
								flag = (Me.InvProc = 1 And Me.cmbProcType.SelectedIndex = 0)
								If flag Then
									Try
										Me.CalcBalance()
										Dim num10 As Double = Convert.ToDouble(Me.txtCapital.Text)
										flag = (Me.ProcCode <> -1)
										If flag Then
											Dim sqlDataAdapter4 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select val1*exchange_price from Inv_Sub where currency_from=", Me.cmbCurrency.SelectedValue), " and proc_id="), Me.ProcCode)), Me.conn1)
											Dim dataTable4 As DataTable = New DataTable()
											sqlDataAdapter4.Fill(dataTable4)
											flag = (dataTable4.Rows.Count > 0)
											If flag Then
												num10 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0)))
												flag = (Convert.ToDouble(Me.txtVal2.Text) > num10)
												If flag Then
													Dim text10 As String = "اجمالي الشراء أكبر من رصيد الخزنة"
													text10 = text10 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
													text10 = text10 + Environment.NewLine + "تعديل باضافة مبلغ: " + Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text) - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))))
													text10 = String.Concat(New String() {text10, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))))})
													flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
													If flag Then
														text10 = "total purchases is greater than safe balance"
														text10 = text10 + Environment.NewLine + "value : " + Me.txtVal2.Text
														text10 = text10 + Environment.NewLine + "the edited value: " + Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text) - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))))
														text10 = String.Concat(New String() {text10, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10 - Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable4.Rows(0)(0))))})
													End If
												End If
											Else
												flag = (Convert.ToDouble(Me.txtVal2.Text) > num10)
												If flag Then
													Dim text11 As String = "اجمالي الشراء أكبر من رصيد الخزنة"
													text11 = text11 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
													text11 = String.Concat(New String() {text11, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10)})
													flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
													If flag Then
														text11 = "total purchases is greater than safe balance"
														text11 = text11 + Environment.NewLine + "value : " + Me.txtVal2.Text
														text11 = String.Concat(New String() {text11, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10)})
													End If
												End If
											End If
										Else
											flag = (Convert.ToDouble(Me.txtVal2.Text) > num10)
											If flag Then
												Dim text12 As String = "اجمالي الشراء للعملةأكبر من رصيد الخزنة"
												text12 = text12 + Environment.NewLine + "المبلغ : " + Me.txtVal2.Text
												text12 = String.Concat(New String() {text12, Environment.NewLine, "رصيد الخزنة: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10)})
												flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
												If flag Then
													text12 = "total purchases is greater than safe balance"
													text12 = text12 + Environment.NewLine + "value : " + Me.txtVal2.Text
													text12 = String.Concat(New String() {text12, Environment.NewLine, "safe balance: ", Me.cmbStock.Text, " = ", Conversions.ToString(num10)})
												End If
											End If
										End If
									Catch ex As Exception
									End Try
								End If
								flag = (Me.InvProc = 2)
								If flag Then
								End If
								Dim value As String = ""
								Try
									flag = Me._IsItemsTab3
									If flag Then
										Dim sqlDataAdapter5 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select is_tab3 from currencies where id=", Me.cmbCurrency.SelectedValue)), Me.conn1)
										Dim dataTable5 As DataTable = New DataTable()
										sqlDataAdapter5.Fill(dataTable5)
										flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable5.Rows(0)(0)))
										If flag Then
											value = "1"
										End If
									End If
								Catch ex2 As Exception
								End Try
								Dim flag2 As Boolean = False
								Dim index As Integer = -1
								flag = Me._IsUpdateDG
								If flag Then
									index = Me.dgvItems.SelectedRows(0).Index
								Else
									Dim num11 As Integer = 0
									Dim num12 As Integer = Me.dgvItems.Rows.Count - 1
									Dim num13 As Integer = num11
									While True
										Dim num14 As Integer = num13
										Dim num9 As Integer = num12
										If num14 > num9 Then
											GoTo IL_1061
										End If
										Dim left As String = "شراء"
										flag = (Me.InvProc = 2)
										If flag Then
											left = "بيع"
										End If
										flag = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(Me.dgvItems.Rows(num13).Cells(9).Value, Me.cmbCurrency.SelectedValue, False), Operators.CompareObjectEqual(Me.dgvItems.Rows(num13).Cells(3).Value, Me.cmbUnits.Text, False)), Operators.CompareObjectEqual(left, Me.dgvItems.Rows(num13).Cells(1).Value, False)))
										If flag Then
											Exit While
										End If
										num13 += 1
									End While
									flag2 = True
									index = num13
IL_1061:
									flag = Not flag2
									If flag Then
										Me.dgvItems.Rows.Add()
										index = Me.dgvItems.Rows.Count - 1
									End If
								End If
								Try
									Me.sp.Open()
									Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
									Me.sp.WriteLine(String.Concat(New String() {Me.GetCurrencyName(Conversions.ToInteger(Me.cmbCurrency.SelectedValue)), " Q:", Me.txtVal1.Text, " P:", Conversions.ToString(Convert.ToDouble(Me.txtVal2.Text))}))
									Me.sp.Close()
								Catch ex3 As Exception
								End Try
								flag = (Not Me._IsUpdateDG AndAlso flag2)
								Dim flag3 As Boolean
								If flag Then
									flag3 = (Me.chkInTax.Checked And Not Me._IsLastClientSaleDo)
									If flag3 Then
										Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtTax.Text) / 100.0), 6))
									End If
									Me.dgvItems.Rows(index).Cells(4).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(index).Cells(4).Value)) + Convert.ToDouble(Me.txtVal1.Text))
									Me.dgvItems.Rows(index).Cells(5).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(index).Cells(5).Value)) + num2)
									Me.dgvItems.Rows(index).Cells(8).Value = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(index).Cells(8).Value)) + Convert.ToDouble(Me.txtVal2.Text))
								Else
									flag3 = Not Me._IsUpdateDG
									If flag3 Then
										flag = (Me.chkInTax.Checked And Not Me._IsLastClientSaleDo)
										If flag Then
											Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtTax.Text) / 100.0), 6))
										End If
									Else
										flag3 = (Conversion.Val(Me.txtExchangeVal.Text) <> Me._lastitemprice)
										If flag3 Then
											Me.txtExchangeVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtExchangeVal.Text) / (1.0 + Conversion.Val(Me.txtTax.Text) / 100.0), 6))
										End If
									End If
									Me.dgvItems.Rows(index).Cells(0).Value = Me.txtNo.Text
									Dim dataGridViewComboBoxCell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(index).Cells(1), DataGridViewComboBoxCell)
									flag3 = (Me.InvProc = 1)
									If flag3 Then
										dataGridViewComboBoxCell.Value = "شراء"
									Else
										dataGridViewComboBoxCell.Value = "بيع"
									End If
									Me.dgvItems.Rows(index).Cells(2).Value = Me.GetCurrencyName(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
									Me.dgvItems.Rows(index).Cells(3).Value = Me.cmbUnits.Text
									Me.dgvItems.Rows(index).Cells(4).Value = Convert.ToDouble(Me.txtVal1.Text)
									Me.dgvItems.Rows(index).Cells(5).Value = num2
									Me.dgvItems.Rows(index).Cells(6).Value = num3
									Me.dgvItems.Rows(index).Cells(7).Value = Convert.ToDouble(Me.txtExchangeVal.Text)
									Me.dgvItems.Rows(index).Cells(8).Value = Convert.ToDouble(Me.txtVal2.Text)
									Me.dgvItems.Rows(index).Cells(9).Value = RuntimeHelpers.GetObjectValue(Me.cmbCurrency.SelectedValue)
									Me.dgvItems.Rows(index).Cells(10).Value = Me.txtExpireDate.Value.ToShortDateString()
									Me.dgvItems.Rows(index).Cells("colistab3").Value = value
								End If
								Me.CalcTot()
								Me.cmbGroups.SelectedIndex = -1
								Me.cmbCurrency.SelectedIndex = -1
								Me.cmbUnits.SelectedIndex = -1
								Me.txtBarcode.Text = ""
								Me.txtVal1.Text = ""
								Me.txtExchangeVal.Text = ""
								Me.txtExchangeValD.Text = ""
								Me.txtVal2D.Text = ""
								Me._lastitemprice = 0.0
								Me._IsUpdateDG = False
								flag3 = Me.rdAuto.Checked
								If flag3 Then
									Me.txtBarcode.Focus()
								Else
									Me.cmbCurrency.Focus()
								End If
							End If
						End If
					End If
				End If
			End If
		End If
	End Sub

	Private Sub txtVal2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtVal2.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
			Me.Add2DG()
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

	Private Sub LoadOrderNo()
		Try
			Dim flag As Boolean = Me.Code = -1
			If flag Then
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from inv where date>=@date1 and date<=@date2 order by id", Me.conn1)
				sqlDataAdapter.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
				sqlDataAdapter.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDate.Value.AddDays(1.0).ToShortDateString()
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Me.txtOrderNo.Text = "" + Conversions.ToString(dataTable.Rows.Count + 1)
			Else
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from inv where date>=@date1 and date<@date2 order by id", Me.conn1)
				sqlDataAdapter2.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Me.txtDate.Value.ToShortDateString()
				sqlDataAdapter2.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Me.txtDate.Value.AddDays(1.0).ToShortDateString()
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				Me.txtOrderNo.Text = Conversions.ToString(Conversion.Val(Me.txtNo.Text) - Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("id"))) + 1.0)
			End If
		Catch ex As Exception
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
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name,nameEN,color from groups order by id", Me.conn)
		sqlDataAdapter.Fill(Me.dtGroups)
		Me.cmbGroups.DataSource = Me.dtGroups
		Me.cmbGroups.DisplayMember = Me._gfieldname
		Me.cmbGroups.ValueMember = "id"
		Me.cmbGroups.SelectedIndex = -1
		Dim num As Integer = 0
		Dim num2 As Integer = 6
		Dim flag As Boolean = num2 > Me.dtGroups.Rows.Count
		If flag Then
			num2 = Me.dtGroups.Rows.Count
		End If
		Dim num3 As Integer = num
		Dim num4 As Integer = num2 - 1
		Dim num5 As Integer = num3
		While True
			Dim num6 As Integer = num5
			Dim num7 As Integer = num4
			If num6 > num7 Then
				Exit While
			End If
			Me.dgvGroups.Rows.Add()
			Me.dgvGroups.Rows(num5).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtGroups.Rows(num5)(Me._gfieldname))
			Try
				Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvGroups.Rows(Me.dgvGroups.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
				dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtGroups.Rows(num5)("color")))
			Catch ex As Exception
			End Try
			num5 += 1
		End While
	End Sub

	Private Sub LoadUnits()
		' The following expression was wrapped in a checked-statement
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from units order by id", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbUnits.DataSource = dataTable
			Me.cmbUnits.DisplayMember = "name"
			Me.cmbUnits.ValueMember = "id"
			Me.cmbUnits.SelectedIndex = -1
			Dim num As Integer = 0
			Dim num2 As Integer = dataTable.Rows.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Me.dgvUnits.Columns.Add("col" + Conversions.ToString(num3), "")
				Me.dgvUnits.Columns(num3).Width = 80
				num3 += 1
			End While
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.dgvUnits.Rows.Add()
				Me.dgvUnits.Rows(0).Height = 30
				Dim num6 As Integer = 0
				Dim num7 As Integer = dataTable.Rows.Count - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					Dim num5 As Integer = num7
					If num9 > num5 Then
						Exit While
					End If
					Me.dgvUnits.Rows(0).Cells(num8).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num8)("name"))
					num8 += 1
				End While
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub LoadUnits(curr As Integer)
		' The following expression was wrapped in a checked-statement
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
				Me.dgvUnits.Rows.Clear()
				Me.dgvUnits.Columns.Clear()
				Dim num As Integer = 0
				Dim num2 As Integer = dataTable.Rows.Count - 1
				Dim num3 As Integer = num
				While True
					Dim num4 As Integer = num3
					Dim num5 As Integer = num2
					If num4 > num5 Then
						Exit While
					End If
					Me.dgvUnits.Columns.Add("col" + Conversions.ToString(num3), "")
					Me.dgvUnits.Columns(num3).Width = 80
					num3 += 1
				End While
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.dgvUnits.Rows.Add()
					Me.dgvUnits.Rows(0).Height = 30
					Dim num6 As Integer = 0
					Dim num7 As Integer = dataTable.Rows.Count - 1
					Dim num8 As Integer = num6
					While True
						Dim num9 As Integer = num8
						Dim num5 As Integer = num7
						If num9 > num5 Then
							Exit While
						End If
						Me.dgvUnits.Rows(0).Cells(num8).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num8)("name"))
						num8 += 1
					End While
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GetTaxVal()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.txtTax.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax")))
				Me.taxno = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tax_no")))
				Try
					Me.lblTab3Name.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("tab3_name")))
					flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3")))
					If flag Then
						Me.txtTab3Perc.Text = Conversions.ToString(dataTable.Rows(0)("tab3val"))
					End If
				Catch ex As Exception
				End Try
				Try
					Me._IsItemsTab3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3_items")))
					Me._IsItemsTab3MinFee = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("is_tab3_items_minfee")))
					Me._ItemsTab3MinFee = Conversion.Val(Operators.ConcatenateObject("", dataTable.Rows(0)("tab3_items_minfee")))
				Catch ex2 As Exception
				End Try
			End If
		Catch ex3 As Exception
		End Try
	End Sub

	Private Sub LoadTawlaGroups()
		' The following expression was wrapped in a checked-statement
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from tawla_groups order by id", Me.conn)
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
				Me.dgvTawlaGroups.Columns.Add("col" + Conversions.ToString(num3), "")
				Me.dgvTawlaGroups.Columns(num3).Width = 60
				num3 += 1
			End While
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.dgvTawlaGroups.Rows.Add()
				Me.dgvTawlaGroups.Rows(0).Height = 30
				Dim num6 As Integer = 0
				Dim num7 As Integer = dataTable.Rows.Count - 1
				Dim num8 As Integer = num6
				While True
					Dim num9 As Integer = num8
					Dim num5 As Integer = num7
					If num9 > num5 Then
						Exit While
					End If
					Me.dgvTawlaGroups.Rows(0).Cells(num8).Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(num8)("name"))
					num8 += 1
				End While
				Me.LoadTawla(dataTable.Rows(0)("name").ToString())
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Sub LoadMobApps()
		Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id,name from mobapps where IS_Deleted=0 order by id", Me.conn)
		Dim dataTable As DataTable = New DataTable()
		sqlDataAdapter.Fill(dataTable)
		Me.cmbApps.DataSource = dataTable
		Me.cmbApps.DisplayMember = "name"
		Me.cmbApps.ValueMember = "id"
		Me.cmbApps.SelectedIndex = -1
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

	Public Sub LoadData()
		Try
			Try
				Me.btnFirst.Visible = True
				Me.btnLast.Visible = True
				Me.btnNext.Visible = True
				Me.btnPrevious.Visible = True
			Catch ex As Exception
			End Try
			Try
				Me._frmSalePurch.InvProc = 2
				Me._frmSalePurch.LoadData()
			Catch ex2 As Exception
			End Try
			Dim flag As Boolean
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select IS_New,IS_Save,IS_Delete,IS_Search,IS_Print from User_Permissions,Forms where User_Permissions.Form_id=Forms.id and Forms.id=20001 and user_id=" + Conversions.ToString(MainClass.UserID), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count = 0)
				If flag Then
					Me.btnCustAdd.Enabled = False
				End If
			Catch ex3 As Exception
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
			Try
				flag = MainClass.hide_costcenter
				If flag Then
					Me.lblcostcenter.Visible = False
					Me.cmbCenter.Visible = False
				End If
			Catch ex4 As Exception
			End Try
			Me.lblDiscount.Visible = True
			Me.lblDiscPerc.Visible = True
			Me.txtMinusPerc.Visible = True
			Me.txtMinusVal.Visible = True
			Me.txtPaid.Text = "0"
			Me.txtTotPurch.Text = "0"
			Me.txtTotSale.Text = "0"
			Me.txtDiff.Text = "0"
			Me.GetTaxVal()
			Me.LoadOrderNo()
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select port,nameA from Foundation", Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Me.sp = New SerialPort(dataTable2.Rows(0)(0).ToString(), 9600, Parity.None, 8, StopBits.One)
					Me._foundname = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
				End If
			Catch ex5 As Exception
			End Try
			Dim flag2 As Boolean
			Try
				Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
				Dim dataTable3 As DataTable = New DataTable()
				sqlDataAdapter3.Fill(dataTable3)
				flag = (dataTable3.Rows.Count > 0)
				If flag Then
					Try
						flag2 = (Operators.CompareString(dataTable3.Rows(0)("Exchangeval").ToString(), "", False) <> 0)
						If flag2 Then
							Me._Exchangeal = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("Exchangeval")))
						End If
					Catch ex6 As Exception
					End Try
					Try
						flag2 = (Conversion.Val(Operators.ConcatenateObject("", dataTable3.Rows(0)("vat_type"))) = 2.0)
						If flag2 Then
							Me.chkInTax.Checked = True
						End If
					Catch ex7 As Exception
					End Try
					Try
						flag2 = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable3.Rows(0)("sales_title2")), "", False)
						If flag2 Then
							Me.Sales_title2 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("sales_title2")))
						End If
					Catch ex8 As Exception
					End Try
					Try
						Me._lastclientsale = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("is_client_lastsale")))
					Catch ex9 As Exception
					End Try
					Try
						Me._ActvRestPrintNew = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("actv_rest_print_new")))
					Catch ex10 As Exception
					End Try
					Try
						Me._ZatcInteg = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("is_zatc_integ")))
						Me._PreventInvZatcFail = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("is_prevent_inv_zatc_fail")))
					Catch ex11 As Exception
					End Try
					Try
						Me._KitPrinterType = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable3.Rows(0)("kit_print_type")))
					Catch ex12 As Exception
					End Try
				End If
			Catch ex13 As Exception
			End Try
			flag2 = (Me.InvProc = 1)
			If flag2 Then
				Me.lblTotSale.Visible = False
				Me.txtTotSale.Visible = False
				Dim lblTotPurch As Control = Me.lblTotPurch
				Dim location As Point = New Point(194, 3)
				lblTotPurch.Location = location
				Dim txtTotPurch As Control = Me.txtTotPurch
				location = New Point(194, 27)
				txtTotPurch.Location = location
			Else
				Me.lblTotPurch.Visible = False
				Me.txtTotPurch.Visible = False
				Me.Label9.Visible = False
				Me.txtExpireDate.Visible = False
				flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag2 Then
					Me.Text = "الكاشير"
				Else
					Me.Text = "cashier"
				End If
			End If
			Me.txtToDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtFromDate.Value = Conversions.ToDate(DateTime.Now.ToShortDateString())
			Me.txtDate.Value = DateTime.Now
			Me.LoadGroups()
			Me.LoadUnits()
			Me.LoadSafes()
			Me.LoadStocks()
			Me.LoadCustomers()
			Me.LoadSalesMen()
			Me.LoadBaks()
			Me.LoadTawlaGroups()
			Me.LoadMobApps()
			Me.LoadCenters()
			Me.txtDate.Value = DateTime.Now
			Me.cmbType.SelectedIndex = 1
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
			End If
			Me.cmbCurrency.Focus()
			flag2 = (Me.cmbProcType.SelectedIndex = 1)
			If flag2 Then
				Me.GroupBox3.Height = 72
			End If
			Me.rdOut.Checked = True
			Me.cmbBanks.Visible = True
			Me.lblBarcode.Text = "الباركود"
			Me.LoadAllCurrency()
		Catch ex14 As Exception
		End Try
	End Sub

	Private Sub frmSalePurch_Load(ByVal sender As Object, ByVal e As EventArgs) ' Handles frmSalePurch.Load
		Me.LoadData()
	End Sub

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

			' ========== التحقق من حد ديون العميل ==========
			If Not ValidateCustomerDebtLimit() Then Return

			' ========== التحقق من البنك والمدفوعات ==========
			If Not ValidatePaymentInputs() Then Return

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
			UpdateInvoiceAdditionalData(sqlTransaction, zatcaIntegration, isZatcaProcessed)

			' ========== حفظ تفاصيل الفاتورة ==========
			SaveInvoiceDetails(sqlTransaction)

			' ========== حفظ القيود المحاسبية ==========
			Dim centerCode As Integer = GetCenterCode()
			SaveAccountingRestrictions(sqlTransaction, clientAccountCode, stockAccountCode, purchRestCode, saleRestCode, centerCode)

			' ========== تأكيد المعاملة ==========
			sqlTransaction.Commit()

			' ========== معالجة ما بعد الحفظ ==========
			ProcessPostSaveOperations()

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
			If MainClass.IsTrial AndAlso Me.ProcCode = -1 Then
				Dim adapter As New SqlDataAdapter("SELECT id FROM inv WHERE proc_type=1", Me.conn1)
				Dim dt As New DataTable()
				adapter.Fill(dt)

				If dt.Rows.Count >= 100 Then
					Dim message As String = If(MainClass.Language = "en",
					"you reach the maximum of entries",
					"لقد وصلت لأقصى حد ادخال")
					MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Me.ISTRialEnd = True
					Return False
				End If
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

		' التحقق من وجود أصناف
		If Me.dgvItems.Rows.Count = 0 Then
			MessageBox.Show("يجب ادخال أصناف للفاتورة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbCurrency.Focus()
			Return False
		End If

		Return True
	End Function

	Private Function ValidateCustomerDebtLimit() As Boolean
		Try
			If Me.InvProc <> 2 Then Return True
			If Me.cmbType.SelectedIndex <> 0 Then Return True
			If Me.ProcCode <> -1 Then Return True

			Dim hasDebitBalance As Boolean = Me.txtBalance.Text.Contains("مدين") OrElse
										  Conversion.Val(Me.txtBalance.Text) = 0.0
			If Not hasDebitBalance Then Return True

			Dim adapter As New SqlDataAdapter(
			$"SELECT maxdepit FROM Customers WHERE id={Me.cmbClient.SelectedValue}",
			Me.conn)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Dim maxDebt As Double = Conversion.Val($"{dt.Rows(0)(0)}")
				If maxDebt <> 0.0 Then
					Dim currentBalance As Decimal = Convert.ToDecimal(
					Me.txtBalance.Text.Replace("مدين", "").Replace(" ", ""))
					Dim newTotal As Double = Convert.ToDouble(
					Decimal.Add(currentBalance, Convert.ToDecimal(Me.txtDiff.Text)))

					If newTotal > maxDebt Then
						Interaction.MsgBox("العميل تعدى الحد الأعلى للديون", MsgBoxStyle.OkOnly, Nothing)
						Return False
					End If
				End If
			End If

			Return True
		Catch ex As Exception
			Return True
		End Try
	End Function

	Private Function ValidatePaymentInputs() As Boolean
		' التحقق من اختيار البنك عند وجود دفع بالشبكة
		If Conversion.Val(Me.txtNetwork.Text) <> 0.0 AndAlso Me.cmbBanks.SelectedValue Is Nothing Then
			Interaction.MsgBox("اختر البنك", MsgBoxStyle.OkOnly, Nothing)
			Me.txtNetwork.Focus()
			Return False
		End If

		' التحقق من تطابق المدفوعات مع صافي الفاتورة
		If Me.cmbType.SelectedIndex = 1 AndAlso Me.chkIsPaid.Checked Then
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

#End Region

#Region "دوال معالجة الزكاة والدخل"

	Private Function ProcessZatcaIntegration(ByRef zatcaIntegration As ZatcaIntegration,
										  ByRef isProcessed As Boolean) As Boolean
		Try
			Dim shouldProcess As Boolean = Me.chkIsPaid.Checked AndAlso
			(Me.cmbProcType.SelectedIndex = 0 OrElse Me.cmbProcType.SelectedIndex = 1) AndAlso
			Me.InvProc = 2 AndAlso
			((Me.ProcCode = -1 AndAlso Me._ZatcInteg) OrElse Me._IsReAPI)

			If Not shouldProcess Then Return True

			Dim payType As Integer = DeterminePaymentType()
			Dim invType As Integer = If(Me.cmbProcType.SelectedIndex = 1, 5, 1)
			Dim itemsTable As DataTable = PrepareZatcaItemsTable()

			Dim totalVat As Double = 0.0
			Dim totalNet As Double = 0.0
			CalculateZatcaTotals(itemsTable, totalVat, totalNet)

			Dim success As Boolean = zatcaIntegration.ZatcaIntegration(
			Me.txtNo.Text,
			Me.txtDate.Value,
			invType,
			payType,
			Conversions.ToInteger(Me.cmbClient.SelectedValue),
			Convert.ToDouble(Me.txtTotSale.Text),
			Convert.ToDouble(Me.txtMinusVal.Text),
			totalVat,
			totalNet,
			itemsTable,
			-1,
			DateTime.MinValue)

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
			Return 0
		ElseIf Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
			Return 2
		Else
			Return 1
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
		Return dt
	End Function

	Private Sub CalculateZatcaTotals(ByRef itemsTable As DataTable,
								  ByRef totalVat As Double,
								  ByRef totalNet As Double)
		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			Dim row As DataRow = itemsTable.NewRow()

			row("name") = $"{Me.dgvItems.Rows(i).Cells(2).Value}"
			row("price") = Me.dgvItems.Rows(i).Cells(7).Value
			row("quan") = Me.dgvItems.Rows(i).Cells(4).Value
			row("total") = Me.dgvItems.Rows(i).Cells(8).Value

			Dim itemTotal As Double = Conversion.Val(Me.dgvItems.Rows(i).Cells(8).Value)
			Dim totalSale As Double = Conversion.Val(Me.txtTotSale.Text)
			Dim minusVal As Double = Conversion.Val(Me.txtMinusVal.Text)
			Dim taxPerc As Double = Conversion.Val(Me.txtTax.Text)
			Dim tab3Val As Double = Conversion.Val($"{Me.dgvItems.Rows(i).Cells("coltab3val").Value}")

			Dim discount As Double = Math.Round(minusVal / totalSale * itemTotal, 2)
			Dim afterDisc As Double = itemTotal - discount
			Dim vatAmount As Double = taxPerc / 100.0 * (afterDisc + tab3Val)
			Dim netAmount As Double = afterDisc + taxPerc / 100.0 * afterDisc

			row("disc") = discount
			row("totalafterdisc") = afterDisc
			row("vatperc") = Me.txtTax.Text
			row("vat") = vatAmount
			row("net") = netAmount

			totalVat += vatAmount
			totalNet += netAmount

			itemsTable.Rows.Add(row)
		Next
	End Sub

#End Region

#Region "دوال قاعدة البيانات"

	Private Function GetAccountCode(accountName As String) As Integer
		Dim adapter As New SqlDataAdapter(
		$"SELECT Code FROM Accounts_Index WHERE type=2 AND AName='{accountName}'",
		Me.conn)
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

		If Not Me.chkIsPaid.Checked Then Return

		Dim branchFilter As String = If(MainClass.BranchNo <> -1,
		$" WHERE branch={MainClass.BranchNo}", "")

		If Me.ProcCode = -1 Then
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

			If purchCode = 0 AndAlso Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
				purchCode = GetNextRestrictionId(transaction, branchFilter)
			End If

			If saleCode = 0 AndAlso Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
				saleCode = GetNextRestrictionId(transaction, branchFilter)
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
		Dim cmd As New SqlCommand($"SELECT MAX(id) FROM Restrictions {filter}",
							  Me.conn, transaction)
		Return CInt(Math.Round(Conversion.Val($"{cmd.ExecuteScalar()}") + 1.0))
	End Function

	Private Sub DeleteExistingRestrictions(transaction As SqlTransaction,
										purchCode As Integer,
										saleCode As Integer)
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

#End Region

#Region "دوال حفظ الفاتورة"

	Private Sub SaveMainInvoice(transaction As SqlTransaction,
							purchRestCode As Integer,
							saleRestCode As Integer)
		Dim isBuy As Integer = If(Me.InvProc = 2, 0, 1)
		Dim cmd As SqlCommand

		If Me.ProcCode = -1 Then
			' فاتورة جديدة
			Dim spName As String = If(Me.cmbProcType.SelectedIndex <> 1, "InsertInv", "InsertInvRet")
			cmd = New SqlCommand(spName, Me.conn, transaction)
			Me.LoadInvNo()
			Me.Code = CInt(Math.Round(Convert.ToDouble(Me.txtNo.Text)))
		Else
			' تعديل فاتورة
			Dim spName As String = If(Me.cmbProcType.SelectedIndex <> 1, "UpdateInv", "UpdateInvRet")
			cmd = New SqlCommand(spName, Me.conn, transaction)
		End If

		cmd.CommandType = CommandType.StoredProcedure
		AddInvoiceParameters(cmd, purchRestCode, saleRestCode, isBuy)
		cmd.ExecuteNonQuery()
	End Sub

	Private Sub AddInvoiceParameters(cmd As SqlCommand,
								  purchRestCode As Integer,
								  saleRestCode As Integer,
								  isBuy As Integer)
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
		If Me.cmbType.SelectedIndex = 1 AndAlso Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
			bankId = Conversions.ToInteger(Me.cmbBanks.SelectedValue)
		End If
		cmd.Parameters.Add("@bank", SqlDbType.Int).Value = bankId
	End Sub

	Private Sub UpdateInvoiceAdditionalData(transaction As SqlTransaction,
										 zatcaIntegration As ZatcaIntegration,
										 isZatcaProcessed As Boolean)
		Dim isExistingInvoice As Boolean = False

		' الحصول على كود الفاتورة
		If Me.ProcCode = -1 Then
			Dim cmd As New SqlCommand("SELECT MAX(proc_id) FROM Inv", Me.conn, transaction)
			Me.ProcCode = CInt(Math.Round(Convert.ToDouble($"{cmd.ExecuteScalar()}")))
		Else
			isExistingInvoice = True
		End If

		' تحديث بيانات الزكاة
		UpdateZatcaData(transaction, zatcaIntegration, isZatcaProcessed)

		' تحديث كود قيد البيع
		UpdateSaleRestrictionCode(transaction)

		' تحديث بيانات المطعم والتطبيق
		UpdateRestaurantAndAppData(transaction)

		' تحديث الضريبة الإضافية
		UpdateAdditionalTax(transaction)

		' تحديث المدفوعات
		UpdatePaymentParts(transaction)

		' تحديث مركز التكلفة
		UpdateCostCenter(transaction)
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
			' تجاهل الخطأ
		End Try
	End Sub

	Private Sub UpdateSaleRestrictionCode(transaction As SqlTransaction)
		Try
			Dim cmd As New SqlCommand(
			$"UPDATE inv SET sale_rest_id={Me.RestSaleCode} WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdateRestaurantAndAppData(transaction As SqlTransaction)
		Dim restType As Integer = GetRestaurantType()
		Dim tableId As Integer = GetTableId()
		Dim isPaid As Integer = If(Me.chkIsPaid.Checked, 1, 0)
		Dim appId As Integer = If(Me.cmbApps.SelectedValue IsNot Nothing,
		Convert.ToInt32(Me.cmbApps.SelectedValue), -1)
		Dim isPaidOnline As Integer = If(Me.chkPaidOnline.Checked, 1, 0)

		Dim sql As String = $"UPDATE inv SET rest_type={restType}, tawla={tableId}, " &
		"tawla_paid=@tawla_paid, mobapp_id=@mobapp_id, fees=@fees, " &
		$"is_paid_online=@is_paid_online WHERE proc_id={Me.ProcCode}"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)
		cmd.Parameters.Add("@tawla_paid", SqlDbType.Bit).Value = isPaid
		cmd.Parameters.Add("@mobapp_id", SqlDbType.Int).Value = appId
		cmd.Parameters.Add("@fees", SqlDbType.Float).Value = Conversion.Val(Me.txtAppFee.Text)
		cmd.Parameters.Add("@is_paid_online", SqlDbType.Bit).Value = isPaidOnline
		cmd.ExecuteNonQuery()
	End Sub

	Private Function GetRestaurantType() As Integer
		If Me.rdOut.Checked Then Return 2
		If Me.rdIn2.Checked Then Return 3
		If Me.rdApp.Checked Then Return 6
		Return 1
	End Function

	Private Function GetTableId() As Integer
		Try
			If Not (Me.rdIn.Checked OrElse Me.rdIn2.Checked) Then Return -1

			Dim tableName As String = Me.dgvTawlas.SelectedCells(0).Value.ToString()
			Dim adapter As New SqlDataAdapter($"SELECT id FROM tawla WHERE name='{tableName}'", Me.conn1)
			Dim dt As New DataTable()
			adapter.Fill(dt)

			If dt.Rows.Count > 0 Then
				Return Convert.ToInt32(dt.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
		Return -1
	End Function

	Private Sub UpdateAdditionalTax(transaction As SqlTransaction)
		Try
			Dim sql As String = $"UPDATE inv SET tab3tax={Conversion.Val(Me.txtTab3Perc.Text)}, " &
			$"tab3_val={Conversion.Val(Me.lblTab3Val.Text)} WHERE proc_id={Me.ProcCode}"
			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
			cmd.ExecuteNonQuery()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub UpdatePaymentParts(transaction As SqlTransaction)
		Try
			Dim sql As String = $"UPDATE inv SET cash_part={Conversion.Val(Me.txtCash.Text)}, " &
			$"network_part={Conversion.Val(Me.txtNetwork.Text)} WHERE proc_id={Me.ProcCode}"
			Dim cmd As New SqlCommand(sql, Me.conn, transaction)
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

	Private Function GetCenterCode() As Integer
		If Me.cmbCenter.SelectedValue IsNot Nothing Then
			Return Convert.ToInt32(Me.cmbCenter.SelectedValue)
		End If
		Return -1
	End Function

#End Region

#Region "دوال حفظ تفاصيل الفاتورة"

	Private Sub SaveInvoiceDetails(transaction As SqlTransaction)
		' حذف التفاصيل القديمة إن وجدت
		If Me.ProcCode <> -1 Then
			Dim deleteCmd As New SqlCommand(
			$"DELETE FROM Inv_Sub WHERE proc_id={Me.ProcCode}",
			Me.conn, transaction)
			deleteCmd.ExecuteNonQuery()
		End If

		' إضافة التفاصيل الجديدة
		For i As Integer = 0 To Me.dgvItems.Rows.Count - 1
			SaveInvoiceDetailRow(transaction, i)
		Next
	End Sub

	Private Sub SaveInvoiceDetailRow(transaction As SqlTransaction, rowIndex As Integer)
		Dim sql As String = "INSERT INTO Inv_Sub(proc_id, proc_type, currency_from, unit, val, val1, " &
		"exchange_price, discount, taxperc, taxval, item_adds, is_tab3, item_tab3) " &
		"VALUES(@proc_id, @proc_type, @currency_from, @unit, @val, @val1, " &
		"@exchange_price, @discount, @taxperc, @taxval, @item_adds, @is_tab3, @item_tab3)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)

		cmd.Parameters.Add("@proc_id", SqlDbType.Int).Value = Me.ProcCode

		' نوع العملية (شراء/بيع)
		Dim cell As DataGridViewComboBoxCell = CType(Me.dgvItems.Rows(rowIndex).Cells(1), DataGridViewComboBoxCell)
		cmd.Parameters.Add("@proc_type", SqlDbType.Int).Value = If(cell.Value?.ToString() = "شراء", 1, 2)

		cmd.Parameters.Add("@currency_from", SqlDbType.Int).Value = Me.dgvItems.Rows(rowIndex).Cells(9).Value
		cmd.Parameters.Add("@unit", SqlDbType.Int).Value = GetUnitID($"{Me.dgvItems.Rows(rowIndex).Cells(3).Value}")
		cmd.Parameters.Add("@val", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(5).Value
		cmd.Parameters.Add("@val1", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(4).Value
		cmd.Parameters.Add("@exchange_price", SqlDbType.Float).Value = Me.dgvItems.Rows(rowIndex).Cells(7).Value

		' حساب الخصم
		Dim itemTotal As Double = Conversion.Val(Me.dgvItems.Rows(rowIndex).Cells(8).Value)
		Dim totalSale As Double = Conversion.Val(Me.txtTotSale.Text)
		Dim minusVal As Double = Conversion.Val(Me.txtMinusVal.Text)
		Dim discount As Double = Math.Round(minusVal / If(totalSale = 0.0, 1.0, totalSale) * itemTotal, 2)

		cmd.Parameters.Add("@discount", SqlDbType.Float).Value = discount
		cmd.Parameters.Add("@taxperc", SqlDbType.Float).Value = Conversion.Val(Me.txtTax.Text)

		' حساب الضريبة
		Dim tab3Val As Double = Conversion.Val($"{Me.dgvItems.Rows(rowIndex).Cells("coltab3val").Value}")
		Dim taxVal As Double = Conversion.Val(Me.txtTax.Text) / 100.0 * (itemTotal - discount + tab3Val)
		cmd.Parameters.Add("@taxval", SqlDbType.Float).Value = taxVal

		cmd.Parameters.Add("@item_adds", SqlDbType.NVarChar).Value = $"{Me.dgvItems.Rows(rowIndex).Cells("colAdds").Value}"
		cmd.Parameters.Add("@is_tab3", SqlDbType.Bit).Value = Conversion.Val($"{Me.dgvItems.Rows(rowIndex).Cells("colistab3").Value}")
		cmd.Parameters.Add("@item_tab3", SqlDbType.Float).Value = tab3Val

		cmd.ExecuteNonQuery()
	End Sub

#End Region

#Region "دوال القيود المحاسبية"

	Private Sub SaveAccountingRestrictions(transaction As SqlTransaction,
										clientAccountCode As Integer,
										stockAccountCode As Integer,
										purchRestCode As Integer,
										saleRestCode As Integer,
										centerCode As Integer)
		If Not Me.chkIsPaid.Checked Then Return

		Select Case Me.cmbProcType.SelectedIndex
			Case 0 ' فاتورة عادية
				SaveNormalInvoiceRestrictions(transaction, clientAccountCode, stockAccountCode,
										  purchRestCode, saleRestCode, centerCode)
			Case 1 ' فاتورة مرتجع
				SaveReturnInvoiceRestrictions(transaction, clientAccountCode, stockAccountCode,
										  purchRestCode, saleRestCode, centerCode)
			Case 2 ' مخزون أول المدة
				SaveOpeningStockRestrictions(transaction, purchRestCode)
		End Select
	End Sub

	Private Sub SaveNormalInvoiceRestrictions(transaction As SqlTransaction,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer,
										   purchRestCode As Integer,
										   saleRestCode As Integer,
										   centerCode As Integer)
		' قيود الشراء
		If Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
			SavePurchaseRestriction(transaction, purchRestCode, clientAccountCode, stockAccountCode)
		End If

		' قيود البيع
		If Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
			SaveSaleRestriction(transaction, saleRestCode, clientAccountCode, stockAccountCode, centerCode)
		End If
	End Sub

	Private Sub SavePurchaseRestriction(transaction As SqlTransaction,
									 restCode As Integer,
									 clientAccountCode As Integer,
									 stockAccountCode As Integer)
		Dim notes As String = $"فاتورة شراء {Me.cmbType.Text} رقم:{Me.Code} خاصة المورد:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة شراء{Me.cmbType.Text} رقم:{Me.Code} خاصة المورد:{Me.cmbClient.Text}"

		' إدخال القيد الرئيسي
		InsertRestriction(transaction, restCode, 1, notes)

		' المشتريات - مدين
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text), 0,
		3410001, notes)

		' ضريبة القيمة المضافة - مدين
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.lblTaxVal.Text), 0, 3410005, taxNotes)

		' المورد - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)
			InsertRestrictionSub(transaction, restCode, 0,
			Convert.ToDouble(Me.txtDiff.Text), stockAccountCode, notes)
		End If
	End Sub

	Private Sub SaveSaleRestriction(transaction As SqlTransaction,
								 restCode As Integer,
								 clientAccountCode As Integer,
								 stockAccountCode As Integer,
								 centerCode As Integer)
		Dim notes As String = $"فاتورة بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}"

		' إدخال القيد الرئيسي
		InsertRestriction(transaction, restCode, 2, notes)

		' العميل - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)

		' المبيعات - دائن
		Dim salesAccount As Integer = If(MainClass.IsAccTreeNew, 41010001, 4110001)
		Dim salesAmount As Double = Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text) -
								Conversion.Val(Me.lblTab3Val.Text) - Conversion.Val(Me.txtAppFee.Text)
		InsertRestrictionSubWithCenter(transaction, restCode, 0, salesAmount, salesAccount, notes, centerCode)

		' ضريبة القيمة المضافة - دائن
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 2100120001, 4110005)
		InsertRestrictionSub(transaction, restCode, 0,
		Conversion.Val(Me.lblTaxVal.Text), vatAccount, taxNotes)

		' رسوم التبغ - دائن
		If Conversion.Val(Me.lblTab3Val.Text) <> 0.0 Then
			Dim tobaccoAccount As Integer = If(MainClass.IsAccTreeNew, 2100120004, 4110009)
			InsertRestrictionSub(transaction, restCode, 0,
			Conversion.Val(Me.lblTab3Val.Text), tobaccoAccount,
			$"رسوم التبغ فاتورة بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' رسوم تطبيق الجوال - دائن
		If Me.rdApp.Checked AndAlso Conversion.Val(Me.txtAppFee.Text) <> 0.0 Then
			Dim appFeeAccount As Integer = If(MainClass.IsAccTreeNew, 2100120005, 4110010)
			InsertRestrictionSub(transaction, restCode, 0,
			Conversion.Val(Me.txtAppFee.Text), appFeeAccount,
			$"رسوم تطبيق الجوال فاتورة بيع  {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			SaveCashPaymentRestrictions(transaction, restCode, clientAccountCode, stockAccountCode, notes)
		End If
	End Sub

	Private Sub SaveCashPaymentRestrictions(transaction As SqlTransaction,
										 restCode As Integer,
										 clientAccountCode As Integer,
										 stockAccountCode As Integer,
										 notes As String)
		' النقدي
		If Conversion.Val(Me.txtCash.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtCash.Text), 0, stockAccountCode, notes)
		End If

		' الشبكة
		If Conversion.Val(Me.txtNetwork.Text) <> 0.0 Then
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtNetwork.Text), 0,
			Conversions.ToInteger(Me.cmbBanks.SelectedValue), notes)
		End If

		' العميل - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)
	End Sub

	Private Sub SaveReturnInvoiceRestrictions(transaction As SqlTransaction,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer,
										   purchRestCode As Integer,
										   saleRestCode As Integer,
										   centerCode As Integer)
		' قيود مرتجع الشراء
		If Convert.ToDouble(Me.txtTotPurch.Text) <> 0.0 Then
			SavePurchaseReturnRestriction(transaction, purchRestCode, clientAccountCode, stockAccountCode)
		End If

		' قيود مرتجع البيع
		If Convert.ToDouble(Me.txtTotSale.Text) <> 0.0 Then
			SaveSaleReturnRestriction(transaction, saleRestCode, clientAccountCode, stockAccountCode)
		End If
	End Sub

	Private Sub SavePurchaseReturnRestriction(transaction As SqlTransaction,
										   restCode As Integer,
										   clientAccountCode As Integer,
										   stockAccountCode As Integer)
		Dim notes As String = $"فاتورة مرتد شراء {Me.cmbType.Text} رقم:{Me.Code} خاصة المورد:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة مرتد شراء {Me.cmbType.Text} رقم:{Me.Code} خاصة المورد:{Me.cmbClient.Text}"

		InsertRestriction(transaction, restCode, 3, notes)

		' مرتجعات المشتريات - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text), 3410002, notes)

		' ضريبة القيمة المضافة - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Conversion.Val(Me.lblTaxVal.Text), 3410005, taxNotes)

		' المورد - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			InsertRestrictionSub(transaction, restCode, 0,
			Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtDiff.Text), 0, stockAccountCode, notes)
		End If
	End Sub

	Private Sub SaveSaleReturnRestriction(transaction As SqlTransaction,
									   restCode As Integer,
									   clientAccountCode As Integer,
									   stockAccountCode As Integer)
		Dim notes As String = $"فاتورة مرتد بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}"
		Dim taxNotes As String = $"ض. القيمة المضافة فاتورة مرتد بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}"

		InsertRestriction(transaction, restCode, 4, notes)

		' العميل - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), clientAccountCode, notes)

		' مرتجعات المبيعات - مدين
		Dim returnAccount As Integer = If(MainClass.IsAccTreeNew, 31010003, 4110003)
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.lblTaxVal.Text) - Conversion.Val(Me.lblTab3Val.Text),
		0, returnAccount, notes)

		' ضريبة القيمة المضافة - مدين
		Dim vatAccount As Integer = If(MainClass.IsAccTreeNew, 2100120001, 4110005)
		InsertRestrictionSub(transaction, restCode,
		Conversion.Val(Me.lblTaxVal.Text), 0, vatAccount, taxNotes)

		' رسوم التبغ - مدين
		If Conversion.Val(Me.lblTab3Val.Text) <> 0.0 Then
			Dim tobaccoAccount As Integer = If(MainClass.IsAccTreeNew, 2100120004, 4110009)
			InsertRestrictionSub(transaction, restCode,
			Conversion.Val(Me.lblTab3Val.Text), 0, tobaccoAccount,
			$"رسوم التبغ فاتورة مرتد بيع {Me.cmbType.Text} رقم:{Me.Code} خاصة العميل:{Me.cmbClient.Text}")
		End If

		' إذا كانت نقدية
		If Me.cmbType.SelectedIndex = 1 Then
			InsertRestrictionSub(transaction, restCode, 0,
			Convert.ToDouble(Me.txtDiff.Text), stockAccountCode, notes)
			InsertRestrictionSub(transaction, restCode,
			Convert.ToDouble(Me.txtDiff.Text), 0, clientAccountCode, notes)
		End If
	End Sub

	Private Sub SaveOpeningStockRestrictions(transaction As SqlTransaction, restCode As Integer)
		Dim notes As String = "مخزون أول المدة "

		InsertRestriction(transaction, restCode, 9, notes)

		' المخزون - دائن
		InsertRestrictionSub(transaction, restCode, 0,
		Convert.ToDouble(Me.txtDiff.Text), 2120001, notes)

		' البضاعة أول المدة - مدين
		InsertRestrictionSub(transaction, restCode,
		Convert.ToDouble(Me.txtDiff.Text), 0, 1270001, notes)
	End Sub

	Private Sub InsertRestriction(transaction As SqlTransaction,
							   id As Integer,
							   type As Integer,
							   notes As String)
		Dim sql As String = "INSERT INTO Restrictions(id, date, doc_no, type, state, notes, branch, IS_Deleted) " &
						"VALUES(@id, @date, @doc_no, @type, @state, @notes, @branch, @IS_Deleted)"

		Dim cmd As New SqlCommand(sql, Me.conn, transaction)
		cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
		cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Me.txtDate.Value
		cmd.Parameters.Add("@doc_no", SqlDbType.Int).Value = Me.Code
		cmd.Parameters.Add("@type", SqlDbType.Int).Value = type
		cmd.Parameters.Add("@state", SqlDbType.Int).Value = 1
		cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = notes
		cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainClass.BranchNo
		cmd.Parameters.Add("@IS_Deleted", SqlDbType.Bit).Value = 0
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

	Private Sub ProcessPostSaveOperations()
		Me.dgvSrch.Rows.Clear()

		' إدراج سند قبض تلقائي للفاتورة الآجلة الجديدة
		If Me.cmbType.SelectedIndex = 0 AndAlso Me.InvProc = 2 Then
			Try
				Dim frmSandQ As New frmSandQ()
				frmSandQ.InsertAuto(
				Convert.ToDouble(Me.txtPaid.Text),
				Conversions.ToInteger(Me.cmbClient.SelectedValue),
				Me.cmbClient.Text,
				Conversions.ToInteger(Me.cmbStock.SelectedValue),
				Me.cmbStock.Text,
				Me.txtDate.Value)
			Catch ex As Exception
			End Try
		End If

		' إرسال إلى شاشة العرض
		SendToCustomerDisplay()

		' عرض نافذة الإيصال
		ShowReceiptPopup()

		' مسح النموذج إذا كان الإعداد مفعلاً
		If Me._IsCLR Then
			ClearForm()
		End If
	End Sub

	Private Sub SendToCustomerDisplay()
		Try
			Me.sp.Open()
			Me.sp.Write(Convert.ToString(Convert.ToChar(12)))
			Me.sp.WriteLine("Total: " + Me.txtDiff.Text)
			Me.sp.Close()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub ShowReceiptPopup()
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

	Private Sub ClearForm()
		Me.cmbClient.SelectedIndex = -1
		Me.cmbCurrency.SelectedIndex = -1
		Me.txtVal1.Text = ""
		Me.txtExchangeVal.Text = ""
		Me.txtVal2.Text = ""
		Me.dgvItems.Rows.Clear()
		Me.txtCapital.Text = ""
		Me.txtTotPurch.Text = "0"
		Me.txtTotSale.Text = "0"
		Me.txtDiff.Text = "0"
		Me.txtMinusPerc.Text = "0"
		Me.LoadInvNo()
		Me.CLR()
		Me.cmbCurrency.Focus()
	End Sub

#End Region

#Region "دوال معالجة الأخطاء"

	Private Sub HandleSaveError(transaction As SqlTransaction, ex As Exception)
		Try
			transaction?.Rollback()
		Catch rollbackEx As Exception
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
		End Try
	End Sub

#End Region

	'//////////////////////////////

	Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
		Try
			Dim flag As Boolean = Me.Code <> -1
			If flag Then
				Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Open
				If flag2 Then
					Me.conn.Open()
				End If
				Dim sqlCommand As SqlCommand = New SqlCommand("update Inv set IS_Deleted=1 where proc_id=" + Conversions.ToString(Me.ProcCode), Me.conn)
				sqlCommand.ExecuteNonQuery()
				flag2 = (Me.RestPurchCode <> 0)
				If flag2 Then
					sqlCommand = New SqlCommand("update Restrictions set state=2 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.RestPurchCode), Me.conn)
					sqlCommand.ExecuteNonQuery()
				End If
				flag2 = (Me.RestSaleCode <> 0)
				If flag2 Then
					sqlCommand = New SqlCommand("update Restrictions set state=2 where branch=" + Conversions.ToString(MainClass.BranchNo) + " and id=" + Conversions.ToString(Me.RestSaleCode), Me.conn)
					sqlCommand.ExecuteNonQuery()
				End If
				Dim text As String = "تم الحذف"
				flag2 = (Operators.CompareString(MainClass.Language, "en", False) = 0)
				If flag2 Then
					text = "Deleted"
				End If
				MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.dgvSrch.Rows.Clear()
				Me.CLR()
			Else
				Dim text2 As String = "اختر فاتورة ليتم حذفها"
				Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
				If flag2 Then
					text2 = "choose invoice to be deleted"
				End If
				MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		Catch ex As Exception
			Dim text3 As String = "خطأ أثناء الحذف"
			Dim flag2 As Boolean = Operators.CompareString(MainClass.Language, "en", False) = 0
			If flag2 Then
				text3 = "error in deleting"
			End If
			flag2 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag2 Then
				text3 = text3 + Environment.NewLine + "تفاصيل الخطأ: " + ex.Message
			Else
				text3 = text3 + Environment.NewLine + "Error details: " + ex.Message
			End If
			MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		Finally
			Dim flag2 As Boolean = Me.conn.State <> ConnectionState.Closed
			If flag2 Then
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
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
		End If
	End Sub

	Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
	'///////////////////////////////
	Private Sub ReadData(dr As SqlDataReader)
		If Not dr.HasRows Then
			Me.CLR()
			Return
		End If

		dr.Read()
		Me.CLR()
		Me._IsCalcTot = False

		'========================
		' Basic Invoice Info
		'========================
		Me.ProcCode = Convert.ToInt32(dr("proc_id"))
		Me.RestPurchCode = Convert.ToInt32(dr("purch_rest_id"))
		Me.RestSaleCode = Convert.ToInt32(dr("sale_rest_id"))
		Me.cmbProcType.SelectedIndex = Convert.ToInt32(dr("proc_type")) - 1
		Me.Code = Convert.ToInt32(dr("id"))

		Me.txtNo.Text = Me.Code.ToString()
		Me.txtDate.Value = Convert.ToDateTime(dr("date"))
		Me.cmbType.SelectedIndex = Convert.ToInt32(dr("inv_type")) - 1
		Me.cmbSafe.SelectedValue = dr("safe")
		Me.cmbStock.SelectedValue = dr("stock")
		Me.cmbClient.SelectedValue = dr("cust_id")

		' البيانات الاختيارية
		If Not IsDBNull(dr("tab3tax")) Then
			Me.txtTab3Perc.Text = dr("tab3tax").ToString()
		End If

		If Not IsDBNull(dr("minus")) Then
			Me.txtMinusVal.Text = dr("minus").ToString()
		End If

		' القيم المالية
		Me.txtTotPurch.Text = Format(Convert.ToDouble(dr("tot_purch")), "0.#,##.##")
		Me.txtTotSale.Text = Format(Convert.ToDouble(dr("tot_sale")), "0.#,##.##")
		Me.txtDiff.Text = Format(Convert.ToDouble(dr("tot_net")), "0.#,##.##")

		If Not IsDBNull(dr("paid")) Then
			Me.txtPaid.Text = Format(Convert.ToDouble(dr("paid")), "0.#,##.##")
		End If

		If Not IsDBNull(dr("tax")) Then
			Me.txtTax.Text = dr("tax").ToString()
		End If

		'========================
		' Salesman
		'========================
		If Not IsDBNull(dr("salesman")) AndAlso Convert.ToInt32(dr("salesman")) <> -1 Then
			Me.cmbSalesMen.SelectedValue = dr("salesman")
		End If

		'========================
		' Payment Type
		'========================
		If Me.cmbType.SelectedIndex = 1 Then
			Dim payType As Integer = Convert.ToInt32(dr("pay_type"))
			Select Case payType
				Case 1
					Me.rdCash.Checked = True
				Case 2
					Me.rdNetwork.Checked = True
					If Not IsDBNull(dr("bank")) Then
						Me.cmbBanks.SelectedValue = dr("bank")
					End If
			End Select
		End If

		'========================
		' Return Invoice
		'========================
		If Me.cmbProcType.SelectedIndex = 1 Then
			Me.txtSrcInvNo.Text = dr("InvId_Return").ToString()
		End If

		'========================
		' Restaurant / App Logic
		'========================
		Dim restType As Integer = Convert.ToInt32(dr("rest_type"))

		Select Case restType
			Case 1, 3
				If restType = 1 Then
					Me.rdIn.Checked = True
				Else
					Me.rdIn2.Checked = True
				End If

				' تحميل بيانات الطاولة
				If Not IsDBNull(dr("tawla")) Then
					LoadTawlaData(Convert.ToInt32(dr("tawla")))
				End If

			Case 6
				Me.rdApp.Checked = True

				If Not IsDBNull(dr("mobapp_id")) AndAlso Convert.ToInt32(dr("mobapp_id")) <> -1 Then
					Me.cmbApps.SelectedValue = dr("mobapp_id")
				End If

				If Not IsDBNull(dr("fees")) Then
					Me.txtAppFee.Text = dr("fees").ToString()
				End If

				If Not IsDBNull(dr("is_paid_online")) Then
					Me.chkPaidOnline.Checked = Convert.ToBoolean(dr("is_paid_online"))
				End If

			Case Else
				Me.rdOut.Checked = True
		End Select

		'========================
		' Payment Split
		'========================
		If Not IsDBNull(dr("cash_part")) Then
			Me.txtCash.Text = dr("cash_part").ToString()
		End If

		If Not IsDBNull(dr("network_part")) Then
			Me.txtNetwork.Text = dr("network_part").ToString()
		End If

		'========================
		' Paid Status
		'========================
		If Not IsDBNull(dr("tawla_paid")) Then
			Me.chkIsPaid.Checked = Convert.ToBoolean(dr("tawla_paid"))
		End If

		Me._Ispaid = Me.chkIsPaid.Checked

		' المركز
		If Not IsDBNull(dr("center")) Then
			Me.cmbCenter.SelectedValue = dr("center")
		End If

		Me.LoadOrderNo()
		dr.Close()

		'========================
		' Load Items
		'========================
		Me._IsCalcTot = True
		LoadInvoiceItems()

		Me.CalcTot()
		Me.DGV_Count = Me.dgvItems.Rows.Count
	End Sub

	Private Sub LoadTawlaData(tawlaId As Integer)
		Try
			Dim query As String = String.Format(
			"SELECT tawla.name AS tawla, tawla_groups.name AS groupname " &
			"FROM tawla, tawla_groups " &
			"WHERE tawla.tawla_group = tawla_groups.id " &
			"AND tawla.id = {0}", tawlaId)

			Using da As New SqlDataAdapter(query, Me.conn1)
				Dim dt As New DataTable()
				da.Fill(dt)

				If dt.Rows.Count = 0 Then Return

				Dim groupName As String = dt.Rows(0)("groupname").ToString()
				Dim tawlaName As String = dt.Rows(0)("tawla").ToString()

				' تحديد المجموعة
				For col As Integer = 0 To Me.dgvTawlaGroups.Columns.Count - 1
					If Me.dgvTawlaGroups.Rows(0).Cells(col).Value.ToString() = groupName Then
						Me.dgvTawlaGroups.Rows(0).Cells(col).Selected = True
						Me.LoadTawla(groupName)
						Exit For
					End If
				Next

				' تحديد الطاولة
				For row As Integer = 0 To Me.dgvTawlas.Rows.Count - 1
					For col As Integer = 0 To Me.dgvTawlas.Columns.Count - 1
						If Me.dgvTawlas.Rows(row).Cells(col).Value.ToString() = tawlaName Then
							Me.dgvTawlas.Rows(row).Cells(col).Selected = True
							Return
						End If
					Next
				Next
			End Using
		Catch ex As Exception
			' تجاهل الخطأ في حالة عدم العثور على الطاولة
		End Try
	End Sub

	Private Sub LoadInvoiceItems()
		Dim query As String = "SELECT * FROM Inv_Sub WHERE proc_id = " & Me.ProcCode
		Using da As New SqlDataAdapter(query, Me.conn)
			Dim dt As New DataTable()
			da.Fill(dt)

			For i As Integer = 0 To dt.Rows.Count - 1
				Me.dgvItems.Rows.Add()
				Dim row = Me.dgvItems.Rows(i)

				' البيانات الأساسية
				row.Cells(0).Value = Me.Code

				' نوع العملية (شراء/بيع)
				Dim procType As Integer = Val(dt.Rows(i)("proc_type"))
				row.Cells(1).Value = If(procType = 1, "شراء", "بيع")

				' اسم العملة
				row.Cells(2).Value = GetCurrencyName(Val(dt.Rows(i)("currency_from")))

				' اسم الوحدة
				row.Cells(3).Value = GetUnitName(Val(dt.Rows(i)("unit")))

				' القيم الرقمية
				row.Cells(4).Value = dt.Rows(i)("val1")
				row.Cells(5).Value = dt.Rows(i)("val")

				' حساب نسبة الوحدة (المنطق الأصلي من الكود)
				Dim unitPerc As Decimal = 1D
				Dim unitId As Object = dt.Rows(i)("unit")
				Dim currencyId As Object = dt.Rows(i)("currency_from")

				If Not IsDBNull(unitId) AndAlso Not IsDBNull(currencyId) Then
					Dim percQuery As String = String.Format(
					"SELECT curr_units.perc FROM Currencies, curr_units " &
					"WHERE Currencies.id = curr_units.curr " &
					"AND curr_units.unit = {0} AND curr_units.curr = {1}",
					unitId, currencyId)

					Try
						Using percCommand As New SqlCommand(percQuery, Me.conn)
							If Me.conn.State <> ConnectionState.Open Then
								Me.conn.Open()
							End If

							Dim result = percCommand.ExecuteScalar()
							If result IsNot Nothing AndAlso Not IsDBNull(result) Then
								unitPerc = Conversion.Val(result)
							End If

							If Me.conn.State = ConnectionState.Open Then
								Me.conn.Close()
							End If
						End Using
					Catch ex As Exception
						' في حالة الخطأ، نستخدم القيمة الافتراضية 1
						unitPerc = 1D
					End Try
				End If

				row.Cells(6).Value = unitPerc

				' سعر الصرف والإجمالي
				row.Cells(7).Value = dt.Rows(i)("exchange_price")

				Dim val1 As Double = Conversion.Val(dt.Rows(i)("val1"))
				Dim exchangePrice As Double = Conversion.Val(dt.Rows(i)("exchange_price"))
				row.Cells(8).Value = Math.Round(val1 * exchangePrice, 5)

				' المعرفات والبيانات الإضافية
				row.Cells(9).Value = dt.Rows(i)("currency_from")

				If Not IsDBNull(dt.Rows(i)("item_adds")) Then
					row.Cells("colAdds").Value = dt.Rows(i)("item_adds").ToString()
				End If

				row.Cells("colold").Value = 1

				' بيانات التبغ (tab3)
				If Not IsDBNull(dt.Rows(i)("is_tab3")) Then
					Dim isTab3 As Boolean = Convert.ToBoolean(dt.Rows(i)("is_tab3"))
					If isTab3 Then
						row.Cells("colistab3").Value = "1"

						If Not IsDBNull(dt.Rows(i)("item_tab3")) Then
							row.Cells("coltab3val").Value = Conversion.Val(dt.Rows(i)("item_tab3"))
						End If
					End If
				End If
			Next
		End Using
	End Sub


	'///////////////////////////////

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
			Me.txtExchangeValD.Text = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtExchangeVal.Text) / Me._Exchangeal, 2))
			Me.txtVal2D.Text = String.Format("{0:#,##.##}", Math.Round(Convert.ToDouble(Me.txtVal2.Text) / Me._Exchangeal, 2))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=0 and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 order by id desc"}))
	End Sub

	Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=0 and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 and id>", Conversions.ToString(Me.Code), " order by id asc"}))
	End Sub

	Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=0 and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 order by id asc"}))
	End Sub

	Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
		Dim text As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		Me.Navigate(String.Concat(New String() {"select top 1 * from Inv where ", text, " is_buy=0 and proc_type=", Conversions.ToString(Me.cmbProcType.SelectedIndex + 1), " and IS_Deleted=0 and id<", Conversions.ToString(Me.Code), " order by id desc"}))
	End Sub

	Private Sub CalcPrice()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price,sale_price from Currencies  where id= ", Me.cmbCurrency.SelectedValue)), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_price"))))
			Else
				Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_price"))))
			End If
		Catch ex As Exception
		End Try
		Try
			Dim flag As Boolean = Me.InvProc = 2 And Me._lastclientsale
			If flag Then
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 inv_sub.exchange_price from inv,inv_sub where inv.proc_id=inv_sub.proc_id and  is_deleted=0 and cust_id=", Me.cmbClient.SelectedValue), " and inv.proc_type=1 and is_buy=0 and "), " inv_sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv_sub.unit="), Me.cmbUnits.SelectedValue), " order by inv.date desc")), Me.conn1)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = (dataTable2.Rows.Count > 0)
				If flag Then
					Me._IsLastClientSaleDo = True
					Me.txtExchangeVal.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))))
				End If
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCurrency.SelectedIndexChanged
		Try
			Try
				Dim flag As Boolean = Me.rdNormal.Checked
				If flag Then
					Me.LoadUnits(Conversions.ToInteger(Me.cmbCurrency.SelectedValue))
				End If
			Catch ex As Exception
			End Try
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select group_id,unit from Currencies where id=", Me.cmbCurrency.SelectedValue)), Me.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
					Try
						Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(1))
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
			Me.txtExchangeVal.Text = ""
			Me.txtVal2.Text = ""
			Me.CalcPrice()
			Me.txtVal1.Focus()
		Catch ex4 As Exception
		End Try
	End Sub

	Private Sub Search()
		Dim str As String = ""
		Dim flag As Boolean = MainClass.BranchNo <> -1
		If flag Then
			str = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
		End If
		flag = (Operators.CompareString(Me.txtSrchNo.Text, "", False) <> 0)
		Dim cond As String
		If flag Then
			cond = str + " inv.id=" + Me.txtSrchNo.Text + " and "
		Else
			cond = str + " date>=@date1 and date<=@date2 and "
		End If
		Me.LoadDG(cond)
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

	Private Sub frmSalePurch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) ' Handles frmSalePurch.KeyDown
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
						Me.PrintRptEn(2)
					End If
				Else
					flag2 = (e.KeyCode = Keys.F5)
					If flag2 Then
						flag = Me.btnPrint.Enabled
						If flag Then
							Me.PrintRptA4(1)
						End If
					Else
						flag2 = (e.KeyCode = Keys.F9)
						If flag2 Then
							Me.txtNetwork.Focus()
							Me.txtCash.Text = "0"
							Me.txtNetwork.Text = Me.txtDiff.Text
						Else
							flag2 = (e.KeyCode = Keys.[Return])
							If flag2 Then
								SendKeys.Send("{TAB}")
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
			Me._focusedtxt = Me.txtVal1
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtExchangeVal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtExchangeVal.Enter
		Try
			Me.txtExchangeVal.SelectAll()
			Me._focusedtxt = Me.txtExchangeVal
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
							Me.Text = "مرتد مبيعات"
						Else
							flag = (Me.cmbProcType.SelectedIndex = 2)
							If flag Then
								Me.Text = "أصناف أول المدة"
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
			Dim flag As Boolean = e.ColumnIndex = 11
			If flag Then
				Dim text As String = "هل تريد حذف السجل"
				flag = (Operators.CompareString(MainClass.Language, "en", False) = 0)
				If flag Then
					text = "Do you want to delete this record"
				End If
				Dim dialogResult As DialogResult = MessageBox.Show(text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				flag = (dialogResult = DialogResult.Yes)
				If flag Then
					Me.dgvItems.Rows.Remove(Me.dgvItems.Rows(e.RowIndex))
					Me.CalcTot()
				End If
			Else
				flag = (e.ColumnIndex = 12)
				If flag Then
					Try
						Dim frmRestAdds As frmRestAdds = New frmRestAdds()
						flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells("colAdds").Value), "", False)
						If flag Then
							frmRestAdds.txtAdds.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells("colAdds").Value))
						End If
						frmRestAdds.lblName.Text = Me.GetCurrencyName(Conversions.ToInteger(Me.dgvItems.Rows(e.RowIndex).Cells(9).Value))
						frmRestAdds.ShowDialog()
						Me.dgvItems.Rows(e.RowIndex).Cells("colAdds").Value = frmRestAdds.txtAdds.Text
					Catch ex As Exception
					End Try
				Else
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select group_id from Currencies where id=", Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					Dim num As Integer = CInt(Math.Round(Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))))
					Me.cmbGroups.SelectedValue = num
					Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)
					Try
						Me.cmbUnits.SelectedValue = Me.GetUnitID(Conversions.ToString(Me.dgvItems.Rows(e.RowIndex).Cells(3).Value))
					Catch ex2 As Exception
					End Try
					Me.txtVal1.Text = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(e.RowIndex).Cells(4).Value))
					Me.txtExchangeVal.Text = Conversions.ToString(Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(7).Value)))
					Try
						Me._lastitemprice = Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(7).Value))
					Catch ex3 As Exception
					End Try
					Me.txtVal2.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(8).Value)))
					Try
						Me.txtExpireDate.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(e.RowIndex).Cells(10).Value))
					Catch ex4 As Exception
					End Try
					Me._IsUpdateDG = True
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
				Else
					Me.Navigate(String.Concat(New String() {"select * from Inv where ", text, " IS_Buy=", Conversions.ToString(value), " and IS_Deleted=0 and proc_type=1 and  id=", Me.txtSrcInvNo.Text}))
					Me.cmbProcType.SelectedIndex = 1
					Me.ProcCode = -1
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
		Me._lastitemprice = 0.0
		Me._IsUpdateDG = False
		Me.cmbCurrency.Focus()
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

	Private Sub cmbCurrency_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbCurrency.KeyDown
	End Sub

	Private Function GetEmpName(emp As Integer) As String
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select name from Employees where id=" + Conversions.ToString(emp), Me.conn)
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

	Private Sub PrintRpt(type As Integer)
		Dim flag As Boolean = Me.dgvItems.Rows.Count = 0
		If flag Then
			MessageBox.Show("لا توجد عمليات شراء أو بيع بالجدول", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Me.cmbSafe.Focus()
		Else
			flag = (Me.ProcCode = -1)
			If flag Then
				Me.LoadInvNo()
				Me.LoadOrderNo()
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
			Dim flag2 As Boolean
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				Dim currencyNameEN As String = Me.GetCurrencyNameEN(Conversions.ToInteger(Me.dgvItems.Rows(num3).Cells(9).Value))
				Dim text As String = Me.dgvItems.Rows(num3).Cells(2).Value.ToString()
				flag = (Operators.CompareString(currencyNameEN, "", False) <> 0)
				If flag Then
					text = text + " - " + currencyNameEN
				End If
				text = Conversions.ToString(Operators.ConcatenateObject(text + " - ", Me.dgvItems.Rows(num3).Cells(3).Value))
				flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colAdds").Value), "", False)
				If flag Then
					text = Conversions.ToString(Operators.ConcatenateObject(text + " - ", Me.dgvItems.Rows(num3).Cells("colAdds").Value))
				End If
				flag = Me._ActvRestPrintNew
				If flag Then
					flag2 = Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colistab3").Value), "1", False)
					If flag2 Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Environment.NewLine + "رسوم تبغ " + Me.txtTab3Perc.Text + " %" + "   ", Me.dgvItems.Rows(num3).Cells("coltab3val").Value)))
					End If
					Dim num6 As Double = Conversion.Val(Me.txtTotSale.Text)
					Dim num7 As Double = Math.Round(Conversion.Val(Me.txtMinusVal.Text) / If((num6 = 0.0), 1.0, num6) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)), 2)
					Dim value As Double = Conversion.Val(Me.txtTax.Text) / 100.0 * (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)) - num7 + Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("coltab3val").Value)))
					text = String.Concat(New String() {text, Environment.NewLine, "ضريبة القيمة المضافة ", Me.txtTax.Text, " %   ", Conversions.ToString(Math.Round(value, 2))})
				End If
				dataTable.Rows.Add(New Object() {text, RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)})
				num3 += 1
			End While
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable2)
			Dim num8 As Integer = 1
			Try
				flag2 = Operators.ConditionalCompareObjectEqual(dataTable2.Rows(0)("rptinv_type"), 2, False)
				If flag2 Then
					num8 = 2
				End If
			Catch ex As Exception
			End Try
			Dim num9 As Decimal = 1D
			Dim value2 As Decimal = Me.NumericUpDown1.Value
			Dim num10 As Decimal = num9
			While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num10, value2, 1D)
				flag2 = Me._ActvRestPrintNew
				Dim obj As Object
				If flag2 Then
					obj = New rptInvRest2()
				Else
					flag2 = (num8 = 1)
					If flag2 Then
						obj = New rptInvRest()
					Else
						obj = New rptInvRestNoTable()
					End If
				End If
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
				Dim text2 As String = ""
				Try
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
					Dim dataTable3 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable3)
					text2 = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)(0)))
				Catch ex2 As Exception
				End Try
				Try
					Dim textObject As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lblHeader"}, Nothing, Nothing, Nothing), TextObject)
					flag2 = (Me.cmbProcType.SelectedIndex = 3)
					If flag2 Then
						textObject.Text = "عرض سعر"
					Else
						flag2 = (Me.cmbProcType.SelectedIndex = 0)
						If flag2 Then
							flag = (Me.InvProc = 1)
							If flag Then
								textObject.Text = "فاتورة مشتريات"
							Else
								flag2 = (Me.InvProc = 2)
								If flag2 Then
									textObject.Text = "فاتورة ضريبية مبسطة"
									flag2 = (Operators.CompareString(text2, "", False) <> 0)
									If flag2 Then
										textObject.Text = "فاتورة ضريبية"
									End If
									flag2 = (Operators.CompareString(Me.taxno, "", False) = 0)
									If flag2 Then
										textObject.Text = "فاتورة مبيعات"
									End If
									flag2 = (Operators.CompareString(Me.Sales_title2, "", False) <> 0)
									If flag2 Then
										textObject.Text = Me.Sales_title2
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
				Catch ex3 As Exception
				End Try
				Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"invno"}, Nothing, Nothing, Nothing), TextObject)
				textObject2.Text = Me.txtNo.Text
				Dim str As String = ""
				flag2 = (Me.rdIn.Checked Or Me.rdIn2.Checked)
				If flag2 Then
					str = " - " + Me.dgvTawlas.SelectedCells(0).Value.ToString()
				End If
				Try
					Dim str2 As String = "محلي أفراد"
					flag2 = Me.rdOut.Checked
					If flag2 Then
						str2 = "خارجي"
					Else
						flag2 = Me.rdIn2.Checked
						If flag2 Then
							str2 = "محلي عوائل"
						Else
							flag2 = Me.rdApp.Checked
							If flag2 Then
								str2 = Me.cmbApps.Text
							End If
						End If
					End If
					Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"type"}, Nothing, Nothing, Nothing), TextObject)
					textObject3.Text = str2 + str
				Catch ex4 As Exception
				End Try
				Try
					Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"no2"}, Nothing, Nothing, Nothing), TextObject)
					textObject4.Text = Me.txtOrderNo.Text
				Catch ex5 As Exception
				End Try
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"date"}, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.txtDate.Value.ToShortDateString()
				Try
					Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"client"}, Nothing, Nothing, Nothing), TextObject)
					textObject6.Text = Me.cmbClient.Text
				Catch ex6 As Exception
				End Try
				Try
					Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"vat_no"}, Nothing, Nothing, Nothing), TextObject)
					textObject7.Text = text2
				Catch ex7 As Exception
				End Try
				Try
					Dim text3 As String = ""
					flag2 = (Me.cmbType.SelectedIndex = 0)
					If flag2 Then
						text3 = "آجل"
					Else
						flag2 = (Conversion.Val(Me.txtCash.Text) <> 0.0 And Conversion.Val(Me.txtNetwork.Text) = 0.0)
						If flag2 Then
							text3 = "نقدي"
						Else
							flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) = 0.0)
							If flag2 Then
								text3 = "شبكة"
							Else
								flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0 And Conversion.Val(Me.txtCash.Text) <> 0.0)
								If flag2 Then
									text3 = "نقدي وشبكة"
								End If
							End If
						End If
					End If
					Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"paytype"}, Nothing, Nothing, Nothing), TextObject)
					textObject8.Text = text3
				Catch ex8 As Exception
				End Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttime"}, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.txtInvTime.Text
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttab3"}, Nothing, Nothing, Nothing), TextObject)
				flag2 = Me._ActvRestPrintNew
				If flag2 Then
					Dim textObject11 As TextObject = textObject10
					textObject11.Text = textObject11.Text + "رسوم التبغ  " + Me.txtTab3Perc.Text + " %"
					Try
						Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"sum"}, Nothing, Nothing, Nothing), TextObject)
						textObject12.Text = Me.txtTotSale.Text
					Catch ex9 As Exception
					End Try
					Try
						Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"disc"}, Nothing, Nothing, Nothing), TextObject)
						textObject13.Text = Me.txtMinusVal.Text
					Catch ex10 As Exception
					End Try
					Try
						Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tab3"}, Nothing, Nothing, Nothing), TextObject)
						textObject14.Text = Me.lblTab3Val.Text
					Catch ex11 As Exception
					End Try
					Try
						Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"net"}, Nothing, Nothing, Nothing), TextObject)
						textObject15.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
					Catch ex12 As Exception
					End Try
					Try
						Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"cash"}, Nothing, Nothing, Nothing), TextObject)
						textObject16.Text = Conversions.ToString(Conversion.Val(Me.txtCash.Text))
					Catch ex13 As Exception
					End Try
					Try
						Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"visa"}, Nothing, Nothing, Nothing), TextObject)
						textObject17.Text = Conversions.ToString(Conversion.Val(Me.txtNetwork.Text))
					Catch ex14 As Exception
					End Try
				Else
					flag2 = (Conversion.Val(Me.txtMinusVal.Text) <> 0.0)
					If flag2 Then
						textObject10.Text = "خصم  " + Me.txtMinusVal.Text
					End If
					flag2 = (Conversion.Val(Me.lblTab3Val.Text) <> 0.0)
					If flag2 Then
						flag = (Operators.CompareString(textObject10.Text, "", False) <> 0)
						Dim textObject11 As TextObject
						If flag Then
							textObject11 = textObject10
							textObject11.Text += "        "
						End If
						textObject11 = textObject10
						textObject11.Text = String.Concat(New String() {textObject11.Text, "رسوم التبغ  ", Me.txtTab3Perc.Text, " %   قيمته  ", Me.lblTab3Val.Text})
					End If
				End If
				Dim textObject18 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"taxperc"}, Nothing, Nothing, Nothing), TextObject)
				textObject18.Text = Me.txtTax.Text + " %"
				Dim textObject19 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
				textObject19.Text = Me.lblTaxVal.Text
				Try
					flag2 = (Me.rdApp.Checked And Conversion.Val(Me.txtAppFee.Text) <> 0.0)
					If flag2 Then
						Dim textObject20 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"app_fee"}, Nothing, Nothing, Nothing), TextObject)
						textObject20.Text = "رسوم التطبيق = " + Conversions.ToString(Conversion.Val(Me.txtAppFee.Text))
					End If
				Catch ex15 As Exception
				End Try
				Dim textObject21 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tot"}, Nothing, Nothing, Nothing), TextObject)
				textObject21.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
				Try
					flag2 = Me._ActvRestPrintNew
					If flag2 Then
						flag = (Conversion.Val(Me.txtrec.Text) <> 0.0)
						If flag Then
							Dim textObject22 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtrec"}, Nothing, Nothing, Nothing), TextObject)
							Dim textObject11 As TextObject = textObject22
							textObject11.Text = String.Concat(New String() {textObject11.Text, "المستلم: ", Me.txtrec.Text, " - المتبقي: ", Me.txtrecrem.Text})
						End If
					Else
						flag2 = (Conversion.Val(Me.txtrec.Text) <> 0.0)
						If flag2 Then
							Dim textObject23 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtrec"}, Nothing, Nothing, Nothing), TextObject)
							flag2 = (Conversion.Val(Me.txtNetwork.Text) <> 0.0)
							If flag2 Then
								textObject23.Text = "مدفوع شبكة: " + Me.txtNetwork.Text + " - "
							End If
							Dim textObject11 As TextObject = textObject23
							textObject11.Text = String.Concat(New String() {textObject11.Text, "المستلم: ", Me.txtrec.Text, " - المتبقي: ", Me.txtrecrem.Text})
						End If
					End If
				Catch ex16 As Exception
				End Try
				Dim textObject24 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"user"}, Nothing, Nothing, Nothing), TextObject)
				textObject24.Text = Me.GetSalesEmpNameByInvNo()
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
				Try
					Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter("select img as logo from branches where id=" + Conversions.ToString(MainClass.BranchNo), Me.conn)
					Dim dataTable4 As DataTable = New DataTable()
					sqlDataAdapter3.Fill(dataTable4)
					flag2 = (dataTable4.Rows(0)("logo") IsNot DBNull.Value)
					If flag2 Then
						dataTable4.Columns.Add("NameA")
						dataTable4.Columns.Add("NameE")
						dataTable4.Rows(0)("NameA") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameA"))
						dataTable4.Rows(0)("NameE") = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("NameE"))
						Dim instance3 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
						Dim type4 As Type = Nothing
						Dim memberName3 As String = "SetDataSource"
						Dim array4 As Object() = New Object() {dataTable4}
						Dim arguments3 As Object() = array4
						Dim argumentNames3 As String() = Nothing
						Dim typeArguments3 As Type() = Nothing
						array2 = New Boolean() {True}
						NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
						If array2(0) Then
							dataTable4 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(DataTable)), DataTable)
						End If
					End If
				Catch ex17 As Exception
				End Try
				Try
					Dim img As Image = MainClass.qrcodeGen(1, Me.txtNo.Text, Me.txtDate.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"), Me.cmbClient.Text, text2, Conversions.ToString(dataTable2.Rows(0)("nameA")), Me.taxno, Me.lblTaxVal.Text, Me.txtDiff.Text)
					Dim dataTable5 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable5)
					dataTable5.Columns("Logo").ColumnName = "barcode"
					dataTable5.Rows(0)("barcode") = MainClass.Image2Arr(img)
					Dim instance4 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptQR"}, Nothing, Nothing, Nothing)
					Dim type5 As Type = Nothing
					Dim memberName4 As String = "SetDataSource"
					Dim array4 As Object() = New Object() {dataTable5}
					Dim arguments4 As Object() = array4
					Dim argumentNames4 As String() = Nothing
					Dim typeArguments4 As Type() = Nothing
					array2 = New Boolean() {True}
					NewLateBinding.LateCall(instance4, type5, memberName4, arguments4, argumentNames4, typeArguments4, array2, True)
					If array2(0) Then
						dataTable5 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(DataTable)), DataTable)
					End If
				Catch ex18 As Exception
				End Try
				Dim textObject25 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing), Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
				textObject25.Text = Me.taxno
				flag2 = (dataTable2.Rows.Count > 0)
				If flag2 Then
					Dim textObject26 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
					textObject26.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Address")))
					Dim textObject27 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTel"}, Nothing, Nothing, Nothing), TextObject)
					textObject27.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Tel")))
					Dim textObject28 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
					textObject28.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)("Mobile")))
					Try
						Dim instance5 As Object = obj
						Dim type6 As Type = Nothing
						Dim memberName5 As String = "SetParameterValue"
						array3 = New Object(1) {}
						array3(0) = "msg"
						Dim array5 As Object() = array3
						Dim num11 As Integer = 1
						Dim dataRow As DataRow = dataTable2.Rows(0)
						Dim dataRow2 As DataRow = dataRow
						Dim columnName As String = "msg"
						array5(num11) = RuntimeHelpers.GetObjectValue(dataRow2(columnName))
						array = array3
						Dim arguments5 As Object() = array
						Dim argumentNames5 As String() = Nothing
						Dim typeArguments5 As Type() = Nothing
						array2 = New Boolean() {False, True}
						NewLateBinding.LateCall(instance5, type6, memberName5, arguments5, argumentNames5, typeArguments5, array2, True)
						If array2(1) Then
							dataRow(columnName) = RuntimeHelpers.GetObjectValue(array(1))
						End If
					Catch ex19 As Exception
						NewLateBinding.LateCall(obj, Nothing, "SetParameterValue", New Object() {"msg", ""}, Nothing, Nothing, Nothing, True)
					End Try
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
					frmRptViewer.TopMost = True
					frmRptViewer.Show()
				Else
					flag2 = Me.chkIsPaid.Checked
					If flag2 Then
						Try
							crystalReportViewer.ShowLastPage()
							Dim num12 As Integer = crystalReportViewer.GetCurrentPageNumber()
							crystalReportViewer.ShowFirstPage()
							Dim instance6 As Object = obj
							Dim type7 As Type = Nothing
							Dim memberName6 As String = "PrintToPrinter"
							array = New Object() {1, False, 1, num12}
							Dim arguments6 As Object() = array
							Dim argumentNames6 As String() = Nothing
							Dim typeArguments6 As Type() = Nothing
							array2 = New Boolean() {False, False, False, True}
							NewLateBinding.LateCall(instance6, type7, memberName6, arguments6, argumentNames6, typeArguments6, array2, True)
							If array2(3) Then
								num12 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
							End If
						Catch ex20 As Exception
						End Try
					End If
				End If
				num10 = Decimal.Add(num10, 1D)
			End While
			flag2 = (type = 2)
			If flag2 Then
				Dim flag3 As Boolean = False
				flag2 = (Me.rdOut.Checked Or ((Me.rdIn.Checked Or Me.rdIn2.Checked) And Not Me.chkIsPaid.Checked))
				If flag2 Then
					flag3 = True
				End If
				flag2 = flag3
				If flag2 Then
					Me.Print_Sub()
				End If
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = True
				Try
					flag5 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)("print_opentawlas")))
				Catch ex21 As Exception
				End Try
				flag2 = (flag5 And (Me.rdIn.Checked Or Me.rdIn2.Checked))
				If flag2 Then
					flag4 = True
				End If
				Me.btnSave_Click(Nothing, Nothing)
				flag2 = flag4
				If flag2 Then
					Me.Close()
					Dim frmTawlasManage As frmTawlasManage = New frmTawlasManage()
					frmTawlasManage.Show()
					frmTawlasManage.Activate()
				End If
			End If
		End If
	End Sub

	Private Sub Print_Sub()
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
				Dim flag As Boolean = Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colold").Value)) <> 1.0
				If flag Then
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells(2).Value))
					Dim currencyNameEN As String = Me.GetCurrencyNameEN(Conversions.ToInteger(Me.dgvItems.Rows(num3).Cells(9).Value))
					flag = (Operators.CompareString(currencyNameEN, "", False) <> 0)
					If flag Then
						text = text + " - " + currencyNameEN
					End If
					flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("colAdds").Value), "", False)
					If flag Then
						text = Conversions.ToString(Operators.ConcatenateObject(text + " - ", Me.dgvItems.Rows(num3).Cells("colAdds").Value))
					End If
					Dim num6 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(8).Value)) - Conversion.Val(Operators.ConcatenateObject("", Me.dgvItems.Rows(num3).Cells("coldisc").Value))
					num6 *= 1.0 + Conversion.Val(Me.txtTax.Text) / 100.0
					dataTable.Rows.Add(New Object() {RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(0).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(1).Value), text, RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(3).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(4).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(5).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(6).Value), RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(7).Value), num6, RuntimeHelpers.GetObjectValue(Me.dgvItems.Rows(num3).Cells(9).Value), 0})
				End If
				num3 += 1
			End While
			Me.PrintToGroups(dataTable)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Printsub(dt As DataTable, _printer As String, Optional _groupname As String = "")
		Try
			Dim reportDocument As ReportDocument = New ReportDocument()
			Dim flag As Boolean = Me._KitPrinterType = 2
			If flag Then
				reportDocument.Load(System.Windows.Forms.Application.StartupPath + "\\rpt\\rptInvGG.rpt")
			Else
				reportDocument.Load(System.Windows.Forms.Application.StartupPath + "\\rpt\\rptInvG.rpt")
			End If
			reportDocument.SetDataSource(dt)
			Try
				Dim textObject As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("invno"), TextObject)
				textObject.Text = Me.txtOrderNo.Text
			Catch ex As Exception
			End Try
			Try
				Dim textObject2 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("no2"), TextObject)
				textObject2.Text = Me.txtNo.Text
				Try
					Dim textObject3 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("new"), TextObject)
					textObject2.Text = "TA-" + Convert.ToInt32(Me.txtNo.Text).ToString("D6")
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
			Try
				Dim textObject4 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("date"), TextObject)
				flag = (Me._KitPrinterType = 2)
				If flag Then
					textObject4.Text = Me.txtDate.Value.ToString("dd/MM/yyyy  HH:mm")
				Else
					textObject4.Text = Me.txtDate.Value.ToString("dd/MM/yyyy")
				End If
			Catch ex4 As Exception
			End Try
			Try
				Me.txtInvTime.Value = Me.txtDate.Value
				Dim textObject5 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("txttime"), TextObject)
				textObject5.Text = Me.txtInvTime.Text
			Catch ex5 As Exception
			End Try
			Try
				Dim textObject6 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("group_name"), TextObject)
				textObject6.Text = _groupname
			Catch ex6 As Exception
			End Try
			Try
				Dim text As String = "محلي أفراد"
				flag = Me.rdOut.Checked
				If flag Then
					text = "طلب خارجي"
				Else
					flag = Me.rdIn2.Checked
					If flag Then
						text = "محلي عوائل"
					Else
						flag = Me.rdApp.Checked
						If flag Then
							text = "تطبيق"
						End If
					End If
				End If
				Try
					Dim textObject7 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
					textObject7.Text = text
				Catch ex7 As Exception
				End Try
				Try
					Dim textObject8 As TextObject = CType(reportDocument.Subreports("rptHeader").ReportDefinition.Sections(1).ReportObjects("type"), TextObject)
					textObject8.Text = "* " + text + " *"
				Catch ex8 As Exception
				End Try
			Catch ex9 As Exception
			End Try
			Try
				Dim textObject9 As TextObject = CType(reportDocument.ReportDefinition.Sections(1).ReportObjects("user"), TextObject)
				flag = (Me._KitPrinterType = 2)
				If flag Then
					textObject9.Text = Me.GetEmpName(MainClass.EmpNo)
				Else
					textObject9.Text = Me.GetSalesEmpNameByInvNo()
				End If
			Catch ex10 As Exception
			End Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Try
				reportDocument.Subreports("rptHeader").SetDataSource(dataTable)
			Catch ex11 As Exception
			End Try
			Try
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Dim textObject10 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtAddress"), TextObject)
					textObject10.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Address")))
					Dim textObject11 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtTel"), TextObject)
					textObject11.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Tel")))
					Dim textObject12 As TextObject = CType(reportDocument.ReportDefinition.Sections(4).ReportObjects("txtFax"), TextObject)
					textObject12.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("Fax")))
				End If
			Catch ex12 As Exception
			End Try
			Try
				flag = (Me._KitPrinterType <> 2)
				If flag Then
					reportDocument.ReportDefinition.Sections(0).SectionFormat.EnableSuppress = True
					reportDocument.ReportDefinition.Sections(4).SectionFormat.EnableSuppress = True
				End If
			Catch ex13 As Exception
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
			Catch ex14 As Exception
			End Try
		Catch ex15 As Exception
		End Try
	End Sub

	Private Sub PrintToGroups(dtt As DataTable)
		' The following expression was wrapped in a checked-statement
		Try
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Currency1")
			dataTable.Columns.Add("Value1")
			dataTable.Columns.Add("Process")
			dataTable.Columns.Add("Value2")
			Dim num As Integer = -1
			Dim text As String = ""
			Dim groupname As String = ""
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
						Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select groups.id,groups.printer,groups.name from groups,currencies where groups.id=currencies.group_id and currencies.id=", dtt.Rows(num4)(9))), Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter.Fill(dataTable2)
						num = Conversions.ToInteger(dataTable2.Rows(0)(0))
						text = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(1)))
						groupname = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(2)))
						flag3 = (Operators.CompareString(text, "", False) <> 0)
						If flag3 Then
							Dim text2 As String = dtt.Rows(num4)(2).ToString()
							dataTable.Rows.Add(New Object() {text2, RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(4)), RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(1)), Conversion.Val(RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(8))).ToString("N2")})
							dtt.Rows(num4)(10) = 1
							flag = True
						End If
					Else
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select groups.id,groups.printer from groups,currencies where groups.id=currencies.group_id and currencies.id=", dtt.Rows(num4)(9))), Me.conn1)
						Dim dataTable3 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable3)
						flag3 = Operators.ConditionalCompareObjectEqual(dataTable3.Rows(0)(0), num, False)
						If flag3 Then
							Dim text3 As String = dtt.Rows(num4)(2).ToString()
							dataTable.Rows.Add(New Object() {text3, RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(4)), RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(1)), Conversion.Val(RuntimeHelpers.GetObjectValue(dtt.Rows(num4)(8))).ToString("N2")})
							dtt.Rows(num4)(10) = 1
							flag = True
						End If
					End If
				End If
				num4 += 1
			End While
			flag3 = flag
			If flag3 Then
				Me.Printsub(dataTable, text, groupname)
				Me.PrintToGroups(dtt)
			End If
		Catch ex As Exception
		End Try
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
				Me.LoadOrderNo()
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
			Dim num6 As Decimal = 1D
			Dim value As Decimal = Me.NumericUpDown1.Value
			Dim num7 As Decimal = num6
			While ObjectFlowControl.ForLoopControl.ForNextCheckDec(num7, value, 1D)
				Dim obj As Object = New rptInvEnRest()
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
				Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"taxperc"}, Nothing, Nothing, Nothing), TextObject)
				textObject4.Text = Me.txtTax.Text + " %"
				Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
				textObject5.Text = Me.lblTaxVal.Text
				Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tot"}, Nothing, Nothing, Nothing), TextObject)
				textObject6.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
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
				Else
					Try
						crystalReportViewer.ShowLastPage()
						Dim num8 As Integer = crystalReportViewer.GetCurrentPageNumber()
						crystalReportViewer.ShowFirstPage()
						Dim instance3 As Object = obj
						Dim type4 As Type = Nothing
						Dim memberName3 As String = "PrintToPrinter"
						array = New Object() {1, False, 1, num8}
						Dim arguments3 As Object() = array
						Dim argumentNames3 As String() = Nothing
						Dim typeArguments3 As Type() = Nothing
						array2 = New Boolean() {False, False, False, True}
						NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
						If array2(3) Then
							num8 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
						End If
					Catch ex As Exception
					End Try
				End If
				num7 = Decimal.Add(num7, 1D)
			End While
			flag = (type = 2)
			If flag Then
				Me.Print_Sub()
				Me.btnSave_Click(Nothing, Nothing)
			End If
		End If
	End Sub

	Private Sub PrintRptA4(type As Integer)
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
				Me.LoadOrderNo()
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
			Dim obj As Object = RuntimeHelpers.GetObjectValue(New Object())
			flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
			If flag Then
				obj = New rptInvA4Rest()
			Else
				obj = New rptInvA4Rest___EN()
			End If
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
				textObject.Text = "فاتورة عرض سعر"
			End If
			Dim textObject2 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtNo"}, Nothing, Nothing, Nothing), TextObject)
			textObject2.Text = Me.txtNo.Text
			Dim textObject3 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtDate"}, Nothing, Nothing, Nothing), TextObject)
			textObject3.Text = Me.txtDate.Value.ToShortDateString()
			Me.txtInvTime.Value = Me.txtDate.Value
			Dim textObject4 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtTime"}, Nothing, Nothing, Nothing), TextObject)
			textObject4.Text = Me.txtInvTime.Text
			Dim textObject5 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtcust"}, Nothing, Nothing, Nothing), TextObject)
			textObject5.Text = Me.cmbClient.Text
			Dim textObject6 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtact"}, Nothing, Nothing, Nothing), TextObject)
			textObject6.Text = Me.GetCustAct(Conversions.ToInteger(Me.cmbClient.SelectedValue))
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject7 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"lbltaxno"}, Nothing, Nothing, Nothing), TextObject)
				flag = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
				If flag Then
					textObject7.Text = "الرقم الضريبي"
				Else
					textObject7.Text = "Tax No."
				End If
				Try
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select tax_no from customers where id=", Me.cmbClient.SelectedValue)), Me.conn)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable2)
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)))
					Dim textObject8 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
					textObject8.Text = text
				Catch ex As Exception
				End Try
			End If
			flag = (Me.InvProc = 1)
			If flag Then
				Dim textObject9 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject9.Text = Me.txtTotPurch.Text
			Else
				Dim textObject10 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtSum"}, Nothing, Nothing, Nothing), TextObject)
				textObject10.Text = Me.txtTotSale.Text
			End If
			Dim textObject11 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"net"}, Nothing, Nothing, Nothing), TextObject)
			textObject11.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtDiff.Text), 2))
			flag = (Conversion.Val(Me.lblTab3Val.Text) <> 0.0)
			If flag Then
				Dim textObject12 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttab3"}, Nothing, Nothing, Nothing), TextObject)
				textObject12.Text = "رسوم التبغ   " + Me.txtTab3Perc.Text + " %     قيمة رسوم التبغ      " + Me.lblTab3Val.Text
			End If
			Dim textObject13 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {4}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax"}, Nothing, Nothing, Nothing), TextObject)
			textObject13.Text = Me.lblTaxVal.Text
			Dim textObject14 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {2}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtuser"}, Nothing, Nothing, Nothing), TextObject)
			textObject14.Text = Me.GetSalesEmpNameByInvNo()
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select * from Foundation", Me.conn)
			Dim dataTable3 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable3)
			Dim instance2 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
			Dim type3 As Type = Nothing
			Dim memberName2 As String = "SetDataSource"
			Dim array3 As Object() = New Object() {dataTable3}
			Dim arguments2 As Object() = array3
			Dim argumentNames2 As String() = Nothing
			Dim typeArguments2 As Type() = Nothing
			array2 = New Boolean() {True}
			NewLateBinding.LateCall(instance2, type3, memberName2, arguments2, argumentNames2, typeArguments2, array2, True)
			If array2(0) Then
				dataTable3 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(DataTable)), DataTable)
			End If
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
					Dim instance3 As Object = NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing)
					Dim type4 As Type = Nothing
					Dim memberName3 As String = "SetDataSource"
					Dim array4 As Object() = New Object() {dataTable4}
					Dim arguments3 As Object() = array4
					Dim argumentNames3 As String() = Nothing
					Dim typeArguments3 As Type() = Nothing
					array2 = New Boolean() {True}
					NewLateBinding.LateCall(instance3, type4, memberName3, arguments3, argumentNames3, typeArguments3, array2, True)
					If array2(0) Then
						dataTable4 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(DataTable)), DataTable)
					End If
				End If
			Catch ex2 As Exception
			End Try
			Dim textObject15 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Subreports", New Object() {"rptHeader"}, Nothing, Nothing, Nothing), Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {1}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"tax_no"}, Nothing, Nothing, Nothing), TextObject)
			textObject15.Text = Me.taxno
			flag = (dataTable3.Rows.Count > 0)
			If flag Then
				Dim textObject16 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtAddress"}, Nothing, Nothing, Nothing), TextObject)
				textObject16.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Address")))
				Dim textObject17 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txttel"}, Nothing, Nothing, Nothing), TextObject)
				textObject17.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("tel")))
				Dim textObject18 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtMobile"}, Nothing, Nothing, Nothing), TextObject)
				textObject18.Text = Conversions.ToString(Operators.ConcatenateObject("", dataTable3.Rows(0)("Mobile")))
				Dim textObject19 As TextObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {5}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"txtFax"}, Nothing, Nothing, Nothing), TextObject)
				textObject19.Text = Me.TextBox1.Text
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
						Dim subreportObject As SubreportObject = CType(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ReportObjects", New Object() {"Subreport1"}, Nothing, Nothing, Nothing), SubreportObject)
						subreportObject.ObjectFormat.EnableSuppress = True
					End If
					flag = (Operators.CompareString(left2, "0", False) = 0)
					If flag Then
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "ReportDefinition", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Sections", New Object() {6}, Nothing, Nothing, Nothing), Nothing, "SectionFormat", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EnableSuppress", New Object() {True}, Nothing, Nothing, False, True)
					End If
				End If
			Catch ex3 As Exception
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
					Dim num6 As Integer = crystalReportViewer.GetCurrentPageNumber()
					crystalReportViewer.ShowFirstPage()
					Dim instance4 As Object = obj
					Dim type5 As Type = Nothing
					Dim memberName4 As String = "PrintToPrinter"
					array = New Object() {1, False, 1, num6}
					Dim arguments4 As Object() = array
					Dim argumentNames4 As String() = Nothing
					Dim typeArguments4 As Type() = Nothing
					array2 = New Boolean() {False, False, False, True}
					NewLateBinding.LateCall(instance4, type5, memberName4, arguments4, argumentNames4, typeArguments4, array2, True)
					If array2(3) Then
						num6 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(3)), GetType(Integer)))
					End If
				Catch ex4 As Exception
				End Try
			End If
		End If
	End Sub

	Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
		Me._IsCLR = False
		Me.btnSave_Click(Nothing, Nothing)
		Me._IsCLR = True
		Me._frmSalePurch.Navigate("select * from inv where proc_id=" + Conversions.ToString(Me.ProcCode))
		Me._frmSalePurch.PrintRptA4(1, 1, True)
		Me.CLR()
	End Sub

	Private Sub cmbClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbClient.SelectedIndexChanged
		Try
			Me.ShowCustBalance()
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintCashier.Click
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
				Dim text2 As String = ""
				flag = (MainClass.BranchNo <> -1)
				If flag Then
					text2 = String.Concat(New String() {"Restrictions.branch=", Conversions.ToString(MainClass.BranchNo), " and Restrictions_Sub.branch=", Conversions.ToString(MainClass.BranchNo), " and "})
				End If
				sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Restrictions.id,Restrictions.date,sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit,Restrictions.notes from Restrictions,Restrictions_Sub where ", text2, " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id ", text, " group by Restrictions.id,Restrictions.date,Restrictions.notes,Restrictions_Sub.acc_no"}), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim num3 As Integer = 0
				Dim num4 As Integer = dataTable.Rows.Count - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					num += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("dept")))
					num2 += Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(num5)("credit")))
					num5 += 1
				End While
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

	Private Sub cmbStock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbStock.SelectedIndexChanged
		Me.CalcBalance()
	End Sub

	Private Sub txtSrchNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSrchNo.KeyDown
	End Sub

	Private Sub txtSrchNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSrchNo.KeyPress
		MainClass.ISInteger(e)
	End Sub

	Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
		Dim frmCurrenciesBalances As New frmCurrenciesBalances()
		' The following expression was wrapped in a checked-statement
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

	Private Sub frmSalePurch_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) ' Handles frmSalePurch.FormClosing
		Try
			Dim flag As Boolean = Not Me.ISTRialEnd
			If flag Then
				Dim flag2 As Boolean = Me.cmbProcType.SelectedIndex = 0
				If flag2 Then
					Dim flag3 As Boolean = (Me.ProcCode = -1 And Me.dgvItems.Rows.Count > 0) Or (Me.ProcCode <> -1 And Me.DGV_Count <> Me.dgvItems.Rows.Count)
					If flag3 Then
						flag3 = (Operators.CompareString(MainClass.Language, "ar", False) = 0)
						Dim text As String
						If flag3 Then
							text = "انت لم تحفظ الفاتورة"
						Else
							text = "you not save the invoice"
						End If
						MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						e.Cancel = True
						Return
					End If
				End If
			End If
			Dim frmCurrenciesBalances As New frmCurrenciesBalances()
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

	Private Sub ShowCustBalance()
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select Code from Accounts_Index where AName='", Me.cmbClient.Text, "' and (acc_branch=", Conversions.ToString(MainClass.BranchNo), " or acc_branch is null )"}), Me.conn)
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
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select sum(Restrictions_Sub.dept) as dept ,sum(Restrictions_Sub.credit) as credit from Restrictions,Restrictions_Sub where " + str + " Restrictions.IS_Deleted=0 and Restrictions.state=1 and Restrictions.id=Restrictions_Sub.res_id " + text, Me.conn1)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable2)
			num += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("dept")))
			num2 += Conversion.Val(Operators.ConcatenateObject("", dataTable2.Rows(0)("credit")))
			flag = (num > num2)
			If flag Then
				Me.txtBalance.Text = String.Format("{0:0.#,##.##}", Math.Round(num - num2, 3))
			Else
				flag = (num2 > num)
				If flag Then
					Me.txtBalance.Text = String.Format("{0:0.#,##.##}", Math.Round(num2 - num, 3)) + "  دائن"
				Else
					flag = (num = num2)
					If flag Then
						Me.txtBalance.Text = "0"
					End If
				End If
			End If
		Catch ex As Exception
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
		Me.LoadClients()
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
			Dim flag As Boolean = Operators.CompareString(Me.txtBarcode.Text.Trim(), "", False) <> 0
			If flag Then
				Me._EnteredBarcode = Me.txtBarcode.Text.Trim()
				flag = Not Me._BarcodeProcess
				If flag Then
					Me._ismezan = False
					Me.timer1.Enabled = True
				Else
					flag = Me._ismezan
					If Not flag Then
						Me._ismezan = False
						Dim text As String = ""
						Dim flag2 As Boolean
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
								flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
								If flag2 Then
									Me._ismezan = True
									Me.txtBarcode.Text = text2
								End If
							End If
						Catch ex As Exception
						End Try
						Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select id,group_id,unit from currencies where IS_Deleted=0 and barcode='" + Me.txtBarcode.Text + "'", Me.conn1)
						Dim dataTable2 As DataTable = New DataTable()
						sqlDataAdapter2.Fill(dataTable2)
						flag2 = (dataTable2.Rows.Count > 0)
						If flag2 Then
							Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(1))
							Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))
							Try
								flag2 = (dataTable2.Rows(0)(2) IsNot DBNull.Value)
								If flag2 Then
									Me.cmbUnits.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(2))
								Else
									flag2 = (Me.cmbUnits.Items.Count > 0)
									If flag2 Then
										Me.cmbUnits.SelectedIndex = 0
									End If
								End If
							Catch ex2 As Exception
							End Try
							flag2 = Not Me._IsUpdateDG
							If flag2 Then
								flag = Me._ismezan
								If flag Then
									Me.txtVal1.Text = text
								Else
									Me.txtVal1.Text = "1"
								End If
							End If
						End If
					End If
				End If
			End If
		Catch ex3 As Exception
		Finally
			Me._BarcodeProcess = False
		End Try
	End Sub

	Private Sub cmbGroups_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGroups.SelectedIndexChanged
		Try
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMinusPerc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusPerc.TextChanged
		Dim flag As Boolean = Me.dochange
		If flag Then
			Try
				Me.dochange = False
				Me.txtMinusVal.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtMinusPerc.Text) / 100.0 * Conversion.Val(Me.txtTotSale.Text), 2))
				Me.txtTab3Perc_TextChanged(Nothing, Nothing)
			Catch ex As Exception
			End Try
			Me.dochange = True
		End If
	End Sub

	Private Sub dgvSrch_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSrch.CellContentClick
	End Sub

	Private Sub cmbSafe_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSafe.SelectedIndexChanged
	End Sub

	Private Sub cmd135_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd135.Click
		Dim flag As Boolean = Not Me._entered
		If flag Then
			Me._entered = True
			Me._focusedtxt.Text = Me.cmd135.Text
		Else
			Dim focusedtxt As TextBox = Me._focusedtxt
			focusedtxt.Text += Me.cmd135.Text
		End If
	End Sub

	Private Sub cmd2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd2.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd2.Text
	End Sub

	Private Sub cmd3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd3.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd3.Text
	End Sub

	Private Sub cmd4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd4.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd4.Text
	End Sub

	Private Sub cmd5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd5.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd5.Text
	End Sub

	Private Sub cmd6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd6.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd6.Text
	End Sub

	Private Sub cmd7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd7.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd7.Text
	End Sub

	Private Sub cmd8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd8.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd8.Text
	End Sub

	Private Sub cmd9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd9.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd9.Text
	End Sub

	Private Sub cmd0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd0.Click
		Dim focusedtxt As TextBox = Me._focusedtxt
		focusedtxt.Text += Me.cmd0.Text
	End Sub

	Private Sub cmdClearAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClearAll.Click
		Me._focusedtxt.Text = String.Empty
		Me.valHolder1 = 0.0
		Me.valHolder2 = 0.0
		Me.calcFunc = String.Empty
		Me.hasDecimal = False
	End Sub

	Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
	End Sub

	Private Sub cmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbType.SelectedIndexChanged
		Dim flag As Boolean = Me.cmbType.SelectedIndex = 0 And Me.InvProc = 2
		If flag Then
			Me.Panel1.Visible = True
		Else
			Me.Panel1.Visible = False
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

	Private Sub rdNormal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdNormal.CheckedChanged
	End Sub

	Private Sub GroupBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox2.Enter
	End Sub

	Private Sub dgvItems_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick
	End Sub

	Private Sub lblSrcInvNo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblSrcInvNo.Click
	End Sub

	Private Sub txtVal2D_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVal2D.TextChanged
	End Sub

	Private Sub txtDiff_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDiff.TextChanged
	End Sub

	Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
	End Sub

	Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
	End Sub

	Private Sub GroupBox3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox3.Enter
	End Sub


	Private Sub txtBalance_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBalance.TextChanged
	End Sub

	Private Sub cmbUnits_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbUnits.SelectedIndexChanged
		Try
			Me.txtExchangeVal.Text = ""
			Me.txtExchangeValD.Text = ""
			Me.txtVal2.Text = ""
			Me.txtVal2D.Text = ""
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select purch_price,sale_price from Currencies  where unit=", Me.cmbUnits.SelectedValue), " and id= "), Me.cmbCurrency.SelectedValue)), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Me.InvProc = 1
				If flag2 Then
					Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch_price"))))
				Else
					Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale_price"))))
				End If
			Else
				sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select curr_units.purch,curr_units.sale from Currencies,curr_units  where Currencies.id=curr_units.curr and curr_units.unit=", Me.cmbUnits.SelectedValue), " and curr_units.curr= "), Me.cmbCurrency.SelectedValue)), Me.conn)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				Dim flag2 As Boolean = dataTable.Rows.Count > 0
				If flag2 Then
					flag = (Me.InvProc = 1)
					If flag Then
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("purch"))))
					Else
						Me.txtExchangeVal.Text = String.Format("{0:0.#,##.##}", Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("sale"))))
					End If
				End If
			End If
			Try
				Dim flag2 As Boolean = Me.InvProc = 2 And Me._lastclientsale
				If flag2 Then
					Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select top 1 inv_sub.exchange_price from inv,inv_sub where inv.proc_id=inv_sub.proc_id and  is_deleted=0 and cust_id=", Me.cmbClient.SelectedValue), " and inv.proc_type=1 and is_buy=0 and "), " inv_sub.currency_from="), Me.cmbCurrency.SelectedValue), " and inv_sub.unit="), Me.cmbUnits.SelectedValue), " order by inv.date desc")), Me.conn1)
					Dim dataTable2 As DataTable = New DataTable()
					sqlDataAdapter2.Fill(dataTable2)
					flag2 = (dataTable2.Rows.Count > 0)
					If flag2 Then
						Me._IsLastClientSaleDo = True
						Me.txtExchangeVal.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable2.Rows(0)(0))))
					End If
				End If
			Catch ex As Exception
			End Try
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub cmbAddSalesMen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAddSalesMen.Click
		Dim num As Integer = -1
		Dim flag As Boolean = Me.cmbSalesMen.SelectedValue IsNot Nothing
		If flag Then
			num = Conversions.ToInteger(Me.cmbSalesMen.SelectedValue)
		End If
		Dim frmSafes As frmSafes = New frmSafes()
		frmSafes.Activate()
		frmSafes.ShowDialog()
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

	Private Sub dgvitemData_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvitemData.CellClick
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select id from currencies where id=", Me.dgvitemData.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag)), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbCurrency.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
			Dim flag As Boolean = Me.cmbUnits.Items.Count = 1 And Conversion.Val(Me.txtExchangeVal.Text) <> 0.0
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Me.txtVal1.Text) = 0.0
				If flag2 Then
					Me.txtVal1.Text = Conversions.ToString(1)
				End If
				Me.Add2DG()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvitemData_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvitemData.DataError
	End Sub

	Private Sub dgvGroups_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvGroups.DataError
	End Sub

	Private Sub dgvGroups_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvGroups.CellClick
		' The following expression was wrapped in a checked-statement
		Try
			Me.dgvitemData.Rows.Clear()
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select id from groups where name='", Me.dgvGroups.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), "' or nameEN='"), Me.dgvGroups.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), "'")), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Me.cmbGroups.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
			Dim backColor As Color = Color.White
			Try
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select color from groups where name='", Me.dgvGroups.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), "' or nameEN='"), Me.dgvGroups.Rows(e.RowIndex).Cells(e.ColumnIndex).Value), "'")), Me.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				backColor = Color.FromArgb(Conversions.ToInteger(dataTable2.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Dim sqlDataAdapter3 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select id, symbol,nameEN,img from Currencies where group_id=", dataTable.Rows(0)(0)), " and IS_Deleted=0 order by id")), Me.conn)
			Me.dtItems = New DataTable()
			sqlDataAdapter3.Fill(Me.dtItems)
			Me.ItemsIndex = 0
			Dim num As Integer = 0
			Dim num2 As Integer = 12
			Dim flag As Boolean = num2 > Me.dtItems.Rows.Count
			If flag Then
				num2 = Me.dtItems.Rows.Count
			End If
			Dim num3 As Integer = num
			Dim num4 As Integer = num2 - 1
			Dim num5 As Integer = num3
			While True
				Dim num6 As Integer = num5
				Dim num7 As Integer = num4
				If num6 > num7 Then
					Exit While
				End If
				Me.dgvitemData.Rows.Add()
				flag = (num5 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Style.BackColor = backColor
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
				End If
				flag = (num5 + 1 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Style.BackColor = backColor
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
				End If
				flag = (num5 + 2 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Style.BackColor = backColor
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
				End If
				flag = (num5 + 3 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Style.BackColor = backColor
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
				End If
				num5 += 3
				num5 += 1
			End While
		Catch ex2 As Exception
		End Try
		Me._paintend = False
	End Sub

	Private Sub dgvitemData_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvitemData.CellContentClick
	End Sub

	Private Sub dgvitemData_CurrentCellChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles dgvitemData.CurrentCellChanged
		Try
			Me.txtVal1.Text = "1"
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
		Me.PrintRptA4(1)
	End Sub

	Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
		Me.PrintRpt(2)
	End Sub

	Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
		' The following expression was wrapped in a checked-statement
		Try
			Me.dgvitemData.Rows.Clear()
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
			Me.ItemsIndex = 0
			Dim num As Integer = 0
			Dim num2 As Integer = 12
			Dim flag As Boolean = num2 > Me.dtItems.Rows.Count
			If flag Then
				num2 = Me.dtItems.Rows.Count
			End If
			Dim num3 As Integer = num
			Dim num4 As Integer = num2 - 1
			Dim num5 As Integer = num3
			While True
				Dim num6 As Integer = num5
				Dim num7 As Integer = num4
				If num6 > num7 Then
					Exit While
				End If
				Me.dgvitemData.Rows.Add()
				flag = (num5 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
					Try
						Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
						dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5)("color")))
					Catch ex As Exception
					End Try
				End If
				flag = (num5 + 1 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
					Try
						Dim dataGridViewButtonCell2 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1), DataGridViewButtonCell)
						dataGridViewButtonCell2.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 1)("color")))
					Catch ex2 As Exception
					End Try
				End If
				flag = (num5 + 2 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
					Try
						Dim dataGridViewButtonCell3 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2), DataGridViewButtonCell)
						dataGridViewButtonCell3.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 2)("color")))
					Catch ex3 As Exception
					End Try
				End If
				flag = (num5 + 3 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
					Try
						Dim dataGridViewButtonCell4 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3), DataGridViewButtonCell)
						dataGridViewButtonCell4.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 3)("color")))
					Catch ex4 As Exception
					End Try
				End If
				num5 += 3
				num5 += 1
			End While
		Catch ex5 As Exception
		End Try
	End Sub

	Private Sub Button9_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = Me.ItemsIndex - 1 >= 0
			If flag Then
				Me.ItemsIndex -= 1
				Me.dgvitemData.Rows.Clear()
				Me.dgvitemData.CreateGraphics().Clear(Color.White)
				Dim num As Integer = 12 * Me.ItemsIndex
				Dim num2 As Integer = num + 12
				flag = (num2 > Me.dtItems.Rows.Count)
				If flag Then
					num2 = Me.dtItems.Rows.Count
				End If
				Dim num3 As Integer = num
				Dim num4 As Integer = num2 - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Me.dgvitemData.Rows.Add()
					flag = (num5 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
						Try
							Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
							dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5)("color")))
						Catch ex As Exception
						End Try
					End If
					flag = (num5 + 1 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
						Try
							Dim dataGridViewButtonCell2 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1), DataGridViewButtonCell)
							dataGridViewButtonCell2.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 1)("color")))
						Catch ex2 As Exception
						End Try
					End If
					flag = (num5 + 2 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
						Try
							Dim dataGridViewButtonCell3 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2), DataGridViewButtonCell)
							dataGridViewButtonCell3.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 2)("color")))
						Catch ex3 As Exception
						End Try
					End If
					flag = (num5 + 3 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
						Try
							Dim dataGridViewButtonCell4 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3), DataGridViewButtonCell)
							dataGridViewButtonCell4.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 3)("color")))
						Catch ex4 As Exception
						End Try
					End If
					num5 += 3
					num5 += 1
				End While
			End If
		Catch ex5 As Exception
		End Try
	End Sub

	Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = (Me.ItemsIndex + 1) * 12 <= Me.dtItems.Rows.Count
			If flag Then
				Me.ItemsIndex += 1
				Me.dgvitemData.Rows.Clear()
				Me.dgvitemData.CreateGraphics().Clear(Color.White)
				Dim num As Integer = 12 * Me.ItemsIndex
				Dim num2 As Integer = num + 12
				flag = (num2 > Me.dtItems.Rows.Count)
				If flag Then
					num2 = Me.dtItems.Rows.Count
				End If
				Dim num3 As Integer = num
				Dim num4 As Integer = num2 - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Me.dgvitemData.Rows.Add()
					flag = (num5 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
						Try
							Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
							dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5)("color")))
						Catch ex As Exception
						End Try
					End If
					flag = (num5 + 1 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
						Try
							Dim dataGridViewButtonCell2 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1), DataGridViewButtonCell)
							dataGridViewButtonCell2.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 1)("color")))
						Catch ex2 As Exception
						End Try
					End If
					flag = (num5 + 2 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
						Try
							Dim dataGridViewButtonCell3 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2), DataGridViewButtonCell)
							dataGridViewButtonCell3.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 2)("color")))
						Catch ex3 As Exception
						End Try
					End If
					flag = (num5 + 3 < Me.dtItems.Rows.Count)
					If flag Then
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
						Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
						Try
							Dim dataGridViewButtonCell4 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3), DataGridViewButtonCell)
							dataGridViewButtonCell4.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 3)("color")))
						Catch ex4 As Exception
						End Try
					End If
					num5 += 3
					num5 += 1
				End While
			End If
		Catch ex5 As Exception
		End Try
	End Sub

	Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button11.Click
		' The following expression was wrapped in a checked-statement
		Try
			Me.dgvitemData.Rows.Clear()
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
			Me.ItemsIndex = CInt(Math.Round(Math.Ceiling(CDbl(Me.dtItems.Rows.Count) / 12.0) - 1.0))
			Dim num As Integer = Me.ItemsIndex * 12
			Dim num2 As Integer = num + 12
			Dim flag As Boolean = num2 > Me.dtItems.Rows.Count
			If flag Then
				num2 = Me.dtItems.Rows.Count
			End If
			Dim num3 As Integer = num
			Dim num4 As Integer = num2 - 1
			Dim num5 As Integer = num3
			While True
				Dim num6 As Integer = num5
				Dim num7 As Integer = num4
				If num6 > num7 Then
					Exit While
				End If
				Me.dgvitemData.Rows.Add()
				flag = (num5 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5)("id"))
					Try
						Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
						dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5)("color")))
					Catch ex As Exception
					End Try
				End If
				flag = (num5 + 1 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 1)("id"))
					Try
						Dim dataGridViewButtonCell2 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(1), DataGridViewButtonCell)
						dataGridViewButtonCell2.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 1)("color")))
					Catch ex2 As Exception
					End Try
				End If
				flag = (num5 + 2 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 2)("id"))
					Try
						Dim dataGridViewButtonCell3 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(2), DataGridViewButtonCell)
						dataGridViewButtonCell3.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 2)("color")))
					Catch ex3 As Exception
					End Try
				End If
				flag = (num5 + 3 < Me.dtItems.Rows.Count)
				If flag Then
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Value = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)(Me._fieldname))
					Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3).Tag = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(num5 + 3)("id"))
					Try
						Dim dataGridViewButtonCell4 As DataGridViewButtonCell = CType(Me.dgvitemData.Rows(Me.dgvitemData.Rows.Count - 1).Cells(3), DataGridViewButtonCell)
						dataGridViewButtonCell4.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtcolor.Rows(num5 + 3)("color")))
					Catch ex4 As Exception
					End Try
				End If
				num5 += 3
				num5 += 1
			End While
		Catch ex5 As Exception
		End Try
	End Sub

	Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button13.Click
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = (Me.GroupsIndex + 1) * 6 <= Me.dtGroups.Rows.Count
			If flag Then
				Me.GroupsIndex += 1
				Me.dgvGroups.Rows.Clear()
				Dim num As Integer = 6 * Me.GroupsIndex
				Dim num2 As Integer = num + 6
				flag = (num2 > Me.dtGroups.Rows.Count)
				If flag Then
					num2 = Me.dtGroups.Rows.Count
				End If
				Dim num3 As Integer = num
				Dim num4 As Integer = num2 - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Me.dgvGroups.Rows.Add()
					Me.dgvGroups.Rows(Me.dgvGroups.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtGroups.Rows(num5)(Me._gfieldname))
					Try
						Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvGroups.Rows(Me.dgvGroups.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
						dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtGroups.Rows(num5)("color")))
					Catch ex As Exception
					End Try
					num5 += 1
				End While
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button12.Click
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = Me.GroupsIndex - 1 >= 0
			If flag Then
				Me.GroupsIndex -= 1
				Me.dgvGroups.Rows.Clear()
				Dim num As Integer = 6 * Me.GroupsIndex
				Dim num2 As Integer = num + 6
				flag = (num2 > Me.dtGroups.Rows.Count)
				If flag Then
					num2 = Me.dtGroups.Rows.Count
				End If
				Dim num3 As Integer = num
				Dim num4 As Integer = num2 - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit While
					End If
					Me.dgvGroups.Rows.Add()
					Me.dgvGroups.Rows(Me.dgvGroups.Rows.Count - 1).Cells(0).Value = RuntimeHelpers.GetObjectValue(Me.dtGroups.Rows(num5)(Me._gfieldname))
					Try
						Dim dataGridViewButtonCell As DataGridViewButtonCell = CType(Me.dgvGroups.Rows(Me.dgvGroups.Rows.Count - 1).Cells(0), DataGridViewButtonCell)
						dataGridViewButtonCell.Style.BackColor = Color.FromArgb(Conversions.ToInteger(Me.dtGroups.Rows(num5)("color")))
					Catch ex As Exception
					End Try
					num5 += 1
				End While
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Private Sub txtTax_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTax.TextChanged
		Try
			Dim value As Double = Math.Round(Conversion.Val(Me.txtTax.Text) / 100.0 * (Conversion.Val(Me.txtTotSale.Text) - Conversion.Val(Me.txtMinusVal.Text) + Conversion.Val(Me.lblTab3Val.Text)), 3)
			Me.lblTaxVal.Text = "" + Conversions.ToString(value)
			Me.txtDiff.Text = Conversions.ToString(Math.Round(Convert.ToDouble(Me.txtTotSale.Text) + Conversion.Val(Me.lblTab3Val.Text) + Conversion.Val(Me.lblTaxVal.Text) - Conversion.Val(Me.txtMinusVal.Text), 2))
			Dim flag As Boolean = Me.cmbType.SelectedIndex = 1 And Me.ProcCode = -1
			If flag Then
				Me.txtCash.Text = Me.txtDiff.Text
				Me.txtNetwork.Text = ""
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtrec_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtrec.TextChanged
		Try
			Me.txtrecrem.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtrec.Text) - Conversion.Val(Me.txtCash.Text), 2))
		Catch ex As Exception
		End Try
	End Sub

	Private Sub lblTaxVal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTaxVal.Click
	End Sub

	Private Sub txtMinusVal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusVal.Enter
		Try
			Me._focusedtxt = Me.txtMinusVal
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtCash_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.Enter
		Try
			Me._focusedtxt = Me.txtCash
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtNetwork_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtNetwork.Enter
		Try
			Me._focusedtxt = Me.txtNetwork
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtTab3Perc_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtTab3Perc.Enter
		Try
			Me._focusedtxt = Me.txtTab3Perc
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtrec_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtrec.Enter
		Try
			Me._focusedtxt = Me.txtrec
		Catch ex As Exception
		End Try
	End Sub

	Private Sub GroupBox4_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox4.Enter
	End Sub

	Private Sub Button14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
		Me.PrintRptEn(2)
	End Sub

	Public Sub New()
		AddHandler MyBase.Load, AddressOf Me.frmSalePurch_Load
		AddHandler MyBase.Resize, AddressOf Me.frmSalePurchRest_Resize
		AddHandler MyBase.FormClosing, AddressOf Me.frmSalePurch_FormClosing
		AddHandler MyBase.KeyDown, AddressOf Me.frmSalePurch_KeyDown
		frmSalePurchRest.__ENCAddToList(Me)
		Me.conn = MainClass.ConnObj()
		Me.conn1 = MainClass.ConnObj()
		Me.Code = -1
		Me.ProcCode = -1
		Me.RestPurchCode = -1
		Me.RestSaleCode = -1
		Me.InvProc = 1
		Me.DGV_Count = 0
		Me.ISTRialEnd = False
		Me.sp = New SerialPort("COM3", 9600, Parity.None, 8, StopBits.One)
		Me.taxno = ""
		Me.dtItems = New DataTable()
		Me.dtGroups = New DataTable()
		Me.dtcolor = New DataTable()
		Me.ItemsIndex = 0
		Me.GroupsIndex = 0
		Me._fieldname = "symbol"
		Me._gfieldname = "name"
		Me._IsCalcTot = True
		Me._IsUpdateDG = False
		Me._DefaultBank = -1
		Me.Sales_title2 = ""
		Me._Exchangeal = 1250.0
		Me._foundname = ""
		Me._lastclientsale = False
		Me._IsItemsTab3 = False
		Me._IsItemsTab3MinFee = False
		Me._ItemsTab3MinFee = 0.0
		Me._ActvRestPrintNew = False
		Me._KitPrinterType = 1
		Me._ZatcInteg = False
		Me._PreventInvZatcFail = False
		Me._IsCLR = True
		Me._IsReAPI = False
		Me._Ispaid = False
		Me._IsLastClientSaleDo = False
		Me._focusedtxt = Me.txtVal1
		Me._lastitemprice = 0.0
		Me._frmSalePurch = New frmSalePurch()
		Me.dochange = True
		Me._entered = False
		Me._paintend = False
		Me.ClientID = -1
		Me._EnteredBarcode = ""
		Me._BarcodeProcess = False
		Me._ismezan = False
		Me.InitializeComponent()
	End Sub

	Private Sub dgvItems_CellMouseMove(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvItems.CellMouseMove
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select inv_sub.exchange_price from inv,inv_sub where inv.proc_id=inv_sub.proc_id and inv.is_deleted=0 and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv_sub.currency_from=", Me.dgvItems.Rows(e.RowIndex).Cells(9).Value), " order by inv.date desc")), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.ToolTip1.SetToolTip(Me.dgvItems, "آخر سعر شراء: " + dataTable.Rows(0)(0).ToString())
			Else
				sqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select purch_price from currencies where is_deleted=0 and id=", Me.dgvItems.Rows(e.RowIndex).Cells(9).Value)), Me.conn1)
				dataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (dataTable.Rows.Count > 0)
				If flag Then
					Me.ToolTip1.SetToolTip(Me.dgvItems, "آخر سعر شراء: " + dataTable.Rows(0)(0).ToString())
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvUnits_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUnits.CellClick
		' The following expression was wrapped in a checked-statement
		Try
			Dim num As Integer = 0
			Dim num2 As Integer = Me.cmbUnits.Items.Count - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					GoTo IL_95
				End If
				Dim flag As Boolean = Operators.CompareString(Me.cmbUnits.GetItemText(RuntimeHelpers.GetObjectValue(Me.cmbUnits.Items(num3))), Me.dgvUnits.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString(), False) = 0
				If flag Then
					Exit While
				End If
				num3 += 1
			End While
			Me.cmbUnits.SelectedIndex = num3
IL_95:
		Catch ex As Exception
		End Try
	End Sub

	Public Sub LoadTawla(_group As String)
		' The following expression was wrapped in a checked-statement
		Try
			Me.dgvTawlas.Rows.Clear()
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from tawla_groups where name='" + _group + "'", Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num As Integer = 0
			Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select * from tawla where tawla_group=", dataTable.Rows(0)(0))), Me.conn)
			Dim dataTable2 As DataTable = New DataTable()
			sqlDataAdapter2.Fill(dataTable2)
			Dim num2 As Integer = 0
			Dim num3 As Integer = dataTable2.Rows.Count - 1
			Dim num4 As Integer = num2
			While True
				Dim num5 As Integer = num4
				Dim num6 As Integer = num3
				If num5 > num6 Then
					Exit While
				End If
				Dim flag As Boolean = num4 Mod 3 = 0
				If flag Then
					Me.dgvTawlas.Rows.Add()
					num = 0
				End If
				Me.dgvTawlas.Rows(Me.dgvTawlas.Rows.Count - 1).Cells(num).Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows(num4)("name"))
				num += 1
				num4 += 1
			End While
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgvTawlaGroups_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvTawlaGroups.CellClick
		Me.LoadTawla(Conversions.ToString(Operators.ConcatenateObject("", Me.dgvTawlaGroups.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)))
	End Sub

	Private Sub rdIn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdIn.CheckedChanged
		Try
			Dim flag As Boolean = Me.rdIn.Checked Or Me.rdIn2.Checked
			If flag Then
				Me.pnlTawla.Visible = True
				Me.pnlGroups.Width = 220
				Me.pnlApp.Visible = False
				Me.chkIsPaid.Checked = False
			Else
				Me.pnlTawla.Visible = False
				Me.pnlGroups.Width = 180
				flag = Me.rdOut.Checked
				If flag Then
					Me.pnlApp.Visible = False
					Me.chkIsPaid.Checked = True
				End If
				flag = Me.rdApp.Checked
				If flag Then
					Dim flag2 As Boolean = Me.ProcCode = -1
					If flag2 Then
						Me.chkIsPaid.Checked = False
					End If
					Me.pnlApp.Visible = True
				End If
			End If
		Catch ex As Exception
		End Try
		Me.dgvitemData.CreateGraphics().Clear(Color.White)
		Me.dgvitemData.Refresh()
	End Sub

	Private Sub dgvitemData_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvitemData.CellPainting
		' The following expression was wrapped in a checked-statement
		Try
			Dim flag As Boolean = e.RowIndex <> -1
			If flag Then
				Dim flag2 As Boolean = (e.PaintParts And DataGridViewPaintParts.Background) <> DataGridViewPaintParts.None
				If flag2 Then
					Dim value As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dgvitemData.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag))
					Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select img,symbol from currencies where id=" + Conversions.ToString(value), Me.conn)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					flag2 = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("img")))
					If flag2 Then
						e.Graphics.DrawImage(MainClass.Arr2Image(CType(dataTable.Rows(0)(0), Byte())), e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height - 20)
					Else
						e.Graphics.DrawImage(Resources.nopic, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height - 20)
					End If
				End If
				flag2 = Not e.Handled
				If flag2 Then
					e.Handled = True
					e.PaintContent(e.CellBounds)
				End If
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub rdOut_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdOut.CheckedChanged
	End Sub

	Private Sub rdCash_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdCash.CheckedChanged
	End Sub

	Private Sub txtTab3Perc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTab3Perc.TextChanged
		Me.CalcTot()
	End Sub

	Private Sub txtCustNo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCustNo.TextChanged
		Try
			Dim value As Integer = 1
			Dim flag As Boolean = Me.InvProc = 1
			If flag Then
				value = 2
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select id from customers where cust_no=" + Conversions.ToString(Conversion.Val(Me.txtCustNo.Text)) + " and type=" + Conversions.ToString(value), Me.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Me.cmbClient.SelectedValue = RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Button15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button15.Click
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
			frmSrchClient.frm7 = Me
			frmSrchClient.ShowDialog()
			Me.cmbClient.SelectedValue = Me.ClientID
		Catch ex As Exception
		End Try
	End Sub

	Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
		Try
			Me.timer1.Enabled = False
			Dim flag As Boolean = Operators.CompareString(Me._EnteredBarcode, Me.txtBarcode.Text.Trim(), False) = 0
			If flag Then
				Me._BarcodeProcess = True
				Me.txtBarcode_TextChanged(Nothing, Nothing)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.TextChanged
		Try
			Dim flag As Boolean = Me.txtCash.Focused Or Me._focusedtxt Is Me.txtCash
			If flag Then
				Me.txtNetwork.Text = Conversions.ToString(Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.txtCash.Text))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtNetwork_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNetwork.TextChanged
		Try
			Dim flag As Boolean = Me.txtNetwork.Focused Or Me._focusedtxt Is Me.txtNetwork
			If flag Then
				Me.txtCash.Text = Conversions.ToString(Conversion.Val(Me.txtDiff.Text) - Conversion.Val(Me.txtNetwork.Text))
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMinusVal_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinusVal.TextChanged
		Try
			Dim flag As Boolean = Me.dochange
			If flag Then
				Me.dochange = False
				flag = (Conversion.Val(Me.txtTotSale.Text) <> 0.0)
				If flag Then
					Me.txtMinusPerc.Text = Conversions.ToString(Math.Round(Conversion.Val(Me.txtMinusVal.Text) / Conversion.Val(Me.txtTotSale.Text) * 100.0, 1))
				End If
				Me.dochange = True
				Me.txtTab3Perc_TextChanged(Nothing, Nothing)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub cmbApps_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbApps.SelectedIndexChanged
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Conversions.ToString(Operators.ConcatenateObject("select fees from mobapps where id=", Me.cmbApps.SelectedValue)), Me.conn1)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Me.txtAppFee.Text = "" + dataTable.Rows(0)(0).ToString()
			End If
		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtAppFee_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAppFee.TextChanged
		Me.CalcTot()
	End Sub

	Private Sub chkPaidOnline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPaidOnline.CheckedChanged
		Dim checked As Boolean = Me.chkPaidOnline.Checked
		If checked Then
			Me.chkIsPaid.Checked = True
		End If
	End Sub

	Private Sub frmSalePurchRest_Resize(ByVal sender As Object, ByVal e As EventArgs) 'Handles frmSalePurchRest.Resize
		Try
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
		Try
			Me.dgvitemData.CreateGraphics().Clear(Color.White)
		Catch ex As Exception
		End Try
	End Sub
End Class
