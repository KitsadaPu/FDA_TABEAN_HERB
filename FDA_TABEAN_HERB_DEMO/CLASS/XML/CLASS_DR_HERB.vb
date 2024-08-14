Public Class CLASS_DR_HERB
    Inherits CLASS_CENTER
    Public XML_DRUG_PRODUCT_HERB As New XML_DRUG_PRODUCT_HERB

#Region "SHOW"
    Private _DT_SHOW As New CLS_SHOW
    Public Property DT_SHOW() As CLS_SHOW
        Get
            Return _DT_SHOW
        End Get
        Set(ByVal value As CLS_SHOW)
            _DT_SHOW = value
        End Set
    End Property
#End Region

#Region "MASTER"
    Private _DT_MASTER As New CLS_MASTER
    Public Property DT_MASTER() As CLS_MASTER
        Get
            Return _DT_MASTER
        End Get
        Set(ByVal value As CLS_MASTER)
            _DT_MASTER = value
        End Set
    End Property
#End Region

    Private _date_rgt_day As String
    Public Property date_rgt_day() As String
        Get
            Return _date_rgt_day
        End Get
        Set(ByVal value As String)
            _date_rgt_day = value
        End Set
    End Property

    Private _date_rgt_month As String
    Public Property date_rgt_month() As String
        Get
            Return _date_rgt_month
        End Get
        Set(ByVal value As String)
            _date_rgt_month = value
        End Set
    End Property

    Private _date_rgt_year As String
    Public Property date_rgt_year() As String
        Get
            Return _date_rgt_year
        End Get
        Set(ByVal value As String)
            _date_rgt_year = value
        End Set
    End Property
    Private _date_exdate_day As String
    Public Property date_exdate_day() As String
        Get
            Return _date_exdate_day
        End Get
        Set(ByVal value As String)
            _date_exdate_day = value
        End Set
    End Property

    Private _date_exdate_month As String
    Public Property date_exdate_month() As String
        Get
            Return _date_exdate_month
        End Get
        Set(ByVal value As String)
            _date_exdate_month = value
        End Set
    End Property

    Private _date_exdate_year As String
    Public Property date_exdate_year() As String
        Get
            Return _date_exdate_year
        End Get
        Set(ByVal value As String)
            _date_exdate_year = value
        End Set
    End Property
    Private _LCN_TYPE_NAME As String
    Public Property LCN_TYPE_NAME() As String
        Get
            Return _LCN_TYPE_NAME
        End Get
        Set(ByVal value As String)
            _LCN_TYPE_NAME = value
        End Set
    End Property
    Private _DAY_RENEW As String
    Public Property DAY_RENEW() As String
        Get
            Return _DAY_RENEW
        End Get
        Set(ByVal value As String)
            _DAY_RENEW = value
        End Set
    End Property
    Private _MONTH_RENEW As String
    Public Property MONTH_RENEW() As String
        Get
            Return _MONTH_RENEW
        End Get
        Set(ByVal value As String)
            _MONTH_RENEW = value
        End Set
    End Property
    Private _YEAR_RENEW As String
    Public Property YEAR_RENEW() As String
        Get
            Return _YEAR_RENEW
        End Get
        Set(ByVal value As String)
            _YEAR_RENEW = value
        End Set
    End Property
    Private _DATE_RENEW_TH As String
    Public Property DATE_RENEW_TH() As String
        Get
            Return _DATE_RENEW_TH
        End Get
        Set(ByVal value As String)
            _DATE_RENEW_TH = value
        End Set
    End Property
    Private _STAFF_APPROVE As String
    Public Property STAFF_APPROVE() As String
        Get
            Return _STAFF_APPROVE
        End Get
        Set(ByVal value As String)
            _STAFF_APPROVE = value
        End Set
    End Property
    Private _QR_CODE As String
    Public Property QR_CODE() As String
        Get
            Return _QR_CODE
        End Get
        Set(ByVal value As String)
            _QR_CODE = value
        End Set
    End Property
End Class
