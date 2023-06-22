Imports System.Web.Mvc
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web
Public Class BAO_DRUG_HERB

    Public Class connection_db
        Public Function Queryds(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString1").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
    End Class

    Public Class tb_dd
        Inherits connection_db

        Public Function SP_CER_HERB_BY_IDENTIFY(ByVal IDEN As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_CER_HERB_BY_IDENTIFY @identify= '" & IDEN & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_STAFF_DALCN_CER_HERB() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_STAFF_DALCN_CER_HERB"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_CRITERIA_USE_IN_AUDIT_CER() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_CRITERIA_USE_IN_AUDIT_CER"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_PRODUCTION_MODEL_CER() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_PRODUCTION_MODEL_CER"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_STATUS_STAFF() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_STATUS_STAFF"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_STAFF_NAME_HERB() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_STAFF_NAME_HERB"
            dt = Queryds(qstr)

            Return dt
        End Function

        Public Function SP_FILE_UPLOAD_CER_LCN(ByVal FK_ID As Integer, ByVal TYPE_ID As Integer, ByVal TR_ID As Integer, ByVal PROCESS_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_FILE_UPLOAD_CER_LCN  @TR_ID=" & TR_ID & ",@TYPE_ID= " & TYPE_ID & ",@FK_IDA= " & FK_ID & ",@PROCESS_ID= " & PROCESS_ID & ""
            dt = Queryds(qstr)

            Return dt
        End Function

        Public Function SP_MAS_DDL_LANGUEGE_CER(ByVal ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_DDL_LANGUEGE_CER @group_id='" & ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_UPLOAD_FILE_CER() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_UPLOAD_FILE_CER"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_FILE_UPLOAD_CER_MAS(ByVal ID As Integer, ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_FILE_UPLOAD_CER_MAS @HEAD_ID=" & ID & ",@FK_IDA= " & FK_IDA & ""
            dt = Queryds(qstr)

            Return dt
        End Function

        'Public Function SP_DD_STATUS_JJ(ByVal ID As Integer) As DataTable
        '    Dim dt As New DataTable
        '    Dim qstr As String = ""

        '    qstr = "exec [dbo].[SP_DD_STATUS_JJ] @s_id='" & ID & "'"
        '    dt = Queryds(qstr)

        '    Return dt
        'End Function
        Public Function SP_DD_STATUS_CER(ByVal ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec [dbo].[SP_DD_STATUS_CER] @s_id='" & ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function

        Public Function SP_FILE_UPLOAD_CER(ByVal TR_ID As Integer, ByVal TYPE_ID As Integer, ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_FILE_UPLOAD_CER @TR_ID=" & TR_ID & ",@TYPE_ID= '" & TYPE_ID & "',@PROCESS_ID= '" & P_ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function

    End Class

End Class