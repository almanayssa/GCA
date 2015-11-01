Namespace SGS.Model.Entidades

    Public Class PersonaBE

        Private _id_persona As String
        Private _nom_per As String
        Private _ape_pat As String
        Private _ape_mat As String
        Private _direccion As String
        Private _fec_nac_per As Date
        Private _dni_per As String
        Private _nombre_completo As String
        Private _tipo_familiar As String
        Private _id_inscripcion As String

        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Public Property nom_per() As String
            Get
                Return _nom_per
            End Get
            Set(ByVal value As String)
                _nom_per = value
            End Set
        End Property

        Public Property ape_pat() As String
            Get
                Return _ape_pat
            End Get
            Set(ByVal value As String)
                _ape_pat = value
            End Set
        End Property

        Public Property ape_mat() As String
            Get
                Return _ape_mat
            End Get
            Set(ByVal value As String)
                _ape_mat = value
            End Set
        End Property

        Public Property direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property

        Public Property fec_nac_per() As Date
            Get
                Return _fec_nac_per
            End Get
            Set(ByVal value As Date)
                _fec_nac_per = value
            End Set
        End Property

        Public Property dni_per() As String
            Get
                Return _dni_per
            End Get
            Set(ByVal value As String)
                _dni_per = value
            End Set
        End Property

        Public Property nombre_completo() As String
            Get
                Return _nombre_completo
            End Get
            Set(ByVal value As String)
                _nombre_completo = value
            End Set
        End Property

        Public Property tipo_familiar() As String
            Get
                Return _tipo_familiar
            End Get
            Set(ByVal value As String)
                _tipo_familiar = value
            End Set
        End Property

        Public Property id_inscripcion() As String
            Get
                Return _id_inscripcion
            End Get
            Set(ByVal value As String)
                _id_inscripcion = value
            End Set
        End Property

    End Class

End Namespace


