Module Modulo_Parametros

    Private _tipo_cambio As Double = 0.0
    Private _valor_igv As Double
    Private _modulo_activo As frmPadre 'System.Windows.Forms.Form
    Private _area As String
    Private _caja As String 'va contener el código del punto de Emisión de Documentos
    Private _codSede As String = ""
    Private _nomSede As String
    'Private _modulo_activo As SGS_El_Bosque.frmPadre 'System.Windows.Forms.Form
    Public strUsuario As String
    Private _Gasto As Double
    Private _id_usuario As String
    Private _area_usuario As String
    Private _punto_emision As String
    Private _cod_punto_emision As String
    Private _cant_inv_lib As Integer
    Private _est_usuario As String
    Private _NoPerfilReclamaciones As String

    Public Property tipo_cambio()
        Get
            Return _tipo_cambio
        End Get
        Set(ByVal value)
            _tipo_cambio = value
        End Set
    End Property

    Public Property area_usuario()
        Get
            Return _area_usuario
        End Get
        Set(ByVal value)
            _area_usuario = value
        End Set
    End Property

    Public Property id_usuario()
        Get
            Return _id_usuario
        End Get
        Set(ByVal value)
            _id_usuario = value
        End Set
    End Property

    Public Property gasto()
        Get
            Return _Gasto
        End Get
        Set(ByVal value)
            _Gasto = value
        End Set
    End Property

    Public Property valor_igv()
        Get
            Return _valor_igv
        End Get
        Set(ByVal value)
            _valor_igv = value
        End Set
    End Property

    Public Property modulo_activo()
        Get
            Return _modulo_activo
        End Get
        Set(ByVal value)
            _modulo_activo = value
        End Set
    End Property

    Public Property area()
        Get
            Return _area
        End Get
        Set(ByVal value)
            _area = value
        End Set
    End Property

    Public Property codSede()
        Get
            Return _codSede
        End Get
        Set(ByVal value)
            _codSede = value
        End Set
    End Property

    Public Property nomSede()
        Get
            Return _nomSede
        End Get
        Set(ByVal value)
            _nomSede = value
        End Set
    End Property

    Public Property caja()
        Get
            Return _caja
        End Get
        Set(ByVal value)
            _caja = value
        End Set
    End Property

    Public Property punto_emision()
        Get
            Return _punto_emision
        End Get
        Set(ByVal value)
            _punto_emision = value
        End Set
    End Property

    Public Property cod_punto_emision()
        Get
            Return _cod_punto_emision
        End Get
        Set(ByVal value)
            _cod_punto_emision = value
        End Set
    End Property

    Public Property cant_inv_lib()
        Get
            Return _cant_inv_lib
        End Get
        Set(ByVal value)
            _cant_inv_lib = value
        End Set
    End Property

    Public Property est_usuario()
        Get
            Return _est_usuario
        End Get
        Set(ByVal value)
            _est_usuario = value
        End Set
    End Property

    Public Property NoPerfilReclamaciones()
        Get
            Return _NoPerfilReclamaciones
        End Get
        Set(ByVal value)
            _NoPerfilReclamaciones = value
        End Set
    End Property

End Module
