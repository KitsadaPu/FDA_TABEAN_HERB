<form class="needs-validation" novalidate>
    <h4>กรุณากรอกข้อมูล รายละเอียดการยกเลิกคำขอ</h4>
    <div class="form-group">
        <label for="validationTxt_name_appoinment" class="col-form-label">โปรดเลือกเหตุผล :</label>
        <select class="custom-select mr-sm-2" id="validationInputDiscount" ng-model="FULL_MODEL.LCN_APPROVE_EDIT.DD_CANCEL_NM">
            <option value="" disabled selected>กรุณาเลือก...</option>
            <option ng-repeat="x in FULL_MODEL.ddl_CancelRequest" ng-value="{{x.ID}}">{{x.STATUS_CAUSE}}</option>
        </select>
    </div>
    <div class="form-group">
        <label for="Txt_note_CancelDetail" class="col-form-label">รายละเอียดการยกเลิก(ถ้ามี) :</label>
        <textarea class="form-control" id="Txt_note_CancelDetail" ng-model="FULL_MODEL.LCN_APPROVE_EDIT.Appoinment_Email"></textarea>
        <small id="RemarkHelp" class="form-text text-muted">เหตุผลเพิ่มเติม.</small>
    </div>
    <div class="form-group col-md-2">
        <label for="validationtxt_date_cancel" class="col-form-label">วันที่ยกเลิก :</label>
        <input type="date" class="form-control" id="validationtxt_date_cancel" ng-model="FULL_MODEL.LCN_APPROVE_EDIT.cancel_date">
        <div class="invalid-feedback">
            กรุณากรอกข้อมูล วันที่ยกเลิกคำขอ.
        </div>
    </div>
    <div class="form-group">
        <label for="file_up" class="col-form-label">เอกสารแนบประกอบการยกเลิกคำขอ</label>
        @*<input type="file" style="margin:10px" id="file_up" ngf-select="Uploadattact_STAFF(x.FileForUpload, x.index, x.TOPIC_ID,x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">*@
        <input type="file" class="custom-file-input" id="inputGroupFile01" ngf-select="Uploadattact(x.FileForUpload, x.index, x.TOPIC_ID,x.IDA, x.CITIZEN_ID, x.PROCESS_ID,$index, x)" ng-model="x.FileForUpload">
    </div>
    <div class="form-group">
        {{FULL_MODEL.FILE_ATTACH.DUCUMENT_NAME}}
        <div style="cursor:pointer;margin:unset;" layout="column" ng-show="!(x.NAME_REAL == undefined || x.NAME_REAL == null || x.NAME_REAL == '')">
            <p>วันที่อัพโหลด : <span style="color:green">{{x.CREATE_DATE}}</span></p>
            <p>ชื่อไฟล์ : <span style="color:green"><a href="#" ng-click="show_attach_preview(x.NAME_FAKE)">{{x.NAME_REAL}}</a></span></p>
            <p>สถานะ : <span style="color:green">แนบไฟล์แล้ว </span></p>
            <hr />
        </div>
    </div>
    <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" data-dismiss="modal" ng-click="BTN_SAVE_CANCEL_CLICK()">Save</button>
    </div>
</form>


