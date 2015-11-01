Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarActividadPresenter

        Public vBuscarActividad As IBuscarActividad
        Public bc As BusinessController
        Public ListadoComites As List(Of ComiteBE)
        Public ListadoActividades As List(Of ActividadBE)

        Public Sub New(ByVal vBuscarActividad As IBuscarActividad)
            Me.vBuscarActividad = vBuscarActividad

            bc = New BusinessController
        End Sub

        Public Sub ListarComites()
            ListadoComites = bc.ListarComites()
            vBuscarActividad.oListadoComites = ListadoComites
        End Sub

        Public Sub ListarActividades()
            ListadoActividades = bc.ListarActividades(vBuscarActividad.Comite, vBuscarActividad.Descripcion)
            vBuscarActividad.oListadoActividades = ListadoActividades
        End Sub

    End Class

End Namespace