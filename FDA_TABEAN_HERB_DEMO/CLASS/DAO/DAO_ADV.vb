Public Class DAO_ADV
    Public MustInherit Class MAINCONTEXT3
        Public dbpage As New LINQ_FDA_ADVDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class
    Public Class TB_Drug_HerbAdvertiseItem
        Inherits MAINCONTEXT3
        Public fields As New Drug_HerbAdvertiseItem

        Private _Details As New List(Of Drug_HerbAdvertiseItem)
        Public Property Details() As List(Of Drug_HerbAdvertiseItem)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of Drug_HerbAdvertiseItem))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New Drug_HerbAdvertiseItem
        End Sub

        Public Sub GetDataAll()
            datas = (From p In dbpage.Drug_HerbAdvertiseItems Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub

        Public Sub GetDataby_IDA(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbAdvertiseItems Where p.ID = id Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GetDataby_FKIDA(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbAdvertiseItems Where p.Drug_HerbFormID = id Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GetDataby_FKIDA_firstedit(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbAdvertiseItems Where p.Drug_HerbFormID = id And p.edited = True Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GetDataby_FKIDA_first(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbAdvertiseItems Where p.Drug_HerbFormID = id Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class
    Public Class TB_Drug_HerbItemDetail
        Inherits MAINCONTEXT3
        Public fields As New Drug_HerbItemDetail

        Private _Details As New List(Of Drug_HerbItemDetail)
        Public Property Details() As List(Of Drug_HerbItemDetail)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of Drug_HerbItemDetail))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New Drug_HerbItemDetail
        End Sub

        Public Sub GetDataAll()
            datas = (From p In dbpage.Drug_HerbItemDetails Select p)
            For Each Me.fields In datas
                AddDetails()

            Next
        End Sub
        Public Sub GetDataby_ID(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbItemDetails Where p.ID = id Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GetDataby_FKID(ByVal id As Integer)
            datas = (From p In dbpage.Drug_HerbItemDetails Where p.Drug_HerbFormID = id Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class
End Class
