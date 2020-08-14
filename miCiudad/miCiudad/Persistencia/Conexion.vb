Public Class Conexion

    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion_pg As Npgsql.NpgsqlConnection

        Try
            conexion_pg = New Npgsql.NpgsqlConnection()
            Dim cadenaDeConexion As String
            cadenaDeConexion = "server = 127.0.0.1; port = 5432; username='postgre'; password = 'root'; database= 'miCiudad' "

            conexion_pg.ConnectionString = cadenaDeConexion
            conexion_pg.Open()

        Catch ex As Exception
            Throw ex
        End Try

        Return conexion_pg

    End Function








End Class
