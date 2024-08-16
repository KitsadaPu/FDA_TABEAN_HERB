Imports System.Web.Mvc

Namespace Controllers
    Public Class AUTHENController
        Inherits Controller

        ' GET: AUTHEN
        Function Index() As ActionResult
            Return View()
        End Function

        Function AUTHEN_GATEWAY_STAFF() As ActionResult
            Return View()
        End Function
        Function AUTHEN_GATEWAY_CUSTOMER() As ActionResult
            Return View()
        End Function
        Function NAV_BAR() As ActionResult
            Return View()
        End Function
        Function TOP_PAGE() As ActionResult
            Return View()
        End Function
    End Class
End Namespace