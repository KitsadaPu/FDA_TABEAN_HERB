Namespace DAO_TABEAN

    Public MustInherit Class MAINCONTEXT        'ประกาศเพื่อใช้เป็น Class แม่
        Public db As New LINQ_TABEANDataContext 'ประกาศเพื่อใช้เป็น Class LINQ DataTable
        Public datas                            'ประกาศเ
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TB_SET_PAGE_MAIN_HERB
        Inherits MAINCONTEXT
        Public fields As New SET_PAGE_MAIN_HERB

        Private _Details As New List(Of SET_PAGE_MAIN_HERB)
        Public Property Details() As List(Of SET_PAGE_MAIN_HERB)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_MAIN_HERB))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_MAIN_HERB
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.SET_PAGE_MAIN_HERBs Where p.ACTIVEFACT IsNot Nothing Or p.ACTIVEFACT <> 0 Order By p.IDA Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
    End Class
    Public Class TB_SET_PAGE_SUB_MAIN_HERB
        Inherits MAINCONTEXT
        Public fields As New SET_PAGE_SUB_MAIN_HERB

        Private _Details As New List(Of SET_PAGE_SUB_MAIN_HERB)
        Public Property Details() As List(Of SET_PAGE_SUB_MAIN_HERB)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_SUB_MAIN_HERB))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_SUB_MAIN_HERB
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.SET_PAGE_SUB_MAIN_HERBs Where p.ACTIVEFACT IsNot Nothing Or p.ACTIVEFACT <> 0 Order By p.IDA Ascending Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
        'Public Sub GetDataby_SYSTEM_ID(ByVal SYSTEM_ID As Integer)

        '    datas = (From p In db.SET_PAGE_SUB_MAIN_HERBs Where p.IDA = SYSTEM_ID Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
    End Class
    Public Class ClsDBdrrqt
        Inherits MAINCONTEXT

        Public fields As New drrqt
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In db.drrqts Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal IDA As Integer)

            datas = (From p In db.drrqts Where p.FK_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_LCN_IDA(ByVal IDA As Integer)

            datas = (From p In db.drrqts Where p.FK_LCN_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TR_ID(ByVal TR_ID As Integer)

            datas = (From p In db.drrqts Where p.TR_ID = TR_ID Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub insert()
            db.drrqts.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub

        Public Sub delete()
            db.drrqts.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()

            datas = (From p In db.drrqts Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetData_pvncd_rgtno_drgtpcd_rgttpcd(ByVal pvncd As String, ByVal rgtno As String, ByVal drgtpcd As String, ByVal rgttpcd As String)

            datas = (From p In db.drrqts Where p.pvncd = pvncd And p.rgtno = rgtno And p.drgtpcd = drgtpcd And p.rgttpcd = rgttpcd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_TRANSECTION_ID_UPLOAD(ByVal TRANSECTION_ID_UPLOAD As Integer)

            datas = (From p In db.drrqts Where p.TR_ID = TRANSECTION_ID_UPLOAD Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_MAX_RCVNO(ByVal years As Integer, ByVal rgttpcd As String, ByVal drgtpcd As String)
            datas = (From p In db.drrqts Where Left(p.rcvno, 2) = years And p.rgttpcd = rgttpcd And p.drgtpcd = drgtpcd Order By CInt(p.rcvno) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_MAX_RGTNO(ByVal rgtno As String, ByVal rgttpcd As String, ByVal drgtpcd As String)
            datas = (From p In db.drrqts Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.drgtpcd = drgtpcd Order By CInt(p.rgtno) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub

        Public Function COUNT_REPEAT_RGTNO(ByVal rgtno As String, ByVal rgttpcd As String, ByVal drgtpcd As String) As Integer
            Dim i As Integer = 0
            datas = (From p In db.drrqts Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.drgtpcd = drgtpcd)
            For Each Me.fields In datas
                i += 1
            Next
            Return i
        End Function
        Public Function COUNT_REPEAT_RGTNO_PVNCD(ByVal rgtno As String, ByVal rgttpcd As String, ByVal drgtpcd As String, ByVal pvncd As Integer) As Integer
            Dim i As Integer = 0
            datas = (From p In db.drrqts Where p.rgtno = rgtno And p.rgttpcd = rgttpcd And p.drgtpcd = drgtpcd And p.pvncd = pvncd)
            For Each Me.fields In datas
                i += 1
            Next
            Return i
        End Function

        Public Sub GET_RGTNO_NEW_BYTPCD(ByVal rgttpcd As String)
            datas = (From p In db.drrqts Where p.RGTNO_NEW <> "" And p.RGTNO_NEW.Contains(rgttpcd) Select p.RGTNO_NEW).ToList

        End Sub
        Public Sub GET_RGTNO_NEW_BYTPCD2(ByVal rgttpcd As String)
            datas = (From p In db.drrqts Where (p.HerbFromNarcotics_ID Is Nothing Or p.HerbFromNarcotics_ID = 0) And p.RGTNO_NEW <> "" And p.RGTNO_NEW.Contains(rgttpcd) Select p.RGTNO_NEW).ToList
        End Sub
    End Class
    Public Class ClsDBdrrgt
        Inherits MAINCONTEXT

        Public fields As New drrgt
        Public Sub GetDataby_IDA(ByVal IDA As Integer)

            datas = (From p In db.drrgts Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_4key(ByVal rgtno As String, ByVal drgtpcd As String, ByVal rgttpcd As String, ByVal pvncd As Integer)

            datas = (From p In db.drrgts Where p.rgtno = rgtno And p.drgtpcd = drgtpcd And p.rgttpcd = rgttpcd And p.pvncd = pvncd Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_IDA(ByVal IDA As Integer)

            datas = (From p In db.drrgts Where p.FK_IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FK_DRRQT(ByVal IDA As Integer)

            datas = (From p In db.drrgts Where p.FK_DRRQT = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
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

            datas = (From p In db.drrgts)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_TRANSECTION_ID_UPLOAD(ByVal TRANSECTION_ID_UPLOAD As Integer)

            datas = (From p In db.drrgts Where p.TR_ID = TRANSECTION_ID_UPLOAD Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GET_MAX_RGTNO(ByVal years As Integer, ByVal rgttpcd As String, ByVal drgtpcd As String)
            datas = (From p In db.drrqts Where Left(p.rgtno, 2) = years And p.rgttpcd = rgttpcd And p.drgtpcd = drgtpcd Order By CInt(p.rgtno) Descending Select p).Take(1)
            For Each Me.fields In datas
            Next
        End Sub

        Public Function CountDataby_FK_DRRQT(ByVal IDA As Integer) As Integer
            Dim i As Integer = 0
            datas = (From p In db.drrgts Where p.FK_DRRQT = IDA Select p)
            For Each Me.fields In datas
                i += 1
            Next

            Return i
        End Function
    End Class
    Public Class TB_TABEAN_HERB
        Inherits MAINCONTEXT

        Public fields As New TABEAN_HERB

        Public Sub insert()
            db.TABEAN_HERBs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_HERBs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.TABEAN_HERBs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_FK_IDA_DQ(ByVal FK_IDA As Integer)
            datas = From p In db.TABEAN_HERBs Where p.FK_IDA_DQ = FK_IDA Select p

            For Each Me.fields In datas

            Next
        End Sub

    End Class
    Public Class TB_TABEAN_JJ
        Inherits MAINCONTEXT

        Public fields As New TABEAN_JJ

        Public Sub insert()
            db.TABEAN_JJs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_JJs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_JJs Select p)

        End Sub

        Public Sub GetdatabyID_DD_HERB_NAME_ID(ByVal DD_HERB_NAME_ID As Integer)
            datas = From p In db.TABEAN_JJs Where p.DD_HERB_NAME_ID = DD_HERB_NAME_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.TABEAN_JJs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID(ByVal TR_ID As Integer)
            datas = From p In db.TABEAN_JJs Where p.TR_ID_JJ = TR_ID Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_IDA_LCN_ID_AND_TR_ID(ByVal IDA As Integer, ByVal TR_ID As Integer, ByVal LCN_ID As Integer)
            datas = From p In db.TABEAN_JJs Where p.IDA = IDA And p.TR_ID_JJ = TR_ID And p.IDA_LCN = LCN_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_IDA_DD_HERB_NAME_ID(ByVal IDA As Integer, ByVal DD_HERB_NAME As Integer)
            datas = From p In db.TABEAN_JJs Where p.IDA = IDA And p.DD_HERB_NAME_ID = DD_HERB_NAME Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_IDA_LCN(ByVal IDA_LCN As Integer, ByVal DD_HERB_NAME As Integer)
            datas = From p In db.TABEAN_JJs Where p.LCN_ID = IDA_LCN And p.DD_HERB_NAME_ID = DD_HERB_NAME Select p

            For Each Me.fields In datas

            Next
        End Sub
        'Public Sub GetdatabyID_TR_ID_AND_FK(ByVal FK_IDA As Integer, ByVal TR_ID As Integer)
        '    datas = From p In db.TABEAN_JJs Where p.FK_IDA = FK_IDA And p.TR_ID_JJ = TR_ID Select p

        '    For Each Me.fields In datas

        '    Next
        'End Sub

        Public Sub GetdatabyID_IDA_PROCESS(ByVal IDA As Integer, ByVal DDHERB As Integer)
            datas = From p In db.TABEAN_JJs Where p.IDA = IDA And p.DDHERB = DDHERB Select p

            For Each Me.fields In datas

            Next
        End Sub

    End Class
    Public Class TB_TABEAN_HERB_SUBSTITUTE
        Inherits MAINCONTEXT

        Public fields As New TABEAN_HERB_SUBSTITUTE

        Public Sub insert()
            db.TABEAN_HERB_SUBSTITUTEs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_HERB_SUBSTITUTEs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_HERB_SUBSTITUTEs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.TABEAN_HERB_SUBSTITUTEs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_FK_IDA(ByVal FK_IDA As Integer)
            datas = From p In db.TABEAN_HERB_SUBSTITUTEs Where p.FK_IDA = FK_IDA Select p
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_MAS_TABEAN_HERB_UPLOADFILE_JJ
        Inherits MAINCONTEXT

        Public fields As New MAS_TABEAN_HERB_UPLOADFILE_JJ

        Public Sub insert()
            db.MAS_TABEAN_HERB_UPLOADFILE_JJs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.MAS_TABEAN_HERB_UPLOADFILE_JJs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.MAS_TABEAN_HERB_UPLOADFILE_JJs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.MAS_TABEAN_HERB_UPLOADFILE_JJs Where p.ID = IDA And p.ACTIVEFACT = True Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TYPE(ByVal TYPE_ID As Integer)
            datas = From p In db.MAS_TABEAN_HERB_UPLOADFILE_JJs Where p.TYPE_ID = TYPE_ID And p.ACTIVEFACT = True Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_PROCESS_ID(ByVal P_ID As Integer)
            datas = From p In db.MAS_TABEAN_HERB_UPLOADFILE_JJs Where p.PROCESS_ID = P_ID And p.ACTIVEFACT = True Select p

            For Each Me.fields In datas

            Next
        End Sub

        '    Public Sub Getdataby_TR_ID(ByVal TR_ID As Integer)
        '        datas = From p In db.MAS_TABEAN_HERB_UPLOADFILE_JJs Where p.ID = TR_ID Select p

        '        For Each Me.fields In datas

        '        Next
        '    End Sub

    End Class
    Public Class TB_TABEAN_HERB_UPLOAD_FILE_JJ
        Inherits MAINCONTEXT

        Public fields As New TABEAN_HERB_UPLOAD_FILE_JJ

        Public Sub insert()
            db.TABEAN_HERB_UPLOAD_FILE_JJs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_HERB_UPLOAD_FILE_JJs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_IDA_AND_TR_ID(ByVal IDA As Integer, ByVal TR_ID As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.IDA = IDA And p.TR_ID = TR_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID(ByVal TR_ID As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID_PROCESS_ID(ByVal TR_ID As Integer, ByVal PROCESS_ID As String)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.PROCESS_ID = PROCESS_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID_FK_IDA_PROCESS_ID(ByVal FK_IDA As Integer, ByVal TR_ID As Integer, ByVal PROCESS_ID As String)
            datas = (From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.FK_IDA = FK_IDA And p.PROCESS_ID = PROCESS_ID Order By p.IDA Descending Select p).Take(1)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_TR_ID_FK_IDA_PROCESS_ID_AND_TYPE(ByVal FK_IDA As Integer, ByVal TR_ID As Integer, ByVal PROCESS_ID As String, ByVal TYPE_ID As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.FK_IDA = FK_IDA And p.PROCESS_ID = PROCESS_ID And p.TYPE = TYPE_ID Select p
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_TR_ID_FK_IDA_PROCESS_ID_AND_TYPE_DC(ByVal FK_IDA As Integer, ByVal TR_ID As Integer, ByVal PROCESS_ID As String, ByVal TYPE_ID As Integer)
            Dim DC As String = "ฉลาก และเอกสารกำกับผลิตภัณฑ์ :"
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.FK_IDA = FK_IDA And p.PROCESS_ID = PROCESS_ID And p.TYPE = TYPE_ID And p.DUCUMENT_NAME = DC Select p
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_TR_ID_FK_IDA_PROCESS_ID_AND_TYPE_DC2(ByVal FK_IDA As Integer, ByVal TR_ID As Integer, ByVal PROCESS_ID As String, ByVal TYPE_ID As Integer, ByVal DC As String)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.FK_IDA = FK_IDA And p.PROCESS_ID = PROCESS_ID And p.TYPE = TYPE_ID And p.DUCUMENT_NAME = DC Select p
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID_PROCESS_TYPE(ByVal TR_ID As Integer, ByVal PROCESS_ID As String, ByVal TYPE_ID As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.PROCESS_ID = PROCESS_ID And p.TYPE = TYPE_ID Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_IDA_TYPE(ByVal FK_IDA As Integer, ByVal TYPE As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.FK_IDA = FK_IDA And p.TYPE = TYPE Select p

            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_TR_ID_PROCESS_ID_ALL(ByVal TR_ID As Integer, ByVal PROCESS_ID As String, ByVal type_id As Integer)
            datas = From p In db.TABEAN_HERB_UPLOAD_FILE_JJs Where p.TR_ID = TR_ID And p.PROCESS_ID = PROCESS_ID And p.TYPE = type_id Select p
        End Sub

    End Class
    Public Class TB_TABEAN_RENEW
        Inherits MAINCONTEXT

        Public fields As New TABEAN_RENEW

        Public Sub insert()
            db.TABEAN_RENEWs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_RENEWs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_RENEWs Select p)

        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.TABEAN_RENEWs Where p.IDA = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_FK_IDA(ByVal FK_IDA As Integer)
            datas = From p In db.TABEAN_RENEWs Where p.FK_IDA = FK_IDA Select p
            For Each Me.fields In datas
            Next
        End Sub

    End Class
    Public Class TB_TABEAN_SUBPACKAGE
        Inherits MAINCONTEXT

        Public fields As New TABEAN_JJ_SUB_PACKSIZE

        Private _Details As New List(Of TABEAN_JJ_SUB_PACKSIZE)
        Public Property Details() As List(Of TABEAN_JJ_SUB_PACKSIZE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of TABEAN_JJ_SUB_PACKSIZE))
                _Details = value
            End Set
        End Property

        Public Sub AddDetails()
            Details.Add(fields)
            fields = New TABEAN_JJ_SUB_PACKSIZE
        End Sub

        Public Sub insert()
            db.TABEAN_JJ_SUB_PACKSIZEs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.TABEAN_JJ_SUB_PACKSIZEs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.TABEAN_JJ_SUB_PACKSIZEs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GetData_ByIDA(ByVal IDA As Integer)
            datas = (From p In db.TABEAN_JJ_SUB_PACKSIZEs Where p.IDA = IDA Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetData_ByDD_HERB_NAME_ID(ByVal DD_HERB_NAME_ID As Integer)
            datas = (From p In db.TABEAN_JJ_SUB_PACKSIZEs Where p.IDA = DD_HERB_NAME_ID Select p)
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetData_ByFkIDA(ByVal fk_ida As Integer)
            datas = (From p In db.TABEAN_JJ_SUB_PACKSIZEs Where p.FK_IDA = fk_ida Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
    Public Class TB_MAS_PRICE_DISCOUNT_TABEAN_HERB
        Inherits MAINCONTEXT

        Public fields As New MAS_PRICE_DISCOUNT_TABEAN_HERB

        Public Sub insert()
            db.MAS_PRICE_DISCOUNT_TABEAN_HERBs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.MAS_PRICE_DISCOUNT_TABEAN_HERBs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.MAS_PRICE_DISCOUNT_TABEAN_HERBs Select p)

        End Sub
        Public Sub GetdatabyID_ID(ByVal ID As Integer)
            datas = From p In db.MAS_PRICE_DISCOUNT_TABEAN_HERBs Where p.ID = ID Select p
            For Each Me.fields In datas

            Next
        End Sub

        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.MAS_PRICE_DISCOUNT_TABEAN_HERBs Where p.IDA = IDA Select p
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_MAS_PRICE_REQUEST_HERB
        Inherits MAINCONTEXT

        Public fields As New MAS_PRICE_REQUEST_HERB

        Public Sub insert()
            db.MAS_PRICE_REQUEST_HERBs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub Update()
            db.SubmitChanges()
        End Sub

        Public Sub Delete()
            db.MAS_PRICE_REQUEST_HERBs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetAll()
            datas = (From p In db.MAS_PRICE_REQUEST_HERBs Select p)

        End Sub
        Public Sub Getdataby_Process_ID(ByVal Process_ID As Integer)
            datas = From p In db.MAS_PRICE_REQUEST_HERBs Where p.Process_ID = Process_ID Select p

            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GetdatabyID_IDA(ByVal IDA As Integer)
            datas = From p In db.MAS_PRICE_REQUEST_HERBs Where p.ID = IDA Select p

            For Each Me.fields In datas

            Next
        End Sub
    End Class
End Namespace
