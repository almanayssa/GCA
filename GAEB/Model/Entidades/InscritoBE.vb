Namespace SGS.Model.Entidades

    Public Class InscritoBE

        Private _Codigo As Integer
        Private _Observacion As String
        Private _FlagNotificar As Boolean

        Public Property Codigo() As Integer
            Get
                Return _Codigo
            End Get
            Set(ByVal value As Integer)
                _Codigo = value
            End Set
        End Property

        Public Property Observacion() As String
            Get
                Return _Observacion
            End Get
            Set(ByVal value As String)
                _Observacion = value
            End Set
        End Property

        Public Property FlagNotificar() As Boolean
            Get
                Return _FlagNotificar
            End Get
            Set(ByVal value As Boolean)
                _FlagNotificar = value
            End Set
        End Property

    End Class

End Namespace

