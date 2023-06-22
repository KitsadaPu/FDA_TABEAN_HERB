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
            <button type="button"  style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-warning" ng-click="BTN_BACK_PAGE_CLICK('../TABEAN_RENEW/Renew_Main')">ย้อนกลับ</button>
            @*<input type="button"  style="Height: 47px;Width: 250px; background-color: #1ab394;border-radius:3px" value="สร้างคำขอใหม่" ng-click="cer_add_lcn_click('../CER_HERB/CER_LCN_ADD', 'active', $index+1)" />*@
            <input type="button" style="Height: 47px;Width: 250px;border-radius:3px" class="btn btn-outline-primary" value="สร้างคำขอใหม่" ng-click="BTN_RENEW_ADD_CLICK()" />
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
                <tr ng-repeat="x in FULL_MODEL.Renew_Tabean">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td hidden="hidden">{{x.STATUS_ID}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.RCVNO_NEW}} </td>
                    <td>{{x.RGTNO_FULL}} </td>
                    <td>{{x.DRUG_NAME}} </td>
                    <td>{{x.STATUS_NAME}} </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" data-toggle="modal" data-backdrop="false" data-target="#Renew_modal" ng-click="BTN_RENEW_DETAIL_CLICK(x.IDA, x.STATUS_ID, x.FK_LCN, x.TR_ID, x.PROCESS_ID,x.FK_IDA,x.STATUS_NAME)" style="color:#0033CC;">รายละเอียด</a>
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
                <div class="modal-footer" ng-if="SET_MAIN_POPUP_PAGE == '../TABEAN_RENEW/Renew_Upload_file'||'../TABEAN_RENEW/Renew_Confirm_Detail'">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary" data-dismiss="modal" ng-click="BTN_SAVE_DATA_RENEW_CLICK(SET_MAIN_POPUP_PAGE)">Save</button>
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

