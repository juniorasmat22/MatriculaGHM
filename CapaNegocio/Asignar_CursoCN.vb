Imports CapaDatos
Imports CapaEntidad
Public Class Asignar_CursoCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New Asignar_CursoCN
    Public Shared ReadOnly Property instancia() As Asignar_CursoCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function Registrar_Asignacion(ByVal asignacion As Asignar_Curso) As Boolean
        Return Asignar_CursoDA.instancia.Registro_Asignacion(asignacion)
    End Function
End Class
