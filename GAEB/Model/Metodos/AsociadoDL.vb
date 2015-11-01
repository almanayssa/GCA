Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class AsociadoDL
        Implements IAsociado

#Region "Select"

        Public Function ListarAsociados() As System.Collections.Generic.List(Of Entidades.AsociadoBE) Implements Interfaces.IAsociado.ListarAsociados
            Dim oListadoAsociados As New List(Of AsociadoBE)
            Dim oAsociado As AsociadoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("Comite.SP_LISTAR_ASOCIADOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oAsociado = New AsociadoBE
                    oAsociado.id_socio = dr("id_socio")
                    oAsociado.id_persona = dr("id_persona")
                    oAsociado.condicion = dr("condicion")
                    oAsociado.id_accion = dr("id_accion")
                    oListadoAsociados.Add(oAsociado)
                End While
                dr.Close()
                Return oListadoAsociados
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarAsociadosDatos() As System.Collections.Generic.List(Of Entidades.AsociadoBE) Implements Interfaces.IAsociado.ListarAsociadosDatos
            Dim oListadoAsociados As New List(Of AsociadoBE)
            Dim oAsociado As AsociadoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("Comite.SP_LISTAR_ASOCIADOS_DATOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oAsociado = New AsociadoBE
                    oAsociado.id_socio = dr("id_socio")
                    oAsociado.id_persona = dr("id_persona")
                    oAsociado.condicion = dr("des_cod")
                    oAsociado.id_accion = dr("id_accion")
                    oAsociado.persona_nombre_completo = dr("nombrecompleto")
                    oAsociado.persona_dni_per = dr("dni_per")
                    oAsociado.persona_fec_nac_per = dr("fec_nac_per")
                    oListadoAsociados.Add(oAsociado)
                End While
                dr.Close()
                Return oListadoAsociados
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

