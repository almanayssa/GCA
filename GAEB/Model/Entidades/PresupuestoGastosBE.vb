Namespace SGS.Model.Entidades

    Public Class PresupuestoGastosBE

        Private _id_detalle As Integer?
        Private _id_presupuesto As Integer?
        Private _id_item As String
        Private _monto As Double?
        Private _monto_pres As Double?

        Public Property id_detalle() As Integer?
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer?)
                _id_detalle = value
            End Set
        End Property

        Public Property id_presupuesto() As Integer?
            Get
                Return _id_presupuesto
            End Get
            Set(ByVal value As Integer?)
                _id_presupuesto = value
            End Set
        End Property

        Public Property id_item() As String
            Get
                Return _id_item
            End Get
            Set(ByVal value As String)
                _id_item = value
            End Set
        End Property

        Public Property monto() As Double?
            Get
                Return _monto
            End Get
            Set(ByVal value As Double?)
                _monto = value
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

        Public Property recurso As String
    End Class

End Namespace

