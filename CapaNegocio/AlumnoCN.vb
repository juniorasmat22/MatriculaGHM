Imports CapaDatos
Imports CapaEntidad
Public Class AlumnoCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New AlumnoCN
    Public Shared ReadOnly Property instancia() As AlumnoCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Alumno)
        Return AlumnoDA.instancia.ListarTodos
    End Function
    Public Sub Registrar_alumno(ByVal alumno As Alumno)
        AlumnoDA.instancia.Registro_Alumno(alumno)
    End Sub
    Public Function Editar_Alumno(ByVal alumno As Alumno) As Boolean
        Return AlumnoDA.instancia.Editar_Alumno(alumno)
    End Function
    Public Function Eliminar_Alumno(ByVal dni As String) As Boolean
        Return AlumnoDA.instancia.Eliminar_Alumno(dni)
    End Function

    Public Function Buscar_Alumno(ByVal dni As String) As Alumno
        Try
            Return AlumnoDA.instancia.Buscar_Alumno(dni)
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
End Class
