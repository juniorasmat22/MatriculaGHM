Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_Grado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function ListarGrado() As List(Of Grado)
        Dim Coleccion As New List(Of Grado)

        Try
            Coleccion = GradoCN.instancia.ListarTodos
        Catch ex As Exception
            Coleccion = Nothing
        End Try
        Return Coleccion
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function RegistrarGrado(ByVal numero As String, ByVal seccion As String, ByVal nivel As String) As Boolean
        Dim objGrado As Grado = New Grado(CInt(numero), seccion, nivel)

        Dim rpt As Boolean
        rpt = GradoCN.instancia.Registrar_Grado(objGrado)


        Return rpt
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function ActualizarGrado(ByVal id As Integer, ByVal numero As String, ByVal seccion As String, ByVal nivel As String) As Boolean
        Dim correcto As Boolean = False
        Dim objGrado As Grado = New Grado()
        objGrado.Codigo = id
        objGrado.Numero = CInt(numero)
        objGrado.seccion = seccion
        objGrado.nivel = nivel

        correcto = GradoCN.instancia.Editar_Grado(objGrado)
        Return correcto
    End Function
    <System.Web.Services.WebMethod()>
    Public Shared Function EliminarGrado(ByVal id As String) As Boolean
        Dim correcto As Boolean = False
        correcto = GradoCN.instancia.Eliminar_Grado(id)
        Return correcto
    End Function
End Class