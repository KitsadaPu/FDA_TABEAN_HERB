Imports System.Web.Mvc
Imports System.IO
Imports System.Xml
Imports iTextSharp.text.pdf
Imports System.Xml.Serialization
Imports System.Drawing

Namespace Controllers
    Public Class CENTER_VIEWController
        Inherits Controller

        ' GET: CENTER_VIEW
        Function Index() As ActionResult
            Return View()
        End Function


        Function PREVIEW_PDF_BYPATH(ByVal PATH As String) As ActionResult
            Dim CLS As New Cls_XML

            If PATH <> "" Then
                If Not IsNothing(PATH) Then
                    Session("PATH_PDF") = PATH
                    Try
                        Response.Clear()
                        Response.ContentType = "Application/pdf"
                        Response.WriteFile(PATH)
                        Response.Flush()
                        Response.End()
                    Catch ex As Exception
                        Response.Clear()
                        Response.Write("ไม่พบไฟล์")
                        Response.Flush()
                        Response.End()
                    End Try
                Else
                    Response.Clear()
                    Response.Write("ไม่พบไฟล์")
                    Response.Flush()
                    Response.End()

                End If
            Else
                Response.Clear()
                Response.Write("ไม่พบไฟล์")
                Response.Flush()
                Response.End()
            End If

            Return View()


        End Function

    End Class
End Namespace