Public Class PlantillaBosque
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Session("ubosque") = "" Then
        '    Response.Redirect("index.aspx")
        'End If
        'Dim strPage = Me.Request.ServerVariables("script_name")
        'strPage = Right(strPage, Len(strPage) - InStrRev(strPage, "/"))
        'If strPage <> "frmRegistroInvitadosWeb.aspx" Then
        '    Session("invitacion") = Nothing
        'End If
    End Sub

End Class