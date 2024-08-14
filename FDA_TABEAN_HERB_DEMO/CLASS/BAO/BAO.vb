Imports System.Web.Mvc
Imports System.Data.SqlClient
Namespace BAO
    Public Class BAO
        Public dt As New DataTable
        Dim rdr As SqlDataReader

        Dim conn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString").ConnectionString)
        Dim conn_CPN As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString)
        Dim conherb_124 As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("FDA_XML_DRUG_HERBConnectionString").ConnectionString)
        'Dim conn_PERMISSION As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("LGT_PERMISSIONConnectionString").ConnectionString)
        Dim SqlCmd As SqlCommand
        Dim dtAdapter As SqlDataAdapter
        Dim objds As New DataSet
        Dim strSQL As String = String.Empty
        Public Function Queryds(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        'Public Function Queryds_PERMISSION(ByVal Commands As String) As DataTable
        '    Dim dt As New DataTable
        '    Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGT_PERMISSIONConnectionString").ConnectionString)
        '    Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
        '    mySqlDataAdapter.Fill(dt)
        '    MyConnection.Close()
        '    Return dt
        'End Function
        Public Function Queryd_CPN(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Overloads Function Queryselect_CER_CENTER(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_CFS_CENTERConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()

            Return dt
        End Function
        Public Function Queryd_124(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_DRUGConnectionString1").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Function Queryd_Herb124(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_DRUG_HERBConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Function dsQueryselect(ByVal queryString As String, ByVal connectionString As String) As DataSet
            Dim myDataSet As DataSet = New DataSet
            Try
                Dim MyConnection As SqlConnection = New SqlConnection(connectionString)
                Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(queryString, MyConnection)
                mySqlDataAdapter.Fill(myDataSet)
                Return myDataSet
            Catch ex As Exception
                Return myDataSet
            End Try
        End Function
        Public Function SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDENTITY(ByVal LOCATION_TYPE_ID As Integer, ByVal IDENTITY As String) As DataTable

            Dim sql As String = "exec SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDENTITY @LOCATION_TYPE_ID=" & LOCATION_TYPE_ID & ",@IDENTITY= '" & IDENTITY & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_Lisense_Name_and_Addr(ByVal IDENTITY As String) As DataTable

            Dim sql As String = "exec SP_Lisense_Name_and_Addr @identify= '" & IDENTITY & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDEN(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDEN @iden='" & iden & "' ,@LOCATION_TYPE_CD=" & LOCATION_TYPE_CD
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try
            Return dta
        End Function
        'Public Function SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY(ByVal THANM As String, ByVal IDENTIFY As String) As DataTable
        '    Dim clsds As New ClassDataset
        '    Dim sql As String = "exec SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY @THANM= N'" & THANM & "' ,@IDENTIFY = N'" & IDENTIFY & "' "
        '    Dim dta As New DataTable
        '    dta = Queryd_CPN(sql)
        '    Return dta
        'End Function
        Public Function SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY(ByVal THANM As String, ByVal IDENTIFY As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_MEMBER_THANM_THANM_by_thanm_and_IDENTIFY @THANM= N'" & THANM & "' ,@IDENTIFY = N'" & IDENTIFY & "' "
            Dim dta As New DataTable
            dta = clsds.dsQueryselect(sql, conn_CPN.ConnectionString).Tables(0)
            Return dta
        End Function
        Public Function SP_WHO_CUSTOMER_LCN_BY_IDENTIFY(ByVal IDENTITY As String) As DataTable

            Dim sql As String = "exec SP_WHO_CUSTOMER_LCN_BY_IDENTIFY @iden= '" & IDENTITY & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_SEARCH_STAFF_HERB_LCN_BY_NEWCODE_NOT(ByVal Newcode As String) As DataTable

            Dim sql As String = "exec SP_SEARCH_STAFF_HERB_LCN_BY_NEWCODE_NOT @Newcode_not= '" & Newcode & "'"
            Dim dta As New DataTable
            dta = Queryd_Herb124(sql)
            Return dta
        End Function
        Public Function SP_SEARCH_PEOPLE_HERB(ByVal Newcode As String) As DataTable

            Dim sql As String = "exec SP_SEARCH_PEOPLE_HERB @Newcode= '" & Newcode & "'"
            Dim dta As New DataTable
            dta = Queryd_Herb124(sql)
            Return dta
        End Function
        Public Function SP_GET_DRUG_LCN_IDEN_HERB(ByVal IDEN As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_GET_DRUG_LCN_IDEN_HERB @iden='" & IDEN & "'"
            dt = Queryselect_CER_CENTER(qstr)

            Return dt
        End Function
        Public Function SP_CUSTOMER_LCN_BY_IDENTIFY_NO120(ByVal IDENTITY As String) As DataTable

            Dim sql As String = "exec SP_CUSTOMER_LCN_BY_IDENTIFY_NO120 @iden= '" & IDENTITY & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_SYSPREFIX_DDL() As DataTable
            Dim sql As String = "exec SP_SYSPREFIX_DDL"
            Dim dta As New DataTable
            dta = Queryd_CPN(sql)
            dta.TableName = "SP_SYSPREFIX_DDL"
            Return dta
        End Function
        Public Function SP_DALCN_TRANSFER_STAFF() As DataTable

            Dim sql As String = "exec SP_DALCN_TRANSFER_STAFF"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_XML_TABEAN_EDIT_FORMULA(ByVal FK_IDA As Integer) As DataTable
            Dim sql As String = "exec SP_XML_TABEAN_EDIT_FORMULA @FK_IDA=" & FK_IDA
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_XML_TABEAN_EDIT_FORMULA"
            Return dta
        End Function
        Public Function SP_XML_TABEAN_HERB_BY_IDEN(ByVal IDENTITY As String, ByVal FK_IDA_LCN As Integer) As DataTable

            Dim sql As String = "exec SP_XML_TABEAN_HERB_BY_IDEN @IDENTIFY= '" & IDENTITY & "' ,@LCN_IDA= " & FK_IDA_LCN

            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_SEARCH_LCN_BY_IDEN(ByVal iden As String) As DataTable
            Dim sql As String = "exec SP_SEARCH_LCN_BY_IDEN @iden='" & iden & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_GET_DATA_DALCN_BY_IDA(ByVal IDA As Integer) As DataTable
            Dim sql As String = "exec SP_GET_DATA_DALCN_BY_IDA @IDA=" & IDA
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_GET_DATA_DALCN_BY_IDA"
            Return dta
        End Function
        Public Function SP_DALCN_SUBSTITUTE_STAFF() As DataTable
            Dim sql As String = "exec SP_DALCN_SUBSTITUTE_STAFF "
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DALCN_SUBSTITUTE_STAFF"
            Return dta
        End Function
        Public Function SP_LCN_APPROVE_EDIT_GET_DATA(ByVal lcn As Integer, ByVal staff As Integer) As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_DATA @IDA=" & lcn & ",@STAFF_TYPE=" & staff
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_CUSTOMER_LCN_BY_IDENTIFY(ByVal IDENTITY As String) As DataTable

            Dim sql As String = "exec SP_CUSTOMER_LCN_BY_IDENTIFY @iden= '" & IDENTITY & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_TABEAN_EXHIBITION_CUSTOMER(ByVal FK_LCN As String, ByVal iden As String) As DataTable
            Dim sql As String = "exec SP_TABEAN_EXHIBITION_CUSTOMER @FK_LCN='" & FK_LCN & "' ,@IDENTIFY='" & iden & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DDL_LCN_SUBSTITUTE_by_PROCESS_ID"
            Return dta
        End Function
        Public Function SP_TABEAN_DONATE_CUSTOMER(ByVal FK_LCN As String, ByVal iden As String) As DataTable
            Dim sql As String = "exec SP_TABEAN_DONATE_CUSTOMER @FK_LCN='" & FK_LCN & "' ,@IDENTIFY='" & iden & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_DONATE_CUSTOMER"
            Return dta
        End Function
        Public Function SP_TABEAN_ANALYZE_CUSTOMER(ByVal FK_LCN As String, ByVal iden As String) As DataTable
            Dim sql As String = "exec SP_TABEAN_ANALYZE_CUSTOMER @FK_LCN='" & FK_LCN & "' ,@IDENTIFY='" & iden & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_ANALYZE_CUSTOMER"
            Return dta
        End Function
        '
        Public Function SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA(ByVal FK_IDA As Integer) As DataTable
            Dim sql As String = "exec SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA @FK_IDA=" & FK_IDA
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA"
            Return dta
        End Function
        Public Function SP_DRRGT_SUBSTITUTE_STAFF() As DataTable
            Dim sql As String = "exec SP_DRRGT_SUBSTITUTE_STAFF "
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DRRGT_SUBSTITUTE_STAFF"
            Return dta
        End Function
        '
        Public Function SP_DALCN_NCT_SUBSTITUTE_STAFF() As DataTable
            Dim sql As String = "exec SP_DALCN_NCT_SUBSTITUTE_STAFF "
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DALCN_NCT_SUBSTITUTE_STAFF"
            Return dta
        End Function
        Public Function SP_DALCN_PHR_CANCEL_FK_IDA(ByVal PHR_CTZNO As String) As DataTable
            Dim sql As String = "exec SP_DALCN_PHR_CANCEL_FK_IDA @@PHR_CTZO='" & PHR_CTZNO & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DALCN_PHR_CANCEL_FK_IDA"
            Return dta
        End Function
        '
        Public Function SP_DRRGT_PRODUCER_BY_FK_IDA(ByVal fk_ida As Integer) As DataTable
            Dim sql As String = "exec SP_DRRGT_PRODUCER_BY_FK_IDA @FK_IDA=" & fk_ida
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DRRGT_PRODUCER_BY_FK_IDA"
            Return dta
        End Function
        Public Function SP_DRRQT_PRODUCER_BY_FK_IDA(ByVal fk_ida As Integer) As DataTable
            Dim sql As String = "exec SP_DRRQT_PRODUCER_BY_FK_IDA @FK_IDA=" & fk_ida
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DRRQT_PRODUCER_BY_FK_IDA"
            Return dta
        End Function
        Public Function SP_DDL_LCN_SUBSTITUTE_by_PROCESS_ID(ByVal process As String, ByVal iden As String) As DataTable
            Dim sql As String = "exec SP_DDL_LCN_SUBSTITUTE_by_PROCESS_ID @PROCESS_ID='" & process & "' ,@iden='" & iden & "'"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DDL_LCN_SUBSTITUTE_by_PROCESS_ID"
            Return dta
        End Function
        Public Function SP_DALCN_SUBSTITUTE_BY_FK_IDA(ByVal FK_IDA As Integer) As DataTable
            Dim sql As String = "exec SP_DALCN_SUBSTITUTE_BY_FK_IDA @FK_IDA=" & FK_IDA
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DALCN_SUBSTITUTE_BY_FK_IDA"
            Return dta
        End Function
        Public Function SP_DRSAMP_BY_LCNNO(ByVal LCNNO As Integer) As DataTable
            Dim sql As String = "exec SP_DRSAMP_BY_LCNNO @lcnno=" & LCNNO
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_DRSAMP_BY_LCNNO"
            Return dta
        End Function
        Public Function SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID2(ByVal LOCATION_TYPE_CD As Integer, ByVal LCNSID As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID2 @LCNSID=" & LCNSID & " ,@LOCATION_TYPE_CD=" & LOCATION_TYPE_CD
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        Public Function SP_STAFF_DALCN_BY_IDENTIFY(ByVal iden As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_STAFF_DALCN_BY_IDENTIFY @iden='" & iden & "'"
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        Public Function SP_DRUG_REGISTRATION_PRODUCER_IN_BY_FK_IDA(ByVal fk_ida As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_DRUG_REGISTRATION_PRODUCER_IN_BY_FK_IDA @FK_IDA=" & fk_ida
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        '
        Public Function SP_DRRGT_PRODUCER_IN_BY_FK_IDA(ByVal fk_ida As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_DRRGT_PRODUCER_IN_BY_FK_IDA @FK_IDA=" & fk_ida
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        '
        Public Function SP_DRRQT_PRODUCER_IN_BY_FK_IDA(ByVal fk_ida As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_DRRQT_PRODUCER_IN_BY_FK_IDA @FK_IDA=" & fk_ida
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        Public Function SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDEN_V2(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_CUSTOMER_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_IDEN_V2 @iden='" & iden & "' ,@LOCATION_TYPE_CD=" & LOCATION_TYPE_CD
            Dim dta As New DataTable
            Try
                dta = clsds.dsQueryselect(sql, conn.ConnectionString).Tables(0)
            Catch ex As Exception

            End Try

            Return dta
        End Function
        Public Sub SP_DRUG_PRODUCT_ID_BY_LCN_IDA(ByVal LCN_IDA As Integer)

            strSQL = "SP_DRUG_PRODUCT_ID_BY_LCN_IDA"
            SqlCmd = New SqlCommand(strSQL, conn)
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
            conn.Open()
            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.Add("@LCN_IDA", SqlDbType.Int).Value = LCN_IDA
            dtAdapter = New SqlDataAdapter(SqlCmd)
            dtAdapter.Fill(dt)
            conn.Close()

        End Sub
        Public Function SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD() As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD]"
            dt = Queryd_Herb124(sql)
            Return dt
        End Function
        Public Function SP_LCN_APPROVE_EDIT_GET_DATA_FILE_UPLOAD_FOR_UPDATE(ByVal lcn As Integer, ByVal ddl1 As Integer, ByVal ddl2 As Integer, ByVal typeCre As Integer, ByVal year As String) As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_DATA_FILE_UPLOAD_FOR_UPDATE @LCN_IDA=" & lcn & ",@DDL1=" & ddl1 & ",@DDL2=" & ddl2 & ",@TYPE_CREATE=" & typeCre & ",@YEAR='" & year & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_LCN_APPROVE_EDIT_GET_UPLOAD_FILE(ByVal type As Integer) As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_UPLOAD_FILE @REASON_TYPE= " & type
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_LCN_APPROVE_EDIT_GET_TRANSACTION_RQ_NUMBER() As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_TRANSACTION_RQ_NUMBER"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_XML_TABEAN_HERB_BY_IDEN_DRRQT(ByVal IDENTITY As String, ByVal FK_IDA_LCN As Integer) As DataTable

            Dim sql As String = "exec SP_XML_TABEAN_HERB_BY_IDEN_DRRQT @IDENTIFY= '" & IDENTITY & "' ,@LCN_IDA= " & FK_IDA_LCN

            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_XML_TABEAN_HERB_BY_IDEN_124(ByVal IDENTITY As String, ByVal FK_IDA_LCN As Integer) As DataTable

            Dim sql As String = "exec SP_XML_TABEAN_HERB_BY_IDEN_124 @IDENTIFY= '" & IDENTITY & "' ,@LCN_IDA= " & FK_IDA_LCN

            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_XML_TABEAN_HERB_BY_IDEN_124_RENEW(ByVal IDENTITY As String, ByVal FK_IDA_LCN As Integer) As DataTable

            Dim sql As String = "exec SP_XML_TABEAN_HERB_BY_IDEN_124_RENEW @IDENTIFY= '" & IDENTITY & "' ,@LCN_IDA= " & FK_IDA_LCN

            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_XML_TABEAN_JJ_BY_IDEN(ByVal IDENTITY As String, ByVal FK_IDA_LCN As Integer) As DataTable

            Dim sql As String = "exec SP_XML_TABEAN_JJ_BY_IDEN @IDENTIFY= '" & IDENTITY & "' ,@LCN_IDA= " & FK_IDA_LCN

            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_TABEAN_HERB_SUBNEW_STAFF() As DataTable
            Dim sql As String = "exec SP_TABEAN_HERB_SUBNEW_STAFF"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_HERB_SUBNEW_STAFF"
            Return dta
        End Function
        Public Function SP_TABEAN_HERB_SUBSTITUTE_BY_FK_IDA(ByVal FK_IDA As Integer) As DataTable
            Dim sql As String = "exec SP_TABEAN_HERB_SUBSTITUTE_BY_FK_IDA @FK_IDA=" & FK_IDA
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_HERB_SUBSTITUTE_BY_FK_IDA"
            Return dta
        End Function
        Public Function SP_TABEAN_HERB_SUBNEW_STAFF_BY_PROCESS(ByVal process_id As Integer) As DataTable
            Dim sql As String = "exec SP_TABEAN_HERB_SUBNEW_STAFF_BY_PROCESS @PROCESS_ID=" & process_id
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_HERB_SUBNEW_STAFF_BY_PROCESS"
            Return dta
        End Function
        Public Function SP_TABEAN_RENEW_STAFF() As DataTable
            Dim sql As String = "exec SP_TABEAN_RENEW_STAFF"
            Dim dta As New DataTable
            dta = Queryds(sql)
            dta.TableName = "SP_TABEAN_RENEW_STAFF"
            Return dta
        End Function
        Public Function SP_XML_TABEAN_HERB_SUBSTITUTE(ByVal IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_XML_TABEAN_HERB_SUBSTITUTE @IDA=" & IDA
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
        Public Function SP_TABEAN_RENEW_TBN_CUSTOMER(ByVal IDEN As String, ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_RENEW_TBN_CUSTOMER @IDENTIFY= '" & IDEN & "'" & ",@FK_IDA=" & FK_IDA
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_TABEAN_RENEW_JJ_CUSTOMER(ByVal IDEN As String, ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_RENEW_JJ_CUSTOMER @IDENTIFY= '" & IDEN & "'" & ",@FK_IDA=" & FK_IDA
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_STATUS_CANCEL_TABEAN_HERB(ByVal IDgroup As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_STATUS_CANCEL_TABEAN_HERB @IDgroup=" & IDgroup
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_LOG_STATUS(ByVal IDA As Integer, ByVal Process_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LOG_STATUS @FK_IDA=" & IDA & ",@PROCESS_ID=" & Process_ID
            dt = Queryds(qstr)

            Return dt
        End Function
        Function Get_DDL_DATA(ByVal stat_g As Integer, ByVal group1 As Integer, ByVal group2 As Integer) As DataTable
            'Dim dt As New DataTable
            Dim sql As String = "exec SP_MAS_STATUS_STAFF_BY_GROUP_DDL_V2 @stat_group=" & stat_g & ", @group1=" & group1 & " , @group2=" & group2
            Dim dta As New DataTable
            dta = Queryds(sql)
            Return dta
        End Function
        Public Function SP_TABEAN_HERB_UPLOAD_FILE_JJ(ByVal TR_ID_JJ As Integer, ByVal TYPE_ID As Integer, ByVal P_ID As Integer, ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_HERB_UPLOAD_FILE_JJ @TR_ID_JJ=" & TR_ID_JJ & ",@TYPE_ID= '" & TYPE_ID & "',@PROCESS_ID= '" & P_ID & "'" & ",@FK_IDA= " & FK_IDA
            dt = Queryds(qstr)

            Return dt
        End Function
        Function SP_MAS_STATUS_STAFF_BY_GROUP_DDL_V2(ByVal _stat_group As Integer, ByVal _group As Integer, ByVal _status_id As Integer, ByVal _status_id2 As Integer)

            strSQL = "SP_MAS_STATUS_STAFF_BY_GROUP_DDL_V2_1"
            SqlCmd = New SqlCommand(strSQL, conn)
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
            conn.Open()
            SqlCmd.CommandType = CommandType.StoredProcedure
            SqlCmd.Parameters.Add("@stat_group", SqlDbType.Int).Value = _stat_group
            SqlCmd.Parameters.Add("@group1", SqlDbType.Int).Value = _group
            SqlCmd.Parameters.Add("@group2", SqlDbType.Int).Value = _status_id
            SqlCmd.Parameters.Add("@group3", SqlDbType.Int).Value = _status_id2
            dtAdapter = New SqlDataAdapter(SqlCmd)
            dtAdapter.Fill(dt)
            conn.Close()
            Return dt
        End Function
        Public Function SP_TABEAN_UPLOAD_FILE_CENTER(ByVal TR_ID As Integer, ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""
            qstr = "exec SP_TABEAN_UPLOAD_FILE_CENTER @TR_ID=" & TR_ID & ",@PROCESS_ID= '" & P_ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_TABEAN_UPLOAD_FILE_EDIT_CENTER(ByVal TR_ID As Integer, ByVal TYPE_Edit As Integer, ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_UPLOAD_FILE_EDIT_CENTER @TR_ID=" & TR_ID & ",@TYPE_EDIT= '" & TYPE_Edit & "',@PROCESS_ID= '" & P_ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_TABEAN_UPLOAD_FILE_EDIT_STAFF_CENTER(ByVal TR_ID As Integer, ByVal TYPE_ID As Integer, ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_UPLOAD_FILE_EDIT_STAFF_CENTER @TR_ID=" & TR_ID & ",@TYPE_ID= '" & TYPE_ID & "',@PROCESS_ID= '" & P_ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_TABEAN_HERB_UPLOAD_FILE_CENTER(ByVal TR_ID As Integer, ByVal TYPE_ID As Integer, ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_TABEAN_HERB_UPLOAD_FILE_CENTER @TR_ID=" & TR_ID & ",@TYPE_ID= '" & TYPE_ID & "',@PROCESS_ID= '" & P_ID & "'"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_PRICE_DISCOUNT_TABEAN_HERB() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""
            qstr = "exec SP_MAS_PRICE_DISCOUNT_TABEAN_HERB "
            dt = Queryds(qstr)
            Return dt
        End Function
        Public Function SP_MAS_PRICE_DISCOUNT_TABEAN_HERB_BY_PROCESS(ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_PRICE_DISCOUNT_TABEAN_HERB_BY_PROCESS @PROCESS_ID=" & P_ID
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_DD_PRICE_ESTIMATE_REQUEST(ByVal P_ID As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_DD_PRICE_ESTIMATE_REQUEST @PROCESS_ID=" & P_ID
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_TABEAN_HERB_SALE() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_TABEAN_HERB_SALE"
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_MAS_PRICE_DISCOUNT_DALCN_HERB() As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_MAS_PRICE_DISCOUNT_DALCN_HERB "
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_XML_DRUG_DRRQT(ByVal _IDA_DQ As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_XML_DRUG_DRRQT @IDA=" & _IDA_DQ
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA @LOCATION_ADDRESS_IDA = " & LOCATION_ADDRESS_IDA
            dt = Queryds(sql)
            dt.TableName = "SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA"
            Return dt
        End Function
        Public Function SP_XML_TABEAN_RENEW_TBN(ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_XML_TABEAN_RENEW_TBN @FK_IDA=" & FK_IDA
            dt = Queryds(qstr)

            Return dt
        End Function

        Public Function SP_XML_WHO_DALCN(ByVal FK_IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_XML_WHO_DALCN @FK_IDA=" & FK_IDA
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2(ByVal fk_ida As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_DRRQT_PRODUCER_IN_BY_FK_IDA_V2 @FK_IDA=" & fk_ida
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_XML_TABEAN_JJ(ByVal IDA As Integer) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_XML_TABEAN_JJ @IDA=" & IDA
            dt = Queryds(qstr)

            Return dt
        End Function
    End Class

    Public Class BIND_DT_XML
        Inherits BAO
        Public Function SP_LCN_APPROVE_EDIT_GET_DATA_XML1(ByVal ida As Integer, ByVal year As Integer) As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_DATA_XML1 @IDA= " & ida & ",@YEAR=" & year
            dt = Queryds(qstr)

            Return dt
        End Function
        Public Function SP_LCN_APPROVE_EDIT_GET_DATA_XML2(ByVal ida As Integer, ByVal year As Integer) As DataTable

            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_LCN_APPROVE_EDIT_GET_DATA_XML2 @IDA= " & ida & ",@YEAR=" & year
            dt = Queryds(qstr)

            Return dt
        End Function

    End Class
    Public Class AppSettings
        Public _PATH_PDF_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")    'ที่อยู่ Path
        Public _PATH_DEFAULT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_DEFALUT")              'ที่อยู่ Path
        Public _PATH_UPLOAD As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_UPLOAD")              'ที่อยู่ Path
        Public _PATH_XML_PDF_TABEAN_SUB As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB")              'ที่อยู่ Path

        Sub RunAppSettings()
            _PATH_PDF_TEMPLATE = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")                 'ที่อยู่ Path
            _PATH_UPLOAD = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_UPLOAD")                 'ที่อยู่ Path
            _PATH_XML_PDF_TABEAN_SUB = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_PDF_TABEAN_SUB")                 'ที่อยู่ Path
        End Sub

    End Class
    Public Class GenNumber
        'CODE แปลงเลข ให้รองรับแบบ NCT-N-2560-1
        Public Function FORMAT_NUMBER_BOOKING(ByVal SYSTEM As String, ByVal TYPE As String, ByVal YEAR As String, ByVal int_no As Integer) As String
            Dim str_no As String = SYSTEM & "-" & TYPE & "-" & YEAR & "-" & int_no
            Return str_no
        End Function
        Public Function GEN_RCVNO_NO(ByVal YEAR As String, ByVal PVNCD As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.ClsDBGEN_RCVNO
            dao.GetDataby_Year_PVNCD_PROCESS_ID_MAX(PVNCD, YEAR, PROCESS_ID)
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.ClsDBGEN_RCVNO
            dao.fields.YEARS = YEAR
            dao.fields.PVNCD = PVNCD
            dao.fields.GEN_RCV = int_no
            dao.fields.PROCESS_ID = PROCESS_ID
            dao.fields.FK_IDA = FK_IDA
            dao.insert()
            Return str_no
        End Function
        Public Function GEN_RCVNO_NO_NEW(ByVal YEAR As String, ByVal PVNCD As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.ClsDBGEN_RCVNO
            dao.GetDataby_Year_PVNCD_PROCESS_ID_MAX(PVNCD, YEAR, PROCESS_ID)
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If
            'int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            Return str_no
        End Function
    End Class

End Namespace