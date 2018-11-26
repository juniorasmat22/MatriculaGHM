Imports CapaDatos
Imports CapaEntidad
Public Class MatriculaCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New MatriculaCN
    Public Shared ReadOnly Property instancia() As MatriculaCN
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarTodos() As List(Of DetalleMatricula)
        Return MatriculaDA.instancia.ListarMatricula
    End Function
    Public Function Registrar_Matricula(ByVal matricula As Matricula) As Boolean
        Return MatriculaDA.instancia.Registro_Matricula(matricula)
    End Function
End Class
