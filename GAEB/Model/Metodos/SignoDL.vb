Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class SignoDL
        Implements ISigno

#Region "Select"

        Public Function ListarSignos() As System.Collections.Generic.List(Of Entidades.SignoBE) Implements Interfaces.ISigno.ListarSignos
            Dim oListadoSignos As New List(Of SignoBE)
            Dim oSigno As SignoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_SIGNOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSigno = New SignoBE
                    oSigno.id_signo = dr("id_signo")
                    oSigno.signo = dr("signo")
                    oListadoSignos.Add(oSigno)
                End While
                dr.Close()
                Return oListadoSignos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace
