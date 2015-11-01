Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarResponsables() As List(Of PersonaBE)
            Try
                Dim iPersona As IPersona
                Dim oListarResponsables As List(Of PersonaBE) = Nothing

                iPersona = New PersonaDL
                oListarResponsables = iPersona.ListarResponsables()

                Return oListarResponsables

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function ListarPersonasFamilia(ByVal password As String, ByVal nombre As String) As List(Of PersonaBE)
            Try
                Dim iPersona As IPersona
                Dim oListarPersonas As List(Of PersonaBE) = Nothing

                iPersona = New PersonaDL
                oListarPersonas = iPersona.ListarPersonasFamilia(password, nombre)

                Return oListarPersonas

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace
