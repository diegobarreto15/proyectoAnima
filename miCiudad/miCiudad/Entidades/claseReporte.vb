Public Class claseReporte
    Private _descripcion As String
    Private _direccion As String
    Private _estado As String
    Private _ci As Integer
    Private _id As Integer
    'imagen BYTEA

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
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

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    'Public Property Nombre As String
    'Get
    'Return _nombre
    'End Get
    'Set(value As String)
    '       _nombre = value
    'End Set
    'End Property

End Class
