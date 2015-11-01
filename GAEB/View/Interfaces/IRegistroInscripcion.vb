Imports SGS.Model.Entidades

Namespace SGS.View.Interfaces

    Public Interface IRegistroInscripcion

        Property CodigoActividad As String
        Property DescripcionActividad As String
        Property CostoActividad As String
        Property VacantesActividad As String
        Property FechaActividad As String
        Property HoraInicioActividad As String
        Property HoraFinActividad As String
        Property NombreSocio As String
        Property CodigoSocio As String
        Property ClaveSocio As String
        Property CondicionSocio As String
        Property TipoEntidadSocio As String
        Property DireccionSocio As String
        Property TelefonoSocio As String
        Property oListadoPersona As List(Of SGS.Model.Entidades.PersonaBE)

        Sub MostrarMensaje(ByVal mensaje As String, ByVal titulo As String)

    End Interface

End Namespace

