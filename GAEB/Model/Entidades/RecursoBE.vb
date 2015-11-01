Namespace SGS.Model.Entidades

    Public Class RecursoBE

        Private _id_recurso As Integer
        Private _descripcion As String
        Private _cantidad As Integer
        Private _id_actividad As Integer
        Private _cantidadreal As Integer?

        Public Property id_recurso() As Integer
            Get
                Return _id_recurso
            End Get
            Set(ByVal value As Integer)
                _id_recurso = value
            End Set
        End Property

        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Public Property cantidad() As Integer
            Get
                Return _cantidad
            End Get
            Set(ByVal value As Integer)
                _cantidad = value
            End Set
        End Property

        Public Property id_actividad() As String
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As String)
                _id_actividad = value
            End Set
        End Property

        Public Property cantidadreal() As Integer?
            Get
                Return _cantidadreal
            End Get
            Set(ByVal value As Integer?)
                _cantidadreal = value
            End Set
        End Property

    End Class

End Namespace

