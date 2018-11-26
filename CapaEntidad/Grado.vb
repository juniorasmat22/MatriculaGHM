Public Class Grado
    Private _codigo As Integer
    Private _numero As Integer
    Private _seccion As String
    Private _nivel As String

    Public Sub New()
    End Sub
    Public Sub New(numero As Integer, seccion As String, nivel As String)
        _numero = numero
        _seccion = seccion
        _nivel = nivel
    End Sub
    Public Sub New(codigo As Integer, numero As Integer, seccion As String, nivel As String)
        _codigo = codigo
        _numero = numero
        _seccion = seccion
        _nivel = nivel
    End Sub

    Public Property seccion As String
        Get
            Return _seccion
        End Get
        Set(value As String)
            _seccion = value
        End Set
    End Property
    Public Property nivel As String
        Get
            Return _nivel
        End Get
        Set(value As String)
            _nivel = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property
End Class
