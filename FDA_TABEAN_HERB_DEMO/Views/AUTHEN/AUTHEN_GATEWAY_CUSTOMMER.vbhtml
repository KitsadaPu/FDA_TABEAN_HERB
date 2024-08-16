<!DOCTYPE html>
<html>
<head>
    <title>FDA</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../html5/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../html5/css/font-awesome.css" rel="stylesheet" />
    <link href="../html5/css/datatables.min.css" rel="stylesheet" />
    <link href="../html5/css/animate.css" rel="stylesheet" />
    <link href="../html5/css/style.css" rel="stylesheet" />
    <script src="../html5/js/jquery-3.1.1.min.js"></script>
    <script src="../html5/js/popper.min.js"></script>
    <script src="../html5/js/bootstrap.min.js"></script>
    <script src="../DESIGN/js/bower_component/angular-material/angular-material.js"></script>
    <script src="../DESIGN/js/bower_component/angular-material/angular-material.min.js"></script>

    <script type="text/javascript" src="../Design/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript" src="../Design/js/fontawesome-all.min.js"></script>
    <script type="text/javascript" src="../Design/js/fusioncharts.js"></script>
    <script type="text/javascript" src="../Design/js/jquery-fusioncharts.min.js"></script>
    <script type="text/javascript" src="../Design/js/fusioncharts.theme.fusion.js"></script>
    <script type="text/javascript" src="../Design/js/alert.js"></script>
    <script type="text/javascript" src="../Design/js/common.js"></script>
    <script type="text/javascript" src="../Design/js/company_profile.js"></script>
    <script src="../html5/js/jquery.metisMenu.js"></script>
    <script src="../html5/js/jquery.slimscroll.min.js"></script>
    <script src="../html5/js/datatables.min.js"></script>
    <script src="../html5/js/dataTables.bootstrap4.min.js"></script>
    <script src="../html5/js/inspinia.js"></script>
    <script src="../html5/js/pace.min.js"></script>
    <link href="../html5/css/angular-material.css" rel="stylesheet" />
    <link href="../html5/css/spinners.css" rel="stylesheet" />
    <!-- Angular Material requires Angular.js Libraries -->
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-animate.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-aria.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular-messages.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/danialfarid-angular-file-upload/12.2.13/ng-file-upload.min.js"></script>
    <script src="https://angular-ui.github.io/bootstrap/ui-bootstrap-tpls-0.10.0.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/angular-utils-pagination/0.11.1/dirPagination.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/angular_material/1.1.8/angular-material.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.14.1/moment.min.js"></script>
    <script src="../html5/js/angular-cookies.js"></script>
    <script src="../JS/alert.js"></script>
    <script src="../JS/dirPagination.js"></script>
    <script src="../Bootstrap/selectize/selectize.standard.min.js"></script>
    <script src="../Bootstrap/select2/js/select2.full.min.js"></script>
    <script src="~/Scripts/sweetalert.js"></script>
    <script src="~/Angular_App/APP/MASTER_CTRL.js?v=1.0003"></script>
    <script src="~/Angular_app/APP/JS_COMMON.js"></script>

    <script src="~/Angular_App/APP/MASTER_CTRL.js?v=1.0003"></script>
    <script src="~/Angular_app/APP/JS_COMMON.js"></script>
    <script src="~/Angular_app/APP/AUTHEN_GATEWAY_CUSTOMMER_CTRL.js"></script>
    <script src="~/Angular_App/CENTER_SV/CENTER_SV.js?v=1.0003"></script>
    <script src="~/Angular_app/TABEAN_RENEW/Tabean_Renew_EditFile_CTRL.js"></script>
    <script src="~/Angular_app/TABEAN_RENEW/Tabean_Renew_Main.js"></script>
    <script src="~/Angular_app/TABEAN_RENEW/Tabean_Renew_Request.js"></script>
    <style>
        .navbar-default .nav > li ng-scope > a:hover,
        .navbar-default .nav > li ng-scope > a:focus {
            background-color: #293846;
            color: white;
        }

        .panel {
            margin-bottom: 0px !important;
            background-color: #fff !important;
            border: 10px solid transparent !important;
            border-radius: 10px !important;
        }
    </style>
    <style>
        .modal-dialog {
            width: 1500px;
            width: 100%;
            height: 100%;
            margin: 0;
            padding: 0;
            min-width: 1500px;
            min-width: 100%;
        }

        .modal-content {
            height: auto;
            min-height: 100%;
            /*            border-radius: 0;*/
        }
    </style>
</head>
<body ng-app="POST_APP" ng-controller="MASTER_CTRL">
    <div id="wrapper">
        <div ng-controller="AUTHEN_GATEWAY_CUSTOMMER_CTRL">
            <div class="loading-spiner-holder" data-loading style="background:#04adfd40;width: 100%;height: 100%;position: fixed;z-index: 99999;">
                <div class="loading-spiner">
                    <span class="dots-loader" style="position: fixed;z-index: 100000;top: 50%;left: 50%;">Loading&#8230;</span>
                </div>
            </div>
            @Html.Partial("NAV_BAR", Nothing)
            <div id="page-wrapper" class="gray-bg">
                @Html.Partial("TOP_PAGE", Nothing)
                <div class="panel">
                    <div ng-include="SET_MAIN_PAGE">

                    </div>
                </div>

            </div>
        </div>
    </div>
    <style>
        html {
            /*color: rgba(0,0,0,0.87);*/
            background-color: rgba(255, 255, 255, 0);
        }

        body {
            overflow-x: visible;
        }
    </style>
    <script>
        $(document).ready(function () {
            $('.dataTables-example').DataTable({
                pageLength: 25,
                responsive: true,
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

                            $(win.document.body).find('table')
                                .addClass('compact')
                                .css('font-size', 'inherit');
                        }
                    }
                ]

            });

        });

    </script>

</body>
</html>



