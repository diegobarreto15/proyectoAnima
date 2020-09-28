Public Class LogicaReporte
    Public Sub altaReporte(reportesito As claseReporte)
        Dim persistencia As New PersistenciaReporte
        persistencia.altaReporte(reportesito)
    End Sub
End Class
