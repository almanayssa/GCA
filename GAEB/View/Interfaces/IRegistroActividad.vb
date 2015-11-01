Imports SGS.Model.Entidades

Namespace SGS.View.Interfaces

    Public Interface IRegistroActividad

        Property Codigo As String
        Property Descripcion As String
        Property Espacio As String
        Property Fecha As Date
        Property HoraInicio As String
        Property HoraFin As String

        Property Comite As Integer
        Property Tipo As Integer
        Property Responsable As String

        Property NombreTipoPersonal As String
        Property CantidadTipoPersonal As String

        Property NombreRecurso As String
        Property CantidadRecurso As String

        WriteOnly Property oListadoComites As List(Of SGS.Model.Entidades.ComiteBE)
        WriteOnly Property oListadoTipoActividad As List(Of SGS.Model.Entidades.TipoActividadBE)
        WriteOnly Property oListadoResponsables As List(Of SGS.Model.Entidades.PersonaBE)

        Property oListadoTipoPersonal As List(Of SGS.Model.Entidades.TipoPersonalBE)
        Property oListadoRecursos As List(Of SGS.Model.Entidades.RecursoBE)
        Property oListadoRestricciones As List(Of SGS.Model.Entidades.RestriccionBE)

        Sub FormularioEnModoVista()
        Sub FormularioEnModoEdicion()
        Sub MostrarMensaje(ByVal mensaje As String, ByVal titulo As String)

    End Interface

End Namespace

