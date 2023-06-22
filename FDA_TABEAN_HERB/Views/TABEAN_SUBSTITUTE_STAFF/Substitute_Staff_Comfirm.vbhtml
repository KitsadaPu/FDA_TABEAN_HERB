<form>
    <div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1000px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">
            <div ng-hide="FULL_MODEL.STATUS_ID == 5">
                <div class="form-group" ng-hide="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
                    <label for="validationInputStatus">เลือกสถานะ:</label>
                    <select class="form-control" id="validationInputStatus" ng-model="FULL_MODEL.CONFIRM_STATUS_ID" ng-change="fil_req_ddl_status_staff()" ng-disabled="FULL_MODEL.STATUS_ID == 8">
                        <option value="" disabled selected ng-if="FULL_MODEL.STATUS_ID != 8">กรุณาเลือก...</option>
                        <option ng-repeat="x in FULL_MODEL.ddl_status_staff" ng-value="{{x.STATUS_ID}}">{{x.STATUS_NAME_STAFF}}</option>
                    </select>
                </div>
                <div class="form-group" ng-if="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
                    <label for="StatusStaff">สถานะคำขอ:</label>
                    <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.STATUS_NAME" ng-readonly="FULL_MODEL.STATUS_ID == 8">
                </div>
                <div class="form-group">
                    <label for="DateConStaff">วันที่รับคำขอ:</label>
                    <input type="date" class="form-control" id="DateConStaff" aria-describedby="DateConHelp" ng-model="FULL_MODEL.DATE_CONNFIRM" ng-readonly="FULL_MODEL.STATUS_ID == 8">
                    <small id="DateConHelp" class="form-text text-muted">เลือกวันโดยการกดที่ปฏิทิน.</small>
                </div>
                <div class="form-group" ng-hide="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
                    <label for="validationInputStaff">เจ้าหน้าที่รับคำขอ:</label>
                    <select class="form-control" id="validationInputStaff" ng-model="FULL_MODEL.STAFF_NAME_ID" ng-change="fil_req_staff_name()" ng-disabled="FULL_MODEL.STATUS_ID == 8">
                        <option value="" disabled selected ng-if="FULL_MODEL.STATUS_ID != 8">กรุณาเลือก...</option>
                        <option ng-repeat="x in FULL_MODEL.ddl_staff_name" ng-value="{{x.IDA}}">{{x.STAFF_NAME}}</option>
                    </select>
                </div>
                <div class="form-group" ng-if="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
                    <label for="validationInputStaff">เจ้าหน้าที่อนุมัติ:</label>
                    <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.appdate_StaffName" ng-readonly="FULL_MODEL.STATUS_ID == 8">
                </div>
                <div class="form-group" ng-if="(FULL_MODEL.STATUS_ID == 6||FULL_MODEL.STATUS_ID == 8)">
                    <label for="validationInputRemarkStaff">หมายเหตุ:</label>
                    @*<input type="text" class="form-control" id="validationInputRemarkStaff" aria-describedby="RemarkHelp" ng-model="FULL_MODEL.DATE_CONNFIRM">*@
                    <textarea class="form-control" id="validationInputRemarkStaff" ng-model="FULL_MODEL.NOTE_STAFF" ng-readonly="FULL_MODEL.STATUS_ID == 8"></textarea>
                    <small id="RemarkHelp" class="form-text text-muted">เหตุผลเพิ่มเติม.</small>
                </div>
                <div class="form-group" ng-if="(FULL_MODEL.CONFIRM_STATUS_ID == 7||FULL_MODEL.CONFIRM_STATUS_ID == 8)">
                    <label for="validationInputRemarkStaff">หมายเหตุ:</label>
                    @*<input type="text" class="form-control" id="validationInputRemarkStaff" aria-describedby="RemarkHelp" ng-model="FULL_MODEL.DATE_CONNFIRM">*@
                    <textarea class="form-control" id="validationInputRemarkStaff" ng-model="FULL_MODEL.NOTE_STAFF" ng-readonly="FULL_MODEL.STATUS_ID == 8"></textarea>
                    <small id="RemarkHelp" class="form-text text-muted">เหตุผลเพิ่มเติม.</small>
                </div>
            </div>
            <div class="form-group" ng-if="FULL_MODEL.FILE_ATTACH != null">
                <label for="tb_msa_cuia_staff">เอกสารแนบ:</label>
                <div class="table-responsive">
                    <table ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0" class="table-striped" id="tb_msa_cuia_staff">
                        <thead>
                            <tr>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH">
                                <td hidden="hidden">{{x.IDA}} </td>
                                <td>{{x.index}} </td>
                                <td>{{x.DUCUMENT_NAME}} </td>
                                <td>{{x.NAME_REAL}} </td>
                                <td>
                                    <a href="#" ng-click="show_attach_preview(x.NAME_FAKE)" style="color:#0033CC;">ดูข้อมูล</a>
                                    @*<p>ดูข้อมูล<span style="color:green"><a href="#" ng-click="show_attach_preview(x.NAME_FAKE)"></a></span></p>*@
                                </td>
                            </tr>
                        </tbody>
                        <tfoot></tfoot>
                    </table>
                </div>
            </div>

            <div ng-show="!(FULL_MODEL.STATUS_ID == 8|| FULL_MODEL.STATUS_ID == 7|| FULL_MODEL.STATUS_ID == 0||FULL_MODEL.STATUS_ID == 5)" style="text-align:center;">
                <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" data-dismiss="modal" ng-click="BTN_STAFF_CONFIRM_CLICK()" value="บันทึก" />
            </div>
            @*<div style="height: 5px;" ng-show="(FULL_MODEL.STATUS_ID == 5)"></div>
            <div ng-show="(FULL_MODEL.STATUS_ID == 5)" style="text-align:center;">
                <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" data-dismiss="modal" ng-click="BTN_STAFF_KEEP_STATUS_CLICK()" value="ข้ามสถานะจ่ายเงิน" />
            </div>*@
            <div style="height: 5px;"></div>
            <div ng-show="!( FULL_MODEL.STATUS_ID == 75|| FULL_MODEL.STATUS_ID == 76|| FULL_MODEL.STATUS_ID == 77|| FULL_MODEL.STATUS_ID == 78|| FULL_MODEL.STATUS_ID == 11|| FULL_MODEL.STATUS_ID == 7)" style="text-align:center;">
                <input type="button" class="btn btn-info" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" ng-click="BTN_PREVIEW_SUBSTITUTE_CLICK()" value="PREVIEW ใบสำคัญ" />
            </div>
            <div style="height: 5px;"></div>
            <div ng-show="!( FULL_MODEL.STATUS_ID == 75|| FULL_MODEL.STATUS_ID == 76|| FULL_MODEL.STATUS_ID == 77|| FULL_MODEL.STATUS_ID == 78||FULL_MODEL.STATUS_ID == 8)" style="text-align:center;">
                <input type="button" class="btn btn-danger" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" ng-click="BTN_CENCLE_CLICK(IDA)" value="ยกเลิกคำขอ" />
            </div>
            <div style="height: 5px;"></div>
            <div style="text-align:center;">
                <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height:48px; Width:100%" data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
            </div>
        </div>
    </div>
</form>
