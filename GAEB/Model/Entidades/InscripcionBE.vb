Namespace SGS.Model.Entidades

    Public Class InscripcionBE

        Private _id_inscripcion As Integer
        Private _id_socio As String
        Private _fecha_registro As Date
        Private _serie As String
        Private _correlativo As String
        Private _tipo_doc As String
        Private _flg_web As Boolean
        Private _flg_anulado As Boolean
        Private _fecha_anulacion As Date
        Private _monto As Decimal
        Private _id_actividad_detalle As Integer
        Private _id_actividad As Integer
        Private _id_actividad_recurrente As Integer
        Private _fecha_recurrente As Date
        Private _ListaPersona As List(Of SGS.Model.Entidades.PersonaBE)
        Private _ListaInvitado As List(Of SGS.Model.Entidades.InvitadoBE)


        Public Property id_inscripcion() As Integer
            Get
                Return _id_inscripcion
            End Get
            Set(ByVal value As Integer)
                _id_inscripcion = value
            End Set
        End Property

        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Public Property fecha_registro() As Date
            Get
                Return _fecha_registro
            End Get
            Set(ByVal value As Date)
                _fecha_registro = value
            End Set
        End Property

        Public Property serie() As String
            Get
                Return _serie
            End Get
            Set(ByVal value As String)
                _serie = value
            End Set
        End Property

        Public Property correlativo() As String
            Get
                Return _correlativo
            End Get
            Set(ByVal value As String)
                _correlativo = value
            End Set
        End Property

        Public Property tipo_doc() As String
            Get
                Return _tipo_doc
            End Get
            Set(ByVal value As String)
                _tipo_doc = value
            End Set
        End Property

        Public Property flg_web() As Boolean
            Get
                Return _flg_web
            End Get
            Set(ByVal value As Boolean)
                _flg_web = value
            End Set
        End Property

        Public Property flg_anulado() As Boolean
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As Boolean)
                _flg_anulado = value
            End Set
        End Property

        Public Property fecha_anulacion() As Date
            Get
                Return _fecha_anulacion
            End Get
            Set(ByVal value As Date)
                _fecha_anulacion = value
            End Set
        End Property

        Public Property monto() As Integer
            Get
                Return _monto
            End Get
            Set(ByVal value As Integer)
                _monto = value
            End Set
        End Property

        Public Property id_actividad_detalle() As Integer
            Get
                Return _id_actividad_detalle
            End Get
            Set(ByVal value As Integer)
                _id_actividad_detalle = value
            End Set
        End Property

        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
            End Set
        End Property

        Public Property id_actividad_recurrente() As Integer
            Get
                Return _id_actividad_recurrente
            End Get
            Set(ByVal value As Integer)
                _id_actividad_recurrente = value
            End Set
        End Property

        Public Property fecha_recurrente() As Date
            Get
                Return _fecha_recurrente
            End Get
            Set(ByVal value As Date)
                _fecha_recurrente = value
            End Set
        End Property

        Public Property ListaPersona() As List(Of SGS.Model.Entidades.PersonaBE)
            Get
                Return _ListaPersona
            End Get
            Set(ByVal value As List(Of SGS.Model.Entidades.PersonaBE))
                _ListaPersona = value
            End Set
        End Property

        Public Property ListaInvitado() As List(Of SGS.Model.Entidades.InvitadoBE)
            Get
                Return _ListaInvitado
            End Get
            Set(ByVal value As List(Of SGS.Model.Entidades.InvitadoBE))
                _ListaInvitado = value
            End Set
        End Property

    End Class

End Namespace

