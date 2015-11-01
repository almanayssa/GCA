Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PersonaDL
        Implements IPersona

#Region "Select"

        Public Function ListarResponsables() As System.Collections.Generic.List(Of Entidades.PersonaBE) Implements Interfaces.IPersona.ListarResponsables
            Dim oListadoPersonas As New List(Of PersonaBE)
            Dim oPersona As PersonaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("Comite.SP_LISTAR_RESPONSABLES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPersona = New PersonaBE
                    oPersona.id_persona = dr("id_persona")
                    oPersona.nombre_completo = dr("nombre_completo")
                    oListadoPersonas.Add(oPersona)
                End While
                dr.Close()
                Return oListadoPersonas
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarPersonasFamilia(ByVal clave As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.PersonaBE) Implements Interfaces.IPersona.ListarPersonasFamilia
            Dim oListadoPersonas As New List(Of PersonaBE)
            Dim oPersona As PersonaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("Comite.SP_LISTAR_PERSONAS_REL_FAMILIA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPersona = New PersonaBE
                    oPersona.id_persona = dr("id_persona")
                    oPersona.nombre_completo = dr("nombre_completo")
                    oPersona.tipo_familiar = dr("tipo_familiar")
                    oPersona.fec_nac_per = dr("fec_nac_per")
                    oPersona.dni_per = IIf(IsDBNull(dr("dni_per")), Nothing, dr("dni_per"))
                    oListadoPersonas.Add(oPersona)
                End While
                dr.Close()
                Return oListadoPersonas
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

