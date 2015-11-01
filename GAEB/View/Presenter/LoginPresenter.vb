Imports SGS.Model.Entidades
Imports SGS.Controller
Imports SGS.View.Interfaces

Namespace SGS.View.Presenter

    Public Class LoginPresenter

        Public vLogin As ILogin
        Public oUsuario As UsuarioBE
        Public bc As BusinessController

        Public Sub New(ByVal vLogin As ILogin)
            Me.vLogin = vLogin

            bc = New BusinessController
        End Sub

        Private Function ValidarCamposRequeridos() As Boolean
            Dim flag As Boolean = False

            If vLogin.Usuario = String.Empty Then
                flag = True
            End If

            If vLogin.Contrasena = String.Empty Then
                flag = True
            End If

            Return flag
        End Function

        Public Sub IniciarSesion()

            If ValidarCamposRequeridos() Then
                vLogin.MostrarMensaje("Complete datos", "Información")
                Exit Sub
            End If

            Dim oUsuarioLogueado As New UsuarioBE
            oUsuarioLogueado = bc.ObtenerUsuarioLogueado(vLogin.Usuario, vLogin.Contrasena)

            If oUsuarioLogueado.Codigo = Nothing Then
                vLogin.MostrarMensaje("Usuario o contraseña incorrectos", "Información")
            Else
                vLogin.Redireccionar()
            End If
        End Sub

    End Class

End Namespace

