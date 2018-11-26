Public Class Empleado
    Dim _dni As String
    Dim _nombres As String
    Dim _apellidos As String
    Dim _direccion As String
    Dim _cargo As String

    Public Sub New(dni As String, nombres As String, apellidos As String, direccion As String, cargo As String)
        _dni = dni
        _nombres = nombres
        _apellidos = apellidos
        _direccion = direccion
        _cargo = cargo
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
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property
    Public Property apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
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
    Public Property cargo As String
        Get
            Return _cargo
        End Get
        Set(value As String)
            _cargo = value
        End Set
    End Property
End Class
