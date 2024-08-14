
<form @*ng-controller="Substitute_Add_CTRL"*@ style="padding-left:2em">
    <h3>คำขอใบแทนสำหรับผลิตภัณฑ์สมุนไพร </h3>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-4">
            <div class="form-check">
                <input class="form-check-input" type="radio" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.PROCESS_ID" name="TabeanTypeRadios" id="TabeanTypeRadios1" value="20610">
                <label class="form-check-label" for="TabeanTypeRadios1">
                    คำขอใบแทนใบสำคัญกำรขึ้นทะเบียนตำรับผลิตภัณฑ์สมุนไพร
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="radio" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.PROCESS_ID" name="TabeanTypeRadios" id="TabeanTypeRadios2" value="20620">
                <label class="form-check-label" for="TabeanTypeRadios2">
                    คำขอใบแทนใบรับแจ้งรำยละเอียดผลิตภัณฑ์สมุนไพร
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="radio" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.PROCESS_ID" name="TabeanTypeRadios" id="TabeanTypeRadios3" value="20630">
                <label class="form-check-label" for="TabeanTypeRadios3">
                    คำขอใบแทนใบรับจดแจ้งผลิตภัณฑ์สมุนไพร
                </label>
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="form-row">
        <h4>ชื่อผู้ขอรับใบแทน</h4>
        <hr />
    </div>
    <div style="height: 15px;"></div>
    <div class="form-group row">
        <div class="form-check form-check-inline">
            <input class="form-check-input" type="radio" name="TypePersonRadio" id="TypePerson1" ng-value="1" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON">
            <label class="form-check-label" for="inlineRadio1">บุคคลธรรมดา</label>
        </div>
        <div class="form-check form-check-inline">
            <input class="form-check-input" type="radio" name="TypePersonRadio" id="TypePerson2" ng-value="99" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON">
            <label class="form-check-label" for="inlineRadio2">นิติบุคคล</label>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="form-group row">
        <label for="colFormLabel" class="col-sm-1 col-form-label">ข้าพเจ้า:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="LicenName" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.THANM" readonly>
        </div>
        <label for="Idenntify" ng-if="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON != 1" class="col-sm-1 col-form-label">เลขทะเบียนนิติบุคคล:</label>
        <label for="Idenntify" ng-if="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON == 1" class="col-sm-1 col-form-label">เลขประจำตัวประชาชน:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="Idenntify" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.CITIZEN_ID_AUTHORIZE" aria-describedby="BSNDetail" readonly>
        </div>
    </div>
    <div class="form-group row" ng-if="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.TYPE_PERSON != 1">
        <label for="colFormLabel" class="col-sm-1 col-form-label">โดยมี:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="BSNName" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99" aria-describedby="BSNDetail" readonly>
            <small id="BSNDetail" class="form-text text-muted">เป็นผู้แทนนิติบุคคล หรือผู้มีอำนาจทำการแทนนิติบุคคล.</small>
        </div>
        <label for="CitizenAut" class="col-sm-1 col-form-label">เลขประจำตัวประชำชน:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="CitizenAut" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.AGENT99_ID" readonly>
        </div>
    </div>
    <div class="form-group row">
        <label for="colFormLabel" class="col-sm-1 col-form-label">อายุ:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="PersonAge" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.PERSON_AGE">
        </div>
        <label for="colFormLabel" class="col-sm-1 col-form-label">สัญชาติ:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="Nation" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.NATIONAL_NAME">
        </div>
    </div>
    <div class="form-row">
        <h4>ขอรับใบแทนผลิตภัณฑ์สมุนไพร</h4>
    </div>
    <div class="form-group row">
        <label for="colFormLabel" class="col-sm-1 col-form-label">ชื่อ (ภาษาไทย):</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="DrugNameThai" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.NAME_THAI" readonly>
        </div>
        <label for="colFormLabel" class="col-sm-1 col-form-label">ชื่อ (ภาษาอังกฤษ):</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="DrugNameEng" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.NAME_ENG" readonly>
        </div>
    </div>
    <div class="form-group">
        <label for="RGTNO_Display">ใบสำคัญการขึ้นทะเบียนตำรับ/ ใบรับแจ้งรายละเอียด/ ใบรับจดแจ้งผลิตภัณฑ์สมุนไพร เลขที่:</label>
        <input type="text" class="form-control" id="RGTNO_Display" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.RGTNO_FULL"readonly />
    </div>
    <div class="form-group">
        <label class="my-1 mr-2" for="PurposeRequest">เหตุที่ขอใบแทนผลิตภัณฑ์สมุนไพร</label>
        <select class="custom-select my-1 mr-sm-2" id="PurposeRequest" ng-model="FULL_MODEL.TABEAN_HERB_SUBSTITUTE.PURPOSE_ID">
            <option value="" disabled selected>กรุณาเลือก...</option>
            <option value="1">ใบอนุญาตสูญหาย </option>
            <option value="2">ใบอนุญาตถูกทำลาย หรือ ลบเลือนในสาระสำคัญ </option>
        </select>
    </div>

    @*<button type="button" class="btn btn-warning my-1" ng-click="BTN_BACK_PAGE()">ย้อนกลับ</button>
        <button type="submit" class="btn btn-primary my-1" ng-click="BTN_SUBSTITUTE_SAVE()">บันทึกข้อมูล</button>*@
</form>
