Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CursoDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New CursoDA
    Public Shared ReadOnly Property instancia() As CursoDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarCursos() As List(Of Curso)
        Dim Coleccion As New List(Of Curso)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Cursos", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Curso(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function Registro_Curso(ByVal curso As Curso) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_IngresarCurso", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = curso.nombre
            da.SelectCommand.Parameters.Add("@horas", SqlDbType.Int).Value = curso.horas
            da.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = curso.descripcion
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
    Public Function Editar_Curso(ByVal curso As Curso) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Editar_Curso", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int).Value = curso.Codigo
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = curso.nombre
            da.SelectCommand.Parameters.Add("@horas", SqlDbType.Int).Value = curso.horas
            da.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = curso.descripcion
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

    Public Function Eliminar_Curso(ByVal codigo As Integer) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Eliminar_Curso", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo
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
