Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarTipoPersonalPresenter

        Public vBuscarTipoPersonal As IBuscarTipoPersonal
        Public bc As BusinessController
        Public ListadoTipoPersonal As List(Of TipoPersonalBE)

        Public Sub New(ByVal vBuscarTipoPersonal As IBuscarTipoPersonal)
            Me.vBuscarTipoPersonal = vBuscarTipoPersonal

            bc = New BusinessController
        End Sub

        Public Sub ListarTipoPersonal()
            ListadoTipoPersonal = bc.ListarTipoPersonal(vBuscarTipoPersonal.Descripcion)
            vBuscarTipoPersonal.oListadoTipoPersonal = ListadoTipoPersonal
        End Sub

    End Class

End Namespace

