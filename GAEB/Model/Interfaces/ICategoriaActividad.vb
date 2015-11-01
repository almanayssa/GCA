Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface ICategoriaActividad

#Region "Select"

        Function ListarCategoriaActividad(ByVal id_tipo_act As String) As List(Of CategoriaActividadBE)

#End Region

    End Interface

End Namespace

