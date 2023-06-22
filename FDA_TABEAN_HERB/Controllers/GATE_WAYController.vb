Imports System.Web.Mvc
Imports System.Web
Imports Newtonsoft.Json
Imports System.IO
Imports System.Xml.Serialization
Imports System.Web.Script.Serialization
Imports System.Xml

Namespace Controllers
    Public Class GATE_WAYController
        Inherits Controller

        ' GET: GATE_WAY
        Function Index() As ActionResult
            Return View()
        End Function
        Function GATEWAY_EXCHANGE_FDA(ByVal test As String) As JsonResult
            'Return Json(CODE_CENTER(MODEL), JsonRequestBehavior.AllowGet)
            Return Json(test, JsonRequestBehavior.AllowGet)
        End Function
        Function GATEWAY_EXCHANGE(ByVal MODEL As String) As JsonResult
            Dim MODEL_APP As New MODEL_APP

            Try

                Dim jss As New JavaScriptSerializer
                Dim list_file As New List(Of HttpPostedFileBase)
                MODEL_APP = jss.Deserialize(JSON_CONVERT_DATE(MODEL), GetType(MODEL_APP))
                'MODEL_APP = jss.Deserialize(MODEL, GetType(MODEL_APP))

                For i As Integer = 0 To Request.Files.Count - 1
                    Dim file As HttpPostedFileBase = Request.Files(i)
                    list_file.Add(file)
                Next

                Dim json_model = Json(CODE_CENTER(MODEL_APP, list_file), JsonRequestBehavior.AllowGet)
                If json_model.Data Is Nothing Then
                    Throw New Exception
                End If
                json_model.MaxJsonLength = Integer.MaxValue
                Return json_model
                'Return Json(CODE_CENTER(MODEL_APP), JsonRequestBehavior.AllowGet)
                'Dim b As Byte = Request.Files
            Catch ex As Exception
                MODEL_APP.RESULT = "กรุณาลองใหม่อีกครั้ง"
                Dim json_model = Json(MODEL_APP, JsonRequestBehavior.AllowGet)
                json_model.MaxJsonLength = Integer.MaxValue
                Return json_model
                'Return Json(MODEL, JsonRequestBehavior.AllowGet)
            End Try
        End Function
        Private Function CODE_CENTER(ByVal MODEL_APP As MODEL_APP, ByVal List_file As List(Of HttpPostedFileBase)) As MODEL_APP
            Dim CORE_FUNC As New CORE_FUNC
            Dim jss As New JavaScriptSerializer

            Dim groups As Integer = 0

            Try
                'INSERT_MODEL_LOG(MODEL_APP, "START_FUNC", groups, "")
                Dim ar As Array = MODEL_APP.FUNC_CODE.Split(",")
                For i = 0 To ar.Length - 1
                    Select Case ar(i)

                        ''''''''''''''''''''''''''''''''''''''''''' GET DATA  '''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Case "FUNC-GET_DATA_TYPE_TABEAN"
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_BY_PROCESS_ID(MODEL_APP)
                        Case "FUNC-GET_DATATABLE_TABEAN_SUB"
                            'MODEL_APP = CORE_FUNC.Binddata_Tabean_BY_PROCESS_ID(MODEL_APP)
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_Substitute(MODEL_APP)
                        Case "FUNC-GET_DATA_TABEAN_SUBSTITUTE"
                            MODEL_APP = CORE_FUNC.GetDataTabeanSubstitute(MODEL_APP)
                        Case "FUNC-GET_DATA_CONFIRM_CUSTOMER"
                            MODEL_APP = CORE_FUNC.GetDataCustomerConfirm(MODEL_APP)
                        Case "FUNC-GET_DATA_TABEAN_SUB_STAFF"
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_Substitute_Saff(MODEL_APP)
                        Case "FUNC-GET_DATA_TABEAN_FILE_UPLOAD"
                            MODEL_APP = CORE_FUNC.GET_FILE_UPLOAD_TABEAN_CENNTER(MODEL_APP)
                        Case "FUNC-GET_DATA_CONFIRM_STAFF"
                            MODEL_APP = CORE_FUNC.GetDataStaffConfirm(MODEL_APP)
                        Case "FUNC-GET_DATA_LCN_STAFF"
                            MODEL_APP.lcn_edit_staff = CORE_FUNC.Binddata_lcn_edit_staff(MODEL_APP)
                        Case "FUNC-SEARCH_DATA_CUSTOMER"
                            MODEL_APP.FILE_SEARCH = CORE_FUNC.SEARCH_DATA_CUSTOMER(MODEL_APP)
                        Case "FUNC-SELECT_CUSTOMER"
                            MODEL_APP = CORE_FUNC.BindTable_lcn(MODEL_APP)
                        Case "FUNC-GET_DATA_LCN_EDIT"
                            MODEL_APP.lcn_edit = CORE_FUNC.Binddata_lcn_edit(MODEL_APP)
                        Case "FUNC-GET_DATA_LCN_DETAIL"
                            MODEL_APP.dalcn = CORE_FUNC.Binddata_DALCN(MODEL_APP)
                            MODEL_APP.DALCN_PHR = CORE_FUNC.Binddata_PHR(MODEL_APP)
                            MODEL_APP.DALCN_LOCATION_BSN = CORE_FUNC.Binddata_BSN(MODEL_APP)
                            MODEL_APP.DALCN_LOCATION_ADDRESS = CORE_FUNC.Binddata_LOCATION_ADDRESS(MODEL_APP)
                            MODEL_APP.CLS_ADDR = CORE_FUNC.Binddata_lcn_addr(MODEL_APP)
                        Case "FUNC-GET_DATA_TABEAN_RENEW"
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_Renew_BY_PROCESS_ID(MODEL_APP)
                        Case "FUNC-GET_DATA_TABEAN_RENEW_STAFF"
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_Renew_Saff(MODEL_APP)
                        Case "FUNC-GET_DATA_CONFIRM_RENEW"
                            'MODEL_APP = CORE_FUNC.Binddata_Tabean_Renew_Detail(MODEL_APP)
                            MODEL_APP = CORE_FUNC.GetDataDDL_Discount(MODEL_APP)
                        Case "FUNC-GET_DATA_RENEW_UPLOAD"
                            MODEL_APP = CORE_FUNC.GET_FILE_UPLOAD_TABEAN_CENNTER(MODEL_APP)
                        Case "FUNC-GET_DATA_CONFIRM_RENEW_STAFF"
                            MODEL_APP = CORE_FUNC.Binddata_Tabean_Renew_Detail_Saff(MODEL_APP)
                        Case "FUNC-GET_FILE_TABEAN_RENEW"
                            MODEL_APP = CORE_FUNC.GET_FILE_UPLOAD_TABEAN_CENNTER(MODEL_APP)

                        ''''''''''''''''''''''''''''''''''''''''''' INSERT_DATA '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        Case "FUNC-SAVE_DATA_TABEAN_SUBSTITUTE"
                            MODEL_APP = CORE_FUNC.SaveDataTabeanSubstitute(MODEL_APP)
                        Case "FUNC-SAVE_DATA_CONFIRM_SUBSTITUTE"
                            MODEL_APP = CORE_FUNC.UpdateDataTabeanSubConfirm(MODEL_APP)
                        Case "FUNC-SAVE_DATA_STAFF_CONFIRM_SUBSTITUTE"
                            MODEL_APP = CORE_FUNC.UpdateDataStaffTabeanSubConfirm(MODEL_APP)
                        Case "FUNC-KEEP_STATUS_STAFF_SUBSTITUTE"
                            MODEL_APP = CORE_FUNC.UpdateDataKeepStatusSub(MODEL_APP)
                        Case "FUNC-ADD_REQUEST_TABEAN_RENEW"
                            MODEL_APP = CORE_FUNC.ADD_REQUEST_TABEAN_RENEW(MODEL_APP)
                        Case "FUNC-SAVE_DATA_CONFIRM_RENEW"
                            MODEL_APP = CORE_FUNC.UpdateDataConfirmRenew(MODEL_APP)
                        Case "FUNC-KEEP_STATUS_STAFF_RENEW"
                            MODEL_APP = CORE_FUNC.UpdateDataKeepStatusRenew(MODEL_APP)
                        Case "FUNC-SAVE_DATA_STAFF_CONFIRM_RENEW_TABEAN"
                            MODEL_APP = CORE_FUNC.UpdateDataStaffTabeanRenewConfirm(MODEL_APP)

                        ''''''''''''''''''''''''''''''''''''''''''' TB '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        Case "FUNC-SEARCH_DRUG"
                            MODEL_APP.infor_drug = CORE_FUNC.BindTable(MODEL_APP)
                        Case "FUNC-SEARCH_DRR_HERB"
                            MODEL_APP.infor_drr_herb = CORE_FUNC.BindTable_Drr(MODEL_APP)
                        Case "FUNC-SEARCH_LOCATION_DRUG"
                            MODEL_APP.infor_location_drug = CORE_FUNC.BindTable_location(MODEL_APP)
                        Case "FUNC-SEARCH_DALCN_HERB"
                            MODEL_APP.infor_dalcn_herb = CORE_FUNC.BindTable_dalcn_herb(MODEL_APP)

                            '''''''''''''''''''''''''''''''''''''''adv'''''''''''''''''''''''''''''''''''''''''''''
                        Case Else
                            MODEL_APP.RESULT = "ไม่พบฟังก์ชัน"
                    End Select
                Next

                Return MODEL_APP
            Catch ex As Exception
                MODEL_APP.ERR_ALERT = ex.Message
                Return Nothing
            End Try
            Return MODEL_APP
        End Function
        Private Function JSON_CONVERT_DATE(ByVal json As String) As String

            Dim reg = New Regex(""".*?""")
            Dim matches = reg.Matches(json)

            Dim temp As String = ""
            For Each item In matches
                If temp = "" Then
                    temp = item.ToString()
                Else
                    temp = temp & "," & item.ToString()
                End If
            Next

            Dim tempd As String = ""

            For Each ddd As String In temp.Split(",")
                If ddd.Contains("Date(") Then
                    If tempd = "" Then
                        tempd = ddd
                    Else
                        tempd = tempd & "," & ddd
                    End If
                End If
            Next

            For Each Val As String In tempd.Split(",")
                Try
                    Dim reg2 = New Regex("\(.*?\)")
                    Dim matches2 = reg2.Matches(Val)
                    For Each item2 In matches2
                        'item2 = {({(1050035680333)})}
                        Dim datas As String = item2.ToString().Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "")
                        Dim timestamp As Double = datas
                        Dim dateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
                        dateTime = dateTime.AddMilliseconds(timestamp)
                        If dateTime.Year > 2500 Then
                            json = json.Replace(Val, """" & dateTime.AddYears(-543).ToShortDateString() & """")
                        Else
                            Try

                            Catch ex As Exception

                            End Try
                            json = json.Replace(Val, """" & dateTime.ToShortDateString() & """")
                        End If

                    Next
                Catch ex As Exception

                End Try
            Next

            matches = reg.Matches(json)

            temp = ""
            For Each item In matches
                If temp = "" Then
                    temp = item.ToString()
                Else
                    temp = temp & "," & item.ToString()
                End If
            Next

            Dim tempd2 As String = ""
            For Each ddd As String In temp.Split(",")

                If ddd.Contains("/") Then
                    Dim aa As Array = ddd.Split("/")
                    If tempd2 = "" Then

                        If aa.Length >= 2 Then
                            tempd2 = ddd
                        End If

                    Else
                        If aa.Length >= 2 Then
                            tempd2 = tempd2 & "," & ddd
                        End If
                    End If

                End If
            Next
            For Each Val As String In tempd2.Split(",")

                Try
                    'Val = Val.Replace("""", "")
                    Dim ar As Array = Val.Replace("""", "").Split("/")
                    Dim chk_date As String = ""
                    Dim ar2 As Array = ar(2).ToString.Split(" ")
                    If ar2(0) > 2500 Then
                        ar2(0) = CInt(ar2(0)) - 543
                        Try

                            chk_date = ar(1) & "/" & ar(0) & "/" & ar2(0) & " " & ar2(1)

                        Catch ex As Exception
                            Try
                                chk_date = ar(1) & "/" & ar(0) & "/" & ar2(0)
                            Catch ex2 As Exception
                                chk_date = Val
                            End Try

                        End Try

                    Else
                        Try
                            chk_date = ar(0) & "/" & ar(1) & "/" & ar2(0) & " " & ar2(1)
                        Catch ex As Exception
                            Try
                                chk_date = ar(0) & "/" & ar(1) & "/" & ar2(0)
                            Catch ex2 As Exception
                                chk_date = Val
                            End Try
                        End Try

                    End If
                    json = json.Replace(Val, """" & chk_date & """")
                Catch ex As Exception

                End Try

            Next


            Return json
        End Function
    End Class
End Namespace