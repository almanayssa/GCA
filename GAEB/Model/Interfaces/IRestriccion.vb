Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IRestriccion

#Region "Select"

        Function ListarRestricciones() As List(Of RestriccionBE)
        Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As List(Of RestriccionBE)
        Function ObtenerCantidadXRestriccion(ByVal id_actividad As Integer, ByVal id_restriccion As Integer, ByVal id_socio As String, ByVal id_persona As String, ByVal id_invitado As String) As String

#End Region

    End Interface

End Namespace

