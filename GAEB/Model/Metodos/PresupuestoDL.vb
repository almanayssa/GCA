Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class PresupuestoDL
        Implements IPresupuesto


#Region "Select"

#End Region

#Region "Insert"

        Public Function InsertarPresupuesto(ByRef oPresupuesto As Entidades.PresupuestoBE) As Integer Implements Interfaces.IPresupuesto.InsertarPresupuesto
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PRESUPUESTO", sqlConn)

            Dim recordId As Integer

            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.Add("@id_plananual_comite", SqlDbType.Int).Value = oPresupuesto.id_plananual_comite
            sqlCmd.Parameters.Add("@ingreso_act", SqlDbType.Money).Value = oPresupuesto.ingreso_act
            sqlCmd.Parameters.Add("@ingreso_otros", SqlDbType.Money).Value = oPresupuesto.ingreso_otros
            sqlCmd.Parameters.Add("@gastos", SqlDbType.Money).Value = oPresupuesto.gastos
            sqlCmd.Parameters.Add("@monto_pres", SqlDbType.Money).Value = oPresupuesto.monto_pres

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

