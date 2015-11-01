Namespace SGS.Model.Entidades

    Public Class AsociadoBE

        Private _id_socio As String
        Private _id_accion As String
        Private _id_persona As String
        Private _condicion As String
        Private _Persona As PersonaBE

        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Public Property id_accion() As String
            Get
                Return _id_accion
            End Get
            Set(ByVal value As String)
                _id_accion = value
            End Set
        End Property


        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Public Property condicion() As String
            Get
                Return _condicion
            End Get
            Set(ByVal value As String)
                _condicion = value
            End Set
        End Property

        Public Property Persona() As PersonaBE
            Get
                Return _Persona
            End Get
            Set(ByVal value As PersonaBE)
                _Persona = value
            End Set
        End Property

        Public Property persona_fec_nac_per As Date
        Public Property persona_dni_per As String
        Public Property persona_nombre_completo As String
    End Class

End Namespace

