Namespace SGS.Model.Entidades

    Public Class InscripcionDetalleBE

        Private _id_detalle As Integer
        Private _id_inscripcion As Integer
        Private _id_entidad As String
        Private _relacion As String
        Private _asistio As String

        Public Property id_detalle() As Integer
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer)
                _id_detalle = value
            End Set
        End Property

        Public Property id_inscripcion() As Integer
            Get
                Return _id_inscripcion
            End Get
            Set(ByVal value As Integer)
                _id_inscripcion = value
            End Set
        End Property

        Public Property id_entidad() As String
            Get
                Return _id_entidad
            End Get
            Set(ByVal value As String)
                _id_entidad = value
            End Set
        End Property

        Public Property relacion() As String
            Get
                Return _relacion
            End Get
            Set(ByVal value As String)
                _relacion = value
            End Set
        End Property

        Public Property asistio() As String
            Get
                Return _asistio
            End Get
            Set(ByVal value As String)
                _asistio = value
            End Set
        End Property

    End Class

End Namespace

