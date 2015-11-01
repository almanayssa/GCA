Namespace SGS.Model.Entidades

    Public Class LugarResBE

        Private _id_res As Integer
        Private _fec_ini As Date?
        Private _fec_fin As Date?
        Private _id_estado_lugar As Integer
        Private _observacion As String
        Private _id_lugar As Integer

        Public Property id_res() As Integer
            Get
                Return _id_res
            End Get
            Set(ByVal value As Integer)
                _id_res = value
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

        Public Property id_estado_lugar() As Integer
            Get
                Return _id_estado_lugar
            End Get
            Set(ByVal value As Integer)
                _id_estado_lugar = value
            End Set
        End Property

        Public Property observacion() As String
            Get
                Return _observacion
            End Get
            Set(ByVal value As String)
                _observacion = value
            End Set
        End Property

        Public Property id_lugar() As Integer
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer)
                _id_lugar = value
            End Set
        End Property

    End Class

End Namespace

