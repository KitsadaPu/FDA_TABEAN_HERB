Imports System.IO

Public Class BAO_DROPBOX

    ''' <summary>
    ''' ตรวจสอบว่าไฟล์ UPLOAD ครบแล้วหรือยัง
    ''' </summary>
    ''' <returns>TRUE คือครบ False คือไม่ครบ</returns>
    Public Function CHECK_FILE(ByVal TR_ID As String) As Boolean
        Dim chk As Boolean = True
        Dim dao_b As New DAO.TB_FILE_BOX
        dao_b.GETDATA_BY_TR_ID(TR_ID)
        For Each dao_b.fields In dao_b.Details
            If dao_b.fields.PRIORITY = "HIGH" Then
                If File.Exists(dao_b.fields.PATH_FILE) Then
                Else
                    chk = False
                End If
            End If
        Next
        Return chk
    End Function

    Public Sub ADD_LOG(ByVal whos As String,
                   ByVal whats As String, ByVal whys As String,
                   ByVal wheres As String, ByVal hows As String, ByVal DATAs As String)

        Dim ws_l As New WS_LOG.WS_LOG_CENTER
        Dim ws_f As New WS_LOG.CLS_FIELDS
        With ws_f
            .HOWs = hows
            .WHATs = whats
            .WHEREs = wheres
            .WHOS = whos
            .WHYs = whys
            .DATAs = DATAs
        End With
        ws_l.ADD_LOG(ws_f)
    End Sub
End Class
