Imports System.Data.SqlClient
Imports CapaEntidad
Public Class AlumnoDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New AlumnoDA
    Public Shared ReadOnly Property instancia() As AlumnoDA
        Get

            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Alumno)
        Dim Coleccion As New List(Of Alumno)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Alumno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New Alumno(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4), PaTable.Item(5), PaTable.Item(6)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function

    Public Sub Registro_Alumno(ByVal alumno As Alumno)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_IngresarAlumno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = alumno.dni
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = alumno.nombre
            da.SelectCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = alumno.apellido
            da.SelectCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = alumno.direccion
            da.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = alumno.correo
            da.SelectCommand.Parameters.Add("@nacimiento", SqlDbType.Date).Value = alumno.nacimiento
            da.SelectCommand.Parameters.Add("@sexo", SqlDbType.VarChar, 50).Value = alumno.sexo
            da.SelectCommand.ExecuteNonQuery()

            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function Editar_Alumno(ByVal alumno As Alumno) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Editar_Alumno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = alumno.dni
            da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = alumno.nombre
            da.SelectCommand.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = alumno.apellido
            da.SelectCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = alumno.direccion
            da.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = alumno.correo
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
    Public Function Eliminar_Alumno(ByVal dni As String) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Eliminar_Alumno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = dni
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

    Public Function Buscar_Alumno(ByVal dni As String) As Alumno
        Dim objAlumno As Alumno = Nothing
        Try

            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Buscar_Alumno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = dni
            Dim dr As SqlDataReader
            dr = da.SelectCommand.ExecuteReader()
            While dr.Read()
                objAlumno = New Alumno(dr("ALU_Dni"), dr("Alu_Nombres"), dr("Alu_Apellidos"), dr("Alu_Direccion"), dr("Alu_Correo"), dr("Alu_Fecha_Nacimiento"), dr("Alu_Sexo"))
            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return objAlumno
    End Function
End Class
