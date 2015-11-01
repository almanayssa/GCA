Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PersonalDL
        Implements IPersonal

#Region "Select"

        Public Function ListarPersonal(ByVal id_tipo_personal As Integer) As System.Collections.Generic.List(Of Entidades.PersonalBE) Implements Interfaces.IPersonal.ListarPersonal
            Dim oListadoPersonal As New List(Of PersonalBE)
            Dim oPersonal As PersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PERSONAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo_personal", SqlDbType.Int).Value = id_tipo_personal

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPersonal = New PersonalBE
                    oPersonal.id_personal = dr("id_personal")
                    oPersonal.nombre_completo = dr("nombre_completo")
                    oPersonal.tipo_personal = dr("tipo")
                    oListadoPersonal.Add(oPersonal)
                End While
                dr.Close()
                Return oListadoPersonal
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

