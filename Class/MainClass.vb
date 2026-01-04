Imports MessagingToolkit.QRCode.Codec
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports AQSYS.My
Public Class MainClass

	' السيرفر يتم أخذه من frmUserLogin.txtServer
	'Public Shared connserv As String = frmUserLogin.txtServer

	Public Shared conn As SqlConnection
	Public Shared AppVersion As String
	Public Shared connstr As String = "server=.\SQLExpress;database=StockDB;trusted_connection=true;TrustServerCertificate=True"
	Public Shared Window_State As FormWindowState = FormWindowState.Normal

	Public Shared IsTrial As Boolean = True

	Public Shared Server As String = ""

	Public Shared UserID As Integer = 1

	Public Shared UserName As String = ""

	Public Shared EmpNo As Integer = -1

	Public Shared BranchNo As Integer = -1

	Public Shared BranchName As String = ""

	Public Shared Language As String = "ar"

	Public Shared IsAccTreeNew As Boolean = False

	Public Shared hide_manfc As Boolean = True

	Public Shared hide_costcenter As Boolean = True

	Public Shared hide_retention As Boolean = True

	Public Shared hide_yearclose As Boolean = True

	Public Shared AppNameAR As String = "برنامج الأمهر المحاسبي"

	Public Shared AppNameEN As String = "ALAMHAR Almuhasbi Application"

	Public Shared CurrentVersion As Integer = 16

	Private Shared _name As String = "Tahoma"

	Private Shared _size As String = "8"

	Private Shared _fcolor As Integer = Color.Black.ToArgb()

	Private Shared _bcolor As Integer = Color.LightBlue.ToArgb()

	Private Shared _style As String = "عادي"

	Public Shared _enckey As String = "abshir"

	'Public Const SECURE_APP_NAME As String = "StockDB-Basem-SecureApp-2024"

	''' <summary>
	''' إصدار الحماية
	''' </summary>
	''' 

	Public Const SECURITY_VERSION As String = "1.0"

	Public Shared Property Database As String

	Public Shared Function GetSecureConnectionString(server As String, database As String) As String
		Return $"Server={server};Database={database};" &
			   $"User Id={AppConstants.SQL_USER};Password={AppConstants.SQL_PASS};" &
			   $"Application Name={AppConstants.APP_SIGNATURE};" &
			   "MultipleActiveResultSets=True;Connection Timeout=30;" &
			   "TrustServerCertificate=True;Encrypt=False;"
	End Function

	Public Shared Function ConnObj1() As SqlConnection
		MainClass.conn = New SqlConnection(MainClass.connstr)
		Return MainClass.conn
	End Function

	''' <summary>
	''' إنشاء كائن اتصال جديد
	''' </summary>
	Public Shared Function ConnObj() As SqlConnection
		Try
			' التحقق من سلسلة الاتصال
			If String.IsNullOrEmpty(connstr) OrElse
		   connstr.Contains("trusted_connection") OrElse
		   connstr.Contains("Integrated Security") Then

				' قراءة الإعدادات
				Dim s = SecureDatabaseManager.LoadSettings()
				If s IsNot Nothing Then
					Server = s.Server
					Database = s.Database
				End If

				' إنشاء سلسلة اتصال آمنة
				connstr = $"Server={Server};Database={Database};" &
					  $"User Id={AppConstants.SQL_USER};Password={AppConstants.SQL_PASS};" &
					  $"Application Name={AppConstants.APP_SIGNATURE};" &
					  "MultipleActiveResultSets=True;Connection Timeout=30;" &
					  "TrustServerCertificate=True;Encrypt=False;"
			End If

			conn = New SqlConnection(connstr)
			Return conn
		Catch ex As Exception
			Return Nothing
		End Try
	End Function
	Public Shared Function qrcodeGen2(_type As Integer, _no As String, _date As String, _cust As String, _custvatno As String, _comp As String, _vatno As String, _vatval As String, _net As String) As Image
		Try
			Dim qrcodeEncoder As QRCodeEncoder = New QRCodeEncoder()
			qrcodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
			qrcodeEncoder.QRCodeVersion = 0
			Dim content As String = ""
			Dim flag As Boolean = _type = 1
			If flag Then
				content = String.Concat(New String() {"Invoice Number: ", _no, Environment.NewLine, "Invoice Issue Date: ", _date, Environment.NewLine, "Company: ", _comp, Environment.NewLine, "VAT Number: ", _vatno, Environment.NewLine, "Total VAT: ", _vatval, Environment.NewLine, "Total Amount Due: ", _net})
			Else
				flag = (_type = 2)
				If flag Then
					content = String.Concat(New String() {"Invoice Number: ", _no, Environment.NewLine, "Invoice Issue Date: ", _date, Environment.NewLine, "Company: ", _comp, Environment.NewLine, "VAT Number: ", _vatno, Environment.NewLine, "Client: ", _cust, Environment.NewLine, "VAT No.: ", _custvatno, Environment.NewLine, "Total VAT: ", _vatval, Environment.NewLine, "Total Amount Due: ", _net})
				End If
			End If
			Return qrcodeEncoder.Encode(content, Encoding.UTF8)
		Catch ex As Exception
		End Try
		Return Nothing
	End Function

	Public Shared Function qrcodeGen(_type As Integer, _no As String, _date As String, _cust As String, _custvatno As String, _comp As String, _vatno As String, _vatval As String, _net As String) As Image
		Try
			Dim qrcodeEncoder As QRCodeEncoder = New QRCodeEncoder()
			qrcodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
			qrcodeEncoder.QRCodeVersion = 0
			Dim content As String = ""
			Dim flag As Boolean = True
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select is_qr_enc from foundation", MainClass.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0)))
			Catch ex As Exception
			End Try
			Dim flag2 As Boolean = flag
			If flag2 Then
				Dim generateQrCodeTLV As GenerateQrCodeTLV = New GenerateQrCodeTLV(_comp, _vatno, _date, _net, _vatval)
				content = generateQrCodeTLV.GetImageBase64()
			Else
				flag2 = (_type = 1)
				If flag2 Then
					content = String.Concat(New String() {"Invoice Number: ", _no, Environment.NewLine, "Invoice Issue Date: ", _date, Environment.NewLine, "Company: ", _comp, Environment.NewLine, "VAT Number: ", _vatno, Environment.NewLine, "Total VAT: ", _vatval, Environment.NewLine, "Total Amount Due: ", _net})
				Else
					flag2 = (_type = 2)
					If flag2 Then
						content = String.Concat(New String() {"Invoice Number: ", _no, Environment.NewLine, "Invoice Issue Date: ", _date, Environment.NewLine, "Company: ", _comp, Environment.NewLine, "VAT Number: ", _vatno, Environment.NewLine, "Client: ", _cust, Environment.NewLine, "VAT No.: ", _custvatno, Environment.NewLine, "Total VAT: ", _vatval, Environment.NewLine, "Total Amount Due: ", _net})
					End If
				End If
			End If
			Return qrcodeEncoder.Encode(content, Encoding.UTF8)
		Catch ex2 As Exception
		End Try
		Return Nothing
	End Function

	Public Shared Sub SendEmail(_email As String, _file As String, str As String)
		Try
			Dim mailMessage As MailMessage = New MailMessage()
			mailMessage.[To].Add(_email)
			mailMessage.From = New MailAddress("aabshir538@gmail.com", "برنامج أبشر", Encoding.UTF8)
			mailMessage.Subject = str
			mailMessage.SubjectEncoding = Encoding.UTF8
			mailMessage.Body = str + "<br />"
			mailMessage.BodyEncoding = Encoding.UTF8
			mailMessage.IsBodyHtml = True
			Dim attachment As Attachment = New Attachment(_file)
			mailMessage.Attachments.Add(attachment)
			mailMessage.Priority = MailPriority.High
			'New SmtpClient() With { .UseDefaultCredentials = False, .Credentials = New NetworkCredential("aabshir538@gmail.com", "asd123456*"), .Port = 587, .Host = "smtp.gmail.com", .EnableSsl = True }.Send(mailMessage)
			Using frm As New SmtpClient()
				frm.UseDefaultCredentials = False
				frm.Credentials = New NetworkCredential("aabshir538@gmail.com", "asd123456*")
				frm.Port = 587
				frm.Host = "smtp.gmail.com"
				frm.EnableSsl = True
				frm.Send(mailMessage)
			End Using
			attachment.Dispose()
		Catch ex As Exception
		End Try
	End Sub

	Public Shared Sub DoApplyUserSett(frm As Form)
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select * from UserSetting where ActiveSett=1 and user_id=" + Conversions.ToString(MainClass.UserID), MainClass.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				MainClass._name = dataTable.Rows(0)(1).ToString()
				MainClass._size = dataTable.Rows(0)(2).ToString()
				flag = (Operators.CompareString(dataTable.Rows(0)(3).ToString(), "عريض", False) = 0)
				If flag Then
					MainClass._style = "عريض"
				Else
					MainClass._style = "عادي"
				End If
				MainClass._fcolor = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(4)))
				MainClass._bcolor = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(5)))
				frm.BackColor = Color.FromArgb(MainClass._bcolor)
				MainClass.ApplySett(frm)
			End If
		Catch ex As Exception
		End Try
	End Sub

	Public Shared Function GetItemQuan(_item As Integer, _store As Integer) As Double
		Try
			Dim text As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Dim num4 As Double = 0.0
			Dim num5 As Double = 0.0
			Dim num6 As Double = 0.0
			Dim num7 As Double = 0.0
			Dim num8 As Double = 0.0
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and safe=", Conversions.ToString(_store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=3 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 "}), MainClass.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(difftot) from tsweya,tsweya_sub where safe=", Conversions.ToString(_store), " and item=", Conversions.ToString(_item), " and tsweya.id=tsweya_sub.tsweya_id and IS_Deleted=0"}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num8 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and safe=", Conversions.ToString(_store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 "}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num2 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val) from inv,inv_sub where ", text, " (is_hold=0 or is_hold is null) and safe=", Conversions.ToString(_store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 "}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num3 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val) from inv,inv_sub where ", text, " safe=", Conversions.ToString(_store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=1 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 "}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num4 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(val) from inv,inv_sub where ", text, " safe=", Conversions.ToString(_store), " and Inv_Sub.currency_from=", Conversions.ToString(_item), " and inv.proc_type=2 and inv_sub.proc_type=2 and inv.proc_id=inv_sub.proc_id and IS_Deleted=0 "}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num5 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(value) from SafesTransfer,SafesTransfer_Sub where ", text, " SafesTransfer.safe_to=", Conversions.ToString(_store), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0"}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num6 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			sqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select sum(value) from SafesTransfer,SafesTransfer_Sub where ", text, " SafesTransfer.safe_from=", Conversions.ToString(_store), " and currency=", Conversions.ToString(_item), " and SafesTransfer.id=SafesTransfer_Sub.transfer_id and IS_Deleted=0"}), MainClass.conn)
			dataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0 And Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0)
			If flag Then
				num7 = Convert.ToDouble(Operators.ConcatenateObject("", dataTable.Rows(0)(0)))
			End If
			Return num + num2 - num3 - num4 + num5 + num6 - num7 + num8
		Catch ex As Exception
		End Try
		Return 0.0
	End Function

	Public Shared Function chkItemExpire(_Item As Integer, _Balance As Double, _Safe As Integer, _date As DateTime) As Double
		Try
			Dim text As String = ""
			Dim flag As Boolean = MainClass.BranchNo <> -1
			If flag Then
				text = "branch=" + Conversions.ToString(MainClass.BranchNo) + " and "
			End If
			Dim num As Double = _Balance
			Dim flag2 As Boolean = True
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(String.Concat(New String() {"select val,date from inv,inv_sub where ", text, " safe=", Conversions.ToString(_Safe), " and currency_from=", Conversions.ToString(_Item), " and expire_date>=@date and (inv.proc_type=1 or inv.proc_type=3) and inv_sub.proc_type=1 and inv.proc_id=inv_sub.proc_id  and IS_Deleted=0 order by date desc"}), MainClass.conn)
			sqlDataAdapter.SelectCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = _date.ToShortDateString()
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim num2 As Integer = 0
			Dim num3 As Integer = dataTable.Rows.Count - 1
			Dim num4 As Integer = num2
			While True
				Dim num5 As Integer = num4
				Dim num6 As Integer = num3
				If num5 > num6 Then
					GoTo IL_14D
				End If
				flag = (CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("val")))) > num)
				If flag Then
					Exit While
				End If
				num -= CDbl(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows(num4)("val"))))
				num4 += 1
			End While
			flag2 = False
IL_14D:
			flag = flag2
			If flag Then
				Return num
			End If
		Catch ex As Exception
		End Try
		Return -1.0
	End Function

	Private Shared Sub ApplySett(Parent As Control)
		Try
			Try
				For Each obj As Object In Parent.Controls
					Dim control As Control = CType(obj, Control)
					Dim flag As Boolean = Operators.CompareString(MainClass._style, "عادي", False) = 0
					If flag Then
						control.Font = New Font(MainClass._name, Convert.ToSingle(MainClass._size), FontStyle.Regular)
					Else
						control.Font = New Font(MainClass._name, Convert.ToSingle(MainClass._size), FontStyle.Bold)
					End If
					control.ForeColor = Color.FromArgb(MainClass._fcolor)
					flag = (TypeOf control Is TabPage Or TypeOf control Is Panel Or TypeOf control Is GroupBox)
					If flag Then
						control.BackColor = Color.FromArgb(MainClass._bcolor)
					End If
					flag = (TypeOf control Is DataGridView)
					If flag Then
						Dim dataGridView As DataGridView = CType(control, DataGridView)
						dataGridView.BackgroundColor = Color.FromArgb(MainClass._bcolor)
					End If
					MainClass.ApplySett(control)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		Catch ex As Exception
		End Try
	End Sub

	Public Shared Sub EnableControls(Parent As Control, IsEnable As Boolean)
		Try
			Try
				For Each obj As Object In Parent.Controls
					Dim control As Control = CType(obj, Control)
					control.Enabled = IsEnable
					MainClass.EnableControls(control, IsEnable)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		Catch ex As Exception
		End Try
	End Sub

	Public Shared Sub ApplyPermissionToForm(frm As Form)
		Try
			Dim str As String = frm.Name
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(frm.Tag, "SalePurch2", False)
			If flag Then
				str = "frmSalePurch2"
			Else
				flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "SalePurch3", False)
				If flag Then
					str = "frmSalePurch3"
				Else
					flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "SalePurch4", False)
					If flag Then
						str = "frmSalePurch4"
					Else
						flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "SalePurch5", False)
						If flag Then
							str = "frmSalePurch5"
						Else
							flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "frmMezanMorg3a2", False)
							If flag Then
								str = "frmMezanMorg3a2"
							Else
								flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "frmMezanyaArba72", False)
								If flag Then
									str = "frmMezanyaArba72"
								Else
									flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "frmMezanyaArba73", False)
									If flag Then
										str = "frmMezanyaArba73"
									Else
										flag = Operators.ConditionalCompareObjectEqual(frm.Tag, "frmMezanyaArba74", False)
										If flag Then
											str = "frmMezanyaArba74"
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select IS_New,IS_Save,IS_Delete,IS_Search,IS_Print from User_Permissions,Forms where User_Permissions.Form_id=Forms.id and Forms.FormName='" + str + "' and user_id=" + Conversions.ToString(MainClass.UserID), MainClass.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			flag = (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = frm.Controls.Find("toolStrip1", True).Count() > 0
				If flag2 Then
					Dim toolStrip As ToolStrip = CType(frm.Controls.Find("toolStrip1", True)(0), ToolStrip)
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_New")))
					If flag2 Then
						flag = (toolStrip.Items.Find("btnNew", True).Count() > 0)
						If flag Then
							toolStrip.Items.Find("btnNew", True)(0).Enabled = False
						End If
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Save")))
					If flag2 Then
						flag = (toolStrip.Items.Find("btnSave", True).Count() > 0)
						If flag Then
							toolStrip.Items.Find("btnSave", True)(0).Enabled = False
						End If
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Delete")))
					If flag2 Then
						flag = (toolStrip.Items.Find("btnDelete", True).Count() > 0)
						If flag Then
							toolStrip.Items.Find("btnDelete", True)(0).Enabled = False
						End If
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Search")))
					If flag2 Then
						Try
							toolStrip.Items.Find("btnLast", True)(0).Enabled = False
							toolStrip.Items.Find("btnNext", True)(0).Enabled = False
							toolStrip.Items.Find("btnPrevious", True)(0).Enabled = False
							toolStrip.Items.Find("btnFirst", True)(0).Enabled = False
							flag2 = (frm.Controls.Find("TabControl1", True).Count() > 0)
							If flag2 Then
								Dim tabControl As TabControl = CType(frm.Controls.Find("TabControl1", True)(0), TabControl)
								MainClass.EnableControls(tabControl.TabPages(1), False)
							End If
						Catch ex As Exception
						End Try
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Print")))
					If flag2 Then
						flag = (toolStrip.Items.Find("btnPrint", True).Count() > 0)
						If flag Then
							toolStrip.Items.Find("btnPrint", True)(0).Enabled = False
						End If
					End If
				Else
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Search")))
					If flag2 Then
						flag = (frm.Controls.Find("btnShow", True).Count() > 0)
						If flag Then
							frm.Controls.Find("btnShow", True)(0).Enabled = False
						End If
					End If
					flag2 = Not Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("IS_Print")))
					If flag2 Then
						flag = (frm.Controls.Find("btnPreview", True).Count() > 0)
						If flag Then
							frm.Controls.Find("btnPreview", True)(0).Enabled = False
						End If
						flag2 = (frm.Controls.Find("btnPrint", True).Count() > 0)
						If flag2 Then
							frm.Controls.Find("btnPrint", True)(0).Enabled = False
						End If
					End If
				End If
			End If
		Catch ex2 As Exception
		End Try
	End Sub

	Public Shared Function Image2Arr(img As Image) As Byte()
		Dim memoryStream As MemoryStream = New MemoryStream()
		img.Save(memoryStream, ImageFormat.Jpeg)
		Return memoryStream.GetBuffer()
	End Function

	Public Shared Function Arr2Image(arr As Byte()) As Image
		Dim stream As MemoryStream = New MemoryStream(arr)
		Return Image.FromStream(stream)
	End Function

	Public Shared Sub CLRForm(parent As Control)
		Try
			For Each obj As Object In parent.Controls
				Dim control As Control = CType(obj, Control)
				Dim flag As Boolean = TypeOf control Is TextBox
				If flag Then
					control.Text = ""
				End If
				flag = (TypeOf control Is ComboBox)
				If flag Then
					Dim comboBox As ComboBox = CType(control, ComboBox)
					comboBox.SelectedIndex = -1
				End If
				flag = (TypeOf control Is PictureBox)
				If flag Then
					Dim pictureBox As PictureBox = CType(control, PictureBox)
					pictureBox.Image = Nothing
				End If
				flag = (TypeOf control Is DateTimePicker)
				If flag Then
					Dim dateTimePicker As DateTimePicker = CType(control, DateTimePicker)
					dateTimePicker.Value = DateTime.Now
				End If
				MainClass.CLRForm(control)
			Next
		Finally
			Dim enumerator As IEnumerator
			Dim flag As Boolean = TypeOf enumerator Is IDisposable
			If flag Then
				TryCast(enumerator, IDisposable).Dispose()
			End If
		End Try
	End Sub

	Public Shared Sub IsFloat(e As KeyPressEventArgs)
		Dim flag As Boolean = Not (Char.IsNumber(e.KeyChar) Or Strings.Asc(e.KeyChar) = 8 Or Operators.CompareString(e.KeyChar.ToString(), ".", False) = 0)
		If flag Then
			e.Handled = True
		End If
	End Sub

	Public Shared Sub ISInteger(e As KeyPressEventArgs)
		Dim flag As Boolean = Not (Char.IsNumber(e.KeyChar) Or Strings.Asc(e.KeyChar) = 8)
		If flag Then
			e.Handled = True
		End If
	End Sub

	Public Shared Function GenerateCode(Parent_Code As Integer) As String
		Dim result As String
		Try
			Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select max(Code) from Accounts_Index where ParentCode='" + Conversions.ToString(Parent_Code) + "'", MainClass.conn)
			Dim dataTable As DataTable = New DataTable()
			sqlDataAdapter.Fill(dataTable)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)(0).ToString(), "", False) <> 0
				If flag2 Then
					result = "" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)(0))) + 1.0)
				Else
					result = "" + Conversions.ToString(Parent_Code) + "0001"
				End If
			Else
				result = "" + Conversions.ToString(Parent_Code) + "0001"
			End If
		Catch ex As Exception
			result = ""
		End Try
		Return result
	End Function

	Public Shared Function ISExpire(_date As DateTime) As Boolean
		Try
			Dim flag As Boolean
			Dim frmBuyApp As New frmBuyApp()
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select open_expire from foundation where id=1", MainClass.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = (Operators.CompareString(MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)("open_expire"))), MainClass._enckey), "open", False) = 0)
				If flag Then
					Return False
				End If
			Catch ex As Exception
			End Try
			Dim str As String = ""
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				If flag Then
					str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				End If
			Catch ex2 As Exception
			End Try
			Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
			Dim text As String = _date.ToString("dd/MM/yyyy")
			Dim dateTimeFormat As DateTimeFormatInfo = New CultureInfo("en-us", False).DateTimeFormat
			dateTimeFormat.Calendar = New GregorianCalendar()
			flag = (registryKey.GetValue("Expire") IsNot Nothing)
			If flag Then
				Try
					Dim text2 As String = MainClass.Decrypt(Conversions.ToString(registryKey.GetValue("Expire")), MainClass._enckey).Replace("-", "/")
					Try
						flag = (Convert.ToInt32(text2.Split(New Char() {"/"c})(2)) < 1990)
						If flag Then
							text2 = MainClass.ConvertDateCalendar(Convert.ToDateTime(text2), "Gregorian", "en-US")
						End If
					Catch ex3 As Exception
					End Try
					Dim t As DateTime = DateTime.ParseExact(text2, "dd/MM/yyyy", dateTimeFormat)
					flag = (DateTime.Compare(t, _date) < 0)
					If flag Then
						Interaction.MsgBox("تم انتهاء صلاحية الدعم الفني للبرنامج ، يرجى الاتصال بالدعم الفني", MsgBoxStyle.OkOnly, Nothing)
						frmBuyApp.ShowDialog()
						Return True
					End If
				Catch ex4 As Exception
					Interaction.MsgBox("حدث خطأ بخصوص صلاحية تفعيلك، يرجى الاتصال بالدعم الفني", MsgBoxStyle.OkOnly, Nothing)
					frmBuyApp.ShowDialog()
					Return True
				End Try
			Else
				Dim sqlDataAdapter2 As SqlDataAdapter = New SqlDataAdapter("select date_exp from foundation where id=1", MainClass.conn)
				Dim dataTable2 As DataTable = New DataTable()
				sqlDataAdapter2.Fill(dataTable2)
				flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable2.Rows(0)(0)), "", False)
				If flag Then
					Dim text3 As String = MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable2.Rows(0)(0))), MainClass._enckey).Replace("-", "/")
					Try
						flag = (Convert.ToInt32(text3.Split(New Char() {"/"c})(2)) < 1990)
						If flag Then
							text3 = MainClass.ConvertDateCalendar(Convert.ToDateTime(text3), "Gregorian", "en-US")
						End If
					Catch ex5 As Exception
					End Try
					Dim t2 As DateTime = DateTime.ParseExact(text3, "dd/MM/yyyy", dateTimeFormat)
					flag = (DateTime.Compare(t2, _date) < 0)
					If flag Then
						Interaction.MsgBox("تم انتهاء صلاحية تفعيل البرنامج الخاص بك، يرجى الاتصال بالدعم الفني", MsgBoxStyle.OkOnly, Nothing)
						frmBuyApp.ShowDialog()
						Return True
					End If
				End If
			End If
		Catch ex6 As Exception
		End Try
		Return False
	End Function

	Public Shared Function ConvertDateCalendar(DateConv As DateTime, Calendar As String, DateLangCulture As String) As String
		DateLangCulture = DateLangCulture.ToLower()
		Dim flag As Boolean = Operators.CompareString(Calendar, "Hijri", False) = 0 AndAlso DateLangCulture.StartsWith("en-")
		If flag Then
			DateLangCulture = "ar-sa"
		End If
		Dim dateTimeFormat As DateTimeFormatInfo = New CultureInfo(DateLangCulture, False).DateTimeFormat
		flag = (Operators.CompareString(Calendar, "Hijri", False) = 0)
		If flag Then
			dateTimeFormat.Calendar = New HijriCalendar()
		Else
			flag = (Operators.CompareString(Calendar, "Gregorian", False) = 0)
			If Not flag Then
				Return ""
			End If
			dateTimeFormat.Calendar = New GregorianCalendar()
		End If
		dateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
		Return DateConv.[Date].ToString("dd/MM/yyyy", dateTimeFormat)
	End Function

	Public Shared Function GetExpireDaysDiff() As Integer
		Try
			Dim str As String = ""
			Dim flag As Boolean
			Try
				flag = File.Exists(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				If flag Then
					str = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\copyno.txt")
				End If
			Catch ex As Exception
			End Try
			Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\ExchangeVB" + str, True)
			Dim text As String = DateTime.Now.ToString("dd/MM/yyyy")
			Dim dateTimeFormat As DateTimeFormatInfo = New CultureInfo("en-us", False).DateTimeFormat
			dateTimeFormat.Calendar = New GregorianCalendar()
			flag = (registryKey.GetValue("Expire") IsNot Nothing)
			If flag Then
				Dim text2 As String = MainClass.Decrypt(Conversions.ToString(registryKey.GetValue("Expire")), MainClass._enckey).Replace("-", "/")
				Try
					flag = (Convert.ToInt32(text2.Split(New Char() {"/"c})(2)) < 1990)
					If flag Then
						text2 = MainClass.ConvertDateCalendar(Convert.ToDateTime(text2), "Gregorian", "en-US")
					End If
				Catch ex2 As Exception
				End Try
				Return DateTime.ParseExact(text2, "dd/MM/yyyy", dateTimeFormat).Subtract(DateTime.Now).Days
			End If
			Try
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("select date_exp from foundation where id=1", MainClass.conn)
				Dim dataTable As DataTable = New DataTable()
				sqlDataAdapter.Fill(dataTable)
				flag = Operators.ConditionalCompareObjectNotEqual(Operators.ConcatenateObject("", dataTable.Rows(0)(0)), "", False)
				If flag Then
					Dim text3 As String = MainClass.Decrypt(Conversions.ToString(Operators.ConcatenateObject("", dataTable.Rows(0)(0))), MainClass._enckey).Replace("-", "/")
					Try
						flag = (Convert.ToInt32(text3.Split(New Char() {"/"c})(2)) < 1990)
						If flag Then
							text3 = MainClass.ConvertDateCalendar(Convert.ToDateTime(text3), "Gregorian", "en-US")
						End If
					Catch ex3 As Exception
					End Try
					Return DateTime.ParseExact(text3, "dd/MM/yyyy", dateTimeFormat).Subtract(DateTime.Now).Days
				End If
			Catch ex4 As Exception
			End Try
		Catch ex5 As Exception
		End Try
		Return 0
	End Function

	Public Shared Function Encrypt(inText As String, key As String) As String
		Dim bytes As Byte() = Encoding.Unicode.GetBytes(inText)
		Dim aes As Aes = Aes.Create()
		Try
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(key, New Byte() {73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118})
			aes.Key = rfc2898DeriveBytes.GetBytes(32)
			aes.IV = rfc2898DeriveBytes.GetBytes(16)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Try
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
				Try
					cryptoStream.Write(bytes, 0, bytes.Length)
					cryptoStream.Close()
				Finally
					Dim flag As Boolean = cryptoStream IsNot Nothing
					If flag Then
						CType(cryptoStream, IDisposable).Dispose()
					End If
				End Try
				inText = Convert.ToBase64String(memoryStream.ToArray())
			Finally
				Dim flag As Boolean = memoryStream IsNot Nothing
				If flag Then
					CType(memoryStream, IDisposable).Dispose()
				End If
			End Try
		Finally
			Dim flag As Boolean = aes IsNot Nothing
			If flag Then
				CType(aes, IDisposable).Dispose()
			End If
		End Try
		Return inText
	End Function

	Public Shared Function Decrypt(cryptTxt As String, key As String) As String
		cryptTxt = cryptTxt.Replace(" ", "+")
		Dim array As Byte() = Convert.FromBase64String(cryptTxt)
		Dim aes As Aes = Aes.Create()
		Try
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(key, New Byte() {73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118})
			aes.Key = rfc2898DeriveBytes.GetBytes(32)
			aes.IV = rfc2898DeriveBytes.GetBytes(16)
			Dim memoryStream As MemoryStream = New MemoryStream()
			Try
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write)
				Try
					cryptoStream.Write(array, 0, array.Length)
					cryptoStream.Close()
				Finally
					Dim flag As Boolean = cryptoStream IsNot Nothing
					If flag Then
						CType(cryptoStream, IDisposable).Dispose()
					End If
				End Try
				cryptTxt = Encoding.Unicode.GetString(memoryStream.ToArray())
			Finally
				Dim flag As Boolean = memoryStream IsNot Nothing
				If flag Then
					CType(memoryStream, IDisposable).Dispose()
				End If
			End Try
		Finally
			Dim flag As Boolean = aes IsNot Nothing
			If flag Then
				CType(aes, IDisposable).Dispose()
			End If
		End Try
		Return cryptTxt
	End Function
End Class
