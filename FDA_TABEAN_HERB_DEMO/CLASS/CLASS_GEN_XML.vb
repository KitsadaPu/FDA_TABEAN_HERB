Imports System.IO
Imports System.Xml.Serialization
Imports System.Globalization
'Imports Org.BouncyCastle.Asn1.Ocsp
Namespace CLASS_GEN_XML
    Public Class Center
        Protected Friend _CITIEZEN_ID As String
        Protected Friend _lcnsid_customer As Integer
        Protected Friend _lcnno As String
        Protected Friend _PVNCD As String
        Protected Friend _lcntpcd As String
        Protected Friend _lctcd As Integer
        Protected Friend _IDA As Integer
        Protected Friend _LCN_IDA As Integer
        Function ConvertFromXml(Of T As Class)(ByRef str As String) As T


            Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))


            Dim reader As StringReader = New StringReader(str)


            Dim c As T = TryCast(serializer.Deserialize(reader), T)


            Return c

        End Function
        Public Sub GEN_XML_TABEAN_SUB(ByVal PATH As String, ByVal p2 As CLASS_DR_SUB)

            Dim objStreamWriter As New StreamWriter(PATH)
            Dim x As New XmlSerializer(p2.GetType)
            x.Serialize(objStreamWriter, p2)
            objStreamWriter.Close()
        End Sub
        Public Sub GEN_XML_TABEAN_RENEW(ByVal PATH As String, ByVal p2 As CLASS_DR_RENEW)

            Dim objStreamWriter As New StreamWriter(PATH)
            Dim x As New XmlSerializer(p2.GetType)
            x.Serialize(objStreamWriter, p2)
            objStreamWriter.Close()

        End Sub
        Public Sub GEN_XML_TABEAN_TBN(ByVal PATH As String, ByVal p2 As CLASS_DR_HERB)

            Dim objStreamWriter As New StreamWriter(PATH)
            Dim x As New XmlSerializer(p2.GetType)
            x.Serialize(objStreamWriter, p2)
            objStreamWriter.Close()

        End Sub
        Public Function date_to_thai(ByVal _date As Date)
            Dim dateD_TH As String = ""
            Dim dateM_TH As String = ""
            Dim dateY_TH As String = ""
            Dim dateD As Date
            Dim dateM As Date
            Dim dateY As Date
            Dim date_FULL As String = ""
            Try
                Dim month As Integer = 6 ' Specify the month number here

                ' Create an instance of the Thai culture
                Dim thaiCulture As New CultureInfo("th-TH")

                ' Get the localized month name
                Dim monthName As String = thaiCulture.DateTimeFormat.GetMonthName(month)
                _date = _date
                _date = CDate(_date).ToString("dd/MM/yyy")
                dateD = _date
                dateM = _date
                dateY = _date

                dateD_TH = dateD.Day.ToString()
                dateM_TH = dateM.ToString("MMMM")
                dateY_TH = con_year(dateY.Year)
                date_FULL = dateD_TH & " " & dateM_TH & " " & dateY_TH
            Catch ex As Exception

            End Try

            Return date_FULL
        End Function
        Public Function SEARCH_NAME_BY_IDEN(ByVal CITIZEN_AUTHORIZE As String) As Object
            Dim CITIZEN_ID_AUTHORIZE As String = ""
            Try
                CITIZEN_ID_AUTHORIZE = CITIZEN_AUTHORIZE
                'CITIZEN_ID_AUTHORIZE = text_edit_ddl1_PHR_TEXT_JOB.Text
            Catch ex As Exception

            End Try
            Dim NAME As String = ""
            Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
            Dim obj As New XML_DATA
            'Dim cls As New CLS_COMMON.convert
            Dim result As String = ""
            'result = ws_center.GET_DATA_IDEM(citizen_id, citizen_id, "IDEM", "DPIS")
            result = ws_center.GET_DATA_IDENTIFY(CITIZEN_ID_AUTHORIZE, CITIZEN_ID_AUTHORIZE, "FUSION", "P@ssw0rdfusion440")
            obj = ConvertFromXml(Of XML_DATA)(result)
            Try
                Dim TYPE_PERSON As Integer = obj.SYSLCNSIDs.type
                If TYPE_PERSON = 1 Then
                    NAME = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                Else
                    If obj.SYSLCNSNMs.thalnm IsNot Nothing Then
                        NAME = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                    Else
                        NAME = obj.SYSLCNSNMs.prefixnm2 & obj.SYSLCNSNMs.thanm
                    End If
                End If
            Catch ex As Exception

            End Try
            Return NAME
        End Function
        'Public Sub GEN_XML_LCN_EDIT(ByVal PATH As String, ByVal p2 As CLS_LCN_EDIT_SMP3)

        '    Dim objStreamWriter As New StreamWriter(PATH)
        '    Dim x As New XmlSerializer(p2.GetType)
        '    x.Serialize(objStreamWriter, p2)
        '    objStreamWriter.Close()

        'End Sub
        'Public Sub GEN_XML_TABEAN_SMP3(ByVal PATH As String, ByVal p2 As CLS_LCN_EDIT_SMP3)

        '    Dim objStreamWriter As New StreamWriter(PATH)
        '    Dim x As New XmlSerializer(p2.GetType)
        '    x.Serialize(objStreamWriter, p2)
        '    objStreamWriter.Close()

        'End Sub
    End Class


    Public Class LCN_CENTER
        Inherits Center
        Public Class LCN_EDIT_SMP3
            Inherits Center

            'Public Function gen_xml(ByVal IDA As Integer, ByVal IDA_LCN As Integer, ByVal _YEAR As String)
            '    Dim XML As New CLS_LCN_EDIT_SMP3

            '    'Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT
            '    'dao.GetDataby_IDA_YEAR(IDA, _YEAR, True)
            '    'XML.LCN_APPROVE_EDIT = dao.fields

            '    Dim dt1, dt2 As New DataTable
            '    Dim bao As New BAO.BIND_DT_XML
            '    dt1 = bao.SP_LCN_APPROVE_EDIT_GET_DATA_XML1(IDA, _YEAR)

            '    dt1.Columns.Add("CREATE_DATE_FULL")
            '    dt1.Columns.Add("STAFF_RQ_DATE_FULL")

            '    For Each dr As DataRow In dt1.Rows
            '        Dim status As Integer = 0
            '        Dim create_date_full As Date
            '        Dim rq_date_full As Date


            '        Dim create_date_Show As String = ""
            '        Dim rq_date_Show As String = ""

            '        Try
            '            status = dr("STATUS_ID")
            '        Catch ex As Exception

            '        End Try

            '        Try
            '            create_date_full = dr("CREATE_DATE")
            '        Catch ex As Exception

            '        End Try

            '        Try
            '            rq_date_full = dr("STAFF_RQ_DATE")
            '        Catch ex As Exception

            '        End Try

            '        Try
            '            If status = 2 Then
            '                rq_date_Show = ""
            '            Else
            '                rq_date_Show = rq_date_full.Day.ToString() & " " & rq_date_full.ToString("MMMM") & " " & con_year(rq_date_full.Year)
            '            End If


            '        Catch ex As Exception

            '        End Try
            '        create_date_Show = create_date_full.Day.ToString() & " " & create_date_full.ToString("MMMM") & " " & con_year(create_date_full.Year)

            '        dr("STAFF_RQ_DATE_FULL") = rq_date_Show
            '        dr("CREATE_DATE_FULL") = create_date_Show

            '    Next

            '    dt1.TableName = "XML_LCN_APPROVE_EDIT"

            '    dt2 = bao.SP_LCN_APPROVE_EDIT_GET_DATA_XML2(IDA_LCN, _YEAR)
            '    dt2.TableName = "XML_LCN_APPROVE_EDIT_FILE_UPLOAD"


            '    Dim dao_lcn As New DAO_LCN.TB_dalcn
            '    dao_lcn.GetDataby_IDA(IDA_LCN)
            '    Dim dt_lcn As New DataTable
            '    Dim bao_lcn As New BAO.BAO

            '    'dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)
            '    dt_lcn.TableName = "XML_LCN_EDIT_LOCATION_ADDRESS"

            '    XML.DT_SHOW.DT1 = dt1
            '    XML.DT_SHOW.DT2 = dt2
            '    XML.DT_SHOW.DT3 = dt_lcn

            '    Return XML
            'End Function

        End Class
    End Class
    Public Class TABEAN_CENTER
        Public Class TABEAN_SUBSTITUTE
            Inherits Center
            Public Function Gen_XML_SUBSTITUTE_TBN(ByVal IDA As Integer, ByVal FK_IDA As Integer, ByVal _IDA_LCN As Integer)
                Dim BAO_SP_RN As New BAO.BAO
                'Dim bao_lcn As New BAO_SHOW
                'Dim bao_lcn_location As New BAO_MASTER
                Dim XML As New CLASS_DR_SUB
                Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
                dao.GetdatabyID_IDA(IDA)
                Dim dao_bsn As New DAO_LCN.TB_DALCN_LOCATION_BSN
                dao_bsn.GetDataby_LCN_IDA(dao.fields.FK_LCN)
                Dim DT As New DataTable
                If dao.fields.TYPE_PERSON = 1 Then
                    dao.fields.TYPE_PERSON = 1
                Else
                    dao.fields.TYPE_PERSON = 2
                    dao.fields.THANM = dao_bsn.fields.BSN_THAIFULLNAME
                    dao.fields.AGENT99_ID = dao_bsn.fields.BSN_IDENTIFY
                End If
                XML.TABEAN_SUB = dao.fields
                DT = BAO_SP_RN.SP_XML_TABEAN_HERB_SUBSTITUTE(IDA)
                For Each dr As DataRow In DT.Rows
                    If dao.fields.TYPE_PERSON = 2 Then
                        dr("AGENT99_ID") = dao_bsn.fields.BSN_IDENTIFY
                    End If
                Next
                DT.TableName = "SP_XML_TABEAN_HERB_SUBSTITUTE"
                If dao.fields.TYPE_PERSON = 2 Then
                    XML.DT_SHOW.DT1 = DT
                Else
                    XML.DT_SHOW.DT2 = DT
                End If
                Dim dateValue As Date  ' Replace with your desired date
                ' Create an instance of the Thai culture
                Dim thaiCulture As New CultureInfo("th-TH")
                ' Convert the date to Thai format
                Dim thaiDate As String = ""
                Try
                    dateValue = dao.fields.DATE_CONFIRM
                    thaiDate = dateValue.ToString("dd MMMM yyyy", thaiCulture)
                    XML.RCVDATE_FULL_THAI = thaiDate
                Catch ex As Exception

                End Try
                Return XML
            End Function
        End Class
        Public Class TABEAN_HERB_TBN
            Inherits Center

            'Public Function gen_xml_tbn(ByVal _IDA As Integer, ByVal _IDA_DQ As Integer, ByVal _IDA_LCN As Integer)
            '    Dim XML As New CLASS_DRRQT
            '    Dim bao_lcn As New BAO_SHOW

            '    Dim dt_lcn As New DataTable
            '    Dim dt_lcn_location As New DataTable

            '    Dim dao_lcn As New DAO_LCN.TB_dalcn
            '    dao_lcn.GetDataby_IDA(_IDA_LCN)

            '    Dim dao_drrqt As New DAO_DRUG.ClsDBdrrqt
            '    dao_drrqt.GetDataby_IDA(_IDA_DQ)

            '    Dim dao_tabean_herb As New DAO_TABEAN_HERB.TB_TABEAN_HERB
            '    dao_tabean_herb.GetdatabyID_IDA(_IDA)

            '    Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
            '    dao_cpn.GetDataby_identify(dao_drrqt.fields.CITIZEN_ID_AUTHORIZE)

            '    Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
            '    dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)

            '    Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
            '    Try
            '        dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
            '    Catch ex As Exception

            '    End Try

            '    Dim CITIZEN_ID As String = dao_drrqt.fields.IDENTIFY
            '    Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
            '    Dim obj As New XML_DATA
            '    'Dim cls As New CLS_COMMON.convert
            '    Dim result As String = ""
            '    'result = ws_center.GET_DATA_IDEM(citizen_id, citizen_id, "IDEM", "DPIS")
            '    result = ws_center.GET_DATA_IDENTIFY(CITIZEN_ID, CITIZEN_ID, "FUSION", "P@ssw0rdfusion440")
            '    obj = ConvertFromXml(Of XML_DATA)(result)
            '    Dim THANM_CENTER As String = ""
            '    Dim TYPE_PERSON_CENTER As Integer = obj.SYSLCNSIDs.type
            '    If TYPE_PERSON_CENTER = 1 Then
            '        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
            '    ElseIf TYPE_PERSON_CENTER = 99 Or TYPE_PERSON_CENTER = 3 Then
            '        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
            '    Else
            '        If obj.SYSLCNSNMs.thalnm IsNot Nothing Then
            '            THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
            '        Else
            '            THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
            '        End If
            '    End If

            '    Dim THANM As String = dao_lcn.fields.thanm
            '    If THANM = "" Or THANM Is Nothing Then
            '        THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm & " " & dao_customer.fields.thalnm
            '    Else
            '        THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
            '    End If
            '    Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
            '    Try
            '        tb_location.GetDataby_LCN_IDA(_IDA_LCN)
            '    Catch ex As Exception

            '    End Try
            '    Dim dao_pfx As New DAO_CPN.TB_sysprefix
            '    Dim BSN_THAIFULLNAME As String = ""
            '    Dim citizen_bsn As String = tb_location.fields.BSN_IDENTIFY
            '    Dim dao_cpn2 As New DAO_CPN.clsDBsyslcnsid
            '    ' dao_cpn.GetDataby_identify(dao.fields.CITIZEN_ID_AUTHORIZE)
            '    dao_cpn2.GetDataby_identify(dao_drrqt.fields.CITIZEN_ID_AUTHORIZE)
            '    Dim dao_who As New DAO_WHO.TB_WHO_DALCN
            '    dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
            '    Dim WHO_NAME As String = ""
            '    WHO_NAME = dao_who.fields.THANM_NAME
            '    Try
            '        dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
            '        Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
            '        Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
            '        Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
            '        If dao_drrqt.fields.WHO_ID = True Then
            '            BSN_THAIFULLNAME = THANM_CENTER
            '            'BSN_THAIFULLNAME = WHO_NAME
            '        Else
            '            BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
            '        End If
            '        'BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

            '    Catch ex As Exception

            '    End Try
            '    'Try
            '    '    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
            '    '    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
            '    '    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
            '    '    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
            '    '    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

            '    'Catch ex As Exception

            '    'End Try




            '    Dim bao As New BAO.ClsDBSqlcommand
            '    Dim person_age As String = ""
            '    Dim NATIONALITY_PERSON As String = ""
            '    Try
            '        person_age = dao_tabean_herb.fields.PERSON_AGE
            '        If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
            '            NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
            '        Else
            '            NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
            '        End If
            '    Catch ex As Exception

            '    End Try

            '    'Dim TYPE_PERSON As Integer = dao_cpn.fields.type
            '    Dim TYPE_PERSON_WHO As Integer = dao_cpn2.fields.type
            '    '  Dim NATION As String = dao_lcn.fields.NATION
            '    Dim TYPE_PERSON As Integer = dao_cpn.fields.type
            '    Dim NATION As String = dao_lcn.fields.NATION


            '    Dim CITIZEN_ID_AUTHORIZE As String = dao_drrqt.fields.CITIZEN_ID_AUTHORIZE
            '    Dim NAME As String = dao_drrqt.fields.CREATE_BY
            '    Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace
            '    'Dim BSN_THAIFULLNAME As String = dao_lcn.fields.BSN_THAIFULLNAME

            '    Dim dt As New DataTable
            '    Dim BAO2 As New BAO_TABEAN_HERB.tb_main

            '    Dim date_rcv_day As Date
            '    Dim date_rcv_month As Date
            '    Dim date_rcv_year As Date

            '    Dim date_rgt_day As Date
            '    Dim date_rgt_month As Date
            '    Dim date_rgt_year As Date

            '    If dao_drrqt.fields.rcvdate IsNot Nothing Then
            '        date_rcv_day = dao_drrqt.fields.rcvdate
            '        date_rcv_month = dao_drrqt.fields.rcvdate
            '        date_rcv_year = dao_drrqt.fields.rcvdate

            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    End If
            '    'If dao_drrqt.fields.STATUS_ID = 6 Or dao_drrqt.fields.STATUS_ID = 11 Or dao_drrqt.fields.STATUS_ID = 12 Or dao_drrqt.fields.STATUS_ID = 13 Or dao_drrqt.fields.STATUS_ID = 23 Then
            '    '    date_rcv_day = dao_drrqt.fields.rcvdate
            '    '    date_rcv_month = dao_drrqt.fields.rcvdate
            '    '    date_rcv_year = dao_drrqt.fields.rcvdate

            '    '    XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    'End If
            '    If dao_drrqt.fields.STATUS_ID = 8 Then

            '        date_rcv_day = dao_drrqt.fields.rcvdate
            '        date_rcv_month = dao_drrqt.fields.rcvdate
            '        date_rcv_year = dao_drrqt.fields.rcvdate

            '        date_rgt_day = dao_drrqt.fields.appdate
            '        date_rgt_month = dao_drrqt.fields.appdate
            '        date_rgt_year = dao_drrqt.fields.appdate

            '        XML.RGTNO_DATE = date_rgt_day.Day.ToString() & " " & date_rgt_month.ToString("MMMM") & " " & con_year(date_rgt_year.Year)
            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    End If

            '    dt = BAO2.SP_XML_DRUG_DRRQT(_IDA_DQ)
            '    dt.Columns.Add("TYPE_SUB_NAME_CHANGE")
            '    dt.Columns.Add("TREATMENT_AGE_FULL")
            '    dt.Columns.Add("WARNIG_DETIAL")
            '    For Each dr As DataRow In dt.Rows

            '        'If dr("TYPE_SUB_ID") = 1 Then
            '        '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนไทย"
            '        'ElseIf dr("TYPE_SUB_ID") = 2 Then
            '        '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
            '        'ElseIf dr("TYPE_SUB_ID") = 3 Then
            '        '    dr("TYPE_SUB_NAME_CHANGE") = "ยาพัฒนาจากสมุนไพร"
            '        'End If  
            '        Try
            '            dr("RECIPE_NAME") = dao_tabean_herb.fields.RECIPE_NAME & " " & dao_tabean_herb.fields.RECIPE_UNIT_NAME

            '        Catch ex As Exception

            '        End Try
            '        Try
            '            If dao_drrqt.fields.RCVNO_OLD <> Nothing Then
            '                dr("RCVNO_NEW") = dao_drrqt.fields.RCVNO_OLD
            '                dr("RCVNO_DATE") = dao_drrqt.fields.DATE_CONFIRM
            '            End If
            '        Catch ex As Exception

            '        End Try
            '        Try
            '            If dr("WARNING_TYPE_ID") = 1 And dr("WARNING_ID") = 2 Then
            '                dr("WARNIG_DETIAL") = dao_tabean_herb.fields.WARNING_NAME
            '            Else
            '                dr("WARNIG_DETIAL") = dao_tabean_herb.fields.WARNING_SUB_NAME
            '            End If
            '        Catch ex As Exception

            '        End Try

            '        Dim TEXT_UP As String = ""
            '        Try
            '            TEXT_UP = dr("FOREIGN_NAME_PLACE")
            '            dr("FOREIGN_NAME_PLACE") = TEXT_UP.ToUpper()
            '        Catch ex As Exception

            '        End Try

            '        Try
            '            If dr("TYPE_ID") = 20102 Then
            '                dr("TYPE_ID") = 20101
            '            ElseIf dr("TYPE_ID") = 20103 Then
            '                dr("TYPE_ID") = 20101
            '            ElseIf dr("TYPE_ID") = 20191 Then
            '                dr("TYPE_ID") = 20101
            '            ElseIf dr("TYPE_ID") = 20192 Then
            '                dr("TYPE_ID") = 20101
            '            ElseIf dr("TYPE_ID") = 20193 Then
            '                dr("TYPE_ID") = 20101
            '            ElseIf dr("TYPE_ID") = 20194 Then
            '                dr("TYPE_ID") = 20104
            '            End If

            '        Catch ex As Exception

            '        End Try

            '        Try
            '            If dr("CATEGORY_ID") = 1220 Then
            '                dr("CATEGORY_ID") = 122
            '            ElseIf dr("CATEGORY_ID") = 1221 Then
            '                dr("CATEGORY_ID") = 121
            '            End If
            '        Catch ex As Exception

            '        End Try

            '        'Try
            '        '    dr("TREATMENT_AGE_FULL") = dao_tabean_herb.fields.STORAGE_NAME & " " & dao_tabean_herb.fields.TREATMENT_AGE & " " & dao_tabean_herb.fields.TREATMENT_AGE_NAME
            '        'Catch ex As Exception

            '        'End Try
            '        Try
            '            If dao_tabean_herb.fields.TREATMENT_AGE Is Nothing Or dao_tabean_herb.fields.TREATMENT_AGE = 0 Then
            '                dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao_tabean_herb.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao_tabean_herb.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
            '            ElseIf dao_tabean_herb.fields.TREATMENT_AGE_MONTH Is Nothing Or dao_tabean_herb.fields.TREATMENT_AGE_MONTH = 0 Then
            '                dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao_tabean_herb.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao_tabean_herb.fields.TREATMENT_AGE & " " & "ปี"
            '            Else
            '                dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao_tabean_herb.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao_tabean_herb.fields.TREATMENT_AGE & " " & "ปี" & " " & dao_tabean_herb.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
            '            End If
            '            'dr("TREATMENT_AGE_FULL") = dao.fields.STORAGE_NAME & " " & dao.fields.TREATMENT_AGE & " " & dao.fields.TREATMENT_AGE_NAME

            '        Catch ex As Exception
            '            dr("TREATMENT_AGE_FULL") = dao_tabean_herb.fields.STORAGE_NAME & " " & dao_tabean_herb.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
            '        End Try
            '        'If dr("TYPE_SUB_ID") = 2 Then
            '        '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
            '        'End If
            '    Next
            '    dt.TableName = "XML_TABEAN_TBN_DRRQT_HERB"
            '    XML.DT_SHOW.DT1 = dt

            '    'Dim bao As New BAO.ClsDBSqlcommand
            '    Dim dt_lcn2 As New DataTable


            '    Dim DT_WHO As New DataTable
            '    Dim BAO_SP As New BAO_TABEAN_HERB.tb_main
            '    DT_WHO = BAO_SP.SP_XML_WHO_DALCN(_IDA)

            '    If TYPE_PERSON = 1 Then
            '        'XML.TYPE_PERSON_1 = TYPE_PERSON
            '        '    XML.BSN_THAINAME = THANM
            '        'XML.TYPE_PERSON_1 = TYPE_PERSON
            '        If dao_drrqt.fields.WHO_ID = True Then
            '            '        dt_lcn2 = BAO_SP.SP_XML_WHO_DALCN(dao_drrqt.fields.IDA)
            '            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)
            '            dt_lcn2 = bao.SP_Lisense_Name_and_Addr(dao_drrqt.fields.CITIZEN_ID_AUTHORIZE) ' bao_show.SP_LOCATION_BSN_BY_LCN_IDA(_IDA) 'ผู้ดำเนิน

            '            dt_lcn.Columns.Add("NATION")
            '            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '            dt_lcn.Columns.Add("CITIZEN_ID")
            '            'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '            dt_lcn.Columns.Add("NAME")
            '            dt_lcn.Columns.Add("THANM")
            '            dt_lcn.Columns.Add("THANAMEPLACE")
            '            dt_lcn.Columns.Add("PERSON_AGE")
            '            dt_lcn.Columns.Add("NATIONALITY_PERSON")


            '            For Each dr As DataRow In dt_lcn.Rows
            '                For Each dr2 As DataRow In dt_lcn2.Rows
            '                    Try
            '                        dr("thanm") = dr2("tha_fullname")
            '                        XML.BSN_THAINAME = dr2("tha_fullname")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thaaddr") = dr2("thaaddr")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("CITIZEN_ID") = dr2("identify")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thamu") = dr2("mu")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("tharoad") = dr2("tharoad")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thabuilding") = dr2("thabuilding")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thasoi") = dr2("thasoi")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thathmblnm") = dr2("thathmblnm")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thaamphrnm") = dr2("thaamphrnm")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thachngwtnm_nozip") = dr2("thachngwtnm")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("thachngwtnm") = dr2("thachngwtnm")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("zipcode") = dr2("zipcode")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("NAME") = NAME
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("tel") = dr2("tel")
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("fax") = dr2("fax")
            '                    Catch ex As Exception

            '                    End Try
            '                Next
            '                Try
            '                    dr("NATION") = NATION
            '                Catch ex As Exception

            '                End Try
            '                'Try
            '                '    If dr("tel") = Nothing Or dr("tel") = "-" Then
            '                '        If dr("Mobile") = Nothing Then
            '                '            dr("tel") = "-"
            '                '        Else
            '                '            dr("tel") = dr("Mobile")
            '                '        End If
            '                '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '                '        dr("tel") = dr("tel") & ", " & dr("Mobile")
            '                '    End If
            '                'Catch ex As Exception

            '                'End Try
            '                Try
            '                    dr("PERSON_AGE") = person_age
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '                Catch ex As Exception

            '                End Try
            '                'Try
            '                '    dr("CITIZEN_ID") = citizen_bsn
            '                'Catch ex As Exception

            '                'End Try
            '                'Try
            '                '    dr("NAME_JJ") = BSN_THAIFULLNAME
            '                'Catch ex As Exception

            '                'End Try
            '                'Try
            '                '    dr("THANM") = THANM
            '                'Catch ex As Exception

            '                'End Try
            '                Try
            '                    dr("THANAMEPLACE") = THANAMEPLACE
            '                Catch ex As Exception

            '                End Try
            '            Next

            '        Else
            '            'XML.TYPE_PERSON_1 = TYPE_PERSON
            '            '    XML.BSN_THAINAME = THANM
            '            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '            dt_lcn.Columns.Add("NATION")
            '            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '            dt_lcn.Columns.Add("CITIZEN_ID")
            '            dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '            dt_lcn.Columns.Add("NAME")
            '            dt_lcn.Columns.Add("THANM")
            '            dt_lcn.Columns.Add("THANAMEPLACE")
            '            dt_lcn.Columns.Add("PERSON_AGE")
            '            dt_lcn.Columns.Add("NATIONALITY_PERSON")

            '            For Each dr As DataRow In dt_lcn.Rows
            '                Try
            '                    dr("NATION") = NATION
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    If dr("tel") = Nothing Or dr("tel") = "-" Then
            '                        If dr("Mobile") = Nothing Then
            '                            dr("tel") = "-"
            '                        Else
            '                            dr("tel") = dr("Mobile")
            '                        End If
            '                    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '                        dr("tel") = dr("tel") & ", " & dr("Mobile")
            '                    End If
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("PERSON_AGE") = person_age
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("CITIZEN_ID") = citizen_bsn
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("NAME") = BSN_THAIFULLNAME
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("THANM") = THANM
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("THANAMEPLACE") = THANAMEPLACE
            '                Catch ex As Exception

            '                End Try
            '            Next
            '        End If

            '        dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_PERSON_1"
            '        XML.DT_SHOW.DT2 = dt_lcn
            '    ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '        'XML.TYPE_PERSON_99 = TYPE_PERSON
            '        If dao_drrqt.fields.WHO_ID = True Then
            '            If TYPE_PERSON_WHO = 1 Then
            '                'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
            '                'XML.TYPE_PERSON_99 = TYPE_PERSON
            '                XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
            '                dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_who.fields.FK_LCT)

            '                dt_lcn.Columns.Add("NATION")
            '                dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '                'dt_lcn.Columns.Add("CITIZEN_ID")
            '                'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '                dt_lcn.Columns.Add("NAME")
            '                dt_lcn.Columns.Add("THANM")
            '                dt_lcn.Columns.Add("THANAMEPLACE")
            '                dt_lcn.Columns.Add("PERSON_AGE")
            '                dt_lcn.Columns.Add("NATIONALITY_PERSON")

            '                For Each dr As DataRow In dt_lcn.Rows
            '                    Try
            '                        dr("NATION") = NATION
            '                    Catch ex As Exception

            '                    End Try
            '                    'Try
            '                    '    If dr("tel") = Nothing Or dr("tel") = "-" Then
            '                    '        If dr("Mobile") = Nothing Then
            '                    '            dr("tel") = "-"
            '                    '        Else
            '                    '            dr("tel") = dr("Mobile")
            '                    '        End If
            '                    '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '                    '        dr("tel") = dr("tel") & ", " & dr("Mobile")
            '                    '    End If
            '                    'Catch ex As Exception

            '                    'End Try
            '                    Try
            '                        dr("PERSON_AGE") = dao_tabean_herb.fields.PERSON_AGE
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("NATIONALITY_PERSON") = dao_tabean_herb.fields.NATIONALITY_PERSON
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("CITIZEN_ID") = citizen_bsn
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("NAME") = BSN_THAIFULLNAME
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("THANM") = THANM
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("THANAMEPLACE") = THANAMEPLACE
            '                    Catch ex As Exception

            '                    End Try
            '                Next
            '            ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '                'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
            '                'XML.TYPE_PERSON_99 = TYPE_PERSON
            '                XML.BSN_THAIFULLNAME = dao_tabean_herb.fields.AGENT_99
            '                dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)
            '                dt_lcn2 = bao.SP_Lisense_Name_and_Addr(dao_drrqt.fields.CITIZEN_ID_AUTHORIZE)

            '                dt_lcn.Columns.Add("NATION")
            '                dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '                dt_lcn.Columns.Add("NAME")
            '                dt_lcn.Columns.Add("THANM")
            '                dt_lcn.Columns.Add("THANAMEPLACE")
            '                dt_lcn.Columns.Add("PERSON_AGE")
            '                dt_lcn.Columns.Add("NATIONALITY_PERSON")
            '                dt_lcn.Columns.Add("CITIZEN_ID")
            '                dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")

            '                For Each dr As DataRow In dt_lcn.Rows
            '                    For Each dr2 As DataRow In dt_lcn2.Rows
            '                        Try
            '                            dr("thanm") = dr2("tha_fullname")
            '                            XML.BSN_THAINAME = dao_tabean_herb.fields.AGENT_99
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thaaddr") = dr2("thaaddr")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("CITIZEN_ID") = dao_tabean_herb.fields.IDEN_AGENT_99
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thamu") = dr2("mu")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("tharoad") = dr2("tharoad")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thabuilding") = dr2("thabuilding")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thasoi") = dr2("thasoi")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thathmblnm") = dr2("thathmblnm")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thaamphrnm") = dr2("thaamphrnm")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("thachngwtnm_nozip") = dr2("thachngwtnm")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("zipcode") = dr2("zipcode")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("NAME") = NAME
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("tel") = dr2("tel")
            '                        Catch ex As Exception

            '                        End Try
            '                        Try
            '                            dr("fax") = dr2("fax")
            '                        Catch ex As Exception

            '                        End Try
            '                    Next
            '                    Try
            '                        dr("NATION") = NATION
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("PERSON_AGE") = person_age
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
            '                    Catch ex As Exception

            '                    End Try
            '                    Try
            '                        dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '                    Catch ex As Exception

            '                    End Try

            '                    'Try
            '                    '    dr("THANM") = THANM
            '                    'Catch ex As Exception

            '                    'End Try
            '                    Try
            '                        dr("THANAMEPLACE") = THANAMEPLACE
            '                    Catch ex As Exception

            '                    End Try
            '                Next
            '            End If
            '        Else
            '            'XML.TYPE_PERSON_99 = TYPE_PERSON
            '            XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
            '            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '            dt_lcn.Columns.Add("NATION")
            '            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '            dt_lcn.Columns.Add("CITIZEN_ID")
            '            dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '            dt_lcn.Columns.Add("NAME")
            '            dt_lcn.Columns.Add("THANM")
            '            dt_lcn.Columns.Add("THANAMEPLACE")
            '            dt_lcn.Columns.Add("PERSON_AGE")
            '            dt_lcn.Columns.Add("NATIONALITY_PERSON")

            '            For Each dr As DataRow In dt_lcn.Rows
            '                Try
            '                    dr("NATION") = NATION
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    If dr("tel") = Nothing Or dr("tel") = "-" Then
            '                        If dr("Mobile") = Nothing Then
            '                            dr("tel") = "-"
            '                        Else
            '                            dr("tel") = dr("Mobile")
            '                        End If
            '                    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '                        dr("tel") = dr("tel") & ", " & dr("Mobile")
            '                    End If
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("PERSON_AGE") = person_age
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("CITIZEN_ID") = citizen_bsn
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("NAME") = BSN_THAIFULLNAME
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("THANM") = THANM
            '                Catch ex As Exception

            '                End Try
            '                Try
            '                    dr("THANAMEPLACE") = THANAMEPLACE
            '                Catch ex As Exception

            '                End Try

            '            Next
            '        End If

            '        dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_NITI_99"
            '        XML.DT_SHOW.DT3 = dt_lcn
            '    End If

            '    'If TYPE_PERSON = 1 Then
            '    '    'XML.TYPE_PERSON_1 = TYPE_PERSON
            '    '    XML.BSN_THAINAME = THANM
            '    '    dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '    '    dt_lcn.Columns.Add("NATION")
            '    '    dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '    '    dt_lcn.Columns.Add("CITIZEN_ID")
            '    '    dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '    '    dt_lcn.Columns.Add("NAME")
            '    '    dt_lcn.Columns.Add("THANM")
            '    '    dt_lcn.Columns.Add("THANAMEPLACE")
            '    '    dt_lcn.Columns.Add("PERSON_AGE")
            '    '    dt_lcn.Columns.Add("NATIONALITY_PERSON")

            '    '    For Each dr As DataRow In dt_lcn.Rows
            '    '        Try
            '    '            dr("NATION") = NATION
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            If dr("tel") = Nothing Or dr("tel") = "-" Then
            '    '                If dr("Mobile") = Nothing Then
            '    '                    dr("tel") = "-"
            '    '                Else
            '    '                    dr("tel") = dr("Mobile")
            '    '                End If
            '    '            ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '    '                dr("tel") = dr("tel") & ", " & dr("Mobile")
            '    '            End If
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("PERSON_AGE") = NATION
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("NATIONALITY_PERSON") = NATION
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("CITIZEN_ID") = citizen_bsn
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("NAME") = NAME
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("THANM") = THANM
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("THANAMEPLACE") = dr("thanameplace")
            '    '        Catch ex As Exception

            '    '        End Try
            '    '    Next
            '    '    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_PERSON_1"
            '    '    XML.DT_SHOW.DT2 = dt_lcn
            '    'ElseIf TYPE_PERSON = 99 Then
            '    '    'XML.TYPE_PERSON_99 = TYPE_PERSON
            '    '    XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
            '    '    dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '    '    dt_lcn.Columns.Add("NATION")
            '    '    dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '    '    dt_lcn.Columns.Add("CITIZEN_ID")
            '    '    dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '    '    dt_lcn.Columns.Add("NAME")
            '    '    dt_lcn.Columns.Add("THANM")
            '    '    dt_lcn.Columns.Add("THANAMEPLACE")

            '    '    For Each dr As DataRow In dt_lcn.Rows
            '    '        Try
            '    '            dr("NATION") = NATION
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            If dr("tel") = Nothing Or dr("tel") = "-" Then
            '    '                If dr("Mobile") = Nothing Then
            '    '                    dr("tel") = "-"
            '    '                Else
            '    '                    dr("tel") = dr("Mobile")
            '    '                End If
            '    '            ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
            '    '                dr("tel") = dr("tel") & ", " & dr("Mobile")
            '    '            End If
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("CITIZEN_ID") = citizen_bsn
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("NAME") = NAME
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("THANM") = THANM
            '    '        Catch ex As Exception

            '    '        End Try
            '    '        Try
            '    '            dr("THANAMEPLACE") = dr("thanameplace")
            '    '        Catch ex As Exception

            '    '        End Try

            '    '    Next
            '    '    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_NITI_99"
            '    '    XML.DT_SHOW.DT3 = dt_lcn
            '    'End If
            '    If dao_drrqt.fields.WHO_ID = False Then
            '        If TYPE_PERSON = 1 Then
            '            XML.BSN_THAINAME = THANM
            '        ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '            XML.BSN_THAINAME = BSN_THAIFULLNAME
            '        End If
            '    End If

            '    If dao_lcn.fields.PROCESS_ID = 121 Then
            '        Dim dao_lcn_HPI As New DAO_LCN.TB_dalcn
            '        dao_lcn_HPI.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 121)

            '        Dim dao_lcn_bsn_HPI As New DAO_LCN.TB_DALCN_LOCATION_BSN
            '        dao_lcn_bsn_HPI.GetDataby_LCN_IDA(_IDA_LCN)

            '        Dim dao_cpn_HPI As New DAO_CPN.clsDBsyslcnsid
            '        Try

            '            dao_cpn_HPI.GetDataby_identify(dao_lcn_HPI.fields.CITIZEN_ID_AUTHORIZE)

            '        Catch ex As Exception

            '        End Try

            '        Dim TYPE_PERSON_HPI As Integer = dao_cpn_HPI.fields.type
            '        Dim LCNNO_DISPLAY_NEW_HPI As String = dao_lcn_HPI.fields.LCNNO_DISPLAY_NEW
            '        Dim THANM_HPI As String = dao_lcn_HPI.fields.thanm
            '        Dim BSN_THAIFULLNAME_HPI As String = dao_lcn_bsn_HPI.fields.BSN_THAIFULLNAME

            '        dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPI.fields.FK_IDA)

            '        dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPI")
            '        dt_lcn_location.Columns.Add("THANM_HPI")
            '        dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPI")

            '        For Each dr As DataRow In dt_lcn_location.Rows
            '            Try
            '                dr("LCNNO_DISPLAY_NEW_HPI") = LCNNO_DISPLAY_NEW_HPI
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANM_HPI") = THANM
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                If TYPE_PERSON_HPI = 1 Then
            '                    dr("BSN_THAIFULLNAME_HPI") = "-"
            '                Else
            '                    dr("BSN_THAIFULLNAME_HPI") = BSN_THAIFULLNAME_HPI

            '                End If
            '            Catch ex As Exception

            '            End Try

            '        Next
            '        dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPI"
            '        XML.DT_SHOW.DT4 = dt_lcn_location
            '    ElseIf dao_lcn.fields.PROCESS_ID = 122 Then
            '        Dim dao_lcn_HPM As New DAO_LCN.TB_dalcn
            '        dao_lcn_HPM.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 122)

            '        Dim dao_lcn_bsn_HPM As New DAO_LCN.TB_DALCN_LOCATION_BSN
            '        dao_lcn_bsn_HPM.GetDataby_LCN_IDA(_IDA_LCN)

            '        Dim dao_cpn_HPM As New DAO_CPN.clsDBsyslcnsid
            '        Try

            '            dao_cpn_HPM.GetDataby_identify(dao_lcn_HPM.fields.CITIZEN_ID_AUTHORIZE)

            '        Catch ex As Exception

            '        End Try
            '        Dim TYPE_PERSON_HPM As Integer = dao_cpn_HPM.fields.type
            '        Dim LCNNO_DISPLAY_NEW_HPM As String = dao_lcn_HPM.fields.LCNNO_DISPLAY_NEW
            '        Dim THANM_HPM As String = dao_lcn_HPM.fields.thanm
            '        Dim BSN_THAIFULLNAME_HPM As String = dao_lcn_bsn_HPM.fields.BSN_THAIFULLNAME

            '        dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPM.fields.FK_IDA)

            '        dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPM")
            '        dt_lcn_location.Columns.Add("THANM_HPM")
            '        dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPM")
            '        dt_lcn_location.Columns.Add("TREATMENT_AGE_FULL")

            '        For Each dr As DataRow In dt_lcn_location.Rows
            '            Try
            '                dr("LCNNO_DISPLAY_NEW_HPM") = LCNNO_DISPLAY_NEW_HPM
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANM_HPM") = THANM
            '            Catch ex As Exception

            '            End Try
            '            If TYPE_PERSON_HPM = 1 Then
            '                dr("BSN_THAIFULLNAME_HPM") = "-"
            '            Else
            '                dr("BSN_THAIFULLNAME_HPM") = BSN_THAIFULLNAME_HPM

            '            End If
            '        Next

            '        dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPM"
            '        XML.DT_SHOW.DT5 = dt_lcn_location
            '    End If

            '    Dim bao_sp2 As New BAO.ClsDBSqlcommand
            '    XML.DT_SHOW.DT6 = bao_sp2.SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2(_IDA_DQ)
            '    XML.DT_SHOW.DT6.TableName = "SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2"
            '    Try
            '        If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
            '            XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
            '        Else
            '            XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
            '        End If
            '    Catch ex As Exception

            '    End Try

            '    If TYPE_PERSON = 1 Then
            '        XML.THANM_THAIFULLNAME = THANM
            '    ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '        XML.THANM_THAIFULLNAME = BSN_THAIFULLNAME
            '    End If

            '    Return XML
            'End Function

            Public Function gen_xml_tbn_2(ByVal _IDA As Integer, ByVal _IDA_DQ As Integer, ByVal _IDA_LCN As Integer)
                Dim XML As New CLASS_DRRQT

                Dim bao_lcn As New BAO.BAO
                Dim BAO As New BAO.BAO

                Dim dt_lcn As New DataTable
                Dim dt_lcn_location As New DataTable

                Dim dao_lcn As New DAO_LCN.TB_dalcn
                dao_lcn.GetDataby_IDA(_IDA_LCN)
                Dim dao_drrqt As New DAO_TABEAN.ClsDBdrrqt
                dao_drrqt.GetDataby_IDA(_IDA_DQ)
                Dim dao_tabean_herb As New DAO_TABEAN.TB_TABEAN_HERB
                dao_tabean_herb.GetdatabyID_FK_IDA_DQ(_IDA_DQ)
                dao_drrqt.GetDataby_IDA(_IDA_DQ)
                XML.DRRQT = dao_drrqt.fields
                Dim IDENTIFY As String = ""
                If dao_drrqt.fields.CITIZEN_ID_AUTHORIZE = "" Then
                    IDENTIFY = dao_drrqt.fields.IDENTIFY
                Else
                    IDENTIFY = dao_drrqt.fields.CITIZEN_ID_AUTHORIZE
                End If
                Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
                dao_cpn.GetDataby_identify(IDENTIFY)

                Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
                dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)

                Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                Try
                    dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim THANM As String = dao_lcn.fields.thanm
                If THANM = "" Or THANM Is Nothing Then
                    THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm & " " & dao_customer.fields.thalnm
                Else
                    THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
                End If

                Dim TYPE_PERSON As Integer = dao_cpn.fields.type
                Dim NATION As String = dao_lcn.fields.NATION
                ' Dim THANM As String = dao_lcn.fields.thanm

                Dim CITIZEN_ID As String = IDENTIFY
                Dim CITIZEN_ID_AUTHORIZE As String = IDENTIFY
                Dim NAME As String = dao_drrqt.fields.CREATE_BY
                Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace

                Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
                Try
                    tb_location.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim dao_pfx As New DAO_CPN.TB_sysprefix
                Dim BSN_THAIFULLNAME As String = ""
                Dim dao_who As New DAO_LCN.TB_WHO_DALCN
                dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
                Dim WHO_NAME As String = ""
                WHO_NAME = dao_who.fields.THANM_NAME
                Try
                    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
                    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
                    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
                    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
                    'If dao_drrqt.fields.WHO_ID = True Then
                    '    BSN_THAIFULLNAME = WHO_NAME
                    'Else
                    '    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
                    'End If
                    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

                Catch ex As Exception

                End Try

                Dim dt As New DataTable
                Dim date_rcv_day As Date
                Dim date_rcv_month As Date
                Dim date_rcv_year As Date

                Dim date_rgt_day As Date
                Dim date_rgt_month As Date
                Dim date_rgt_year As Date

                If dao_drrqt.fields.STATUS_ID = 6 Or dao_drrqt.fields.STATUS_ID = 11 Or dao_drrqt.fields.STATUS_ID = 12 Or dao_drrqt.fields.STATUS_ID = 13 Then
                    date_rcv_day = dao_drrqt.fields.rcvdate
                    date_rcv_month = dao_drrqt.fields.rcvdate
                    date_rcv_year = dao_drrqt.fields.rcvdate

                    XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
                ElseIf dao_drrqt.fields.STATUS_ID = 8 Then

                    date_rcv_day = dao_drrqt.fields.rcvdate
                    date_rcv_month = dao_drrqt.fields.rcvdate
                    date_rcv_year = dao_drrqt.fields.rcvdate

                    date_rgt_day = dao_drrqt.fields.appdate
                    date_rgt_month = dao_drrqt.fields.appdate
                    date_rgt_year = dao_drrqt.fields.appdate

                    XML.date_rgt_day = date_rgt_day.Day.ToString()
                    XML.date_rgt_month = date_rgt_month.ToString("MMMM")
                    XML.date_rgt_year = con_year(date_rgt_year.Year)

                    Try
                        Dim a As String = date_rgt_day.Day.ToString() - 1
                        Dim b As String = date_rgt_month.ToString("MMMM")
                        Dim c As String = con_year(date_rgt_year.Year) + 5

                        XML.date_rgt_exdate_day = a
                        XML.date_rgt_exdate_month = b
                        XML.date_rgt_exdate_year = c

                        XML.RGTNO_DATE_END = a & " " & b & " " & c
                    Catch ex As Exception

                    End Try

                    XML.RGTNO_DATE = date_rgt_day.Day.ToString() & " " & date_rgt_month.ToString("MMMM") & " " & con_year(date_rgt_year.Year)
                    XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
                End If

                dt = BAO.SP_XML_DRUG_DRRQT(_IDA_DQ)
                dt.Columns.Add("TYPE_SUB_NAME_CHANGE")
                For Each dr As DataRow In dt.Rows

                    If dr("TYPE_SUB_ID") = 1 Then
                        dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนไทย"
                    ElseIf dr("TYPE_SUB_ID") = 2 Then
                        dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
                    ElseIf dr("TYPE_SUB_ID") = 3 Then
                        dr("TYPE_SUB_NAME_CHANGE") = "ยาพัฒนาจากสมุนไพร"
                    End If

                    If dr("LCN_NAME") = Nothing Then
                        dr("LCN_NAME") = THANM
                    End If

                    Try
                        If dao_tabean_herb.fields.FOREIGN_NAME = "" Then
                            dr("FOREIGN_NAME") = "-"
                        End If
                    Catch ex As Exception

                    End Try
                    Try
                        If dao_tabean_herb.fields.FOREIGN_NAME = "" Then
                            dr("FOREIGN_NAME") = "-"
                        End If
                    Catch ex As Exception

                    End Try
                    Try
                        If dao_tabean_herb.fields.FOREIGN_NAME_PLACE = "" Then
                            dr("FOREIGN_NAME_PLACE") = "-"
                        End If
                    Catch ex As Exception

                    End Try
                Next
                dt.TableName = "XML_TABEAN_TBN_DRRQT_HERB"
                XML.DT_SHOW.DT1 = dt

                If TYPE_PERSON = 1 Then
                    'XML.TYPE_PERSON_1 = TYPE_PERSON
                    dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                    dt_lcn.Columns.Add("NATION")
                    dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                    dt_lcn.Columns.Add("CITIZEN_ID")
                    dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                    dt_lcn.Columns.Add("NAME")
                    dt_lcn.Columns.Add("THANM")
                    dt_lcn.Columns.Add("THANAMEPLACE")

                    For Each dr As DataRow In dt_lcn.Rows
                        Try
                            dr("NATION") = NATION
                        Catch ex As Exception

                        End Try
                        Try
                            dr("TYPE_PERSON_CPN") = TYPE_PERSON
                        Catch ex As Exception

                        End Try
                        Try
                            dr("CITIZEN_ID") = CITIZEN_ID
                        Catch ex As Exception

                        End Try
                        Try
                            dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
                        Catch ex As Exception

                        End Try
                        Try
                            dr("NAME") = NAME
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM") = THANM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANAMEPLACE") = THANAMEPLACE
                        Catch ex As Exception

                        End Try
                    Next
                ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
                    'XML.TYPE_PERSON_99 = TYPE_PERSON
                    dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                    dt_lcn.Columns.Add("NATION")
                    dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                    dt_lcn.Columns.Add("CITIZEN_ID")
                    dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                    dt_lcn.Columns.Add("NAME")
                    dt_lcn.Columns.Add("THANM")
                    dt_lcn.Columns.Add("THANAMEPLACE")

                    For Each dr As DataRow In dt_lcn.Rows
                        Try
                            dr("NATION") = NATION
                        Catch ex As Exception

                        End Try
                        Try
                            dr("TYPE_PERSON_CPN") = TYPE_PERSON
                        Catch ex As Exception

                        End Try
                        Try
                            dr("CITIZEN_ID") = CITIZEN_ID
                        Catch ex As Exception

                        End Try
                        Try
                            dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
                        Catch ex As Exception

                        End Try
                        Try
                            dr("NAME") = NAME
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM") = THANM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANAMEPLACE") = THANAMEPLACE
                        Catch ex As Exception

                        End Try

                    Next

                End If
                dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS"
                XML.DT_SHOW.DT2 = dt_lcn

                If dao_drrqt.fields.WHO_ID = True Then
                    If TYPE_PERSON = 1 Then
                        XML.THANM_THAIFULLNAME = THANM
                    ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
                        XML.THANM_THAIFULLNAME = THANM
                    End If
                Else
                    XML.THANM_THAIFULLNAME = THANM
                End If

                If TYPE_PERSON = 1 Then
                    XML.BSN_THAINAME = THANM
                ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
                    XML.BSN_THAINAME = BSN_THAIFULLNAME
                End If
                Return XML
            End Function
            Public Function gen_xml_tbn_2_new(ByVal Newcode As String, ByVal Process_ID As Integer)
                Dim XML As New CLASS_DR_HERB

                Dim bao_lcn As New BAO.BAO
                Dim BAO As New BAO.BAO
                Dim dao As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
                dao.GetDataby_u1_frn_no(Newcode)
                Dim dao_lcn As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                dao_lcn.GetDataby_u1(dao.fields.Newcode_not)
                If dao.fields.rgttpcd <> "K" Then
                    dao.fields.engfrgnnm = "-"
                    dao.fields.engfrgnnm_addr = "-"
                End If
                XML.XML_DRUG_PRODUCT_HERB = dao.fields
                Dim dt_tabean As New DataTable
                Dim dt_lcn As New DataTable
                dt_tabean = BAO.SP_SEARCH_PEOPLE_HERB(Newcode)
                dt_lcn = BAO.SP_SEARCH_STAFF_HERB_LCN_BY_NEWCODE_NOT(dao.fields.Newcode_not)
                dt_tabean.TableName = "SP_SEARCH_PEOPLE_HERB"
                dt_lcn.TableName = "SP_SEARCH_STAFF_HERB_LCN"
                XML.DT_SHOW.DT1 = dt_tabean
                XML.DT_SHOW.DT2 = dt_lcn

                Dim date_rgt_day As Date
                Dim date_rgt_month As Date
                Dim date_rgt_year As Date
                date_rgt_day = dao.fields.appdate
                date_rgt_month = dao.fields.appdate
                date_rgt_year = dao.fields.appdate

                Dim month As Integer = 0
                month = date_rgt_month.Month ' Specify the month number here

                ' Create an instance of the Thai culture
                Dim thaiCulture As New CultureInfo("th-TH")

                ' Get the localized month name
                Dim monthName As String = thaiCulture.DateTimeFormat.GetMonthName(month)
                XML.date_rgt_day = date_rgt_day.Day.ToString()
                'XML.date_rgt_month = date_rgt_month.ToString("MMMM")
                XML.date_rgt_month = monthName
                XML.date_rgt_year = con_year(date_rgt_year.Year)

                Dim date_exdate_day As Date
                Dim date_date_rgt_exdate_monthmonth As Date
                Dim date_exdate_year As Date
                date_exdate_day = dao.fields.expdate
                date_date_rgt_exdate_monthmonth = dao.fields.expdate
                date_exdate_year = dao.fields.expdate
                Try


                    Dim a As String = date_exdate_day.Day.ToString()
                    Dim b As String = date_date_rgt_exdate_monthmonth.ToString("MMMM")
                    Dim c As String = con_year(date_exdate_year.Year) + 5

                    month = date_exdate_day.Month
                    monthName = thaiCulture.DateTimeFormat.GetMonthName(month)

                    XML.date_exdate_day = a
                    'XML.date_exdate_month = date_date_rgt_exdate_monthmonth.ToString("MMMM")
                    XML.date_exdate_month = monthName
                    XML.date_exdate_year = c
                    'XML.RGTNO_DATE_END = a & " " & b & " " & c

                    a = date_exdate_day.Day.ToString() + 1
                    b = date_date_rgt_exdate_monthmonth.ToString("MMMM")
                    c = con_year(date_exdate_year.Year)

                    month = date_exdate_day.Month
                    monthName = thaiCulture.DateTimeFormat.GetMonthName(month)

                    XML.DAY_RENEW = a
                    XML.MONTH_RENEW = b
                    XML.YEAR_RENEW = c
                    XML.DATE_RENEW_TH = a & " " & b & " " & c
                Catch ex As Exception

                End Try
                Dim TYPE_LCN As String = ""
                If dao_lcn.fields.lcntpcd = "ผสม" Then
                    TYPE_LCN = "ผลิต"
                ElseIf dao_lcn.fields.lcntpcd = "นสม" Then
                    TYPE_LCN = "นำเข้า"
                ElseIf dao_lcn.fields.lcntpcd = "ขสม" Then
                    TYPE_LCN = "ขาย"
                End If
                XML.LCN_TYPE_NAME = TYPE_LCN
                XML.STAFF_APPROVE = "นายฉัตรชัย พานิชศุภภรณ์"

                ''Dim url As String = "https://excercitium.fda.moph.go.th/FDA_TXC/TXC_SEARCH/FRM_TXC_SEARCH_QRCODE.aspx?lcnno=" & b64encode(dao.fields.LCNNO) & "&wotype=" & b64encode("3") & "&pvncd=" & b64encode(dao.fields.PVNCD) & "&lcntpcd=" & b64encode(dao.fields.lcntpcd)
                'Dim url As String = "www.google.com"
                ''url = "https://meshlog.fda.moph.go.th/FDA_TABEAN_HERB_DEMO/PDF/PDF_PREVIEW.aspx?Newcode=" + Newcode + "&PROCESS_ID=" + Process_ID
                'Dim cls_qr As New QR_CODE.GEN_QR_CODE
                'XML.QR_CODE = cls_qr.GenerateQR_TO_BASE64(20, 20, url)

                Return XML
            End Function
            'Public Function gen_xml_tbn_2_renew(ByVal _IDA As Integer, ByVal _IDA_DQ As Integer, ByVal _IDA_LCN As Integer)
            '    Dim XML As New CLASS_DRRQT

            '    Dim bao_lcn As New BAO.BAO

            '    Dim dt_lcn As New DataTable
            '    Dim dt_lcn_location As New DataTable

            '    Dim dao_lcn As New DAO_LCN.TB_dalcn
            '    dao_lcn.GetDataby_IDA(_IDA_LCN)
            '    Dim dao_drrgt As New DAO_TABEAN.ClsDBdrrgt
            '    dao_drrgt.GetDataby_IDA(_IDA_DQ)
            '    Dim dao_drrqt As New DAO_TABEAN.ClsDBdrrqt

            '    Dim dao_tabean_herb As New DAO_TABEAN.TB_TABEAN_HERB
            '    Try
            '        dao_drrqt.GetDataby_IDA(dao_drrgt.fields.FK_DRRQT)
            '        dao_tabean_herb.GetdatabyID_FK_IDA_DQ(dao_drrgt.fields.FK_DRRQT)
            '    Catch ex As Exception

            '    End Try
            '    dao_drrqt.GetDataby_IDA(_IDA_DQ)

            '    Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
            '    dao_cpn.GetDataby_identify(dao_drrgt.fields.IDENTIFY)

            '    Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
            '    dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)

            '    Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
            '    Try
            '        dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
            '    Catch ex As Exception

            '    End Try
            '    Dim THANM As String = dao_lcn.fields.thanm
            '    If THANM = "" Or THANM Is Nothing Then
            '        THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm & " " & dao_customer.fields.thalnm
            '    Else
            '        THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
            '    End If

            '    Dim TYPE_PERSON As Integer = dao_cpn.fields.type
            '    Dim NATION As String = dao_lcn.fields.NATION
            '    ' Dim THANM As String = dao_lcn.fields.thanm

            '    Dim CITIZEN_ID As String = dao_drrqt.fields.IDENTIFY
            '    Dim CITIZEN_ID_AUTHORIZE As String = dao_drrqt.fields.CITIZEN_ID_AUTHORIZE
            '    Dim NAME As String = dao_drrqt.fields.CREATE_BY
            '    Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace

            '    Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
            '    Try
            '        tb_location.GetDataby_LCN_IDA(_IDA_LCN)
            '    Catch ex As Exception

            '    End Try
            '    Dim dao_pfx As New DAO_CPN.TB_sysprefix
            '    Dim BSN_THAIFULLNAME As String = ""
            '    Dim dao_who As New DAO_WHO.TB_WHO_DALCN
            '    dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
            '    Dim WHO_NAME As String = ""
            '    WHO_NAME = dao_who.fields.THANM_NAME
            '    Try
            '        dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
            '        Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
            '        Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
            '        Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
            '        'If dao_drrqt.fields.WHO_ID = True Then
            '        '    BSN_THAIFULLNAME = WHO_NAME
            '        'Else
            '        '    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
            '        'End If
            '        BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

            '    Catch ex As Exception

            '    End Try
            '    'Try
            '    '    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
            '    '    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
            '    '    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
            '    '    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
            '    '    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

            '    'Catch ex As Exception

            '    'End Try

            '    Dim dt As New DataTable
            '    Dim date_rcv_day As Date
            '    Dim date_rcv_month As Date
            '    Dim date_rcv_year As Date

            '    Dim date_rgt_day As Date
            '    Dim date_rgt_month As Date
            '    Dim date_rgt_year As Date

            '    If dao_drrqt.fields.STATUS_ID = 6 Or dao_drrqt.fields.STATUS_ID = 11 Or dao_drrqt.fields.STATUS_ID = 12 Or dao_drrqt.fields.STATUS_ID = 13 Then
            '        date_rcv_day = dao_drrqt.fields.rcvdate
            '        date_rcv_month = dao_drrqt.fields.rcvdate
            '        date_rcv_year = dao_drrqt.fields.rcvdate

            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    ElseIf dao_drrqt.fields.STATUS_ID = 8 Then

            '        date_rcv_day = dao_drrqt.fields.rcvdate
            '        date_rcv_month = dao_drrqt.fields.rcvdate
            '        date_rcv_year = dao_drrqt.fields.rcvdate

            '        date_rgt_day = dao_drrqt.fields.appdate
            '        date_rgt_month = dao_drrqt.fields.appdate
            '        date_rgt_year = dao_drrqt.fields.appdate

            '        XML.date_rgt_day = date_rgt_day.Day.ToString()
            '        XML.date_rgt_month = date_rgt_month.ToString("MMMM")
            '        XML.date_rgt_year = con_year(date_rgt_year.Year)

            '        Try
            '            Dim a As String = date_rgt_day.Day.ToString() - 1
            '            Dim b As String = date_rgt_month.ToString("MMMM")
            '            Dim c As String = con_year(date_rgt_year.Year) + 5

            '            XML.date_rgt_exdate_day = a
            '            XML.date_rgt_exdate_month = b
            '            XML.date_rgt_exdate_year = c

            '            XML.RGTNO_DATE_END = a & " " & b & " " & c
            '        Catch ex As Exception

            '        End Try

            '        XML.RGTNO_DATE = date_rgt_day.Day.ToString() & " " & date_rgt_month.ToString("MMMM") & " " & con_year(date_rgt_year.Year)
            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    End If

            '    dt = BAO.SP_XML_DRUG_DRRQT(_IDA_DQ)
            '    dt.Columns.Add("TYPE_SUB_NAME_CHANGE")
            '    For Each dr As DataRow In dt.Rows

            '        If dr("TYPE_SUB_ID") = 1 Then
            '            dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนไทย"
            '        ElseIf dr("TYPE_SUB_ID") = 2 Then
            '            dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
            '        ElseIf dr("TYPE_SUB_ID") = 3 Then
            '            dr("TYPE_SUB_NAME_CHANGE") = "ยาพัฒนาจากสมุนไพร"
            '        End If

            '        If dr("LCN_NAME") = Nothing Then
            '            dr("LCN_NAME") = THANM
            '        End If

            '        Try
            '            If dao_tabean_herb.fields.FOREIGN_NAME = "" Then
            '                dr("FOREIGN_NAME") = "-"
            '            End If
            '        Catch ex As Exception

            '        End Try
            '        Try
            '            If dao_tabean_herb.fields.FOREIGN_NAME = "" Then
            '                dr("FOREIGN_NAME") = "-"
            '            End If
            '        Catch ex As Exception

            '        End Try
            '        Try
            '            If dao_tabean_herb.fields.FOREIGN_NAME_PLACE = "" Then
            '                dr("FOREIGN_NAME_PLACE") = "-"
            '            End If
            '        Catch ex As Exception

            '        End Try
            '    Next
            '    dt.TableName = "XML_TABEAN_TBN_DRRQT_HERB"
            '    XML.DT_SHOW.DT1 = dt

            '    If TYPE_PERSON = 1 Then
            '        'XML.TYPE_PERSON_1 = TYPE_PERSON
            '        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '        dt_lcn.Columns.Add("NATION")
            '        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '        dt_lcn.Columns.Add("CITIZEN_ID")
            '        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '        dt_lcn.Columns.Add("NAME")
            '        dt_lcn.Columns.Add("THANM")
            '        dt_lcn.Columns.Add("THANAMEPLACE")

            '        For Each dr As DataRow In dt_lcn.Rows
            '            Try
            '                dr("NATION") = NATION
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("CITIZEN_ID") = CITIZEN_ID
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("NAME") = NAME
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANM") = THANM
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANAMEPLACE") = THANAMEPLACE
            '            Catch ex As Exception

            '            End Try
            '        Next
            '    ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '        'XML.TYPE_PERSON_99 = TYPE_PERSON
            '        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

            '        dt_lcn.Columns.Add("NATION")
            '        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
            '        dt_lcn.Columns.Add("CITIZEN_ID")
            '        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
            '        dt_lcn.Columns.Add("NAME")
            '        dt_lcn.Columns.Add("THANM")
            '        dt_lcn.Columns.Add("THANAMEPLACE")

            '        For Each dr As DataRow In dt_lcn.Rows
            '            Try
            '                dr("NATION") = NATION
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("TYPE_PERSON_CPN") = TYPE_PERSON
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("CITIZEN_ID") = CITIZEN_ID
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("NAME") = NAME
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANM") = THANM
            '            Catch ex As Exception

            '            End Try
            '            Try
            '                dr("THANAMEPLACE") = THANAMEPLACE
            '            Catch ex As Exception

            '            End Try

            '        Next

            '    End If
            '    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS"
            '    XML.DT_SHOW.DT2 = dt_lcn

            '    'Dim dt_formula As DataTable
            '    'Dim bao_master_2 As New BAO.ClsDBSqlcommand
            '    'dt_formula = bao_master_2.SP_drug_formula_JJ(_IDA)
            '    'dt_formula.TableName = "XML_TABEAN_FORMULA_JJ"
            '    'XML.DT_SHOW.DT3 = dt_formula

            '    If dao_drrqt.fields.WHO_ID = True Then
            '        If TYPE_PERSON = 1 Then
            '            XML.THANM_THAIFULLNAME = THANM
            '        ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '            XML.THANM_THAIFULLNAME = THANM
            '        End If
            '    Else
            '        XML.THANM_THAIFULLNAME = THANM
            '    End If

            '    If TYPE_PERSON = 1 Then
            '        XML.BSN_THAINAME = THANM
            '    ElseIf TYPE_PERSON = 99 Or TYPE_PERSON = 3 Then
            '        XML.BSN_THAINAME = BSN_THAIFULLNAME
            '    End If
            '    Return XML
            'End Function
            'Public Function gen_xml_approve(ByVal _IDA As Integer, ByVal _IDA_DQ As Integer, ByVal _IDA_LCN As Integer)
            '    Dim XML As New CLASS_DRRQT

            '    Dim bao_lcn As New BAO_SHOW

            '    Dim dt_lcn As New DataTable
            '    Dim dt_lcn_location As New DataTable

            '    Dim dao_lcn As New DAO_LCN.TB_dalcn
            '    dao_lcn.GetDataby_IDA(_IDA_LCN)

            '    Dim dao_drrqt As New DAO_DRUG.ClsDBdrrqt
            '    dao_drrqt.GetDataby_IDA(_IDA_DQ)

            '    Dim dao_tabean_herb As New DAO_TABEAN_HERB.TB_TABEAN_HERB
            '    dao_tabean_herb.GetdatabyID_IDA(_IDA)

            '    Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
            '    dao_cpn.GetDataby_identify(dao_drrqt.fields.CITIZEN_ID_AUTHORIZE)

            '    Dim TYPE_PERSON As Integer = dao_cpn.fields.type
            '    Dim NATION As String = dao_lcn.fields.NATION
            '    Dim THANM As String = dao_lcn.fields.thanm

            '    Dim CITIZEN_ID As String = dao_drrqt.fields.IDENTIFY
            '    Dim CITIZEN_ID_AUTHORIZE As String = dao_drrqt.fields.CITIZEN_ID_AUTHORIZE
            '    Dim NAME As String = dao_drrqt.fields.CREATE_BY
            '    Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace

            '    Dim dt As New DataTable
            '    Dim BAO As New BAO_TABEAN_HERB.tb_main

            '    Dim date_rcv_day As Date
            '    Dim date_rcv_month As Date
            '    Dim date_rcv_year As Date

            '    Dim date_rgt_day As Date
            '    Dim date_rgt_month As Date
            '    Dim date_rgt_year As Date

            '    If dao_drrqt.fields.STATUS_ID = 6 Or dao_drrqt.fields.STATUS_ID = 11 Or dao_drrqt.fields.STATUS_ID = 12 Or dao_drrqt.fields.STATUS_ID = 13 Then
            '        date_rcv_day = dao_drrqt.fields.rcvdate
            '        date_rgt_month = dao_drrqt.fields.rcvdate
            '        date_rgt_year = dao_drrqt.fields.rcvdate

            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.Month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    End If
            '    If dao_drrqt.fields.STATUS_ID = 8 Then
            '        date_rgt_day = dao_drrqt.fields.appdate
            '        date_rgt_month = dao_drrqt.fields.appdate
            '        date_rgt_year = dao_drrqt.fields.appdate

            '        XML.date_rgt_day = date_rgt_day.Day.ToString()
            '        XML.date_rgt_month = date_rgt_month.ToString("MMMM")
            '        XML.date_rgt_year = con_year(date_rgt_year.Year)

            '        Try
            '            Dim a As String = date_rgt_day.Day.ToString() - 1
            '            Dim b As String = date_rgt_month.ToString("MMMM")
            '            Dim c As String = con_year(date_rgt_year.Year) + 1

            '            XML.date_rgt_exdate_day = a
            '            XML.date_rgt_exdate_month = b
            '            XML.date_rgt_exdate_year = c
            '        Catch ex As Exception

            '        End Try

            '        XML.RGTNO_DATE = date_rgt_day.Day.ToString() & " " & date_rgt_month.ToString("MMMM") & " " & con_year(date_rgt_year.Year)
            '        XML.RCVNO_DATE = date_rcv_day.Day.ToString() & " " & date_rcv_month.ToString("MMMM") & " " & con_year(date_rcv_year.Year)
            '    End If

            '    Dim PROCESS_NAME As String = ""

            '    If dao_drrqt.fields.PROCESS_ID = 20101 Then
            '        PROCESS_NAME = "การขึ้นทะเบียนผลิตภัณฑ์สมุนไพร ประเภทยาแผนไทย"
            '    ElseIf dao_drrqt.fields.PROCESS_ID = 20102 Then
            '        PROCESS_NAME = "การขึ้นทะเบียนผลิตภัณฑ์สมุนไพร ประเภทยาตามองค์ความรู้การแพทย์ทางเลือก"
            '    ElseIf dao_drrqt.fields.PROCESS_ID = 20103 Then
            '        PROCESS_NAME = "การขึ้นทะเบียนผลิตภัณฑ์สมุนไพร ประเภทยาพัฒนาจากสมุนไพร"
            '    ElseIf dao_drrqt.fields.PROCESS_ID = 20104 Then
            '        PROCESS_NAME = "การขึ้นทะเบียนผลิตภัณฑ์สมุนไพร ประเภทผลิตภัณฑ์สมุนไพรเพื่อสุขภาพ"
            '    End If

            '    XML.PROCESS_NAME = PROCESS_NAME

            '    dt = BAO.SP_XML_DRUG_DRRQT(_IDA_DQ)

            '    dt.TableName = "XML_TABEAN_TBN_DRRQT_HERB"
            '    XML.DT_SHOW.DT1 = dt

            '    Return XML
            'End Function

        End Class
        Public Class TABEAN_RENEW
            Inherits Center
            Public Function Gen_XML_RENREW_TBN(ByVal IDA As Integer, ByVal FK_IDA As Integer, ByVal _IDA_LCN As Integer)
                Dim bao_lcn As New BAO.BAO
                Dim bao_lcn_location As New BAO.BAO
                Dim XML As New CLASS_DR_RENEW
                Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
                Dim Process_id As String = ""
                Dim CLS_TABEAN_RENEW As New TABEAN_RENEW
                dao.GetdatabyID_IDA(IDA)
                XML.TABEAN_RENEW = dao.fields
                Process_id = dao.fields.PROCESS_ID

                Dim dao_drrgt As New DAO_TABEAN.ClsDBdrrgt
                dao_drrgt.GetDataby_IDA(FK_IDA)
                Dim dao_drrqt As New DAO_TABEAN.ClsDBdrrqt
                Try
                    dao_drrqt.GetDataby_IDA(dao_drrgt.fields.FK_DRRQT)
                    'dao_drrqt.GetDataby_IDA(FK_IDA)
                    FK_IDA = dao_drrqt.fields.IDA
                Catch ex As Exception
                    FK_IDA = dao.fields.FK_IDA
                End Try
                Dim dao_tabean_herb As New DAO_TABEAN.TB_TABEAN_HERB
                Dim dao_product As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
                dao_product.GetDataby_u1_frn_no(dao.fields.Newcode_U)
                Dim dao_licen As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                dao_licen.GetDataby_u1(dao_product.fields.Newcode_not)
                Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                Try
                    dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim dao_lc As New DAO_LCN.TB_dalcn
                Dim IDA_LC As Integer
                Try
                    dao_lc.GetDataby_IDA(dao_licen.fields.IDA_dalcn)
                    IDA_LC = dao_lc.fields.FK_IDA
                Catch ex As Exception
                    IDA_LC = 0
                End Try
                Dim dao_lcn As New DAO_LCN.TB_dalcn
                dao_lcn.GetDataby_IDA(IDA_LC)

                Dim date_write As String = ""
                Dim date_pay As String = ""
                Dim DT As New DataTable
                Dim BAO_SP_RN As New BAO.BAO
                DT = BAO_SP_RN.SP_XML_TABEAN_RENEW_TBN(IDA)
                For Each dr As DataRow In DT.Rows
                    If dao.fields.STATUS_ID > 1 Then
                        date_write = dr("DATE_CONFIRM_TH")
                        date_pay = dr("Pay_Request_Date_TH")
                    End If
                Next
                DT.TableName = "SP_XML_TABEAN_RENEW_TBN"
                XML.DT_SHOW.DT1 = DT
                If dao.fields.STATUS_ID > 1 Then
                    XML.DATE_CONFIRM_TH = date_pay
                    XML.WRITEDATE_FULL_THAI = date_write
                End If
                'If dao.fields.STATUS_ID = 0 Then
                '    XML.WRITEDATE_FULL_THAI = date_write.Day.ToString() & " " & date_write.ToString("MMMM") & " " & con_year(date_write.Year)
                'ElseIf dao.fields.STATUS_ID > 1 Then
                '    'XML.WRITEDATE_FULL_THAI = date_to_thai(dao.fields.CREATE_DATE)
                '    XML.WRITEDATE_FULL_THAI = date_write.Day.ToString() & " " & date_write.ToString("MMMM") & " " & con_year(date_write.Year)
                'Else
                '    XML.WRITEDATE_FULL_THAI = date_write.Day.ToString() & " " & date_write.ToString("MMMM") & " " & con_year(date_write.Year)
                'End If

                'Dim date_pay As Date
                'If IsNothing(dao.fields.Pay_Request_Date) = True Then
                '    date_pay = Date.Now
                '    XML.DATE_CONFIRM_TH = date_pay.Day.ToString() & " " & date_pay.ToString("MMMM") & " " & con_year(date_pay.Year)
                'Else
                '    XML.DATE_CONFIRM_TH = date_to_thai(dao.fields.Pay_Request_Date)
                'End If

                Dim dt_lcn As New DataTable
                Dim dt_lcn_location As New DataTable

                dao_tabean_herb.GetdatabyID_FK_IDA_DQ(FK_IDA)
                Dim IDENTIFY As String = ""
                Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
                If dao_drrqt.fields.CITIZEN_ID_AUTHORIZE = "" Then
                    IDENTIFY = dao_drrqt.fields.IDENTIFY
                    If IDENTIFY = "" Then IDENTIFY = dao.fields.CITIZEN_ID_AUTHORIZE
                Else
                    IDENTIFY = dao_product.fields.CITIZEN_AUTHORIZE
                End If


                dao_cpn.GetDataby_identify(IDENTIFY)
                Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
                Try
                    dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)
                Catch ex As Exception
                    dao_customer.GetDataby_identify(dao_lcn.fields.CITIZEN_ID_AUTHORIZE)
                End Try

                Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
                Dim obj As New XML_DATA
                'Dim cls As New CLS_COMMON.convert
                Dim result As String = ""
                'result = ws_center.GET_DATA_IDEM(citizen_id, citizen_id, "IDEM", "DPIS")
                result = ws_center.GET_DATA_IDENTIFY(IDENTIFY, IDENTIFY, "FUSION", "P@ssw0rdfusion440")
                obj = ConvertFromXml(Of XML_DATA)(result)
                Dim THANM_CENTER As String = ""
                Dim TYPE_PERSON_CENTER As Integer = obj.SYSLCNSIDs.type
                If TYPE_PERSON_CENTER = 1 Then
                    THANM_CENTER = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                ElseIf TYPE_PERSON_CENTER = 99 Then
                    THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
                Else
                    If obj.SYSLCNSNMs.thalnm IsNot Nothing Then
                        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                    Else
                        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
                    End If
                End If

                Dim THANM As String = dao_lcn.fields.thanm
                If THANM = "" Or THANM Is Nothing Then
                    THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm & " " & dao_customer.fields.thalnm
                Else
                    THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
                End If
                Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
                Try
                    tb_location.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim dao_pfx As New DAO_CPN.TB_sysprefix
                Dim BSN_THAIFULLNAME As String = ""
                Dim citizen_bsn As String = tb_location.fields.BSN_IDENTIFY
                Dim dao_cpn2 As New DAO_CPN.clsDBsyslcnsid
                ' dao_cpn.GetDataby_identify(dao.fields.CITIZEN_ID_AUTHORIZE)
                dao_cpn2.GetDataby_identify(citizen_bsn)
                Dim dao_who As New DAO_LCN.TB_WHO_DALCN
                dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
                Dim WHO_NAME As String = ""
                WHO_NAME = dao_who.fields.THANM_NAME
                Try
                    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
                    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
                    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
                    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
                    If dao_drrqt.fields.WHO_ID = True Then
                        BSN_THAIFULLNAME = THANM_CENTER
                    Else
                        BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
                    End If
                Catch ex As Exception

                End Try

                Dim bao As New BAO.BAO
                Dim person_age As String = ""
                Dim NATIONALITY_PERSON As String = ""
                Dim TYPE_PERSON_WHO As Integer = dao_cpn2.fields.type
                Dim TYPE_PERSON As Integer = dao_cpn.fields.type
                Dim NATION As String = dao_lcn.fields.NATION
                Try
                    person_age = dao_tabean_herb.fields.PERSON_AGE
                    If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
                        NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
                    Else
                        NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
                    End If
                    TYPE_PERSON_WHO = dao_cpn2.fields.type
                    TYPE_PERSON = dao_cpn.fields.type
                    NATION = dao_lcn.fields.NATION
                Catch ex As Exception

                End Try

                Dim CITIZEN_ID_AUTHORIZE As String = IDENTIFY
                Dim NAME As String = dao_drrqt.fields.CREATE_BY
                Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace
                Dim dt_lcn2 As New DataTable


                Dim DT_WHO As New DataTable
                Dim BAO_SP As New BAO.BAO
                DT_WHO = BAO_SP.SP_XML_WHO_DALCN(_IDA)

                If TYPE_PERSON = 1 Then
                    If dao_drrqt.fields.WHO_ID = True Then
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA_LC)
                        dt_lcn2 = bao.SP_Lisense_Name_and_Addr(IDENTIFY) ' bao_show.SP_LOCATION_BSN_BY_LCN_IDA(_IDA) 'ผู้ดำเนิน

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")


                        For Each dr As DataRow In dt_lcn.Rows
                            For Each dr2 As DataRow In dt_lcn2.Rows
                                Try
                                    dr("thanm") = dr2("tha_fullname")
                                    XML.BSN_THAINAME = dr2("tha_fullname")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thaaddr") = dr2("thaaddr")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID") = dr2("identify")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thamu") = dr2("mu")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("tharoad") = dr2("tharoad")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thabuilding") = dr2("thabuilding")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thasoi") = dr2("thasoi")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thathmblnm") = dr2("thathmblnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thaamphrnm") = dr2("thaamphrnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thachngwtnm_nozip") = dr2("thachngwtnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thachngwtnm") = dr2("thachngwtnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("zipcode") = dr2("zipcode")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NAME") = NAME
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("tel") = dr2("tel")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("fax") = dr2("fax")
                                Catch ex As Exception

                                End Try
                            Next
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            'Try
                            '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                            '        If dr("Mobile") = Nothing Then
                            '            dr("tel") = "-"
                            '        Else
                            '            dr("tel") = dr("Mobile")
                            '        End If
                            '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                            '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                            '    End If
                            'Catch ex As Exception

                            'End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            'Try
                            '    dr("CITIZEN_ID") = citizen_bsn
                            'Catch ex As Exception

                            'End Try
                            'Try
                            '    dr("NAME_JJ") = BSN_THAIFULLNAME
                            'Catch ex As Exception

                            'End Try
                            'Try
                            '    dr("THANM") = THANM
                            'Catch ex As Exception

                            'End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next

                    Else
                        'XML.TYPE_PERSON_1 = TYPE_PERSON
                        '    XML.BSN_THAINAME = THANM
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA_LC)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_PERSON_1"
                    XML.DT_SHOW.DT2 = dt_lcn
                Else
                    'XML.TYPE_PERSON_99 = TYPE_PERSON
                    If dao_drrqt.fields.WHO_ID = True Then
                        If TYPE_PERSON_WHO = 1 Then
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            'XML.TYPE_PERSON_99 = TYPE_PERSON
                            XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_who.fields.FK_LCT)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            'dt_lcn.Columns.Add("CITIZEN_ID")
                            'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                            dt_lcn.Columns.Add("NAME")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")

                            For Each dr As DataRow In dt_lcn.Rows
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                'Try
                                '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                                '        If dr("Mobile") = Nothing Then
                                '            dr("tel") = "-"
                                '        Else
                                '            dr("tel") = dr("Mobile")
                                '        End If
                                '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                                '    End If
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("PERSON_AGE") = dao_tabean_herb.fields.PERSON_AGE
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = dao_tabean_herb.fields.NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID") = citizen_bsn
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NAME") = BSN_THAIFULLNAME
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANM") = THANM
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        Else
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            'XML.TYPE_PERSON_99 = TYPE_PERSON
                            XML.BSN_THAIFULLNAME = dao_tabean_herb.fields.AGENT_99
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA_LC)
                            dt_lcn2 = bao.SP_Lisense_Name_and_Addr(IDENTIFY)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            dt_lcn.Columns.Add("NAME")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")
                            dt_lcn.Columns.Add("CITIZEN_ID")
                            dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")

                            For Each dr As DataRow In dt_lcn.Rows
                                For Each dr2 As DataRow In dt_lcn2.Rows
                                    Try
                                        dr("thanm") = dr2("tha_fullname")
                                        XML.BSN_THAINAME = dao_tabean_herb.fields.AGENT_99
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaaddr") = dr2("thaaddr")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID") = dao_tabean_herb.fields.IDEN_AGENT_99
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thamu") = dr2("mu")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tharoad") = dr2("tharoad")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thabuilding") = dr2("thabuilding")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thasoi") = dr2("thasoi")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thathmblnm") = dr2("thathmblnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaamphrnm") = dr2("thaamphrnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thachngwtnm_nozip") = dr2("thachngwtnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("zipcode") = dr2("zipcode")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("NAME") = NAME
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tel") = dr2("tel")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("fax") = dr2("fax")
                                    Catch ex As Exception

                                    End Try
                                Next
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("PERSON_AGE") = person_age
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try

                                'Try
                                '    dr("THANM") = THANM
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        End If
                    Else
                        'XML.TYPE_PERSON_99 = TYPE_PERSON
                        XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA_LC)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = SEARCH_NAME_BY_IDEN(dr("IDENTIFY"))
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try

                        Next
                    End If
                    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_NITI_99"
                    XML.DT_SHOW.DT3 = dt_lcn
                End If
                If dao_drrqt.fields.WHO_ID = False Then
                    If TYPE_PERSON = 1 Then
                        XML.BSN_THAINAME = THANM
                    Else
                        XML.BSN_THAINAME = BSN_THAIFULLNAME
                    End If
                End If

                If dao.fields.lcntpcd = "นสม" Then
                    Dim dao_lcn_HPI As New DAO_LCN.TB_dalcn
                    dao_lcn_HPI.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 121)

                    Dim dao_lcn_bsn_HPI As New DAO_LCN.TB_DALCN_LOCATION_BSN
                    dao_lcn_bsn_HPI.GetDataby_LCN_IDA(_IDA_LCN)

                    Dim dao_cpn_HPI As New DAO_CPN.clsDBsyslcnsid
                    Try

                        dao_cpn_HPI.GetDataby_identify(dao_lcn_HPI.fields.CITIZEN_ID_AUTHORIZE)

                    Catch ex As Exception

                    End Try

                    Dim TYPE_PERSON_HPI As Integer = dao_cpn_HPI.fields.type
                    Dim LCNNO_DISPLAY_NEW_HPI As String = dao_lcn_HPI.fields.LCNNO_DISPLAY_NEW
                    Dim THANM_HPI As String = dao_lcn_HPI.fields.thanm
                    Dim BSN_THAIFULLNAME_HPI As String = dao_lcn_bsn_HPI.fields.BSN_THAIFULLNAME

                    dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPI.fields.FK_IDA)

                    dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPI")
                    dt_lcn_location.Columns.Add("THANM_HPI")
                    dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPI")

                    For Each dr As DataRow In dt_lcn_location.Rows
                        Try
                            dr("LCNNO_DISPLAY_NEW_HPI") = LCNNO_DISPLAY_NEW_HPI
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM_HPI") = THANM_HPI
                        Catch ex As Exception

                        End Try
                        Try
                            If TYPE_PERSON_HPI = 1 Then
                                dr("BSN_THAIFULLNAME_HPI") = "-"
                            Else
                                dr("BSN_THAIFULLNAME_HPI") = BSN_THAIFULLNAME_HPI

                            End If
                        Catch ex As Exception

                        End Try

                    Next
                    dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPI"
                    XML.DT_SHOW.DT4 = dt_lcn_location
                ElseIf dao.fields.lcntpcd = "ผสม" Then
                    Dim dao_lcn_HPM As New DAO_LCN.TB_dalcn
                    dao_lcn_HPM.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 122)

                    Dim dao_lcn_bsn_HPM As New DAO_LCN.TB_DALCN_LOCATION_BSN
                    dao_lcn_bsn_HPM.GetDataby_LCN_IDA(_IDA_LCN)

                    Dim dao_cpn_HPM As New DAO_CPN.clsDBsyslcnsid
                    Try

                        dao_cpn_HPM.GetDataby_identify(dao_lcn_HPM.fields.CITIZEN_ID_AUTHORIZE)

                    Catch ex As Exception

                    End Try
                    Dim TYPE_PERSON_HPM As Integer = dao_cpn_HPM.fields.type
                    Dim LCNNO_DISPLAY_NEW_HPM As String = dao_lcn_HPM.fields.LCNNO_DISPLAY_NEW
                    'Dim THANM_HPM As String = dao_lcn_HPM.fields.thanm
                    Dim THANM_HPM As String
                    THANM_HPM = SEARCH_NAME_BY_IDEN(dao_lcn_HPM.fields.CITIZEN_ID_AUTHORIZE)
                    Dim BSN_THAIFULLNAME_HPM As String = dao_lcn_bsn_HPM.fields.BSN_THAIFULLNAME

                    dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPM.fields.FK_IDA)

                    dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPM")
                    dt_lcn_location.Columns.Add("THANM_HPM")
                    dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPM")
                    dt_lcn_location.Columns.Add("TREATMENT_AGE_FULL")

                    For Each dr As DataRow In dt_lcn_location.Rows
                        Try
                            dr("LCNNO_DISPLAY_NEW_HPM") = LCNNO_DISPLAY_NEW_HPM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM_HPM") = THANM_HPM
                        Catch ex As Exception

                        End Try
                        If TYPE_PERSON_HPM = 1 Then
                            dr("BSN_THAIFULLNAME_HPM") = "-"
                        Else
                            dr("BSN_THAIFULLNAME_HPM") = BSN_THAIFULLNAME_HPM

                        End If
                    Next

                    dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPM"
                    XML.DT_SHOW.DT5 = dt_lcn_location
                End If

                Dim bao_sp2 As New BAO.BAO
                XML.DT_SHOW.DT6 = bao_sp2.SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2(FK_IDA)
                XML.DT_SHOW.DT6.TableName = "SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2"
                Try
                    If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
                        XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
                    Else
                        XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
                    End If
                Catch ex As Exception

                End Try

                If TYPE_PERSON = 1 Then
                    XML.THANM_THAIFULLNAME = THANM
                Else
                    XML.THANM_THAIFULLNAME = BSN_THAIFULLNAME
                End If
                Return XML
            End Function
            Public Function Gen_XML_RENREW_TBN_NON_IDA(ByVal IDA_DR As Integer, ByVal _IDA_LCN As Integer)
                Dim bao_lcn As New BAO.BAO
                Dim bao_lcn_location As New BAO.BAO
                Dim XML As New CLASS_DR_RENEW
                Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
                Dim Process_id As String = ""
                Dim CLS_TABEAN_RENEW As New TABEAN_RENEW
                'dao.GetdatabyID_IDA(IDA)
                XML.TABEAN_RENEW = dao.fields
                'Process_id = dao.fields.PROCESS_ID

                'Dim dao_drrgt As New DAO_DRUG.ClsDBdrrgt
                'dao_drrgt.GetDataby_IDA(FK_IDA)
                Dim dao_drrqt As New DAO_TABEAN.ClsDBdrrqt
                Try
                    ' dao_drrqt.GetDataby_IDA(dao_drrqt.fields.FK_DRRQT)
                    dao_drrqt.GetDataby_IDA(IDA_DR)
                Catch ex As Exception

                End Try
                Dim dao_tabean_herb As New DAO_TABEAN.TB_TABEAN_HERB
                Dim dao_lcn As New DAO_LCN.TB_dalcn
                dao_lcn.GetDataby_IDA(_IDA_LCN)

                Dim DT As New DataTable
                Dim BAO_SP_RN As New BAO.BAO
                DT = BAO_SP_RN.SP_XML_TABEAN_RENEW_TBN(IDA_DR)
                DT.TableName = "SP_XML_TABEAN_RENEW_TBN"
                XML.DT_SHOW.DT1 = DT

                If dao.fields.STATUS_ID = 0 Then
                    XML.WRITEDATE_FULL_THAI = date_to_thai(Date.Now)

                ElseIf dao.fields.STATUS_ID > 1 Then
                    XML.WRITEDATE_FULL_THAI = date_to_thai(dao.fields.CREATE_DATE)
                Else
                    XML.WRITEDATE_FULL_THAI = date_to_thai(Date.Now)
                End If

                Dim dt_lcn As New DataTable
                Dim dt_lcn_location As New DataTable

                dao_tabean_herb.GetdatabyID_FK_IDA_DQ(IDA_DR)
                Dim IDENTIFY As String = ""
                Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
                If dao_drrqt.fields.CITIZEN_ID_AUTHORIZE = "" Then
                    IDENTIFY = dao_drrqt.fields.IDENTIFY
                Else
                    IDENTIFY = dao_drrqt.fields.CITIZEN_ID_AUTHORIZE
                End If

                dao_cpn.GetDataby_identify(IDENTIFY)
                Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
                dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)

                Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                Try
                    dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try

                Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
                Dim obj As New XML_DATA
                'Dim cls As New CLS_COMMON.convert
                Dim result As String = ""
                'result = ws_center.GET_DATA_IDEM(citizen_id, citizen_id, "IDEM", "DPIS")
                result = ws_center.GET_DATA_IDENTIFY(IDENTIFY, IDENTIFY, "FUSION", "P@ssw0rdfusion440")
                obj = ConvertFromXml(Of XML_DATA)(result)
                Dim THANM_CENTER As String = ""
                Dim TYPE_PERSON_CENTER As Integer = obj.SYSLCNSIDs.type
                If TYPE_PERSON_CENTER = 1 Then
                    THANM_CENTER = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                ElseIf TYPE_PERSON_CENTER = 99 Then
                    THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
                Else
                    If obj.SYSLCNSNMs.thalnm IsNot Nothing Then
                        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                    Else
                        THANM_CENTER = obj.SYSLCNSNMs.prefixnm & obj.SYSLCNSNMs.thanm
                    End If
                End If

                Dim THANM As String = dao_lcn.fields.thanm
                If THANM = "" Or THANM Is Nothing Then
                    THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm & " " & dao_customer.fields.thalnm
                Else
                    THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
                End If
                Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
                Try
                    tb_location.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim dao_pfx As New DAO_CPN.TB_sysprefix
                Dim BSN_THAIFULLNAME As String = ""
                Dim citizen_bsn As String = tb_location.fields.BSN_IDENTIFY
                Dim dao_cpn2 As New DAO_CPN.clsDBsyslcnsid
                ' dao_cpn.GetDataby_identify(dao.fields.CITIZEN_ID_AUTHORIZE)
                dao_cpn2.GetDataby_identify(IDENTIFY)
                Dim dao_who As New DAO_LCN.TB_WHO_DALCN
                dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
                Dim WHO_NAME As String = ""
                WHO_NAME = dao_who.fields.THANM_NAME
                Try
                    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
                    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
                    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
                    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
                    If dao_drrqt.fields.WHO_ID = True Then
                        BSN_THAIFULLNAME = THANM_CENTER
                    Else
                        BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
                    End If
                Catch ex As Exception

                End Try

                Dim bao As New BAO.BAO
                Dim person_age As String = ""
                Dim NATIONALITY_PERSON As String = ""
                Try
                    person_age = dao_tabean_herb.fields.PERSON_AGE
                    If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
                        NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
                    Else
                        NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
                    End If
                Catch ex As Exception

                End Try
                Dim TYPE_PERSON_WHO As Integer = dao_cpn2.fields.type
                Dim TYPE_PERSON As Integer = dao_cpn.fields.type
                Dim NATION As String = dao_lcn.fields.NATION


                Dim CITIZEN_ID_AUTHORIZE As String = IDENTIFY
                Dim NAME As String = dao_drrqt.fields.CREATE_BY
                Dim THANAMEPLACE As String = dao_lcn.fields.thanameplace
                Dim dt_lcn2 As New DataTable


                Dim DT_WHO As New DataTable
                Dim BAO_SP As New BAO.BAO
                DT_WHO = BAO_SP.SP_XML_WHO_DALCN(_IDA)

                If TYPE_PERSON = 1 Then
                    If dao_drrqt.fields.WHO_ID = True Then
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)
                        dt_lcn2 = bao.SP_Lisense_Name_and_Addr(IDENTIFY) ' bao_show.SP_LOCATION_BSN_BY_LCN_IDA(_IDA) 'ผู้ดำเนิน

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")


                        For Each dr As DataRow In dt_lcn.Rows
                            For Each dr2 As DataRow In dt_lcn2.Rows
                                Try
                                    dr("thanm") = dr2("tha_fullname")
                                    XML.BSN_THAINAME = dr2("tha_fullname")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thaaddr") = dr2("thaaddr")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID") = dr2("identify")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thamu") = dr2("mu")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("tharoad") = dr2("tharoad")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thabuilding") = dr2("thabuilding")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thasoi") = dr2("thasoi")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thathmblnm") = dr2("thathmblnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thaamphrnm") = dr2("thaamphrnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thachngwtnm_nozip") = dr2("thachngwtnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("thachngwtnm") = dr2("thachngwtnm")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("zipcode") = dr2("zipcode")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NAME") = NAME
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("tel") = dr2("tel")
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("fax") = dr2("fax")
                                Catch ex As Exception

                                End Try
                            Next
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            'Try
                            '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                            '        If dr("Mobile") = Nothing Then
                            '            dr("tel") = "-"
                            '        Else
                            '            dr("tel") = dr("Mobile")
                            '        End If
                            '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                            '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                            '    End If
                            'Catch ex As Exception

                            'End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            'Try
                            '    dr("CITIZEN_ID") = citizen_bsn
                            'Catch ex As Exception

                            'End Try
                            'Try
                            '    dr("NAME_JJ") = BSN_THAIFULLNAME
                            'Catch ex As Exception

                            'End Try
                            'Try
                            '    dr("THANM") = THANM
                            'Catch ex As Exception

                            'End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next

                    Else
                        'XML.TYPE_PERSON_1 = TYPE_PERSON
                        '    XML.BSN_THAINAME = THANM
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_PERSON_1"
                    XML.DT_SHOW.DT2 = dt_lcn
                Else
                    'XML.TYPE_PERSON_99 = TYPE_PERSON
                    If dao_drrqt.fields.WHO_ID = True Then
                        If TYPE_PERSON_WHO = 1 Then
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            'XML.TYPE_PERSON_99 = TYPE_PERSON
                            XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_who.fields.FK_LCT)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            'dt_lcn.Columns.Add("CITIZEN_ID")
                            'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                            dt_lcn.Columns.Add("NAME")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")

                            For Each dr As DataRow In dt_lcn.Rows
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                'Try
                                '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                                '        If dr("Mobile") = Nothing Then
                                '            dr("tel") = "-"
                                '        Else
                                '            dr("tel") = dr("Mobile")
                                '        End If
                                '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                                '    End If
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("PERSON_AGE") = dao_tabean_herb.fields.PERSON_AGE
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = dao_tabean_herb.fields.NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID") = citizen_bsn
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NAME") = BSN_THAIFULLNAME
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANM") = THANM
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        Else
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            'XML.TYPE_PERSON_99 = TYPE_PERSON
                            XML.BSN_THAIFULLNAME = dao_tabean_herb.fields.AGENT_99
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)
                            dt_lcn2 = bao.SP_Lisense_Name_and_Addr(IDENTIFY)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            dt_lcn.Columns.Add("NAME")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")
                            dt_lcn.Columns.Add("CITIZEN_ID")
                            dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")

                            For Each dr As DataRow In dt_lcn.Rows
                                For Each dr2 As DataRow In dt_lcn2.Rows
                                    Try
                                        dr("thanm") = dr2("tha_fullname")
                                        XML.BSN_THAINAME = dao_tabean_herb.fields.AGENT_99
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaaddr") = dr2("thaaddr")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID") = dao_tabean_herb.fields.IDEN_AGENT_99
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thamu") = dr2("mu")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tharoad") = dr2("tharoad")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thabuilding") = dr2("thabuilding")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thasoi") = dr2("thasoi")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thathmblnm") = dr2("thathmblnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaamphrnm") = dr2("thaamphrnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thachngwtnm_nozip") = dr2("thachngwtnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("zipcode") = dr2("zipcode")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("NAME") = NAME
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tel") = dr2("tel")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("fax") = dr2("fax")
                                    Catch ex As Exception

                                    End Try
                                Next
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("PERSON_AGE") = person_age
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try

                                'Try
                                '    dr("THANM") = THANM
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        End If
                    Else
                        'XML.TYPE_PERSON_99 = TYPE_PERSON
                        XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try

                        Next
                    End If

                    dt_lcn.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_NITI_99"
                    XML.DT_SHOW.DT3 = dt_lcn

                    If dao_drrqt.fields.WHO_ID = False Then
                        If TYPE_PERSON = 1 Then
                            XML.BSN_THAINAME = THANM
                        Else
                            XML.BSN_THAINAME = BSN_THAIFULLNAME
                        End If
                    End If

                    If dao_lcn.fields.PROCESS_ID = 121 Then
                        Dim dao_lcn_HPI As New DAO_LCN.TB_dalcn
                        dao_lcn_HPI.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 121)

                        Dim dao_lcn_bsn_HPI As New DAO_LCN.TB_DALCN_LOCATION_BSN
                        dao_lcn_bsn_HPI.GetDataby_LCN_IDA(_IDA_LCN)

                        Dim dao_cpn_HPI As New DAO_CPN.clsDBsyslcnsid
                        Try

                            dao_cpn_HPI.GetDataby_identify(dao_lcn_HPI.fields.CITIZEN_ID_AUTHORIZE)

                        Catch ex As Exception

                        End Try

                        Dim TYPE_PERSON_HPI As Integer = dao_cpn_HPI.fields.type
                        Dim LCNNO_DISPLAY_NEW_HPI As String = dao_lcn_HPI.fields.LCNNO_DISPLAY_NEW
                        Dim THANM_HPI As String = dao_lcn_HPI.fields.thanm
                        Dim BSN_THAIFULLNAME_HPI As String = dao_lcn_bsn_HPI.fields.BSN_THAIFULLNAME

                        dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPI.fields.FK_IDA)

                        dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPI")
                        dt_lcn_location.Columns.Add("THANM_HPI")
                        dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPI")

                        For Each dr As DataRow In dt_lcn_location.Rows
                            Try
                                dr("LCNNO_DISPLAY_NEW_HPI") = LCNNO_DISPLAY_NEW_HPI
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM_HPI") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                If TYPE_PERSON_HPI = 1 Then
                                    dr("BSN_THAIFULLNAME_HPI") = "-"
                                Else
                                    dr("BSN_THAIFULLNAME_HPI") = BSN_THAIFULLNAME_HPI

                                End If
                            Catch ex As Exception

                            End Try

                        Next
                        dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPI"
                        XML.DT_SHOW.DT4 = dt_lcn_location
                    ElseIf dao_lcn.fields.PROCESS_ID = 122 Then
                        Dim dao_lcn_HPM As New DAO_LCN.TB_dalcn
                        dao_lcn_HPM.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 122)

                        Dim dao_lcn_bsn_HPM As New DAO_LCN.TB_DALCN_LOCATION_BSN
                        dao_lcn_bsn_HPM.GetDataby_LCN_IDA(_IDA_LCN)

                        Dim dao_cpn_HPM As New DAO_CPN.clsDBsyslcnsid
                        Try

                            dao_cpn_HPM.GetDataby_identify(dao_lcn_HPM.fields.CITIZEN_ID_AUTHORIZE)

                        Catch ex As Exception

                        End Try
                        Dim TYPE_PERSON_HPM As Integer = dao_cpn_HPM.fields.type
                        Dim LCNNO_DISPLAY_NEW_HPM As String = dao_lcn_HPM.fields.LCNNO_DISPLAY_NEW
                        Dim THANM_HPM As String = dao_lcn_HPM.fields.thanm
                        Dim BSN_THAIFULLNAME_HPM As String = dao_lcn_bsn_HPM.fields.BSN_THAIFULLNAME

                        dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPM.fields.FK_IDA)

                        dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPM")
                        dt_lcn_location.Columns.Add("THANM_HPM")
                        dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPM")
                        dt_lcn_location.Columns.Add("TREATMENT_AGE_FULL")

                        For Each dr As DataRow In dt_lcn_location.Rows
                            Try
                                dr("LCNNO_DISPLAY_NEW_HPM") = LCNNO_DISPLAY_NEW_HPM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM_HPM") = THANM
                            Catch ex As Exception

                            End Try
                            If TYPE_PERSON_HPM = 1 Then
                                dr("BSN_THAIFULLNAME_HPM") = "-"
                            Else
                                dr("BSN_THAIFULLNAME_HPM") = BSN_THAIFULLNAME_HPM

                            End If
                        Next

                        dt_lcn_location.TableName = "XML_TABEAN_TBN_LOCATION_ADDRESS_HPM"
                        XML.DT_SHOW.DT5 = dt_lcn_location
                    End If

                    Dim bao_sp2 As New BAO.BAO
                    XML.DT_SHOW.DT6 = bao_sp2.SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2(IDA_DR)
                    XML.DT_SHOW.DT6.TableName = "SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2"
                    Try
                        If dao_tabean_herb.fields.NATIONALITY_PERSON_ID = 1 Then
                            XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON
                        Else
                            XML.NATIONALITY_PERSON = dao_tabean_herb.fields.NATIONALITY_PERSON_OTHER
                        End If
                    Catch ex As Exception

                    End Try

                    If TYPE_PERSON = 1 Then
                        XML.THANM_THAIFULLNAME = THANM
                    Else
                        XML.THANM_THAIFULLNAME = BSN_THAIFULLNAME
                    End If
                End If
                Return XML
            End Function
            Public Function Gen_XML_RENREW_JJ(ByVal IDA As Integer, ByVal FK_IDA As Integer, ByVal _IDA_LCN As Integer)
                Dim bao_lcn As New BAO.BAO
                Dim bao_lcn_location As New BAO.BAO
                Dim XML As New CLASS_DR_RENEW
                Dim dao_RN As New DAO_TABEAN.TB_TABEAN_RENEW
                Dim Process_id As String = ""
                Dim CLS_TABEAN_RENEW As New TABEAN_RENEW
                dao_RN.GetdatabyID_IDA(IDA)
                XML.TABEAN_RENEW = dao_RN.fields
                Process_id = dao_RN.fields.PROCESS_ID

                Dim DT As New DataTable
                Dim BAO_SP_RN As New BAO.BAO
                DT = BAO_SP_RN.SP_XML_TABEAN_RENEW_TBN(FK_IDA)
                DT.TableName = "SP_XML_TABEAN_RENEW_TBN"
                XML.DT_SHOW.DT1 = DT

                If dao_RN.fields.STATUS_ID = 0 Then
                    XML.WRITEDATE_FULL_THAI = date_to_thai(Date.Now)

                ElseIf dao_RN.fields.STATUS_ID > 1 Then
                    XML.WRITEDATE_FULL_THAI = date_to_thai(dao_RN.fields.CREATE_DATE)
                Else
                    XML.WRITEDATE_FULL_THAI = date_to_thai(Date.Now)
                End If

                Dim dt_lcn As New DataTable
                Dim dt_lcn_location As New DataTable
                Dim dao_lcn As New DAO_LCN.TB_dalcn
                dao_lcn.GetDataby_IDA(_IDA_LCN)

                Dim dao As New DAO_TABEAN.TB_TABEAN_JJ
                dao.GetdatabyID_IDA(FK_IDA)

                Dim dao_cpn As New DAO_CPN.clsDBsyslcnsid
                Dim dao_cpn2 As New DAO_CPN.clsDBsyslcnsid
                dao_cpn.GetDataby_identify(dao.fields.CITIZEN_ID_AUTHORIZE)
                dao_cpn2.GetDataby_identify(dao.fields.CITIZEN_ID_AUTHORIZE)

                Dim dao_customer As New DAO_CPN.clsDBsyslcnsnm
                dao_customer.GetDataby_lcnsid(dao_lcn.fields.lcnsid)

                Dim dao_esub As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
                Try
                    dao_esub.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try
                Dim THANM As String = dao_lcn.fields.thanm
                If THANM = "" Or THANM Is Nothing Then
                    THANM = dao_customer.fields.prefixnm & " " & dao_customer.fields.thanm
                Else
                    THANM = dao_lcn.fields.syslcnsnm_prefixnm & " " & dao_lcn.fields.thanm
                End If
                Dim tb_location As New DAO_LCN.TB_DALCN_LOCATION_BSN
                Try
                    tb_location.GetDataby_LCN_IDA(_IDA_LCN)
                Catch ex As Exception

                End Try

                Dim citizen_bsn As String = tb_location.fields.BSN_IDENTIFY
                Dim dao_pfx As New DAO_CPN.TB_sysprefix
                Dim BSN_THAIFULLNAME As String = ""
                Dim dao_who As New DAO_LCN.TB_WHO_DALCN
                dao_who.GetdatabyID_FK_LCN(_IDA_LCN)
                Dim WHO_NAME As String = ""
                WHO_NAME = dao_who.fields.THANM_NAME
                Try
                    dao_pfx.Getdata_byid(tb_location.fields.BSN_PREFIXTHAICD)
                    Dim BSN_PRIFRFIX As String = dao_pfx.fields.thanm
                    Dim BSN_THAINAME As String = tb_location.fields.BSN_THAINAME
                    Dim BSN_THAILASTNAME As String = tb_location.fields.BSN_THAILASTNAME
                    'If dao.fields.WHO_ID = True Then
                    '    BSN_THAIFULLNAME = WHO_NAME
                    'Else
                    '    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME
                    'End If
                    BSN_THAIFULLNAME = BSN_PRIFRFIX & " " & BSN_THAINAME & " " & BSN_THAILASTNAME

                Catch ex As Exception

                End Try

                Dim person_age As String = ""
                Dim NATIONALITY_PERSON As String = ""
                Try
                    person_age = dao.fields.PERSON_AGE
                    If dao.fields.NATIONALITY_PERSON_ID = 1 Then
                        NATIONALITY_PERSON = dao.fields.NATIONALITY_PERSON
                    Else
                        NATIONALITY_PERSON = dao.fields.NATIONALITY_PERSON_OTHER
                    End If
                Catch ex As Exception

                End Try

                Dim TYPE_PERSON As Integer = dao_cpn.fields.type
                Dim TYPE_PERSON_WHO As Integer = dao_cpn2.fields.type
                Dim NATION As String = dao_lcn.fields.NATION
                'Dim THANM As String = dao_lcn.fields.thanm

                Dim CITIZEN_ID As String = dao.fields.CITIZEN_ID
                Dim CITIZEN_ID_AUTHORIZE As String = dao.fields.CITIZEN_ID_AUTHORIZE
                Dim NAME_JJ As String = dao.fields.NAME_JJ
                Dim THANAMEPLACE As String = dao.fields.LCN_THANAMEPLACE

                Dim bao As New BAO.BAO
                Dim dt_lcn2 As New DataTable


                Dim DT_WHO As New DataTable
                Dim BAO_SP As New BAO.BAO
                DT_WHO = BAO_SP.SP_XML_WHO_DALCN(FK_IDA)
                'ข้อ 2 
                If TYPE_PERSON = 1 Then
                    'XML.TYPE_PERSON_1 = TYPE_PERSON
                    If dao.fields.WHO_ID = True Then
                        dt_lcn = BAO_SP.SP_XML_WHO_DALCN(FK_IDA)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        'dt_lcn.Columns.Add("CITIZEN_ID")
                        'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME_JJ")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            'Try
                            '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                            '        If dr("Mobile") = Nothing Then
                            '            dr("tel") = "-"
                            '        Else
                            '            dr("tel") = dr("Mobile")
                            '        End If
                            '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                            '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                            '    End If
                            'Catch ex As Exception

                            'End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME_JJ") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next

                    Else
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME_JJ")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME_JJ") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try
                        Next
                    End If

                    dt_lcn.TableName = "XML_TABEAN_JJ_LOCATION_ADDRESS_PERSON_1"
                    XML.DT_SHOW.DT3 = dt_lcn
                Else
                    'XML.TYPE_PERSON_99 = TYPE_PERSON
                    If dao.fields.WHO_ID = True Then
                        If TYPE_PERSON_WHO = 1 Then
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_who.fields.FK_LCT)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            'dt_lcn.Columns.Add("CITIZEN_ID")
                            'dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                            dt_lcn.Columns.Add("NAME_JJ")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")

                            For Each dr As DataRow In dt_lcn.Rows
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                'Try
                                '    If dr("tel") = Nothing Or dr("tel") = "-" Then
                                '        If dr("Mobile") = Nothing Then
                                '            dr("tel") = "-"
                                '        Else
                                '            dr("tel") = dr("Mobile")
                                '        End If
                                '    ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                '        dr("tel") = dr("tel") & ", " & dr("Mobile")
                                '    End If
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("PERSON_AGE") = person_age
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("CITIZEN_ID") = citizen_bsn
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NAME_JJ") = BSN_THAIFULLNAME
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANM") = THANM
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        Else
                            'dt_lcn = BAO_SP.SP_XML_WHO_DALCN(IDA)
                            dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.IDA_LCT)
                            dt_lcn2 = bao.SP_Lisense_Name_and_Addr(dao.fields.CITIZEN_ID_AUTHORIZE)

                            dt_lcn.Columns.Add("NATION")
                            dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                            dt_lcn.Columns.Add("NAME_JJ")
                            dt_lcn.Columns.Add("THANM")
                            dt_lcn.Columns.Add("THANAMEPLACE")
                            dt_lcn.Columns.Add("PERSON_AGE")
                            dt_lcn.Columns.Add("NATIONALITY_PERSON")
                            dt_lcn.Columns.Add("CITIZEN_ID")
                            dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")

                            For Each dr As DataRow In dt_lcn.Rows
                                For Each dr2 As DataRow In dt_lcn2.Rows
                                    Try
                                        dr("thanm") = dr2("tha_fullname")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaaddr") = dr2("thaaddr")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID") = CITIZEN_ID
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("CITIZEN_ID_AUTHORIZE") = dr2("identify")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thamu") = dr2("mu")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tharoad") = dr2("tharoad")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thabuilding") = dr2("thabuilding")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thasoi") = dr2("thasoi")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thathmblnm") = dr2("thathmblnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thaamphrnm") = dr2("thaamphrnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("thachngwtnm_nozip") = dr2("thachngwtnm")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("zipcode") = dr2("zipcode")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("NAME_JJ") = NAME_JJ
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("tel") = dr2("tel")
                                    Catch ex As Exception

                                    End Try
                                    Try
                                        dr("fax") = dr2("fax")
                                    Catch ex As Exception

                                    End Try
                                Next
                                Try
                                    dr("NATION") = NATION
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("PERSON_AGE") = person_age
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                                Catch ex As Exception

                                End Try
                                Try
                                    dr("TYPE_PERSON_CPN") = TYPE_PERSON
                                Catch ex As Exception

                                End Try

                                'Try
                                '    dr("THANM") = THANM
                                'Catch ex As Exception

                                'End Try
                                Try
                                    dr("THANAMEPLACE") = THANAMEPLACE
                                Catch ex As Exception

                                End Try
                            Next
                        End If
                    Else
                        dt_lcn = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn.fields.FK_IDA)

                        dt_lcn.Columns.Add("NATION")
                        dt_lcn.Columns.Add("TYPE_PERSON_CPN")
                        dt_lcn.Columns.Add("CITIZEN_ID")
                        dt_lcn.Columns.Add("CITIZEN_ID_AUTHORIZE")
                        dt_lcn.Columns.Add("NAME_JJ")
                        dt_lcn.Columns.Add("THANM")
                        dt_lcn.Columns.Add("THANAMEPLACE")
                        dt_lcn.Columns.Add("PERSON_AGE")
                        dt_lcn.Columns.Add("NATIONALITY_PERSON")

                        For Each dr As DataRow In dt_lcn.Rows
                            Try
                                dr("NATION") = NATION
                            Catch ex As Exception

                            End Try
                            Try
                                If dr("tel") = Nothing Or dr("tel") = "-" Then
                                    If dr("Mobile") = Nothing Then
                                        dr("tel") = "-"
                                    Else
                                        dr("tel") = dr("Mobile")
                                    End If
                                ElseIf dr("Mobile") IsNot Nothing And dr("tel") IsNot Nothing Or dr("tel") = "-" Then
                                    dr("tel") = dr("tel") & ", " & dr("Mobile")
                                End If
                            Catch ex As Exception

                            End Try
                            Try
                                dr("PERSON_AGE") = person_age
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NATIONALITY_PERSON") = NATIONALITY_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("TYPE_PERSON_CPN") = TYPE_PERSON
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID") = citizen_bsn
                            Catch ex As Exception

                            End Try
                            Try
                                dr("CITIZEN_ID_AUTHORIZE") = CITIZEN_ID_AUTHORIZE
                            Catch ex As Exception

                            End Try
                            Try
                                dr("NAME_JJ") = BSN_THAIFULLNAME
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANM") = THANM
                            Catch ex As Exception

                            End Try
                            Try
                                dr("THANAMEPLACE") = THANAMEPLACE
                            Catch ex As Exception

                            End Try

                        Next
                    End If

                    dt_lcn.TableName = "XML_TABEAN_JJ_LOCATION_ADDRESS_NITI_99"
                    XML.DT_SHOW.DT4 = dt_lcn
                End If

                If TYPE_PERSON = 1 Then
                    XML.BSN_THAIFULLNAME = THANM
                Else
                    XML.BSN_THAIFULLNAME = BSN_THAIFULLNAME
                End If
                Dim dt_jj As New DataTable
                'HEAD
                Dim bao_xml As New BAO.BAO
                dt_jj = bao_xml.SP_XML_TABEAN_JJ(FK_IDA)

                dt_jj.Columns.Add("TYPE_SUB_NAME_CHANGE")
                dt_jj.Columns.Add("PP_JJ")
                dt_jj.Columns.Add("TREATMENT_AGE_FULL")
                For Each dr As DataRow In dt_jj.Rows

                    'If dr("TYPE_SUB_ID") = 1 Then
                    '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนไทย"
                    'ElseIf dr("TYPE_SUB_ID") = 2 Then
                    '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
                    'ElseIf dr("TYPE_SUB_ID") = 3 Then
                    '    dr("TYPE_SUB_NAME_CHANGE") = "ยาพัฒนาจากสมุนไพร"
                    'End If
                    Try
                        If dao.fields.TREATMENT_AGE Is Nothing Or dao.fields.TREATMENT_AGE = 0 Then
                            dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
                        ElseIf dao.fields.TREATMENT_AGE_MONTH Is Nothing Or dao.fields.TREATMENT_AGE_MONTH = 0 Then
                            dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao.fields.TREATMENT_AGE & " " & "ปี"
                        Else
                            dr("TREATMENT_AGE_FULL") = "การเก็บรักษา " & dao.fields.STORAGE_NAME & " / อายุการเก็บรักษา " & dao.fields.TREATMENT_AGE & " " & "ปี" & " " & dao.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
                        End If
                        'dr("TREATMENT_AGE_FULL") = dao.fields.STORAGE_NAME & " " & dao.fields.TREATMENT_AGE & " " & dao.fields.TREATMENT_AGE_NAME

                    Catch ex As Exception
                        dr("TREATMENT_AGE_FULL") = dao.fields.STORAGE_NAME & " " & dao.fields.TREATMENT_AGE_MONTH & " " & "เดือน"
                    End Try

                    dr("PP_JJ") = "ตามเอกสารแนบ"

                    'If dr("TYPE_SUB_ID") = 2 Then
                    '    dr("TYPE_SUB_NAME_CHANGE") = "ยาแผนจีน"
                    'End If

                Next
                dt_jj.TableName = "XML_TABEAN_JJ"
                XML.DT_SHOW.DT5 = dt_jj

                'XML.TABEAN_JJ = dao.fields

                Dim date_approve_day As Date
                Dim date_approve_month As Date
                Dim date_approve_year As Date
                Dim date_req_day As Date
                Dim date_req_month As Date
                Dim date_req_year As Date


                Dim dao_detail As New DAO_TABEAN.TB_TABEAN_SUBPACKAGE
                dao_detail.GetData_ByFkIDA(FK_IDA)

                For Each dao_detail.fields In dao_detail.Details
                    'XML.TABEAN_SUBPACKAGE.Add(dao_detail.fields)

                    Dim pk As String = ""
                    pk = " primary packaging " & dao_detail.fields.PACK_FSIZE_NAME & " " & dao_detail.fields.PACK_FSIZE_VOLUME & " " & dao_detail.fields.PACK_FSIZE_UNIT_NAME & " secondary packaging " &
                        dao_detail.fields.PACK_SECSIZE_NAME & " " & dao_detail.fields.PACK_SECSIZE_VOLUME & " " & dao_detail.fields.PACK_SECSIZE_UNIT_NAME & " tertiary packaging " &
                        dao_detail.fields.PACK_THSIZE_NAME & " " & dao_detail.fields.PACK_THSSIZE_VOLUME & " " & dao_detail.fields.PACK_THSIZE_UNIT_NAME

                    'XML.list_subpackage.Add(pk)
                Next

                If dao_lcn.fields.PROCESS_ID = 121 Then
                    Dim dao_lcn_HPI As New DAO_LCN.TB_dalcn
                    dao_lcn_HPI.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 121)

                    Dim dao_lcn_bsn_HPI As New DAO_LCN.TB_DALCN_LOCATION_BSN
                    dao_lcn_bsn_HPI.GetDataby_LCN_IDA(_IDA_LCN)

                    Dim LCNNO_DISPLAY_NEW_HPI As String = dao_lcn_HPI.fields.LCNNO_DISPLAY_NEW
                    Dim THANM_HPI As String = dao_lcn_HPI.fields.thanm
                    Dim BSN_THAIFULLNAME_HPI As String = dao_lcn_bsn_HPI.fields.BSN_THAIFULLNAME

                    dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPI.fields.FK_IDA)

                    dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPI")
                    dt_lcn_location.Columns.Add("THANM_HPI")
                    dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPI")

                    For Each dr As DataRow In dt_lcn_location.Rows
                        Try
                            dr("LCNNO_DISPLAY_NEW_HPI") = LCNNO_DISPLAY_NEW_HPI
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM_HPI") = THANM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("BSN_THAIFULLNAME_HPI") = BSN_THAIFULLNAME
                        Catch ex As Exception

                        End Try

                    Next
                    dt_lcn_location.TableName = "XML_TABEAN_JJ_LOCATION_ADDRESS_HPI"
                    XML.DT_SHOW.DT1 = dt_lcn_location
                ElseIf dao_lcn.fields.PROCESS_ID = 122 Then
                    Dim dao_lcn_HPM As New DAO_LCN.TB_dalcn
                    dao_lcn_HPM.GetDataby_IDA_and_PROCESS_ID(_IDA_LCN, 122)

                    Dim dao_lcn_bsn_HPM As New DAO_LCN.TB_DALCN_LOCATION_BSN
                    dao_lcn_bsn_HPM.GetDataby_LCN_IDA(_IDA_LCN)

                    Dim LCNNO_DISPLAY_NEW_HPM As String = dao_lcn_HPM.fields.LCNNO_DISPLAY_NEW
                    Dim THANM_HPM As String = dao_lcn_HPM.fields.thanm
                    Dim BSN_THAIFULLNAME_HPM As String = dao_lcn_bsn_HPM.fields.BSN_THAIFULLNAME

                    dt_lcn_location = bao_lcn.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao_lcn_HPM.fields.FK_IDA)

                    dt_lcn_location.Columns.Add("LCNNO_DISPLAY_NEW_HPM")
                    dt_lcn_location.Columns.Add("THANM_HPM")
                    dt_lcn_location.Columns.Add("BSN_THAIFULLNAME_HPM")

                    For Each dr As DataRow In dt_lcn_location.Rows
                        Try
                            dr("LCNNO_DISPLAY_NEW_HPM") = LCNNO_DISPLAY_NEW_HPM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("THANM_HPM") = THANM
                        Catch ex As Exception

                        End Try
                        Try
                            dr("BSN_THAIFULLNAME_HPM") = BSN_THAIFULLNAME
                        Catch ex As Exception

                        End Try

                    Next

                    dt_lcn_location.TableName = "XML_TABEAN_JJ_LOCATION_ADDRESS_HPM"
                    XML.DT_SHOW.DT2 = dt_lcn_location
                End If

                If TYPE_PERSON = 1 Then
                    XML.THANM_THAIFULLNAME = THANM
                Else
                    XML.THANM_THAIFULLNAME = BSN_THAIFULLNAME
                End If


                Return XML
            End Function
        End Class
    End Class
End Namespace
