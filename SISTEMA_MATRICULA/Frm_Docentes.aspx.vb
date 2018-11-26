Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_Docentes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function ListarDocente() As List(Of Profesor)
        Dim Coleccion As New List(Of Profesor)

        Try
            Coleccion = ProfesorCN.instancia.ListarTodos
        Catch ex As Exception
            Coleccion = Nothing
        End Try
        Return Coleccion
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function RegistrarDocente(ByVal id As String, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Dim objProfesor As Profesor = New Profesor(id, nombre, apellido, direccion, telefono, correo)

        Dim rpt As Boolean
        rpt = ProfesorCN.instancia.Registrar_Profesor(objProfesor)
        Return rpt
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function ActualizarDocente(ByVal id As String, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Dim correcto As Boolean = False
        Dim objProfesor As Profesor = New Profesor(id, nombre, apellido, direccion, telefono, correo)

        correcto = ProfesorCN.instancia.Editar_Profesor(objProfesor)
        Return correcto
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function EliminarDocente(ByVal id As String) As Boolean
        Dim correcto As Boolean = False
        correcto = ProfesorCN.instancia.Eliminar_Profesor(id)
        Return correcto
    End Function
End Class