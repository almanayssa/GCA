Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarDetallesXActividad(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)
            Try
                Dim iActividadDetalle As IActividadDetalle
                Dim oListadoDetalles As List(Of ActividadDetalleBE) = Nothing

                iActividadDetalle = New ActividadDetalleDL
                oListadoDetalles = iActividadDetalle.ListarDetallesXActividad(id_actividad)

                Return oListadoDetalles

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarDetallesXActividadInscribir(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)
            Try
                Dim iActividadDetalle As IActividadDetalle
                Dim oListadoDetalles As List(Of ActividadDetalleBE) = Nothing

                iActividadDetalle = New ActividadDetalleDL
                oListadoDetalles = iActividadDetalle.ListarDetallesXActividadInscribir(id_actividad)

                Return oListadoDetalles

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


