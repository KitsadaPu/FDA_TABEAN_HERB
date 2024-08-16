var active_menu;
var MENU_ID;
var his_main;

function chk_active(name) {
    if (active_menu == name) {
        active_menu = "";
        MENU_ID = 0;
        var current = document.getElementsByClassName("collapse ng-scope nav nav-second-level");
        var len_css = current.length;
        for (var i = 0; i < len_css; i++) {
            current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level in", "collapse ng-scope nav nav-second-level off");

        }
    } else {
        if (active_menu == "") {
            var current = document.getElementsByClassName("collapse ng-scope nav nav-second-level");
            var len_css = current.length;
            for (var i = 0; i < len_css; i++) {
                if (current[i].className == "collapse ng-scope nav nav-second-level off") {
                    current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level off", "collapse ng-scope nav nav-second-level in");
                } else {
                    current[i].className = current[i].className.replace("collapse ng-scope nav nav-second-level off", "collapse ng-scope nav nav-second-level in");
                }
            }
            active_menu = name;
        } else {
            active_menu = name;
        }

    }
};
// ตาราง
 function doc_datatable() {
    setTimeout(function () {
        $('.dataTables-example').DataTable({
            pageLength: 25,
            responsive: true,
            destroy: true,
            dom: '<"html5buttons"B>lTfgitp',
            buttons: [
                { extend: 'copy' },
                //{ extend: 'csv' },
                { extend: 'excel', title: 'ExampleFile' },
                //{ extend: 'pdf', title: 'ExampleFile' },

                {
                    extend: 'print',
                    customize: function (win) {
                        $(win.document.body).addClass('white-bg');
                        $(win.document.body).css('font-size', '10px');


                    }
                }
            ]

        });
    }, 100);
};
function remove_doc() {
    $('.dataTables-example').DataTable().destroy();
};
// แปลงวัน
function CHANGE_FORMATDATE_typedate(DATE_CHANGE) {
    var dateString = DATE_CHANGE.substr(6);
    var currentTime = new Date(parseInt(dateString));
    var month = currentTime.getMonth() + 1;
    var day = currentTime.getDate();
    var year = currentTime.getFullYear();
    return DATE_CHANGE = month + "/" + day + "/" + year;
};
function con_to_date(dateString) {
    try {
        var dateArray = new Date(dateString);


    }
    catch (err) {
    }
    return dateArray;
};

function log_out() {
    Swal.fire({
        title: 'คุณต้องการจะออกจากระบบ?',
        showDenyButton: true,
        showCancelButton: true,
        confirmButtonText: 'ออกจากระบบ',
        denyButtonText: 'ยกเลิก',
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.value == true) {
            location.replace("https://privus.fda.moph.go.th/");
        } else if (result.value == false) {
        }
    })
};

function success_data(msg) {
    Swal.fire({
        type: 'success',
        title: 'success',
        text: msg
    })

    //window.location = "/HOME/CER_REQ";
};

function ERR_DATA(msg) {
    Swal.fire({
        icon: 'error',
        title: 'เกิดข้อผิดพลาด',
        text: msg
    })
    //window.location = "/HOME/CER_REQ";
};

var PATH_NAME;
var IDA;
var cactive;
var PROCESS_ID;


function MENU_CLICK(path, cactive, id, PROCESS_ID, MAIN_PATH, datas) {
    his_main = path;
    PATH_NAME = MAIN_PATH;
    IDA = 0;
    cactive = cactive;
    PROCESS_ID = PROCESS_ID;
    chk_active(datas.PAGE_NAME);
    MENU_ID = datas.IDA;
};

 function SUB_MENU_CLICK(path, cactive, index, PROCESS_ID, MAIN_PATH, datas) {
    SET_MAIN_PAGE = path;
    his_main = path;
    PATH_NAME = MAIN_PATH;
    PROCESS_ID = PROCESS_ID;
    cactive = cactive;
    PROCESS_ID = PROCESS_ID;

};

function BACK_PAGE() {
    SET_MAIN_PAGE = his_main;

};

var IDA_DR;
var IDA_LCN;
var TR_ID;
var NAME_THAI;
var NAME_ENG;
var RGTNO_DISPLAY;
var Newcode;
var STATUS_LCN;
var STATUS_ID;
function SET_PARAM2(MODEL) {
   IDA = MODEL.IDA;
   IDA_DR = MODEL.IDA_DR;
   IDA_LCN = MODEL.IDA_LCN;
   TR_ID = MODEL.TR_ID;
   NAME_THAI = MODEL.NAME_THAI;
   NAME_ENG = MODEL.NAME_ENG;
   RGTNO_DISPLAY = MODEL.RGTNO_DISPLAY;
   PROCESS_ID = MODEL.PROCESS_ID;
   Newcode = MODEL.Newcode;
   STATUS_LCN = MODEL.STATUS_LCN;
   STATUS_ID = MODEL.STATUS_ID;
};