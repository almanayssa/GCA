Imports SGS.Model.Interfaces
Imports SGS.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGS.Model.Metodos

    Public Class CategoriaActividadDL
        Implements ICategoriaActividad

#Region "Select"

        Public Function ListarCategoriaActividad(ByVal id_tipo_act As String) As System.Collections.Generic.List(Of Entidades.CategoriaActividadBE) Implements Interfaces.ICategoriaActividad.ListarCategoriaActividad
            Dim oListadoCategoriaActividad As New List(Of CategoriaActividadBE)
            Dim oCategoria As CategoriaActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGS").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_CATEGORIAS_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = id_tipo_act

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oCategoria = New CategoriaActividadBE
                    oCategoria.id_cattipo_act = dr("id_cattipo_act")
                    oCategoria.descripcion = dr("descripcion")
                    oListadoCategoriaActividad.Add(oCategoria)
                End While
                dr.Close()
                Return oListadoCategoriaActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

