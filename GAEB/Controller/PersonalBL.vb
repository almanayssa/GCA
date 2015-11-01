Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarPersonal(ByVal id_tipo_personal As Integer) As List(Of PersonalBE)
            Try
                Dim iPersonal As IPersonal
                Dim oListadoPersonal As List(Of PersonalBE) = Nothing

                iPersonal = New PersonalDL
                oListadoPersonal = iPersonal.ListarPersonal(id_tipo_personal)

                Return oListadoPersonal

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

