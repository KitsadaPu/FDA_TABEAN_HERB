Namespace DAO_XML_CPN

    Public MustInherit Class MAINCONTEXT
        Public db As New LINQ_CPNDataContext
        Public datas
        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
            Sub GetDataAll()
        End Interface
    End Class

    'Public Class TB_XML_CPN_KEEP_PATH
    '    Inherits MAINCONTEXT
    '    Public fields As New XML_CPN_KEEP_PATH
    '    Public Sub insert()
    '        db.XML_CPN_KEEP_PATHs.InsertOnSubmit(fields)
    '        db.SubmitChanges()
    '    End Sub
    '    Public Sub update()
    '        db.SubmitChanges()
    '    End Sub
    '    Public Sub delete()
    '        db.XML_CPN_KEEP_PATHs.DeleteOnSubmit(fields)
    '        db.SubmitChanges()
    '    End Sub

    '    Public Sub GetDataAll()
    '        datas = (From p In db.XML_CPN_KEEP_PATHs Select p)
    '        For Each Me.fields In datas
    '        Next
    '    End Sub

    '    Public Sub GetDataby_GROUP_TYPE(ByVal GROUPNAME As String, ByVal TYPE_DESCRIPTION As String)
    '        datas = (From p In db.XML_CPN_KEEP_PATHs Where p.GROUPNAME = GROUPNAME And p.TYPE_DESCRIPTION = TYPE_DESCRIPTION Select p)
    '        For Each Me.fields In datas
    '        Next
    '    End Sub
    'End Class
End Namespace
