Namespace SGS.View.Interfaces

    Public Interface ILogin

        Property Usuario As String
        Property Contrasena As String
        Sub MostrarMensaje(ByVal mensaje As String, ByVal titulo As String)
        Sub Redireccionar()

    End Interface

End Namespace

