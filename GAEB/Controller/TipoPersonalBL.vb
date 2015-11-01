Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTipoPersonal(ByVal descripcion As String) As List(Of TipoPersonalBE)
            Try
                Dim iTipoPersonal As ITipoPersonal
                Dim oListadoTipos As List(Of TipoPersonalBE) = Nothing

                iTipoPersonal = New TipoPersonalDL
                oListadoTipos = iTipoPersonal.ListarTipoPersonal(descripcion)

                Return oListadoTipos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarTipoPersonalXActividad(ByVal id_actividad As Integer) As List(Of TipoPersonalBE)
            Try
                Dim iTipoPersonal As ITipoPersonal
                Dim oListadoTipoPersonal As List(Of TipoPersonalBE) = Nothing

                iTipoPersonal = New TipoPersonalDL
                oListadoTipoPersonal = iTipoPersonal.ListarTipoPersonalXActividad(id_actividad)

                Return oListadoTipoPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
