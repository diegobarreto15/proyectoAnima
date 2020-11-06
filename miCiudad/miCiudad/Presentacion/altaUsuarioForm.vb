Public Class formAltaUsuario

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
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
            userName = lblNombreUsuario.Text

            Dim contrasenia As String
            contrasenia = tbxContrasenia.Text

            Dim usuarioNueva = New ClaseUsuario()
            Dim logica As New LogicaUsuario()

            If userName <> "" & telUsuario <> "" & emailUsuario <> "" & ciUsuario <> "" & nombreUsuario <> "" & apellidoUsuario <> "" & userName <> "" Then
                usuarioNueva.Tel = telUsuario
                usuarioNueva.Email = emailUsuario
                usuarioNueva.Ci = ciUsuario
                usuarioNueva.Nombre = nombreUsuario
                usuarioNueva.Apellido = apellidoUsuario
                usuarioNueva.UserName = userName
                usuarioNueva.Passwd = contrasenia

                logica.altaUsuario(usuarioNueva)

                'Else
                If telUsuario = "" Then

                End If
            End If



            '      Dim usuarioNueva = New ClaseUsuario()
            '       usuarioNueva.Tel = telUsuario
            '        usuarioNueva.Email = emailUsuario
            '         usuarioNueva.Ci = ciUsuario
            '          usuarioNueva.Nombre = nombreUsuario
            '           usuarioNueva.Apellido = apellidoUsuario
            '            usuarioNueva.UserName = userName
            '            usuarioNueva.Passwd = contrasenia

            'Dim logica As New LogicaUsuario()
            'logica.altaUsuario(usuarioNueva)

        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs)
        tbxTelefono.Text = ""
        tbxCorreo.Text = ""
        tbxCi.Text = ""
        tbxNombre.Text = ""
        tbxApellido.Text = ""
        lblNombreUsuario.Text = ""
        tbxContrasenia.Text = ""
    End Sub

    'End Sub
    'Me.tbxNombre Border.CornerRadius
End Class