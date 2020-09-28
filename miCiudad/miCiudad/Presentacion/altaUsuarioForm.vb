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

            Dim newUsuarioNueva As New ClaseUsuario()
            newUsuarioNueva.Tel = telUsuario
            newUsuarioNueva.Email = emailUsuario
            newUsuarioNueva.Ci = ciUsuario
            newUsuarioNueva.Nombre = nombreUsuario
            newUsuarioNueva.Apellido = apellidoUsuario
            newUsuarioNueva.Tipo = tipoUsuario
            newUsuarioNueva.UserName = userName
            'newUsuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaUsuario()
            logica.altaUsuario(usuarioNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub formAltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class