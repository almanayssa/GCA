Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos


Namespace SGS.Controller
    Partial Public Class ObjetoGeneralBL

#Region "Select"

        Public Function SelectHoraServidor() As Date
            Try
                Dim iObjetoGeneral As IObjetoGeneral
                Dim HoraServidor As Date = Nothing

                iObjetoGeneral = New ObjetoGeneralDL
                HoraServidor = iObjetoGeneral.SelectHoraServidor()

                Return HoraServidor

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Update"

#End Region

#Region "Insert"

#End Region

    End Class

End Namespace
