Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class TipoLugarDL
        Implements ITipoLugar

#Region "Select"

        Public Function ListarTipoLugar() As System.Collections.Generic.List(Of Entidades.TipoLugarBE) Implements Interfaces.ITipoLugar.ListarTipoLugar
            Dim oListadoTipoLugar As New List(Of TipoLugarBE)
            Dim oTipoLugar As TipoLugarBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOS_LUGAR", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipoLugar = New TipoLugarBE
                    oTipoLugar.id_tipo = dr("id_tipo")
                    oTipoLugar.desc_tipo = dr("desc_tipo")
                    oTipoLugar.flg_anulado = dr("flg_anulado")
                    oListadoTipoLugar.Add(oTipoLugar)
                End While
                dr.Close()
                Return oListadoTipoLugar
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

