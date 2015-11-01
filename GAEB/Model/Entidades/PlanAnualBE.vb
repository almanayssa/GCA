Namespace SGS.Model.Entidades

    Public Class PlanAnualBE

        Private _id_plan As Integer?
        Private _descripcion As String
        Private _fec_ini As Date?
        Private _fec_fin As Date?
        Private _fec_lim_pres As Date?
        Private _año As String
        
        Public Property id_plan() As Integer?
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer?)
                _id_plan = value
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

        Public Property fec_lim_pres() As Date
            Get
                Return _fec_lim_pres
            End Get
            Set(ByVal value As Date)
                _fec_lim_pres = value
            End Set
        End Property

        Public Property año() As String
            Get
                Return _año
            End Get
            Set(ByVal value As String)
                _año = value
            End Set
        End Property

    End Class

End Namespace

