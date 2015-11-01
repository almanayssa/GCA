Namespace SGS.View.Interfaces

    Public Interface IBuscarActividad

        Property Comite As String
        Property Descripcion As String
        WriteOnly Property oListadoComites As List(Of SGS.Model.Entidades.ComiteBE)
        WriteOnly Property oListadoActividades As List(Of SGS.Model.Entidades.ActividadBE)

    End Interface

End Namespace

