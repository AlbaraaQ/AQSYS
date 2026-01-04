' SecureDatabaseManager.vb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.ServiceProcess
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Data

Public Class SecureDatabaseManager

    Private _serverName As String
    Private _databaseName As String

    Public Event LogMessage(message As String, isError As Boolean)
    Public Event ProgressChanged(progress As Integer)

    ' مفتاح التشفير
    Private Shared ReadOnly EncryptionKey As String = "StockDB@2024#SecureKey!@#$%"

    Public Sub New(serverName As String, databaseName As String)
        _serverName = serverName
        _databaseName = databaseName
    End Sub

#Region "التشفير وفك التشفير"

    ''' <summary>
    ''' تشفير النص
    ''' </summary>
    Public Shared Function Encrypt(plainText As String) As String
        If String.IsNullOrEmpty(plainText) Then Return ""

        Try
            Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(plainText)

            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {
                    &H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64,
                    &H76, &H65, &H64, &H65, &H76
                })

                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)

                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                        cs.Write(clearBytes, 0, clearBytes.Length)
                        cs.Close()
                    End Using
                    Return Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        Catch
            Return plainText
        End Try
    End Function

    ''' <summary>
    ''' فك التشفير
    ''' </summary>
    Public Shared Function Decrypt(cipherText As String) As String
        If String.IsNullOrEmpty(cipherText) Then Return ""

        Try
            cipherText = cipherText.Replace(" ", "+")
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)

            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {
                    &H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64,
                    &H76, &H65, &H64, &H65, &H76
                })

                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)

                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    Return Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
        Catch
            Return cipherText
        End Try
    End Function

#End Region

#Region "البحث عن الخوادم"

    Public Shared Function GetAvailableSqlServers() As List(Of String)
        Dim servers As New List(Of String)
        Try
            For Each svc In ServiceController.GetServices()
                If svc.ServiceName = "MSSQLSERVER" AndAlso svc.Status = ServiceControllerStatus.Running Then
                    servers.Add("localhost")
                    servers.Add(".")
                ElseIf svc.ServiceName.StartsWith("MSSQL$") AndAlso svc.Status = ServiceControllerStatus.Running Then
                    Dim name = svc.ServiceName.Replace("MSSQL$", "")
                    servers.Add("localhost\" & name)
                    servers.Add(".\" & name)
                End If
            Next
        Catch
        End Try

        If servers.Count = 0 Then
            servers.Add("localhost")
            servers.Add(".\SQLEXPRESS")
        End If

        Return servers.Distinct().ToList()
    End Function

#End Region

#Region "سلاسل الاتصال"

    Private Function GetAdminConnectionString(Optional db As String = "master") As String
        Return $"Server={_serverName};Database={db};Integrated Security=True;" &
               "Connection Timeout=30;TrustServerCertificate=True;Encrypt=False;"
    End Function

    Public Shared Function GetSecureConnectionString(server As String, database As String) As String
        Return $"Server={server};Database={database};" &
               $"User Id={AppConstants.SQL_USER};Password={AppConstants.SQL_PASS};" &
               $"Application Name={AppConstants.APP_SIGNATURE};" &
               "MultipleActiveResultSets=True;Connection Timeout=30;" &
               "TrustServerCertificate=True;Encrypt=False;"
    End Function

    Public Shared Function CreateConnection(server As String, database As String) As SqlConnection
        Try
            Dim connStr = GetSecureConnectionString(server, database)
            Dim conn As New SqlConnection(connStr)
            conn.Open()
            Return conn
        Catch
            Return Nothing
        End Try
    End Function

    Public Function TestConnection() As Boolean
        Try
            RaiseEvent LogMessage("🔄 اختبار الاتصال...", False)
            Using conn As New SqlConnection(GetAdminConnectionString())
                conn.Open()
            End Using
            RaiseEvent LogMessage("✅ الاتصال ناجح: " & _serverName, False)
            Return True
        Catch ex As Exception
            RaiseEvent LogMessage("❌ فشل: " & ex.Message, True)
            Return False
        End Try
    End Function

#End Region

#Region "إنشاء قاعدة البيانات"

    Public Function CreateDatabase() As Boolean
        Try
            RaiseEvent LogMessage("📊 إنشاء قاعدة البيانات...", False)
            RaiseEvent ProgressChanged(10)

            Using conn As New SqlConnection(GetAdminConnectionString())
                conn.Open()

                Dim checkSql = $"SELECT COUNT(*) FROM sys.databases WHERE name = N'{_databaseName}'"
                Using cmd As New SqlCommand(checkSql, conn)
                    If CInt(cmd.ExecuteScalar()) > 0 Then
                        RaiseEvent LogMessage("⚠️ القاعدة موجودة مسبقاً", False)
                        RaiseEvent ProgressChanged(100)
                        Return True
                    End If
                End Using

                Using cmd As New SqlCommand($"CREATE DATABASE [{_databaseName}]", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            RaiseEvent LogMessage("✅ تم إنشاء القاعدة", False)
            RaiseEvent ProgressChanged(100)
            Return True

        Catch ex As Exception
            RaiseEvent LogMessage("❌ " & ex.Message, True)
            Return False
        End Try
    End Function

    Private Function DatabaseExists() As Boolean
        Try
            Using conn As New SqlConnection(GetAdminConnectionString())
                conn.Open()
                Dim sql = $"SELECT COUNT(*) FROM sys.databases WHERE name = N'{_databaseName}'"
                Using cmd As New SqlCommand(sql, conn)
                    Return CInt(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "تنفيذ Script"

    Public Function ExecuteScript() As Boolean
        Try
            RaiseEvent LogMessage("📥 تنفيذ Script...", False)
            RaiseEvent ProgressChanged(5)

            Dim script As String = My.Resources.script
            If String.IsNullOrEmpty(script) Then
                RaiseEvent LogMessage("❌ ملف Script فارغ!", True)
                Return False
            End If

            script = script.Replace("[StockDB-4soft]", $"[{_databaseName}]")
            script = script.Replace("StockDB-4soft", _databaseName)

            Dim lines = script.Split({vbCrLf, vbLf}, StringSplitOptions.None).
                Where(Function(l) Not l.Trim().ToUpper().StartsWith("USE ")).ToList()
            script = String.Join(vbCrLf, lines)

            Dim commands = script.Split({"GO" & vbCrLf, vbCrLf & "GO", "GO" & vbLf, vbLf & "GO"},
                StringSplitOptions.RemoveEmptyEntries).
                Where(Function(c) Not String.IsNullOrWhiteSpace(c) AndAlso c.Trim().ToUpper() <> "GO").ToList()

            RaiseEvent LogMessage($"📋 {commands.Count} أمر", False)

            Using conn As New SqlConnection(GetAdminConnectionString(_databaseName))
                conn.Open()

                Dim done = 0
                For i = 0 To commands.Count - 1
                    Try
                        Using cmd As New SqlCommand(commands(i), conn)
                            cmd.CommandTimeout = 120
                            cmd.ExecuteNonQuery()
                            done += 1
                        End Using
                    Catch
                    End Try
                    RaiseEvent ProgressChanged(5 + CInt((i / commands.Count) * 90))
                Next

                RaiseEvent LogMessage($"✅ {done}/{commands.Count} أمر", False)
            End Using

            RaiseEvent ProgressChanged(100)
            Return True

        Catch ex As Exception
            RaiseEvent LogMessage("❌ " & ex.Message, True)
            Return False
        End Try
    End Function

#End Region

#Region "تطبيق الحماية"

    ''' <summary>
    ''' قائمة كل الجداول المطلوب حمايتها
    ''' </summary>
    Private ReadOnly AllTables As String() = {
        "Users", "User_Permissions", "UserSetting",
        "Inv", "Inv_Sub", "inv_services", "inv_serials", "inv_docs",
        "SandQ", "SandD", "SandQD", "SandSD",
        "MultiQbd", "MultiQbd_sub", "MultiSarf", "MultiSarf_sub",
        "Restrictions", "Restrictions_Sub",
        "Accounts_Index",
        "Currencies", "Currency_SafeBalance", "Currency_Lastprice", "Currency_Lastprice_Sub",
        "curr_units", "curr_barcodes",
        "Customers", "Companies", "Banks", "Branches",
        "Employees", "EmpBranches", "EmpSalaryAddSub",
        "Safes", "Safe_Emps", "SafesTransfer", "SafesTransfer_Sub",
        "Stocks", "Stock_Emps",
        "groups", "units", "materials", "mat_units",
        "Twreed_Srf", "Twreed_Srf_Sub",
        "tsweya", "tsweya_sub",
        "SalaryPay", "Salary_Pay", "Salary_Pay_Sub", "SalaryAddSubTypes",
        "Foundation", "Forms",
        "offers", "offers_sub", "offers2",
        "cont", "cont_installments",
        "services", "services_inv", "services_inv_sub",
        "tawla", "tawla_groups", "tawla_reserve",
        "delivery_emps", "mobapps", "salesmen",
        "SecurityKeys", "SecurityLog"
    }

    Public Function ApplyProtection() As Boolean
        Try
            RaiseEvent LogMessage("🔐 تطبيق الحماية الشاملة...", False)
            RaiseEvent ProgressChanged(5)

            If Not DatabaseExists() Then
                RaiseEvent LogMessage("❌ قاعدة البيانات غير موجودة!", True)
                Return False
            End If
            RaiseEvent ProgressChanged(10)

            RaiseEvent LogMessage("   📋 إنشاء جداول الأمان...", False)
            CreateSecurityKeysTable()
            RaiseEvent ProgressChanged(20)

            RaiseEvent LogMessage("   👤 إنشاء مستخدم SQL...", False)
            CreateSqlUser()
            RaiseEvent ProgressChanged(40)

            RaiseEvent LogMessage("   🔑 منح الصلاحيات...", False)
            GrantPermissions()
            RaiseEvent ProgressChanged(50)

            RaiseEvent LogMessage("   🛡️ حماية جميع الجداول...", False)
            CreateAllTableProtectionTriggers()
            RaiseEvent ProgressChanged(80)

            RaiseEvent LogMessage("   🔄 اختبار الاتصال الآمن...", False)
            Threading.Thread.Sleep(1000)

            If TestSecureConnection() Then
                RaiseEvent LogMessage("✅ تم تطبيق الحماية بنجاح!", False)
                RaiseEvent ProgressChanged(100)
                Return True
            Else
                RaiseEvent LogMessage("❌ فشل اختبار الاتصال", True)
                Return False
            End If

        Catch ex As Exception
            RaiseEvent LogMessage("❌ خطأ: " & ex.Message, True)
            Return False
        End Try
    End Function

    Private Sub CreateSecurityKeysTable()
        Using conn As New SqlConnection(GetAdminConnectionString(_databaseName))
            conn.Open()

            Dim sql = "
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SecurityKeys')
                CREATE TABLE SecurityKeys (
                    id INT IDENTITY(1,1) PRIMARY KEY,
                    user_id INT NOT NULL,
                    validation_key NVARCHAR(500),
                    created_date DATETIME DEFAULT GETDATE(),
                    last_login DATETIME,
                    is_active BIT DEFAULT 1
                );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SecurityLog')
                CREATE TABLE SecurityLog (
                    id INT IDENTITY(1,1) PRIMARY KEY,
                    username NVARCHAR(100),
                    action_type NVARCHAR(50),
                    result NVARCHAR(20),
                    app_name NVARCHAR(200),
                    error_message NVARCHAR(500),
                    log_date DATETIME DEFAULT GETDATE()
                );"

            Using cmd As New SqlCommand(sql, conn)
                cmd.CommandTimeout = 60
                cmd.ExecuteNonQuery()
            End Using
        End Using
        RaiseEvent LogMessage("      ✅ تم إنشاء جداول الأمان", False)
    End Sub

    Private Sub CreateSqlUser()
        Using conn As New SqlConnection(GetAdminConnectionString())
            conn.Open()

            Try
                Dim dropSql = $"IF EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'{AppConstants.SQL_USER}') DROP LOGIN [{AppConstants.SQL_USER}]"
                Using cmd As New SqlCommand(dropSql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            Catch
            End Try

            Threading.Thread.Sleep(500)

            Dim createSql = $"CREATE LOGIN [{AppConstants.SQL_USER}] WITH PASSWORD = N'{AppConstants.SQL_PASS}', DEFAULT_DATABASE = [{_databaseName}], CHECK_POLICY = OFF, CHECK_EXPIRATION = OFF"
            Using cmd As New SqlCommand(createSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            RaiseEvent LogMessage($"      ✅ تم إنشاء Login: {AppConstants.SQL_USER}", False)
        End Using

        Threading.Thread.Sleep(500)

        Using conn As New SqlConnection(GetAdminConnectionString(_databaseName))
            conn.Open()

            Try
                Dim dropSql = $"IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'{AppConstants.SQL_USER}') DROP USER [{AppConstants.SQL_USER}]"
                Using cmd As New SqlCommand(dropSql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            Catch
            End Try

            Threading.Thread.Sleep(300)

            Dim createSql = $"CREATE USER [{AppConstants.SQL_USER}] FOR LOGIN [{AppConstants.SQL_USER}]"
            Using cmd As New SqlCommand(createSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            Dim roleSql = $"ALTER ROLE [db_owner] ADD MEMBER [{AppConstants.SQL_USER}]"
            Using cmd As New SqlCommand(roleSql, conn)
                cmd.ExecuteNonQuery()
            End Using

            RaiseEvent LogMessage($"      ✅ تم إنشاء User: {AppConstants.SQL_USER}", False)
        End Using
    End Sub

    Private Sub GrantPermissions()
        Using conn As New SqlConnection(GetAdminConnectionString(_databaseName))
            conn.Open()

            Dim sql = $"
                GRANT CONNECT TO [{AppConstants.SQL_USER}];
                GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON SCHEMA::dbo TO [{AppConstants.SQL_USER}];"

            Using cmd As New SqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        RaiseEvent LogMessage("      ✅ تم منح الصلاحيات", False)
    End Sub

    ''' <summary>
    ''' حماية جميع الجداول
    ''' </summary>
    Private Sub CreateAllTableProtectionTriggers()
        Using conn As New SqlConnection(GetAdminConnectionString(_databaseName))
            conn.Open()

            Dim protectedCount = 0
            Dim totalTables = AllTables.Length

            For i = 0 To AllTables.Length - 1
                Dim tableName = AllTables(i)

                Try
                    ' التحقق من وجود الجدول
                    Dim checkSql = $"SELECT COUNT(*) FROM sys.tables WHERE name = N'{tableName}'"
                    Dim exists As Boolean
                    Using cmd As New SqlCommand(checkSql, conn)
                        exists = CInt(cmd.ExecuteScalar()) > 0
                    End Using

                    If Not exists Then Continue For

                    ' حذف Trigger القديم
                    Dim dropSql = $"IF EXISTS (SELECT * FROM sys.triggers WHERE name = N'TR_Protect_{tableName}') DROP TRIGGER [dbo].[TR_Protect_{tableName}]"
                    Using cmd As New SqlCommand(dropSql, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' إنشاء Trigger جديد
                    Dim createSql = $"
                        CREATE TRIGGER [dbo].[TR_Protect_{tableName}]
                        ON [dbo].[{tableName}]
                        FOR INSERT, UPDATE, DELETE
                        AS
                        BEGIN
                            SET NOCOUNT ON;
                            DECLARE @LoginName NVARCHAR(256) = SUSER_SNAME();
                            DECLARE @AppName NVARCHAR(256) = APP_NAME();
                            
                            -- السماح لـ sa
                            IF @LoginName = N'sa' RETURN;
                            
                            -- السماح لمستخدم التطبيق
                            IF @LoginName = N'{AppConstants.SQL_USER}' RETURN;
                            
                            -- السماح للتطبيق الرسمي
                            IF @AppName LIKE N'{AppConstants.APP_SIGNATURE}%' RETURN;
                            
                            -- السماح لـ SSMS للإدارة
                            IF @AppName LIKE N'Microsoft SQL Server Management Studio%' RETURN;
                            
                            -- تسجيل المحاولة
                            BEGIN TRY
                                INSERT INTO SecurityLog (username, action_type, result, app_name, error_message)
                                VALUES (@LoginName, 'BLOCKED_MODIFY', 'REJECTED', @AppName, N'محاولة تعديل جدول {tableName}');
                            END TRY
                            BEGIN CATCH
                            END CATCH
                            
                            -- رفض
                            RAISERROR(N'لا يسمح لك باستخدام هذا البرنامج. استخدم التطبيق الرسمي.', 16, 1);
                            ROLLBACK TRANSACTION;
                        END"

                    Using cmd As New SqlCommand(createSql, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    protectedCount += 1

                Catch
                End Try

                ' تحديث التقدم
                RaiseEvent ProgressChanged(50 + CInt((i / totalTables) * 30))
            Next

            RaiseEvent LogMessage($"      ✅ تم حماية {protectedCount} جدول", False)
        End Using
    End Sub

    Private Function TestSecureConnection() As Boolean
        Try
            Dim connStr = GetSecureConnectionString(_serverName, _databaseName)
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand("SELECT 1", conn)
                    cmd.ExecuteScalar()
                End Using
            End Using
            RaiseEvent LogMessage("      ✅ الاتصال الآمن يعمل!", False)
            Return True
        Catch ex As Exception
            RaiseEvent LogMessage("      ❌ فشل: " & ex.Message, True)
            Return False
        End Try
    End Function

#End Region

#Region "تسجيل الدخول"

    Public Shared Function Login(server As String, database As String, username As String, password As String) As DataRow
        Try
            Dim conn = CreateConnection(server, database)
            If conn Is Nothing Then Return Nothing

            Try
                Dim sql = "SELECT * FROM Users WHERE username = @u AND pwd = @p AND (IS_Deleted = 0 OR IS_Deleted IS NULL)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        If dt.Rows.Count > 0 Then Return dt.Rows(0)
                    End Using
                End Using
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        Catch
        End Try

        Return Nothing
    End Function

#End Region

#Region "حفظ وقراءة الإعدادات - مشفرة"

    ''' <summary>
    ''' حفظ الإعدادات مشفرة
    ''' </summary>
    Public Sub SaveSettings(branchId As Integer, userName As String, password As String, remember As Boolean)
        Try
            ' تجميع البيانات
            Dim serverInfo = $"{_serverName};{AppConstants.SQL_USER};{AppConstants.SQL_PASS}"

            Dim data As New StringBuilder()
            data.AppendLine(If(remember, "1", "0"))
            data.AppendLine(serverInfo)
            data.AppendLine(branchId.ToString())
            data.AppendLine(userName)
            data.AppendLine(password)
            data.AppendLine(_databaseName)

            ' تشفير كل المحتوى
            Dim encryptedData = Encrypt(data.ToString())

            Dim path = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Data.txt")
            IO.File.WriteAllText(path, encryptedData, Encoding.UTF8)

            RaiseEvent LogMessage("✅ تم حفظ الإعدادات (مشفرة)", False)
        Catch ex As Exception
            RaiseEvent LogMessage("❌ " & ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' قراءة الإعدادات المشفرة
    ''' </summary>
    Public Shared Function LoadSettings() As Settings
        Try
            Dim path = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Data.txt")
            If Not IO.File.Exists(path) Then Return Nothing

            ' قراءة وفك التشفير
            Dim encryptedData = IO.File.ReadAllText(path, Encoding.UTF8)
            Dim decryptedData = Decrypt(encryptedData)

            ' تحليل البيانات
            Dim lines = decryptedData.Split({vbCrLf, vbLf}, StringSplitOptions.None)
            If lines.Length < 6 Then Return Nothing

            Dim s As New Settings()

            ' السطر 0: تذكرني
            s.Remember = (lines(0).Trim() = "1")

            ' السطر 1: السيرفر;مستخدم_SQL;كلمة_مرور_SQL
            Dim serverLine = lines(1).Trim()
            If serverLine.Contains(";") Then
                Dim parts = serverLine.Split(";"c)
                s.Server = parts(0)
                If parts.Length > 1 Then s.SqlUser = parts(1)
                If parts.Length > 2 Then s.SqlPassword = parts(2)
            Else
                s.Server = serverLine
                s.SqlUser = AppConstants.SQL_USER
                s.SqlPassword = AppConstants.SQL_PASS
            End If

            ' السطر 2: رقم الفرع
            s.BranchId = CInt(Val(lines(2).Trim()))

            ' السطر 3: اسم المستخدم
            s.UserName = lines(3).Trim()

            ' السطر 4: كلمة المرور
            s.Password = lines(4).Trim()

            ' السطر 5: اسم القاعدة
            s.Database = lines(5).Trim()

            If String.IsNullOrEmpty(s.Server) OrElse String.IsNullOrEmpty(s.Database) Then
                Return Nothing
            End If

            Return s
        Catch
            Return Nothing
        End Try
    End Function

    Public Class Settings
        Public Property Remember As Boolean = False
        Public Property Server As String = ""
        Public Property SqlUser As String = ""
        Public Property SqlPassword As String = ""
        Public Property BranchId As Integer = 0
        Public Property UserName As String = ""
        Public Property Password As String = ""
        Public Property Database As String = ""
    End Class

#End Region

End Class