Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class ActividadDetalleDL
        Implements IActividadDetalle

#Region "Select"

        Public Function ListarDetallesXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.ActividadDetalleBE) Implements Interfaces.IActividadDetalle.ListarDetallesXActividad
            Dim oListadoDetalles As New List(Of ActividadDetalleBE)
            Dim oDetalle As ActividadDetalleBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DETALLES_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.VarChar).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oDetalle = New ActividadDetalleBE
                    oDetalle.id_actividad_detalle = dr("id_actividad_detalle")
                    oDetalle.fecha_ini = dr("fecha_ini")
                    oDetalle.hora_ini = dr.GetTimeSpan(2)
                    oDetalle.fecha_fin = dr("fecha_fin")
                    oDetalle.hora_fin = dr.GetTimeSpan(4)
                    oDetalle.id_sede = dr("id_sede")
                    oDetalle.des_sede = dr("des_sede")
                    oDetalle.id_tipo_lugar = dr("id_tipo")
                    oDetalle.id_lugar = dr("id_lugar")
                    oDetalle.lugar = dr("nombre")
                    oDetalle.vacantes = dr("vacantes")
                    oListadoDetalles.Add(oDetalle)
                End While
                dr.Close()
                Return oListadoDetalles
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarDetallesXActividadInscribir(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.ActividadDetalleBE) Implements Interfaces.IActividadDetalle.ListarDetallesXActividadInscribir
            Dim oListadoDetalles As New List(Of ActividadDetalleBE)
            Dim oDetalle As ActividadDetalleBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DETALLES_ACTIVIDAD_INSCRIBIR", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.VarChar).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oDetalle = New ActividadDetalleBE
                    oDetalle.id_actividad_detalle = dr("id_actividad_detalle")
                    oDetalle.fecha_ini = dr("fecha_ini")
                    oDetalle.hora_ini = dr.GetTimeSpan(2)
                    oDetalle.fecha_fin = dr("fecha_fin")
                    oDetalle.hora_fin = dr.GetTimeSpan(4)
                    oDetalle.id_sede = dr("id_sede")
                    oDetalle.des_sede = dr("des_sede")
                    oDetalle.lugar = dr("lugar")
                    oDetalle.id_tipo_lugar = dr("id_tipo")
                    oDetalle.id_lugar = dr("id_lugar")
                    oDetalle.vacantes = CInt(IIf(dr("vacantes") Is DBNull.Value, 0, dr("vacantes"))) - CInt(IIf(dr("usado") Is DBNull.Value, 0, dr("usado")))
                    oListadoDetalles.Add(oDetalle)
                End While
                dr.Close()
                Return oListadoDetalles
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarActividadDetalle(ByRef oActividadDetalle As Entidades.ActividadDetalleBE) As Integer Implements Interfaces.IActividadDetalle.InsertarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD_DETALLE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = IIf(oActividadDetalle.id_actividad Is Nothing, DBNull.Value, oActividadDetalle.id_actividad)
            sqlCmd.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = IIf(oActividadDetalle.fecha_ini Is Nothing, DBNull.Value, oActividadDetalle.fecha_ini)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividadDetalle.hora_ini Is Nothing, DBNull.Value, oActividadDetalle.hora_ini)
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = IIf(oActividadDetalle.fecha_fin Is Nothing, DBNull.Value, oActividadDetalle.fecha_fin)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividadDetalle.hora_fin Is Nothing, DBNull.Value, oActividadDetalle.hora_fin)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oActividadDetalle.id_sede Is Nothing, DBNull.Value, oActividadDetalle.id_sede)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oActividadDetalle.id_lugar Is Nothing, DBNull.Value, oActividadDetalle.id_lugar)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividadDetalle.vacantes Is Nothing, DBNull.Value, oActividadDetalle.vacantes)

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Update"

        Public Function ActualizarActividadDetalle(ByRef oActividadDetalle As Entidades.ActividadDetalleBE) As Integer Implements Interfaces.IActividadDetalle.ActualizarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD_DETALLE", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_detalle", SqlDbType.Int).Value = oActividadDetalle.id_actividad_detalle
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = IIf(oActividadDetalle.id_actividad Is Nothing, DBNull.Value, oActividadDetalle.id_actividad)
            sqlCmd.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = IIf(oActividadDetalle.fecha_ini Is Nothing, DBNull.Value, oActividadDetalle.fecha_ini)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividadDetalle.hora_ini Is Nothing, DBNull.Value, oActividadDetalle.hora_ini)
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = IIf(oActividadDetalle.fecha_fin Is Nothing, DBNull.Value, oActividadDetalle.fecha_fin)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividadDetalle.hora_fin Is Nothing, DBNull.Value, oActividadDetalle.hora_fin)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oActividadDetalle.id_sede Is Nothing, DBNull.Value, oActividadDetalle.id_sede)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oActividadDetalle.id_lugar Is Nothing, DBNull.Value, oActividadDetalle.id_lugar)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividadDetalle.vacantes Is Nothing, DBNull.Value, oActividadDetalle.vacantes)

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarActividadDetalle(ByVal id_actividad_detalle As Integer) As Integer Implements Interfaces.IActividadDetalle.BorrarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDAD_DETALLE", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_detalle", SqlDbType.Int).Value = id_actividad_detalle

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

