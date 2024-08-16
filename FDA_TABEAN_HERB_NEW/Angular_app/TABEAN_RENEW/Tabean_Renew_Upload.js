app.controller('Tabean_Renew_Upload', function ($scope, Upload, CENTER_SV) {
    $scope.upload_id = '';
    pageload()
    function pageload() {
        $scope.FULL_MODEL.TR_ID = $scope.TR_ID
        $scope.FULL_MODEL.PROCESS_ID = $scope.PROCESS_ID
        $scope.FULL_MODEL.IDA_DR = $scope.IDA_DR
        $scope.FULL_MODEL.FUNC_CODE = 'FUNC-GET_DATA_RENEW_UPLOAD';
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

    $scope.Uploadattact = function (FileForUpload, AttachfUp_IDA, IDA, PROCESS_ID, fl) { //อัพโหลดไฟล์เเนบบังคับ
        console.log(fl);
        if (FileForUpload == undefined || FileForUpload == "") {
            alert("กรุณาเลือกไฟล์")
        }
        else {
            try {
                Upload.upload({
                    method: "post",
                    url: '../HOME/Upload_Attach_User',
                    data:
                    {
                        FileForUpload: FileForUpload,
                        AttachfUp_IDA: AttachfUp_IDA,
                        IDA: IDA,
                        PROCESS_ID: PROCESS_ID,
                        FILE_UPLOAD_TABLE: JSON.stringify(fl),
                    }
                }).then(function (resp) {
                    var message = resp.data;
                    if (message == "กรุณาอัพโหลดไฟล์PDFเท่านั้น") {
                        alert("กรุณาอัพโหลดไฟล์ PDF เท่านั้น")
                    }
                    else {
                        $scope.FILEUPLOADTABLE[AttachfUp_IDA] = resp.data;
                        console.log('fl : ', fl);
                        console.log("FILEUPLOADTABLE ", $scope.FILEUPLOADTABLE[AttachfUp_IDA]);
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