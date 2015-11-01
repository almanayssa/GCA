Namespace SGS.Model.Entidades

    Public Class PresupuestoBE

        Private _id_presupuesto As Integer?
        Private _id_plananual_comite As Integer?
        Private _ingreso_act As Double?
        Private _ingreso_otros As Double?
        Private _gastos As Double?
        Private _monto_pres As Double?
        Private _ListaGastos As List(Of PresupuestoGastosBE)

        Public Property id_presupuesto() As Integer?
            Get
                Return _id_presupuesto
            End Get
            Set(ByVal value As Integer?)
                _id_presupuesto = value
            End Set
        End Property

        Public Property id_plananual_comite() As Integer?
            Get
                Return _id_plananual_comite
            End Get
            Set(ByVal value As Integer?)
                _id_plananual_comite = value
            End Set
        End Property

        Public Property ingreso_act() As Double
            Get
                Return _ingreso_act
            End Get
            Set(ByVal value As Double)
                _ingreso_act = value
            End Set
        End Property

        Public Property ingreso_otros() As Double?
            Get
                Return _ingreso_otros
            End Get
            Set(ByVal value As Double?)
                _ingreso_otros = value
            End Set
        End Property
        
        Public Property gastos() As Double?
            Get
                Return _gastos
            End Get
            Set(ByVal value As Double?)
                _gastos = value
            End Set
        End Property

        Public Property monto_pres() As Double?
            Get
                Return _monto_pres
            End Get
            Set(ByVal value As Double?)
                _monto_pres = value
            End Set
        End Property

        Public Property ListaGastos() As List(Of PresupuestoGastosBE)
            Get
                Return _ListaGastos
            End Get
            Set(ByVal value As List(Of PresupuestoGastosBE))
                _ListaGastos = value
            End Set
        End Property
    End Class

End Namespace

