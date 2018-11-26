Public Class DetalleMatricula
    Private _codigo As Integer
    Private _dni As String
    Private _nombre As String
    Private _grado As String
    Private _seccion As String

    Public Sub New()
    End Sub

    Public Sub New(codigo As Integer, dni As String, nombre As String, grado As String, seccion As String)
        _codigo = codigo
        _dni = dni
        _nombre = nombre
        _grado = grado
        _seccion = seccion
    End Sub

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Grado As String
        Get
            Return _grado
        End Get
        Set(value As String)
            _grado = value
        End Set
    End Property

    Public Property Seccion As String
        Get
            Return _seccion
        End Get
        Set(value As String)
            _seccion = value
        End Set
    End Property
End Class
