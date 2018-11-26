Public Class Curso
    Private _codigo As Integer
    Private _nombre As String
    Private _horas As Integer
    Private _descripcion As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, horas As Integer, descripcion As String)
        _nombre = nombre
        _horas = horas
        _descripcion = descripcion
    End Sub

    Public Sub New(codigo As Integer, nombre As String, horas As Integer, descripcion As String)
        _codigo = codigo
        _nombre = nombre
        _horas = horas
        _descripcion = descripcion
    End Sub

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property horas As Integer
        Get
            Return _horas

        End Get
        Set(value As Integer)
            _horas = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return _descripcion

        End Get
        Set(value As String)
            _descripcion = value
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
