app.service("CENTER_SV", function ($http, Upload) {

    this.GET_SET_FULL_MODEL = function (TOKEN) { //เรียก Full model
        var response = $http({
            method: "post",
            url: "../GET_DATA/GET_DATA",
            dataType: "json",
            params: {
                TOKEN: TOKEN

            }
        });
        return response;
    };

    this.GET_SET_FULL_MODEL_CUTOMMER = function (TOKEN) { //เรียก Full model
        var response = $http({
            method: "post",
            url: "../GET_DATA/GET_DATA_CUTOMMER",
            dataType: "json",
            params: {
                TOKEN: TOKEN

            }
        });
        return response;
    };

    this.GET_AUTHEN = function (TOKEN) {
        var response = $http({
            method: "post",
            url: "../GET_DATA/GET_AUTHEN",
            params: {
                TOKEN: TOKEN
            }
        });
        return response;
    };

    this.GET_DATA = function (model) { //เรียก Full model
        var response = $http({
            method: "post",
            url: "../GATE_WAY/GATEWAY_EXCHANGE",
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

    this.UPLOAD_FILE = function (model, fileup) {

        var response = Upload.upload({
            method: "post",
            url: "../GATE_WAY/GATEWAY_EXCHANGE",
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model),
                files: fileup
            }
        });
        return response;
    }
    this.INSERT_DATA = function (model) { //เรียก Full model
        var response = $http({
            method: "post",
            url: "../GATE_WAY/GATEWAY_EXCHANGE",
            dataType: "json",
            data: {
                MODEL: JSON.stringify(model)
            }
        });
        return response;
    };

});