Imports CapaEntidad
Imports CapaNegocio
Public Class Frm_AsignarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
        DropDownList1.DataSource = GradoCN.instancia.ListarSecciones
        DropDownList1.DataTextField = "seccion"
        DropDownList1.DataValueField = "numero"
        DropDownList1.DataBind()


        DropDownList2.DataSource = CursoCN.instancia.ListarTodos
        DropDownList2.DataTextField = "nombre"
        DropDownList2.DataValueField = "codigo"
        DropDownList2.DataBind()

        DropDownList3.DataSource = ProfesorCN.instancia.ListarNombres
        DropDownList3.DataTextField = "nombre"
        DropDownList3.DataValueField = "dni"
        DropDownList3.DataBind()

    End Sub
    <System.Web.Services.WebMethod()>
    Public Shared Function Asignar_Curso(ByVal codCurso As Integer, ByVal codProfesor As String, ByVal codGrado As Integer) As Boolean
        Dim objAsigancion As Asignar_Curso = New Asignar_Curso(codCurso, codProfesor, codGrado)
        Dim rpt As Boolean
        rpt = Asignar_CursoCN.instancia.Registrar_Asignacion(objAsigancion)
        Return rpt
    End Function
End Class