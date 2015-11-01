Public Class logoff
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        Session("ubosque") = ""
        Session.Clear()
        Session.Abandon()
        Response.Redirect("index.aspx")
    End Sub
End Class