<style>
    .dot {
        height: 8px;
        width: 8px;
        background-color: #f7a54a;
        border-radius: 50%;
        display: inline-block;
    }
</style>
<form>
    <div class="row">
        <div class="col-sm-8">
            <iframe id='iframe1' style='height:1100px;width:100%;margin-left:10px;' src="{{PDF_VIEW}}"></iframe>
        </div>
        <div class="col-sm-4">
            <div class="card">
                <div class="card-header">
                    <ul class="nav nav-tabs card-header-tabs">
                        <li class="nav-item" role="presentation">
                            <button class="nav-link active" id="home-tab" data-toggle="tab" data-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true" ng-click="SELECT_PAGR(1)">อัพเดทข้อมูล</button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="profile-tab" data-toggle="tab" data-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false" ng-click="SELECT_PAGR(2)">ประวัติ</button>
                        </li>
                    </ul>
                </div>
                <div class="card-body tab-content">
                    <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab" @*ng-show="Page == 1"*@>
                        @Html.Partial("../TABEAN_RENEW_STAFF/Renew_Staff_Update_Status")
                    </div>
                    <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab" @*ng-show="Page == 2"*@>
                        @Html.Partial("../TABEAN_RENEW_STAFF/Renew_Staff_Log_Status")
                    </div>
                </div>
            </div>
            <br />
            <div class="card border-dark mb-3" ng-if="FULL_MODEL.FILE_ATTACH != null">
                <div class="card-header text-monospace" id="AAN" aria-describedby="AANConHelp">เอกสารแนบ</div>
                <small id="AANConHelp" class="form-text text-muted" style="padding-left:2em"><span class="dot"></span> เอกสารที่ส่งแก้ไข</small>
                <div class="card-body text-dark">
                    <div class="table-responsive">
                        <table ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0" class="table-striped" id="tb_msa_cuia_staff">
                            <thead>
                                <tr>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH" style="font-size:12px">
                                    <td hidden="hidden">{{x.IDA}} </td>
                                    <td>{{x.index}} </td>
                                    <td>{{x.Document_Name}} </td>
                                    <td style="color:{{x.EditTypeFile >= 1 ? '#f7a54a' : 'green' }}">{{x.NAME_REAL}} </td>
                                    <td>
                                        <a href="#" ng-click="show_attach_preview(x.IDA)" style="color:#0033CC;">ดูข้อมูล</a>
                                        @*<p>ดูข้อมูล<span style="color:green"><a href="#" ng-click="show_attach_preview(x.NAME_FAKE)"></a></span></p>*@
                                    </td>
                                </tr>
                            </tbody>
                            <tfoot></tfoot>
                        </table>
                    </div>
                </div>
                <!--<div class="form-group" ng-if="FULL_MODEL.FILE_ATTACH != null">
                <strong><label for="tb_msa_cuia_staff" id="AAN" class="text-monospace" aria-describedby="AANConHelp"></label></strong>-->
                @*<span class="dot"></span><span style="font-size:small">เอกสารที่ส่งแก้ไข</span>*@

                <!--<div class="table-responsive">
                <table ng-if="FULL_MODEL.FILE_ATTACH != null && FULL_MODEL.FILE_ATTACH.length != 0" class="table-striped" id="tb_msa_cuia_staff">
                    <thead>
                        <tr>
                        </tr>
                    </thead>
                    <tbody>
                        <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH" style="font-size:12px">
                            <td hidden="hidden">{{x.IDA}} </td>
                            <td>{{x.index}} </td>
                            <td>{{x.Document_Name}} </td>
                            <td style="color:{{x.EditTypeFile >= 1 ? '#f7a54a' : 'green' }}">{{x.NAME_REAL}} </td>
                            <td>
                                <a href="#" ng-click="show_attach_preview(x.IDA)" style="color:#0033CC;">ดูข้อมูล</a>-->
                @*<p>ดูข้อมูล<span style="color:green"><a href="#" ng-click="show_attach_preview(x.NAME_FAKE)"></a></span></p>*@
                <!--</td>
                                </tr>
                            </tbody>
                            <tfoot></tfoot>
                        </table>
                    </div>
                </div>-->
            </div>
        </div>
    </div>
</form>
