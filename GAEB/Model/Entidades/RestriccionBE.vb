Namespace SGS.Model.Entidades

    Public Class RestriccionBE

        Private _id_restriccion As Integer
        Private _descripcion As String
        Private _flg_condicion As Boolean
        Private _consulta As String
        Private _mensaje As String
        Private _id_signo As Integer
        Private _valor As String
        Private _id_actividad As Integer

        Public Property id_restriccion() As Integer
            Get
                Return _id_restriccion
            End Get
            Set(ByVal value As Integer)
                _id_restriccion = value
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

        Public Property flg_condicion() As Boolean
            Get
                Return _flg_condicion
            End Get
            Set(ByVal value As Boolean)
                _flg_condicion = value
            End Set
        End Property

        Public Property consulta() As String
            Get
                Return _consulta
            End Get
            Set(ByVal value As String)
                _consulta = value
            End Set
        End Property

        Public Property mensaje() As String
            Get
                Return _mensaje
            End Get
            Set(ByVal value As String)
                _mensaje = value
            End Set
        End Property

        Public Property id_signo() As Integer
            Get
                Return _id_signo
            End Get
            Set(ByVal value As Integer)
                _id_signo = value
            End Set
        End Property

        Public Property valor() As String
            Get
                Return _valor
            End Get
            Set(ByVal value As String)
                _valor = value
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

    End Class

End Namespace

