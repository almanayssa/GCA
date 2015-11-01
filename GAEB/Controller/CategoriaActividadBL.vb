Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarCategoriaActividad(ByVal id_tipo_act As String) As List(Of CategoriaActividadBE)
            Try
                Dim iCategoriaActividad As ICategoriaActividad
                Dim oListadoCategoriaActividad As List(Of CategoriaActividadBE) = Nothing

                iCategoriaActividad = New CategoriaActividadDL
                oListadoCategoriaActividad = iCategoriaActividad.ListarCategoriaActividad(id_tipo_act)

                Return oListadoCategoriaActividad

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

