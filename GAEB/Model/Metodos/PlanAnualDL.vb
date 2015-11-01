Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PlanAnualDL
        Implements IPlanAnual

#Region "Select"

        Public Function ListarPlanesAnual() As System.Collections.Generic.List(Of Entidades.PlanAnualBE) Implements Interfaces.IPlanAnual.ListarPlanesAnual
            Dim oListadoPlanesAnual As New List(Of PlanAnualBE)
            Dim oPlanAnual As PlanAnualBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLAN_ANUAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPlanAnual = New PlanAnualBE
                    oPlanAnual.id_plan = dr("id_plan")
                    oPlanAnual.descripcion = dr("descripcion")
                    oPlanAnual.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oPlanAnual.fec_fin = dr("fec_fin")
                    oPlanAnual.fec_lim_pres = dr("fec_lim_pres")
                    oPlanAnual.año = dr("año")
                    oListadoPlanesAnual.Add(oPlanAnual)
                End While
                dr.Close()
                Return oListadoPlanesAnual
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

