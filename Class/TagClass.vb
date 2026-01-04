Imports System
Imports System.Text
	Public Class TagClass
		Public _Tag As Integer

		Public _Value As String

		Public Sub New(tag As Integer, value As String)
			Me._Tag = tag
			Me._Value = value
		End Sub

		Public Overrides Function ToString() As String
			Return Me.ToHex(Me._Tag) + Me.ToHex(Encoding.UTF8.GetBytes(Me._Value).Length) + Me.ToHex(Me._Value)
		End Function

		Protected Function ToHex(str As String) As String
			Return BitConverter.ToString(Encoding.UTF8.GetBytes(str)).Replace("-", "")
		End Function

		Protected Function ToHex(n As Integer) As String
			Return n.ToString("X2")
		End Function
	End Class
