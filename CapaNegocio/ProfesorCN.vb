Imports CapaDatos
Imports CapaEntidad
Public Class ProfesorCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New ProfesorCN
    Public Shared ReadOnly Property instancia() As ProfesorCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Profesor)
        Return ProfesorDA.instancia.ListarTodos
    End Function
    Public Function ListarNombres() As List(Of Profesor)
        Return ProfesorDA.instancia.ListarNombre
    End Function
    Public Function Registrar_Profesor(ByVal profesor As Profesor) As Boolean
        Return ProfesorDA.instancia.Registro_Profesor(profesor)
    End Function
    Public Function Editar_Profesor(ByVal profesor As Profesor) As Boolean
        Return ProfesorDA.instancia.Editar_Profesor(profesor)
    End Function
    Public Function Eliminar_Profesor(ByVal dni As String) As Boolean
        Return ProfesorDA.instancia.Eliminar_Profesor(dni)
    End Function
End Class
