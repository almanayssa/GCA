Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarAsociados() As List(Of AsociadoBE)
            Try
                Dim iAsociado As IAsociado
                Dim oListarAsociados As List(Of AsociadoBE) = Nothing

                iAsociado = New AsociadoDL
                oListarAsociados = iAsociado.ListarAsociados()

                Return oListarAsociados

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarAsociadosDatos() As List(Of AsociadoBE)
            Try
                Dim iAsociado As IAsociado
                Dim oListarAsociados As List(Of AsociadoBE) = Nothing

                iAsociado = New AsociadoDL
                oListarAsociados = iAsociado.ListarAsociadosDatos()

                Return oListarAsociados

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
