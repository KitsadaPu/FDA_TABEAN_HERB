Namespace DAO_DRUG_BC

    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_DRUG_BCDataContext
        Public datas
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
            Sub GetDataAll()
        End Interface
    End Class

    Public Class TB_BLOCKCHAIN_DATA
        Inherits MAINCONTEXT
        Public fields As New BLOCKCHAIN_DATA
        Public Sub insert()
            db.BLOCKCHAIN_DATAs.InsertOnSubmit(fields)
            db.SubmitChanges()
        End Sub
        Public Sub update()
            db.SubmitChanges()
        End Sub
        Public Sub delete()
            db.BLOCKCHAIN_DATAs.DeleteOnSubmit(fields)
            db.SubmitChanges()
        End Sub

        Public Sub GetDataAll()
            datas = (From p In db.BLOCKCHAIN_DATAs Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GetDataby_IDA(ByVal IDA As String)
            datas = (From p In db.BLOCKCHAIN_DATAs Where p.IDA = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
End Namespace
