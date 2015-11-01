Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IActividad

#Region "Select"

        Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        Function ListarActividadesAInscribir(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
        Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
        Function ListarActividadesPorComite_TipoActividad(ByVal comiteID As String, ByVal tipoActividadID As String) As List(Of ActividadBE)

        Function ListarActividadesNoRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        Function ListarActividadesRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
        Function ObtenerActividad(ByVal id_actividad As Integer) As ActividadBE

        Function ListarActividadesPlan(ByVal id_plananual_comite As Integer) As List(Of ActividadBE)
        Function ListarActividadesEstado(ByVal id_comite As String, ByVal nombre As String, ByVal estado As String) As List(Of ActividadBE)


#End Region

#Region "Insert"

        Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer
        Function InsertarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer
        Function InsertarTipoPersonalXActividad(ByRef oTipoPersonal As TipoPersonalBE) As Integer
        Function InsertarRecursoXActividad(ByRef oRecurso As RecursoBE) As Integer
        Function InsertarRestriccionXActividad(ByRef oRestriccion As RestriccionBE) As Integer
        Function InsertarPersonalXActividad(ByRef oPersonal As PersonalBE) As Integer

        Function InsertarPlanAnual(ByRef oActividad As ActividadBE) As Integer
        Function InsertarPlanAnualComite(ByRef oActividad As ActividadBE) As Integer
        Function InsertarPlanAnualComiteDetalle(ByRef oActividad As ActividadBE) As Integer

#End Region

#Region "Update"

        Function ActualizarActividad(ByRef oActividad As ActividadBE) As Integer

        Function AprobarActividad(ByRef oActividad As ActividadBE) As Integer

        Function HabilitarActividad(ByRef oActividad As ActividadBE) As Integer

        Function ActualizarRecursosXActividad(ByRef oRecurso As RecursoBE) As Integer
#End Region

#Region "Delete"

        Function BorrarActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarTipoPersonalXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRecursosXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarRestriccionesXActividad(ByVal id_actividad As Integer) As Integer
        Function BorrarActividadesPlanAnualComite(ByVal id_plan_anual_comite As Integer) As Integer

#End Region

    End Interface

End Namespace

