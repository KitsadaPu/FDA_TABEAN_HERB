<from>
    <div ng-hide="FULL_MODEL.STATUS_ID == 3 || FULL_MODEL.STATUS_ID == 31 || FULL_MODEL.STATUS_ID == 41">
        <div class="form-group" ng-hide="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
            <strong><label for="validationInputStatus" style="text-align:left">เลือกสถานะ:</label></strong>
            <select class="form-control" id="validationInputStatus" ng-model="FULL_MODEL.CONFIRM_STATUS_ID" ng-change="fil_req_ddl_status_staff()" ng-disabled="FULL_MODEL.STATUS_ID == 8">
                <option value="" disabled selected ng-if="FULL_MODEL.STATUS_ID != 8">กรุณาเลือก...</option>
                <option ng-repeat="x in FULL_MODEL.ddl_status_staff" ng-value="{{x.STATUS_ID}}">{{x.STATUS_NAME_STAFF}}</option>
            </select>
        </div>
        <div ng-show="FULL_MODEL.CONFIRM_STATUS_ID == 31">
            <div class="form-group">
                <strong><label for="StatusStaff" style="text-align:left">ค่าประเมินเอกสารทางวิชาการ:</label></strong>
                <select class="form-control custom-select custom-select-sm" ng-model="FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID" ng-change="Price_Request()">
                    <option value="" disabled selected>กรุณาเลือก...</option>
                    <option ng-repeat="x in FULL_MODEL.ddl_price" ng-value="{{x.ID}}">{{x.Request_Name}}</option>
                </select>
            </div>
            <div class="form-group">
                <strong><label for="StatusStaff" style="text-align:left">เงื่อนไขส่วนลดค่าคำขอ:</label></strong>
                <select class="form-control" ng-model="FULL_MODEL.TABEAN_RENEW.Discount_EstimateID" ng-change="Price_Request_Discount()">
                    <option value="" selected>กรุณาเลือก...</option>
                    <option ng-repeat="x in FULL_MODEL.ddl_discount" ng-value="{{x.ID}}">{{x.DiscountName}}</option>
                </select>
            </div>
            <div class="form-group">
                <strong><label for="StatusStaff" style="text-align:left">จำนวนเงิน:</label></strong>
                <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.TABEAN_RENEW.ML_ESTIMATE" readonly> บาท
            </div>
        </div>
        <div ng-show="FULL_MODEL.CONFIRM_STATUS_ID == 23">
            <div class="form-group">
                <strong><label for="StatusStaff" style="text-align:left">ช่องทางการจำหน่าย:</label></strong>
                <select class="form-control" ng-model="FULL_MODEL.TABEAN_RENEW.Estimate_PAY_ID">
                    <option value="" disabled selected>กรุณาเลือก...</option>
                    <option ng-repeat="x in FULL_MODEL.ddl_sale_channel" ng-value="{{x.SALE_CHANNEL_ID}}">{{x.SALE_CHANNEL_NAME}}</option>
                </select>
            </div>
            <div class="form-group">
                <strong><label for="StatusStaff" style="text-align:left">ชนิดผลิตภัณฑ์:</label></strong>
                <select class="form-control" ng-model="FULL_MODEL.TABEAN_RENEW.Discount_EstimateID">
                    <option value="" disabled selected>กรุณาเลือก...</option>
                    <option ng-repeat="x in FULL_MODEL.ddl_kind_tabean" ng-value="{{x.kindcd}}">{{x.thakindnm}}</option>
                </select>
            </div>
        </div>
        <div class="form-group" ng-if="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
            <strong><label for="StatusStaff" style="text-align:left">สถานะคำขอ:</label></strong>
            <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.STATUS_NAME" ng-readonly="FULL_MODEL.STATUS_ID == 8">
        </div>
        <div class="form-group">
            <strong><label for="DateConStaff" style="text-align:left">วันที่ดำเนินการ:</label></strong>
            <input type="date" class="form-control" id="DateConStaff" aria-describedby="DateConHelp" ng-model="FULL_MODEL.DATE_CONNFIRM" ng-readonly="FULL_MODEL.STATUS_ID == 8">
            <small id="DateConHelp" class="form-text text-muted">เลือกวันโดยการกดที่ปฏิทิน.</small>
        </div>
        <div class="form-group" ng-hide="FULL_MODEL.STATUS_ID == 8 || FULL_MODEL.STATUS_ID == 7">
            <strong><label for="validationInputStaff" style="text-align:left">เจ้าหน้าที่ดำเนินการ:</label></strong>
            <select class="form-control" id="validationInputStaff" ng-model="FULL_MODEL.STAFF_NAME_ID" ng-disabled="FULL_MODEL.STATUS_ID == 8">
                <option value="" disabled>กรุณาเลือก...</option>
                <option ng-repeat="x in FULL_MODEL.ddl_staff_name" ng-value="x.CITIZEN_ID">{{x.STAFF_NAME}}</option>
            </select>
        </div>
        <div class="form-group" ng-if="FULL_MODEL.STATUS_ID == 8||FULL_MODEL.STATUS_ID == 7">
            <strong><label for="validationInputStaff" style="text-align:left">เจ้าหน้าที่อนุมัติ:</label></strong>
            <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.TABEAN_RENEW.appdate_StaffName" ng-readonly="FULL_MODEL.STATUS_ID == 8">
        </div>
        <div class="form-group" ng-if="(FULL_MODEL.STATUS_ID == 6||FULL_MODEL.STATUS_ID == 8)">
            <strong> <label for="validationInputRemarkStaff" style="text-align:left">หมายเหตุ:</label></strong>
            @*<input type="text" class="form-control" id="validationInputRemarkStaff" aria-describedby="RemarkHelp" ng-model="FULL_MODEL.DATE_CONNFIRM">*@
            <textarea class="form-control" id="validationInputRemarkStaff" ng-model="FULL_MODEL.NOTE_STAFF" ng-readonly="FULL_MODEL.STATUS_ID == 8"></textarea>
            <small id="RemarkHelp" class="form-text text-muted">เหตุผลเพิ่มเติม.</small>
        </div>
    </div>
    <div ng-show="!(FULL_MODEL.STATUS_ID == 8|| FULL_MODEL.STATUS_ID == 7|| FULL_MODEL.STATUS_ID == 0||FULL_MODEL.STATUS_ID == 31||FULL_MODEL.STATUS_ID == 41)" style="text-align:center;">
        <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" ng-click="BTN_STAFF_CONFIRM_CLICK()" value="บันทึก" />
    </div>
    <div style="height: 5px;" ng-show="(FULL_MODEL.STATUS_ID == 31||FULL_MODEL.STATUS_ID == 41)"></div>
    <div ng-show="(FULL_MODEL.STATUS_ID == 31||FULL_MODEL.STATUS_ID == 41)" style="text-align:center;">
        <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" data-dismiss="modal" ng-click="BTN_STAFF_KEEP_STATUS_CLICK()" value="ข้ามสถานะจ่ายเงิน" />
    </div>
    <div style="height: 5px;"></div>
    <div ng-show="( FULL_MODEL.CONFIRM_STATUS_ID == 23 || FULL_MODEL.CONFIRM_STATUS_ID == 6 || FULL_MODEL.CONFIRM_STATUS_ID == 61 ||FULL_MODEL.CONFIRM_STATUS_ID == 62||FULL_MODEL.CONFIRM_STATUS_ID == 8||FULL_MODEL.STATUS_ID == 8
                 ||FULL_MODEL.STATUS_ID == 6||FULL_MODEL.STATUS_ID == 61||FULL_MODEL.STATUS_ID == 23)" style="text-align:center;">
        <input type="button" class="btn btn-info" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" ng-click="BTN_PREVIEW_TABEAN_CLICK()" value="PREVIEW ใบสำคัญ" />
    </div>
    <div style="height: 5px;"></div>
    <div ng-show="!( FULL_MODEL.STATUS_ID == 75|| FULL_MODEL.STATUS_ID == 76|| FULL_MODEL.STATUS_ID == 77|| FULL_MODEL.STATUS_ID == 78||FULL_MODEL.STATUS_ID == 8)" style="text-align:center;">
        <input type="button" class="btn btn-danger" name="abortrequest" id="abortrequest" style="Height:48px; Width:100%" ng-click="BTN_CENCLE_CLICK(IDA)" value="ยกเลิกคำขอ" />
    </div>
    <div style="height: 5px;"></div>
    <div style="text-align:center;">
        <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height:48px; Width:100%" data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
    </div>
</from>