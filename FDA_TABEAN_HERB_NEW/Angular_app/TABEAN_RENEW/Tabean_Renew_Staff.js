app.controller('Tabean_Renew_Staff', function ($scope, Upload, CENTER_SV) {

    pageload()
    function pageload() {
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_RENEW_STAFF';
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.ddl_status = datas.data.ddl_status;
            $scope.Renew_Tabean_Staff = datas.data.Renew_Tabean_Staff;
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_STAFF_CONFIRM_CLICK = function () {
        if (!$scope.FULL_MODEL.CONFIRM_STATUS_ID || !$scope.FULL_MODEL.CONFIRM_STATUS_ID || !$scope.FULL_MODEL.STAFF_NAME_ID) {
            alert("กรุณาเลือกข้อมูลให้ครบ");
            return; // หยุดการทำงานถ้ายังไม่ได้เลือก
        }
        if ($scope.FULL_MODEL.CONFIRM_STATUS_ID != undefined && $scope.FULL_MODEL.CONFIRM_STATUS_ID != "") {
            var temp = $scope.FULL_MODEL.ddl_status_staff.filter(x => x.STATUS_ID == $scope.FULL_MODEL.CONFIRM_STATUS_ID);
            $scope.FULL_MODEL.CONFIRM_STATUS_NAME = temp[0].STATUS_NAME_STAFF;
            $scope.FULL_MODEL.CONFIRM_STATUS_ID = temp[0].STATUS_ID;
        };
        if ($scope.FULL_MODEL.CONFIRM_STATUS_ID == 31) {
            if ($scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != "") {
                var temp = $scope.FULL_MODEL.ddl_discount.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID);
                $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateName = temp[0].DiscountName;
                $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID = temp[0].IDA;
            };
            if ($scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != "") {
                var temp = $scope.FULL_MODEL.ddl_price.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID);
                $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_Name = temp[0].Request_Show;
                $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID = temp[0].ID;
            };
        }
        if ($scope.FULL_MODEL.CONFIRM_STATUS_ID == 23) {
            if ($scope.FULL_MODEL.TABEAN_RENEW.KIND_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.KIND_ID != "") {
                var temp = $scope.FULL_MODEL.ddl_kind_tabean.filter(x => x.kindcd == $scope.FULL_MODEL.TABEAN_RENEW.KIND_ID);
                $scope.FULL_MODEL.TABEAN_RENEW.KIND_NAME = temp[0].thakindnm;
                $scope.FULL_MODEL.TABEAN_RENEW.KIND_ID = temp[0].kindcd;
            };
            if ($scope.FULL_MODEL.TABEAN_RENEW.STYPE_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.STYPE_ID != "") {
                var temp = $scope.FULL_MODEL.ddl_stype.filter(x => x.STYPE_ID == $scope.FULL_MODEL.TABEAN_RENEW.STYPE_ID);
                $scope.FULL_MODEL.TABEAN_RENEW.STYPE_NAME = temp[0].STYPE_NAME;
                $scope.FULL_MODEL.TABEAN_RENEW.STYPE_ID = temp[0].STYPE_ID;
            };
            if ($scope.FULL_MODEL.TABEAN_RENEW.SALE_CHANNEL_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.SALE_CHANNEL_ID != "") {
                var temp = $scope.FULL_MODEL.ddl_sale_channel.filter(x => x.SALE_CHANNEL_ID == $scope.FULL_MODEL.TABEAN_RENEW.SALE_CHANNEL_ID);
                $scope.FULL_MODEL.TABEAN_RENEW.SALE_CHANNEL_NAME = temp[0].SALE_CHANNEL_NAME;
                $scope.FULL_MODEL.TABEAN_RENEW.SALE_CHANNEL_ID = temp[0].SALE_CHANNEL_ID;
            };

        }
        if ($scope.FULL_MODEL.STAFF_NAME_ID != undefined && $scope.FULL_MODEL.STAFF_NAME_ID != "") {
            var temp = $scope.FULL_MODEL.ddl_staff_name.filter(x => x.CITIZEN_ID == $scope.FULL_MODEL.STAFF_NAME_ID);
            $scope.FULL_MODEL.STAFF_NAME_CONFIRM = temp[0].STAFF_NAME;
            $scope.FULL_MODEL.STAFF_NAME_ID = temp[0].IDA;
            $scope.FULL_MODEL.STAFF_IDENTIFY = temp[0].CITIZEN_ID;
        };

        //if ($scope.FULL_MODEL.CONFIRM_STATUS_ID == 11) {
        //    var modal = $('#RenewTabeanStaff_Modal')
        //    modal.find('.modal-title').text('แก้ไขเอกสารแนบคำขอต่ออายุ');
        //    $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Edit_File')
        //    $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_EDIT_FILE_STAFF_UPLOAD';
        //    $scope.GET_DATA_CENTER($scope.FULL_MODEL)
        //} else {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-SAVE_DATA_STAFF_CONFIRM_RENEW_TABEAN';
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            if ($scope.FULL_MODEL.CONFIRM_STATUS_ID == 21 || $scope.FULL_MODEL.CONFIRM_STATUS_ID == 22) {
                var modal = $('#RenewTabeanStaff_Modal')
                modal.find('.modal-title').text('แก้ไขเอกสารแนบคำขอต่ออายุ');
                $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Edit_File')
                $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_EDIT_FILE_STAFF_UPLOAD';
                $scope.FULL_MODEL.TYPE_EDIT = 2;
                $scope.GET_DATA_CENTER($scope.FULL_MODEL)
            } else {
                $scope.FULL_MODEL = datas.data;
                $scope.FULL_MODEL.FILE_ATTACH = datas.data.FILEUPLOADTABLE;
                $('#RenewTabeanStaff_Modal').modal('hide')
                pageload();
                remove_doc()
                doc_datatable()
            }
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_TABEAN_RENEW_STAFF_DETAIL_CLICK = function (IDA, STATUS_ID, IDA_LCN, TR_ID, PROCESS_ID, IDA_DR, STATUS_NAME, NEWCODE) {
        $scope.FULL_MODEL.STATUS_ID = STATUS_ID;
        $scope.FULL_MODEL.TR_ID = TR_ID;
        $scope.FULL_MODEL.IDA_DR = IDA_DR;
        $scope.FULL_MODEL.IDA = IDA;
        $scope.FULL_MODEL.PROCESS_ID = PROCESS_ID;
        $scope.NEWCODE = NEWCODE;
        $scope.SET_PARAM2($scope.FULL_MODEL);
        if (STATUS_ID == 21 || STATUS_ID == 22) {
            var modal = $('#RenewTabeanStaff_Modal')
            modal.find('.modal-title').text('แก้ไขเอกสารแนบคำขอต่ออายุ');
            $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Edit_File')
            var senddata = {
                STATUS_ID: STATUS_ID,
                TR_ID: TR_ID,
                IDA_DR: IDA_DR,
                IDA: IDA,
                PROCESS_ID: PROCESS_ID,
                NEWCODE: NEWCODE,
                FUNC_CODE: 'FUNC-GET_EDIT_FILE_STAFF_UPLOAD',
                TYPE_EDIT: 2,
            }
            //$scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_EDIT_FILE_STAFF_UPLOAD';
            //$scope.FULL_MODEL.TYPE_EDIT = 2;
            $scope.GET_DATA_CENTER(senddata)
        } else {
            var senddata2 = {
                STATUS_ID: STATUS_ID,
                TR_ID: TR_ID,
                IDA_DR: IDA_DR,
                IDA: IDA,
                PROCESS_ID: PROCESS_ID,
                NEWCODE: NEWCODE,
                FUNC_CODE: 'FUNC-GET_DATA_CONFIRM_RENEW_STAFF',
            }
            /*     $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_CONFIRM_RENEW_STAFF';*/
            var getDATA = CENTER_SV.GET_DATA(senddata2);
            getDATA.then(function (datas) {
                $scope.FULL_MODEL = datas.data;
                var modal = $('#RenewTabeanStaff_Modal')
                /*    var date_now = new Date(Date.now()).toLocaleString("th-TH", { timeZone: "UTC" });*/
                modal.find('.modal-title').text('รายละเอียดคำขอต่ออายุ');
                if (STATUS_ID != 8) {
                    $scope.FULL_MODEL.CONFIRM_STATUS_ID = "";
                    $scope.FULL_MODEL.STAFF_NAME_ID = "";
                };
                $scope.FULL_MODEL.FILE_ATTACH = datas.data.FILEUPLOADTABLE;
                $scope.Log_Status = datas.data.Log_Status;
                $scope.FULL_MODEL.STAFF_NAME_ID = $scope.CLS_SESSION.CITIZEN_ID;
                //var temp = $scope.FULL_MODEL.ddl_staff_name.filter(x => x.CITIZEN_ID == $scope.FULL_MODEL.STAFF_NAME_ID);
                //$scope.FULL_MODEL.STAFF_NAME_CONFIRM = temp[0].STAFF_NAME;
                $scope.FILE_ATTACH = datas.data.FILE_ATTACH_STAFF;
                $scope.FULL_MODEL.DATE_CONNFIRM = new Date();
                $scope.Page = 1;
                $scope.FULL_MODEL.STATUS_NAME = STATUS_NAME
                $scope.SET_POPUP_PAGE('../TABEAN_RENEW_STAFF/Renew_Staff_Confirm')
                $scope.PDF_VIEW = "../PDF/PDF_VIEW.aspx?IDA=" + IDA + "&TR_ID=" + TR_ID + "&PROCESS_ID=" + PROCESS_ID;
                remove_doc()
                doc_datatable()
            }, function () {
                alert($scope.error_message)
            })
        }
        /* $scope.GET_DATA_CENTER();*/
    };

    $scope.BTN_SAVE_DATA_EDITFILE_CLICK = function (STATUS_ID) {
        $scope.FULL_MODEL.CONFIRM_STATUS_ID = STATUS_ID
        //if ($scope.FULL_MODEL.STATUS_ID == 21) {
        //    $scope.FULL_MODEL.CONFIRM_STATUS_ID = 22
        //}
        var senddata = {
            STATUS_ID: $scope.FULL_MODEL.CONFIRM_STATUS_ID,
            CONFIRM_STATUS_ID: $scope.FULL_MODEL.CONFIRM_STATUS_ID,
            TR_ID: $scope.TR_ID,
            IDA_DR: $scope.IDA_DR,
            IDA: $scope.IDA,
            PROCESS_ID: $scope.PROCESS_ID,
            NEWCODE: $scope.NEWCODE,
            FUNC_CODE: 'FUNC-UPDATE_CONFIRM_EDIT_STAFF',
            FILE_ATTACH_EDIT: $scope.FULL_MODEL.FILE_ATTACH_EDIT,
            TABEAN_RENEW: $scope.FULL_MODEL.TABEAN_RENEW,
        }
        //$scope.FULL_MODEL.CONFIRM_STATUS_ID = $scope.FULL_MODEL.STATUS_ID
        //$scope.FULL_MODEL.FUNC_CODE = 'FUNC-UPDATE_CONFIRM_EDIT_STAFF';
        var getDATA = CENTER_SV.GET_DATA(senddata);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $('#RenewTabeanStaff_Modal').modal('hide')
            pageload();
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.Price_Request = function () {
        if ($scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != "") {
            var temp = $scope.FULL_MODEL.ddl_price.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID);
            $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE = temp[0].Price;
        };
        if ($scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != "") {
            var temp = $scope.FULL_MODEL.ddl_discount.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID);
            $scope.Prise_Discount = temp[0].ESTIMATE_Fee;
            $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE = $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE - (($scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE * 100) / $scope.Prise_Discount)
        };
    };

    $scope.Price_Request_Discount = function () {
        if ($scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID != "") {
            var temp = $scope.FULL_MODEL.ddl_discount.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Discount_EstimateID);
            $scope.Prise_Discount = temp[0].ESTIMATE_Fee;
            $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE = $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE - (($scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE * 100) / $scope.Prise_Discount)
        };

        //if ($scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != undefined && $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID != "") {
        //    var temp = $scope.FULL_MODEL.ddl_price.filter(x => x.ID == $scope.FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID);
        //    $scope.FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE = temp[0].Price;
        //};
    };

    $scope.BTN_PREVIEW_TABEAN_CLICK = function () {
        window.open("../PDF/PDF_PREVIEW.aspx?Newcode=" + $scope.NEWCODE + "&PROCESS_ID=" + $scope.PROCESS_ID + "&IDA=" + $scope.IDA);
    };

    $scope.exitpage = function () {
        pageload();
    };
    //$scope.BTN_STAFF_KEEP_STATUS_CLICK = function () {
    //    $scope.FULL_MODEL.FUNC_CODE = 'FUNC-KEEP_STATUS_STAFF_RENEW';
    //    var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
    //    getDATA.then(function (datas) {
    //        $scope.FULL_MODEL = datas.data;

    //        pageload();
    //        remove_doc()
    //        doc_datatable()
    //    }, function () {
    //        alert($scope.error_message)
    //    })
    //};


    $scope.GET_DATA_CENTER = function (datas) {
        var getDATA = CENTER_SV.GET_DATA(datas);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILEUPLOADTABLE = datas.data.FILEUPLOADTABLE;
            $scope.FILE_ATTACH_STAFF = datas.data.FILE_ATTACH_STAFF;
            $scope.FULL_MODEL.STATUS_ID = datas.data.TABEAN_RENEW.STATUS_ID
            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

    //// Initialize status filter
    //$scope.statusFilter = {};

    //// Update status filter function
    //$scope.updateStatusFilter = function () {
    //    $scope.statusFilterFunction = function (item) {
    //        // If no statuses are selected, show all items
    //        if (Object.values($scope.statusFilter).every(val => !val)) {
    //            return true;
    //        }
    //        return $scope.statusFilter[item.STATUS_NAME];
    //    };
    //};

    //// Initialize filter function
    //$scope.updateStatusFilter();

    // Create an array of years
    const currentYear = new Date().getFullYear();
    $scope.years = Array.from({ length: 5 }, (v, i) => currentYear - i);

    // Initialize year filter function
    $scope.yearFilterFunction = function (item) {
        // If no year is selected, show all items
        if (!$scope.selectedYear) {
            return true;
        }
        const itemYear = new Date(item.YEAR).getFullYear();
        return itemYear == $scope.selectedYear;
    };
    // Initialize sorting
    $scope.sortKey = 'index'; // Default sort key
    $scope.reverse = false;   // Default sort order

    // Function to sort by column
    $scope.sortColumn = function (column) {
        $scope.reverse = ($scope.sortKey === column) ? !$scope.reverse : false;
        $scope.sortKey = column;
    };

    $scope.exportData = function () {
        var data = $scope.filteredData.map(item => [
            item.index,
            item.TR_ID,
            item.RGTNO_FULL,
            item.LCNNO_DISPLAY_NEW,
            item.RCVNO_NEW,
            item.DRUG_NAME,
            item.STATUS_NAME,
            item.DATE_CONFIRM_TH
        ]);

        var ws = XLSX.utils.aoa_to_sheet([
            ['ลำดับ', 'เลขดำเนินการ', 'เลขที่ทะเบียน', 'เลขที่ใบอนุญาต', 'เลขที่รับคำขอ', 'ชื่อยา', 'สถานะคำขอ', 'วันที่ยื่นคำขอ'],
            ...data
        ]);

        var maxLengths = [];
        data.forEach(row => {
            row.forEach((cell, i) => {
                maxLengths[i] = Math.max(maxLengths[i] || 0, cell ? cell.toString().length : 0);
            });
        });

        ws['!cols'] = maxLengths.map(length => ({ wch: length + 2 }));

        const borderStyle = {
            top: { style: "thin" },
            bottom: { style: "thin" },
            left: { style: "thin" },
            right: { style: "thin" }
        };

        const range = XLSX.utils.decode_range(ws['!ref']);
        for (let R = range.s.r; R <= range.e.r; ++R) {
            for (let C = range.s.c; C <= range.e.c; ++C) {
                const cellAddress = XLSX.utils.encode_cell({ r: R, c: C });
                if (!ws[cellAddress]) continue;
                if (!ws[cellAddress].s) ws[cellAddress].s = {};
                ws[cellAddress].s.border = borderStyle;
            }
        }

        ws['!freeze'] = { pane: { topLeftCell: "A2" } };

        var wb = XLSX.utils.book_new();
        XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
        XLSX.writeFile(wb, 'exported_data.xlsx');
    };

    $(document).ready(function () {
        $('[data-toggle="tooltip"]').tooltip();
    });

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
                        $scope.FILE_ATTACH_STAFF[Index] = resp.data;
                        console.log('fl : ', fl);
                        console.log("FILE_ATTACH_STAFF ", $scope.FILE_ATTACH_STAFF[Index]);
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