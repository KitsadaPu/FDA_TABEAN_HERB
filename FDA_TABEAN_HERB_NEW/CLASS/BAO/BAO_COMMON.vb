Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Xml
Imports FDA_CERTIFICATE_HERB.XML_CENTER

Module BAO_COMMON
    Public _PATH_FILE_DRUG As String = System.Configuration.ConfigurationManager.AppSettings("PATH_FILE_DRUG")
    <System.Runtime.CompilerServices.Extension()>
    Public Sub DropDownSelectData(ByRef Dropdown As DropDownList, ByVal Value As String)
        '   Dropdown.DataBind()
        For Each LT As ListItem In Dropdown.Items
            If LT.Value = Value Then
                LT.Selected = True
            Else
                LT.Selected = False
            End If
        Next
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub DropDownSelectText(ByRef Dropdown As DropDownList, ByVal Value As String)
        '   Dropdown.DataBind()
        For Each LT As ListItem In Dropdown.Items
            If LT.Text = Value Then
                LT.Selected = True
            Else
                LT.Selected = False
            End If
        Next
    End Sub
    Public _PATH_DEFALUT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_DEFALUT")

    Public Class AppSettings
        Public _PATH_PDF_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")
        Public _PATH_PDF_DOWNLOAD As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_DOWNLOAD")
        Public _PATH_PDF_DOWNLOAD_REF As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_DOWNLOAD_REF")

        Sub RunAppSettings()
            _PATH_PDF_TEMPLATE = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")
            _PATH_PDF_DOWNLOAD = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_DOWNLOAD")

        End Sub
    End Class


    ''' <summary>
    ''' ใช้สำหรับการสร้างชื่อ File PDF
    ''' </summary>
    ''' <param name="SYS"></param>
    ''' <param name="PROSESS_ID"></param>
    ''' <param name="YEAR"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function LOAD_XML()


    End Function

    Private _p_cer As New CLASS_CER_LCN
    Public Property p_cer() As CLASS_CER_LCN
        Get
            Return _p_cer
        End Get
        Set(ByVal value As CLASS_CER_LCN)
            _p_cer = value
        End Set
    End Property
    Private _TBN_SUB As New CLASS_DR_SUB
    Public Property TBN_SUB() As CLASS_DR_SUB
        Get
            Return _TBN_SUB
        End Get
        Set(ByVal value As CLASS_DR_SUB)
            _TBN_SUB = value
        End Set
    End Property
    Private _TBN_NEW As CLASS_DR_HERB
    Public Property TBN_NEW() As CLASS_DR_HERB
        Get
            Return _TBN_NEW
        End Get
        Set(ByVal value As CLASS_DR_HERB)
            _TBN_NEW = value
        End Set
    End Property
    Private _TBN_RENEW As CLASS_DR_RENEW
    Public Property TBN_RENEW() As CLASS_DR_RENEW
        Get
            Return _TBN_RENEW
        End Get
        Set(ByVal value As CLASS_DR_RENEW)
            _TBN_RENEW = value
        End Set
    End Property
    'Private _TB_SMP3 As New CLS_LCN_EDIT_SMP3
    'Public Property TB_SMP3() As CLS_LCN_EDIT_SMP3
    '    Get
    '        Return _TB_SMP3
    '    End Get
    '    Set(ByVal value As CLS_LCN_EDIT_SMP3)
    '        _TB_SMP3 = value
    '    End Set
    'End Property

    ''' <summary>
    ''' ProcessID 
    ''' 1 = สถานที่
    ''' 5 = สบ 5
    ''' </summary>
    ''' <param name="PATH_XML">ที่อยู่ XML ที่ต้องใช้</param>
    ''' <param name="PATH_PDF_TEMPLATE">ที่อยู่ PDF TEMPLATE ที่ต้องใช้</param>
    ''' <param name="PROSESS_ID">รหัส Process</param>
    ''' <param name="PATH_PDF_OUTPUT">PDF ที่ต้องออกมาใช้งาน</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LOAD_XML_PDF(ByVal PATH_XML As String, ByVal PATH_PDF_TEMPLATE As String, ByVal PROSESS_ID As Integer, PATH_PDF_OUTPUT As String, Optional filename As String = "", Optional ByVal SUBSTITUTE As String = "", Optional STATUS_ID As String = "", Optional temps As String = "") As String

        If Checkfile(PATH_PDF_OUTPUT) = False Then
            'ตรวจสอบว่ามี XML มั้ย
            If Checkfile(PATH_XML) = False Then
                If PROSESS_ID = "10201" Then
                    'Dim cls_xml As New CLASS_GEN_XML.LCN_CENTER.LCN_EDIT_SMP3
                    'cls_xml.GEN_XML_LCN_EDIT(PATH_XML, _TB_SMP3)
                    'elseIf PROSESS_ID = 10601 Then
                    '    'ส่ง PATH_XML ไป GEN XML
                    '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                    '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                    'ElseIf PROSESS_ID = 10602 Then
                    '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                    '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                    'ElseIf PROSESS_ID = 40301 Then
                    '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                    '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                    'ElseIf PROSESS_ID = 40401 Then
                    '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                    '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                ElseIf PROSESS_ID = "20101" Or PROSESS_ID = "1400001" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                    cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                ElseIf PROSESS_ID = "20102" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                    cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                ElseIf PROSESS_ID = "20103" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                    cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                ElseIf PROSESS_ID = "20104" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                    cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                ElseIf PROSESS_ID = "20610" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_SUBSTITUTE
                    cls_xml.GEN_XML_TABEAN_SUB(PATH_XML, TBN_SUB)
                ElseIf PROSESS_ID = "20620" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_SUBSTITUTE
                    cls_xml.GEN_XML_TABEAN_SUB(PATH_XML, TBN_SUB)
                ElseIf PROSESS_ID = "20630" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_SUBSTITUTE
                    cls_xml.GEN_XML_TABEAN_SUB(PATH_XML, TBN_SUB)
                ElseIf PROSESS_ID = "20710" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_RENEW
                    cls_xml.GEN_XML_TABEAN_RENEW(PATH_XML, TBN_RENEW)
                ElseIf PROSESS_ID = "20720" Then
                    Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_RENEW
                    cls_xml.GEN_XML_TABEAN_RENEW(PATH_XML, TBN_RENEW)
                ElseIf PROSESS_ID = "20730" Then
                End If


            Else
                'If PROSESS_ID = 10601 Then
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                'ElseIf PROSESS_ID = 10602 Then
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                'ElseIf PROSESS_ID = 40301 Then
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                'ElseIf PROSESS_ID = 40401 Then
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)
                'End If
            End If
            'ตรวจสอบว่ามี PDF มั้ย
            Dim ws_platten As New WS_FLATTEN.WS_FLATTEN
            Dim renderedbytes As Byte() = Nothing

            Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"
                    Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                        stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                    End Using
                End Using
            End Using
        Else
            If PROSESS_ID = 10601 Then 'คือสถานที่
                '    'ส่ง PATH_XML ไป GEN XML
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CER
                '    cls_xml.GEN_XML_CER_LCN(PATH_XML, LCN_CER)

                '    Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                '        Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"
                '            Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                '                stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                '            End Using
                '        End Using
                '    End Using
                'ElseIf PROSESS_ID = "10201" Then
                '    Dim cls_xml As New CLASS_GEN_XML.LCN_CENTER.LCN_EDIT_SMP3
                '    cls_xml.GEN_XML_TABEAN_SMP3(PATH_XML, _TB_SMP3)

                '    Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                '        Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                '            Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                '                stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                '            End Using

                '        End Using
                '    End Using
            ElseIf PROSESS_ID = "20101" Or PROSESS_ID = "1400001" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            ElseIf PROSESS_ID = "20102" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            ElseIf PROSESS_ID = "20103" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            ElseIf PROSESS_ID = "20104" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_HERB_TBN
                cls_xml.GEN_XML_TABEAN_TBN(PATH_XML, _TBN_NEW)
                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            ElseIf PROSESS_ID = "20610" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_SUBSTITUTE
                cls_xml.GEN_XML_TABEAN_SUB(PATH_XML, TBN_SUB)
                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            ElseIf PROSESS_ID = "20710" Or PROSESS_ID = "20720" Or PROSESS_ID = "20730" Then
                Dim cls_xml As New CLASS_GEN_XML.TABEAN_CENTER.TABEAN_RENEW
                cls_xml.GEN_XML_TABEAN_RENEW(PATH_XML, TBN_RENEW)

                Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) 'C:\path\PDF_TEMPLATE\
                    Using outputStream = New FileStream(PATH_PDF_OUTPUT, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"

                        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
                            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML)
                        End Using

                    End Using
                End Using
            End If
        End If
        Return PATH_PDF_OUTPUT
    End Function
    Function con_year(ByVal _year As String)
        Dim int_year As Integer = Convert.ToInt32(_year)
        If int_year <= 2500 Then
            int_year += 543
        End If
        Return int_year.ToString()
    End Function
    Function con_year_2() As String
        Dim int_year As Integer = Integer.Parse(Date.Now.Year)
        If int_year <= 2500 Then
            int_year += 543
        End If
        Return int_year.ToString()
    End Function
    Public Sub AddLogStatus(ByVal status_id As Integer, ByVal process_id As String, ByVal iden As String, ByVal iden_select As String, ByVal STAFF_NAME As String, ByVal STAFF_NAME_SELECT As String, Optional FK_IDA As Integer = 0)
        Try
            Dim dao As New DAO_DRUG.TB_LOG_STATUS
            dao.fields.IDENTIFY = iden
            dao.fields.IDENTIFY_SELECT = iden_select
            dao.fields.STAFF_NAME = STAFF_NAME
            dao.fields.STAFF_NAME_SELECT = STAFF_NAME_SELECT
            dao.fields.PROCESS_ID = process_id
            dao.fields.STATUS_DATE = Date.Now
            dao.fields.STATUS_ID = status_id
            dao.fields.FK_IDA = FK_IDA
            dao.insert()
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' ดึงสกุลไฟล์แนบ
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetExtension(ByVal filename As String) As String
        Dim extension As String() = filename.Split(".")
        Dim extension_name As String = extension(extension.Length - 1)
        Return extension_name
    End Function

    Public Function Checkfile(ByVal Path As String) As Boolean
        Dim b As Boolean = System.IO.File.Exists(Path)
        Return b
    End Function

    Public Function NAME_PDF(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".pdf"

        Return filename
    End Function
    Public Function NAME_XML(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".xml"

        Return filename
    End Function
    Public Function NAME_PDF_SMP3(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer, ByVal STATUS_ID As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & STATUS_ID & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".pdf"

        Return filename
    End Function
    Public Function NAME_XML_SMP3(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer, ByVal STATUS_ID As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & STATUS_ID & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".xml"

        Return filename
    End Function
    Public Function NAME_PDF_TBN(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer, ByVal STATUS_ID As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & STATUS_ID & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".pdf"

        Return filename
    End Function
    Public Function NAME_PDF(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & ID_TRANSECTION_UPLOAD.Trim() & ".pdf"

        Return filename
    End Function
    Public Function NAME_XML(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & ID_TRANSECTION_UPLOAD.Trim() & ".xml"

        Return filename
    End Function
    Public Function NAME_XML_TBN(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer, ByVal STATUS_ID As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & STATUS_ID & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".xml"

        Return filename
    End Function
    Public Function NAME_PDF_APPOINTMENT(ByVal SYS As String, ByVal PROSESS_ID As String, ByVal YEAR As String, ByVal ID_TRANSECTION_UPLOAD As String, ByVal IDA As Integer, ByVal STATUS_ID As Integer) As String
        Dim filename As String = SYS & "-" & PROSESS_ID & "-" & con_year(YEAR) & "-" & STATUS_ID & "-" & ID_TRANSECTION_UPLOAD.Trim() & "-" & IDA & ".pdf"

        Return filename
    End Function

    Private _LCN_CER As CLASS_CER_LCN
    Public Property LCN_CER() As CLASS_CER_LCN
        Get
            Return _LCN_CER
        End Get
        Set(ByVal value As CLASS_CER_LCN)
            _LCN_CER = value
        End Set
    End Property
End Module