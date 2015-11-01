Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class RegistroInscripcionPresenter
        Public vRegistroInscripcion As IRegistroInscripcion
        Public ListadoPersona As List(Of PersonaBE)

        Public bc As BusinessController

        Public Sub New(ByVal vRegistroInscripcion As IRegistroInscripcion)
            Me.vRegistroInscripcion = vRegistroInscripcion

            bc = New BusinessController
        End Sub

        Public Sub CargarActividad(ByRef oActividad As ActividadBE)
            vRegistroInscripcion.CodigoActividad = String.Format("{0:000}", CInt(oActividad.Codigo))
            vRegistroInscripcion.DescripcionActividad = oActividad.Descripcion
            vRegistroInscripcion.CostoActividad = "0"
            vRegistroInscripcion.VacantesActividad = "-"
            vRegistroInscripcion.FechaActividad = oActividad.FechaInicio.ToString("dd/MM/yyyy")
            vRegistroInscripcion.HoraInicioActividad = oActividad.FechaInicio.ToString("HH:mm")
            vRegistroInscripcion.HoraFinActividad = oActividad.FechaFin.ToString("HH:mm")
        End Sub

        Public Sub CargarSocio(ByRef oAsociado As AsociadoBE)
            vRegistroInscripcion.NombreSocio = oAsociado.Persona.nombrecompleto
            vRegistroInscripcion.ClaveSocio = oAsociado.Id_Accion
            vRegistroInscripcion.CodigoSocio = oAsociado.Id_Socio
            vRegistroInscripcion.CondicionSocio = oAsociado.Condicion
            vRegistroInscripcion.TipoEntidadSocio = "Socio"
            vRegistroInscripcion.DireccionSocio = oAsociado.Persona.direccion
            vRegistroInscripcion.TelefonoSocio = String.Empty
        End Sub

        Public Sub AgregarInscrito(ByRef oPersonal As PersonaBE)
            If ListadoPersona Is Nothing Then
                ListadoPersona = New List(Of PersonaBE)
            End If
            ListadoPersona.Add(oPersonal)
            vRegistroInscripcion.oListadoPersona = ListadoPersona
        End Sub

        Public Sub GuardarInscripcion()

            If ValidarCamposRequeridos() <> String.Empty Then
                vRegistroInscripcion.MostrarMensaje(ValidarCamposRequeridos, "Información")
                Exit Sub
            End If

            Dim oInscripcion As New InscripcionBE
            oInscripcion.Id_actividad = vRegistroInscripcion.CodigoActividad
            oInscripcion.Id_Socio = vRegistroInscripcion.CodigoSocio
            oInscripcion.ListaPersona = vRegistroInscripcion.oListadoPersona

            oInscripcion = bc.InsertarInscripcion(oInscripcion)
            'vRegistroInscripcion.


            If oInscripcion.Codigo = Nothing Then
                vRegistroInscripcion.MostrarMensaje("Error al grabar", "Información")
            Else
                vRegistroInscripcion.MostrarMensaje("La inscripción se registró satisfactoriamente", "Información")
            End If
        End Sub

        Private Function ValidarCamposRequeridos() As String
            Dim msg As String = String.Empty

            If vRegistroInscripcion.CodigoActividad = String.Empty Then
                msg &= vbCrLf & "- Ingrese una actividad"
            End If

            If vRegistroInscripcion.CodigoSocio = String.Empty Then
                msg &= vbCrLf & "- Ingrese un asociado"
            End If

            If vRegistroInscripcion.oListadoPersona Is Nothing Then
                msg &= vbCrLf & "- Ingrese una persona a inscribir"
            End If

            Return msg
        End Function

        Public Sub LimpiarFormulario()
            vRegistroInscripcion.CodigoActividad = String.Empty
            vRegistroInscripcion.ClaveSocio = String.Empty
            vRegistroInscripcion.CodigoSocio = String.Empty
            vRegistroInscripcion.oListadoPersona = Nothing
        End Sub

    End Class

End Namespace

