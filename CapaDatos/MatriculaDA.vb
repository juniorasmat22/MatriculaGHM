Imports System.Data.SqlClient
Imports CapaEntidad
Public Class MatriculaDA
    Public Sub New()

    End Sub
    Public Shared ReadOnly _instancia As New MatriculaDA
    Public Shared ReadOnly Property instancia() As MatriculaDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarMatricula() As List(Of DetalleMatricula)
        Dim Coleccion As New List(Of DetalleMatricula)
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Listar_Matricula", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = da.SelectCommand.ExecuteReader

            While PaTable.Read
                Coleccion.Add(New DetalleMatricula(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4)))

            End While
            cnn.Close()
            cnn.Dispose()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Coleccion
    End Function
    Public Function Registro_Matricula(ByVal matricula As Matricula) As Boolean
        Dim correcto = False
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim da As New SqlDataAdapter("sp_Ingresar_Matricula", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@dniEstudiante", SqlDbType.VarChar, 8).Value = matricula.Dni_Alumno
            da.SelectCommand.Parameters.Add("@codGrado", SqlDbType.Int).Value = matricula.CodGrado
            da.SelectCommand.Parameters.Add("@hora", SqlDbType.VarChar, 30).Value = matricula.Hora
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.VarChar, 30).Value = matricula.Fecha
            da.SelectCommand.Parameters.Add("@empDni", SqlDbType.VarChar, 8).Value = matricula.Dni_Empleado
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
