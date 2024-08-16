<div class="card">
    <div class="card-header alert alert-info"> ข้อมูลผู้ขอต่ออายุใบสำคัญการขึ้นทะเบียนตำรับ ใบรับแจ้งรายละเอียด ใบรับจดแจ้งผลิตภัณฑ์สมุนไพร</div>
    <div class="card-body">
        <blockquote class="blockquote mb-0">
            <div>
                <div class="form-check form-check-inline">
                    <md-radio-group ng-model="FULL_MODEL.TABEAN_RENEW.TYPE_PERSON" aria-labelledby="favoriteFruit">
                        <md-radio-button value="1" class="md-primary" disabled>บุคคลธรรมดา</md-radio-button>
                    </md-radio-group>
                </div>
                <div class="form-check form-check-inline">
                    <md-radio-group ng-model="FULL_MODEL.TABEAN_RENEW.TYPE_PERSON" aria-labelledby="favoriteFruit">
                        <md-radio-button value="2" class="md-primary" disabled>นิติบุคคล</md-radio-button>
                    </md-radio-group>
                </div>
                <hr />
                <div class="row" ng-show="FULL_MODEL.TABEAN_RENEW.TYPE_PERSON == 1">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                ข้าพเจ้า
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                เลขประจำตัวประชาชน
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.CITIZEN_AUTHORIZE" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                อายุ
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.Age" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                สัญชาติ
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.Nation" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ที่อยู่เลขที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thaaddr_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                หมู่บ้าน/อาคาร
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thabuilding_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                หมู่ที
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thamu_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                ตรอก/ซอย
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thasoi_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ถนน
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.tharoad_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                ตำบล/แขวง
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thathmblnm_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                อำเภอเขต
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thaamphrnm_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                จังหวัด
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thachngwtnm_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                รหัสไปรษณีย์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.zipcode_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                โทรสาร
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.LNM" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                โทรศัพท์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.tel_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                E-mail<i style="color:red">*</i>
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.Email"  placeholder="-" />
                            </div>
                        </div><br />
                    </div>
                </div>
                <div class="row" ng-show="FULL_MODEL.TABEAN_RENEW.TYPE_PERSON == 2">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                ข้าพเจ้า (ชื่อนิติบุคคล)
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                เลขทะเบียนนิติบุคคล
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.CITIZEN_AUTHORIZE" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ที่อยู่เลขที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thaaddr_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                หมู่บ้าน/อาคาร
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thabuilding_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                หมู่ที
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thamu_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                ตรอก/ซอย
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.LNM" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ถนน
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.tharoad_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                ตำบล/แขวง
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thathmblnm_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                อำเภอเขต
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thaamphrnm_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                จังหวัด
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.thachngwtnm_thanm" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                รหัสไปรษณีย์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.zipcode_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                โทรสาร
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.LNM" readonly placeholder="-" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                โทรศัพท์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.tel_thanm" readonly placeholder="-" />
                            </div>
                            <div class="col-md-3">
                                E-mail<i style="color:red">*</i>
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.Email" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                โดยมี<i style="color:red">*</i>
                            </div>
                            <div class="col-md-3">
                                <select class="custom-select-sm" ng-model="TABEAN_RENEW.BSN_PREFIX_CD" ng-change="filter_prefix()">
                                        <option value="" disabled ng-if="TABEAN_RENEW.BSN_PREFIX_CD">กรุณาเลือก...</option>
                                        <option ng-repeat="x in FULL_MODEL.ddl_prefix" ng-value="convert_int(x.prefixcd)" ng-selected="x.prefixcd === TABEAN_RENEW.BSN_PREFIX_CD">{{ x.thanm }}</option>
                                    </select>
                                @*<select  ng-model="TABEAN_RENEW.BSN_PREFIX_CD" ng-options="x.prefixcd as x.thanm for x in FULL_MODEL.ddl_prefix">
                                    <option value="" disabled selected>กรุณาเลือก...</option>
                                </select>*@
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" placeholder="ชื่อ" ng-model="TABEAN_RENEW.BSN_NAME" />
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" placeholder="นามสกุล" ng-model="TABEAN_RENEW.BSN_LNAME" />
                            </div>
                        </div><br />

                        <div class="row">
                            <div class="col-md-3">
                                เป็นผู้แทนนิติบุคคล หรือผู้มีอำนาจทำการแทนนิติบุคคล
                            </div>
                            <div class="col-md-1">
                                อายุ<i style="color:red">*</i>
                            </div>
                            <div class="col-md-1">
                                <input class="form-control" ng-model="TABEAN_RENEW.Age" />
                            </div>
                            <div class="col-md-1">
                                ปี
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                สัญชาติ<i style="color:red">*</i>
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.Nation" />
                            </div>
                            <div class="col-md-3">
                                เลขบัตรประชาชน<i style="color:red">*</i>
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="TABEAN_RENEW.BSN_IDENTIFY" />
                            </div>
                        </div><br />
                    </div>
                </div>
            </div>
        </blockquote>
    </div>
</div>
@*<div class="card">
        <div class="alert alert-info">
            ข้อมูลผู้ขอต่ออายุใบสำคัญการขึ้นทะเบียนตำรับ ใบรับแจ้งรายละเอียด ใบรับจดแจ้งผลิตภัณฑ์สมุนไพร<br />
        </div>
        <div class="row">
            <div class="col-md-12">
                <md-radio-group ng-model="PERSON_TYPE_1.PREFIX_NM" aria-labelledby="favoriteFruit">
                    <md-radio-button value="นาย" class="md-primary">บุคคลธรรมดา</md-radio-button>
                </md-radio-group>

            </div>
        </div>
        <div class="col-md-12">
            <md-radio-group ng-model="PERSON_TYPE_1.PREFIX_NM" aria-labelledby="favoriteFruit">
                <md-radio-button value="นาง" class="md-primary">นิติบุคคล</md-radio-button>
            </md-radio-group>
            <div class="row">
                <div class="col-md-12">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-5">
                                ข้าพเจ้า (ชื่อนิติบุคคล)<i style="color:red">*</i>
                            </div>
                            <div class="col-md-7">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-5">
                                เลขทะเบียนนิติบุคคล<i style="color:red">*</i>
                            </div>
                            <div class="col-md-7">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-5">
                                อายุ   <i style="color:red">*</i>
                            </div>
                            <div class="col-md-7">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-5">
                                สัญชาต  <i style="color:red">*</i>
                            </div>
                            <div class="col-md-7">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-5">
                                เลขประจำตัวประชาชน <i style="color:red">*</i>
                            </div>
                            <div class="col-md-7">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                ที่อยู่เลขที่ <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                หมู่บ้าน/อาคาร <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                หมู่ที <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                ตรอก/ซอย <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                ถนน<i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                ตำบล/แขวง <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                อำเภอเขต<i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                จังหวัด <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                รหัสไปรษณีย์
                                <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                โทรสาร <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-2">
                                โทรศัพท์
                                <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                            <div class="col-md-2">
                                E-mail <i style="color:red">*</i>
                            </div>
                            <div class="col-md-2">
                                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
                            </div>
                        </div><br />
                    </div>
                </div>
            </div>
        </div><br />

        <div class="row">
            <div class="col-md-5">
                นามสกุล   <i style="color:red">*</i>
            </div>
            <div class="col-md-7">
                <input class="form-control" ng-model="PERSON_TYPE_1.LNM" />
            </div>
        </div><br />
        <div class="row">
            <div class="col-md-5">
                อีเมล (หน่วยงาน)   <i style="color:red">*</i>
            </div>
            <div class="col-md-7">
                <input class="form-control" ng-model="PERSON_TYPE_1.EMAIL_DEPARTMENT" />
            </div>
        </div><br />
        <div class="row">
            <div class="col-md-5">
                อีเมล (ส่วนตัว/สำรอง)
            </div>
            <div class="col-md-7">
                <input class="form-control" ng-model="PERSON_TYPE_1.EMAIL_PRIVATE" />
            </div>
        </div><br />

        <div class="row">
            <div class="col-md-5">
                โทรศัพท์  <i style="color:red">*</i>
            </div>
            <div class="col-md-7">
                <input class="form-control" ng-model="PERSON_TYPE_1.TEL" />
            </div>
        </div><br />
        <div class="row">
            <div class="col-md-5">
                โทรสาร  <i style="color:red">*</i>
            </div>
            <div class="col-md-7">
                <input class="form-control" ng-model="PERSON_TYPE_1.FAX" />
            </div>
        </div><br />


    </div>*@
