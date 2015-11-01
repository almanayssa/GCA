Namespace SGS.Model.Entidades

    Public Class SignoBE

        Private _id_signo As Integer
        Private _signo As String

        Public Property id_signo() As Integer
            Get
                Return _id_signo
            End Get
            Set(ByVal value As Integer)
                _id_signo = value
            End Set
        End Property

        Public Property signo() As String
            Get
                Return _signo
            End Get
            Set(ByVal value As String)
                _signo = value
            End Set
        End Property

    End Class

End Namespace
