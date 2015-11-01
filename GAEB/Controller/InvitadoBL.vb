Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarInvitados(ByVal clave As String, ByVal nombre As String) As List(Of InvitadoBE)
            Try
                Dim iInvitado As IInvitado
                Dim oListarInvitados As List(Of InvitadoBE) = Nothing

                iInvitado = New InvitadoDL
                oListarInvitados = iInvitado.ListarInvitados(clave, nombre)

                Return oListarInvitados

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
