Imports System.Data.SqlClient
Imports CapaEntidad
Public Class GradoDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New GradoDA
    Public Shared ReadOnly Property instancia() As GradoDA
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarSecciones() As List(Of Grado)
        Dim Coleccion As New List(Of Grado)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Secciones", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Grado(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function ListarTodos() As List(Of Grado)
        Dim Coleccion As New List(Of Grado)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Grado", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Grado(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function

    Public Function Registro_Grado(ByVal grado As Grado) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Ingresar_Grado", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@numero", SqlDbType.Int).Value = grado.Numero
            da.SelectCommand.Parameters.Add("@seccion", SqlDbType.VarChar, 1).Value = grado.seccion
            da.SelectCommand.Parameters.Add("@nivel", SqlDbType.VarChar, 50).Value = grado.nivel
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
    Public Function Editar_Grado(ByVal grado As Grado) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Editar_Grado", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codigo", SqlDbType.Int).Value = grado.Codigo
            da.SelectCommand.Parameters.Add("@numero", SqlDbType.Int).Value = grado.Numero
            da.SelectCommand.Parameters.Add("@seccion", SqlDbType.VarChar, 1).Value = grado.seccion
            da.SelectCommand.Parameters.Add("@nivel", SqlDbType.VarChar, 50).Value = grado.nivel
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
    Public Function Eliminar_Grado(ByVal codigo As Integer) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Eliminar_Grado", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 8).Value = codigo
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
