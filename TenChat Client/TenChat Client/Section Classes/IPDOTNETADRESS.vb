
Public Class IPDOTNETADRESS
    Private _hostname As String
    Private _port As Integer

    Public Sub New(Hostname As String, Port As Integer)
        _hostname = Hostname
        _port = Port
    End Sub

    Public ReadOnly Property Port
        Get
            Return _port
        End Get
    End Property

    Public ReadOnly Property HostIP
        Get
            Return _hostname
        End Get
    End Property
End Class
