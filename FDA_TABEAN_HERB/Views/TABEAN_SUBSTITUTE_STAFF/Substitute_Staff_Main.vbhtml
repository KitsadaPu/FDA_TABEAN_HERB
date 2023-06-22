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
<div ng-controller="Substitute_Staff_CTRL">
    <div class="row">
        <div class="col-md-12" style="text-align:center">
            <h3>คำขอใบแทนใบสำคัญผลิตภัณฑ์สมุนไพร</h3>
        </div>
    </div>

    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>
    <div class="table-responsive">
        <table class="table table-striped table-bordered  dataTables-example">
            <thead>
                <tr>
                    <th hidden="hidden">IDA</th>
                    <th>ลำดับ</th>
                    <th>เลขที่ใบอนุญาตใหม่</th>
                    <th>เลขดำเนินการ</th>
                    <th>เลขรับคำขอ</th>
                    <th>เลขที่ทะเบียน</th>
                    <th>เหตุผลการขอแก้ไขใบอนุญาต</th>
                    <th>สถานะใบอนุญาต</th>
                    <th>รายละเอียด</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="x in FULL_MODEL.Substitute_Tabean_Staff">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td hidden="hidden">{{x.STATUS_ID}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.PURPOSE}} </td>
                    <td>{{x.STATUS_NAME}} </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" data-toggle="modal" data-backdrop="false" data-target="#SubstituteTabeanStaff_Modal" ng-click="BTN_SUBDEATAIL_STAFF_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.IDA_DR,x.STATUS_NAME,x.Newcode)" style="color:#0033CC;">ดูรายละเอียด</a>
                    </td>
                    @*<td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" ng-click="BTN_STAFF_DETAIL_EDIT_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID,x.datas)" style="color:#0033CC;">ดูรายละเอียดการแก้ไข</a>
                    </td>*@
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
 
    <div class="modal fade" id="SubstituteTabeanStaff_Modal" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
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
                @*<div class="modal-footer" ng-if="SET_MAIN_POPUP_PAGE == '../LCN_EDIT/LCN_EDIT_CONFIRM_DETAIL'">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary" data-dismiss="modal" ng-click="BTN_SAVE_DATA_DETAIL_CONFIRM()">Save</button>
                </div>*@
            </div>
        </div>
    </div>
    <footer class="footer1">
        <div class="inner">
            <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</div>

