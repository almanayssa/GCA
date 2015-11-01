Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class LugarDL
        Implements ILugar

#Region "Select"

        Public Function ListarLugares(ByVal id_tipo As Integer, ByVal id_sede As String) As System.Collections.Generic.List(Of Entidades.LugarBE) Implements Interfaces.ILugar.ListarLugares
            Dim oListadoLugares As New List(Of LugarBE)
            Dim oLugar As LugarBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_LUGARES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.Int).Value = id_tipo
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = id_sede

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oLugar = New LugarBE
                    oLugar.id_lugar = dr("id_lugar")
                    oLugar.nombre = dr("nombre")
                    oLugar.direccion = dr("direccion")
                    oLugar.id_tipo = dr("id_tipo")
                    oListadoLugares.Add(oLugar)
                End While
                dr.Close()
                Return oListadoLugares
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

