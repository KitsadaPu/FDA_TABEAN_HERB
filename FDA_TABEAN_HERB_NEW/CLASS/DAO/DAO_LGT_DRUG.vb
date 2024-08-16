Namespace DAO_LGT_DRUG
    Public MustInherit Class MAINCONTEXT2
        Public dbpage As New Linq_LGT_DRUGDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TB_SET_PAGE_MAIN_SEARCH
        Inherits MAINCONTEXT2
        Public fields As New SET_PAGE_MAIN_SEARCH

        Private _Details As New List(Of SET_PAGE_MAIN_SEARCH)
        Public Property Details() As List(Of SET_PAGE_MAIN_SEARCH)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_MAIN_SEARCH))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_MAIN_SEARCH
        End Sub

        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_MAIN_SEARCHes Where p.ACTIVEFACT = 1 Order By p.RID Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class
    Public Class TB_SET_PAGE_MAIN_CER
        Inherits MAINCONTEXT2
        Public fields As New SET_PAGE_MAIN_CER

        Private _Details As New List(Of SET_PAGE_MAIN_CER)
        Public Property Details() As List(Of SET_PAGE_MAIN_CER)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_MAIN_CER))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_MAIN_CER
        End Sub
        Public Sub GETDATA_BY_ID_POEPLE(ByVal ID As Integer)
            datas = (From p In dbpage.SET_PAGE_MAIN_CERs Where p.TYPE_PEOPLE = ID Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_MAIN_CERs Where p.ACTIVEFACT = 1 Order By p.RID Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class

    Public Class TB_SET_PAGE_SUB_MAIN_SEARCH
        Inherits MAINCONTEXT2
        Public fields As New SET_PAGE_SUB_MAIN_SEARCH

        Private _Details As New List(Of SET_PAGE_SUB_MAIN_SEARCH)
        Public Property Details() As List(Of SET_PAGE_SUB_MAIN_SEARCH)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_SEARCH))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_SUB_MAIN_SEARCH
        End Sub
        Public Sub GETDATA_BY_ID_POEPLE(ByVal ID As Integer)
            datas = (From p In dbpage.SET_PAGE_SUB_MAIN_SEARCHes Where p.TYPE_PEOPLE = ID Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_SUB_MAIN_SEARCHes Where p.ACTIVEFACT = 1 Order By p.RID Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class

    Public Class TB_SET_PAGE_SUB_MAIN_CER
        Inherits MAINCONTEXT2
        Public fields As New SET_PAGE_SUB_MAIN_CER

        Private _Details As New List(Of SET_PAGE_SUB_MAIN_CER)
        Public Property Details() As List(Of SET_PAGE_SUB_MAIN_CER)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_CER))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_SUB_MAIN_CER
        End Sub
        Public Sub GETDATA_BY_ID_POEPLE(ByVal ID As Integer)
            datas = (From p In dbpage.SET_PAGE_SUB_MAIN_CERs Where p.TYPE_PEOPLE = ID Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_SUB_MAIN_CERs Where p.ACTIVEFACT = 1 Order By p.RID Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class
    Public Class TB_CER_HERB
        Inherits MAINCONTEXT2
        Public fields As New CER_HERB
        Private _Details As New List(Of CER_HERB)
        Public Property Details() As List(Of CER_HERB)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of CER_HERB))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New CER_HERB
        End Sub
        Public Sub insert()
            dbpage.CER_HERBs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.CER_HERBs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.CER_HERBs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        'Public Sub GETDATA_BY_FK_IDA(ByVal FK_IDA As String)
        '    datas = (From p In dbpage.CER_HERBs Where p.FK_IDA = FK_IDA Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.CER_HERBs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
    Public Class TB_CER_HERB_DALCN
        Inherits MAINCONTEXT2
        Public fields As New CER_HERB_LCN
        Private _Details As New List(Of CER_HERB_LCN)
        Public Property Details() As List(Of CER_HERB_LCN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of CER_HERB_LCN))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New CER_HERB_LCN
        End Sub
        Public Sub insert()
            dbpage.CER_HERB_LCNs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.CER_HERB_LCNs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.CER_HERB_LCNs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_rcvno_last_type(ByVal process_id As Integer)
            Dim chk = Year(Date.Now)
            If chk < 2500 Then
                chk += 543
            End If
            Dim chk2 = Right(chk, 2) & "00000"
            datas = (From p In dbpage.CER_HERB_LCNs Where p.PROCESS_ID = process_id And Not p.REF_CODE Is Nothing Order By p.REF_CODE.Substring(14, 18) Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        'Public Sub GETDATA_BY_FK_IDA(ByVal FK_IDA As String)
        '    datas = (From p In dbpage.CER_HERB_LCNs Where p.FK_IDA = FK_IDA Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.CER_HERB_LCNs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
    Public Class TB_dalcn
        Inherits MAINCONTEXT2
        Public fields As New dalcn
        Private _Details As New List(Of dalcn)
        Public Property Details() As List(Of dalcn)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of dalcn))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New dalcn
        End Sub

        Public Sub insert()
            dbpage.dalcns.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.dalcns.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.dalcns Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TR_ID(ByVal IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.TR_ID = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA_STATUS(ByVal IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = IDA And p.cnccscd Is Nothing Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_lcnsid(ByVal lcnsid As Integer)

            datas = (From p In dbpage.dalcns Where p.lcnsid = lcnsid Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal FK_IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA_and_PROCESS_ID(ByVal _IDA As Integer, ByVal PROCESS_ID As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = _IDA And p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = 8 Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID(ByVal FK_IDA As Integer, ByVal PROCESS_ID As Integer)

            datas = (From p In dbpage.dalcns Where p.FK_IDA = FK_IDA And p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = 8 Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_4(ByVal FK_IDA As Integer, ByVal PROCESS_ID_1 As Integer, ByVal PROCESS_ID_2 As Integer, ByVal PROCESS_ID_3 As Integer, ByVal PROCESS_ID_4 As Integer)
            datas = (From p In dbpage.dalcns Where p.FK_IDA = FK_IDA And p.STATUS_ID = 8 And (p.PROCESS_ID = PROCESS_ID_1 Or p.PROCESS_ID = PROCESS_ID_2 Or p.PROCESS_ID = PROCESS_ID_3 Or p.PROCESS_ID = PROCESS_ID_4) Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataEditby_IDEN(ByVal iden As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = iden And p.STATUS_ID = 8 And (p.lcntpcd = "ขย1" Or p.lcntpcd = "ขย2" Or p.lcntpcd = "ขย3" Or p.lcntpcd = "ขย4" Or p.lcntpcd = "นย1" Or p.lcntpcd = "ผย1" Or p.lcntpcd = "ขยบ" Or p.lcntpcd = "นยบ" Or p.lcntpcd = "ผยบ") Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDEN(ByVal iden As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = iden And p.STATUS_ID = 8 Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_AND_IDEN(ByVal IDEN As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.STATUS_ID = 8 And
                (p.PROCESS_ID = 105 Or p.PROCESS_ID = 106 Or p.PROCESS_ID = 108 Or p.PROCESS_ID = 109) Select p Order By p.IDA Descending)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_AND_IDEN2(ByVal IDEN As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.STATUS_ID = 8 And (p.lcntpcd = "นย1" Or p.lcntpcd = "ผย1" Or p.lcntpcd = "นยบ" Or p.lcntpcd = "ผยบ" Or p.lcntpcd = "นย8" Or p.lcntpcd = "ผย8" Or p.lcntpcd = "นยบ8" Or p.lcntpcd = "ผยบ8") Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_AND_IDEN3(ByVal IDEN As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.STATUS_ID = 8 And (p.lcntpcd = "ขย1" Or p.lcntpcd = "ขย2" Or p.lcntpcd = "ขย3" Or p.lcntpcd = "ขย4") Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_AND_IDEN4(ByVal IDEN As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.STATUS_ID = 8 And (p.lcntpcd = "ขยบ" Or p.lcntpcd = "นยบ" Or p.lcntpcd = "ผยบ") Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_and_PROCESS_ID_AND_IDEN5(ByVal IDEN As String)
            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = IDEN And p.STATUS_ID = 8 And (p.lcntpcd = "ผยส" Or p.lcntpcd = "นยส" Or p.lcntpcd = "สยส") Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_lcnsid_lcnno(ByVal lcnsid As Integer, ByVal lcnno As Integer)

            datas = (From p In dbpage.dalcns Where p.lcnsid = lcnsid And p.lcnno = lcnno Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TRANSECTION_ID_UPLOAD(ByVal TRANSECTION_ID_UPLOAD As Integer)

            datas = (From p In dbpage.dalcns Where p.TRANSECTION_ID_UPLOAD = TRANSECTION_ID_UPLOAD Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_IDA_ID(ByVal IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_citi_lcnno_lcntpcd(ByVal citi As String, ByVal lcnno As String, ByVal lcnt As String)

            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = citi And p.lcnno = lcnno And p.lcntpcd = lcnt Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_citi_lcnno(ByVal citi As String, ByVal lcnno As String)

            datas = (From p In dbpage.dalcns Where p.CITIZEN_ID_AUTHORIZE = citi And p.lcnno = lcnno Select p Order By p.IDA Ascending)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_pvncd_lcnno_lcntpcd(ByVal pvncd As String, ByVal lcnno As String, ByVal lcntpcd As String)

            datas = (From p In dbpage.dalcns Where p.pvncd = pvncd And p.lcnno = lcnno And p.lcntpcd = lcntpcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Friend Sub GetDataby_IDA()
            Throw New NotImplementedException()
        End Sub
    End Class
    Public Class TB_DALCN_LOCATION_ADDRESS
        Inherits MAINCONTEXT2 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

        Public fields As New DALCN_LOCATION_ADDRESS

        Public Sub insert()
            dbpage.DALCN_LOCATION_ADDRESSes.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_LOCATION_ADDRESSes.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_LOCATION_ADDRESSes Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_ADDRESSes Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TR_ID(ByVal TR_ID As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_ADDRESSes Where p.TR_ID = TR_ID Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_ADDRESSes Where p.FK_IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_MAS_TEMPLATE_PROCESS_CER
        Inherits MAINCONTEXT2

        Public fields As New MAS_TEMPLATE_PROCESS_CER

        Public Sub insert()
            dbpage.MAS_TEMPLATE_PROCESS_CERs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.MAS_TEMPLATE_PROCESS_CERs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE99(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_GROUP_PREVIEW(ByVal P_ID As String, ByVal STATUS As Integer, ByVal GROUPS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
             And p.GROUPS = GROUPS And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_BY_GROUP(ByVal P_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, Optional _group As Integer = 0)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_BY_GROUPV2(ByVal PROCESS_ID As Integer, ByVal lcntype As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, Optional _group As Integer = 0)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = PROCESS_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GETDATA_TABEAN_HERB_JJ_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_TB_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_TBN_TEMPLAETE1(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GETDATA_TABEAN_HERB_APPOINTMENT(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal lcntype As String, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        'Public Sub GetDataby_TEMPLAETE_BY_PROCESS_ID_STATUS(ByVal PROCESS_ID As String, ByVal STATUS As Integer, ByVal group_id As Integer)
        '    datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = STATUS _
        '      And p.GROUPS = group_id And p.PREVIEW =  Select p)
        '    For Each Me.fields In datas

        '    Next
        'End Sub
        Public Sub GetDataby_TEMPLAETE2(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_GROUP(ByVal P_ID As String, ByVal lcntype As String, ByVal STATUS As Integer, ByVal GROUPS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.LCNTYPECD = lcntype And p.STATUS_ID = STATUS _
             And p.GROUPS = GROUPS And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW(ByVal P_ID As Integer, ByVal STATUS As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_TABEAN(ByVal PROCESS_ID As String, ByVal STATUS_ID As Integer, ByVal PREVIEW As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = STATUS_ID _
              And p.PREVIEW = PREVIEW Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_TEMPLAETE_and_P_ID_and_STATUS_and_PREVIEW_AND_GROUP(ByVal P_ID As String, ByVal STATUS As Integer, ByVal PREVIEW As Integer, ByVal _group As Integer)
            datas = (From p In dbpage.MAS_TEMPLATE_PROCESS_CERs Where p.PROCESS_ID = P_ID And p.STATUS_ID = STATUS _
              And p.PREVIEW = PREVIEW And p.GROUPS = _group Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class

    Public Class TB_TRANSACTION_ID_CER
        Inherits MAINCONTEXT2

        Public fields As New TRANSACTION_ID_CER

        Public Sub insert()
            dbpage.TRANSACTION_ID_CERs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.TRANSACTION_ID_CERs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.TRANSACTION_ID_CERs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.TRANSACTION_ID_CERs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        'Public Sub GetDataby_TR_ID_Process(ByVal tr_id As String, ByVal process_id As String)

        '    datas = (From p In dbpage.TRANSACTION_ID_CERs Where p.DESCRIPTION = tr_id And p.PROCESS_ID_STR = process_id Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
    End Class
    Public Class TB_DALCN_LOCATION_BSN
        Inherits MAINCONTEXT2 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

        Public fields As New DALCN_LOCATION_BSN

        Public Sub insert()
            dbpage.DALCN_LOCATION_BSNs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_LOCATION_BSNs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_LOCATION_BSNs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_BSNs Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_LCN_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_BSNs Where p.LCN_IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Function COUNT_LCN_IDA(ByVal IDA As Integer) As Integer
            Dim i As Integer = 0
            datas = (From p In dbpage.DALCN_LOCATION_BSNs Where p.LCN_IDA = IDA Select p)
            For Each Me.fields In datas
                i += 1
            Next
            Return i
        End Function
        Public Sub Getdata_by_fk_id2(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_BSNs Where p.LCN_IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub Getdata_by_iden(ByVal iden As String)

            datas = (From p In dbpage.DALCN_LOCATION_BSNs Where p.BSN_IDENTIFY = iden Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class

    Public Class TB_MAS_UPLOAD_FILE_CER
        Inherits MAINCONTEXT2
        Public fields As New MAS_UPLOAD_FILE_CER
        Private _Details As New List(Of MAS_UPLOAD_FILE_CER)
        Public Property Details() As List(Of MAS_UPLOAD_FILE_CER)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_UPLOAD_FILE_CER))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_UPLOAD_FILE_CER
        End Sub
        Public Sub insert()
            dbpage.MAS_UPLOAD_FILE_CERs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.MAS_UPLOAD_FILE_CERs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.MAS_UPLOAD_FILE_CERs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GETDATA_BY_ID(ByVal ID As Integer)
            datas = (From p In dbpage.MAS_UPLOAD_FILE_CERs Where p.HEAD_ID = ID Select p)
            For Each Me.fields In datas
            Next
        End Sub

        'Public Sub GETDATA_BY_FK_IDA(ByVal FK_IDA As String)
        '    datas = (From p In dbpage.CER_HERBs Where p.FK_IDA = FK_IDA Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.MAS_UPLOAD_FILE_CERs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class


    Public Class TB_FILE_UPLOAD_CER
        Inherits MAINCONTEXT2
        Public fields As New FILE_UPLOAD_CER
        Private _Details As New List(Of FILE_UPLOAD_CER)
        Public Property Details() As List(Of FILE_UPLOAD_CER)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of FILE_UPLOAD_CER))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New FILE_UPLOAD_CER
        End Sub
        Public Sub insert()
            dbpage.FILE_UPLOAD_CERs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.FILE_UPLOAD_CERs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.FILE_UPLOAD_CERs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GETDATA_BY_FK_IDA(ByVal FK_IDA As String)
            datas = (From p In dbpage.FILE_UPLOAD_CERs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GETDATA_BY_FK_IDA_AND_TR_ID(ByVal FK_IDA As Integer, ByVal TR_ID As Integer)
            datas = (From p In dbpage.FILE_UPLOAD_CERs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GETDATA_BY_FK_IDA_AND_TR_ID_AND_TYPE(ByVal FK_IDA As Integer, ByVal TR_ID As Integer, ByVal TYPE_ID As Integer)
            datas = (From p In dbpage.FILE_UPLOAD_CERs Where p.FK_IDA = FK_IDA And p.TYPE_ID = TYPE_ID And p.TR_ID = TR_ID Select p)
            For Each Me.fields In datas
            Next
        End Sub


        Public Sub GETDATA_BY_HEAD_ID_AND_FK(ByVal ID As String, ByVal FK_IDA As Integer)
            datas = (From p In dbpage.FILE_UPLOAD_CERs Where p.HEAD_ID = ID Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.FILE_UPLOAD_CERs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_CER_PRODUCTION_MODEL_DETAIL
        Inherits MAINCONTEXT2
        Public fields As New CER_PRODUCTION_MODEL_DETAIL
        Private _Details As New List(Of CER_PRODUCTION_MODEL_DETAIL)
        Public Property Details() As List(Of CER_PRODUCTION_MODEL_DETAIL)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of CER_PRODUCTION_MODEL_DETAIL))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New CER_PRODUCTION_MODEL_DETAIL
        End Sub
        Public Sub insert()
            dbpage.CER_PRODUCTION_MODEL_DETAILs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.CER_PRODUCTION_MODEL_DETAILs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.CER_PRODUCTION_MODEL_DETAILs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        'Public Sub GETDATA_BY_ID(ByVal ID As Integer)
        '    datas = (From p In dbpage.CER_PRODUCTION_MODEL_DETAILs Where p.HEAD_ID = ID Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub

        'Public Sub GETDATA_BY_FK_IDA(ByVal FK_IDA As String)
        '    datas = (From p In dbpage.CER_HERBs Where p.FK_IDA = FK_IDA Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.CER_PRODUCTION_MODEL_DETAILs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL
        Inherits MAINCONTEXT2
        Public fields As New CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL
        Private _Details As New List(Of CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL)
        Public Property Details() As List(Of CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL))
                _Details = value
            End Set
        End Property
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New CER_CRITERIA_USE_IN_AUDIT_CER_DETAIL
        End Sub
        Public Sub insert()
            dbpage.CER_CRITERIA_USE_IN_AUDIT_CER_DETAILs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.CER_CRITERIA_USE_IN_AUDIT_CER_DETAILs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.CER_CRITERIA_USE_IN_AUDIT_CER_DETAILs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataAll()
            datas = (From p In dbpage.CER_CRITERIA_USE_IN_AUDIT_CER_DETAILs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

End Namespace