Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim nombre As String = txtNombre.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        Dim script As String = "
        Swal.fire({
            title: 'Éxito',
            text: 'Usuario registrado correctamente',
            icon: 'success'
        }).then(function() {
            window.location.href = 'Login.aspx';
        });
    "

        ClientScript.RegisterStartupScript(Me.GetType(), "alert", script, True)

    End Sub





End Class