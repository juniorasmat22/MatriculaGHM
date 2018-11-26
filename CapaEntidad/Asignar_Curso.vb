Public Class Asignar_Curso
    Private _codCurso As Integer
    Private _dniProfesor As String
    Private _codGrado As Integer

    Public Sub New()
    End Sub

    Public Sub New(codCurso As Integer, dniProfesor As String, codGrado As Integer)
        _codCurso = codCurso
        _dniProfesor = dniProfesor
        _codGrado = codGrado
    End Sub

    Public Property codCurso As Integer
        Get
            Return _codCurso
        End Get
        Set(value As Integer)
            _codCurso = value
        End Set
    End Property
    Public Property dniProfesor As String
        Get
            Return _dniProfesor
        End Get
        Set(value As String)
            _dniProfesor = value
        End Set
    End Property
    Public Property codGrado As Integer
        Get
            Return _codGrado
        End Get
        Set(value As Integer)
            _codGrado = value
        End Set
    End Property
End Class
