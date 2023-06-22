Imports System.Web.Mvc
Public Class AUTHEN_INFORMATION

    Private _NAME As String
    Public Property NAME() As String
        Get
            Return _NAME
        End Get
        Set(ByVal value As String)
            _NAME = value
        End Set
    End Property
    Private _pvncd_name As String
    Public Property pvncd_name() As String
        Get
            Return _pvncd_name
        End Get
        Set(ByVal value As String)
            _pvncd_name = value
        End Set
    End Property
    Private _CITIZEN_ID As String
    Public Property CITIZEN_ID() As String
        Get
            Return _CITIZEN_ID
        End Get
        Set(ByVal value As String)
            _CITIZEN_ID = value
        End Set
    End Property

    Private _CITIZEN_ID_BSN As String
    Public Property CITIZEN_ID_BSN() As String
        Get
            Return _CITIZEN_ID_BSN
        End Get
        Set(ByVal value As String)
            _CITIZEN_ID_BSN = value
        End Set
    End Property

    Private _thanm As String
    Public Property thanm() As String
        Get
            Return _thanm
        End Get
        Set(ByVal value As String)
            _thanm = value
        End Set
    End Property
    Private _TOKEN As String
    Public Property TOKEN() As String
        Get
            Return _TOKEN
        End Get
        Set(ByVal value As String)
            _TOKEN = value
        End Set
    End Property

    Private _Groups As String
    Public Property Groups() As String
        Get
            Return _Groups
        End Get
        Set(ByVal value As String)
            _Groups = value
        End Set
    End Property

    Private _System_ID As String
    Public Property System_ID() As String
        Get
            Return _System_ID
        End Get
        Set(ByVal value As String)
            _System_ID = value
        End Set
    End Property


    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    Private _pvncd As String
    Public Property pvncd() As String
        Get
            Return _pvncd
        End Get
        Set(ByVal value As String)
            _pvncd = value
        End Set
    End Property
    Private _GROUP_TYPE As String
    Public Property GROUP_TYPE() As String
        Get
            Return _GROUP_TYPE
        End Get
        Set(ByVal value As String)
            _GROUP_TYPE = value
        End Set
    End Property

    Private _menu_all As String
    Public Property menu_all() As String
        Get
            Return _menu_all
        End Get
        Set(ByVal value As String)
            _menu_all = value
        End Set
    End Property



    Private _STAFF_APM As Integer = 0
    Public Property STAFF_APM() As Integer
        Get
            Return _STAFF_APM
        End Get
        Set(ByVal value As Integer)
            _STAFF_APM = value
        End Set
    End Property


    Private _LCNSID_CUSTOMER As String
    Public Property LCNSID_CUSTOMER() As String
        Get
            Return _LCNSID_CUSTOMER
        End Get
        Set(ByVal value As String)
            _LCNSID_CUSTOMER = value
        End Set
    End Property

    Private _THANM_CUSTOMER As String
    ''' <summary>
    ''' เก็บชื่อ บริษัท
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property THANM_CUSTOMER() As String
        Get
            Return _THANM_CUSTOMER
        End Get
        Set(ByVal value As String)
            _THANM_CUSTOMER = value
        End Set
    End Property

    ''' <summary>
    ''' PROCESS act
    ''' </summary>
    Private _PROCESS_ID As String
    Public Property PROCESS_ID() As String
        Get
            Return _PROCESS_ID
        End Get
        Set(ByVal value As String)
            _PROCESS_ID = value
        End Set
    End Property

    ''' <summary>
    ''' PROCESS act
    ''' </summary>
    Private _PROCESS_NAME As String
    Public Property PROCESS_NAME() As String
        Get
            Return _PROCESS_NAME
        End Get
        Set(ByVal value As String)
            _PROCESS_NAME = value
        End Set
    End Property

    Private _CITIZEN_ID_AUTHORIZE As String
    ''' <summary>
    ''' เก็บรหัสบัตรประชาชนหรือนิติบุคคล
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CITIZEN_ID_AUTHORIZE() As String
        Get
            Return _CITIZEN_ID_AUTHORIZE
        End Get
        Set(ByVal value As String)
            _CITIZEN_ID_AUTHORIZE = value
        End Set
    End Property
    'Private _taxno As String
    'Public Property taxno() As String
    '    Get
    '        Return _taxno
    '    End Get
    '    Set(ByVal value As String)
    '        _taxno = value
    '    End Set
    'End Property

    Private _FullAddr As String
    ''' <summary>
    ''' เก็บที่อยู่ของบริษัท
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FullAddr() As String
        Get
            Return _FullAddr
        End Get
        Set(ByVal value As String)
            _FullAddr = value
        End Set
    End Property

    Private _PATH_PDF As String
    Public Property PATH_PDF() As String
        Get
            Return _PATH_PDF
        End Get
        Set(ByVal value As String)
            _PATH_PDF = value
        End Set
    End Property

    Private _FILENAME_PDF As String
    Public Property FILENAME_PDF() As String
        Get
            Return _FILENAME_PDF
        End Get
        Set(ByVal value As String)
            _FILENAME_PDF = value
        End Set
    End Property


    Private _LCNSID As String
    Public Property LCNSID() As String
        Get
            Return _LCNSID
        End Get
        Set(ByVal value As String)
            _LCNSID = value
        End Set
    End Property


    Private _path_result As String
    Public Property path_result() As String
        Get
            Return _path_result
        End Get
        Set(ByVal value As String)
            _path_result = value
        End Set
    End Property

    Private _SYSTEM_PROD As String = ""
    Public Property SYSTEM_PROD() As String
        Get
            Return _SYSTEM_PROD
        End Get
        Set(ByVal value As String)
            _SYSTEM_PROD = value
        End Set
    End Property

    Private _SYSTEM_NM As String
    Public Property SYSTEM_NM() As String
        Get
            Return _SYSTEM_NM
        End Get
        Set(ByVal value As String)
            _SYSTEM_NM = value
        End Set
    End Property

End Class
