﻿Public Class formAltaUsuario

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        tbxTelefono.Text = ""
        tbxCorreo.Text = ""
        tbxCi.Text = ""
        tbxNombre.Text = ""
        tbxApellido.Text = ""
        tbxNombreUsuario.Text = ""
        tbxContrasenia.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbxVectorAltaUsuario.Click

    End Sub

    Private Sub tbxNombre_TextChanged(sender As Object, e As EventArgs) Handles tbxNombre.TextChanged

    End Sub
    'Me.tbxNombre Border.CornerRadius
End Class