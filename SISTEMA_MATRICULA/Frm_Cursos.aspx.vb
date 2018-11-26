Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_Cursos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function ListarCursos() As List(Of Curso)
        Dim Coleccion As New List(Of Curso)

        Try
            Coleccion = CursoCN.instancia.ListarTodos
        Catch ex As Exception
            Coleccion = Nothing
        End Try
        Return Coleccion
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function RegistrarCurso(ByVal nombre As String, ByVal horas As Integer, ByVal descripcion As String) As Boolean
        Dim objCurso As Curso = New Curso(nombre, horas, descripcion)

        Dim rpt As Boolean
        rpt = CursoCN.instancia.Registrar_Curso(objCurso)
        Return rpt
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function ActualizarCurso(ByVal codigo As Integer, ByVal nombre As String, ByVal horas As Integer, ByVal descripcion As String) As Boolean
        Dim correcto As Boolean = False
        Dim objCurso As Curso = New Curso(codigo, nombre, horas, descripcion)
        correcto = CursoCN.instancia.Editar_Curso(objCurso)
        Return correcto
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function EliminarCurso(ByVal codigo As Integer) As Boolean
        Dim correcto As Boolean = False
        correcto = CursoCN.instancia.Eliminar_Curso(codigo)
        Return correcto
    End Function
End Class