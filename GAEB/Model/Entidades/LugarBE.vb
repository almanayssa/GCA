Namespace SGS.Model.Entidades

    Public Class LugarBE

        Private _id_lugar As Integer
        Private _nombre As String
        Private _id_distrito As String
        Private _id_region As String
        Private _id_urbanizacion As String
        Private _id_calle As String
        Private _direccion As String
        Private _id_tipo As Integer
        Private _id_estado_lugar As String

        Public Property id_lugar() As Integer
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer)
                _id_lugar = value
            End Set
        End Property

        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property id_distrito() As String
            Get
                Return _id_distrito
            End Get
            Set(ByVal value As String)
                _id_distrito = value
            End Set
        End Property

        Public Property id_region() As String
            Get
                Return _id_region
            End Get
            Set(ByVal value As String)
                _id_region = value
            End Set
        End Property

        Public Property id_urbanizacion() As String
            Get
                Return _id_urbanizacion
            End Get
            Set(ByVal value As String)
                _id_urbanizacion = value
            End Set
        End Property

        Public Property id_calle() As String
            Get
                Return _id_calle
            End Get
            Set(ByVal value As String)
                _id_calle = value
            End Set
        End Property

        Public Property direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property

        Public Property id_tipo() As Integer
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As Integer)
                _id_tipo = value
            End Set
        End Property

        Public Property id_estado_lugar() As String
            Get
                Return _id_estado_lugar
            End Get
            Set(ByVal value As String)
                _id_estado_lugar = value
            End Set
        End Property
    End Class

End Namespace

