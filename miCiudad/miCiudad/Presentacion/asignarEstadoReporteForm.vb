<<<<<<< HEAD
﻿
=======
﻿Public Class asignarEstadoReporteForm


    Private Sub btnAceptarModReport_Click(sender As Object, e As EventArgs) Handles btnAceptarModReport.Click
        Try

            Dim estadoReporte As String
            estadoReporte = cbxEstado.SelectedItem.ToString()

            Dim id As String
            id = tbxId.Text

            Dim reporteNuevo As New claseReporte()
            reporteNuevo.Id = id
            reporteNuevo.Estado = estadoReporte

            Dim logica As New LogicaReporte()
            logica.asignarReporte(reporteNuevo)

        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

<<<<<<< HEAD
    Private Sub btnAceptarModReport_Click(sender As Object, e As EventArgs) Handles btnAceptarModReport.Click

    End Sub
=======

>>>>>>> 6a778b8edca208ee5e8811800a9fdb7ac348a3f1
End Class
>>>>>>> b49a60fd3bd708f55f651a2c50566688926bb851
