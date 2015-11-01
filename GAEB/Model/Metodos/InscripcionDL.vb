Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class InscripcionDL
        Implements IInscripcion

#Region "Insert"

        Public Function InsertarInscripcion(ByRef oInscripcion As Entidades.InscripcionBE) As Integer Implements Interfaces.IInscripcion.InsertarInscripcion
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_INSCRIPCION", sqlConn)

            'Dim prm As New SqlParameter("@id", SqlDbType.Int)
            Dim recordId As Integer
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = oInscripcion.id_socio
            If oInscripcion.serie <> "" AndAlso oInscripcion.correlativo <> "" Then
                sqlCmd.Parameters.Add("@tipo_doc", SqlDbType.VarChar).Value = oInscripcion.tipo_doc
                sqlCmd.Parameters.Add("@serie", SqlDbType.VarChar).Value = oInscripcion.serie
                sqlCmd.Parameters.Add("@correlativo", SqlDbType.VarChar).Value = oInscripcion.correlativo
            End If
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.VarChar).Value = oInscripcion.flg_web
            sqlCmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = oInscripcion.monto
            If oInscripcion.id_actividad_detalle <> 0 Then
                sqlCmd.Parameters.Add("@id_actividad_detalle", SqlDbType.Int).Value = oInscripcion.id_actividad_detalle
            End If
            If oInscripcion.id_actividad <> 0 Then
                sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oInscripcion.id_actividad
            End If
            If oInscripcion.id_actividad_recurrente <> 0 Then
                sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = oInscripcion.id_actividad_recurrente
                sqlCmd.Parameters.Add("@fecha_recurrente", SqlDbType.Date).Value = oInscripcion.fecha_recurrente
            End If


            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()
                'recordId = CType(prm.Value, Integer)
                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

        Public Function InsertarInscrito(ByRef oPersona As Entidades.PersonaBE) As Integer Implements Interfaces.IInscripcion.InsertarInscrito
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_INSCRITO", sqlConn)
            Dim rows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = oPersona.id_inscripcion
            sqlCmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = oPersona.id_persona
            sqlCmd.Parameters.Add("@tipo_familiar", SqlDbType.VarChar).Value = oPersona.tipo_familiar

            Try
                sqlConn.Open()
                rows = sqlCmd.ExecuteNonQuery()

                Return rows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

#End Region

    End Class

End Namespace

