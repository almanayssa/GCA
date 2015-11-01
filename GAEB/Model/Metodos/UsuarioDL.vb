Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class UsuarioDL
        Implements IUsuario

#Region "Select"

        Public Function ObtenerUsuarioLogueado(ByVal username As String, ByVal password As String) As UsuarioBE Implements IUsuario.ObtenerUsuarioLogueado
            Dim oUsuario As New UsuarioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_USUARIO_LOGUEADO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oUsuario.id_usuario = dr("id_usuario")
                    oUsuario.username = dr("username")
                    oUsuario.password = dr("password")
                End If
                dr.Close()
                Return oUsuario
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

#End Region
 
    End Class

End Namespace

