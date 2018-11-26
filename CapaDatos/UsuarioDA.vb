Imports System.Data.SqlClient
Imports CapaEntidad
Public Class UsuarioDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New UsuarioDA
    Public Shared ReadOnly Property instancia() As UsuarioDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function validarUsuario(ByVal correo As String, ByVal contra As String) As DataSet
        Dim ds As New DataSet 'creamos el dataset
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("Valida_Usuario", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = correo
            da.SelectCommand.Parameters.Add("@contra", SqlDbType.VarChar, 20).Value = contra
            da.Fill(ds, "Usuario")
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function


End Class
