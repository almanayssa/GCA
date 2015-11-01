Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarPersonaInscribirPresenter

        Public vBuscarPersonaInscribir As IBuscarPersonaInscribir
        Public bc As BusinessController
        Public ListadoPersonasAInscribir As List(Of PersonaBE)

        Public Sub New(ByVal vBuscarPersonaInscribir As IBuscarPersonaInscribir)
            Me.vBuscarPersonaInscribir = vBuscarPersonaInscribir

            bc = New BusinessController
        End Sub

        Public Sub ListarPersonasAInscribir()
            ListadoPersonasAInscribir = bc.ListarPersonasFamilia(vBuscarPersonaInscribir.Clave, vBuscarPersonaInscribir.Nombre)
            vBuscarPersonaInscribir.oListadoPersonasAInscribir = ListadoPersonasAInscribir
        End Sub

    End Class

End Namespace