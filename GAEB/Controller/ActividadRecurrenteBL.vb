Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ObtenerActividadRecurrente(ByVal id_actividad_recurrente As Integer) As ActividadRecurrenteBE
            Try
                Dim iActividadRecurrente As IActividadRecurrente
                Dim oActividadRecurrente As ActividadRecurrenteBE = Nothing

                iActividadRecurrente = New ActividadRecurrenteDL
                oActividadRecurrente = iActividadRecurrente.ObtenerActividadRecurrente(id_actividad_recurrente)

                Return oActividadRecurrente

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace