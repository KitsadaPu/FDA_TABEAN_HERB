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

    .t00 tr:nth-child(even) {
        background-color: #eee;
    }

    .t00 tr:nth-child(odd) {
        background-color: #fff;
    }

    .t00 th {
        background-color: #649173;
        color: white;
        width: auto;
        font-size: 14px;
    }

    .t00 td {
        height: 50px;
        text-align: center;
    }

    .fontlabelimage {
        font-size: 16px;
        color: forestgreen;
    }
</style>
<div ng-controller="LCN_EDIT_ADD">
    <div class="row">
        <div class="col-md-12" style="text-align:center">
            <h2>คำขอแก้ไขเปลี่ยนแปลงใบอนุญาตสมุนไพร</h2>
        </div>
    </div>

    @*<div class="row">
            <div class="col-lg-4"></div>
            <div class="col-lg-3">
                <h2>คำขอแก้ไขรายการในใบอนุญาตฯ</h2>
            </div>
            <div class="col-lg-5"></div>
        </div>*@

    <div class="row">
        <div class="col-lg-4"></div>
        <div class="col-lg-3">
            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-8"><input type="radio" ng-model="FULL_MODEL.dalcn.PROCESS_ID" ng-click="SELECT_LCN_TYPE_RQ(1)" name="LCN_TYPE_RQ" ng-value="122"> &ensp;ผลิตผลิตภัณฆ์สมุนไพร<br></div>
                <div class="col-lg-1"></div>
            </div>
            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-8"><input type="radio" ng-model="FULL_MODEL.dalcn.PROCESS_ID" ng-click="SELECT_LCN_TYPE_RQ(2)" name="LCN_TYPE_RQ" ng-value="121"> &ensp;นำเข้าผลิตภัณฆ์สมุนไพร<br></div>
                <div class="col-lg-1"></div>
            </div>
            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-8"><input type="radio" ng-model="FULL_MODEL.dalcn.PROCESS_ID" ng-click="SELECT_LCN_TYPE_RQ(3)" name="LCN_TYPE_RQ" ng-value="120"> &ensp;ขายผลิตภัณฆ์สมุนไพร<br></div>
                <div class="col-lg-1"></div>
            </div>
            @*<asp:RadioButtonList ID="rdl_lcn_type" runat="server" BorderStyle="None" Enabled="False">
                    <asp:ListItem Value="1">ผลิตผลิตภัณฆ์สมุนไพร</asp:ListItem>
                    <asp:ListItem Value="2">นำเข้าผลิตภัณฆ์สมุนไพร</asp:ListItem>
                    <asp:ListItem Value="3">ขายผลิตภัณฆ์สมุนไพร</asp:ListItem>
                </asp:RadioButtonList>*@
        </div>
        <div class="col-lg-5"></div>
    </div>
    <div>
        <br />
    </div>
    <div>
        <br />
    </div>
    <div></div>

    <div class="row">
        <div class="col-lg-1" style="text-align: right;"></div>
        <div class="col-lg-2">ข้าพเจ้า :</div>
        <div class="col-lg-2">
            @*<input id="txt_sub_name" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.tha_fullname" readonly />*@
            <input id="txt_sub_name" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.tha_fullname" readonly class="form-control-plaintext" />
            @*<asp:TextBox ID="txt_sub_name" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">(ชื่อผู้รับอนุญาต)</div>
        <div class="col-lg-5"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">ซึ้งมีผู้มีดำเนินกิจการชื่อ :</div>
        <div class="col-lg-2">
            <input id="txt_bsn_name" type="text" style="width:100%" ng-model="FULL_MODEL.DALCN_LOCATION_BSN.BSN_THAIFULLNAME" readonly class="form-control-plaintext" />
            @*<asp:TextBox ID="txt_bsn_name" runat="server" BorderColor="Lime" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-5"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">ซึ้งมีผู้มีหน้าที่ปฏิบัติการชื่อ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_phr_name" type="text" style="width:100%" ng-model="FULL_MODEL.DALCN_PHR.PHR_NAME" readonly class="form-control-plaintext" />
            @*<asp:TextBox ID="txt_sub_phr_name" runat="server" BorderColor="Lime" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">(เฉพาะกรณีนิติบุคคล)</div>
        <div class="col-lg-5"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">เลขประจำตัวประชาชน/ใบอนุญาตทำงานเลขที่ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_iden" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.identify" readonly class="form-control-plaintext" />
            @*<asp:TextBox ID="txt_sub_iden" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-7"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">ตามใบอนุญาตเลขที่ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_lcnno" type="text" style="width:100%" ng-model="FULL_MODEL.dalcn.LCNNO_DISPLAY_NEW" readonly />
            @*<asp:TextBox ID="txt_sub_lcnno" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">ณ สถานที่ประกอบธุรกิจชื่อ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_location" type="text" style="width:100%" ng-model="FULL_MODEL.dalcn.LOCATION_ADDRESS_thanameplace" readonly />
            @*<asp:TextBox ID="txt_sub_location" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">อยู่เลขที่ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_addr" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.thaaddr" readonly />
            @*<asp:TextBox ID="txt_sub_addr" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">หมู่บ้าน/อาคาร :</div>
        <div class="col-lg-2">
            <input id="txt_sub_building" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.building" readonly />
            @*<asp:TextBox ID="txt_sub_building" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">หมู่ที่ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_mu" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.mu" readonly />
            @*<asp:TextBox ID="txt_sub_mu" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">ตรอก/ซอย :</div>
        <div class="col-lg-2">
            <input id="txt_sub_soi" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.thasoi" readonly />
            @*<asp:TextBox ID="txt_sub_soi" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">ถนน :</div>
        <div class="col-lg-2">
            <input id="txt_sub_road" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.tharoad" readonly />
            @*<asp:TextBox ID="txt_sub_road" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">ตำบล/แขวง :</div>
        <div class="col-lg-2">
            <input id="txt_sub_tambol" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.thmblnm" readonly />
            @*<asp:TextBox ID="txt_sub_tambol" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">อำเภอ/เขต :</div>
        <div class="col-lg-2">
            <input id="txt_sub_name" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.amphrnm" readonly />
            @*<asp:TextBox ID="txt_sub_amphor" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">จังหวัด :</div>
        <div class="col-lg-2">
            <input id="txt_sub_changwat" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.chngwtnm" readonly />
            @*<asp:TextBox ID="txt_sub_changwat" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">รหัสไปรษณีย์ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_name" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.zipcode" readonly />
            @*<asp:TextBox ID="txt_sub_zipcode" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-2">โทรศัพท์ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_tel" type="text" style="width:100%" ng-model="FULL_MODEL.CLS_ADDR.tel" readonly />
            @*<asp:TextBox ID="txt_sub_tel" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-3"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-2">เวลาทำการ :</div>
        <div class="col-lg-2">
            <input id="txt_sub_opentime" type="text" style="width:100%" ng-model="FULL_MODEL.dalcn.opentime" readonly />
            @*<asp:TextBox ID="txt_sub_opentime" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>*@
        </div>
        <div class="col-lg-7"></div>
    </div>

    <div style="height: 15px;"></div>
    <div class="row" ng-hide="(STATUS_TYPE_RQ == 1)">
        <div class="col-lg-1"></div>
        <div class="col-lg-10" style="text-align:left;color:red" ng-hide="(STATUS_TYPE_RQ == 1)">
            *กรุณาเลือกรูปแบบคำขอ เพื่อแนบเอกสารประกอบคำขอฯ
        </div>
        <div class="col-lg-1"></div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-10" style="padding-left:2em">
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="1" ng-value="1" id="check_main_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_1" ng-click="select_input(1)" >
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยน/เพิ่ม/ถอน/แจ้งเปลี่ยนหน้าที่ ผู้มีหน้าที่ปฏิบัติการ
                </label>
            </div>

            <div class="form-check" data-toggle="modal" data-target="#LOCATION_MODAL">
                <input class="form-check-input" type="checkbox" value="2" id="check_main_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_2" ng-click="select_input(2)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีย้ายสถานที่/เพิ่มสถานที่/ลดขยายสถานที่
                </label>
            </div>

            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_2 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" ng-value="1" id="check_sub_main_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_1" ng-click="select_input_sub_2_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีที่ผู้ขอรับอนุญาตเป็นเจ้าของกรรมสิทธิ์
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" ng-value="1" id="check_sub_main_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_2" ng-click="select_input_sub_2_2()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีที่ผู้ขอรับอนุญาตไม่ได้เป็นเจ้าของกรรมสิทธิ์
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" ng-value="1" id="check_sub_main_3" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_3" ng-click="select_input_sub_2_3()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีทะเบียนบ้านไม่มีผู้อยู่อาศัย (ทะเบียนบ้านลอย) ใช้เอกสารอย่างใดอย่างหนึ่ง ดังนี้
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" ng-value="1" id="check_sub_main_4" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_2_4" ng-click="select_input_sub_2_4()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณี ขอใบอนุญาตผลิตฯ มีเอกสารเพิ่มเติม ดังต่อไปนี้
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="3" ng-value="3" id="check_main_3" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_3" ng-click="select_input(3)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนผู้ดำเนินกิจการ (นิติบุคคล)
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_3 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" data-toggle="modal" data-target="#BSN_MODAL" id="check_sub_main_3_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_1" ng-click="select_input_sub_3_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            นิติบุคคล
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="2" data-toggle="modal" data-target="#BSN_MODAL" id="check_sub_main_3_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_3_2" ng-click="select_input_sub_3_2()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีที่ผู้ขอรับอนุญาตไม่ได้เป็นเจ้าของกรรมสิทธิ์
                        </label>
                    </div>
                </div>
            </div>

            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="4" ng-value="4" id="check_main_4" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_4" ng-click="select_input(4)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนเวลาทำการ
                </label>
            </div>

            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="5" id="check_main_5" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_5" ng-change="check_input" ng-click="select_input(5)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนเบอร์โทรศัพท์/ยกเลิกหมวดผลิตภัณฑ์สมุนไพร
                </label>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="6" id="check_main_6" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_6" ng-click="select_input(6)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนหมายเลขบ้าน/รายละเอียดของสถานที่ตั้ง
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_6 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_6_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_6_1" ng-click="select_input_sub_6_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีเปลี่ยนหมายเลขบ้าน/รายละเอียดของสถานที่ตั้ง
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="7" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_7" ng-click="select_input(7)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนคำนำหน้า/ชื่อตัว/ชื่อสกุล/ ของผู้รับอนุญาต ผู้มีหน้าที่ปฏิบัติการ ผู้ดำเนินกิจการ
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_7 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_7_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_1" ng-click="select_input_sub_7_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีผู้รับอนุญาต/ผู้ดำเนินกิจการ/ เปลี่ยนคำนำหน้า/ชื่อตัว/ชื่อสกุล
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="2" id="check_sub_main_7_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_7_2" ng-click="select_input_sub_7_2()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีผู้มีหน้าที่ปฏิบัติการเปลี่ยนคำนำหน้า/ชื่อตัว/ชื่อสกุล
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="8" id="check_main_8" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_8" ng-click="select_input(8)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีเปลี่ยนชื่อร้าน/ชื่อสถานที่ขายฯ/นำสั่ง/ผลิตฯ (บุคคลธรรมดา/นิติบุคคล/แปรสภาพ)
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_8 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_8_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_1" ng-click="select_input_sub_8_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีนิติบุคคล
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="2" id="check_sub_main_8_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_8_2" ng-click="select_input_sub_8_2()">
                        <label class="form-check-label" for="defaultCheck1">
                            บุคคลธรรมดา
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="9" id="check_main_9" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_9" ng-click="select_input(9)">
                <label class="form-check-label" for="defaultCheck1">
                    กรณีสืบสิทธิ์แทนผู้รับอนุญาตที่เสียชีวิต แต่ไม่เกิน 90 วัน
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_9 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_9_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_1" ng-click="select_input_sub_9_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            บุคคลธรรมดา
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="2" id="check_sub_main_9_2" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_2" ng-click="select_input_sub_9_2()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีบุคคลต่างด้าว
                        </label>
                    </div>
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="3" id="check_sub_main_9_3" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_9_3" ng-click="select_input_sub_9_3()">
                        <label class="form-check-label" for="defaultCheck1">
                            เอกสารของผู้มีหน้าที่ปฏิบัติการ
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="10" id="check_main_10" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_10" ng-click="select_input(10)">
                <label class="form-check-label" for="defaultCheck1">
                    เพิ่มประเภทการผลิต (สถานที่ผลิตผลิตภัณฑ์สมุนไพร)
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_10 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_10_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_10_1" ng-click="select_input_sub_10_1()">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีสถานที่ผลิตผลิตภัณฑ์สมุนไพร
                        </label>
                    </div>
                </div>
            </div>
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="11" id="check_main_11" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_11" ng-click="select_input(11)">
                <label class="form-check-label" for="defaultCheck1">
                    เพิ่มรายการผลิตผลิตภัณฑ์สมุนไพรที่ขออนุญาตนำเข้าหรือขาย
                </label>
            </div>
            <div class="row" ng-show="(FULL_MODEL.TYPE_EDIT_REQUEST.Main_check_11 == true)" style="padding-left:2em">
                <div class="col-lg-10">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" value="1" id="check_sub_main_11_1" ng-model="FULL_MODEL.TYPE_EDIT_REQUEST.Sub_check_11_1" ng-click="select_input_sub_11_1(16)">
                        <label class="form-check-label" for="defaultCheck1">
                            กรณีนำเข้าและขาย
                        </label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10">
            <div class="form-group">
                <label for="exampleFormControlTextarea1">เหตุผลการขอแก้ไขใบอนุญาต :</label>
                <textarea class="form-control" id="exampleFormControlTextarea1" rows="3" ng-model="FULL_MODEL.lcn_edit.NOTE_REASON"></textarea>
            </div>
        </div>
    </div>

    <div class="modal fade" id="LCN_EDIT_MODAL" tabindex="-1" role="dialog" aria-labelledby="TitleLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title" id="TitleLabel">-</h3>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div ng-include="SET_MAIN_POPUP_PAGE" style="padding-left:45px;">
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary" data-dismiss="modal">Save</button>
                </div>
            </div>
        </div>
    </div>

    <div style="height: 15px;"></div>
    <div class="row">
        <div class="col-sm-12 " style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_BACK_PAGE()" value="ย้อนกลับ" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="button" class="btn btn-lg btn-success" ng-click="BTN_SAVE_DATA_CLICK()" value="บันทึก" />
        </div>
    </div>
</div>



