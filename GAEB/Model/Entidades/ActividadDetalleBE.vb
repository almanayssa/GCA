Namespace SGS.Model.Entidades

    Public Class ActividadDetalleBE

        Private _id_actividad_detalle As Integer?
        Private _fecha_ini As Date?
        Private _hora_ini As TimeSpan?
        Private _fecha_fin As Date?
        Private _hora_fin As TimeSpan?
        Private _id_sede As String
        Private _id_lugar As Integer?
        Private _vacantes As Integer?
        Private _id_actividad As Integer?

        Private _id_tipo_lugar As Integer?

        Public Property id_actividad_detalle() As Integer?
            Get
                Return _id_actividad_detalle
            End Get
            Set(ByVal value As Integer?)
                _id_actividad_detalle = value
            End Set
        End Property

        Public Property fecha_ini() As Date?
            Get
                Return _fecha_ini
            End Get
            Set(ByVal value As Date?)
                _fecha_ini = value
            End Set
        End Property

        Public Property hora_ini() As TimeSpan?
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As TimeSpan?)
                _hora_ini = value
            End Set
        End Property

        Public Property fecha_fin() As Date?
            Get
                Return _fecha_fin
            End Get
            Set(ByVal value As Date?)
                _fecha_fin = value
            End Set
        End Property

        Public Property hora_fin() As TimeSpan?
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As TimeSpan?)
                _hora_fin = value
            End Set
        End Property

        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
            End Set
        End Property

        Public Property id_lugar() As Integer?
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer?)
                _id_lugar = value
            End Set
        End Property

        Public Property vacantes() As Integer?
            Get
                Return _vacantes
            End Get
            Set(ByVal value As Integer?)
                _vacantes = value
            End Set
        End Property

        Public Property id_actividad() As Integer?
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer?)
                _id_actividad = value
            End Set
        End Property

        Public Property id_tipo_lugar() As Integer?
            Get
                Return _id_tipo_lugar
            End Get
            Set(ByVal value As Integer?)
                _id_tipo_lugar = value
            End Set
        End Property

        Public Property des_sede As String
        Public Property lugar As String
    End Class

End Namespace

