Namespace SGS.Model.Entidades

    Public Class InvitadoBE

        Private _id_invitado As String
        Private _dni_inv As String
        Private _nom_inv As String
        Private _ape_pat_inv As String
        Private _ape_mat_inv As String
        Private _sexo_inv As String
        Private _fec_reg As Date
        Private _id_socio As String
        Private _sede_reg As String
        Private _fec_nac As Date
        Private _flg_modificado As Boolean
        Private _id_tipo_doc As String
        Private _flg_anulado As Boolean
        Private _nombre_completo As String

        Public Property id_invitado() As String
            Get
                Return _id_invitado
            End Get
            Set(ByVal value As String)
                _id_invitado = value
            End Set
        End Property

        Public Property dni_inv() As String
            Get
                Return _dni_inv
            End Get
            Set(ByVal value As String)
                _dni_inv = value
            End Set
        End Property

        Public Property nom_inv() As String
            Get
                Return _nom_inv
            End Get
            Set(ByVal value As String)
                _nom_inv = value
            End Set
        End Property

        Public Property ape_pat_inv() As String
            Get
                Return _ape_pat_inv
            End Get
            Set(ByVal value As String)
                _ape_pat_inv = value
            End Set
        End Property

        Public Property ape_mat_inv() As String
            Get
                Return _ape_mat_inv
            End Get
            Set(ByVal value As String)
                _ape_mat_inv = value
            End Set
        End Property

        Public Property sexo_inv() As String
            Get
                Return _sexo_inv
            End Get
            Set(ByVal value As String)
                _sexo_inv = value
            End Set
        End Property

        Public Property fec_reg() As Date
            Get
                Return _fec_reg
            End Get
            Set(ByVal value As Date)
                _fec_reg = value
            End Set
        End Property

        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Public Property sede_reg() As String
            Get
                Return _sede_reg
            End Get
            Set(ByVal value As String)
                _sede_reg = value
            End Set
        End Property

        Public Property fec_nac() As Date
            Get
                Return _fec_nac
            End Get
            Set(ByVal value As Date)
                _fec_nac = value
            End Set
        End Property

        Public Property flg_modificado() As Boolean
            Get
                Return _flg_modificado
            End Get
            Set(ByVal value As Boolean)
                _flg_modificado = value
            End Set
        End Property

        Public Property id_tipo_doc() As String
            Get
                Return _id_tipo_doc
            End Get
            Set(ByVal value As String)
                _id_tipo_doc = value
            End Set
        End Property

        Public Property flg_anulado() As Boolean
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As Boolean)
                _flg_anulado = value
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

    End Class

End Namespace


