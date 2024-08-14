Imports System.Web.Mvc

Namespace Controllers
    Public Class TABEAN_SUBSTITUTEController
        Inherits Controller

        ' GET: Substitute
        Function Index() As ActionResult
            Return View()
        End Function
        Function Substitute_Main() As ActionResult
            Return View()
        End Function
        Function Substitute_Add() As ActionResult
            Return View()
        End Function
        Function Substitute_Confirm() As ActionResult
            Return View()
        End Function
        Function Substitute_Confirm_Detail() As ActionResult
            Return View()
        End Function
        Function Substitute_Choose_Tabean() As ActionResult
            Return View()
        End Function
        Function Substitute_Upload() As ActionResult
            Return View()
        End Function
    End Class
    Public Class TABEAN_SUBSTITUTE_STAFFController
        Inherits Controller

        ' GET: Substitute
        Function Index() As ActionResult
            Return View()
        End Function
        Function Substitute_Staff_Main() As ActionResult
            Return View()
        End Function
        Function Substitute_Staff_Comfirm() As ActionResult
            Return View()
        End Function
        Function Substitute_Staff_Replacement() As ActionResult
            Return View()
        End Function
    End Class
    Public Class TABEAN_RENEWController
        Inherits Controller

        ' GET: Tabean_Renew
        Function Index() As ActionResult
            Return View()
        End Function
        Function Renew_Confirm() As ActionResult
            Return View()
        End Function
        Function Renew_Confirm_Detail() As ActionResult
            Return View()
        End Function
        Function Renew_Main() As ActionResult
            Return View()
        End Function
        Function Renew_Request() As ActionResult
            Return View()
        End Function
        Function Renew_Request_Add() As ActionResult
            Return View()
        End Function
        Function Renew_Upload_file() As ActionResult
            Return View()
        End Function
        Function Renew_Edit_File() As ActionResult
            Return View()
        End Function
    End Class
    Public Class TABEAN_RENEW_STAFFController
        Inherits Controller
        Function Index() As ActionResult
            Return View()
        End Function
        Function Renew_Staff_Confirm() As ActionResult
            Return View()
        End Function
        Function Renew_Staff_Main() As ActionResult
            Return View()
        End Function
        Function Renew_Staff_Edit_File() As ActionResult
            Return View()
        End Function
        Function Renew_Staff_Cancel_Request() As ActionResult
            Return View()
        End Function
        Function Renew_Staff_Edit_Admin() As ActionResult
            Return View()
        End Function
    End Class
End Namespace