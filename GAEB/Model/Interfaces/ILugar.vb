Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface ILugar

#Region "Select"

        Function ListarLugares(ByVal id_tipo As Integer, ByVal id_sede As String) As List(Of LugarBE)

#End Region

    End Interface

End Namespace

