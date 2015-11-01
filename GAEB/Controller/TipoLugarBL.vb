Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarTipoLugar() As List(Of TipoLugarBE)
            Try
                Dim iTipoLugar As ITipoLugar
                Dim oListadoTipoLugar As List(Of TipoLugarBE) = Nothing

                iTipoLugar = New TipoLugarDL
                oListadoTipoLugar = iTipoLugar.ListarTipoLugar()

                Return oListadoTipoLugar

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

