Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Color
Imports System.ComponentModel

Public Class MDI
    'Dim X As New Configuration.AppSettingsReader
    'Dim cad As String = X.GetValue("conexion", Type.GetType("System.String"))
    'Dim bd As String = X.GetValue("bd", Type.GetType("System.String"))

    'Dim cnx As New SqlConnection(cad)

#Region "Cargar"

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Bienvenido - Versión 1.0"

        'Me.lblTipoC.Margin = New System.Windows.Forms.Padding(Me.Width - 300, 3, 0, 2)
        'lblMdi.Text = "Conectado a: " & bd
        'If Modulo_Parametros.area_usuario = "CAJA" Or Modulo_Parametros.area_usuario = "COBRANZA" Then
        '    lblTipoC.Text = "Tipo de Cambio:"
        '    If Modulo_Parametros.tipo_cambio = 0 Then
        '        lblValorTC.Text = "S/V"
        '    Else
        '        lblValorTC.Text = CStr(Format(Modulo_Parametros.tipo_cambio, "####.000"))
        '    End If

        'End If

    End Sub

#End Region

#Region "Cerrar"

    Private Sub MDI_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim rpta As Integer
        rpta = MsgBox("Desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If rpta = MsgBoxResult.No Then
            e.Cancel = True
        ElseIf rpta = MsgBoxResult.Yes Then
            End
        End If
    End Sub

#End Region

#Region "Metodos Botones"

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Limpiar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Imprimir()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Modificar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Eliminar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Grabar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos Menu"

    Private Sub RegistroDeActividadToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegistroDeActividadToolStripMenuItem.Click

    End Sub

    Private Sub RegistroDeInscripcionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegistroDeInscripcionToolStripMenuItem.Click

    End Sub

    Private Sub PlanificaciónAnualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanificaciónAnualToolStripMenuItem.Click

    End Sub

    Private Sub HabilitarActividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabilitarActividadToolStripMenuItem.Click

    End Sub

    Private Sub PresidenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresidenciaToolStripMenuItem.Click

    End Sub

    Private Sub PresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoToolStripMenuItem.Click

    End Sub

#End Region

    Private Sub RegistroDeActividadRecurrenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeActividadRecurrenteToolStripMenuItem.Click
        
    End Sub

End Class