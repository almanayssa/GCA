Namespace SGS.Model.Entidades

    Public Class TipoActividadBE

        Private _id_tipo_act As String
        Private _desc_tipo As String

        Public Property id_tipo_act() As String
            Get
                Return _id_tipo_act
            End Get
            Set(ByVal value As String)
                _id_tipo_act = value
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

    End Class

End Namespace
