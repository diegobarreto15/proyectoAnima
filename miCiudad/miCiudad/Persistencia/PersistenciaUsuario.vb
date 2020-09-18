Imports Npgsql

Public Class PersistenciaUsuario
    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub altaUsuario(usuarito As ClaseUsuario)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = Conexion
            Dim cadenaComandos As String
            cadenaComandos = "insert into usuarios (tel, password, email, ci, name, surname, userType, userName) values (@tel, @password, @email, @ci, @name, @surname,  @userType, @userName);"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = usuarito.Email
            cmd.Parameters.Add("@tel", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Tel
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = usuarito.Passwd
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Ci
            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Nombre
            cmd.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Apellido
            cmd.Parameters.Add("@userType", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = usuarito.Tipo
            cmd.Parameters.Add("@userName", NpgsqlTypes.NpgsqlDbType.Varchar, 60).Value = usuarito.UserName

            cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Close()
        End Try
    End Sub
End Class
