app.controller('AUTHEN_GATEWAY_STAFF_CTRL', function ($scope, $timeout, CENTER_SV) {
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
        $scope.TOKEN = '/vIBd7bjVxwJkS4MdtaDQwUU'
        $scope.PROCESS_ID = QueryString("PROCESS_ID");
        //$scope.PROCESS_ID = 20610;
        $scope.citizen_authen = QueryString("citizen_authorize");
        //$scope.citizen_authen = '0105560101256';
        $scope.IDA_LCN = QueryString("IDA_LCN");
        //$scope.IDA_LCN = 57727;
        $scope.IDA_LCT = QueryString("IDA_LCT");
        // $scope.IDA_LCT = 53912;
    }

    function pageload() {
        $scope.pick_v = 0;
        var getDATA = CENTER_SV.GET_SET_FULL_MODEL($scope.TOKEN);
        getDATA.then(function (datas) {
            if (datas.data.ERR_ALERT != null) {
                Swal.fire({
                    title: datas.data.ERR_ALERT,
                    showDenyButton: true,
                    denyButtonText: 'ตกลง',
                }).then((result) => {
                    if (result.value == true) {
                        location.replace("https://privus.fda.moph.go.th/");
                    } else if (result.value == false) {
                    }
                });
            }
            $scope.FULL_MODEL = datas.data;
            if (($scope.IDA_LCN !== "") && ($scope.IDA_LCT !== "") && ($scope.citizen_authen !== "")) {
                $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
                $scope.FULL_MODEL.CITIZEN_AUTHORIZE = $scope.citizen_authen;
                $scope.FULL_MODEL.STAFF_ID = 1;
            }
            $scope.CLS_SESSION = datas.data.CLS_SESSION;
            $scope.GET_LEFT_MAIN = $scope.FULL_MODEL.List_SET_PAGE_MAIN_HERB;
            $scope.SET_SUB_PAGE_MAIN = $scope.FULL_MODEL.List_SET_PAGE_SUB_MAIN_HERB;
            SET_PATH_PAGE_MAIN($scope.PROCESS_ID)
        }, function () {
            alert($scope.error_message)
        });
    }


    $scope.btn_log_out = function () {
        log_out();
    };

    $scope.BTN_ADD_LCN_EDIT_CLICK = function (path, cactive, IDA, datas) {

        //var send_data = {
        //    FUNC_CODE: 'FUNC-INSERT_IDA_CER_LCN',
        //    IDA_LCN: IDA,
        //    dalcn_herb: datas,
        //};
        //var getDATA = CENTER_SV.GET_DATA(send_data);
        //getDATA.then(function (datas) {

        //$scope.IDA = datas.data.CER_HERB_LCN.IDA
        $scope.his_main = $scope.his_main;
        $scope.IDA_LCN = IDA;
        //$scope.cactive = cactive;
        //$('#myModal2').modal('hide');
        $scope.SET_MAIN_PAGE = path;
        //}, function () {
        //    alert("ระบบมีปัญหา")
        //})
    };

    function SET_PATH_PAGE_MAIN(proces_id) {
        if ((proces_id == "20610") && ($scope.IDA_LCN !== "") && ($scope.IDA_LCT !== "") && ($scope.citizen_authen !== "")) {
            $scope.SET_MAIN_PAGE = "../TABEAN_SUBSTITUTE/Substitute_Choose_Tabean";
        } else if (proces_id == "20610") {
            $scope.SET_MAIN_PAGE = "../TABEAN_SUBSTITUTE_STAFF/Substitute_Staff_Main";
        } else if (proces_id == "20710") {
            $scope.SET_MAIN_PAGE = "../TABEAN_RENEW_STAFF/Renew_Staff_Main";
        }
    }

    $scope.BTN_MENU_CLICK = function (path, cactive, id, PROCESS_ID, MAIN_PATH, datas) {
        $scope.his_main = path;
        $scope.PATH_NAME = MAIN_PATH;
        $scope.IDA = 0;
        $scope.cactive = cactive;
        $scope.PROCESS_ID = PROCESS_ID;
        chk_active(datas.PAGE_NAME);
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

    $scope.BTN_BACK_PAGE = function () {
        $scope.SET_MAIN_PAGE = $scope.his_main;
    };

    $scope.BTN_BACK_PAGE_CLICK = function (path) {
        //$scope.his_main = path;
        //$scope.his_main = $scope.SET_MAIN_PAGE;
        $scope.SET_MAIN_PAGE = path;

        //remove_doc()
        //doc_datatable()
    };

    $scope.show_attach_preview = function (Path_ID) {
        window.open("../PDF/PREVIEW_FILE_ATTACH.aspx?Path_ID=" + Path_ID, "_blank");
    };

    $scope.SET_PARAM = function (IDA, IDA_DR,TR_ID, IDA_LCN,Newcode,MODEL) {
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

    $scope.BTN_REPLACE_CLICK = function (path,PROCESS_ID, IDA, IDENTIFY, datas) {
        $scope.SET_MAIN_PAGE = path;
        $scope.his_main = path;
        $scope.IDA_LCN = IDA;
        $scope.FULL_MODEL.IDA_LCN = IDA;
        $scope.FULL_MODEL.CLS_SESSION.CITIZEN_ID_AUTHORIZE = IDENTIFY;
        $scope.FULL_MODEL.CITIZEN_AUTHORIZE = IDENTIFY;
        $scope.FULL_MODEL.STAFF_ID = 1;
        remove_doc()
        doc_datatable()
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
    }

    $scope.convert_int = function (number) {
        return parseInt(number);
    };
    //function chk_active(name) {
    //    if ($scope.active_menu == name) {
    //        $scope.active_menu = "";
    //        $scope.MENU_ID = 0;
    //        var current = document.getElementsByClassName("collapse ng-scope nav nav-second-level");
    //        var len_css = current.length;
    //        for (var i = 0; i < len_css; i++) {
    //            current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level in", "collapse ng-scope nav nav-second-level off");

    //        }
    //    } else {
    //        if ($scope.active_menu == "") {
    //            var current = document.getElementsByClassName("collapse ng-scope nav nav-second-level");
    //            var len_css = current.length;
    //            for (var i = 0; i < len_css; i++) {
    //                if (current[i].className == "collapse ng-scope nav nav-second-level off") {
    //                    current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level off", "collapse ng-scope nav nav-second-level in");
    //                } else {
    //                    current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level off", "collapse ng-scope nav nav-second-level in");
    //                }
    //            }
    //            $scope.active_menu = name;
    //        } else {
    //            $scope.active_menu = name;
    //        }

    //    }
    //};
});



