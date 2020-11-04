Public Class bajaUsuarioForm
    Private Sub EliminarUsuario(sender As Object, e As EventArgs) Handles btnAceptarBaja.Click
        'Dim eliminar As Integer
        Dim si As Byte
        si = MsgBox("¿Desea eliminar este usuario de la base de datos?", vbYesNo, "Eliminar Usuario")
        If si = 6 Then

            MsgBox("Eliminado")
            tbxCI.Clear()

        End If
    End Sub
    'Dim conexion As Npgsql.NpgsqlConnection

    'Function EliminarUsuario(ByVal persona, ByVal condicion)
    'conexion.Open()
    'Dim elimina As String = "DROP USUARIO FROM Miciudad WHERE cedula='" & tbxCI.Text And "'"
    'comando = New cmd.command(eliminar, conexion)
    'Dim i As Integer = comando.ExecuteNonQuery()
    'conexion.Close()
    'If (i > 0) Then
    'Return True
    'Else
    'Return False
    'End If

    'End Function

    Private Sub btnAceptarBaja_Click(sender As Object, e As EventArgs) Handles btnAceptarBaja.Click

    End Sub
End Class