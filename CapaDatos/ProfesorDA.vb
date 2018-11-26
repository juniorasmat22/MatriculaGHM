Imports System.Data.SqlClient
Imports CapaEntidad
Public Class ProfesorDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New ProfesorDA
    Public Shared ReadOnly Property instancia() As ProfesorDA
        Get
            Return _instancia
        End Get
    End Property

    Public Function ListarTodos() As List(Of Profesor)
        Dim Coleccion As New List(Of Profesor)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Profesor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Profesor(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4), PaTable.Item(5)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function Registro_Profesor(ByVal profesor As Profesor) As Boolean
        Dim corecto As Boolean = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Ingresar_Profesor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = profesor.dni
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = profesor.nombre
            da.SelectCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = profesor.apellido
            da.SelectCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = profesor.direccion
            da.SelectCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = profesor.telefono
            da.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = profesor.correo
            da.SelectCommand.ExecuteNonQuery()
            corecto = True
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            corecto = False
            MsgBox(ex.Message)
        End Try
        Return corecto
    End Function
    Public Function Editar_Profesor(ByVal profesor As Profesor) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Editar_Profesor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = profesor.dni
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = profesor.nombre
            da.SelectCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = profesor.apellido
            da.SelectCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = profesor.direccion
            da.SelectCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = profesor.telefono
            da.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = profesor.correo
            da.SelectCommand.ExecuteNonQuery()
            correcto = True
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return correcto
    End Function
    Public Function Eliminar_Profesor(ByVal dni As String) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Eliminar_Profesor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = dni
            da.SelectCommand.ExecuteNonQuery()
            correcto = True
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return correcto
    End Function

    Public Function ListarNombre() As List(Of Profesor)
        Dim Coleccion As New List(Of Profesor)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Nombres", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Profesor(PaTable.Item(0), PaTable.Item(1)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
End Class
