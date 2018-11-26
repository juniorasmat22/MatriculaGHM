Public Class Alumno
    Private _dni As String
    Private _nombre As String
    Private _apellido As String
    Private _correo As String
    Private _direccion As String
    Private _fecha_nacimiento As Date
    Private _sexo As String

    Public Sub New()
    End Sub

    Public Sub New(dni As String, nombre As String, apellido As String, direccion As String, correo As String, fecha_nacimiento As Date, sexo As String)
        _dni = dni
        _nombre = nombre
        _apellido = apellido
        _correo = correo
        _direccion = direccion
        _fecha_nacimiento = fecha_nacimiento
        _sexo = sexo
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
    Public Property nacimiento As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As Date)
            _fecha_nacimiento = value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property
End Class
