
Namespace SGS.Model.Entidades

    Public Class ObjetoGeneralBE
        Private _id As String
        Private _desc As String
        Private _abr As String
        Private _val As String

        Public Property id As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property

        Public Property desc As String
            Get
                Return _desc
            End Get
            Set(ByVal value As String)
                _desc = value
            End Set
        End Property

        Public Property abr As String
            Get
                Return _abr
            End Get
            Set(ByVal value As String)
                _abr = value
            End Set
        End Property

        Public Property val As String
            Get
                Return _val
            End Get
            Set(ByVal value As String)
                _val = value
            End Set
        End Property

    End Class

End Namespace