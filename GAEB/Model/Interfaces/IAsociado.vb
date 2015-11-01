Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IAsociado

#Region "Select"

        Function ListarAsociados() As List(Of AsociadoBE)
        Function ListarAsociadosDatos() As List(Of AsociadoBE)

#End Region

    End Interface

End Namespace

