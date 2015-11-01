Imports System.Data
Imports System.Collections.Generic

Public Class controles_usrEncabezado
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Session("ubosque") <> "" Then
                menu1.DataSource = Server.MapPath("menu1.xml")
                Menu1.DataBind()
                DatosGlobales()
                'HyperLink2.NavigateUrl = "~/frmContactenos.aspx"
                'MostrarMenu("lcruzado")
            Else
                lnkSalir.Visible = False
                HyperLink2.NavigateUrl = "http://www.elbosque.org.pe/sugerencias_y_contacto.php"
            End If

        End If
    End Sub

    Private Sub DatosGlobales()
        'Dim objSocio As New Bosque.BL.SocioBL
        'Dim objListaSocio As List(Of Bosque.BE.SocioBE)

        'objListaSocio = objSocio.ListarSocio(Session("ubosque"))
        'If Not IsNothing(objListaSocio) Then
        '    If objListaSocio.Count > 0 Then
        '        lblUsuario.Text = "Usuario: " & objListaSocio.Item(0).ape_pat & " " & objListaSocio.Item(0).ape_mat & " " & objListaSocio.Item(0).nom_per
        '        lblaccion.Text = "Clave: " & objListaSocio.Item(0).id_accion
        '    End If
        'Else
        '    lblUsuario.Text = "Usuario inactivo"
        'End If


        'lblLugar.Text = "Sede: " & "Santiago de Surco"
        'lblUsuario.Text = "Usuario: " & "lcruzado"
    End Sub

    Private Function DtMenu(ByVal pUsuario As String) As DataTable
        Dim dt As New DataTable("menu")
        Dim rw As DataRow
        dt.Columns.Add("pagina", GetType(String))
        dt.Columns.Add("descripcion", GetType(String))

        rw = dt.NewRow
        rw("pagina") = "frmConsultaDeudaWeb.aspx"
        rw("descripcion") = "Cuotas pendientes"
        dt.Rows.Add(rw)

        rw = dt.NewRow
        rw("pagina") = "frmConsultaCuotasCanc.aspx"
        rw("descripcion") = "Consulta Cuotas Canceladas"
        dt.Rows.Add(rw)

        rw = dt.NewRow
        rw("pagina") = "DatosSocio.aspx"
        rw("descripcion") = "Datos personales"
        dt.Rows.Add(rw)

        rw = dt.NewRow
        rw("pagina") = "frmCambioPassword.aspx"
        rw("descripcion") = "Cambio de Password"
        dt.Rows.Add(rw)

        rw = dt.NewRow
        rw("pagina") = "frmRegistroInvitadosWeb.aspx"
        rw("descripcion") = "Registro de invitados"
        dt.Rows.Add(rw)

        rw = dt.NewRow
        rw("pagina") = "ReservacionBungalows.aspx"
        rw("descripcion") = "Reserva de Alojamientos"
        dt.Rows.Add(rw)
        'rw = dt.NewRow
        'rw("pagina") = "enviarsugerencia.aspx"
        'rw("descripcion") = "Sugerencias"
        'dt.Rows.Add(rw)

        'rw = dt.NewRow
        'rw("pagina") = "recuperarclave.aspx"
        'rw("descripcion") = "recupera clave"
        'dt.Rows.Add(rw)

        Return dt
    End Function


    'Private Sub MostrarMenu(ByVal pUsuario As String)
    '    Dim dt As DataTable = DtMenu(pUsuario)
    '    Dim rw As DataRow
    '    For Each rw In dt.Rows
    '        Dim mn As New MenuItem
    '        mn.Value = rw.Item("pagina")
    '        mn.Text = rw.Item("descripcion")
    '        mn.NavigateUrl = "../" & rw.Item("pagina")
    '        mn.ImageUrl = "../imagenes/botones/icoMenu.gif"
    '        mnuPrincipal.Items.Add(mn)
    '        'mnuPrincipal.CssClass = "Menu1"
    '    Next

    'End Sub

End Class