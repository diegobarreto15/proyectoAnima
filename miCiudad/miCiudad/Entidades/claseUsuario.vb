Public Class ClaseUsuario

    Private _tel As Integer
    Private _email As String
    Private _passwd As String
    Private _ci As Integer
    Private _nombre As String
    Private _apellido As String
    Private _tipoUsuario As String

    Public Property Tel As Integer
        Get
            Return _tel
        End Get
        Set(value As Integer)
            _tel = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Passwd As String
        Get
            Return _passwd
        End Get
        Set(value As String)
            _passwd = value
        End Set
    End Property

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property TipoUsuario As String
        Get
            Return _tipoUsuario
        End Get
        Set(value As String)
            _tipoUsuario = value
        End Set
    End Property

    Public Sub ClaseUsuario()

    End Sub

    Public Sub ClaseUsuario(tel_ As Integer, email_ As String, passwd_ As Integer, ci_ As Integer, nombre_ As String, apellido_ As String, tipoUsuario_ As String)
        Tel = tel_
        Email = email_
        Passwd = passwd_
        Ci = ci_
        Nombre = nombre_
        Apellido = apellido_
        TipoUsuario = tipoUsuario_
    End Sub
End Class