Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IRecurso

#Region "Select"

        Function ListarRecursos(ByVal descripcion As String) As List(Of RecursoBE)
        Function ListarRecursosXActividad(ByVal id_actividad As Integer) As List(Of RecursoBE)

#End Region

    End Interface

End Namespace

