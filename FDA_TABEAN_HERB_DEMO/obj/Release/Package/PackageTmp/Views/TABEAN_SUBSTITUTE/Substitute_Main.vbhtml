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
<div ng-controller="Substitute_Add_CTRL">
    <div class="row">
        <div class="col-lg-12" style="text-align:center">
            <h3>คำขอใบแทนใบสำคัญผลิตภัณฑ์สมุนไพร</h3>
        </div>
    </div>

    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="row" style="padding-left:2em">
        <div class="col-md-6" style="text-align:left">
            @*<button type="button" class="btn btn-outline-warning"  ng-click="BTN_BACK_PAGE_CLICK('../TABEAN_SUBSTITUTE/Substitute_Choose_Tabean')">ย้อนกลับ</button>*@
        </div>
        <div class="col-md-6" style="text-align:right">
            <button type="button" style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-warning" ng-click="BTN_BACK_PAGE_CLICK('../TABEAN_SUBSTITUTE/Substitute_Choose_Tabean')">ย้อนกลับ</button>
            @*<input type="button"  style="Height: 47px;Width: 250px; background-color: #1ab394;border-radius:3px" value="สร้างคำขอใหม่" ng-click="cer_add_lcn_click('../CER_HERB/CER_LCN_ADD', 'active', $index+1)" />*@
            <input type="button" style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-primary" value="สร้างคำขอใหม่" data-toggle="modal" data-backdrop="false" data-target="#Substitute_modal" ng-click="BTN_SUBSTITUTE_ADD_CLICK('../TABEAN_SUBSTITUTE/Substitute_Add')" />
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
                    <th>เลขที่รับคำขอ</th>
                    <th>เลขที่ทะเบียน</th>
                    <th>ชื่อยา</th>
                    <th>สถานะคำขอ</th>
                    <th>รายละเอียด</th>
                    @*<th>ดูรายละเอียดการแก้ไข</th>*@
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="x in FULL_MODEL.Substitute_Tabean">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td hidden="hidden">{{x.STATUS_ID}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.NAME_THAI}} </td>
                    <td>{{x.STATUS_NAME}} </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        @*<input type="button" value="รายละเอียด" data-toggle="modal" data-target="#LCN_EDIT_DETAIL_MODAL" ng-click="BTN_LCN_EDIT_CONFIRM_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID,x.datas)">*@
                        <a href="#" data-toggle="modal" data-backdrop="false" data-target="#Substitute_modal" ng-click="BTN_SUBSTITUTE_DETAIL_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.datas)" style="color:#0033CC;">รายละเอียด</a>
                    </td>
                    @*<td style="color:#0033CC;text-decoration:underline;">
            <a href="#" ng-click="BTN_STAFF_DETAIL_EDIT_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN_IDA, x.TR_ID,x.datas)" style="color:#0033CC;">ดูรายละเอียดการแก้ไข</a>
        </td>*@
                </tr>
            </tbody>
            <tfoot></tfoot>
        </table>
    </div>


    <div class="row">
        <div class="col-lg-12">
            <div class="col-lg-12" style="color:red;">
                <p> หมายเหตุ : 1. ใช้เป็นข้อมูลเพื่อการตรวจสอบเบื้องต้น หากประสงค์ใช้ประโยชน์เพื่อการอ้างอิง หรือดำเนินการทางกฎหมาย โปรดติดต่อกองผลิตภัณฑ์สมุนไพร สำนักงานคณะกรรมการอาหารและยา โทร 02-5907000 ต่อ 71503 " </p>
                <br /> <p>
                    2.กรณีสืบค้น โดยใช้อุปกรณ์ที่เป็น android หรือ ios อาจไม่สามารถดูรายละเอียดได้
                    แนะนำให้สืบค้นโดยใช้เครื่องคอมพิวเตอร์ชนิดตั้งโต๊ะ หากยังไม่สามารถสืบค้นได้โปรด จับภาพหน้าจอ และแจ้งปัญหาไปยัง Drug-SmartHelp@fda.moph.go.th"
                </p> <br />
                <p> 3.หากไม่สามารถดูรายละเอียดได้โปรดตั้งค่า Browser ให้อนุญาตการใช้ ป๊อปอัพ/pop up" </p> <br />
                <p> 4.แนะนำให้ใช้ Firefox, Chrome และ Microsoft edge" </p>
            </div>
        </div>
    </div>

    <div class="modal fade" id="Substitute_modal" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
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
                <div class="modal-footer" ng-if="SET_MAIN_POPUP_PAGE == '../TABEAN_SUBSTITUTE/Substitute_Add'||'../TABEAN_SUBSTITUTE/Substitute_Confirm_Detail'">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary" ng-click="BTN_SAVE_DATA_SUBSTITUTE_CLICK(SET_MAIN_POPUP_PAGE)">Save</button>
                </div>
            </div>
        </div>
    </div>

    <footer class="modal-footer">
        <div class="inner">
            <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</div>

