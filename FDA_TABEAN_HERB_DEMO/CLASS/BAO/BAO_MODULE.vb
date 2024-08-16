Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Module BAO_MODULE

    Public Function GET_BSN_NAME(ByVal BSN_CTZNO As String) As String
        Dim clsxml As New Cls_XML
        Dim ws_c As New WS_GET_CPN.WS_DATA_CENTER
        Dim xml_COM As String = ""
        xml_COM = ws_c.GET_DATA_IDENTIFY(BSN_CTZNO, "0994000165676", "FUSION", "P@ssw0rdfusion440")
        clsxml.ReadData(xml_COM)
        Dim BSN_NAME As String = ""
        If clsxml.Get_Value_XML("thanm") = "" Then
            BSN_NAME = ""
        Else
            BSN_NAME = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm") & " " & clsxml.Get_Value_XML("thalnm")
        End If


        Return BSN_NAME
    End Function
    Public Function CONVERT_CLASS_TOSTRING(ByVal sv_r As Object) As String
        Dim x2 As New XmlSerializer(sv_r.GetType())
        Dim settings As New XmlWriterSettings()
        settings.Encoding = Encoding.UTF8
        settings.Indent = True
        Dim mem2 As New MemoryStream()
        Using writer As XmlWriter = XmlWriter.Create(mem2, settings)
            x2.Serialize(writer, sv_r)
            writer.Flush()
            writer.Close()
        End Using
        Dim B64 As String = ""
        B64 = Convert.ToBase64String(mem2.GetBuffer())


        Dim bytes() As Byte = Convert.FromBase64String(B64)
        Dim mem As New MemoryStream
        mem.Write(bytes, 0, bytes.Length)
        mem.Position = 0

        Dim xmldata As String = ""
        Dim sr2 As StreamReader = New StreamReader(mem) ' Read the memory stream
        xmldata = sr2.ReadToEnd() ' ·Ó¡ÒÃá»Å§¤èÒ BASE64 ·Õèä´é¡ÅÑºÁÒà»ç¹ string

        Return xmldata
    End Function

    Public Function GET_NAME(ByVal IDENTIFY As String) As String
        Dim xml_c As String = ""
        Dim ws_c As New WS_GET_CPN.WS_DATA_CENTER
        xml_c = ws_c.GET_DATA_IDENTIFY(IDENTIFY, "0000000000000", "FUSION", "P@ssw0rdfusion440")
        Dim clsxml As New Cls_XML
        clsxml.ReadData(xml_c)
        Dim p_name As String = clsxml.Get_Value_XML("prefixnm")
        If p_name = "บริษัทจำกัด" Then
            p_name = "บริษัท"
        End If
        Dim CUSTOMER_NAME As String = p_name & " " & clsxml.Get_Value_XML("thanm")
        Return CUSTOMER_NAME
    End Function

    Public Function CHECK_CONDITION_PERSON(ByVal TR_ID As String) As Boolean
        Dim CHK As Boolean = False
        Dim SUM_QTY As Integer = 0

        Dim dao_inv_I As New DAO.TB_INV_ITEM
        dao_inv_I.Getdataby_TR_ID(TR_ID)
        For Each dao_inv_I.fields In dao_inv_I.Details
            If dao_inv_I.fields.PRODUCT_TYPE = "หน้ากาก" Then 'กรณีหน้ากาก
                SUM_QTY = SUM_QTY + dao_inv_I.fields.PRODUCT_QTY
            End If
        Next

        Dim dao_m As New DAO.TB_S_BOX
        dao_m.GETDATA_BY_TR_ID(TR_ID)
        Dim CUSTOMER_CTZNO As String = dao_m.fields.CUSTOMER_CTZNO
        Dim CUSTOMER_IDENTIFY As String = dao_m.fields.CUSTOMER_IDENTIFY
        Dim PRODUCT_GROUP As String = dao_m.fields.PRODUCT_NAME

        Dim dao_p As New DAO.TB_PRODUCT_CONDITION
        dao_p.GETDATABY_IDENTIFY(CUSTOMER_CTZNO, PRODUCT_GROUP)
        For Each dao_p.fields In dao_p.datas
            SUM_QTY = SUM_QTY + dao_p.fields.QTY
        Next

        If SUM_QTY > 200 Then
            CHK = True
        End If
        Return CHK
    End Function

    Public Function HAVE_FILE(ByVal files As String) As Boolean
        Dim chk As Boolean = False
        If File.Exists(files) Then
            chk = True
        Else
            chk = False
        End If
        Return chk
    End Function


    'Public Function GET_ORG_BY_PROCES_ID(ByVal PROCESS_ID As String, ByVal PROCESS_TYPE As String) As String
    '    Dim dao As New DAO.TB_MAS_PROCESS
    '    dao.GETDATA_BY_PROCESS_ID(PROCESS_ID, PROCESS_TYPE)
    '    Return dao.fields.PROCESS_REPORT
    'End Function


    Public Function UPDATE_LPI(ByVal TR_ID As String) As String
        Dim LPI As String = ""
        Dim dao_m As New DAO.TB_S_BOX
        dao_m.GETDATA_BY_TR_ID(TR_ID)

        LPI = GET_LPI(dao_m.fields.IDA)
        dao_m.fields.LPI = LPI
        dao_m.update()
        Return LPI
    End Function


    Public Function GET_LPI(ByVal IDA As Integer) As String
        Dim year As Integer = Date.Now.Year
        If year > 2500 Then 'เป็นพุทธ
            year = Mid(year, 3, 2)
        Else 'เป็นคริส
            year = year + 543
            year = Mid(year, 3, 2)
        End If
        Dim number_LPI As Long = year & 27000000000
        Dim LPI As String = number_LPI + IDA

        Return LPI
    End Function

    Public Sub SendMail(ByVal Content As String, ByVal email As String, ByVal title As String)
        Dim mm As New WS_MAIL.FDA_MAIL
        Dim mcontent As New WS_MAIL.Fields_Mail

        mcontent.EMAIL_CONTENT = Content
        mcontent.EMAIL_FROM = "fda_info@fda.moph.go.th"
        mcontent.EMAIL_PASS = "deeku181"
        mcontent.EMAIL_TILE = title
        mcontent.EMAIL_TO = email

        mm.SendMail(mcontent)
    End Sub
    Public Sub ADD_LICENSE(ByVal TR_ID As String)

        'Dim dao_s As New DAO.TB_S_BOX
        'dao_s.GETDATA_BY_TR_ID(TR_ID)


        'Dim IDA As Integer = dao_s.fields.IDA
        'Dim invno As String = dao_s.fields.INV_NO
        'Dim lcpinv As String = dao_s.fields.LPI

        'Dim dao_imvch As New DAO.NSW.TB_LGT_IMVCH
        'With dao_imvch.fields
        '    .rcvno = lcpinv
        '    .rcvdate = Date.Now
        '    .cptpst = 1
        '    .chkpntcd = 100
        '    .chkdate = Date.Now
        '    .impdate = Date.Now
        '    .invno = invno
        '    .invdate = dao_s.fields.INV_DATE
        '    .lcpinv = lcpinv
        '    .lcnsid = 0
        '    .lcnscd = 1
        '    .lctcd = 1
        '    .lctnmcd = 1

        '    Dim CUS_NAME As String = GET_NAME(dao_s.fields.CUSTOMER_IDENTIFY)
        '    If CUS_NAME = "" Then
        '        .lctnm = dao_s.fields.COMPANY_NAME
        '    Else
        '        .lctnm = CUS_NAME
        '        End If
        '    .ctzno = dao_s.fields.CUSTOMER_IDENTIFY

        '    .cnsdcd = 4 '3 คือ GREEN 4 คือ RED
        '    .cnsddate = Date.Now
        '    .nrow = 0
        '    .signnmcd = 12492
        '    .inspcnsdcd = 0
        '    .stfcd = 0
        '    .rstfcd = 0
        '    .lstfcd = 0
        '    .rmdfdate = Date.Now
        '    .lmdfdate = Date.Now
        '    .Status = 9
        'End With
        'dao_imvch.insert()



        'Dim dao_item As New DAO.TB_INV_ITEM
        'dao_item.Getdataby_TR_ID(TR_ID)
        'Dim rid As Integer = 1
        'For Each dao_item.fields In dao_item.Details
        '    Dim inv_numer As Integer = dao_item.fields.INV_NO

        '    Dim dao_imppd As New DAO.NSW.TB_LGT_IMPPD
        '    With dao_imppd.fields
        '        .rcvno = lcpinv
        '        .rid = rid
        '        .rows = inv_numer
        '        .pdttpcd = 20
        '        .appvno = dao_item.fields.NEWCODE
        '        .thapdnm = dao_item.fields.PRODUCT_NAME
        '        .engpdnm = dao_item.fields.PRODUCT_NAME
        '        .import_count = dao_item.fields.PRODUCT_QTY
        '        'เซ็ท ใช้ หน่วย SET ที่เหลือ UNIT
        '        .import_unit = "19"
        '    End With
        '    dao_imppd.insert()

        '    Dim dao_imppditem As New DAO.NSW.TB_LGT_IMPPDITEM
        '    With dao_imppditem.fields
        '        .rcvno = lcpinv
        '        .rid = rid
        '        .itemno = inv_numer
        '        .qty = dao_item.fields.PRODUCT_QTY
        '        .untcd = 19
        '        .crntvalue = 0
        '        .crntcd = 0
        '        .value = dao_item.fields.PRODUCT_QTY
        '    End With
        '    dao_imppditem.insert()

        '    rid = rid + 1
        'Next

    End Sub

    Public Function COPY_FILE(ByVal INPUT As String, ByVal OUTPUT As String) As Boolean

        Dim chk As Boolean = False
        Try
            File.Copy(INPUT, OUTPUT)
            chk = True
        Catch ex As Exception
            chk = False
        End Try

        Return chk
    End Function
End Module