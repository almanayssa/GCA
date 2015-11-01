Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IUsuario

#Region "Select"

        Function ObtenerUsuarioLogueado(ByVal username As String, ByVal password As String) As UsuarioBE

#End Region

    End Interface

End Namespace

