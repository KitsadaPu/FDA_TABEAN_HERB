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
<<<<<<<< HEAD:FDA_TABEAN_HERB_NEW/Controllers/AUTHENController.vb
        Function AUTHEN_GATEWAY_CUSTOMER() As ActionResult
========
        Function AUTHEN_GATEWAY_CUSTOMMER() As ActionResult
>>>>>>>> 5ea1ad78a7a4d702f4c22e17424ee87d07bc9d38:FDA_TABEAN_HERB_DEMO/Controllers/AUTHENController.vb
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