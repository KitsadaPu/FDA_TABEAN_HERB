app.controller('AUTHEN_GATEWAY_CUSTOMMER_CTRL', function ($scope, $timeout, CENTER_SV) {
    runQuery2();
    pageload();
    function QueryString(name) {//รับพารามิเตอร์จาก Query string
        var regexS = "[\\?&]" + name + "=([^&#]*)",
            regex = new RegExp(regexS),
            results = regex.exec(window.location.search);
        if (results === null) {
            return "";
        } else {
            return decodeURIComponent(results[1].replace(/\+/g, " "));
        }
    }

    function runQuery2() { //รับพารามิเตอร์จาก Query string
        $scope.TOKEN = QueryString("Token");
        //$scope.TOKEN = 'VBM0pfbhUWffntYiVwNeTAUU'
        $scope.PROCESS_ID = QueryString("PROCESS_ID");
        $scope.citizen_authen = QueryString("citizen_authorize");
        $scope.IDA_LCN = QueryString("IDA_LCN");
        $scope.IDA_LCT = QueryString("IDA_LCT");
    }

    function pageload() {
        $scope.pick_v = 0;
        var getDATA = CENTER_SV.GET_SET_FULL_MODEL_CUTOMMER($scope.TOKEN);
        getDATA.then(function (datas) {
            if (datas.data.ERR_ALERT != null) {
            }
            $scope.FULL_MODEL = datas.data;
            $scope.CLS_SESSION = datas.data.CLS_SESSION;
            if (($scope.IDA_LCN !== "") && ($scope.IDA_LCT !== "") && ($scope.citizen_authen !== "")) {
                $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
                $scope.FULL_MODEL.CITIZEN_AUTHORIZE = $scope.citizen_authen;
            }
            if ($scope.CLS_SESSION.SYSTEM_ID == 11309) {
                $scope.PROCESS_ID = datas.data.List_SET_PAGE_MAIN_HERB[0].PROCESS_ID
            }     
            $scope.GET_LEFT_MAIN = $scope.FULL_MODEL.List_SET_PAGE_MAIN_HERB;
            $scope.SET_SUB_PAGE_MAIN = $scope.FULL_MODEL.List_SET_PAGE_SUB_MAIN_HERB;
            SET_PATH_PAGE_MAIN($scope.PROCESS_ID);
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.btn_log_out = function () {
        log_out();
    };

    $scope.BTN_ADD_LCN_EDIT_CLICK = function (path, cactive, IDA, datas) {
        $scope.his_main = $scope.his_main;
        $scope.IDA_LCN = IDA;
        $scope.SET_MAIN_PAGE = path;
    };

    function SET_PATH_PAGE_MAIN(proces_id) {
        if ((proces_id == "20610") && ($scope.IDA_LCN !== "") && ($scope.IDA_LCT !== "") && ($scope.citizen_authen !== "")) {
            $scope.SET_MAIN_PAGE = "../TABEAN_SUBSTITUTE/Substitute_Choose_Tabean";
        } else if (proces_id == "20610") {
            $scope.SET_MAIN_PAGE = "../TABEAN_SUBSTITUTE/Substitute_Main";
        } else if (proces_id == "20710") {
            $scope.SET_MAIN_PAGE = "../TABEAN_RENEW/Renew_Main";
        }
    }

    $scope.BTN_PAYMENT_CLICK = function () {
        $scope.path_url = "https://platba.fda.moph.go.th/FDA_FEE/MAIN/check_token.aspx?Token=" + $scope.TOKEN + "&system=herb&identify=" + $scope.CLS_SESSION.CITIZEN_ID_AUTHORIZE
        window.open($scope.path_url, "_blank");
        return
    };

    $scope.BTN_BACK_PAGE_CLICK = function (path) {
        $scope.SET_MAIN_PAGE = path;
        //remove_doc()
        //doc_datatable()
    };

    $scope.show_attach_preview = function (Path_ID) {
        window.open("../PDF/PREVIEW_FILE_ATTACH.aspx?Path_ID=" + Path_ID, "_blank");
    };

    $scope.SET_PARAM = function (IDA, IDA_DR, TR_ID, IDA_LCN, Newcode, MODEL) {
        $scope.IDA = IDA;
        $scope.IDA_DR = IDA_DR;
        $scope.TR_ID = TR_ID;
        $scope.IDA_LCN = IDA_LCN;
        $scope.Newcode = Newcode;
        $scope.NAME_THAI = $scope.FULL_MODEL.NAME_THAI;
    }

    $scope.SET_PARAM2 = function (MODEL) {
        $scope.IDA = MODEL.IDA;
        $scope.IDA_DR = MODEL.IDA_DR;
        $scope.IDA_LCN = MODEL.IDA_LCN;
        $scope.TR_ID = MODEL.TR_ID;
        $scope.NAME_THAI = MODEL.NAME_THAI;
        $scope.NAME_ENG = MODEL.NAME_ENG;
        $scope.RGTNO_DISPLAY = MODEL.RGTNO_DISPLAY;
        $scope.PROCESS_ID = MODEL.PROCESS_ID;
        $scope.Newcode = MODEL.Newcode;
        $scope.STATUS_LCN = MODEL.STATUS_LCN;
        $scope.STATUS_ID = MODEL.STATUS_ID;
    }

    $scope.SET_PAGE = function (path) {
        $scope.SET_MAIN_PAGE = path;
    }
    $scope.SET_POPUP_PAGE = function (path) {
        $scope.SET_MAIN_POPUP_PAGE = path;
    };
    $scope.SELECT_PAGR = function (PAGE) {
        $scope.Page = PAGE;
    };

    function GET_DATA(func_code, ida) {
        var senddata = {
            FUNC_CODE: func_code,
            IDA: ida,
        }
        var getData = CENTER_SV.GET_DATA(senddata);
        getData.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.cer_dalcn_herb = datas.data.cer_dalcn_herb;

        }, function () {
            alert($scope.error_message);
        });
    };

    $scope.BTN_MENU_CLICK = function (path, cactive, id, PROCESS_ID, MAIN_PATH, datas) {
        $scope.his_main = path;
        $scope.PATH_NAME = MAIN_PATH;
        $scope.IDA = 0;
        $scope.cactive = cactive;
        $scope.PROCESS_ID = PROCESS_ID;
        chk_active2(datas.PAGE_NAME);
        $scope.active_menu = active_menu;
        $scope.MENU_ID = datas.IDA;
        //$scope.MENU_ID = datas.IDA;
    };

    $scope.BTN_SUB_MENU_CLICK = function (path, cactive, index, PROCESS_ID, MAIN_PATH, datas) {
        $scope.SET_MAIN_PAGE = path;
        $scope.his_main = path;
        $scope.PATH_NAME = MAIN_PATH;
        $scope.PROCESS_ID = PROCESS_ID;
        $scope.cactive = cactive;
        $scope.PROCESS_ID = PROCESS_ID;
    };

    $scope.convert_int = function (number) {
        return parseInt(number);
    };
    //$scope.today = function () {
    //    $scope.dt = new Date();
    //};
    //$scope.today();

    
    //// ตาราง
    //$scope.doc_datatable_custommer = function () {
    //    setTimeout(function () {
    //        $('.dataTables-example').DataTable({
    //            pageLength: 25,
    //            responsive: true,
    //            destroy: true,
    //            dom: '<"html5buttons"B>lTfgitp',
    //            buttons: [
    //                { extend: 'copy' },
    //                //{ extend: 'csv' },
    //                { extend: 'excel', title: 'ExampleFile' },
    //                //{ extend: 'pdf', title: 'ExampleFile' },

    //                {
    //                    extend: 'print',
    //                    customize: function (win) {
    //                        $(win.document.body).addClass('white-bg');
    //                        $(win.document.body).css('font-size', '10px');


    //                    }
    //                }
    //            ]

    //        });
    //    }, 100);
    //};

    //$scope.remove_doc_custommer = function () {
    //    $('.dataTables-example').DataTable().destroy();
    //}
    //// แปลงวัน
    //$scope.CHANGE_FORMATDATE_typedate = function (DATE_CHANGE) {
    //    var dateString = DATE_CHANGE.substr(6);
    //    var currentTime = new Date(parseInt(dateString));
    //    var month = currentTime.getMonth() + 1;
    //    var day = currentTime.getDate();
    //    var year = currentTime.getFullYear();
    //    return DATE_CHANGE = month + "/" + day + "/" + year;
    //}
    //$scope.con_to_date = function (dateString) {
    //    try {
    //        var dateArray = new Date(dateString);


    //    }
    //    catch (err) {
    //    }
    //    return dateArray;
    //};

});



