Imports Npgsql
Public Class PersistenciaUsuario
    Dim Conexion As Npgsql.NpgsqlConnection

    Public Sub altaUsuario(usuarito As ClaseUsuario)
        Try
            Dim classcnn = New Conexion
            Conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = Conexion
            Dim cadenaComandos As String
            cadenaComandos = "insert into usuarios (tel, pass, email, ci, nombre, apellido,  tipoUsuario) values (@tel, @pass, @email, @ci, @nombre, @apellido,  @tipoUsuario);"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = usuarito.Email
            cmd.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Tel
            cmd.Parameters.Add("@pass", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = usuarito.Passwd
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = usuarito.Nombre
            cmd.Parameters.Add("@apellido", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = usuarito.Apellido
            cmd.Parameters.Add("@tipoUsuario", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = usuarito.TipoUsuario

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Close()
        End Try
    End Sub
End Class
