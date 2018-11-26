Imports System.Data.SqlClient
Imports CapaEntidad
Public Class EmpleadoDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New EmpleadoDA
    Public Shared ReadOnly Property instancia() As EmpleadoDA
        Get
            Return _instancia
        End Get
    End Property
End Class
