<form>
    <div class="alert alert-info">
        รายการเอกสารแนบคำขอใบแทนใบสำคัญ<br />
    </div>
    @*<div class="form-row">
        <h3>รายการเอกสารแนบ</h3>
    </div>*@
    <div class="row">
        <div class="mat-elevation-z8" style="padding-left:2em;padding-right:2em">
            <table class="table" id="tb_file_upload_sub" width="100%">
                <thead>
                    <tr>
                        @*<th scope="col">ลำดับ</th>
                        <th scope="col">เอกสารที่ต้องอัพโหลด</th>
                        <th scope="col">ไฟล์อัพโหลด</th>
                        <th scope="col"></th>*@
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="x in FILEUPLOADTABLE">
                        <td hidden="hidden">{{x.IDA}} </td>
                        <td>{{x.index}} </td>
                        <td>
                            {{x.DUCUMENT_NAME}}
                            <div style="cursor:pointer;margin:unset;" layout="column" ng-show="!(x.NAME_REAL == undefined || x.NAME_REAL == null || x.NAME_REAL == '')">
                                <p>วันที่อัพโหลด : <span style="color:green">{{x.CREATE_DATE}}</span></p>
                                <p>ชื่อไฟล์ : <span style="color:green"><a href="#" ng-click="show_attach_preview(x.NAME_FAKE)">{{x.NAME_REAL}}</a></span></p>
                                <p>สถานะ : <span style="color:green">แนบไฟล์แล้ว </span></p>
                                <hr />
                            </div>
                        </td>
                        <td>
                            <div class="input-group mb-3">
                                <div class="custom-file">
                                    <input type="file" class="custom-file-input" id="inputGroupFile01" ngf-select="Uploadattact(x.FileForUpload, x.index, x.TOPIC_ID,x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">
                                    <label class="custom-file-label" for="inputGroupFile01">Choose file</label>
                                </div>
                            </div>
                        </td>
                    </tr>
                </tbody>
                <tfoot></tfoot>
            </table>
        </div>
    </div>
    <div style="height: 15px;"></div>
    @*<div class="row">
            <div class="col-sm-12 " style="text-align:center">
                <input type="button" class="btn btn-lg" ng-click="BTN_BACK_PAGE()" value="ย้อนกลับ" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="button" class="btn btn-lg btn-success" ng-click="BTN_SAVE_DATA_UPLOAD_CLICK()" value="บันทึก" />
            </div>
        </div>*@
</form>