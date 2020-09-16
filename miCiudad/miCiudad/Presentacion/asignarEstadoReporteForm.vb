Public Class asignarEstadoReporteForm
    Private Sub cbxEstadoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstadoReporte.SelectedIndexChanged
        cbxEstadoReporte.Items.Add("")
        cbxEstadoReporte.Items.Add("Pendiente")
        cbxEstadoReporte.Items.Add("En revision")
        cbxEstadoReporte.Items.Add("En proceso")
    End Sub
End Class