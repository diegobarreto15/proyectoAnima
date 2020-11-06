Public Class modificarUserForm
    Private Sub modificarUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            usuarioNueva.Email = emailUsuario
            usuarioNueva.Ci = ciUsuario
            usuarioNueva.Nombre = nombreUsuario
            usuarioNueva.Apellido = apellidoUsuario
            usuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaUsuario()
            logica.modificarUsuario(usuarioNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try

    End Sub
End Class