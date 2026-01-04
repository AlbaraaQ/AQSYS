Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class DatabaseSecurityManager

    Private Shared ReadOnly Key As Byte() = Encoding.UTF8.GetBytes("StockDB@2024#Key")
    Private Shared ReadOnly IV As Byte() = Encoding.UTF8.GetBytes("Stock#IV@2024!!")

    ''' <summary>
    ''' تشفير النص
    ''' </summary>
    Public Shared Function Encrypt(plainText As String) As String
        If String.IsNullOrEmpty(plainText) Then Return ""

        Try
            Using aes As Aes = Aes.Create()
                aes.Key = Key
                aes.IV = IV

                Dim encryptor = aes.CreateEncryptor(aes.Key, aes.IV)

                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                        Using sw As New StreamWriter(cs)
                            sw.Write(plainText)
                        End Using
                    End Using
                    Return Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
        Catch
            Return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText))
        End Try
    End Function

    ''' <summary>
    ''' فك التشفير
    ''' </summary>
    Public Shared Function Decrypt(encryptedText As String) As String
        If String.IsNullOrEmpty(encryptedText) Then Return ""

        Try
            Dim buffer = Convert.FromBase64String(encryptedText)

            Using aes As Aes = Aes.Create()
                aes.Key = Key
                aes.IV = IV

                Dim decryptor = aes.CreateDecryptor(aes.Key, aes.IV)

                Using ms As New MemoryStream(buffer)
                    Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                        Using sr As New StreamReader(cs)
                            Return sr.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        Catch
            Try
                Return Encoding.UTF8.GetString(Convert.FromBase64String(encryptedText))
            Catch
                Return ""
            End Try
        End Try
    End Function

End Class