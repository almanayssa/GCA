Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IActividadDetalle

#Region "Select"

        Function ListarDetallesXActividad(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)
        Function ListarDetallesXActividadInscribir(ByVal id_actividad As Integer) As List(Of ActividadDetalleBE)

#End Region

#Region "Insert"

        Function InsertarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer

#End Region

#Region "Update"

        Function ActualizarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer

#End Region

#Region "Delete"

        Function BorrarActividadDetalle(ByVal id_actividad_detalle As Integer) As Integer

#End Region

    End Interface

End Namespace

