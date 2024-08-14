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
<div ng-controller="Tabean_Renew_Main">
    <div class="row">
        <div class="col-lg-12" style="text-align:center">
            <h3>กรุณาเลือกประเภทผลิตภัณฑ์เพื่อทำรายการต่ออายุผลิตภัณฑ์สมุนไพร</h3>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="form-group col-md-6" style="padding-left:2em">
            <label for="inlineFormAmphrKeepSelect">เลือกประเภทผลิตภัณฑ์:</label>
            <select class="custom-select mr-sm-2" id="inlineFormAmphrKeepSelect" ng-model="PROCESS_ID" ng-change="Chooses_Tabean()">
                <option value="" disabled selected>กรุณาเลือก...</option>
                <option value="20710" >การขอต่ออายุใบสำคัญการขึ้นทะเบียนผลิตภัณฑ์สมุนไพร</option>
                <option value="20720"  disabled>การขอต่ออายุใบรับแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
                <option value="20730" >การขอต่ออายุใบรับจดแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12" style="color:red">
            <h3>*โปรดเลือกทะเบียนเพื่อทำรายการต่อ</h3>
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
                    @*<th>เลขดำเนินการ</th>*@
                    <th>เลขที่ทะเบียน</th>
                    <th>ชื่อผลิตภัณฑ์</th>
                    <th>เลขที่ใบอนุญาต</th>
                    @*<th>เลขที่รับคำขอ</th>*@
                    <th>สถานะทะเบียน</th>
                    <th>วันที่หมดอายุ</th>
                    <th>รายละเอียด</th>
                    @*<th>ดูรายละเอียดการแก้ไข</th>*@
                </tr>
            </thead>
            <tbody>
                <tr ng-if="Tabean_Herb.length===0">
                    <td colspan="8" class="text-center text-base-danger">--- ไม่มีคำขอในระบบ ---</td>
                </tr>
                <tr dir-paginate="x in filteredData = (Tabean_Herb |filter:search)  | itemsPerPage: 20">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td>{{x.index}} </td>
                    @*<td>{{x.tr_id}} </td>*@
                    <td>{{x.RGTNO_DISPLAY}} </td>
                    <td>{{x.thadrgnm}} </td>
                    <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                    @*<td>{{x.RCVNO_FULL}} </td>*@
                    <td> {{x.cncnm}}</td>
                    @*<td> {{x.expdate}}</td>*@
                    <td> {{x.expdate_TH}}</td>
                    <td style="color:#0033CC;">
                        <a href="#" ng-click="BTN_CHOOSE_TABEAN_CLICK('../TABEAN_RENEW/Renew_Request', x.IDA, x.CITIZEN_ID_AUTHORIZE, x.thadrgnm, x.engdrgnm, x.RGTNO_DISPLAY, x.Newcode, x.STATUS_LCN, x)"
                           ng-if="x.days_from_today <= 90 && x.expdate_status == 'ไม่เกิน'" style="color:#0033CC;" aria-describedby="SelectHelpBlock">เลือกรายการ</a>
                        <small id="SelectHelpBlock" class="form-text text-danger" ng-show="x.days_from_today < 0 && x.expdate_status == 'ไม่เกิน'">ยื่นคำขอได้ไม่เกิน {{x.expdate_after}}</small>
                        <a style="color:gray" ng-show="x.days_from_today > 90">ยังไม่สามารถยื่นคำขอได้</a>
                        <a style="color:gray" ng-show="x.days_from_today < 0 && x.expdate_status == 'เกิน'">ไม่สามารถยื่นคำขอได้</a>
                        <small id="SelectHelpBlock" class="form-text text-danger" ng-show="x.days_from_today < 0 && x.expdate_status == 'เกิน'">เนื่องจากคำขอเกินระยะเวลาในการยื่นคำขอแล้ว</small>
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
</div>

