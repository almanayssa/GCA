Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class RestriccionDL
        Implements IRestriccion

#Region "Select"

        Public Function ListarRestricciones() As System.Collections.Generic.List(Of Entidades.RestriccionBE) Implements Interfaces.IRestriccion.ListarRestricciones
            Dim oListadoRestricciones As New List(Of RestriccionBE)
            Dim oRestriccion As RestriccionBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RESTRICCIONES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRestriccion = New RestriccionBE
                    oRestriccion.id_restriccion = dr("id_restriccion")
                    oRestriccion.descripcion = dr("descripcion")
                    oRestriccion.flg_condicion = dr("flg_condicion")
                    oListadoRestricciones.Add(oRestriccion)
                End While
                dr.Close()
                Return oListadoRestricciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.RestriccionBE) Implements Interfaces.IRestriccion.ListarRestriccionesXActividad
            Dim oListadoRestricciones As New List(Of RestriccionBE)
            Dim oRestriccion As RestriccionBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RESTRICCIONES_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.VarChar).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRestriccion = New RestriccionBE
                    oRestriccion.id_restriccion = dr("id_restriccion")
                    oRestriccion.descripcion = dr("descripcion")
                    oRestriccion.id_signo = dr("id_signo")
                    oRestriccion.valor = dr("valor")
                    oListadoRestricciones.Add(oRestriccion)
                End While
                dr.Close()
                Return oListadoRestricciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerCantidadXRestriccion(ByVal id_actividad As Integer, ByVal id_restriccion As Integer, ByVal id_socio As String, ByVal id_persona As String, ByVal id_invitado As String) As String Implements Interfaces.IRestriccion.ObtenerCantidadXRestriccion
            Dim resul As String = ""
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_SELECCIONAR_RESTRICCIONES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.VarChar).Value = id_actividad
            sqlCmd.Parameters.Add("@id_restriccion", SqlDbType.VarChar).Value = id_restriccion
            If id_socio IsNot Nothing Then sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = id_socio
            If id_persona IsNot Nothing Then sqlCmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = id_persona
            If id_socio IsNot Nothing Then sqlCmd.Parameters.Add("@id_invitado", SqlDbType.VarChar).Value = id_invitado

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    resul = dr("result")
                End If
                dr.Close()
                Return resul
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region
        
    End Class

End Namespace



