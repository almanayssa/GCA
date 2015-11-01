Namespace SGS.Model.Entidades

    Public Class ActividadBE

        Private _id_actividad As Integer?
        Private _nombre As String
        Private _descripcion As String
        Private _fec_ini As Date?
        Private _fec_fin As Date?
        Private _hora_ini As TimeSpan?
        Private _hora_fin As TimeSpan?
        Private _monto_pago As Decimal?
        Private _id_estado As String
        Private _id_cattipo_act As Integer?
        Private _id_comite As String
        Private _id_tipo_act As String
        Private _id_actividad_recurrente As Integer?
        Private _flg_plan_anual As Boolean?
        Private _flg_registro As Boolean?
        Private _dias_registro As Integer?
        Private _flg_web As Boolean?
        Private _dias_web As Integer?
        Private _tipo_inscripcion As String
        Private _ActividadRecurrente As ActividadRecurrenteBE
        Private _ListaActividadDetalle As List(Of ActividadDetalleBE)
        Private _ListaTipoPersonal As List(Of TipoPersonalBE)
        Private _ListaRecursos As List(Of RecursoBE)
        Private _ListaRestricciones As List(Of RestriccionBE)
        Private _ListaPersonal As List(Of PersonalBE)

        Private _nombreComite As String
        Private _flg_recurrente As Boolean
        Private _tipo_act As String
        Private _cat_act As String
        Private _fec_registro As Date
        Private _fec_web As Date
        Private _ListaActividadDetalleBorrados As List(Of ActividadDetalleBE)

        Public Property id_actividad() As Integer?
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer?)
                _id_actividad = value
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

        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Public Property fec_ini() As Date?
            Get
                Return _fec_ini
            End Get
            Set(ByVal value As Date?)
                _fec_ini = value
            End Set
        End Property

        Public Property fec_fin() As Date?
            Get
                Return _fec_fin
            End Get
            Set(ByVal value As Date?)
                _fec_fin = value
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

        Public Property monto_pago() As Decimal?
            Get
                Return _monto_pago
            End Get
            Set(ByVal value As Decimal?)
                _monto_pago = value
            End Set
        End Property

        Public Property id_estado() As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property

        Public Property id_cattipo_act() As Integer?
            Get
                Return _id_cattipo_act
            End Get
            Set(ByVal value As Integer?)
                _id_cattipo_act = value
            End Set
        End Property

        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
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

        Public Property id_actividad_recurrente() As Integer?
            Get
                Return _id_actividad_recurrente
            End Get
            Set(ByVal value As Integer?)
                _id_actividad_recurrente = value
            End Set
        End Property

        Public Property flg_plan_anual() As Boolean?
            Get
                Return _flg_plan_anual
            End Get
            Set(ByVal value As Boolean?)
                _flg_plan_anual = value
            End Set
        End Property

        Public Property flg_registro() As Boolean?
            Get
                Return _flg_registro
            End Get
            Set(ByVal value As Boolean?)
                _flg_registro = value
            End Set
        End Property

        Public Property dias_registro() As Integer?
            Get
                Return _dias_registro
            End Get
            Set(ByVal value As Integer?)
                _dias_registro = value
            End Set
        End Property

        Public Property flg_web() As Boolean?
            Get
                Return _flg_web
            End Get
            Set(ByVal value As Boolean?)
                _flg_web = value
            End Set
        End Property

        Public Property dias_web() As Integer?
            Get
                Return _dias_web
            End Get
            Set(ByVal value As Integer?)
                _dias_web = value
            End Set
        End Property

        Public Property tipo_inscripcion() As String
            Get
                Return _tipo_inscripcion
            End Get
            Set(ByVal value As String)
                _tipo_inscripcion = value
            End Set
        End Property

        Public Property ActividadRecurrente() As ActividadRecurrenteBE
            Get
                Return _ActividadRecurrente
            End Get
            Set(ByVal value As ActividadRecurrenteBE)
                _ActividadRecurrente = value
            End Set
        End Property

        Public Property ListaActividadDetalle() As List(Of ActividadDetalleBE)
            Get
                Return _ListaActividadDetalle
            End Get
            Set(ByVal value As List(Of ActividadDetalleBE))
                _ListaActividadDetalle = value
            End Set
        End Property

        Public Property ListaTipoPersonal() As List(Of TipoPersonalBE)
            Get
                Return _ListaTipoPersonal
            End Get
            Set(ByVal value As List(Of TipoPersonalBE))
                _ListaTipoPersonal = value
            End Set
        End Property

        Public Property ListaRecursos() As List(Of RecursoBE)
            Get
                Return _ListaRecursos
            End Get
            Set(ByVal value As List(Of RecursoBE))
                _ListaRecursos = value
            End Set
        End Property

        Public Property ListaRestricciones() As List(Of RestriccionBE)
            Get
                Return _ListaRestricciones
            End Get
            Set(ByVal value As List(Of RestriccionBE))
                _ListaRestricciones = value
            End Set
        End Property

        Public Property ListaPersonal() As List(Of PersonalBE)
            Get
                Return _ListaPersonal
            End Get
            Set(ByVal value As List(Of PersonalBE))
                _ListaPersonal = value
            End Set
        End Property

        'Custom -> to populate datagridview
        Public Property QueryTipo As String
        Public Property QueryVacantes As String
        Public Property QueryNombreLugar As String
        Public Property QueryNombreSede As String
        Public Property QueryTipoActividad As String
        Public Property accion As Integer



        Public Property nombreComite() As String
            Get
                Return _nombreComite
            End Get
            Set(ByVal value As String)
                _nombreComite = value
            End Set
        End Property

        Public Property flg_recurrente() As Boolean
            Get
                Return _flg_recurrente
            End Get
            Set(ByVal value As Boolean)
                _flg_recurrente = value
            End Set
        End Property

        Public Property tipo_act() As String
            Get
                Return _tipo_act
            End Get
            Set(ByVal value As String)
                _tipo_act = value
            End Set
        End Property

        Public Property cat_act() As String
            Get
                Return _cat_act
            End Get
            Set(ByVal value As String)
                _cat_act = value
            End Set
        End Property

        Public Property fec_registro() As Date
            Get
                Return _fec_registro
            End Get
            Set(ByVal value As Date)
                _fec_registro = value
            End Set
        End Property

        Public Property fec_web() As Date
            Get
                Return _fec_web
            End Get
            Set(ByVal value As Date)
                _fec_web = value
            End Set
        End Property

        Public Property ListaActividadDetalleBorrados() As List(Of ActividadDetalleBE)
            Get
                Return _ListaActividadDetalleBorrados
            End Get
            Set(ByVal value As List(Of ActividadDetalleBE))
                _ListaActividadDetalleBorrados = value
            End Set
        End Property


        Private _des_sede As String
        Public Property des_sede() As String
            Get
                Return _des_sede
            End Get
            Set(ByVal value As String)
                _des_sede = value
            End Set
        End Property


        Private _nom_lug As String
        Public Property nom_lug() As String
            Get
                Return _nom_lug
            End Get
            Set(ByVal value As String)
                _nom_lug = value
            End Set
        End Property


        Private _direccion As String
        Public Property direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property


        Private _des_urbanizacion As String
        Public Property des_urbanizacion() As String
            Get
                Return _des_urbanizacion
            End Get
            Set(ByVal value As String)
                _des_urbanizacion = value
            End Set
        End Property


        Private _des_cal As String
        Public Property des_cal() As String
            Get
                Return _des_cal
            End Get
            Set(ByVal value As String)
                _des_cal = value
            End Set
        End Property


        Private _des_dis As String
        Public Property des_dis() As String
            Get
                Return _des_dis
            End Get
            Set(ByVal value As String)
                _des_dis = value
            End Set
        End Property


        Private _des_reg As String
        Public Property des_reg() As String
            Get
                Return _des_reg
            End Get
            Set(ByVal value As String)
                _des_reg = value
            End Set
        End Property

        Private _id_plan_anual As Integer
        Public Property id_plan_anual() As Integer
            Get
                Return _id_plan_anual
            End Get
            Set(ByVal value As Integer)
                _id_plan_anual = value
            End Set
        End Property

        Private _id_plan_anual_comite As Integer
        Public Property id_plan_anual_comite() As Integer
            Get
                Return _id_plan_anual_comite
            End Get
            Set(ByVal value As Integer)
                _id_plan_anual_comite = value
            End Set
        End Property


        Private _fec_lim_pres As Date
        Public Property fec_lim_pres() As Date
            Get
                Return _fec_lim_pres
            End Get
            Set(ByVal value As Date)
                _fec_lim_pres = value
            End Set
        End Property

    End Class

End Namespace

