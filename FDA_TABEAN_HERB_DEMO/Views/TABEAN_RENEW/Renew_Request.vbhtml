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
<div ng-controller="Tabean_Renew_Request">
    <div class="row">
        <div class="col-lg-12" style="text-align:center">
            <h3>คำขอต่ออายุใบสำคัญ</h3>
        </div>
    </div>

    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="row" style="padding-left:2em">
        <div class="col-md-6" style="text-align:left">

        </div>
        <div class="col-md-6" style="text-align:right">
            <button type="button" style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-warning" ng-click="BTN_BACK_PAGE_CLICK('../TABEAN_RENEW/Renew_Main')">ย้อนกลับ</button>
            @*<input type="button"  style="Height: 47px;Width: 250px; background-color: #1ab394;border-radius:3px" value="สร้างคำขอใหม่" ng-click="cer_add_lcn_click('../CER_HERB/CER_LCN_ADD', 'active', $index+1)" />*@
            <input type="button" style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-primary" value="สร้างคำขอใหม่" ng-click="BTN_RENEW_ADD_CLICK()" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fas fa-search"></i></span>
                </div>
                <input type="text" class="form-control" id="searchInput" ng-model="search.$" placeholder="ระบุข้อมูลที่ต้องการค้นหา...">
            </div>
        </div>
    </div>
    <div class="table-responsive">
        <table class="table table-striped table-bordered table-hover">
            <thead>
                <tr>
                    <th hidden="hidden">IDA</th>
                    <th>ลำดับ</th>
                    <th>เลขดำเนินการ</th>
                    <th>เลขที่รับคำขอ</th>
                    <th>เลขที่ทะเบียน</th>
                    <th>ชื่อยา</th>
                    <th>สถานะคำขอ</th>
                    <th>รายละเอียด</th>
                    @*<th>ดูรายละเอียดการแก้ไข</th>*@
                </tr>
            </thead>
            <tbody>
                <tr  ng-if="Renew_Tabean.length===0">
                    <td colspan="7" class="text-center text-base-danger">--- ไม่มีคำขอในระบบ ---</td>
                </tr>
                <tr dir-paginate="x in filteredData = (Renew_Tabean | filter:search ) | itemsPerPage: 15">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td hidden="hidden">{{x.STATUS_ID}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.DRUG_NAME}} </td>
                    <td>{{x.STATUS_NAME}} </td>
                    <td style="color:#0033CC;">
                        <a href="#" data-toggle="modal" data-backdrop="false" ng-hide="x.STATUS_ID == 18||x.STATUS_ID == 22" data-target="#Renew_modal" ng-click="BTN_RENEW_DETAIL_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.FK_IDA,x.STATUS_NAME,x.T_Request_ID)" style="color:#0033CC;">รายละเอียด</a>
                        <a href="#" data-toggle="modal" data-backdrop="false" ng-show="x.STATUS_ID == 18||x.STATUS_ID == 22" data-target="#Renew_modal" ng-click="BTN_RENEW_EDIT_FILE_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.FK_IDA,x.STATUS_NAME,x.T_Request_ID)" style="color:#0033CC;">แก้ไขเอกสารแนบ</a>
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
    <div class="row">
        <div class="col-md-12" style="text-align:right">
            <a href="#" ng-click="BTN_PAYMENT_CLICK()" style="color:#0033CC;"><i class="bi bi-wallet2"></i>  ออกใบสั่งชำระ </a>
            @*<button type="button" ng-click="BTN_PAYMENT_CLICK()"  style="color:#fff;">ใบสั่งชำระ</button>*@
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="col-lg-12" style="color:red;">
                <p> ๑. ทะเบียนผลิตภัณฑ์สมุนไพรที่ปรากฎขึ้น จะปรากฎขึ้นเฉพาะทะเบียนผลิตภัณฑ์ที่อยู่ในช่วงเวลาที่สามารถยื่นคำขอต่ออายุได้เท่านั้น </p>
                <br /> <p>
                    ๒. ในกรณีที่การยื่นคำขอของท่าน เป็นการยื่นคำขอภายในช่วงเวลา 1 เดือน หลังจากวันที่ใบสำคัญสิ้นอายุ ท่านจะต้องชำระค่าธรรมเนียมการต่ออายุล่าช้าตามที่กฎหมายกำหนด
                </p> <br />
                <p> ๓. หากท่านทีทะเบียนที่อยู่ในช่วงเวลาที่ต้องยื่นคำขอ แต่ท่านไม่พบคำขอดังกล่าว ขอให้ท่านติดต่อ ปรดติดต่อกองผลิตภัณฑ์สมุนไพร สำนักงานคณะกรรมการอาหารและยา โทร 02-5907000 ต่อ 71503 เพื่อสอบถาม </p> <br />
                <p> ๔.หากไม่สามารถดูรายละเอียดได้โปรดตั้งค่า Browser ให้อนุญาตการใช้ ป๊อปอัพ/pop up" </p> <br />
                <p> ๕.แนะนำให้ใช้ Firefox, Chrome และ Microsoft edge" </p>
            </div>
        </div>
    </div>
    <footer class="modal-footer">
        <div class="inner">
            <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
        </div>
    </footer>
    @*<div class="modal-dialog modal-xl fade" id="Renew_modal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="exampleModalLabel">รายละเอียดคำขอ ต่ออายุผลิตภัณฆ์สมุนไพร</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div ng-include="SET_MAIN_POPUP_PAGE" style="padding-left:5px;"></div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Save changes</button>
                    </div>
                </div>
            </div>
        </div>*@
    <div class="modal fade" id="Renew_modal" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
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
                <div class="modal-footer" ng-show="SET_MAIN_POPUP_PAGE == '../TABEAN_RENEW/Renew_Upload_file'|| SET_MAIN_POPUP_PAGE == '../TABEAN_RENEW/Renew_Confirm_Detail'|| SET_MAIN_POPUP_PAGE == '../TABEAN_RENEW/Renew_Edit_File'">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary" ng-click="BTN_SAVE_DATA_RENEW_CLICK(SET_MAIN_POPUP_PAGE)">Save</button>
                </div>
            </div>
        </div>
    </div>
</div>

