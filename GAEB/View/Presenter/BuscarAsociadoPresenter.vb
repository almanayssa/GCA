Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarAsociadoPresenter

        Public vBuscarAsociado As IBuscarAsociado
        Public bc As BusinessController
        Public ListadoAsociados As List(Of AsociadoBE)
        Public ListadoAsociadoDatos As List(Of AsociadoBE)

        Public Sub New(ByVal vBuscarAsociado As IBuscarAsociado)
            Me.vBuscarAsociado = vBuscarAsociado

            bc = New BusinessController
        End Sub

        Public Sub ListarSocios()
            ListadoAsociados = bc.ListarAsociados()
            vBuscarAsociado.oListadoAsociados = ListadoAsociados
        End Sub

        Public Sub ListarAsociadosDatos()
            ListadoAsociadoDatos = bc.ListarAsociadosDatos()
            vBuscarAsociado.oListadoAsociadoDatos = ListadoAsociadoDatos
        End Sub

    End Class

End Namespace