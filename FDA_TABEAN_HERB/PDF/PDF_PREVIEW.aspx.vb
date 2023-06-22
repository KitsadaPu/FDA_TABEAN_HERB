Public Class PDF_PREVIEW
    Inherits System.Web.UI.Page
    Private _CLS As New CLS_SESSION
    'Private MODEL As New MODEL_APP
    Private IDA As String
    Private TR_ID As String
    Private GROUP_ID As String
    Private PROCESS_ID As String
    Private Newcode As String

    Sub RunSession()
        IDA = Request.QueryString("IDA")
        TR_ID = Request.QueryString("TR_ID")
        GROUP_ID = Request.QueryString("GROUP_ID")
        PROCESS_ID = Request.QueryString("PROCESS_ID")
        Newcode = Request.QueryString("Newcode")
        'Try
        '    _CLS = Session("CLS")
        'Catch ex As Exception
        '    Response.Redirect("http://privus.fda.moph.go.th/")
        'End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RunSession()
        If Not IsPostBack Then
            'PDF_NAME()
            Dim bao_app As New BAO.AppSettings
            If PROCESS_ID = 20610 Then
                Run_Pdf_Tabean_Herb_2_8()
            ElseIf PROCESS_ID = 20620 Then

            ElseIf PROCESS_ID = 20630 Then
                Run_Pdf_Tabean_JJ()
            End If
            Dim filename = _CLS.PDFNAME
            If filename.ToUpper.Contains(".PDF") Then
                filename = filename.Replace(".pdf", "")
            End If
            Try
                'Dim filepath = _CLS.FILENAME_PDF
                'Dim filepath = _CLS.PATH_PDF & "\" & filename & ".pdf"
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
    Public Sub Run_Pdf_Tabean_Herb()
        Dim bao_app As New BAO.AppSettings
        bao_app.RunAppSettings()
        'Dim dao_dg As New DAO_DRUG.ClsDBdrrgt
        'dao_dg.GetDataby_IDA(_IDA)
        Dim dao_dq As New DAO_TABEAN.ClsDBdrrqt
        dao_dq.GetDataby_IDA(IDA)
        Dim dao As New DAO_TABEAN.TB_TABEAN_HERB
        dao.GetdatabyID_FK_IDA_DQ(IDA)
        Dim _PROCESSID As String = dao_dq.fields.PROCESS_ID
        Dim dao_pdftemplate As New DAO_DRUG.ClsDB_MAS_TEMPLATE_PROCESS
        dao_pdftemplate.GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW_AND_GROUP(PROCESS_ID, dao_dq.fields.STATUS_ID, 0, 1)

        Dim _PATH_FILE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB") 'path

        'Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", dao_dq.fields.PROCESS_ID, dao_dq.fields.DATE_YEAR, dao_dq.fields.TR_ID, _IDA, dao_dq.fields.STATUS_ID)
        Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", _PROCESSID, dao_dq.fields.DATE_YEAR, dao_dq.fields.TR_ID, IDA, dao_dq.fields.STATUS_ID)

        _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
        _CLS.PDFNAME = PATH_PDF_OUTPUT
        '_CLS.FILENAME_XML = Path_XML
    End Sub
    Public Sub Run_Pdf_Tabean_Herb_2_8()
        Dim bao_app As New BAO.AppSettings
        bao_app.RunAppSettings()

        Dim dao As New DAO_XML_DRUG_HERB.TB_XML_DRUG_PRODUCT_HERB
        dao.GetDataby_u1_frn_no(Newcode)
        Dim dao_gt As New DAO_TABEAN.ClsDBdrrgt
        dao_gt.GetDataby_4key(dao.fields.rgtno, dao.fields.drgtpcd, dao.fields.rgttpcd, dao.fields.pvncd)
        Dim XML As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
        TBN_NEW = XML.gen_xml_tbn_2_new(Newcode)
        Dim dao_pdftemplate As New DAO_DRUG.ClsDB_MAS_TEMPLATE_PROCESS
        dao_pdftemplate.GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW_AND_GROUP(PROCESS_ID, 8, 0, 1)
        Dim YEAR As String = ""
        YEAR = CDate(Date.Now).Year
        If dao_gt.fields.TR_ID Is Nothing Then
            dao_gt.fields.TR_ID = 0
        End If
        Dim _PATH_FILE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB") 'path
        Dim PATH_PDF_TEMPLATE As String = _PATH_FILE & "PDF_TEMPLATE\" & dao_pdftemplate.fields.PDF_TEMPLATE
        Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", dao_gt.fields.PROCESS_ID, YEAR, dao_gt.fields.TR_ID, dao_gt.fields.IDA, 8)
        Dim Path_XML As String = _PATH_FILE & dao_pdftemplate.fields.XML_PATH & "\" & NAME_XML_TBN("HB_XML", dao_gt.fields.PROCESS_ID, YEAR, dao_gt.fields.TR_ID, dao_gt.fields.IDA, 8)

        LOAD_XML_PDF(Path_XML, PATH_PDF_TEMPLATE, dao_gt.fields.PROCESS_ID, PATH_PDF_OUTPUT)

        _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
        _CLS.PDFNAME = PATH_PDF_OUTPUT
        _CLS.FILENAME_XML = Path_XML

    End Sub

    Public Sub Run_Pdf_Tabean_JJ()
        Dim bao_app As New BAO.AppSettings
        bao_app.RunAppSettings()
        Dim dao As New DAO_TABEAN.TB_TABEAN_JJ
        dao.GetdatabyID_IDA(IDA)
        Dim _ProcessID As String = dao.fields.DDHERB
        Dim dao_pdftemplate As New DAO_DRUG.ClsDB_MAS_TEMPLATE_PROCESS
        dao_pdftemplate.GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW_AND_GROUP(PROCESS_ID, dao.fields.STATUS_ID, 0, 2)

        Dim _PATH_FILE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB") 'path

        'Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", dao_dq.fields.PROCESS_ID, dao_dq.fields.DATE_YEAR, dao_dq.fields.TR_ID, _IDA, dao_dq.fields.STATUS_ID)
        Dim PATH_PDF_OUTPUT As String = _PATH_FILE & dao_pdftemplate.fields.PDF_OUTPUT & "\" & NAME_PDF_TBN("HB_PDF", _ProcessID, dao.fields.DATE_YEAR, dao.fields.TR_ID_JJ, IDA, dao.fields.STATUS_ID)

        _CLS.FILENAME_PDF = PATH_PDF_OUTPUT
        _CLS.PDFNAME = PATH_PDF_OUTPUT
        '_CLS.FILENAME_XML = Path_XML
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