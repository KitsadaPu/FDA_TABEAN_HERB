<style type="text/css">
    .auto-style7 {
        width: 314px;
    }

    .auto-style8 {
        width: 369px;
    }

    .footer1 {
        background: #7793F5;
        color: #fff;
        padding: 10px;
        margin-top: 30px;
        font-size: 0.9em;
    }

    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        text-align: left;
        padding: 8px;
    }

    th {
        background-color: #4CAF50;
        color: white;
    }
</style>
<div ng-controller="Tabean_Renew_Staff">
    <div class="row">
        <div class="col-lg-12" style="text-align:center">
            <h3>คำขอต่ออายุทะเบียน</h3>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="form-group col-md-6" style="padding-left:2em">
            <label for="inlineFormAmphrKeepSelect">เลือกประเภทผลิตภัณฑ์:</label>
            <select class="custom-select mr-sm-2" id="inlineFormAmphrKeepSelect" ng-model="FULL_MODEL.PROCESS_ID" ng-change="Chooses_Tabean()">
                <option value="" disabled selected>กรุณาเลือก...</option>
                <option value="20710" ng-selected="FULL_MODEL.PROCESS_ID == '20710'">การขอต่ออายุใบสำคัญการขึ้นทะเบียนผลิตภัณฑ์สมุนไพร</option>
                <option value="20720" ng-selected="FULL_MODEL.PROCESS_ID == '20720'" disabled>การขอต่ออายุใบรับแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
                <option value="20730" ng-selected="FULL_MODEL.PROCESS_ID == '20730'">การขอต่ออายุใบรับจดแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
            </select>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="table-responsive">
        <table class="table table-striped table-bordered table-hover dataTables-example">
            <thead>
                <tr>
                    <th hidden="hidden">IDA</th>
                    <th>ลำดับ</th>
                    <th>เลขดำเนินการ</th>
                    <th>เลขที่ทะเบียน</th>
                    <th>เลขที่ใบอนุญาต</th>
                    <th>เลขที่รับคำขอ</th>
                    <th>ชื่อยา</th>
                    <th>สถานะทะเบียน</th>
                    <th>รายละเอียด</th>
                    @*<th>ดูรายละเอียดการแก้ไข</th>*@
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="x in FULL_MODEL.Renew_Tabean_Staff">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.DRUG_NAME}} </td>
                    <td> {{x.STATUS_NAME}}</td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" data-toggle="modal" data-backdrop="false" data-target="#RenewTabeanStaff_Modal" ng-click="BTN_TABEAN_RENEW_STAFF_DETAIL_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.IDA_DR,x.STATUS_NAME)" style="color:#0033CC;">เลือกรายการ</a>
                    </td>
                </tr>
            </tbody>
            <tfoot></tfoot>
        </table>
    </div>
    <div class="modal fade" id="RenewTabeanStaff_Modal" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="TitleLabel">-</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div ng-include="SET_MAIN_POPUP_PAGE" style="padding-left:5px;">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

