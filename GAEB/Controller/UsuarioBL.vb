Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ObtenerUsuarioLogueado(ByVal username As String, ByVal password As String) As UsuarioBE
            Try
                Dim iUsuario As IUsuario
                Dim oUsuario As UsuarioBE = Nothing

                iUsuario = New UsuarioDL
                oUsuario = iUsuario.ObtenerUsuarioLogueado(username, password)

                Return oUsuario

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace

