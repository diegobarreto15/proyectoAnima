Imports System.IO

Public Class formAltaReporte
    'Dim listaImagenes As As New List(Of String)
    Dim foto As Image
    Dim fotoByte As Byte()

    Private Sub subirImagen_Click(sender As Object, e As EventArgs) Handles subirImagen.Click
        Try
            If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
                'Dim rutaImagen As String = OpenFileDialog1.FileName
                'foto = Image.FromFile(rutaImagen)
                'Else
                Dim rutaImagen As String = OpenFileDialog1.FileName
                foto = Image.FromFile(rutaImagen)
                Dim imageStream As System.IO.MemoryStream = New System.IO.MemoryStream
                foto.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                fotoByte = imageStream.GetBuffer()
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim ciReporte As Integer
            ciReporte = tbxCi.Text

            Dim direccionReporte As String
            direccionReporte = tbxDireccion.Text

            Dim estadoReporte As String
            estadoReporte = cbxEstado.SelectedItem.ToString

            Dim descripcionReporte As String
            descripcionReporte = tbxDescripcion.Text

            Dim reporteNuevo = New claseReporte()
            reporteNuevo.Ci = ciReporte
            reporteNuevo.Descripcion = descripcionReporte
            reporteNuevo.Direccion = direccionReporte
            reporteNuevo.Imagen = fotoByte
            reporteNuevo.Estado = estadoReporte

            Dim newUsuarioNueva As New claseReporte()
            newUsuarioNueva.Ci = ciReporte
            newUsuarioNueva.Descripcion = descripcionReporte
            newUsuarioNueva.Direccion = direccionReporte
            newUsuarioNueva.Imagen = fotoByte
            newUsuarioNueva.Estado = estadoReporte
            'newUsuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaReporte()
            logica.altaReporte(reporteNuevo)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub


End Class