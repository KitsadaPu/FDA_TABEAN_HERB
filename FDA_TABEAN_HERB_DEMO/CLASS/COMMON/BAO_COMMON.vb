Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Xml

Module BAO_COMMON
    ''' <summary>
    ''' สำหรับ ผปก  Upload Pdf แล้ว แปลงเป็น XML
    ''' </summary>
    ''' <param name="PATH_PDF_TRADER"></param>
    ''' <param name="PATH_XML_TRADER"></param>
    ''' <remarks></remarks>
    Public Sub convert_PDF_To_XML(ByVal PATH_PDF_TRADER As String, ByVal PATH_XML_TRADER As String)
        'Dim outputStream As New System.IO.MemoryStream()
        'Dim reader As New PdfReader(PATH_PDF_TRADER)
        'Dim doc As New XmlDocument
        'Dim ob As String
        'ob = reader.AcroFields.Xfa.DatasetsNode.FirstChild.InnerXml
        'doc.LoadXml(ob)
        'doc.Save(PATH_XML_TRADER) '"C:\path\XML_TRADER\"
    End Sub



    ''' <summary>
    ''' นำข้อมูล XML เข้า PDFTEMPLATE แล้วทำการสร้าง PDF ขึ้นมาใหม่
    ''' </summary>
    ''' <param name="PATH_PDF_XML"></param>
    ''' <param name="PATH_XML_TRADER"></param>
    ''' <param name="PATH_PDF_TEMPLATE"></param>
    ''' <remarks></remarks>
    Public Sub convert_XML_To_PDF(ByVal PATH_PDF_XML As String, ByVal PATH_XML_TRADER As String, ByVal PATH_PDF_TEMPLATE As String)
        'Using pdfReader__1 = New PdfReader(PATH_PDF_TEMPLATE) '"C:\path\PDF_TEMPLATE\"
        '    Using outputStream = New FileStream(PATH_PDF_XML, FileMode.Create, FileAccess.Write) '"C:\path\PDF_XML_CLASS\"
        '        Using stamper = New iTextSharp.text.pdf.PdfStamper(pdfReader__1, outputStream, ControlChars.NullChar, True)
        '            stamper.AcroFields.Xfa.FillXfaForm(PATH_XML_TRADER)
        '        End Using
        '    End Using
        'End Using
    End Sub
End Module
