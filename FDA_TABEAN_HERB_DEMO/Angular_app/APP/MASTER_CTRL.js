//var app = angular.module('POST_APP', ['ngMaterial', 'ui.bootstrap', 'ngFileUpload', 'mdDataTable']);
var app = angular.module('POST_APP', ['ngMaterial', 'ui.bootstrap', 'ngFileUpload', 'ngAnimate', 'angularUtils.directives.dirPagination']);
app.directive('loading', ['$http', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, elm, attrs) {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };
            scope.$watch(scope.isLoading, function (v) {
                if (v) {
                    elm.show();
                } else {
                    elm.hide();
                }
            });
        }
    };
}]);
app.config(function ($mdDateLocaleProvider) {
    var shortMonths = ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.'];
    $mdDateLocaleProvider.months = ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน', 'กรกฎาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'];
    $mdDateLocaleProvider.shortMonths = shortMonths;
    $mdDateLocaleProvider.days = ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'];
    $mdDateLocaleProvider.shortDays = ['อา', 'จ', 'อ', 'พ', 'พฤ', 'ศ', 'ส'];
    $mdDateLocaleProvider.monthHeaderFormatter = function (date) {
        return shortMonths[date.getMonth()] + ' ' + (date.getFullYear() + 543);
    };
    $mdDateLocaleProvider.formatDate = function (date) {
        return `${moment(date).format('DD/MM')}/${moment(date).get('year') + 543}`;
    };
    $mdDateLocaleProvider.parseDate = function (dateString) {
        var dateArray = dateString.split("/");
        dateString = dateArray[1] + "/" + dateArray[0] + "/" + (dateArray[2] - 543);
        var m = moment(dateString, 'L', true);
        return m.isValid() ? m.toDate() : new Date(NaN);
    };
}).controller('MASTER_CTRL', function ($scope, CENTER_SV) {
    $scope.Mahesh = {};
    $scope.Mahesh.name = "Mahesh Parashar";
    $scope.Mahesh.rollno = 1;

    $scope.Piyush = {};
    $scope.Piyush.name = "Piyush Parashar";
    $scope.Piyush.rollno = 2;

    $scope.logo = {};
    $scope.logo.name = "../Home/Main_indexr";

    $scope.test = {};
    $scope.test.name = "Piyush Parashar";

});

app.directive('student', function () {
    var directive = {};
    directive.restrict = 'E';
    directive.template = "Student: <b>gg</b>" +
        "Roll No: <b>gg</b>";

    directive.scope = {
        student: "=name"
    }
    directive.compile = function (element, attributes) {
        //element.css("border", "1px solid #cccccc");

        var linkFunction = function ($scope, element, attributes) {
            //element.html("Student: <b>" + $scope.student.name + "</b>" +
            //    "Roll No: <b>" + $scope.student.rollno + "</b><br />");
            //element.css("background-color", "#ff00ff");
        }
        return linkFunction;
    }

    return directive;
});

app.directive('hupper', function () {
    var directive = {};
    directive.restrict = 'E';
    directive.template = "<header>" +
        "<section id='header'>" +
        "<div class='wrap-header'>" +
        "<div class='list-left'>" +
        "<div class='menu'></div><a class='logo-site' href='../Home/Main_index'><img src='../css_last/Images/layout/logo.svg'></a><span class='text-e'>ระบบรายงานเฮม์ (เฉพาะกัญชง)</span> <a></a>" +
        "</div>" +
        "<div class='list-sub-menu'>" +
        "<a href='https://privus.fda.moph.go.th/' class='sub-menu sign-out'><i class='fas fa-sign-out-alt icon'></i><a/>" +
        "</div >" +
        "<div class='clearfix'></div>" +
        "</div>" +
        "<div class='search-xs show-xs'>" +
        "<form class='search'><input name='search' type='text'></form><div class='sub-menu search'></div>" +
        "</div > " +
        "<div class='line-header'></div>" +
        "</section>" +
        "</header>";

    directive.scope = {
        test: "=name"
    }
    directive.compile = function (element, attributes) {
        //element.css("border", "1px solid #cccccc");

        var linkFunction = function ($scope, element, attributes) {
            //element.html("Test: <b>" + $scope.test.name + "</b>");
            //element.css("background-color", "#ff00ff");
        }
        return linkFunction;
    }

    return directive;
}).controller('MASTER_CTRL', function ($scope, CENTER_SV) {
    //pageload();

    $scope.currentPage = 1;
    $scope.currentPage_2 = 1;
    $scope.currentPage_3 = 1;
    $scope.pageSize = 20;
    $scope.renew_currentPage = 1;

    dashboard_load();
    function dashboard_load() {
        var treeviewMenu = $('.app-menu');
        $('[data-toggle="sidebar"]').click(function (event) {
            event.preventDefault();
            $('.app').toggleClass('sidenav-toggled');
        });

        // Activate sidebar treeview toggle
        $("[data-toggle='treeview']").click(function (event) {
            event.preventDefault();
            if (!$(this).parent().hasClass('is-expanded')) {
                treeviewMenu.find("[data-toggle='treeview']").parent().removeClass('is-expanded');
            }
            $(this).parent().toggleClass('is-expanded');
        });

        // Set initial active toggle
        $("[data-toggle='treeview.'].is-expanded").parent().toggleClass('is-expanded');

        //Activate bootstrip tooltips
        $("[data-toggle='tooltip']").tooltip();
    }
});

