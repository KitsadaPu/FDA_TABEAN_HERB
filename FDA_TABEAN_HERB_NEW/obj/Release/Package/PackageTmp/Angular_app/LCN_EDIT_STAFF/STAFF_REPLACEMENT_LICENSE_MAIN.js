app.controller('STAFF_REPLACEMENT_LCN_EDIT', function ($scope, CENTER_SV) {

    pageload()
    function pageload() {
        //$scope.pick_v = 0;
        //var send_data = {
        //    FUNC_CODE: 'FUNC-LOAD_DATA_ID_USER',
        //    IDA: IDA,
        //    IDA_LCN: IDA_LCN,
        //};
        //var getDATA = CENTER_SV.GET_DATA(send_data);
        //getDATA.then(function (datas) {
        //    $scope.MAS_PRODUCTION_MODEL_CER = datas.data.MAS_PRODUCTION_MODEL_CER;
        //    $scope.MAS_CRITERIA_USE_IN_AUDIT_CER = datas.data.MAS_CRITERIA_USE_IN_AUDIT_CER;
        //    $scope.dalcn_herb = datas.data.dalcn_herb;
        //    $scope.cer_dalcn_herb = datas.data.cer_dalcn_herb;

        //    //alert('ค้นหาเรียบร้อย');
        //    remove_doc()
        //    doc_datatable()
        //}, function () {
        //    alert($scope.error_message)
        //})
        $scope.PATH_NAME = $scope.PATH_NAME
    };

    $scope.BTN_SEARCH_CUSTOMER = function () {

        var send_data = {
            FUNC_CODE: 'FUNC-SEARCH_DATA_CUSTOMER',
            IDA: $scope.IDA,
            IDA: $scope.IDA_LCN,
            NAME_SEARCH: $scope.FULL_MODEL.NAME_SEARCH,
            IDEN_SEARCH: $scope.FULL_MODEL.IDEN_SEARCH,
        };
        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.FILE_SEARCH = datas.data.FILE_SEARCH;
        }, function () {
            alert("ระบบมีปัญหา")
        })

    };


    $scope.BTN_SELECT_CUSTOMER = function (IDA, IDEN, NAME, datas) {

        var send_data = {
            FUNC_CODE: 'FUNC-SELECT_CUSTOMER',
            IDA: $scope.IDA,
            IDA: $scope.IDA_LCN,
            NAME_SEARCH: NAME,
            IDEN_SEARCH: IDEN,
            CITIZEN_ID_AUTHORIZE: IDEN,
            CLS_SESSION: $scope.FULL_MODEL.CLS_SESSION,
        };
        var getDATA = CENTER_SV.GET_DATA(send_data);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;
            $scope.CUSTOMER_FILE = datas.data.CUSTOMER_FILE;
            remove_doc()
            doc_datatable()
        }, function () {
            alert("ระบบมีปัญหา")
        })

    };

});