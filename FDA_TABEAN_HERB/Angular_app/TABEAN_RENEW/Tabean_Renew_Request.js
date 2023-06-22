
app.controller('Tabean_Renew_Request', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';

    pageload()
    function pageload() {
        $scope.FULL_MODEL.IDA_DR = $scope.IDA_DR;
        $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.Newcode = $scope.Newcode;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_RENEW';
        /* $scope.SENT_DATAS();*/
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_RENEW_ADD_CLICK = function () {
        var modal = $('#Renew_modal')
        if ($scope.STATUS_LCN == 'หมดอายุ') {
            modal.hide();
            alert('ไม่สามารถต่ออายุใบสำคัญการขึ้นทะเบียน / ใบรับแจ้งรายละเอียด / ใบรับจดแจ้งผลิตภัณฑ์สมุนไพร ได้ เนื่องจาก สถานที่ผลิต / นำเข้า ผลิตภัณฑ์สมุนไพร ตามใบสำคัญฯ ของท่าน ไม่มีสภาพตามกฎหมายผลิตภัณฑ์สมุนไพร แล้ว')
        } else {
            modal.modal('show');
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Request_Add')
            modal.find('.modal-title').text('รายละเอียดคำขอ');
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + $scope.IDA_DR + "&TR_ID=" + $scope.TR_ID + "&PROCESS_ID=" + $scope.FULL_MODEL.PROCESS_ID + "&IDA_LCN=" + $scope.IDA_LCN;
        };     
    };

    $scope.BTN_SAVE_DATA_RENEW_CLICK = function (path) {
        if (path == '../TABEAN_RENEW/Renew_Confirm_Detail') {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_CONFIRM_RENEW';
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
                var modal = $('#Renew_modal')
                modal.hide();
                pageload();
                $scope.remove_doc();
                $scope.doc_datatable();
            }, function () {
                alert($scope.error_message)
            })
        } else {
            var modal = $('#Renew_modal')
            modal.hide();
            pageload();
        }
      
    };

    $scope.BTN_EDIT_FILE_CONFIM_CLICK = function () {
        $scope.FULL_MODEL.TR_ID = $scope.TR_ID;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_FILE_TABEAN_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;

            var modal = $('#Renew_modal')
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Upload_file')
            modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })

    };

    $scope.BTN_RENEW_DETAIL_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME) {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_RENEW';
            $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
            $scope.FULL_MODEL.TR_ID = TR_ID;
            $scope.FULL_MODEL.IDA_DR = IDA_DR;
            $scope.FULL_MODEL.IDA = IDA;
            $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
            $scope.SET_PARAM2($scope.FULL_MODEL);
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                $scope.FULL_MODEL = datas.data;

                var modal = $('#RenewTabeanStaff_Modal')
                /*    var date_now = new Date(Date.now()).toLocaleString("th-TH", { timeZone: "UTC" });*/
                modal.find('.modal-title').text('รายละเอียดคำขอต่ออายุ');
                if (STATUS_ID != 8) {
                    $scope.FULL_MODEL.CONFIRM_STATUS_ID = "";
                    $scope.FULL_MODEL.STAFF_NAME_ID = "";
                };
                $scope.FULL_MODEL.DATE_CONNFIRM = new Date();
                $scope.FULL_MODEL.STATUS_NAME = STATUS_NAME
                $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Confirm')
                $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
                $scope.remove_doc();
                $scope.doc_datatable();
            }, function () {
                alert($scope.error_message)
            })
    };

    $scope.BTN_ADD_REQUEST_CLICK = function () {
        $scope.FULL_MODEL.Newcode = $scope.Newcode;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-ADD_REQUEST_TABEAN_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;

            var modal = $('#Renew_modal')
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Upload_file')
            modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_CONFIRM_CLICK = function () {
            var modal = $('#Renew_modal')
        $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Confirm_Detail')
            modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
    };
    
    $scope.BTN_RENEW_DETAIL_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME) {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_RENEW';
        $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
        $scope.FULL_MODEL.TR_ID = TR_ID;
        $scope.FULL_MODEL.IDA_DR = IDA_DR;
        $scope.FULL_MODEL.IDA = IDA;
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        $scope.SET_PARAM2($scope.FULL_MODEL);
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            var modal = $('#RenewTabeanStaff_Modal')
            modal.find('.modal-title').text('รายละเอียดใบนัดหมายคำขอต่ออายุใบสำคัญ');
            if (STATUS_ID != 8) {
                $scope.FULL_MODEL.CONFIRM_STATUS_ID = "";
                $scope.FULL_MODEL.STAFF_NAME_ID = "";
            };
            $scope.FULL_MODEL.DATE_CONNFIRM = new Date();
            $scope.FULL_MODEL.STATUS_NAME = STATUS_NAME
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Confirm')
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.SENT_DATAS = function () {
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.Uploadattact = function (FileForUpload, AttachfUp_IDA, TOPIC_IDA, IDA, CITIZEN_ID, PROCESS_ID, Index, fl) { //อัพโหลดไฟล์เเนบบังคับ
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
                        alert("กรุณาอัพโหลดไฟล์ PDF เท่านั้น")
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
});