Public Class PersistenciaPersona
    Sub New()
    End Sub

    Dim conexionPP = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(personaUser As persona)
        Try
            Dim classcnn = New Conexion
            conexionPP = classcnn.abrirConexion
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into personas(ci,nombre,direccion) values(@ci,@nombre,@direccion)"
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexionPP
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personaUser.nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 80).Value = personaUser.direccion

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            conexionPP.close
        End Try


    End Sub





End Class
