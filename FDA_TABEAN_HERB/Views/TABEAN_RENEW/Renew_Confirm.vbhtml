<form>
    <div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1000px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">
            <div ng-show="(FULL_MODEL.STATUS_ID == 1)" style="text-align:center;">
                <input type="button" class="btn btn-success" name="abortrequest" id="abortrequest" style="Height:45px; Width:90%" ng-click="BTN_CONFIRM_CLICK()" value="ยื่นคำขอ" />
            </div>
            <div style="height: 15px;"></div>
            <div ng-show="(FULL_MODEL.STATUS_ID == 1)" style="text-align:center;">
                <input type="button" class="btn btn-warning" name="abortrequest" id="abortrequest" style="Height: 45px; Width: 90% " ng-click="BTN_EDIT_FILE_CONFIM_CLICK()" value="แก้ไขเอกสารแนบ" />
            </div>
            <div style="height: 15px;"></div>
            <div ng-show="!(FULL_MODEL.STATUS_ID == 2 || FULL_MODEL.STATUS_ID == 77)" style="text-align:center;">
                <input type="button" class="btn btn-danger" name="abortrequest" id="abortrequest" style="Height: 45px; Width: 90% " ng-click="BTN_CENCLE_CLICK(IDA)" value="ยกเลิกคำขอ" />
            </div>
            <div style="height: 15px;"></div>
            <div style="text-align:center;">
                <input type="button" name="exitpage" id="exitpage" class="btn btn-warning" style="Height: 45px; Width: 90% " data-dismiss="modal" value="ออกจากหน้านี้" ng-click="exitpage()" />
            </div>
            <div style="height: 15px;"></div>
            <div class="form-group" ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0">
                <h4 for="tb_msa_cuia_staff" ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0">เอกสารแนบ</h4>
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
                                </td>
                            </tr>
                        </tbody>
                        <tfoot></tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</form>