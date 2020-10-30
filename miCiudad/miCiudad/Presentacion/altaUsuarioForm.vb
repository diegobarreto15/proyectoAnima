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

            Dim userName As String
            userName = tbxNombreUsuario.Text

            Dim contrasenia As String
            contrasenia = tbxContrasenia.Text
            If userName <> Nothing & telUsuario <> Nothing & emailUsuario <> Nothing & ciUsuario <> Nothing & nombreUsuario <> Nothing & apellidoUsuario <> Nothing & userName <> Nothing Then
                Dim usuarioNueva = New ClaseUsuario()
                usuarioNueva.Tel = telUsuario
                usuarioNueva.Email = emailUsuario
                usuarioNueva.Ci = ciUsuario
                usuarioNueva.Nombre = nombreUsuario
                usuarioNueva.Apellido = apellidoUsuario
                usuarioNueva.UserName = userName
                usuarioNueva.Passwd = contrasenia

                Dim logica As New LogicaUsuario()
                logica.altaUsuario(usuarioNueva)

            Else
                If telUsuario = Nothing Then

                End If
            End If


<<<<<<< HEAD
=======
            Dim usuarioNueva = New ClaseUsuario()
            usuarioNueva.Tel = telUsuario
            usuarioNueva.Email = emailUsuario
            usuarioNueva.Ci = ciUsuario
            usuarioNueva.Nombre = nombreUsuario
            usuarioNueva.Apellido = apellidoUsuario
            usuarioNueva.Tipo = tipoUsuario
            usuarioNueva.UserName = userName
            usuarioNueva.Passwd = contrasenia

            'Dim newUsuarioNueva As New ClaseUsuario()
            'newUsuarioNueva.Tel = telUsuario
            'newUsuarioNueva.Email = emailUsuario
            'newUsuarioNueva.Ci = ciUsuario
            'newUsuarioNueva.Nombre = nombreUsuario
            'newUsuarioNueva.Apellido = apellidoUsuario
            'newUsuarioNueva.Tipo = tipoUsuario
            'newUsuarioNueva.UserName = userName
            'newUsuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaUsuario()
            logica.altaUsuario(usuarioNueva)
>>>>>>> b49a60fd3bd708f55f651a2c50566688926bb851
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        tbxTelefono.Text = ""
        tbxCorreo.Text = ""
        tbxCi.Text = ""
        tbxNombre.Text = ""
        tbxApellido.Text = ""
        tbxNombreUsuario.Text = ""
        tbxContrasenia.Text = ""
    End Sub
End Class
