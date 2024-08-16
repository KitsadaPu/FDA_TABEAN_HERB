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
<div ng-controller="LCN_EDIT_STAFF">
    <div class="row">
        <div class="col-md-12" style="text-align:center">
            <h3>คำขอแก้ไขเปลี่ยนแปลงใบอนุญาตสมุนไพร</h3>
        </div>
    </div>

    <div style="height: 15px;"></div>
    <div style="height: 15px;"></div>

    <div class="table-responsive">
        <table ng-if="lcn_edit_staff != null && lcn_edit_staff.length != 0" class="table table-striped table-bordered table-hover dataTables-example" id="tb_lcn_staff">
            <thead>
                <tr>
                    <th hidden="hidden">IDA</th>
                    <th>ลำดับ</th>
                    <th>เลขที่ใบอนุญาตใหม่</th>
                    <th>เลขดำเนินการ</th>
                    <th>ชื่อสถานที่</th>
                    <th>เหตุผลการขอแก้ไขใบอนุญาต</th>
                    <th>เลขรับคำขอ</th>
                    <th>สถานะใบอนุญาต</th>
                    <th>รายละเอียด</th>
                    <th>ดูรายละเอียดการแก้ไข</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="x in lcn_edit_staff">
                    <td hidden="hidden">{{x.IDA}} </td>
                    <td hidden="hidden">{{x.STATUS_ID}} </td>
                    <td>{{x.index}} </td>
                    <td>{{x.LCNNO}} </td>
                    <td>{{x.TR_ID}} </td>
                    <td>{{x.LCN_NAME}} </td>
                    <td>{{x.LCN_EDIT_REASON_NAME}} </td>
                    <td>{{x.RCVNO_DISPLAY}} </td>
                    <td>{{x.STATUS_NAME}} </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" ng-click="BTN_STAFF_MENU_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID,x.datas)" style="color:#0033CC;">รายละเอียด</a>
                    </td>
                    <td style="color:#0033CC;text-decoration:underline;">
                        <a href="#" ng-click="BTN_STAFF_DETAIL_EDIT_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID,x.datas)" style="color:#0033CC;">ดูรายละเอียดการแก้ไข</a>
                    </td>
                    @*<td style="color:#0033CC;text-decoration:underline;">
            <a href="#" ng-show="(x.language_thai_id == 'True' &&  x.STATUS_ID == 8 || x.STATUS_ID == 6 || x.STATUS_ID == 13)" ng-click="BTN_STAFF_LANGUEGE1_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID, 1)" style="color:#0033CC;">ภาษาไทย</a>
            <br ng-show="(x.language_thai_id == 'True' &&  x.STATUS_ID == 8  || x.STATUS_ID == 6 || x.STATUS_ID == 13)" />
            <a href="#" ng-show="(x.language_eng_id == 'True' && x.STATUS_ID == 8  || x.STATUS_ID == 6 || x.STATUS_ID == 13)" ng-click="BTN_STAFF_LANGUEGE2_CLICK(x.IDA, x.STATUS_ID, x.FK_IDA_LCN, x.TR_ID, 2)" style="color:#0033CC;">ภาษาอังกฤษ</a>
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
    <div class="modal fade" id="myModal_PREVIEW" aria-hidden="true" style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <input type="button" class="btn btn-default pull-right" value="ปิด" data-dismiss="modal" />
                <header class="header header1">
                    <div class="inner inner1">

                        <div class="title-header">
                            <span class="circle"></span>
                            <div class="media-body">
                                <div class="row">
                                    <div class="col-md-12" style="text-align:center">
                                        @*<img src="../DESIGN_DETAIL/imgs/logo@2x.png" style="width:80px;height:80px;text-align:left;" />*@
                                        <h3>ตรวจสอบสถานที่สมุนไพร</h3>
                                        <span style="font-size:12pt;margin-left: 3%;">สำนักงานคณะกรรมการอาหารและยา กระทรวงสาธารณสุข</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </header>

            </div>
        </div>
    </div>
    <div Class="modal fade" id="myModal2" style="padding-left: 17px;">

        <div Class="modal-dialog modal-lg" style="width:100%;">
            <div Class="modal-content">
                <div Class="modal-header">
                    <h3 Class="modal-title"> </h3>
                    <Button type="button" Class="btn btn-secondary" data-dismiss="modal">&times;</Button>
                </div>
                <div Class="modal-body">
                    <div ng-include="SET_MAIN_POPUP_PAGE" style="padding-left:45px;">

                    </div>

                </div>
            </div>
        </div>
    </div>


    <div Class="modal fade" id="myModal_lcn_staff" style="padding-left: 17px;">

        <div Class="modal-dialog modal-lg" style="width:100%;">
            <div Class="modal-content">
                <div Class="modal-header">
                    <h3 Class="modal-title"> </h3>
                    <Button type="button" Class="btn btn-secondary" data-dismiss="modal">&times;</Button>
                </div>
                <div Class="modal-body">
                    <div ng-include="SET_MAIN_POPUP_PAGE" style="padding-left:45px;">

                    </div>

                </div>
            </div>
        </div>
    </div>
    <footer class="footer1">
        <div class="inner">
            <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
        </div>
    </footer>
</div>

