
app.controller('Tabean_Renew_Main', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';

    pageload()
    function pageload() {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TYPE_TABEAN';
        /*$scope.SENT_DATAS();*/
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.Chooses_Tabean = function () {
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TYPE_TABEAN';
        /*$scope.SENT_DATAS();*/
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            $scope.remove_doc();
            $scope.doc_datatable();
        }, function () {
            alert($scope.error_message)
        })
    };

    $scope.BTN_CHOOSE_TABEAN_CLICK = function (Path, IDA_DR, IDENETITFY, NAME_THAI, NAME_ENG, RGTNO_DISPLAY, Newcode, STATUS_LCN) {
        $scope.FULL_MODEL.NAME_THAI = NAME_THAI;
        $scope.FULL_MODEL.NAME_ENG = NAME_ENG;
        $scope.FULL_MODEL.RGTNO_DISPLAY = RGTNO_DISPLAY;
        $scope.FULL_MODEL.IDA_DR = IDA_DR;
        $scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
        $scope.FULL_MODEL.Newcode = Newcode;
        $scope.FULL_MODEL.STATUS_LCN = STATUS_LCN;
        $scope.SET_PARAM2($scope.FULL_MODEL);
/*        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_RENEW';*/
        $scope.SET_PAGE(Path)
        /*   $scope.SENT_DATAS()*/
    };
});