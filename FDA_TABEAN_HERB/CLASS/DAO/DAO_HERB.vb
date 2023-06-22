Namespace DAO_HERB
    'Public MustInherit Class MAINCONTEXT2
    '    Public dbpage As New LINQ_SEARCH_DRUGDataContext

    '    Public datas

    '    Public Interface MAIN
    '        Sub insert()
    '        Sub delete()
    '        Sub update()
    '    End Interface
    'End Class
    'Public Class TB_syschngwt
    '    Inherits MAINCONTEXT2
    '    Public fields As New syschngwt

    '    Private _Details As New List(Of syschngwt)
    '    Public Property Details() As List(Of syschngwt)
    '        Get
    '            Return _Details
    '        End Get
    '        Set(ByVal value As List(Of syschngwt))
    '            _Details = value
    '        End Set
    '    End Property

    '    Private Sub AddDetails()
    '        Details.Add(fields)
    '        fields = New syschngwt
    '    End Sub

    '    Public Sub GetDataAll()
    '        datas = (From p In dbpage.syschngwts Where p.thachngwtnm <> "-" Order By p.thachngwtnm Ascending Select p)
    '        For Each Me.fields In datas
    '            AddDetails()

    '        Next
    '    End Sub
    '    Public Sub GetDataby_pvncd(ByVal chngwtcd As Integer)
    '        datas = (From p In dbpage.syschngwts Where p.chngwtcd = chngwtcd Select p)
    '        For Each Me.fields In datas
    '            AddDetails()
    '        Next
    '    End Sub
    '    '    Public Sub GetDataby_lcnsid(ByVal lcnsid As Integer)
    '    '        datas = (From p In dbpage.dalcns Where p.lcnsid = lcnsid Select p)
    '    '        For Each Me.fields In datas
    '    '            AddDetails()
    '    '        Next
    '    '    End Sub
    'End Class
    'Public Class TB_sysamphr
    '    Inherits MAINCONTEXT2
    '    Public fields As New sysamphr

    '    Private _Details As New List(Of sysamphr)
    '    Public Property Details() As List(Of sysamphr)
    '        Get
    '            Return _Details
    '        End Get
    '        Set(ByVal value As List(Of sysamphr))
    '            _Details = value
    '        End Set
    '    End Property

    '    Private Sub AddDetails()
    '        Details.Add(fields)
    '        fields = New sysamphr
    '    End Sub

    '    Public Sub GetDataAll()
    '        datas = (From p In dbpage.sysamphrs Where p.thaamphrnm <> "-" Order By p.thaamphrnm Ascending Select p)
    '        For Each Me.fields In datas
    '            AddDetails()
    '        Next
    '    End Sub
    'End Class
    'Public Class TB_systhmbl
    '    Inherits MAINCONTEXT2
    '    Public fields As New systhmbl

    '    Private _Details As New List(Of systhmbl)
    '    Public Property Details() As List(Of systhmbl)
    '        Get
    '            Return _Details
    '        End Get
    '        Set(ByVal value As List(Of systhmbl))
    '            _Details = value
    '        End Set
    '    End Property

    '    Private Sub AddDetails()
    '        Details.Add(fields)
    '        fields = New systhmbl
    '    End Sub

    '    Public Sub GetDataAll()
    '        datas = (From p In dbpage.systhmbls Where p.thathmblnm <> "-" Order By p.thathmblnm Ascending Select p)
    '        For Each Me.fields In datas
    '            AddDetails()

    '        Next
    '    End Sub
    'End Class

End Namespace