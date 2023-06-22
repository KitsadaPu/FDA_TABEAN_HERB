app.controller('Tabean_Renew_Staff', function ($scope, Upload, CENTER_SV) {

    pageload()
    function pageload() {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_RENEW_STAFF';
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_STAFF_CONFIRM_CLICK = function () {
        if ($scope.FULL_MODEL.CONFIRM_STATUS_ID != undefined && $scope.FULL_MODEL.CONFIRM_STATUS_ID != "") {
            var temp = $scope.FULL_MODEL.ddl_status_staff.filter(x => x.STATUS_ID == $scope.FULL_MODEL.CONFIRM_STATUS_ID);
            $scope.FULL_MODEL.CONFIRM_STATUS_NAME = temp[0].STATUS_NAME_STAFF;
            $scope.FULL_MODEL.CONFIRM_STATUS_ID = temp[0].STATUS_ID;
        };

        if ($scope.FULL_MODEL.STAFF_NAME_ID != undefined && $scope.FULL_MODEL.STAFF_NAME_ID != "") {
            var temp = $scope.FULL_MODEL.ddl_staff_name.filter(x => x.IDA == $scope.FULL_MODEL.STAFF_NAME_ID);
            $scope.FULL_MODEL.STAFF_NAME_CONFIRM = temp[0].STAFF_NAME;
            $scope.FULL_MODEL.STAFF_NAME_ID = temp[0].IDA;
        };
        if ($scope.FULL_MODEL.CONFIRM_STATUS_ID == 11) {
            var modal = $('#RenewTabeanStaff_Modal')
            modal.find('.modal-title').text('แก้ไขเอกสารแนบคำขอต่ออายุ');
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Edit_File')
        } else {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_STAFF_CONFIRM_RENEW_TABEAN';
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
                $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
                $('#RenewTabeanStaff_Modal').modal('hide')
                pageload();
                $scope.remove_doc();
                $scope.doc_datatable();
            }, function () {
                alert($scope.error_message)
            })
        }
    
       
    };

    $scope.BTN_TABEAN_RENEW_STAFF_DETAIL_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME) {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_RENEW_STAFF';
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
        /* $scope.GET_DATA_CENTER();*/
    };

    $scope.BTN_PREVIEW_SUBSTITUTE_CLICK = function () {
        window.open("../PDF/PDF_PREVIEW.aspx?IDA=" + $scope.IDA_DR + "&TR_ID=" + $scope.TR_ID + "&PROCESS_ID=" + $scope.PROCESS_ID);
    };
    $scope.BTN_STAFF_KEEP_STATUS_CLICK = function () {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-KEEP_STATUS_STAFF_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            pageload();
            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.GET_DATA_CENTER = function () {
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };
});