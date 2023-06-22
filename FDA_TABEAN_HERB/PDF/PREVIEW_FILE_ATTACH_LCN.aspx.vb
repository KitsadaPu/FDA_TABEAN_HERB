Public Class PREVIEW_FILE_ATTACH_LCN
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim bao As New BAO.AppSettings
            Dim filename = Request.QueryString("filename")
            'Dim filename = "Certificate_1.pdf"
            If filename.ToUpper.Contains(".PDF") Then
                filename = filename.Replace(".pdf", "")
            End If
            Try
                Dim filepath = bao._PATH_XML_PDF_TABEAN_SUB & "FILE_UPLOAD\" & filename & ".pdf"
                Dim clsds As New ClassDataset
                load_pdf(filepath)
            Catch ex As Exception
                Try
                    Dim filepath = "D:\path\XML_PDF_CER_NEW\FILE_UPLOAD\" & filename & ".pdf"
                    Dim clsds As New ClassDataset
                    load_pdf(filepath)
                Catch ex2 As Exception

                End Try
            End Try

            'Try
            '    Response.Clear()
            '    Response.ContentType = "Application/pdf"
            '    Response.AddHeader("Content-Disposition", "attachment; filename=" & filename)
            '    Response.BinaryWrite(clsds.UpLoadImageByte(bao_app._PATH_FILE & "UPLOAD\" & filename & ".pdf")) '"C:\path\PDF_XML_CLASS\" ดึงเฉพาะไฟล์แนบเพิ่มเติม


            '    Response.Flush()
            '    Response.Close()
            '    Response.End()
            'Catch ex As Exception

            'End Try
        End If
        'Try
        '    Dim clsds As New ClassDataset
        '    Response.Clear()
        '    Response.ContentType = "Application/pdf"
        '    Response.AddHeader("Content-Disposition", "attachment; filename=" & filename)
        '    Response.BinaryWrite(clsds.UpLoadImageByte(filename)) '"C:\path\PDF_XML_CLASS\"
        '    If (Response.IsClientConnected) Then
        '        Response.Flush()
        '        Response.Close()
        '        Response.End()
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub load_pdf(ByVal FilePath As String)
        Response.ContentType = "Application/pdf"
        Response.WriteFile(FilePath)
        Response.End()
    End Sub

End Class