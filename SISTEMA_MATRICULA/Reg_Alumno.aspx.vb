
Imports CapaEntidad
Imports CapaNegocio
Public Class Reg_Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") = "" Then
            Response.Redirect("login.aspx")
        End If
    End Sub
    Public Function obtenerAlumno() As Alumno
        Dim objAlumno As Alumno = New Alumno()
        objAlumno.dni = txtDni.Text
        objAlumno.nombre = txtNombre.Text
        objAlumno.apellido = txtApellidos.Text
        objAlumno.direccion = txtDireccion.Text
        objAlumno.correo = txtCorreo.Text
        objAlumno.sexo = If(dlSexo.SelectedValue = "1", "Masculino", "Femenino")
        objAlumno.nacimiento = Convert.ToDateTime(txtFecha.Text)
        Return objAlumno
    End Function

    Protected Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        Dim Obj_Alumno As Alumno = obtenerAlumno()
        'enviar a la capa negocio
        AlumnoCN.instancia.Registrar_alumno(Obj_Alumno)

        Response.Redirect("Frm_Alumnos.aspx")
    End Sub
End Class