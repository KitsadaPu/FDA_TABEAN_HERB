Namespace DAO_DRUG
    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_DRUG_HERBDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TB_TRANSACTION_UPLOAD
        Inherits MAINCONTEXT

        Public fields As New TRANSACTION_UPLOAD

        Public Sub insert()
            db.TRANSACTION_UPLOADs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.TRANSACTION_UPLOADs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In db.TRANSACTION_UPLOADs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In db.TRANSACTION_UPLOADs Where p.ID = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TR_ID_Process(ByVal tr_id As String, ByVal process_id As String)

            datas = (From p In db.TRANSACTION_UPLOADs Where p.DESCRIPTION = tr_id And p.PROCESS_ID_STR = process_id Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_MAS_STAFF_NAME_HERB
        Inherits MAINCONTEXT

        Public fields As New MAS_STAFF_NAME_HERB

        Public Sub insert()
            db.MAS_STAFF_NAME_HERBs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.MAS_STAFF_NAME_HERBs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.MAS_STAFF_NAME_HERBs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.MAS_STAFF_NAME_HERBs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class ClsDB_MAS_TEMPLATE_PROCESS
        Inherits MAINCONTEXT

        Public fields As New MAS_TEMPLATE_PROCESS

        Public Sub insert()
            db.MAS_TEMPLATE_PROCESSes.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.MAS_TEMPLATE_PROCESSes.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In db.MAS_TEMPLATE_PROCESSes Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetDataby_TEMPLAETE99(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_BY_GROUP_V1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal PREVIEW As Integer, Optional _group As Integer = 0)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_BY_GROUP(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, Optional _group As Integer = 0)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_BY_GROUPV2(ByVal PROCESS_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, Optional _group As Integer = 0)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = PROCESS_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        'Public Sub GetDataby_TEMPLAETE_BY_PROCESS_ID_STATUS(ByVal PROCESS_ID As String, ByVal STATUS As Integer, ByVal group_id As Integer)
        '    datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = STATUS _
        '      And p.GROUPS = group_id And p.PREVIEW =  Select p)
        '    For Each Me.fields In datas

        '    Next
        'End Sub

        Public Sub GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GETDATA_TABEAN_HERB_EX_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_TB_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_TBN_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GETDATA_TABEAN_HERB_TBN_TEMPLAETE_GROUP(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal GROUPS As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.GROUPS = GROUPS Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_APPOINTMENT(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetDataby_TEMPLAETE2(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_GROUP(ByVal P_ID As String, ByVal lcntype As String, ByVal STATUS As Integer, ByVal GROUPS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
             And p.GROUPS = GROUPS And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_GROUP_PREVIEW(ByVal P_ID As String, ByVal STATUS As Integer, ByVal GROUPS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
             And p.GROUPS = GROUPS And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_TABEAN(ByVal PROCESS_ID As String, ByVal STATUS_ID As Integer, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = STATUS_ID _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW_AND_GROUP(ByVal P_ID As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, ByVal _group As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GETDATA_LCN_EDIT_TEMPLAETE(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In db.MAS_TEMPLATE_PROCESSes Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_LOG_STATUS
        Inherits MAINCONTEXT 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

        Public fields As New LOG_STATUS

        Public Sub insert()
            db.LOG_STATUS.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.LOG_STATUS.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataby_IDA(ByVal _IDA As Integer)

            datas = (From p In db.LOG_STATUS Where p.IDA = _IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_STATUS_ID(ByVal _IDA As Integer, ByVal PROCECSS_ID As Integer, ByVal STATUS_ID As Integer)

            datas = (From p In db.LOG_STATUS Where p.FK_IDA = _IDA And p.PROCESS_ID = PROCECSS_ID And p.STATUS_ID = STATUS_ID Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataALL()
            datas = (From p In db.LOG_STATUS Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class ClsDBGEN_RCVNO
        Inherits MAINCONTEXT

        Public fields As New GEN_RCVNO
        Public Sub GetDataby_Year_PVNCD_PROCESS_ID_MAX(ByVal PVNCD As String, ByVal YEARS As Integer, ByVal PROCESS_ID As Integer)
            datas = (From p In db.GEN_RCVNOs Where p.PVNCD = PVNCD And p.YEARS = YEARS And p.PROCESS_ID = PROCESS_ID Order By CInt(p.GEN_RCV) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_Year_PVNCD_PROCESS_ID(ByVal PVNCD As String, ByVal YEARS As Integer, ByVal PROCESS_ID As Integer)
            datas = (From p In db.GEN_RCVNOs Where p.PVNCD = PVNCD And p.YEARS = YEARS And p.PROCESS_ID = PROCESS_ID Order By CInt(p.GEN_RCV) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub insert()
            db.GEN_RCVNOs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.GEN_RCVNOs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In db.GEN_RCVNOs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_RGTNO_MAX_N_NC(ByVal YEAR As String, ByVal PVNCD As String, ByVal IDA As Integer)
            'datas = (From p In db.GEN_NO_01s Where p.IDA = YEAR Order By p.IDA Descending Select p)
            datas = (From p In db.GEN_RCVNOs Where p.PVNCD = PVNCD And p.YEARS = YEAR And (p.GEN_TYPE = "1" Or p.GEN_TYPE = "6") Order By CInt(p.GEN_RCV) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_RGTNO_MAX_NB_NBC(ByVal YEAR As String, ByVal PVNCD As String, ByVal IDA As Integer)
            'datas = (From p In db.GEN_NO_01s Where p.IDA = YEAR Order By p.IDA Descending Select p)
            datas = (From p In db.GEN_RCVNOs Where p.PVNCD = PVNCD And p.YEARS = YEAR And (p.GEN_TYPE = "7" Or p.GEN_TYPE = "B") Order By CInt(p.GEN_RCV) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_RGTNO_MAX(ByVal YEAR As String, ByVal PVNCD As String, ByVal RGTTPCD As String, ByVal IDA As Integer)
            'datas = (From p In db.GEN_NO_01s Where p.IDA = YEAR Order By p.IDA Descending Select p)
            datas = (From p In db.GEN_RCVNOs Where p.PVNCD = PVNCD And p.YEARS = YEAR And p.GEN_TYPE = RGTTPCD Order By CInt(p.GEN_RCV) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LOG_RENEW_HERB
        Inherits MAINCONTEXT

        Public fields As New LOG_RENEW_HERB
        Private _Details As New List(Of LOG_RENEW_HERB)
        Public Property Details() As List(Of LOG_RENEW_HERB)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of LOG_RENEW_HERB))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New LOG_RENEW_HERB
        End Sub
        Public Sub insert()
            db.LOG_RENEW_HERBs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.LOG_RENEW_HERBs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub GetAll()
            datas = (From p In db.LOG_RENEW_HERBs Select p)

        End Sub
    End Class
End Namespace
