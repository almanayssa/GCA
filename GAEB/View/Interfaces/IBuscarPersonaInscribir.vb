Namespace SGS.View.Interfaces

    Public Interface IBuscarPersonaInscribir

        Property Clave As String
        Property Nombre As String
        WriteOnly Property oListadoPersonasAInscribir As List(Of SGS.Model.Entidades.PersonaBE)

    End Interface

End Namespace

