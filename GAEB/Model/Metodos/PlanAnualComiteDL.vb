Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PlanAnualComiteDL
        Implements IPlanAnualComite

#Region "Select"

        Public Function ListarPlanesAnualComite(ByVal id_plan As Integer) As System.Collections.Generic.List(Of Entidades.PlanAnualComiteBE) Implements Interfaces.IPlanAnualComite.ListarPlanesAnualComite
            Dim oListadoPlanesAnualComite As New List(Of PlanAnualComiteBE)
            Dim oPlanAnualComite As PlanAnualComiteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLAN_ANUAL_COMITE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPlanAnualComite = New PlanAnualComiteBE
                    oPlanAnualComite.id_plananual_comite = dr("id_plananual_comite")
                    oPlanAnualComite.id_plan = dr("id_plan")
                    oPlanAnualComite.id_comite = dr("id_comite")
                    oPlanAnualComite.comite = dr("nombre")
                    oPlanAnualComite.fec_reg = dr("fec_reg")
                    oPlanAnualComite.nombre_plan = dr("descripcion")
                    oListadoPlanesAnualComite.Add(oPlanAnualComite)
                End While
                dr.Close()
                Return oListadoPlanesAnualComite
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerPlanAnualComite(ByVal id_plan As Integer, ByVal id_comite As String) As PlanAnualComiteBE Implements Interfaces.IPlanAnualComite.ObtenerPlanAnualComite
            Dim oListadoPlanesAnualComite As New List(Of PlanAnualComiteBE)
            Dim oPlanAnualComite As New PlanAnualComiteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLAN_COMITE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oPlanAnualComite = New PlanAnualComiteBE
                    oPlanAnualComite.id_plananual_comite = dr("id_plananual_comite")
                    oPlanAnualComite.id_comite = dr("id_comite")
                    oPlanAnualComite.fec_reg = dr("fec_reg")
                    oPlanAnualComite.id_presupuesto = dr("id_presupuesto")
                End If
                dr.Close()
                Return oPlanAnualComite
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

