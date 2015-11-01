Namespace SGS.Model.Entidades

    Public Class ComiteBE

        Private _id_comite As String
        Private _nombre As String
        Private _cta_contable As String

        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
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

        Public Property cta_contable() As String
            Get
                Return _cta_contable
            End Get
            Set(ByVal value As String)
                _cta_contable = value
            End Set
        End Property

    End Class

End Namespace

