Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IPersonal

#Region "Select"

        Function ListarPersonal(ByVal id_tipo_personal As Integer) As List(Of PersonalBE)

#End Region

    End Interface

End Namespace

