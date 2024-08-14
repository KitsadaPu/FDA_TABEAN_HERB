Imports System.Web.Mvc

Public Class MODEL_APP
    Private _FILE_ATTACH As New Object
    Public Property FILE_ATTACH() As Object
        Get
            Return _FILE_ATTACH
        End Get
        Set(ByVal value As Object)
            _FILE_ATTACH = value
        End Set
    End Property
    Private _FILEUPLOADTABLE_STAFF As Object
    Public Property FILEUPLOADTABLE_STAFF() As Object
        Get
            Return _FILEUPLOADTABLE_STAFF
        End Get
        Set(ByVal value As Object)
            _FILEUPLOADTABLE_STAFF = value
        End Set
    End Property
    Private _FILE_ATTACH_EDIT As New Object
    Public Property FILE_ATTACH_EDIT() As Object
        Get
            Return _FILE_ATTACH_EDIT
        End Get
        Set(ByVal value As Object)
            _FILE_ATTACH_EDIT = value
        End Set
    End Property
    Private _FILE_ATTACH_STAFF As New Object
    Public Property FILE_ATTACH_STAFF() As Object
        Get
            Return _FILE_ATTACH_STAFF
        End Get
        Set(ByVal value As Object)
            _FILE_ATTACH_STAFF = value
        End Set
    End Property
    Private _CHK_LIST1 As New Object
    Public Property CHK_LIST1() As Object
        Get
            Return _CHK_LIST1
        End Get
        Set(ByVal value As Object)
            _CHK_LIST1 = value
        End Set
    End Property
    Private _NAME As String
    Public Property NAME() As String
        Get
            Return _NAME
        End Get
        Set(ByVal value As String)
            _NAME = value
        End Set
    End Property
    Private _NAME_SEARCH As String
    Public Property NAME_SEARCH() As String
        Get
            Return _NAME_SEARCH
        End Get
        Set(ByVal value As String)
            _NAME_SEARCH = value
        End Set
    End Property
    Private _IDEN_SEARCH As String
    Public Property IDEN_SEARCH() As String
        Get
            Return _IDEN_SEARCH
        End Get
        Set(ByVal value As String)
            _IDEN_SEARCH = value
        End Set
    End Property
    Private _CITIZEN_AUTHORIZE As String
    Public Property CITIZEN_AUTHORIZE() As String
        Get
            Return _CITIZEN_AUTHORIZE
        End Get
        Set(ByVal value As String)
            _CITIZEN_AUTHORIZE = value
        End Set
    End Property
    Private _RGTNO_DISPLAY As String
    Public Property RGTNO_DISPLAY() As String
        Get
            Return _RGTNO_DISPLAY
        End Get
        Set(ByVal value As String)
            _RGTNO_DISPLAY = value
        End Set
    End Property
    Private _TYPE_ID As String
    Public Property TYPE_ID() As String
        Get
            Return _TYPE_ID
        End Get
        Set(ByVal value As String)
            _TYPE_ID = value
        End Set
    End Property
    Private _TYPE_EDIT As String
    Public Property TYPE_EDIT() As String
        Get
            Return _TYPE_EDIT
        End Get
        Set(ByVal value As String)
            _TYPE_EDIT = value
        End Set
    End Property
    Private _NAME_ENG As String
    Public Property NAME_ENG() As String
        Get
            Return _NAME_ENG
        End Get
        Set(ByVal value As String)
            _NAME_ENG = value
        End Set
    End Property
    Private _NAME_THAI As String
    Public Property NAME_THAI() As String
        Get
            Return _NAME_THAI
        End Get
        Set(ByVal value As String)
            _NAME_THAI = value
        End Set
    End Property
    Private _FILE_SEARCH As New Object
    Public Property FILE_SEARCH() As Object
        Get
            Return _FILE_SEARCH
        End Get
        Set(ByVal value As Object)
            _FILE_SEARCH = value
        End Set
    End Property
    Private _LIST_UPLOAD_FILE As Object
    Public Property LIST_UPLOAD_FILE() As Object
        Get
            Return _LIST_UPLOAD_FILE
        End Get
        Set(ByVal value As Object)
            _LIST_UPLOAD_FILE = value
        End Set
    End Property
    Private _CUSTOMER_FILE As New Object
    Public Property CUSTOMER_FILE() As Object
        Get
            Return _CUSTOMER_FILE
        End Get
        Set(ByVal value As Object)
            _CUSTOMER_FILE = value
        End Set
    End Property
    Private _HEAD_ID As String
    Public Property HEAD_ID() As String
        Get
            Return _HEAD_ID
        End Get
        Set(ByVal value As String)
            _HEAD_ID = value
        End Set
    End Property

    Private _fileHerbForm As Object
    Public Property fileHerbForm() As String
        Get
            Return _fileHerbForm
        End Get
        Set(ByVal value As String)
            _fileHerbForm = value
        End Set
    End Property
    Private _List_SET_PAGE_MAIN_LCN As New List(Of SET_PAGE_MAIN_LCN)
    Public Property List_SET_PAGE_MAIN_LCN() As List(Of SET_PAGE_MAIN_LCN)
        Get
            Return _List_SET_PAGE_MAIN_LCN
        End Get
        Set(ByVal value As List(Of SET_PAGE_MAIN_LCN))
            _List_SET_PAGE_MAIN_LCN = value
        End Set
    End Property
    Private _List_SET_PAGE_SUB_MAIN_LCN As New List(Of SET_PAGE_SUB_MAIN_LCN)
    Public Property List_SET_PAGE_SUB_MAIN_LCN() As List(Of SET_PAGE_SUB_MAIN_LCN)
        Get
            Return _List_SET_PAGE_SUB_MAIN_LCN
        End Get
        Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_LCN))
            _List_SET_PAGE_SUB_MAIN_LCN = value
        End Set
    End Property
    Private _List_SET_PAGE_MAIN_HERB As New List(Of SET_PAGE_MAIN_HERB)
    Public Property List_SET_PAGE_MAIN_HERB() As List(Of SET_PAGE_MAIN_HERB)
        Get
            Return _List_SET_PAGE_MAIN_HERB
        End Get
        Set(ByVal value As List(Of SET_PAGE_MAIN_HERB))
            _List_SET_PAGE_MAIN_HERB = value
        End Set
    End Property
    Private _List_SET_PAGE_SUB_MAIN_HERB As New List(Of SET_PAGE_SUB_MAIN_HERB)
    Public Property List_SET_PAGE_SUB_MAIN_HERB() As List(Of SET_PAGE_SUB_MAIN_HERB)
        Get
            Return _List_SET_PAGE_SUB_MAIN_HERB
        End Get
        Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_HERB))
            _List_SET_PAGE_SUB_MAIN_HERB = value
        End Set
    End Property
    Private _CLS_SESSION As New CLS_SESSION
    Public Property CLS_SESSION() As CLS_SESSION
        Get
            Return _CLS_SESSION
        End Get
        Set(ByVal value As CLS_SESSION)
            _CLS_SESSION = value
        End Set
    End Property
    Private _CLS_ADDR As New CLS_ADDR
    Public Property CLS_ADDR() As CLS_ADDR
        Get
            Return _CLS_ADDR
        End Get
        Set(ByVal value As CLS_ADDR)
            _CLS_ADDR = value
        End Set
    End Property
    Private _INFOR_SEARCH As New INFOR_SH
    Public Property INFOR_SEARCH() As INFOR_SH
        Get
            Return _INFOR_SEARCH
        End Get
        Set(ByVal value As INFOR_SH)
            _INFOR_SEARCH = value
        End Set
    End Property
    Private _INFOR_LOCATION_SEARCH As New INFOR_LOCATION_SEARCH
    Public Property INFOR_LOCATION_SEARCH() As INFOR_LOCATION_SEARCH
        Get
            Return _INFOR_LOCATION_SEARCH
        End Get
        Set(ByVal value As INFOR_LOCATION_SEARCH)
            _INFOR_LOCATION_SEARCH = value
        End Set
    End Property
    Private _DRR_HERB As DRR_HERB
    Public Property DRR_HERB() As DRR_HERB
        Get
            Return _DRR_HERB
        End Get
        Set(ByVal value As DRR_HERB)
            _DRR_HERB = value
        End Set
    End Property
    Private _DALCN_SEARCH As New DALCN_SEARCH
    Public Property DALCN_SEARCH() As DALCN_SEARCH
        Get
            Return _DALCN_SEARCH
        End Get
        Set(ByVal value As DALCN_SEARCH)
            _DALCN_SEARCH = value
        End Set
    End Property
    Private _DALCN_DETAIL As New DALCN_SEARCH
    Public Property DALCN_DETAIL() As DALCN_SEARCH
        Get
            Return _DALCN_DETAIL
        End Get
        Set(ByVal value As DALCN_SEARCH)
            _DALCN_DETAIL = value
        End Set
    End Property
    Private _DALCN_PHR As New DALCN_PHR
    Public Property DALCN_PHR() As DALCN_PHR
        Get
            Return _DALCN_PHR
        End Get
        Set(ByVal value As DALCN_PHR)
            _DALCN_PHR = value
        End Set
    End Property
    Private _DALCN_LOCATION_ADDRESS As New DALCN_LOCATION_ADDRESS
    Public Property DALCN_LOCATION_ADDRESS() As DALCN_LOCATION_ADDRESS
        Get
            Return _DALCN_LOCATION_ADDRESS
        End Get
        Set(ByVal value As DALCN_LOCATION_ADDRESS)
            _DALCN_LOCATION_ADDRESS = value
        End Set
    End Property
    'Private _ADV_
    Private _DALCN_LOCATION_BSN As New DALCN_LOCATION_BSN
    Public Property DALCN_LOCATION_BSN() As DALCN_LOCATION_BSN
        Get
            Return _DALCN_LOCATION_BSN
        End Get
        Set(ByVal value As DALCN_LOCATION_BSN)
            _DALCN_LOCATION_BSN = value
        End Set
    End Property
    Private _dalcn As New dalcn
    Public Property dalcn() As dalcn
        Get
            Return _dalcn
        End Get
        Set(ByVal value As dalcn)
            _dalcn = value
        End Set
    End Property
    Private _XML_DRUG_PRODUCT_HERB As new XML_DRUG_PRODUCT_HERB
    Public Property XML_DRUG_PRODUCT_HERB() As XML_DRUG_PRODUCT_HERB
        Get
            Return _XML_DRUG_PRODUCT_HERB
        End Get
        Set(ByVal value As XML_DRUG_PRODUCT_HERB)
            _XML_DRUG_PRODUCT_HERB = value
        End Set
    End Property
    Private _XML_SEARCH_DRUG_LCN_HERB As New XML_SEARCH_DRUG_LCN_HERB
    Public Property XML_SEARCH_DRUG_LCN_HERB() As XML_SEARCH_DRUG_LCN_HERB
        Get
            Return _XML_SEARCH_DRUG_LCN_HERB
        End Get
        Set(ByVal value As XML_SEARCH_DRUG_LCN_HERB)
            _XML_SEARCH_DRUG_LCN_HERB = value
        End Set
    End Property
    Private _XML_SEARCH_DRUG_LCN_LICEN_HERB As New XML_SEARCH_DRUG_LCN_LICEN_HERB
    Public Property XML_SEARCH_DRUG_LCN_LICEN_HERB() As XML_SEARCH_DRUG_LCN_LICEN_HERB
        Get
            Return _XML_SEARCH_DRUG_LCN_LICEN_HERB
        End Get
        Set(ByVal value As XML_SEARCH_DRUG_LCN_LICEN_HERB)
            _XML_SEARCH_DRUG_LCN_LICEN_HERB = value
        End Set
    End Property
    Private _TABEAN_HERB_SUBSTITUTE As New TABEAN_HERB_SUBSTITUTE
    Public Property TABEAN_HERB_SUBSTITUTE() As TABEAN_HERB_SUBSTITUTE
        Get
            Return _TABEAN_HERB_SUBSTITUTE
        End Get
        Set(ByVal value As TABEAN_HERB_SUBSTITUTE)
            _TABEAN_HERB_SUBSTITUTE = value
        End Set
    End Property
    Private _TABEAN_RENEW As New TABEAN_RENEW
    Public Property TABEAN_RENEW() As TABEAN_RENEW
        Get
            Return _TABEAN_RENEW
        End Get
        Set(ByVal value As TABEAN_RENEW)
            _TABEAN_RENEW = value
        End Set
    End Property
    Private _list_LCN_APPROVE_EDIT As New LCN_APPROVE_EDIT
    Public Property list_LCN_APPROVE_EDIT() As LCN_APPROVE_EDIT
        Get
            Return _list_LCN_APPROVE_EDIT
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT)
            _list_LCN_APPROVE_EDIT = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST As New LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
    Public Property TYPE_EDIT_REQUEST() As LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
        Get
            Return _LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST)
            _LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL1_REASON As New LCN_APPROVE_EDIT_DDL1_REASON
    Public Property LCN_APPROVE_EDIT_DDL1() As LCN_APPROVE_EDIT_DDL1_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL1_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL1_REASON)
            _LCN_APPROVE_EDIT_DDL1_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL2_REASON As New LCN_APPROVE_EDIT_DDL2_REASON
    Public Property LCN_APPROVE_EDIT_DDL2() As LCN_APPROVE_EDIT_DDL2_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL2_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL2_REASON)
            _LCN_APPROVE_EDIT_DDL2_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL3_REASON As New LCN_APPROVE_EDIT_DDL3_REASON
    Public Property LCN_APPROVE_EDIT_DDL3() As LCN_APPROVE_EDIT_DDL3_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL3_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL3_REASON)
            _LCN_APPROVE_EDIT_DDL3_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL4_REASON As New LCN_APPROVE_EDIT_DDL4_REASON
    Public Property LCN_APPROVE_EDIT_DDL4() As LCN_APPROVE_EDIT_DDL4_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL4_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL4_REASON)
            _LCN_APPROVE_EDIT_DDL4_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL5_REASON As New LCN_APPROVE_EDIT_DDL5_REASON
    Public Property LCN_APPROVE_EDIT_DDL5() As LCN_APPROVE_EDIT_DDL5_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL5_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL5_REASON)
            _LCN_APPROVE_EDIT_DDL5_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL6_REASON As New LCN_APPROVE_EDIT_DDL6_REASON
    Public Property LCN_APPROVE_EDIT_DDL6() As LCN_APPROVE_EDIT_DDL6_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL6_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL6_REASON)
            _LCN_APPROVE_EDIT_DDL6_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL7_REASON As New LCN_APPROVE_EDIT_DDL7_REASON
    Public Property LCN_APPROVE_EDIT_DDL7() As LCN_APPROVE_EDIT_DDL7_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL7_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL7_REASON)
            _LCN_APPROVE_EDIT_DDL7_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL8_REASON As New LCN_APPROVE_EDIT_DDL8_REASON
    Public Property LCN_APPROVE_EDIT_DDL8() As LCN_APPROVE_EDIT_DDL8_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL8_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL8_REASON)
            _LCN_APPROVE_EDIT_DDL8_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL9_REASON As New LCN_APPROVE_EDIT_DDL9_REASON
    Public Property LCN_APPROVE_EDIT_DDL9() As LCN_APPROVE_EDIT_DDL9_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL9_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL9_REASON)
            _LCN_APPROVE_EDIT_DDL9_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL10_REASON As New LCN_APPROVE_EDIT_DDL10_REASON
    Public Property LCN_APPROVE_EDIT_DDL10() As LCN_APPROVE_EDIT_DDL10_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL10_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL10_REASON)
            _LCN_APPROVE_EDIT_DDL10_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_DDL11_REASON As New LCN_APPROVE_EDIT_DDL11_REASON
    Public Property LCN_APPROVE_EDIT_DDL11() As LCN_APPROVE_EDIT_DDL11_REASON
        Get
            Return _LCN_APPROVE_EDIT_DDL11_REASON
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_DDL11_REASON)
            _LCN_APPROVE_EDIT_DDL11_REASON = value
        End Set
    End Property
    Private _LCN_APPROVE_EDIT_UPLOAD_FILE As New LCN_APPROVE_EDIT_UPLOAD_FILE
    Public Property LCN_APPROVE_EDIT_UPLOAD_FILE() As LCN_APPROVE_EDIT_UPLOAD_FILE
        Get
            Return _LCN_APPROVE_EDIT_UPLOAD_FILE
        End Get
        Set(ByVal value As LCN_APPROVE_EDIT_UPLOAD_FILE)
            _LCN_APPROVE_EDIT_UPLOAD_FILE = value
        End Set
    End Property
    'Private _ADV_SEARCH As ADV_SEARCH
    'Public Property ADV_SEARCH() As ADV_SEARCH
    '    Get
    '        Return _ADV_SEARCH
    '    End Get
    '    Set(ByVal value As ADV_SEARCH)
    '        _ADV_SEARCH = value
    '    End Set
    'End Property
    'Private _OFFICE_LOCATION_SEARCH As New OFFICE_SEARCH
    'Public Property OFFICE_LOCATION_SEARCH() As OFFICE_SEARCH
    '    Get
    '        Return _OFFICE_LOCATION_SEARCH
    '    End Get
    '    Set(ByVal value As OFFICE_SEARCH)
    '        _OFFICE_LOCATION_SEARCH = value
    '    End Set
    'End Property
    Private _get_location As New get_location
    Public Property get_location() As get_location
        Get
            Return _get_location
        End Get
        Set(ByVal value As get_location)
            _get_location = value
        End Set
    End Property
    Private _get_data As New Object
    Public Property get_data() As Object
        Get
            Return _get_data
        End Get
        Set(ByVal value As Object)
            _get_data = value
        End Set
    End Property
    Private _get_frgn As New Object
    Public Property get_frgn() As Object
        Get
            Return _get_frgn
        End Get
        Set(ByVal value As Object)
            _get_frgn = value
        End Set
    End Property
    Private _get_Animal As New Object
    Public Property get_Animal() As Object
        Get
            Return _get_Animal
        End Get
        Set(ByVal value As Object)
            _get_Animal = value
        End Set
    End Property
    Private _get_recipe As New Object
    Public Property get_recipe() As Object
        Get
            Return _get_recipe
        End Get
        Set(ByVal value As Object)
            _get_recipe = value
        End Set
    End Property
    Private _infor_drug As New Object
    Public Property infor_drug() As Object
        Get
            Return _infor_drug
        End Get
        Set(ByVal value As Object)
            _infor_drug = value
        End Set
    End Property

    Private _infor_location_drug As New Object
    Public Property infor_location_drug() As Object
        Get
            Return _infor_location_drug
        End Get
        Set(ByVal value As Object)
            _infor_location_drug = value
        End Set
    End Property
    Private _infor_dalcn_herb As New Object
    Public Property infor_dalcn_herb() As Object
        Get
            Return _infor_dalcn_herb
        End Get
        Set(ByVal value As Object)
            _infor_dalcn_herb = value
        End Set
    End Property
    Private _cer_dalcn_herb As New Object
    Public Property cer_dalcn_herb() As Object
        Get
            Return _cer_dalcn_herb
        End Get
        Set(ByVal value As Object)
            _cer_dalcn_herb = value
        End Set
    End Property
    Private _lcn_edit_staff As New Object
    Public Property lcn_edit_staff() As Object
        Get
            Return _lcn_edit_staff
        End Get
        Set(ByVal value As Object)
            _lcn_edit_staff = value
        End Set
    End Property
    Private _Tabean_Herb As Object
    Public Property Tabean_Herb() As Object
        Get
            Return _Tabean_Herb
        End Get
        Set(ByVal value As Object)
            _Tabean_Herb = value
        End Set
    End Property
    Private _Tabean_Herb_Staff As Object
    Public Property Tabean_Herb_Staff() As Object
        Get
            Return _Tabean_Herb_Staff
        End Get
        Set(ByVal value As Object)
            _Tabean_Herb_Staff = value
        End Set
    End Property
    Private _Tabean_JJ As Object
    Public Property Tabean_JJ() As Object
        Get
            Return _Tabean_JJ
        End Get
        Set(ByVal value As Object)
            _Tabean_JJ = value
        End Set
    End Property
    Private _Tabean_JJ_Staff As Object
    Public Property Tabean_JJ_Staff() As Object
        Get
            Return _Tabean_JJ_Staff
        End Get
        Set(ByVal value As Object)
            _Tabean_JJ_Staff = value
        End Set
    End Property
    Private _Tabean_RJ As Object
    Public Property Tabean_RJ() As Object
        Get
            Return _Tabean_RJ
        End Get
        Set(ByVal value As Object)
            _Tabean_RJ = value
        End Set
    End Property
    Private _Tabean_RJ_Staff As Object
    Public Property Tabean_RJ_Staff() As Object
        Get
            Return _Tabean_RJ_Staff
        End Get
        Set(ByVal value As Object)
            _Tabean_RJ_Staff = value
        End Set
    End Property
    Private _Substitute_Tabean As Object
    Public Property Substitute_Tabean() As Object
        Get
            Return _Substitute_Tabean
        End Get
        Set(ByVal value As Object)
            _Substitute_Tabean = value
        End Set
    End Property
    Private _Substitute_Tabean_Staff As Object
    Public Property Substitute_Tabean_Staff() As Object
        Get
            Return _Substitute_Tabean_Staff
        End Get
        Set(ByVal value As Object)
            _Substitute_Tabean_Staff = value
        End Set
    End Property
    Private _Renew_Tabean As Object
    Public Property Renew_Tabean() As Object
        Get
            Return _Renew_Tabean
        End Get
        Set(ByVal value As Object)
            _Renew_Tabean = value
        End Set
    End Property
    Private _Renew_Tabean_Staff As Object
    Public Property Renew_Tabean_Staff() As Object
        Get
            Return _Renew_Tabean_Staff
        End Get
        Set(ByVal value As Object)
            _Renew_Tabean_Staff = value
        End Set
    End Property
    Private _Log_Status As Object
    Public Property Log_Status() As Object
        Get
            Return _Log_Status
        End Get
        Set(ByVal value As Object)
            _Log_Status = value
        End Set
    End Property
    Private _lcn_addr As New Object
    Public Property lcn_addr() As Object
        Get
            Return _lcn_addr
        End Get
        Set(ByVal value As Object)
            _lcn_addr = value
        End Set
    End Property
    Private _lcn_edit As New Object
    Public Property lcn_edit() As Object
        Get
            Return _lcn_edit
        End Get
        Set(ByVal value As Object)
            _lcn_edit = value
        End Set
    End Property
    Private _cer_lcn_staff As New Object
    Public Property cer_lcn_staff() As Object
        Get
            Return _cer_lcn_staff
        End Get
        Set(ByVal value As Object)
            _cer_lcn_staff = value
        End Set
    End Property
    Private _dalcn_herb As New Object
    Public Property dalcn_herb() As Object
        Get
            Return _dalcn_herb
        End Get
        Set(ByVal value As Object)
            _dalcn_herb = value
        End Set
    End Property
    Private _MAS_PRODUCTION_MODEL_CER As New Object
    Public Property MAS_PRODUCTION_MODEL_CER() As Object
        Get
            Return _MAS_PRODUCTION_MODEL_CER
        End Get
        Set(ByVal value As Object)
            _MAS_PRODUCTION_MODEL_CER = value
        End Set
    End Property

    Private _MAS_CRITERIA_USE_IN_AUDIT_CER As New Object
    Public Property MAS_CRITERIA_USE_IN_AUDIT_CER() As Object
        Get
            Return _MAS_CRITERIA_USE_IN_AUDIT_CER
        End Get
        Set(ByVal value As Object)
            _MAS_CRITERIA_USE_IN_AUDIT_CER = value
        End Set
    End Property
    Private _adv_herb As New Object
    Public Property adv_herb() As Object
        Get
            Return _adv_herb
        End Get
        Set(ByVal value As Object)
            _adv_herb = value
        End Set
    End Property
    Private _adv_herb_detail As New Object
    Public Property adv_herb_detail() As Object
        Get
            Return _adv_herb_detail
        End Get
        Set(ByVal value As Object)
            _adv_herb_detail = value
        End Set
    End Property
    Private _adv_office_herb As New Object
    Public Property adv_office_herb() As Object
        Get
            Return _adv_office_herb
        End Get
        Set(ByVal value As Object)
            _adv_office_herb = value
        End Set
    End Property
    Private _adv_office_herb_detail As New Object
    Public Property adv_office_herb_detail() As Object
        Get
            Return _adv_office_herb_detail
        End Get
        Set(ByVal value As Object)
            _adv_office_herb_detail = value
        End Set
    End Property
    Private _infor_drr_herb As Object
    Public Property infor_drr_herb() As Object
        Get
            Return _infor_drr_herb
        End Get
        Set(ByVal value As Object)
            _infor_drr_herb = value
        End Set
    End Property
    Private _office_drug As New Object
    Public Property office_drug() As Object
        Get
            Return _office_drug
        End Get
        Set(ByVal value As Object)
            _office_drug = value
        End Set
    End Property
    Private _detail_drr As New Object
    Public Property detail_drr() As Object
        Get
            Return _detail_drr
        End Get
        Set(ByVal value As Object)
            _detail_drr = value
        End Set
    End Property
    Private _ERR_ALERT As String
    Public Property ERR_ALERT() As String
        Get
            Return _ERR_ALERT
        End Get
        Set(ByVal value As String)
            _ERR_ALERT = value
        End Set
    End Property
    Private _ALERT_MS As String
    Public Property ALERT_MS() As String
        Get
            Return _ALERT_MS
        End Get
        Set(ByVal value As String)
            _ALERT_MS = value
        End Set
    End Property
    Private _FILEUPLOADTABLE As Object
    Public Property FILEUPLOADTABLE() As Object
        Get
            Return _FILEUPLOADTABLE
        End Get
        Set(ByVal value As Object)
            _FILEUPLOADTABLE = value
        End Set
    End Property
    Private _Newcode As String
    Public Property Newcode() As String
        Get
            Return _Newcode
        End Get
        Set(ByVal value As String)
            _Newcode = value
        End Set
    End Property
    Private _IDA As String
    Public Property IDA() As String
        Get
            Return _IDA
        End Get
        Set(ByVal value As String)
            _IDA = value
        End Set
    End Property
    Private _TR_ID As String
    Public Property TR_ID() As String
        Get
            Return _TR_ID
        End Get
        Set(ByVal value As String)
            _TR_ID = value
        End Set
    End Property
    Private _PROCESS_ID As String
    Public Property PROCESS_ID() As String
        Get
            Return _PROCESS_ID
        End Get
        Set(ByVal value As String)
            _PROCESS_ID = value
        End Set
    End Property
    Private _STATUS_ID As String
    Public Property STATUS_ID() As String
        Get
            Return _STATUS_ID
        End Get
        Set(ByVal value As String)
            _STATUS_ID = value
        End Set
    End Property
    Private _STATUS_LCN As String
    Public Property STATUS_LCN() As String
        Get
            Return _STATUS_LCN
        End Get
        Set(ByVal value As String)
            _STATUS_LCN = value
        End Set
    End Property
    Private _IDA_LCN As String
    Public Property IDA_LCN() As String
        Get
            Return _IDA_LCN
        End Get
        Set(ByVal value As String)
            _IDA_LCN = value
        End Set
    End Property
    Private _DATE_CONNFIRM As String
    Public Property DATE_CONNFIRM() As String
        Get
            Return _DATE_CONNFIRM
        End Get
        Set(ByVal value As String)
            _DATE_CONNFIRM = value
        End Set
    End Property
    Private _CONFIRM_STATUS_ID As String
    Public Property CONFIRM_STATUS_ID() As String
        Get
            Return _CONFIRM_STATUS_ID
        End Get
        Set(ByVal value As String)
            _CONFIRM_STATUS_ID = value
        End Set
    End Property
    Private _CONFIRM_STATUS As String
    Public Property CONFIRM_STATUS_NAME() As String
        Get
            Return _CONFIRM_STATUS
        End Get
        Set(ByVal value As String)
            _CONFIRM_STATUS = value
        End Set
    End Property
    Private _STAFF_NAME_CONFIRM As String
    Public Property STAFF_NAME_CONFIRM() As String
        Get
            Return _STAFF_NAME_CONFIRM
        End Get
        Set(ByVal value As String)
            _STAFF_NAME_CONFIRM = value
        End Set
    End Property
    Private _STAFF_IDENTIFY As String
    Public Property STAFF_IDENTIFY() As String
        Get
            Return _STAFF_IDENTIFY
        End Get
        Set(ByVal value As String)
            _STAFF_IDENTIFY = value
        End Set
    End Property
    Private _STAFF_NAME_ID As String
    Public Property STAFF_NAME_ID() As String
        Get
            Return _STAFF_NAME_ID
        End Get
        Set(ByVal value As String)
            _STAFF_NAME_ID = value
        End Set
    End Property
    Private _NOTE_STAFF As String
    Public Property NOTE_STAFF() As String
        Get
            Return _NOTE_STAFF
        End Get
        Set(ByVal value As String)
            _NOTE_STAFF = value
        End Set
    End Property
    Private _IDA_DR As String
    Public Property IDA_DR() As String
        Get
            Return _IDA_DR
        End Get
        Set(ByVal value As String)
            _IDA_DR = value
        End Set
    End Property
    Private _PATH_NAME As String
    Public Property PATH_NAME() As String
        Get
            Return _PATH_NAME
        End Get
        Set(ByVal value As String)
            _PATH_NAME = value
        End Set
    End Property
    Private _IDA_LCT As String
    Public Property IDA_LCT() As String
        Get
            Return _IDA_LCT
        End Get
        Set(ByVal value As String)
            _IDA_LCT = value
        End Set
    End Property
    Private _ddl1 As String
    Public Property ddl1() As String
        Get
            Return _ddl1
        End Get
        Set(ByVal value As String)
            _ddl1 = value
        End Set
    End Property
    Private _ddl2 As String
    Public Property ddl2() As String
        Get
            Return _ddl2
        End Get
        Set(ByVal value As String)
            _ddl2 = value
        End Set
    End Property
    Private _ddl_Type_Tabean As Object
    Public Property ddl_Type_Tabean() As Object
        Get
            Return _ddl_Type_Tabean
        End Get
        Set(ByVal value As Object)
            _ddl_Type_Tabean = value
        End Set
    End Property
    Private _ddl_staff_name As Object
    Public Property ddl_staff_name() As Object
        Get
            Return _ddl_staff_name
        End Get
        Set(ByVal value As Object)
            _ddl_staff_name = value
        End Set
    End Property
    Private _ddl_CancelRequest As Object
    Public Property ddl_CancelRequest() As Object
        Get
            Return _ddl_CancelRequest
        End Get
        Set(ByVal value As Object)
            _ddl_CancelRequest = value
        End Set
    End Property
    Private _ddl_status_staff As Object
    Public Property ddl_status_staff() As Object
        Get
            Return _ddl_status_staff
        End Get
        Set(ByVal value As Object)
            _ddl_status_staff = value
        End Set
    End Property
    Private _ddl_status As Object
    Public Property ddl_status() As Object
        Get
            Return _ddl_status
        End Get
        Set(ByVal value As Object)
            _ddl_status = value
        End Set
    End Property
    Private _ddl_price As Object
    Public Property ddl_price() As Object
        Get
            Return _ddl_price
        End Get
        Set(ByVal value As Object)
            _ddl_price = value
        End Set
    End Property
    Private _ddl_kind_tabean As Object
    Public Property ddl_kind_tabean() As Object
        Get
            Return _ddl_kind_tabean
        End Get
        Set(ByVal value As Object)
            _ddl_kind_tabean = value
        End Set
    End Property
    Private _ddl_prefix As Object
    Public Property ddl_prefix() As Object
        Get
            Return _ddl_prefix
        End Get
        Set(ByVal value As Object)
            _ddl_prefix = value
        End Set
    End Property
    Private _ddl_sale_channel As Object
    Public Property ddl_sale_channel() As Object
        Get
            Return _ddl_sale_channel
        End Get
        Set(ByVal value As Object)
            _ddl_sale_channel = value
        End Set
    End Property
    Private _ddl_discount As Object
    Public Property ddl_discount() As Object
        Get
            Return _ddl_discount
        End Get
        Set(ByVal value As Object)
            _ddl_discount = value
        End Set
    End Property
    Private _detial_type As String
    Public Property Detial_Type() As String
        Get
            Return _detial_type
        End Get
        Set(ByVal value As String)
            _detial_type = value
        End Set
    End Property
    Private _PERASON_TYPE As String
    Public Property PERASON_TYPE() As String
        Get
            Return _PERASON_TYPE
        End Get
        Set(ByVal value As String)
            _PERASON_TYPE = value
        End Set
    End Property
    Private _STAFF_ID As String
    Public Property STAFF_ID() As String
        Get
            Return _STAFF_ID
        End Get
        Set(ByVal value As String)
            _STAFF_ID = value
        End Set
    End Property
    Private _WRITE_DATE As Date
    Public Property WRITE_DATE() As String
        Get
            Return _WRITE_DATE
        End Get
        Set(ByVal value As String)
            _WRITE_DATE = value
        End Set
    End Property
    Private _FUNC_CODE As String
    Public Property FUNC_CODE() As String
        Get
            Return _FUNC_CODE
        End Get
        Set(ByVal value As String)
            _FUNC_CODE = value
        End Set
    End Property
    Private _RESULT As String
    Public Property RESULT() As String
        Get
            Return _RESULT
        End Get
        Set(ByVal value As String)
            _RESULT = value
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
    Private _PDFNAME As String
    Public Property PDFNAME() As String
        Get
            Return _PDFNAME
        End Get
        Set(ByVal value As String)
            _PDFNAME = value
        End Set
    End Property
    Private _FILENAME_XML As String
    Public Property FILENAME_XML() As String
        Get
            Return _FILENAME_XML
        End Get
        Set(ByVal value As String)
            _FILENAME_XML = value
        End Set
    End Property
#Region "SET_PAGE_SUB_MAIN"
    Private _SET_PAGE_SUB_MAIN As New Object
    Public Property SET_PAGE_SUB_MAIN() As Object
        Get
            Return _SET_PAGE_SUB_MAIN
        End Get
        Set(ByVal value As Object)
            _SET_PAGE_SUB_MAIN = value
        End Set
    End Property
    Private _List_SET_PAGE_SUB_MAIN As New List(Of Object)
    Public Property List_SET_PAGE_SUB_MAIN() As List(Of Object)
        Get
            Return _List_SET_PAGE_SUB_MAIN
        End Get
        Set(ByVal value As List(Of Object))
            _List_SET_PAGE_SUB_MAIN = value
        End Set
    End Property
#End Region
#Region "SET_Dropdown"
    Private _syschngwt As New List(Of syschngwt)
    Public Property syschngwt() As List(Of syschngwt)
        Get
            Return _syschngwt
        End Get
        Set(ByVal value As List(Of syschngwt))
            _syschngwt = value
        End Set
    End Property
    'Private _systhmbl As New List(Of systhmbl)
    'Public Property systhmbl() As List(Of systhmbl)
    '    Get
    '        Return _systhmbl
    '    End Get
    '    Set(ByVal value As List(Of systhmbl))
    '        _systhmbl = value
    '    End Set
    'End Property
    'Private _sysamphr As New List(Of sysamphr)
    'Public Property sysamphr() As List(Of sysamphr)
    '    Get
    '        Return _sysamphr
    '    End Get
    '    Set(ByVal value As List(Of sysamphr))
    '        _sysamphr = value
    '    End Set
    'End Property
    Private _kind_licen As New Object
    Public Property kind_licen() As Object
        Get
            Return _kind_licen
        End Get
        Set(ByVal value As Object)
            _kind_licen = value
        End Set
    End Property

#End Region

End Class


Public Class INFOR_SH
    Private _txt_substance As String
    Public Property txt_substance() As String
        Get
            Return _txt_substance
        End Get
        Set(ByVal value As String)
            _txt_substance = value
        End Set
    End Property
    Private _Txt_fdpdtno As String
    Public Property Txt_fdpdtno() As String
        Get
            Return _Txt_fdpdtno
        End Get
        Set(ByVal value As String)
            _Txt_fdpdtno = value
        End Set
    End Property
    Private _txt_Product_THAI As String
    Public Property txt_Product_THAI() As String
        Get
            Return _txt_Product_THAI
        End Get
        Set(ByVal value As String)
            _txt_Product_THAI = value
        End Set
    End Property
    Private _txt_Product_ENG As String
    Public Property txt_Product_ENG() As String
        Get
            Return _txt_Product_ENG
        End Get
        Set(ByVal value As String)
            _txt_Product_ENG = value
        End Set
    End Property

End Class
Public Class DRR_HERB
    Private _IDA As String
    Public Property IDA() As String
        Get
            Return _IDA
        End Get
        Set(ByVal value As String)
            _IDA = value
        End Set
    End Property
    Private _thadrgnm As String
    Public Property thadrgnm() As String
        Get
            Return _thadrgnm
        End Get
        Set(ByVal value As String)
            _thadrgnm = value
        End Set
    End Property
    Private _engdrgnm As String
    Public Property engdrgnm() As String
        Get
            Return _engdrgnm
        End Get
        Set(ByVal value As String)
            _engdrgnm = value
        End Set
    End Property
    Private _rgttpcd As String
    Public Property rgttpcd() As String
        Get
            Return _rgttpcd
        End Get
        Set(ByVal value As String)
            _rgttpcd = value
        End Set
    End Property
    Private _STATUS_NAME As String
    Public Property STATUS_NAME() As String
        Get
            Return _STATUS_NAME
        End Get
        Set(ByVal value As String)
            _STATUS_NAME = value
        End Set
    End Property
    Private _thachngwtnm As String
    Public Property thachngwtnm() As String
        Get
            Return _thachngwtnm
        End Get
        Set(ByVal value As String)
            _thachngwtnm = value
        End Set
    End Property
    Private _register As String
    Public Property register() As String
        Get
            Return _register
        End Get
        Set(ByVal value As String)
            _register = value
        End Set
    End Property
    Private _register_rcvno As String
    Public Property register_rcvno() As String
        Get
            Return _register_rcvno
        End Get
        Set(ByVal value As String)
            _register_rcvno = value
        End Set
    End Property



End Class

Public Class DALCN_SEARCH

    Private _IDA As String
    Public Property IDA() As String
        Get
            Return _IDA
        End Get
        Set(ByVal value As String)
            _IDA = value
        End Set
    End Property
    Private _lcntpcd As String
    Public Property lcntpcd() As String
        Get
            Return _lcntpcd
        End Get
        Set(ByVal value As String)
            _lcntpcd = value
        End Set
    End Property
    Private _lcnno_display As String
    Public Property lcnno_display() As String
        Get
            Return _lcnno_display
        End Get
        Set(ByVal value As String)
            _lcnno_display = value
        End Set
    End Property
    Private _lcnno_display_new As String
    Public Property lcnno_display_new() As String
        Get
            Return _lcnno_display_new
        End Get
        Set(ByVal value As String)
            _lcnno_display_new = value
        End Set
    End Property
    Private _thachngwtnm As String
    Public Property thachngwtnm() As String
        Get
            Return _thachngwtnm
        End Get
        Set(ByVal value As String)
            _thachngwtnm = value
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
    Private _STATUS_NAME As String
    Public Property STATUS_NAME() As String
        Get
            Return _STATUS_NAME
        End Get
        Set(ByVal value As String)
            _STATUS_NAME = value
        End Set
    End Property

    'Private _Message_MODEL As New Message_MODEL
    'Public Property Message_MODEL() As Message_MODEL
    '    Get
    '        Return _Message_MODEL
    '    End Get
    '    Set(ByVal value As Message_MODEL)
    '        _Message_MODEL = value
    '    End Set
    'End Property

    Private _BSN_THAIFULLNAME As String
    Public Property BSN_THAIFULLNAME() As String
        Get
            Return _BSN_THAIFULLNAME
        End Get
        Set(ByVal value As String)
            _BSN_THAIFULLNAME = value
        End Set
    End Property
    Private _thanm_addr As String
    Public Property thanm_addr() As String
        Get
            Return _thanm_addr
        End Get
        Set(ByVal value As String)
            _thanm_addr = value
        End Set
    End Property
    Private _opentime As String
    Public Property opentime() As String
        Get
            Return _opentime
        End Get
        Set(ByVal value As String)
            _opentime = value
        End Set
    End Property
    Private _phrs As New List(Of PHR)
    Public Property phrs() As List(Of PHR)
        Get
            Return _phrs
        End Get
        Set(ByVal value As List(Of PHR))
            _phrs = value
        End Set
    End Property
End Class
Public Class ADV_SEARCH
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Private _RequestNumber As String
    Public Property RequestNumber() As String
        Get
            Return _RequestNumber
        End Get
        Set(ByVal value As String)
            _RequestNumber = value
        End Set
    End Property
    Private _LicenseNumber As String
    Public Property LicenseNumber() As String
        Get
            Return _LicenseNumber
        End Get
        Set(ByVal value As String)
            _LicenseNumber = value
        End Set
    End Property
    Private _AgencyName As String
    Public Property AgencyName() As String
        Get
            Return _AgencyName
        End Get
        Set(ByVal value As String)
            _AgencyName = value
        End Set
    End Property
    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Private _StatusDetail As String
    Public Property StatusDetail() As String
        Get
            Return _StatusDetail
        End Get
        Set(ByVal value As String)
            _StatusDetail = value
        End Set
    End Property
End Class
Public Class INFOR_LOCATION_SEARCH
    Private _lcnno_noo As String
    Public Property lcnno_noo() As String
        Get
            Return _lcnno_noo
        End Get
        Set(ByVal value As String)
            _lcnno_noo = value
        End Set
    End Property
    Private _thachngwtnm As String
    Public Property thachngwtnm() As String
        Get
            Return _thachngwtnm
        End Get
        Set(ByVal value As String)
            _thachngwtnm = value
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
    Private _lcnno_display_new As String
    Public Property lcnno_display_new() As String
        Get
            Return _lcnno_display_new
        End Get
        Set(ByVal value As String)
            _lcnno_display_new = value
        End Set
    End Property
    Private _LOCATION_TYPE As String
    Public Property LOCATION_TYPE() As String
        Get
            Return _LOCATION_TYPE
        End Get
        Set(ByVal value As String)
            _LOCATION_TYPE = value
        End Set
    End Property
    Private _LCO_STATUS As String
    Public Property LCO_STATUS() As String
        Get
            Return _LCO_STATUS
        End Get
        Set(ByVal value As String)
            _LCO_STATUS = value
        End Set
    End Property
End Class
Public Class OFFICE_SEARCH
    Private _rcb_prov As String
    Public Property rcb_prov() As String
        Get
            Return _rcb_prov
        End Get
        Set(ByVal value As String)
            _rcb_prov = value
        End Set
    End Property
    Private _txt_store As String
    Public Property txt_store() As String
        Get
            Return _txt_store
        End Get
        Set(ByVal value As String)
            _txt_store = value
        End Set
    End Property
    Private _rcb_kind_licen As String
    Public Property rcb_kind_licen() As String
        Get
            Return _rcb_kind_licen
        End Get
        Set(ByVal value As String)
            _rcb_kind_licen = value
        End Set
    End Property
    Private _Txt_fdpdtno_lo As String
    Public Property Txt_fdpdtno_lo() As String
        Get
            Return _Txt_fdpdtno_lo
        End Get
        Set(ByVal value As String)
            _Txt_fdpdtno_lo = value
        End Set
    End Property
    Private _rcb_prov1 As String
    Public Property rcb_prov1() As String
        Get
            Return _rcb_prov1
        End Get
        Set(ByVal value As String)
            _rcb_prov1 = value
        End Set
    End Property
    Private _txt_licen As String
    Public Property txt_licen() As String
        Get
            Return _txt_licen
        End Get
        Set(ByVal value As String)
            _txt_licen = value
        End Set
    End Property
    Private _txt_grannm As String
    Public Property txt_grannm() As String
        Get
            Return _txt_grannm
        End Get
        Set(ByVal value As String)
            _txt_grannm = value
        End Set
    End Property
    Private _txt_phr As String
    Public Property txt_phr() As String
        Get
            Return _txt_phr
        End Get
        Set(ByVal value As String)
            _txt_phr = value
        End Set
    End Property
    Private _txt_Identify As String
    Public Property txt_Identify() As String
        Get
            Return _txt_Identify
        End Get
        Set(ByVal value As String)
            _txt_Identify = value
        End Set
    End Property
    Private _txt_num_phr As String
    Public Property txt_num_phr() As String
        Get
            Return _txt_num_phr
        End Get
        Set(ByVal value As String)
            _txt_num_phr = value
        End Set
    End Property
    Private _txt_addr As String
    Public Property txt_addr() As String
        Get
            Return _txt_addr
        End Get
        Set(ByVal value As String)
            _txt_addr = value
        End Set
    End Property
    Private _rcb_chang As String
    Public Property rcb_chang() As String
        Get
            Return _rcb_chang
        End Get
        Set(ByVal value As String)
            _rcb_chang = value
        End Set
    End Property
    Private _rcb_amphr As String
    Public Property rcb_amphr() As String
        Get
            Return _rcb_amphr
        End Get
        Set(ByVal value As String)
            _rcb_amphr = value
        End Set
    End Property
    Private _rcb_thmblns As String
    Public Property rcb_thmblns() As String
        Get
            Return _rcb_thmblns
        End Get
        Set(ByVal value As String)
            _rcb_thmblns = value
        End Set
    End Property
    Private _RadioButtonList1_select_lcn As String
    Public Property RadioButtonList1_select_lcn() As String
        Get
            Return _RadioButtonList1_select_lcn
        End Get
        Set(ByVal value As String)
            _RadioButtonList1_select_lcn = value
        End Set
    End Property
    Private _RadioButtonList_provinces As String
    Public Property RadioButtonList_provinces() As String
        Get
            Return _RadioButtonList_provinces
        End Get
        Set(ByVal value As String)
            _RadioButtonList_provinces = value
        End Set
    End Property

End Class

Public Class LGT_IOW

    Private _LGT_IOW_E As New LGT_IOW1
    Public Property LGT_IOW_E() As LGT_IOW1
        Get
            Return _LGT_IOW_E
        End Get
        Set(ByVal value As LGT_IOW1)
            _LGT_IOW_E = value
        End Set
    End Property



End Class
Public Class LGT_IOW1

    Private _XML_SEARCH_DRUG_DR As New Object
    Public Property XML_SEARCH_DRUG_DR() As Object
        Get
            Return _XML_SEARCH_DRUG_DR
        End Get
        Set(ByVal value As Object)
            _XML_SEARCH_DRUG_DR = value
        End Set
    End Property



End Class

Public Class LGT_XML_DRUG_LCN_CENTER
    Private _LGT_XML_DRUG_LCN_CENTER_TO As New LGT_XML_DRUG_LCN_CENTER_TO
    Public Property LGT_XML_DRUG_LCN_CENTER_TO() As LGT_XML_DRUG_LCN_CENTER_TO
        Get
            Return _LGT_XML_DRUG_LCN_CENTER_TO
        End Get
        Set(ByVal value As LGT_XML_DRUG_LCN_CENTER_TO)
            _LGT_XML_DRUG_LCN_CENTER_TO = value
        End Set
    End Property
End Class
Public Class LGT_XML_DRUG_LCN_CENTER_TO

    Private _DT1 As DataTable
    Public Property DT1() As DataTable
        Get
            Return _DT1
        End Get
        Set(ByVal value As DataTable)
            _DT1 = value
        End Set
    End Property
    Private _DT2 As DataTable
    Public Property DT2() As DataTable
        Get
            Return _DT2
        End Get
        Set(ByVal value As DataTable)
            _DT2 = value
        End Set
    End Property

    Private _DT3 As DataTable
    Public Property DT3() As DataTable
        Get
            Return _DT3
        End Get
        Set(ByVal value As DataTable)
            _DT3 = value
        End Set
    End Property

    Private _DT4 As DataTable
    Public Property DT4() As DataTable
        Get
            Return _DT4
        End Get
        Set(ByVal value As DataTable)
            _DT4 = value
        End Set
    End Property
End Class
Public Class get_location

    Private _lcnno_no As String
    Public Property lcnno_no() As String
        Get
            Return _lcnno_no
        End Get
        Set(ByVal value As String)
            _lcnno_no = value
        End Set
    End Property
    Private _grannm_lo As String
    Public Property grannm_lo() As String
        Get
            Return _grannm_lo
        End Get
        Set(ByVal value As String)
            _grannm_lo = value
        End Set
    End Property
    Private _thanm_addr As String
    Public Property thanm_addr() As String
        Get
            Return _thanm_addr
        End Get
        Set(ByVal value As String)
            _thanm_addr = value
        End Set
    End Property
    Private _licen_time As String
    Public Property licen_time() As String
        Get
            Return _licen_time
        End Get
        Set(ByVal value As String)
            _licen_time = value
        End Set
    End Property

    Private _phrs As New List(Of PHR)
    Public Property phrs() As List(Of PHR)
        Get
            Return _phrs
        End Get
        Set(ByVal value As List(Of PHR))
            _phrs = value
        End Set
    End Property
    Private _licen As New List(Of Licen)
    Public Property licen() As List(Of Licen)
        Get
            Return _licen
        End Get
        Set(ByVal value As List(Of Licen))
            _licen = value
        End Set
    End Property

End Class

Public Class PHR

    Private _pharmacy_name As String
    Public Property pharmacy_name() As String
        Get
            Return _pharmacy_name
        End Get
        Set(ByVal value As String)
            _pharmacy_name = value
        End Set
    End Property
    Private _opentime As String
    Public Property opentime() As String
        Get
            Return _opentime
        End Get
        Set(ByVal value As String)
            _opentime = value
        End Set
    End Property
    Private _phr_addrr As String
    Public Property phr_addrr() As String
        Get
            Return _phr_addrr
        End Get
        Set(ByVal value As String)
            _phr_addrr = value
        End Set
    End Property
    Private _phrno As String
    Public Property phrno() As String
        Get
            Return _phrno
        End Get
        Set(ByVal value As String)
            _phrno = value
        End Set
    End Property

End Class
Public Class Licen

    Private _licen As String
    Public Property licen() As String
        Get
            Return _licen
        End Get
        Set(ByVal value As String)
            _licen = value
        End Set
    End Property
    Private _licen_time As String
    Public Property licen_time() As String
        Get
            Return _licen_time
        End Get
        Set(ByVal value As String)
            _licen_time = value
        End Set
    End Property

End Class



