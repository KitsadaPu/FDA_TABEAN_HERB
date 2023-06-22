Namespace DAO_LCN
    Public MustInherit Class MAINCONTEXT
        Public dbpage As New LINQ_LCNDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TB_SET_PAGE_MAIN_LCN
        Inherits MAINCONTEXT
        Public fields As New SET_PAGE_MAIN_LCN

        Private _Details As New List(Of SET_PAGE_MAIN_LCN)
        Public Property Details() As List(Of SET_PAGE_MAIN_LCN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_MAIN_LCN))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_MAIN_LCN
        End Sub

        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_MAIN_LCNs Where p.ACTIVEFACT IsNot Nothing Or p.ACTIVEFACT <> 0 Order By p.IDA Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class
    Public Class TB_SET_PAGE_SUB_MAIN_LCN
        Inherits MAINCONTEXT
        Public fields As New SET_PAGE_SUB_MAIN_LCN

        Private _Details As New List(Of SET_PAGE_SUB_MAIN_LCN)
        Public Property Details() As List(Of SET_PAGE_SUB_MAIN_LCN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_LCN))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_SUB_MAIN_LCN
        End Sub

        Public Sub GetDataAll()
            datas = (From p In dbpage.SET_PAGE_SUB_MAIN_LCNs Where p.ACTIVEFACT IsNot Nothing Or p.ACTIVEFACT <> 0 Order By p.IDA Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
        Public Sub GetDataby_SYSTEM_ID(ByVal SYSTEM_ID As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = SYSTEM_ID Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_dalcn
        Inherits MAINCONTEXT

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
        Public Sub GetDataby_IDA_and_PROCESS_ID(ByVal _IDA As Integer, ByVal PROCESS_ID As Integer)

            datas = (From p In dbpage.dalcns Where p.IDA = _IDA And p.PROCESS_ID = PROCESS_ID And p.STATUS_ID = 8 Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal FK_IDA As Integer)

            datas = (From p In dbpage.dalcns Where p.FK_IDA = FK_IDA Select p)
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
        Public Sub GetDataby_lcnno_new(ByVal Lcnno_new As String)

            datas = (From p In dbpage.dalcns Where p.LCNNO_DISPLAY_NEW = Lcnno_new Select p)
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
    Public Class TB_WHO_DALCN
        Inherits MAINCONTEXT

        Public fields As New WHO_DALCN

        Public Sub insert()
            datas.WHO_DALCNs.InsertOnSubmit(fields)
            datas.SubmitChanges()
        End Sub

        Public Sub Update()
            datas.SubmitChanges()
        End Sub

        Public Sub Delete()
            datas.WHO_DALCNs.DeleteOnSubmit(fields)
            datas.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In dbpage.WHO_DALCNs Select p)
        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In dbpage.WHO_DALCNs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_IDEN(ByVal IDEN As String)
            datas = From p In dbpage.WHO_DALCNs Where p.IDENTIFY = IDEN Select p
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetdatabyID_FK_LCN(ByVal FK_LCN As Integer)
            datas = From p In dbpage.WHO_DALCNs Where p.FK_LCN = FK_LCN Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_FK_LCN_IDEN(ByVal FK_LCN As Integer, ByVal IDEN As String)
            datas = From p In dbpage.WHO_DALCNs Where p.FK_LCN = FK_LCN And p.IDENTIFY = IDEN Select p

            For Each Me.fields In datas

            Next
        End Sub
        'Public Sub GetdatabyID_IDA_LCN_ID_AND_TR_ID(ByVal IDA As Integer, ByVal TR_ID As Integer, ByVal LCN_ID As Integer)
        '    datas = From p In db.TABEAN_JJs Where p.IDA = IDA And p.TR_ID_JJ = TR_ID And p.IDA_LCN = LCN_ID Select p

        '    For Each Me.fields In datas

        '    Next
        'End Sub

    End Class
    Public Class TB_DALCN_LOCATION_BSN
        Inherits MAINCONTEXT 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

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
    Public Class TB_DALCN_DETAIL_LOCATION_KEEP
        Inherits MAINCONTEXT 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

        Public fields As New DALCN_DETAIL_LOCATION_KEEP

        Public Sub insert()
            dbpage.DALCN_DETAIL_LOCATION_KEEPs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_DETAIL_LOCATION_KEEPs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetData_by_LCN_IDA(ByVal LCN_IDA As String)

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Where p.LCN_IDA = LCN_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_LOCATION_ADDRESS_rcvno(ByVal LOCATION_ADDRESS_rcvno As String)

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Where p.LOCATION_ADDRESS_rcvno = LOCATION_ADDRESS_rcvno Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As String)

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Where p.LOCATION_ADDRESS_IDA = LOCATION_ADDRESS_IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetData_by_LOCATION_ADDRESS_IDA_AND_LCN_IDA(ByVal LOCATION_ADDRESS_IDA As String, ByVal LCN_IDA As String)

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Where p.LOCATION_ADDRESS_IDA = LOCATION_ADDRESS_IDA And p.LCN_IDA = LCN_IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
        '
        Public Sub GetDataby_IDA(ByVal IDA As String)

            datas = (From p In dbpage.DALCN_DETAIL_LOCATION_KEEPs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_DALCN_LOCATION_ADDRESS
        Inherits MAINCONTEXT 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

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
        Public Sub GetDataby_FK_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_LOCATION_ADDRESSes Where p.FK_IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_DALCN_PHR
        Inherits MAINCONTEXT

        Public fields As New DALCN_PHR

        Private _Details As New List(Of DALCN_PHR)
        Public Property Details() As List(Of DALCN_PHR)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of DALCN_PHR))
                _Details = value
            End Set
        End Property
        Public Sub AddDetails()
            Details.Add(fields)
            fields = New DALCN_PHR
        End Sub
        Public Sub insert()
            dbpage.DALCN_PHRs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_PHRs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_PHRs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_PHRs Where p.PHR_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_AddDetails(ByVal FK_IDA As Integer)
            datas = (From p In dbpage.DALCN_PHRs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GetDataby_FK_IDA(ByVal FK_IDA As Integer)

            datas = (From p In dbpage.DALCN_PHRs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_CTZNO(ByVal CTZNO As String)
            datas = (From p In dbpage.DALCN_PHRs Where p.PHR_CTZNO = CTZNO Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetDataby_FK_LCN_ACTIVE(ByVal FK_IDA As String, ByVal active As Boolean)

            datas = (From p In dbpage.DALCN_PHRs Where p.FK_IDA = CInt(FK_IDA) Select p) 'And p.ACTIVEFACT = active
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub
        Public Function CountDataby_FK_IDA_and_Type(ByVal FK_IDA As Integer, ByVal _type As Integer) As Integer
            Dim i As Integer = 0
            Try
                datas = (From p In dbpage.DALCN_PHRs Where p.FK_IDA = FK_IDA And p.PHR_MEDICAL_TYPE = _type Select p)
                For Each Me.fields In datas
                    i += 1
                Next
            Catch ex As Exception

            End Try
            Return i
        End Function
    End Class
    Public Class TB_LCN_APPROVE_EDIT
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT

        Public Sub insert()
            dbpage.LCN_APPROVE_EDITs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDITs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDITs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA_YEAR(ByVal IDA As Integer, ByVal year As String, ByVal active As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.IDA = IDA And p.DATE_YEAR = year And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_LCN_IDA_AND_YEAR_AND_ACTIVE(ByVal IDA As Integer, ByVal year As String, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.FK_LCN_IDA = IDA And p.DATE_YEAR = year And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_LCN_IDA_AND_YEAR_TR_ID_AND_ACTIVE(ByVal IDA As Integer, ByVal year As String, ByVal tr_id As String, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.FK_LCN_IDA = IDA And p.DATE_YEAR = year And p.TR_ID = tr_id And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataBY_LCN_IDA(ByVal lcn As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.FK_LCN_IDA = lcn Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataBY_IDA_LCN_IDA_LCN_EDIT_REASON_TYPE(ByVal IDA As String, ByVal lcn As Integer, ByVal edit_reason_type As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.FK_LCN_IDA = lcn And p.LCN_EDIT_REASON_TYPE = edit_reason_type And p.IDA = IDA And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataBY_LCN_IDA_LCN_EDIT_REASON_TYPE_YEAR(ByVal lcn As Integer, ByVal edit_reason_type As Integer, ByVal year As String, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.FK_LCN_IDA = lcn And p.LCN_EDIT_REASON_TYPE = edit_reason_type And p.DATE_YEAR = year And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL1_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL1_REASON
        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL1_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL1_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL1_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL1_REASONs Where p.IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_IDA(ByVal fk_ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL1_REASONs Where p.FK_IDA = fk_ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL1_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL2_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL2_REASON

        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL2_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL2_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL2_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL2_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL2_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL2_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL3_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL3_REASON
        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL3_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL3_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL3_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL3_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL3_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL3_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL4_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL4_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL4_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL4_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL4_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL4_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL4_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL5_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL5_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL5_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL5_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL5_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL6_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL6_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL6_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL6_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL6_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL6_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCT_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL6_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL7_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL7_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL7_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL7_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL7_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL7_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL7_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL7_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL8_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL8_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL8_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL8_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL8_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL8_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL8_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL8_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL9_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL9_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL9_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL9_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL9_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL9_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL9_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL9_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL10_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL10_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL10_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL10_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL10_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_LCN_APPROVE_EDIT_DDL11_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_DDL11_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_DDL11_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_DDL11_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL11_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LOG_STATUS_LCN_EDIT
        Inherits MAINCONTEXT

        Public fields As New LOG_STATUS_LCN_EDIT

        Public Sub insert()
            dbpage.LOG_STATUS_LCN_EDITs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LOG_STATUS_LCN_EDITs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LOG_STATUS_LCN_EDITs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDITs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL1_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL1_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL1_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL1_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL1_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL1_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL2_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL2_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL2_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL3_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL3_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL3_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL4_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL4_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL4_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL4_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL4_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL4_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL4_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL5_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL5_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL5_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL6_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL6_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL6_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL6_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL6_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL6_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCT_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL6_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL7_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL7_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL7_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL8_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL8_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs Where p.FK_LCT_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCT_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL8_REASONs Where p.FK_LCT_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL9_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL9_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL9_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL10_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL10_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL10_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub



    End Class
    Public Class TB_OLD_LCN_APPROVE_EDIT_DDL11_REASON
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_OLD_DDL11_REASON


        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs Where p.FK_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA(ByVal ida As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GET_DATA_BY_FK_LCN_IDA_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_DATA_BY_FK_LCN_IDA_IDAROW_DDL1_DDL2_ACTIVE(ByVal ida As Integer, ByVal row As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_OLD_DDL11_REASONs Where p.FK_LCN_IDA = ida And p.FK_IDA_CHK_ROW = row And p.ddl1 = ddl1 And p.ddl2 = ddl2 And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


    End Class
    Public Class TB_LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST

        Private _Details As New List(Of LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST)
        Public Property Details() As List(Of LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST))
                _Details = value
            End Set
        End Property
        Public Sub AddDetails()
            Details.Add(fields)
            fields = New LCN_APPROVE_EDIT_TYPE_EDIT_REQUEST
        End Sub
        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_AddDetails(ByVal FK_IDA As Integer)
            datas = (From p In dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GetDataby_FK_IDA(ByVal FK_IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_TYPE_EDIT_REQUESTs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_LCN_APPROVE_EDIT_UPLOAD_FILE
        Inherits MAINCONTEXT

        Public fields As New LCN_APPROVE_EDIT_UPLOAD_FILE

        Private _Details As New List(Of LCN_APPROVE_EDIT_UPLOAD_FILE)
        Public Property Details() As List(Of LCN_APPROVE_EDIT_UPLOAD_FILE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of LCN_APPROVE_EDIT_UPLOAD_FILE))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TR_ID(ByVal TR_ID As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.TR_ID = TR_ID Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GETDATA_BY_PROCESS_HEAD_ID_TITEL_ID_TR_ID(ByVal PROCESS_ID As Integer, ByVal HEAD_ID As Integer, ByVal TITEL_ID1 As Integer, ByVal TITEL_ID2 As Integer, ByVal TR_ID As String, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.PROCESS_ID = PROCESS_ID And p.HEAD_ID = HEAD_ID And p.FK_TITEL_ID = TITEL_ID1 And p.FK_TITEL_ID2 = TITEL_ID2 And p.TR_ID = TR_ID And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GETDATA_BY_PROCESS_HEAD_ID_TITEL_ID_TR_ID_EDIT_FILE(ByVal PROCESS_ID As Integer, ByVal HEAD_ID As Integer, ByVal TITEL_ID1 As Integer, ByVal TITEL_ID2 As Integer, ByVal TR_ID As String, ByVal type_edit As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.PROCESS_ID = PROCESS_ID And p.HEAD_ID = HEAD_ID And p.FK_TITEL_ID = TITEL_ID1 And p.FK_TITEL_ID2 = TITEL_ID2 And p.TR_ID = TR_ID And p.TYPE = type_edit And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GETDATA_BY_PROCESS_HEAD_ID_TITEL_ID_AND_TYPE_EDIT(ByVal process As Integer, ByVal TITEL_ID1 As Integer, ByVal TITEL_ID2 As Integer, ByVal type_edit As Integer, ByVal active As Boolean)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.PROCESS_ID = process And p.FK_TITEL_ID = TITEL_ID1 And p.FK_TITEL_ID2 = TITEL_ID2 And p.TYPE = type_edit And p.ACTIVE = active Select p)
            For Each Me.fields In datas
            Next
        End Sub


        Public Sub GET_DATA_BY_FILE_NUMBER(ByVal file_id As Integer, ByVal LCN_IDA As Integer)

            datas = (From p In dbpage.LCN_APPROVE_EDIT_UPLOAD_FILEs Where p.FILE_NUMBER_NAME = file_id And p.FK_IDA = LCN_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_DALCN_CURRENT_ADDRESS
        Inherits MAINCONTEXT

        Public fields As New DALCN_CURRENT_ADDRESS
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_CURRENT_ADDRESSes Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub insert()
            dbpage.DALCN_CURRENT_ADDRESSes.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_CURRENT_ADDRESSes.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_CURRENT_ADDRESSes Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_By_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.DALCN_CURRENT_ADDRESSes Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_By_FK_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.DALCN_CURRENT_ADDRESSes Where p.FK_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_DALCN_IMPORT_DRUG_GROUP_HERB_DETAIL
        Inherits MAINCONTEXT 'เรียก Class แม่มาใช้เพื่อให้รู้จักว่าเป็น Table ไหน

        Public fields As New DALCN_IMPORT_DRUG_GROUP_HERB_DETAIL

        Public Sub insert()
            dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub GetDataby_FKLCN_AND_FK_IDA(ByVal FK_LCN As Integer, ByVal FK_IDA As Integer)

            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Where p.FK_IDA = FK_IDA And p.LCN_IDA = FK_LCN Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FKIDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Where p.LCN_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_LCN_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Where p.LCN_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Function count_drug_group(ByVal FK_LCN_IDA As Integer) As Boolean
            Dim bool As Boolean = False
            Dim i As Integer = 0
            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Where p.LCN_IDA = FK_LCN_IDA Select p)
            For Each Me.fields In datas
                i += 1
            Next
            If i > 0 Then
                bool = True
            End If
            Return bool
        End Function
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataALL()

            datas = (From p In dbpage.DALCN_IMPORT_DRUG_GROUP_HERB_DETAILs Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_DALCN_FRGN_DATA
        Inherits MAINCONTEXT

        Public fields As New DALCN_FRGN_DATA
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In dbpage.DALCN_FRGN_DATAs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal FK_IDA As Integer)

            datas = (From p In dbpage.DALCN_FRGN_DATAs Where p.FK_IDA = FK_IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA_AND_PERSON_TYPE(ByVal FK_IDA As Integer, ByVal type As Integer)

            datas = (From p In dbpage.DALCN_FRGN_DATAs Where p.FK_IDA = FK_IDA And p.PERSONAL_TYPE = type Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub insert()
            dbpage.DALCN_FRGN_DATAs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub

        Public Sub delete()
            dbpage.DALCN_FRGN_DATAs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In dbpage.DALCN_FRGN_DATAs Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_By_IDA(ByVal IDA As Integer)
            datas = (From p In dbpage.DALCN_FRGN_DATAs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class

End Namespace