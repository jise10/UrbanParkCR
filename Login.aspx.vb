Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        ' Aquí puedes agregar la lógica para verificar las credenciales del usuario.
        ' Por ejemplo, podrías consultar una base de datos para validar el email y la contraseña.
        ' Si las credenciales son correctas, podrías redirigir al usuario a otra página o mostrar un mensaje de éxito.
        lblMensaje.Text = "Inicio de sesión exitoso."
    End Sub

End Class