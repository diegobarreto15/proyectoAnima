Public Class mainForm
    Private Sub AltaUserMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUserMenuItem.Click
        formAltaUsuario.ShowDialog()
    End Sub

    Private Sub AltaReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaReporteToolStripMenuItem.Click
        formAltaReporte.ShowDialog()
    End Sub
End Class
