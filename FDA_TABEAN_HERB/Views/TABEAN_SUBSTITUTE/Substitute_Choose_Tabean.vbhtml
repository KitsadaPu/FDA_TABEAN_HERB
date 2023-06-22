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
<div ng-controller="Substitute_CTRL">
    <div class="row">
        <div class="col-lg-12" style="text-align:center">
            <h3>กรุณาเลือกทะเบียนเพื่อทำรายการต่อ</h3>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="form-group col-md-6" style="padding-left:2em">
            <label for="inlineFormAmphrKeepSelect">เลือกประเภทผลิตภัณฑ์:</label>
            <select class="custom-select mr-sm-2" id="inlineFormAmphrKeepSelect" ng-model="FULL_MODEL.PROCESS_ID" ng-change="Chooses_Tabean()">
                <option value="" disabled >กรุณาเลือก...</option>
                <option value="20610" ng-selected="FULL_MODEL.PROCESS_ID == '20610'" selected>คำขอใบแทนใบสำคัญการขึ้นทะเบียนผลิตภัณฑ์สมุนไพร</option>
                <option value="20620" ng-selected="FULL_MODEL.PROCESS_ID == '20620'" disabled>คำขอใบแทนใบรับแจ้งรายละเอียดผลิตภัณฑ์สมุนไพร</option>
                <option value="20630" ng-selected="FULL_MODEL.PROCESS_ID == '20630'" >คำขอใบแทนใบรับจดแจ้งผลิตภัณฑ์สมุนไพร</option>
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
                <tr ng-repeat="x in FULL_MODEL.Tabean_Herb">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.tr_id}} </td>
                    <td>{{x.RGTNO_DISPLAY}} </td>
                    <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                    <td>{{x.RCVNO_FULL}} </td>
                    <td>{{x.thadrgnm}} </td>
                    <td> </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" ng-click="BTN_CHOOSE_TABEAN_CLICK('../TABEAN_SUBSTITUTE/Substitute_Main',x.IDA, x.CITIZEN_ID_AUTHORIZE,x.thadrgnm,x.engdrgnm,x.RGTNO_DISPLAY,x.Newcode,x.STATUS_LCN, x)" style="color:#0033CC;">เลือกรายการ</a>
                    </td>
                </tr>
            </tbody>
            <tfoot></tfoot>
        </table>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="col-lg-12" style="color:red;">
                <p> หมายเหตุ : 1. ใช้เป็นข้อมูลเพื่อการตรวจสอบเบื้องต้น หากประสงค์ใช้ประโยชน์เพื่อการอ้างอิง หรือดำเนินการทางกฎหมาย โปรดติดต่อสำนักยา สำนักงานคณะกรรมการอาหารและยา" </p>
                <br /> <p>
                    2.กรณีสืบค้น โดยใช้อุปกรณ์ที่เป็น android หรือ ios อาจไม่สามารถดูรายละเอียดได้
                    แนะนำให้สืบค้นโดยใช้เครื่องคอมพิวเตอร์ชนิดตั้งโต๊ะ หากยังไม่สามารถสืบค้นได้โปรด จับภาพหน้าจอ และแจ้งปัญหาไปยัง Drug-SmartHelp@fda.moph.go.th"
                </p> <br />
                <p> 3.หากไม่สามารถดูรายละเอียดได้โปรดตั้งค่า Browser ให้อนุญาตการใช้ ป๊อปอัพ/pop up" </p> <br />
                <p> 4.แนะนำให้ใช้ Firefox, Chrome และ Microsoft edge" </p>
            </div>
        </div>
    </div>
    <footer class="modal-footer">
        <div class="inner">
            <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</div>

