Public Class Usuario
    Dim _correo As String
    Dim _password As String

    Public Sub New(correo As String, password As String)
        _correo = correo
        _password = password
    End Sub
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property contraseña As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
