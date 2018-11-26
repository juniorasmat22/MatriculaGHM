Imports System.Data.SqlClient
Imports CapaEntidad
Public Class Asignar_CursoDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New Asignar_CursoDA
    Public Shared ReadOnly Property instancia() As Asignar_CursoDA
        Get
            Return _instancia
        End Get
    End Property

    Public Function Registro_Asignacion(ByVal asignacion As Asignar_Curso) As Boolean
        Dim correcto As Boolean = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Ingresar_Asignacion", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codCurso", SqlDbType.Int).Value = asignacion.codCurso
            da.SelectCommand.Parameters.Add("@codProfesor", SqlDbType.VarChar, 8).Value = asignacion.dniProfesor
            da.SelectCommand.Parameters.Add("@codSeccion", SqlDbType.Int).Value = asignacion.codGrado

            da.SelectCommand.ExecuteNonQuery()
            correcto = True
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            correcto = False
            MsgBox(ex.Message)
        End Try
        Return correcto

    End Function
End Class
