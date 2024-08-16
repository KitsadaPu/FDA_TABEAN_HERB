<form onsubmit="return validateForm_request()">
    <!--<div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1000px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">-->
    @*<h4 style="color: red">ชื่อผู้ติดต่อฉุกเฉิน</h4>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="inputPrefix">คำนำหน้า</label>
                <input type="text" class="form-control" id="inputPrefix">
            </div>
            <div class="form-group col-md-4">
                <label for="inputName">ชื่อ</label>
                <input type="text" class="form-control" id="inputName">
            </div>
            <div class="form-group col-md4">
                <label for="inputLastName">นามสกุล</label>
                <input type="text" class="form-control" id="inputLastName">
            </div>
        </div>
        <div class="form-group">
            <label for="inputTel">โทรศัพท์</label>
            <input type="tel" class="form-control" id="inputTel" placeholder="0900100100">
        </div>
        <div class="form-group">
            <label for="inputEmail">E-mail</label>
            <input type="email" class="form-control" id="inputEmail">
        </div>
        <div class="form-group">
            <label for="inputLatitute">Latitute</label>
            <input type="number" class="form-control" id="Latitute" placeholder="5.0-21.0" min="5" mas="21" maxlength="21" value="''|tage:2" >
        </div>
        <div class="form-group">
            <label for="inputLongtitute">Longtitute</label>
            <input type="number" class="form-control" id="inputLongtitute" placeholder="97.0-106.0" min="97.0" max="106.0">
        </div>*@
    <!--<div style="text-align:center;">
                <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:45px; Width:90%" ng-click="BTN_ADD_REQUEST_CLICK()" value="สร้างคำขอ" />
            </div>
            <div style="height: 15px;"></div>
            <div style="text-align:center;">
                <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height: 45px; Width: 90% " data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
            </div>
        </div>
    </div>-->
    @*<div id="main-content">
        <div class="wrap-main-content">
            <div id="page">
                <div class="page-content container ">
                    <div class="no-pm no-bg card no-border card-tab card-tab2 active">*@
    @*<div class="in" style="padding:0px">
        <div ng-cloak>
            <md-content>
                <md-tabs class="md-primary" md-dynamic-height md-border-bottom>
                    <md-tab label="1.รายละเอียด">
                        <md-content class="md-padding">*@
    @*@Html.Partial("../EMANSCR/EMANSCR_TAB3")*@
    <div class="card">
        <div class="card-header alert alert-info">
            @*<h2>รายละเอียดของผลิตภัณฑ์</h2>*@
            รายละเอียดของผลิตภัณฑ์
        </div>
        <div class="card-body">
            <blockquote class="blockquote mb-0">
                <div class="row">
                    <div class="col-md-3">
                        <label> ชื่อภาษาไทย</label>
                    </div>
                    <div class="col-md-9">
                        <input class="form-control" ng-model="TABEAN_RENEW.thadrgnm" readonly/>
                    </div>
                </div><br />

                <div class="row">
                    <div class="col-3">
                        <label> ชื่อภาษาอังกฤษ (ถ้ามี)</label>
                    </div>
                    <div class="col-9">
                        <input class="form-control" ng-model="TABEAN_RENEW.engdrgnm" readonly/>
                    </div>
                </div><br />

                <div class="row">
                    <div class="col-md-3">
                        <label>เลขทะเบียนที่</label>
                    </div>
                    <div class="col-md-9">
                        <input class="form-control" ng-model="TABEAN_RENEW.Register" readonly/>
                    </div>
                </div>
                @*<footer class="blockquote-footer">Someone famous in <cite title="Source Title">Source Title</cite></footer>*@
            </blockquote>
        </div>
    </div>
    <br />
    @Html.Partial("../TABEAN_RENEW/Renew_Information_Request")
    <br />

    @Html.Partial("../TABEAN_RENEW/Renew_Imformation_Location")
    <br />

    <div class="d-flex align-items-end flex-column bd-highlight mb-3">
        <button type="submit" class="btn btn-primary p-2" ng-click="BTN_ADD_REQUEST_CLICK()">
            <i class="fas fa-save"></i>
            สร้างคำขอ
        </button>
    </div>
</form>