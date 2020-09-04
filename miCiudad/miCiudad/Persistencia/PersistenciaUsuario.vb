Public Class PersistenciaUsuario
    Sub New()
    End Sub

    Dim conexionPU = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(personaUser As ClaseUsuario)
        Try
            Dim classcnn = New Conexion
            conexionPU = classcnn.abrirConexion
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into personas(ci,nombre,direccion) values(@ci,@nombre,@direccion)"
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexionPU
            cmd.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Tel
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Email
            cmd.Parameters.Add("@apellido", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Apellido
            cmd.Parameters.Add("@passwd", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Passwd
            cmd.Parameters.Add("@tipoUsuario", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.TipoUsuario
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personaUser.Nombre

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            conexionPU.close
        End Try
    End Sub
End Class
