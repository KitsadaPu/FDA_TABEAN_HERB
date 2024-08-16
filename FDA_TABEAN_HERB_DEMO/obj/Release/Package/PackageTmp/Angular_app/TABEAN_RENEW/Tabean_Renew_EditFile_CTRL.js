
app.controller('Tabean_Renew_EditFile_CTRL', function ($scope, Upload, CENTER_SV) {

    pageload()
    function pageload() {
        //$scope.FULL_MODEL.IDA_DR = $scope.IDA_DR;
        //$scope.FULL_MODEL.IDA_LCN = $scope.IDA_LCN;
        //$scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID;
        //$scope.FULL_MODEL.Newcode = $scope.Newcode;
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_TABEAN_RENEW_EDIT_FILE';
        /* $scope.SENT_DATAS();*/
        var getDATA = CENTER_SV.GET_DATA($scope.FULL_MODEL);
        getDATA.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

            remove_doc()
            doc_datatable()
        }, function () {
            alert($scope.error_message)
        })
    };

});