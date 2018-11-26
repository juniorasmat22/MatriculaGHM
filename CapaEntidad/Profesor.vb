Public Class Profesor
    Private _dni As String
    Private _nombre As String
    Private _apellido As String
    Private _correo As String
    Private _direccion As String
    Private _telefono As String

    Public Sub New(dni As String, nombre As String)
        _dni = dni
        _nombre = nombre
    End Sub

    Public Sub New(dni As String, nombre As String, apellido As String, direccion As String, telefono As String, correo As String)
        _dni = dni
        _nombre = nombre
        _apellido = apellido
        _correo = correo
        _direccion = direccion
        _telefono = telefono
    End Sub
    Public Property dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
End Class
