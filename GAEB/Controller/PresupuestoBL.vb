Imports SGS.Model.Entidades
Imports SGS.Model.Interfaces
Imports SGS.Model.Metodos

Namespace SGS.Controller

    Partial Public Class BusinessController

#Region "Insert"

        Public Function InsertarPresupuesto(ByRef oPresupuesto As PresupuestoBE) As Integer
            Try

                Dim id_presupuesto As Integer

                Dim iPresupuesto As IPresupuesto
                iPresupuesto = New PresupuestoDL

                Dim iPresupuestogas As IPresupuestoGastos
                iPresupuestogas = New PresupuestoGastosDL

                id_presupuesto = iPresupuesto.InsertarPresupuesto(oPresupuesto)

                

                If oPresupuesto.ListaGastos IsNot Nothing Then
                    For Each oPresgasto As PresupuestoGastosBE In oPresupuesto.ListaGastos
                        oPresgasto.id_presupuesto = id_presupuesto
                        iPresupuestogas.InsertarPresupuestoGastos(oPresgasto)
                    Next
                End If


                oPresupuesto.id_presupuesto = id_presupuesto

                Return oPresupuesto.id_presupuesto

            Catch ex As Exception
                Return Nothing
            End Try
        
        End Function

#End Region

    End Class

End Namespace

