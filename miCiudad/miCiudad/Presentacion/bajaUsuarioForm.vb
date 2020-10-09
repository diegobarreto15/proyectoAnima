Public Class bajaUsuarioForm
    Private Sub btnAceptarBaja_Click(sender As Object, e As EventArgs) Handles btnAceptarBaja.Click
        Dim eliminar As Integer
        Dim si As Byte
        si = MsgBox("¿Desea eliminar este usuario de la base de datos?", vbYesNo, "Eliminar Usuario")
        If si = 6 Then
            eliminar = "DELETE FROM Miciudad WHERE cedula='" & tbxCI.Text And "'"

        End If





    End Sub
End Class