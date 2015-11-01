Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPlanesAnualComite(ByVal id_plan As Integer) As List(Of PlanAnualComiteBE)
            Try
                Dim iPlanAnualComite As IPlanAnualComite
                Dim oListadoPlanAnualComite As List(Of PlanAnualComiteBE) = Nothing

                iPlanAnualComite = New PlanAnualComiteDL
                oListadoPlanAnualComite = iPlanAnualComite.ListarPlanesAnualComite(id_plan)

                Return oListadoPlanAnualComite

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerPlanAnualComite(ByVal id_plan As Integer, ByVal id_comite As String) As PlanAnualComiteBE
            Try
                Dim iPlanAnualComite As IPlanAnualComite
                Dim oPlanAnualComite As PlanAnualComiteBE = Nothing

                iPlanAnualComite = New PlanAnualComiteDL
                oPlanAnualComite = iPlanAnualComite.ObtenerPlanAnualComite(id_plan, id_comite)

                Return oPlanAnualComite

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

