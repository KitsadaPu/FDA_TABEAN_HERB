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
        /*cursor: pointer;*/
    }
/*    .export-icon {
        position: absolute;
        right: 1em;
        top: 0;
    }*/
</style>
<div ng-controller="Tabean_Renew_Staff">
    <div class="row">
        <div class="col-lg-12" style="text-align:left">
            <h2>คำขอต่ออายุผลิตภัณฑ์</h2>
        </div>
    </div>
    <div class="row">
        <div class="form-group col-md-4">
            <label for="inlineFormAmphrKeepSelect">เลือกประเภทผลิตภัณฑ์:</label>
            <select class="custom-select mr-sm-2 custom-select-sm" id="inlineFormAmphrKeepSelect" ng-model="FULL_MODEL.PROCESS_ID" ng-change="Chooses_Tabean()">
                <option value="" selected>ทั้งหมด</option>
                <option value="20710" ng-selected="FULL_MODEL.PROCESS_ID == '20710'">การขอต่ออายุใบสำคัญการขึ้นทะเบียนผลิตภัณฑ์สมุนไพร</option>
                <option value="20720" ng-selected="FULL_MODEL.PROCESS_ID == '20720'" disabled>การขอต่ออายุใบรับแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
                <option value="20730" ng-selected="FULL_MODEL.PROCESS_ID == '20730'">การขอต่ออายุใบรับจดแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
            </select>
        </div>
        <div class="form-group col-md-4">
            <label for="yearSelect">ปีที่ยื่นคำขอ:</label>
            <select class="custom-select mr-sm-2 custom-select-sm" id="yearSelect" ng-model="selectedYear">
                <option value="" selected>ทั้งหมด...</option>
                <option ng-repeat="year in years" value="{{year + 543}}">{{year + 543}}</option>
            </select>
        </div>
        <div class="form-group col-md-4">
            <label for="statusSelect">สถานะคำขอ:</label>
            <select class="custom-select custom-select-sm" id="statusSelect" ng-model="statusFilter">
                <option value="">ทั้งหมด</option>
                <option ng-repeat="status in ddl_status" value="{{status.STATUS_ID}}">{{status.STATUS_NAME_STAFF}}</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fas fa-search"></i></span>
                </div>
                <input type="text" class="form-control" id="searchInput" ng-model="search.$" placeholder="ระบุข้อมูลที่ต้องการค้นหา...">
                <button class="export-button" ng-click="exportData()" data-toggle="tooltip" data-placement="top" title="Export to Excel" style="border:none"> 
                    <img src="~/imgs/excel.png" alt="Export to Excel" width="30" height="30">
                </button>
            </div>
        </div>
    </div>
    <div class="table-responsive">
        <table class="table table-striped table-bordered table-hover">
            <thead>
                <tr>
                    <th hidden="hidden">IDA</th>
                    <th ng-click="sortColumn('index')">ลำดับ</th>
                    <th ng-click="sortColumn('TR_ID')">เลขดำเนินการ</th>
                    <th ng-click="sortColumn('RGTNO_FULL')">เลขที่ทะเบียน</th>
                    <th ng-click="sortColumn('LCNNO_DISPLAY_NEW')">เลขที่ใบอนุญาต</th>
                    <th ng-click="sortColumn('RCVNO_NEW')">เลขที่รับคำขอ</th>
                    <th ng-click="sortColumn('DRUG_NAME')">ชื่อยา</th>
                    <th ng-click="sortColumn('STATUS_NAME')">สถานะคำขอ</th>
                    <th ng-click="sortColumn('DATE_CONFIRM_TH')">วันที่ยื่นคำขอ</th>
                    <th ng-click="sortColumn('rcv_StaffName')">เจ้าหน้าที่รับเรื่อง</th>
                    <th>รายละเอียด</th>
                </tr>
            </thead>
            <tbody>
                @*<tr ng-repeat="x in FULL_MODEL.Renew_Tabean_Staff | orderBy:'-TR_ID'">*@
                <tr dir-paginate="x in filteredData = (FULL_MODEL.Renew_Tabean_Staff | orderBy:'-TR_ID' | filter:search |filter:{PROCESS_ID: FULL_MODEL.PROCESS_ID} | filter:{STATUS_ID: statusFilter} | filter:yearFilterFunction) | itemsPerPage: 20">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.DRUG_NAME}} </td>
                    <td> {{x.STATUS_NAME}}</td>
                    <td>{{x.DATE_CONFIRM_TH}} </td>
                    <td>{{x.rcv_StaffName}} </td>
                    <td style="color:#0033CC;">
                        <a href="#" data-toggle="modal" data-backdrop="false" data-target="#RenewTabeanStaff_Modal" ng-click="BTN_TABEAN_RENEW_STAFF_DETAIL_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.IDA_DR,x.STATUS_NAME,x.Newcode_U)" style="color:#0033CC;">เลือกรายการ</a>
                    </td>
                </tr>
            </tbody>
            <tfoot></tfoot>
        </table>
        <div class="row">
            <div class="col-md-6">
                <dir-pagination-controls class="pagination" max-size="7" direction-links="true" boundary-links="true"></dir-pagination-controls>
            </div>
            <div class="col-md-6 text-right">
                <p>จำนวนรายการที่กรอง: {{filteredData.length}} รายการ</p>
            </div>
        </div>
    </div>
    <div class="modal fade" id="RenewTabeanStaff_Modal" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="TitleLabel">-</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close" ng-click="exitpage()">
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


