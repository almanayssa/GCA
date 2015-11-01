Namespace SGS.Model.Entidades

    Public Class ActividadRecurrenteBE

        Private _id_actividad_recurrente As Integer?
        Private _tipo As String
        Private _num_rep As Integer?
        Private _chk_dom As Boolean?
        Private _chk_lun As Boolean?
        Private _chk_mar As Boolean?
        Private _chk_mie As Boolean?
        Private _chk_jue As Boolean?
        Private _chk_vie As Boolean?
        Private _chk_sab As Boolean?
        Private _dia_mes As Integer?
        Private _ordinal As Integer?
        Private _dia_semana As Integer?
        Private _fecha_fin As Date?
        Private _id_sede As String
        Private _id_lugar As Integer?
        Private _vacantes As Integer?
        Private _hora_ini As TimeSpan?
        Private _hora_fin As TimeSpan?

        Private _id_tipo_lugar As Integer?

        Public Property id_actividad_recurrente() As Integer?
            Get
                Return _id_actividad_recurrente
            End Get
            Set(ByVal value As Integer?)
                _id_actividad_recurrente = value
            End Set
        End Property

        Public Property tipo() As String
            Get
                Return _tipo
            End Get
            Set(ByVal value As String)
                _tipo = value
            End Set
        End Property

        Public Property num_rep() As Integer?
            Get
                Return _num_rep
            End Get
            Set(ByVal value As Integer?)
                _num_rep = value
            End Set
        End Property

        Public Property chk_dom() As Boolean?
            Get
                Return _chk_dom
            End Get
            Set(ByVal value As Boolean?)
                _chk_dom = value
            End Set
        End Property

        Public Property chk_lun() As Boolean?
            Get
                Return _chk_lun
            End Get
            Set(ByVal value As Boolean?)
                _chk_lun = value
            End Set
        End Property

        Public Property chk_mar() As Boolean?
            Get
                Return _chk_mar
            End Get
            Set(ByVal value As Boolean?)
                _chk_mar = value
            End Set
        End Property

        Public Property chk_mie() As Boolean?
            Get
                Return _chk_mie
            End Get
            Set(ByVal value As Boolean?)
                _chk_mie = value
            End Set
        End Property

        Public Property chk_jue() As Boolean?
            Get
                Return _chk_jue
            End Get
            Set(ByVal value As Boolean?)
                _chk_jue = value
            End Set
        End Property

        Public Property chk_vie() As Boolean?
            Get
                Return _chk_vie
            End Get
            Set(ByVal value As Boolean?)
                _chk_vie = value
            End Set
        End Property

        Public Property chk_sab() As Boolean?
            Get
                Return _chk_sab
            End Get
            Set(ByVal value As Boolean?)
                _chk_sab = value
            End Set
        End Property

        Public Property dia_mes() As Integer?
            Get
                Return _dia_mes
            End Get
            Set(ByVal value As Integer?)
                _dia_mes = value
            End Set
        End Property

        Public Property ordinal() As Integer?
            Get
                Return _ordinal
            End Get
            Set(ByVal value As Integer?)
                _ordinal = value
            End Set
        End Property

        Public Property dia_semana() As Integer?
            Get
                Return _dia_semana
            End Get
            Set(ByVal value As Integer?)
                _dia_semana = value
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

        Public Property hora_ini() As TimeSpan?
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As TimeSpan?)
                _hora_ini = value
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

        Public Property id_tipo_lugar() As Integer?
            Get
                Return _id_tipo_lugar
            End Get
            Set(ByVal value As Integer?)
                _id_tipo_lugar = value
            End Set
        End Property
    End Class

End Namespace

