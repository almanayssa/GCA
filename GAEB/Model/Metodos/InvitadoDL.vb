Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class InvitadoDL
        Implements IInvitado

#Region "Select"

        Public Function ListarInvitados(ByVal clave As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.InvitadoBE) Implements Interfaces.IInvitado.ListarInvitados
            Dim oListadoInvitados As New List(Of InvitadoBE)
            Dim oInvitado As InvitadoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("Comite.SP_LISTAR_INVITADOS_INSCRIBIR", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oInvitado = New InvitadoBE
                    oInvitado.id_invitado = dr("id_invitado")
                    oInvitado.nombre_completo = dr("nombrecompleto")
                    oInvitado.fec_nac = dr("fec_nac")
                    oInvitado.dni_inv = dr("dni_inv")
                    oListadoInvitados.Add(oInvitado)
                End While
                dr.Close()
                Return oListadoInvitados
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

