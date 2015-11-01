Namespace SGS.Model.Entidades

    Public Class CategoriaActividadBE

        Private _id_cattipo_act As Integer
        Private _descripcion As String
        Private _id_tipo_act As String

        Public Property id_cattipo_act() As Integer
            Get
                Return _id_cattipo_act
            End Get
            Set(ByVal value As Integer)
                _id_cattipo_act = value
            End Set
        End Property

        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Public Property id_tipo_act() As String
            Get
                Return _id_tipo_act
            End Get
            Set(ByVal value As String)
                _id_tipo_act = value
            End Set
        End Property

    End Class

End Namespace

