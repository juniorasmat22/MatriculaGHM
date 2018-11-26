Imports CapaDatos
Imports CapaEntidad
Public Class CursoCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New CursoCN
    Public Shared ReadOnly Property instancia() As CursoCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Curso)
        Return CursoDA.instancia.ListarCursos
    End Function
    Public Function Registrar_Curso(ByVal curso As Curso) As Boolean
        Return CursoDA.instancia.Registro_Curso(curso)
    End Function
    Public Function Editar_Curso(ByVal curso As Curso) As Boolean
        Return CursoDA.instancia.Editar_Curso(curso)
    End Function
    Public Function Eliminar_Curso(ByVal codigo As Integer) As Boolean
        Return CursoDA.instancia.Eliminar_Curso(codigo)
    End Function
End Class
