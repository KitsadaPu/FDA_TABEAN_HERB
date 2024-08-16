Imports System.Globalization
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Web.Services.Description
Imports System.Xml
Imports System.Xml.Serialization
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Dim MODEL_APP As New MODEL_APP
    Function Upload_Attach(ByVal FileForUpload As FileUpload, ByVal AttachfUp_IDA As String, ByVal TYPE_ID As String, ByVal PROCESS_ID As String, ByVal IDA As String, ByVal CITIZEN_ID As String, ByVal FILE_UPLOAD_TABLE As String, ByVal INDEX As String, ByVal EXPLAIN_IDA As String, ByVal STEP_ As String, ByVal CITIZEN_NAME As String)
        'อัพโหลดไฟล์เเนบบังคับ
        Dim bao As New BAO.AppSettings

        Dim daoAttachfile_update As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
        Dim Page_close_status = 0
        Dim PATH_ATTACH = ""
        Dim list_attach_file As New DataTable
        Dim jss As New JavaScriptSerializer

        Dim jResults = jss.DeserializeObject(FILE_UPLOAD_TABLE)
        Dim result As [String] = jResults("NAME_REAL")
        'Dim msg As [String] = jResults("TOPIC_ID")

        ' list_attach_file = JsonConvert.DeserializeObject(Of DataTable)(FILE_UPLOAD_TABLE)
        MODEL_APP.FILEUPLOADTABLE = FILE_UPLOAD_TABLE

        'Dim main_data As New DAO_LGT_DRUG.TB_CER_HERB_DALCN
        'main_data.GETDATA_BY_IDA(IDA)

        For Each s As String In Request.Files
            Dim check_file As Boolean = True
            Dim postedFile As HttpPostedFileBase = Request.Files(s)
            If Not postedFile.FileName.Contains("pdf") And Not postedFile.FileName.Contains("PDF") Then
                check_file = False

                MODEL_APP.ERR_ALERT = "กรุณาอัพโหลดไฟล์PDFเท่านั้น"
                'Message = Message & " - กรุณาอัพโหลดไฟล์ PDF เท่านั้น"
                Return MODEL_APP.ERR_ALERT
            End If
            Dim TYPE As Integer = CInt(Int(TYPE_ID))
            If check_file = True Then
                daoAttachfile_update.GetdatabyID_IDA(IDA)
                Dim dao_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE
                dao_mas.GetdatabyID_ID(daoAttachfile_update.fields.Document_ID)
                'Dim filename As String = daoAttachfile_update.fields.FilePath & ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                Dim filename As String = dao_mas.fields.PathFile & ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                Dim filenametoupdate As String = ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                daoAttachfile_update.fields.NAME_FAKE = filenametoupdate
                daoAttachfile_update.fields.NAME_REAL = Path.GetFileName(postedFile.FileName)
                If TYPE > 1 Then daoAttachfile_update.fields.TYPE = TYPE Else daoAttachfile_update.fields.TYPE = 1
                daoAttachfile_update.fields.ACTIVE = 1
                daoAttachfile_update.fields.CREATE_DATE = DateTime.Now()
                daoAttachfile_update.fields.Update_Date = DateTime.Now()
                daoAttachfile_update.fields.CitizenUpdateID = CITIZEN_ID
                daoAttachfile_update.fields.FilePath = filename
                daoAttachfile_update.Update()

                jResults("NAME_FAKE") = filenametoupdate
                jResults("NAME_REAL") = Path.GetFileName(postedFile.FileName)
                jResults("CREATE_DATE") = CONVERTTHAIDATE(DateTime.Now())

                Console.WriteLine(filename)

                overWriteFile(filename, postedFile)
                MODEL_APP.ERR_ALERT = "อัพโหลดเรียบร้อย"
                MODEL_APP.FILEUPLOADTABLE = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
                Dim ss2 As String = JsonConvert.SerializeObject(jResults, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
                Return ss2
            End If
        Next
        Return Nothing
    End Function
    Function Upload_Attach_staff(ByVal FileForUpload As FileUpload, ByVal AttachfUp_IDA As String, ByVal TYPE_ID As String, ByVal PROCESS_ID As String, ByVal IDA As String, ByVal CITIZEN_ID As String, ByVal FILE_UPLOAD_TABLE As String, ByVal INDEX As String, ByVal EXPLAIN_IDA As String, ByVal STEP_ As String, ByVal CITIZEN_NAME As String)
        'อัพโหลดไฟล์เเนบบังคับ
        Dim bao As New BAO.AppSettings

        Dim daoAttachfile_update As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
        Dim Page_close_status = 0
        Dim PATH_ATTACH = ""
        Dim list_attach_file As New DataTable
        Dim jss As New JavaScriptSerializer

        Dim jResults = jss.DeserializeObject(FILE_UPLOAD_TABLE)
        Dim result As [String] = jResults("NAME_REAL")
        'Dim msg As [String] = jResults("TOPIC_ID")

        ' list_attach_file = JsonConvert.DeserializeObject(Of DataTable)(FILE_UPLOAD_TABLE)
        MODEL_APP.FILEUPLOADTABLE = FILE_UPLOAD_TABLE

        'Dim main_data As New DAO_LGT_DRUG.TB_CER_HERB_DALCN
        'main_data.GETDATA_BY_IDA(IDA)

        For Each s As String In Request.Files
            Dim check_file As Boolean = True
            Dim postedFile As HttpPostedFileBase = Request.Files(s)
            If Not postedFile.FileName.Contains("pdf") And Not postedFile.FileName.Contains("PDF") Then
                check_file = False

                MODEL_APP.ERR_ALERT = "กรุณาอัพโหลดไฟล์PDFเท่านั้น"
                'Message = Message & " - กรุณาอัพโหลดไฟล์ PDF เท่านั้น"
                Return MODEL_APP.ERR_ALERT
            End If
            Dim TYPE As Integer = CInt(Int(TYPE_ID))
            If check_file = True Then
                daoAttachfile_update.GetdatabyID_IDA(IDA)
                Dim dao_mas As New DAO_TABEAN.TB_MAS_TABEAN_HERB_UPLOADFILE
                dao_mas.GetdatabyID_ID(daoAttachfile_update.fields.Document_ID)
                'Dim filename As String = daoAttachfile_update.fields.FilePath & ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                Dim filename As String = dao_mas.fields.PathFile & ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                Dim filenametoupdate As String = ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                daoAttachfile_update.fields.NAME_FAKE = filenametoupdate
                daoAttachfile_update.fields.NAME_REAL = Path.GetFileName(postedFile.FileName)
                If TYPE > 1 Then daoAttachfile_update.fields.TYPE = TYPE Else daoAttachfile_update.fields.TYPE = 1
                daoAttachfile_update.fields.ACTIVE = 1
                daoAttachfile_update.fields.CREATE_DATE = DateTime.Now()
                daoAttachfile_update.fields.Update_Date = DateTime.Now()
                daoAttachfile_update.fields.CitizenUpdateID = CITIZEN_ID
                daoAttachfile_update.fields.FilePath = filename
                daoAttachfile_update.Update()

                jResults("NAME_FAKE") = filenametoupdate
                jResults("NAME_REAL") = Path.GetFileName(postedFile.FileName)
                jResults("CREATE_DATE") = CONVERTTHAIDATE(DateTime.Now())

                Console.WriteLine(filename)

                overWriteFile(filename, postedFile)
                MODEL_APP.ERR_ALERT = "อัพโหลดเรียบร้อย"
                MODEL_APP.FILEUPLOADTABLE = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
                MODEL_APP.FILEUPLOADTABLE_STAFF = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
                Dim ss2 As String = JsonConvert.SerializeObject(jResults, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
                Return ss2
            End If
        Next
        Return Nothing
    End Function
    'Function Upload_Attach(ByVal FileForUpload As FileUpload, ByVal AttachfUp_IDA As String, ByVal TOPIC_IDA As String, ByVal PROCESS_ID As String, ByVal IDA As String, ByVal CITIZEN_ID As String, ByVal FILE_UPLOAD_TABLE As String, ByVal INDEX As String, ByVal EXPLAIN_IDA As String, ByVal STEP_ As String, ByVal CITIZEN_NAME As String)
    '    'อัพโหลดไฟล์เเนบบังคับ
    '    Dim bao As New BAO.AppSettings

    '    Dim daoAttachfile_update As New DAO_LGT_DRUG.TB_FILE_UPLOAD_CER
    '    Dim Page_close_status = 0
    '    Dim PATH_ATTACH = ""
    '    Dim list_attach_file As New DataTable
    '    Dim jss As New JavaScriptSerializer

    '    Dim jResults = jss.DeserializeObject(FILE_UPLOAD_TABLE)
    '    Dim result As [String] = jResults("NAME_REAL")
    '    'Dim msg As [String] = jResults("TOPIC_ID")

    '    ' list_attach_file = JsonConvert.DeserializeObject(Of DataTable)(FILE_UPLOAD_TABLE)
    '    MODEL_CENTER.FILEUPLOADTABLE = FILE_UPLOAD_TABLE

    '    Dim main_data As New DAO_LGT_DRUG.TB_CER_HERB_DALCN
    '    main_data.GETDATA_BY_IDA(IDA)

    '    For Each s As String In Request.Files
    '        Dim check_file As Boolean = True
    '        Dim postedFile As HttpPostedFileBase = Request.Files(s)
    '        If Not postedFile.FileName.Contains("pdf") And Not postedFile.FileName.Contains("PDF") Then
    '            check_file = False

    '            MODEL_CENTER.Message_MODEL.attachupfmessage = "กรุณาอัพโหลดไฟล์PDFเท่านั้น"
    '            'Message = Message & " - กรุณาอัพโหลดไฟล์ PDF เท่านั้น"
    '            Return MODEL_CENTER.Message_MODEL.attachupfmessage
    '        End If

    '        If check_file = True Then

    '            Dim filename As String = bao._PATH_UPLOAD & ATTACH_NAME_UPLOAD_PDF("Attact", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
    '            Dim filenametoupdate As String = ATTACH_NAME_UPLOAD_PDF("Attact", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
    '            daoAttachfile_update.GETDATA_BY_IDA(IDA)
    '            daoAttachfile_update.fields.NAME_FAKE = filenametoupdate
    '            daoAttachfile_update.fields.NAME_REAL = Path.GetFileName(postedFile.FileName)
    '            'daoAttachfile_update.fields.STATUS_ATTACH = "10"   
    '            'daoAttachfile_update.fields.CITIZEN_ID = CITIZEN_ID
    '            'daoAttachfile_update.field.CITIZEN_NAME = CITIZEN_NAME
    '            daoAttachfile_update.fields.TYPE_ID = 2
    '            daoAttachfile_update.fields.ACTIVE = 1
    '            daoAttachfile_update.fields.CREATE_DATE = DateTime.Now()
    '            daoAttachfile_update.update()


    '            jResults("NAME_FAKE") = filenametoupdate
    '            jResults("NAME_REAL") = Path.GetFileName(postedFile.FileName)
    '            jResults("CREATE_DATE") = CONVERTTHAIDATE(DateTime.Now())

    '            Console.WriteLine(filename)

    '            overWriteFile(filename, postedFile)
    '            MODEL_CENTER.Message_MODEL.attachupfmessage = "อัพโหลดเรียบร้อย"
    '            MODEL_CENTER.FILEUPLOADTABLE = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
    '            Dim ss2 As String = JsonConvert.SerializeObject(jResults, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
    '            Return ss2
    '        End If

    '    Next
    '    'MODEL_CENTER.Message_MODEL.Page_close_status = Page_close_status


    '    Return Nothing
    'End Function

    'Function Upload_Attach_Edit_User(ByVal FileForUpload As FileUpload, ByVal AttachfUp_IDA As String, ByVal TOPIC_IDA As String, ByVal PROCESS_ID As String, ByVal IDA As String, ByVal CITIZEN_ID As String, ByVal FILE_UPLOAD_TABLE As String, ByVal INDEX As String, ByVal EXPLAIN_IDA As String, ByVal STEP_ As String, ByVal CITIZEN_NAME As String)
    '    'อัพโหลดไฟล์เเนบบังคับ
    '    Dim bao As New BAO.AppSettings

    '    Dim daoAttachfile_update As New DAO_LGT_DRUG.TB_FILE_UPLOAD_CER
    '    Dim Page_close_status = 0
    '    Dim PATH_ATTACH = ""
    '    Dim list_attach_file As New DataTable
    '    Dim jss As New JavaScriptSerializer

    '    Dim jResults = jss.DeserializeObject(FILE_UPLOAD_TABLE)
    '    Dim result As [String] = jResults("NAME_REAL")
    '    'Dim msg As [String] = jResults("TOPIC_ID")

    '    ' list_attach_file = JsonConvert.DeserializeObject(Of DataTable)(FILE_UPLOAD_TABLE)
    '    MODEL_CENTER.FILE_ATTACH = FILE_UPLOAD_TABLE

    '    Dim main_data As New DAO_LGT_DRUG.TB_CER_HERB_DALCN
    '    main_data.GETDATA_BY_IDA(IDA)

    '    For Each s As String In Request.Files
    '        Dim check_file As Boolean = True
    '        Dim postedFile As HttpPostedFileBase = Request.Files(s)
    '        If Not postedFile.FileName.Contains("pdf") And Not postedFile.FileName.Contains("PDF") Then
    '            check_file = False

    '            MODEL_CENTER.Message_MODEL.attachupfmessage = "กรุณาอัพโหลดไฟล์PDFเท่านั้น"
    '            'Message = Message & " - กรุณาอัพโหลดไฟล์ PDF เท่านั้น"
    '            Return MODEL_CENTER.Message_MODEL.attachupfmessage
    '        End If

    '        If check_file = True Then

    '            Dim filename As String = bao._PATH_UPLOAD & ATTACH_NAME_UPLOAD_PDF("Attact", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
    '            Dim filenametoupdate As String = ATTACH_NAME_UPLOAD_PDF("Attact", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
    '            daoAttachfile_update.GETDATA_BY_IDA(IDA)
    '            daoAttachfile_update.fields.NAME_FAKE = filenametoupdate
    '            daoAttachfile_update.fields.NAME_REAL = Path.GetFileName(postedFile.FileName)
    '            'daoAttachfile_update.fields.STATUS_ATTACH = "10"   
    '            'daoAttachfile_update.fields.CITIZEN_ID = CITIZEN_ID
    '            'daoAttachfile_update.field.CITIZEN_NAME = CITIZEN_NAME
    '            daoAttachfile_update.fields.TYPE_ID = 3
    '            daoAttachfile_update.fields.ACTIVE = 1
    '            daoAttachfile_update.fields.CREATE_DATE = DateTime.Now()
    '            daoAttachfile_update.update()


    '            jResults("NAME_FAKE") = filenametoupdate
    '            jResults("NAME_REAL") = Path.GetFileName(postedFile.FileName)
    '            jResults("CREATE_DATE") = CONVERTTHAIDATE(DateTime.Now())

    '            Console.WriteLine(filename)

    '            overWriteFile(filename, postedFile)
    '            MODEL_CENTER.Message_MODEL.attachupfmessage = "อัพโหลดเรียบร้อย"
    '            MODEL_CENTER.FILE_ATTACH = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
    '            Dim ss2 As String = JsonConvert.SerializeObject(jResults, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
    '            Return ss2
    '        End If

    '    Next
    '    'MODEL_CENTER.Message_MODEL.Page_close_status = Page_close_status


    '    Return Nothing
    'End Function

    Function Upload_Attach_User(ByVal FileForUpload As FileUpload, ByVal AttachfUp_IDA As String, ByVal PROCESS_ID As String, ByVal IDA As String, ByVal CITIZEN_ID As String, ByVal FILE_UPLOAD_TABLE As String, ByVal INDEX As String)
        'อัพโหลดไฟล์เเนบบังคับ
        Dim bao As New BAO.AppSettings
        'Dim daoAttachfile_update As New DAO_LGT_DRUG.TB_FILE_UPLOAD_CER
        Dim daoAttachfile_update As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE_JJ
        Dim Page_close_status = 0
        Dim PATH_ATTACH = ""
        'PROCESS_ID = "10201"
        Dim list_attach_file As New DataTable
        Dim jss As New JavaScriptSerializer

        Dim jResults = jss.DeserializeObject(FILE_UPLOAD_TABLE)
        Dim result As [String] = jResults("NAME_REAL")
        'Dim msg As [String] = jResults("TOPIC_ID")

        ' list_attach_file = JsonConvert.DeserializeObject(Of DataTable)(FILE_UPLOAD_TABLE)
        MODEL_APP.FILE_ATTACH = FILE_UPLOAD_TABLE

        For Each s As String In Request.Files
            Dim check_file As Boolean = True
            Dim postedFile As HttpPostedFileBase = Request.Files(s)
            If Not postedFile.FileName.Contains("pdf") And Not postedFile.FileName.Contains("PDF") Then
                check_file = False

                MODEL_APP.ERR_ALERT = "กรุณาอัพโหลดไฟล์PDFเท่านั้น"
                'Message = Message & " - กรุณาอัพโหลดไฟล์ PDF เท่านั้น"
                Return MODEL_APP.ERR_ALERT
            End If

            If check_file = True Then
                Dim filename As String = bao._PATH_XML_PDF_TABEAN_SUB & "FILE_UPLOAD\" & ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                Dim filenametoupdate As String = ATTACH_NAME_UPLOAD_PDF("FILE_UPLOAD_HB", PROCESS_ID, Date.Now.Year, IDA, AttachfUp_IDA)
                daoAttachfile_update.GetdatabyID_IDA(IDA)
                daoAttachfile_update.fields.NAME_FAKE = filenametoupdate
                daoAttachfile_update.fields.NAME_REAL = Path.GetFileName(postedFile.FileName)
                daoAttachfile_update.fields.TYPE = 1
                daoAttachfile_update.fields.ACTIVE = 1
                daoAttachfile_update.fields.CREATE_DATE = DateTime.Now()
                daoAttachfile_update.update()

                jResults("NAME_FAKE") = filenametoupdate
                jResults("NAME_REAL") = Path.GetFileName(postedFile.FileName)
                jResults("CREATE_DATE") = CONVERTTHAIDATE(DateTime.Now())

                Console.WriteLine(filename)
                overWriteFile(filename, postedFile)
                MODEL_APP.ERR_ALERT = "อัพโหลดเรียบร้อย"
                MODEL_APP.FILEUPLOADTABLE = JsonConvert.SerializeObject(FILE_UPLOAD_TABLE)
                Dim ss2 As String = JsonConvert.SerializeObject(jResults, New JsonSerializerSettings With {.ReferenceLoopHandling = ReferenceLoopHandling.Ignore})
                Return ss2
            End If
        Next
        'MODEL_APP.Message_MODEL.Page_close_status = Page_close_status

        Return Nothing
    End Function
    Function CONVERTTHAIDATE(ByVal DATEINPUT As DateTime)
        Dim dateThai = DATEINPUT.ToString("dd/MM/yyyy", New CultureInfo("th-TH"))
        Return dateThai
    End Function

    Public Sub overWriteFile(ByVal writePath As String, ByVal fileUpload As HttpPostedFileBase)

        Dim fs = New FileStream(writePath, FileMode.Create, FileAccess.ReadWrite)
        Try
            fileUpload.InputStream.CopyTo(fs)
            fs.Flush()
        Catch ex As Exception
        Finally
            fs.Close()
        End Try
    End Sub

    Public Function ATTACH_NAME_UPLOAD_PDF(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal IDA As String, ByVal RUNING_ID As String) As String

        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & IDA & "-" & RUNING_ID & ".pdf"

        Return filename
    End Function


End Class
