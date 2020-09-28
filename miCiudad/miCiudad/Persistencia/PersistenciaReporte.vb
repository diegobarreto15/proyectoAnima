﻿Imports Npgsql

Public Class PersistenciaReporte
    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub altaReporte(reportesito As claseReporte)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String
            cadenaComandos = "insert into Reportes (description, direction, state, id, ci, image) values (@description, @direction, @state, DEFAULT, @ci, @image);"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@description", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = reportesito.Descripcion
            cmd.Parameters.Add("@direction", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Direccion
            cmd.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Estado
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = reportesito.Ci
            cmd.Parameters.Add("@Image", NpgsqlTypes.NpgsqlDbType.Bytea).Value = reportesito.Imagen


            cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
