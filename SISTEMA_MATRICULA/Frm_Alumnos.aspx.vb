Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_Alumnos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function ListarAlumnos() As List(Of Alumno)
        Dim Coleccion As New List(Of Alumno)

        Try
            Coleccion = AlumnoCN.instancia.ListarTodos
        Catch ex As Exception
            Coleccion = Nothing
        End Try
        Return Coleccion
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function ActualizarAlumnos(ByVal id As String, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal correo As String) As Boolean
        Dim correcto As Boolean = False
        Dim objAlumno As Alumno = New Alumno()
        objAlumno.dni = id
        objAlumno.nombre = nombre
        objAlumno.apellido = apellido
        objAlumno.direccion = direccion
        objAlumno.correo = correo
        correcto = AlumnoCN.instancia.Editar_Alumno(objAlumno)
        Return correcto
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function EliminarAlumnos(ByVal id As String) As Boolean
        Dim correcto As Boolean = False
        correcto = AlumnoCN.instancia.Eliminar_Alumno(id)
        Return correcto
    End Function

End Class