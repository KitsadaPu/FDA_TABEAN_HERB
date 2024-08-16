Imports System.IO
Imports System.Text
Imports System.Web.Mvc
Imports System.Xml.Serialization
Imports System.Globalization
Imports Newtonsoft.Json
Imports System.Web.Script.Serialization
Imports System.Xml

Public Class CORE_FUNC

    Inherits Controller
    Public Function BindTable_lcn_cer(ByVal MODEL As MODEL_APP) As Object
        'Dim clsds As New ClassDataset
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset SP_MAS_STATUS_STAFF
        Dim sql As String = ""
        Dim citizen_id As String = ""
        'Dim citizen_id As String = "3901100313466"
        'citizen_id = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
        If citizen_id = "" Then
            citizen_id = MODEL.IDEN_SEARCH
        End If

        dt = clsds.SP_GET_DRUG_LCN_IDEN_HERB(citizen_id)

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        Return DataTableToJSON(dt)
    End Function
    Public Function BindTable(ByVal MODEL As MODEL_APP) As Object
        'Dim clsds As New ClassDataset
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset
        Dim sql As String = ""

        If MODEL.INFOR_SEARCH.txt_Product_THAI IsNot Nothing Or MODEL.INFOR_SEARCH.txt_Product_ENG IsNot Nothing Or MODEL.INFOR_SEARCH.Txt_fdpdtno IsNot Nothing Then
            sql = "exec [dbo].[SP_SEARCH_PRODUCT_ESUB_HERB] @thadrgnm= '" & MODEL.INFOR_SEARCH.txt_Product_THAI &
                "',@engdrgnm='" & MODEL.INFOR_SEARCH.txt_Product_ENG &
                "',@register='" & MODEL.INFOR_SEARCH.Txt_fdpdtno & "'"

            'dt = clsds.Queryds_xml_drug_HERB(sql)

            'dt.Columns.Add("index")

            'Dim index As Integer = 0
            'For Each item As DataRow In dt.Rows
            '    index += 1
            '    'Dim row As DataRow

            '    item("index") = index

            '    Dim Newcode_datarow As DataRow()
            '    Dim Newcode_item As String
            '    Newcode_item = item("Newcode_U")                      'ตอนแรกได้ Newcode มาเก็บใน Newcode_item
            '    Dim Newcode_string As String = "Newcode_U = '" & Newcode_item & "'"         'การ where ด้วย datatable
            '    Newcode_datarow = dt.Select(Newcode_string)       'การ where ด้วย datatable

            '    If Newcode_datarow.Length >= 1 Then

            '    Else

            '        'dt.Rows.Add(row)
            '    End If

            'Next


            Try
                dt = clsds.Queryds_xml_drug_HERB(sql)

                Dim index As Integer = 0
                dt1.Columns.Add("register")
                dt1.Columns.Add("thadrgnm")
                dt1.Columns.Add("engdrgnm")
                dt1.Columns.Add("licen_loca")
                dt1.Columns.Add("thadsgnm")
                dt1.Columns.Add("engdsgnm")

                dt1.Columns.Add("cncnm")
                dt1.Columns.Add("Newcode_not")
                dt1.Columns.Add("Newcode_U")
                dt1.Columns.Add("index")
                dt1.Columns.Add("pvncd")
                dt1.Columns.Add("drgtpcd")
                dt1.Columns.Add("rgttpcd")
                dt1.Columns.Add("rgtno")

                For Each item As DataRow In dt.Rows

                    index += 1
                    Dim row As DataRow
                    row = dt1.NewRow
                    row("thadrgnm") = item("thadrgnm")
                    row("engdrgnm") = item("engdrgnm")
                    row("licen_loca") = item("licen_loca")

                    row("thadsgnm") = item("thadsgnm")
                    row("engdsgnm") = item("engdsgnm")
                    row("cncnm") = item("cncnm")
                    row("Newcode_not") = item("Newcode_not")
                    row("Newcode_U") = item("Newcode_U")
                    row("register") = item("register")
                    row("pvncd") = item("pvncd")
                    row("drgtpcd") = item("drgtpcd")
                    row("rgttpcd") = item("rgttpcd")
                    row("rgtno") = item("rgtno")
                    row("index") = index


                    Dim Newcode_datarow As DataRow()
                    Dim Newcode_item As String
                    Newcode_item = item("Newcode_U")                      'ตอนแรกได้ Newcode มาเก็บใน Newcode_item
                    Dim Newcode_string As String = "Newcode_U = '" & Newcode_item & "'"         'การ where ด้วย datatable
                    Newcode_datarow = dt1.Select(Newcode_string)       'การ where ด้วย datatable


                    If Newcode_datarow.Length >= 1 Then

                    Else

                        dt1.Rows.Add(row)
                    End If

                Next

            Catch ex As Exception

            End Try
        ElseIf MODEL.INFOR_SEARCH.txt_substance IsNot Nothing Then
            sql = "exec [dbo].[SP_SEARCH_PRODUCT_FORMULA_HERB] @principle_DRUG= '" & MODEL.INFOR_SEARCH.txt_substance & "'"
            Try
                dt = clsds.Queryds_xml_drug_HERB(sql)


                Dim index As Integer = 0
                dt1.Columns.Add("register")
                dt1.Columns.Add("thadrgnm")
                dt1.Columns.Add("engdrgnm")
                dt1.Columns.Add("licen_loca")
                dt1.Columns.Add("thadsgnm")
                dt1.Columns.Add("engdsgnm")
                dt1.Columns.Add("cncnm")
                dt1.Columns.Add("Newcode_not")
                dt1.Columns.Add("Newcode_U")
                dt1.Columns.Add("index")
                dt1.Columns.Add("pvncd")
                dt1.Columns.Add("drgtpcd")
                dt1.Columns.Add("rgttpcd")
                dt1.Columns.Add("rgtno")
                For Each item As DataRow In dt.Rows

                    index += 1
                    Dim row As DataRow
                    row = dt1.NewRow
                    row("thadrgnm") = item("thadrgnm")
                    row("engdrgnm") = item("engdrgnm")
                    row("licen_loca") = item("licen_loca")
                    row("thadsgnm") = item("thadsgnm")
                    row("engdsgnm") = item("engdsgnm")
                    row("cncnm") = item("cncnm")
                    row("Newcode_not") = item("Newcode_not")
                    row("Newcode_U") = item("Newcode_U")
                    row("register") = item("register")
                    row("pvncd") = item("pvncd")
                    row("drgtpcd") = item("drgtpcd")
                    row("rgttpcd") = item("rgttpcd")
                    row("rgtno") = item("rgtno")
                    row("index") = index

                    Dim Newcode_datarow As DataRow()
                    Dim Newcode_item As String
                    Newcode_item = item("Newcode_U")                      'ตอนแรกได้ Newcode มาเก็บใน Newcode_item
                    Dim Newcode_string As String = "Newcode_U = '" & Newcode_item & "'"         'การ where ด้วย datatable
                    Newcode_datarow = dt1.Select(Newcode_string)       'การ where ด้วย datatable


                    If Newcode_datarow.Length >= 1 Then

                    Else

                        dt1.Rows.Add(row)
                    End If

                Next
            Catch ex As Exception

            End Try
        End If
        Return DataTableToJSON(dt1)
    End Function
    Public Function BindTable_Drr(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset
        Dim sql As String = ""
        Dim bao_search As New ClassDataset
        '@ida='" & MODEL.DALCN_SEARCH.IDA & "'
        sql = "exec [dbo].[sp_search_drr]"

        Try
            dt = clsds.Queryds_LGT_DRUG(sql)

            If MODEL.DRR_HERB.thachngwtnm IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[thachngwtnm] like '%" & MODEL.DRR_HERB.thachngwtnm & "%' ")
            If MODEL.DRR_HERB.rgttpcd IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[rgttpcd] like '%" & MODEL.DRR_HERB.rgttpcd & "%' ")
            If MODEL.DRR_HERB.thadrgnm IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[thadrgnm] like '%" & MODEL.DRR_HERB.thadrgnm & "%' ")
            If MODEL.DRR_HERB.engdrgnm IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[engdrgnm] like '%" & MODEL.DRR_HERB.engdrgnm & "%' ")
            If MODEL.DRR_HERB.register IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[register] like '%" & MODEL.DRR_HERB.register & "%' ")
            If MODEL.DRR_HERB.register_rcvno IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[register_rcvno] like '%" & MODEL.DRR_HERB.register_rcvno & "%' ")
            If MODEL.DRR_HERB.STATUS_NAME IsNot Nothing Then dt = bao_search.DatatableWhere(dt, "[STATUS_NAME] like '%" & MODEL.DRR_HERB.STATUS_NAME & "%' ")
        Catch ex As Exception

        End Try

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        Return DataTableToJSON(dt)
    End Function

    Public Function Binddata_detail_Drr(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset
        Dim sql As String = ""
        Dim bao_search As New ClassDataset
        '@ida='" & MODEL.DALCN_SEARCH.IDA & "'
        sql = "exec [dbo].[sp_search_drr_byida] @IDA =" + MODEL.IDA

        Try
            dt = clsds.Queryds_LGT_DRUG(sql)


        Catch ex As Exception

        End Try

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        Return DataTableToJSON(dt)
    End Function
    Public Function Binddata_lcn_edit_staff(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        dt = bao.SP_LCN_APPROVE_EDIT_GET_DATA(0, 1)

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        Return DataTableToJSON(dt)
    End Function
    Public Function Binddata_Tabean_Substitute(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        dt = bao.SP_TABEAN_HERB_SUBSTITUTE_BY_FK_IDA(MODEL.IDA_DR)
        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        MODEL.Substitute_Tabean = DataTableToJSON(dt)
        Return MODEL
    End Function
    Public Function GetDataTabeanSubstitute(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)
        MODEL = SEARCH_NAME_BY_IDEN(MODEL)
        Dim dao_bsn As New DAO_LCN.TB_DALCN_LOCATION_BSN
        dao_bsn.GetDataby_LCN_IDA(MODEL.IDA_LCN)
        If dao.fields.IDA = 0 Then
            MODEL.TABEAN_HERB_SUBSTITUTE.THANM = MODEL.NAME
            MODEL.TABEAN_HERB_SUBSTITUTE.PROCESS_ID = MODEL.PROCESS_ID
            MODEL.TABEAN_HERB_SUBSTITUTE.NAME_ENG = MODEL.NAME_ENG
            MODEL.TABEAN_HERB_SUBSTITUTE.NAME_THAI = MODEL.NAME_THAI
            MODEL.TABEAN_HERB_SUBSTITUTE.RGTNO_FULL = MODEL.RGTNO_DISPLAY
            MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON = MODEL.PERASON_TYPE
            MODEL.TABEAN_HERB_SUBSTITUTE.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
            MODEL.TABEAN_HERB_SUBSTITUTE.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
            MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99 = dao_bsn.fields.BSN_THAIFULLNAME
            MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99_ID = dao_bsn.fields.BSN_IDENTIFY
            If dao_bsn.fields.AGE = 0 Or dao_bsn.fields.AGE Is Nothing Then
                MODEL.TABEAN_HERB_SUBSTITUTE.PERSON_AGE = 0
            Else
                MODEL.TABEAN_HERB_SUBSTITUTE.PERSON_AGE = dao_bsn.fields.AGE
            End If

        Else
            MODEL.TABEAN_HERB_SUBSTITUTE = dao.fields
        End If
        Dim dao_lcn As New DAO_LCN.TB_dalcn
        dao_lcn.GetDataby_IDA(MODEL.IDA_LCN)
        MODEL.dalcn = dao_lcn.fields
        Return MODEL
    End Function
    Public Function SaveDataTabeanSubstitute(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)
        Dim dao_lcn As New DAO_LCN.TB_dalcn
        dao_lcn.GetDataby_IDA(MODEL.IDA_LCN)
        Dim TR_ID As String = ""
        Dim bao_tran As New BAO_TRANSECTION
        If dao.fields.IDA = 0 Then
            dao.fields.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
            dao.fields.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
            dao.fields.CREATE_BY = MODEL.CLS_SESSION.THANM
            dao.fields.CREATE_DATE = Date.Now
            dao.fields.pvncd = dao_lcn.fields.pvncd
            dao.fields.PURPOSE_ID = MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE_ID
            If MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE_ID = 1 Then
                dao.fields.PURPOSE = "ใบอนุญาตสูญหาย"
            ElseIf MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE_ID = 2 Then
                dao.fields.PURPOSE = "ใบอนุญาตถูกทำลาย หรือ ลบเลือนในสาระสำคัญ"
            End If

            dao.fields.Newcode = MODEL.Newcode
            dao.fields.FK_IDA = MODEL.IDA_DR
            dao.fields.NAME_THAI = MODEL.TABEAN_HERB_SUBSTITUTE.NAME_THAI
            dao.fields.NAME_ENG = MODEL.TABEAN_HERB_SUBSTITUTE.NAME_ENG
            dao.fields.RGTNO_FULL = MODEL.TABEAN_HERB_SUBSTITUTE.RGTNO_FULL
            dao.fields.TYPE_PERSON = MODEL.PERASON_TYPE
            dao.fields.THANM = MODEL.TABEAN_HERB_SUBSTITUTE.THANM
            dao.fields.IDENTIFY = MODEL.TABEAN_HERB_SUBSTITUTE.IDENTIFY
            dao.fields.PERSON_AGE = MODEL.TABEAN_HERB_SUBSTITUTE.PERSON_AGE
            dao.fields.TypePersonName = MODEL.TABEAN_HERB_SUBSTITUTE.TypePersonName
            dao.fields.AGENT99 = MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99
            dao.fields.AGENT99_ID = MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99_ID
            dao.fields.NATIONAL_NAME = MODEL.TABEAN_HERB_SUBSTITUTE.NATIONAL_NAME
            dao.fields.PROCESS_ID = MODEL.TABEAN_HERB_SUBSTITUTE.PROCESS_ID
            dao.fields.YEAR = con_year(Date.Now().Year())
            Try
                bao_tran.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
                bao_tran.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE

                TR_ID = bao_tran.insert_transection(MODEL.PROCESS_ID)
            Catch ex As Exception

            End Try
            dao.fields.FK_LCN = dao_lcn.fields.IDA
            dao.fields.pvncd = dao_lcn.fields.pvncd
            dao.fields.lcntpcd = dao_lcn.fields.lcntpcd
            dao.fields.lcnno = dao_lcn.fields.lcnno
            dao.fields.LCNNO_DISPLAY_NEW = dao_lcn.fields.LCNNO_DISPLAY_NEW
            dao.fields.FK_IDA = MODEL.IDA_DR
            dao.fields.IDA_DR = MODEL.IDA_DR
            dao.fields.TR_ID = TR_ID
            dao.fields.STATUS_ID = 1
            dao.fields.ACTIVEFACT = 1
            dao.insert()

            Dim dao_up_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE_JJ
            If dao.fields.PURPOSE_ID = 1 Then
                dao_up_mas.GetdatabyID_TYPE(260)
            Else
                dao_up_mas.GetdatabyID_TYPE(261)
            End If

            For Each dao_up_mas.fields In dao_up_mas.datas
                Dim dao_up As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE_JJ
                dao_up.fields.DUCUMENT_NAME = dao_up_mas.fields.DUCUMENT_NAME
                dao_up.fields.DUCUMENT_ID = dao_up_mas.fields.ID
                dao_up.fields.TR_ID = TR_ID
                dao_up.fields.FK_IDA = dao.fields.IDA
                dao_up.fields.PROCESS_ID = MODEL.PROCESS_ID
                dao_up.fields.FK_IDA_LCN = MODEL.IDA_LCN
                dao_up.fields.TYPE = 1
                dao_up.insert()
            Next
            MODEL.TR_ID = TR_ID
            MODEL.IDA = dao.fields.IDA

            'Dim dao_up2 As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE_JJ
            'dao_up2.GetdatabyID_TR_ID_PROCESS_ID(dao.fields.TR_ID, MODEL.PROCESS_ID)
            'MODEL.FILEUPLOADTABLE = dao_up2.fields
            GET_FILE_UPLOAD_TABEAN_CENNTER(MODEL)
        Else
            dao.fields.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
            'dao.fields.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
            dao.fields.CREATE_BY = MODEL.CLS_SESSION.THANM
            dao.fields.CREATE_DATE = Date.Now
            dao.fields.pvncd = dao_lcn.fields.pvncd
            dao.fields.PURPOSE_ID = MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE_ID
            dao.fields.PURPOSE = MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE
            dao.fields.FK_IDA = MODEL.IDA_DR
            dao.fields.NAME_THAI = MODEL.TABEAN_HERB_SUBSTITUTE.NAME_THAI
            dao.fields.NAME_ENG = MODEL.TABEAN_HERB_SUBSTITUTE.NAME_ENG
            dao.fields.RGTNO_FULL = MODEL.TABEAN_HERB_SUBSTITUTE.RGTNO_FULL
            dao.fields.TYPE_PERSON = MODEL.PERASON_TYPE
            dao.fields.THANM = MODEL.TABEAN_HERB_SUBSTITUTE.THANM
            dao.fields.IDENTIFY = MODEL.TABEAN_HERB_SUBSTITUTE.IDENTIFY
            dao.fields.NATIONAL_NAME = MODEL.TABEAN_HERB_SUBSTITUTE.NATIONAL_NAME
            dao.fields.PERSON_AGE = MODEL.TABEAN_HERB_SUBSTITUTE.PERSON_AGE
            dao.fields.TypePersonName = MODEL.TABEAN_HERB_SUBSTITUTE.TypePersonName
            dao.fields.AGENT99 = MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99
            dao.fields.AGENT99_ID = MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99_ID
            dao.fields.NATIONAL_NAME = MODEL.TABEAN_HERB_SUBSTITUTE.NATIONAL_NAME
            dao.Update()
        End If

        Return MODEL
    End Function
    Public Function UpdateDataTabeanSubConfirm(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)

        dao.fields.DATE_CONFIRM = Date.Now
        dao.fields.STATUS_ID = 2
        dao.Update()

        Return MODEL
    End Function
    Public Function UpdateDataStaffTabeanSubConfirm(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)
        Dim mas_staff As New DAO_DRUG.TB_MAS_STAFF_NAME_HERB
        mas_staff.GetdatabyID_IDA(MODEL.STAFF_NAME_ID)
        If MODEL.CONFIRM_STATUS_ID = 3 Then
            dao.fields.rcv_StaffID = MODEL.STAFF_NAME_ID
            'dao.fields.rcv_StaffName = mas_staff.fields.STAFF_NAME
            dao.fields.rcv_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.rcvdate = MODEL.DATE_CONNFIRM
            Dim bao As New BAO.GenNumber
            Dim RCVNO As String = ""
            Dim RCVNO_HERB_NEW As String = ""
            'Dim pvncd As String = dao.fields.pvncd
            Dim pvncd As String = 10

            RCVNO = bao.GEN_RCVNO_NO(con_year(Date.Now.Year()), pvncd, dao.fields.PROCESS_ID, MODEL.IDA)
            Dim TR_ID As String = dao.fields.TR_ID
            MODEL.TR_ID = TR_ID
            Dim DATE_YEAR As String = con_year(Date.Now().Year()).Substring(2, 2)
            RCVNO_HERB_NEW = bao.GEN_RCVNO_NO_NEW(con_year(Date.Now.Year()), MODEL.CLS_SESSION.PVCODE, dao.fields.PROCESS_ID, MODEL.IDA)
            Dim RCVNO_FULL As String = "HB" & " " & pvncd & "-" & dao.fields.PROCESS_ID & "-" & DATE_YEAR & "-" & RCVNO_HERB_NEW
            dao.fields.RCVNO_NEW = RCVNO_FULL
            dao.fields.rcvno = RCVNO
        ElseIf MODEL.CONFIRM_STATUS_ID = 11 Then
            dao.fields.staff_edit_id = MODEL.STAFF_NAME_ID
            'dao.fields.staff_edit_name = mas_staff.fields.STAFF_NAME
            dao.fields.staff_edit_name = MODEL.STAFF_NAME_CONFIRM
            dao.fields.staff_edit_date = MODEL.DATE_CONNFIRM
            dao.Update()
            AddLogStatus(dao.fields.STATUS_ID, dao.fields.PROCESS_ID, MODEL.CLS_SESSION.CITIZEN_ID, MODEL.STAFF_NAME_ID, "", MODEL.CONFIRM_STATUS_NAME, MODEL.IDA)
            'Response.Redirect("POPUP_TABEAN_SUBSTITUTE_STAFF_EDIT.aspx?IDA=" & _IDA & "&process_id=" & dao.fields.PROCESS_ID & "&IDA_LCN=" & _IDA_LCN & "&TR_ID=" & _TR_ID)
        ElseIf MODEL.CONFIRM_STATUS_ID = 5 Then
            dao.fields.CONSIDER_StaffID = MODEL.STAFF_NAME_ID
            'dao.fields.CONSIDER_StaffName = mas_staff.fields.STAFF_NAME
            dao.fields.CONSIDER_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.CONSIDER_DATE = MODEL.DATE_CONNFIRM
        ElseIf MODEL.CONFIRM_STATUS_ID = 8 Then
            dao.fields.appdate_StaffID = MODEL.STAFF_NAME_ID
            'dao.fields.appdate_StaffName = mas_staff.fields.STAFF_NAME
            dao.fields.appdate_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.appdate = MODEL.DATE_CONNFIRM
        ElseIf MODEL.CONFIRM_STATUS_ID = 9 Or dao.fields.STATUS_ID = 7 Or dao.fields.STATUS_ID = 10 Then
            dao.fields.NOTE_CANCEL = MODEL.NOTE_STAFF
            Try
                dao.fields.DD_CANCEL_ID = MODEL.STAFF_NAME_ID
                'dao.fields.DD_CANCEL_NM = mas_staff.fields.STAFF_NAME
                dao.fields.DD_CANCEL_NM = MODEL.STAFF_NAME_CONFIRM
            Catch ex As Exception

            End Try
            'UC_ATTACH1.insert_TBN_SUB(_TR_ID, _Process_ID, dao.fields.IDA, 77)
        End If
        dao.fields.STATUS_ID = MODEL.CONFIRM_STATUS_ID
        dao.Update()
        'AddLogStatus(dao.fields.STATUS_ID, dao.fields.PROCESS_ID, MODEL.CLS_SESSION.CITIZEN_ID, MODEL.IDA)
        AddLogStatus(dao.fields.STATUS_ID, dao.fields.PROCESS_ID, MODEL.CLS_SESSION.CITIZEN_ID, MODEL.STAFF_NAME_ID, "", MODEL.CONFIRM_STATUS_NAME, MODEL.IDA)

        Return MODEL
    End Function
    Public Function UpdateDataKeepStatusSub(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)
        dao.fields.STATUS_ID = 4
        dao.Update()

        Return MODEL
    End Function
    Public Function UpdateDataKeepStatusRenew(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        If MODEL.STATUS_ID = 31 Or MODEL.STATUS_ID = 41 Then
            dao.fields.STATUS_ID = 42
            'ElseIf MODEL.STATUS_ID = 1 Then
            '    dao.fields.STATUS_ID = 4
        Else

        End If
        dao.Update()
        Return MODEL
    End Function
    Public Function INSET_REQUEST_TABEAN_RENEW(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        Dim TR_ID As String = ""
        Dim bao_tran As New BAO_TRANSECTION
        Dim dao_lcn As New DAO_LCN.TB_dalcn
        Dim dao_lcn_herb As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
        Dim dao_dr As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
        Try
            dao_dr.GetDataby_NEWCODE(MODEL.Newcode)
            Try
                dao_lcn.GetDataby_IDA(MODEL.IDA_LCN)
                dao_lcn_herb.GetDataby_u1(dao_dr.fields.Newcode_not)
            Catch ex As Exception

            End Try
            dao.fields.PROCESS_ID = MODEL.PROCESS_ID
            dao.fields.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
            dao.fields.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
            dao.fields.IDENTIFY = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
            dao.fields.CREATE_BY = MODEL.CLS_SESSION.THANM
            dao.fields.CREATE_DATE = Date.Now
            dao.fields.YEAR = con_year(Date.Now().Year())
            dao.fields.STATUS_ID = 1
            dao.fields.ACTIVEFACT = 1
            Try
                bao_tran.CITIZEN_ID = MODEL.CLS_SESSION.CITIZEN_ID
                bao_tran.CITIZEN_ID_AUTHORIZE = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
                TR_ID = bao_tran.insert_transection(MODEL.PROCESS_ID)
            Catch ex As Exception

            End Try
            dao.fields.pvncd = 10
            dao.fields.rgtno = MODEL.TABEAN_RENEW.rgtno
            dao.fields.rgttpcd = MODEL.TABEAN_RENEW.rgttpcd
            dao.fields.drgtpcd = MODEL.TABEAN_RENEW.drgtpcd
            dao.fields.Register = MODEL.TABEAN_RENEW.Register
            dao.fields.Newcode_Not = MODEL.TABEAN_RENEW.Newcode_Not
            dao.fields.Newcode_U = MODEL.TABEAN_RENEW.Newcode_U
            dao.fields.Holder_Name = MODEL.TABEAN_RENEW.Holder_Name
            dao.fields.Holder_Iden = MODEL.TABEAN_RENEW.Holder_Iden
            dao.fields.Holder_Addr = MODEL.TABEAN_RENEW.Holder_Addr
            dao.fields.thadrgnm = MODEL.TABEAN_RENEW.thadrgnm
            dao.fields.engdrgnm = MODEL.TABEAN_RENEW.engdrgnm
            dao.fields.lcntpcd = MODEL.TABEAN_RENEW.lcntpcd
            dao.fields.TYPE_PERSON = MODEL.TABEAN_RENEW.TYPE_PERSON
            dao.fields.Age = MODEL.TABEAN_RENEW.Age
            Try
                dao.fields.BSN_PREFIX_CD = MODEL.TABEAN_RENEW.BSN_PREFIX_CD
                dao.fields.BSN_PREFIX_NM = MODEL.TABEAN_RENEW.BSN_PREFIX_NM
                dao.fields.BSN_LNAME = MODEL.TABEAN_RENEW.BSN_LNAME
                dao.fields.BSN_NAME = MODEL.TABEAN_RENEW.BSN_NAME
                dao.fields.BSN_FULLNAME_TH = MODEL.TABEAN_RENEW.BSN_PREFIX_NM & " " & MODEL.TABEAN_RENEW.BSN_NAME & " " & MODEL.TABEAN_RENEW.BSN_LNAME
                dao.fields.BSN_IDENTIFY = MODEL.TABEAN_RENEW.BSN_IDENTIFY
            Catch ex As Exception

            End Try
            dao.fields.Email = MODEL.TABEAN_RENEW.Email
            dao.fields.PhoneNumber = MODEL.TABEAN_RENEW.PhoneNumber
            dao.fields.Nation = MODEL.TABEAN_RENEW.Nation

            dao.fields.FK_LCN = MODEL.XML_SEARCH_DRUG_LCN_HERB.IDA_dalcn
            dao.fields.lpvncd = MODEL.XML_SEARCH_DRUG_LCN_HERB.pvncd
            'dao.fields.pvncd = dao_lcn_herb.fields.pvncd
            dao.fields.lcnsid = MODEL.XML_SEARCH_DRUG_LCN_HERB.lcnsid
            'dao.fields.lcntpcd = dao_lcn_herb.fields.lcntpcd
            dao.fields.LCNNO = MODEL.XML_SEARCH_DRUG_LCN_HERB.lcnno
            dao.fields.LCNNO_DISPLAY_NEW = MODEL.XML_SEARCH_DRUG_LCN_HERB.lcnno_display_new
            dao.fields.LCNNO_NEW = dao_lcn_herb.fields.lcnno_display_new
            dao.fields.DRUG_NAME = dao_dr.fields.thadrgnm
            dao.fields.DRUG_NAME_ENG = dao_dr.fields.engdrgnm
            dao.fields.FK_IDA = dao_dr.fields.IDA_drrgt
            dao.fields.FK_LCT = dao_lcn.fields.FK_IDA
            'dao.fields.IDA_DR = MODEL.IDA_DR
            dao.fields.FK_IDA = dao_dr.fields.IDA_drrgt
            dao.fields.TR_ID = TR_ID
            dao.fields.WRITE_AT = "สำนักงานคณะกรรมการอาหารและยา"
            dao.fields.WRITE_DATE = Date.UtcNow
            If MODEL.PROCESS_ID = 20710 Then
                'Dim dao_qt As New DAO_TABEAN.ClsDBdrrqt
                'dao_dr.GetDataby_IDA(MODEL.IDA_DR)
                Dim dao_dr2 As New DAO_TABEAN.TB_TABEAN_HERB
                dao_dr2.GetdatabyID_FK_IDA_DQ(MODEL.IDA_DR)
                dao.fields.RGTNO_FULL = dao_dr.fields.register
                dao.fields.LCN_NAME = dao_lcn_herb.fields.licen
            ElseIf MODEL.PROCESS_ID = 20720 Then

            ElseIf MODEL.PROCESS_ID = 20730 Then
                'Dim dao_dr As New DAO_TABEAN.TB_TABEAN_JJ
                'dao_dr.GetdatabyID_IDA(MODEL.IDA_DR)
                dao.fields.RGTNO_FULL = dao_dr.fields.register
                dao.fields.LCN_NAME = dao_lcn_herb.fields.licen
            End If
            dao.insert()
            MODEL.TR_ID = TR_ID
            MODEL.IDA = dao.fields.IDA
            Dim Condition As String = ""
            INSERT_ATTACH_FILE(MODEL.PROCESS_ID, Condition, MODEL)
            If dao_dr.fields.lcntpcd = "นสม" Then
                Condition = "นำเข้า"
                INSERT_ATTACH_FILE(MODEL.PROCESS_ID, Condition, MODEL)
            End If

            Dim bao As New BAO.BAO
            Dim dt_up As New DataTable
            Dim index As Integer = 0
            dt_up = bao.SP_TABEAN_UPLOAD_FILE_CENTER(TR_ID, MODEL.PROCESS_ID)
            dt_up.Columns.Add("index")
            For Each item As DataRow In dt_up.Rows
                index += 1
                item("index") = index
            Next
            MODEL.FILEUPLOADTABLE = DataTableToJSON(dt_up)
        Catch ex As Exception
            MODEL.ERR_ALERT = "เกิดข้อผิดผลาด ไม่สามรถสร้างคำขอได้ (" & ex.Message & ")"
        End Try
        Return MODEL
    End Function
    Public Sub INSERT_ATTACH_FILE(ByVal Process_ID As Integer, ByVal Condition As String, ByVal MODEL As MODEL_APP)
        Dim dao_up_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE
        If Condition = "" Then
            dao_up_mas.Getdataby_Process_ID_Condition(Process_ID, "N")
        Else
            dao_up_mas.Getdataby_Process_ID_And_ConditionDetail(Process_ID, Condition)
        End If
        Dim Forcible As Integer
        For Each dao_up_mas.fields In dao_up_mas.datas
            Dim dao_up As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
            With dao_up_mas.fields
                Forcible = .Forcible
                dao_up.fields.Document_Name = .DocumentName
                dao_up.fields.Document_ID = .ID
                dao_up.fields.Forcible = Forcible
                dao_up.fields.FilePath = .PathFile
                dao_up.fields.TR_ID = MODEL.TR_ID
                dao_up.fields.FK_IDA = MODEL.IDA
                dao_up.fields.ProcessID = MODEL.PROCESS_ID
                dao_up.fields.TYPE = .TypeID
                dao_up.fields.CREATE_DATE = DateTime.Now
                dao_up.fields.CitizenID = MODEL.CLS_SESSION.CITIZEN_ID
                dao_up.fields.SEQ = .SEQ
            End With
            dao_up.insert()
        Next
    End Sub
    Public Function UpdateDataConfirmRenew(ByVal MODEL As MODEL_APP) As Object
        Dim CHK_FILE As String
        Dim SSID As Integer = 0
        CHK_FILE = Check_File_Uploads(MODEL)
        If CHK_FILE <> "" Then Return MODEL.ALERT_MS
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        dao.fields.DATE_CONFIRM = Date.Now

        'Dim dao_p As New DAO_TABEAN.TB_MAS_PRICE_DISCOUNT_TABEAN_HERB
        'dao_p.GetdatabyID_ID(MODEL.TABEAN_RENEW.Discount_RequestID)

        Dim dao_req As New DAO_TABEAN.TB_MAS_PRICE_REQUEST_HERB
        dao_req.Getdataby_SUb_Process(MODEL.TABEAN_RENEW.T_Resuest_ID)
        dao.fields.T_Resuest_ID = dao_req.fields.Sub_Process
        dao.fields.T_Resuest_NM = dao_req.fields.Process_Descrip
        dao.fields.ML_REQUEST = dao_req.fields.Price
        dao.fields.Pay_Request_Name = dao_req.fields.Request_Show
        dao.fields.Pay_Request_ID = dao_req.fields.ID

        Dim bao As New BAO.GenNumber
        Dim RCVNO As String = ""
        Dim RCVNO_HERB_NEW As String = ""
        'Dim pvncd As String = dao.fields.pvncd
        Dim pvncd As String = 10

        RCVNO = bao.GEN_RCVNO_NO(con_year(Date.Now.Year()), pvncd, MODEL.PROCESS_ID, MODEL.IDA)
        Dim TR_ID As String = dao.fields.TR_ID
        Dim DATE_YEAR As String = con_year(Date.Now().Year()).Substring(2, 2)
        RCVNO_HERB_NEW = bao.GEN_RCVNO_NO_NEW(con_year(Date.Now.Year()), pvncd, MODEL.PROCESS_ID, MODEL.IDA)
        Dim RCVNO_FULL As String = "HB" & " " & pvncd & "-" & MODEL.PROCESS_ID & "-" & DATE_YEAR & "-" & RCVNO_HERB_NEW
        dao.fields.RCVNO_NEW = RCVNO_FULL
        dao.fields.RCVNO = RCVNO

        dao.fields.Appoinment_Contact = MODEL.TABEAN_RENEW.Appoinment_Contact
        dao.fields.Appoinment_Email = MODEL.TABEAN_RENEW.Appoinment_Email
        dao.fields.Appoinment_Phone = MODEL.TABEAN_RENEW.Appoinment_Phone
        dao.fields.Discount_Detail = MODEL.TABEAN_RENEW.Discount_Detail
        'Try
        '    dao.fields.Discount_RequestID = MODEL.TABEAN_RENEW.Discount_RequestID
        '    dao.fields.Discount_RequestName = MODEL.TABEAN_RENEW.Discount_RequestName
        '    dao.fields.ML_REQUEST = SUM_Discount(MODEL)
        'Catch ex As Exception

        'End Try
        'If dao_p.fields.REQUEST_Fee = 100 Then
        '    dao.fields.STATUS_ID = 4
        'Else
        dao.fields.STATUS_ID = 3
        SSID = dao.fields.STATUS_ID
        'End If
        dao.Update()
        If SSID = 3 Then
            Dim SW As New SW_HERB_PAYMENT.SW_LCN_EDIT_PAYMENT
            SW.INSERT_HERB_PAYMENT_CENTER_L44(dao.fields.CITIZEN_ID_AUTHORIZE, MODEL.IDA, MODEL.PROCESS_ID)
        End If
        SendMailAndSMS(dao.fields.Appoinment_Phone, dao.fields.Appoinment_Email, MODEL.PROCESS_ID, SSID, dao.fields.TR_ID)
        Return MODEL
    End Function
    Function SUM_Discount(ByVal MODEL As MODEL_APP) As Object
        Dim dao_ml As New DAO_TABEAN.TB_MAS_PRICE_REQUEST_HERB
        dao_ml.Getdataby_Process_ID(MODEL.PROCESS_ID)
        Dim dao_p As New DAO_TABEAN.TB_MAS_PRICE_DISCOUNT_TABEAN_HERB
        dao_p.GetdatabyID_ID(MODEL.TABEAN_RENEW.Discount_RequestID)
        Dim number1 As Integer = 0
        Dim number2 As Integer = 0
        Dim number3 As Integer = 100
        Dim answer1 As Decimal
        Dim sum1 As Integer
        Dim sum2 As Integer
        If dao_p.fields.REQUEST_Fee = Nothing Then
            number2 = 0
        Else
            number2 = dao_p.fields.REQUEST_Fee
        End If
        number1 = dao_ml.fields.Price

        sum1 = number1 * number2
        sum2 = sum1 / number3
        answer1 = number1 - sum2
        Return answer1
    End Function
    Public Function UpdateDataStaffTabeanRenewConfirm(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        Dim mas_staff As New DAO_DRUG.TB_MAS_STAFF_NAME_HERB
        mas_staff.GetdatabyID_IDA(MODEL.STAFF_NAME_ID)
        Dim StatusID As Integer = MODEL.CONFIRM_STATUS_ID
        Dim SS_EDIT As Integer = MODEL.CONFIRM_STATUS_ID
        Dim TYPE_EDIT As Integer = 0
        Dim Status_Pass As Integer = 0
        Dim TR_ID As Integer = dao.fields.TR_ID
        If IsNothing(dao.fields.TYPE_EDIT_FILE) = False Then
            TYPE_EDIT = dao.fields.TYPE_EDIT_FILE
        End If
        If StatusID = 23 Then
            dao.fields.rcv_StaffID = MODEL.STAFF_NAME_ID
            dao.fields.rcv_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.RCVDATE = MODEL.DATE_CONNFIRM
            If MODEL.TABEAN_RENEW.STYPE_ID IsNot Nothing AndAlso MODEL.TABEAN_RENEW.STYPE_ID <> 0 Then
                dao.fields.STYPE_ID = MODEL.TABEAN_RENEW.STYPE_ID
                dao.fields.STYPE_NAME = MODEL.TABEAN_RENEW.STYPE_NAME
            End If
            If MODEL.TABEAN_RENEW.KIND_ID IsNot Nothing AndAlso MODEL.TABEAN_RENEW.KIND_ID <> 0 Then
                dao.fields.KIND_ID = MODEL.TABEAN_RENEW.KIND_ID
                dao.fields.KIND_NAME = MODEL.TABEAN_RENEW.KIND_NAME
            End If
            If MODEL.TABEAN_RENEW.SALE_CHANNEL_ID IsNot Nothing AndAlso MODEL.TABEAN_RENEW.SALE_CHANNEL_ID <> 0 Then
                dao.fields.SALE_CHANNEL_ID = MODEL.TABEAN_RENEW.SALE_CHANNEL_ID
                dao.fields.SALE_CHANNEL_NAME = MODEL.TABEAN_RENEW.SALE_CHANNEL_NAME
            End If
        ElseIf StatusID = 11 Or StatusID = 21 Then
            dao.fields.staff_edit_id = MODEL.STAFF_NAME_ID
            dao.fields.staff_edit_name = MODEL.STAFF_NAME_CONFIRM
            dao.fields.staff_edit_date = MODEL.DATE_CONNFIRM
            Dim Head_id As Integer = 99
            Dim dao_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE
            dao_mas.Getdataby_Head_ID_and_Process_id(Head_id, dao.fields.PROCESS_ID)
            Dim Forcible As Integer = dao_mas.fields.Forcible
            Dim dao_up As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
            If TYPE_EDIT > 0 Then
                dao_up.Getdataby_tr_id_and_type(TR_ID, 2)
                INSERT_HISTORY_FILE_UPLOAD_TABEAN_CENNTER(dao_up.fields.IDA, MODEL.CLS_SESSION.CITIZEN_ID)
                dao_up.fields.NAME_FAKE = ""
                dao_up.fields.NAME_REAL = ""
                dao_up.fields.Edit_Chk = 0
                dao_up.Update()
                dao.fields.Note_Edit_FileUpload = dao.fields.Note_Edit_FileUpload & " " & dao.fields.Note_Edit
                dao.fields.Note_Edit = ""
            Else
                dao_up.Getdataby_tr_id_process_and_doc_id(dao.fields.TR_ID, dao.fields.PROCESS_ID, dao_mas.fields.ID)
                dao_up.fields.Document_Name = dao_mas.fields.DocumentName
                dao_up.fields.Document_ID = dao_mas.fields.ID
                dao_up.fields.Forcible = Forcible
                dao_up.fields.FilePath = dao_mas.fields.PathFile
                dao_up.fields.TR_ID = dao.fields.TR_ID
                dao_up.fields.FK_IDA = dao.fields.IDA
                dao_up.fields.ProcessID = MODEL.PROCESS_ID
                dao_up.fields.TYPE = 2
                dao_up.fields.CREATE_DATE = DateTime.Now
                dao_up.fields.CitizenID = MODEL.CLS_SESSION.CITIZEN_ID
                dao_up.insert()
            End If
        ElseIf StatusID = 19 Then
            dao.fields.staff_edit_id2 = MODEL.STAFF_NAME_ID
            dao.fields.staff_edit_name2 = MODEL.STAFF_NAME_CONFIRM
            dao.fields.staff_edit_date2 = MODEL.DATE_CONNFIRM
        ElseIf StatusID = 6 Or StatusID = 63 Or StatusID = 62 Or StatusID = 61 Then
            dao.fields.CONSIDER_StaffID = MODEL.STAFF_NAME_ID
            dao.fields.CONSIDER_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.CONSIDER_DATE = MODEL.DATE_CONNFIRM
        ElseIf StatusID = 25 Then
            Dim CHK_FILE As String
            CHK_FILE = Check_File_Uploads(MODEL)
            If CHK_FILE <> "" Then Return MODEL.ALERT_MS
            dao.fields.Age = MODEL.TABEAN_RENEW.Age
            dao.fields.BSN_IDENTIFY = MODEL.TABEAN_RENEW.BSN_IDENTIFY
            dao.fields.BSN_NAME = MODEL.TABEAN_RENEW.BSN_NAME
            dao.fields.Email = MODEL.TABEAN_RENEW.Email
            'dao.fields.PhoneNumber = MODEL.TABEAN_RENEW.PhoneNumber
            dao.fields.Nation = MODEL.TABEAN_RENEW.Nation
            dao.fields.TYPE_EDIT_FILE = TYPE_EDIT + 1
        ElseIf StatusID = 5 Then
            'dao.fields.STAT = TYPE_EDIT + 1
        ElseIf StatusID = 31 OrElse StatusID = 32 Then
            dao.fields.staff_examine_id = MODEL.STAFF_NAME_ID
            dao.fields.staff_examine_nm = MODEL.STAFF_NAME_CONFIRM
            dao.fields.staff_examine_date = DateTime.UtcNow
            If StatusID = 32 Then
                If MODEL.TABEAN_RENEW.ML_ESTIMATE Is Nothing OrElse MODEL.TABEAN_RENEW.ML_ESTIMATE = 0 Then
                    dao.fields.ML_ESTIMATE = 0
                Else
                    dao.fields.ML_ESTIMATE = MODEL.TABEAN_RENEW.ML_ESTIMATE
                End If
            Else
                dao.fields.ML_ESTIMATE = MODEL.TABEAN_RENEW.ML_ESTIMATE
            End If
            If MODEL.TABEAN_RENEW.Discount_EstimateID IsNot Nothing AndAlso MODEL.TABEAN_RENEW.Discount_EstimateID <> 0 AndAlso Not String.IsNullOrEmpty(MODEL.TABEAN_RENEW.Discount_EstimateName) Then
                dao.fields.Discount_EstimateID = MODEL.TABEAN_RENEW.Discount_EstimateID
                dao.fields.Discount_EstimateName = MODEL.TABEAN_RENEW.Discount_EstimateName
            End If
            'dao.fields.Estimate_PAY_ID = MODEL.TABEAN_RENEW.Estimate_PAY_ID
            'dao.fields.Estimate_PAY_Name = MODEL.TABEAN_RENEW.Estimate_PAY_Name
            If MODEL.TABEAN_RENEW.Estimate_PAY_ID IsNot Nothing AndAlso MODEL.TABEAN_RENEW.Estimate_PAY_ID <> 0 AndAlso Not String.IsNullOrEmpty(MODEL.TABEAN_RENEW.Estimate_PAY_Name) Then
                dao.fields.Estimate_PAY_ID = MODEL.TABEAN_RENEW.Estimate_PAY_ID
                dao.fields.Estimate_PAY_Name = MODEL.TABEAN_RENEW.Estimate_PAY_Name
            End If
        ElseIf StatusID = 16 Then
            dao.fields.ESTIMATE_BY = MODEL.STAFF_NAME_ID
            dao.fields.ESTIMATE_NAME_BY = MODEL.STAFF_NAME_CONFIRM
            dao.fields.ESTIMATE_DATE = MODEL.DATE_CONNFIRM
        ElseIf StatusID = 22 Then
            Dim dao_log As New DAO_DRUG.TB_LOG_STATUS
            dao_log.GetDataby_STATUS_ID(MODEL.IDA, MODEL.PROCESS_ID, 31)
            If dao_log.fields.IDA = 0 Then dao_log.GetDataby_STATUS_ID(MODEL.IDA, MODEL.PROCESS_ID, 32)
            If dao_log.fields.IDA = 0 Then
                dao.fields.EDIT_STATUS = 1
            Else
                dao.fields.EDIT_STATUS = 2
            End If
            dao.fields.Note_Edit = MODEL.TABEAN_RENEW.Note_Edit
            dao.fields.Note_Edit2 = MODEL.TABEAN_RENEW.Note_Edit2
            dao.fields.Edit_Staff_File_Chk = MODEL.TABEAN_RENEW.Edit_Staff_File_Chk
            dao.fields.Edit_Staff_Chk = MODEL.TABEAN_RENEW.Edit_Staff_Chk
            dao.fields.Header_Edit_Location = MODEL.TABEAN_RENEW.Header_Edit_Location
            dao.fields.Header_Edit_Person = MODEL.TABEAN_RENEW.Header_Edit_Person
            'dao.fields.EDIT_STATUS = SS_EDIT
            Try
                Dim TYPE_ID As Integer = 0
                'If StatusID = 18 Then TYPE_ID = 3 Else TYPE_ID = 5
                Dim res_1 As Boolean
                Dim res_id As String = ""
                Dim P_ID As Double = 0
                For Each item In MODEL.FILE_ATTACH_EDIT
                    Try
                        item.TryGetValue("Edit_Chk", res_1)
                        item.TryGetValue("IDA", res_id)
                        If res_1 = True Then
                            INSERT_HISTORY_FILE_UPLOAD_TABEAN_CENNTER(res_id, MODEL.CLS_SESSION.CITIZEN_ID)
                            Dim dao_up As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
                            dao_up.GetdatabyID_IDA(GetItemsOb(item, "IDA"))
                            'dao_up.fields.Document_Name = GetItemsOb(item, "DUCUMENT_NAME")
                            dao_up.fields.NAME_FAKE = ""
                            dao_up.fields.NAME_REAL = ""
                            dao_up.fields.Edit_Chk = res_1
                            'dao_up.fields.TR_ID = MODEL.TR_ID
                            'dao_up.fields.FK_IDA = dao.fields.IDA
                            'dao_up.fields.ProcessID = MODEL.PROCESS_ID
                            dao_up.fields.EditTypeFile = TYPE_EDIT + 1
                            dao_up.fields.ACTIVE = 0
                            dao_up.Update()
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try
        ElseIf StatusID = 8 Then
            Dim date_expi As Date
            Dim date_expiyear As String
            Dim NEWCODE_U As String = dao.fields.Newcode_U
            Dim AuthorizeID As String = dao.fields.CITIZEN_ID_AUTHORIZE
            Dim dao_p As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
            dao_p.GetDataby_u1_frn_no(dao.fields.Newcode_U)
            dao.fields.appdate_StaffID = MODEL.STAFF_NAME_ID
            dao.fields.appdate_StaffName = MODEL.STAFF_NAME_CONFIRM
            dao.fields.appdate = MODEL.DATE_CONNFIRM
            dao.fields.Expdate_Before_Renew = dao_p.fields.expdate
            dao.fields.ExpYear_Before_Renew = dao.fields.Expdate_Before_Renew.Value.Year
            date_expi = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Year, 5, CDate(dao_p.fields.expdate)))
            date_expiyear = DateAdd(DateInterval.Year, 5, CDate(dao_p.fields.expdate)).Year
            dao.fields.Date_Extend = date_expi
            dao.fields.Year_Extend = date_expiyear
            dao_p.fields.expdate = date_expi
            dao_p.fields.lmdfdate = DateTime.Now
            If Not String.IsNullOrEmpty(dao.fields.STYPE_NAME) AndAlso dao.fields.STYPE_NAME <> "-- กรุณาเลือก --" Then
                dao_p.fields.thadsgnm = dao.fields.STYPE_NAME
            End If
            If Not String.IsNullOrEmpty(dao.fields.KIND_NAME) AndAlso dao.fields.KIND_NAME <> "-- กรุณาเลือก --" Then
                dao_p.fields.thakindnm = dao.fields.KIND_NAME
            End If
            If Not String.IsNullOrEmpty(dao.fields.SALE_CHANNEL_NAME) AndAlso dao.fields.SALE_CHANNEL_NAME <> "-- กรุณาเลือก --" Then
                dao_p.fields.sale_channel = dao.fields.SALE_CHANNEL_NAME
            End If
            dao_p.update()
            Dim dao_log As New DAO_DRUG.TB_LOG_RENEW_HERB
            dao_log.fields.citizen_id = MODEL.CLS_SESSION.CITIZEN_ID
            dao_log.fields.date_renew = DateTime.Now
            dao_log.fields.ExpDate_New = date_expi
            dao_log.fields.ExpYear_New = date_expiyear
            dao_log.fields.ExpDate_Old = dao_p.fields.expdate
            dao_log.fields.ExpYear_Old = dao.fields.Expdate_Before_Renew.Value.Year
            dao_log.fields.FK_IDA = MODEL.IDA
            dao_log.fields.PROCESS_ID = MODEL.PROCESS_ID
            dao_log.insert()
            Dim ws_drug As New WS_DRUG.WS_DRUG
            ws_drug.XML_DRUG_BC_UPDATE_TB(NEWCODE_U, AuthorizeID) 'อัพเดทข้อมูลผ่าน sevice
        ElseIf StatusID = 9 Or dao.fields.STATUS_ID = 7 Or dao.fields.STATUS_ID = 10 Then
            dao.fields.NOTE_CANCEL = MODEL.NOTE_STAFF
            Try
                dao.fields.DD_CANCEL_ID = MODEL.STAFF_NAME_ID
                dao.fields.DD_CANCEL_NM = MODEL.STAFF_NAME_CONFIRM
            Catch ex As Exception

            End Try
        End If
        dao.fields.STATUS_ID = StatusID
        dao.Update()
        AddLogStatus(dao.fields.STATUS_ID, dao.fields.PROCESS_ID, MODEL.CLS_SESSION.CITIZEN_ID, MODEL.STAFF_IDENTIFY, MODEL.CLS_SESSION.THANM, MODEL.STAFF_NAME_CONFIRM, MODEL.IDA)
        If StatusID = 32 Then
            Dim dao_n As New DAO_TABEAN.TB_TABEAN_RENEW
            dao_n.GetdatabyID_IDA(MODEL.IDA)
            If dao_n.fields.ML_ESTIMATE = 0 Then
                dao_n.fields.STATUS_ID = 41
                Status_Pass = 41
                dao_n.Update()
                AddLogStatus(Status_Pass, dao.fields.PROCESS_ID, MODEL.CLS_SESSION.CITIZEN_ID, MODEL.STAFF_IDENTIFY, MODEL.CLS_SESSION.THANM, MODEL.STAFF_NAME_CONFIRM, MODEL.IDA)
            End If
        End If
        If dao.fields.STATUS_ID = 31 Then
            Dim SW As New SW_HERB_PAYMENT.SW_LCN_EDIT_PAYMENT
            SW.INSERT_HERB_PAYMENT_CENTER_L44(dao.fields.CITIZEN_ID_AUTHORIZE, MODEL.IDA, MODEL.PROCESS_ID)
        End If
        If StatusID = 5 Then
            Dim bao As New PDF_VIEW
            bao.BIND_PDF_TABEAN(MODEL.IDA, MODEL.PROCESS_ID)
        End If
        If StatusID = 22 Then SendMailAndSMS(dao.fields.Appoinment_Phone, dao.fields.Appoinment_Email, MODEL.PROCESS_ID, StatusID, dao.fields.TR_ID)
        Return MODEL
    End Function
    Public Sub SendMailAndSMS(ByVal Phone As String, ByVal email As String, ByVal Process_ID As Integer, ByVal Status_ID As Integer, ByVal TR_ID As Integer)
        Dim title As String = ""
        Dim Send_ID As String = 0
        Dim Content As String = 0
        Dim Dao_S As New DAO_TABEAN.TB_Mas_Sending_Information_Customer
        Dao_S.Getdataby_Process_ID_And_Status_ID(Process_ID, Status_ID)
        Content = Dao_S.fields.Message_Detail & " " & TR_ID
        title = Dao_S.fields.Title
        Send_ID = Dao_S.fields.Sendind_CD
        Dim mm As New FDA_MAIL.FDA_MAIL
        Dim mcontent As New FDA_MAIL.Fields_Mail
        mcontent.EMAIL_CONTENT = Content
        mcontent.EMAIL_FROM = "fda_info@fda.moph.go.th"
        mcontent.EMAIL_PASS = "deeku181"
        mcontent.EMAIL_TILE = title
        mcontent.EMAIL_TO = email
        Dim smss As New FDA_SMS.FDA_SMS
        Dim smss_content As String = ""
        If Send_ID = 1 Then
            mm.SendMail(mcontent)
        ElseIf Send_ID = 2 Then
            smss.SEND_SMS(Phone, Content)
        ElseIf Send_ID = 3 Then
            mm.SendMail(mcontent)
            smss.SEND_SMS(Phone, Content)
        End If
    End Sub
    Public Sub SendMail(ByVal Content As String, ByVal email As String, ByVal title As String)
        Dim mm As New FDA_MAIL.FDA_MAIL
        Dim mcontent As New FDA_MAIL.Fields_Mail
        mcontent.EMAIL_CONTENT = Content
        mcontent.EMAIL_FROM = "fda_info@fda.moph.go.th"
        mcontent.EMAIL_PASS = "deeku181"
        mcontent.EMAIL_TILE = title
        mcontent.EMAIL_TO = email
        mm.SendMail(mcontent)
    End Sub

    Public Sub SendSMS(ByVal mobile As String, ByVal msg As String)
        Dim smss As New FDA_SMS.FDA_SMS
        Dim smss_content As String = ""
        smss.SEND_SMS(mobile, msg)
    End Sub

    Function GetItemsOb(ByVal Ob As Object, ByVal Value As String)
        Dim Result As String = ""
        Ob.TryGetValue(Value, Result)
        Return Result
    End Function
    Public Function GET_DATA_EDIT_STAFF(ByVal MODEL As MODEL_APP) As Object
        Dim PROCESS_ID As String = MODEL.PROCESS_ID
        If PROCESS_ID = 20710 Or PROCESS_ID = 20720 Or PROCESS_ID = 20730 Then
            Dim dao_renew As New DAO_TABEAN.TB_TABEAN_RENEW
            dao_renew.GetdatabyID_IDA(MODEL.IDA)
            MODEL.TABEAN_RENEW = dao_renew.fields
        End If
        Return MODEL
    End Function
    Public Function GET_FILE_UPLOAD_TABEAN_CENNTER(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim dt_up As New DataTable
        'dt_up = bao.SP_TABEAN_HERB_UPLOAD_FILE_CENTER(MODEL.TR_ID, 1, MODEL.PROCESS_ID)
        dt_up = bao.SP_TABEAN_UPLOAD_FILE_CENTER(MODEL.TR_ID, MODEL.PROCESS_ID)
        Dim index As Integer = 0
        dt_up.Columns.Add("index")
        For Each item As DataRow In dt_up.Rows
            index += 1
            item("index") = index
        Next
        MODEL.FILEUPLOADTABLE = DataTableToJSON(dt_up)
        MODEL.FILE_ATTACH_EDIT = DataTableToJSON(dt_up)
        Return MODEL
    End Function
    Public Sub INSERT_HISTORY_FILE_UPLOAD_TABEAN_CENNTER(ByVal ID As Integer, ByVal Citizen_ID As String)
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_UPLOADFILE_HIS
        Dim dao_m As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
        dao_m.GetdatabyID_IDA(ID)
        Dim Forcible As Integer
        With dao.fields
            .IDA = dao_m.fields.IDA
            .ACTIVE = dao_m.fields.ACTIVE
            .CREATE_DATE = dao_m.fields.CREATE_DATE
            .Update_Date = dao_m.fields.Update_Date
            .CitizenID = dao_m.fields.CitizenID
            .CitizenUpdateID = dao_m.fields.CitizenUpdateID
            .Document_ID = dao_m.fields.Document_ID
            .Document_Name = dao_m.fields.Document_Name
            .EditTypeFile = dao_m.fields.EditTypeFile
            .Edit_Chk = dao_m.fields.Edit_Chk
            .FK_IDA = dao_m.fields.FK_IDA
            .Forcible = Forcible = dao_m.fields.Forcible
            .NAME_FAKE = dao_m.fields.NAME_FAKE
            .NAME_REAL = dao_m.fields.NAME_REAL
            .TR_ID = dao_m.fields.TR_ID
            .TYPE = dao_m.fields.TYPE
            .ProcessID = dao_m.fields.ProcessID
            .FilePath = dao_m.fields.FilePath
            .Edit_Date = DateTime.UtcNow
            .Edit_ID = Citizen_ID
        End With
        dao.insert()
    End Sub
    Public Function GET_FILE_UPLOAD_TABEAN_EDIT_CENNTER(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim dt_up As New DataTable
        Dim dt_e As New DataTable
        Dim dt_s As New DataTable
        'If IsNothing(MODEL.TYPE_ID) = True Then MODEL.TYPE_ID = 0
        If MODEL.TYPE_ID = 0 Then MODEL.TYPE_ID = 1
        dt_up = bao.SP_TABEAN_UPLOAD_FILE_CENTER(MODEL.TR_ID, MODEL.PROCESS_ID)
        dt_e = bao.SP_TABEAN_UPLOAD_FILE_EDIT_CENTER(MODEL.TR_ID, MODEL.TYPE_EDIT, MODEL.PROCESS_ID)
        dt_s = bao.SP_TABEAN_UPLOAD_FILE_EDIT_STAFF_CENTER(MODEL.TR_ID, MODEL.TYPE_EDIT, MODEL.PROCESS_ID)
        Dim index As Integer = 0
        dt_up.Columns.Add("index")
        For Each item As DataRow In dt_up.Rows
            index += 1
            item("index") = index
        Next
        MODEL.FILEUPLOADTABLE = DataTableToJSON(dt_up)
        MODEL.FILE_ATTACH = DataTableToJSON(dt_up)
        MODEL.FILE_ATTACH_EDIT = DataTableToJSON(dt_up)
        MODEL.FILE_ATTACH_STAFF = DataTableToJSON(dt_s)
        Return MODEL
    End Function
    Public Function GET_EDIT_FILE_STAFF_UPLOAD(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim dt_up As New DataTable
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE_JJ
        Dim dao_up_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE_JJ
        Dim TYPE_ID As Integer = 0
        If MODEL.STATUS_ID = 11 Then TYPE_ID = 2 Else TYPE_ID = 4
        dao.GetdatabyID_TR_ID_FK_IDA_PROCESS_ID_AND_TYPE(MODEL.IDA, MODEL.TR_ID, MODEL.PROCESS_ID, TYPE_ID)
        If dao.fields.IDA = 0 Then
            dao_up_mas.GetdatabyID_TYPE(710)
            For Each dao_up_mas.fields In dao_up_mas.datas
                Dim dao_up As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE_JJ
                dao_up.fields.DUCUMENT_NAME = dao_up_mas.fields.DUCUMENT_NAME
                dao_up.fields.TR_ID = MODEL.TR_ID
                dao_up.fields.PROCESS_ID = MODEL.PROCESS_ID
                dao_up.fields.FK_IDA = MODEL.IDA
                dao_up.fields.FK_IDA_LCN = MODEL.IDA_LCN
                dao_up.fields.TYPE = TYPE_ID
                dao_up.insert()
            Next
        End If

        dt_up = bao.SP_TABEAN_HERB_UPLOAD_FILE_CENTER(MODEL.TR_ID, TYPE_ID, MODEL.PROCESS_ID)
        Dim index As Integer = 0
        dt_up.Columns.Add("index")
        For Each item As DataRow In dt_up.Rows
            index += 1
            item("index") = index
        Next
        MODEL.FILEUPLOADTABLE = DataTableToJSON(dt_up)
        Return MODEL
    End Function
    Public Function GET_EDIT_FILE_STAFF_UPLOAD_USER(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim dt_up As New DataTable
        Dim dt_e As New DataTable
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        Try
            If dao.fields.TYPE_EDIT_FILE Is Nothing OrElse dao.fields.TYPE_EDIT_FILE = 0 Then
                dao.fields.TYPE_EDIT_FILE = 0
            End If
            MODEL.TYPE_EDIT = dao.fields.TYPE_EDIT_FILE + 1
        Catch ex As Exception
            MODEL.TYPE_EDIT = 0
        End Try

        dt_e = bao.SP_TABEAN_UPLOAD_FILE_EDIT_STAFF_CENTER(MODEL.TR_ID, 2, MODEL.PROCESS_ID)
        dt_up = bao.SP_TABEAN_UPLOAD_FILE_EDIT_CENTER(MODEL.TR_ID, MODEL.TYPE_EDIT, MODEL.PROCESS_ID)
        Dim index As Integer = 0
        dt_up.Columns.Add("index")
        For Each item As DataRow In dt_up.Rows
            index += 1
            item("index") = index
        Next
        'MODEL.TABEAN_RENEW = dao.fields
        MODEL.FILE_ATTACH_STAFF = DataTableToJSON(dt_e)
        MODEL.FILEUPLOADTABLE = DataTableToJSON(dt_up)
        Return MODEL
    End Function
    Public Function Binddata_Tabean_Substitute_Saff(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        dt = bao.SP_TABEAN_HERB_SUBNEW_STAFF_BY_PROCESS(MODEL.PROCESS_ID)
        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        MODEL.Substitute_Tabean_Staff = DataTableToJSON(dt)
        Return MODEL
    End Function
    Public Function Binddata_Tabean_Renew_Detail(ByVal MODEL As MODEL_APP) As Object
        Dim dt_status As New DataTable
        Dim dt_staff As New DataTable
        MODEL.ddl_status_staff = bind_ddl_mas_Renew_status(MODEL)
        MODEL.ddl_staff_name = bind_ddl_mas_staff(MODEL)
        MODEL.FILE_ATTACH = GET_FILE_UPLOAD_EDIT(MODEL)
        MODEL.ddl_CancelRequest = Get_ddl_Cancel_Tabean(MODEL)
        Return MODEL
    End Function
    Public Function Binddata_Tabean_Renew_Detail_Saff(ByVal MODEL As MODEL_APP) As Object
        Dim dt_status As New DataTable
        Dim dt_staff As New DataTable
        'MODEL.ddl_status = bind_ddl_status(MODEL)
        MODEL.ddl_status_staff = bind_ddl_mas_Renew_status(MODEL)
        MODEL.ddl_discount = SP_MAS_PRICE_DISCOUNT_TABEAN_HERB(MODEL)
        MODEL.ddl_price = SP_MAS_PRICE_ESTIMATE_REQUEST_TABEAN_HERB(MODEL)
        MODEL.ddl_sale_channel = SP_MAS_SALE_CHANALE_TABEAN(MODEL)
        MODEL.ddl_stype = SP_MAS_TABEAN_HERB_STYPE(MODEL)
        MODEL.ddl_kind_tabean = SP_MAS_KIND_TABEAN(MODEL)
        MODEL.ddl_staff_name = bind_ddl_mas_staff(MODEL)
        'MODEL.FILE_ATTACH = GET_FILE_UPLOAD_EDIT(MODEL)
        'MODEL.FILE_ATTACH_EDIT = GET_FILE_UPLOAD_EDIT(MODEL)
        MODEL.Log_Status = GetDataLog_Status(MODEL)

        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        If dao.fields.STATUS_ID = 8 Then
            MODEL.TABEAN_RENEW.appdate_StaffName = dao.fields.appdate_StaffName
            MODEL.DATE_CONNFIRM = dao.fields.appdate
        End If
        Return MODEL
    End Function
    Public Function Binddata_Tabean_Renew_Saff(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        dt = bao.SP_TABEAN_RENEW_STAFF()
        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        MODEL.Renew_Tabean_Staff = DataTableToJSON(dt)
        MODEL.ddl_status = bind_ddl_status(MODEL)
        Return MODEL
    End Function
    Public Function GetDataStaffConfirm(ByVal MODEL As MODEL_APP) As Object
        Dim dt_status As New DataTable
        Dim dt_staff As New DataTable
        MODEL.ddl_status_staff = bind_ddl_mas_substitute_status(MODEL)
        MODEL.ddl_staff_name = bind_ddl_mas_staff(MODEL)
        MODEL.FILE_ATTACH = GET_FILE_UPLOAD_EDIT(MODEL)
        MODEL.ddl_CancelRequest = Get_ddl_Cancel_Tabean(MODEL)
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(MODEL.IDA)
        If dao.fields.STATUS_ID = 8 Then
            MODEL.TABEAN_HERB_SUBSTITUTE.appdate_StaffName = dao.fields.appdate_StaffName
            MODEL.DATE_CONNFIRM = dao.fields.appdate
        End If
        Return MODEL
    End Function
    Public Function GetDataCustomerConfirm(ByVal MODEL As MODEL_APP) As Object
        Dim dt_status As New DataTable
        Dim dt_staff As New DataTable
        'MODEL.ddl_status_staff = bind_ddl_mas_substitute_status(MODEL)
        'MODEL.ddl_staff_name = bind_ddl_mas_staff(MODEL)
        MODEL.FILE_ATTACH = GET_FILE_UPLOAD_EDIT(MODEL)
        MODEL.ddl_CancelRequest = Get_ddl_Cancel_Tabean(MODEL)
        Return MODEL
    End Function
    Public Function GetDataDDL_Discount(ByVal MODEL As MODEL_APP) As Object
        Dim dt_discount As New DataTable
        dt_discount = SP_MAS_PRICE_DISCOUNT_DALCN_HERB(MODEL)
        MODEL.ddl_discount = DataTableToJSON(dt_discount)
        MODEL.FILE_ATTACH = GET_FILE_UPLOAD_EDIT(MODEL)
        Return MODEL
    End Function
    Public Function GetDataDDL_Type_Request(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim dao As New DAO_TABEAN.TB_MAS_PRICE_REQUEST_HERB
        dao.Getdataby_Process_ID_AD(MODEL.PROCESS_ID)
        MODEL.ddl_Type_Tabean = dao.Details
        Return MODEL.ddl_Type_Tabean
    End Function
    Public Function GetDataDDL_Type_Estimate(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim dao As New DAO_TABEAN.TB_MAS_PRICE_ESTIMATE_REQUEST_HERB
        dao.GetData_By_PROCESS_ID(MODEL.PROCESS_ID)
        MODEL.ddl_price = dao.Details
        Return MODEL.ddl_price
    End Function
    Function SP_MAS_PRICE_DISCOUNT_DALCN_HERB(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        Dim dt As DataTable = bao.SP_MAS_PRICE_DISCOUNT_DALCN_HERB()
        Return dt
    End Function
    Function SP_MAS_PRICE_DISCOUNT_TABEAN_HERB(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        'Dim dt As DataTable = bao.SP_MAS_PRICE_DISCOUNT_TABEAN_HERB()
        Dim dt As DataTable = bao.SP_MAS_PRICE_DISCOUNT_TABEAN_HERB_BY_PROCESS(MODEL.PROCESS_ID)
        Return DataTableToJSON(dt)
    End Function
    Function SP_MAS_PRICE_ESTIMATE_REQUEST_TABEAN_HERB(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        Dim dt As DataTable = bao.SP_DD_PRICE_ESTIMATE_REQUEST(MODEL.PROCESS_ID)
        Return DataTableToJSON(dt)
    End Function
    Function SP_MAS_SALE_CHANALE_TABEAN(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        Dim dt As DataTable = bao.SP_MAS_TABEAN_HERB_SALE()
        Return DataTableToJSON(dt)
    End Function
    Function SP_MAS_TABEAN_HERB_STYPE(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        Dim dt As DataTable
        dt = bao.SP_DD_MAS_TABEAN_HERB_STYPE()
        Return DataTableToJSON(dt)
    End Function
    Function SP_MAS_KIND_TABEAN(ByVal MODEL As MODEL_APP)
        Dim dao As New DAO_TABEAN.TB_drkdofdrg
        dao.GETDATA_ACTIVE_Y()
        Return dao.Details
    End Function
    Public Function SEARCH_NAME_BY_IDEN(ByVal MODEL As MODEL_APP) As Object
        Dim CITIZEN_ID_AUTHORIZE As String = ""
        Try
            CITIZEN_ID_AUTHORIZE = MODEL.CITIZEN_AUTHORIZE
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
            MODEL.NAME = NAME
            MODEL.PERASON_TYPE = TYPE_PERSON
        Catch ex As Exception

        End Try
        Return MODEL
    End Function
    Function ConvertFromXml(Of T As Class)(ByRef str As String) As T


        Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))


        Dim reader As StringReader = New StringReader(str)


        Dim c As T = TryCast(serializer.Deserialize(reader), T)


        Return c

    End Function
    Public Function bind_ddl_mas_substitute_status(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim int_group_ddl1 As Integer = 0
        Dim int_group_ddl2 As Integer = 0
        Dim status_id1 As Integer = 0
        Dim dao_sub As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao_sub.GetdatabyID_IDA(MODEL.IDA)

        status_id1 = dao_sub.fields.STATUS_ID
        If status_id1 = 2 Then
            int_group_ddl1 = 1
            int_group_ddl2 = 0
        ElseIf status_id1 = 3 Then
            int_group_ddl1 = 2
            int_group_ddl2 = 0
        ElseIf status_id1 = 4 Then
            int_group_ddl1 = 3
            int_group_ddl2 = 0
        End If
        dt = bao.Get_DDL_DATA(12, int_group_ddl1, int_group_ddl2)
        MODEL.ddl_status_staff = DataTableToJSON(dt)
        Return MODEL.ddl_status_staff
    End Function

    Public Function bind_ddl_status(ByVal MODEL As MODEL_APP) As Object
        Dim dao_mas As New DAO_TABEAN.TB_MAS_TYPE_REQUESTS_HERB
        dao_mas.GetData_By_PROCESS_ID(MODEL.PROCESS_ID)
        Dim StatGroup As String = dao_mas.fields.Status_Group
        Dim dao As New DAO_TABEAN.TB_MAS_STATUS
        dao.Getdataby_StatGroup_Staff(StatGroup)
        MODEL.ddl_status = dao.Details
        Return MODEL.ddl_status
    End Function
    Public Function bind_ddl_mas_Renew_status(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim int_group_ddl1 As Integer = 0
        Dim int_group_ddl2 As Integer = 0
        Dim status_id1 As Integer = 0
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(MODEL.IDA)
        Dim dao_mas As New DAO_TABEAN.TB_MAS_TYPE_REQUESTS_HERB
        dao_mas.GetData_By_PROCESS_ID(MODEL.PROCESS_ID)
        Dim ss_id As Integer = 0
        Dim ss_id2 As Integer = 0
        Dim ss_edit As Integer = 0
        Dim STID As Integer = dao.fields.STATUS_ID
        If IsNothing(dao.fields.EDIT_STATUS) = True Then ss_edit = 0 Else ss_edit = dao.fields.EDIT_STATUS
        Dim STGroup As Integer
        Dim Edit_TYPE As Integer = 0
        If IsNothing(dao.fields.TYPE_EDIT_FILE) = False Then
            Edit_TYPE = dao.fields.TYPE_EDIT_FILE
        End If
        Try
            STGroup = dao_mas.fields.Status_Group
        Catch ex As Exception
            STGroup = 207
        End Try
        If (STID = 25 And ss_edit = 1) Then
            ss_id = 1
            'ss_id2 = 2
        ElseIf (STID = 4) Then
            ss_id = 1
            ss_id2 = 2
            'ElseIf (STID = 25 And Edit_TYPE >= 1) Then
        ElseIf (STID = 25 And ss_edit = 2) Then
            ss_id = 2
            ss_id2 = 3
        ElseIf STID = 4 Or STID = 32 Or STID = 42 Or STID = 5 Then
            ss_id = 2
            ss_id2 = 3
        ElseIf STID = 23 Or STID = 61 Or STID = 62 Then
            'ss_id = 2
            ss_id2 = 4
        ElseIf STID = 6 Then
            ss_id = 5
        End If

        dt = bao.SP_MAS_STATUS_STAFF_BY_GROUP_DDL_V2(STGroup, 0, ss_id, ss_id2)
        MODEL.ddl_status_staff = DataTableToJSON(dt)
        Return MODEL.ddl_status_staff
    End Function
    Public Function bind_ddl_mas_staff(ByVal MODEL As MODEL_APP) As Object
        Dim dt As DataTable
        Dim bao As New BAO.BAO
        dt = bao.SP_MAS_STAFF_NAME_HERB()
        MODEL.ddl_staff_name = DataTableToJSON(dt)
        Return MODEL.ddl_staff_name
    End Function
    Function Get_ddl_Cancel_Tabean(ByVal model As MODEL_APP)
        Dim dt As DataTable
        Dim bao As New BAO.BAO
        dt = bao.SP_MAS_STATUS_CANCEL_TABEAN_HERB(3)
        model.ddl_CancelRequest = DataTableToJSON(dt)
        Return model.ddl_CancelRequest
    End Function
    Function GetDataLog_Status(ByVal model As MODEL_APP)
        Dim dt As DataTable
        Dim bao As New BAO.BAO
        dt = bao.SP_LOG_STATUS(model.IDA, model.PROCESS_ID)
        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        model.Log_Status = DataTableToJSON(dt)
        Return model.Log_Status
    End Function
    Public Function GET_FILE_UPLOAD_EDIT(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        'Dim YEAR_S As String = ""
        'Dim TR_ID As String = ""
        'Dim dao_up_get As New DAO_LCN.TB_LCN_APPROVE_EDIT_UPLOAD_FILE
        'dao_up_get.GetDataby_TR_ID(MODEL.TR_ID)
        'MODEL.FILE_ATTACH = dao_up_get.fields

        Dim dt_up As New DataTable
        dt_up = bao.SP_TABEAN_HERB_UPLOAD_FILE_JJ(MODEL.TR_ID, 1, MODEL.PROCESS_ID, MODEL.IDA)
        Dim index As Integer = 0
        dt_up.Columns.Add("index")
        dt_up.Columns.Add("VALUVE")
        For Each item As DataRow In dt_up.Rows
            index += 1
            item("index") = index
            item("VALUVE") = index
        Next
        Return DataTableToJSON(dt_up)
    End Function
    Public Function Binddata_Tabean_BY_PROCESS_ID(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        Dim Citizen_ID As String = ""
        If MODEL.STAFF_ID = 1 Then
            Citizen_ID = MODEL.CITIZEN_AUTHORIZE
        Else
            Citizen_ID = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
        End If
        If MODEL.PROCESS_ID = 20610 Or MODEL.PROCESS_ID = 20710 Then
            'dt = bao.SP_XML_TABEAN_HERB_BY_IDEN_DRRQT(Citizen_ID, MODEL.IDA_LCN)
            'dt = bao.SP_XML_TABEAN_HERB_BY_IDEN_124(Citizen_ID, 0)
            dt = bao.SP_XML_TABEAN_HERB_BY_IDEN_124_RENEW(Citizen_ID, 0)
        ElseIf MODEL.PROCESS_ID = 20620 Or MODEL.PROCESS_ID = 20720 Then
            dt = bao.SP_XML_TABEAN_HERB_BY_IDEN_DRRQT(Citizen_ID, MODEL.IDA_LCN)
        ElseIf MODEL.PROCESS_ID = 20630 Or MODEL.PROCESS_ID = 20730 Then
            dt = bao.SP_XML_TABEAN_HERB_BY_IDEN_124(Citizen_ID, MODEL.IDA_LCN)
        End If

        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        MODEL.Tabean_Herb = DataTableToJSON(dt)
        Return MODEL
    End Function
    Public Function Binddata_Tabean_Renew_BY_PROCESS_ID(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        'Dim dao As New DAO_LCN
        Dim Citizen_ID As String = ""
        If MODEL.STAFF_ID = 1 Then
            Citizen_ID = MODEL.CITIZEN_AUTHORIZE
        Else
            Citizen_ID = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
        End If
        'Dim DAO_WHO As New DAO_LCN.TB_WHO_DALCN
        'DAO_WHO.GetdatabyID_FK_LCN(MODEL.IDA_LCN)
        If MODEL.PROCESS_ID.Contains("2071") Or MODEL.PROCESS_ID.Contains("1400001") Then
            dt = bao.SP_TABEAN_RENEW_TBN_CUSTOMER(Citizen_ID, MODEL.IDA_DR)
        ElseIf MODEL.PROCESS_ID.Contains("2073") Then
            dt = bao.SP_TABEAN_RENEW_JJ_CUSTOMER(Citizen_ID, MODEL.IDA_DR)
        End If
        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next
        MODEL.Renew_Tabean = DataTableToJSON(dt)
        Return MODEL
    End Function
    Public Function Binddata_lcn_edit(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim bao As New BAO.BAO
        dt = bao.SP_LCN_APPROVE_EDIT_GET_DATA(MODEL.IDA_LCN, 2)

        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next
        Return DataTableToJSON(dt)
    End Function
    Public Function SEARCH_LCN_LOCATION(ByVal MODEL As MODEL_APP) As Object
        Dim LCN_SEARCH As String = MODEL.TABEAN_RENEW.LCNNO_NEW
        Dim dao_lcn As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
        dao_lcn.GetDataby_lcnno_no_New(LCN_SEARCH)
        Dim dao_licen As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_LICEN_HERB
        dao_licen.GetDataby_u1(dao_lcn.fields.Newcode_not)

        MODEL.XML_SEARCH_DRUG_LCN_HERB = dao_lcn.fields
        MODEL.XML_SEARCH_DRUG_LCN_LICEN_HERB = dao_licen.fields
        Return MODEL
    End Function
    Public Function Check_File_Uploads(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
        dao.Getdataby_tr_id_and_t(MODEL.TR_ID, 1)
        Dim Count_con As Integer = 0
        Dim Count_con2 As Integer = 0
        Dim Con_Detail As String = 0
        For Each dao.fields In dao.datas
            Dim dao_m As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE
            dao_m.GetdatabyID_ID(dao.fields.Document_ID)
            Dim Condition As String = dao_m.fields.Condition
            If Condition = "Y" And dao_m.fields.Detail = "อย่างน้อยต้องแนบข้อ 6 หรือข้อ 7 หนึ่งไฟล์ " Then
                If dao.fields.ACTIVE = True Then Count_con += 1
                Con_Detail = "นำเข้า"
            ElseIf Condition = "Y" And dao_m.fields.Detail = "อย่างน้อยต้องแนบข้อ 8,9 หรือข้อ 10 หนึ่งไฟล์ " Then
                If dao.fields.ACTIVE = True Then Count_con2 += 1
                Con_Detail = "นำเข้า"
            Else
                If dao.fields.Forcible = True And (dao.fields.ACTIVE Is Nothing Or dao.fields.ACTIVE = False) Then
                    MODEL.ALERT_MS = "กรุณาแนบไฟล์ให้ครบถ้วน"
                    Return MODEL.ALERT_MS
                End If
            End If
        Next
        If Con_Detail = "นำเข้า" Then
            If Count_con >= 1 And Count_con2 >= 1 Then
                Return MODEL.ALERT_MS
            Else
                MODEL.ALERT_MS = "กรุณาแนบไฟล์ให้ครบถ้วน"
                Return MODEL.ALERT_MS
            End If
        End If
        Return MODEL.ALERT_MS
    End Function
    Public Function GET_DATA_TABEAN_HERB_RENEW(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim dao_r As New DAO_TABEAN.TB_TABEAN_RENEW
        dao_r.GetdatabyID_IDA(MODEL.IDA)
        MODEL.TABEAN_RENEW = dao_r.fields
        Dim dao As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
        dao.GetDataby_u1(MODEL.Newcode)
        Dim dao_lcn As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_HERB
        dao_lcn.GetDataby_u1(dao.fields.Newcode_not)
        Dim dao_licen As New DAO_XML_DRUG_HERB.TB_XML_SEARCH_DRUG_LCN_LICEN_HERB
        dao_licen.GetDataby_u1(dao.fields.Newcode_not)
        Dim IDA_LCN As Integer = 0
        Dim THANM_CENTER As String = ""
        Dim Nation As String = ""
        Dim BirthDate As Date
        Dim Age_Person As Integer
        Try
            IDA_LCN = dao_lcn.fields.IDA_dalcn
            MODEL.IDA_LCN = IDA_LCN
        Catch ex As Exception
            IDA_LCN = 0
            MODEL.IDA_LCN = IDA_LCN
        End Try
        Dim dao_bsn As New DAO_LCN.TB_DALCN_LOCATION_BSN
        dao_bsn.GetDataby_LCN_IDA(IDA_LCN)
        Dim TYPE_ID As Integer = 0
        Dim CITIZEN_ID As String = dao.fields.CITIZEN_AUTHORIZE
        Dim ws_center As New WS_DATA_CENTER.WS_DATA_CENTER
        Dim obj As New XML_DATA
        Dim result As String = ""
        result = ws_center.GET_DATA_IDENTIFY(CITIZEN_ID, CITIZEN_ID, "FUSION", "P@ssw0rdfusion440")
        obj = ConvertFromXml(Of XML_DATA)(result)
        Dim TYPE_PERSON_CENTER As Integer = 0
        Try
            BirthDate = obj.SYSLCNSIDs.birthdate
            'If BirthDate.Year < 2560 Then con_year(BirthDate.Year)
            Dim thaiCalendar As New ThaiBuddhistCalendar()
            Dim currentThaiYear As Integer = thaiCalendar.GetYear(DateTime.Now)
            ' ปีเกิดที่เป็น พ.ศ. (ตัวอย่างเช่น 2560)
            Dim birthYearThai As Integer = thaiCalendar.GetYear(BirthDate)
            ' คำนวณอายุ
            If birthYearThai > currentThaiYear Then
                If birthYearThai > 3000 Then
                    birthYearThai = birthYearThai - 543
                End If
            End If
            Dim ageThai As Integer
            If currentThaiYear > birthYearThai Then ageThai = currentThaiYear - birthYearThai Else ageThai = birthYearThai - currentThaiYear
            If ageThai > 120 Then ageThai = ageThai - 543
            TYPE_PERSON_CENTER = obj.SYSLCNSIDs.type
            If TYPE_PERSON_CENTER = 1 Then
                TYPE_PERSON_CENTER = 1
                MODEL.TABEAN_RENEW.LCN_NAME = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
                Age_Person = ageThai
                MODEL.TABEAN_RENEW.Age = Age_Person
                If IsNothing(obj.SYSLCNSIDs.nation) = True Then
                    Nation = "ไทย"
                Else
                    Nation = obj.SYSLCNSIDs.nation
                End If
            Else
                TYPE_PERSON_CENTER = 2
                MODEL.TABEAN_RENEW.LCN_NAME = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
            End If
        Catch ex As Exception
            TYPE_PERSON_CENTER = 0
        End Try
        Dim BSN_IDENTIFY As String = dao_bsn.fields.BSN_IDENTIFY
        result = ws_center.GET_DATA_IDENTIFY(BSN_IDENTIFY, BSN_IDENTIFY, "FUSION", "P@ssw0rdfusion440")
        obj = ConvertFromXml(Of XML_DATA)(result)
        Try
            If TYPE_PERSON_CENTER = 2 Then
                BirthDate = obj.SYSLCNSIDs.birthdate
                'If BirthDate.Year < 2560 Then con_year(BirthDate.Year)
                Dim thaiCalendar As New ThaiBuddhistCalendar()
                Dim currentThaiYear As Integer = thaiCalendar.GetYear(DateTime.Now)
                ' ปีเกิดที่เป็น พ.ศ. (ตัวอย่างเช่น 2560)
                Dim birthYearThai As Integer = thaiCalendar.GetYear(BirthDate)
                ' คำนวณอายุ
                Dim ageThai As Integer = currentThaiYear - birthYearThai
                If ageThai < 0 Then
                    ageThai += 543
                End If
                Age_Person = ageThai
                MODEL.TABEAN_RENEW.Age = Age_Person
                If IsNothing(obj.SYSLCNSIDs.nation) = True Then
                    Nation = "ไทย"
                Else
                    Nation = obj.SYSLCNSIDs.nation
                End If
            End If
            MODEL.TABEAN_RENEW.Nation = Nation
            MODEL.TABEAN_RENEW.BSN_IDENTIFY = BSN_IDENTIFY
            MODEL.TABEAN_RENEW.BSN_PREFIX_CD = obj.SYSLCNSNMs.prefixcd
            MODEL.TABEAN_RENEW.BSN_PREFIX_NM = obj.SYSLCNSNMs.prefixnm
            MODEL.TABEAN_RENEW.BSN_NAME = obj.SYSLCNSNMs.thanm
            MODEL.TABEAN_RENEW.BSN_LNAME = obj.SYSLCNSNMs.thalnm
            MODEL.TABEAN_RENEW.BSN_FULLNAME_TH = obj.SYSLCNSNMs.prefixnm & " " & obj.SYSLCNSNMs.thanm & " " & obj.SYSLCNSNMs.thalnm
        Catch ex As Exception

        End Try
        MODEL.TABEAN_RENEW.RGTNO_FULL = dao.fields.register
        MODEL.TABEAN_RENEW.rgtno = dao.fields.rgtno
        MODEL.TABEAN_RENEW.drgtpcd = dao.fields.drgtpcd
        MODEL.TABEAN_RENEW.rgttpcd = dao.fields.rgttpcd
        MODEL.TABEAN_RENEW.pvncd = dao.fields.pvncd
        MODEL.TABEAN_RENEW.lpvncd = dao_lcn.fields.pvncd
        MODEL.TABEAN_RENEW.LCNNO = dao_lcn.fields.lcnno
        MODEL.TABEAN_RENEW.LCNNO_DISPLAY_NEW = dao_lcn.fields.lcnno_display_new
        MODEL.TABEAN_RENEW.Register = dao.fields.register
        MODEL.TABEAN_RENEW.Newcode_Not = dao.fields.Newcode_not
        MODEL.TABEAN_RENEW.Newcode_U = dao.fields.Newcode_U
        MODEL.TABEAN_RENEW.Holder_Name = dao.fields.holder_name
        MODEL.TABEAN_RENEW.Holder_Iden = dao.fields.holder_identify
        MODEL.TABEAN_RENEW.Holder_Addr = dao.fields.addr_who
        MODEL.TABEAN_RENEW.thadrgnm = dao.fields.thadrgnm
        MODEL.TABEAN_RENEW.engdrgnm = dao.fields.engdrgnm
        MODEL.TABEAN_RENEW.lcntpcd = dao.fields.lcntpcd
        MODEL.TABEAN_RENEW.TYPE_PERSON = TYPE_PERSON_CENTER
        MODEL.XML_DRUG_PRODUCT_HERB = dao.fields
        MODEL.XML_SEARCH_DRUG_LCN_HERB = dao_lcn.fields
        MODEL.XML_SEARCH_DRUG_LCN_LICEN_HERB = dao_licen.fields
        MODEL.ddl_prefix = DataTableToJSON(bind_ddl_prefix(MODEL))
        Return MODEL
    End Function
    Function bind_ddl_prefix(ByVal MODEL As MODEL_APP)
        Dim bao As New BAO.BAO
        Dim dt As DataTable = bao.SP_SYSPREFIX_DDL()
        Return dt
    End Function
    Public Function Binddata_DALCN(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim clsds As New BAO.BAO
        Dim dao As New DAO_LCN.TB_dalcn
        dao.GetDataby_IDA(MODEL.IDA_LCN)
        MODEL.dalcn = dao.fields
        Return MODEL.dalcn
    End Function
    Public Function Binddata_PHR(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_LCN.TB_DALCN_PHR
        dao.GetDataby_FK_IDA(MODEL.IDA_LCN)
        MODEL.DALCN_PHR = dao.fields
        Return MODEL.DALCN_PHR
    End Function
    Public Function Binddata_BSN(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_LCN.TB_DALCN_LOCATION_BSN
        dao.GetDataby_LCN_IDA(MODEL.IDA_LCN)
        MODEL.DALCN_LOCATION_BSN = dao.fields
        Return MODEL.DALCN_LOCATION_BSN
    End Function
    Public Function Binddata_LOCATION_ADDRESS(ByVal MODEL As MODEL_APP) As Object
        Dim dao_lcn As New DAO_LCN.TB_dalcn
        dao_lcn.GetDataby_IDA(MODEL.IDA_LCN)
        Dim dao As New DAO_LCN.TB_DALCN_LOCATION_ADDRESS
        Try
            dao.GetDataby_IDA(dao_lcn.fields.FK_IDA)
        Catch ex As Exception

        End Try
        MODEL.DALCN_LOCATION_ADDRESS = dao.fields
        Return MODEL.DALCN_LOCATION_ADDRESS
    End Function
    Public Function Binddata_lcn_addr(ByVal MODEL As MODEL_APP) As Object
        Dim bao As New BAO.BAO
        Dim dt As New DataTable
        If MODEL.STAFF_ID = 1 Then
            dt = bao.SP_Lisense_Name_and_Addr(MODEL.CITIZEN_AUTHORIZE) ' bao_show.SP_LOCATION_BSN_BY_LCN_IDA(_IDA) 'ผู้ดำเนิน
        Else
            dt = bao.SP_Lisense_Name_and_Addr(MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE) ' bao_show.SP_LOCATION_BSN_BY_LCN_IDA(_IDA) 'ผู้ดำเนิน
        End If

        Dim index As Integer = 0
        dt.Columns.Add("index")
        For Each item As DataRow In dt.Rows
            index += 1
            item("index") = index
        Next

        For Each dr As DataRow In dt.Rows
            Try
                MODEL.CLS_ADDR.tha_fullname = dr("tha_fullname")

            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.identify = dr("identify")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.thaaddr = dr("thaaddr")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.building = dr("building")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.mu = dr("mu")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.thasoi = dr("thasoi")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.tharoad = dr("tharoad")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.thmblnm = dr("thmblnm")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.amphrnm = dr("amphrnm")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.chngwtnm = dr("chngwtnm")
            Catch ex As Exception

            End Try
            Try
                MODEL.CLS_ADDR.tel = dr("tel")
            Catch ex As Exception

            End Try
        Next
        Return MODEL.CLS_ADDR
    End Function
    Public Function SAVE_DATA_LCN_EDIT(ByVal MODEL As MODEL_APP) As Object
        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT
        dao.GetDataby_IDA(MODEL.IDA)
        Dim dao_log As New DAO_LCN.TB_LOG_STATUS_LCN_EDIT
        Dim TR_ID As String = ""
        If dao.fields.IDA = 0 Then
            dao_log.fields.STATUS_ID = 0
            dao_log.fields.PROCESS_ID = 10201
            dao_log.fields.STATUS_DATE = System.DateTime.Now
            dao_log.fields.IDENTIFY = MODEL.CLS_SESSION.CITIZEN_ID
            dao_log.fields.NAME = MODEL.CLS_SESSION.THANM
            dao_log.fields.FK_IDA = MODEL.IDA_LCN
            dao_log.insert()

            Dim get_reson_type As Integer = 0

            Dim _PROCESS_ID As String = 10201
            Dim bao_tran As New BAO_TRANSECTION
            Dim _YEAR As String = con_year(Date.Now().Year())
            dao.fields.FK_LCN_IDA = MODEL.dalcn.IDA
            dao.fields.FK_LOCATION_IDA = MODEL.dalcn.FK_IDA
            dao.fields.STAFF_TYPE = MODEL.STAFF_ID
            'dao.fields.STAFF_NAME = _STAFF_NAME
            TR_ID = bao_tran.insert_transection(_PROCESS_ID)
            dao.fields.TR_ID = TR_ID
            dao.fields.LCN_PROCESS_ID = 10201
            'dao.fields.TR_ID = _tr_id
            'dao.fields.LCN_EDIT_REASON_TYPE = DDL_EDIT_REASON.SelectedValue
            'dao.fields.LCN_EDIT_REASON_NAME = DDL_EDIT_REASON.SelectedItem.Text
            Try
                'dao.fields.FK_SUB_REASON_TYPE = DDL_EDIT_REASON_SUB.SelectedValue
            Catch ex As Exception

            End Try
            Try
                'dao.fields.FK_SUB_REASON_NAME = DDL_EDIT_REASON_SUB.SelectedItem.Text
            Catch ex As Exception

            End Try
            dao.fields.DATE_YEAR = con_year(Date.Now().Year())
            dao.fields.NOTE_REASON = MODEL.list_LCN_APPROVE_EDIT.NOTE_REASON
            Try
                dao.fields.LCN_TYPE_ID = MODEL.dalcn.PROCESS_ID
            Catch ex As Exception

            End Try
            Try
                'dao.fields.LCN_TYPE_NAME = rdl_lcn_type.SelectedItem.Text
            Catch ex As Exception

            End Try
            dao.fields.LCN_NAME = MODEL.CLS_ADDR.tha_fullname
            dao.fields.LCN_NAME_SUB = MODEL.DALCN_PHR.PHR_NAME
            dao.fields.LCN_IDENTIFY = MODEL.CLS_ADDR.identify
            dao.fields.LCNNO = MODEL.dalcn.LCNNO_DISPLAY_NEW
            dao.fields.LCN_LOCATION = MODEL.DALCN_LOCATION_ADDRESS.thanameplace
            dao.fields.ADDR_NUM = MODEL.CLS_ADDR.thaaddr
            dao.fields.ADDR_BUILDING = MODEL.CLS_ADDR.building
            dao.fields.ADDR_MOO = MODEL.CLS_ADDR.mu
            dao.fields.ADDR_SOI = MODEL.CLS_ADDR.thasoi
            dao.fields.ADDR_ROAD = MODEL.CLS_ADDR.tharoad
            dao.fields.ADDR_TAMBON = MODEL.CLS_ADDR.thmblnm
            dao.fields.ADDR_AMPHOR = MODEL.CLS_ADDR.amphrnm
            dao.fields.ADDR_CHANGWAT = MODEL.CLS_ADDR.chngwtnm
            dao.fields.ADDR_ZIPCODE = MODEL.CLS_ADDR.zipcode
            dao.fields.ADDR_TEL = MODEL.CLS_ADDR.tel
            dao.fields.LCN_OPENTIME = MODEL.dalcn.opentime
            dao.fields.STATUS_ID = 0
            dao.fields.STATUS_NAME = "บันทึกคำขอรอส่งเรื่อง"
            dao.fields.ACTIVE = 1
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.CREATE_BY = ""
            dao.insert()
            MODEL.IDA = dao.fields.IDA
        Else
            dao.fields.LCN_NAME = MODEL.CLS_ADDR.tha_fullname
            dao.fields.LCN_NAME_SUB = MODEL.DALCN_PHR.PHR_NAME
            dao.fields.LCN_IDENTIFY = MODEL.CLS_ADDR.identify
            dao.fields.LCNNO = MODEL.dalcn.LCNNO_DISPLAY_NEW
            dao.fields.LCN_LOCATION = MODEL.DALCN_LOCATION_ADDRESS.thanameplace
            dao.fields.ADDR_NUM = MODEL.CLS_ADDR.thaaddr
            dao.fields.ADDR_BUILDING = MODEL.CLS_ADDR.building
            dao.fields.ADDR_MOO = MODEL.CLS_ADDR.mu
            dao.fields.ADDR_SOI = MODEL.CLS_ADDR.thasoi
            dao.fields.ADDR_ROAD = MODEL.CLS_ADDR.tharoad
            dao.fields.ADDR_TAMBON = MODEL.CLS_ADDR.thmblnm
            dao.fields.ADDR_AMPHOR = MODEL.CLS_ADDR.amphrnm
            dao.fields.ADDR_CHANGWAT = MODEL.CLS_ADDR.chngwtnm
            dao.fields.ADDR_ZIPCODE = MODEL.CLS_ADDR.zipcode
            dao.fields.ADDR_TEL = MODEL.CLS_ADDR.tel
            dao.fields.LCN_OPENTIME = MODEL.dalcn.opentime
            dao.fields.STATUS_ID = 0
            dao.fields.STATUS_NAME = "บันทึกคำขอรอส่งเรื่อง"
            dao.fields.ACTIVE = 1
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.CREATE_BY = ""
            dao.update()
        End If

        Dim dao_t As New DAO_LCN.TB_LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
        dao_t.GetDataby_FK_IDA(MODEL.IDA)
        If dao_t.fields.IDA = 0 Then
            dao_t.fields.FK_IDA = MODEL.IDA
            dao_t.fields.Main_check_1 = MODEL.TYPE_EDIT_REQUEST.Main_check_1
            dao_t.fields.Main_check_2 = MODEL.TYPE_EDIT_REQUEST.Main_check_2
            dao_t.fields.Main_check_3 = MODEL.TYPE_EDIT_REQUEST.Main_check_3
            dao_t.fields.Main_check_4 = MODEL.TYPE_EDIT_REQUEST.Main_check_4
            dao_t.fields.Main_check_5 = MODEL.TYPE_EDIT_REQUEST.Main_check_5
            dao_t.fields.Main_check_6 = MODEL.TYPE_EDIT_REQUEST.Main_check_6
            dao_t.fields.Main_check_7 = MODEL.TYPE_EDIT_REQUEST.Main_check_7
            dao_t.fields.Main_check_8 = MODEL.TYPE_EDIT_REQUEST.Main_check_8
            dao_t.fields.Main_check_9 = MODEL.TYPE_EDIT_REQUEST.Main_check_9
            dao_t.fields.Main_check_10 = MODEL.TYPE_EDIT_REQUEST.Main_check_10
            dao_t.fields.Main_check_11 = MODEL.TYPE_EDIT_REQUEST.Main_check_11
            dao_t.fields.Sub_check_2_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1
            dao_t.fields.Sub_check_2_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2
            dao_t.fields.Sub_check_2_3 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3
            dao_t.fields.Sub_check_2_4 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4
            dao_t.fields.Sub_check_3_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1
            dao_t.fields.Sub_check_3_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2
            dao_t.fields.Sub_check_6_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1
            dao_t.fields.Sub_check_7_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1
            dao_t.fields.Sub_check_7_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2
            dao_t.fields.Sub_check_8_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1
            dao_t.fields.Sub_check_8_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2
            dao_t.fields.Sub_check_9_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1
            dao_t.fields.Sub_check_9_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2
            dao_t.fields.Sub_check_9_3 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_3
            dao_t.fields.Sub_check_10_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1
            dao_t.fields.Sub_check_11_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1
            dao_t.insert()
        Else
            dao_t.fields.Main_check_1 = MODEL.TYPE_EDIT_REQUEST.Main_check_1
            dao_t.fields.Main_check_2 = MODEL.TYPE_EDIT_REQUEST.Main_check_2
            dao_t.fields.Main_check_3 = MODEL.TYPE_EDIT_REQUEST.Main_check_3
            dao_t.fields.Main_check_4 = MODEL.TYPE_EDIT_REQUEST.Main_check_4
            dao_t.fields.Main_check_5 = MODEL.TYPE_EDIT_REQUEST.Main_check_5
            dao_t.fields.Main_check_6 = MODEL.TYPE_EDIT_REQUEST.Main_check_6
            dao_t.fields.Main_check_7 = MODEL.TYPE_EDIT_REQUEST.Main_check_7
            dao_t.fields.Main_check_8 = MODEL.TYPE_EDIT_REQUEST.Main_check_8
            dao_t.fields.Main_check_9 = MODEL.TYPE_EDIT_REQUEST.Main_check_9
            dao_t.fields.Main_check_10 = MODEL.TYPE_EDIT_REQUEST.Main_check_10
            dao_t.fields.Main_check_11 = MODEL.TYPE_EDIT_REQUEST.Main_check_11
            dao_t.fields.Sub_check_2_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1
            dao_t.fields.Sub_check_2_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2
            dao_t.fields.Sub_check_2_3 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3
            dao_t.fields.Sub_check_2_4 = MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4
            dao_t.fields.Sub_check_3_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1
            dao_t.fields.Sub_check_3_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2
            dao_t.fields.Sub_check_6_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1
            dao_t.fields.Sub_check_7_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1
            dao_t.fields.Sub_check_7_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2
            dao_t.fields.Sub_check_8_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1
            dao_t.fields.Sub_check_8_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2
            dao_t.fields.Sub_check_9_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1
            dao_t.fields.Sub_check_9_2 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2
            dao_t.fields.Sub_check_9_3 = MODEL.TYPE_EDIT_REQUEST.Sub_check_9_3
            dao_t.fields.Sub_check_10_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1
            dao_t.fields.Sub_check_11_1 = MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1
            dao_t.update()
        End If

        If MODEL.TYPE_EDIT_REQUEST.Main_check_1 = True Then
            SET_DATA_INSERT_Main_check_1(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_2 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1 = True Then
                MODEL.ddl1 = 2
                MODEL.ddl2 = 1
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2 = True Then
                MODEL.ddl1 = 2
                MODEL.ddl2 = 2
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3 = True Then
                MODEL.ddl1 = 2
                MODEL.ddl2 = 3
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4 = True Then
                MODEL.ddl1 = 2
                MODEL.ddl2 = 4
            End If
            SET_DATA_INSERT_Main_check_2(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_3 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1 = True Then
                MODEL.ddl1 = 3
                MODEL.ddl2 = 1
                SET_DATA_INSERT_REASON_DDL3_SUB1(MODEL)
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2 = True Then
                MODEL.ddl1 = 3
                MODEL.ddl2 = 2
                SET_DATA_INSERT_REASON3_SUB2(MODEL)
            End If
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_4 = True Then
            SET_DATA_INSERT_REASON4(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_5 = True Then
            SET_DATA_INSERT_REASON5(MODEL)
            save_data_OLD_ddl5(MODEL)
            save_data_ddl5(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_6 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1 = True Then
                MODEL.ddl1 = 6
                MODEL.ddl2 = 1
                SET_DATA_INSERT_REASON_DDL6(MODEL)
            End If
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_7 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1 = True Then
                MODEL.ddl1 = 7
                MODEL.ddl2 = 1
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2 = True Then
                MODEL.ddl1 = 7
                MODEL.ddl2 = 2
            End If
            SET_DATA_INSERT_REASON7(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_8 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1 = True Then
                MODEL.ddl1 = 8
                MODEL.ddl2 = 1
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2 = True Then
                MODEL.ddl1 = 8
                MODEL.ddl2 = 1
            End If
            SET_DATA_INSERT_REASON8(MODEL)
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_9 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1 = True Then
                MODEL.ddl1 = 9
                MODEL.ddl2 = 1
                SET_DATA_OLD_INSERT_REASON_DDL9_SUB1(MODEL)
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2 = True Then
                MODEL.ddl1 = 9
                MODEL.ddl2 = 2
                SET_DATA_OLD_INSERT_REASON_DDL9_SUB2(MODEL)
            ElseIf MODEL.TYPE_EDIT_REQUEST.Sub_check_9_3 = True Then
                MODEL.ddl1 = 9
                MODEL.ddl2 = 3
                'SET_DATA_OLD_INSERT_REASON_DDL9_SUB2(MODEL)
            End If
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_10 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1 = True Then
                MODEL.ddl1 = 10
                MODEL.ddl2 = 1
                save_data_OLD_ddl10(MODEL)
                save_data_ddl10(MODEL)
            End If
        ElseIf MODEL.TYPE_EDIT_REQUEST.Main_check_11 = True Then
            If MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1 = True Then
                MODEL.ddl1 = 11
                MODEL.ddl2 = 1
                save_data_OLD_ddl11(MODEL)
                save_data_ddl11(MODEL)
            End If
        End If
        SET_DATA_INSERT_UPLOAD_FILE(MODEL)
        Return MODEL
    End Function
    Sub SET_DATA_INSERT_UPLOAD_FILE(ByVal MODEL As MODEL_APP)
        Dim lcn_edit_process As Integer = 0
        Dim ddl1 As Integer = 0
        Dim ddl2 As Integer = 0
        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT
        dao.GetDataby_IDA(MODEL.IDA)
        ddl1 = dao.fields.LCN_EDIT_REASON_TYPE
        Try
            ddl2 = dao.fields.FK_SUB_REASON_TYPE
        Catch ex As Exception
        End Try

        lcn_edit_process = dao.fields.LCN_PROCESS_ID

        Dim dt As New DataTable
        Dim bao As New BAO.BAO
        Dim YEAR_S As String = ""
        Dim TR_ID As String = ""
        If dao.fields.TR_ID IsNot Nothing Then TR_ID = dao.fields.TR_ID
        YEAR_S = con_year(Date.Now().Year())
        dt = bao.SP_LCN_APPROVE_EDIT_GET_DATA_FILE_UPLOAD_FOR_UPDATE(MODEL.IDA, MODEL.ddl1, MODEL.ddl2, 1, YEAR_S)

        For Each dr As DataRow In dt.Rows
            Dim dao_up As New DAO_LCN.TB_LCN_APPROVE_EDIT_UPLOAD_FILE
            Dim IDA As String = ""
            IDA = dr("IDA")
            dao_up.GetDataby_IDA(IDA)
            dao_up.fields.TR_ID = TR_ID
            dao_up.update()
        Next
    End Sub
    Sub SET_DATA_INSERT_Main_check_1(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON1(MODEL)

        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL1_REASON
        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL1_REASON
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA(MODEL.IDA_LCN, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA_LCN, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.PHR_TEXT_JOB = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_TEXT_JOB
            dao.fields.PHR_TEXT_NUM = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_TEXT_NUM
            dao.fields.STUDY_LEVEL = MODEL.LCN_APPROVE_EDIT_DDL1.STUDY_LEVEL
            dao.fields.PHR_SAKHA = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_SAKHA
            dao.fields.NAME_SIMINAR = MODEL.LCN_APPROVE_EDIT_DDL1.NAME_SIMINAR
            Try
                dao.fields.SIMINAR_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL1.SIMINAR_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.SIMINAR_DATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.PHR_TEXT_JOB = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_TEXT_JOB
            dao.fields.PHR_TEXT_NUM = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_TEXT_NUM
            dao.fields.STUDY_LEVEL = MODEL.LCN_APPROVE_EDIT_DDL1.STUDY_LEVEL
            dao.fields.PHR_SAKHA = MODEL.LCN_APPROVE_EDIT_DDL1.PHR_SAKHA
            dao.fields.NAME_SIMINAR = MODEL.LCN_APPROVE_EDIT_DDL1.NAME_SIMINAR
            Try
                dao.fields.SIMINAR_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL1.SIMINAR_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.SIMINAR_DATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If
    End Sub
    Sub SET_DATA_OLD_INSERT_REASON1(ByVal MODEL As MODEL_APP)

        If MODEL.Detial_Type = 0 Then
            Dim dao_phr As New DAO_LCN.TB_DALCN_PHR
            dao_phr.GetDataby_FK_IDA(MODEL.IDA_LCN)

            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As DateTime

            GET_1 = dao_phr.fields.PHR_TEXT_JOB
            GET_2 = dao_phr.fields.PHR_TEXT_NUM
            GET_3 = dao_phr.fields.STUDY_LEVEL
            GET_4 = dao_phr.fields.PHR_VETERINARY_FIELD
            'GET_4 = dao_phr.fields.PHR_SAKHA
            GET_5 = dao_phr.fields.NAME_SIMINAR
            '12/10/2564
            Dim datefull_siminar As Date
            Dim SIMINAR_DATE As String = ""
            Try
                'datefull_siminar = dao_phr.fields.SIMINAR_DATE
                'SIMINAR_DATE = datefull_siminar.Day & "/" & datefull_siminar.Month & "/" & datefull_siminar.Year
                GET_6 = dao_phr.fields.SIMINAR_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            'insert old detail
            Dim old_update As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL1_REASON
            old_update.GET_DATA_BY_FK_LCN_IDA(MODEL.IDA_LCN, True)
            old_update.fields.UPDATE_BY = ""
            old_update.fields.UPDATE_DATE = System.DateTime.Now
            old_update.fields.ACTIVE = False
            old_update.update()

            Dim old_dao As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL1_REASON
            old_dao.fields.FK_IDA = MODEL.IDA
            old_dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            old_dao.fields.PHR_TEXT_JOB = GET_1
            old_dao.fields.PHR_TEXT_NUM = GET_2
            old_dao.fields.STUDY_LEVEL = GET_3
            old_dao.fields.PHR_SAKHA = GET_4
            old_dao.fields.NAME_SIMINAR = GET_5
            Try
                old_dao.fields.SIMINAR_DATE = DateTime.ParseExact(GET_6, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                'old_dao.fields.SIMINAR_DATE = System.DateTime.Now
            End Try
            old_dao.fields.CREATE_DATE = System.DateTime.Now
            old_dao.fields.ACTIVE = 1
            old_dao.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_Main_check_2(ByVal MODEL As MODEL_APP)

        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON2(MODEL)
        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL2_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL2_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lct_ida, ddl1, ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCT
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL2.thanameplace
            dao.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL2.HOUSENO
            dao.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL2.thaaddr
            dao.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL2.thabuilding
            dao.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL2.thamu
            dao.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL2.thasoi
            dao.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL2.tharoad
            dao.fields.thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL2.thathmblnm
            dao.fields.thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL2.thaamphrnm
            dao.fields.thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL2.thachngwtnm
            dao.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL2.zipcode
            dao.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL2.fax
            dao.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL2.tel
            dao.fields.email = MODEL.LCN_APPROVE_EDIT_DDL2.email
            dao.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL2.opentime

            'สถานที่เก็บ
            dao.fields.KEEP_thanameplace = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thanameplace
            dao.fields.KEEP_HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_HOUSENO
            dao.fields.KEEP_thaaddr = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thaaddr
            dao.fields.KEEP_thabuilding = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thabuilding
            dao.fields.KEEP_thamu = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thamu
            dao.fields.KEEP_thasoi = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thasoi
            dao.fields.KEEP_tharoad = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_tharoad
            dao.fields.KEEP_thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thathmblnm
            dao.fields.KEEP_thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thathmblnm
            dao.fields.KEEP_thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thachngwtnm
            dao.fields.KEEP_zipcode = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_zipcode
            dao.fields.KEEP_fax = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_fax
            dao.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_tel
            dao.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_email
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCT
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL2.thanameplace
            dao.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL2.HOUSENO
            dao.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL2.thaaddr
            dao.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL2.thabuilding
            dao.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL2.thamu
            dao.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL2.thasoi
            dao.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL2.tharoad
            dao.fields.thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL2.thathmblnm
            dao.fields.thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL2.thaamphrnm
            dao.fields.thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL2.thachngwtnm
            dao.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL2.zipcode
            dao.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL2.fax
            dao.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL2.tel
            dao.fields.email = MODEL.LCN_APPROVE_EDIT_DDL2.email
            dao.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL2.opentime

            'สถานที่เก็บ
            dao.fields.KEEP_thanameplace = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thanameplace
            dao.fields.KEEP_HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_HOUSENO
            dao.fields.KEEP_thaaddr = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thaaddr
            dao.fields.KEEP_thabuilding = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thabuilding
            dao.fields.KEEP_thamu = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thamu
            dao.fields.KEEP_thasoi = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thasoi
            dao.fields.KEEP_tharoad = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_tharoad
            dao.fields.KEEP_thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thathmblnm
            dao.fields.KEEP_thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thathmblnm
            dao.fields.KEEP_thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_thachngwtnm
            dao.fields.KEEP_zipcode = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_zipcode
            dao.fields.KEEP_fax = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_fax
            dao.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_tel
            dao.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL2.KEEP_email
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If


    End Sub
    Sub SET_DATA_OLD_INSERT_REASON2(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            Dim dao1 As New DAO_LCN.TB_DALCN_LOCATION_ADDRESS
            dao1.GetDataby_IDA(MODEL.IDA_LCT)

            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""
            Dim GET_10 As String = ""
            Dim GET_11 As String = ""
            Dim GET_12 As String = ""
            Dim GET_13 As String = ""
            Dim GET_14 As String = ""
            Dim GET_15 As String = ""

            GET_1 = dao1.fields.thanameplace
            GET_2 = dao1.fields.HOUSENO
            GET_3 = dao1.fields.thaaddr
            GET_4 = dao1.fields.thabuilding
            GET_5 = dao1.fields.thamu
            GET_6 = dao1.fields.thasoi
            GET_7 = dao1.fields.tharoad
            GET_8 = dao1.fields.thathmblnm
            GET_9 = dao1.fields.thaamphrnm
            GET_10 = dao1.fields.thachngwtnm
            GET_11 = dao1.fields.zipcode
            GET_12 = dao1.fields.fax
            GET_13 = dao1.fields.tel
            GET_14 = "" 'รอเพิ่มฟิว email
            GET_15 = "" 'รอเพิ่มฟิว opentime
            'สถานที่เก็บ
            Dim dao2 As New DAO_LCN.TB_DALCN_DETAIL_LOCATION_KEEP
            dao2.GetData_by_LOCATION_ADDRESS_IDA_AND_LCN_IDA(MODEL.IDA_LCT, MODEL.IDA_LCN)

            Dim GET_KEEP_1 As String = ""
            Dim GET_KEEP_2 As String = ""
            Dim GET_KEEP_3 As String = ""
            Dim GET_KEEP_4 As String = ""
            Dim GET_KEEP_5 As String = ""
            Dim GET_KEEP_6 As String = ""
            Dim GET_KEEP_7 As String = ""
            Dim GET_KEEP_8 As String = ""
            Dim GET_KEEP_9 As String = ""
            Dim GET_KEEP_10 As String = ""
            Dim GET_KEEP_11 As String = ""
            Dim GET_KEEP_12 As String = ""
            Dim GET_KEEP_13 As String = ""
            Dim GET_KEEP_14 As String = ""

            GET_KEEP_1 = dao2.fields.LOCATION_ADDRESS_thanameplace
            GET_KEEP_2 = dao2.fields.LOCATION_ADDRESS_HOUSENO
            GET_KEEP_3 = dao2.fields.LOCATION_ADDRESS_thaaddr
            GET_KEEP_4 = dao2.fields.LOCATION_ADDRESS_thabuilding
            GET_KEEP_5 = dao2.fields.LOCATION_ADDRESS_thamu
            GET_KEEP_6 = dao2.fields.LOCATION_ADDRESS_thasoi
            GET_KEEP_7 = dao2.fields.LOCATION_ADDRESS_tharoad
            GET_KEEP_8 = dao2.fields.LOCATION_ADDRESS_thathmblnm
            GET_KEEP_9 = dao2.fields.LOCATION_ADDRESS_thaamphrnm
            GET_KEEP_10 = dao2.fields.LOCATION_ADDRESS_thachngwtnm
            GET_KEEP_11 = dao2.fields.LOCATION_ADDRESS_zipcode
            GET_KEEP_12 = dao2.fields.LOCATION_ADDRESS_fax
            GET_KEEP_13 = dao2.fields.LOCATION_ADDRESS_tel
            GET_KEEP_14 = "" 'รอเพิ่มฟิว KEEP_email

            'insert old detail
            Dim dao_old_update As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL2_REASON
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL2_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_old_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, ddl1, ddl2, True)
                dao_old_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)

                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_old_update.fields.ACTIVE = 0
                dao_old_update.fields.UPDATE_DATE = System.DateTime.Now
                dao_old_update.update()
            End If
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCT_IDA = MODEL.IDA_LCN
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.thanameplace = GET_1
            dao_old.fields.HOUSENO = GET_2
            dao_old.fields.thaaddr = GET_3
            dao_old.fields.thabuilding = GET_4
            dao_old.fields.thamu = GET_5
            dao_old.fields.thasoi = GET_6
            dao_old.fields.tharoad = GET_7
            dao_old.fields.thathmblnm = GET_8
            dao_old.fields.thaamphrnm = GET_9
            dao_old.fields.thachngwtnm = GET_10
            dao_old.fields.zipcode = GET_11
            dao_old.fields.fax = GET_12
            dao_old.fields.tel = GET_13
            dao_old.fields.email = GET_14
            dao_old.fields.opentime = GET_15

            'สถานที่เก็บ
            dao_old.fields.KEEP_thanameplace = GET_KEEP_1
            dao_old.fields.KEEP_HOUSENO = GET_KEEP_2
            dao_old.fields.KEEP_thaaddr = GET_KEEP_3
            dao_old.fields.KEEP_thabuilding = GET_KEEP_4
            dao_old.fields.KEEP_thamu = GET_KEEP_5
            dao_old.fields.KEEP_thasoi = GET_KEEP_6
            dao_old.fields.KEEP_tharoad = GET_KEEP_7
            dao_old.fields.KEEP_thathmblnm = GET_KEEP_8
            dao_old.fields.KEEP_thaamphrnm = GET_KEEP_9
            dao_old.fields.KEEP_thachngwtnm = GET_KEEP_10
            dao_old.fields.KEEP_zipcode = GET_KEEP_11
            dao_old.fields.KEEP_fax = GET_KEEP_12
            dao_old.fields.KEEP_tel = GET_KEEP_13
            dao_old.fields.KEEP_email = GET_KEEP_14
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON_DDL3_SUB1(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON_DDL3_SUB1(MODEL)

        Dim dao1 As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL3_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL3_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, MODEL.ddl1, MODEL.ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao1.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao1.fields.IDA = 0 Then
            dao1.fields.FK_IDA = MODEL.IDA
            dao1.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao1.fields.ddl1 = MODEL.ddl1
            dao1.fields.ddl2 = MODEL.ddl2
            dao1.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL3.thaaddr
            dao1.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL3.thabuilding
            dao1.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL3.thamu
            dao1.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL3.thasoi
            dao1.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL3.tharoad
            dao1.fields.thmblcd = MODEL.LCN_APPROVE_EDIT_DDL3.thmblcd
            dao1.fields.amphrcd = MODEL.LCN_APPROVE_EDIT_DDL3.amphrcd
            dao1.fields.chngwtcd = MODEL.LCN_APPROVE_EDIT_DDL3.chngwtcd
            dao1.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL3.zipcode
            dao1.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL3.tel
            dao1.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL3.fax
            dao1.fields.email = MODEL.LCN_APPROVE_EDIT_DDL3.email
            dao1.fields.CREATE_DATE = System.DateTime.Now
            dao1.fields.ACTIVE = 1
            dao1.insert()
        Else
            dao1.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao1.fields.ddl1 = MODEL.ddl1
            dao1.fields.ddl2 = MODEL.ddl2
            dao1.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL3.thaaddr
            dao1.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL3.thabuilding
            dao1.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL3.thamu
            dao1.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL3.thasoi
            dao1.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL3.tharoad
            dao1.fields.thmblcd = MODEL.LCN_APPROVE_EDIT_DDL3.thmblcd
            dao1.fields.amphrcd = MODEL.LCN_APPROVE_EDIT_DDL3.amphrcd
            dao1.fields.chngwtcd = MODEL.LCN_APPROVE_EDIT_DDL3.chngwtcd
            dao1.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL3.zipcode
            dao1.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL3.tel
            dao1.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL3.fax
            dao1.fields.email = MODEL.LCN_APPROVE_EDIT_DDL3.email
            dao1.fields.CREATE_DATE = System.DateTime.Now
            dao1.fields.ACTIVE = 1
            dao1.update()
        End If
    End Sub
    Sub SET_DATA_OLD_INSERT_REASON_DDL3_SUB1(ByVal MODEL As MODEL_APP)

        Dim dao1 As New DAO_LCN.TB_DALCN_CURRENT_ADDRESS
        dao1.GetData_By_FK_IDA(MODEL.IDA_LCN)
        Dim GET_1 As String = ""
        Dim GET_2 As String = ""
        Dim GET_3 As String = ""
        Dim GET_4 As String = ""
        Dim GET_5 As String = ""
        Dim GET_6 As String = ""
        Dim GET_7 As String = ""
        Dim GET_8 As String = ""
        Dim GET_9 As String = ""
        Dim GET_10 As String = ""
        Dim GET_11 As String = ""
        Dim GET_12 As String = ""

        GET_1 = dao1.fields.thaaddr
        GET_2 = dao1.fields.thabuilding
        GET_3 = dao1.fields.thamu
        GET_4 = dao1.fields.thasoi
        GET_5 = dao1.fields.tharoad

        Dim thmblcd As Integer = 0
        Dim amphrcd As Integer = 0
        Dim chngwtcd As Integer = 0
        Try
            thmblcd = dao1.fields.thmblcd
            GET_6 = thmblcd
        Catch ex As Exception

        End Try
        Try
            amphrcd = dao1.fields.amphrcd
            GET_7 = amphrcd
        Catch ex As Exception

        End Try
        Try
            chngwtcd = dao1.fields.chngwtcd
            GET_8 = chngwtcd
        Catch ex As Exception
            GET_8 = ""
        End Try

        GET_9 = dao1.fields.zipcode
        GET_10 = dao1.fields.tel
        GET_11 = dao1.fields.fax
        GET_12 = dao1.fields.email

        'เซฟตัวเก่า
        Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL3_REASON
        Dim dao_old_update As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL3_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_old_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, MODEL.ddl1, MODEL.ddl2, True)
            dao_old_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_old_update.fields.ACTIVE = 0
            dao_old_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_old_update.update()
        End If
        dao_old.fields.FK_IDA = MODEL.IDA
        dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
        dao_old.fields.ddl1 = MODEL.ddl1
        dao_old.fields.ddl2 = MODEL.ddl2
        dao_old.fields.thaaddr = GET_1
        dao_old.fields.thabuilding = GET_2
        dao_old.fields.thamu = GET_3
        dao_old.fields.thasoi = GET_4
        dao_old.fields.tharoad = GET_5
        Try
            dao_old.fields.thmblcd = GET_6
        Catch ex As Exception
            dao_old.fields.thmblcd = 0
        End Try

        Try
            dao_old.fields.amphrcd = GET_7
        Catch ex As Exception
            dao_old.fields.amphrcd = 0
        End Try
        Try
            dao_old.fields.chngwtcd = GET_8
        Catch ex As Exception
            dao_old.fields.chngwtcd = 0
        End Try
        dao_old.fields.zipcode = GET_9
        dao_old.fields.tel = GET_10
        dao_old.fields.fax = GET_11
        dao_old.fields.email = GET_12
        dao_old.fields.CREATE_DATE = System.DateTime.Now
        dao_old.fields.ACTIVE = 1
        dao_old.insert()
    End Sub
    Sub SET_DATA_INSERT_REASON3_SUB2(ByVal MODEL As MODEL_APP)

        SET_DATA_OLD_INSERT_REASON3_SUB2(MODEL)

        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL3_REASON
        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL3_REASON

        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, MODEL.ddl1, MODEL.ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.GIVE_PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_PASSPORT_NO
            Try
                dao.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.GIVE_WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_WORK_LICENSE_NO
            Try
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.GIVE_PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_PASSPORT_NO
            Try
                dao.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.GIVE_WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_WORK_LICENSE_NO
            Try
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL3.GIVE_WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If

    End Sub
    Sub SET_DATA_OLD_INSERT_REASON3_SUB2(ByVal MODEL As MODEL_APP)

        'get ตัวเก่า
        If MODEL.Detial_Type = 0 Then
            Dim dao1 As New DAO_LCN.TB_dalcn
            dao1.GetDataby_IDA(MODEL.IDA_LCN)

            Dim GET_1 As String = ""
            Dim GET_2 As DateTime
            Dim GET_3 As String = ""
            Dim GET_4 As DateTime
            GET_1 = dao1.fields.GIVE_PASSPORT_NO
            Dim datefull_PASSPORT_EXPDATE As Date
            Dim PASSPORT_EXPDATE As String = ""
            Try
                'datefull_PASSPORT_EXPDATE =
                'PASSPORT_EXPDATE = datefull_PASSPORT_EXPDATE.Day & "/" & datefull_PASSPORT_EXPDATE.Month & "/" & datefull_PASSPORT_EXPDATE.Year
                GET_2 = dao1.fields.GIVE_PASSPORT_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_3 = dao1.fields.GIVE_WORK_LICENSE_NO
            Dim datefull_GIVE_WORK_LICENSE_EXPDATE As Date
            Dim WORK_LICENSE_EXPDATE As String = ""
            Try
                'datefull_GIVE_WORK_LICENSE_EXPDATE =
                'WORK_LICENSE_EXPDATE = datefull_GIVE_WORK_LICENSE_EXPDATE.Day & "/" & datefull_GIVE_WORK_LICENSE_EXPDATE.Month & "/" & datefull_GIVE_WORK_LICENSE_EXPDATE.Year
                GET_4 = dao1.fields.GIVE_WORK_LICENSE_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            'เซฟของเก่า
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL3_REASON
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL3_REASON

            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, MODEL.ddl1, MODEL.ddl2, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.GIVE_PASSPORT_NO = GET_1
            Try
                dao_old.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(GET_2, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try
            dao_old.fields.GIVE_WORK_LICENSE_NO = GET_3
            Try
                dao_old.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(GET_4, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON4(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON4(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL4_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL4_REASON
        Dim ROW_CHK As String = ""
        Try
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL4.opentime
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL4.opentime
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If


    End Sub
    Sub SET_DATA_OLD_INSERT_REASON4(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'get ตัวเก่า
            Dim dao_main As New DAO_LCN.TB_dalcn
            dao_main.GetDataby_IDA(MODEL.IDA_LCN)
            Dim GET_1 As String = ""
            GET_1 = dao_main.fields.opentime

            'เซฟตัวเก่า
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL4_REASON
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL4_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCN_IDA(MODEL.IDA_LCN, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao_old.fields.opentime = GET_1
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON5(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON5(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL5_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL5_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(MODEL.IDA_LCN, MODEL.ddl1, MODEL.ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCN
            dao.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL5.tel
            dao.fields.email = MODEL.LCN_APPROVE_EDIT_DDL5.email

            'สถานที่เก็บ
            'Dim dao2 As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
            'dao2.GetDataby_IDA(_lct_ida)
            dao.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL5.KEEP_tel
            dao.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL5.KEEP_email
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCN
            dao.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL5.tel
            dao.fields.email = MODEL.LCN_APPROVE_EDIT_DDL5.email

            'สถานที่เก็บ
            'Dim dao2 As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
            'dao2.GetDataby_IDA(_lct_ida)
            dao.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL5.KEEP_tel
            dao.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL5.KEEP_email
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If


    End Sub
    Sub SET_DATA_OLD_INSERT_REASON5(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'get ตัวเก่า
            Dim dao1 As New DAO_LCN.TB_DALCN_LOCATION_ADDRESS
            dao1.GetDataby_IDA(MODEL.IDA_LCT)

            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_KEEP_1 As String = ""
            Dim GET_KEEP_2 As String = ""

            GET_1 = dao1.fields.tel
            GET_2 = "" 'รอเพิ่มฟิว email

            'สถานที่เก็บ
            Dim dao2 As New DAO_LCN.TB_DALCN_DETAIL_LOCATION_KEEP
            dao2.GetData_by_LOCATION_ADDRESS_IDA_AND_LCN_IDA(MODEL.IDA_LCT, MODEL.IDA_LCN)


            GET_KEEP_1 = dao2.fields.LOCATION_ADDRESS_tel
            GET_KEEP_2 = "" 'รอเพิ่มฟิว KEEP_email

            'เซฟตัวเก่า
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL5_REASON
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL5_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(_lct_ida, ddl1, ddl2, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If

            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.FK_LCT_IDA = MODEL.IDA_LCT
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.tel = GET_1
            dao_old.fields.email = GET_2

            'สถานที่เก็บ
            'Dim dao2 As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
            'dao2.GetDataby_IDA(_lct_ida)
            dao_old.fields.KEEP_tel = GET_KEEP_1
            dao_old.fields.KEEP_email = GET_KEEP_2

            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1

            dao_old.insert()
        End If
    End Sub
    Sub save_data_OLD_ddl5(ByVal MODEL As MODEL_APP)
        Dim dao_get As New DAO_LCN.TB_DALCN_IMPORT_DRUG_GROUP_HERB_DETAIL
        Try
            dao_get.GetDataby_FKIDA(MODEL.IDA_LCN)
        Catch ex As Exception

        End Try

        Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL5_REASON
        'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_LCN_IDA, _ddl1, _ddl2, True)
        dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        For Each dao_update_old.fields In dao_update_old.datas
            dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
            dao_update_old.fields.UPDATE_BY = ""
            dao_update_old.fields.ACTIVE = 0
            dao_update_old.update()
        Next


        For Each dao_get.fields In dao_get.datas

            Dim GET_1 As Integer = 0
            Dim GET_2 As Integer = 0
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""

            GET_1 = dao_get.fields.FK_IDA
            GET_2 = dao_get.fields.LCN_IDA
            GET_3 = dao_get.fields.COL1
            GET_4 = dao_get.fields.COL2
            GET_5 = dao_get.fields.COL3
            GET_6 = dao_get.fields.COL4
            GET_7 = dao_get.fields.COL5
            GET_8 = dao_get.fields.COL6
            GET_9 = dao_get.fields.COL6_OTHER

            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL5_REASON
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_IDA_CHK_ROW = GET_1
            dao_old.fields.FK_LCN_IDA = GET_2
            dao_old.fields.COL1 = GET_3
            dao_old.fields.COL2 = GET_4
            dao_old.fields.COL3 = GET_5
            dao_old.fields.COL4 = GET_6
            dao_old.fields.COL5 = GET_7
            dao_old.fields.COL6 = GET_8
            dao_old.fields.COL6_OTHER = GET_9
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.CREATE_BY = ""
            dao_old.fields.ACTIVE = 1
            dao_old.insert()

        Next
    End Sub
    Sub save_data_ddl5(ByVal MODEL As MODEL_APP)

    End Sub
    Sub SET_DATA_INSERT_REASON_DDL6(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า 
        SET_DATA_OLD_INSERT_REASON_DDL6(MODEL)

        Dim dao1 As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL6_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL6_REASON
        Dim ROW_CHK As String = ""
        Try
            dao_update.GET_DATA_BY_FK_LCT_IDA(MODEL.IDA_LCT, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao1.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao1.fields.IDA = 0 Then
            dao1.fields.FK_IDA = MODEL.IDA
            dao1.fields.FK_LCT_IDA = MODEL.IDA_LCT
            'dao1.fields.DDL1 = dd1
            'dao1.fields.DDL2 = dd2
            dao1.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL6.thanameplace
            dao1.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL6.HOUSENO
            dao1.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL6.thaaddr
            dao1.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL6.thabuilding
            dao1.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL6.thamu
            dao1.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL6.thasoi
            dao1.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL6.tharoad
            dao1.fields.thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL6.thathmblnm
            dao1.fields.thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL6.thaamphrnm
            dao1.fields.thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL6.thachngwtnm
            dao1.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL6.zipcode
            dao1.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL6.fax
            dao1.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL6.tel
            dao1.fields.email = MODEL.LCN_APPROVE_EDIT_DDL6.email
            dao1.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL6.opentime

            'สถานที่เก็บ
            dao1.fields.KEEP_thanameplace = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thanameplace
            dao1.fields.KEEP_HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_HOUSENO
            dao1.fields.KEEP_thaaddr = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thaaddr
            dao1.fields.KEEP_thabuilding = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thabuilding
            dao1.fields.KEEP_thamu = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thamu
            dao1.fields.KEEP_thasoi = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thasoi
            dao1.fields.KEEP_tharoad = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_tharoad
            dao1.fields.KEEP_thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thathmblnm
            dao1.fields.KEEP_thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thaamphrnm
            dao1.fields.KEEP_thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thachngwtnm
            dao1.fields.KEEP_zipcode = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_zipcode
            dao1.fields.KEEP_fax = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_fax
            dao1.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_tel
            dao1.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_email
            dao1.fields.CREATE_DATE = System.DateTime.Now
            dao1.fields.ACTIVE = 1
            dao1.insert()
        Else
            dao1.fields.FK_IDA = MODEL.IDA
            dao1.fields.FK_LCT_IDA = MODEL.IDA_LCT
            'dao1.fields.DDL1 = dd1
            'dao1.fields.DDL2 = dd2
            dao1.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL6.thanameplace
            dao1.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL6.HOUSENO
            dao1.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL6.thaaddr
            dao1.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL6.thabuilding
            dao1.fields.thamu = MODEL.LCN_APPROVE_EDIT_DDL6.thamu
            dao1.fields.thasoi = MODEL.LCN_APPROVE_EDIT_DDL6.thasoi
            dao1.fields.tharoad = MODEL.LCN_APPROVE_EDIT_DDL6.tharoad
            dao1.fields.thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL6.thathmblnm
            dao1.fields.thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL6.thaamphrnm
            dao1.fields.thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL6.thachngwtnm
            dao1.fields.zipcode = MODEL.LCN_APPROVE_EDIT_DDL6.zipcode
            dao1.fields.fax = MODEL.LCN_APPROVE_EDIT_DDL6.fax
            dao1.fields.tel = MODEL.LCN_APPROVE_EDIT_DDL6.tel
            dao1.fields.email = MODEL.LCN_APPROVE_EDIT_DDL6.email
            dao1.fields.opentime = MODEL.LCN_APPROVE_EDIT_DDL6.opentime

            'สถานที่เก็บ
            dao1.fields.KEEP_thanameplace = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thanameplace
            dao1.fields.KEEP_HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_HOUSENO
            dao1.fields.KEEP_thaaddr = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thaaddr
            dao1.fields.KEEP_thabuilding = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thabuilding
            dao1.fields.KEEP_thamu = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thamu
            dao1.fields.KEEP_thasoi = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thasoi
            dao1.fields.KEEP_tharoad = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_tharoad
            dao1.fields.KEEP_thathmblnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thathmblnm
            dao1.fields.KEEP_thaamphrnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thaamphrnm
            dao1.fields.KEEP_thachngwtnm = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_thachngwtnm
            dao1.fields.KEEP_zipcode = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_zipcode
            dao1.fields.KEEP_fax = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_fax
            dao1.fields.KEEP_tel = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_tel
            dao1.fields.KEEP_email = MODEL.LCN_APPROVE_EDIT_DDL6.KEEP_email
            dao1.fields.CREATE_DATE = System.DateTime.Now
            dao1.fields.ACTIVE = 1
            dao1.update()
        End If
    End Sub
    Sub SET_DATA_OLD_INSERT_REASON_DDL6(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'get ตัวเก่า
            Dim dao1 As New DAO_LCN.TB_DALCN_LOCATION_ADDRESS
            dao1.GetDataby_IDA(MODEL.IDA_LCT)
            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""
            Dim GET_10 As String = ""
            Dim GET_11 As String = ""
            Dim GET_12 As String = ""
            Dim GET_13 As String = ""
            Dim GET_14 As String = ""
            Dim GET_15 As String = ""


            GET_1 = dao1.fields.thanameplace
            GET_2 = dao1.fields.HOUSENO
            GET_3 = dao1.fields.thaaddr
            GET_4 = dao1.fields.thabuilding
            GET_5 = dao1.fields.thamu
            GET_6 = dao1.fields.thasoi
            GET_7 = dao1.fields.tharoad
            GET_8 = dao1.fields.thathmblnm
            GET_9 = dao1.fields.thaamphrnm
            GET_10 = dao1.fields.thachngwtnm
            GET_11 = dao1.fields.zipcode
            GET_12 = dao1.fields.fax
            GET_13 = dao1.fields.tel
            GET_14 = "" 'รอเพิ่มฟิว email
            GET_15 = "" 'รอเพิ่มฟิว opentime

            'สถานที่เก็บ
            Dim dao2 As New DAO_LCN.TB_DALCN_DETAIL_LOCATION_KEEP
            dao2.GetData_by_LOCATION_ADDRESS_IDA_AND_LCN_IDA(MODEL.IDA_LCT, MODEL.IDA_LCN)

            Dim GET_KEEP_1 As String = ""
            Dim GET_KEEP_2 As String = ""
            Dim GET_KEEP_3 As String = ""
            Dim GET_KEEP_4 As String = ""
            Dim GET_KEEP_5 As String = ""
            Dim GET_KEEP_6 As String = ""
            Dim GET_KEEP_7 As String = ""
            Dim GET_KEEP_8 As String = ""
            Dim GET_KEEP_9 As String = ""
            Dim GET_KEEP_10 As String = ""
            Dim GET_KEEP_11 As String = ""
            Dim GET_KEEP_12 As String = ""
            Dim GET_KEEP_13 As String = ""
            Dim GET_KEEP_14 As String = ""

            GET_KEEP_1 = dao2.fields.LOCATION_ADDRESS_thanameplace
            GET_KEEP_2 = dao2.fields.LOCATION_ADDRESS_HOUSENO
            GET_KEEP_3 = dao2.fields.LOCATION_ADDRESS_thaaddr
            GET_KEEP_4 = dao2.fields.LOCATION_ADDRESS_thabuilding
            GET_KEEP_5 = dao2.fields.LOCATION_ADDRESS_thamu
            GET_KEEP_6 = dao2.fields.LOCATION_ADDRESS_thasoi
            GET_KEEP_7 = dao2.fields.LOCATION_ADDRESS_tharoad
            GET_KEEP_8 = dao2.fields.LOCATION_ADDRESS_thathmblnm
            GET_KEEP_9 = dao2.fields.LOCATION_ADDRESS_thaamphrnm
            GET_KEEP_10 = dao2.fields.LOCATION_ADDRESS_thachngwtnm
            GET_KEEP_11 = dao2.fields.LOCATION_ADDRESS_zipcode
            GET_KEEP_12 = dao2.fields.LOCATION_ADDRESS_fax
            GET_KEEP_13 = dao2.fields.LOCATION_ADDRESS_tel
            GET_KEEP_14 = "" 'รอเพิ่มฟิว KEEP_email

            'เซฟตัวเก่า
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL6_REASON
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL6_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCT_IDA(_lct_ida, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If

            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCT_IDA = MODEL.IDA_LCT
            'dao1.fields.DDL1 = dd1
            'dao1.fields.DDL2 = dd2
            dao_old.fields.thanameplace = GET_1
            dao_old.fields.HOUSENO = GET_2
            dao_old.fields.thaaddr = GET_3
            dao_old.fields.thabuilding = GET_4
            dao_old.fields.thamu = GET_5
            dao_old.fields.thasoi = GET_6
            dao_old.fields.tharoad = GET_7
            dao_old.fields.thathmblnm = GET_8
            dao_old.fields.thaamphrnm = GET_9
            dao_old.fields.thachngwtnm = GET_10
            dao_old.fields.zipcode = GET_11
            dao_old.fields.fax = GET_12
            dao_old.fields.tel = GET_13
            dao_old.fields.email = GET_14
            dao_old.fields.opentime = GET_15

            'สถานที่เก็บ
            dao_old.fields.KEEP_thanameplace = GET_KEEP_1
            dao_old.fields.KEEP_HOUSENO = GET_KEEP_2
            dao_old.fields.KEEP_thaaddr = GET_KEEP_3
            dao_old.fields.KEEP_thabuilding = GET_KEEP_4
            dao_old.fields.KEEP_thamu = GET_KEEP_5
            dao_old.fields.KEEP_thasoi = GET_KEEP_6
            dao_old.fields.KEEP_tharoad = GET_KEEP_7
            dao_old.fields.KEEP_thathmblnm = GET_KEEP_8
            dao_old.fields.KEEP_thaamphrnm = GET_KEEP_9
            dao_old.fields.KEEP_thachngwtnm = GET_KEEP_10
            dao_old.fields.KEEP_zipcode = GET_KEEP_11
            dao_old.fields.KEEP_fax = GET_KEEP_12
            dao_old.fields.KEEP_tel = GET_KEEP_13
            dao_old.fields.KEEP_email = GET_KEEP_14
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON7(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON7(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL7_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL7_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.DALCN_BSN_THAIFULLNAME = MODEL.LCN_APPROVE_EDIT_DDL7.BSN_THAIFULLNAME
            dao.fields.BSN_THAIFULLNAME = MODEL.LCN_APPROVE_EDIT_DDL7.BSN_THAIFULLNAME
            dao.fields.PHR_TEXT_JOB = MODEL.LCN_APPROVE_EDIT_DDL7.PHR_TEXT_JOB
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.DALCN_BSN_THAIFULLNAME = MODEL.LCN_APPROVE_EDIT_DDL7.BSN_THAIFULLNAME
            dao.fields.BSN_THAIFULLNAME = MODEL.LCN_APPROVE_EDIT_DDL7.BSN_THAIFULLNAME
            dao.fields.PHR_TEXT_JOB = MODEL.LCN_APPROVE_EDIT_DDL7.PHR_TEXT_JOB
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If

    End Sub
    Sub SET_DATA_OLD_INSERT_REASON7(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'get ตัวเก่า
            Dim dao_main As New DAO_LCN.TB_dalcn
            dao_main.GetDataby_IDA(MODEL.IDA_LCN)

            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_3 As String = ""

            GET_1 = dao_main.fields.BSN_THAIFULLNAME

            Dim dao_bsn As New DAO_LCN.TB_DALCN_LOCATION_BSN
            dao_bsn.GetDataby_LCN_IDA(MODEL.IDA_LCN)
            GET_2 = dao_bsn.fields.BSN_THAIFULLNAME

            Dim dao_phr As New DAO_LCN.TB_DALCN_PHR
            dao_phr.GetDataby_FK_IDA(MODEL.IDA_LCN)
            GET_3 = dao_phr.fields.PHR_TEXT_JOB

            'เซฟตัวเก่า
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL7_REASON
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL7_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.DALCN_BSN_THAIFULLNAME = GET_1
            dao_old.fields.BSN_THAIFULLNAME = GET_2
            dao_old.fields.PHR_TEXT_JOB = GET_3
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON8(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON8(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL8_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL8_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(_lct_ida, ddl1, ddl2, True)
            dao_update.GET_DATA_BY_FK_LCN_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCT
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL8.thanameplace
            dao.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL8.HOUSENO
            dao.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL8.thaaddr
            dao.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL8.thabuilding
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCT_IDA = MODEL.IDA_LCT
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.thanameplace = MODEL.LCN_APPROVE_EDIT_DDL8.thanameplace
            dao.fields.HOUSENO = MODEL.LCN_APPROVE_EDIT_DDL8.HOUSENO
            dao.fields.thaaddr = MODEL.LCN_APPROVE_EDIT_DDL8.thaaddr
            dao.fields.thabuilding = MODEL.LCN_APPROVE_EDIT_DDL8.thabuilding
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If

    End Sub
    Sub SET_DATA_OLD_INSERT_REASON8(ByVal MODEL As MODEL_APP)
        'get ตัวเก่า
        Dim dao1 As New DAO_LCN.TB_DALCN_LOCATION_ADDRESS
        dao1.GetDataby_IDA(MODEL.IDA_LCT)
        Dim GET_1 As String = ""
        Dim GET_2 As String = ""
        Dim GET_3 As String = ""
        Dim GET_4 As String = ""

        GET_1 = dao1.fields.thanameplace
        GET_2 = dao1.fields.HOUSENO
        GET_3 = dao1.fields.thaaddr
        GET_4 = dao1.fields.thabuilding

        'เซฟตัวเก่า
        Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL8_REASON
        Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL8_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update_old.GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(_lct_ida, ddl1, ddl2, True)
            dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update_old.fields.ACTIVE = 0
            dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
            dao_update_old.update()
        End If
        dao_old.fields.FK_IDA = MODEL.IDA
        dao_old.fields.FK_LCT_IDA = MODEL.IDA_LCT
        dao_old.fields.ddl1 = MODEL.ddl1
        dao_old.fields.ddl2 = MODEL.ddl2
        dao_old.fields.thanameplace = GET_1
        dao_old.fields.HOUSENO = GET_2
        dao_old.fields.thaaddr = GET_3
        dao_old.fields.thabuilding = GET_4
        dao_old.fields.CREATE_DATE = System.DateTime.Now
        dao_old.fields.ACTIVE = 1
        dao_old.insert()
    End Sub
    Sub SET_DATA_INSERT_REASON_DDL9_SUB1(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON_DDL9_SUB1(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL9_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL9_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.PERSON_TYPE = 1
            dao.fields.PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL9.PASSPORT_NO
            Try
                dao.fields.PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.PASSPORT_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.BS_NO = MODEL.LCN_APPROVE_EDIT_DDL9.BS_NO
            Try
                dao.fields.BS_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.BS_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.BS_DATE = System.DateTime.Now
            End Try

            dao.fields.WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL9.WORK_LICENSE_NO
            Try
                dao.fields.WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.DOC_NO = MODEL.LCN_APPROVE_EDIT_DDL9.DOC_NO
            Try
                dao.fields.DOC_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.DOC_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.DOC_DATE = System.DateTime.Now
            End Try
            dao.fields.FRGN_NO = MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_NO
            Try
                dao.fields.FRGN_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.FRGN_DATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1

            dao.insert()
        Else
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.PERSON_TYPE = 1
            dao.fields.PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL9.PASSPORT_NO
            Try
                dao.fields.PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.PASSPORT_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.BS_NO = MODEL.LCN_APPROVE_EDIT_DDL9.BS_NO
            Try
                dao.fields.BS_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.BS_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.BS_DATE = System.DateTime.Now
            End Try

            dao.fields.WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL9.WORK_LICENSE_NO
            Try
                dao.fields.WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.DOC_NO = MODEL.LCN_APPROVE_EDIT_DDL9.DOC_NO
            Try
                dao.fields.DOC_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.DOC_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.DOC_DATE = System.DateTime.Now
            End Try
            dao.fields.FRGN_NO = MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_NO
            Try
                dao.fields.FRGN_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.FRGN_DATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If

    End Sub
    Sub SET_DATA_OLD_INSERT_REASON_DDL9_SUB1(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'getตัวเก่า
            Dim dao1 As New DAO_LCN.TB_DALCN_FRGN_DATA
            dao1.GetDataby_FK_IDA_AND_PERSON_TYPE(MODEL.IDA_LCN, 1)

            Dim GET_1 As String = ""
            Dim GET_2 As String = ""
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""
            Dim GET_10 As String = ""

            GET_1 = dao1.fields.PASSPORT_NO

            Dim datefull_PASSPORT_EXPDATE As Date
            Dim PASSPORT_EXPDATE As String = ""

            Try
                'datefull_PASSPORT_EXPDATE = dao1.fields.PASSPORT_EXPDATE
                'PASSPORT_EXPDATE = datefull_PASSPORT_EXPDATE.Day & "/" & datefull_PASSPORT_EXPDATE.Month & "/" & datefull_PASSPORT_EXPDATE.Year
                GET_2 = dao1.fields.PASSPORT_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_3 = dao1.fields.BS_NO
            Dim datefull_BS_DATE As Date
            Dim BS_DATE As String = ""

            Try
                'datefull_BS_DATE = dao1.fields.BS_DATE
                'BS_DATE = datefull_BS_DATE.Day & "/" & datefull_BS_DATE.Month & "/" & datefull_BS_DATE.Year
                GET_4 = dao1.fields.BS_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_5 = dao1.fields.WORK_LICENSE_NO
            Dim datefull_WORK_LICENSE_EXPDATE As Date
            Dim WORK_LICENSE_EXPDATE As String = ""

            Try
                'datefull_WORK_LICENSE_EXPDATE = dao1.fields.WORK_LICENSE_EXPDATE
                'WORK_LICENSE_EXPDATE = datefull_WORK_LICENSE_EXPDATE.Day & "/" & datefull_WORK_LICENSE_EXPDATE.Month & "/" & datefull_WORK_LICENSE_EXPDATE.Year
                GET_6 = dao1.fields.WORK_LICENSE_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_7 = dao1.fields.DOC_NO
            Dim datefull_DOC_DATE As Date
            Dim DOC_DATE As String = ""
            Try
                'datefull_DOC_DATE = dao1.fields.DOC_DATE
                'DOC_DATE = datefull_DOC_DATE.Day & "/" & datefull_DOC_DATE.Month & "/" & datefull_DOC_DATE.Year
                GET_8 = dao1.fields.DOC_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_9 = dao1.fields.FRGN_NO
            Dim datefull_FRGN_DATE As Date
            Dim FRGN_DATE As String = ""

            Try
                'datefull_FRGN_DATE = dao1.fields.FRGN_DATE
                'FRGN_DATE = datefull_FRGN_DATE.Day & "/" & datefull_FRGN_DATE.Month & "/" & datefull_FRGN_DATE.Year
                GET_10 = dao1.fields.FRGN_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            'เซฟตัวเก่า
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL9_REASON
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL9_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If

            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.PERSON_TYPE = 1
            dao_old.fields.PASSPORT_NO = GET_1
            Try
                dao_old.fields.PASSPORT_EXPDATE = DateTime.ParseExact(GET_2, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.PASSPORT_EXPDATE = System.DateTime.Now
            End Try

            dao_old.fields.BS_NO = GET_3
            Try
                dao_old.fields.BS_DATE = DateTime.ParseExact(GET_4, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.BS_DATE = System.DateTime.Now
            End Try

            dao_old.fields.WORK_LICENSE_NO = GET_5
            Try
                dao_old.fields.WORK_LICENSE_EXPDATE = DateTime.ParseExact(GET_6, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try

            dao_old.fields.DOC_NO = GET_7
            Try
                dao_old.fields.DOC_DATE = DateTime.ParseExact(GET_8, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.DOC_DATE = System.DateTime.Now
            End Try

            dao_old.fields.FRGN_NO = GET_9
            Try
                dao_old.fields.FRGN_DATE = DateTime.ParseExact(GET_10, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.FRGN_DATE = System.DateTime.Now
            End Try
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub SET_DATA_INSERT_REASON_DDL9_SUB2(ByVal MODEL As MODEL_APP)
        'เซฟตัวเก่า
        SET_DATA_OLD_INSERT_REASON_DDL9_SUB2(MODEL)

        Dim dao As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL9_REASON
        Dim dao_update As New DAO_LCN.TB_LCN_APPROVE_EDIT_DDL9_REASON
        Dim ROW_CHK As String = ""
        Try
            'dao_update.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
            dao_update.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
            ROW_CHK = "HAVE"
        Catch ex As Exception
            ROW_CHK = "NULL"
        End Try
        If ROW_CHK = "HAVE" Then
            dao_update.fields.ACTIVE = 0
            dao_update.fields.UPDATE_DATE = System.DateTime.Now
            dao_update.update()
        End If
        dao.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        If dao.fields.IDA = 0 Then
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.PERSON_TYPE = 2
            dao.fields.DOC_NO = MODEL.LCN_APPROVE_EDIT_DDL9.DOC_NO
            Try
                dao.fields.DOC_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.DOC_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.DOC_DATE = System.DateTime.Now
            End Try
            dao.fields.FRGN_NO = MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_NO
            Try
                dao.fields.FRGN_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.FRGN_DATE = System.DateTime.Now
            End Try
            dao.fields.GIVE_PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_PASSPORT_NO
            Try
                dao.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try

            dao.fields.GIVE_WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_WORK_LICENSE_NO
            Try
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.insert()
        Else
            dao.fields.FK_IDA = MODEL.IDA
            dao.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao.fields.ddl1 = MODEL.ddl1
            dao.fields.ddl2 = MODEL.ddl2
            dao.fields.PERSON_TYPE = 2
            dao.fields.DOC_NO = MODEL.LCN_APPROVE_EDIT_DDL9.DOC_NO
            Try
                dao.fields.DOC_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.DOC_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.DOC_DATE = System.DateTime.Now
            End Try
            dao.fields.FRGN_NO = MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_NO
            Try
                dao.fields.FRGN_DATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.FRGN_DATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.FRGN_DATE = System.DateTime.Now
            End Try
            dao.fields.GIVE_PASSPORT_NO = MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_PASSPORT_NO
            Try
                dao.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_PASSPORT_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try

            dao.fields.GIVE_WORK_LICENSE_NO = MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_WORK_LICENSE_NO
            Try
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(MODEL.LCN_APPROVE_EDIT_DDL9.GIVE_WORK_LICENSE_EXPDATE, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao.fields.CREATE_DATE = System.DateTime.Now
            dao.fields.ACTIVE = 1
            dao.update()
        End If

    End Sub
    Sub SET_DATA_OLD_INSERT_REASON_DDL9_SUB2(ByVal MODEL As MODEL_APP)
        If MODEL.Detial_Type = 0 Then
            'get ตัวเก่า
            Dim dao1 As New DAO_LCN.TB_DALCN_FRGN_DATA
            dao1.GetDataby_FK_IDA_AND_PERSON_TYPE(MODEL.IDA_LCN, 2)

            Dim GET_1 As String = ""
            Dim GET_2 As DateTime
            Dim GET_3 As String = ""
            Dim GET_4 As DateTime
            Dim GET_5 As String = ""
            Dim GET_6 As DateTime
            Dim GET_7 As String = ""
            Dim GET_8 As DateTime

            GET_1 = dao1.fields.DOC_NO
            Dim datefull_DOC_DATE As Date
            Dim DOC_DATE As String = ""

            Try
                'datefull_DOC_DATE = dao1.fields.DOC_DATE
                'DOC_DATE = datefull_DOC_DATE.Day & "/" & datefull_DOC_DATE.Month & "/" & datefull_DOC_DATE.Year
                GET_2 = dao1.fields.DOC_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try
            GET_3 = dao1.fields.FRGN_NO
            Dim datefull_FRGN_DATE As Date
            Dim FRGN_DATE As String = ""

            Try
                'datefull_FRGN_DATE = dao1.fields.FRGN_DATE
                'FRGN_DATE = datefull_FRGN_DATE.Day & "/" & datefull_FRGN_DATE.Month & "/" & datefull_FRGN_DATE.Year
                GET_4 = dao1.fields.FRGN_DATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            Dim dao2 As New DAO_LCN.TB_dalcn
            dao2.GetDataby_IDA(MODEL.IDA_LCN)

            GET_5 = dao2.fields.GIVE_PASSPORT_NO
            Dim datefull_GIVE_PASSPORT_EXPDATE As Date
            Dim GIVE_PASSPORT_EXPDATE As String = ""

            Try
                'datefull_GIVE_PASSPORT_EXPDATE = dao2.fields.GIVE_PASSPORT_EXPDATE
                'GIVE_PASSPORT_EXPDATE = datefull_GIVE_PASSPORT_EXPDATE.Day & "/" & datefull_GIVE_PASSPORT_EXPDATE.Month & "/" & datefull_GIVE_PASSPORT_EXPDATE.Year
                GET_6 = dao2.fields.GIVE_PASSPORT_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            GET_7 = dao2.fields.GIVE_WORK_LICENSE_NO
            Dim datefull_GIVE_WORK_LICENSE_EXPDATE As Date
            Dim GIVE_WORK_LICENSE_EXPDATE As String = ""

            Try
                'datefull_GIVE_WORK_LICENSE_EXPDATE = dao2.fields.GIVE_WORK_LICENSE_EXPDATE
                'GIVE_WORK_LICENSE_EXPDATE = datefull_GIVE_WORK_LICENSE_EXPDATE.Day & "/" & datefull_GIVE_WORK_LICENSE_EXPDATE.Month & "/" & datefull_GIVE_WORK_LICENSE_EXPDATE.Year
                GET_8 = dao2.fields.GIVE_WORK_LICENSE_EXPDATE
            Catch ex As Exception
                'text_edit_ddl1_SIMINAR_DATE.Text = ""
            End Try

            'เซฟ ตัวเก่า
            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL9_REASON
            Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL9_REASON
            Dim ROW_CHK As String = ""
            Try
                'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_lcn_ida, ddl1, ddl2, True)
                dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
                ROW_CHK = "HAVE"
            Catch ex As Exception
                ROW_CHK = "NULL"
            End Try
            If ROW_CHK = "HAVE" Then
                dao_update_old.fields.ACTIVE = 0
                dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
                dao_update_old.update()
            End If
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_LCN_IDA = MODEL.IDA_LCN
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.PERSON_TYPE = 2
            dao_old.fields.DOC_NO = GET_1
            Try
                dao_old.fields.DOC_DATE = DateTime.ParseExact(GET_2, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.DOC_DATE = System.DateTime.Now
            End Try

            dao_old.fields.FRGN_NO = GET_3
            Try
                dao_old.fields.FRGN_DATE = DateTime.ParseExact(GET_4, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.FRGN_DATE = System.DateTime.Now
            End Try

            dao_old.fields.GIVE_PASSPORT_NO = GET_5
            Try
                dao_old.fields.GIVE_PASSPORT_EXPDATE = DateTime.ParseExact(GET_6, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.GIVE_PASSPORT_EXPDATE = System.DateTime.Now
            End Try

            dao_old.fields.GIVE_WORK_LICENSE_NO = GET_7
            Try
                dao_old.fields.GIVE_WORK_LICENSE_EXPDATE = DateTime.ParseExact(GET_8, "dd/MM/yyyy", New CultureInfo("th-TH").DateTimeFormat)
            Catch ex As Exception
                dao_old.fields.GIVE_WORK_LICENSE_EXPDATE = System.DateTime.Now
            End Try
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        End If
    End Sub
    Sub save_data_OLD_ddl10(ByVal model As MODEL_APP)
        Dim dao_get As New DAO_LCN.TB_DALCN_IMPORT_DRUG_GROUP_HERB_DETAIL
        Try
            dao_get.GetDataby_FKIDA(model.IDA_LCN)
        Catch ex As Exception

        End Try

        Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL10_REASON
        'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(model.IDA_LCN, _ddl1, _ddl2, True)
        dao_update_old.GET_DATA_BY_FK_IDA(model.IDA, True)
        For Each dao_update_old.fields In dao_update_old.datas
            dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
            dao_update_old.fields.UPDATE_BY = ""
            dao_update_old.fields.ACTIVE = 0
            dao_update_old.update()
        Next

        For Each dao_get.fields In dao_get.datas

            Dim GET_1 As Integer = 0
            Dim GET_2 As Integer = 0
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""

            GET_1 = dao_get.fields.FK_IDA
            GET_2 = dao_get.fields.LCN_IDA
            GET_3 = dao_get.fields.COL1
            GET_4 = dao_get.fields.COL2
            GET_5 = dao_get.fields.COL3
            GET_6 = dao_get.fields.COL4
            GET_7 = dao_get.fields.COL5
            GET_8 = dao_get.fields.COL6
            GET_9 = dao_get.fields.COL6_OTHER

            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL10_REASON
            dao_old.fields.ddl1 = model.ddl1
            dao_old.fields.ddl2 = model.ddl2
            dao_old.fields.FK_IDA = model.IDA
            dao_old.fields.FK_IDA_CHK_ROW = GET_1
            dao_old.fields.FK_LCN_IDA = GET_2
            dao_old.fields.COL1 = GET_3
            dao_old.fields.COL2 = GET_4
            dao_old.fields.COL3 = GET_5
            dao_old.fields.COL4 = GET_6
            dao_old.fields.COL5 = GET_7
            dao_old.fields.COL6 = GET_8
            dao_old.fields.COL6_OTHER = GET_9
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.CREATE_BY = ""
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        Next
    End Sub
    Sub save_data_ddl10(ByVal model As MODEL_APP)

    End Sub
    Sub save_data_OLD_ddl11(ByVal MODEL As MODEL_APP)
        Dim dao_get As New DAO_LCN.TB_DALCN_IMPORT_DRUG_GROUP_HERB_DETAIL
        Try
            dao_get.GetDataby_FKIDA(MODEL.IDA_LCN)
        Catch ex As Exception

        End Try
        Dim dao_update_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL11_REASON
        'dao_update_old.GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(_LCN_IDA, _ddl1, _ddl2, True)
        dao_update_old.GET_DATA_BY_FK_IDA(MODEL.IDA, True)
        For Each dao_update_old.fields In dao_update_old.datas
            dao_update_old.fields.UPDATE_DATE = System.DateTime.Now
            dao_update_old.fields.UPDATE_BY = ""
            dao_update_old.fields.ACTIVE = 0
            dao_update_old.update()
        Next

        For Each dao_get.fields In dao_get.datas

            Dim GET_1 As Integer = 0
            Dim GET_2 As Integer = 0
            Dim GET_3 As String = ""
            Dim GET_4 As String = ""
            Dim GET_5 As String = ""
            Dim GET_6 As String = ""
            Dim GET_7 As String = ""
            Dim GET_8 As String = ""
            Dim GET_9 As String = ""

            GET_1 = dao_get.fields.FK_IDA
            GET_2 = dao_get.fields.LCN_IDA
            GET_3 = dao_get.fields.COL1
            GET_4 = dao_get.fields.COL2
            GET_5 = dao_get.fields.COL3
            GET_6 = dao_get.fields.COL4
            GET_7 = dao_get.fields.COL5
            GET_8 = dao_get.fields.COL6
            GET_9 = dao_get.fields.COL6_OTHER

            Dim dao_old As New DAO_LCN.TB_OLD_LCN_APPROVE_EDIT_DDL11_REASON
            dao_old.fields.ddl1 = MODEL.ddl1
            dao_old.fields.ddl2 = MODEL.ddl2
            dao_old.fields.FK_IDA = MODEL.IDA
            dao_old.fields.FK_IDA_CHK_ROW = GET_1
            dao_old.fields.FK_LCN_IDA = GET_2
            dao_old.fields.COL1 = GET_3
            dao_old.fields.COL2 = GET_4
            dao_old.fields.COL3 = GET_5
            dao_old.fields.COL4 = GET_6
            dao_old.fields.COL5 = GET_7
            dao_old.fields.COL6 = GET_8
            dao_old.fields.COL6_OTHER = GET_9
            dao_old.fields.CREATE_DATE = System.DateTime.Now
            dao_old.fields.CREATE_BY = ""
            dao_old.fields.ACTIVE = 1
            dao_old.insert()
        Next
    End Sub
    Sub save_data_ddl11(ByVal MODEL As MODEL_APP)

    End Sub
    Public Function BindTable_lcn(ByVal MODEL As MODEL_APP) As Object
        'Dim clsds As New ClassDataset
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim clsds As New BAO.BAO
        'Dim clsds As New ClassDataset SP_MAS_STATUS_STAFF
        Dim sql As String = ""
        Dim citizen_id As String = ""
        'Dim citizen_id As String = "3901100313466"
        'citizen_id = MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE
        If citizen_id = "" Then
            citizen_id = MODEL.IDEN_SEARCH
            MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE = citizen_id
            MODEL.CITIZEN_AUTHORIZE = citizen_id
            MODEL.STAFF_ID = 1
        End If

        'dt = clsds.SP_GET_DRUG_LCN_IDEN_HERB(citizen_id)
        'dt = clsds.SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDEN(1, citizen_id)
        dt = clsds.SP_CUSTOMER_LCN_BY_IDENTIFY(citizen_id)

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next
        MODEL.CUSTOMER_FILE = DataTableToJSON(dt)
        Return MODEL
    End Function
    Function SEARCH_DATA_CUSTOMER(ByVal MODEL As MODEL_APP)
        Dim txt_NUM As String = ""
        Dim txt_SEARCH As String = ""
        txt_NUM = MODEL.IDEN_SEARCH
        txt_SEARCH = MODEL.NAME_SEARCH
        If MODEL.IDEN_SEARCH <> "" Then
            Dim ws2 As New WS_Taxno_TaxnoAuthorize.WebService1
            Dim a As String = ""
            Try

                a = ws2.insert_taxno_authorize(txt_NUM)
            Catch ex As Exception

            End Try
            Try
                a = ws2.insert_taxno(txt_NUM)
            Catch ex As Exception

            End Try

            Try
                Dim ws1 As New WS_FDA_CITIZEN.WS_FDA_CITIZEN
                ws1.FDA_CITIZEN(txt_NUM, "1102001745831", "fusion", "P@ssw0rdfusion440")
            Catch ex As Exception

            End Try
            Try
                Dim ws3 As New WS_TRADER.WS_TRADER
                ws3.CallWS_TRADER("fusion", "P@ssw0rdfusion440", txt_NUM)
            Catch ex As Exception

            End Try

        End If

        Dim dao As New DAO_CPN.clsDBsyslcnsnm
        dao.GetDataby_thanm(txt_SEARCH)
        'Dim bao As New BAO.BAO
        'Dim dt As New DataTable
        'dt = bao.SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY(txt_SEARCH, txt_NUM)
        Dim bao As New BAO.BAO
        Dim dt As New DataTable
        dt = bao.SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY(txt_SEARCH, txt_NUM)

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        MODEL.FILE_SEARCH = DataTableToJSON(dt)

        Return MODEL.FILE_SEARCH
    End Function

    Public Function BindTable_location(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset
        Dim sql As String = ""
        Dim bao_search As New ClassDataset

        sql = "exec [dbo].[SP_SEARCH_DRUG_LCN_HERB] @thanm='" & MODEL.INFOR_LOCATION_SEARCH.thanm &
            "',@thachngwtnm='" & MODEL.INFOR_LOCATION_SEARCH.thachngwtnm &
            "',@lcnno_noo='" & MODEL.INFOR_LOCATION_SEARCH.lcnno_noo &
            "',@lcnno_display_new='" & MODEL.INFOR_LOCATION_SEARCH.lcnno_display_new & "'"

        Try
            dt = clsds.Queryds_xml_drug_HERB(sql)

            If MODEL.INFOR_LOCATION_SEARCH.thachngwtnm <> "" Then
                dt = bao_search.DatatableWhere(dt, "[thachngwtnm] like '%" & MODEL.INFOR_LOCATION_SEARCH.thachngwtnm & "%' ")
            End If

            If MODEL.INFOR_LOCATION_SEARCH.LOCATION_TYPE IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[typee] like '%" & MODEL.INFOR_LOCATION_SEARCH.LOCATION_TYPE.ToString & "%' ")
            End If

            If MODEL.INFOR_LOCATION_SEARCH.LCO_STATUS IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[cncnm] like '%" & MODEL.INFOR_LOCATION_SEARCH.LCO_STATUS.ToString & "%' ")
            End If

            If MODEL.INFOR_LOCATION_SEARCH.thanm IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[thanm] like '%" & MODEL.INFOR_LOCATION_SEARCH.thanm & "%' ")
            End If

            If MODEL.INFOR_LOCATION_SEARCH.lcnno_noo IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[lcnno_noo] like '%" & MODEL.INFOR_LOCATION_SEARCH.lcnno_noo & "%' ")
            End If

            If MODEL.INFOR_LOCATION_SEARCH.lcnno_display_new IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[lcnno_display_new] like '%" & MODEL.INFOR_LOCATION_SEARCH.lcnno_display_new & "%' ")
            End If

        Catch ex As Exception

        End Try
        Return DataTableToJSON(dt)
    End Function
    Public Function BindTable_dalcn_herb(ByVal MODEL As MODEL_APP) As Object
        Dim dt As New DataTable
        Dim dt1 As New DataTable
        Dim clsds As New BAO_LO.BAO_LO
        'Dim clsds As New ClassDataset
        Dim sql As String = ""
        Dim bao_search As New ClassDataset
        '@ida='" & MODEL.DALCN_SEARCH.IDA & "'
        sql = "exec [dbo].[sp_search_dalcn]"

        Try
            dt = clsds.Queryds_LGT_DRUG(sql)

            If MODEL.DALCN_SEARCH.thachngwtnm IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[thachngwtnm] like '%" & MODEL.DALCN_SEARCH.thachngwtnm & "%' ")
            End If

            If MODEL.DALCN_SEARCH.STATUS_NAME IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[STATUS_NAME] like '%" & MODEL.DALCN_SEARCH.STATUS_NAME & "%' ")
            End If

            If MODEL.DALCN_SEARCH.lcntpcd IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[lcntpcd] like '%" & MODEL.DALCN_SEARCH.lcntpcd & "%' ")
            End If

            If MODEL.DALCN_SEARCH.lcnno_display IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[lcnno_display] like '%" & MODEL.DALCN_SEARCH.lcnno_display & "%' ")
            End If

            If MODEL.DALCN_SEARCH.lcnno_display_new IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[lcnno_display_new] like '%" & MODEL.DALCN_SEARCH.lcnno_display_new & "%' ")
            End If

            If MODEL.DALCN_SEARCH.thanm IsNot Nothing Then
                dt = bao_search.DatatableWhere(dt, "[thanameplace] like '%" & MODEL.DALCN_SEARCH.thanm & "%' ")
            End If

        Catch ex As Exception

        End Try

        Dim index As Integer = 0
        dt.Columns.Add("index")

        For Each item As DataRow In dt.Rows
            index += 1

            item("index") = index
        Next

        Return DataTableToJSON(dt)
    End Function
    Public Function Get_data_kind_licen() As Object
        Dim BAO As New BAO.BAO
        Return DataTableToJSON(BAO.SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD())
    End Function
    Public Function con_date(ByVal str_date As String)

        Dim day_now As String = str_date.Split("/")(0) 'เอาเฉพาะวันที่
        Dim month_now As String = str_date.Split("/")(1) 'เอาเฉพาะเดือนที่
        Dim year_now As String = str_date.Split("/")(2) 'เอาเฉพาะปี
        year_now = year_now.Split(" ")(0) 'ตัดเวลาออก

        If year_now < 2500 Then 'ถ้าเป็น คศ
            year_now = (Integer.Parse(year_now) + 543).ToString() 'ปรับเป็น พศ
        End If

        If String.IsNullOrEmpty(month_now) = False Then 'ถ้าเดือนไม่เป็นค่าว่าง
            'แปลงเป็นชื่อเดือน
            If (month_now = "1") Then
                month_now = "มกราคม"
            ElseIf (month_now = "2") Then
                month_now = "กุมภาพันธ์"
            ElseIf (month_now = "3") Then
                month_now = "มีนาคม"
            ElseIf (month_now = "4") Then
                month_now = "เมษายน"
            ElseIf (month_now = "5") Then
                month_now = "พฤษภาคม"
            ElseIf (month_now = "6") Then
                month_now = "มิถุนายน"
            ElseIf (month_now = "7") Then
                month_now = "กรกฎาคม"
            ElseIf (month_now = "8") Then
                month_now = "สิงหาคม"
            ElseIf (month_now = "9") Then
                month_now = "กันยายน"
            ElseIf (month_now = "10") Then
                month_now = "ตุลาคม"
            ElseIf (month_now = "11") Then
                month_now = "พฤศจิกายน"
            ElseIf (month_now = "12") Then
                month_now = "ธันวาคม"
            End If
        End If

        Dim str_date2 As String = day_now & " " & month_now & " " & year_now

        Return str_date2
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
        'Dim serializer As JavaScriptSerializer = New JavaScriptSerializer()
        'Return serializer.Serialize(list)
    End Function
    Function Get_data_dalcn_detail(ByVal IDA As String) As Object
        Dim MODEL As New MODEL_APP
        Dim sql As String = ""
        Dim sql_1 As String = ""
        Dim dt As DataTable
        Dim dt_1 As DataTable

        Dim BAO_LO As New BAO_LO.BAO_LO

        sql = "exec [dbo].[sp_search_dalcn_ida] @ida= '" & IDA & "'"

        dt = BAO_LO.Queryds_LGT_DRUG(sql)

        For Each dr As DataRow In dt.Rows
            MODEL.DALCN_SEARCH.lcnno_display = dr("LCNNO_DISPLAY")
            MODEL.DALCN_SEARCH.lcnno_display_new = dr("LCNNO_DISPLAY_NEW")
            MODEL.DALCN_SEARCH.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
            MODEL.DALCN_SEARCH.thanm_addr = dr("thanm_addr")
            MODEL.DALCN_SEARCH.thanm = dr("thanm")
            MODEL.DALCN_SEARCH.opentime = dr("opentime")
        Next

        sql = "exec [dbo].[sp_search_dalcn_phr] @ida= '" & IDA & "'"

        dt_1 = BAO_LO.Queryds_LGT_DRUG(sql)

        For Each dr As DataRow In dt_1.Rows
            Dim phr As New PHR
            Try
                'phr.pharmacy_name = dr("pharmacy_name")
                If DBNull.Value.Equals(dr("pharmacy_name")) Then
                    phr.pharmacy_name = "-"
                Else
                    phr.pharmacy_name = dr("pharmacy_name")
                End If

                phr.opentime = dr("opentime")
            Catch ex As Exception

            End Try
            If MODEL.DALCN_SEARCH.phrs.Contains(phr) Then
            Else
                MODEL.DALCN_SEARCH.phrs.Add(phr)
            End If
        Next

        Return MODEL.DALCN_SEARCH
    End Function
End Class
