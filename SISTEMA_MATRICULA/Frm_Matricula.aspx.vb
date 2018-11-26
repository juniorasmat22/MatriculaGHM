Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_Matricula
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtEmpleado.Text = Session("Usuario")
        codEmpleado.Text = Session("dni")
        Label1.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        'DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Secciones.DataSource = GradoCN.instancia.ListarSecciones
        Secciones.DataTextField = "seccion"
        Secciones.DataValueField = "numero"
        Secciones.DataBind()


    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function ListarMatricula() As List(Of DetalleMatricula)
        Dim Coleccion As New List(Of DetalleMatricula)

        Try
            Coleccion = MatriculaCN.instancia.ListarTodos
        Catch ex As Exception
            Coleccion = Nothing
        End Try
        Return Coleccion
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function BuscarEstudiante(ByVal dni As String) As Alumno
        Return AlumnoCN.instancia.Buscar_Alumno(dni)
    End Function

    <System.Web.Services.WebMethod()>
    Public Shared Function RegistrarMatricula(ByVal dni As String, ByVal grado As Integer, ByVal hora As String, ByVal fecha As String, ByVal empleado As String) As Boolean
        Dim objMatricula = New Matricula(dni, grado, hora, fecha, empleado)
        Return MatriculaCN.instancia.Registrar_Matricula(objMatricula)
    End Function

End Class