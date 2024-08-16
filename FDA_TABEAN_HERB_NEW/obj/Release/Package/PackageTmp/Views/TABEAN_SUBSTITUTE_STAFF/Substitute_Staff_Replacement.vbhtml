<style type="text/css">
    .auto-style7 {
        width: 314px;
    }

    .auto-style8 {
        width: 369px;
    }

    .footer1 {
        background: #63320e;
        color: #ffffff;
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
<div ng-controller="STAFF_REPLACEMENT_LCN_EDIT" style="padding-left:2em;padding-right:2em">
    <div style="height: 25px;"></div>
    <div class="row">
        <div class="col-md-12" style="text-align:center">
            <h3>ใบรับเรื่องแทนผู้ประกอบการ</h3>
        </div>
    </div>

    <div style="height: 40px;"></div>
    <div class="form-group row">
        @*<div class="col-sm-1"></div>*@
        <label for="NameSearch" class="col-sm-2 col-form-label">ชื่อผู้ประกอบการ:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="NameSearch" ng-model="FULL_MODEL.NAME_SEARCH">
        </div>
    </div>
    <div class="form-group row">
        @*<div class="col-sm-1"></div>*@
        <label for="IdenSearch" class="col-sm-2 col-form-label">เลขนิติบุคคล/เลขบัตรประชาชน:</label>
        <div class="col-sm-4">
            <input type="text" class="form-control" id="IdenSearch" ng-model="FULL_MODEL.IDEN_SEARCH">
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-md-2"></div>
            <div class="col-md-8">
                <button type="button" class="btn btn-outline-primary" style="Height: 40px;Width: 250px;" ng-click="BTN_SEARCH_CUSTOMER()">ค้นหา</button>
                @*<input type="button" style="Height: 47px;Width: 250px; background-color: #1ab394;border-radius:3px" value="ค้นหา" ng-click="BTN_SEARCH_CUSTOMER()" />*@
            </div>
        </div>

        <div style="height: 50px;"></div>
        <div class="row" ng-if="FILE_SEARCH != null">
            <div class="col-md-3">
                <h3>ชื่อผู้ประกอบการ</h3>
            </div>
            <div class="col-md-3" style="text-align:left">
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="table-responsive">
                    <table ng-if="FILE_SEARCH != null && FILE_SEARCH.length != 0" class="table table-striped table-bordered table-hover">
                        <thead>
                            <tr>
                                <th hidden="hidden">IDA</th>
                                <th>ลำดับ</th>
                                <th>ชื่อผู้ประกอบการ</th>
                                <th>เลขนิติบุคคล/เลขบัตรประชาชน</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="x in FILE_SEARCH">
                                <td hidden="hidden">{{x.IDA}} </td>
                                <td>{{x.index}} </td>
                                <td>{{x.fullname}} </td>
                                <td>{{x.IDENTIFY}} </td>
                                <td style="color:#0033CC;text-decoration:underline;">
                                    <a href="#" ng-click="BTN_SELECT_CUSTOMER(x.IDA, x.IDENTIFY, x.fullname, x)" style="color:#0033CC;">เลือก</a>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot></tfoot>
                    </table>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>


        <div style="height: 30px;"></div>
        <div class="form-row" ng-if="CUSTOMER_FILE != null">
            <div class="col-md-3">
                <h3>สถานที่</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="table-responsive">
                    <table ng-if="CUSTOMER_FILE != null && CUSTOMER_FILE.length != 0" class="table table-striped table-bordered table-hover dataTables-example">
                        <thead>
                            <tr>
                                <th hidden="hidden">IDA</th>
                                <th>ลำดับ</th>
                                <th>เลขที่ใบอนุญาต</th>
                                <th>เลขที่ใบอนุญาตใหม่</th>
                                <th>ประเภทใบอนุญาต</th>
                                <th>ชื่อสถานที่หรือชื่อร้าน</th>
                                <th>ที่ตั้ง</th>
                                <th>จังหวัด</th>
                                <th>สถานะใบอนุญาต</th>
                                @*<th>ชื่อผู้ดำเนินกิจการ</th>*@
                                <th>รายละเอียด</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="x in CUSTOMER_FILE">
                                <td hidden="hidden">{{x.IDA}} </td>
                                <td>{{x.index}} </td>
                                <td>{{x.LCNNO_DISPLAY}} </td>
                                <td>{{x.LCNNO_DISPLAY_NEW}} </td>
                                <td>{{x.lcntpcd}} </td>
                                <td>{{x.thanameplace}} </td>
                                <td>{{x.fulladdr}} </td>
                                <td>{{x.thachngwtnm}} </td>
                                <td>{{x.cncnm}} </td>
                                @*<td>{{x.BSN_THAIFULLNAME}} </td>*@
                                <td style="color:#0033CC;text-decoration:underline;">
                                    <a href="#" ng-click="BTN_REPLACE_CLICK(PATH_NAME,PROCESS_ID, x.IDA, x.CITIZEN_ID_AUTHORIZE, x)" style="color:#0033CC;">เลือก</a>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot></tfoot>
                    </table>
                </div>
            </div>
            <div class="col-md-1"></div>
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
        <center>
            <div class="modal fade" id="myModal_PREVIEW" aria-hidden="true" style="display: none;width:100%;text-align:center">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <input type="button" class="btn btn-default pull-right" value="ปิด" data-dismiss="modal" />

                        <div Class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                    @*@Html.Partial("cer_lcn_detail", Nothing)*@
                                </div>
                            </div>
                        </div>

                        <footer class="footer1">
                            <div class="inner">
                                <strong>สำนักงานคณะกรรมการอาหารและยา :</strong> 88/24 ถนนติวานนท์ อำเภอเมือง จังหวัดนนทบุรี 11000 โทรศัพท์ 0-2590-7000
                            </div>
                        </footer>
                    </div>
                </div>
            </div>
        </center>
    </div>


