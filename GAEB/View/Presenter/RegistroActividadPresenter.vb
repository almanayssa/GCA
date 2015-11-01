Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class RegistroActividadPresenter

        Public vRegistroActividad As IRegistroActividad
        Public oActividad As ActividadBE
        Public bc As BusinessController
        Public ListadoComites As List(Of ComiteBE)
        Public ListadoTipoActividad As List(Of TipoActividadBE)
        Public ListadoResponsables As List(Of PersonaBE)
        Public ListadoTipoPersonal As List(Of TipoPersonalBE)
        Public ListadoRecursos As List(Of RecursoBE)
        Public ListadoRestricciones As List(Of RestriccionBE)
        Public CodigoEspacio As Integer

        Public Sub New(ByVal vRegistroActividad As IRegistroActividad)
            Me.vRegistroActividad = vRegistroActividad

            bc = New BusinessController
        End Sub

        Public Sub ListarComites()
            ListadoComites = bc.ListarComites()
            vRegistroActividad.oListadoComites = ListadoComites
        End Sub

        Public Sub ListarTipoActividad()
            ListadoTipoActividad = bc.ListarTipoActividad()
            vRegistroActividad.oListadoTipoActividad = ListadoTipoActividad
        End Sub

        Public Sub ListarResponsables()
            ListadoResponsables = bc.ListarResponsables()
            vRegistroActividad.oListadoResponsables = ListadoResponsables
        End Sub

        Public Sub CargarActividad(ByVal pCodigo As Integer)
            Dim oActividad As ActividadBE = bc.CargarActividadCabecera(pCodigo)
            vRegistroActividad.Codigo = oActividad.Codigo
            vRegistroActividad.Descripcion = oActividad.Descripcion
            CodigoEspacio = oActividad.CodigoEspacio
            vRegistroActividad.Espacio = oActividad.DescripcionEspacio
            vRegistroActividad.Fecha = oActividad.Fecha
            vRegistroActividad.HoraInicio = oActividad.HoraInicio
            vRegistroActividad.HoraFin = oActividad.HoraFin
            vRegistroActividad.Comite = oActividad.CodigoComite
            vRegistroActividad.Tipo = oActividad.CodigoTipo
            vRegistroActividad.Responsable = oActividad.CodigoResponsable

            ListarTipoPersonal()
            ListarRecursos()
            ListarRestricciones()
        End Sub

        Public Sub CargarEspacio(ByRef oEspacio As EspacioBE)
            CodigoEspacio = oEspacio.Codigo
            vRegistroActividad.Espacio = oEspacio.Descripcion
        End Sub

        Public Sub CargarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
            vRegistroActividad.NombreTipoPersonal = oTipoPersonal.Descripcion
        End Sub

        Public Sub CargarRecurso(ByRef oRecurso As RecursoBE)
            vRegistroActividad.NombreRecurso = oRecurso.Descripcion
        End Sub

        Private Function ValidarAgregarTipoPersonal() As String
            Dim msg As String = String.Empty

            If vRegistroActividad.NombreTipoPersonal = String.Empty Then
                msg &= vbCrLf & "- Seleccione un tipo de personal"
            End If

            If vRegistroActividad.CantidadTipoPersonal = String.Empty Then
                msg &= vbCrLf & "- Ingrese una cantidad para el tipo de personal"
            End If

            Return msg
        End Function

        Private Function ValidarAgregarRecurso() As String
            Dim msg As String = String.Empty

            If vRegistroActividad.NombreRecurso = String.Empty Then
                msg &= vbCrLf & "- Seleccione un recurso"
            End If

            If vRegistroActividad.CantidadRecurso = String.Empty Then
                msg &= vbCrLf & "- Ingrese una cantidad para el recurso"
            End If

            Return msg
        End Function

        Public Sub ListarTipoPersonal()
            ListadoTipoPersonal = bc.ListarTipoPersonalXActividad(CInt(vRegistroActividad.Codigo))
            vRegistroActividad.oListadoTipoPersonal = ListadoTipoPersonal
        End Sub

        Public Sub ListarRecursos()
            ListadoRecursos = bc.ListarRecursosXActividad(CInt(vRegistroActividad.Codigo))
            vRegistroActividad.oListadoRecursos = ListadoRecursos
        End Sub

        Public Sub ListarRestricciones()
            ListadoRestricciones = bc.ListarRestriccionesXActividad(CInt(vRegistroActividad.Codigo))
            vRegistroActividad.oListadoRestricciones = ListadoRestricciones
        End Sub

        Public Sub AgregarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
            If ValidarAgregarTipoPersonal() <> String.Empty Then
                vRegistroActividad.MostrarMensaje(ValidarAgregarTipoPersonal, "Información")
                Exit Sub
            End If

            If ListadoTipoPersonal Is Nothing Then
                ListadoTipoPersonal = New List(Of TipoPersonalBE)
            End If
            oTipoPersonal.Cantidad = vRegistroActividad.CantidadTipoPersonal
            ListadoTipoPersonal.Add(oTipoPersonal)
            vRegistroActividad.NombreTipoPersonal = String.Empty
            vRegistroActividad.CantidadTipoPersonal = String.Empty
            vRegistroActividad.oListadoTipoPersonal = ListadoTipoPersonal
        End Sub

        Public Sub AgregarRecurso(ByRef oRecurso As RecursoBE)
            If ValidarAgregarRecurso() <> String.Empty Then
                vRegistroActividad.MostrarMensaje(ValidarAgregarRecurso, "Información")
                Exit Sub
            End If

            If ListadoRecursos Is Nothing Then
                ListadoRecursos = New List(Of RecursoBE)
            End If
            oRecurso.Cantidad = vRegistroActividad.CantidadRecurso
            ListadoRecursos.Add(oRecurso)
            vRegistroActividad.NombreRecurso = String.Empty
            vRegistroActividad.CantidadRecurso = String.Empty
            vRegistroActividad.oListadoRecursos = ListadoRecursos
        End Sub

        Public Sub AgregarRestriccion(ByRef oRestriccion As RestriccionBE)
            If ListadoRestricciones Is Nothing Then
                ListadoRestricciones = New List(Of RestriccionBE)
            End If
            ListadoRestricciones.Add(oRestriccion)
            vRegistroActividad.oListadoRestricciones = ListadoRestricciones
        End Sub

        Public Sub QuitarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
            If ListadoTipoPersonal IsNot Nothing Then
                ListadoTipoPersonal.Remove(oTipoPersonal)
            End If
            vRegistroActividad.oListadoTipoPersonal = ListadoTipoPersonal
        End Sub

        Public Sub QuitarRecurso(ByRef oRecurso As RecursoBE)
            If ListadoRecursos IsNot Nothing Then
                ListadoRecursos.Remove(oRecurso)
            End If
            vRegistroActividad.oListadoRecursos = ListadoRecursos
        End Sub

        Public Sub QuitarRestriccion(ByRef oRestriccion As RestriccionBE)
            If ListadoRestricciones IsNot Nothing Then
                ListadoRestricciones.Remove(oRestriccion)
            End If
            vRegistroActividad.oListadoRestricciones = ListadoRestricciones
        End Sub

        Public Sub LimpiarFormulario()
            vRegistroActividad.Codigo = String.Empty
            vRegistroActividad.Descripcion = String.Empty
            vRegistroActividad.Espacio = String.Empty
            vRegistroActividad.Comite = 1
            vRegistroActividad.Tipo = 1
            vRegistroActividad.Responsable = "M0000001"
            vRegistroActividad.Fecha = Now
            vRegistroActividad.HoraInicio = String.Empty
            vRegistroActividad.HoraFin = String.Empty
            vRegistroActividad.oListadoTipoPersonal = Nothing
            vRegistroActividad.oListadoRecursos = Nothing
            vRegistroActividad.oListadoRestricciones = Nothing
        End Sub

        Private Function ValidarCamposRequeridos() As String
            Dim msg As String = String.Empty

            If vRegistroActividad.Descripcion = String.Empty Then
                msg &= vbCrLf & "- Ingrese una descripción"
            End If

            If vRegistroActividad.Espacio = String.Empty Then
                msg &= vbCrLf & "- Seleccione un espacio"
            End If

            If vRegistroActividad.Fecha = Nothing Then
                msg &= vbCrLf & "- Ingrese una fecha"
            End If

            If vRegistroActividad.HoraInicio = String.Empty Then
                msg &= vbCrLf & "- Ingrese una hora de inicio"
            End If

            If vRegistroActividad.HoraFin = String.Empty Then
                msg &= vbCrLf & "- Ingrese una hora de fin"
            End If

            If vRegistroActividad.Comite = Nothing Then
                msg &= vbCrLf & "- Seleccione un comité"
            End If

            If vRegistroActividad.Tipo = Nothing Then
                msg &= vbCrLf & "- Seleccione un tipo de actividad"
            End If

            If vRegistroActividad.Responsable = String.Empty Then
                msg &= vbCrLf & "- Seleccione un responsable"
            End If

            Return msg
        End Function

        Public Function GuardarActividad() As Boolean
            Dim flag As Boolean = True

            If ValidarCamposRequeridos() <> String.Empty Then
                vRegistroActividad.MostrarMensaje(ValidarCamposRequeridos, "Información")
                flag = False
                Return flag
                Exit Function
            End If

            Dim affectedRows As Integer = 0
            Dim oActividad As New ActividadBE
            oActividad.Descripcion = vRegistroActividad.Descripcion
            oActividad.CodigoEspacio = CodigoEspacio
            oActividad.CodigoComite = vRegistroActividad.Comite
            oActividad.CodigoTipo = vRegistroActividad.Tipo
            oActividad.CodigoResponsable = vRegistroActividad.Responsable
            oActividad.FechaInicio = vRegistroActividad.Fecha.Add(CDate(vRegistroActividad.HoraInicio).TimeOfDay)
            oActividad.FechaFin = vRegistroActividad.Fecha.Add(CDate(vRegistroActividad.HoraFin).TimeOfDay)
            oActividad.ListaTipoPersonal = vRegistroActividad.oListadoTipoPersonal
            oActividad.ListaRecursos = vRegistroActividad.oListadoRecursos
            oActividad.ListaRestricciones = vRegistroActividad.oListadoRestricciones

            If vRegistroActividad.Codigo = String.Empty Then
                oActividad.Estado = "R" 'Registrada
                affectedRows = bc.InsertarActividad(oActividad)
            Else
                oActividad.Codigo = vRegistroActividad.Codigo
                affectedRows = bc.ActualizarActividad(oActividad)
            End If

            If affectedRows = 0 Then
                vRegistroActividad.MostrarMensaje("Error al grabar", "Información")
                flag = False
            Else
                If vRegistroActividad.Codigo = String.Empty Then
                    vRegistroActividad.Codigo = affectedRows
                    vRegistroActividad.MostrarMensaje("La actividad se registró satisfactoriamente", "Información")
                Else
                    vRegistroActividad.MostrarMensaje("La actividad se actualizó satisfactoriamente", "Información")
                End If
            End If

            Return flag
        End Function

    End Class

End Namespace


