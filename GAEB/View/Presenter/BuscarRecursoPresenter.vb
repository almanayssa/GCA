Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class BuscarRecursoPresenter

        Public vBuscarRecurso As IBuscarRecurso
        Public bc As BusinessController
        Public ListadoRecursos As List(Of RecursoBE)

        Public Sub New(ByVal vBuscarRecurso As IBuscarRecurso)
            Me.vBuscarRecurso = vBuscarRecurso

            bc = New BusinessController
        End Sub

        Public Sub ListarRecursos()
            ListadoRecursos = bc.ListarRecursos(vBuscarRecurso.Descripcion)
            vBuscarRecurso.oListadoRecursos = ListadoRecursos
        End Sub

    End Class

End Namespace

