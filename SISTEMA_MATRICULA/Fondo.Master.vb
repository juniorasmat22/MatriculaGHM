Public Class Fondo
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") <> "" Then
            Nombre.Text = Session("Usuario")
            txtCorreo.Text = Session("Correo")
        End If
    End Sub

End Class