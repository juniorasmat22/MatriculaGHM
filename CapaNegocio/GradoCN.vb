Imports CapaDatos
Imports CapaEntidad
Public Class GradoCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New GradoCN
    Public Shared ReadOnly Property instancia() As GradoCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarSecciones() As List(Of Grado)
        Return GradoDA.instancia.ListarSecciones
    End Function
    Public Function ListarTodos() As List(Of Grado)
        Return GradoDA.instancia.ListarTodos
    End Function
    Public Function Registrar_Grado(ByVal grado As Grado) As Boolean
        Return GradoDA.instancia.Registro_Grado(grado)
    End Function
    Public Function Editar_Grado(ByVal grado As Grado) As Boolean
        Return GradoDA.instancia.Editar_Grado(grado)
    End Function
    Public Function Eliminar_Grado(ByVal codigo As String) As Boolean
        Return GradoDA.instancia.Eliminar_Grado(codigo)
    End Function
End Class
