Public Class index
    Inherits System.Web.UI.Page

    'Private objUsuarioBosque As New Bosque.BL.UsuarioBL
    'Private objSocioBosque As New Bosque.BL.SocioBL
    'Private EntSocio As New Bosque.BE.SocioBE
    'Private objAuditoria As New Bosque.BL.AuditoriaBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtUsuario.Focus()
        End If
        Label1.Visible = False
    End Sub

    Protected Sub btnAcceder_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAcceder.Click
        Dim strPage As String = Me.Request.ServerVariables("script_name")
        strPage = Right(strPage, Len(strPage) - InStrRev(strPage, "/"))

        'If objUsuarioBosque.validarUsuario(txtUsuario.Text.Trim, txtClave.Text.Trim) Then
        '    EntSocio = objSocioBosque.datosUsuario(txtUsuario.Text.Trim)
        Session("ubosque") = txtUsuario.Text.Trim
        '    Session("id_socio") = EntSocio.id_socio
        '    Session("id_persona") = EntSocio.id_persona

        '    objAuditoria.registrarAuditoria(EntSocio.id_socio, "", "SELECT", "", "", "", "", "", "Ingresó a la web", _
        '                                    Request.ServerVariables("REMOTE_ADDR"), strPage)


        Response.Redirect("inicio.aspx")
        'Else
        '    Label1.Visible = True
        '    Label1.Text = "Verifique sus datos"
        '    objAuditoria.registrarAuditoria(txtUsuario.Text, "", "SELECT", "", "", "", "", "", "Ingreso fallido a la web", _
        '                                    Request.ServerVariables("REMOTE_ADDR"), strPage)
        'End If
    End Sub

End Class