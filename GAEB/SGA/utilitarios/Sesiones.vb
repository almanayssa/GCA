Imports SGS.Model.Entidades

Public Class Sesiones

    Private Const sActividadSeleccionada As String = "sActividadSeleccionada"

    Public Shared Property ActividadSeleccionada() As ActividadBE
        Get
            Return HttpContext.Current.Session(sActividadSeleccionada)
        End Get
        Set(ByVal value As ActividadBE)
            HttpContext.Current.Session(sActividadSeleccionada) = value
        End Set
    End Property

    Public Shared Function ActividadSeleccionadaEsNulo() As Boolean
        Return HttpContext.Current.Session(sActividadSeleccionada) Is Nothing
    End Function

    Public Shared Sub ActividadSeleccionadaRemover()
        HttpContext.Current.Session.Remove(sActividadSeleccionada)
    End Sub

    Private Const sListadoActividades As String = "sListadoActividades"

    Public Shared Property ListadoActividades() As List(Of ActividadBE)
        Get
            Return HttpContext.Current.Session(sListadoActividades)
        End Get
        Set(ByVal value As List(Of ActividadBE))
            HttpContext.Current.Session(sListadoActividades) = value
        End Set
    End Property

    Public Shared Function ListadoActividadesEsNulo() As Boolean
        Return HttpContext.Current.Session(sListadoActividades) Is Nothing
    End Function

    Public Shared Sub ListadoActividadesRemover()
        HttpContext.Current.Session.Remove(sListadoActividades)
    End Sub

    Private Const sTempListadoActividades As String = "sTempListadoActividades"

    Public Shared Property TempListadoActividades() As List(Of ActividadBE)
        Get
            Return HttpContext.Current.Session(sTempListadoActividades)
        End Get
        Set(ByVal value As List(Of ActividadBE))
            HttpContext.Current.Session(sTempListadoActividades) = value
        End Set
    End Property

    Public Shared Function TempListadoActividadesEsNulo() As Boolean
        Return HttpContext.Current.Session(sTempListadoActividades) Is Nothing
    End Function

    Public Shared Sub TempListadoActividadesRemover()
        HttpContext.Current.Session.Remove(sTempListadoActividades)
    End Sub

#Region "MessageDescription"

    Public Shared Property MessageDescription() As String
        Get
            Return HttpContext.Current.Session(sMsgDescription)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgDescription) = value
        End Set
    End Property

    Public Shared Function MessageDescriptionIsNull() As Boolean
        Return HttpContext.Current.Session(sMsgDescription) Is Nothing
    End Function

    Public Shared Sub MessageDescriptionRemove()
        HttpContext.Current.Session.Remove(sMsgDescription)
    End Sub

#End Region

#Region "MessageTitle"

    Public Shared Property MessageTitle() As String
        Get
            Return HttpContext.Current.Session(sMsgTitle)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgTitle) = value
        End Set
    End Property

    Public Shared Function MessageTitleIsNull() As Boolean
        Return HttpContext.Current.Session(sMsgTitle) Is Nothing
    End Function

    Public Shared Sub MessageTitleRemove()
        HttpContext.Current.Session.Remove(sMsgTitle)
    End Sub

#End Region

#Region "MessageContinue"

    ' This session indicate the Message page
    Private Const sMsgDescription As String = "sMsgDescription"
    Private Const sMsgTitle As String = "sMsgTitle"
    Private Const sMsgContinue As String = "sMsgContinue"

    Public Shared Property MessageContinue() As String
        Get
            Return HttpContext.Current.Session(sMsgContinue)
        End Get
        Set(ByVal value As String)
            HttpContext.Current.Session(sMsgContinue) = value
        End Set
    End Property

    Public Shared Function MessageContinueIsNull() As Boolean
        Return HttpContext.Current.Session(sMsgContinue) Is Nothing
    End Function

    Public Shared Sub MessageContinueRemove()
        HttpContext.Current.Session.Remove(sMsgContinue)
    End Sub

#End Region
End Class
