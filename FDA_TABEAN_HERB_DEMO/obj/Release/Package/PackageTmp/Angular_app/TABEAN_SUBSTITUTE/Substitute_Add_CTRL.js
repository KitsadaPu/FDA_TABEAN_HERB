
app.controller('Substitute_Add_CTRL', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';

     pageload()
    function pageload() {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATATABLE_TABEAN_SUB';
        $scope.FULL_MODEL.CLS_SESSION = $scope.FULL_MODEL.CLS_SESSION;
        $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
        $scope.FULL_MODEL.IDA_DR = $scope.IDA_DR;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.Newcode = $scope.Newcode;
        /* $scope.SENT_DATAS();*/
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_STAFF_CONFIRM_CLICK = function (path) {
        $scope.SET_PAGE(path);
        pageload();
        $scope.SENT_DATAS();
    };

    $scope.BTN_SAVE_DATA_SUBSTITUTE_CLICK = function (path) {  
        var modal = $('#Substitute_modal')
        if (path == '../TABEAN_SUBSTITUTE/Substitute_Add') {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_TABEAN_SUBSTITUTE';
            $scope.FULL_MODEL = $scope.FULL_MODEL
            $scope.SENT_DATAS();     
            $scope.SET_POPUP_PAGE('../TABEAN_SUBSTITUTE/Substitute_Upload');
            alert('บันทึกข้อมูลแล้ว กรุณาอัพโหลดเอกสารแนบ')
        } else if (path == '../TABEAN_SUBSTITUTE/Substitute_Confirm_Detail') {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_CONFIRM_SUBSTITUTE';
            $scope.SENT_DATAS();
        } else if (path == '../TABEAN_SUBSTITUTE/Substitute_Upload') {
            alert('บันทึกข้อมูลแล้ว กรุณากดดูรายละเอียดเพื่อตรวจสอบความถูกต้องก่อนยืนคำขอ')
            modal.modal('hide');
            pageload();
        } 
    };

    $scope.BTN_SUBSTITUTE_DETAIL_CLICK = function (IDA, STATUS_ID, FK_LCN, TR_ID, PROCESS_ID, X) {
        var modal = $('#Substitute_modal')
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_CUSTOMER';
        $scope.SET_POPUP_PAGE('../TABEAN_SUBSTITUTE/Substitute_Confirm');
        $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
        $scope.FULL_MODEL.TR_ID = TR_ID;
        $scope.FULL_MODEL.IDA = IDA;
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            //$scope.FULL_MODEL.STATUS_ID = STATUS_ID;
            //$scope.FULL_MODEL.TR_ID = TR_ID;
            //$scope.FULL_MODEL.IDA = IDA;
            modal.find('.modal-title').text('รายละเอียดคำขอ');
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };
    $scope.BTN_SUBSTITUTE_ADD_CLICK = function (path,) {
        /*$scope.SET_PAGE(path);*/
        /*        $scope.SENT_DATAS();*/
        $scope.FULL_MODEL.NAME_ENG = $scope.NAME_ENG;
        $scope.FULL_MODEL.NAME_THAI = $scope.NAME_THAI;
        $scope.FULL_MODEL.RGTNO_DISPLAY = $scope.RGTNO_DISPLAY;
        $scope.FULL_MODEL.IDA_DR = $scope.IDA_DR;
        $scope.FULL_MODEL.IDA = 0;
        $scope.FULL_MODEL.Newcode = $scope.Newcode;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_SUBSTITUTE';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            var modal = $('#Substitute_modal')
            modal.find('.modal-title').text('คำขอใบแทนสำหรับผลิตภัณฑ์สมุนไพร');
            $scope.SET_POPUP_PAGE(path);
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_CONFIRM_CLICK = function (path,) {
        var modal = $('#Substitute_modal')
        /* $scope.SET_POPUP_PAGE('../TABEAN_SUBSTITUTE/Substitute_Confirm_Detail');*/
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_CONFIRM_SUBSTITUTE';
        //$scope.FULL_MODEL = $scope.FULL_MODEL;
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            alert('ยื่นคำขอแล้วข้อมูลแล้ว รอเจ้าหน้าที่รับคำขอ')
            modal.modal('hide');
            pageload();      
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_EDIT_DATA_CONFIRM_CLICK = function (path,) { 
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_SUBSTITUTE';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
            $scope.SET_POPUP_PAGE('../TABEAN_SUBSTITUTE/Substitute_Add');
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };
    $scope.BTN_EDIT_FILE_CONFIM_CLICK = function (path,) {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_FILE_UPLOAD';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
            $scope.SET_POPUP_PAGE('../TABEAN_SUBSTITUTE/Substitute_Upload');
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.SENT_DATAS = function () {
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;

            remove_doc()
            doc_datatable()
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