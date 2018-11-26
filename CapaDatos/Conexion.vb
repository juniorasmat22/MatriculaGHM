Public Class Conexion
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New Conexion

    Public Shared ReadOnly Property Instancia As Conexion
        Get
            Return _instancia
        End Get
    End Property
    Public Function cadenaconexion() As String
        Return "Data Source=DESKTOP-KKF85CV\SQLEXPRESS;Initial Catalog=BD_Matricula;Integrated Security=True"
    End Function
End Class
