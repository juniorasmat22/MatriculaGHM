Imports CapaNegocio
Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") <> "" Then
            Session.Remove("Usuario")
        End If
    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim fila As DataRow
        Dim dst As DataSet
        Dim correo As String
        Dim pass As String
        Dim nombre As String = ""
        Dim em As String = ""
        Dim dni As String = ""
        correo = email.Text
        pass = Password.Text
        dst = UsuarioCN.instancia.validarUsuario(correo, pass)
        If dst.Tables("Usuario").Rows.Count = 0 Then
            Response.Redirect("login.aspx")
        End If
        For Each fila In dst.Tables("Usuario").Rows
            nombre = fila("Nombre")
            em = fila("correo")
            dni = fila("dni")
        Next
        Session.Add("Usuario", nombre)
        Session.Add("dni", dni)
        Session.Add("Correo", em)
        Response.Redirect("index.aspx")
    End Sub
End Class