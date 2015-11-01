Imports SGS.Model.Entidades

Namespace SGS.Model.Interfaces

    Public Interface IInscripcion

#Region "Insert"

        Function InsertarInscripcion(ByRef oInscripcion As InscripcionBE) As Integer
        Function InsertarInscrito(ByRef oPersona As PersonaBE) As Integer

#End Region

    End Interface

End Namespace

