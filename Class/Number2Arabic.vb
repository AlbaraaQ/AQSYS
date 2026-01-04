Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
	Public Class Number2Arabic
		Public Sub New()
		End Sub

		Private Shared Function GetAla7ad(Num_Under2 As Long) As String
			If Num_Under2 <= 9L AndAlso Num_Under2 >= 1L Then
				Select Case CInt((Num_Under2 - 1L))
					Case 0
						Return "واحد"
					Case 1
						Return "أثنان "
					Case 2
						Return "ثلاثة"
					Case 3
						Return "أربعة"
					Case 4
						Return "خمسة"
					Case 5
						Return "ستة"
					Case 6
						Return "سبعة"
					Case 7
						Return "ثمانية"
					Case 8
						Return "تسعة"
				End Select
			End If
			Return "صفر"
		End Function

		Private Shared Function GetAl3asharat(Num2 As Integer) As String
			Dim result As String
			Select Case Num2
				Case 1
					result = "عشرة"
				Case 2
					result = "عشرون "
				Case 3
					result = "ثلاثون"
				Case 4
					result = "أربعون"
				Case 5
					result = "خمسون"
				Case 6
					result = "ستون"
				Case 7
					result = "سبعون"
				Case 8
					result = "ثمانون"
				Case 9
					result = "تسعون"
				Case Else
					result = "صفر"
			End Select
			Return result
		End Function

		Private Shared Function GetAlmeaat(Num3 As Integer) As String
			Dim result As String
			Select Case Num3
				Case 1
					result = "مائة"
				Case 2
					result = "مائتان "
				Case 3
					result = "ثلاثة مائة"
				Case 4
					result = "أربعة مائة"
				Case 5
					result = "خمسة مائة"
				Case 6
					result = "ستة مائة"
				Case 7
					result = "سبعة مائة"
				Case 8
					result = "ثمان مائة"
				Case 9
					result = "تسعة مائة"
				Case Else
					result = "صفر"
			End Select
			Return result
		End Function

		Private Shared Function GetAloloof(Num4 As Integer) As String
			Dim result As String
			Select Case Num4
				Case 1
					result = "ألف"
				Case 2
					result = "ألفان"
				Case 3
					result = "ثلاثةألاف"
				Case 4
					result = "أربعةألاف"
				Case 5
					result = "خمسةألاف"
				Case 6
					result = "ستةألاف"
				Case 7
					result = "سبعةألاف"
				Case 8
					result = "ثمانيةألاف"
				Case 9
					result = "تسعةألاف"
				Case Else
					result = "صفر"
			End Select
			Return result
		End Function

	Private Shared Function Get3Digits(Num0 As String) As String
		Dim text As String = ""
		Dim flag As Boolean = Operators.CompareString(Num0.ToString(), "", False) = 0
		If flag Then
			Num0 = "0"
		End If
		Dim num As Integer = Integer.Parse(Num0.ToString())
		flag = (num >= 0)
		If flag Then
			Dim num2 As Integer = num / 100
			Dim num3 As Integer = num Mod 100
			Dim num4 As Integer = num3 / 10
			Dim num5 As Integer = num3 Mod 10
			text = Number2Arabic.GetAla7ad(CLng(num5))
			Dim al3asharat As String = Number2Arabic.GetAl3asharat(num4)
			flag = (num4 <> 0)
			Dim flag2 As Boolean
			If flag Then
				flag2 = (num4 = 1 AndAlso num5 <> 0)
				If flag2 Then
					text += al3asharat
				Else
					flag2 = (num5 <> 0 AndAlso num4 <> 0)
					If flag2 Then
						text = text + " و " + al3asharat
					Else
						flag2 = (num4 <> 0)
						If flag2 Then
							text = al3asharat
						End If
					End If
				End If
			End If
			Dim almeaat As String = Number2Arabic.GetAlmeaat(num2)
			flag2 = (num2 > 0 AndAlso Operators.CompareString(text, "صفر", False) <> 0)
			If flag2 Then
				text = almeaat + " و " + text
			End If
			flag2 = (num2 <> 0 AndAlso num4 = 0 AndAlso num5 = 0)
			If flag2 Then
				text = almeaat
			End If
		End If
		Return text
	End Function

	Private Shared Function Get4Digits(Num0 As String) As String
		Dim text As String = ""
		Dim flag As Boolean = Operators.CompareString(Num0.ToString(), "", False) = 0
		If flag Then
			Num0 = "0"
		End If
		Dim num As Integer = Integer.Parse(Num0.ToString())
		flag = (num >= 0)
		If flag Then
			Dim num2 As Integer = num / 1000
			Dim num3 As Integer = num Mod 1000
			Dim num4 As Integer = num3 / 100
			Dim num5 As Integer = num Mod 100
			Dim num6 As Integer = num5 / 10
			Dim num7 As Integer = num5 Mod 10
			text = Number2Arabic.GetAla7ad(CLng(num7))
			Dim al3asharat As String = Number2Arabic.GetAl3asharat(num6)
			flag = (num6 <> 0)
			Dim flag2 As Boolean
			If flag Then
				flag2 = (num6 = 1 AndAlso num7 <> 0)
				If flag2 Then
					text += al3asharat
				Else
					flag2 = (num7 <> 0 AndAlso num6 <> 0)
					If flag2 Then
						text = text + " و " + al3asharat
					Else
						flag2 = (num6 <> 0)
						If flag2 Then
							text = al3asharat
						End If
					End If
				End If
			End If
			Dim almeaat As String = Number2Arabic.GetAlmeaat(num4)
			flag2 = (num4 > 0 AndAlso Operators.CompareString(text, "صفر", False) <> 0)
			If flag2 Then
				text = almeaat + " و " + text
			End If
			flag2 = (num4 <> 0 AndAlso num6 = 0 AndAlso num7 = 0)
			If flag2 Then
				text = almeaat
			End If
			flag2 = (num2 > 0)
			If flag2 Then
				Dim aloloof As String = Number2Arabic.GetAloloof(num2)
				flag2 = (Operators.CompareString(text, "صفر", False) <> 0)
				If flag2 Then
					text = aloloof + " و " + text
				Else
					text = aloloof
				End If
			End If
		End If
		Return text
	End Function

	Private Shared Sub Cal3Digits(strType As String, ByRef strNnumber As String, ByRef ReturnValue As String)
			Dim flag As Boolean = strNnumber.Length > 0
			If flag Then
				Dim flag2 As Boolean = strNnumber.Length < 3
				If flag2 Then
					strNnumber = "000" + strNnumber
					strNnumber = strNnumber.Substring(strNnumber.Length - 3, 3)
				End If
				Dim text As String = Number2Arabic.Get3Digits(strNnumber.Substring(strNnumber.Length - 3, 3))
				flag2 = (Operators.CompareString(text, "صفر", False) <> 0)
				If flag2 Then
					text += strType
				Else
					text = ""
				End If
				flag2 = (Operators.CompareString(ReturnValue, "صفر", False) <> 0)
				If flag2 Then
					flag = (Operators.CompareString(text, "", False) <> 0)
					If flag Then
						Dim flag3 As Boolean = Operators.CompareString(ReturnValue, "", False) <> 0
						If flag3 Then
							ReturnValue = text + " و " + ReturnValue
						Else
							ReturnValue = text
						End If
					End If
				Else
					ReturnValue = text
				End If
				strNnumber = strNnumber.Substring(0, strNnumber.Length - 3)
			End If
		End Sub

		Private Shared Function Convert(strNnumber As String) As String
			Dim strType As String = " ألف "
			Dim strType2 As String = " مليون "
			Dim strType3 As String = " مليار "
			Dim strType4 As String = " بليون "
			Dim strType5 As String = " ألف بليون "
			Dim strType6 As String = " مليون بليون "
			Dim strType7 As String = " مليار بليون "
			Dim strType8 As String = " بليون بليون "
			Dim result As String = ""
			Dim flag As Boolean = Operators.CompareString(strNnumber.ToString(), "", False) = 0
			If flag Then
				strNnumber = "0"
			End If
			flag = (strNnumber.Length < 3)
			If flag Then
				strNnumber = "000" + strNnumber
				strNnumber = strNnumber.Substring(strNnumber.Length - 3, 3)
			End If
			flag = (strNnumber.Length = 4)
			If flag Then
				result = Number2Arabic.Get4Digits(strNnumber)
			Else
				result = Number2Arabic.Get3Digits(strNnumber.Substring(strNnumber.Length - 3, 3))
				strNnumber = strNnumber.Substring(0, strNnumber.Length - 3)
				Number2Arabic.Cal3Digits(strType, strNnumber, result)
				Number2Arabic.Cal3Digits(strType2, strNnumber, result)
				Number2Arabic.Cal3Digits(strType3, strNnumber, result)
				Number2Arabic.Cal3Digits(strType4, strNnumber, result)
				Number2Arabic.Cal3Digits(strType5, strNnumber, result)
				Number2Arabic.Cal3Digits(strType6, strNnumber, result)
				Number2Arabic.Cal3Digits(strType7, strNnumber, result)
				Number2Arabic.Cal3Digits(strType8, strNnumber, result)
			End If
			Return result
		End Function

		Public Shared Function ameral(strNnumber As String) As String
			Dim text As String = ""
			Try
				Dim d As Double = Double.Parse(strNnumber)
				Dim num As Long = CLng(Math.Round(Math.Truncate(d)))
				Dim text2 As String = num.ToString()
				Dim num2 As Integer = strNnumber.Length - text2.Length
				Dim flag As Boolean = strNnumber.Length > text2.Length
				Dim num3 As Long
				If flag Then
					num3 = Long.Parse(strNnumber.Substring(strNnumber.Length - num2 + 1, num2 - 1))
				Else
					num3 = 0L
				End If
				flag = (num > 0L)
				If flag Then
					text = Number2Arabic.Convert(num.ToString())
				End If
				flag = (num3 <> 0L)
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(text, "", False) <> 0
					If flag2 Then
						text = String.Concat(New String() { text, " -  و ", Number2Arabic.Convert(num3.ToString()), " من ", Number2Arabic.Convert(CInt(Math.Round(Math.Truncate(Math.Pow(10.0, CDbl((num2 - 1)))))).ToString()) })
					Else
						text = Number2Arabic.Convert(num3.ToString()) + " من " + Number2Arabic.Convert(CInt(Math.Round(Math.Truncate(Math.Pow(10.0, CDbl((num2 - 1)))))).ToString())
					End If
				End If
			Catch ex As Exception
				strNnumber = "0"
				text = Number2Arabic.Convert(strNnumber)
			End Try
			Return text
		End Function

		Public Shared Function NoToTxt(TheNo As Double, MyCur As String, MySubCur As String) As String
			Dim array As String() = New String(9) {}
			Dim array2 As String() = New String(9) {}
			Dim array3 As String() = New String(9) {}
			Dim text As String = ""
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim text4 As String = ""
			Dim text5 As String = ""
			Dim text6 As String = ""
			Dim text7 As String = ""
			Dim flag As Boolean = TheNo > 999999999999.99
			Dim result As String
			If flag Then
				result = Conversions.ToString(0)
			Else
				flag = (TheNo < 0.0)
				Dim text8 As String
				If flag Then
					TheNo *= -1.0
					text8 = "يتبقى لكم "
				Else
					text8 = "فقط لا غير "
				End If
				flag = (TheNo = 0.0)
				If flag Then
					result = "صفر"
				Else
					Dim text9 As String = " و"
					array(0) = ""
					array(1) = "مائة"
					array(2) = "مائتان"
					array(3) = "ثلاثمائة"
					array(4) = "أربعمائة"
					array(5) = "خمسمائة"
					array(6) = "ستمائة"
					array(7) = "سبعمائة"
					array(8) = "ثمانمائة"
					array(9) = "تسعمائة"
					array2(0) = ""
					array2(1) = " عشر"
					array2(2) = "عشرون"
					array2(3) = "ثلاثون"
					array2(4) = "أربعون"
					array2(5) = "خمسون"
					array2(6) = "ستون"
					array2(7) = "سبعون"
					array2(8) = "ثمانون"
					array2(9) = "تسعون"
					array3(0) = ""
					array3(1) = "واحد"
					array3(2) = "اثنان"
					array3(3) = "ثلاثة"
					array3(4) = "أربعة"
					array3(5) = "خمسة"
					array3(6) = "ستة"
					array3(7) = "سبعة"
					array3(8) = "ثمانية"
					array3(9) = "تسعة"
					Dim str As String = Strings.Format(TheNo, "000000000000.00")
					Dim flag2 As Boolean
					For i As Integer = 0 To 15 - 1 Step 3
						flag = (i < 12)
						Dim str2 As String
						If flag Then
							str2 = Strings.Mid(str, i + 1, 3)
						Else
							str2 = "0" + Strings.Mid(str, i + 2, 2)
						End If
						flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) > 0.0)
						If flag Then
							Dim value As String = Strings.Mid(str2, 1, 1)
							Dim str3 As String = array(Conversions.ToInteger(value))
							value = Strings.Mid(str2, 3, 1)
							Dim text10 As String = array3(Conversions.ToInteger(value))
							value = Strings.Mid(str2, 2, 1)
							Dim str4 As String = array2(Conversions.ToInteger(value))
							flag = (Conversions.ToDouble(Strings.Mid(str2, 2, 2)) = 11.0)
							If flag Then
								text = "إحدى عشر"
							End If
							flag = (Conversions.ToDouble(Strings.Mid(str2, 2, 2)) = 12.0)
							If flag Then
								text2 = "إثنى عشر"
							End If
							flag = (Conversions.ToDouble(Strings.Mid(str2, 2, 2)) = 10.0)
							If flag Then
								str4 = "عشرة"
							End If
							flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 1)) > 0.0 And Conversions.ToDouble(Strings.Mid(str2, 2, 2)) > 0.0)
							If flag Then
								str3 += text9
							End If
							flag = (Conversions.ToDouble(Strings.Mid(str2, 3, 1)) > 0.0 And Conversions.ToDouble(Strings.Mid(str2, 2, 1)) > 1.0)
							If flag Then
								text10 += text9
							End If
							Dim text11 As String = str3 + text10 + str4
							flag = (Conversions.ToDouble(Strings.Mid(str2, 3, 1)) = 1.0 And Conversions.ToDouble(Strings.Mid(str2, 2, 1)) = 1.0)
							If flag Then
								text11 = str3 + text
								flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 1)) = 0.0)
								If flag Then
									text11 = text
								End If
							End If
							flag = (Conversions.ToDouble(Strings.Mid(str2, 3, 1)) = 2.0 And Conversions.ToDouble(Strings.Mid(str2, 2, 1)) = 1.0)
							If flag Then
								text11 = str3 + text2
								flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 1)) = 0.0)
								If flag Then
									text11 = text2
								End If
							End If
							flag = (i = 0 And Operators.CompareString(text11, "", False) <> 0)
							If flag Then
								flag2 = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) > 10.0)
								If flag2 Then
									text3 = text11 + " مليار"
								Else
									text3 = text11 + " مليارات"
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) = 2.0)
									If flag2 Then
										text3 = " مليار"
									End If
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) = 2.0)
									If flag2 Then
										text3 = " ملياران"
									End If
								End If
							End If
							flag2 = (i = 3 And Operators.CompareString(text11, "", False) <> 0)
							If flag2 Then
								flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) > 10.0)
								If flag Then
									text4 = text11 + " مليون"
								Else
									text4 = text11 + " ملايين"
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) = 1.0)
									If flag2 Then
										text4 = " مليون"
									End If
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) = 2.0)
									If flag2 Then
										text4 = " مليونان"
									End If
								End If
							End If
							flag2 = (i = 6 And Operators.CompareString(text11, "", False) <> 0)
							If flag2 Then
								flag = (Conversions.ToDouble(Strings.Mid(str2, 1, 3)) > 10.0)
								If flag Then
									text5 = text11 + " ألف"
								Else
									text5 = text11 + " آلاف"
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 3, 1)) = 1.0)
									If flag2 Then
										text5 = " ألف"
									End If
									flag2 = (Conversions.ToDouble(Strings.Mid(str2, 3, 1)) = 2.0)
									If flag2 Then
										text5 = " ألفان"
									End If
								End If
							End If
							flag2 = (i = 9 And Operators.CompareString(text11, "", False) <> 0)
							If flag2 Then
								text6 = text11
							End If
							flag2 = (i = 12 And Operators.CompareString(text11, "", False) <> 0)
							If flag2 Then
								text7 = text11
							End If
						End If
					Next
					flag2 = (Operators.CompareString(text3, "", False) <> 0)
					If flag2 Then
						flag = (Operators.CompareString(text4, "", False) <> 0 Or Operators.CompareString(text5, "", False) <> 0 Or Operators.CompareString(text6, "", False) <> 0)
						If flag Then
							text3 += text9
						End If
					End If
					flag2 = (Operators.CompareString(text4, "", False) <> 0)
					If flag2 Then
						flag = (Operators.CompareString(text5, "", False) <> 0 Or Operators.CompareString(text6, "", False) <> 0)
						If flag Then
							text4 += text9
						End If
					End If
					flag2 = (Operators.CompareString(text5, "", False) <> 0)
					If flag2 Then
						flag = (Operators.CompareString(text6, "", False) <> 0)
						If flag Then
							text5 += text9
						End If
					End If
					flag2 = (Operators.CompareString(text7, "", False) <> 0)
					If flag2 Then
						flag = (Operators.CompareString(text3, "", False) <> 0 Or Operators.CompareString(text4, "", False) <> 0 Or Operators.CompareString(text5, "", False) <> 0 Or Operators.CompareString(text6, "", False) <> 0)
						If flag Then
							result = String.Concat(New String() { text3, text4, text5, text6, " ", MyCur, text9, text7, " ", MySubCur, " ", text8 })
						Else
							result = String.Concat(New String() { text7, " ", MySubCur, " ", text8 })
						End If
					Else
						result = String.Concat(New String() { text3, text4, text5, text6, " ", MyCur, " ", text8 })
					End If
				End If
			End If
			Return result
		End Function
	End Class
