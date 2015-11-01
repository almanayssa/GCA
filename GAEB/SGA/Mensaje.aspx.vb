Public Class Mensaje
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            lblMessagePage.Text = Sesiones.MessageTitle
            lblMessageDescription.Text = Sesiones.MessageDescription
        End If
    End Sub

    Private Sub ibtContinue_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtContinue.Click
        Response.Redirect(Sesiones.MessageContinue, True)
    End Sub
End Class