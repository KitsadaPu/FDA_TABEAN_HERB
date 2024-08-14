Imports System.Data.SqlClient

Namespace bao_search
    Public Class connection_db
        Public Function Queryds_xml(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XMLConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function

        Public Function Queryds_cpn(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function

        Public Function Queryds_cmt(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_CMTConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
    End Class

    Public Class cmt
        Inherits connection_db

        Public Function sp_search_cmt(ByVal brand As String, ByVal product As String, ByVal thanm As String, ByVal regnos As String, ByVal pvncd As String, ByVal cnsdcd As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec [dbo].[SP_SEARCH_CMT] @brand = '" & brand & "',@Product = '" & product & "',@thanm_T = '" & thanm & "',@regnos = '" & regnos & "',@pvncd_p = '" & pvncd & "',@cnsdcd='" & cnsdcd & "'"

            dt = Queryds_xml(qstr)

            Return dt
        End Function

        Public Function SP_SHOWPDF_cmtfrgn(ByVal ida As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_SHOWPDF_cmtfrgn @IDA=" & ida

            dt = Queryds_cmt(qstr)

            Return dt
        End Function

        Public Function SP_getcmtlctnmrqt_by_lctnmno(ByVal lctnmno As String, ByVal lcnsid As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_getcmtlctnmrqt_by_lctnmno @lctnmno='" & lctnmno & "',@lcnsid='" & lcnsid & "'"

            dt = Queryds_cmt(qstr)

            Return dt
        End Function
    End Class

    Public Class cpn
        Inherits connection_db

        Public Function SP_MAINCOMPANY_LCNSID(ByVal lcnsid As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAINCOMPANY_LCNSID @lcnsid=" & lcnsid & ",@lctcd=1"

            dt = Queryds_cpn(qstr)

            Return dt
        End Function

        Public Function Get_Type_Hello(ByVal regnos As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "select * from openquery(lgtcmt,'select cr.regnos,cri.brandtha,cri.brandeng,cri.producttha,cri.producteng"
            qstr &= ",cr.cmttypecd,cr.lcnsid,pre.cmtpretha, di.cmtdiftha,cat.cmtcattha,body.cmtbodtha "
            qstr &= "from lgt_cmtrqt cr join lgt_cmtrqtitem cri on cr.rcvno = cri.rcvno and cr.pvncd = cri.pvncd "
            qstr &= "join lgt_cmtcode ctcode on ctcode.cmtcodecd = cri.cmtcodecd "
            qstr &= "join lgt_cmtpreparation pre on ctcode.cmtprecd = pre.cmtprecd "
            qstr &= "Join lgt_cmtdifinition di on ctcode.cmtdifcd = di.cmtdifcd "
            qstr &= "join lgt_cmtcategory cat on ctcode.cmtcatcd = cat.cmtcatcd "
            qstr &= "join lgt_cmtusebody body on body.cmtbodcd = ctcode.cmtbodcd "
            qstr &= "where cr.regnos=" & regnos & " and cr.cnsdcd=1;')"

            dt = Queryds_cpn(qstr)

            Return dt
        End Function
    End Class

End Namespace
