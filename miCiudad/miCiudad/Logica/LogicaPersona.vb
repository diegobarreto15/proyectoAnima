Public Class LogicaPersona

    Public Sub altaPersona(personaUser As persona)
        Dim persistencia As New PersistenciaPersona
        persistencia.altaPersona(personaUser)
    End Sub

End Class
