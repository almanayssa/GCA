Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IPlanAnualComite

#Region "Select"

        Function ListarPlanesAnualComite(ByVal id_plan As Integer) As List(Of PlanAnualComiteBE)

        Function ObtenerPlanAnualComite(ByVal id_plan As Integer, ByVal id_comite As String) As PlanAnualComiteBE

#End Region

    End Interface

End Namespace

