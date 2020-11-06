Imports Npgsql

Public Class PersistenciaUsuario
    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub modificarUsuario(usuarito As ClaseUsuario)
        Try

            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String

            cadenaComandos = "UPDATE users SET tel=@tel, password=md5(@password), email=@email, name=@name, surname=@surname, userType=@userType, userName=@userType WHERE ci = @ci;"
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
            conexion.Close()
        End Try
    End Sub


    Public Sub altaUsuario(usuarito As ClaseUsuario)
        Try

            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String
            cadenaComandos = " insert into users (tel, password, email, ci, name, surname, userType, userName) values(@tel, md5(@password), @email, @ci, @name, @surname, @userType, @userName);"
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
            conexion.Close()
        End Try
    End Sub

    Public Function bajaUsuario(ci As Integer) As Boolean
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand


            cmd.Connection = conexion
            Dim cadenaComandos As String
            cadenaComandos = "DELETE FROM users WHERE ci = @ci"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery
            If resultado >= 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function


End Class
