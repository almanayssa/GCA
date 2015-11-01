Namespace SGS.Model.Entidades

    Public Class TipoLugarBE

        Private _id_tipo As Integer
        Private _desc_tipo As String
        Private _flg_anulado As Boolean

        Public Property id_tipo() As Integer
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As Integer)
                _id_tipo = value
            End Set
        End Property

        Public Property desc_tipo() As String
            Get
                Return _desc_tipo
            End Get
            Set(ByVal value As String)
                _desc_tipo = value
            End Set
        End Property

        Public Property flg_anulado() As Boolean
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As Boolean)
                _flg_anulado = value
            End Set
        End Property

    End Class

End Namespace

