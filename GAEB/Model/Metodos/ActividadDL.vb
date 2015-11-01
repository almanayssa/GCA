Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class ActividadDL
        Implements IActividad


#Region "Select"

        Public Function ObtenerActividad(ByVal id_actividad As Integer) As Entidades.ActividadBE Implements Interfaces.IActividad.ObtenerActividad
            Dim oActividad As New ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(3)
                    oActividad.hora_fin = dr.GetTimeSpan(4)
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.dias_registro = dr("dias_registro")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividad.des_sede = dr("des_sede")
                    oActividad.nom_lug = dr("nom_lug")
                    oActividad.direccion = dr("direccion")
                    oActividad.des_urbanizacion = dr("des_urbanizacion")
                    oActividad.des_cal = dr("des_cal")
                    oActividad.des_dis = dr("des_dis")
                    oActividad.des_reg = dr("des_reg")
                    oActividad.fec_registro = dr("fec_registro")
                End If
                dr.Close()
                Return oActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividades
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(id_comite = "000", DBNull.Value, id_comite)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(4)
                    oActividad.hora_fin = dr.GetTimeSpan(5)
                    oActividad.id_comite = dr("id_comite")
                    oActividad.nombreComite = dr("nombreComite")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesAInscribir(ByVal id_comite As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesAInscribir
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_INSCRIBIR", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.hora_ini = dr("hora_ini")
                    oActividad.fec_fin = IIf(IsDBNull(dr("fec_fin")), Nothing, dr("fec_fin"))
                    oActividad.hora_fin = dr("hora_fin")
                    oActividad.nombreComite = dr("nombrecomite")
                    oActividad.monto_pago = IIf(dr("monto_pago") Is DBNull.Value, 0, dr("monto_pago"))
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")

                    If oActividad.id_actividad_recurrente IsNot Nothing Then
                        Dim oActividadRecurrente As New ActividadRecurrenteBE
                        oActividadRecurrente.tipo = dr("tipo")
                        oActividadRecurrente.num_rep = dr("num_rep")
                        oActividadRecurrente.chk_dom = dr("chk_dom")
                        oActividadRecurrente.chk_lun = dr("chk_lun")
                        oActividadRecurrente.chk_mar = dr("chk_mar")
                        oActividadRecurrente.chk_mie = dr("chk_mie")
                        oActividadRecurrente.chk_jue = dr("chk_jue")
                        oActividadRecurrente.chk_vie = dr("chk_vie")
                        oActividadRecurrente.chk_sab = dr("chk_sab")
                        oActividadRecurrente.dia_mes = dr("dia_mes")
                        oActividadRecurrente.ordinal = dr("ordinal")
                        oActividadRecurrente.dia_semana = dr("dia_semana")
                        oActividadRecurrente.fecha_fin = dr("fecha_fin")
                        oActividadRecurrente.id_sede = dr("id_sede")
                        oActividadRecurrente.id_lugar = dr("id_lugar")
                        oActividadRecurrente.vacantes = dr("vacantes")
                        oActividadRecurrente.hora_ini = dr.GetTimeSpan(35) 'dr("hora_ini")
                        oActividadRecurrente.hora_fin = dr.GetTimeSpan(36) 'dr("hora_fin")
                        oActividad.ActividadRecurrente = oActividadRecurrente
                    End If

                    oListadoActividades.Add(oActividad)


                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function CargarActividadCabecera(ByVal id_actividad As Integer) As Entidades.ActividadBE Implements Interfaces.IActividad.CargarActividadCabecera
            Dim oActividad As New ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_CARGAR_ACTIVIDAD_CABECERA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr.GetTimeSpan(4) 'dr("hora_fin")
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.id_comite = dr("id_comite")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.nombre = dr("nombre")
                    oActividad.flg_plan_anual = dr("flg_plan_anual")
                    oActividad.flg_registro = dr("flg_registro")
                    oActividad.dias_registro = dr("dias_registro")
                    oActividad.flg_web = dr("flg_web")
                    oActividad.dias_web = dr("dias_web")
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))

                    If oActividad.id_actividad_recurrente IsNot Nothing Then
                        Dim oActividadRecurrente As New ActividadRecurrenteBE
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
                        oActividadRecurrente.hora_ini = dr.GetTimeSpan(35) 'dr("hora_ini")
                        oActividadRecurrente.hora_fin = dr.GetTimeSpan(36) 'dr("hora_fin")
                        oActividadRecurrente.id_tipo_lugar = dr("id_tipo")
                        oActividad.ActividadRecurrente = oActividadRecurrente
                    End If

                End If
                dr.Close()
                Return oActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesPorComite_TipoActividad(ByVal comiteID As String, ByVal tipoActividadID As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesPorComite_TipoActividad
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)

            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_POR_COMITE_TIPOACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing


            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = comiteID
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = tipoActividadID

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_plan_anual_comite = IIf(dr("id_plananual_comite") Is DBNull.Value, 0, dr("id_plananual_comite"))
                    oActividad.id_actividad = IIf(dr("id_actividad") Is DBNull.Value, String.Empty, dr("id_actividad"))
                    oActividad.id_comite = IIf(dr("id_comite") Is DBNull.Value, String.Empty, dr("id_comite"))
                    oActividad.id_tipo_act = IIf(dr("id_tipo_act") Is DBNull.Value, String.Empty, dr("id_tipo_act"))
                    oActividad.descripcion = IIf(dr("descripcion") Is DBNull.Value, String.Empty, dr("descripcion"))
                    oActividad.QueryTipoActividad = IIf(dr("desc_tipo") Is DBNull.Value, String.Empty, dr("desc_tipo"))
                    oActividad.QueryNombreSede = IIf(dr("Sede") Is DBNull.Value, String.Empty, dr("Sede"))
                    oActividad.QueryNombreLugar = IIf(dr("nombre") Is DBNull.Value, String.Empty, dr("nombre"))
                    oActividad.QueryVacantes = IIf(dr("vacantes") Is DBNull.Value, String.Empty, dr("vacantes"))
                    oActividad.QueryTipo = IIf(dr("tipo") Is DBNull.Value, String.Empty, dr("tipo"))


                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesNoRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesNoRecurrentes
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)

            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_NO_RECURRENTES", sqlConn)
            Dim dr As SqlDataReader = Nothing

            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@diaCalendario", SqlDbType.Date).Value = IIf(diaCalendario = Nothing, DBNull.Value, diaCalendario)
            sqlCmd.Parameters.Add("@diaInicio", SqlDbType.Date).Value = IIf(diaInicio = Nothing, DBNull.Value, diaInicio)
            sqlCmd.Parameters.Add("@diaFin", SqlDbType.Date).Value = IIf(diaFin = Nothing, DBNull.Value, diaFin)

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr.GetTimeSpan(4) 'dr("hora_fin")
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.nombre = dr("nombre")
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividad.flg_registro = dr("flg_registro")
                    oActividad.fec_registro = dr("fec_registro")
                    oActividad.flg_web = dr("flg_web")
                    oActividad.fec_web = dr("fec_web")
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")
                    oActividad.nombreComite = dr("nom_comite")
                    oActividad.tipo_act = dr("tipo_act")
                    oActividad.cat_act = IIf(dr("cat_act") Is DBNull.Value, Nothing, dr("cat_act"))

                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesRecurrentes(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesRecurrentes
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)

            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_RECURRENTES", sqlConn)
            Dim dr As SqlDataReader = Nothing

            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@diaCalendario", SqlDbType.Date).Value = IIf(diaCalendario = Nothing, DBNull.Value, diaCalendario)
            sqlCmd.Parameters.Add("@diaInicio", SqlDbType.Date).Value = IIf(diaInicio = Nothing, DBNull.Value, diaInicio)
            sqlCmd.Parameters.Add("@diaFin", SqlDbType.Date).Value = IIf(diaFin = Nothing, DBNull.Value, diaFin)

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr.GetTimeSpan(4) 'dr("hora_fin")
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.nombre = dr("nombre")
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividad.flg_registro = dr("flg_registro")
                    oActividad.fec_registro = dr("fec_registro")
                    oActividad.flg_web = dr("flg_web")
                    oActividad.fec_web = dr("fec_web")
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")
                    oActividad.nombreComite = dr("nom_comite")
                    oActividad.tipo_act = dr("tipo_act")
                    oActividad.cat_act = IIf(dr("cat_act") Is DBNull.Value, Nothing, dr("cat_act"))

                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesPlan(ByVal id_plananual_comite As Integer) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesPlan
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_PLAN_COMITE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plananual_comite", SqlDbType.Int).Value = id_plananual_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(8)
                    'oActividad.hora_fin = dr.GetTimeSpan(10)
                    oActividad.id_comite = dr("id_comite")
                    oActividad.QueryTipoActividad = dr("desc_tipo")
                    oActividad.cat_act = dr("categoria")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesEstado(ByVal id_comite As String, ByVal nombre As String, ByVal estado As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesEstado
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_ESTADO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
            sqlCmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.hora_ini = dr("hora_ini")
                    oActividad.fec_fin = dr("fec_fin")
                    oActividad.hora_fin = dr("hora_fin")
                    oActividad.id_comite = dr("id_comite")
                    oActividad.nombreComite = dr("nombreComite")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function
#End Region

#Region "Insert"

        Public Function InsertarPlanAnual(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.InsertarPlanAnual

            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_TB_Maestro_Plan_Anual", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividad.descripcion Is Nothing, DBNull.Value, oActividad.descripcion)
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = oActividad.fec_fin
            sqlCmd.Parameters.Add("@fec_lim_pres", SqlDbType.DateTime).Value = oActividad.fec_lim_pres

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

        Public Function InsertarPlanAnualComite(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.InsertarPlanAnualComite

            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_TB_Plan_Anual_Comite", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = oActividad.id_plan_anual
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = oActividad.id_comite

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

        Public Function InsertarPlanAnualComiteDetalle(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.InsertarPlanAnualComiteDetalle

            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_TB_Plan_Anual_Comite_Actividad", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan_anual_comite", SqlDbType.Int).Value = oActividad.id_plan_anual_comite
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad

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

        Public Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer Implements IActividad.InsertarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = IIf(oActividad.fec_ini Is Nothing, DBNull.Value, oActividad.fec_ini)
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = IIf(oActividad.fec_fin Is Nothing, DBNull.Value, oActividad.fec_fin)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividad.hora_ini Is Nothing, DBNull.Value, oActividad.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividad.hora_fin Is Nothing, DBNull.Value, oActividad.hora_fin)
            sqlCmd.Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = IIf(oActividad.monto_pago Is Nothing, DBNull.Value, oActividad.monto_pago)
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = IIf(oActividad.id_estado Is Nothing, DBNull.Value, oActividad.id_estado)
            sqlCmd.Parameters.Add("@id_cattipo_act", SqlDbType.Int).Value = IIf(oActividad.id_cattipo_act Is Nothing, DBNull.Value, oActividad.id_cattipo_act)
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = IIf(oActividad.id_comite Is Nothing, DBNull.Value, oActividad.id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(oActividad.id_tipo_act Is Nothing, DBNull.Value, oActividad.id_tipo_act)
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividad.descripcion Is Nothing, DBNull.Value, oActividad.descripcion)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oActividad.nombre Is Nothing, DBNull.Value, oActividad.nombre)
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = IIf(oActividad.id_actividad_recurrente Is Nothing, DBNull.Value, oActividad.id_actividad_recurrente)
            sqlCmd.Parameters.Add("@flg_plan_anual", SqlDbType.Bit).Value = IIf(oActividad.flg_plan_anual Is Nothing, DBNull.Value, oActividad.flg_plan_anual)
            sqlCmd.Parameters.Add("@flg_registro", SqlDbType.Bit).Value = IIf(oActividad.flg_registro Is Nothing, DBNull.Value, oActividad.flg_registro)
            sqlCmd.Parameters.Add("@dias_registro", SqlDbType.Int).Value = IIf(oActividad.dias_registro Is Nothing, DBNull.Value, oActividad.dias_registro)
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.Bit).Value = IIf(oActividad.flg_web Is Nothing, DBNull.Value, oActividad.flg_web)
            sqlCmd.Parameters.Add("@dias_web", SqlDbType.Int).Value = IIf(oActividad.dias_web Is Nothing, DBNull.Value, oActividad.dias_web)
            sqlCmd.Parameters.Add("@tipo_inscripcion", SqlDbType.Char).Value = IIf(oActividad.tipo_inscripcion Is Nothing, DBNull.Value, oActividad.tipo_inscripcion)

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

        Public Function InsertarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer Implements IActividad.InsertarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD_DETALLE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividadDetalle.id_actividad
            sqlCmd.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = oActividadDetalle.fecha_ini
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = oActividadDetalle.hora_ini
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = oActividadDetalle.fecha_fin
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = oActividadDetalle.hora_fin
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = oActividadDetalle.id_sede
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = oActividadDetalle.id_lugar
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = oActividadDetalle.vacantes

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

        Public Function InsertarTipoPersonalXActividad(ByRef oTipoPersonal As TipoPersonalBE) As Integer Implements IActividad.InsertarTipoPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_TIPOPERSONAL_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oTipoPersonal.id_actividad
            sqlCmd.Parameters.Add("@id_tipo_personal", SqlDbType.Int).Value = oTipoPersonal.id_tipo_personal
            sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = oTipoPersonal.cantidad

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

        Public Function InsertarRecursoXActividad(ByRef oRecurso As RecursoBE) As Integer Implements IActividad.InsertarRecursoXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_RECURSO_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oRecurso.id_actividad
            sqlCmd.Parameters.Add("@id_recurso", SqlDbType.Int).Value = oRecurso.id_recurso
            sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = oRecurso.cantidad

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

        Public Function InsertarRestriccionXActividad(ByRef oRestriccion As RestriccionBE) As Integer Implements IActividad.InsertarRestriccionXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_RESTRICCION_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_restriccion", SqlDbType.Int).Value = oRestriccion.id_restriccion
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oRestriccion.id_actividad
            sqlCmd.Parameters.Add("@id_signo", SqlDbType.Int).Value = IIf(oRestriccion.id_signo = Nothing, DBNull.Value, oRestriccion.id_signo)
            sqlCmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = IIf(oRestriccion.valor Is Nothing, DBNull.Value, oRestriccion.valor)

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

        Public Function InsertarPersonalXActividad(ByRef oPersonal As Entidades.PersonalBE) As Integer Implements Interfaces.IActividad.InsertarPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PERSONAL_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oPersonal.id_actividad
            sqlCmd.Parameters.Add("@id_personal", SqlDbType.Int).Value = oPersonal.id_personal

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

        Public Function ActualizarActividad(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.ActualizarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = IIf(oActividad.fec_ini Is Nothing, DBNull.Value, oActividad.fec_ini)
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = IIf(oActividad.fec_fin Is Nothing, DBNull.Value, oActividad.fec_fin)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividad.hora_ini Is Nothing, DBNull.Value, oActividad.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividad.hora_fin Is Nothing, DBNull.Value, oActividad.hora_fin)
            sqlCmd.Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = IIf(oActividad.monto_pago Is Nothing, DBNull.Value, oActividad.monto_pago)
            sqlCmd.Parameters.Add("@id_cattipo_act", SqlDbType.Int).Value = IIf(oActividad.id_cattipo_act Is Nothing, DBNull.Value, oActividad.id_cattipo_act)
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = IIf(oActividad.id_comite Is Nothing, DBNull.Value, oActividad.id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(oActividad.id_tipo_act Is Nothing, DBNull.Value, oActividad.id_tipo_act)
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividad.descripcion Is Nothing, DBNull.Value, oActividad.descripcion)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oActividad.nombre Is Nothing, DBNull.Value, oActividad.nombre)
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = IIf(oActividad.id_actividad_recurrente Is Nothing, DBNull.Value, oActividad.id_actividad_recurrente)
            sqlCmd.Parameters.Add("@flg_plan_anual", SqlDbType.Bit).Value = IIf(oActividad.flg_plan_anual Is Nothing, DBNull.Value, oActividad.flg_plan_anual)
            sqlCmd.Parameters.Add("@flg_registro", SqlDbType.Bit).Value = IIf(oActividad.flg_registro Is Nothing, DBNull.Value, oActividad.flg_registro)
            sqlCmd.Parameters.Add("@dias_registro", SqlDbType.Int).Value = IIf(oActividad.dias_registro Is Nothing, DBNull.Value, oActividad.dias_registro)
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.Bit).Value = IIf(oActividad.flg_web Is Nothing, DBNull.Value, oActividad.flg_web)
            sqlCmd.Parameters.Add("@dias_web", SqlDbType.Int).Value = IIf(oActividad.dias_web Is Nothing, DBNull.Value, oActividad.dias_web)
            sqlCmd.Parameters.Add("@tipo_inscripcion", SqlDbType.Char).Value = IIf(oActividad.tipo_inscripcion Is Nothing, DBNull.Value, oActividad.tipo_inscripcion)

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

        Public Function AprobarActividad(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.AprobarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_APROBAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            If oActividad.accion = 1 Then sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = "EST004"
            If oActividad.accion = 2 Then sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = "EST006"

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

        Public Function HabilitarActividad(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.HabilitarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_APROBAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = "EST005"

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

        Public Function ActualizarRecursosXActividad(ByRef oRecurso As Entidades.RecursoBE) As Integer Implements Interfaces.IActividad.ActualizarRecursosXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_MODIFICAR_CANTIDADREAL_RECURSO_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oRecurso.id_actividad
            sqlCmd.Parameters.Add("@id_recurso", SqlDbType.Int).Value = oRecurso.id_recurso
            sqlCmd.Parameters.Add("@cantidadreal", SqlDbType.Int).Value = oRecurso.cantidadreal
            
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

        Public Function BorrarActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

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

        Public Function BorrarTipoPersonalXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarTipoPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_TIPOPERSONAL_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

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

        Public Function BorrarRecursosXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarRecursosXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_RECURSO_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

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

        Public Function BorrarRestriccionesXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarRestriccionesXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_RESTRICCION_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

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

        Public Function BorrarActividadesPlanAnualComite(ByVal id_plananual_comite As Integer) As Integer Implements Interfaces.IActividad.BorrarActividadesPlanAnualComite
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDADES_PLAN_ANUAL_COMITE", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plananual_comite", SqlDbType.Int).Value = id_plananual_comite

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

