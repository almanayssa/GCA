Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPlanesAnual() As List(Of PlanAnualBE)
            Try
                Dim iPlanAnual As IPlanAnual
                Dim oListadoPlanAnual As List(Of PlanAnualBE) = Nothing

                iPlanAnual = New PlanAnualDL
                oListadoPlanAnual = iPlanAnual.ListarPlanesAnual()

                Return oListadoPlanAnual

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

