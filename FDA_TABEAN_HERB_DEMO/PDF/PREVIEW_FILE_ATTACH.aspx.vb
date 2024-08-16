Public Class PREVIEW_FILE_ATTACH
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim bao As New BAO.AppSettings
            Dim IDA = Request.QueryString("Path_ID")
            Dim dao As New DAO_TABEAN.TB_TABEAN_HERB_UPLOAD_FILE
            dao.GetdatabyID_IDA(IDA)
            Dim Path_file As String = dao.fields.FilePath
            Try
                Dim clsds As New ClassDataset
                load_pdf(Path_file)
            Catch ex As Exception
                Try
                    Dim clsds As New ClassDataset
                    load_pdf(Path_file)
                Catch ex2 As Exception

                End Try
            End Try
        End If
    End Sub

    Private Sub load_pdf(ByVal FilePath As String)
        Response.ContentType = "Application/pdf"
        Response.WriteFile(FilePath)
        Response.End()
    End Sub

End Class
