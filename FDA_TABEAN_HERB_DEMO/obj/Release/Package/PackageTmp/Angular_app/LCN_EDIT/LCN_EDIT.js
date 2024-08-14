
app.controller('LCN_EDIT', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';

    pageload()
    function pageload() {
        $scope.pick_v = 0;
        /* var date_now = new Date(Date.now()).toLocaleString("th-TH", { timeZone: "UTC" });*/
        var send_data = {
            FUNC_CODE: 'FUNC-GET_DATA_LCN_EDIT',
            CLS_SESSION: $scope.FULL_MODEL.CLS_SESSION,
            IDA_LCN: $scope.IDA_LCN
        };

        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {
            $scope.lcn_edit = datas.data.lcn_edit;
            //alert('ค้นหาเรียบร้อย');
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    //$scope.BTN_ADD_LCN_EDIT_CLICK = function (path, cactive, IDA, datas) {

    //    //var send_data = {
    //    //    FUNC_CODE: 'FUNC-INSERT_IDA_CER_LCN',
    //    //    IDA_LCN: IDA,
    //    //    dalcn_herb: datas,
    //    //};
    //    //var getDATA = CENTER_SV.GET_DATA(send_data);
    //    //getDATA.then(function (datas) {

    //        $scope.IDA = datas.data.CER_HERB_LCN.IDA
    //        $scope.his_main = $scope.his_main;
    //        $scope.IDA_LCN = IDA;
    //        //$scope.cactive = cactive;
    //        //$('#myModal2').modal('hide');
    //        $scope.SET_MAIN_PAGE = path;
    //    //}, function () {
    //    //    alert("ระบบมีปัญหา")
    //    //})
    //};

    $scope.today = function () {
        $scope.DATE_CONFIRM = new Date();
    };
    $scope.today();

    $scope.fil_req_date = function () {
        var date_now = new Date(Date.now()).toLocaleString("th-TH", { timeZone: "UTC" });
        $scope.CER_HERB_LCN.WRITE_AT = date_now;
        $scope.format = 'dd/MM/yyyy';
        $scope.date = new Date();
        return date_now;
    }

    $scope.fil_req_staff_name = function () {
        var req_type = $scope.DDL_STAFF_NAME.filter(x => x.IDA);
        //$scope.FULL_MODEL.DDL_STAFF_NAME = req_type[0].STAFF_NAME;   
        //$scope.STAFF_NAME = x.STAFF_NAME;
        $scope.FULL_MODEL.DDL_STAFF_NAME = x.IDA;

    };

    $scope.fil_tyre_cer = function () {
        var req_type = $scope.ddl_type_cer_lcn.filter(x => x.ID);
        //$scope.FULL_MODEL.ddl_type_cer_lcn = req_type[0].language_cer;
        $scope.FULL_MODEL.ddl_type_cer_lcn = x.ID
    };

    $scope.fil_req_status = function () {
        var req_type = $scope.DDL_STATUS.filter(x => x.STATUS_ID);
        //$scope.FULL_MODEL.DDL_STATUS = req_type[0].STATUS_NAME;   
        $scope.FULL_MODEL.STATUS_ID = x.STATUS_ID
    };


    $scope.show_attach_preview = function (NAME) {
        window.open("../PDF/PREVIEW_FILE_ATTACH_LCN.aspx?filename=" + NAME, "_blank");

    };

    $scope.Uploadattact2 = function (FileForUpload, AttachfUp_IDA, TOPIC_IDA, IDA, CITIZEN_ID, PROCESS_ID, Index, fl) { //อัพโหลดไฟล์เเนบบังคับ
        console.log(fl);


        if (FileForUpload == undefined || FileForUpload == "") {
            alert("กรุณาเลือกไฟล์")
            return false;
        }
        else {

            try {
                Upload.upload({
                    method: "post",
                    url: '../HOME/Upload_Attach',
                    data:
                    {
                        FileForUpload: FileForUpload,
                        AttachfUp_IDA: AttachfUp_IDA,
                        //TOPIC_IDA: TOPIC_IDA,
                        PROCESS_ID: PROCESS_ID,
                        IDA: IDA,
                        //CITIZEN_ID: $scope.FULL_MODEL.AUTHEN_INFORMATION.CITIZEN_ID,
                        FILE_UPLOAD_TABLE: JSON.stringify(fl),
                        INDEX: Index,
                        //EXPLAIN_IDA: $scope.EXPLAIN_IDA,
                        //STEP_: $scope.waytoupload,
                        //CITIZEN_NAME: $scope.FULL_MODEL.AUTHEN_INFORMATION.CITIZEN_NAME

                    }
                }).then(function (resp) {
                    var message = resp.data;
                    if (message == "กรุณาอัพโหลดไฟล์PDFเท่านั้น") {
                        alert("กรุณาอัพโหลดไฟล์PDFเท่านั้น")
                    }
                    else {
                        $scope.FILEUPLOADTABLE[Index] = resp.data;


                        console.log('fl : ', fl);

                        console.log("FILEUPLOADTABLE ", $scope.FILEUPLOADTABLE[Index]);
                    }

                    console.log('resp.data' + resp.data);

                });
            }
            catch (err) {

                alert("Error!")

            }

        }
    };

    $scope.BTN_SEARCH_CUSTOMER = function () {

        var send_data = {
            FUNC_CODE: 'FUNC-SEARCH_DATA_CUSTOMER',
            IDA: $scope.IDA,
            IDA: $scope.IDA_LCN,
            TR_ID: $scope.TR_ID,
            NAME_SEARCH: $scope.FULL_MODEL.NAME_SEARCH,
            IDEN_SEARCH: $scope.FULL_MODEL.IDEN_SEARCH,
            CLS_SESSION: $scope.FULL_MODEL.CLS_SESSION,
        };
        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {

            $scope.FILE_ATTACH = datas.data.FILE_ATTACH;
            $scope.FILEUPLOADTABLE_STAFF = datas.data.FILEUPLOADTABLE_STAFF;
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID;
        }, function () {
            alert("ระบบมีปัญหา")
        })

    };


    $scope.BTN_SAVE_DATA_EDIT_STAFF = function () {

        var send_data = {
            FUNC_CODE: 'FUNC-SAVE_DATA_EDIT_STAFF',
            IDA: $scope.IDA,
            IDA_LCN: $scope.IDA_LCN,
            CLS_SESSION: $scope.FULL_MODEL.CLS_SESSION,
            CER_HERB_LCN: $scope.CER_HERB_LCN,
            FILE_ATTACH: $scope.FILE_ATTACH,
        };
        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {

            $scope.CER_HERB_LCN = datas.data.CER_HERB_LCN;
            $scope.IDA_LCN = $scope.IDA_LCN;


            alert("บันทึกข้อมูลแล้ว")
            $('#myModal_lcn_staff').modal('hide');
            pageload()
        }, function () {
            alert("ระบบมีปัญหา")
        })

    };

    $scope.Uploadattact = function (FileForUpload, AttachfUp_IDA, TOPIC_IDA, IDA, CITIZEN_ID, PROCESS_ID, Index, fl) { //อัพโหลดไฟล์เเนบบังคับ
        console.log(fl);


        if (FileForUpload == undefined || FileForUpload == "") {

            alert("กรุณาเลือกไฟล์")
        }

        else {

            try {


                Upload.upload({
                    method: "post",
                    url: '../HOME/Upload_Attach_Staff',
                    data:
                    {
                        FileForUpload: FileForUpload,
                        AttachfUp_IDA: AttachfUp_IDA,
                        //TOPIC_IDA: TOPIC_IDA,
                        PROCESS_ID: PROCESS_ID,
                        IDA: IDA,
                        //CITIZEN_ID: $scope.FULL_MODEL.AUTHEN_INFORMATION.CITIZEN_ID,
                        FILE_UPLOAD_TABLE: JSON.stringify(fl),
                        INDEX: Index,
                        //EXPLAIN_IDA: $scope.EXPLAIN_IDA,
                        //STEP_: $scope.waytoupload,
                        //CITIZEN_NAME: $scope.FULL_MODEL.AUTHEN_INFORMATION.CITIZEN_NAME

                    }
                }).then(function (resp) {
                    var message = resp.data;
                    if (message == "กรุณาอัพโหลดไฟล์PDFเท่านั้น") {
                        alert("กรุณาอัพโหลดไฟล์ PDF เท่านั้น")
                    }
                    else {
                        $scope.FILEUPLOADTABLE_STAFF[Index] = resp.data;


                        console.log('fl : ', fl);

                        console.log("FILEUPLOADTABLE_STAFF ", $scope.FILEUPLOADTABLE_STAFF[Index]);
                    }

                    console.log('resp.data' + resp.data);



                });
            }
            catch (err) {
                alert("Error!")

            }

        }
    };
});