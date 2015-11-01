Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarEspacioPresenter

        Public vBuscarEspacio As IBuscarEspacio
        Public bc As BusinessController
        Public ListadoEspacios As List(Of EspacioBE)

        Public Sub New(ByVal vBuscarEspacio As IBuscarEspacio)
            Me.vBuscarEspacio = vBuscarEspacio

            bc = New BusinessController
        End Sub

        Public Sub ListarEspacios()
            ListadoEspacios = bc.ListarEspacios(vBuscarEspacio.Descripcion)
            vBuscarEspacio.oListadoEspacios = ListadoEspacios
        End Sub

    End Class

End Namespace

