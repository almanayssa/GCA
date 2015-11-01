Namespace SGS.View.Interfaces

    Public Interface IBuscarPersonal

        Property Tipo As String
        WriteOnly Property oListadoTipos As List(Of SGS.Model.Entidades.TipoPersonalBE)
        WriteOnly Property oListadoPersonal As List(Of SGS.Model.Entidades.PersonalBE)

    End Interface

End Namespace

