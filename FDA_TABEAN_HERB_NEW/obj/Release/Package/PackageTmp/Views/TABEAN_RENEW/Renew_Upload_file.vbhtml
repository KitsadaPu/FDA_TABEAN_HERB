<form>
    <div class="card">
        <div class="card-header alert alert-info"> รายการเอกสารแนบคำขอต่ออายุใบสำคัญ</div>
        <div class="card-body">
            <blockquote class="blockquote mb-0">
                <div>
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
                                <tr ng-if="FILEUPLOADTABLE.length===0">
                                    <td colspan="7" class="text-center text-base-danger">--- ไม่มีเอกสารแนบ กรุณาติดต่อเจ้าหน้าที่ เพื่อตรวจสอบ ---</td>
                                </tr>
                                <tr ng-repeat="x in FILEUPLOADTABLE">
                                    <td hidden="hidden">{{x.IDA}} </td>
                                    <td>{{x.index}} </td>
                                    <td class="col-sm-9">
                                        {{x.Document_Name}}<i style="color:red" ng-show="x.Forcible == 'True'">*</i>
                                        <div class="small" style="cursor:pointer;margin:unset;" layout="column" ng-show="!(x.NAME_REAL == undefined || x.NAME_REAL == null || x.NAME_REAL == '')">
                                            <span><strong>วันที่อัพโหลด : </strong><span style="color:green">{{x.CREATE_DATE}}</span></span>
                                            <span><strong>ชื่อไฟล์ :</strong> <span style="color:green"><a href="#" ng-click="show_attach_preview(x.IDA)">{{x.NAME_REAL}}</a></span></span>
                                            <span><strong>สถานะ :</strong> <span style="color:green">แนบไฟล์แล้ว </span></span>
                                            <hr />
                                        </div>
                                    </td>
                                    <td class="col-sm-3">
                                        <div class="input-group mb-3">
                                            <div class="custom-file">
                                                <input type="file" class="custom-file-input" id="inputGroupFile01" ngf-select="Uploadattact(x.FileForUpload, x.index, x.TYPE,x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">
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
            </blockquote>
        </div>
    </div>
    @*<div class="alert alert-info">
        รายการเอกสารแนบคำขอต่ออายุใบสำคัญ<br />
    </div>*@
    @*<div class="form-row">
            <h3>รายการเอกสารแนบ</h3>
        </div>*@
    @*<div class="row">*@

    @*</div>*@
    <div style="height: 15px;"></div>
</form>
