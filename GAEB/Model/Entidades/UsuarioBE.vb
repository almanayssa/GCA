Namespace SGS.Model.Entidades

    Public Class UsuarioBE

        Private _id_usuario As String
        Private _username As String
        Private _password As String

        Public Property id_usuario() As String
            Get
                Return _id_usuario
            End Get
            Set(ByVal value As String)
                _id_usuario = value
            End Set
        End Property

        Public Property username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property

        Public Property password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property

    End Class

End Namespace


