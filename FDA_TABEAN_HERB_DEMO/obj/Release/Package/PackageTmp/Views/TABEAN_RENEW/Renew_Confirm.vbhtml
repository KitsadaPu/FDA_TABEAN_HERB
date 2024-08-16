<form onsubmit="return validateForm()">
    <div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1000px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">
            <div class="card">
                <div class="card-header">
                    <ul class="nav nav-tabs card-header-tabs">
                        <li class="nav-item" role="presentation">
                            <button class="nav-link active" id="home-tab" data-toggle="tab" data-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true" ng-click="SELECT_PAGR(1)">รายละเอียดเพิ่มเติม</button>
                        </li>
                        @*<li class="nav-item" role="presentation">
                                <button class="nav-link" id="profile-tab" data-toggle="tab" data-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false" ng-click="SELECT_PAGR(2)">ประวัติ</button>
                            </li>*@
                    </ul>
                </div>
                <div class="card-body tab-content">
                    <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab" @*ng-show="Page == 1"*@>
                        <div class="form-group" ng-if="FULL_MODEL.STATUS_ID >= 1">
                            <strong><label for="StatusStaff" style="text-align:left">สถานะคำขอ:</label></strong>
                            <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.STATUS_NAME" readonly>
                        </div>
                        <div class="form-group" ng-if="FULL_MODEL.STATUS_ID >= 1">
                            <strong><label for="StatusStaff" style="text-align:left">เลขดำเนินการ:</label></strong>
                            <input type="text" class="form-control" id="StatusStaff" ng-model="FULL_MODEL.TR_ID" readonly>
                        </div>
                        <div class="form-group" ng-if="FULL_MODEL.STATUS_ID >= 1">
                            <strong><label for="StatusStaff" style="text-align:left">ประเภททะเบียน:</label></strong><i style="color:red" ng-show="FULL_MODEL.STATUS_ID == 1||FULL_MODEL.STATUS_ID == 2">*</i>
                            <select class="form-control" ng-model="FULL_MODEL.TABEAN_RENEW.T_Resuest_ID" aria-describedby="DateConHelp" ng-disabled="FULL_MODEL.STATUS_ID >= 2">
                                <option value="" disabled ng-if="FULL_MODEL.TABEAN_RENEW.T_Resuest_ID == undefined">กรุณาเลือก...</option>
                                <option ng-repeat="x in FULL_MODEL.ddl_Type_Tabean" ng-value="{{x.Sub_Process}}" ng-selected>{{x.Process_Descrip}}</option>
                            </select>
                            <small id="DateConHelp" class="form-text text-muted">กรุณาเลือกประเภททะเบียนของท่านก่อนยื่นคำขอ.</small>
                        </div>
                        <div class="needs-validation" novalidate>
                            <h4 style="color:red" ng-show="FULL_MODEL.STATUS_ID == 1||FULL_MODEL.STATUS_ID == 2">กรุณากรอกข้อมูล รายละเอียดประกอบการนัดหมาย</h4>
                            <div class="form-group">
                                <label for="validationTxt_name_appoinment" class="col-form-label">ชื่อผู้ติดต่อ:</label><i style="color:red" ng-show="FULL_MODEL.STATUS_ID == 1||FULL_MODEL.STATUS_ID == 2">*</i>
                                <input type="text" class="form-control" id="validationTxt_name_appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Contact" ng-readonly="FULL_MODEL.STATUS_ID >= 2">
                                <div class="invalid-feedback">
                                    กรุณากรอกข้อมูล ชื่อผู้ติดต่อ.
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="validationTxt_email_Appoinment" class="col-form-label">E-mail:</label><i style="color:red" ng-show="FULL_MODEL.STATUS_ID == 1||FULL_MODEL.STATUS_ID == 2">*</i>
                                <input type="email" class="form-control" id="validationTxt_email_Appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Email" ng-readonly="FULL_MODEL.STATUS_ID >= 2">
                                <div class="invalid-feedback">
                                    กรุณากรอกข้อมูล E-mail.
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="validationtxt_Phone_Appoinment" class="col-form-label">หมายเลขโทรศัพท์ติดต่อกลับ:</label><i style="color:red" ng-show="FULL_MODEL.STATUS_ID == 1||FULL_MODEL.STATUS_ID == 2">*</i>
                                <input type="tel" class="form-control" id="validationtxt_Phone_Appoinment" ng-model="FULL_MODEL.TABEAN_RENEW.Appoinment_Phone" ng-readonly="FULL_MODEL.STATUS_ID >= 2">
                                <div class="invalid-feedback">
                                    กรุณากรอกข้อมูล หมายเลขโทรศัพท์ติดต่อกลับ.
                                </div>
                            </div>

                            @*<h4>ส่วนลดค่าคำขอ(ถ้ามี)</h4>
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
                                </div>*@
                        </div>
                        <div ng-show="(FULL_MODEL.STATUS_ID == 1)" style="text-align:center;">
                            <input type="submit" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:45px; Width:90%" ng-click="BTN_CONFIRM_CLICK()" value="ยื่นคำขอ" />
                        </div>
                        <div style="height: 15px;"></div>
                        <div ng-show="(FULL_MODEL.STATUS_ID == 1)" style="text-align:center;">
                            <input type="button" class="btn btn-warning" name="abortrequest" id="abortrequest" style="Height: 45px; Width: 90% " ng-click="BTN_EDIT_FILE_CONFIM_CLICK()" value="แก้ไขเอกสารแนบ" />
                        </div>
                        <div style="height: 5px;"></div>
                        <div ng-show="( FULL_MODEL.STATUS_ID == 8)" style="text-align:center;">
                            <input type="button" class="btn btn-info" name="abortrequest" id="abortrequest" style="Height:45px; Width:90%" ng-click="BTN_PREVIEW_TABEAN_CLICK()" value="PREVIEW ใบสำคัญ" />
                        </div>
                        <div style="height: 15px;"></div>
                        <div ng-show="!(FULL_MODEL.STATUS_ID == 2 || FULL_MODEL.STATUS_ID == 8 || FULL_MODEL.STATUS_ID == 77)" style="text-align:center;">
                            <input type="button" class="btn btn-danger" name="abortrequest" id="abortrequest" style="Height: 45px; Width: 90% " ng-click="BTN_CENCLE_CLICK(IDA)" value="ยกเลิกคำขอ" />
                        </div>
                        <div style="height: 15px;"></div>
                        <div style="text-align:center;">
                            <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height: 45px; Width: 90% " data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
                        </div>
                    </div>
                </div>
            </div>

            <div style="height: 15px;"></div>
            <div class="card border-dark mb-3" ng-if="FULL_MODEL.FILE_ATTACH != null">
                <div class="card-header text-monospace" id="AAN" aria-describedby="AANConHelp">เอกสารแนบ</div>
                <small id="AANConHelp" class="form-text text-muted" style="padding-left:2em"><span class="dot"></span> เอกสารที่ส่งแก้ไข</small>
                <div class="card-body text-dark">
                    <div class="table-responsive">
                        <table ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0" class="table-striped" id="tb_msa_cuia_staff">
                            <thead>
                                <tr>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH" style="font-size:12px">
                                    <td hidden="hidden">{{x.IDA}} </td>
                                    <td>{{x.index}} </td>
                                    <td>{{x.Document_Name}} </td>
                                    <td style="color:green">{{x.NAME_REAL}} </td>
                                    <td>
                                        <a href="#" ng-click="show_attach_preview(x.IDA)" style="color:#0033CC;">ดูข้อมูล</a>
                                    </td>
                                </tr>
                            </tbody>
                            <tfoot></tfoot>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>