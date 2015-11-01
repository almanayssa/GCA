Namespace SGS.Model.Entidades

    Public Class PlanAnualComiteBE

        Private _id_plananual_comite As Integer?
        Private _id_plan As Integer?
        Private _id_comite As String
        Private _fec_reg As Date?

        Public Property id_plananual_comite() As Integer?
            Get
                Return _id_plananual_comite
            End Get
            Set(ByVal value As Integer?)
                _id_plananual_comite = value
            End Set
        End Property

        Public Property id_plan() As Integer?
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer?)
                _id_plan = value
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

        Public Property fec_reg() As Date?
            Get
                Return _fec_reg
            End Get
            Set(ByVal value As Date?)
                _fec_reg = value
            End Set
        End Property

        Public Property comite As String
        Public Property nombre_plan As String
        Public Property id_presupuesto As Integer
    End Class

End Namespace

