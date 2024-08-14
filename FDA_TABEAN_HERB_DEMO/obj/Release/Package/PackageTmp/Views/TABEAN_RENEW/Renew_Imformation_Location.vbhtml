@*<div class="card">
        <div class="alert alert-info">
            ข้อมูลสถานที่ผลิต หรือนำเข้า ผลิตภัณฑ์สมุนไพร<br />
        </div>
    </div>*@
<div class="card">
    <div class="card-header alert alert-info"> ข้อมูลสถานที่ผลิต หรือนำเข้า ผลิตภัณฑ์สมุนไพร</div>
    <div class="card-body">
        <blockquote class="blockquote mb-0">
            <div>
                <div class="form-check form-check-inline">
                    <md-radio-group ng-model="TABEAN_RENEW.lcntpcd" aria-labelledby="favoriteFruit">
                        <md-radio-button value="ผสม" class="md-primary" disabled>ผลิตในประเทศ</md-radio-button>
                    </md-radio-group>
                </div>
                <div class="form-check form-check-inline">
                    <md-radio-group ng-model="TABEAN_RENEW.lcntpcd" aria-labelledby="favoriteFruit">
                        <md-radio-button value="นสม" class="md-primary" disabled>นำเข้า</md-radio-button>
                    </md-radio-group>
                </div>
                <hr />
                <div class="row" ng-show="TABEAN_RENEW.lcntpcd == 'ผสม'">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อผู้รับอนุญาตผลิต
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.licen" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อผู้ดำเนินกิจการ (กรณีนิติบุคคล)
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.grannm_lo" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อสถานที่ผลิต
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.thanm" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="form-group row">
                            <div class="col-md-3">
                                ใบอนุญาตผลิตเลขที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.lcnno_display_new" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                <input type="tel" class="form-control" id="colFormLabel" placeholder="ตัวอย่าง HB 10-1-65-99" aria-describedby="SearchHelp" ng-model="TABEAN_RENEW.LCNNO_NEW">
                                <small id="SearchHelp" class="form-text text-muted">*กรณีข้อมูลสถานที่ไม่อัพเดท ให้ท่านกรอกข้อมูลเลขที่ใบอนุญาตแล้วกดปุ่ม"ค้นหา"เพื่อทำการดึงข้อมูลใหม่.</small>
                                @*<label ng-hide="false" ng-model="TABEANRENEW.LCNNO_NEW"></label>
                                    <label ng-hide="false" ng-model="TABEANRENEW.LCNNO"></label>
                                    <label ng-hide="false" ng-model="TABEANRENEW.FK_LCN"></label>*@
                            </div>
                            <div class="col-md-3">
                                <button type="submit" class="btn btn-primary" ng-click="BTN_SEARCH_LCN_CLICK()">ค้นหา</button>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                อยู่เลขที
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thaaddr" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                ตรอก/ซอย
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thasoi" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ถนน
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.tharoad" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                หมู่ที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thamu" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ตำบล/แขวง
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thathmblnm" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                อำเภอ/เขต
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thaamphrnm" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                จังหวัด
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thachngwtnm" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                รหัสไปรษณีย์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.zipcode" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                โทรศัพท์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.tel" readonly placeholder="-"/>
                            </div>
                            @*<div class="col-md-3">
                                    รหัสไปรษณีย์
                                </div>
                                <div class="col-md-3">
                                    <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.LNM" />
                                </div>*@
                        </div><br />
                    </div>
                </div>
                <div class="row" ng-show="FULL_MODEL.TABEAN_RENEW.lcntpcd == 'นสม'">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อผู้รับอนุญาตนำเข้า
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.licen" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อสถานที่นำเข้า
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.thanm" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                กรณีนิติบุคคล ระบุชื่อผู้ดำเนินกิจการ
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.grannm_lo" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                ใบอนุญาตผลิตเลขที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.lcnno_display_new" readonly />
                            </div>
                        </div><br />
                        <div class="form-group row">
                            <label for="colFormLabel" class="col-sm-3 col-form-label"></label>
                            <div class="col-sm-3">
                                <input type="tel" class="form-control" id="colFormLabel" placeholder="ตัวอย่าง HB 10-1-65-99" aria-describedby="SearchHelp" ng-model="TABEAN_RENEW.LCNNO_NEW">
                                <small id="SearchHelp" class="form-text text-muted">*กรณีข้อมูลสถานที่ไม่อัพเดท ให้ท่านกรอกข้อมูลเลขที่ใบอนุญาตแล้วกดปุ่ม"ค้นหา"เพื่อทำการดึงข้อมูลใหม่.</small>
                            </div>
                            <div class="col-md-3">
                                <button type="submit" class="btn btn-primary" ng-click="BTN_SEARCH_LCN_CLICK()">ค้นหา</button>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ที่ตั้งสถานที่นำเข้า อยู่เลขที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_LICEN_HERB.thanm" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                ตรอก/ซอย
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thasoi" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ถนน
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.tharoad" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                หมู่ที่
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thamu" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ตำบล/แขวง
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thathmblnm" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                อำเภอ/เขต
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thaamphrnm" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                จังหวัด
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.thachngwtnm" readonly placeholder="-"/>
                            </div>
                            <div class="col-md-3">
                                รหัสไปรษณีย์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.zipcode" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                โทรศัพท์
                            </div>
                            <div class="col-md-3">
                                <input class="form-control" ng-model="XML_SEARCH_DRUG_LCN_HERB.tel" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ชื่อผู้ผลิตต่างประเทศ
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.engfrgnnm" readonly placeholder="-"/>
                            </div>
                        </div><br />
                        <div class="row">
                            <div class="col-md-3">
                                ที่ตั้งสถานที่ผลิต
                            </div>
                            <div class="col-md-9">
                                <input class="form-control" ng-model="XML_DRUG_PRODUCT_HERB.engfrgnnm_addr" readonly placeholder="-"/>
                            </div>
                        </div><br />
                    </div>
                </div>
            </div>
        </blockquote>
    </div>
</div>