Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class ActividadRecurrenteDL
        Implements IActividadRecurrente

#Region "Select"

        Public Function ObtenerActividadRecurrente(ByVal id_actividad_recurrente As Integer) As Entidades.ActividadRecurrenteBE Implements Interfaces.IActividadRecurrente.ObtenerActividadRecurrente
            Dim oActividadRecurrente As New ActividadRecurrenteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_ACTIVIDAD_RECURRENTE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = id_actividad_recurrente

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oActividadRecurrente.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividadRecurrente.tipo = dr("tipo")
                    oActividadRecurrente.num_rep = dr("num_rep")
                    oActividadRecurrente.chk_dom = IIf(dr("chk_dom") Is DBNull.Value, Nothing, dr("chk_dom"))
                    oActividadRecurrente.chk_lun = IIf(dr("chk_lun") Is DBNull.Value, Nothing, dr("chk_lun"))
                    oActividadRecurrente.chk_mar = IIf(dr("chk_mar") Is DBNull.Value, Nothing, dr("chk_mar"))
                    oActividadRecurrente.chk_mie = IIf(dr("chk_mie") Is DBNull.Value, Nothing, dr("chk_mie"))
                    oActividadRecurrente.chk_jue = IIf(dr("chk_jue") Is DBNull.Value, Nothing, dr("chk_jue"))
                    oActividadRecurrente.chk_vie = IIf(dr("chk_vie") Is DBNull.Value, Nothing, dr("chk_vie"))
                    oActividadRecurrente.chk_sab = IIf(dr("chk_sab") Is DBNull.Value, Nothing, dr("chk_sab"))
                    oActividadRecurrente.dia_mes = IIf(dr("dia_mes") Is DBNull.Value, Nothing, dr("dia_mes"))
                    oActividadRecurrente.ordinal = IIf(dr("ordinal") Is DBNull.Value, Nothing, dr("ordinal"))
                    oActividadRecurrente.dia_semana = IIf(dr("dia_semana") Is DBNull.Value, Nothing, dr("dia_semana"))
                    oActividadRecurrente.fecha_fin = IIf(dr("fecha_fin") Is DBNull.Value, Nothing, dr("fecha_fin"))
                    oActividadRecurrente.id_sede = dr("id_sede")
                    oActividadRecurrente.id_lugar = dr("id_lugar")
                    oActividadRecurrente.vacantes = dr("vacantes")
                    oActividadRecurrente.hora_ini = dr.GetTimeSpan(17) 'dr("hora_ini")
                    oActividadRecurrente.hora_fin = dr.GetTimeSpan(18) 'dr("hora_fin")
                End If

                dr.Close()
                Return oActividadRecurrente
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarActividadRecurrente(ByRef oActividadRecurrente As Entidades.ActividadRecurrenteBE) As Integer Implements Interfaces.IActividadRecurrente.InsertarActividadRecurrente
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD_RECURRENTE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.Add("@tipo", SqlDbType.Char).Value = IIf(oActividadRecurrente.tipo Is Nothing, DBNull.Value, oActividadRecurrente.tipo)
            sqlCmd.Parameters.Add("@num_rep", SqlDbType.Bit).Value = IIf(oActividadRecurrente.num_rep Is Nothing, DBNull.Value, oActividadRecurrente.num_rep)
            sqlCmd.Parameters.Add("@chk_dom", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_dom Is Nothing, DBNull.Value, oActividadRecurrente.chk_dom)
            sqlCmd.Parameters.Add("@chk_lun", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_lun Is Nothing, DBNull.Value, oActividadRecurrente.chk_lun)
            sqlCmd.Parameters.Add("@chk_mar", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mar Is Nothing, DBNull.Value, oActividadRecurrente.chk_mar)
            sqlCmd.Parameters.Add("@chk_mie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mie Is Nothing, DBNull.Value, oActividadRecurrente.chk_mie)
            sqlCmd.Parameters.Add("@chk_jue", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_jue Is Nothing, DBNull.Value, oActividadRecurrente.chk_jue)
            sqlCmd.Parameters.Add("@chk_vie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_vie Is Nothing, DBNull.Value, oActividadRecurrente.chk_vie)
            sqlCmd.Parameters.Add("@chk_sab", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_sab Is Nothing, DBNull.Value, oActividadRecurrente.chk_sab)
            sqlCmd.Parameters.Add("@dia_mes", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_mes Is Nothing, DBNull.Value, oActividadRecurrente.dia_mes)
            sqlCmd.Parameters.Add("@ordinal", SqlDbType.Int).Value = IIf(oActividadRecurrente.ordinal Is Nothing, DBNull.Value, oActividadRecurrente.ordinal)
            sqlCmd.Parameters.Add("@dia_semana", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_semana Is Nothing, DBNull.Value, oActividadRecurrente.dia_semana)
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = IIf(oActividadRecurrente.fecha_fin Is Nothing, DBNull.Value, oActividadRecurrente.fecha_fin)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.id_sede Is Nothing, DBNull.Value, oActividadRecurrente.id_sede)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oActividadRecurrente.id_lugar Is Nothing, DBNull.Value, oActividadRecurrente.id_lugar)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividadRecurrente.vacantes Is Nothing, DBNull.Value, oActividadRecurrente.vacantes)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_ini Is Nothing, DBNull.Value, oActividadRecurrente.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_fin Is Nothing, DBNull.Value, oActividadRecurrente.hora_fin)

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

        Public Function ActualizarActividadRecurrente(ByRef oActividadRecurrente As Entidades.ActividadRecurrenteBE) As Integer Implements Interfaces.IActividadRecurrente.ActualizarActividadRecurrente
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD_RECURRENTE", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = oActividadRecurrente.id_actividad_recurrente
            sqlCmd.Parameters.Add("@tipo", SqlDbType.Char).Value = IIf(oActividadRecurrente.tipo Is Nothing, DBNull.Value, oActividadRecurrente.tipo)
            sqlCmd.Parameters.Add("@num_rep", SqlDbType.Bit).Value = IIf(oActividadRecurrente.num_rep Is Nothing, DBNull.Value, oActividadRecurrente.num_rep)
            sqlCmd.Parameters.Add("@chk_dom", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_dom Is Nothing, DBNull.Value, oActividadRecurrente.chk_dom)
            sqlCmd.Parameters.Add("@chk_lun", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_lun Is Nothing, DBNull.Value, oActividadRecurrente.chk_lun)
            sqlCmd.Parameters.Add("@chk_mar", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mar Is Nothing, DBNull.Value, oActividadRecurrente.chk_mar)
            sqlCmd.Parameters.Add("@chk_mie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mie Is Nothing, DBNull.Value, oActividadRecurrente.chk_mie)
            sqlCmd.Parameters.Add("@chk_jue", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_jue Is Nothing, DBNull.Value, oActividadRecurrente.chk_jue)
            sqlCmd.Parameters.Add("@chk_vie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_vie Is Nothing, DBNull.Value, oActividadRecurrente.chk_vie)
            sqlCmd.Parameters.Add("@chk_sab", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_sab Is Nothing, DBNull.Value, oActividadRecurrente.chk_sab)
            sqlCmd.Parameters.Add("@dia_mes", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_mes Is Nothing, DBNull.Value, oActividadRecurrente.dia_mes)
            sqlCmd.Parameters.Add("@ordinal", SqlDbType.Int).Value = IIf(oActividadRecurrente.ordinal Is Nothing, DBNull.Value, oActividadRecurrente.ordinal)
            sqlCmd.Parameters.Add("@dia_semana", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_semana Is Nothing, DBNull.Value, oActividadRecurrente.dia_semana)
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = IIf(oActividadRecurrente.fecha_fin Is Nothing, DBNull.Value, oActividadRecurrente.fecha_fin)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.id_sede Is Nothing, DBNull.Value, oActividadRecurrente.id_sede)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oActividadRecurrente.id_lugar Is Nothing, DBNull.Value, oActividadRecurrente.id_lugar)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividadRecurrente.vacantes Is Nothing, DBNull.Value, oActividadRecurrente.vacantes)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_ini Is Nothing, DBNull.Value, oActividadRecurrente.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_fin Is Nothing, DBNull.Value, oActividadRecurrente.hora_fin)

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

        Public Function BorrarActividadRecurrente(ByVal id_actividad_recurrente As Integer) As Integer Implements Interfaces.IActividadRecurrente.BorrarActividadRecurrente
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDAD_RECURRENTE", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = id_actividad_recurrente

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

