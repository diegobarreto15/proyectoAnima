Public Class claseUsuario

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
End Class