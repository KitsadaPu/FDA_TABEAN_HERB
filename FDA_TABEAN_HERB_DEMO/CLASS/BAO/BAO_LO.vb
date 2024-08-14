Imports System.Data.SqlClient
Namespace BAO_LO
    Public Class BAO_LO
        Public dt As New DataTable
        Public ds As New DataSet
        Dim rdr As SqlDataReader
        Dim conn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("FDA_CMTConnectionString").ConnectionString)
        Dim conn_CPN As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString)
        Dim conn1 As String = System.Configuration.ConfigurationManager.ConnectionStrings("FDA_CFS_CENTERConnectionString").ConnectionString
        Dim conn_DRUG As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString1").ConnectionString

        Dim SqlCmd As SqlCommand
        Dim dtAdapter As SqlDataAdapter
        Dim objds As New DataSet
        Dim strSQL As String = String.Empty

        Function AddDatatable(ByVal dt As DataTable) As DataTable
            Dim dr As DataRow = dt.NewRow
            For Each c As DataColumn In dt.Columns
                If c.DataType.Name.ToString() = "String" Then
                    dr(c.ColumnName) = ""
                ElseIf c.DataType.Name.ToString() = "Int32" Then
                    dr(c.ColumnName) = 0
                ElseIf c.DataType.Name.ToString() = "DateTime" Then
                    dr(c.ColumnName) = Date.Now 'Nothing 'Date.Now
                Else
                    Try
                        dr(c.ColumnName) = Nothing
                    Catch ex As Exception
                        dr(c.ColumnName) = 0
                    End Try


                End If

            Next

            dt.Rows.Add(dr)
            Return dt
        End Function

        Public Function Queryds_cmt(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_CMTConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function


        Public Function Queryds_cpn(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function


        Public Function Queryds_xml(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_SEARCH1ConnectionString1").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function

        Public Function Queryds_xml_center(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_NCTConnectionString1").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Function Queryds_xml_drug_HERB(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_DRUG_HERBConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()

            Return dt
        End Function

        Public Function Queryds_LGT_DRUG(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString1").ConnectionString)
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

        Public Function Queryds_FDA_ADV_HERB(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_ADV_HERBConnectionString1").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()

            Return dt
        End Function

        Public Function Queryds_xml_cmt(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_XML_CMTConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Function Queryds_xml_block(ByVal Commands As String) As DataTable
            Dim dt As New DataTable
            Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FDA_PDF_CENTERConnectionString").ConnectionString)
            Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
            mySqlDataAdapter.Fill(dt)
            MyConnection.Close()
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_OFFICER_LCN_PHARMACY_HERB(ByVal Newcode_not As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_OFFICER_LCN_PHARMACY_HERB]  @Newcode_not = '" & Newcode_not & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_GET_DRUG_IDA_BC(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GET_DRUG_IDA_BC] @Newcode = '" & Newcode & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_GET_LIST_PDF(ByVal MAIN_TR_ID As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GET_LIST_PDF]  @MAIN_TR_ID = N'" & MAIN_TR_ID & "'"
            dt = Queryds_xml_block(sql)
            Return dt
        End Function
        Public Function SP_GET_DRUG_LCN_IDEN_HERB(ByVal IDEN As String) As DataTable
            Dim dt As New DataTable
            Dim qstr As String = ""

            qstr = "exec SP_GET_DRUG_LCN_IDEN_HERB @iden='" & IDEN & "'"
            dt = Queryselect_CER_CENTER(qstr)

            Return dt
        End Function


        Public Function GenDropdown_Application(ByVal applicability As String, ByVal mode As String) As DataTable
            Dim dt As New DataTable
            Dim sp_abp As String()
            sp_abp = applicability.Split(",")
            Dim qstr As String = ""

            qstr = "SELECT APPLICATION_POSITIVE_NAME,APPLICATION_POSITIVE_CD "
            qstr &= "FROM [CHM_APP_MODE] am "
            qstr &= "join CHM_APPLICATION_POSITIVE ap on am.APPLICATION_CD = ap.APPLICATION_POSITIVE_CD "
            qstr &= "where am.APPLICABILITY_CD in (" & applicability & ") and am.MODE_IDA in (" & mode & ") "
            qstr &= "group by APPLICATION_POSITIVE_NAME,APPLICATION_POSITIVE_CD "
            qstr &= "having COUNT(APPLICATION_CD)=" & sp_abp.Count

            dt = Queryds_cmt(qstr)

            Return dt
        End Function

        Public Function SP_OR_LO(ByVal perform_lo_sea As String, ByVal licen_lo_sea As String, ByVal oper_lo_sea As String) As DataTable
            Dim sql As String = "exec SP_OR_LO @perform_lo_sea='" & perform_lo_sea & "'@licen_lo_sea ='" & licen_lo_sea & "'@oper_lo_sea='" & oper_lo_sea & "'"
            Dim dt As New DataTable
            dt = Queryds_cmt(sql)
            Return dt
        End Function

        Public Function SP_AMOUNT_LO(ByVal lcnno_lo_sea As Integer, ByVal thanm_lo_sea As Integer, ByVal thachngwtnm_lo_sea As String) As DataTable
            Dim sql As String = "exec SP_AMOUNT_LO @lcnno_lo_sea='" & lcnno_lo_sea & "'@thanm_lo_sea ='" & thanm_lo_sea & "'@thachngwtnm_lo_sea='" & thachngwtnm_lo_sea & "'"
            Dim dt As New DataTable
            dt = Queryds_cmt(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_PRO(ByVal Product_DRUG As String, ByVal principle_DRUG As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO] @Product_DRUG = '" & Product_DRUG & "',@principle_DRUG = '" & principle_DRUG & "',@register = '" & register & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' แสดงหน้า popup ผลิตภัณฑ์
        ''' </summary>


        Public Function SP_SEARCH_PRO_POPUP(ByVal rgttpcd As String, ByVal rgtno As String, ByVal drgtpcd As String) As DataTable

            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_POPUP]  @rgttpcd = '" & rgttpcd & "',@rgtno= '" & rgtno & "',@drgtpcd= '" & drgtpcd & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        'Public Function SP_RECIPE_GROUP(ByVal Newcode As String) As DataTable
        '    Dim sql As String = "exec [dbo].[SP_RECIPE_GROUP]  @Newcode = '" & Newcode & "'"
        '    Dim dt As New DataTable
        '    dt = Queryds_xml_drug_HERB(sql)
        '    Return dt
        'End Function

        Public Function SP_CMT_REPORT_TEST(ByVal Newcode_cmt As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_CMT_REPORT_TEST]  @Newcode_cmt = '" & Newcode_cmt & "'"
            dt = Queryds_xml_cmt(sql)
            Return dt
        End Function

        Public Function SP_RECIPE_GROUP(ByVal thadrgnm As String, ByVal engdrgnm As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_RECIPE_GROUP]  @thadrgnm = '" & thadrgnm & "',@engdrgnm= '" & engdrgnm & "',@register= '" & register & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function

        Public Function SP_IOW_AORI_A(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_IOW_AORI_A]  @Newcode = '" & Newcode & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function


        Public Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As Integer) As DataTable
            Dim clsds As New ClassDataset
            Dim sql As String = "exec SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA @LOCATION_ADDRESS_IDA = " & LOCATION_ADDRESS_IDA
            Dim dt As New DataTable
            Try
                dt = clsds.dsQueryselect(sql, conn_DRUG).Tables(0)
                If dt.Rows.Count() = 0 Then
                    dt = AddDatatable(dt)
                End If
            Catch ex As Exception

            End Try
            If dt.Rows.Count() = 0 Then
                dt = AddDatatable(dt)
            End If
            dt.TableName = "SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA"
            Return dt
        End Function


        ''' <summary>
        ''' รูปแบบยา
        ''' </summary>

        Public Function SP_SEARCH_DOSAGE_FORMS(ByVal lcnno As String, ByVal lcnsid As String, ByVal lcntpcd As String, ByVal pvncd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DOSAGE_FORMS]  @lcnno = '" & lcnno & "',@lcnsid = '" & lcnsid & "',@lcntpcd = '" & lcntpcd & "',@pvncd = '" & pvncd & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ' ''' <summary>
        ' ''' ชื่อสารสำคัญ
        ' ''' </summary>
        ' ''' <param name="drgtpcd"></param>
        ' ''' <param name="rgttpcd"></param>
        ' ''' <returns></returns>
        ' ''' <remarks></remarks>
        'Public Function SP_SEARCH_IOWA(ByVal drgtpcd As String, ByVal rgttpcd As String) As DataTable
        '    Dim sql As String = "exec [dbo].[SP_SEARCH_IOWA]  @drgtpcd = '" & drgtpcd & "',@rgttpcd = '" & rgttpcd & "'"
        '    Dim dt As New DataTable
        '    dt = Queryds_xml(sql)
        '    Return dt
        'End Function
        ' ''' <summary>
        ' ''' ส่วนค้นหา หน้าสถานที่
        ' ''' </summary>
        ' ''' <remarks></remarks>

        Public Function SP_SEARCH_LO(ByVal lcnno_no As String, ByVal licen_loca As String, ByVal grannm_lo As String, ByVal thanm As String, ByVal thachngwtnm As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO] @lcnno_no = '" & lcnno_no & "',@licen_loca = '" & licen_loca & "',@grannm_lo = '" & grannm_lo & "',@thanm = '" & thanm & "',@thachngwtnm = '" & thachngwtnm & "',@register = '" & register & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function


        ''' <summary>
        ''' แสดงหน้า popup สถานที่
        ''' </summary>


        Public Function SP_SEARCH_LO_POPUP(ByVal lcnno As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP]  @lcnno = '" & lcnno & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' แสดงหน้า popup ของสถานที่ ผู้มีหน้าที่ปฏิบัติการ 
        ''' </summary>
        Public Function SP_SEARCH_LO_POPUP_pharmacy_name(ByVal lcnno As String, ByVal lcntpcd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP_pharmacy_name]  @lcnno = '" & lcnno & "',@lcntpcd = '" & lcntpcd & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function

        ''' <summary>
        ''' แสดงชื่อสารสำคัญ
        ''' </summary>

        Public Function SP_SEARCH_IOWA(ByVal lcnno As String, ByVal drgtpcd As String, ByVal rgttpcd As String, ByVal rgtno As String, ByVal lcnsid As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_IOWA]  @lcnno = '" & lcnno & "',@drgtpcd = '" & drgtpcd & "',@rgttpcd = '" & rgttpcd & "',@rgtno = '" & rgtno & "',@lcnsid = '" & lcnsid & "'"
            'Dim sql As String = "exec [dbo].[SP_SEARCH_IOWA] @rgtno = '" & rgtno & "',@thadrgnm = '" & thadrgnm & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาชื่อผู้มีหน้าที่ปฏิบัติการ
        ''' </summary>

        Public Function SP_SEARCH_LO_pharmacy_name(ByVal pharmacy_name As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_pharmacy_name]  @pharmacy_name = '" & pharmacy_name & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาชื่อผู้ดำเนินการ 
        ''' </summary>

        Public Function SP_SEARCH_LO_grannm_lo(ByVal grannm_lo As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_grannm_lo]  @grannm_lo = '" & grannm_lo & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาชื่อผู้รับอนุญาต  
        ''' </summary>

        Public Function SP_SEARCH_LO_licen_loca(ByVal licen_loca As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_licen_loca]  @licen_loca = '" & licen_loca & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาจังหวัด 
        ''' </summary>

        Public Function SP_SEARCH_LO_thachngwtnm(ByVal thachngwtnm As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_thachngwtnm]  @thachngwtnm = '" & thachngwtnm & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาชื่อสถานที่หรือชื่อร้าน
        ''' </summary>

        Public Function SP_SEARCH_LO_thanm(ByVal thanm As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_thanm]  @thanm = '" & thanm & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        '''ค้นหาชื่อสถานที่ 
        ''' </summary>

        Public Function SP_SEARCH_LCN(ByVal pharmacy_name As String, ByVal Identify As String, ByVal phrno As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LCN] @pharmacy_name = '" & pharmacy_name & "',@Identify = '" & Identify & "',@phrno = '" & phrno & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        '''ค้นหาชื่อสถานที่ ในส่วนของเจ้าหน้าที่
        ''' </summary>

        Public Function SP_SEARCH_DRUG_OFFICER_LCN() As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_OFFICER_LCN] "
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        '''  ค้นหาเลขทะเบียนตำรับยา
        ''' </summary>


        Public Function SP_SEARCH_LO_lcnno(ByVal lcnno_no As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_lcnno]  @lcnno_no = '" & lcnno_no & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function


        ''' <summary>
        ''' แสดงชื่อผู้ผลิตต่างประเทศ
        ''' </summary>

        Public Function SP_SEARCH_FRGN(ByVal pvncd As String, ByVal drgtpcd As String, ByVal rgttpcd As String, ByVal rgtno As String, ByVal lcnsid As String, ByVal lcnno As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_FRGN]  @pvncd = '" & pvncd & "',@drgtpcd = '" & drgtpcd & "',@rgttpcd = '" & rgttpcd & "',@rgtno = '" & rgtno & "',@lcnsid = '" & lcnsid & "',@lcnno = '" & lcnno & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาชื่อการค้าไทย
        ''' </summary>

        Public Function SP_SEARCH_PRO_Product_DRUG(ByVal Product_DRUG_THAI As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_Product_DRUG]  @Product_DRUG_THAI = '" & Product_DRUG_THAI & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาชื่อการค้าอังกฤษ ในช่่องเดียวกัน
        ''' </summary>

        Public Function SP_SEARCH_PRO_Product_DRUG_ENG(ByVal Product_DRUG_ENG As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_Product_DRUG_ENG]  @Product_DRUG_ENG = '" & Product_DRUG_ENG & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาชื่อการอังกฤษ
        ''' </summary>

        Public Function SP_SEARCH_PRO_Product_DRUD_E(ByVal Product_DRUG_E As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_Product_DRUD_E]  @Product_DRUG_E = '" & Product_DRUG_E & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหา หน้า ประชาชนหน้า FRM_SEARCH_DRUG และหน้า FRM_SEARCH_DRUG_EX
        ''' </summary>
        ''' <param name="thadrgnm"></param>
        ''' <param name="engdrgnm"></param>
        ''' <param name="register"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_SEARCH_PRO_principle_DRUG(ByVal thadrgnm As String, ByVal engdrgnm As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_principle_DRUG]  @thadrgnm = '" & thadrgnm & "',@engdrgnm = '" & engdrgnm & "',@register = '" & register & "'"
            Dim dt As New DataTable
            Return dt
        End Function

        Public Function SP_SEARCH_PRO_principle_DRUG1(ByVal principle_DRUG As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_principle_DRUG1]  @principle_DRUG = '" & principle_DRUG & "'"
            Dim dt As New DataTable
            Return dt
        End Function
        Public Function SP_SEARCH_PRO_principle_DRUG2(ByVal atcnm As String, ByVal atccd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_principle_EX_DRUG2]  @atcnm = '" & atcnm & "', @atccd = '" & atccd & "'"
            Dim dt As New DataTable
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาเลขสารสำคัญ
        ''' </summary>

        Public Function SP_SEARCH_PRO_principle_all_DRUG(ByVal principle_all_DRUG As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_principle_all_DRUG]  @principle_all_DRUG = '" & principle_all_DRUG & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD() As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_SEARCH_DROPDOWN_KIND_LCNTPCD] "
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาเลขสารสำคัญ_ภาษาอังกฤษ
        ''' </summary>

        Public Function SP_SEARCH_PRO_principle_DRUG_ENG(ByVal principle_DRUG_ENG As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_principle_DRUG_ENG]  @principle_DRUG_ENG = '" & principle_DRUG_ENG & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาเลขทะเบียนตำรับยา
        ''' </summary>
        Public Function SP_SEARCH_PRO_register(ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_register]  @register = '" & register & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' ค้นหาเลขทะเบียนตำรับยา ภาษาอังกฤษ
        ''' </summary>
        Public Function SP_SEARCH_PRO_register_ENG(ByVal register_eng As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRO_register_ENG]  @register_eng = '" & register_eng & "'"
            Dim dt As New DataTable
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาหน้าสถานที่ แสดงเลขที่ใบอนุญาต  ชื่อผู้รับอนุญาต + ที่อยู่สำนักงานใหญ่         เลขที่ใบอนุญาต     
        ''' </summary>
        Public Function SP_SEARCH_LO_POPUP_licen_loca(ByVal lcnno As String, ByVal lcnsid As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP_licen_loca]  @lcnno = '" & lcnno & "',@lcnsid = '" & lcnsid & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ค้นหาหน้าสถานที่ ชื่อสถานที่หรือชื่อร้าน +ที่อยู่    และเวลาเปิดปิดร้าน    
        ''' </summary>
        Public Function SP_SEARCH_LO_POPUP_thanm(ByVal lcnno As String, ByVal lcnsid As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP_thanm]  @lcnno = '" & lcnno & "',@lcnsid = '" & lcnsid & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function


        ''' <summary>
        ''' ค้นหาหน้าสถานที่  ชื่อผู้ดำเนิน + ที่อยู่  
        ''' </summary>
        Public Function SP_SEARCH_LO_POPUP_grannm_lo(ByVal lcnno As String, ByVal lcnsid As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP_grannm_lo]  @lcnno = '" & lcnno & "',@lcnsid = '" & lcnsid & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function


        ''' <summary>
        ''' ค้นหาหน้าสถานที่  ชื่อผู้ปฏิบัติการ +ที่อยู่  เวลาเปิดปิดผู้ปฏิบัติการ 
        ''' </summary>
        Public Function SP_SEARCH_LO_POPUP_pharmacy_name(ByVal lcnno As String, ByVal lcnsid As String, ByVal lcntpcd As String, ByVal pvncd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO_POPUP_pharmacy_name]  @lcnno = '" & lcnno & "',@lcnsid = '" & lcnsid & "',@lcntpcd = '" & lcntpcd & "',@pvncd = '" & pvncd & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติดค้นหาเลขที่ใบอนุญาต
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_lcnno(ByVal oo As String, ByVal grannm_lo As String, ByVal thanm As String, ByVal thachngwtnm As String, ByVal lcnno_no As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_lcnno]  @oo = '" & oo & "',@grannm_lo = '" & grannm_lo & "',@thanm = '" & thanm & "',@thachngwtnm = '" & thachngwtnm & "',@lcnno_no = '" & lcnno_no & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติดค้นหา ผู้รับอนุญาต
        ''' </summary>
        ''' <param name="oo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SP_SEARCH_NCT_LO_oo(ByVal oo As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_oo]  @oo = '" & oo & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ค้นหาผู้ดำเนิน
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_grannm_lo(ByVal grannm_lo As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_grannm_lo]  @grannm_lo = '" & grannm_lo & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ค้นหาสถานที่แยก ชื่อสลับกับ เลขทะเบียน จาก thanm เป็น lcnno_o
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_lcnno_o(ByVal thanm As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_lcnno_o]  @thanm = '" & thanm & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ค้นหาสถานที่
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_thanm(ByVal lcnno_no As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_thanm]  @lcnno_no = '" & lcnno_no & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' เสพติด ค้นหาจากจังหวัด
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_thachngwtnm(ByVal thachngwtnm As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_thachngwtnm]  @thachngwtnm = '" & thachngwtnm & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function

        ''' <summary>
        ''' เสพติด หน้าแสดงรายละเอียด
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_POPUP(ByVal lcnno_no As String, ByVal lcnsid As String, ByVal pvncd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_POPUP]  @lcnno_no = '" & lcnno_no & "',@lcnsid = '" & lcnsid & "',@pvncd = '" & pvncd & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ค้นหาขอที่
        ''' </summary>

        Public Function SP_SEARCH_NCT_LO_request(ByVal ppp As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_LO_request]  @ppp = '" & ppp & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function

        Public Function SP_SEARCH_DRUG_OFFICER_LCN_PHARMACY(ByVal Newcode_not As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_OFFICER_LCN_PHARMACY]  @Newcode_not = '" & Newcode_not & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ค้นหาขอที่
        ''' </summary>

        Public Function SP_SEARCH_NCT() As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT] "
            dt = Queryds_xml(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด ปุ่ม export excel
        ''' </summary>

        Public Function SP_SEARCH_NCT_exportexcel(ByVal lcnno_no As String, ByVal lcnsid As String, ByVal pvncd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_NCT_exportexcel] @lcnno_no = '" & lcnno_no & "',@lcnsid = '" & lcnsid & "',@pvncd = '" & pvncd & "'"
            dt = Queryds_xml(sql)
            Return dt
        End Function


        ''' <summary>
        '''ค้นหาผลิตภัณฑ์ยา
        ''' </summary>

        Public Function SP_SEARCH_PRODUCT() As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_PRODUCT] "
            dt = Queryds_xml(sql)
            Return dt
        End Function

        Public Function SP_SEARCH_DRUG_PRO_DH15() As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_PRO_DH15] "
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function XML_SEARCH_DRUG_DR_OPERATOR_INSERT() As DataTable
            Dim sql As String = "exec [dbo].[XML_SEARCH_DRUG_DR_OPERATOR_INSERT] "
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function





        ''' <summary>
        '''ค้นหาสถานที่ 
        ''' </summary>

        Public Function SP_SEARCH_LO() As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_LO] "
            dt = Queryds_xml(sql)
            Return dt
        End Function
        Public Function SP_NCT_N() As DataTable
            Dim sql As String = "exec [dbo].[SP_NCT_N] "
            dt = Queryds_xml_center(sql)
            Return dt
        End Function

        ' ''' <summary>
        '    ''' เสพติด หน้าแสดงรายละเอียด  ไว้ทำ excel(FDA_XML_NCT)
        ' ''' </summary>

        '    Public Function SP_NCT_N_POPUP_EXPORT(ByVal NewCODE_not_rid As String) As DataTable
        '        Dim sql As String = "exec [dbo].[SP_NCT_N_POPUP_EXPORT]  @NewCODE_not_rid = '" & NewCODE_not_rid & "'"
        '        dt = Queryds_xml_center(sql)
        '        Return dt
        '    End Function


        ''' <summary>
        ''' เสพติด หน้าแสดงรายละเอียด
        ''' </summary>

        Public Function SP_NCT_N_POPUP_EXPORT(ByVal lcnno_no As String, ByVal lcnsid As String, ByVal pvncd As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_NCT_N_POPUP_EXPORT]  @lcnno_no = '" & lcnno_no & "',@lcnsid = '" & lcnsid & "',@pvncd = '" & pvncd & "'"
            dt = Queryds_xml_center(sql)
            Return dt
        End Function
        ''' <summary>
        ''' เสพติด หน้าแสดงรายละเอียด
        ''' </summary>
        Public Function SP_SEARCH_TABEAN_DRUG(ByVal thadrgnm As String, ByVal engdrgnm As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_TABEAN_DRUG]  @thadrgnm = '" & thadrgnm & "',@engdrgnm = '" & engdrgnm & "',@register = '" & register & "'"
            dt = Queryds_xml_center(sql)
            Return dt
        End Function

        ''' <summary>
        ''' ยา สารสำคัญ
        ''' </summary>
        Public Function SP_SEARCH_IOWANM(ByVal principle_DRUG As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_IOWANM]  @principle_DRUG = '" & principle_DRUG & "'"
            dt = Queryds_xml_center(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_OPERATOR(ByVal Identify As String, ByVal lcnno As String, ByVal Newcode_not As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_OPERATOR]  @Identify  = '" & Identify & "',@lcnno= '" & lcnno & "',@Newcode_not= '" & Newcode_not & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_LCN(ByVal thanm As String, ByVal thachngwtnm As String, ByVal lcnno_noo As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_LCN]  @thanm  = '" & thanm & "',@thachngwtnm= '" & thachngwtnm & "',@lcnno_noo= '" & lcnno_noo & "'"
            dt = Queryds_xml_center(sql)
            Return dt
        End Function

        Public Function SP_SEARCH_DRUG_LCN_EXCEL_PER(ByVal thanm As String, ByVal thachngwtnm As String, ByVal lcnno_noo As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_LCN_EXCEL_PER]  @thanm  = '" & thanm & "',@thachngwtnm= '" & thachngwtnm & "',@lcnno_noo= '" & lcnno_noo & "'"
            dt = Queryds_xml_center(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_REFER(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_REFER]  @Newcode= '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_PRO(ByVal thadrgnm As String, ByVal engdrgnm As String, ByVal register As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_PRO]  @thadrgnm= '" & thadrgnm & "',@engdrgnm = '" & engdrgnm & "',@register = '" & register & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_SEARCH_DRUG_PRO_PAGE(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_SEARCH_DRUG_PRO_PAGE]  @Newcode= '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function



        Public Function SP_DRUG_TERMS_OF_USE(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_TERMS_OF_USE]  @Newcode= '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_GENXML_DRUG_PHARMACY_TO(ByVal Newcode_not As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GENXML_DRUG_PHARMACY_TO] @Newcode_not = '" & Newcode_not & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            dt.TableName = "SP_GENXML_DRUG_PHARMACY_TO"

            Return dt
        End Function
        Public Function SP_GENXML_SEARCH_DRUG_LCN(ByVal Newcode_not As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GENXML_SEARCH_DRUG_LCN] @Newcode_not = '" & Newcode_not & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            dt.TableName = "SP_GENXML_SEARCH_DRUG_LCN"

            Return dt
        End Function
        Public Function SP_DRUG_REPORT_GENERAL(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_GENERAL]  @Newcode = '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FORMULA_ANCIENT(ByVal Newcode_U As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FORMULA_ANCIENT]  @Newcode_U = '" & Newcode_U & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FORMULA_MODERN(ByVal Newcode_U As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FORMULA_MODERN]  @Newcode_U = '" & Newcode_U & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FORMULA(ByVal Newcode_U As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FORMULA]  @Newcode_U = '" & Newcode_U & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FORMULA_AORI_A(ByVal Newcode_U As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FORMULA_AORI_A]  @Newcode_U = '" & Newcode_U & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FORMULA_AORI_A_LICEN(ByVal iowanm As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FORMULA_AORI_A_LICEN]  @iowanm = '" & iowanm & "'"
            dt = Queryds_xml_drug_HERB(sql)
            dt.TableName = "SP_DRUG_REPORT_FORMULA_AORI_A_LICEN"
            Return dt
        End Function
        Public Function SP_DRUG_REPOET_RECIPE_GROUP(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPOET_RECIPE_GROUP]  @Newcode = '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_STOWAGR(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_STOWAGR]  @Newcode = '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_FRGN(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_FRGN]  @Newcode = '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_DRUG_REPORT_ANIMAL_DRUGS(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_DRUG_REPORT_ANIMAL_DRUGS]  @Newcode = '" & Newcode & "'"
            dt = Queryds_xml_drug_HERB(sql)
            Return dt
        End Function
        Public Function SP_GENXML_SEARCH_DRUG_DH15(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GENXML_SEARCH_DRUG_DH15] @Newcode = '" & Newcode & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            dt.TableName = "SP_GENXML_SEARCH_DRUG_DH15"

            Return dt
        End Function
        Public Function SP_GENXML_DRUG_FORMULA_DH15(ByVal Newcode As String) As DataTable
            Dim sql As String = "exec [dbo].[SP_GENXML_DRUG_FORMULA_DH15] @Newcode = '" & Newcode & "'"
            Dim dt As New DataTable
            dt = Queryds_xml_drug_HERB(sql)
            dt.TableName = "SP_GENXML_DRUG_FORMULA_DH15"
            Return dt
        End Function
    End Class
End Namespace