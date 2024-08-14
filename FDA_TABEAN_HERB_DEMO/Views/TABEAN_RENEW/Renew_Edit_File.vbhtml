<div>
    <div style="height: 15px;"></div>
    <div class="row was-validated">
        <div class="col-md-12">
            <div class="form-group">
                <h2 style="color:red">เหตุผลการแก้ไข</h2>
                <textarea id="exampleFormControlTextarea1" style="background-color:white" rows="3" ng-model="FULL_MODEL.TABEAN_RENEW.Note_Edit" class="form-control" placeholder="เหตุผลการขอแก้ไข" readonly></textarea>
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="form-row">
        <h2 style="color:red">เอกสารแนบประกอบการแก้ไข</h2>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="card" ng-repeat="x in FULL_MODEL.FILE_ATTACH_STAFF">
                <div class="card-body">
                    <h3 class="card-title">{{x.Document_Name}}</h3>
                    <div style="cursor:pointer;margin:unset;" layout="column" ng-show="!(x.NAME_REAL == undefined || x.NAME_REAL == null || x.NAME_REAL == '')">
                        <span>วันที่อัพโหลด : <span style="color:green">{{x.CREATE_DATE}}</span></span>
                        <span>ชื่อไฟล์ : <span style="color:green"><a href="#" ng-click="show_attach_preview(x.IDA)">{{x.NAME_REAL}}</a></span></span>
                        @*<p>สถานะ : <span style="color:green">แนบไฟล์แล้ว </span></p>*@
                        <hr />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div ng-show="FULL_MODEL.TABEAN_RENEW.Edit_Staff_Chk == true">
        <h2 style="color:red">รายละเอียดคำขอที่ต้องแก้ไข</h2>
        <div ng-show="FULL_MODEL.TABEAN_RENEW.Header_Edit_Person == true">
            @Html.Partial("../TABEAN_RENEW/Renew_Information_Request")
        </div>
        <br />
        <div ng-show="FULL_MODEL.TABEAN_RENEW.Header_Edit_Location == true">
            @Html.Partial("../TABEAN_RENEW/Renew_Imformation_Location")
        </div>
    </div>
    <div ng-show="FULL_MODEL.TABEAN_RENEW.Edit_Staff_File_Chk == true">
        <div class="form-row">
            <h2 style="color:red">เอกสารแนบที่ต้องแก้ไข</h2>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="card" ng-repeat="x in FULL_MODEL.FILEUPLOADTABLE">
                    <div class="card-body">
                        <h3 class="card-title">{{x.index}}. {{x.Document_Name}}</h3>
                        <div style="cursor:pointer;margin:unset;" layout="column" ng-show="!(x.NAME_REAL == undefined || x.NAME_REAL == null || x.NAME_REAL == '')">
                            <span>วันที่อัพโหลด : <span style="color:green">{{x.CREATE_DATE}}</span></span>
                            <span>ชื่อไฟล์ : <span style="color:green"><a href="#" ng-click="show_attach_preview(x.IDA)">{{x.NAME_REAL}}</a></span></span>
                            <span>สถานะ : <span style="color:green">แนบไฟล์แล้ว </span></span>
                            @*<span ng-show="x.EditTypeFile >= 1">สถานะ : <span style="color:orange">แก้ไขไฟล์ </span></span>*@
                            <hr />
                        </div>
                        <div class="input-group mb-2">
                            <div class="custom-file" ng-show="x.EditTypeFile >= 1">
                                <input type="file" class="custom-file-input" id="inputGroupFile01" ngf-select="Uploadattact(x.FileForUpload, x.index, x.TYPE, x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">
                                <label class="custom-file-label" for="inputGroupFile01">Choose file</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
