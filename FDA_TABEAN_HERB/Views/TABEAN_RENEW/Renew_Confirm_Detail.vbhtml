
<form class="needs-validation" novalidate>
    <h4>กรุณากรอกข้อมูล รายละเอียดประกอบการนัดหมาย</h4>
    <div class="form-group">
        <label for="validationTxt_name_appoinment" class="col-form-label">ชื่อผู้ติดต่อ:</label>
        <input type="text" class="form-control" id="validationTxt_name_appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Contact">
        <div class="invalid-feedback">
            กรุณากรอกข้อมูล ชื่อผู้ติดต่อ.
        </div>
    </div>
    <div class="form-group">
        <label for="validationTxt_email_Appoinment" class="col-form-label">E-mail:</label>
        <input type="email" class="form-control" id="validationTxt_email_Appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Email">
        <div class="invalid-feedback">
            กรุณากรอกข้อมูล E-mail.
        </div>
    </div>
    <div class="form-group">
        <label for="validationtxt_Phone_Appoinment" class="col-form-label">หมายเลขโทรศัพท์ติดต่อกลับ:</label>
        <input type="tel" class="form-control" id="validationtxt_Phone_Appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Phone">
        <div class="invalid-feedback">
            กรุณากรอกข้อมูล หมายเลขโทรศัพท์ติดต่อกลับ.
        </div>
    </div>

    <h4>ส่วนลดค่าคำขอ(ถ้ามี)</h4>
    <div class="form-group">
        <label for="validationInputDiscount">โปรดเลือกเงื่อนไขส่วนลดค่าคำขอ:</label>
        <select class="custom-select mr-sm-2" id="validationInputDiscount" ng-model="FULL_MODEL.TABEAN_RENEW.Discount_RequestID" >
            <option value="" disabled selected>กรุณาเลือก...</option>
            <option ng-repeat="x in FULL_MODEL.ddl_discount" ng-value="{{x.ID}}">{{x.DiscountName}}</option>
        </select>
        <div class="invalid-feedback">
            กรุณาเลือกข้อมูล เงื่อนไขส่วนลดค่าคำขอ.
        </div>
    </div>
    <div class="form-group">
        <label for="txt_Discount_Detail" class="col-form-label">รายละเอียดส่วนลดค่าคำขอ: </label>
        <textarea class="form-control" id="txt_Discount_Detail" ng-model="FULL_MODEL.TABEAN_RENEW.Discount_Detail"></textarea>
    </div>
</form>



