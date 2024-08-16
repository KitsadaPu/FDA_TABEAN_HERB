Namespace DAO_SEARCH

    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_LogsDataContext
        Public datas
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    
    Public Class TB_drrgt
        Inherits MAINCONTEXT
        Public fields As New drrgt
        Public Sub insert()
            db.drrgts.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.drrgts.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.drrgts Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_rgtno(ByVal rgtno As Integer, ByVal rgttpcd As String)
            datas = (From p In db.drrgts Where p.rgtno = rgtno And p.rgttpcd = rgttpcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_dalcn
        Inherits MAINCONTEXT
        Public fields As New dalcn
        Public Sub insert()
            db.dalcns.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.dalcns.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.dalcns Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_lcnno(ByVal lcnno As Integer)
            datas = (From p In db.dalcns Where p.lcnno = lcnno Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_pvncd(ByVal pvncd As Integer)
            datas = (From p In db.dalcns Where p.pvncd = pvncd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_lcnsid(ByVal lcnsid As Integer)
            datas = (From p In db.dalcns Where p.lcnsid = lcnsid Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_syschngwt
        Inherits MAINCONTEXT
        Public fields As New syschngwt
        Public Sub insert()
            db.syschngwts.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.syschngwts.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        'Public Sub GetDataAll()
        '    datas = (From p In db.syschngwts Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In db.syschngwts Where p.thachngwtnm <> "-" Order By p.thachngwtnm Ascending Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_pvncd(ByVal chngwtcd As Integer)
            datas = (From p In db.syschngwts Where p.chngwtcd = chngwtcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_lcnsid(ByVal lcnsid As Integer)
            datas = (From p In db.dalcns Where p.lcnsid = lcnsid Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_sysisocnt
        Inherits MAINCONTEXT
        Public fields As New sysisocnt
        Public Sub insert()
            db.sysisocnts.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.sysisocnts.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        'Public Sub GetDataAll()
        '    datas = (From p In db.sysisocnts Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In db.sysisocnts Order By p.engcntnm Ascending Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_rgtno(ByVal engcntnm As Integer)
            datas = (From p In db.sysisocnts Where p.engcntnm = engcntnm Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class

    Public Class TB_login_system
        Inherits MAINCONTEXT
        Public fields As New LOG_LOGIN_SYSTEM
        Public Sub insert()
            db.LOG_LOGIN_SYSTEMs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.LOG_LOGIN_SYSTEMs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.LOG_LOGIN_SYSTEMs Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class

    Public Class TB_LOG_SEARCH_DRUG_DESCRIPTION
        Inherits MAINCONTEXT
        Public fields As New LOG_SEARCH_DRUG_DESCRIPTION
        Public Sub insert()
            db.LOG_SEARCH_DRUG_DESCRIPTIONs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.LOG_SEARCH_DRUG_DESCRIPTIONs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.LOG_SEARCH_DRUG_DESCRIPTIONs Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class

    Public Class TB_sysamphr
        Inherits MAINCONTEXT
        Public fields As New sysamphr
        Public Sub insert()
            db.sysamphrs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.sysamphrs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            db = (From p In db.sysamphrs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetData_by_chngwtcd_amphrcd(ByVal chngwtcd As Integer, ByVal amphrcd As Integer)
            datas = (From p In db.sysamphrs Where p.chngwtcd = chngwtcd And p.amphrcd = amphrcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_chngwtcd_(ByVal chngwtcd As Integer)
            datas = (From p In db.sysamphrs Where p.chngwtcd = chngwtcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_amphrs_name(ByVal name As Integer)
            datas = (From p In db.sysamphrs Where p.thaamphrnm = name Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_systhmbl
        Inherits MAINCONTEXT
        Public fields As New systhmbl
        Public Sub insert()
            db.systhmbls.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.systhmbls.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub GetDataAll()
            datas = (From p In db.systhmbls Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_chngwtcd_amphrcd_thmblcd(ByVal chngwtcd As Integer, ByVal amphrcd As Integer, ByVal thmblcd As Integer)
            datas = (From p In db.systhmbls Where p.chngwtcd = chngwtcd And p.amphrcd = amphrcd And p.thmblcd = thmblcd Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetData_by_chngwtcd_amphrcd(ByVal chngwtcd As Integer, ByVal amphrcd As Integer)
            datas = (From p In db.systhmbls Where p.chngwtcd = chngwtcd And p.amphrcd = amphrcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_thmbls_name(ByVal name As String)
            datas = (From p In db.systhmbls Where p.thathmblnm = name Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
End Namespace
