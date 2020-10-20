Public Class modificarUserForm
    Private Sub btnAceptarMOD_Click(sender As Object, e As EventArgs) Handles btnAceptarMOD.Click
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

            Dim tipoUsuario As String
            tipoUsuario = cbxTipoUsuario.Items.ToString()

            Dim userName As String
            userName = tbxNombreUsuario.Text

            Dim contrasenia As String
            contrasenia = tbxContrasenia.Text

            Dim usuarioNueva = New ClaseUsuario()
            usuarioNueva.Tel = telUsuario
            usuarioNueva.Email = emailUsuario
            usuarioNueva.Ci = ciUsuario
            usuarioNueva.Nombre = nombreUsuario
            usuarioNueva.Apellido = apellidoUsuario
            usuarioNueva.Tipo = tipoUsuario
            usuarioNueva.UserName = userName
            usuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaUsuario()
            logica.modificarUsuario(usuarioNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub
End Class