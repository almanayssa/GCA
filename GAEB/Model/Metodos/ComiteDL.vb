Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class ComiteDL
        Implements IComite

#Region "Select"

        Public Function ListarComites() As System.Collections.Generic.List(Of Entidades.ComiteBE) Implements Interfaces.IComite.ListarComites
            Dim oListadoComites As New List(Of ComiteBE)
            Dim oComite As ComiteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_COMITES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oComite = New ComiteBE
                    oComite.id_comite = dr("id_comite")
                    oComite.nombre = dr("nombre")
                    oComite.cta_contable = dr("cta_contable")
                    oListadoComites.Add(oComite)
                End While
                dr.Close()
                Return oListadoComites
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

