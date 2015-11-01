Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PresupuestoGastosDL
        Implements IPresupuestoGastos



#Region "Select"

        Public Function ListarPresupuestoGastos(ByVal id_plan As Integer, ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.PresupuestoGastosBE) Implements Interfaces.IPresupuestoGastos.ListarPresupuestoGastos
            Dim oListadoPresupuestoGastos As New List(Of PresupuestoGastosBE)
            Dim oPresupuestoGastos As PresupuestoGastosBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_GASTOS_PRESUPUESTO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPresupuestoGastos = New PresupuestoGastosBE
                    oPresupuestoGastos.id_item = dr("id_recurso")
                    oPresupuestoGastos.monto = CDbl(dr("monto"))
                    oPresupuestoGastos.monto_pres = CDbl(dr("monto"))
                    oPresupuestoGastos.recurso = dr("descripcion")
                    oListadoPresupuestoGastos.Add(oPresupuestoGastos)
                End While
                dr.Close()
                Return oListadoPresupuestoGastos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarPresupuestoGastos(ByRef oPresupuestoGastos As Entidades.PresupuestoGastosBE) As Integer Implements Interfaces.IPresupuestoGastos.InsertarPresupuestoGastos
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_GASTO_PRES", sqlConn)

            Dim recordId As Integer

            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.Add("@id_presupuesto", SqlDbType.Int).Value = oPresupuestoGastos.id_presupuesto
            sqlCmd.Parameters.Add("@id_item", SqlDbType.VarChar).Value = oPresupuestoGastos.id_item
            sqlCmd.Parameters.Add("@monto", SqlDbType.Money).Value = oPresupuestoGastos.monto
            sqlCmd.Parameters.Add("@monto_pres", SqlDbType.Money).Value = oPresupuestoGastos.monto_pres

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

    End Class

End Namespace

