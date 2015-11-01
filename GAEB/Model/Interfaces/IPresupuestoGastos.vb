Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IPresupuestoGastos

#Region "Select"

        Function ListarPresupuestoGastos(ByVal id_plan As Integer, ByVal id_comite As String) As List(Of PresupuestoGastosBE)

#End Region

#Region "Insert"

        Function InsertarPresupuestoGastos(ByRef oPresupuestoGastos As PresupuestoGastosBE) As Integer

#End Region

    End Interface

End Namespace

