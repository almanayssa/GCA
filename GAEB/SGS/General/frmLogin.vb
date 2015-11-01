Imports SGS.Controller
Imports SGS.Model.Entidades

Public Class frmLogin

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Function ValidarCamposRequeridos() As Boolean
        Dim flag As Boolean = False

        If tbxUsuario.Text.Trim = String.Empty Then
            flag = True
        End If

        If tbxContrasena.Text.Trim = String.Empty Then
            flag = True
        End If

        Return flag
    End Function

    Private Sub IniciarSesion()

        'If ValidarCamposRequeridos() Then
        '    MessageBox.Show("Complete datos", "Información")
        '    Exit Sub
        'End If

        'Dim oUsuarioLogueado As New UsuarioBE
        'oUsuarioLogueado = bc.ObtenerUsuarioLogueado(tbxUsuario.Text.Trim, tbxContrasena.Text.Trim)

        'If oUsuarioLogueado.id_usuario = Nothing Then
        '    MessageBox.Show("Usuario o contraseña incorrectos", "Información")
        'Else
        Me.Hide()
        MDI.Show()
        'End If
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnEntrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        IniciarSesion()
    End Sub

#End Region

End Class
