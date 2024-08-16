<div @*ng-controller="Tabean_Renew_EditFile_CTRL"*@>
    <div class="form-row align-items-center">
        <div class="col-auto my-1">
            <div class="custom-control custom-checkbox mr-sm-2" required>
                <input type="checkbox" class="custom-control-input" id="Edit_Staff_Chk" ng-model="FULL_MODEL.TABEAN_RENEW.Edit_Staff_Chk">
                <label class="custom-control-label" for="Edit_Staff_Chk">แก้ไขข้อมูลคำขอ</label>
            </div>
        </div>
        <div class="col-auto my-1">
            <div class="custom-control custom-checkbox mr-sm-2" required>
                <input type="checkbox" class="custom-control-input" id="Edit_Staff_File_Chk" ng-model="FULL_MODEL.TABEAN_RENEW.Edit_Staff_File_Chk">
                <label class="custom-control-label" for="Edit_Staff_File_Chk">แก้ไขเอกสารแนบ</label>
            </div>
        </div>
        @*<div class="col-auto my-1">
                <button type="submit" class="btn btn-primary">Submit</button>
            </div>*@
    </div>
    <div ng-show="FULL_MODEL.TABEAN_RENEW.Edit_Staff_Chk == true" style="padding-left:2em">
        <div class="custom-control custom-switch">
            <input type="checkbox" class="custom-control-input" id="customSwitch1" ng-model="FULL_MODEL.TABEAN_RENEW.Header_Edit_Person">
            <label class="custom-control-label" for="customSwitch1">แก้ไขข้อมูลส่วนที่ 2 ข้อมูลผู้ขอต่ออายุใบสำคัญ</label>
        </div>
        <div class="custom-control custom-switch">
            <input type="checkbox" class="custom-control-input" id="customSwitch2" ng-model="FULL_MODEL.TABEAN_RENEW.Header_Edit_Location">
            <label class="custom-control-label" for="customSwitch2">แก้ไขข้อมูลส่วนที่ 3 ข้อมูลสถานที่ผลิต หรือนำเข้า </label>
        </div>
    </div>
    <div class="row" ng-show="FULL_MODEL.TABEAN_RENEW.Edit_Staff_File_Chk == true">
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="เอกสารแนบคำขอทะเบียน">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col">ลำดับ</th>
                                            <th style="width:90%" scope="col">รายการเอกสาร</th>
                                            @*<th style="width:40%" scope="col">ชื่อเอกสารที่อัพโหลด</th>*@
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH">
                                            <td>
                                                {{x.index}}
                                            </td>
                                            <td>
                                                @*{{x.Document_Name}}*@
                                                <a href="#" ng-click="show_attach_preview(x.IDA)">{{x.Document_Name}}</a>
                                                @*<input class="form-inline form-control" ng-model="item.DUCUMENT_NAME" />*@
                                            </td>
                                            @* <td>
                                                       <a href="#" ng-click="show_attach_preview(x.NAME_FAKE)">{{x.NAME_REAL}}</a>
                                                    <input class="form-inline form-control" ng-model="item.NAME_REAL" />
                                                    </td>
                                                    @*<td>
                                                    <button class="btn btn-danger btn-sm float-right" ng-click="delete_event($index)"><i class="fas fa-minus-circle"></i></button>
                                                </td>*@
                                        </tr>
                                    </tbody>
                                </table>
                            </md-content>

                        </md-tab>
                    </md-tabs>
                </md-content>
            </div>
        </div>
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="รายการเอกสารที่แก้ไข">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col">รายการ</th>
                                            <th style="width:90%" scope="col">รายการเอกสาร</th>
                                            @*<th style="width:40%" scope="col">ชื่อเอกสารที่อัพโหลด</th>*@
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH_EDIT">
                                            <td>
                                                <input type="checkbox" ng-model="x.CHK_VALUVE" ng-disabled="FULL_MODEL.STATUS_ID== 18">
                                            </td>
                                            <td>
                                                {{x.Document_Name}}
                                            </td>
                                            @*<td>
                                                    {{x.NAME_REAL}}
                                                </td>*@
                                        </tr>
                                    </tbody>
                                </table>
                            </md-content>
                        </md-tab>
                    </md-tabs>
                </md-content>
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <h3>รายละเอียดการแก้ไข</h3><hr />
    <div class="row was-validated">
        @*<div class="col-md-1"></div>*@
        <div class="col-md-12">
            <div class="form-group">
                <label for="exampleFormControlTextarea1">เหตุผลการส่งแก้ไข :</label>
                <textarea id="exampleFormControlTextarea1" rows="3" ng-model="FULL_MODEL.TABEAN_RENEW.Note_Edit" class="form-control is-invalid" ng-readonly="FULL_MODEL.STATUS_ID== 22" ng-show="FULL_MODEL.STATUS_ID== 21 || FULL_MODEL.STATUS_ID== 22" placeholder="เหตุผลการขอแก้ไข" required></textarea>
                @*<textarea id="exampleFormControlTextarea1" rows="3" ng-model="FULL_MODEL.TABEAN_RENEW.Note_Edit2" class="form-control is-invalid" ng-readonly="FULL_MODEL.STATUS_ID== 20" ng-show="FULL_MODEL.STATUS_ID== 22 || FULL_MODEL.STATUS_ID== 22" placeholder="เหตุผลการขอแก้ไข" required></textarea>*@
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="form-row">
        <h3>เอกสารแนบประกอบการส่งแก้ไข</h3>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="card" ng-repeat="x in FULL_MODEL.FILE_ATTACH_STAFF">
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
                        <div class="custom-file">
                            <input type="file" class="custom-file-input" id="inputGroupFile01" ngf-select="Uploadattact(x.FileForUpload, x.index, x.TYPE, x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">
                            <label class="custom-file-label" for="inputGroupFile01">Choose file</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal" ng-click="exitpage()">Close</button>
        <button type="submit" class="btn btn-primary" ng-click="BTN_SAVE_DATA_EDITFILE_CLICK(18)" ng-disabled="FULL_MODEL.STATUS_ID== 18">Save</button>
    </div>

</div>
