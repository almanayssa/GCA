Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Data.Common

Namespace SGS.Model.Metodos

    Public Class ObjetoGeneralDL
        Implements IObjetoGeneral

        Public Function SelectHoraServidor() As DateTime Implements Interfaces.IObjetoGeneral.SelectHoraServidor

            Dim strConn As String = ConfigurationManager.ConnectionStrings("conexion").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim strCommand As New StringBuilder
            Dim currentDate As DateTime

            Dim strSQL As New StringBuilder()

            strSQL.Append("SELECT GETDATE() as CurrentDate ")

            Dim sqlCmd As New SqlCommand(strSQL.ToString(), sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.Text

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    currentDate = dr("CurrentDate")
                End If
                dr.Close()

                Return currentDate
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace
