Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarPersonalPresenter

        Public vBuscarPersonal As IBuscarPersonal
        Public bc As BusinessController
        Public ListadoTipos As List(Of TipoPersonalBE)
        Public ListadoPersonal As List(Of PersonalBE)

        Public Sub New(ByVal vBuscarPersonal As IBuscarPersonal)
            Me.vBuscarPersonal = vBuscarPersonal

            bc = New BusinessController
        End Sub

        Public Sub ListarTipoPersonal()
            ListadoTipos = bc.ListarTipoPersonal(String.Empty)
            vBuscarPersonal.oListadoTipos = ListadoTipos
        End Sub

        Public Sub ListarPersonal()
            ListadoPersonal = bc.ListarPersonal(vBuscarPersonal.Tipo)
            vBuscarPersonal.oListadoPersonal = ListadoPersonal
        End Sub

    End Class

End Namespace

