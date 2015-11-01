Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarSedes() As List(Of SedeBE)
            Try
                Dim iSede As ISede
                Dim oListadoSedes As List(Of SedeBE) = Nothing

                iSede = New SedeDL
                oListadoSedes = iSede.ListarSedes()

                Return oListadoSedes

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

