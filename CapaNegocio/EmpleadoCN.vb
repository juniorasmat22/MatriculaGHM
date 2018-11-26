Imports CapaDatos
Imports CapaEntidad
Public Class EmpleadoCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New EmpleadoCN
    Public Shared ReadOnly Property instancia() As EmpleadoCN
        Get
            Return _instancia
        End Get
    End Property
End Class
