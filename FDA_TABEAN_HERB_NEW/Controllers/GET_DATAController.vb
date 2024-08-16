Imports System.Web.Mvc
Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO
Imports System.Drawing
Namespace Controllers
    Public Class GET_DATAController
        Inherits Controller

        ' GET: GET_DATA
        Function Index() As ActionResult
            Return View()
        End Function

        Public Function GET_DATA_CUTOMMER(ByVal TOKEN As String) As JsonResult

            Dim CLS_MODEL As MODEL_APP = New MODEL_APP()
            CLS_MODEL.CLS_SESSION = CHK_TOKEN(TOKEN)
            If (CLS_MODEL.CLS_SESSION.CODE = "900" Or CLS_MODEL.CLS_SESSION.CODE = "901") Then
                If CLS_MODEL.CLS_SESSION.SYSTEM_ID = "11309" Then
                    CLS_MODEL.List_SET_PAGE_MAIN_HERB = GET_SET_PAGE_MAIN_HERB_CUSTOMMER(CLS_MODEL.CLS_SESSION.SYSTEM_ID)
                    CLS_MODEL.List_SET_PAGE_SUB_MAIN_HERB = GET_SET_PAGE_SUB_MAIN_HERB_CUSTOMMER(CLS_MODEL.CLS_SESSION.SYSTEM_ID)
                    'Else
                    '    CLS_MODEL.List_SET_PAGE_MAIN_CER = GET_SET_PAGE_MAIN_CER(1)
                    '    CLS_MODEL.List_SET_PAGE_SUB_MAIN_CER = GET_SET_PAGE_SUB_MAIN_CER(1)
                End If

                'CLS_MODEL.syschngwt = Get_data_syschngwt()
                '    CLS_MODEL.sysamphr = Get_data_sysamphr()
                '    CLS_MODEL.systhmbl = Get_data_systhmbl()
                CLS_MODEL.kind_licen = Get_data_kind_licen()

            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "100") Then
                CLS_MODEL.ERR_ALERT = "TOKEN Expire"
            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "101") Then
                CLS_MODEL.ERR_ALERT = "ชื่อผู้ใช้นี้ ไม่มีสิทธิใช้งาน"
            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "102") Then
                CLS_MODEL.ERR_ALERT = "ชื่อผู้ใช้นี้ มีการเข้าใช้ระบบนี้อยู่แล้ว"
            End If

            Return Json(CLS_MODEL, JsonRequestBehavior.AllowGet)
        End Function
        Public Function GET_DATA(ByVal TOKEN As String) As JsonResult

            Dim CLS_MODEL As MODEL_APP = New MODEL_APP()
            CLS_MODEL.CLS_SESSION = CHK_TOKEN(TOKEN)
            If (CLS_MODEL.CLS_SESSION.CODE = "900" Or CLS_MODEL.CLS_SESSION.CODE = "901") Then
                If CLS_MODEL.CLS_SESSION.SYSTEM_ID = "9818" Or CLS_MODEL.CLS_SESSION.SYSTEM_ID = "9841" Or CLS_MODEL.CLS_SESSION.SYSTEM_ID = "11085" Or CLS_MODEL.CLS_SESSION.SYSTEM_ID = "11085" Or CLS_MODEL.CLS_SESSION.SYSTEM_ID = "9819" Then
                    CLS_MODEL.List_SET_PAGE_MAIN_HERB = GET_SET_PAGE_MAIN_HERB()
                    CLS_MODEL.List_SET_PAGE_SUB_MAIN_HERB = GET_SET_PAGE_SUB_MAIN_HERB()
                    'Else
                    '    CLS_MODEL.List_SET_PAGE_MAIN_CER = GET_SET_PAGE_MAIN_CER(1)
                    '    CLS_MODEL.List_SET_PAGE_SUB_MAIN_CER = GET_SET_PAGE_SUB_MAIN_CER(1)
                End If

                'CLS_MODEL.syschngwt = Get_data_syschngwt()
                '    CLS_MODEL.sysamphr = Get_data_sysamphr()
                '    CLS_MODEL.systhmbl = Get_data_systhmbl()
                CLS_MODEL.kind_licen = Get_data_kind_licen()

            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "100") Then
                CLS_MODEL.ERR_ALERT = "TOKEN Expire"
            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "101") Then
                CLS_MODEL.ERR_ALERT = "ชื่อผู้ใช้นี้ ไม่มีสิทธิใช้งาน"
            ElseIf (CLS_MODEL.CLS_SESSION.CODE = "102") Then
                CLS_MODEL.ERR_ALERT = "ชื่อผู้ใช้นี้ มีการเข้าใช้ระบบนี้อยู่แล้ว"
            End If

            Return Json(CLS_MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Public Function GET_SET_PAGE_MAIN_HERB_CUSTOMMER(ByVal SystemID As Integer) As Object
            Dim dao As New DAO_TABEAN.TB_SET_PAGE_MAIN_HERB
            dao.GETDATA_BY_SYSID(SystemID)
            Return dao.Details()
        End Function
        Public Function GET_SET_PAGE_SUB_MAIN_HERB_CUSTOMMER(ByVal SystemID As Integer) As Object
            Dim dao As New DAO_TABEAN.TB_SET_PAGE_SUB_MAIN_HERB
            dao.GETDATA_BY_SYSID(SystemID)
            Return dao.Details()
        End Function
        Public Function GET_SET_PAGE_MAIN_HERB() As Object
            Dim dao As New DAO_TABEAN.TB_SET_PAGE_MAIN_HERB
            dao.GetDataStaff()
            Return dao.Details()
        End Function
        Public Function GET_SET_PAGE_SUB_MAIN_HERB() As Object
            Dim dao As New DAO_TABEAN.TB_SET_PAGE_SUB_MAIN_HERB
            dao.GetDataAll()
            Return dao.Details()
        End Function
        Public Function Get_data_kind_licen() As Object
            Dim BAO As New BAO.BAO
            Return DataTableToJSON(BAO.SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD())
        End Function


        Public Function DataTableToJSON(ByVal table As DataTable) As Object
            Dim list = New List(Of Dictionary(Of String, Object))()

            For Each row As DataRow In table.Rows
                Dim dict = New Dictionary(Of String, Object)()

                For Each col As DataColumn In table.Columns
                    dict(col.ColumnName) = (Convert.ToString(row(col)))
                Next

                list.Add(dict)
            Next

            Return list
        End Function
        Function CHK_TOKEN(ByVal TOKEN As String) As CLS_SESSION

            Dim _CLS As New CLS_SESSION

            If TOKEN = "PASS" Then

                _CLS.CITIZEN_ID = "1100400181875"
                _CLS.CITIZEN_ID_AUTHORIZE = "3102000896182"
                _CLS.COMPANY_NAME = "บริษัท เทสออนลี่ จำกัด มหาขน"
                _CLS.THANM = "นายทดสอบ ระบบ"
                _CLS.TOKEN = TOKEN
                _CLS.CODE = "900"
            Else

                Try
                    Dim ws As New Authentication_66.Authentication
                    Dim xml As String = ""
                    xml = ws.Authen_Login(TOKEN)

                    Dim clsxml As New Cls_XML
                    clsxml.ReadData(xml)
                    _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
                    _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
                    ' _CLS.CITIZEN_ID_AUTHORIZE = "0000000000000"
                    _CLS.TOKEN = TOKEN
                    _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
                    _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
                    _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
                    _CLS.THANM = clsxml.Get_Value_XML("Name")
                    _CLS.CODE = clsxml.Get_Value_XML("CODE")
                Catch ex As Exception
                    Try
                        Dim ws As New Authentication_65.Authentication
                        Dim xml As String = ""
                        xml = ws.Authen_Login(TOKEN)

                        Dim clsxml As New Cls_XML
                        clsxml.ReadData(xml)
                        _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
                        _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
                        ' _CLS.CITIZEN_ID_AUTHORIZE = "0000000000000"
                        _CLS.TOKEN = TOKEN
                        _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
                        _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
                        _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
                        _CLS.THANM = clsxml.Get_Value_XML("Name")
                        _CLS.CODE = clsxml.Get_Value_XML("CODE")
                    Catch ex2 As Exception
                        Dim ws As New Authentication_104.Authentication
                        Dim xml As String = ""
                        xml = ws.Authen_Login(TOKEN)

                        Dim clsxml As New Cls_XML
                        clsxml.ReadData(xml)
                        _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
                        _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
                        ' _CLS.CITIZEN_ID_AUTHORIZE = "0000000000000"
                        _CLS.TOKEN = TOKEN
                        _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
                        _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
                        _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
                        _CLS.THANM = clsxml.Get_Value_XML("Name")
                        _CLS.CODE = clsxml.Get_Value_XML("CODE")
                    End Try
                End Try
            End If
            Dim citizen_id As String = ""
            citizen_id = _CLS.CITIZEN_ID
            Dim NAME As String = ""
            Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
            Dim obj As New XML_DATA
            'Dim cls As New CLS_COMMON.convert
            Dim result As String = ""
            'result = ws_center.GET_DATA_IDEM(citizen_id, citizen_id, "IDEM", "DPIS")
            result = ws_center.GET_DATA_IDENTIFY(citizen_id, citizen_id, "FUSION", "P@ssw0rdfusion440")
            obj = ConvertFromXml(Of XML_DATA)(result)
            Try
                Dim TYPE_PERSON As Integer = obj.SYSLCNSIDs.type
                _CLS.NameTH_Prefix = obj.SYSLCNSNMs.prefixnm
                _CLS.NameTH_FirstName = obj.SYSLCNSNMs.thanm
                _CLS.NameTH_SurName = obj.SYSLCNSNMs.thalnm
            Catch ex As Exception

            End Try


            Return _CLS
        End Function

        Function ConvertFromXml(Of T As Class)(ByRef str As String) As T


            Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))


            Dim reader As StringReader = New StringReader(str)


            Dim c As T = TryCast(serializer.Deserialize(reader), T)


            Return c

        End Function
    End Class


End Namespace