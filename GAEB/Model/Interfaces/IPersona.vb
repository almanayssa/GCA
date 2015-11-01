Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IPersona

#Region "Select"

        Function ListarResponsables() As List(Of PersonaBE)
        Function ListarPersonasFamilia(ByVal clave As String, ByVal nombre As String) As List(Of PersonaBE)

#End Region

    End Interface

End Namespace

