Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
	Public Class GenerateQrCodeTLV
		Public Tags As List(Of TagClass)

		Public Sub New(sellerName As String, vATNumber As String, invoiceDateTime As String, invoiceTotal As String, vATTotal As String)
			Me.Tags = New List(Of TagClass)()
			Me.Tags.Add(New TagClass(1, sellerName))
			Me.Tags.Add(New TagClass(2, vATNumber))
			Me.Tags.Add(New TagClass(3, invoiceDateTime))
			Me.Tags.Add(New TagClass(4, invoiceTotal))
			Me.Tags.Add(New TagClass(5, vATTotal))
		End Sub

		Private Function ToTLV() As String
			Return Me.ToSingleStringWithEmptySeparator(Me.Tags.[Select](Function(x As TagClass) x.ToString()).ToList(), "")
		End Function

		Public Function GetImageBase64() As String
			Return Convert.ToBase64String(Me.HexStringToByteArray(Me.ToTLV()))
		End Function

		Public Function QRCodeBase64() As String
			Return Me.ToQRCode(Me.GetImageBase64(), 20)
		End Function

		Public Function GetQRCode() As Byte()
			Return Convert.FromBase64String(Me.ToQRCode(Me.GetImageBase64(), 20))
		End Function

		Private Function ToQRCode(value As String, Optional pixelsPerModule As Integer = 20) As String
			Return ""
		End Function

		Private Function ToArray(image As Bitmap) As Byte()
			Dim memoryStream As MemoryStream = New MemoryStream()
			Dim result As Byte()
			Try
				image.Save(memoryStream, ImageFormat.Png)
				result = memoryStream.ToArray()
			Finally
				Dim flag As Boolean = memoryStream IsNot Nothing
				If flag Then
					CType(memoryStream, IDisposable).Dispose()
				End If
			End Try
			Return result
		End Function

		Private Function ToSingleStringWithEmptySeparator(items As List(Of String), Optional separator As String = "") As String
			Return String.Join(separator, items.ToArray())
		End Function

		Private Function HexStringToByteArray(hex As String) As Byte()
			Dim length As Integer = hex.Length
			Dim array As Byte() = New Byte(CInt(Math.Round(CDbl(length) / 2.0 - 1.0)) + 1 - 1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = length - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit While
				End If
				array(CInt(Math.Round(CDbl(num3) / 2.0))) = Convert.ToByte(hex.Substring(num3, 2), 16)
				num3 += 2
			End While
			Return array
		End Function
	End Class
