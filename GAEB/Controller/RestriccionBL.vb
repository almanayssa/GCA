Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarRestricciones() As List(Of RestriccionBE)
            Try
                Dim iRestriccion As IRestriccion
                Dim oListadoRestricciones As List(Of RestriccionBE) = Nothing

                iRestriccion = New RestriccionDL
                oListadoRestricciones = iRestriccion.ListarRestricciones()

                Return oListadoRestricciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As List(Of RestriccionBE)
            Try
                Dim iRestriccion As IRestriccion
                Dim oListadoRestricciones As List(Of RestriccionBE) = Nothing

                iRestriccion = New RestriccionDL
                oListadoRestricciones = iRestriccion.ListarRestriccionesXActividad(id_actividad)

                Return oListadoRestricciones

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ObtenerCantidadXRestriccion(ByVal id_actividad As Integer, ByVal id_restriccion As Integer, ByVal id_socio As String, ByVal id_persona As String, ByVal id_invitado As String) As String
            Try
                Dim iRestriccion As IRestriccion
                Dim result As String

                iRestriccion = New RestriccionDL
                result = iRestriccion.ObtenerCantidadXRestriccion(id_actividad, id_restriccion, id_socio, id_persona, id_invitado)

                Return result

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

