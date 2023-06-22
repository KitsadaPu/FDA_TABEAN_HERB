<div class="card">
    <div class="row">
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="รายละเอียดกิจกรรม">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col"></th>
                                            <th style="width:70%" scope="col">ชื่อเอกสารแนบ</th>
                                            <th style="width:15%" scope="col">ค่าใช้จ่าย</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="item in FULL_MODEL.FILE_ATTACH">
                                            <td>
                                                <button ng-show="item.FK_ACTIVITY == 0" class="btn btn-success btn-sm float-right" ng-click="add_sub(item,$index+1)"><i class="fas fa-plus"></i></button>
                                            </td>
                                            <td>
                                                <input class="form-inline form-control" ng-model="item.ACTIVITY_NM" />
                                            </td>
                                            <td>
                                                <input hidden ng-model="item.ACTIVITY_BUDGET = item.MONTH10+item.MONTH11+item.MONTH12+item.MONTH1+item.MONTH2+item.MONTH3+item.MONTH4+item.MONTH5+item.MONTH6+item.MONTH7+item.MONTH8+item.MONTH9" />
                                                {{item.MONTH10+item.MONTH11+item.MONTH12+item.MONTH1+item.MONTH2+item.MONTH3+item.MONTH4+item.MONTH5+item.MONTH6+item.MONTH7+item.MONTH8+item.MONTH9 | currency:""}}
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
        <div class="col-md-6">
            <div ng-cloak>
                <md-content>
                    <md-tabs md-dynamic-height md-border-bottom>
                        <md-tab label="รายละเอียดกิจกรรม">
                            <md-content class="md-padding">
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th style="width:10%" scope="col"></th>
                                            <th style="width:70%" scope="col">ชื่อกิจกรรม</th>
                                            <th style="width:5%" scope="col">ลบ</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="item in FULL_MODEL.FILE_ATTACH">
                                            <td>
                                                <button ng-show="item.FK_ACTIVITY == 0" class="btn btn-success btn-sm float-right" ng-click="add_sub(item,$index+1)"><i class="fas fa-plus"></i></button>
                                            </td>
                                            <td>
                                                <input class="form-inline form-control" ng-model="item.DUCUMENT_NAME" />
                                            </td>
                                            <td>
                                                <button class="btn btn-danger btn-sm float-right" ng-click="delete_event($index)"><i class="fas fa-minus-circle"></i></button>
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
