Public Class INIFile

    Public Sub New(inifile As String, b As Boolean)
        index = IO.File.ReadAllText(inifile)
    End Sub

    Public Sub New(initext As String)
        index = initext
    End Sub

    Public Property index As String

    Public Function GetFromIni(path As String) As String
        Dim txt As New TextBox
        txt.Text = index
        Dim tx As String = ""
        For Each line As String In txt.Lines
            If line.ToLower.StartsWith(path & "=") Then
                tx = line.Replace(path & "=", "")
            End If
        Next
        Return tx
    End Function

End Class
