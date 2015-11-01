Imports System.Collections.Generic

Partial Class inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Validación si la sesión esta abierta para que pueda ingresar al sistema
        If Session("ubosque") = "" Then
            Response.Redirect("index.aspx")
        End If

        'If Session("url") <> "" Then
        '    TextBox1.Text = Session("url")
        'End If

        ' ''Dim objetoSocio As New Bosque.BL.SocioBL
        ' ''Dim objListSocio As List(Of Bosque.BE.SocioBE)

        ' ''objListSocio = objetoSocio.ListarSocio(Session("ubosque").ToString)

        ' ''If Not IsNothing(objListSocio) Then
        ' ''    lblApellidosNombre.Text = objListSocio.Item(0).nom_per & " " & objListSocio.Item(0).ape_pat & " " & objListSocio.Item(0).ape_mat
        ' ''Else
        ' ''    lblApellidosNombre.Text = "Sesión desactivada"
        ' ''End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Response.Redirect("frmVotacionEvento.aspx")
    End Sub

End Class