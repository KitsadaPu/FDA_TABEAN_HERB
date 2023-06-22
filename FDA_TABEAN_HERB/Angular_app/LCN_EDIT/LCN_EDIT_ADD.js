app.controller('LCN_EDIT_ADD', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';

    pageload()
    function pageload() {
        $scope.pick_v = 0;
        /* var date_now = new Date(Date.now()).toLocaleString("th-TH", { timeZone: "UTC" });*/
        var send_data = {
            FUNC_CODE: 'FUNC-GET_DATA_LCN_DETAIL',
            CLS_SESSION: $scope.FULL_MODEL.CLS_SESSION,
            IDA_LCN: $scope.IDA_LCN,
            STAFF_ID: $scope.STAFF_ID,
            CITIZEN_AUTHORIZE: $scope.CITIZEN_AUTHORIZE
        };

        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.lcn_edit = datas.data.lcn_edit;
            //alert('ค้นหาเรียบร้อย');
            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

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

   
    $scope.BTN_SAVE_DATA_CLICK = function () {
        var send_data = {
            FUNC_CODE: 'FUNC-INSERT_IDA_LCN_EDIT',
            lcn_edit: $scope.FULL_MODEL.lcn_edit,
            TYPE_EDIT_REQUEST: $scope.FULL_MODEL.TYPE_EDIT_REQUEST,
        };
        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {
            $scope.IDA = datas.data.CER_HERB_LCN.IDA
            $scope.his_main = $scope.SET_MAIN_PAGE;
            $scope.IDA_LCN = IDA;
        /*  $('#myModal2').modal('hide');*/
        $scope.SET_MAIN_PAGE = path;
        }, function () {
            alert("ระบบมีปัญหา")
        })
    };
    $scope.show_attach_preview = function (NAME) {
        window.open("../PDF/PREVIEW_FILE_ATTACH_LCN.aspx?filename=" + NAME, "_blank");

    };

    $scope.select_input = function (ID) {
        if (ID == 2) {
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_1 = false          
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_3 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_4 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_5 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_6 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_7 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_8 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_9 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_10 = false
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_11 = false
        } else if (ID != 2) {
            $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_2 = false
        }
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_2 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_3 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_6 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_7 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_8 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_9 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1 = false
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_10 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1 = false
        //}
        //if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_11 == true) {
        //    $scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1 = false     
        //}
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_PHR';
            modal.find('.modal-title').text('กรณีเปลี่ยน/เพิ่ม/ถอน/แจ้งเปลี่ยนหน้าที่ ผู้มีหน้าที่ปฏิบัติการ');
            modal.modal('show');
        }
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_4 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_TIME';
            modal.find('.modal-title').text('กรณีเปลี่ยนเวลาทำการ');
            modal.modal('show');
        }
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_5 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_PHONE_NUMBER';
            modal.find('.modal-title').text('กรณีเปลี่ยนเบอร์โทรศัพท์/ยกเลิกหมวดผลิตภัณฑ์สมุนไพร');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_2_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1 == true ) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text(' กรณีที่ผู้ขอรับอนุญาตเป็นเจ้าของกรรมสิทธิ์');
            modal.modal('show');
        }
    };
    $scope.select_input_sub_2_2 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text('กรณีที่ผู้ขอรับอนุญาตไม่ได้เป็นเจ้าของกรรมสิทธิ์');
            modal.modal('show');
        }

    };
    $scope.select_input_sub_2_3 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text('กรณีทะเบียนบ้านไม่มีผู้อยู่อาศัย (ทะเบียนบ้านลอย) ใช้เอกสารอย่างใดอย่างหนึ่ง ดังนี้');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_2_4 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text('กรณี ขอใบอนุญาตผลิตฯ มีเอกสารเพิ่มเติม ดังต่อไปนี้');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_3_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_BSN';
            modal.find('.modal-title').text('กรณีเปลี่ยนผู้ดำเนินกิจการ (นิติบุคคล)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_3_2 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_BSN_2';
            modal.find('.modal-title').text('กรณีที่ผู้ขอรับอนุญาตไม่ได้เป็นเจ้าของกรรมสิทธิ์');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_6_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_ADDR';
            modal.find('.modal-title').text('กรณีเปลี่ยนหมายเลขบ้าน/รายละเอียดของสถานที่ตั้ง');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_7_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_NAME';
            modal.find('.modal-title').text('กรณีผู้รับอนุญาต/ผู้ดำเนินกิจการ/ เปลี่ยนคำนำหน้า/ชื่อตัว/ชื่อสกุล');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_7_2 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_NAME_2';
            modal.find('.modal-title').text('กรณีผู้มีหน้าที่ปฏิบัติการเปลี่ยนคำนำหน้า/ชื่อตัว/ชื่อสกุล');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_8_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_NAME_LOCATION';
            modal.find('.modal-title').text(' กรณีเปลี่ยนชื่อร้าน/ชื่อสถานที่ขายฯ/นำสั่ง/ผลิตฯ (นิติบุคคล)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_8_2 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_NAME_LOCATION_2';
            modal.find('.modal-title').text(' กรณีเปลี่ยนชื่อร้าน/ชื่อสถานที่ขายฯ/นำสั่ง/ผลิตฯ (บุคคลธรรมดา)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_9_q = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text(' กรณีสืบสิทธิ์แทนผู้รับอนุญาตที่เสียชีวิต แต่ไม่เกิน 90 วัน(กรณีนิติบุคคล)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_9_2 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_LOCATION';
            modal.find('.modal-title').text(' กรณีสืบสิทธิ์แทนผู้รับอนุญาตที่เสียชีวิต แต่ไม่เกิน 90 วัน(บุคคลธรรมดา)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_10_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_DRUG_CATEGORY';
            modal.find('.modal-title').text('เพิ่มประเภทการผลิต( กรณีสถานที่ผลิตผลิตภัณฑ์สมุนไพร)');
            modal.modal('show');
        }
    };

    $scope.select_input_sub_11_1 = function () {
        var modal = $('#LCN_EDIT_MODAL')
        if ($scope.FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1 == true) {
            $scope.SET_MAIN_POPUP_PAGE = '../LCN_EDIT/LCN_EDIT_DRUG_CATEGORY';
            modal.find('.modal-title').text('เพิ่มรายการผลิตผลิตภัณฑ์สมุนไพรที่ขออนุญาตนำเข้าหรือขาย(กรณีนำเข้าและขาย)');
            modal.modal('show');
        }
    };

    $('#PHR_MODAL').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget)
        var recipient = button.data('whatever')
        var modal = $(this)
        modal.find('.modal-title').text('กรณีเปลี่ยน/เพิ่ม/ถอน/แจ้งเปลี่ยนหน้าที่ ผู้มีหน้าที่ปฏิบัติการ')
        modal.find('.modal-body input').val(recipient)
    });

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