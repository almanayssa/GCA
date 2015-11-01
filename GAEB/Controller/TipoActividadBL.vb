Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTipoActividad() As List(Of TipoActividadBE)
            Try
                Dim iTipoActividad As ITipoActividad
                Dim oListadoTipoActividad As List(Of TipoActividadBE) = Nothing

                iTipoActividad = New TipoActividadDL
                oListadoTipoActividad = iTipoActividad.ListarTipoActividad()

                Return oListadoTipoActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

