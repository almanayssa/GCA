Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IActividadRecurrente

#Region "Select"

        Function ObtenerActividadRecurrente(ByVal id_actividad_recurrente As Integer) As ActividadRecurrenteBE

#End Region

#Region "Insert"

        Function InsertarActividadRecurrente(ByRef oActividadRecurrente As ActividadRecurrenteBE) As Integer

#End Region

#Region "Update"

        Function ActualizarActividadRecurrente(ByRef oActividadRecurrente As ActividadRecurrenteBE) As Integer

#End Region

#Region "Delete"

        Function BorrarActividadRecurrente(ByVal id_actividad_recurrente As Integer) As Integer

#End Region

    End Interface

End Namespace

