
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
            $scope.Renew_Tabean = datas.data.Renew_Tabean;

            //remove_doc()
            //doc_datatable()
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
            //    modal.modal('show');
            //    $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Request_Add')
            //    modal.find('.modal-title').text('รายละเอียดคำขอ');
            //    $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + $scope.IDA_DR + "&TR_ID=" + $scope.TR_ID + "&PROCESS_ID=" + $scope.FULL_MODEL.PROCESS_ID + "&IDA_LCN=" + $scope.IDA_LCN;
            $scope.FULL_MODEL.IDA_DR = $scope.IDA_DR;
            $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
            $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
            $scope.FULL_MODEL.Newcode = $scope.Newcode;
            $scope.FULL_MODEL.TABEAN_RENEW = {};
            $scope.FULL_MODEL.IDA = 0;
            $scope.FULL_MODEL.CITIZEN_ID_AUTHORIZE = $scope.CITIZEN_ID_AUTHORIZE;
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_HERB_RENEW';
            /* $scope.SENT_DATAS();*/
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
                $scope.TABEAN_RENEW = datas.data.TABEAN_RENEW;
                $scope.XML_DRUG_PRODUCT_HERB = datas.data.XML_DRUG_PRODUCT_HERB;
                $scope.XML_SEARCH_DRUG_LCN_HERB = datas.data.XML_SEARCH_DRUG_LCN_HERB;
                $scope.XML_SEARCH_DRUG_LCN_LICEN_HERB = datas.data.XML_SEARCH_DRUG_LCN_LICEN_HERB;

                $scope.filter_prefix = function () {
                    var fil_prefix = $scope.FULL_MODEL.ddl_prefix.filter(i => i.prefixcd == $scope.TABEAN_RENEW.BSN_PREFIX_CD);
                    $scope.TABEAN_RENEW.BSN_PREFIX_NM = fil_prefix[0].thanm;
                };
                modal.modal('show');
                $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Request_Add')
                modal.find('.modal-title').text('รายละเอียดคำขอ');
                //remove_doc()
                //doc_datatable()
            }, function () {
                alert($scope.error_message)
            })
        };
    };

    $scope.BTN_SAVE_DATA_RENEW_CLICK = function (path) {
        //if (path == '../TABEAN_RENEW/Renew_Confirm_Detail') {
        //$scope.TABEAN_RENEW = $scope.FULL_MODEL.TABEAN_RENEW;
        //$scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_CONFIRM_RENEW';
        //var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        //getDATA.then(function (datas) {
        //    $scope.FULL_MODEL = datas.data;
        //    var modal = $('#Renew_modal')
        //    modal.hide();
        //    pageload();
        //    remove_doc()
        //    doc_datatable()
        //}, function () {
        //    alert($scope.error_message)
        //})
        //} else
        if (path == '../TABEAN_RENEW/Renew_Edit_File') {
            if ($scope.STATUS_ID == 22) {
                $scope.FULL_MODEL.CONFIRM_STATUS_ID = 25;
            }
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-UPDATE_CONFIRM_EDIT_STAFF';
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                if (datas.data.ALERT_MS != null) {
                    alert(datas.data.ALERT_MS)
                } else {
                    $scope.FULL_MODEL = datas.data;
                    //var modal = $('#Renew_modal')
                    //modal.hide();
                    $('#Renew_modal').fadeOut(500, function () {
                        $('#Renew_modal').modal('hide');
                    });
                    pageload();
                    //remove_doc()
                    //doc_datatable()
                }
            }, function () {
                alert($scope.error_message)
            })
        }
        if (path == '../TABEAN_RENEW/Renew_Upload_file') {
            $scope.FULL_MODEL.FUNC_CODE = 'FUNC-CHECK_FILE_UPLOADS';
            var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
            getDATA.then(function (datas) {
                if (datas.data.ALERT_MS != null) {
                    alert(datas.data.ALERT_MS)
                } else {
                    $scope.FULL_MODEL = datas.data;
                    //var modal = $('#Renew_modal')
                    //modal.hide();
                    $('#Renew_modal').fadeOut(500, function () {
                        $('#Renew_modal').modal('hide');
                    });
                    pageload();
                    //remove_doc()
                    //doc_datatable()
                }
            }, function () {
                alert($scope.error_message)
            })
            //for (var i = 0; i < $scope.FILEUPLOADTABLE.length; i++) {
            //    var item = $scope.FILEUPLOADTABLE[i];
            //    // ทำสิ่งที่ต้องการกับ item ในแต่ละรอบของลูป
            //    if (item.Forcible === 'True' && item.ACTIVE !== 'True') {
            //        // กรณีพบเงื่อนไขที่ต้องการให้แสดง popup
            //        if (i === $scope.FILEUPLOADTABLE.length - 1) {
            //            Swal.fire({
            //                title: 'กรุณาแนบไฟล์ให้ครบถ้วน',
            //                showDenyButton: true,
            //                denyButtonText: 'ตกลง',
            //            }).then((result) => {
            //                if (result.isConfirmed) {
            //                    // ตัวอย่างเช่น กรณีที่ต้องการ redirect
            //                    // window.location.replace("https://privus.fda.moph.go.th/");
            //                }
            //            });
            //        }
            //        break; // หยุดลูปหลังจากแสดง popup แล้ว
            //    } else {
            //        // กรณีอื่นๆ ที่ต้องการทำต่อไป
            //    }
            //}
            //var modal = $('#Renew_modal')
            //modal.hide();
            //pageload();
            //} else {
            //    $('#Renew_modal').fadeOut(500, function () {
            //        $('#Renew_modal').modal('hide');
            //    });
            //    pageload();
        }

    };

    $scope.BTN_SEARCH_LCN_CLICK = function () {
        $scope.FULL_MODEL.TR_ID = $scope.TR_ID;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.TABEAN_RENEW = $scope.TABEAN_RENEW;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SEARCH_LCN_LOCATION';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            if ($scope.TABEAN_RENEW.lcntpcd == datas.data.XML_SEARCH_DRUG_LCN_HERB.lcntpcd) {
                $scope.FULL_MODEL = datas.data;
                $scope.TABEAN_RENEW = datas.data.TABEAN_RENEW;
                $scope.XML_SEARCH_DRUG_LCN_HERB = datas.data.XML_SEARCH_DRUG_LCN_HERB;
                $scope.XML_SEARCH_DRUG_LCN_LICEN_HERB = datas.data.XML_SEARCH_DRUG_LCN_LICEN_HERB;
                //remove_doc()
                //doc_datatable()
            } else {
                alert('ไม่สามารถดึงข้อมูลที่ประเภทใบอนุญาตต่างกันได้')
            }
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_EDIT_FILE_CONFIM_CLICK = function () {
        $scope.FULL_MODEL.TR_ID = $scope.TR_ID;
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_FILE_TABEAN_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
            $scope.TABEAN_RENEW = datas.data.TABEAN_RENEW;
            var modal = $('#Renew_modal')
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Upload_file')
            modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
            //remove_doc()
            //doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_RENEW_EDIT_FILE_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME) {
        $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
        $scope.FULL_MODEL.TR_ID = TR_ID;
        $scope.FULL_MODEL.IDA_DR = IDA_DR;
        $scope.FULL_MODEL.IDA = IDA;
        $scope.FULL_MODEL.TYPE_EDIT = 2;
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        $scope.SET_PARAM2($scope.FULL_MODEL);
        if (STATUS_ID == 22) {
            $scope.FULL_MODEL.TYPE_ID = 5;
        } else {
            $scope.FULL_MODEL.TYPE_ID = 3;
        }
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        /*   $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_EDIT_FILE_STAFF_UPLOAD';*/
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET-DATA_EDIT_FILE_TABEAN_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
            $scope.FILE_ATTACH_EDIT = datas.data.FILE_ATTACH_EDIT;
            $scope.TABEAN_RENEW = datas.data.TABEAN_RENEW;
            $scope.XML_DRUG_PRODUCT_HERB = datas.data.XML_DRUG_PRODUCT_HERB;
            $scope.XML_SEARCH_DRUG_LCN_HERB = datas.data.XML_SEARCH_DRUG_LCN_HERB;
            $scope.XML_SEARCH_DRUG_LCN_LICEN_HERB = datas.data.XML_SEARCH_DRUG_LCN_LICEN_HERB;
            var modal = $('#Renew_modal')
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Edit_File')
            modal.find('.modal-title').text('รายละเอียดการแก้ไขเเอกสารแนบใบสำคัญ');
            //remove_doc()
            //doc_datatable()
        }, function () {
            alert($scope.error_message)
        })

    };

    $scope.BTN_RENEW_DETAIL_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME, T_Request) {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_RENEW';
        $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
        $scope.FULL_MODEL.TR_ID = TR_ID;
        $scope.FULL_MODEL.IDA_DR = IDA_DR;
        $scope.FULL_MODEL.IDA = IDA;
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        $scope.FULL_MODEL.TABEAN_RENEW.T_Request_ID = T_Request;
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
            $scope.ddl_Type_Tabean = datas.data.ddl_Type_Tabean;
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Confirm')
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
            //remove_doc()
            /*         doc_datatable()*/
        }, function () {
            alert($scope.error_message)
        })
    };

    //$scope.filter_prefix = function () {
    //    //var type_prefix = $scope.FULL_MODEL.ddl_prefix.filter(x => x.prefixcd);
    //    $scope.TABEAN_RENEW.BSN_PREFIX_CD = x.prefixcd
    //};


    $scope.BTN_PREVIEW_TABEAN_CLICK = function () {
        window.open("../PDF/PDF_PREVIEW.aspx?Newcode=" + $scope.Newcode + "&PROCESS_ID=" + $scope.PROCESS_ID);
    };

    $scope.BTN_ADD_REQUEST_CLICK = function () {
        if (!$scope.validateForm_request()) {
            alert($scope.ALERT_MS);
            return;
        }
        if ($scope.TABEAN_RENEW.BSN_PREFIX_CD != undefined && $scope.TABEAN_RENEW.BSN_PREFIX_CD != "") {
            var temp = $scope.FULL_MODEL.ddl_prefix.filter(x => x.prefixcd == $scope.TABEAN_RENEW.BSN_PREFIX_CD);
            $scope.FULL_MODEL.TABEAN_RENEW.BSN_PREFIX_NM = temp[0].thanm;
            $scope.FULL_MODEL.TABEAN_RENEW.BSN_PREFIX_CD = temp[0].prefixcd;
        };
        $scope.FULL_MODEL.TABEAN_RENEW = $scope.TABEAN_RENEW;
        $scope.FULL_MODEL.Newcode = $scope.Newcode;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-ADD_REQUEST_TABEAN_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.error_message = datas.data.ERR_ALERT;
            if (datas.data.ERR_ALERT == null) {
                $scope.FULL_MODEL = datas.data;
                $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;

                var modal = $('#Renew_modal')
                $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Upload_file')
                modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
                //remove_doc()
                //doc_datatable()
            } else {
                alert($scope.error_message);
            }
        }, function () {
            alert($scope.error_message);
        })
    };

    $scope.BTN_CONFIRM_CLICK = function () {
        if (!$scope.FULL_MODEL.TABEAN_RENEW.T_Resuest_ID && ($scope.FULL_MODEL.STATUS_ID == 1 || $scope.FULL_MODEL.STATUS_ID == 2)) {
            alert("กรุณาเลือกประเภททะเบียน");
            return; // หยุดการทำงานถ้ายังไม่ได้เลือก
        }
        if (!$scope.validateForm()) {
            alert($scope.ALERT_MS);
            return;
        }
        //var modal = $('#Renew_modal')
        //$scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Confirm_Detail')
        //modal.find('.modal-title').text('อัปโหลดเเอกสารแนบ');
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_CONFIRM_RENEW';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            if (datas.data.ALERT_MS != null) {
                alert(datas.data.ALERT_MS)
            } else {
                $scope.FULL_MODEL = datas.data;
                $('#Renew_modal').fadeOut(500, function () {
                    $('#Renew_modal').modal('hide');
                });
                pageload();
            }
      
            //remove_doc()
            //doc_datatable()
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
            modal.find('.modal-title').text('รายละเอียดใบนัดหมายคำขอต่ออายุใบสำคัญ');
            if (STATUS_ID != 8) {
                $scope.FULL_MODEL.CONFIRM_STATUS_ID = "";
                $scope.FULL_MODEL.STAFF_NAME_ID = "";
            };
            $scope.FULL_MODEL.FILE_ATTACH = datas.data.FILEUPLOADTABLE;
            $scope.FULL_MODEL.DATE_CONNFIRM = new Date();
            $scope.FULL_MODEL.STATUS_NAME = STATUS_NAME
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW/Renew_Confirm')
            $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
            //remove_doc()
            //doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.SENT_DATAS = function () {
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            //remove_doc()
            //doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.validateForm_request = function () {
        var TYPE_ID = $scope.TABEAN_RENEW.TYPE_PERSON;
        var Nation = $scope.TABEAN_RENEW.Nation;
        var BSN_IDENTIFY = $scope.TABEAN_RENEW.BSN_IDENTIFY;
        var Age = $scope.TABEAN_RENEW.Age;
        var Email = $scope.TABEAN_RENEW.Email;
        var BSN_NAME = $scope.TABEAN_RENEW.BSN_NAME;
        var BSN_LNAME = $scope.TABEAN_RENEW.BSN_LNAME;
        var BSN_PREFIX_CD = $scope.TABEAN_RENEW.BSN_PREFIX_CD;
        if (TYPE_ID == 1) {
            if (!Email) {
                $scope.ALERT_MS = "กรุณากรอกข้อมูลให้ครบถ้วน";
                return false;
            }
        } else if (TYPE_ID == 2) {
            if (!Nation || !BSN_IDENTIFY || !Age || !BSN_NAME || !BSN_LNAME || !BSN_PREFIX_CD | !Email) {
                $scope.ALERT_MS = "กรุณากรอกข้อมูลให้ครบถ้วน";
                return false;
            }
        } 
        return true;
    };

    $scope.validateForm = function () {
        var name = $scope.FULL_MODEL.TABEAN_RENEW.Appoinment_Contact;
        var email = $scope.FULL_MODEL.TABEAN_RENEW.Appoinment_Email;
        var phone = $scope.FULL_MODEL.TABEAN_RENEW.Appoinment_Phone;

        if (!name || !email || !phone) {
            $scope.ALERT_MS = "กรุณากรอกข้อมูลให้ครบถ้วน";
            return false;
        }
        return true;
    };

    $scope.Uploadattact = function (FileForUpload, AttachfUp_IDA, TYPE_ID, IDA, CITIZEN_ID, PROCESS_ID, Index, fl) { //อัพโหลดไฟล์เเนบบังคับ
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
                        TYPE_ID: TYPE_ID,
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