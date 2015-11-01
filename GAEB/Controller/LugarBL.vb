Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarLugares(ByVal id_tipo As Integer, ByVal id_sede As String) As List(Of LugarBE)
            Try
                Dim iLugar As ILugar
                Dim oListadoLugares As List(Of LugarBE) = Nothing

                iLugar = New LugarDL
                oListadoLugares = iLugar.ListarLugares(id_tipo, id_Sede)

                Return oListadoLugares

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

