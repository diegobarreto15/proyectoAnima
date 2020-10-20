Public Class LogicaUsuario
    Public Sub altaUsuario(usuarito As ClaseUsuario)
        Dim persistencia As New PersistenciaUsuario
        persistencia.altaUsuario(usuarito)
    End Sub

    Public Sub modificarUsuario(usuarito As ClaseUsuario)
        Dim persistencia As New PersistenciaUsuario
        persistencia.modificarUsuario(usuarito)
    End Sub


End Class
