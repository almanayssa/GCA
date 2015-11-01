Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarRestriccionPresenter

        Public vBuscarRestriccion As IBuscarRestriccion
        Public bc As BusinessController
        Public ListadoRestricciones As List(Of RestriccionBE)

        Public Sub New(ByVal vBuscarRestriccion As IBuscarRestriccion)
            Me.vBuscarRestriccion = vBuscarRestriccion

            bc = New BusinessController
        End Sub

        Public Sub ListarRestricciones()
            ListadoRestricciones = bc.ListarRestricciones(vBuscarRestriccion.Descripcion)
            vBuscarRestriccion.oListadoRestricciones = ListadoRestricciones
        End Sub

    End Class

End Namespace

