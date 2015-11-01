Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPresupuestoGastos(ByVal id_plan As Integer, ByVal id_comite As String) As List(Of PresupuestoGastosBE)
            Try
                Dim iPresupuestoGastos As IPresupuestoGastos
                Dim oListadoPresupuestoGastos As List(Of PresupuestoGastosBE) = Nothing

                iPresupuestoGastos = New PresupuestoGastosDL
                oListadoPresupuestoGastos = iPresupuestoGastos.ListarPresupuestoGastos(id_plan, id_comite)

                Return oListadoPresupuestoGastos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

