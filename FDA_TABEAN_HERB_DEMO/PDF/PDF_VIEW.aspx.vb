Public Class PDF_VIEW
    Inherits System.Web.UI.Page
    Private _CLS As New CLS_SESSION
    'Private MODEL As New MODEL_APP
    Private IDA As String
    Private TR_ID As String
    Private PROCESS_ID As String
    Private IDA_LCN As String

    Sub RunSession()
        IDA = Request.QueryString("IDA")
        TR_ID = Request.QueryString("TR_ID")
        PROCESS_ID = Request.QueryString("PROCESS_ID")
        IDA_LCN = Request.QueryString("IDA_LCN")
        'Try
        '    _CLS = Session("CLS")
        'Catch ex As Exception
        '    Response.Redirect("http://privus.fda.moph.go.th/")
        'End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RunSession()
        If Not IsPostBack Then
            If PROCESS_ID.Contains("207") Then
                BIND_PDF_TABEAN(IDA, PROCESS_ID)
            Else
                PDF_SUB()
            End If

            Dim bao_app As New BAO.AppSettings

            Dim filename = _CLS.PDFNAME
            If filename.ToUpper.Contains(".PDF") Then
                filename = filename.Replace(".pdf", "")
            End If
            Try
                'Dim filepath = _CLS.FILENAME_PDF
                Dim filepath = _CLS.PATH_PDF & "\" & filename & ".pdf"
                ' Dim filepath = bao_app._PATH_PDF_TEMPLATE & filename & ".pdf"
                Dim clsds As New ClassDataset
                load_pdf2(filepath)
            Catch ex As Exception
                Try
                    'Dim filepath = "D:\path\XML_PDF_CER\PDF_TEMPLATE\" & filename & ".pdf"
                    'Dim filepath = "D:\path\XML_PDF_CER\PDF_TEMPLATE\" & filename & ".pdf"
                    Dim filepath = _CLS.FILENAME_PDF
                    Dim clsds As New ClassDataset
                    load_pdf2(filepath)
                Catch ex2 As Exception

                End Try
            End Try
        End If
    End Sub

    'Public Sub PDF_NAME()
    '    Dim bao As New BAO.AppSettings
    '    Dim IDA_CER As Integer = IDA


    '    Dim cer_lcn As New DAO_LGT_DRUG.TB_CER_HERB_DALCN
    '    cer_lcn.GETDATA_BY_IDA(IDA_CER)

    '    Dim dao_pdftemplate As New DAO_LGT_DRUG.TB_MAS_TEMPLATE_PROCESS_CER
    '    If cer_lcn.fields.PROCESS_ID = 10601 Then
    '        dao_pdftemplate.GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(cer_lcn.fields.PROCESS_ID, cer_lcn.fields.STATUS_ID, "GMP", 0)
    '    ElseIf cer_lcn.fields.PROCESS_ID = 10602 Then
    '        dao_pdftemplate.GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(cer_lcn.fields.PROCESS_ID, cer_lcn.fields.STATUS_ID, "FMP", 0)
    '    End If

    '    Dim paths As String = bao._PATH_DEFAULT
    '    Dim PDF_TEMPLATE As String = paths & "PDF_TEMPLATE\" & dao_pdftemplate.fields.PDF_TEMPLATE
    '    Dim PATH_PDF_OUTPUT As String = paths & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF("CER", cer_lcn.fields.PROCESS_ID, cer_lcn.fields.YEAR, cer_lcn.fields.TR_ID, IDA_CER)
    '    Dim Path_XML As String = paths & dao_pdftemplate.fields.XML_PATH & "\" & NAME_XML("CER", cer_lcn.fields.PROCESS_ID, cer_lcn.fields.YEAR, cer_lcn.fields.TR_ID, IDA_CER)
    '    Dim file_name As String = NAME_PDF("CER", cer_lcn.fields.PROCESS_ID, cer_lcn.fields.YEAR, cer_lcn.fields.TR_ID, IDA_CER)
    '    Dim PATH_PDF As String = paths & dao_pdftemplate.fields.PDF_OUTPUT

    '    _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
    '    _CLS.PDFNAME = file_name
    '    _CLS.FILENAME_XML = Path_XML
    '    _CLS.PATH_PDF = PATH_PDF
    '    lr_preview.Text = "<iframe id='iframe1'  style='height:800px;width:100%;' src='../PDF/FRM_PDF.aspx?fileName=" & PATH_PDF_OUTPUT & "' ></iframe>"
    'End Sub
    Public Sub PDF_SUB()
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_SUBSTITUTE
        dao.GetdatabyID_IDA(IDA)
        Dim IDA_LCN As String = dao.fields.FK_LCN
        Dim _YEAR As String = dao.fields.YEAR
        Dim _tr_id_xml As String = dao.fields.TR_ID
        Dim _StatusID As String = dao.fields.STATUS_ID
        Dim Process_ID As String = dao.fields.PROCESS_ID
        Dim XML As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_SUBSTITUTE
        TBN_SUB = XML.Gen_XML_SUBSTITUTE_TBN(IDA, IDA_LCN, _YEAR)

        Dim dao_pdftemplate As New DAO_DRUG.ClsDB_MAS_TEMPLATE_PROCESS
        dao_pdftemplate.GETDATA_TABEAN_HERB_TBN_TEMPLAETE_GROUP(Process_ID, dao.fields.STATUS_ID, "บท", 0)

        Dim _PATH_FILE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB") 'path
        Dim PATH_PDF_TEMPLATE As String = _PATH_FILE & "PDF_TEMPLATE\" & dao_pdftemplate.fields.PDF_TEMPLATE
        Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", Process_ID, dao.fields.YEAR, dao.fields.TR_ID, IDA, dao.fields.STATUS_ID)
        Dim Path_XML As String = _PATH_FILE & dao_pdftemplate.fields.XML_PATH & "\" & NAME_XML_TBN("HB_XML", Process_ID, dao.fields.YEAR, dao.fields.TR_ID, IDA, dao.fields.STATUS_ID)

        LOAD_XML_PDF(Path_XML, PATH_PDF_TEMPLATE, Process_ID, PATH_PDF_OUTPUT)

        _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
        _CLS.PDFNAME = PATH_PDF_OUTPUT
        _CLS.FILENAME_XML = Path_XML
        'lr_preview.Text = "<iframe id='iframe1'  style='height:800px;width:100%;' src='../PDF/FRM_PDF.aspx?fileName=" & PATH_PDF_OUTPUT & "' ></iframe>"
    End Sub
    Sub BIND_PDF_TABEAN(ByVal IDA As Integer, ByVal PRocess_ID As Integer)
        Dim dao As New DAO_TABEAN.TB_TABEAN_RENEW
        dao.GetdatabyID_IDA(IDA)
        Dim IDA_LCN As Integer = 0
        Try
            IDA_LCN = dao.fields.FK_LCN
        Catch ex As Exception
            IDA_LCN = 0
        End Try
        Dim XML As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_RENEW
        If PRocess_ID = 20710 Then
            If dao.fields.IDA = 0 Then
                TBN_RENEW = XML.Gen_XML_RENREW_TBN_NON_IDA(IDA, IDA_LCN)
            Else
                TBN_RENEW = XML.Gen_XML_RENREW_TBN(IDA, dao.fields.FK_IDA, IDA_LCN)
            End If
        ElseIf PRocess_ID = 20720 Then

        ElseIf PRocess_ID = 20730 Then
            If dao.fields.IDA = 0 Then
                'TBN_RENEW = Gen_XML_RENREW_JJ_NON_IDA(IDA, IDA_LCN)
            Else
                TBN_RENEW = XML.Gen_XML_RENREW_JJ(IDA, dao.fields.FK_IDA, dao.fields.FK_LCN)
            End If

        End If

        Dim dao_pdftemplate As New DAO_DRUG.ClsDB_MAS_TEMPLATE_PROCESS
        If dao.fields.IDA = 0 Then
            dao_pdftemplate.GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(PRocess_ID, 0, "ตอ", 0)
        Else
            dao_pdftemplate.GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(PRocess_ID, dao.fields.STATUS_ID, "ตอ", 0)
        End If
        Dim dao_m As New DAO_TABEAN.TB_MAS_TYPE_REQUESTS_HERB
        dao_m.GetData_By_PROCESS_ID(PRocess_ID)
        Dim _PATH_FILE As String = ""
        Try
            _PATH_FILE = dao_m.fields.PathFile_Upload
        Catch ex As Exception
            _PATH_FILE = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_RENEW") 'path
        End Try
        'Dim _PATH_FILE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_RENEW") 'path
        Dim PATH_PDF_TEMPLATE As String = _PATH_FILE & "PDF_TEMPLATE\" & dao_pdftemplate.fields.PDF_TEMPLATE
        Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF("HB_PDF", PRocess_ID, Date.Now.Year, IDA)
        Dim Path_XML As String = _PATH_FILE & dao_pdftemplate.fields.XML_PATH & "\" & NAME_XML("HB_XML", PRocess_ID, Date.Now.Year, IDA)

        LOAD_XML_PDF(Path_XML, PATH_PDF_TEMPLATE, PRocess_ID, PATH_PDF_OUTPUT)

        _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
        _CLS.PDFNAME = PATH_PDF_OUTPUT
        _CLS.FILENAME_XML = Path_XML

    End Sub
    Private Sub load_pdf(ByVal FilePath As String)
        Response.ContentType = "Application/pdf"
        Response.WriteFile(FilePath)
        Response.End()
    End Sub

    Private Sub load_pdf2(ByVal FilePath As String)

        Dim clsds As New ClassDataset
        Dim ws_F As New WS_FLATTEN.WS_FLATTEN
        Dim b_o As Byte()
        'If Request.QueryString("status") = "1" Then
        '    b_o = ws_F.PDF_DIGITAL_SIGN(bb)
        'Else
        Dim bb As Byte()
        bb = clsds.UpLoadImageByte(FilePath)

        b_o = ws_F.FlattenPDF_DIGITAL(bb)
        Response.Clear()
        Response.ContentType = "Application/pdf"
        'Response.AddHeader("Content-Disposition", "attachment; filename=" & "ADVERFOOD" & ".pdf")
        Response.BinaryWrite(b_o)
        'Response.WriteFile(FilePath)
        Response.Flush()
        Response.End()

    End Sub
End Class