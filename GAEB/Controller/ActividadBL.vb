Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ObtenerActividad(ByVal id_actividad As Integer) As ActividadBE
            Try
                Dim iActividad As IActividad
                Dim oActividad As ActividadBE = Nothing

                iActividad = New ActividadDL
                oActividad = iActividad.ObtenerActividad(id_actividad)

                Return oActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function CargarActividadCabecera(ByVal id_actividad As Integer) As ActividadBE
            Try
                Dim iActividad As IActividad
                Dim oActividad As ActividadBE = Nothing

                iActividad = New ActividadDL
                oActividad = iActividad.CargarActividadCabecera(id_actividad)

                Return oActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividades(id_comite, nombre)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesAInscribir(ByVal id_comite As String, ByVal nombre As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesAInscribir(id_comite, nombre)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        'RegistroPlanAnualActividad

        Public Function ListarActividadesPorComite_TipoActividad(ByVal comiteID As String, ByVal tipoActividadID As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesPorComite_TipoActividad(comiteID, tipoActividadID)


                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesNoRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesNoRecurrentes(diaCalendario, diaInicio, diaFin)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesRecurrentes(diaCalendario, diaInicio, diaFin)


                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesPlan(ByVal id_plananual_comite As Integer) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesPlan(id_plananual_comite)


                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarActividadesEstado(ByVal id_comite As String, ByVal nombre As String, ByVal estado As String) As List(Of ActividadBE)
            Try
                Dim iActividad As IActividad
                Dim oListadoActividades As List(Of ActividadBE) = Nothing

                iActividad = New ActividadDL
                oListadoActividades = iActividad.ListarActividadesEstado(id_comite, nombre, estado)

                Return oListadoActividades

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer
            Try
                Dim id_actividad_recurrente As Integer = 0

                If oActividad.ActividadRecurrente IsNot Nothing Then
                    Dim iActividadRecurrente As IActividadRecurrente
                    iActividadRecurrente = New ActividadRecurrenteDL

                    id_actividad_recurrente = iActividadRecurrente.InsertarActividadRecurrente(oActividad.ActividadRecurrente)
                End If

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim id_actividad As Integer

                If id_actividad_recurrente <> 0 Then
                    oActividad.id_actividad_recurrente = id_actividad_recurrente
                End If

                id_actividad = iActividad.InsertarActividad(oActividad)

                If oActividad.ListaActividadDetalle IsNot Nothing Then
                    For Each oActividadDetalle As ActividadDetalleBE In oActividad.ListaActividadDetalle
                        oActividadDetalle.id_actividad = id_actividad
                        iActividad.InsertarActividadDetalle(oActividadDetalle)
                    Next
                End If

                If oActividad.ListaTipoPersonal IsNot Nothing Then
                    For Each oTipoPersonal As TipoPersonalBE In oActividad.ListaTipoPersonal
                        oTipoPersonal.id_actividad = id_actividad
                        iActividad.InsertarTipoPersonalXActividad(oTipoPersonal)
                    Next
                End If

                If oActividad.ListaRecursos IsNot Nothing Then
                    For Each oRecurso As RecursoBE In oActividad.ListaRecursos
                        oRecurso.id_actividad = id_actividad
                        iActividad.InsertarRecursoXActividad(oRecurso)
                    Next
                End If

                If oActividad.ListaRestricciones IsNot Nothing Then
                    For Each oRestriccion As RestriccionBE In oActividad.ListaRestricciones
                        oRestriccion.id_actividad = id_actividad
                        iActividad.InsertarRestriccionXActividad(oRestriccion)
                    Next
                End If

                oActividad.id_actividad = id_actividad

                Return oActividad.id_actividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function InsertarActividad_Plan(ByRef oActividad As ActividadBE, ByRef ListaActividadesSelected As List(Of ActividadBE)) As Integer
            Try
                Dim iActividad As IActividad = New ActividadDL
                Dim idPlan As Integer = 0
                Dim idPlanComite As Integer = 0

                idPlan = iActividad.InsertarPlanAnual(oActividad)
                oActividad.id_plan_anual = idPlan

                idPlanComite = iActividad.InsertarPlanAnualComite(oActividad)

                For Each tempActividad As ActividadBE In ListaActividadesSelected
                    tempActividad.id_plan_anual_comite = idPlanComite
                    iActividad.InsertarPlanAnualComiteDetalle(tempActividad)
                Next

                Return idPlanComite

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ActualizarActividad_Plan(ByRef id_plananual_comite As Integer, ByRef ListaActividadesSelected As List(Of ActividadBE)) As Integer
            Try
                Dim iActividad As IActividad = New ActividadDL
                Dim affectedRows As Integer = 0

                iActividad.BorrarActividadesPlanAnualComite(id_plananual_comite)

                For Each tempActividad As ActividadBE In ListaActividadesSelected
                    tempActividad.id_plan_anual_comite = id_plananual_comite
                    affectedRows = iActividad.InsertarPlanAnualComiteDetalle(tempActividad)
                Next

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarActividad(ByRef oActividad As ActividadBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim iActividadRecurrente As IActividadRecurrente
                iActividadRecurrente = New ActividadRecurrenteDL

                Dim iActividadDetalle As IActividadDetalle
                iActividadDetalle = New ActividadDetalleDL

                If oActividad.flg_recurrente = False Then
                    If oActividad.ActividadRecurrente IsNot Nothing Then
                        oActividad.id_actividad_recurrente = Nothing
                        affectedRows += iActividad.ActualizarActividad(oActividad)
                        affectedRows += iActividadRecurrente.BorrarActividadRecurrente(oActividad.ActividadRecurrente.id_actividad_recurrente)
                    End If
                Else
                    If oActividad.ActividadRecurrente.id_actividad_recurrente Is Nothing Then
                        Dim id As Integer = iActividadRecurrente.InsertarActividadRecurrente(oActividad.ActividadRecurrente)
                        oActividad.id_actividad_recurrente = id
                    Else
                        affectedRows += iActividadRecurrente.ActualizarActividadRecurrente(oActividad.ActividadRecurrente)
                    End If

                    affectedRows += iActividad.ActualizarActividad(oActividad)
                End If

                affectedRows += iActividad.BorrarTipoPersonalXActividad(oActividad.id_actividad)
                affectedRows += iActividad.BorrarRecursosXActividad(oActividad.id_actividad)
                affectedRows += iActividad.BorrarRestriccionesXActividad(oActividad.id_actividad)

                If oActividad.ListaActividadDetalleBorrados IsNot Nothing Then
                    For Each oActividadDetalle As ActividadDetalleBE In oActividad.ListaActividadDetalleBorrados
                        affectedRows += iActividadDetalle.BorrarActividadDetalle(oActividadDetalle.id_actividad_detalle)
                    Next
                End If

                If oActividad.ListaActividadDetalle IsNot Nothing Then
                    For Each oActividadDetalle As ActividadDetalleBE In oActividad.ListaActividadDetalle
                        oActividadDetalle.id_actividad = oActividad.id_actividad
                        If oActividadDetalle.id_actividad_detalle Is Nothing Then
                            affectedRows += iActividadDetalle.InsertarActividadDetalle(oActividadDetalle)
                        Else
                            If oActividadDetalle.id_actividad_detalle > 0 Then
                                affectedRows += iActividadDetalle.ActualizarActividadDetalle(oActividadDetalle)
                            Else
                                affectedRows += iActividadDetalle.InsertarActividadDetalle(oActividadDetalle)
                            End If
                        End If
                    Next
                End If

                If oActividad.ListaTipoPersonal IsNot Nothing Then
                    For Each oTipoPersonal As TipoPersonalBE In oActividad.ListaTipoPersonal
                        oTipoPersonal.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarTipoPersonalXActividad(oTipoPersonal)
                    Next
                End If

                If oActividad.ListaRecursos IsNot Nothing Then
                    For Each oRecurso As RecursoBE In oActividad.ListaRecursos
                        oRecurso.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarRecursoXActividad(oRecurso)
                    Next
                End If

                If oActividad.ListaRestricciones IsNot Nothing Then
                    For Each oRestriccion As RestriccionBE In oActividad.ListaRestricciones
                        oRestriccion.id_actividad = oActividad.id_actividad
                        affectedRows += iActividad.InsertarRestriccionXActividad(oRestriccion)
                    Next
                End If

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function AprobarActividad(ByRef oListActividad As List(Of ActividadBE)) As Integer
            Try
                Dim affectedRows As Integer

                Dim iActividad As IActividad
                iActividad = New ActividadDL

                For Each oActividad As ActividadBE In oListActividad

                    affectedRows += iActividad.AprobarActividad(oActividad)

                Next

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function HabilitarActividad(ByRef oActividad As ActividadBE) As Integer
            Try
                Dim affectedRows As Integer

                Dim iActividad As IActividad
                iActividad = New ActividadDL


                If oActividad.ListaPersonal IsNot Nothing Then
                    For Each oPersonal As PersonalBE In oActividad.ListaPersonal
                        oPersonal.id_actividad = oActividad.id_actividad
                        iActividad.InsertarPersonalXActividad(oPersonal)
                    Next
                End If

                If oActividad.ListaRecursos IsNot Nothing Then
                    For Each oRecurso As RecursoBE In oActividad.ListaRecursos
                        oRecurso.id_actividad = oActividad.id_actividad
                        iActividad.ActualizarRecursosXActividad(oRecurso)
                    Next
                End If

                affectedRows = iActividad.HabilitarActividad(oActividad)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarActividad(ByRef id_actividad As Integer) As Integer
            Try
                Dim iActividad As IActividad
                iActividad = New ActividadDL

                Dim affectedRows As Integer
                affectedRows = iActividad.BorrarActividad(id_actividad)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
