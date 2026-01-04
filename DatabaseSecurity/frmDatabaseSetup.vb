' frmDatabaseSetup.vb
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmDatabaseSetup

    Private _manager As SecureDatabaseManager
    Private _dragging As Boolean = False
    Private _dragStart As Point

    Public Property SetupCompleted As Boolean = False

    Private Sub frmDatabaseSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDatabaseName.Text = AppConstants.DEFAULT_DB_NAME
        progressBar.Value = 0
        lblStatus.Text = "جاهز"

        Log("🚀 معالج إعداد قاعدة البيانات المحمية", False)
        Log("📋 اختر الخادم ثم اضغط 'إعداد كامل'", False)
        Log("═══════════════════════════════════════", False)

        SearchServers()
    End Sub

    Private Async Sub SearchServers()
        btnRefresh.Enabled = False
        cmbServers.Items.Clear()
        cmbServers.Text = "جاري البحث..."

        Dim servers = Await Task.Run(Function() SecureDatabaseManager.GetAvailableSqlServers())

        cmbServers.Items.Clear()
        For Each s In servers
            cmbServers.Items.Add(s)
        Next

        If cmbServers.Items.Count > 0 Then
            cmbServers.SelectedIndex = 0
            Log($"✅ تم العثور على {servers.Count} خادم", False)
        Else
            Log("⚠️ لم يتم العثور على خوادم", True)
        End If

        btnRefresh.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        SearchServers()
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        If Not ValidateInput() Then Return
        CreateManager()
        _manager.TestConnection()
    End Sub

    Private Async Sub btnCreateDatabase_Click(sender As Object, e As EventArgs) Handles btnCreateDatabase.Click
        If Not ValidateInput() Then Return
        SetBusy(True)
        CreateManager()
        Await Task.Run(Function() _manager.CreateDatabase())
        SetBusy(False)
    End Sub

    Private Async Sub btnExecuteScript_Click(sender As Object, e As EventArgs) Handles btnExecuteScript.Click
        If Not ValidateInput() Then Return
        SetBusy(True)
        CreateManager()
        Await Task.Run(Function() _manager.ExecuteScript())
        SetBusy(False)
    End Sub

    Private Async Sub btnApplyProtection_Click(sender As Object, e As EventArgs) Handles btnApplyProtection.Click
        If Not ValidateInput() Then Return
        SetBusy(True)
        CreateManager()
        Await Task.Run(Function() _manager.ApplyProtection())
        SetBusy(False)
    End Sub

    Private Async Sub btnFullSetup_Click(sender As Object, e As EventArgs) Handles btnFullSetup.Click
        If Not ValidateInput() Then Return

        Dim result = MessageBox.Show(
            "سيتم:" & vbCrLf &
            "1️⃣ إنشاء قاعدة البيانات" & vbCrLf &
            "2️⃣ تنفيذ Script" & vbCrLf &
            "3️⃣ إنشاء مستخدم SQL محمي" & vbCrLf &
            "4️⃣ تطبيق الحماية" & vbCrLf &
            "5️⃣ حفظ الإعدادات" & vbCrLf & vbCrLf &
            "هل تريد المتابعة؟",
            "تأكيد الإعداد",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then Return

        SetBusy(True)
        CreateManager()

        ' الخطوة 1
        Log("═══════════════════════════════════════", False)
        Log("📌 الخطوة 1: إنشاء قاعدة البيانات", False)
        Dim ok1 = Await Task.Run(Function() _manager.CreateDatabase())
        If Not ok1 Then
            SetBusy(False)
            Return
        End If

        Await Task.Delay(500)

        ' الخطوة 2
        Log("═══════════════════════════════════════", False)
        Log("📌 الخطوة 2: تنفيذ Script", False)
        Dim ok2 = Await Task.Run(Function() _manager.ExecuteScript())
        If Not ok2 Then
            SetBusy(False)
            Return
        End If

        Await Task.Delay(500)

        ' الخطوة 3
        Log("═══════════════════════════════════════", False)
        Log("📌 الخطوة 3: تطبيق الحماية", False)
        Dim ok3 = Await Task.Run(Function() _manager.ApplyProtection())
        If Not ok3 Then
            SetBusy(False)
            Return
        End If

        ' حفظ الإعدادات
        _manager.SaveSettings(1, "admin", "admin", True)

        Log("═══════════════════════════════════════", False)
        Log("🎉 تم الإعداد بنجاح!", False)
        Log("🔐 البيانات محمية", False)

        SetupCompleted = True

        MessageBox.Show(
            "✅ تم إعداد قاعدة البيانات بنجاح!" & vbCrLf & vbCrLf &
            "🔐 الحماية مفعلة" & vbCrLf & vbCrLf &
            "سجل الدخول بـ:" & vbCrLf &
            "👤 المستخدم: admin" & vbCrLf &
            "🔑 كلمة المرور: admin",
            "نجاح",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        SetBusy(False)
        Me.Close()
    End Sub

    Private Sub CreateManager()
        _manager = New SecureDatabaseManager(cmbServers.Text, txtDatabaseName.Text)
        AddHandler _manager.LogMessage, AddressOf Log
        AddHandler _manager.ProgressChanged, AddressOf Progress
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(cmbServers.Text) OrElse cmbServers.Text.Contains("البحث") Then
            MessageBox.Show("اختر الخادم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(txtDatabaseName.Text) Then
            MessageBox.Show("ادخل اسم القاعدة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub Log(msg As String, isErr As Boolean)
        If rtbLog.InvokeRequired Then
            rtbLog.Invoke(Sub() Log(msg, isErr))
            Return
        End If
        rtbLog.SelectionColor = If(isErr, Color.OrangeRed, Color.Lime)
        rtbLog.AppendText(DateTime.Now.ToString("HH:mm:ss") & " │ " & msg & vbCrLf)
        rtbLog.ScrollToCaret()
    End Sub

    Private Sub Progress(val As Integer)
        If progressBar.InvokeRequired Then
            progressBar.Invoke(Sub() Progress(val))
            Return
        End If
        progressBar.Value = Math.Min(val, 100)
        lblStatus.Text = $"{val}%"
    End Sub

    Private Sub SetBusy(busy As Boolean)
        btnCreateDatabase.Enabled = Not busy
        btnExecuteScript.Enabled = Not busy
        btnApplyProtection.Enabled = Not busy
        btnTestConnection.Enabled = Not busy
        btnFullSetup.Enabled = Not busy
        btnRefresh.Enabled = Not busy
        cmbServers.Enabled = Not busy
        txtDatabaseName.Enabled = Not busy
        Cursor = If(busy, Cursors.WaitCursor, Cursors.Default)
        If Not busy Then
            progressBar.Value = 0
            lblStatus.Text = "جاهز"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' سحب النافذة
    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        _dragging = True : _dragStart = e.Location
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        If _dragging Then Location = New Point(Location.X + e.X - _dragStart.X, Location.Y + e.Y - _dragStart.Y)
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp
        _dragging = False
    End Sub

End Class