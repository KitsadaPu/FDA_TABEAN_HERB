<div class="card">
    <div class="row">
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="เอกสารแนบคำขอทะเบียน">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col">ลำดับ</th>
                                            <th style="width:40%" scope="col">รายการเอกสาร</th>
                                            <th style="width:40%" scope="col">ชื่อเอกสารที่อัพโหลด</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="item in FULL_MODEL.FILE_ATTACH">
                                            <td>
                                                {{item.index}}
                                            </td>
                                            <td>
                                                {{item.DUCUMENT_NAME}}
                                                @*<input class="form-inline form-control" ng-model="item.DUCUMENT_NAME" />*@
                                            </td>
                                            <td>
                                                <a href="#" ng-click="show_attach_preview(item.NAME_FAKE)">{{item.NAME_REAL}}</a>
                                                @*<input class="form-inline form-control" ng-model="item.NAME_REAL" />*@
                                            </td>
                                            @*<td>
                            <button class="btn btn-danger btn-sm float-right" ng-click="delete_event($index)"><i class="fas fa-minus-circle"></i></button>
                        </td>*@
                                        </tr>
                                    </tbody>
                                </table>
                            </md-content>
                            
                        </md-tab>
                    </md-tabs>
                </md-content>
            </div>
        </div>
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="รายการเอกสารที่แก้ไข">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col">รายการ</th>
                                            <th style="width:40%" scope="col">รายการเอกสาร</th>
                                            <th style="width:40%" scope="col">ชื่อเอกสารที่อัพโหลด</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="x in FULL_MODEL.FILE_ATTACH">
                                            <td>
                                                <input type="checkbox" ng-model="item.VALUVE">
                                            </td>
                                            <td>
                                                {{x.DUCUMENT_NAME}}
                                            </td>
                                            <td>
                                                {{x.NAME_REAL"}}
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </md-content>
                        </md-tab>
                    </md-tabs>
                </md-content>
            </div>
        </div>
    </div>
</div>
