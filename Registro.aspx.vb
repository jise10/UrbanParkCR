Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombre As String = txtNombre.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        ' Aquí puedes agregar la lógica para guardar los datos en una base de datos o realizar otras acciones necesarias.
        ' Por ejemplo, podrías mostrar un mensaje de éxito después de registrar al usuario.
        lblMensaje.Text = "Usuario registrado exitosamente."
    End Sub

End Class