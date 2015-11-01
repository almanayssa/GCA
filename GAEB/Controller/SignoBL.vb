Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSignos() As List(Of SignoBE)
            Try
                Dim iSigno As ISigno
                Dim oListadoSignos As List(Of SignoBE) = Nothing

                iSigno = New SignoDL
                oListadoSignos = iSigno.ListarSignos()

                Return oListadoSignos

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
