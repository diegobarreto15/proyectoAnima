Public Class formAltaUsuario
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim telUsuario As Integer
            telUsuario = tbxTelefono.Text

            Dim emailUsuario As String
            emailUsuario = tbxCorreo.Text

            Dim ciUsuario As Integer
            ciUsuario = tbxCi.Text

            Dim nombreUsuario As String
            nombreUsuario = tbxNombre.Text

            Dim apellidoUsuario As String
            apellidoUsuario = tbxApellido.Text

            Dim tipoUsuarioUsuario As Integer
            tipoUsuarioUsuario = cbxTipoUsuario.Items.ToString

            Dim usuarioNueva = New ClaseUsuario()
            usuarioNueva.Tel = telUsuario
            usuarioNueva.Email = emailUsuario
            usuarioNueva.Ci = ciUsuario
            usuarioNueva.Nombre = nombreUsuario
            usuarioNueva.Apellido = apellidoUsuario
            usuarioNueva.TipoUsuario = tipoUsuarioUsuario

            Dim newUsuarioNueva As New ClaseUsuario()
            newUsuarioNueva.Tel = telUsuario
            newUsuarioNueva.Email = emailUsuario
            newUsuarioNueva.Ci = ciUsuario
            newUsuarioNueva.Nombre = nombreUsuario
            newUsuarioNueva.Apellido = apellidoUsuario
            newUsuarioNueva.TipoUsuario = tipoUsuarioUsuario

            Dim logica As New LogicaUsuario()
            logica.altaUsuario(usuarioNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub cbxTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoUsuario.SelectedIndexChanged

    End Sub
End Class