Public Class Matricula
    Private _Dni_Alumno As String
    Private _codGrado As Integer
    Private _hora As String
    Private _fecha As String
    Private _Dni_Empleado As String

    Public Sub New()
    End Sub

    Public Sub New(Dni_Alumno As String, codGrado As Integer, hora As String, fecha As String, Dni_Empleado As String)
        _Dni_Alumno = Dni_Alumno
        _codGrado = codGrado
        _hora = hora
        _fecha = fecha
        _Dni_Empleado = Dni_Empleado
    End Sub

    Public Property Dni_Alumno As String
        Get
            Return _Dni_Alumno
        End Get
        Set(value As String)
            _Dni_Alumno = value
        End Set
    End Property

    Public Property CodGrado As Integer
        Get
            Return _codGrado
        End Get
        Set(value As Integer)
            _codGrado = value
        End Set
    End Property

    Public Property Hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            _hora = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Dni_Empleado As String
        Get
            Return _Dni_Empleado
        End Get
        Set(value As String)
            _Dni_Empleado = value
        End Set
    End Property
End Class
