Imports CapaDatos
Imports CapaEntidad
Public Class UsuarioCN
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New UsuarioCN
    Public Shared ReadOnly Property instancia() As UsuarioCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function validarUsuario(ByVal correo As String, ByVal contra As String) As DataSet
        Return UsuarioDA.instancia.validarUsuario(correo, contra)
    End Function
End Class
